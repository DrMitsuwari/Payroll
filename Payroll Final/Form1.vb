Public Class LogIn
    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click

        Dim use As String = Username.Text
        Dim pass As String = Password.Text


        If use = "admin" And pass = "password123" Then

            Dim nextForm As New Payroll_Input_()
            nextForm.Show()

            Me.Hide()
        Else

            MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Power_Click(sender As Object, e As EventArgs) Handles Power.Click
        ' Exit the application
        Application.Exit()
    End Sub
End Class
