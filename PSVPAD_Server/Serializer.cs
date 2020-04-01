// Decompiled with JetBrains decompiler
// Type: PSV_Server.VitaInputData
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System;

namespace PSV_Server
{
    [Serializable]
    public class VitaInputData
    {
        public uint keyData;
        public float lx;
        public float ly;
        public float rx;
        public float ry;
        public float motionX;
        public float motionY;
        public float motionZ;
        public byte keyboardDat;
        public byte rearTouch;
    }
}
