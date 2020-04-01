using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class ConnectionStatusPanel : Panel
    {
        public ConnectionStatusPanel()
        {
            InitializeWidget();
			
			///callbacks 
			AppMain.psvPad.connectionChanged += new ChangedEventHandler(connectionChanged_Event);

        }
		
		private void connectionChanged_Event(string Name, String IP, bool Connected){
			
			if (Connected){
				this.Label_isConnected.Text = "Connected";
			}
			else{
				this.Label_isConnected.Text = "Disconnected";	
			}
			
            this.Label_connectionName.Text = Name;
            this.Label_IPAddress.Text = IP;
		}
		
		
    }
}
