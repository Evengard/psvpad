using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class MainScreen : Scene
    {
		
		public string keyboardEntry = "";
		
		KeyboardDialog onScreenKeyboard; 
		
        public MainScreen()
        {
            InitializeWidget();
			
			//keyboardEntry = new EditableText();
           	//keyboardEntry.Name = "keyboardEntry";
			
			onScreenKeyboard = new KeyboardDialog();
			
			///Callbacks...
			this.Status_Button.ButtonAction +=  status_Button_Pressed;
			this.Add_Buttons.ButtonAction += add_Button_Pressed;
			this.Help_Button.ButtonAction += help_Button_Pressed;
			this.Configuration_Button.ButtonAction += configuration_Button_Pressed;
			this.Keyboard_Button.ButtonAction += keyboard_Button_Pressed;
			this.Touchpad_Button.ButtonAction += tbc_Button_Pressed;
        }
		
		
		void keyboard_Button_Pressed (object sender, TouchEventArgs e){
			onScreenKeyboard.Show();
			
		}

        void configuration_Button_Pressed (object sender, TouchEventArgs e)
        {
        	HelpPanel.Visible = false;
            TBC.Visible = false;
            KeyboardPanel.Visible = false;
            AddPanel.Visible = false;
            Config_Panel.Visible = true;
            StatusPanel.Visible = false;
			TBC_Panel.Visible = false; 
        }
		
		void tbc_Button_Pressed (object sender, TouchEventArgs e)
        {
        	HelpPanel.Visible = false;
            TBC.Visible = false;
            KeyboardPanel.Visible = false;
            AddPanel.Visible = false;
            Config_Panel.Visible = false;
            StatusPanel.Visible = false;
			TBC_Panel.Visible = true; 
        }

        void add_Button_Pressed (object sender, TouchEventArgs e)
        {
        	HelpPanel.Visible = false;
            TBC.Visible = false;
            KeyboardPanel.Visible = false;
            AddPanel.Visible = true;
            Config_Panel.Visible = false;
            StatusPanel.Visible = false;
			TBC_Panel.Visible = false; 
        }
		
		void help_Button_Pressed (object sender, TouchEventArgs e)
        {
        	HelpPanel.Visible = true;
            TBC.Visible = false;
            KeyboardPanel.Visible = false;
            AddPanel.Visible = false;
            Config_Panel.Visible = false;
            StatusPanel.Visible = false;
			TBC_Panel.Visible = false; 
        }


        void  status_Button_Pressed (object sender, TouchEventArgs e)
        {
			this.StatusPanel.Visible = !this.StatusPanel.Visible; 
        }
    }
}
