using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;

using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Threading;

using System.Reflection;

//UI stuff 
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using System.Security;
using System.Reflection.Emit;

namespace PSVPAD
{
	
	
	
	public class AppMain
	{
		//Makes life a little bit simpler 
		public static GraphicsContext graphics;
		
		public static PsvP psvPad; 
		public static SoundStream soundStream; 
		
		public static void Main (string[] args)
		{
			
			Initialize (); 
			
			while (true) {
					SystemEvents.CheckEvents ();
				
					Update ();
					Render ();
			}
		}
		
		///DONT Change Order of Execution!
		public static void Initialize ()
		{
			// Set up the graphics system
			graphics = new GraphicsContext ();
			
			//Create new PsvP Object
			AppMain.psvPad = new PsvP();
			
			soundStream = new SoundStream();
			
			UISystem.Initialize(graphics);
			
			//Create the scene and sets it 
			MainScreen screen = new MainScreen();
			UISystem.SetScene(screen);
			
			//Initialise/ Load Configuration/ If there is one.
			AppMain.psvPad.initialise(); 
			
			Thread update = new Thread(new ThreadStart(AppMain.psvPad.updateLoop));
            update.Start();
			
			//Thread soundPlayer = new Thread(new ThreadStart(AppMain.soundStream.updateStream));
			//soundPlayer.Start();
			
		}
		
		static private List<TouchData> touchData;
		
		public static void Update ()
		{	
			//AppMain.psvPad.update();
			//AppMain.soundStream.playStream();
			
			touchData = Touch.GetData(0);
    		UISystem.Update (touchData);
		}
		
		public static void Render ()
		{
			//set the size of the viewport 
			graphics.SetViewport(0, 0, graphics.Screen.Width, graphics.Screen.Height);
			
			// Clear the screen
			graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			graphics.Clear ();
			
			//renders the ui
			UISystem.Render();	
			
			// Present the screen
			graphics.SwapBuffers ();
		}
	}
}

