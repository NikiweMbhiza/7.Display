Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String
        Dim Birthyear As Integer
        YourMessage = "Happy bday , how old are you"
        MsgBox(YourMessage)
        Birthyear = Val(InputBox("enter your  year of birth"))
        MsgBox("YOU ARE NOW" & 2023 - Birthyear & " YEARS OLD")

    End Sub
End Class
