Public Class Form1

    Private Sub Backup_Run(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If BackupNU.Text = "1" Then
            My.Settings.Backup = "2"
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\1") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BDir + "\1", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\1") Then
                My.Computer.FileSystem.CopyDirectory("%appdata%\.minecraft", My.Settings.BDir + "\1")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.BDir + "\1")
                If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\1") Then
                    My.Computer.FileSystem.CopyDirectory(My.Settings.mcdir, My.Settings.BDir + "\1")
                End If
            End If
        End If

        If BackupNU.Text = "2" Then
            My.Settings.Backup = "3"
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\2") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BDir + "\2", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\2") Then
                My.Computer.FileSystem.CopyDirectory("%appdata%\.minecraft", My.Settings.BDir + "\2")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.BDir + "\2")
                If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\2") Then
                    My.Computer.FileSystem.CopyDirectory(My.Settings.mcdir, My.Settings.BDir + "\2")
                End If
            End If
        End If

        If BackupNU.Text = "3" Then
            My.Settings.Backup = "4"
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\3") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BDir + "\3", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\3") Then
                My.Computer.FileSystem.CopyDirectory("%appdata%\.minecraft", My.Settings.BDir + "\3")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.BDir + "\3")
                If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\3") Then
                    My.Computer.FileSystem.CopyDirectory(My.Settings.mcdir, My.Settings.BDir + "\3")
                End If
            End If
        End If

        If BackupNU.Text = "4" Then
            My.Settings.Backup = "5"
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\4") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BDir + "\4", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\4") Then
                My.Computer.FileSystem.CopyDirectory("%appdata%\.minecraft", My.Settings.BDir + "\4")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.BDir + "\4")
                If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\4") Then
                    My.Computer.FileSystem.CopyDirectory(My.Settings.mcdir, My.Settings.BDir + "\4")
                End If
            End If
        End If

        If BackupNU.Text = "5" Then
            My.Settings.Backup = "1"
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\5") Then
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BDir + "\5", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\5") Then
                My.Computer.FileSystem.CopyDirectory("%appdata%\.minecraft", My.Settings.BDir + "\5")
            Else
                My.Computer.FileSystem.CreateDirectory(My.Settings.BDir + "\5")
                If My.Computer.FileSystem.DirectoryExists(My.Settings.BDir + "\5") Then
                    My.Computer.FileSystem.CopyDirectory(My.Settings.mcdir, My.Settings.BDir + "\5")
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackupNU.Text = My.Settings.Backup
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        settings.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BackupNU.Text = My.Settings.Backup
    End Sub
End Class