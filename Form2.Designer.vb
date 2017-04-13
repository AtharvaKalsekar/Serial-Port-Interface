<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.testx = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.testy = New System.Windows.Forms.TextBox()
        Me.testnX = New System.Windows.Forms.TextBox()
        Me.testnY = New System.Windows.Forms.TextBox()
        Me.X = New System.Windows.Forms.Label()
        Me.Y = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.testcase = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.arrowtest = New System.Windows.Forms.TextBox()
        Me.testsub1 = New System.Windows.Forms.TextBox()
        Me.testsub2 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtTransmit)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmitted Data"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(151, 25)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(47, 25)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "S&end"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(14, 25)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(131, 20)
        Me.txtTransmit.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbReceived)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Received Data"
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(17, 19)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(171, 58)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'SerialPort2
        '
        '
        'testx
        '
        Me.testx.Location = New System.Drawing.Point(72, 214)
        Me.testx.Name = "testx"
        Me.testx.Size = New System.Drawing.Size(48, 20)
        Me.testx.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'testy
        '
        Me.testy.Location = New System.Drawing.Point(183, 214)
        Me.testy.Name = "testy"
        Me.testy.Size = New System.Drawing.Size(48, 20)
        Me.testy.TabIndex = 4
        '
        'testnX
        '
        Me.testnX.Location = New System.Drawing.Point(72, 240)
        Me.testnX.Name = "testnX"
        Me.testnX.Size = New System.Drawing.Size(48, 20)
        Me.testnX.TabIndex = 5
        '
        'testnY
        '
        Me.testnY.Location = New System.Drawing.Point(183, 240)
        Me.testnY.Name = "testnY"
        Me.testnY.Size = New System.Drawing.Size(48, 20)
        Me.testnY.TabIndex = 6
        '
        'X
        '
        Me.X.AutoSize = True
        Me.X.Location = New System.Drawing.Point(27, 217)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(14, 13)
        Me.X.TabIndex = 7
        Me.X.Text = "X"
        '
        'Y
        '
        Me.Y.AutoSize = True
        Me.Y.Location = New System.Drawing.Point(138, 217)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(14, 13)
        Me.Y.TabIndex = 8
        Me.Y.Text = "Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "nX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "nY"
        '
        'testcase
        '
        Me.testcase.Location = New System.Drawing.Point(278, 54)
        Me.testcase.Name = "testcase"
        Me.testcase.Size = New System.Drawing.Size(74, 20)
        Me.testcase.TabIndex = 11
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'arrowtest
        '
        Me.arrowtest.Location = New System.Drawing.Point(278, 89)
        Me.arrowtest.Name = "arrowtest"
        Me.arrowtest.Size = New System.Drawing.Size(74, 20)
        Me.arrowtest.TabIndex = 12
        '
        'testsub1
        '
        Me.testsub1.Location = New System.Drawing.Point(284, 147)
        Me.testsub1.Name = "testsub1"
        Me.testsub1.Size = New System.Drawing.Size(67, 20)
        Me.testsub1.TabIndex = 13
        '
        'testsub2
        '
        Me.testsub2.Location = New System.Drawing.Point(284, 192)
        Me.testsub2.Name = "testsub2"
        Me.testsub2.Size = New System.Drawing.Size(66, 20)
        Me.testsub2.TabIndex = 14
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 261)
        Me.Controls.Add(Me.testsub2)
        Me.Controls.Add(Me.testsub1)
        Me.Controls.Add(Me.arrowtest)
        Me.Controls.Add(Me.testcase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Y)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.testnY)
        Me.Controls.Add(Me.testnX)
        Me.Controls.Add(Me.testy)
        Me.Controls.Add(Me.testx)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtTransmit As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rtbReceived As RichTextBox
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents testx As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents testy As TextBox
    Friend WithEvents testnX As TextBox
    Friend WithEvents testnY As TextBox
    Friend WithEvents X As Label
    Friend WithEvents Y As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents testcase As TextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents arrowtest As TextBox
    Friend WithEvents testsub1 As TextBox
    Friend WithEvents testsub2 As MaskedTextBox
End Class
