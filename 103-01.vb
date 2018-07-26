Public Class Form1
    '103年來恩杯第一題 https://csie.stust.edu.tw/Sysid/csie/LionCup2017/download/20141023_v2.pdf
    '求遞迴函數值
    'f(1)=3   f(2)=5
    'f(n)=3*f(n-1)-f(n-2)
    '1 ≤ n ≤ 20
    'textbox1.MaxLength 設為 2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)
        If ((n < 1) Or (n > 20)) Then '依題意只能輸入 1-20
            MsgBox("輸入 n 值超出 1 至 20 範圍，請重新輸入")
            Exit Sub
        End If
        Label2.Text = "F(" & n & ")="
        TextBox2.Text = f(n)
    End Sub

    Function f(ByVal n As Long) As Long
        If (n = 1) Then
            Return (3)
        ElseIf (n = 2) Then
            Return (5)
        Else
            Return (3 * f(n - 1) - f(n - 2))
        End If
    End Function

    '限制只能輸入數字及退回鍵
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8))
    End Sub
End Class
