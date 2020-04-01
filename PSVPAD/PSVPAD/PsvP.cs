using System;

using System.Collections.Generic;

using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

using Sce.PlayStation.Core.Input;

using Sce.PlayStation.Core.Audio;

namespace PSVPAD
{
	/// <summary>
	/// Event Handlers Definitions.
	/// </summary>
	public delegate void ChangedEventHandler(string Name, string IP, bool Connected);//Event connection changed 
	public delegate void AddedEventHandler(string Name);//Event new connection added /// passes name of connection.
	
	public delegate void settingsChangedHandler();//Event called to update the settings in Configuration
	
	public class PsvP
	{
		//HOLDS THE INPUT DATA 
		VitaInputData data;
		
		//----------Public--------------------------------------------------------------------------------------- 
		
		//Handles the keyboard events 
		public KeyboardEvents keyboard = new KeyboardEvents();
		
		public event ChangedEventHandler connectionChanged;
		public event AddedEventHandler connectionAdded; 
		public event settingsChangedHandler settingsChanged; 
			
		//-------------PRIVATE ATTRIBUTES------------------------------------------------------------------------
		//=======================================================================================================
		private TcpClient client;
		private bool connected; 	
		//private VitaInputData data;
		
		/*String Name, String IP.*/
		private Dictionary<string, string> savedConnections = new Dictionary<string, string>();
		
		//Current/ Default Connection. --> In the sence that which ever connection is current will become default.
		private string defaultConnection = "default Connection";
		
		//An ASCIIEncoder - in the name really.
		private ASCIIEncoding encoder = new ASCIIEncoding();
		
		///Server time out timer --> used to establish whether the server has disconnected.
		private Stopwatch serverTimeOut = new Stopwatch(); 
		private float timeOutPeriod = 2.0f; //persiod of time before the connection times out and is closed - 2 Seconds 
		
		//Holds the additional buttons flags 
		private uint addButtonData = 0; 
		private byte keyboardData = 0; 
		
		//!< PSVPAD Settings/ Configuration 
		private const String configFile = "/Documents/Settings.cfg"; 
		private bool configReadOnly = false; //Used as a flag for when the config file is being read so it doesn't get written to. 
		//private UInt32 connectionCount = 0; //represents the number of saved connections in this file. 
		private bool autoConnectEnabled = true; 
		private bool gyroEnabled = false; 
		private bool soundEnabled = false; 
		private bool backTouchEnabled = false;
		
		private UdpClient listener = null;
		
			//!< PUBLIC GETS SETS====================== 
				public bool isAutoConnectEnabled(){
					return this.autoConnectEnabled;
				}	
				public bool isGyroEnabled(){
					return this.gyroEnabled;
				}	
				public bool isSoundEnabled(){
					return this.soundEnabled;
				}
				public bool isBackTouchEnabled(){
					return this.backTouchEnabled;
				}
		
				public void setAutoConnectEnabled(bool val){
					this.autoConnectEnabled = val;
				}
				public void setGyroEnabled(bool val){
					this.gyroEnabled = val; 
				}
				public void setSoundEnabled(bool val){
					this.soundEnabled = val; 
				}
				public void setBackTouchEnabled(bool val){
					this.backTouchEnabled = val; 
				}
			//!< ======================================
		
		//=======================================================================================================
		//-------------------------------------------------------------------------------------------------------
		
		//Sets/Gets
		//Returns true if client is connected.
		public bool isConnected(){
			return connected;	
		}
		
		//set Button data - if isSet, is set to true, button is down.
		public void setAddButtonData(uint button, bool isSet){
			if (isSet){
				this.addButtonData |= button; 
			}
			else{
				this.addButtonData &= ~button; 
			}
		}
		
		//Sets the current keyboard key
		public void setKeyDat(byte key){
			this.keyboardData = key; 
		}
		
		///CAREFUL - DOES NOT TOGGLE THE ACTUAL CONNECTION!! Use connnectToServer() & disconnect(); to toggle connection status.
		private void setConnected(bool Connected){
			connected = Connected;	
			this.connectionChangedEvent();
		}
		
		
		//------------------------Public Member Functions/ Methods-----------------------------------------------  
		
		public PsvP ()
		{
			this.connected = false; 
			this.client = null;
			
		}
		
		//Psvpad Initialisation.
		public bool initialise(){
			
			//Start timer 
			serverTimeOut.Start();
			
			//data = new VitaInputData();
			
			if (!(this.loadConfig())){
				return false;	
			}
			
			///Called Connection Changed Event to ensure that Status Panel Is Up To Date 
			this.connectionChangedEvent();
			
			// This is where we store all the input ready for serialisation 
			this.data = new VitaInputData();			

			
			return true; 
			
		}
		
		
		//for multi threading 
		public void updateLoop(){
			while (true){
				this.update();	
			}
		}
		
		public void update(){
			if (this.connected){
				sendControlsToServer(); 	
			}
			else
			{
				receiveBroadcastFromServer();
			}
		}
		
		public void receiveBroadcastFromServer()
		{
			if (listener != null && listener.Available > 0)
			{
				IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 11111);
				byte[] bytes = listener.Receive(ref groupEP);
				var result = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
				if (result == "PSVPAD_1.5.1")
				{
					Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytes.Length));
					Console.WriteLine(groupEP.Address.ToString());
					listener.Close();
					listener = null;
					this.connectToServer(groupEP.Address.ToString());
				}
			}
			else if (listener == null && this.autoConnectEnabled)
			{
				listener = new UdpClient(11111);
				listener.EnableBroadcast = true;
			}
		}
		
		///Returns the IP of a given connection 
		public string getIP(string ConnectionName){
			if (this.savedConnections.ContainsKey(ConnectionName)){
				return this.savedConnections[ConnectionName];
			}
			
			return "NULL"; 
		}
		
		public void addAndConnect(string Name, string IpAddress){
			this.addConnection(Name, IpAddress);
			this.connectToServer(IpAddress); 
			this.defaultConnection = Name;
			
			///Should be called last.
			this.connectionChangedEvent();
		}
		
		public void addConnection(string Name, string IpAddress){
			
			//If Connection Name already exists, then just change the IP.
			if (this.savedConnections.ContainsKey(Name)){
				this.savedConnections[Name] = IpAddress; 		
			}
			else{
				this.savedConnections.Add(Name,IpAddress);
				this.connectionAddedEvent(Name);
			}
			
			//Save configuration file... 
			this.saveConfig();
			
			
		}
		
		public void removeConnection(string Name){
			if (this.savedConnections.ContainsKey(Name)){
				this.savedConnections.Remove(Name);	
			}
			
			//Save configuration file... 
			this.saveConfig();
		}
		
		///connect to a known connection. --> As stored in dictionary 'savedConnections'
		public void connectTo(string ConnectionName){
			if (this.savedConnections.ContainsKey(ConnectionName)){
				connectToServer(savedConnections[ConnectionName]); 
			}
			this.defaultConnection = ConnectionName;
			
			///Should be called last.
			this.connectionChangedEvent();
			
		}
		
		//Takes Server Ip Address - Establishes connection with server 
		public void connectToServer(string IpAddress){
			this.disconnectFromServer();
			//do{	
			try{
				this.client = new TcpClient();
            	//IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(IpAddress), 3000);
            	//this.client.Connect(serverEndPoint);
				IAsyncResult result = this.client.BeginConnect(IPAddress.Parse(IpAddress),3000,null,null);
				
				result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(300));
        		
				//Failed to connect after (TimeSpan) seconds return false.
				if (!client.Connected)
        		{
					setConnected(false); 
					return; 
				}
				
				client.EndConnect(result);
				setConnected(true);
				//reset timer
				this.serverTimeOut.Reset();
			}
			catch{
				setConnected(false);
			}
			//}while(!AppMain.CheckServerOk(AppMain.client.GetStream()));
			
		}
		
		public void disconnectFromServer(){
			if (this.isConnected()){
				this.client.Close();
				this.setConnected(false);
			}
		}
			
		//--------------------------------------------------------------------------------------------------------
		
		//------------------------Private Member Functions/ Methods-----------------------------------------------
		
		//Loads the configuration file -> (Saved settings for PSVPAD).
		//If No previous setting uses default...
		private bool loadConfig(){		
					
			//If Settings is present then load settings otherwise load defaults...and save.
			if (File.Exists(configFile)){
				using (BinaryReader reader = new BinaryReader(File.Open(configFile, FileMode.Open)))
	            {
					//clear the saved connections
	                this.savedConnections.Clear();
					
					this.autoConnectEnabled = reader.ReadBoolean();
					this.gyroEnabled = reader.ReadBoolean(); 
					this.soundEnabled = reader.ReadBoolean(); 
					this.backTouchEnabled = reader.ReadBoolean();
					this.defaultConnection = reader.ReadString();
					
					
					//For the number of store connections -> load connections and add to dictionary...
					this.configReadOnly = true; 
					int _connectionCount = reader.ReadInt32();
					for (int cc = 0; cc < _connectionCount; cc++){
						this.addConnection(reader.ReadString(),reader.ReadString()); 
					}
					
					this.configReadOnly = false; 
	            }
				
				
				//Set check boxes 
				this.settingsChangedEvent();
				
				
			}
			else{
				using (BinaryWriter writer = new BinaryWriter(File.Open(configFile, FileMode.Create)))
		        {
		            writer.Write(this.autoConnectEnabled);
		            writer.Write(this.gyroEnabled);
		            writer.Write(this.soundEnabled);
		            writer.Write(this.backTouchEnabled);
					
					//Write deafult connection count 0 <--;
					writer.Write(this.defaultConnection);
					writer.Write(0); 
					
					//Conection data will be writter here in this logical position in the file
					
		        }
				
			}
				
			return true;
		}
		
		//called to save the configuration file... 
		void saveConfig(){
			if (!this.configReadOnly){
				using (BinaryWriter writer = new BinaryWriter(File.Open(configFile, FileMode.Create)))
		        {
		            writer.Write(this.autoConnectEnabled);
		            writer.Write(this.gyroEnabled);
		            writer.Write(this.soundEnabled);
		            writer.Write(this.backTouchEnabled);
					
					//Write deafult connection count 0 <--;
					writer.Write(this.defaultConnection);
					
					writer.Write(this.savedConnections.Count);
					
					//Conection data will be writter here in the file
					foreach(KeyValuePair<string, string> entry in this.savedConnections)
					{
					    writer.Write(entry.Key);
						writer.Write(entry.Value);
					}
					
		        }
			}
			
		}
		

		//Back touch... Will be cleaned up in future... 
		private float backTouchY = 0;
		bool isSwipeAction = false; 
		bool backLeftTouched = false; 
		bool backRightTouched = false;
		Stopwatch touchDelayTimer = new Stopwatch(); 
		
		private void sendControlsToServer(){
			
			//Check client still conected.
			if (!this.client.Connected){
				this.disconnectFromServer();
				return;
			}
			
			//reset input data as necessary 
			data.keyData = 0; 
			
			// Query gamepad for data 
			GamePadData gamePadData = GamePad.GetData (0);
			
			// Get the vitas motion data -> (Gyro)
			MotionData motionData = Motion.GetData(0);
			
			// Query the rear touch data.
			List<TouchData> rearTouchData = Touch.GetRearTouchData(0); 
			
			data.keyData = (uint)gamePadData.Buttons;
			
			//Needed a means of resetting the keyboard data after it had been sent, data was being reset before it had chance to be sent
			//bool resetKeyboard = false; 
			/*if (data.keyboardDat != 0){
				resetKeyboard = true;
			}*/
			data.keyboardDat = this.keyboardData; 
			
			//Add additional button data onto keyData 
			data.keyData |= this.addButtonData;
			
			// Set the values of the analog
			data.lx = gamePadData.AnalogLeftX;
			data.ly = gamePadData.AnalogLeftY;
			data.rx = gamePadData.AnalogRightX;
			data.ry = gamePadData.AnalogRightY;
			
			///Gyro/ Motion Data 
			if (this.isGyroEnabled()){
				data.motionX = motionData.Acceleration.X;
				data.motionY = motionData.Acceleration.Y;
				data.motionZ = motionData.Acceleration.Z;
			}
			else{
				data.motionX = 0; 
				data.motionY = 0; 
				data.motionZ = 0; 
			}
			
			

			
			//Rear touch
			//Limited support <<== CODE ABSTRACTION POINT 
			//Expect extended touch functionality in next update. 
			if (this.isBackTouchEnabled()){
									
				uint _touchData = (uint)data.rearTouch; 	
				//if moving 
				if (isSwipeAction){
					//do stuff
					//_touchData &= ~(uint)RearTouchButtons.LEFT_TOUCH;
					//_touchData &= ~(uint)RearTouchButtons.RIGHT_TOUCH;
				}
				
				//if time has passed and isn't moving
				//if (touchDelayTimer.ElapsedMilliseconds > 50 && !this.isSwipeAction){
				if (touchDelayTimer.ElapsedMilliseconds > 50){
					if (backLeftTouched){
						_touchData |= (uint)RearTouchButtons.LEFT_TOUCH;
					}
					else{
						_touchData &= ~(uint)RearTouchButtons.LEFT_TOUCH;
					}
					
					if (backRightTouched){
						_touchData |= (uint)RearTouchButtons.RIGHT_TOUCH;
					}
					else{
						_touchData &= ~(uint)RearTouchButtons.RIGHT_TOUCH;
					}
					
				}
				data.rearTouch = (byte)_touchData;
					
					
				if (rearTouchData.Count > 0){	
					//update the touch data
					for (int f = 0; f < rearTouchData.Count; f++){
						///check if moving 
						if (rearTouchData[f].Y  < backTouchY-0.1 || rearTouchData[f].Y  > backTouchY+0.1){
							this.isSwipeAction = true;	
						}
						else{
							this.isSwipeAction = false; 
						}
						
						//set previous position data...
						this.backTouchY = rearTouchData[f].Y; 
						
						if (rearTouchData[f].Status == TouchStatus.Down){
							if (rearTouchData[f].X < 0){
								backLeftTouched = true;
							}
							else{
								backRightTouched = true;
							}
							touchDelayTimer.Reset(); 
							touchDelayTimer.Start();
						}
						else if (rearTouchData[f].Status == TouchStatus.Up){
							if (rearTouchData[f].X < 0){
								backLeftTouched = false;
							}
							else{
								backRightTouched = false;
							}
						}
							
					}
				}
				
			}	
				
			
			
				
					
			//----------------------------------------NOTE LOOKS LIKE THIS COULD BE A PROBLEM RIGHT HERE.... TODO
			try{
				sendDataToServer(data); 
			}
			catch{
				//check to see if the server has timed out.
				if (serverTimeOut.ElapsedMilliseconds > (this.timeOutPeriod*1000)){
					this.disconnectFromServer(); 	
				}
			}
			
			//if (resetKeyboard)//Only reset keyboard after key has been sucessfully sent...
			this.setKeyDat(0);//reset key data to 0 to prevent multiple key presses.
			
			//If message recieved reset timeout
			if (this.isConnected() && client.Connected && checkServerOk(client.GetStream())){
				serverTimeOut.Reset();

			}
			else{

			}
			
			
			//Old code not sure what I'm doing with this at the moment -> currently nothing uses the front touch.
			/*
			
			//return the change in position.//Only Handles 1 input at the moment
			if (touchData.Count >0){
				float diffx = touchData[0].X - previousPos.X; 
				float diffy = touchData[0].Y - previousPos.Y;
			
				previousPos.X = touchData[0].X; 
				previousPos.Y = touchData[0].Y;
			
				//touch x, touch y 
				SendData("TX");
				SendData(diffx);
				SendData("TY");
				SendData(diffy);
			}
			else{	
				//touch x, touch y 
				SendData("TX");
				SendData(0);
				SendData("TY");
				SendData(0);
				
			}
			*/
			
		}
		
		private NetworkStream sendDataToServer(VitaInputData data){
			
			IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
			//stream.Position = 0;
			
            formatter.Serialize(stream, data);
			stream.Flush();
			stream.Close();
            byte[] buffer = stream.GetBuffer();
			
			NetworkStream clientStream = client.GetStream();
			
			//if (buffer.Length == 256)
			clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
			return clientStream;
		

		}
		
		//!<< You can just any code related to audio.
		//int BUF_SIZE = 6615;
		//int BUF_SIZE = 11025;
		int BUF_SIZE = 2;
		//SoundPlayer soundPlayer = null; 
		private bool checkServerOk(NetworkStream clientStream){
			
			byte[] message = new byte[BUF_SIZE];	
			
			//get OK from Server 
			int bytesRead = 0;
			
			try
            {
				int read = 0; 
				while (read < BUF_SIZE){
            		bytesRead = clientStream.Read(message, read, message.Length - read);
					read += bytesRead;
					if (bytesRead == 2 || bytesRead == 0){
						break;	
					}
				}
	
            }
            catch{
				return false; 
            }
			
			if (bytesRead == 0)
				return false; 
			
			if (encoder.GetString(message, 0, 2)=="OK"){
				return true;//Message has been recieved by the server. 
			}


			//AppMain.soundStream.addBuffer(message); 
			
			
			/*if (soundPlayer == null){
					soundPlayer = (new Sound(AppMain.soundStream.compileWaveBuffer(message))).CreatePlayer();
					soundPlayer.Volume = 1.0f; 
					soundPlayer.Play();
				}
				else{
					soundPlayer.Stop(); 
					soundPlayer.Dispose();
					soundPlayer = (new Sound(AppMain.soundStream.compileWaveBuffer(message))).CreatePlayer();
					soundPlayer.Volume = 1.0f;
					soundPlayer.Play();
				}*/
			
			return false;
			
			
			
		}
		
		
		///Calls Connection Changed Event 
		private void connectionChangedEvent(){
		if (this.connectionChanged != null)
			
			if (this.savedConnections.ContainsKey(defaultConnection)){	
        		this.connectionChanged(defaultConnection, this.savedConnections[defaultConnection],this.connected);		
			}
			else{
				string IP = "N/A";
				try 
				{
					IP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
				}
				catch
				{
				}
			/*Case where nothing in dictionary - Just throw back N/A*/	
				this.connectionChanged("N/A", IP, this.connected);
			}
		}
		
		private void connectionAddedEvent(string ConnectionName){
			
			this.connectionAdded(ConnectionName); 
			
		}
		
		private void settingsChangedEvent(){	
			this.settingsChanged();	
		}
		
		
		//--------------------------------------------------------------------------------------------------------
		
		

		
		
		
	}
}

