<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COM port:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud Rate:"
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(91, 20)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(91, 21)
        Me.cmbPort.TabIndex = 2
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(92, 53)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(89, 21)
        Me.cmbBaud.TabIndex = 3
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(205, 20)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(50, 20)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(205, 53)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(50, 21)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtTransmit)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 45)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmit Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbReceived)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 65)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Received Data"
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(16, 19)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(122, 20)
        Me.txtTransmit.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(160, 19)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(47, 19)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(22, 22)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(181, 27)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPort As ComboBox
    Friend WithEvents cmbBaud As ComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtTransmit As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rtbReceived As RichTextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
