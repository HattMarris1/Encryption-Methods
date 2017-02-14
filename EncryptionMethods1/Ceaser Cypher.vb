Public Class Ceaser_Cypher
    Inherits Encryptor

    Public Function ceaserCypherencrypt(Optional ByVal shift As Integer = 0)
        'encrypts the plain text using a Ceaser Cypher method
        Dim OutputCypherText As String = String.Empty
        Dim Inputplaintext As String

        'gets the plaintext from the user
        Inputplaintext = getplaintext()

        'gets the amount to shift the plaintext by from the user
        If shift = 0 Then
            shift = getkey()
        End If

        For looper = 1 To Inputplaintext.Length
            Dim thechar As Char
            Dim theasciival As Integer
            Dim shiftedasciival As Integer

            'stores the current character to be shifted in thechar
            thechar = Mid(Inputplaintext, looper, 1)

            'gets the ascii value of this character
            theasciival = Asc(thechar)

            'adds shift to this number
            shiftedasciival = theasciival + shift

            'adds this character onto the end of the string
            OutputCypherText = OutputCypherText & Chr(shiftedasciival)
        Next
        Return OutputCypherText
    End Function

    Public Function ceaserCypherDecrypt()
        '  Decrypts the plain text using a Ceaser Cypher method
        Dim OutputPlainText As String = String.Empty
        Dim Inputcyphertext As String
        Dim shift As Integer

        'gets the encryptedtext from the user
        Inputcyphertext = getCypherText()

        'gets the shift from the user
        shift = getkey()

        For looper = 1 To Inputcyphertext.Length
            Dim thechar As Char
            Dim theasciival As Integer
            Dim shiftedasciival As Integer

            'stores the current character to be shifted in thechar
            thechar = Mid(Inputcyphertext, looper, 1)

            'gets the ascii value of this character
            theasciival = Asc(thechar)

            'takes away the shift from this number
            shiftedasciival = theasciival - shift

            'adds this character onto the end of the string
            OutputPlainText = OutputPlainText & Chr(shiftedasciival)
        Next
        Return OutputPlainText
    End Function
End Class
