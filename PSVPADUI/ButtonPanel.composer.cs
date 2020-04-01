// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class ButtonPanel
    {
        Button Add_Buttons;
        Button Keyboard_Button;
        Button Touchpad_Button;
        Button Configuration_Button;
        Button About_Button;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Add_Buttons = new Button();
            Add_Buttons.Name = "Add_Buttons";
            Keyboard_Button = new Button();
            Keyboard_Button.Name = "Keyboard_Button";
            Touchpad_Button = new Button();
            Touchpad_Button.Name = "Touchpad_Button";
            Configuration_Button = new Button();
            Configuration_Button.Name = "Configuration_Button";
            About_Button = new Button();
            About_Button.Name = "About_Button";

            // ButtonPanel
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(Add_Buttons);
            this.AddChildLast(Keyboard_Button);
            this.AddChildLast(Touchpad_Button);
            this.AddChildLast(Configuration_Button);
            this.AddChildLast(About_Button);

            // Add_Buttons
            Add_Buttons.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Add_Buttons.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Add_Buttons.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Keyboard_Button
            Keyboard_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Keyboard_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Keyboard_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Touchpad_Button
            Touchpad_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Touchpad_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Touchpad_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // Configuration_Button
            Configuration_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Configuration_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Configuration_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // About_Button
            About_Button.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            About_Button.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            About_Button.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

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

                    Add_Buttons.SetPosition(100, 245);
                    Add_Buttons.SetSize(214, 56);
                    Add_Buttons.Anchors = Anchors.None;
                    Add_Buttons.Visible = true;

                    Keyboard_Button.SetPosition(100, 245);
                    Keyboard_Button.SetSize(214, 56);
                    Keyboard_Button.Anchors = Anchors.None;
                    Keyboard_Button.Visible = true;

                    Touchpad_Button.SetPosition(100, 245);
                    Touchpad_Button.SetSize(214, 56);
                    Touchpad_Button.Anchors = Anchors.None;
                    Touchpad_Button.Visible = true;

                    Configuration_Button.SetPosition(100, 245);
                    Configuration_Button.SetSize(214, 56);
                    Configuration_Button.Anchors = Anchors.None;
                    Configuration_Button.Visible = true;

                    About_Button.SetPosition(100, 245);
                    About_Button.SetSize(214, 56);
                    About_Button.Anchors = Anchors.None;
                    About_Button.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Add_Buttons.SetPosition(0, 478);
                    Add_Buttons.SetSize(208, 66);
                    Add_Buttons.Anchors = Anchors.None;
                    Add_Buttons.Visible = true;

                    Keyboard_Button.SetPosition(207, 478);
                    Keyboard_Button.SetSize(208, 66);
                    Keyboard_Button.Anchors = Anchors.None;
                    Keyboard_Button.Visible = true;

                    Touchpad_Button.SetPosition(415, 478);
                    Touchpad_Button.SetSize(208, 66);
                    Touchpad_Button.Anchors = Anchors.None;
                    Touchpad_Button.Visible = true;

                    Configuration_Button.SetPosition(623, 478);
                    Configuration_Button.SetSize(208, 66);
                    Configuration_Button.Anchors = Anchors.None;
                    Configuration_Button.Visible = true;

                    About_Button.SetPosition(832, 478);
                    About_Button.SetSize(128, 66);
                    About_Button.Anchors = Anchors.None;
                    About_Button.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Add_Buttons.Text = "Additional Buttons";

            Keyboard_Button.Text = "Keyboard";

            Touchpad_Button.Text = "Touch Pad";

            Configuration_Button.Text = "Configuration";

            About_Button.Text = "Help";
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
