Imports System.IO

Namespace Extensions

    Module ResourceExtensions
        <Runtime.CompilerServices.Extension()>
        Public Sub FileSave(BytesToWrite() As Byte, FileName As String)

            If File.Exists(FileName) Then
                File.Delete(FileName)
            End If

            Dim FileStream As New FileStream(FileName, FileMode.OpenOrCreate)
            Dim BinaryWriter As New BinaryWriter(FileStream)

            BinaryWriter.Write(BytesToWrite)
            BinaryWriter.Close()
            FileStream.Close()

        End Sub
    End Module
End Namespace