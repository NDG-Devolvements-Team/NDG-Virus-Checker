<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSig = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(25, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(210, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "NDG Virus Checker 2018"
        '
        'lblSig
        '
        Me.lblSig.AutoSize = True
        Me.lblSig.Font = New System.Drawing.Font("Palace Script MT", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSig.Location = New System.Drawing.Point(2, 163)
        Me.lblSig.Name = "lblSig"
        Me.lblSig.Size = New System.Drawing.Size(104, 12)
        Me.lblSig.TabIndex = 1
        Me.lblSig.Text = "By NDG Devolvement"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(29, 53)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(209, 20)
        Me.txtFilePath.TabIndex = 2
        Me.txtFilePath.Text = "File"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(241, 53)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(71, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtHash
        '
        Me.txtHash.Location = New System.Drawing.Point(57, 92)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.Size = New System.Drawing.Size(244, 20)
        Me.txtHash.TabIndex = 4
        Me.txtHash.Text = "MD5"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(1, 135)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "File Status:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(67, 135)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 177)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.lblSig)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form1"
        Me.Text = "NDG Virus Check 2018"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSig As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtHash As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
