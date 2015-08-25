Public Class frmUpdate

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.tblCameraCodes' table. You can move, or remove it, as needed.
        Me.TblCameraCodesTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.tblCameraCodes)
        'TODO: This line of code loads data into the 'DbDataliaPoliceCamerasDataSet.RegPlates' table. You can move, or remove it, as needed.
        Me.RegPlatesTableAdapter.Fill(Me.DbDataliaPoliceCamerasDataSet.RegPlates)

    End Sub
End Class