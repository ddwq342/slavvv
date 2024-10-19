using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PUK_Anjamakan.CND;
using PUK_Anjamakan.DAL;
using PUK_Anjamakan.Properties;

namespace PUK_Anjamakan.Frm;

public class TEST : Form
{
	private SqlConnection connectionString = new SqlConnection("Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password);

	private CLS_PRODUCTS log = new CLS_PRODUCTS();

	private DataTable dt = new DataTable();

	private Home fr = new Home();

	private IContainer components = null;

	private Button btnsearch;

	private TableLayoutPanel tableLayoutPanel1;

	private Label label1;

	private Label label8;

	private Label label9;

	private Label label10;

	private Label label6;

	private Label label2;

	private Label label3;

	private Label label7;

	private Label label11;

	private TableLayoutPanel bnltablsearch;

	private Button btnadd;

	private TextBox txtwaraqadrost;

	private TextBox txtwaraqaybatl;

	private Label label4;

	private Label label5;

	public TextBox txtmalband;

	public TextBox txtparezga;

	public TextBox txtcoodtasj;

	public TextBox txtnawtasj;

	public TextBox txtnawbnka;

	public TextBox txtwestga;

	public TextBox txtzhdangdar;

	public TextBox txtbnkacood;

	public Guna2ComboBox comwestga;

	private Button btn_candid_h;

	private Panel panel1;

	private TextBox txt_total_h;

	private TableLayoutPanel tableLayoutPanel3;

	private Button btn_candid_hl;

	private TextBox txt_total_hl;

	private TextBox txt_total_d;

	private Button btn_candid_s;

	private Button btn_candid_d;

	private TextBox txt_total_s;

	private Button button5;

	private Label label49;

	private TableLayoutPanel tableLayoutPanel7;

	private TextBox h235;

	private TextBox h178;

	private TextBox h234;

	private TextBox h170;

	private TextBox h233;

	private Label label297;

	private TextBox h229;

	private TextBox h176;

	private Label label293;

	private Label label315;

	private TextBox h173;

	private TextBox h169;

	private Label label289;

	private Label label323;

	private Label label285;

	private TextBox h223;

	private TextBox h220;

	private Label label311;

	private Label label319;

	private TextBox h167;

	private TextBox h219;

	private TextBox h164;

	private TextBox h217;

	private Label label281;

	private TextBox h162;

	private Label label277;

	private Label label307;

	private TextBox h161;

	private TextBox h160;

	private Label label269;

	private Label label303;

	private Label label299;

	private TextBox h158;

	private Label label295;

	private TextBox h151;

	private TextBox h150;

	private TextBox h154;

	private TextBox h149;

	private Label label291;

	private TextBox h157;

	private TextBox h156;

	private TextBox h148;

	private TextBox h147;

	private TextBox h146;

	private TextBox h144;

	private Label label287;

	private TextBox h139;

	private TextBox h133;

	private TextBox h131;

	private Label label267;

	private Label label263;

	private Label label283;

	private Label label259;

	private Label label255;

	private Label label279;

	private Label label251;

	private Label label247;

	private Label label69;

	private Label label275;

	private Label label72;

	private Label label76;

	private Label label80;

	private Label label271;

	private Label label399;

	private Label label395;

	private Label label391;

	private TextBox s161;

	private Label label387;

	private TextBox s157;

	private TextBox s153;

	private TextBox s148;

	private TextBox s147;

	private TextBox s145;

	private TextBox s138;

	private TextBox s137;

	private Label label383;

	private Label label379;

	private Label label375;

	private TextBox d211;

	private TextBox d200;

	private TextBox d197;

	private TextBox d196;

	private TextBox d195;

	private TextBox d190;

	private Label label213;

	private Label label209;

	private Label label205;

	private Label label201;

	private Label label197;

	private Label label193;

	private Label label157;

	private Label label153;

	private Label label12;

	private TextBox h102;

	private TextBox hl147;

	private TextBox hl172;

	private TextBox hl133;

	private Label label114;

	private Label label99;

	private TextBox hl129;

	private TextBox hl169;

	private Label label15;

	private TextBox d161;

	private Label label112;

	private TextBox hl123;

	private TextBox d159;

	private Label label97;

	private TextBox s101;

	private Label label109;

	private TextBox hl114;

	private Label label95;

	private TextBox hl162;

	private Label label107;

	private Label label50;

	private TextBox d107;

	private Label label92;

	private TextBox hl161;

	private Label label105;

	private TextBox d148;

	private TextBox d147;

	private TextBox d143;

	private TextBox d142;

	private TextBox d141;

	private TextBox d140;

	private TextBox d134;

	private TextBox d133;

	private Label label60;

	private TextBox s136;

	private Label label117;

	private Label label129;

	private Label label125;

	private Label label121;

	private Label label113;

	private TextBox s135;

	private Label label371;

	private Label label90;

	private Label label19;

	private TextBox h103;

	private TextBox d126;

	private Label label18;

	private TextBox s104;

	private Label label52;

	private TextBox d108;

	private TextBox d118;

	private Label label23;

	private TextBox h105;

	private TextBox s114;

	private TextBox d114;

	private Label label22;

	private TextBox s110;

	private Label label54;

	private TextBox s113;

	private TextBox hl164;

	private Label label27;

	private TextBox h106;

	private Label label58;

	private Label label26;

	private Label label56;

	private Label label31;

	private TextBox h109;

	private Label label30;

	private Label label35;

	private TextBox h111;

	private TextBox h112;

	private TextBox h114;

	private Label label39;

	private Label label43;

	private Label label34;

	private Label label38;

	private Label label42;

	private Label label46;

	private Label label48;

	private Label label73;

	private TextBox s115;

	private TextBox s116;

	private TextBox s117;

	private TextBox s119;

	private TextBox s121;

	private TextBox s122;

	private Label label101;

	private Label label103;

	private TextBox hl148;

	private TextBox hl157;

	private Label label120;

	private Label label124;

	private TextBox hl190;

	private TextBox hl198;

	private TextBox d127;

	private TextBox d129;

	private TextBox d132;

	private Label label66;

	private Label label65;

	private Label label62;

	private Label label47;

	private Label label88;

	private Label label84;

	private TextBox h120;

	private TextBox h123;

	private TextBox h129;

	private Label label77;

	private Label label81;

	private Label label85;

	private Label label89;

	private Label label355;

	private Label label359;

	private Label label363;

	private TextBox s123;

	private TextBox s124;

	private TextBox s125;

	private TextBox s128;

	private TextBox s129;

	private TextBox s130;

	private TextBox s133;

	private Label label367;

	private Label label133;

	private Label label137;

	private Label label141;

	private Label label145;

	private Label label149;

	private TextBox d152;

	private TextBox d155;

	private TextBox d157;

	private Label label161;

	private TextBox d162;

	private Label label165;

	private TextBox d163;

	private Label label169;

	private TextBox d164;

	private Label label173;

	private TextBox d169;

	private Label label177;

	private TextBox d175;

	private Label label181;

	private TextBox d177;

	private Label label185;

	private TextBox d186;

	private Label label189;

	private TextBox d188;

	private Label label91;

	private TextBox d213;

	private Label label94;

	private Label label53;

	private Label label55;

	private Label label57;

	private Label label64;

	private TextBox d222;

	private TextBox d224;

	private TextBox d225;

	private TextBox d227;

	private TextBox d232;

	private Label label403;

	private Label label14;

	private Label label17;

	private Label label21;

	private Label label25;

	private Label label29;

	private Label label33;

	private TextBox h179;

	private TextBox h181;

	private TextBox h184;

	private TextBox h187;

	private TextBox h189;

	private TextBox h190;

	private Label label37;

	private Label label41;

	private Label label45;

	private Label label86;

	private Label label82;

	private Label label78;

	private Label label74;

	private TextBox h191;

	private TextBox h198;

	private TextBox h199;

	private TextBox h202;

	private TextBox h203;

	private TextBox h204;

	private TextBox h205;

	private Label label70;

	private Label label67;

	private Label label245;

	private Label label249;

	private Label label253;

	private Label label257;

	private Label label261;

	private Label label265;

	private TextBox h206;

	private TextBox h208;

	private TextBox h209;

	private TextBox h210;

	private TextBox h212;

	private TextBox h214;

	private TextBox h215;

	private TextBox h216;

	private Label label273;

	private Label label357;

	private TextBox s230;

	private Label label353;

	private TextBox s228;

	private Label label87;

	private TextBox s226;

	private Label label83;

	private TextBox s221;

	private Label label79;

	private TextBox s218;

	private Label label75;

	private TextBox s207;

	private TextBox s201;

	private Label label71;

	private Label label68;

	private TextBox s198;

	private TextBox s194;

	private Label label44;

	private Label label40;

	private TextBox s193;

	private Label label36;

	private TextBox s192;

	private Label label32;

	private TextBox s190;

	private TextBox s185;

	private TextBox s183;

	private TextBox s182;

	private Label label28;

	private Label label24;

	private Label label20;

	private Label label16;

	private TextBox s180;

	private Label label13;

	private TextBox s174;

	private Label label431;

	private TextBox s171;

	private Label label427;

	private TextBox s169;

	private Label label423;

	private TextBox s168;

	private Label label361;

	private TextBox s231;

	private TextBox s236;

	private Label label365;

	private Label label419;

	private TextBox s166;

	private Label label415;

	private TextBox s165;

	private Label label411;

	private TextBox s164;

	private Label label407;

	private TextBox s162;

	private Label labljorydangdan;

	private Label lbl_taswit;

	public TEST()
	{
		InitializeComponent();
		txtcoler();
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

	private void pnalrgp()
	{
	}

	private void totals()
	{
		try
		{
			double To1 = (double)int.Parse(s101.Text) + Convert.ToDouble(s104.Text) + Convert.ToDouble(s110.Text) + Convert.ToDouble(s113.Text) + Convert.ToDouble(s114.Text) + Convert.ToDouble(s115.Text) + Convert.ToDouble(s116.Text) + Convert.ToDouble(s117.Text) + Convert.ToDouble(s119.Text) + Convert.ToDouble(s121.Text) + Convert.ToDouble(s122.Text) + Convert.ToDouble(s123.Text) + Convert.ToDouble(s124.Text) + Convert.ToDouble(s125.Text) + Convert.ToDouble(s128.Text) + Convert.ToDouble(s129.Text) + Convert.ToDouble(s130.Text) + Convert.ToDouble(s133.Text) + Convert.ToDouble(s135.Text) + Convert.ToDouble(s136.Text) + Convert.ToDouble(s137.Text) + Convert.ToDouble(s138.Text) + Convert.ToDouble(s145.Text) + Convert.ToDouble(s147.Text) + Convert.ToDouble(s148.Text) + Convert.ToDouble(s153.Text) + Convert.ToDouble(s157.Text) + Convert.ToDouble(s161.Text) + Convert.ToDouble(s162.Text) + Convert.ToDouble(s164.Text) + Convert.ToDouble(s165.Text) + Convert.ToDouble(s166.Text) + Convert.ToDouble(s168.Text) + Convert.ToDouble(s169.Text) + Convert.ToDouble(s171.Text) + Convert.ToDouble(s174.Text) + Convert.ToDouble(s180.Text) + Convert.ToDouble(s182.Text) + Convert.ToDouble(s183.Text) + Convert.ToDouble(s185.Text) + Convert.ToDouble(s190.Text) + Convert.ToDouble(s192.Text) + Convert.ToDouble(s193.Text) + Convert.ToDouble(s194.Text) + Convert.ToDouble(s198.Text) + Convert.ToDouble(s201.Text) + Convert.ToDouble(s207.Text) + Convert.ToDouble(s218.Text) + Convert.ToDouble(s221.Text) + Convert.ToDouble(s226.Text) + Convert.ToDouble(s228.Text) + Convert.ToDouble(s230.Text) + Convert.ToDouble(s231.Text) + Convert.ToDouble(s236.Text);
			double To2 = (double)int.Parse(h102.Text) + Convert.ToDouble(h103.Text) + Convert.ToDouble(h105.Text) + Convert.ToDouble(h106.Text) + Convert.ToDouble(h109.Text) + Convert.ToDouble(h111.Text) + Convert.ToDouble(h112.Text) + Convert.ToDouble(h114.Text) + Convert.ToDouble(h120.Text) + Convert.ToDouble(h123.Text) + Convert.ToDouble(h129.Text) + Convert.ToDouble(h131.Text) + Convert.ToDouble(h133.Text) + Convert.ToDouble(h139.Text) + Convert.ToDouble(h144.Text) + Convert.ToDouble(h146.Text) + Convert.ToDouble(h147.Text) + Convert.ToDouble(h148.Text) + Convert.ToDouble(h149.Text) + Convert.ToDouble(h150.Text) + Convert.ToDouble(h151.Text) + Convert.ToDouble(h154.Text) + Convert.ToDouble(h156.Text) + Convert.ToDouble(h157.Text) + Convert.ToDouble(h158.Text) + Convert.ToDouble(h160.Text) + Convert.ToDouble(h161.Text) + Convert.ToDouble(h162.Text) + Convert.ToDouble(h164.Text) + Convert.ToDouble(h167.Text) + Convert.ToDouble(h169.Text) + Convert.ToDouble(h170.Text) + Convert.ToDouble(h173.Text) + Convert.ToDouble(h176.Text) + Convert.ToDouble(h178.Text) + Convert.ToDouble(h179.Text) + Convert.ToDouble(h181.Text) + Convert.ToDouble(h184.Text) + Convert.ToDouble(h187.Text) + Convert.ToDouble(h189.Text) + Convert.ToDouble(h190.Text) + Convert.ToDouble(h191.Text) + Convert.ToDouble(h198.Text) + Convert.ToDouble(h199.Text) + Convert.ToDouble(h202.Text) + Convert.ToDouble(h203.Text) + Convert.ToDouble(h204.Text) + Convert.ToDouble(h205.Text) + Convert.ToDouble(h206.Text) + Convert.ToDouble(h208.Text) + Convert.ToDouble(h209.Text) + Convert.ToDouble(h210.Text) + Convert.ToDouble(h212.Text) + Convert.ToDouble(h214.Text) + Convert.ToDouble(h215.Text) + Convert.ToDouble(h216.Text) + Convert.ToDouble(h217.Text) + Convert.ToDouble(h219.Text) + Convert.ToDouble(h220.Text) + Convert.ToDouble(h223.Text) + Convert.ToDouble(h229.Text) + Convert.ToDouble(h233.Text) + Convert.ToDouble(h234.Text) + Convert.ToDouble(h235.Text);
			double To3 = (double)int.Parse(d107.Text) + Convert.ToDouble(d108.Text) + Convert.ToDouble(d114.Text) + Convert.ToDouble(d118.Text) + Convert.ToDouble(d126.Text) + Convert.ToDouble(d127.Text) + Convert.ToDouble(d129.Text) + Convert.ToDouble(d132.Text) + Convert.ToDouble(d133.Text) + Convert.ToDouble(d134.Text) + Convert.ToDouble(d140.Text) + Convert.ToDouble(d141.Text) + Convert.ToDouble(d142.Text) + Convert.ToDouble(d143.Text) + Convert.ToDouble(d147.Text) + Convert.ToDouble(d148.Text) + Convert.ToDouble(d152.Text) + Convert.ToDouble(d155.Text) + Convert.ToDouble(d157.Text) + Convert.ToDouble(d159.Text) + Convert.ToDouble(d161.Text) + Convert.ToDouble(d162.Text) + Convert.ToDouble(d163.Text) + Convert.ToDouble(d164.Text) + Convert.ToDouble(d169.Text) + Convert.ToDouble(d175.Text) + Convert.ToDouble(d177.Text) + Convert.ToDouble(d186.Text) + Convert.ToDouble(d188.Text) + Convert.ToDouble(d190.Text) + Convert.ToDouble(d195.Text) + Convert.ToDouble(d196.Text) + Convert.ToDouble(d197.Text) + Convert.ToDouble(d200.Text) + Convert.ToDouble(d211.Text) + Convert.ToDouble(d213.Text) + Convert.ToDouble(d222.Text) + Convert.ToDouble(d224.Text) + Convert.ToDouble(d225.Text) + Convert.ToDouble(d227.Text) + Convert.ToDouble(d232.Text);
			double To4 = (double)int.Parse(hl114.Text) + Convert.ToDouble(hl123.Text) + Convert.ToDouble(hl129.Text) + Convert.ToDouble(hl133.Text) + Convert.ToDouble(hl147.Text) + Convert.ToDouble(hl148.Text) + Convert.ToDouble(hl157.Text) + Convert.ToDouble(hl161.Text) + Convert.ToDouble(hl162.Text) + Convert.ToDouble(hl164.Text) + Convert.ToDouble(hl169.Text) + Convert.ToDouble(hl172.Text) + Convert.ToDouble(hl190.Text) + Convert.ToDouble(hl198.Text);
			txt_total_s.Text = To1.ToString();
			txt_total_h.Text = To2.ToString();
			txt_total_d.Text = To3.ToString();
			txt_total_hl.Text = To4.ToString();
		}
		catch
		{
		}
	}

	private void add_Gshty_Load(object sender, EventArgs e)
	{
		lbl_taswit.Text = Settings.Default.MALBAND;
		LoadTheme();
		LoadTheme();
		all_txt0();
		txtcoler();
	}

	private void total_s_Click(object sender, EventArgs e)
	{
	}

	private void comboxvalue()
	{
		comwestga.Items.Clear();
		if (txtwestga.Text == "7")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
		}
		if (txtwestga.Text == "1")
		{
			comwestga.Items.Add("1");
		}
		if (txtwestga.Text == "2")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
		}
		if (txtwestga.Text == "3")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
		}
		if (txtwestga.Text == "4")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
		}
		if (txtwestga.Text == "5")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
		}
		if (txtwestga.Text == "6")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
		}
		if (txtwestga.Text == "8")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
		}
		if (txtwestga.Text == "9")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
		}
		if (txtwestga.Text == "10")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
			comwestga.Items.Add("10");
		}
		if (txtwestga.Text == "11")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
			comwestga.Items.Add("10");
			comwestga.Items.Add("11");
		}
		if (txtwestga.Text == "12")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
			comwestga.Items.Add("10");
			comwestga.Items.Add("11");
			comwestga.Items.Add("12");
		}
		if (txtwestga.Text == "13")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
			comwestga.Items.Add("10");
			comwestga.Items.Add("11");
			comwestga.Items.Add("13");
		}
		if (txtwestga.Text == "14")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
			comwestga.Items.Add("10");
			comwestga.Items.Add("11");
			comwestga.Items.Add("13");
			comwestga.Items.Add("14");
		}
		if (txtwestga.Text == "15")
		{
			comwestga.Items.Add("1");
			comwestga.Items.Add("2");
			comwestga.Items.Add("3");
			comwestga.Items.Add("4");
			comwestga.Items.Add("5");
			comwestga.Items.Add("6");
			comwestga.Items.Add("7");
			comwestga.Items.Add("8");
			comwestga.Items.Add("9");
			comwestga.Items.Add("10");
			comwestga.Items.Add("11");
			comwestga.Items.Add("13");
			comwestga.Items.Add("14");
			comwestga.Items.Add("15");
		}
	}

	private void btnsearch_Click(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty)
		{
			MessageBox.Show("ئەم ژمارە دەنگدەرە لەم پارێزگایە نیە یان هەڵەیە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		string query = "SELECT *\r\n                         FROM intshar \r\n                         WHERE cood_bnka = " + txtbnkacood.Text + " and User_Password = " + lbl_taswit.Text;
		SqlCommand command = new SqlCommand(query, connectionString);
		connectionString.Open();
		using (SqlDataReader reader = command.ExecuteReader())
		{
			if (reader.Read())
			{
				txtparezga.Text = reader["naw_mahafaza"].ToString();
				txtmalband.Text = reader["malband"].ToString();
				txtcoodtasj.Text = reader["cood_tasjil"].ToString();
				txtnawtasj.Text = reader["naw_tasjil"].ToString();
				txtnawbnka.Text = reader["naw_bnka"].ToString();
				txtwestga.Text = reader["westga"].ToString();
				txtzhdangdar.Text = reader["dangdar"].ToString();
				labljorydangdan.Text = reader["jory_dangdan"].ToString();
			}
			comboxvalue();
			connectionString.Close();
		}
		if (txtcoodtasj.Text == string.Empty)
		{
			MessageBox.Show("ئەم ژمارەی بنکەی دەنگدانە  هەڵەیە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void add_selemany_tybat()
	{
		string qurey = "insert into slemany_tyabat(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal,[101],\t[104],\t[110],\t[113],\t[114],\t[115],\t[116],\t[117],\t[119],\t[121],\t[122],\t[123],\t[124],\t[125],\t[128],\t[129],\t[130],\t[133],\t[135],\t[136],\t[137],\t[138],\t[145],\t[147],\t[148],\t[153],\t[157],\t[161],\t[162],\t[164],\t[165],\t[166],\t[168],\t[169],\t[171],\t[174],\t[180],\t[182],\t[183],\t[185],\t[190],\t[192],\t[193],\t[194],\t[198],\t[201],\t[207],\t[218],\t[221],\t[226],\t[228],\t[230],\t[231],\t[236])VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,@101,\t@104,\t@110,\t@113,\t@114,\t@115,\t@116,\t@117,\t@119,\t@121,\t@122,\t@123,\t@124,\t@125,\t@128,\t@129,\t@130,\t@133,\t@135,\t@136,\t@137,\t@138,\t@145,\t@147,\t@148,\t@153,\t@157,\t@161,\t@162,\t@164,\t@165,\t@166,\t@168,\t@169,\t@171,\t@174,\t@180,\t@182,\t@183,\t@185,\t@190,\t@192,\t@193,\t@194,\t@198,\t@201,\t@207,\t@218,\t@221,\t@226,\t@228,\t@230,\t@231,\t@236)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@malband", txtmalband.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@naw_tasjil", txtnawtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@naw_bnka", txtnawbnka.Text);
		cmd.Parameters.AddWithValue("@westga_gshty", txtwestga.Text);
		cmd.Parameters.AddWithValue("@dangdar", txtzhdangdar.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@101", s101.Text);
		cmd.Parameters.AddWithValue("@104", s104.Text);
		cmd.Parameters.AddWithValue("@110", s110.Text);
		cmd.Parameters.AddWithValue("@113", s113.Text);
		cmd.Parameters.AddWithValue("@114", s114.Text);
		cmd.Parameters.AddWithValue("@115", s115.Text);
		cmd.Parameters.AddWithValue("@116", s116.Text);
		cmd.Parameters.AddWithValue("@117", s117.Text);
		cmd.Parameters.AddWithValue("@119", s119.Text);
		cmd.Parameters.AddWithValue("@121", s121.Text);
		cmd.Parameters.AddWithValue("@122", s122.Text);
		cmd.Parameters.AddWithValue("@123", s123.Text);
		cmd.Parameters.AddWithValue("@124", s124.Text);
		cmd.Parameters.AddWithValue("@125", s125.Text);
		cmd.Parameters.AddWithValue("@128", s128.Text);
		cmd.Parameters.AddWithValue("@129", s129.Text);
		cmd.Parameters.AddWithValue("@130", s130.Text);
		cmd.Parameters.AddWithValue("@133", s133.Text);
		cmd.Parameters.AddWithValue("@135", s135.Text);
		cmd.Parameters.AddWithValue("@136", s136.Text);
		cmd.Parameters.AddWithValue("@137", s137.Text);
		cmd.Parameters.AddWithValue("@138", s138.Text);
		cmd.Parameters.AddWithValue("@145", s145.Text);
		cmd.Parameters.AddWithValue("@147", s147.Text);
		cmd.Parameters.AddWithValue("@148", s148.Text);
		cmd.Parameters.AddWithValue("@153", s153.Text);
		cmd.Parameters.AddWithValue("@157", s157.Text);
		cmd.Parameters.AddWithValue("@161", s161.Text);
		cmd.Parameters.AddWithValue("@162", s162.Text);
		cmd.Parameters.AddWithValue("@164", s164.Text);
		cmd.Parameters.AddWithValue("@165", s165.Text);
		cmd.Parameters.AddWithValue("@166", s166.Text);
		cmd.Parameters.AddWithValue("@168", s168.Text);
		cmd.Parameters.AddWithValue("@169", s169.Text);
		cmd.Parameters.AddWithValue("@171", s171.Text);
		cmd.Parameters.AddWithValue("@174", s174.Text);
		cmd.Parameters.AddWithValue("@180", s180.Text);
		cmd.Parameters.AddWithValue("@182", s182.Text);
		cmd.Parameters.AddWithValue("@183", s183.Text);
		cmd.Parameters.AddWithValue("@185", s185.Text);
		cmd.Parameters.AddWithValue("@190", s190.Text);
		cmd.Parameters.AddWithValue("@192", s192.Text);
		cmd.Parameters.AddWithValue("@193", s193.Text);
		cmd.Parameters.AddWithValue("@194", s194.Text);
		cmd.Parameters.AddWithValue("@198", s198.Text);
		cmd.Parameters.AddWithValue("@201", s201.Text);
		cmd.Parameters.AddWithValue("@207", s207.Text);
		cmd.Parameters.AddWithValue("@218", s218.Text);
		cmd.Parameters.AddWithValue("@221", s221.Text);
		cmd.Parameters.AddWithValue("@226", s226.Text);
		cmd.Parameters.AddWithValue("@228", s228.Text);
		cmd.Parameters.AddWithValue("@230", s230.Text);
		cmd.Parameters.AddWithValue("@231", s231.Text);
		cmd.Parameters.AddWithValue("@236", s236.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
	}

	private void add_dhok_tybat()
	{
		string qurey = "insert into dhok_taybat(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal,[107],\t[108],\t[114],\t[118],\t[126],\t[127],\t[129],\t[132],\t[133],\t[134],\t[140],\t[141],\t[142],\t[143],\t[147],\t[148],\t[152],\t[155],\t[157],\t[159],\t[161],\t[162],\t[163],\t[164],\t[169],\t[175],\t[177],\t[186],\t[188],\t[190],\t[195],\t[196],\t[197],\t[200],\t[211],\t[213],\t[222],\t[224],\t[225],\t[227],\t[232])VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,\t@107,\t@108,\t@114,\t@118,\t@126,\t@127,\t@129,\t@132,\t@133,\t@134,\t@140,\t@141,\t@142,\t@143,\t@147,\t@148,\t@152,\t@155,\t@157,\t@159,\t@161,\t@162,\t@163,\t@164,\t@169,\t@175,\t@177,\t@186,\t@188,\t@190,\t@195,\t@196,\t@197,\t@200,\t@211,\t@213,\t@222,\t@224,\t@225,\t@227,\t@232)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@malband", txtmalband.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@naw_tasjil", txtnawtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@naw_bnka", txtnawbnka.Text);
		cmd.Parameters.AddWithValue("@westga_gshty", txtwestga.Text);
		cmd.Parameters.AddWithValue("@dangdar", txtzhdangdar.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@107", d107.Text);
		cmd.Parameters.AddWithValue("@108", d108.Text);
		cmd.Parameters.AddWithValue("@114", d114.Text);
		cmd.Parameters.AddWithValue("@118", d118.Text);
		cmd.Parameters.AddWithValue("@126", d126.Text);
		cmd.Parameters.AddWithValue("@127", d127.Text);
		cmd.Parameters.AddWithValue("@129", d129.Text);
		cmd.Parameters.AddWithValue("@132", d132.Text);
		cmd.Parameters.AddWithValue("@133", d133.Text);
		cmd.Parameters.AddWithValue("@134", d134.Text);
		cmd.Parameters.AddWithValue("@140", d140.Text);
		cmd.Parameters.AddWithValue("@141", d141.Text);
		cmd.Parameters.AddWithValue("@142", d142.Text);
		cmd.Parameters.AddWithValue("@143", d143.Text);
		cmd.Parameters.AddWithValue("@147", d147.Text);
		cmd.Parameters.AddWithValue("@148", d148.Text);
		cmd.Parameters.AddWithValue("@152", d152.Text);
		cmd.Parameters.AddWithValue("@155", d155.Text);
		cmd.Parameters.AddWithValue("@157", d157.Text);
		cmd.Parameters.AddWithValue("@159", d159.Text);
		cmd.Parameters.AddWithValue("@161", d161.Text);
		cmd.Parameters.AddWithValue("@162", d162.Text);
		cmd.Parameters.AddWithValue("@163", d163.Text);
		cmd.Parameters.AddWithValue("@164", d164.Text);
		cmd.Parameters.AddWithValue("@169", d169.Text);
		cmd.Parameters.AddWithValue("@175", d175.Text);
		cmd.Parameters.AddWithValue("@177", d177.Text);
		cmd.Parameters.AddWithValue("@186", d186.Text);
		cmd.Parameters.AddWithValue("@188", d188.Text);
		cmd.Parameters.AddWithValue("@190", d190.Text);
		cmd.Parameters.AddWithValue("@195", d195.Text);
		cmd.Parameters.AddWithValue("@196", d196.Text);
		cmd.Parameters.AddWithValue("@197", d197.Text);
		cmd.Parameters.AddWithValue("@200", d200.Text);
		cmd.Parameters.AddWithValue("@211", d211.Text);
		cmd.Parameters.AddWithValue("@213", d213.Text);
		cmd.Parameters.AddWithValue("@222", d222.Text);
		cmd.Parameters.AddWithValue("@224", d224.Text);
		cmd.Parameters.AddWithValue("@225", d225.Text);
		cmd.Parameters.AddWithValue("@227", d227.Text);
		cmd.Parameters.AddWithValue("@232", d232.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
	}

	private void Update_taybat_all()
	{
		Home ho = new Home();
		string qurey = "Update taybat_all set [waraqa_rast]=@waraqa_rast,[waraqapochal]=@waraqapochal ,[s101]=@s101,\t[s104] =@s104, \t[s110] =@s110, \t[s113] =@s113, \t[s114] =@s114, \t[s115] =@s115, \t[s116] =@s116, \t[s117] =@s117, \t[s119] =@s119, \t[s121] =@s121, \t[s122] =@s122, \t[s123] =@s123, \t[s124] =@s124, \t[s125] =@s125, \t[s128] =@s128, \t[s129] =@s129, \t[s130] =@s130, \t[s133] =@s133, \t[s135] =@s135, \t[s136] =@s136, \t[s137] =@s137, \t[s138] =@s138, \t[s145] =@s145, \t[s147] =@s147, \t[s148] =@s148, \t[s153] =@s153, \t[s157] =@s157, \t[s161] =@s161, \t[s162] =@s162, \t[s164] =@s164, \t[s165] =@s165, \t[s166] =@s166, \t[s168] =@s168, \t[s169] =@s169, \t[s171] =@s171, \t[s174] =@s174, \t[s180] =@s180, \t[s182] =@s182, \t[s183] =@s183, \t[s185] =@s185, \t[s190] =@s190, \t[s192] =@s192, \t[s193] =@s193, \t[s194] =@s194, \t[s198] =@s198, \t[s201] =@s201, \t[s207] =@s207, \t[s218] =@s218, \t[s221] =@s221, \t[s226] =@s226, \t[s228] =@s228, \t[s230] =@s230, \t[s231] =@s231, \t[s236]  =@s236,  \t[h102]=@h102,\t[h103] =@h103, \t[h105] =@h105, \t[h106] =@h106, \t[h109] =@h109, \t[h111] =@h111, \t[h112] =@h112, \t[h114] =@h114, \t[h120] =@h120, \t[h123] =@h123, \t[h129] =@h129, \t[h131] =@h131, \t[h133] =@h133, \t[h139] =@h139, \t[h144] =@h144, \t[h146] =@h146, \t[h147] =@h147, \t[h148] =@h148, \t[h149] =@h149, \t[h150] =@h150, \t[h151] =@h151, \t[h154] =@h154, \t[h156] =@h156, \t[h157] =@h157, \t[h158] =@h158, \t[h160] =@h160, \t[h161] =@h161, \t[h162] =@h162, \t[h164] =@h164, \t[h167] =@h167, \t[h169] =@h169, \t[h170] =@h170, \t[h173] =@h173, \t[h176] =@h176, \t[h178] =@h178, \t[h179] =@h179, \t[h181] =@h181, \t[h184] =@h184, \t[h187] =@h187, \t[h189] =@h189, \t[h190] =@h190, \t[h191] =@h191, \t[h198] =@h198, \t[h199] =@h199, \t[h202] =@h202, \t[h203] =@h203, \t[h204] =@h204, \t[h205] =@h205, \t[h206] =@h206, \t[h208] =@h208, \t[h209] =@h209, \t[h210] =@h210, \t[h212] =@h212, \t[h214] =@h214, \t[h215] =@h215, \t[h216] =@h216, \t[h217] =@h217, \t[h219] =@h219, \t[h220] =@h220, \t[h223] =@h223, \t[h229] =@h229, \t[h233] =@h233, \t[h234] =@h234, \t[h235]  =@h235,  \t[d107] =@d107, \t[d108] =@d108, \t[d114] =@d114, \t[d118] =@d118, \t[d126] =@d126, \t[d127] =@d127, \t[d129] =@d129, \t[d132] =@d132, \t[d133] =@d133, \t[d134] =@d134, \t[d140] =@d140, \t[d141] =@d141, \t[d142] =@d142, \t[d143] =@d143, \t[d147] =@d147, \t[d148] =@d148, \t[d152] =@d152, \t[d155] =@d155, \t[d157] =@d157, \t[d159] =@d159, \t[d161] =@d161, \t[d162] =@d162, \t[d163] =@d163, \t[d164] =@d164, \t[d169] =@d169, \t[d175] =@d175, \t[d177] =@d177, \t[d186] =@d186, \t[d188] =@d188, \t[d190] =@d190, \t[d195] =@d195, \t[d196] =@d196, \t[d197] =@d197, \t[d200] =@d200, \t[d211] =@d211, \t[d213] =@d213, \t[d222] =@d222, \t[d224] =@d224, \t[d225] =@d225, \t[d227] =@d227, \t[d232]  =@d232,  \t[hl114] =@hl114, \t[hl123] =@hl123, \t[hl129] =@hl129, \t[hl133] =@hl133, \t[hl147] =@hl147, \t[hl148] =@hl148, \t[hl157] =@hl157, \t[hl161] =@hl161, \t[hl162] =@hl162, \t[hl164] =@hl164, \t[hl169] =@hl169, \t[hl172] =@hl172, \t[hl190] =@hl190, \t[hl198]  =@hl198   WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@s101", s101.Text);
		cmd.Parameters.AddWithValue("@s104", s104.Text);
		cmd.Parameters.AddWithValue("@s110", s110.Text);
		cmd.Parameters.AddWithValue("@s113", s113.Text);
		cmd.Parameters.AddWithValue("@s114", s114.Text);
		cmd.Parameters.AddWithValue("@s115", s115.Text);
		cmd.Parameters.AddWithValue("@s116", s116.Text);
		cmd.Parameters.AddWithValue("@s117", s117.Text);
		cmd.Parameters.AddWithValue("@s119", s119.Text);
		cmd.Parameters.AddWithValue("@s121", s121.Text);
		cmd.Parameters.AddWithValue("@s122", s122.Text);
		cmd.Parameters.AddWithValue("@s123", s123.Text);
		cmd.Parameters.AddWithValue("@s124", s124.Text);
		cmd.Parameters.AddWithValue("@s125", s125.Text);
		cmd.Parameters.AddWithValue("@s128", s128.Text);
		cmd.Parameters.AddWithValue("@s129", s129.Text);
		cmd.Parameters.AddWithValue("@s130", s130.Text);
		cmd.Parameters.AddWithValue("@s133", s133.Text);
		cmd.Parameters.AddWithValue("@s135", s135.Text);
		cmd.Parameters.AddWithValue("@s136", s136.Text);
		cmd.Parameters.AddWithValue("@s137", s137.Text);
		cmd.Parameters.AddWithValue("@s138", s138.Text);
		cmd.Parameters.AddWithValue("@s145", s145.Text);
		cmd.Parameters.AddWithValue("@s147", s147.Text);
		cmd.Parameters.AddWithValue("@s148", s148.Text);
		cmd.Parameters.AddWithValue("@s153", s153.Text);
		cmd.Parameters.AddWithValue("@s157", s157.Text);
		cmd.Parameters.AddWithValue("@s161", s161.Text);
		cmd.Parameters.AddWithValue("@s162", s162.Text);
		cmd.Parameters.AddWithValue("@s164", s164.Text);
		cmd.Parameters.AddWithValue("@s165", s165.Text);
		cmd.Parameters.AddWithValue("@s166", s166.Text);
		cmd.Parameters.AddWithValue("@s168", s168.Text);
		cmd.Parameters.AddWithValue("@s169", s169.Text);
		cmd.Parameters.AddWithValue("@s171", s171.Text);
		cmd.Parameters.AddWithValue("@s174", s174.Text);
		cmd.Parameters.AddWithValue("@s180", s180.Text);
		cmd.Parameters.AddWithValue("@s182", s182.Text);
		cmd.Parameters.AddWithValue("@s183", s183.Text);
		cmd.Parameters.AddWithValue("@s185", s185.Text);
		cmd.Parameters.AddWithValue("@s190", s190.Text);
		cmd.Parameters.AddWithValue("@s192", s192.Text);
		cmd.Parameters.AddWithValue("@s193", s193.Text);
		cmd.Parameters.AddWithValue("@s194", s194.Text);
		cmd.Parameters.AddWithValue("@s198", s198.Text);
		cmd.Parameters.AddWithValue("@s201", s201.Text);
		cmd.Parameters.AddWithValue("@s207", s207.Text);
		cmd.Parameters.AddWithValue("@s218", s218.Text);
		cmd.Parameters.AddWithValue("@s221", s221.Text);
		cmd.Parameters.AddWithValue("@s226", s226.Text);
		cmd.Parameters.AddWithValue("@s228", s228.Text);
		cmd.Parameters.AddWithValue("@s230", s230.Text);
		cmd.Parameters.AddWithValue("@s231", s231.Text);
		cmd.Parameters.AddWithValue("@s236", s236.Text);
		cmd.Parameters.AddWithValue("@h102", h102.Text);
		cmd.Parameters.AddWithValue("@h103", h103.Text);
		cmd.Parameters.AddWithValue("@h105", h105.Text);
		cmd.Parameters.AddWithValue("@h106", h106.Text);
		cmd.Parameters.AddWithValue("@h109", h109.Text);
		cmd.Parameters.AddWithValue("@h111", h111.Text);
		cmd.Parameters.AddWithValue("@h112", h112.Text);
		cmd.Parameters.AddWithValue("@h114", h114.Text);
		cmd.Parameters.AddWithValue("@h120", h120.Text);
		cmd.Parameters.AddWithValue("@h123", h123.Text);
		cmd.Parameters.AddWithValue("@h129", h129.Text);
		cmd.Parameters.AddWithValue("@h131", h131.Text);
		cmd.Parameters.AddWithValue("@h133", h133.Text);
		cmd.Parameters.AddWithValue("@h139", h139.Text);
		cmd.Parameters.AddWithValue("@h144", h144.Text);
		cmd.Parameters.AddWithValue("@h146", h146.Text);
		cmd.Parameters.AddWithValue("@h147", h147.Text);
		cmd.Parameters.AddWithValue("@h148", h148.Text);
		cmd.Parameters.AddWithValue("@h149", h149.Text);
		cmd.Parameters.AddWithValue("@h150", h150.Text);
		cmd.Parameters.AddWithValue("@h151", h151.Text);
		cmd.Parameters.AddWithValue("@h154", h154.Text);
		cmd.Parameters.AddWithValue("@h156", h156.Text);
		cmd.Parameters.AddWithValue("@h157", h157.Text);
		cmd.Parameters.AddWithValue("@h158", h158.Text);
		cmd.Parameters.AddWithValue("@h160", h160.Text);
		cmd.Parameters.AddWithValue("@h161", h161.Text);
		cmd.Parameters.AddWithValue("@h162", h162.Text);
		cmd.Parameters.AddWithValue("@h164", h164.Text);
		cmd.Parameters.AddWithValue("@h167", h167.Text);
		cmd.Parameters.AddWithValue("@h169", h169.Text);
		cmd.Parameters.AddWithValue("@h170", h170.Text);
		cmd.Parameters.AddWithValue("@h173", h173.Text);
		cmd.Parameters.AddWithValue("@h176", h176.Text);
		cmd.Parameters.AddWithValue("@h178", h178.Text);
		cmd.Parameters.AddWithValue("@h179", h179.Text);
		cmd.Parameters.AddWithValue("@h181", h181.Text);
		cmd.Parameters.AddWithValue("@h184", h184.Text);
		cmd.Parameters.AddWithValue("@h187", h187.Text);
		cmd.Parameters.AddWithValue("@h189", h189.Text);
		cmd.Parameters.AddWithValue("@h190", h190.Text);
		cmd.Parameters.AddWithValue("@h191", h191.Text);
		cmd.Parameters.AddWithValue("@h198", h198.Text);
		cmd.Parameters.AddWithValue("@h199", h199.Text);
		cmd.Parameters.AddWithValue("@h202", h202.Text);
		cmd.Parameters.AddWithValue("@h203", h203.Text);
		cmd.Parameters.AddWithValue("@h204", h204.Text);
		cmd.Parameters.AddWithValue("@h205", h205.Text);
		cmd.Parameters.AddWithValue("@h206", h206.Text);
		cmd.Parameters.AddWithValue("@h208", h208.Text);
		cmd.Parameters.AddWithValue("@h209", h209.Text);
		cmd.Parameters.AddWithValue("@h210", h210.Text);
		cmd.Parameters.AddWithValue("@h212", h212.Text);
		cmd.Parameters.AddWithValue("@h214", h214.Text);
		cmd.Parameters.AddWithValue("@h215", h215.Text);
		cmd.Parameters.AddWithValue("@h216", h216.Text);
		cmd.Parameters.AddWithValue("@h217", h217.Text);
		cmd.Parameters.AddWithValue("@h219", h219.Text);
		cmd.Parameters.AddWithValue("@h220", h220.Text);
		cmd.Parameters.AddWithValue("@h223", h223.Text);
		cmd.Parameters.AddWithValue("@h229", h229.Text);
		cmd.Parameters.AddWithValue("@h233", h233.Text);
		cmd.Parameters.AddWithValue("@h234", h234.Text);
		cmd.Parameters.AddWithValue("@h235", h235.Text);
		cmd.Parameters.AddWithValue("@d107", d107.Text);
		cmd.Parameters.AddWithValue("@d108", d108.Text);
		cmd.Parameters.AddWithValue("@d114", d114.Text);
		cmd.Parameters.AddWithValue("@d118", d118.Text);
		cmd.Parameters.AddWithValue("@d126", d126.Text);
		cmd.Parameters.AddWithValue("@d127", d127.Text);
		cmd.Parameters.AddWithValue("@d129", d129.Text);
		cmd.Parameters.AddWithValue("@d132", d132.Text);
		cmd.Parameters.AddWithValue("@d133", d133.Text);
		cmd.Parameters.AddWithValue("@d134", d134.Text);
		cmd.Parameters.AddWithValue("@d140", d140.Text);
		cmd.Parameters.AddWithValue("@d141", d141.Text);
		cmd.Parameters.AddWithValue("@d142", d142.Text);
		cmd.Parameters.AddWithValue("@d143", d143.Text);
		cmd.Parameters.AddWithValue("@d147", d147.Text);
		cmd.Parameters.AddWithValue("@d148", d148.Text);
		cmd.Parameters.AddWithValue("@d152", d152.Text);
		cmd.Parameters.AddWithValue("@d155", d155.Text);
		cmd.Parameters.AddWithValue("@d157", d157.Text);
		cmd.Parameters.AddWithValue("@d159", d159.Text);
		cmd.Parameters.AddWithValue("@d161", d161.Text);
		cmd.Parameters.AddWithValue("@d162", d162.Text);
		cmd.Parameters.AddWithValue("@d163", d163.Text);
		cmd.Parameters.AddWithValue("@d164", d164.Text);
		cmd.Parameters.AddWithValue("@d169", d169.Text);
		cmd.Parameters.AddWithValue("@d175", d175.Text);
		cmd.Parameters.AddWithValue("@d177", d177.Text);
		cmd.Parameters.AddWithValue("@d186", d186.Text);
		cmd.Parameters.AddWithValue("@d188", d188.Text);
		cmd.Parameters.AddWithValue("@d190", d190.Text);
		cmd.Parameters.AddWithValue("@d195", d195.Text);
		cmd.Parameters.AddWithValue("@d196", d196.Text);
		cmd.Parameters.AddWithValue("@d197", d197.Text);
		cmd.Parameters.AddWithValue("@d200", d200.Text);
		cmd.Parameters.AddWithValue("@d211", d211.Text);
		cmd.Parameters.AddWithValue("@d213", d213.Text);
		cmd.Parameters.AddWithValue("@d222", d222.Text);
		cmd.Parameters.AddWithValue("@d224", d224.Text);
		cmd.Parameters.AddWithValue("@d225", d225.Text);
		cmd.Parameters.AddWithValue("@d227", d227.Text);
		cmd.Parameters.AddWithValue("@d232", d232.Text);
		cmd.Parameters.AddWithValue("@hl114", hl114.Text);
		cmd.Parameters.AddWithValue("@hl123", hl123.Text);
		cmd.Parameters.AddWithValue("@hl129", hl129.Text);
		cmd.Parameters.AddWithValue("@hl133", hl133.Text);
		cmd.Parameters.AddWithValue("@hl147", hl147.Text);
		cmd.Parameters.AddWithValue("@hl148", hl148.Text);
		cmd.Parameters.AddWithValue("@hl157", hl157.Text);
		cmd.Parameters.AddWithValue("@hl161", hl161.Text);
		cmd.Parameters.AddWithValue("@hl162", hl162.Text);
		cmd.Parameters.AddWithValue("@hl164", hl164.Text);
		cmd.Parameters.AddWithValue("@hl169", hl169.Text);
		cmd.Parameters.AddWithValue("@hl172", hl172.Text);
		cmd.Parameters.AddWithValue("@hl190", hl190.Text);
		cmd.Parameters.AddWithValue("@hl198", hl198.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		add_update_delete();
		MessageBox.Show("تازةكرايةوة ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void add_update_delete()
	{
		Home ho = new Home();
		string qurey = "insert into update_delete(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal, [naw_karmand],[taime],[shwen],Device_name,srial_namber,[s101],\t[s104],\t[s110],\t[s113],\t[s114],\t[s115],\t[s116],\t[s117],\t[s119],\t[s121],\t[s122],\t[s123],\t[s124],\t[s125],\t[s128],\t[s129],\t[s130],\t[s133],\t[s135],\t[s136],\t[s137],\t[s138],\t[s145],\t[s147],\t[s148],\t[s153],\t[s157],\t[s161],\t[s162],\t[s164],\t[s165],\t[s166],\t[s168],\t[s169],\t[s171],\t[s174],\t[s180],\t[s182],\t[s183],\t[s185],\t[s190],\t[s192],\t[s193],\t[s194],\t[s198],\t[s201],\t[s207],\t[s218],\t[s221],\t[s226],\t[s228],\t[s230],\t[s231],\t[s236],\t[h102],\t[h103],\t[h105],\t[h106],\t[h109],\t[h111],\t[h112],\t[h114],\t[h120],\t[h123],\t[h129],\t[h131],\t[h133],\t[h139],\t[h144],\t[h146],\t[h147],\t[h148],\t[h149],\t[h150],\t[h151],\t[h154],\t[h156],\t[h157],\t[h158],\t[h160],\t[h161],\t[h162],\t[h164],\t[h167],\t[h169],\t[h170],\t[h173],\t[h176],\t[h178],\t[h179],\t[h181],\t[h184],\t[h187],\t[h189],\t[h190],\t[h191],\t[h198],\t[h199],\t[h202],\t[h203],\t[h204],\t[h205],\t[h206],\t[h208],\t[h209],\t[h210],\t[h212],\t[h214],\t[h215],\t[h216],\t[h217],\t[h219],\t[h220],\t[h223],\t[h229],\t[h233],\t[h234],\t[h235],\t[d107],\t[d108],\t[d114],\t[d118],\t[d126],\t[d127],\t[d129],\t[d132],\t[d133],\t[d134],\t[d140],\t[d141],\t[d142],\t[d143],\t[d147],\t[d148],\t[d152],\t[d155],\t[d157],\t[d159],\t[d161],\t[d162],\t[d163],\t[d164],\t[d169],\t[d175],\t[d177],\t[d186],\t[d188],\t[d190],\t[d195],\t[d196],\t[d197],\t[d200],\t[d211],\t[d213],\t[d222],\t[d224],\t[d225],\t[d227],\t[d232],\t[hl114],\t[hl123],\t[hl129],\t[hl133],\t[hl147],\t[hl148],\t[hl157],\t[hl161],\t[hl162],\t[hl164],\t[hl169],\t[hl172],\t[hl190],\t[hl198] )VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,@naw_karmand,@taime,@shwen,@Device_name,@srial_namber,@s101,\t@s104, \t@s110, \t@s113, \t@s114, \t@s115, \t@s116, \t@s117, \t@s119, \t@s121, \t@s122, \t@s123, \t@s124, \t@s125, \t@s128, \t@s129, \t@s130, \t@s133, \t@s135, \t@s136, \t@s137, \t@s138, \t@s145, \t@s147, \t@s148, \t@s153, \t@s157, \t@s161, \t@s162, \t@s164, \t@s165, \t@s166, \t@s168, \t@s169, \t@s171, \t@s174, \t@s180, \t@s182, \t@s183, \t@s185, \t@s190, \t@s192, \t@s193, \t@s194, \t@s198, \t@s201, \t@s207, \t@s218, \t@s221, \t@s226, \t@s228, \t@s230, \t@s231, \t@s236,  \t@h102,\t@h103, \t@h105, \t@h106, \t@h109, \t@h111, \t@h112, \t@h114, \t@h120, \t@h123, \t@h129, \t@h131, \t@h133, \t@h139, \t@h144, \t@h146, \t@h147, \t@h148, \t@h149, \t@h150, \t@h151, \t@h154, \t@h156, \t@h157, \t@h158, \t@h160, \t@h161, \t@h162, \t@h164, \t@h167, \t@h169, \t@h170, \t@h173, \t@h176, \t@h178, \t@h179, \t@h181, \t@h184, \t@h187, \t@h189, \t@h190, \t@h191, \t@h198, \t@h199, \t@h202, \t@h203, \t@h204, \t@h205, \t@h206, \t@h208, \t@h209, \t@h210, \t@h212, \t@h214, \t@h215, \t@h216, \t@h217, \t@h219, \t@h220, \t@h223, \t@h229, \t@h233, \t@h234, \t@h235,  \t@d107, \t@d108, \t@d114, \t@d118, \t@d126, \t@d127, \t@d129, \t@d132, \t@d133, \t@d134, \t@d140, \t@d141, \t@d142, \t@d143, \t@d147, \t@d148, \t@d152, \t@d155, \t@d157, \t@d159, \t@d161, \t@d162, \t@d163, \t@d164, \t@d169, \t@d175, \t@d177, \t@d186, \t@d188, \t@d190, \t@d195, \t@d196, \t@d197, \t@d200, \t@d211, \t@d213, \t@d222, \t@d224, \t@d225, \t@d227, \t@d232,  \t@hl114, \t@hl123, \t@hl129, \t@hl133, \t@hl147, \t@hl148, \t@hl157, \t@hl161, \t@hl162, \t@hl164, \t@hl169, \t@hl172, \t@hl190, \t@hl198)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@malband", txtmalband.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@naw_tasjil", txtnawtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@naw_bnka", txtnawbnka.Text);
		cmd.Parameters.AddWithValue("@westga_gshty", txtwestga.Text);
		cmd.Parameters.AddWithValue("@dangdar", txtzhdangdar.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@naw_karmand", ho.lblkarmand.Text.ToString());
		cmd.Parameters.AddWithValue("@taime", ho.lbltaime.Text.ToString());
		cmd.Parameters.AddWithValue("@shwen", ho.lblshwen.Text.ToString());
		cmd.Parameters.AddWithValue("@Device_name", ho.lbldevice.Text.ToString());
		cmd.Parameters.AddWithValue("@srial_namber", ho.lblsrial.Text.ToString());
		cmd.Parameters.AddWithValue("@s101", s101.Text);
		cmd.Parameters.AddWithValue("@s104", s104.Text);
		cmd.Parameters.AddWithValue("@s110", s110.Text);
		cmd.Parameters.AddWithValue("@s113", s113.Text);
		cmd.Parameters.AddWithValue("@s114", s114.Text);
		cmd.Parameters.AddWithValue("@s115", s115.Text);
		cmd.Parameters.AddWithValue("@s116", s116.Text);
		cmd.Parameters.AddWithValue("@s117", s117.Text);
		cmd.Parameters.AddWithValue("@s119", s119.Text);
		cmd.Parameters.AddWithValue("@s121", s121.Text);
		cmd.Parameters.AddWithValue("@s122", s122.Text);
		cmd.Parameters.AddWithValue("@s123", s123.Text);
		cmd.Parameters.AddWithValue("@s124", s124.Text);
		cmd.Parameters.AddWithValue("@s125", s125.Text);
		cmd.Parameters.AddWithValue("@s128", s128.Text);
		cmd.Parameters.AddWithValue("@s129", s129.Text);
		cmd.Parameters.AddWithValue("@s130", s130.Text);
		cmd.Parameters.AddWithValue("@s133", s133.Text);
		cmd.Parameters.AddWithValue("@s135", s135.Text);
		cmd.Parameters.AddWithValue("@s136", s136.Text);
		cmd.Parameters.AddWithValue("@s137", s137.Text);
		cmd.Parameters.AddWithValue("@s138", s138.Text);
		cmd.Parameters.AddWithValue("@s145", s145.Text);
		cmd.Parameters.AddWithValue("@s147", s147.Text);
		cmd.Parameters.AddWithValue("@s148", s148.Text);
		cmd.Parameters.AddWithValue("@s153", s153.Text);
		cmd.Parameters.AddWithValue("@s157", s157.Text);
		cmd.Parameters.AddWithValue("@s161", s161.Text);
		cmd.Parameters.AddWithValue("@s162", s162.Text);
		cmd.Parameters.AddWithValue("@s164", s164.Text);
		cmd.Parameters.AddWithValue("@s165", s165.Text);
		cmd.Parameters.AddWithValue("@s166", s166.Text);
		cmd.Parameters.AddWithValue("@s168", s168.Text);
		cmd.Parameters.AddWithValue("@s169", s169.Text);
		cmd.Parameters.AddWithValue("@s171", s171.Text);
		cmd.Parameters.AddWithValue("@s174", s174.Text);
		cmd.Parameters.AddWithValue("@s180", s180.Text);
		cmd.Parameters.AddWithValue("@s182", s182.Text);
		cmd.Parameters.AddWithValue("@s183", s183.Text);
		cmd.Parameters.AddWithValue("@s185", s185.Text);
		cmd.Parameters.AddWithValue("@s190", s190.Text);
		cmd.Parameters.AddWithValue("@s192", s192.Text);
		cmd.Parameters.AddWithValue("@s193", s193.Text);
		cmd.Parameters.AddWithValue("@s194", s194.Text);
		cmd.Parameters.AddWithValue("@s198", s198.Text);
		cmd.Parameters.AddWithValue("@s201", s201.Text);
		cmd.Parameters.AddWithValue("@s207", s207.Text);
		cmd.Parameters.AddWithValue("@s218", s218.Text);
		cmd.Parameters.AddWithValue("@s221", s221.Text);
		cmd.Parameters.AddWithValue("@s226", s226.Text);
		cmd.Parameters.AddWithValue("@s228", s228.Text);
		cmd.Parameters.AddWithValue("@s230", s230.Text);
		cmd.Parameters.AddWithValue("@s231", s231.Text);
		cmd.Parameters.AddWithValue("@s236", s236.Text);
		cmd.Parameters.AddWithValue("@h102", h102.Text);
		cmd.Parameters.AddWithValue("@h103", h103.Text);
		cmd.Parameters.AddWithValue("@h105", h105.Text);
		cmd.Parameters.AddWithValue("@h106", h106.Text);
		cmd.Parameters.AddWithValue("@h109", h109.Text);
		cmd.Parameters.AddWithValue("@h111", h111.Text);
		cmd.Parameters.AddWithValue("@h112", h112.Text);
		cmd.Parameters.AddWithValue("@h114", h114.Text);
		cmd.Parameters.AddWithValue("@h120", h120.Text);
		cmd.Parameters.AddWithValue("@h123", h123.Text);
		cmd.Parameters.AddWithValue("@h129", h129.Text);
		cmd.Parameters.AddWithValue("@h131", h131.Text);
		cmd.Parameters.AddWithValue("@h133", h133.Text);
		cmd.Parameters.AddWithValue("@h139", h139.Text);
		cmd.Parameters.AddWithValue("@h144", h144.Text);
		cmd.Parameters.AddWithValue("@h146", h146.Text);
		cmd.Parameters.AddWithValue("@h147", h147.Text);
		cmd.Parameters.AddWithValue("@h148", h148.Text);
		cmd.Parameters.AddWithValue("@h149", h149.Text);
		cmd.Parameters.AddWithValue("@h150", h150.Text);
		cmd.Parameters.AddWithValue("@h151", h151.Text);
		cmd.Parameters.AddWithValue("@h154", h154.Text);
		cmd.Parameters.AddWithValue("@h156", h156.Text);
		cmd.Parameters.AddWithValue("@h157", h157.Text);
		cmd.Parameters.AddWithValue("@h158", h158.Text);
		cmd.Parameters.AddWithValue("@h160", h160.Text);
		cmd.Parameters.AddWithValue("@h161", h161.Text);
		cmd.Parameters.AddWithValue("@h162", h162.Text);
		cmd.Parameters.AddWithValue("@h164", h164.Text);
		cmd.Parameters.AddWithValue("@h167", h167.Text);
		cmd.Parameters.AddWithValue("@h169", h169.Text);
		cmd.Parameters.AddWithValue("@h170", h170.Text);
		cmd.Parameters.AddWithValue("@h173", h173.Text);
		cmd.Parameters.AddWithValue("@h176", h176.Text);
		cmd.Parameters.AddWithValue("@h178", h178.Text);
		cmd.Parameters.AddWithValue("@h179", h179.Text);
		cmd.Parameters.AddWithValue("@h181", h181.Text);
		cmd.Parameters.AddWithValue("@h184", h184.Text);
		cmd.Parameters.AddWithValue("@h187", h187.Text);
		cmd.Parameters.AddWithValue("@h189", h189.Text);
		cmd.Parameters.AddWithValue("@h190", h190.Text);
		cmd.Parameters.AddWithValue("@h191", h191.Text);
		cmd.Parameters.AddWithValue("@h198", h198.Text);
		cmd.Parameters.AddWithValue("@h199", h199.Text);
		cmd.Parameters.AddWithValue("@h202", h202.Text);
		cmd.Parameters.AddWithValue("@h203", h203.Text);
		cmd.Parameters.AddWithValue("@h204", h204.Text);
		cmd.Parameters.AddWithValue("@h205", h205.Text);
		cmd.Parameters.AddWithValue("@h206", h206.Text);
		cmd.Parameters.AddWithValue("@h208", h208.Text);
		cmd.Parameters.AddWithValue("@h209", h209.Text);
		cmd.Parameters.AddWithValue("@h210", h210.Text);
		cmd.Parameters.AddWithValue("@h212", h212.Text);
		cmd.Parameters.AddWithValue("@h214", h214.Text);
		cmd.Parameters.AddWithValue("@h215", h215.Text);
		cmd.Parameters.AddWithValue("@h216", h216.Text);
		cmd.Parameters.AddWithValue("@h217", h217.Text);
		cmd.Parameters.AddWithValue("@h219", h219.Text);
		cmd.Parameters.AddWithValue("@h220", h220.Text);
		cmd.Parameters.AddWithValue("@h223", h223.Text);
		cmd.Parameters.AddWithValue("@h229", h229.Text);
		cmd.Parameters.AddWithValue("@h233", h233.Text);
		cmd.Parameters.AddWithValue("@h234", h234.Text);
		cmd.Parameters.AddWithValue("@h235", h235.Text);
		cmd.Parameters.AddWithValue("@d107", d107.Text);
		cmd.Parameters.AddWithValue("@d108", d108.Text);
		cmd.Parameters.AddWithValue("@d114", d114.Text);
		cmd.Parameters.AddWithValue("@d118", d118.Text);
		cmd.Parameters.AddWithValue("@d126", d126.Text);
		cmd.Parameters.AddWithValue("@d127", d127.Text);
		cmd.Parameters.AddWithValue("@d129", d129.Text);
		cmd.Parameters.AddWithValue("@d132", d132.Text);
		cmd.Parameters.AddWithValue("@d133", d133.Text);
		cmd.Parameters.AddWithValue("@d134", d134.Text);
		cmd.Parameters.AddWithValue("@d140", d140.Text);
		cmd.Parameters.AddWithValue("@d141", d141.Text);
		cmd.Parameters.AddWithValue("@d142", d142.Text);
		cmd.Parameters.AddWithValue("@d143", d143.Text);
		cmd.Parameters.AddWithValue("@d147", d147.Text);
		cmd.Parameters.AddWithValue("@d148", d148.Text);
		cmd.Parameters.AddWithValue("@d152", d152.Text);
		cmd.Parameters.AddWithValue("@d155", d155.Text);
		cmd.Parameters.AddWithValue("@d157", d157.Text);
		cmd.Parameters.AddWithValue("@d159", d159.Text);
		cmd.Parameters.AddWithValue("@d161", d161.Text);
		cmd.Parameters.AddWithValue("@d162", d162.Text);
		cmd.Parameters.AddWithValue("@d163", d163.Text);
		cmd.Parameters.AddWithValue("@d164", d164.Text);
		cmd.Parameters.AddWithValue("@d169", d169.Text);
		cmd.Parameters.AddWithValue("@d175", d175.Text);
		cmd.Parameters.AddWithValue("@d177", d177.Text);
		cmd.Parameters.AddWithValue("@d186", d186.Text);
		cmd.Parameters.AddWithValue("@d188", d188.Text);
		cmd.Parameters.AddWithValue("@d190", d190.Text);
		cmd.Parameters.AddWithValue("@d195", d195.Text);
		cmd.Parameters.AddWithValue("@d196", d196.Text);
		cmd.Parameters.AddWithValue("@d197", d197.Text);
		cmd.Parameters.AddWithValue("@d200", d200.Text);
		cmd.Parameters.AddWithValue("@d211", d211.Text);
		cmd.Parameters.AddWithValue("@d213", d213.Text);
		cmd.Parameters.AddWithValue("@d222", d222.Text);
		cmd.Parameters.AddWithValue("@d224", d224.Text);
		cmd.Parameters.AddWithValue("@d225", d225.Text);
		cmd.Parameters.AddWithValue("@d227", d227.Text);
		cmd.Parameters.AddWithValue("@d232", d232.Text);
		cmd.Parameters.AddWithValue("@hl114", hl114.Text);
		cmd.Parameters.AddWithValue("@hl123", hl123.Text);
		cmd.Parameters.AddWithValue("@hl129", hl129.Text);
		cmd.Parameters.AddWithValue("@hl133", hl133.Text);
		cmd.Parameters.AddWithValue("@hl147", hl147.Text);
		cmd.Parameters.AddWithValue("@hl148", hl148.Text);
		cmd.Parameters.AddWithValue("@hl157", hl157.Text);
		cmd.Parameters.AddWithValue("@hl161", hl161.Text);
		cmd.Parameters.AddWithValue("@hl162", hl162.Text);
		cmd.Parameters.AddWithValue("@hl164", hl164.Text);
		cmd.Parameters.AddWithValue("@hl169", hl169.Text);
		cmd.Parameters.AddWithValue("@hl172", hl172.Text);
		cmd.Parameters.AddWithValue("@hl190", hl190.Text);
		cmd.Parameters.AddWithValue("@hl198", hl198.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
	}

	private void add_taybat_all()
	{
		Home ho = new Home();
		string qurey = "insert into taybat_all(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal, [naw_karmand],[taime],[jor_dangdan],Device_name,srial_namber,[s101],\t[s104],\t[s110],\t[s113],\t[s114],\t[s115],\t[s116],\t[s117],\t[s119],\t[s121],\t[s122],\t[s123],\t[s124],\t[s125],\t[s128],\t[s129],\t[s130],\t[s133],\t[s135],\t[s136],\t[s137],\t[s138],\t[s145],\t[s147],\t[s148],\t[s153],\t[s157],\t[s161],\t[s162],\t[s164],\t[s165],\t[s166],\t[s168],\t[s169],\t[s171],\t[s174],\t[s180],\t[s182],\t[s183],\t[s185],\t[s190],\t[s192],\t[s193],\t[s194],\t[s198],\t[s201],\t[s207],\t[s218],\t[s221],\t[s226],\t[s228],\t[s230],\t[s231],\t[s236],\t[h102],\t[h103],\t[h105],\t[h106],\t[h109],\t[h111],\t[h112],\t[h114],\t[h120],\t[h123],\t[h129],\t[h131],\t[h133],\t[h139],\t[h144],\t[h146],\t[h147],\t[h148],\t[h149],\t[h150],\t[h151],\t[h154],\t[h156],\t[h157],\t[h158],\t[h160],\t[h161],\t[h162],\t[h164],\t[h167],\t[h169],\t[h170],\t[h173],\t[h176],\t[h178],\t[h179],\t[h181],\t[h184],\t[h187],\t[h189],\t[h190],\t[h191],\t[h198],\t[h199],\t[h202],\t[h203],\t[h204],\t[h205],\t[h206],\t[h208],\t[h209],\t[h210],\t[h212],\t[h214],\t[h215],\t[h216],\t[h217],\t[h219],\t[h220],\t[h223],\t[h229],\t[h233],\t[h234],\t[h235],\t[d107],\t[d108],\t[d114],\t[d118],\t[d126],\t[d127],\t[d129],\t[d132],\t[d133],\t[d134],\t[d140],\t[d141],\t[d142],\t[d143],\t[d147],\t[d148],\t[d152],\t[d155],\t[d157],\t[d159],\t[d161],\t[d162],\t[d163],\t[d164],\t[d169],\t[d175],\t[d177],\t[d186],\t[d188],\t[d190],\t[d195],\t[d196],\t[d197],\t[d200],\t[d211],\t[d213],\t[d222],\t[d224],\t[d225],\t[d227],\t[d232],\t[hl114],\t[hl123],\t[hl129],\t[hl133],\t[hl147],\t[hl148],\t[hl157],\t[hl161],\t[hl162],\t[hl164],\t[hl169],\t[hl172],\t[hl190],\t[hl198] )VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,@naw_karmand,@taime,@jor_dangdan,@Device_name,@srial_namber,@s101,\t@s104, \t@s110, \t@s113, \t@s114, \t@s115, \t@s116, \t@s117, \t@s119, \t@s121, \t@s122, \t@s123, \t@s124, \t@s125, \t@s128, \t@s129, \t@s130, \t@s133, \t@s135, \t@s136, \t@s137, \t@s138, \t@s145, \t@s147, \t@s148, \t@s153, \t@s157, \t@s161, \t@s162, \t@s164, \t@s165, \t@s166, \t@s168, \t@s169, \t@s171, \t@s174, \t@s180, \t@s182, \t@s183, \t@s185, \t@s190, \t@s192, \t@s193, \t@s194, \t@s198, \t@s201, \t@s207, \t@s218, \t@s221, \t@s226, \t@s228, \t@s230, \t@s231, \t@s236,  \t@h102,\t@h103, \t@h105, \t@h106, \t@h109, \t@h111, \t@h112, \t@h114, \t@h120, \t@h123, \t@h129, \t@h131, \t@h133, \t@h139, \t@h144, \t@h146, \t@h147, \t@h148, \t@h149, \t@h150, \t@h151, \t@h154, \t@h156, \t@h157, \t@h158, \t@h160, \t@h161, \t@h162, \t@h164, \t@h167, \t@h169, \t@h170, \t@h173, \t@h176, \t@h178, \t@h179, \t@h181, \t@h184, \t@h187, \t@h189, \t@h190, \t@h191, \t@h198, \t@h199, \t@h202, \t@h203, \t@h204, \t@h205, \t@h206, \t@h208, \t@h209, \t@h210, \t@h212, \t@h214, \t@h215, \t@h216, \t@h217, \t@h219, \t@h220, \t@h223, \t@h229, \t@h233, \t@h234, \t@h235,  \t@d107, \t@d108, \t@d114, \t@d118, \t@d126, \t@d127, \t@d129, \t@d132, \t@d133, \t@d134, \t@d140, \t@d141, \t@d142, \t@d143, \t@d147, \t@d148, \t@d152, \t@d155, \t@d157, \t@d159, \t@d161, \t@d162, \t@d163, \t@d164, \t@d169, \t@d175, \t@d177, \t@d186, \t@d188, \t@d190, \t@d195, \t@d196, \t@d197, \t@d200, \t@d211, \t@d213, \t@d222, \t@d224, \t@d225, \t@d227, \t@d232,  \t@hl114, \t@hl123, \t@hl129, \t@hl133, \t@hl147, \t@hl148, \t@hl157, \t@hl161, \t@hl162, \t@hl164, \t@hl169, \t@hl172, \t@hl190, \t@hl198)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@malband", txtmalband.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@naw_tasjil", txtnawtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@naw_bnka", txtnawbnka.Text);
		cmd.Parameters.AddWithValue("@westga_gshty", txtwestga.Text);
		cmd.Parameters.AddWithValue("@dangdar", txtzhdangdar.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@naw_karmand", ho.lblkarmand.Text.ToString());
		cmd.Parameters.AddWithValue("@taime", ho.lbltaime.Text.ToString());
		cmd.Parameters.AddWithValue("@jor_dangdan", labljorydangdan.Text.ToString());
		cmd.Parameters.AddWithValue("@Device_name", ho.lbldevice.Text.ToString());
		cmd.Parameters.AddWithValue("@srial_namber", ho.lblsrial.Text.ToString());
		cmd.Parameters.AddWithValue("@s101", s101.Text);
		cmd.Parameters.AddWithValue("@s104", s104.Text);
		cmd.Parameters.AddWithValue("@s110", s110.Text);
		cmd.Parameters.AddWithValue("@s113", s113.Text);
		cmd.Parameters.AddWithValue("@s114", s114.Text);
		cmd.Parameters.AddWithValue("@s115", s115.Text);
		cmd.Parameters.AddWithValue("@s116", s116.Text);
		cmd.Parameters.AddWithValue("@s117", s117.Text);
		cmd.Parameters.AddWithValue("@s119", s119.Text);
		cmd.Parameters.AddWithValue("@s121", s121.Text);
		cmd.Parameters.AddWithValue("@s122", s122.Text);
		cmd.Parameters.AddWithValue("@s123", s123.Text);
		cmd.Parameters.AddWithValue("@s124", s124.Text);
		cmd.Parameters.AddWithValue("@s125", s125.Text);
		cmd.Parameters.AddWithValue("@s128", s128.Text);
		cmd.Parameters.AddWithValue("@s129", s129.Text);
		cmd.Parameters.AddWithValue("@s130", s130.Text);
		cmd.Parameters.AddWithValue("@s133", s133.Text);
		cmd.Parameters.AddWithValue("@s135", s135.Text);
		cmd.Parameters.AddWithValue("@s136", s136.Text);
		cmd.Parameters.AddWithValue("@s137", s137.Text);
		cmd.Parameters.AddWithValue("@s138", s138.Text);
		cmd.Parameters.AddWithValue("@s145", s145.Text);
		cmd.Parameters.AddWithValue("@s147", s147.Text);
		cmd.Parameters.AddWithValue("@s148", s148.Text);
		cmd.Parameters.AddWithValue("@s153", s153.Text);
		cmd.Parameters.AddWithValue("@s157", s157.Text);
		cmd.Parameters.AddWithValue("@s161", s161.Text);
		cmd.Parameters.AddWithValue("@s162", s162.Text);
		cmd.Parameters.AddWithValue("@s164", s164.Text);
		cmd.Parameters.AddWithValue("@s165", s165.Text);
		cmd.Parameters.AddWithValue("@s166", s166.Text);
		cmd.Parameters.AddWithValue("@s168", s168.Text);
		cmd.Parameters.AddWithValue("@s169", s169.Text);
		cmd.Parameters.AddWithValue("@s171", s171.Text);
		cmd.Parameters.AddWithValue("@s174", s174.Text);
		cmd.Parameters.AddWithValue("@s180", s180.Text);
		cmd.Parameters.AddWithValue("@s182", s182.Text);
		cmd.Parameters.AddWithValue("@s183", s183.Text);
		cmd.Parameters.AddWithValue("@s185", s185.Text);
		cmd.Parameters.AddWithValue("@s190", s190.Text);
		cmd.Parameters.AddWithValue("@s192", s192.Text);
		cmd.Parameters.AddWithValue("@s193", s193.Text);
		cmd.Parameters.AddWithValue("@s194", s194.Text);
		cmd.Parameters.AddWithValue("@s198", s198.Text);
		cmd.Parameters.AddWithValue("@s201", s201.Text);
		cmd.Parameters.AddWithValue("@s207", s207.Text);
		cmd.Parameters.AddWithValue("@s218", s218.Text);
		cmd.Parameters.AddWithValue("@s221", s221.Text);
		cmd.Parameters.AddWithValue("@s226", s226.Text);
		cmd.Parameters.AddWithValue("@s228", s228.Text);
		cmd.Parameters.AddWithValue("@s230", s230.Text);
		cmd.Parameters.AddWithValue("@s231", s231.Text);
		cmd.Parameters.AddWithValue("@s236", s236.Text);
		cmd.Parameters.AddWithValue("@h102", h102.Text);
		cmd.Parameters.AddWithValue("@h103", h103.Text);
		cmd.Parameters.AddWithValue("@h105", h105.Text);
		cmd.Parameters.AddWithValue("@h106", h106.Text);
		cmd.Parameters.AddWithValue("@h109", h109.Text);
		cmd.Parameters.AddWithValue("@h111", h111.Text);
		cmd.Parameters.AddWithValue("@h112", h112.Text);
		cmd.Parameters.AddWithValue("@h114", h114.Text);
		cmd.Parameters.AddWithValue("@h120", h120.Text);
		cmd.Parameters.AddWithValue("@h123", h123.Text);
		cmd.Parameters.AddWithValue("@h129", h129.Text);
		cmd.Parameters.AddWithValue("@h131", h131.Text);
		cmd.Parameters.AddWithValue("@h133", h133.Text);
		cmd.Parameters.AddWithValue("@h139", h139.Text);
		cmd.Parameters.AddWithValue("@h144", h144.Text);
		cmd.Parameters.AddWithValue("@h146", h146.Text);
		cmd.Parameters.AddWithValue("@h147", h147.Text);
		cmd.Parameters.AddWithValue("@h148", h148.Text);
		cmd.Parameters.AddWithValue("@h149", h149.Text);
		cmd.Parameters.AddWithValue("@h150", h150.Text);
		cmd.Parameters.AddWithValue("@h151", h151.Text);
		cmd.Parameters.AddWithValue("@h154", h154.Text);
		cmd.Parameters.AddWithValue("@h156", h156.Text);
		cmd.Parameters.AddWithValue("@h157", h157.Text);
		cmd.Parameters.AddWithValue("@h158", h158.Text);
		cmd.Parameters.AddWithValue("@h160", h160.Text);
		cmd.Parameters.AddWithValue("@h161", h161.Text);
		cmd.Parameters.AddWithValue("@h162", h162.Text);
		cmd.Parameters.AddWithValue("@h164", h164.Text);
		cmd.Parameters.AddWithValue("@h167", h167.Text);
		cmd.Parameters.AddWithValue("@h169", h169.Text);
		cmd.Parameters.AddWithValue("@h170", h170.Text);
		cmd.Parameters.AddWithValue("@h173", h173.Text);
		cmd.Parameters.AddWithValue("@h176", h176.Text);
		cmd.Parameters.AddWithValue("@h178", h178.Text);
		cmd.Parameters.AddWithValue("@h179", h179.Text);
		cmd.Parameters.AddWithValue("@h181", h181.Text);
		cmd.Parameters.AddWithValue("@h184", h184.Text);
		cmd.Parameters.AddWithValue("@h187", h187.Text);
		cmd.Parameters.AddWithValue("@h189", h189.Text);
		cmd.Parameters.AddWithValue("@h190", h190.Text);
		cmd.Parameters.AddWithValue("@h191", h191.Text);
		cmd.Parameters.AddWithValue("@h198", h198.Text);
		cmd.Parameters.AddWithValue("@h199", h199.Text);
		cmd.Parameters.AddWithValue("@h202", h202.Text);
		cmd.Parameters.AddWithValue("@h203", h203.Text);
		cmd.Parameters.AddWithValue("@h204", h204.Text);
		cmd.Parameters.AddWithValue("@h205", h205.Text);
		cmd.Parameters.AddWithValue("@h206", h206.Text);
		cmd.Parameters.AddWithValue("@h208", h208.Text);
		cmd.Parameters.AddWithValue("@h209", h209.Text);
		cmd.Parameters.AddWithValue("@h210", h210.Text);
		cmd.Parameters.AddWithValue("@h212", h212.Text);
		cmd.Parameters.AddWithValue("@h214", h214.Text);
		cmd.Parameters.AddWithValue("@h215", h215.Text);
		cmd.Parameters.AddWithValue("@h216", h216.Text);
		cmd.Parameters.AddWithValue("@h217", h217.Text);
		cmd.Parameters.AddWithValue("@h219", h219.Text);
		cmd.Parameters.AddWithValue("@h220", h220.Text);
		cmd.Parameters.AddWithValue("@h223", h223.Text);
		cmd.Parameters.AddWithValue("@h229", h229.Text);
		cmd.Parameters.AddWithValue("@h233", h233.Text);
		cmd.Parameters.AddWithValue("@h234", h234.Text);
		cmd.Parameters.AddWithValue("@h235", h235.Text);
		cmd.Parameters.AddWithValue("@d107", d107.Text);
		cmd.Parameters.AddWithValue("@d108", d108.Text);
		cmd.Parameters.AddWithValue("@d114", d114.Text);
		cmd.Parameters.AddWithValue("@d118", d118.Text);
		cmd.Parameters.AddWithValue("@d126", d126.Text);
		cmd.Parameters.AddWithValue("@d127", d127.Text);
		cmd.Parameters.AddWithValue("@d129", d129.Text);
		cmd.Parameters.AddWithValue("@d132", d132.Text);
		cmd.Parameters.AddWithValue("@d133", d133.Text);
		cmd.Parameters.AddWithValue("@d134", d134.Text);
		cmd.Parameters.AddWithValue("@d140", d140.Text);
		cmd.Parameters.AddWithValue("@d141", d141.Text);
		cmd.Parameters.AddWithValue("@d142", d142.Text);
		cmd.Parameters.AddWithValue("@d143", d143.Text);
		cmd.Parameters.AddWithValue("@d147", d147.Text);
		cmd.Parameters.AddWithValue("@d148", d148.Text);
		cmd.Parameters.AddWithValue("@d152", d152.Text);
		cmd.Parameters.AddWithValue("@d155", d155.Text);
		cmd.Parameters.AddWithValue("@d157", d157.Text);
		cmd.Parameters.AddWithValue("@d159", d159.Text);
		cmd.Parameters.AddWithValue("@d161", d161.Text);
		cmd.Parameters.AddWithValue("@d162", d162.Text);
		cmd.Parameters.AddWithValue("@d163", d163.Text);
		cmd.Parameters.AddWithValue("@d164", d164.Text);
		cmd.Parameters.AddWithValue("@d169", d169.Text);
		cmd.Parameters.AddWithValue("@d175", d175.Text);
		cmd.Parameters.AddWithValue("@d177", d177.Text);
		cmd.Parameters.AddWithValue("@d186", d186.Text);
		cmd.Parameters.AddWithValue("@d188", d188.Text);
		cmd.Parameters.AddWithValue("@d190", d190.Text);
		cmd.Parameters.AddWithValue("@d195", d195.Text);
		cmd.Parameters.AddWithValue("@d196", d196.Text);
		cmd.Parameters.AddWithValue("@d197", d197.Text);
		cmd.Parameters.AddWithValue("@d200", d200.Text);
		cmd.Parameters.AddWithValue("@d211", d211.Text);
		cmd.Parameters.AddWithValue("@d213", d213.Text);
		cmd.Parameters.AddWithValue("@d222", d222.Text);
		cmd.Parameters.AddWithValue("@d224", d224.Text);
		cmd.Parameters.AddWithValue("@d225", d225.Text);
		cmd.Parameters.AddWithValue("@d227", d227.Text);
		cmd.Parameters.AddWithValue("@d232", d232.Text);
		cmd.Parameters.AddWithValue("@hl114", hl114.Text);
		cmd.Parameters.AddWithValue("@hl123", hl123.Text);
		cmd.Parameters.AddWithValue("@hl129", hl129.Text);
		cmd.Parameters.AddWithValue("@hl133", hl133.Text);
		cmd.Parameters.AddWithValue("@hl147", hl147.Text);
		cmd.Parameters.AddWithValue("@hl148", hl148.Text);
		cmd.Parameters.AddWithValue("@hl157", hl157.Text);
		cmd.Parameters.AddWithValue("@hl161", hl161.Text);
		cmd.Parameters.AddWithValue("@hl162", hl162.Text);
		cmd.Parameters.AddWithValue("@hl164", hl164.Text);
		cmd.Parameters.AddWithValue("@hl169", hl169.Text);
		cmd.Parameters.AddWithValue("@hl172", hl172.Text);
		cmd.Parameters.AddWithValue("@hl190", hl190.Text);
		cmd.Parameters.AddWithValue("@hl198", hl198.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		MessageBox.Show("تۆمار کرا ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void add_halabja_tybat()
	{
		string qurey = "insert into halabja_taybat(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal,[114],\t[123],\t[129],\t[133],\t[147],\t[148],\t[157],\t[161],\t[162],\t[164],\t[169],\t[172],\t[190],\t[198])VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,@114,\t@123,\t@129,\t@133,\t@147,\t@148,\t@157,\t@161,\t@162,\t@164,\t@169,\t@172,\t@190,\t@198)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@malband", txtmalband.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@naw_tasjil", txtnawtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@naw_bnka", txtnawbnka.Text);
		cmd.Parameters.AddWithValue("@westga_gshty", txtwestga.Text);
		cmd.Parameters.AddWithValue("@dangdar", txtzhdangdar.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@114", hl114.Text);
		cmd.Parameters.AddWithValue("@123", hl123.Text);
		cmd.Parameters.AddWithValue("@129", hl129.Text);
		cmd.Parameters.AddWithValue("@133", hl133.Text);
		cmd.Parameters.AddWithValue("@147", hl147.Text);
		cmd.Parameters.AddWithValue("@148", hl148.Text);
		cmd.Parameters.AddWithValue("@157", hl157.Text);
		cmd.Parameters.AddWithValue("@161", hl161.Text);
		cmd.Parameters.AddWithValue("@162", hl162.Text);
		cmd.Parameters.AddWithValue("@164", hl164.Text);
		cmd.Parameters.AddWithValue("@169", hl169.Text);
		cmd.Parameters.AddWithValue("@172", hl172.Text);
		cmd.Parameters.AddWithValue("@190", hl190.Text);
		cmd.Parameters.AddWithValue("@198", hl198.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
	}

	private void add_hawler_tyabat()
	{
		string qurey = "insert into hawler_tyabat(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal,[102],\t[103],\t[105],\t[106],\t[109],\t[111],\t[112],\t[114],\t[120],\t[123],\t[129],\t[131],\t[133],\t[139],\t[144],\t[146],\t[147],\t[148],\t[149],\t[150],\t[151],\t[154],\t[156],\t[157],\t[158],\t[160],\t[161],\t[162],\t[164],\t[167],\t[169],\t[170],\t[173],\t[176],\t[178],\t[179],\t[181],\t[184],\t[187],\t[189],\t[190],\t[191],\t[198],\t[199],\t[202],\t[203],\t[204],\t[205],\t[206],\t[208],\t[209],\t[210],\t[212],\t[214],\t[215],\t[216],\t[217],\t[219],\t[220],\t[223],\t[229],\t[233],\t[234],\t[235])VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,\t@102,\t@103,\t@105,\t@106,\t@109,\t@111,\t@112,\t@114,\t@120,\t@123,\t@129,\t@131,\t@133,\t@139,\t@144,\t@146,\t@147,\t@148,\t@149,\t@150,\t@151,\t@154,\t@156,\t@157,\t@158,\t@160,\t@161,\t@162,\t@164,\t@167,\t@169,\t@170,\t@173,\t@176,\t@178,\t@179,\t@181,\t@184,\t@187,\t@189,\t@190,\t@191,\t@198,\t@199,\t@202,\t@203,\t@204,\t@205,\t@206,\t@208,\t@209,\t@210,\t@212,\t@214,\t@215,\t@216,\t@217,\t@219,\t@220,\t@223,\t@229,\t@233,\t@234,\t@235)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@malband", txtmalband.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@naw_tasjil", txtnawtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@naw_bnka", txtnawbnka.Text);
		cmd.Parameters.AddWithValue("@westga_gshty", txtwestga.Text);
		cmd.Parameters.AddWithValue("@dangdar", txtzhdangdar.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@102", h102.Text);
		cmd.Parameters.AddWithValue("@103", h103.Text);
		cmd.Parameters.AddWithValue("@105", h105.Text);
		cmd.Parameters.AddWithValue("@106", h106.Text);
		cmd.Parameters.AddWithValue("@109", h109.Text);
		cmd.Parameters.AddWithValue("@111", h111.Text);
		cmd.Parameters.AddWithValue("@112", h112.Text);
		cmd.Parameters.AddWithValue("@114", h114.Text);
		cmd.Parameters.AddWithValue("@120", h120.Text);
		cmd.Parameters.AddWithValue("@123", h123.Text);
		cmd.Parameters.AddWithValue("@129", h129.Text);
		cmd.Parameters.AddWithValue("@131", h131.Text);
		cmd.Parameters.AddWithValue("@133", h133.Text);
		cmd.Parameters.AddWithValue("@139", h139.Text);
		cmd.Parameters.AddWithValue("@144", h144.Text);
		cmd.Parameters.AddWithValue("@146", h146.Text);
		cmd.Parameters.AddWithValue("@147", h147.Text);
		cmd.Parameters.AddWithValue("@148", h148.Text);
		cmd.Parameters.AddWithValue("@149", h149.Text);
		cmd.Parameters.AddWithValue("@150", h150.Text);
		cmd.Parameters.AddWithValue("@151", h151.Text);
		cmd.Parameters.AddWithValue("@154", h154.Text);
		cmd.Parameters.AddWithValue("@156", h156.Text);
		cmd.Parameters.AddWithValue("@157", h157.Text);
		cmd.Parameters.AddWithValue("@158", h158.Text);
		cmd.Parameters.AddWithValue("@160", h160.Text);
		cmd.Parameters.AddWithValue("@161", h161.Text);
		cmd.Parameters.AddWithValue("@162", h162.Text);
		cmd.Parameters.AddWithValue("@164", h164.Text);
		cmd.Parameters.AddWithValue("@167", h167.Text);
		cmd.Parameters.AddWithValue("@169", h169.Text);
		cmd.Parameters.AddWithValue("@170", h170.Text);
		cmd.Parameters.AddWithValue("@173", h173.Text);
		cmd.Parameters.AddWithValue("@176", h176.Text);
		cmd.Parameters.AddWithValue("@178", h178.Text);
		cmd.Parameters.AddWithValue("@179", h179.Text);
		cmd.Parameters.AddWithValue("@181", h181.Text);
		cmd.Parameters.AddWithValue("@184", h184.Text);
		cmd.Parameters.AddWithValue("@187", h187.Text);
		cmd.Parameters.AddWithValue("@189", h189.Text);
		cmd.Parameters.AddWithValue("@190", h190.Text);
		cmd.Parameters.AddWithValue("@191", h191.Text);
		cmd.Parameters.AddWithValue("@198", h198.Text);
		cmd.Parameters.AddWithValue("@199", h199.Text);
		cmd.Parameters.AddWithValue("@202", h202.Text);
		cmd.Parameters.AddWithValue("@203", h203.Text);
		cmd.Parameters.AddWithValue("@204", h204.Text);
		cmd.Parameters.AddWithValue("@205", h205.Text);
		cmd.Parameters.AddWithValue("@206", h206.Text);
		cmd.Parameters.AddWithValue("@208", h208.Text);
		cmd.Parameters.AddWithValue("@209", h209.Text);
		cmd.Parameters.AddWithValue("@210", h210.Text);
		cmd.Parameters.AddWithValue("@212", h212.Text);
		cmd.Parameters.AddWithValue("@214", h214.Text);
		cmd.Parameters.AddWithValue("@215", h215.Text);
		cmd.Parameters.AddWithValue("@216", h216.Text);
		cmd.Parameters.AddWithValue("@217", h217.Text);
		cmd.Parameters.AddWithValue("@219", h219.Text);
		cmd.Parameters.AddWithValue("@220", h220.Text);
		cmd.Parameters.AddWithValue("@223", h223.Text);
		cmd.Parameters.AddWithValue("@229", h229.Text);
		cmd.Parameters.AddWithValue("@233", h233.Text);
		cmd.Parameters.AddWithValue("@234", h234.Text);
		cmd.Parameters.AddWithValue("@235", h235.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
	}

	private void btnadd_Click(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty || comwestga.Text == string.Empty)
		{
			MessageBox.Show("ئەم ژمارە دەنگدەرە لەم پارێزگایە نیە یان هەڵەیە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (btnadd.Text == "تۆمارکردن")
		{
			add_taybat_all();
		}
		else if (btnadd.Text == "Update")
		{
			Update_taybat_all();
		}
	}

	private void comwestga_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty)
		{
			MessageBox.Show("تکایە ژمارەی بنکەی دەنگدان بنوسە ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		string query = "SELECT *\r\n                         FROM taybat_all \r\n                         WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand command = new SqlCommand(query, connectionString);
		connectionString.Open();
		using SqlDataReader reader = command.ExecuteReader();
		if (reader.Read())
		{
			txtwaraqadrost.Text = reader["waraqa_rast"].ToString();
			txtwaraqaybatl.Text = reader["waraqapochal"].ToString();
			s101.Text = reader["s101"].ToString();
			s104.Text = reader["s104"].ToString();
			s110.Text = reader["s110"].ToString();
			s113.Text = reader["s113"].ToString();
			s114.Text = reader["s114"].ToString();
			s115.Text = reader["s115"].ToString();
			s116.Text = reader["s116"].ToString();
			s117.Text = reader["s117"].ToString();
			s119.Text = reader["s119"].ToString();
			s121.Text = reader["s121"].ToString();
			s122.Text = reader["s122"].ToString();
			s123.Text = reader["s123"].ToString();
			s124.Text = reader["s124"].ToString();
			s125.Text = reader["s125"].ToString();
			s128.Text = reader["s128"].ToString();
			s129.Text = reader["s129"].ToString();
			s130.Text = reader["s130"].ToString();
			s133.Text = reader["s133"].ToString();
			s135.Text = reader["s135"].ToString();
			s136.Text = reader["s136"].ToString();
			s137.Text = reader["s137"].ToString();
			s138.Text = reader["s138"].ToString();
			s145.Text = reader["s145"].ToString();
			s147.Text = reader["s147"].ToString();
			s148.Text = reader["s148"].ToString();
			s153.Text = reader["s153"].ToString();
			s157.Text = reader["s157"].ToString();
			s161.Text = reader["s161"].ToString();
			s162.Text = reader["s162"].ToString();
			s164.Text = reader["s164"].ToString();
			s165.Text = reader["s165"].ToString();
			s166.Text = reader["s166"].ToString();
			s168.Text = reader["s168"].ToString();
			s169.Text = reader["s169"].ToString();
			s171.Text = reader["s171"].ToString();
			s174.Text = reader["s174"].ToString();
			s180.Text = reader["s180"].ToString();
			s182.Text = reader["s182"].ToString();
			s183.Text = reader["s183"].ToString();
			s185.Text = reader["s185"].ToString();
			s190.Text = reader["s190"].ToString();
			s192.Text = reader["s192"].ToString();
			s193.Text = reader["s193"].ToString();
			s194.Text = reader["s194"].ToString();
			s198.Text = reader["s198"].ToString();
			s201.Text = reader["s201"].ToString();
			s207.Text = reader["s207"].ToString();
			s218.Text = reader["s218"].ToString();
			s221.Text = reader["s221"].ToString();
			s226.Text = reader["s226"].ToString();
			s228.Text = reader["s228"].ToString();
			s230.Text = reader["s230"].ToString();
			s231.Text = reader["s231"].ToString();
			s236.Text = reader["s236"].ToString();
			h102.Text = reader["h102"].ToString();
			h103.Text = reader["h103"].ToString();
			h105.Text = reader["h105"].ToString();
			h106.Text = reader["h106"].ToString();
			h109.Text = reader["h109"].ToString();
			h111.Text = reader["h111"].ToString();
			h112.Text = reader["h112"].ToString();
			h114.Text = reader["h114"].ToString();
			h120.Text = reader["h120"].ToString();
			h123.Text = reader["h123"].ToString();
			h129.Text = reader["h129"].ToString();
			h131.Text = reader["h131"].ToString();
			h133.Text = reader["h133"].ToString();
			h139.Text = reader["h139"].ToString();
			h144.Text = reader["h144"].ToString();
			h146.Text = reader["h146"].ToString();
			h147.Text = reader["h147"].ToString();
			h148.Text = reader["h148"].ToString();
			h149.Text = reader["h149"].ToString();
			h150.Text = reader["h150"].ToString();
			h151.Text = reader["h151"].ToString();
			h154.Text = reader["h154"].ToString();
			h156.Text = reader["h156"].ToString();
			h157.Text = reader["h157"].ToString();
			h158.Text = reader["h158"].ToString();
			h160.Text = reader["h160"].ToString();
			h161.Text = reader["h161"].ToString();
			h162.Text = reader["h162"].ToString();
			h164.Text = reader["h164"].ToString();
			h167.Text = reader["h167"].ToString();
			h169.Text = reader["h169"].ToString();
			h170.Text = reader["h170"].ToString();
			h173.Text = reader["h173"].ToString();
			h176.Text = reader["h176"].ToString();
			h178.Text = reader["h178"].ToString();
			h179.Text = reader["h179"].ToString();
			h181.Text = reader["h181"].ToString();
			h184.Text = reader["h184"].ToString();
			h187.Text = reader["h187"].ToString();
			h189.Text = reader["h189"].ToString();
			h190.Text = reader["h190"].ToString();
			h191.Text = reader["h191"].ToString();
			h198.Text = reader["h198"].ToString();
			h199.Text = reader["h199"].ToString();
			h202.Text = reader["h202"].ToString();
			h203.Text = reader["h203"].ToString();
			h204.Text = reader["h204"].ToString();
			h205.Text = reader["h205"].ToString();
			h206.Text = reader["h206"].ToString();
			h208.Text = reader["h208"].ToString();
			h209.Text = reader["h209"].ToString();
			h210.Text = reader["h210"].ToString();
			h212.Text = reader["h212"].ToString();
			h214.Text = reader["h214"].ToString();
			h215.Text = reader["h215"].ToString();
			h216.Text = reader["h216"].ToString();
			h217.Text = reader["h217"].ToString();
			h219.Text = reader["h219"].ToString();
			h220.Text = reader["h220"].ToString();
			h223.Text = reader["h223"].ToString();
			h229.Text = reader["h229"].ToString();
			h233.Text = reader["h233"].ToString();
			h234.Text = reader["h234"].ToString();
			h235.Text = reader["h235"].ToString();
			d107.Text = reader["d107"].ToString();
			d108.Text = reader["d108"].ToString();
			d114.Text = reader["d114"].ToString();
			d118.Text = reader["d118"].ToString();
			d126.Text = reader["d126"].ToString();
			d127.Text = reader["d127"].ToString();
			d129.Text = reader["d129"].ToString();
			d132.Text = reader["d132"].ToString();
			d133.Text = reader["d133"].ToString();
			d134.Text = reader["d134"].ToString();
			d140.Text = reader["d140"].ToString();
			d141.Text = reader["d141"].ToString();
			d142.Text = reader["d142"].ToString();
			d143.Text = reader["d143"].ToString();
			d147.Text = reader["d147"].ToString();
			d148.Text = reader["d148"].ToString();
			d152.Text = reader["d152"].ToString();
			d155.Text = reader["d155"].ToString();
			d157.Text = reader["d157"].ToString();
			d159.Text = reader["d159"].ToString();
			d161.Text = reader["d161"].ToString();
			d162.Text = reader["d162"].ToString();
			d163.Text = reader["d163"].ToString();
			d164.Text = reader["d164"].ToString();
			d169.Text = reader["d169"].ToString();
			d175.Text = reader["d175"].ToString();
			d177.Text = reader["d177"].ToString();
			d186.Text = reader["d186"].ToString();
			d188.Text = reader["d188"].ToString();
			d190.Text = reader["d190"].ToString();
			d195.Text = reader["d195"].ToString();
			d196.Text = reader["d196"].ToString();
			d197.Text = reader["d197"].ToString();
			d200.Text = reader["d200"].ToString();
			d211.Text = reader["d211"].ToString();
			d213.Text = reader["d213"].ToString();
			d222.Text = reader["d222"].ToString();
			d224.Text = reader["d224"].ToString();
			d225.Text = reader["d225"].ToString();
			d227.Text = reader["d227"].ToString();
			d232.Text = reader["d232"].ToString();
			hl114.Text = reader["hl114"].ToString();
			hl123.Text = reader["hl123"].ToString();
			hl129.Text = reader["hl129"].ToString();
			hl133.Text = reader["hl133"].ToString();
			hl147.Text = reader["hl147"].ToString();
			hl148.Text = reader["hl148"].ToString();
			hl157.Text = reader["hl157"].ToString();
			hl161.Text = reader["hl161"].ToString();
			hl162.Text = reader["hl162"].ToString();
			hl164.Text = reader["hl164"].ToString();
			hl169.Text = reader["hl169"].ToString();
			hl172.Text = reader["hl172"].ToString();
			hl190.Text = reader["hl190"].ToString();
			hl198.Text = reader["hl198"].ToString();
			btnadd.Text = "Update";
			txtcoler();
		}
		else
		{
			all_txt0();
			txtcoler();
			btnadd.Text = "تۆمارکردن";
		}
		connectionString.Close();
	}

	private void txtcoler()
	{
		List<TextBox> textBoxes = new List<TextBox>
		{
			s101, s104, s110, s113, s114, s115, s116, s117, s119, s121,
			s122, s123, s124, s125, s128, s129, s130, s133, s135, s136,
			s137, s138, s145, s147, s148, s153, s157, s161, s162, s164,
			s165, s166, s168, s169, s171, s174, s180, s182, s183, s185,
			s190, s192, s193, s194, s198, s201, s207, s218, s221, s226,
			s228, s230, s231, s236, h102, h103, h105, h106, h109, h111,
			h112, h114, h120, h123, h129, h131, h133, h139, h144, h146,
			h147, h148, h149, h150, h151, h154, h156, h157, h158, h160,
			h161, h162, h164, h167, h169, h170, h173, h176, h178, h179,
			h181, h184, h187, h189, h190, h191, h198, h199, h202, h203,
			h204, h205, h206, h208, h209, h210, h212, h214, h215, h216,
			h217, h219, h220, h223, h229, h233, h234, h235, d107, d108,
			d114, d118, d126, d127, d129, d132, d133, d134, d140, d141,
			d142, d143, d147, d148, d152, d155, d157, d159, d161, d162,
			d163, d164, d169, d175, d177, d186, d188, d190, d195, d196,
			d197, d200, d211, d213, d222, d224, d225, d227, d232, hl114,
			hl123, hl129, hl133, hl147, hl148, hl157, hl161, hl162, hl164, hl169,
			hl172, hl190, hl198
		};
		foreach (TextBox textBox in textBoxes)
		{
			if (textBox.Text == "0")
			{
				textBox.ForeColor = Color.FromArgb(255, 192, 192);
			}
			else
			{
				textBox.ForeColor = Color.Black;
			}
		}
	}

	private void all_txt0()
	{
		txtwaraqadrost.Text = "0";
		txtwaraqaybatl.Text = "0";
		s101.Text = "0";
		s104.Text = "0";
		s110.Text = "0";
		s113.Text = "0";
		s114.Text = "0";
		s115.Text = "0";
		s116.Text = "0";
		s117.Text = "0";
		s119.Text = "0";
		s121.Text = "0";
		s122.Text = "0";
		s123.Text = "0";
		s124.Text = "0";
		s125.Text = "0";
		s128.Text = "0";
		s129.Text = "0";
		s130.Text = "0";
		s133.Text = "0";
		s135.Text = "0";
		s136.Text = "0";
		s137.Text = "0";
		s138.Text = "0";
		s145.Text = "0";
		s147.Text = "0";
		s148.Text = "0";
		s153.Text = "0";
		s157.Text = "0";
		s161.Text = "0";
		s162.Text = "0";
		s164.Text = "0";
		s165.Text = "0";
		s166.Text = "0";
		s168.Text = "0";
		s169.Text = "0";
		s171.Text = "0";
		s174.Text = "0";
		s180.Text = "0";
		s182.Text = "0";
		s183.Text = "0";
		s185.Text = "0";
		s190.Text = "0";
		s192.Text = "0";
		s193.Text = "0";
		s194.Text = "0";
		s198.Text = "0";
		s201.Text = "0";
		s207.Text = "0";
		s218.Text = "0";
		s221.Text = "0";
		s226.Text = "0";
		s228.Text = "0";
		s230.Text = "0";
		s231.Text = "0";
		s236.Text = "0";
		h102.Text = "0";
		h103.Text = "0";
		h105.Text = "0";
		h106.Text = "0";
		h109.Text = "0";
		h111.Text = "0";
		h112.Text = "0";
		h114.Text = "0";
		h120.Text = "0";
		h123.Text = "0";
		h129.Text = "0";
		h131.Text = "0";
		h133.Text = "0";
		h139.Text = "0";
		h144.Text = "0";
		h146.Text = "0";
		h147.Text = "0";
		h148.Text = "0";
		h149.Text = "0";
		h150.Text = "0";
		h151.Text = "0";
		h154.Text = "0";
		h156.Text = "0";
		h157.Text = "0";
		h158.Text = "0";
		h160.Text = "0";
		h161.Text = "0";
		h162.Text = "0";
		h164.Text = "0";
		h167.Text = "0";
		h169.Text = "0";
		h170.Text = "0";
		h173.Text = "0";
		h176.Text = "0";
		h178.Text = "0";
		h179.Text = "0";
		h181.Text = "0";
		h184.Text = "0";
		h187.Text = "0";
		h189.Text = "0";
		h190.Text = "0";
		h191.Text = "0";
		h198.Text = "0";
		h199.Text = "0";
		h202.Text = "0";
		h203.Text = "0";
		h204.Text = "0";
		h205.Text = "0";
		h206.Text = "0";
		h208.Text = "0";
		h209.Text = "0";
		h210.Text = "0";
		h212.Text = "0";
		h214.Text = "0";
		h215.Text = "0";
		h216.Text = "0";
		h217.Text = "0";
		h219.Text = "0";
		h220.Text = "0";
		h223.Text = "0";
		h229.Text = "0";
		h233.Text = "0";
		h234.Text = "0";
		h235.Text = "0";
		d107.Text = "0";
		d108.Text = "0";
		d114.Text = "0";
		d118.Text = "0";
		d126.Text = "0";
		d127.Text = "0";
		d129.Text = "0";
		d132.Text = "0";
		d133.Text = "0";
		d134.Text = "0";
		d140.Text = "0";
		d141.Text = "0";
		d142.Text = "0";
		d143.Text = "0";
		d147.Text = "0";
		d148.Text = "0";
		d152.Text = "0";
		d155.Text = "0";
		d157.Text = "0";
		d159.Text = "0";
		d161.Text = "0";
		d162.Text = "0";
		d163.Text = "0";
		d164.Text = "0";
		d169.Text = "0";
		d175.Text = "0";
		d177.Text = "0";
		d186.Text = "0";
		d188.Text = "0";
		d190.Text = "0";
		d195.Text = "0";
		d196.Text = "0";
		d197.Text = "0";
		d200.Text = "0";
		d211.Text = "0";
		d213.Text = "0";
		d222.Text = "0";
		d224.Text = "0";
		d225.Text = "0";
		d227.Text = "0";
		d232.Text = "0";
		hl114.Text = "0";
		hl123.Text = "0";
		hl129.Text = "0";
		hl133.Text = "0";
		hl147.Text = "0";
		hl148.Text = "0";
		hl157.Text = "0";
		hl161.Text = "0";
		hl162.Text = "0";
		hl164.Text = "0";
		hl169.Text = "0";
		hl172.Text = "0";
		hl190.Text = "0";
		hl198.Text = "0";
	}

	private void h102_Click(object sender, EventArgs e)
	{
		h102.Text = "";
	}

	private void h103_Click(object sender, EventArgs e)
	{
		h103.Text = "";
	}

	private void h105_Click(object sender, EventArgs e)
	{
		h105.Text = "";
	}

	private void h106_Click(object sender, EventArgs e)
	{
		h106.Text = "";
	}

	private void h109_Click(object sender, EventArgs e)
	{
		h109.Text = "";
	}

	private void h111_Click(object sender, EventArgs e)
	{
		h111.Text = "";
	}

	private void h112_Click(object sender, EventArgs e)
	{
		h112.Text = "";
	}

	private void h114_Click(object sender, EventArgs e)
	{
		h114.Text = "";
	}

	private void h120_Click(object sender, EventArgs e)
	{
		h120.Text = "";
	}

	private void h123_Click(object sender, EventArgs e)
	{
		h123.Text = "";
	}

	private void h129_Click(object sender, EventArgs e)
	{
		h129.Text = "";
	}

	private void h131_Click(object sender, EventArgs e)
	{
		h131.Text = "";
	}

	private void h133_Click(object sender, EventArgs e)
	{
		h133.Text = "";
	}

	private void h139_Click(object sender, EventArgs e)
	{
		h139.Text = "";
	}

	private void h144_Click(object sender, EventArgs e)
	{
		h144.Text = "";
	}

	private void h146_Click(object sender, EventArgs e)
	{
		h146.Text = "";
	}

	private void h147_Click(object sender, EventArgs e)
	{
		h147.Text = "";
	}

	private void h148_Click(object sender, EventArgs e)
	{
		h148.Text = "";
	}

	private void h149_Click(object sender, EventArgs e)
	{
		h149.Text = "";
	}

	private void h150_Click(object sender, EventArgs e)
	{
		h150.Text = "";
	}

	private void h151_Click(object sender, EventArgs e)
	{
		h151.Text = "";
	}

	private void h154_Click(object sender, EventArgs e)
	{
		h154.Text = "";
	}

	private void h156_Click(object sender, EventArgs e)
	{
		h156.Text = "";
	}

	private void h157_Click(object sender, EventArgs e)
	{
		h157.Text = "";
	}

	private void h158_Click(object sender, EventArgs e)
	{
		h158.Text = "";
	}

	private void h160_Click(object sender, EventArgs e)
	{
		h160.Text = "";
	}

	private void h161_Click(object sender, EventArgs e)
	{
		h161.Text = "";
	}

	private void h162_Click(object sender, EventArgs e)
	{
		h162.Text = "";
	}

	private void h164_Click(object sender, EventArgs e)
	{
		h164.Text = "";
	}

	private void h167_Click(object sender, EventArgs e)
	{
		h167.Text = "";
	}

	private void h169_Click(object sender, EventArgs e)
	{
		h169.Text = "";
	}

	private void h170_Click(object sender, EventArgs e)
	{
		h170.Text = "";
	}

	private void h173_Click(object sender, EventArgs e)
	{
		h173.Text = "";
	}

	private void h176_Click(object sender, EventArgs e)
	{
		h176.Text = "";
	}

	private void h178_Click(object sender, EventArgs e)
	{
		h178.Text = "";
	}

	private void h235_Click(object sender, EventArgs e)
	{
		h235.Text = "";
	}

	private void h234_Click(object sender, EventArgs e)
	{
		h234.Text = "";
	}

	private void h233_Click(object sender, EventArgs e)
	{
		h233.Text = "";
	}

	private void h229_Click(object sender, EventArgs e)
	{
		h229.Text = "";
	}

	private void h223_Click(object sender, EventArgs e)
	{
		h223.Text = "";
	}

	private void h220_Click(object sender, EventArgs e)
	{
		h220.Text = "";
	}

	private void h219_Click(object sender, EventArgs e)
	{
		h219.Text = "";
	}

	private void h217_Click(object sender, EventArgs e)
	{
		h217.Text = "";
	}

	private void h216_Click(object sender, EventArgs e)
	{
		h216.Text = "";
	}

	private void h215_Click(object sender, EventArgs e)
	{
		h215.Text = "";
	}

	private void h214_Click(object sender, EventArgs e)
	{
		h214.Text = "";
	}

	private void h212_Click(object sender, EventArgs e)
	{
		h212.Text = "";
	}

	private void h210_Click(object sender, EventArgs e)
	{
		h210.Text = "";
	}

	private void h209_Click(object sender, EventArgs e)
	{
		h209.Text = "";
	}

	private void h208_Click(object sender, EventArgs e)
	{
		h208.Text = "";
	}

	private void h206_Click(object sender, EventArgs e)
	{
		h206.Text = "";
	}

	private void h205_Click(object sender, EventArgs e)
	{
		h205.Text = "";
	}

	private void h204_Click(object sender, EventArgs e)
	{
		h204.Text = "";
	}

	private void h203_Click(object sender, EventArgs e)
	{
		h203.Text = "";
	}

	private void h202_Click(object sender, EventArgs e)
	{
		h202.Text = "";
	}

	private void h199_Click(object sender, EventArgs e)
	{
		h199.Text = "";
	}

	private void h198_Click(object sender, EventArgs e)
	{
		h198.Text = "";
	}

	private void h191_Click(object sender, EventArgs e)
	{
		h191.Text = "";
	}

	private void h190_Click(object sender, EventArgs e)
	{
		h190.Text = "";
	}

	private void h189_Click(object sender, EventArgs e)
	{
		h189.Text = "";
	}

	private void h187_Click(object sender, EventArgs e)
	{
		h187.Text = "";
	}

	private void h184_Click(object sender, EventArgs e)
	{
		h184.Text = "";
	}

	private void button5_Click(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty || comwestga.Text == string.Empty || txtmalband.Text == string.Empty || txtnawbnka.Text == string.Empty || txtcoodtasj.Text == string.Empty)
		{
			MessageBox.Show("تکایە خانەکان پربکەوە", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		else if (MessageBox.Show("Do you wont Delete ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		{
			string qurey1 = "delete from  candid_s  WHERE cood_bnka = " + txtbnkacood.Text + " and westga=" + comwestga.Text;
			string qurey2 = "delete from  candid_h  WHERE cood_bnka = " + txtbnkacood.Text + " and westga=" + comwestga.Text;
			string qurey3 = "delete from  candid_d  WHERE cood_bnka = " + txtbnkacood.Text + " and westga=" + comwestga.Text;
			string qurey4 = "delete from  candid_hl  WHERE cood_bnka = " + txtbnkacood.Text + " and westga=" + comwestga.Text;
			string qurey = "delete from taybat_all  WHERE cood_bnka = " + txtbnkacood.Text + " and westga=" + comwestga.Text;
			SqlCommand cmd = new SqlCommand(qurey, connectionString);
			SqlCommand cmd1 = new SqlCommand(qurey1, connectionString);
			SqlCommand cmd2 = new SqlCommand(qurey2, connectionString);
			SqlCommand cmd3 = new SqlCommand(qurey3, connectionString);
			connectionString.Open();
			MessageBox.Show("Deleted ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			cmd.ExecuteNonQuery();
			cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			cmd3.ExecuteNonQuery();
			all_txt0();
			connectionString.Close();
			add_update_delete();
		}
	}

	private void txtbnkacood_TextChanged(object sender, EventArgs e)
	{
		Regex r = new Regex("^[0-9]{6}$");
		if (r.IsMatch(txtbnkacood.Text))
		{
			txtbnkacood.BackColor = Color.LightGreen;
		}
		else
		{
			txtbnkacood.BackColor = Color.LightPink;
		}
	}

	private void txtbnkacood_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			txtbnkacood.Text = "0";
		}
	}

	private void h102_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h102.Text = "0";
		}
	}

	private void h103_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h103.Text = "0";
		}
	}

	private void h105_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h105.Text = "0";
		}
	}

	private void h106_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h106.Text = "0";
		}
	}

	private void h109_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h109.Text = "0";
		}
	}

	private void h111_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h111.Text = "0";
		}
	}

	private void h112_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h112.Text = "0";
		}
	}

	private void h114_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h114.Text = "0";
		}
	}

	private void h120_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h120.Text = "0";
		}
	}

	private void h123_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h123.Text = "0";
		}
	}

	private void h129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h129.Text = "0";
		}
	}

	private void h173_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h173.Text = "0";
		}
	}

	private void h176_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h176.Text = "0";
		}
	}

	private void h178_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h178.Text = "0";
		}
	}

	private void h179_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h179.Text = "0";
		}
	}

	private void h181_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h181.Text = "0";
		}
	}

	private void h184_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h184.Text = "0";
		}
	}

	private void h187_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h187.Text = "0";
		}
	}

	private void h189_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h189.Text = "0";
		}
	}

	private void h190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h190.Text = "0";
		}
	}

	private void h191_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h191.Text = "0";
		}
	}

	private void h198_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h198.Text = "0";
		}
	}

	private void h131_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h131.Text = "0";
		}
	}

	private void h199_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h199.Text = "0";
		}
	}

	private void h133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h133.Text = "0";
		}
	}

	private void h202_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h202.Text = "0";
		}
	}

	private void h139_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h139.Text = "0";
		}
	}

	private void h144_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h144.Text = "0";
		}
	}

	private void h146_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h146.Text = "0";
		}
	}

	private void h147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h147.Text = "0";
		}
	}

	private void h148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h148.Text = "0";
		}
	}

	private void h149_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h149.Text = "0";
		}
	}

	private void h150_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h150.Text = "0";
		}
	}

	private void h151_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h151.Text = "0";
		}
	}

	private void h154_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h154.Text = "0";
		}
	}

	private void h156_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h156.Text = "0";
		}
	}

	private void h157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h157.Text = "0";
		}
	}

	private void h158_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h158.Text = "0";
		}
	}

	private void h160_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h160.Text = "0";
		}
	}

	private void h161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h161.Text = "0";
		}
	}

	private void h162_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h162.Text = "0";
		}
	}

	private void h164_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h164.Text = "0";
		}
	}

	private void h167_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h167.Text = "0";
		}
	}

	private void h169_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h169.Text = "0";
		}
	}

	private void h170_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h170.Text = "0";
		}
	}

	private void h203_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h203.Text = "0";
		}
	}

	private void h204_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h204.Text = "0";
		}
	}

	private void h205_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h205.Text = "0";
		}
	}

	private void h206_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h206.Text = "0";
		}
	}

	private void h208_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h208.Text = "0";
		}
	}

	private void h209_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h209.Text = "0";
		}
	}

	private void h210_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h210.Text = "0";
		}
	}

	private void h212_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h212.Text = "0";
		}
	}

	private void h214_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h214.Text = "0";
		}
	}

	private void h215_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h215.Text = "0";
		}
	}

	private void h216_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h216.Text = "0";
		}
	}

	private void h217_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h217.Text = "0";
		}
	}

	private void h219_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h219.Text = "0";
		}
	}

	private void h220_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h220.Text = "0";
		}
	}

	private void h223_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h223.Text = "0";
		}
	}

	private void h229_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h229.Text = "0";
		}
	}

	private void h233_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h233.Text = "0";
		}
	}

	private void h234_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h234.Text = "0";
		}
	}

	private void h235_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h235.Text = "0";
		}
	}

	private void s101_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s101.Text = "0";
		}
	}

	private void s104_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s104.Text = "0";
		}
	}

	private void s110_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s110.Text = "0";
		}
	}

	private void s113_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s113.Text = "0";
		}
	}

	private void s114_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s114.Text = "0";
		}
	}

	private void s115_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s115.Text = "0";
		}
	}

	private void s116_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s116.Text = "0";
		}
	}

	private void s117_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s117.Text = "0";
		}
	}

	private void s119_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s119.Text = "0";
		}
	}

	private void s121_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s121.Text = "0";
		}
	}

	private void s122_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s122.Text = "0";
		}
	}

	private void s162_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s162.Text = "0";
		}
	}

	private void s164_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s164.Text = "0";
		}
	}

	private void s165_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s165.Text = "0";
		}
	}

	private void s166_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s166.Text = "0";
		}
	}

	private void s168_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s168.Text = "0";
		}
	}

	private void s169_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s169.Text = "0";
		}
	}

	private void s171_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s171.Text = "0";
		}
	}

	private void s174_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s174.Text = "0";
		}
	}

	private void s180_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s180.Text = "0";
		}
	}

	private void s182_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s182.Text = "0";
		}
	}

	private void s183_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s183.Text = "0";
		}
	}

	private void s123_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s123.Text = "0";
		}
	}

	private void s124_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s124.Text = "0";
		}
	}

	private void s125_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s125.Text = "0";
		}
	}

	private void s128_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s128.Text = "0";
		}
	}

	private void s129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s129.Text = "0";
		}
	}

	private void s130_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s130.Text = "0";
		}
	}

	private void s133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s133.Text = "0";
		}
	}

	private void s135_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s135.Text = "0";
		}
	}

	private void s136_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s136.Text = "0";
		}
	}

	private void s137_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s137.Text = "0";
		}
	}

	private void s138_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s138.Text = "0";
		}
	}

	private void s145_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s145.Text = "0";
		}
	}

	private void s147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s147.Text = "0";
		}
	}

	private void s148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s148.Text = "0";
		}
	}

	private void s153_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s153.Text = "0";
		}
	}

	private void s157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s157.Text = "0";
		}
	}

	private void s161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s161.Text = "0";
		}
	}

	private void s185_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s185.Text = "0";
		}
	}

	private void s190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s190.Text = "0";
		}
	}

	private void s192_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s192.Text = "0";
		}
	}

	private void s193_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s193.Text = "0";
		}
	}

	private void s194_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s194.Text = "0";
		}
	}

	private void s198_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s198.Text = "0";
		}
	}

	private void s201_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s201.Text = "0";
		}
	}

	private void s207_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s207.Text = "0";
		}
	}

	private void s218_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s218.Text = "0";
		}
	}

	private void s221_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s221.Text = "0";
		}
	}

	private void s226_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s226.Text = "0";
		}
	}

	private void s228_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s228.Text = "0";
		}
	}

	private void s230_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s230.Text = "0";
		}
	}

	private void s231_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s231.Text = "0";
		}
	}

	private void s236_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s236.Text = "0";
		}
	}

	private void d107_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d107.Text = "0";
		}
	}

	private void d108_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d108.Text = "0";
		}
	}

	private void d114_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d114.Text = "0";
		}
	}

	private void d118_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d118.Text = "0";
		}
	}

	private void d126_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d126.Text = "0";
		}
	}

	private void d127_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d127.Text = "0";
		}
	}

	private void d129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d129.Text = "0";
		}
	}

	private void d132_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d132.Text = "0";
		}
	}

	private void d133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d133.Text = "0";
		}
	}

	private void d134_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d134.Text = "0";
		}
	}

	private void d140_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d140.Text = "0";
		}
	}

	private void d162_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d162.Text = "0";
		}
	}

	private void d163_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d163.Text = "0";
		}
	}

	private void d164_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d164.Text = "0";
		}
	}

	private void d169_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d169.Text = "0";
		}
	}

	private void d177_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d177.Text = "0";
		}
	}

	private void d186_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d186.Text = "0";
		}
	}

	private void d188_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d188.Text = "0";
		}
	}

	private void d190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d190.Text = "0";
		}
	}

	private void d195_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d195.Text = "0";
		}
	}

	private void d141_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d141.Text = "0";
		}
	}

	private void d196_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d196.Text = "0";
		}
	}

	private void d197_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d197.Text = "0";
		}
	}

	private void d200_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d200.Text = "0";
		}
	}

	private void d211_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d211.Text = "0";
		}
	}

	private void d213_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d213.Text = "0";
		}
	}

	private void d147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d147.Text = "0";
		}
	}

	private void d143_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d143.Text = "0";
		}
	}

	private void d142_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d142.Text = "0";
		}
	}

	private void d148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d148.Text = "0";
		}
	}

	private void d152_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d152.Text = "0";
		}
	}

	private void d155_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d155.Text = "0";
		}
	}

	private void d157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d157.Text = "0";
		}
	}

	private void d159_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d159.Text = "0";
		}
	}

	private void d161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d161.Text = "0";
		}
	}

	private void d232_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d232.Text = "0";
		}
	}

	private void d227_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d227.Text = "0";
		}
	}

	private void d225_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d225.Text = "0";
		}
	}

	private void d224_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d224.Text = "0";
		}
	}

	private void d222_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d222.Text = "0";
		}
	}

	private void hl114_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl114.Text = "0";
		}
	}

	private void hl123_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void hl123_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl123.Text = "0";
		}
	}

	private void hl129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl129.Text = "0";
		}
	}

	private void hl133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl133.Text = "0";
		}
	}

	private void hl147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl147.Text = "0";
		}
	}

	private void hl148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl148.Text = "0";
		}
	}

	private void hl157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl157.Text = "0";
		}
	}

	private void hl161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl161.Text = "0";
		}
	}

	private void hl162_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl162.Text = "0";
		}
	}

	private void hl164_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl164.Text = "0";
		}
	}

	private void hl169_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl169.Text = "0";
		}
	}

	private void hl172_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl172.Text = "0";
		}
	}

	private void hl190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl190.Text = "0";
		}
	}

	private void hl198_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl198.Text = "0";
		}
	}

	private void txtwaraqadrost_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			txtwaraqadrost.Text = "0";
		}
	}

	private void txtwaraqaybatl_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			txtwaraqaybatl.Text = "0";
		}
	}

	private void txtbnkacood_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h102_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h103_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h105_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h106_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h109_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h111_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h112_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h114_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h120_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h123_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h173_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h176_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h178_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h179_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h181_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h184_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h187_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h189_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h190_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h191_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h129_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h198_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h131_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h199_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h133_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h202_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h139_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h203_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h144_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h204_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h205_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h147_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h206_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h208_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h148_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h209_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h149_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h150_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h210_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h212_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h151_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h154_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h214_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h156_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h215_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h216_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h157_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h158_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h160_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h219_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h217_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h161_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h162_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h164_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h167_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h169_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h234_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h233_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h229_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h223_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h220_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s161_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s157_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s153_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s148_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s147_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s145_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s138_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s137_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s236_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s231_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s230_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s228_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s226_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s221_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s218_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s207_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s201_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s198_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s194_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s128_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s129_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s130_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s133_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s135_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s136_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s193_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s192_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s190_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s185_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s123_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s122_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s183_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s121_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s182_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s119_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s180_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s117_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s116_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s115_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s114_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s113_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s110_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s104_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s101_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s162_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s164_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s165_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s166_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s168_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s169_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s171_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s174_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void txtwaraqadrost_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void txtwaraqaybatl_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d107_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d108_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d114_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d118_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d126_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d127_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d129_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d132_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d133_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d134_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d162_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d163_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d164_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d169_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d175_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d175_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d175.Text = "0";
		}
	}

	private void d177_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d186_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d188_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d190_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d195_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d140_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d196_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d197_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d141_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d142_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d200_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d143_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d211_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d213_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d147_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d148_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d222_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d224_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d225_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d227_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d232_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d159_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d157_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d155_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d152_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d161_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl114_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl123_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl129_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl133_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl147_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl148_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl157_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl161_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl162_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl164_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl169_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl172_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl190_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl198_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Candid_h ca = new Candid_h();
		ca.Visible = true;
		ca.txtparezga.Text = txtparezga.Text;
		ca.txtcoodtasj.Text = txtcoodtasj.Text;
		ca.txtbnkacood.Text = txtbnkacood.Text;
		ca.txtnawbnka.Text = txtnawbnka.Text;
		ca.txtwestga.Text = txtwestga.Text;
		ca.lbl_taswit.Text = labljorydangdan.Text;
	}

	private void btnadd_MouseMove(object sender, MouseEventArgs e)
	{
		btnadd.BackColor = Color.Red;
	}

	private void tableLayoutPanel3_MouseMove(object sender, MouseEventArgs e)
	{
		btnadd.BackColor = Color.FromArgb(43, 196, 138);
	}

	private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
	{
		btnadd.BackColor = Color.FromArgb(43, 196, 138);
	}

	private void label4_MouseMove(object sender, MouseEventArgs e)
	{
		btnadd.BackColor = Color.FromArgb(43, 196, 138);
	}

	private void comwestga_MouseMove(object sender, MouseEventArgs e)
	{
		btnadd.BackColor = Color.FromArgb(43, 196, 138);
	}

	private void button3_MouseMove(object sender, MouseEventArgs e)
	{
		btnadd.BackColor = Color.FromArgb(43, 196, 138);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Candid_T ca = new Candid_T();
		ca.Visible = true;
		ca.txtparezga.Text = txtparezga.Text;
		ca.txtcoodtasj.Text = txtcoodtasj.Text;
		ca.txtbnkacood.Text = txtbnkacood.Text;
		ca.txtnawbnka.Text = txtnawbnka.Text;
		ca.txtwestga.Text = txtwestga.Text;
		ca.lbl_taswit.Text = labljorydangdan.Text;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Candid_d ca = new Candid_d();
		ca.Visible = true;
		ca.txtparezga.Text = txtparezga.Text;
		ca.txtcoodtasj.Text = txtcoodtasj.Text;
		ca.txtbnkacood.Text = txtbnkacood.Text;
		ca.txtnawbnka.Text = txtnawbnka.Text;
		ca.txtwestga.Text = txtwestga.Text;
		ca.lbl_taswit.Text = labljorydangdan.Text;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Candid_hl ca = new Candid_hl();
		ca.Visible = true;
		ca.txtparezga.Text = txtparezga.Text;
		ca.txtcoodtasj.Text = txtcoodtasj.Text;
		ca.txtbnkacood.Text = txtbnkacood.Text;
		ca.txtnawbnka.Text = txtnawbnka.Text;
		ca.txtwestga.Text = txtwestga.Text;
		ca.lbl_taswit.Text = labljorydangdan.Text;
	}

	private void label26_Click(object sender, EventArgs e)
	{
	}

	private void h102_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h103_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h105_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h106_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h109_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h111_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h112_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h114_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h120_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h123_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h173_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h176_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h178_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h179_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h181_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h184_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h187_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h189_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h190_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h191_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s101_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s104_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s110_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s113_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s114_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s115_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s116_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s117_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s119_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s121_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s162_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s164_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s165_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s166_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s168_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s169_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s171_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s174_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s180_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s182_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d107_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d108_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d114_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d118_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d126_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d127_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d129_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d132_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d133_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d134_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d162_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d163_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d164_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d169_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d175_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d177_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d186_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d188_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d190_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d195_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl114_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl123_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl129_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl133_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl147_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl148_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl157_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl161_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl162_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl164_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl169_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl172_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl190_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void hl198_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h129_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h131_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h133_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h139_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h144_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h146_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h147_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h148_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h149_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h150_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h151_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h198_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h199_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h202_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h203_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h204_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h205_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h206_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h208_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h209_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h210_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h212_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s122_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s123_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s124_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s125_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s128_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s129_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s130_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s133_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s135_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s136_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s137_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s183_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s185_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s190_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s192_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s193_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s194_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s198_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s201_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s207_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s218_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s221_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d140_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d141_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d142_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d143_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d147_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d148_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d152_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d155_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d157_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d159_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d161_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d196_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d197_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d200_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d211_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d213_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d222_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d224_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d225_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d227_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void d232_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h154_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h156_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h157_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h158_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h160_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h161_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h162_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h164_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h167_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h169_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h170_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h214_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h215_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h216_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h217_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h219_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h220_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h223_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h229_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h233_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h234_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void h235_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s138_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s145_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s147_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s148_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s153_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s157_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s161_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s226_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s228_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s230_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s231_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void s236_TextChanged_1(object sender, EventArgs e)
	{
		totals();
	}

	private void txt_total_h_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h102_Leave_1(object sender, EventArgs e)
	{
		if (h102.Text == string.Empty)
		{
			h102.Text = "0";
		}
		if (h102.Text == "0")
		{
			h102.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h102.ForeColor = Color.Black;
		}
	}

	private void h103_Leave_1(object sender, EventArgs e)
	{
		if (h103.Text == string.Empty)
		{
			h103.Text = "0";
		}
		if (h103.Text == "0")
		{
			h103.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h103.ForeColor = Color.Black;
		}
	}

	private void h105_Leave_1(object sender, EventArgs e)
	{
		if (h105.Text == string.Empty)
		{
			h105.Text = "0";
		}
		if (h105.Text == "0")
		{
			h105.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h105.ForeColor = Color.Black;
		}
	}

	private void h106_Leave_1(object sender, EventArgs e)
	{
		if (h106.Text == string.Empty)
		{
			h106.Text = "0";
		}
		if (h106.Text == "0")
		{
			h106.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h106.ForeColor = Color.Black;
		}
	}

	private void h109_Leave_1(object sender, EventArgs e)
	{
		if (h109.Text == string.Empty)
		{
			h109.Text = "0";
		}
		if (h109.Text == "0")
		{
			h109.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h109.ForeColor = Color.Black;
		}
	}

	private void h111_Leave_1(object sender, EventArgs e)
	{
		if (h111.Text == string.Empty)
		{
			h111.Text = "0";
		}
		if (h111.Text == "0")
		{
			h111.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h111.ForeColor = Color.Black;
		}
	}

	private void h112_Leave_1(object sender, EventArgs e)
	{
		if (h112.Text == string.Empty)
		{
			h112.Text = "0";
		}
		if (h112.Text == "0")
		{
			h112.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h112.ForeColor = Color.Black;
		}
	}

	private void h114_Leave_1(object sender, EventArgs e)
	{
		if (h114.Text == string.Empty)
		{
			h114.Text = "0";
		}
		if (h114.Text == "0")
		{
			h114.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h114.ForeColor = Color.Black;
		}
	}

	private void h120_Leave_1(object sender, EventArgs e)
	{
		if (h120.Text == string.Empty)
		{
			h120.Text = "0";
		}
		if (h120.Text == "0")
		{
			h120.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h120.ForeColor = Color.Black;
		}
	}

	private void h123_Leave_1(object sender, EventArgs e)
	{
		if (h123.Text == string.Empty)
		{
			h123.Text = "0";
		}
		if (h123.Text == "0")
		{
			h123.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h123.ForeColor = Color.Black;
		}
	}

	private void h129_Leave_1(object sender, EventArgs e)
	{
		if (h129.Text == string.Empty)
		{
			h129.Text = "0";
		}
		if (h129.Text == "0")
		{
			h129.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h129.ForeColor = Color.Black;
		}
	}

	private void h131_Leave_1(object sender, EventArgs e)
	{
		if (h131.Text == string.Empty)
		{
			h131.Text = "0";
		}
		if (h131.Text == "0")
		{
			h131.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h131.ForeColor = Color.Black;
		}
	}

	private void h139_Leave_1(object sender, EventArgs e)
	{
		if (h139.Text == string.Empty)
		{
			h139.Text = "0";
		}
		if (h139.Text == "0")
		{
			h139.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h139.ForeColor = Color.Black;
		}
	}

	private void h133_Leave_1(object sender, EventArgs e)
	{
		if (h133.Text == string.Empty)
		{
			h133.Text = "0";
		}
		if (h133.Text == "0")
		{
			h133.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h133.ForeColor = Color.Black;
		}
	}

	private void h144_Leave_1(object sender, EventArgs e)
	{
		if (h144.Text == string.Empty)
		{
			h144.Text = "0";
		}
		if (h144.Text == "0")
		{
			h144.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h144.ForeColor = Color.Black;
		}
	}

	private void h146_Leave_1(object sender, EventArgs e)
	{
		if (h146.Text == string.Empty)
		{
			h146.Text = "0";
		}
		if (h146.Text == "0")
		{
			h146.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h146.ForeColor = Color.Black;
		}
	}

	private void h147_Leave_1(object sender, EventArgs e)
	{
		if (h147.Text == string.Empty)
		{
			h147.Text = "0";
		}
		if (h147.Text == "0")
		{
			h147.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h147.ForeColor = Color.Black;
		}
	}

	private void h148_Leave_1(object sender, EventArgs e)
	{
		if (h148.Text == string.Empty)
		{
			h148.Text = "0";
		}
		if (h148.Text == "0")
		{
			h148.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h148.ForeColor = Color.Black;
		}
	}

	private void h149_Leave_1(object sender, EventArgs e)
	{
		if (h149.Text == string.Empty)
		{
			h149.Text = "0";
		}
		if (h149.Text == "0")
		{
			h149.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h149.ForeColor = Color.Black;
		}
	}

	private void h150_Leave_1(object sender, EventArgs e)
	{
		if (h150.Text == string.Empty)
		{
			h150.Text = "0";
		}
		if (h150.Text == "0")
		{
			h150.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h150.ForeColor = Color.Black;
		}
	}

	private void h151_Leave_1(object sender, EventArgs e)
	{
		if (h151.Text == string.Empty)
		{
			h151.Text = "0";
		}
		if (h151.Text == "0")
		{
			h151.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h151.ForeColor = Color.Black;
		}
	}

	private void h154_Leave_1(object sender, EventArgs e)
	{
		if (h154.Text == string.Empty)
		{
			h154.Text = "0";
		}
		if (h154.Text == "0")
		{
			h154.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h154.ForeColor = Color.Black;
		}
	}

	private void h156_Leave_1(object sender, EventArgs e)
	{
		if (h156.Text == string.Empty)
		{
			h156.Text = "0";
		}
		if (h156.Text == "0")
		{
			h156.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h156.ForeColor = Color.Black;
		}
	}

	private void h157_Leave_1(object sender, EventArgs e)
	{
		if (h157.Text == string.Empty)
		{
			h157.Text = "0";
		}
		if (h157.Text == "0")
		{
			h157.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h157.ForeColor = Color.Black;
		}
	}

	private void h158_Leave_1(object sender, EventArgs e)
	{
		if (h158.Text == string.Empty)
		{
			h158.Text = "0";
		}
		if (h158.Text == "0")
		{
			h158.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h158.ForeColor = Color.Black;
		}
	}

	private void h160_Leave_1(object sender, EventArgs e)
	{
		if (h160.Text == string.Empty)
		{
			h160.Text = "0";
		}
		if (h160.Text == "0")
		{
			h160.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h160.ForeColor = Color.Black;
		}
	}

	private void h161_Leave_1(object sender, EventArgs e)
	{
		if (h161.Text == string.Empty)
		{
			h161.Text = "0";
		}
		if (h161.Text == "0")
		{
			h161.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h161.ForeColor = Color.Black;
		}
	}

	private void h162_Leave_1(object sender, EventArgs e)
	{
		if (h162.Text == string.Empty)
		{
			h162.Text = "0";
		}
		if (h162.Text == "0")
		{
			h162.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h162.ForeColor = Color.Black;
		}
	}

	private void h164_Leave_1(object sender, EventArgs e)
	{
		if (h164.Text == string.Empty)
		{
			h164.Text = "0";
		}
		if (h164.Text == "0")
		{
			h164.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h164.ForeColor = Color.Black;
		}
	}

	private void h167_Leave_1(object sender, EventArgs e)
	{
		if (h167.Text == string.Empty)
		{
			h167.Text = "0";
		}
		if (h167.Text == "0")
		{
			h167.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h167.ForeColor = Color.Black;
		}
	}

	private void h169_Leave_1(object sender, EventArgs e)
	{
		if (h169.Text == string.Empty)
		{
			h169.Text = "0";
		}
		if (h169.Text == "0")
		{
			h169.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h169.ForeColor = Color.Black;
		}
	}

	private void h170_Leave_1(object sender, EventArgs e)
	{
		if (h170.Text == string.Empty)
		{
			h170.Text = "0";
		}
		if (h170.Text == "0")
		{
			h170.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h170.ForeColor = Color.Black;
		}
	}

	private void h173_Leave_1(object sender, EventArgs e)
	{
		if (h173.Text == string.Empty)
		{
			h173.Text = "0";
		}
		if (h173.Text == "0")
		{
			h173.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h173.ForeColor = Color.Black;
		}
	}

	private void h176_Leave_1(object sender, EventArgs e)
	{
		if (h176.Text == string.Empty)
		{
			h176.Text = "0";
		}
		if (h176.Text == "0")
		{
			h176.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h176.ForeColor = Color.Black;
		}
	}

	private void h178_Leave_1(object sender, EventArgs e)
	{
		if (h178.Text == string.Empty)
		{
			h178.Text = "0";
		}
		if (h178.Text == "0")
		{
			h178.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h178.ForeColor = Color.Black;
		}
	}

	private void h179_Leave_1(object sender, EventArgs e)
	{
		if (h179.Text == string.Empty)
		{
			h179.Text = "0";
		}
		if (h179.Text == "0")
		{
			h179.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h179.ForeColor = Color.Black;
		}
	}

	private void h181_Leave_1(object sender, EventArgs e)
	{
		if (h181.Text == string.Empty)
		{
			h181.Text = "0";
		}
		if (h181.Text == "0")
		{
			h181.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h181.ForeColor = Color.Black;
		}
	}

	private void h184_Layout(object sender, LayoutEventArgs e)
	{
		if (h184.Text == string.Empty)
		{
			h184.Text = "0";
		}
		if (h184.Text == "0")
		{
			h184.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h184.ForeColor = Color.Black;
		}
	}

	private void h184_Leave_1(object sender, EventArgs e)
	{
		if (h184.Text == string.Empty)
		{
			h184.Text = "0";
		}
		if (h184.Text == "0")
		{
			h184.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h184.ForeColor = Color.Black;
		}
	}

	private void h187_Leave_1(object sender, EventArgs e)
	{
		if (h187.Text == string.Empty)
		{
			h187.Text = "0";
		}
		if (h187.Text == "0")
		{
			h187.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h187.ForeColor = Color.Black;
		}
	}

	private void h189_Leave_1(object sender, EventArgs e)
	{
		if (h189.Text == string.Empty)
		{
			h189.Text = "0";
		}
		if (h189.Text == "0")
		{
			h189.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h189.ForeColor = Color.Black;
		}
	}

	private void h190_Leave_1(object sender, EventArgs e)
	{
		if (h190.Text == string.Empty)
		{
			h190.Text = "0";
		}
		if (h190.Text == "0")
		{
			h190.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h190.ForeColor = Color.Black;
		}
	}

	private void h191_Leave_1(object sender, EventArgs e)
	{
		if (h191.Text == string.Empty)
		{
			h191.Text = "0";
		}
		if (h191.Text == "0")
		{
			h191.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h191.ForeColor = Color.Black;
		}
	}

	private void h198_Leave_1(object sender, EventArgs e)
	{
		if (h198.Text == string.Empty)
		{
			h198.Text = "0";
		}
		if (h198.Text == "0")
		{
			h198.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h198.ForeColor = Color.Black;
		}
	}

	private void h199_Leave_1(object sender, EventArgs e)
	{
		if (h199.Text == string.Empty)
		{
			h199.Text = "0";
		}
		if (h199.Text == "0")
		{
			h199.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h199.ForeColor = Color.Black;
		}
	}

	private void h202_Leave_1(object sender, EventArgs e)
	{
		if (h202.Text == string.Empty)
		{
			h202.Text = "0";
		}
		if (h202.Text == "0")
		{
			h202.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h202.ForeColor = Color.Black;
		}
	}

	private void h203_Leave_1(object sender, EventArgs e)
	{
		if (h203.Text == string.Empty)
		{
			h203.Text = "0";
		}
		if (h203.Text == "0")
		{
			h203.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h203.ForeColor = Color.Black;
		}
	}

	private void h204_Leave_1(object sender, EventArgs e)
	{
		if (h204.Text == string.Empty)
		{
			h204.Text = "0";
		}
		if (h204.Text == "0")
		{
			h204.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h204.ForeColor = Color.Black;
		}
	}

	private void h205_Leave_1(object sender, EventArgs e)
	{
		if (h205.Text == string.Empty)
		{
			h205.Text = "0";
		}
		if (h205.Text == "0")
		{
			h205.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h205.ForeColor = Color.Black;
		}
	}

	private void h206_Leave_1(object sender, EventArgs e)
	{
		if (h206.Text == string.Empty)
		{
			h206.Text = "0";
		}
		if (h206.Text == "0")
		{
			h206.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h206.ForeColor = Color.Black;
		}
	}

	private void h208_Leave_1(object sender, EventArgs e)
	{
		if (h208.Text == string.Empty)
		{
			h208.Text = "0";
		}
		if (h208.Text == "0")
		{
			h208.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h208.ForeColor = Color.Black;
		}
	}

	private void h209_Leave_1(object sender, EventArgs e)
	{
		if (h209.Text == string.Empty)
		{
			h209.Text = "0";
		}
		if (h209.Text == "0")
		{
			h209.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h209.ForeColor = Color.Black;
		}
	}

	private void h210_Leave_1(object sender, EventArgs e)
	{
		if (h210.Text == string.Empty)
		{
			h210.Text = "0";
		}
		if (h210.Text == "0")
		{
			h210.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h210.ForeColor = Color.Black;
		}
	}

	private void h212_Leave_1(object sender, EventArgs e)
	{
		if (h212.Text == string.Empty)
		{
			h212.Text = "0";
		}
		if (h212.Text == "0")
		{
			h212.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h212.ForeColor = Color.Black;
		}
	}

	private void h214_Leave_1(object sender, EventArgs e)
	{
		if (h214.Text == string.Empty)
		{
			h214.Text = "0";
		}
		if (h214.Text == "0")
		{
			h214.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h214.ForeColor = Color.Black;
		}
	}

	private void h215_Leave_1(object sender, EventArgs e)
	{
		if (h215.Text == string.Empty)
		{
			h215.Text = "0";
		}
		if (h215.Text == "0")
		{
			h215.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h215.ForeColor = Color.Black;
		}
	}

	private void h216_Leave_1(object sender, EventArgs e)
	{
		if (h216.Text == string.Empty)
		{
			h216.Text = "0";
		}
		if (h216.Text == "0")
		{
			h216.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h216.ForeColor = Color.Black;
		}
	}

	private void h217_Leave_1(object sender, EventArgs e)
	{
		if (h217.Text == string.Empty)
		{
			h217.Text = "0";
		}
		if (h217.Text == "0")
		{
			h217.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h217.ForeColor = Color.Black;
		}
	}

	private void h219_Leave_1(object sender, EventArgs e)
	{
		if (h219.Text == string.Empty)
		{
			h219.Text = "0";
		}
		if (h219.Text == "0")
		{
			h219.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h219.ForeColor = Color.Black;
		}
	}

	private void h220_Leave_1(object sender, EventArgs e)
	{
		if (h220.Text == string.Empty)
		{
			h220.Text = "0";
		}
		if (h220.Text == "0")
		{
			h220.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h220.ForeColor = Color.Black;
		}
	}

	private void h223_Leave_1(object sender, EventArgs e)
	{
		if (h223.Text == string.Empty)
		{
			h223.Text = "0";
		}
		if (h223.Text == "0")
		{
			h223.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h223.ForeColor = Color.Black;
		}
	}

	private void h229_Leave_1(object sender, EventArgs e)
	{
		if (h229.Text == string.Empty)
		{
			h229.Text = "0";
		}
		if (h229.Text == "0")
		{
			h229.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h229.ForeColor = Color.Black;
		}
	}

	private void h233_Leave_1(object sender, EventArgs e)
	{
		if (h233.Text == string.Empty)
		{
			h233.Text = "0";
		}
		if (h233.Text == "0")
		{
			h233.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h233.ForeColor = Color.Black;
		}
	}

	private void h234_Leave_1(object sender, EventArgs e)
	{
		if (h234.Text == string.Empty)
		{
			h234.Text = "0";
		}
		if (h234.Text == "0")
		{
			h234.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h234.ForeColor = Color.Black;
		}
	}

	private void h235_Leave_1(object sender, EventArgs e)
	{
		if (h235.Text == string.Empty)
		{
			h235.Text = "0";
		}
		if (h235.Text == "0")
		{
			h235.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h235.ForeColor = Color.Black;
		}
	}

	private void s101_Leave_1(object sender, EventArgs e)
	{
		if (s101.Text == string.Empty)
		{
			s101.Text = "0";
		}
		if (s101.Text == "0")
		{
			s101.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s101.ForeColor = Color.Black;
		}
	}

	private void s104_Leave_1(object sender, EventArgs e)
	{
		if (s104.Text == string.Empty)
		{
			s104.Text = "0";
		}
		if (s104.Text == "0")
		{
			s104.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s104.ForeColor = Color.Black;
		}
	}

	private void s110_Leave_1(object sender, EventArgs e)
	{
		if (s110.Text == string.Empty)
		{
			s110.Text = "0";
		}
		if (s110.Text == "0")
		{
			s110.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s110.ForeColor = Color.Black;
		}
	}

	private void s114_Leave_1(object sender, EventArgs e)
	{
		if (s114.Text == string.Empty)
		{
			s114.Text = "0";
		}
		if (s114.Text == "0")
		{
			s114.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s114.ForeColor = Color.Black;
		}
	}

	private void s115_Leave_1(object sender, EventArgs e)
	{
		if (s115.Text == string.Empty)
		{
			s115.Text = "0";
		}
		if (s115.Text == "0")
		{
			s115.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s115.ForeColor = Color.Black;
		}
	}

	private void s116_Leave_1(object sender, EventArgs e)
	{
		if (s116.Text == string.Empty)
		{
			s116.Text = "0";
		}
		if (s116.Text == "0")
		{
			s116.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s116.ForeColor = Color.Black;
		}
	}

	private void s117_Leave_1(object sender, EventArgs e)
	{
		if (s117.Text == string.Empty)
		{
			s117.Text = "0";
		}
		if (s117.Text == "0")
		{
			s117.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s117.ForeColor = Color.Black;
		}
	}

	private void s119_Leave_1(object sender, EventArgs e)
	{
		if (s119.Text == string.Empty)
		{
			s119.Text = "0";
		}
		if (s119.Text == "0")
		{
			s119.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s119.ForeColor = Color.Black;
		}
	}

	private void s121_Leave_1(object sender, EventArgs e)
	{
		if (s121.Text == string.Empty)
		{
			s121.Text = "0";
		}
		if (s121.Text == "0")
		{
			s121.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s121.ForeColor = Color.Black;
		}
	}

	private void s162_Leave_1(object sender, EventArgs e)
	{
		if (s162.Text == string.Empty)
		{
			s162.Text = "0";
		}
		if (s162.Text == "0")
		{
			s162.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s162.ForeColor = Color.Black;
		}
	}

	private void s164_Leave_1(object sender, EventArgs e)
	{
		if (s164.Text == string.Empty)
		{
			s164.Text = "0";
		}
		if (s164.Text == "0")
		{
			s164.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s164.ForeColor = Color.Black;
		}
	}

	private void s165_Leave_1(object sender, EventArgs e)
	{
		if (s165.Text == string.Empty)
		{
			s165.Text = "0";
		}
		if (s165.Text == "0")
		{
			s165.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s165.ForeColor = Color.Black;
		}
	}

	private void s166_Leave_1(object sender, EventArgs e)
	{
		if (s166.Text == string.Empty)
		{
			s166.Text = "0";
		}
		if (s166.Text == "0")
		{
			s166.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s166.ForeColor = Color.Black;
		}
	}

	private void s168_Leave_1(object sender, EventArgs e)
	{
		if (s168.Text == string.Empty)
		{
			s168.Text = "0";
		}
		if (s168.Text == "0")
		{
			s168.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s168.ForeColor = Color.Black;
		}
	}

	private void s169_Leave_1(object sender, EventArgs e)
	{
		if (s169.Text == string.Empty)
		{
			s169.Text = "0";
		}
		if (s169.Text == "0")
		{
			s169.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s169.ForeColor = Color.Black;
		}
	}

	private void s171_Leave_1(object sender, EventArgs e)
	{
		if (s171.Text == string.Empty)
		{
			s171.Text = "0";
		}
		if (s171.Text == "0")
		{
			s171.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s171.ForeColor = Color.Black;
		}
	}

	private void s174_Leave_1(object sender, EventArgs e)
	{
		if (s174.Text == string.Empty)
		{
			s174.Text = "0";
		}
		if (s174.Text == "0")
		{
			s174.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s174.ForeColor = Color.Black;
		}
	}

	private void s180_Leave_1(object sender, EventArgs e)
	{
		if (s180.Text == string.Empty)
		{
			s180.Text = "0";
		}
		if (s180.Text == "0")
		{
			s180.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s180.ForeColor = Color.Black;
		}
	}

	private void s182_Leave_1(object sender, EventArgs e)
	{
		if (s182.Text == string.Empty)
		{
			s182.Text = "0";
		}
		if (s182.Text == "0")
		{
			s182.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s182.ForeColor = Color.Black;
		}
	}

	private void s122_Leave_1(object sender, EventArgs e)
	{
		if (s122.Text == string.Empty)
		{
			s122.Text = "0";
		}
		if (s122.Text == "0")
		{
			s122.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s122.ForeColor = Color.Black;
		}
	}

	private void s123_Leave_1(object sender, EventArgs e)
	{
		if (s123.Text == string.Empty)
		{
			s123.Text = "0";
		}
		if (s123.Text == "0")
		{
			s123.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s123.ForeColor = Color.Black;
		}
	}

	private void s124_Leave_1(object sender, EventArgs e)
	{
		if (s124.Text == string.Empty)
		{
			s124.Text = "0";
		}
		if (s124.Text == "0")
		{
			s124.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s124.ForeColor = Color.Black;
		}
	}

	private void s125_Leave_1(object sender, EventArgs e)
	{
		if (s125.Text == string.Empty)
		{
			s125.Text = "0";
		}
		if (s125.Text == "0")
		{
			s125.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s125.ForeColor = Color.Black;
		}
	}

	private void s128_Leave_1(object sender, EventArgs e)
	{
		if (s128.Text == string.Empty)
		{
			s128.Text = "0";
		}
		if (s128.Text == "0")
		{
			s128.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s128.ForeColor = Color.Black;
		}
	}

	private void s129_Leave_1(object sender, EventArgs e)
	{
		if (s129.Text == string.Empty)
		{
			s129.Text = "0";
		}
		if (s129.Text == "0")
		{
			s129.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s129.ForeColor = Color.Black;
		}
	}

	private void s130_Leave_1(object sender, EventArgs e)
	{
		if (s130.Text == string.Empty)
		{
			s130.Text = "0";
		}
		if (s130.Text == "0")
		{
			s130.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s130.ForeColor = Color.Black;
		}
	}

	private void s133_Leave_1(object sender, EventArgs e)
	{
		if (s133.Text == string.Empty)
		{
			s133.Text = "0";
		}
		if (s133.Text == "0")
		{
			s133.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s133.ForeColor = Color.Black;
		}
	}

	private void s135_Leave_1(object sender, EventArgs e)
	{
		if (s135.Text == string.Empty)
		{
			s135.Text = "0";
		}
		if (s135.Text == "0")
		{
			s135.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s135.ForeColor = Color.Black;
		}
	}

	private void s136_Leave_1(object sender, EventArgs e)
	{
		if (s136.Text == string.Empty)
		{
			s136.Text = "0";
		}
		if (s136.Text == "0")
		{
			s136.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s136.ForeColor = Color.Black;
		}
	}

	private void s137_Leave_1(object sender, EventArgs e)
	{
		if (s137.Text == string.Empty)
		{
			s137.Text = "0";
		}
		if (s137.Text == "0")
		{
			s137.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s137.ForeColor = Color.Black;
		}
	}

	private void s183_Leave_1(object sender, EventArgs e)
	{
		if (s183.Text == string.Empty)
		{
			s183.Text = "0";
		}
		if (s183.Text == "0")
		{
			s183.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s183.ForeColor = Color.Black;
		}
	}

	private void s185_Leave_1(object sender, EventArgs e)
	{
		if (s185.Text == string.Empty)
		{
			s185.Text = "0";
		}
		if (s185.Text == "0")
		{
			s185.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s185.ForeColor = Color.Black;
		}
	}

	private void s190_Leave_1(object sender, EventArgs e)
	{
		if (s190.Text == string.Empty)
		{
			s190.Text = "0";
		}
		if (s190.Text == "0")
		{
			s190.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s190.ForeColor = Color.Black;
		}
	}

	private void s192_Leave_1(object sender, EventArgs e)
	{
		if (s192.Text == string.Empty)
		{
			s192.Text = "0";
		}
		if (s192.Text == "0")
		{
			s192.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s192.ForeColor = Color.Black;
		}
	}

	private void s193_Leave_1(object sender, EventArgs e)
	{
		if (s193.Text == string.Empty)
		{
			s193.Text = "0";
		}
		if (s193.Text == "0")
		{
			s193.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s193.ForeColor = Color.Black;
		}
	}

	private void s194_Leave_1(object sender, EventArgs e)
	{
		if (s194.Text == string.Empty)
		{
			s194.Text = "0";
		}
		if (s194.Text == "0")
		{
			s194.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s194.ForeColor = Color.Black;
		}
	}

	private void s198_Leave_1(object sender, EventArgs e)
	{
		if (s198.Text == string.Empty)
		{
			s198.Text = "0";
		}
		if (s198.Text == "0")
		{
			s198.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s198.ForeColor = Color.Black;
		}
	}

	private void s201_Leave_1(object sender, EventArgs e)
	{
		if (s201.Text == string.Empty)
		{
			s201.Text = "0";
		}
		if (s201.Text == "0")
		{
			s201.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s201.ForeColor = Color.Black;
		}
	}

	private void s207_Leave_1(object sender, EventArgs e)
	{
		if (s207.Text == string.Empty)
		{
			s207.Text = "0";
		}
		if (s207.Text == "0")
		{
			s207.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s207.ForeColor = Color.Black;
		}
	}

	private void s218_Leave_1(object sender, EventArgs e)
	{
		if (s218.Text == string.Empty)
		{
			s218.Text = "0";
		}
		if (s218.Text == "0")
		{
			s218.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s218.ForeColor = Color.Black;
		}
	}

	private void s221_Leave_1(object sender, EventArgs e)
	{
		if (s221.Text == string.Empty)
		{
			s221.Text = "0";
		}
		if (s221.Text == "0")
		{
			s221.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s221.ForeColor = Color.Black;
		}
	}

	private void s138_Leave_1(object sender, EventArgs e)
	{
		if (s138.Text == string.Empty)
		{
			s138.Text = "0";
		}
		if (s138.Text == "0")
		{
			s138.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s138.ForeColor = Color.Black;
		}
	}

	private void s145_Leave_1(object sender, EventArgs e)
	{
		if (s145.Text == string.Empty)
		{
			s145.Text = "0";
		}
		if (s145.Text == "0")
		{
			s145.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s145.ForeColor = Color.Black;
		}
	}

	private void s147_Leave_1(object sender, EventArgs e)
	{
		if (s147.Text == string.Empty)
		{
			s147.Text = "0";
		}
		if (s147.Text == "0")
		{
			s147.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s147.ForeColor = Color.Black;
		}
	}

	private void s148_Leave_1(object sender, EventArgs e)
	{
		if (s148.Text == string.Empty)
		{
			s148.Text = "0";
		}
		if (s148.Text == "0")
		{
			s148.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s148.ForeColor = Color.Black;
		}
	}

	private void s153_Leave_1(object sender, EventArgs e)
	{
		if (s153.Text == string.Empty)
		{
			s153.Text = "0";
		}
		if (s153.Text == "0")
		{
			s153.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s153.ForeColor = Color.Black;
		}
	}

	private void s157_Leave_1(object sender, EventArgs e)
	{
		if (s157.Text == string.Empty)
		{
			s157.Text = "0";
		}
		if (s157.Text == "0")
		{
			s157.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s157.ForeColor = Color.Black;
		}
	}

	private void s161_Leave_1(object sender, EventArgs e)
	{
		if (s161.Text == string.Empty)
		{
			s161.Text = "0";
		}
		if (s161.Text == "0")
		{
			s161.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s161.ForeColor = Color.Black;
		}
	}

	private void s226_Leave_1(object sender, EventArgs e)
	{
		if (s226.Text == string.Empty)
		{
			s226.Text = "0";
		}
		if (s226.Text == "0")
		{
			s226.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s226.ForeColor = Color.Black;
		}
	}

	private void s228_Leave_1(object sender, EventArgs e)
	{
		if (s228.Text == string.Empty)
		{
			s228.Text = "0";
		}
		if (s228.Text == "0")
		{
			s228.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s228.ForeColor = Color.Black;
		}
	}

	private void s230_Leave_1(object sender, EventArgs e)
	{
		if (s230.Text == string.Empty)
		{
			s230.Text = "0";
		}
		if (s230.Text == "0")
		{
			s230.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s230.ForeColor = Color.Black;
		}
	}

	private void s231_Leave_1(object sender, EventArgs e)
	{
		if (s231.Text == string.Empty)
		{
			s231.Text = "0";
		}
		if (s231.Text == "0")
		{
			s231.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s231.ForeColor = Color.Black;
		}
	}

	private void s236_Leave_1(object sender, EventArgs e)
	{
		if (s236.Text == string.Empty)
		{
			s236.Text = "0";
		}
		if (s236.Text == "0")
		{
			s236.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s236.ForeColor = Color.Black;
		}
	}

	private void d107_Leave_1(object sender, EventArgs e)
	{
		if (d107.Text == string.Empty)
		{
			d107.Text = "0";
		}
		if (d107.Text == "0")
		{
			d107.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d107.ForeColor = Color.Black;
		}
	}

	private void d108_Leave_1(object sender, EventArgs e)
	{
		if (d108.Text == string.Empty)
		{
			d108.Text = "0";
		}
		if (d108.Text == "0")
		{
			d108.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d108.ForeColor = Color.Black;
		}
	}

	private void d114_Leave_1(object sender, EventArgs e)
	{
		if (d114.Text == string.Empty)
		{
			d114.Text = "0";
		}
		if (d114.Text == "0")
		{
			d114.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d114.ForeColor = Color.Black;
		}
	}

	private void d118_Leave_1(object sender, EventArgs e)
	{
		if (d118.Text == string.Empty)
		{
			d118.Text = "0";
		}
		if (d118.Text == "0")
		{
			d118.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d118.ForeColor = Color.Black;
		}
	}

	private void d126_Leave_1(object sender, EventArgs e)
	{
		if (d126.Text == string.Empty)
		{
			d126.Text = "0";
		}
		if (d126.Text == "0")
		{
			d126.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d126.ForeColor = Color.Black;
		}
	}

	private void d127_Leave_1(object sender, EventArgs e)
	{
		if (d127.Text == string.Empty)
		{
			d127.Text = "0";
		}
		if (d127.Text == "0")
		{
			h129.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d127.ForeColor = Color.Black;
		}
	}

	private void d129_Leave_1(object sender, EventArgs e)
	{
		if (d129.Text == string.Empty)
		{
			d129.Text = "0";
		}
		if (d129.Text == "0")
		{
			d129.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d129.ForeColor = Color.Black;
		}
	}

	private void d132_Leave_1(object sender, EventArgs e)
	{
		if (d132.Text == string.Empty)
		{
			d132.Text = "0";
		}
		if (d132.Text == "0")
		{
			d132.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d132.ForeColor = Color.Black;
		}
	}

	private void d133_Leave_1(object sender, EventArgs e)
	{
		if (d133.Text == string.Empty)
		{
			d133.Text = "0";
		}
		if (d133.Text == "0")
		{
			d133.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d133.ForeColor = Color.Black;
		}
	}

	private void d134_Leave_1(object sender, EventArgs e)
	{
		if (d134.Text == string.Empty)
		{
			d134.Text = "0";
		}
		if (d134.Text == "0")
		{
			d134.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d134.ForeColor = Color.Black;
		}
	}

	private void d162_Leave_1(object sender, EventArgs e)
	{
		if (d162.Text == string.Empty)
		{
			d162.Text = "0";
		}
		if (d162.Text == "0")
		{
			d162.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d162.ForeColor = Color.Black;
		}
	}

	private void d163_Leave_1(object sender, EventArgs e)
	{
		if (d163.Text == string.Empty)
		{
			d163.Text = "0";
		}
		if (d163.Text == "0")
		{
			d163.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d163.ForeColor = Color.Black;
		}
	}

	private void d164_Leave_1(object sender, EventArgs e)
	{
		if (d164.Text == string.Empty)
		{
			d164.Text = "0";
		}
		if (d164.Text == "0")
		{
			d164.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d164.ForeColor = Color.Black;
		}
	}

	private void d169_Leave_1(object sender, EventArgs e)
	{
		if (d169.Text == string.Empty)
		{
			d169.Text = "0";
		}
		if (d169.Text == "0")
		{
			d169.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d169.ForeColor = Color.Black;
		}
	}

	private void d175_Leave_1(object sender, EventArgs e)
	{
		if (d175.Text == string.Empty)
		{
			d175.Text = "0";
		}
		if (d175.Text == "0")
		{
			d175.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d175.ForeColor = Color.Black;
		}
	}

	private void d177_Leave_1(object sender, EventArgs e)
	{
		if (d177.Text == string.Empty)
		{
			d177.Text = "0";
		}
		if (d177.Text == "0")
		{
			d177.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d177.ForeColor = Color.Black;
		}
	}

	private void d186_Leave_1(object sender, EventArgs e)
	{
		if (d186.Text == string.Empty)
		{
			d186.Text = "0";
		}
		if (d186.Text == "0")
		{
			d186.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d186.ForeColor = Color.Black;
		}
	}

	private void d188_Leave_1(object sender, EventArgs e)
	{
		if (d188.Text == string.Empty)
		{
			d188.Text = "0";
		}
		if (d188.Text == "0")
		{
			d188.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d188.ForeColor = Color.Black;
		}
	}

	private void d190_Leave_1(object sender, EventArgs e)
	{
		if (d190.Text == string.Empty)
		{
			d190.Text = "0";
		}
		if (d190.Text == "0")
		{
			d190.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d190.ForeColor = Color.Black;
		}
	}

	private void d195_Leave_1(object sender, EventArgs e)
	{
		if (d195.Text == string.Empty)
		{
			d195.Text = "0";
		}
		if (d195.Text == "0")
		{
			d195.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d195.ForeColor = Color.Black;
		}
	}

	private void d140_Leave_1(object sender, EventArgs e)
	{
		if (d140.Text == string.Empty)
		{
			d140.Text = "0";
		}
		if (d140.Text == "0")
		{
			d140.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d140.ForeColor = Color.Black;
		}
	}

	private void d141_Leave_1(object sender, EventArgs e)
	{
		if (d141.Text == string.Empty)
		{
			d141.Text = "0";
		}
		if (d141.Text == "0")
		{
			d141.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d141.ForeColor = Color.Black;
		}
	}

	private void d142_Leave_1(object sender, EventArgs e)
	{
		if (d142.Text == string.Empty)
		{
			d142.Text = "0";
		}
		if (d142.Text == "0")
		{
			d142.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d142.ForeColor = Color.Black;
		}
	}

	private void d143_Leave_1(object sender, EventArgs e)
	{
		if (d143.Text == string.Empty)
		{
			d143.Text = "0";
		}
		if (d143.Text == "0")
		{
			d143.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d143.ForeColor = Color.Black;
		}
	}

	private void d147_Leave_1(object sender, EventArgs e)
	{
		if (d147.Text == string.Empty)
		{
			d147.Text = "0";
		}
		if (d147.Text == "0")
		{
			d147.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d147.ForeColor = Color.Black;
		}
	}

	private void d148_Leave_1(object sender, EventArgs e)
	{
		if (d148.Text == string.Empty)
		{
			d148.Text = "0";
		}
		if (d148.Text == "0")
		{
			d148.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d148.ForeColor = Color.Black;
		}
	}

	private void d152_Leave_1(object sender, EventArgs e)
	{
		if (d152.Text == string.Empty)
		{
			d152.Text = "0";
		}
		if (d152.Text == "0")
		{
			d152.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d152.ForeColor = Color.Black;
		}
	}

	private void d155_Leave_1(object sender, EventArgs e)
	{
		if (d155.Text == string.Empty)
		{
			d155.Text = "0";
		}
		if (d155.Text == "0")
		{
			d155.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d155.ForeColor = Color.Black;
		}
	}

	private void d157_Leave_1(object sender, EventArgs e)
	{
		if (d157.Text == string.Empty)
		{
			d157.Text = "0";
		}
		if (d157.Text == "0")
		{
			d157.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d157.ForeColor = Color.Black;
		}
	}

	private void d159_Leave_1(object sender, EventArgs e)
	{
		if (d159.Text == string.Empty)
		{
			d159.Text = "0";
		}
		if (d159.Text == "0")
		{
			d159.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d159.ForeColor = Color.Black;
		}
	}

	private void d161_Leave_1(object sender, EventArgs e)
	{
		if (d161.Text == string.Empty)
		{
			d161.Text = "0";
		}
		if (d161.Text == "0")
		{
			d161.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d161.ForeColor = Color.Black;
		}
	}

	private void d196_Leave_1(object sender, EventArgs e)
	{
		if (d196.Text == string.Empty)
		{
			d196.Text = "0";
		}
		if (d196.Text == "0")
		{
			d196.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d196.ForeColor = Color.Black;
		}
	}

	private void d197_Leave_1(object sender, EventArgs e)
	{
		if (d197.Text == string.Empty)
		{
			d197.Text = "0";
		}
		if (d197.Text == "0")
		{
			d197.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d197.ForeColor = Color.Black;
		}
	}

	private void d200_Leave_1(object sender, EventArgs e)
	{
		if (d200.Text == string.Empty)
		{
			d200.Text = "0";
		}
		if (d200.Text == "0")
		{
			d200.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d200.ForeColor = Color.Black;
		}
	}

	private void d211_Leave_1(object sender, EventArgs e)
	{
		if (d211.Text == string.Empty)
		{
			d211.Text = "0";
		}
		if (d211.Text == "0")
		{
			d211.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d211.ForeColor = Color.Black;
		}
	}

	private void d213_Leave_1(object sender, EventArgs e)
	{
		if (d213.Text == string.Empty)
		{
			d213.Text = "0";
		}
		if (d213.Text == "0")
		{
			d213.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d213.ForeColor = Color.Black;
		}
	}

	private void d222_Leave_1(object sender, EventArgs e)
	{
		if (d222.Text == string.Empty)
		{
			d222.Text = "0";
		}
		if (d222.Text == "0")
		{
			d222.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d222.ForeColor = Color.Black;
		}
	}

	private void d224_Leave_1(object sender, EventArgs e)
	{
		if (d224.Text == string.Empty)
		{
			d224.Text = "0";
		}
		if (d224.Text == "0")
		{
			d224.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d224.ForeColor = Color.Black;
		}
	}

	private void d225_Leave_1(object sender, EventArgs e)
	{
		if (d225.Text == string.Empty)
		{
			d225.Text = "0";
		}
		if (d225.Text == "0")
		{
			d225.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d225.ForeColor = Color.Black;
		}
	}

	private void d227_Leave_1(object sender, EventArgs e)
	{
		if (d227.Text == string.Empty)
		{
			d227.Text = "0";
		}
		if (d227.Text == "0")
		{
			d227.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d227.ForeColor = Color.Black;
		}
	}

	private void d232_Leave_1(object sender, EventArgs e)
	{
		if (d232.Text == string.Empty)
		{
			d232.Text = "0";
		}
		if (d232.Text == "0")
		{
			d232.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			d232.ForeColor = Color.Black;
		}
	}

	private void hl114_Leave_1(object sender, EventArgs e)
	{
		if (hl114.Text == string.Empty)
		{
			hl114.Text = "0";
		}
		if (hl114.Text == "0")
		{
			hl114.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl114.ForeColor = Color.Black;
		}
	}

	private void hl123_Leave_1(object sender, EventArgs e)
	{
		if (hl123.Text == string.Empty)
		{
			hl123.Text = "0";
		}
		if (hl123.Text == "0")
		{
			hl123.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl123.ForeColor = Color.Black;
		}
	}

	private void hl129_Leave_1(object sender, EventArgs e)
	{
		if (h129.Text == string.Empty)
		{
			h129.Text = "0";
		}
		if (h129.Text == "0")
		{
			h129.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			h129.ForeColor = Color.Black;
		}
	}

	private void hl133_Leave_1(object sender, EventArgs e)
	{
		if (hl133.Text == string.Empty)
		{
			hl133.Text = "0";
		}
		if (hl133.Text == "0")
		{
			hl133.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl133.ForeColor = Color.Black;
		}
	}

	private void hl147_Leave_1(object sender, EventArgs e)
	{
		if (hl147.Text == string.Empty)
		{
			hl147.Text = "0";
		}
		if (hl147.Text == "0")
		{
			hl147.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl147.ForeColor = Color.Black;
		}
	}

	private void hl148_Leave_1(object sender, EventArgs e)
	{
		if (hl148.Text == string.Empty)
		{
			hl148.Text = "0";
		}
		if (hl148.Text == "0")
		{
			hl148.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl148.ForeColor = Color.Black;
		}
	}

	private void hl157_Leave_1(object sender, EventArgs e)
	{
		if (hl157.Text == string.Empty)
		{
			hl157.Text = "0";
		}
		if (hl157.Text == "0")
		{
			hl157.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl157.ForeColor = Color.Black;
		}
	}

	private void hl161_Leave_1(object sender, EventArgs e)
	{
		if (hl161.Text == string.Empty)
		{
			hl161.Text = "0";
		}
		if (hl161.Text == "0")
		{
			hl161.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl161.ForeColor = Color.Black;
		}
	}

	private void hl162_Leave_1(object sender, EventArgs e)
	{
		if (hl162.Text == string.Empty)
		{
			hl162.Text = "0";
		}
		if (hl162.Text == "0")
		{
			hl162.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl162.ForeColor = Color.Black;
		}
	}

	private void hl164_Leave_1(object sender, EventArgs e)
	{
		if (hl164.Text == string.Empty)
		{
			hl164.Text = "0";
		}
		if (hl164.Text == "0")
		{
			hl164.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl164.ForeColor = Color.Black;
		}
	}

	private void hl169_Leave_1(object sender, EventArgs e)
	{
		if (hl169.Text == string.Empty)
		{
			hl169.Text = "0";
		}
		if (hl169.Text == "0")
		{
			hl169.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl169.ForeColor = Color.Black;
		}
	}

	private void hl172_Leave_1(object sender, EventArgs e)
	{
		if (hl172.Text == string.Empty)
		{
			hl172.Text = "0";
		}
		if (hl172.Text == "0")
		{
			hl172.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl172.ForeColor = Color.Black;
		}
	}

	private void hl190_Leave_1(object sender, EventArgs e)
	{
		if (hl190.Text == string.Empty)
		{
			hl190.Text = "0";
		}
		if (hl190.Text == "0")
		{
			hl190.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl190.ForeColor = Color.Black;
		}
	}

	private void hl198_Leave_1(object sender, EventArgs e)
	{
		if (hl198.Text == string.Empty)
		{
			hl198.Text = "0";
		}
		if (hl198.Text == "0")
		{
			hl198.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			hl198.ForeColor = Color.Black;
		}
	}

	private void h102_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h102.Text = "0";
		}
	}

	private void h103_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h103.Text = "0";
		}
	}

	private void h105_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h105.Text = "0";
		}
	}

	private void h106_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h106.Text = "0";
		}
	}

	private void h109_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h109.Text = "0";
		}
	}

	private void h111_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h111.Text = "0";
		}
	}

	private void h112_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h112.Text = "0";
		}
	}

	private void h114_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h114.Text = "0";
		}
	}

	private void h120_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h120.Text = "0";
		}
	}

	private void h123_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h123.Text = "0";
		}
	}

	private void h173_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h173.Text = "0";
		}
	}

	private void h176_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h176.Text = "0";
		}
	}

	private void h178_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h178.Text = "0";
		}
	}

	private void h179_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h179.Text = "0";
		}
	}

	private void h181_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h181.Text = "0";
		}
	}

	private void h184_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h184.Text = "0";
		}
	}

	private void h187_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h187.Text = "0";
		}
	}

	private void h189_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h189.Text = "0";
		}
	}

	private void h190_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h190.Text = "0";
		}
	}

	private void h191_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h191.Text = "0";
		}
	}

	private void h131_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h131.Text = "0";
		}
	}

	private void h133_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h133.Text = "0";
		}
	}

	private void h139_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h139.Text = "0";
		}
	}

	private void h144_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h144.Text = "0";
		}
	}

	private void h146_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h146.Text = "0";
		}
	}

	private void h147_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h147.Text = "0";
		}
	}

	private void h148_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h148.Text = "0";
		}
	}

	private void h149_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h149.Text = "0";
		}
	}

	private void h150_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h150.Text = "0";
		}
	}

	private void h151_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h151.Text = "0";
		}
	}

	private void h154_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h154.Text = "0";
		}
	}

	private void h156_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h156.Text = "0";
		}
	}

	private void h157_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h157.Text = "0";
		}
	}

	private void h158_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h158.Text = "0";
		}
	}

	private void h160_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h160.Text = "0";
		}
	}

	private void h161_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h161.Text = "0";
		}
	}

	private void h162_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h162.Text = "0";
		}
	}

	private void h164_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h164.Text = "0";
		}
	}

	private void h167_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h167.Text = "0";
		}
	}

	private void h169_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h169.Text = "0";
		}
	}

	private void h170_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h170.Text = "0";
		}
	}

	private void h198_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h198.Text = "0";
		}
	}

	private void h199_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h199.Text = "0";
		}
	}

	private void h202_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h202.Text = "0";
		}
	}

	private void h203_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h203.Text = "0";
		}
	}

	private void h204_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h204.Text = "0";
		}
	}

	private void h205_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h205.Text = "0";
		}
	}

	private void h206_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h206.Text = "0";
		}
	}

	private void h208_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h208.Text = "0";
		}
	}

	private void h209_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h209.Text = "0";
		}
	}

	private void h210_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h210.Text = "0";
		}
	}

	private void h212_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h212.Text = "0";
		}
	}

	private void h214_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h214.Text = "0";
		}
	}

	private void h215_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h215.Text = "0";
		}
	}

	private void h216_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h216.Text = "0";
		}
	}

	private void h217_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h217.Text = "0";
		}
	}

	private void h219_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h219.Text = "0";
		}
	}

	private void h220_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h220.Text = "0";
		}
	}

	private void h223_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h223.Text = "0";
		}
	}

	private void h229_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h229.Text = "0";
		}
	}

	private void h233_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h233.Text = "0";
		}
	}

	private void h234_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h234.Text = "0";
		}
	}

	private void h235_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h235.Text = "0";
		}
	}

	private void s101_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s101.Text = "0";
		}
	}

	private void s104_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s104.Text = "0";
		}
	}

	private void s110_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s110.Text = "0";
		}
	}

	private void s113_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s113.Text = "0";
		}
	}

	private void s113_Leave(object sender, EventArgs e)
	{
		if (s113.Text == string.Empty)
		{
			s113.Text = "0";
		}
		if (s113.Text == "0")
		{
			s113.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s113.ForeColor = Color.Black;
		}
	}

	private void s114_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s114.Text = "0";
		}
	}

	private void s115_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s115.Text = "0";
		}
	}

	private void s116_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s116.Text = "0";
		}
	}

	private void s117_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s117.Text = "0";
		}
	}

	private void s119_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s119.Text = "0";
		}
	}

	private void s121_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s121.Text = "0";
		}
	}

	private void s162_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s162.Text = "0";
		}
	}

	private void s164_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s164.Text = "0";
		}
	}

	private void s165_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s165.Text = "0";
		}
	}

	private void s166_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s166.Text = "0";
		}
	}

	private void s168_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s168.Text = "0";
		}
	}

	private void s169_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s169.Text = "0";
		}
	}

	private void s171_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s171.Text = "0";
		}
	}

	private void s174_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s174.Text = "0";
		}
	}

	private void s180_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s180.Text = "0";
		}
	}

	private void s182_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s182.Text = "0";
		}
	}

	private void s122_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s122.Text = "0";
		}
	}

	private void s123_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s123.Text = "0";
		}
	}

	private void s124_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s124.Text = "0";
		}
	}

	private void s125_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s125.Text = "0";
		}
	}

	private void s128_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s128.Text = "0";
		}
	}

	private void s129_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s129.Text = "0";
		}
	}

	private void s130_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s130.Text = "0";
		}
	}

	private void s133_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s133.Text = "0";
		}
	}

	private void s135_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s135.Text = "0";
		}
	}

	private void s136_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s136.Text = "0";
		}
	}

	private void s137_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s137.Text = "0";
		}
	}

	private void s138_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s138.Text = "0";
		}
	}

	private void s183_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s183.Text = "0";
		}
	}

	private void s185_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s185.Text = "0";
		}
	}

	private void s190_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s190.Text = "0";
		}
	}

	private void s192_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s192.Text = "0";
		}
	}

	private void s193_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s193.Text = "0";
		}
	}

	private void s194_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s194.Text = "0";
		}
	}

	private void s198_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s198.Text = "0";
		}
	}

	private void s201_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s201.Text = "0";
		}
	}

	private void s207_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s207.Text = "0";
		}
	}

	private void s218_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s218.Text = "0";
		}
	}

	private void s221_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s221.Text = "0";
		}
	}

	private void s226_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s226.Text = "0";
		}
	}

	private void s145_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s145.Text = "0";
		}
	}

	private void s147_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s147.Text = "0";
		}
	}

	private void s148_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s148.Text = "0";
		}
	}

	private void s153_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s153.Text = "0";
		}
	}

	private void s157_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s157.Text = "0";
		}
	}

	private void s161_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s161.Text = "0";
		}
	}

	private void s228_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s228.Text = "0";
		}
	}

	private void s230_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s230.Text = "0";
		}
	}

	private void s231_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s231.Text = "0";
		}
	}

	private void s236_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s236.Text = "0";
		}
	}

	private void d107_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d107.Text = "0";
		}
	}

	private void d108_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d108.Text = "0";
		}
	}

	private void d114_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d114.Text = "0";
		}
	}

	private void d118_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d118.Text = "0";
		}
	}

	private void d126_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d126.Text = "0";
		}
	}

	private void d127_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d127.Text = "0";
		}
	}

	private void d129_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d129.Text = "0";
		}
	}

	private void d132_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d132.Text = "0";
		}
	}

	private void d133_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d133.Text = "0";
		}
	}

	private void d134_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d134.Text = "0";
		}
	}

	private void d162_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d162.Text = "0";
		}
	}

	private void d163_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d163.Text = "0";
		}
	}

	private void d164_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d164.Text = "0";
		}
	}

	private void d169_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d169.Text = "0";
		}
	}

	private void d175_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d175.Text = "0";
		}
	}

	private void d177_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d177.Text = "0";
		}
	}

	private void d186_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d186.Text = "0";
		}
	}

	private void d188_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d188.Text = "0";
		}
	}

	private void d190_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d190.Text = "0";
		}
	}

	private void d195_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d195.Text = "0";
		}
	}

	private void d140_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d140.Text = "0";
		}
	}

	private void d141_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d141.Text = "0";
		}
	}

	private void d142_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d142.Text = "0";
		}
	}

	private void d143_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d143.Text = "0";
		}
	}

	private void d147_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d147.Text = "0";
		}
	}

	private void d148_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d148.Text = "0";
		}
	}

	private void d152_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d152.Text = "0";
		}
	}

	private void d155_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d155.Text = "0";
		}
	}

	private void d157_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d157.Text = "0";
		}
	}

	private void d159_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d159.Text = "0";
		}
	}

	private void d161_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d161.Text = "0";
		}
	}

	private void d196_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d196.Text = "0";
		}
	}

	private void d197_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d197.Text = "0";
		}
	}

	private void d200_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d200.Text = "0";
		}
	}

	private void d211_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d211.Text = "0";
		}
	}

	private void d213_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d213.Text = "0";
		}
	}

	private void d222_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d222.Text = "0";
		}
	}

	private void d224_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d224.Text = "0";
		}
	}

	private void d225_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d225.Text = "0";
		}
	}

	private void d227_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d227.Text = "0";
		}
	}

	private void d232_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			d232.Text = "0";
		}
	}

	private void hl114_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl114.Text = "0";
		}
	}

	private void hl123_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl123.Text = "0";
		}
	}

	private void hl129_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl129.Text = "0";
		}
	}

	private void hl133_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl133.Text = "0";
		}
	}

	private void hl147_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl147.Text = "0";
		}
	}

	private void hl148_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl148.Text = "0";
		}
	}

	private void hl157_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl157.Text = "0";
		}
	}

	private void hl161_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl161.Text = "0";
		}
	}

	private void hl162_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl162.Text = "0";
		}
	}

	private void hl164_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl164.Text = "0";
		}
	}

	private void hl169_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl169.Text = "0";
		}
	}

	private void hl172_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl172.Text = "0";
		}
	}

	private void hl190_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl190.Text = "0";
		}
	}

	private void hl198_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			hl190.Text = "0";
		}
	}

	private void h102_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h103_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h105_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h106_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h109_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h111_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h112_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h114_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h120_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h123_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h129_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h129_KeyDown_1(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			h129.Text = "0";
		}
	}

	private void h173_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h176_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h178_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h179_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h181_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h184_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h187_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h189_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h190_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h191_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h198_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h131_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h133_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h139_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h144_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h146_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h147_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h148_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h149_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h150_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h151_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h154_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h156_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h199_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h202_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h203_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h204_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h205_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h206_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h208_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h209_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h210_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h212_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h214_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h215_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h216_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h217_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h219_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h220_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h223_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h229_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h233_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h234_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h235_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s101_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s104_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s110_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s113_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s114_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s115_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s116_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s117_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s119_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s121_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s162_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s164_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s165_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s166_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s168_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s169_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s171_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s174_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s180_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s182_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s122_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s123_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s124_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s125_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s128_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s129_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s130_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s133_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s135_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s136_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s137_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s138_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s183_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s185_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s190_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s192_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s193_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s194_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s198_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s201_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s207_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s218_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s221_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s226_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s145_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s147_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s148_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s153_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s157_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s161_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s228_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s230_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s231_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void s236_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d107_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d108_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d114_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d118_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d126_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d127_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d129_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d132_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d133_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d134_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d162_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d163_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d164_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d169_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d175_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d177_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d186_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d188_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d190_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d195_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d140_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d141_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d142_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d143_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d147_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d148_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d152_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d155_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d157_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d159_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d161_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d196_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d197_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d200_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d211_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d213_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d222_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d224_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d225_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void d227_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl114_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl123_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl129_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl133_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl147_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl148_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl157_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl161_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl162_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl164_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl169_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl172_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl190_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void hl198_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h102_Click_1(object sender, EventArgs e)
	{
		h102.Text = "";
	}

	private void h103_Click_1(object sender, EventArgs e)
	{
		h103.Text = "";
	}

	private void h105_Click_1(object sender, EventArgs e)
	{
		h105.Text = "";
	}

	private void h106_Click_1(object sender, EventArgs e)
	{
		h106.Text = "";
	}

	private void h109_Click_1(object sender, EventArgs e)
	{
		h109.Text = "";
	}

	private void h111_Click_1(object sender, EventArgs e)
	{
		h111.Text = "";
	}

	private void h112_Click_1(object sender, EventArgs e)
	{
		h112.Text = "";
	}

	private void h114_Click_1(object sender, EventArgs e)
	{
		h114.Text = "";
	}

	private void h120_Click_1(object sender, EventArgs e)
	{
		h120.Text = "";
	}

	private void h123_Click_1(object sender, EventArgs e)
	{
		h123.Text = "";
	}

	private void h173_Click_1(object sender, EventArgs e)
	{
		h173.Text = "";
	}

	private void h176_Click_1(object sender, EventArgs e)
	{
		h176.Text = "";
	}

	private void h178_Click_1(object sender, EventArgs e)
	{
		h178.Text = "";
	}

	private void h179_Click(object sender, EventArgs e)
	{
		h179.Text = "";
	}

	private void h181_Click(object sender, EventArgs e)
	{
		h181.Text = "";
	}

	private void h184_Click_1(object sender, EventArgs e)
	{
		h184.Text = "";
	}

	private void h187_Click_1(object sender, EventArgs e)
	{
		h187.Text = "";
	}

	private void h189_Click_1(object sender, EventArgs e)
	{
		h189.Text = "";
	}

	private void h190_Click_1(object sender, EventArgs e)
	{
		h190.Text = "";
	}

	private void h191_Click_1(object sender, EventArgs e)
	{
		h191.Text = "";
	}

	private void h129_Click_1(object sender, EventArgs e)
	{
		h129.Text = "";
	}

	private void h131_Click_1(object sender, EventArgs e)
	{
		h131.Text = "";
	}

	private void h133_Click_1(object sender, EventArgs e)
	{
		h133.Text = "";
	}

	private void h139_Click_1(object sender, EventArgs e)
	{
		h139.Text = "";
	}

	private void h144_Click_1(object sender, EventArgs e)
	{
		h144.Text = "";
	}

	private void h146_Click_1(object sender, EventArgs e)
	{
		h146.Text = "";
	}

	private void h147_Click_1(object sender, EventArgs e)
	{
		h147.Text = "";
	}

	private void h148_Click_1(object sender, EventArgs e)
	{
		h148.Text = "";
	}

	private void h149_Click_1(object sender, EventArgs e)
	{
		h149.Text = "";
	}

	private void h150_Click_1(object sender, EventArgs e)
	{
		h150.Text = "";
	}

	private void h151_Click_1(object sender, EventArgs e)
	{
		h151.Text = "";
	}

	private void h154_Click_1(object sender, EventArgs e)
	{
		h154.Text = "";
	}

	private void h198_Click_1(object sender, EventArgs e)
	{
		h198.Text = "";
	}

	private void h199_Click_1(object sender, EventArgs e)
	{
		h199.Text = "";
	}

	private void h202_Click_1(object sender, EventArgs e)
	{
		h202.Text = "";
	}

	private void h203_Click_1(object sender, EventArgs e)
	{
		h203.Text = "";
	}

	private void h204_Click_1(object sender, EventArgs e)
	{
		h204.Text = "";
	}

	private void h205_Click_1(object sender, EventArgs e)
	{
		h205.Text = "";
	}

	private void h206_Click_1(object sender, EventArgs e)
	{
		h206.Text = "";
	}

	private void h208_Click_1(object sender, EventArgs e)
	{
		h208.Text = "";
	}

	private void h209_Click_1(object sender, EventArgs e)
	{
		h209.Text = "";
	}

	private void h210_Click_1(object sender, EventArgs e)
	{
		h210.Text = "";
	}

	private void h212_Click_1(object sender, EventArgs e)
	{
		h212.Text = "";
	}

	private void h214_Click_1(object sender, EventArgs e)
	{
		h214.Text = "";
	}

	private void h156_Click_1(object sender, EventArgs e)
	{
		h156.Text = "";
	}

	private void h157_Click_1(object sender, EventArgs e)
	{
		h157.Text = "";
	}

	private void h158_Click_1(object sender, EventArgs e)
	{
		h158.Text = "";
	}

	private void h160_Click_1(object sender, EventArgs e)
	{
		h160.Text = "";
	}

	private void h161_Click_1(object sender, EventArgs e)
	{
		h161.Text = "";
	}

	private void h162_Click_1(object sender, EventArgs e)
	{
		h162.Text = "";
	}

	private void h164_Click_1(object sender, EventArgs e)
	{
		h164.Text = "";
	}

	private void h167_Click_1(object sender, EventArgs e)
	{
		h167.Text = "";
	}

	private void h169_Click_1(object sender, EventArgs e)
	{
		h169.Text = "";
	}

	private void h170_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void h215_Click_1(object sender, EventArgs e)
	{
		h215.Text = "";
	}

	private void h216_Click_1(object sender, EventArgs e)
	{
		h216.Text = "";
	}

	private void h217_Click_1(object sender, EventArgs e)
	{
		h217.Text = "";
	}

	private void h219_Click_1(object sender, EventArgs e)
	{
		h219.Text = "";
	}

	private void h220_Click_1(object sender, EventArgs e)
	{
		h220.Text = "";
	}

	private void h223_Click_1(object sender, EventArgs e)
	{
		h223.Text = "";
	}

	private void h229_Click_1(object sender, EventArgs e)
	{
		h229.Text = "";
	}

	private void h233_Click_1(object sender, EventArgs e)
	{
		h233.Text = "";
	}

	private void h234_Click_1(object sender, EventArgs e)
	{
		h234.Text = "";
	}

	private void h235_Click_1(object sender, EventArgs e)
	{
		h235.Text = "";
	}

	private void s101_Click(object sender, EventArgs e)
	{
		s101.Text = "";
	}

	private void s104_Click(object sender, EventArgs e)
	{
		s104.Text = "";
	}

	private void s110_Click(object sender, EventArgs e)
	{
		s110.Text = "";
	}

	private void s113_Click(object sender, EventArgs e)
	{
		s113.Text = "";
	}

	private void s114_Click(object sender, EventArgs e)
	{
		s114.Text = "";
	}

	private void s115_Click(object sender, EventArgs e)
	{
		s115.Text = "";
	}

	private void s116_Click(object sender, EventArgs e)
	{
		s116.Text = "";
	}

	private void s117_Click(object sender, EventArgs e)
	{
		s117.Text = "";
	}

	private void s119_Click(object sender, EventArgs e)
	{
		s119.Text = "";
	}

	private void s121_Click(object sender, EventArgs e)
	{
		s121.Text = "";
	}

	private void s122_Click(object sender, EventArgs e)
	{
		s122.Text = "";
	}

	private void s162_Click(object sender, EventArgs e)
	{
		s162.Text = "";
	}

	private void s164_Click(object sender, EventArgs e)
	{
		s164.Text = "";
	}

	private void s165_Click(object sender, EventArgs e)
	{
		s165.Text = "";
	}

	private void s166_Click(object sender, EventArgs e)
	{
		s166.Text = "";
	}

	private void s168_Click(object sender, EventArgs e)
	{
		s168.Text = "";
	}

	private void s169_Click(object sender, EventArgs e)
	{
		s169.Text = "";
	}

	private void s171_Click(object sender, EventArgs e)
	{
		s171.Text = "";
	}

	private void s174_Click(object sender, EventArgs e)
	{
		s174.Text = "";
	}

	private void s180_Click(object sender, EventArgs e)
	{
		s180.Text = "";
	}

	private void s182_Click(object sender, EventArgs e)
	{
		s182.Text = "";
	}

	private void s183_Click(object sender, EventArgs e)
	{
		s183.Text = "";
	}

	private void s123_Click(object sender, EventArgs e)
	{
		s123.Text = "";
	}

	private void s124_Click(object sender, EventArgs e)
	{
		s124.Text = "";
	}

	private void s125_Click(object sender, EventArgs e)
	{
		s125.Text = "";
	}

	private void s128_Click(object sender, EventArgs e)
	{
		s128.Text = "";
	}

	private void s129_Click(object sender, EventArgs e)
	{
		s129.Text = "";
	}

	private void s130_Click(object sender, EventArgs e)
	{
		s130.Text = "";
	}

	private void s133_Click(object sender, EventArgs e)
	{
		s133.Text = "";
	}

	private void s135_Click(object sender, EventArgs e)
	{
		s135.Text = "";
	}

	private void s136_Click(object sender, EventArgs e)
	{
		s136.Text = "";
	}

	private void s137_Click(object sender, EventArgs e)
	{
		s137.Text = "";
	}

	private void s138_Click(object sender, EventArgs e)
	{
		s138.Text = "";
	}

	private void s145_Click(object sender, EventArgs e)
	{
		s145.Text = "";
	}

	private void s185_Click(object sender, EventArgs e)
	{
		s185.Text = "";
	}

	private void s190_Click(object sender, EventArgs e)
	{
		s190.Text = "";
	}

	private void s192_Click(object sender, EventArgs e)
	{
		s192.Text = "";
	}

	private void s193_Click(object sender, EventArgs e)
	{
		s193.Text = "";
	}

	private void s194_Click(object sender, EventArgs e)
	{
		s194.Text = "";
	}

	private void s198_Click(object sender, EventArgs e)
	{
		s198.Text = "";
	}

	private void s201_Click(object sender, EventArgs e)
	{
		s201.Text = "";
	}

	private void s207_Click(object sender, EventArgs e)
	{
		s207.Text = "";
	}

	private void s218_Click(object sender, EventArgs e)
	{
		s218.Text = "";
	}

	private void s221_Click(object sender, EventArgs e)
	{
		s221.Text = "";
	}

	private void s226_Click(object sender, EventArgs e)
	{
		s226.Text = "";
	}

	private void s228_Click(object sender, EventArgs e)
	{
		s228.Text = "";
	}

	private void s147_Click(object sender, EventArgs e)
	{
		s147.Text = "";
	}

	private void s148_Click(object sender, EventArgs e)
	{
		s148.Text = "";
	}

	private void s153_Click(object sender, EventArgs e)
	{
		s153.Text = "";
	}

	private void s157_Click(object sender, EventArgs e)
	{
		s157.Text = "";
	}

	private void s161_Click(object sender, EventArgs e)
	{
		s161.Text = "";
	}

	private void s230_Click(object sender, EventArgs e)
	{
		s230.Text = "";
	}

	private void s231_Click(object sender, EventArgs e)
	{
		s231.Text = "";
	}

	private void s236_Click(object sender, EventArgs e)
	{
		s236.Text = "";
	}

	private void d107_Click(object sender, EventArgs e)
	{
		d107.Text = "";
	}

	private void d108_Click(object sender, EventArgs e)
	{
		d108.Text = "";
	}

	private void d114_Click(object sender, EventArgs e)
	{
		d114.Text = "";
	}

	private void d118_Click(object sender, EventArgs e)
	{
		d118.Text = "";
	}

	private void d126_Click(object sender, EventArgs e)
	{
		d126.Text = "";
	}

	private void d127_Click(object sender, EventArgs e)
	{
		d127.Text = "";
	}

	private void d129_Click(object sender, EventArgs e)
	{
		d129.Text = "";
	}

	private void d132_Click(object sender, EventArgs e)
	{
		d132.Text = "";
	}

	private void d133_Click(object sender, EventArgs e)
	{
		d133.Text = "";
	}

	private void d134_Click(object sender, EventArgs e)
	{
		d134.Text = "";
	}

	private void d140_Click(object sender, EventArgs e)
	{
		d140.Text = "";
	}

	private void d162_Click(object sender, EventArgs e)
	{
		d162.Text = "";
	}

	private void d163_Click(object sender, EventArgs e)
	{
		d163.Text = "";
	}

	private void d164_Click(object sender, EventArgs e)
	{
		d164.Text = "";
	}

	private void d169_Click(object sender, EventArgs e)
	{
		d169.Text = "";
	}

	private void d175_Click(object sender, EventArgs e)
	{
		d175.Text = "";
	}

	private void d177_Click(object sender, EventArgs e)
	{
		d177.Text = "";
	}

	private void d186_Click(object sender, EventArgs e)
	{
		d186.Text = "";
	}

	private void d188_Click(object sender, EventArgs e)
	{
		d188.Text = "";
	}

	private void d190_Click(object sender, EventArgs e)
	{
		d190.Text = "";
	}

	private void d195_Click(object sender, EventArgs e)
	{
		d195.Text = "";
	}

	private void d196_Click(object sender, EventArgs e)
	{
		d196.Text = "";
	}

	private void d141_Click(object sender, EventArgs e)
	{
		d141.Text = "";
	}

	private void d142_Click(object sender, EventArgs e)
	{
		d142.Text = "";
	}

	private void d143_Click(object sender, EventArgs e)
	{
		d143.Text = "";
	}

	private void d147_Click(object sender, EventArgs e)
	{
		d147.Text = "";
	}

	private void d148_Click(object sender, EventArgs e)
	{
		d148.Text = "";
	}

	private void d152_Click(object sender, EventArgs e)
	{
		d152.Text = "";
	}

	private void d155_Click(object sender, EventArgs e)
	{
		d155.Text = "";
	}

	private void d157_Click(object sender, EventArgs e)
	{
		d157.Text = "";
	}

	private void d159_Click(object sender, EventArgs e)
	{
		d159.Text = "";
	}

	private void d161_Click(object sender, EventArgs e)
	{
		d161.Text = "";
	}

	private void d197_Click(object sender, EventArgs e)
	{
		d197.Text = "";
	}

	private void d200_Click(object sender, EventArgs e)
	{
		d200.Text = "";
	}

	private void d211_Click(object sender, EventArgs e)
	{
		d211.Text = "";
	}

	private void d213_Click(object sender, EventArgs e)
	{
		d213.Text = "";
	}

	private void d222_Click(object sender, EventArgs e)
	{
		d222.Text = "";
	}

	private void d224_Click(object sender, EventArgs e)
	{
		d224.Text = "";
	}

	private void d225_Click(object sender, EventArgs e)
	{
		d225.Text = "";
	}

	private void d227_Click(object sender, EventArgs e)
	{
		d227.Text = "";
	}

	private void d232_Click(object sender, EventArgs e)
	{
		d232.Text = "";
	}

	private void hl114_Click(object sender, EventArgs e)
	{
		hl114.Text = "";
	}

	private void hl123_Click(object sender, EventArgs e)
	{
		hl123.Text = "";
	}

	private void hl129_Click(object sender, EventArgs e)
	{
		hl129.Text = "";
	}

	private void hl133_Click(object sender, EventArgs e)
	{
		hl133.Text = "";
	}

	private void hl147_Click(object sender, EventArgs e)
	{
		hl147.Text = "";
	}

	private void hl148_Click(object sender, EventArgs e)
	{
		hl148.Text = "";
	}

	private void hl157_Click(object sender, EventArgs e)
	{
		hl157.Text = "";
	}

	private void hl161_Click(object sender, EventArgs e)
	{
		hl161.Text = "";
	}

	private void hl162_Click(object sender, EventArgs e)
	{
		hl162.Text = "";
	}

	private void hl164_Click(object sender, EventArgs e)
	{
		hl164.Text = "";
	}

	private void hl169_Click(object sender, EventArgs e)
	{
		hl169.Text = "";
	}

	private void hl172_Click(object sender, EventArgs e)
	{
		hl172.Text = "";
	}

	private void hl190_Click(object sender, EventArgs e)
	{
		hl190.Text = "";
	}

	private void hl198_Click(object sender, EventArgs e)
	{
		hl198.Text = "";
	}

	private void h161_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUK_Anjamakan.Frm.TEST));
		this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.txtmalband = new System.Windows.Forms.TextBox();
		this.txtparezga = new System.Windows.Forms.TextBox();
		this.txtcoodtasj = new System.Windows.Forms.TextBox();
		this.txtnawtasj = new System.Windows.Forms.TextBox();
		this.txtnawbnka = new System.Windows.Forms.TextBox();
		this.txtbnkacood = new System.Windows.Forms.TextBox();
		this.txtwestga = new System.Windows.Forms.TextBox();
		this.txtzhdangdar = new System.Windows.Forms.TextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.btnsearch = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.bnltablsearch = new System.Windows.Forms.TableLayoutPanel();
		this.button5 = new System.Windows.Forms.Button();
		this.label49 = new System.Windows.Forms.Label();
		this.comwestga = new Guna.UI2.WinForms.Guna2ComboBox();
		this.btnadd = new System.Windows.Forms.Button();
		this.label4 = new System.Windows.Forms.Label();
		this.txtwaraqadrost = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.txtwaraqaybatl = new System.Windows.Forms.TextBox();
		this.txt_total_h = new System.Windows.Forms.TextBox();
		this.btn_candid_h = new System.Windows.Forms.Button();
		this.panel1 = new System.Windows.Forms.Panel();
		this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
		this.h235 = new System.Windows.Forms.TextBox();
		this.h178 = new System.Windows.Forms.TextBox();
		this.h234 = new System.Windows.Forms.TextBox();
		this.h170 = new System.Windows.Forms.TextBox();
		this.h233 = new System.Windows.Forms.TextBox();
		this.label297 = new System.Windows.Forms.Label();
		this.h229 = new System.Windows.Forms.TextBox();
		this.h176 = new System.Windows.Forms.TextBox();
		this.label293 = new System.Windows.Forms.Label();
		this.label315 = new System.Windows.Forms.Label();
		this.h173 = new System.Windows.Forms.TextBox();
		this.h169 = new System.Windows.Forms.TextBox();
		this.label289 = new System.Windows.Forms.Label();
		this.label323 = new System.Windows.Forms.Label();
		this.label285 = new System.Windows.Forms.Label();
		this.h223 = new System.Windows.Forms.TextBox();
		this.h220 = new System.Windows.Forms.TextBox();
		this.label311 = new System.Windows.Forms.Label();
		this.label319 = new System.Windows.Forms.Label();
		this.h167 = new System.Windows.Forms.TextBox();
		this.h219 = new System.Windows.Forms.TextBox();
		this.h164 = new System.Windows.Forms.TextBox();
		this.h217 = new System.Windows.Forms.TextBox();
		this.label281 = new System.Windows.Forms.Label();
		this.h162 = new System.Windows.Forms.TextBox();
		this.label277 = new System.Windows.Forms.Label();
		this.label307 = new System.Windows.Forms.Label();
		this.h161 = new System.Windows.Forms.TextBox();
		this.h160 = new System.Windows.Forms.TextBox();
		this.label269 = new System.Windows.Forms.Label();
		this.label303 = new System.Windows.Forms.Label();
		this.label299 = new System.Windows.Forms.Label();
		this.h158 = new System.Windows.Forms.TextBox();
		this.label295 = new System.Windows.Forms.Label();
		this.h151 = new System.Windows.Forms.TextBox();
		this.h150 = new System.Windows.Forms.TextBox();
		this.h154 = new System.Windows.Forms.TextBox();
		this.h149 = new System.Windows.Forms.TextBox();
		this.label291 = new System.Windows.Forms.Label();
		this.h157 = new System.Windows.Forms.TextBox();
		this.h156 = new System.Windows.Forms.TextBox();
		this.h148 = new System.Windows.Forms.TextBox();
		this.h147 = new System.Windows.Forms.TextBox();
		this.h146 = new System.Windows.Forms.TextBox();
		this.h144 = new System.Windows.Forms.TextBox();
		this.label287 = new System.Windows.Forms.Label();
		this.h139 = new System.Windows.Forms.TextBox();
		this.h133 = new System.Windows.Forms.TextBox();
		this.h131 = new System.Windows.Forms.TextBox();
		this.label267 = new System.Windows.Forms.Label();
		this.label263 = new System.Windows.Forms.Label();
		this.label283 = new System.Windows.Forms.Label();
		this.label259 = new System.Windows.Forms.Label();
		this.label255 = new System.Windows.Forms.Label();
		this.label279 = new System.Windows.Forms.Label();
		this.label251 = new System.Windows.Forms.Label();
		this.label247 = new System.Windows.Forms.Label();
		this.label69 = new System.Windows.Forms.Label();
		this.label275 = new System.Windows.Forms.Label();
		this.label72 = new System.Windows.Forms.Label();
		this.label76 = new System.Windows.Forms.Label();
		this.label80 = new System.Windows.Forms.Label();
		this.label271 = new System.Windows.Forms.Label();
		this.label399 = new System.Windows.Forms.Label();
		this.label395 = new System.Windows.Forms.Label();
		this.label391 = new System.Windows.Forms.Label();
		this.s161 = new System.Windows.Forms.TextBox();
		this.label387 = new System.Windows.Forms.Label();
		this.s157 = new System.Windows.Forms.TextBox();
		this.s153 = new System.Windows.Forms.TextBox();
		this.s148 = new System.Windows.Forms.TextBox();
		this.s147 = new System.Windows.Forms.TextBox();
		this.s145 = new System.Windows.Forms.TextBox();
		this.s138 = new System.Windows.Forms.TextBox();
		this.s137 = new System.Windows.Forms.TextBox();
		this.label383 = new System.Windows.Forms.Label();
		this.label379 = new System.Windows.Forms.Label();
		this.label375 = new System.Windows.Forms.Label();
		this.d211 = new System.Windows.Forms.TextBox();
		this.d200 = new System.Windows.Forms.TextBox();
		this.d197 = new System.Windows.Forms.TextBox();
		this.d196 = new System.Windows.Forms.TextBox();
		this.d195 = new System.Windows.Forms.TextBox();
		this.d190 = new System.Windows.Forms.TextBox();
		this.label213 = new System.Windows.Forms.Label();
		this.label209 = new System.Windows.Forms.Label();
		this.label205 = new System.Windows.Forms.Label();
		this.label201 = new System.Windows.Forms.Label();
		this.label197 = new System.Windows.Forms.Label();
		this.label193 = new System.Windows.Forms.Label();
		this.label157 = new System.Windows.Forms.Label();
		this.label153 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.h102 = new System.Windows.Forms.TextBox();
		this.hl147 = new System.Windows.Forms.TextBox();
		this.hl172 = new System.Windows.Forms.TextBox();
		this.hl133 = new System.Windows.Forms.TextBox();
		this.label114 = new System.Windows.Forms.Label();
		this.label99 = new System.Windows.Forms.Label();
		this.hl129 = new System.Windows.Forms.TextBox();
		this.hl169 = new System.Windows.Forms.TextBox();
		this.label15 = new System.Windows.Forms.Label();
		this.d161 = new System.Windows.Forms.TextBox();
		this.label112 = new System.Windows.Forms.Label();
		this.hl123 = new System.Windows.Forms.TextBox();
		this.d159 = new System.Windows.Forms.TextBox();
		this.label97 = new System.Windows.Forms.Label();
		this.s101 = new System.Windows.Forms.TextBox();
		this.label109 = new System.Windows.Forms.Label();
		this.hl114 = new System.Windows.Forms.TextBox();
		this.label95 = new System.Windows.Forms.Label();
		this.hl162 = new System.Windows.Forms.TextBox();
		this.label107 = new System.Windows.Forms.Label();
		this.label50 = new System.Windows.Forms.Label();
		this.d107 = new System.Windows.Forms.TextBox();
		this.label92 = new System.Windows.Forms.Label();
		this.hl161 = new System.Windows.Forms.TextBox();
		this.label105 = new System.Windows.Forms.Label();
		this.d148 = new System.Windows.Forms.TextBox();
		this.d147 = new System.Windows.Forms.TextBox();
		this.d143 = new System.Windows.Forms.TextBox();
		this.d142 = new System.Windows.Forms.TextBox();
		this.d141 = new System.Windows.Forms.TextBox();
		this.d140 = new System.Windows.Forms.TextBox();
		this.d134 = new System.Windows.Forms.TextBox();
		this.d133 = new System.Windows.Forms.TextBox();
		this.label60 = new System.Windows.Forms.Label();
		this.s136 = new System.Windows.Forms.TextBox();
		this.label117 = new System.Windows.Forms.Label();
		this.label129 = new System.Windows.Forms.Label();
		this.label125 = new System.Windows.Forms.Label();
		this.label121 = new System.Windows.Forms.Label();
		this.label113 = new System.Windows.Forms.Label();
		this.s135 = new System.Windows.Forms.TextBox();
		this.label371 = new System.Windows.Forms.Label();
		this.label90 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.h103 = new System.Windows.Forms.TextBox();
		this.d126 = new System.Windows.Forms.TextBox();
		this.label18 = new System.Windows.Forms.Label();
		this.s104 = new System.Windows.Forms.TextBox();
		this.label52 = new System.Windows.Forms.Label();
		this.d108 = new System.Windows.Forms.TextBox();
		this.d118 = new System.Windows.Forms.TextBox();
		this.label23 = new System.Windows.Forms.Label();
		this.h105 = new System.Windows.Forms.TextBox();
		this.s114 = new System.Windows.Forms.TextBox();
		this.d114 = new System.Windows.Forms.TextBox();
		this.label22 = new System.Windows.Forms.Label();
		this.s110 = new System.Windows.Forms.TextBox();
		this.label54 = new System.Windows.Forms.Label();
		this.s113 = new System.Windows.Forms.TextBox();
		this.hl164 = new System.Windows.Forms.TextBox();
		this.label27 = new System.Windows.Forms.Label();
		this.h106 = new System.Windows.Forms.TextBox();
		this.label58 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.label56 = new System.Windows.Forms.Label();
		this.label31 = new System.Windows.Forms.Label();
		this.h109 = new System.Windows.Forms.TextBox();
		this.label30 = new System.Windows.Forms.Label();
		this.label35 = new System.Windows.Forms.Label();
		this.h111 = new System.Windows.Forms.TextBox();
		this.h112 = new System.Windows.Forms.TextBox();
		this.h114 = new System.Windows.Forms.TextBox();
		this.label39 = new System.Windows.Forms.Label();
		this.label43 = new System.Windows.Forms.Label();
		this.label34 = new System.Windows.Forms.Label();
		this.label38 = new System.Windows.Forms.Label();
		this.label42 = new System.Windows.Forms.Label();
		this.label46 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.label73 = new System.Windows.Forms.Label();
		this.s115 = new System.Windows.Forms.TextBox();
		this.s116 = new System.Windows.Forms.TextBox();
		this.s117 = new System.Windows.Forms.TextBox();
		this.s119 = new System.Windows.Forms.TextBox();
		this.s121 = new System.Windows.Forms.TextBox();
		this.s122 = new System.Windows.Forms.TextBox();
		this.label101 = new System.Windows.Forms.Label();
		this.label103 = new System.Windows.Forms.Label();
		this.hl148 = new System.Windows.Forms.TextBox();
		this.hl157 = new System.Windows.Forms.TextBox();
		this.label120 = new System.Windows.Forms.Label();
		this.label124 = new System.Windows.Forms.Label();
		this.hl190 = new System.Windows.Forms.TextBox();
		this.hl198 = new System.Windows.Forms.TextBox();
		this.d127 = new System.Windows.Forms.TextBox();
		this.d129 = new System.Windows.Forms.TextBox();
		this.d132 = new System.Windows.Forms.TextBox();
		this.label66 = new System.Windows.Forms.Label();
		this.label65 = new System.Windows.Forms.Label();
		this.label62 = new System.Windows.Forms.Label();
		this.label47 = new System.Windows.Forms.Label();
		this.label88 = new System.Windows.Forms.Label();
		this.label84 = new System.Windows.Forms.Label();
		this.h120 = new System.Windows.Forms.TextBox();
		this.h123 = new System.Windows.Forms.TextBox();
		this.h129 = new System.Windows.Forms.TextBox();
		this.label77 = new System.Windows.Forms.Label();
		this.label81 = new System.Windows.Forms.Label();
		this.label85 = new System.Windows.Forms.Label();
		this.label89 = new System.Windows.Forms.Label();
		this.label355 = new System.Windows.Forms.Label();
		this.label359 = new System.Windows.Forms.Label();
		this.label363 = new System.Windows.Forms.Label();
		this.s123 = new System.Windows.Forms.TextBox();
		this.s124 = new System.Windows.Forms.TextBox();
		this.s125 = new System.Windows.Forms.TextBox();
		this.s128 = new System.Windows.Forms.TextBox();
		this.s129 = new System.Windows.Forms.TextBox();
		this.s130 = new System.Windows.Forms.TextBox();
		this.s133 = new System.Windows.Forms.TextBox();
		this.label367 = new System.Windows.Forms.Label();
		this.label133 = new System.Windows.Forms.Label();
		this.label137 = new System.Windows.Forms.Label();
		this.label141 = new System.Windows.Forms.Label();
		this.label145 = new System.Windows.Forms.Label();
		this.label149 = new System.Windows.Forms.Label();
		this.d152 = new System.Windows.Forms.TextBox();
		this.d155 = new System.Windows.Forms.TextBox();
		this.d157 = new System.Windows.Forms.TextBox();
		this.label161 = new System.Windows.Forms.Label();
		this.d162 = new System.Windows.Forms.TextBox();
		this.label165 = new System.Windows.Forms.Label();
		this.d163 = new System.Windows.Forms.TextBox();
		this.label169 = new System.Windows.Forms.Label();
		this.d164 = new System.Windows.Forms.TextBox();
		this.label173 = new System.Windows.Forms.Label();
		this.d169 = new System.Windows.Forms.TextBox();
		this.label177 = new System.Windows.Forms.Label();
		this.d175 = new System.Windows.Forms.TextBox();
		this.label181 = new System.Windows.Forms.Label();
		this.d177 = new System.Windows.Forms.TextBox();
		this.label185 = new System.Windows.Forms.Label();
		this.d186 = new System.Windows.Forms.TextBox();
		this.label189 = new System.Windows.Forms.Label();
		this.d188 = new System.Windows.Forms.TextBox();
		this.label91 = new System.Windows.Forms.Label();
		this.d213 = new System.Windows.Forms.TextBox();
		this.label94 = new System.Windows.Forms.Label();
		this.label53 = new System.Windows.Forms.Label();
		this.label55 = new System.Windows.Forms.Label();
		this.label57 = new System.Windows.Forms.Label();
		this.label64 = new System.Windows.Forms.Label();
		this.d222 = new System.Windows.Forms.TextBox();
		this.d224 = new System.Windows.Forms.TextBox();
		this.d225 = new System.Windows.Forms.TextBox();
		this.d227 = new System.Windows.Forms.TextBox();
		this.d232 = new System.Windows.Forms.TextBox();
		this.label403 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.label33 = new System.Windows.Forms.Label();
		this.h179 = new System.Windows.Forms.TextBox();
		this.h181 = new System.Windows.Forms.TextBox();
		this.h184 = new System.Windows.Forms.TextBox();
		this.h187 = new System.Windows.Forms.TextBox();
		this.h189 = new System.Windows.Forms.TextBox();
		this.h190 = new System.Windows.Forms.TextBox();
		this.label37 = new System.Windows.Forms.Label();
		this.label41 = new System.Windows.Forms.Label();
		this.label45 = new System.Windows.Forms.Label();
		this.label86 = new System.Windows.Forms.Label();
		this.label82 = new System.Windows.Forms.Label();
		this.label78 = new System.Windows.Forms.Label();
		this.label74 = new System.Windows.Forms.Label();
		this.h191 = new System.Windows.Forms.TextBox();
		this.h198 = new System.Windows.Forms.TextBox();
		this.h199 = new System.Windows.Forms.TextBox();
		this.h202 = new System.Windows.Forms.TextBox();
		this.h203 = new System.Windows.Forms.TextBox();
		this.h204 = new System.Windows.Forms.TextBox();
		this.h205 = new System.Windows.Forms.TextBox();
		this.label70 = new System.Windows.Forms.Label();
		this.label67 = new System.Windows.Forms.Label();
		this.label245 = new System.Windows.Forms.Label();
		this.label249 = new System.Windows.Forms.Label();
		this.label253 = new System.Windows.Forms.Label();
		this.label257 = new System.Windows.Forms.Label();
		this.label261 = new System.Windows.Forms.Label();
		this.label265 = new System.Windows.Forms.Label();
		this.h206 = new System.Windows.Forms.TextBox();
		this.h208 = new System.Windows.Forms.TextBox();
		this.h209 = new System.Windows.Forms.TextBox();
		this.h210 = new System.Windows.Forms.TextBox();
		this.h212 = new System.Windows.Forms.TextBox();
		this.h214 = new System.Windows.Forms.TextBox();
		this.h215 = new System.Windows.Forms.TextBox();
		this.h216 = new System.Windows.Forms.TextBox();
		this.label273 = new System.Windows.Forms.Label();
		this.label357 = new System.Windows.Forms.Label();
		this.s230 = new System.Windows.Forms.TextBox();
		this.label353 = new System.Windows.Forms.Label();
		this.s228 = new System.Windows.Forms.TextBox();
		this.label87 = new System.Windows.Forms.Label();
		this.s226 = new System.Windows.Forms.TextBox();
		this.label83 = new System.Windows.Forms.Label();
		this.s221 = new System.Windows.Forms.TextBox();
		this.label79 = new System.Windows.Forms.Label();
		this.s218 = new System.Windows.Forms.TextBox();
		this.label75 = new System.Windows.Forms.Label();
		this.s207 = new System.Windows.Forms.TextBox();
		this.s201 = new System.Windows.Forms.TextBox();
		this.label71 = new System.Windows.Forms.Label();
		this.label68 = new System.Windows.Forms.Label();
		this.s198 = new System.Windows.Forms.TextBox();
		this.s194 = new System.Windows.Forms.TextBox();
		this.label44 = new System.Windows.Forms.Label();
		this.label40 = new System.Windows.Forms.Label();
		this.s193 = new System.Windows.Forms.TextBox();
		this.label36 = new System.Windows.Forms.Label();
		this.s192 = new System.Windows.Forms.TextBox();
		this.label32 = new System.Windows.Forms.Label();
		this.s190 = new System.Windows.Forms.TextBox();
		this.s185 = new System.Windows.Forms.TextBox();
		this.s183 = new System.Windows.Forms.TextBox();
		this.s182 = new System.Windows.Forms.TextBox();
		this.label28 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.s180 = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.s174 = new System.Windows.Forms.TextBox();
		this.label431 = new System.Windows.Forms.Label();
		this.s171 = new System.Windows.Forms.TextBox();
		this.label427 = new System.Windows.Forms.Label();
		this.s169 = new System.Windows.Forms.TextBox();
		this.label423 = new System.Windows.Forms.Label();
		this.s168 = new System.Windows.Forms.TextBox();
		this.label361 = new System.Windows.Forms.Label();
		this.s231 = new System.Windows.Forms.TextBox();
		this.s236 = new System.Windows.Forms.TextBox();
		this.label365 = new System.Windows.Forms.Label();
		this.label419 = new System.Windows.Forms.Label();
		this.s166 = new System.Windows.Forms.TextBox();
		this.label415 = new System.Windows.Forms.Label();
		this.s165 = new System.Windows.Forms.TextBox();
		this.label411 = new System.Windows.Forms.Label();
		this.s164 = new System.Windows.Forms.TextBox();
		this.label407 = new System.Windows.Forms.Label();
		this.s162 = new System.Windows.Forms.TextBox();
		this.lbl_taswit = new System.Windows.Forms.Label();
		this.labljorydangdan = new System.Windows.Forms.Label();
		this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
		this.btn_candid_hl = new System.Windows.Forms.Button();
		this.txt_total_hl = new System.Windows.Forms.TextBox();
		this.txt_total_d = new System.Windows.Forms.TextBox();
		this.btn_candid_s = new System.Windows.Forms.Button();
		this.btn_candid_d = new System.Windows.Forms.Button();
		this.txt_total_s = new System.Windows.Forms.TextBox();
		this.tableLayoutPanel1.SuspendLayout();
		this.bnltablsearch.SuspendLayout();
		this.panel1.SuspendLayout();
		this.tableLayoutPanel7.SuspendLayout();
		this.tableLayoutPanel3.SuspendLayout();
		base.SuspendLayout();
		this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
		this.tableLayoutPanel1.ColumnCount = 9;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.39558f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.709559f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.77206f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.625f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.78677f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.38603f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.639485f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67811f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198f));
		this.tableLayoutPanel1.Controls.Add(this.txtmalband, 6, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtparezga, 5, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtcoodtasj, 4, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtnawtasj, 3, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtnawbnka, 2, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtbnkacood, 8, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtwestga, 1, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtzhdangdar, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
		this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
		this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
		this.tableLayoutPanel1.Controls.Add(this.label10, 5, 0);
		this.tableLayoutPanel1.Controls.Add(this.label6, 7, 0);
		this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
		this.tableLayoutPanel1.Controls.Add(this.btnsearch, 7, 1);
		this.tableLayoutPanel1.Controls.Add(this.label3, 8, 0);
		this.tableLayoutPanel1.Controls.Add(this.label1, 6, 0);
		this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
		this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 2;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56f));
		this.tableLayoutPanel1.Size = new System.Drawing.Size(1357, 113);
		this.tableLayoutPanel1.TabIndex = 7;
		this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(tableLayoutPanel1_MouseMove);
		this.txtmalband.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtmalband.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtmalband.Location = new System.Drawing.Point(900, 60);
		this.txtmalband.Multiline = true;
		this.txtmalband.Name = "txtmalband";
		this.txtmalband.ReadOnly = true;
		this.txtmalband.Size = new System.Drawing.Size(82, 50);
		this.txtmalband.TabIndex = 2;
		this.txtmalband.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtparezga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtparezga.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtparezga.Location = new System.Drawing.Point(780, 60);
		this.txtparezga.Multiline = true;
		this.txtparezga.Name = "txtparezga";
		this.txtparezga.ReadOnly = true;
		this.txtparezga.Size = new System.Drawing.Size(114, 50);
		this.txtparezga.TabIndex = 3;
		this.txtparezga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtcoodtasj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtcoodtasj.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtcoodtasj.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtcoodtasj.Location = new System.Drawing.Point(621, 60);
		this.txtcoodtasj.Multiline = true;
		this.txtcoodtasj.Name = "txtcoodtasj";
		this.txtcoodtasj.ReadOnly = true;
		this.txtcoodtasj.Size = new System.Drawing.Size(153, 50);
		this.txtcoodtasj.TabIndex = 4;
		this.txtcoodtasj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtnawtasj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtnawtasj.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtnawtasj.Location = new System.Drawing.Point(440, 60);
		this.txtnawtasj.Multiline = true;
		this.txtnawtasj.Name = "txtnawtasj";
		this.txtnawtasj.ReadOnly = true;
		this.txtnawtasj.Size = new System.Drawing.Size(175, 50);
		this.txtnawtasj.TabIndex = 5;
		this.txtnawtasj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtnawbnka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtnawbnka.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtnawbnka.Location = new System.Drawing.Point(200, 60);
		this.txtnawbnka.Multiline = true;
		this.txtnawbnka.Name = "txtnawbnka";
		this.txtnawbnka.ReadOnly = true;
		this.txtnawbnka.Size = new System.Drawing.Size(234, 50);
		this.txtnawbnka.TabIndex = 6;
		this.txtnawbnka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtbnkacood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtbnkacood.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtbnkacood.Location = new System.Drawing.Point(1158, 60);
		this.txtbnkacood.Multiline = true;
		this.txtbnkacood.Name = "txtbnkacood";
		this.txtbnkacood.Size = new System.Drawing.Size(192, 50);
		this.txtbnkacood.TabIndex = 0;
		this.txtbnkacood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtbnkacood.TextChanged += new System.EventHandler(txtbnkacood_TextChanged);
		this.txtbnkacood.KeyDown += new System.Windows.Forms.KeyEventHandler(txtbnkacood_KeyDown);
		this.txtbnkacood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtbnkacood_KeyPress);
		this.txtwestga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtwestga.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtwestga.Location = new System.Drawing.Point(123, 60);
		this.txtwestga.Multiline = true;
		this.txtwestga.Name = "txtwestga";
		this.txtwestga.ReadOnly = true;
		this.txtwestga.Size = new System.Drawing.Size(71, 50);
		this.txtwestga.TabIndex = 7;
		this.txtwestga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtzhdangdar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtzhdangdar.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtzhdangdar.Location = new System.Drawing.Point(3, 60);
		this.txtzhdangdar.Multiline = true;
		this.txtzhdangdar.Name = "txtzhdangdar";
		this.txtzhdangdar.ReadOnly = true;
		this.txtzhdangdar.Size = new System.Drawing.Size(114, 50);
		this.txtzhdangdar.TabIndex = 8;
		this.txtzhdangdar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.ForeColor = System.Drawing.Color.White;
		this.label11.Location = new System.Drawing.Point(123, 0);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(66, 29);
		this.label11.TabIndex = 11;
		this.label11.Text = "ژ.وێستگه\u200c";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.Color.White;
		this.label7.Location = new System.Drawing.Point(440, 0);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(155, 29);
		this.label7.TabIndex = 10;
		this.label7.Text = "ناوی ناوه\u200cندی تۆماركردن";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.ForeColor = System.Drawing.Color.White;
		this.label9.Location = new System.Drawing.Point(621, 0);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(135, 29);
		this.label9.TabIndex = 12;
		this.label9.Text = "ژ.ناوه\u200cندی تۆماركردن";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.ForeColor = System.Drawing.Color.White;
		this.label10.Location = new System.Drawing.Point(780, 0);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(57, 29);
		this.label10.TabIndex = 13;
		this.label10.Text = "پارێزگا";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.White;
		this.label6.Location = new System.Drawing.Point(988, 0);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(45, 29);
		this.label6.TabIndex = 10;
		this.label6.Text = "گه\u200cڕان";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.White;
		this.label2.Location = new System.Drawing.Point(3, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(69, 29);
		this.label2.TabIndex = 10;
		this.label2.Text = "ژ.ده\u200cنگده\u200cر";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnsearch.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.btnsearch.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnsearch.ForeColor = System.Drawing.Color.White;
		this.btnsearch.Image = (System.Drawing.Image)resources.GetObject("btnsearch.Image");
		this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnsearch.Location = new System.Drawing.Point(988, 60);
		this.btnsearch.Name = "btnsearch";
		this.btnsearch.Size = new System.Drawing.Size(164, 50);
		this.btnsearch.TabIndex = 1;
		this.btnsearch.Text = "Search";
		this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnsearch.UseVisualStyleBackColor = false;
		this.btnsearch.Click += new System.EventHandler(btnsearch_Click);
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.White;
		this.label3.Location = new System.Drawing.Point(1158, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(110, 29);
		this.label3.TabIndex = 9;
		this.label3.Text = "ژ.بنكه\u200cی ده\u200cنگدان";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(900, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 29);
		this.label1.TabIndex = 8;
		this.label1.Text = "مه\u200cڵبه\u200cند";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = System.Drawing.Color.White;
		this.label8.Location = new System.Drawing.Point(200, 0);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(130, 29);
		this.label8.TabIndex = 11;
		this.label8.Text = "ناوی بنكه\u200cی ده\u200cنگدان";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bnltablsearch.BackColor = System.Drawing.Color.Gray;
		this.bnltablsearch.ColumnCount = 8;
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.73333f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.711111f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.49952f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.340324f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.08889f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.64444f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.bnltablsearch.Controls.Add(this.button5, 0, 0);
		this.bnltablsearch.Controls.Add(this.label49, 7, 0);
		this.bnltablsearch.Controls.Add(this.comwestga, 6, 0);
		this.bnltablsearch.Controls.Add(this.btnadd, 5, 0);
		this.bnltablsearch.Controls.Add(this.label4, 4, 0);
		this.bnltablsearch.Controls.Add(this.txtwaraqadrost, 3, 0);
		this.bnltablsearch.Controls.Add(this.label5, 2, 0);
		this.bnltablsearch.Controls.Add(this.txtwaraqaybatl, 1, 0);
		this.bnltablsearch.Dock = System.Windows.Forms.DockStyle.Top;
		this.bnltablsearch.Location = new System.Drawing.Point(0, 113);
		this.bnltablsearch.Name = "bnltablsearch";
		this.bnltablsearch.RowCount = 1;
		this.bnltablsearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.bnltablsearch.Size = new System.Drawing.Size(1357, 60);
		this.bnltablsearch.TabIndex = 8;
		this.button5.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.button5.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.ForeColor = System.Drawing.Color.White;
		this.button5.Location = new System.Drawing.Point(3, 3);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(147, 54);
		this.button5.TabIndex = 5902;
		this.button5.Text = "سرینەوە";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.label49.AutoSize = true;
		this.label49.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label49.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label49.ForeColor = System.Drawing.Color.Black;
		this.label49.Location = new System.Drawing.Point(1144, 0);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(73, 37);
		this.label49.TabIndex = 38;
		this.label49.Text = "وێستگە";
		this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.comwestga.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
		this.comwestga.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.comwestga.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.comwestga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comwestga.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.comwestga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.comwestga.Font = new System.Drawing.Font("Segoe UI", 13.8f);
		this.comwestga.ForeColor = System.Drawing.Color.Red;
		this.comwestga.ItemHeight = 40;
		this.comwestga.Location = new System.Drawing.Point(978, 3);
		this.comwestga.Name = "comwestga";
		this.comwestga.Size = new System.Drawing.Size(160, 46);
		this.comwestga.TabIndex = 0;
		this.comwestga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.comwestga.SelectedIndexChanged += new System.EventHandler(comwestga_SelectedIndexChanged);
		this.comwestga.MouseMove += new System.Windows.Forms.MouseEventHandler(comwestga_MouseMove);
		this.btnadd.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.btnadd.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnadd.ForeColor = System.Drawing.Color.White;
		this.btnadd.Location = new System.Drawing.Point(786, 3);
		this.btnadd.Name = "btnadd";
		this.btnadd.Size = new System.Drawing.Size(186, 54);
		this.btnadd.TabIndex = 5897;
		this.btnadd.Text = "تۆماركردن";
		this.btnadd.UseVisualStyleBackColor = false;
		this.btnadd.Click += new System.EventHandler(btnadd_Click);
		this.btnadd.MouseMove += new System.Windows.Forms.MouseEventHandler(btnadd_MouseMove);
		this.label4.AutoSize = true;
		this.label4.BackColor = System.Drawing.Color.White;
		this.label4.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.Color.LimeGreen;
		this.label4.Location = new System.Drawing.Point(551, 0);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(188, 58);
		this.label4.TabIndex = 10;
		this.label4.Text = "وه\u200cره\u200cقه\u200cی دروست / عدد الاوراق الصحیحه\u200c";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(label4_MouseMove);
		this.txtwaraqadrost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtwaraqadrost.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtwaraqadrost.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txtwaraqadrost.Location = new System.Drawing.Point(480, 3);
		this.txtwaraqadrost.Multiline = true;
		this.txtwaraqadrost.Name = "txtwaraqadrost";
		this.txtwaraqadrost.Size = new System.Drawing.Size(65, 54);
		this.txtwaraqadrost.TabIndex = 1;
		this.txtwaraqadrost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtwaraqadrost.KeyDown += new System.Windows.Forms.KeyEventHandler(txtwaraqadrost_KeyDown);
		this.txtwaraqadrost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtwaraqadrost_KeyPress);
		this.label5.AutoSize = true;
		this.label5.BackColor = System.Drawing.Color.White;
		this.label5.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.Red;
		this.label5.Location = new System.Drawing.Point(241, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(191, 58);
		this.label5.TabIndex = 10;
		this.label5.Text = "وه\u200cره\u200cقه\u200cی پوچه\u200cڵ / عدد الاوراق الباطلة\u200c";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtwaraqaybatl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtwaraqaybatl.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtwaraqaybatl.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txtwaraqaybatl.Location = new System.Drawing.Point(156, 3);
		this.txtwaraqaybatl.Multiline = true;
		this.txtwaraqaybatl.Name = "txtwaraqaybatl";
		this.txtwaraqaybatl.Size = new System.Drawing.Size(79, 54);
		this.txtwaraqaybatl.TabIndex = 2;
		this.txtwaraqaybatl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtwaraqaybatl.KeyDown += new System.Windows.Forms.KeyEventHandler(txtwaraqaybatl_KeyDown);
		this.txtwaraqaybatl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtwaraqaybatl_KeyPress);
		this.txt_total_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_total_h.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_total_h.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txt_total_h.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txt_total_h.Location = new System.Drawing.Point(987, 3);
		this.txt_total_h.Multiline = true;
		this.txt_total_h.Name = "txt_total_h";
		this.txt_total_h.ReadOnly = true;
		this.txt_total_h.Size = new System.Drawing.Size(69, 55);
		this.txt_total_h.TabIndex = 179;
		this.txt_total_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txt_total_h.TextChanged += new System.EventHandler(txt_total_h_TextChanged);
		this.btn_candid_h.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.btn_candid_h.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.btn_candid_h.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
		this.btn_candid_h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_candid_h.Font = new System.Drawing.Font("Unikurd Seyran", 16.2f);
		this.btn_candid_h.ForeColor = System.Drawing.Color.Black;
		this.btn_candid_h.Location = new System.Drawing.Point(1062, 3);
		this.btn_candid_h.Name = "btn_candid_h";
		this.btn_candid_h.Size = new System.Drawing.Size(237, 55);
		this.btn_candid_h.TabIndex = 54;
		this.btn_candid_h.Text = "هەولێر";
		this.btn_candid_h.UseVisualStyleBackColor = false;
		this.btn_candid_h.Click += new System.EventHandler(button1_Click);
		this.panel1.AutoScroll = true;
		this.panel1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.panel1.Controls.Add(this.tableLayoutPanel7);
		this.panel1.Controls.Add(this.tableLayoutPanel3);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 173);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1357, 660);
		this.panel1.TabIndex = 10;
		this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tableLayoutPanel7.ColumnCount = 19;
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25f));
		this.tableLayoutPanel7.Controls.Add(this.h235, 15, 31);
		this.tableLayoutPanel7.Controls.Add(this.h178, 15, 2);
		this.tableLayoutPanel7.Controls.Add(this.h234, 15, 30);
		this.tableLayoutPanel7.Controls.Add(this.h170, 17, 31);
		this.tableLayoutPanel7.Controls.Add(this.h233, 15, 29);
		this.tableLayoutPanel7.Controls.Add(this.label297, 16, 31);
		this.tableLayoutPanel7.Controls.Add(this.h229, 15, 28);
		this.tableLayoutPanel7.Controls.Add(this.h176, 15, 1);
		this.tableLayoutPanel7.Controls.Add(this.label293, 16, 30);
		this.tableLayoutPanel7.Controls.Add(this.label315, 16, 0);
		this.tableLayoutPanel7.Controls.Add(this.h173, 15, 0);
		this.tableLayoutPanel7.Controls.Add(this.h169, 17, 30);
		this.tableLayoutPanel7.Controls.Add(this.label289, 16, 29);
		this.tableLayoutPanel7.Controls.Add(this.label323, 16, 2);
		this.tableLayoutPanel7.Controls.Add(this.label285, 16, 28);
		this.tableLayoutPanel7.Controls.Add(this.h223, 15, 27);
		this.tableLayoutPanel7.Controls.Add(this.h220, 15, 26);
		this.tableLayoutPanel7.Controls.Add(this.label311, 18, 31);
		this.tableLayoutPanel7.Controls.Add(this.label319, 16, 1);
		this.tableLayoutPanel7.Controls.Add(this.h167, 17, 29);
		this.tableLayoutPanel7.Controls.Add(this.h219, 15, 25);
		this.tableLayoutPanel7.Controls.Add(this.h164, 17, 28);
		this.tableLayoutPanel7.Controls.Add(this.h217, 15, 24);
		this.tableLayoutPanel7.Controls.Add(this.label281, 16, 27);
		this.tableLayoutPanel7.Controls.Add(this.h162, 17, 27);
		this.tableLayoutPanel7.Controls.Add(this.label277, 16, 26);
		this.tableLayoutPanel7.Controls.Add(this.label307, 18, 30);
		this.tableLayoutPanel7.Controls.Add(this.h161, 17, 26);
		this.tableLayoutPanel7.Controls.Add(this.h160, 17, 25);
		this.tableLayoutPanel7.Controls.Add(this.label269, 16, 24);
		this.tableLayoutPanel7.Controls.Add(this.label303, 18, 29);
		this.tableLayoutPanel7.Controls.Add(this.label299, 18, 28);
		this.tableLayoutPanel7.Controls.Add(this.h158, 17, 24);
		this.tableLayoutPanel7.Controls.Add(this.label295, 18, 27);
		this.tableLayoutPanel7.Controls.Add(this.h151, 17, 20);
		this.tableLayoutPanel7.Controls.Add(this.h150, 17, 19);
		this.tableLayoutPanel7.Controls.Add(this.h154, 17, 21);
		this.tableLayoutPanel7.Controls.Add(this.h149, 17, 18);
		this.tableLayoutPanel7.Controls.Add(this.label291, 18, 26);
		this.tableLayoutPanel7.Controls.Add(this.h157, 17, 23);
		this.tableLayoutPanel7.Controls.Add(this.h156, 17, 22);
		this.tableLayoutPanel7.Controls.Add(this.h148, 17, 17);
		this.tableLayoutPanel7.Controls.Add(this.h147, 17, 16);
		this.tableLayoutPanel7.Controls.Add(this.h146, 17, 15);
		this.tableLayoutPanel7.Controls.Add(this.h144, 17, 14);
		this.tableLayoutPanel7.Controls.Add(this.label287, 18, 25);
		this.tableLayoutPanel7.Controls.Add(this.h139, 17, 13);
		this.tableLayoutPanel7.Controls.Add(this.h133, 17, 12);
		this.tableLayoutPanel7.Controls.Add(this.h131, 17, 11);
		this.tableLayoutPanel7.Controls.Add(this.label267, 18, 20);
		this.tableLayoutPanel7.Controls.Add(this.label263, 18, 19);
		this.tableLayoutPanel7.Controls.Add(this.label283, 18, 24);
		this.tableLayoutPanel7.Controls.Add(this.label259, 18, 18);
		this.tableLayoutPanel7.Controls.Add(this.label255, 18, 17);
		this.tableLayoutPanel7.Controls.Add(this.label279, 18, 23);
		this.tableLayoutPanel7.Controls.Add(this.label251, 18, 16);
		this.tableLayoutPanel7.Controls.Add(this.label247, 18, 15);
		this.tableLayoutPanel7.Controls.Add(this.label69, 18, 14);
		this.tableLayoutPanel7.Controls.Add(this.label275, 18, 22);
		this.tableLayoutPanel7.Controls.Add(this.label72, 18, 13);
		this.tableLayoutPanel7.Controls.Add(this.label76, 18, 12);
		this.tableLayoutPanel7.Controls.Add(this.label80, 18, 11);
		this.tableLayoutPanel7.Controls.Add(this.label271, 18, 21);
		this.tableLayoutPanel7.Controls.Add(this.label399, 13, 26);
		this.tableLayoutPanel7.Controls.Add(this.label395, 13, 25);
		this.tableLayoutPanel7.Controls.Add(this.label391, 13, 24);
		this.tableLayoutPanel7.Controls.Add(this.s161, 12, 27);
		this.tableLayoutPanel7.Controls.Add(this.label387, 13, 23);
		this.tableLayoutPanel7.Controls.Add(this.s157, 12, 26);
		this.tableLayoutPanel7.Controls.Add(this.s153, 12, 25);
		this.tableLayoutPanel7.Controls.Add(this.s148, 12, 24);
		this.tableLayoutPanel7.Controls.Add(this.s147, 12, 23);
		this.tableLayoutPanel7.Controls.Add(this.s145, 12, 22);
		this.tableLayoutPanel7.Controls.Add(this.s138, 12, 21);
		this.tableLayoutPanel7.Controls.Add(this.s137, 12, 20);
		this.tableLayoutPanel7.Controls.Add(this.label383, 13, 22);
		this.tableLayoutPanel7.Controls.Add(this.label379, 13, 21);
		this.tableLayoutPanel7.Controls.Add(this.label375, 13, 20);
		this.tableLayoutPanel7.Controls.Add(this.d211, 5, 13);
		this.tableLayoutPanel7.Controls.Add(this.d200, 5, 12);
		this.tableLayoutPanel7.Controls.Add(this.d197, 5, 11);
		this.tableLayoutPanel7.Controls.Add(this.d196, 5, 10);
		this.tableLayoutPanel7.Controls.Add(this.d195, 5, 9);
		this.tableLayoutPanel7.Controls.Add(this.d190, 5, 8);
		this.tableLayoutPanel7.Controls.Add(this.label213, 6, 13);
		this.tableLayoutPanel7.Controls.Add(this.label209, 6, 12);
		this.tableLayoutPanel7.Controls.Add(this.label205, 6, 11);
		this.tableLayoutPanel7.Controls.Add(this.label201, 6, 10);
		this.tableLayoutPanel7.Controls.Add(this.label197, 6, 9);
		this.tableLayoutPanel7.Controls.Add(this.label193, 6, 8);
		this.tableLayoutPanel7.Controls.Add(this.label157, 8, 20);
		this.tableLayoutPanel7.Controls.Add(this.label153, 8, 19);
		this.tableLayoutPanel7.Controls.Add(this.label12, 18, 0);
		this.tableLayoutPanel7.Controls.Add(this.h102, 17, 0);
		this.tableLayoutPanel7.Controls.Add(this.hl147, 2, 4);
		this.tableLayoutPanel7.Controls.Add(this.hl172, 0, 4);
		this.tableLayoutPanel7.Controls.Add(this.hl133, 2, 3);
		this.tableLayoutPanel7.Controls.Add(this.label114, 1, 4);
		this.tableLayoutPanel7.Controls.Add(this.label99, 3, 4);
		this.tableLayoutPanel7.Controls.Add(this.hl129, 2, 2);
		this.tableLayoutPanel7.Controls.Add(this.hl169, 0, 3);
		this.tableLayoutPanel7.Controls.Add(this.label15, 13, 0);
		this.tableLayoutPanel7.Controls.Add(this.d161, 7, 20);
		this.tableLayoutPanel7.Controls.Add(this.label112, 1, 3);
		this.tableLayoutPanel7.Controls.Add(this.hl123, 2, 1);
		this.tableLayoutPanel7.Controls.Add(this.d159, 7, 19);
		this.tableLayoutPanel7.Controls.Add(this.label97, 3, 3);
		this.tableLayoutPanel7.Controls.Add(this.s101, 12, 0);
		this.tableLayoutPanel7.Controls.Add(this.label109, 1, 2);
		this.tableLayoutPanel7.Controls.Add(this.hl114, 2, 0);
		this.tableLayoutPanel7.Controls.Add(this.label95, 3, 2);
		this.tableLayoutPanel7.Controls.Add(this.hl162, 0, 1);
		this.tableLayoutPanel7.Controls.Add(this.label107, 1, 1);
		this.tableLayoutPanel7.Controls.Add(this.label50, 8, 0);
		this.tableLayoutPanel7.Controls.Add(this.d107, 7, 0);
		this.tableLayoutPanel7.Controls.Add(this.label92, 3, 1);
		this.tableLayoutPanel7.Controls.Add(this.hl161, 0, 0);
		this.tableLayoutPanel7.Controls.Add(this.label105, 1, 0);
		this.tableLayoutPanel7.Controls.Add(this.d148, 7, 15);
		this.tableLayoutPanel7.Controls.Add(this.d147, 7, 14);
		this.tableLayoutPanel7.Controls.Add(this.d143, 7, 13);
		this.tableLayoutPanel7.Controls.Add(this.d142, 7, 12);
		this.tableLayoutPanel7.Controls.Add(this.d141, 7, 11);
		this.tableLayoutPanel7.Controls.Add(this.d140, 7, 10);
		this.tableLayoutPanel7.Controls.Add(this.d134, 7, 9);
		this.tableLayoutPanel7.Controls.Add(this.d133, 7, 8);
		this.tableLayoutPanel7.Controls.Add(this.label60, 8, 8);
		this.tableLayoutPanel7.Controls.Add(this.s136, 12, 19);
		this.tableLayoutPanel7.Controls.Add(this.label117, 8, 10);
		this.tableLayoutPanel7.Controls.Add(this.label129, 8, 13);
		this.tableLayoutPanel7.Controls.Add(this.label125, 8, 12);
		this.tableLayoutPanel7.Controls.Add(this.label121, 8, 11);
		this.tableLayoutPanel7.Controls.Add(this.label113, 8, 9);
		this.tableLayoutPanel7.Controls.Add(this.s135, 12, 18);
		this.tableLayoutPanel7.Controls.Add(this.label371, 13, 19);
		this.tableLayoutPanel7.Controls.Add(this.label90, 3, 0);
		this.tableLayoutPanel7.Controls.Add(this.label19, 18, 1);
		this.tableLayoutPanel7.Controls.Add(this.h103, 17, 1);
		this.tableLayoutPanel7.Controls.Add(this.d126, 7, 4);
		this.tableLayoutPanel7.Controls.Add(this.label18, 13, 1);
		this.tableLayoutPanel7.Controls.Add(this.s104, 12, 1);
		this.tableLayoutPanel7.Controls.Add(this.label52, 8, 1);
		this.tableLayoutPanel7.Controls.Add(this.d108, 7, 1);
		this.tableLayoutPanel7.Controls.Add(this.d118, 7, 3);
		this.tableLayoutPanel7.Controls.Add(this.label23, 18, 2);
		this.tableLayoutPanel7.Controls.Add(this.h105, 17, 2);
		this.tableLayoutPanel7.Controls.Add(this.s114, 12, 4);
		this.tableLayoutPanel7.Controls.Add(this.d114, 7, 2);
		this.tableLayoutPanel7.Controls.Add(this.label22, 13, 2);
		this.tableLayoutPanel7.Controls.Add(this.s110, 12, 2);
		this.tableLayoutPanel7.Controls.Add(this.label54, 8, 2);
		this.tableLayoutPanel7.Controls.Add(this.s113, 12, 3);
		this.tableLayoutPanel7.Controls.Add(this.hl164, 0, 2);
		this.tableLayoutPanel7.Controls.Add(this.label27, 18, 3);
		this.tableLayoutPanel7.Controls.Add(this.h106, 17, 3);
		this.tableLayoutPanel7.Controls.Add(this.label58, 8, 4);
		this.tableLayoutPanel7.Controls.Add(this.label26, 13, 3);
		this.tableLayoutPanel7.Controls.Add(this.label56, 8, 3);
		this.tableLayoutPanel7.Controls.Add(this.label31, 18, 4);
		this.tableLayoutPanel7.Controls.Add(this.h109, 17, 4);
		this.tableLayoutPanel7.Controls.Add(this.label30, 13, 4);
		this.tableLayoutPanel7.Controls.Add(this.label35, 18, 5);
		this.tableLayoutPanel7.Controls.Add(this.h111, 17, 5);
		this.tableLayoutPanel7.Controls.Add(this.h112, 17, 6);
		this.tableLayoutPanel7.Controls.Add(this.h114, 17, 7);
		this.tableLayoutPanel7.Controls.Add(this.label39, 18, 6);
		this.tableLayoutPanel7.Controls.Add(this.label43, 18, 7);
		this.tableLayoutPanel7.Controls.Add(this.label34, 13, 5);
		this.tableLayoutPanel7.Controls.Add(this.label38, 13, 6);
		this.tableLayoutPanel7.Controls.Add(this.label42, 13, 7);
		this.tableLayoutPanel7.Controls.Add(this.label46, 13, 8);
		this.tableLayoutPanel7.Controls.Add(this.label48, 13, 9);
		this.tableLayoutPanel7.Controls.Add(this.label73, 13, 10);
		this.tableLayoutPanel7.Controls.Add(this.s115, 12, 5);
		this.tableLayoutPanel7.Controls.Add(this.s116, 12, 6);
		this.tableLayoutPanel7.Controls.Add(this.s117, 12, 7);
		this.tableLayoutPanel7.Controls.Add(this.s119, 12, 8);
		this.tableLayoutPanel7.Controls.Add(this.s121, 12, 9);
		this.tableLayoutPanel7.Controls.Add(this.s122, 12, 10);
		this.tableLayoutPanel7.Controls.Add(this.label101, 3, 5);
		this.tableLayoutPanel7.Controls.Add(this.label103, 3, 6);
		this.tableLayoutPanel7.Controls.Add(this.hl148, 2, 5);
		this.tableLayoutPanel7.Controls.Add(this.hl157, 2, 6);
		this.tableLayoutPanel7.Controls.Add(this.label120, 1, 5);
		this.tableLayoutPanel7.Controls.Add(this.label124, 1, 6);
		this.tableLayoutPanel7.Controls.Add(this.hl190, 0, 5);
		this.tableLayoutPanel7.Controls.Add(this.hl198, 0, 6);
		this.tableLayoutPanel7.Controls.Add(this.d127, 7, 5);
		this.tableLayoutPanel7.Controls.Add(this.d129, 7, 6);
		this.tableLayoutPanel7.Controls.Add(this.d132, 7, 7);
		this.tableLayoutPanel7.Controls.Add(this.label66, 8, 5);
		this.tableLayoutPanel7.Controls.Add(this.label65, 8, 6);
		this.tableLayoutPanel7.Controls.Add(this.label62, 8, 7);
		this.tableLayoutPanel7.Controls.Add(this.label47, 18, 8);
		this.tableLayoutPanel7.Controls.Add(this.label88, 18, 9);
		this.tableLayoutPanel7.Controls.Add(this.label84, 18, 10);
		this.tableLayoutPanel7.Controls.Add(this.h120, 17, 8);
		this.tableLayoutPanel7.Controls.Add(this.h123, 17, 9);
		this.tableLayoutPanel7.Controls.Add(this.h129, 17, 10);
		this.tableLayoutPanel7.Controls.Add(this.label77, 13, 11);
		this.tableLayoutPanel7.Controls.Add(this.label81, 13, 12);
		this.tableLayoutPanel7.Controls.Add(this.label85, 13, 13);
		this.tableLayoutPanel7.Controls.Add(this.label89, 13, 14);
		this.tableLayoutPanel7.Controls.Add(this.label355, 13, 15);
		this.tableLayoutPanel7.Controls.Add(this.label359, 13, 16);
		this.tableLayoutPanel7.Controls.Add(this.label363, 13, 17);
		this.tableLayoutPanel7.Controls.Add(this.s123, 12, 11);
		this.tableLayoutPanel7.Controls.Add(this.s124, 12, 12);
		this.tableLayoutPanel7.Controls.Add(this.s125, 12, 13);
		this.tableLayoutPanel7.Controls.Add(this.s128, 12, 14);
		this.tableLayoutPanel7.Controls.Add(this.s129, 12, 15);
		this.tableLayoutPanel7.Controls.Add(this.s130, 12, 16);
		this.tableLayoutPanel7.Controls.Add(this.s133, 12, 17);
		this.tableLayoutPanel7.Controls.Add(this.label367, 13, 18);
		this.tableLayoutPanel7.Controls.Add(this.label133, 8, 14);
		this.tableLayoutPanel7.Controls.Add(this.label137, 8, 15);
		this.tableLayoutPanel7.Controls.Add(this.label141, 8, 16);
		this.tableLayoutPanel7.Controls.Add(this.label145, 8, 17);
		this.tableLayoutPanel7.Controls.Add(this.label149, 8, 18);
		this.tableLayoutPanel7.Controls.Add(this.d152, 7, 16);
		this.tableLayoutPanel7.Controls.Add(this.d155, 7, 17);
		this.tableLayoutPanel7.Controls.Add(this.d157, 7, 18);
		this.tableLayoutPanel7.Controls.Add(this.label161, 6, 0);
		this.tableLayoutPanel7.Controls.Add(this.d162, 5, 0);
		this.tableLayoutPanel7.Controls.Add(this.label165, 6, 1);
		this.tableLayoutPanel7.Controls.Add(this.d163, 5, 1);
		this.tableLayoutPanel7.Controls.Add(this.label169, 6, 2);
		this.tableLayoutPanel7.Controls.Add(this.d164, 5, 2);
		this.tableLayoutPanel7.Controls.Add(this.label173, 6, 3);
		this.tableLayoutPanel7.Controls.Add(this.d169, 5, 3);
		this.tableLayoutPanel7.Controls.Add(this.label177, 6, 4);
		this.tableLayoutPanel7.Controls.Add(this.d175, 5, 4);
		this.tableLayoutPanel7.Controls.Add(this.label181, 6, 5);
		this.tableLayoutPanel7.Controls.Add(this.d177, 5, 5);
		this.tableLayoutPanel7.Controls.Add(this.label185, 6, 6);
		this.tableLayoutPanel7.Controls.Add(this.d186, 5, 6);
		this.tableLayoutPanel7.Controls.Add(this.label189, 6, 7);
		this.tableLayoutPanel7.Controls.Add(this.d188, 5, 7);
		this.tableLayoutPanel7.Controls.Add(this.label91, 6, 14);
		this.tableLayoutPanel7.Controls.Add(this.d213, 5, 14);
		this.tableLayoutPanel7.Controls.Add(this.label94, 6, 15);
		this.tableLayoutPanel7.Controls.Add(this.label53, 6, 16);
		this.tableLayoutPanel7.Controls.Add(this.label55, 6, 17);
		this.tableLayoutPanel7.Controls.Add(this.label57, 6, 18);
		this.tableLayoutPanel7.Controls.Add(this.label64, 6, 19);
		this.tableLayoutPanel7.Controls.Add(this.d222, 5, 15);
		this.tableLayoutPanel7.Controls.Add(this.d224, 5, 16);
		this.tableLayoutPanel7.Controls.Add(this.d225, 5, 17);
		this.tableLayoutPanel7.Controls.Add(this.d227, 5, 18);
		this.tableLayoutPanel7.Controls.Add(this.d232, 5, 19);
		this.tableLayoutPanel7.Controls.Add(this.label403, 13, 27);
		this.tableLayoutPanel7.Controls.Add(this.label14, 16, 3);
		this.tableLayoutPanel7.Controls.Add(this.label17, 16, 4);
		this.tableLayoutPanel7.Controls.Add(this.label21, 16, 5);
		this.tableLayoutPanel7.Controls.Add(this.label25, 16, 6);
		this.tableLayoutPanel7.Controls.Add(this.label29, 16, 7);
		this.tableLayoutPanel7.Controls.Add(this.label33, 16, 8);
		this.tableLayoutPanel7.Controls.Add(this.h179, 15, 3);
		this.tableLayoutPanel7.Controls.Add(this.h181, 15, 4);
		this.tableLayoutPanel7.Controls.Add(this.h184, 15, 5);
		this.tableLayoutPanel7.Controls.Add(this.h187, 15, 6);
		this.tableLayoutPanel7.Controls.Add(this.h189, 15, 7);
		this.tableLayoutPanel7.Controls.Add(this.h190, 15, 8);
		this.tableLayoutPanel7.Controls.Add(this.label37, 16, 9);
		this.tableLayoutPanel7.Controls.Add(this.label41, 16, 10);
		this.tableLayoutPanel7.Controls.Add(this.label45, 16, 11);
		this.tableLayoutPanel7.Controls.Add(this.label86, 16, 12);
		this.tableLayoutPanel7.Controls.Add(this.label82, 16, 13);
		this.tableLayoutPanel7.Controls.Add(this.label78, 16, 14);
		this.tableLayoutPanel7.Controls.Add(this.label74, 16, 15);
		this.tableLayoutPanel7.Controls.Add(this.h191, 15, 9);
		this.tableLayoutPanel7.Controls.Add(this.h198, 15, 10);
		this.tableLayoutPanel7.Controls.Add(this.h199, 15, 11);
		this.tableLayoutPanel7.Controls.Add(this.h202, 15, 12);
		this.tableLayoutPanel7.Controls.Add(this.h203, 15, 13);
		this.tableLayoutPanel7.Controls.Add(this.h204, 15, 14);
		this.tableLayoutPanel7.Controls.Add(this.h205, 15, 15);
		this.tableLayoutPanel7.Controls.Add(this.label70, 16, 16);
		this.tableLayoutPanel7.Controls.Add(this.label67, 16, 17);
		this.tableLayoutPanel7.Controls.Add(this.label245, 16, 18);
		this.tableLayoutPanel7.Controls.Add(this.label249, 16, 19);
		this.tableLayoutPanel7.Controls.Add(this.label253, 16, 20);
		this.tableLayoutPanel7.Controls.Add(this.label257, 16, 21);
		this.tableLayoutPanel7.Controls.Add(this.label261, 16, 22);
		this.tableLayoutPanel7.Controls.Add(this.label265, 16, 23);
		this.tableLayoutPanel7.Controls.Add(this.h206, 15, 16);
		this.tableLayoutPanel7.Controls.Add(this.h208, 15, 17);
		this.tableLayoutPanel7.Controls.Add(this.h209, 15, 18);
		this.tableLayoutPanel7.Controls.Add(this.h210, 15, 19);
		this.tableLayoutPanel7.Controls.Add(this.h212, 15, 20);
		this.tableLayoutPanel7.Controls.Add(this.h214, 15, 21);
		this.tableLayoutPanel7.Controls.Add(this.h215, 15, 22);
		this.tableLayoutPanel7.Controls.Add(this.h216, 15, 23);
		this.tableLayoutPanel7.Controls.Add(this.label273, 16, 25);
		this.tableLayoutPanel7.Controls.Add(this.label357, 11, 23);
		this.tableLayoutPanel7.Controls.Add(this.s230, 10, 23);
		this.tableLayoutPanel7.Controls.Add(this.label353, 11, 22);
		this.tableLayoutPanel7.Controls.Add(this.s228, 10, 22);
		this.tableLayoutPanel7.Controls.Add(this.label87, 11, 21);
		this.tableLayoutPanel7.Controls.Add(this.s226, 10, 21);
		this.tableLayoutPanel7.Controls.Add(this.label83, 11, 20);
		this.tableLayoutPanel7.Controls.Add(this.s221, 10, 20);
		this.tableLayoutPanel7.Controls.Add(this.label79, 11, 19);
		this.tableLayoutPanel7.Controls.Add(this.s218, 10, 19);
		this.tableLayoutPanel7.Controls.Add(this.label75, 11, 18);
		this.tableLayoutPanel7.Controls.Add(this.s207, 10, 18);
		this.tableLayoutPanel7.Controls.Add(this.s201, 10, 17);
		this.tableLayoutPanel7.Controls.Add(this.label71, 11, 17);
		this.tableLayoutPanel7.Controls.Add(this.label68, 11, 16);
		this.tableLayoutPanel7.Controls.Add(this.s198, 10, 16);
		this.tableLayoutPanel7.Controls.Add(this.s194, 10, 15);
		this.tableLayoutPanel7.Controls.Add(this.label44, 11, 15);
		this.tableLayoutPanel7.Controls.Add(this.label40, 11, 14);
		this.tableLayoutPanel7.Controls.Add(this.s193, 10, 14);
		this.tableLayoutPanel7.Controls.Add(this.label36, 11, 13);
		this.tableLayoutPanel7.Controls.Add(this.s192, 10, 13);
		this.tableLayoutPanel7.Controls.Add(this.label32, 11, 12);
		this.tableLayoutPanel7.Controls.Add(this.s190, 10, 12);
		this.tableLayoutPanel7.Controls.Add(this.s185, 10, 11);
		this.tableLayoutPanel7.Controls.Add(this.s183, 10, 10);
		this.tableLayoutPanel7.Controls.Add(this.s182, 10, 9);
		this.tableLayoutPanel7.Controls.Add(this.label28, 11, 11);
		this.tableLayoutPanel7.Controls.Add(this.label24, 11, 10);
		this.tableLayoutPanel7.Controls.Add(this.label20, 11, 9);
		this.tableLayoutPanel7.Controls.Add(this.label16, 11, 8);
		this.tableLayoutPanel7.Controls.Add(this.s180, 10, 8);
		this.tableLayoutPanel7.Controls.Add(this.label13, 11, 7);
		this.tableLayoutPanel7.Controls.Add(this.s174, 10, 7);
		this.tableLayoutPanel7.Controls.Add(this.label431, 11, 6);
		this.tableLayoutPanel7.Controls.Add(this.s171, 10, 6);
		this.tableLayoutPanel7.Controls.Add(this.label427, 11, 5);
		this.tableLayoutPanel7.Controls.Add(this.s169, 10, 5);
		this.tableLayoutPanel7.Controls.Add(this.label423, 11, 4);
		this.tableLayoutPanel7.Controls.Add(this.s168, 10, 4);
		this.tableLayoutPanel7.Controls.Add(this.label361, 11, 24);
		this.tableLayoutPanel7.Controls.Add(this.s231, 10, 24);
		this.tableLayoutPanel7.Controls.Add(this.s236, 10, 25);
		this.tableLayoutPanel7.Controls.Add(this.label365, 11, 25);
		this.tableLayoutPanel7.Controls.Add(this.label419, 11, 3);
		this.tableLayoutPanel7.Controls.Add(this.s166, 10, 3);
		this.tableLayoutPanel7.Controls.Add(this.label415, 11, 2);
		this.tableLayoutPanel7.Controls.Add(this.s165, 10, 2);
		this.tableLayoutPanel7.Controls.Add(this.label411, 11, 1);
		this.tableLayoutPanel7.Controls.Add(this.s164, 10, 1);
		this.tableLayoutPanel7.Controls.Add(this.label407, 11, 0);
		this.tableLayoutPanel7.Controls.Add(this.s162, 10, 0);
		this.tableLayoutPanel7.Controls.Add(this.lbl_taswit, 4, 0);
		this.tableLayoutPanel7.Controls.Add(this.labljorydangdan, 4, 1);
		this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 72);
		this.tableLayoutPanel7.Name = "tableLayoutPanel7";
		this.tableLayoutPanel7.RowCount = 32;
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.125f));
		this.tableLayoutPanel7.Size = new System.Drawing.Size(1306, 1755);
		this.tableLayoutPanel7.TabIndex = 11;
		this.h235.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h235.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h235.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h235.Location = new System.Drawing.Point(1001, 1677);
		this.h235.Multiline = true;
		this.h235.Name = "h235";
		this.h235.Size = new System.Drawing.Size(70, 75);
		this.h235.TabIndex = 62;
		this.h235.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h235.Click += new System.EventHandler(h235_Click_1);
		this.h235.TextChanged += new System.EventHandler(h235_TextChanged_1);
		this.h235.KeyDown += new System.Windows.Forms.KeyEventHandler(h235_KeyDown_1);
		this.h235.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h235_KeyPress);
		this.h235.Leave += new System.EventHandler(h235_Leave_1);
		this.h178.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h178.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h178.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h178.Location = new System.Drawing.Point(1001, 111);
		this.h178.Multiline = true;
		this.h178.Name = "h178";
		this.h178.Size = new System.Drawing.Size(70, 48);
		this.h178.TabIndex = 33;
		this.h178.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h178.Click += new System.EventHandler(h178_Click_1);
		this.h178.TextChanged += new System.EventHandler(h178_TextChanged_1);
		this.h178.KeyDown += new System.Windows.Forms.KeyEventHandler(h178_KeyDown_1);
		this.h178.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h178_KeyPress_1);
		this.h178.Leave += new System.EventHandler(h178_Leave_1);
		this.h234.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h234.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h234.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h234.Location = new System.Drawing.Point(1001, 1623);
		this.h234.Multiline = true;
		this.h234.Name = "h234";
		this.h234.Size = new System.Drawing.Size(70, 48);
		this.h234.TabIndex = 61;
		this.h234.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h234.Click += new System.EventHandler(h234_Click_1);
		this.h234.TextChanged += new System.EventHandler(h234_TextChanged_1);
		this.h234.KeyDown += new System.Windows.Forms.KeyEventHandler(h234_KeyDown_1);
		this.h234.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h234_KeyPress_1);
		this.h234.Leave += new System.EventHandler(h234_Leave_1);
		this.h170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h170.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h170.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h170.Location = new System.Drawing.Point(1153, 1677);
		this.h170.Multiline = true;
		this.h170.Name = "h170";
		this.h170.Size = new System.Drawing.Size(70, 75);
		this.h170.TabIndex = 30;
		this.h170.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h170.TextChanged += new System.EventHandler(h170_TextChanged_1);
		this.h170.KeyDown += new System.Windows.Forms.KeyEventHandler(h170_KeyDown_1);
		this.h170.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h170_KeyPress);
		this.h170.Leave += new System.EventHandler(h170_Leave_1);
		this.h233.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h233.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h233.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h233.Location = new System.Drawing.Point(1001, 1569);
		this.h233.Multiline = true;
		this.h233.Name = "h233";
		this.h233.Size = new System.Drawing.Size(70, 48);
		this.h233.TabIndex = 60;
		this.h233.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h233.Click += new System.EventHandler(h233_Click_1);
		this.h233.TextChanged += new System.EventHandler(h233_TextChanged_1);
		this.h233.KeyDown += new System.Windows.Forms.KeyEventHandler(h233_KeyDown_1);
		this.h233.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h233_KeyPress_1);
		this.h233.Leave += new System.EventHandler(h233_Leave_1);
		this.label297.AutoSize = true;
		this.label297.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label297.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label297.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label297.Location = new System.Drawing.Point(1077, 1674);
		this.label297.Name = "label297";
		this.label297.Size = new System.Drawing.Size(59, 37);
		this.label297.TabIndex = 160;
		this.label297.Text = "235";
		this.label297.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h229.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h229.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h229.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h229.Location = new System.Drawing.Point(1001, 1515);
		this.h229.Multiline = true;
		this.h229.Name = "h229";
		this.h229.Size = new System.Drawing.Size(70, 48);
		this.h229.TabIndex = 59;
		this.h229.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h229.Click += new System.EventHandler(h229_Click_1);
		this.h229.TextChanged += new System.EventHandler(h229_TextChanged_1);
		this.h229.KeyDown += new System.Windows.Forms.KeyEventHandler(h229_KeyDown_1);
		this.h229.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h229_KeyPress_1);
		this.h229.Leave += new System.EventHandler(h229_Leave_1);
		this.h176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h176.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h176.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h176.Location = new System.Drawing.Point(1001, 57);
		this.h176.Multiline = true;
		this.h176.Name = "h176";
		this.h176.Size = new System.Drawing.Size(70, 48);
		this.h176.TabIndex = 32;
		this.h176.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h176.Click += new System.EventHandler(h176_Click_1);
		this.h176.TextChanged += new System.EventHandler(h176_TextChanged_1);
		this.h176.KeyDown += new System.Windows.Forms.KeyEventHandler(h176_KeyDown_1);
		this.h176.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h176_KeyPress_1);
		this.h176.Leave += new System.EventHandler(h176_Leave_1);
		this.label293.AutoSize = true;
		this.label293.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label293.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label293.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label293.Location = new System.Drawing.Point(1077, 1620);
		this.label293.Name = "label293";
		this.label293.Size = new System.Drawing.Size(59, 37);
		this.label293.TabIndex = 156;
		this.label293.Text = "234";
		this.label293.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label315.AutoSize = true;
		this.label315.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label315.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label315.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label315.Location = new System.Drawing.Point(1077, 0);
		this.label315.Name = "label315";
		this.label315.Size = new System.Drawing.Size(59, 37);
		this.label315.TabIndex = 178;
		this.label315.Text = "173";
		this.label315.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h173.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h173.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h173.Location = new System.Drawing.Point(1001, 3);
		this.h173.Multiline = true;
		this.h173.Name = "h173";
		this.h173.Size = new System.Drawing.Size(70, 48);
		this.h173.TabIndex = 31;
		this.h173.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h173.Click += new System.EventHandler(h173_Click_1);
		this.h173.TextChanged += new System.EventHandler(h173_TextChanged_1);
		this.h173.KeyDown += new System.Windows.Forms.KeyEventHandler(h173_KeyDown_1);
		this.h173.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h173_KeyPress_1);
		this.h173.Leave += new System.EventHandler(h173_Leave_1);
		this.h169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h169.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h169.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h169.Location = new System.Drawing.Point(1153, 1623);
		this.h169.Multiline = true;
		this.h169.Name = "h169";
		this.h169.Size = new System.Drawing.Size(70, 48);
		this.h169.TabIndex = 29;
		this.h169.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h169.Click += new System.EventHandler(h169_Click_1);
		this.h169.TextChanged += new System.EventHandler(h169_TextChanged_1);
		this.h169.KeyDown += new System.Windows.Forms.KeyEventHandler(h169_KeyDown_1);
		this.h169.Leave += new System.EventHandler(h169_Leave_1);
		this.label289.AutoSize = true;
		this.label289.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label289.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label289.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label289.Location = new System.Drawing.Point(1077, 1566);
		this.label289.Name = "label289";
		this.label289.Size = new System.Drawing.Size(59, 37);
		this.label289.TabIndex = 152;
		this.label289.Text = "233";
		this.label289.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label323.AutoSize = true;
		this.label323.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label323.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label323.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label323.Location = new System.Drawing.Point(1077, 108);
		this.label323.Name = "label323";
		this.label323.Size = new System.Drawing.Size(59, 37);
		this.label323.TabIndex = 186;
		this.label323.Text = "178";
		this.label323.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label285.AutoSize = true;
		this.label285.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label285.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label285.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label285.Location = new System.Drawing.Point(1077, 1512);
		this.label285.Name = "label285";
		this.label285.Size = new System.Drawing.Size(59, 37);
		this.label285.TabIndex = 148;
		this.label285.Text = "229";
		this.label285.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h223.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h223.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h223.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h223.Location = new System.Drawing.Point(1001, 1461);
		this.h223.Multiline = true;
		this.h223.Name = "h223";
		this.h223.Size = new System.Drawing.Size(70, 48);
		this.h223.TabIndex = 58;
		this.h223.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h223.Click += new System.EventHandler(h223_Click_1);
		this.h223.TextChanged += new System.EventHandler(h223_TextChanged_1);
		this.h223.KeyDown += new System.Windows.Forms.KeyEventHandler(h223_KeyDown_1);
		this.h223.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h223_KeyPress_1);
		this.h223.Leave += new System.EventHandler(h223_Leave_1);
		this.h220.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h220.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h220.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h220.Location = new System.Drawing.Point(1001, 1407);
		this.h220.Multiline = true;
		this.h220.Name = "h220";
		this.h220.Size = new System.Drawing.Size(70, 48);
		this.h220.TabIndex = 57;
		this.h220.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h220.Click += new System.EventHandler(h220_Click_1);
		this.h220.TextChanged += new System.EventHandler(h220_TextChanged_1);
		this.h220.KeyDown += new System.Windows.Forms.KeyEventHandler(h220_KeyDown_1);
		this.h220.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h220_KeyPress_1);
		this.h220.Leave += new System.EventHandler(h220_Leave_1);
		this.label311.AutoSize = true;
		this.label311.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label311.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label311.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label311.Location = new System.Drawing.Point(1229, 1674);
		this.label311.Name = "label311";
		this.label311.Size = new System.Drawing.Size(59, 37);
		this.label311.TabIndex = 174;
		this.label311.Text = "170";
		this.label311.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label319.AutoSize = true;
		this.label319.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label319.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label319.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label319.Location = new System.Drawing.Point(1077, 54);
		this.label319.Name = "label319";
		this.label319.Size = new System.Drawing.Size(59, 37);
		this.label319.TabIndex = 182;
		this.label319.Text = "176";
		this.label319.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h167.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h167.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h167.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h167.Location = new System.Drawing.Point(1153, 1569);
		this.h167.Multiline = true;
		this.h167.Name = "h167";
		this.h167.Size = new System.Drawing.Size(70, 48);
		this.h167.TabIndex = 28;
		this.h167.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h167.Click += new System.EventHandler(h167_Click_1);
		this.h167.TextChanged += new System.EventHandler(h167_TextChanged_1);
		this.h167.KeyDown += new System.Windows.Forms.KeyEventHandler(h167_KeyDown_1);
		this.h167.Leave += new System.EventHandler(h167_Leave_1);
		this.h219.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h219.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h219.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h219.Location = new System.Drawing.Point(1001, 1353);
		this.h219.Multiline = true;
		this.h219.Name = "h219";
		this.h219.Size = new System.Drawing.Size(70, 48);
		this.h219.TabIndex = 56;
		this.h219.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h219.Click += new System.EventHandler(h219_Click_1);
		this.h219.TextChanged += new System.EventHandler(h219_TextChanged_1);
		this.h219.KeyDown += new System.Windows.Forms.KeyEventHandler(h219_KeyDown_1);
		this.h219.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h219_KeyPress_1);
		this.h219.Leave += new System.EventHandler(h219_Leave_1);
		this.h164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h164.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h164.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h164.Location = new System.Drawing.Point(1153, 1515);
		this.h164.Multiline = true;
		this.h164.Name = "h164";
		this.h164.Size = new System.Drawing.Size(70, 48);
		this.h164.TabIndex = 27;
		this.h164.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h164.Click += new System.EventHandler(h164_Click_1);
		this.h164.TextChanged += new System.EventHandler(h164_TextChanged_1);
		this.h164.KeyDown += new System.Windows.Forms.KeyEventHandler(h164_KeyDown_1);
		this.h164.Leave += new System.EventHandler(h164_Leave_1);
		this.h217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h217.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h217.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h217.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h217.Location = new System.Drawing.Point(1001, 1299);
		this.h217.Multiline = true;
		this.h217.Name = "h217";
		this.h217.Size = new System.Drawing.Size(70, 48);
		this.h217.TabIndex = 55;
		this.h217.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h217.Click += new System.EventHandler(h217_Click_1);
		this.h217.TextChanged += new System.EventHandler(h217_TextChanged_1);
		this.h217.KeyDown += new System.Windows.Forms.KeyEventHandler(h217_KeyDown_1);
		this.h217.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h217_KeyPress_1);
		this.h217.Leave += new System.EventHandler(h217_Leave_1);
		this.label281.AutoSize = true;
		this.label281.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label281.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label281.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label281.Location = new System.Drawing.Point(1077, 1458);
		this.label281.Name = "label281";
		this.label281.Size = new System.Drawing.Size(59, 37);
		this.label281.TabIndex = 144;
		this.label281.Text = "223";
		this.label281.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h162.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h162.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h162.Location = new System.Drawing.Point(1153, 1461);
		this.h162.Multiline = true;
		this.h162.Name = "h162";
		this.h162.Size = new System.Drawing.Size(70, 48);
		this.h162.TabIndex = 26;
		this.h162.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h162.Click += new System.EventHandler(h162_Click_1);
		this.h162.TextChanged += new System.EventHandler(h162_TextChanged_1);
		this.h162.KeyDown += new System.Windows.Forms.KeyEventHandler(h162_KeyDown_1);
		this.h162.Leave += new System.EventHandler(h162_Leave_1);
		this.label277.AutoSize = true;
		this.label277.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label277.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label277.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label277.Location = new System.Drawing.Point(1077, 1404);
		this.label277.Name = "label277";
		this.label277.Size = new System.Drawing.Size(59, 37);
		this.label277.TabIndex = 140;
		this.label277.Text = "220";
		this.label277.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label307.AutoSize = true;
		this.label307.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label307.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label307.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label307.Location = new System.Drawing.Point(1229, 1620);
		this.label307.Name = "label307";
		this.label307.Size = new System.Drawing.Size(59, 37);
		this.label307.TabIndex = 170;
		this.label307.Text = "169";
		this.label307.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h161.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h161.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h161.Location = new System.Drawing.Point(1153, 1407);
		this.h161.Multiline = true;
		this.h161.Name = "h161";
		this.h161.Size = new System.Drawing.Size(70, 48);
		this.h161.TabIndex = 26;
		this.h161.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h161.Click += new System.EventHandler(h161_Click_1);
		this.h161.TextChanged += new System.EventHandler(h161_TextChanged_1);
		this.h161.KeyDown += new System.Windows.Forms.KeyEventHandler(h161_KeyDown_1);
		this.h161.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h161_KeyPress_1);
		this.h161.Leave += new System.EventHandler(h161_Leave_1);
		this.h160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h160.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h160.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h160.Location = new System.Drawing.Point(1153, 1353);
		this.h160.Multiline = true;
		this.h160.Name = "h160";
		this.h160.Size = new System.Drawing.Size(70, 48);
		this.h160.TabIndex = 25;
		this.h160.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h160.Click += new System.EventHandler(h160_Click_1);
		this.h160.TextChanged += new System.EventHandler(h160_TextChanged_1);
		this.h160.KeyDown += new System.Windows.Forms.KeyEventHandler(h160_KeyDown_1);
		this.h160.Leave += new System.EventHandler(h160_Leave_1);
		this.label269.AutoSize = true;
		this.label269.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label269.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label269.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label269.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label269.Location = new System.Drawing.Point(1077, 1296);
		this.label269.Name = "label269";
		this.label269.Size = new System.Drawing.Size(70, 54);
		this.label269.TabIndex = 132;
		this.label269.Text = "217";
		this.label269.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label303.AutoSize = true;
		this.label303.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label303.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label303.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label303.Location = new System.Drawing.Point(1229, 1566);
		this.label303.Name = "label303";
		this.label303.Size = new System.Drawing.Size(59, 37);
		this.label303.TabIndex = 166;
		this.label303.Text = "167";
		this.label303.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label299.AutoSize = true;
		this.label299.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label299.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label299.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label299.Location = new System.Drawing.Point(1229, 1512);
		this.label299.Name = "label299";
		this.label299.Size = new System.Drawing.Size(59, 37);
		this.label299.TabIndex = 162;
		this.label299.Text = "164";
		this.label299.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h158.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h158.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h158.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h158.Location = new System.Drawing.Point(1153, 1299);
		this.h158.Multiline = true;
		this.h158.Name = "h158";
		this.h158.Size = new System.Drawing.Size(70, 48);
		this.h158.TabIndex = 24;
		this.h158.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h158.Click += new System.EventHandler(h158_Click_1);
		this.h158.TextChanged += new System.EventHandler(h158_TextChanged_1);
		this.h158.KeyDown += new System.Windows.Forms.KeyEventHandler(h158_KeyDown_1);
		this.h158.Leave += new System.EventHandler(h158_Leave_1);
		this.label295.AutoSize = true;
		this.label295.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label295.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label295.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label295.Location = new System.Drawing.Point(1229, 1458);
		this.label295.Name = "label295";
		this.label295.Size = new System.Drawing.Size(59, 37);
		this.label295.TabIndex = 158;
		this.label295.Text = "162";
		this.label295.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h151.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h151.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h151.Location = new System.Drawing.Point(1153, 1083);
		this.h151.Multiline = true;
		this.h151.Name = "h151";
		this.h151.Size = new System.Drawing.Size(70, 48);
		this.h151.TabIndex = 20;
		this.h151.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h151.Click += new System.EventHandler(h151_Click_1);
		this.h151.TextChanged += new System.EventHandler(h151_TextChanged_1);
		this.h151.KeyDown += new System.Windows.Forms.KeyEventHandler(h151_KeyDown_1);
		this.h151.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h151_KeyPress_1);
		this.h151.Leave += new System.EventHandler(h151_Leave_1);
		this.h150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h150.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h150.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h150.Location = new System.Drawing.Point(1153, 1029);
		this.h150.Multiline = true;
		this.h150.Name = "h150";
		this.h150.Size = new System.Drawing.Size(70, 48);
		this.h150.TabIndex = 19;
		this.h150.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h150.Click += new System.EventHandler(h150_Click_1);
		this.h150.TextChanged += new System.EventHandler(h150_TextChanged_1);
		this.h150.KeyDown += new System.Windows.Forms.KeyEventHandler(h150_KeyDown_1);
		this.h150.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h150_KeyPress_1);
		this.h150.Leave += new System.EventHandler(h150_Leave_1);
		this.h154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h154.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h154.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h154.Location = new System.Drawing.Point(1153, 1137);
		this.h154.Multiline = true;
		this.h154.Name = "h154";
		this.h154.Size = new System.Drawing.Size(70, 48);
		this.h154.TabIndex = 21;
		this.h154.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h154.Click += new System.EventHandler(h154_Click_1);
		this.h154.TextChanged += new System.EventHandler(h154_TextChanged_1);
		this.h154.KeyDown += new System.Windows.Forms.KeyEventHandler(h154_KeyDown_1);
		this.h154.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h154_KeyPress_1);
		this.h154.Leave += new System.EventHandler(h154_Leave_1);
		this.h149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h149.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h149.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h149.Location = new System.Drawing.Point(1153, 975);
		this.h149.Multiline = true;
		this.h149.Name = "h149";
		this.h149.Size = new System.Drawing.Size(70, 48);
		this.h149.TabIndex = 18;
		this.h149.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h149.Click += new System.EventHandler(h149_Click_1);
		this.h149.TextChanged += new System.EventHandler(h149_TextChanged_1);
		this.h149.KeyDown += new System.Windows.Forms.KeyEventHandler(h149_KeyDown_1);
		this.h149.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h149_KeyPress_1);
		this.h149.Leave += new System.EventHandler(h149_Leave_1);
		this.label291.AutoSize = true;
		this.label291.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label291.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label291.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label291.Location = new System.Drawing.Point(1229, 1404);
		this.label291.Name = "label291";
		this.label291.Size = new System.Drawing.Size(59, 37);
		this.label291.TabIndex = 154;
		this.label291.Text = "161";
		this.label291.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h157.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h157.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h157.Location = new System.Drawing.Point(1153, 1245);
		this.h157.Multiline = true;
		this.h157.Name = "h157";
		this.h157.Size = new System.Drawing.Size(70, 48);
		this.h157.TabIndex = 23;
		this.h157.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h157.Click += new System.EventHandler(h157_Click_1);
		this.h157.TextChanged += new System.EventHandler(h157_TextChanged_1);
		this.h157.KeyDown += new System.Windows.Forms.KeyEventHandler(h157_KeyDown_1);
		this.h157.Leave += new System.EventHandler(h157_Leave_1);
		this.h156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h156.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h156.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h156.Location = new System.Drawing.Point(1153, 1191);
		this.h156.Multiline = true;
		this.h156.Name = "h156";
		this.h156.Size = new System.Drawing.Size(70, 48);
		this.h156.TabIndex = 22;
		this.h156.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h156.Click += new System.EventHandler(h156_Click_1);
		this.h156.TextChanged += new System.EventHandler(h156_TextChanged_1);
		this.h156.KeyDown += new System.Windows.Forms.KeyEventHandler(h156_KeyDown_1);
		this.h156.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h156_KeyPress_1);
		this.h156.Leave += new System.EventHandler(h156_Leave_1);
		this.h148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h148.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h148.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h148.Location = new System.Drawing.Point(1153, 921);
		this.h148.Multiline = true;
		this.h148.Name = "h148";
		this.h148.Size = new System.Drawing.Size(70, 48);
		this.h148.TabIndex = 17;
		this.h148.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h148.Click += new System.EventHandler(h148_Click_1);
		this.h148.TextChanged += new System.EventHandler(h148_TextChanged_1);
		this.h148.KeyDown += new System.Windows.Forms.KeyEventHandler(h148_KeyDown_1);
		this.h148.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h148_KeyPress_1);
		this.h148.Leave += new System.EventHandler(h148_Leave_1);
		this.h147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h147.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h147.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h147.Location = new System.Drawing.Point(1153, 867);
		this.h147.Multiline = true;
		this.h147.Name = "h147";
		this.h147.Size = new System.Drawing.Size(70, 48);
		this.h147.TabIndex = 16;
		this.h147.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h147.Click += new System.EventHandler(h147_Click_1);
		this.h147.TextChanged += new System.EventHandler(h147_TextChanged_1);
		this.h147.KeyDown += new System.Windows.Forms.KeyEventHandler(h147_KeyDown_1);
		this.h147.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h147_KeyPress_1);
		this.h147.Leave += new System.EventHandler(h147_Leave_1);
		this.h146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h146.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h146.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h146.Location = new System.Drawing.Point(1153, 813);
		this.h146.Multiline = true;
		this.h146.Name = "h146";
		this.h146.Size = new System.Drawing.Size(70, 48);
		this.h146.TabIndex = 15;
		this.h146.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h146.Click += new System.EventHandler(h146_Click_1);
		this.h146.TextChanged += new System.EventHandler(h146_TextChanged_1);
		this.h146.KeyDown += new System.Windows.Forms.KeyEventHandler(h146_KeyDown_1);
		this.h146.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h146_KeyPress);
		this.h146.Leave += new System.EventHandler(h146_Leave_1);
		this.h144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h144.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h144.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h144.Location = new System.Drawing.Point(1153, 759);
		this.h144.Multiline = true;
		this.h144.Name = "h144";
		this.h144.Size = new System.Drawing.Size(70, 48);
		this.h144.TabIndex = 14;
		this.h144.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h144.Click += new System.EventHandler(h144_Click_1);
		this.h144.TextChanged += new System.EventHandler(h144_TextChanged_1);
		this.h144.KeyDown += new System.Windows.Forms.KeyEventHandler(h144_KeyDown_1);
		this.h144.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h144_KeyPress_1);
		this.h144.Leave += new System.EventHandler(h144_Leave_1);
		this.label287.AutoSize = true;
		this.label287.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label287.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label287.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label287.Location = new System.Drawing.Point(1229, 1350);
		this.label287.Name = "label287";
		this.label287.Size = new System.Drawing.Size(59, 37);
		this.label287.TabIndex = 150;
		this.label287.Text = "160";
		this.label287.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h139.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h139.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h139.Location = new System.Drawing.Point(1153, 705);
		this.h139.Multiline = true;
		this.h139.Name = "h139";
		this.h139.Size = new System.Drawing.Size(70, 48);
		this.h139.TabIndex = 13;
		this.h139.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h139.Click += new System.EventHandler(h139_Click_1);
		this.h139.TextChanged += new System.EventHandler(h139_TextChanged_1);
		this.h139.KeyDown += new System.Windows.Forms.KeyEventHandler(h139_KeyDown_1);
		this.h139.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h139_KeyPress_1);
		this.h139.Leave += new System.EventHandler(h139_Leave_1);
		this.h133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h133.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h133.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h133.Location = new System.Drawing.Point(1153, 651);
		this.h133.Multiline = true;
		this.h133.Name = "h133";
		this.h133.Size = new System.Drawing.Size(70, 48);
		this.h133.TabIndex = 12;
		this.h133.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h133.Click += new System.EventHandler(h133_Click_1);
		this.h133.TextChanged += new System.EventHandler(h133_TextChanged_1);
		this.h133.KeyDown += new System.Windows.Forms.KeyEventHandler(h133_KeyDown_1);
		this.h133.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h133_KeyPress_1);
		this.h133.Leave += new System.EventHandler(h133_Leave_1);
		this.h131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h131.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h131.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h131.Location = new System.Drawing.Point(1153, 597);
		this.h131.Multiline = true;
		this.h131.Name = "h131";
		this.h131.Size = new System.Drawing.Size(70, 48);
		this.h131.TabIndex = 11;
		this.h131.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h131.Click += new System.EventHandler(h131_Click_1);
		this.h131.TextChanged += new System.EventHandler(h131_TextChanged_1);
		this.h131.KeyDown += new System.Windows.Forms.KeyEventHandler(h131_KeyDown_1);
		this.h131.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h131_KeyPress_1);
		this.h131.Leave += new System.EventHandler(h131_Leave_1);
		this.label267.AutoSize = true;
		this.label267.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label267.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label267.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label267.Location = new System.Drawing.Point(1229, 1080);
		this.label267.Name = "label267";
		this.label267.Size = new System.Drawing.Size(59, 37);
		this.label267.TabIndex = 130;
		this.label267.Text = "151";
		this.label267.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label263.AutoSize = true;
		this.label263.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label263.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label263.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label263.Location = new System.Drawing.Point(1229, 1026);
		this.label263.Name = "label263";
		this.label263.Size = new System.Drawing.Size(59, 37);
		this.label263.TabIndex = 126;
		this.label263.Text = "150";
		this.label263.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label283.AutoSize = true;
		this.label283.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label283.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label283.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label283.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label283.Location = new System.Drawing.Point(1229, 1296);
		this.label283.Name = "label283";
		this.label283.Size = new System.Drawing.Size(74, 54);
		this.label283.TabIndex = 146;
		this.label283.Text = "158";
		this.label283.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label259.AutoSize = true;
		this.label259.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label259.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label259.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label259.Location = new System.Drawing.Point(1229, 972);
		this.label259.Name = "label259";
		this.label259.Size = new System.Drawing.Size(59, 37);
		this.label259.TabIndex = 122;
		this.label259.Text = "149";
		this.label259.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label255.AutoSize = true;
		this.label255.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label255.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label255.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label255.Location = new System.Drawing.Point(1229, 918);
		this.label255.Name = "label255";
		this.label255.Size = new System.Drawing.Size(59, 37);
		this.label255.TabIndex = 118;
		this.label255.Text = "148";
		this.label255.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label279.AutoSize = true;
		this.label279.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label279.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label279.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label279.Location = new System.Drawing.Point(1229, 1242);
		this.label279.Name = "label279";
		this.label279.Size = new System.Drawing.Size(59, 37);
		this.label279.TabIndex = 142;
		this.label279.Text = "157";
		this.label279.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label251.AutoSize = true;
		this.label251.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label251.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label251.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label251.Location = new System.Drawing.Point(1229, 864);
		this.label251.Name = "label251";
		this.label251.Size = new System.Drawing.Size(59, 37);
		this.label251.TabIndex = 114;
		this.label251.Text = "147";
		this.label251.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label247.AutoSize = true;
		this.label247.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label247.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label247.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label247.Location = new System.Drawing.Point(1229, 810);
		this.label247.Name = "label247";
		this.label247.Size = new System.Drawing.Size(59, 37);
		this.label247.TabIndex = 110;
		this.label247.Text = "146";
		this.label247.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label69.AutoSize = true;
		this.label69.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label69.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label69.Location = new System.Drawing.Point(1229, 756);
		this.label69.Name = "label69";
		this.label69.Size = new System.Drawing.Size(59, 37);
		this.label69.TabIndex = 57;
		this.label69.Text = "144";
		this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label275.AutoSize = true;
		this.label275.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label275.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label275.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label275.Location = new System.Drawing.Point(1229, 1188);
		this.label275.Name = "label275";
		this.label275.Size = new System.Drawing.Size(59, 37);
		this.label275.TabIndex = 138;
		this.label275.Text = "156";
		this.label275.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label72.AutoSize = true;
		this.label72.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label72.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label72.Location = new System.Drawing.Point(1229, 702);
		this.label72.Name = "label72";
		this.label72.Size = new System.Drawing.Size(59, 37);
		this.label72.TabIndex = 60;
		this.label72.Text = "139";
		this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label76.AutoSize = true;
		this.label76.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label76.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label76.Location = new System.Drawing.Point(1229, 648);
		this.label76.Name = "label76";
		this.label76.Size = new System.Drawing.Size(59, 37);
		this.label76.TabIndex = 64;
		this.label76.Text = "133";
		this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label80.AutoSize = true;
		this.label80.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label80.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label80.Location = new System.Drawing.Point(1229, 594);
		this.label80.Name = "label80";
		this.label80.Size = new System.Drawing.Size(74, 54);
		this.label80.TabIndex = 68;
		this.label80.Text = "131";
		this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label271.AutoSize = true;
		this.label271.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label271.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label271.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label271.Location = new System.Drawing.Point(1229, 1134);
		this.label271.Name = "label271";
		this.label271.Size = new System.Drawing.Size(59, 37);
		this.label271.TabIndex = 134;
		this.label271.Text = "154";
		this.label271.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label399.AutoSize = true;
		this.label399.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label399.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label399.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label399.ForeColor = System.Drawing.Color.White;
		this.label399.Location = new System.Drawing.Point(895, 1404);
		this.label399.Name = "label399";
		this.label399.Size = new System.Drawing.Size(59, 37);
		this.label399.TabIndex = 153;
		this.label399.Text = "157";
		this.label399.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label395.AutoSize = true;
		this.label395.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label395.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label395.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label395.ForeColor = System.Drawing.Color.White;
		this.label395.Location = new System.Drawing.Point(895, 1350);
		this.label395.Name = "label395";
		this.label395.Size = new System.Drawing.Size(59, 37);
		this.label395.TabIndex = 149;
		this.label395.Text = "153";
		this.label395.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label391.AutoSize = true;
		this.label391.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label391.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label391.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label391.ForeColor = System.Drawing.Color.White;
		this.label391.Location = new System.Drawing.Point(895, 1296);
		this.label391.Name = "label391";
		this.label391.Size = new System.Drawing.Size(59, 37);
		this.label391.TabIndex = 145;
		this.label391.Text = "148";
		this.label391.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s161.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s161.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s161.Location = new System.Drawing.Point(819, 1461);
		this.s161.Multiline = true;
		this.s161.Name = "s161";
		this.s161.Size = new System.Drawing.Size(70, 48);
		this.s161.TabIndex = 90;
		this.s161.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s161.Click += new System.EventHandler(s161_Click);
		this.s161.TextChanged += new System.EventHandler(s161_TextChanged_1);
		this.s161.KeyDown += new System.Windows.Forms.KeyEventHandler(s161_KeyDown_1);
		this.s161.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s161_KeyPress_1);
		this.s161.Leave += new System.EventHandler(s161_Leave_1);
		this.label387.AutoSize = true;
		this.label387.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label387.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label387.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label387.ForeColor = System.Drawing.Color.White;
		this.label387.Location = new System.Drawing.Point(895, 1242);
		this.label387.Name = "label387";
		this.label387.Size = new System.Drawing.Size(59, 37);
		this.label387.TabIndex = 141;
		this.label387.Text = "147";
		this.label387.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s157.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s157.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s157.Location = new System.Drawing.Point(819, 1407);
		this.s157.Multiline = true;
		this.s157.Name = "s157";
		this.s157.Size = new System.Drawing.Size(70, 48);
		this.s157.TabIndex = 89;
		this.s157.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s157.Click += new System.EventHandler(s157_Click);
		this.s157.TextChanged += new System.EventHandler(s157_TextChanged_1);
		this.s157.KeyDown += new System.Windows.Forms.KeyEventHandler(s157_KeyDown_1);
		this.s157.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s157_KeyPress_1);
		this.s157.Leave += new System.EventHandler(s157_Leave_1);
		this.s153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s153.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s153.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s153.Location = new System.Drawing.Point(819, 1353);
		this.s153.Multiline = true;
		this.s153.Name = "s153";
		this.s153.Size = new System.Drawing.Size(70, 48);
		this.s153.TabIndex = 88;
		this.s153.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s153.Click += new System.EventHandler(s153_Click);
		this.s153.TextChanged += new System.EventHandler(s153_TextChanged_1);
		this.s153.KeyDown += new System.Windows.Forms.KeyEventHandler(s153_KeyDown_1);
		this.s153.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s153_KeyPress_1);
		this.s153.Leave += new System.EventHandler(s153_Leave_1);
		this.s148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s148.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s148.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s148.Location = new System.Drawing.Point(819, 1299);
		this.s148.Multiline = true;
		this.s148.Name = "s148";
		this.s148.Size = new System.Drawing.Size(70, 48);
		this.s148.TabIndex = 87;
		this.s148.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s148.Click += new System.EventHandler(s148_Click);
		this.s148.TextChanged += new System.EventHandler(s148_TextChanged_1);
		this.s148.KeyDown += new System.Windows.Forms.KeyEventHandler(s148_KeyDown_1);
		this.s148.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s148_KeyPress_1);
		this.s148.Leave += new System.EventHandler(s148_Leave_1);
		this.s147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s147.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s147.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s147.Location = new System.Drawing.Point(819, 1245);
		this.s147.Multiline = true;
		this.s147.Name = "s147";
		this.s147.Size = new System.Drawing.Size(70, 48);
		this.s147.TabIndex = 86;
		this.s147.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s147.Click += new System.EventHandler(s147_Click);
		this.s147.TextChanged += new System.EventHandler(s147_TextChanged_1);
		this.s147.KeyDown += new System.Windows.Forms.KeyEventHandler(s147_KeyDown_1);
		this.s147.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s147_KeyPress_1);
		this.s147.Leave += new System.EventHandler(s147_Leave_1);
		this.s145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s145.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s145.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s145.Location = new System.Drawing.Point(819, 1191);
		this.s145.Multiline = true;
		this.s145.Name = "s145";
		this.s145.Size = new System.Drawing.Size(70, 48);
		this.s145.TabIndex = 85;
		this.s145.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s145.Click += new System.EventHandler(s145_Click);
		this.s145.TextChanged += new System.EventHandler(s145_TextChanged_1);
		this.s145.KeyDown += new System.Windows.Forms.KeyEventHandler(s145_KeyDown_1);
		this.s145.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s145_KeyPress_1);
		this.s145.Leave += new System.EventHandler(s145_Leave_1);
		this.s138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s138.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s138.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s138.Location = new System.Drawing.Point(819, 1137);
		this.s138.Multiline = true;
		this.s138.Name = "s138";
		this.s138.Size = new System.Drawing.Size(70, 48);
		this.s138.TabIndex = 84;
		this.s138.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s138.Click += new System.EventHandler(s138_Click);
		this.s138.TextChanged += new System.EventHandler(s138_TextChanged_1);
		this.s138.KeyDown += new System.Windows.Forms.KeyEventHandler(s138_KeyDown_1);
		this.s138.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s138_KeyPress_1);
		this.s138.Leave += new System.EventHandler(s138_Leave_1);
		this.s137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s137.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s137.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s137.Location = new System.Drawing.Point(819, 1083);
		this.s137.Multiline = true;
		this.s137.Name = "s137";
		this.s137.Size = new System.Drawing.Size(70, 48);
		this.s137.TabIndex = 83;
		this.s137.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s137.Click += new System.EventHandler(s137_Click);
		this.s137.TextChanged += new System.EventHandler(s137_TextChanged_1);
		this.s137.KeyDown += new System.Windows.Forms.KeyEventHandler(s137_KeyDown_1);
		this.s137.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s137_KeyPress_1);
		this.s137.Leave += new System.EventHandler(s137_Leave_1);
		this.label383.AutoSize = true;
		this.label383.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label383.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label383.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label383.ForeColor = System.Drawing.Color.White;
		this.label383.Location = new System.Drawing.Point(895, 1188);
		this.label383.Name = "label383";
		this.label383.Size = new System.Drawing.Size(59, 37);
		this.label383.TabIndex = 137;
		this.label383.Text = "145";
		this.label383.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label379.AutoSize = true;
		this.label379.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label379.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label379.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label379.ForeColor = System.Drawing.Color.White;
		this.label379.Location = new System.Drawing.Point(895, 1134);
		this.label379.Name = "label379";
		this.label379.Size = new System.Drawing.Size(59, 37);
		this.label379.TabIndex = 133;
		this.label379.Text = "138";
		this.label379.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label375.AutoSize = true;
		this.label375.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label375.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label375.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label375.ForeColor = System.Drawing.Color.White;
		this.label375.Location = new System.Drawing.Point(895, 1080);
		this.label375.Name = "label375";
		this.label375.Size = new System.Drawing.Size(59, 37);
		this.label375.TabIndex = 129;
		this.label375.Text = "137";
		this.label375.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d211.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d211.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d211.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d211.Location = new System.Drawing.Point(335, 705);
		this.d211.Multiline = true;
		this.d211.Name = "d211";
		this.d211.Size = new System.Drawing.Size(70, 48);
		this.d211.TabIndex = 151;
		this.d211.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d211.Click += new System.EventHandler(d211_Click);
		this.d211.TextChanged += new System.EventHandler(d211_TextChanged_1);
		this.d211.KeyDown += new System.Windows.Forms.KeyEventHandler(d211_KeyDown_1);
		this.d211.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d211_KeyPress_1);
		this.d211.Leave += new System.EventHandler(d211_Leave_1);
		this.d200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d200.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d200.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d200.Location = new System.Drawing.Point(335, 651);
		this.d200.Multiline = true;
		this.d200.Name = "d200";
		this.d200.Size = new System.Drawing.Size(70, 48);
		this.d200.TabIndex = 150;
		this.d200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d200.Click += new System.EventHandler(d200_Click);
		this.d200.TextChanged += new System.EventHandler(d200_TextChanged_1);
		this.d200.KeyDown += new System.Windows.Forms.KeyEventHandler(d200_KeyDown_1);
		this.d200.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d200_KeyPress_1);
		this.d200.Leave += new System.EventHandler(d200_Leave_1);
		this.d197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d197.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d197.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d197.Location = new System.Drawing.Point(335, 597);
		this.d197.Multiline = true;
		this.d197.Name = "d197";
		this.d197.Size = new System.Drawing.Size(70, 48);
		this.d197.TabIndex = 149;
		this.d197.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d197.Click += new System.EventHandler(d197_Click);
		this.d197.TextChanged += new System.EventHandler(d197_TextChanged_1);
		this.d197.KeyDown += new System.Windows.Forms.KeyEventHandler(d197_KeyDown_1);
		this.d197.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d197_KeyPress_1);
		this.d197.Leave += new System.EventHandler(d197_Leave_1);
		this.d196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d196.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d196.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d196.Location = new System.Drawing.Point(335, 543);
		this.d196.Multiline = true;
		this.d196.Name = "d196";
		this.d196.Size = new System.Drawing.Size(70, 48);
		this.d196.TabIndex = 148;
		this.d196.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d196.Click += new System.EventHandler(d196_Click);
		this.d196.TextChanged += new System.EventHandler(d196_TextChanged_1);
		this.d196.KeyDown += new System.Windows.Forms.KeyEventHandler(d196_KeyDown_1);
		this.d196.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d196_KeyPress_1);
		this.d196.Leave += new System.EventHandler(d196_Leave_1);
		this.d195.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d195.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d195.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d195.Location = new System.Drawing.Point(335, 489);
		this.d195.Multiline = true;
		this.d195.Name = "d195";
		this.d195.Size = new System.Drawing.Size(70, 48);
		this.d195.TabIndex = 147;
		this.d195.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d195.Click += new System.EventHandler(d195_Click);
		this.d195.TextChanged += new System.EventHandler(d195_TextChanged_1);
		this.d195.KeyDown += new System.Windows.Forms.KeyEventHandler(d195_KeyDown_1);
		this.d195.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d195_KeyPress_1);
		this.d195.Leave += new System.EventHandler(d195_Leave_1);
		this.d190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d190.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d190.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d190.Location = new System.Drawing.Point(335, 435);
		this.d190.Multiline = true;
		this.d190.Name = "d190";
		this.d190.Size = new System.Drawing.Size(70, 48);
		this.d190.TabIndex = 146;
		this.d190.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d190.Click += new System.EventHandler(d190_Click);
		this.d190.TextChanged += new System.EventHandler(d190_TextChanged_1);
		this.d190.KeyDown += new System.Windows.Forms.KeyEventHandler(d190_KeyDown_1);
		this.d190.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d190_KeyPress_1);
		this.d190.Leave += new System.EventHandler(d190_Leave_1);
		this.label213.AutoSize = true;
		this.label213.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label213.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label213.Location = new System.Drawing.Point(411, 702);
		this.label213.Name = "label213";
		this.label213.Size = new System.Drawing.Size(59, 37);
		this.label213.TabIndex = 178;
		this.label213.Text = "211";
		this.label213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label209.AutoSize = true;
		this.label209.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label209.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label209.Location = new System.Drawing.Point(411, 648);
		this.label209.Name = "label209";
		this.label209.Size = new System.Drawing.Size(59, 37);
		this.label209.TabIndex = 174;
		this.label209.Text = "200";
		this.label209.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label205.AutoSize = true;
		this.label205.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label205.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label205.Location = new System.Drawing.Point(411, 594);
		this.label205.Name = "label205";
		this.label205.Size = new System.Drawing.Size(59, 37);
		this.label205.TabIndex = 170;
		this.label205.Text = "197";
		this.label205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label201.AutoSize = true;
		this.label201.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label201.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label201.Location = new System.Drawing.Point(411, 540);
		this.label201.Name = "label201";
		this.label201.Size = new System.Drawing.Size(59, 37);
		this.label201.TabIndex = 166;
		this.label201.Text = "196";
		this.label201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label197.AutoSize = true;
		this.label197.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label197.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label197.Location = new System.Drawing.Point(411, 486);
		this.label197.Name = "label197";
		this.label197.Size = new System.Drawing.Size(59, 37);
		this.label197.TabIndex = 162;
		this.label197.Text = "195";
		this.label197.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label193.AutoSize = true;
		this.label193.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label193.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label193.Location = new System.Drawing.Point(411, 432);
		this.label193.Name = "label193";
		this.label193.Size = new System.Drawing.Size(59, 37);
		this.label193.TabIndex = 158;
		this.label193.Text = "190";
		this.label193.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label157.AutoSize = true;
		this.label157.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label157.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label157.Location = new System.Drawing.Point(563, 1080);
		this.label157.Name = "label157";
		this.label157.Size = new System.Drawing.Size(59, 37);
		this.label157.TabIndex = 122;
		this.label157.Text = "161";
		this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label153.AutoSize = true;
		this.label153.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label153.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label153.Location = new System.Drawing.Point(563, 1026);
		this.label153.Name = "label153";
		this.label153.Size = new System.Drawing.Size(59, 37);
		this.label153.TabIndex = 118;
		this.label153.Text = "159";
		this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label12.AutoSize = true;
		this.label12.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label12.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.Location = new System.Drawing.Point(1229, 0);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(59, 37);
		this.label12.TabIndex = 0;
		this.label12.Text = "102";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h102.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h102.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h102.Location = new System.Drawing.Point(1153, 3);
		this.h102.Multiline = true;
		this.h102.Name = "h102";
		this.h102.Size = new System.Drawing.Size(70, 48);
		this.h102.TabIndex = 0;
		this.h102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h102.Click += new System.EventHandler(h102_Click_1);
		this.h102.TextChanged += new System.EventHandler(h102_TextChanged_1);
		this.h102.KeyDown += new System.Windows.Forms.KeyEventHandler(h102_KeyDown_1);
		this.h102.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h102_KeyPress_1);
		this.h102.Leave += new System.EventHandler(h102_Leave_1);
		this.hl147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl147.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl147.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl147.Location = new System.Drawing.Point(155, 219);
		this.hl147.Multiline = true;
		this.hl147.Name = "hl147";
		this.hl147.Size = new System.Drawing.Size(70, 48);
		this.hl147.TabIndex = 162;
		this.hl147.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl147.Click += new System.EventHandler(hl147_Click);
		this.hl147.TextChanged += new System.EventHandler(hl147_TextChanged_1);
		this.hl147.KeyDown += new System.Windows.Forms.KeyEventHandler(hl147_KeyDown_1);
		this.hl147.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl147_KeyPress_1);
		this.hl147.Leave += new System.EventHandler(hl147_Leave_1);
		this.hl172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl172.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl172.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl172.Location = new System.Drawing.Point(3, 219);
		this.hl172.Multiline = true;
		this.hl172.Name = "hl172";
		this.hl172.Size = new System.Drawing.Size(70, 48);
		this.hl172.TabIndex = 169;
		this.hl172.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl172.Click += new System.EventHandler(hl172_Click);
		this.hl172.TextChanged += new System.EventHandler(hl172_TextChanged_1);
		this.hl172.KeyDown += new System.Windows.Forms.KeyEventHandler(hl172_KeyDown_1);
		this.hl172.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl172_KeyPress_1);
		this.hl172.Leave += new System.EventHandler(hl172_Leave_1);
		this.hl133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl133.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl133.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl133.Location = new System.Drawing.Point(155, 165);
		this.hl133.Multiline = true;
		this.hl133.Name = "hl133";
		this.hl133.Size = new System.Drawing.Size(70, 48);
		this.hl133.TabIndex = 161;
		this.hl133.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl133.Click += new System.EventHandler(hl133_Click);
		this.hl133.TextChanged += new System.EventHandler(hl133_TextChanged_1);
		this.hl133.KeyDown += new System.Windows.Forms.KeyEventHandler(hl133_KeyDown_1);
		this.hl133.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl133_KeyPress_1);
		this.hl133.Leave += new System.EventHandler(hl133_Leave_1);
		this.label114.AutoSize = true;
		this.label114.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label114.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label114.Location = new System.Drawing.Point(79, 216);
		this.label114.Name = "label114";
		this.label114.Size = new System.Drawing.Size(59, 37);
		this.label114.TabIndex = 79;
		this.label114.Text = "172";
		this.label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label99.AutoSize = true;
		this.label99.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label99.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label99.Location = new System.Drawing.Point(231, 216);
		this.label99.Name = "label99";
		this.label99.Size = new System.Drawing.Size(59, 37);
		this.label99.TabIndex = 64;
		this.label99.Text = "147";
		this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl129.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl129.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl129.Location = new System.Drawing.Point(155, 111);
		this.hl129.Multiline = true;
		this.hl129.Name = "hl129";
		this.hl129.Size = new System.Drawing.Size(70, 48);
		this.hl129.TabIndex = 160;
		this.hl129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl129.Click += new System.EventHandler(hl129_Click);
		this.hl129.TextChanged += new System.EventHandler(hl129_TextChanged_1);
		this.hl129.KeyDown += new System.Windows.Forms.KeyEventHandler(hl129_KeyDown_1);
		this.hl129.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl129_KeyPress_1);
		this.hl129.Leave += new System.EventHandler(hl129_Leave_1);
		this.hl169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl169.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl169.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl169.Location = new System.Drawing.Point(3, 165);
		this.hl169.Multiline = true;
		this.hl169.Name = "hl169";
		this.hl169.Size = new System.Drawing.Size(70, 48);
		this.hl169.TabIndex = 168;
		this.hl169.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl169.Click += new System.EventHandler(hl169_Click);
		this.hl169.TextChanged += new System.EventHandler(hl169_TextChanged_1);
		this.hl169.KeyDown += new System.Windows.Forms.KeyEventHandler(hl169_KeyDown_1);
		this.hl169.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl169_KeyPress_1);
		this.hl169.Leave += new System.EventHandler(hl169_Leave_1);
		this.label15.AutoSize = true;
		this.label15.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label15.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label15.Location = new System.Drawing.Point(895, 0);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(59, 37);
		this.label15.TabIndex = 3;
		this.label15.Text = "101";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d161.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d161.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d161.Location = new System.Drawing.Point(487, 1083);
		this.d161.Multiline = true;
		this.d161.Name = "d161";
		this.d161.Size = new System.Drawing.Size(70, 48);
		this.d161.TabIndex = 137;
		this.d161.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d161.Click += new System.EventHandler(d161_Click);
		this.d161.TextChanged += new System.EventHandler(d161_TextChanged_1);
		this.d161.KeyDown += new System.Windows.Forms.KeyEventHandler(d161_KeyDown_1);
		this.d161.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d161_KeyPress_1);
		this.d161.Leave += new System.EventHandler(d161_Leave_1);
		this.label112.AutoSize = true;
		this.label112.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label112.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label112.Location = new System.Drawing.Point(79, 162);
		this.label112.Name = "label112";
		this.label112.Size = new System.Drawing.Size(59, 37);
		this.label112.TabIndex = 77;
		this.label112.Text = "169";
		this.label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl123.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl123.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl123.Location = new System.Drawing.Point(155, 57);
		this.hl123.Multiline = true;
		this.hl123.Name = "hl123";
		this.hl123.Size = new System.Drawing.Size(70, 48);
		this.hl123.TabIndex = 159;
		this.hl123.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl123.Click += new System.EventHandler(hl123_Click);
		this.hl123.TextChanged += new System.EventHandler(hl123_TextChanged_1);
		this.hl123.KeyDown += new System.Windows.Forms.KeyEventHandler(hl123_KeyDown_1);
		this.hl123.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl123_KeyPress_1);
		this.hl123.Leave += new System.EventHandler(hl123_Leave_1);
		this.d159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d159.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d159.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d159.Location = new System.Drawing.Point(487, 1029);
		this.d159.Multiline = true;
		this.d159.Name = "d159";
		this.d159.Size = new System.Drawing.Size(70, 48);
		this.d159.TabIndex = 136;
		this.d159.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d159.Click += new System.EventHandler(d159_Click);
		this.d159.TextChanged += new System.EventHandler(d159_TextChanged_1);
		this.d159.KeyDown += new System.Windows.Forms.KeyEventHandler(d159_KeyDown_1);
		this.d159.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d159_KeyPress_1);
		this.d159.Leave += new System.EventHandler(d159_Leave_1);
		this.label97.AutoSize = true;
		this.label97.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label97.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label97.Location = new System.Drawing.Point(231, 162);
		this.label97.Name = "label97";
		this.label97.Size = new System.Drawing.Size(59, 37);
		this.label97.TabIndex = 62;
		this.label97.Text = "133";
		this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s101.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s101.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s101.Location = new System.Drawing.Point(819, 3);
		this.s101.Multiline = true;
		this.s101.Name = "s101";
		this.s101.Size = new System.Drawing.Size(70, 48);
		this.s101.TabIndex = 63;
		this.s101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s101.Click += new System.EventHandler(s101_Click);
		this.s101.TextChanged += new System.EventHandler(s101_TextChanged_1);
		this.s101.KeyDown += new System.Windows.Forms.KeyEventHandler(s101_KeyDown_1);
		this.s101.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s101_KeyPress_1);
		this.s101.Leave += new System.EventHandler(s101_Leave_1);
		this.label109.AutoSize = true;
		this.label109.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label109.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label109.Location = new System.Drawing.Point(79, 108);
		this.label109.Name = "label109";
		this.label109.Size = new System.Drawing.Size(59, 37);
		this.label109.TabIndex = 74;
		this.label109.Text = "164";
		this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl114.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl114.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl114.Location = new System.Drawing.Point(155, 3);
		this.hl114.Multiline = true;
		this.hl114.Name = "hl114";
		this.hl114.Size = new System.Drawing.Size(70, 48);
		this.hl114.TabIndex = 158;
		this.hl114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl114.Click += new System.EventHandler(hl114_Click);
		this.hl114.TextChanged += new System.EventHandler(hl114_TextChanged_1);
		this.hl114.KeyDown += new System.Windows.Forms.KeyEventHandler(hl114_KeyDown_1);
		this.hl114.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl114_KeyPress_1);
		this.hl114.Leave += new System.EventHandler(hl114_Leave_1);
		this.label95.AutoSize = true;
		this.label95.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label95.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label95.Location = new System.Drawing.Point(231, 108);
		this.label95.Name = "label95";
		this.label95.Size = new System.Drawing.Size(59, 37);
		this.label95.TabIndex = 60;
		this.label95.Text = "129";
		this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl162.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl162.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl162.Location = new System.Drawing.Point(3, 57);
		this.hl162.Multiline = true;
		this.hl162.Name = "hl162";
		this.hl162.Size = new System.Drawing.Size(70, 48);
		this.hl162.TabIndex = 166;
		this.hl162.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl162.Click += new System.EventHandler(hl162_Click);
		this.hl162.TextChanged += new System.EventHandler(hl162_TextChanged_1);
		this.hl162.KeyDown += new System.Windows.Forms.KeyEventHandler(hl162_KeyDown_1);
		this.hl162.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl162_KeyPress_1);
		this.hl162.Leave += new System.EventHandler(hl162_Leave_1);
		this.label107.AutoSize = true;
		this.label107.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label107.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label107.Location = new System.Drawing.Point(79, 54);
		this.label107.Name = "label107";
		this.label107.Size = new System.Drawing.Size(59, 37);
		this.label107.TabIndex = 72;
		this.label107.Text = "162";
		this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label50.AutoSize = true;
		this.label50.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label50.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label50.Location = new System.Drawing.Point(563, 0);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(59, 37);
		this.label50.TabIndex = 38;
		this.label50.Text = "107";
		this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d107.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d107.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d107.Location = new System.Drawing.Point(487, 3);
		this.d107.Multiline = true;
		this.d107.Name = "d107";
		this.d107.Size = new System.Drawing.Size(70, 48);
		this.d107.TabIndex = 117;
		this.d107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d107.Click += new System.EventHandler(d107_Click);
		this.d107.TextChanged += new System.EventHandler(d107_TextChanged_1);
		this.d107.KeyDown += new System.Windows.Forms.KeyEventHandler(d107_KeyDown_1);
		this.d107.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d107_KeyPress_1);
		this.d107.Leave += new System.EventHandler(d107_Leave_1);
		this.label92.AutoSize = true;
		this.label92.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label92.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label92.Location = new System.Drawing.Point(231, 54);
		this.label92.Name = "label92";
		this.label92.Size = new System.Drawing.Size(59, 37);
		this.label92.TabIndex = 57;
		this.label92.Text = "123";
		this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl161.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl161.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl161.Location = new System.Drawing.Point(3, 3);
		this.hl161.Multiline = true;
		this.hl161.Name = "hl161";
		this.hl161.Size = new System.Drawing.Size(70, 48);
		this.hl161.TabIndex = 165;
		this.hl161.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl161.Click += new System.EventHandler(hl161_Click);
		this.hl161.TextChanged += new System.EventHandler(hl161_TextChanged_1);
		this.hl161.KeyDown += new System.Windows.Forms.KeyEventHandler(hl161_KeyDown_1);
		this.hl161.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl161_KeyPress_1);
		this.hl161.Leave += new System.EventHandler(hl161_Leave_1);
		this.label105.AutoSize = true;
		this.label105.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label105.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label105.Location = new System.Drawing.Point(79, 0);
		this.label105.Name = "label105";
		this.label105.Size = new System.Drawing.Size(59, 37);
		this.label105.TabIndex = 70;
		this.label105.Text = "161";
		this.label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d148.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d148.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d148.Location = new System.Drawing.Point(487, 813);
		this.d148.Multiline = true;
		this.d148.Name = "d148";
		this.d148.Size = new System.Drawing.Size(70, 48);
		this.d148.TabIndex = 132;
		this.d148.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d148.Click += new System.EventHandler(d148_Click);
		this.d148.TextChanged += new System.EventHandler(d148_TextChanged_1);
		this.d148.KeyDown += new System.Windows.Forms.KeyEventHandler(d148_KeyDown_1);
		this.d148.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d148_KeyPress_1);
		this.d148.Leave += new System.EventHandler(d148_Leave_1);
		this.d147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d147.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d147.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d147.Location = new System.Drawing.Point(487, 759);
		this.d147.Multiline = true;
		this.d147.Name = "d147";
		this.d147.Size = new System.Drawing.Size(70, 48);
		this.d147.TabIndex = 131;
		this.d147.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d147.Click += new System.EventHandler(d147_Click);
		this.d147.TextChanged += new System.EventHandler(d147_TextChanged_1);
		this.d147.KeyDown += new System.Windows.Forms.KeyEventHandler(d147_KeyDown_1);
		this.d147.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d147_KeyPress_1);
		this.d147.Leave += new System.EventHandler(d147_Leave_1);
		this.d143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d143.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d143.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d143.Location = new System.Drawing.Point(487, 705);
		this.d143.Multiline = true;
		this.d143.Name = "d143";
		this.d143.Size = new System.Drawing.Size(70, 48);
		this.d143.TabIndex = 130;
		this.d143.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d143.Click += new System.EventHandler(d143_Click);
		this.d143.TextChanged += new System.EventHandler(d143_TextChanged_1);
		this.d143.KeyDown += new System.Windows.Forms.KeyEventHandler(d143_KeyDown_1);
		this.d143.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d143_KeyPress_1);
		this.d143.Leave += new System.EventHandler(d143_Leave_1);
		this.d142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d142.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d142.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d142.Location = new System.Drawing.Point(487, 651);
		this.d142.Multiline = true;
		this.d142.Name = "d142";
		this.d142.Size = new System.Drawing.Size(70, 48);
		this.d142.TabIndex = 129;
		this.d142.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d142.Click += new System.EventHandler(d142_Click);
		this.d142.TextChanged += new System.EventHandler(d142_TextChanged_1);
		this.d142.KeyDown += new System.Windows.Forms.KeyEventHandler(d142_KeyDown_1);
		this.d142.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d142_KeyPress_1);
		this.d142.Leave += new System.EventHandler(d142_Leave_1);
		this.d141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d141.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d141.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d141.Location = new System.Drawing.Point(487, 597);
		this.d141.Multiline = true;
		this.d141.Name = "d141";
		this.d141.Size = new System.Drawing.Size(70, 48);
		this.d141.TabIndex = 128;
		this.d141.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d141.Click += new System.EventHandler(d141_Click);
		this.d141.TextChanged += new System.EventHandler(d141_TextChanged_1);
		this.d141.KeyDown += new System.Windows.Forms.KeyEventHandler(d141_KeyDown_1);
		this.d141.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d141_KeyPress_1);
		this.d141.Leave += new System.EventHandler(d141_Leave_1);
		this.d140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d140.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d140.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d140.Location = new System.Drawing.Point(487, 543);
		this.d140.Multiline = true;
		this.d140.Name = "d140";
		this.d140.Size = new System.Drawing.Size(70, 48);
		this.d140.TabIndex = 127;
		this.d140.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d140.Click += new System.EventHandler(d140_Click);
		this.d140.TextChanged += new System.EventHandler(d140_TextChanged_1);
		this.d140.KeyDown += new System.Windows.Forms.KeyEventHandler(d140_KeyDown_1);
		this.d140.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d140_KeyPress_1);
		this.d140.Leave += new System.EventHandler(d140_Leave_1);
		this.d134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d134.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d134.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d134.Location = new System.Drawing.Point(487, 489);
		this.d134.Multiline = true;
		this.d134.Name = "d134";
		this.d134.Size = new System.Drawing.Size(70, 48);
		this.d134.TabIndex = 126;
		this.d134.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d134.Click += new System.EventHandler(d134_Click);
		this.d134.TextChanged += new System.EventHandler(d134_TextChanged_1);
		this.d134.KeyDown += new System.Windows.Forms.KeyEventHandler(d134_KeyDown_1);
		this.d134.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d134_KeyPress_1);
		this.d134.Leave += new System.EventHandler(d134_Leave_1);
		this.d133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d133.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d133.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d133.Location = new System.Drawing.Point(487, 435);
		this.d133.Multiline = true;
		this.d133.Name = "d133";
		this.d133.Size = new System.Drawing.Size(70, 48);
		this.d133.TabIndex = 125;
		this.d133.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d133.Click += new System.EventHandler(d133_Click);
		this.d133.TextChanged += new System.EventHandler(d133_TextChanged_1);
		this.d133.KeyDown += new System.Windows.Forms.KeyEventHandler(d133_KeyDown_1);
		this.d133.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d133_KeyPress_1);
		this.d133.Leave += new System.EventHandler(d133_Leave_1);
		this.label60.AutoSize = true;
		this.label60.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label60.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label60.Location = new System.Drawing.Point(563, 432);
		this.label60.Name = "label60";
		this.label60.Size = new System.Drawing.Size(59, 37);
		this.label60.TabIndex = 48;
		this.label60.Text = "133";
		this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s136.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s136.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s136.Location = new System.Drawing.Point(819, 1029);
		this.s136.Multiline = true;
		this.s136.Name = "s136";
		this.s136.Size = new System.Drawing.Size(70, 48);
		this.s136.TabIndex = 82;
		this.s136.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s136.Click += new System.EventHandler(s136_Click);
		this.s136.TextChanged += new System.EventHandler(s136_TextChanged_1);
		this.s136.KeyDown += new System.Windows.Forms.KeyEventHandler(s136_KeyDown_1);
		this.s136.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s136_KeyPress_1);
		this.s136.Leave += new System.EventHandler(s136_Leave_1);
		this.label117.AutoSize = true;
		this.label117.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label117.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label117.Location = new System.Drawing.Point(563, 540);
		this.label117.Name = "label117";
		this.label117.Size = new System.Drawing.Size(59, 37);
		this.label117.TabIndex = 82;
		this.label117.Text = "140";
		this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label129.AutoSize = true;
		this.label129.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label129.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label129.Location = new System.Drawing.Point(563, 702);
		this.label129.Name = "label129";
		this.label129.Size = new System.Drawing.Size(59, 37);
		this.label129.TabIndex = 94;
		this.label129.Text = "143";
		this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label125.AutoSize = true;
		this.label125.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label125.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label125.Location = new System.Drawing.Point(563, 648);
		this.label125.Name = "label125";
		this.label125.Size = new System.Drawing.Size(59, 37);
		this.label125.TabIndex = 90;
		this.label125.Text = "142";
		this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label121.AutoSize = true;
		this.label121.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label121.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label121.Location = new System.Drawing.Point(563, 594);
		this.label121.Name = "label121";
		this.label121.Size = new System.Drawing.Size(59, 37);
		this.label121.TabIndex = 86;
		this.label121.Text = "141";
		this.label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label113.AutoSize = true;
		this.label113.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label113.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label113.Location = new System.Drawing.Point(563, 486);
		this.label113.Name = "label113";
		this.label113.Size = new System.Drawing.Size(59, 37);
		this.label113.TabIndex = 78;
		this.label113.Text = "134";
		this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s135.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s135.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s135.Location = new System.Drawing.Point(819, 975);
		this.s135.Multiline = true;
		this.s135.Name = "s135";
		this.s135.Size = new System.Drawing.Size(70, 48);
		this.s135.TabIndex = 81;
		this.s135.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s135.Click += new System.EventHandler(s135_Click);
		this.s135.TextChanged += new System.EventHandler(s135_TextChanged_1);
		this.s135.KeyDown += new System.Windows.Forms.KeyEventHandler(s135_KeyDown_1);
		this.s135.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s135_KeyPress_1);
		this.s135.Leave += new System.EventHandler(s135_Leave_1);
		this.label371.AutoSize = true;
		this.label371.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label371.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label371.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label371.ForeColor = System.Drawing.Color.White;
		this.label371.Location = new System.Drawing.Point(895, 1026);
		this.label371.Name = "label371";
		this.label371.Size = new System.Drawing.Size(59, 37);
		this.label371.TabIndex = 125;
		this.label371.Text = "136";
		this.label371.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label90.AutoSize = true;
		this.label90.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label90.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label90.Location = new System.Drawing.Point(231, 0);
		this.label90.Name = "label90";
		this.label90.Size = new System.Drawing.Size(59, 37);
		this.label90.TabIndex = 55;
		this.label90.Text = "114";
		this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.AutoSize = true;
		this.label19.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label19.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label19.Location = new System.Drawing.Point(1229, 54);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(59, 37);
		this.label19.TabIndex = 7;
		this.label19.Text = "103";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h103.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h103.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h103.Location = new System.Drawing.Point(1153, 57);
		this.h103.Multiline = true;
		this.h103.Name = "h103";
		this.h103.Size = new System.Drawing.Size(70, 48);
		this.h103.TabIndex = 1;
		this.h103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h103.Click += new System.EventHandler(h103_Click_1);
		this.h103.TextChanged += new System.EventHandler(h103_TextChanged_1);
		this.h103.KeyDown += new System.Windows.Forms.KeyEventHandler(h103_KeyDown_1);
		this.h103.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h103_KeyPress_1);
		this.h103.Leave += new System.EventHandler(h103_Leave_1);
		this.d126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d126.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d126.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d126.Location = new System.Drawing.Point(487, 219);
		this.d126.Multiline = true;
		this.d126.Name = "d126";
		this.d126.Size = new System.Drawing.Size(70, 48);
		this.d126.TabIndex = 121;
		this.d126.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d126.Click += new System.EventHandler(d126_Click);
		this.d126.TextChanged += new System.EventHandler(d126_TextChanged_1);
		this.d126.KeyDown += new System.Windows.Forms.KeyEventHandler(d126_KeyDown_1);
		this.d126.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d126_KeyPress_1);
		this.d126.Leave += new System.EventHandler(d126_Leave_1);
		this.label18.AutoSize = true;
		this.label18.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label18.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label18.Location = new System.Drawing.Point(895, 54);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(70, 54);
		this.label18.TabIndex = 6;
		this.label18.Text = "104";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s104.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s104.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s104.Location = new System.Drawing.Point(819, 57);
		this.s104.Multiline = true;
		this.s104.Name = "s104";
		this.s104.Size = new System.Drawing.Size(70, 48);
		this.s104.TabIndex = 64;
		this.s104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s104.Click += new System.EventHandler(s104_Click);
		this.s104.TextChanged += new System.EventHandler(s104_TextChanged_1);
		this.s104.KeyDown += new System.Windows.Forms.KeyEventHandler(s104_KeyDown_1);
		this.s104.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s104_KeyPress_1);
		this.s104.Leave += new System.EventHandler(s104_Leave_1);
		this.label52.AutoSize = true;
		this.label52.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label52.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label52.Location = new System.Drawing.Point(563, 54);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(59, 37);
		this.label52.TabIndex = 40;
		this.label52.Text = "108";
		this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d108.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d108.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d108.Location = new System.Drawing.Point(487, 57);
		this.d108.Multiline = true;
		this.d108.Name = "d108";
		this.d108.Size = new System.Drawing.Size(70, 48);
		this.d108.TabIndex = 118;
		this.d108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d108.Click += new System.EventHandler(d108_Click);
		this.d108.TextChanged += new System.EventHandler(d108_TextChanged_1);
		this.d108.KeyDown += new System.Windows.Forms.KeyEventHandler(d108_KeyDown_1);
		this.d108.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d108_KeyPress_1);
		this.d108.Leave += new System.EventHandler(d108_Leave_1);
		this.d118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d118.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d118.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d118.Location = new System.Drawing.Point(487, 165);
		this.d118.Multiline = true;
		this.d118.Name = "d118";
		this.d118.Size = new System.Drawing.Size(70, 48);
		this.d118.TabIndex = 120;
		this.d118.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d118.Click += new System.EventHandler(d118_Click);
		this.d118.TextChanged += new System.EventHandler(d118_TextChanged_1);
		this.d118.KeyDown += new System.Windows.Forms.KeyEventHandler(d118_KeyDown_1);
		this.d118.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d118_KeyPress_1);
		this.d118.Leave += new System.EventHandler(d118_Leave_1);
		this.label23.AutoSize = true;
		this.label23.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label23.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label23.Location = new System.Drawing.Point(1229, 108);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(59, 37);
		this.label23.TabIndex = 11;
		this.label23.Text = "105";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h105.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h105.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h105.Location = new System.Drawing.Point(1153, 111);
		this.h105.Multiline = true;
		this.h105.Name = "h105";
		this.h105.Size = new System.Drawing.Size(70, 48);
		this.h105.TabIndex = 2;
		this.h105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h105.Click += new System.EventHandler(h105_Click_1);
		this.h105.TextChanged += new System.EventHandler(h105_TextChanged_1);
		this.h105.KeyDown += new System.Windows.Forms.KeyEventHandler(h105_KeyDown_1);
		this.h105.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h105_KeyPress_1);
		this.h105.Leave += new System.EventHandler(h105_Leave_1);
		this.s114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s114.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s114.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s114.Location = new System.Drawing.Point(819, 219);
		this.s114.Multiline = true;
		this.s114.Name = "s114";
		this.s114.Size = new System.Drawing.Size(70, 48);
		this.s114.TabIndex = 67;
		this.s114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s114.Click += new System.EventHandler(s114_Click);
		this.s114.TextChanged += new System.EventHandler(s114_TextChanged_1);
		this.s114.KeyDown += new System.Windows.Forms.KeyEventHandler(s114_KeyDown_1);
		this.s114.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s114_KeyPress_1);
		this.s114.Leave += new System.EventHandler(s114_Leave_1);
		this.d114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d114.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d114.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d114.Location = new System.Drawing.Point(487, 111);
		this.d114.Multiline = true;
		this.d114.Name = "d114";
		this.d114.Size = new System.Drawing.Size(70, 48);
		this.d114.TabIndex = 119;
		this.d114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d114.Click += new System.EventHandler(d114_Click);
		this.d114.TextChanged += new System.EventHandler(d114_TextChanged_1);
		this.d114.KeyDown += new System.Windows.Forms.KeyEventHandler(d114_KeyDown_1);
		this.d114.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d114_KeyPress_1);
		this.d114.Leave += new System.EventHandler(d114_Leave_1);
		this.label22.AutoSize = true;
		this.label22.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label22.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label22.Location = new System.Drawing.Point(895, 108);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(59, 37);
		this.label22.TabIndex = 10;
		this.label22.Text = "110";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s110.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s110.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s110.Location = new System.Drawing.Point(819, 111);
		this.s110.Multiline = true;
		this.s110.Name = "s110";
		this.s110.Size = new System.Drawing.Size(70, 48);
		this.s110.TabIndex = 65;
		this.s110.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s110.Click += new System.EventHandler(s110_Click);
		this.s110.TextChanged += new System.EventHandler(s110_TextChanged_1);
		this.s110.KeyDown += new System.Windows.Forms.KeyEventHandler(s110_KeyDown_1);
		this.s110.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s110_KeyPress_1);
		this.s110.Leave += new System.EventHandler(s110_Leave_1);
		this.label54.AutoSize = true;
		this.label54.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label54.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label54.Location = new System.Drawing.Point(563, 108);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(59, 37);
		this.label54.TabIndex = 42;
		this.label54.Text = "114";
		this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s113.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s113.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s113.Location = new System.Drawing.Point(819, 165);
		this.s113.Multiline = true;
		this.s113.Name = "s113";
		this.s113.Size = new System.Drawing.Size(70, 48);
		this.s113.TabIndex = 66;
		this.s113.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s113.Click += new System.EventHandler(s113_Click);
		this.s113.TextChanged += new System.EventHandler(s113_TextChanged_1);
		this.s113.KeyDown += new System.Windows.Forms.KeyEventHandler(s113_KeyDown_1);
		this.s113.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s113_KeyPress_1);
		this.s113.Leave += new System.EventHandler(s113_Leave);
		this.hl164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl164.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl164.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl164.Location = new System.Drawing.Point(3, 111);
		this.hl164.Multiline = true;
		this.hl164.Name = "hl164";
		this.hl164.Size = new System.Drawing.Size(70, 48);
		this.hl164.TabIndex = 167;
		this.hl164.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl164.Click += new System.EventHandler(hl164_Click);
		this.hl164.TextChanged += new System.EventHandler(hl164_TextChanged_1);
		this.hl164.KeyDown += new System.Windows.Forms.KeyEventHandler(hl164_KeyDown_1);
		this.hl164.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl164_KeyPress_1);
		this.hl164.Leave += new System.EventHandler(hl164_Leave_1);
		this.label27.AutoSize = true;
		this.label27.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label27.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label27.Location = new System.Drawing.Point(1229, 162);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(59, 37);
		this.label27.TabIndex = 15;
		this.label27.Text = "106";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h106.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h106.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h106.Location = new System.Drawing.Point(1153, 165);
		this.h106.Multiline = true;
		this.h106.Name = "h106";
		this.h106.Size = new System.Drawing.Size(70, 48);
		this.h106.TabIndex = 3;
		this.h106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h106.Click += new System.EventHandler(h106_Click_1);
		this.h106.TextChanged += new System.EventHandler(h106_TextChanged_1);
		this.h106.KeyDown += new System.Windows.Forms.KeyEventHandler(h106_KeyDown_1);
		this.h106.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h106_KeyPress_1);
		this.h106.Leave += new System.EventHandler(h106_Leave_1);
		this.label58.AutoSize = true;
		this.label58.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label58.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label58.Location = new System.Drawing.Point(563, 216);
		this.label58.Name = "label58";
		this.label58.Size = new System.Drawing.Size(59, 37);
		this.label58.TabIndex = 46;
		this.label58.Text = "126";
		this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label26.AutoSize = true;
		this.label26.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label26.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label26.Location = new System.Drawing.Point(895, 162);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(59, 37);
		this.label26.TabIndex = 14;
		this.label26.Text = "113";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label56.AutoSize = true;
		this.label56.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label56.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label56.Location = new System.Drawing.Point(563, 162);
		this.label56.Name = "label56";
		this.label56.Size = new System.Drawing.Size(59, 37);
		this.label56.TabIndex = 44;
		this.label56.Text = "118";
		this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label31.AutoSize = true;
		this.label31.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label31.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label31.Location = new System.Drawing.Point(1229, 216);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(59, 37);
		this.label31.TabIndex = 19;
		this.label31.Text = "109";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h109.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h109.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h109.Location = new System.Drawing.Point(1153, 219);
		this.h109.Multiline = true;
		this.h109.Name = "h109";
		this.h109.Size = new System.Drawing.Size(70, 48);
		this.h109.TabIndex = 4;
		this.h109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h109.Click += new System.EventHandler(h109_Click_1);
		this.h109.TextChanged += new System.EventHandler(h109_TextChanged_1);
		this.h109.KeyDown += new System.Windows.Forms.KeyEventHandler(h109_KeyDown_1);
		this.h109.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h109_KeyPress_1);
		this.h109.Leave += new System.EventHandler(h109_Leave_1);
		this.label30.AutoSize = true;
		this.label30.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label30.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label30.Location = new System.Drawing.Point(895, 216);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(59, 37);
		this.label30.TabIndex = 18;
		this.label30.Text = "114";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label35.AutoSize = true;
		this.label35.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label35.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label35.Location = new System.Drawing.Point(1229, 270);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(59, 37);
		this.label35.TabIndex = 23;
		this.label35.Text = "111";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h111.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h111.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h111.Location = new System.Drawing.Point(1153, 273);
		this.h111.Multiline = true;
		this.h111.Name = "h111";
		this.h111.Size = new System.Drawing.Size(70, 48);
		this.h111.TabIndex = 5;
		this.h111.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h111.Click += new System.EventHandler(h111_Click_1);
		this.h111.TextChanged += new System.EventHandler(h111_TextChanged_1);
		this.h111.KeyDown += new System.Windows.Forms.KeyEventHandler(h111_KeyDown_1);
		this.h111.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h111_KeyPress_1);
		this.h111.Leave += new System.EventHandler(h111_Leave_1);
		this.h112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h112.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h112.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h112.Location = new System.Drawing.Point(1153, 327);
		this.h112.Multiline = true;
		this.h112.Name = "h112";
		this.h112.Size = new System.Drawing.Size(70, 48);
		this.h112.TabIndex = 6;
		this.h112.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h112.Click += new System.EventHandler(h112_Click_1);
		this.h112.TextChanged += new System.EventHandler(h112_TextChanged_1);
		this.h112.KeyDown += new System.Windows.Forms.KeyEventHandler(h112_KeyDown_1);
		this.h112.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h112_KeyPress_1);
		this.h112.Leave += new System.EventHandler(h112_Leave_1);
		this.h114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h114.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h114.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h114.Location = new System.Drawing.Point(1153, 381);
		this.h114.Multiline = true;
		this.h114.Name = "h114";
		this.h114.Size = new System.Drawing.Size(70, 48);
		this.h114.TabIndex = 7;
		this.h114.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h114.Click += new System.EventHandler(h114_Click_1);
		this.h114.TextChanged += new System.EventHandler(h114_TextChanged_1);
		this.h114.KeyDown += new System.Windows.Forms.KeyEventHandler(h114_KeyDown_1);
		this.h114.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h114_KeyPress_1);
		this.h114.Leave += new System.EventHandler(h114_Leave_1);
		this.label39.AutoSize = true;
		this.label39.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label39.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label39.Location = new System.Drawing.Point(1229, 324);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(59, 37);
		this.label39.TabIndex = 27;
		this.label39.Text = "112";
		this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label43.AutoSize = true;
		this.label43.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label43.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label43.Location = new System.Drawing.Point(1229, 378);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(59, 37);
		this.label43.TabIndex = 31;
		this.label43.Text = "114";
		this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label34.AutoSize = true;
		this.label34.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label34.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label34.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label34.Location = new System.Drawing.Point(895, 270);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(59, 37);
		this.label34.TabIndex = 22;
		this.label34.Text = "115";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label38.AutoSize = true;
		this.label38.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label38.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label38.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label38.Location = new System.Drawing.Point(895, 324);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(59, 37);
		this.label38.TabIndex = 26;
		this.label38.Text = "116";
		this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label42.AutoSize = true;
		this.label42.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label42.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label42.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label42.Location = new System.Drawing.Point(895, 378);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(59, 37);
		this.label42.TabIndex = 30;
		this.label42.Text = "117";
		this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label46.AutoSize = true;
		this.label46.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label46.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label46.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label46.Location = new System.Drawing.Point(895, 432);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(59, 37);
		this.label46.TabIndex = 34;
		this.label46.Text = "119";
		this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label48.AutoSize = true;
		this.label48.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label48.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label48.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label48.Location = new System.Drawing.Point(895, 486);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(59, 37);
		this.label48.TabIndex = 36;
		this.label48.Text = "121";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label73.AutoSize = true;
		this.label73.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label73.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label73.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label73.Location = new System.Drawing.Point(895, 540);
		this.label73.Name = "label73";
		this.label73.Size = new System.Drawing.Size(59, 37);
		this.label73.TabIndex = 61;
		this.label73.Text = "122";
		this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s115.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s115.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s115.Location = new System.Drawing.Point(819, 273);
		this.s115.Multiline = true;
		this.s115.Name = "s115";
		this.s115.Size = new System.Drawing.Size(70, 48);
		this.s115.TabIndex = 68;
		this.s115.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s115.Click += new System.EventHandler(s115_Click);
		this.s115.TextChanged += new System.EventHandler(s115_TextChanged_1);
		this.s115.KeyDown += new System.Windows.Forms.KeyEventHandler(s115_KeyDown_1);
		this.s115.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s115_KeyPress_1);
		this.s115.Leave += new System.EventHandler(s115_Leave_1);
		this.s116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s116.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s116.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s116.Location = new System.Drawing.Point(819, 327);
		this.s116.Multiline = true;
		this.s116.Name = "s116";
		this.s116.Size = new System.Drawing.Size(70, 48);
		this.s116.TabIndex = 69;
		this.s116.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s116.Click += new System.EventHandler(s116_Click);
		this.s116.TextChanged += new System.EventHandler(s116_TextChanged_1);
		this.s116.KeyDown += new System.Windows.Forms.KeyEventHandler(s116_KeyDown_1);
		this.s116.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s116_KeyPress_1);
		this.s116.Leave += new System.EventHandler(s116_Leave_1);
		this.s117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s117.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s117.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s117.Location = new System.Drawing.Point(819, 381);
		this.s117.Multiline = true;
		this.s117.Name = "s117";
		this.s117.Size = new System.Drawing.Size(70, 48);
		this.s117.TabIndex = 70;
		this.s117.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s117.Click += new System.EventHandler(s117_Click);
		this.s117.TextChanged += new System.EventHandler(s117_TextChanged_1);
		this.s117.KeyDown += new System.Windows.Forms.KeyEventHandler(s117_KeyDown_1);
		this.s117.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s117_KeyPress_1);
		this.s117.Leave += new System.EventHandler(s117_Leave_1);
		this.s119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s119.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s119.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s119.Location = new System.Drawing.Point(819, 435);
		this.s119.Multiline = true;
		this.s119.Name = "s119";
		this.s119.Size = new System.Drawing.Size(70, 48);
		this.s119.TabIndex = 71;
		this.s119.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s119.Click += new System.EventHandler(s119_Click);
		this.s119.TextChanged += new System.EventHandler(s119_TextChanged_1);
		this.s119.KeyDown += new System.Windows.Forms.KeyEventHandler(s119_KeyDown_1);
		this.s119.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s119_KeyPress_1);
		this.s119.Leave += new System.EventHandler(s119_Leave_1);
		this.s121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s121.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s121.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s121.Location = new System.Drawing.Point(819, 489);
		this.s121.Multiline = true;
		this.s121.Name = "s121";
		this.s121.Size = new System.Drawing.Size(70, 48);
		this.s121.TabIndex = 72;
		this.s121.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s121.Click += new System.EventHandler(s121_Click);
		this.s121.TextChanged += new System.EventHandler(s121_TextChanged_1);
		this.s121.KeyDown += new System.Windows.Forms.KeyEventHandler(s121_KeyDown_1);
		this.s121.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s121_KeyPress_1);
		this.s121.Leave += new System.EventHandler(s121_Leave_1);
		this.s122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s122.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s122.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s122.Location = new System.Drawing.Point(819, 543);
		this.s122.Multiline = true;
		this.s122.Name = "s122";
		this.s122.Size = new System.Drawing.Size(70, 48);
		this.s122.TabIndex = 73;
		this.s122.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s122.Click += new System.EventHandler(s122_Click);
		this.s122.TextChanged += new System.EventHandler(s122_TextChanged_1);
		this.s122.KeyDown += new System.Windows.Forms.KeyEventHandler(s122_KeyDown_1);
		this.s122.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s122_KeyPress_1);
		this.s122.Leave += new System.EventHandler(s122_Leave_1);
		this.label101.AutoSize = true;
		this.label101.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label101.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label101.Location = new System.Drawing.Point(231, 270);
		this.label101.Name = "label101";
		this.label101.Size = new System.Drawing.Size(59, 37);
		this.label101.TabIndex = 66;
		this.label101.Text = "148";
		this.label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label103.AutoSize = true;
		this.label103.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label103.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label103.Location = new System.Drawing.Point(231, 324);
		this.label103.Name = "label103";
		this.label103.Size = new System.Drawing.Size(59, 37);
		this.label103.TabIndex = 68;
		this.label103.Text = "157";
		this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl148.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl148.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl148.Location = new System.Drawing.Point(155, 273);
		this.hl148.Multiline = true;
		this.hl148.Name = "hl148";
		this.hl148.Size = new System.Drawing.Size(70, 48);
		this.hl148.TabIndex = 163;
		this.hl148.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl148.Click += new System.EventHandler(hl148_Click);
		this.hl148.TextChanged += new System.EventHandler(hl148_TextChanged_1);
		this.hl148.KeyDown += new System.Windows.Forms.KeyEventHandler(hl148_KeyDown_1);
		this.hl148.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl148_KeyPress_1);
		this.hl148.Leave += new System.EventHandler(hl148_Leave_1);
		this.hl157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl157.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl157.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl157.Location = new System.Drawing.Point(155, 327);
		this.hl157.Multiline = true;
		this.hl157.Name = "hl157";
		this.hl157.Size = new System.Drawing.Size(70, 48);
		this.hl157.TabIndex = 164;
		this.hl157.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl157.Click += new System.EventHandler(hl157_Click);
		this.hl157.TextChanged += new System.EventHandler(hl157_TextChanged_1);
		this.hl157.KeyDown += new System.Windows.Forms.KeyEventHandler(hl157_KeyDown_1);
		this.hl157.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl157_KeyPress_1);
		this.hl157.Leave += new System.EventHandler(hl157_Leave_1);
		this.label120.AutoSize = true;
		this.label120.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label120.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label120.Location = new System.Drawing.Point(79, 270);
		this.label120.Name = "label120";
		this.label120.Size = new System.Drawing.Size(59, 37);
		this.label120.TabIndex = 85;
		this.label120.Text = "190";
		this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label124.AutoSize = true;
		this.label124.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.label124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label124.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label124.Location = new System.Drawing.Point(79, 324);
		this.label124.Name = "label124";
		this.label124.Size = new System.Drawing.Size(59, 37);
		this.label124.TabIndex = 89;
		this.label124.Text = "198";
		this.label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.hl190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl190.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl190.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl190.Location = new System.Drawing.Point(3, 273);
		this.hl190.Multiline = true;
		this.hl190.Name = "hl190";
		this.hl190.Size = new System.Drawing.Size(70, 48);
		this.hl190.TabIndex = 170;
		this.hl190.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl190.Click += new System.EventHandler(hl190_Click);
		this.hl190.TextChanged += new System.EventHandler(hl190_TextChanged_1);
		this.hl190.KeyDown += new System.Windows.Forms.KeyEventHandler(hl190_KeyDown_1);
		this.hl190.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl190_KeyPress_1);
		this.hl190.Leave += new System.EventHandler(hl190_Leave_1);
		this.hl198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.hl198.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.hl198.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.hl198.Location = new System.Drawing.Point(3, 327);
		this.hl198.Multiline = true;
		this.hl198.Name = "hl198";
		this.hl198.Size = new System.Drawing.Size(70, 48);
		this.hl198.TabIndex = 171;
		this.hl198.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.hl198.Click += new System.EventHandler(hl198_Click);
		this.hl198.TextChanged += new System.EventHandler(hl198_TextChanged);
		this.hl198.KeyDown += new System.Windows.Forms.KeyEventHandler(hl198_KeyDown_1);
		this.hl198.KeyPress += new System.Windows.Forms.KeyPressEventHandler(hl198_KeyPress_1);
		this.hl198.Leave += new System.EventHandler(hl198_Leave_1);
		this.d127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d127.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d127.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d127.Location = new System.Drawing.Point(487, 273);
		this.d127.Multiline = true;
		this.d127.Name = "d127";
		this.d127.Size = new System.Drawing.Size(70, 48);
		this.d127.TabIndex = 122;
		this.d127.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d127.Click += new System.EventHandler(d127_Click);
		this.d127.TextChanged += new System.EventHandler(d127_TextChanged_1);
		this.d127.KeyDown += new System.Windows.Forms.KeyEventHandler(d127_KeyDown_1);
		this.d127.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d127_KeyPress_1);
		this.d127.Leave += new System.EventHandler(d127_Leave_1);
		this.d129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d129.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d129.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d129.Location = new System.Drawing.Point(487, 327);
		this.d129.Multiline = true;
		this.d129.Name = "d129";
		this.d129.Size = new System.Drawing.Size(70, 48);
		this.d129.TabIndex = 123;
		this.d129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d129.Click += new System.EventHandler(d129_Click);
		this.d129.TextChanged += new System.EventHandler(d129_TextChanged_1);
		this.d129.KeyDown += new System.Windows.Forms.KeyEventHandler(d129_KeyDown_1);
		this.d129.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d129_KeyPress_1);
		this.d129.Leave += new System.EventHandler(d129_Leave_1);
		this.d132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d132.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d132.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d132.Location = new System.Drawing.Point(487, 381);
		this.d132.Multiline = true;
		this.d132.Name = "d132";
		this.d132.Size = new System.Drawing.Size(70, 48);
		this.d132.TabIndex = 124;
		this.d132.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d132.Click += new System.EventHandler(d132_Click);
		this.d132.TextChanged += new System.EventHandler(d132_TextChanged_1);
		this.d132.KeyDown += new System.Windows.Forms.KeyEventHandler(d132_KeyDown_1);
		this.d132.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d132_KeyPress_1);
		this.d132.Leave += new System.EventHandler(d132_Leave_1);
		this.label66.AutoSize = true;
		this.label66.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label66.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label66.Location = new System.Drawing.Point(563, 270);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(59, 37);
		this.label66.TabIndex = 54;
		this.label66.Text = "127";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label65.AutoSize = true;
		this.label65.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label65.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label65.Location = new System.Drawing.Point(563, 324);
		this.label65.Name = "label65";
		this.label65.Size = new System.Drawing.Size(59, 37);
		this.label65.TabIndex = 53;
		this.label65.Text = "129";
		this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label62.AutoSize = true;
		this.label62.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label62.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label62.Location = new System.Drawing.Point(563, 378);
		this.label62.Name = "label62";
		this.label62.Size = new System.Drawing.Size(59, 37);
		this.label62.TabIndex = 50;
		this.label62.Text = "132";
		this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label47.AutoSize = true;
		this.label47.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label47.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label47.Location = new System.Drawing.Point(1229, 432);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(59, 37);
		this.label47.TabIndex = 35;
		this.label47.Text = "120";
		this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label88.AutoSize = true;
		this.label88.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label88.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label88.Location = new System.Drawing.Point(1229, 486);
		this.label88.Name = "label88";
		this.label88.Size = new System.Drawing.Size(59, 37);
		this.label88.TabIndex = 76;
		this.label88.Text = "123";
		this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label84.AutoSize = true;
		this.label84.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label84.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label84.Location = new System.Drawing.Point(1229, 540);
		this.label84.Name = "label84";
		this.label84.Size = new System.Drawing.Size(59, 37);
		this.label84.TabIndex = 72;
		this.label84.Text = "129";
		this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h120.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h120.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h120.Location = new System.Drawing.Point(1153, 435);
		this.h120.Multiline = true;
		this.h120.Name = "h120";
		this.h120.Size = new System.Drawing.Size(70, 48);
		this.h120.TabIndex = 8;
		this.h120.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h120.Click += new System.EventHandler(h120_Click_1);
		this.h120.TextChanged += new System.EventHandler(h120_TextChanged_1);
		this.h120.KeyDown += new System.Windows.Forms.KeyEventHandler(h120_KeyDown_1);
		this.h120.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h120_KeyPress_1);
		this.h120.Leave += new System.EventHandler(h120_Leave_1);
		this.h123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h123.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h123.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h123.Location = new System.Drawing.Point(1153, 489);
		this.h123.Multiline = true;
		this.h123.Name = "h123";
		this.h123.Size = new System.Drawing.Size(70, 48);
		this.h123.TabIndex = 9;
		this.h123.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h123.Click += new System.EventHandler(h123_Click_1);
		this.h123.TextChanged += new System.EventHandler(h123_TextChanged_1);
		this.h123.KeyDown += new System.Windows.Forms.KeyEventHandler(h123_KeyDown_1);
		this.h123.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h123_KeyPress_1);
		this.h123.Leave += new System.EventHandler(h123_Leave_1);
		this.h129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h129.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h129.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h129.Location = new System.Drawing.Point(1153, 543);
		this.h129.Multiline = true;
		this.h129.Name = "h129";
		this.h129.Size = new System.Drawing.Size(70, 48);
		this.h129.TabIndex = 10;
		this.h129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h129.Click += new System.EventHandler(h129_Click_1);
		this.h129.TextChanged += new System.EventHandler(h129_TextChanged_1);
		this.h129.KeyDown += new System.Windows.Forms.KeyEventHandler(h129_KeyDown_1);
		this.h129.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h129_KeyPress_1);
		this.h129.Leave += new System.EventHandler(h129_Leave_1);
		this.label77.AutoSize = true;
		this.label77.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label77.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label77.ForeColor = System.Drawing.Color.White;
		this.label77.Location = new System.Drawing.Point(895, 594);
		this.label77.Name = "label77";
		this.label77.Size = new System.Drawing.Size(59, 37);
		this.label77.TabIndex = 65;
		this.label77.Text = "123";
		this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label81.AutoSize = true;
		this.label81.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label81.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label81.ForeColor = System.Drawing.Color.White;
		this.label81.Location = new System.Drawing.Point(895, 648);
		this.label81.Name = "label81";
		this.label81.Size = new System.Drawing.Size(59, 37);
		this.label81.TabIndex = 69;
		this.label81.Text = "124";
		this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label85.AutoSize = true;
		this.label85.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label85.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label85.ForeColor = System.Drawing.Color.White;
		this.label85.Location = new System.Drawing.Point(895, 702);
		this.label85.Name = "label85";
		this.label85.Size = new System.Drawing.Size(59, 37);
		this.label85.TabIndex = 73;
		this.label85.Text = "125";
		this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label89.AutoSize = true;
		this.label89.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label89.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label89.ForeColor = System.Drawing.Color.White;
		this.label89.Location = new System.Drawing.Point(895, 756);
		this.label89.Name = "label89";
		this.label89.Size = new System.Drawing.Size(59, 37);
		this.label89.TabIndex = 77;
		this.label89.Text = "128";
		this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label355.AutoSize = true;
		this.label355.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label355.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label355.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label355.ForeColor = System.Drawing.Color.White;
		this.label355.Location = new System.Drawing.Point(895, 810);
		this.label355.Name = "label355";
		this.label355.Size = new System.Drawing.Size(59, 37);
		this.label355.TabIndex = 109;
		this.label355.Text = "129";
		this.label355.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label359.AutoSize = true;
		this.label359.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label359.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label359.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label359.ForeColor = System.Drawing.Color.White;
		this.label359.Location = new System.Drawing.Point(895, 864);
		this.label359.Name = "label359";
		this.label359.Size = new System.Drawing.Size(59, 37);
		this.label359.TabIndex = 113;
		this.label359.Text = "130";
		this.label359.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label363.AutoSize = true;
		this.label363.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label363.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label363.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label363.ForeColor = System.Drawing.Color.White;
		this.label363.Location = new System.Drawing.Point(895, 918);
		this.label363.Name = "label363";
		this.label363.Size = new System.Drawing.Size(59, 37);
		this.label363.TabIndex = 117;
		this.label363.Text = "133";
		this.label363.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s123.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s123.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s123.Location = new System.Drawing.Point(819, 597);
		this.s123.Multiline = true;
		this.s123.Name = "s123";
		this.s123.Size = new System.Drawing.Size(70, 48);
		this.s123.TabIndex = 74;
		this.s123.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s123.Click += new System.EventHandler(s123_Click);
		this.s123.TextChanged += new System.EventHandler(s123_TextChanged_1);
		this.s123.KeyDown += new System.Windows.Forms.KeyEventHandler(s123_KeyDown_1);
		this.s123.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s123_KeyPress_1);
		this.s123.Leave += new System.EventHandler(s123_Leave_1);
		this.s124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s124.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s124.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s124.Location = new System.Drawing.Point(819, 651);
		this.s124.Multiline = true;
		this.s124.Name = "s124";
		this.s124.Size = new System.Drawing.Size(70, 48);
		this.s124.TabIndex = 75;
		this.s124.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s124.Click += new System.EventHandler(s124_Click);
		this.s124.TextChanged += new System.EventHandler(s124_TextChanged_1);
		this.s124.KeyDown += new System.Windows.Forms.KeyEventHandler(s124_KeyDown_1);
		this.s124.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s124_KeyPress);
		this.s124.Leave += new System.EventHandler(s124_Leave_1);
		this.s125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s125.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s125.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s125.Location = new System.Drawing.Point(819, 705);
		this.s125.Multiline = true;
		this.s125.Name = "s125";
		this.s125.Size = new System.Drawing.Size(70, 48);
		this.s125.TabIndex = 76;
		this.s125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s125.Click += new System.EventHandler(s125_Click);
		this.s125.TextChanged += new System.EventHandler(s125_TextChanged_1);
		this.s125.KeyDown += new System.Windows.Forms.KeyEventHandler(s125_KeyDown_1);
		this.s125.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s125_KeyPress);
		this.s125.Leave += new System.EventHandler(s125_Leave_1);
		this.s128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s128.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s128.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s128.Location = new System.Drawing.Point(819, 759);
		this.s128.Multiline = true;
		this.s128.Name = "s128";
		this.s128.Size = new System.Drawing.Size(70, 48);
		this.s128.TabIndex = 77;
		this.s128.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s128.Click += new System.EventHandler(s128_Click);
		this.s128.TextChanged += new System.EventHandler(s128_TextChanged_1);
		this.s128.KeyDown += new System.Windows.Forms.KeyEventHandler(s128_KeyDown_1);
		this.s128.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s128_KeyPress_1);
		this.s128.Leave += new System.EventHandler(s128_Leave_1);
		this.s129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s129.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s129.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s129.Location = new System.Drawing.Point(819, 813);
		this.s129.Multiline = true;
		this.s129.Name = "s129";
		this.s129.Size = new System.Drawing.Size(70, 48);
		this.s129.TabIndex = 78;
		this.s129.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s129.Click += new System.EventHandler(s129_Click);
		this.s129.TextChanged += new System.EventHandler(s129_TextChanged_1);
		this.s129.KeyDown += new System.Windows.Forms.KeyEventHandler(s129_KeyDown_1);
		this.s129.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s129_KeyPress_1);
		this.s129.Leave += new System.EventHandler(s129_Leave_1);
		this.s130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s130.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s130.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s130.Location = new System.Drawing.Point(819, 867);
		this.s130.Multiline = true;
		this.s130.Name = "s130";
		this.s130.Size = new System.Drawing.Size(70, 48);
		this.s130.TabIndex = 79;
		this.s130.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s130.Click += new System.EventHandler(s130_Click);
		this.s130.TextChanged += new System.EventHandler(s130_TextChanged_1);
		this.s130.KeyDown += new System.Windows.Forms.KeyEventHandler(s130_KeyDown_1);
		this.s130.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s130_KeyPress_1);
		this.s130.Leave += new System.EventHandler(s130_Leave_1);
		this.s133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s133.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s133.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s133.Location = new System.Drawing.Point(819, 921);
		this.s133.Multiline = true;
		this.s133.Name = "s133";
		this.s133.Size = new System.Drawing.Size(70, 48);
		this.s133.TabIndex = 80;
		this.s133.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s133.Click += new System.EventHandler(s133_Click);
		this.s133.TextChanged += new System.EventHandler(s133_TextChanged_1);
		this.s133.KeyDown += new System.Windows.Forms.KeyEventHandler(s133_KeyDown_1);
		this.s133.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s133_KeyPress_1);
		this.s133.Leave += new System.EventHandler(s133_Leave_1);
		this.label367.AutoSize = true;
		this.label367.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label367.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label367.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label367.ForeColor = System.Drawing.Color.White;
		this.label367.Location = new System.Drawing.Point(895, 972);
		this.label367.Name = "label367";
		this.label367.Size = new System.Drawing.Size(59, 37);
		this.label367.TabIndex = 121;
		this.label367.Text = "135";
		this.label367.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label133.AutoSize = true;
		this.label133.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label133.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label133.Location = new System.Drawing.Point(563, 756);
		this.label133.Name = "label133";
		this.label133.Size = new System.Drawing.Size(59, 37);
		this.label133.TabIndex = 98;
		this.label133.Text = "147";
		this.label133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label137.AutoSize = true;
		this.label137.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label137.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label137.Location = new System.Drawing.Point(563, 810);
		this.label137.Name = "label137";
		this.label137.Size = new System.Drawing.Size(59, 37);
		this.label137.TabIndex = 102;
		this.label137.Text = "148";
		this.label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label141.AutoSize = true;
		this.label141.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label141.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label141.Location = new System.Drawing.Point(563, 864);
		this.label141.Name = "label141";
		this.label141.Size = new System.Drawing.Size(59, 37);
		this.label141.TabIndex = 106;
		this.label141.Text = "152";
		this.label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label145.AutoSize = true;
		this.label145.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label145.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label145.Location = new System.Drawing.Point(563, 918);
		this.label145.Name = "label145";
		this.label145.Size = new System.Drawing.Size(59, 37);
		this.label145.TabIndex = 110;
		this.label145.Text = "155";
		this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label149.AutoSize = true;
		this.label149.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label149.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label149.Location = new System.Drawing.Point(563, 972);
		this.label149.Name = "label149";
		this.label149.Size = new System.Drawing.Size(59, 37);
		this.label149.TabIndex = 114;
		this.label149.Text = "157";
		this.label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d152.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d152.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d152.Location = new System.Drawing.Point(487, 867);
		this.d152.Multiline = true;
		this.d152.Name = "d152";
		this.d152.Size = new System.Drawing.Size(70, 48);
		this.d152.TabIndex = 133;
		this.d152.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d152.Click += new System.EventHandler(d152_Click);
		this.d152.TextChanged += new System.EventHandler(d152_TextChanged_1);
		this.d152.KeyDown += new System.Windows.Forms.KeyEventHandler(d152_KeyDown_1);
		this.d152.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d152_KeyPress_1);
		this.d152.Leave += new System.EventHandler(d152_Leave_1);
		this.d155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d155.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d155.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d155.Location = new System.Drawing.Point(487, 921);
		this.d155.Multiline = true;
		this.d155.Name = "d155";
		this.d155.Size = new System.Drawing.Size(70, 48);
		this.d155.TabIndex = 134;
		this.d155.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d155.Click += new System.EventHandler(d155_Click);
		this.d155.TextChanged += new System.EventHandler(d155_TextChanged_1);
		this.d155.KeyDown += new System.Windows.Forms.KeyEventHandler(d155_KeyDown_1);
		this.d155.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d155_KeyPress_1);
		this.d155.Leave += new System.EventHandler(d155_Leave_1);
		this.d157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d157.Dock = System.Windows.Forms.DockStyle.Fill;
		this.d157.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d157.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d157.Location = new System.Drawing.Point(487, 975);
		this.d157.Multiline = true;
		this.d157.Name = "d157";
		this.d157.Size = new System.Drawing.Size(70, 48);
		this.d157.TabIndex = 135;
		this.d157.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d157.Click += new System.EventHandler(d157_Click);
		this.d157.TextChanged += new System.EventHandler(d157_TextChanged_1);
		this.d157.KeyDown += new System.Windows.Forms.KeyEventHandler(d157_KeyDown_1);
		this.d157.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d157_KeyPress_1);
		this.d157.Leave += new System.EventHandler(d157_Leave_1);
		this.label161.AutoSize = true;
		this.label161.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label161.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label161.Location = new System.Drawing.Point(411, 0);
		this.label161.Name = "label161";
		this.label161.Size = new System.Drawing.Size(59, 37);
		this.label161.TabIndex = 126;
		this.label161.Text = "162";
		this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d162.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d162.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d162.Location = new System.Drawing.Point(335, 3);
		this.d162.Multiline = true;
		this.d162.Name = "d162";
		this.d162.Size = new System.Drawing.Size(70, 48);
		this.d162.TabIndex = 138;
		this.d162.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d162.Click += new System.EventHandler(d162_Click);
		this.d162.TextChanged += new System.EventHandler(d162_TextChanged_1);
		this.d162.KeyDown += new System.Windows.Forms.KeyEventHandler(d162_KeyDown_1);
		this.d162.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d162_KeyPress_1);
		this.d162.Leave += new System.EventHandler(d162_Leave_1);
		this.label165.AutoSize = true;
		this.label165.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label165.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label165.Location = new System.Drawing.Point(411, 54);
		this.label165.Name = "label165";
		this.label165.Size = new System.Drawing.Size(59, 37);
		this.label165.TabIndex = 130;
		this.label165.Text = "163";
		this.label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d163.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d163.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d163.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d163.Location = new System.Drawing.Point(335, 57);
		this.d163.Multiline = true;
		this.d163.Name = "d163";
		this.d163.Size = new System.Drawing.Size(70, 48);
		this.d163.TabIndex = 139;
		this.d163.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d163.Click += new System.EventHandler(d163_Click);
		this.d163.TextChanged += new System.EventHandler(d163_TextChanged_1);
		this.d163.KeyDown += new System.Windows.Forms.KeyEventHandler(d163_KeyDown_1);
		this.d163.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d163_KeyPress_1);
		this.d163.Leave += new System.EventHandler(d163_Leave_1);
		this.label169.AutoSize = true;
		this.label169.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label169.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label169.Location = new System.Drawing.Point(411, 108);
		this.label169.Name = "label169";
		this.label169.Size = new System.Drawing.Size(59, 37);
		this.label169.TabIndex = 134;
		this.label169.Text = "164";
		this.label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d164.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d164.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d164.Location = new System.Drawing.Point(335, 111);
		this.d164.Multiline = true;
		this.d164.Name = "d164";
		this.d164.Size = new System.Drawing.Size(70, 48);
		this.d164.TabIndex = 140;
		this.d164.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d164.Click += new System.EventHandler(d164_Click);
		this.d164.TextChanged += new System.EventHandler(d164_TextChanged_1);
		this.d164.KeyDown += new System.Windows.Forms.KeyEventHandler(d164_KeyDown_1);
		this.d164.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d164_KeyPress_1);
		this.d164.Leave += new System.EventHandler(d164_Leave_1);
		this.label173.AutoSize = true;
		this.label173.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label173.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label173.Location = new System.Drawing.Point(411, 162);
		this.label173.Name = "label173";
		this.label173.Size = new System.Drawing.Size(59, 37);
		this.label173.TabIndex = 138;
		this.label173.Text = "169";
		this.label173.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d169.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d169.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d169.Location = new System.Drawing.Point(335, 165);
		this.d169.Multiline = true;
		this.d169.Name = "d169";
		this.d169.Size = new System.Drawing.Size(70, 48);
		this.d169.TabIndex = 141;
		this.d169.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d169.Click += new System.EventHandler(d169_Click);
		this.d169.TextChanged += new System.EventHandler(d169_TextChanged_1);
		this.d169.KeyDown += new System.Windows.Forms.KeyEventHandler(d169_KeyDown_1);
		this.d169.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d169_KeyPress_1);
		this.d169.Leave += new System.EventHandler(d169_Leave_1);
		this.label177.AutoSize = true;
		this.label177.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label177.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label177.Location = new System.Drawing.Point(411, 216);
		this.label177.Name = "label177";
		this.label177.Size = new System.Drawing.Size(59, 37);
		this.label177.TabIndex = 142;
		this.label177.Text = "175";
		this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d175.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d175.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d175.Location = new System.Drawing.Point(335, 219);
		this.d175.Multiline = true;
		this.d175.Name = "d175";
		this.d175.Size = new System.Drawing.Size(70, 48);
		this.d175.TabIndex = 142;
		this.d175.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d175.Click += new System.EventHandler(d175_Click);
		this.d175.TextChanged += new System.EventHandler(d175_TextChanged_1);
		this.d175.KeyDown += new System.Windows.Forms.KeyEventHandler(d175_KeyDown_1);
		this.d175.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d175_KeyPress_1);
		this.d175.Leave += new System.EventHandler(d175_Leave_1);
		this.label181.AutoSize = true;
		this.label181.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label181.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label181.Location = new System.Drawing.Point(411, 270);
		this.label181.Name = "label181";
		this.label181.Size = new System.Drawing.Size(59, 37);
		this.label181.TabIndex = 146;
		this.label181.Text = "177";
		this.label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d177.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d177.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d177.Location = new System.Drawing.Point(335, 273);
		this.d177.Multiline = true;
		this.d177.Name = "d177";
		this.d177.Size = new System.Drawing.Size(70, 48);
		this.d177.TabIndex = 143;
		this.d177.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d177.Click += new System.EventHandler(d177_Click);
		this.d177.TextChanged += new System.EventHandler(d177_TextChanged_1);
		this.d177.KeyDown += new System.Windows.Forms.KeyEventHandler(d177_KeyDown_1);
		this.d177.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d177_KeyPress_1);
		this.d177.Leave += new System.EventHandler(d177_Leave_1);
		this.label185.AutoSize = true;
		this.label185.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label185.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label185.Location = new System.Drawing.Point(411, 324);
		this.label185.Name = "label185";
		this.label185.Size = new System.Drawing.Size(59, 37);
		this.label185.TabIndex = 150;
		this.label185.Text = "186";
		this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d186.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d186.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d186.Location = new System.Drawing.Point(335, 327);
		this.d186.Multiline = true;
		this.d186.Name = "d186";
		this.d186.Size = new System.Drawing.Size(70, 48);
		this.d186.TabIndex = 144;
		this.d186.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d186.Click += new System.EventHandler(d186_Click);
		this.d186.TextChanged += new System.EventHandler(d186_TextChanged_1);
		this.d186.KeyDown += new System.Windows.Forms.KeyEventHandler(d186_KeyDown_1);
		this.d186.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d186_KeyPress_1);
		this.d186.Leave += new System.EventHandler(d186_Leave_1);
		this.label189.AutoSize = true;
		this.label189.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label189.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label189.Location = new System.Drawing.Point(411, 378);
		this.label189.Name = "label189";
		this.label189.Size = new System.Drawing.Size(59, 37);
		this.label189.TabIndex = 154;
		this.label189.Text = "188";
		this.label189.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d188.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d188.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d188.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d188.Location = new System.Drawing.Point(335, 381);
		this.d188.Multiline = true;
		this.d188.Name = "d188";
		this.d188.Size = new System.Drawing.Size(70, 48);
		this.d188.TabIndex = 145;
		this.d188.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d188.Click += new System.EventHandler(d188_Click);
		this.d188.TextChanged += new System.EventHandler(d188_TextChanged_1);
		this.d188.KeyDown += new System.Windows.Forms.KeyEventHandler(d188_KeyDown_1);
		this.d188.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d188_KeyPress_1);
		this.d188.Leave += new System.EventHandler(d188_Leave_1);
		this.label91.AutoSize = true;
		this.label91.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label91.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label91.Location = new System.Drawing.Point(411, 756);
		this.label91.Name = "label91";
		this.label91.Size = new System.Drawing.Size(59, 37);
		this.label91.TabIndex = 56;
		this.label91.Text = "213";
		this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d213.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d213.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d213.Location = new System.Drawing.Point(335, 759);
		this.d213.Multiline = true;
		this.d213.Name = "d213";
		this.d213.Size = new System.Drawing.Size(70, 48);
		this.d213.TabIndex = 152;
		this.d213.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d213.Click += new System.EventHandler(d213_Click);
		this.d213.TextChanged += new System.EventHandler(d213_TextChanged_1);
		this.d213.KeyDown += new System.Windows.Forms.KeyEventHandler(d213_KeyDown_1);
		this.d213.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d213_KeyPress_1);
		this.d213.Leave += new System.EventHandler(d213_Leave_1);
		this.label94.AutoSize = true;
		this.label94.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label94.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label94.Location = new System.Drawing.Point(411, 810);
		this.label94.Name = "label94";
		this.label94.Size = new System.Drawing.Size(59, 37);
		this.label94.TabIndex = 59;
		this.label94.Text = "222";
		this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label53.AutoSize = true;
		this.label53.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label53.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label53.Location = new System.Drawing.Point(411, 864);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(59, 37);
		this.label53.TabIndex = 41;
		this.label53.Text = "224";
		this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label55.AutoSize = true;
		this.label55.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label55.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label55.Location = new System.Drawing.Point(411, 918);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(59, 37);
		this.label55.TabIndex = 43;
		this.label55.Text = "225";
		this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label57.AutoSize = true;
		this.label57.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label57.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label57.Location = new System.Drawing.Point(411, 972);
		this.label57.Name = "label57";
		this.label57.Size = new System.Drawing.Size(59, 37);
		this.label57.TabIndex = 45;
		this.label57.Text = "227";
		this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label64.AutoSize = true;
		this.label64.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label64.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label64.Location = new System.Drawing.Point(411, 1026);
		this.label64.Name = "label64";
		this.label64.Size = new System.Drawing.Size(59, 37);
		this.label64.TabIndex = 52;
		this.label64.Text = "232";
		this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.d222.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d222.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d222.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d222.Location = new System.Drawing.Point(335, 813);
		this.d222.Multiline = true;
		this.d222.Name = "d222";
		this.d222.Size = new System.Drawing.Size(70, 48);
		this.d222.TabIndex = 153;
		this.d222.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d222.Click += new System.EventHandler(d222_Click);
		this.d222.TextChanged += new System.EventHandler(d222_TextChanged_1);
		this.d222.KeyDown += new System.Windows.Forms.KeyEventHandler(d222_KeyDown_1);
		this.d222.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d222_KeyPress_1);
		this.d222.Leave += new System.EventHandler(d222_Leave_1);
		this.d224.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d224.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d224.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d224.Location = new System.Drawing.Point(335, 867);
		this.d224.Multiline = true;
		this.d224.Name = "d224";
		this.d224.Size = new System.Drawing.Size(70, 48);
		this.d224.TabIndex = 154;
		this.d224.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d224.Click += new System.EventHandler(d224_Click);
		this.d224.TextChanged += new System.EventHandler(d224_TextChanged_1);
		this.d224.KeyDown += new System.Windows.Forms.KeyEventHandler(d224_KeyDown_1);
		this.d224.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d224_KeyPress_1);
		this.d224.Leave += new System.EventHandler(d224_Leave_1);
		this.d225.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d225.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d225.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d225.Location = new System.Drawing.Point(335, 921);
		this.d225.Multiline = true;
		this.d225.Name = "d225";
		this.d225.Size = new System.Drawing.Size(70, 48);
		this.d225.TabIndex = 155;
		this.d225.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d225.Click += new System.EventHandler(d225_Click);
		this.d225.TextChanged += new System.EventHandler(d225_TextChanged_1);
		this.d225.KeyDown += new System.Windows.Forms.KeyEventHandler(d225_KeyDown_1);
		this.d225.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d225_KeyPress_1);
		this.d225.Leave += new System.EventHandler(d225_Leave_1);
		this.d227.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d227.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d227.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d227.Location = new System.Drawing.Point(335, 975);
		this.d227.Multiline = true;
		this.d227.Name = "d227";
		this.d227.Size = new System.Drawing.Size(70, 48);
		this.d227.TabIndex = 156;
		this.d227.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d227.Click += new System.EventHandler(d227_Click);
		this.d227.TextChanged += new System.EventHandler(d227_TextChanged_1);
		this.d227.KeyDown += new System.Windows.Forms.KeyEventHandler(d227_KeyDown_1);
		this.d227.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d227_KeyPress_1);
		this.d227.Leave += new System.EventHandler(d227_Leave_1);
		this.d232.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.d232.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.d232.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.d232.Location = new System.Drawing.Point(335, 1029);
		this.d232.Multiline = true;
		this.d232.Name = "d232";
		this.d232.Size = new System.Drawing.Size(70, 48);
		this.d232.TabIndex = 157;
		this.d232.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.d232.Click += new System.EventHandler(d232_Click);
		this.d232.TextChanged += new System.EventHandler(d232_TextChanged_1);
		this.d232.KeyDown += new System.Windows.Forms.KeyEventHandler(d232_KeyDown_1);
		this.d232.Leave += new System.EventHandler(d232_Leave_1);
		this.label403.AutoSize = true;
		this.label403.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label403.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label403.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label403.ForeColor = System.Drawing.Color.White;
		this.label403.Location = new System.Drawing.Point(895, 1458);
		this.label403.Name = "label403";
		this.label403.Size = new System.Drawing.Size(59, 37);
		this.label403.TabIndex = 157;
		this.label403.Text = "161";
		this.label403.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label14.AutoSize = true;
		this.label14.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label14.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(1077, 162);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(59, 37);
		this.label14.TabIndex = 2;
		this.label14.Text = "179";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label17.AutoSize = true;
		this.label17.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label17.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label17.Location = new System.Drawing.Point(1077, 216);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(59, 37);
		this.label17.TabIndex = 5;
		this.label17.Text = "181";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label21.AutoSize = true;
		this.label21.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label21.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label21.Location = new System.Drawing.Point(1077, 270);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(59, 37);
		this.label21.TabIndex = 9;
		this.label21.Text = "184";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.AutoSize = true;
		this.label25.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label25.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label25.Location = new System.Drawing.Point(1077, 324);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(59, 37);
		this.label25.TabIndex = 13;
		this.label25.Text = "187";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label29.AutoSize = true;
		this.label29.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label29.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label29.Location = new System.Drawing.Point(1077, 378);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(59, 37);
		this.label29.TabIndex = 17;
		this.label29.Text = "189";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label33.AutoSize = true;
		this.label33.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label33.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label33.Location = new System.Drawing.Point(1077, 432);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(59, 37);
		this.label33.TabIndex = 21;
		this.label33.Text = "190";
		this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h179.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h179.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h179.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h179.Location = new System.Drawing.Point(1001, 165);
		this.h179.Multiline = true;
		this.h179.Name = "h179";
		this.h179.Size = new System.Drawing.Size(70, 48);
		this.h179.TabIndex = 34;
		this.h179.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h179.Click += new System.EventHandler(h179_Click);
		this.h179.TextChanged += new System.EventHandler(h179_TextChanged_1);
		this.h179.KeyDown += new System.Windows.Forms.KeyEventHandler(h179_KeyDown_1);
		this.h179.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h179_KeyPress_1);
		this.h179.Leave += new System.EventHandler(h179_Leave_1);
		this.h181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h181.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h181.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h181.Location = new System.Drawing.Point(1001, 219);
		this.h181.Multiline = true;
		this.h181.Name = "h181";
		this.h181.Size = new System.Drawing.Size(70, 48);
		this.h181.TabIndex = 35;
		this.h181.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h181.Click += new System.EventHandler(h181_Click);
		this.h181.TextChanged += new System.EventHandler(h181_TextChanged_1);
		this.h181.KeyDown += new System.Windows.Forms.KeyEventHandler(h181_KeyDown_1);
		this.h181.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h181_KeyPress_1);
		this.h181.Leave += new System.EventHandler(h181_Leave_1);
		this.h184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h184.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h184.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h184.Location = new System.Drawing.Point(1001, 273);
		this.h184.Multiline = true;
		this.h184.Name = "h184";
		this.h184.Size = new System.Drawing.Size(70, 48);
		this.h184.TabIndex = 36;
		this.h184.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h184.Click += new System.EventHandler(h184_Click_1);
		this.h184.TextChanged += new System.EventHandler(h184_TextChanged_1);
		this.h184.KeyDown += new System.Windows.Forms.KeyEventHandler(h184_KeyDown_1);
		this.h184.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h184_KeyPress_1);
		this.h184.Layout += new System.Windows.Forms.LayoutEventHandler(h184_Layout);
		this.h184.Leave += new System.EventHandler(h184_Leave_1);
		this.h187.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h187.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h187.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h187.Location = new System.Drawing.Point(1001, 327);
		this.h187.Multiline = true;
		this.h187.Name = "h187";
		this.h187.Size = new System.Drawing.Size(70, 48);
		this.h187.TabIndex = 37;
		this.h187.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h187.Click += new System.EventHandler(h187_Click_1);
		this.h187.TextChanged += new System.EventHandler(h187_TextChanged_1);
		this.h187.KeyDown += new System.Windows.Forms.KeyEventHandler(h187_KeyDown_1);
		this.h187.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h187_KeyPress_1);
		this.h187.Leave += new System.EventHandler(h187_Leave_1);
		this.h189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h189.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h189.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h189.Location = new System.Drawing.Point(1001, 381);
		this.h189.Multiline = true;
		this.h189.Name = "h189";
		this.h189.Size = new System.Drawing.Size(70, 48);
		this.h189.TabIndex = 38;
		this.h189.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h189.Click += new System.EventHandler(h189_Click_1);
		this.h189.TextChanged += new System.EventHandler(h189_TextChanged_1);
		this.h189.KeyDown += new System.Windows.Forms.KeyEventHandler(h189_KeyDown_1);
		this.h189.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h189_KeyPress_1);
		this.h189.Leave += new System.EventHandler(h189_Leave_1);
		this.h190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h190.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h190.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h190.Location = new System.Drawing.Point(1001, 435);
		this.h190.Multiline = true;
		this.h190.Name = "h190";
		this.h190.Size = new System.Drawing.Size(70, 48);
		this.h190.TabIndex = 39;
		this.h190.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h190.Click += new System.EventHandler(h190_Click_1);
		this.h190.TextChanged += new System.EventHandler(h190_TextChanged_1);
		this.h190.KeyDown += new System.Windows.Forms.KeyEventHandler(h190_KeyDown_1);
		this.h190.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h190_KeyPress_1);
		this.h190.Leave += new System.EventHandler(h190_Leave_1);
		this.label37.AutoSize = true;
		this.label37.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label37.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label37.Location = new System.Drawing.Point(1077, 486);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(59, 37);
		this.label37.TabIndex = 25;
		this.label37.Text = "191";
		this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label41.AutoSize = true;
		this.label41.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label41.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label41.Location = new System.Drawing.Point(1077, 540);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(59, 37);
		this.label41.TabIndex = 29;
		this.label41.Text = "198";
		this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label45.AutoSize = true;
		this.label45.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label45.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label45.Location = new System.Drawing.Point(1077, 594);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(59, 37);
		this.label45.TabIndex = 33;
		this.label45.Text = "199";
		this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label86.AutoSize = true;
		this.label86.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label86.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label86.Location = new System.Drawing.Point(1077, 648);
		this.label86.Name = "label86";
		this.label86.Size = new System.Drawing.Size(59, 37);
		this.label86.TabIndex = 74;
		this.label86.Text = "202";
		this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label82.AutoSize = true;
		this.label82.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label82.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label82.Location = new System.Drawing.Point(1077, 702);
		this.label82.Name = "label82";
		this.label82.Size = new System.Drawing.Size(59, 37);
		this.label82.TabIndex = 70;
		this.label82.Text = "203";
		this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label78.AutoSize = true;
		this.label78.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label78.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label78.Location = new System.Drawing.Point(1077, 756);
		this.label78.Name = "label78";
		this.label78.Size = new System.Drawing.Size(59, 37);
		this.label78.TabIndex = 66;
		this.label78.Text = "204";
		this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label74.AutoSize = true;
		this.label74.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label74.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label74.Location = new System.Drawing.Point(1077, 810);
		this.label74.Name = "label74";
		this.label74.Size = new System.Drawing.Size(59, 37);
		this.label74.TabIndex = 62;
		this.label74.Text = "205";
		this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h191.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h191.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h191.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h191.Location = new System.Drawing.Point(1001, 489);
		this.h191.Multiline = true;
		this.h191.Name = "h191";
		this.h191.Size = new System.Drawing.Size(70, 48);
		this.h191.TabIndex = 40;
		this.h191.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h191.Click += new System.EventHandler(h191_Click_1);
		this.h191.TextChanged += new System.EventHandler(h191_TextChanged_1);
		this.h191.KeyDown += new System.Windows.Forms.KeyEventHandler(h191_KeyDown_1);
		this.h191.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h191_KeyPress_1);
		this.h191.Leave += new System.EventHandler(h191_Leave_1);
		this.h198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h198.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h198.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h198.Location = new System.Drawing.Point(1001, 543);
		this.h198.Multiline = true;
		this.h198.Name = "h198";
		this.h198.Size = new System.Drawing.Size(70, 48);
		this.h198.TabIndex = 41;
		this.h198.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h198.Click += new System.EventHandler(h198_Click_1);
		this.h198.TextChanged += new System.EventHandler(h198_TextChanged_1);
		this.h198.KeyDown += new System.Windows.Forms.KeyEventHandler(h198_KeyDown_1);
		this.h198.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h198_KeyPress_1);
		this.h198.Leave += new System.EventHandler(h198_Leave_1);
		this.h199.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h199.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h199.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h199.Location = new System.Drawing.Point(1001, 597);
		this.h199.Multiline = true;
		this.h199.Name = "h199";
		this.h199.Size = new System.Drawing.Size(70, 48);
		this.h199.TabIndex = 42;
		this.h199.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h199.Click += new System.EventHandler(h199_Click_1);
		this.h199.TextChanged += new System.EventHandler(h199_TextChanged_1);
		this.h199.KeyDown += new System.Windows.Forms.KeyEventHandler(h199_KeyDown_1);
		this.h199.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h199_KeyPress_1);
		this.h199.Leave += new System.EventHandler(h199_Leave_1);
		this.h202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h202.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h202.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h202.Location = new System.Drawing.Point(1001, 651);
		this.h202.Multiline = true;
		this.h202.Name = "h202";
		this.h202.Size = new System.Drawing.Size(70, 48);
		this.h202.TabIndex = 43;
		this.h202.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h202.Click += new System.EventHandler(h202_Click_1);
		this.h202.TextChanged += new System.EventHandler(h202_TextChanged_1);
		this.h202.KeyDown += new System.Windows.Forms.KeyEventHandler(h202_KeyDown_1);
		this.h202.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h202_KeyPress_1);
		this.h202.Leave += new System.EventHandler(h202_Leave_1);
		this.h203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h203.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h203.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h203.Location = new System.Drawing.Point(1001, 705);
		this.h203.Multiline = true;
		this.h203.Name = "h203";
		this.h203.Size = new System.Drawing.Size(70, 48);
		this.h203.TabIndex = 44;
		this.h203.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h203.Click += new System.EventHandler(h203_Click_1);
		this.h203.TextChanged += new System.EventHandler(h203_TextChanged_1);
		this.h203.KeyDown += new System.Windows.Forms.KeyEventHandler(h203_KeyDown_1);
		this.h203.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h203_KeyPress_1);
		this.h203.Leave += new System.EventHandler(h203_Leave_1);
		this.h204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h204.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h204.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h204.Location = new System.Drawing.Point(1001, 759);
		this.h204.Multiline = true;
		this.h204.Name = "h204";
		this.h204.Size = new System.Drawing.Size(70, 48);
		this.h204.TabIndex = 45;
		this.h204.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h204.Click += new System.EventHandler(h204_Click_1);
		this.h204.TextChanged += new System.EventHandler(h204_TextChanged_1);
		this.h204.KeyDown += new System.Windows.Forms.KeyEventHandler(h204_KeyDown_1);
		this.h204.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h204_KeyPress_1);
		this.h204.Leave += new System.EventHandler(h204_Leave_1);
		this.h205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h205.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h205.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h205.Location = new System.Drawing.Point(1001, 813);
		this.h205.Multiline = true;
		this.h205.Name = "h205";
		this.h205.Size = new System.Drawing.Size(70, 48);
		this.h205.TabIndex = 46;
		this.h205.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h205.Click += new System.EventHandler(h205_Click_1);
		this.h205.TextChanged += new System.EventHandler(h205_TextChanged_1);
		this.h205.KeyDown += new System.Windows.Forms.KeyEventHandler(h205_KeyDown_1);
		this.h205.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h205_KeyPress_1);
		this.h205.Leave += new System.EventHandler(h205_Leave_1);
		this.label70.AutoSize = true;
		this.label70.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label70.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label70.Location = new System.Drawing.Point(1077, 864);
		this.label70.Name = "label70";
		this.label70.Size = new System.Drawing.Size(59, 37);
		this.label70.TabIndex = 58;
		this.label70.Text = "206";
		this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label67.AutoSize = true;
		this.label67.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label67.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label67.Location = new System.Drawing.Point(1077, 918);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(59, 37);
		this.label67.TabIndex = 55;
		this.label67.Text = "208";
		this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label245.AutoSize = true;
		this.label245.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label245.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label245.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label245.Location = new System.Drawing.Point(1077, 972);
		this.label245.Name = "label245";
		this.label245.Size = new System.Drawing.Size(59, 37);
		this.label245.TabIndex = 108;
		this.label245.Text = "209";
		this.label245.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label249.AutoSize = true;
		this.label249.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label249.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label249.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label249.Location = new System.Drawing.Point(1077, 1026);
		this.label249.Name = "label249";
		this.label249.Size = new System.Drawing.Size(59, 37);
		this.label249.TabIndex = 112;
		this.label249.Text = "210";
		this.label249.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label253.AutoSize = true;
		this.label253.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label253.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label253.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label253.Location = new System.Drawing.Point(1077, 1080);
		this.label253.Name = "label253";
		this.label253.Size = new System.Drawing.Size(59, 37);
		this.label253.TabIndex = 116;
		this.label253.Text = "212";
		this.label253.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label257.AutoSize = true;
		this.label257.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label257.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label257.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label257.Location = new System.Drawing.Point(1077, 1134);
		this.label257.Name = "label257";
		this.label257.Size = new System.Drawing.Size(59, 37);
		this.label257.TabIndex = 120;
		this.label257.Text = "214";
		this.label257.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label261.AutoSize = true;
		this.label261.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label261.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label261.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label261.Location = new System.Drawing.Point(1077, 1188);
		this.label261.Name = "label261";
		this.label261.Size = new System.Drawing.Size(59, 37);
		this.label261.TabIndex = 124;
		this.label261.Text = "215";
		this.label261.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label265.AutoSize = true;
		this.label265.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label265.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label265.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label265.Location = new System.Drawing.Point(1077, 1242);
		this.label265.Name = "label265";
		this.label265.Size = new System.Drawing.Size(59, 37);
		this.label265.TabIndex = 128;
		this.label265.Text = "216";
		this.label265.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.h206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h206.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h206.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h206.Location = new System.Drawing.Point(1001, 867);
		this.h206.Multiline = true;
		this.h206.Name = "h206";
		this.h206.Size = new System.Drawing.Size(70, 48);
		this.h206.TabIndex = 47;
		this.h206.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h206.Click += new System.EventHandler(h206_Click_1);
		this.h206.TextChanged += new System.EventHandler(h206_TextChanged_1);
		this.h206.KeyDown += new System.Windows.Forms.KeyEventHandler(h206_KeyDown_1);
		this.h206.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h206_KeyPress_1);
		this.h206.Leave += new System.EventHandler(h206_Leave_1);
		this.h208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h208.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h208.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h208.Location = new System.Drawing.Point(1001, 921);
		this.h208.Multiline = true;
		this.h208.Name = "h208";
		this.h208.Size = new System.Drawing.Size(70, 48);
		this.h208.TabIndex = 48;
		this.h208.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h208.Click += new System.EventHandler(h208_Click_1);
		this.h208.TextChanged += new System.EventHandler(h208_TextChanged_1);
		this.h208.KeyDown += new System.Windows.Forms.KeyEventHandler(h208_KeyDown_1);
		this.h208.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h208_KeyPress_1);
		this.h208.Leave += new System.EventHandler(h208_Leave_1);
		this.h209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h209.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h209.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h209.Location = new System.Drawing.Point(1001, 975);
		this.h209.Multiline = true;
		this.h209.Name = "h209";
		this.h209.Size = new System.Drawing.Size(70, 48);
		this.h209.TabIndex = 49;
		this.h209.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h209.Click += new System.EventHandler(h209_Click_1);
		this.h209.TextChanged += new System.EventHandler(h209_TextChanged_1);
		this.h209.KeyDown += new System.Windows.Forms.KeyEventHandler(h209_KeyDown_1);
		this.h209.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h209_KeyPress_1);
		this.h209.Leave += new System.EventHandler(h209_Leave_1);
		this.h210.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h210.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h210.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h210.Location = new System.Drawing.Point(1001, 1029);
		this.h210.Multiline = true;
		this.h210.Name = "h210";
		this.h210.Size = new System.Drawing.Size(70, 48);
		this.h210.TabIndex = 50;
		this.h210.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h210.Click += new System.EventHandler(h210_Click_1);
		this.h210.TextChanged += new System.EventHandler(h210_TextChanged_1);
		this.h210.KeyDown += new System.Windows.Forms.KeyEventHandler(h210_KeyDown_1);
		this.h210.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h210_KeyPress_1);
		this.h210.Leave += new System.EventHandler(h210_Leave_1);
		this.h212.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h212.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h212.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h212.Location = new System.Drawing.Point(1001, 1083);
		this.h212.Multiline = true;
		this.h212.Name = "h212";
		this.h212.Size = new System.Drawing.Size(70, 48);
		this.h212.TabIndex = 51;
		this.h212.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h212.Click += new System.EventHandler(h212_Click_1);
		this.h212.TextChanged += new System.EventHandler(h212_TextChanged_1);
		this.h212.KeyDown += new System.Windows.Forms.KeyEventHandler(h212_KeyDown_1);
		this.h212.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h212_KeyPress_1);
		this.h212.Leave += new System.EventHandler(h212_Leave_1);
		this.h214.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h214.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h214.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h214.Location = new System.Drawing.Point(1001, 1137);
		this.h214.Multiline = true;
		this.h214.Name = "h214";
		this.h214.Size = new System.Drawing.Size(70, 48);
		this.h214.TabIndex = 52;
		this.h214.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h214.Click += new System.EventHandler(h214_Click_1);
		this.h214.TextChanged += new System.EventHandler(h214_TextChanged_1);
		this.h214.KeyDown += new System.Windows.Forms.KeyEventHandler(h214_KeyDown_1);
		this.h214.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h214_KeyPress_1);
		this.h214.Leave += new System.EventHandler(h214_Leave_1);
		this.h215.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h215.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h215.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h215.Location = new System.Drawing.Point(1001, 1191);
		this.h215.Multiline = true;
		this.h215.Name = "h215";
		this.h215.Size = new System.Drawing.Size(70, 48);
		this.h215.TabIndex = 53;
		this.h215.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h215.Click += new System.EventHandler(h215_Click_1);
		this.h215.TextChanged += new System.EventHandler(h215_TextChanged_1);
		this.h215.KeyDown += new System.Windows.Forms.KeyEventHandler(h215_KeyDown_1);
		this.h215.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h215_KeyPress_1);
		this.h215.Leave += new System.EventHandler(h215_Leave_1);
		this.h216.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h216.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h216.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h216.Location = new System.Drawing.Point(1001, 1245);
		this.h216.Multiline = true;
		this.h216.Name = "h216";
		this.h216.Size = new System.Drawing.Size(70, 48);
		this.h216.TabIndex = 54;
		this.h216.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h216.Click += new System.EventHandler(h216_Click_1);
		this.h216.TextChanged += new System.EventHandler(h216_TextChanged_1);
		this.h216.KeyDown += new System.Windows.Forms.KeyEventHandler(h216_KeyDown_1);
		this.h216.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h216_KeyPress_1);
		this.h216.Leave += new System.EventHandler(h216_Leave_1);
		this.label273.AutoSize = true;
		this.label273.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.label273.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label273.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label273.Location = new System.Drawing.Point(1077, 1350);
		this.label273.Name = "label273";
		this.label273.Size = new System.Drawing.Size(59, 37);
		this.label273.TabIndex = 136;
		this.label273.Text = "219";
		this.label273.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label357.AutoSize = true;
		this.label357.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label357.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label357.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label357.ForeColor = System.Drawing.Color.White;
		this.label357.Location = new System.Drawing.Point(743, 1242);
		this.label357.Name = "label357";
		this.label357.Size = new System.Drawing.Size(59, 37);
		this.label357.TabIndex = 111;
		this.label357.Text = "230";
		this.label357.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s230.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s230.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s230.Location = new System.Drawing.Point(667, 1245);
		this.s230.Multiline = true;
		this.s230.Name = "s230";
		this.s230.Size = new System.Drawing.Size(70, 48);
		this.s230.TabIndex = 114;
		this.s230.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s230.Click += new System.EventHandler(s230_Click);
		this.s230.TextChanged += new System.EventHandler(s230_TextChanged_1);
		this.s230.KeyDown += new System.Windows.Forms.KeyEventHandler(s230_KeyDown_1);
		this.s230.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s230_KeyPress_1);
		this.s230.Leave += new System.EventHandler(s230_Leave_1);
		this.label353.AutoSize = true;
		this.label353.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label353.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label353.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label353.ForeColor = System.Drawing.Color.White;
		this.label353.Location = new System.Drawing.Point(743, 1188);
		this.label353.Name = "label353";
		this.label353.Size = new System.Drawing.Size(59, 37);
		this.label353.TabIndex = 107;
		this.label353.Text = "228";
		this.label353.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s228.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s228.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s228.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s228.Location = new System.Drawing.Point(667, 1191);
		this.s228.Multiline = true;
		this.s228.Name = "s228";
		this.s228.Size = new System.Drawing.Size(70, 48);
		this.s228.TabIndex = 113;
		this.s228.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s228.Click += new System.EventHandler(s228_Click);
		this.s228.TextChanged += new System.EventHandler(s228_TextChanged_1);
		this.s228.KeyDown += new System.Windows.Forms.KeyEventHandler(s228_KeyDown_1);
		this.s228.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s228_KeyPress_1);
		this.s228.Leave += new System.EventHandler(s228_Leave_1);
		this.label87.AutoSize = true;
		this.label87.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label87.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label87.ForeColor = System.Drawing.Color.White;
		this.label87.Location = new System.Drawing.Point(743, 1134);
		this.label87.Name = "label87";
		this.label87.Size = new System.Drawing.Size(59, 37);
		this.label87.TabIndex = 75;
		this.label87.Text = "226";
		this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s226.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s226.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s226.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s226.Location = new System.Drawing.Point(667, 1137);
		this.s226.Multiline = true;
		this.s226.Name = "s226";
		this.s226.Size = new System.Drawing.Size(70, 48);
		this.s226.TabIndex = 112;
		this.s226.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s226.Click += new System.EventHandler(s226_Click);
		this.s226.TextChanged += new System.EventHandler(s226_TextChanged_1);
		this.s226.KeyDown += new System.Windows.Forms.KeyEventHandler(s226_KeyDown_1);
		this.s226.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s226_KeyPress_1);
		this.s226.Leave += new System.EventHandler(s226_Leave_1);
		this.label83.AutoSize = true;
		this.label83.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label83.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label83.ForeColor = System.Drawing.Color.White;
		this.label83.Location = new System.Drawing.Point(743, 1080);
		this.label83.Name = "label83";
		this.label83.Size = new System.Drawing.Size(59, 37);
		this.label83.TabIndex = 71;
		this.label83.Text = "221";
		this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s221.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s221.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s221.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s221.Location = new System.Drawing.Point(667, 1083);
		this.s221.Multiline = true;
		this.s221.Name = "s221";
		this.s221.Size = new System.Drawing.Size(70, 48);
		this.s221.TabIndex = 111;
		this.s221.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s221.Click += new System.EventHandler(s221_Click);
		this.s221.TextChanged += new System.EventHandler(s221_TextChanged_1);
		this.s221.KeyDown += new System.Windows.Forms.KeyEventHandler(s221_KeyDown_1);
		this.s221.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s221_KeyPress_1);
		this.s221.Leave += new System.EventHandler(s221_Leave_1);
		this.label79.AutoSize = true;
		this.label79.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label79.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label79.ForeColor = System.Drawing.Color.White;
		this.label79.Location = new System.Drawing.Point(743, 1026);
		this.label79.Name = "label79";
		this.label79.Size = new System.Drawing.Size(59, 37);
		this.label79.TabIndex = 67;
		this.label79.Text = "218";
		this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s218.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s218.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s218.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s218.Location = new System.Drawing.Point(667, 1029);
		this.s218.Multiline = true;
		this.s218.Name = "s218";
		this.s218.Size = new System.Drawing.Size(70, 48);
		this.s218.TabIndex = 110;
		this.s218.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s218.Click += new System.EventHandler(s218_Click);
		this.s218.TextChanged += new System.EventHandler(s218_TextChanged_1);
		this.s218.KeyDown += new System.Windows.Forms.KeyEventHandler(s218_KeyDown_1);
		this.s218.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s218_KeyPress_1);
		this.s218.Leave += new System.EventHandler(s218_Leave_1);
		this.label75.AutoSize = true;
		this.label75.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label75.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label75.ForeColor = System.Drawing.Color.White;
		this.label75.Location = new System.Drawing.Point(743, 972);
		this.label75.Name = "label75";
		this.label75.Size = new System.Drawing.Size(59, 37);
		this.label75.TabIndex = 63;
		this.label75.Text = "207";
		this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s207.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s207.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s207.Location = new System.Drawing.Point(667, 975);
		this.s207.Multiline = true;
		this.s207.Name = "s207";
		this.s207.Size = new System.Drawing.Size(70, 48);
		this.s207.TabIndex = 109;
		this.s207.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s207.Click += new System.EventHandler(s207_Click);
		this.s207.TextChanged += new System.EventHandler(s207_TextChanged_1);
		this.s207.KeyDown += new System.Windows.Forms.KeyEventHandler(s207_KeyDown_1);
		this.s207.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s207_KeyPress_1);
		this.s207.Leave += new System.EventHandler(s207_Leave_1);
		this.s201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s201.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s201.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s201.Location = new System.Drawing.Point(667, 921);
		this.s201.Multiline = true;
		this.s201.Name = "s201";
		this.s201.Size = new System.Drawing.Size(70, 48);
		this.s201.TabIndex = 108;
		this.s201.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s201.Click += new System.EventHandler(s201_Click);
		this.s201.TextChanged += new System.EventHandler(s201_TextChanged_1);
		this.s201.KeyDown += new System.Windows.Forms.KeyEventHandler(s201_KeyDown_1);
		this.s201.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s201_KeyPress_1);
		this.s201.Leave += new System.EventHandler(s201_Leave_1);
		this.label71.AutoSize = true;
		this.label71.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label71.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label71.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label71.Location = new System.Drawing.Point(743, 918);
		this.label71.Name = "label71";
		this.label71.Size = new System.Drawing.Size(59, 37);
		this.label71.TabIndex = 59;
		this.label71.Text = "201";
		this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label68.AutoSize = true;
		this.label68.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label68.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label68.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label68.Location = new System.Drawing.Point(743, 864);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(59, 37);
		this.label68.TabIndex = 56;
		this.label68.Text = "198";
		this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s198.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s198.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s198.Location = new System.Drawing.Point(667, 867);
		this.s198.Multiline = true;
		this.s198.Name = "s198";
		this.s198.Size = new System.Drawing.Size(70, 48);
		this.s198.TabIndex = 107;
		this.s198.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s198.Click += new System.EventHandler(s198_Click);
		this.s198.TextChanged += new System.EventHandler(s198_TextChanged_1);
		this.s198.KeyDown += new System.Windows.Forms.KeyEventHandler(s198_KeyDown_1);
		this.s198.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s198_KeyPress_1);
		this.s198.Leave += new System.EventHandler(s198_Leave_1);
		this.s194.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s194.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s194.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s194.Location = new System.Drawing.Point(667, 813);
		this.s194.Multiline = true;
		this.s194.Name = "s194";
		this.s194.Size = new System.Drawing.Size(70, 48);
		this.s194.TabIndex = 106;
		this.s194.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s194.Click += new System.EventHandler(s194_Click);
		this.s194.TextChanged += new System.EventHandler(s194_TextChanged_1);
		this.s194.KeyDown += new System.Windows.Forms.KeyEventHandler(s194_KeyDown_1);
		this.s194.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s194_KeyPress_1);
		this.s194.Leave += new System.EventHandler(s194_Leave_1);
		this.label44.AutoSize = true;
		this.label44.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label44.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label44.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label44.Location = new System.Drawing.Point(743, 810);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(59, 37);
		this.label44.TabIndex = 32;
		this.label44.Text = "194";
		this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label40.AutoSize = true;
		this.label40.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label40.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label40.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label40.Location = new System.Drawing.Point(743, 756);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(59, 37);
		this.label40.TabIndex = 28;
		this.label40.Text = "193";
		this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s193.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s193.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s193.Location = new System.Drawing.Point(667, 759);
		this.s193.Multiline = true;
		this.s193.Name = "s193";
		this.s193.Size = new System.Drawing.Size(70, 48);
		this.s193.TabIndex = 105;
		this.s193.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s193.Click += new System.EventHandler(s193_Click);
		this.s193.TextChanged += new System.EventHandler(s193_TextChanged_1);
		this.s193.KeyDown += new System.Windows.Forms.KeyEventHandler(s193_KeyDown_1);
		this.s193.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s193_KeyPress_1);
		this.s193.Leave += new System.EventHandler(s193_Leave_1);
		this.label36.AutoSize = true;
		this.label36.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label36.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label36.Location = new System.Drawing.Point(743, 702);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(59, 37);
		this.label36.TabIndex = 24;
		this.label36.Text = "192";
		this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s192.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s192.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s192.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s192.Location = new System.Drawing.Point(667, 705);
		this.s192.Multiline = true;
		this.s192.Name = "s192";
		this.s192.Size = new System.Drawing.Size(70, 48);
		this.s192.TabIndex = 104;
		this.s192.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s192.Click += new System.EventHandler(s192_Click);
		this.s192.TextChanged += new System.EventHandler(s192_TextChanged_1);
		this.s192.KeyDown += new System.Windows.Forms.KeyEventHandler(s192_KeyDown_1);
		this.s192.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s192_KeyPress_1);
		this.s192.Leave += new System.EventHandler(s192_Leave_1);
		this.label32.AutoSize = true;
		this.label32.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label32.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label32.Location = new System.Drawing.Point(743, 648);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(59, 37);
		this.label32.TabIndex = 20;
		this.label32.Text = "190";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s190.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s190.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s190.Location = new System.Drawing.Point(667, 651);
		this.s190.Multiline = true;
		this.s190.Name = "s190";
		this.s190.Size = new System.Drawing.Size(70, 48);
		this.s190.TabIndex = 103;
		this.s190.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s190.Click += new System.EventHandler(s190_Click);
		this.s190.TextChanged += new System.EventHandler(s190_TextChanged_1);
		this.s190.KeyDown += new System.Windows.Forms.KeyEventHandler(s190_KeyDown_1);
		this.s190.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s190_KeyPress_1);
		this.s190.Leave += new System.EventHandler(s190_Leave_1);
		this.s185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s185.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s185.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s185.Location = new System.Drawing.Point(667, 597);
		this.s185.Multiline = true;
		this.s185.Name = "s185";
		this.s185.Size = new System.Drawing.Size(70, 48);
		this.s185.TabIndex = 102;
		this.s185.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s185.Click += new System.EventHandler(s185_Click);
		this.s185.TextChanged += new System.EventHandler(s185_TextChanged_1);
		this.s185.KeyDown += new System.Windows.Forms.KeyEventHandler(s185_KeyDown_1);
		this.s185.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s185_KeyPress_1);
		this.s185.Leave += new System.EventHandler(s185_Leave_1);
		this.s183.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s183.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s183.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s183.Location = new System.Drawing.Point(667, 543);
		this.s183.Multiline = true;
		this.s183.Name = "s183";
		this.s183.Size = new System.Drawing.Size(70, 48);
		this.s183.TabIndex = 101;
		this.s183.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s183.Click += new System.EventHandler(s183_Click);
		this.s183.TextChanged += new System.EventHandler(s183_TextChanged_1);
		this.s183.KeyDown += new System.Windows.Forms.KeyEventHandler(s183_KeyDown_1);
		this.s183.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s183_KeyPress_1);
		this.s183.Leave += new System.EventHandler(s183_Leave_1);
		this.s182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s182.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s182.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s182.Location = new System.Drawing.Point(667, 489);
		this.s182.Multiline = true;
		this.s182.Name = "s182";
		this.s182.Size = new System.Drawing.Size(70, 48);
		this.s182.TabIndex = 100;
		this.s182.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s182.Click += new System.EventHandler(s182_Click);
		this.s182.TextChanged += new System.EventHandler(s182_TextChanged_1);
		this.s182.KeyDown += new System.Windows.Forms.KeyEventHandler(s182_KeyDown_1);
		this.s182.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s182_KeyPress_1);
		this.s182.Leave += new System.EventHandler(s182_Leave_1);
		this.label28.AutoSize = true;
		this.label28.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label28.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label28.Location = new System.Drawing.Point(743, 594);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(59, 37);
		this.label28.TabIndex = 16;
		this.label28.Text = "185";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label24.AutoSize = true;
		this.label24.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label24.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label24.Location = new System.Drawing.Point(743, 540);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(59, 37);
		this.label24.TabIndex = 12;
		this.label24.Text = "183";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label20.AutoSize = true;
		this.label20.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label20.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label20.Location = new System.Drawing.Point(743, 486);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(59, 37);
		this.label20.TabIndex = 8;
		this.label20.Text = "182";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label16.AutoSize = true;
		this.label16.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label16.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label16.Location = new System.Drawing.Point(743, 432);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(59, 37);
		this.label16.TabIndex = 4;
		this.label16.Text = "180";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s180.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s180.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s180.Location = new System.Drawing.Point(667, 435);
		this.s180.Multiline = true;
		this.s180.Name = "s180";
		this.s180.Size = new System.Drawing.Size(70, 48);
		this.s180.TabIndex = 99;
		this.s180.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s180.Click += new System.EventHandler(s180_Click);
		this.s180.TextChanged += new System.EventHandler(s180_TextChanged_1);
		this.s180.KeyDown += new System.Windows.Forms.KeyEventHandler(s180_KeyDown_1);
		this.s180.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s180_KeyPress_1);
		this.s180.Leave += new System.EventHandler(s180_Leave_1);
		this.label13.AutoSize = true;
		this.label13.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label13.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.label13.Location = new System.Drawing.Point(743, 378);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(59, 37);
		this.label13.TabIndex = 1;
		this.label13.Text = "174";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s174.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s174.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s174.Location = new System.Drawing.Point(667, 381);
		this.s174.Multiline = true;
		this.s174.Name = "s174";
		this.s174.Size = new System.Drawing.Size(70, 48);
		this.s174.TabIndex = 98;
		this.s174.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s174.Click += new System.EventHandler(s174_Click);
		this.s174.TextChanged += new System.EventHandler(s174_TextChanged_1);
		this.s174.KeyDown += new System.Windows.Forms.KeyEventHandler(s174_KeyDown_1);
		this.s174.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s174_KeyPress_1);
		this.s174.Leave += new System.EventHandler(s174_Leave_1);
		this.label431.AutoSize = true;
		this.label431.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label431.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label431.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label431.ForeColor = System.Drawing.Color.White;
		this.label431.Location = new System.Drawing.Point(743, 324);
		this.label431.Name = "label431";
		this.label431.Size = new System.Drawing.Size(59, 37);
		this.label431.TabIndex = 185;
		this.label431.Text = "171";
		this.label431.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s171.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s171.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s171.Location = new System.Drawing.Point(667, 327);
		this.s171.Multiline = true;
		this.s171.Name = "s171";
		this.s171.Size = new System.Drawing.Size(70, 48);
		this.s171.TabIndex = 97;
		this.s171.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s171.Click += new System.EventHandler(s171_Click);
		this.s171.TextChanged += new System.EventHandler(s171_TextChanged_1);
		this.s171.KeyDown += new System.Windows.Forms.KeyEventHandler(s171_KeyDown_1);
		this.s171.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s171_KeyPress_1);
		this.s171.Leave += new System.EventHandler(s171_Leave_1);
		this.label427.AutoSize = true;
		this.label427.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label427.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label427.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label427.ForeColor = System.Drawing.Color.White;
		this.label427.Location = new System.Drawing.Point(743, 270);
		this.label427.Name = "label427";
		this.label427.Size = new System.Drawing.Size(59, 37);
		this.label427.TabIndex = 181;
		this.label427.Text = "169";
		this.label427.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s169.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s169.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s169.Location = new System.Drawing.Point(667, 273);
		this.s169.Multiline = true;
		this.s169.Name = "s169";
		this.s169.Size = new System.Drawing.Size(70, 48);
		this.s169.TabIndex = 96;
		this.s169.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s169.Click += new System.EventHandler(s169_Click);
		this.s169.TextChanged += new System.EventHandler(s169_TextChanged_1);
		this.s169.KeyDown += new System.Windows.Forms.KeyEventHandler(s169_KeyDown_1);
		this.s169.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s169_KeyPress_1);
		this.s169.Leave += new System.EventHandler(s169_Leave_1);
		this.label423.AutoSize = true;
		this.label423.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label423.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label423.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label423.ForeColor = System.Drawing.Color.White;
		this.label423.Location = new System.Drawing.Point(743, 216);
		this.label423.Name = "label423";
		this.label423.Size = new System.Drawing.Size(59, 37);
		this.label423.TabIndex = 177;
		this.label423.Text = "168";
		this.label423.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s168.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s168.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s168.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s168.Location = new System.Drawing.Point(667, 219);
		this.s168.Multiline = true;
		this.s168.Name = "s168";
		this.s168.Size = new System.Drawing.Size(70, 48);
		this.s168.TabIndex = 95;
		this.s168.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s168.Click += new System.EventHandler(s168_Click);
		this.s168.TextChanged += new System.EventHandler(s168_TextChanged_1);
		this.s168.KeyDown += new System.Windows.Forms.KeyEventHandler(s168_KeyDown_1);
		this.s168.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s168_KeyPress_1);
		this.s168.Leave += new System.EventHandler(s168_Leave_1);
		this.label361.AutoSize = true;
		this.label361.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label361.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label361.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label361.ForeColor = System.Drawing.Color.White;
		this.label361.Location = new System.Drawing.Point(743, 1296);
		this.label361.Name = "label361";
		this.label361.Size = new System.Drawing.Size(59, 37);
		this.label361.TabIndex = 115;
		this.label361.Text = "231";
		this.label361.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s231.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s231.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s231.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s231.Location = new System.Drawing.Point(667, 1299);
		this.s231.Multiline = true;
		this.s231.Name = "s231";
		this.s231.Size = new System.Drawing.Size(70, 48);
		this.s231.TabIndex = 115;
		this.s231.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s231.Click += new System.EventHandler(s231_Click);
		this.s231.TextChanged += new System.EventHandler(s231_TextChanged_1);
		this.s231.KeyDown += new System.Windows.Forms.KeyEventHandler(s231_KeyDown_1);
		this.s231.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s231_KeyPress_1);
		this.s231.Leave += new System.EventHandler(s231_Leave_1);
		this.s236.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s236.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s236.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s236.Location = new System.Drawing.Point(667, 1353);
		this.s236.Multiline = true;
		this.s236.Name = "s236";
		this.s236.Size = new System.Drawing.Size(70, 48);
		this.s236.TabIndex = 116;
		this.s236.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s236.Click += new System.EventHandler(s236_Click);
		this.s236.TextChanged += new System.EventHandler(s236_TextChanged_1);
		this.s236.KeyDown += new System.Windows.Forms.KeyEventHandler(s236_KeyDown_1);
		this.s236.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s236_KeyPress_1);
		this.s236.Leave += new System.EventHandler(s236_Leave_1);
		this.label365.AutoSize = true;
		this.label365.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label365.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label365.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label365.ForeColor = System.Drawing.Color.White;
		this.label365.Location = new System.Drawing.Point(743, 1350);
		this.label365.Name = "label365";
		this.label365.Size = new System.Drawing.Size(59, 37);
		this.label365.TabIndex = 119;
		this.label365.Text = "236";
		this.label365.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label419.AutoSize = true;
		this.label419.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label419.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label419.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label419.ForeColor = System.Drawing.Color.White;
		this.label419.Location = new System.Drawing.Point(743, 162);
		this.label419.Name = "label419";
		this.label419.Size = new System.Drawing.Size(59, 37);
		this.label419.TabIndex = 173;
		this.label419.Text = "166";
		this.label419.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s166.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s166.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s166.Location = new System.Drawing.Point(667, 165);
		this.s166.Multiline = true;
		this.s166.Name = "s166";
		this.s166.Size = new System.Drawing.Size(70, 48);
		this.s166.TabIndex = 94;
		this.s166.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s166.Click += new System.EventHandler(s166_Click);
		this.s166.TextChanged += new System.EventHandler(s166_TextChanged_1);
		this.s166.KeyDown += new System.Windows.Forms.KeyEventHandler(s166_KeyDown_1);
		this.s166.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s166_KeyPress_1);
		this.s166.Leave += new System.EventHandler(s166_Leave_1);
		this.label415.AutoSize = true;
		this.label415.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label415.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label415.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label415.ForeColor = System.Drawing.Color.White;
		this.label415.Location = new System.Drawing.Point(743, 108);
		this.label415.Name = "label415";
		this.label415.Size = new System.Drawing.Size(59, 37);
		this.label415.TabIndex = 169;
		this.label415.Text = "165";
		this.label415.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s165.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s165.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s165.Location = new System.Drawing.Point(667, 111);
		this.s165.Multiline = true;
		this.s165.Name = "s165";
		this.s165.Size = new System.Drawing.Size(70, 48);
		this.s165.TabIndex = 93;
		this.s165.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s165.Click += new System.EventHandler(s165_Click);
		this.s165.TextChanged += new System.EventHandler(s165_TextChanged_1);
		this.s165.KeyDown += new System.Windows.Forms.KeyEventHandler(s165_KeyDown_1);
		this.s165.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s165_KeyPress_1);
		this.s165.Leave += new System.EventHandler(s165_Leave_1);
		this.label411.AutoSize = true;
		this.label411.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label411.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label411.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label411.ForeColor = System.Drawing.Color.White;
		this.label411.Location = new System.Drawing.Point(743, 54);
		this.label411.Name = "label411";
		this.label411.Size = new System.Drawing.Size(59, 37);
		this.label411.TabIndex = 165;
		this.label411.Text = "164";
		this.label411.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s164.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s164.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s164.Location = new System.Drawing.Point(667, 57);
		this.s164.Multiline = true;
		this.s164.Name = "s164";
		this.s164.Size = new System.Drawing.Size(70, 48);
		this.s164.TabIndex = 92;
		this.s164.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s164.Click += new System.EventHandler(s164_Click);
		this.s164.TextChanged += new System.EventHandler(s164_TextChanged_1);
		this.s164.KeyDown += new System.Windows.Forms.KeyEventHandler(s164_KeyDown_1);
		this.s164.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s164_KeyPress_1);
		this.s164.Leave += new System.EventHandler(s164_Leave_1);
		this.label407.AutoSize = true;
		this.label407.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.label407.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label407.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label407.ForeColor = System.Drawing.Color.White;
		this.label407.Location = new System.Drawing.Point(743, 0);
		this.label407.Name = "label407";
		this.label407.Size = new System.Drawing.Size(59, 37);
		this.label407.TabIndex = 161;
		this.label407.Text = "162";
		this.label407.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s162.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s162.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s162.Location = new System.Drawing.Point(667, 3);
		this.s162.Multiline = true;
		this.s162.Name = "s162";
		this.s162.Size = new System.Drawing.Size(70, 48);
		this.s162.TabIndex = 91;
		this.s162.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s162.Click += new System.EventHandler(s162_Click);
		this.s162.TextChanged += new System.EventHandler(s162_TextChanged_1);
		this.s162.KeyDown += new System.Windows.Forms.KeyEventHandler(s162_KeyDown_1);
		this.s162.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s162_KeyPress_1);
		this.s162.Leave += new System.EventHandler(s162_Leave_1);
		this.lbl_taswit.AutoSize = true;
		this.lbl_taswit.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.lbl_taswit.Location = new System.Drawing.Point(307, 0);
		this.lbl_taswit.Name = "lbl_taswit";
		this.lbl_taswit.Size = new System.Drawing.Size(17, 54);
		this.lbl_taswit.TabIndex = 188;
		this.lbl_taswit.Text = "label51";
		this.labljorydangdan.AutoSize = true;
		this.labljorydangdan.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.labljorydangdan.Location = new System.Drawing.Point(307, 54);
		this.labljorydangdan.Name = "labljorydangdan";
		this.labljorydangdan.Size = new System.Drawing.Size(17, 54);
		this.labljorydangdan.TabIndex = 187;
		this.labljorydangdan.Text = "label51";
		this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tableLayoutPanel3.ColumnCount = 11;
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.811321f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.28302f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.962264f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.962264f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.35849f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.962264f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.811321f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.47352f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.193646f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.811321f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.11321f));
		this.tableLayoutPanel3.Controls.Add(this.btn_candid_hl, 0, 0);
		this.tableLayoutPanel3.Controls.Add(this.txt_total_hl, 0, 0);
		this.tableLayoutPanel3.Controls.Add(this.btn_candid_h, 10, 0);
		this.tableLayoutPanel3.Controls.Add(this.txt_total_h, 9, 0);
		this.tableLayoutPanel3.Controls.Add(this.txt_total_d, 3, 0);
		this.tableLayoutPanel3.Controls.Add(this.btn_candid_s, 7, 0);
		this.tableLayoutPanel3.Controls.Add(this.btn_candid_d, 4, 0);
		this.tableLayoutPanel3.Controls.Add(this.txt_total_s, 6, 0);
		this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 5);
		this.tableLayoutPanel3.Name = "tableLayoutPanel3";
		this.tableLayoutPanel3.RowCount = 1;
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tableLayoutPanel3.Size = new System.Drawing.Size(1304, 61);
		this.tableLayoutPanel3.TabIndex = 10;
		this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(tableLayoutPanel3_MouseMove);
		this.btn_candid_hl.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.btn_candid_hl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.btn_candid_hl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
		this.btn_candid_hl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_candid_hl.Font = new System.Drawing.Font("Unikurd Seyran", 16.2f);
		this.btn_candid_hl.ForeColor = System.Drawing.Color.Black;
		this.btn_candid_hl.Location = new System.Drawing.Point(78, 3);
		this.btn_candid_hl.Name = "btn_candid_hl";
		this.btn_candid_hl.Size = new System.Drawing.Size(219, 55);
		this.btn_candid_hl.TabIndex = 183;
		this.btn_candid_hl.Text = "هەڵەبجە";
		this.btn_candid_hl.UseVisualStyleBackColor = false;
		this.btn_candid_hl.Click += new System.EventHandler(button2_Click);
		this.txt_total_hl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_total_hl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_total_hl.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txt_total_hl.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txt_total_hl.Location = new System.Drawing.Point(3, 3);
		this.txt_total_hl.Multiline = true;
		this.txt_total_hl.Name = "txt_total_hl";
		this.txt_total_hl.ReadOnly = true;
		this.txt_total_hl.Size = new System.Drawing.Size(69, 55);
		this.txt_total_hl.TabIndex = 182;
		this.txt_total_hl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txt_total_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_total_d.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_total_d.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txt_total_d.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txt_total_d.Location = new System.Drawing.Point(328, 3);
		this.txt_total_d.Multiline = true;
		this.txt_total_d.Name = "txt_total_d";
		this.txt_total_d.ReadOnly = true;
		this.txt_total_d.Size = new System.Drawing.Size(71, 55);
		this.txt_total_d.TabIndex = 181;
		this.txt_total_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.btn_candid_s.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.btn_candid_s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.btn_candid_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
		this.btn_candid_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_candid_s.Font = new System.Drawing.Font("Unikurd Seyran", 16.2f);
		this.btn_candid_s.ForeColor = System.Drawing.Color.White;
		this.btn_candid_s.Location = new System.Drawing.Point(731, 3);
		this.btn_candid_s.Name = "btn_candid_s";
		this.btn_candid_s.Size = new System.Drawing.Size(222, 55);
		this.btn_candid_s.TabIndex = 184;
		this.btn_candid_s.Text = "سلیمانی";
		this.btn_candid_s.UseVisualStyleBackColor = false;
		this.btn_candid_s.Click += new System.EventHandler(button3_Click);
		this.btn_candid_s.MouseMove += new System.Windows.Forms.MouseEventHandler(button3_MouseMove);
		this.btn_candid_d.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.btn_candid_d.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.btn_candid_d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
		this.btn_candid_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_candid_d.Font = new System.Drawing.Font("Unikurd Seyran", 16.2f);
		this.btn_candid_d.ForeColor = System.Drawing.Color.Black;
		this.btn_candid_d.Location = new System.Drawing.Point(405, 3);
		this.btn_candid_d.Name = "btn_candid_d";
		this.btn_candid_d.Size = new System.Drawing.Size(220, 55);
		this.btn_candid_d.TabIndex = 185;
		this.btn_candid_d.Text = "دهۆک";
		this.btn_candid_d.UseVisualStyleBackColor = false;
		this.btn_candid_d.Click += new System.EventHandler(button4_Click);
		this.txt_total_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_total_s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_total_s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txt_total_s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txt_total_s.Location = new System.Drawing.Point(656, 3);
		this.txt_total_s.Multiline = true;
		this.txt_total_s.Name = "txt_total_s";
		this.txt_total_s.ReadOnly = true;
		this.txt_total_s.Size = new System.Drawing.Size(69, 55);
		this.txt_total_s.TabIndex = 180;
		this.txt_total_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1357, 833);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bnltablsearch);
		base.Controls.Add(this.tableLayoutPanel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "TEST";
		this.Text = "تایبه\u200cت";
		base.Load += new System.EventHandler(add_Gshty_Load);
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.bnltablsearch.ResumeLayout(false);
		this.bnltablsearch.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.tableLayoutPanel7.ResumeLayout(false);
		this.tableLayoutPanel7.PerformLayout();
		this.tableLayoutPanel3.ResumeLayout(false);
		this.tableLayoutPanel3.PerformLayout();
		base.ResumeLayout(false);
	}
}
