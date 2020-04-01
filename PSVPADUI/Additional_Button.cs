using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class Additional_Button : Panel
    {
        public Additional_Button()
        {
            InitializeWidget();
			
			Panel_1.TouchEventReceived += panel_1_Touch;
			Panel_2.TouchEventReceived += panel_2_Touch;
			
			Button_1.TouchEventReceived += button_1_Touch;
			Button_2.TouchEventReceived += button_2_Touch;
			Button_3.TouchEventReceived += button_3_Touch;
			Button_4.TouchEventReceived += button_4_Touch;
			Button_5.TouchEventReceived += button_5_Touch;
			Button_6.TouchEventReceived += button_6_Touch;
			Button_7.TouchEventReceived += button_7_Touch;
			Button_8.TouchEventReceived += button_8_Touch;
			Button_9.TouchEventReceived += button_9_Touch;
			Button_10.TouchEventReceived += button_10_Touch;
			Button_11.TouchEventReceived += button_11_Touch;
			Button_12.TouchEventReceived += button_12_Touch;
        }
		
		//
		private void button_Event_Received(uint button, TouchEventArgs e){
			//If key down 
			if (e.TouchEvents.PrimaryTouchEvent.Type ==  TouchEventType.Down){
				AppMain.psvPad.setAddButtonData(button, true); 	
			}
			else if (e.TouchEvents.PrimaryTouchEvent.Type ==  TouchEventType.Up || e.TouchEvents.PrimaryTouchEvent.Type == TouchEventType.Leave){//key released 
				AppMain.psvPad.setAddButtonData(button, false); 	
			}
		}
		
		void panel_1_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B13,e); 	
		}
		
		void panel_2_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B14,e); 	
		}

        void button_1_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B1,e); 		
        }
		
		void button_2_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B2,e); 		
        }
		
		void button_3_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B3,e); 		
        }
		
		void button_4_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B4,e); 		
        }
		
		void button_5_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B5,e); 		
        }
		
		void button_6_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B6,e); 		
        }
		
		void button_7_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B7,e); 		
        }
		
		void button_8_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B8,e); 		
        }
		
		void button_9_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B9,e); 		
        }
		
		void button_10_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B10,e); 		
        }
		
		void button_11_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B11,e); 		
        }
		
		void button_12_Touch (object sender, TouchEventArgs e){
			this.button_Event_Received((uint)AdditionalButtons.B12,e); 		
        }
		
		
		

		
    }
}
