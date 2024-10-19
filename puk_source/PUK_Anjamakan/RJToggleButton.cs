using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PUK_Anjamakan;

public class RJToggleButton : CheckBox
{
	private Color onBackColor = Color.MediumSlateBlue;

	private Color onToggleColor = Color.WhiteSmoke;

	private Color offBackColor = Color.Gray;

	private Color offToggleColor = Color.Gainsboro;

	private bool solidStyle = true;

	[Category("RJ Code Advance")]
	public Color OnBackColor
	{
		get
		{
			return onBackColor;
		}
		set
		{
			onBackColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color OnToggleColor
	{
		get
		{
			return onToggleColor;
		}
		set
		{
			onToggleColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color OffBackColor
	{
		get
		{
			return offBackColor;
		}
		set
		{
			offBackColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color OffToggleColor
	{
		get
		{
			return offToggleColor;
		}
		set
		{
			offToggleColor = value;
			Invalidate();
		}
	}

	[Browsable(false)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
		}
	}

	[Category("RJ Code Advance")]
	[DefaultValue(true)]
	public bool SolidStyle
	{
		get
		{
			return solidStyle;
		}
		set
		{
			solidStyle = value;
			Invalidate();
		}
	}

	public RJToggleButton()
	{
		MinimumSize = new Size(45, 22);
	}

	private GraphicsPath GetFigurePath()
	{
		int arcSize = base.Height - 1;
		Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
		Rectangle rightArc = new Rectangle(base.Width - arcSize - 2, 0, arcSize, arcSize);
		GraphicsPath path = new GraphicsPath();
		path.StartFigure();
		path.AddArc(leftArc, 90f, 180f);
		path.AddArc(rightArc, 270f, 180f);
		path.CloseFigure();
		return path;
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		int toggleSize = base.Height - 5;
		pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		pevent.Graphics.Clear(base.Parent.BackColor);
		if (base.Checked)
		{
			if (solidStyle)
			{
				pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
			}
			else
			{
				pevent.Graphics.DrawPath(new Pen(onBackColor, 2f), GetFigurePath());
			}
			pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(base.Width - base.Height + 1, 2, toggleSize, toggleSize));
		}
		else
		{
			if (solidStyle)
			{
				pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
			}
			else
			{
				pevent.Graphics.DrawPath(new Pen(offBackColor, 2f), GetFigurePath());
			}
			pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
		}
	}
}
