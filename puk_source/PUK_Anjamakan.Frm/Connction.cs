using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PUK_Anjamakan.Properties;

namespace PUK_Anjamakan.Frm;

public class Connction : Form
{
	private IContainer components = null;

	private Panel panel1;

	private PictureBox pictureBox1;

	private TextBox txtDatabase;

	private Label label3;

	private Label label6;

	private Label label4;

	private Button btnExit;

	private Label label5;

	private TextBox txtServer;

	private Button btnSave;

	private Label label1;

	private TextBox txtPWD;

	private Label label2;

	private RadioButton rbWindows;

	private TextBox txtID;

	private RadioButton rbSQL;

	public TextBox txtshwen;

	public TextBox textBox1;

	public Connction()
	{
		InitializeComponent();
		txtServer.Text = Settings.Default.Server;
		txtDatabase.Text = Settings.Default.Database;
		txtshwen.Text = Settings.Default.MALBAND;
		if (Settings.Default.Mode == "SQL")
		{
			rbSQL.Checked = true;
			txtID.Text = Settings.Default.ID;
			txtPWD.Text = Settings.Default.Password;
		}
		else
		{
			rbWindows.Checked = true;
			txtID.Clear();
			txtPWD.Clear();
			txtID.ReadOnly = true;
			txtPWD.ReadOnly = true;
		}
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
	}

	private void Connction_Load(object sender, EventArgs e)
	{
		LoadTheme();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		Settings.Default.MALBAND = txtshwen.Text;
		Settings.Default.Server = txtServer.Text;
		Settings.Default.Database = txtDatabase.Text;
		Settings.Default.Mode = (rbSQL.Checked ? "SQL" : "Windows");
		Settings.Default.ID = txtID.Text;
		Settings.Default.Password = txtPWD.Text;
		Settings.Default.Save();
		MessageBox.Show("تم الحفظ بنجاح");
	}

	private void rbWindows_CheckedChanged(object sender, EventArgs e)
	{
		txtID.ReadOnly = true;
		txtPWD.ReadOnly = true;
	}

	private void rbSQL_CheckedChanged(object sender, EventArgs e)
	{
		txtID.ReadOnly = false;
		txtPWD.ReadOnly = false;
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Home fr = new Home();
		fr.Visible = true;
		base.Visible = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUK_Anjamakan.Frm.Connction));
		this.panel1 = new System.Windows.Forms.Panel();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.txtshwen = new System.Windows.Forms.TextBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.txtDatabase = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.btnExit = new System.Windows.Forms.Button();
		this.label5 = new System.Windows.Forms.Label();
		this.txtServer = new System.Windows.Forms.TextBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.txtPWD = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.rbWindows = new System.Windows.Forms.RadioButton();
		this.txtID = new System.Windows.Forms.TextBox();
		this.rbSQL = new System.Windows.Forms.RadioButton();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.Controls.Add(this.textBox1);
		this.panel1.Controls.Add(this.txtshwen);
		this.panel1.Controls.Add(this.pictureBox1);
		this.panel1.Controls.Add(this.txtDatabase);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.btnExit);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.txtServer);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.txtPWD);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.rbWindows);
		this.panel1.Controls.Add(this.txtID);
		this.panel1.Controls.Add(this.rbSQL);
		this.panel1.Location = new System.Drawing.Point(7, 11);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(559, 665);
		this.panel1.TabIndex = 16;
		this.textBox1.Font = new System.Drawing.Font("Ali_K_Alwand", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
		this.textBox1.Location = new System.Drawing.Point(51, 547);
		this.textBox1.Multiline = true;
		this.textBox1.Name = "textBox1";
		this.textBox1.PasswordChar = '*';
		this.textBox1.Size = new System.Drawing.Size(465, 41);
		this.textBox1.TabIndex = 66;
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtshwen.Font = new System.Drawing.Font("Ali_K_Alwand", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
		this.txtshwen.Location = new System.Drawing.Point(168, 495);
		this.txtshwen.Multiline = true;
		this.txtshwen.Name = "txtshwen";
		this.txtshwen.PasswordChar = '*';
		this.txtshwen.Size = new System.Drawing.Size(212, 41);
		this.txtshwen.TabIndex = 65;
		this.txtshwen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(168, 16);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(193, 129);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 13;
		this.pictureBox1.TabStop = false;
		this.txtDatabase.BackColor = System.Drawing.Color.White;
		this.txtDatabase.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtDatabase.Location = new System.Drawing.Point(168, 234);
		this.txtDatabase.Multiline = true;
		this.txtDatabase.Name = "txtDatabase";
		this.txtDatabase.PasswordChar = '*';
		this.txtDatabase.Size = new System.Drawing.Size(212, 41);
		this.txtDatabase.TabIndex = 3;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.label3.ForeColor = System.Drawing.Color.Navy;
		this.label3.Location = new System.Drawing.Point(24, 316);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(151, 30);
		this.label3.TabIndex = 4;
		this.label3.Text = "Authentication";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.label6.ForeColor = System.Drawing.Color.Navy;
		this.label6.Location = new System.Drawing.Point(389, 506);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(127, 30);
		this.label6.TabIndex = 9;
		this.label6.Text = "شوي\u064eني تو\u064eماركردن";
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.label4.ForeColor = System.Drawing.Color.Navy;
		this.label4.Location = new System.Drawing.Point(44, 440);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(107, 30);
		this.label4.TabIndex = 9;
		this.label4.Text = "Password";
		this.btnExit.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnExit.ForeColor = System.Drawing.Color.Navy;
		this.btnExit.Location = new System.Drawing.Point(282, 603);
		this.btnExit.Name = "btnExit";
		this.btnExit.Size = new System.Drawing.Size(98, 49);
		this.btnExit.TabIndex = 12;
		this.btnExit.Text = "Close";
		this.btnExit.UseVisualStyleBackColor = true;
		this.btnExit.Click += new System.EventHandler(btnExit_Click);
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.label5.ForeColor = System.Drawing.Color.Navy;
		this.label5.Location = new System.Drawing.Point(36, 381);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(126, 30);
		this.label5.TabIndex = 7;
		this.label5.Text = "User_Name";
		this.txtServer.BackColor = System.Drawing.SystemColors.Menu;
		this.txtServer.Font = new System.Drawing.Font("Tahoma", 10.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtServer.Location = new System.Drawing.Point(168, 185);
		this.txtServer.Multiline = true;
		this.txtServer.Name = "txtServer";
		this.txtServer.PasswordChar = '*';
		this.txtServer.Size = new System.Drawing.Size(348, 41);
		this.txtServer.TabIndex = 1;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.Navy;
		this.btnSave.Location = new System.Drawing.Point(168, 603);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(102, 49);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.label1.ForeColor = System.Drawing.Color.Navy;
		this.label1.Location = new System.Drawing.Point(24, 188);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(138, 30);
		this.label1.TabIndex = 0;
		this.label1.Text = "Server Name";
		this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.txtPWD.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPWD.Location = new System.Drawing.Point(168, 437);
		this.txtPWD.Multiline = true;
		this.txtPWD.Name = "txtPWD";
		this.txtPWD.PasswordChar = '*';
		this.txtPWD.ReadOnly = true;
		this.txtPWD.Size = new System.Drawing.Size(212, 41);
		this.txtPWD.TabIndex = 10;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.label2.ForeColor = System.Drawing.Color.Navy;
		this.label2.Location = new System.Drawing.Point(46, 237);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(105, 30);
		this.label2.TabIndex = 2;
		this.label2.Text = "Database";
		this.rbWindows.AutoSize = true;
		this.rbWindows.Checked = true;
		this.rbWindows.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.rbWindows.ForeColor = System.Drawing.Color.Navy;
		this.rbWindows.Location = new System.Drawing.Point(187, 292);
		this.rbWindows.Name = "rbWindows";
		this.rbWindows.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.rbWindows.Size = new System.Drawing.Size(265, 34);
		this.rbWindows.TabIndex = 5;
		this.rbWindows.TabStop = true;
		this.rbWindows.Text = "Windows Authentication";
		this.rbWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.rbWindows.UseVisualStyleBackColor = true;
		this.rbWindows.CheckedChanged += new System.EventHandler(rbWindows_CheckedChanged);
		this.txtID.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtID.Location = new System.Drawing.Point(168, 378);
		this.txtID.Multiline = true;
		this.txtID.Name = "txtID";
		this.txtID.PasswordChar = '*';
		this.txtID.ReadOnly = true;
		this.txtID.Size = new System.Drawing.Size(212, 41);
		this.txtID.TabIndex = 8;
		this.rbSQL.AutoSize = true;
		this.rbSQL.Font = new System.Drawing.Font("Ali_K_Samik", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
		this.rbSQL.ForeColor = System.Drawing.Color.Navy;
		this.rbSQL.Location = new System.Drawing.Point(187, 336);
		this.rbSQL.Name = "rbSQL";
		this.rbSQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.rbSQL.Size = new System.Drawing.Size(290, 34);
		this.rbSQL.TabIndex = 6;
		this.rbSQL.Text = "SQL Server Authentication";
		this.rbSQL.UseVisualStyleBackColor = true;
		this.rbSQL.CheckedChanged += new System.EventHandler(rbSQL_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Navy;
		base.ClientSize = new System.Drawing.Size(575, 686);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Connction";
		this.Text = "Connction";
		base.Load += new System.EventHandler(Connction_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
