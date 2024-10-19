using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PUK_Anjamakan.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager temp = new ResourceManager("PUK_Anjamakan.Properties.Resources", typeof(Resources).Assembly);
				resourceMan = temp;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap calendarDark
	{
		get
		{
			object obj = ResourceManager.GetObject("calendarDark", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap calendarWhite
	{
		get
		{
			object obj = ResourceManager.GetObject("calendarWhite", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
	}
}
