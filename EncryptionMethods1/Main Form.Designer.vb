<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ClearEncryptTextBox = New System.Windows.Forms.Button()
        Me.WriteToTextFileButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenTextFileEncryptButton = New System.Windows.Forms.Button()
        Me.EncryptorTabControl = New System.Windows.Forms.TabControl()
        Me.SteganographyEncryptTabPage = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SteganographyEncryptTextBox = New System.Windows.Forms.TextBox()
        Me.SteganographyEncryptButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CeaserCypherEncryptTabPage = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.CeaserCypherEncryptTextbox = New System.Windows.Forms.TextBox()
        Me.CeaserCypherEncryptButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RailFenceEncryptTabPage = New System.Windows.Forms.TabPage()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.RailFenceEncryptTextbox = New System.Windows.Forms.TextBox()
        Me.RailFenceEncryptButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BlockCypherEncryptTabPage = New System.Windows.Forms.TabPage()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.BlockCyphersEncryptTextbox = New System.Windows.Forms.TextBox()
        Me.BlockCypherEncryptButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EncryptTextbox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ClearDecryptTextBoxButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenTextFileDecryptButton = New System.Windows.Forms.Button()
        Me.DecryptTabControl = New System.Windows.Forms.TabControl()
        Me.SteganographyDecryptTab = New System.Windows.Forms.TabPage()
        Me.SteganographyDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.SteganographyDecryptButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CeaserCypherDecryptTabPage = New System.Windows.Forms.TabPage()
        Me.CeaserCypherDecryptTextbox = New System.Windows.Forms.TextBox()
        Me.CeaserCypherDecryptButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RailFenceDecryptTabPage = New System.Windows.Forms.TabPage()
        Me.RailFenceDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.RailFenceDecryptButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BlockCypherDecryptTabPage = New System.Windows.Forms.TabPage()
        Me.BlockCypherDecryptTextBox = New System.Windows.Forms.TextBox()
        Me.BlockCypherDecryptButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DecryptTextbox = New System.Windows.Forms.TextBox()
        Me.TextfileOpendialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.EncryptorTabControl.SuspendLayout()
        Me.SteganographyEncryptTabPage.SuspendLayout()
        Me.CeaserCypherEncryptTabPage.SuspendLayout()
        Me.RailFenceEncryptTabPage.SuspendLayout()
        Me.BlockCypherEncryptTabPage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.DecryptTabControl.SuspendLayout()
        Me.SteganographyDecryptTab.SuspendLayout()
        Me.CeaserCypherDecryptTabPage.SuspendLayout()
        Me.RailFenceDecryptTabPage.SuspendLayout()
        Me.BlockCypherDecryptTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.TabPage1)
        Me.MainTabControl.Controls.Add(Me.TabPage2)
        Me.MainTabControl.Location = New System.Drawing.Point(4, 34)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(1161, 558)
        Me.MainTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ClearEncryptTextBox)
        Me.TabPage1.Controls.Add(Me.WriteToTextFileButton)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.OpenTextFileEncryptButton)
        Me.TabPage1.Controls.Add(Me.EncryptorTabControl)
        Me.TabPage1.Controls.Add(Me.EncryptTextbox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1153, 532)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ClearEncryptTextBox
        '
        Me.ClearEncryptTextBox.Location = New System.Drawing.Point(27, 409)
        Me.ClearEncryptTextBox.Name = "ClearEncryptTextBox"
        Me.ClearEncryptTextBox.Size = New System.Drawing.Size(101, 33)
        Me.ClearEncryptTextBox.TabIndex = 8
        Me.ClearEncryptTextBox.Text = "Clear"
        Me.ClearEncryptTextBox.UseVisualStyleBackColor = True
        '
        'WriteToTextFileButton
        '
        Me.WriteToTextFileButton.Location = New System.Drawing.Point(791, 463)
        Me.WriteToTextFileButton.Name = "WriteToTextFileButton"
        Me.WriteToTextFileButton.Size = New System.Drawing.Size(219, 51)
        Me.WriteToTextFileButton.TabIndex = 6
        Me.WriteToTextFileButton.Text = "Save to text file..."
        Me.WriteToTextFileButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please input the Text you would like encrypted below:"
        '
        'OpenTextFileEncryptButton
        '
        Me.OpenTextFileEncryptButton.Location = New System.Drawing.Point(181, 434)
        Me.OpenTextFileEncryptButton.Name = "OpenTextFileEncryptButton"
        Me.OpenTextFileEncryptButton.Size = New System.Drawing.Size(127, 35)
        Me.OpenTextFileEncryptButton.TabIndex = 2
        Me.OpenTextFileEncryptButton.Text = "Open Text File.."
        Me.OpenTextFileEncryptButton.UseVisualStyleBackColor = True
        '
        'EncryptorTabControl
        '
        Me.EncryptorTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.EncryptorTabControl.Controls.Add(Me.SteganographyEncryptTabPage)
        Me.EncryptorTabControl.Controls.Add(Me.CeaserCypherEncryptTabPage)
        Me.EncryptorTabControl.Controls.Add(Me.RailFenceEncryptTabPage)
        Me.EncryptorTabControl.Controls.Add(Me.BlockCypherEncryptTabPage)
        Me.EncryptorTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.EncryptorTabControl.ItemSize = New System.Drawing.Size(30, 120)
        Me.EncryptorTabControl.Location = New System.Drawing.Point(553, 64)
        Me.EncryptorTabControl.Multiline = True
        Me.EncryptorTabControl.Name = "EncryptorTabControl"
        Me.EncryptorTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EncryptorTabControl.SelectedIndex = 0
        Me.EncryptorTabControl.Size = New System.Drawing.Size(567, 378)
        Me.EncryptorTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.EncryptorTabControl.TabIndex = 1
        '
        'SteganographyEncryptTabPage
        '
        Me.SteganographyEncryptTabPage.Controls.Add(Me.LinkLabel1)
        Me.SteganographyEncryptTabPage.Controls.Add(Me.SteganographyEncryptTextBox)
        Me.SteganographyEncryptTabPage.Controls.Add(Me.SteganographyEncryptButton)
        Me.SteganographyEncryptTabPage.Controls.Add(Me.Label2)
        Me.SteganographyEncryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.SteganographyEncryptTabPage.Name = "SteganographyEncryptTabPage"
        Me.SteganographyEncryptTabPage.Size = New System.Drawing.Size(439, 370)
        Me.SteganographyEncryptTabPage.TabIndex = 0
        Me.SteganographyEncryptTabPage.Text = "Steganography"
        Me.SteganographyEncryptTabPage.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(359, 118)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(34, 37)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "?"
        '
        'SteganographyEncryptTextBox
        '
        Me.SteganographyEncryptTextBox.Location = New System.Drawing.Point(35, 199)
        Me.SteganographyEncryptTextBox.Multiline = True
        Me.SteganographyEncryptTextBox.Name = "SteganographyEncryptTextBox"
        Me.SteganographyEncryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SteganographyEncryptTextBox.Size = New System.Drawing.Size(370, 136)
        Me.SteganographyEncryptTextBox.TabIndex = 5
        '
        'SteganographyEncryptButton
        '
        Me.SteganographyEncryptButton.Location = New System.Drawing.Point(114, 101)
        Me.SteganographyEncryptButton.Name = "SteganographyEncryptButton"
        Me.SteganographyEncryptButton.Size = New System.Drawing.Size(219, 54)
        Me.SteganographyEncryptButton.TabIndex = 1
        Me.SteganographyEncryptButton.Text = "Encrypt"
        Me.SteganographyEncryptButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Steganography"
        '
        'CeaserCypherEncryptTabPage
        '
        Me.CeaserCypherEncryptTabPage.Controls.Add(Me.LinkLabel2)
        Me.CeaserCypherEncryptTabPage.Controls.Add(Me.CeaserCypherEncryptTextbox)
        Me.CeaserCypherEncryptTabPage.Controls.Add(Me.CeaserCypherEncryptButton)
        Me.CeaserCypherEncryptTabPage.Controls.Add(Me.Label3)
        Me.CeaserCypherEncryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.CeaserCypherEncryptTabPage.Name = "CeaserCypherEncryptTabPage"
        Me.CeaserCypherEncryptTabPage.Size = New System.Drawing.Size(439, 370)
        Me.CeaserCypherEncryptTabPage.TabIndex = 1
        Me.CeaserCypherEncryptTabPage.Text = "Ceaser Cypher"
        Me.CeaserCypherEncryptTabPage.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(371, 128)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(34, 37)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "?"
        '
        'CeaserCypherEncryptTextbox
        '
        Me.CeaserCypherEncryptTextbox.Location = New System.Drawing.Point(35, 199)
        Me.CeaserCypherEncryptTextbox.Multiline = True
        Me.CeaserCypherEncryptTextbox.Name = "CeaserCypherEncryptTextbox"
        Me.CeaserCypherEncryptTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CeaserCypherEncryptTextbox.Size = New System.Drawing.Size(370, 136)
        Me.CeaserCypherEncryptTextbox.TabIndex = 5
        '
        'CeaserCypherEncryptButton
        '
        Me.CeaserCypherEncryptButton.Location = New System.Drawing.Point(114, 101)
        Me.CeaserCypherEncryptButton.Name = "CeaserCypherEncryptButton"
        Me.CeaserCypherEncryptButton.Size = New System.Drawing.Size(219, 54)
        Me.CeaserCypherEncryptButton.TabIndex = 2
        Me.CeaserCypherEncryptButton.Text = "Encrypt"
        Me.CeaserCypherEncryptButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ceaser Cypher"
        '
        'RailFenceEncryptTabPage
        '
        Me.RailFenceEncryptTabPage.Controls.Add(Me.LinkLabel3)
        Me.RailFenceEncryptTabPage.Controls.Add(Me.RailFenceEncryptTextbox)
        Me.RailFenceEncryptTabPage.Controls.Add(Me.RailFenceEncryptButton)
        Me.RailFenceEncryptTabPage.Controls.Add(Me.Label4)
        Me.RailFenceEncryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.RailFenceEncryptTabPage.Name = "RailFenceEncryptTabPage"
        Me.RailFenceEncryptTabPage.Size = New System.Drawing.Size(439, 370)
        Me.RailFenceEncryptTabPage.TabIndex = 2
        Me.RailFenceEncryptTabPage.Text = "Rail Fence"
        Me.RailFenceEncryptTabPage.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(371, 118)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(34, 37)
        Me.LinkLabel3.TabIndex = 7
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "?"
        '
        'RailFenceEncryptTextbox
        '
        Me.RailFenceEncryptTextbox.Location = New System.Drawing.Point(35, 199)
        Me.RailFenceEncryptTextbox.Multiline = True
        Me.RailFenceEncryptTextbox.Name = "RailFenceEncryptTextbox"
        Me.RailFenceEncryptTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RailFenceEncryptTextbox.Size = New System.Drawing.Size(370, 136)
        Me.RailFenceEncryptTextbox.TabIndex = 5
        '
        'RailFenceEncryptButton
        '
        Me.RailFenceEncryptButton.Location = New System.Drawing.Point(114, 101)
        Me.RailFenceEncryptButton.Name = "RailFenceEncryptButton"
        Me.RailFenceEncryptButton.Size = New System.Drawing.Size(219, 54)
        Me.RailFenceEncryptButton.TabIndex = 3
        Me.RailFenceEncryptButton.Text = "Encrypt"
        Me.RailFenceEncryptButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rail Fence"
        '
        'BlockCypherEncryptTabPage
        '
        Me.BlockCypherEncryptTabPage.Controls.Add(Me.LinkLabel4)
        Me.BlockCypherEncryptTabPage.Controls.Add(Me.BlockCyphersEncryptTextbox)
        Me.BlockCypherEncryptTabPage.Controls.Add(Me.BlockCypherEncryptButton)
        Me.BlockCypherEncryptTabPage.Controls.Add(Me.Label7)
        Me.BlockCypherEncryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.BlockCypherEncryptTabPage.Name = "BlockCypherEncryptTabPage"
        Me.BlockCypherEncryptTabPage.Size = New System.Drawing.Size(439, 370)
        Me.BlockCypherEncryptTabPage.TabIndex = 5
        Me.BlockCypherEncryptTabPage.Text = "Block Cyphers"
        Me.BlockCypherEncryptTabPage.UseVisualStyleBackColor = True
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(371, 118)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(34, 37)
        Me.LinkLabel4.TabIndex = 8
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "?"
        '
        'BlockCyphersEncryptTextbox
        '
        Me.BlockCyphersEncryptTextbox.Location = New System.Drawing.Point(35, 199)
        Me.BlockCyphersEncryptTextbox.Multiline = True
        Me.BlockCyphersEncryptTextbox.Name = "BlockCyphersEncryptTextbox"
        Me.BlockCyphersEncryptTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.BlockCyphersEncryptTextbox.Size = New System.Drawing.Size(370, 136)
        Me.BlockCyphersEncryptTextbox.TabIndex = 5
        '
        'BlockCypherEncryptButton
        '
        Me.BlockCypherEncryptButton.Location = New System.Drawing.Point(114, 101)
        Me.BlockCypherEncryptButton.Name = "BlockCypherEncryptButton"
        Me.BlockCypherEncryptButton.Size = New System.Drawing.Size(219, 54)
        Me.BlockCypherEncryptButton.TabIndex = 3
        Me.BlockCypherEncryptButton.Text = "Encrypt"
        Me.BlockCypherEncryptButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Block Cyphers"
        '
        'EncryptTextbox
        '
        Me.EncryptTextbox.AcceptsReturn = True
        Me.EncryptTextbox.AcceptsTab = True
        Me.EncryptTextbox.AllowDrop = True
        Me.EncryptTextbox.Location = New System.Drawing.Point(27, 91)
        Me.EncryptTextbox.Multiline = True
        Me.EncryptTextbox.Name = "EncryptTextbox"
        Me.EncryptTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EncryptTextbox.Size = New System.Drawing.Size(440, 312)
        Me.EncryptTextbox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ClearDecryptTextBoxButton)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.OpenTextFileDecryptButton)
        Me.TabPage2.Controls.Add(Me.DecryptTabControl)
        Me.TabPage2.Controls.Add(Me.DecryptTextbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1153, 532)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ClearDecryptTextBoxButton
        '
        Me.ClearDecryptTextBoxButton.Location = New System.Drawing.Point(30, 450)
        Me.ClearDecryptTextBoxButton.Name = "ClearDecryptTextBoxButton"
        Me.ClearDecryptTextBoxButton.Size = New System.Drawing.Size(101, 33)
        Me.ClearDecryptTextBoxButton.TabIndex = 9
        Me.ClearDecryptTextBoxButton.Text = "Clear"
        Me.ClearDecryptTextBoxButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(114, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Please input the Text you would like decrypted below:"
        '
        'OpenTextFileDecryptButton
        '
        Me.OpenTextFileDecryptButton.Location = New System.Drawing.Point(184, 439)
        Me.OpenTextFileDecryptButton.Name = "OpenTextFileDecryptButton"
        Me.OpenTextFileDecryptButton.Size = New System.Drawing.Size(127, 35)
        Me.OpenTextFileDecryptButton.TabIndex = 6
        Me.OpenTextFileDecryptButton.Text = "Open Text File.."
        Me.OpenTextFileDecryptButton.UseVisualStyleBackColor = True
        '
        'DecryptTabControl
        '
        Me.DecryptTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DecryptTabControl.Controls.Add(Me.SteganographyDecryptTab)
        Me.DecryptTabControl.Controls.Add(Me.CeaserCypherDecryptTabPage)
        Me.DecryptTabControl.Controls.Add(Me.RailFenceDecryptTabPage)
        Me.DecryptTabControl.Controls.Add(Me.BlockCypherDecryptTabPage)
        Me.DecryptTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.DecryptTabControl.ItemSize = New System.Drawing.Size(30, 120)
        Me.DecryptTabControl.Location = New System.Drawing.Point(556, 69)
        Me.DecryptTabControl.Multiline = True
        Me.DecryptTabControl.Name = "DecryptTabControl"
        Me.DecryptTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DecryptTabControl.SelectedIndex = 0
        Me.DecryptTabControl.Size = New System.Drawing.Size(567, 388)
        Me.DecryptTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.DecryptTabControl.TabIndex = 5
        '
        'SteganographyDecryptTab
        '
        Me.SteganographyDecryptTab.Controls.Add(Me.SteganographyDecryptTextBox)
        Me.SteganographyDecryptTab.Controls.Add(Me.SteganographyDecryptButton)
        Me.SteganographyDecryptTab.Controls.Add(Me.Label10)
        Me.SteganographyDecryptTab.Location = New System.Drawing.Point(124, 4)
        Me.SteganographyDecryptTab.Name = "SteganographyDecryptTab"
        Me.SteganographyDecryptTab.Size = New System.Drawing.Size(439, 380)
        Me.SteganographyDecryptTab.TabIndex = 0
        Me.SteganographyDecryptTab.Text = "Steganography"
        Me.SteganographyDecryptTab.UseVisualStyleBackColor = True
        '
        'SteganographyDecryptTextBox
        '
        Me.SteganographyDecryptTextBox.Location = New System.Drawing.Point(35, 199)
        Me.SteganographyDecryptTextBox.Multiline = True
        Me.SteganographyDecryptTextBox.Name = "SteganographyDecryptTextBox"
        Me.SteganographyDecryptTextBox.Size = New System.Drawing.Size(370, 136)
        Me.SteganographyDecryptTextBox.TabIndex = 5
        '
        'SteganographyDecryptButton
        '
        Me.SteganographyDecryptButton.Location = New System.Drawing.Point(114, 101)
        Me.SteganographyDecryptButton.Name = "SteganographyDecryptButton"
        Me.SteganographyDecryptButton.Size = New System.Drawing.Size(219, 54)
        Me.SteganographyDecryptButton.TabIndex = 1
        Me.SteganographyDecryptButton.Text = "Decrypt"
        Me.SteganographyDecryptButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(186, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Steganography"
        '
        'CeaserCypherDecryptTabPage
        '
        Me.CeaserCypherDecryptTabPage.Controls.Add(Me.CeaserCypherDecryptTextbox)
        Me.CeaserCypherDecryptTabPage.Controls.Add(Me.CeaserCypherDecryptButton)
        Me.CeaserCypherDecryptTabPage.Controls.Add(Me.Label11)
        Me.CeaserCypherDecryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.CeaserCypherDecryptTabPage.Name = "CeaserCypherDecryptTabPage"
        Me.CeaserCypherDecryptTabPage.Size = New System.Drawing.Size(439, 380)
        Me.CeaserCypherDecryptTabPage.TabIndex = 1
        Me.CeaserCypherDecryptTabPage.Text = "Ceaser Cypher"
        Me.CeaserCypherDecryptTabPage.UseVisualStyleBackColor = True
        '
        'CeaserCypherDecryptTextbox
        '
        Me.CeaserCypherDecryptTextbox.Location = New System.Drawing.Point(35, 199)
        Me.CeaserCypherDecryptTextbox.Multiline = True
        Me.CeaserCypherDecryptTextbox.Name = "CeaserCypherDecryptTextbox"
        Me.CeaserCypherDecryptTextbox.Size = New System.Drawing.Size(370, 136)
        Me.CeaserCypherDecryptTextbox.TabIndex = 5
        '
        'CeaserCypherDecryptButton
        '
        Me.CeaserCypherDecryptButton.Location = New System.Drawing.Point(114, 101)
        Me.CeaserCypherDecryptButton.Name = "CeaserCypherDecryptButton"
        Me.CeaserCypherDecryptButton.Size = New System.Drawing.Size(219, 54)
        Me.CeaserCypherDecryptButton.TabIndex = 2
        Me.CeaserCypherDecryptButton.Text = "Decrypt"
        Me.CeaserCypherDecryptButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(188, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ceaser Cypher"
        '
        'RailFenceDecryptTabPage
        '
        Me.RailFenceDecryptTabPage.Controls.Add(Me.RailFenceDecryptTextBox)
        Me.RailFenceDecryptTabPage.Controls.Add(Me.RailFenceDecryptButton)
        Me.RailFenceDecryptTabPage.Controls.Add(Me.Label12)
        Me.RailFenceDecryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.RailFenceDecryptTabPage.Name = "RailFenceDecryptTabPage"
        Me.RailFenceDecryptTabPage.Size = New System.Drawing.Size(439, 380)
        Me.RailFenceDecryptTabPage.TabIndex = 2
        Me.RailFenceDecryptTabPage.Text = "Rail Fence"
        Me.RailFenceDecryptTabPage.UseVisualStyleBackColor = True
        '
        'RailFenceDecryptTextBox
        '
        Me.RailFenceDecryptTextBox.Location = New System.Drawing.Point(35, 199)
        Me.RailFenceDecryptTextBox.Multiline = True
        Me.RailFenceDecryptTextBox.Name = "RailFenceDecryptTextBox"
        Me.RailFenceDecryptTextBox.Size = New System.Drawing.Size(370, 136)
        Me.RailFenceDecryptTextBox.TabIndex = 5
        '
        'RailFenceDecryptButton
        '
        Me.RailFenceDecryptButton.Location = New System.Drawing.Point(114, 101)
        Me.RailFenceDecryptButton.Name = "RailFenceDecryptButton"
        Me.RailFenceDecryptButton.Size = New System.Drawing.Size(219, 54)
        Me.RailFenceDecryptButton.TabIndex = 3
        Me.RailFenceDecryptButton.Text = "Decrypt"
        Me.RailFenceDecryptButton.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(192, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Rail Fence"
        '
        'BlockCypherDecryptTabPage
        '
        Me.BlockCypherDecryptTabPage.Controls.Add(Me.BlockCypherDecryptTextBox)
        Me.BlockCypherDecryptTabPage.Controls.Add(Me.BlockCypherDecryptButton)
        Me.BlockCypherDecryptTabPage.Controls.Add(Me.Label15)
        Me.BlockCypherDecryptTabPage.Location = New System.Drawing.Point(124, 4)
        Me.BlockCypherDecryptTabPage.Name = "BlockCypherDecryptTabPage"
        Me.BlockCypherDecryptTabPage.Size = New System.Drawing.Size(439, 380)
        Me.BlockCypherDecryptTabPage.TabIndex = 5
        Me.BlockCypherDecryptTabPage.Text = "Block Cyphers"
        Me.BlockCypherDecryptTabPage.UseVisualStyleBackColor = True
        '
        'BlockCypherDecryptTextBox
        '
        Me.BlockCypherDecryptTextBox.Location = New System.Drawing.Point(35, 199)
        Me.BlockCypherDecryptTextBox.Multiline = True
        Me.BlockCypherDecryptTextBox.Name = "BlockCypherDecryptTextBox"
        Me.BlockCypherDecryptTextBox.Size = New System.Drawing.Size(370, 136)
        Me.BlockCypherDecryptTextBox.TabIndex = 5
        '
        'BlockCypherDecryptButton
        '
        Me.BlockCypherDecryptButton.Location = New System.Drawing.Point(114, 101)
        Me.BlockCypherDecryptButton.Name = "BlockCypherDecryptButton"
        Me.BlockCypherDecryptButton.Size = New System.Drawing.Size(219, 54)
        Me.BlockCypherDecryptButton.TabIndex = 3
        Me.BlockCypherDecryptButton.Text = "Decrypt"
        Me.BlockCypherDecryptButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(187, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Block Cyphers"
        '
        'DecryptTextbox
        '
        Me.DecryptTextbox.AcceptsReturn = True
        Me.DecryptTextbox.AcceptsTab = True
        Me.DecryptTextbox.AllowDrop = True
        Me.DecryptTextbox.Location = New System.Drawing.Point(42, 96)
        Me.DecryptTextbox.Multiline = True
        Me.DecryptTextbox.Name = "DecryptTextbox"
        Me.DecryptTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DecryptTextbox.Size = New System.Drawing.Size(440, 312)
        Me.DecryptTextbox.TabIndex = 4
        '
        'TextfileOpendialog
        '
        Me.TextfileOpendialog.DefaultExt = "txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 604)
        Me.Controls.Add(Me.MainTabControl)
        Me.Name = "Form1"
        Me.Text = "Encryption Methods"
        Me.MainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.EncryptorTabControl.ResumeLayout(False)
        Me.SteganographyEncryptTabPage.ResumeLayout(False)
        Me.SteganographyEncryptTabPage.PerformLayout()
        Me.CeaserCypherEncryptTabPage.ResumeLayout(False)
        Me.CeaserCypherEncryptTabPage.PerformLayout()
        Me.RailFenceEncryptTabPage.ResumeLayout(False)
        Me.RailFenceEncryptTabPage.PerformLayout()
        Me.BlockCypherEncryptTabPage.ResumeLayout(False)
        Me.BlockCypherEncryptTabPage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.DecryptTabControl.ResumeLayout(False)
        Me.SteganographyDecryptTab.ResumeLayout(False)
        Me.SteganographyDecryptTab.PerformLayout()
        Me.CeaserCypherDecryptTabPage.ResumeLayout(False)
        Me.CeaserCypherDecryptTabPage.PerformLayout()
        Me.RailFenceDecryptTabPage.ResumeLayout(False)
        Me.RailFenceDecryptTabPage.PerformLayout()
        Me.BlockCypherDecryptTabPage.ResumeLayout(False)
        Me.BlockCypherDecryptTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents EncryptorTabControl As System.Windows.Forms.TabControl
    Friend WithEvents SteganographyEncryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CeaserCypherEncryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents RailFenceEncryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents BlockCypherEncryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents OpenTextFileEncryptButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SteganographyEncryptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SteganographyEncryptButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CeaserCypherEncryptTextbox As System.Windows.Forms.TextBox
    Friend WithEvents CeaserCypherEncryptButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RailFenceEncryptTextbox As System.Windows.Forms.TextBox
    Friend WithEvents RailFenceEncryptButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BlockCyphersEncryptTextbox As System.Windows.Forms.TextBox
    Friend WithEvents BlockCypherEncryptButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OpenTextFileDecryptButton As System.Windows.Forms.Button
    Friend WithEvents DecryptTabControl As System.Windows.Forms.TabControl
    Friend WithEvents SteganographyDecryptTab As System.Windows.Forms.TabPage
    Friend WithEvents SteganographyDecryptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SteganographyDecryptButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CeaserCypherDecryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CeaserCypherDecryptTextbox As System.Windows.Forms.TextBox
    Friend WithEvents CeaserCypherDecryptButton As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RailFenceDecryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents RailFenceDecryptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RailFenceDecryptButton As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BlockCypherDecryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents BlockCypherDecryptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BlockCypherDecryptButton As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DecryptTextbox As System.Windows.Forms.TextBox
    Friend WithEvents TextfileOpendialog As System.Windows.Forms.OpenFileDialog
    Public WithEvents EncryptTextbox As System.Windows.Forms.TextBox
    Friend WithEvents WriteToTextFileButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ClearEncryptTextBox As System.Windows.Forms.Button
    Friend WithEvents ClearDecryptTextBoxButton As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel

End Class
