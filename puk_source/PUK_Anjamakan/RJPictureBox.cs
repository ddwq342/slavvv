using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PUK_Anjamakan;

internal class RJPictureBox : PictureBox
{
	private int borderSize = 2;

	private Color borderColor = Color.RoyalBlue;

	private Color borderColor2 = Color.HotPink;

	private DashStyle borderLineStyle = DashStyle.Solid;

	private DashCap borderCapStyle = DashCap.Flat;

	private float gradientAngle = 50f;

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
	public Color BorderColor2
	{
		get
		{
			return borderColor2;
		}
		set
		{
			borderColor2 = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public DashStyle BorderLineStyle
	{
		get
		{
			return borderLineStyle;
		}
		set
		{
			borderLineStyle = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public DashCap BorderCapStyle
	{
		get
		{
			return borderCapStyle;
		}
		set
		{
			borderCapStyle = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public float GradientAngle
	{
		get
		{
			return gradientAngle;
		}
		set
		{
			gradientAngle = value;
			Invalidate();
		}
	}

	public RJPictureBox()
	{
		base.Size = new Size(100, 100);
		base.SizeMode = PictureBoxSizeMode.StretchImage;
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		base.OnPaint(pe);
		Graphics graph = pe.Graphics;
		Rectangle rectContourSmooth = Rectangle.Inflate(base.ClientRectangle, -1, -1);
		Rectangle rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
		int smoothSize = ((borderSize <= 0) ? 1 : (borderSize * 3));
		using LinearGradientBrush borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle);
		using GraphicsPath pathRegion = new GraphicsPath();
		using Pen penSmooth = new Pen(base.Parent.BackColor, smoothSize);
		using Pen penBorder = new Pen(borderGColor, borderSize);
		graph.SmoothingMode = SmoothingMode.AntiAlias;
		penBorder.DashStyle = borderLineStyle;
		penBorder.DashCap = borderCapStyle;
		pathRegion.AddEllipse(rectContourSmooth);
		base.Region = new Region(pathRegion);
		graph.DrawEllipse(penSmooth, rectContourSmooth);
		if (borderSize > 0)
		{
			graph.DrawEllipse(penBorder, rectBorder);
		}
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Size = new Size(base.Width, base.Width);
	}
}
