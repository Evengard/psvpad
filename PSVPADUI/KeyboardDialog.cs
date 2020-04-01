using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class KeyboardDialog : Dialog
    {
        public KeyboardDialog()
            : base(null, null)
        {
            InitializeWidget();
			
			this.HideEffect = new SlideOutEffect(){
				MoveDirection = FourWayDirection.Down,
			};
			
			KeyboardEvents keyboard = AppMain.psvPad.keyboard; 
			
			this.CloseKeyboardBtn.ButtonAction += closeKeyboard_Action; 
			this.SpaceBtn.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved; 
			this.FullStopBtn.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved; 
			this.CommerBtn.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved; 
			
			this.LeftBtn.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved;
			this.RightBtn.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved;
			
			//>>ENTER NOT BACKSPACE<< BUTTON HASN'T BEEN RENAMED <-------------------------------------------
			this.BackSpaceBtn.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved;
        }
		
		
		void closeKeyboard_Action(Object sender, TouchEventArgs e){
			this.Hide();
		}
		
    }
}
