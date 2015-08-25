Public Class frmSearch
    Dim scalarQueriesTableAdapter As dbDataliaPoliceCamerasDataSetTableAdapters.QueriesTableAdapter
    Dim returnDistrict As String
    Dim returnYear As Integer
    Dim returnDigits As Integer
    Dim regPlate As String
    Dim returnCountQOne As String
    Dim returnCountQTwo As String
    Dim camCode As Short
    Dim regYear As Short
    Dim district As String
    Dim camDate As Date
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet2.tblDistricts' table. You can move, or remove it, as needed.
        Me.TblDistrictsTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet2.tblDistricts)
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet2.tblCaptureDate' table. You can move, or remove it, as needed.
        Me.TblCaptureDateTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet2.tblCaptureDate)
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet1.tblRegYears' table. You can move, or remove it, as needed.
        Me.TblRegYearsTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet1.tblRegYears)
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.tblCameraCodes' table. You can move, or remove it, as needed.
        Me.TblCameraCodesTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.tblCameraCodes)
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.RegPlates' table. You can move, or remove it, as needed.
        Me.RegPlatesTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.RegPlates)
    End Sub

    Private Sub TblCameraRecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCameraRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataliaPoliceCamerasDataSet)
    End Sub

    Private Sub cboReg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReg.SelectedIndexChanged
        If Not (Me.cboReg.SelectedValue Is Nothing) Then
            regPlate = Me.cboReg.SelectedValue
            scalarQueriesTableAdapter = New dbDataliaPoliceCamerasDataSetTableAdapters.QueriesTableAdapter()
            returnDistrict = CType(scalarQueriesTableAdapter.selectDistrict(regPlate), String)
            returnYear = CType(scalarQueriesTableAdapter.selectYear(regPlate), Integer)
            returnDigits = CType(scalarQueriesTableAdapter.selectDigits(regPlate), Integer)
            Me.TblCameraRecordsTableAdapter.FillRegPlate(Me.DbDataliaPoliceCamerasDataSet.tblCameraRecords, returnDistrict, returnYear, returnDigits)
        End If
    End Sub

    Private Sub btnQuestion1_Click(sender As Object, e As EventArgs) Handles btnQuestion1.Click
        If Not (Me.cboCamera.SelectedValue Is Nothing Or Me.cboRegYear.SelectedValue Is Nothing) Then
            camCode = Me.cboCamera.SelectedValue
            regYear = Me.cboRegYear.SelectedValue
            scalarQueriesTableAdapter = New dbDataliaPoliceCamerasDataSetTableAdapters.QueriesTableAdapter()
            returnCountQOne = CType(scalarQueriesTableAdapter.countQuestion1(camCode, regYear), String)
            lblQuestion1Answer.Text = returnCountQOne
        End If
    End Sub

    Private Sub btnQuestion2_Click(sender As Object, e As EventArgs) Handles btnQuestion2.Click
        camDate = cboDateOnRoad.SelectedValue
        Dim dateAsString = camDate.ToString("yyyy/MM/dd")
        If Not (Me.cboDistrict.SelectedValue Is Nothing Or Me.cboDateOnRoad.SelectedValue Is Nothing) Then
            district = Me.cboDistrict.SelectedValue
            scalarQueriesTableAdapter = New dbDataliaPoliceCamerasDataSetTableAdapters.QueriesTableAdapter()
            returnCountQTwo = CType(scalarQueriesTableAdapter.countQuestion2(district, dateAsString), String)
            lblQuestion2Answer.Text = returnCountQTwo
        End If
    End Sub
End Class