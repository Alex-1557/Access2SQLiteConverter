Partial Module Module1

    Dim CalibDataList As List(Of CalibData)
    Dim CardDataList As List(Of CardData)
    Dim ControlDataList As List(Of ControlData)
    Dim CoreDataList As List(Of CoreData)
    Dim GaugeDataList As List(Of GaugeData)
    Dim RecipeDataList As List(Of RecipeData)
    Dim SignalDataList As List(Of SignalData)
    Dim SpcDataList As List(Of SpcData)
    Dim ViewDataList As List(Of ViewData)
    Dim PrivList As List(Of Priv)
    Dim CN1 As System.Data.OleDb.OleDbConnection
    Dim CN2 As System.Data.SQLite.SQLiteConnection

    Sub Main(PRM As String())

        Console.WriteLine("AtiConverter use Microsoft Provider for Access https://www.microsoft.com/en-us/download/details.aspx?id=54920")

        If PRM.Count = 2 Then
            Try
                Dim AccessCN As String = My.Settings.ACE.Replace("@@@", PRM(0))
                CN1 = New OleDb.OleDbConnection(AccessCN)
                CN1.Open()
                AccessRead()

                My.Computer.FileSystem.WriteAllBytes(PRM(1), My.Resources.ATI_Empty, False)
                Dim SQLiteCN As String = My.Settings.SQLite.Replace("@@@", PRM(1))
                CN2 = New System.Data.SQLite.SQLiteConnection(SQLiteCN)
                CN2.Open()
                SqliteWrite()

                CN1.Close()
                CN2.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
        Else
            Console.WriteLine("Usage: AtiConverter PathToAccessDB.accdb PathToSqlite.db")
        End If
    End Sub
End Module

'connection Access 32/64
'https://www.connectionstrings.com/access/ 'Datadirectory
'https://stackoverflow.com/questions/1991643/microsoft-jet-oledb-4-0-provider-is-not-registered-on-the-local-machine
'https://www.microsoft.com/en-us/download/details.aspx?id=13255
' Exception
'The 'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine.
'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Projects\ATI\Access\RtgNtDat.mdb;Persist Security Info=False;