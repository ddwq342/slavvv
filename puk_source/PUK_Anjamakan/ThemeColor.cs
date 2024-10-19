using System.Collections.Generic;
using System.Drawing;

namespace PUK_Anjamakan;

public static class ThemeColor
{
	public static List<string> ColorList = new List<string>
	{
		"#3F51B5", "#E41A4A", "#009688", "#E41A4A", "#9C27B0", "#E41A4A", "#2196F3", "#E41A4A", "#E41A4A", "#E41A4A",
		"#721D47", "#E41A4A", "#E4126B", "#E41A4A", "#B71C46"
	};

	public static Color PrimaryColor { get; set; }

	public static Color SecondaryColor { get; set; }

	public static Color ChangeColorBrightness(Color color, double correctionFactor)
	{
		double red = (int)color.R;
		double green = (int)color.G;
		double blue = (int)color.B;
		if (correctionFactor < 0.0)
		{
			correctionFactor = 1.0 + correctionFactor;
			red *= correctionFactor;
			green *= correctionFactor;
			blue *= correctionFactor;
		}
		else
		{
			red = (255.0 - red) * correctionFactor + red;
			green = (255.0 - green) * correctionFactor + green;
			blue = (255.0 - blue) * correctionFactor + blue;
		}
		return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
	}
}
