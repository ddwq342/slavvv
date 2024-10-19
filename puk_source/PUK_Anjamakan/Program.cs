using System;
using System.Windows.Forms;
using PUK_Anjamakan.Frm;

namespace PUK_Anjamakan;

internal static class Program
{
	public static string entryName;

	public static string User_tyape;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new Home());
	}
}
