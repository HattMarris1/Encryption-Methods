Public Class Steganography_Visual
    Private theletterlables(4) As letter_nodes
    Private randomletterlables((theletterlables.Length * 4) - 3) As letter_nodes

    Private Sub encrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encrypt.Click
        'puts the letters of the users plaintext in panels and shows how it is encrypted
        writefirstfiveletters(Me, theletterlables)
        spreadouttheletters(Me, theletterlables)
        wastetime(99999999)
        inserttherandomcharacters(Me, randomletterlables)
        movetherandomlettersup(Me, randomletterlables)
    End Sub

    Public Sub writefirstfiveletters(ByRef theform As Form, ByRef thenodes() As letter_nodes)
        'writes the first five letters of the users plaintext across the top of the form
        Dim plaintext As String = Form1.gettheplaintext
        Dim temppoint As Point
        temppoint.Y = 100

        If plaintext = "" Then
            plaintext = "Hello!"
        End If

        For looper = 0 To thenodes.Length - 1
            temppoint.X = looper * 100
            thenodes(looper) = New letter_nodes(plaintext(looper), theform, temppoint, Color.Firebrick)
        Next
    End Sub

    Public Sub spreadouttheletters(ByRef theform As Form, ByRef thenodes() As letter_nodes)
        'creates space between the letters by spreading them out to the right
        For outerlooper = thenodes.Length - 1 To 0 Step -1

            For looper = outerlooper * 300 To 0 Step -1
                thenodes(outerlooper).GoRight(1)
                Application.DoEvents()
                wastetime(50000)
            Next
        Next
    End Sub

    Public Sub wastetime(ByVal thetimetowaste As Integer)
        'wastes time by looping a specified number of times
        For looper = 1 To thetimetowaste
        Next
    End Sub

    Public Sub inserttherandomcharacters(ByRef theform As Form, ByRef randomletterlables() As letter_nodes)
        'puts randomly generated characters between and beneath each panel on the form
        Dim randomcharacters As String
        Dim temppoint As Point

        temppoint.Y = 200
        randomcharacters = Randomstringgenerator(randomletterlables.Length)

        For looper = 1 To randomletterlables.Length - 1
            If looper = 4 Or looper = 8 Or looper = 12 Or looper = 16 Then
                randomletterlables(looper) = New letter_nodes(randomcharacters(looper), theform, temppoint, Color.Firebrick)
                'fadein(randomletterlables(looper))
            Else
                temppoint.X = looper * 100
                randomletterlables(looper) = New letter_nodes(randomcharacters(looper), theform, temppoint, Color.Firebrick)
            End If
        Next
    End Sub

    Public Function Randomstringgenerator(ByVal length As Integer) As String
        'generates a string of random characters
        Dim final As String = ""
        Dim validCharacters() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~"
        Randomize()
        'number = New Random
        For i As Integer = 1 To length
            final = final & validCharacters((validCharacters.Length - 1) * Rnd())
        Next
        Return final
    End Function

    Public Sub movetherandomlettersup(ByVal theform As Form, ByRef thenodes() As letter_nodes)
        'moves the panels with random letters in them up into the spaces between the plaintext characters
        For outerlooper = 1 To 100
            For looper = 1 To thenodes.Length - 1
                thenodes(looper).GoUp(1)
                Application.DoEvents()
                wastetime(50000)
            Next
        Next
    End Sub
End Class