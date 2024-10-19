using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PUK_Anjamakan.DAL;

namespace PUK_Anjamakan.Frm;

public class log_in : Form
{
	private CLS_PRODUCTS log = new CLS_PRODUCTS();

	private IContainer components = null;

	private Panel leftPanel;

	private Label labelWelcome;

	private Label labelAppName;

	private Label labelDescription;

	private Label labelName;

	private Label txtPassword;

	private Label labelPassword;

	private TextBox txtpass;

	private CheckBox chekpas;

	private Button buttonSignUp;

	private Button buttonSignIn;

	private ComboBox comtype;

	private Panel panel1;

	public TextBox TxtUser;

	public log_in()
	{
		InitializeComponent();
	}

	private void labelDescription_Click(object sender, EventArgs e)
	{
	}

	private void buttonSignIn_Click(object sender, EventArgs e)
	{
		if (TxtUser.Text == string.Empty || txtPassword.Text == string.Empty || comtype.Text == string.Empty)
		{
			MessageBox.Show(" تکایە خانەکان پڕبکەوە ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		DataTable dt = log.SP_LOGIN2(TxtUser.Text, txtpass.Text, comtype.Text);
		if (dt.Rows.Count > 0)
		{
			if (dt.Rows[0][3].ToString() == "All")
			{
				Program.entryName = TxtUser.Text;
				Program.User_tyape = comtype.Text;
				Home fr = new Home();
				fr.Visible = true;
				base.Visible = false;
			}
			if (dt.Rows[0][3].ToString() == "Slemany")
			{
				Program.entryName = TxtUser.Text;
				Program.User_tyape = comtype.Text;
				Home fr = new Home();
				fr.Visible = true;
				base.Visible = false;
			}
			if (dt.Rows[0][3].ToString() == "Dhok")
			{
				Program.entryName = TxtUser.Text;
				Program.User_tyape = comtype.Text;
				Home fr = new Home();
				fr.Visible = true;
				base.Visible = false;
			}
			if (dt.Rows[0][3].ToString() == "Taybat")
			{
				Program.entryName = TxtUser.Text;
				Program.User_tyape = comtype.Text;
				Home fr = new Home();
				fr.Visible = true;
				base.Visible = false;
			}
			if (dt.Rows[0][3].ToString() == "Halabja")
			{
				Program.entryName = TxtUser.Text;
				Program.User_tyape = comtype.Text;
				Home fr = new Home();
				fr.Visible = true;
				base.Visible = false;
			}
			if (dt.Rows[0][3].ToString() == "Hawler")
			{
				Program.entryName = TxtUser.Text;
				Program.User_tyape = comtype.Text;
				Home fr = new Home();
				fr.Visible = true;
				base.Visible = false;
			}
		}
		else
		{
			MessageBox.Show("Please Check Your User_Name Or password Or User_Type", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void checkBoxTerms_CheckedChanged(object sender, EventArgs e)
	{
		if (chekpas.Checked)
		{
			txtpass.UseSystemPasswordChar = false;
		}
		else
		{
			txtpass.UseSystemPasswordChar = true;
		}
	}

	private void log_in_Load(object sender, EventArgs e)
	{
		panel1.BackColor = Color.FromArgb(243, 243, 243);
		if (chekpas.Checked)
		{
			txtpass.UseSystemPasswordChar = false;
		}
		else
		{
			txtpass.UseSystemPasswordChar = true;
		}
	}

	private void buttonSignUp_Click(object sender, EventArgs e)
	{
		Home ho = new Home();
		ho.Visible = true;
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
		this.leftPanel = new System.Windows.Forms.Panel();
		this.labelWelcome = new System.Windows.Forms.Label();
		this.labelAppName = new System.Windows.Forms.Label();
		this.labelDescription = new System.Windows.Forms.Label();
		this.labelName = new System.Windows.Forms.Label();
		this.txtPassword = new System.Windows.Forms.Label();
		this.labelPassword = new System.Windows.Forms.Label();
		this.TxtUser = new System.Windows.Forms.TextBox();
		this.txtpass = new System.Windows.Forms.TextBox();
		this.chekpas = new System.Windows.Forms.CheckBox();
		this.buttonSignUp = new System.Windows.Forms.Button();
		this.buttonSignIn = new System.Windows.Forms.Button();
		this.comtype = new System.Windows.Forms.ComboBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.leftPanel.SuspendLayout();
		base.SuspendLayout();
		this.leftPanel.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
		this.leftPanel.Controls.Add(this.labelWelcome);
		this.leftPanel.Controls.Add(this.labelAppName);
		this.leftPanel.Controls.Add(this.labelDescription);
		this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.leftPanel.Location = new System.Drawing.Point(0, 0);
		this.leftPanel.Name = "leftPanel";
		this.leftPanel.Size = new System.Drawing.Size(382, 450);
		this.leftPanel.TabIndex = 0;
		this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 14f);
		this.labelWelcome.ForeColor = System.Drawing.Color.White;
		this.labelWelcome.Location = new System.Drawing.Point(127, 160);
		this.labelWelcome.Name = "labelWelcome";
		this.labelWelcome.Size = new System.Drawing.Size(150, 40);
		this.labelWelcome.TabIndex = 1;
		this.labelWelcome.Text = "Welcome to";
		this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
		this.labelAppName.ForeColor = System.Drawing.Color.White;
		this.labelAppName.Location = new System.Drawing.Point(106, 210);
		this.labelAppName.Name = "labelAppName";
		this.labelAppName.Size = new System.Drawing.Size(182, 43);
		this.labelAppName.TabIndex = 2;
		this.labelAppName.Text = "Login_Form";
		this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10f);
		this.labelDescription.ForeColor = System.Drawing.Color.White;
		this.labelDescription.Location = new System.Drawing.Point(3, 253);
		this.labelDescription.Name = "labelDescription";
		this.labelDescription.Size = new System.Drawing.Size(389, 77);
		this.labelDescription.TabIndex = 3;
		this.labelDescription.Text = "Please Enter Your User_Name and Password\r\n And Select User_Type";
		this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.labelDescription.Click += new System.EventHandler(labelDescription_Click);
		this.labelName.Font = new System.Drawing.Font("Segoe UI", 10f);
		this.labelName.ForeColor = System.Drawing.Color.Black;
		this.labelName.Location = new System.Drawing.Point(449, 63);
		this.labelName.Name = "labelName";
		this.labelName.Size = new System.Drawing.Size(100, 23);
		this.labelName.TabIndex = 0;
		this.labelName.Text = "Name";
		this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10f);
		this.txtPassword.ForeColor = System.Drawing.Color.Black;
		this.txtPassword.Location = new System.Drawing.Point(449, 133);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.Size = new System.Drawing.Size(100, 23);
		this.txtPassword.TabIndex = 1;
		this.txtPassword.Text = "Password";
		this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10f);
		this.labelPassword.ForeColor = System.Drawing.Color.Black;
		this.labelPassword.Location = new System.Drawing.Point(449, 203);
		this.labelPassword.Name = "labelPassword";
		this.labelPassword.Size = new System.Drawing.Size(100, 23);
		this.labelPassword.TabIndex = 2;
		this.labelPassword.Text = "User_Type";
		this.TxtUser.Font = new System.Drawing.Font("Segoe UI", 10f);
		this.TxtUser.Location = new System.Drawing.Point(449, 93);
		this.TxtUser.Name = "TxtUser";
		this.TxtUser.Size = new System.Drawing.Size(250, 30);
		this.TxtUser.TabIndex = 3;
		this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10f);
		this.txtpass.Location = new System.Drawing.Point(449, 163);
		this.txtpass.Name = "txtpass";
		this.txtpass.Size = new System.Drawing.Size(250, 30);
		this.txtpass.TabIndex = 4;
		this.chekpas.Font = new System.Drawing.Font("Segoe UI", 8f);
		this.chekpas.Location = new System.Drawing.Point(449, 273);
		this.chekpas.Name = "chekpas";
		this.chekpas.Size = new System.Drawing.Size(104, 24);
		this.chekpas.TabIndex = 6;
		this.chekpas.Text = "Show_Pass";
		this.chekpas.CheckedChanged += new System.EventHandler(checkBoxTerms_CheckedChanged);
		this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
		this.buttonSignUp.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
		this.buttonSignUp.ForeColor = System.Drawing.Color.White;
		this.buttonSignUp.Location = new System.Drawing.Point(596, 315);
		this.buttonSignUp.Name = "buttonSignUp";
		this.buttonSignUp.Size = new System.Drawing.Size(100, 38);
		this.buttonSignUp.TabIndex = 7;
		this.buttonSignUp.Text = "Close";
		this.buttonSignUp.UseVisualStyleBackColor = false;
		this.buttonSignUp.Click += new System.EventHandler(buttonSignUp_Click);
		this.buttonSignIn.BackColor = System.Drawing.Color.White;
		this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
		this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
		this.buttonSignIn.Location = new System.Drawing.Point(449, 315);
		this.buttonSignIn.Name = "buttonSignIn";
		this.buttonSignIn.Size = new System.Drawing.Size(100, 38);
		this.buttonSignIn.TabIndex = 8;
		this.buttonSignIn.Text = "Log In";
		this.buttonSignIn.UseVisualStyleBackColor = false;
		this.buttonSignIn.Click += new System.EventHandler(buttonSignIn_Click);
		this.comtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comtype.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comtype.FormattingEnabled = true;
		this.comtype.Items.AddRange(new object[6] { "Hawler", "Slemany", "Dhok", "Halabja", "Taybat", "All" });
		this.comtype.Location = new System.Drawing.Point(450, 232);
		this.comtype.Name = "comtype";
		this.comtype.Size = new System.Drawing.Size(246, 32);
		this.comtype.TabIndex = 9;
		this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(799, 34);
		this.panel1.TabIndex = 10;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.comtype);
		base.Controls.Add(this.leftPanel);
		base.Controls.Add(this.labelName);
		base.Controls.Add(this.txtPassword);
		base.Controls.Add(this.buttonSignUp);
		base.Controls.Add(this.labelPassword);
		base.Controls.Add(this.buttonSignIn);
		base.Controls.Add(this.TxtUser);
		base.Controls.Add(this.chekpas);
		base.Controls.Add(this.txtpass);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "log_in";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Login";
		base.Load += new System.EventHandler(log_in_Load);
		this.leftPanel.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
