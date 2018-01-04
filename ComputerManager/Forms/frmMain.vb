Imports System.Windows.Forms

''' <summary>
''' Main Form.
''' </summary>
''' <remarks></remarks>
Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Read the help path 
        Dim strRegHelpPath As String = My.Application.Info.DirectoryPath
        ' Try to find the help file in the current culture
        Dim strLocalizedHelpFile As String = strRegHelpPath & "\" & Threading.Thread.CurrentThread.CurrentUICulture.Name.Substring(0, 2) & "\" & "Documentation.chm"
        If System.IO.File.Exists(strLocalizedHelpFile) Then
            ' If the help file relative to the current UI culture (2 letters) is found, set it to the help provider. 
            Me.HelpProvider1.HelpNamespace = strLocalizedHelpFile
        Else
            ' Use the default culture help file
            Me.HelpProvider1.HelpNamespace = strRegHelpPath & "\" & "Documentation.chm"
        End If

    End Sub

#Region "File"

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) _
        Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click

        Using frmChooseComputer As New frmChooseComputer

            If frmChooseComputer.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ' If OK chosen
                Me.OpenForm(frmChooseComputer.txtComputerName.Text)
            End If
        End Using

    End Sub

    Private Sub OpenForm(ByVal ComputerName As String)

        Me.Cursor = Cursors.AppStarting

        ' Change . for the computer name for clarification
        If ComputerName = "." Then
            ComputerName = My.Computer.Name
        End If

        ' Is it already open?
        Dim blnAlreadyOpen As Boolean = False
        For Each frmComputerI As frmComputer In Me.MdiChildren
            With frmComputerI
                If .Computer.ComputerName = ComputerName Then
                    ' The computer form is already open
                    .Show()
                    .Focus()
                    blnAlreadyOpen = True
                End If
            End With
        Next

        If blnAlreadyOpen Then
            ' Already open: beep
            Beep()
        Else
            ' If it is not already open, open the form
            Dim NewMDIChild As New frmComputer(ComputerName)
            With NewMDIChild
                ' Set the MDI parent
                .MdiParent = Me
                .Show()
            End With
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "View"

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) _
           Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

 #End Region

#Region "Windows"

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

#End Region

#Region "Help"

    ''' <summary>
    ''' Run when Help / About menu is clicked.
    ''' </summary>
    ''' <param name="sender">The object that fired the event.</param>
    ''' <param name="e">Arguments</param>
    ''' <remarks></remarks>
    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ContentsToolStripMenuItem.Click

        Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace)

    End Sub

    ''' <summary>
    ''' Run when Help / Index menu is clicked.
    ''' </summary>
    ''' <param name="sender">The object that fired the event.</param>
    ''' <param name="e">Arguments</param>
    ''' <remarks></remarks>
    Private Sub IndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
         Handles IndexToolStripMenuItem.Click, HelpToolStripButton.Click

        Help.ShowHelpIndex(Me, Me.HelpProvider1.HelpNamespace)

    End Sub

    ''' <summary>
    ''' Run when Help / Search menu is clicked.
    ''' </summary>
    ''' <param name="sender">The object that fired the event.</param>
    ''' <param name="e">Arguments</param>
    ''' <remarks></remarks>
    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
          Handles SearchToolStripMenuItem.Click

        Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.Find, "")

    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAboutBox.ShowDialog(Me)
    End Sub

#End Region

End Class
