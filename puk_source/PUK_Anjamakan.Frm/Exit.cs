using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PUK_Anjamakan.Frm;

public class Exit : Form
{
	private IContainer components = null;

	private Label label4;

	private Label label5;

	private Button button3;

	private Button button2;

	private Button button1;

	public Exit()
	{
		InitializeComponent();
	}

	private void LoadTheme()
	{
		foreach (Control btns in base.Controls)
		{
			if (btns.GetType() == typeof(Button))
			{
				Button btn = (Button)btns;
				btn.BackColor = ThemeColor.PrimaryColor;
				btn.ForeColor = Color.White;
				btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
			}
		}
		label4.ForeColor = ThemeColor.SecondaryColor;
		label5.ForeColor = ThemeColor.PrimaryColor;
	}

	private void Exit_Load(object sender, EventArgs e)
	{
		LoadTheme();
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
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(304, 29);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(42, 17);
		this.label4.TabIndex = 9;
		this.label4.Text = "label2";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(138, 365);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(42, 17);
		this.label5.TabIndex = 8;
		this.label5.Text = "label1";
		this.button3.Location = new System.Drawing.Point(362, 376);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(82, 45);
		this.button3.TabIndex = 7;
		this.button3.Text = "button3";
		this.button3.UseVisualStyleBackColor = true;
		this.button2.Location = new System.Drawing.Point(471, 376);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(82, 45);
		this.button2.TabIndex = 6;
		this.button2.Text = "button2";
		this.button2.UseVisualStyleBackColor = true;
		this.button1.Location = new System.Drawing.Point(580, 376);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(82, 45);
		this.button1.TabIndex = 5;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		base.Name = "Exit";
		this.Text = "Exit";
		base.Load += new System.EventHandler(Exit_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
