using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
	public class KeyboardEvents
	{
		public KeyboardEvents ()
		{
			this.fillKeyCodeDictionary();		
		}
		
		//Opted in the end to add a keycode dictionary for all the additional keys, probably more optimal and space efficient than a bunch of ifs
		Dictionary<String, uint> keyCodes = new Dictionary<string, uint>(StringComparer.InvariantCultureIgnoreCase);
		
		//Does what it says -> sub section of key codes -> And then some if anyone wants to add functionality for them
		//Complete list: http://msdn.microsoft.com/en-gb/library/windows/desktop/dd375731%28v=vs.85%29.aspx
		private void fillKeyCodeDictionary(){
            this.keyCodes.Add("Backspace", 0x8); //Back
            this.keyCodes.Add("Tab", 0x9); //Tab
            this.keyCodes.Add("Clear", 0x0C); //Clear
            this.keyCodes.Add("Enter", 0x0D); //Enter/ Return key  
            this.keyCodes.Add("Shift", 0x10); //Shift 
            this.keyCodes.Add("Control", 0x11);
            this.keyCodes.Add("Alt", 0x12);
            this.keyCodes.Add("Pause", 0x13);
            this.keyCodes.Add("Caps lock", 0x14);
            this.keyCodes.Add("Escape", 0x1B);
            this.keyCodes.Add("Esc", 0x1B);


            this.keyCodes.Add("Space", 0x20);
            this.keyCodes.Add("Pgup", 0x21);
            this.keyCodes.Add("Pgdn", 0x22);
            this.keyCodes.Add("End", 0x23);
            this.keyCodes.Add("Home", 0x24);
            this.keyCodes.Add("Left", 0x25); //Left Arrow Key 
            this.keyCodes.Add("Up", 0x26);
            this.keyCodes.Add("Right", 0x27);
            this.keyCodes.Add("Down", 0x28);
            this.keyCodes.Add("Select", 0x29); //Select key?
            this.keyCodes.Add("Print", 0x2A);
            this.keyCodes.Add("Execute", 0x2B);//Execute key 
            this.keyCodes.Add("Prtscr", 0x2C);
            this.keyCodes.Add("Insert", 0x2D);
            this.keyCodes.Add("Delete", 0x2E);
            this.keyCodes.Add("Del", 0x2E);
            this.keyCodes.Add("Help", 0x2F);
            this.keyCodes.Add("Win", 0x5B); //Left Windows
            this.keyCodes.Add("Sleep", 0x5F);
            this.keyCodes.Add("Num0", 0x60); //NumPAD 0 "" 
            this.keyCodes.Add("Num1", 0x61);
            this.keyCodes.Add("Num2", 0x62);
            this.keyCodes.Add("Num3", 0x63);
            this.keyCodes.Add("Num4", 0x64);
            this.keyCodes.Add("Num5", 0x65);
            this.keyCodes.Add("Num6", 0x66);
            this.keyCodes.Add("Num7", 0x67); 
            this.keyCodes.Add("Num8", 0x68); 
            this.keyCodes.Add("Num9", 0x69);
            this.keyCodes.Add("F1", 0x70); //Function 1// Functions 1 - 12.
            this.keyCodes.Add("F2", 0x71);
            this.keyCodes.Add("F3", 0x72);
            this.keyCodes.Add("F4", 0x73);
            this.keyCodes.Add("F5", 0x74);
            this.keyCodes.Add("F6", 0x75);
            this.keyCodes.Add("F7", 0x76);
            this.keyCodes.Add("F8", 0x77);
            this.keyCodes.Add("F9", 0x78);
            this.keyCodes.Add("F10", 0x79);
            this.keyCodes.Add("F11", 0x7A);
            this.keyCodes.Add("F12", 0x7B); 
            this.keyCodes.Add("Numlock",0x90); 
            this.keyCodes.Add("Scrolllock", 0x91);
			
			//Just awkward
            this.keyCodes.Add(";", 0xBA);
            this.keyCodes.Add("=", 0xBB);
            this.keyCodes.Add("-", 0xBD);
            this.keyCodes.Add("/", 0xBF);
            this.keyCodes.Add("'", 0xC0);
            this.keyCodes.Add("[", 0xDB);
            this.keyCodes.Add(@"\", 0xDC);
            this.keyCodes.Add("]", 0xDD);
            this.keyCodes.Add("#", 0xDE);
            this.keyCodes.Add(",", 0xBC);
            this.keyCodes.Add(".", 0xBE);
			this.keyCodes.Add("+", 0x6B);
		}
		//It was going to take too much messing around to make these functions avilable to the keyboard dialogue
		//and the keyboardPanel2 (c# no friend classes?) so I just made them public
		public void keyboard_Touch_Event_Received(object sender, TouchEventArgs e){
			//If key down 
			if (e.TouchEvents.PrimaryTouchEvent.Type ==  TouchEventType.Down){
				//AppMain.psvPad.setAddButtonData(button, true); 	
				//Show tool tip or equivilent here
			}
			else if (e.TouchEvents.PrimaryTouchEvent.Type ==  TouchEventType.Up){//key released 
				//this will actual pass the key to be sent over the network	
				Button keyBut = (Button)sender; 
				//The conversion to upper is important, all hell may just break lose if this is changed, no seriously theres no telling what key events you could accidently send to windows, well there is a way of telling but its long and boring and involves comparing the ascii values of the characters to a list of hexidecimal key codes -> just leave it okay?
				AppMain.psvPad.setKeyDat((byte)keyBut.Text.ToUpper()[0]);
			}
			else if (e.TouchEvents.PrimaryTouchEvent.Type == TouchEventType.Leave){
				
				
			}
		}	
		
		//Facilitate special cases i.e. that of the space, backspace and erm... lots more, --> note: shift, ctrl and alt will be handled differently if there included.
		//Special case... Mildy more efficient then including in the callback listed above avoid expensive string comparison
		public void keyboard_S_Touch_Event_Recieved(object sender, TouchEventArgs e){	
			if (e.TouchEvents.PrimaryTouchEvent.Type ==  TouchEventType.Down){
				//AppMain.psvPad.setAddButtonData(button, true); 	
				//Show tool tip or equivilent here
			}
			else if (e.TouchEvents.PrimaryTouchEvent.Type ==  TouchEventType.Up){//key released 
				//this will actual pass the key to be sent over the network	
				Button keyBut = (Button)sender; 
				if (this.keyCodes.ContainsKey(keyBut.Text)){
					AppMain.psvPad.setKeyDat((byte)this.keyCodes[keyBut.Text]);
				}		
			}

			
		}
	}
}

