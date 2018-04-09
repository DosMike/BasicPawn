﻿'BasicPawn
'Copyright(C) 2018 TheTimocop

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


Public Class FormDebuggerException
    Private g_mFormDebugger As FormDebugger
    Private g_sLogFile As String = ""

    Private Const MAX_LINES_TO_LIST = 100

    Public Sub New(mFormDebugger As FormDebugger, sLogFile As String, smException As ClassDebuggerParser.STRUC_SM_EXCEPTION)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Panel_FooterControl.Name &= "@FooterControl"
        Panel_FooterDarkControl.Name &= "@FooterDarkControl"
        Label_Title.Name &= "@TitleColors"

        g_mFormDebugger = mFormDebugger
        g_sLogFile = sLogFile

        Label_ExceptionInfo.Text = "Exception: " & smException.sExceptionInfo
        Label_Date.Text = "Date: " & smException.dLogDate.ToString

        ListView_StackTrace.BeginUpdate()
        Dim iIndex As Integer = 0
        For Each stackTrace In smException.mStackTraces
            Dim iRealLine As Integer = -1
            Dim sFile As String = ""

            If (stackTrace.iLine > -1 AndAlso stackTrace.iLine < g_mFormDebugger.g_ClassDebuggerRunner.g_mSourceLinesInfo.Length) Then
                Dim info = g_mFormDebugger.g_ClassDebuggerRunner.g_mSourceLinesInfo(stackTrace.iLine)
                iRealLine = info.iRealLine - 1
                sFile = info.sFile
            End If

            If (stackTrace.sFileName = g_mFormDebugger.g_ClassDebuggerRunner.m_PluginIdentity) Then
                Dim mListViewItemData As New ClassListViewItemData(New String() {
                                                          CStr(iIndex),
                                                          CStr(stackTrace.iLine),
                                                          CStr(iRealLine),
                                                          sFile,
                                                          stackTrace.sFunctionName})

                mListViewItemData.g_mData("Index") = iIndex
                mListViewItemData.g_mData("Line") = stackTrace.iLine
                mListViewItemData.g_mData("RealLine") = iRealLine
                mListViewItemData.g_mData("File") = sFile
                mListViewItemData.g_mData("FunctionName") = stackTrace.sFunctionName

                ListView_StackTrace.Items.Add(mListViewItemData)
            Else
                Dim mListViewItemData As New ClassListViewItemData(New String() {
                                                          CStr(iIndex),
                                                          "-1",
                                                          CStr(iRealLine),
                                                          sFile,
                                                          stackTrace.sFunctionName})

                mListViewItemData.g_mData("Index") = iIndex
                mListViewItemData.g_mData("Line") = stackTrace.iLine
                mListViewItemData.g_mData("RealLine") = iRealLine
                mListViewItemData.g_mData("File") = sFile
                mListViewItemData.g_mData("FunctionName") = stackTrace.sFunctionName

                ListView_StackTrace.Items.Add(mListViewItemData)
            End If

            iIndex += 1
        Next
        ListView_StackTrace.EndUpdate()
    End Sub

    Private Sub ListView_StackTrace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_StackTrace.SelectedIndexChanged
        MarkListViewItem()
    End Sub

    Private Sub ListView_StackTrace_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView_StackTrace.MouseClick
        MarkListViewItem()
    End Sub

    Private Sub MarkListViewItem()
        Try
            If (ListView_StackTrace.SelectedItems.Count < 1) Then
                Return
            End If

            Dim mListViewItemData = TryCast(ListView_StackTrace.SelectedItems(0), ClassListViewItemData)
            If (mListViewItemData Is Nothing) Then
                Return
            End If

            Dim iDebugLine As Integer = CInt(mListViewItemData.g_mData("Line"))

            iDebugLine -= 1

            If (iDebugLine < 0) Then
                Return
            End If

            Dim iLineLen As Integer = g_mFormDebugger.TextEditorControlEx_DebuggerSource.Document.GetLineSegment(iDebugLine).Length

            Dim startLocation As New ICSharpCode.TextEditor.TextLocation(0, iDebugLine)
            Dim endLocation As New ICSharpCode.TextEditor.TextLocation(iLineLen, iDebugLine)

            g_mFormDebugger.TextEditorControlEx_DebuggerSource.ActiveTextAreaControl.Caret.Position = startLocation
            g_mFormDebugger.TextEditorControlEx_DebuggerSource.ActiveTextAreaControl.SelectionManager.SetSelection(startLocation, endLocation)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button_ViewLog_Click(sender As Object, e As EventArgs) Handles Button_ViewLog.Click
        Try
            Dim sLines As String() = ClassTools.ClassStrings.StringReadLinesEnd(g_sLogFile, MAX_LINES_TO_LIST)

            Using i As New FormDebuggerCriticalPopup(g_mFormDebugger, "SourceMod Exception Log", "Latest exceptions from the SourceMod log", String.Join(Environment.NewLine, sLines))
                i.ShowDialog(Me)
            End Using
        Catch ex As Exception
            ClassExceptionLog.WriteToLogMessageBox(ex)
        End Try
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub Button_Continue_Click(sender As Object, e As EventArgs) Handles Button_Continue.Click
        g_mFormDebugger.g_ClassDebuggerRunner.ContinueDebugging()
        Me.Close()
    End Sub

    Private Sub FormDebuggerException_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClassControlStyle.UpdateControls(Me)
    End Sub
End Class