Public Class Ceaser_Cypher_Visual
    Private theletterlables(10) As letter_nodes
    Private plaintext As String = Form1.gettheplaintext

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'puts the letters of the users plaintext in panels and shows how it is encrypted

        Dim shift As Integer

        writefirsttenletters(Me, theletterlables)

        'Encrypts using ceaser Cypher class

        Dim ceaserCypherencrypt As Ceaser_Cypher
        ceaserCypherencrypt = New Ceaser_Cypher
        Dim thecyphertext As String
        shift = ceaserCypherencrypt.getkey
        thecyphertext = ceaserCypherencrypt.ceaserCypherencrypt(shift)

        displaykey(shift)

        For looper = 0 To theletterlables.Length - 1
            'generates an array with all the characters between the plain and encrypted text
            Dim steppedcharacters(shift) As Char
            Dim steppedcharactersletternodes(shift) As letter_nodes
            For characterlooper = 0 To steppedcharacters.Length - 1
                steppedcharacters(characterlooper) = Chr(Asc(plaintext(looper)) + characterlooper)
            Next
            stepthroughthealphabet(steppedcharacters, steppedcharactersletternodes, theletterlables(looper))
        Next
    End Sub

    Private Sub displaykey(ByVal key As Integer)
        'puts the users key in the label at the top of the form
        Label1.Text = Label1.Text & key
    End Sub

    Private Sub stepthroughthealphabet(ByVal characterarray() As Char, ByVal theletternodearray() As letter_nodes, ByVal theplaintextletternode As letter_nodes)
        'generates a series of consecutive letter nodes, fades them in and moves them down one by one
        godownonehundred(theplaintextletternode)
        Dim temppoint As Point
        temppoint.X = theplaintextletternode.getnodepanel.Location.X
        temppoint.Y = 100
        'writes the characters into the letter nodes
        For looper = 1 To characterarray.Length - 2

            wastetime(1000)

            theletternodearray(looper) = New letter_nodes(characterarray(looper), Me, temppoint, Color.Fuchsia)

            godownonehundred(theletternodearray(looper))

            theletternodearray(looper).fadeout()
        Next

        theletternodearray(characterarray.Length - 1) = New letter_nodes(characterarray(characterarray.Length - 1), Me, temppoint, Color.CornflowerBlue)
        godownonehundred(theletternodearray(characterarray.Length - 1))

        theplaintextletternode.fadeout()
    End Sub

    Private Sub godownonehundred(ByVal thenode As letter_nodes)
        'Moves the nodepanel down 100 pixels
        For innerlooper = 0 To 100
            wastetime(90000)
            thenode.GoDown(1)
        Next
    End Sub

    Public Sub writefirsttenletters(ByRef theform As Form, ByRef thenodes() As letter_nodes)
        'writes the first ten letters of the users plaintext across the top of the form
        Dim temppoint As Point
        temppoint.Y = 150

        If plaintext = "" Then
            plaintext = "Hello!"
        End If

        For looper = 0 To thenodes.Length - 1
            temppoint.X = looper * 100
            thenodes(looper) = New letter_nodes(plaintext(looper), theform, temppoint, Color.Firebrick)
        Next
    End Sub

    Private Sub wastetime(ByVal thetimetowaste)
        'wastes time by looping a specified number of times
        For looper = 1 To thetimetowaste
        Next
    End Sub
End Class