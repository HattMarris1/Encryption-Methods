Imports System.Windows.Forms

Public Class integerInputDialog

    Private thePrompt As String

    Protected Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'handles the ok button, sets dialog result to ok
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Protected Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'handles the Cancel button, sets dialog result to cancel
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Overridable Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'handles the keypress event, ensure that the key pressed is a number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub settheprompt(ByVal theprompttosetitas As String)
        'sets the text that appears in the lable on the form
        thePrompt = theprompttosetitas
    End Sub

    Protected Sub InputDialogBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'selects the textbox so the user can type straight into it, puts the prompt in the label
        TextBox1.Select()
        PromptTextBox.Text = thePrompt
    End Sub
End Class
