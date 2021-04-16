Imports MySql.Data.MySqlClient
Public Class alltodolist
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub alltodolist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call Populate_ListView()
    End Sub
    Public Sub Populate_ListView()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim n As Integer
        Dim i As Integer
        Dim calls As Integer
        sql = "SELECT * FROM `todo`"

        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader
        ListView1.Clear()
        n = 0
        calls = reader.FieldCount
        Do While reader.Read
            ListView1.Items.Add(n)
            For i = 0 To calls - 1
                ListView1.Items(n).SubItems.Add(reader(i))

            Next



            n += 1
        Loop
        ' We have set listview properties
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.MultiSelect = True
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        'set column headers
        ListView1.Columns.Add("SN")



        For i = 0 To calls - 1
            ListView1.Columns.Add(reader.GetName(i))
        Next

        reader.Close()
    End Sub
    Public Sub Connect()
        Dim ConString As String
        ConString = "server=localhost;uid=root;pwd=;database=personaldata"

        Try
            con.ConnectionString = ConString
            con.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class