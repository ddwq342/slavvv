using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PUK_Anjamakan.Properties;

namespace PUK_Anjamakan.Frm;

public class Home : Form
{
	private Button currentButton;

	private Random random;

	private int tempIndex;

	private Form activeForm;

	private SqlConnection con = new SqlConnection("Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password);

	private SqlCommand cmd;

	private IContainer components = null;

	private Panel panelMenu;

	private Button btnhawler;

	private Button btnslemany;

	private Button addtaybat;

	private Panel panelLogo;

	private Panel panelTitleBar;

	private Label lblTitle;

	private Panel panelDesktopPane;

	private Button btnCloseChildForm;

	private PictureBox pictureBox1;

	private Button button2;

	private Button button1;

	private Button button3;

	private Panel pnltaskbar;

	public Label lblshwen;

	public Label lblkarmand;

	public Label lbltaime;

	private Button btnrest;

	private Button btnclose;

	private Button btnreport;

	private Button btnconn;

	private Button btnhalbja;

	private Button btndhok;

	private TableLayoutPanel tableLayoutPanel1;

	public Label lbldevice;

	public Label lblsrial;

	private Label lbluser;

	private Button btnlogin;

	private Label label1;

	private Label label2;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label6;

	private Label lbl_tybat;

	private Label label7;

	private Button button4;

	private Button button5;

	private Label txtFileName;

	public Home()
	{
		InitializeComponent();
		lbltaime.Text = DateTime.Now.ToString();
		random = new Random();
		btnCloseChildForm.Visible = false;
		Text = string.Empty;
		base.ControlBox = false;
		base.MaximizedBounds = Screen.FromHandle(base.Handle).Bounds;
		panelMenu.Size = new Size(51, 778);
		addtaybat.Text = "";
		btnreport.Text = "";
		btnclose.Text = "";
		btnhawler.Text = "";
		addtaybat.Text = "";
		btnslemany.Text = "";
		btnrest.Text = "";
		string deviceName = Environment.MachineName;
		lbldevice.Text = deviceName;
		string serialNumber = GetLaptopSerialNumber();
		lblsrial.Text = serialNumber;
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	private Color SelectThemeColor()
	{
		int index = random.Next(ThemeColor.ColorList.Count);
		while (tempIndex == index)
		{
			index = random.Next(ThemeColor.ColorList.Count);
		}
		tempIndex = index;
		string color = ThemeColor.ColorList[index];
		return ColorTranslator.FromHtml(color);
	}

	private void DisableButton()
	{
		foreach (Control previousBtn in panelMenu.Controls)
		{
			if (previousBtn.GetType() == typeof(Button))
			{
				previousBtn.BackColor = Color.FromArgb(51, 51, 76);
				previousBtn.ForeColor = Color.Gainsboro;
				previousBtn.Font = new Font("Unikurd Jino", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}
	}

	private void Reset()
	{
		DisableButton();
		lblTitle.Text = "HOME";
		panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
		panelLogo.BackColor = Color.FromArgb(39, 39, 58);
		currentButton = null;
		btnCloseChildForm.Visible = false;
		pnltaskbar.Visible = true;
	}

	private void OpenChildForm(Form childForm, object btnSender)
	{
		if (activeForm != null)
		{
			activeForm.Close();
		}
		ActivateButton(btnSender);
		activeForm = childForm;
		childForm.TopLevel = false;
		childForm.FormBorderStyle = FormBorderStyle.None;
		childForm.Dock = DockStyle.Fill;
		panelDesktopPane.Controls.Add(childForm);
		panelDesktopPane.Tag = childForm;
		childForm.BringToFront();
		childForm.Show();
		lblTitle.Font = new Font("Unikurd Jino", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblTitle.Text = childForm.Text;
	}

	private void ActivateButton(object btnSender)
	{
		if (btnSender != null && currentButton != (Button)btnSender)
		{
			DisableButton();
			Color color = SelectThemeColor();
			currentButton = (Button)btnSender;
			currentButton.BackColor = color;
			currentButton.ForeColor = Color.White;
			currentButton.Font = new Font("Unikurd Jino", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			panelTitleBar.BackColor = color;
			lblTitle.Font = new Font("Unikurd Jino", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			pnltaskbar.Visible = false;
			panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
			ThemeColor.PrimaryColor = color;
			ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
			btnCloseChildForm.Visible = true;
		}
	}

	private void btnadd_gshty_Click(object sender, EventArgs e)
	{
		OpenChildForm(new Frm_Tybat(), sender);
	}

	private void btnreport_Click(object sender, EventArgs e)
	{
		OpenChildForm(new S_Gshty(), sender);
	}

	private void btnconn_Click(object sender, EventArgs e)
	{
		OpenChildForm(new H_Gshty(), sender);
	}

	private void btnrest_Click(object sender, EventArgs e)
	{
	}

	private void btnclose_Click(object sender, EventArgs e)
	{
		OpenChildForm(new Exit(), sender);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (activeForm != null)
		{
			activeForm.Close();
		}
		Reset();
	}

	private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(base.Handle, 274, 61458, 0);
	}

	private void panelLogo_MouseDown(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(base.Handle, 274, 61458, 0);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Normal)
		{
			base.WindowState = FormWindowState.Maximized;
		}
		else
		{
			base.WindowState = FormWindowState.Normal;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void btnadd_gshty_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnadd_tybat_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnview_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnreport_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnconn_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnrest_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnclose_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void panelDesktopPane_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(51, 778);
		addtaybat.Text = "";
		btnreport.Text = "";
		btnclose.Text = "";
		btnhawler.Text = "";
		addtaybat.Text = "";
		btnslemany.Text = "";
		btnrest.Text = "";
		btnconn.Text = "";
		btnlogin.Text = "";
		btnhalbja.Text = "";
		btndhok.Text = "";
		btnlogin.Text = "";
	}

	private void panelLogo_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void panelMenu_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(51, 778);
		addtaybat.Text = "";
		btnreport.Text = "";
		btnclose.Text = "";
		btnhawler.Text = "";
		addtaybat.Text = "";
		btnslemany.Text = "";
		btnrest.Text = "";
		btnhalbja.Text = "";
		btndhok.Text = "";
		btnlogin.Text = "";
		btnconn.Text = "";
	}

	private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(51, 778);
		addtaybat.Text = "";
		btnreport.Text = "";
		btnclose.Text = "";
		btnhawler.Text = "";
		addtaybat.Text = "";
		btnslemany.Text = "";
		btnrest.Text = "";
		btnhalbja.Text = "";
		btndhok.Text = "";
		btnconn.Text = "";
		btnlogin.Text = "";
	}

	private string GetLaptopSerialNumber()
	{
		string serialNumber = string.Empty;
		try
		{
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");
			foreach (ManagementObject obj in searcher.Get())
			{
				serialNumber = obj["SerialNumber"].ToString();
			}
		}
		catch (Exception ex)
		{
			serialNumber = "Error retrieving serial number: " + ex.Message;
		}
		return serialNumber;
	}

	private void Home_Load(object sender, EventArgs e)
	{
		string deviceName = Environment.MachineName;
		lbldevice.Text = deviceName;
		string serialNumber = GetLaptopSerialNumber();
		lblsrial.Text = serialNumber;
		addtaybat.Enabled = false;
		btnslemany.Enabled = false;
		btnhawler.Enabled = false;
		btnreport.Enabled = false;
		btnhalbja.Enabled = false;
		btndhok.Enabled = false;
		lbluser.Text = Program.User_tyape;
		User_type();
		connctions();
		connctionsh();
		connctiond();
		connctionshl();
		connction_tybat();
	}

	private void connctions()
	{
		string str = "Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password;
		SqlConnection con = new SqlConnection(str);
		string query = "SELECT COUNT(ID) FROM slemany_hazb ";
		try
		{
			con.Open();
			label1.ForeColor = Color.Yellow;
			label1.Text = "Database Sucessfully Connected";
			SqlCommand cmd = new SqlCommand(query, con);
			int rows_count = Convert.ToInt32(cmd.ExecuteScalar());
			cmd.Dispose();
			con.Close();
			label2.ForeColor = Color.White;
			label2.Text = "سلێمانی = " + rows_count;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
		}
	}

	private void connctionshl()
	{
		string str = "Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password;
		SqlConnection con = new SqlConnection(str);
		string query = "SELECT COUNT(ID) FROM halabja_hazb ";
		try
		{
			con.Open();
			label1.ForeColor = Color.Yellow;
			label1.Text = "Database Sucessfully Connected";
			SqlCommand cmd = new SqlCommand(query, con);
			int rows_count = Convert.ToInt32(cmd.ExecuteScalar());
			cmd.Dispose();
			con.Close();
			label3.ForeColor = Color.White;
			label3.Text = "هەڵەبجە = " + rows_count;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
		}
	}

	private void connctiond()
	{
		string str = "Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password;
		SqlConnection con = new SqlConnection(str);
		string query = "SELECT COUNT(ID) FROM dhok_hazb ";
		try
		{
			con.Open();
			label1.ForeColor = Color.Yellow;
			label1.Text = "Database Sucessfully Connected";
			SqlCommand cmd = new SqlCommand(query, con);
			int rows_count = Convert.ToInt32(cmd.ExecuteScalar());
			cmd.Dispose();
			con.Close();
			label5.ForeColor = Color.White;
			label5.Text = "دهۆک = " + rows_count;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
		}
	}

	private void connction_tybat()
	{
		string str = "Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password;
		SqlConnection con = new SqlConnection(str);
		string query = "SELECT COUNT(ID) FROM taybat_all ";
		try
		{
			con.Open();
			label1.ForeColor = Color.Yellow;
			label1.Text = "Database Sucessfully Connected";
			SqlCommand cmd = new SqlCommand(query, con);
			int rows_count = Convert.ToInt32(cmd.ExecuteScalar());
			cmd.Dispose();
			con.Close();
			lbl_tybat.ForeColor = Color.White;
			lbl_tybat.Text = "تایبەت = " + rows_count;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
		}
	}

	private void connctionsh()
	{
		string str = "Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password;
		SqlConnection con = new SqlConnection(str);
		string query = "SELECT COUNT(ID) FROM hawler_hazb ";
		try
		{
			con.Open();
			label1.ForeColor = Color.Yellow;
			label1.Text = "Database Sucessfully Connected";
			SqlCommand cmd = new SqlCommand(query, con);
			int rows_count = Convert.ToInt32(cmd.ExecuteScalar());
			cmd.Dispose();
			con.Close();
			label4.ForeColor = Color.White;
			label4.Text = "هەولێر = " + rows_count;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
		}
	}

	private void User_type()
	{
		if (lbluser.Text == "All")
		{
			addtaybat.Enabled = true;
			btnslemany.Enabled = true;
			btnhawler.Enabled = true;
			btnreport.Enabled = true;
			btnhalbja.Enabled = true;
			btndhok.Enabled = true;
		}
		if (lbluser.Text == "Halabja")
		{
			btnhalbja.Enabled = true;
		}
		if (lbluser.Text == "Slemany")
		{
			btnslemany.Enabled = true;
		}
		if (lbluser.Text == "Hawler")
		{
			btnhawler.Enabled = true;
		}
		if (lbluser.Text == "Taybat")
		{
			addtaybat.Enabled = true;
		}
		if (lbluser.Text == "Dhok")
		{
			btndhok.Enabled = true;
		}
	}

	private void btnslemany_Click(object sender, EventArgs e)
	{
	}

	private void btndhok_Click(object sender, EventArgs e)
	{
		OpenChildForm(new D_Gshty(), sender);
	}

	private void btnhalbja_Click(object sender, EventArgs e)
	{
		OpenChildForm(new HL_Gshty(), sender);
	}

	private void btndhok_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnhalbja_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnconn_MouseMove_1(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnreport_MouseMove_1(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnclose_MouseMove_1(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnrest_MouseMove_1(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnconn_Click_1(object sender, EventArgs e)
	{
		Connction co = new Connction();
		co.Visible = true;
		base.Visible = false;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		log_in lo = new log_in();
		lo.Visible = true;
		base.Visible = false;
	}

	private void btnlogin_MouseMove(object sender, MouseEventArgs e)
	{
		panelMenu.Size = new Size(220, 778);
		addtaybat.Text = "تایبه\u200cت";
		btnslemany.Text = "سلێمانی";
		btnclose.Text = "Exit_App";
		btnconn.Text = "Connction";
		btnhawler.Text = "هەولێر";
		btnlogin.Text = "Log_in";
		btnreport.Text = "Report";
		btnrest.Text = "Restart";
		btnhalbja.Text = "هەڵەبجە";
		btndhok.Text = "دهۆک";
	}

	private void btnrest_Click_1(object sender, EventArgs e)
	{
		Application.Restart();
	}

	private void button4_Click_1(object sender, EventArgs e)
	{
	}

	private void button5_Click(object sender, EventArgs e)
	{
		string fileName = txtFileName.Text + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
		string strQuery = "Backup Database nawa_anjamakan2024 to Disk='" + fileName + ".bak'";
		cmd = new SqlCommand(strQuery, con);
		con.Open();
		cmd.ExecuteNonQuery();
		con.Close();
		MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUK_Anjamakan.Frm.Home));
		this.panelMenu = new System.Windows.Forms.Panel();
		this.btnlogin = new System.Windows.Forms.Button();
		this.btnrest = new System.Windows.Forms.Button();
		this.btnclose = new System.Windows.Forms.Button();
		this.btnreport = new System.Windows.Forms.Button();
		this.btnconn = new System.Windows.Forms.Button();
		this.btnhalbja = new System.Windows.Forms.Button();
		this.btndhok = new System.Windows.Forms.Button();
		this.btnhawler = new System.Windows.Forms.Button();
		this.btnslemany = new System.Windows.Forms.Button();
		this.addtaybat = new System.Windows.Forms.Button();
		this.panelLogo = new System.Windows.Forms.Panel();
		this.panelTitleBar = new System.Windows.Forms.Panel();
		this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.lblTitle = new System.Windows.Forms.Label();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.btnCloseChildForm = new System.Windows.Forms.Button();
		this.panelDesktopPane = new System.Windows.Forms.Panel();
		this.txtFileName = new System.Windows.Forms.Label();
		this.button5 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.lbluser = new System.Windows.Forms.Label();
		this.lblsrial = new System.Windows.Forms.Label();
		this.lbldevice = new System.Windows.Forms.Label();
		this.lblshwen = new System.Windows.Forms.Label();
		this.lblkarmand = new System.Windows.Forms.Label();
		this.lbltaime = new System.Windows.Forms.Label();
		this.pnltaskbar = new System.Windows.Forms.Panel();
		this.lbl_tybat = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panelMenu.SuspendLayout();
		this.panelTitleBar.SuspendLayout();
		this.tableLayoutPanel1.SuspendLayout();
		this.panelDesktopPane.SuspendLayout();
		this.pnltaskbar.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.panelMenu.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
		this.panelMenu.Controls.Add(this.btnlogin);
		this.panelMenu.Controls.Add(this.btnrest);
		this.panelMenu.Controls.Add(this.btnclose);
		this.panelMenu.Controls.Add(this.btnreport);
		this.panelMenu.Controls.Add(this.btnconn);
		this.panelMenu.Controls.Add(this.btnhalbja);
		this.panelMenu.Controls.Add(this.btndhok);
		this.panelMenu.Controls.Add(this.btnhawler);
		this.panelMenu.Controls.Add(this.btnslemany);
		this.panelMenu.Controls.Add(this.addtaybat);
		this.panelMenu.Controls.Add(this.panelLogo);
		this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
		this.panelMenu.Location = new System.Drawing.Point(1140, 0);
		this.panelMenu.Name = "panelMenu";
		this.panelMenu.Size = new System.Drawing.Size(220, 778);
		this.panelMenu.TabIndex = 3;
		this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(panelMenu_MouseMove);
		this.btnlogin.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnlogin.FlatAppearance.BorderSize = 0;
		this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnlogin.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnlogin.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnlogin.Image = (System.Drawing.Image)resources.GetObject("btnlogin.Image");
		this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnlogin.Location = new System.Drawing.Point(0, 620);
		this.btnlogin.Name = "btnlogin";
		this.btnlogin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnlogin.Size = new System.Drawing.Size(220, 60);
		this.btnlogin.TabIndex = 10;
		this.btnlogin.Text = "Log_In";
		this.btnlogin.UseVisualStyleBackColor = true;
		this.btnlogin.Click += new System.EventHandler(button4_Click);
		this.btnlogin.MouseMove += new System.Windows.Forms.MouseEventHandler(btnlogin_MouseMove);
		this.btnrest.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnrest.FlatAppearance.BorderSize = 0;
		this.btnrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnrest.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnrest.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnrest.Image = (System.Drawing.Image)resources.GetObject("btnrest.Image");
		this.btnrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnrest.Location = new System.Drawing.Point(0, 560);
		this.btnrest.Name = "btnrest";
		this.btnrest.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnrest.Size = new System.Drawing.Size(220, 60);
		this.btnrest.TabIndex = 8;
		this.btnrest.Text = "Restart";
		this.btnrest.UseVisualStyleBackColor = true;
		this.btnrest.Click += new System.EventHandler(btnrest_Click_1);
		this.btnrest.MouseMove += new System.Windows.Forms.MouseEventHandler(btnrest_MouseMove_1);
		this.btnclose.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnclose.FlatAppearance.BorderSize = 0;
		this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnclose.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnclose.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnclose.Image = (System.Drawing.Image)resources.GetObject("btnclose.Image");
		this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnclose.Location = new System.Drawing.Point(0, 500);
		this.btnclose.Name = "btnclose";
		this.btnclose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnclose.Size = new System.Drawing.Size(220, 60);
		this.btnclose.TabIndex = 9;
		this.btnclose.Text = "Exit_App";
		this.btnclose.UseVisualStyleBackColor = true;
		this.btnclose.MouseMove += new System.Windows.Forms.MouseEventHandler(btnclose_MouseMove_1);
		this.btnreport.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnreport.FlatAppearance.BorderSize = 0;
		this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnreport.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnreport.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnreport.Image = (System.Drawing.Image)resources.GetObject("btnreport.Image");
		this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnreport.Location = new System.Drawing.Point(0, 440);
		this.btnreport.Name = "btnreport";
		this.btnreport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnreport.Size = new System.Drawing.Size(220, 60);
		this.btnreport.TabIndex = 1;
		this.btnreport.Text = "Report";
		this.btnreport.UseVisualStyleBackColor = true;
		this.btnreport.Click += new System.EventHandler(btnslemany_Click);
		this.btnreport.MouseMove += new System.Windows.Forms.MouseEventHandler(btnreport_MouseMove_1);
		this.btnconn.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnconn.FlatAppearance.BorderSize = 0;
		this.btnconn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnconn.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnconn.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnconn.Image = (System.Drawing.Image)resources.GetObject("btnconn.Image");
		this.btnconn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnconn.Location = new System.Drawing.Point(0, 380);
		this.btnconn.Name = "btnconn";
		this.btnconn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnconn.Size = new System.Drawing.Size(220, 60);
		this.btnconn.TabIndex = 2;
		this.btnconn.Text = "  Connction";
		this.btnconn.UseVisualStyleBackColor = true;
		this.btnconn.Click += new System.EventHandler(btnconn_Click_1);
		this.btnconn.MouseMove += new System.Windows.Forms.MouseEventHandler(btnconn_MouseMove_1);
		this.btnhalbja.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnhalbja.FlatAppearance.BorderSize = 0;
		this.btnhalbja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnhalbja.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnhalbja.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnhalbja.Image = (System.Drawing.Image)resources.GetObject("btnhalbja.Image");
		this.btnhalbja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnhalbja.Location = new System.Drawing.Point(0, 320);
		this.btnhalbja.Name = "btnhalbja";
		this.btnhalbja.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnhalbja.Size = new System.Drawing.Size(220, 60);
		this.btnhalbja.TabIndex = 4;
		this.btnhalbja.Text = "هه\u200cڵه\u200cبجه\u200c";
		this.btnhalbja.UseVisualStyleBackColor = true;
		this.btnhalbja.Click += new System.EventHandler(btnhalbja_Click);
		this.btnhalbja.MouseMove += new System.Windows.Forms.MouseEventHandler(btnhalbja_MouseMove);
		this.btndhok.Dock = System.Windows.Forms.DockStyle.Top;
		this.btndhok.FlatAppearance.BorderSize = 0;
		this.btndhok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btndhok.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btndhok.ForeColor = System.Drawing.Color.Gainsboro;
		this.btndhok.Image = (System.Drawing.Image)resources.GetObject("btndhok.Image");
		this.btndhok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btndhok.Location = new System.Drawing.Point(0, 260);
		this.btndhok.Name = "btndhok";
		this.btndhok.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btndhok.Size = new System.Drawing.Size(220, 60);
		this.btndhok.TabIndex = 3;
		this.btndhok.Text = "دهۆك";
		this.btndhok.UseVisualStyleBackColor = true;
		this.btndhok.Click += new System.EventHandler(btndhok_Click);
		this.btndhok.MouseMove += new System.Windows.Forms.MouseEventHandler(btndhok_MouseMove);
		this.btnhawler.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnhawler.FlatAppearance.BorderSize = 0;
		this.btnhawler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnhawler.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold);
		this.btnhawler.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnhawler.Image = (System.Drawing.Image)resources.GetObject("btnhawler.Image");
		this.btnhawler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnhawler.Location = new System.Drawing.Point(0, 200);
		this.btnhawler.Name = "btnhawler";
		this.btnhawler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnhawler.Size = new System.Drawing.Size(220, 60);
		this.btnhawler.TabIndex = 5;
		this.btnhawler.Text = "هەولێر";
		this.btnhawler.UseVisualStyleBackColor = true;
		this.btnhawler.Click += new System.EventHandler(btnconn_Click);
		this.btnhawler.MouseMove += new System.Windows.Forms.MouseEventHandler(btnconn_MouseMove);
		this.btnslemany.Dock = System.Windows.Forms.DockStyle.Top;
		this.btnslemany.FlatAppearance.BorderSize = 0;
		this.btnslemany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnslemany.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold);
		this.btnslemany.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnslemany.Image = (System.Drawing.Image)resources.GetObject("btnslemany.Image");
		this.btnslemany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnslemany.Location = new System.Drawing.Point(0, 140);
		this.btnslemany.Name = "btnslemany";
		this.btnslemany.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnslemany.Size = new System.Drawing.Size(220, 60);
		this.btnslemany.TabIndex = 6;
		this.btnslemany.Text = "سلێمانی";
		this.btnslemany.UseVisualStyleBackColor = true;
		this.btnslemany.Click += new System.EventHandler(btnreport_Click);
		this.btnslemany.MouseMove += new System.Windows.Forms.MouseEventHandler(btnreport_MouseMove);
		this.addtaybat.Dock = System.Windows.Forms.DockStyle.Top;
		this.addtaybat.FlatAppearance.BorderSize = 0;
		this.addtaybat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.addtaybat.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.addtaybat.ForeColor = System.Drawing.Color.Gainsboro;
		this.addtaybat.Image = (System.Drawing.Image)resources.GetObject("addtaybat.Image");
		this.addtaybat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.addtaybat.Location = new System.Drawing.Point(0, 80);
		this.addtaybat.Name = "addtaybat";
		this.addtaybat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.addtaybat.Size = new System.Drawing.Size(220, 60);
		this.addtaybat.TabIndex = 0;
		this.addtaybat.Text = "تایبه\u200cت";
		this.addtaybat.UseVisualStyleBackColor = true;
		this.addtaybat.Click += new System.EventHandler(btnadd_gshty_Click);
		this.addtaybat.MouseMove += new System.Windows.Forms.MouseEventHandler(btnadd_gshty_MouseMove);
		this.panelLogo.BackColor = System.Drawing.Color.FromArgb(38, 38, 58);
		this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
		this.panelLogo.Location = new System.Drawing.Point(0, 0);
		this.panelLogo.Name = "panelLogo";
		this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.panelLogo.Size = new System.Drawing.Size(220, 80);
		this.panelLogo.TabIndex = 1;
		this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(panelLogo_MouseDown);
		this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(panelLogo_MouseMove);
		this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
		this.panelTitleBar.Controls.Add(this.tableLayoutPanel1);
		this.panelTitleBar.Controls.Add(this.button2);
		this.panelTitleBar.Controls.Add(this.button1);
		this.panelTitleBar.Controls.Add(this.button3);
		this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
		this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
		this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
		this.panelTitleBar.Name = "panelTitleBar";
		this.panelTitleBar.Size = new System.Drawing.Size(1140, 80);
		this.panelTitleBar.TabIndex = 4;
		this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(panelTitleBar_MouseDown);
		this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(panelTitleBar_MouseMove);
		this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.tableLayoutPanel1.ColumnCount = 1;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
		this.tableLayoutPanel1.Location = new System.Drawing.Point(279, 7);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 1;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 66);
		this.tableLayoutPanel1.TabIndex = 14;
		this.lblTitle.AutoSize = true;
		this.lblTitle.BackColor = System.Drawing.Color.Transparent;
		this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.lblTitle.Location = new System.Drawing.Point(3, 0);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(658, 66);
		this.lblTitle.TabIndex = 0;
		this.lblTitle.Text = "HOME";
		this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button2.BackColor = System.Drawing.Color.Transparent;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.Gainsboro;
		this.button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button2.Location = new System.Drawing.Point(110, 8);
		this.button2.Name = "button2";
		this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.button2.Size = new System.Drawing.Size(31, 30);
		this.button2.TabIndex = 13;
		this.button2.Text = " ";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.BackColor = System.Drawing.Color.Transparent;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.Gainsboro;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button1.Location = new System.Drawing.Point(57, 3);
		this.button1.Name = "button1";
		this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.button1.Size = new System.Drawing.Size(37, 39);
		this.button1.TabIndex = 12;
		this.button1.Text = " ";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click_1);
		this.button3.BackColor = System.Drawing.Color.Transparent;
		this.button3.FlatAppearance.BorderSize = 0;
		this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button3.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.ForeColor = System.Drawing.Color.Gainsboro;
		this.button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
		this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button3.Location = new System.Drawing.Point(10, 7);
		this.button3.Name = "button3";
		this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.button3.Size = new System.Drawing.Size(31, 30);
		this.button3.TabIndex = 11;
		this.button3.Text = " ";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.btnCloseChildForm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
		this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCloseChildForm.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCloseChildForm.ForeColor = System.Drawing.Color.Gainsboro;
		this.btnCloseChildForm.Image = (System.Drawing.Image)resources.GetObject("btnCloseChildForm.Image");
		this.btnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnCloseChildForm.Location = new System.Drawing.Point(1073, 19);
		this.btnCloseChildForm.Name = "btnCloseChildForm";
		this.btnCloseChildForm.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
		this.btnCloseChildForm.Size = new System.Drawing.Size(41, 46);
		this.btnCloseChildForm.TabIndex = 8;
		this.btnCloseChildForm.Text = " ";
		this.btnCloseChildForm.UseVisualStyleBackColor = true;
		this.btnCloseChildForm.Click += new System.EventHandler(button1_Click);
		this.panelDesktopPane.BackColor = System.Drawing.Color.White;
		this.panelDesktopPane.Controls.Add(this.txtFileName);
		this.panelDesktopPane.Controls.Add(this.button5);
		this.panelDesktopPane.Controls.Add(this.button4);
		this.panelDesktopPane.Controls.Add(this.label7);
		this.panelDesktopPane.Controls.Add(this.label6);
		this.panelDesktopPane.Controls.Add(this.lbluser);
		this.panelDesktopPane.Controls.Add(this.lblsrial);
		this.panelDesktopPane.Controls.Add(this.lbldevice);
		this.panelDesktopPane.Controls.Add(this.lblshwen);
		this.panelDesktopPane.Controls.Add(this.lblkarmand);
		this.panelDesktopPane.Controls.Add(this.lbltaime);
		this.panelDesktopPane.Controls.Add(this.pnltaskbar);
		this.panelDesktopPane.Controls.Add(this.pictureBox1);
		this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelDesktopPane.Location = new System.Drawing.Point(0, 80);
		this.panelDesktopPane.Name = "panelDesktopPane";
		this.panelDesktopPane.Size = new System.Drawing.Size(1140, 698);
		this.panelDesktopPane.TabIndex = 5;
		this.panelDesktopPane.MouseMove += new System.Windows.Forms.MouseEventHandler(panelDesktopPane_MouseMove);
		this.txtFileName.AutoSize = true;
		this.txtFileName.Location = new System.Drawing.Point(27, 202);
		this.txtFileName.Name = "txtFileName";
		this.txtFileName.Size = new System.Drawing.Size(71, 17);
		this.txtFileName.TabIndex = 83;
		this.txtFileName.Text = "G:\\disctop";
		this.button5.Location = new System.Drawing.Point(214, 282);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(116, 50);
		this.button5.TabIndex = 82;
		this.button5.Text = "backup";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.button4.Location = new System.Drawing.Point(166, 420);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(116, 50);
		this.button4.TabIndex = 81;
		this.button4.Text = "backup";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click_1);
		this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Unikurd Roonak", 28.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(736, 20);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(355, 69);
		this.label7.TabIndex = 80;
		this.label7.Text = "مەکتەبی هەڵبژاردن";
		this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(451, 387);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(330, 62);
		this.label6.TabIndex = 79;
		this.label6.Text = "Nawa Vari";
		this.lbluser.AutoSize = true;
		this.lbluser.ForeColor = System.Drawing.Color.White;
		this.lbluser.Location = new System.Drawing.Point(221, 480);
		this.lbluser.Name = "lbluser";
		this.lbluser.Size = new System.Drawing.Size(42, 17);
		this.lbluser.TabIndex = 78;
		this.lbluser.Text = "label1";
		this.lblsrial.AutoSize = true;
		this.lblsrial.BackColor = System.Drawing.Color.White;
		this.lblsrial.ForeColor = System.Drawing.Color.White;
		this.lblsrial.Location = new System.Drawing.Point(183, 360);
		this.lblsrial.Name = "lblsrial";
		this.lblsrial.Size = new System.Drawing.Size(80, 17);
		this.lblsrial.TabIndex = 77;
		this.lblsrial.Text = "laptopname";
		this.lbldevice.AutoSize = true;
		this.lbldevice.BackColor = System.Drawing.Color.White;
		this.lbldevice.ForeColor = System.Drawing.Color.White;
		this.lbldevice.Location = new System.Drawing.Point(237, 252);
		this.lbldevice.Name = "lbldevice";
		this.lbldevice.Size = new System.Drawing.Size(80, 17);
		this.lbldevice.TabIndex = 76;
		this.lbldevice.Text = "laptopname";
		this.lblshwen.AutoSize = true;
		this.lblshwen.BackColor = System.Drawing.Color.White;
		this.lblshwen.ForeColor = System.Drawing.Color.White;
		this.lblshwen.Location = new System.Drawing.Point(618, 72);
		this.lblshwen.Name = "lblshwen";
		this.lblshwen.Size = new System.Drawing.Size(44, 17);
		this.lblshwen.TabIndex = 75;
		this.lblshwen.Text = "kirkuk";
		this.lblkarmand.AutoSize = true;
		this.lblkarmand.BackColor = System.Drawing.Color.White;
		this.lblkarmand.ForeColor = System.Drawing.Color.White;
		this.lblkarmand.Location = new System.Drawing.Point(475, 120);
		this.lblkarmand.Name = "lblkarmand";
		this.lblkarmand.Size = new System.Drawing.Size(40, 17);
		this.lblkarmand.TabIndex = 74;
		this.lblkarmand.Text = "nawa";
		this.lbltaime.AutoSize = true;
		this.lbltaime.BackColor = System.Drawing.Color.White;
		this.lbltaime.ForeColor = System.Drawing.Color.White;
		this.lbltaime.Location = new System.Drawing.Point(378, 60);
		this.lbltaime.Name = "lbltaime";
		this.lbltaime.Size = new System.Drawing.Size(42, 17);
		this.lbltaime.TabIndex = 73;
		this.lbltaime.Text = "label1";
		this.pnltaskbar.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
		this.pnltaskbar.Controls.Add(this.lbl_tybat);
		this.pnltaskbar.Controls.Add(this.label5);
		this.pnltaskbar.Controls.Add(this.label4);
		this.pnltaskbar.Controls.Add(this.label3);
		this.pnltaskbar.Controls.Add(this.label2);
		this.pnltaskbar.Controls.Add(this.label1);
		this.pnltaskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.pnltaskbar.Location = new System.Drawing.Point(0, 645);
		this.pnltaskbar.Name = "pnltaskbar";
		this.pnltaskbar.Size = new System.Drawing.Size(1140, 53);
		this.pnltaskbar.TabIndex = 72;
		this.lbl_tybat.AutoSize = true;
		this.lbl_tybat.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_tybat.Location = new System.Drawing.Point(1009, 12);
		this.lbl_tybat.Name = "lbl_tybat";
		this.lbl_tybat.Size = new System.Drawing.Size(65, 29);
		this.lbl_tybat.TabIndex = 0;
		this.lbl_tybat.Text = "label1";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.Location = new System.Drawing.Point(835, 12);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(65, 29);
		this.label5.TabIndex = 0;
		this.label5.Text = "label1";
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(697, 12);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(65, 29);
		this.label4.TabIndex = 0;
		this.label4.Text = "label1";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(516, 12);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(65, 29);
		this.label3.TabIndex = 0;
		this.label3.Text = "label1";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(348, 12);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(65, 29);
		this.label2.TabIndex = 0;
		this.label2.Text = "label1";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(12, 12);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(65, 29);
		this.label1.TabIndex = 0;
		this.label1.Text = "label1";
		this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(417, 106);
		this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(388, 271);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 71;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1360, 778);
		base.Controls.Add(this.panelDesktopPane);
		base.Controls.Add(this.panelTitleBar);
		base.Controls.Add(this.panelMenu);
		this.MinimumSize = new System.Drawing.Size(950, 500);
		base.Name = "Home";
		this.Text = "Home";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.Load += new System.EventHandler(Home_Load);
		this.panelMenu.ResumeLayout(false);
		this.panelTitleBar.ResumeLayout(false);
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.panelDesktopPane.ResumeLayout(false);
		this.panelDesktopPane.PerformLayout();
		this.pnltaskbar.ResumeLayout(false);
		this.pnltaskbar.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
