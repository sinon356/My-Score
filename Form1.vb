Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer
        Dim ResultAs As String

        score = InputBox("Enter score")
        If score >= 0 And score <= 49 Then
            ResultAs = "Failed"
        ElseIf score <= 74 And score >= 50 Then
            ResultAs = "Pass"
        ElseIf score <= 89 And score >= 75 Then
            ResultAs = "Very Good"
        ElseIf score >= 90 And score <= 100 Then
            ResultAs = "Excellent"
        Else
            ResultAs = "Please input your score between 0 - 100"
        End If
        Label1.Text = ResultAs
    End Sub
End Class
