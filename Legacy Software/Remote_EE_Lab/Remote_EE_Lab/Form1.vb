Public Class Form1
    Dim Serial_Message As String = "test_message"
    Dim boardID As String = "null"
    Dim temp_read As String = "null"
    Dim USB_port As String = "COM3" 'default COM port; this can be changed later using Setup tab

    'Declare the variables for Board_1
    Dim Board_1_Serial_Message As String = "board_1,01,1,4,4,01,01" 'default message
    Dim Board_1_R1_State As String = "01"
    Dim Board_1_R3_State As String = "1"
    Dim Board_1_Scope_Placement_Ch1 As String = "4"
    Dim Board_1_Scope_Placement_Ch2 As String = "4"
    Dim Board_1_Scope_Ch1_gain As String = "01"
    Dim Board_1_Scope_Ch2_gain As String = "01"


    'Declare the variables for Board_2
    Dim Board_2_Serial_Message As String = "board_2,1,1,1,1,1,1,01,01" 'default message
    Dim Board_2_R1_State As String = "1"
    Dim Board_2_R2_State As String = "1"
    Dim Board_2_R3_State As String = "1"
    Dim Board_2_R4_State As String = "1"
    Dim Board_2_C1_State As String = "1"
    Dim Board_2_C2_State As String = "1"
    Dim Board_2_Scope_Ch1_gain As String = "01"
    Dim Board_2_Scope_Ch2_gain As String = "01"

    'Declare the variables for Board_3
    Dim Board_3_Serial_Message As String = "board_3,1,1" 'default message
    Dim Board_3_R2_State As String = "1"
    Dim Board_3_R3_State As String = "1"

    'Declare the variables for Board_4
    Dim Board_4_Serial_Message As String = "board_4,1,1,1" 'default message
    Dim Board_4_R1_State As String = "1"
    Dim Board_4_Diode1_State As String = "1" '1 means forward, 0 means backward
    Dim Board_4_Diode2_State As String = "1" '1 means forward, 0 means backward

    'Declare the variables for Board_5
    Dim Board_5_Serial_Message As String = "board_5,1,1,1" 'default message
    Dim Board_5_R2_State As String = "1"
    Dim Board_5_R3_State As String = "1"
    Dim Board_5_C1_State As String = "1"

    'Declare the variables for Board_6
    Dim Board_6_Serial_Message As String = "board_6,1" 'default message
    Dim ProgramSelector_State As String = "1" 'default value

    'Declare the variables for Board_7
    Dim Board_7_Serial_Message As String = "board_7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" 'default message
    Dim Board_7_Connect_XOR_1_State = "0"
    Dim Board_7_Connect_XOR_2_State = "0"
    Dim Board_7_Connect_XOR_3_State = "0"
    Dim Board_7_Connect_XOR_4_State = "0"
    Dim Board_7_Connect_XOR_5_State = "0"
    Dim Board_7_Connect_XOR_6_State = "0"
    Dim Board_7_Connect_XOR_7_State = "0"
    Dim Board_7_Preset_D1_State = "0"
    Dim Board_7_Preset_D2_State = "0"
    Dim Board_7_Preset_D3_State = "0"
    Dim Board_7_Preset_D4_State = "0"
    Dim Board_7_Preset_D5_State = "0"
    Dim Board_7_Preset_D6_State = "0"
    Dim Board_7_Preset_D7_State = "0"
    Dim Board_7_Preset_D8_State = "0"
    Dim Board_7_Clock_State = "0"
    Dim Board_7_Clear_All = "0" '0 means no signal is not sent; 1 means clear all flipflops when Update button is pressed

    'Error messages from Arduino
    '-1 = Bad board ID
    '-2 = Bad data recieved from GUI

    Private Sub btn_Dev_Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dev_Test.Click
        Shell("C:\Program Files (x86)\Velleman\PcLab2000LT\PcLab2000LT.exe")

    End Sub



    Private Sub btn_test_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_test_2.Click
        Shell("C:\Program Files (x86)\LogicPort\LogicPort.exe")
    End Sub

    'Setup COM port
    Private Sub setup_COM_port(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        USB_port = ComPortTextBox.Text
        MessageBox.Show("COM Port Successfully Set to " + USB_port)
    End Sub


    'Board ID Check
    Private Sub board_detect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_detect.Click
        Try
            Dim SendCode As String = "boardID" 'request message to retreive the board ID from Arduino
            boardID = "null"
            SerialPort1.PortName = USB_port
            SerialPort1.Open()
            SerialPort1.DiscardInBuffer()
            SerialPort1.DiscardOutBuffer()
            SerialPort1.Write(SendCode)
            boardID = SerialPort1.ReadLine()
            boardID = SerialPort1.ReadLine().Substring(0, 8)
            SerialPort1.Close()
            Serial_Text_Test.Text = boardID
            Panel_Enable(boardID)

            If boardID.Equals("00000001") Then
                board_1_R3_enable.Enabled = True
                Brd_1_Res_Select.Enabled = True
                Brd_1_Scope.Enabled = True
                brd_1_ch1_gain.Enabled = True
                Brd_1_Scope_Ch2.Enabled = True
                brd_1_ch_2_gain.Enabled = True
            ElseIf boardID.Equals("00000010") Then
                board_2_R1.Enabled = True
                board_2_R2.Enabled = True
                board_2_R3.Enabled = True
                board_2_R4.Enabled = True
                board_2_C1.Enabled = True
                board_2_C2.Enabled = True
                board_2_scope_ch_1_gain.Enabled = True
                board_2_scope_ch_2_gain.Enabled = True
            ElseIf boardID.Equals("00000011") Then
                board_3_R2.Enabled = True
                board_3_R3.Enabled = True
                board_3_multimeter_output.Enabled = True
            ElseIf boardID.Equals("00000100") Then
                board_4_R1.Enabled = True
                board4_Diode1_RadioButton1.Enabled = True
                board4_Diode1_RadioButton2.Enabled = True
                board4_Diode2_RadioButton1.Enabled = True
                board4_Diode2_RadioButton2.Enabled = True
            ElseIf boardID.Equals("00000101") Then
                board_5_R2.Enabled = True
                board_5_R3.Enabled = True
                board_5_C1.Enabled = True
            ElseIf boardID.Equals("00000110") Then
                ProgramSelector.Enabled = True
            ElseIf boardID.Equals("00000111") Then
                PresetD1.Enabled = True
                ConnectXOR1.Enabled = True
                BypassXOR1.Enabled = True
                PresetD2.Enabled = True
                ConnectXOR2.Enabled = True
                BypassXOR2.Enabled = True
                PresetD3.Enabled = True
                ConnectXOR3.Enabled = True
                BypassXOR3.Enabled = True
                PresetD4.Enabled = True
                ConnectXOR4.Enabled = True
                BypassXOR4.Enabled = True
                PresetD5.Enabled = True
                ConnectXOR5.Enabled = True
                BypassXOR5.Enabled = True
                PresetD6.Enabled = True
                ConnectXOR6.Enabled = True
                BypassXOR6.Enabled = True
                PresetD7.Enabled = True
                ConnectXOR7.Enabled = True
                BypassXOR7.Enabled = True
                PresetD8.Enabled = True
                ClearCheckBox.Enabled = True
                ConnectClock.Enabled = True
                DisconnectClock.Enabled = True

            End If

        Catch ex As Exception
        End Try

        'boardID = "00000111"



    End Sub

    Sub Panel_Enable(ByVal board As String)
        Try
            'If there is a problem transmitting board ID, it's likely to be due to the indices of this substring
            Select Case board
                Case "00000000"
                    'do something
                    Deactivate()
                    Serial_Text_Test.Text = "No board is present: " + board
                Case "00000001"
                    'do something
                    Setup.SelectTab(0)
                    Deactivate()
                    lbl_board_1_status.BackColor = Color.Green
                    lbl_board_1_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case "00000010"
                    'do something
                    Setup.SelectTab(1)
                    Deactivate()
                    lbl_board_2_status.BackColor = Color.Green
                    lbl_board_2_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case "00000011" 'Daughterboard 3: Current Mirror or Widlar Reducing Current Source
                    'do something
                    Setup.SelectTab(2)
                    Deactivate()
                    lbl_board_3_status.BackColor = Color.Green
                    lbl_board_3_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case "00000100" 'Daughterboard 4: Half-Wave Rectifier
                    ' do something
                    Setup.SelectTab(3)
                    Deactivate()
                    lbl_board_4_status.BackColor = Color.Green
                    lbl_board_4_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case "00000101" 'Daughterboard 5: Integrator/Low-Pass Filter
                    'do something
                    Setup.SelectTab(4)
                    Deactivate()
                    lbl_board_5_status.BackColor = Color.Green
                    lbl_board_5_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case "00000110" 'Daughterboard 6: Debugging a Z80 circuit
                    'do something
                    Setup.SelectTab(5)
                    Deactivate()
                    lbl_board_6_status.BackColor = Color.Green
                    lbl_board_6_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case "00000111" 'Daughterboard 7: Learning to use the Logic Analyzer with Flipflops
                    'do something
                    Setup.SelectTab(6)
                    Deactivate()
                    lbl_board_7_status.BackColor = Color.Green
                    lbl_board_7_status.Text = "Active"
                    Serial_Text_Test.Text = board
                Case Else
                    'don't do anything
                    Deactivate()
                    Serial_Text_Test.Text = board
            End Select
        Catch ex As Exception
            Serial_Text_Test.Text = "WARNING: Recheck Board ID"
        End Try
    End Sub

    Private Sub Deactivate()
        lbl_board_1_status.BackColor = Color.Red
        lbl_board_1_status.Text = "Inactive"
        lbl_board_2_status.BackColor = Color.Red
        lbl_board_2_status.Text = "Inactive"
        lbl_board_3_status.BackColor = Color.Red
        lbl_board_3_status.Text = "Inactive"
        lbl_board_4_status.BackColor = Color.Red
        lbl_board_4_status.Text = "Inactive"
        lbl_board_5_status.BackColor = Color.Red
        lbl_board_5_status.Text = "Inactive"
        lbl_board_6_status.BackColor = Color.Red
        lbl_board_6_status.Text = "Inactive"
        lbl_board_7_status.BackColor = Color.Red
        lbl_board_7_status.Text = "Inactive"
    End Sub



    'Send Serial Message
    Private Sub btn_Send_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Send_Config.Click

        'Check if the correct board is connected
        Try
            Dim SendCode As String = "boardID" 'request message to retreive the board ID from Arduino
            boardID = "null"
            SerialPort1.PortName = USB_port
            SerialPort1.Open()
            SerialPort1.DiscardInBuffer()
            SerialPort1.DiscardOutBuffer()
            SerialPort1.Write(SendCode)
            boardID = SerialPort1.ReadLine()
            SerialPort1.Close()
            Serial_Text_Test.Text = boardID
            Panel_Enable(boardID)
        Catch ex As Exception
        End Try

        Try
            Select Case boardID 'If there is a problem transmitting board ID, it's likely to be due to the indices of this substring
                Case "00000000"
                    lbl_board_1_status.BackColor = Color.Red
                    lbl_board_1_status.Text = "Inactive"
                    lbl_board_2_status.BackColor = Color.Red
                    lbl_board_2_status.Text = "Inactive"
                    Serial_Text_Test.Text = "WARNING: No board is present"
                Case "00000001"
                    Serial_Message = Board_1_Serial_Message
                Case "00000010"
                    Serial_Message = Board_2_Serial_Message
                Case "00000011"
                    Serial_Message = Board_3_Serial_Message
                Case "00000100"
                    Serial_Message = Board_4_Serial_Message
                Case "00000101"
                    Serial_Message = Board_5_Serial_Message
                Case "00000110"
                    Serial_Message = Board_6_Serial_Message
                Case "00000111"
                    Serial_Message = Board_7_Serial_Message
                    'Remove the check mark from the box on Board 7 so user doesn't accidentally clear it again next time
                    ClearCheckBox.Checked = False
                Case Else
                    'don't do anything
                    Serial_Text_Test.Text = "WARNING: No board is present"
            End Select
        Catch ex As Exception
            Serial_Text_Test.Text = "WARNING: Resend the message"
        End Try

        Try
            SerialPort1.PortName = USB_port
            SerialPort1.Open()
            SerialPort1.DiscardInBuffer()
            SerialPort1.DiscardOutBuffer()
            SerialPort1.WriteLine(Serial_Message)
            SerialPort1.Close()
        Catch ex As Exception
        End Try

        'Change the Button color back to blue, to indicate
        'that the configuration changes have been noted
        btn_Send_Config.BackColor = Color.LightBlue
    End Sub







    'Board 1 Subroutines 

    'Board_1: Serial Message Compiler
    'This subroutine takes the individual board_1 variables and
    'combines them into one string.
    Sub Board_1_Compile_Serial_Message()
        Board_1_Serial_Message = "board_1," + Board_1_R1_State + "," +
                                 Board_1_R3_State + "," +
                                 Board_1_Scope_Placement_Ch1 + "," +
                                 Board_1_Scope_Placement_Ch2 + "," +
                                 Board_1_Scope_Ch1_gain + "," +
                                 Board_1_Scope_Ch2_gain
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_1_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub


    'Board_1: Scope CH1 placement
    Private Sub Brd_1_Scope_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brd_1_Scope.SelectedIndexChanged
        If Brd_1_Scope.SelectedIndex = 0 Then
            Board_1_Scope_Placement_Ch1 = "1"
        ElseIf Brd_1_Scope.SelectedIndex = 1 Then
            Board_1_Scope_Placement_Ch1 = "2"
        ElseIf Brd_1_Scope.SelectedIndex = 2 Then
            Board_1_Scope_Placement_Ch1 = "3"
        Else
            Board_1_Scope_Placement_Ch1 = "4"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()

    End Sub

    'Board_1: Scope CH2 placement
    Private Sub Brd_1_Scope_Ch2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brd_1_Scope_Ch2.SelectedIndexChanged
        If Brd_1_Scope_Ch2.SelectedIndex = 0 Then
            Board_1_Scope_Placement_Ch2 = "1"
        ElseIf Brd_1_Scope_Ch2.SelectedIndex = 1 Then
            Board_1_Scope_Placement_Ch2 = "2"
        ElseIf Brd_1_Scope_Ch2.SelectedIndex = 2 Then
            Board_1_Scope_Placement_Ch2 = "3"
        Else
            Board_1_Scope_Placement_Ch2 = "4"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub


    Private Sub board_1_R3_enable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_1_R3_enable.SelectedIndexChanged


        If board_1_R3_enable.SelectedIndex = 0 Then
            Board_1_R3_State = "1"
        Else
            Board_1_R3_State = "0"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub


    Private Sub Brd_1_Res_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brd_1_Res_Select.SelectedIndexChanged
        If Brd_1_Res_Select.SelectedIndex = 0 Then
            Board_1_R1_State = "01"
        ElseIf Brd_1_Res_Select.SelectedIndex = 1 Then
            Board_1_R1_State = "02"
        ElseIf Brd_1_Res_Select.SelectedIndex = 2 Then
            Board_1_R1_State = "03"
        ElseIf Brd_1_Res_Select.SelectedIndex = 3 Then
            Board_1_R1_State = "04"
        ElseIf Brd_1_Res_Select.SelectedIndex = 4 Then
            Board_1_R1_State = "05"
        ElseIf Brd_1_Res_Select.SelectedIndex = 5 Then
            Board_1_R1_State = "06"
        ElseIf Brd_1_Res_Select.SelectedIndex = 6 Then
            Board_1_R1_State = "07"
        ElseIf Brd_1_Res_Select.SelectedIndex = 7 Then
            Board_1_R1_State = "08"
        ElseIf Brd_1_Res_Select.SelectedIndex = 8 Then
            Board_1_R1_State = "09"
        ElseIf Brd_1_Res_Select.SelectedIndex = 9 Then
            Board_1_R1_State = "10"
        ElseIf Brd_1_Res_Select.SelectedIndex = 10 Then
            Board_1_R1_State = "11"
        Else
            Board_1_R1_State = "10"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub

    Private Sub brd_1_ch1_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brd_1_ch1_gain.SelectedIndexChanged
        If brd_1_ch1_gain.SelectedIndex = 0 Then
            Board_1_Scope_Ch1_gain = "01"
        Else
            Board_1_Scope_Ch1_gain = "10"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub

    Private Sub brd_1_ch_2_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brd_1_ch_2_gain.SelectedIndexChanged
        If brd_1_ch_2_gain.SelectedIndex = 0 Then
            Board_1_Scope_Ch2_gain = "01"
        Else
            Board_1_Scope_Ch2_gain = "10"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub













    'Board 2 Subroutines 

    'Board_2: Serial Message Compiler
    'This subroutine takes the individual board_2 variables and
    'combines them into one string.
    Sub Board_2_Compile_Serial_Message()
        Board_2_Serial_Message = "board_2," + Board_2_R1_State + "," +
                         Board_2_R2_State + "," +
                         Board_2_R3_State + "," +
                         Board_2_R4_State + "," +
                         Board_2_C1_State + "," +
                         Board_2_C2_State + "," +
                         Board_2_Scope_Ch1_gain + "," +
                         Board_2_Scope_Ch2_gain
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_2_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub

    'Board_2: R1 control
    Private Sub board_2_R1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_R1.SelectedIndexChanged
        If board_2_R1.SelectedIndex = 0 Then
            Board_2_R1_State = "1"
        ElseIf board_2_R1.SelectedIndex = 1 Then
            Board_2_R1_State = "2"
        ElseIf board_2_R1.SelectedIndex = 2 Then
            Board_2_R1_State = "3"
        ElseIf board_2_R1.SelectedIndex = 3 Then
            Board_2_R1_State = "4"
        Else
            Board_2_R1_State = "5"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: R2 control
    Private Sub board_2_R2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_R2.SelectedIndexChanged
        If board_2_R2.SelectedIndex = 0 Then
            Board_2_R2_State = "1"
        ElseIf board_2_R2.SelectedIndex = 1 Then
            Board_2_R2_State = "2"
        ElseIf board_2_R2.SelectedIndex = 2 Then
            Board_2_R2_State = "3"
        ElseIf board_2_R2.SelectedIndex = 3 Then
            Board_2_R2_State = "4"
        Else
            Board_2_R2_State = "5"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: R3 control
    Private Sub board_2_R3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_R3.SelectedIndexChanged
        If board_2_R3.SelectedIndex = 0 Then
            Board_2_R3_State = "1"
        ElseIf board_2_R3.SelectedIndex = 1 Then
            Board_2_R3_State = "2"
        ElseIf board_2_R3.SelectedIndex = 2 Then
            Board_2_R3_State = "3"
        ElseIf board_2_R3.SelectedIndex = 3 Then
            Board_2_R3_State = "4"
        Else
            Board_2_R3_State = "5"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: R4 control
    Private Sub board_2_R4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_R4.SelectedIndexChanged
        If board_2_R4.SelectedIndex = 0 Then
            Board_2_R4_State = "1"
        ElseIf board_2_R4.SelectedIndex = 1 Then
            Board_2_R4_State = "2"
        ElseIf board_2_R4.SelectedIndex = 2 Then
            Board_2_R4_State = "3"
        ElseIf board_2_R4.SelectedIndex = 3 Then
            Board_2_R4_State = "4"
        Else
            Board_2_R4_State = "5"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: C1 control
    Private Sub board_2_C1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_C1.SelectedIndexChanged
        If board_2_C1.SelectedIndex = 0 Then
            Board_2_C1_State = "1"
        ElseIf board_2_C1.SelectedIndex = 1 Then
            Board_2_C1_State = "2"
        Else
            Board_2_C1_State = "3"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: C2 control
    Private Sub board_2_C2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_C2.SelectedIndexChanged
        If board_2_C2.SelectedIndex = 0 Then
            Board_2_C2_State = "1"
        ElseIf board_2_C2.SelectedIndex = 1 Then
            Board_2_C2_State = "2"
        Else
            Board_2_C2_State = "3"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: Ch1 gain control
    Private Sub board_2_scope_ch_1_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_scope_ch_1_gain.SelectedIndexChanged
        If board_2_scope_ch_1_gain.SelectedIndex = 0 Then
            Board_2_Scope_Ch1_gain = "01"
        Else
            Board_2_Scope_Ch1_gain = "10"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    Private Sub board_2_scope_ch_2_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_scope_ch_2_gain.SelectedIndexChanged
        If board_2_scope_ch_2_gain.SelectedIndex = 0 Then
            Board_2_Scope_Ch2_gain = "01"
        Else
            Board_2_Scope_Ch2_gain = "10"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub









    'Board 3 Subroutines 

    'Board_3: Serial Message Compiler
    'This subroutine takes the individual board_3 variables and
    'combines them into one string.
    Sub Board_3_Compile_Serial_Message()
        Board_3_Serial_Message = "board_3," +
                         Board_3_R2_State + "," +
                         Board_3_R3_State
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_3_Serial_Message
        'Change the 'Send Data' button color to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub

    'Board 3: R2 control
    Private Sub board_3_R2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_3_R2.SelectedIndexChanged
        If board_3_R2.SelectedIndex = 0 Then
            Board_3_R2_State = "1"
        ElseIf board_3_R2.SelectedIndex = 1 Then
            Board_3_R2_State = "2"
        ElseIf board_3_R2.SelectedIndex = 2 Then
            Board_3_R2_State = "3"
        ElseIf board_3_R2.SelectedIndex = 3 Then
            Board_3_R2_State = "4"
        Else
            Board_3_R2_State = "5"
        End If
        'Call the message compiler
        Board_3_Compile_Serial_Message()
    End Sub

    'Board 3: R3 control
    Private Sub board_3_R3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_3_R3.SelectedIndexChanged
        If board_3_R3.SelectedIndex = 0 Then
            Board_3_R3_State = "1"
        ElseIf board_3_R3.SelectedIndex = 1 Then
            Board_3_R3_State = "2"
        ElseIf board_3_R3.SelectedIndex = 2 Then
            Board_3_R3_State = "3"
        ElseIf board_3_R3.SelectedIndex = 3 Then
            Board_3_R3_State = "4"
        Else
            Board_3_R3_State = "5"
        End If
        'Call the message compiler
        Board_3_Compile_Serial_Message()
    End Sub










    'Board 4 Subroutines 

    'Board_4: Serial Message Compiler
    'This subroutine takes the individual board_4 variables and
    'combines them into one string.
    Sub Board_4_Compile_Serial_Message()
        Board_4_Serial_Message = "board_4," +
                         Board_4_R1_State + "," +
                         Board_4_Diode1_State + "," +
                         Board_4_Diode2_State
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_4_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub

    'Board 4: R1 control
    Private Sub board_4_R1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_4_R1.SelectedIndexChanged
        If board_4_R1.SelectedIndex = 0 Then
            Board_4_R1_State = "1"
        ElseIf board_4_R1.SelectedIndex = 1 Then
            Board_4_R1_State = "2"
        ElseIf board_4_R1.SelectedIndex = 2 Then
            Board_4_R1_State = "3"
        Else
            Board_4_R1_State = "4"
        End If
        'Call the message compiler
        Board_4_Compile_Serial_Message()
    End Sub

    'Board 4: Diode 1 control
    Private Sub board4_Diode1_RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board4_Diode1_RadioButton1.CheckedChanged
        If board4_Diode1_RadioButton1.Checked = True Then
            Board_4_Diode1_State = "1"
        Else
            Board_4_Diode1_State = "0"
        End If
        'Call the message compiler
        Board_4_Compile_Serial_Message()
    End Sub
    'You actually DO need a function for BOTH radio buttons; if you only have a function for RadioButton1,
    'then RadioButton2 will not work until AFTER RadioButton1 has been clicked, which is confusing and undesirable
    Private Sub board4_Diode1_RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board4_Diode1_RadioButton2.CheckedChanged
        If board4_Diode1_RadioButton2.Checked = True Then
            Board_4_Diode1_State = "0"
        Else
            Board_4_Diode1_State = "1"
        End If
        'Call the message compiler
        Board_4_Compile_Serial_Message()
    End Sub

    'Board 4: Diode 2 control
    Private Sub board4_Diode2_RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board4_Diode2_RadioButton1.CheckedChanged
        If board4_Diode2_RadioButton1.Checked = True Then
            Board_4_Diode2_State = "1"
        Else
            Board_4_Diode2_State = "0"
        End If
        'Call the message compiler
        Board_4_Compile_Serial_Message()
    End Sub
    Private Sub board4_Diode2_RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board4_Diode2_RadioButton2.CheckedChanged
        If board4_Diode2_RadioButton2.Checked = True Then
            Board_4_Diode2_State = "0"
        Else
            Board_4_Diode2_State = "1"
        End If
        'Call the message compiler
        Board_4_Compile_Serial_Message()
    End Sub





    'Board 5 Subroutines 

    'Board_5: Serial Message Compiler
    'This subroutine takes the individual board_5 variables and
    'combines them into one string.
    Sub Board_5_Compile_Serial_Message()
        Board_5_Serial_Message = "board_5," +
                         Board_5_R2_State + "," +
                         Board_5_R3_State + "," +
                         Board_5_C1_State
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_5_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub

    'Board 5: R2 control
    Private Sub board_5_R2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_5_R2.SelectedIndexChanged
        If board_5_R2.SelectedIndex = 0 Then
            Board_5_R2_State = "1"
        Else
            Board_5_R2_State = "0"
        End If
        'Call the message compiler
        Board_5_Compile_Serial_Message()
    End Sub

    'Board 5: R2 control
    Private Sub board_5_R3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_5_R3.SelectedIndexChanged
        If board_5_R3.SelectedIndex = 0 Then
            Board_5_R3_State = "1"
        Else
            Board_5_R3_State = "0"
        End If
        'Call the message compiler
        Board_5_Compile_Serial_Message()
    End Sub

    'Board 5: C1 control
    Private Sub board_5_C1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_5_C1.SelectedIndexChanged
        If board_5_C1.SelectedIndex = 0 Then
            Board_5_C1_State = "1"
        Else
            Board_5_C1_State = "0"
        End If
        'Call the message compiler
        Board_5_Compile_Serial_Message()
    End Sub













    'Board 7 Subroutines
    'Board_7: Serial Message Compiler
    'This subroutine takes the individual board_7 variables and
    'combines them into one string.
    Sub Board_7_Compile_Serial_Message()
        Board_7_Serial_Message = "board_7," +
        Board_7_Connect_XOR_1_State + "," +
        Board_7_Connect_XOR_2_State + "," +
        Board_7_Connect_XOR_3_State + "," +
        Board_7_Connect_XOR_4_State + "," +
        Board_7_Connect_XOR_5_State + "," +
        Board_7_Connect_XOR_6_State + "," +
        Board_7_Connect_XOR_7_State + "," +
        Board_7_Preset_D1_State + "," +
        Board_7_Preset_D2_State + "," +
        Board_7_Preset_D3_State + "," +
        Board_7_Preset_D4_State + "," +
        Board_7_Preset_D5_State + "," +
        Board_7_Preset_D6_State + "," +
        Board_7_Preset_D7_State + "," +
        Board_7_Preset_D8_State + "," +
        Board_7_Clock_State + "," +
        Board_7_Clear_All
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_7_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub


    'Flipflop presets
    'Board 7: dff1 control
    Private Sub board_7_PresetD1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD1.SelectedIndexChanged
        If PresetD1.SelectedIndex = 0 Then
            Board_7_Preset_D1_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff2 control
    Private Sub board_7_PresetD2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD2.SelectedIndexChanged
        If PresetD2.SelectedIndex = 0 Then
            Board_7_Preset_D2_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff3 control
    Private Sub board_7_PresetD3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD3.SelectedIndexChanged
        If PresetD3.SelectedIndex = 0 Then
            Board_7_Preset_D3_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff4 control
    Private Sub board_7_PresetD4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD4.SelectedIndexChanged
        If PresetD4.SelectedIndex = 0 Then
            Board_7_Preset_D4_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff5 control
    Private Sub board_7_PresetD5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD5.SelectedIndexChanged
        If PresetD5.SelectedIndex = 0 Then
            Board_7_Preset_D5_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff6 control
    Private Sub board_7_PresetD6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD6.SelectedIndexChanged
        If PresetD6.SelectedIndex = 0 Then
            Board_7_Preset_D6_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff7 control
    Private Sub board_7_PresetD7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD7.SelectedIndexChanged
        If PresetD7.SelectedIndex = 0 Then
            Board_7_Preset_D7_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    'Board 7: dff8 control
    Private Sub board_7_PresetD8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetD8.SelectedIndexChanged
        If PresetD8.SelectedIndex = 0 Then
            Board_7_Preset_D8_State = "1"
        Else 'If selected index is -1 or something weird, don't bother to recompile serial message
            Return
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Clock Connection Controls
    'Board 7: Clock control
    Private Sub board7_ConnectClock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectClock.CheckedChanged
        If ConnectClock.Checked = True Then
            Board_7_Clock_State = "1" 'Connect Clock
        Else
            Board_7_Clock_State = "0" 'Bypass Clock
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_DisconnectClock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectClock.CheckedChanged
        If DisconnectClock.Checked = True Then
            Board_7_Clock_State = "0" 'Disconnect Clock
        Else
            Board_7_Clock_State = "1" 'Connected Clock
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub



    'XOR Connection Controls
    'Board 7: XOR 1 control
    Private Sub board7_ConnectXOR1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR1.CheckedChanged
        If ConnectXOR1.Checked = True Then
            Board_7_Connect_XOR_1_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_1_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR1.CheckedChanged
        If BypassXOR1.Checked = True Then
            Board_7_Connect_XOR_1_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_1_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Board 7: XOR 2 control
    Private Sub board7_ConnectXOR2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR2.CheckedChanged
        If ConnectXOR2.Checked = True Then
            Board_7_Connect_XOR_2_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_2_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR2.CheckedChanged
        If BypassXOR2.Checked = True Then
            Board_7_Connect_XOR_2_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_2_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Board 7: XOR 3 control
    Private Sub board7_ConnectXOR3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR3.CheckedChanged
        If ConnectXOR3.Checked = True Then
            Board_7_Connect_XOR_3_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_3_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR3.CheckedChanged
        If BypassXOR3.Checked = True Then
            Board_7_Connect_XOR_3_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_3_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Board 7: XOR 4 control
    Private Sub board7_ConnectXOR4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR4.CheckedChanged
        If ConnectXOR4.Checked = True Then
            Board_7_Connect_XOR_4_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_4_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR4.CheckedChanged
        If BypassXOR4.Checked = True Then
            Board_7_Connect_XOR_4_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_4_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Board 7: XOR 5 control
    Private Sub board7_ConnectXOR5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR5.CheckedChanged
        If ConnectXOR5.Checked = True Then
            Board_7_Connect_XOR_5_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_5_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR5.CheckedChanged
        If BypassXOR5.Checked = True Then
            Board_7_Connect_XOR_5_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_5_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Board 7: XOR 6 control
    Private Sub board7_ConnectXOR6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR6.CheckedChanged
        If ConnectXOR6.Checked = True Then
            Board_7_Connect_XOR_6_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_6_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR6.CheckedChanged
        If BypassXOR6.Checked = True Then
            Board_7_Connect_XOR_6_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_6_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Board 7: XOR 7 control
    Private Sub board7_ConnectXOR7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectXOR7.CheckedChanged
        If ConnectXOR7.Checked = True Then
            Board_7_Connect_XOR_7_State = "0" 'Connect XOR
        Else
            Board_7_Connect_XOR_7_State = "1" 'Bypass XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub
    Private Sub board7_BypassXOR7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BypassXOR7.CheckedChanged
        If BypassXOR7.Checked = True Then
            Board_7_Connect_XOR_7_State = "1" 'Bypass XOR
        Else
            Board_7_Connect_XOR_7_State = "0" 'Connect XOR
        End If
        'Call the message compiler
        Board_7_Compile_Serial_Message()
    End Sub

    'Set up behavior for the "Clear" checkbox, which resets all the DFF presets back to 0
    Private Sub checkBoxChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearCheckBox.CheckedChanged
        If ClearCheckBox.Checked = True Then 'User wants to clear all flipflops
            'Send the signal to clear all flipflops
            Board_7_Clear_All = "1"
            'Change the serial message
            Board_7_Preset_D1_State = "0"
            Board_7_Preset_D2_State = "0"
            Board_7_Preset_D3_State = "0"
            Board_7_Preset_D4_State = "0"
            Board_7_Preset_D5_State = "0"
            Board_7_Preset_D6_State = "0"
            Board_7_Preset_D7_State = "0"
            Board_7_Preset_D8_State = "0"
            'Call the message compiler
            Board_7_Compile_Serial_Message()
            'Reset all the drop-down boxes to default
            PresetD1.SelectedIndex = -1
            PresetD2.SelectedIndex = -1
            PresetD3.SelectedIndex = -1
            PresetD4.SelectedIndex = -1
            PresetD5.SelectedIndex = -1
            PresetD6.SelectedIndex = -1
            PresetD7.SelectedIndex = -1
            PresetD8.SelectedIndex = -1
        Else 'User wants to make sure flipflops don't get cleared on next cycle
            Board_7_Clear_All = "0"
            'Call the message compiler
            Board_7_Compile_Serial_Message()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Serial_Text_Test_TextChanged(sender As Object, e As EventArgs) Handles Serial_Text_Test.TextChanged

    End Sub
End Class
