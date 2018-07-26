Public Class Form1
    '103 年第四題 https://csie.stust.edu.tw/Sysid/csie/LionCup2017/download/20141023_v2.pdf
    '判斷一字串是否為迴文
    '100 字以內
    '文字為英文小寫字母、數字 及 + - * /
    'textbox1.MaxLength 必須設為 100
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = Len(TextBox1.Text)
        Dim j As Integer = i \ 2 - 1
        Dim t As Integer
        i = i - 1
        For t = 0 To j
            If (TextBox1.Text.Substring(t, 1) <> TextBox1.Text.Substring(i - t, 1)) Then
                Exit For
            End If
        Next
        If (t > j) Then
            TextBox2.Text = "迴文"
        Else
            TextBox2.Text = "非迴文"
        End If
    End Sub

    '限制只能輸入數字及英文小寫與 + - * /
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsLower(e.KeyChar)) Then
            e.Handled = False
        ElseIf ((e.KeyChar = "+" Or e.KeyChar = "-" Or e.KeyChar = "*" Or e.KeyChar = "/")) Then
            e.Handled = False
        ElseIf (e.KeyChar = Chr(8)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
