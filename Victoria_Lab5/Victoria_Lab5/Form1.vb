Option Strict On
'@author: Victoria Valdron
'@date: 05-04-2019
'@filename: Victoria_Lab5.sln
'@course: NETD2201-05
'@description: The purpose of this lab was to create a basic text editor that
'can provide basic function (save,copy,paste,cut,etc).


Imports System.IO
Imports System.Drawing.Text


Public Class frmTextEdit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click


        Application.Exit()


    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFile As New SaveFileDialog
        Dim saveAs As String

        saveFile.ShowDialog()
        saveAs = saveFile.FileName
        Dim stringWrite As New StreamWriter(saveAs)
        stringWrite.Write(txtInput.Text)
        stringWrite.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFile As New OpenFileDialog
        Dim fileLocate As String
        openFile.ShowDialog()
        fileLocate = openFile.FileName

        Dim stringRead As New StreamReader(fileLocate)
        txtInput.Text = stringRead.ReadToEnd()
        stringRead.Close()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFile As New SaveFileDialog
        Dim saveAs As String

        saveFile.ShowDialog()
        saveAs = saveFile.FileName
        Dim stringWrite As New StreamWriter(saveAs)
        stringWrite.Write(txtInput.Text)
        stringWrite.Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        Clipboard.SetText(txtInput.Text)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        If Clipboard.ContainsText = True Then

            txtInput.Text = Clipboard.GetText

        Else


            txtInput.Clear()

        End If



    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click

        Clipboard.SetText(txtInput.Text)
        txtInput.Clear()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtInput.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program is a text editor, you can input text into the box below. You can also copy/cut or paste, save your files, or create/open new files.")
    End Sub
End Class
