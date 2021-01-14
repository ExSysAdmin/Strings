Public Class Form1
    Public EditFile As String = ""
    Public UnnsavedChanges As Boolean = False

    Private Sub TrimLeftBtn_Click(sender As Object, e As EventArgs) Handles TrimLeftBtn.Click
        Dim CurrentString As String = StringTextBox.Text
        Dim NewString As String = ""
        Dim StringArray As String() = Split(CurrentString, vbCrLf)
        For Each Line As String In StringArray
            If NewString = "" Then
                NewString = LTrim(Line)
            Else
                NewString = NewString & vbCrLf & LTrim(Line)
            End If
        Next
        StringTextBox.Text = NewString
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
        CurrentString = Nothing
        NewString = Nothing
        StringArray = Nothing
    End Sub

    Private Sub TrimBtn_Click(sender As Object, e As EventArgs) Handles TrimBtn.Click
        Dim CurrentString As String = StringTextBox.Text
        Dim NewString As String = ""
        Dim StringArray As String() = Split(CurrentString, vbCrLf)
        For Each Line As String In StringArray
            If NewString = "" Then
                NewString = Trim(Line)
            Else
                NewString = NewString & vbCrLf & Trim(Line)
            End If
        Next
        StringTextBox.Text = NewString
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
        CurrentString = Nothing
        NewString = Nothing
        StringArray = Nothing
    End Sub

    Private Sub TrimRightBtn_Click(sender As Object, e As EventArgs) Handles TrimRightBtn.Click
        Dim CurrentString As String = StringTextBox.Text
        Dim NewString As String = ""
        Dim StringArray As String() = Split(CurrentString, vbCrLf)
        For Each Line As String In StringArray
            If NewString = "" Then
                NewString = RTrim(Line)
            Else
                NewString = NewString & vbCrLf & RTrim(Line)
            End If
        Next
        StringTextBox.Text = NewString
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
        CurrentString = Nothing
        NewString = Nothing
        StringArray = Nothing
    End Sub

    Private Sub UCaseBtn_Click(sender As Object, e As EventArgs) Handles UCaseBtn.Click
        Dim CurrentString As String = StringTextBox.Text
        Dim NewString As String = ""
        Dim StringArray As String() = Split(CurrentString, vbCrLf)
        For Each Line As String In StringArray
            If NewString = "" Then
                NewString = UCase(Line)
            Else
                NewString = NewString & vbCrLf & UCase(Line)
            End If
        Next
        StringTextBox.Text = NewString
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
        CurrentString = Nothing
        NewString = Nothing
        StringArray = Nothing
    End Sub

    Private Sub LCaseBtn_Click(sender As Object, e As EventArgs) Handles LCaseBtn.Click
        Dim CurrentString As String = StringTextBox.Text
        Dim NewString As String = ""
        Dim StringArray As String() = Split(CurrentString, vbCrLf)
        For Each Line As String In StringArray
            If NewString = "" Then
                NewString = LCase(Line)
            Else
                NewString = NewString & vbCrLf & LCase(Line)
            End If
        Next
        StringTextBox.Text = NewString
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
        CurrentString = Nothing
        NewString = Nothing
        StringArray = Nothing
    End Sub

    Private Sub RemoveBlankLinesBtn_Click(sender As Object, e As EventArgs) Handles RemoveBlankLinesBtn.Click
        Dim CurrentString As String = StringTextBox.Text
        Dim NewString As String = ""
        Dim StringArray As String() = Split(CurrentString, vbCrLf)
        For Each Line As String In StringArray
            If Not Trim(Line) = "" Then
                If NewString = "" Then
                    NewString = Line
                Else
                    NewString = NewString & vbCrLf & Line
                End If
            End If
        Next
        StringTextBox.Text = NewString
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
        CurrentString = Nothing
        NewString = Nothing
        StringArray = Nothing
    End Sub

    Private Sub ClipboardBtn_Click(sender As Object, e As EventArgs) Handles ClipboardBtn.Click
        My.Computer.Clipboard.SetText(StringTextBox.Text)
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        StringTextBox.Text = ""
        If EditFile <> "" Then
            UnnsavedChanges = True
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim NewOpenFileDialog As OpenFileDialog = New OpenFileDialog
        If NewOpenFileDialog.ShowDialog = DialogResult.OK Then
            If NewOpenFileDialog.FileName <> "" Then
                If My.Computer.FileSystem.FileExists(NewOpenFileDialog.FileName) Then
                    EditFile = NewOpenFileDialog.FileName
                    StringTextBox.Text = My.Computer.FileSystem.ReadAllText(EditFile)
                    MainTabPage.Text = EditFile

                    ' /// File Menu Actions ///
                    OpenToolStripMenuItem.Enabled = False
                    SaveToolStripMenuItem.Enabled = True
                    SaveToolStripMenuItem.Text = "Save - " & EditFile
                    SaveAsToolStripMenuItem.Enabled = False
                    CloseToolStripMenuItem.Enabled = True
                    CloseToolStripMenuItem.Text = "Close - " & EditFile


                    If EditFile <> "" Then
                        UnnsavedChanges = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If EditFile <> "" Then
            My.Computer.FileSystem.WriteAllText(EditFile, StringTextBox.Text, False)
            If EditFile <> "" Then
                UnnsavedChanges = False
            End If
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim NewSaveFileDialog As SaveFileDialog = New SaveFileDialog
        If NewSaveFileDialog.ShowDialog = DialogResult.OK Then
            If NewSaveFileDialog.FileName <> "" Then
                EditFile = NewSaveFileDialog.FileName
                If Not My.Computer.FileSystem.FileExists(EditFile) Then
                    My.Computer.FileSystem.WriteAllText(EditFile, StringTextBox.Text, False)
                    MainTabPage.Text = EditFile

                    ' /// File Menu Actions ///
                    OpenToolStripMenuItem.Enabled = False
                    SaveToolStripMenuItem.Enabled = True
                    SaveToolStripMenuItem.Text = "Save - " & EditFile
                    SaveAsToolStripMenuItem.Enabled = False
                    CloseToolStripMenuItem.Enabled = True
                    CloseToolStripMenuItem.Text = "Close - " & EditFile

                    If EditFile <> "" Then
                        UnnsavedChanges = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If EditFile <> "" Then
            If UnnsavedChanges Then
                Dim CloseResponse As MsgBoxResult = MsgBox("Do you want to save changes to " & EditFile, MsgBoxStyle.YesNoCancel, "Close.")
                If CloseResponse = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.WriteAllText(EditFile, StringTextBox.Text, False)
                    EditFile = ""
                    MainTabPage.Text = "New"
                    StringTextBox.Text = ""

                    ' /// File Menu Actions ///
                    OpenToolStripMenuItem.Enabled = True
                    SaveToolStripMenuItem.Enabled = False
                    SaveToolStripMenuItem.Text = "Save"
                    SaveAsToolStripMenuItem.Enabled = False
                    CloseToolStripMenuItem.Enabled = False
                    CloseToolStripMenuItem.Text = "Close"

                ElseIf CloseResponse = MsgBoxResult.No Then
                    EditFile = ""
                    MainTabPage.Text = "New"
                    StringTextBox.Text = ""

                    ' /// File Menu Actions ///
                    OpenToolStripMenuItem.Enabled = True
                    SaveToolStripMenuItem.Enabled = False
                    SaveToolStripMenuItem.Text = "Save"
                    SaveAsToolStripMenuItem.Enabled = False
                    CloseToolStripMenuItem.Enabled = False
                    CloseToolStripMenuItem.Text = "Close"

                Else
                    ' /// Cancelled ///
                End If
            Else
                EditFile = ""
                MainTabPage.Text = "New"
                StringTextBox.Text = ""

                ' /// File Menu Actions ///
                OpenToolStripMenuItem.Enabled = True
                SaveToolStripMenuItem.Enabled = False
                SaveToolStripMenuItem.Text = "Save"
                SaveAsToolStripMenuItem.Enabled = False
                CloseToolStripMenuItem.Enabled = False
                CloseToolStripMenuItem.Text = "Close"

            End If
        Else

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If EditFile <> "" And UnnsavedChanges = True Then
            ' ////////////////////////
            ' ///  Save Then Exit  ///
            ' ////////////////////////
            Dim ExitSaveResponse As MsgBoxResult = MsgBox("Do you want to save changes to " & EditFile, MsgBoxStyle.YesNoCancel, "Exit")
            If ExitSaveResponse = MsgBoxResult.Yes Then
                ' Save then Exit
                My.Computer.FileSystem.WriteAllText(EditFile, StringTextBox.Text, False)
                Me.Close()
            ElseIf ExitSaveResponse = MsgBoxResult.No Then
                ' Just Exit
                Me.Close()
            Else
                ' Do Nothing
            End If
        End If

        If EditFile = "" And UnnsavedChanges = True And Trim(StringTextBox.Text) <> "" Then
            ' ////////////////////////
            ' /// SaveAs Then Exit ///
            ' ////////////////////////
            Dim ExitSaveAsResponse As MsgBoxResult = MsgBox("Do you want to save your work?", MsgBoxStyle.YesNoCancel, "Exit")
            If ExitSaveAsResponse = MsgBoxResult.Yes Then
                ' Save As then Exit
                Dim NewSaveFileDialog As SaveFileDialog = New SaveFileDialog
                NewSaveFileDialog.OverwritePrompt = True
                If NewSaveFileDialog.ShowDialog = DialogResult.OK And NewSaveFileDialog.FileName <> "" Then
                    My.Computer.FileSystem.WriteAllText(NewSaveFileDialog.FileName, StringTextBox.Text, False)
                    Me.Close()
                End If
            ElseIf ExitSaveAsResponse = MsgBoxResult.No Then
                ' Just Exit
                Me.Close()
            Else
                ' Do Nothing
            End If
        End If

        If (EditFile = "" And UnnsavedChanges = False) Or (EditFile = "" And Trim(StringTextBox.Text) = "") Then
            Me.Close()
        End If

    End Sub

    Private Sub StringTextBox_TextChanged(sender As Object, e As EventArgs) Handles StringTextBox.TextChanged
        UnnsavedChanges = True
        If EditFile = "" Then
            SaveAsToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim AboutForm As AboutBox1 = New AboutBox1()
        AboutForm.ShowDialog()
    End Sub
End Class
