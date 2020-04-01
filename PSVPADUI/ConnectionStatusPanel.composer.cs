// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class ConnectionStatusPanel
    {
        Label Label_Connection_Status;
        Label Label_Connection_Name;
        Label Label_Connection_IP;
        Label Label_isConnected;
        Label Label_connectionName;
        Label Label_IPAddress;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Label_Connection_Status = new Label();
            Label_Connection_Status.Name = "Label_Connection_Status";
            Label_Connection_Name = new Label();
            Label_Connection_Name.Name = "Label_Connection_Name";
            Label_Connection_IP = new Label();
            Label_Connection_IP.Name = "Label_Connection_IP";
            Label_isConnected = new Label();
            Label_isConnected.Name = "Label_isConnected";
            Label_connectionName = new Label();
            Label_connectionName.Name = "Label_connectionName";
            Label_IPAddress = new Label();
            Label_IPAddress.Name = "Label_IPAddress";

            // ConnectionStatusPanel
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 127f / 255f);
            this.Clip = true;
            this.AddChildLast(Label_Connection_Status);
            this.AddChildLast(Label_Connection_Name);
            this.AddChildLast(Label_Connection_IP);
            this.AddChildLast(Label_isConnected);
            this.AddChildLast(Label_connectionName);
            this.AddChildLast(Label_IPAddress);

            // Label_Connection_Status
            Label_Connection_Status.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Connection_Status.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_Connection_Status.LineBreak = LineBreak.Character;

            // Label_Connection_Name
            Label_Connection_Name.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Connection_Name.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_Connection_Name.LineBreak = LineBreak.Character;

            // Label_Connection_IP
            Label_Connection_IP.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Connection_IP.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_Connection_IP.LineBreak = LineBreak.Character;

            // Label_isConnected
            Label_isConnected.TextColor = new UIColor(45f / 255f, 125f / 255f, 25f / 255f, 255f / 255f);
            Label_isConnected.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_isConnected.LineBreak = LineBreak.Character;

            // Label_connectionName
            Label_connectionName.TextColor = new UIColor(45f / 255f, 125f / 255f, 25f / 255f, 255f / 255f);
            Label_connectionName.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_connectionName.LineBreak = LineBreak.Character;

            // Label_IPAddress
            Label_IPAddress.TextColor = new UIColor(45f / 255f, 125f / 255f, 25f / 255f, 255f / 255f);
            Label_IPAddress.Font = new UIFont(FontAlias.System, 15, FontStyle.Regular);
            Label_IPAddress.LineBreak = LineBreak.Character;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(120, 350);
                    this.Anchors = Anchors.None;

                    Label_Connection_Status.SetPosition(20, 17);
                    Label_Connection_Status.SetSize(214, 36);
                    Label_Connection_Status.Anchors = Anchors.None;
                    Label_Connection_Status.Visible = true;

                    Label_Connection_Name.SetPosition(20, 17);
                    Label_Connection_Name.SetSize(214, 36);
                    Label_Connection_Name.Anchors = Anchors.None;
                    Label_Connection_Name.Visible = true;

                    Label_Connection_IP.SetPosition(20, 17);
                    Label_Connection_IP.SetSize(214, 36);
                    Label_Connection_IP.Anchors = Anchors.None;
                    Label_Connection_IP.Visible = true;

                    Label_isConnected.SetPosition(20, 17);
                    Label_isConnected.SetSize(214, 36);
                    Label_isConnected.Anchors = Anchors.None;
                    Label_isConnected.Visible = true;

                    Label_connectionName.SetPosition(20, 17);
                    Label_connectionName.SetSize(214, 36);
                    Label_connectionName.Anchors = Anchors.None;
                    Label_connectionName.Visible = true;

                    Label_IPAddress.SetPosition(20, 17);
                    Label_IPAddress.SetSize(214, 36);
                    Label_IPAddress.Anchors = Anchors.None;
                    Label_IPAddress.Visible = true;

                    break;

                default:
                    this.SetSize(350, 120);
                    this.Anchors = Anchors.None;

                    Label_Connection_Status.SetPosition(0, 0);
                    Label_Connection_Status.SetSize(136, 36);
                    Label_Connection_Status.Anchors = Anchors.None;
                    Label_Connection_Status.Visible = true;

                    Label_Connection_Name.SetPosition(0, 36);
                    Label_Connection_Name.SetSize(136, 36);
                    Label_Connection_Name.Anchors = Anchors.None;
                    Label_Connection_Name.Visible = true;

                    Label_Connection_IP.SetPosition(0, 72);
                    Label_Connection_IP.SetSize(136, 36);
                    Label_Connection_IP.Anchors = Anchors.None;
                    Label_Connection_IP.Visible = true;

                    Label_isConnected.SetPosition(146, 0);
                    Label_isConnected.SetSize(204, 36);
                    Label_isConnected.Anchors = Anchors.None;
                    Label_isConnected.Visible = true;

                    Label_connectionName.SetPosition(146, 36);
                    Label_connectionName.SetSize(204, 36);
                    Label_connectionName.Anchors = Anchors.None;
                    Label_connectionName.Visible = true;

                    Label_IPAddress.SetPosition(146, 72);
                    Label_IPAddress.SetSize(204, 36);
                    Label_IPAddress.Anchors = Anchors.None;
                    Label_IPAddress.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_Connection_Status.Text = "Connection Status:";

            Label_Connection_Name.Text = "Connection Name:";

            Label_Connection_IP.Text = "Connection IP:";

            Label_isConnected.Text = "Connected";

            Label_connectionName.Text = "AJS PC";

            Label_IPAddress.Text = "192.168.1.66";
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
