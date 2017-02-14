Public Class RailFence
    Inherits Encryptor

    Public Function RailFenceEncryptor()
        'encrypts the plain text using a Rail Fence cypher method
        Dim numberofrows As Integer
        Dim thecyphertext As String = ""
        Dim Inputplaintext As String

        'gets the plaintext from the user
        Inputplaintext = Form1.gettheplaintext()

        'gets the amount of rows to use in the cypher from the user
        numberofrows = getkey()

        For outerlooper = 1 To numberofrows
            'starting at the first character of the string, it takes every nth character, 
            '(where n is the key) and writes them into the string 'thecyphertext'.
            'It then repeats this starting with the next character
            For innerlooper = outerlooper - 1 To Inputplaintext.Length - 1 Step numberofrows
                thecyphertext = thecyphertext & Inputplaintext(innerlooper)
            Next
        Next
        Return thecyphertext
    End Function

    Public Function RailFenceDecryptor()
        'decrypts the plain text using a Rail Fence cypher method
        Dim thenumberofrows As Integer
        Dim numberofcolumns As Integer
        Dim theOutputplaintext As String = ""
        Dim thecyphertext As String

        'gets the cypher text from the user
        thecyphertext = getCypherText()

        'gets the key from the user
        thenumberofrows = getkey()

        'calcualtes the number of columns using the length of the
        'cyphertext and the number of rows
        numberofcolumns = Math.Round(thecyphertext.Length / thenumberofrows)

        For outerlooper = 1 To numberofcolumns
            For innerlooper = outerlooper - 1 To thecyphertext.Length - 1 Step numberofcolumns
                theOutputplaintext = theOutputplaintext & thecyphertext(innerlooper)
            Next
        Next
        Return theOutputplaintext
    End Function
End Class
