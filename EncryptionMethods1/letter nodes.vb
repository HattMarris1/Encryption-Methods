Public Class letter_nodes
    Private letterinthenode As Char
    Private labelcontainingletter As Label
    Private nodepanel As Panel
    Private labelfont As Font

    Public Sub New(ByVal letter As Char, ByRef theform As Form, ByVal theposition As Point, thecoulour As Color)
        'creates a letter node in a specified form, in a specified postion, with a specified colour
        Me.nodepanel = New Panel

        labelfont = New Font("impact", 32)
        'places the panel in a specific place 
        nodepanel.SetBounds(theposition.X, theposition.Y, 50, 50)
        nodepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        'sets the opacity of the backcolour to 0, so the fadein starts at 0
        nodepanel.BackColor = Color.FromArgb(0, thecoulour)

        'defines a lable to put the letter in
        Me.labelcontainingletter = New Label
        labelcontainingletter.Font = labelfont
        labelcontainingletter.Text = letter

        'adds the panel to the form
        nodepanel.Controls.Add(Me.labelcontainingletter)

        labelcontainingletter.SetBounds(0, 0, 50, 50)
        labelcontainingletter.Text = letter
        theform.Controls.Add(nodepanel)
        fadein()
    End Sub
    Public Sub fadein()
        'fades in the panel by increasing the back colours opacity
        For looper = 0 To 255
            wastetime(3000)
            nodepanel.BackColor = Color.FromArgb(looper, nodepanel.BackColor)
            labelcontainingletter.ForeColor = Color.FromArgb(looper, SystemColors.Control)
            Application.DoEvents()
        Next
    End Sub
    Public Sub GoDown(ByVal amount As Integer)
        'moves the panel down a specified amount
        Dim TempPoint As Point
        TempPoint = Me.nodepanel.Location
        TempPoint.Y = TempPoint.Y + amount
        Me.nodepanel.Location = TempPoint
        Application.DoEvents()
    End Sub

    Public Sub GoRight(ByVal amount As Integer)
        'moves the panel to the right a specified amount
        Dim TempPoint As Point
        TempPoint = Me.nodepanel.Location
        TempPoint.X = TempPoint.X + amount
        Me.nodepanel.Location = TempPoint
        Application.DoEvents()
    End Sub

    Public Sub GoUp(ByVal amount As Integer)
        'Moves the panel up a specified amount
        Dim TempPoint As Point
        TempPoint = Me.nodepanel.Location
        TempPoint.Y = TempPoint.Y - amount
        Me.nodepanel.Location = TempPoint
        Application.DoEvents()
    End Sub

    Public Sub fadeout()
        'fades out the panel by decreasing the back colours opacity
        For looper = 255 To 0 Step -1
            wastetime(3000)
            nodepanel.BackColor = Color.FromArgb(looper, nodepanel.BackColor)
            labelcontainingletter.ForeColor = Color.FromArgb(looper, labelcontainingletter.ForeColor)
            nodepanel.BorderStyle = BorderStyle.None
            Application.DoEvents()
        Next
        GoDown(300)
    End Sub

    Public Sub wastetime(ByVal timetowaste As Long)
        'wastes time by looping a specified number of times
        For looper = 0 To timetowaste
            Application.DoEvents()
        Next
    End Sub

    Public Function getnodepanel()
        'getter for the letter nodes panel
        Return nodepanel
    End Function
End Class
