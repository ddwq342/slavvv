using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PUK_Anjamakan.Properties;

namespace PUK_Anjamakan;

public class RJDatePicker : DateTimePicker
{
	private Color skinColor = Color.MediumSlateBlue;

	private Color textColor = Color.White;

	private Color borderColor = Color.PaleVioletRed;

	private int borderSize = 0;

	private bool droppedDown = false;

	private Image calendarIcon = Resources.calendarWhite;

	private RectangleF iconButtonArea;

	private const int calendarIconWidth = 34;

	private const int arrowIconWidth = 17;

	public Color SkinColor
	{
		get
		{
			return skinColor;
		}
		set
		{
			skinColor = value;
			if (skinColor.GetBrightness() >= 0.8f)
			{
				calendarIcon = Resources.calendarDark;
			}
			else
			{
				calendarIcon = Resources.calendarWhite;
			}
			Invalidate();
		}
	}

	public Color TextColor
	{
		get
		{
			return textColor;
		}
		set
		{
			textColor = value;
			Invalidate();
		}
	}

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

	public RJDatePicker()
	{
		SetStyle(ControlStyles.UserPaint, value: true);
		MinimumSize = new Size(0, 35);
		Font = new Font(Font.Name, 9.5f);
	}

	protected override void OnDropDown(EventArgs eventargs)
	{
		base.OnDropDown(eventargs);
		droppedDown = true;
	}

	protected override void OnCloseUp(EventArgs eventargs)
	{
		base.OnCloseUp(eventargs);
		droppedDown = false;
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		base.OnKeyPress(e);
		e.Handled = true;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		using Graphics graphics = CreateGraphics();
		using Pen penBorder = new Pen(borderColor, borderSize);
		using SolidBrush skinBrush = new SolidBrush(skinColor);
		using SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64));
		using SolidBrush textBrush = new SolidBrush(textColor);
		using StringFormat textFormat = new StringFormat();
		RectangleF clientArea = new RectangleF(0f, 0f, (float)base.Width - 0.5f, (float)base.Height - 0.5f);
		RectangleF iconArea = new RectangleF(clientArea.Width - 34f, 0f, 34f, clientArea.Height);
		penBorder.Alignment = PenAlignment.Inset;
		textFormat.LineAlignment = StringAlignment.Center;
		graphics.FillRectangle(skinBrush, clientArea);
		graphics.DrawString("   " + Text, Font, textBrush, clientArea, textFormat);
		if (droppedDown)
		{
			graphics.FillRectangle(openIconBrush, iconArea);
		}
		if (borderSize >= 1)
		{
			graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
		}
		graphics.DrawImage(calendarIcon, base.Width - calendarIcon.Width - 9, (base.Height - calendarIcon.Height) / 2);
	}

	private int GetIconButtonWidth()
	{
		int textWidh = TextRenderer.MeasureText(Text, Font).Width;
		if (textWidh <= base.Width - 54)
		{
			return 34;
		}
		return 17;
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		int iconWidth = GetIconButtonWidth();
		iconButtonArea = new RectangleF(base.Width - iconWidth, 0f, iconWidth, base.Height);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (iconButtonArea.Contains(e.Location))
		{
			Cursor = Cursors.Hand;
		}
		else
		{
			Cursor = Cursors.Default;
		}
	}
}
