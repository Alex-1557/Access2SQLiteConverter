Imports System.Data.Common
Public Module RawSqlQuery
    <Runtime.CompilerServices.Extension>
    Public Function RawSqlQuery(Of T)(Connection As OleDb.OleDbConnection, ByVal SqlQuery As String, ByVal RowMapperFunc As Func(Of OleDb.OleDbDataReader, T), Optional NeedPrint As Boolean = True) As List(Of T)
        Try
            If NeedPrint Then
                Dim Prop1 = GetType(T).GetProperties()
                Dim Res1 As New List(Of String)
                Prop1.ToList.ForEach(Sub(Y) Res1.Add(Y.Name))
                Console.WriteLine(String.Join("#", Res1))
            End If

            Using Command = New OleDb.OleDbCommand
                Command.CommandText = SqlQuery
                Command.CommandType = CommandType.Text
                Command.Connection = Connection

                Using RDR = Command.ExecuteReader()
                    Dim ResultList = New List(Of T)()

                    While RDR.Read()

                        Dim X = RowMapperFunc(RDR)
                        ResultList.Add(X)

                        If NeedPrint Then
                            Dim Prop2 = X.GetType().GetProperties()
                            Dim Res2 As New List(Of String)
                            Prop2.ToList.ForEach(Sub(Y)
                                                     If Y.PropertyType.Name = "Byte[]" Then
                                                         Res2.Add("*BYTE ARRAY*")
                                                     Else
                                                         Res2.Add(Y.GetValue(X, Nothing))
                                                     End If

                                                 End Sub)
                            Console.WriteLine(String.Join("#", Res2))
                        End If

                    End While

                    Return ResultList
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($" Error: {ex.Message} : in {SqlQuery}")
            Return Nothing
        End Try
    End Function

End Module
