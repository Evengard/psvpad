// Decompiled with JetBrains decompiler
// Type: PSV_Server.UserControl1
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using PSV_Server.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PSV_Server
{
    public class UserControl1 : UserControl
    {
        private IContainer components;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)Resources.psv;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = nameof(UserControl1);
            this.Size = new Size(527, 262);
            this.Load += new EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
        }

        public UserControl1()
        {
            this.InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
        }
    }
}
