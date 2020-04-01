// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class TBC
    {
        Panel Title;
        Label Label_1;
        Label Label_2;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Title = new Panel();
            Title.Name = "Title";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Label_2 = new Label();
            Label_2.Name = "Label_2";

            // TBC
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Title);
            this.AddChildLast(Label_1);
            this.AddChildLast(Label_2);

            // Title
            Title.BackgroundColor = new UIColor(45f / 255f, 43f / 255f, 43f / 255f, 255f / 255f);
            Title.Clip = true;

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 60, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.TextShadow = new TextShadowSettings()
            {
                Color = new UIColor(27f / 255f, 30f / 255f, 49f / 255f, 127f / 255f),
                HorizontalOffset = 2f,
                VerticalOffset = 2f,
            };

            // Label_2
            Label_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_2.LineBreak = LineBreak.Character;

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

                    Label_1.SetPosition(89, 22);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(117, 185);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Title.SetPosition(0, 0);
                    Title.SetSize(960, 100);
                    Title.Anchors = Anchors.None;
                    Title.Visible = true;

                    Label_1.SetPosition(53, 0);
                    Label_1.SetSize(850, 97);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(8, 100);
                    Label_2.SetSize(925, 114);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "To Be Confirmed?";

            Label_2.Text = "What should go here, whats lacking, what else do you need from a controller?";
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
