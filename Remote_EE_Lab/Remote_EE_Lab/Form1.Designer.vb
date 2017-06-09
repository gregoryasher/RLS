<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.board_detect = New System.Windows.Forms.Button()
        Me.CommControlGroup = New System.Windows.Forms.GroupBox()
        Me.lbl_serial = New System.Windows.Forms.Label()
        Me.btn_test_2 = New System.Windows.Forms.Button()
        Me.btn_Dev_Test = New System.Windows.Forms.Button()
        Me.Serial_Text_Test = New System.Windows.Forms.RichTextBox()
        Me.btn_Send_Config = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Board7 = New System.Windows.Forms.TabPage()
        Me.ClearCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClockBox = New System.Windows.Forms.GroupBox()
        Me.ConnectClock = New System.Windows.Forms.RadioButton()
        Me.DisconnectClock = New System.Windows.Forms.RadioButton()
        Me.XOR1 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR1 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR1 = New System.Windows.Forms.RadioButton()
        Me.XOR2 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR2 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR2 = New System.Windows.Forms.RadioButton()
        Me.XOR3 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR3 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR3 = New System.Windows.Forms.RadioButton()
        Me.XOR4 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR4 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR4 = New System.Windows.Forms.RadioButton()
        Me.XOR5 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR5 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR5 = New System.Windows.Forms.RadioButton()
        Me.XOR6 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR6 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR6 = New System.Windows.Forms.RadioButton()
        Me.XOR7 = New System.Windows.Forms.GroupBox()
        Me.ConnectXOR7 = New System.Windows.Forms.RadioButton()
        Me.BypassXOR7 = New System.Windows.Forms.RadioButton()
        Me.PresetD1 = New System.Windows.Forms.ComboBox()
        Me.PresetD2 = New System.Windows.Forms.ComboBox()
        Me.PresetD3 = New System.Windows.Forms.ComboBox()
        Me.PresetD4 = New System.Windows.Forms.ComboBox()
        Me.PresetD5 = New System.Windows.Forms.ComboBox()
        Me.PresetD6 = New System.Windows.Forms.ComboBox()
        Me.PresetD7 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_board_7_status = New System.Windows.Forms.Label()
        Me.PresetD8 = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Board6 = New System.Windows.Forms.TabPage()
        Me.ResetZ80 = New System.Windows.Forms.GroupBox()
        Me.ResetZ80_Button = New System.Windows.Forms.Button()
        Me.SelectProgram = New System.Windows.Forms.GroupBox()
        Me.ProgramSelector = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_board_6_status = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Board5 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_board_5_status = New System.Windows.Forms.Label()
        Me.board_5_R3 = New System.Windows.Forms.ComboBox()
        Me.board_5_R2 = New System.Windows.Forms.ComboBox()
        Me.board_5_C1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Board4 = New System.Windows.Forms.TabPage()
        Me.Diode2 = New System.Windows.Forms.GroupBox()
        Me.board4_Diode2_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.board4_Diode2_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Diode1 = New System.Windows.Forms.GroupBox()
        Me.board4_Diode1_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.board4_Diode1_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_board_4_status = New System.Windows.Forms.Label()
        Me.board_4_R1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Board3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.board_3_multimeter_refresh = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.board_3_multimeter_output = New System.Windows.Forms.RichTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbl_board_3_status = New System.Windows.Forms.Label()
        Me.board_3_R3 = New System.Windows.Forms.ComboBox()
        Me.board_3_R2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Board_2 = New System.Windows.Forms.TabPage()
        Me.lbl_board_2 = New System.Windows.Forms.Label()
        Me.lbl_board_2_status = New System.Windows.Forms.Label()
        Me.board_2_Circuit_Control = New System.Windows.Forms.GroupBox()
        Me.board_2_ch2 = New System.Windows.Forms.GroupBox()
        Me.board_2_lbl6 = New System.Windows.Forms.Label()
        Me.board_2_scope_ch_2_gain = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl5 = New System.Windows.Forms.Label()
        Me.board_2_lbl4 = New System.Windows.Forms.Label()
        Me.board_2_Ch_1 = New System.Windows.Forms.GroupBox()
        Me.board_2_lbl3 = New System.Windows.Forms.Label()
        Me.board_2_scope_ch_1_gain = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_2 = New System.Windows.Forms.Label()
        Me.board_2_lbl1 = New System.Windows.Forms.Label()
        Me.board_2_lbl_C1 = New System.Windows.Forms.Label()
        Me.board_2_C1 = New System.Windows.Forms.ComboBox()
        Me.board_2_R4 = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_C2 = New System.Windows.Forms.Label()
        Me.board_2_lbl_R4 = New System.Windows.Forms.Label()
        Me.board_2_C2 = New System.Windows.Forms.ComboBox()
        Me.board_2_R3 = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_R2 = New System.Windows.Forms.Label()
        Me.board_2_lbl_R3 = New System.Windows.Forms.Label()
        Me.board_2_R2 = New System.Windows.Forms.ComboBox()
        Me.board_2_R1 = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_R1 = New System.Windows.Forms.Label()
        Me.board_2_chematic = New System.Windows.Forms.PictureBox()
        Me.Board_1 = New System.Windows.Forms.TabPage()
        Me.lbl_board_1_status = New System.Windows.Forms.Label()
        Me.Circuit_Controls = New System.Windows.Forms.GroupBox()
        Me.brd_1_ch2 = New System.Windows.Forms.GroupBox()
        Me.board_1_lbl_2 = New System.Windows.Forms.Label()
        Me.brd_1_ch_2_gain = New System.Windows.Forms.ComboBox()
        Me.lbl_gain_2 = New System.Windows.Forms.Label()
        Me.Brd_1_Scope_Ch2 = New System.Windows.Forms.ComboBox()
        Me.lbl_Scope_1 = New System.Windows.Forms.Label()
        Me.brd_1_ch1 = New System.Windows.Forms.GroupBox()
        Me.board_1_lbl_1 = New System.Windows.Forms.Label()
        Me.brd_1_ch1_gain = New System.Windows.Forms.ComboBox()
        Me.lbl_gain_1 = New System.Windows.Forms.Label()
        Me.lbl_scope = New System.Windows.Forms.Label()
        Me.Brd_1_Scope = New System.Windows.Forms.ComboBox()
        Me.lbl5k_1 = New System.Windows.Forms.Label()
        Me.lbl_board_1 = New System.Windows.Forms.Label()
        Me.lbl_5k = New System.Windows.Forms.Label()
        Me.lbl_1k = New System.Windows.Forms.Label()
        Me.Brd_1_Res_Select = New System.Windows.Forms.ComboBox()
        Me.Lbl_19k = New System.Windows.Forms.Label()
        Me.lbl_A = New System.Windows.Forms.Label()
        Me.board_1_R3_enable = New System.Windows.Forms.ComboBox()
        Me.lbl_B = New System.Windows.Forms.Label()
        Me.lbl_D = New System.Windows.Forms.Label()
        Me.lbl_C = New System.Windows.Forms.Label()
        Me.Board_1_Image = New System.Windows.Forms.PictureBox()
        Me.Setup = New System.Windows.Forms.TabControl()
        Me.TabPageSetup = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComPortTextBox = New System.Windows.Forms.RichTextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CommControlGroup.SuspendLayout()
        Me.Board7.SuspendLayout()
        Me.ClockBox.SuspendLayout()
        Me.XOR1.SuspendLayout()
        Me.XOR2.SuspendLayout()
        Me.XOR3.SuspendLayout()
        Me.XOR4.SuspendLayout()
        Me.XOR5.SuspendLayout()
        Me.XOR6.SuspendLayout()
        Me.XOR7.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board6.SuspendLayout()
        Me.ResetZ80.SuspendLayout()
        Me.SelectProgram.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board4.SuspendLayout()
        Me.Diode2.SuspendLayout()
        Me.Diode1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board_2.SuspendLayout()
        Me.board_2_Circuit_Control.SuspendLayout()
        Me.board_2_ch2.SuspendLayout()
        Me.board_2_Ch_1.SuspendLayout()
        CType(Me.board_2_chematic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board_1.SuspendLayout()
        Me.Circuit_Controls.SuspendLayout()
        Me.brd_1_ch2.SuspendLayout()
        Me.brd_1_ch1.SuspendLayout()
        CType(Me.Board_1_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Setup.SuspendLayout()
        Me.TabPageSetup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'board_detect
        '
        Me.board_detect.BackColor = System.Drawing.Color.LightBlue
        Me.board_detect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_detect.Location = New System.Drawing.Point(15, 19)
        Me.board_detect.Name = "board_detect"
        Me.board_detect.Size = New System.Drawing.Size(96, 23)
        Me.board_detect.TabIndex = 0
        Me.board_detect.Text = "Check Board "
        Me.board_detect.UseVisualStyleBackColor = False
        '
        'CommControlGroup
        '
        Me.CommControlGroup.Controls.Add(Me.lbl_serial)
        Me.CommControlGroup.Controls.Add(Me.btn_test_2)
        Me.CommControlGroup.Controls.Add(Me.btn_Dev_Test)
        Me.CommControlGroup.Controls.Add(Me.Serial_Text_Test)
        Me.CommControlGroup.Controls.Add(Me.btn_Send_Config)
        Me.CommControlGroup.Controls.Add(Me.board_detect)
        Me.CommControlGroup.Location = New System.Drawing.Point(21, 12)
        Me.CommControlGroup.Name = "CommControlGroup"
        Me.CommControlGroup.Size = New System.Drawing.Size(911, 65)
        Me.CommControlGroup.TabIndex = 1
        Me.CommControlGroup.TabStop = False
        Me.CommControlGroup.Text = "Communication Control"
        '
        'lbl_serial
        '
        Me.lbl_serial.AutoSize = True
        Me.lbl_serial.Location = New System.Drawing.Point(228, 24)
        Me.lbl_serial.Name = "lbl_serial"
        Me.lbl_serial.Size = New System.Drawing.Size(96, 13)
        Me.lbl_serial.TabIndex = 5
        Me.lbl_serial.Text = "Serial Port Monitor:"
        '
        'btn_test_2
        '
        Me.btn_test_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_test_2.Location = New System.Drawing.Point(816, 19)
        Me.btn_test_2.Name = "btn_test_2"
        Me.btn_test_2.Size = New System.Drawing.Size(87, 23)
        Me.btn_test_2.TabIndex = 4
        Me.btn_test_2.Text = "Logic Analyzer"
        Me.btn_test_2.UseVisualStyleBackColor = True
        '
        'btn_Dev_Test
        '
        Me.btn_Dev_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Dev_Test.Location = New System.Drawing.Point(603, 19)
        Me.btn_Dev_Test.Name = "btn_Dev_Test"
        Me.btn_Dev_Test.Size = New System.Drawing.Size(207, 23)
        Me.btn_Dev_Test.TabIndex = 3
        Me.btn_Dev_Test.Text = "Oscilloscope/Function Generator"
        Me.btn_Dev_Test.UseVisualStyleBackColor = True
        '
        'Serial_Text_Test
        '
        Me.Serial_Text_Test.Location = New System.Drawing.Point(330, 19)
        Me.Serial_Text_Test.Multiline = False
        Me.Serial_Text_Test.Name = "Serial_Text_Test"
        Me.Serial_Text_Test.ReadOnly = True
        Me.Serial_Text_Test.Size = New System.Drawing.Size(255, 23)
        Me.Serial_Text_Test.TabIndex = 2
        Me.Serial_Text_Test.Text = ""
        '
        'btn_Send_Config
        '
        Me.btn_Send_Config.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Send_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Send_Config.Location = New System.Drawing.Point(117, 19)
        Me.btn_Send_Config.Name = "btn_Send_Config"
        Me.btn_Send_Config.Size = New System.Drawing.Size(105, 23)
        Me.btn_Send_Config.TabIndex = 1
        Me.btn_Send_Config.Text = "Update Board"
        Me.btn_Send_Config.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Board7
        '
        Me.Board7.Controls.Add(Me.ClearCheckBox)
        Me.Board7.Controls.Add(Me.ClockBox)
        Me.Board7.Controls.Add(Me.XOR1)
        Me.Board7.Controls.Add(Me.XOR2)
        Me.Board7.Controls.Add(Me.XOR3)
        Me.Board7.Controls.Add(Me.XOR4)
        Me.Board7.Controls.Add(Me.XOR5)
        Me.Board7.Controls.Add(Me.XOR6)
        Me.Board7.Controls.Add(Me.XOR7)
        Me.Board7.Controls.Add(Me.PresetD1)
        Me.Board7.Controls.Add(Me.PresetD2)
        Me.Board7.Controls.Add(Me.PresetD3)
        Me.Board7.Controls.Add(Me.PresetD4)
        Me.Board7.Controls.Add(Me.PresetD5)
        Me.Board7.Controls.Add(Me.PresetD6)
        Me.Board7.Controls.Add(Me.PresetD7)
        Me.Board7.Controls.Add(Me.Label25)
        Me.Board7.Controls.Add(Me.lbl_board_7_status)
        Me.Board7.Controls.Add(Me.PresetD8)
        Me.Board7.Controls.Add(Me.PictureBox5)
        Me.Board7.Location = New System.Drawing.Point(4, 22)
        Me.Board7.Name = "Board7"
        Me.Board7.Padding = New System.Windows.Forms.Padding(3)
        Me.Board7.Size = New System.Drawing.Size(903, 414)
        Me.Board7.TabIndex = 6
        Me.Board7.Text = "Experiment 7"
        Me.Board7.UseVisualStyleBackColor = True
        '
        'ClearCheckBox
        '
        Me.ClearCheckBox.AutoSize = True
        Me.ClearCheckBox.Location = New System.Drawing.Point(87, 301)
        Me.ClearCheckBox.Name = "ClearCheckBox"
        Me.ClearCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ClearCheckBox.TabIndex = 38
        Me.ClearCheckBox.UseVisualStyleBackColor = True
        '
        'ClockBox
        '
        Me.ClockBox.Controls.Add(Me.ConnectClock)
        Me.ClockBox.Controls.Add(Me.DisconnectClock)
        Me.ClockBox.Location = New System.Drawing.Point(11, 346)
        Me.ClockBox.Name = "ClockBox"
        Me.ClockBox.Size = New System.Drawing.Size(117, 51)
        Me.ClockBox.TabIndex = 37
        Me.ClockBox.TabStop = False
        Me.ClockBox.Text = "Clock"
        '
        'ConnectClock
        '
        Me.ConnectClock.AutoSize = True
        Me.ConnectClock.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectClock.Location = New System.Drawing.Point(6, 11)
        Me.ConnectClock.Name = "ConnectClock"
        Me.ConnectClock.Size = New System.Drawing.Size(95, 17)
        Me.ConnectClock.TabIndex = 32
        Me.ConnectClock.TabStop = True
        Me.ConnectClock.Text = "Connect Clock"
        Me.ConnectClock.UseVisualStyleBackColor = True
        '
        'DisconnectClock
        '
        Me.DisconnectClock.AutoSize = True
        Me.DisconnectClock.ForeColor = System.Drawing.Color.Red
        Me.DisconnectClock.Location = New System.Drawing.Point(6, 29)
        Me.DisconnectClock.Name = "DisconnectClock"
        Me.DisconnectClock.Size = New System.Drawing.Size(109, 17)
        Me.DisconnectClock.TabIndex = 33
        Me.DisconnectClock.TabStop = True
        Me.DisconnectClock.Text = "Disconnect Clock"
        Me.DisconnectClock.UseVisualStyleBackColor = True
        '
        'XOR1
        '
        Me.XOR1.Controls.Add(Me.ConnectXOR1)
        Me.XOR1.Controls.Add(Me.BypassXOR1)
        Me.XOR1.Location = New System.Drawing.Point(1104, 202)
        Me.XOR1.Name = "XOR1"
        Me.XOR1.Size = New System.Drawing.Size(72, 51)
        Me.XOR1.TabIndex = 36
        Me.XOR1.TabStop = False
        Me.XOR1.Text = "XOR 1"
        '
        'ConnectXOR1
        '
        Me.ConnectXOR1.AutoSize = True
        Me.ConnectXOR1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR1.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR1.Name = "ConnectXOR1"
        Me.ConnectXOR1.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR1.TabIndex = 32
        Me.ConnectXOR1.TabStop = True
        Me.ConnectXOR1.Text = "Include"
        Me.ConnectXOR1.UseVisualStyleBackColor = True
        '
        'BypassXOR1
        '
        Me.BypassXOR1.AutoSize = True
        Me.BypassXOR1.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR1.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR1.Name = "BypassXOR1"
        Me.BypassXOR1.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR1.TabIndex = 33
        Me.BypassXOR1.TabStop = True
        Me.BypassXOR1.Text = "Bypass"
        Me.BypassXOR1.UseVisualStyleBackColor = True
        '
        'XOR2
        '
        Me.XOR2.Controls.Add(Me.ConnectXOR2)
        Me.XOR2.Controls.Add(Me.BypassXOR2)
        Me.XOR2.Location = New System.Drawing.Point(942, 202)
        Me.XOR2.Name = "XOR2"
        Me.XOR2.Size = New System.Drawing.Size(72, 51)
        Me.XOR2.TabIndex = 36
        Me.XOR2.TabStop = False
        Me.XOR2.Text = "XOR 2"
        '
        'ConnectXOR2
        '
        Me.ConnectXOR2.AutoSize = True
        Me.ConnectXOR2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR2.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR2.Name = "ConnectXOR2"
        Me.ConnectXOR2.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR2.TabIndex = 32
        Me.ConnectXOR2.TabStop = True
        Me.ConnectXOR2.Text = "Include"
        Me.ConnectXOR2.UseVisualStyleBackColor = True
        '
        'BypassXOR2
        '
        Me.BypassXOR2.AutoSize = True
        Me.BypassXOR2.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR2.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR2.Name = "BypassXOR2"
        Me.BypassXOR2.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR2.TabIndex = 33
        Me.BypassXOR2.TabStop = True
        Me.BypassXOR2.Text = "Bypass"
        Me.BypassXOR2.UseVisualStyleBackColor = True
        '
        'XOR3
        '
        Me.XOR3.Controls.Add(Me.ConnectXOR3)
        Me.XOR3.Controls.Add(Me.BypassXOR3)
        Me.XOR3.Location = New System.Drawing.Point(775, 202)
        Me.XOR3.Name = "XOR3"
        Me.XOR3.Size = New System.Drawing.Size(72, 51)
        Me.XOR3.TabIndex = 36
        Me.XOR3.TabStop = False
        Me.XOR3.Text = "XOR 3"
        '
        'ConnectXOR3
        '
        Me.ConnectXOR3.AutoSize = True
        Me.ConnectXOR3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR3.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR3.Name = "ConnectXOR3"
        Me.ConnectXOR3.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR3.TabIndex = 32
        Me.ConnectXOR3.TabStop = True
        Me.ConnectXOR3.Text = "Include"
        Me.ConnectXOR3.UseVisualStyleBackColor = True
        '
        'BypassXOR3
        '
        Me.BypassXOR3.AutoSize = True
        Me.BypassXOR3.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR3.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR3.Name = "BypassXOR3"
        Me.BypassXOR3.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR3.TabIndex = 33
        Me.BypassXOR3.TabStop = True
        Me.BypassXOR3.Text = "Bypass"
        Me.BypassXOR3.UseVisualStyleBackColor = True
        '
        'XOR4
        '
        Me.XOR4.Controls.Add(Me.ConnectXOR4)
        Me.XOR4.Controls.Add(Me.BypassXOR4)
        Me.XOR4.Location = New System.Drawing.Point(616, 202)
        Me.XOR4.Name = "XOR4"
        Me.XOR4.Size = New System.Drawing.Size(72, 51)
        Me.XOR4.TabIndex = 36
        Me.XOR4.TabStop = False
        Me.XOR4.Text = "XOR 4"
        '
        'ConnectXOR4
        '
        Me.ConnectXOR4.AutoSize = True
        Me.ConnectXOR4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR4.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR4.Name = "ConnectXOR4"
        Me.ConnectXOR4.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR4.TabIndex = 32
        Me.ConnectXOR4.TabStop = True
        Me.ConnectXOR4.Text = "Include"
        Me.ConnectXOR4.UseVisualStyleBackColor = True
        '
        'BypassXOR4
        '
        Me.BypassXOR4.AutoSize = True
        Me.BypassXOR4.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR4.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR4.Name = "BypassXOR4"
        Me.BypassXOR4.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR4.TabIndex = 33
        Me.BypassXOR4.TabStop = True
        Me.BypassXOR4.Text = "Bypass"
        Me.BypassXOR4.UseVisualStyleBackColor = True
        '
        'XOR5
        '
        Me.XOR5.Controls.Add(Me.ConnectXOR5)
        Me.XOR5.Controls.Add(Me.BypassXOR5)
        Me.XOR5.Location = New System.Drawing.Point(452, 202)
        Me.XOR5.Name = "XOR5"
        Me.XOR5.Size = New System.Drawing.Size(72, 51)
        Me.XOR5.TabIndex = 36
        Me.XOR5.TabStop = False
        Me.XOR5.Text = "XOR 5"
        '
        'ConnectXOR5
        '
        Me.ConnectXOR5.AutoSize = True
        Me.ConnectXOR5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR5.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR5.Name = "ConnectXOR5"
        Me.ConnectXOR5.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR5.TabIndex = 32
        Me.ConnectXOR5.TabStop = True
        Me.ConnectXOR5.Text = "Include"
        Me.ConnectXOR5.UseVisualStyleBackColor = True
        '
        'BypassXOR5
        '
        Me.BypassXOR5.AutoSize = True
        Me.BypassXOR5.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR5.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR5.Name = "BypassXOR5"
        Me.BypassXOR5.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR5.TabIndex = 33
        Me.BypassXOR5.TabStop = True
        Me.BypassXOR5.Text = "Bypass"
        Me.BypassXOR5.UseVisualStyleBackColor = True
        '
        'XOR6
        '
        Me.XOR6.Controls.Add(Me.ConnectXOR6)
        Me.XOR6.Controls.Add(Me.BypassXOR6)
        Me.XOR6.Location = New System.Drawing.Point(293, 202)
        Me.XOR6.Name = "XOR6"
        Me.XOR6.Size = New System.Drawing.Size(72, 51)
        Me.XOR6.TabIndex = 35
        Me.XOR6.TabStop = False
        Me.XOR6.Text = "XOR 6"
        '
        'ConnectXOR6
        '
        Me.ConnectXOR6.AutoSize = True
        Me.ConnectXOR6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR6.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR6.Name = "ConnectXOR6"
        Me.ConnectXOR6.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR6.TabIndex = 32
        Me.ConnectXOR6.TabStop = True
        Me.ConnectXOR6.Text = "Include"
        Me.ConnectXOR6.UseVisualStyleBackColor = True
        '
        'BypassXOR6
        '
        Me.BypassXOR6.AutoSize = True
        Me.BypassXOR6.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR6.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR6.Name = "BypassXOR6"
        Me.BypassXOR6.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR6.TabIndex = 33
        Me.BypassXOR6.TabStop = True
        Me.BypassXOR6.Text = "Bypass"
        Me.BypassXOR6.UseVisualStyleBackColor = True
        '
        'XOR7
        '
        Me.XOR7.Controls.Add(Me.ConnectXOR7)
        Me.XOR7.Controls.Add(Me.BypassXOR7)
        Me.XOR7.Location = New System.Drawing.Point(130, 202)
        Me.XOR7.Name = "XOR7"
        Me.XOR7.Size = New System.Drawing.Size(72, 51)
        Me.XOR7.TabIndex = 34
        Me.XOR7.TabStop = False
        Me.XOR7.Text = "XOR 7"
        '
        'ConnectXOR7
        '
        Me.ConnectXOR7.AutoSize = True
        Me.ConnectXOR7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ConnectXOR7.Location = New System.Drawing.Point(6, 11)
        Me.ConnectXOR7.Name = "ConnectXOR7"
        Me.ConnectXOR7.Size = New System.Drawing.Size(60, 17)
        Me.ConnectXOR7.TabIndex = 32
        Me.ConnectXOR7.TabStop = True
        Me.ConnectXOR7.Text = "Include"
        Me.ConnectXOR7.UseVisualStyleBackColor = True
        '
        'BypassXOR7
        '
        Me.BypassXOR7.AutoSize = True
        Me.BypassXOR7.ForeColor = System.Drawing.Color.Red
        Me.BypassXOR7.Location = New System.Drawing.Point(6, 29)
        Me.BypassXOR7.Name = "BypassXOR7"
        Me.BypassXOR7.Size = New System.Drawing.Size(59, 17)
        Me.BypassXOR7.TabIndex = 33
        Me.BypassXOR7.TabStop = True
        Me.BypassXOR7.Text = "Bypass"
        Me.BypassXOR7.UseVisualStyleBackColor = True
        '
        'PresetD1
        '
        Me.PresetD1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD1.FormattingEnabled = True
        Me.PresetD1.Items.AddRange(New Object() {"1"})
        Me.PresetD1.Location = New System.Drawing.Point(1205, 121)
        Me.PresetD1.Name = "PresetD1"
        Me.PresetD1.Size = New System.Drawing.Size(40, 21)
        Me.PresetD1.TabIndex = 24
        '
        'PresetD2
        '
        Me.PresetD2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD2.FormattingEnabled = True
        Me.PresetD2.Items.AddRange(New Object() {"1"})
        Me.PresetD2.Location = New System.Drawing.Point(1044, 121)
        Me.PresetD2.Name = "PresetD2"
        Me.PresetD2.Size = New System.Drawing.Size(40, 21)
        Me.PresetD2.TabIndex = 23
        '
        'PresetD3
        '
        Me.PresetD3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD3.FormattingEnabled = True
        Me.PresetD3.Items.AddRange(New Object() {"1"})
        Me.PresetD3.Location = New System.Drawing.Point(884, 121)
        Me.PresetD3.Name = "PresetD3"
        Me.PresetD3.Size = New System.Drawing.Size(40, 21)
        Me.PresetD3.TabIndex = 22
        '
        'PresetD4
        '
        Me.PresetD4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD4.FormattingEnabled = True
        Me.PresetD4.Items.AddRange(New Object() {"1"})
        Me.PresetD4.Location = New System.Drawing.Point(721, 121)
        Me.PresetD4.Name = "PresetD4"
        Me.PresetD4.Size = New System.Drawing.Size(40, 21)
        Me.PresetD4.TabIndex = 21
        '
        'PresetD5
        '
        Me.PresetD5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD5.FormattingEnabled = True
        Me.PresetD5.Items.AddRange(New Object() {"1"})
        Me.PresetD5.Location = New System.Drawing.Point(560, 121)
        Me.PresetD5.Name = "PresetD5"
        Me.PresetD5.Size = New System.Drawing.Size(40, 21)
        Me.PresetD5.TabIndex = 20
        '
        'PresetD6
        '
        Me.PresetD6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD6.FormattingEnabled = True
        Me.PresetD6.Items.AddRange(New Object() {"1"})
        Me.PresetD6.Location = New System.Drawing.Point(398, 121)
        Me.PresetD6.Name = "PresetD6"
        Me.PresetD6.Size = New System.Drawing.Size(40, 21)
        Me.PresetD6.TabIndex = 19
        '
        'PresetD7
        '
        Me.PresetD7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD7.FormattingEnabled = True
        Me.PresetD7.Items.AddRange(New Object() {"1"})
        Me.PresetD7.Location = New System.Drawing.Point(237, 121)
        Me.PresetD7.Name = "PresetD7"
        Me.PresetD7.Size = New System.Drawing.Size(40, 21)
        Me.PresetD7.TabIndex = 18
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(542, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(172, 13)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Learning to Use the Logic Analyzer"
        '
        'lbl_board_7_status
        '
        Me.lbl_board_7_status.AutoSize = True
        Me.lbl_board_7_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_7_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_7_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_7_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_7_status.Name = "lbl_board_7_status"
        Me.lbl_board_7_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_7_status.TabIndex = 16
        Me.lbl_board_7_status.Text = "Inactive"
        '
        'PresetD8
        '
        Me.PresetD8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PresetD8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PresetD8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PresetD8.FormattingEnabled = True
        Me.PresetD8.Items.AddRange(New Object() {"1"})
        Me.PresetD8.Location = New System.Drawing.Point(75, 121)
        Me.PresetD8.Name = "PresetD8"
        Me.PresetD8.Size = New System.Drawing.Size(40, 21)
        Me.PresetD8.TabIndex = 8
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 44)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1290, 364)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Board6
        '
        Me.Board6.Controls.Add(Me.ResetZ80)
        Me.Board6.Controls.Add(Me.SelectProgram)
        Me.Board6.Controls.Add(Me.Label19)
        Me.Board6.Controls.Add(Me.lbl_board_6_status)
        Me.Board6.Controls.Add(Me.PictureBox4)
        Me.Board6.Location = New System.Drawing.Point(4, 22)
        Me.Board6.Name = "Board6"
        Me.Board6.Padding = New System.Windows.Forms.Padding(3)
        Me.Board6.Size = New System.Drawing.Size(903, 414)
        Me.Board6.TabIndex = 5
        Me.Board6.Text = "Experiment 6"
        Me.Board6.UseVisualStyleBackColor = True
        '
        'ResetZ80
        '
        Me.ResetZ80.Controls.Add(Me.ResetZ80_Button)
        Me.ResetZ80.Location = New System.Drawing.Point(736, 214)
        Me.ResetZ80.Name = "ResetZ80"
        Me.ResetZ80.Size = New System.Drawing.Size(109, 78)
        Me.ResetZ80.TabIndex = 19
        Me.ResetZ80.TabStop = False
        Me.ResetZ80.Text = "Reset Z80"
        '
        'ResetZ80_Button
        '
        Me.ResetZ80_Button.Location = New System.Drawing.Point(6, 32)
        Me.ResetZ80_Button.Name = "ResetZ80_Button"
        Me.ResetZ80_Button.Size = New System.Drawing.Size(97, 23)
        Me.ResetZ80_Button.TabIndex = 0
        Me.ResetZ80_Button.Text = "Reset"
        Me.ResetZ80_Button.UseVisualStyleBackColor = True
        '
        'SelectProgram
        '
        Me.SelectProgram.Controls.Add(Me.ProgramSelector)
        Me.SelectProgram.Location = New System.Drawing.Point(736, 120)
        Me.SelectProgram.Name = "SelectProgram"
        Me.SelectProgram.Size = New System.Drawing.Size(109, 79)
        Me.SelectProgram.TabIndex = 18
        Me.SelectProgram.TabStop = False
        Me.SelectProgram.Text = "Select Program"
        '
        'ProgramSelector
        '
        Me.ProgramSelector.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProgramSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProgramSelector.FormattingEnabled = True
        Me.ProgramSelector.Items.AddRange(New Object() {"Program A", "Program B", "Program C", "Program D", "Program E"})
        Me.ProgramSelector.Location = New System.Drawing.Point(6, 32)
        Me.ProgramSelector.Name = "ProgramSelector"
        Me.ProgramSelector.Size = New System.Drawing.Size(97, 21)
        Me.ProgramSelector.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(271, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(175, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Debugging a Microprocessor Circuit"
        '
        'lbl_board_6_status
        '
        Me.lbl_board_6_status.AutoSize = True
        Me.lbl_board_6_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_6_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_6_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_6_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_6_status.Name = "lbl_board_6_status"
        Me.lbl_board_6_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_6_status.TabIndex = 16
        Me.lbl_board_6_status.Text = "Inactive"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 44)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(724, 368)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Board5
        '
        Me.Board5.Controls.Add(Me.Label9)
        Me.Board5.Controls.Add(Me.lbl_board_5_status)
        Me.Board5.Controls.Add(Me.board_5_R3)
        Me.Board5.Controls.Add(Me.board_5_R2)
        Me.Board5.Controls.Add(Me.board_5_C1)
        Me.Board5.Controls.Add(Me.PictureBox3)
        Me.Board5.Location = New System.Drawing.Point(4, 22)
        Me.Board5.Name = "Board5"
        Me.Board5.Padding = New System.Windows.Forms.Padding(3)
        Me.Board5.Size = New System.Drawing.Size(903, 414)
        Me.Board5.TabIndex = 4
        Me.Board5.Text = "Experiment 5"
        Me.Board5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Integrator With Shunt Resistor vs. Low-Pass Filter"
        '
        'lbl_board_5_status
        '
        Me.lbl_board_5_status.AutoSize = True
        Me.lbl_board_5_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_5_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_5_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_5_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_5_status.Name = "lbl_board_5_status"
        Me.lbl_board_5_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_5_status.TabIndex = 16
        Me.lbl_board_5_status.Text = "Inactive"
        '
        'board_5_R3
        '
        Me.board_5_R3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_5_R3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_5_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_5_R3.FormattingEnabled = True
        Me.board_5_R3.Items.AddRange(New Object() {"Open", "10 k"})
        Me.board_5_R3.Location = New System.Drawing.Point(408, 256)
        Me.board_5_R3.Name = "board_5_R3"
        Me.board_5_R3.Size = New System.Drawing.Size(65, 21)
        Me.board_5_R3.TabIndex = 4
        '
        'board_5_R2
        '
        Me.board_5_R2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_5_R2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_5_R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_5_R2.FormattingEnabled = True
        Me.board_5_R2.Items.AddRange(New Object() {"10 k", "20 k"})
        Me.board_5_R2.Location = New System.Drawing.Point(246, 86)
        Me.board_5_R2.Name = "board_5_R2"
        Me.board_5_R2.Size = New System.Drawing.Size(65, 21)
        Me.board_5_R2.TabIndex = 12
        '
        'board_5_C1
        '
        Me.board_5_C1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_5_C1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_5_C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_5_C1.FormattingEnabled = True
        Me.board_5_C1.Items.AddRange(New Object() {"0.22 uF", "0.01 uF"})
        Me.board_5_C1.Location = New System.Drawing.Point(362, 144)
        Me.board_5_C1.Name = "board_5_C1"
        Me.board_5_C1.Size = New System.Drawing.Size(65, 21)
        Me.board_5_C1.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(842, 368)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Board4
        '
        Me.Board4.Controls.Add(Me.Diode2)
        Me.Board4.Controls.Add(Me.Diode1)
        Me.Board4.Controls.Add(Me.Label1)
        Me.Board4.Controls.Add(Me.lbl_board_4_status)
        Me.Board4.Controls.Add(Me.board_4_R1)
        Me.Board4.Controls.Add(Me.PictureBox1)
        Me.Board4.Location = New System.Drawing.Point(4, 22)
        Me.Board4.Name = "Board4"
        Me.Board4.Padding = New System.Windows.Forms.Padding(3)
        Me.Board4.Size = New System.Drawing.Size(903, 414)
        Me.Board4.TabIndex = 2
        Me.Board4.Text = "Experiment 4"
        Me.Board4.UseVisualStyleBackColor = True
        '
        'Diode2
        '
        Me.Diode2.BackColor = System.Drawing.Color.Transparent
        Me.Diode2.Controls.Add(Me.board4_Diode2_RadioButton2)
        Me.Diode2.Controls.Add(Me.board4_Diode2_RadioButton1)
        Me.Diode2.Location = New System.Drawing.Point(445, 278)
        Me.Diode2.Name = "Diode2"
        Me.Diode2.Size = New System.Drawing.Size(62, 71)
        Me.Diode2.TabIndex = 23
        Me.Diode2.TabStop = False
        '
        'board4_Diode2_RadioButton2
        '
        Me.board4_Diode2_RadioButton2.AutoSize = True
        Me.board4_Diode2_RadioButton2.Image = CType(resources.GetObject("board4_Diode2_RadioButton2.Image"), System.Drawing.Image)
        Me.board4_Diode2_RadioButton2.Location = New System.Drawing.Point(6, 46)
        Me.board4_Diode2_RadioButton2.Name = "board4_Diode2_RadioButton2"
        Me.board4_Diode2_RadioButton2.Size = New System.Drawing.Size(53, 22)
        Me.board4_Diode2_RadioButton2.TabIndex = 1
        Me.board4_Diode2_RadioButton2.TabStop = True
        Me.board4_Diode2_RadioButton2.UseVisualStyleBackColor = True
        '
        'board4_Diode2_RadioButton1
        '
        Me.board4_Diode2_RadioButton1.AutoSize = True
        Me.board4_Diode2_RadioButton1.Image = CType(resources.GetObject("board4_Diode2_RadioButton1.Image"), System.Drawing.Image)
        Me.board4_Diode2_RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.board4_Diode2_RadioButton1.Name = "board4_Diode2_RadioButton1"
        Me.board4_Diode2_RadioButton1.Size = New System.Drawing.Size(53, 22)
        Me.board4_Diode2_RadioButton1.TabIndex = 0
        Me.board4_Diode2_RadioButton1.TabStop = True
        Me.board4_Diode2_RadioButton1.UseVisualStyleBackColor = True
        '
        'Diode1
        '
        Me.Diode1.BackColor = System.Drawing.Color.Transparent
        Me.Diode1.Controls.Add(Me.board4_Diode1_RadioButton2)
        Me.Diode1.Controls.Add(Me.board4_Diode1_RadioButton1)
        Me.Diode1.Location = New System.Drawing.Point(355, 79)
        Me.Diode1.Name = "Diode1"
        Me.Diode1.Size = New System.Drawing.Size(62, 71)
        Me.Diode1.TabIndex = 22
        Me.Diode1.TabStop = False
        '
        'board4_Diode1_RadioButton2
        '
        Me.board4_Diode1_RadioButton2.AutoSize = True
        Me.board4_Diode1_RadioButton2.Image = CType(resources.GetObject("board4_Diode1_RadioButton2.Image"), System.Drawing.Image)
        Me.board4_Diode1_RadioButton2.Location = New System.Drawing.Point(6, 46)
        Me.board4_Diode1_RadioButton2.Name = "board4_Diode1_RadioButton2"
        Me.board4_Diode1_RadioButton2.Size = New System.Drawing.Size(53, 22)
        Me.board4_Diode1_RadioButton2.TabIndex = 1
        Me.board4_Diode1_RadioButton2.UseVisualStyleBackColor = True
        '
        'board4_Diode1_RadioButton1
        '
        Me.board4_Diode1_RadioButton1.AutoSize = True
        Me.board4_Diode1_RadioButton1.Image = CType(resources.GetObject("board4_Diode1_RadioButton1.Image"), System.Drawing.Image)
        Me.board4_Diode1_RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.board4_Diode1_RadioButton1.Name = "board4_Diode1_RadioButton1"
        Me.board4_Diode1_RadioButton1.Size = New System.Drawing.Size(53, 22)
        Me.board4_Diode1_RadioButton1.TabIndex = 0
        Me.board4_Diode1_RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Precision Half-Wave Rectifier"
        '
        'lbl_board_4_status
        '
        Me.lbl_board_4_status.AutoSize = True
        Me.lbl_board_4_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_4_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_4_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_4_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_4_status.Name = "lbl_board_4_status"
        Me.lbl_board_4_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_4_status.TabIndex = 16
        Me.lbl_board_4_status.Text = "Inactive"
        '
        'board_4_R1
        '
        Me.board_4_R1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_4_R1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_4_R1.DropDownWidth = 60
        Me.board_4_R1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_4_R1.FormattingEnabled = True
        Me.board_4_R1.Items.AddRange(New Object() {"0.5 k", "1 k", "1.5 k ", "5 k"})
        Me.board_4_R1.Location = New System.Drawing.Point(264, 64)
        Me.board_4_R1.Name = "board_4_R1"
        Me.board_4_R1.Size = New System.Drawing.Size(54, 21)
        Me.board_4_R1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(842, 360)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Board3
        '
        Me.Board3.Controls.Add(Me.GroupBox3)
        Me.Board3.Controls.Add(Me.Label31)
        Me.Board3.Controls.Add(Me.lbl_board_3_status)
        Me.Board3.Controls.Add(Me.board_3_R3)
        Me.Board3.Controls.Add(Me.board_3_R2)
        Me.Board3.Controls.Add(Me.PictureBox6)
        Me.Board3.Location = New System.Drawing.Point(4, 22)
        Me.Board3.Name = "Board3"
        Me.Board3.Padding = New System.Windows.Forms.Padding(3)
        Me.Board3.Size = New System.Drawing.Size(903, 414)
        Me.Board3.TabIndex = 7
        Me.Board3.Text = "Experiment 3"
        Me.Board3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.board_3_multimeter_refresh)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.board_3_multimeter_output)
        Me.GroupBox3.Location = New System.Drawing.Point(586, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Multimeter Reading"
        '
        'board_3_multimeter_refresh
        '
        Me.board_3_multimeter_refresh.Location = New System.Drawing.Point(7, 62)
        Me.board_3_multimeter_refresh.Name = "board_3_multimeter_refresh"
        Me.board_3_multimeter_refresh.Size = New System.Drawing.Size(141, 23)
        Me.board_3_multimeter_refresh.TabIndex = 20
        Me.board_3_multimeter_refresh.Text = "Refresh Output"
        Me.board_3_multimeter_refresh.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "mA"
        '
        'board_3_multimeter_output
        '
        Me.board_3_multimeter_output.Location = New System.Drawing.Point(6, 34)
        Me.board_3_multimeter_output.Name = "board_3_multimeter_output"
        Me.board_3_multimeter_output.ReadOnly = True
        Me.board_3_multimeter_output.Size = New System.Drawing.Size(142, 21)
        Me.board_3_multimeter_output.TabIndex = 3
        Me.board_3_multimeter_output.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(271, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(238, 13)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "Current Mirror or Widlar Reducing Current Source"
        '
        'lbl_board_3_status
        '
        Me.lbl_board_3_status.AutoSize = True
        Me.lbl_board_3_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_3_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_3_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_3_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_3_status.Name = "lbl_board_3_status"
        Me.lbl_board_3_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_3_status.TabIndex = 16
        Me.lbl_board_3_status.Text = "Inactive"
        '
        'board_3_R3
        '
        Me.board_3_R3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_3_R3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_3_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_3_R3.FormattingEnabled = True
        Me.board_3_R3.Items.AddRange(New Object() {"short (for current mirror only)", "1 K", "5.1 K", "10 K", "20 K"})
        Me.board_3_R3.Location = New System.Drawing.Point(377, 320)
        Me.board_3_R3.Name = "board_3_R3"
        Me.board_3_R3.Size = New System.Drawing.Size(166, 21)
        Me.board_3_R3.TabIndex = 4
        '
        'board_3_R2
        '
        Me.board_3_R2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_3_R2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_3_R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_3_R2.FormattingEnabled = True
        Me.board_3_R2.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_3_R2.Location = New System.Drawing.Point(377, 151)
        Me.board_3_R2.Name = "board_3_R2"
        Me.board_3_R2.Size = New System.Drawing.Size(54, 21)
        Me.board_3_R2.TabIndex = 6
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(81, 54)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(482, 348)
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'Board_2
        '
        Me.Board_2.Controls.Add(Me.lbl_board_2)
        Me.Board_2.Controls.Add(Me.lbl_board_2_status)
        Me.Board_2.Controls.Add(Me.board_2_Circuit_Control)
        Me.Board_2.Controls.Add(Me.board_2_lbl_C1)
        Me.Board_2.Controls.Add(Me.board_2_C1)
        Me.Board_2.Controls.Add(Me.board_2_R4)
        Me.Board_2.Controls.Add(Me.board_2_lbl_C2)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R4)
        Me.Board_2.Controls.Add(Me.board_2_C2)
        Me.Board_2.Controls.Add(Me.board_2_R3)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R2)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R3)
        Me.Board_2.Controls.Add(Me.board_2_R2)
        Me.Board_2.Controls.Add(Me.board_2_R1)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R1)
        Me.Board_2.Controls.Add(Me.board_2_chematic)
        Me.Board_2.Location = New System.Drawing.Point(4, 22)
        Me.Board_2.Name = "Board_2"
        Me.Board_2.Padding = New System.Windows.Forms.Padding(3)
        Me.Board_2.Size = New System.Drawing.Size(903, 414)
        Me.Board_2.TabIndex = 1
        Me.Board_2.Text = "Experiment 2"
        Me.Board_2.UseVisualStyleBackColor = True
        '
        'lbl_board_2
        '
        Me.lbl_board_2.AutoSize = True
        Me.lbl_board_2.Location = New System.Drawing.Point(271, 17)
        Me.lbl_board_2.Name = "lbl_board_2"
        Me.lbl_board_2.Size = New System.Drawing.Size(94, 13)
        Me.lbl_board_2.TabIndex = 17
        Me.lbl_board_2.Text = "[ Sallen Key Filter ]"
        '
        'lbl_board_2_status
        '
        Me.lbl_board_2_status.AutoSize = True
        Me.lbl_board_2_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_2_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_2_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_2_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_2_status.Name = "lbl_board_2_status"
        Me.lbl_board_2_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_2_status.TabIndex = 16
        Me.lbl_board_2_status.Text = "Inactive"
        '
        'board_2_Circuit_Control
        '
        Me.board_2_Circuit_Control.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.board_2_Circuit_Control.Controls.Add(Me.board_2_ch2)
        Me.board_2_Circuit_Control.Controls.Add(Me.board_2_Ch_1)
        Me.board_2_Circuit_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_Circuit_Control.Location = New System.Drawing.Point(540, 44)
        Me.board_2_Circuit_Control.Name = "board_2_Circuit_Control"
        Me.board_2_Circuit_Control.Size = New System.Drawing.Size(200, 340)
        Me.board_2_Circuit_Control.TabIndex = 2
        Me.board_2_Circuit_Control.TabStop = False
        Me.board_2_Circuit_Control.Text = "Circuit Controls"
        '
        'board_2_ch2
        '
        Me.board_2_ch2.Controls.Add(Me.board_2_lbl6)
        Me.board_2_ch2.Controls.Add(Me.board_2_scope_ch_2_gain)
        Me.board_2_ch2.Controls.Add(Me.board_2_lbl5)
        Me.board_2_ch2.Controls.Add(Me.board_2_lbl4)
        Me.board_2_ch2.Location = New System.Drawing.Point(19, 205)
        Me.board_2_ch2.Name = "board_2_ch2"
        Me.board_2_ch2.Size = New System.Drawing.Size(162, 124)
        Me.board_2_ch2.TabIndex = 5
        Me.board_2_ch2.TabStop = False
        Me.board_2_ch2.Text = "Scope Channel 2"
        '
        'board_2_lbl6
        '
        Me.board_2_lbl6.AutoSize = True
        Me.board_2_lbl6.Location = New System.Drawing.Point(6, 98)
        Me.board_2_lbl6.Name = "board_2_lbl6"
        Me.board_2_lbl6.Size = New System.Drawing.Size(119, 13)
        Me.board_2_lbl6.TabIndex = 6
        Me.board_2_lbl6.Text = "Match Gain in Vellemen"
        '
        'board_2_scope_ch_2_gain
        '
        Me.board_2_scope_ch_2_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.board_2_scope_ch_2_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_scope_ch_2_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_scope_ch_2_gain.FormattingEnabled = True
        Me.board_2_scope_ch_2_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.board_2_scope_ch_2_gain.Location = New System.Drawing.Point(8, 69)
        Me.board_2_scope_ch_2_gain.Name = "board_2_scope_ch_2_gain"
        Me.board_2_scope_ch_2_gain.Size = New System.Drawing.Size(104, 21)
        Me.board_2_scope_ch_2_gain.TabIndex = 5
        '
        'board_2_lbl5
        '
        Me.board_2_lbl5.AutoSize = True
        Me.board_2_lbl5.Location = New System.Drawing.Point(6, 53)
        Me.board_2_lbl5.Name = "board_2_lbl5"
        Me.board_2_lbl5.Size = New System.Drawing.Size(51, 13)
        Me.board_2_lbl5.TabIndex = 4
        Me.board_2_lbl5.Text = "Ch2 Gain"
        '
        'board_2_lbl4
        '
        Me.board_2_lbl4.AutoSize = True
        Me.board_2_lbl4.Location = New System.Drawing.Point(3, 27)
        Me.board_2_lbl4.Name = "board_2_lbl4"
        Me.board_2_lbl4.Size = New System.Drawing.Size(142, 13)
        Me.board_2_lbl4.TabIndex = 3
        Me.board_2_lbl4.Text = "Oscilloscope Position: (OUT)"
        '
        'board_2_Ch_1
        '
        Me.board_2_Ch_1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.board_2_Ch_1.Controls.Add(Me.board_2_lbl3)
        Me.board_2_Ch_1.Controls.Add(Me.board_2_scope_ch_1_gain)
        Me.board_2_Ch_1.Controls.Add(Me.board_2_lbl_2)
        Me.board_2_Ch_1.Controls.Add(Me.board_2_lbl1)
        Me.board_2_Ch_1.Location = New System.Drawing.Point(19, 36)
        Me.board_2_Ch_1.Name = "board_2_Ch_1"
        Me.board_2_Ch_1.Size = New System.Drawing.Size(162, 123)
        Me.board_2_Ch_1.TabIndex = 4
        Me.board_2_Ch_1.TabStop = False
        Me.board_2_Ch_1.Text = "Scope Channel 1"
        '
        'board_2_lbl3
        '
        Me.board_2_lbl3.AutoSize = True
        Me.board_2_lbl3.Location = New System.Drawing.Point(5, 97)
        Me.board_2_lbl3.Name = "board_2_lbl3"
        Me.board_2_lbl3.Size = New System.Drawing.Size(119, 13)
        Me.board_2_lbl3.TabIndex = 4
        Me.board_2_lbl3.Text = "Match Gain in Vellemen"
        '
        'board_2_scope_ch_1_gain
        '
        Me.board_2_scope_ch_1_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.board_2_scope_ch_1_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_scope_ch_1_gain.FormattingEnabled = True
        Me.board_2_scope_ch_1_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.board_2_scope_ch_1_gain.Location = New System.Drawing.Point(8, 71)
        Me.board_2_scope_ch_1_gain.Name = "board_2_scope_ch_1_gain"
        Me.board_2_scope_ch_1_gain.Size = New System.Drawing.Size(104, 21)
        Me.board_2_scope_ch_1_gain.TabIndex = 3
        '
        'board_2_lbl_2
        '
        Me.board_2_lbl_2.AutoSize = True
        Me.board_2_lbl_2.Location = New System.Drawing.Point(6, 54)
        Me.board_2_lbl_2.Name = "board_2_lbl_2"
        Me.board_2_lbl_2.Size = New System.Drawing.Size(51, 13)
        Me.board_2_lbl_2.TabIndex = 2
        Me.board_2_lbl_2.Text = "Ch1 Gain"
        '
        'board_2_lbl1
        '
        Me.board_2_lbl1.AutoSize = True
        Me.board_2_lbl1.Location = New System.Drawing.Point(6, 27)
        Me.board_2_lbl1.Name = "board_2_lbl1"
        Me.board_2_lbl1.Size = New System.Drawing.Size(130, 13)
        Me.board_2_lbl1.TabIndex = 0
        Me.board_2_lbl1.Text = "Oscilloscope Position: (IN)"
        '
        'board_2_lbl_C1
        '
        Me.board_2_lbl_C1.AutoSize = True
        Me.board_2_lbl_C1.Location = New System.Drawing.Point(177, 155)
        Me.board_2_lbl_C1.Name = "board_2_lbl_C1"
        Me.board_2_lbl_C1.Size = New System.Drawing.Size(20, 13)
        Me.board_2_lbl_C1.TabIndex = 15
        Me.board_2_lbl_C1.Text = "C1"
        '
        'board_2_C1
        '
        Me.board_2_C1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_C1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_C1.FormattingEnabled = True
        Me.board_2_C1.Items.AddRange(New Object() {"0.01 uF", "0.1   uF", "0.22 uF"})
        Me.board_2_C1.Location = New System.Drawing.Point(139, 171)
        Me.board_2_C1.Name = "board_2_C1"
        Me.board_2_C1.Size = New System.Drawing.Size(58, 21)
        Me.board_2_C1.TabIndex = 14
        '
        'board_2_R4
        '
        Me.board_2_R4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_R4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_R4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_R4.FormattingEnabled = True
        Me.board_2_R4.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_2_R4.Location = New System.Drawing.Point(349, 196)
        Me.board_2_R4.Name = "board_2_R4"
        Me.board_2_R4.Size = New System.Drawing.Size(54, 21)
        Me.board_2_R4.TabIndex = 4
        '
        'board_2_lbl_C2
        '
        Me.board_2_lbl_C2.AutoSize = True
        Me.board_2_lbl_C2.Location = New System.Drawing.Point(205, 73)
        Me.board_2_lbl_C2.Name = "board_2_lbl_C2"
        Me.board_2_lbl_C2.Size = New System.Drawing.Size(20, 13)
        Me.board_2_lbl_C2.TabIndex = 13
        Me.board_2_lbl_C2.Text = "C2"
        '
        'board_2_lbl_R4
        '
        Me.board_2_lbl_R4.AutoSize = True
        Me.board_2_lbl_R4.Location = New System.Drawing.Point(363, 179)
        Me.board_2_lbl_R4.Name = "board_2_lbl_R4"
        Me.board_2_lbl_R4.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R4.TabIndex = 5
        Me.board_2_lbl_R4.Text = "R4"
        '
        'board_2_C2
        '
        Me.board_2_C2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_C2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_C2.FormattingEnabled = True
        Me.board_2_C2.Items.AddRange(New Object() {"0.01 uF", "0.1   uF", "0.22 uF"})
        Me.board_2_C2.Location = New System.Drawing.Point(229, 58)
        Me.board_2_C2.Name = "board_2_C2"
        Me.board_2_C2.Size = New System.Drawing.Size(65, 21)
        Me.board_2_C2.TabIndex = 12
        '
        'board_2_R3
        '
        Me.board_2_R3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_R3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_R3.FormattingEnabled = True
        Me.board_2_R3.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_2_R3.Location = New System.Drawing.Point(258, 196)
        Me.board_2_R3.Name = "board_2_R3"
        Me.board_2_R3.Size = New System.Drawing.Size(54, 21)
        Me.board_2_R3.TabIndex = 6
        '
        'board_2_lbl_R2
        '
        Me.board_2_lbl_R2.AutoSize = True
        Me.board_2_lbl_R2.Location = New System.Drawing.Point(124, 106)
        Me.board_2_lbl_R2.Name = "board_2_lbl_R2"
        Me.board_2_lbl_R2.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R2.TabIndex = 11
        Me.board_2_lbl_R2.Text = "R2"
        '
        'board_2_lbl_R3
        '
        Me.board_2_lbl_R3.AutoSize = True
        Me.board_2_lbl_R3.Location = New System.Drawing.Point(273, 181)
        Me.board_2_lbl_R3.Name = "board_2_lbl_R3"
        Me.board_2_lbl_R3.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R3.TabIndex = 7
        Me.board_2_lbl_R3.Text = "R3"
        '
        'board_2_R2
        '
        Me.board_2_R2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_R2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_R2.FormattingEnabled = True
        Me.board_2_R2.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_2_R2.Location = New System.Drawing.Point(108, 122)
        Me.board_2_R2.Name = "board_2_R2"
        Me.board_2_R2.Size = New System.Drawing.Size(54, 21)
        Me.board_2_R2.TabIndex = 10
        '
        'board_2_R1
        '
        Me.board_2_R1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_R1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_R1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_R1.FormattingEnabled = True
        Me.board_2_R1.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_2_R1.Location = New System.Drawing.Point(26, 122)
        Me.board_2_R1.Name = "board_2_R1"
        Me.board_2_R1.Size = New System.Drawing.Size(54, 21)
        Me.board_2_R1.TabIndex = 8
        '
        'board_2_lbl_R1
        '
        Me.board_2_lbl_R1.AutoSize = True
        Me.board_2_lbl_R1.Location = New System.Drawing.Point(42, 106)
        Me.board_2_lbl_R1.Name = "board_2_lbl_R1"
        Me.board_2_lbl_R1.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R1.TabIndex = 9
        Me.board_2_lbl_R1.Text = "R1"
        '
        'board_2_chematic
        '
        Me.board_2_chematic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.board_2_chematic.Image = CType(resources.GetObject("board_2_chematic.Image"), System.Drawing.Image)
        Me.board_2_chematic.Location = New System.Drawing.Point(3, 44)
        Me.board_2_chematic.Name = "board_2_chematic"
        Me.board_2_chematic.Size = New System.Drawing.Size(462, 340)
        Me.board_2_chematic.TabIndex = 3
        Me.board_2_chematic.TabStop = False
        '
        'Board_1
        '
        Me.Board_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Board_1.Controls.Add(Me.lbl_board_1_status)
        Me.Board_1.Controls.Add(Me.Circuit_Controls)
        Me.Board_1.Controls.Add(Me.lbl5k_1)
        Me.Board_1.Controls.Add(Me.lbl_board_1)
        Me.Board_1.Controls.Add(Me.lbl_5k)
        Me.Board_1.Controls.Add(Me.lbl_1k)
        Me.Board_1.Controls.Add(Me.Brd_1_Res_Select)
        Me.Board_1.Controls.Add(Me.Lbl_19k)
        Me.Board_1.Controls.Add(Me.lbl_A)
        Me.Board_1.Controls.Add(Me.board_1_R3_enable)
        Me.Board_1.Controls.Add(Me.lbl_B)
        Me.Board_1.Controls.Add(Me.lbl_D)
        Me.Board_1.Controls.Add(Me.lbl_C)
        Me.Board_1.Controls.Add(Me.Board_1_Image)
        Me.Board_1.Location = New System.Drawing.Point(4, 22)
        Me.Board_1.Name = "Board_1"
        Me.Board_1.Padding = New System.Windows.Forms.Padding(3)
        Me.Board_1.Size = New System.Drawing.Size(903, 414)
        Me.Board_1.TabIndex = 0
        Me.Board_1.Text = "Experiment 1"
        '
        'lbl_board_1_status
        '
        Me.lbl_board_1_status.AutoSize = True
        Me.lbl_board_1_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_1_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_1_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_1_status.Location = New System.Drawing.Point(11, 22)
        Me.lbl_board_1_status.Name = "lbl_board_1_status"
        Me.lbl_board_1_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_1_status.TabIndex = 12
        Me.lbl_board_1_status.Text = "Inactive"
        '
        'Circuit_Controls
        '
        Me.Circuit_Controls.Controls.Add(Me.brd_1_ch2)
        Me.Circuit_Controls.Controls.Add(Me.brd_1_ch1)
        Me.Circuit_Controls.Location = New System.Drawing.Point(540, 40)
        Me.Circuit_Controls.Name = "Circuit_Controls"
        Me.Circuit_Controls.Size = New System.Drawing.Size(200, 359)
        Me.Circuit_Controls.TabIndex = 2
        Me.Circuit_Controls.TabStop = False
        Me.Circuit_Controls.Text = "Circuit Controls"
        '
        'brd_1_ch2
        '
        Me.brd_1_ch2.Controls.Add(Me.board_1_lbl_2)
        Me.brd_1_ch2.Controls.Add(Me.brd_1_ch_2_gain)
        Me.brd_1_ch2.Controls.Add(Me.lbl_gain_2)
        Me.brd_1_ch2.Controls.Add(Me.Brd_1_Scope_Ch2)
        Me.brd_1_ch2.Controls.Add(Me.lbl_Scope_1)
        Me.brd_1_ch2.Location = New System.Drawing.Point(19, 205)
        Me.brd_1_ch2.Name = "brd_1_ch2"
        Me.brd_1_ch2.Size = New System.Drawing.Size(162, 139)
        Me.brd_1_ch2.TabIndex = 5
        Me.brd_1_ch2.TabStop = False
        Me.brd_1_ch2.Text = "Scope Channel 2"
        '
        'board_1_lbl_2
        '
        Me.board_1_lbl_2.AutoSize = True
        Me.board_1_lbl_2.Location = New System.Drawing.Point(6, 109)
        Me.board_1_lbl_2.Name = "board_1_lbl_2"
        Me.board_1_lbl_2.Size = New System.Drawing.Size(119, 13)
        Me.board_1_lbl_2.TabIndex = 6
        Me.board_1_lbl_2.Text = "Match Gain in Vellemen"
        '
        'brd_1_ch_2_gain
        '
        Me.brd_1_ch_2_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.brd_1_ch_2_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brd_1_ch_2_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brd_1_ch_2_gain.FormattingEnabled = True
        Me.brd_1_ch_2_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.brd_1_ch_2_gain.Location = New System.Drawing.Point(6, 85)
        Me.brd_1_ch_2_gain.Name = "brd_1_ch_2_gain"
        Me.brd_1_ch_2_gain.Size = New System.Drawing.Size(104, 21)
        Me.brd_1_ch_2_gain.TabIndex = 5
        '
        'lbl_gain_2
        '
        Me.lbl_gain_2.AutoSize = True
        Me.lbl_gain_2.Location = New System.Drawing.Point(6, 67)
        Me.lbl_gain_2.Name = "lbl_gain_2"
        Me.lbl_gain_2.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gain_2.TabIndex = 4
        Me.lbl_gain_2.Text = "Ch2 Gain"
        '
        'Brd_1_Scope_Ch2
        '
        Me.Brd_1_Scope_Ch2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Brd_1_Scope_Ch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Brd_1_Scope_Ch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brd_1_Scope_Ch2.FormattingEnabled = True
        Me.Brd_1_Scope_Ch2.Items.AddRange(New Object() {"(A)", "(B)", "(C)", "(D)"})
        Me.Brd_1_Scope_Ch2.Location = New System.Drawing.Point(6, 43)
        Me.Brd_1_Scope_Ch2.Name = "Brd_1_Scope_Ch2"
        Me.Brd_1_Scope_Ch2.Size = New System.Drawing.Size(104, 21)
        Me.Brd_1_Scope_Ch2.TabIndex = 2
        '
        'lbl_Scope_1
        '
        Me.lbl_Scope_1.AutoSize = True
        Me.lbl_Scope_1.Location = New System.Drawing.Point(3, 27)
        Me.lbl_Scope_1.Name = "lbl_Scope_1"
        Me.lbl_Scope_1.Size = New System.Drawing.Size(107, 13)
        Me.lbl_Scope_1.TabIndex = 3
        Me.lbl_Scope_1.Text = "Oscilloscope Position"
        '
        'brd_1_ch1
        '
        Me.brd_1_ch1.Controls.Add(Me.board_1_lbl_1)
        Me.brd_1_ch1.Controls.Add(Me.brd_1_ch1_gain)
        Me.brd_1_ch1.Controls.Add(Me.lbl_gain_1)
        Me.brd_1_ch1.Controls.Add(Me.lbl_scope)
        Me.brd_1_ch1.Controls.Add(Me.Brd_1_Scope)
        Me.brd_1_ch1.Location = New System.Drawing.Point(19, 36)
        Me.brd_1_ch1.Name = "brd_1_ch1"
        Me.brd_1_ch1.Size = New System.Drawing.Size(162, 135)
        Me.brd_1_ch1.TabIndex = 4
        Me.brd_1_ch1.TabStop = False
        Me.brd_1_ch1.Text = "Scope Channel 1"
        '
        'board_1_lbl_1
        '
        Me.board_1_lbl_1.AutoSize = True
        Me.board_1_lbl_1.Location = New System.Drawing.Point(6, 108)
        Me.board_1_lbl_1.Name = "board_1_lbl_1"
        Me.board_1_lbl_1.Size = New System.Drawing.Size(119, 13)
        Me.board_1_lbl_1.TabIndex = 4
        Me.board_1_lbl_1.Text = "Match Gain in Vellemen"
        '
        'brd_1_ch1_gain
        '
        Me.brd_1_ch1_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.brd_1_ch1_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brd_1_ch1_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brd_1_ch1_gain.FormattingEnabled = True
        Me.brd_1_ch1_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.brd_1_ch1_gain.Location = New System.Drawing.Point(9, 84)
        Me.brd_1_ch1_gain.Name = "brd_1_ch1_gain"
        Me.brd_1_ch1_gain.Size = New System.Drawing.Size(104, 21)
        Me.brd_1_ch1_gain.TabIndex = 3
        '
        'lbl_gain_1
        '
        Me.lbl_gain_1.AutoSize = True
        Me.lbl_gain_1.Location = New System.Drawing.Point(6, 68)
        Me.lbl_gain_1.Name = "lbl_gain_1"
        Me.lbl_gain_1.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gain_1.TabIndex = 2
        Me.lbl_gain_1.Text = "Ch1 Gain"
        '
        'lbl_scope
        '
        Me.lbl_scope.AutoSize = True
        Me.lbl_scope.Location = New System.Drawing.Point(6, 27)
        Me.lbl_scope.Name = "lbl_scope"
        Me.lbl_scope.Size = New System.Drawing.Size(107, 13)
        Me.lbl_scope.TabIndex = 0
        Me.lbl_scope.Text = "Oscilloscope Position"
        '
        'Brd_1_Scope
        '
        Me.Brd_1_Scope.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Brd_1_Scope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Brd_1_Scope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brd_1_Scope.FormattingEnabled = True
        Me.Brd_1_Scope.Items.AddRange(New Object() {"(A)", "(B)", "(C)", "(D)"})
        Me.Brd_1_Scope.Location = New System.Drawing.Point(9, 43)
        Me.Brd_1_Scope.Name = "Brd_1_Scope"
        Me.Brd_1_Scope.Size = New System.Drawing.Size(104, 21)
        Me.Brd_1_Scope.TabIndex = 1
        '
        'lbl5k_1
        '
        Me.lbl5k_1.AutoSize = True
        Me.lbl5k_1.Location = New System.Drawing.Point(288, 181)
        Me.lbl5k_1.Name = "lbl5k_1"
        Me.lbl5k_1.Size = New System.Drawing.Size(22, 13)
        Me.lbl5k_1.TabIndex = 11
        Me.lbl5k_1.Text = "5 k"
        '
        'lbl_board_1
        '
        Me.lbl_board_1.AutoSize = True
        Me.lbl_board_1.Location = New System.Drawing.Point(275, 14)
        Me.lbl_board_1.Name = "lbl_board_1"
        Me.lbl_board_1.Size = New System.Drawing.Size(113, 13)
        Me.lbl_board_1.TabIndex = 0
        Me.lbl_board_1.Text = "[ Two Stage Amplifier ]"
        '
        'lbl_5k
        '
        Me.lbl_5k.AutoSize = True
        Me.lbl_5k.Location = New System.Drawing.Point(237, 109)
        Me.lbl_5k.Name = "lbl_5k"
        Me.lbl_5k.Size = New System.Drawing.Size(22, 13)
        Me.lbl_5k.TabIndex = 10
        Me.lbl_5k.Text = "5 k"
        '
        'lbl_1k
        '
        Me.lbl_1k.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_1k.AutoSize = True
        Me.lbl_1k.Location = New System.Drawing.Point(54, 195)
        Me.lbl_1k.Name = "lbl_1k"
        Me.lbl_1k.Size = New System.Drawing.Size(22, 13)
        Me.lbl_1k.TabIndex = 9
        Me.lbl_1k.Text = "1 k"
        '
        'Brd_1_Res_Select
        '
        Me.Brd_1_Res_Select.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Brd_1_Res_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Brd_1_Res_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brd_1_Res_Select.FormattingEnabled = True
        Me.Brd_1_Res_Select.Items.AddRange(New Object() {"1 K", "2 K", "3 K", "4 K", "5 K", "6 K", "7 K", "8 K", "9 K", "10 K", "short"})
        Me.Brd_1_Res_Select.Location = New System.Drawing.Point(287, 76)
        Me.Brd_1_Res_Select.Name = "Brd_1_Res_Select"
        Me.Brd_1_Res_Select.Size = New System.Drawing.Size(64, 21)
        Me.Brd_1_Res_Select.TabIndex = 1
        '
        'Lbl_19k
        '
        Me.Lbl_19k.AutoSize = True
        Me.Lbl_19k.Location = New System.Drawing.Point(108, 184)
        Me.Lbl_19k.Name = "Lbl_19k"
        Me.Lbl_19k.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_19k.TabIndex = 8
        Me.Lbl_19k.Text = "19 k"
        '
        'lbl_A
        '
        Me.lbl_A.AutoSize = True
        Me.lbl_A.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_A.Location = New System.Drawing.Point(63, 109)
        Me.lbl_A.Name = "lbl_A"
        Me.lbl_A.Size = New System.Drawing.Size(20, 13)
        Me.lbl_A.TabIndex = 3
        Me.lbl_A.Text = "(A)"
        '
        'board_1_R3_enable
        '
        Me.board_1_R3_enable.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_1_R3_enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_1_R3_enable.Enabled = False
        Me.board_1_R3_enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_1_R3_enable.FormattingEnabled = True
        Me.board_1_R3_enable.Items.AddRange(New Object() {"5 k", "Open"})
        Me.board_1_R3_enable.Location = New System.Drawing.Point(219, 135)
        Me.board_1_R3_enable.Name = "board_1_R3_enable"
        Me.board_1_R3_enable.Size = New System.Drawing.Size(52, 21)
        Me.board_1_R3_enable.TabIndex = 7
        '
        'lbl_B
        '
        Me.lbl_B.AutoSize = True
        Me.lbl_B.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_B.Location = New System.Drawing.Point(171, 119)
        Me.lbl_B.Name = "lbl_B"
        Me.lbl_B.Size = New System.Drawing.Size(20, 13)
        Me.lbl_B.TabIndex = 4
        Me.lbl_B.Text = "(B)"
        '
        'lbl_D
        '
        Me.lbl_D.AutoSize = True
        Me.lbl_D.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_D.Location = New System.Drawing.Point(402, 143)
        Me.lbl_D.Name = "lbl_D"
        Me.lbl_D.Size = New System.Drawing.Size(21, 13)
        Me.lbl_D.TabIndex = 6
        Me.lbl_D.Text = "(D)"
        '
        'lbl_C
        '
        Me.lbl_C.AutoSize = True
        Me.lbl_C.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_C.Location = New System.Drawing.Point(284, 160)
        Me.lbl_C.Name = "lbl_C"
        Me.lbl_C.Size = New System.Drawing.Size(20, 13)
        Me.lbl_C.TabIndex = 5
        Me.lbl_C.Text = "(C)"
        '
        'Board_1_Image
        '
        Me.Board_1_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Board_1_Image.Image = CType(resources.GetObject("Board_1_Image.Image"), System.Drawing.Image)
        Me.Board_1_Image.Location = New System.Drawing.Point(11, 40)
        Me.Board_1_Image.Name = "Board_1_Image"
        Me.Board_1_Image.Size = New System.Drawing.Size(450, 359)
        Me.Board_1_Image.TabIndex = 0
        Me.Board_1_Image.TabStop = False
        '
        'Setup
        '
        Me.Setup.Controls.Add(Me.Board_1)
        Me.Setup.Controls.Add(Me.Board_2)
        Me.Setup.Controls.Add(Me.Board3)
        Me.Setup.Controls.Add(Me.Board4)
        Me.Setup.Controls.Add(Me.Board5)
        Me.Setup.Controls.Add(Me.Board6)
        Me.Setup.Controls.Add(Me.Board7)
        Me.Setup.Controls.Add(Me.TabPageSetup)
        Me.Setup.Location = New System.Drawing.Point(21, 83)
        Me.Setup.Name = "Setup"
        Me.Setup.SelectedIndex = 0
        Me.Setup.Size = New System.Drawing.Size(911, 440)
        Me.Setup.TabIndex = 5
        '
        'TabPageSetup
        '
        Me.TabPageSetup.Controls.Add(Me.Label3)
        Me.TabPageSetup.Controls.Add(Me.GroupBox1)
        Me.TabPageSetup.Controls.Add(Me.Label2)
        Me.TabPageSetup.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSetup.Name = "TabPageSetup"
        Me.TabPageSetup.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSetup.Size = New System.Drawing.Size(903, 414)
        Me.TabPageSetup.TabIndex = 8
        Me.TabPageSetup.Text = "Setup"
        Me.TabPageSetup.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(533, 234)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComPortTextBox)
        Me.GroupBox1.Controls.Add(Me.SubmitButton)
        Me.GroupBox1.Location = New System.Drawing.Point(173, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 78)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter COM Port Name"
        '
        'ComPortTextBox
        '
        Me.ComPortTextBox.Location = New System.Drawing.Point(127, 32)
        Me.ComPortTextBox.Name = "ComPortTextBox"
        Me.ComPortTextBox.Size = New System.Drawing.Size(361, 23)
        Me.ComPortTextBox.TabIndex = 3
        Me.ComPortTextBox.Text = ""
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 32)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(97, 23)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Setup for Remote Lab System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(939, 535)
        Me.Controls.Add(Me.Setup)
        Me.Controls.Add(Me.CommControlGroup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Remote EE Lab"
        Me.CommControlGroup.ResumeLayout(False)
        Me.CommControlGroup.PerformLayout()
        Me.Board7.ResumeLayout(False)
        Me.Board7.PerformLayout()
        Me.ClockBox.ResumeLayout(False)
        Me.ClockBox.PerformLayout()
        Me.XOR1.ResumeLayout(False)
        Me.XOR1.PerformLayout()
        Me.XOR2.ResumeLayout(False)
        Me.XOR2.PerformLayout()
        Me.XOR3.ResumeLayout(False)
        Me.XOR3.PerformLayout()
        Me.XOR4.ResumeLayout(False)
        Me.XOR4.PerformLayout()
        Me.XOR5.ResumeLayout(False)
        Me.XOR5.PerformLayout()
        Me.XOR6.ResumeLayout(False)
        Me.XOR6.PerformLayout()
        Me.XOR7.ResumeLayout(False)
        Me.XOR7.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board6.ResumeLayout(False)
        Me.Board6.PerformLayout()
        Me.ResetZ80.ResumeLayout(False)
        Me.SelectProgram.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board5.ResumeLayout(False)
        Me.Board5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board4.ResumeLayout(False)
        Me.Board4.PerformLayout()
        Me.Diode2.ResumeLayout(False)
        Me.Diode2.PerformLayout()
        Me.Diode1.ResumeLayout(False)
        Me.Diode1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board3.ResumeLayout(False)
        Me.Board3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board_2.ResumeLayout(False)
        Me.Board_2.PerformLayout()
        Me.board_2_Circuit_Control.ResumeLayout(False)
        Me.board_2_ch2.ResumeLayout(False)
        Me.board_2_ch2.PerformLayout()
        Me.board_2_Ch_1.ResumeLayout(False)
        Me.board_2_Ch_1.PerformLayout()
        CType(Me.board_2_chematic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board_1.ResumeLayout(False)
        Me.Board_1.PerformLayout()
        Me.Circuit_Controls.ResumeLayout(False)
        Me.brd_1_ch2.ResumeLayout(False)
        Me.brd_1_ch2.PerformLayout()
        Me.brd_1_ch1.ResumeLayout(False)
        Me.brd_1_ch1.PerformLayout()
        CType(Me.Board_1_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Setup.ResumeLayout(False)
        Me.TabPageSetup.ResumeLayout(False)
        Me.TabPageSetup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents board_detect As System.Windows.Forms.Button
    Friend WithEvents CommControlGroup As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Send_Config As System.Windows.Forms.Button
    Friend WithEvents Serial_Text_Test As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btn_Dev_Test As System.Windows.Forms.Button
    Friend WithEvents btn_test_2 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents lbl_serial As System.Windows.Forms.Label
    Friend WithEvents Board7 As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_board_7_status As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Board6 As TabPage
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_board_6_status As Label
    Friend WithEvents ProgramSelector As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Board5 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_board_5_status As Label
    Friend WithEvents board_5_R3 As ComboBox
    Friend WithEvents board_5_R2 As ComboBox
    Friend WithEvents board_5_C1 As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Board4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_board_4_status As Label
    Friend WithEvents board_4_R1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Board3 As TabPage
    Friend WithEvents Label31 As Label
    Friend WithEvents lbl_board_3_status As Label
    Friend WithEvents board_3_R3 As ComboBox
    Friend WithEvents board_3_R2 As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Board_2 As TabPage
    Friend WithEvents lbl_board_2 As Label
    Friend WithEvents lbl_board_2_status As Label
    Friend WithEvents board_2_Circuit_Control As GroupBox
    Friend WithEvents board_2_ch2 As GroupBox
    Friend WithEvents board_2_lbl6 As Label
    Friend WithEvents board_2_scope_ch_2_gain As ComboBox
    Friend WithEvents board_2_lbl5 As Label
    Friend WithEvents board_2_lbl4 As Label
    Friend WithEvents board_2_Ch_1 As GroupBox
    Friend WithEvents board_2_lbl3 As Label
    Friend WithEvents board_2_scope_ch_1_gain As ComboBox
    Friend WithEvents board_2_lbl_2 As Label
    Friend WithEvents board_2_lbl1 As Label
    Friend WithEvents board_2_lbl_C1 As Label
    Friend WithEvents board_2_C1 As ComboBox
    Friend WithEvents board_2_R4 As ComboBox
    Friend WithEvents board_2_lbl_C2 As Label
    Friend WithEvents board_2_lbl_R4 As Label
    Friend WithEvents board_2_C2 As ComboBox
    Friend WithEvents board_2_R3 As ComboBox
    Friend WithEvents board_2_lbl_R2 As Label
    Friend WithEvents board_2_lbl_R3 As Label
    Friend WithEvents board_2_R2 As ComboBox
    Friend WithEvents board_2_R1 As ComboBox
    Friend WithEvents board_2_lbl_R1 As Label
    Friend WithEvents board_2_chematic As PictureBox
    Friend WithEvents Board_1 As TabPage
    Friend WithEvents lbl_board_1_status As Label
    Friend WithEvents Circuit_Controls As GroupBox
    Friend WithEvents brd_1_ch2 As GroupBox
    Friend WithEvents board_1_lbl_2 As Label
    Friend WithEvents brd_1_ch_2_gain As ComboBox
    Friend WithEvents lbl_gain_2 As Label
    Friend WithEvents Brd_1_Scope_Ch2 As ComboBox
    Friend WithEvents lbl_Scope_1 As Label
    Friend WithEvents brd_1_ch1 As GroupBox
    Friend WithEvents board_1_lbl_1 As Label
    Friend WithEvents brd_1_ch1_gain As ComboBox
    Friend WithEvents lbl_gain_1 As Label
    Friend WithEvents lbl_scope As Label
    Friend WithEvents Brd_1_Scope As ComboBox
    Friend WithEvents lbl5k_1 As Label
    Friend WithEvents lbl_board_1 As Label
    Friend WithEvents lbl_5k As Label
    Friend WithEvents lbl_1k As Label
    Friend WithEvents Brd_1_Res_Select As ComboBox
    Friend WithEvents Lbl_19k As Label
    Friend WithEvents lbl_A As Label
    Friend WithEvents board_1_R3_enable As ComboBox
    Friend WithEvents lbl_B As Label
    Friend WithEvents lbl_D As Label
    Friend WithEvents lbl_C As Label
    Friend WithEvents Board_1_Image As PictureBox
    Friend WithEvents Setup As TabControl
    Friend WithEvents Diode2 As GroupBox
    Friend WithEvents board4_Diode2_RadioButton2 As RadioButton
    Friend WithEvents board4_Diode2_RadioButton1 As RadioButton
    Friend WithEvents Diode1 As GroupBox
    Friend WithEvents board4_Diode1_RadioButton2 As RadioButton
    Friend WithEvents board4_Diode1_RadioButton1 As RadioButton
    Friend WithEvents SelectProgram As GroupBox
    Friend WithEvents PresetD1 As ComboBox
    Friend WithEvents PresetD2 As ComboBox
    Friend WithEvents PresetD3 As ComboBox
    Friend WithEvents PresetD4 As ComboBox
    Friend WithEvents PresetD5 As ComboBox
    Friend WithEvents PresetD6 As ComboBox
    Friend WithEvents PresetD7 As ComboBox
    Friend WithEvents PresetD8 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents board_3_multimeter_refresh As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents board_3_multimeter_output As RichTextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.Board7.AutoScroll = True

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents ResetZ80 As GroupBox
    Friend WithEvents ResetZ80_Button As Button
    Friend WithEvents BypassXOR7 As RadioButton
    Friend WithEvents ConnectXOR7 As RadioButton
    Friend WithEvents XOR7 As GroupBox
    Friend WithEvents XOR1 As GroupBox
    Friend WithEvents ConnectXOR1 As RadioButton
    Friend WithEvents BypassXOR1 As RadioButton
    Friend WithEvents XOR2 As GroupBox
    Friend WithEvents ConnectXOR2 As RadioButton
    Friend WithEvents BypassXOR2 As RadioButton
    Friend WithEvents XOR3 As GroupBox
    Friend WithEvents ConnectXOR3 As RadioButton
    Friend WithEvents BypassXOR3 As RadioButton
    Friend WithEvents XOR4 As GroupBox
    Friend WithEvents ConnectXOR4 As RadioButton
    Friend WithEvents BypassXOR4 As RadioButton
    Friend WithEvents XOR5 As GroupBox
    Friend WithEvents ConnectXOR5 As RadioButton
    Friend WithEvents BypassXOR5 As RadioButton
    Friend WithEvents XOR6 As GroupBox
    Friend WithEvents ConnectXOR6 As RadioButton
    Friend WithEvents BypassXOR6 As RadioButton
    Friend WithEvents TabPageSetup As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComPortTextBox As RichTextBox
    Friend WithEvents ClockBox As GroupBox
    Friend WithEvents ConnectClock As RadioButton
    Friend WithEvents DisconnectClock As RadioButton
    Friend WithEvents ClearCheckBox As CheckBox
End Class
