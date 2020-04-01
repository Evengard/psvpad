// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class HelpPanel1
    {
        Panel Title;
        Label Label_Help;
        Label Label_1;
        Label Label_2;
        Label Label_3;
        Label Label_4;
        Label Label_5;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Title = new Panel();
            Title.Name = "Title";
            Label_Help = new Label();
            Label_Help.Name = "Label_Help";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Label_2 = new Label();
            Label_2.Name = "Label_2";
            Label_3 = new Label();
            Label_3.Name = "Label_3";
            Label_4 = new Label();
            Label_4.Name = "Label_4";
            Label_5 = new Label();
            Label_5.Name = "Label_5";

            // HelpPanel1
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Title);
            this.AddChildLast(Label_1);
            this.AddChildLast(Label_2);
            this.AddChildLast(Label_3);
            this.AddChildLast(Label_4);
            this.AddChildLast(Label_5);

            // Title
            Title.BackgroundColor = new UIColor(45f / 255f, 43f / 255f, 43f / 255f, 255f / 255f);
            Title.Clip = true;
            Title.AddChildLast(Label_Help);

            // Label_Help
            Label_Help.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_Help.Font = new UIFont(FontAlias.System, 60, FontStyle.Regular);
            Label_Help.LineBreak = LineBreak.Character;
            Label_Help.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(27f / 255f, 30f / 255f, 49f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            // Label_2
            Label_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 25, FontStyle.Bold);
            Label_2.LineBreak = LineBreak.Character;

            // Label_3
            Label_3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_3.Font = new UIFont(FontAlias.System, 25, FontStyle.Bold);
            Label_3.LineBreak = LineBreak.Character;

            // Label_4
            Label_4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_4.Font = new UIFont(FontAlias.System, 25, FontStyle.Bold);
            Label_4.LineBreak = LineBreak.Character;

            // Label_5
            Label_5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_5.Font = new UIFont(FontAlias.System, 25, FontStyle.Bold);
            Label_5.LineBreak = LineBreak.Character;

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

                    Label_Help.SetPosition(89, 22);
                    Label_Help.SetSize(214, 36);
                    Label_Help.Anchors = Anchors.None;
                    Label_Help.Visible = true;

                    Label_1.SetPosition(117, 185);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(117, 185);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(117, 185);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(117, 185);
                    Label_4.SetSize(214, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    Label_5.SetPosition(117, 185);
                    Label_5.SetSize(214, 36);
                    Label_5.Anchors = Anchors.None;
                    Label_5.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Title.SetPosition(0, 0);
                    Title.SetSize(960, 100);
                    Title.Anchors = Anchors.None;
                    Title.Visible = true;

                    Label_Help.SetPosition(0, 3);
                    Label_Help.SetSize(850, 97);
                    Label_Help.Anchors = Anchors.None;
                    Label_Help.Visible = true;

                    Label_1.SetPosition(17, 110);
                    Label_1.SetSize(925, 114);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(17, 237);
                    Label_2.SetSize(151, 46);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(17, 291);
                    Label_3.SetSize(925, 57);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(17, 355);
                    Label_4.SetSize(925, 75);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    Label_5.SetPosition(17, 437);
                    Label_5.SetSize(925, 47);
                    Label_5.Anchors = Anchors.None;
                    Label_5.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_Help.Text = "PSV-PAD 1.3.0- HELP";

            Label_1.Text = "Welcome to PSVPAD, This software is currently in ALPHA and as such you may notice it's not quite complete! SORRY!, The help pages have not been compiled so to speak as of yet. Hopefully they'll be available in the next update!";

            Label_2.Text = "Quick Help";

            Label_3.Text = "*New connections can be added in connection settings";

            Label_4.Text = "*You can access connection settings by going to configuration panel and swiping accross ";

            Label_5.Text = "*Enter your pc ip in the relevant text box - Then add & connect";
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
