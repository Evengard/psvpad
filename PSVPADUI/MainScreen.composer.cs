// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class MainScreen
    {
        ImageBox Background;
        Button Keyboard_Button;
        Button Add_Buttons;
        Button Touchpad_Button;
        Button Configuration_Button;
        Button Help_Button;
        PagePanel HelpPanel;
        PagePanel TBC;
        PagePanel KeyboardPanel;
        PagePanel AddPanel;
        PagePanel Config_Panel;
        Button Status_Button;
        BusyIndicator BusyIndicator;
        PagePanel TBC_Panel;
        ScrollPanel StatusPanel;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Background = new ImageBox();
            Background.Name = "Background";
            Keyboard_Button = new Button();
            Keyboard_Button.Name = "Keyboard_Button";
            Add_Buttons = new Button();
            Add_Buttons.Name = "Add_Buttons";
            Touchpad_Button = new Button();
            Touchpad_Button.Name = "Touchpad_Button";
            Configuration_Button = new Button();
            Configuration_Button.Name = "Configuration_Button";
            Help_Button = new Button();
            Help_Button.Name = "Help_Button";
            HelpPanel = new PagePanel();
            HelpPanel.Name = "HelpPanel";
            TBC = new PagePanel();
            TBC.Name = "TBC";
            KeyboardPanel = new PagePanel();
            KeyboardPanel.Name = "KeyboardPanel";
            AddPanel = new PagePanel();
            AddPanel.Name = "AddPanel";
            Config_Panel = new PagePanel();
            Config_Panel.Name = "Config_Panel";
            Status_Button = new Button();
            Status_Button.Name = "Status_Button";
            BusyIndicator = new BusyIndicator();
            BusyIndicator.Name = "BusyIndicator";
            TBC_Panel = new PagePanel();
            TBC_Panel.Name = "TBC_Panel";
            StatusPanel = new ScrollPanel();
            StatusPanel.Name = "StatusPanel";

            // MainScreen
            this.RootWidget.AddChildLast(Background);
            this.RootWidget.AddChildLast(Keyboard_Button);
            this.RootWidget.AddChildLast(Add_Buttons);
            this.RootWidget.AddChildLast(Touchpad_Button);
            this.RootWidget.AddChildLast(Configuration_Button);
            this.RootWidget.AddChildLast(Help_Button);
            this.RootWidget.AddChildLast(HelpPanel);
            this.RootWidget.AddChildLast(TBC);
            this.RootWidget.AddChildLast(KeyboardPanel);
            this.RootWidget.AddChildLast(AddPanel);
            this.RootWidget.AddChildLast(Config_Panel);
            this.RootWidget.AddChildLast(Status_Button);
            this.RootWidget.AddChildLast(BusyIndicator);
            this.RootWidget.AddChildLast(TBC_Panel);
            this.RootWidget.AddChildLast(StatusPanel);
            this.Transition = new CrossFadeTransition();
            this.Showing += new EventHandler(onShowing);
            this.Shown += new EventHandler(onShown);

            // Background
            Background.Image = new ImageAsset("/Application/assets/PSVPAD.png");
            Background.ImageScaleType = ImageScaleType.Center;

            // Keyboard_Button
            Keyboard_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Keyboard_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Keyboard_Button.TextTrimming = TextTrimming.None;
            Keyboard_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Add_Buttons
            Add_Buttons.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Add_Buttons.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Add_Buttons.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Touchpad_Button
            Touchpad_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Touchpad_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Touchpad_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Configuration_Button
            Configuration_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Configuration_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Configuration_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Help_Button
            Help_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Help_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Help_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // HelpPanel
            HelpPanel.AddPage(new HelpPanel1());

            // TBC
            TBC.AddPage(new Configuration());

            // KeyboardPanel
            KeyboardPanel.AddPage(new Configuration());

            // AddPanel
            AddPanel.AddPage(new Additional_Button());

            // Config_Panel
            Config_Panel.AddPage(new Configuration());
            Config_Panel.AddPage(new ConnectionSettings());

            // Status_Button
            Status_Button.IconImage = new ImageAsset("/Application/assets/WIFIGREEN.png");
            Status_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // TBC_Panel
            TBC_Panel.AddPage(new TBC());

            // StatusPanel
            StatusPanel.HorizontalScroll = false;
            StatusPanel.VerticalScroll = false;
            StatusPanel.ScrollBarVisibility = ScrollBarVisibility.Invisible;
            var StatusPanel_ConnectionStatusPanel = new ConnectionStatusPanel();
            StatusPanel.PanelWidth = StatusPanel_ConnectionStatusPanel.Width;
            StatusPanel.PanelHeight = StatusPanel_ConnectionStatusPanel.Height;
            StatusPanel.PanelX = 0;
            StatusPanel.PanelY = 0;
            StatusPanel.AddChildLast(StatusPanel_ConnectionStatusPanel);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    Background.SetPosition(-149, -140);
                    Background.SetSize(200, 200);
                    Background.Anchors = Anchors.None;
                    Background.Visible = true;

                    Keyboard_Button.SetPosition(100, 245);
                    Keyboard_Button.SetSize(214, 56);
                    Keyboard_Button.Anchors = Anchors.None;
                    Keyboard_Button.Visible = true;

                    Add_Buttons.SetPosition(100, 245);
                    Add_Buttons.SetSize(214, 56);
                    Add_Buttons.Anchors = Anchors.None;
                    Add_Buttons.Visible = true;

                    Touchpad_Button.SetPosition(100, 245);
                    Touchpad_Button.SetSize(214, 56);
                    Touchpad_Button.Anchors = Anchors.None;
                    Touchpad_Button.Visible = true;

                    Configuration_Button.SetPosition(100, 245);
                    Configuration_Button.SetSize(214, 56);
                    Configuration_Button.Anchors = Anchors.None;
                    Configuration_Button.Visible = true;

                    Help_Button.SetPosition(100, 245);
                    Help_Button.SetSize(214, 56);
                    Help_Button.Anchors = Anchors.None;
                    Help_Button.Visible = true;

                    HelpPanel.SetPosition(471, 206);
                    HelpPanel.SetSize(100, 50);
                    HelpPanel.Anchors = Anchors.None;
                    HelpPanel.Visible = true;

                    TBC.SetPosition(471, 206);
                    TBC.SetSize(100, 50);
                    TBC.Anchors = Anchors.None;
                    TBC.Visible = true;

                    KeyboardPanel.SetPosition(471, 206);
                    KeyboardPanel.SetSize(100, 50);
                    KeyboardPanel.Anchors = Anchors.None;
                    KeyboardPanel.Visible = true;

                    AddPanel.SetPosition(471, 206);
                    AddPanel.SetSize(100, 50);
                    AddPanel.Anchors = Anchors.None;
                    AddPanel.Visible = true;

                    Config_Panel.SetPosition(471, 206);
                    Config_Panel.SetSize(100, 50);
                    Config_Panel.Anchors = Anchors.None;
                    Config_Panel.Visible = true;

                    Status_Button.SetPosition(100, 245);
                    Status_Button.SetSize(214, 56);
                    Status_Button.Anchors = Anchors.None;
                    Status_Button.Visible = true;

                    BusyIndicator.SetPosition(449, 259);
                    BusyIndicator.SetSize(48, 48);
                    BusyIndicator.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                    BusyIndicator.Visible = true;

                    TBC_Panel.SetPosition(471, 206);
                    TBC_Panel.SetSize(100, 50);
                    TBC_Panel.Anchors = Anchors.None;
                    TBC_Panel.Visible = true;

                    StatusPanel.SetPosition(756, 84);
                    StatusPanel.SetSize(100, 50);
                    StatusPanel.Anchors = Anchors.None;
                    StatusPanel.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Background.SetPosition(-1, 0);
                    Background.SetSize(961, 544);
                    Background.Anchors = Anchors.None;
                    Background.Visible = true;

                    Keyboard_Button.SetPosition(200, 478);
                    Keyboard_Button.SetSize(142, 66);
                    Keyboard_Button.Anchors = Anchors.None;
                    Keyboard_Button.Visible = true;

                    Add_Buttons.SetPosition(0, 478);
                    Add_Buttons.SetSize(200, 66);
                    Add_Buttons.Anchors = Anchors.None;
                    Add_Buttons.Visible = true;

                    Touchpad_Button.SetPosition(342, 478);
                    Touchpad_Button.SetSize(200, 66);
                    Touchpad_Button.Anchors = Anchors.None;
                    Touchpad_Button.Visible = true;

                    Configuration_Button.SetPosition(542, 478);
                    Configuration_Button.SetSize(200, 66);
                    Configuration_Button.Anchors = Anchors.None;
                    Configuration_Button.Visible = true;

                    Help_Button.SetPosition(742, 478);
                    Help_Button.SetSize(132, 66);
                    Help_Button.Anchors = Anchors.None;
                    Help_Button.Visible = true;

                    HelpPanel.SetPosition(-1, 0);
                    HelpPanel.SetSize(960, 478);
                    HelpPanel.Anchors = Anchors.None;
                    HelpPanel.Visible = true;

                    TBC.SetPosition(0, 0);
                    TBC.SetSize(960, 478);
                    TBC.Anchors = Anchors.None;
                    TBC.Visible = false;

                    KeyboardPanel.SetPosition(0, 0);
                    KeyboardPanel.SetSize(960, 478);
                    KeyboardPanel.Anchors = Anchors.None;
                    KeyboardPanel.Visible = false;

                    AddPanel.SetPosition(-1, 0);
                    AddPanel.SetSize(960, 478);
                    AddPanel.Anchors = Anchors.None;
                    AddPanel.Visible = false;

                    Config_Panel.SetPosition(0, 0);
                    Config_Panel.SetSize(960, 478);
                    Config_Panel.Anchors = Anchors.None;
                    Config_Panel.Visible = false;

                    Status_Button.SetPosition(875, 478);
                    Status_Button.SetSize(84, 66);
                    Status_Button.Anchors = Anchors.None;
                    Status_Button.Visible = true;

                    BusyIndicator.SetPosition(456, 215);
                    BusyIndicator.SetSize(48, 48);
                    BusyIndicator.Anchors = Anchors.Top | Anchors.Height | Anchors.Left | Anchors.Width;
                    BusyIndicator.Visible = true;

                    TBC_Panel.SetPosition(0, 0);
                    TBC_Panel.SetSize(960, 478);
                    TBC_Panel.Anchors = Anchors.None;
                    TBC_Panel.Visible = false;

                    StatusPanel.SetPosition(609, 358);
                    StatusPanel.SetSize(350, 120);
                    StatusPanel.Anchors = Anchors.None;
                    StatusPanel.Visible = false;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Keyboard_Button.Text = "Keyboard";

            Add_Buttons.Text = "Additional Buttons";

            Touchpad_Button.Text = "TBC";

            Configuration_Button.Text = "Configuration";

            Help_Button.Text = "Help";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    HelpPanel.Visible = false;
                    TBC.Visible = false;
                    KeyboardPanel.Visible = false;
                    AddPanel.Visible = false;
                    Config_Panel.Visible = false;
                    TBC_Panel.Visible = false;
                    StatusPanel.Visible = false;
                    break;

                default:
                    HelpPanel.Visible = false;
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    new FadeInEffect()
                    {
                        Widget = HelpPanel,
                    }.Start();
                    new FadeInEffect()
                    {
                        Widget = TBC,
                    }.Start();
                    new FadeInEffect()
                    {
                        Widget = KeyboardPanel,
                    }.Start();
                    new FadeInEffect()
                    {
                        Widget = AddPanel,
                    }.Start();
                    new FadeInEffect()
                    {
                        Widget = Config_Panel,
                    }.Start();
                    new FadeInEffect()
                    {
                        Widget = TBC_Panel,
                    }.Start();
                    new FadeInEffect()
                    {
                        Widget = StatusPanel,
                    }.Start();
                    break;

                default:
                    new FadeInEffect()
                    {
                        Widget = HelpPanel,
                    }.Start();
                    break;
            }
        }

    }
}
