Imports System.IO.Ports
Imports System.Configuration
Imports System.ComponentModel

Public Class Form_C2C

    Dim AppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
    Dim AppConfigSettings As AppSettingsSection = AppConfig.AppSettings
    '-----------------------------------------
    Dim ComPort_BaudRate() As Integer = {100, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200}
    Dim ComPort_Parity() As Parity = {Parity.None, Parity.Odd, Parity.Even, Parity.Mark, Parity.Space}
    Dim ComPort_Parity_Text() As String = {"None", "Odd", "Even", "Mark", "Space"}
    Dim ComPort_DataBits() As Integer = {5, 6, 7, 8}
    Dim ComPort_StopBits() As StopBits = {StopBits.None, StopBits.One, StopBits.OnePointFive, StopBits.Two}
    Dim ComPort_StopBits_Text() As String = {"0", "1", "1.5", "2"}
    '-----------------------------------------
    Dim Event_A_DataReceiving As Boolean = False  ' 是否發生資料接收：用於閃爍接收燈號用
    Dim Event_B_DataReceiving As Boolean = False  ' 是否發生資料接收：用於閃爍接收燈號用
    '-----------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchSystemComport()
        Notifyicon_RX_DrawBlink(NotifyIcon_C2C, False, False)
    End Sub

    ' 事件：ComPort A：接收資料
    Private Sub SerialPort_A_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles ComPort_A.DataReceived
        Dim ComPort As SerialPort = DirectCast(sender, SerialPort)
        Dim RX_Buff(64) As Byte
        Dim RX_Count As Integer

        RX_Count = ComPort.BytesToRead
        If RX_Count > 0 Then
            If Event_A_DataReceiving = False Then
                Event_A_DataReceiving = True
            End If
            If RX_Count > RX_Buff.Length Then
                Array.Resize(RX_Buff, RX_Count)
            End If
            ComPort.Read(RX_Buff, 0, RX_Count)
            If ComPort_B.IsOpen Then
                ComPort_B.Write(RX_Buff, 0, RX_Count)
            End If
        End If
    End Sub

    ' 事件：ComPort B：接收資料
    Private Sub SerialPort_B_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles ComPort_B.DataReceived
        Dim ComPort As SerialPort = DirectCast(sender, SerialPort)
        Dim RX_Buff(64) As Byte
        Dim RX_Count As Integer

        RX_Count = ComPort.BytesToRead
        If RX_Count > 0 Then
            If Event_B_DataReceiving = False Then
                Event_B_DataReceiving = True
            End If
            If RX_Count > RX_Buff.Length Then
                Array.Resize(RX_Buff, RX_Count)
            End If
            ComPort.Read(RX_Buff, 0, RX_Count)
            If ComPort_A.IsOpen Then
                ComPort_A.Write(RX_Buff, 0, RX_Count)
            End If
        End If
    End Sub

    ' 搜尋系統 ComPort
    Private Sub SearchSystemComport()
        Dim PortName As String = ""
        Dim PortBaud As Integer
        Dim PortParityText As String
        Dim PortDataBits As Integer
        Dim PortStopBitsText As String

        '---------------------------------------
        CB_ComPort_BaudRate_A.Sorted = True
        CB_ComPort_BaudRate_B.Sorted = True
        For Each PortName In My.Computer.Ports.SerialPortNames
            CB_ComPort_Name_A.Items.Add(PortName)
            CB_ComPort_Name_B.Items.Add(PortName)
        Next
        If CB_ComPort_Name_A.Items.Count > 0 Then
            BT_ComPort_Link.Enabled = True
            CB_ComPort_Name_A.SelectedIndex = 0
            CB_ComPort_Name_B.SelectedIndex = 0
        End If
        CB_ComPort_Name_A.Text = AppConfig_ItemString("Port_A_Name")
        CB_ComPort_Name_B.Text = AppConfig_ItemString("Port_B_Name")
        Check_ComPort_AB_Name()
        '---------------------------------------
        CB_ComPort_BaudRate_A.Sorted = False
        CB_ComPort_BaudRate_B.Sorted = False
        For Each PortBaud In ComPort_BaudRate
            CB_ComPort_BaudRate_A.Items.Add(PortBaud.ToString)
            CB_ComPort_BaudRate_B.Items.Add(PortBaud.ToString)
        Next
        CB_ComPort_BaudRate_A.SelectedIndex = 6
        CB_ComPort_BaudRate_B.SelectedIndex = 6
        CB_ComPort_BaudRate_A.Text = AppConfig_ItemString("Port_A_BaudRate")
        CB_ComPort_BaudRate_B.Text = AppConfig_ItemString("Port_B_BaudRate")
        '---------------------------------------
        CB_ComPort_Parity_A.Sorted = False
        CB_ComPort_Parity_B.Sorted = False
        For Each PortParityText In ComPort_Parity_Text
            CB_ComPort_Parity_A.Items.Add(PortParityText)
            CB_ComPort_Parity_B.Items.Add(PortParityText)
        Next
        CB_ComPort_Parity_A.SelectedIndex = 0
        CB_ComPort_Parity_B.SelectedIndex = 0
        CB_ComPort_Parity_A.Text = AppConfig_ItemString("Port_A_Parity")
        CB_ComPort_Parity_B.Text = AppConfig_ItemString("Port_B_Parity")
        '---------------------------------------
        CB_ComPort_DataBits_A.Sorted = False
        CB_ComPort_DataBits_B.Sorted = False
        For Each PortDataBits In ComPort_DataBits
            CB_ComPort_DataBits_A.Items.Add(PortDataBits.ToString())
            CB_ComPort_DataBits_B.Items.Add(PortDataBits.ToString())
        Next
        CB_ComPort_DataBits_A.SelectedIndex = CB_ComPort_DataBits_A.Items.Count - 1
        CB_ComPort_DataBits_B.SelectedIndex = CB_ComPort_DataBits_B.Items.Count - 1
        CB_ComPort_DataBits_A.Text = AppConfig_ItemString("Port_A_DataBits")
        CB_ComPort_DataBits_B.Text = AppConfig_ItemString("Port_B_DataBits")
        '---------------------------------------
        CB_ComPort_StopBits_A.Sorted = False
        CB_ComPort_StopBits_B.Sorted = False
        For Each PortStopBitsText In ComPort_StopBits_Text
            CB_ComPort_StopBits_A.Items.Add(PortStopBitsText)
            CB_ComPort_StopBits_B.Items.Add(PortStopBitsText)
        Next
        CB_ComPort_StopBits_A.SelectedIndex = 1
        CB_ComPort_StopBits_B.SelectedIndex = 1
        CB_ComPort_StopBits_A.Text = AppConfig_ItemString("Port_A_StopBits")
        CB_ComPort_StopBits_B.Text = AppConfig_ItemString("Port_B_StopBits")
        '---------------------------------------
        '---------------------------------------
    End Sub

    ' 設定資料：讀取項目值
    Private Function AppConfig_ItemString(ByVal ItemName As String) As String
        If IsNothing(AppConfigSettings.Settings(ItemName)) Then
            Return ("")
        Else
            Return (AppConfigSettings.Settings(ItemName).Value)
        End If
    End Function

    ' 設定資料：更新項目值
    Private Sub AppConfig_ItemUpdate(ByVal ItemName As String, ByVal ItemData As String)
        If IsNothing(AppConfigSettings.Settings(ItemName)) Then
            AppConfigSettings.Settings.Add(ItemName, ItemData)
        Else
            AppConfigSettings.Settings(ItemName).Value = ItemData
        End If
    End Sub

    ' 設定資料：儲存項目值
    Private Sub AppConfig_Save()   ' 設定資訊寫入
        Dim PortName As String = ""
        Dim Config As String = ""
        Dim ThreadMode As Boolean = False

        '------------------------------------------
        AppConfig_ItemUpdate("Port_A_Name", CB_ComPort_Name_A.Text)
        AppConfig_ItemUpdate("Port_A_BaudRate", CB_ComPort_BaudRate_A.Text)
        AppConfig_ItemUpdate("Port_A_Parity", CB_ComPort_Parity_A.Text)
        AppConfig_ItemUpdate("Port_A_DataBits", CB_ComPort_DataBits_A.Text)
        AppConfig_ItemUpdate("Port_A_StopBits", CB_ComPort_StopBits_A.Text)
        '------------------------------------------
        AppConfig_ItemUpdate("Port_B_Name", CB_ComPort_Name_B.Text)
        AppConfig_ItemUpdate("Port_B_BaudRate", CB_ComPort_BaudRate_B.Text)
        AppConfig_ItemUpdate("Port_B_Parity", CB_ComPort_Parity_B.Text)
        AppConfig_ItemUpdate("Port_B_DataBits", CB_ComPort_DataBits_B.Text)
        AppConfig_ItemUpdate("Port_B_StopBits", CB_ComPort_StopBits_B.Text)
        '------------------------------------------
        AppConfig.Save(ConfigurationSaveMode.Modified)  ' 儲存更新資料 
    End Sub

    ' 事件：視窗關閉中
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AppConfig_Save()
    End Sub

    ' 檢查 ComPort A 與 ComPort B 是否同一個
    Private Sub Check_ComPort_AB_Name()
        If CB_ComPort_Name_A.SelectedIndex = CB_ComPort_Name_B.SelectedIndex Then
            BT_ComPort_Link.Enabled = False
        Else
            BT_ComPort_Link.Enabled = True
        End If
    End Sub

    ' 事件：ComPort A：選擇值變更
    Private Sub CB_ComPort_Name_A_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ComPort_Name_A.SelectedIndexChanged
        Check_ComPort_AB_Name()
    End Sub

    ' 事件：ComPort B：選擇值變更
    Private Sub CB_ComPort_Name_B_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ComPort_Name_B.SelectedIndexChanged
        Check_ComPort_AB_Name()
    End Sub

    ' 事件：連線按鈕：被按下
    Private Sub BT_ComPort_Link_Click(sender As Object, e As EventArgs) Handles BT_ComPort_Link.Click
        If ComPort_A.IsOpen Then
            BT_ComPort_Link.Text = "連線"
            BT_ComPort_Link.BackColor = DirectCast(BT_ComPort_Link.Tag, Color)
            GroupBox_ComPort_A.Enabled = True
            GroupBox_ComPort_B.Enabled = True
            ComPort_Close()
        Else
            BT_ComPort_Link.Text = "離線"
            BT_ComPort_Link.Tag = BT_ComPort_Link.BackColor
            BT_ComPort_Link.BackColor = Color.YellowGreen
            GroupBox_ComPort_A.Enabled = False
            GroupBox_ComPort_B.Enabled = False
            ComPort_Open()
        End If
    End Sub

    ' ComPort：關閉
    Private Sub ComPort_Close()
        If ComPort_A.IsOpen Then
            ComPort_A.Close()
            ComPort_B.Close()
        End If
    End Sub

    ' ComPort：開啟
    Private Sub ComPort_Open()
        '------------------------------------------
        ComPort_A.PortName = CB_ComPort_Name_A.Text
        ComPort_A.BaudRate = ComPort_BaudRate(CB_ComPort_BaudRate_A.SelectedIndex)
        ComPort_A.Parity = ComPort_Parity(CB_ComPort_Parity_A.SelectedIndex)
        ComPort_A.DataBits = ComPort_DataBits(CB_ComPort_DataBits_A.SelectedIndex)
        ComPort_A.StopBits = ComPort_StopBits(CB_ComPort_DataBits_A.SelectedIndex)
        '------------------------------------------
        ComPort_B.PortName = CB_ComPort_Name_B.Text
        ComPort_B.BaudRate = ComPort_BaudRate(CB_ComPort_BaudRate_B.SelectedIndex)
        ComPort_B.Parity = ComPort_Parity(CB_ComPort_Parity_B.SelectedIndex)
        ComPort_B.DataBits = ComPort_DataBits(CB_ComPort_DataBits_B.SelectedIndex)
        ComPort_B.StopBits = ComPort_StopBits(CB_ComPort_DataBits_B.SelectedIndex)
        '------------------------------------------
        ComPort_A.Open()
        ComPort_B.Open()
    End Sub

    ' 事件：畫面大小變更時，可用來攔截最小化視窗被按下時
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon_ShowBalloonTip("縮小至系統列提示", "滑鼠連點系統列圖示可復原程式畫面!")
        End If
    End Sub

    ' 工作列中顯示氣球提示
    Private Sub NotifyIcon_ShowBalloonTip(ByVal Title As String, ByVal Text As String)
        NotifyIcon_C2C.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon_C2C.BalloonTipTitle = Title
        NotifyIcon_C2C.BalloonTipText = Text
        NotifyIcon_C2C.ShowBalloonTip(1000)
    End Sub

    ' 事件：通知區域圖示被滑鼠連點
    Private Sub NotifyIcon_C2C_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon_C2C.MouseDoubleClick
        Me.Show()
        WindowState = FormWindowState.Normal
    End Sub

    ' 事件：計時器：接收資料閃燈
    Private Sub Timer_RX_Blink_Tick(sender As Object, e As EventArgs) Handles Timer_RX_Blink.Tick
        Dim AorB_Blink As Boolean = False
        Dim A_RX_Blink As Boolean = False
        Dim B_RX_Blink As Boolean = False

        If Event_A_DataReceiving = True And CInt(TSSL_A_RX_Blink.Tag) = 0 Then
            TSSL_A_RX_Blink.Tag = 2
        End If
        With TSSL_A_RX_Blink
            Select Case CInt(.Tag)
                Case 2
                    .Text = "●"
                    .ForeColor = Color.GreenYellow
                    A_RX_Blink = True
                    AorB_Blink = True
                    .Tag = 1
                Case 1
                    .Text = "○"
                    .ForeColor = Color.Black
                    AorB_Blink = True
                    .Tag = 0
                    Event_A_DataReceiving = False
                Case 0
            End Select
        End With
        '------------------------------------------
        If Event_B_DataReceiving = True And CInt(TSSL_B_RX_Blink.Tag) = 0 Then
            TSSL_B_RX_Blink.Tag = 2
        End If
        With TSSL_B_RX_Blink
            Select Case CInt(.Tag)
                Case 2
                    .Text = "●"
                    .ForeColor = Color.GreenYellow
                    B_RX_Blink = True
                    AorB_Blink = True
                    .Tag = 1
                Case 1
                    .Text = "○"
                    .ForeColor = Color.Black
                    AorB_Blink = True
                    .Tag = 0
                    Event_B_DataReceiving = False
                Case 0
            End Select
        End With
        '------------------------------------------
        If AorB_Blink = True Then
            Notifyicon_RX_DrawBlink(NotifyIcon_C2C, A_RX_Blink, B_RX_Blink)
        End If
        '------------------------------------------
    End Sub

    ' 工作列圖示內顯示閃燈
    Private Sub Notifyicon_RX_DrawBlink(ByVal NI As NotifyIcon, ByVal RX_A As Boolean, ByVal RX_B As Boolean)
        Const IconSize As Integer = 16
        Dim NormalColor As Color = Color.Silver
        Dim BlinkColor As Color = Color.GreenYellow
        Dim myBitmap As Bitmap = New Bitmap(IconSize, IconSize, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim myGraphics As Graphics = Graphics.FromImage(myBitmap)
        Dim drawBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(NormalColor)
        Dim rect_A As New Rectangle(0, 0, CInt(IconSize / 2) - 1, IconSize - 1)
        Dim rect_B As New Rectangle(CInt(IconSize / 2), 0, IconSize - 1, IconSize - 1)

        '------------------------------------------
        myGraphics.Clear(Color.Red)
        '------------------------------------------
        If RX_A = True Then
            drawBrush.Color = BlinkColor
        Else
            drawBrush.Color = NormalColor
        End If
        myGraphics.FillRectangle(drawBrush, rect_A)
        '------------------------------------------
        If RX_B = True Then
            drawBrush.Color = BlinkColor
        Else
            drawBrush.Color = NormalColor
        End If
        myGraphics.FillRectangle(drawBrush, rect_B)
        '------------------------------------------
        If (NI.Icon IsNot Nothing) Then
            NI.Icon.Dispose()
        End If
        '------------------------------------------
        Dim HIcon As System.IntPtr = myBitmap.GetHicon()
        Dim newIcon As Icon = System.Drawing.Icon.FromHandle(HIcon)
        NI.Icon = newIcon
        DestroyIcon(newIcon.Handle)
        '------------------------------------------
    End Sub

    ' 使用處置原始圖示的 DestroyIcon Win32 API，以確保會釋放資源中的方法
    ' https://msdn.microsoft.com/zh-tw/library/system.drawing.icon.fromhandle(v=vs.110).aspx
    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

End Class
