Public Class Form1
    '103 年第六題 https://csie.stust.edu.tw/Sysid/csie/LionCup2017/download/20141023_v2.pdf
    '計算礦石最終溫度
    '礦石加熱 i 秒後溫度公式 Ti = Ti−1 + i × 3.14159
    '礦石初始溫度 T0
    '𝑇𝑖 計算結果依四捨五入顯示到小數點以下 5 位

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t0 As Double = TextBox1.Text
        Dim ti As Double, i As Integer
        If (TextBox2.Text > 200) Then
            MsgBox("秒數超過 200秒，請重新輸入.")
            Exit Sub
        End If
        For i = 1 To TextBox2.Text
            ti = t0 + i * 3.14159
            t0 = ti
        Next
        ti = CInt(ti * 100000) / 100000
        TextBox3.Text = Format(ti, "##.00000")
    End Sub

    '限制只能輸入數字、退回鍵、負號、小數點
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (e.KeyChar = Chr(8)) Or (e.KeyChar = "-") Or (e.KeyChar = "."))
    End Sub

    '限制只能輸入數字、退回鍵
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (e.KeyChar = Chr(8)))
    End Sub

End Class
