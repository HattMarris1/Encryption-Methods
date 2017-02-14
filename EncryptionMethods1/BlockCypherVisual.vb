Public Class BlockCypherVisual

    Private Sub BlockCypherVisual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'makes the nodes and lines invisible, so they can fade on the button press
        maketheencryptednodesandlinesinvisible()
        Application.DoEvents()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'fades in the lines and panels one at a time
        fadeinlines(Color.Black, LineShape5)

        fadeinpanels(Color.Firebrick, CypherTextPanel1)
        fadeinlines(Color.Black, LineShape6)
        fadeinlines(Color.Black, LineShape7)
        fadeinlines(Color.Black, LineShape8)
        fadeinlines(Color.Black, LineShape9)
        Application.DoEvents()

        fadeinlines(Color.Black, LineShape11)
        fadeinpanels(Color.Firebrick, CypherTextPanel2)
        fadeinlines(Color.Black, LineShape12)
        fadeinlines(Color.Black, LineShape13)
        fadeinlines(Color.Black, LineShape14)
        fadeinlines(Color.Black, LineShape15)
        Application.DoEvents()

        fadeinlines(Color.Black, LineShape17)
        fadeinpanels(Color.Firebrick, CypherTextPanel3)
        fadeinlines(Color.Black, LineShape18)
        fadeinlines(Color.Black, LineShape19)
        fadeinlines(Color.Black, LineShape20)
        fadeinlines(Color.Black, LineShape21)
        Application.DoEvents()

        fadeinlines(Color.Black, LineShape23)
        fadeinpanels(Color.Firebrick, CypherTextPanel4)
        fadeinlines(Color.Black, LineShape24)
        fadeinlines(Color.Black, LineShape25)
        fadeinlines(Color.Black, LineShape26)
        fadeinlines(Color.Black, LineShape27)

        fadeinpanels(Color.Firebrick, CypherTextPanel5)
    End Sub

    Public Sub fadeinlines(thecolour As Color, theline As Microsoft.VisualBasic.PowerPacks.LineShape)

        theline.Visible = True
        For looper = 0 To 255 Step 10
            theline.BorderColor = Color.FromArgb(looper, thecolour)
            Application.DoEvents()
            wastetime(10000000)
        Next

    End Sub

    Public Sub fadeinpanels(thecolour As Color, thepanel As Panel)
        thepanel.Visible = True
        For looper = 0 To 255
            wastetime(100)

            thepanel.BackColor = Color.FromArgb(looper, thecolour)
            thepanel.ForeColor = Color.FromArgb(looper, SystemColors.Control)
            Application.DoEvents()
        Next
    End Sub

    Public Sub wastetime(ByVal timetowaste As Long)
        'wastes time by looping a specified number of times
        For looper = 0 To timetowaste
        Next
    End Sub

    Public Sub maketheencryptednodesandlinesinvisible()
        'makes the nodes and lines invisible
        CypherTextPanel1.Visible = False
        CypherTextPanel2.Visible = False
        CypherTextPanel3.Visible = False
        CypherTextPanel4.Visible = False
        CypherTextPanel5.Visible = False

        LineShape5.Visible = False
        LineShape6.Visible = False
        LineShape7.Visible = False
        LineShape8.Visible = False
        LineShape9.Visible = False

        LineShape11.Visible = False
        LineShape12.Visible = False
        LineShape13.Visible = False
        LineShape14.Visible = False
        LineShape15.Visible = False

        LineShape17.Visible = False
        LineShape18.Visible = False
        LineShape19.Visible = False
        LineShape20.Visible = False
        LineShape21.Visible = False

        LineShape23.Visible = False
        LineShape24.Visible = False
        LineShape25.Visible = False
        LineShape26.Visible = False
        LineShape27.Visible = False
    End Sub
End Class