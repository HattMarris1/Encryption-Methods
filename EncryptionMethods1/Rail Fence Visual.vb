Public Class rail_fence_visual
    Const numberofcolumns As Integer = 4
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'puts the letters of the users plaintext in panels and shows how it is encrypted
        Dim plaintext As String = Form1.gettheplaintext
        Dim plaintextcharacters(plaintext.Length - 1) As letter_nodes
        MsgBox("Firstly, the letters are written out in columns")
        writeoutthelettersinacoloumn(plaintext, plaintextcharacters)

        MsgBox("then, the first letter from each column is written form the first characters, and the second letters from each")
        writelettersoutinencryptedform(plaintextcharacters)
    End Sub

    Private Sub writeoutthelettersinacoloumn(ByVal plaintext As String, ByRef letternodes() As letter_nodes)
        'writes the letters out vertically in columns
        Dim temppoint As Point
        Dim row As Integer
        Dim column As Integer

        For looper = 0 To plaintext.Length - 1
            row = Int(looper / numberofcolumns)
            column = looper Mod numberofcolumns
            temppoint.X = 100 + row * 100
            temppoint.Y = 100 + column * 100
            letternodes(looper) = New letter_nodes(plaintext(looper), Me, temppoint, Color.Firebrick)
        Next
    End Sub

    Private Sub writelettersoutinencryptedform(ByRef plaintextcharacters() As letter_nodes)
        'moves the letters from thier coloumns and puts them in encrypted form
        For looper = 0 To plaintextcharacters.Length - 1

            For innerlooper = 1 To 100
                plaintextcharacters(looper).GoRight((looper Mod numberofcolumns) * numberofcolumns)
                plaintextcharacters(looper).wastetime(9000)
            Next

            For Ylooper = plaintextcharacters(looper).getnodepanel.Location.Y To 100 Step -1
                plaintextcharacters(looper).wastetime(6000)
                Dim temppoint As Point
                temppoint.Y = Ylooper
                temppoint.X = plaintextcharacters(looper).getnodepanel.Location.X
                plaintextcharacters(looper).getnodepanel.Location = temppoint
                'temppoint.Y=
            Next
        Next
    End Sub

End Class