// Decompiled with JetBrains decompiler
// Type: PSV_Server.PSVKeyType
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

namespace PSV_Server
{
    public enum PSVKeyType : uint
    {
        Left = 1,
        Up = 2,
        Right = 4,
        Down = 8,
        Square = 16, // 0x00000010
        Triangle = 32, // 0x00000020
        Circle = 64, // 0x00000040
        Cross = 128, // 0x00000080
        Start = 256, // 0x00000100
        Select = 512, // 0x00000200
        L = 1024, // 0x00000400
        R = 2048, // 0x00000800
        FrontRightB14 = 4096, // 0x00001000
        Enter = 65536, // 0x00010000
        Back = 131072, // 0x00020000
        B1 = 262144, // 0x00040000
        B2 = 524288, // 0x00080000
        B3 = 1048576, // 0x00100000
        B4 = 2097152, // 0x00200000
        B5 = 4194304, // 0x00400000
        B6 = 8388608, // 0x00800000
        B7 = 16777216, // 0x01000000
        B8 = 33554432, // 0x02000000
        B9 = 67108864, // 0x04000000
        B10 = 134217728, // 0x08000000
        B11 = 268435456, // 0x10000000
        B12 = 536870912, // 0x20000000
        FrontLeftB13 = 1073741824, // 0x40000000
    }
}
