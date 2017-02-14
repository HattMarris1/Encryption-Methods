Public Class Block_Cypher
    Inherits Encryptor
    Public Function BlockCypherEncryptor()
        'Encrypts the plain text using a Block cypher method
        Dim theblocks() As Byte
        Dim thexoredblocks() As Byte
        Dim Inputplaintext As String = getplaintext()
        ReDim theblocks(Inputplaintext.Length)
        Dim key As String
        ReDim thexoredblocks(Inputplaintext.Length)
        Dim OutputCypherText As String = ""
        Dim intialisationvector As Byte

        key = getkey()
        intialisationvector = Asc(key)

        'converts each character to a its ascii number
        For looper = 1 To Inputplaintext.Length
            Dim tempchar As Char
            tempchar = Mid(Inputplaintext, looper, 1)
            theblocks(looper) = Asc(tempchar)
        Next

        'Xors the first block with intialisation vector 
        thexoredblocks(1) = theblocks(1) Xor intialisationvector

        'Xors the last xored block with the current plaintext block
        For looper = 2 To theblocks.Length - 1
            thexoredblocks(looper) = thexoredblocks(looper - 1) Xor theblocks(looper)
        Next

        'converts the xored blocks back into characters
        For looper = 1 To thexoredblocks.Length - 1
            OutputCypherText = OutputCypherText & Chr(thexoredblocks(looper) + 1)
        Next
        Return OutputCypherText
    End Function
    Public Function blockCypherDecryptor()
        'Encrypts the plain text using a Block cypher method
        Dim CypherText As String = getCypherText()
        Dim theblocks(CypherText.Length) As Byte
        Dim key As String
        Dim thexoredblocks(CypherText.Length) As Byte
        Dim OuputPlaintext  As String = ""
        Dim initialisationvector As Byte
        key = getkey()

        initialisationvector = Asc(key)

        'converts each character into its ascii number
        For looper = 1 To CypherText.Length
            Dim temp As String
            temp = Mid(CypherText, looper, 1)
            theblocks(looper) = Asc(temp) - 1
        Next

        'Xors the first block with intialisation vector
        thexoredblocks(1) = theblocks(1) Xor initialisationvector

        'Xors the last xored block with the current encryptedtext block
        For looper = 2 To thexoredblocks.Length - 1
            thexoredblocks(looper) = theblocks(looper - 1) Xor theblocks(looper)
        Next

        'converts the xored blocks back into characters
        For looper = 1 To thexoredblocks.Length - 1
            OuputPlaintext = OuputPlaintext & Chr(thexoredblocks(looper))
        Next
        Return OuputPlaintext
    End Function
    Public Overrides Function getkey()
        'gets the key, and ensures it is not nothing
        Dim intialisationvector As String = ""
        Do While intialisationvector = ""
            StringInputDialogBox.settheprompt("Please enter the intialisation vector:")
            StringInputDialogBox.ShowDialog()
            If StringInputDialogBox.DialogResult = DialogResult.OK Then
                intialisationvector = StringInputDialogBox.TextBox1.Text
                Return intialisationvector
            End If
        Loop
        Return intialisationvector
    End Function
End Class
