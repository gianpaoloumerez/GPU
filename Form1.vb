Public Class Calculator
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        If Label1.Text <> "0" Then
            Label1.Text += "0"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Label1.Text = "0" Then
            Label1.Text = "1"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "1"
        End If

    End Sub
End Class
