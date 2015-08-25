Public Class frmOverview

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchForm As frmSearch
        searchForm = New frmSearch()
        searchForm.Show()
        searchForm = Nothing
    End Sub

    Private Sub TblCameraRecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCameraRecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCameraRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataliaPoliceCamerasDataSet)

    End Sub

    Private Sub frmOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.tblCameraRecords' table. You can move, or remove it, as needed.
        Me.TblCameraRecordsTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.tblCameraRecords)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateFrom As frmUpdate
        updateFrom = New frmUpdate()
        updateFrom.Show()
        updateFrom = Nothing
    End Sub
End Class
