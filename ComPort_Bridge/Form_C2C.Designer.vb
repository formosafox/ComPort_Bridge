<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_C2C
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_C2C))
        Me.ComPort_A = New System.IO.Ports.SerialPort(Me.components)
        Me.ComPort_B = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox_ComPort_A = New System.Windows.Forms.GroupBox()
        Me.CB_ComPort_DataBits_A = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_StopBits_A = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_Parity_A = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_BaudRate_A = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_Name_A = New System.Windows.Forms.ComboBox()
        Me.StatusStrip_C2C = New System.Windows.Forms.StatusStrip()
        Me.TSSL_A_RX_Blink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_B_RX_Blink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox_ComPort_B = New System.Windows.Forms.GroupBox()
        Me.CB_ComPort_DataBits_B = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_StopBits_B = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_Parity_B = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_BaudRate_B = New System.Windows.Forms.ComboBox()
        Me.CB_ComPort_Name_B = New System.Windows.Forms.ComboBox()
        Me.BT_ComPort_Link = New System.Windows.Forms.Button()
        Me.NotifyIcon_C2C = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer_RX_Blink = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_ComPort_A.SuspendLayout()
        Me.StatusStrip_C2C.SuspendLayout()
        Me.GroupBox_ComPort_B.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComPort_A
        '
        Me.ComPort_A.Parity = System.IO.Ports.Parity.Even
        Me.ComPort_A.PortName = "COM2"
        '
        'ComPort_B
        '
        Me.ComPort_B.PortName = "COM3"
        '
        'GroupBox_ComPort_A
        '
        Me.GroupBox_ComPort_A.Controls.Add(Me.CB_ComPort_DataBits_A)
        Me.GroupBox_ComPort_A.Controls.Add(Me.CB_ComPort_StopBits_A)
        Me.GroupBox_ComPort_A.Controls.Add(Me.CB_ComPort_Parity_A)
        Me.GroupBox_ComPort_A.Controls.Add(Me.CB_ComPort_BaudRate_A)
        Me.GroupBox_ComPort_A.Controls.Add(Me.CB_ComPort_Name_A)
        Me.GroupBox_ComPort_A.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_ComPort_A.Name = "GroupBox_ComPort_A"
        Me.GroupBox_ComPort_A.Size = New System.Drawing.Size(84, 145)
        Me.GroupBox_ComPort_A.TabIndex = 0
        Me.GroupBox_ComPort_A.TabStop = False
        Me.GroupBox_ComPort_A.Text = "【Port：A】"
        '
        'CB_ComPort_DataBits_A
        '
        Me.CB_ComPort_DataBits_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_DataBits_A.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_DataBits_A.FormattingEnabled = True
        Me.CB_ComPort_DataBits_A.Location = New System.Drawing.Point(5, 92)
        Me.CB_ComPort_DataBits_A.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_DataBits_A.Name = "CB_ComPort_DataBits_A"
        Me.CB_ComPort_DataBits_A.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_DataBits_A.TabIndex = 12
        '
        'CB_ComPort_StopBits_A
        '
        Me.CB_ComPort_StopBits_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_StopBits_A.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_StopBits_A.FormattingEnabled = True
        Me.CB_ComPort_StopBits_A.Location = New System.Drawing.Point(5, 116)
        Me.CB_ComPort_StopBits_A.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_StopBits_A.Name = "CB_ComPort_StopBits_A"
        Me.CB_ComPort_StopBits_A.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_StopBits_A.TabIndex = 11
        '
        'CB_ComPort_Parity_A
        '
        Me.CB_ComPort_Parity_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_Parity_A.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_Parity_A.FormattingEnabled = True
        Me.CB_ComPort_Parity_A.Location = New System.Drawing.Point(5, 68)
        Me.CB_ComPort_Parity_A.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_Parity_A.Name = "CB_ComPort_Parity_A"
        Me.CB_ComPort_Parity_A.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_Parity_A.TabIndex = 10
        '
        'CB_ComPort_BaudRate_A
        '
        Me.CB_ComPort_BaudRate_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_BaudRate_A.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_BaudRate_A.FormattingEnabled = True
        Me.CB_ComPort_BaudRate_A.Location = New System.Drawing.Point(5, 44)
        Me.CB_ComPort_BaudRate_A.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_BaudRate_A.Name = "CB_ComPort_BaudRate_A"
        Me.CB_ComPort_BaudRate_A.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_BaudRate_A.TabIndex = 9
        '
        'CB_ComPort_Name_A
        '
        Me.CB_ComPort_Name_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_Name_A.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_Name_A.FormattingEnabled = True
        Me.CB_ComPort_Name_A.Location = New System.Drawing.Point(5, 20)
        Me.CB_ComPort_Name_A.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_Name_A.Name = "CB_ComPort_Name_A"
        Me.CB_ComPort_Name_A.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_Name_A.Sorted = True
        Me.CB_ComPort_Name_A.TabIndex = 8
        '
        'StatusStrip_C2C
        '
        Me.StatusStrip_C2C.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StatusStrip_C2C.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_A_RX_Blink, Me.ToolStripStatusLabel1, Me.TSSL_B_RX_Blink, Me.ToolStripStatusLabel2})
        Me.StatusStrip_C2C.Location = New System.Drawing.Point(0, 199)
        Me.StatusStrip_C2C.Name = "StatusStrip_C2C"
        Me.StatusStrip_C2C.Size = New System.Drawing.Size(197, 22)
        Me.StatusStrip_C2C.TabIndex = 27
        Me.StatusStrip_C2C.Text = "StatusStrip1"
        '
        'TSSL_A_RX_Blink
        '
        Me.TSSL_A_RX_Blink.Name = "TSSL_A_RX_Blink"
        Me.TSSL_A_RX_Blink.Size = New System.Drawing.Size(24, 17)
        Me.TSSL_A_RX_Blink.Text = "○"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "[A] RX"
        '
        'TSSL_B_RX_Blink
        '
        Me.TSSL_B_RX_Blink.Name = "TSSL_B_RX_Blink"
        Me.TSSL_B_RX_Blink.Size = New System.Drawing.Size(24, 17)
        Me.TSSL_B_RX_Blink.Text = "○"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel2.Text = "[B] RX"
        '
        'GroupBox_ComPort_B
        '
        Me.GroupBox_ComPort_B.Controls.Add(Me.CB_ComPort_DataBits_B)
        Me.GroupBox_ComPort_B.Controls.Add(Me.CB_ComPort_StopBits_B)
        Me.GroupBox_ComPort_B.Controls.Add(Me.CB_ComPort_Parity_B)
        Me.GroupBox_ComPort_B.Controls.Add(Me.CB_ComPort_BaudRate_B)
        Me.GroupBox_ComPort_B.Controls.Add(Me.CB_ComPort_Name_B)
        Me.GroupBox_ComPort_B.Location = New System.Drawing.Point(102, 12)
        Me.GroupBox_ComPort_B.Name = "GroupBox_ComPort_B"
        Me.GroupBox_ComPort_B.Size = New System.Drawing.Size(84, 145)
        Me.GroupBox_ComPort_B.TabIndex = 13
        Me.GroupBox_ComPort_B.TabStop = False
        Me.GroupBox_ComPort_B.Text = "【Port：B】"
        '
        'CB_ComPort_DataBits_B
        '
        Me.CB_ComPort_DataBits_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_DataBits_B.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_DataBits_B.FormattingEnabled = True
        Me.CB_ComPort_DataBits_B.Location = New System.Drawing.Point(5, 92)
        Me.CB_ComPort_DataBits_B.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_DataBits_B.Name = "CB_ComPort_DataBits_B"
        Me.CB_ComPort_DataBits_B.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_DataBits_B.TabIndex = 12
        '
        'CB_ComPort_StopBits_B
        '
        Me.CB_ComPort_StopBits_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_StopBits_B.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_StopBits_B.FormattingEnabled = True
        Me.CB_ComPort_StopBits_B.Location = New System.Drawing.Point(5, 116)
        Me.CB_ComPort_StopBits_B.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_StopBits_B.Name = "CB_ComPort_StopBits_B"
        Me.CB_ComPort_StopBits_B.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_StopBits_B.TabIndex = 11
        '
        'CB_ComPort_Parity_B
        '
        Me.CB_ComPort_Parity_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_Parity_B.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_Parity_B.FormattingEnabled = True
        Me.CB_ComPort_Parity_B.Location = New System.Drawing.Point(5, 68)
        Me.CB_ComPort_Parity_B.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_Parity_B.Name = "CB_ComPort_Parity_B"
        Me.CB_ComPort_Parity_B.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_Parity_B.TabIndex = 10
        '
        'CB_ComPort_BaudRate_B
        '
        Me.CB_ComPort_BaudRate_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_BaudRate_B.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_BaudRate_B.FormattingEnabled = True
        Me.CB_ComPort_BaudRate_B.Location = New System.Drawing.Point(5, 44)
        Me.CB_ComPort_BaudRate_B.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_BaudRate_B.Name = "CB_ComPort_BaudRate_B"
        Me.CB_ComPort_BaudRate_B.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_BaudRate_B.TabIndex = 9
        '
        'CB_ComPort_Name_B
        '
        Me.CB_ComPort_Name_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ComPort_Name_B.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ComPort_Name_B.FormattingEnabled = True
        Me.CB_ComPort_Name_B.Location = New System.Drawing.Point(5, 20)
        Me.CB_ComPort_Name_B.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_ComPort_Name_B.Name = "CB_ComPort_Name_B"
        Me.CB_ComPort_Name_B.Size = New System.Drawing.Size(70, 20)
        Me.CB_ComPort_Name_B.Sorted = True
        Me.CB_ComPort_Name_B.TabIndex = 8
        '
        'BT_ComPort_Link
        '
        Me.BT_ComPort_Link.Enabled = False
        Me.BT_ComPort_Link.Location = New System.Drawing.Point(17, 163)
        Me.BT_ComPort_Link.Name = "BT_ComPort_Link"
        Me.BT_ComPort_Link.Size = New System.Drawing.Size(169, 23)
        Me.BT_ComPort_Link.TabIndex = 28
        Me.BT_ComPort_Link.Text = "連線"
        Me.BT_ComPort_Link.UseVisualStyleBackColor = True
        '
        'NotifyIcon_C2C
        '
        Me.NotifyIcon_C2C.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon_C2C.Icon = CType(resources.GetObject("NotifyIcon_C2C.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_C2C.Text = "滑鼠連點開啟"
        Me.NotifyIcon_C2C.Visible = True
        '
        'Timer_RX_Blink
        '
        Me.Timer_RX_Blink.Enabled = True
        Me.Timer_RX_Blink.Interval = 500
        Me.Timer_RX_Blink.Tag = "0"
        '
        'Form_C2C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 221)
        Me.Controls.Add(Me.BT_ComPort_Link)
        Me.Controls.Add(Me.GroupBox_ComPort_B)
        Me.Controls.Add(Me.StatusStrip_C2C)
        Me.Controls.Add(Me.GroupBox_ComPort_A)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_C2C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C2C"
        Me.GroupBox_ComPort_A.ResumeLayout(False)
        Me.StatusStrip_C2C.ResumeLayout(False)
        Me.StatusStrip_C2C.PerformLayout()
        Me.GroupBox_ComPort_B.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComPort_A As IO.Ports.SerialPort
    Friend WithEvents ComPort_B As IO.Ports.SerialPort
    Friend WithEvents GroupBox_ComPort_A As GroupBox
    Friend WithEvents StatusStrip_C2C As StatusStrip
    Friend WithEvents TSSL_A_RX_Blink As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TSSL_B_RX_Blink As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents CB_ComPort_Name_A As ComboBox
    Friend WithEvents CB_ComPort_BaudRate_A As ComboBox
    Friend WithEvents CB_ComPort_Parity_A As ComboBox
    Friend WithEvents CB_ComPort_StopBits_A As ComboBox
    Friend WithEvents CB_ComPort_DataBits_A As ComboBox
    Friend WithEvents GroupBox_ComPort_B As GroupBox
    Friend WithEvents CB_ComPort_DataBits_B As ComboBox
    Friend WithEvents CB_ComPort_StopBits_B As ComboBox
    Friend WithEvents CB_ComPort_Parity_B As ComboBox
    Friend WithEvents CB_ComPort_BaudRate_B As ComboBox
    Friend WithEvents CB_ComPort_Name_B As ComboBox
    Friend WithEvents BT_ComPort_Link As Button
    Friend WithEvents NotifyIcon_C2C As NotifyIcon
    Friend WithEvents Timer_RX_Blink As Timer
End Class
