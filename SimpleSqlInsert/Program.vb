Imports System.Data
Imports System.Data.SqlClient

Module Program
    Sub Main()

        Dim address As New Address() With {
                    .StreetNumber = 111,
                    .StreetName = "Pine St",
                    .StreetType = StreetType.Commercial,
                    .Toilets = 2
                }

        Dim result As (success As Boolean, exception As Exception) = SqlOperations.InsertRecord(address)

        If result.success Then
            ' Insert successful and the Id is populated
        Else
            ' failed, examine exception
        End If
    End Sub

End Module

Public Class Address
    Public Property Id() As Integer
    Public Property StreetNumber() As Integer
    Public Property StreetName() As String
    Public Property StreetType() As StreetType
    Public ReadOnly Property StreetFull() As String
        Get
            Return $"{StreetNumber} {StreetName} {StreetType}"
        End Get
    End Property
    Public Property Toilets() As Integer
End Class

Public Enum StreetType
    Residential
    Commercial
End Enum


Public Class SqlOperations
    Private Const ConnectionString As String = "TODO"

    Public Shared Function InsertRecord(address As Address) As (success As Boolean, exception As Exception)

        Dim statement =
                <SQL>
                    INSERT INTO myTable(Address,Toilets)   
                    VALUES(@address,@toilets); 
                    SELECT CAST(scope_identity() AS int);
                </SQL>.Value

        Using cn = New SqlConnection(ConnectionString)
            Using cmd = New SqlCommand With {.Connection = cn, .CommandText = statement}

                cmd.Parameters.Add("@address", SqlDbType.NChar).Value = address.StreetFull
                cmd.Parameters.Add("@toilets", SqlDbType.Int).Value = address.Toilets

                Try
                    cn.Open()

                    address.Id = Convert.ToInt32(cmd.ExecuteScalar())

                    Return (True, Nothing)

                Catch ex As Exception
                    Return (False, ex)
                End Try

            End Using
        End Using
    End Function

End Class
