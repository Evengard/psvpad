using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security.Permissions;

namespace PSVPAD
{
	//For its general usefulness -->Addtional Buttons enumeration 
	//Used in keyData -- Additional to input recieved from vita.
	public enum AdditionalButtons : uint{
		//Additional Buttons 
        B1 = 0x1 << 18,
        B2 = 0x1 << 19,
        B3 = 0x1 << 20,
        B4 = 0x1 << 21,
        B5 = 0x1 << 22,
        B6 = 0x1 << 23,
        B7 = 0x1 << 24,
        B8 = 0x1 << 25,
        B9 = 0x1 << 26,
        B10 = 0x1 << 27,
        B11 = 0x1 << 28,
        B12 = 0x1 << 29,	
		B13 = 0x1 << 30,
		B14 = 0x1 << 12
	}
	
	//Rear touch enumeration for clarity 
	//NOTE -> Actions on the rear touch will translate to joy buttons...
	//		  as such theres no variation in regards to swipe speed etc... 
	/// <summary>
	/// Rear touch button enumeration.
	/// SWIPE_UP --> User swipes up on rear touch panel, either side 
	/// SWIPE_DOWN --> User swipes down of the rear touch panel, either side 
	/// LEFT_TOUCH --> User touches the rear touch panel on the left hand side of the vita
	/// RIGHT_TOUCH --> User touched the rear touch panel on the right hand side of the vita 
	/// </summary>
	public enum RearTouchButtons : uint{
		SWIPE_UP 	= 		0x1 << 0,
		SWIPE_DOWN 	= 		0x1 << 1, 
		LEFT_TOUCH  = 		0x1 << 2, 
		RIGHT_TOUCH = 		0x1 << 3	
	}
	
    [Serializable]
    public class VitaInputData
    {
        public uint keyData = 0;
        //left anologue
        public float lx = 0;
        public float ly = 0;
        //right anologue
        public float rx = 0;
        public float ry = 0;
		
		//Motion Data 
		public float motionX = 0; 
		public float motionY = 0; 
		public float motionZ = 0; 
		
		//Stores key data related to keyboard input Ignore this
		//Each key is represented by a 1 byte/ 8 bit unsigned integer, 
		//so 2 32 bit unsigned bytes is equililent to 8 key presses
		//public uint keyboardDat1;
		//public uint keyboardDat2;
		public byte keyboardDat; 
		
		// Holds rear touch data.
		public byte rearTouch = 0;
		
    };

}


