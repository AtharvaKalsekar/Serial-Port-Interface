Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports Microsoft.Win32

Public Class Form2


    Public Sub keybd_event(bVk As Byte, bScan As Byte, dwFlags As UInteger, dwExtraInfo As UInteger)
        Select Case bVk
            Case VK_UP
                arrowtest.Text = "up arrow"
            Case VK_RIGHT
                arrowtest.Text = "right arrow"
            Case VK_LEFT
                arrowtest.Text = "left arrow"
            Case VK_DOWN
                arrowtest.Text = "down arrow"
        End Select

    End Sub


    Dim e As System.Windows.Forms.KeyEventArgs

    'Const VK_H = 72
    'Const VK_E = 69
    'Const VK_L = 76
    'Const VK_O = 79


    Const VK_UP = &H26
    Const VK_DOWN = &H28
    Const VK_LEFT = &H25
    Const VK_RIGHT = &H27
    Const KEYEVENTF_KEYUP = &H2
    Const KEYEVENTF_EXTENDEDKEY = &H1

    '   Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtrainfo As Long)




    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10


    Dim ata As String
    Dim mp As Point
    Dim MPX As Integer
    Dim MPY As Integer
    Public Property portname As String
    Public Property baudrate As String
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer
    Private nX As Integer
    Private nY As Integer
    Private x1 As Integer
    Private y1 As Integer
    Dim accx As Double
    Dim accy As Double
    Dim accz As Double
    Dim i As Integer = 0


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SerialPort2.PortName = portname 'Set SerialPort1 to the selected COM port at startup
        SerialPort2.BaudRate = baudrate         'Set Baud rate to the selected value on


        'Other Serial Port Property
        SerialPort2.Parity = IO.Ports.Parity.None
        SerialPort2.StopBits = IO.Ports.StopBits.One
        SerialPort2.DataBits = 8            'Open our serial port
        SerialPort2.Open()
    End Sub

    Public Function setSpeedval(ByVal newSpeed As Double)
        Dim NewKey As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\Mouse", True)
        NewKey.SetValue("MouseSpeed", newSpeed)
    End Function


    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        SerialPort2.Write(txtTransmit.Text & vbCr) 'The text contained in the txtText will be sent to the serial port as ascii
        'plus the carriage return (Enter Key) the carriage return can be ommitted if the other end does not need it
        mp = MousePosition
        testx.Text = mp.X
        testy.Text = mp.Y
    End Sub


    Private Sub SerialPort2_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        ' ata = SerialPort2.ReadExisting()

        ReceivedText(SerialPort2.ReadExisting()) 'Automatically called every time a data is received at the serialPort

    End Sub


    Private Sub ReceivedText(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.rtbReceived.Text &= [text]
        End If
        testsub1.Text = "entered display"
        mp = MousePosition
        ' testx.Text = mp.X
        ' MPX = mp.X
        ' testy.Text = mp.Y
        ' MPY = mp.Y
        Cursor_pos([text], 0)

    End Sub



    Private Sub Cursor_pos(ByVal [ata1] As String, ByVal i As Integer)
        'i = 0
        'Dim words As String() = ata1.Split(New Char() {" "c})
        'Dim word As String
        'For Each word In words
        'Console.WriteLine(word)
        'accx = Convert.ToDouble(word)
        'Next

        'testsub2.Text = [ata1]



        Select Case [ata1]

            Case "s"
                While i <= 100
                    nX = mp.X
                    nY = mp.Y + i
                    System.Threading.Thread.Sleep(10) ' sleep thread for 0.1ms so cursor looks smooth.
                    SetCursorPos(nX, nY)
                    i += 1
                End While
                'testnX.Text = nX
                'testnY.Text = nY
                testcase.Text = "down"
                Call keybd_event(VK_DOWN, 0, KEYEVENTF_EXTENDEDKEY, 0)

            Case "w"
                While i <= 100
                    nX = mp.X
                    nY = mp.Y - i
                    System.Threading.Thread.Sleep(10) ' sleep thread for 0.1ms so cursor looks smooth.
                    SetCursorPos(nX, nY)
                    i += 1
                End While
                testcase.Text = "up"
                Call keybd_event(VK_UP, 0, KEYEVENTF_EXTENDEDKEY, 0)

            Case "a"
                testsub2.Text = "entered left case"
                While i <= 100
                    nX = mp.X - i
                    nY = mp.Y
                    SetCursorPos(nX, nY)
                    System.Threading.Thread.Sleep(10) ' sleep thread for 0.1ms so cursor looks smooth.
                    i += 1
                End While
                testcase.Text = "left"
                System.Windows.Forms.SendKeys.SendWait("{LEFT}")
                Call keybd_event(VK_LEFT, 0, KEYEVENTF_EXTENDEDKEY, 0)

            Case "d"
                testsub2.Text = "enterd right case"
                For i = 0 To 100
                    nX = mp.X + i
                    nY = mp.Y
                    System.Threading.Thread.Sleep(10) ' sleep thread for 0.1ms so cursor looks smooth.
                    SetCursorPos(nX, nY)
                Next
                'testnX.Text = nX
                'testnY.Text = nY
                testcase.Text = "right"
                System.Windows.Forms.SendKeys.SendWait("{RIGHT}")
                Call keybd_event(VK_RIGHT, 0, KEYEVENTF_EXTENDEDKEY, 0)

            Case "c"
                x1 = mp.X
                y1 = mp.Y
                SetCursorPos(x1, y1)
                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                testcase.Text = "clicked"

            Case Else
                Exit Select

        End Select

    End Sub

    'Dim count As Integer = 0

    Private Sub txtTransmit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTransmit.KeyDown
        If e.KeyCode = Keys.Enter Then
            SerialPort2.Write(txtTransmit.Text & vbCr) 'The text contained in the txtText will be sent to the serial port as ascii
            'plus the carriage return (Enter Key) the carriage return can be ommitted if the other end does not need it
            mp = MousePosition
            testx.Text = mp.X
            MPX = mp.X
            testy.Text = mp.Y
            MPY = mp.Y
        End If

    End Sub
End Class