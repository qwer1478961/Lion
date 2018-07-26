Public Class Form1
    '103 年第五題 https://csie.stust.edu.tw/Sysid/csie/LionCup2017/download/20141023_v2.pdf
    '判斷兩線關係
    '給定 L1 兩點 (x1,y1)、(x2,y2) 與 L2 兩點 (x3,y3)、(x4,y4)
    '判斷 L1 與 L2 關係 (平行 或 垂直)
    '線段斜率公式 (y2-y1)/(x1-x2)
    '斜率可能產生分母為零，請小心使用
    '令 a=x1-x2、b=y1-y2、c=x3-x4、d=y3-y4
    '若 L1 // L2 則 m1= m2 ，bc=ad
    '若 L1 ⊥ L2 則 m1 × m2 =-1 ， bd=-ac
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = Val(x1.Text) - Val(x2.Text)
        Dim b As Integer = Val(y1.Text) - Val(y2.Text)
        Dim c As Integer = Val(x3.Text) - Val(x4.Text)
        Dim d As Integer = Val(y3.Text) - Val(y4.Text)
        If (b * c = a * d) Then
            MsgBox("平行")
        ElseIf (b * d = -a * c) Then
            MsgBox("垂直")
        Else
            MsgBox("兩者皆非")
        End If
    End Sub

    '限制只能輸入數字及退回鍵及負號
    Private Sub x1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles x1.KeyPress, x2.KeyPress, x3.KeyPress, x4.KeyPress, y1.KeyPress, y2.KeyPress, y3.KeyPress, y4.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or (e.KeyChar = Chr(8)) Or (e.KeyChar = "-"))
    End Sub

End Class
