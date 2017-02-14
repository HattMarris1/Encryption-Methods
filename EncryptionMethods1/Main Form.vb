Public Class Form1

    Private blockcypherencrypt As Block_Cypher
    Private blockcypherdecrypt As Block_Cypher
    Private steganographyencrypt As Steganography
    Private steganographydecrypt As Steganography
    Private ceaserCypherEncrypt As Ceaser_Cypher
    Private ceaserCypherDecrypt As Ceaser_Cypher
    Private therailfenceencrypt As RailFence
    Private therailfencedecrypt As RailFence
    Private thecyphertext As String
    Private theplaintext As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Puts the words "Hello There" in the main encrypt text box on the left as default
        EncryptTextbox.Text = "Hello There"
    End Sub

    Private Sub TabControl2_DrawItem(sender As System.Object, e As System.Windows.Forms.DrawItemEventArgs) Handles EncryptorTabControl.DrawItem
        'Moves the tabs to the left hand side of the tab control
        Dim g As Graphics
        Dim sText As String
        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF
        Dim ctlTab As TabControl
        ctlTab = CType(sender, TabControl)
        g = e.Graphics
        sText = ctlTab.TabPages(e.Index).Text

        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6

        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub TabControl3_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles DecryptTabControl.DrawItem
        'Moves the tabs to the left hand side of the tab control
        Dim g As Graphics
        Dim sText As String
        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF
        Dim ctlTab As TabControl
        ctlTab = CType(sender, TabControl)
        g = e.Graphics
        sText = ctlTab.TabPages(e.Index).Text

        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6

        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub EncryptTextbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles EncryptTextbox.TextChanged
        'Automatically puts the contents of the encrypt text box into the variable theplaintext
        theplaintext = EncryptTextbox.Text
    End Sub

    Private Sub OpenTextFileEncryptButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenTextFileEncryptButton.Click
        'Allows the user to import plaintext from a text file
        TextfileOpendialog.ShowDialog()
        copyintotextbox(EncryptTextbox)
    End Sub

    Private Sub TextfileOpendialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextfileOpendialog.FileOk
        'Text file open dialog box that gets the file location the user specifies
        readtextfromtextfile(TextfileOpendialog.FileName)
    End Sub

    Private Sub OpenTextFileDecryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenTextFileDecryptButton.Click
        'Allows the user to import Cyphertext from a text file
        TextfileOpendialog.ShowDialog()
        copyintotextbox(DecryptTextbox)
    End Sub

    Private Sub WriteToTextFile(sender As System.Object, e As System.EventArgs) Handles WriteToTextFileButton.Click
        'Writes the users plaintext or encrypted text to a text file
        Dim thename As String

        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.ShowDialog()

        thename = SaveFileDialog1.FileName

        MsgBox(thename)
        Dim theboxtoreadfrom As TextBox

        Select Case EncryptorTabControl.SelectedIndex
            Case Is = 0
                theboxtoreadfrom = SteganographyEncryptTextBox
            Case Is = 1
                theboxtoreadfrom = CeaserCypherEncryptTextbox
            Case Is = 2
                theboxtoreadfrom = RailFenceEncryptTextbox
            Case Is = 3
                theboxtoreadfrom = BlockCyphersEncryptTextbox
            Case Else
                theboxtoreadfrom.Text = "no Text Box"
        End Select
        WriteintoTextfile(theboxtoreadfrom, thename)
    End Sub

    'Steganography

    Private Sub SteganographyEncryptButton_Click(sender As System.Object, e As System.EventArgs) Handles SteganographyEncryptButton.Click
        'Runs the steganography encryptor when the button is clicked
        If theplaintext <> "" Then
            steganographyencrypt = New Steganography
            SteganographyEncryptTextBox.Text = steganographyencrypt.steganographyencrypt
        Else : MsgBox("no text to encrypt")
        End If

    End Sub

    Private Sub SteganographyDecryptButton_Click(sender As System.Object, e As System.EventArgs) Handles SteganographyDecryptButton.Click
        'Runs the steganography decryptor when the button is clicked
        If thecyphertext <> "" Then
            steganographydecrypt = New Steganography
            SteganographyDecryptTextBox.Text = steganographydecrypt.SteganographyDecryptor
        Else : MsgBox("no text to decrypt")
        End If
    End Sub

    Private Sub SteganographyEncryptTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles SteganographyEncryptTextBox.TextChanged
        'Automatically puts the encrypted text into the Steganography decryptor box on the Decrypt tab
        DecryptTextbox.Text = SteganographyEncryptTextBox.Text

    End Sub

    'Ceaser Cypher
    Private Sub CeaserCypherEncryptButton_Click(sender As System.Object, e As System.EventArgs) Handles CeaserCypherEncryptButton.Click
        'Runs the ceaser Cypher encryptor when the button is clicked
        If theplaintext <> "" Then
            ceaserCypherEncrypt = New Ceaser_Cypher
            CeaserCypherEncryptTextbox.Text = ceaserCypherEncrypt.ceaserCypherencrypt
        Else : MsgBox("no text to encrypt")
        End If
    End Sub

    Private Sub CeaserCypherDecryptButton_Click(sender As System.Object, e As System.EventArgs) Handles CeaserCypherDecryptButton.Click
        'Runs the steganography decryptor when the button is clicked
        If thecyphertext <> "" Then
            ceaserCypherDecrypt = New Ceaser_Cypher
            CeaserCypherDecryptTextbox.Text = ceaserCypherDecrypt.ceaserCypherDecrypt
        Else : MsgBox("no text to decrypt")
        End If
    End Sub

    Private Sub CeaserCypherEncryptTextbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CeaserCypherEncryptTextbox.TextChanged
        'Automatically puts the encrypted text into the Ceaser Cypher decryptor box on the Decrypt tab
        DecryptTextbox.Text = CeaserCypherEncryptTextbox.Text
    End Sub

    'Rail Fence

    Private Sub RailFenceEncryptButton_Click(sender As System.Object, e As System.EventArgs) Handles RailFenceEncryptButton.Click
        'Runs the rail fence encryptor when the button is clicked
        If theplaintext <> "" Then
            therailfenceencrypt = New RailFence
            RailFenceEncryptTextbox.Text = therailfenceencrypt.RailFenceEncryptor
        Else : MsgBox("no text to encrypt")
        End If
    End Sub

    Private Sub RailFenceDecryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RailFenceDecryptButton.Click
        'Runs the rail fence decryptor when the button is clicked
        If thecyphertext <> "" Then
            therailfencedecrypt = New RailFence
            RailFenceDecryptTextBox.Text = therailfencedecrypt.RailFenceDecryptor
        Else : MsgBox("no text to decrypt")
        End If
    End Sub

    Private Sub RailFenceEncryptTextbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles RailFenceEncryptTextbox.TextChanged
        'Automatically puts the encrypted text into the rail fence decryptor box on the Decrypt tab
        DecryptTextbox.Text = RailFenceEncryptTextbox.Text
    End Sub

    'Block Cypher
    Private Sub BlockCypherEncryptButton_Click(sender As System.Object, e As System.EventArgs) Handles BlockCypherEncryptButton.Click
        If thecyphertext <> "" Then
            'Runs the Block Cypher encryptor when the button is clicked
            blockcypherencrypt = New Block_Cypher
            BlockCyphersEncryptTextbox.Text = blockcypherencrypt.BlockCypherEncryptor
        Else : MsgBox("no text to encrypt")
        End If
    End Sub

    Private Sub BlockCypherDecryptButton_Click(sender As System.Object, e As System.EventArgs) Handles BlockCypherDecryptButton.Click
        If thecyphertext <> "" Then
            'Runs the block cypher decryptor when the button is clicked
            blockcypherdecrypt = New Block_Cypher
            BlockCypherDecryptTextBox.Text = blockcypherdecrypt.blockCypherDecryptor
            Else : MsgBox("no text to decrypt")
        End If
    End Sub

    Private Sub BlockCypherEncryptTextbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles BlockCyphersEncryptTextbox.TextChanged
        'Automatically puts the encrypted text into the ceaser cypher decryptor box on the Decrypt tab
        DecryptTextbox.Text = BlockCyphersEncryptTextbox.Text
    End Sub

    'The Visual demonstration stuff

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'shows the visual demonstration form for the steganography method of encryption
        Steganography_Visual.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'shows the visual demonstration form for the ceaser cipher method of encryption
        Ceaser_Cypher_Visual.ShowDialog()
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        'shows the visual demonstration form for the Rail Fence method of encryption
        rail_fence_visual.ShowDialog()
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'shows the visual demonstration form for the block cipher method of encryption
        BlockCypherVisual.ShowDialog()
    End Sub

    Public Function gettheplaintext()
        'gets the plaintext 
        Return theplaintext
    End Function

    Private Sub ClearEncryptTextBox_Click(sender As System.Object, e As System.EventArgs) Handles ClearEncryptTextBox.Click
        'clears the encrypt text box
        EncryptTextbox.Text = ""
    End Sub

    Private Sub ClearDecryptTextBoxButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearDecryptTextBoxButton.Click
        'clears the decrypt text box
        DecryptTextbox.Text = ""
    End Sub

    Private Sub DecryptTextbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DecryptTextbox.TextChanged
        'Automatically puts the contents of the decrypt text box into the variable thecyphertext
        thecyphertext = DecryptTextbox.Text
    End Sub
End Class
