using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PUK_Anjamakan;

public class RJButton : Button
{
	private int borderSize = 0;

	private int borderRadius = 20;

	private Color borderColor = Color.PaleVioletRed;

	[Category("RJ Code Advance")]
	public int BorderSize
	{
		get
		{
			return borderSize;
		}
		set
		{
			borderSize = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public int BorderRadius
	{
		get
		{
			return borderRadius;
		}
		set
		{
			borderRadius = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color BorderColor
	{
		get
		{
			return borderColor;
		}
		set
		{
			borderColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color BackgroundColor
	{
		get
		{
			return BackColor;
		}
		set
		{
			BackColor = value;
		}
	}

	[Category("RJ Code Advance")]
	public Color TextColor
	{
		get
		{
			return ForeColor;
		}
		set
		{
			ForeColor = value;
		}
	}

	public RJButton()
	{
		base.FlatStyle = FlatStyle.Flat;
		base.FlatAppearance.BorderSize = 0;
		base.Size = new Size(150, 40);
		BackColor = Color.MediumSlateBlue;
		ForeColor = Color.White;
		base.Resize += Button_Resize;
	}

	private GraphicsPath GetFigurePath(Rectangle rect, float radius)
	{
		GraphicsPath path = new GraphicsPath();
		float curveSize = radius * 2f;
		path.StartFigure();
		path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180f, 90f);
		path.AddArc((float)rect.Right - curveSize, rect.Y, curveSize, curveSize, 270f, 90f);
		path.AddArc((float)rect.Right - curveSize, (float)rect.Bottom - curveSize, curveSize, curveSize, 0f, 90f);
		path.AddArc(rect.X, (float)rect.Bottom - curveSize, curveSize, curveSize, 90f, 90f);
		path.CloseFigure();
		return path;
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		base.OnPaint(pevent);
		Rectangle rectSurface = base.ClientRectangle;
		Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
		int smoothSize = 2;
		if (borderSize > 0)
		{
			smoothSize = borderSize;
		}
		if (borderRadius > 2)
		{
			using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
			{
				using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize);
				using Pen penSurface = new Pen(base.Parent.BackColor, smoothSize);
				using Pen penBorder = new Pen(borderColor, borderSize);
				pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				base.Region = new Region(pathSurface);
				pevent.Graphics.DrawPath(penSurface, pathSurface);
				if (borderSize >= 1)
				{
					pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
				return;
			}
		}
		pevent.Graphics.SmoothingMode = SmoothingMode.None;
		base.Region = new Region(rectSurface);
		if (borderSize >= 1)
		{
			using (Pen pen = new Pen(borderColor, borderSize))
			{
				pen.Alignment = PenAlignment.Inset;
				pevent.Graphics.DrawRectangle(pen, 0, 0, base.Width - 1, base.Height - 1);
			}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		base.Parent.BackColorChanged += Container_BackColorChanged;
	}

	private void Container_BackColorChanged(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void Button_Resize(object sender, EventArgs e)
	{
		if (borderRadius > base.Height)
		{
			borderRadius = base.Height;
		}
	}
}
