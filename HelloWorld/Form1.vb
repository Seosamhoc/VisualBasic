Public Class frmHello


    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdShowHide_Click(sender As Object, e As EventArgs) Handles cmdShowHide.Click
        If lblMessage.Visible Then
            lblMessage.Visible = False
            cmdShowHide.Text = "Say hello"
        Else
            lblMessage.Visible = True
            cmdShowHide.Text = "Hide Message"
        End If
    End Sub
End Class
