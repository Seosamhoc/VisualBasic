<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHello
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
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdShowHide = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(153, 146)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdShowHide
        '
        Me.cmdShowHide.Location = New System.Drawing.Point(32, 146)
        Me.cmdShowHide.Name = "cmdShowHide"
        Me.cmdShowHide.Size = New System.Drawing.Size(99, 23)
        Me.cmdShowHide.TabIndex = 2
        Me.cmdShowHide.Text = "Say hello"
        Me.cmdShowHide.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(62, 25)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(140, 29)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.Text = "Hello World"
        Me.lblMessage.Visible = False
        '
        'frmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 187)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.cmdShowHide)
        Me.Controls.Add(Me.cmdExit)
        Me.Name = "frmHello"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdShowHide As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
