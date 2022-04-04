Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    '                                                    
    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Launcher_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Launcher_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
    '                                                   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() ' 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '                                   CONFIG
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("Explorer.exe fivem://connect 43.248.188.188:2333/localhost") 'SERVER IP
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe https://discord.gg/871336387859853333") 'DISCORD SERVER
    End Sub

    Private Sub Creditos(sender As Object, e As EventArgs) Handles Button4.Click, PictureBox2.Click
        Dim v = Shell("Explorer.exe https://github.com/Martin67776")
    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
