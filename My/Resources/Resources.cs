// Decompiled with JetBrains decompiler
// Type: CountdownApp.My.Resources.Resources
// Assembly: CountdownApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FC7E3B5E-A665-400F-94A5-48F1DBB775B0
// Assembly location: C:\Users\Pika\Desktop\WaktuSimulasiAppv1.1.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CountdownApp.My.Resources
{
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) CountdownApp.My.Resources.Resources.resourceMan, (object) null))
          CountdownApp.My.Resources.Resources.resourceMan = new ResourceManager("CountdownApp.Resources", typeof (CountdownApp.My.Resources.Resources).Assembly);
        return CountdownApp.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => CountdownApp.My.Resources.Resources.resourceCulture;
      set => CountdownApp.My.Resources.Resources.resourceCulture = value;
    }

    internal static Bitmap _480px_Blue_circle => (Bitmap) RuntimeHelpers.GetObjectValue(CountdownApp.My.Resources.Resources.ResourceManager.GetObject("480px-Blue_circle", CountdownApp.My.Resources.Resources.resourceCulture));

    internal static Bitmap Logoblue => (Bitmap) RuntimeHelpers.GetObjectValue(CountdownApp.My.Resources.Resources.ResourceManager.GetObject(nameof (Logoblue), CountdownApp.My.Resources.Resources.resourceCulture));

    internal static Bitmap Rounded_Rectangle => (Bitmap) RuntimeHelpers.GetObjectValue(CountdownApp.My.Resources.Resources.ResourceManager.GetObject("Rounded Rectangle", CountdownApp.My.Resources.Resources.resourceCulture));
  }
}
