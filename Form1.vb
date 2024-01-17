Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        c = (a ^ 2 + b ^ 2) ^ 0.5

        TextBox3.Text = c

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.AntiqueWhite
    End Sub
End Class
