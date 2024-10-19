using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PUK_Anjamakan;

public class RJProgressBar : ProgressBar
{
	private Color channelColor = Color.LightSteelBlue;

	private Color sliderColor = Color.RoyalBlue;

	private Color foreBackColor = Color.RoyalBlue;

	private int channelHeight = 6;

	private int sliderHeight = 6;

	private TextPosition showValue = TextPosition.Right;

	private string symbolBefore = "";

	private string symbolAfter = "";

	private bool showMaximun = false;

	private bool paintedBack = false;

	private bool stopPainting = false;

	[Category("RJ Code Advance")]
	public Color ChannelColor
	{
		get
		{
			return channelColor;
		}
		set
		{
			channelColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color SliderColor
	{
		get
		{
			return sliderColor;
		}
		set
		{
			sliderColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color ForeBackColor
	{
		get
		{
			return foreBackColor;
		}
		set
		{
			foreBackColor = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public int ChannelHeight
	{
		get
		{
			return channelHeight;
		}
		set
		{
			channelHeight = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public int SliderHeight
	{
		get
		{
			return sliderHeight;
		}
		set
		{
			sliderHeight = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public TextPosition ShowValue
	{
		get
		{
			return showValue;
		}
		set
		{
			showValue = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public string SymbolBefore
	{
		get
		{
			return symbolBefore;
		}
		set
		{
			symbolBefore = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public string SymbolAfter
	{
		get
		{
			return symbolAfter;
		}
		set
		{
			symbolAfter = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public bool ShowMaximun
	{
		get
		{
			return showMaximun;
		}
		set
		{
			showMaximun = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
		}
	}

	[Category("RJ Code Advance")]
	public override Color ForeColor
	{
		get
		{
			return base.ForeColor;
		}
		set
		{
			base.ForeColor = value;
		}
	}

	public RJProgressBar()
	{
		SetStyle(ControlStyles.UserPaint, value: true);
		ForeColor = Color.White;
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		if (stopPainting)
		{
			return;
		}
		if (!paintedBack)
		{
			Graphics graph = pevent.Graphics;
			Rectangle rectChannel = new Rectangle(0, 0, base.Width, ChannelHeight);
			using SolidBrush brushChannel = new SolidBrush(channelColor);
			if (channelHeight >= sliderHeight)
			{
				rectChannel.Y = base.Height - channelHeight;
			}
			else
			{
				rectChannel.Y = base.Height - (channelHeight + sliderHeight) / 2;
			}
			graph.Clear(base.Parent.BackColor);
			graph.FillRectangle(brushChannel, rectChannel);
			if (!base.DesignMode)
			{
				paintedBack = true;
			}
		}
		if (base.Value == base.Maximum || base.Value == base.Minimum)
		{
			paintedBack = false;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (!stopPainting)
		{
			Graphics graph = e.Graphics;
			double scaleFactor = ((double)base.Value - (double)base.Minimum) / ((double)base.Maximum - (double)base.Minimum);
			int sliderWidth = (int)((double)base.Width * scaleFactor);
			Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
			using SolidBrush brushSlider = new SolidBrush(sliderColor);
			if (sliderHeight >= channelHeight)
			{
				rectSlider.Y = base.Height - sliderHeight;
			}
			else
			{
				rectSlider.Y = base.Height - (sliderHeight + channelHeight) / 2;
			}
			if (sliderWidth > 1)
			{
				graph.FillRectangle(brushSlider, rectSlider);
			}
			if (showValue != TextPosition.None)
			{
				DrawValueText(graph, sliderWidth, rectSlider);
			}
		}
		if (base.Value == base.Maximum)
		{
			stopPainting = true;
		}
		else
		{
			stopPainting = false;
		}
	}

	private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
	{
		string text = symbolBefore + base.Value + symbolAfter;
		if (showMaximun)
		{
			text = text + "/" + symbolBefore + base.Maximum + symbolAfter;
		}
		Size textSize = TextRenderer.MeasureText(text, Font);
		Rectangle rectText = new Rectangle(0, 0, textSize.Width, textSize.Height + 2);
		using SolidBrush brushText = new SolidBrush(ForeColor);
		using SolidBrush brushTextBack = new SolidBrush(foreBackColor);
		using StringFormat textFormat = new StringFormat();
		switch (showValue)
		{
		case TextPosition.Left:
			rectText.X = 0;
			textFormat.Alignment = StringAlignment.Near;
			break;
		case TextPosition.Right:
			rectText.X = base.Width - textSize.Width;
			textFormat.Alignment = StringAlignment.Far;
			break;
		case TextPosition.Centre:
			rectText.X = (base.Width - textSize.Width) / 2;
			textFormat.Alignment = StringAlignment.Center;
			break;
		case TextPosition.Sliding:
		{
			rectText.X = sliderWidth - textSize.Width;
			textFormat.Alignment = StringAlignment.Center;
			using (SolidBrush brushClear = new SolidBrush(base.Parent.BackColor))
			{
				Rectangle rect = rectSlider;
				rect.Y = rectText.X;
				rect.Height = rectText.Height;
				graph.FillRectangle(brushClear, rect);
			}
			break;
		}
		}
		graph.FillRectangle(brushTextBack, rectText);
		graph.DrawString(text, Font, brushText, rectText, textFormat);
	}
}
