using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace LoginConsoleApp.Classes
{
    /// <summary>
    /// Serializer to encrypt/decrypt objects using AES.
    /// </summary>
    /// <typeparam name="T">Type of object to serialize/deserialize.</typeparam>
    public class CryptoSerializer<T>
    {
        private readonly byte[] _secretKey;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="secretKey">
        /// Secret key. Legal AES keys are 16, 24, or 32 bytes long.
        /// </param>
        public CryptoSerializer(byte[] secretKey)
        {
            _secretKey = secretKey;
        }

        /// <summary>
        /// Serialization callback that can be registered with 
        /// a cache using CacheBuilder.SetSerialization
        /// </summary>
        public void Serialize(List<T> obj, Stream stream)
        {
            // The first 16 bytes of the serialized stream is the 
            // AES initialization vector. (An IV does not need to be
            // secret, but the same IV should never be used twice with
            // the same key.)
            byte[] iv = GenerateRandomBytes(16);
            stream.Write(iv, 0, 16);

            using AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = _secretKey;
            aes.IV = iv;

            CryptoStream cryptoStream = new(stream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            // Using protobuf-net for serialization
            // (but any serializer can be used to write to this CryptoStream).
            ProtoBuf.Serializer.Serialize(cryptoStream, obj);

            cryptoStream.FlushFinalBlock();
        }

        /// <summary>
        /// Deserialization callback that can be registered with 
        /// a cache using CacheBuilder.SetSerialization
        /// </summary>
        public List<T> Deserialize(Stream stream)
        {
            // First 16 bytes is the initialization vector.
            byte[] iv = new byte[16];
            stream.Read(iv, 0, 16);

            using AesCryptoServiceProvider aes = new();
            aes.Key = _secretKey;
            aes.IV = iv;

            CryptoStream cryptoStream = new(stream, aes.CreateDecryptor(), CryptoStreamMode.Read);

            return ProtoBuf.Serializer.Deserialize<List<T>>(cryptoStream);
        }

        // This RNG is thread safe. Used to generate IV.
        private static readonly RNGCryptoServiceProvider rng = new ();

        private static byte[] GenerateRandomBytes(int length)
        {
            byte[] randomBytes = new byte[length];
            rng.GetBytes(randomBytes);
            return randomBytes;
        }
    }
}
