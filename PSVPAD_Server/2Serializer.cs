// Decompiled with JetBrains decompiler
// Type: PSV_Server.vitaAssemblyBinder
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace PSV_Server
{
    internal sealed class vitaAssemblyBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            assemblyName = Assembly.GetExecutingAssembly().FullName;
            typeName = "PSV_Server.InputData";
            return Type.GetType(string.Format("{0}, {1}", (object)typeName, (object)assemblyName));
        }
    }
}
