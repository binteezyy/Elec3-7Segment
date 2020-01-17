Public Class Form1
    Private Sub Form1_Load(sender As Object, ea As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        Timer.Start()

    End Sub

    Private Sub Timer_Tick(sender As Object, ea As EventArgs) Handles Timer.Tick
        Static ctr As Integer = 0
        If ctr = 0 Then
            ctr += 1
            A.Visible = True
            B.Visible = True
            C.Visible = True
            D.Visible = True
            E.Visible = True
            F.Visible = True
            G.Visible = False
        ElseIf ctr = 1 Then
            ctr += 1
            A.Visible = True
            B.Visible = False
            C.Visible = False
            D.Visible = False
            E.Visible = False
            F.Visible = True
            G.Visible = False
        ElseIf ctr = 2 Then
            ctr += 1
            A.Visible = True
            B.Visible = True
            C.Visible = False
            D.Visible = True
            E.Visible = True
            F.Visible = False
            G.Visible = True
        ElseIf ctr = 3 Then
            ctr += 1
            A.Visible = True
            B.Visible = True
            C.Visible = False
            D.Visible = False
            E.Visible = True
            F.Visible = True
            G.Visible = True
        ElseIf ctr = 4 Then
            ctr += 1
            A.Visible = True
            B.Visible = False
            C.Visible = True
            D.Visible = False
            E.Visible = False
            F.Visible = True
            G.Visible = True
        ElseIf ctr = 5 Then
            ctr += 1
            A.Visible = False
            B.Visible = True
            C.Visible = True
            D.Visible = False
            E.Visible = True
            F.Visible = True
            G.Visible = True
        ElseIf ctr = 6 Then
            ctr += 1
            A.Visible = False
            B.Visible = True
            C.Visible = True
            D.Visible = True
            E.Visible = True
            F.Visible = True
            G.Visible = True
        ElseIf ctr = 7 Then
            ctr += 1
            A.Visible = True
            B.Visible = True
            C.Visible = False
            D.Visible = False
            E.Visible = False
            F.Visible = True
            G.Visible = False
        ElseIf ctr = 8 Then
            ctr += 1
            A.Visible = True
            B.Visible = True
            C.Visible = True
            D.Visible = True
            E.Visible = True
            F.Visible = True
            G.Visible = True
        ElseIf ctr = 9 Then
            ctr = 0
            A.Visible = True
            B.Visible = True
            C.Visible = True
            D.Visible = False
            E.Visible = True
            F.Visible = True
            G.Visible = True
        End If
    End Sub
End Class
