Imports System.IO

Module Input
    'reading from a text file
    Private theplaintext As String

    Public Sub readtextfromtextfile(ByVal thefilename As String)
        'reads the text in the input text file and stores it in theplaintext variable
        theplaintext = ""

        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader(thefilename)
            ' Read one line from file
            Dim line As String

            ' Read first line.q 
            line = reader.ReadLine

            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                theplaintext = theplaintext & vbCrLf & line
                line = reader.ReadLine
            Loop
        End Using
    End Sub

    Public Sub copyintotextbox(ByRef Textbox As TextBox)
        'copys the text from theplaintext into the text box
        Textbox.Text = Textbox.Text & theplaintext & vbCrLf
    End Sub

    'Writing to a text file
    Private thetexttobewritten As String

    Public Sub WriteintoTextfile(ByVal thetextbox As TextBox, ByVal textfilename As String)
        'writes the text into a text file
        FileOpen(1, textfilename, OpenMode.Output)
        PrintLine(1, thetextbox.Text)
        FileClose(1)
    End Sub
End Module
