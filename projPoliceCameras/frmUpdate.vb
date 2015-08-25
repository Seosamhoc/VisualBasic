Public Class frmUpdate
    Dim regPlate As String
    Dim district As String
    Dim regYear As Short
    Dim digits As Short
    Dim camCode As Short
    Dim camDate As Date

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.tblCameraCodes' table. You can move, or remove it, as needed.
        Me.TblCameraCodesTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.tblCameraCodes)
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.RegPlates' table. You can move, or remove it, as needed.
        Me.RegPlatesTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.RegPlates)

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        regPlate = Me.cboReg.SelectedValue
        district = Me.RegPlatesTableAdapter1.GetDistrict(regPlate)
        regYear = Me.RegPlatesTableAdapter1.GetYear(regPlate)
        digits = Me.RegPlatesTableAdapter1.GetDigits(regPlate)
        camCode = Me.cboCamCode.SelectedValue
        camDate = Me.dtpCaptureDate.Text
        MessageBox.Show("Reg: " & regPlate & " Dist: " & district & "Year: " & regYear & "Digits: " & digits & "Camera: " & camCode & "Date: " & camDate)
        'Me.TblCameraRecordsTableAdapter1.InsertQuery(district, regYear, digits, camCode, camDate)
    End Sub
End Class