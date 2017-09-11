﻿'BasicPawn
'Copyright(C) 2017 TheTimocop

'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with this program. If Not, see < http: //www.gnu.org/licenses/>.



Public Class UCObjectBrowser
    Private g_mFormMain As FormMain
    Private g_tUpdateThread As Threading.Thread

    Private g_iControlDrawCoutner As Integer = 0

    Public Shared g_bWndProcBug As Boolean = False

    Public Sub New(f As FormMain)
        g_mFormMain = f

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call. 
    End Sub

    Private g_lObjectsItems As New List(Of STRUC_OBJECTS_ITEM)

    Private g_sSourceMainFileExt As String() = {".sp", ".sma", ".pwn", ".p", "BasicPawn.exe", ".src"}

    Class STRUC_OBJECTS_ITEM
        Public g_sFile As String
        Public g_sType As String
        Public g_sName As String
        Public g_sNodeKey As String

        Public Sub New(sFile As String, sType As String, sName As String, sNodeKey As String)
            g_sFile = sFile
            g_sType = sType
            g_sName = sName
            g_sNodeKey = sNodeKey
        End Sub
    End Class

    ReadOnly Property m_IsUpdating As Boolean
        Get
            Return g_tUpdateThread IsNot Nothing AndAlso g_tUpdateThread.IsAlive
        End Get
    End Property

    Public Sub StartUpdate()
        If (g_tUpdateThread Is Nothing OrElse Not g_tUpdateThread.IsAlive) Then
            g_tUpdateThread = New Threading.Thread(AddressOf UpdateTreeViewThread) With {
                .Priority = Threading.ThreadPriority.Lowest,
                .IsBackground = True
            }
            g_tUpdateThread.Start()
        End If
    End Sub

    Public Sub StopUpdate()
        If (g_tUpdateThread IsNot Nothing AndAlso g_tUpdateThread.IsAlive) Then
            g_tUpdateThread.Abort()
            g_tUpdateThread.Join()
            g_tUpdateThread = Nothing
        End If
    End Sub

    Private Sub UpdateTreeViewThread()
        Try
            Dim bWndProcBug As Boolean = g_bWndProcBug

            If (bWndProcBug) Then
                Me.Invoke(Sub()
                              TreeView_ObjectBrowser.Enabled = False
                              TreeView_ObjectBrowser.Visible = False
                          End Sub)
            Else
                Me.Invoke(Sub()
                              TreeView_ObjectBrowser.Enabled = False
                              ClassTools.ClassForms.SuspendDrawing(g_iControlDrawCoutner, TreeView_ObjectBrowser)
                          End Sub)
            End If

            Dim mActiveTab As ClassTabControl.SourceTabPage = DirectCast(g_mFormMain.Invoke(Function() g_mFormMain.g_ClassTabControl.m_ActiveTab), ClassTabControl.SourceTabPage)

            Dim lAutocompleteList As New List(Of ClassSyntaxTools.STRUC_AUTOCOMPLETE)
            lAutocompleteList.AddRange(mActiveTab.m_AutocompleteItems.ToArray)

            If (True) Then
                Dim i As Integer
                For i = 0 To lAutocompleteList.Count - 1
                    If (Not ClassSettings.g_iSettingsVarAutocompleteShowObjectBrowser) Then
                        If ((lAutocompleteList(i).m_Type And ClassSyntaxTools.STRUC_AUTOCOMPLETE.ENUM_TYPE_FLAGS.VARIABLE) = ClassSyntaxTools.STRUC_AUTOCOMPLETE.ENUM_TYPE_FLAGS.VARIABLE) Then
                            Continue For
                        End If
                    End If

                    'Add missing nodes
                    Dim sFile As String = lAutocompleteList(i).m_File
                    Dim bIsMainFile As Boolean = Array.Exists(g_sSourceMainFileExt, Function(s As String) sFile.ToLower.EndsWith(s.ToLower))
                    If (Not CBool(Me.Invoke(Function() TreeView_ObjectBrowser.Nodes.ContainsKey(sFile)))) Then
                        If (bIsMainFile) Then
                            Me.Invoke(Sub()
                                          Dim mTreeNode = TreeView_ObjectBrowser.Nodes.Insert(0, sFile, sFile)
                                          mTreeNode.NodeFont = New Font(TreeView_ObjectBrowser.Font, FontStyle.Regular)
                                      End Sub)
                        Else
                            Me.Invoke(Sub()
                                          Dim mTreeNode = TreeView_ObjectBrowser.Nodes.Add(sFile, sFile)
                                          mTreeNode.NodeFont = New Font(TreeView_ObjectBrowser.Font, FontStyle.Italic)
                                      End Sub)
                        End If
                    End If

                    Dim iTypes As Integer = lAutocompleteList(i).m_Type
                    Dim sTypes As String = If(String.IsNullOrEmpty(lAutocompleteList(i).GetTypeFullNames), "private", lAutocompleteList(i).GetTypeFullNames.ToLower)
                    If (Not CBool(Me.Invoke(Function() TreeView_ObjectBrowser.Nodes(sFile).Nodes.ContainsKey(sTypes)))) Then
                        Me.Invoke(Sub() TreeView_ObjectBrowser.Nodes(sFile).Nodes.Add(sTypes, sTypes))
                    End If

                    Dim sName As String = lAutocompleteList(i).m_FunctionName
                    If (Not CBool(Me.Invoke(Function() TreeView_ObjectBrowser.Nodes(sFile).Nodes(sTypes).Nodes.ContainsKey(sName)))) Then
                        Me.Invoke(Sub() TreeView_ObjectBrowser.Nodes(sFile).Nodes(sTypes).Nodes.Add(New ClassTreeNodeAutocomplete(sName, sName, sFile, iTypes, sName)))
                    End If

                    If (bIsMainFile) Then
                        Me.Invoke(Sub() TreeView_ObjectBrowser.Nodes(sFile).ExpandAll())
                    End If
                Next
            End If


            'Remove invalid nodes 
            If (True) Then
                Dim mFileNodes As TreeNodeCollection = CType(Me.Invoke(Function() TreeView_ObjectBrowser.Nodes), TreeNodeCollection)
                Dim mTypeNodes As TreeNodeCollection
                Dim mNameNodes As TreeNodeCollection
                Dim i As Integer
                For i = mFileNodes.Count - 1 To 0 Step -1
                    mTypeNodes = mFileNodes(i).Nodes

                    Dim j As Integer
                    For j = mTypeNodes.Count - 1 To 0 Step -1
                        mNameNodes = mTypeNodes(j).Nodes

                        Dim l As Integer
                        For l = mNameNodes.Count - 1 To 0 Step -1
                            Dim mTreeNodeAutocomplete As ClassTreeNodeAutocomplete = TryCast(mNameNodes(l), ClassTreeNodeAutocomplete)
                            If (mTreeNodeAutocomplete Is Nothing) Then
                                Me.Invoke(Sub() mNameNodes(l).Remove())
                                Continue For
                            End If

                            If (Not lAutocompleteList.Exists(Function(m As ClassSyntaxTools.STRUC_AUTOCOMPLETE) m.m_File = mTreeNodeAutocomplete.g_sFile AndAlso m.m_Type = mTreeNodeAutocomplete.g_iType AndAlso m.m_FunctionName = mTreeNodeAutocomplete.g_sFunction)) Then
                                Me.Invoke(Sub() mNameNodes(l).Remove())
                            End If
                        Next

                        If (mTypeNodes(j).Nodes.Count < 1) Then
                            Me.Invoke(Sub() mTypeNodes(j).Remove())
                        End If
                    Next

                    If (mFileNodes(i).Nodes.Count < 1) Then
                        Me.Invoke(Sub() mFileNodes(i).Remove())
                    End If
                Next
            End If

            lAutocompleteList = Nothing

            If (bWndProcBug) Then
                Me.Invoke(Sub()
                              TreeView_ObjectBrowser.Visible = True
                              TreeView_ObjectBrowser.Enabled = True
                          End Sub)
            Else
                Me.Invoke(Sub()
                              ClassTools.ClassForms.ResumeDrawing(g_iControlDrawCoutner, TreeView_ObjectBrowser)
                              TreeView_ObjectBrowser.Enabled = True
                          End Sub)
            End If
        Catch ex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Class ClassTreeNodeAutocomplete
        Inherits TreeNode

        Public g_sFile As String
        Public g_iType As Integer
        Public g_sFunction As String

        Public Sub New(sText As String, sKey As String, sFile As String, iType As Integer, sFunction As String)
            Text = sText
            Name = sKey

            g_sFile = sFile
            g_iType = iType
            g_sFunction = sFunction
        End Sub


    End Class

    Private Sub TextboxWatermark_Search_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextboxWatermark_Search.PreviewKeyDown
        If (e.KeyCode <> Keys.Enter) Then
            Return
        End If

        Dim sSearchText As String = TextboxWatermark_Search.Text
        If (String.IsNullOrEmpty(sSearchText)) Then
            Return
        End If

        Dim mTreeNodes As TreeNode() = GetAllTreeViewNodes(TreeView_ObjectBrowser)

        Dim iSelectedIndex As Integer = -1
        For i = 0 To mTreeNodes.Length - 1
            If (mTreeNodes(i).IsSelected) Then
                iSelectedIndex = i
                Exit For
            End If
        Next

        While True
            For i = iSelectedIndex + 1 To mTreeNodes.Length - 1
                If (mTreeNodes(i).Text.ToLower.Contains(sSearchText.ToLower)) Then
                    TreeView_ObjectBrowser.SelectedNode = mTreeNodes(i)
                    TreeView_ObjectBrowser.SelectedNode.EnsureVisible()
                    Exit While
                End If
            Next

            For i = 0 To mTreeNodes.Length - 1
                If (mTreeNodes(i).Text.ToLower.Contains(sSearchText.ToLower)) Then
                    TreeView_ObjectBrowser.SelectedNode = mTreeNodes(i)
                    TreeView_ObjectBrowser.SelectedNode.EnsureVisible()
                    Exit While
                End If
            Next

            Exit While
        End While
    End Sub

    Private Function GetAllTreeViewNodes(mTreeView As TreeView) As TreeNode()
        Dim lTreeNodes As New List(Of TreeNode)

        For Each mItem As TreeNode In mTreeView.Nodes
            lTreeNodes.AddRange(GetAllTreeViewNodes(mItem))
        Next

        Return lTreeNodes.ToArray
    End Function

    Private Function GetAllTreeViewNodes(mTreeNode As TreeNode) As TreeNode()
        Dim lTreeNodes As New List(Of TreeNode) From {
            mTreeNode
        }

        For Each mItem As TreeNode In mTreeNode.Nodes
            lTreeNodes.AddRange(GetAllTreeViewNodes(mItem))
        Next

        Return lTreeNodes.ToArray
    End Function


    Private Sub ContextMenuStrip_ObjectBrowser_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_ObjectBrowser.Opening
        If (TreeView_ObjectBrowser.SelectedNode Is Nothing) Then
            Return
        End If

        ToolStripMenuItem_OpenFile.Enabled = (TreeView_ObjectBrowser.SelectedNode.Level = 0)
        ToolStripMenuItem_ListReferences.Enabled = (TreeView_ObjectBrowser.SelectedNode.Level = 2 AndAlso System.Text.RegularExpressions.Regex.IsMatch(TreeView_ObjectBrowser.SelectedNode.Text, "^[a-zA-Z0-9_]+$"))
        ToolStripMenuItem_Copy.Enabled = (TreeView_ObjectBrowser.SelectedNode.Level = 2 OrElse TreeView_ObjectBrowser.SelectedNode.Level = 0)
    End Sub

    Private Sub ToolStripMenuItem_OpenFile_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_OpenFile.Click
        Try
            If (TreeView_ObjectBrowser.SelectedNode Is Nothing OrElse TreeView_ObjectBrowser.SelectedNode.Level <> 0) Then
                Return
            End If

            For Each sPath As String In g_mFormMain.g_ClassTabControl.m_ActiveTab.m_IncludeFiles.ToArray
                If (IO.Path.GetFileName(sPath).ToLower <> TreeView_ObjectBrowser.SelectedNode.Text.ToLower) Then
                    Continue For
                End If

                Dim mTab = g_mFormMain.g_ClassTabControl.AddTab()
                mTab.OpenFileTab(sPath)
                mTab.SelectTab(500)
            Next
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_ListReferences_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_ListReferences.Click
        Try
            If (TreeView_ObjectBrowser.SelectedNode Is Nothing OrElse TreeView_ObjectBrowser.SelectedNode.Level <> 2) Then
                Return
            End If

            g_mFormMain.g_ClassTextEditorTools.ListReferences(TreeView_ObjectBrowser.SelectedNode.Text)
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Copy_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Copy.Click
        Try
            If (TreeView_ObjectBrowser.SelectedNode Is Nothing) Then
                Return
            End If

            If (TreeView_ObjectBrowser.SelectedNode.Level <> 2 AndAlso TreeView_ObjectBrowser.SelectedNode.Level <> 0) Then
                Return
            End If

            My.Computer.Clipboard.SetText(TreeView_ObjectBrowser.SelectedNode.Text)
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub TreeView_ObjectBrowser_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TreeView_ObjectBrowser.MouseDoubleClick
        Try
            If (TreeView_ObjectBrowser.SelectedNode Is Nothing OrElse TreeView_ObjectBrowser.SelectedNode.Level <> 2) Then
                Return
            End If

            g_mFormMain.g_ClassTextEditorTools.ListReferences(TreeView_ObjectBrowser.SelectedNode.Text)
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Class ClassTreeViewFix
        Inherits TreeView

        Protected Overrides Sub WndProc(ByRef m As Message)
            Try
                MyBase.WndProc(m)
            Catch ex As Exception
                If (Not g_bWndProcBug) Then
                    g_bWndProcBug = True
                    ClassExceptionLog.WriteToLog(ex)
                End If
            End Try
        End Sub
    End Class
End Class
