using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class Configuration : Panel
    {
        public Configuration()
        {
            InitializeWidget();
			
			this.CheckBox_Enable_Gyro.CheckedChanged += gyro_CheckBox_Toggled;
			this.Check_Sound.CheckedChanged += sound_CheckBox_Toggled;
			this.Check_Auto_Connect.CheckedChanged += autoConnect_CheckBox_Toggled;
			this.Check_Enable_Touch.CheckedChanged += touchEnabled_CheckBox_Toggled;
			
			AppMain.psvPad.settingsChanged += new settingsChangedHandler(settingsChanged_Event); 
			
        }
		
		
		public void settingsChanged_Event(){
			
			//!< Update the check boxes accordingly 
			this.CheckBox_Enable_Gyro.Checked = AppMain.psvPad.isGyroEnabled();
			this.Check_Auto_Connect.Checked = AppMain.psvPad.isAutoConnectEnabled(); 
			this.Check_Sound.Checked = AppMain.psvPad.isSoundEnabled();
			this.Check_Enable_Touch.Checked = AppMain.psvPad.isBackTouchEnabled();	
			
		}
		
		public void gyro_CheckBox_Toggled(Object Sender, TouchEventArgs e){
			AppMain.psvPad.setGyroEnabled(CheckBox_Enable_Gyro.Checked);
		}	
		public void autoConnect_CheckBox_Toggled(Object Sender, TouchEventArgs e){
			AppMain.psvPad.setAutoConnectEnabled(Check_Auto_Connect.Checked);
		}
		public void sound_CheckBox_Toggled(Object Sender, TouchEventArgs e){
			AppMain.psvPad.setSoundEnabled(Check_Sound.Checked);
		}
		public void touchEnabled_CheckBox_Toggled(Object Sender, TouchEventArgs e){
			AppMain.psvPad.setBackTouchEnabled(Check_Enable_Touch.Checked); 
		}
		
		
    }
}
