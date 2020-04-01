using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSVPAD
{
    public partial class ConnectionSettings : Panel
    {
        public ConnectionSettings()
        {
            InitializeWidget();
			
			//Set up Callbacks. 
			this.AddConnectBtn.ButtonAction += addConnectBtn_Pressed;
			this.SelectConnectList.SelectionChanged += selectionChanged_Event;
			this.ConnectBtn.ButtonAction += connectBtn_Pressed; 
			this.DeleteConnectBtn.ButtonAction += deleteConnectBtn_Pressed; 
			this.Add.ButtonAction += addBtn_Pressed;
			AppMain.psvPad.connectionAdded += new AddedEventHandler(connectionAdded_Event); 
			
        }
		
		///Callbacks.
		private void addConnectBtn_Pressed(Object sender, EventArgs e){
			
			AppMain.psvPad.addAndConnect(this.PCNameText.Text, this.IP_Text.Text); 
			
		}
		
		private void addBtn_Pressed(Object sender, EventArgs e){
			
			AppMain.psvPad.addConnection(this.PCNameText.Text, this.IP_Text.Text);
			
		}
		
		private void selectionChanged_Event(Object sender, PopupSelectionChangedEventArgs Args){
			
			string Name = this.SelectConnectList.ListItems[this.SelectConnectList.SelectedIndex];
			string IP = AppMain.psvPad.getIP(Name);
			if (IP != "NULL"){
				this.PCNameText.Text = Name; 
				this.IP_Text.Text = IP; 
			}
				
		}
		
		private void connectBtn_Pressed(Object sender, TouchEventArgs Args){
			if (this.SelectConnectList.ListItems.Count > 0){
				string Name = this.SelectConnectList.ListItems[this.SelectConnectList.SelectedIndex];	
				AppMain.psvPad.connectTo(Name);
			}
		}
		
		private void deleteConnectBtn_Pressed(Object sender, TouchEventArgs Args){
			if (this.SelectConnectList.ListItems.Count > 0){
				string Name = this.SelectConnectList.ListItems[this.SelectConnectList.SelectedIndex];
				AppMain.psvPad.removeConnection(Name); 	
				this.SelectConnectList.ListItems.Remove(Name);
			}
		}
		
		private void connectionAdded_Event (string Name){
			SelectConnectList.ListItems.Add(Name);
			
		}
		
    }
}
