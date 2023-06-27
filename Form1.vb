Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text & TextBox2.Text) Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please Input number first")
            Else
                TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
            End If
        Else
            MsgBox("Please input number only")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(TextBox1.Text & TextBox2.Text) Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please Input number first")
            Else
                TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
            End If
        Else
            MsgBox("Please input number only")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(TextBox1.Text & TextBox2.Text) Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please Input number first")
            Else
                TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
            End If
        Else
            MsgBox("Please input number only")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNumeric(TextBox1.Text & TextBox2.Text) Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please Input number first")
            Else
                TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
            End If
        Else
            MsgBox("Please input number only")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
