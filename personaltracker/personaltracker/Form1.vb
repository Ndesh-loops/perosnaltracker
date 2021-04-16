
Imports MySql.Data.MySqlClient
Public Class login
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim sql As String
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim password As String
    Dim username As String
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Panel2.BackColor = Color.OrangeRed
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = Color.Coral
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.OrangeRed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim sql As String
        Dim pass As String

        username = UserNameTextBox.Text.Trim()
        password = PasswordTextBox.Text.Trim()
        sql = "select password from users WHERE username=@username"
        cmd = New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@username", username)

        Try

            pass = cmd.ExecuteScalar()

            If password = pass And PasswordTextBox.Text IsNot "" Then
                MessageBox.Show("Login succesful")


                dashboard.Show()
                ''Me.Close()

            Else
                MsgBox("Please ensure that all the details are entered and are correctly filled.You must be registered to login")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
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
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles loginButton.MouseEnter
        loginButton.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles loginButton.MouseLeave
        loginButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.LimeGreen
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If PasswordTextBox.UseSystemPasswordChar = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class
