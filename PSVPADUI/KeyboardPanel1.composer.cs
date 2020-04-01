// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    partial class KeyboardPanel1
    {
        Button keyboard_shift;
        Button keyboard_q;
        Button keyboard_1;
        Button keyboard_w;
        Button keyboard_e;
        Button keyboard_r;
        Button keyboard_t;
        Button keyboard_y;
        Button keyboard_u;
        Button keyboard_i;
        Button keyboard_o;
        Button keyboard_p;
        Button keyboard_a;
        Button keyboard_s;
        Button keyboard_d;
        Button keyboard_f;
        Button keyboard_g;
        Button keyboard_h;
        Button keyboard_j;
        Button keyboard_k;
        Button keyboard_l;
        Button keyboard_z;
        Button keyboard_x;
        Button keyboard_c;
        Button keyboard_v;
        Button keyboard_b;
        Button keyboard_n;
        Button keyboard_m;
        Button keyboard_2;
        Button keyboard_4;
        Button keyboard_3;
        Button keyboard_5;
        Button keyboard_6;
        Button keyboard_7;
        Button keyboard_8;
        Button keyboard_9;
        Button keyboard_0;
        Button keyboard_backspace;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            keyboard_shift = new Button();
            keyboard_shift.Name = "keyboard_shift";
            keyboard_q = new Button();
            keyboard_q.Name = "keyboard_q";
            keyboard_1 = new Button();
            keyboard_1.Name = "keyboard_1";
            keyboard_w = new Button();
            keyboard_w.Name = "keyboard_w";
            keyboard_e = new Button();
            keyboard_e.Name = "keyboard_e";
            keyboard_r = new Button();
            keyboard_r.Name = "keyboard_r";
            keyboard_t = new Button();
            keyboard_t.Name = "keyboard_t";
            keyboard_y = new Button();
            keyboard_y.Name = "keyboard_y";
            keyboard_u = new Button();
            keyboard_u.Name = "keyboard_u";
            keyboard_i = new Button();
            keyboard_i.Name = "keyboard_i";
            keyboard_o = new Button();
            keyboard_o.Name = "keyboard_o";
            keyboard_p = new Button();
            keyboard_p.Name = "keyboard_p";
            keyboard_a = new Button();
            keyboard_a.Name = "keyboard_a";
            keyboard_s = new Button();
            keyboard_s.Name = "keyboard_s";
            keyboard_d = new Button();
            keyboard_d.Name = "keyboard_d";
            keyboard_f = new Button();
            keyboard_f.Name = "keyboard_f";
            keyboard_g = new Button();
            keyboard_g.Name = "keyboard_g";
            keyboard_h = new Button();
            keyboard_h.Name = "keyboard_h";
            keyboard_j = new Button();
            keyboard_j.Name = "keyboard_j";
            keyboard_k = new Button();
            keyboard_k.Name = "keyboard_k";
            keyboard_l = new Button();
            keyboard_l.Name = "keyboard_l";
            keyboard_z = new Button();
            keyboard_z.Name = "keyboard_z";
            keyboard_x = new Button();
            keyboard_x.Name = "keyboard_x";
            keyboard_c = new Button();
            keyboard_c.Name = "keyboard_c";
            keyboard_v = new Button();
            keyboard_v.Name = "keyboard_v";
            keyboard_b = new Button();
            keyboard_b.Name = "keyboard_b";
            keyboard_n = new Button();
            keyboard_n.Name = "keyboard_n";
            keyboard_m = new Button();
            keyboard_m.Name = "keyboard_m";
            keyboard_2 = new Button();
            keyboard_2.Name = "keyboard_2";
            keyboard_4 = new Button();
            keyboard_4.Name = "keyboard_4";
            keyboard_3 = new Button();
            keyboard_3.Name = "keyboard_3";
            keyboard_5 = new Button();
            keyboard_5.Name = "keyboard_5";
            keyboard_6 = new Button();
            keyboard_6.Name = "keyboard_6";
            keyboard_7 = new Button();
            keyboard_7.Name = "keyboard_7";
            keyboard_8 = new Button();
            keyboard_8.Name = "keyboard_8";
            keyboard_9 = new Button();
            keyboard_9.Name = "keyboard_9";
            keyboard_0 = new Button();
            keyboard_0.Name = "keyboard_0";
            keyboard_backspace = new Button();
            keyboard_backspace.Name = "keyboard_backspace";

            // KeyboardPanel1
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(keyboard_shift);
            this.AddChildLast(keyboard_q);
            this.AddChildLast(keyboard_1);
            this.AddChildLast(keyboard_w);
            this.AddChildLast(keyboard_e);
            this.AddChildLast(keyboard_r);
            this.AddChildLast(keyboard_t);
            this.AddChildLast(keyboard_y);
            this.AddChildLast(keyboard_u);
            this.AddChildLast(keyboard_i);
            this.AddChildLast(keyboard_o);
            this.AddChildLast(keyboard_p);
            this.AddChildLast(keyboard_a);
            this.AddChildLast(keyboard_s);
            this.AddChildLast(keyboard_d);
            this.AddChildLast(keyboard_f);
            this.AddChildLast(keyboard_g);
            this.AddChildLast(keyboard_h);
            this.AddChildLast(keyboard_j);
            this.AddChildLast(keyboard_k);
            this.AddChildLast(keyboard_l);
            this.AddChildLast(keyboard_z);
            this.AddChildLast(keyboard_x);
            this.AddChildLast(keyboard_c);
            this.AddChildLast(keyboard_v);
            this.AddChildLast(keyboard_b);
            this.AddChildLast(keyboard_n);
            this.AddChildLast(keyboard_m);
            this.AddChildLast(keyboard_2);
            this.AddChildLast(keyboard_4);
            this.AddChildLast(keyboard_3);
            this.AddChildLast(keyboard_5);
            this.AddChildLast(keyboard_6);
            this.AddChildLast(keyboard_7);
            this.AddChildLast(keyboard_8);
            this.AddChildLast(keyboard_9);
            this.AddChildLast(keyboard_0);
            this.AddChildLast(keyboard_backspace);

            // keyboard_shift
            keyboard_shift.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_shift.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_shift.TextTrimming = TextTrimming.None;
            keyboard_shift.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_q
            keyboard_q.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_q.TextFont = new UIFont(FontAlias.System, 30, FontStyle.Regular);
            keyboard_q.TextTrimming = TextTrimming.None;
            keyboard_q.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_1
            keyboard_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_1.TextTrimming = TextTrimming.None;
            keyboard_1.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_w
            keyboard_w.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_w.TextFont = new UIFont(FontAlias.System, 30, FontStyle.Regular);
            keyboard_w.TextTrimming = TextTrimming.None;
            keyboard_w.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_e
            keyboard_e.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_e.TextFont = new UIFont(FontAlias.System, 30, FontStyle.Regular);
            keyboard_e.TextTrimming = TextTrimming.None;
            keyboard_e.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_r
            keyboard_r.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_r.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_r.TextTrimming = TextTrimming.None;
            keyboard_r.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_t
            keyboard_t.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_t.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_t.TextTrimming = TextTrimming.None;
            keyboard_t.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_y
            keyboard_y.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_y.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_y.TextTrimming = TextTrimming.None;
            keyboard_y.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_u
            keyboard_u.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_u.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_u.TextTrimming = TextTrimming.None;
            keyboard_u.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_i
            keyboard_i.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_i.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_i.TextTrimming = TextTrimming.None;
            keyboard_i.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_o
            keyboard_o.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_o.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_o.TextTrimming = TextTrimming.None;
            keyboard_o.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_p
            keyboard_p.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_p.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_p.TextTrimming = TextTrimming.None;
            keyboard_p.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_a
            keyboard_a.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_a.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_a.TextTrimming = TextTrimming.None;
            keyboard_a.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_s
            keyboard_s.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_s.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_s.TextTrimming = TextTrimming.None;
            keyboard_s.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_d
            keyboard_d.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_d.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_d.TextTrimming = TextTrimming.None;
            keyboard_d.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_f
            keyboard_f.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_f.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_f.TextTrimming = TextTrimming.None;
            keyboard_f.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_g
            keyboard_g.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_g.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_g.TextTrimming = TextTrimming.None;
            keyboard_g.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_h
            keyboard_h.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_h.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_h.TextTrimming = TextTrimming.None;
            keyboard_h.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_j
            keyboard_j.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_j.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_j.TextTrimming = TextTrimming.None;
            keyboard_j.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_k
            keyboard_k.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_k.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_k.TextTrimming = TextTrimming.None;
            keyboard_k.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_l
            keyboard_l.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_l.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_l.TextTrimming = TextTrimming.None;
            keyboard_l.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_z
            keyboard_z.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_z.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_z.TextTrimming = TextTrimming.None;
            keyboard_z.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_x
            keyboard_x.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_x.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_x.TextTrimming = TextTrimming.None;
            keyboard_x.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_c
            keyboard_c.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_c.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_c.TextTrimming = TextTrimming.None;
            keyboard_c.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_v
            keyboard_v.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_v.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_v.TextTrimming = TextTrimming.None;
            keyboard_v.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_b
            keyboard_b.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_b.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_b.TextTrimming = TextTrimming.None;
            keyboard_b.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_n
            keyboard_n.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_n.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_n.TextTrimming = TextTrimming.None;
            keyboard_n.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_m
            keyboard_m.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_m.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_m.TextTrimming = TextTrimming.None;
            keyboard_m.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_2
            keyboard_2.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_2.TextTrimming = TextTrimming.None;
            keyboard_2.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_4
            keyboard_4.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_4.TextTrimming = TextTrimming.None;
            keyboard_4.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_3
            keyboard_3.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_3.TextTrimming = TextTrimming.None;
            keyboard_3.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_5
            keyboard_5.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_5.TextTrimming = TextTrimming.None;
            keyboard_5.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_6
            keyboard_6.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_6.TextTrimming = TextTrimming.None;
            keyboard_6.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_7
            keyboard_7.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_7.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_7.TextTrimming = TextTrimming.None;
            keyboard_7.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_8
            keyboard_8.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_8.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_8.TextTrimming = TextTrimming.None;
            keyboard_8.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_9
            keyboard_9.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_9.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_9.TextTrimming = TextTrimming.None;
            keyboard_9.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_0
            keyboard_0.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_0.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_0.TextTrimming = TextTrimming.None;
            keyboard_0.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            // keyboard_backspace
            keyboard_backspace.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            keyboard_backspace.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            keyboard_backspace.TextTrimming = TextTrimming.None;
            keyboard_backspace.BackgroundFilterColor = new UIColor(108f / 255f, 108f / 255f, 108f / 255f, 255f / 255f);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(350, 960);
                    this.Anchors = Anchors.None;

                    keyboard_shift.SetPosition(100, 245);
                    keyboard_shift.SetSize(214, 56);
                    keyboard_shift.Anchors = Anchors.None;
                    keyboard_shift.Visible = true;

                    keyboard_q.SetPosition(100, 245);
                    keyboard_q.SetSize(214, 56);
                    keyboard_q.Anchors = Anchors.None;
                    keyboard_q.Visible = true;

                    keyboard_1.SetPosition(100, 245);
                    keyboard_1.SetSize(214, 56);
                    keyboard_1.Anchors = Anchors.None;
                    keyboard_1.Visible = true;

                    keyboard_w.SetPosition(100, 245);
                    keyboard_w.SetSize(214, 56);
                    keyboard_w.Anchors = Anchors.None;
                    keyboard_w.Visible = true;

                    keyboard_e.SetPosition(100, 245);
                    keyboard_e.SetSize(214, 56);
                    keyboard_e.Anchors = Anchors.None;
                    keyboard_e.Visible = true;

                    keyboard_r.SetPosition(100, 245);
                    keyboard_r.SetSize(214, 56);
                    keyboard_r.Anchors = Anchors.None;
                    keyboard_r.Visible = true;

                    keyboard_t.SetPosition(100, 245);
                    keyboard_t.SetSize(214, 56);
                    keyboard_t.Anchors = Anchors.None;
                    keyboard_t.Visible = true;

                    keyboard_y.SetPosition(100, 245);
                    keyboard_y.SetSize(214, 56);
                    keyboard_y.Anchors = Anchors.None;
                    keyboard_y.Visible = true;

                    keyboard_u.SetPosition(100, 245);
                    keyboard_u.SetSize(214, 56);
                    keyboard_u.Anchors = Anchors.None;
                    keyboard_u.Visible = true;

                    keyboard_i.SetPosition(100, 245);
                    keyboard_i.SetSize(214, 56);
                    keyboard_i.Anchors = Anchors.None;
                    keyboard_i.Visible = true;

                    keyboard_o.SetPosition(100, 245);
                    keyboard_o.SetSize(214, 56);
                    keyboard_o.Anchors = Anchors.None;
                    keyboard_o.Visible = true;

                    keyboard_p.SetPosition(100, 245);
                    keyboard_p.SetSize(214, 56);
                    keyboard_p.Anchors = Anchors.None;
                    keyboard_p.Visible = true;

                    keyboard_a.SetPosition(100, 245);
                    keyboard_a.SetSize(214, 56);
                    keyboard_a.Anchors = Anchors.None;
                    keyboard_a.Visible = true;

                    keyboard_s.SetPosition(100, 245);
                    keyboard_s.SetSize(214, 56);
                    keyboard_s.Anchors = Anchors.None;
                    keyboard_s.Visible = true;

                    keyboard_d.SetPosition(100, 245);
                    keyboard_d.SetSize(214, 56);
                    keyboard_d.Anchors = Anchors.None;
                    keyboard_d.Visible = true;

                    keyboard_f.SetPosition(100, 245);
                    keyboard_f.SetSize(214, 56);
                    keyboard_f.Anchors = Anchors.None;
                    keyboard_f.Visible = true;

                    keyboard_g.SetPosition(100, 245);
                    keyboard_g.SetSize(214, 56);
                    keyboard_g.Anchors = Anchors.None;
                    keyboard_g.Visible = true;

                    keyboard_h.SetPosition(100, 245);
                    keyboard_h.SetSize(214, 56);
                    keyboard_h.Anchors = Anchors.None;
                    keyboard_h.Visible = true;

                    keyboard_j.SetPosition(100, 245);
                    keyboard_j.SetSize(214, 56);
                    keyboard_j.Anchors = Anchors.None;
                    keyboard_j.Visible = true;

                    keyboard_k.SetPosition(100, 245);
                    keyboard_k.SetSize(214, 56);
                    keyboard_k.Anchors = Anchors.None;
                    keyboard_k.Visible = true;

                    keyboard_l.SetPosition(100, 245);
                    keyboard_l.SetSize(214, 56);
                    keyboard_l.Anchors = Anchors.None;
                    keyboard_l.Visible = true;

                    keyboard_z.SetPosition(100, 245);
                    keyboard_z.SetSize(214, 56);
                    keyboard_z.Anchors = Anchors.None;
                    keyboard_z.Visible = true;

                    keyboard_x.SetPosition(100, 245);
                    keyboard_x.SetSize(214, 56);
                    keyboard_x.Anchors = Anchors.None;
                    keyboard_x.Visible = true;

                    keyboard_c.SetPosition(100, 245);
                    keyboard_c.SetSize(214, 56);
                    keyboard_c.Anchors = Anchors.None;
                    keyboard_c.Visible = true;

                    keyboard_v.SetPosition(100, 245);
                    keyboard_v.SetSize(214, 56);
                    keyboard_v.Anchors = Anchors.None;
                    keyboard_v.Visible = true;

                    keyboard_b.SetPosition(100, 245);
                    keyboard_b.SetSize(214, 56);
                    keyboard_b.Anchors = Anchors.None;
                    keyboard_b.Visible = true;

                    keyboard_n.SetPosition(100, 245);
                    keyboard_n.SetSize(214, 56);
                    keyboard_n.Anchors = Anchors.None;
                    keyboard_n.Visible = true;

                    keyboard_m.SetPosition(100, 245);
                    keyboard_m.SetSize(214, 56);
                    keyboard_m.Anchors = Anchors.None;
                    keyboard_m.Visible = true;

                    keyboard_2.SetPosition(100, 245);
                    keyboard_2.SetSize(214, 56);
                    keyboard_2.Anchors = Anchors.None;
                    keyboard_2.Visible = true;

                    keyboard_4.SetPosition(100, 245);
                    keyboard_4.SetSize(214, 56);
                    keyboard_4.Anchors = Anchors.None;
                    keyboard_4.Visible = true;

                    keyboard_3.SetPosition(100, 245);
                    keyboard_3.SetSize(214, 56);
                    keyboard_3.Anchors = Anchors.None;
                    keyboard_3.Visible = true;

                    keyboard_5.SetPosition(100, 245);
                    keyboard_5.SetSize(214, 56);
                    keyboard_5.Anchors = Anchors.None;
                    keyboard_5.Visible = true;

                    keyboard_6.SetPosition(100, 245);
                    keyboard_6.SetSize(214, 56);
                    keyboard_6.Anchors = Anchors.None;
                    keyboard_6.Visible = true;

                    keyboard_7.SetPosition(100, 245);
                    keyboard_7.SetSize(214, 56);
                    keyboard_7.Anchors = Anchors.None;
                    keyboard_7.Visible = true;

                    keyboard_8.SetPosition(100, 245);
                    keyboard_8.SetSize(214, 56);
                    keyboard_8.Anchors = Anchors.None;
                    keyboard_8.Visible = true;

                    keyboard_9.SetPosition(100, 245);
                    keyboard_9.SetSize(214, 56);
                    keyboard_9.Anchors = Anchors.None;
                    keyboard_9.Visible = true;

                    keyboard_0.SetPosition(100, 245);
                    keyboard_0.SetSize(214, 56);
                    keyboard_0.Anchors = Anchors.None;
                    keyboard_0.Visible = true;

                    keyboard_backspace.SetPosition(100, 245);
                    keyboard_backspace.SetSize(214, 56);
                    keyboard_backspace.Anchors = Anchors.None;
                    keyboard_backspace.Visible = true;

                    break;

                default:
                    this.SetSize(960, 350);
                    this.Anchors = Anchors.None;

                    keyboard_shift.SetPosition(20, 233);
                    keyboard_shift.SetSize(138, 54);
                    keyboard_shift.Anchors = Anchors.None;
                    keyboard_shift.Visible = true;

                    keyboard_q.SetPosition(20, 125);
                    keyboard_q.SetSize(92, 54);
                    keyboard_q.Anchors = Anchors.None;
                    keyboard_q.Visible = true;

                    keyboard_1.SetPosition(0, 71);
                    keyboard_1.SetSize(84, 54);
                    keyboard_1.Anchors = Anchors.None;
                    keyboard_1.Visible = true;

                    keyboard_w.SetPosition(112, 126);
                    keyboard_w.SetSize(92, 54);
                    keyboard_w.Anchors = Anchors.None;
                    keyboard_w.Visible = true;

                    keyboard_e.SetPosition(204, 125);
                    keyboard_e.SetSize(92, 54);
                    keyboard_e.Anchors = Anchors.None;
                    keyboard_e.Visible = true;

                    keyboard_r.SetPosition(296, 126);
                    keyboard_r.SetSize(92, 54);
                    keyboard_r.Anchors = Anchors.None;
                    keyboard_r.Visible = true;

                    keyboard_t.SetPosition(388, 126);
                    keyboard_t.SetSize(92, 54);
                    keyboard_t.Anchors = Anchors.None;
                    keyboard_t.Visible = true;

                    keyboard_y.SetPosition(481, 126);
                    keyboard_y.SetSize(92, 54);
                    keyboard_y.Anchors = Anchors.None;
                    keyboard_y.Visible = true;

                    keyboard_u.SetPosition(573, 126);
                    keyboard_u.SetSize(92, 54);
                    keyboard_u.Anchors = Anchors.None;
                    keyboard_u.Visible = true;

                    keyboard_i.SetPosition(665, 126);
                    keyboard_i.SetSize(92, 54);
                    keyboard_i.Anchors = Anchors.None;
                    keyboard_i.Visible = true;

                    keyboard_o.SetPosition(757, 126);
                    keyboard_o.SetSize(92, 54);
                    keyboard_o.Anchors = Anchors.None;
                    keyboard_o.Visible = true;

                    keyboard_p.SetPosition(849, 126);
                    keyboard_p.SetSize(92, 54);
                    keyboard_p.Anchors = Anchors.None;
                    keyboard_p.Visible = true;

                    keyboard_a.SetPosition(68, 179);
                    keyboard_a.SetSize(92, 54);
                    keyboard_a.Anchors = Anchors.None;
                    keyboard_a.Visible = true;

                    keyboard_s.SetPosition(160, 179);
                    keyboard_s.SetSize(92, 54);
                    keyboard_s.Anchors = Anchors.None;
                    keyboard_s.Visible = true;

                    keyboard_d.SetPosition(252, 179);
                    keyboard_d.SetSize(92, 54);
                    keyboard_d.Anchors = Anchors.None;
                    keyboard_d.Visible = true;

                    keyboard_f.SetPosition(344, 179);
                    keyboard_f.SetSize(92, 54);
                    keyboard_f.Anchors = Anchors.None;
                    keyboard_f.Visible = true;

                    keyboard_g.SetPosition(436, 179);
                    keyboard_g.SetSize(92, 54);
                    keyboard_g.Anchors = Anchors.None;
                    keyboard_g.Visible = true;

                    keyboard_h.SetPosition(529, 179);
                    keyboard_h.SetSize(92, 54);
                    keyboard_h.Anchors = Anchors.None;
                    keyboard_h.Visible = true;

                    keyboard_j.SetPosition(621, 179);
                    keyboard_j.SetSize(92, 54);
                    keyboard_j.Anchors = Anchors.None;
                    keyboard_j.Visible = true;

                    keyboard_k.SetPosition(713, 179);
                    keyboard_k.SetSize(92, 54);
                    keyboard_k.Anchors = Anchors.None;
                    keyboard_k.Visible = true;

                    keyboard_l.SetPosition(805, 179);
                    keyboard_l.SetSize(92, 54);
                    keyboard_l.Anchors = Anchors.None;
                    keyboard_l.Visible = true;

                    keyboard_z.SetPosition(159, 234);
                    keyboard_z.SetSize(92, 54);
                    keyboard_z.Anchors = Anchors.None;
                    keyboard_z.Visible = true;

                    keyboard_x.SetPosition(251, 234);
                    keyboard_x.SetSize(92, 54);
                    keyboard_x.Anchors = Anchors.None;
                    keyboard_x.Visible = true;

                    keyboard_c.SetPosition(343, 234);
                    keyboard_c.SetSize(92, 54);
                    keyboard_c.Anchors = Anchors.None;
                    keyboard_c.Visible = true;

                    keyboard_v.SetPosition(435, 234);
                    keyboard_v.SetSize(92, 54);
                    keyboard_v.Anchors = Anchors.None;
                    keyboard_v.Visible = true;

                    keyboard_b.SetPosition(527, 234);
                    keyboard_b.SetSize(92, 54);
                    keyboard_b.Anchors = Anchors.None;
                    keyboard_b.Visible = true;

                    keyboard_n.SetPosition(620, 234);
                    keyboard_n.SetSize(92, 54);
                    keyboard_n.Anchors = Anchors.None;
                    keyboard_n.Visible = true;

                    keyboard_m.SetPosition(712, 234);
                    keyboard_m.SetSize(92, 54);
                    keyboard_m.Anchors = Anchors.None;
                    keyboard_m.Visible = true;

                    keyboard_2.SetPosition(84, 71);
                    keyboard_2.SetSize(84, 54);
                    keyboard_2.Anchors = Anchors.None;
                    keyboard_2.Visible = true;

                    keyboard_4.SetPosition(252, 71);
                    keyboard_4.SetSize(84, 54);
                    keyboard_4.Anchors = Anchors.None;
                    keyboard_4.Visible = true;

                    keyboard_3.SetPosition(168, 71);
                    keyboard_3.SetSize(84, 54);
                    keyboard_3.Anchors = Anchors.None;
                    keyboard_3.Visible = true;

                    keyboard_5.SetPosition(336, 71);
                    keyboard_5.SetSize(84, 54);
                    keyboard_5.Anchors = Anchors.None;
                    keyboard_5.Visible = true;

                    keyboard_6.SetPosition(420, 71);
                    keyboard_6.SetSize(84, 54);
                    keyboard_6.Anchors = Anchors.None;
                    keyboard_6.Visible = true;

                    keyboard_7.SetPosition(504, 71);
                    keyboard_7.SetSize(84, 54);
                    keyboard_7.Anchors = Anchors.None;
                    keyboard_7.Visible = true;

                    keyboard_8.SetPosition(588, 71);
                    keyboard_8.SetSize(84, 54);
                    keyboard_8.Anchors = Anchors.None;
                    keyboard_8.Visible = true;

                    keyboard_9.SetPosition(672, 71);
                    keyboard_9.SetSize(84, 54);
                    keyboard_9.Anchors = Anchors.None;
                    keyboard_9.Visible = true;

                    keyboard_0.SetPosition(756, 72);
                    keyboard_0.SetSize(84, 54);
                    keyboard_0.Anchors = Anchors.None;
                    keyboard_0.Visible = true;

                    keyboard_backspace.SetPosition(804, 234);
                    keyboard_backspace.SetSize(137, 54);
                    keyboard_backspace.Anchors = Anchors.None;
                    keyboard_backspace.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            keyboard_shift.Text = "Caps Lock";

            keyboard_q.Text = "Q";

            keyboard_1.Text = "1";

            keyboard_w.Text = "W";

            keyboard_e.Text = "E";

            keyboard_r.Text = "R";

            keyboard_t.Text = "T";

            keyboard_y.Text = "Y";

            keyboard_u.Text = "U";

            keyboard_i.Text = "I";

            keyboard_o.Text = "O";

            keyboard_p.Text = "P";

            keyboard_a.Text = "A";

            keyboard_s.Text = "S";

            keyboard_d.Text = "D";

            keyboard_f.Text = "F";

            keyboard_g.Text = "G";

            keyboard_h.Text = "H";

            keyboard_j.Text = "J";

            keyboard_k.Text = "K";

            keyboard_l.Text = "L";

            keyboard_z.Text = "Z";

            keyboard_x.Text = "X";

            keyboard_c.Text = "C";

            keyboard_v.Text = "V";

            keyboard_b.Text = "B";

            keyboard_n.Text = "N";

            keyboard_m.Text = "M";

            keyboard_2.Text = "2";

            keyboard_4.Text = "4";

            keyboard_3.Text = "3";

            keyboard_5.Text = "5";

            keyboard_6.Text = "6";

            keyboard_7.Text = "7";

            keyboard_8.Text = "8";

            keyboard_9.Text = "9";

            keyboard_0.Text = "0";

            keyboard_backspace.Text = "Backspace";
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
