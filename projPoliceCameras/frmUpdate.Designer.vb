<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grbAddCapture = New System.Windows.Forms.GroupBox()
        Me.lblCaptureDate = New System.Windows.Forms.Label()
        Me.lblCamCode = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.dtpCaptureDate = New System.Windows.Forms.DateTimePicker()
        Me.cboCamCode = New System.Windows.Forms.ComboBox()
        Me.TblCameraCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataliaPoliceCamerasDataSet = New projPoliceCameras.dbDataliaPoliceCamerasDataSet()
        Me.cboReg = New System.Windows.Forms.ComboBox()
        Me.RegPlatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegPlatesTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.RegPlatesTableAdapter()
        Me.TblCameraCodesTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCameraCodesTableAdapter()
        Me.RegPlatesTableAdapter1 = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.RegPlatesTableAdapter()
        Me.grbAddCapture.SuspendLayout()
        CType(Me.TblCameraCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataliaPoliceCamerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegPlatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbAddCapture
        '
        Me.grbAddCapture.Controls.Add(Me.lblCaptureDate)
        Me.grbAddCapture.Controls.Add(Me.lblCamCode)
        Me.grbAddCapture.Controls.Add(Me.lblReg)
        Me.grbAddCapture.Controls.Add(Me.btnCapture)
        Me.grbAddCapture.Controls.Add(Me.dtpCaptureDate)
        Me.grbAddCapture.Controls.Add(Me.cboCamCode)
        Me.grbAddCapture.Controls.Add(Me.cboReg)
        Me.grbAddCapture.Location = New System.Drawing.Point(30, 148)
        Me.grbAddCapture.Name = "grbAddCapture"
        Me.grbAddCapture.Size = New System.Drawing.Size(492, 104)
        Me.grbAddCapture.TabIndex = 0
        Me.grbAddCapture.TabStop = False
        '
        'lblCaptureDate
        '
        Me.lblCaptureDate.AutoSize = True
        Me.lblCaptureDate.Location = New System.Drawing.Point(315, 25)
        Me.lblCaptureDate.Name = "lblCaptureDate"
        Me.lblCaptureDate.Size = New System.Drawing.Size(70, 13)
        Me.lblCaptureDate.TabIndex = 6
        Me.lblCaptureDate.Text = "Capture Date"
        '
        'lblCamCode
        '
        Me.lblCamCode.AutoSize = True
        Me.lblCamCode.Location = New System.Drawing.Point(211, 28)
        Me.lblCamCode.Name = "lblCamCode"
        Me.lblCamCode.Size = New System.Drawing.Size(49, 13)
        Me.lblCamCode.TabIndex = 5
        Me.lblCamCode.Text = "Camera: "
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(28, 28)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(90, 13)
        Me.lblReg.TabIndex = 4
        Me.lblReg.Text = "Registration Plate"
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(384, 73)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(75, 23)
        Me.btnCapture.TabIndex = 3
        Me.btnCapture.Text = "Add Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'dtpCaptureDate
        '
        Me.dtpCaptureDate.Location = New System.Drawing.Point(318, 44)
        Me.dtpCaptureDate.Name = "dtpCaptureDate"
        Me.dtpCaptureDate.Size = New System.Drawing.Size(141, 20)
        Me.dtpCaptureDate.TabIndex = 2
        '
        'cboCamCode
        '
        Me.cboCamCode.DataSource = Me.TblCameraCodesBindingSource
        Me.cboCamCode.DisplayMember = "CameraCode"
        Me.cboCamCode.FormattingEnabled = True
        Me.cboCamCode.Location = New System.Drawing.Point(214, 44)
        Me.cboCamCode.Name = "cboCamCode"
        Me.cboCamCode.Size = New System.Drawing.Size(46, 21)
        Me.cboCamCode.TabIndex = 1
        Me.cboCamCode.ValueMember = "CameraCode"
        '
        'TblCameraCodesBindingSource
        '
        Me.TblCameraCodesBindingSource.DataMember = "tblCameraCodes"
        Me.TblCameraCodesBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet
        '
        'DbDataliaPoliceCamerasDataSet
        '
        Me.DbDataliaPoliceCamerasDataSet.DataSetName = "dbDataliaPoliceCamerasDataSet"
        Me.DbDataliaPoliceCamerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboReg
        '
        Me.cboReg.DataSource = Me.RegPlatesBindingSource
        Me.cboReg.DisplayMember = "RegPlate"
        Me.cboReg.FormattingEnabled = True
        Me.cboReg.Location = New System.Drawing.Point(31, 43)
        Me.cboReg.Name = "cboReg"
        Me.cboReg.Size = New System.Drawing.Size(121, 21)
        Me.cboReg.TabIndex = 0
        Me.cboReg.ValueMember = "RegPlate"
        '
        'RegPlatesBindingSource
        '
        Me.RegPlatesBindingSource.DataMember = "RegPlates"
        Me.RegPlatesBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet
        '
        'RegPlatesTableAdapter
        '
        Me.RegPlatesTableAdapter.ClearBeforeFill = True
        '
        'TblCameraCodesTableAdapter
        '
        Me.TblCameraCodesTableAdapter.ClearBeforeFill = True
        '
        'RegPlatesTableAdapter1
        '
        Me.RegPlatesTableAdapter1.ClearBeforeFill = True
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 291)
        Me.Controls.Add(Me.grbAddCapture)
        Me.Name = "frmUpdate"
        Me.Text = "frmUpdate"
        Me.grbAddCapture.ResumeLayout(False)
        Me.grbAddCapture.PerformLayout()
        CType(Me.TblCameraCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataliaPoliceCamerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegPlatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbAddCapture As System.Windows.Forms.GroupBox
    Friend WithEvents lblCaptureDate As System.Windows.Forms.Label
    Friend WithEvents lblCamCode As System.Windows.Forms.Label
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents dtpCaptureDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCamCode As System.Windows.Forms.ComboBox
    Friend WithEvents cboReg As System.Windows.Forms.ComboBox
    Friend WithEvents DbDataliaPoliceCamerasDataSet As projPoliceCameras.dbDataliaPoliceCamerasDataSet
    Friend WithEvents RegPlatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegPlatesTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.RegPlatesTableAdapter
    Friend WithEvents TblCameraCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCameraCodesTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCameraCodesTableAdapter
    Friend WithEvents RegPlatesTableAdapter1 As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.RegPlatesTableAdapter
End Class
