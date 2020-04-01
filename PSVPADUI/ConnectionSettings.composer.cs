// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class ConnectionSettings
    {
        Panel Panel_1;
        EditableText IP_Text;
        Label Label_IPAddress;
        Button AddConnectBtn;
        EditableText PCNameText;
        Label Label_PCName;
        Button Add;
        Panel Title;
        Label Label_Config;
        Label ConnectLabel;
        PopupList SelectConnectList;
        Button DeleteConnectBtn;
        Button ConnectBtn;
        Button DisconnectBtn;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Panel_1 = new Panel();
            Panel_1.Name = "Panel_1";
            IP_Text = new EditableText();
            IP_Text.Name = "IP_Text";
            Label_IPAddress = new Label();
            Label_IPAddress.Name = "Label_IPAddress";
            AddConnectBtn = new Button();
            AddConnectBtn.Name = "AddConnectBtn";
            PCNameText = new EditableText();
            PCNameText.Name = "PCNameText";
            Label_PCName = new Label();
            Label_PCName.Name = "Label_PCName";
            Add = new Button();
            Add.Name = "Add";
            Title = new Panel();
            Title.Name = "Title";
            Label_Config = new Label();
            Label_Config.Name = "Label_Config";
            ConnectLabel = new Label();
            ConnectLabel.Name = "ConnectLabel";
            SelectConnectList = new PopupList();
            SelectConnectList.Name = "SelectConnectList";
            DeleteConnectBtn = new Button();
            DeleteConnectBtn.Name = "DeleteConnectBtn";
            ConnectBtn = new Button();
            ConnectBtn.Name = "ConnectBtn";
            DisconnectBtn = new Button();
            DisconnectBtn.Name = "DisconnectBtn";

            // ConnectionSettings
            this.BackgroundColor = new UIColor(63f / 255f, 62f / 255f, 62f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(Panel_1);
            this.AddChildLast(Title);
            this.AddChildLast(ConnectLabel);
            this.AddChildLast(SelectConnectList);
            this.AddChildLast(DeleteConnectBtn);
            this.AddChildLast(ConnectBtn);
            this.AddChildLast(DisconnectBtn);

            // Panel_1
            Panel_1.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 178f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(IP_Text);
            Panel_1.AddChildLast(Label_IPAddress);
            Panel_1.AddChildLast(AddConnectBtn);
            Panel_1.AddChildLast(PCNameText);
            Panel_1.AddChildLast(Label_PCName);
            Panel_1.AddChildLast(Add);

            // IP_Text
            IP_Text.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            IP_Text.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            IP_Text.LineBreak = LineBreak.Character;

            // Label_IPAddress
            Label_IPAddress.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_IPAddress.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_IPAddress.LineBreak = LineBreak.Character;

            // AddConnectBtn
            AddConnectBtn.TextColor = new UIColor(52f / 255f, 208f / 255f, 64f / 255f, 255f / 255f);
            AddConnectBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // PCNameText
            PCNameText.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            PCNameText.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            PCNameText.LineBreak = LineBreak.Character;

            // Label_PCName
            Label_PCName.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_PCName.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_PCName.LineBreak = LineBreak.Character;

            // Add
            Add.TextColor = new UIColor(52f / 255f, 208f / 255f, 64f / 255f, 255f / 255f);
            Add.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

            // ConnectLabel
            ConnectLabel.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            ConnectLabel.Font = new UIFont(FontAlias.System, 48, FontStyle.Regular);
            ConnectLabel.LineBreak = LineBreak.Character;

            // SelectConnectList
            SelectConnectList.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            SelectConnectList.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            SelectConnectList.ListItemTextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            SelectConnectList.ListItemFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            SelectConnectList.ListTitleTextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            SelectConnectList.ListTitleFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // DeleteConnectBtn
            DeleteConnectBtn.TextColor = new UIColor(161f / 255f, 37f / 255f, 37f / 255f, 255f / 255f);
            DeleteConnectBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // ConnectBtn
            ConnectBtn.TextColor = new UIColor(52f / 255f, 208f / 255f, 64f / 255f, 255f / 255f);
            ConnectBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // DisconnectBtn
            DisconnectBtn.TextColor = new UIColor(161f / 255f, 37f / 255f, 37f / 255f, 255f / 255f);
            DisconnectBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    Panel_1.SetPosition(-6, 208);
                    Panel_1.SetSize(100, 100);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    IP_Text.SetPosition(61, 289);
                    IP_Text.SetSize(360, 56);
                    IP_Text.Anchors = Anchors.None;
                    IP_Text.Visible = true;

                    Label_IPAddress.SetPosition(59, 197);
                    Label_IPAddress.SetSize(214, 36);
                    Label_IPAddress.Anchors = Anchors.None;
                    Label_IPAddress.Visible = true;

                    AddConnectBtn.SetPosition(726, 430);
                    AddConnectBtn.SetSize(214, 56);
                    AddConnectBtn.Anchors = Anchors.None;
                    AddConnectBtn.Visible = true;

                    PCNameText.SetPosition(379, 278);
                    PCNameText.SetSize(360, 56);
                    PCNameText.Anchors = Anchors.None;
                    PCNameText.Visible = true;

                    Label_PCName.SetPosition(59, 197);
                    Label_PCName.SetSize(214, 36);
                    Label_PCName.Anchors = Anchors.None;
                    Label_PCName.Visible = true;

                    Add.SetPosition(726, 430);
                    Add.SetSize(214, 56);
                    Add.Anchors = Anchors.None;
                    Add.Visible = true;

                    Title.SetPosition(270, -79);
                    Title.SetSize(100, 100);
                    Title.Anchors = Anchors.None;
                    Title.Visible = true;

                    Label_Config.SetPosition(89, 22);
                    Label_Config.SetSize(214, 36);
                    Label_Config.Anchors = Anchors.None;
                    Label_Config.Visible = true;

                    ConnectLabel.SetPosition(59, 197);
                    ConnectLabel.SetSize(214, 36);
                    ConnectLabel.Anchors = Anchors.None;
                    ConnectLabel.Visible = true;

                    SelectConnectList.SetPosition(391, 159);
                    SelectConnectList.SetSize(360, 56);
                    SelectConnectList.Anchors = Anchors.Height;
                    SelectConnectList.Visible = true;

                    DeleteConnectBtn.SetPosition(583, 190);
                    DeleteConnectBtn.SetSize(214, 56);
                    DeleteConnectBtn.Anchors = Anchors.None;
                    DeleteConnectBtn.Visible = true;

                    ConnectBtn.SetPosition(705, 103);
                    ConnectBtn.SetSize(214, 56);
                    ConnectBtn.Anchors = Anchors.None;
                    ConnectBtn.Visible = true;

                    DisconnectBtn.SetPosition(705, 103);
                    DisconnectBtn.SetSize(214, 56);
                    DisconnectBtn.Anchors = Anchors.None;
                    DisconnectBtn.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Panel_1.SetPosition(21, 336);
                    Panel_1.SetSize(919, 86);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    IP_Text.SetPosition(457, 17);
                    IP_Text.SetSize(191, 54);
                    IP_Text.Anchors = Anchors.None;
                    IP_Text.Visible = true;

                    Label_IPAddress.SetPosition(321, 23);
                    Label_IPAddress.SetSize(136, 41);
                    Label_IPAddress.Anchors = Anchors.None;
                    Label_IPAddress.Visible = true;

                    AddConnectBtn.SetPosition(732, 15);
                    AddConnectBtn.SetSize(185, 56);
                    AddConnectBtn.Anchors = Anchors.None;
                    AddConnectBtn.Visible = true;

                    PCNameText.SetPosition(151, 17);
                    PCNameText.SetSize(160, 54);
                    PCNameText.Anchors = Anchors.None;
                    PCNameText.Visible = true;

                    Label_PCName.SetPosition(15, 23);
                    Label_PCName.SetSize(136, 41);
                    Label_PCName.Anchors = Anchors.None;
                    Label_PCName.Visible = true;

                    Add.SetPosition(648, 15);
                    Add.SetSize(84, 56);
                    Add.Anchors = Anchors.None;
                    Add.Visible = true;

                    Title.SetPosition(0, 0);
                    Title.SetSize(960, 100);
                    Title.Anchors = Anchors.None;
                    Title.Visible = true;

                    Label_Config.SetPosition(0, 3);
                    Label_Config.SetSize(960, 97);
                    Label_Config.Anchors = Anchors.None;
                    Label_Config.Visible = true;

                    ConnectLabel.SetPosition(21, 127);
                    ConnectLabel.SetSize(476, 63);
                    ConnectLabel.Anchors = Anchors.None;
                    ConnectLabel.Visible = true;

                    SelectConnectList.SetPosition(509, 127);
                    SelectConnectList.SetSize(332, 63);
                    SelectConnectList.Anchors = Anchors.Height;
                    SelectConnectList.Visible = true;

                    DeleteConnectBtn.SetPosition(856, 130);
                    DeleteConnectBtn.SetSize(84, 56);
                    DeleteConnectBtn.Anchors = Anchors.None;
                    DeleteConnectBtn.Visible = true;

                    ConnectBtn.SetPosition(20, 201);
                    ConnectBtn.SetSize(918, 56);
                    ConnectBtn.Anchors = Anchors.None;
                    ConnectBtn.Visible = true;

                    DisconnectBtn.SetPosition(20, 269);
                    DisconnectBtn.SetSize(918, 56);
                    DisconnectBtn.Anchors = Anchors.None;
                    DisconnectBtn.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            IP_Text.Text = "192.168.1.66";

            Label_IPAddress.Text = "IP Address: ";

            AddConnectBtn.Text = "Add & Connect";

            PCNameText.Text = "Default PC";

            Label_PCName.Text = "PC Name: ";

            Add.Text = "+";

            Label_Config.Text = "PSV-PAD Connection Settings";

            ConnectLabel.Text = "Select Connection:";

            SelectConnectList.ListItems.Clear();
            /*SelectConnectList.ListItems.AddRange(new String[]
            {
                "",
            });*/
            SelectConnectList.SelectedIndex = 0;

            DeleteConnectBtn.Text = "X";

            ConnectBtn.Text = "Connect";

            DisconnectBtn.Text = "Disconnect";
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
