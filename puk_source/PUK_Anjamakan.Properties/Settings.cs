using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PUK_Anjamakan.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("rgre")]
	public string Server
	{
		get
		{
			return (string)this["Server"];
		}
		set
		{
			this["Server"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("greg")]
	public string Database
	{
		get
		{
			return (string)this["Database"];
		}
		set
		{
			this["Database"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("SQL")]
	public string Mode
	{
		get
		{
			return (string)this["Mode"];
		}
		set
		{
			this["Mode"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("dfed")]
	public string ID
	{
		get
		{
			return (string)this["ID"];
		}
		set
		{
			this["ID"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("fgedg")]
	public string Password
	{
		get
		{
			return (string)this["Password"];
		}
		set
		{
			this["Password"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("few")]
	public string MALBAND
	{
		get
		{
			return (string)this["MALBAND"];
		}
		set
		{
			this["MALBAND"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("eewf")]
	public string naw_karmand
	{
		get
		{
			return (string)this["naw_karmand"];
		}
		set
		{
			this["naw_karmand"] = value;
		}
	}
}
