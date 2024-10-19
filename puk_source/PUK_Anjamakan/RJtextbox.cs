using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PUK_Anjamakan;

[DefaultEvent("_TextChanged")]
public class RJtextbox : UserControl
{
	private Color borderColor = Color.MediumSlateBlue;

	private Color borderFocusColor = Color.HotPink;

	private int borderSize = 2;

	private bool underlinedStyle = false;

	private bool isFocused = false;

	private int borderRadius = 0;

	private Color placeholderColor = Color.DarkGray;

	private string placeholderText = "";

	private bool isPlaceholder = false;

	private bool isPasswordChar = false;

	private IContainer components = null;

	private TextBox textBox1;

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
	public Color BorderFocusColor
	{
		get
		{
			return borderFocusColor;
		}
		set
		{
			borderFocusColor = value;
		}
	}

	[Category("RJ Code Advance")]
	public int BorderSize
	{
		get
		{
			return borderSize;
		}
		set
		{
			if (value >= 1)
			{
				borderSize = value;
				Invalidate();
			}
		}
	}

	[Category("RJ Code Advance")]
	public bool UnderlinedStyle
	{
		get
		{
			return underlinedStyle;
		}
		set
		{
			underlinedStyle = value;
			Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public bool PasswordChar
	{
		get
		{
			return isPasswordChar;
		}
		set
		{
			isPasswordChar = value;
			if (!isPlaceholder)
			{
				textBox1.UseSystemPasswordChar = value;
			}
		}
	}

	[Category("RJ Code Advance")]
	public bool Multiline
	{
		get
		{
			return textBox1.Multiline;
		}
		set
		{
			textBox1.Multiline = value;
		}
	}

	[Category("RJ Code Advance")]
	public override Color BackColor
	{
		get
		{
			return base.BackColor;
		}
		set
		{
			base.BackColor = value;
			textBox1.BackColor = value;
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
			textBox1.ForeColor = value;
		}
	}

	[Category("RJ Code Advance")]
	public override Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
			textBox1.Font = value;
			if (base.DesignMode)
			{
				UpdateControlHeight();
			}
		}
	}

	[Category("RJ Code Advance")]
	public string Texts
	{
		get
		{
			if (isPlaceholder)
			{
				return "";
			}
			return textBox1.Text;
		}
		set
		{
			textBox1.Text = value;
			SetPlaceholder();
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
			if (value >= 0)
			{
				borderRadius = value;
				Invalidate();
			}
		}
	}

	[Category("RJ Code Advance")]
	public Color PlaceholderColor
	{
		get
		{
			return placeholderColor;
		}
		set
		{
			placeholderColor = value;
			if (isPlaceholder)
			{
				textBox1.ForeColor = value;
			}
		}
	}

	[Category("RJ Code Advance")]
	public string PlaceholderText
	{
		get
		{
			return placeholderText;
		}
		set
		{
			placeholderText = value;
			textBox1.Text = "";
			SetPlaceholder();
		}
	}

	public event EventHandler _TextChanged;

	public RJtextbox()
	{
		InitializeComponent();
	}

	private void SetPlaceholder()
	{
		if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
		{
			isPlaceholder = true;
			textBox1.Text = placeholderText;
			textBox1.ForeColor = placeholderColor;
			if (isPasswordChar)
			{
				textBox1.UseSystemPasswordChar = false;
			}
		}
	}

	private GraphicsPath GetFigurePath(Rectangle rect, int radius)
	{
		GraphicsPath path = new GraphicsPath();
		float curveSize = (float)radius * 2f;
		path.StartFigure();
		path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180f, 90f);
		path.AddArc((float)rect.Right - curveSize, rect.Y, curveSize, curveSize, 270f, 90f);
		path.AddArc((float)rect.Right - curveSize, (float)rect.Bottom - curveSize, curveSize, curveSize, 0f, 90f);
		path.AddArc(rect.X, (float)rect.Bottom - curveSize, curveSize, curveSize, 90f, 90f);
		path.CloseFigure();
		return path;
	}

	private void SetTextBoxRoundedRegion()
	{
		GraphicsPath pathTxt;
		if (Multiline)
		{
			pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
			textBox1.Region = new Region(pathTxt);
		}
		else
		{
			pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
			textBox1.Region = new Region(pathTxt);
		}
		pathTxt.Dispose();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Graphics graph = e.Graphics;
		if (borderRadius > 1)
		{
			Rectangle rectBorderSmooth = base.ClientRectangle;
			Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
			int smoothSize = ((borderSize <= 0) ? 1 : borderSize);
			using GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius);
			using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize);
			using Pen penBorderSmooth = new Pen(base.Parent.BackColor, smoothSize);
			using Pen penBorder = new Pen(borderColor, borderSize);
			base.Region = new Region(pathBorderSmooth);
			if (borderRadius > 15)
			{
				SetTextBoxRoundedRegion();
			}
			graph.SmoothingMode = SmoothingMode.AntiAlias;
			penBorder.Alignment = PenAlignment.Center;
			if (isFocused)
			{
				penBorder.Color = borderFocusColor;
			}
			if (underlinedStyle)
			{
				graph.DrawPath(penBorderSmooth, pathBorderSmooth);
				graph.SmoothingMode = SmoothingMode.None;
				graph.DrawLine(penBorder, 0, base.Height - 1, base.Width, base.Height - 1);
			}
			else
			{
				graph.DrawPath(penBorderSmooth, pathBorderSmooth);
				graph.DrawPath(penBorder, pathBorder);
			}
			return;
		}
		using Pen pen = new Pen(borderColor, borderSize);
		base.Region = new Region(base.ClientRectangle);
		pen.Alignment = PenAlignment.Inset;
		if (isFocused)
		{
			pen.Color = borderFocusColor;
		}
		if (underlinedStyle)
		{
			graph.DrawLine(pen, 0, base.Height - 1, base.Width, base.Height - 1);
		}
		else
		{
			graph.DrawRectangle(pen, 0f, 0f, (float)base.Width - 0.5f, (float)base.Height - 0.5f);
		}
	}

	private void RemovePlaceholder()
	{
		if (isPlaceholder && placeholderText != "")
		{
			isPlaceholder = false;
			textBox1.Text = "";
			textBox1.ForeColor = ForeColor;
			if (isPasswordChar)
			{
				textBox1.UseSystemPasswordChar = true;
			}
		}
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		UpdateControlHeight();
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		if (base.DesignMode)
		{
			UpdateControlHeight();
		}
	}

	private void UpdateControlHeight()
	{
		if (!textBox1.Multiline)
		{
			int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
			textBox1.Multiline = true;
			textBox1.MinimumSize = new Size(0, txtHeight);
			textBox1.Multiline = false;
			base.Height = textBox1.Height + base.Padding.Top + base.Padding.Bottom;
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (this._TextChanged != null)
		{
			this._TextChanged(sender, e);
		}
	}

	private void RJtextbox_Click(object sender, EventArgs e)
	{
	}

	private void RJtextbox_MouseEnter(object sender, EventArgs e)
	{
	}

	private void RJtextbox_MouseLeave(object sender, EventArgs e)
	{
	}

	private void RJtextbox_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void RJtextbox_Enter(object sender, EventArgs e)
	{
	}

	private void RJtextbox_Leave(object sender, EventArgs e)
	{
	}

	private void textBox1_Click(object sender, EventArgs e)
	{
		OnClick(e);
	}

	private void textBox1_MouseEnter(object sender, EventArgs e)
	{
		OnMouseEnter(e);
	}

	private void textBox1_MouseLeave(object sender, EventArgs e)
	{
		OnMouseLeave(e);
	}

	private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		OnKeyPress(e);
	}

	private void textBox1_Enter(object sender, EventArgs e)
	{
		isFocused = true;
		Invalidate();
		RemovePlaceholder();
	}

	private void textBox1_Leave(object sender, EventArgs e)
	{
		isFocused = false;
		Invalidate();
		SetPlaceholder();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.textBox1 = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.textBox1.Location = new System.Drawing.Point(10, 7);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(230, 21);
		this.textBox1.TabIndex = 0;
		this.textBox1.Click += new System.EventHandler(textBox1_Click);
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.textBox1.Enter += new System.EventHandler(textBox1_Enter);
		this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox1_KeyPress);
		this.textBox1.Leave += new System.EventHandler(textBox1_Leave);
		this.textBox1.MouseEnter += new System.EventHandler(textBox1_MouseEnter);
		this.textBox1.MouseLeave += new System.EventHandler(textBox1_MouseLeave);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.SystemColors.Window;
		base.Controls.Add(this.textBox1);
		this.Font = new System.Drawing.Font("Tahoma", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ForeColor = System.Drawing.Color.Black;
		base.Name = "RJtextbox";
		base.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
		base.Size = new System.Drawing.Size(250, 30);
		base.Click += new System.EventHandler(RJtextbox_Click);
		base.Enter += new System.EventHandler(RJtextbox_Enter);
		base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(RJtextbox_KeyPress);
		base.Leave += new System.EventHandler(RJtextbox_Leave);
		base.MouseEnter += new System.EventHandler(RJtextbox_MouseEnter);
		base.MouseLeave += new System.EventHandler(RJtextbox_MouseLeave);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
