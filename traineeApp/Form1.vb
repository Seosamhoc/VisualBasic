Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableInput()
        'DisableInput()
    End Sub

    Private Sub DisableInput()
        '*********************************************************************
        'Cycles through controls on the form and in group boxes and, when the 
        'control is a text box, it is disabled to prevent user-input. Also hides
        'some controls that are only used for Add and Edit.
        '*********************************************************************
        Try

            For Each GroupBoxCntrol As Control In Me.Controls
                If TypeOf GroupBoxCntrol Is GroupBox Then
                    For Each Ctrl As Control In GroupBoxCntrol.Controls
                        If TypeOf Ctrl Is TextBox Then
                            Ctrl.Enabled = False
                        Else
                            Ctrl.Enabled = True
                        End If
                    Next
                End If
            Next
            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is TextBox Then
                    Ctrl.Enabled = False
                Else
                    Ctrl.Enabled = True
                End If
            Next

            txtCounty.Visible = True
            txtDateStarted.Visible = True
            txtDoB.Visible = True
            txtDept.Visible = True
            txtGender.Visible = True

            lstCounties.Visible = False
            cboDept.Visible = False
            dtDateStarted.Visible = False
            dtDoB.Visible = False
            optF.Visible = False
            optM.Visible = False

        Catch ex As Exception
            MsgBox("Unable to set up display! ")
        End Try

    End Sub

    Private Sub EnableInput()
        '*********************************************************************
        'Cycles through controls on the form and in group boxes and, when the 
        'control is a text box, it is enabled to allow user-input. Also shows
        'some controls that are only used for Add and Edit.
        '*********************************************************************
        Try

            For Each GroupBoxCntrol As Control In Me.Controls
                If TypeOf GroupBoxCntrol Is GroupBox Then
                    For Each Ctrl As Control In GroupBoxCntrol.Controls
                        'Check name to see if it needs to be made visible

                        If TypeOf Ctrl Is TextBox Then
                            Ctrl.Enabled = True
                        End If
                    Next
                End If
            Next
            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is TextBox Then
                    Ctrl.Enabled = True
                End If
            Next

            txtCounty.Visible = False
            txtDateStarted.Visible = False
            txtDoB.Visible = False
            txtDept.Visible = False
            txtGender.Visible = False

            lstCounties.Visible = True
            cboDept.Visible = True
            dtDateStarted.Visible = True
            dtDoB.Visible = True
            optF.Visible = True
            optM.Visible = True

        Catch ex As Exception
            MsgBox("Unable to set up display! ")
        End Try

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class
