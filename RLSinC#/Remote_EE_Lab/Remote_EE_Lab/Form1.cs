using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO.Ports;
using System.Net.Mail;
using System.Net;


namespace Remote_EE_Lab
{
    public partial class Form1 : Form
    {
        //Default Declarations
        String Serial_Message = "test_message";
        String boardID = "null";
        String Current_Board = "-1";
        String USB_port = "COM69"; //default COM port; this can be changed later using Setup tab;
        bool isDebugMode = false;

        //Declare the variables for Board_1
        String Board_1_Serial_Message = "board_1,01,1,4,4,01,01"; //default message
        String Board_1_R1_State = "01";
        String Board_1_R3_State = "1";
        String Board_1_Scope_Placement_Ch1 = "4";
        String Board_1_Scope_Placement_Ch2 = "4";
        String Board_1_Scope_Ch1_gain = "01";
        String Board_1_Scope_Ch2_gain = "01";


        //Declare the variables for Board_2
        String Board_2_Serial_Message = "board_2,1,1,1,1,1,1,01,01"; //default message'
        String Board_2_R1_State = "1";
        String Board_2_R2_State = "1";
        String Board_2_R3_State = "1";
        String Board_2_R4_State = "1";
        String Board_2_C1_State = "1";
        String Board_2_C2_State = "1";
        String Board_2_Scope_Ch1_gain = "01";
        String Board_2_Scope_Ch2_gain = "01";

        //Declare the variables for Board_3
        String Board_3_Serial_Message = "board_3,1,1"; //default message
        String Board_3_R2_State = "1";
        String Board_3_R3_State = "1";

        //Declare the variables for Board_4
        String Board_4_Serial_Message = "board_4,1,1,1"; //default message
        String Board_4_R1_State = "1";
        String Board_4_Diode1_State = "1"; //1 means forward, 0 means backward
        String Board_4_Diode2_State = "1"; //1 means forward, 0 means backward

        //Declare the variables for Board_5
        String Board_5_Serial_Message = "board_5,1,1,1"; //default message
        String Board_5_R2_State = "1";
        String Board_5_R3_State = "1";
        String Board_5_C1_State = "1";

        //Declare the variables for Board_6
        String Board_6_Serial_Message = "board_6,1"; //default message
        //String ProgramSelector_State = "1"; //default value

        //Declare the variables for Board_7
        String Board_7_Serial_Message = "board_7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"; //default message
        String Board_7_Connect_XOR_1_State = "0";
        String Board_7_Connect_XOR_2_State = "0";
        String Board_7_Connect_XOR_3_State = "0";
        String Board_7_Connect_XOR_4_State = "0";
        String Board_7_Connect_XOR_5_State = "0";
        String Board_7_Connect_XOR_6_State = "0";
        String Board_7_Connect_XOR_7_State = "0";
        String Board_7_Preset_D1_State = "0";
        String Board_7_Preset_D2_State = "0";
        String Board_7_Preset_D3_State = "0";
        String Board_7_Preset_D4_State = "0";
        String Board_7_Preset_D5_State = "0";
        String Board_7_Preset_D6_State = "0";
        String Board_7_Preset_D7_State = "0";
        String Board_7_Preset_D8_State = "0";
        String Board_7_Clock_State = "0";
        String Board_7_Clear_All = "0"; //0 means no signal is not sent; 1 means clear all flipflops when Update button is pressed
        

        public Form1()
        {
            //Creates a new thread that starts the splashscreen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            
            InitializeComponent();
            t.Abort();
            bringToFront();
            setComPort();
        }

        /************************************************************
        *  setComPort()
        *  When called, gets all of the COM Ports currently being
        *  used and then sets COM port of the RLS to the COM port
        *  that is being used by the Remote lab system motherboard.
        ************************************************************/
        public void setComPort()
        {
            try
            {
                string[] temp = SerialPort.GetPortNames();
                USB_port = temp[0];
            }
            catch
            {
                MessageBox.Show("Remote Lab Station not connected");
            }
        }

        /************************************************************
        *   SplashStart()
        *   Starts the splash screen before the running
        *   the RLS program.
        ************************************************************/
        public void SplashStart()
        {
            //Runs the splashscreen
            Application.Run(new SplashScreen_1());
        }

        /************************************************************
        *   bringToFront()
        *   Sends the RLS program to the front of everything the
        *   user currently has open.
        ************************************************************/
        public void bringToFront()
        {
            //if (WindowState == FormWindowState.Minimized)
              //  WindowState = FormWindowState.Normal;
            //else
            //{
                TopMost = true;
                Focus();
                BringToFront();
                TopMost = false;
            //}
        }

        /************************************************************
        *   btn_Dev_Test_Click()
        *   Starts the velleman oscilloscope + function generator
        *   program.
        ************************************************************/
        private void btn_Dev_Test_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("PcLab2000LT").Length > 0)
            {
                MessageBox.Show("An instance of the PcLab2000LT.exe is already running");
            }
            else
            {
                Process.Start("C:/Velleman/PcLab2000LT.exe");
            }
        }

        /************************************************************
        *   btn_test_2_Click()
        *   Starts the logic port logic analyzer software.
        ************************************************************/
        private void btn_test_2_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LogicPort").Length > 0)
            {
                MessageBox.Show("An instance of the LogicPort.exe is already running");
            }
            else
            {
                Process.Start("C:/Program Files (x86)/LogicPort/LogicPort.exe");
            }
        }

        /************************************************************
        *   SubmitButton_Click()
        *   Allows user to manually set a COM port if for some reason
        *   the RLS does not automatically detect the correct one.
        ************************************************************/
        //private void SubmitButton_Click(object sender, EventArgs e)
        //{
        //    USB_port = ComPortTextBox.Text;
        //    MessageBox.Show("COM Port Successfully Set to " + USB_port);
        //}

        /************************************************************
        *   board_detect_Click
        *   Makes check board button work. It finds what 
        *   daughterboard is currently connected to the RLS
        *   motherboard.
        ************************************************************/
        private void board_detect_Click(object sender, EventArgs e)
        {
            if (isDebugMode == true)
            {
                lbl_board_1_status.BackColor = Color.Purple;
                lbl_board_1_status.Text = "Debug";
                lbl_board_2_status.BackColor = Color.Purple;
                lbl_board_2_status.Text = "Debug";
                lbl_board_3_status.BackColor = Color.Purple;
                lbl_board_3_status.Text = "Debug";
                lbl_board_4_status.BackColor = Color.Purple;
                lbl_board_4_status.Text = "Debug";
                lbl_board_5_status.BackColor = Color.Purple;
                lbl_board_5_status.Text = "Debug";
                lbl_board_6_status.BackColor = Color.Purple;
                lbl_board_6_status.Text = "Debug";
                lbl_board_7_status.BackColor = Color.Purple;
                lbl_board_7_status.Text = "Debug";

                Current_Board = "-1";
                //board 1
                board_1_R3_enable.Enabled = true;
                Brd_1_Res_Select.Enabled = true;
                Brd_1_Scope.Enabled = true;
                brd_1_ch1_gain.Enabled = true;
                Brd_1_Scope_Ch2.Enabled = true;
                brd_1_ch_2_gain.Enabled = true;

                //board 2
                board_2_R1.Enabled = true;
                board_2_R2.Enabled = true;
                board_2_R3.Enabled = true;
                board_2_R4.Enabled = true;
                board_2_C1.Enabled = true;
                board_2_C2.Enabled = true;
                board_2_scope_ch_1_gain.Enabled = true;
                board_2_scope_ch_2_gain.Enabled = true;

                //board 3
                board_3_R2.Enabled = true;
                board_3_R3.Enabled = true;
                board_3_multimeter_output.Enabled = true;

                //board 4
                board_4_R1.Enabled = true;
                board4_Diode1_RadioButton1.Enabled = true;
                board4_Diode1_RadioButton2.Enabled = true;
                board4_Diode2_RadioButton1.Enabled = true;
                board4_Diode2_RadioButton2.Enabled = true;

                //board 5
                board_5_R2.Enabled = true;
                board_5_R3.Enabled = true;
                board_5_C1.Enabled = true;

                //board 6
                ProgramSelector.Enabled = false;

                //board 7
                PresetD1.Enabled = true;
                ConnectXOR1.Enabled = true;
                BypassXOR1.Enabled = true;
                PresetD2.Enabled = true;
                ConnectXOR2.Enabled = true;
                BypassXOR2.Enabled = true;
                PresetD3.Enabled = true;
                ConnectXOR3.Enabled = true;
                BypassXOR3.Enabled = true;
                PresetD4.Enabled = true;
                ConnectXOR4.Enabled = true;
                BypassXOR4.Enabled = true;
                PresetD5.Enabled = true;
                ConnectXOR5.Enabled = true;
                BypassXOR5.Enabled = true;
                PresetD6.Enabled = true;
                ConnectXOR6.Enabled = true;
                BypassXOR6.Enabled = true;
                PresetD7.Enabled = true;
                ConnectXOR7.Enabled = true;
                BypassXOR7.Enabled = true;
                PresetD8.Enabled = true;
                ClearCheckBox.Enabled = true;
                ConnectClock.Enabled = true;
                DisconnectClock.Enabled = true;
            }
            else
            {
                try
                {
                    string SendCode = "boardID"; //request message to retreive the board ID from Arduino


                    //Using SerialPort1 send "boardID" to the arduino and the arduino responds by
                    //sending back the board id of the daughterboard currently connected.
                    SerialPort1.PortName = USB_port;
                    SerialPort1.Open();
                    SerialPort1.DiscardInBuffer();
                    SerialPort1.DiscardOutBuffer();
                    SerialPort1.Write(SendCode);
                    boardID = SerialPort1.ReadLine();
                    boardID = SerialPort1.ReadLine().Substring(0, 8);
                    SerialPort1.Close();
                    Serial_Text_Test.Text = boardID;
                    Panel_Enable(boardID);
                    /////////////////////////////////////////

                    if (boardID.Equals("00000001")) //Enabled what is needed for board 1
                    {
                        board_1_R3_enable.Enabled = true;
                        Brd_1_Res_Select.Enabled = true;
                        Brd_1_Scope.Enabled = true;
                        brd_1_ch1_gain.Enabled = true;
                        Brd_1_Scope_Ch2.Enabled = true;
                        brd_1_ch_2_gain.Enabled = true;
                        Current_Board = "00000001";
                    }
                    else if (boardID.Equals("00000010")) //Enabled what is needed for board 2
                    {
                        board_2_R1.Enabled = true;
                        board_2_R2.Enabled = true;
                        board_2_R3.Enabled = true;
                        board_2_R4.Enabled = true;
                        board_2_C1.Enabled = true;
                        board_2_C2.Enabled = true;
                        board_2_scope_ch_1_gain.Enabled = true;
                        board_2_scope_ch_2_gain.Enabled = true;
                        Current_Board = "00000010";
                    }
                    else if (boardID.Equals("00000011")) //Enabled what is needed for board 3
                    {
                        board_3_R2.Enabled = true;
                        board_3_R3.Enabled = true;
                        board_3_multimeter_output.Enabled = true;
                        Current_Board = "00000011";
                    }
                    else if (boardID.Equals("00000100")) //Enabled what is needed for board 4
                    {
                        board_4_R1.Enabled = true;
                        board4_Diode1_RadioButton1.Enabled = true;
                        board4_Diode1_RadioButton2.Enabled = true;
                        board4_Diode2_RadioButton1.Enabled = true;
                        board4_Diode2_RadioButton2.Enabled = true;
                        Current_Board = "00000100";
                    }
                    else if (boardID.Equals("00000101")) //Enabled what is needed for board 5
                    {
                        board_5_R2.Enabled = true;
                        board_5_R3.Enabled = true;
                        board_5_C1.Enabled = true;
                        Current_Board = "00000101";
                    }
                    else if (boardID.Equals("00000110")) //Enabled what is needed for board 6
                    {
                        ProgramSelector.Enabled = true;
                        Current_Board = "00000110";
                    }
                    else if (boardID.Equals("00000111")) //Enabled what is needed for board 7
                    {
                        PresetD1.Enabled = true;
                        ConnectXOR1.Enabled = true;
                        BypassXOR1.Enabled = true;
                        PresetD2.Enabled = true;
                        ConnectXOR2.Enabled = true;
                        BypassXOR2.Enabled = true;
                        PresetD3.Enabled = true;
                        ConnectXOR3.Enabled = true;
                        BypassXOR3.Enabled = true;
                        PresetD4.Enabled = true;
                        ConnectXOR4.Enabled = true;
                        BypassXOR4.Enabled = true;
                        PresetD5.Enabled = true;
                        ConnectXOR5.Enabled = true;
                        BypassXOR5.Enabled = true;
                        PresetD6.Enabled = true;
                        ConnectXOR6.Enabled = true;
                        BypassXOR6.Enabled = true;
                        PresetD7.Enabled = true;
                        ConnectXOR7.Enabled = true;
                        BypassXOR7.Enabled = true;
                        PresetD8.Enabled = true;
                        ClearCheckBox.Enabled = true;
                        ConnectClock.Enabled = true;
                        DisconnectClock.Enabled = true;
                        Current_Board = "00000111";
                    }
                }
                catch { }//Deactivate(); Serial_Text_Test.Text = "No board is present: " + boardID; };
            }
        }

        /************************************************************
        *   Panel_Enable()
        *   Sets the text that says wether the board is enabled
        *   or disabled to enabled.
        ************************************************************/
        private void Panel_Enable(string board)
        {
            try
            {
                switch (board) //Checks which board needs to be enabled
                {
                    case "00000000": // makes sure everything is deactivated
                        Deactivate();
                        Serial_Text_Test.Text = "No board is present: " + board;
                        break;
                    case "00000001": // changes panel to active for program 1 (no project)
                        Setup.SelectTab(0);
                        Deactivate();
                        lbl_board_1_status.BackColor = Color.Green;
                        lbl_board_1_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    case "00000010": // changes panel to active for program 2 (no project)
                        Setup.SelectTab(1);
                        Deactivate();
                        lbl_board_2_status.BackColor = Color.Green;
                        lbl_board_2_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    case "00000011": //Daughterboard 3: Current Mirror or Widlar Reducing Current Source
                        Setup.SelectTab(2);
                        Deactivate();
                        lbl_board_3_status.BackColor = Color.Green;
                        lbl_board_3_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    case "00000100": //Daughterboard 4: Half-Wave Rectifier
                        Setup.SelectTab(3);
                        Deactivate();
                        lbl_board_4_status.BackColor = Color.Green;
                        lbl_board_4_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    case "00000101": //Daughterboard 5: Integrator/Low-Pass Filter
                        Setup.SelectTab(4);
                        Deactivate();
                        lbl_board_5_status.BackColor = Color.Green;
                        lbl_board_5_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    case "00000110": //Daughterboard 6: Debugging a Z80 circuit
                        Setup.SelectTab(5);
                        Deactivate();
                        lbl_board_6_status.BackColor = Color.Green;
                        lbl_board_6_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    case "00000111": //Daughterboard 7: Learning to use the Logic Analyzer with Flipflops
                        Setup.SelectTab(6);
                        Deactivate();
                        lbl_board_7_status.BackColor = Color.Green;
                        lbl_board_7_status.Text = "Active";
                        Serial_Text_Test.Text = board;
                        break;
                    default:
                        Deactivate();
                        Serial_Text_Test.Text = "Invalid board: "+ board;
                        break;
                }
            }
            catch
            {
                Serial_Text_Test.Text = "WARNING: Recheck Board ID";
            }
        }

        /************************************************************
        *   Deactivate()
        *   Disables every experiment and changes everything to
        *   inactive.
        ************************************************************/
        private void Deactivate()
        {
            lbl_board_1_status.BackColor = Color.Red;
            lbl_board_1_status.Text = "Inactive";
            lbl_board_2_status.BackColor = Color.Red;
            lbl_board_2_status.Text = "Inactive";
            lbl_board_3_status.BackColor = Color.Red;
            lbl_board_3_status.Text = "Inactive";
            lbl_board_4_status.BackColor = Color.Red;
            lbl_board_4_status.Text = "Inactive";
            lbl_board_5_status.BackColor = Color.Red;
            lbl_board_5_status.Text = "Inactive";
            lbl_board_6_status.BackColor = Color.Red;
            lbl_board_6_status.Text = "Inactive";
            lbl_board_7_status.BackColor = Color.Red;
            lbl_board_7_status.Text = "Inactive";

            Current_Board = "-1";
            //board 1
            board_1_R3_enable.Enabled = false;
            Brd_1_Res_Select.Enabled = false;
            Brd_1_Scope.Enabled = false;
            brd_1_ch1_gain.Enabled = false;
            Brd_1_Scope_Ch2.Enabled = false;
            brd_1_ch_2_gain.Enabled = false;

            //board 2
            board_2_R1.Enabled = false;
            board_2_R2.Enabled = false;
            board_2_R3.Enabled = false;
            board_2_R4.Enabled = false;
            board_2_C1.Enabled = false;
            board_2_C2.Enabled = false;
            board_2_scope_ch_1_gain.Enabled = false;
            board_2_scope_ch_2_gain.Enabled = false;

            //board 3
            board_3_R2.Enabled = false;
            board_3_R3.Enabled = false;
            board_3_multimeter_output.Enabled = false;

            //board 4
            board_4_R1.Enabled = false;
            board4_Diode1_RadioButton1.Enabled = false;
            board4_Diode1_RadioButton2.Enabled = false;
            board4_Diode2_RadioButton1.Enabled = false;
            board4_Diode2_RadioButton2.Enabled = false;

            //board 5
            board_5_R2.Enabled = false;
            board_5_R3.Enabled = false;
            board_5_C1.Enabled = false;

            //board 6
            ProgramSelector.Enabled = false;

            //board 7
            PresetD1.Enabled = false;
            ConnectXOR1.Enabled = false;
            BypassXOR1.Enabled = false;
            PresetD2.Enabled = false;
            ConnectXOR2.Enabled = false;
            BypassXOR2.Enabled = false;
            PresetD3.Enabled = false;
            ConnectXOR3.Enabled = false;
            BypassXOR3.Enabled = false;
            PresetD4.Enabled = false;
            ConnectXOR4.Enabled = false;
            BypassXOR4.Enabled = false;
            PresetD5.Enabled = false;
            ConnectXOR5.Enabled = false;
            BypassXOR5.Enabled = false;
            PresetD6.Enabled = false;
            ConnectXOR6.Enabled = false;
            BypassXOR6.Enabled = false;
            PresetD7.Enabled = false;
            ConnectXOR7.Enabled = false;
            BypassXOR7.Enabled = false;
            PresetD8.Enabled = false;
            ClearCheckBox.Enabled = false;
            ConnectClock.Enabled = false;
            DisconnectClock.Enabled = false;

        }

        /************************************************************
        *   btn_Send_Config_Click()
        *   Update button code.
        ************************************************************/
        private void btn_Send_Config_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets board id of board currently connected
                string SendCode = "boardID"; //request message to retreive the board ID from Arduino
                boardID = "null";
                SerialPort1.PortName = USB_port;
                SerialPort1.Open();
                SerialPort1.DiscardInBuffer();
                SerialPort1.DiscardOutBuffer();
                SerialPort1.Write(SendCode);
                boardID = SerialPort1.ReadLine(); //Added to be consistant with check
                boardID = SerialPort1.ReadLine().Substring(0, 8);
                
                SerialPort1.Close();
                //Check to make sure that the board that is connected matches the board that was last checked
                if(boardID.Equals(Current_Board))
                {
                }
                else
                {
                    Serial_Text_Test.Text = "Please check board first";
                    return;
                }
            }
            catch { }
            //Set message that needs to be sent
            try
            {
                switch (Current_Board) //if there is a problem transmitting board ID, it's likely to be due to the indices of this substring
                {
                    case "00000000":
                        Deactivate();
                        Serial_Text_Test.Text = "No board is present: " + boardID;
                        break;
                    case "00000001":
                        Serial_Message = Board_1_Serial_Message;
                        break;
                    case "00000010":
                        Serial_Message = Board_2_Serial_Message;
                        break;
                    case "00000011":
                        Serial_Message = Board_3_Serial_Message;
                        break;
                    case "00000100":
                        Serial_Message = Board_4_Serial_Message;
                        break;
                    case "00000101":
                        Board_5_Compile_Serial_Message();
                        Serial_Message = Board_5_Serial_Message;
                        break;
                    case "00000110":
                        Serial_Message = Board_6_Serial_Message;
                        break;
                    case "00000111":
                        Serial_Message = Board_7_Serial_Message;
                        //Remove the check mark from the box on Board 7 so user doesn't accidentally clear it again next time
                        ClearCheckBox.Checked = false;
                        break;
                    default:
                        //don't do anything
                        Serial_Text_Test.Text = "WARNING: No board is present";
                        break;
                }
            }
            catch { Serial_Text_Test.Text = "WARNING: Resend the message"; }

            //Send message through USB port to arduino based on the previous try catch
            try
            {
                SerialPort1.PortName = USB_port;
                SerialPort1.Open();
                SerialPort1.DiscardInBuffer();
                SerialPort1.DiscardOutBuffer();
                SerialPort1.WriteLine(Serial_Message);
                MessageBox.Show(Serial_Message);
                Serial_Text_Test.Text = "Board " + boardID + " message sent!";
                //Thread.Sleep(1000);
                //string returnMes = SerialPort1.ReadLine(); //Added to be consistant with check
                ///returnMes = SerialPort1.ReadLine();
                //Serial_Text_Test.Text = returnMes;

                SerialPort1.Close();
            }
            catch { }
            btn_Send_Config.BackColor = Color.LightBlue;
        }


      


        /////////////////////BOARD SUBROUTINES
        //Board 1 Subroutines 
        //Board_1: Serial Message Compiler
        //This subroutine takes the individual board_1 variables and
        //combines them into one string.
        void Board_1_Compile_Serial_Message()
        {
            Board_1_Serial_Message = "board_1," + Board_1_R1_State + "," +
                                     Board_1_R3_State + "," +
                                     Board_1_Scope_Placement_Ch1 + "," +
                                     Board_1_Scope_Placement_Ch2 + "," +
                                     Board_1_Scope_Ch1_gain + "," +
                                     Board_1_Scope_Ch2_gain;
            //this statement exists exclusively for debuginng purposes
            Serial_Text_Test.Text = Board_1_Serial_Message;
            //Change the 'Send Data' button collor to orange, to indicate that
            //a change in the board configuration has occured.
            btn_Send_Config.BackColor = Color.Orange;
        }


        //Board_1: Scope CH1 placement
        private void Brd_1_Scope_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (Brd_1_Scope.SelectedIndex.Equals(0))
                Board_1_Scope_Placement_Ch1 = "1";
            else if (Brd_1_Scope.SelectedIndex.Equals(1))
                Board_1_Scope_Placement_Ch1 = "2";
            else if (Brd_1_Scope.SelectedIndex.Equals(2))
                Board_1_Scope_Placement_Ch1 = "3";
            else
                Board_1_Scope_Placement_Ch1 = "4";

            //Call the message compiler
            Board_1_Compile_Serial_Message();
        }


        //Board_1: Scope CH2 placement
        private void Brd_1_Scope_Ch2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (Brd_1_Scope_Ch2.SelectedIndex.Equals(0))
                Board_1_Scope_Placement_Ch2 = "1";
            else if (Brd_1_Scope_Ch2.SelectedIndex.Equals(1))
                Board_1_Scope_Placement_Ch2 = "2";
            else if (Brd_1_Scope_Ch2.SelectedIndex.Equals(2))
                Board_1_Scope_Placement_Ch2 = "3";
            else
                Board_1_Scope_Placement_Ch2 = "4";

            //Call the message compiler
            Board_1_Compile_Serial_Message();
        }

        private void board_1_R3_enable_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (board_1_R3_enable.SelectedIndex.Equals(0))
                Board_1_R3_State = "1";
            else
                Board_1_R3_State = "0";

            //Call the message compiler
            Board_1_Compile_Serial_Message();
        }

        private void Brd_1_Res_Select_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (Brd_1_Res_Select.SelectedIndex.Equals(0))
                Board_1_R1_State = "01";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(1))
                Board_1_R1_State = "02";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(2))
                Board_1_R1_State = "03";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(3))
                Board_1_R1_State = "04";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(4))
                Board_1_R1_State = "05";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(5))
                Board_1_R1_State = "06";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(6))
                Board_1_R1_State = "07";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(7))
                Board_1_R1_State = "08";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(8))
                Board_1_R1_State = "09";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(9))
                Board_1_R1_State = "10";
            else if (Brd_1_Res_Select.SelectedIndex.Equals(10))
                Board_1_R1_State = "11";
            else
                Board_1_R1_State = "10";

            //Call the message compiler
            Board_1_Compile_Serial_Message();
        }

        private void brd_1_ch1_gain_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (brd_1_ch1_gain.SelectedIndex.Equals(0))
                Board_1_Scope_Ch1_gain = "01";
            else
                Board_1_Scope_Ch1_gain = "10";

            //Call the message compiler
            Board_1_Compile_Serial_Message();
        }

        private void brd_1_ch_2_gain_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (brd_1_ch_2_gain.SelectedIndex.Equals(0))
                Board_1_Scope_Ch2_gain = "01";
            else
                Board_1_Scope_Ch2_gain = "10";

            //Call the message compiler
            Board_1_Compile_Serial_Message();
        }







        //Board 2 Subroutines 
        //Board_2: Serial Message Compiler
        //This subroutine takes the individual board_2 variables and
        //combines them into one string.
        void Board_2_Compile_Serial_Message()
        {
            Board_2_Serial_Message = "board_2," + Board_2_R1_State + "," +
                             Board_2_R2_State + "," +
                             Board_2_R3_State + "," +
                             Board_2_R4_State + "," +
                             Board_2_C1_State + "," +
                             Board_2_C2_State + "," +
                             Board_2_Scope_Ch1_gain + "," +
                             Board_2_Scope_Ch2_gain;
            //this statement exists exclusively for debuginng purposes
            Serial_Text_Test.Text = Board_2_Serial_Message;
            //Change the 'Send Data' button collor to orange, to indicate that
            //a change in the board configuration has occured.
            btn_Send_Config.BackColor = Color.Orange;
        }


        //Board_2: R1 control
        private void board_2_R1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_R1.SelectedIndex.Equals(0))
                Board_2_R1_State = "1";
            else if (board_2_R1.SelectedIndex.Equals(1))
                Board_2_R1_State = "2";
            else if (board_2_R1.SelectedIndex.Equals(2))
                Board_2_R1_State = "3";
            else if (board_2_R1.SelectedIndex.Equals(3))
                Board_2_R1_State = "4";
            else
                Board_2_R1_State = "5";


            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }


        //Board_2: R2 control
        private void board_2_R2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_R2.SelectedIndex.Equals(0))
                Board_2_R2_State = "1";
            else if (board_2_R2.SelectedIndex.Equals(1))
                Board_2_R2_State = "2";
            else if (board_2_R2.SelectedIndex.Equals(2))
                Board_2_R2_State = "3";
            else if (board_2_R2.SelectedIndex.Equals(3))
                Board_2_R2_State = "4";
            else
                Board_2_R2_State = "5";


            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }


        //Board_2: R3 control
        private void board_2_R3_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_R3.SelectedIndex.Equals(0))
                Board_2_R3_State = "1";
            else if (board_2_R3.SelectedIndex.Equals(1))
                Board_2_R3_State = "2";
            else if (board_2_R3.SelectedIndex.Equals(2))
                Board_2_R3_State = "3";
            else if (board_2_R3.SelectedIndex.Equals(3))
                Board_2_R3_State = "4";
            else
                Board_2_R3_State = "5";


            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }


        //Board_2: R4 control
        private void board_2_R4_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_R4.SelectedIndex.Equals(0))
                Board_2_R4_State = "1";
            else if (board_2_R4.SelectedIndex.Equals(1))
                Board_2_R4_State = "2";
            else if (board_2_R4.SelectedIndex.Equals(2))
                Board_2_R4_State = "3";
            else if (board_2_R4.SelectedIndex.Equals(3))
                Board_2_R4_State = "4";
            else
                Board_2_R4_State = "5";

            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }


        //Board_2: C1 control
        private void board_2_C1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_C1.SelectedIndex.Equals(0))
                Board_2_C1_State = "1";
            else if (board_2_C1.SelectedIndex.Equals(1))
                Board_2_C1_State = "2";
            else
                Board_2_C1_State = "3";

            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }


        //Board_2: C2 control
        private void board_2_C2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_C2.SelectedIndex.Equals(0))
                Board_2_C2_State = "1";
            else if (board_2_C2.SelectedIndex.Equals(1))
                Board_2_C2_State = "2";
            else
                Board_2_C2_State = "3";

            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }


        //Board_2: Ch1 gain control
        private void board_2_scope_ch_1_gain_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_scope_ch_1_gain.SelectedIndex.Equals(0))
                Board_2_Scope_Ch1_gain = "01";
            else
                Board_2_Scope_Ch1_gain = "10";

            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }

        private void board_2_scope_ch_2_gain_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (board_2_scope_ch_2_gain.SelectedIndex.Equals(0))
                Board_2_Scope_Ch2_gain = "01";
            else
                Board_2_Scope_Ch2_gain = "10";

            //Call the message compiler
            Board_2_Compile_Serial_Message();
        }






        //Board 3 Subroutines 
        //Board_3: Serial Message Compiler
        //This subroutine takes the individual board_3 variables and
        //combines them into one string.
        void Board_3_Compile_Serial_Message()
        {
            Board_3_Serial_Message = "board_3," +
                             (board_3_R2.SelectedIndex.Equals(0) ? "1" : 
                                board_3_R2.SelectedIndex.Equals(1) ? "2" :
                                board_3_R2.SelectedIndex.Equals(2) ? "3" : 
                                board_3_R2.SelectedIndex.Equals(2) ? "4" : "5") + 
                             "," +
                             (board_3_R3.SelectedIndex.Equals(0) ? "1" :
                                board_3_R3.SelectedIndex.Equals(1) ? "2" :
                                board_3_R3.SelectedIndex.Equals(2) ? "3" :
                                board_3_R3.SelectedIndex.Equals(2) ? "4" : "5");
            //this statement exists exclusively for debuginng purposes
            Serial_Text_Test.Text = Board_3_Serial_Message;
            //Change the 'Send Data' button color to orange, to indicate that
            //a change in the board configuration has occured.
            btn_Send_Config.BackColor = Color.Orange;
        }


        //Board 4 Subroutines 
        //Board_4: Serial Message Compiler
        //This subroutine takes the individual board_4 variables and
        //combines them into one string.
        void Board_4_Compile_Serial_Message()
        {
            Board_4_Serial_Message = "board_4," +
                             (board_4_R1.SelectedIndex.Equals(0) ? "1" :
                             board_4_R1.SelectedIndex.Equals(1) ? "2" :
                             board_4_R1.SelectedIndex.Equals(2) ? "3" : "4") + 
                             "," +
                             (board4_Diode1_RadioButton1.Checked.Equals(true) ? "1" : "0") + 
                             "," +
                             (board4_Diode2_RadioButton2.Checked.Equals(true) ? "1" : "0");
            //this statement exists exclusively for debuginng purposes
            Serial_Text_Test.Text = Board_4_Serial_Message;
            //Change the 'Send Data' button collor to orange, to indicate that
            //a change in the board configuration has occured.
            btn_Send_Config.BackColor = Color.Orange;
        }


        //Board 5 Subroutines 
        //Board_5: Serial Message Compiler
        //This subroutine takes the individual board_5 variables and
        //combines them into one string.
        void Board_5_Compile_Serial_Message()
        {
            Board_5_Serial_Message = "board_5," +
                             (board_5_R2.SelectedIndex.Equals(0) ? "1" : "0")+
                             "," +
                             (board_5_R3.SelectedIndex.Equals(0) ? "1" : "0") +
                             "," +
                             (board_5_C1.SelectedIndex.Equals(0) ? "1" : "0");
            //this statement exists exclusively for debuginng purposes
            Serial_Text_Test.Text = Board_5_Serial_Message;
            //Change the 'Send Data' button collor to orange, to indicate that
            //a change in the board configuration has occured.
            btn_Send_Config.BackColor = Color.Orange;
        }



        //Board 7 Subroutines
        //Board_7: Serial Message Compiler
        //This subroutine takes the individual board_7 variables and
        //combines them into one string.
        void Board_7_Compile_Serial_Message()
        {
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
            Board_7_Clear_All;
            //this statement exists exclusively for debuginng purposes
            Serial_Text_Test.Text = Board_7_Serial_Message;
            //Change the 'Send Data' button collor to orange, to indicate that
            //a change in the board configuration has occured.
            btn_Send_Config.BackColor = Color.Orange;
        }



        //Flipflop presets
        //Board 7: dff1 control
        private void board_7_PresetD1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD1.SelectedIndex.Equals(0))
                Board_7_Preset_D1_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff2 control
        private void board_7_PresetD2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD2.SelectedIndex.Equals(0))
                Board_7_Preset_D2_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff3 control
        private void board_7_PresetD3_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD3.SelectedIndex.Equals(0))
                Board_7_Preset_D3_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff4 control
        private void board_7_PresetD4_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD4.SelectedIndex.Equals(0))
                Board_7_Preset_D4_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff5 control
        private void board_7_PresetD5_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD5.SelectedIndex.Equals(0))
                Board_7_Preset_D5_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff6 control
        private void board_7_PresetD6_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD6.SelectedIndex.Equals(0))
                Board_7_Preset_D6_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff7 control
        private void board_7_PresetD7_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD7.SelectedIndex.Equals(0))
                Board_7_Preset_D7_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: dff8 control
        private void board_7_PresetD8_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (PresetD8.SelectedIndex.Equals(0))
                Board_7_Preset_D8_State = "1";
            else //if selected index is -1 or something weird, don't bother to recompile serial message
                return;

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Clock Connection Controls
        //Board 7: Clock control
        private void board7_ConnectClock_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectClock.Checked.Equals(true))
                Board_7_Clock_State = "1"; //Connect Clock
            else
                Board_7_Clock_State = "0"; //Bypass Clock

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        private void board7_DisconnectClock_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (DisconnectClock.Checked.Equals(true))
                Board_7_Clock_State = "0"; //Disconnect Clock
            else
                Board_7_Clock_State = "1"; //Connected Clock

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }




        //XOR Connection Controls
        //Board 7: XOR 1 control
        private void board7_ConnectXOR1_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR1.Checked.Equals(true))
                Board_7_Connect_XOR_1_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_1_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        private void board7_BypassXOR1_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR1.Checked.Equals(true))
                Board_7_Connect_XOR_1_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_1_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Board 7: XOR 2 control
        private void board7_ConnectXOR2_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR2.Checked.Equals(true))
                Board_7_Connect_XOR_2_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_2_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        private void board7_BypassXOR2_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR2.Checked.Equals(true))
                Board_7_Connect_XOR_2_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_2_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        //Board 7: XOR 3 control
        private void board7_ConnectXOR3_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR3.Checked.Equals(true))
                Board_7_Connect_XOR_3_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_3_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }

        private void board7_BypassXOR3_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR3.Checked.Equals(true))
                Board_7_Connect_XOR_3_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_3_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Board 7: XOR 4 control
        private void board7_ConnectXOR4_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR4.Checked.Equals(true))
                Board_7_Connect_XOR_4_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_4_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }
        
        private void board7_BypassXOR4_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR4.Checked.Equals(true))
                Board_7_Connect_XOR_4_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_4_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Board 7: XOR 5 control
        private void board7_ConnectXOR5_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR5.Checked.Equals(true))
                Board_7_Connect_XOR_5_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_5_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }
        
        private void board7_BypassXOR5_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR5.Checked.Equals(true))
                Board_7_Connect_XOR_5_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_5_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Board 7: XOR 6 control
        private void board7_ConnectXOR6_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR6.Checked.Equals(true))
                Board_7_Connect_XOR_6_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_6_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }
        
        private void board7_BypassXOR6_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR6.Checked.Equals(true))
                Board_7_Connect_XOR_6_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_6_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Board 7: XOR 7 control
        private void board7_ConnectXOR7_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (ConnectXOR7.Checked.Equals(true))
                Board_7_Connect_XOR_7_State = "0"; //Connect XOR
            else
                Board_7_Connect_XOR_7_State = "1"; //Bypass XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }
        
        private void board7_BypassXOR7_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (BypassXOR7.Checked.Equals(true))
                Board_7_Connect_XOR_7_State = "1"; //Bypass XOR
            else
                Board_7_Connect_XOR_7_State = "0"; //Connect XOR

            //Call the message compiler
            Board_7_Compile_Serial_Message();
        }


        //Set up behavior for the "Clear" checkbox, which resets all the DFF presets back to 0
        private void checkBoxChanged(System.Object sender, System.EventArgs e)
        {
            if (ClearCheckBox.Checked.Equals(true))  //User wants to clear all flipflops
            { //Send the signal to clear all flipflops
                Board_7_Clear_All = "1";
                //Change the serial message
                Board_7_Preset_D1_State = "0";
                Board_7_Preset_D2_State = "0";
                Board_7_Preset_D3_State = "0";
                Board_7_Preset_D4_State = "0";
                Board_7_Preset_D5_State = "0";
                Board_7_Preset_D6_State = "0";
                Board_7_Preset_D7_State = "0";
                Board_7_Preset_D8_State = "0";
                //Call the message compiler
                Board_7_Compile_Serial_Message();
                //Reset all the drop-down boxes to default
                PresetD1.SelectedIndex = -1;
                PresetD2.SelectedIndex = -1;
                PresetD3.SelectedIndex = -1;
                PresetD4.SelectedIndex = -1;
                PresetD5.SelectedIndex = -1;
                PresetD6.SelectedIndex = -1;
                PresetD7.SelectedIndex = -1;
                PresetD8.SelectedIndex = -1;
            }
            else
            {//User wants to make sure flipflops don't get cleared on next cycle
                Board_7_Clear_All = "0";
                //Call the message compiler
                Board_7_Compile_Serial_Message();
            }
        }



    
    private void PictureBox6_Click(Object sender, EventArgs e) { }



    private void Serial_Text_Test_TextChanged(Object sender, EventArgs e) { }

    

    private void Form1_Load(Object sender, EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Board7_Click(object sender, EventArgs e)
        {

        }

        private void Brd_1_Scope_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("LogicPort2").Length > 0)
            {
                MessageBox.Show("An instance of the LogicPort2.exe is already running");
            }
            else
            {
                Process.Start("C:/LogicPort2/LogicPort2.exe");
            }
        }

        private void ProgramSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Something is required here!");

            //e.Cancel = true;
            //this.WindowState = FormWindowState.Minimized;
            //var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            //psi.CreateNoWindow = true;
            //psi.UseShellExecute = false;
            //Process.Start(psi);
            foreach (var process in Process.GetProcessesByName("LogicPort"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("LogicPort2"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("PcLab2000LT"))
            {
                process.Kill();
            }


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //CommControlGroup.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Setup.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void CommControlGroup_Resize(object sender, EventArgs e)
        {

        }

        private void Setup_Resize(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }


}
