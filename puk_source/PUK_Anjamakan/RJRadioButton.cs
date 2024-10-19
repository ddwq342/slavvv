using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PUK_Anjamakan;

public class RJRadioButton : RadioButton
{
	private Color checkedColor = Color.MediumSlateBlue;

	private Color unCheckedColor = Color.Gray;

	public Color CheckedColor
	{
		get
		{
			return checkedColor;
		}
		set
		{
			checkedColor = value;
			Invalidate();
		}
	}

	public Color UnCheckedColor
	{
		get
		{
			return unCheckedColor;
		}
		set
		{
			unCheckedColor = value;
			Invalidate();
		}
	}

	public RJRadioButton()
	{
		MinimumSize = new Size(0, 21);
		base.Padding = new Padding(10, 0, 0, 0);
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		Graphics graphics = pevent.Graphics;
		graphics.SmoothingMode = SmoothingMode.AntiAlias;
		float rbBorderSize = 18f;
		float rbCheckSize = 12f;
		RectangleF rectangleF = default(RectangleF);
		rectangleF.X = 0.5f;
		rectangleF.Y = ((float)base.Height - rbBorderSize) / 2f;
		rectangleF.Width = rbBorderSize;
		rectangleF.Height = rbBorderSize;
		RectangleF rectRbBorder = rectangleF;
		rectangleF = default(RectangleF);
		rectangleF.X = rectRbBorder.X + (rectRbBorder.Width - rbCheckSize) / 2f;
		rectangleF.Y = ((float)base.Height - rbCheckSize) / 2f;
		rectangleF.Width = rbCheckSize;
		rectangleF.Height = rbCheckSize;
		RectangleF rectRbCheck = rectangleF;
		using Pen penBorder = new Pen(checkedColor, 1.6f);
		using SolidBrush brushRbCheck = new SolidBrush(checkedColor);
		using SolidBrush brushText = new SolidBrush(ForeColor);
		graphics.Clear(BackColor);
		if (base.Checked)
		{
			graphics.DrawEllipse(penBorder, rectRbBorder);
			graphics.FillEllipse(brushRbCheck, rectRbCheck);
		}
		else
		{
			penBorder.Color = unCheckedColor;
			graphics.DrawEllipse(penBorder, rectRbBorder);
		}
		graphics.DrawString(Text, Font, brushText, rbBorderSize + 8f, (base.Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Width = TextRenderer.MeasureText(Text, Font).Width + 30;
	}
}
