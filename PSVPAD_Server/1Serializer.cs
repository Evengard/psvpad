// Decompiled with JetBrains decompiler
// Type: PSV_Server.InputData
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace PSV_Server
{
    [Serializable]
    public class InputData : ISerializable
    {
        public readonly KeyStateAccessor KeyStates;

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

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("keyData", this.keyData);
            info.AddValue("lx", this.lx);
            info.AddValue("ly", this.ly);
            info.AddValue("rx", this.rx);
            info.AddValue("ry", this.ry);
            info.AddValue("motionX", this.motionX);
            info.AddValue("motionY", this.motionY);
            info.AddValue("motionZ", this.motionZ);
            info.AddValue("keyboardDat", this.keyboardDat);
            info.AddValue("rearTouch", this.rearTouch);
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public InputData(SerializationInfo info, StreamingContext context)
        {
            this.keyData = info.GetUInt32(nameof(keyData));
            this.lx = info.GetSingle(nameof(lx));
            this.ly = info.GetSingle(nameof(ly));
            this.rx = info.GetSingle(nameof(rx));
            this.ry = info.GetSingle(nameof(ry));
            this.motionX = info.GetSingle(nameof(motionX));
            this.motionY = info.GetSingle(nameof(motionY));
            this.motionZ = info.GetSingle(nameof(motionZ));
            this.keyboardDat = info.GetByte(nameof(keyboardDat));
            this.rearTouch = info.GetByte(nameof(rearTouch));

            KeyStates = new KeyStateAccessor(this);
        }

        public class KeyStateAccessor
        {
            private readonly InputData _parent;
            internal protected KeyStateAccessor(InputData parent)
            {
                _parent = parent;
            }

            public bool Button_L => (_parent.keyData & (uint)PSVKeyType.L) != 0;
            public bool Button_R => (_parent.keyData & (uint)PSVKeyType.R) != 0;
            public bool Button_Triangle => (_parent.keyData & (uint)PSVKeyType.Triangle) != 0;
            public bool Button_Square => (_parent.keyData & (uint)PSVKeyType.Square) != 0;
            public bool Button_Circle => (_parent.keyData & (uint)PSVKeyType.Circle) != 0;
            public bool Button_Cross => (_parent.keyData & (uint)PSVKeyType.Cross) != 0;
            public bool Button_DUp => (_parent.keyData & (uint)PSVKeyType.Up) != 0;
            public bool Button_DDown => (_parent.keyData & (uint)PSVKeyType.Down) != 0;
            public bool Button_DLeft => (_parent.keyData & (uint)PSVKeyType.Left) != 0;
            public bool Button_DRight => (_parent.keyData & (uint)PSVKeyType.Right) != 0;
            public bool Button_Start => (_parent.keyData & (uint)PSVKeyType.Start) != 0;
            public bool Button_Select => (_parent.keyData & (uint)PSVKeyType.Select) != 0;
            public bool B1Btn => (_parent.keyData & (uint)PSVKeyType.B1) != 0;
            public bool B2Btn => (_parent.keyData & (uint)PSVKeyType.B2) != 0;
            public bool B3Btn => (_parent.keyData & (uint)PSVKeyType.B3) != 0;
            public bool B4Btn => (_parent.keyData & (uint)PSVKeyType.B4) != 0;
            public bool B5Btn => (_parent.keyData & (uint)PSVKeyType.B5) != 0;
            public bool B6Btn => (_parent.keyData & (uint)PSVKeyType.B6) != 0;
            public bool B7Btn => (_parent.keyData & (uint)PSVKeyType.B7) != 0;
            public bool B8Btn => (_parent.keyData & (uint)PSVKeyType.B8) != 0;
            public bool B9Btn => (_parent.keyData & (uint)PSVKeyType.B9) != 0;
            public bool B10Btn => (_parent.keyData & (uint)PSVKeyType.B10) != 0;
            public bool B11Btn => (_parent.keyData & (uint)PSVKeyType.B11) != 0;
            public bool B12Btn => (_parent.keyData & (uint)PSVKeyType.B12) != 0;
            public bool Front_Left_Touch_B13Btn => (_parent.keyData & (uint)PSVKeyType.FrontLeftB13) != 0;
            public bool Front_Right_Touch_B14Btn => (_parent.keyData & (uint)PSVKeyType.FrontRightB14) != 0;
            public bool Front_Left_Touch_All => Front_Left_Touch_B13Btn || B1Btn || B2Btn || B3Btn || B7Btn || B8Btn || B9Btn;
            public bool Front_Right_Touch_All => Front_Right_Touch_B14Btn || B4Btn || B5Btn || B6Btn || B10Btn || B11Btn || B12Btn;
            public bool Rear_Left_Touch => (_parent.rearTouch & (uint)PSVRearTouch.LEFT_TOUCH) != 0;
            public bool Rear_Right_Touch => (_parent.rearTouch & (uint)PSVRearTouch.RIGHT_TOUCH) != 0;
        }
    }
}
