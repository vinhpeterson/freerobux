Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Dim RandomShit As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DesktopLocation = New Point(RandomShit.Next(1, 1000), RandomShit.Next(1, 500)) Then
            DesktopLocation = New Point(RandomShit.Next(1, 1000), RandomShit.Next(1, 500))
        Else
            DesktopLocation = New Point(RandomShit.Next(1, 1000), RandomShit.Next(1, 500))
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        MsgBox("Problem?")
    End Sub
End Class
