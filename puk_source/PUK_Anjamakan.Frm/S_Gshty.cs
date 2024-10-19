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

public class S_Gshty : Form
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

	private Panel panel1;

	private Label label213;

	private Label label209;

	private Label label205;

	private Label label201;

	private Label label197;

	private Label label193;

	private Label label189;

	private Label label185;

	private Label label181;

	private Label label177;

	private Label label173;

	private Label label169;

	private Label label165;

	private Label label161;

	private Label label157;

	private Label label153;

	private Label label149;

	private Label label145;

	private Label label141;

	private Label label137;

	private Label label133;

	private Label label129;

	private Label label125;

	private Label label121;

	private Label label117;

	private Label label113;

	private Label label94;

	private Label label91;

	private Label label54;

	private Label label56;

	private Label label58;

	private Label label66;

	private Label label65;

	private Label label62;

	private Label label60;

	private Label label64;

	private Label label52;

	private Label label50;

	private Label label53;

	private Label label57;

	private Label label55;

	private Label label23;

	private Label label19;

	private Label label12;

	private TextBox s36;

	private TextBox s60;

	private TextBox s27;

	private TextBox s64;

	private TextBox s24;

	private TextBox s58;

	private TextBox s59;

	private TextBox s65;

	private TextBox s166s;

	private TextBox s31;

	private TextBox s168s;

	private TextBox s23;

	private TextBox s169s;

	private TextBox s29;

	private TextBox s30;

	private TextBox s25;

	private TextBox s66;

	private TextBox s62;

	private TextBox s22;

	private TextBox s221;

	private TextBox s32;

	private TextBox s207;

	private TextBox s70;

	private TextBox s57;

	private TextBox s35;

	private TextBox s171s;

	private TextBox s34;

	private TextBox s63;

	private TextBox s72;

	private TextBox s61;

	private TextBox s28;

	private TextBox s26;

	private TextBox s69;

	private TextBox s71;

	private TextBox s67;

	private TextBox s33;

	private TextBox s68;

	private TextBox s50;

	private TextBox s49;

	private TextBox s48;

	private TextBox s47;

	private TextBox s46;

	private TextBox s45;

	private TextBox s44;

	private TextBox s43;

	private TextBox s42;

	private TextBox s41;

	private TextBox s40;

	private TextBox s39;

	private TextBox s38;

	private TextBox s37;

	private TextBox s21;

	private TextBox s20;

	private TextBox s19;

	private TextBox s18;

	private TextBox s17;

	private TextBox s16;

	private TextBox s15;

	private TextBox s14;

	private TextBox s13;

	private TextBox s12;

	private TextBox s11;

	private TextBox s10;

	private TextBox s9;

	private TextBox s8;

	private TextBox s7;

	private TextBox s6;

	private TextBox s56;

	private TextBox s5;

	private TextBox s55;

	private TextBox s4;

	private TextBox s54;

	private TextBox s3;

	private TextBox s53;

	private TextBox s2;

	private TextBox s52;

	private TextBox s1;

	private TextBox s51;

	private TextBox s180s;

	private TextBox s165s;

	private TextBox s174s;

	private TextBox s164s;

	private TextBox s162s;

	private TextBox s161s;

	private TextBox s157s;

	private TextBox h235;

	private TextBox h234;

	private TextBox s153s;

	private TextBox s148s;

	private TextBox h233;

	private TextBox h229;

	private TextBox h220;

	private TextBox h223;

	private TextBox s147s;

	private TextBox h219;

	private TextBox s145s;

	private TextBox s138s;

	private TextBox s137s;

	private TextBox h217;

	private TextBox h216;

	private TextBox s136s;

	private TextBox h215;

	private TextBox s135s;

	private TextBox h214;

	private TextBox s133s;

	private TextBox h212;

	private TextBox s130s;

	private TextBox h210;

	private TextBox s231s;

	private TextBox s129s;

	private TextBox s236s;

	private TextBox s128s;

	private TextBox s125s;

	private TextBox s230s;

	private TextBox s228s;

	private TextBox s124s;

	private TextBox s226s;

	private TextBox s123s;

	private TextBox s122s;

	private TextBox s221s;

	private TextBox s121s;

	private TextBox s119s;

	private TextBox s117s;

	private TextBox s218s;

	private TextBox s207s;

	private TextBox s201s;

	private TextBox s198s;

	private TextBox s194s;

	private TextBox s193s;

	private TextBox s116s;

	private TextBox s115s;

	private TextBox s114s;

	private TextBox s113s;

	private TextBox s190s;

	private TextBox s192s;

	private TextBox s110s;

	private TextBox s185s;

	private TextBox s104s;

	private TextBox s101s;

	private TextBox s183s;

	private TableLayoutPanel tableLayoutPanel7;

	private TextBox s182s;

	private Label label311;

	private Label label307;

	private Label label303;

	private Label label299;

	private Label label295;

	private Label label291;

	private Label label287;

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

	private Label label27;

	private Label label31;

	private Label label35;

	private Label label39;

	private Label label47;

	private Label label88;

	private Label label84;

	private TableLayoutPanel tableLayoutPanel3;

	private Button btn_p;

	private TextBox txt_candid_s;

	private Button button5;

	private Label label49;

	private Label label16;

	private Label label13;

	private Label label15;

	private Label label18;

	private Label label20;

	private Label label22;

	private Label label24;

	private Label label26;

	private Label label28;

	private Label label30;

	private Label label32;

	private Label label34;

	private Label label36;

	private Label label38;

	private Label label40;

	private Label label42;

	private Label label44;

	private Label label46;

	private Label label48;

	private Label label51;

	private Label label59;

	private Label label61;

	private Label label63;

	private Label label68;

	private Label label71;

	private Label label73;

	private Label label75;

	private Label label77;

	private Label label79;

	private Label label81;

	private Label label83;

	private Label label85;

	private Label label87;

	private Label label89;

	private Label label90;

	private Label label96;

	private Label label97;

	private Label label98;

	private Label label99;

	private Label label100;

	private Label label101;

	private Label label102;

	private Label label103;

	private Label label104;

	private Label label105;

	private Label label106;

	private Label label107;

	private Label label108;

	private Label label109;

	private Label label110;

	private Label label111;

	private Label label112;

	private Label label114;

	private Label label115;

	private Label label116;

	private Label label118;

	private Label label119;

	private Label label120;

	private Label label122;

	private Label label123;

	private Label label124;

	private Label label126;

	private Label label127;

	private Label label128;

	private Label label130;

	private Label label131;

	private Label label132;

	private Label label134;

	private Label label14;

	private Label label17;

	private Label label21;

	private Label label25;

	private Label label29;

	private Label label33;

	private Label label37;

	private Label label41;

	private Label label45;

	private Label label67;

	private Label label70;

	private Label label78;

	private Label label82;

	private Label label86;

	private Label label136;

	private Label label138;

	private Label label139;

	private Label label140;

	private Label label142;

	private Label label143;

	private Label label144;

	private Label label146;

	private Label label147;

	private Label label148;

	private Label label150;

	private Label label151;

	private Label label152;

	private Label label154;

	private Label label155;

	private Label label156;

	private Label label158;

	private Label label159;

	private Label label160;

	private Label label162;

	private Label label163;

	private Label label164;

	private Label label166;

	private Label label167;

	private Label label168;

	private Label label170;

	private Label label171;

	private Label label172;

	private Label label174;

	private Label label175;

	private Label label176;

	private Label label178;

	private Label label179;

	private Label label180;

	private Label label182;

	private Label label183;

	private Label label184;

	private Label label186;

	private Label label187;

	private Label label188;

	private Label label190;

	private Label label191;

	private Label label192;

	private Label label194;

	private Label label195;

	private Label label196;

	private Label label198;

	private Label label199;

	private Label label200;

	private Label label202;

	private Label label203;

	private Label label204;

	private Label label206;

	private Label label207;

	private Label label208;

	private Label label210;

	private Label lbl_taswit;

	private TextBox txt_total_s;

	private Button btn_candid_d;

	private Label labljorydangdan;

	public S_Gshty()
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
		btnadd.BackColor = ThemeColor.SecondaryColor;
		btn_p.BackColor = ThemeColor.PrimaryColor;
		btn_candid_d.BackColor = ThemeColor.PrimaryColor;
	}

	private void pnalrgp()
	{
	}

	private void totals()
	{
		try
		{
			double To2 = (double)int.Parse(s101s.Text) + Convert.ToDouble(s104s.Text) + Convert.ToDouble(s110s.Text) + Convert.ToDouble(s113s.Text) + Convert.ToDouble(s114s.Text) + Convert.ToDouble(s115s.Text) + Convert.ToDouble(s116s.Text) + Convert.ToDouble(s117s.Text) + Convert.ToDouble(s119s.Text) + Convert.ToDouble(s121s.Text) + Convert.ToDouble(s122s.Text) + Convert.ToDouble(s123s.Text) + Convert.ToDouble(s124s.Text) + Convert.ToDouble(s125s.Text) + Convert.ToDouble(s128s.Text) + Convert.ToDouble(s129s.Text) + Convert.ToDouble(s130s.Text) + Convert.ToDouble(s133s.Text) + Convert.ToDouble(s135s.Text) + Convert.ToDouble(s136s.Text) + Convert.ToDouble(s137s.Text) + Convert.ToDouble(s138s.Text) + Convert.ToDouble(s145s.Text) + Convert.ToDouble(s147s.Text) + Convert.ToDouble(s148s.Text) + Convert.ToDouble(s153s.Text) + Convert.ToDouble(s157s.Text) + Convert.ToDouble(s161s.Text) + Convert.ToDouble(s162s.Text) + Convert.ToDouble(s164s.Text) + Convert.ToDouble(s165s.Text) + Convert.ToDouble(s166s.Text) + Convert.ToDouble(s168s.Text) + Convert.ToDouble(s169s.Text) + Convert.ToDouble(s171s.Text) + Convert.ToDouble(s174s.Text) + Convert.ToDouble(s180s.Text) + Convert.ToDouble(s182s.Text) + Convert.ToDouble(s183s.Text) + Convert.ToDouble(s185s.Text) + Convert.ToDouble(s190s.Text) + Convert.ToDouble(s192s.Text) + Convert.ToDouble(s193s.Text) + Convert.ToDouble(s194s.Text) + Convert.ToDouble(s198s.Text) + Convert.ToDouble(s201s.Text) + Convert.ToDouble(s207s.Text) + Convert.ToDouble(s218s.Text) + Convert.ToDouble(s221s.Text) + Convert.ToDouble(s226s.Text) + Convert.ToDouble(s228s.Text) + Convert.ToDouble(s230s.Text) + Convert.ToDouble(s231s.Text) + Convert.ToDouble(s236s.Text);
			double To3 = (double)int.Parse(s1.Text) + Convert.ToDouble(s2.Text) + Convert.ToDouble(s3.Text) + Convert.ToDouble(s4.Text) + Convert.ToDouble(s5.Text) + Convert.ToDouble(s6.Text) + Convert.ToDouble(s7.Text) + Convert.ToDouble(s8.Text) + Convert.ToDouble(s9.Text) + Convert.ToDouble(s10.Text) + Convert.ToDouble(s11.Text) + Convert.ToDouble(s12.Text) + Convert.ToDouble(s13.Text) + Convert.ToDouble(s14.Text) + Convert.ToDouble(s15.Text) + Convert.ToDouble(s16.Text) + Convert.ToDouble(s17.Text) + Convert.ToDouble(s18.Text) + Convert.ToDouble(s19.Text) + Convert.ToDouble(s20.Text) + Convert.ToDouble(s21.Text) + Convert.ToDouble(s22.Text) + Convert.ToDouble(s23.Text) + Convert.ToDouble(s24.Text) + Convert.ToDouble(s25.Text) + Convert.ToDouble(s26.Text) + Convert.ToDouble(s27.Text) + Convert.ToDouble(s28.Text) + Convert.ToDouble(s29.Text) + Convert.ToDouble(s30.Text) + Convert.ToDouble(s31.Text) + Convert.ToDouble(s32.Text) + Convert.ToDouble(s33.Text) + Convert.ToDouble(s34.Text) + Convert.ToDouble(s35.Text) + Convert.ToDouble(s36.Text) + Convert.ToDouble(s37.Text) + Convert.ToDouble(s38.Text) + Convert.ToDouble(s39.Text) + Convert.ToDouble(s40.Text) + Convert.ToDouble(s41.Text) + Convert.ToDouble(s42.Text) + Convert.ToDouble(s43.Text) + Convert.ToDouble(s44.Text) + Convert.ToDouble(s45.Text) + Convert.ToDouble(s46.Text) + Convert.ToDouble(s47.Text) + Convert.ToDouble(s48.Text) + Convert.ToDouble(s49.Text) + Convert.ToDouble(s50.Text) + Convert.ToDouble(s51.Text) + Convert.ToDouble(s52.Text) + Convert.ToDouble(s53.Text) + Convert.ToDouble(s54.Text) + Convert.ToDouble(s55.Text) + Convert.ToDouble(s56.Text) + Convert.ToDouble(s57.Text) + Convert.ToDouble(s58.Text) + Convert.ToDouble(s59.Text) + Convert.ToDouble(s60.Text) + Convert.ToDouble(s61.Text) + Convert.ToDouble(s62.Text) + Convert.ToDouble(s63.Text) + Convert.ToDouble(s64.Text) + Convert.ToDouble(s65.Text) + Convert.ToDouble(s66.Text) + Convert.ToDouble(s67.Text) + Convert.ToDouble(s68.Text) + Convert.ToDouble(s69.Text) + Convert.ToDouble(s70.Text) + Convert.ToDouble(s71.Text) + Convert.ToDouble(s72.Text);
			txt_total_s.Text = To2.ToString();
			txt_candid_s.Text = To3.ToString();
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

	private void tex1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex3_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex4_KeyPress_1(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex6_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex7_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex8_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex9_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex10_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex11_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex12_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex13_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex14_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex15_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex16_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex17_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex18_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex19_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex20_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex21_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex22_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex23_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex24_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex25_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex26_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex27_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex28_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex29_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex31_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex30_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex32_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex33_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void tex33_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex34_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex35_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex36_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex37_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex38_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex39_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex40_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex41_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex42_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex43_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex44_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex45_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex46_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex47_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex48_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex49_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex50_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex51_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void tex51_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex52_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex53_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex54_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex55_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex56_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex57_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex58_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex59_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex60_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
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
			MessageBox.Show("تکایە ژمارەی بنکەی دەنگدان بنوسە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

	private void Update_s()
	{
		Home ho = new Home();
		string qurey = "Update  slemany_hazb set [waraqa_rast]=@waraqa_rast,[waraqapochal]=@waraqapochal ,[101]=@s101,\t[104] =@s104, \t[110] =@s110, \t[113] =@s113, \t[114] =@s114, \t[115] =@s115, \t[116] =@s116, \t[117] =@s117, \t[119] =@s119, \t[121] =@s121, \t[122] =@s122, \t[123] =@s123, \t[124] =@s124, \t[125] =@s125, \t[128] =@s128, \t[129] =@s129, \t[130] =@s130, \t[133] =@s133, \t[135] =@s135, \t[136] =@s136, \t[137] =@s137, \t[138] =@s138, \t[145] =@s145, \t[147] =@s147, \t[148] =@s148, \t[153] =@s153, \t[157] =@s157, \t[161] =@s161, \t[162] =@s162, \t[164] =@s164, \t[165] =@s165, \t[166] =@s166, \t[168] =@s168, \t[169] =@s169, \t[171] =@s171, \t[174] =@s174, \t[180] =@s180, \t[182] =@s182, \t[183] =@s183, \t[185] =@s185, \t[190] =@s190, \t[192] =@s192, \t[193] =@s193, \t[194] =@s194, \t[198] =@s198, \t[201] =@s201, \t[207] =@s207, \t[218] =@s218, \t[221] =@s221, \t[226] =@s226, \t[228] =@s228, \t[230] =@s230, \t[231] =@s231, \t[236]  =@s236   WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@waraqa_rast", txtwaraqadrost.Text);
		cmd.Parameters.AddWithValue("@waraqapochal", txtwaraqaybatl.Text);
		cmd.Parameters.AddWithValue("@s101", s101s.Text);
		cmd.Parameters.AddWithValue("@s104", s104s.Text);
		cmd.Parameters.AddWithValue("@s110", s110s.Text);
		cmd.Parameters.AddWithValue("@s113", s113s.Text);
		cmd.Parameters.AddWithValue("@s114", s114s.Text);
		cmd.Parameters.AddWithValue("@s115", s115s.Text);
		cmd.Parameters.AddWithValue("@s116", s116s.Text);
		cmd.Parameters.AddWithValue("@s117", s117s.Text);
		cmd.Parameters.AddWithValue("@s119", s119s.Text);
		cmd.Parameters.AddWithValue("@s121", s121s.Text);
		cmd.Parameters.AddWithValue("@s122", s122s.Text);
		cmd.Parameters.AddWithValue("@s123", s123s.Text);
		cmd.Parameters.AddWithValue("@s124", s124s.Text);
		cmd.Parameters.AddWithValue("@s125", s125s.Text);
		cmd.Parameters.AddWithValue("@s128", s128s.Text);
		cmd.Parameters.AddWithValue("@s129", s129s.Text);
		cmd.Parameters.AddWithValue("@s130", s130s.Text);
		cmd.Parameters.AddWithValue("@s133", s133s.Text);
		cmd.Parameters.AddWithValue("@s135", s135s.Text);
		cmd.Parameters.AddWithValue("@s136", s136s.Text);
		cmd.Parameters.AddWithValue("@s137", s137s.Text);
		cmd.Parameters.AddWithValue("@s138", s138s.Text);
		cmd.Parameters.AddWithValue("@s145", s145s.Text);
		cmd.Parameters.AddWithValue("@s147", s147s.Text);
		cmd.Parameters.AddWithValue("@s148", s148s.Text);
		cmd.Parameters.AddWithValue("@s153", s153s.Text);
		cmd.Parameters.AddWithValue("@s157", s157s.Text);
		cmd.Parameters.AddWithValue("@s161", s161s.Text);
		cmd.Parameters.AddWithValue("@s162", s162s.Text);
		cmd.Parameters.AddWithValue("@s164", s164s.Text);
		cmd.Parameters.AddWithValue("@s165", s165s.Text);
		cmd.Parameters.AddWithValue("@s166", s166s.Text);
		cmd.Parameters.AddWithValue("@s168", s168s.Text);
		cmd.Parameters.AddWithValue("@s169", s169s.Text);
		cmd.Parameters.AddWithValue("@s171", s171s.Text);
		cmd.Parameters.AddWithValue("@s174", s174s.Text);
		cmd.Parameters.AddWithValue("@s180", s180s.Text);
		cmd.Parameters.AddWithValue("@s182", s182s.Text);
		cmd.Parameters.AddWithValue("@s183", s183s.Text);
		cmd.Parameters.AddWithValue("@s185", s185s.Text);
		cmd.Parameters.AddWithValue("@s190", s190s.Text);
		cmd.Parameters.AddWithValue("@s192", s192s.Text);
		cmd.Parameters.AddWithValue("@s193", s193s.Text);
		cmd.Parameters.AddWithValue("@s194", s194s.Text);
		cmd.Parameters.AddWithValue("@s198", s198s.Text);
		cmd.Parameters.AddWithValue("@s201", s201s.Text);
		cmd.Parameters.AddWithValue("@s207", s207s.Text);
		cmd.Parameters.AddWithValue("@s218", s218s.Text);
		cmd.Parameters.AddWithValue("@s221", s221s.Text);
		cmd.Parameters.AddWithValue("@s226", s226s.Text);
		cmd.Parameters.AddWithValue("@s228", s228s.Text);
		cmd.Parameters.AddWithValue("@s230", s230s.Text);
		cmd.Parameters.AddWithValue("@s231", s231s.Text);
		cmd.Parameters.AddWithValue("@s236", s236s.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
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
		cmd.Parameters.AddWithValue("@s117", s72.Text);
		cmd.Parameters.AddWithValue("@s119", s34.Text);
		cmd.Parameters.AddWithValue("@s121", s35.Text);
		cmd.Parameters.AddWithValue("@s122", s70.Text);
		cmd.Parameters.AddWithValue("@s123", s32.Text);
		cmd.Parameters.AddWithValue("@s128", s62.Text);
		cmd.Parameters.AddWithValue("@s129", s25.Text);
		cmd.Parameters.AddWithValue("@s133", s169s.Text);
		cmd.Parameters.AddWithValue("@s135", s168s.Text);
		cmd.Parameters.AddWithValue("@s136", s31.Text);
		cmd.Parameters.AddWithValue("@s137", s166s.Text);
		cmd.Parameters.AddWithValue("@s138", s65.Text);
		cmd.Parameters.AddWithValue("@s145", s59.Text);
		cmd.Parameters.AddWithValue("@s147", s58.Text);
		cmd.Parameters.AddWithValue("@s148", s24.Text);
		cmd.Parameters.AddWithValue("@s153", s64.Text);
		cmd.Parameters.AddWithValue("@s157", s27.Text);
		cmd.Parameters.AddWithValue("@s161", s60.Text);
		cmd.Parameters.AddWithValue("@s171", s36.Text);
		cmd.Parameters.AddWithValue("@s174", s68.Text);
		cmd.Parameters.AddWithValue("@s180", s33.Text);
		cmd.Parameters.AddWithValue("@s182", s67.Text);
		cmd.Parameters.AddWithValue("@s183", s71.Text);
		cmd.Parameters.AddWithValue("@s185", s69.Text);
		cmd.Parameters.AddWithValue("@s190", s26.Text);
		cmd.Parameters.AddWithValue("@s192", s28.Text);
		cmd.Parameters.AddWithValue("@s193", s61.Text);
		cmd.Parameters.AddWithValue("@s194", s63.Text);
		cmd.Parameters.AddWithValue("@s198", s171s.Text);
		cmd.Parameters.AddWithValue("@s201", s57.Text);
		cmd.Parameters.AddWithValue("@s207", s207.Text);
		cmd.Parameters.AddWithValue("@s218", s218s.Text);
		cmd.Parameters.AddWithValue("@s221", s221.Text);
		cmd.Parameters.AddWithValue("@s226", s22.Text);
		cmd.Parameters.AddWithValue("@s228", s66.Text);
		cmd.Parameters.AddWithValue("@s230", s30.Text);
		cmd.Parameters.AddWithValue("@s231", s29.Text);
		cmd.Parameters.AddWithValue("@s236", s23.Text);
		cmd.Parameters.AddWithValue("@h102", s101s.Text);
		cmd.Parameters.AddWithValue("@h103", s104s.Text);
		cmd.Parameters.AddWithValue("@h105", s110s.Text);
		cmd.Parameters.AddWithValue("@h106", s113s.Text);
		cmd.Parameters.AddWithValue("@h109", s114s.Text);
		cmd.Parameters.AddWithValue("@h111", s115s.Text);
		cmd.Parameters.AddWithValue("@h112", s116s.Text);
		cmd.Parameters.AddWithValue("@h120", s117s.Text);
		cmd.Parameters.AddWithValue("@h123", s119s.Text);
		cmd.Parameters.AddWithValue("@h129", s121s.Text);
		cmd.Parameters.AddWithValue("@h131", s122s.Text);
		cmd.Parameters.AddWithValue("@h133", s123s.Text);
		cmd.Parameters.AddWithValue("@h139", s124s.Text);
		cmd.Parameters.AddWithValue("@h144", s125s.Text);
		cmd.Parameters.AddWithValue("@h146", s128s.Text);
		cmd.Parameters.AddWithValue("@h147", s129s.Text);
		cmd.Parameters.AddWithValue("@h148", s130s.Text);
		cmd.Parameters.AddWithValue("@h149", s133s.Text);
		cmd.Parameters.AddWithValue("@h150", s135s.Text);
		cmd.Parameters.AddWithValue("@h151", s136s.Text);
		cmd.Parameters.AddWithValue("@h154", s137s.Text);
		cmd.Parameters.AddWithValue("@h156", s138s.Text);
		cmd.Parameters.AddWithValue("@h157", s145s.Text);
		cmd.Parameters.AddWithValue("@h158", s147s.Text);
		cmd.Parameters.AddWithValue("@h160", s148s.Text);
		cmd.Parameters.AddWithValue("@h161", s153s.Text);
		cmd.Parameters.AddWithValue("@h162", s157s.Text);
		cmd.Parameters.AddWithValue("@h164", s161s.Text);
		cmd.Parameters.AddWithValue("@h167", s162s.Text);
		cmd.Parameters.AddWithValue("@h169", s164s.Text);
		cmd.Parameters.AddWithValue("@h170", s165s.Text);
		cmd.Parameters.AddWithValue("@h173", s174s.Text);
		cmd.Parameters.AddWithValue("@h176", s180s.Text);
		cmd.Parameters.AddWithValue("@h178", s182s.Text);
		cmd.Parameters.AddWithValue("@h179", s183s.Text);
		cmd.Parameters.AddWithValue("@h181", s185s.Text);
		cmd.Parameters.AddWithValue("@h184", s190s.Text);
		cmd.Parameters.AddWithValue("@h187", s192s.Text);
		cmd.Parameters.AddWithValue("@h189", s193s.Text);
		cmd.Parameters.AddWithValue("@h190", s194s.Text);
		cmd.Parameters.AddWithValue("@h191", s198s.Text);
		cmd.Parameters.AddWithValue("@h198", s201s.Text);
		cmd.Parameters.AddWithValue("@h199", s207s.Text);
		cmd.Parameters.AddWithValue("@h202", s218s.Text);
		cmd.Parameters.AddWithValue("@h203", s221s.Text);
		cmd.Parameters.AddWithValue("@h204", s226s.Text);
		cmd.Parameters.AddWithValue("@h205", s228s.Text);
		cmd.Parameters.AddWithValue("@h206", s230s.Text);
		cmd.Parameters.AddWithValue("@h208", s231s.Text);
		cmd.Parameters.AddWithValue("@h209", s236s.Text);
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
		cmd.Parameters.AddWithValue("@d107", s1.Text);
		cmd.Parameters.AddWithValue("@d108", s2.Text);
		cmd.Parameters.AddWithValue("@d114", s3.Text);
		cmd.Parameters.AddWithValue("@d118", s4.Text);
		cmd.Parameters.AddWithValue("@d126", s5.Text);
		cmd.Parameters.AddWithValue("@d127", s6.Text);
		cmd.Parameters.AddWithValue("@d129", s7.Text);
		cmd.Parameters.AddWithValue("@d132", s8.Text);
		cmd.Parameters.AddWithValue("@d133", s9.Text);
		cmd.Parameters.AddWithValue("@d134", s10.Text);
		cmd.Parameters.AddWithValue("@d140", s11.Text);
		cmd.Parameters.AddWithValue("@d141", s12.Text);
		cmd.Parameters.AddWithValue("@d142", s13.Text);
		cmd.Parameters.AddWithValue("@d143", s14.Text);
		cmd.Parameters.AddWithValue("@d147", s15.Text);
		cmd.Parameters.AddWithValue("@d148", s16.Text);
		cmd.Parameters.AddWithValue("@d152", s17.Text);
		cmd.Parameters.AddWithValue("@d155", s18.Text);
		cmd.Parameters.AddWithValue("@d157", s19.Text);
		cmd.Parameters.AddWithValue("@d159", s20.Text);
		cmd.Parameters.AddWithValue("@d161", s21.Text);
		cmd.Parameters.AddWithValue("@d162", s37.Text);
		cmd.Parameters.AddWithValue("@d163", s38.Text);
		cmd.Parameters.AddWithValue("@d164", s39.Text);
		cmd.Parameters.AddWithValue("@d169", s40.Text);
		cmd.Parameters.AddWithValue("@d175", s41.Text);
		cmd.Parameters.AddWithValue("@d177", s42.Text);
		cmd.Parameters.AddWithValue("@d186", s43.Text);
		cmd.Parameters.AddWithValue("@d188", s44.Text);
		cmd.Parameters.AddWithValue("@d190", s45.Text);
		cmd.Parameters.AddWithValue("@d195", s46.Text);
		cmd.Parameters.AddWithValue("@d196", s47.Text);
		cmd.Parameters.AddWithValue("@d197", s48.Text);
		cmd.Parameters.AddWithValue("@d200", s49.Text);
		cmd.Parameters.AddWithValue("@d211", s50.Text);
		cmd.Parameters.AddWithValue("@d213", s51.Text);
		cmd.Parameters.AddWithValue("@d222", s52.Text);
		cmd.Parameters.AddWithValue("@d224", s53.Text);
		cmd.Parameters.AddWithValue("@d225", s54.Text);
		cmd.Parameters.AddWithValue("@d227", s55.Text);
		cmd.Parameters.AddWithValue("@d232", s56.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
	}

	private void Update_cabdid()
	{
		string qurey = "Update candid_s set [1]=@1,\t[2]=@2,\t[3]=@3,\t[4]=@4,\t[5]=@5,\t[6]=@6,\t[7]=@7,\t[8]=@8,\t[9]=@9,\t[10]=@10,\t[11]=@11,\t[12]=@12,\t[13]=@13,\t[14]=@14,\t[15]=@15,\t[16]=@16,\t[17]=@17,\t[18]=@18,\t[19]=@19,\t[20]=@20,\t[21]=@21,\t[22]=@22,\t[23]=@23,\t[24]=@24,\t[25]=@25,\t[26]=@26,\t[27]=@27,\t[28]=@28,\t[29]=@29,\t[30]=@30,\t[31]=@31,\t[32]=@32,\t[33]=@33,\t[34]=@34,\t[35]=@35,\t[36]=@36,\t[37]=@37,\t[38]=@38,\t[39]=@39,\t[40]=@40,\t[41]=@41,\t[42]=@42,\t[43]=@43,\t[44]=@44,\t[45]=@45,\t[46]=@46,\t[47]=@47,\t[48]=@48,\t[49]=@49,\t[50]=@50,\t[51]=@51,\t[52]=@52,\t[53]=@53,\t[54]=@54,\t[55]=@55,\t[56]=@56,\t[57]=@57,\t[58]=@58,\t[59]=@59,\t[60]=@60,\t[61]=@61,\t[62]=@62,\t[63]=@63,\t[64]=@64,\t[65]=@65,\t[66]=@66,\t[67]=@67,\t[68]=@68,\t[69]=@69,\t[70]=@70,\t[71]=@71,\t[72]=@72   WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@1", s1.Text);
		cmd.Parameters.AddWithValue("@2", s2.Text);
		cmd.Parameters.AddWithValue("@3", s3.Text);
		cmd.Parameters.AddWithValue("@4", s4.Text);
		cmd.Parameters.AddWithValue("@5", s5.Text);
		cmd.Parameters.AddWithValue("@6", s6.Text);
		cmd.Parameters.AddWithValue("@7", s7.Text);
		cmd.Parameters.AddWithValue("@8", s8.Text);
		cmd.Parameters.AddWithValue("@9", s9.Text);
		cmd.Parameters.AddWithValue("@10", s10.Text);
		cmd.Parameters.AddWithValue("@11", s11.Text);
		cmd.Parameters.AddWithValue("@12", s12.Text);
		cmd.Parameters.AddWithValue("@13", s13.Text);
		cmd.Parameters.AddWithValue("@14", s14.Text);
		cmd.Parameters.AddWithValue("@15", s15.Text);
		cmd.Parameters.AddWithValue("@16", s16.Text);
		cmd.Parameters.AddWithValue("@17", s17.Text);
		cmd.Parameters.AddWithValue("@18", s18.Text);
		cmd.Parameters.AddWithValue("@19", s19.Text);
		cmd.Parameters.AddWithValue("@20", s20.Text);
		cmd.Parameters.AddWithValue("@21", s21.Text);
		cmd.Parameters.AddWithValue("@22", s22.Text);
		cmd.Parameters.AddWithValue("@23", s23.Text);
		cmd.Parameters.AddWithValue("@24", s24.Text);
		cmd.Parameters.AddWithValue("@25", s25.Text);
		cmd.Parameters.AddWithValue("@26", s26.Text);
		cmd.Parameters.AddWithValue("@27", s27.Text);
		cmd.Parameters.AddWithValue("@28", s28.Text);
		cmd.Parameters.AddWithValue("@29", s29.Text);
		cmd.Parameters.AddWithValue("@30", s30.Text);
		cmd.Parameters.AddWithValue("@31", s31.Text);
		cmd.Parameters.AddWithValue("@32", s32.Text);
		cmd.Parameters.AddWithValue("@33", s33.Text);
		cmd.Parameters.AddWithValue("@34", s34.Text);
		cmd.Parameters.AddWithValue("@35", s35.Text);
		cmd.Parameters.AddWithValue("@36", s36.Text);
		cmd.Parameters.AddWithValue("@37", s37.Text);
		cmd.Parameters.AddWithValue("@38", s38.Text);
		cmd.Parameters.AddWithValue("@39", s39.Text);
		cmd.Parameters.AddWithValue("@40", s40.Text);
		cmd.Parameters.AddWithValue("@41", s41.Text);
		cmd.Parameters.AddWithValue("@42", s42.Text);
		cmd.Parameters.AddWithValue("@43", s43.Text);
		cmd.Parameters.AddWithValue("@44", s44.Text);
		cmd.Parameters.AddWithValue("@45", s45.Text);
		cmd.Parameters.AddWithValue("@46", s46.Text);
		cmd.Parameters.AddWithValue("@47", s47.Text);
		cmd.Parameters.AddWithValue("@48", s48.Text);
		cmd.Parameters.AddWithValue("@49", s49.Text);
		cmd.Parameters.AddWithValue("@50", s50.Text);
		cmd.Parameters.AddWithValue("@51", s51.Text);
		cmd.Parameters.AddWithValue("@52", s52.Text);
		cmd.Parameters.AddWithValue("@53", s53.Text);
		cmd.Parameters.AddWithValue("@54", s54.Text);
		cmd.Parameters.AddWithValue("@55", s55.Text);
		cmd.Parameters.AddWithValue("@56", s56.Text);
		cmd.Parameters.AddWithValue("@57", s57.Text);
		cmd.Parameters.AddWithValue("@58", s58.Text);
		cmd.Parameters.AddWithValue("@59", s59.Text);
		cmd.Parameters.AddWithValue("@60", s60.Text);
		cmd.Parameters.AddWithValue("@61", s61.Text);
		cmd.Parameters.AddWithValue("@62", s62.Text);
		cmd.Parameters.AddWithValue("@63", s63.Text);
		cmd.Parameters.AddWithValue("@64", s64.Text);
		cmd.Parameters.AddWithValue("@65", s65.Text);
		cmd.Parameters.AddWithValue("@66", s66.Text);
		cmd.Parameters.AddWithValue("@67", s67.Text);
		cmd.Parameters.AddWithValue("@68", s68.Text);
		cmd.Parameters.AddWithValue("@69", s69.Text);
		cmd.Parameters.AddWithValue("@70", s70.Text);
		cmd.Parameters.AddWithValue("@71", s71.Text);
		cmd.Parameters.AddWithValue("@72", s72.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		MessageBox.Show("تازةكرايةوة ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void btnadd_Click(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty || comwestga.Text == string.Empty || txtnawbnka.Text == string.Empty || txtcoodtasj.Text == string.Empty)
		{
			MessageBox.Show("تکایە خانەکان بە دروستی پربکەوە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (txt_total_s.Text == "0")
		{
			MessageBox.Show("تکایە دەنگەکان تۆماربکەن", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (btnadd.Text == "تۆمارکردن")
		{
			DataTable bm = new DataTable();
			bm = log.get_hazb_s(int.Parse(txtbnkacood.Text), int.Parse(comwestga.Text));
			if (bm.Rows.Count > 0)
			{
				MessageBox.Show(" تۆمار کراوە تکایە بیگۆڕە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			insert_s();
			insert_cabdid();
		}
		else if (btnadd.Text == "Update")
		{
			Update_s();
			Update_cabdid();
		}
	}

	private void comwestga_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty)
		{
			MessageBox.Show("تکایە ژمارەی بنکەی دەنگدان بنوسە ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		string query1 = "SELECT *\r\n                         FROM candid_s\r\n                         WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		string query = "SELECT *\r\n                         FROM slemany_hazb\r\n                         WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand command = new SqlCommand(query, connectionString);
		SqlCommand command1 = new SqlCommand(query1, connectionString);
		connectionString.Open();
		using (SqlDataReader reader = command.ExecuteReader())
		{
			if (reader.Read())
			{
				txtwaraqadrost.Text = reader["waraqa_rast"].ToString();
				txtwaraqaybatl.Text = reader["waraqapochal"].ToString();
				s101s.Text = reader["101"].ToString();
				s104s.Text = reader["104"].ToString();
				s110s.Text = reader["110"].ToString();
				s113s.Text = reader["113"].ToString();
				s114s.Text = reader["114"].ToString();
				s115s.Text = reader["115"].ToString();
				s116s.Text = reader["116"].ToString();
				s117s.Text = reader["117"].ToString();
				s119s.Text = reader["119"].ToString();
				s121s.Text = reader["121"].ToString();
				s122s.Text = reader["122"].ToString();
				s123s.Text = reader["123"].ToString();
				s124s.Text = reader["124"].ToString();
				s125s.Text = reader["125"].ToString();
				s128s.Text = reader["128"].ToString();
				s129s.Text = reader["129"].ToString();
				s130s.Text = reader["130"].ToString();
				s133s.Text = reader["133"].ToString();
				s135s.Text = reader["135"].ToString();
				s136s.Text = reader["136"].ToString();
				s137s.Text = reader["137"].ToString();
				s138s.Text = reader["138"].ToString();
				s145s.Text = reader["145"].ToString();
				s147s.Text = reader["147"].ToString();
				s148s.Text = reader["148"].ToString();
				s153s.Text = reader["153"].ToString();
				s157s.Text = reader["157"].ToString();
				s161s.Text = reader["161"].ToString();
				s162s.Text = reader["162"].ToString();
				s164s.Text = reader["164"].ToString();
				s165s.Text = reader["165"].ToString();
				s166s.Text = reader["166"].ToString();
				s168s.Text = reader["168"].ToString();
				s169s.Text = reader["169"].ToString();
				s171s.Text = reader["171"].ToString();
				s174s.Text = reader["174"].ToString();
				s180s.Text = reader["180"].ToString();
				s182s.Text = reader["182"].ToString();
				s183s.Text = reader["183"].ToString();
				s185s.Text = reader["185"].ToString();
				s190s.Text = reader["190"].ToString();
				s192s.Text = reader["192"].ToString();
				s193s.Text = reader["193"].ToString();
				s194s.Text = reader["194"].ToString();
				s198s.Text = reader["198"].ToString();
				s201s.Text = reader["201"].ToString();
				s207s.Text = reader["207"].ToString();
				s218s.Text = reader["218"].ToString();
				s221s.Text = reader["221"].ToString();
				s226s.Text = reader["226"].ToString();
				s228s.Text = reader["228"].ToString();
				s230s.Text = reader["230"].ToString();
				s231s.Text = reader["231"].ToString();
				s236s.Text = reader["236"].ToString();
				btnadd.Text = "Update";
				txtcoler();
			}
			else
			{
				all_txt0();
				txtcoler();
				btnadd.Text = "تۆمارکردن";
			}
		}
		using (SqlDataReader reader1 = command1.ExecuteReader())
		{
			if (reader1.Read())
			{
				s1.Text = reader1["1"].ToString();
				s2.Text = reader1["2"].ToString();
				s3.Text = reader1["3"].ToString();
				s4.Text = reader1["4"].ToString();
				s5.Text = reader1["5"].ToString();
				s6.Text = reader1["6"].ToString();
				s7.Text = reader1["7"].ToString();
				s8.Text = reader1["8"].ToString();
				s9.Text = reader1["9"].ToString();
				s10.Text = reader1["10"].ToString();
				s11.Text = reader1["11"].ToString();
				s12.Text = reader1["12"].ToString();
				s13.Text = reader1["13"].ToString();
				s14.Text = reader1["14"].ToString();
				s15.Text = reader1["15"].ToString();
				s16.Text = reader1["16"].ToString();
				s17.Text = reader1["17"].ToString();
				s18.Text = reader1["18"].ToString();
				s19.Text = reader1["19"].ToString();
				s20.Text = reader1["20"].ToString();
				s21.Text = reader1["21"].ToString();
				s22.Text = reader1["22"].ToString();
				s23.Text = reader1["23"].ToString();
				s24.Text = reader1["24"].ToString();
				s25.Text = reader1["25"].ToString();
				s26.Text = reader1["26"].ToString();
				s27.Text = reader1["27"].ToString();
				s28.Text = reader1["28"].ToString();
				s29.Text = reader1["29"].ToString();
				s30.Text = reader1["30"].ToString();
				s31.Text = reader1["31"].ToString();
				s32.Text = reader1["32"].ToString();
				s33.Text = reader1["33"].ToString();
				s34.Text = reader1["34"].ToString();
				s35.Text = reader1["35"].ToString();
				s36.Text = reader1["36"].ToString();
				s37.Text = reader1["37"].ToString();
				s38.Text = reader1["38"].ToString();
				s39.Text = reader1["39"].ToString();
				s40.Text = reader1["40"].ToString();
				s41.Text = reader1["41"].ToString();
				s42.Text = reader1["42"].ToString();
				s43.Text = reader1["43"].ToString();
				s44.Text = reader1["44"].ToString();
				s45.Text = reader1["45"].ToString();
				s46.Text = reader1["46"].ToString();
				s47.Text = reader1["47"].ToString();
				s48.Text = reader1["48"].ToString();
				s49.Text = reader1["49"].ToString();
				s50.Text = reader1["50"].ToString();
				s51.Text = reader1["51"].ToString();
				s52.Text = reader1["52"].ToString();
				s53.Text = reader1["53"].ToString();
				s54.Text = reader1["54"].ToString();
				s55.Text = reader1["55"].ToString();
				s56.Text = reader1["56"].ToString();
				s57.Text = reader1["57"].ToString();
				s58.Text = reader1["58"].ToString();
				s59.Text = reader1["59"].ToString();
				s60.Text = reader1["60"].ToString();
				s61.Text = reader1["61"].ToString();
				s62.Text = reader1["62"].ToString();
				s63.Text = reader1["63"].ToString();
				s64.Text = reader1["64"].ToString();
				s65.Text = reader1["65"].ToString();
				s66.Text = reader1["66"].ToString();
				s67.Text = reader1["67"].ToString();
				s68.Text = reader1["68"].ToString();
				s69.Text = reader1["69"].ToString();
				s70.Text = reader1["70"].ToString();
				s71.Text = reader1["71"].ToString();
				s72.Text = reader1["72"].ToString();
			}
		}
		txtcoler();
		connectionString.Close();
	}

	private void insert_cabdid()
	{
		string qurey = "insert into candid_s(naw_mahafaza,cood_tasjil,cood_bnka,jor_dangdan,\twestga,[1]\t,[2]\t,[3]\t,[4]\t,[5]\t,[6]\t,[7]\t,[8]\t,[9]\t,[10]\t,[11]\t,[12]\t,[13]\t,[14]\t,[15]\t,[16]\t,[17]\t,[18]\t,[19]\t,[20]\t,[21]\t,[22]\t,[23]\t,[24]\t,[25]\t,[26]\t,[27]\t,[28]\t,[29]\t,[30]\t,[31]\t,[32]\t,[33]\t,[34]\t,[35]\t,[36]\t,[37]\t,[38]\t,[39]\t,[40]\t,[41]\t,[42]\t,[43]\t,[44]\t,[45]\t,[46]\t,[47]\t,[48]\t,[49]\t,[50]\t,[51]\t,[52]\t,[53]\t,[54]\t,[55]\t,[56]\t,[57]\t,[58]\t,[59]\t,[60]\t,[61]\t,[62]\t,[63]\t,[64]\t,[65]\t,[66]\t,[67]\t,[68]\t,[69]\t,[70]\t,[71]\t,[72])VALUES (@naw_mahafaza,\t@cood_tasjil,\t@cood_bnka,@jor_dangdan,\t@westga,@1,@2,\t@3,\t@4,\t@5,\t@6,\t@7,\t@8,\t@9,\t@10,\t@11,\t@12,\t@13,\t@14,\t@15,\t@16,\t@17,\t@18,\t@19,\t@20,\t@21,\t@22,\t@23,\t@24,\t@25,\t@26,\t@27,\t@28,\t@29,\t@30,\t@31,\t@32,\t@33,\t@34,\t@35,\t@36,\t@37,\t@38,\t@39,\t@40,\t@41,\t@42,\t@43,\t@44,\t@45,\t@46,\t@47,\t@48,\t@49,\t@50,\t@51,\t@52,\t@53,\t@54,\t@55,\t@56,\t@57,\t@58,\t@59,\t@60,\t@61,\t@62,\t@63,\t@64,\t@65,\t@66,\t@67,\t@68,\t@69,\t@70,\t@71,\t@72)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@jor_dangdan", labljorydangdan.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@1", s1.Text);
		cmd.Parameters.AddWithValue("@2", s2.Text);
		cmd.Parameters.AddWithValue("@3", s3.Text);
		cmd.Parameters.AddWithValue("@4", s4.Text);
		cmd.Parameters.AddWithValue("@5", s5.Text);
		cmd.Parameters.AddWithValue("@6", s6.Text);
		cmd.Parameters.AddWithValue("@7", s7.Text);
		cmd.Parameters.AddWithValue("@8", s8.Text);
		cmd.Parameters.AddWithValue("@9", s9.Text);
		cmd.Parameters.AddWithValue("@10", s10.Text);
		cmd.Parameters.AddWithValue("@11", s11.Text);
		cmd.Parameters.AddWithValue("@12", s12.Text);
		cmd.Parameters.AddWithValue("@13", s13.Text);
		cmd.Parameters.AddWithValue("@14", s14.Text);
		cmd.Parameters.AddWithValue("@15", s15.Text);
		cmd.Parameters.AddWithValue("@16", s16.Text);
		cmd.Parameters.AddWithValue("@17", s17.Text);
		cmd.Parameters.AddWithValue("@18", s18.Text);
		cmd.Parameters.AddWithValue("@19", s19.Text);
		cmd.Parameters.AddWithValue("@20", s20.Text);
		cmd.Parameters.AddWithValue("@21", s21.Text);
		cmd.Parameters.AddWithValue("@22", s22.Text);
		cmd.Parameters.AddWithValue("@23", s23.Text);
		cmd.Parameters.AddWithValue("@24", s24.Text);
		cmd.Parameters.AddWithValue("@25", s25.Text);
		cmd.Parameters.AddWithValue("@26", s26.Text);
		cmd.Parameters.AddWithValue("@27", s27.Text);
		cmd.Parameters.AddWithValue("@28", s28.Text);
		cmd.Parameters.AddWithValue("@29", s29.Text);
		cmd.Parameters.AddWithValue("@30", s30.Text);
		cmd.Parameters.AddWithValue("@31", s31.Text);
		cmd.Parameters.AddWithValue("@32", s32.Text);
		cmd.Parameters.AddWithValue("@33", s33.Text);
		cmd.Parameters.AddWithValue("@34", s34.Text);
		cmd.Parameters.AddWithValue("@35", s35.Text);
		cmd.Parameters.AddWithValue("@36", s36.Text);
		cmd.Parameters.AddWithValue("@37", s37.Text);
		cmd.Parameters.AddWithValue("@38", s38.Text);
		cmd.Parameters.AddWithValue("@39", s39.Text);
		cmd.Parameters.AddWithValue("@40", s40.Text);
		cmd.Parameters.AddWithValue("@41", s41.Text);
		cmd.Parameters.AddWithValue("@42", s42.Text);
		cmd.Parameters.AddWithValue("@43", s43.Text);
		cmd.Parameters.AddWithValue("@44", s44.Text);
		cmd.Parameters.AddWithValue("@45", s45.Text);
		cmd.Parameters.AddWithValue("@46", s46.Text);
		cmd.Parameters.AddWithValue("@47", s47.Text);
		cmd.Parameters.AddWithValue("@48", s48.Text);
		cmd.Parameters.AddWithValue("@49", s49.Text);
		cmd.Parameters.AddWithValue("@50", s50.Text);
		cmd.Parameters.AddWithValue("@51", s51.Text);
		cmd.Parameters.AddWithValue("@52", s52.Text);
		cmd.Parameters.AddWithValue("@53", s53.Text);
		cmd.Parameters.AddWithValue("@54", s54.Text);
		cmd.Parameters.AddWithValue("@55", s55.Text);
		cmd.Parameters.AddWithValue("@56", s56.Text);
		cmd.Parameters.AddWithValue("@57", s57.Text);
		cmd.Parameters.AddWithValue("@58", s58.Text);
		cmd.Parameters.AddWithValue("@59", s59.Text);
		cmd.Parameters.AddWithValue("@60", s60.Text);
		cmd.Parameters.AddWithValue("@61", s61.Text);
		cmd.Parameters.AddWithValue("@62", s62.Text);
		cmd.Parameters.AddWithValue("@63", s63.Text);
		cmd.Parameters.AddWithValue("@64", s64.Text);
		cmd.Parameters.AddWithValue("@65", s65.Text);
		cmd.Parameters.AddWithValue("@66", s66.Text);
		cmd.Parameters.AddWithValue("@67", s67.Text);
		cmd.Parameters.AddWithValue("@68", s68.Text);
		cmd.Parameters.AddWithValue("@69", s69.Text);
		cmd.Parameters.AddWithValue("@70", s70.Text);
		cmd.Parameters.AddWithValue("@71", s71.Text);
		cmd.Parameters.AddWithValue("@72", s72.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		MessageBox.Show("تۆمارکرا ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void txtcoler()
	{
		List<TextBox> textBoxes = new List<TextBox>
		{
			s101s, s104s, s110s, s113s, s114s, s115s, s116s, s117s, s119s, s121s,
			s122s, s123s, s124s, s125s, s128s, s129s, s130s, s133s, s135s, s136s,
			s137s, s138s, s145s, s147s, s148s, s153s, s157s, s161s, s162s, s164s,
			s165s, s166s, s168s, s169s, s171s, s174s, s180s, s182s, s183s, s185s,
			s190s, s192s, s193s, s194s, s198s, s201s, s207s, s218s, s221s, s226s,
			s228s, s230s, s231s, s236s, s1, s2, s3, s4, s5, s6,
			s7, s8, s9, s10, s11, s12, s13, s14, s15, s16,
			s17, s18, s19, s20, s21, s22, s23, s24, s25, s26,
			s27, s28, s29, s30, s31, s32, s33, s34, s35, s36,
			s37, s38, s39, s40, s41, s42, s43, s44, s45, s46,
			s47, s48, s49, s50, s51, s52, s53, s54, s55, s56,
			s57, s58, s59, s60, s61, s62, s63, s64, s65, s66,
			s67, s68, s69, s70, s71, s72
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
		s1.Text = "0";
		s2.Text = "0";
		s3.Text = "0";
		s4.Text = "0";
		s5.Text = "0";
		s6.Text = "0";
		s7.Text = "0";
		s8.Text = "0";
		s9.Text = "0";
		s10.Text = "0";
		s11.Text = "0";
		s12.Text = "0";
		s13.Text = "0";
		s14.Text = "0";
		s15.Text = "0";
		s16.Text = "0";
		s17.Text = "0";
		s18.Text = "0";
		s19.Text = "0";
		s20.Text = "0";
		s21.Text = "0";
		s22.Text = "0";
		s23.Text = "0";
		s24.Text = "0";
		s25.Text = "0";
		s26.Text = "0";
		s27.Text = "0";
		s28.Text = "0";
		s29.Text = "0";
		s30.Text = "0";
		s31.Text = "0";
		s32.Text = "0";
		s33.Text = "0";
		s34.Text = "0";
		s35.Text = "0";
		s36.Text = "0";
		s37.Text = "0";
		s38.Text = "0";
		s39.Text = "0";
		s40.Text = "0";
		s41.Text = "0";
		s42.Text = "0";
		s43.Text = "0";
		s44.Text = "0";
		s45.Text = "0";
		s46.Text = "0";
		s47.Text = "0";
		s48.Text = "0";
		s49.Text = "0";
		s50.Text = "0";
		s51.Text = "0";
		s52.Text = "0";
		s53.Text = "0";
		s54.Text = "0";
		s55.Text = "0";
		s56.Text = "0";
		s57.Text = "0";
		s58.Text = "0";
		s59.Text = "0";
		s60.Text = "0";
		s61.Text = "0";
		s62.Text = "0";
		s63.Text = "0";
		s64.Text = "0";
		s65.Text = "0";
		s66.Text = "0";
		s67.Text = "0";
		s68.Text = "0";
		s69.Text = "0";
		s70.Text = "0";
		s71.Text = "0";
		s72.Text = "0";
		s101s.Text = "0";
		s104s.Text = "0";
		s110s.Text = "0";
		s113s.Text = "0";
		s114s.Text = "0";
		s115s.Text = "0";
		s116s.Text = "0";
		s117s.Text = "0";
		s119s.Text = "0";
		s121s.Text = "0";
		s122s.Text = "0";
		s123s.Text = "0";
		s124s.Text = "0";
		s125s.Text = "0";
		s128s.Text = "0";
		s129s.Text = "0";
		s130s.Text = "0";
		s133s.Text = "0";
		s135s.Text = "0";
		s136s.Text = "0";
		s137s.Text = "0";
		s138s.Text = "0";
		s145s.Text = "0";
		s147s.Text = "0";
		s148s.Text = "0";
		s153s.Text = "0";
		s157s.Text = "0";
		s161s.Text = "0";
		s162s.Text = "0";
		s164s.Text = "0";
		s165s.Text = "0";
		s166s.Text = "0";
		s168s.Text = "0";
		s169s.Text = "0";
		s171s.Text = "0";
		s174s.Text = "0";
		s180s.Text = "0";
		s182s.Text = "0";
		s183s.Text = "0";
		s185s.Text = "0";
		s190s.Text = "0";
		s192s.Text = "0";
		s193s.Text = "0";
		s194s.Text = "0";
		s198s.Text = "0";
		s201s.Text = "0";
		s207s.Text = "0";
		s218s.Text = "0";
		s221s.Text = "0";
		s226s.Text = "0";
		s228s.Text = "0";
		s230s.Text = "0";
		s231s.Text = "0";
		s236s.Text = "0";
	}

	private void insert_s()
	{
		Home ho = new Home();
		string qurey = "insert into slemany_hazb(naw_mahafaza,\tmalband,\tcood_tasjil,\tnaw_tasjil,\tcood_bnka,\tnaw_bnka,\twestga_gshty,\tdangdar,\twestga,\twaraqa_rast,\twaraqapochal, [naw_karmand],[taime],[jor_dangdan],Device_name,srial_namber,[101],\t[104],\t[110],\t[113],\t[114],\t[115],\t[116],\t[117],\t[119],\t[121],\t[122],\t[123],\t[124],\t[125],\t[128],\t[129],\t[130],\t[133],\t[135],\t[136],\t[137],\t[138],\t[145],\t[147],\t[148],\t[153],\t[157],\t[161],\t[162],\t[164],\t[165],\t[166],\t[168],\t[169],\t[171],\t[174],\t[180],\t[182],\t[183],\t[185],\t[190],\t[192],\t[193],\t[194],\t[198],\t[201],\t[207],\t[218],\t[221],\t[226],\t[228],\t[230],\t[231],\t[236])VALUES (@naw_mahafaza,\t@malband,\t@cood_tasjil,\t@naw_tasjil,\t@cood_bnka,\t@naw_bnka,\t@westga_gshty,\t@dangdar,\t@westga,\t@waraqa_rast,\t@waraqapochal,@naw_karmand,@taime,@jor_dangdan,@Device_name,@srial_namber,@s101,\t@s104, \t@s110, \t@s113, \t@s114, \t@s115, \t@s116, \t@s117, \t@s119, \t@s121, \t@s122, \t@s123, \t@s124, \t@s125, \t@s128, \t@s129, \t@s130, \t@s133, \t@s135, \t@s136, \t@s137, \t@s138, \t@s145, \t@s147, \t@s148, \t@s153, \t@s157, \t@s161, \t@s162, \t@s164, \t@s165, \t@s166, \t@s168, \t@s169, \t@s171, \t@s174, \t@s180, \t@s182, \t@s183, \t@s185, \t@s190, \t@s192, \t@s193, \t@s194, \t@s198, \t@s201, \t@s207, \t@s218, \t@s221, \t@s226, \t@s228, \t@s230, \t@s231, \t@s236)";
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
		cmd.Parameters.AddWithValue("@s101", s101s.Text);
		cmd.Parameters.AddWithValue("@s104", s104s.Text);
		cmd.Parameters.AddWithValue("@s110", s110s.Text);
		cmd.Parameters.AddWithValue("@s113", s113s.Text);
		cmd.Parameters.AddWithValue("@s114", s114s.Text);
		cmd.Parameters.AddWithValue("@s115", s115s.Text);
		cmd.Parameters.AddWithValue("@s116", s116s.Text);
		cmd.Parameters.AddWithValue("@s117", s117s.Text);
		cmd.Parameters.AddWithValue("@s119", s119s.Text);
		cmd.Parameters.AddWithValue("@s121", s121s.Text);
		cmd.Parameters.AddWithValue("@s122", s122s.Text);
		cmd.Parameters.AddWithValue("@s123", s123s.Text);
		cmd.Parameters.AddWithValue("@s124", s124s.Text);
		cmd.Parameters.AddWithValue("@s125", s125s.Text);
		cmd.Parameters.AddWithValue("@s128", s128s.Text);
		cmd.Parameters.AddWithValue("@s129", s129s.Text);
		cmd.Parameters.AddWithValue("@s130", s130s.Text);
		cmd.Parameters.AddWithValue("@s133", s133s.Text);
		cmd.Parameters.AddWithValue("@s135", s135s.Text);
		cmd.Parameters.AddWithValue("@s136", s136s.Text);
		cmd.Parameters.AddWithValue("@s137", s137s.Text);
		cmd.Parameters.AddWithValue("@s138", s138s.Text);
		cmd.Parameters.AddWithValue("@s145", s145s.Text);
		cmd.Parameters.AddWithValue("@s147", s147s.Text);
		cmd.Parameters.AddWithValue("@s148", s148s.Text);
		cmd.Parameters.AddWithValue("@s153", s153s.Text);
		cmd.Parameters.AddWithValue("@s157", s157s.Text);
		cmd.Parameters.AddWithValue("@s161", s161s.Text);
		cmd.Parameters.AddWithValue("@s162", s162s.Text);
		cmd.Parameters.AddWithValue("@s164", s164s.Text);
		cmd.Parameters.AddWithValue("@s165", s165s.Text);
		cmd.Parameters.AddWithValue("@s166", s166s.Text);
		cmd.Parameters.AddWithValue("@s168", s168s.Text);
		cmd.Parameters.AddWithValue("@s169", s169s.Text);
		cmd.Parameters.AddWithValue("@s171", s171s.Text);
		cmd.Parameters.AddWithValue("@s174", s174s.Text);
		cmd.Parameters.AddWithValue("@s180", s180s.Text);
		cmd.Parameters.AddWithValue("@s182", s182s.Text);
		cmd.Parameters.AddWithValue("@s183", s183s.Text);
		cmd.Parameters.AddWithValue("@s185", s185s.Text);
		cmd.Parameters.AddWithValue("@s190", s190s.Text);
		cmd.Parameters.AddWithValue("@s192", s192s.Text);
		cmd.Parameters.AddWithValue("@s193", s193s.Text);
		cmd.Parameters.AddWithValue("@s194", s194s.Text);
		cmd.Parameters.AddWithValue("@s198", s198s.Text);
		cmd.Parameters.AddWithValue("@s201", s201s.Text);
		cmd.Parameters.AddWithValue("@s207", s207s.Text);
		cmd.Parameters.AddWithValue("@s218", s218s.Text);
		cmd.Parameters.AddWithValue("@s221", s221s.Text);
		cmd.Parameters.AddWithValue("@s226", s226s.Text);
		cmd.Parameters.AddWithValue("@s228", s228s.Text);
		cmd.Parameters.AddWithValue("@s230", s230s.Text);
		cmd.Parameters.AddWithValue("@s231", s231s.Text);
		cmd.Parameters.AddWithValue("@s236", s236s.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		MessageBox.Show("تۆمار کرا ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void h102_Click(object sender, EventArgs e)
	{
		s101s.Text = "";
	}

	private void h103_Click(object sender, EventArgs e)
	{
		s104s.Text = "";
	}

	private void h105_Click(object sender, EventArgs e)
	{
		s110s.Text = "";
	}

	private void h106_Click(object sender, EventArgs e)
	{
		s113s.Text = "";
	}

	private void h109_Click(object sender, EventArgs e)
	{
		s114s.Text = "";
	}

	private void h111_Click(object sender, EventArgs e)
	{
		s115s.Text = "";
	}

	private void h112_Click(object sender, EventArgs e)
	{
		s116s.Text = "";
	}

	private void h114_Click(object sender, EventArgs e)
	{
	}

	private void h120_Click(object sender, EventArgs e)
	{
		s117s.Text = "";
	}

	private void h123_Click(object sender, EventArgs e)
	{
		s119s.Text = "";
	}

	private void h129_Click(object sender, EventArgs e)
	{
		s121s.Text = "";
	}

	private void h131_Click(object sender, EventArgs e)
	{
		s122s.Text = "";
	}

	private void h133_Click(object sender, EventArgs e)
	{
		s123s.Text = "";
	}

	private void h139_Click(object sender, EventArgs e)
	{
		s124s.Text = "";
	}

	private void h144_Click(object sender, EventArgs e)
	{
		s125s.Text = "";
	}

	private void h146_Click(object sender, EventArgs e)
	{
		s128s.Text = "";
	}

	private void h147_Click(object sender, EventArgs e)
	{
		s129s.Text = "";
	}

	private void h148_Click(object sender, EventArgs e)
	{
		s130s.Text = "";
	}

	private void h149_Click(object sender, EventArgs e)
	{
		s133s.Text = "";
	}

	private void h150_Click(object sender, EventArgs e)
	{
		s135s.Text = "";
	}

	private void h151_Click(object sender, EventArgs e)
	{
		s136s.Text = "";
	}

	private void h154_Click(object sender, EventArgs e)
	{
		s137s.Text = "";
	}

	private void h156_Click(object sender, EventArgs e)
	{
		s138s.Text = "";
	}

	private void h157_Click(object sender, EventArgs e)
	{
		s145s.Text = "";
	}

	private void h158_Click(object sender, EventArgs e)
	{
		s147s.Text = "";
	}

	private void h160_Click(object sender, EventArgs e)
	{
		s148s.Text = "";
	}

	private void h161_Click(object sender, EventArgs e)
	{
		s153s.Text = "";
	}

	private void h162_Click(object sender, EventArgs e)
	{
		s157s.Text = "";
	}

	private void h164_Click(object sender, EventArgs e)
	{
		s161s.Text = "";
	}

	private void h167_Click(object sender, EventArgs e)
	{
		s162s.Text = "";
	}

	private void h169_Click(object sender, EventArgs e)
	{
		s164s.Text = "";
	}

	private void h170_Click(object sender, EventArgs e)
	{
		s165s.Text = "";
	}

	private void h173_Click(object sender, EventArgs e)
	{
		s174s.Text = "";
	}

	private void h176_Click(object sender, EventArgs e)
	{
		s180s.Text = "";
	}

	private void h178_Click(object sender, EventArgs e)
	{
		s182s.Text = "";
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
		s236s.Text = "";
	}

	private void h208_Click(object sender, EventArgs e)
	{
		s231s.Text = "";
	}

	private void h206_Click(object sender, EventArgs e)
	{
		s230s.Text = "";
	}

	private void h205_Click(object sender, EventArgs e)
	{
		s228s.Text = "";
	}

	private void h204_Click(object sender, EventArgs e)
	{
		s226s.Text = "";
	}

	private void h203_Click(object sender, EventArgs e)
	{
		s221s.Text = "";
	}

	private void h202_Click(object sender, EventArgs e)
	{
		s218s.Text = "";
	}

	private void h199_Click(object sender, EventArgs e)
	{
		s207s.Text = "";
	}

	private void h198_Click(object sender, EventArgs e)
	{
		s201s.Text = "";
	}

	private void h191_Click(object sender, EventArgs e)
	{
		s198s.Text = "";
	}

	private void h190_Click(object sender, EventArgs e)
	{
		s194s.Text = "";
	}

	private void h189_Click(object sender, EventArgs e)
	{
		s193s.Text = "";
	}

	private void h187_Click(object sender, EventArgs e)
	{
		s192s.Text = "";
	}

	private void h184_Click(object sender, EventArgs e)
	{
		s190s.Text = "";
	}

	private void s117_Click(object sender, EventArgs e)
	{
		s72.Text = "";
	}

	private void s119_Click(object sender, EventArgs e)
	{
		s34.Text = "";
	}

	private void s121_Click(object sender, EventArgs e)
	{
		s35.Text = "";
	}

	private void s122_Click(object sender, EventArgs e)
	{
		s70.Text = "";
	}

	private void s174_Click(object sender, EventArgs e)
	{
		s68.Text = "";
	}

	private void s180_Click(object sender, EventArgs e)
	{
		s33.Text = "";
	}

	private void s182_Click(object sender, EventArgs e)
	{
		s67.Text = "";
	}

	private void s183_Click(object sender, EventArgs e)
	{
		s71.Text = "";
	}

	private void s185_Click(object sender, EventArgs e)
	{
		s69.Text = "";
	}

	private void s190_Click(object sender, EventArgs e)
	{
		s26.Text = "";
	}

	private void s192_Click(object sender, EventArgs e)
	{
		s28.Text = "";
	}

	private void s193_Click(object sender, EventArgs e)
	{
		s61.Text = "";
	}

	private void s194_Click(object sender, EventArgs e)
	{
		s63.Text = "";
	}

	private void s198_Click(object sender, EventArgs e)
	{
		s171s.Text = "";
	}

	private void s201_Click(object sender, EventArgs e)
	{
		s57.Text = "";
	}

	private void s123_Click(object sender, EventArgs e)
	{
		s32.Text = "";
	}

	private void s128_Click(object sender, EventArgs e)
	{
		s62.Text = "";
	}

	private void s129_Click(object sender, EventArgs e)
	{
		s25.Text = "";
	}

	private void s130_Click(object sender, EventArgs e)
	{
	}

	private void s133_Click(object sender, EventArgs e)
	{
		s169s.Text = "";
	}

	private void s135_Click(object sender, EventArgs e)
	{
		s168s.Text = "";
	}

	private void s136_Click(object sender, EventArgs e)
	{
		s31.Text = "";
	}

	private void s137_Click(object sender, EventArgs e)
	{
		s166s.Text = "";
	}

	private void s207_Click(object sender, EventArgs e)
	{
		s207.Text = "";
	}

	private void s218_Click(object sender, EventArgs e)
	{
	}

	private void s221_Click(object sender, EventArgs e)
	{
		s221.Text = "";
	}

	private void s226_Click(object sender, EventArgs e)
	{
		s22.Text = "";
	}

	private void s228_Click(object sender, EventArgs e)
	{
		s66.Text = "";
	}

	private void s230_Click(object sender, EventArgs e)
	{
		s30.Text = "";
	}

	private void s231_Click(object sender, EventArgs e)
	{
		s29.Text = "";
	}

	private void s236_Click(object sender, EventArgs e)
	{
		s23.Text = "";
	}

	private void s138_Click(object sender, EventArgs e)
	{
		s65.Text = "";
	}

	private void s145_Click(object sender, EventArgs e)
	{
		s59.Text = "";
	}

	private void s147_Click(object sender, EventArgs e)
	{
		s58.Text = "";
	}

	private void s148_Click(object sender, EventArgs e)
	{
		s58.Text = "";
	}

	private void s153_Click(object sender, EventArgs e)
	{
		s64.Text = "";
	}

	private void s157_Click(object sender, EventArgs e)
	{
		s27.Text = "";
	}

	private void s161_Click(object sender, EventArgs e)
	{
		s60.Text = "";
	}

	private void s171_Click(object sender, EventArgs e)
	{
		s36.Text = "";
	}

	private void d107_Click(object sender, EventArgs e)
	{
		s1.Text = "";
	}

	private void d108_Click(object sender, EventArgs e)
	{
		s2.Text = "";
	}

	private void d114_Click(object sender, EventArgs e)
	{
		s3.Text = "";
	}

	private void d118_Click(object sender, EventArgs e)
	{
		s4.Text = "";
	}

	private void d126_Click(object sender, EventArgs e)
	{
		s5.Text = "";
	}

	private void d127_Click(object sender, EventArgs e)
	{
		s6.Text = "";
	}

	private void d129_Click(object sender, EventArgs e)
	{
		s7.Text = "";
	}

	private void d132_Click(object sender, EventArgs e)
	{
		s8.Text = "";
	}

	private void d133_Click(object sender, EventArgs e)
	{
		s9.Text = "";
	}

	private void d134_Click(object sender, EventArgs e)
	{
		s10.Text = "";
	}

	private void d140_Click(object sender, EventArgs e)
	{
		s11.Text = "";
	}

	private void d213_Click(object sender, EventArgs e)
	{
		s51.Text = "";
	}

	private void d222_Click(object sender, EventArgs e)
	{
		s52.Text = "";
	}

	private void d224_Click(object sender, EventArgs e)
	{
		s53.Text = "";
	}

	private void d225_Click(object sender, EventArgs e)
	{
		s54.Text = "";
	}

	private void d227_Click(object sender, EventArgs e)
	{
		s55.Text = "";
	}

	private void d232_Click(object sender, EventArgs e)
	{
		s56.Text = "";
	}

	private void d141_Click(object sender, EventArgs e)
	{
		s12.Text = "";
	}

	private void d142_Click(object sender, EventArgs e)
	{
		s13.Text = "";
	}

	private void d143_Click(object sender, EventArgs e)
	{
		s14.Text = "";
	}

	private void d147_Click(object sender, EventArgs e)
	{
		s15.Text = "";
	}

	private void d148_Click(object sender, EventArgs e)
	{
		s16.Text = "";
	}

	private void d152_Click(object sender, EventArgs e)
	{
		s17.Text = "";
	}

	private void d155_Click(object sender, EventArgs e)
	{
		s18.Text = "";
	}

	private void d157_Click(object sender, EventArgs e)
	{
		s19.Text = "";
	}

	private void d159_Click(object sender, EventArgs e)
	{
		s20.Text = "";
	}

	private void d161_Click(object sender, EventArgs e)
	{
		s21.Text = "";
	}

	private void d162_Click(object sender, EventArgs e)
	{
		s37.Text = "";
	}

	private void d163_Click(object sender, EventArgs e)
	{
		s38.Text = "";
	}

	private void d164_Click(object sender, EventArgs e)
	{
		s39.Text = "";
	}

	private void d169_Click(object sender, EventArgs e)
	{
		s40.Text = "";
	}

	private void d175_Click(object sender, EventArgs e)
	{
		s41.Text = "";
	}

	private void d177_Click(object sender, EventArgs e)
	{
		s42.Text = "";
	}

	private void d186_Click(object sender, EventArgs e)
	{
		s43.Text = "";
	}

	private void d188_Click(object sender, EventArgs e)
	{
		s44.Text = "";
	}

	private void d190_Click(object sender, EventArgs e)
	{
		s45.Text = "";
	}

	private void d195_Click(object sender, EventArgs e)
	{
		s46.Text = "";
	}

	private void d196_Click(object sender, EventArgs e)
	{
		s47.Text = "";
	}

	private void d197_Click(object sender, EventArgs e)
	{
		s48.Text = "";
	}

	private void d200_Click(object sender, EventArgs e)
	{
		s49.Text = "";
	}

	private void d211_Click(object sender, EventArgs e)
	{
		s50.Text = "";
	}

	private void h102_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h103_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h105_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h106_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h109_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h111_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h112_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h114_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h120_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h123_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h129_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h131_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h133_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h139_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h144_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h146_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h147_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h148_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h149_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h150_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h151_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h154_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h156_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h157_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h158_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h160_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h161_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h162_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h164_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h167_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h169_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h170_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h173_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h176_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h178_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h179_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h181_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h184_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h187_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h189_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h190_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h191_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h198_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h199_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h202_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h203_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h204_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h205_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h206_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h208_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h209_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h210_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h212_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h214_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h215_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h216_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h217_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h219_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h220_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h223_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h229_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h233_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h234_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h235_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s101_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s104_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s110_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s113_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s174_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s180_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s182_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s183_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s114_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s185_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s115_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s190_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s116_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s192_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s117_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s193_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s119_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s194_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s121_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s198_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s122_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s201_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s123_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s207_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s124_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s218_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s125_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s221_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s128_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s226_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s129_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s228_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s130_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s230_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s133_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s231_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s135_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s236_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s136_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s137_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s138_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s145_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s147_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s148_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s153_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s157_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s161_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s162_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s164_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s165_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s166_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s168_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s169_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void s171_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d107_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d213_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d108_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d222_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d114_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d224_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d118_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d225_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d126_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d227_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d127_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d232_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl114_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl161_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl123_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl162_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl129_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl164_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl133_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl169_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl147_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl172_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl148_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl190_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl157_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void hl198_TextChanged(object sender, EventArgs e)
	{
	}

	private void d129_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d132_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d133_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d134_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d140_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d141_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d142_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d143_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d147_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d148_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d152_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d155_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d157_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d159_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d161_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d162_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d163_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d164_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d169_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d175_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d177_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d186_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d188_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d190_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d195_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d196_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d197_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d200_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void d211_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void h102_Leave(object sender, EventArgs e)
	{
		if (s101s.Text == string.Empty)
		{
			s101s.Text = "0";
		}
		if (s101s.Text == "0")
		{
			s101s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s101s.ForeColor = Color.Black;
		}
	}

	private void h103_Leave(object sender, EventArgs e)
	{
		if (s104s.Text == string.Empty)
		{
			s104s.Text = "0";
		}
		if (s104s.Text == "0")
		{
			s104s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s104s.ForeColor = Color.Black;
		}
	}

	private void h105_Leave(object sender, EventArgs e)
	{
		if (s110s.Text == string.Empty)
		{
			s110s.Text = "0";
		}
		if (s110s.Text == "0")
		{
			s110s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s110s.ForeColor = Color.Black;
		}
	}

	private void h106_Leave(object sender, EventArgs e)
	{
		if (s113s.Text == string.Empty)
		{
			s113s.Text = "0";
		}
		if (s113s.Text == "0")
		{
			s113s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s113s.ForeColor = Color.Black;
		}
	}

	private void h109_Leave(object sender, EventArgs e)
	{
		if (s114s.Text == string.Empty)
		{
			s114s.Text = "0";
		}
		if (s114s.Text == "0")
		{
			s114s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s114s.ForeColor = Color.Black;
		}
	}

	private void h111_Leave(object sender, EventArgs e)
	{
		if (s115s.Text == string.Empty)
		{
			s115s.Text = "0";
		}
		if (s115s.Text == "0")
		{
			s115s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s115s.ForeColor = Color.Black;
		}
	}

	private void h112_Leave(object sender, EventArgs e)
	{
		if (s116s.Text == string.Empty)
		{
			s116s.Text = "0";
		}
		if (s116s.Text == "0")
		{
			s116s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s116s.ForeColor = Color.Black;
		}
	}

	private void h114_Leave(object sender, EventArgs e)
	{
	}

	private void h120_Leave(object sender, EventArgs e)
	{
		if (s117s.Text == string.Empty)
		{
			s117s.Text = "0";
		}
		if (s117s.Text == "0")
		{
			s117s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s117s.ForeColor = Color.Black;
		}
	}

	private void h123_Leave(object sender, EventArgs e)
	{
		if (s119s.Text == string.Empty)
		{
			s119s.Text = "0";
		}
		if (s119s.Text == "0")
		{
			s119s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s119s.ForeColor = Color.Black;
		}
	}

	private void h179_Leave(object sender, EventArgs e)
	{
		if (s183s.Text == string.Empty)
		{
			s183s.Text = "0";
		}
		if (s183s.Text == "0")
		{
			s183s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s183s.ForeColor = Color.Black;
		}
	}

	private void h181_Leave(object sender, EventArgs e)
	{
		if (s185s.Text == string.Empty)
		{
			s185s.Text = "0";
		}
		if (s185s.Text == "0")
		{
			s185s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s185s.ForeColor = Color.Black;
		}
	}

	private void h184_Leave(object sender, EventArgs e)
	{
		if (s190s.Text == string.Empty)
		{
			s190s.Text = "0";
		}
		if (s190s.Text == "0")
		{
			s190s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s190s.ForeColor = Color.Black;
		}
	}

	private void h187_Leave(object sender, EventArgs e)
	{
		if (s192s.Text == string.Empty)
		{
			s192s.Text = "0";
		}
		if (s192s.Text == "0")
		{
			s192s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s192s.ForeColor = Color.Black;
		}
	}

	private void h189_Leave(object sender, EventArgs e)
	{
		if (s193s.Text == string.Empty)
		{
			s193s.Text = "0";
		}
		if (s193s.Text == "0")
		{
			s193s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s193s.ForeColor = Color.Black;
		}
	}

	private void h190_Leave(object sender, EventArgs e)
	{
		if (s194s.Text == string.Empty)
		{
			s194s.Text = "0";
		}
		if (s194s.Text == "0")
		{
			s194s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s194s.ForeColor = Color.Black;
		}
	}

	private void h191_Leave(object sender, EventArgs e)
	{
		if (s198s.Text == string.Empty)
		{
			s198s.Text = "0";
		}
		if (s198s.Text == "0")
		{
			s198s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s198s.ForeColor = Color.Black;
		}
	}

	private void h198_Leave(object sender, EventArgs e)
	{
		if (s201s.Text == string.Empty)
		{
			s201s.Text = "0";
		}
		if (s201s.Text == "0")
		{
			s201s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s201s.ForeColor = Color.Black;
		}
	}

	private void h199_Leave(object sender, EventArgs e)
	{
		if (s207s.Text == string.Empty)
		{
			s207s.Text = "0";
		}
		if (s207s.Text == "0")
		{
			s207s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s207s.ForeColor = Color.Black;
		}
	}

	private void h202_Leave(object sender, EventArgs e)
	{
		if (s218s.Text == string.Empty)
		{
			s218s.Text = "0";
		}
		if (s218s.Text == "0")
		{
			s218s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s218s.ForeColor = Color.Black;
		}
	}

	private void s174_Leave(object sender, EventArgs e)
	{
		if (s68.Text == string.Empty)
		{
			s68.Text = "0";
		}
		if (s68.Text == "0")
		{
			s68.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s68.ForeColor = Color.Black;
		}
	}

	private void s117_Leave(object sender, EventArgs e)
	{
		if (s72.Text == string.Empty)
		{
			s72.Text = "0";
		}
		if (s72.Text == "0")
		{
			s72.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s72.ForeColor = Color.Black;
		}
	}

	private void s119_Leave(object sender, EventArgs e)
	{
		if (s34.Text == string.Empty)
		{
			s34.Text = "0";
		}
		if (s34.Text == "0")
		{
			s34.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s34.ForeColor = Color.Black;
		}
	}

	private void s121_Leave(object sender, EventArgs e)
	{
		if (s35.Text == string.Empty)
		{
			s35.Text = "0";
		}
		if (s35.Text == "0")
		{
			s35.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s35.ForeColor = Color.Black;
		}
	}

	private void s180_Leave(object sender, EventArgs e)
	{
		if (s33.Text == string.Empty)
		{
			s33.Text = "0";
		}
		if (s33.Text == "0")
		{
			s33.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s33.ForeColor = Color.Black;
		}
	}

	private void s182_Leave(object sender, EventArgs e)
	{
		if (s67.Text == string.Empty)
		{
			s67.Text = "0";
		}
		if (s67.Text == "0")
		{
			s67.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s67.ForeColor = Color.Black;
		}
	}

	private void s183_Leave(object sender, EventArgs e)
	{
		if (s71.Text == string.Empty)
		{
			s71.Text = "0";
		}
		if (s71.Text == "0")
		{
			s71.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s71.ForeColor = Color.Black;
		}
	}

	private void s185_Leave(object sender, EventArgs e)
	{
		if (s69.Text == string.Empty)
		{
			s69.Text = "0";
		}
		if (s69.Text == "0")
		{
			s69.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s69.ForeColor = Color.Black;
		}
	}

	private void s190_Leave(object sender, EventArgs e)
	{
		if (s26.Text == string.Empty)
		{
			s26.Text = "0";
		}
		if (s26.Text == "0")
		{
			s26.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s26.ForeColor = Color.Black;
		}
	}

	private void s192_Leave(object sender, EventArgs e)
	{
		if (s28.Text == string.Empty)
		{
			s28.Text = "0";
		}
		if (s28.Text == "0")
		{
			s28.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s28.ForeColor = Color.Black;
		}
	}

	private void s193_Leave(object sender, EventArgs e)
	{
		if (s61.Text == string.Empty)
		{
			s61.Text = "0";
		}
		if (s61.Text == "0")
		{
			s61.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s61.ForeColor = Color.Black;
		}
	}

	private void s194_Leave(object sender, EventArgs e)
	{
		if (s101s.Text == string.Empty)
		{
			s63.Text = "0";
		}
		if (s63.Text == "0")
		{
			s63.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s63.ForeColor = Color.Black;
		}
	}

	private void s198_Leave(object sender, EventArgs e)
	{
		if (s171s.Text == string.Empty)
		{
			s171s.Text = "0";
		}
		if (s171s.Text == "0")
		{
			s171s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s171s.ForeColor = Color.Black;
		}
	}

	private void d107_Leave(object sender, EventArgs e)
	{
		if (s1.Text == string.Empty)
		{
			s1.Text = "0";
		}
		if (s1.Text == "0")
		{
			s1.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s1.ForeColor = Color.Black;
		}
	}

	private void d108_Leave(object sender, EventArgs e)
	{
		if (s2.Text == string.Empty)
		{
			s2.Text = "0";
		}
		if (s2.Text == "0")
		{
			s2.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s2.ForeColor = Color.Black;
		}
	}

	private void d114_Leave(object sender, EventArgs e)
	{
		if (s3.Text == string.Empty)
		{
			s3.Text = "0";
		}
		if (s3.Text == "0")
		{
			s3.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s3.ForeColor = Color.Black;
		}
	}

	private void d118_Leave(object sender, EventArgs e)
	{
		if (s4.Text == string.Empty)
		{
			s4.Text = "0";
		}
		if (s4.Text == "0")
		{
			s4.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s4.ForeColor = Color.Black;
		}
	}

	private void d126_Leave(object sender, EventArgs e)
	{
		if (s5.Text == string.Empty)
		{
			s5.Text = "0";
		}
		if (s5.Text == "0")
		{
			s5.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s5.ForeColor = Color.Black;
		}
	}

	private void d127_Leave(object sender, EventArgs e)
	{
		if (s6.Text == string.Empty)
		{
			s6.Text = "0";
		}
		if (s6.Text == "0")
		{
			s6.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s6.ForeColor = Color.Black;
		}
	}

	private void d129_Leave(object sender, EventArgs e)
	{
		if (s7.Text == string.Empty)
		{
			s7.Text = "0";
		}
		if (s7.Text == "0")
		{
			s7.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s7.ForeColor = Color.Black;
		}
	}

	private void d132_Leave(object sender, EventArgs e)
	{
		if (s8.Text == string.Empty)
		{
			s8.Text = "0";
		}
		if (s8.Text == "0")
		{
			s8.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s8.ForeColor = Color.Black;
		}
	}

	private void d133_Leave(object sender, EventArgs e)
	{
		if (s9.Text == string.Empty)
		{
			s9.Text = "0";
		}
		if (s9.Text == "0")
		{
			s9.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s9.ForeColor = Color.Black;
		}
	}

	private void d134_Leave(object sender, EventArgs e)
	{
		if (s10.Text == string.Empty)
		{
			s10.Text = "0";
		}
		if (s10.Text == "0")
		{
			s10.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s10.ForeColor = Color.Black;
		}
	}

	private void d213_Leave(object sender, EventArgs e)
	{
		if (s51.Text == string.Empty)
		{
			s51.Text = "0";
		}
		if (s51.Text == "0")
		{
			s51.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s51.ForeColor = Color.Black;
		}
	}

	private void d222_Leave(object sender, EventArgs e)
	{
		if (s52.Text == string.Empty)
		{
			s52.Text = "0";
		}
		if (s52.Text == "0")
		{
			s52.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s52.ForeColor = Color.Black;
		}
	}

	private void d224_Leave(object sender, EventArgs e)
	{
		if (s53.Text == string.Empty)
		{
			s53.Text = "0";
		}
		if (s53.Text == "0")
		{
			s53.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s53.ForeColor = Color.Black;
		}
	}

	private void d225_Leave(object sender, EventArgs e)
	{
		if (s54.Text == string.Empty)
		{
			s54.Text = "0";
		}
		if (s54.Text == "0")
		{
			s54.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s54.ForeColor = Color.Black;
		}
	}

	private void d227_Leave(object sender, EventArgs e)
	{
		if (s55.Text == string.Empty)
		{
			s55.Text = "0";
		}
		if (s55.Text == "0")
		{
			s55.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s55.ForeColor = Color.Black;
		}
	}

	private void d232_Leave(object sender, EventArgs e)
	{
		if (s56.Text == string.Empty)
		{
			s56.Text = "0";
		}
		if (s56.Text == "0")
		{
			s56.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s56.ForeColor = Color.Black;
		}
	}

	private void h129_Leave(object sender, EventArgs e)
	{
		if (s121s.Text == string.Empty)
		{
			s121s.Text = "0";
		}
		if (s121s.Text == "0")
		{
			s121s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s121s.ForeColor = Color.Black;
		}
	}

	private void h131_Leave(object sender, EventArgs e)
	{
		if (s122s.Text == string.Empty)
		{
			s122s.Text = "0";
		}
		if (s122s.Text == "0")
		{
			s122s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s122s.ForeColor = Color.Black;
		}
	}

	private void h133_Leave(object sender, EventArgs e)
	{
		if (s123s.Text == string.Empty)
		{
			s123s.Text = "0";
		}
		if (s123s.Text == "0")
		{
			s123s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s123s.ForeColor = Color.Black;
		}
	}

	private void h139_Leave(object sender, EventArgs e)
	{
		if (s124s.Text == string.Empty)
		{
			s124s.Text = "0";
		}
		if (s124s.Text == "0")
		{
			s124s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s124s.ForeColor = Color.Black;
		}
	}

	private void h144_Leave(object sender, EventArgs e)
	{
		if (s125s.Text == string.Empty)
		{
			s125s.Text = "0";
		}
		if (s125s.Text == "0")
		{
			s125s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s125s.ForeColor = Color.Black;
		}
	}

	private void h146_Leave(object sender, EventArgs e)
	{
		if (s128s.Text == string.Empty)
		{
			s128s.Text = "0";
		}
		if (s128s.Text == "0")
		{
			s128s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s128s.ForeColor = Color.Black;
		}
	}

	private void h147_Leave(object sender, EventArgs e)
	{
		if (s129s.Text == string.Empty)
		{
			s129s.Text = "0";
		}
		if (s129s.Text == "0")
		{
			s129s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s129s.ForeColor = Color.Black;
		}
	}

	private void h148_Leave(object sender, EventArgs e)
	{
		if (s130s.Text == string.Empty)
		{
			s130s.Text = "0";
		}
		if (s130s.Text == "0")
		{
			s130s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s130s.ForeColor = Color.Black;
		}
	}

	private void h149_Leave(object sender, EventArgs e)
	{
		if (s133s.Text == string.Empty)
		{
			s133s.Text = "0";
		}
		if (s133s.Text == "0")
		{
			s133s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s133s.ForeColor = Color.Black;
		}
	}

	private void h203_Leave(object sender, EventArgs e)
	{
		if (s221s.Text == string.Empty)
		{
			s221s.Text = "0";
		}
		if (s221s.Text == "0")
		{
			s221s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s221s.ForeColor = Color.Black;
		}
	}

	private void h204_Leave(object sender, EventArgs e)
	{
		if (s226s.Text == string.Empty)
		{
			s226s.Text = "0";
		}
		if (s226s.Text == "0")
		{
			s226s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s226s.ForeColor = Color.Black;
		}
	}

	private void h205_Leave(object sender, EventArgs e)
	{
		if (s228s.Text == string.Empty)
		{
			s228s.Text = "0";
		}
		if (s228s.Text == "0")
		{
			s228s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s228s.ForeColor = Color.Black;
		}
	}

	private void h206_Leave(object sender, EventArgs e)
	{
		if (s230s.Text == string.Empty)
		{
			s230s.Text = "0";
		}
		if (s230s.Text == "0")
		{
			s230s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s230s.ForeColor = Color.Black;
		}
	}

	private void h208_Leave(object sender, EventArgs e)
	{
		if (s231s.Text == string.Empty)
		{
			s231s.Text = "0";
		}
		if (s231s.Text == "0")
		{
			s231s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s231s.ForeColor = Color.Black;
		}
	}

	private void h209_Leave(object sender, EventArgs e)
	{
		if (s236s.Text == string.Empty)
		{
			s236s.Text = "0";
		}
		if (s236s.Text == "0")
		{
			s236s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s236s.ForeColor = Color.Black;
		}
	}

	private void h210_Leave(object sender, EventArgs e)
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

	private void h212_Leave(object sender, EventArgs e)
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

	private void h214_Leave(object sender, EventArgs e)
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

	private void s122_Leave(object sender, EventArgs e)
	{
		if (s70.Text == string.Empty)
		{
			s70.Text = "0";
		}
		if (s70.Text == "0")
		{
			s70.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s70.ForeColor = Color.Black;
		}
	}

	private void s123_Leave(object sender, EventArgs e)
	{
		if (s32.Text == string.Empty)
		{
			s32.Text = "0";
		}
		if (s32.Text == "0")
		{
			s32.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s32.ForeColor = Color.Black;
		}
	}

	private void s128_Leave(object sender, EventArgs e)
	{
		if (s62.Text == string.Empty)
		{
			s62.Text = "0";
		}
		if (s62.Text == "0")
		{
			s62.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s62.ForeColor = Color.Black;
		}
	}

	private void s129_Leave(object sender, EventArgs e)
	{
		if (s25.Text == string.Empty)
		{
			s25.Text = "0";
		}
		if (s25.Text == "0")
		{
			s25.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s25.ForeColor = Color.Black;
		}
	}

	private void s130_Leave(object sender, EventArgs e)
	{
	}

	private void s133_Leave(object sender, EventArgs e)
	{
		if (s169s.Text == string.Empty)
		{
			s169s.Text = "0";
		}
		if (s169s.Text == "0")
		{
			s169s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s169s.ForeColor = Color.Black;
		}
	}

	private void s135_Leave(object sender, EventArgs e)
	{
		if (s168s.Text == string.Empty)
		{
			s168s.Text = "0";
		}
		if (s168s.Text == "0")
		{
			s168s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s168s.ForeColor = Color.Black;
		}
	}

	private void s201_Leave(object sender, EventArgs e)
	{
		if (s57.Text == string.Empty)
		{
			s57.Text = "0";
		}
		if (s57.Text == "0")
		{
			s57.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s57.ForeColor = Color.Black;
		}
	}

	private void s207_Leave(object sender, EventArgs e)
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

	private void s218_Leave(object sender, EventArgs e)
	{
	}

	private void s221_Leave(object sender, EventArgs e)
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

	private void s226_Leave(object sender, EventArgs e)
	{
		if (s22.Text == string.Empty)
		{
			s22.Text = "0";
		}
		if (s22.Text == "0")
		{
			s22.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s22.ForeColor = Color.Black;
		}
	}

	private void s228_Leave(object sender, EventArgs e)
	{
		if (s66.Text == string.Empty)
		{
			s66.Text = "0";
		}
		if (s66.Text == "0")
		{
			s66.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s66.ForeColor = Color.Black;
		}
	}

	private void s230_Leave(object sender, EventArgs e)
	{
		if (s30.Text == string.Empty)
		{
			s30.Text = "0";
		}
		if (s30.Text == "0")
		{
			s30.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s30.ForeColor = Color.Black;
		}
	}

	private void s231_Leave(object sender, EventArgs e)
	{
		if (s29.Text == string.Empty)
		{
			s29.Text = "0";
		}
		if (s29.Text == "0")
		{
			s29.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s29.ForeColor = Color.Black;
		}
	}

	private void s236_Leave(object sender, EventArgs e)
	{
		if (s23.Text == string.Empty)
		{
			s23.Text = "0";
		}
		if (s23.Text == "0")
		{
			s23.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s23.ForeColor = Color.Black;
		}
	}

	private void d140_Leave(object sender, EventArgs e)
	{
		if (s11.Text == string.Empty)
		{
			s11.Text = "0";
		}
		if (s11.Text == "0")
		{
			s11.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s11.ForeColor = Color.Black;
		}
	}

	private void d141_Leave(object sender, EventArgs e)
	{
		if (s12.Text == string.Empty)
		{
			s12.Text = "0";
		}
		if (s12.Text == "0")
		{
			s12.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s12.ForeColor = Color.Black;
		}
	}

	private void d142_Leave(object sender, EventArgs e)
	{
		if (s13.Text == string.Empty)
		{
			s13.Text = "0";
		}
		if (s13.Text == "0")
		{
			s13.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s13.ForeColor = Color.Black;
		}
	}

	private void d143_Leave(object sender, EventArgs e)
	{
		if (s14.Text == string.Empty)
		{
			s14.Text = "0";
		}
		if (s14.Text == "0")
		{
			s14.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s14.ForeColor = Color.Black;
		}
	}

	private void d147_Leave(object sender, EventArgs e)
	{
		if (s15.Text == string.Empty)
		{
			s15.Text = "0";
		}
		if (s15.Text == "0")
		{
			s15.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s15.ForeColor = Color.Black;
		}
	}

	private void d148_Leave(object sender, EventArgs e)
	{
		if (s16.Text == string.Empty)
		{
			s16.Text = "0";
		}
		if (s16.Text == "0")
		{
			s16.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s16.ForeColor = Color.Black;
		}
	}

	private void d152_Leave(object sender, EventArgs e)
	{
		if (s17.Text == string.Empty)
		{
			s17.Text = "0";
		}
		if (s17.Text == "0")
		{
			s17.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s17.ForeColor = Color.Black;
		}
	}

	private void d155_Leave(object sender, EventArgs e)
	{
		if (s18.Text == string.Empty)
		{
			s18.Text = "0";
		}
		if (s18.Text == "0")
		{
			s18.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s18.ForeColor = Color.Black;
		}
	}

	private void d157_Leave(object sender, EventArgs e)
	{
		if (s19.Text == string.Empty)
		{
			s19.Text = "0";
		}
		if (s19.Text == "0")
		{
			s19.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s19.ForeColor = Color.Black;
		}
	}

	private void h150_Leave(object sender, EventArgs e)
	{
		if (s135s.Text == string.Empty)
		{
			s135s.Text = "0";
		}
		if (s135s.Text == "0")
		{
			s135s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s135s.ForeColor = Color.Black;
		}
	}

	private void h151_Leave(object sender, EventArgs e)
	{
		if (s136s.Text == string.Empty)
		{
			s136s.Text = "0";
		}
		if (s136s.Text == "0")
		{
			s136s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s136s.ForeColor = Color.Black;
		}
	}

	private void h154_Leave(object sender, EventArgs e)
	{
		if (s137s.Text == string.Empty)
		{
			s137s.Text = "0";
		}
		if (s137s.Text == "0")
		{
			s137s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s137s.ForeColor = Color.Black;
		}
	}

	private void h156_Leave(object sender, EventArgs e)
	{
		if (s138s.Text == string.Empty)
		{
			s138s.Text = "0";
		}
		if (s138s.Text == "0")
		{
			s138s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s138s.ForeColor = Color.Black;
		}
	}

	private void h157_Leave(object sender, EventArgs e)
	{
		if (s145s.Text == string.Empty)
		{
			s145s.Text = "0";
		}
		if (s145s.Text == "0")
		{
			s145s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s145s.ForeColor = Color.Black;
		}
	}

	private void h158_Leave(object sender, EventArgs e)
	{
		if (s147s.Text == string.Empty)
		{
			s147s.Text = "0";
		}
		if (s147s.Text == "0")
		{
			s147s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s147s.ForeColor = Color.Black;
		}
	}

	private void h160_Leave(object sender, EventArgs e)
	{
		if (s148s.Text == string.Empty)
		{
			s148s.Text = "0";
		}
		if (s148s.Text == "0")
		{
			s148s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s148s.ForeColor = Color.Black;
		}
	}

	private void h161_Leave(object sender, EventArgs e)
	{
		if (s153s.Text == string.Empty)
		{
			s153s.Text = "0";
		}
		if (s153s.Text == "0")
		{
			s153s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s153s.ForeColor = Color.Black;
		}
	}

	private void h162_Leave(object sender, EventArgs e)
	{
		if (s157s.Text == string.Empty)
		{
			s157s.Text = "0";
		}
		if (s157s.Text == "0")
		{
			s157s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s157s.ForeColor = Color.Black;
		}
	}

	private void h164_Leave(object sender, EventArgs e)
	{
		if (s161s.Text == string.Empty)
		{
			s161s.Text = "0";
		}
		if (s161s.Text == "0")
		{
			s161s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s161s.ForeColor = Color.Black;
		}
	}

	private void h215_Leave(object sender, EventArgs e)
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

	private void h216_Leave(object sender, EventArgs e)
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

	private void h217_Leave(object sender, EventArgs e)
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

	private void h219_Leave(object sender, EventArgs e)
	{
		if (s101s.Text == string.Empty)
		{
			s101s.Text = "0";
		}
		if (s101s.Text == "0")
		{
			s101s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s101s.ForeColor = Color.Black;
		}
	}

	private void h220_Leave(object sender, EventArgs e)
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

	private void h223_Leave(object sender, EventArgs e)
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

	private void h229_Leave(object sender, EventArgs e)
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

	private void h233_Leave(object sender, EventArgs e)
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

	private void h234_Leave(object sender, EventArgs e)
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

	private void h235_Leave(object sender, EventArgs e)
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

	private void s136_Leave(object sender, EventArgs e)
	{
		if (s31.Text == string.Empty)
		{
			s31.Text = "0";
		}
		if (s31.Text == "0")
		{
			s31.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s31.ForeColor = Color.Black;
		}
	}

	private void s137_Leave(object sender, EventArgs e)
	{
		if (s166s.Text == string.Empty)
		{
			s166s.Text = "0";
		}
		if (s166s.Text == "0")
		{
			s166s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s166s.ForeColor = Color.Black;
		}
	}

	private void s138_Leave(object sender, EventArgs e)
	{
		if (s65.Text == string.Empty)
		{
			s65.Text = "0";
		}
		if (s65.Text == "0")
		{
			s65.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s65.ForeColor = Color.Black;
		}
	}

	private void s145_Leave(object sender, EventArgs e)
	{
		if (s59.Text == string.Empty)
		{
			s59.Text = "0";
		}
		if (s59.Text == "0")
		{
			s59.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s59.ForeColor = Color.Black;
		}
	}

	private void s147_Leave(object sender, EventArgs e)
	{
		if (s58.Text == string.Empty)
		{
			s58.Text = "0";
		}
		if (s58.Text == "0")
		{
			s58.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s58.ForeColor = Color.Black;
		}
	}

	private void s148_Leave(object sender, EventArgs e)
	{
		if (s24.Text == string.Empty)
		{
			s24.Text = "0";
		}
		if (s24.Text == "0")
		{
			s24.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s24.ForeColor = Color.Black;
		}
	}

	private void s153_Leave(object sender, EventArgs e)
	{
		if (s64.Text == string.Empty)
		{
			s64.Text = "0";
		}
		if (s64.Text == "0")
		{
			s64.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s64.ForeColor = Color.Black;
		}
	}

	private void s157_Leave(object sender, EventArgs e)
	{
		if (s27.Text == string.Empty)
		{
			s27.Text = "0";
		}
		if (s27.Text == "0")
		{
			s27.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s27.ForeColor = Color.Black;
		}
	}

	private void s161_Leave(object sender, EventArgs e)
	{
		if (s60.Text == string.Empty)
		{
			s60.Text = "0";
		}
		if (s60.Text == "0")
		{
			s60.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s60.ForeColor = Color.Black;
		}
	}

	private void s162_Leave(object sender, EventArgs e)
	{
	}

	private void d159_Leave(object sender, EventArgs e)
	{
		if (s20.Text == string.Empty)
		{
			s20.Text = "0";
		}
		if (s20.Text == "0")
		{
			s20.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s20.ForeColor = Color.Black;
		}
	}

	private void d161_Leave(object sender, EventArgs e)
	{
		if (s21.Text == string.Empty)
		{
			s21.Text = "0";
		}
		if (s21.Text == "0")
		{
			s21.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s21.ForeColor = Color.Black;
		}
	}

	private void d162_Leave(object sender, EventArgs e)
	{
		if (s37.Text == string.Empty)
		{
			s37.Text = "0";
		}
		if (s37.Text == "0")
		{
			s37.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s37.ForeColor = Color.Black;
		}
	}

	private void d163_Leave(object sender, EventArgs e)
	{
		if (s38.Text == string.Empty)
		{
			s38.Text = "0";
		}
		if (s38.Text == "0")
		{
			s38.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s38.ForeColor = Color.Black;
		}
	}

	private void d164_Leave(object sender, EventArgs e)
	{
		if (s39.Text == string.Empty)
		{
			s39.Text = "0";
		}
		if (s39.Text == "0")
		{
			s39.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s39.ForeColor = Color.Black;
		}
	}

	private void d169_Leave(object sender, EventArgs e)
	{
		if (s40.Text == string.Empty)
		{
			s40.Text = "0";
		}
		if (s40.Text == "0")
		{
			s40.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s40.ForeColor = Color.Black;
		}
	}

	private void d175_Leave(object sender, EventArgs e)
	{
		if (s41.Text == string.Empty)
		{
			s41.Text = "0";
		}
		if (s41.Text == "0")
		{
			s41.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s41.ForeColor = Color.Black;
		}
	}

	private void d177_Leave(object sender, EventArgs e)
	{
		if (s42.Text == string.Empty)
		{
			s42.Text = "0";
		}
		if (s42.Text == "0")
		{
			s42.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s42.ForeColor = Color.Black;
		}
	}

	private void d186_Leave(object sender, EventArgs e)
	{
		if (s43.Text == string.Empty)
		{
			s43.Text = "0";
		}
		if (s43.Text == "0")
		{
			s43.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s43.ForeColor = Color.Black;
		}
	}

	private void d188_Leave(object sender, EventArgs e)
	{
		if (s44.Text == string.Empty)
		{
			s44.Text = "0";
		}
		if (s44.Text == "0")
		{
			s44.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s44.ForeColor = Color.Black;
		}
	}

	private void h167_Leave(object sender, EventArgs e)
	{
		if (s162s.Text == string.Empty)
		{
			s162s.Text = "0";
		}
		if (s162s.Text == "0")
		{
			s162s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s162s.ForeColor = Color.Black;
		}
	}

	private void h169_Leave(object sender, EventArgs e)
	{
		if (s164s.Text == string.Empty)
		{
			s164s.Text = "0";
		}
		if (s164s.Text == "0")
		{
			s164s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s164s.ForeColor = Color.Black;
		}
	}

	private void h170_Leave(object sender, EventArgs e)
	{
		if (s165s.Text == string.Empty)
		{
			s165s.Text = "0";
		}
		if (s165s.Text == "0")
		{
			s165s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s165s.ForeColor = Color.Black;
		}
	}

	private void h173_Leave(object sender, EventArgs e)
	{
		if (s174s.Text == string.Empty)
		{
			s174s.Text = "0";
		}
		if (s174s.Text == "0")
		{
			s174s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s174s.ForeColor = Color.Black;
		}
	}

	private void h176_Leave(object sender, EventArgs e)
	{
		if (s180s.Text == string.Empty)
		{
			s180s.Text = "0";
		}
		if (s180s.Text == "0")
		{
			s180s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s180s.ForeColor = Color.Black;
		}
	}

	private void h178_Leave(object sender, EventArgs e)
	{
		if (s182s.Text == string.Empty)
		{
			s182s.Text = "0";
		}
		if (s182s.Text == "0")
		{
			s182s.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s182s.ForeColor = Color.Black;
		}
	}

	private void s171_Leave(object sender, EventArgs e)
	{
		if (s36.Text == string.Empty)
		{
			s36.Text = "0";
		}
		if (s36.Text == "0")
		{
			s36.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s36.ForeColor = Color.Black;
		}
	}

	private void d190_Leave(object sender, EventArgs e)
	{
		if (s45.Text == string.Empty)
		{
			s45.Text = "0";
		}
		if (s45.Text == "0")
		{
			s45.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s45.ForeColor = Color.Black;
		}
	}

	private void d195_Leave(object sender, EventArgs e)
	{
		if (s46.Text == string.Empty)
		{
			s46.Text = "0";
		}
		if (s46.Text == "0")
		{
			s46.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s46.ForeColor = Color.Black;
		}
	}

	private void d196_Leave(object sender, EventArgs e)
	{
		if (s47.Text == string.Empty)
		{
			s47.Text = "0";
		}
		if (s47.Text == "0")
		{
			s47.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s47.ForeColor = Color.Black;
		}
	}

	private void d197_Leave(object sender, EventArgs e)
	{
		if (s48.Text == string.Empty)
		{
			s48.Text = "0";
		}
		if (s48.Text == "0")
		{
			s48.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s48.ForeColor = Color.Black;
		}
	}

	private void d200_Leave(object sender, EventArgs e)
	{
		if (s49.Text == string.Empty)
		{
			s49.Text = "0";
		}
		if (s49.Text == "0")
		{
			s49.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s49.ForeColor = Color.Black;
		}
	}

	private void d211_Leave(object sender, EventArgs e)
	{
		if (s50.Text == string.Empty)
		{
			s50.Text = "0";
		}
		if (s50.Text == "0")
		{
			s50.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			s50.ForeColor = Color.Black;
		}
	}

	private void txtwaraqadrost_Click(object sender, EventArgs e)
	{
		txtwaraqadrost.Text = "";
	}

	private void txtwaraqaybatl_Click(object sender, EventArgs e)
	{
		txtwaraqaybatl.Text = "";
	}

	private void txtwaraqadrost_Leave(object sender, EventArgs e)
	{
		if (txtwaraqadrost.Text == string.Empty)
		{
			txtwaraqadrost.Text = "0";
		}
		if (txtwaraqadrost.Text == "0")
		{
			txtwaraqadrost.ForeColor = Color.Green;
		}
		else
		{
			txtwaraqadrost.ForeColor = Color.Green;
		}
	}

	private void txtwaraqaybatl_Leave(object sender, EventArgs e)
	{
		if (txtwaraqaybatl.Text == string.Empty)
		{
			txtwaraqaybatl.Text = "0";
		}
		if (txtwaraqaybatl.Text == "0")
		{
			txtwaraqaybatl.ForeColor = Color.Red;
		}
		else
		{
			txtwaraqaybatl.ForeColor = Color.Red;
		}
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
			string qurey = "delete from  slemany_hazb  WHERE cood_bnka = " + txtbnkacood.Text + " and westga=" + comwestga.Text;
			SqlCommand cmd = new SqlCommand(qurey, connectionString);
			SqlCommand cmd1 = new SqlCommand(qurey1, connectionString);
			connectionString.Open();
			MessageBox.Show("Deleted ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			cmd.ExecuteNonQuery();
			cmd1.ExecuteNonQuery();
			all_txt0();
			connectionString.Close();
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
			s101s.Text = "0";
		}
	}

	private void h103_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s104s.Text = "0";
		}
	}

	private void h105_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s110s.Text = "0";
		}
	}

	private void h106_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s113s.Text = "0";
		}
	}

	private void h109_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s114s.Text = "0";
		}
	}

	private void h111_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s115s.Text = "0";
		}
	}

	private void h112_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s116s.Text = "0";
		}
	}

	private void h114_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void h120_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s117s.Text = "0";
		}
	}

	private void h123_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s119s.Text = "0";
		}
	}

	private void h129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s121s.Text = "0";
		}
	}

	private void h173_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s174s.Text = "0";
		}
	}

	private void h176_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s180s.Text = "0";
		}
	}

	private void h178_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s182s.Text = "0";
		}
	}

	private void h179_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s183s.Text = "0";
		}
	}

	private void h181_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s185s.Text = "0";
		}
	}

	private void h184_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s190s.Text = "0";
		}
	}

	private void h187_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s192s.Text = "0";
		}
	}

	private void h189_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s193s.Text = "0";
		}
	}

	private void h190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s194s.Text = "0";
		}
	}

	private void h191_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s198s.Text = "0";
		}
	}

	private void h198_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s201s.Text = "0";
		}
	}

	private void h131_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s122s.Text = "0";
		}
	}

	private void h199_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s207s.Text = "0";
		}
	}

	private void h133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s123s.Text = "0";
		}
	}

	private void h202_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s218s.Text = "0";
		}
	}

	private void h139_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s124s.Text = "0";
		}
	}

	private void h144_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s125s.Text = "0";
		}
	}

	private void h146_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s128s.Text = "0";
		}
	}

	private void h147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s129s.Text = "0";
		}
	}

	private void h148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s130s.Text = "0";
		}
	}

	private void h149_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s133s.Text = "0";
		}
	}

	private void h150_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s135s.Text = "0";
		}
	}

	private void h151_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s136s.Text = "0";
		}
	}

	private void h154_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s137s.Text = "0";
		}
	}

	private void h156_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s138s.Text = "0";
		}
	}

	private void h157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s145s.Text = "0";
		}
	}

	private void h158_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s147s.Text = "0";
		}
	}

	private void h160_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s148s.Text = "0";
		}
	}

	private void h161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s153s.Text = "0";
		}
	}

	private void h162_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s157s.Text = "0";
		}
	}

	private void h164_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s161s.Text = "0";
		}
	}

	private void h167_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s162s.Text = "0";
		}
	}

	private void h169_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s164s.Text = "0";
		}
	}

	private void h170_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s165s.Text = "0";
		}
	}

	private void h203_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s221s.Text = "0";
		}
	}

	private void h204_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s226s.Text = "0";
		}
	}

	private void h205_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s228s.Text = "0";
		}
	}

	private void h206_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s230s.Text = "0";
		}
	}

	private void h208_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s231s.Text = "0";
		}
	}

	private void h209_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s236s.Text = "0";
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

	private void s117_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s72.Text = "0";
		}
	}

	private void s119_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s34.Text = "0";
		}
	}

	private void s121_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s35.Text = "0";
		}
	}

	private void s122_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s70.Text = "0";
		}
	}

	private void s171_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s36.Text = "0";
		}
	}

	private void s174_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s68.Text = "0";
		}
	}

	private void s180_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s33.Text = "0";
		}
	}

	private void s182_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s67.Text = "0";
		}
	}

	private void s183_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s71.Text = "0";
		}
	}

	private void s123_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s32.Text = "0";
		}
	}

	private void s128_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s62.Text = "0";
		}
	}

	private void s129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s25.Text = "0";
		}
	}

	private void s130_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void s133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s169s.Text = "0";
		}
	}

	private void s135_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s168s.Text = "0";
		}
	}

	private void s136_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s31.Text = "0";
		}
	}

	private void s137_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s166s.Text = "0";
		}
	}

	private void s138_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s65.Text = "0";
		}
	}

	private void s145_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s59.Text = "0";
		}
	}

	private void s147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s58.Text = "0";
		}
	}

	private void s148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s24.Text = "0";
		}
	}

	private void s153_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s64.Text = "0";
		}
	}

	private void s157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s27.Text = "0";
		}
	}

	private void s161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s60.Text = "0";
		}
	}

	private void s185_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s69.Text = "0";
		}
	}

	private void s190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s26.Text = "0";
		}
	}

	private void s192_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s28.Text = "0";
		}
	}

	private void s193_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s61.Text = "0";
		}
	}

	private void s194_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s63.Text = "0";
		}
	}

	private void s198_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s171s.Text = "0";
		}
	}

	private void s201_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s57.Text = "0";
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
			s22.Text = "0";
		}
	}

	private void s228_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s66.Text = "0";
		}
	}

	private void s230_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s30.Text = "0";
		}
	}

	private void s231_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s29.Text = "0";
		}
	}

	private void s236_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s23.Text = "0";
		}
	}

	private void d107_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s1.Text = "0";
		}
	}

	private void d108_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s2.Text = "0";
		}
	}

	private void d114_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s3.Text = "0";
		}
	}

	private void d118_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s4.Text = "0";
		}
	}

	private void d126_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s5.Text = "0";
		}
	}

	private void d127_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s6.Text = "0";
		}
	}

	private void d129_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s7.Text = "0";
		}
	}

	private void d132_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s8.Text = "0";
		}
	}

	private void d133_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s9.Text = "0";
		}
	}

	private void d134_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s10.Text = "0";
		}
	}

	private void d140_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s11.Text = "0";
		}
	}

	private void d162_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s37.Text = "0";
		}
	}

	private void d163_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s38.Text = "0";
		}
	}

	private void d164_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s39.Text = "0";
		}
	}

	private void d169_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s40.Text = "0";
		}
	}

	private void d177_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s42.Text = "0";
		}
	}

	private void d186_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s43.Text = "0";
		}
	}

	private void d188_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s44.Text = "0";
		}
	}

	private void d190_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s45.Text = "0";
		}
	}

	private void d195_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s46.Text = "0";
		}
	}

	private void d141_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s12.Text = "0";
		}
	}

	private void d196_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s47.Text = "0";
		}
	}

	private void d197_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s48.Text = "0";
		}
	}

	private void d200_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s49.Text = "0";
		}
	}

	private void d211_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s50.Text = "0";
		}
	}

	private void d213_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s51.Text = "0";
		}
	}

	private void d147_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s15.Text = "0";
		}
	}

	private void d143_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s14.Text = "0";
		}
	}

	private void d142_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s13.Text = "0";
		}
	}

	private void d148_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s16.Text = "0";
		}
	}

	private void d152_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s17.Text = "0";
		}
	}

	private void d155_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s18.Text = "0";
		}
	}

	private void d157_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s19.Text = "0";
		}
	}

	private void d159_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s20.Text = "0";
		}
	}

	private void d161_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s21.Text = "0";
		}
	}

	private void d232_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s56.Text = "0";
		}
	}

	private void d227_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s55.Text = "0";
		}
	}

	private void d225_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s54.Text = "0";
		}
	}

	private void d224_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s53.Text = "0";
		}
	}

	private void d222_KeyDown(object sender, KeyEventArgs e)
	{
		CultureInfo ar = new CultureInfo("en-us");
		InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
		if (e.KeyCode == Keys.Return)
		{
			MessageBox.Show("ژمارەی دەنگدەر بنووسەوە", "دامەگرە enter تکایە", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			s52.Text = "0";
		}
	}

	private void hl123_MouseDown(object sender, MouseEventArgs e)
	{
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

	private void h146_KeyPress(object sender, KeyPressEventArgs e)
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
			s41.Text = "0";
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
		btnsearch.BackColor = Color.FromArgb(43, 196, 138);
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
	}

	private void button4_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void label26_Click(object sender, EventArgs e)
	{
	}

	private void button5_MouseMove(object sender, MouseEventArgs e)
	{
		button5.BackColor = Color.Green;
	}

	private void bnltablsearch_MouseMove(object sender, MouseEventArgs e)
	{
		button5.BackColor = Color.Red;
	}

	private void btnsearch_MouseMove(object sender, MouseEventArgs e)
	{
		btnsearch.BackColor = Color.Red;
	}

	private void label12_Click(object sender, EventArgs e)
	{
	}

	private void label16_Click(object sender, EventArgs e)
	{
	}

	private void label13_Click(object sender, EventArgs e)
	{
	}

	private void label19_Click(object sender, EventArgs e)
	{
	}

	private void label23_Click(object sender, EventArgs e)
	{
	}

	private void label15_Click(object sender, EventArgs e)
	{
	}

	private void label18_Click(object sender, EventArgs e)
	{
	}

	private void label27_Click(object sender, EventArgs e)
	{
	}

	private void label20_Click(object sender, EventArgs e)
	{
	}

	private void label31_Click(object sender, EventArgs e)
	{
	}

	private void label35_Click(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUK_Anjamakan.Frm.S_Gshty));
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
		this.panel1 = new System.Windows.Forms.Panel();
		this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
		this.btn_p = new System.Windows.Forms.Button();
		this.txt_candid_s = new System.Windows.Forms.TextBox();
		this.txt_total_s = new System.Windows.Forms.TextBox();
		this.btn_candid_d = new System.Windows.Forms.Button();
		this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
		this.s50 = new System.Windows.Forms.TextBox();
		this.s49 = new System.Windows.Forms.TextBox();
		this.s48 = new System.Windows.Forms.TextBox();
		this.s47 = new System.Windows.Forms.TextBox();
		this.s46 = new System.Windows.Forms.TextBox();
		this.s45 = new System.Windows.Forms.TextBox();
		this.label213 = new System.Windows.Forms.Label();
		this.label209 = new System.Windows.Forms.Label();
		this.label205 = new System.Windows.Forms.Label();
		this.label201 = new System.Windows.Forms.Label();
		this.label197 = new System.Windows.Forms.Label();
		this.label193 = new System.Windows.Forms.Label();
		this.label157 = new System.Windows.Forms.Label();
		this.label153 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.s21 = new System.Windows.Forms.TextBox();
		this.s20 = new System.Windows.Forms.TextBox();
		this.label50 = new System.Windows.Forms.Label();
		this.s1 = new System.Windows.Forms.TextBox();
		this.s16 = new System.Windows.Forms.TextBox();
		this.s15 = new System.Windows.Forms.TextBox();
		this.s14 = new System.Windows.Forms.TextBox();
		this.s13 = new System.Windows.Forms.TextBox();
		this.s12 = new System.Windows.Forms.TextBox();
		this.s11 = new System.Windows.Forms.TextBox();
		this.s10 = new System.Windows.Forms.TextBox();
		this.s9 = new System.Windows.Forms.TextBox();
		this.label60 = new System.Windows.Forms.Label();
		this.label117 = new System.Windows.Forms.Label();
		this.label129 = new System.Windows.Forms.Label();
		this.label125 = new System.Windows.Forms.Label();
		this.label121 = new System.Windows.Forms.Label();
		this.label113 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.s5 = new System.Windows.Forms.TextBox();
		this.label52 = new System.Windows.Forms.Label();
		this.s2 = new System.Windows.Forms.TextBox();
		this.s4 = new System.Windows.Forms.TextBox();
		this.label23 = new System.Windows.Forms.Label();
		this.s3 = new System.Windows.Forms.TextBox();
		this.label54 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.label58 = new System.Windows.Forms.Label();
		this.label56 = new System.Windows.Forms.Label();
		this.label31 = new System.Windows.Forms.Label();
		this.label35 = new System.Windows.Forms.Label();
		this.label39 = new System.Windows.Forms.Label();
		this.s6 = new System.Windows.Forms.TextBox();
		this.s7 = new System.Windows.Forms.TextBox();
		this.s8 = new System.Windows.Forms.TextBox();
		this.label66 = new System.Windows.Forms.Label();
		this.label65 = new System.Windows.Forms.Label();
		this.label62 = new System.Windows.Forms.Label();
		this.label133 = new System.Windows.Forms.Label();
		this.label137 = new System.Windows.Forms.Label();
		this.label141 = new System.Windows.Forms.Label();
		this.label145 = new System.Windows.Forms.Label();
		this.label149 = new System.Windows.Forms.Label();
		this.s17 = new System.Windows.Forms.TextBox();
		this.s18 = new System.Windows.Forms.TextBox();
		this.s19 = new System.Windows.Forms.TextBox();
		this.label161 = new System.Windows.Forms.Label();
		this.s37 = new System.Windows.Forms.TextBox();
		this.label165 = new System.Windows.Forms.Label();
		this.s38 = new System.Windows.Forms.TextBox();
		this.label169 = new System.Windows.Forms.Label();
		this.s39 = new System.Windows.Forms.TextBox();
		this.label173 = new System.Windows.Forms.Label();
		this.s40 = new System.Windows.Forms.TextBox();
		this.label177 = new System.Windows.Forms.Label();
		this.s41 = new System.Windows.Forms.TextBox();
		this.label181 = new System.Windows.Forms.Label();
		this.s42 = new System.Windows.Forms.TextBox();
		this.label185 = new System.Windows.Forms.Label();
		this.s43 = new System.Windows.Forms.TextBox();
		this.label189 = new System.Windows.Forms.Label();
		this.s44 = new System.Windows.Forms.TextBox();
		this.label91 = new System.Windows.Forms.Label();
		this.s51 = new System.Windows.Forms.TextBox();
		this.label94 = new System.Windows.Forms.Label();
		this.label53 = new System.Windows.Forms.Label();
		this.label55 = new System.Windows.Forms.Label();
		this.label57 = new System.Windows.Forms.Label();
		this.label64 = new System.Windows.Forms.Label();
		this.s52 = new System.Windows.Forms.TextBox();
		this.s53 = new System.Windows.Forms.TextBox();
		this.s54 = new System.Windows.Forms.TextBox();
		this.s55 = new System.Windows.Forms.TextBox();
		this.s56 = new System.Windows.Forms.TextBox();
		this.s57 = new System.Windows.Forms.TextBox();
		this.s22 = new System.Windows.Forms.TextBox();
		this.s23 = new System.Windows.Forms.TextBox();
		this.s59 = new System.Windows.Forms.TextBox();
		this.s58 = new System.Windows.Forms.TextBox();
		this.s24 = new System.Windows.Forms.TextBox();
		this.s60 = new System.Windows.Forms.TextBox();
		this.s61 = new System.Windows.Forms.TextBox();
		this.s25 = new System.Windows.Forms.TextBox();
		this.s62 = new System.Windows.Forms.TextBox();
		this.s26 = new System.Windows.Forms.TextBox();
		this.s63 = new System.Windows.Forms.TextBox();
		this.s27 = new System.Windows.Forms.TextBox();
		this.s28 = new System.Windows.Forms.TextBox();
		this.s64 = new System.Windows.Forms.TextBox();
		this.s29 = new System.Windows.Forms.TextBox();
		this.s30 = new System.Windows.Forms.TextBox();
		this.s31 = new System.Windows.Forms.TextBox();
		this.s65 = new System.Windows.Forms.TextBox();
		this.s66 = new System.Windows.Forms.TextBox();
		this.s32 = new System.Windows.Forms.TextBox();
		this.s33 = new System.Windows.Forms.TextBox();
		this.s34 = new System.Windows.Forms.TextBox();
		this.s67 = new System.Windows.Forms.TextBox();
		this.s69 = new System.Windows.Forms.TextBox();
		this.s68 = new System.Windows.Forms.TextBox();
		this.s70 = new System.Windows.Forms.TextBox();
		this.s71 = new System.Windows.Forms.TextBox();
		this.s35 = new System.Windows.Forms.TextBox();
		this.s36 = new System.Windows.Forms.TextBox();
		this.s72 = new System.Windows.Forms.TextBox();
		this.s174s = new System.Windows.Forms.TextBox();
		this.s180s = new System.Windows.Forms.TextBox();
		this.s182s = new System.Windows.Forms.TextBox();
		this.s183s = new System.Windows.Forms.TextBox();
		this.s185s = new System.Windows.Forms.TextBox();
		this.s190s = new System.Windows.Forms.TextBox();
		this.s192s = new System.Windows.Forms.TextBox();
		this.s193s = new System.Windows.Forms.TextBox();
		this.s194s = new System.Windows.Forms.TextBox();
		this.s198s = new System.Windows.Forms.TextBox();
		this.s201s = new System.Windows.Forms.TextBox();
		this.s207s = new System.Windows.Forms.TextBox();
		this.s218s = new System.Windows.Forms.TextBox();
		this.s221s = new System.Windows.Forms.TextBox();
		this.s226s = new System.Windows.Forms.TextBox();
		this.s228s = new System.Windows.Forms.TextBox();
		this.s230s = new System.Windows.Forms.TextBox();
		this.s231s = new System.Windows.Forms.TextBox();
		this.s236s = new System.Windows.Forms.TextBox();
		this.h210 = new System.Windows.Forms.TextBox();
		this.h212 = new System.Windows.Forms.TextBox();
		this.h214 = new System.Windows.Forms.TextBox();
		this.h215 = new System.Windows.Forms.TextBox();
		this.h216 = new System.Windows.Forms.TextBox();
		this.h217 = new System.Windows.Forms.TextBox();
		this.h219 = new System.Windows.Forms.TextBox();
		this.h220 = new System.Windows.Forms.TextBox();
		this.h223 = new System.Windows.Forms.TextBox();
		this.h229 = new System.Windows.Forms.TextBox();
		this.h233 = new System.Windows.Forms.TextBox();
		this.h234 = new System.Windows.Forms.TextBox();
		this.h235 = new System.Windows.Forms.TextBox();
		this.s221 = new System.Windows.Forms.TextBox();
		this.s207 = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.label28 = new System.Windows.Forms.Label();
		this.label30 = new System.Windows.Forms.Label();
		this.label32 = new System.Windows.Forms.Label();
		this.label34 = new System.Windows.Forms.Label();
		this.label36 = new System.Windows.Forms.Label();
		this.label38 = new System.Windows.Forms.Label();
		this.label40 = new System.Windows.Forms.Label();
		this.label42 = new System.Windows.Forms.Label();
		this.label44 = new System.Windows.Forms.Label();
		this.label46 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.label59 = new System.Windows.Forms.Label();
		this.label61 = new System.Windows.Forms.Label();
		this.label63 = new System.Windows.Forms.Label();
		this.label68 = new System.Windows.Forms.Label();
		this.label71 = new System.Windows.Forms.Label();
		this.label73 = new System.Windows.Forms.Label();
		this.label75 = new System.Windows.Forms.Label();
		this.label77 = new System.Windows.Forms.Label();
		this.label79 = new System.Windows.Forms.Label();
		this.label81 = new System.Windows.Forms.Label();
		this.label83 = new System.Windows.Forms.Label();
		this.label85 = new System.Windows.Forms.Label();
		this.label87 = new System.Windows.Forms.Label();
		this.label89 = new System.Windows.Forms.Label();
		this.label90 = new System.Windows.Forms.Label();
		this.label96 = new System.Windows.Forms.Label();
		this.label97 = new System.Windows.Forms.Label();
		this.label98 = new System.Windows.Forms.Label();
		this.label99 = new System.Windows.Forms.Label();
		this.label100 = new System.Windows.Forms.Label();
		this.label101 = new System.Windows.Forms.Label();
		this.label102 = new System.Windows.Forms.Label();
		this.label103 = new System.Windows.Forms.Label();
		this.label104 = new System.Windows.Forms.Label();
		this.label105 = new System.Windows.Forms.Label();
		this.label106 = new System.Windows.Forms.Label();
		this.label107 = new System.Windows.Forms.Label();
		this.label108 = new System.Windows.Forms.Label();
		this.label109 = new System.Windows.Forms.Label();
		this.label110 = new System.Windows.Forms.Label();
		this.label111 = new System.Windows.Forms.Label();
		this.label112 = new System.Windows.Forms.Label();
		this.label115 = new System.Windows.Forms.Label();
		this.label116 = new System.Windows.Forms.Label();
		this.label118 = new System.Windows.Forms.Label();
		this.label119 = new System.Windows.Forms.Label();
		this.label120 = new System.Windows.Forms.Label();
		this.label122 = new System.Windows.Forms.Label();
		this.label123 = new System.Windows.Forms.Label();
		this.label124 = new System.Windows.Forms.Label();
		this.label126 = new System.Windows.Forms.Label();
		this.label127 = new System.Windows.Forms.Label();
		this.label128 = new System.Windows.Forms.Label();
		this.label130 = new System.Windows.Forms.Label();
		this.label131 = new System.Windows.Forms.Label();
		this.label132 = new System.Windows.Forms.Label();
		this.label134 = new System.Windows.Forms.Label();
		this.s101s = new System.Windows.Forms.TextBox();
		this.s104s = new System.Windows.Forms.TextBox();
		this.s110s = new System.Windows.Forms.TextBox();
		this.s113s = new System.Windows.Forms.TextBox();
		this.s114s = new System.Windows.Forms.TextBox();
		this.s115s = new System.Windows.Forms.TextBox();
		this.s116s = new System.Windows.Forms.TextBox();
		this.label29 = new System.Windows.Forms.Label();
		this.label33 = new System.Windows.Forms.Label();
		this.label37 = new System.Windows.Forms.Label();
		this.label41 = new System.Windows.Forms.Label();
		this.label45 = new System.Windows.Forms.Label();
		this.label67 = new System.Windows.Forms.Label();
		this.label70 = new System.Windows.Forms.Label();
		this.label170 = new System.Windows.Forms.Label();
		this.label171 = new System.Windows.Forms.Label();
		this.label172 = new System.Windows.Forms.Label();
		this.label174 = new System.Windows.Forms.Label();
		this.label175 = new System.Windows.Forms.Label();
		this.label176 = new System.Windows.Forms.Label();
		this.label178 = new System.Windows.Forms.Label();
		this.label179 = new System.Windows.Forms.Label();
		this.label180 = new System.Windows.Forms.Label();
		this.label182 = new System.Windows.Forms.Label();
		this.label183 = new System.Windows.Forms.Label();
		this.label184 = new System.Windows.Forms.Label();
		this.label186 = new System.Windows.Forms.Label();
		this.label187 = new System.Windows.Forms.Label();
		this.label188 = new System.Windows.Forms.Label();
		this.label190 = new System.Windows.Forms.Label();
		this.label191 = new System.Windows.Forms.Label();
		this.label192 = new System.Windows.Forms.Label();
		this.label194 = new System.Windows.Forms.Label();
		this.label195 = new System.Windows.Forms.Label();
		this.label196 = new System.Windows.Forms.Label();
		this.label198 = new System.Windows.Forms.Label();
		this.label199 = new System.Windows.Forms.Label();
		this.label200 = new System.Windows.Forms.Label();
		this.label202 = new System.Windows.Forms.Label();
		this.label203 = new System.Windows.Forms.Label();
		this.label204 = new System.Windows.Forms.Label();
		this.label206 = new System.Windows.Forms.Label();
		this.label207 = new System.Windows.Forms.Label();
		this.label208 = new System.Windows.Forms.Label();
		this.label210 = new System.Windows.Forms.Label();
		this.label47 = new System.Windows.Forms.Label();
		this.label78 = new System.Windows.Forms.Label();
		this.s117s = new System.Windows.Forms.TextBox();
		this.label88 = new System.Windows.Forms.Label();
		this.label84 = new System.Windows.Forms.Label();
		this.label82 = new System.Windows.Forms.Label();
		this.s119s = new System.Windows.Forms.TextBox();
		this.label86 = new System.Windows.Forms.Label();
		this.s121s = new System.Windows.Forms.TextBox();
		this.label80 = new System.Windows.Forms.Label();
		this.label136 = new System.Windows.Forms.Label();
		this.s122s = new System.Windows.Forms.TextBox();
		this.label76 = new System.Windows.Forms.Label();
		this.label138 = new System.Windows.Forms.Label();
		this.s123s = new System.Windows.Forms.TextBox();
		this.label72 = new System.Windows.Forms.Label();
		this.label139 = new System.Windows.Forms.Label();
		this.s124s = new System.Windows.Forms.TextBox();
		this.label69 = new System.Windows.Forms.Label();
		this.label140 = new System.Windows.Forms.Label();
		this.s125s = new System.Windows.Forms.TextBox();
		this.label247 = new System.Windows.Forms.Label();
		this.label142 = new System.Windows.Forms.Label();
		this.s128s = new System.Windows.Forms.TextBox();
		this.label251 = new System.Windows.Forms.Label();
		this.label143 = new System.Windows.Forms.Label();
		this.s129s = new System.Windows.Forms.TextBox();
		this.s130s = new System.Windows.Forms.TextBox();
		this.label144 = new System.Windows.Forms.Label();
		this.label255 = new System.Windows.Forms.Label();
		this.label259 = new System.Windows.Forms.Label();
		this.label146 = new System.Windows.Forms.Label();
		this.s133s = new System.Windows.Forms.TextBox();
		this.label263 = new System.Windows.Forms.Label();
		this.label147 = new System.Windows.Forms.Label();
		this.s135s = new System.Windows.Forms.TextBox();
		this.label267 = new System.Windows.Forms.Label();
		this.label148 = new System.Windows.Forms.Label();
		this.s136s = new System.Windows.Forms.TextBox();
		this.label271 = new System.Windows.Forms.Label();
		this.label150 = new System.Windows.Forms.Label();
		this.s137s = new System.Windows.Forms.TextBox();
		this.s138s = new System.Windows.Forms.TextBox();
		this.label151 = new System.Windows.Forms.Label();
		this.label275 = new System.Windows.Forms.Label();
		this.label279 = new System.Windows.Forms.Label();
		this.label152 = new System.Windows.Forms.Label();
		this.s145s = new System.Windows.Forms.TextBox();
		this.s147s = new System.Windows.Forms.TextBox();
		this.label154 = new System.Windows.Forms.Label();
		this.label283 = new System.Windows.Forms.Label();
		this.label287 = new System.Windows.Forms.Label();
		this.label155 = new System.Windows.Forms.Label();
		this.s148s = new System.Windows.Forms.TextBox();
		this.s153s = new System.Windows.Forms.TextBox();
		this.label156 = new System.Windows.Forms.Label();
		this.label291 = new System.Windows.Forms.Label();
		this.label295 = new System.Windows.Forms.Label();
		this.label158 = new System.Windows.Forms.Label();
		this.s157s = new System.Windows.Forms.TextBox();
		this.label299 = new System.Windows.Forms.Label();
		this.label159 = new System.Windows.Forms.Label();
		this.s161s = new System.Windows.Forms.TextBox();
		this.label303 = new System.Windows.Forms.Label();
		this.label160 = new System.Windows.Forms.Label();
		this.s162s = new System.Windows.Forms.TextBox();
		this.label307 = new System.Windows.Forms.Label();
		this.label162 = new System.Windows.Forms.Label();
		this.s164s = new System.Windows.Forms.TextBox();
		this.s165s = new System.Windows.Forms.TextBox();
		this.label163 = new System.Windows.Forms.Label();
		this.label311 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label164 = new System.Windows.Forms.Label();
		this.s166s = new System.Windows.Forms.TextBox();
		this.label166 = new System.Windows.Forms.Label();
		this.s168s = new System.Windows.Forms.TextBox();
		this.label167 = new System.Windows.Forms.Label();
		this.s169s = new System.Windows.Forms.TextBox();
		this.label168 = new System.Windows.Forms.Label();
		this.s171s = new System.Windows.Forms.TextBox();
		this.label114 = new System.Windows.Forms.Label();
		this.label51 = new System.Windows.Forms.Label();
		this.lbl_taswit = new System.Windows.Forms.Label();
		this.labljorydangdan = new System.Windows.Forms.Label();
		this.tableLayoutPanel1.SuspendLayout();
		this.bnltablsearch.SuspendLayout();
		this.panel1.SuspendLayout();
		this.tableLayoutPanel3.SuspendLayout();
		this.tableLayoutPanel7.SuspendLayout();
		base.SuspendLayout();
		this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
		this.tableLayoutPanel1.ColumnCount = 9;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.98686f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.81445f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.05882f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95502f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.54325f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.44898f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.877551f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.38384f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207f));
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
		this.txtmalband.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtmalband.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtmalband.Location = new System.Drawing.Point(929, 60);
		this.txtmalband.Multiline = true;
		this.txtmalband.Name = "txtmalband";
		this.txtmalband.ReadOnly = true;
		this.txtmalband.Size = new System.Drawing.Size(61, 50);
		this.txtmalband.TabIndex = 2;
		this.txtmalband.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtparezga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtparezga.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtparezga.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtparezga.Location = new System.Drawing.Point(809, 60);
		this.txtparezga.Multiline = true;
		this.txtparezga.Name = "txtparezga";
		this.txtparezga.ReadOnly = true;
		this.txtparezga.Size = new System.Drawing.Size(114, 50);
		this.txtparezga.TabIndex = 3;
		this.txtparezga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtcoodtasj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtcoodtasj.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtcoodtasj.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtcoodtasj.Location = new System.Drawing.Point(665, 60);
		this.txtcoodtasj.Multiline = true;
		this.txtcoodtasj.Name = "txtcoodtasj";
		this.txtcoodtasj.ReadOnly = true;
		this.txtcoodtasj.Size = new System.Drawing.Size(138, 50);
		this.txtcoodtasj.TabIndex = 4;
		this.txtcoodtasj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtnawtasj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtnawtasj.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtnawtasj.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtnawtasj.Location = new System.Drawing.Point(471, 60);
		this.txtnawtasj.Multiline = true;
		this.txtnawtasj.Name = "txtnawtasj";
		this.txtnawtasj.ReadOnly = true;
		this.txtnawtasj.Size = new System.Drawing.Size(188, 50);
		this.txtnawtasj.TabIndex = 5;
		this.txtnawtasj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtnawbnka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtnawbnka.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtnawbnka.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtnawbnka.Location = new System.Drawing.Point(218, 60);
		this.txtnawbnka.Multiline = true;
		this.txtnawbnka.Name = "txtnawbnka";
		this.txtnawbnka.ReadOnly = true;
		this.txtnawbnka.Size = new System.Drawing.Size(247, 50);
		this.txtnawbnka.TabIndex = 6;
		this.txtnawbnka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtbnkacood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtbnkacood.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtbnkacood.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtbnkacood.Location = new System.Drawing.Point(1149, 60);
		this.txtbnkacood.Multiline = true;
		this.txtbnkacood.Name = "txtbnkacood";
		this.txtbnkacood.Size = new System.Drawing.Size(205, 50);
		this.txtbnkacood.TabIndex = 0;
		this.txtbnkacood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtbnkacood.TextChanged += new System.EventHandler(txtbnkacood_TextChanged);
		this.txtbnkacood.KeyDown += new System.Windows.Forms.KeyEventHandler(txtbnkacood_KeyDown);
		this.txtbnkacood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtbnkacood_KeyPress);
		this.txtwestga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtwestga.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtwestga.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtwestga.Location = new System.Drawing.Point(140, 60);
		this.txtwestga.Multiline = true;
		this.txtwestga.Name = "txtwestga";
		this.txtwestga.ReadOnly = true;
		this.txtwestga.Size = new System.Drawing.Size(72, 50);
		this.txtwestga.TabIndex = 7;
		this.txtwestga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtzhdangdar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtzhdangdar.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtzhdangdar.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtzhdangdar.Location = new System.Drawing.Point(3, 60);
		this.txtzhdangdar.Multiline = true;
		this.txtzhdangdar.Name = "txtzhdangdar";
		this.txtzhdangdar.ReadOnly = true;
		this.txtzhdangdar.Size = new System.Drawing.Size(131, 50);
		this.txtzhdangdar.TabIndex = 8;
		this.txtzhdangdar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label11.AutoSize = true;
		this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label11.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.ForeColor = System.Drawing.Color.White;
		this.label11.Location = new System.Drawing.Point(140, 0);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(72, 57);
		this.label11.TabIndex = 11;
		this.label11.Text = "ژ.وێستگه\u200c";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label7.AutoSize = true;
		this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label7.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.Color.White;
		this.label7.Location = new System.Drawing.Point(471, 0);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(188, 57);
		this.label7.TabIndex = 10;
		this.label7.Text = "ناوی ناوه\u200cندی تۆماركردن";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label9.AutoSize = true;
		this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label9.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.ForeColor = System.Drawing.Color.White;
		this.label9.Location = new System.Drawing.Point(665, 0);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(138, 57);
		this.label9.TabIndex = 12;
		this.label9.Text = "ژ.ناوه\u200cندی تۆماركردن";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label10.AutoSize = true;
		this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label10.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.ForeColor = System.Drawing.Color.White;
		this.label10.Location = new System.Drawing.Point(809, 0);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(114, 57);
		this.label10.TabIndex = 13;
		this.label10.Text = "پارێزگا";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label6.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.White;
		this.label6.Location = new System.Drawing.Point(996, 0);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(147, 57);
		this.label6.TabIndex = 10;
		this.label6.Text = "گه\u200cڕان";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.AutoSize = true;
		this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label2.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.White;
		this.label2.Location = new System.Drawing.Point(3, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(131, 57);
		this.label2.TabIndex = 10;
		this.label2.Text = "ژ.ده\u200cنگده\u200cر";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnsearch.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill;
		this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		this.btnsearch.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnsearch.ForeColor = System.Drawing.Color.White;
		this.btnsearch.Image = (System.Drawing.Image)resources.GetObject("btnsearch.Image");
		this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnsearch.Location = new System.Drawing.Point(996, 60);
		this.btnsearch.Name = "btnsearch";
		this.btnsearch.Size = new System.Drawing.Size(147, 50);
		this.btnsearch.TabIndex = 1;
		this.btnsearch.Text = "Search";
		this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnsearch.UseVisualStyleBackColor = false;
		this.btnsearch.Click += new System.EventHandler(btnsearch_Click);
		this.btnsearch.MouseMove += new System.Windows.Forms.MouseEventHandler(btnsearch_MouseMove);
		this.label3.AutoSize = true;
		this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label3.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.White;
		this.label3.Location = new System.Drawing.Point(1149, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(205, 57);
		this.label3.TabIndex = 9;
		this.label3.Text = "ژ.بنكه\u200cی ده\u200cنگدان";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label1.AutoSize = true;
		this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label1.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(929, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(61, 57);
		this.label1.TabIndex = 8;
		this.label1.Text = "مه\u200cڵبه\u200cند";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.AutoSize = true;
		this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label8.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = System.Drawing.Color.White;
		this.label8.Location = new System.Drawing.Point(218, 0);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(247, 57);
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
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151f));
		this.bnltablsearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174f));
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
		this.bnltablsearch.MouseMove += new System.Windows.Forms.MouseEventHandler(bnltablsearch_MouseMove);
		this.button5.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.button5.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.ForeColor = System.Drawing.Color.White;
		this.button5.Location = new System.Drawing.Point(3, 3);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(156, 54);
		this.button5.TabIndex = 5902;
		this.button5.Text = "سرینەوە";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(button5_MouseMove);
		this.label49.AutoSize = true;
		this.label49.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label49.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label49.ForeColor = System.Drawing.Color.Black;
		this.label49.Location = new System.Drawing.Point(1182, 0);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(172, 60);
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
		this.comwestga.Location = new System.Drawing.Point(1031, 3);
		this.comwestga.Name = "comwestga";
		this.comwestga.Size = new System.Drawing.Size(145, 46);
		this.comwestga.TabIndex = 0;
		this.comwestga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.comwestga.SelectedIndexChanged += new System.EventHandler(comwestga_SelectedIndexChanged);
		this.comwestga.MouseMove += new System.Windows.Forms.MouseEventHandler(comwestga_MouseMove);
		this.btnadd.BackColor = System.Drawing.Color.FromArgb(43, 196, 138);
		this.btnadd.Dock = System.Windows.Forms.DockStyle.Fill;
		this.btnadd.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnadd.ForeColor = System.Drawing.Color.White;
		this.btnadd.Location = new System.Drawing.Point(829, 3);
		this.btnadd.Name = "btnadd";
		this.btnadd.Size = new System.Drawing.Size(196, 54);
		this.btnadd.TabIndex = 5897;
		this.btnadd.Text = "تۆماركردن";
		this.btnadd.UseVisualStyleBackColor = false;
		this.btnadd.Click += new System.EventHandler(btnadd_Click);
		this.btnadd.MouseMove += new System.Windows.Forms.MouseEventHandler(btnadd_MouseMove);
		this.label4.AutoSize = true;
		this.label4.BackColor = System.Drawing.Color.White;
		this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label4.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.Color.LimeGreen;
		this.label4.Location = new System.Drawing.Point(581, 0);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(242, 60);
		this.label4.TabIndex = 10;
		this.label4.Text = "وه\u200cره\u200cقه\u200cی دروست / عدد الاوراق الصحیحه\u200c";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(label4_MouseMove);
		this.txtwaraqadrost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtwaraqadrost.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtwaraqadrost.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtwaraqadrost.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txtwaraqadrost.Location = new System.Drawing.Point(506, 3);
		this.txtwaraqadrost.Multiline = true;
		this.txtwaraqadrost.Name = "txtwaraqadrost";
		this.txtwaraqadrost.Size = new System.Drawing.Size(69, 54);
		this.txtwaraqadrost.TabIndex = 1;
		this.txtwaraqadrost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtwaraqadrost.Click += new System.EventHandler(txtwaraqadrost_Click);
		this.txtwaraqadrost.KeyDown += new System.Windows.Forms.KeyEventHandler(txtwaraqadrost_KeyDown);
		this.txtwaraqadrost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtwaraqadrost_KeyPress);
		this.txtwaraqadrost.Leave += new System.EventHandler(txtwaraqadrost_Leave);
		this.label5.AutoSize = true;
		this.label5.BackColor = System.Drawing.Color.White;
		this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label5.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.Red;
		this.label5.Location = new System.Drawing.Point(254, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(246, 60);
		this.label5.TabIndex = 10;
		this.label5.Text = "وه\u200cره\u200cقه\u200cی پوچه\u200cڵ / عدد الاوراق الباطلة\u200c";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtwaraqaybatl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtwaraqaybatl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtwaraqaybatl.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtwaraqaybatl.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txtwaraqaybatl.Location = new System.Drawing.Point(165, 3);
		this.txtwaraqaybatl.Multiline = true;
		this.txtwaraqaybatl.Name = "txtwaraqaybatl";
		this.txtwaraqaybatl.Size = new System.Drawing.Size(83, 54);
		this.txtwaraqaybatl.TabIndex = 2;
		this.txtwaraqaybatl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtwaraqaybatl.Click += new System.EventHandler(txtwaraqaybatl_Click);
		this.txtwaraqaybatl.KeyDown += new System.Windows.Forms.KeyEventHandler(txtwaraqaybatl_KeyDown);
		this.txtwaraqaybatl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtwaraqaybatl_KeyPress);
		this.txtwaraqaybatl.Leave += new System.EventHandler(txtwaraqaybatl_Leave);
		this.panel1.AutoScroll = true;
		this.panel1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.panel1.Controls.Add(this.tableLayoutPanel3);
		this.panel1.Controls.Add(this.tableLayoutPanel7);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 173);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1357, 660);
		this.panel1.TabIndex = 10;
		this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tableLayoutPanel3.ColumnCount = 5;
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.361963f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.47546f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.993865f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.665645f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.42638f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.tableLayoutPanel3.Controls.Add(this.btn_p, 0, 0);
		this.tableLayoutPanel3.Controls.Add(this.txt_candid_s, 0, 0);
		this.tableLayoutPanel3.Controls.Add(this.txt_total_s, 3, 0);
		this.tableLayoutPanel3.Controls.Add(this.btn_candid_d, 4, 0);
		this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 5);
		this.tableLayoutPanel3.Name = "tableLayoutPanel3";
		this.tableLayoutPanel3.RowCount = 1;
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tableLayoutPanel3.Size = new System.Drawing.Size(1325, 61);
		this.tableLayoutPanel3.TabIndex = 10;
		this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(tableLayoutPanel3_MouseMove);
		this.btn_p.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
		this.btn_p.Dock = System.Windows.Forms.DockStyle.Fill;
		this.btn_p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.btn_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
		this.btn_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_p.Font = new System.Drawing.Font("Unikurd Seyran", 16.2f);
		this.btn_p.ForeColor = System.Drawing.Color.White;
		this.btn_p.Location = new System.Drawing.Point(100, 3);
		this.btn_p.Name = "btn_p";
		this.btn_p.Size = new System.Drawing.Size(265, 55);
		this.btn_p.TabIndex = 183;
		this.btn_p.Text = "کاندید / یەکێتیی";
		this.btn_p.UseVisualStyleBackColor = false;
		this.btn_p.Click += new System.EventHandler(button2_Click);
		this.txt_candid_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_candid_s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_candid_s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txt_candid_s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txt_candid_s.Location = new System.Drawing.Point(3, 3);
		this.txt_candid_s.Multiline = true;
		this.txt_candid_s.Name = "txt_candid_s";
		this.txt_candid_s.ReadOnly = true;
		this.txt_candid_s.Size = new System.Drawing.Size(91, 55);
		this.txt_candid_s.TabIndex = 182;
		this.txt_candid_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txt_total_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_total_s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_total_s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txt_total_s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.txt_total_s.Location = new System.Drawing.Point(397, 3);
		this.txt_total_s.Multiline = true;
		this.txt_total_s.Name = "txt_total_s";
		this.txt_total_s.ReadOnly = true;
		this.txt_total_s.Size = new System.Drawing.Size(108, 55);
		this.txt_total_s.TabIndex = 181;
		this.txt_total_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.btn_candid_d.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.btn_candid_d.Dock = System.Windows.Forms.DockStyle.Fill;
		this.btn_candid_d.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.btn_candid_d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
		this.btn_candid_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_candid_d.Font = new System.Drawing.Font("Unikurd Seyran", 16.2f);
		this.btn_candid_d.ForeColor = System.Drawing.Color.White;
		this.btn_candid_d.Location = new System.Drawing.Point(511, 3);
		this.btn_candid_d.Name = "btn_candid_d";
		this.btn_candid_d.Size = new System.Drawing.Size(811, 55);
		this.btn_candid_d.TabIndex = 185;
		this.btn_candid_d.Text = " لیستی قەوارەکانی پارێزگای سلێمانی ";
		this.btn_candid_d.UseVisualStyleBackColor = false;
		this.btn_candid_d.Click += new System.EventHandler(button4_Click);
		this.tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tableLayoutPanel7.ColumnCount = 11;
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.63942f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.646295f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.028266f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.569901f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.291826f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.479755f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.09855f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.708798f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.250573f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.39725f));
		this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.708798f));
		this.tableLayoutPanel7.Controls.Add(this.s50, 0, 13);
		this.tableLayoutPanel7.Controls.Add(this.s49, 0, 12);
		this.tableLayoutPanel7.Controls.Add(this.s48, 0, 11);
		this.tableLayoutPanel7.Controls.Add(this.s47, 0, 10);
		this.tableLayoutPanel7.Controls.Add(this.s46, 0, 9);
		this.tableLayoutPanel7.Controls.Add(this.s45, 0, 8);
		this.tableLayoutPanel7.Controls.Add(this.label213, 1, 13);
		this.tableLayoutPanel7.Controls.Add(this.label209, 1, 12);
		this.tableLayoutPanel7.Controls.Add(this.label205, 1, 11);
		this.tableLayoutPanel7.Controls.Add(this.label201, 1, 10);
		this.tableLayoutPanel7.Controls.Add(this.label197, 1, 9);
		this.tableLayoutPanel7.Controls.Add(this.label193, 1, 8);
		this.tableLayoutPanel7.Controls.Add(this.label157, 3, 20);
		this.tableLayoutPanel7.Controls.Add(this.label153, 3, 19);
		this.tableLayoutPanel7.Controls.Add(this.label12, 10, 0);
		this.tableLayoutPanel7.Controls.Add(this.s21, 2, 20);
		this.tableLayoutPanel7.Controls.Add(this.s20, 2, 19);
		this.tableLayoutPanel7.Controls.Add(this.label50, 3, 0);
		this.tableLayoutPanel7.Controls.Add(this.s1, 2, 0);
		this.tableLayoutPanel7.Controls.Add(this.s16, 2, 15);
		this.tableLayoutPanel7.Controls.Add(this.s15, 2, 14);
		this.tableLayoutPanel7.Controls.Add(this.s14, 2, 13);
		this.tableLayoutPanel7.Controls.Add(this.s13, 2, 12);
		this.tableLayoutPanel7.Controls.Add(this.s12, 2, 11);
		this.tableLayoutPanel7.Controls.Add(this.s11, 2, 10);
		this.tableLayoutPanel7.Controls.Add(this.s10, 2, 9);
		this.tableLayoutPanel7.Controls.Add(this.s9, 2, 8);
		this.tableLayoutPanel7.Controls.Add(this.label60, 3, 8);
		this.tableLayoutPanel7.Controls.Add(this.label117, 3, 10);
		this.tableLayoutPanel7.Controls.Add(this.label129, 3, 13);
		this.tableLayoutPanel7.Controls.Add(this.label125, 3, 12);
		this.tableLayoutPanel7.Controls.Add(this.label121, 3, 11);
		this.tableLayoutPanel7.Controls.Add(this.label113, 3, 9);
		this.tableLayoutPanel7.Controls.Add(this.label19, 10, 1);
		this.tableLayoutPanel7.Controls.Add(this.s5, 2, 4);
		this.tableLayoutPanel7.Controls.Add(this.label52, 3, 1);
		this.tableLayoutPanel7.Controls.Add(this.s2, 2, 1);
		this.tableLayoutPanel7.Controls.Add(this.s4, 2, 3);
		this.tableLayoutPanel7.Controls.Add(this.label23, 10, 2);
		this.tableLayoutPanel7.Controls.Add(this.s3, 2, 2);
		this.tableLayoutPanel7.Controls.Add(this.label54, 3, 2);
		this.tableLayoutPanel7.Controls.Add(this.label27, 10, 3);
		this.tableLayoutPanel7.Controls.Add(this.label58, 3, 4);
		this.tableLayoutPanel7.Controls.Add(this.label56, 3, 3);
		this.tableLayoutPanel7.Controls.Add(this.label31, 10, 4);
		this.tableLayoutPanel7.Controls.Add(this.label35, 10, 5);
		this.tableLayoutPanel7.Controls.Add(this.label39, 10, 6);
		this.tableLayoutPanel7.Controls.Add(this.s6, 2, 5);
		this.tableLayoutPanel7.Controls.Add(this.s7, 2, 6);
		this.tableLayoutPanel7.Controls.Add(this.s8, 2, 7);
		this.tableLayoutPanel7.Controls.Add(this.label66, 3, 5);
		this.tableLayoutPanel7.Controls.Add(this.label65, 3, 6);
		this.tableLayoutPanel7.Controls.Add(this.label62, 3, 7);
		this.tableLayoutPanel7.Controls.Add(this.label133, 3, 14);
		this.tableLayoutPanel7.Controls.Add(this.label137, 3, 15);
		this.tableLayoutPanel7.Controls.Add(this.label141, 3, 16);
		this.tableLayoutPanel7.Controls.Add(this.label145, 3, 17);
		this.tableLayoutPanel7.Controls.Add(this.label149, 3, 18);
		this.tableLayoutPanel7.Controls.Add(this.s17, 2, 16);
		this.tableLayoutPanel7.Controls.Add(this.s18, 2, 17);
		this.tableLayoutPanel7.Controls.Add(this.s19, 2, 18);
		this.tableLayoutPanel7.Controls.Add(this.label161, 1, 0);
		this.tableLayoutPanel7.Controls.Add(this.s37, 0, 0);
		this.tableLayoutPanel7.Controls.Add(this.label165, 1, 1);
		this.tableLayoutPanel7.Controls.Add(this.s38, 0, 1);
		this.tableLayoutPanel7.Controls.Add(this.label169, 1, 2);
		this.tableLayoutPanel7.Controls.Add(this.s39, 0, 2);
		this.tableLayoutPanel7.Controls.Add(this.label173, 1, 3);
		this.tableLayoutPanel7.Controls.Add(this.s40, 0, 3);
		this.tableLayoutPanel7.Controls.Add(this.label177, 1, 4);
		this.tableLayoutPanel7.Controls.Add(this.s41, 0, 4);
		this.tableLayoutPanel7.Controls.Add(this.label181, 1, 5);
		this.tableLayoutPanel7.Controls.Add(this.s42, 0, 5);
		this.tableLayoutPanel7.Controls.Add(this.label185, 1, 6);
		this.tableLayoutPanel7.Controls.Add(this.s43, 0, 6);
		this.tableLayoutPanel7.Controls.Add(this.label189, 1, 7);
		this.tableLayoutPanel7.Controls.Add(this.s44, 0, 7);
		this.tableLayoutPanel7.Controls.Add(this.label91, 1, 14);
		this.tableLayoutPanel7.Controls.Add(this.s51, 0, 14);
		this.tableLayoutPanel7.Controls.Add(this.label94, 1, 15);
		this.tableLayoutPanel7.Controls.Add(this.label53, 1, 16);
		this.tableLayoutPanel7.Controls.Add(this.label55, 1, 17);
		this.tableLayoutPanel7.Controls.Add(this.label57, 1, 18);
		this.tableLayoutPanel7.Controls.Add(this.label64, 1, 19);
		this.tableLayoutPanel7.Controls.Add(this.s52, 0, 15);
		this.tableLayoutPanel7.Controls.Add(this.s53, 0, 16);
		this.tableLayoutPanel7.Controls.Add(this.s54, 0, 17);
		this.tableLayoutPanel7.Controls.Add(this.s55, 0, 18);
		this.tableLayoutPanel7.Controls.Add(this.s56, 0, 19);
		this.tableLayoutPanel7.Controls.Add(this.s57, 0, 20);
		this.tableLayoutPanel7.Controls.Add(this.s22, 2, 21);
		this.tableLayoutPanel7.Controls.Add(this.s23, 2, 22);
		this.tableLayoutPanel7.Controls.Add(this.s59, 0, 22);
		this.tableLayoutPanel7.Controls.Add(this.s58, 0, 21);
		this.tableLayoutPanel7.Controls.Add(this.s24, 2, 23);
		this.tableLayoutPanel7.Controls.Add(this.s60, 0, 23);
		this.tableLayoutPanel7.Controls.Add(this.s61, 0, 24);
		this.tableLayoutPanel7.Controls.Add(this.s25, 2, 24);
		this.tableLayoutPanel7.Controls.Add(this.s62, 0, 25);
		this.tableLayoutPanel7.Controls.Add(this.s26, 2, 25);
		this.tableLayoutPanel7.Controls.Add(this.s63, 0, 26);
		this.tableLayoutPanel7.Controls.Add(this.s27, 2, 26);
		this.tableLayoutPanel7.Controls.Add(this.s28, 2, 27);
		this.tableLayoutPanel7.Controls.Add(this.s64, 0, 27);
		this.tableLayoutPanel7.Controls.Add(this.s29, 2, 28);
		this.tableLayoutPanel7.Controls.Add(this.s30, 2, 29);
		this.tableLayoutPanel7.Controls.Add(this.s31, 2, 30);
		this.tableLayoutPanel7.Controls.Add(this.s65, 0, 28);
		this.tableLayoutPanel7.Controls.Add(this.s66, 0, 29);
		this.tableLayoutPanel7.Controls.Add(this.s32, 2, 31);
		this.tableLayoutPanel7.Controls.Add(this.s33, 2, 32);
		this.tableLayoutPanel7.Controls.Add(this.s34, 2, 33);
		this.tableLayoutPanel7.Controls.Add(this.s67, 0, 30);
		this.tableLayoutPanel7.Controls.Add(this.s69, 0, 32);
		this.tableLayoutPanel7.Controls.Add(this.s68, 0, 31);
		this.tableLayoutPanel7.Controls.Add(this.s70, 0, 33);
		this.tableLayoutPanel7.Controls.Add(this.s71, 0, 34);
		this.tableLayoutPanel7.Controls.Add(this.s35, 2, 34);
		this.tableLayoutPanel7.Controls.Add(this.s36, 2, 35);
		this.tableLayoutPanel7.Controls.Add(this.s72, 0, 35);
		this.tableLayoutPanel7.Controls.Add(this.s174s, 5, 0);
		this.tableLayoutPanel7.Controls.Add(this.s180s, 5, 1);
		this.tableLayoutPanel7.Controls.Add(this.s182s, 5, 2);
		this.tableLayoutPanel7.Controls.Add(this.s183s, 5, 3);
		this.tableLayoutPanel7.Controls.Add(this.s185s, 5, 4);
		this.tableLayoutPanel7.Controls.Add(this.s190s, 5, 5);
		this.tableLayoutPanel7.Controls.Add(this.s192s, 5, 6);
		this.tableLayoutPanel7.Controls.Add(this.s193s, 5, 7);
		this.tableLayoutPanel7.Controls.Add(this.s194s, 5, 8);
		this.tableLayoutPanel7.Controls.Add(this.s198s, 5, 9);
		this.tableLayoutPanel7.Controls.Add(this.s201s, 5, 10);
		this.tableLayoutPanel7.Controls.Add(this.s207s, 5, 11);
		this.tableLayoutPanel7.Controls.Add(this.s218s, 5, 12);
		this.tableLayoutPanel7.Controls.Add(this.s221s, 5, 13);
		this.tableLayoutPanel7.Controls.Add(this.s226s, 5, 14);
		this.tableLayoutPanel7.Controls.Add(this.s228s, 5, 15);
		this.tableLayoutPanel7.Controls.Add(this.s230s, 5, 16);
		this.tableLayoutPanel7.Controls.Add(this.s231s, 5, 17);
		this.tableLayoutPanel7.Controls.Add(this.s236s, 5, 18);
		this.tableLayoutPanel7.Controls.Add(this.h210, 5, 19);
		this.tableLayoutPanel7.Controls.Add(this.h212, 5, 20);
		this.tableLayoutPanel7.Controls.Add(this.h214, 5, 21);
		this.tableLayoutPanel7.Controls.Add(this.h215, 5, 22);
		this.tableLayoutPanel7.Controls.Add(this.h216, 5, 23);
		this.tableLayoutPanel7.Controls.Add(this.h217, 5, 24);
		this.tableLayoutPanel7.Controls.Add(this.h219, 5, 25);
		this.tableLayoutPanel7.Controls.Add(this.h220, 5, 26);
		this.tableLayoutPanel7.Controls.Add(this.h223, 5, 27);
		this.tableLayoutPanel7.Controls.Add(this.h229, 5, 28);
		this.tableLayoutPanel7.Controls.Add(this.h233, 5, 29);
		this.tableLayoutPanel7.Controls.Add(this.h234, 5, 30);
		this.tableLayoutPanel7.Controls.Add(this.h235, 5, 31);
		this.tableLayoutPanel7.Controls.Add(this.s221, 5, 32);
		this.tableLayoutPanel7.Controls.Add(this.s207, 5, 33);
		this.tableLayoutPanel7.Controls.Add(this.label16, 7, 0);
		this.tableLayoutPanel7.Controls.Add(this.label13, 7, 1);
		this.tableLayoutPanel7.Controls.Add(this.label15, 7, 2);
		this.tableLayoutPanel7.Controls.Add(this.label18, 7, 3);
		this.tableLayoutPanel7.Controls.Add(this.label20, 7, 4);
		this.tableLayoutPanel7.Controls.Add(this.label22, 7, 5);
		this.tableLayoutPanel7.Controls.Add(this.label24, 7, 6);
		this.tableLayoutPanel7.Controls.Add(this.label26, 7, 7);
		this.tableLayoutPanel7.Controls.Add(this.label28, 7, 8);
		this.tableLayoutPanel7.Controls.Add(this.label30, 7, 9);
		this.tableLayoutPanel7.Controls.Add(this.label32, 7, 10);
		this.tableLayoutPanel7.Controls.Add(this.label34, 6, 10);
		this.tableLayoutPanel7.Controls.Add(this.label36, 7, 11);
		this.tableLayoutPanel7.Controls.Add(this.label38, 7, 12);
		this.tableLayoutPanel7.Controls.Add(this.label40, 7, 13);
		this.tableLayoutPanel7.Controls.Add(this.label42, 7, 14);
		this.tableLayoutPanel7.Controls.Add(this.label44, 7, 15);
		this.tableLayoutPanel7.Controls.Add(this.label46, 7, 16);
		this.tableLayoutPanel7.Controls.Add(this.label48, 7, 17);
		this.tableLayoutPanel7.Controls.Add(this.label59, 7, 19);
		this.tableLayoutPanel7.Controls.Add(this.label61, 7, 20);
		this.tableLayoutPanel7.Controls.Add(this.label63, 7, 21);
		this.tableLayoutPanel7.Controls.Add(this.label68, 7, 22);
		this.tableLayoutPanel7.Controls.Add(this.label71, 7, 23);
		this.tableLayoutPanel7.Controls.Add(this.label73, 7, 24);
		this.tableLayoutPanel7.Controls.Add(this.label75, 7, 25);
		this.tableLayoutPanel7.Controls.Add(this.label77, 7, 26);
		this.tableLayoutPanel7.Controls.Add(this.label79, 7, 27);
		this.tableLayoutPanel7.Controls.Add(this.label81, 7, 28);
		this.tableLayoutPanel7.Controls.Add(this.label83, 7, 29);
		this.tableLayoutPanel7.Controls.Add(this.label85, 7, 30);
		this.tableLayoutPanel7.Controls.Add(this.label87, 7, 31);
		this.tableLayoutPanel7.Controls.Add(this.label89, 7, 32);
		this.tableLayoutPanel7.Controls.Add(this.label90, 7, 33);
		this.tableLayoutPanel7.Controls.Add(this.label96, 6, 0);
		this.tableLayoutPanel7.Controls.Add(this.label97, 6, 1);
		this.tableLayoutPanel7.Controls.Add(this.label98, 6, 2);
		this.tableLayoutPanel7.Controls.Add(this.label99, 6, 3);
		this.tableLayoutPanel7.Controls.Add(this.label100, 6, 4);
		this.tableLayoutPanel7.Controls.Add(this.label101, 6, 5);
		this.tableLayoutPanel7.Controls.Add(this.label102, 6, 6);
		this.tableLayoutPanel7.Controls.Add(this.label103, 6, 7);
		this.tableLayoutPanel7.Controls.Add(this.label104, 6, 8);
		this.tableLayoutPanel7.Controls.Add(this.label105, 6, 9);
		this.tableLayoutPanel7.Controls.Add(this.label106, 6, 11);
		this.tableLayoutPanel7.Controls.Add(this.label107, 6, 12);
		this.tableLayoutPanel7.Controls.Add(this.label108, 6, 13);
		this.tableLayoutPanel7.Controls.Add(this.label109, 6, 14);
		this.tableLayoutPanel7.Controls.Add(this.label110, 6, 15);
		this.tableLayoutPanel7.Controls.Add(this.label111, 6, 16);
		this.tableLayoutPanel7.Controls.Add(this.label112, 6, 17);
		this.tableLayoutPanel7.Controls.Add(this.label115, 6, 19);
		this.tableLayoutPanel7.Controls.Add(this.label116, 6, 20);
		this.tableLayoutPanel7.Controls.Add(this.label118, 6, 21);
		this.tableLayoutPanel7.Controls.Add(this.label119, 6, 22);
		this.tableLayoutPanel7.Controls.Add(this.label120, 6, 23);
		this.tableLayoutPanel7.Controls.Add(this.label122, 6, 24);
		this.tableLayoutPanel7.Controls.Add(this.label123, 6, 25);
		this.tableLayoutPanel7.Controls.Add(this.label124, 6, 26);
		this.tableLayoutPanel7.Controls.Add(this.label126, 6, 27);
		this.tableLayoutPanel7.Controls.Add(this.label127, 6, 28);
		this.tableLayoutPanel7.Controls.Add(this.label128, 6, 29);
		this.tableLayoutPanel7.Controls.Add(this.label130, 6, 30);
		this.tableLayoutPanel7.Controls.Add(this.label131, 6, 31);
		this.tableLayoutPanel7.Controls.Add(this.label132, 6, 32);
		this.tableLayoutPanel7.Controls.Add(this.label134, 6, 33);
		this.tableLayoutPanel7.Controls.Add(this.s101s, 8, 0);
		this.tableLayoutPanel7.Controls.Add(this.s104s, 8, 1);
		this.tableLayoutPanel7.Controls.Add(this.s110s, 8, 2);
		this.tableLayoutPanel7.Controls.Add(this.s113s, 8, 3);
		this.tableLayoutPanel7.Controls.Add(this.s114s, 8, 4);
		this.tableLayoutPanel7.Controls.Add(this.s115s, 8, 5);
		this.tableLayoutPanel7.Controls.Add(this.s116s, 8, 6);
		this.tableLayoutPanel7.Controls.Add(this.label29, 9, 0);
		this.tableLayoutPanel7.Controls.Add(this.label33, 9, 1);
		this.tableLayoutPanel7.Controls.Add(this.label37, 9, 2);
		this.tableLayoutPanel7.Controls.Add(this.label41, 9, 3);
		this.tableLayoutPanel7.Controls.Add(this.label45, 9, 4);
		this.tableLayoutPanel7.Controls.Add(this.label67, 9, 5);
		this.tableLayoutPanel7.Controls.Add(this.label70, 9, 6);
		this.tableLayoutPanel7.Controls.Add(this.label170, 3, 21);
		this.tableLayoutPanel7.Controls.Add(this.label171, 1, 20);
		this.tableLayoutPanel7.Controls.Add(this.label172, 1, 21);
		this.tableLayoutPanel7.Controls.Add(this.label174, 1, 22);
		this.tableLayoutPanel7.Controls.Add(this.label175, 1, 23);
		this.tableLayoutPanel7.Controls.Add(this.label176, 1, 24);
		this.tableLayoutPanel7.Controls.Add(this.label178, 1, 25);
		this.tableLayoutPanel7.Controls.Add(this.label179, 1, 26);
		this.tableLayoutPanel7.Controls.Add(this.label180, 1, 27);
		this.tableLayoutPanel7.Controls.Add(this.label182, 1, 28);
		this.tableLayoutPanel7.Controls.Add(this.label183, 1, 29);
		this.tableLayoutPanel7.Controls.Add(this.label184, 3, 22);
		this.tableLayoutPanel7.Controls.Add(this.label186, 3, 23);
		this.tableLayoutPanel7.Controls.Add(this.label187, 3, 24);
		this.tableLayoutPanel7.Controls.Add(this.label188, 3, 25);
		this.tableLayoutPanel7.Controls.Add(this.label190, 3, 26);
		this.tableLayoutPanel7.Controls.Add(this.label191, 3, 27);
		this.tableLayoutPanel7.Controls.Add(this.label192, 3, 28);
		this.tableLayoutPanel7.Controls.Add(this.label194, 3, 29);
		this.tableLayoutPanel7.Controls.Add(this.label195, 3, 30);
		this.tableLayoutPanel7.Controls.Add(this.label196, 3, 31);
		this.tableLayoutPanel7.Controls.Add(this.label198, 3, 32);
		this.tableLayoutPanel7.Controls.Add(this.label199, 3, 33);
		this.tableLayoutPanel7.Controls.Add(this.label200, 3, 34);
		this.tableLayoutPanel7.Controls.Add(this.label202, 3, 35);
		this.tableLayoutPanel7.Controls.Add(this.label203, 1, 35);
		this.tableLayoutPanel7.Controls.Add(this.label204, 1, 34);
		this.tableLayoutPanel7.Controls.Add(this.label206, 1, 33);
		this.tableLayoutPanel7.Controls.Add(this.label207, 1, 32);
		this.tableLayoutPanel7.Controls.Add(this.label208, 1, 31);
		this.tableLayoutPanel7.Controls.Add(this.label210, 1, 30);
		this.tableLayoutPanel7.Controls.Add(this.label47, 10, 7);
		this.tableLayoutPanel7.Controls.Add(this.label78, 9, 7);
		this.tableLayoutPanel7.Controls.Add(this.s117s, 8, 7);
		this.tableLayoutPanel7.Controls.Add(this.label88, 10, 8);
		this.tableLayoutPanel7.Controls.Add(this.label84, 10, 9);
		this.tableLayoutPanel7.Controls.Add(this.label82, 9, 8);
		this.tableLayoutPanel7.Controls.Add(this.s119s, 8, 8);
		this.tableLayoutPanel7.Controls.Add(this.label86, 9, 9);
		this.tableLayoutPanel7.Controls.Add(this.s121s, 8, 9);
		this.tableLayoutPanel7.Controls.Add(this.label80, 10, 10);
		this.tableLayoutPanel7.Controls.Add(this.label136, 9, 10);
		this.tableLayoutPanel7.Controls.Add(this.s122s, 8, 10);
		this.tableLayoutPanel7.Controls.Add(this.label76, 10, 11);
		this.tableLayoutPanel7.Controls.Add(this.label138, 9, 11);
		this.tableLayoutPanel7.Controls.Add(this.s123s, 8, 11);
		this.tableLayoutPanel7.Controls.Add(this.label72, 10, 12);
		this.tableLayoutPanel7.Controls.Add(this.label139, 9, 12);
		this.tableLayoutPanel7.Controls.Add(this.s124s, 8, 12);
		this.tableLayoutPanel7.Controls.Add(this.label69, 10, 13);
		this.tableLayoutPanel7.Controls.Add(this.label140, 9, 13);
		this.tableLayoutPanel7.Controls.Add(this.s125s, 8, 13);
		this.tableLayoutPanel7.Controls.Add(this.label247, 10, 14);
		this.tableLayoutPanel7.Controls.Add(this.label142, 9, 14);
		this.tableLayoutPanel7.Controls.Add(this.s128s, 8, 14);
		this.tableLayoutPanel7.Controls.Add(this.label251, 10, 15);
		this.tableLayoutPanel7.Controls.Add(this.label143, 9, 15);
		this.tableLayoutPanel7.Controls.Add(this.s129s, 8, 15);
		this.tableLayoutPanel7.Controls.Add(this.s130s, 8, 16);
		this.tableLayoutPanel7.Controls.Add(this.label144, 9, 16);
		this.tableLayoutPanel7.Controls.Add(this.label255, 10, 16);
		this.tableLayoutPanel7.Controls.Add(this.label259, 10, 17);
		this.tableLayoutPanel7.Controls.Add(this.label146, 9, 17);
		this.tableLayoutPanel7.Controls.Add(this.s133s, 8, 17);
		this.tableLayoutPanel7.Controls.Add(this.label263, 10, 18);
		this.tableLayoutPanel7.Controls.Add(this.label147, 9, 18);
		this.tableLayoutPanel7.Controls.Add(this.s135s, 8, 18);
		this.tableLayoutPanel7.Controls.Add(this.label267, 10, 19);
		this.tableLayoutPanel7.Controls.Add(this.label148, 9, 19);
		this.tableLayoutPanel7.Controls.Add(this.s136s, 8, 19);
		this.tableLayoutPanel7.Controls.Add(this.label271, 10, 20);
		this.tableLayoutPanel7.Controls.Add(this.label150, 9, 20);
		this.tableLayoutPanel7.Controls.Add(this.s137s, 8, 20);
		this.tableLayoutPanel7.Controls.Add(this.s138s, 8, 21);
		this.tableLayoutPanel7.Controls.Add(this.label151, 9, 21);
		this.tableLayoutPanel7.Controls.Add(this.label275, 10, 21);
		this.tableLayoutPanel7.Controls.Add(this.label279, 10, 22);
		this.tableLayoutPanel7.Controls.Add(this.label152, 9, 22);
		this.tableLayoutPanel7.Controls.Add(this.s145s, 8, 22);
		this.tableLayoutPanel7.Controls.Add(this.s147s, 8, 23);
		this.tableLayoutPanel7.Controls.Add(this.label154, 9, 23);
		this.tableLayoutPanel7.Controls.Add(this.label283, 10, 23);
		this.tableLayoutPanel7.Controls.Add(this.label287, 10, 24);
		this.tableLayoutPanel7.Controls.Add(this.label155, 9, 24);
		this.tableLayoutPanel7.Controls.Add(this.s148s, 8, 24);
		this.tableLayoutPanel7.Controls.Add(this.s153s, 8, 25);
		this.tableLayoutPanel7.Controls.Add(this.label156, 9, 25);
		this.tableLayoutPanel7.Controls.Add(this.label291, 10, 25);
		this.tableLayoutPanel7.Controls.Add(this.label295, 10, 26);
		this.tableLayoutPanel7.Controls.Add(this.label158, 9, 26);
		this.tableLayoutPanel7.Controls.Add(this.s157s, 8, 26);
		this.tableLayoutPanel7.Controls.Add(this.label299, 10, 27);
		this.tableLayoutPanel7.Controls.Add(this.label159, 9, 27);
		this.tableLayoutPanel7.Controls.Add(this.s161s, 8, 27);
		this.tableLayoutPanel7.Controls.Add(this.label303, 10, 28);
		this.tableLayoutPanel7.Controls.Add(this.label160, 9, 28);
		this.tableLayoutPanel7.Controls.Add(this.s162s, 8, 28);
		this.tableLayoutPanel7.Controls.Add(this.label307, 10, 29);
		this.tableLayoutPanel7.Controls.Add(this.label162, 9, 29);
		this.tableLayoutPanel7.Controls.Add(this.s164s, 8, 29);
		this.tableLayoutPanel7.Controls.Add(this.s165s, 8, 30);
		this.tableLayoutPanel7.Controls.Add(this.label163, 9, 30);
		this.tableLayoutPanel7.Controls.Add(this.label311, 10, 30);
		this.tableLayoutPanel7.Controls.Add(this.label14, 10, 31);
		this.tableLayoutPanel7.Controls.Add(this.label17, 10, 32);
		this.tableLayoutPanel7.Controls.Add(this.label21, 10, 33);
		this.tableLayoutPanel7.Controls.Add(this.label25, 10, 34);
		this.tableLayoutPanel7.Controls.Add(this.label164, 9, 31);
		this.tableLayoutPanel7.Controls.Add(this.s166s, 8, 31);
		this.tableLayoutPanel7.Controls.Add(this.label166, 9, 32);
		this.tableLayoutPanel7.Controls.Add(this.s168s, 8, 32);
		this.tableLayoutPanel7.Controls.Add(this.label167, 9, 33);
		this.tableLayoutPanel7.Controls.Add(this.s169s, 8, 33);
		this.tableLayoutPanel7.Controls.Add(this.label168, 9, 34);
		this.tableLayoutPanel7.Controls.Add(this.s171s, 8, 34);
		this.tableLayoutPanel7.Controls.Add(this.label114, 6, 18);
		this.tableLayoutPanel7.Controls.Add(this.label51, 7, 18);
		this.tableLayoutPanel7.Controls.Add(this.lbl_taswit, 4, 2);
		this.tableLayoutPanel7.Controls.Add(this.labljorydangdan, 4, 3);
		this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 69);
		this.tableLayoutPanel7.Name = "tableLayoutPanel7";
		this.tableLayoutPanel7.RowCount = 36;
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777283f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777284f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.781728f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.781728f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.781728f));
		this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.781728f));
		this.tableLayoutPanel7.Size = new System.Drawing.Size(1327, 1955);
		this.tableLayoutPanel7.TabIndex = 0;
		this.s50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s50.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s50.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s50.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s50.Location = new System.Drawing.Point(3, 705);
		this.s50.Multiline = true;
		this.s50.Name = "s50";
		this.s50.Size = new System.Drawing.Size(95, 48);
		this.s50.TabIndex = 121;
		this.s50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s50.Click += new System.EventHandler(d211_Click);
		this.s50.TextChanged += new System.EventHandler(d211_TextChanged);
		this.s50.KeyDown += new System.Windows.Forms.KeyEventHandler(d211_KeyDown);
		this.s50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d211_KeyPress);
		this.s50.Leave += new System.EventHandler(d211_Leave);
		this.s49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s49.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s49.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s49.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s49.Location = new System.Drawing.Point(3, 651);
		this.s49.Multiline = true;
		this.s49.Name = "s49";
		this.s49.Size = new System.Drawing.Size(95, 48);
		this.s49.TabIndex = 120;
		this.s49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s49.Click += new System.EventHandler(d200_Click);
		this.s49.TextChanged += new System.EventHandler(d200_TextChanged);
		this.s49.KeyDown += new System.Windows.Forms.KeyEventHandler(d200_KeyDown);
		this.s49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d200_KeyPress);
		this.s49.Leave += new System.EventHandler(d200_Leave);
		this.s48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s48.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s48.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s48.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s48.Location = new System.Drawing.Point(3, 597);
		this.s48.Multiline = true;
		this.s48.Name = "s48";
		this.s48.Size = new System.Drawing.Size(95, 48);
		this.s48.TabIndex = 119;
		this.s48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s48.Click += new System.EventHandler(d197_Click);
		this.s48.TextChanged += new System.EventHandler(d197_TextChanged);
		this.s48.KeyDown += new System.Windows.Forms.KeyEventHandler(d197_KeyDown);
		this.s48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d197_KeyPress);
		this.s48.Leave += new System.EventHandler(d197_Leave);
		this.s47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s47.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s47.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s47.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s47.Location = new System.Drawing.Point(3, 543);
		this.s47.Multiline = true;
		this.s47.Name = "s47";
		this.s47.Size = new System.Drawing.Size(95, 48);
		this.s47.TabIndex = 118;
		this.s47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s47.Click += new System.EventHandler(d196_Click);
		this.s47.TextChanged += new System.EventHandler(d196_TextChanged);
		this.s47.KeyDown += new System.Windows.Forms.KeyEventHandler(d196_KeyDown);
		this.s47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d196_KeyPress);
		this.s47.Leave += new System.EventHandler(d196_Leave);
		this.s46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s46.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s46.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s46.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s46.Location = new System.Drawing.Point(3, 489);
		this.s46.Multiline = true;
		this.s46.Name = "s46";
		this.s46.Size = new System.Drawing.Size(95, 48);
		this.s46.TabIndex = 117;
		this.s46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s46.Click += new System.EventHandler(d195_Click);
		this.s46.TextChanged += new System.EventHandler(d195_TextChanged);
		this.s46.KeyDown += new System.Windows.Forms.KeyEventHandler(d195_KeyDown);
		this.s46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d195_KeyPress);
		this.s46.Leave += new System.EventHandler(d195_Leave);
		this.s45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s45.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s45.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s45.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s45.Location = new System.Drawing.Point(3, 435);
		this.s45.Multiline = true;
		this.s45.Name = "s45";
		this.s45.Size = new System.Drawing.Size(95, 48);
		this.s45.TabIndex = 116;
		this.s45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s45.Click += new System.EventHandler(d190_Click);
		this.s45.TextChanged += new System.EventHandler(d190_TextChanged);
		this.s45.KeyDown += new System.Windows.Forms.KeyEventHandler(d190_KeyDown);
		this.s45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d190_KeyPress);
		this.s45.Leave += new System.EventHandler(d190_Leave);
		this.label213.AutoSize = true;
		this.label213.BackColor = System.Drawing.Color.Aquamarine;
		this.label213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label213.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label213.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label213.Location = new System.Drawing.Point(104, 702);
		this.label213.Name = "label213";
		this.label213.Size = new System.Drawing.Size(82, 54);
		this.label213.TabIndex = 178;
		this.label213.Text = "50";
		this.label213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label209.AutoSize = true;
		this.label209.BackColor = System.Drawing.Color.Aquamarine;
		this.label209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label209.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label209.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label209.Location = new System.Drawing.Point(104, 648);
		this.label209.Name = "label209";
		this.label209.Size = new System.Drawing.Size(82, 54);
		this.label209.TabIndex = 174;
		this.label209.Text = "49";
		this.label209.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label205.AutoSize = true;
		this.label205.BackColor = System.Drawing.Color.Aquamarine;
		this.label205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label205.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label205.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label205.Location = new System.Drawing.Point(104, 594);
		this.label205.Name = "label205";
		this.label205.Size = new System.Drawing.Size(82, 54);
		this.label205.TabIndex = 170;
		this.label205.Text = "48";
		this.label205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label201.AutoSize = true;
		this.label201.BackColor = System.Drawing.Color.Aquamarine;
		this.label201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label201.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label201.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label201.Location = new System.Drawing.Point(104, 540);
		this.label201.Name = "label201";
		this.label201.Size = new System.Drawing.Size(82, 54);
		this.label201.TabIndex = 166;
		this.label201.Text = "47";
		this.label201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label197.AutoSize = true;
		this.label197.BackColor = System.Drawing.Color.Aquamarine;
		this.label197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label197.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label197.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label197.Location = new System.Drawing.Point(104, 486);
		this.label197.Name = "label197";
		this.label197.Size = new System.Drawing.Size(82, 54);
		this.label197.TabIndex = 162;
		this.label197.Text = "46";
		this.label197.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label193.AutoSize = true;
		this.label193.BackColor = System.Drawing.Color.Aquamarine;
		this.label193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label193.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label193.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label193.Location = new System.Drawing.Point(104, 432);
		this.label193.Name = "label193";
		this.label193.Size = new System.Drawing.Size(82, 54);
		this.label193.TabIndex = 158;
		this.label193.Text = "45";
		this.label193.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label157.AutoSize = true;
		this.label157.BackColor = System.Drawing.Color.Aquamarine;
		this.label157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label157.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label157.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label157.Location = new System.Drawing.Point(285, 1080);
		this.label157.Name = "label157";
		this.label157.Size = new System.Drawing.Size(81, 54);
		this.label157.TabIndex = 122;
		this.label157.Text = "21";
		this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label153.AutoSize = true;
		this.label153.BackColor = System.Drawing.Color.Aquamarine;
		this.label153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label153.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label153.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label153.Location = new System.Drawing.Point(285, 1026);
		this.label153.Name = "label153";
		this.label153.Size = new System.Drawing.Size(81, 54);
		this.label153.TabIndex = 118;
		this.label153.Text = "20";
		this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label12.AutoSize = true;
		this.label12.BackColor = System.Drawing.Color.LightCyan;
		this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label12.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.Location = new System.Drawing.Point(1236, 0);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(88, 54);
		this.label12.TabIndex = 0;
		this.label12.Text = "101";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label12.Click += new System.EventHandler(label12_Click);
		this.s21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s21.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s21.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s21.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s21.Location = new System.Drawing.Point(192, 1083);
		this.s21.Multiline = true;
		this.s21.Name = "s21";
		this.s21.Size = new System.Drawing.Size(87, 48);
		this.s21.TabIndex = 92;
		this.s21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s21.Click += new System.EventHandler(d161_Click);
		this.s21.TextChanged += new System.EventHandler(d161_TextChanged);
		this.s21.KeyDown += new System.Windows.Forms.KeyEventHandler(d161_KeyDown);
		this.s21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d161_KeyPress);
		this.s21.Leave += new System.EventHandler(d161_Leave);
		this.s20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s20.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s20.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s20.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s20.Location = new System.Drawing.Point(192, 1029);
		this.s20.Multiline = true;
		this.s20.Name = "s20";
		this.s20.Size = new System.Drawing.Size(87, 48);
		this.s20.TabIndex = 91;
		this.s20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s20.Click += new System.EventHandler(d159_Click);
		this.s20.TextChanged += new System.EventHandler(d159_TextChanged);
		this.s20.KeyDown += new System.Windows.Forms.KeyEventHandler(d159_KeyDown);
		this.s20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d159_KeyPress);
		this.s20.Leave += new System.EventHandler(d159_Leave);
		this.label50.AutoSize = true;
		this.label50.BackColor = System.Drawing.Color.Aquamarine;
		this.label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label50.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label50.Location = new System.Drawing.Point(285, 0);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(81, 54);
		this.label50.TabIndex = 38;
		this.label50.Text = "1";
		this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s1.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s1.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s1.Location = new System.Drawing.Point(192, 3);
		this.s1.Multiline = true;
		this.s1.Name = "s1";
		this.s1.Size = new System.Drawing.Size(87, 48);
		this.s1.TabIndex = 72;
		this.s1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s1.Click += new System.EventHandler(d107_Click);
		this.s1.TextChanged += new System.EventHandler(d107_TextChanged);
		this.s1.KeyDown += new System.Windows.Forms.KeyEventHandler(d107_KeyDown);
		this.s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d107_KeyPress);
		this.s1.Leave += new System.EventHandler(d107_Leave);
		this.s16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s16.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s16.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s16.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s16.Location = new System.Drawing.Point(192, 813);
		this.s16.Multiline = true;
		this.s16.Name = "s16";
		this.s16.Size = new System.Drawing.Size(87, 48);
		this.s16.TabIndex = 87;
		this.s16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s16.Click += new System.EventHandler(d148_Click);
		this.s16.TextChanged += new System.EventHandler(d148_TextChanged);
		this.s16.KeyDown += new System.Windows.Forms.KeyEventHandler(d148_KeyDown);
		this.s16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d148_KeyPress);
		this.s16.Leave += new System.EventHandler(d148_Leave);
		this.s15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s15.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s15.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s15.Location = new System.Drawing.Point(192, 759);
		this.s15.Multiline = true;
		this.s15.Name = "s15";
		this.s15.Size = new System.Drawing.Size(87, 48);
		this.s15.TabIndex = 86;
		this.s15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s15.Click += new System.EventHandler(d147_Click);
		this.s15.TextChanged += new System.EventHandler(d147_TextChanged);
		this.s15.KeyDown += new System.Windows.Forms.KeyEventHandler(d147_KeyDown);
		this.s15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d147_KeyPress);
		this.s15.Leave += new System.EventHandler(d147_Leave);
		this.s14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s14.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s14.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s14.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s14.Location = new System.Drawing.Point(192, 705);
		this.s14.Multiline = true;
		this.s14.Name = "s14";
		this.s14.Size = new System.Drawing.Size(87, 48);
		this.s14.TabIndex = 85;
		this.s14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s14.Click += new System.EventHandler(d143_Click);
		this.s14.TextChanged += new System.EventHandler(d143_TextChanged);
		this.s14.KeyDown += new System.Windows.Forms.KeyEventHandler(d143_KeyDown);
		this.s14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d143_KeyPress);
		this.s14.Leave += new System.EventHandler(d143_Leave);
		this.s13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s13.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s13.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s13.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s13.Location = new System.Drawing.Point(192, 651);
		this.s13.Multiline = true;
		this.s13.Name = "s13";
		this.s13.Size = new System.Drawing.Size(87, 48);
		this.s13.TabIndex = 84;
		this.s13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s13.Click += new System.EventHandler(d142_Click);
		this.s13.TextChanged += new System.EventHandler(d142_TextChanged);
		this.s13.KeyDown += new System.Windows.Forms.KeyEventHandler(d142_KeyDown);
		this.s13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d142_KeyPress);
		this.s13.Leave += new System.EventHandler(d142_Leave);
		this.s12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s12.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s12.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s12.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s12.Location = new System.Drawing.Point(192, 597);
		this.s12.Multiline = true;
		this.s12.Name = "s12";
		this.s12.Size = new System.Drawing.Size(87, 48);
		this.s12.TabIndex = 83;
		this.s12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s12.Click += new System.EventHandler(d141_Click);
		this.s12.TextChanged += new System.EventHandler(d141_TextChanged);
		this.s12.KeyDown += new System.Windows.Forms.KeyEventHandler(d141_KeyDown);
		this.s12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d141_KeyPress);
		this.s12.Leave += new System.EventHandler(d141_Leave);
		this.s11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s11.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s11.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s11.Location = new System.Drawing.Point(192, 543);
		this.s11.Multiline = true;
		this.s11.Name = "s11";
		this.s11.Size = new System.Drawing.Size(87, 48);
		this.s11.TabIndex = 82;
		this.s11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s11.Click += new System.EventHandler(d140_Click);
		this.s11.TextChanged += new System.EventHandler(d140_TextChanged);
		this.s11.KeyDown += new System.Windows.Forms.KeyEventHandler(d140_KeyDown);
		this.s11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d140_KeyPress);
		this.s11.Leave += new System.EventHandler(d140_Leave);
		this.s10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s10.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s10.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s10.Location = new System.Drawing.Point(192, 489);
		this.s10.Multiline = true;
		this.s10.Name = "s10";
		this.s10.Size = new System.Drawing.Size(87, 48);
		this.s10.TabIndex = 81;
		this.s10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s10.Click += new System.EventHandler(d134_Click);
		this.s10.TextChanged += new System.EventHandler(d134_TextChanged);
		this.s10.KeyDown += new System.Windows.Forms.KeyEventHandler(d134_KeyDown);
		this.s10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d134_KeyPress);
		this.s10.Leave += new System.EventHandler(d134_Leave);
		this.s9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s9.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s9.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s9.Location = new System.Drawing.Point(192, 435);
		this.s9.Multiline = true;
		this.s9.Name = "s9";
		this.s9.Size = new System.Drawing.Size(87, 48);
		this.s9.TabIndex = 80;
		this.s9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s9.Click += new System.EventHandler(d133_Click);
		this.s9.TextChanged += new System.EventHandler(d133_TextChanged);
		this.s9.KeyDown += new System.Windows.Forms.KeyEventHandler(d133_KeyDown);
		this.s9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d133_KeyPress);
		this.s9.Leave += new System.EventHandler(d133_Leave);
		this.label60.AutoSize = true;
		this.label60.BackColor = System.Drawing.Color.Aquamarine;
		this.label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label60.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label60.Location = new System.Drawing.Point(285, 432);
		this.label60.Name = "label60";
		this.label60.Size = new System.Drawing.Size(81, 54);
		this.label60.TabIndex = 48;
		this.label60.Text = "9";
		this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label117.AutoSize = true;
		this.label117.BackColor = System.Drawing.Color.Aquamarine;
		this.label117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label117.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label117.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label117.Location = new System.Drawing.Point(285, 540);
		this.label117.Name = "label117";
		this.label117.Size = new System.Drawing.Size(81, 54);
		this.label117.TabIndex = 82;
		this.label117.Text = "11";
		this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label129.AutoSize = true;
		this.label129.BackColor = System.Drawing.Color.Aquamarine;
		this.label129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label129.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label129.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label129.Location = new System.Drawing.Point(285, 702);
		this.label129.Name = "label129";
		this.label129.Size = new System.Drawing.Size(81, 54);
		this.label129.TabIndex = 94;
		this.label129.Text = "14";
		this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label125.AutoSize = true;
		this.label125.BackColor = System.Drawing.Color.Aquamarine;
		this.label125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label125.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label125.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label125.Location = new System.Drawing.Point(285, 648);
		this.label125.Name = "label125";
		this.label125.Size = new System.Drawing.Size(81, 54);
		this.label125.TabIndex = 90;
		this.label125.Text = "13";
		this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label121.AutoSize = true;
		this.label121.BackColor = System.Drawing.Color.Aquamarine;
		this.label121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label121.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label121.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label121.Location = new System.Drawing.Point(285, 594);
		this.label121.Name = "label121";
		this.label121.Size = new System.Drawing.Size(81, 54);
		this.label121.TabIndex = 86;
		this.label121.Text = "12";
		this.label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label113.AutoSize = true;
		this.label113.BackColor = System.Drawing.Color.Aquamarine;
		this.label113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label113.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label113.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label113.Location = new System.Drawing.Point(285, 486);
		this.label113.Name = "label113";
		this.label113.Size = new System.Drawing.Size(81, 54);
		this.label113.TabIndex = 78;
		this.label113.Text = "10";
		this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.AutoSize = true;
		this.label19.BackColor = System.Drawing.Color.LightCyan;
		this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label19.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label19.Location = new System.Drawing.Point(1236, 54);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(88, 54);
		this.label19.TabIndex = 7;
		this.label19.Text = "104";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.Click += new System.EventHandler(label19_Click);
		this.s5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s5.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s5.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s5.Location = new System.Drawing.Point(192, 219);
		this.s5.Multiline = true;
		this.s5.Name = "s5";
		this.s5.Size = new System.Drawing.Size(87, 48);
		this.s5.TabIndex = 76;
		this.s5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s5.Click += new System.EventHandler(d126_Click);
		this.s5.TextChanged += new System.EventHandler(d126_TextChanged);
		this.s5.KeyDown += new System.Windows.Forms.KeyEventHandler(d126_KeyDown);
		this.s5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d126_KeyPress);
		this.s5.Leave += new System.EventHandler(d126_Leave);
		this.label52.AutoSize = true;
		this.label52.BackColor = System.Drawing.Color.Aquamarine;
		this.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label52.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label52.Location = new System.Drawing.Point(285, 54);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(81, 54);
		this.label52.TabIndex = 40;
		this.label52.Text = "2";
		this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s2.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s2.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s2.Location = new System.Drawing.Point(192, 57);
		this.s2.Multiline = true;
		this.s2.Name = "s2";
		this.s2.Size = new System.Drawing.Size(87, 48);
		this.s2.TabIndex = 73;
		this.s2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s2.Click += new System.EventHandler(d108_Click);
		this.s2.TextChanged += new System.EventHandler(d108_TextChanged);
		this.s2.KeyDown += new System.Windows.Forms.KeyEventHandler(d108_KeyDown);
		this.s2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d108_KeyPress);
		this.s2.Leave += new System.EventHandler(d108_Leave);
		this.s4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s4.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s4.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s4.Location = new System.Drawing.Point(192, 165);
		this.s4.Multiline = true;
		this.s4.Name = "s4";
		this.s4.Size = new System.Drawing.Size(87, 48);
		this.s4.TabIndex = 75;
		this.s4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s4.Click += new System.EventHandler(d118_Click);
		this.s4.TextChanged += new System.EventHandler(d118_TextChanged);
		this.s4.KeyDown += new System.Windows.Forms.KeyEventHandler(d118_KeyDown);
		this.s4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d118_KeyPress);
		this.s4.Leave += new System.EventHandler(d118_Leave);
		this.label23.AutoSize = true;
		this.label23.BackColor = System.Drawing.Color.LightCyan;
		this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label23.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label23.Location = new System.Drawing.Point(1236, 108);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(88, 54);
		this.label23.TabIndex = 11;
		this.label23.Text = "110";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label23.Click += new System.EventHandler(label23_Click);
		this.s3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s3.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s3.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s3.Location = new System.Drawing.Point(192, 111);
		this.s3.Multiline = true;
		this.s3.Name = "s3";
		this.s3.Size = new System.Drawing.Size(87, 48);
		this.s3.TabIndex = 74;
		this.s3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s3.Click += new System.EventHandler(d114_Click);
		this.s3.TextChanged += new System.EventHandler(d114_TextChanged);
		this.s3.KeyDown += new System.Windows.Forms.KeyEventHandler(d114_KeyDown);
		this.s3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d114_KeyPress);
		this.s3.Leave += new System.EventHandler(d114_Leave);
		this.label54.AutoSize = true;
		this.label54.BackColor = System.Drawing.Color.Aquamarine;
		this.label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label54.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label54.Location = new System.Drawing.Point(285, 108);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(81, 54);
		this.label54.TabIndex = 42;
		this.label54.Text = "3";
		this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label27.AutoSize = true;
		this.label27.BackColor = System.Drawing.Color.LightCyan;
		this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label27.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label27.Location = new System.Drawing.Point(1236, 162);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(88, 54);
		this.label27.TabIndex = 15;
		this.label27.Text = "113";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label27.Click += new System.EventHandler(label27_Click);
		this.label58.AutoSize = true;
		this.label58.BackColor = System.Drawing.Color.Aquamarine;
		this.label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label58.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label58.Location = new System.Drawing.Point(285, 216);
		this.label58.Name = "label58";
		this.label58.Size = new System.Drawing.Size(81, 54);
		this.label58.TabIndex = 46;
		this.label58.Text = "5";
		this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label56.AutoSize = true;
		this.label56.BackColor = System.Drawing.Color.Aquamarine;
		this.label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label56.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label56.Location = new System.Drawing.Point(285, 162);
		this.label56.Name = "label56";
		this.label56.Size = new System.Drawing.Size(81, 54);
		this.label56.TabIndex = 44;
		this.label56.Text = "4";
		this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label31.AutoSize = true;
		this.label31.BackColor = System.Drawing.Color.LightCyan;
		this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label31.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label31.Location = new System.Drawing.Point(1236, 216);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(88, 54);
		this.label31.TabIndex = 19;
		this.label31.Text = "114";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label31.Click += new System.EventHandler(label31_Click);
		this.label35.AutoSize = true;
		this.label35.BackColor = System.Drawing.Color.LightCyan;
		this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label35.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label35.Location = new System.Drawing.Point(1236, 270);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(88, 54);
		this.label35.TabIndex = 23;
		this.label35.Text = "115";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label35.Click += new System.EventHandler(label35_Click);
		this.label39.AutoSize = true;
		this.label39.BackColor = System.Drawing.Color.LightCyan;
		this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label39.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label39.Location = new System.Drawing.Point(1236, 324);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(88, 54);
		this.label39.TabIndex = 27;
		this.label39.Text = "116";
		this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s6.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s6.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s6.Location = new System.Drawing.Point(192, 273);
		this.s6.Multiline = true;
		this.s6.Name = "s6";
		this.s6.Size = new System.Drawing.Size(87, 48);
		this.s6.TabIndex = 77;
		this.s6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s6.Click += new System.EventHandler(d127_Click);
		this.s6.TextChanged += new System.EventHandler(d127_TextChanged);
		this.s6.KeyDown += new System.Windows.Forms.KeyEventHandler(d127_KeyDown);
		this.s6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d127_KeyPress);
		this.s6.Leave += new System.EventHandler(d127_Leave);
		this.s7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s7.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s7.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s7.Location = new System.Drawing.Point(192, 327);
		this.s7.Multiline = true;
		this.s7.Name = "s7";
		this.s7.Size = new System.Drawing.Size(87, 48);
		this.s7.TabIndex = 78;
		this.s7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s7.Click += new System.EventHandler(d129_Click);
		this.s7.TextChanged += new System.EventHandler(d129_TextChanged);
		this.s7.KeyDown += new System.Windows.Forms.KeyEventHandler(d129_KeyDown);
		this.s7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d129_KeyPress);
		this.s7.Leave += new System.EventHandler(d129_Leave);
		this.s8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s8.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s8.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s8.Location = new System.Drawing.Point(192, 381);
		this.s8.Multiline = true;
		this.s8.Name = "s8";
		this.s8.Size = new System.Drawing.Size(87, 48);
		this.s8.TabIndex = 79;
		this.s8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s8.Click += new System.EventHandler(d132_Click);
		this.s8.TextChanged += new System.EventHandler(d132_TextChanged);
		this.s8.KeyDown += new System.Windows.Forms.KeyEventHandler(d132_KeyDown);
		this.s8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d132_KeyPress);
		this.s8.Leave += new System.EventHandler(d132_Leave);
		this.label66.AutoSize = true;
		this.label66.BackColor = System.Drawing.Color.Aquamarine;
		this.label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label66.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label66.Location = new System.Drawing.Point(285, 270);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(81, 54);
		this.label66.TabIndex = 54;
		this.label66.Text = "6";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label65.AutoSize = true;
		this.label65.BackColor = System.Drawing.Color.Aquamarine;
		this.label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label65.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label65.Location = new System.Drawing.Point(285, 324);
		this.label65.Name = "label65";
		this.label65.Size = new System.Drawing.Size(81, 54);
		this.label65.TabIndex = 53;
		this.label65.Text = "7";
		this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label62.AutoSize = true;
		this.label62.BackColor = System.Drawing.Color.Aquamarine;
		this.label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label62.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label62.Location = new System.Drawing.Point(285, 378);
		this.label62.Name = "label62";
		this.label62.Size = new System.Drawing.Size(81, 54);
		this.label62.TabIndex = 50;
		this.label62.Text = "8";
		this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label133.AutoSize = true;
		this.label133.BackColor = System.Drawing.Color.Aquamarine;
		this.label133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label133.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label133.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label133.Location = new System.Drawing.Point(285, 756);
		this.label133.Name = "label133";
		this.label133.Size = new System.Drawing.Size(81, 54);
		this.label133.TabIndex = 98;
		this.label133.Text = "15";
		this.label133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label137.AutoSize = true;
		this.label137.BackColor = System.Drawing.Color.Aquamarine;
		this.label137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label137.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label137.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label137.Location = new System.Drawing.Point(285, 810);
		this.label137.Name = "label137";
		this.label137.Size = new System.Drawing.Size(81, 54);
		this.label137.TabIndex = 102;
		this.label137.Text = "16";
		this.label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label141.AutoSize = true;
		this.label141.BackColor = System.Drawing.Color.Aquamarine;
		this.label141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label141.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label141.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label141.Location = new System.Drawing.Point(285, 864);
		this.label141.Name = "label141";
		this.label141.Size = new System.Drawing.Size(81, 54);
		this.label141.TabIndex = 106;
		this.label141.Text = "17";
		this.label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label145.AutoSize = true;
		this.label145.BackColor = System.Drawing.Color.Aquamarine;
		this.label145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label145.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label145.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label145.Location = new System.Drawing.Point(285, 918);
		this.label145.Name = "label145";
		this.label145.Size = new System.Drawing.Size(81, 54);
		this.label145.TabIndex = 110;
		this.label145.Text = "18";
		this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label149.AutoSize = true;
		this.label149.BackColor = System.Drawing.Color.Aquamarine;
		this.label149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label149.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label149.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label149.Location = new System.Drawing.Point(285, 972);
		this.label149.Name = "label149";
		this.label149.Size = new System.Drawing.Size(81, 54);
		this.label149.TabIndex = 114;
		this.label149.Text = "19";
		this.label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s17.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s17.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s17.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s17.Location = new System.Drawing.Point(192, 867);
		this.s17.Multiline = true;
		this.s17.Name = "s17";
		this.s17.Size = new System.Drawing.Size(87, 48);
		this.s17.TabIndex = 88;
		this.s17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s17.Click += new System.EventHandler(d152_Click);
		this.s17.TextChanged += new System.EventHandler(d152_TextChanged);
		this.s17.KeyDown += new System.Windows.Forms.KeyEventHandler(d152_KeyDown);
		this.s17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d152_KeyPress);
		this.s17.Leave += new System.EventHandler(d152_Leave);
		this.s18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s18.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s18.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s18.Location = new System.Drawing.Point(192, 921);
		this.s18.Multiline = true;
		this.s18.Name = "s18";
		this.s18.Size = new System.Drawing.Size(87, 48);
		this.s18.TabIndex = 89;
		this.s18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s18.Click += new System.EventHandler(d155_Click);
		this.s18.TextChanged += new System.EventHandler(d155_TextChanged);
		this.s18.KeyDown += new System.Windows.Forms.KeyEventHandler(d155_KeyDown);
		this.s18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d155_KeyPress);
		this.s18.Leave += new System.EventHandler(d155_Leave);
		this.s19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s19.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s19.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s19.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s19.Location = new System.Drawing.Point(192, 975);
		this.s19.Multiline = true;
		this.s19.Name = "s19";
		this.s19.Size = new System.Drawing.Size(87, 48);
		this.s19.TabIndex = 90;
		this.s19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s19.Click += new System.EventHandler(d157_Click);
		this.s19.TextChanged += new System.EventHandler(d157_TextChanged);
		this.s19.KeyDown += new System.Windows.Forms.KeyEventHandler(d157_KeyDown);
		this.s19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d157_KeyPress);
		this.s19.Leave += new System.EventHandler(d157_Leave);
		this.label161.AutoSize = true;
		this.label161.BackColor = System.Drawing.Color.Aquamarine;
		this.label161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label161.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label161.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label161.Location = new System.Drawing.Point(104, 0);
		this.label161.Name = "label161";
		this.label161.Size = new System.Drawing.Size(82, 54);
		this.label161.TabIndex = 126;
		this.label161.Text = "37";
		this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s37.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s37.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s37.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s37.Location = new System.Drawing.Point(3, 3);
		this.s37.Multiline = true;
		this.s37.Name = "s37";
		this.s37.Size = new System.Drawing.Size(95, 48);
		this.s37.TabIndex = 108;
		this.s37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s37.Click += new System.EventHandler(d162_Click);
		this.s37.TextChanged += new System.EventHandler(d162_TextChanged);
		this.s37.KeyDown += new System.Windows.Forms.KeyEventHandler(d162_KeyDown);
		this.s37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d162_KeyPress);
		this.s37.Leave += new System.EventHandler(d162_Leave);
		this.label165.AutoSize = true;
		this.label165.BackColor = System.Drawing.Color.Aquamarine;
		this.label165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label165.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label165.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label165.Location = new System.Drawing.Point(104, 54);
		this.label165.Name = "label165";
		this.label165.Size = new System.Drawing.Size(82, 54);
		this.label165.TabIndex = 130;
		this.label165.Text = "38";
		this.label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s38.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s38.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s38.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s38.Location = new System.Drawing.Point(3, 57);
		this.s38.Multiline = true;
		this.s38.Name = "s38";
		this.s38.Size = new System.Drawing.Size(95, 48);
		this.s38.TabIndex = 109;
		this.s38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s38.Click += new System.EventHandler(d163_Click);
		this.s38.TextChanged += new System.EventHandler(d163_TextChanged);
		this.s38.KeyDown += new System.Windows.Forms.KeyEventHandler(d163_KeyDown);
		this.s38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d163_KeyPress);
		this.s38.Leave += new System.EventHandler(d163_Leave);
		this.label169.AutoSize = true;
		this.label169.BackColor = System.Drawing.Color.Aquamarine;
		this.label169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label169.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label169.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label169.Location = new System.Drawing.Point(104, 108);
		this.label169.Name = "label169";
		this.label169.Size = new System.Drawing.Size(82, 54);
		this.label169.TabIndex = 134;
		this.label169.Text = "39";
		this.label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s39.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s39.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s39.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s39.Location = new System.Drawing.Point(3, 111);
		this.s39.Multiline = true;
		this.s39.Name = "s39";
		this.s39.Size = new System.Drawing.Size(95, 48);
		this.s39.TabIndex = 110;
		this.s39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s39.Click += new System.EventHandler(d164_Click);
		this.s39.TextChanged += new System.EventHandler(d164_TextChanged);
		this.s39.KeyDown += new System.Windows.Forms.KeyEventHandler(d164_KeyDown);
		this.s39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d164_KeyPress);
		this.s39.Leave += new System.EventHandler(d164_Leave);
		this.label173.AutoSize = true;
		this.label173.BackColor = System.Drawing.Color.Aquamarine;
		this.label173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label173.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label173.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label173.Location = new System.Drawing.Point(104, 162);
		this.label173.Name = "label173";
		this.label173.Size = new System.Drawing.Size(82, 54);
		this.label173.TabIndex = 138;
		this.label173.Text = "40";
		this.label173.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s40.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s40.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s40.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s40.Location = new System.Drawing.Point(3, 165);
		this.s40.Multiline = true;
		this.s40.Name = "s40";
		this.s40.Size = new System.Drawing.Size(95, 48);
		this.s40.TabIndex = 111;
		this.s40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s40.Click += new System.EventHandler(d169_Click);
		this.s40.TextChanged += new System.EventHandler(d169_TextChanged);
		this.s40.KeyDown += new System.Windows.Forms.KeyEventHandler(d169_KeyDown);
		this.s40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d169_KeyPress);
		this.s40.Leave += new System.EventHandler(d169_Leave);
		this.label177.AutoSize = true;
		this.label177.BackColor = System.Drawing.Color.Aquamarine;
		this.label177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label177.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label177.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label177.Location = new System.Drawing.Point(104, 216);
		this.label177.Name = "label177";
		this.label177.Size = new System.Drawing.Size(82, 54);
		this.label177.TabIndex = 142;
		this.label177.Text = "41";
		this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s41.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s41.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s41.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s41.Location = new System.Drawing.Point(3, 219);
		this.s41.Multiline = true;
		this.s41.Name = "s41";
		this.s41.Size = new System.Drawing.Size(95, 48);
		this.s41.TabIndex = 112;
		this.s41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s41.Click += new System.EventHandler(d175_Click);
		this.s41.TextChanged += new System.EventHandler(d175_TextChanged);
		this.s41.KeyDown += new System.Windows.Forms.KeyEventHandler(d175_KeyDown);
		this.s41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d175_KeyPress);
		this.s41.Leave += new System.EventHandler(d175_Leave);
		this.label181.AutoSize = true;
		this.label181.BackColor = System.Drawing.Color.Aquamarine;
		this.label181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label181.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label181.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label181.Location = new System.Drawing.Point(104, 270);
		this.label181.Name = "label181";
		this.label181.Size = new System.Drawing.Size(82, 54);
		this.label181.TabIndex = 146;
		this.label181.Text = "42";
		this.label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s42.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s42.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s42.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s42.Location = new System.Drawing.Point(3, 273);
		this.s42.Multiline = true;
		this.s42.Name = "s42";
		this.s42.Size = new System.Drawing.Size(95, 48);
		this.s42.TabIndex = 113;
		this.s42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s42.Click += new System.EventHandler(d177_Click);
		this.s42.TextChanged += new System.EventHandler(d177_TextChanged);
		this.s42.KeyDown += new System.Windows.Forms.KeyEventHandler(d177_KeyDown);
		this.s42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d177_KeyPress);
		this.s42.Leave += new System.EventHandler(d177_Leave);
		this.label185.AutoSize = true;
		this.label185.BackColor = System.Drawing.Color.Aquamarine;
		this.label185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label185.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label185.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label185.Location = new System.Drawing.Point(104, 324);
		this.label185.Name = "label185";
		this.label185.Size = new System.Drawing.Size(82, 54);
		this.label185.TabIndex = 150;
		this.label185.Text = "43";
		this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s43.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s43.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s43.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s43.Location = new System.Drawing.Point(3, 327);
		this.s43.Multiline = true;
		this.s43.Name = "s43";
		this.s43.Size = new System.Drawing.Size(95, 48);
		this.s43.TabIndex = 114;
		this.s43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s43.Click += new System.EventHandler(d186_Click);
		this.s43.TextChanged += new System.EventHandler(d186_TextChanged);
		this.s43.KeyDown += new System.Windows.Forms.KeyEventHandler(d186_KeyDown);
		this.s43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d186_KeyPress);
		this.s43.Leave += new System.EventHandler(d186_Leave);
		this.label189.AutoSize = true;
		this.label189.BackColor = System.Drawing.Color.Aquamarine;
		this.label189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label189.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label189.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label189.Location = new System.Drawing.Point(104, 378);
		this.label189.Name = "label189";
		this.label189.Size = new System.Drawing.Size(82, 54);
		this.label189.TabIndex = 154;
		this.label189.Text = "44";
		this.label189.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s44.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s44.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s44.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s44.Location = new System.Drawing.Point(3, 381);
		this.s44.Multiline = true;
		this.s44.Name = "s44";
		this.s44.Size = new System.Drawing.Size(95, 48);
		this.s44.TabIndex = 115;
		this.s44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s44.Click += new System.EventHandler(d188_Click);
		this.s44.TextChanged += new System.EventHandler(d188_TextChanged);
		this.s44.KeyDown += new System.Windows.Forms.KeyEventHandler(d188_KeyDown);
		this.s44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d188_KeyPress);
		this.s44.Leave += new System.EventHandler(d188_Leave);
		this.label91.AutoSize = true;
		this.label91.BackColor = System.Drawing.Color.Aquamarine;
		this.label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label91.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label91.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label91.Location = new System.Drawing.Point(104, 756);
		this.label91.Name = "label91";
		this.label91.Size = new System.Drawing.Size(82, 54);
		this.label91.TabIndex = 56;
		this.label91.Text = "51";
		this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s51.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s51.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s51.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s51.Location = new System.Drawing.Point(3, 759);
		this.s51.Multiline = true;
		this.s51.Name = "s51";
		this.s51.Size = new System.Drawing.Size(95, 48);
		this.s51.TabIndex = 122;
		this.s51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s51.Click += new System.EventHandler(d213_Click);
		this.s51.TextChanged += new System.EventHandler(d213_TextChanged);
		this.s51.KeyDown += new System.Windows.Forms.KeyEventHandler(d213_KeyDown);
		this.s51.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d213_KeyPress);
		this.s51.Leave += new System.EventHandler(d213_Leave);
		this.label94.AutoSize = true;
		this.label94.BackColor = System.Drawing.Color.Aquamarine;
		this.label94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label94.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label94.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label94.Location = new System.Drawing.Point(104, 810);
		this.label94.Name = "label94";
		this.label94.Size = new System.Drawing.Size(82, 54);
		this.label94.TabIndex = 59;
		this.label94.Text = "52";
		this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label53.AutoSize = true;
		this.label53.BackColor = System.Drawing.Color.Aquamarine;
		this.label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label53.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label53.Location = new System.Drawing.Point(104, 864);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(82, 54);
		this.label53.TabIndex = 41;
		this.label53.Text = "53";
		this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label55.AutoSize = true;
		this.label55.BackColor = System.Drawing.Color.Aquamarine;
		this.label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label55.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label55.Location = new System.Drawing.Point(104, 918);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(82, 54);
		this.label55.TabIndex = 43;
		this.label55.Text = "54";
		this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label57.AutoSize = true;
		this.label57.BackColor = System.Drawing.Color.Aquamarine;
		this.label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label57.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label57.Location = new System.Drawing.Point(104, 972);
		this.label57.Name = "label57";
		this.label57.Size = new System.Drawing.Size(82, 54);
		this.label57.TabIndex = 45;
		this.label57.Text = "55";
		this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label64.AutoSize = true;
		this.label64.BackColor = System.Drawing.Color.Aquamarine;
		this.label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label64.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label64.Location = new System.Drawing.Point(104, 1026);
		this.label64.Name = "label64";
		this.label64.Size = new System.Drawing.Size(82, 54);
		this.label64.TabIndex = 52;
		this.label64.Text = "56";
		this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s52.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s52.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s52.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s52.Location = new System.Drawing.Point(3, 813);
		this.s52.Multiline = true;
		this.s52.Name = "s52";
		this.s52.Size = new System.Drawing.Size(95, 48);
		this.s52.TabIndex = 123;
		this.s52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s52.Click += new System.EventHandler(d222_Click);
		this.s52.TextChanged += new System.EventHandler(d222_TextChanged);
		this.s52.KeyDown += new System.Windows.Forms.KeyEventHandler(d222_KeyDown);
		this.s52.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d222_KeyPress);
		this.s52.Leave += new System.EventHandler(d222_Leave);
		this.s53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s53.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s53.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s53.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s53.Location = new System.Drawing.Point(3, 867);
		this.s53.Multiline = true;
		this.s53.Name = "s53";
		this.s53.Size = new System.Drawing.Size(95, 48);
		this.s53.TabIndex = 124;
		this.s53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s53.Click += new System.EventHandler(d224_Click);
		this.s53.TextChanged += new System.EventHandler(d224_TextChanged);
		this.s53.KeyDown += new System.Windows.Forms.KeyEventHandler(d224_KeyDown);
		this.s53.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d224_KeyPress);
		this.s53.Leave += new System.EventHandler(d224_Leave);
		this.s54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s54.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s54.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s54.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s54.Location = new System.Drawing.Point(3, 921);
		this.s54.Multiline = true;
		this.s54.Name = "s54";
		this.s54.Size = new System.Drawing.Size(95, 48);
		this.s54.TabIndex = 125;
		this.s54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s54.Click += new System.EventHandler(d225_Click);
		this.s54.TextChanged += new System.EventHandler(d225_TextChanged);
		this.s54.KeyDown += new System.Windows.Forms.KeyEventHandler(d225_KeyDown);
		this.s54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d225_KeyPress);
		this.s54.Leave += new System.EventHandler(d225_Leave);
		this.s55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s55.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s55.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s55.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s55.Location = new System.Drawing.Point(3, 975);
		this.s55.Multiline = true;
		this.s55.Name = "s55";
		this.s55.Size = new System.Drawing.Size(95, 48);
		this.s55.TabIndex = 126;
		this.s55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s55.Click += new System.EventHandler(d227_Click);
		this.s55.TextChanged += new System.EventHandler(d227_TextChanged);
		this.s55.KeyDown += new System.Windows.Forms.KeyEventHandler(d227_KeyDown);
		this.s55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d227_KeyPress);
		this.s55.Leave += new System.EventHandler(d227_Leave);
		this.s56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s56.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s56.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s56.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s56.Location = new System.Drawing.Point(3, 1029);
		this.s56.Multiline = true;
		this.s56.Name = "s56";
		this.s56.Size = new System.Drawing.Size(95, 48);
		this.s56.TabIndex = 127;
		this.s56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s56.Click += new System.EventHandler(d232_Click);
		this.s56.TextChanged += new System.EventHandler(d232_TextChanged);
		this.s56.KeyDown += new System.Windows.Forms.KeyEventHandler(d232_KeyDown);
		this.s56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(d232_KeyPress);
		this.s56.Leave += new System.EventHandler(d232_Leave);
		this.s57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s57.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s57.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s57.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s57.Location = new System.Drawing.Point(3, 1083);
		this.s57.Multiline = true;
		this.s57.Name = "s57";
		this.s57.Size = new System.Drawing.Size(95, 48);
		this.s57.TabIndex = 128;
		this.s57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s57.Click += new System.EventHandler(s201_Click);
		this.s57.TextChanged += new System.EventHandler(s201_TextChanged);
		this.s57.KeyDown += new System.Windows.Forms.KeyEventHandler(s201_KeyDown);
		this.s57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s201_KeyPress);
		this.s57.Leave += new System.EventHandler(s201_Leave);
		this.s22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s22.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s22.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s22.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s22.Location = new System.Drawing.Point(192, 1137);
		this.s22.Multiline = true;
		this.s22.Name = "s22";
		this.s22.Size = new System.Drawing.Size(87, 48);
		this.s22.TabIndex = 93;
		this.s22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s22.Click += new System.EventHandler(s226_Click);
		this.s22.TextChanged += new System.EventHandler(s226_TextChanged);
		this.s22.KeyDown += new System.Windows.Forms.KeyEventHandler(s226_KeyDown);
		this.s22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s226_KeyPress);
		this.s22.Leave += new System.EventHandler(s226_Leave);
		this.s23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s23.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s23.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s23.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s23.Location = new System.Drawing.Point(192, 1191);
		this.s23.Multiline = true;
		this.s23.Name = "s23";
		this.s23.Size = new System.Drawing.Size(87, 48);
		this.s23.TabIndex = 94;
		this.s23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s23.Click += new System.EventHandler(s236_Click);
		this.s23.TextChanged += new System.EventHandler(s236_TextChanged);
		this.s23.KeyDown += new System.Windows.Forms.KeyEventHandler(s236_KeyDown);
		this.s23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s236_KeyPress);
		this.s23.Leave += new System.EventHandler(s236_Leave);
		this.s59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s59.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s59.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s59.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s59.Location = new System.Drawing.Point(3, 1191);
		this.s59.Multiline = true;
		this.s59.Name = "s59";
		this.s59.Size = new System.Drawing.Size(95, 48);
		this.s59.TabIndex = 130;
		this.s59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s59.Click += new System.EventHandler(s145_Click);
		this.s59.TextChanged += new System.EventHandler(s145_TextChanged);
		this.s59.KeyDown += new System.Windows.Forms.KeyEventHandler(s145_KeyDown);
		this.s59.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s145_KeyPress);
		this.s59.Leave += new System.EventHandler(s145_Leave);
		this.s58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s58.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s58.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s58.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s58.Location = new System.Drawing.Point(3, 1137);
		this.s58.Multiline = true;
		this.s58.Name = "s58";
		this.s58.Size = new System.Drawing.Size(95, 48);
		this.s58.TabIndex = 129;
		this.s58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s58.Click += new System.EventHandler(s147_Click);
		this.s58.TextChanged += new System.EventHandler(s147_TextChanged);
		this.s58.KeyDown += new System.Windows.Forms.KeyEventHandler(s147_KeyDown);
		this.s58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s147_KeyPress);
		this.s58.Leave += new System.EventHandler(s147_Leave);
		this.s24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s24.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s24.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s24.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s24.Location = new System.Drawing.Point(192, 1245);
		this.s24.Multiline = true;
		this.s24.Name = "s24";
		this.s24.Size = new System.Drawing.Size(87, 48);
		this.s24.TabIndex = 95;
		this.s24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s24.Click += new System.EventHandler(s148_Click);
		this.s24.TextChanged += new System.EventHandler(s148_TextChanged);
		this.s24.KeyDown += new System.Windows.Forms.KeyEventHandler(s148_KeyDown);
		this.s24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s148_KeyPress);
		this.s24.Leave += new System.EventHandler(s148_Leave);
		this.s60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s60.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s60.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s60.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s60.Location = new System.Drawing.Point(3, 1245);
		this.s60.Multiline = true;
		this.s60.Name = "s60";
		this.s60.Size = new System.Drawing.Size(95, 48);
		this.s60.TabIndex = 131;
		this.s60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s60.Click += new System.EventHandler(s161_Click);
		this.s60.TextChanged += new System.EventHandler(s161_TextChanged);
		this.s60.KeyDown += new System.Windows.Forms.KeyEventHandler(s161_KeyDown);
		this.s60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s161_KeyPress);
		this.s60.Leave += new System.EventHandler(s161_Leave);
		this.s61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s61.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s61.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s61.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s61.Location = new System.Drawing.Point(3, 1299);
		this.s61.Multiline = true;
		this.s61.Name = "s61";
		this.s61.Size = new System.Drawing.Size(95, 48);
		this.s61.TabIndex = 132;
		this.s61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s61.Click += new System.EventHandler(s193_Click);
		this.s61.TextChanged += new System.EventHandler(s193_TextChanged);
		this.s61.KeyDown += new System.Windows.Forms.KeyEventHandler(s193_KeyDown);
		this.s61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s193_KeyPress);
		this.s61.Leave += new System.EventHandler(s193_Leave);
		this.s25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s25.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s25.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s25.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s25.Location = new System.Drawing.Point(192, 1299);
		this.s25.Multiline = true;
		this.s25.Name = "s25";
		this.s25.Size = new System.Drawing.Size(87, 48);
		this.s25.TabIndex = 96;
		this.s25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s25.Click += new System.EventHandler(s129_Click);
		this.s25.TextChanged += new System.EventHandler(s129_TextChanged);
		this.s25.KeyDown += new System.Windows.Forms.KeyEventHandler(s129_KeyDown);
		this.s25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s129_KeyPress);
		this.s25.Leave += new System.EventHandler(s129_Leave);
		this.s62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s62.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s62.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s62.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s62.Location = new System.Drawing.Point(3, 1353);
		this.s62.Multiline = true;
		this.s62.Name = "s62";
		this.s62.Size = new System.Drawing.Size(95, 48);
		this.s62.TabIndex = 133;
		this.s62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s62.Click += new System.EventHandler(s128_Click);
		this.s62.TextChanged += new System.EventHandler(s128_TextChanged);
		this.s62.KeyDown += new System.Windows.Forms.KeyEventHandler(s128_KeyDown);
		this.s62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s128_KeyPress);
		this.s62.Leave += new System.EventHandler(s128_Leave);
		this.s26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s26.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s26.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s26.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s26.Location = new System.Drawing.Point(192, 1353);
		this.s26.Multiline = true;
		this.s26.Name = "s26";
		this.s26.Size = new System.Drawing.Size(87, 48);
		this.s26.TabIndex = 97;
		this.s26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s26.Click += new System.EventHandler(s190_Click);
		this.s26.TextChanged += new System.EventHandler(s190_TextChanged);
		this.s26.KeyDown += new System.Windows.Forms.KeyEventHandler(s190_KeyDown);
		this.s26.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s190_KeyPress);
		this.s26.Leave += new System.EventHandler(s190_Leave);
		this.s63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s63.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s63.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s63.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s63.Location = new System.Drawing.Point(3, 1407);
		this.s63.Multiline = true;
		this.s63.Name = "s63";
		this.s63.Size = new System.Drawing.Size(95, 48);
		this.s63.TabIndex = 134;
		this.s63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s63.Click += new System.EventHandler(s194_Click);
		this.s63.TextChanged += new System.EventHandler(s194_TextChanged);
		this.s63.KeyDown += new System.Windows.Forms.KeyEventHandler(s194_KeyDown);
		this.s63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s194_KeyPress);
		this.s63.Leave += new System.EventHandler(s194_Leave);
		this.s27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s27.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s27.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s27.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s27.Location = new System.Drawing.Point(192, 1407);
		this.s27.Multiline = true;
		this.s27.Name = "s27";
		this.s27.Size = new System.Drawing.Size(87, 48);
		this.s27.TabIndex = 98;
		this.s27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s27.Click += new System.EventHandler(s157_Click);
		this.s27.TextChanged += new System.EventHandler(s157_TextChanged);
		this.s27.KeyDown += new System.Windows.Forms.KeyEventHandler(s157_KeyDown);
		this.s27.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s157_KeyPress);
		this.s27.Leave += new System.EventHandler(s157_Leave);
		this.s28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s28.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s28.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s28.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s28.Location = new System.Drawing.Point(192, 1461);
		this.s28.Multiline = true;
		this.s28.Name = "s28";
		this.s28.Size = new System.Drawing.Size(87, 48);
		this.s28.TabIndex = 99;
		this.s28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s28.Click += new System.EventHandler(s192_Click);
		this.s28.TextChanged += new System.EventHandler(s192_TextChanged);
		this.s28.KeyDown += new System.Windows.Forms.KeyEventHandler(s192_KeyDown);
		this.s28.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s192_KeyPress);
		this.s28.Leave += new System.EventHandler(s192_Leave);
		this.s64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s64.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s64.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s64.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s64.Location = new System.Drawing.Point(3, 1461);
		this.s64.Multiline = true;
		this.s64.Name = "s64";
		this.s64.Size = new System.Drawing.Size(95, 48);
		this.s64.TabIndex = 135;
		this.s64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s64.Click += new System.EventHandler(s153_Click);
		this.s64.TextChanged += new System.EventHandler(s153_TextChanged);
		this.s64.KeyDown += new System.Windows.Forms.KeyEventHandler(s153_KeyDown);
		this.s64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s153_KeyPress);
		this.s64.Leave += new System.EventHandler(s153_Leave);
		this.s29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s29.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s29.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s29.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s29.Location = new System.Drawing.Point(192, 1515);
		this.s29.Multiline = true;
		this.s29.Name = "s29";
		this.s29.Size = new System.Drawing.Size(87, 48);
		this.s29.TabIndex = 100;
		this.s29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s29.Click += new System.EventHandler(s231_Click);
		this.s29.TextChanged += new System.EventHandler(s231_TextChanged);
		this.s29.KeyDown += new System.Windows.Forms.KeyEventHandler(s231_KeyDown);
		this.s29.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s231_KeyPress);
		this.s29.Leave += new System.EventHandler(s231_Leave);
		this.s30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s30.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s30.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s30.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s30.Location = new System.Drawing.Point(192, 1569);
		this.s30.Multiline = true;
		this.s30.Name = "s30";
		this.s30.Size = new System.Drawing.Size(87, 48);
		this.s30.TabIndex = 101;
		this.s30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s30.Click += new System.EventHandler(s230_Click);
		this.s30.TextChanged += new System.EventHandler(s230_TextChanged);
		this.s30.KeyDown += new System.Windows.Forms.KeyEventHandler(s230_KeyDown);
		this.s30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s230_KeyPress);
		this.s30.Leave += new System.EventHandler(s230_Leave);
		this.s31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s31.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s31.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s31.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s31.Location = new System.Drawing.Point(192, 1623);
		this.s31.Multiline = true;
		this.s31.Name = "s31";
		this.s31.Size = new System.Drawing.Size(87, 48);
		this.s31.TabIndex = 102;
		this.s31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s31.Click += new System.EventHandler(s136_Click);
		this.s31.TextChanged += new System.EventHandler(s136_TextChanged);
		this.s31.KeyDown += new System.Windows.Forms.KeyEventHandler(s136_KeyDown);
		this.s31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s136_KeyPress);
		this.s31.Leave += new System.EventHandler(s136_Leave);
		this.s65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s65.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s65.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s65.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s65.Location = new System.Drawing.Point(3, 1515);
		this.s65.Multiline = true;
		this.s65.Name = "s65";
		this.s65.Size = new System.Drawing.Size(95, 48);
		this.s65.TabIndex = 136;
		this.s65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s65.Click += new System.EventHandler(s138_Click);
		this.s65.TextChanged += new System.EventHandler(s138_TextChanged);
		this.s65.KeyDown += new System.Windows.Forms.KeyEventHandler(s138_KeyDown);
		this.s65.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s138_KeyPress);
		this.s65.Leave += new System.EventHandler(s138_Leave);
		this.s66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s66.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s66.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s66.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s66.Location = new System.Drawing.Point(3, 1569);
		this.s66.Multiline = true;
		this.s66.Name = "s66";
		this.s66.Size = new System.Drawing.Size(95, 48);
		this.s66.TabIndex = 137;
		this.s66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s66.Click += new System.EventHandler(s228_Click);
		this.s66.TextChanged += new System.EventHandler(s228_TextChanged);
		this.s66.KeyDown += new System.Windows.Forms.KeyEventHandler(s228_KeyDown);
		this.s66.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s228_KeyPress);
		this.s66.Leave += new System.EventHandler(s228_Leave);
		this.s32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s32.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s32.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s32.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s32.Location = new System.Drawing.Point(192, 1677);
		this.s32.Multiline = true;
		this.s32.Name = "s32";
		this.s32.Size = new System.Drawing.Size(87, 48);
		this.s32.TabIndex = 103;
		this.s32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s32.Click += new System.EventHandler(s123_Click);
		this.s32.TextChanged += new System.EventHandler(s123_TextChanged);
		this.s32.KeyDown += new System.Windows.Forms.KeyEventHandler(s123_KeyDown);
		this.s32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s123_KeyPress);
		this.s32.Leave += new System.EventHandler(s123_Leave);
		this.s33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s33.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s33.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s33.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s33.Location = new System.Drawing.Point(192, 1731);
		this.s33.Multiline = true;
		this.s33.Name = "s33";
		this.s33.Size = new System.Drawing.Size(87, 48);
		this.s33.TabIndex = 104;
		this.s33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s33.Click += new System.EventHandler(s180_Click);
		this.s33.TextChanged += new System.EventHandler(s180_TextChanged);
		this.s33.KeyDown += new System.Windows.Forms.KeyEventHandler(s180_KeyDown);
		this.s33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s180_KeyPress);
		this.s33.Leave += new System.EventHandler(s180_Leave);
		this.s34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s34.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s34.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s34.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s34.Location = new System.Drawing.Point(192, 1785);
		this.s34.Multiline = true;
		this.s34.Name = "s34";
		this.s34.Size = new System.Drawing.Size(87, 48);
		this.s34.TabIndex = 105;
		this.s34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s34.Click += new System.EventHandler(s119_Click);
		this.s34.TextChanged += new System.EventHandler(s119_TextChanged);
		this.s34.KeyDown += new System.Windows.Forms.KeyEventHandler(s119_KeyDown);
		this.s34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s119_KeyPress);
		this.s34.Leave += new System.EventHandler(s119_Leave);
		this.s67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s67.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s67.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s67.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s67.Location = new System.Drawing.Point(3, 1623);
		this.s67.Multiline = true;
		this.s67.Name = "s67";
		this.s67.Size = new System.Drawing.Size(95, 48);
		this.s67.TabIndex = 138;
		this.s67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s67.Click += new System.EventHandler(s182_Click);
		this.s67.TextChanged += new System.EventHandler(s182_TextChanged);
		this.s67.KeyDown += new System.Windows.Forms.KeyEventHandler(s182_KeyDown);
		this.s67.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s182_KeyPress);
		this.s67.Leave += new System.EventHandler(s182_Leave);
		this.s69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s69.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s69.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s69.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s69.Location = new System.Drawing.Point(3, 1731);
		this.s69.Multiline = true;
		this.s69.Name = "s69";
		this.s69.Size = new System.Drawing.Size(95, 48);
		this.s69.TabIndex = 140;
		this.s69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s69.Click += new System.EventHandler(s185_Click);
		this.s69.TextChanged += new System.EventHandler(s185_TextChanged);
		this.s69.KeyDown += new System.Windows.Forms.KeyEventHandler(s185_KeyDown);
		this.s69.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s185_KeyPress);
		this.s69.Leave += new System.EventHandler(s185_Leave);
		this.s68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s68.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s68.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s68.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s68.Location = new System.Drawing.Point(3, 1677);
		this.s68.Multiline = true;
		this.s68.Name = "s68";
		this.s68.Size = new System.Drawing.Size(95, 48);
		this.s68.TabIndex = 139;
		this.s68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s68.Click += new System.EventHandler(s174_Click);
		this.s68.TextChanged += new System.EventHandler(s174_TextChanged);
		this.s68.KeyDown += new System.Windows.Forms.KeyEventHandler(s174_KeyDown);
		this.s68.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s174_KeyPress);
		this.s68.Leave += new System.EventHandler(s174_Leave);
		this.s70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s70.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s70.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s70.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s70.Location = new System.Drawing.Point(3, 1785);
		this.s70.Multiline = true;
		this.s70.Name = "s70";
		this.s70.Size = new System.Drawing.Size(95, 48);
		this.s70.TabIndex = 141;
		this.s70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s70.Click += new System.EventHandler(s122_Click);
		this.s70.TextChanged += new System.EventHandler(s122_TextChanged);
		this.s70.KeyDown += new System.Windows.Forms.KeyEventHandler(s122_KeyDown);
		this.s70.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s122_KeyPress);
		this.s70.Leave += new System.EventHandler(s122_Leave);
		this.s71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s71.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s71.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s71.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s71.Location = new System.Drawing.Point(3, 1839);
		this.s71.Multiline = true;
		this.s71.Name = "s71";
		this.s71.Size = new System.Drawing.Size(95, 48);
		this.s71.TabIndex = 142;
		this.s71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s71.Click += new System.EventHandler(s183_Click);
		this.s71.TextChanged += new System.EventHandler(s183_TextChanged);
		this.s71.KeyDown += new System.Windows.Forms.KeyEventHandler(s183_KeyDown);
		this.s71.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s183_KeyPress);
		this.s71.Leave += new System.EventHandler(s183_Leave);
		this.s35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s35.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s35.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s35.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s35.Location = new System.Drawing.Point(192, 1839);
		this.s35.Multiline = true;
		this.s35.Name = "s35";
		this.s35.Size = new System.Drawing.Size(87, 48);
		this.s35.TabIndex = 106;
		this.s35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s35.Click += new System.EventHandler(s121_Click);
		this.s35.TextChanged += new System.EventHandler(s121_TextChanged);
		this.s35.KeyDown += new System.Windows.Forms.KeyEventHandler(s121_KeyDown);
		this.s35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s121_KeyPress);
		this.s35.Leave += new System.EventHandler(s121_Leave);
		this.s36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s36.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s36.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s36.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s36.Location = new System.Drawing.Point(192, 1893);
		this.s36.Multiline = true;
		this.s36.Name = "s36";
		this.s36.Size = new System.Drawing.Size(87, 59);
		this.s36.TabIndex = 107;
		this.s36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s36.Click += new System.EventHandler(s171_Click);
		this.s36.TextChanged += new System.EventHandler(s171_TextChanged);
		this.s36.KeyDown += new System.Windows.Forms.KeyEventHandler(s171_KeyDown);
		this.s36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s171_KeyPress);
		this.s36.Leave += new System.EventHandler(s171_Leave);
		this.s72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s72.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s72.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s72.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s72.Location = new System.Drawing.Point(3, 1893);
		this.s72.Multiline = true;
		this.s72.Name = "s72";
		this.s72.Size = new System.Drawing.Size(95, 59);
		this.s72.TabIndex = 143;
		this.s72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s72.Click += new System.EventHandler(s117_Click);
		this.s72.TextChanged += new System.EventHandler(s117_TextChanged);
		this.s72.KeyDown += new System.Windows.Forms.KeyEventHandler(s117_KeyDown);
		this.s72.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s117_KeyPress);
		this.s72.Leave += new System.EventHandler(s117_Leave);
		this.s174s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s174s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s174s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s174s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s174s.Location = new System.Drawing.Point(402, 3);
		this.s174s.Multiline = true;
		this.s174s.Name = "s174s";
		this.s174s.Size = new System.Drawing.Size(106, 48);
		this.s174s.TabIndex = 36;
		this.s174s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s174s.Click += new System.EventHandler(h173_Click);
		this.s174s.TextChanged += new System.EventHandler(h173_TextChanged);
		this.s174s.KeyDown += new System.Windows.Forms.KeyEventHandler(h173_KeyDown);
		this.s174s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h173_KeyPress);
		this.s174s.Leave += new System.EventHandler(h173_Leave);
		this.s180s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s180s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s180s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s180s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s180s.Location = new System.Drawing.Point(402, 57);
		this.s180s.Multiline = true;
		this.s180s.Name = "s180s";
		this.s180s.Size = new System.Drawing.Size(106, 48);
		this.s180s.TabIndex = 37;
		this.s180s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s180s.Click += new System.EventHandler(h176_Click);
		this.s180s.TextChanged += new System.EventHandler(h176_TextChanged);
		this.s180s.KeyDown += new System.Windows.Forms.KeyEventHandler(h176_KeyDown);
		this.s180s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h176_KeyPress);
		this.s180s.Leave += new System.EventHandler(h176_Leave);
		this.s182s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s182s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s182s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s182s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s182s.Location = new System.Drawing.Point(402, 111);
		this.s182s.Multiline = true;
		this.s182s.Name = "s182s";
		this.s182s.Size = new System.Drawing.Size(106, 48);
		this.s182s.TabIndex = 38;
		this.s182s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s182s.Click += new System.EventHandler(h178_Click);
		this.s182s.TextChanged += new System.EventHandler(h178_TextChanged);
		this.s182s.KeyDown += new System.Windows.Forms.KeyEventHandler(h178_KeyDown);
		this.s182s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h178_KeyPress);
		this.s182s.Leave += new System.EventHandler(h178_Leave);
		this.s183s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s183s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s183s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s183s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s183s.Location = new System.Drawing.Point(402, 165);
		this.s183s.Multiline = true;
		this.s183s.Name = "s183s";
		this.s183s.Size = new System.Drawing.Size(106, 48);
		this.s183s.TabIndex = 39;
		this.s183s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s183s.TextChanged += new System.EventHandler(h179_TextChanged);
		this.s183s.KeyDown += new System.Windows.Forms.KeyEventHandler(h179_KeyDown);
		this.s183s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h179_KeyPress);
		this.s183s.Leave += new System.EventHandler(h179_Leave);
		this.s185s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s185s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s185s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s185s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s185s.Location = new System.Drawing.Point(402, 219);
		this.s185s.Multiline = true;
		this.s185s.Name = "s185s";
		this.s185s.Size = new System.Drawing.Size(106, 48);
		this.s185s.TabIndex = 40;
		this.s185s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s185s.TextChanged += new System.EventHandler(h181_TextChanged);
		this.s185s.KeyDown += new System.Windows.Forms.KeyEventHandler(h181_KeyDown);
		this.s185s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h181_KeyPress);
		this.s185s.Leave += new System.EventHandler(h181_Leave);
		this.s190s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s190s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s190s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s190s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s190s.Location = new System.Drawing.Point(402, 273);
		this.s190s.Multiline = true;
		this.s190s.Name = "s190s";
		this.s190s.Size = new System.Drawing.Size(106, 48);
		this.s190s.TabIndex = 41;
		this.s190s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s190s.Click += new System.EventHandler(h184_Click);
		this.s190s.TextChanged += new System.EventHandler(h184_TextChanged);
		this.s190s.KeyDown += new System.Windows.Forms.KeyEventHandler(h184_KeyDown);
		this.s190s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h184_KeyPress);
		this.s190s.Leave += new System.EventHandler(h184_Leave);
		this.s192s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s192s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s192s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s192s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s192s.Location = new System.Drawing.Point(402, 327);
		this.s192s.Multiline = true;
		this.s192s.Name = "s192s";
		this.s192s.Size = new System.Drawing.Size(106, 48);
		this.s192s.TabIndex = 42;
		this.s192s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s192s.Click += new System.EventHandler(h187_Click);
		this.s192s.TextChanged += new System.EventHandler(h187_TextChanged);
		this.s192s.KeyDown += new System.Windows.Forms.KeyEventHandler(h187_KeyDown);
		this.s192s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h187_KeyPress);
		this.s192s.Leave += new System.EventHandler(h187_Leave);
		this.s193s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s193s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s193s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s193s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s193s.Location = new System.Drawing.Point(402, 381);
		this.s193s.Multiline = true;
		this.s193s.Name = "s193s";
		this.s193s.Size = new System.Drawing.Size(106, 48);
		this.s193s.TabIndex = 43;
		this.s193s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s193s.Click += new System.EventHandler(h189_Click);
		this.s193s.TextChanged += new System.EventHandler(h189_TextChanged);
		this.s193s.KeyDown += new System.Windows.Forms.KeyEventHandler(h189_KeyDown);
		this.s193s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h189_KeyPress);
		this.s193s.Leave += new System.EventHandler(h189_Leave);
		this.s194s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s194s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s194s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s194s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s194s.Location = new System.Drawing.Point(402, 435);
		this.s194s.Multiline = true;
		this.s194s.Name = "s194s";
		this.s194s.Size = new System.Drawing.Size(106, 48);
		this.s194s.TabIndex = 44;
		this.s194s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s194s.Click += new System.EventHandler(h190_Click);
		this.s194s.TextChanged += new System.EventHandler(h190_TextChanged);
		this.s194s.KeyDown += new System.Windows.Forms.KeyEventHandler(h190_KeyDown);
		this.s194s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h190_KeyPress);
		this.s194s.Leave += new System.EventHandler(h190_Leave);
		this.s198s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s198s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s198s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s198s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s198s.Location = new System.Drawing.Point(402, 489);
		this.s198s.Multiline = true;
		this.s198s.Name = "s198s";
		this.s198s.Size = new System.Drawing.Size(106, 48);
		this.s198s.TabIndex = 45;
		this.s198s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s198s.Click += new System.EventHandler(h191_Click);
		this.s198s.TextChanged += new System.EventHandler(h191_TextChanged);
		this.s198s.KeyDown += new System.Windows.Forms.KeyEventHandler(h191_KeyDown);
		this.s198s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h191_KeyPress);
		this.s198s.Leave += new System.EventHandler(h191_Leave);
		this.s201s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s201s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s201s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s201s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s201s.Location = new System.Drawing.Point(402, 543);
		this.s201s.Multiline = true;
		this.s201s.Name = "s201s";
		this.s201s.Size = new System.Drawing.Size(106, 48);
		this.s201s.TabIndex = 46;
		this.s201s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s201s.Click += new System.EventHandler(h198_Click);
		this.s201s.TextChanged += new System.EventHandler(h198_TextChanged);
		this.s201s.KeyDown += new System.Windows.Forms.KeyEventHandler(h198_KeyDown);
		this.s201s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h198_KeyPress);
		this.s201s.Leave += new System.EventHandler(h198_Leave);
		this.s207s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s207s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s207s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s207s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s207s.Location = new System.Drawing.Point(402, 597);
		this.s207s.Multiline = true;
		this.s207s.Name = "s207s";
		this.s207s.Size = new System.Drawing.Size(106, 48);
		this.s207s.TabIndex = 47;
		this.s207s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s207s.Click += new System.EventHandler(h199_Click);
		this.s207s.TextChanged += new System.EventHandler(h199_TextChanged);
		this.s207s.KeyDown += new System.Windows.Forms.KeyEventHandler(h199_KeyDown);
		this.s207s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h199_KeyPress);
		this.s207s.Leave += new System.EventHandler(h199_Leave);
		this.s218s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s218s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s218s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s218s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s218s.Location = new System.Drawing.Point(402, 651);
		this.s218s.Multiline = true;
		this.s218s.Name = "s218s";
		this.s218s.Size = new System.Drawing.Size(106, 48);
		this.s218s.TabIndex = 48;
		this.s218s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s218s.Click += new System.EventHandler(h202_Click);
		this.s218s.TextChanged += new System.EventHandler(h202_TextChanged);
		this.s218s.KeyDown += new System.Windows.Forms.KeyEventHandler(h202_KeyDown);
		this.s218s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h202_KeyPress);
		this.s218s.Leave += new System.EventHandler(h202_Leave);
		this.s221s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s221s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s221s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s221s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s221s.Location = new System.Drawing.Point(402, 705);
		this.s221s.Multiline = true;
		this.s221s.Name = "s221s";
		this.s221s.Size = new System.Drawing.Size(106, 48);
		this.s221s.TabIndex = 49;
		this.s221s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s221s.Click += new System.EventHandler(h203_Click);
		this.s221s.TextChanged += new System.EventHandler(h203_TextChanged);
		this.s221s.KeyDown += new System.Windows.Forms.KeyEventHandler(h203_KeyDown);
		this.s221s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h203_KeyPress);
		this.s221s.Leave += new System.EventHandler(h203_Leave);
		this.s226s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s226s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s226s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s226s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s226s.Location = new System.Drawing.Point(402, 759);
		this.s226s.Multiline = true;
		this.s226s.Name = "s226s";
		this.s226s.Size = new System.Drawing.Size(106, 48);
		this.s226s.TabIndex = 50;
		this.s226s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s226s.Click += new System.EventHandler(h204_Click);
		this.s226s.TextChanged += new System.EventHandler(h204_TextChanged);
		this.s226s.KeyDown += new System.Windows.Forms.KeyEventHandler(h204_KeyDown);
		this.s226s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h204_KeyPress);
		this.s226s.Leave += new System.EventHandler(h204_Leave);
		this.s228s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s228s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s228s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s228s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s228s.Location = new System.Drawing.Point(402, 813);
		this.s228s.Multiline = true;
		this.s228s.Name = "s228s";
		this.s228s.Size = new System.Drawing.Size(106, 48);
		this.s228s.TabIndex = 51;
		this.s228s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s228s.Click += new System.EventHandler(h205_Click);
		this.s228s.TextChanged += new System.EventHandler(h205_TextChanged);
		this.s228s.KeyDown += new System.Windows.Forms.KeyEventHandler(h205_KeyDown);
		this.s228s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h205_KeyPress);
		this.s228s.Leave += new System.EventHandler(h205_Leave);
		this.s230s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s230s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s230s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s230s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s230s.Location = new System.Drawing.Point(402, 867);
		this.s230s.Multiline = true;
		this.s230s.Name = "s230s";
		this.s230s.Size = new System.Drawing.Size(106, 48);
		this.s230s.TabIndex = 52;
		this.s230s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s230s.Click += new System.EventHandler(h206_Click);
		this.s230s.TextChanged += new System.EventHandler(h206_TextChanged);
		this.s230s.KeyDown += new System.Windows.Forms.KeyEventHandler(h206_KeyDown);
		this.s230s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h206_KeyPress);
		this.s230s.Leave += new System.EventHandler(h206_Leave);
		this.s231s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s231s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s231s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s231s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s231s.Location = new System.Drawing.Point(402, 921);
		this.s231s.Multiline = true;
		this.s231s.Name = "s231s";
		this.s231s.Size = new System.Drawing.Size(106, 48);
		this.s231s.TabIndex = 53;
		this.s231s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s231s.Click += new System.EventHandler(h208_Click);
		this.s231s.TextChanged += new System.EventHandler(h208_TextChanged);
		this.s231s.KeyDown += new System.Windows.Forms.KeyEventHandler(h208_KeyDown);
		this.s231s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h208_KeyPress);
		this.s231s.Leave += new System.EventHandler(h208_Leave);
		this.s236s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s236s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s236s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s236s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s236s.Location = new System.Drawing.Point(402, 975);
		this.s236s.Multiline = true;
		this.s236s.Name = "s236s";
		this.s236s.Size = new System.Drawing.Size(106, 48);
		this.s236s.TabIndex = 54;
		this.s236s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s236s.Click += new System.EventHandler(h209_Click);
		this.s236s.TextChanged += new System.EventHandler(h209_TextChanged);
		this.s236s.KeyDown += new System.Windows.Forms.KeyEventHandler(h209_KeyDown);
		this.s236s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h209_KeyPress);
		this.s236s.Leave += new System.EventHandler(h209_Leave);
		this.h210.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h210.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h210.Enabled = false;
		this.h210.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h210.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h210.Location = new System.Drawing.Point(402, 1029);
		this.h210.Multiline = true;
		this.h210.Name = "h210";
		this.h210.Size = new System.Drawing.Size(106, 48);
		this.h210.TabIndex = 55;
		this.h210.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h210.Click += new System.EventHandler(h210_Click);
		this.h210.TextChanged += new System.EventHandler(h210_TextChanged);
		this.h210.KeyDown += new System.Windows.Forms.KeyEventHandler(h210_KeyDown);
		this.h210.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h210_KeyPress);
		this.h210.Leave += new System.EventHandler(h210_Leave);
		this.h212.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h212.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h212.Enabled = false;
		this.h212.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h212.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h212.Location = new System.Drawing.Point(402, 1083);
		this.h212.Multiline = true;
		this.h212.Name = "h212";
		this.h212.Size = new System.Drawing.Size(106, 48);
		this.h212.TabIndex = 56;
		this.h212.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h212.Click += new System.EventHandler(h212_Click);
		this.h212.TextChanged += new System.EventHandler(h212_TextChanged);
		this.h212.KeyDown += new System.Windows.Forms.KeyEventHandler(h212_KeyDown);
		this.h212.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h212_KeyPress);
		this.h212.Leave += new System.EventHandler(h212_Leave);
		this.h214.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h214.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h214.Enabled = false;
		this.h214.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h214.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h214.Location = new System.Drawing.Point(402, 1137);
		this.h214.Multiline = true;
		this.h214.Name = "h214";
		this.h214.Size = new System.Drawing.Size(106, 48);
		this.h214.TabIndex = 57;
		this.h214.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h214.Click += new System.EventHandler(h214_Click);
		this.h214.TextChanged += new System.EventHandler(h214_TextChanged);
		this.h214.KeyDown += new System.Windows.Forms.KeyEventHandler(h214_KeyDown);
		this.h214.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h214_KeyPress);
		this.h214.Leave += new System.EventHandler(h214_Leave);
		this.h215.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h215.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h215.Enabled = false;
		this.h215.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h215.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h215.Location = new System.Drawing.Point(402, 1191);
		this.h215.Multiline = true;
		this.h215.Name = "h215";
		this.h215.Size = new System.Drawing.Size(106, 48);
		this.h215.TabIndex = 58;
		this.h215.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h215.Click += new System.EventHandler(h215_Click);
		this.h215.TextChanged += new System.EventHandler(h215_TextChanged);
		this.h215.KeyDown += new System.Windows.Forms.KeyEventHandler(h215_KeyDown);
		this.h215.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h215_KeyPress);
		this.h215.Leave += new System.EventHandler(h215_Leave);
		this.h216.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h216.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h216.Enabled = false;
		this.h216.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h216.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h216.Location = new System.Drawing.Point(402, 1245);
		this.h216.Multiline = true;
		this.h216.Name = "h216";
		this.h216.Size = new System.Drawing.Size(106, 48);
		this.h216.TabIndex = 59;
		this.h216.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h216.Click += new System.EventHandler(h216_Click);
		this.h216.TextChanged += new System.EventHandler(h216_TextChanged);
		this.h216.KeyDown += new System.Windows.Forms.KeyEventHandler(h216_KeyDown);
		this.h216.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h216_KeyPress);
		this.h216.Leave += new System.EventHandler(h216_Leave);
		this.h217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h217.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h217.Enabled = false;
		this.h217.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h217.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h217.Location = new System.Drawing.Point(402, 1299);
		this.h217.Multiline = true;
		this.h217.Name = "h217";
		this.h217.Size = new System.Drawing.Size(106, 48);
		this.h217.TabIndex = 60;
		this.h217.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h217.Click += new System.EventHandler(h217_Click);
		this.h217.TextChanged += new System.EventHandler(h217_TextChanged);
		this.h217.KeyDown += new System.Windows.Forms.KeyEventHandler(h217_KeyDown);
		this.h217.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h217_KeyPress);
		this.h217.Leave += new System.EventHandler(h217_Leave);
		this.h219.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h219.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h219.Enabled = false;
		this.h219.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h219.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h219.Location = new System.Drawing.Point(402, 1353);
		this.h219.Multiline = true;
		this.h219.Name = "h219";
		this.h219.Size = new System.Drawing.Size(106, 48);
		this.h219.TabIndex = 61;
		this.h219.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h219.Click += new System.EventHandler(h219_Click);
		this.h219.TextChanged += new System.EventHandler(h219_TextChanged);
		this.h219.KeyDown += new System.Windows.Forms.KeyEventHandler(h219_KeyDown);
		this.h219.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h219_KeyPress);
		this.h219.Leave += new System.EventHandler(h219_Leave);
		this.h220.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h220.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h220.Enabled = false;
		this.h220.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h220.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h220.Location = new System.Drawing.Point(402, 1407);
		this.h220.Multiline = true;
		this.h220.Name = "h220";
		this.h220.Size = new System.Drawing.Size(106, 48);
		this.h220.TabIndex = 62;
		this.h220.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h220.Click += new System.EventHandler(h220_Click);
		this.h220.TextChanged += new System.EventHandler(h220_TextChanged);
		this.h220.KeyDown += new System.Windows.Forms.KeyEventHandler(h220_KeyDown);
		this.h220.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h220_KeyPress);
		this.h220.Leave += new System.EventHandler(h220_Leave);
		this.h223.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h223.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h223.Enabled = false;
		this.h223.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h223.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h223.Location = new System.Drawing.Point(402, 1461);
		this.h223.Multiline = true;
		this.h223.Name = "h223";
		this.h223.Size = new System.Drawing.Size(106, 48);
		this.h223.TabIndex = 63;
		this.h223.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h223.Click += new System.EventHandler(h223_Click);
		this.h223.TextChanged += new System.EventHandler(h223_TextChanged);
		this.h223.KeyDown += new System.Windows.Forms.KeyEventHandler(h223_KeyDown);
		this.h223.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h223_KeyPress);
		this.h223.Leave += new System.EventHandler(h223_Leave);
		this.h229.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h229.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h229.Enabled = false;
		this.h229.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h229.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h229.Location = new System.Drawing.Point(402, 1515);
		this.h229.Multiline = true;
		this.h229.Name = "h229";
		this.h229.Size = new System.Drawing.Size(106, 48);
		this.h229.TabIndex = 64;
		this.h229.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h229.Click += new System.EventHandler(h229_Click);
		this.h229.TextChanged += new System.EventHandler(h229_TextChanged);
		this.h229.KeyDown += new System.Windows.Forms.KeyEventHandler(h229_KeyDown);
		this.h229.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h229_KeyPress);
		this.h229.Leave += new System.EventHandler(h229_Leave);
		this.h233.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h233.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h233.Enabled = false;
		this.h233.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h233.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h233.Location = new System.Drawing.Point(402, 1569);
		this.h233.Multiline = true;
		this.h233.Name = "h233";
		this.h233.Size = new System.Drawing.Size(106, 48);
		this.h233.TabIndex = 65;
		this.h233.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h233.Click += new System.EventHandler(h233_Click);
		this.h233.TextChanged += new System.EventHandler(h233_TextChanged);
		this.h233.KeyDown += new System.Windows.Forms.KeyEventHandler(h233_KeyDown);
		this.h233.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h233_KeyPress);
		this.h233.Leave += new System.EventHandler(h233_Leave);
		this.h234.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h234.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h234.Enabled = false;
		this.h234.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h234.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h234.Location = new System.Drawing.Point(402, 1623);
		this.h234.Multiline = true;
		this.h234.Name = "h234";
		this.h234.Size = new System.Drawing.Size(106, 48);
		this.h234.TabIndex = 66;
		this.h234.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h234.Click += new System.EventHandler(h234_Click);
		this.h234.TextChanged += new System.EventHandler(h234_TextChanged);
		this.h234.KeyDown += new System.Windows.Forms.KeyEventHandler(h234_KeyDown);
		this.h234.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h234_KeyPress);
		this.h234.Leave += new System.EventHandler(h234_Leave);
		this.h235.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.h235.Dock = System.Windows.Forms.DockStyle.Fill;
		this.h235.Enabled = false;
		this.h235.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.h235.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.h235.Location = new System.Drawing.Point(402, 1677);
		this.h235.Multiline = true;
		this.h235.Name = "h235";
		this.h235.Size = new System.Drawing.Size(106, 48);
		this.h235.TabIndex = 67;
		this.h235.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.h235.Click += new System.EventHandler(h235_Click);
		this.h235.TextChanged += new System.EventHandler(h235_TextChanged);
		this.h235.KeyDown += new System.Windows.Forms.KeyEventHandler(h235_KeyDown);
		this.h235.Leave += new System.EventHandler(h235_Leave);
		this.s221.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s221.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s221.Enabled = false;
		this.s221.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s221.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s221.Location = new System.Drawing.Point(402, 1731);
		this.s221.Multiline = true;
		this.s221.Name = "s221";
		this.s221.Size = new System.Drawing.Size(106, 48);
		this.s221.TabIndex = 68;
		this.s221.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s221.Click += new System.EventHandler(s221_Click);
		this.s221.TextChanged += new System.EventHandler(s221_TextChanged);
		this.s221.KeyDown += new System.Windows.Forms.KeyEventHandler(s221_KeyDown);
		this.s221.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s221_KeyPress);
		this.s221.Leave += new System.EventHandler(s221_Leave);
		this.s207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s207.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s207.Enabled = false;
		this.s207.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s207.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s207.Location = new System.Drawing.Point(402, 1785);
		this.s207.Multiline = true;
		this.s207.Name = "s207";
		this.s207.Size = new System.Drawing.Size(106, 48);
		this.s207.TabIndex = 69;
		this.s207.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s207.Click += new System.EventHandler(s207_Click);
		this.s207.TextChanged += new System.EventHandler(s207_TextChanged);
		this.s207.KeyDown += new System.Windows.Forms.KeyEventHandler(s207_KeyDown);
		this.s207.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s207_KeyPress);
		this.s207.Leave += new System.EventHandler(s207_Leave);
		this.label16.AutoSize = true;
		this.label16.BackColor = System.Drawing.Color.LightCyan;
		this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label16.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label16.ForeColor = System.Drawing.Color.Black;
		this.label16.Location = new System.Drawing.Point(767, 0);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(83, 54);
		this.label16.TabIndex = 5909;
		this.label16.Text = "174";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label16.Click += new System.EventHandler(label16_Click);
		this.label13.AutoSize = true;
		this.label13.BackColor = System.Drawing.Color.LightCyan;
		this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label13.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.ForeColor = System.Drawing.Color.Black;
		this.label13.Location = new System.Drawing.Point(767, 54);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(83, 54);
		this.label13.TabIndex = 5909;
		this.label13.Text = "180";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label13.Click += new System.EventHandler(label13_Click);
		this.label15.AutoSize = true;
		this.label15.BackColor = System.Drawing.Color.LightCyan;
		this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label15.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label15.ForeColor = System.Drawing.Color.Black;
		this.label15.Location = new System.Drawing.Point(767, 108);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(83, 54);
		this.label15.TabIndex = 5909;
		this.label15.Text = "182";
		this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label15.Click += new System.EventHandler(label15_Click);
		this.label18.AutoSize = true;
		this.label18.BackColor = System.Drawing.Color.LightCyan;
		this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label18.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label18.ForeColor = System.Drawing.Color.Black;
		this.label18.Location = new System.Drawing.Point(767, 162);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(83, 54);
		this.label18.TabIndex = 5909;
		this.label18.Text = "183";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label18.Click += new System.EventHandler(label18_Click);
		this.label20.AutoSize = true;
		this.label20.BackColor = System.Drawing.Color.LightCyan;
		this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label20.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.ForeColor = System.Drawing.Color.Black;
		this.label20.Location = new System.Drawing.Point(767, 216);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(83, 54);
		this.label20.TabIndex = 5909;
		this.label20.Text = "185";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label20.Click += new System.EventHandler(label20_Click);
		this.label22.AutoSize = true;
		this.label22.BackColor = System.Drawing.Color.LightCyan;
		this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label22.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label22.ForeColor = System.Drawing.Color.Black;
		this.label22.Location = new System.Drawing.Point(767, 270);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(83, 54);
		this.label22.TabIndex = 5909;
		this.label22.Text = "190";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label24.AutoSize = true;
		this.label24.BackColor = System.Drawing.Color.LightCyan;
		this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label24.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label24.ForeColor = System.Drawing.Color.Black;
		this.label24.Location = new System.Drawing.Point(767, 324);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(83, 54);
		this.label24.TabIndex = 5909;
		this.label24.Text = "192";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label26.AutoSize = true;
		this.label26.BackColor = System.Drawing.Color.LightCyan;
		this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label26.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label26.ForeColor = System.Drawing.Color.Black;
		this.label26.Location = new System.Drawing.Point(767, 378);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(83, 54);
		this.label26.TabIndex = 5909;
		this.label26.Text = "193";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label26.Click += new System.EventHandler(label26_Click);
		this.label28.AutoSize = true;
		this.label28.BackColor = System.Drawing.Color.LightCyan;
		this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label28.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label28.ForeColor = System.Drawing.Color.Black;
		this.label28.Location = new System.Drawing.Point(767, 432);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(83, 54);
		this.label28.TabIndex = 5909;
		this.label28.Text = "194";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label28.Click += new System.EventHandler(label26_Click);
		this.label30.AutoSize = true;
		this.label30.BackColor = System.Drawing.Color.LightCyan;
		this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label30.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label30.ForeColor = System.Drawing.Color.Black;
		this.label30.Location = new System.Drawing.Point(767, 486);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(83, 54);
		this.label30.TabIndex = 5909;
		this.label30.Text = "198";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label30.Click += new System.EventHandler(label26_Click);
		this.label32.AutoSize = true;
		this.label32.BackColor = System.Drawing.Color.LightCyan;
		this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label32.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label32.ForeColor = System.Drawing.Color.Black;
		this.label32.Location = new System.Drawing.Point(767, 540);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(83, 54);
		this.label32.TabIndex = 5909;
		this.label32.Text = "201";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label32.Click += new System.EventHandler(label26_Click);
		this.label34.AutoSize = true;
		this.label34.BackColor = System.Drawing.Color.LightCyan;
		this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label34.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label34.ForeColor = System.Drawing.Color.Black;
		this.label34.Location = new System.Drawing.Point(514, 540);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(247, 54);
		this.label34.TabIndex = 5909;
		this.label34.Text = "افین عدنان جاسم";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label34.Click += new System.EventHandler(label26_Click);
		this.label36.AutoSize = true;
		this.label36.BackColor = System.Drawing.Color.LightCyan;
		this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label36.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label36.ForeColor = System.Drawing.Color.Black;
		this.label36.Location = new System.Drawing.Point(767, 594);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(83, 54);
		this.label36.TabIndex = 5909;
		this.label36.Text = "207";
		this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label36.Click += new System.EventHandler(label26_Click);
		this.label38.AutoSize = true;
		this.label38.BackColor = System.Drawing.Color.LightCyan;
		this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label38.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label38.ForeColor = System.Drawing.Color.Black;
		this.label38.Location = new System.Drawing.Point(767, 648);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(83, 54);
		this.label38.TabIndex = 5909;
		this.label38.Text = "218";
		this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label38.Click += new System.EventHandler(label26_Click);
		this.label40.AutoSize = true;
		this.label40.BackColor = System.Drawing.Color.LightCyan;
		this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label40.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label40.ForeColor = System.Drawing.Color.Black;
		this.label40.Location = new System.Drawing.Point(767, 702);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(83, 54);
		this.label40.TabIndex = 5909;
		this.label40.Text = "221";
		this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label40.Click += new System.EventHandler(label26_Click);
		this.label42.AutoSize = true;
		this.label42.BackColor = System.Drawing.Color.LightCyan;
		this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label42.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label42.ForeColor = System.Drawing.Color.Black;
		this.label42.Location = new System.Drawing.Point(767, 756);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(83, 54);
		this.label42.TabIndex = 5909;
		this.label42.Text = "226";
		this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label42.Click += new System.EventHandler(label26_Click);
		this.label44.AutoSize = true;
		this.label44.BackColor = System.Drawing.Color.LightCyan;
		this.label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label44.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label44.ForeColor = System.Drawing.Color.Black;
		this.label44.Location = new System.Drawing.Point(767, 810);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(83, 54);
		this.label44.TabIndex = 5909;
		this.label44.Text = "228";
		this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label44.Click += new System.EventHandler(label26_Click);
		this.label46.AutoSize = true;
		this.label46.BackColor = System.Drawing.Color.LightCyan;
		this.label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label46.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label46.ForeColor = System.Drawing.Color.Black;
		this.label46.Location = new System.Drawing.Point(767, 864);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(83, 54);
		this.label46.TabIndex = 5909;
		this.label46.Text = "230";
		this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label46.Click += new System.EventHandler(label26_Click);
		this.label48.AutoSize = true;
		this.label48.BackColor = System.Drawing.Color.LightCyan;
		this.label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label48.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label48.ForeColor = System.Drawing.Color.Black;
		this.label48.Location = new System.Drawing.Point(767, 918);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(83, 54);
		this.label48.TabIndex = 5909;
		this.label48.Text = "231";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label48.Click += new System.EventHandler(label26_Click);
		this.label59.AutoSize = true;
		this.label59.BackColor = System.Drawing.Color.LightCyan;
		this.label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label59.Enabled = false;
		this.label59.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label59.ForeColor = System.Drawing.Color.Black;
		this.label59.Location = new System.Drawing.Point(767, 1026);
		this.label59.Name = "label59";
		this.label59.Size = new System.Drawing.Size(83, 54);
		this.label59.TabIndex = 5909;
		this.label59.Text = "0";
		this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label59.Click += new System.EventHandler(label26_Click);
		this.label61.AutoSize = true;
		this.label61.BackColor = System.Drawing.Color.LightCyan;
		this.label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label61.Enabled = false;
		this.label61.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label61.ForeColor = System.Drawing.Color.Black;
		this.label61.Location = new System.Drawing.Point(767, 1080);
		this.label61.Name = "label61";
		this.label61.Size = new System.Drawing.Size(83, 54);
		this.label61.TabIndex = 5909;
		this.label61.Text = "0";
		this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label61.Click += new System.EventHandler(label26_Click);
		this.label63.AutoSize = true;
		this.label63.BackColor = System.Drawing.Color.LightCyan;
		this.label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label63.Enabled = false;
		this.label63.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label63.ForeColor = System.Drawing.Color.Black;
		this.label63.Location = new System.Drawing.Point(767, 1134);
		this.label63.Name = "label63";
		this.label63.Size = new System.Drawing.Size(83, 54);
		this.label63.TabIndex = 5909;
		this.label63.Text = "0";
		this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label63.Click += new System.EventHandler(label26_Click);
		this.label68.AutoSize = true;
		this.label68.BackColor = System.Drawing.Color.LightCyan;
		this.label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label68.Enabled = false;
		this.label68.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label68.ForeColor = System.Drawing.Color.Black;
		this.label68.Location = new System.Drawing.Point(767, 1188);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(83, 54);
		this.label68.TabIndex = 5909;
		this.label68.Text = "0";
		this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label68.Click += new System.EventHandler(label26_Click);
		this.label71.AutoSize = true;
		this.label71.BackColor = System.Drawing.Color.LightCyan;
		this.label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label71.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label71.Enabled = false;
		this.label71.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label71.ForeColor = System.Drawing.Color.Black;
		this.label71.Location = new System.Drawing.Point(767, 1242);
		this.label71.Name = "label71";
		this.label71.Size = new System.Drawing.Size(83, 54);
		this.label71.TabIndex = 5909;
		this.label71.Text = "0";
		this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label71.Click += new System.EventHandler(label26_Click);
		this.label73.AutoSize = true;
		this.label73.BackColor = System.Drawing.Color.LightCyan;
		this.label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label73.Enabled = false;
		this.label73.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label73.ForeColor = System.Drawing.Color.Black;
		this.label73.Location = new System.Drawing.Point(767, 1296);
		this.label73.Name = "label73";
		this.label73.Size = new System.Drawing.Size(83, 54);
		this.label73.TabIndex = 5909;
		this.label73.Text = "0";
		this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label73.Click += new System.EventHandler(label26_Click);
		this.label75.AutoSize = true;
		this.label75.BackColor = System.Drawing.Color.LightCyan;
		this.label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label75.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label75.Enabled = false;
		this.label75.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label75.ForeColor = System.Drawing.Color.Black;
		this.label75.Location = new System.Drawing.Point(767, 1350);
		this.label75.Name = "label75";
		this.label75.Size = new System.Drawing.Size(83, 54);
		this.label75.TabIndex = 5909;
		this.label75.Text = "0";
		this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label75.Click += new System.EventHandler(label26_Click);
		this.label77.AutoSize = true;
		this.label77.BackColor = System.Drawing.Color.LightCyan;
		this.label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label77.Enabled = false;
		this.label77.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label77.ForeColor = System.Drawing.Color.Black;
		this.label77.Location = new System.Drawing.Point(767, 1404);
		this.label77.Name = "label77";
		this.label77.Size = new System.Drawing.Size(83, 54);
		this.label77.TabIndex = 5909;
		this.label77.Text = "0";
		this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label77.Click += new System.EventHandler(label26_Click);
		this.label79.AutoSize = true;
		this.label79.BackColor = System.Drawing.Color.LightCyan;
		this.label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label79.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label79.Enabled = false;
		this.label79.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label79.ForeColor = System.Drawing.Color.Black;
		this.label79.Location = new System.Drawing.Point(767, 1458);
		this.label79.Name = "label79";
		this.label79.Size = new System.Drawing.Size(83, 54);
		this.label79.TabIndex = 5909;
		this.label79.Text = "0";
		this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label79.Click += new System.EventHandler(label26_Click);
		this.label81.AutoSize = true;
		this.label81.BackColor = System.Drawing.Color.LightCyan;
		this.label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label81.Enabled = false;
		this.label81.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label81.ForeColor = System.Drawing.Color.Black;
		this.label81.Location = new System.Drawing.Point(767, 1512);
		this.label81.Name = "label81";
		this.label81.Size = new System.Drawing.Size(83, 54);
		this.label81.TabIndex = 5909;
		this.label81.Text = "0";
		this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label81.Click += new System.EventHandler(label26_Click);
		this.label83.AutoSize = true;
		this.label83.BackColor = System.Drawing.Color.LightCyan;
		this.label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label83.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label83.Enabled = false;
		this.label83.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label83.ForeColor = System.Drawing.Color.Black;
		this.label83.Location = new System.Drawing.Point(767, 1566);
		this.label83.Name = "label83";
		this.label83.Size = new System.Drawing.Size(83, 54);
		this.label83.TabIndex = 5909;
		this.label83.Text = "0";
		this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label83.Click += new System.EventHandler(label26_Click);
		this.label85.AutoSize = true;
		this.label85.BackColor = System.Drawing.Color.LightCyan;
		this.label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label85.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label85.Enabled = false;
		this.label85.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label85.ForeColor = System.Drawing.Color.Black;
		this.label85.Location = new System.Drawing.Point(767, 1620);
		this.label85.Name = "label85";
		this.label85.Size = new System.Drawing.Size(83, 54);
		this.label85.TabIndex = 5909;
		this.label85.Text = "0";
		this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label85.Click += new System.EventHandler(label26_Click);
		this.label87.AutoSize = true;
		this.label87.BackColor = System.Drawing.Color.LightCyan;
		this.label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label87.Enabled = false;
		this.label87.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label87.ForeColor = System.Drawing.Color.Black;
		this.label87.Location = new System.Drawing.Point(767, 1674);
		this.label87.Name = "label87";
		this.label87.Size = new System.Drawing.Size(83, 54);
		this.label87.TabIndex = 5909;
		this.label87.Text = "0";
		this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label87.Click += new System.EventHandler(label26_Click);
		this.label89.AutoSize = true;
		this.label89.BackColor = System.Drawing.Color.LightCyan;
		this.label89.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label89.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label89.Enabled = false;
		this.label89.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label89.ForeColor = System.Drawing.Color.Black;
		this.label89.Location = new System.Drawing.Point(767, 1728);
		this.label89.Name = "label89";
		this.label89.Size = new System.Drawing.Size(83, 54);
		this.label89.TabIndex = 5909;
		this.label89.Text = "0";
		this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label89.Click += new System.EventHandler(label26_Click);
		this.label90.AutoSize = true;
		this.label90.BackColor = System.Drawing.Color.LightCyan;
		this.label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label90.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label90.Enabled = false;
		this.label90.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label90.ForeColor = System.Drawing.Color.Black;
		this.label90.Location = new System.Drawing.Point(767, 1782);
		this.label90.Name = "label90";
		this.label90.Size = new System.Drawing.Size(83, 54);
		this.label90.TabIndex = 5909;
		this.label90.Text = "0";
		this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label90.Click += new System.EventHandler(label26_Click);
		this.label96.AutoSize = true;
		this.label96.BackColor = System.Drawing.Color.LightCyan;
		this.label96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label96.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label96.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label96.ForeColor = System.Drawing.Color.Black;
		this.label96.Location = new System.Drawing.Point(514, 0);
		this.label96.Name = "label96";
		this.label96.Size = new System.Drawing.Size(247, 54);
		this.label96.TabIndex = 5909;
		this.label96.Text = "کویخا عمر تەرەمارى";
		this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label97.AutoSize = true;
		this.label97.BackColor = System.Drawing.Color.LightCyan;
		this.label97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label97.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label97.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label97.ForeColor = System.Drawing.Color.Black;
		this.label97.Location = new System.Drawing.Point(514, 54);
		this.label97.Name = "label97";
		this.label97.Size = new System.Drawing.Size(247, 54);
		this.label97.TabIndex = 5909;
		this.label97.Text = "سامانی کەمئەندان";
		this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label98.AutoSize = true;
		this.label98.BackColor = System.Drawing.Color.LightCyan;
		this.label98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label98.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label98.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label98.ForeColor = System.Drawing.Color.Black;
		this.label98.Location = new System.Drawing.Point(514, 108);
		this.label98.Name = "label98";
		this.label98.Size = new System.Drawing.Size(247, 54);
		this.label98.TabIndex = 5909;
		this.label98.Text = "ادریس خدر حسن خدر";
		this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label99.AutoSize = true;
		this.label99.BackColor = System.Drawing.Color.LightCyan;
		this.label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label99.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label99.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label99.ForeColor = System.Drawing.Color.Black;
		this.label99.Location = new System.Drawing.Point(514, 162);
		this.label99.Name = "label99";
		this.label99.Size = new System.Drawing.Size(247, 54);
		this.label99.TabIndex = 5909;
		this.label99.Text = "مامۆستا خدر برای شەهید کوێخا";
		this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label100.AutoSize = true;
		this.label100.BackColor = System.Drawing.Color.LightCyan;
		this.label100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label100.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label100.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label100.ForeColor = System.Drawing.Color.Black;
		this.label100.Location = new System.Drawing.Point(514, 216);
		this.label100.Name = "label100";
		this.label100.Size = new System.Drawing.Size(247, 54);
		this.label100.TabIndex = 5909;
		this.label100.Text = "دلێر کەریم";
		this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label101.AutoSize = true;
		this.label101.BackColor = System.Drawing.Color.LightCyan;
		this.label101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label101.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label101.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label101.ForeColor = System.Drawing.Color.Black;
		this.label101.Location = new System.Drawing.Point(514, 270);
		this.label101.Name = "label101";
		this.label101.Size = new System.Drawing.Size(247, 54);
		this.label101.TabIndex = 5909;
		this.label101.Text = "پارتی دیموکراتی کوردستان";
		this.label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label102.AutoSize = true;
		this.label102.BackColor = System.Drawing.Color.LightCyan;
		this.label102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label102.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label102.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label102.ForeColor = System.Drawing.Color.Black;
		this.label102.Location = new System.Drawing.Point(514, 324);
		this.label102.Name = "label102";
		this.label102.Size = new System.Drawing.Size(247, 54);
		this.label102.TabIndex = 5909;
		this.label102.Text = "بەرزان حاجی کەریم بەرزنجی";
		this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label103.AutoSize = true;
		this.label103.BackColor = System.Drawing.Color.LightCyan;
		this.label103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label103.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label103.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label103.ForeColor = System.Drawing.Color.Black;
		this.label103.Location = new System.Drawing.Point(514, 378);
		this.label103.Name = "label103";
		this.label103.Size = new System.Drawing.Size(247, 54);
		this.label103.TabIndex = 5909;
		this.label103.Text = "کاروان بەرخەسپى";
		this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label103.Click += new System.EventHandler(label26_Click);
		this.label104.AutoSize = true;
		this.label104.BackColor = System.Drawing.Color.LightCyan;
		this.label104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label104.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label104.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label104.ForeColor = System.Drawing.Color.Black;
		this.label104.Location = new System.Drawing.Point(514, 432);
		this.label104.Name = "label104";
		this.label104.Size = new System.Drawing.Size(247, 54);
		this.label104.TabIndex = 5909;
		this.label104.Text = "مامۆستا ئاوات حسام الدین طیب ";
		this.label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label104.Click += new System.EventHandler(label26_Click);
		this.label105.AutoSize = true;
		this.label105.BackColor = System.Drawing.Color.LightCyan;
		this.label105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label105.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label105.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label105.ForeColor = System.Drawing.Color.Black;
		this.label105.Location = new System.Drawing.Point(514, 486);
		this.label105.Name = "label105";
		this.label105.Size = new System.Drawing.Size(247, 54);
		this.label105.TabIndex = 5909;
		this.label105.Text = "الحرکة الاسلامیة في کوردستان العراق";
		this.label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label105.Click += new System.EventHandler(label26_Click);
		this.label106.AutoSize = true;
		this.label106.BackColor = System.Drawing.Color.LightCyan;
		this.label106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label106.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label106.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label106.ForeColor = System.Drawing.Color.Black;
		this.label106.Location = new System.Drawing.Point(514, 594);
		this.label106.Name = "label106";
		this.label106.Size = new System.Drawing.Size(247, 54);
		this.label106.TabIndex = 5909;
		this.label106.Text = "دانا ئامانج نجیب شمعون ";
		this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label106.Click += new System.EventHandler(label26_Click);
		this.label107.AutoSize = true;
		this.label107.BackColor = System.Drawing.Color.LightCyan;
		this.label107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label107.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label107.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label107.ForeColor = System.Drawing.Color.Black;
		this.label107.Location = new System.Drawing.Point(514, 648);
		this.label107.Name = "label107";
		this.label107.Size = new System.Drawing.Size(247, 54);
		this.label107.TabIndex = 5909;
		this.label107.Text = "توانا بشیر داود";
		this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label107.Click += new System.EventHandler(label26_Click);
		this.label108.AutoSize = true;
		this.label108.BackColor = System.Drawing.Color.LightCyan;
		this.label108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label108.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label108.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label108.ForeColor = System.Drawing.Color.Black;
		this.label108.Location = new System.Drawing.Point(514, 702);
		this.label108.Name = "label108";
		this.label108.Size = new System.Drawing.Size(247, 54);
		this.label108.TabIndex = 5909;
		this.label108.Text = "حسین علی الونداوى";
		this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label108.Click += new System.EventHandler(label26_Click);
		this.label109.AutoSize = true;
		this.label109.BackColor = System.Drawing.Color.LightCyan;
		this.label109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label109.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label109.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label109.ForeColor = System.Drawing.Color.Black;
		this.label109.Location = new System.Drawing.Point(514, 756);
		this.label109.Name = "label109";
		this.label109.Size = new System.Drawing.Size(247, 54);
		this.label109.TabIndex = 5909;
		this.label109.Text = "هجران عباس جوکل";
		this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label109.Click += new System.EventHandler(label26_Click);
		this.label110.AutoSize = true;
		this.label110.BackColor = System.Drawing.Color.LightCyan;
		this.label110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label110.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label110.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label110.ForeColor = System.Drawing.Color.Black;
		this.label110.Location = new System.Drawing.Point(514, 810);
		this.label110.Name = "label110";
		this.label110.Size = new System.Drawing.Size(247, 54);
		this.label110.TabIndex = 5909;
		this.label110.Text = "ماموستا نجدت نوري محمد";
		this.label110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label110.Click += new System.EventHandler(label26_Click);
		this.label111.AutoSize = true;
		this.label111.BackColor = System.Drawing.Color.LightCyan;
		this.label111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label111.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label111.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label111.ForeColor = System.Drawing.Color.Black;
		this.label111.Location = new System.Drawing.Point(514, 864);
		this.label111.Name = "label111";
		this.label111.Size = new System.Drawing.Size(247, 54);
		this.label111.TabIndex = 5909;
		this.label111.Text = "سزگین مصلح علوش";
		this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label111.Click += new System.EventHandler(label26_Click);
		this.label112.AutoSize = true;
		this.label112.BackColor = System.Drawing.Color.LightCyan;
		this.label112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label112.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label112.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label112.ForeColor = System.Drawing.Color.Black;
		this.label112.Location = new System.Drawing.Point(514, 918);
		this.label112.Name = "label112";
		this.label112.Size = new System.Drawing.Size(247, 54);
		this.label112.TabIndex = 5909;
		this.label112.Text = "زبنا عادل علوش";
		this.label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label112.Click += new System.EventHandler(label26_Click);
		this.label115.AutoSize = true;
		this.label115.BackColor = System.Drawing.Color.LightCyan;
		this.label115.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label115.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label115.Enabled = false;
		this.label115.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label115.ForeColor = System.Drawing.Color.Black;
		this.label115.Location = new System.Drawing.Point(514, 1026);
		this.label115.Name = "label115";
		this.label115.Size = new System.Drawing.Size(247, 54);
		this.label115.TabIndex = 5909;
		this.label115.Text = "گه\u200cڕان";
		this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label115.Click += new System.EventHandler(label26_Click);
		this.label116.AutoSize = true;
		this.label116.BackColor = System.Drawing.Color.LightCyan;
		this.label116.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label116.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label116.Enabled = false;
		this.label116.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label116.ForeColor = System.Drawing.Color.Black;
		this.label116.Location = new System.Drawing.Point(514, 1080);
		this.label116.Name = "label116";
		this.label116.Size = new System.Drawing.Size(247, 54);
		this.label116.TabIndex = 5909;
		this.label116.Text = "گه\u200cڕان";
		this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label116.Click += new System.EventHandler(label26_Click);
		this.label118.AutoSize = true;
		this.label118.BackColor = System.Drawing.Color.LightCyan;
		this.label118.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label118.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label118.Enabled = false;
		this.label118.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label118.ForeColor = System.Drawing.Color.Black;
		this.label118.Location = new System.Drawing.Point(514, 1134);
		this.label118.Name = "label118";
		this.label118.Size = new System.Drawing.Size(247, 54);
		this.label118.TabIndex = 5909;
		this.label118.Text = "گه\u200cڕان";
		this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label118.Click += new System.EventHandler(label26_Click);
		this.label119.AutoSize = true;
		this.label119.BackColor = System.Drawing.Color.LightCyan;
		this.label119.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label119.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label119.Enabled = false;
		this.label119.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label119.ForeColor = System.Drawing.Color.Black;
		this.label119.Location = new System.Drawing.Point(514, 1188);
		this.label119.Name = "label119";
		this.label119.Size = new System.Drawing.Size(247, 54);
		this.label119.TabIndex = 5909;
		this.label119.Text = "گه\u200cڕان";
		this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label119.Click += new System.EventHandler(label26_Click);
		this.label120.AutoSize = true;
		this.label120.BackColor = System.Drawing.Color.LightCyan;
		this.label120.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label120.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label120.Enabled = false;
		this.label120.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label120.ForeColor = System.Drawing.Color.Black;
		this.label120.Location = new System.Drawing.Point(514, 1242);
		this.label120.Name = "label120";
		this.label120.Size = new System.Drawing.Size(247, 54);
		this.label120.TabIndex = 5909;
		this.label120.Text = "گه\u200cڕان";
		this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label120.Click += new System.EventHandler(label26_Click);
		this.label122.AutoSize = true;
		this.label122.BackColor = System.Drawing.Color.LightCyan;
		this.label122.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label122.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label122.Enabled = false;
		this.label122.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label122.ForeColor = System.Drawing.Color.Black;
		this.label122.Location = new System.Drawing.Point(514, 1296);
		this.label122.Name = "label122";
		this.label122.Size = new System.Drawing.Size(247, 54);
		this.label122.TabIndex = 5909;
		this.label122.Text = "گه\u200cڕان";
		this.label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label122.Click += new System.EventHandler(label26_Click);
		this.label123.AutoSize = true;
		this.label123.BackColor = System.Drawing.Color.LightCyan;
		this.label123.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label123.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label123.Enabled = false;
		this.label123.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label123.ForeColor = System.Drawing.Color.Black;
		this.label123.Location = new System.Drawing.Point(514, 1350);
		this.label123.Name = "label123";
		this.label123.Size = new System.Drawing.Size(247, 54);
		this.label123.TabIndex = 5909;
		this.label123.Text = "گه\u200cڕان";
		this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label123.Click += new System.EventHandler(label26_Click);
		this.label124.AutoSize = true;
		this.label124.BackColor = System.Drawing.Color.LightCyan;
		this.label124.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label124.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label124.Enabled = false;
		this.label124.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label124.ForeColor = System.Drawing.Color.Black;
		this.label124.Location = new System.Drawing.Point(514, 1404);
		this.label124.Name = "label124";
		this.label124.Size = new System.Drawing.Size(247, 54);
		this.label124.TabIndex = 5909;
		this.label124.Text = "گه\u200cڕان";
		this.label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label124.Click += new System.EventHandler(label26_Click);
		this.label126.AutoSize = true;
		this.label126.BackColor = System.Drawing.Color.LightCyan;
		this.label126.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label126.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label126.Enabled = false;
		this.label126.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label126.ForeColor = System.Drawing.Color.Black;
		this.label126.Location = new System.Drawing.Point(514, 1458);
		this.label126.Name = "label126";
		this.label126.Size = new System.Drawing.Size(247, 54);
		this.label126.TabIndex = 5909;
		this.label126.Text = "گه\u200cڕان";
		this.label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label126.Click += new System.EventHandler(label26_Click);
		this.label127.AutoSize = true;
		this.label127.BackColor = System.Drawing.Color.LightCyan;
		this.label127.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label127.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label127.Enabled = false;
		this.label127.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label127.ForeColor = System.Drawing.Color.Black;
		this.label127.Location = new System.Drawing.Point(514, 1512);
		this.label127.Name = "label127";
		this.label127.Size = new System.Drawing.Size(247, 54);
		this.label127.TabIndex = 5909;
		this.label127.Text = "گه\u200cڕان";
		this.label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label127.Click += new System.EventHandler(label26_Click);
		this.label128.AutoSize = true;
		this.label128.BackColor = System.Drawing.Color.LightCyan;
		this.label128.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label128.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label128.Enabled = false;
		this.label128.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label128.ForeColor = System.Drawing.Color.Black;
		this.label128.Location = new System.Drawing.Point(514, 1566);
		this.label128.Name = "label128";
		this.label128.Size = new System.Drawing.Size(247, 54);
		this.label128.TabIndex = 5909;
		this.label128.Text = "گه\u200cڕان";
		this.label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label128.Click += new System.EventHandler(label26_Click);
		this.label130.AutoSize = true;
		this.label130.BackColor = System.Drawing.Color.LightCyan;
		this.label130.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label130.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label130.Enabled = false;
		this.label130.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label130.ForeColor = System.Drawing.Color.Black;
		this.label130.Location = new System.Drawing.Point(514, 1620);
		this.label130.Name = "label130";
		this.label130.Size = new System.Drawing.Size(247, 54);
		this.label130.TabIndex = 5909;
		this.label130.Text = "گه\u200cڕان";
		this.label130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label130.Click += new System.EventHandler(label26_Click);
		this.label131.AutoSize = true;
		this.label131.BackColor = System.Drawing.Color.LightCyan;
		this.label131.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label131.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label131.Enabled = false;
		this.label131.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label131.ForeColor = System.Drawing.Color.Black;
		this.label131.Location = new System.Drawing.Point(514, 1674);
		this.label131.Name = "label131";
		this.label131.Size = new System.Drawing.Size(247, 54);
		this.label131.TabIndex = 5909;
		this.label131.Text = "گه\u200cڕان";
		this.label131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label131.Click += new System.EventHandler(label26_Click);
		this.label132.AutoSize = true;
		this.label132.BackColor = System.Drawing.Color.LightCyan;
		this.label132.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label132.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label132.Enabled = false;
		this.label132.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label132.ForeColor = System.Drawing.Color.Black;
		this.label132.Location = new System.Drawing.Point(514, 1728);
		this.label132.Name = "label132";
		this.label132.Size = new System.Drawing.Size(247, 54);
		this.label132.TabIndex = 5909;
		this.label132.Text = "گه\u200cڕان";
		this.label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label132.Click += new System.EventHandler(label26_Click);
		this.label134.AutoSize = true;
		this.label134.BackColor = System.Drawing.Color.LightCyan;
		this.label134.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label134.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label134.Enabled = false;
		this.label134.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label134.ForeColor = System.Drawing.Color.Black;
		this.label134.Location = new System.Drawing.Point(514, 1782);
		this.label134.Name = "label134";
		this.label134.Size = new System.Drawing.Size(247, 54);
		this.label134.TabIndex = 5909;
		this.label134.Text = "گه\u200cڕان";
		this.label134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label134.Click += new System.EventHandler(label26_Click);
		this.s101s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s101s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s101s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s101s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s101s.Location = new System.Drawing.Point(856, 3);
		this.s101s.Multiline = true;
		this.s101s.Name = "s101s";
		this.s101s.Size = new System.Drawing.Size(103, 48);
		this.s101s.TabIndex = 0;
		this.s101s.Text = " ";
		this.s101s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s101s.Click += new System.EventHandler(h102_Click);
		this.s101s.TextChanged += new System.EventHandler(h102_TextChanged);
		this.s101s.KeyDown += new System.Windows.Forms.KeyEventHandler(h102_KeyDown);
		this.s101s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h102_KeyPress);
		this.s101s.Leave += new System.EventHandler(h102_Leave);
		this.s104s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s104s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s104s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s104s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s104s.Location = new System.Drawing.Point(856, 57);
		this.s104s.Multiline = true;
		this.s104s.Name = "s104s";
		this.s104s.Size = new System.Drawing.Size(103, 48);
		this.s104s.TabIndex = 1;
		this.s104s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s104s.Click += new System.EventHandler(h103_Click);
		this.s104s.TextChanged += new System.EventHandler(h103_TextChanged);
		this.s104s.KeyDown += new System.Windows.Forms.KeyEventHandler(h103_KeyDown);
		this.s104s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h103_KeyPress);
		this.s104s.Leave += new System.EventHandler(h103_Leave);
		this.s110s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s110s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s110s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s110s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s110s.Location = new System.Drawing.Point(856, 111);
		this.s110s.Multiline = true;
		this.s110s.Name = "s110s";
		this.s110s.Size = new System.Drawing.Size(103, 48);
		this.s110s.TabIndex = 2;
		this.s110s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s110s.Click += new System.EventHandler(h105_Click);
		this.s110s.TextChanged += new System.EventHandler(h105_TextChanged);
		this.s110s.KeyDown += new System.Windows.Forms.KeyEventHandler(h105_KeyDown);
		this.s110s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h105_KeyPress);
		this.s110s.Leave += new System.EventHandler(h105_Leave);
		this.s113s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s113s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s113s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s113s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s113s.Location = new System.Drawing.Point(856, 165);
		this.s113s.Multiline = true;
		this.s113s.Name = "s113s";
		this.s113s.Size = new System.Drawing.Size(103, 48);
		this.s113s.TabIndex = 3;
		this.s113s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s113s.Click += new System.EventHandler(h106_Click);
		this.s113s.TextChanged += new System.EventHandler(h106_TextChanged);
		this.s113s.KeyDown += new System.Windows.Forms.KeyEventHandler(h106_KeyDown);
		this.s113s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h106_KeyPress);
		this.s113s.Leave += new System.EventHandler(h106_Leave);
		this.s114s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s114s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s114s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s114s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s114s.Location = new System.Drawing.Point(856, 219);
		this.s114s.Multiline = true;
		this.s114s.Name = "s114s";
		this.s114s.Size = new System.Drawing.Size(103, 48);
		this.s114s.TabIndex = 4;
		this.s114s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s114s.Click += new System.EventHandler(h109_Click);
		this.s114s.TextChanged += new System.EventHandler(h109_TextChanged);
		this.s114s.KeyDown += new System.Windows.Forms.KeyEventHandler(h109_KeyDown);
		this.s114s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h109_KeyPress);
		this.s114s.Leave += new System.EventHandler(h109_Leave);
		this.s115s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s115s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s115s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s115s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s115s.Location = new System.Drawing.Point(856, 273);
		this.s115s.Multiline = true;
		this.s115s.Name = "s115s";
		this.s115s.Size = new System.Drawing.Size(103, 48);
		this.s115s.TabIndex = 5;
		this.s115s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s115s.Click += new System.EventHandler(h111_Click);
		this.s115s.TextChanged += new System.EventHandler(h111_TextChanged);
		this.s115s.KeyDown += new System.Windows.Forms.KeyEventHandler(h111_KeyDown);
		this.s115s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h111_KeyPress);
		this.s115s.Leave += new System.EventHandler(h111_Leave);
		this.s116s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s116s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s116s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s116s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s116s.Location = new System.Drawing.Point(856, 327);
		this.s116s.Multiline = true;
		this.s116s.Name = "s116s";
		this.s116s.Size = new System.Drawing.Size(103, 48);
		this.s116s.TabIndex = 6;
		this.s116s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s116s.Click += new System.EventHandler(h112_Click);
		this.s116s.TextChanged += new System.EventHandler(h112_TextChanged);
		this.s116s.KeyDown += new System.Windows.Forms.KeyEventHandler(h112_KeyDown);
		this.s116s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h112_KeyPress);
		this.s116s.Leave += new System.EventHandler(h112_Leave);
		this.label29.AutoSize = true;
		this.label29.BackColor = System.Drawing.Color.LightCyan;
		this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label29.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label29.Location = new System.Drawing.Point(965, 0);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(265, 54);
		this.label29.TabIndex = 0;
		this.label29.Text = "المهندس الاستشاری شوکت عزت";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label33.AutoSize = true;
		this.label33.BackColor = System.Drawing.Color.LightCyan;
		this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label33.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label33.Location = new System.Drawing.Point(965, 54);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(265, 54);
		this.label33.TabIndex = 0;
		this.label33.Text = "مامۆستا سامان";
		this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label37.AutoSize = true;
		this.label37.BackColor = System.Drawing.Color.LightCyan;
		this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label37.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label37.Location = new System.Drawing.Point(965, 108);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(265, 54);
		this.label37.TabIndex = 0;
		this.label37.Text = "نوێنەر باران";
		this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label41.AutoSize = true;
		this.label41.BackColor = System.Drawing.Color.LightCyan;
		this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label41.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label41.Location = new System.Drawing.Point(965, 162);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(265, 54);
		this.label41.TabIndex = 0;
		this.label41.Text = "مامۆستا سەردارى ئۆتیزم";
		this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label45.AutoSize = true;
		this.label45.BackColor = System.Drawing.Color.LightCyan;
		this.label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label45.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label45.Location = new System.Drawing.Point(965, 216);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(265, 54);
		this.label45.TabIndex = 0;
		this.label45.Text = "گوران(التغیر)";
		this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label67.AutoSize = true;
		this.label67.BackColor = System.Drawing.Color.LightCyan;
		this.label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label67.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label67.Location = new System.Drawing.Point(965, 270);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(265, 54);
		this.label67.TabIndex = 0;
		this.label67.Text = "ڕزگار ڕەشید سکتانی";
		this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label70.AutoSize = true;
		this.label70.BackColor = System.Drawing.Color.LightCyan;
		this.label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label70.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label70.Location = new System.Drawing.Point(965, 324);
		this.label70.Name = "label70";
		this.label70.Size = new System.Drawing.Size(265, 54);
		this.label70.TabIndex = 0;
		this.label70.Text = "ماموستا شاهو";
		this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label170.AutoSize = true;
		this.label170.BackColor = System.Drawing.Color.Aquamarine;
		this.label170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label170.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label170.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label170.ForeColor = System.Drawing.Color.Black;
		this.label170.Location = new System.Drawing.Point(285, 1134);
		this.label170.Name = "label170";
		this.label170.Size = new System.Drawing.Size(81, 54);
		this.label170.TabIndex = 5909;
		this.label170.Text = "22";
		this.label170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label170.Click += new System.EventHandler(label26_Click);
		this.label171.AutoSize = true;
		this.label171.BackColor = System.Drawing.Color.Aquamarine;
		this.label171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label171.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label171.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label171.ForeColor = System.Drawing.Color.Black;
		this.label171.Location = new System.Drawing.Point(104, 1080);
		this.label171.Name = "label171";
		this.label171.Size = new System.Drawing.Size(82, 54);
		this.label171.TabIndex = 5909;
		this.label171.Text = "57";
		this.label171.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label171.Click += new System.EventHandler(label26_Click);
		this.label172.AutoSize = true;
		this.label172.BackColor = System.Drawing.Color.Aquamarine;
		this.label172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label172.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label172.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label172.ForeColor = System.Drawing.Color.Black;
		this.label172.Location = new System.Drawing.Point(104, 1134);
		this.label172.Name = "label172";
		this.label172.Size = new System.Drawing.Size(82, 54);
		this.label172.TabIndex = 5909;
		this.label172.Text = "58";
		this.label172.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label172.Click += new System.EventHandler(label26_Click);
		this.label174.AutoSize = true;
		this.label174.BackColor = System.Drawing.Color.Aquamarine;
		this.label174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label174.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label174.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label174.ForeColor = System.Drawing.Color.Black;
		this.label174.Location = new System.Drawing.Point(104, 1188);
		this.label174.Name = "label174";
		this.label174.Size = new System.Drawing.Size(82, 54);
		this.label174.TabIndex = 5909;
		this.label174.Text = "59";
		this.label174.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label174.Click += new System.EventHandler(label26_Click);
		this.label175.AutoSize = true;
		this.label175.BackColor = System.Drawing.Color.Aquamarine;
		this.label175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label175.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label175.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label175.ForeColor = System.Drawing.Color.Black;
		this.label175.Location = new System.Drawing.Point(104, 1242);
		this.label175.Name = "label175";
		this.label175.Size = new System.Drawing.Size(82, 54);
		this.label175.TabIndex = 5909;
		this.label175.Text = "60";
		this.label175.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label175.Click += new System.EventHandler(label26_Click);
		this.label176.AutoSize = true;
		this.label176.BackColor = System.Drawing.Color.Aquamarine;
		this.label176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label176.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label176.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label176.ForeColor = System.Drawing.Color.Black;
		this.label176.Location = new System.Drawing.Point(104, 1296);
		this.label176.Name = "label176";
		this.label176.Size = new System.Drawing.Size(82, 54);
		this.label176.TabIndex = 5909;
		this.label176.Text = "61";
		this.label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label176.Click += new System.EventHandler(label26_Click);
		this.label178.AutoSize = true;
		this.label178.BackColor = System.Drawing.Color.Aquamarine;
		this.label178.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label178.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label178.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label178.ForeColor = System.Drawing.Color.Black;
		this.label178.Location = new System.Drawing.Point(104, 1350);
		this.label178.Name = "label178";
		this.label178.Size = new System.Drawing.Size(82, 54);
		this.label178.TabIndex = 5909;
		this.label178.Text = "62";
		this.label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label178.Click += new System.EventHandler(label26_Click);
		this.label179.AutoSize = true;
		this.label179.BackColor = System.Drawing.Color.Aquamarine;
		this.label179.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label179.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label179.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label179.ForeColor = System.Drawing.Color.Black;
		this.label179.Location = new System.Drawing.Point(104, 1404);
		this.label179.Name = "label179";
		this.label179.Size = new System.Drawing.Size(82, 54);
		this.label179.TabIndex = 5909;
		this.label179.Text = "63";
		this.label179.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label179.Click += new System.EventHandler(label26_Click);
		this.label180.AutoSize = true;
		this.label180.BackColor = System.Drawing.Color.Aquamarine;
		this.label180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label180.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label180.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label180.ForeColor = System.Drawing.Color.Black;
		this.label180.Location = new System.Drawing.Point(104, 1458);
		this.label180.Name = "label180";
		this.label180.Size = new System.Drawing.Size(82, 54);
		this.label180.TabIndex = 5909;
		this.label180.Text = "64";
		this.label180.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label180.Click += new System.EventHandler(label26_Click);
		this.label182.AutoSize = true;
		this.label182.BackColor = System.Drawing.Color.Aquamarine;
		this.label182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label182.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label182.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label182.ForeColor = System.Drawing.Color.Black;
		this.label182.Location = new System.Drawing.Point(104, 1512);
		this.label182.Name = "label182";
		this.label182.Size = new System.Drawing.Size(82, 54);
		this.label182.TabIndex = 5909;
		this.label182.Text = "65";
		this.label182.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label182.Click += new System.EventHandler(label26_Click);
		this.label183.AutoSize = true;
		this.label183.BackColor = System.Drawing.Color.Aquamarine;
		this.label183.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label183.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label183.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label183.ForeColor = System.Drawing.Color.Black;
		this.label183.Location = new System.Drawing.Point(104, 1566);
		this.label183.Name = "label183";
		this.label183.Size = new System.Drawing.Size(82, 54);
		this.label183.TabIndex = 5909;
		this.label183.Text = "66";
		this.label183.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label183.Click += new System.EventHandler(label26_Click);
		this.label184.AutoSize = true;
		this.label184.BackColor = System.Drawing.Color.Aquamarine;
		this.label184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label184.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label184.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label184.ForeColor = System.Drawing.Color.Black;
		this.label184.Location = new System.Drawing.Point(285, 1188);
		this.label184.Name = "label184";
		this.label184.Size = new System.Drawing.Size(81, 54);
		this.label184.TabIndex = 5909;
		this.label184.Text = "23";
		this.label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label184.Click += new System.EventHandler(label26_Click);
		this.label186.AutoSize = true;
		this.label186.BackColor = System.Drawing.Color.Aquamarine;
		this.label186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label186.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label186.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label186.ForeColor = System.Drawing.Color.Black;
		this.label186.Location = new System.Drawing.Point(285, 1242);
		this.label186.Name = "label186";
		this.label186.Size = new System.Drawing.Size(81, 54);
		this.label186.TabIndex = 5909;
		this.label186.Text = "24";
		this.label186.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label186.Click += new System.EventHandler(label26_Click);
		this.label187.AutoSize = true;
		this.label187.BackColor = System.Drawing.Color.Aquamarine;
		this.label187.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label187.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label187.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label187.ForeColor = System.Drawing.Color.Black;
		this.label187.Location = new System.Drawing.Point(285, 1296);
		this.label187.Name = "label187";
		this.label187.Size = new System.Drawing.Size(81, 54);
		this.label187.TabIndex = 5909;
		this.label187.Text = "25";
		this.label187.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label187.Click += new System.EventHandler(label26_Click);
		this.label188.AutoSize = true;
		this.label188.BackColor = System.Drawing.Color.Aquamarine;
		this.label188.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label188.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label188.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label188.ForeColor = System.Drawing.Color.Black;
		this.label188.Location = new System.Drawing.Point(285, 1350);
		this.label188.Name = "label188";
		this.label188.Size = new System.Drawing.Size(81, 54);
		this.label188.TabIndex = 5909;
		this.label188.Text = "26";
		this.label188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label188.Click += new System.EventHandler(label26_Click);
		this.label190.AutoSize = true;
		this.label190.BackColor = System.Drawing.Color.Aquamarine;
		this.label190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label190.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label190.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label190.ForeColor = System.Drawing.Color.Black;
		this.label190.Location = new System.Drawing.Point(285, 1404);
		this.label190.Name = "label190";
		this.label190.Size = new System.Drawing.Size(81, 54);
		this.label190.TabIndex = 5909;
		this.label190.Text = "27";
		this.label190.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label190.Click += new System.EventHandler(label26_Click);
		this.label191.AutoSize = true;
		this.label191.BackColor = System.Drawing.Color.Aquamarine;
		this.label191.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label191.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label191.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label191.ForeColor = System.Drawing.Color.Black;
		this.label191.Location = new System.Drawing.Point(285, 1458);
		this.label191.Name = "label191";
		this.label191.Size = new System.Drawing.Size(81, 54);
		this.label191.TabIndex = 5909;
		this.label191.Text = "28";
		this.label191.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label191.Click += new System.EventHandler(label26_Click);
		this.label192.AutoSize = true;
		this.label192.BackColor = System.Drawing.Color.Aquamarine;
		this.label192.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label192.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label192.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label192.ForeColor = System.Drawing.Color.Black;
		this.label192.Location = new System.Drawing.Point(285, 1512);
		this.label192.Name = "label192";
		this.label192.Size = new System.Drawing.Size(81, 54);
		this.label192.TabIndex = 5909;
		this.label192.Text = "29";
		this.label192.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label192.Click += new System.EventHandler(label26_Click);
		this.label194.AutoSize = true;
		this.label194.BackColor = System.Drawing.Color.Aquamarine;
		this.label194.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label194.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label194.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label194.ForeColor = System.Drawing.Color.Black;
		this.label194.Location = new System.Drawing.Point(285, 1566);
		this.label194.Name = "label194";
		this.label194.Size = new System.Drawing.Size(81, 54);
		this.label194.TabIndex = 5909;
		this.label194.Text = "30";
		this.label194.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label194.Click += new System.EventHandler(label26_Click);
		this.label195.AutoSize = true;
		this.label195.BackColor = System.Drawing.Color.Aquamarine;
		this.label195.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label195.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label195.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label195.ForeColor = System.Drawing.Color.Black;
		this.label195.Location = new System.Drawing.Point(285, 1620);
		this.label195.Name = "label195";
		this.label195.Size = new System.Drawing.Size(81, 54);
		this.label195.TabIndex = 5909;
		this.label195.Text = "31";
		this.label195.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label195.Click += new System.EventHandler(label26_Click);
		this.label196.AutoSize = true;
		this.label196.BackColor = System.Drawing.Color.Aquamarine;
		this.label196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label196.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label196.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label196.ForeColor = System.Drawing.Color.Black;
		this.label196.Location = new System.Drawing.Point(285, 1674);
		this.label196.Name = "label196";
		this.label196.Size = new System.Drawing.Size(81, 54);
		this.label196.TabIndex = 5909;
		this.label196.Text = "32";
		this.label196.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label196.Click += new System.EventHandler(label26_Click);
		this.label198.AutoSize = true;
		this.label198.BackColor = System.Drawing.Color.Aquamarine;
		this.label198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label198.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label198.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label198.ForeColor = System.Drawing.Color.Black;
		this.label198.Location = new System.Drawing.Point(285, 1728);
		this.label198.Name = "label198";
		this.label198.Size = new System.Drawing.Size(81, 54);
		this.label198.TabIndex = 5909;
		this.label198.Text = "33";
		this.label198.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label198.Click += new System.EventHandler(label26_Click);
		this.label199.AutoSize = true;
		this.label199.BackColor = System.Drawing.Color.Aquamarine;
		this.label199.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label199.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label199.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label199.ForeColor = System.Drawing.Color.Black;
		this.label199.Location = new System.Drawing.Point(285, 1782);
		this.label199.Name = "label199";
		this.label199.Size = new System.Drawing.Size(81, 54);
		this.label199.TabIndex = 5909;
		this.label199.Text = "34";
		this.label199.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label199.Click += new System.EventHandler(label26_Click);
		this.label200.AutoSize = true;
		this.label200.BackColor = System.Drawing.Color.Aquamarine;
		this.label200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label200.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label200.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label200.ForeColor = System.Drawing.Color.Black;
		this.label200.Location = new System.Drawing.Point(285, 1836);
		this.label200.Name = "label200";
		this.label200.Size = new System.Drawing.Size(81, 54);
		this.label200.TabIndex = 5909;
		this.label200.Text = "35";
		this.label200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label200.Click += new System.EventHandler(label26_Click);
		this.label202.AutoSize = true;
		this.label202.BackColor = System.Drawing.Color.Aquamarine;
		this.label202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label202.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label202.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label202.ForeColor = System.Drawing.Color.Black;
		this.label202.Location = new System.Drawing.Point(285, 1890);
		this.label202.Name = "label202";
		this.label202.Size = new System.Drawing.Size(81, 65);
		this.label202.TabIndex = 5909;
		this.label202.Text = "36";
		this.label202.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label202.Click += new System.EventHandler(label26_Click);
		this.label203.AutoSize = true;
		this.label203.BackColor = System.Drawing.Color.Aquamarine;
		this.label203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label203.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label203.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label203.ForeColor = System.Drawing.Color.Black;
		this.label203.Location = new System.Drawing.Point(104, 1890);
		this.label203.Name = "label203";
		this.label203.Size = new System.Drawing.Size(82, 65);
		this.label203.TabIndex = 5909;
		this.label203.Text = "72";
		this.label203.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label203.Click += new System.EventHandler(label26_Click);
		this.label204.AutoSize = true;
		this.label204.BackColor = System.Drawing.Color.Aquamarine;
		this.label204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label204.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label204.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label204.ForeColor = System.Drawing.Color.Black;
		this.label204.Location = new System.Drawing.Point(104, 1836);
		this.label204.Name = "label204";
		this.label204.Size = new System.Drawing.Size(82, 54);
		this.label204.TabIndex = 5909;
		this.label204.Text = "71";
		this.label204.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label204.Click += new System.EventHandler(label26_Click);
		this.label206.AutoSize = true;
		this.label206.BackColor = System.Drawing.Color.Aquamarine;
		this.label206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label206.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label206.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label206.ForeColor = System.Drawing.Color.Black;
		this.label206.Location = new System.Drawing.Point(104, 1782);
		this.label206.Name = "label206";
		this.label206.Size = new System.Drawing.Size(82, 54);
		this.label206.TabIndex = 5909;
		this.label206.Text = "70";
		this.label206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label206.Click += new System.EventHandler(label26_Click);
		this.label207.AutoSize = true;
		this.label207.BackColor = System.Drawing.Color.Aquamarine;
		this.label207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label207.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label207.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label207.ForeColor = System.Drawing.Color.Black;
		this.label207.Location = new System.Drawing.Point(104, 1728);
		this.label207.Name = "label207";
		this.label207.Size = new System.Drawing.Size(82, 54);
		this.label207.TabIndex = 5909;
		this.label207.Text = "69";
		this.label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label207.Click += new System.EventHandler(label26_Click);
		this.label208.AutoSize = true;
		this.label208.BackColor = System.Drawing.Color.Aquamarine;
		this.label208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label208.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label208.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label208.ForeColor = System.Drawing.Color.Black;
		this.label208.Location = new System.Drawing.Point(104, 1674);
		this.label208.Name = "label208";
		this.label208.Size = new System.Drawing.Size(82, 54);
		this.label208.TabIndex = 5909;
		this.label208.Text = "68";
		this.label208.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label208.Click += new System.EventHandler(label26_Click);
		this.label210.AutoSize = true;
		this.label210.BackColor = System.Drawing.Color.Aquamarine;
		this.label210.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label210.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label210.Font = new System.Drawing.Font("Tahoma", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label210.ForeColor = System.Drawing.Color.Black;
		this.label210.Location = new System.Drawing.Point(104, 1620);
		this.label210.Name = "label210";
		this.label210.Size = new System.Drawing.Size(82, 54);
		this.label210.TabIndex = 5909;
		this.label210.Text = "67";
		this.label210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label210.Click += new System.EventHandler(label26_Click);
		this.label47.AutoSize = true;
		this.label47.BackColor = System.Drawing.Color.LightCyan;
		this.label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label47.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label47.Location = new System.Drawing.Point(1236, 378);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(88, 54);
		this.label47.TabIndex = 35;
		this.label47.Text = "117";
		this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label78.AutoSize = true;
		this.label78.BackColor = System.Drawing.Color.LightCyan;
		this.label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label78.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label78.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label78.Location = new System.Drawing.Point(965, 378);
		this.label78.Name = "label78";
		this.label78.Size = new System.Drawing.Size(265, 54);
		this.label78.TabIndex = 0;
		this.label78.Text = "هیوا عبدالله خدر- هەڵوێست ژاژڵەیی";
		this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s117s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s117s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s117s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s117s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s117s.Location = new System.Drawing.Point(856, 381);
		this.s117s.Multiline = true;
		this.s117s.Name = "s117s";
		this.s117s.Size = new System.Drawing.Size(103, 48);
		this.s117s.TabIndex = 8;
		this.s117s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s117s.Click += new System.EventHandler(h120_Click);
		this.s117s.TextChanged += new System.EventHandler(h120_TextChanged);
		this.s117s.KeyDown += new System.Windows.Forms.KeyEventHandler(h120_KeyDown);
		this.s117s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h120_KeyPress);
		this.s117s.Leave += new System.EventHandler(h120_Leave);
		this.label88.AutoSize = true;
		this.label88.BackColor = System.Drawing.Color.LightCyan;
		this.label88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label88.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label88.Location = new System.Drawing.Point(1236, 432);
		this.label88.Name = "label88";
		this.label88.Size = new System.Drawing.Size(88, 54);
		this.label88.TabIndex = 76;
		this.label88.Text = "119";
		this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label84.AutoSize = true;
		this.label84.BackColor = System.Drawing.Color.LightCyan;
		this.label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label84.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label84.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label84.Location = new System.Drawing.Point(1236, 486);
		this.label84.Name = "label84";
		this.label84.Size = new System.Drawing.Size(88, 54);
		this.label84.TabIndex = 72;
		this.label84.Text = "121";
		this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label82.AutoSize = true;
		this.label82.BackColor = System.Drawing.Color.LightCyan;
		this.label82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label82.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label82.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label82.Location = new System.Drawing.Point(965, 432);
		this.label82.Name = "label82";
		this.label82.Size = new System.Drawing.Size(265, 54);
		this.label82.TabIndex = 0;
		this.label82.Text = "جبار محمد رضا صۆڵەیی";
		this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s119s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s119s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s119s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s119s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s119s.Location = new System.Drawing.Point(856, 435);
		this.s119s.Multiline = true;
		this.s119s.Name = "s119s";
		this.s119s.Size = new System.Drawing.Size(103, 48);
		this.s119s.TabIndex = 9;
		this.s119s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s119s.Click += new System.EventHandler(h123_Click);
		this.s119s.TextChanged += new System.EventHandler(h123_TextChanged);
		this.s119s.KeyDown += new System.Windows.Forms.KeyEventHandler(h123_KeyDown);
		this.s119s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h123_KeyPress);
		this.s119s.Leave += new System.EventHandler(h123_Leave);
		this.label86.AutoSize = true;
		this.label86.BackColor = System.Drawing.Color.LightCyan;
		this.label86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label86.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label86.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label86.Location = new System.Drawing.Point(965, 486);
		this.label86.Name = "label86";
		this.label86.Size = new System.Drawing.Size(265, 54);
		this.label86.TabIndex = 0;
		this.label86.Text = "پارێزەری ڕاوێژکار کارزان کمال شریف";
		this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s121s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s121s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s121s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s121s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s121s.Location = new System.Drawing.Point(856, 489);
		this.s121s.Multiline = true;
		this.s121s.Name = "s121s";
		this.s121s.Size = new System.Drawing.Size(103, 48);
		this.s121s.TabIndex = 10;
		this.s121s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s121s.Click += new System.EventHandler(h129_Click);
		this.s121s.TextChanged += new System.EventHandler(h129_TextChanged);
		this.s121s.KeyDown += new System.Windows.Forms.KeyEventHandler(h129_KeyDown);
		this.s121s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h129_KeyPress);
		this.s121s.Leave += new System.EventHandler(h129_Leave);
		this.label80.AutoSize = true;
		this.label80.BackColor = System.Drawing.Color.LightCyan;
		this.label80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label80.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label80.Location = new System.Drawing.Point(1236, 540);
		this.label80.Name = "label80";
		this.label80.Size = new System.Drawing.Size(88, 54);
		this.label80.TabIndex = 68;
		this.label80.Text = "122";
		this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label136.AutoSize = true;
		this.label136.BackColor = System.Drawing.Color.LightCyan;
		this.label136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label136.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label136.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label136.Location = new System.Drawing.Point(965, 540);
		this.label136.Name = "label136";
		this.label136.Size = new System.Drawing.Size(265, 54);
		this.label136.TabIndex = 0;
		this.label136.Text = "مامۆستا ئالان";
		this.label136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s122s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s122s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s122s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s122s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s122s.Location = new System.Drawing.Point(856, 543);
		this.s122s.Multiline = true;
		this.s122s.Name = "s122s";
		this.s122s.Size = new System.Drawing.Size(103, 48);
		this.s122s.TabIndex = 11;
		this.s122s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s122s.Click += new System.EventHandler(h131_Click);
		this.s122s.TextChanged += new System.EventHandler(h131_TextChanged);
		this.s122s.KeyDown += new System.Windows.Forms.KeyEventHandler(h131_KeyDown);
		this.s122s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h131_KeyPress);
		this.s122s.Leave += new System.EventHandler(h131_Leave);
		this.label76.AutoSize = true;
		this.label76.BackColor = System.Drawing.Color.LightCyan;
		this.label76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label76.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label76.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label76.Location = new System.Drawing.Point(1236, 594);
		this.label76.Name = "label76";
		this.label76.Size = new System.Drawing.Size(88, 54);
		this.label76.TabIndex = 64;
		this.label76.Text = "123";
		this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label138.AutoSize = true;
		this.label138.BackColor = System.Drawing.Color.LightCyan;
		this.label138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label138.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label138.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label138.Location = new System.Drawing.Point(965, 594);
		this.label138.Name = "label138";
		this.label138.Size = new System.Drawing.Size(265, 54);
		this.label138.TabIndex = 0;
		this.label138.Text = "بزوتنەوەى پەیوەندی ئیسلامى کوردستان";
		this.label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s123s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s123s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s123s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s123s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s123s.Location = new System.Drawing.Point(856, 597);
		this.s123s.Multiline = true;
		this.s123s.Name = "s123s";
		this.s123s.Size = new System.Drawing.Size(103, 48);
		this.s123s.TabIndex = 12;
		this.s123s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s123s.Click += new System.EventHandler(h133_Click);
		this.s123s.TextChanged += new System.EventHandler(h133_TextChanged);
		this.s123s.KeyDown += new System.Windows.Forms.KeyEventHandler(h133_KeyDown);
		this.s123s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h133_KeyPress);
		this.s123s.Leave += new System.EventHandler(h133_Leave);
		this.label72.AutoSize = true;
		this.label72.BackColor = System.Drawing.Color.LightCyan;
		this.label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label72.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label72.Location = new System.Drawing.Point(1236, 648);
		this.label72.Name = "label72";
		this.label72.Size = new System.Drawing.Size(88, 54);
		this.label72.TabIndex = 60;
		this.label72.Text = "124";
		this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label139.AutoSize = true;
		this.label139.BackColor = System.Drawing.Color.LightCyan;
		this.label139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label139.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label139.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label139.Location = new System.Drawing.Point(965, 648);
		this.label139.Name = "label139";
		this.label139.Size = new System.Drawing.Size(265, 54);
		this.label139.TabIndex = 0;
		this.label139.Text = "طالب دارا سۆیلە قەرەچەتانی ";
		this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s124s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s124s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s124s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s124s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s124s.Location = new System.Drawing.Point(856, 651);
		this.s124s.Multiline = true;
		this.s124s.Name = "s124s";
		this.s124s.Size = new System.Drawing.Size(103, 48);
		this.s124s.TabIndex = 13;
		this.s124s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s124s.Click += new System.EventHandler(h139_Click);
		this.s124s.TextChanged += new System.EventHandler(h139_TextChanged);
		this.s124s.KeyDown += new System.Windows.Forms.KeyEventHandler(h139_KeyDown);
		this.s124s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h139_KeyPress);
		this.s124s.Leave += new System.EventHandler(h139_Leave);
		this.label69.AutoSize = true;
		this.label69.BackColor = System.Drawing.Color.LightCyan;
		this.label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label69.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label69.Location = new System.Drawing.Point(1236, 702);
		this.label69.Name = "label69";
		this.label69.Size = new System.Drawing.Size(88, 54);
		this.label69.TabIndex = 57;
		this.label69.Text = "125";
		this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label140.AutoSize = true;
		this.label140.BackColor = System.Drawing.Color.LightCyan;
		this.label140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label140.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label140.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label140.Location = new System.Drawing.Point(965, 702);
		this.label140.Name = "label140";
		this.label140.Size = new System.Drawing.Size(265, 54);
		this.label140.TabIndex = 0;
		this.label140.Text = "برهان-مەلا وشیار شیلەخانی ";
		this.label140.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s125s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s125s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s125s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s125s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s125s.Location = new System.Drawing.Point(856, 705);
		this.s125s.Multiline = true;
		this.s125s.Name = "s125s";
		this.s125s.Size = new System.Drawing.Size(103, 48);
		this.s125s.TabIndex = 14;
		this.s125s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s125s.Click += new System.EventHandler(h144_Click);
		this.s125s.TextChanged += new System.EventHandler(h144_TextChanged);
		this.s125s.KeyDown += new System.Windows.Forms.KeyEventHandler(h144_KeyDown);
		this.s125s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h144_KeyPress);
		this.s125s.Leave += new System.EventHandler(h144_Leave);
		this.label247.AutoSize = true;
		this.label247.BackColor = System.Drawing.Color.LightCyan;
		this.label247.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label247.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label247.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label247.Location = new System.Drawing.Point(1236, 756);
		this.label247.Name = "label247";
		this.label247.Size = new System.Drawing.Size(88, 54);
		this.label247.TabIndex = 110;
		this.label247.Text = "128";
		this.label247.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label142.AutoSize = true;
		this.label142.BackColor = System.Drawing.Color.LightCyan;
		this.label142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label142.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label142.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label142.Location = new System.Drawing.Point(965, 756);
		this.label142.Name = "label142";
		this.label142.Size = new System.Drawing.Size(265, 54);
		this.label142.TabIndex = 0;
		this.label142.Text = "وەستا عوزێر";
		this.label142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s128s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s128s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s128s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s128s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s128s.Location = new System.Drawing.Point(856, 759);
		this.s128s.Multiline = true;
		this.s128s.Name = "s128s";
		this.s128s.Size = new System.Drawing.Size(103, 48);
		this.s128s.TabIndex = 15;
		this.s128s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s128s.Click += new System.EventHandler(h146_Click);
		this.s128s.TextChanged += new System.EventHandler(h146_TextChanged);
		this.s128s.KeyDown += new System.Windows.Forms.KeyEventHandler(h146_KeyDown);
		this.s128s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h146_KeyPress);
		this.s128s.Leave += new System.EventHandler(h146_Leave);
		this.label251.AutoSize = true;
		this.label251.BackColor = System.Drawing.Color.Aquamarine;
		this.label251.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label251.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label251.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label251.Location = new System.Drawing.Point(1236, 810);
		this.label251.Name = "label251";
		this.label251.Size = new System.Drawing.Size(88, 54);
		this.label251.TabIndex = 114;
		this.label251.Text = "129";
		this.label251.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label143.AutoSize = true;
		this.label143.BackColor = System.Drawing.Color.Aquamarine;
		this.label143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label143.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label143.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label143.Location = new System.Drawing.Point(965, 810);
		this.label143.Name = "label143";
		this.label143.Size = new System.Drawing.Size(265, 54);
		this.label143.TabIndex = 0;
		this.label143.Text = "یەکێتی نیشتیمانی کوردستان";
		this.label143.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s129s.BackColor = System.Drawing.Color.Aquamarine;
		this.s129s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s129s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s129s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s129s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s129s.Location = new System.Drawing.Point(856, 813);
		this.s129s.Multiline = true;
		this.s129s.Name = "s129s";
		this.s129s.Size = new System.Drawing.Size(103, 48);
		this.s129s.TabIndex = 16;
		this.s129s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s129s.Click += new System.EventHandler(h147_Click);
		this.s129s.TextChanged += new System.EventHandler(h147_TextChanged);
		this.s129s.KeyDown += new System.Windows.Forms.KeyEventHandler(h147_KeyDown);
		this.s129s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h147_KeyPress);
		this.s129s.Leave += new System.EventHandler(h147_Leave);
		this.s130s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s130s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s130s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s130s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s130s.Location = new System.Drawing.Point(856, 867);
		this.s130s.Multiline = true;
		this.s130s.Name = "s130s";
		this.s130s.Size = new System.Drawing.Size(103, 48);
		this.s130s.TabIndex = 17;
		this.s130s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s130s.Click += new System.EventHandler(h148_Click);
		this.s130s.TextChanged += new System.EventHandler(h148_TextChanged);
		this.s130s.KeyDown += new System.Windows.Forms.KeyEventHandler(h148_KeyDown);
		this.s130s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h148_KeyPress);
		this.s130s.Leave += new System.EventHandler(h148_Leave);
		this.label144.AutoSize = true;
		this.label144.BackColor = System.Drawing.Color.LightCyan;
		this.label144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label144.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label144.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label144.Location = new System.Drawing.Point(965, 864);
		this.label144.Name = "label144";
		this.label144.Size = new System.Drawing.Size(265, 54);
		this.label144.TabIndex = 0;
		this.label144.Text = "پارێزەر طارق ملا فائق جاف";
		this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label255.AutoSize = true;
		this.label255.BackColor = System.Drawing.Color.LightCyan;
		this.label255.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label255.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label255.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label255.Location = new System.Drawing.Point(1236, 864);
		this.label255.Name = "label255";
		this.label255.Size = new System.Drawing.Size(88, 54);
		this.label255.TabIndex = 118;
		this.label255.Text = "130";
		this.label255.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label259.AutoSize = true;
		this.label259.BackColor = System.Drawing.Color.LightCyan;
		this.label259.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label259.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label259.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label259.Location = new System.Drawing.Point(1236, 918);
		this.label259.Name = "label259";
		this.label259.Size = new System.Drawing.Size(88, 54);
		this.label259.TabIndex = 122;
		this.label259.Text = "133";
		this.label259.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label146.AutoSize = true;
		this.label146.BackColor = System.Drawing.Color.LightCyan;
		this.label146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label146.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label146.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label146.Location = new System.Drawing.Point(965, 918);
		this.label146.Name = "label146";
		this.label146.Size = new System.Drawing.Size(265, 54);
		this.label146.TabIndex = 0;
		this.label146.Text = "هاوپەیمانی هەرێمی کوردستان";
		this.label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s133s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s133s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s133s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s133s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s133s.Location = new System.Drawing.Point(856, 921);
		this.s133s.Multiline = true;
		this.s133s.Name = "s133s";
		this.s133s.Size = new System.Drawing.Size(103, 48);
		this.s133s.TabIndex = 18;
		this.s133s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s133s.Click += new System.EventHandler(h149_Click);
		this.s133s.TextChanged += new System.EventHandler(h149_TextChanged);
		this.s133s.KeyDown += new System.Windows.Forms.KeyEventHandler(h149_KeyDown);
		this.s133s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h149_KeyPress);
		this.s133s.Leave += new System.EventHandler(h149_Leave);
		this.label263.AutoSize = true;
		this.label263.BackColor = System.Drawing.Color.LightCyan;
		this.label263.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label263.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label263.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label263.Location = new System.Drawing.Point(1236, 972);
		this.label263.Name = "label263";
		this.label263.Size = new System.Drawing.Size(88, 54);
		this.label263.TabIndex = 126;
		this.label263.Text = "135";
		this.label263.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label147.AutoSize = true;
		this.label147.BackColor = System.Drawing.Color.LightCyan;
		this.label147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label147.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label147.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label147.Location = new System.Drawing.Point(965, 972);
		this.label147.Name = "label147";
		this.label147.Size = new System.Drawing.Size(265, 54);
		this.label147.TabIndex = 0;
		this.label147.Text = "شێرزاد عبدالوهاب لطیف -مامە ڤاندام";
		this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s135s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s135s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s135s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s135s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s135s.Location = new System.Drawing.Point(856, 975);
		this.s135s.Multiline = true;
		this.s135s.Name = "s135s";
		this.s135s.Size = new System.Drawing.Size(103, 48);
		this.s135s.TabIndex = 19;
		this.s135s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s135s.Click += new System.EventHandler(h150_Click);
		this.s135s.TextChanged += new System.EventHandler(h150_TextChanged);
		this.s135s.KeyDown += new System.Windows.Forms.KeyEventHandler(h150_KeyDown);
		this.s135s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h150_KeyPress);
		this.s135s.Leave += new System.EventHandler(h150_Leave);
		this.label267.AutoSize = true;
		this.label267.BackColor = System.Drawing.Color.LightCyan;
		this.label267.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label267.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label267.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label267.Location = new System.Drawing.Point(1236, 1026);
		this.label267.Name = "label267";
		this.label267.Size = new System.Drawing.Size(88, 54);
		this.label267.TabIndex = 130;
		this.label267.Text = "136";
		this.label267.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label148.AutoSize = true;
		this.label148.BackColor = System.Drawing.Color.LightCyan;
		this.label148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label148.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label148.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label148.Location = new System.Drawing.Point(965, 1026);
		this.label148.Name = "label148";
		this.label148.Size = new System.Drawing.Size(265, 54);
		this.label148.TabIndex = 0;
		this.label148.Text = "بورهان علی";
		this.label148.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s136s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s136s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s136s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s136s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s136s.Location = new System.Drawing.Point(856, 1029);
		this.s136s.Multiline = true;
		this.s136s.Name = "s136s";
		this.s136s.Size = new System.Drawing.Size(103, 48);
		this.s136s.TabIndex = 20;
		this.s136s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s136s.Click += new System.EventHandler(h151_Click);
		this.s136s.TextChanged += new System.EventHandler(h151_TextChanged);
		this.s136s.KeyDown += new System.Windows.Forms.KeyEventHandler(h151_KeyDown);
		this.s136s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h151_KeyPress);
		this.s136s.Leave += new System.EventHandler(h151_Leave);
		this.label271.AutoSize = true;
		this.label271.BackColor = System.Drawing.Color.LightCyan;
		this.label271.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label271.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label271.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label271.Location = new System.Drawing.Point(1236, 1080);
		this.label271.Name = "label271";
		this.label271.Size = new System.Drawing.Size(88, 54);
		this.label271.TabIndex = 134;
		this.label271.Text = "137";
		this.label271.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label150.AutoSize = true;
		this.label150.BackColor = System.Drawing.Color.LightCyan;
		this.label150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label150.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label150.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label150.Location = new System.Drawing.Point(965, 1080);
		this.label150.Name = "label150";
		this.label150.Size = new System.Drawing.Size(265, 54);
		this.label150.TabIndex = 0;
		this.label150.Text = "سۆران عمر مۆریاسی ";
		this.label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s137s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s137s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s137s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s137s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s137s.Location = new System.Drawing.Point(856, 1083);
		this.s137s.Multiline = true;
		this.s137s.Name = "s137s";
		this.s137s.Size = new System.Drawing.Size(103, 48);
		this.s137s.TabIndex = 21;
		this.s137s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s137s.Click += new System.EventHandler(h154_Click);
		this.s137s.TextChanged += new System.EventHandler(h154_TextChanged);
		this.s137s.KeyDown += new System.Windows.Forms.KeyEventHandler(h154_KeyDown);
		this.s137s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h154_KeyPress);
		this.s137s.Leave += new System.EventHandler(h154_Leave);
		this.s138s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s138s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s138s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s138s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s138s.Location = new System.Drawing.Point(856, 1137);
		this.s138s.Multiline = true;
		this.s138s.Name = "s138s";
		this.s138s.Size = new System.Drawing.Size(103, 48);
		this.s138s.TabIndex = 22;
		this.s138s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s138s.Click += new System.EventHandler(h156_Click);
		this.s138s.TextChanged += new System.EventHandler(h156_TextChanged);
		this.s138s.KeyDown += new System.Windows.Forms.KeyEventHandler(h156_KeyDown);
		this.s138s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h156_KeyPress);
		this.s138s.Leave += new System.EventHandler(h156_Leave);
		this.label151.AutoSize = true;
		this.label151.BackColor = System.Drawing.Color.LightCyan;
		this.label151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label151.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label151.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label151.Location = new System.Drawing.Point(965, 1134);
		this.label151.Name = "label151";
		this.label151.Size = new System.Drawing.Size(265, 54);
		this.label151.TabIndex = 0;
		this.label151.Text = "عزیزی خانەنشینی ";
		this.label151.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label275.AutoSize = true;
		this.label275.BackColor = System.Drawing.Color.LightCyan;
		this.label275.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label275.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label275.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label275.Location = new System.Drawing.Point(1236, 1134);
		this.label275.Name = "label275";
		this.label275.Size = new System.Drawing.Size(88, 54);
		this.label275.TabIndex = 138;
		this.label275.Text = "138";
		this.label275.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label279.AutoSize = true;
		this.label279.BackColor = System.Drawing.Color.LightCyan;
		this.label279.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label279.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label279.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label279.Location = new System.Drawing.Point(1236, 1188);
		this.label279.Name = "label279";
		this.label279.Size = new System.Drawing.Size(88, 54);
		this.label279.TabIndex = 142;
		this.label279.Text = "145";
		this.label279.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label152.AutoSize = true;
		this.label152.BackColor = System.Drawing.Color.LightCyan;
		this.label152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label152.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label152.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label152.Location = new System.Drawing.Point(965, 1188);
		this.label152.Name = "label152";
		this.label152.Size = new System.Drawing.Size(265, 54);
		this.label152.TabIndex = 0;
		this.label152.Text = "م.فرهاد/قندیل/ئاکۆ";
		this.label152.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s145s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s145s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s145s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s145s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s145s.Location = new System.Drawing.Point(856, 1191);
		this.s145s.Multiline = true;
		this.s145s.Name = "s145s";
		this.s145s.Size = new System.Drawing.Size(103, 48);
		this.s145s.TabIndex = 23;
		this.s145s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s145s.Click += new System.EventHandler(h157_Click);
		this.s145s.TextChanged += new System.EventHandler(h157_TextChanged);
		this.s145s.KeyDown += new System.Windows.Forms.KeyEventHandler(h157_KeyDown);
		this.s145s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h157_KeyPress);
		this.s145s.Leave += new System.EventHandler(h157_Leave);
		this.s147s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s147s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s147s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s147s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s147s.Location = new System.Drawing.Point(856, 1245);
		this.s147s.Multiline = true;
		this.s147s.Name = "s147s";
		this.s147s.Size = new System.Drawing.Size(103, 48);
		this.s147s.TabIndex = 24;
		this.s147s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s147s.Click += new System.EventHandler(h158_Click);
		this.s147s.TextChanged += new System.EventHandler(h158_TextChanged);
		this.s147s.KeyDown += new System.Windows.Forms.KeyEventHandler(h158_KeyDown);
		this.s147s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h158_KeyPress);
		this.s147s.Leave += new System.EventHandler(h158_Leave);
		this.label154.AutoSize = true;
		this.label154.BackColor = System.Drawing.Color.LightCyan;
		this.label154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label154.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label154.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label154.Location = new System.Drawing.Point(965, 1242);
		this.label154.Name = "label154";
		this.label154.Size = new System.Drawing.Size(265, 54);
		this.label154.TabIndex = 0;
		this.label154.Text = "کۆمەڵی دادگەرى کوردستان/عێڕاق";
		this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label283.AutoSize = true;
		this.label283.BackColor = System.Drawing.Color.LightCyan;
		this.label283.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label283.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label283.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label283.Location = new System.Drawing.Point(1236, 1242);
		this.label283.Name = "label283";
		this.label283.Size = new System.Drawing.Size(88, 54);
		this.label283.TabIndex = 146;
		this.label283.Text = "147";
		this.label283.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label287.AutoSize = true;
		this.label287.BackColor = System.Drawing.Color.LightCyan;
		this.label287.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label287.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label287.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label287.Location = new System.Drawing.Point(1236, 1296);
		this.label287.Name = "label287";
		this.label287.Size = new System.Drawing.Size(88, 54);
		this.label287.TabIndex = 150;
		this.label287.Text = "148";
		this.label287.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label155.AutoSize = true;
		this.label155.BackColor = System.Drawing.Color.LightCyan;
		this.label155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label155.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label155.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label155.Location = new System.Drawing.Point(965, 1296);
		this.label155.Name = "label155";
		this.label155.Size = new System.Drawing.Size(265, 54);
		this.label155.TabIndex = 0;
		this.label155.Text = "یەکگرتووی ئیسلامی کوردستان ";
		this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s148s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s148s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s148s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s148s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s148s.Location = new System.Drawing.Point(856, 1299);
		this.s148s.Multiline = true;
		this.s148s.Name = "s148s";
		this.s148s.Size = new System.Drawing.Size(103, 48);
		this.s148s.TabIndex = 25;
		this.s148s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s148s.Click += new System.EventHandler(h160_Click);
		this.s148s.TextChanged += new System.EventHandler(h160_TextChanged);
		this.s148s.KeyDown += new System.Windows.Forms.KeyEventHandler(h160_KeyDown);
		this.s148s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h160_KeyPress);
		this.s148s.Leave += new System.EventHandler(h160_Leave);
		this.s153s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s153s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s153s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s153s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s153s.Location = new System.Drawing.Point(856, 1353);
		this.s153s.Multiline = true;
		this.s153s.Name = "s153s";
		this.s153s.Size = new System.Drawing.Size(103, 48);
		this.s153s.TabIndex = 26;
		this.s153s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s153s.Click += new System.EventHandler(h161_Click);
		this.s153s.TextChanged += new System.EventHandler(h161_TextChanged);
		this.s153s.KeyDown += new System.Windows.Forms.KeyEventHandler(h161_KeyDown);
		this.s153s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h161_KeyPress);
		this.s153s.Leave += new System.EventHandler(h161_Leave);
		this.label156.AutoSize = true;
		this.label156.BackColor = System.Drawing.Color.LightCyan;
		this.label156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label156.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label156.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label156.Location = new System.Drawing.Point(965, 1350);
		this.label156.Name = "label156";
		this.label156.Size = new System.Drawing.Size(265, 54);
		this.label156.TabIndex = 0;
		this.label156.Text = "مامۆستا مهدی";
		this.label156.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label291.AutoSize = true;
		this.label291.BackColor = System.Drawing.Color.LightCyan;
		this.label291.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label291.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label291.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label291.Location = new System.Drawing.Point(1236, 1350);
		this.label291.Name = "label291";
		this.label291.Size = new System.Drawing.Size(88, 54);
		this.label291.TabIndex = 154;
		this.label291.Text = "153";
		this.label291.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label295.AutoSize = true;
		this.label295.BackColor = System.Drawing.Color.LightCyan;
		this.label295.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label295.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label295.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label295.Location = new System.Drawing.Point(1236, 1404);
		this.label295.Name = "label295";
		this.label295.Size = new System.Drawing.Size(88, 54);
		this.label295.TabIndex = 158;
		this.label295.Text = "157";
		this.label295.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label158.AutoSize = true;
		this.label158.BackColor = System.Drawing.Color.LightCyan;
		this.label158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label158.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label158.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label158.Location = new System.Drawing.Point(965, 1404);
		this.label158.Name = "label158";
		this.label158.Size = new System.Drawing.Size(265, 54);
		this.label158.TabIndex = 0;
		this.label158.Text = "نەوەى نوێ";
		this.label158.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s157s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s157s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s157s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s157s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s157s.Location = new System.Drawing.Point(856, 1407);
		this.s157s.Multiline = true;
		this.s157s.Name = "s157s";
		this.s157s.Size = new System.Drawing.Size(103, 48);
		this.s157s.TabIndex = 27;
		this.s157s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s157s.Click += new System.EventHandler(h162_Click);
		this.s157s.TextChanged += new System.EventHandler(h162_TextChanged);
		this.s157s.KeyDown += new System.Windows.Forms.KeyEventHandler(h162_KeyDown);
		this.s157s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h162_KeyPress);
		this.s157s.Leave += new System.EventHandler(h162_Leave);
		this.label299.AutoSize = true;
		this.label299.BackColor = System.Drawing.Color.LightCyan;
		this.label299.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label299.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label299.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label299.Location = new System.Drawing.Point(1236, 1458);
		this.label299.Name = "label299";
		this.label299.Size = new System.Drawing.Size(88, 54);
		this.label299.TabIndex = 162;
		this.label299.Text = "161";
		this.label299.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label159.AutoSize = true;
		this.label159.BackColor = System.Drawing.Color.LightCyan;
		this.label159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label159.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label159.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label159.Location = new System.Drawing.Point(965, 1458);
		this.label159.Name = "label159";
		this.label159.Size = new System.Drawing.Size(265, 54);
		this.label159.TabIndex = 0;
		this.label159.Text = "هەڵوێست";
		this.label159.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s161s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s161s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s161s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s161s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s161s.Location = new System.Drawing.Point(856, 1461);
		this.s161s.Multiline = true;
		this.s161s.Name = "s161s";
		this.s161s.Size = new System.Drawing.Size(103, 48);
		this.s161s.TabIndex = 28;
		this.s161s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s161s.Click += new System.EventHandler(h164_Click);
		this.s161s.TextChanged += new System.EventHandler(h164_TextChanged);
		this.s161s.KeyDown += new System.Windows.Forms.KeyEventHandler(h164_KeyDown);
		this.s161s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h164_KeyPress);
		this.s161s.Leave += new System.EventHandler(h164_Leave);
		this.label303.AutoSize = true;
		this.label303.BackColor = System.Drawing.Color.LightCyan;
		this.label303.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label303.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label303.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label303.Location = new System.Drawing.Point(1236, 1512);
		this.label303.Name = "label303";
		this.label303.Size = new System.Drawing.Size(88, 54);
		this.label303.TabIndex = 166;
		this.label303.Text = "162";
		this.label303.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label160.AutoSize = true;
		this.label160.BackColor = System.Drawing.Color.LightCyan;
		this.label160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label160.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label160.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label160.Location = new System.Drawing.Point(965, 1512);
		this.label160.Name = "label160";
		this.label160.Size = new System.Drawing.Size(265, 54);
		this.label160.TabIndex = 0;
		this.label160.Text = "هاوپەیمانی نیشتیمانی ";
		this.label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s162s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s162s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s162s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s162s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s162s.Location = new System.Drawing.Point(856, 1515);
		this.s162s.Multiline = true;
		this.s162s.Name = "s162s";
		this.s162s.Size = new System.Drawing.Size(103, 48);
		this.s162s.TabIndex = 29;
		this.s162s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s162s.Click += new System.EventHandler(h167_Click);
		this.s162s.TextChanged += new System.EventHandler(h167_TextChanged);
		this.s162s.KeyDown += new System.Windows.Forms.KeyEventHandler(h167_KeyDown);
		this.s162s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h167_KeyPress);
		this.s162s.Leave += new System.EventHandler(h167_Leave);
		this.label307.AutoSize = true;
		this.label307.BackColor = System.Drawing.Color.LightCyan;
		this.label307.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label307.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label307.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label307.Location = new System.Drawing.Point(1236, 1566);
		this.label307.Name = "label307";
		this.label307.Size = new System.Drawing.Size(88, 54);
		this.label307.TabIndex = 170;
		this.label307.Text = "164";
		this.label307.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label162.AutoSize = true;
		this.label162.BackColor = System.Drawing.Color.LightCyan;
		this.label162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label162.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label162.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label162.Location = new System.Drawing.Point(965, 1566);
		this.label162.Name = "label162";
		this.label162.Size = new System.Drawing.Size(265, 54);
		this.label162.TabIndex = 0;
		this.label162.Text = "سەردەم";
		this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s164s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s164s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s164s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s164s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s164s.Location = new System.Drawing.Point(856, 1569);
		this.s164s.Multiline = true;
		this.s164s.Name = "s164s";
		this.s164s.Size = new System.Drawing.Size(103, 48);
		this.s164s.TabIndex = 30;
		this.s164s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s164s.Click += new System.EventHandler(h169_Click);
		this.s164s.TextChanged += new System.EventHandler(h169_TextChanged);
		this.s164s.KeyDown += new System.Windows.Forms.KeyEventHandler(h169_KeyDown);
		this.s164s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(h169_KeyPress);
		this.s164s.Leave += new System.EventHandler(h169_Leave);
		this.s165s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s165s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s165s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s165s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s165s.Location = new System.Drawing.Point(856, 1623);
		this.s165s.Multiline = true;
		this.s165s.Name = "s165s";
		this.s165s.Size = new System.Drawing.Size(103, 48);
		this.s165s.TabIndex = 31;
		this.s165s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s165s.Click += new System.EventHandler(h170_Click);
		this.s165s.TextChanged += new System.EventHandler(h170_TextChanged);
		this.s165s.KeyDown += new System.Windows.Forms.KeyEventHandler(h170_KeyDown);
		this.s165s.Leave += new System.EventHandler(h170_Leave);
		this.label163.AutoSize = true;
		this.label163.BackColor = System.Drawing.Color.LightCyan;
		this.label163.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label163.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label163.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label163.Location = new System.Drawing.Point(965, 1620);
		this.label163.Name = "label163";
		this.label163.Size = new System.Drawing.Size(265, 54);
		this.label163.TabIndex = 0;
		this.label163.Text = "ملکو بازیانی ژنگە";
		this.label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label311.AutoSize = true;
		this.label311.BackColor = System.Drawing.Color.LightCyan;
		this.label311.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label311.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label311.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label311.Location = new System.Drawing.Point(1236, 1620);
		this.label311.Name = "label311";
		this.label311.Size = new System.Drawing.Size(88, 54);
		this.label311.TabIndex = 174;
		this.label311.Text = "165";
		this.label311.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label14.AutoSize = true;
		this.label14.BackColor = System.Drawing.Color.LightCyan;
		this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label14.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(1236, 1674);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(88, 54);
		this.label14.TabIndex = 174;
		this.label14.Text = "166";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label17.AutoSize = true;
		this.label17.BackColor = System.Drawing.Color.LightCyan;
		this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label17.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label17.Location = new System.Drawing.Point(1236, 1728);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(88, 54);
		this.label17.TabIndex = 174;
		this.label17.Text = "168";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label21.AutoSize = true;
		this.label21.BackColor = System.Drawing.Color.LightCyan;
		this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label21.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label21.Location = new System.Drawing.Point(1236, 1782);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(88, 54);
		this.label21.TabIndex = 174;
		this.label21.Text = "169";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.AutoSize = true;
		this.label25.BackColor = System.Drawing.Color.LightCyan;
		this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label25.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label25.Location = new System.Drawing.Point(1236, 1836);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(88, 54);
		this.label25.TabIndex = 174;
		this.label25.Text = "171";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label164.AutoSize = true;
		this.label164.BackColor = System.Drawing.Color.LightCyan;
		this.label164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label164.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label164.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label164.Location = new System.Drawing.Point(965, 1674);
		this.label164.Name = "label164";
		this.label164.Size = new System.Drawing.Size(265, 54);
		this.label164.TabIndex = 0;
		this.label164.Text = "پارێزەر شێرزاد حمە علی";
		this.label164.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s166s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s166s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s166s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s166s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s166s.Location = new System.Drawing.Point(856, 1677);
		this.s166s.Multiline = true;
		this.s166s.Name = "s166s";
		this.s166s.Size = new System.Drawing.Size(103, 48);
		this.s166s.TabIndex = 32;
		this.s166s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s166s.Click += new System.EventHandler(s137_Click);
		this.s166s.TextChanged += new System.EventHandler(s137_TextChanged);
		this.s166s.KeyDown += new System.Windows.Forms.KeyEventHandler(s137_KeyDown);
		this.s166s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s137_KeyPress);
		this.s166s.Leave += new System.EventHandler(s137_Leave);
		this.label166.AutoSize = true;
		this.label166.BackColor = System.Drawing.Color.LightCyan;
		this.label166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label166.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label166.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label166.Location = new System.Drawing.Point(965, 1728);
		this.label166.Name = "label166";
		this.label166.Size = new System.Drawing.Size(265, 54);
		this.label166.TabIndex = 0;
		this.label166.Text = "طارق فائق";
		this.label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s168s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s168s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s168s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s168s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s168s.Location = new System.Drawing.Point(856, 1731);
		this.s168s.Multiline = true;
		this.s168s.Name = "s168s";
		this.s168s.Size = new System.Drawing.Size(103, 48);
		this.s168s.TabIndex = 33;
		this.s168s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s168s.Click += new System.EventHandler(s135_Click);
		this.s168s.TextChanged += new System.EventHandler(s135_TextChanged);
		this.s168s.KeyDown += new System.Windows.Forms.KeyEventHandler(s135_KeyDown);
		this.s168s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s135_KeyPress);
		this.s168s.Leave += new System.EventHandler(s135_Leave);
		this.label167.AutoSize = true;
		this.label167.BackColor = System.Drawing.Color.LightCyan;
		this.label167.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label167.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label167.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label167.Location = new System.Drawing.Point(965, 1782);
		this.label167.Name = "label167";
		this.label167.Size = new System.Drawing.Size(265, 54);
		this.label167.TabIndex = 0;
		this.label167.Text = "بەرەى گەل";
		this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s169s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s169s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s169s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s169s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s169s.Location = new System.Drawing.Point(856, 1785);
		this.s169s.Multiline = true;
		this.s169s.Name = "s169s";
		this.s169s.Size = new System.Drawing.Size(103, 48);
		this.s169s.TabIndex = 34;
		this.s169s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s169s.Click += new System.EventHandler(s133_Click);
		this.s169s.TextChanged += new System.EventHandler(s133_TextChanged);
		this.s169s.KeyDown += new System.Windows.Forms.KeyEventHandler(s133_KeyDown);
		this.s169s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s133_KeyPress);
		this.s169s.Leave += new System.EventHandler(s133_Leave);
		this.label168.AutoSize = true;
		this.label168.BackColor = System.Drawing.Color.LightCyan;
		this.label168.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label168.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label168.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label168.Location = new System.Drawing.Point(965, 1836);
		this.label168.Name = "label168";
		this.label168.Size = new System.Drawing.Size(265, 54);
		this.label168.TabIndex = 0;
		this.label168.Text = "مامۆستا هێرۆ محمد ";
		this.label168.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s171s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s171s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s171s.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s171s.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.s171s.Location = new System.Drawing.Point(856, 1839);
		this.s171s.Multiline = true;
		this.s171s.Name = "s171s";
		this.s171s.Size = new System.Drawing.Size(103, 48);
		this.s171s.TabIndex = 35;
		this.s171s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s171s.Click += new System.EventHandler(s198_Click);
		this.s171s.TextChanged += new System.EventHandler(s198_TextChanged);
		this.s171s.KeyDown += new System.Windows.Forms.KeyEventHandler(s198_KeyDown);
		this.s171s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(s198_KeyPress);
		this.s171s.Leave += new System.EventHandler(s198_Leave);
		this.label114.AutoSize = true;
		this.label114.BackColor = System.Drawing.Color.LightCyan;
		this.label114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label114.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label114.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label114.ForeColor = System.Drawing.Color.Black;
		this.label114.Location = new System.Drawing.Point(514, 972);
		this.label114.Name = "label114";
		this.label114.Size = new System.Drawing.Size(247, 54);
		this.label114.TabIndex = 5909;
		this.label114.Text = "سامان جمیل بویا";
		this.label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label114.Click += new System.EventHandler(label26_Click);
		this.label51.AutoSize = true;
		this.label51.BackColor = System.Drawing.Color.LightCyan;
		this.label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label51.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label51.ForeColor = System.Drawing.Color.Black;
		this.label51.Location = new System.Drawing.Point(767, 972);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(83, 54);
		this.label51.TabIndex = 5909;
		this.label51.Text = "236";
		this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label51.Click += new System.EventHandler(label26_Click);
		this.lbl_taswit.AutoSize = true;
		this.lbl_taswit.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.lbl_taswit.Location = new System.Drawing.Point(372, 108);
		this.lbl_taswit.Name = "lbl_taswit";
		this.lbl_taswit.Size = new System.Drawing.Size(23, 54);
		this.lbl_taswit.TabIndex = 5910;
		this.lbl_taswit.Text = "label43";
		this.labljorydangdan.AutoSize = true;
		this.labljorydangdan.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.labljorydangdan.Location = new System.Drawing.Point(372, 162);
		this.labljorydangdan.Name = "labljorydangdan";
		this.labljorydangdan.Size = new System.Drawing.Size(23, 54);
		this.labljorydangdan.TabIndex = 5910;
		this.labljorydangdan.Text = "label43";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1357, 833);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.bnltablsearch);
		base.Controls.Add(this.tableLayoutPanel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "S_Gshty";
		this.Text = "گشتی";
		base.Load += new System.EventHandler(add_Gshty_Load);
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.bnltablsearch.ResumeLayout(false);
		this.bnltablsearch.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.tableLayoutPanel3.ResumeLayout(false);
		this.tableLayoutPanel3.PerformLayout();
		this.tableLayoutPanel7.ResumeLayout(false);
		this.tableLayoutPanel7.PerformLayout();
		base.ResumeLayout(false);
	}
}
