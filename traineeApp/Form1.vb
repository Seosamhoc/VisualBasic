Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMain
    Dim connetionString As String
    Dim cnn As New SqlConnection
    Dim dt As New DataTable
    Dim iIndex As Integer = 0
    Dim iRecCount As Integer
    Dim insertQuery As String
    Dim updateQuery As String
    Dim lastID As Integer
    Dim inAddMode As Boolean

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connetionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue16\Documents\vsprojects\VisualBasic\traineeApp\TraineeDB.mdf;Integrated Security=True"
        DisableInput()
        ConnectToDatabase()
        DisplayRecord(iIndex)

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
                If TypeOf Ctrl Is TextBox Or Ctrl Is cmdSave Then
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
                If TypeOf Ctrl Is TextBox Or Ctrl Is cmdSave Then
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

            txtID.Enabled = False
        Catch ex As Exception
            MsgBox("Unable to set up display! ")
        End Try

    End Sub

    Private Sub ConnectToDatabase()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        cnn = New SqlConnection(connetionString)
        Try
            cnn.Open()
            Dim da As New SqlDataAdapter("SELECT * FROM tblEmployee", cnn)
            da.Fill(dt)
            iRecCount = dt.Rows.Count
            lastID = dt.Rows(iRecCount - 1)("ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DisplayRecord(Index As Integer)

        Try
            txtID.Text = dt.Rows(Index)("ID").ToString()
            txtFName.Text = dt.Rows(Index)("FirstName").ToString()
            txtLName.Text = dt.Rows(Index)("LastName").ToString()
            txtAddress1.Text = dt.Rows(Index)("AddressLine1").ToString()
            txtAddress2.Text = dt.Rows(Index)("AddressLine2").ToString()
            txtCounty.Text = dt.Rows(Index)("County").ToString()
            txtDoB.Text = dt.Rows(Index)("DoB").ToString()
            txtDateStarted.Text = dt.Rows(Index)("DateJoined").ToString()
            txtDept.Text = dt.Rows(Index)("Dept").ToString()
            txtNotes.Text = dt.Rows(Index)("Notes").ToString()
        Catch ex As Exception
            MsgBox("Could not display record ! ")
        End Try

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Me.Close()
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        iIndex = 0
        DisplayRecord(iIndex)
    End Sub


    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        If iIndex > 0 Then
            iIndex = iIndex - 1
            DisplayRecord(iIndex)
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If iIndex < (iRecCount - 1) Then
            iIndex = iIndex + 1
            DisplayRecord(iIndex)
        End If
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        iIndex = (iRecCount - 1)
        DisplayRecord(iIndex)
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        EnableInput()
        cmdFirst.Enabled = False
        cmdPrevious.Enabled = False
        cmdNext.Enabled = False
        cmdLast.Enabled = False
        cmdCancel.Enabled = True
        txtID.Text = lastID + 1
        txtFName.Clear()
        txtLName.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtCounty.Clear()
        txtDoB.Clear()
        txtDateStarted.Clear()
        txtDept.Clear()
        txtNotes.Clear()
        inAddMode = True
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        cmdFirst.Enabled = False
        cmdPrevious.Enabled = False
        cmdNext.Enabled = False
        cmdLast.Enabled = False
        cmdCancel.Enabled = True
        inAddMode = False
        EnableInput()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If inAddMode Then
            insertQuery = "INSERT INTO tblEmployee VALUES ('"
            insertQuery &= txtFName.Text & "', '"
            insertQuery &= txtLName.Text & "', '"
            insertQuery &= txtAddress1.Text & "', '"
            insertQuery &= txtAddress2.Text & "', '"
            insertQuery &= lstCounties.Text & "', '"
            insertQuery &= dtDoB.Text & "', '"
            insertQuery &= dtDateStarted.Text & "', '"
            insertQuery &= cboDept.Text & "', '"
            insertQuery &= txtNotes.Text & "')"
            MessageBox.Show(insertQuery)
            Dim command As New SqlCommand(insertQuery, cnn)
            command.ExecuteNonQuery()
            dt.Clear()
            Dim da As New SqlDataAdapter("SELECT * FROM tblEmployee", cnn)
            da.Fill(dt)
            iRecCount = dt.Rows.Count
            lastID = dt.Rows(iRecCount - 1)("ID")
            iIndex = (iRecCount - 1)
        Else
            updateQuery = "UPDATE tblEmployee SET "
            updateQuery &= "FirstName = '" & txtFName.Text & "', "
            updateQuery &= "LastName = '" & txtLName.Text & "', "
            updateQuery &= "AddressLine1 = '" & txtAddress1.Text & "', "
            updateQuery &= "AddressLine2 = '" & txtAddress2.Text & "', "
            updateQuery &= "County = '" & lstCounties.Text & "', "
            updateQuery &= "DoB = '" & dtDoB.Text & "', "
            updateQuery &= "DateJoined = '" & dtDateStarted.Text & "', "
            updateQuery &= "Dept = '" & cboDept.Text & "', "
            updateQuery &= "Notes = '" & txtNotes.Text & "' "
            updateQuery &= "WHERE ID = " & txtID.Text
            MessageBox.Show(updateQuery)
            Dim command As New SqlCommand(updateQuery, cnn)
            command.ExecuteNonQuery()
            dt.Clear()
            Dim da As New SqlDataAdapter("SELECT * FROM tblEmployee", cnn)
            da.Fill(dt)
        End If
        DisplayRecord(iIndex)
        DisableInput()
        cmdFirst.Enabled = True
        cmdPrevious.Enabled = True
        cmdNext.Enabled = True
        cmdLast.Enabled = True
        cmdCancel.Enabled = False
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DisplayRecord(iIndex)
        DisableInput()
        cmdFirst.Enabled = True
        cmdPrevious.Enabled = True
        cmdNext.Enabled = True
        cmdLast.Enabled = True
        cmdCancel.Enabled = False
    End Sub
End Class
