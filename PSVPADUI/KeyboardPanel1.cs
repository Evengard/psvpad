using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class KeyboardPanel1 : Panel
    {
        public KeyboardPanel1()
        {
            InitializeWidget();
			
			KeyboardEvents keyboard = AppMain.psvPad.keyboard;
			this.keyboard_0.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_1.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_2.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_3.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_4.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_5.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_6.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_7.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_8.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_9.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			
			this.keyboard_q.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_w.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_e.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_r.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_t.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_y.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_u.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_i.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_o.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_p.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_a.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_s.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_d.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_f.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_g.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_h.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_j.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_k.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_l.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_z.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_x.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_c.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_v.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_b.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_n.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			this.keyboard_m.TouchEventReceived += keyboard.keyboard_Touch_Event_Received;
			
			this.keyboard_backspace.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved;
			this.keyboard_shift.TouchEventReceived += keyboard.keyboard_S_Touch_Event_Recieved;

			
        }
		

		
    }
}
