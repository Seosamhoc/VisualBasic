<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblQuestion1Answer = New System.Windows.Forms.Label()
        Me.cboRegYear = New System.Windows.Forms.ComboBox()
        Me.DbDataliaPoliceCamerasDataSet = New projPoliceCameras.dbDataliaPoliceCamerasDataSet()
        Me.lblQuestion1Part2 = New System.Windows.Forms.Label()
        Me.cboCamera = New System.Windows.Forms.ComboBox()
        Me.TblCameraRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblQuestion1Part1 = New System.Windows.Forms.Label()
        Me.lblQuestion2Answer = New System.Windows.Forms.Label()
        Me.cboDateOnRoad = New System.Windows.Forms.ComboBox()
        Me.lblQuestion2Part2 = New System.Windows.Forms.Label()
        Me.cboDistrict = New System.Windows.Forms.ComboBox()
        Me.lblQuestion2Part1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboReg = New System.Windows.Forms.ComboBox()
        Me.RegPlatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblQuestion3Part1 = New System.Windows.Forms.Label()
        Me.TblCameraRecordsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCameraRecordsTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCameraRecordsTableAdapter()
        Me.btnQuestion2 = New System.Windows.Forms.Button()
        Me.grbBoxQuestion2 = New System.Windows.Forms.GroupBox()
        Me.grbQuestion1 = New System.Windows.Forms.GroupBox()
        Me.btnQuestion1 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.TableAdapterManager()
        Me.RegPlatesTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.RegPlatesTableAdapter()
        Me.TblCameraCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCameraCodesTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCameraCodesTableAdapter()
        Me.DbDataliaPoliceCamerasDataSet1 = New projPoliceCameras.dbDataliaPoliceCamerasDataSet()
        Me.TblRegYearsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRegYearsTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblRegYearsTableAdapter()
        Me.DbDataliaPoliceCamerasDataSet2 = New projPoliceCameras.dbDataliaPoliceCamerasDataSet()
        Me.TblCaptureDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCaptureDateTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCaptureDateTableAdapter()
        Me.TblDistrictsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDistrictsTableAdapter = New projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblDistrictsTableAdapter()
        CType(Me.DbDataliaPoliceCamerasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCameraRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegPlatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCameraRecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbBoxQuestion2.SuspendLayout()
        Me.grbQuestion1.SuspendLayout()
        CType(Me.TblCameraCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataliaPoliceCamerasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRegYearsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataliaPoliceCamerasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCaptureDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDistrictsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(624, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblQuestion1Answer
        '
        Me.lblQuestion1Answer.AutoSize = True
        Me.lblQuestion1Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1Answer.Location = New System.Drawing.Point(619, 26)
        Me.lblQuestion1Answer.Name = "lblQuestion1Answer"
        Me.lblQuestion1Answer.Size = New System.Drawing.Size(71, 37)
        Me.lblQuestion1Answer.TabIndex = 10
        Me.lblQuestion1Answer.Text = "000"
        '
        'cboRegYear
        '
        Me.cboRegYear.DataSource = Me.TblRegYearsBindingSource
        Me.cboRegYear.DisplayMember = "RegYear"
        Me.cboRegYear.FormattingEnabled = True
        Me.cboRegYear.Location = New System.Drawing.Point(236, 41)
        Me.cboRegYear.Name = "cboRegYear"
        Me.cboRegYear.Size = New System.Drawing.Size(121, 21)
        Me.cboRegYear.TabIndex = 9
        Me.cboRegYear.ValueMember = "RegYear"
        '
        'DbDataliaPoliceCamerasDataSet
        '
        Me.DbDataliaPoliceCamerasDataSet.DataSetName = "dbDataliaPoliceCamerasDataSet"
        Me.DbDataliaPoliceCamerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblQuestion1Part2
        '
        Me.lblQuestion1Part2.AutoSize = True
        Me.lblQuestion1Part2.Location = New System.Drawing.Point(72, 44)
        Me.lblQuestion1Part2.Name = "lblQuestion1Part2"
        Me.lblQuestion1Part2.Size = New System.Drawing.Size(158, 13)
        Me.lblQuestion1Part2.TabIndex = 8
        Me.lblQuestion1Part2.Text = "that were registered in the year: "
        '
        'cboCamera
        '
        Me.cboCamera.DataSource = Me.TblCameraCodesBindingSource
        Me.cboCamera.DisplayMember = "CameraCode"
        Me.cboCamera.FormattingEnabled = True
        Me.cboCamera.Location = New System.Drawing.Point(236, 11)
        Me.cboCamera.Name = "cboCamera"
        Me.cboCamera.Size = New System.Drawing.Size(121, 21)
        Me.cboCamera.TabIndex = 7
        Me.cboCamera.ValueMember = "CameraCode"
        '
        'TblCameraRecordsBindingSource
        '
        Me.TblCameraRecordsBindingSource.DataMember = "tblCameraRecords"
        Me.TblCameraRecordsBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet
        '
        'lblQuestion1Part1
        '
        Me.lblQuestion1Part1.AutoSize = True
        Me.lblQuestion1Part1.Location = New System.Drawing.Point(9, 14)
        Me.lblQuestion1Part1.Name = "lblQuestion1Part1"
        Me.lblQuestion1Part1.Size = New System.Drawing.Size(221, 13)
        Me.lblQuestion1Part1.TabIndex = 6
        Me.lblQuestion1Part1.Text = "The number of Vehicles that passed camera: "
        '
        'lblQuestion2Answer
        '
        Me.lblQuestion2Answer.AutoSize = True
        Me.lblQuestion2Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2Answer.Location = New System.Drawing.Point(610, 27)
        Me.lblQuestion2Answer.Name = "lblQuestion2Answer"
        Me.lblQuestion2Answer.Size = New System.Drawing.Size(71, 37)
        Me.lblQuestion2Answer.TabIndex = 15
        Me.lblQuestion2Answer.Text = "000"
        '
        'cboDateOnRoad
        '
        Me.cboDateOnRoad.DataSource = Me.TblCaptureDateBindingSource
        Me.cboDateOnRoad.DisplayMember = "CaptureDate"
        Me.cboDateOnRoad.FormattingEnabled = True
        Me.cboDateOnRoad.Location = New System.Drawing.Point(281, 42)
        Me.cboDateOnRoad.Name = "cboDateOnRoad"
        Me.cboDateOnRoad.Size = New System.Drawing.Size(121, 21)
        Me.cboDateOnRoad.TabIndex = 14
        Me.cboDateOnRoad.ValueMember = "CaptureDate"
        '
        'lblQuestion2Part2
        '
        Me.lblQuestion2Part2.AutoSize = True
        Me.lblQuestion2Part2.Location = New System.Drawing.Point(122, 45)
        Me.lblQuestion2Part2.Name = "lblQuestion2Part2"
        Me.lblQuestion2Part2.Size = New System.Drawing.Size(153, 13)
        Me.lblQuestion2Part2.TabIndex = 13
        Me.lblQuestion2Part2.Text = "that were on the road on date: "
        '
        'cboDistrict
        '
        Me.cboDistrict.DataSource = Me.TblDistrictsBindingSource
        Me.cboDistrict.DisplayMember = "District"
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(282, 13)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(121, 21)
        Me.cboDistrict.TabIndex = 12
        Me.cboDistrict.ValueMember = "District"
        '
        'lblQuestion2Part1
        '
        Me.lblQuestion2Part1.AutoSize = True
        Me.lblQuestion2Part1.Location = New System.Drawing.Point(6, 16)
        Me.lblQuestion2Part1.Name = "lblQuestion2Part1"
        Me.lblQuestion2Part1.Size = New System.Drawing.Size(269, 13)
        Me.lblQuestion2Part1.TabIndex = 11
        Me.lblQuestion2Part1.Text = "The Number of Vehicles that were registered in District: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Was seen by: "
        '
        'cboReg
        '
        Me.cboReg.DataSource = Me.RegPlatesBindingSource
        Me.cboReg.DisplayMember = "RegPlate"
        Me.cboReg.FormattingEnabled = True
        Me.cboReg.Location = New System.Drawing.Point(174, 185)
        Me.cboReg.Name = "cboReg"
        Me.cboReg.Size = New System.Drawing.Size(121, 21)
        Me.cboReg.TabIndex = 17
        Me.cboReg.ValueMember = "RegPlate"
        '
        'RegPlatesBindingSource
        '
        Me.RegPlatesBindingSource.DataMember = "RegPlates"
        Me.RegPlatesBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet
        '
        'lblQuestion3Part1
        '
        Me.lblQuestion3Part1.AutoSize = True
        Me.lblQuestion3Part1.Location = New System.Drawing.Point(12, 188)
        Me.lblQuestion3Part1.Name = "lblQuestion3Part1"
        Me.lblQuestion3Part1.Size = New System.Drawing.Size(156, 13)
        Me.lblQuestion3Part1.TabIndex = 16
        Me.lblQuestion3Part1.Text = "Vehicle with Registration Plate: "
        '
        'TblCameraRecordsDataGridView
        '
        Me.TblCameraRecordsDataGridView.AllowUserToAddRows = False
        Me.TblCameraRecordsDataGridView.AllowUserToDeleteRows = False
        Me.TblCameraRecordsDataGridView.AllowUserToOrderColumns = True
        Me.TblCameraRecordsDataGridView.AutoGenerateColumns = False
        Me.TblCameraRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCameraRecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblCameraRecordsDataGridView.DataSource = Me.TblCameraRecordsBindingSource
        Me.TblCameraRecordsDataGridView.Location = New System.Drawing.Point(15, 233)
        Me.TblCameraRecordsDataGridView.Name = "TblCameraRecordsDataGridView"
        Me.TblCameraRecordsDataGridView.Size = New System.Drawing.Size(650, 94)
        Me.TblCameraRecordsDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "District"
        Me.DataGridViewTextBoxColumn2.HeaderText = "District"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RegYear"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RegYear"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RegDigits"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RegDigits"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CameraCode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CameraCode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CaptureDateTime"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CaptureDateTime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TblCameraRecordsTableAdapter
        '
        Me.TblCameraRecordsTableAdapter.ClearBeforeFill = True
        '
        'btnQuestion2
        '
        Me.btnQuestion2.Location = New System.Drawing.Point(475, 40)
        Me.btnQuestion2.Name = "btnQuestion2"
        Me.btnQuestion2.Size = New System.Drawing.Size(75, 23)
        Me.btnQuestion2.TabIndex = 20
        Me.btnQuestion2.Text = "Go"
        Me.btnQuestion2.UseVisualStyleBackColor = True
        '
        'grbBoxQuestion2
        '
        Me.grbBoxQuestion2.Controls.Add(Me.btnQuestion2)
        Me.grbBoxQuestion2.Controls.Add(Me.cboDateOnRoad)
        Me.grbBoxQuestion2.Controls.Add(Me.lblQuestion2Part2)
        Me.grbBoxQuestion2.Controls.Add(Me.cboDistrict)
        Me.grbBoxQuestion2.Controls.Add(Me.lblQuestion2Part1)
        Me.grbBoxQuestion2.Controls.Add(Me.lblQuestion2Answer)
        Me.grbBoxQuestion2.Location = New System.Drawing.Point(3, 98)
        Me.grbBoxQuestion2.Name = "grbBoxQuestion2"
        Me.grbBoxQuestion2.Size = New System.Drawing.Size(696, 81)
        Me.grbBoxQuestion2.TabIndex = 21
        Me.grbBoxQuestion2.TabStop = False
        '
        'grbQuestion1
        '
        Me.grbQuestion1.Controls.Add(Me.btnQuestion1)
        Me.grbQuestion1.Controls.Add(Me.cboRegYear)
        Me.grbQuestion1.Controls.Add(Me.lblQuestion1Part2)
        Me.grbQuestion1.Controls.Add(Me.cboCamera)
        Me.grbQuestion1.Controls.Add(Me.lblQuestion1Part1)
        Me.grbQuestion1.Controls.Add(Me.lblQuestion1Answer)
        Me.grbQuestion1.Location = New System.Drawing.Point(3, 7)
        Me.grbQuestion1.Name = "grbQuestion1"
        Me.grbQuestion1.Size = New System.Drawing.Size(696, 81)
        Me.grbQuestion1.TabIndex = 22
        Me.grbQuestion1.TabStop = False
        Me.grbQuestion1.Text = " "
        '
        'btnQuestion1
        '
        Me.btnQuestion1.Location = New System.Drawing.Point(475, 39)
        Me.btnQuestion1.Name = "btnQuestion1"
        Me.btnQuestion1.Size = New System.Drawing.Size(75, 23)
        Me.btnQuestion1.TabIndex = 11
        Me.btnQuestion1.Text = "Go"
        Me.btnQuestion1.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblCameraRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegPlatesTableAdapter
        '
        Me.RegPlatesTableAdapter.ClearBeforeFill = True
        '
        'TblCameraCodesBindingSource
        '
        Me.TblCameraCodesBindingSource.DataMember = "tblCameraCodes"
        Me.TblCameraCodesBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet
        '
        'TblCameraCodesTableAdapter
        '
        Me.TblCameraCodesTableAdapter.ClearBeforeFill = True
        '
        'DbDataliaPoliceCamerasDataSet1
        '
        Me.DbDataliaPoliceCamerasDataSet1.DataSetName = "dbDataliaPoliceCamerasDataSet"
        Me.DbDataliaPoliceCamerasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRegYearsBindingSource
        '
        Me.TblRegYearsBindingSource.DataMember = "tblRegYears"
        Me.TblRegYearsBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet1
        '
        'TblRegYearsTableAdapter
        '
        Me.TblRegYearsTableAdapter.ClearBeforeFill = True
        '
        'DbDataliaPoliceCamerasDataSet2
        '
        Me.DbDataliaPoliceCamerasDataSet2.DataSetName = "dbDataliaPoliceCamerasDataSet"
        Me.DbDataliaPoliceCamerasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCaptureDateBindingSource
        '
        Me.TblCaptureDateBindingSource.DataMember = "tblCaptureDate"
        Me.TblCaptureDateBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet2
        '
        'TblCaptureDateTableAdapter
        '
        Me.TblCaptureDateTableAdapter.ClearBeforeFill = True
        '
        'TblDistrictsBindingSource
        '
        Me.TblDistrictsBindingSource.DataMember = "tblDistricts"
        Me.TblDistrictsBindingSource.DataSource = Me.DbDataliaPoliceCamerasDataSet2
        '
        'TblDistrictsTableAdapter
        '
        Me.TblDistrictsTableAdapter.ClearBeforeFill = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbQuestion1)
        Me.Controls.Add(Me.grbBoxQuestion2)
        Me.Controls.Add(Me.TblCameraRecordsDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboReg)
        Me.Controls.Add(Me.lblQuestion3Part1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DbDataliaPoliceCamerasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCameraRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegPlatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCameraRecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbBoxQuestion2.ResumeLayout(False)
        Me.grbBoxQuestion2.PerformLayout()
        Me.grbQuestion1.ResumeLayout(False)
        Me.grbQuestion1.PerformLayout()
        CType(Me.TblCameraCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataliaPoliceCamerasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRegYearsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataliaPoliceCamerasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCaptureDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDistrictsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblQuestion1Answer As System.Windows.Forms.Label
    Friend WithEvents cboRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuestion1Part2 As System.Windows.Forms.Label
    Friend WithEvents cboCamera As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuestion1Part1 As System.Windows.Forms.Label
    Friend WithEvents lblQuestion2Answer As System.Windows.Forms.Label
    Friend WithEvents cboDateOnRoad As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuestion2Part2 As System.Windows.Forms.Label
    Friend WithEvents cboDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuestion2Part1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboReg As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuestion3Part1 As System.Windows.Forms.Label
    Friend WithEvents DbDataliaPoliceCamerasDataSet As projPoliceCameras.dbDataliaPoliceCamerasDataSet
    Friend WithEvents TblCameraRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCameraRecordsTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCameraRecordsTableAdapter
    Friend WithEvents TableAdapterManager As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCameraRecordsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegPlatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegPlatesTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.RegPlatesTableAdapter
    Friend WithEvents btnQuestion2 As System.Windows.Forms.Button
    Friend WithEvents grbBoxQuestion2 As System.Windows.Forms.GroupBox
    Friend WithEvents grbQuestion1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuestion1 As System.Windows.Forms.Button
    Friend WithEvents TblCameraCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCameraCodesTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCameraCodesTableAdapter
    Friend WithEvents DbDataliaPoliceCamerasDataSet1 As projPoliceCameras.dbDataliaPoliceCamerasDataSet
    Friend WithEvents TblRegYearsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRegYearsTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblRegYearsTableAdapter
    Friend WithEvents DbDataliaPoliceCamerasDataSet2 As projPoliceCameras.dbDataliaPoliceCamerasDataSet
    Friend WithEvents TblCaptureDateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCaptureDateTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblCaptureDateTableAdapter
    Friend WithEvents TblDistrictsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDistrictsTableAdapter As projPoliceCameras.dbDataliaPoliceCamerasDataSetTableAdapters.tblDistrictsTableAdapter
End Class
