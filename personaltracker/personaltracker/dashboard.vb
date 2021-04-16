Public Class dashboard
    Private r As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = "Hello" Then
            PictureBox1.Image = personaltracker.My.Resources.cool_background_hd_images_download_photos_pictures
            Label1.Text = "Courage"
        ElseIf Label1.Text = "Courage" Then
            PictureBox1.Image = personaltracker.My.Resources.cool_nawpic_1
            Label1.Text = "Faith"
        ElseIf Label1.Text = "Faith" Then
            PictureBox1.Image = personaltracker.My.Resources._4_space
            Label1.Text = "Determination"
        ElseIf Label1.Text = "Determination" Then
            PictureBox1.Image = personaltracker.My.Resources.ffr
            Label1.Text = "Pride"
        ElseIf Label1.Text = "Pride" Then
            PictureBox1.Image = personaltracker.My.Resources.ffty
            Label1.Text = "Honour"
        ElseIf Label1.Text = "Honour" Then
            PictureBox1.Image = personaltracker.My.Resources.fggg
            Label1.Text = "Self-Love"
        ElseIf Label1.Text = "Self-Love" Then
            PictureBox1.Image = personaltracker.My.Resources.first
            Label1.Text = "Success"
        ElseIf Label1.Text = "Success" Then
            PictureBox1.Image = personaltracker.My.Resources.fourth
            Label1.Text = "Hardwork"
        ElseIf Label1.Text = "Hardwork" Then
            PictureBox1.Image = personaltracker.My.Resources.gyy
            Label1.Text = "Hello"

        End If

    End Sub


    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        todolist.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        goals.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        timetable.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        lessons.ShowDialog()
    End Sub
End Class