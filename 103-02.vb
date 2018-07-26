Public Class Form1
    '103 年第二題 https://csie.stust.edu.tw/Sysid/csie/LionCup2017/download/20141023_v2.pdf
    '計算車資
    '基本費 50 元可打 10 分鐘
    '超過  10 分鐘到 100 分鐘以內的通話時間，每 10 秒 1 元
    '超過 100 分鐘到 200 分鐘以內的通話時間，每 15 秒 1 元
    '超過 200 分鐘到 500 分鐘以內的通話時間，每 20 秒 1 元
    '超過 500 分鐘之後的通話時間，每 30 秒 1 元
    'textbox1.MaxLength 設為 19, 因為 long 最大數為 9223372036854775807
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As Long = Val(TextBox1.Text)
        Dim m(2, 2) As Integer, tmp As Long
        Dim s As Long, i As Integer
        If (t < 0) Then
            MsgBox("輸入時間不能為負. 請重新輸入.")
            Exit Sub
        End If
        If (t = 0) Then
            TextBox2.Text = "0"
            Exit Sub
        Else
            s = 50
        End If
        m(0, 0) = 10 : m(0, 1) = 100 : m(0, 2) = 10 '起始時間 , 終止時間 , 每多少秒 1 元
        m(1, 0) = 100 : m(1, 1) = 200 : m(1, 2) = 15
        m(2, 0) = 200 : m(2, 1) = 500 : m(2, 2) = 20
        For i = 0 To 2
            If (t > m(i, 0)) Then
                If (t > m(i, 1)) Then
                    s += (m(i, 1) - m(i, 0)) * 60 \ m(i, 2) '已超過終止分鐘
                Else
                    tmp = (t - m(i, 0)) * 60
                    s += tmp \ m(i, 2) - ((tmp Mod m(i, 2)) > 0) '未超過中只分鐘累計
                End If
            Else
                Exit For '未超過起始分鐘
            End If
        Next
        If (t > 500) Then
            tmp = (t - 500) * 60
            s += (tmp \ 30) - ((tmp Mod 30) > 0)
        End If
        TextBox2.Text = s
    End Sub

    '限制只能輸入數字及退回鍵
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8))
    End Sub
End Class
