Public Class settings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.BDir = TextBox1.Text
        My.Settings.mcdir = TextBox2.Text
        Me.Close()
    End Sub

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.BDir
        TextBox2.Text = My.Settings.mcdir
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.Backup = "1"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("this is not set up yet", MsgBoxStyle.OkCancel, "Delete")

    End Sub
End Class