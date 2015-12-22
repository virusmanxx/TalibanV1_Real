Imports System.Windows.Forms
Imports System.IO

Public Class Taliban
    Private Sub CloseApp(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(0)
    End Sub

    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)



    Private Sub Taliban_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub

    Private Sub Taliban_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub

    Private Sub Taliban_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If

    End Sub

    Private Sub FeaturesBox_Enter(sender As Object, e As EventArgs) Handles FeaturesBox.Enter

    End Sub
End Class