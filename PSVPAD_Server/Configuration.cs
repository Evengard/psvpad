// Decompiled with JetBrains decompiler
// Type: PSV_Server.Configuration
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

namespace PSV_Server
{
    internal struct Configuration
    {
        public uint clientTimeOut;
        public uint keyRepeatDelayMS;
        public float LSDeadZone;
        public float RSDeadZone;
        public float gyroXDeadZone;
        public float gyroYDeadZone;
        public float gyroZDeadZone;
        public bool gyroXEnabled;
        public bool gyroYEnabled;
        public bool gyroZEnabled;
    }
}
