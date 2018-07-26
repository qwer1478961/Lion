Public Class Form1
    '103 年第三題 https://csie.stust.edu.tw/Sysid/csie/LionCup2017/download/20141023_v2.pdf
    '判斷是否為值數
    '𝑦 = 𝑛^2 + 𝑛 + 41
    '計算 y 是否為質數
    '重點 1, 因為 y 恆為奇數, 所以搜尋數字 從 3 至 sqrt(y)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Long = Val(TextBox1.Text)
        Dim i As Long, j As Long
        If (y < 0) Or (y > 10000) Then
            MsgBox("n值輸入錯誤(0 至 10000)，請重新輸入.")
            Exit Sub
        End If
        y = y ^ 2 + y + 41
        j = Math.Sqrt(y)
        For i = 3 To j Step 2
            If (y Mod i = 0) Then
                TextBox2.Text = "非質數."
                Exit Sub
            End If
        Next
        TextBox2.Text = "質數."
    End Sub

    '限制只能輸入數字及退回鍵
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8))
    End Sub

End Class
