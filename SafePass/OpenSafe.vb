Imports System.Windows.Forms

Public Class OpenSafe
    Friend Password As String

    Private Sub ClearForm()
        Me.txtPassword.Text = ""
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Password = Me.txtPassword.Text
        ClearForm()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        ClearForm()
        Me.Close()
    End Sub

    Private Sub OpenSafe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtPassword.Focus()
    End Sub

    Private Sub OpenSafe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtPassword.Focus()
    End Sub
End Class
