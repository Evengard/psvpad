// Decompiled with JetBrains decompiler
// Type: PSV_Server.PSVServer
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using PSV_Server.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PSV_Server
{
    public class PSVServer : Form
    {
        public static bool isConnected = false;
        public static uint lastButtonPressed = 0;
        public static Dictionary<uint, Button> buttonDict = new Dictionary<uint, Button>();
        private Dictionary<uint, Panel> subPanelDictionary = new Dictionary<uint, Panel>();
        private Point panel_Position = new Point(0, 30);
        private Point panel_Hidden = new Point(0, 310);
        private int slideDelta = 1;
        public string ipAddress;
        private Keyboard keyboard;
        private Panel current_Panel;
        private IContainer components;
        private Label pciplbl;
        private Label ipLable;
        private Label label2;
        public Label Status;
        private Button Button_Main;
        private Button Button_Key_Binds;
        private Button Button_Help;
        private Button Button_Config;
        private Button Button_Wifi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openConfigToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button Info_Button;
        private Panel Main_Panel;
        private Label Label_Title_1;
        private RichTextBox richTextBox1;
        private Panel Binds_Panel;
        private Button Button_DUp;
        private Button Button_R;
        private Button Button_L;
        private Button Button_DDown;
        private Button Button_DRight;
        private Button Button_DLeft;
        private Button Button_LADown;
        private Button Button_LARight;
        private Button Button_LALeft;
        private Button Button_LAUp;
        private Button Button_Cross;
        private Button Button_Circle;
        private Button Button_Square;
        private Button Button_Triangle;
        private Button Button_Start;
        private Button Button_Select;
        private Button Button_RADown;
        private Button Button_RARight;
        private Button Button_RALeft;
        private Button Button_RAUp;
        private Panel Vita_Panel;
        private Button Button_Front;
        private Button Button_Joy;
        private Button Button_List;
        private Panel panel1;
        private Panel BindList_Panel;
        private Label DEvLbl;
        private Panel JoyBind_Panel;
        private Label label1;
        private Panel Config_Panel;
        private Panel Help_Panel;
        private Panel Console_Panel;
        private Timer RefreshTimer;
        private GroupBox GyroscopeSettings;
        private TrackBar GyroXDeadZone_Slider;
        private Label GyroDeadZoneLblX;
        private Label AxisEnableLbl;
        private CheckBox GyroAxisYCheckBox;
        private CheckBox GyroAxisZCheckBox;
        private CheckBox GyroAxisXCheckBox;
        private Label ConfigLbl;
        private Label PercentLbl;
        private PictureBox GyroXAxisVisual;
        private PictureBox GyroYAxisVisual;
        private Label PercentLbl2;
        private Label GyroYDeadZoneLbl;
        private TrackBar GyroYDeadZone_Slider;
        private Label GyroDeadZoneLblY;
        private PictureBox GyroZAxisVisual;
        private Label label3;
        private Label GyroZDeadZoneLbl;
        private TrackBar GyroZDeadZone_Slider;
        private Label AxisZDeadZoneLbl;
        private GroupBox AxisSettings;
        private Label label9;
        private PictureBox LeftStickXAxis;
        private Label label10;
        private Label LeftStickDeadZoneLbl;
        private TrackBar LeftStickDeadZone_Slider;
        private Label label12;
        private GroupBox groupBox1;
        private ToolTip BindInfoToolTip;
        private GroupBox GeneralSettingsGroup;
        private Label label16;
        private Label KeyRepeatLbl;
        private Label MouseSpeedLbl;
        private ToolTip AllTips;
        private TrackBar MouseSpeed_Slider;
        private Label label17;
        private TrackBar KeyRepeat_Slider;
        private Label label18;
        private Label MSLbl;
        private Label label19;
        private NumericUpDown KeyRepeatDelay_Box;
        private NumericUpDown MouseSpeedBox;
        private NumericUpDown ClientTimeOut_Box;
        private GroupBox groupBox2;
        private PictureBox RightStickYAxis;
        private Label label4;
        private Label label5;
        private Label RightStickDeadZoneLbl;
        private Label label8;
        private PictureBox RightStickXAxis;
        private Label label13;
        private TrackBar RightStickDeadZone_Slider;
        private PictureBox LeftStickYAxis;
        private Label label7;
        private Label GyroXDeadZoneLbl;
        private PictureBox PSV_Picture;
        private Button Button_Gyro;
        private Button Button_Back;
        private Button Button_Additional;
        private Panel Back_Panel;
        private Button BackRightDownBtn;
        private Button BackLeftDownBtn;
        private PictureBox VitaBackImage;
        private TextBox ProfileNameTxt;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Button DeleteProfileBtn;
        private Panel Gyro_Panel;
        private Panel Additional_Panel;
        private Label label11;
        private Button B14Btn;
        private Button B13Btn;
        private Button B12Btn;
        private Button B11Btn;
        private Button B10Btn;
        private Button B9Btn;
        private Button B8Btn;
        private Button B7Btn;
        private Button B6Btn;
        private Button B5Btn;
        private Button B4Btn;
        private Button B3Btn;
        private Button B2Btn;
        private Button B1Btn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label15;
        private Label label14;
        private Label label6;
        private Button GyroZPosBtn;
        private Button GyroZNegBtn;
        private Button GyroYPosBtn;
        private Button GyroYNegBtn;
        private Button GyroXPosBtn;
        private Button GyroXNegBtn;
        private Label label23;
        private RichTextBox richTextBox2;
        private Panel ConnectionStatusPanel;
        public Label Status1;
        private Button ClearBinds;

        public static void refresh()
        {
            Program.serverForm.Invalidate();
        }

        public PSVServer()
        {
            this.InitializeComponent();
            this.Vita_Panel.Parent = (Control)this.Binds_Panel;
            this.JoyBind_Panel.Parent = (Control)this.Binds_Panel;
            this.BindList_Panel.Parent = (Control)this.Binds_Panel;
            this.Back_Panel.Parent = (Control)this.Binds_Panel;
            this.Additional_Panel.Parent = (Control)this.Binds_Panel;
            this.Gyro_Panel.Parent = (Control)this.Binds_Panel;
            this.Vita_Panel.Location = new Point(100, 0);
            this.JoyBind_Panel.Location = new Point(100, 0);
            this.BindList_Panel.Location = new Point(100, 0);
            this.Back_Panel.Location = new Point(100, 0);
            this.Additional_Panel.Location = new Point(100, 0);
            this.Gyro_Panel.Location = new Point(100, 0);
            this.initButtDictionary();
            this.initSubPanels();
            this.Size = new Size(655, 385);
            this.keyboard = new Keyboard();
            this.keyboard.FormClosed += (FormClosedEventHandler)((sender, e) => this.keyboard = (Keyboard)null);
        }

        private void initButtDictionary()
        {
            PSVServer.buttonDict.Add(1024U, this.Button_L);
            PSVServer.buttonDict.Add(2048U, this.Button_R);
            PSVServer.buttonDict.Add(32U, this.Button_Triangle);
            PSVServer.buttonDict.Add(16U, this.Button_Square);
            PSVServer.buttonDict.Add(64U, this.Button_Circle);
            PSVServer.buttonDict.Add(128U, this.Button_Cross);
            PSVServer.buttonDict.Add(2U, this.Button_DUp);
            PSVServer.buttonDict.Add(8U, this.Button_DDown);
            PSVServer.buttonDict.Add(1U, this.Button_DLeft);
            PSVServer.buttonDict.Add(4U, this.Button_DRight);
            PSVServer.buttonDict.Add(256U, this.Button_Start);
            PSVServer.buttonDict.Add(512U, this.Button_Select);
            PSVServer.buttonDict.Add(262144U, this.B1Btn);
            PSVServer.buttonDict.Add(524288U, this.B2Btn);
            PSVServer.buttonDict.Add(1048576U, this.B3Btn);
            PSVServer.buttonDict.Add(2097152U, this.B4Btn);
            PSVServer.buttonDict.Add(4194304U, this.B5Btn);
            PSVServer.buttonDict.Add(8388608U, this.B6Btn);
            PSVServer.buttonDict.Add(16777216U, this.B7Btn);
            PSVServer.buttonDict.Add(33554432U, this.B8Btn);
            PSVServer.buttonDict.Add(67108864U, this.B9Btn);
            PSVServer.buttonDict.Add(134217728U, this.B10Btn);
            PSVServer.buttonDict.Add(268435456U, this.B11Btn);
            PSVServer.buttonDict.Add(536870912U, this.B12Btn);
            PSVServer.buttonDict.Add(1073741824U, this.B13Btn);
            PSVServer.buttonDict.Add(4096U, this.B14Btn);
            PSVServer.buttonDict.Add(3U, this.Button_LAUp);
            PSVServer.buttonDict.Add(5U, this.Button_LADown);
            PSVServer.buttonDict.Add(7U, this.Button_LALeft);
            PSVServer.buttonDict.Add(6U, this.Button_LARight);
            PSVServer.buttonDict.Add(9U, this.Button_RAUp);
            PSVServer.buttonDict.Add(10U, this.Button_RADown);
            PSVServer.buttonDict.Add(12U, this.Button_RALeft);
            PSVServer.buttonDict.Add(11U, this.Button_RARight);
            PSVServer.buttonDict.Add(22U, this.BackLeftDownBtn);
            PSVServer.buttonDict.Add(26U, this.BackRightDownBtn);
            PSVServer.buttonDict.Add(34U, this.GyroXNegBtn);
            PSVServer.buttonDict.Add(33U, this.GyroXPosBtn);
            PSVServer.buttonDict.Add(36U, this.GyroYNegBtn);
            PSVServer.buttonDict.Add(35U, this.GyroYPosBtn);
            PSVServer.buttonDict.Add(38U, this.GyroZNegBtn);
            PSVServer.buttonDict.Add(37U, this.GyroZPosBtn);
        }

        private void initSubPanels()
        {
            this.subPanelDictionary.Add(1U, this.Vita_Panel);
            this.subPanelDictionary.Add(2U, this.Back_Panel);
            this.subPanelDictionary.Add(3U, this.Gyro_Panel);
            this.subPanelDictionary.Add(4U, this.Additional_Panel);
            this.subPanelDictionary.Add(5U, this.BindList_Panel);
            this.subPanelDictionary.Add(6U, this.JoyBind_Panel);
        }

        private void PSVServer_Load(object sender, EventArgs e)
        {
            this.RefreshTimer.Enabled = true;
            this.ResumeLayout();
            RefreshIp();
        }

        private void RefreshIp()
        {
            this.ipLable.Text = ipAddress;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void PSVServer_Paint(object sender, PaintEventArgs e)
        {
            if (PSVServer.isConnected)
            {
                this.Status.Text = "CONNECTED";
                this.Status.ForeColor = Color.Green;
                this.Status1.Text = "CONNECTED";
                this.Status1.ForeColor = Color.Green;
            }
            else
            {
                this.Status.Text = "DISCONNECTED";
                this.Status.ForeColor = Color.Red;
                this.Status1.Text = "DISCONNECTED";
                this.Status1.ForeColor = Color.Red;
            }
            RefreshIp();
        }

        private void Button_L_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 1024U;
            this.openKeyboard();
        }

        private void openKeyboard()
        {
            if (this.keyboard != null)
            {
                this.keyboard.Show();
            }
            else
            {
                this.keyboard = new Keyboard();
                this.keyboard.FormClosed += (FormClosedEventHandler)((sender, e) => this.keyboard = (Keyboard)null);
                this.keyboard.Show();
            }
        }

        private void closeKeyboard()
        {
            this.keyboard.Close();
        }

        private void Button_R_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 2048U;
            this.openKeyboard();
        }

        private void Button_Triangle_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 32U;
            this.openKeyboard();
        }

        private void Button_Circle_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 64U;
            this.openKeyboard();
        }

        private void Button_Cross_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 128U;
            this.openKeyboard();
        }

        private void Button_Square_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 16U;
            this.openKeyboard();
        }

        private void Button_DUp_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 2U;
            this.openKeyboard();
        }

        private void Button_DLeft_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 1U;
            this.openKeyboard();
        }

        private void Button_DRight_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 4U;
            this.openKeyboard();
        }

        private void Button_DDown_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 8U;
            this.openKeyboard();
        }

        private void Button_Select_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 512U;
            this.openKeyboard();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 256U;
            this.openKeyboard();
        }

        private void Button_LAUp_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 3U;
            this.openKeyboard();
        }

        private void Button_LADown_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 5U;
            this.openKeyboard();
        }

        private void ButtonLALeft_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 7U;
            this.openKeyboard();
        }

        private void ButtonLARight_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 6U;
            this.openKeyboard();
        }

        private void Button_RAUp_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 9U;
            this.openKeyboard();
        }

        private void Button_RADown_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 10U;
            this.openKeyboard();
        }

        private void Button_RALeft_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 12U;
            this.openKeyboard();
        }

        private void Button_RARight_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 11U;
            this.openKeyboard();
        }

        private void Set_Panel(Panel _Panel)
        {
            this.SuspendLayout();
            if (_Panel == this.current_Panel)
                return;
            if (this.current_Panel != null)
            {
                this.current_Panel.Location = this.panel_Hidden;
                this.current_Panel.Visible = false;
            }
            if (!_Panel.Visible)
                _Panel.Visible = true;
            _Panel.Size = new Size(650, 280);
            _Panel.Location = this.panel_Position;
            this.current_Panel = _Panel;
            this.ResumeLayout();
        }

        private void fadeIn_CallBack(object State)
        {
            this.SuspendLayout();
            Panel panel = (Panel)State;
            if (!(panel.Location != this.panel_Position))
                return;
            int x = panel.Location.X;
            int y = panel.Location.Y;
            if (panel.Location.X != this.panel_Position.X)
            {
                if (panel.Location.X > this.panel_Position.X)
                    x -= 10;
                else
                    x += 10;
            }
            if (panel.Location.Y != this.panel_Position.Y)
            {
                if (panel.Location.Y > this.panel_Position.Y)
                    y -= 10 * this.slideDelta;
                else
                    y += 10 * this.slideDelta;
            }
            panel.Location = new Point(x, y);
            panel.Refresh();
            this.ResumeLayout();
        }

        private void Button_Main_Click(object sender, EventArgs e)
        {
            this.Set_Panel(this.Main_Panel);
        }

        private void Button_Key_Binds_Click(object sender, EventArgs e)
        {
            this.Set_Panel(this.Binds_Panel);
        }

        private void Set_Sub_Panel(uint PanelID)
        {
            this.SuspendLayout();
            foreach (KeyValuePair<uint, Panel> subPanel in this.subPanelDictionary)
                subPanel.Value.Visible = false;
            if (this.subPanelDictionary.ContainsKey(PanelID))
                this.subPanelDictionary[PanelID].Visible = true;
            this.ResumeLayout();
        }

        private void Button_Visual_Click(object sender, EventArgs e)
        {
            this.Set_Sub_Panel(1U);
        }

        private void Button_List_Click(object sender, EventArgs e)
        {
            this.Set_Sub_Panel(5U);
        }

        private void Button_Joy_Click(object sender, EventArgs e)
        {
            this.Set_Sub_Panel(6U);
        }

        private void Console_Button_Click(object sender, EventArgs e)
        {
            this.Set_Panel(this.Console_Panel);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            this.GyroXAxisVisual.Refresh();
            this.GyroYAxisVisual.Refresh();
            this.GyroZAxisVisual.Refresh();
            this.LeftStickXAxis.Refresh();
            this.LeftStickYAxis.Refresh();
            this.RightStickXAxis.Refresh();
            this.RightStickYAxis.Refresh();
        }

        private void Button_Config_Click(object sender, EventArgs e)
        {
            this.Set_Panel(this.Config_Panel);
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            this.Set_Panel(this.Help_Panel);
        }

        private void GyroXDeadZone_Slider_Scroll(object sender, EventArgs e)
        {
            this.GyroXDeadZoneLbl.Text = ((float)this.GyroXDeadZone_Slider.Value / 10f).ToString();
            Program.PSVServer.config.gyroXDeadZone = (float)this.GyroXDeadZone_Slider.Value / 1000f;
        }

        private void AxisBarCustomPaint_Event(
          object Sender,
          PaintEventArgs e,
          float DeadZone,
          float AxisValue)
        {
            this.OnPaint(e);
            Brush brush = (double)AxisValue > (double)DeadZone || (double)AxisValue < -(double)DeadZone ? (Brush)new SolidBrush(Color.Green) : (Brush)new SolidBrush(Color.Red);
            Point point = new Point(0, 0);
            point.X = e.ClipRectangle.Width / 2;
            point.Y = e.ClipRectangle.Height / 2;
            if ((double)AxisValue > 0.0)
                e.Graphics.FillRectangle(brush, new Rectangle(point.X, 0, (int)((double)point.X * (double)AxisValue), e.ClipRectangle.Height));
            else
                e.Graphics.FillRectangle(brush, new Rectangle(point.X + (int)((double)point.X * (double)AxisValue), 0, -(int)((double)point.X * (double)AxisValue), e.ClipRectangle.Height));
            this.Invalidate();
        }

        private void GyroXAxisVisual_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null && Program.PSVServer.config.gyroXEnabled)
                AxisValue = Program.PSVServer.data.motionX;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.GyroXDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void GyroYDeadZone_Slider_Scroll(object sender, EventArgs e)
        {
            this.GyroYDeadZoneLbl.Text = ((float)this.GyroYDeadZone_Slider.Value / 10f).ToString();
            Program.PSVServer.config.gyroYDeadZone = (float)this.GyroYDeadZone_Slider.Value / 1000f;
        }

        private void GyroZDeadZone_Slider_Scroll(object sender, EventArgs e)
        {
            this.GyroZDeadZoneLbl.Text = ((float)this.GyroZDeadZone_Slider.Value / 10f).ToString();
            Program.PSVServer.config.gyroZDeadZone = (float)this.GyroZDeadZone_Slider.Value / 1000f;
        }

        private void GyroYAxisVisual_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null && Program.PSVServer.config.gyroYEnabled)
                AxisValue = Program.PSVServer.data.motionY;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.GyroYDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void GyroZAxisVisual_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null && Program.PSVServer.config.gyroZEnabled)
                AxisValue = Program.PSVServer.data.motionZ;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.GyroZDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void PSVServer_Move(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.RefreshTimer.Enabled = false;
        }

        private void PSVServer_ResizeEnd(object sender, EventArgs e)
        {
            this.ResumeLayout();
            this.RefreshTimer.Enabled = true;
        }

        private void BindInfoToolTip_Popup(object sender, PopupEventArgs e)
        {
        }

        private void BindInfoToolTip_CustomHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.BindInfoToolTip.SetToolTip((Control)button, button.Text);
        }

        private void ClientTimeOut_Box_ValueChanged(object sender, EventArgs e)
        {
            Program.PSVServer.config.clientTimeOut = (uint)this.ClientTimeOut_Box.Value;
        }

        private void GyroAxisXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.PSVServer.config.gyroXEnabled = this.GyroAxisXCheckBox.Checked;
        }

        private void GyroAxisYCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.PSVServer.config.gyroYEnabled = this.GyroAxisYCheckBox.Checked;
        }

        private void GyroAxisZCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.PSVServer.config.gyroZEnabled = this.GyroAxisZCheckBox.Checked;
        }

        private void KeyRepeatDelay_Box_ValueChanged(object sender, EventArgs e)
        {
            Program.PSVServer.config.keyRepeatDelayMS = (uint)this.KeyRepeatDelay_Box.Value;
        }

        private void MouseSpeed_Slider_Scroll(object sender, EventArgs e)
        {
            this.MouseSpeedBox.Value = (Decimal)this.MouseSpeed_Slider.Value;
        }

        private void KeyRepeat_Slider_Scroll(object sender, EventArgs e)
        {
            this.KeyRepeatDelay_Box.Value = (Decimal)this.KeyRepeat_Slider.Value;
        }

        private void LeftStickDeadZone_Slider_Scroll(object sender, EventArgs e)
        {
            Program.PSVServer.config.LSDeadZone = (float)this.LeftStickDeadZone_Slider.Value / 1000f;
            this.LeftStickDeadZoneLbl.Text = ((float)this.LeftStickDeadZone_Slider.Value / 10f).ToString();
        }

        private void RightStickDeadZone_Slider_Scroll(object sender, EventArgs e)
        {
            Program.PSVServer.config.RSDeadZone = (float)this.RightStickDeadZone_Slider.Value / 1000f;
            this.RightStickDeadZoneLbl.Text = ((float)this.RightStickDeadZone_Slider.Value / 10f).ToString();
        }

        private void LeftStickXAxis_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null)
                AxisValue = Program.PSVServer.data.lx;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.LeftStickDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void LeftStickYAxis_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null)
                AxisValue = Program.PSVServer.data.ly;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.LeftStickDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void RightStickXAxis_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null)
                AxisValue = Program.PSVServer.data.rx;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.RightStickDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void RightStickYAxis_Paint(object sender, PaintEventArgs e)
        {
            float AxisValue = 0.0f;
            if (Program.PSVServer.data != null)
                AxisValue = Program.PSVServer.data.ry;
            this.AxisBarCustomPaint_Event(sender, e, (float)this.RightStickDeadZone_Slider.Value / 1000f, AxisValue);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Set_Sub_Panel(2U);
        }

        private void Button_Gyro_Click(object sender, EventArgs e)
        {
            this.Set_Sub_Panel(3U);
        }

        private void Button_Additional_Click(object sender, EventArgs e)
        {
            this.Set_Sub_Panel(4U);
        }

        private void BackLeftDownBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 22U;
            this.openKeyboard();
        }

        private void BackRightDownBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 26U;
            this.openKeyboard();
        }

        private void B13Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 1073741824U;
            this.openKeyboard();
        }

        private void B14Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 4096U;
            this.openKeyboard();
        }

        private void B1Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 262144U;
            this.openKeyboard();
        }

        private void B2Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 524288U;
            this.openKeyboard();
        }

        private void B3Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 1048576U;
            this.openKeyboard();
        }

        private void B4Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 2097152U;
            this.openKeyboard();
        }

        private void B5Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 4194304U;
            this.openKeyboard();
        }

        private void B6Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 8388608U;
            this.openKeyboard();
        }

        private void B7Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 16777216U;
            this.openKeyboard();
        }

        private void B8Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 33554432U;
            this.openKeyboard();
        }

        private void B9Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 67108864U;
            this.openKeyboard();
        }

        private void B10Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 134217728U;
            this.openKeyboard();
        }

        private void B11Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 268435456U;
            this.openKeyboard();
        }

        private void B12Btn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 536870912U;
            this.openKeyboard();
        }

        private void Vita_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Gyro_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.keyboard.Close();
            Program.CloseApplication();
        }

        private void GyroXNegBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 34U;
            this.openKeyboard();
        }

        private void GyroYNegBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 36U;
            this.openKeyboard();
        }

        private void GyroZNegBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 38U;
            this.openKeyboard();
        }

        private void GyroXPosBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 33U;
            this.openKeyboard();
        }

        private void GyroYPosBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 35U;
            this.openKeyboard();
        }

        private void GyroZPosBtn_Click(object sender, EventArgs e)
        {
            PSVServer.lastButtonPressed = 37U;
            this.openKeyboard();
        }

        private void Button_Wifi_Click(object sender, EventArgs e)
        {
            this.ConnectionStatusPanel.Location = new Point(450, 265);
            this.ConnectionStatusPanel.Visible = !this.ConnectionStatusPanel.Visible;
        }

        private void ClearBinds_Click(object sender, EventArgs e)
        {
            Program.PSVServer.clearAllBinds();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PSVServer));
            this.pciplbl = new Label();
            this.ipLable = new Label();
            this.label2 = new Label();
            this.Status = new Label();
            this.Button_Main = new Button();
            this.Button_Key_Binds = new Button();
            this.Button_Help = new Button();
            this.Button_Config = new Button();
            this.Button_Wifi = new Button();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.saveToolStripMenuItem = new ToolStripMenuItem();
            this.openConfigToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.Info_Button = new Button();
            this.Main_Panel = new Panel();
            this.richTextBox1 = new RichTextBox();
            this.Label_Title_1 = new Label();
            this.Binds_Panel = new Panel();
            this.ClearBinds = new Button();
            this.panel1 = new Panel();
            this.Button_Additional = new Button();
            this.Button_Gyro = new Button();
            this.Button_Back = new Button();
            this.Button_Front = new Button();
            this.Button_Joy = new Button();
            this.Button_List = new Button();
            this.Button_RADown = new Button();
            this.Button_RARight = new Button();
            this.Button_RALeft = new Button();
            this.Button_RAUp = new Button();
            this.Button_Start = new Button();
            this.Button_Select = new Button();
            this.Button_LADown = new Button();
            this.Button_LARight = new Button();
            this.Button_LALeft = new Button();
            this.Button_LAUp = new Button();
            this.Button_Cross = new Button();
            this.Button_Circle = new Button();
            this.Button_Square = new Button();
            this.Button_Triangle = new Button();
            this.Button_DDown = new Button();
            this.Button_DRight = new Button();
            this.Button_DLeft = new Button();
            this.Button_R = new Button();
            this.Button_L = new Button();
            this.Button_DUp = new Button();
            this.Vita_Panel = new Panel();
            this.PSV_Picture = new PictureBox();
            this.BindList_Panel = new Panel();
            this.DEvLbl = new Label();
            this.JoyBind_Panel = new Panel();
            this.label1 = new Label();
            this.Config_Panel = new Panel();
            this.label16 = new Label();
            this.GeneralSettingsGroup = new GroupBox();
            this.KeyRepeat_Slider = new TrackBar();
            this.label19 = new Label();
            this.KeyRepeatDelay_Box = new NumericUpDown();
            this.MouseSpeedBox = new NumericUpDown();
            this.ClientTimeOut_Box = new NumericUpDown();
            this.MSLbl = new Label();
            this.label18 = new Label();
            this.KeyRepeatLbl = new Label();
            this.MouseSpeedLbl = new Label();
            this.MouseSpeed_Slider = new TrackBar();
            this.label17 = new Label();
            this.AxisSettings = new GroupBox();
            this.groupBox2 = new GroupBox();
            this.RightStickYAxis = new PictureBox();
            this.label4 = new Label();
            this.label5 = new Label();
            this.RightStickDeadZoneLbl = new Label();
            this.label8 = new Label();
            this.RightStickXAxis = new PictureBox();
            this.label13 = new Label();
            this.RightStickDeadZone_Slider = new TrackBar();
            this.groupBox1 = new GroupBox();
            this.LeftStickYAxis = new PictureBox();
            this.label7 = new Label();
            this.label12 = new Label();
            this.LeftStickDeadZoneLbl = new Label();
            this.label10 = new Label();
            this.LeftStickXAxis = new PictureBox();
            this.label9 = new Label();
            this.LeftStickDeadZone_Slider = new TrackBar();
            this.GyroscopeSettings = new GroupBox();
            this.GyroZAxisVisual = new PictureBox();
            this.label3 = new Label();
            this.GyroZDeadZoneLbl = new Label();
            this.GyroZDeadZone_Slider = new TrackBar();
            this.AxisZDeadZoneLbl = new Label();
            this.GyroYAxisVisual = new PictureBox();
            this.PercentLbl2 = new Label();
            this.GyroYDeadZoneLbl = new Label();
            this.GyroYDeadZone_Slider = new TrackBar();
            this.GyroDeadZoneLblY = new Label();
            this.GyroXAxisVisual = new PictureBox();
            this.PercentLbl = new Label();
            this.GyroXDeadZoneLbl = new Label();
            this.GyroXDeadZone_Slider = new TrackBar();
            this.GyroDeadZoneLblX = new Label();
            this.AxisEnableLbl = new Label();
            this.GyroAxisYCheckBox = new CheckBox();
            this.GyroAxisZCheckBox = new CheckBox();
            this.GyroAxisXCheckBox = new CheckBox();
            this.ConfigLbl = new Label();
            this.Help_Panel = new Panel();
            this.richTextBox2 = new RichTextBox();
            this.Console_Panel = new Panel();
            this.label22 = new Label();
            this.label23 = new Label();
            this.label21 = new Label();
            this.label20 = new Label();
            this.RefreshTimer = new Timer(this.components);
            this.BindInfoToolTip = new ToolTip(this.components);
            this.AllTips = new ToolTip(this.components);
            this.button1 = new Button();
            this.button2 = new Button();
            this.ProfileNameTxt = new TextBox();
            this.DeleteProfileBtn = new Button();
            this.Status1 = new Label();
            this.Back_Panel = new Panel();
            this.BackRightDownBtn = new Button();
            this.BackLeftDownBtn = new Button();
            this.VitaBackImage = new PictureBox();
            this.comboBox1 = new ComboBox();
            this.Gyro_Panel = new Panel();
            this.label15 = new Label();
            this.label14 = new Label();
            this.label6 = new Label();
            this.GyroZPosBtn = new Button();
            this.GyroZNegBtn = new Button();
            this.GyroYPosBtn = new Button();
            this.GyroYNegBtn = new Button();
            this.GyroXPosBtn = new Button();
            this.GyroXNegBtn = new Button();
            this.pictureBox2 = new PictureBox();
            this.Additional_Panel = new Panel();
            this.B14Btn = new Button();
            this.B13Btn = new Button();
            this.B12Btn = new Button();
            this.B11Btn = new Button();
            this.B10Btn = new Button();
            this.B9Btn = new Button();
            this.B8Btn = new Button();
            this.B7Btn = new Button();
            this.B6Btn = new Button();
            this.B5Btn = new Button();
            this.B4Btn = new Button();
            this.B3Btn = new Button();
            this.B2Btn = new Button();
            this.B1Btn = new Button();
            this.pictureBox1 = new PictureBox();
            this.label11 = new Label();
            this.ConnectionStatusPanel = new Panel();
            this.menuStrip1.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.Binds_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Vita_Panel.SuspendLayout();
            ((ISupportInitialize)this.PSV_Picture).BeginInit();
            this.BindList_Panel.SuspendLayout();
            this.JoyBind_Panel.SuspendLayout();
            this.Config_Panel.SuspendLayout();
            this.GeneralSettingsGroup.SuspendLayout();
            this.KeyRepeat_Slider.BeginInit();
            this.KeyRepeatDelay_Box.BeginInit();
            this.MouseSpeedBox.BeginInit();
            this.ClientTimeOut_Box.BeginInit();
            this.MouseSpeed_Slider.BeginInit();
            this.AxisSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize)this.RightStickYAxis).BeginInit();
            ((ISupportInitialize)this.RightStickXAxis).BeginInit();
            this.RightStickDeadZone_Slider.BeginInit();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.LeftStickYAxis).BeginInit();
            ((ISupportInitialize)this.LeftStickXAxis).BeginInit();
            this.LeftStickDeadZone_Slider.BeginInit();
            this.GyroscopeSettings.SuspendLayout();
            ((ISupportInitialize)this.GyroZAxisVisual).BeginInit();
            this.GyroZDeadZone_Slider.BeginInit();
            ((ISupportInitialize)this.GyroYAxisVisual).BeginInit();
            this.GyroYDeadZone_Slider.BeginInit();
            ((ISupportInitialize)this.GyroXAxisVisual).BeginInit();
            this.GyroXDeadZone_Slider.BeginInit();
            this.Help_Panel.SuspendLayout();
            this.Console_Panel.SuspendLayout();
            this.Back_Panel.SuspendLayout();
            ((ISupportInitialize)this.VitaBackImage).BeginInit();
            this.Gyro_Panel.SuspendLayout();
            ((ISupportInitialize)this.pictureBox2).BeginInit();
            this.Additional_Panel.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.ConnectionStatusPanel.SuspendLayout();
            this.SuspendLayout();
            this.pciplbl.AutoSize = true;
            this.pciplbl.BackColor = Color.Transparent;
            this.pciplbl.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.pciplbl.ForeColor = Color.White;
            this.pciplbl.Location = new Point(6, 161);
            this.pciplbl.Margin = new Padding(4, 0, 4, 0);
            this.pciplbl.Name = "pciplbl";
            this.pciplbl.Size = new Size(131, 29);
            this.pciplbl.TabIndex = 0;
            this.pciplbl.Text = "Server IP: ";
            this.ipLable.AutoSize = true;
            this.ipLable.BackColor = Color.Transparent;
            this.ipLable.BorderStyle = BorderStyle.FixedSingle;
            this.ipLable.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.ipLable.ForeColor = Color.RoyalBlue;
            this.ipLable.Location = new Point(145, 161);
            this.ipLable.Margin = new Padding(4, 0, 4, 0);
            this.ipLable.Name = "ipLable";
            this.ipLable.Size = new Size(148, 31);
            this.ipLable.TabIndex = 1;
            this.ipLable.Text = "192.168.0.0";
            this.AllTips.SetToolTip((Control)this.ipLable, "This is your IP Address, this is the address you will use to connect to the server");
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label2.ForeColor = SystemColors.ButtonFace;
            this.label2.Location = new Point(6, 209);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(107, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status: ";
            this.Status.AutoSize = true;
            this.Status.BackColor = Color.Transparent;
            this.Status.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Status.ForeColor = Color.Red;
            this.Status.Location = new Point(140, 213);
            this.Status.Margin = new Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new Size(184, 25);
            this.Status.TabIndex = 6;
            this.Status.Text = "DISCONNECTED";
            this.AllTips.SetToolTip((Control)this.Status, "This is your connection status");
            this.Button_Main.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Main.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Main.FlatAppearance.BorderColor = Color.Black;
            this.Button_Main.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Main.FlatStyle = FlatStyle.Flat;
            this.Button_Main.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Main.ForeColor = SystemColors.AppWorkspace;
            this.Button_Main.Location = new Point(0, 310);
            this.Button_Main.Name = "Button_Main";
            this.Button_Main.Size = new Size(141, 44);
            this.Button_Main.TabIndex = 7;
            this.Button_Main.Text = "Main";
            this.Button_Main.UseVisualStyleBackColor = false;
            this.Button_Main.Click += new EventHandler(this.Button_Main_Click);
            this.Button_Key_Binds.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Key_Binds.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Key_Binds.FlatAppearance.BorderColor = Color.Black;
            this.Button_Key_Binds.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Key_Binds.FlatStyle = FlatStyle.Flat;
            this.Button_Key_Binds.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Key_Binds.ForeColor = SystemColors.AppWorkspace;
            this.Button_Key_Binds.Location = new Point(135, 310);
            this.Button_Key_Binds.Name = "Button_Key_Binds";
            this.Button_Key_Binds.Size = new Size(141, 44);
            this.Button_Key_Binds.TabIndex = 8;
            this.Button_Key_Binds.Text = "Key Binds";
            this.AllTips.SetToolTip((Control)this.Button_Key_Binds, "Bind vita controls to key events in windows");
            this.Button_Key_Binds.UseVisualStyleBackColor = false;
            this.Button_Key_Binds.Click += new EventHandler(this.Button_Key_Binds_Click);
            this.Button_Help.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Help.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Help.FlatAppearance.BorderColor = Color.Black;
            this.Button_Help.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Help.FlatStyle = FlatStyle.Flat;
            this.Button_Help.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Help.ForeColor = SystemColors.AppWorkspace;
            this.Button_Help.Location = new Point(412, 310);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new Size(141, 44);
            this.Button_Help.TabIndex = 9;
            this.Button_Help.Text = "Help";
            this.AllTips.SetToolTip((Control)this.Button_Help, "NEED HELP?");
            this.Button_Help.UseVisualStyleBackColor = false;
            this.Button_Help.Click += new EventHandler(this.Button_Help_Click);
            this.Button_Config.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Config.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Config.FlatAppearance.BorderColor = Color.Black;
            this.Button_Config.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Config.FlatStyle = FlatStyle.Flat;
            this.Button_Config.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Config.ForeColor = SystemColors.AppWorkspace;
            this.Button_Config.Location = new Point(272, 310);
            this.Button_Config.Name = "Button_Config";
            this.Button_Config.Size = new Size(141, 44);
            this.Button_Config.TabIndex = 10;
            this.Button_Config.Text = "Configuration";
            this.AllTips.SetToolTip((Control)this.Button_Config, "Configuration Panel - Used for configuring the server software");
            this.Button_Config.UseVisualStyleBackColor = false;
            this.Button_Config.Click += new EventHandler(this.Button_Config_Click);
            this.Button_Wifi.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Wifi.BackgroundImage = (Image)Resources.WIFIGREEN;
            this.Button_Wifi.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Wifi.FlatAppearance.BorderColor = Color.Black;
            this.Button_Wifi.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Wifi.FlatStyle = FlatStyle.Flat;
            this.Button_Wifi.Location = new Point(608, 310);
            this.Button_Wifi.Name = "Button_Wifi";
            this.Button_Wifi.Size = new Size(44, 44);
            this.Button_Wifi.TabIndex = 11;
            this.AllTips.SetToolTip((Control)this.Button_Wifi, "View connection information and status");
            this.Button_Wifi.UseVisualStyleBackColor = false;
            this.Button_Wifi.Click += new EventHandler(this.Button_Wifi_Click);
            this.menuStrip1.BackColor = Color.Transparent;
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(2769, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.fileToolStripMenuItem.BackColor = Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.saveToolStripMenuItem,
        (ToolStripItem) this.openConfigToolStripMenuItem,
        (ToolStripItem) this.exitToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(30, 24);
            this.fileToolStripMenuItem.Text = "...";
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new Size(162, 24);
            this.saveToolStripMenuItem.Text = "Save Ctrl + s";
            this.openConfigToolStripMenuItem.Enabled = false;
            this.openConfigToolStripMenuItem.Name = "openConfigToolStripMenuItem";
            this.openConfigToolStripMenuItem.Size = new Size(162, 24);
            this.openConfigToolStripMenuItem.Text = "Open Config";
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new Size(162, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
            this.Info_Button.BackColor = Color.FromArgb(64, 64, 64);
            this.Info_Button.BackgroundImageLayout = ImageLayout.Stretch;
            this.Info_Button.DialogResult = DialogResult.Cancel;
            this.Info_Button.FlatAppearance.BorderColor = Color.Black;
            this.Info_Button.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Info_Button.FlatStyle = FlatStyle.Flat;
            this.Info_Button.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.Info_Button.ForeColor = SystemColors.AppWorkspace;
            this.Info_Button.Location = new Point(549, 310);
            this.Info_Button.Name = "Info_Button";
            this.Info_Button.Size = new Size(62, 44);
            this.Info_Button.TabIndex = 13;
            this.Info_Button.Text = "i";
            this.AllTips.SetToolTip((Control)this.Info_Button, "Info/ Credit/ Contact");
            this.Info_Button.UseVisualStyleBackColor = false;
            this.Info_Button.Click += new EventHandler(this.Console_Button_Click);
            this.Main_Panel.BackColor = Color.Transparent;
            this.Main_Panel.Controls.Add((Control)this.richTextBox1);
            this.Main_Panel.Controls.Add((Control)this.Label_Title_1);
            this.Main_Panel.Controls.Add((Control)this.Status);
            this.Main_Panel.Controls.Add((Control)this.label2);
            this.Main_Panel.Controls.Add((Control)this.ipLable);
            this.Main_Panel.Controls.Add((Control)this.pciplbl);
            this.Main_Panel.Location = new Point(0, 30);
            this.Main_Panel.MaximumSize = new Size(650, 280);
            this.Main_Panel.MinimumSize = new Size(650, 280);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new Size(650, 280);
            this.Main_Panel.TabIndex = 14;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.richTextBox1.Location = new Point(11, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new Size(627, 101);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
            this.Label_Title_1.AutoSize = true;
            this.Label_Title_1.BackColor = Color.Transparent;
            this.Label_Title_1.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label_Title_1.ForeColor = Color.White;
            this.Label_Title_1.Location = new Point(22, 9);
            this.Label_Title_1.Name = "Label_Title_1";
            this.Label_Title_1.Size = new Size(542, 36);
            this.Label_Title_1.TabIndex = 7;
            this.Label_Title_1.Text = "PSV_Pad Server Software v1.3.0";
            this.Binds_Panel.BackColor = Color.Transparent;
            this.Binds_Panel.BackgroundImageLayout = ImageLayout.Stretch;
            this.Binds_Panel.Controls.Add((Control)this.ClearBinds);
            this.Binds_Panel.Controls.Add((Control)this.panel1);
            this.Binds_Panel.Location = new Point(688, 31);
            this.Binds_Panel.MaximumSize = new Size(650, 280);
            this.Binds_Panel.MinimumSize = new Size(650, 280);
            this.Binds_Panel.Name = "Binds_Panel";
            this.Binds_Panel.Size = new Size(650, 280);
            this.Binds_Panel.TabIndex = 15;
            this.ClearBinds.BackColor = Color.FromArgb(64, 64, 64);
            this.ClearBinds.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClearBinds.FlatAppearance.BorderColor = Color.Black;
            this.ClearBinds.FlatAppearance.MouseDownBackColor = Color.Black;
            this.ClearBinds.FlatStyle = FlatStyle.Popup;
            this.ClearBinds.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.ClearBinds.ForeColor = Color.FromArgb(192, 0, 0);
            this.ClearBinds.Location = new Point(108, (int)byte.MaxValue);
            this.ClearBinds.Margin = new Padding(1);
            this.ClearBinds.Name = "ClearBinds";
            this.ClearBinds.Size = new Size(110, 25);
            this.ClearBinds.TabIndex = 32;
            this.ClearBinds.Text = "Clear all binds";
            this.AllTips.SetToolTip((Control)this.ClearBinds, "Clears all binds - warning cannot be undone");
            this.ClearBinds.UseVisualStyleBackColor = false;
            this.ClearBinds.Click += new EventHandler(this.ClearBinds_Click);
            this.panel1.BackColor = Color.Transparent;
            this.panel1.Controls.Add((Control)this.Button_Additional);
            this.panel1.Controls.Add((Control)this.Button_Gyro);
            this.panel1.Controls.Add((Control)this.Button_Back);
            this.panel1.Controls.Add((Control)this.Button_Front);
            this.panel1.Controls.Add((Control)this.Button_Joy);
            this.panel1.Controls.Add((Control)this.Button_List);
            this.panel1.Location = new Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(101, 269);
            this.panel1.TabIndex = 29;
            this.Button_Additional.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Additional.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Additional.FlatAppearance.BorderColor = Color.Black;
            this.Button_Additional.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Additional.FlatStyle = FlatStyle.Popup;
            this.Button_Additional.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Additional.ForeColor = SystemColors.AppWorkspace;
            this.Button_Additional.Location = new Point(3, 143);
            this.Button_Additional.Margin = new Padding(1);
            this.Button_Additional.Name = "Button_Additional";
            this.Button_Additional.Size = new Size(92, 44);
            this.Button_Additional.TabIndex = 31;
            this.Button_Additional.Text = "Additional";
            this.AllTips.SetToolTip((Control)this.Button_Additional, "Set up key binds for the additional onscreen buttons on PSV-PAD");
            this.Button_Additional.UseVisualStyleBackColor = false;
            this.Button_Additional.Click += new EventHandler(this.Button_Additional_Click);
            this.Button_Gyro.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Gyro.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Gyro.FlatAppearance.BorderColor = Color.Black;
            this.Button_Gyro.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Gyro.FlatStyle = FlatStyle.Popup;
            this.Button_Gyro.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Gyro.ForeColor = SystemColors.AppWorkspace;
            this.Button_Gyro.Location = new Point(3, 97);
            this.Button_Gyro.Margin = new Padding(1);
            this.Button_Gyro.Name = "Button_Gyro";
            this.Button_Gyro.Size = new Size(92, 44);
            this.Button_Gyro.TabIndex = 30;
            this.Button_Gyro.Text = "Gyro";
            this.AllTips.SetToolTip((Control)this.Button_Gyro, "Set up key binds to the vitas gyro/motion, Relevent axis's will need enabling in configuration ");
            this.Button_Gyro.UseVisualStyleBackColor = false;
            this.Button_Gyro.Click += new EventHandler(this.Button_Gyro_Click);
            this.Button_Back.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Back.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Back.FlatAppearance.BorderColor = Color.Black;
            this.Button_Back.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Back.FlatStyle = FlatStyle.Popup;
            this.Button_Back.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Back.ForeColor = SystemColors.AppWorkspace;
            this.Button_Back.Location = new Point(3, 51);
            this.Button_Back.Margin = new Padding(1);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new Size(92, 44);
            this.Button_Back.TabIndex = 29;
            this.Button_Back.Text = "Back";
            this.AllTips.SetToolTip((Control)this.Button_Back, "Back view of playstation vita for setting up key binds ");
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new EventHandler(this.Button_Back_Click);
            this.Button_Front.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Front.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Front.FlatAppearance.BorderColor = Color.Black;
            this.Button_Front.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Front.FlatStyle = FlatStyle.Popup;
            this.Button_Front.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Front.ForeColor = SystemColors.AppWorkspace;
            this.Button_Front.Location = new Point(3, 5);
            this.Button_Front.Margin = new Padding(1);
            this.Button_Front.Name = "Button_Front";
            this.Button_Front.Size = new Size(92, 44);
            this.Button_Front.TabIndex = 26;
            this.Button_Front.Text = "Front";
            this.AllTips.SetToolTip((Control)this.Button_Front, "Front view of playstation vita for setting up key binds ");
            this.Button_Front.UseVisualStyleBackColor = false;
            this.Button_Front.Click += new EventHandler(this.Button_Visual_Click);
            this.Button_Joy.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_Joy.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_Joy.FlatAppearance.BorderColor = Color.Black;
            this.Button_Joy.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_Joy.FlatStyle = FlatStyle.Popup;
            this.Button_Joy.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Joy.ForeColor = SystemColors.AppWorkspace;
            this.Button_Joy.Location = new Point(3, 235);
            this.Button_Joy.Margin = new Padding(1);
            this.Button_Joy.Name = "Button_Joy";
            this.Button_Joy.Size = new Size(92, 44);
            this.Button_Joy.TabIndex = 28;
            this.Button_Joy.Text = "Joy";
            this.AllTips.SetToolTip((Control)this.Button_Joy, "To Be Confirmed");
            this.Button_Joy.UseVisualStyleBackColor = false;
            this.Button_Joy.Visible = false;
            this.Button_Joy.Click += new EventHandler(this.Button_Joy_Click);
            this.Button_List.BackColor = Color.FromArgb(64, 64, 64);
            this.Button_List.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button_List.FlatAppearance.BorderColor = Color.Black;
            this.Button_List.FlatAppearance.MouseDownBackColor = Color.Black;
            this.Button_List.FlatStyle = FlatStyle.Popup;
            this.Button_List.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_List.ForeColor = SystemColors.AppWorkspace;
            this.Button_List.Location = new Point(3, 189);
            this.Button_List.Margin = new Padding(1);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new Size(92, 44);
            this.Button_List.TabIndex = 27;
            this.Button_List.Text = "List";
            this.AllTips.SetToolTip((Control)this.Button_List, "A list of all bound controls");
            this.Button_List.UseVisualStyleBackColor = false;
            this.Button_List.Click += new EventHandler(this.Button_List_Click);
            this.Button_RADown.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_RADown.Location = new Point(448, 175);
            this.Button_RADown.Name = "Button_RADown";
            this.Button_RADown.Size = new Size(25, 25);
            this.Button_RADown.TabIndex = 24;
            this.Button_RADown.UseVisualStyleBackColor = true;
            this.Button_RADown.Click += new EventHandler(this.Button_RADown_Click);
            this.Button_RADown.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_RARight.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_RARight.Location = new Point(471, 153);
            this.Button_RARight.Name = "Button_RARight";
            this.Button_RARight.Size = new Size(25, 25);
            this.Button_RARight.TabIndex = 23;
            this.Button_RARight.UseVisualStyleBackColor = true;
            this.Button_RARight.Click += new EventHandler(this.Button_RARight_Click);
            this.Button_RARight.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_RALeft.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_RALeft.Location = new Point(425, 153);
            this.Button_RALeft.Name = "Button_RALeft";
            this.Button_RALeft.Size = new Size(25, 25);
            this.Button_RALeft.TabIndex = 22;
            this.Button_RALeft.UseVisualStyleBackColor = true;
            this.Button_RALeft.Click += new EventHandler(this.Button_RALeft_Click);
            this.Button_RALeft.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_RAUp.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_RAUp.Location = new Point(448, 131);
            this.Button_RAUp.Name = "Button_RAUp";
            this.Button_RAUp.Size = new Size(25, 25);
            this.Button_RAUp.TabIndex = 21;
            this.Button_RAUp.UseVisualStyleBackColor = true;
            this.Button_RAUp.Click += new EventHandler(this.Button_RAUp_Click);
            this.Button_RAUp.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_Start.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Start.Location = new Point(415, 220);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new Size(25, 25);
            this.Button_Start.TabIndex = 20;
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new EventHandler(this.Button_Start_Click);
            this.Button_Start.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_Select.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Select.Location = new Point(384, 220);
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.Size = new Size(25, 25);
            this.Button_Select.TabIndex = 19;
            this.Button_Select.UseVisualStyleBackColor = true;
            this.Button_Select.Click += new EventHandler(this.Button_Select_Click);
            this.Button_Select.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_LADown.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_LADown.Location = new Point(80, 175);
            this.Button_LADown.Name = "Button_LADown";
            this.Button_LADown.Size = new Size(25, 25);
            this.Button_LADown.TabIndex = 14;
            this.Button_LADown.UseVisualStyleBackColor = true;
            this.Button_LADown.Click += new EventHandler(this.Button_LADown_Click);
            this.Button_LADown.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_LARight.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_LARight.Location = new Point(103, 153);
            this.Button_LARight.Name = "Button_LARight";
            this.Button_LARight.Size = new Size(25, 25);
            this.Button_LARight.TabIndex = 13;
            this.Button_LARight.UseVisualStyleBackColor = true;
            this.Button_LARight.Click += new EventHandler(this.ButtonLARight_Click);
            this.Button_LARight.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_LALeft.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_LALeft.Location = new Point(57, 153);
            this.Button_LALeft.Name = "Button_LALeft";
            this.Button_LALeft.Size = new Size(25, 25);
            this.Button_LALeft.TabIndex = 12;
            this.Button_LALeft.UseVisualStyleBackColor = true;
            this.Button_LALeft.Click += new EventHandler(this.ButtonLALeft_Click);
            this.Button_LALeft.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_LAUp.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_LAUp.Location = new Point(80, 131);
            this.Button_LAUp.Name = "Button_LAUp";
            this.Button_LAUp.Size = new Size(25, 25);
            this.Button_LAUp.TabIndex = 11;
            this.Button_LAUp.UseVisualStyleBackColor = true;
            this.Button_LAUp.Click += new EventHandler(this.Button_LAUp_Click);
            this.Button_LAUp.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_Cross.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Cross.Location = new Point(472, 108);
            this.Button_Cross.Name = "Button_Cross";
            this.Button_Cross.Size = new Size(25, 25);
            this.Button_Cross.TabIndex = 10;
            this.Button_Cross.UseVisualStyleBackColor = true;
            this.Button_Cross.Click += new EventHandler(this.Button_Cross_Click);
            this.Button_Cross.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_Circle.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Circle.Location = new Point(495, 85);
            this.Button_Circle.Name = "Button_Circle";
            this.Button_Circle.Size = new Size(25, 25);
            this.Button_Circle.TabIndex = 9;
            this.Button_Circle.UseVisualStyleBackColor = true;
            this.Button_Circle.Click += new EventHandler(this.Button_Circle_Click);
            this.Button_Circle.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_Square.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Square.Location = new Point(449, 85);
            this.Button_Square.Name = "Button_Square";
            this.Button_Square.Size = new Size(25, 25);
            this.Button_Square.TabIndex = 8;
            this.Button_Square.UseVisualStyleBackColor = true;
            this.Button_Square.Click += new EventHandler(this.Button_Square_Click);
            this.Button_Square.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_Triangle.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_Triangle.Location = new Point(473, 62);
            this.Button_Triangle.Name = "Button_Triangle";
            this.Button_Triangle.Size = new Size(25, 25);
            this.Button_Triangle.TabIndex = 7;
            this.Button_Triangle.UseVisualStyleBackColor = true;
            this.Button_Triangle.Click += new EventHandler(this.Button_Triangle_Click);
            this.Button_Triangle.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_DDown.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_DDown.Location = new Point(57, 109);
            this.Button_DDown.Name = "Button_DDown";
            this.Button_DDown.Size = new Size(25, 25);
            this.Button_DDown.TabIndex = 6;
            this.Button_DDown.UseVisualStyleBackColor = true;
            this.Button_DDown.Click += new EventHandler(this.Button_DDown_Click);
            this.Button_DDown.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_DRight.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_DRight.Location = new Point(80, 86);
            this.Button_DRight.Name = "Button_DRight";
            this.Button_DRight.Size = new Size(25, 25);
            this.Button_DRight.TabIndex = 5;
            this.Button_DRight.UseVisualStyleBackColor = true;
            this.Button_DRight.Click += new EventHandler(this.Button_DRight_Click);
            this.Button_DRight.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_DLeft.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_DLeft.Location = new Point(35, 86);
            this.Button_DLeft.Name = "Button_DLeft";
            this.Button_DLeft.Size = new Size(25, 25);
            this.Button_DLeft.TabIndex = 4;
            this.Button_DLeft.UseVisualStyleBackColor = true;
            this.Button_DLeft.Click += new EventHandler(this.Button_DLeft_Click);
            this.Button_DLeft.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_R.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_R.Location = new Point(448, 19);
            this.Button_R.Name = "Button_R";
            this.Button_R.Size = new Size(25, 25);
            this.Button_R.TabIndex = 3;
            this.Button_R.UseVisualStyleBackColor = true;
            this.Button_R.Click += new EventHandler(this.Button_R_Click);
            this.Button_R.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_L.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_L.Location = new Point(80, 19);
            this.Button_L.Name = "Button_L";
            this.Button_L.Size = new Size(25, 25);
            this.Button_L.TabIndex = 2;
            this.Button_L.UseVisualStyleBackColor = true;
            this.Button_L.Click += new EventHandler(this.Button_L_Click);
            this.Button_L.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Button_DUp.BackColor = Color.Transparent;
            this.Button_DUp.FlatAppearance.BorderColor = Color.Black;
            this.Button_DUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            this.Button_DUp.FlatAppearance.MouseOverBackColor = Color.Black;
            this.Button_DUp.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Button_DUp.ForeColor = SystemColors.ActiveCaptionText;
            this.Button_DUp.Location = new Point(57, 64);
            this.Button_DUp.Name = "Button_DUp";
            this.Button_DUp.Size = new Size(25, 25);
            this.Button_DUp.TabIndex = 1;
            this.Button_DUp.UseVisualStyleBackColor = false;
            this.Button_DUp.Click += new EventHandler(this.Button_DUp_Click);
            this.Button_DUp.MouseHover += new EventHandler(this.BindInfoToolTip_CustomHover);
            this.Vita_Panel.BackColor = Color.Transparent;
            this.Vita_Panel.BackgroundImageLayout = ImageLayout.None;
            this.Vita_Panel.Controls.Add((Control)this.Button_RADown);
            this.Vita_Panel.Controls.Add((Control)this.Button_DUp);
            this.Vita_Panel.Controls.Add((Control)this.Button_RARight);
            this.Vita_Panel.Controls.Add((Control)this.Button_L);
            this.Vita_Panel.Controls.Add((Control)this.Button_RALeft);
            this.Vita_Panel.Controls.Add((Control)this.Button_R);
            this.Vita_Panel.Controls.Add((Control)this.Button_RAUp);
            this.Vita_Panel.Controls.Add((Control)this.Button_DLeft);
            this.Vita_Panel.Controls.Add((Control)this.Button_Start);
            this.Vita_Panel.Controls.Add((Control)this.Button_DRight);
            this.Vita_Panel.Controls.Add((Control)this.Button_Select);
            this.Vita_Panel.Controls.Add((Control)this.Button_DDown);
            this.Vita_Panel.Controls.Add((Control)this.Button_LADown);
            this.Vita_Panel.Controls.Add((Control)this.Button_Triangle);
            this.Vita_Panel.Controls.Add((Control)this.Button_LARight);
            this.Vita_Panel.Controls.Add((Control)this.Button_Square);
            this.Vita_Panel.Controls.Add((Control)this.Button_LALeft);
            this.Vita_Panel.Controls.Add((Control)this.Button_Circle);
            this.Vita_Panel.Controls.Add((Control)this.Button_LAUp);
            this.Vita_Panel.Controls.Add((Control)this.Button_Cross);
            this.Vita_Panel.Controls.Add((Control)this.PSV_Picture);
            this.Vita_Panel.Location = new Point(1247, 343);
            this.Vita_Panel.Name = "Vita_Panel";
            this.Vita_Panel.Size = new Size(550, 280);
            this.Vita_Panel.TabIndex = 25;
            this.Vita_Panel.Paint += new PaintEventHandler(this.Vita_Panel_Paint);
            this.PSV_Picture.BackColor = Color.Transparent;
            this.PSV_Picture.BackgroundImageLayout = ImageLayout.Stretch;
            this.PSV_Picture.Image = (Image)Resources.psv;
            this.PSV_Picture.Location = new Point(17, 14);
            this.PSV_Picture.Name = "PSV_Picture";
            this.PSV_Picture.Size = new Size(518, 246);
            this.PSV_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PSV_Picture.TabIndex = 0;
            this.PSV_Picture.TabStop = false;
            this.PSV_Picture.WaitOnLoad = true;
            this.BindList_Panel.AutoScroll = true;
            this.BindList_Panel.BackColor = Color.Transparent;
            this.BindList_Panel.Controls.Add((Control)this.DEvLbl);
            this.BindList_Panel.Location = new Point(688, 633);
            this.BindList_Panel.Name = "BindList_Panel";
            this.BindList_Panel.Size = new Size(550, 280);
            this.BindList_Panel.TabIndex = 26;
            this.DEvLbl.AutoSize = true;
            this.DEvLbl.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.DEvLbl.ForeColor = SystemColors.ButtonFace;
            this.DEvLbl.Location = new Point(27, 112);
            this.DEvLbl.Name = "DEvLbl";
            this.DEvLbl.Size = new Size(488, 46);
            this.DEvLbl.TabIndex = 0;
            this.DEvLbl.Text = "UNDER DEVELOPMENT ";
            this.JoyBind_Panel.AutoScroll = true;
            this.JoyBind_Panel.BackColor = Color.Transparent;
            this.JoyBind_Panel.Controls.Add((Control)this.label1);
            this.JoyBind_Panel.Location = new Point(1247, 919);
            this.JoyBind_Panel.Name = "JoyBind_Panel";
            this.JoyBind_Panel.Size = new Size(550, 280);
            this.JoyBind_Panel.TabIndex = 27;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label1.ForeColor = SystemColors.ButtonFace;
            this.label1.Location = new Point(27, 112);
            this.label1.Name = "label1";
            this.label1.Size = new Size(488, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNDER DEVELOPMENT ";
            this.Config_Panel.AutoScroll = true;
            this.Config_Panel.BackColor = Color.Black;
            this.Config_Panel.Controls.Add((Control)this.label16);
            this.Config_Panel.Controls.Add((Control)this.GeneralSettingsGroup);
            this.Config_Panel.Controls.Add((Control)this.AxisSettings);
            this.Config_Panel.Controls.Add((Control)this.GyroscopeSettings);
            this.Config_Panel.Controls.Add((Control)this.ConfigLbl);
            this.Config_Panel.Location = new Point(11, 367);
            this.Config_Panel.MaximumSize = new Size(650, 280);
            this.Config_Panel.MinimumSize = new Size(650, 280);
            this.Config_Panel.Name = "Config_Panel";
            this.Config_Panel.Size = new Size(650, 280);
            this.Config_Panel.TabIndex = 30;
            this.label16.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label16.ForeColor = Color.FromArgb(192, 0, 0);
            this.label16.Location = new Point(15, 59);
            this.label16.Name = "label16";
            this.label16.Size = new Size(606, 30);
            this.label16.TabIndex = 30;
            this.label16.Text = "Warning please take caution, changes could result in undesirable effects";
            this.GeneralSettingsGroup.Controls.Add((Control)this.KeyRepeat_Slider);
            this.GeneralSettingsGroup.Controls.Add((Control)this.label19);
            this.GeneralSettingsGroup.Controls.Add((Control)this.KeyRepeatDelay_Box);
            this.GeneralSettingsGroup.Controls.Add((Control)this.MouseSpeedBox);
            this.GeneralSettingsGroup.Controls.Add((Control)this.ClientTimeOut_Box);
            this.GeneralSettingsGroup.Controls.Add((Control)this.MSLbl);
            this.GeneralSettingsGroup.Controls.Add((Control)this.label18);
            this.GeneralSettingsGroup.Controls.Add((Control)this.KeyRepeatLbl);
            this.GeneralSettingsGroup.Controls.Add((Control)this.MouseSpeedLbl);
            this.GeneralSettingsGroup.Controls.Add((Control)this.MouseSpeed_Slider);
            this.GeneralSettingsGroup.Controls.Add((Control)this.label17);
            this.GeneralSettingsGroup.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GeneralSettingsGroup.ForeColor = Color.Gainsboro;
            this.GeneralSettingsGroup.Location = new Point(18, 92);
            this.GeneralSettingsGroup.Name = "GeneralSettingsGroup";
            this.GeneralSettingsGroup.Size = new Size(603, 232);
            this.GeneralSettingsGroup.TabIndex = 29;
            this.GeneralSettingsGroup.TabStop = false;
            this.GeneralSettingsGroup.Text = "General Settings ";
            this.KeyRepeat_Slider.Location = new Point(229, 170);
            this.KeyRepeat_Slider.Maximum = 1000;
            this.KeyRepeat_Slider.Name = "KeyRepeat_Slider";
            this.KeyRepeat_Slider.Size = new Size(172, 56);
            this.KeyRepeat_Slider.TabIndex = 36;
            this.KeyRepeat_Slider.TickStyle = TickStyle.None;
            this.KeyRepeat_Slider.Value = 200;
            this.KeyRepeat_Slider.Scroll += new EventHandler(this.KeyRepeat_Slider_Scroll);
            this.label19.AutoSize = true;
            this.label19.ForeColor = Color.Gainsboro;
            this.label19.Location = new Point(533, 170);
            this.label19.Name = "label19";
            this.label19.Size = new Size(45, 29);
            this.label19.TabIndex = 45;
            this.label19.Text = "ms";
            this.AllTips.SetToolTip((Control)this.label19, "Used to change the speed in which the mouse will move accross the screen when bound to a key in the Key Binds panel.");
            this.KeyRepeatDelay_Box.Location = new Point(407, 165);
            this.KeyRepeatDelay_Box.Maximum = new Decimal(new int[4]
            {
        1000,
        0,
        0,
        0
            });
            this.KeyRepeatDelay_Box.Name = "KeyRepeatDelay_Box";
            this.KeyRepeatDelay_Box.Size = new Size(120, 34);
            this.KeyRepeatDelay_Box.TabIndex = 44;
            this.KeyRepeatDelay_Box.Value = new Decimal(new int[4]
            {
        200,
        0,
        0,
        0
            });
            this.KeyRepeatDelay_Box.ValueChanged += new EventHandler(this.KeyRepeatDelay_Box_ValueChanged);
            this.MouseSpeedBox.Enabled = false;
            this.MouseSpeedBox.Location = new Point(407, 108);
            this.MouseSpeedBox.Maximum = new Decimal(new int[4]
            {
        50,
        0,
        0,
        0
            });
            this.MouseSpeedBox.Minimum = new Decimal(new int[4]
            {
        1,
        0,
        0,
        0
            });
            this.MouseSpeedBox.Name = "MouseSpeedBox";
            this.MouseSpeedBox.Size = new Size(120, 34);
            this.MouseSpeedBox.TabIndex = 43;
            this.MouseSpeedBox.Value = new Decimal(new int[4]
            {
        8,
        0,
        0,
        0
            });
            this.ClientTimeOut_Box.Location = new Point(205, 58);
            this.ClientTimeOut_Box.Maximum = new Decimal(new int[4]
            {
        99999,
        0,
        0,
        0
            });
            this.ClientTimeOut_Box.Minimum = new Decimal(new int[4]
            {
        100,
        0,
        0,
        0
            });
            this.ClientTimeOut_Box.Name = "ClientTimeOut_Box";
            this.ClientTimeOut_Box.Size = new Size(120, 34);
            this.ClientTimeOut_Box.TabIndex = 42;
            this.ClientTimeOut_Box.Value = new Decimal(new int[4]
            {
        300,
        0,
        0,
        0
            });
            this.ClientTimeOut_Box.ValueChanged += new EventHandler(this.ClientTimeOut_Box_ValueChanged);
            this.MSLbl.AutoSize = true;
            this.MSLbl.ForeColor = Color.Gainsboro;
            this.MSLbl.Location = new Point(331, 63);
            this.MSLbl.Name = "MSLbl";
            this.MSLbl.Size = new Size(45, 29);
            this.MSLbl.TabIndex = 40;
            this.MSLbl.Text = "ms";
            this.AllTips.SetToolTip((Control)this.MSLbl, "Used to change the speed in which the mouse will move accross the screen when bound to a key in the Key Binds panel.");
            this.label18.AutoSize = true;
            this.label18.ForeColor = Color.Gainsboro;
            this.label18.Location = new Point(12, 60);
            this.label18.Name = "label18";
            this.label18.Size = new Size(187, 29);
            this.label18.TabIndex = 38;
            this.label18.Text = "Client Time Out:";
            this.AllTips.SetToolTip((Control)this.label18, "The period of time in milliseconds in which a connection should be terminated if no message has been recieved from the client");
            this.KeyRepeatLbl.AutoSize = true;
            this.KeyRepeatLbl.ForeColor = Color.Gainsboro;
            this.KeyRepeatLbl.Location = new Point(11, 170);
            this.KeyRepeatLbl.Name = "KeyRepeatLbl";
            this.KeyRepeatLbl.Size = new Size(211, 29);
            this.KeyRepeatLbl.TabIndex = 35;
            this.KeyRepeatLbl.Text = "Key Repeat Delay:";
            this.AllTips.SetToolTip((Control)this.KeyRepeatLbl, "Determines the time delay that will occur inbetween key presses, a shorter delay will result in more frequent key down events(key presses), It is unlikely you will need to change this.");
            this.MouseSpeedLbl.AutoSize = true;
            this.MouseSpeedLbl.ForeColor = Color.Gainsboro;
            this.MouseSpeedLbl.Location = new Point(12, 113);
            this.MouseSpeedLbl.Name = "MouseSpeedLbl";
            this.MouseSpeedLbl.Size = new Size(170, 29);
            this.MouseSpeedLbl.TabIndex = 33;
            this.MouseSpeedLbl.Text = "Mouse Speed:";
            this.AllTips.SetToolTip((Control)this.MouseSpeedLbl, "Used to change the speed in which the mouse will move accross the screen when bound to a key in the Key Binds panel.");
            this.MouseSpeed_Slider.Enabled = false;
            this.MouseSpeed_Slider.Location = new Point(229, 113);
            this.MouseSpeed_Slider.Maximum = 50;
            this.MouseSpeed_Slider.Minimum = 1;
            this.MouseSpeed_Slider.Name = "MouseSpeed_Slider";
            this.MouseSpeed_Slider.Size = new Size(172, 56);
            this.MouseSpeed_Slider.TabIndex = 32;
            this.MouseSpeed_Slider.TickStyle = TickStyle.None;
            this.MouseSpeed_Slider.Value = 8;
            this.MouseSpeed_Slider.Scroll += new EventHandler(this.MouseSpeed_Slider_Scroll);
            this.label17.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label17.ForeColor = SystemColors.Highlight;
            this.label17.Location = new Point(13, 30);
            this.label17.Name = "label17";
            this.label17.Size = new Size(578, 30);
            this.label17.TabIndex = 31;
            this.label17.Text = "The following settings relate to the general operation of the server software.";
            this.AxisSettings.Controls.Add((Control)this.groupBox2);
            this.AxisSettings.Controls.Add((Control)this.groupBox1);
            this.AxisSettings.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.AxisSettings.ForeColor = Color.Gainsboro;
            this.AxisSettings.Location = new Point(18, 760);
            this.AxisSettings.Name = "AxisSettings";
            this.AxisSettings.Size = new Size(603, 440);
            this.AxisSettings.TabIndex = 28;
            this.AxisSettings.TabStop = false;
            this.AxisSettings.Text = "PS Vita Analogue Axis Configuration";
            this.groupBox2.Controls.Add((Control)this.RightStickYAxis);
            this.groupBox2.Controls.Add((Control)this.label4);
            this.groupBox2.Controls.Add((Control)this.label5);
            this.groupBox2.Controls.Add((Control)this.RightStickDeadZoneLbl);
            this.groupBox2.Controls.Add((Control)this.label8);
            this.groupBox2.Controls.Add((Control)this.RightStickXAxis);
            this.groupBox2.Controls.Add((Control)this.label13);
            this.groupBox2.Controls.Add((Control)this.RightStickDeadZone_Slider);
            this.groupBox2.ForeColor = Color.Gainsboro;
            this.groupBox2.Location = new Point(16, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(574, 179);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right Stick";
            this.RightStickYAxis.BorderStyle = BorderStyle.FixedSingle;
            this.RightStickYAxis.ErrorImage = (Image)Resources.arrow;
            this.RightStickYAxis.Location = new Point(117, 131);
            this.RightStickYAxis.Margin = new Padding(0);
            this.RightStickYAxis.Name = "RightStickYAxis";
            this.RightStickYAxis.Size = new Size(428, 22);
            this.RightStickYAxis.TabIndex = 19;
            this.RightStickYAxis.TabStop = false;
            this.RightStickYAxis.Paint += new PaintEventHandler(this.RightStickYAxis_Paint);
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Gainsboro;
            this.label4.Location = new Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new Size(91, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Axis Y: ";
            this.label5.ForeColor = Color.Gainsboro;
            this.label5.Location = new Point(22, 42);
            this.label5.Name = "label5";
            this.label5.Size = new Size(258, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Right Stick Dead Zone: ";
            this.AllTips.SetToolTip((Control)this.label5, "Used to set the right sticks deadzone value");
            this.RightStickDeadZoneLbl.BackColor = Color.Black;
            this.RightStickDeadZoneLbl.ForeColor = Color.Maroon;
            this.RightStickDeadZoneLbl.Location = new Point(441, 42);
            this.RightStickDeadZoneLbl.Name = "RightStickDeadZoneLbl";
            this.RightStickDeadZoneLbl.Size = new Size(74, 29);
            this.RightStickDeadZoneLbl.TabIndex = 15;
            this.RightStickDeadZoneLbl.Text = "000.0";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(521, 42);
            this.label8.Name = "label8";
            this.label8.Size = new Size(35, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "%";
            this.RightStickXAxis.BorderStyle = BorderStyle.FixedSingle;
            this.RightStickXAxis.ErrorImage = (Image)Resources.arrow;
            this.RightStickXAxis.Location = new Point(117, 91);
            this.RightStickXAxis.Margin = new Padding(0);
            this.RightStickXAxis.Name = "RightStickXAxis";
            this.RightStickXAxis.Size = new Size(428, 22);
            this.RightStickXAxis.TabIndex = 17;
            this.RightStickXAxis.TabStop = false;
            this.RightStickXAxis.Paint += new PaintEventHandler(this.RightStickXAxis_Paint);
            this.label13.AutoSize = true;
            this.label13.ForeColor = Color.Gainsboro;
            this.label13.Location = new Point(22, 84);
            this.label13.Name = "label13";
            this.label13.Size = new Size(92, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "Axis X: ";
            this.RightStickDeadZone_Slider.Location = new Point(272, 43);
            this.RightStickDeadZone_Slider.Maximum = 1000;
            this.RightStickDeadZone_Slider.Name = "RightStickDeadZone_Slider";
            this.RightStickDeadZone_Slider.Size = new Size(168, 56);
            this.RightStickDeadZone_Slider.TabIndex = 14;
            this.RightStickDeadZone_Slider.TickStyle = TickStyle.None;
            this.RightStickDeadZone_Slider.Value = 1;
            this.RightStickDeadZone_Slider.Scroll += new EventHandler(this.RightStickDeadZone_Slider_Scroll);
            this.groupBox1.Controls.Add((Control)this.LeftStickYAxis);
            this.groupBox1.Controls.Add((Control)this.label7);
            this.groupBox1.Controls.Add((Control)this.label12);
            this.groupBox1.Controls.Add((Control)this.LeftStickDeadZoneLbl);
            this.groupBox1.Controls.Add((Control)this.label10);
            this.groupBox1.Controls.Add((Control)this.LeftStickXAxis);
            this.groupBox1.Controls.Add((Control)this.label9);
            this.groupBox1.Controls.Add((Control)this.LeftStickDeadZone_Slider);
            this.groupBox1.ForeColor = Color.Gainsboro;
            this.groupBox1.Location = new Point(17, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(574, 179);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left Stick";
            this.LeftStickYAxis.BorderStyle = BorderStyle.FixedSingle;
            this.LeftStickYAxis.ErrorImage = (Image)Resources.arrow;
            this.LeftStickYAxis.Location = new Point(117, 131);
            this.LeftStickYAxis.Margin = new Padding(0);
            this.LeftStickYAxis.Name = "LeftStickYAxis";
            this.LeftStickYAxis.Size = new Size(428, 22);
            this.LeftStickYAxis.TabIndex = 19;
            this.LeftStickYAxis.TabStop = false;
            this.LeftStickYAxis.Paint += new PaintEventHandler(this.LeftStickYAxis_Paint);
            this.label7.AutoSize = true;
            this.label7.ForeColor = Color.Gainsboro;
            this.label7.Location = new Point(22, 124);
            this.label7.Name = "label7";
            this.label7.Size = new Size(91, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Axis Y: ";
            this.label12.AutoSize = true;
            this.label12.ForeColor = Color.Gainsboro;
            this.label12.Location = new Point(22, 42);
            this.label12.Name = "label12";
            this.label12.Size = new Size(247, 29);
            this.label12.TabIndex = 13;
            this.label12.Text = "Left Stick Dead Zone: ";
            this.AllTips.SetToolTip((Control)this.label12, "Used to set the left sticks deadzone value");
            this.LeftStickDeadZoneLbl.BackColor = Color.Black;
            this.LeftStickDeadZoneLbl.ForeColor = Color.Maroon;
            this.LeftStickDeadZoneLbl.Location = new Point(441, 42);
            this.LeftStickDeadZoneLbl.Name = "LeftStickDeadZoneLbl";
            this.LeftStickDeadZoneLbl.Size = new Size(74, 29);
            this.LeftStickDeadZoneLbl.TabIndex = 15;
            this.LeftStickDeadZoneLbl.Text = "000.0";
            this.label10.AutoSize = true;
            this.label10.Location = new Point(521, 42);
            this.label10.Name = "label10";
            this.label10.Size = new Size(35, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "%";
            this.LeftStickXAxis.BorderStyle = BorderStyle.FixedSingle;
            this.LeftStickXAxis.ErrorImage = (Image)Resources.arrow;
            this.LeftStickXAxis.Location = new Point(117, 91);
            this.LeftStickXAxis.Margin = new Padding(0);
            this.LeftStickXAxis.Name = "LeftStickXAxis";
            this.LeftStickXAxis.Size = new Size(428, 22);
            this.LeftStickXAxis.TabIndex = 17;
            this.LeftStickXAxis.TabStop = false;
            this.LeftStickXAxis.Paint += new PaintEventHandler(this.LeftStickXAxis_Paint);
            this.label9.AutoSize = true;
            this.label9.ForeColor = Color.Gainsboro;
            this.label9.Location = new Point(22, 84);
            this.label9.Name = "label9";
            this.label9.Size = new Size(92, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Axis X: ";
            this.LeftStickDeadZone_Slider.Location = new Point(267, 42);
            this.LeftStickDeadZone_Slider.Maximum = 1000;
            this.LeftStickDeadZone_Slider.Name = "LeftStickDeadZone_Slider";
            this.LeftStickDeadZone_Slider.Size = new Size(168, 56);
            this.LeftStickDeadZone_Slider.TabIndex = 14;
            this.LeftStickDeadZone_Slider.TickStyle = TickStyle.None;
            this.LeftStickDeadZone_Slider.Value = 1;
            this.LeftStickDeadZone_Slider.Scroll += new EventHandler(this.LeftStickDeadZone_Slider_Scroll);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroZAxisVisual);
            this.GyroscopeSettings.Controls.Add((Control)this.label3);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroZDeadZoneLbl);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroZDeadZone_Slider);
            this.GyroscopeSettings.Controls.Add((Control)this.AxisZDeadZoneLbl);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroYAxisVisual);
            this.GyroscopeSettings.Controls.Add((Control)this.PercentLbl2);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroYDeadZoneLbl);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroYDeadZone_Slider);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroDeadZoneLblY);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroXAxisVisual);
            this.GyroscopeSettings.Controls.Add((Control)this.PercentLbl);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroXDeadZoneLbl);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroXDeadZone_Slider);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroDeadZoneLblX);
            this.GyroscopeSettings.Controls.Add((Control)this.AxisEnableLbl);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroAxisYCheckBox);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroAxisZCheckBox);
            this.GyroscopeSettings.Controls.Add((Control)this.GyroAxisXCheckBox);
            this.GyroscopeSettings.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroscopeSettings.ForeColor = Color.Gainsboro;
            this.GyroscopeSettings.Location = new Point(18, 342);
            this.GyroscopeSettings.Name = "GyroscopeSettings";
            this.GyroscopeSettings.Size = new Size(603, 395);
            this.GyroscopeSettings.TabIndex = 12;
            this.GyroscopeSettings.TabStop = false;
            this.GyroscopeSettings.Text = "PS Vita Gyroscope Configuration";
            this.GyroZAxisVisual.BorderStyle = BorderStyle.FixedSingle;
            this.GyroZAxisVisual.ErrorImage = (Image)Resources.arrow;
            this.GyroZAxisVisual.Location = new Point(10, 334);
            this.GyroZAxisVisual.Margin = new Padding(0);
            this.GyroZAxisVisual.Name = "GyroZAxisVisual";
            this.GyroZAxisVisual.Size = new Size(581, 22);
            this.GyroZAxisVisual.TabIndex = 27;
            this.GyroZAxisVisual.TabStop = false;
            this.GyroZAxisVisual.Paint += new PaintEventHandler(this.GyroZAxisVisual_Paint);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(504, 292);
            this.label3.Name = "label3";
            this.label3.Size = new Size(35, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "%";
            this.GyroZDeadZoneLbl.BackColor = Color.Black;
            this.GyroZDeadZoneLbl.ForeColor = Color.Maroon;
            this.GyroZDeadZoneLbl.Location = new Point(424, 292);
            this.GyroZDeadZoneLbl.Name = "GyroZDeadZoneLbl";
            this.GyroZDeadZoneLbl.Size = new Size(74, 29);
            this.GyroZDeadZoneLbl.TabIndex = 25;
            this.GyroZDeadZoneLbl.Text = "000.0";
            this.GyroZDeadZone_Slider.AutoSize = false;
            this.GyroZDeadZone_Slider.Location = new Point(222, 292);
            this.GyroZDeadZone_Slider.Maximum = 900;
            this.GyroZDeadZone_Slider.Name = "GyroZDeadZone_Slider";
            this.GyroZDeadZone_Slider.Size = new Size(194, 56);
            this.GyroZDeadZone_Slider.TabIndex = 24;
            this.GyroZDeadZone_Slider.TickStyle = TickStyle.None;
            this.GyroZDeadZone_Slider.Value = 1;
            this.GyroZDeadZone_Slider.Scroll += new EventHandler(this.GyroZDeadZone_Slider_Scroll);
            this.AxisZDeadZoneLbl.AutoSize = true;
            this.AxisZDeadZoneLbl.ForeColor = Color.Gainsboro;
            this.AxisZDeadZoneLbl.Location = new Point(5, 285);
            this.AxisZDeadZoneLbl.Name = "AxisZDeadZoneLbl";
            this.AxisZDeadZoneLbl.Size = new Size(214, 29);
            this.AxisZDeadZoneLbl.TabIndex = 23;
            this.AxisZDeadZoneLbl.Text = "Axis Z Dead Zone: ";
            this.GyroYAxisVisual.BorderStyle = BorderStyle.FixedSingle;
            this.GyroYAxisVisual.ErrorImage = (Image)Resources.arrow;
            this.GyroYAxisVisual.Location = new Point(11, 234);
            this.GyroYAxisVisual.Margin = new Padding(0);
            this.GyroYAxisVisual.Name = "GyroYAxisVisual";
            this.GyroYAxisVisual.Size = new Size(581, 22);
            this.GyroYAxisVisual.TabIndex = 22;
            this.GyroYAxisVisual.TabStop = false;
            this.GyroYAxisVisual.Paint += new PaintEventHandler(this.GyroYAxisVisual_Paint);
            this.PercentLbl2.AutoSize = true;
            this.PercentLbl2.Location = new Point(505, 192);
            this.PercentLbl2.Name = "PercentLbl2";
            this.PercentLbl2.Size = new Size(35, 29);
            this.PercentLbl2.TabIndex = 21;
            this.PercentLbl2.Text = "%";
            this.GyroYDeadZoneLbl.BackColor = Color.Black;
            this.GyroYDeadZoneLbl.ForeColor = Color.Maroon;
            this.GyroYDeadZoneLbl.Location = new Point(425, 192);
            this.GyroYDeadZoneLbl.Name = "GyroYDeadZoneLbl";
            this.GyroYDeadZoneLbl.Size = new Size(74, 29);
            this.GyroYDeadZoneLbl.TabIndex = 20;
            this.GyroYDeadZoneLbl.Text = "000.0";
            this.GyroYDeadZone_Slider.Location = new Point(223, 192);
            this.GyroYDeadZone_Slider.Maximum = 900;
            this.GyroYDeadZone_Slider.Name = "GyroYDeadZone_Slider";
            this.GyroYDeadZone_Slider.Size = new Size(194, 56);
            this.GyroYDeadZone_Slider.TabIndex = 19;
            this.GyroYDeadZone_Slider.TickStyle = TickStyle.None;
            this.GyroYDeadZone_Slider.Value = 1;
            this.GyroYDeadZone_Slider.Scroll += new EventHandler(this.GyroYDeadZone_Slider_Scroll);
            this.GyroDeadZoneLblY.AutoSize = true;
            this.GyroDeadZoneLblY.ForeColor = Color.Gainsboro;
            this.GyroDeadZoneLblY.Location = new Point(6, 185);
            this.GyroDeadZoneLblY.Name = "GyroDeadZoneLblY";
            this.GyroDeadZoneLblY.Size = new Size(216, 29);
            this.GyroDeadZoneLblY.TabIndex = 18;
            this.GyroDeadZoneLblY.Text = "Axis Y Dead Zone: ";
            this.GyroXAxisVisual.BorderStyle = BorderStyle.FixedSingle;
            this.GyroXAxisVisual.ErrorImage = (Image)Resources.arrow;
            this.GyroXAxisVisual.Location = new Point(11, 145);
            this.GyroXAxisVisual.Margin = new Padding(0);
            this.GyroXAxisVisual.Name = "GyroXAxisVisual";
            this.GyroXAxisVisual.Size = new Size(581, 22);
            this.GyroXAxisVisual.TabIndex = 17;
            this.GyroXAxisVisual.TabStop = false;
            this.GyroXAxisVisual.Paint += new PaintEventHandler(this.GyroXAxisVisual_Paint);
            this.PercentLbl.AutoSize = true;
            this.PercentLbl.Location = new Point(505, 103);
            this.PercentLbl.Name = "PercentLbl";
            this.PercentLbl.Size = new Size(35, 29);
            this.PercentLbl.TabIndex = 16;
            this.PercentLbl.Text = "%";
            this.GyroXDeadZoneLbl.BackColor = Color.Black;
            this.GyroXDeadZoneLbl.ForeColor = Color.Maroon;
            this.GyroXDeadZoneLbl.Location = new Point(425, 103);
            this.GyroXDeadZoneLbl.Name = "GyroXDeadZoneLbl";
            this.GyroXDeadZoneLbl.Size = new Size(74, 29);
            this.GyroXDeadZoneLbl.TabIndex = 15;
            this.GyroXDeadZoneLbl.Text = "000.0";
            this.GyroXDeadZone_Slider.Location = new Point(223, 103);
            this.GyroXDeadZone_Slider.Maximum = 900;
            this.GyroXDeadZone_Slider.Name = "GyroXDeadZone_Slider";
            this.GyroXDeadZone_Slider.Size = new Size(194, 56);
            this.GyroXDeadZone_Slider.TabIndex = 14;
            this.GyroXDeadZone_Slider.TickStyle = TickStyle.None;
            this.GyroXDeadZone_Slider.Value = 1;
            this.GyroXDeadZone_Slider.Scroll += new EventHandler(this.GyroXDeadZone_Slider_Scroll);
            this.GyroDeadZoneLblX.AutoSize = true;
            this.GyroDeadZoneLblX.ForeColor = Color.Gainsboro;
            this.GyroDeadZoneLblX.Location = new Point(6, 96);
            this.GyroDeadZoneLblX.Name = "GyroDeadZoneLblX";
            this.GyroDeadZoneLblX.Size = new Size(217, 29);
            this.GyroDeadZoneLblX.TabIndex = 13;
            this.GyroDeadZoneLblX.Text = "Axis X Dead Zone: ";
            this.AxisEnableLbl.AutoSize = true;
            this.AxisEnableLbl.ForeColor = Color.Gainsboro;
            this.AxisEnableLbl.Location = new Point(5, 44);
            this.AxisEnableLbl.Name = "AxisEnableLbl";
            this.AxisEnableLbl.Size = new Size(165, 29);
            this.AxisEnableLbl.TabIndex = 12;
            this.AxisEnableLbl.Text = "Axis Enabled: ";
            this.GyroAxisYCheckBox.AutoSize = true;
            this.GyroAxisYCheckBox.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroAxisYCheckBox.ForeColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.GyroAxisYCheckBox.Location = new Point(284, 43);
            this.GyroAxisYCheckBox.Name = "GyroAxisYCheckBox";
            this.GyroAxisYCheckBox.Size = new Size(101, 33);
            this.GyroAxisYCheckBox.TabIndex = 10;
            this.GyroAxisYCheckBox.Text = "Y Axis";
            this.GyroAxisYCheckBox.UseVisualStyleBackColor = true;
            this.GyroAxisYCheckBox.CheckedChanged += new EventHandler(this.GyroAxisYCheckBox_CheckedChanged);
            this.GyroAxisZCheckBox.AutoSize = true;
            this.GyroAxisZCheckBox.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroAxisZCheckBox.ForeColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.GyroAxisZCheckBox.Location = new Point(391, 43);
            this.GyroAxisZCheckBox.Name = "GyroAxisZCheckBox";
            this.GyroAxisZCheckBox.Size = new Size(99, 33);
            this.GyroAxisZCheckBox.TabIndex = 11;
            this.GyroAxisZCheckBox.Text = "Z Axis";
            this.GyroAxisZCheckBox.UseVisualStyleBackColor = true;
            this.GyroAxisZCheckBox.CheckedChanged += new EventHandler(this.GyroAxisZCheckBox_CheckedChanged);
            this.GyroAxisXCheckBox.AutoSize = true;
            this.GyroAxisXCheckBox.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroAxisXCheckBox.ForeColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.GyroAxisXCheckBox.Location = new Point(176, 43);
            this.GyroAxisXCheckBox.Name = "GyroAxisXCheckBox";
            this.GyroAxisXCheckBox.Size = new Size(102, 33);
            this.GyroAxisXCheckBox.TabIndex = 9;
            this.GyroAxisXCheckBox.Text = "X Axis";
            this.GyroAxisXCheckBox.UseVisualStyleBackColor = true;
            this.GyroAxisXCheckBox.CheckedChanged += new EventHandler(this.GyroAxisXCheckBox_CheckedChanged);
            this.ConfigLbl.AutoSize = true;
            this.ConfigLbl.BackColor = Color.Transparent;
            this.ConfigLbl.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.ConfigLbl.ForeColor = Color.Gainsboro;
            this.ConfigLbl.Location = new Point(12, 14);
            this.ConfigLbl.Name = "ConfigLbl";
            this.ConfigLbl.Size = new Size(335, 36);
            this.ConfigLbl.TabIndex = 8;
            this.ConfigLbl.Text = "PSV-PAD Configuration";
            this.Help_Panel.BackColor = Color.Transparent;
            this.Help_Panel.Controls.Add((Control)this.richTextBox2);
            this.Help_Panel.Location = new Point(28, 681);
            this.Help_Panel.Name = "Help_Panel";
            this.Help_Panel.Size = new Size(650, 280);
            this.Help_Panel.TabIndex = 31;
            this.richTextBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.richTextBox2.Location = new Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new Size(644, 274);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = componentResourceManager.GetString("richTextBox2.Text");
            this.Console_Panel.AutoScroll = true;
            this.Console_Panel.BackColor = Color.Transparent;
            this.Console_Panel.Controls.Add((Control)this.label22);
            this.Console_Panel.Controls.Add((Control)this.label23);
            this.Console_Panel.Controls.Add((Control)this.label21);
            this.Console_Panel.Controls.Add((Control)this.label20);
            this.Console_Panel.Location = new Point(1247, 633);
            this.Console_Panel.Name = "Console_Panel";
            this.Console_Panel.Size = new Size(650, 280);
            this.Console_Panel.TabIndex = 32;
            this.label22.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label22.ForeColor = SystemColors.ButtonFace;
            this.label22.Location = new Point(178, 269);
            this.label22.Name = "label22";
            this.label22.Size = new Size(262, 27);
            this.label22.TabIndex = 3;
            this.label22.Text = "Developed by Allan Moore";
            this.label23.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label23.ForeColor = SystemColors.ButtonFace;
            this.label23.Location = new Point(12, 208);
            this.label23.Name = "label23";
            this.label23.Size = new Size(596, 93);
            this.label23.TabIndex = 3;
            this.label23.Text = "A Change Log can be found in  the read me included with this software.";
            this.label21.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label21.ForeColor = SystemColors.ButtonFace;
            this.label21.Location = new Point(9, 67);
            this.label21.Name = "label21";
            this.label21.Size = new Size(582, 141);
            this.label21.TabIndex = 2;
            this.label21.Text = componentResourceManager.GetString("label21.Text");
            this.label20.AutoSize = true;
            this.label20.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label20.ForeColor = SystemColors.ButtonFace;
            this.label20.Location = new Point(9, 12);
            this.label20.Name = "label20";
            this.label20.Size = new Size(450, 46);
            this.label20.TabIndex = 1;
            this.label20.Text = "PSVPAD - 1.3.0";
            this.RefreshTimer.Interval = 32;
            this.RefreshTimer.Tick += new EventHandler(this.RefreshTimer_Tick);
            this.BindInfoToolTip.Popup += new PopupEventHandler(this.BindInfoToolTip_Popup);
            this.AllTips.AutoPopDelay = 10000;
            this.AllTips.InitialDelay = 500;
            this.AllTips.ReshowDelay = 100;
            this.AllTips.ToolTipIcon = ToolTipIcon.Info;
            this.AllTips.ToolTipTitle = "PSVPAD - Tips";
            this.button1.BackColor = Color.FromArgb(64, 64, 64);
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = Color.Black;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.button1.ForeColor = SystemColors.AppWorkspace;
            this.button1.Location = new Point(145, 4);
            this.button1.Margin = new Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new Size(61, 24);
            this.button1.TabIndex = 32;
            this.button1.Text = "Save";
            this.AllTips.SetToolTip((Control)this.button1, "Saves any changes that have been made to the currently selected profile");
            this.button1.UseVisualStyleBackColor = false;
            this.button2.BackColor = Color.FromArgb(64, 64, 64);
            this.button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = Color.Black;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button2.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.button2.ForeColor = SystemColors.AppWorkspace;
            this.button2.Location = new Point(387, 4);
            this.button2.Margin = new Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new Size(61, 24);
            this.button2.TabIndex = 33;
            this.button2.Text = "Add";
            this.AllTips.SetToolTip((Control)this.button2, "Adds a new controller configuration using the name specified on the left");
            this.button2.UseVisualStyleBackColor = false;
            this.ProfileNameTxt.Location = new Point(226, 5);
            this.ProfileNameTxt.Name = "ProfileNameTxt";
            this.ProfileNameTxt.Size = new Size(157, 22);
            this.ProfileNameTxt.TabIndex = 34;
            this.ProfileNameTxt.Text = "My Profile";
            this.AllTips.SetToolTip((Control)this.ProfileNameTxt, "Enter name for new profile here");
            this.DeleteProfileBtn.BackColor = Color.FromArgb(64, 64, 64);
            this.DeleteProfileBtn.BackgroundImageLayout = ImageLayout.Stretch;
            this.DeleteProfileBtn.FlatAppearance.BorderColor = Color.Black;
            this.DeleteProfileBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            this.DeleteProfileBtn.FlatStyle = FlatStyle.Popup;
            this.DeleteProfileBtn.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.DeleteProfileBtn.ForeColor = Color.FromArgb(192, 0, 0);
            this.DeleteProfileBtn.Location = new Point(615, 5);
            this.DeleteProfileBtn.Margin = new Padding(1);
            this.DeleteProfileBtn.Name = "DeleteProfileBtn";
            this.DeleteProfileBtn.Size = new Size(24, 24);
            this.DeleteProfileBtn.TabIndex = 35;
            this.DeleteProfileBtn.Text = "X";
            this.AllTips.SetToolTip((Control)this.DeleteProfileBtn, "Deletes the currently selected profile... Action CANNOT be undone!!");
            this.DeleteProfileBtn.UseVisualStyleBackColor = false;
            this.Status1.AutoSize = true;
            this.Status1.BackColor = Color.Transparent;
            this.Status1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Status1.ForeColor = Color.Red;
            this.Status1.Location = new Point(4, 7);
            this.Status1.Margin = new Padding(4, 0, 4, 0);
            this.Status1.Name = "Status1";
            this.Status1.Size = new Size(184, 25);
            this.Status1.TabIndex = 11;
            this.Status1.Text = "DISCONNECTED";
            this.AllTips.SetToolTip((Control)this.Status1, "This is your connection status");
            this.Back_Panel.BackColor = Color.Transparent;
            this.Back_Panel.BackgroundImageLayout = ImageLayout.None;
            this.Back_Panel.Controls.Add((Control)this.BackRightDownBtn);
            this.Back_Panel.Controls.Add((Control)this.BackLeftDownBtn);
            this.Back_Panel.Controls.Add((Control)this.VitaBackImage);
            this.Back_Panel.Location = new Point(691, 338);
            this.Back_Panel.Name = "Back_Panel";
            this.Back_Panel.Size = new Size(550, 280);
            this.Back_Panel.TabIndex = 26;
            this.BackRightDownBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.BackRightDownBtn.Location = new Point(389, 107);
            this.BackRightDownBtn.Name = "BackRightDownBtn";
            this.BackRightDownBtn.Size = new Size(25, 25);
            this.BackRightDownBtn.TabIndex = 20;
            this.BackRightDownBtn.UseVisualStyleBackColor = true;
            this.BackRightDownBtn.Click += new EventHandler(this.BackRightDownBtn_Click);
            this.BackLeftDownBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.BackLeftDownBtn.Location = new Point(133, 107);
            this.BackLeftDownBtn.Name = "BackLeftDownBtn";
            this.BackLeftDownBtn.Size = new Size(25, 25);
            this.BackLeftDownBtn.TabIndex = 19;
            this.BackLeftDownBtn.UseVisualStyleBackColor = true;
            this.BackLeftDownBtn.Click += new EventHandler(this.BackLeftDownBtn_Click);
            this.VitaBackImage.BackColor = Color.Transparent;
            this.VitaBackImage.BackgroundImageLayout = ImageLayout.Stretch;
            this.VitaBackImage.Image = (Image)Resources.psvback;
            this.VitaBackImage.Location = new Point(17, 14);
            this.VitaBackImage.Name = "VitaBackImage";
            this.VitaBackImage.Size = new Size(518, 246);
            this.VitaBackImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.VitaBackImage.TabIndex = 0;
            this.VitaBackImage.TabStop = false;
            this.VitaBackImage.WaitOnLoad = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(452, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(159, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "   Select Profile....";
            this.Gyro_Panel.AutoScroll = true;
            this.Gyro_Panel.BackColor = Color.Transparent;
            this.Gyro_Panel.Controls.Add((Control)this.label15);
            this.Gyro_Panel.Controls.Add((Control)this.label14);
            this.Gyro_Panel.Controls.Add((Control)this.label6);
            this.Gyro_Panel.Controls.Add((Control)this.GyroZPosBtn);
            this.Gyro_Panel.Controls.Add((Control)this.GyroZNegBtn);
            this.Gyro_Panel.Controls.Add((Control)this.GyroYPosBtn);
            this.Gyro_Panel.Controls.Add((Control)this.GyroYNegBtn);
            this.Gyro_Panel.Controls.Add((Control)this.GyroXPosBtn);
            this.Gyro_Panel.Controls.Add((Control)this.GyroXNegBtn);
            this.Gyro_Panel.Controls.Add((Control)this.pictureBox2);
            this.Gyro_Panel.Location = new Point(1363, 31);
            this.Gyro_Panel.Name = "Gyro_Panel";
            this.Gyro_Panel.Size = new Size(550, 280);
            this.Gyro_Panel.TabIndex = 27;
            this.Gyro_Panel.Paint += new PaintEventHandler(this.Gyro_Panel_Paint);
            this.label15.AutoSize = true;
            this.label15.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label15.ForeColor = SystemColors.AppWorkspace;
            this.label15.Location = new Point(227, 160);
            this.label15.Name = "label15";
            this.label15.Size = new Size(100, 29);
            this.label15.TabIndex = 47;
            this.label15.Text = "MotionZ";
            this.label14.AutoSize = true;
            this.label14.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label14.ForeColor = SystemColors.AppWorkspace;
            this.label14.Location = new Point(227, 112);
            this.label14.Name = "label14";
            this.label14.Size = new Size(102, 29);
            this.label14.TabIndex = 46;
            this.label14.Text = "MotionY";
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label6.ForeColor = SystemColors.AppWorkspace;
            this.label6.Location = new Point(227, 58);
            this.label6.Name = "label6";
            this.label6.Size = new Size(103, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "MotionX";
            this.GyroZPosBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroZPosBtn.Location = new Point(371, 158);
            this.GyroZPosBtn.Name = "GyroZPosBtn";
            this.GyroZPosBtn.Size = new Size(25, 25);
            this.GyroZPosBtn.TabIndex = 44;
            this.GyroZPosBtn.UseVisualStyleBackColor = true;
            this.GyroZPosBtn.Click += new EventHandler(this.GyroZPosBtn_Click);
            this.GyroZNegBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroZNegBtn.Location = new Point(160, 158);
            this.GyroZNegBtn.Name = "GyroZNegBtn";
            this.GyroZNegBtn.Size = new Size(25, 25);
            this.GyroZNegBtn.TabIndex = 43;
            this.GyroZNegBtn.UseVisualStyleBackColor = true;
            this.GyroZNegBtn.Click += new EventHandler(this.GyroZNegBtn_Click);
            this.GyroYPosBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroYPosBtn.Location = new Point(371, 112);
            this.GyroYPosBtn.Name = "GyroYPosBtn";
            this.GyroYPosBtn.Size = new Size(25, 25);
            this.GyroYPosBtn.TabIndex = 42;
            this.GyroYPosBtn.UseVisualStyleBackColor = true;
            this.GyroYPosBtn.Click += new EventHandler(this.GyroYPosBtn_Click);
            this.GyroYNegBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroYNegBtn.Location = new Point(160, 112);
            this.GyroYNegBtn.Name = "GyroYNegBtn";
            this.GyroYNegBtn.Size = new Size(25, 25);
            this.GyroYNegBtn.TabIndex = 41;
            this.GyroYNegBtn.UseVisualStyleBackColor = true;
            this.GyroYNegBtn.Click += new EventHandler(this.GyroYNegBtn_Click);
            this.GyroXPosBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroXPosBtn.Location = new Point(371, 62);
            this.GyroXPosBtn.Name = "GyroXPosBtn";
            this.GyroXPosBtn.Size = new Size(25, 25);
            this.GyroXPosBtn.TabIndex = 40;
            this.GyroXPosBtn.UseVisualStyleBackColor = true;
            this.GyroXPosBtn.Click += new EventHandler(this.GyroXPosBtn_Click);
            this.GyroXNegBtn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.GyroXNegBtn.Location = new Point(160, 62);
            this.GyroXNegBtn.Name = "GyroXNegBtn";
            this.GyroXNegBtn.Size = new Size(25, 25);
            this.GyroXNegBtn.TabIndex = 39;
            this.GyroXNegBtn.UseVisualStyleBackColor = true;
            this.GyroXNegBtn.Click += new EventHandler(this.GyroXNegBtn_Click);
            this.pictureBox2.BackColor = Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox2.Image = (Image)Resources.psv;
            this.pictureBox2.Location = new Point(16, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(518, 246);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.Additional_Panel.AutoScroll = true;
            this.Additional_Panel.BackColor = Color.Transparent;
            this.Additional_Panel.Controls.Add((Control)this.B14Btn);
            this.Additional_Panel.Controls.Add((Control)this.B13Btn);
            this.Additional_Panel.Controls.Add((Control)this.B12Btn);
            this.Additional_Panel.Controls.Add((Control)this.B11Btn);
            this.Additional_Panel.Controls.Add((Control)this.B10Btn);
            this.Additional_Panel.Controls.Add((Control)this.B9Btn);
            this.Additional_Panel.Controls.Add((Control)this.B8Btn);
            this.Additional_Panel.Controls.Add((Control)this.B7Btn);
            this.Additional_Panel.Controls.Add((Control)this.B6Btn);
            this.Additional_Panel.Controls.Add((Control)this.B5Btn);
            this.Additional_Panel.Controls.Add((Control)this.B4Btn);
            this.Additional_Panel.Controls.Add((Control)this.B3Btn);
            this.Additional_Panel.Controls.Add((Control)this.B2Btn);
            this.Additional_Panel.Controls.Add((Control)this.B1Btn);
            this.Additional_Panel.Controls.Add((Control)this.pictureBox1);
            this.Additional_Panel.Controls.Add((Control)this.label11);
            this.Additional_Panel.Location = new Point(1919, 31);
            this.Additional_Panel.Name = "Additional_Panel";
            this.Additional_Panel.Size = new Size(550, 280);
            this.Additional_Panel.TabIndex = 28;
            this.B14Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B14Btn.Location = new Point(344, 59);
            this.B14Btn.Name = "B14Btn";
            this.B14Btn.Size = new Size(25, 25);
            this.B14Btn.TabIndex = 38;
            this.B14Btn.UseVisualStyleBackColor = true;
            this.B14Btn.Click += new EventHandler(this.B14Btn_Click);
            this.B13Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B13Btn.Location = new Point(189, 59);
            this.B13Btn.Name = "B13Btn";
            this.B13Btn.Size = new Size(25, 25);
            this.B13Btn.TabIndex = 37;
            this.B13Btn.UseVisualStyleBackColor = true;
            this.B13Btn.Click += new EventHandler(this.B13Btn_Click);
            this.B12Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B12Btn.Location = new Point(344, 165);
            this.B12Btn.Name = "B12Btn";
            this.B12Btn.Size = new Size(25, 25);
            this.B12Btn.TabIndex = 36;
            this.B12Btn.UseVisualStyleBackColor = true;
            this.B12Btn.Click += new EventHandler(this.B12Btn_Click);
            this.B11Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B11Btn.Location = new Point(313, 166);
            this.B11Btn.Name = "B11Btn";
            this.B11Btn.Size = new Size(25, 25);
            this.B11Btn.TabIndex = 35;
            this.B11Btn.UseVisualStyleBackColor = true;
            this.B11Btn.Click += new EventHandler(this.B11Btn_Click);
            this.B10Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B10Btn.Location = new Point(282, 165);
            this.B10Btn.Name = "B10Btn";
            this.B10Btn.Size = new Size(25, 25);
            this.B10Btn.TabIndex = 34;
            this.B10Btn.UseVisualStyleBackColor = true;
            this.B10Btn.Click += new EventHandler(this.B10Btn_Click);
            this.B9Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B9Btn.Location = new Point(251, 166);
            this.B9Btn.Name = "B9Btn";
            this.B9Btn.Size = new Size(25, 25);
            this.B9Btn.TabIndex = 33;
            this.B9Btn.UseVisualStyleBackColor = true;
            this.B9Btn.Click += new EventHandler(this.B9Btn_Click);
            this.B8Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B8Btn.Location = new Point(220, 166);
            this.B8Btn.Name = "B8Btn";
            this.B8Btn.Size = new Size(25, 25);
            this.B8Btn.TabIndex = 32;
            this.B8Btn.UseVisualStyleBackColor = true;
            this.B8Btn.Click += new EventHandler(this.B8Btn_Click);
            this.B7Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B7Btn.Location = new Point(189, 167);
            this.B7Btn.Name = "B7Btn";
            this.B7Btn.Size = new Size(25, 25);
            this.B7Btn.TabIndex = 31;
            this.B7Btn.UseVisualStyleBackColor = true;
            this.B7Btn.Click += new EventHandler(this.B7Btn_Click);
            this.B6Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B6Btn.Location = new Point(344, 134);
            this.B6Btn.Name = "B6Btn";
            this.B6Btn.Size = new Size(25, 25);
            this.B6Btn.TabIndex = 30;
            this.B6Btn.UseVisualStyleBackColor = true;
            this.B6Btn.Click += new EventHandler(this.B6Btn_Click);
            this.B5Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B5Btn.Location = new Point(313, 135);
            this.B5Btn.Name = "B5Btn";
            this.B5Btn.Size = new Size(25, 25);
            this.B5Btn.TabIndex = 29;
            this.B5Btn.UseVisualStyleBackColor = true;
            this.B5Btn.Click += new EventHandler(this.B5Btn_Click);
            this.B4Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B4Btn.Location = new Point(282, 134);
            this.B4Btn.Name = "B4Btn";
            this.B4Btn.Size = new Size(25, 25);
            this.B4Btn.TabIndex = 28;
            this.B4Btn.UseVisualStyleBackColor = true;
            this.B4Btn.Click += new EventHandler(this.B4Btn_Click);
            this.B3Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B3Btn.Location = new Point(251, 135);
            this.B3Btn.Name = "B3Btn";
            this.B3Btn.Size = new Size(25, 25);
            this.B3Btn.TabIndex = 27;
            this.B3Btn.UseVisualStyleBackColor = true;
            this.B3Btn.Click += new EventHandler(this.B3Btn_Click);
            this.B2Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B2Btn.Location = new Point(220, 135);
            this.B2Btn.Name = "B2Btn";
            this.B2Btn.Size = new Size(25, 25);
            this.B2Btn.TabIndex = 26;
            this.B2Btn.UseVisualStyleBackColor = true;
            this.B2Btn.Click += new EventHandler(this.B2Btn_Click);
            this.B1Btn.Font = new Font("Microsoft Sans Serif", 4.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.B1Btn.Location = new Point(189, 136);
            this.B1Btn.Name = "B1Btn";
            this.B1Btn.Size = new Size(25, 25);
            this.B1Btn.TabIndex = 25;
            this.B1Btn.UseVisualStyleBackColor = true;
            this.B1Btn.Click += new EventHandler(this.B1Btn_Click);
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Image = (Image)Resources.psv;
            this.pictureBox1.Location = new Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(518, 246);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.label11.AutoSize = true;
            this.label11.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label11.ForeColor = SystemColors.ButtonFace;
            this.label11.Location = new Point(14, 13);
            this.label11.Name = "label11";
            this.label11.Size = new Size(355, 46);
            this.label11.TabIndex = 0;
            this.label11.Text = "Addition Key Binds";
            this.ConnectionStatusPanel.BackColor = Color.FromArgb(64, 64, 64);
            this.ConnectionStatusPanel.BorderStyle = BorderStyle.FixedSingle;
            this.ConnectionStatusPanel.Controls.Add((Control)this.Status1);
            this.ConnectionStatusPanel.Location = new Point(667, 330);
            this.ConnectionStatusPanel.Name = "ConnectionStatusPanel";
            this.ConnectionStatusPanel.Size = new Size(200, 45);
            this.ConnectionStatusPanel.TabIndex = 36;
            this.ConnectionStatusPanel.Visible = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.Black;
            this.BackgroundImage = (Image)Resources.PSVPAD;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.CancelButton = (IButtonControl)this.Info_Button;
            this.ClientSize = new Size(2769, 1059);
            this.Controls.Add((Control)this.ConnectionStatusPanel);
            this.Controls.Add((Control)this.Additional_Panel);
            this.Controls.Add((Control)this.Gyro_Panel);
            this.Controls.Add((Control)this.Console_Panel);
            this.Controls.Add((Control)this.DeleteProfileBtn);
            this.Controls.Add((Control)this.ProfileNameTxt);
            this.Controls.Add((Control)this.Info_Button);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.Button_Wifi);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.comboBox1);
            this.Controls.Add((Control)this.Button_Config);
            this.Controls.Add((Control)this.Button_Help);
            this.Controls.Add((Control)this.Button_Key_Binds);
            this.Controls.Add((Control)this.Button_Main);
            this.Controls.Add((Control)this.Back_Panel);
            this.Controls.Add((Control)this.Help_Panel);
            this.Controls.Add((Control)this.JoyBind_Panel);
            this.Controls.Add((Control)this.Config_Panel);
            this.Controls.Add((Control)this.BindList_Panel);
            this.Controls.Add((Control)this.Vita_Panel);
            this.Controls.Add((Control)this.Binds_Panel);
            this.Controls.Add((Control)this.Main_Panel);
            this.Controls.Add((Control)this.menuStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new Size(655, 385);
            this.Name = nameof(PSVServer);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = nameof(PSVServer);
            this.Load += new EventHandler(this.PSVServer_Load);
            this.ResizeEnd += new EventHandler(this.PSVServer_ResizeEnd);
            this.Paint += new PaintEventHandler(this.PSVServer_Paint);
            this.Move += new EventHandler(this.PSVServer_Move);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.Binds_Panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Vita_Panel.ResumeLayout(false);
            ((ISupportInitialize)this.PSV_Picture).EndInit();
            this.BindList_Panel.ResumeLayout(false);
            this.BindList_Panel.PerformLayout();
            this.JoyBind_Panel.ResumeLayout(false);
            this.JoyBind_Panel.PerformLayout();
            this.Config_Panel.ResumeLayout(false);
            this.Config_Panel.PerformLayout();
            this.GeneralSettingsGroup.ResumeLayout(false);
            this.GeneralSettingsGroup.PerformLayout();
            this.KeyRepeat_Slider.EndInit();
            this.KeyRepeatDelay_Box.EndInit();
            this.MouseSpeedBox.EndInit();
            this.ClientTimeOut_Box.EndInit();
            this.MouseSpeed_Slider.EndInit();
            this.AxisSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((ISupportInitialize)this.RightStickYAxis).EndInit();
            ((ISupportInitialize)this.RightStickXAxis).EndInit();
            this.RightStickDeadZone_Slider.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize)this.LeftStickYAxis).EndInit();
            ((ISupportInitialize)this.LeftStickXAxis).EndInit();
            this.LeftStickDeadZone_Slider.EndInit();
            this.GyroscopeSettings.ResumeLayout(false);
            this.GyroscopeSettings.PerformLayout();
            ((ISupportInitialize)this.GyroZAxisVisual).EndInit();
            this.GyroZDeadZone_Slider.EndInit();
            ((ISupportInitialize)this.GyroYAxisVisual).EndInit();
            this.GyroYDeadZone_Slider.EndInit();
            ((ISupportInitialize)this.GyroXAxisVisual).EndInit();
            this.GyroXDeadZone_Slider.EndInit();
            this.Help_Panel.ResumeLayout(false);
            this.Console_Panel.ResumeLayout(false);
            this.Console_Panel.PerformLayout();
            this.Back_Panel.ResumeLayout(false);
            ((ISupportInitialize)this.VitaBackImage).EndInit();
            this.Gyro_Panel.ResumeLayout(false);
            this.Gyro_Panel.PerformLayout();
            ((ISupportInitialize)this.pictureBox2).EndInit();
            this.Additional_Panel.ResumeLayout(false);
            this.Additional_Panel.PerformLayout();
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ConnectionStatusPanel.ResumeLayout(false);
            this.ConnectionStatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public enum AxisButton : uint
        {
            LY_POS = 3,
            LY_NEG = 5,
            LX_POS = 6,
            LX_NEG = 7,
            RY_POS = 9,
            RY_NEG = 10, // 0x0000000A
            RX_POS = 11, // 0x0000000B
            RX_NEG = 12, // 0x0000000C
            GYROX_POS = 33, // 0x00000021
            GYROX_NEG = 34, // 0x00000022
            GYROY_POS = 35, // 0x00000023
            GYROY_NEG = 36, // 0x00000024
            GYROZ_POS = 37, // 0x00000025
            GYROZ_NEG = 38, // 0x00000026
        }

        private enum SubPanels : uint
        {
            FRONT_PANEL = 1,
            BACK_PANEL = 2,
            GYRO_PANEL = 3,
            ADDITIONAL_PANEL = 4,
            LIST_PANEL = 5,
            JOY_PANEL = 6,
        }
    }
}
