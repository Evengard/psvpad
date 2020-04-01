// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class Configuration
    {
        Panel Title;
        Label Label_Config;
        CheckBox Check_Enable_Touch;
        Label Label_Back_Touch;
        Label Label_Gyro;
        CheckBox CheckBox_Enable_Gyro;
        Label Label_AutoConnect;
        CheckBox Check_Auto_Connect;
        Label Label_SoundEnabled;
        CheckBox Check_Sound;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Title = new Panel();
            Title.Name = "Title";
            Label_Config = new Label();
            Label_Config.Name = "Label_Config";
            Check_Enable_Touch = new CheckBox();
            Check_Enable_Touch.Name = "Check_Enable_Touch";
            Label_Back_Touch = new Label();
            Label_Back_Touch.Name = "Label_Back_Touch";
            Label_Gyro = new Label();
            Label_Gyro.Name = "Label_Gyro";
            CheckBox_Enable_Gyro = new CheckBox();
            CheckBox_Enable_Gyro.Name = "CheckBox_Enable_Gyro";
            Label_AutoConnect = new Label();
            Label_AutoConnect.Name = "Label_AutoConnect";
            Check_Auto_Connect = new CheckBox();
            Check_Auto_Connect.Name = "Check_Auto_Connect";
            Label_SoundEnabled = new Label();
            Label_SoundEnabled.Name = "Label_SoundEnabled";
            Check_Sound = new CheckBox();
            Check_Sound.Name = "Check_Sound";

            // Configuration
            this.BackgroundColor = new UIColor(63f / 255f, 62f / 255f, 62f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(Title);
            this.AddChildLast(Check_Enable_Touch);
            this.AddChildLast(Label_Back_Touch);
            this.AddChildLast(Label_Gyro);
            this.AddChildLast(CheckBox_Enable_Gyro);
            this.AddChildLast(Label_AutoConnect);
            this.AddChildLast(Check_Auto_Connect);
            this.AddChildLast(Label_SoundEnabled);
            this.AddChildLast(Check_Sound);

            // Title
            Title.BackgroundColor = new UIColor(45f / 255f, 43f / 255f, 43f / 255f, 255f / 255f);
            Title.Clip = true;
            Title.AddChildLast(Label_Config);

            // Label_Config
            Label_Config.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Config.Font = new UIFont(FontAlias.System, 60, FontStyle.Regular);
            Label_Config.LineBreak = LineBreak.Character;
            Label_Config.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(27f / 255f, 30f / 255f, 49f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_Back_Touch
            Label_Back_Touch.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Back_Touch.Font = new UIFont(FontAlias.System, 48, FontStyle.Regular);
            Label_Back_Touch.LineBreak = LineBreak.Character;

            // Label_Gyro
            Label_Gyro.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Gyro.Font = new UIFont(FontAlias.System, 48, FontStyle.Regular);
            Label_Gyro.LineBreak = LineBreak.Character;

            // Label_AutoConnect
            Label_AutoConnect.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_AutoConnect.Font = new UIFont(FontAlias.System, 48, FontStyle.Regular);
            Label_AutoConnect.LineBreak = LineBreak.Character;

            // Check_Auto_Connect
            Check_Auto_Connect.Enabled = true;

            // Label_SoundEnabled
            Label_SoundEnabled.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_SoundEnabled.Font = new UIFont(FontAlias.System, 48, FontStyle.Regular);
            Label_SoundEnabled.LineBreak = LineBreak.Character;

            // Check_Sound
            Check_Sound.Enabled = false;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    Title.SetPosition(270, -79);
                    Title.SetSize(100, 100);
                    Title.Anchors = Anchors.None;
                    Title.Visible = true;

                    Label_Config.SetPosition(89, 19);
                    Label_Config.SetSize(214, 36);
                    Label_Config.Anchors = Anchors.None;
                    Label_Config.Visible = true;

                    Check_Enable_Touch.SetPosition(153, 134);
                    Check_Enable_Touch.SetSize(56, 56);
                    Check_Enable_Touch.Anchors = Anchors.Height | Anchors.Width;
                    Check_Enable_Touch.Visible = true;

                    Label_Back_Touch.SetPosition(-36, 46);
                    Label_Back_Touch.SetSize(214, 36);
                    Label_Back_Touch.Anchors = Anchors.None;
                    Label_Back_Touch.Visible = true;

                    Label_Gyro.SetPosition(-36, 46);
                    Label_Gyro.SetSize(214, 36);
                    Label_Gyro.Anchors = Anchors.None;
                    Label_Gyro.Visible = true;

                    CheckBox_Enable_Gyro.SetPosition(153, 134);
                    CheckBox_Enable_Gyro.SetSize(56, 56);
                    CheckBox_Enable_Gyro.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_Enable_Gyro.Visible = true;

                    Label_AutoConnect.SetPosition(-36, 46);
                    Label_AutoConnect.SetSize(214, 36);
                    Label_AutoConnect.Anchors = Anchors.None;
                    Label_AutoConnect.Visible = true;

                    Check_Auto_Connect.SetPosition(153, 134);
                    Check_Auto_Connect.SetSize(56, 56);
                    Check_Auto_Connect.Anchors = Anchors.Height | Anchors.Width;
                    Check_Auto_Connect.Visible = true;

                    Label_SoundEnabled.SetPosition(-36, 46);
                    Label_SoundEnabled.SetSize(214, 36);
                    Label_SoundEnabled.Anchors = Anchors.None;
                    Label_SoundEnabled.Visible = true;

                    Check_Sound.SetPosition(153, 134);
                    Check_Sound.SetSize(56, 56);
                    Check_Sound.Anchors = Anchors.Height | Anchors.Width;
                    Check_Sound.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Title.SetPosition(0, -3);
                    Title.SetSize(960, 100);
                    Title.Anchors = Anchors.None;
                    Title.Visible = true;

                    Label_Config.SetPosition(0, 3);
                    Label_Config.SetSize(680, 97);
                    Label_Config.Anchors = Anchors.None;
                    Label_Config.Visible = true;

                    Check_Enable_Touch.SetPosition(848, 127);
                    Check_Enable_Touch.SetSize(56, 56);
                    Check_Enable_Touch.Anchors = Anchors.Height | Anchors.Width;
                    Check_Enable_Touch.Visible = true;

                    Label_Back_Touch.SetPosition(50, 127);
                    Label_Back_Touch.SetSize(775, 56);
                    Label_Back_Touch.Anchors = Anchors.None;
                    Label_Back_Touch.Visible = true;

                    Label_Gyro.SetPosition(50, 191);
                    Label_Gyro.SetSize(775, 56);
                    Label_Gyro.Anchors = Anchors.None;
                    Label_Gyro.Visible = true;

                    CheckBox_Enable_Gyro.SetPosition(848, 191);
                    CheckBox_Enable_Gyro.SetSize(56, 56);
                    CheckBox_Enable_Gyro.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_Enable_Gyro.Visible = true;

                    Label_AutoConnect.SetPosition(51, 257);
                    Label_AutoConnect.SetSize(775, 56);
                    Label_AutoConnect.Anchors = Anchors.None;
                    Label_AutoConnect.Visible = true;

                    Check_Auto_Connect.SetPosition(848, 257);
                    Check_Auto_Connect.SetSize(56, 56);
                    Check_Auto_Connect.Anchors = Anchors.Height | Anchors.Width;
                    Check_Auto_Connect.Visible = true;

                    Label_SoundEnabled.SetPosition(51, 323);
                    Label_SoundEnabled.SetSize(775, 56);
                    Label_SoundEnabled.Anchors = Anchors.None;
                    Label_SoundEnabled.Visible = true;

                    Check_Sound.SetPosition(848, 323);
                    Check_Sound.SetSize(56, 56);
                    Check_Sound.Anchors = Anchors.Height | Anchors.Width;
                    Check_Sound.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_Config.Text = "PSV-PAD Configuration";

            Label_Back_Touch.Text = "Enable Vita Back Touch Panel";

            Label_Gyro.Text = "Enable Vita Gyro";

            Label_AutoConnect.Text = "Auto Connect Enabled";

            Label_SoundEnabled.Text = "Sound Enabled";
        }

        public void InitializeDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        public void StartDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
