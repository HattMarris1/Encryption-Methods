Imports System.Windows.Forms
Public Class StringInputDialogBox
    Inherits EncryptionMethods1.integerInputDialog

    Public Overrides Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'overides the keypress event, allowing the user to enter anything
        e.Handled = False
    End Sub

    Private Sub StringInputDialogBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'selects the textbox so the user can type straight into it
        TextBox1.Select()
    End Sub
End Class