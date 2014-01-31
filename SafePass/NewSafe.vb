Imports System.Windows.Forms

Public Class NewSafe

    Friend Password As String
    Friend FileName As String

    Private Sub ClearForm()
        Me.txtNewFileName.Text = ""
        Me.txtPassword1.Text = ""
        Me.txtPassword2.Text = ""
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim blnValid As Boolean

        blnValid = True

        If Me.objSaveSafe.FileName = "" Then
            blnValid = False
            MsgBox("Please provide a File Name to Save As", MsgBoxStyle.OkOnly, "Error")
        End If

        If Me.txtPassword1.Text = "" Then
            blnValid = False
            MsgBox("Please provide a Password", MsgBoxStyle.OkOnly, "Error")
        End If

        If Me.txtPassword1.Text <> Me.txtPassword2.Text Then
            blnValid = False
            MsgBox("Passwords do not match", MsgBoxStyle.OkOnly, "Error")
        End If

        If blnValid Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Password = Me.txtPassword1.Text
            Me.FileName = Me.objSaveSafe.FileName
            Me.ClearForm()
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearForm()
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Me.objSaveSafe.ShowDialog()
        Me.txtNewFileName.Text = Me.objSaveSafe.FileName
    End Sub
End Class
