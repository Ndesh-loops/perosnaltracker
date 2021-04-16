Imports MySql.Data.MySqlClient
Public Class todolist
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim listno As String
    Dim moduler As String
    Dim taskname As String
    Dim related As String
    Dim timeAllocated As String
    Dim benefit As String
    Dim category As String
    Dim priority As String
    Dim cmd As MySqlCommand
    Private Sub todolist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sql = "SELECT `listno`,`name`,`module`, `related`, `timeallocated`, `benefit`, `priority`, `category`, `date` FROM `todo`"

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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim sql As String
        Dim cmd As MySqlCommand

        sql = "insert into todo(name,module,related,timeallocated,benefit,priority,category) values(@name,@module,@related,@timeallocated,@benefit,@priority,@category)"
        Call Populating()
        cmd = New MySqlCommand(sql, con)
        'cmd.Parameters.AddWithValue("studentnumber", studentnumber)
        cmd.Parameters.AddWithValue("@name", taskname)
        cmd.Parameters.AddWithValue("@module", moduler)
        cmd.Parameters.AddWithValue("@related", related)
        cmd.Parameters.AddWithValue("@timeallocated", timeAllocated)
        cmd.Parameters.AddWithValue("@benefit", benefit)
        cmd.Parameters.AddWithValue("@priority", priority)
        cmd.Parameters.AddWithValue("@category", category)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("New item succesfully added", vbInformation)
            Call Reset()
            Call Populate_ListView()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Reset()

        TnameTextBox.Text = ""
        ListnoTextBox.Text = ""
        ModuleComboBox.Text = ""
        RelatedTextBox.Text = ""
        TimeTextBox.Text = ""
        BenefitTextBox.Text = ""
        PriorityComboBox.Text = ""
        CategoryComboBox.Text = ""

    End Sub

    Private Sub Populating()

        listno = ListnoTextBox.Text
        taskname = TnameTextBox.Text
        moduler = ModuleComboBox.Text
        related = RelatedTextBox.Text
        timeAllocated = TimeTextBox.Text
        benefit = BenefitTextBox.Text
        priority = PriorityComboBox.Text
        category = CategoryComboBox.Text

    End Sub

    Private Sub SaveButton_MouseEnter(sender As Object, e As EventArgs) Handles SaveButton.MouseEnter
        SaveButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub SaveButton_MouseLeave(sender As Object, e As EventArgs) Handles SaveButton.MouseLeave
        SaveButton.ForeColor = Color.White
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Call Reset()
        ListView1.Clear()
    End Sub

    Private Sub NewButton_MouseEnter(sender As Object, e As EventArgs) Handles NewButton.MouseEnter
        NewButton.ForeColor = Color.CornflowerBlue
    End Sub

    Private Sub NewButton_MouseLeave(sender As Object, e As EventArgs) Handles NewButton.MouseLeave
        NewButton.ForeColor = Color.White
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim sql As String
        Dim cmd As MySqlCommand
        listno = ListnoTextBox.Text
        sql = "DELETE FROM todo WHERE listno=" & listno
        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Task aborted successfully", vbInformation)
            Call Populate_ListView()
            Call Reset()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DeleteButton_MouseEnter(sender As Object, e As EventArgs) Handles DeleteButton.MouseEnter
        DeleteButton.ForeColor = Color.Red
    End Sub

    Private Sub DeleteButton_MouseLeave(sender As Object, e As EventArgs) Handles DeleteButton.MouseLeave
        DeleteButton.ForeColor = Color.Firebrick
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.Black
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.MediumAquamarine
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        Dim sql As String
        Dim cmd As MySqlCommand
        listno = ListnoTextBox.Text
        sql = "Update todo set name=@name,listno=@listno,module=@module,related=@related,timeallocated=@timeallocated,benefit=@benefit,priority=@priority,category=@category where listno=@listno"
        Call Populating()
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("listno", listno)
        cmd.Parameters.AddWithValue("@name", taskname)
        cmd.Parameters.AddWithValue("@module", moduler)
        cmd.Parameters.AddWithValue("@related", related)
        cmd.Parameters.AddWithValue("@timeallocated", timeAllocated)
        cmd.Parameters.AddWithValue("@benefit", benefit)
        cmd.Parameters.AddWithValue("@priority", priority)
        cmd.Parameters.AddWithValue("@category", category)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Item succesfully updated", vbInformation)
            Call Reset()
            Call Populate_ListView()

        Catch ex As Exception
            MsgBox("Kindly Click again to confirm alteration")
        End Try
    End Sub


    Private Sub UpdateButton_MouseEnter(sender As Object, e As EventArgs) Handles UpdateButton.MouseEnter
        UpdateButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub UpdateButton_MouseLeave(sender As Object, e As EventArgs) Handles UpdateButton.MouseLeave
        UpdateButton.ForeColor = Color.White
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim Items As ListView.SelectedListViewItemCollection = Me.ListView1.SelectedItems
        Dim item As ListViewItem
        For Each item In Items
            ListnoTextBox.Text = item.SubItems(1).Text
        Next item
        Call Populate_ListView()
    End Sub

    Private Sub ListView1_MouseEnter(sender As Object, e As EventArgs) Handles ListView1.MouseEnter
        ListView1.BackColor = Color.PaleTurquoise
    End Sub

    Private Sub ListView1_MouseLeave(sender As Object, e As EventArgs) Handles ListView1.MouseLeave
        ListView1.BackColor = Color.PowderBlue
    End Sub

    Private Sub ListnoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ListnoTextBox.TextChanged
        Try
            Dim sql As String
            Dim reader As MySqlDataReader
            listno = ListnoTextBox.Text
            sql = "SELECT * FROM `todo` WHERE listno=" & listno
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                TnameTextBox.Text = reader("name")
                ModuleComboBox.Text = reader("module")
                RelatedTextBox.Text = reader("related")
                TimeTextBox.Text = reader("timeallocated")
                BenefitTextBox.Text = reader("benefit")
                PriorityComboBox.Text = reader("priority")
                CategoryComboBox.Text = reader("category")



            End If
            reader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim sql As String
        Dim SearchValue As String
        SearchValue = TextBox1.Text
        sql = "select * from `todo` WHERE `name` like '%" & SearchValue & "%'"
        Call PopulateListView(ListView1, sql)
    End Sub

    Private Sub AllRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllRecordsToolStripMenuItem.Click
        alltodolist.ShowDialog()
    End Sub
End Class