Public Class frmCalculatrice
    Dim A As String
    Dim B As String
    Dim op = ""
    Dim res As Integer
    Dim Test As Boolean
    Private Sub txt_A_TextChanged(sender As Object, e As EventArgs) Handles txt_A.TextChanged

    End Sub

    Private Sub frmCalculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
        A = txt_A.Text
        txt_A.Text = ""
    End Sub

    Private Sub btn_moins_Click(sender As Object, e As EventArgs) Handles btn_moins.Click
        op = "-"
        A = txt_A.Text
        txt_A.Text = ""
    End Sub

    Private Sub btn_mlt_Click(sender As Object, e As EventArgs) Handles btn_mlt.Click
        op = "*"
        A = txt_A.Text
        txt_A.Text = ""
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
        A = txt_A.Text
        txt_A.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_A.Text += "1"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt_A.Text += "2"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_A.Text += "3"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_A.Text += "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_A.Text += "5"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_A.Text += "6"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_A.Text += "7"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_A.Text += "8"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_A.Text += "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txt_A.Text += "0"
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        B = txt_A.Text
        If IsNumeric(A) And IsNumeric(B) Then
            Test = "True"
            txt_A.Text = ""
            If op = "+" Then
                res = Integer.Parse(A) + Integer.Parse(B)
            ElseIf op = "-" Then
                res = Integer.Parse(A) - Integer.Parse(B)
            ElseIf op = "*" Then
                res = Integer.Parse(A) * Integer.Parse(B)
            ElseIf op = "/" Then
                res = Integer.Parse(A) / Integer.Parse(B)
            Else
                MessageBox.Show("veuiller donner l'operateur")
                Test = "False"
            End If
            If Test Then
                lbl_res.Text = res.ToString()
            End If

        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_A.Text = ""
        lbl_res.Text = ""
    End Sub
End Class
