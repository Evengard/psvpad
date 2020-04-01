// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class KeyboardDialog
    {
        PagePanel PagePanel_1;
        Button SwitchKeysBtn;
        Button SpaceBtn;
        Button LeftBtn;
        Button RightBtn;
        Button FullStopBtn;
        Button CommerBtn;
        Button BackSpaceBtn;
        Button CloseKeyboardBtn;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            PagePanel_1 = new PagePanel();
            PagePanel_1.Name = "PagePanel_1";
            SwitchKeysBtn = new Button();
            SwitchKeysBtn.Name = "SwitchKeysBtn";
            SpaceBtn = new Button();
            SpaceBtn.Name = "SpaceBtn";
            LeftBtn = new Button();
            LeftBtn.Name = "LeftBtn";
            RightBtn = new Button();
            RightBtn.Name = "RightBtn";
            FullStopBtn = new Button();
            FullStopBtn.Name = "FullStopBtn";
            CommerBtn = new Button();
            CommerBtn.Name = "CommerBtn";
            BackSpaceBtn = new Button();
            BackSpaceBtn.Name = "BackSpaceBtn";
            CloseKeyboardBtn = new Button();
            CloseKeyboardBtn.Name = "CloseKeyboardBtn";

            // KeyboardDialog
            this.BackgroundStyle = DialogBackgroundStyle.Custom;
            this.CustomBackgroundImage = null;
            this.CustomBackgroundNinePatchMargin = new NinePatchMargin(34, 34, 34, 34);
            this.CustomBackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 0f / 255f);
            this.AddChildLast(PagePanel_1);
            this.AddChildLast(SwitchKeysBtn);
            this.AddChildLast(SpaceBtn);
            this.AddChildLast(LeftBtn);
            this.AddChildLast(RightBtn);
            this.AddChildLast(FullStopBtn);
            this.AddChildLast(CommerBtn);
            this.AddChildLast(BackSpaceBtn);
            this.AddChildLast(CloseKeyboardBtn);
            this.ShowEffect = new FadeInEffect()
            {
            };
            this.HideEffect = new TiltDropEffect();

            // PagePanel_1
            PagePanel_1.AddPage(new KeyboardPanel1());

            // SwitchKeysBtn
            SwitchKeysBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            SwitchKeysBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            SwitchKeysBtn.TextTrimming = TextTrimming.None;
            SwitchKeysBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // SpaceBtn
            SpaceBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            SpaceBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            SpaceBtn.TextTrimming = TextTrimming.None;
            SpaceBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // LeftBtn
            LeftBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            LeftBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            LeftBtn.TextTrimming = TextTrimming.None;
            LeftBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // RightBtn
            RightBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            RightBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            RightBtn.TextTrimming = TextTrimming.None;
            RightBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // FullStopBtn
            FullStopBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            FullStopBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            FullStopBtn.TextTrimming = TextTrimming.None;
            FullStopBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // CommerBtn
            CommerBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            CommerBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            CommerBtn.TextTrimming = TextTrimming.None;
            CommerBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // BackSpaceBtn
            BackSpaceBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            BackSpaceBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            BackSpaceBtn.TextTrimming = TextTrimming.None;
            BackSpaceBtn.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // CloseKeyboardBtn
            CloseKeyboardBtn.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            CloseKeyboardBtn.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            CloseKeyboardBtn.TextTrimming = TextTrimming.None;
            CloseKeyboardBtn.BackgroundFilterColor = new UIColor(45f / 255f, 45f / 255f, 45f / 255f, 255f / 255f);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetPosition(0, 0);
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    PagePanel_1.SetPosition(257, 185);
                    PagePanel_1.SetSize(100, 50);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    SwitchKeysBtn.SetPosition(100, 245);
                    SwitchKeysBtn.SetSize(214, 56);
                    SwitchKeysBtn.Anchors = Anchors.None;
                    SwitchKeysBtn.Visible = true;

                    SpaceBtn.SetPosition(100, 245);
                    SpaceBtn.SetSize(214, 56);
                    SpaceBtn.Anchors = Anchors.None;
                    SpaceBtn.Visible = true;

                    LeftBtn.SetPosition(100, 245);
                    LeftBtn.SetSize(214, 56);
                    LeftBtn.Anchors = Anchors.None;
                    LeftBtn.Visible = true;

                    RightBtn.SetPosition(100, 245);
                    RightBtn.SetSize(214, 56);
                    RightBtn.Anchors = Anchors.None;
                    RightBtn.Visible = true;

                    FullStopBtn.SetPosition(100, 245);
                    FullStopBtn.SetSize(214, 56);
                    FullStopBtn.Anchors = Anchors.None;
                    FullStopBtn.Visible = true;

                    CommerBtn.SetPosition(100, 245);
                    CommerBtn.SetSize(214, 56);
                    CommerBtn.Anchors = Anchors.None;
                    CommerBtn.Visible = true;

                    BackSpaceBtn.SetPosition(100, 245);
                    BackSpaceBtn.SetSize(214, 56);
                    BackSpaceBtn.Anchors = Anchors.None;
                    BackSpaceBtn.Visible = true;

                    CloseKeyboardBtn.SetPosition(100, 245);
                    CloseKeyboardBtn.SetSize(214, 56);
                    CloseKeyboardBtn.Anchors = Anchors.None;
                    CloseKeyboardBtn.Visible = true;

                    break;

                default:
                    this.SetPosition(0, 194);
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    PagePanel_1.SetPosition(0, 194);
                    PagePanel_1.SetSize(960, 350);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    SwitchKeysBtn.SetPosition(85, 481);
                    SwitchKeysBtn.SetSize(98, 54);
                    SwitchKeysBtn.Anchors = Anchors.None;
                    SwitchKeysBtn.Visible = true;

                    SpaceBtn.SetPosition(352, 481);
                    SpaceBtn.SetSize(275, 54);
                    SpaceBtn.Anchors = Anchors.None;
                    SpaceBtn.Visible = true;

                    LeftBtn.SetPosition(267, 481);
                    LeftBtn.SetSize(85, 54);
                    LeftBtn.Anchors = Anchors.None;
                    LeftBtn.Visible = true;

                    RightBtn.SetPosition(628, 481);
                    RightBtn.SetSize(85, 54);
                    RightBtn.Anchors = Anchors.None;
                    RightBtn.Visible = true;

                    FullStopBtn.SetPosition(713, 481);
                    FullStopBtn.SetSize(85, 54);
                    FullStopBtn.Anchors = Anchors.None;
                    FullStopBtn.Visible = true;

                    CommerBtn.SetPosition(182, 481);
                    CommerBtn.SetSize(85, 54);
                    CommerBtn.Anchors = Anchors.None;
                    CommerBtn.Visible = true;

                    BackSpaceBtn.SetPosition(798, 481);
                    BackSpaceBtn.SetSize(161, 54);
                    BackSpaceBtn.Anchors = Anchors.None;
                    BackSpaceBtn.Visible = true;

                    CloseKeyboardBtn.SetPosition(0, 481);
                    CloseKeyboardBtn.SetSize(85, 54);
                    CloseKeyboardBtn.Anchors = Anchors.None;
                    CloseKeyboardBtn.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            SwitchKeysBtn.Text = "@123";

            SpaceBtn.Text = "Space";

            LeftBtn.Text = "Left";

            RightBtn.Text = "Right";

            FullStopBtn.Text = ".";

            CommerBtn.Text = ",";

            BackSpaceBtn.Text = "Enter";

            CloseKeyboardBtn.Text = "X";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
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
