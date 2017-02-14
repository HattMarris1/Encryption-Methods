Public Class Encryptor
    'Properties

    Private key As Integer
    Private plaintext As String
    Private CypherText As String

    'Methods

    Public Sub New()
        'gets the plaintext from the form
        plaintext = Form1.gettheplaintext()
    End Sub

    Public Function getplaintext()
        'gets the plaintext
        Return plaintext
    End Function

    Public Function getCypherText()
        'gets the encryptedtext from the form
        CypherText = Form1.DecryptTextbox.Text
        Return CypherText
    End Function
    Public Overridable Function getkey()
        'The default key getter, gets the key from the user, and rejects anything that isnt above 0
        Dim key As Integer = 0
        Do Until key > 0
            integerInputDialog.settheprompt("Please enter the key:")
            integerInputDialog.ShowDialog()
            Try
                key = integerInputDialog.TextBox1.Text
            Catch ex As Exception
                MsgBox("invalid key, please enter a number above 0")
                key = -1
            End Try

            If key = 0 Then
                MsgBox("key invalid, please enter a number above 0")
            End If
        Loop
        Return key
    End Function
End Class
