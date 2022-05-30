﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace QueryFormatUtility.Classes
{

    /// <summary>
    /// https://gist.github.com/actaneon/301752
    /// Implements a <see cref="TextWriter"/> for writing information to the debugger log.
    /// </summary>
    /// <seealso cref="Debugger.Log"/>
    public class DebuggerWriter : TextWriter
    {
        private bool isOpen;
        private static UnicodeEncoding encoding;
        private readonly int level;
        private readonly string category;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebuggerWriter"/> class.
        /// </summary>
        public DebuggerWriter() : this(0, Debugger.DefaultCategory)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebuggerWriter"/> class with the specified level and category.
        /// </summary>
        /// <param name="level">A description of the importance of the messages.</param>
        /// <param name="category">The category of the messages.</param>
        public DebuggerWriter(int level, string category) : this(level, category, CultureInfo.CurrentCulture)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebuggerWriter"/> class with the specified level, category and format provider.
        /// </summary>
        /// <param name="level">A description of the importance of the messages.</param>
        /// <param name="category">The category of the messages.</param>
        /// <param name="formatProvider">An <see cref="IFormatProvider"/> object that controls formatting.</param>
        public DebuggerWriter(int level, string category, IFormatProvider formatProvider) : base(formatProvider)
        {
            this.level = level;
            this.category = category;
            this.isOpen = true;
        }

        protected override void Dispose(bool disposing)
        {
            isOpen = false;
            base.Dispose(disposing);
        }

        public override void Write(char value)
        {
            if (!isOpen)
            {
                throw new ObjectDisposedException(null);
            }

            Debugger.Log(level, category, value.ToString());
        }

        public override void Write(string value)
        {
            if (!isOpen)
            {
                throw new ObjectDisposedException(null);
            }

            if (value != null)
            {
                Debugger.Log(level, category, value);
            }
        }

        public override void Write(char[] buffer, int index, int count)
        {
            if (!isOpen)
            {
                throw new ObjectDisposedException(null);
            }

            if (buffer == null || index < 0 || count < 0 || buffer.Length - index < count)
            {
                base.Write(buffer, index, count); // delegate throw exception to base class
            }

            Debugger.Log(level, category, new string(buffer, index, count));
        }

        public override Encoding Encoding => encoding ??= new UnicodeEncoding(false, false);

        public int Level => level;

        public string Category => category;
    }
}

