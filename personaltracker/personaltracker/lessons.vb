Public Class lessons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Turquoise
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub

    Private Sub SaveButton_MouseEnter(sender As Object, e As EventArgs) Handles SaveButton.MouseEnter
        SaveButton.ForeColor = Color.LimeGreen

    End Sub

    Private Sub SaveButton_MouseLeave(sender As Object, e As EventArgs) Handles SaveButton.MouseLeave
        SaveButton.ForeColor = Color.White
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

    End Sub

    Private Sub NewButton_MouseEnter(sender As Object, e As EventArgs) Handles NewButton.MouseEnter
        NewButton.ForeColor = Color.CornflowerBlue
    End Sub

    Private Sub NewButton_MouseLeave(sender As Object, e As EventArgs) Handles NewButton.MouseLeave
        NewButton.ForeColor = Color.White
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub DeleteButton_MouseEnter(sender As Object, e As EventArgs) Handles DeleteButton.MouseEnter
        DeleteButton.ForeColor = Color.Red
    End Sub

    Private Sub DeleteButton_MouseLeave(sender As Object, e As EventArgs) Handles DeleteButton.MouseLeave
        DeleteButton.ForeColor = Color.Firebrick
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

    End Sub

    Private Sub UpdateButton_MouseEnter(sender As Object, e As EventArgs) Handles UpdateButton.MouseEnter
        UpdateButton.ForeColor = Color.LimeGreen
    End Sub

    Private Sub UpdateButton_MouseLeave(sender As Object, e As EventArgs) Handles UpdateButton.MouseLeave
        UpdateButton.ForeColor = Color.White
    End Sub
End Class