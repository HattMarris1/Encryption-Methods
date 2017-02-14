Public Class Steganography
    Inherits Encryptor

    Private Function Randomstringgenerator(ByVal length As Integer) As String
        'generates a random string of a specified length
        Dim final As String = ""
        Dim validCharacters() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~"

        For looper As Integer = 1 To length
            'generates the string, adding one random character at a time
            final = final & validCharacters((validCharacters.Length - 1) * Rnd())
        Next
        Return final
    End Function

    Public Function steganographyencrypt()
        'encrypts the plain text using a steganography method
        Dim OutputCypherText As String = String.Empty
        Dim Key As Integer
        Dim Inputplaintext As String

        'gets the plaintext from the user
        Inputplaintext = Form1.gettheplaintext()

        'gets the key from the user
        Key = getkey()

        'builds a string containing each letter of the string
        'followed by a string of random characters the length
        'of the string
        For looper As Integer = 1 To Len(Inputplaintext)
            OutputCypherText = OutputCypherText & Mid(Inputplaintext, looper, 1)
            OutputCypherText = OutputCypherText & Randomstringgenerator(Key)
        Next

        Return OutputCypherText
    End Function

    Public Function SteganographyDecryptor()
        Dim Outputplaintext As String = String.Empty
        Dim Key As Integer
        Dim inputcyphertext As String

        'gets the plaintext from the user
        inputcyphertext = getCypherText()

        'gets the key from the user
        Key = getkey()

        For looper As Integer = 1 To Len(inputcyphertext) Step Key + 1
            Outputplaintext = Outputplaintext & Mid(inputcyphertext, looper, 1)
        Next
        Return Outputplaintext
    End Function
End Class
