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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Label1.Text = "0" Then
            Label1.Text = "2"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "2"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Label1.Text = "0" Then
            Label1.Text = "3"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "3"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Label1.Text = "0" Then
            Label1.Text = "4"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "4"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Label1.Text = "0" Then
            Label1.Text = "5"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "5"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Label1.Text = "0" Then
            Label1.Text = "6"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "6"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Label1.Text = "0" Then
            Label1.Text = "7"
        ElseIf Label1.Text <> "0" Then
            Label1.Text += "7"
        End If
    End Sub
End Class
