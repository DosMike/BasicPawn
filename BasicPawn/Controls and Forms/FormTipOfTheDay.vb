﻿'BasicPawn
'Copyright(C) 2020 TheTimocop

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


Public Class FormTipOfTheDay
    Private g_lTipsList As New List(Of String)

    Private g_iCurrentTipIndex As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Panel_FooterControl.Name &= "@FooterControl"
        Panel_FooterDarkControl.Name &= "@FooterDarkControl"
    End Sub

    Private Sub FormTipOfTheDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClassControlStyle.UpdateControls(Me)

        LoadViews()

        LoadTips()
    End Sub

    Private Sub FormTipOfTheDay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveViews()
    End Sub

    ReadOnly Property m_DoNotShow As Boolean
        Get
            If (String.IsNullOrEmpty(Me.Name)) Then
                Return False
            End If

            Using mStream = ClassFileStreamWait.Create(ClassSettings.g_sWindowInfoFile, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
                Using mIni As New ClassIni(mStream)
                    Return (mIni.ReadKeyValue(Me.Name, "DoNotShow", "0") <> "0")
                End Using
            End Using

            Return False
        End Get
    End Property

    Public Sub SaveViews()
        If (String.IsNullOrEmpty(Me.Name)) Then
            Return
        End If

        Using mStream = ClassFileStreamWait.Create(ClassSettings.g_sWindowInfoFile, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            Using mIni As New ClassIni(mStream)
                Dim lContent As New List(Of ClassIni.STRUC_INI_CONTENT) From {
                    New ClassIni.STRUC_INI_CONTENT(Me.Name, "DoNotShow", If(CheckBox_DoNotShow.Checked, "1", "0"))
                }

                mIni.WriteKeyValue(lContent.ToArray)
            End Using
        End Using
    End Sub

    Public Sub LoadViews()
        If (String.IsNullOrEmpty(Me.Name)) Then
            Return
        End If

        Using mStream = ClassFileStreamWait.Create(ClassSettings.g_sWindowInfoFile, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            Using mIni As New ClassIni(mStream)
                CheckBox_DoNotShow.Checked = (mIni.ReadKeyValue(Me.Name, "DoNotShow", "0") <> "0")
            End Using
        End Using
    End Sub

    Private Sub LoadTips()
        g_lTipsList.Clear()
        g_iCurrentTipIndex = 0

        Dim iTipCounter = 0

        Using mIni As New ClassIni(My.Resources.TipOfTheDayTips)
            For Each mItem In mIni.ReadEverything()
                If (mItem.sSection <> "Tips") Then
                    Continue For
                End If

                Dim sTip As String = mItem.sValue.Replace("\n", Environment.NewLine).Trim
                If (String.IsNullOrEmpty(sTip)) Then
                    Continue For
                End If

                iTipCounter += 1
                g_lTipsList.Add(String.Format("Tip #{0}:{1}{2}", iTipCounter, Environment.NewLine, sTip))
            Next
        End Using

        If (g_lTipsList.Count < 1) Then
            TextBox_Tips.Text = "I guess there are no tips."
            Return
        End If

        g_iCurrentTipIndex = ClassTools.ClassRandom.RandomInt(0, g_lTipsList.Count - 1)
        TextBox_Tips.Text = g_lTipsList(g_iCurrentTipIndex)
    End Sub

    Private Sub Button_NextTip_Click(sender As Object, e As EventArgs) Handles Button_NextTip.Click
        If (g_lTipsList.Count < 1) Then
            Return
        End If

        g_iCurrentTipIndex += 1

        g_iCurrentTipIndex = (g_iCurrentTipIndex Mod g_lTipsList.Count)
        g_iCurrentTipIndex = Math.Max(0, g_iCurrentTipIndex)
        g_iCurrentTipIndex = Math.Min(g_lTipsList.Count - 1, g_iCurrentTipIndex)

        TextBox_Tips.Text = g_lTipsList(g_iCurrentTipIndex)
    End Sub

    Private Sub Button_PreviousTip_Click(sender As Object, e As EventArgs) Handles Button_PreviousTip.Click
        If (g_lTipsList.Count < 1) Then
            Return
        End If

        g_iCurrentTipIndex += g_lTipsList.Count - 1

        g_iCurrentTipIndex = (g_iCurrentTipIndex Mod g_lTipsList.Count)
        g_iCurrentTipIndex = Math.Max(0, g_iCurrentTipIndex)
        g_iCurrentTipIndex = Math.Min(g_lTipsList.Count - 1, g_iCurrentTipIndex)

        TextBox_Tips.Text = g_lTipsList(g_iCurrentTipIndex)
    End Sub
End Class