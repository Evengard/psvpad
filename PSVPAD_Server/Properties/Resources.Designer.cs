// Decompiled with JetBrains decompiler
// Type: PSV_Server.Properties.Resources
// Assembly: PSV_Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99D27C4D-1970-4CC0-8120-423D0430A7B5
// Assembly location: I:\dev\psvpad_complete\PSVPAD Server\PSV_Server.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PSV_Server.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) PSV_Server.Properties.Resources.resourceMan, (object) null))
          PSV_Server.Properties.Resources.resourceMan = new ResourceManager("PSV_Server.Properties.Resources", typeof (PSV_Server.Properties.Resources).Assembly);
        return PSV_Server.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return PSV_Server.Properties.Resources.resourceCulture;
      }
      set
      {
        PSV_Server.Properties.Resources.resourceCulture = value;
      }
    }

    internal static Bitmap arrow
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (arrow), PSV_Server.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap dpad
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (dpad), PSV_Server.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap psv
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (psv), PSV_Server.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap psvback
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (psvback), PSV_Server.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap PSVPAD
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (PSVPAD), PSV_Server.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap server
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (server), PSV_Server.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap WIFIGREEN
    {
      get
      {
        return (Bitmap) PSV_Server.Properties.Resources.ResourceManager.GetObject(nameof (WIFIGREEN), PSV_Server.Properties.Resources.resourceCulture);
      }
    }
  }
}
