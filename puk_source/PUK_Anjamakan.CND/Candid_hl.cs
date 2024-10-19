using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using PUK_Anjamakan.DAL;
using PUK_Anjamakan.Frm;
using PUK_Anjamakan.Properties;

namespace PUK_Anjamakan.CND;

public class Candid_hl : Form
{
	private SqlConnection connectionString = new SqlConnection("Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password);

	private CLS_PRODUCTS log = new CLS_PRODUCTS();

	private DataTable dt = new DataTable();

	private Home ho = new Home();

	private IContainer components = null;

	public Panel pnl_titil_ca;

	private Label label111;

	private Panel panel1;

	private TableLayoutPanel tableLayoutPanel3;

	public TextBox tex88;

	public TextBox tex87;

	public TextBox tex86;

	private Label label94;

	private Label label93;

	private Label label116;

	private Label label92;

	private Label label118;

	public TextBox s63;

	private Label label117;

	public TextBox s53;

	private Label label91;

	private Label label119;

	private Label label90;

	public TextBox s72;

	private Label label120;

	private Label label89;

	private Label label121;

	private Label label88;

	public TextBox s71;

	private Label label87;

	private Label label123;

	private Label label86;

	public TextBox s70;

	private Label label124;

	private Label label85;

	private Label label125;

	private Label label84;

	public TextBox s69;

	private Label label126;

	private Label label83;

	private Label label127;

	private Label label82;

	public TextBox s68;

	private Label label81;

	private Label label129;

	private Label label80;

	public TextBox s67;

	private Label label130;

	private Label label79;

	private Label label131;

	private Label label78;

	public TextBox s66;

	private Label label77;

	private Label label133;

	private Label label76;

	public TextBox s65;

	private Label label134;

	private Label label75;

	private Label label135;

	private Label label74;

	public TextBox s64;

	private Label label136;

	private Label label73;

	private Label label137;

	private Label label72;

	private Label label71;

	private Label label138;

	private Label label70;

	private Label label139;

	private Label label69;

	public TextBox s62;

	private Label label140;

	private Label label68;

	private Label label141;

	private Label label67;

	public TextBox s61;

	private Label label142;

	private Label label66;

	private Label label143;

	private Label label65;

	public TextBox s60;

	private Label label144;

	private Label label64;

	private Label label145;

	private Label label63;

	public TextBox s59;

	private Label label146;

	private Label label62;

	private Label label147;

	private Label label61;

	public TextBox s58;

	private Label label148;

	private Label label60;

	private Label label149;

	private Label label59;

	public TextBox s57;

	private Label label150;

	private Label label58;

	private Label label151;

	private Label label57;

	public TextBox s56;

	private Label label152;

	private Label label56;

	private Label label153;

	private Label label55;

	public TextBox tex89;

	private Label label154;

	private Label label54;

	private Label label155;

	private Label label53;

	public TextBox s55;

	private Label label156;

	private Label label52;

	private Label label157;

	private Label label51;

	public TextBox s54;

	private Label label158;

	private Label label50;

	private Label label159;

	private Label label49;

	private Label label48;

	private Label label160;

	private Label label47;

	private Label label161;

	private Label label46;

	public TextBox s52;

	private Label label162;

	private Label label45;

	private Label label163;

	private Label label44;

	public TextBox s51;

	private Label label164;

	private Label label43;

	private Label label165;

	private Label label42;

	public TextBox s50;

	private Label label166;

	private Label label41;

	private Label label167;

	private Label label40;

	public TextBox s49;

	public TextBox s48;

	public TextBox s47;

	public TextBox s46;

	public TextBox s45;

	public TextBox s44;

	public TextBox s43;

	public TextBox s42;

	public TextBox s41;

	public TextBox s40;

	public TextBox s39;

	private Label label168;

	private Label label39;

	private Label label170;

	private Label label169;

	private Label label172;

	private Label label38;

	private Label label174;

	private Label label37;

	private Label label176;

	private Label label171;

	private Label label178;

	private Label label36;

	private Label label180;

	private Label label35;

	private Label label173;

	private Label label184;

	private Label label34;

	private Label label186;

	private Label label33;

	private Label label188;

	private Label label32;

	private Label label31;

	private Label label30;

	private Label label29;

	private Label label28;

	private Label label27;

	private Label label26;

	private Label label25;

	private Label label24;

	private Label label23;

	private Label label22;

	private Label label21;

	private Label label20;

	private Label label19;

	private Label label18;

	public TextBox s2;

	public TextBox s3;

	public TextBox s4;

	public TextBox s11;

	public TextBox s5;

	public TextBox s9;

	public TextBox s6;

	public TextBox s7;

	public TextBox s12;

	public TextBox s8;

	public TextBox s13;

	public TextBox s17;

	public TextBox s16;

	public TextBox s14;

	public TextBox s18;

	private Button button9;

	private Button button8;

	public TextBox s19;

	public TextBox s20;

	private Button button7;

	public TextBox s22;

	public TextBox s24;

	public TextBox s21;

	public TextBox s38;

	public TextBox s23;

	public TextBox s37;

	public TextBox s25;

	public TextBox s36;

	public TextBox s35;

	public TextBox s34;

	public TextBox s33;

	public TextBox s32;

	public TextBox s31;

	public TextBox s30;

	public TextBox s29;

	public TextBox s28;

	public TextBox s27;

	public TextBox s26;

	public TextBox s15;

	public TextBox s10;

	public TextBox s1;

	private Button button10;

	private Button button11;

	private Button button12;

	private Label label189;

	private Label label187;

	private Label label185;

	private Label label183;

	private Label label181;

	private Label label179;

	private Label label177;

	private Label label175;

	private Label label182;

	private Label label132;

	private Label label128;

	private Label label122;

	private Label label95;

	private TableLayoutPanel tableLayoutPanel1;

	private Label label9;

	private Label label10;

	private Label label6;

	private Label label11;

	private Label label8;

	public TextBox txtcoodtasj;

	public TextBox txtbnkacood;

	private Label label3;

	public TextBox txtnawbnka;

	public TextBox txtparezga;

	private Label label1;

	public TextBox tex_total_s;

	private Button button1;

	public Guna2ComboBox comwestga;

	private SimpleButton simpleButton1;

	public Label txtwestga;

	public Label lbl_taswit;

	public Candid_hl()
	{
		InitializeComponent();
		txtcoler();
	}

	private void totals()
	{
		try
		{
			double To2 = (double)int.Parse(s1.Text) + Convert.ToDouble(s2.Text) + Convert.ToDouble(s3.Text) + Convert.ToDouble(s4.Text) + Convert.ToDouble(s5.Text) + Convert.ToDouble(s6.Text) + Convert.ToDouble(s7.Text) + Convert.ToDouble(s8.Text) + Convert.ToDouble(s9.Text) + Convert.ToDouble(s10.Text) + Convert.ToDouble(s11.Text) + Convert.ToDouble(s12.Text) + Convert.ToDouble(s13.Text) + Convert.ToDouble(s14.Text) + Convert.ToDouble(s15.Text) + Convert.ToDouble(s16.Text) + Convert.ToDouble(s17.Text) + Convert.ToDouble(s18.Text) + Convert.ToDouble(s19.Text) + Convert.ToDouble(s20.Text) + Convert.ToDouble(s21.Text) + Convert.ToDouble(s22.Text) + Convert.ToDouble(s23.Text) + Convert.ToDouble(s24.Text) + Convert.ToDouble(s25.Text) + Convert.ToDouble(s26.Text) + Convert.ToDouble(s27.Text) + Convert.ToDouble(s28.Text) + Convert.ToDouble(s29.Text) + Convert.ToDouble(s30.Text) + Convert.ToDouble(s31.Text) + Convert.ToDouble(s32.Text) + Convert.ToDouble(s33.Text) + Convert.ToDouble(s34.Text) + Convert.ToDouble(s35.Text) + Convert.ToDouble(s36.Text) + Convert.ToDouble(s37.Text) + Convert.ToDouble(s38.Text) + Convert.ToDouble(s39.Text) + Convert.ToDouble(s40.Text) + Convert.ToDouble(s41.Text) + Convert.ToDouble(s42.Text) + Convert.ToDouble(s43.Text) + Convert.ToDouble(s44.Text) + Convert.ToDouble(s45.Text) + Convert.ToDouble(s46.Text) + Convert.ToDouble(s47.Text) + Convert.ToDouble(s48.Text) + Convert.ToDouble(s49.Text) + Convert.ToDouble(s50.Text) + Convert.ToDouble(s51.Text) + Convert.ToDouble(s52.Text) + Convert.ToDouble(s53.Text) + Convert.ToDouble(s54.Text) + Convert.ToDouble(s55.Text) + Convert.ToDouble(tex89.Text) + Convert.ToDouble(s56.Text) + Convert.ToDouble(s57.Text) + Convert.ToDouble(s58.Text) + Convert.ToDouble(s59.Text) + Convert.ToDouble(s60.Text) + Convert.ToDouble(s61.Text) + Convert.ToDouble(s62.Text) + Convert.ToDouble(s63.Text) + Convert.ToDouble(s64.Text) + Convert.ToDouble(s65.Text) + Convert.ToDouble(s66.Text) + Convert.ToDouble(s67.Text) + Convert.ToDouble(s68.Text) + Convert.ToDouble(s69.Text) + Convert.ToDouble(s70.Text) + Convert.ToDouble(s71.Text) + Convert.ToDouble(s72.Text) + Convert.ToDouble(tex86.Text) + Convert.ToDouble(tex87.Text) + Convert.ToDouble(tex88.Text);
			tex_total_s.Text = To2.ToString();
		}
		catch
		{
		}
	}

	private void lblmalband_Click(object sender, EventArgs e)
	{
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void tex13_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex14_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex15_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex16_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex17_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex18_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex19_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex20_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex21_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex22_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex23_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex24_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex25_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex26_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex27_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex28_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex29_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex30_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex31_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex32_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex33_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex34_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex35_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex36_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex37_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex38_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex39_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex40_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex41_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex42_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex43_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex44_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex45_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex46_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex47_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex48_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex49_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex50_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex51_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex52_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex53_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex54_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex55_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex56_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex57_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex58_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex59_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex60_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex61_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex62_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex63_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex64_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex65_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex66_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex67_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex69_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex70_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex71_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex72_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex73_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex74_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex75_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex76_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex77_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex78_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex79_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex80_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex81_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex82_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex83_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex84_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex85_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex86_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex87_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex88_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex89_TextChanged(object sender, EventArgs e)
	{
		totals();
	}

	private void tex13_Leave(object sender, EventArgs e)
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

	private void tex14_Leave(object sender, EventArgs e)
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

	private void tex15_Leave(object sender, EventArgs e)
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

	private void tex16_Leave(object sender, EventArgs e)
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

	private void tex17_Leave(object sender, EventArgs e)
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

	private void tex18_Leave(object sender, EventArgs e)
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

	private void tex19_Leave(object sender, EventArgs e)
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

	private void tex20_Leave(object sender, EventArgs e)
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

	private void tex21_Leave(object sender, EventArgs e)
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

	private void tex22_Leave(object sender, EventArgs e)
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

	private void tex23_Leave(object sender, EventArgs e)
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

	private void tex24_Leave(object sender, EventArgs e)
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

	private void tex25_Leave(object sender, EventArgs e)
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

	private void tex26_Leave(object sender, EventArgs e)
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

	private void tex27_Leave(object sender, EventArgs e)
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

	private void tex28_Leave(object sender, EventArgs e)
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

	private void tex29_Leave(object sender, EventArgs e)
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

	private void tex30_Leave(object sender, EventArgs e)
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

	private void tex31_Leave(object sender, EventArgs e)
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

	private void tex32_Leave(object sender, EventArgs e)
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

	private void tex33_Leave(object sender, EventArgs e)
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

	private void tex34_Leave(object sender, EventArgs e)
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

	private void tex35_Leave(object sender, EventArgs e)
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

	private void tex36_Leave(object sender, EventArgs e)
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

	private void tex37_Leave(object sender, EventArgs e)
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

	private void tex38_Leave(object sender, EventArgs e)
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

	private void tex39_Leave(object sender, EventArgs e)
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

	private void tex40_Leave(object sender, EventArgs e)
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

	private void tex41_Leave(object sender, EventArgs e)
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

	private void tex42_Leave(object sender, EventArgs e)
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

	private void tex43_Leave(object sender, EventArgs e)
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

	private void tex44_Leave(object sender, EventArgs e)
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

	private void tex45_Leave(object sender, EventArgs e)
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

	private void tex46_Leave(object sender, EventArgs e)
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

	private void tex47_Leave(object sender, EventArgs e)
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

	private void tex48_Leave(object sender, EventArgs e)
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

	private void tex49_Leave(object sender, EventArgs e)
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

	private void tex50_Leave(object sender, EventArgs e)
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

	private void tex51_Leave(object sender, EventArgs e)
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

	private void tex52_Leave(object sender, EventArgs e)
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

	private void tex53_Leave(object sender, EventArgs e)
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

	private void tex54_Leave(object sender, EventArgs e)
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

	private void tex55_Leave(object sender, EventArgs e)
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

	private void tex56_Leave(object sender, EventArgs e)
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

	private void tex57_Leave(object sender, EventArgs e)
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

	private void tex58_Leave(object sender, EventArgs e)
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

	private void tex59_Leave(object sender, EventArgs e)
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

	private void tex60_Leave(object sender, EventArgs e)
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

	private void tex61_Leave(object sender, EventArgs e)
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

	private void tex62_Leave(object sender, EventArgs e)
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

	private void tex63_Leave(object sender, EventArgs e)
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

	private void tex64_Leave(object sender, EventArgs e)
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

	private void tex65_Leave(object sender, EventArgs e)
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

	private void tex66_Leave(object sender, EventArgs e)
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

	private void tex67_Leave(object sender, EventArgs e)
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

	private void tex69_Leave(object sender, EventArgs e)
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

	private void tex70_Leave(object sender, EventArgs e)
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

	private void tex71_Leave(object sender, EventArgs e)
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

	private void tex72_Leave(object sender, EventArgs e)
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

	private void tex73_Leave(object sender, EventArgs e)
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

	private void tex74_Leave(object sender, EventArgs e)
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

	private void tex75_Leave(object sender, EventArgs e)
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

	private void tex76_Leave(object sender, EventArgs e)
	{
		if (s63.Text == string.Empty)
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

	private void tex77_Leave(object sender, EventArgs e)
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

	private void tex78_Leave(object sender, EventArgs e)
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

	private void tex79_Leave(object sender, EventArgs e)
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

	private void tex80_Leave(object sender, EventArgs e)
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

	private void tex81_Leave(object sender, EventArgs e)
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

	private void tex82_Leave(object sender, EventArgs e)
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

	private void tex83_Leave(object sender, EventArgs e)
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

	private void tex84_Leave(object sender, EventArgs e)
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

	private void tex85_Leave(object sender, EventArgs e)
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

	private void tex86_Leave(object sender, EventArgs e)
	{
		if (tex86.Text == string.Empty)
		{
			tex86.Text = "0";
		}
		if (tex86.Text == "0")
		{
			tex86.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			tex86.ForeColor = Color.Black;
		}
	}

	private void tex87_Leave(object sender, EventArgs e)
	{
		if (tex87.Text == string.Empty)
		{
			tex87.Text = "0";
		}
		if (tex87.Text == "0")
		{
			tex87.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			tex87.ForeColor = Color.Black;
		}
	}

	private void tex88_Leave(object sender, EventArgs e)
	{
		if (tex88.Text == string.Empty)
		{
			tex88.Text = "0";
		}
		if (tex88.Text == "0")
		{
			tex88.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			tex88.ForeColor = Color.Black;
		}
	}

	private void tex89_Leave(object sender, EventArgs e)
	{
		if (tex89.Text == string.Empty)
		{
			tex89.Text = "0";
		}
		if (tex89.Text == "0")
		{
			tex89.ForeColor = Color.FromArgb(255, 192, 192);
		}
		else
		{
			tex89.ForeColor = Color.Black;
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

	private void tex30_KeyPress(object sender, KeyPressEventArgs e)
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

	private void tex32_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
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

	private void tex61_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex62_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex63_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex64_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex65_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex66_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex67_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex69_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex70_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex71_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex72_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex73_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex74_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex75_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex76_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex77_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex78_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex79_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex80_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex81_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex82_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex83_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex84_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex85_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex86_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex87_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex88_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex89_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void tex13_Click(object sender, EventArgs e)
	{
		s1.Text = "";
	}

	private void tex14_Click(object sender, EventArgs e)
	{
		s2.Text = "";
	}

	private void tex15_Click(object sender, EventArgs e)
	{
		s3.Text = "";
	}

	private void tex16_Click(object sender, EventArgs e)
	{
		s4.Text = "";
	}

	private void tex17_Click(object sender, EventArgs e)
	{
		s5.Text = "";
	}

	private void tex18_Click(object sender, EventArgs e)
	{
		s6.Text = "";
	}

	private void tex19_Click(object sender, EventArgs e)
	{
		s7.Text = "";
	}

	private void tex20_Click(object sender, EventArgs e)
	{
		s8.Text = "";
	}

	private void tex21_Click(object sender, EventArgs e)
	{
		s9.Text = "";
	}

	private void tex22_Click(object sender, EventArgs e)
	{
		s10.Text = "";
	}

	private void tex23_Click(object sender, EventArgs e)
	{
		s11.Text = "";
	}

	private void tex24_Click(object sender, EventArgs e)
	{
		s12.Text = "";
	}

	private void tex25_Click(object sender, EventArgs e)
	{
		s13.Text = "";
	}

	private void tex26_Click(object sender, EventArgs e)
	{
		s14.Text = "";
	}

	private void tex27_Click(object sender, EventArgs e)
	{
		s15.Text = "";
	}

	private void tex28_Click(object sender, EventArgs e)
	{
		s16.Text = "";
	}

	private void tex29_Click(object sender, EventArgs e)
	{
		s17.Text = "";
	}

	private void tex30_Click(object sender, EventArgs e)
	{
		s18.Text = "";
	}

	private void tex31_Click(object sender, EventArgs e)
	{
		s19.Text = "";
	}

	private void tex32_Click(object sender, EventArgs e)
	{
		s20.Text = "";
	}

	private void tex33_Click(object sender, EventArgs e)
	{
		s21.Text = "";
	}

	private void tex34_Click(object sender, EventArgs e)
	{
		s22.Text = "";
	}

	private void tex35_Click(object sender, EventArgs e)
	{
		s23.Text = "";
	}

	private void tex36_Click(object sender, EventArgs e)
	{
		s24.Text = "";
	}

	private void tex37_Click(object sender, EventArgs e)
	{
		s25.Text = "";
	}

	private void tex38_Click(object sender, EventArgs e)
	{
		s26.Text = "";
	}

	private void tex39_Click(object sender, EventArgs e)
	{
		s27.Text = "";
	}

	private void tex40_Click(object sender, EventArgs e)
	{
		s28.Text = "";
	}

	private void tex41_Click(object sender, EventArgs e)
	{
		s29.Text = "";
	}

	private void tex42_Click(object sender, EventArgs e)
	{
		s30.Text = "";
	}

	private void tex43_Click(object sender, EventArgs e)
	{
		s31.Text = "";
	}

	private void tex44_Click(object sender, EventArgs e)
	{
		s32.Text = "";
	}

	private void tex45_Click(object sender, EventArgs e)
	{
		s33.Text = "";
	}

	private void tex46_Click(object sender, EventArgs e)
	{
		s34.Text = "";
	}

	private void tex47_Click(object sender, EventArgs e)
	{
		s35.Text = "";
	}

	private void tex48_Click(object sender, EventArgs e)
	{
		s36.Text = "";
	}

	private void tex49_Click(object sender, EventArgs e)
	{
		s37.Text = "";
	}

	private void tex50_Click(object sender, EventArgs e)
	{
		s38.Text = "";
	}

	private void tex51_Click(object sender, EventArgs e)
	{
		s39.Text = "";
	}

	private void tex52_Click(object sender, EventArgs e)
	{
		s40.Text = "";
	}

	private void tex53_Click(object sender, EventArgs e)
	{
		s41.Text = "";
	}

	private void tex54_Click(object sender, EventArgs e)
	{
		s42.Text = "";
	}

	private void tex55_Click(object sender, EventArgs e)
	{
		s43.Text = "";
	}

	private void tex56_Click(object sender, EventArgs e)
	{
		s44.Text = "";
	}

	private void tex57_Click(object sender, EventArgs e)
	{
		s45.Text = "";
	}

	private void tex58_Click(object sender, EventArgs e)
	{
		s46.Text = "";
	}

	private void tex59_Click(object sender, EventArgs e)
	{
		s47.Text = "";
	}

	private void tex60_Click(object sender, EventArgs e)
	{
		s48.Text = "";
	}

	private void tex61_Click(object sender, EventArgs e)
	{
		s49.Text = "";
	}

	private void tex62_Click(object sender, EventArgs e)
	{
		s50.Text = "";
	}

	private void tex63_Click(object sender, EventArgs e)
	{
		s51.Text = "";
	}

	private void tex64_Click(object sender, EventArgs e)
	{
		s52.Text = "";
	}

	private void tex65_Click(object sender, EventArgs e)
	{
		s53.Text = "";
	}

	private void tex66_Click(object sender, EventArgs e)
	{
		s54.Text = "";
	}

	private void tex67_Click(object sender, EventArgs e)
	{
		s55.Text = "";
	}

	private void tex69_Click(object sender, EventArgs e)
	{
		s56.Text = "";
	}

	private void tex70_Click(object sender, EventArgs e)
	{
		s57.Text = "";
	}

	private void tex71_Click(object sender, EventArgs e)
	{
		s58.Text = "";
	}

	private void tex72_Click(object sender, EventArgs e)
	{
		s59.Text = "";
	}

	private void tex73_Click(object sender, EventArgs e)
	{
		s60.Text = "";
	}

	private void tex74_Click(object sender, EventArgs e)
	{
		s61.Text = "";
	}

	private void tex75_Click(object sender, EventArgs e)
	{
		s62.Text = "";
	}

	private void tex76_Click(object sender, EventArgs e)
	{
		s63.Text = "";
	}

	private void tex77_Click(object sender, EventArgs e)
	{
		s64.Text = "";
	}

	private void tex78_Click(object sender, EventArgs e)
	{
		s65.Text = "";
	}

	private void tex79_Click(object sender, EventArgs e)
	{
		s66.Text = "";
	}

	private void tex80_Click(object sender, EventArgs e)
	{
		s67.Text = "";
	}

	private void tex81_Click(object sender, EventArgs e)
	{
		s68.Text = "";
	}

	private void tex82_Click(object sender, EventArgs e)
	{
		s69.Text = "";
	}

	private void tex83_Click(object sender, EventArgs e)
	{
		s70.Text = "";
	}

	private void tex84_Click(object sender, EventArgs e)
	{
		s71.Text = "";
	}

	private void tex85_Click(object sender, EventArgs e)
	{
		s72.Text = "";
	}

	private void tex86_Click(object sender, EventArgs e)
	{
		tex86.Text = "";
	}

	private void tex87_Click(object sender, EventArgs e)
	{
		tex87.Text = "";
	}

	private void tex88_Click(object sender, EventArgs e)
	{
		tex88.Text = "";
	}

	private void tex89_Click(object sender, EventArgs e)
	{
		tex89.Text = "";
	}

	private void txtcoler()
	{
		List<TextBox> textBoxes = new List<TextBox>
		{
			s1, s2, s3, s4, s5, s6, s7, s8, s9, s10,
			s11, s12, s13, s14, s15, s16, s17, s18, s19, s20,
			s21, s22, s23, s24, s25, s26, s27, s28, s29, s30,
			s31, s32, s33, s34, s35, s36, s37, s38, s39, s40,
			s41, s42, s43, s44, s45, s46, s47, s48, s49, s50,
			s51, s52, s53, s54, s55, tex89, s56, s57, s58, s59,
			s60, s61, s62, s63, s64, s65, s66, s67, s68, s69,
			s70, s71, s72
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

	private void button1_Click(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty || comwestga.Text == string.Empty || txtparezga.Text == string.Empty)
		{
			MessageBox.Show("تکایە بنکەی دەنگدان و وێستگە هەڵبژێرە ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (tex_total_s.Text == "0")
		{
			MessageBox.Show("تکایە دەنگەکان تۆماربکەن", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		if (button1.Text == "Update")
		{
			Update_cabdid();
			txtclear();
			txtcoler();
			return;
		}
		DataTable bm = new DataTable();
		bm = log.get_candid_taybat_hl(int.Parse(txtbnkacood.Text), int.Parse(comwestga.Text));
		if (bm.Rows.Count > 0)
		{
			MessageBox.Show(" تۆمار کراوە تکایە بیگۆڕە", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		insert_cabdid();
		txtclear();
		txtcoler();
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

	private void Candid_T_Load(object sender, EventArgs e)
	{
	}

	private void insert_cabdid()
	{
		string qurey = "insert into candid_hl(naw_mahafaza,cood_tasjil,cood_bnka,jor_dangdan,\twestga,[1]\t,[2]\t,[3]\t,[4]\t,[5]\t,[6])VALUES (@naw_mahafaza,\t@cood_tasjil,\t@cood_bnka,@jor_dangdan,\t@westga,@1,@2,\t@3,\t@4,\t@5,\t@6)";
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@naw_mahafaza", txtparezga.Text);
		cmd.Parameters.AddWithValue("@cood_tasjil", txtcoodtasj.Text);
		cmd.Parameters.AddWithValue("@cood_bnka", txtbnkacood.Text);
		cmd.Parameters.AddWithValue("@jor_dangdan", lbl_taswit.Text);
		cmd.Parameters.AddWithValue("@westga", comwestga.Text);
		cmd.Parameters.AddWithValue("@1", s1.Text);
		cmd.Parameters.AddWithValue("@2", s2.Text);
		cmd.Parameters.AddWithValue("@3", s3.Text);
		cmd.Parameters.AddWithValue("@4", s4.Text);
		cmd.Parameters.AddWithValue("@5", s5.Text);
		cmd.Parameters.AddWithValue("@6", s6.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		MessageBox.Show("تۆمارکرا ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void pnl_titil_ca_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Update_cabdid()
	{
		string qurey = "Update candid_hl set [1]=@1,\t[2]=@2,\t[3]=@3,\t[4]=@4,\t[5]=@5,\t[6]=@6   WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand cmd = new SqlCommand(qurey, connectionString);
		connectionString.Open();
		cmd.Parameters.AddWithValue("@1", s1.Text);
		cmd.Parameters.AddWithValue("@2", s2.Text);
		cmd.Parameters.AddWithValue("@3", s3.Text);
		cmd.Parameters.AddWithValue("@4", s4.Text);
		cmd.Parameters.AddWithValue("@5", s5.Text);
		cmd.Parameters.AddWithValue("@6", s6.Text);
		cmd.ExecuteNonQuery();
		connectionString.Close();
		MessageBox.Show("تازةكرايةوة ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void comwestga_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (txtbnkacood.Text == string.Empty)
		{
			MessageBox.Show("تکایە ژمارەی بنکەی دەنگدان بنوسە ", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		string query = "SELECT *\r\n                         FROM candid_hl \r\n                         WHERE cood_bnka = " + txtbnkacood.Text + " and westga = " + comwestga.Text;
		SqlCommand command = new SqlCommand(query, connectionString);
		connectionString.Open();
		using (SqlDataReader reader = command.ExecuteReader())
		{
			if (reader.Read())
			{
				s1.Text = reader["1"].ToString();
				s2.Text = reader["2"].ToString();
				s3.Text = reader["3"].ToString();
				s4.Text = reader["4"].ToString();
				s5.Text = reader["5"].ToString();
				s6.Text = reader["6"].ToString();
				button1.Text = "Update";
				txtcoler();
			}
			else
			{
				txtclear();
				txtcoler();
				button1.Text = "تۆمارکردن";
			}
		}
		connectionString.Close();
	}

	private void txtclear()
	{
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
	}

	private void tableLayoutPanel1_Leave(object sender, EventArgs e)
	{
	}

	private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
	{
	}

	private void comwestga_Click(object sender, EventArgs e)
	{
		comboxvalue();
	}

	private void button1_MouseMove(object sender, MouseEventArgs e)
	{
		button1.BackColor = Color.Red;
	}

	private void label6_MouseMove(object sender, MouseEventArgs e)
	{
		button1.BackColor = Color.FromArgb(0, 192, 192);
	}

	private void tableLayoutPanel3_MouseMove(object sender, MouseEventArgs e)
	{
		button1.BackColor = Color.FromArgb(0, 192, 192);
	}

	private void comwestga_MouseMove(object sender, MouseEventArgs e)
	{
		button1.BackColor = Color.FromArgb(0, 192, 192);
	}

	private void txtcoodtasj_MouseMove(object sender, MouseEventArgs e)
	{
		button1.BackColor = Color.FromArgb(0, 192, 192);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUK_Anjamakan.CND.Candid_hl));
		this.pnl_titil_ca = new System.Windows.Forms.Panel();
		this.lbl_taswit = new System.Windows.Forms.Label();
		this.txtwestga = new System.Windows.Forms.Label();
		this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.comwestga = new Guna.UI2.WinForms.Guna2ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.txtcoodtasj = new System.Windows.Forms.TextBox();
		this.txtbnkacood = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.txtnawbnka = new System.Windows.Forms.TextBox();
		this.txtparezga = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.tex_total_s = new System.Windows.Forms.TextBox();
		this.button1 = new System.Windows.Forms.Button();
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.label111 = new System.Windows.Forms.Label();
		this.panel1 = new System.Windows.Forms.Panel();
		this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
		this.label93 = new System.Windows.Forms.Label();
		this.label92 = new System.Windows.Forms.Label();
		this.s53 = new System.Windows.Forms.TextBox();
		this.label91 = new System.Windows.Forms.Label();
		this.label90 = new System.Windows.Forms.Label();
		this.label89 = new System.Windows.Forms.Label();
		this.label88 = new System.Windows.Forms.Label();
		this.label87 = new System.Windows.Forms.Label();
		this.label86 = new System.Windows.Forms.Label();
		this.label85 = new System.Windows.Forms.Label();
		this.label84 = new System.Windows.Forms.Label();
		this.label83 = new System.Windows.Forms.Label();
		this.label82 = new System.Windows.Forms.Label();
		this.label81 = new System.Windows.Forms.Label();
		this.label80 = new System.Windows.Forms.Label();
		this.label79 = new System.Windows.Forms.Label();
		this.label78 = new System.Windows.Forms.Label();
		this.label77 = new System.Windows.Forms.Label();
		this.label76 = new System.Windows.Forms.Label();
		this.label75 = new System.Windows.Forms.Label();
		this.label74 = new System.Windows.Forms.Label();
		this.label73 = new System.Windows.Forms.Label();
		this.label72 = new System.Windows.Forms.Label();
		this.label71 = new System.Windows.Forms.Label();
		this.label70 = new System.Windows.Forms.Label();
		this.label69 = new System.Windows.Forms.Label();
		this.label68 = new System.Windows.Forms.Label();
		this.label67 = new System.Windows.Forms.Label();
		this.label66 = new System.Windows.Forms.Label();
		this.label65 = new System.Windows.Forms.Label();
		this.label64 = new System.Windows.Forms.Label();
		this.label63 = new System.Windows.Forms.Label();
		this.label62 = new System.Windows.Forms.Label();
		this.label61 = new System.Windows.Forms.Label();
		this.label60 = new System.Windows.Forms.Label();
		this.label59 = new System.Windows.Forms.Label();
		this.label58 = new System.Windows.Forms.Label();
		this.label57 = new System.Windows.Forms.Label();
		this.label56 = new System.Windows.Forms.Label();
		this.label55 = new System.Windows.Forms.Label();
		this.label54 = new System.Windows.Forms.Label();
		this.label53 = new System.Windows.Forms.Label();
		this.s55 = new System.Windows.Forms.TextBox();
		this.label156 = new System.Windows.Forms.Label();
		this.label52 = new System.Windows.Forms.Label();
		this.label157 = new System.Windows.Forms.Label();
		this.label51 = new System.Windows.Forms.Label();
		this.s54 = new System.Windows.Forms.TextBox();
		this.label158 = new System.Windows.Forms.Label();
		this.label50 = new System.Windows.Forms.Label();
		this.label159 = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.label160 = new System.Windows.Forms.Label();
		this.label47 = new System.Windows.Forms.Label();
		this.label161 = new System.Windows.Forms.Label();
		this.label46 = new System.Windows.Forms.Label();
		this.s52 = new System.Windows.Forms.TextBox();
		this.label162 = new System.Windows.Forms.Label();
		this.label45 = new System.Windows.Forms.Label();
		this.label163 = new System.Windows.Forms.Label();
		this.label44 = new System.Windows.Forms.Label();
		this.s51 = new System.Windows.Forms.TextBox();
		this.label164 = new System.Windows.Forms.Label();
		this.label43 = new System.Windows.Forms.Label();
		this.label165 = new System.Windows.Forms.Label();
		this.label42 = new System.Windows.Forms.Label();
		this.s50 = new System.Windows.Forms.TextBox();
		this.label166 = new System.Windows.Forms.Label();
		this.label41 = new System.Windows.Forms.Label();
		this.label167 = new System.Windows.Forms.Label();
		this.label40 = new System.Windows.Forms.Label();
		this.s49 = new System.Windows.Forms.TextBox();
		this.s48 = new System.Windows.Forms.TextBox();
		this.s47 = new System.Windows.Forms.TextBox();
		this.s46 = new System.Windows.Forms.TextBox();
		this.s45 = new System.Windows.Forms.TextBox();
		this.s44 = new System.Windows.Forms.TextBox();
		this.s43 = new System.Windows.Forms.TextBox();
		this.s42 = new System.Windows.Forms.TextBox();
		this.s41 = new System.Windows.Forms.TextBox();
		this.s40 = new System.Windows.Forms.TextBox();
		this.s39 = new System.Windows.Forms.TextBox();
		this.label168 = new System.Windows.Forms.Label();
		this.label39 = new System.Windows.Forms.Label();
		this.label170 = new System.Windows.Forms.Label();
		this.label169 = new System.Windows.Forms.Label();
		this.label172 = new System.Windows.Forms.Label();
		this.label38 = new System.Windows.Forms.Label();
		this.label174 = new System.Windows.Forms.Label();
		this.label37 = new System.Windows.Forms.Label();
		this.label176 = new System.Windows.Forms.Label();
		this.label171 = new System.Windows.Forms.Label();
		this.label178 = new System.Windows.Forms.Label();
		this.label36 = new System.Windows.Forms.Label();
		this.label180 = new System.Windows.Forms.Label();
		this.label35 = new System.Windows.Forms.Label();
		this.label173 = new System.Windows.Forms.Label();
		this.label184 = new System.Windows.Forms.Label();
		this.label34 = new System.Windows.Forms.Label();
		this.label186 = new System.Windows.Forms.Label();
		this.label33 = new System.Windows.Forms.Label();
		this.label188 = new System.Windows.Forms.Label();
		this.label32 = new System.Windows.Forms.Label();
		this.label31 = new System.Windows.Forms.Label();
		this.label30 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.label28 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.label23 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.s2 = new System.Windows.Forms.TextBox();
		this.s3 = new System.Windows.Forms.TextBox();
		this.s4 = new System.Windows.Forms.TextBox();
		this.s11 = new System.Windows.Forms.TextBox();
		this.s5 = new System.Windows.Forms.TextBox();
		this.s9 = new System.Windows.Forms.TextBox();
		this.s6 = new System.Windows.Forms.TextBox();
		this.s7 = new System.Windows.Forms.TextBox();
		this.s12 = new System.Windows.Forms.TextBox();
		this.s8 = new System.Windows.Forms.TextBox();
		this.s13 = new System.Windows.Forms.TextBox();
		this.s17 = new System.Windows.Forms.TextBox();
		this.s16 = new System.Windows.Forms.TextBox();
		this.s14 = new System.Windows.Forms.TextBox();
		this.s18 = new System.Windows.Forms.TextBox();
		this.button9 = new System.Windows.Forms.Button();
		this.button8 = new System.Windows.Forms.Button();
		this.s19 = new System.Windows.Forms.TextBox();
		this.s20 = new System.Windows.Forms.TextBox();
		this.button7 = new System.Windows.Forms.Button();
		this.s22 = new System.Windows.Forms.TextBox();
		this.s24 = new System.Windows.Forms.TextBox();
		this.s21 = new System.Windows.Forms.TextBox();
		this.s38 = new System.Windows.Forms.TextBox();
		this.s23 = new System.Windows.Forms.TextBox();
		this.s37 = new System.Windows.Forms.TextBox();
		this.s25 = new System.Windows.Forms.TextBox();
		this.s36 = new System.Windows.Forms.TextBox();
		this.s35 = new System.Windows.Forms.TextBox();
		this.s34 = new System.Windows.Forms.TextBox();
		this.s33 = new System.Windows.Forms.TextBox();
		this.s32 = new System.Windows.Forms.TextBox();
		this.s31 = new System.Windows.Forms.TextBox();
		this.s30 = new System.Windows.Forms.TextBox();
		this.s29 = new System.Windows.Forms.TextBox();
		this.s28 = new System.Windows.Forms.TextBox();
		this.s27 = new System.Windows.Forms.TextBox();
		this.s26 = new System.Windows.Forms.TextBox();
		this.s15 = new System.Windows.Forms.TextBox();
		this.s10 = new System.Windows.Forms.TextBox();
		this.s1 = new System.Windows.Forms.TextBox();
		this.button10 = new System.Windows.Forms.Button();
		this.button11 = new System.Windows.Forms.Button();
		this.button12 = new System.Windows.Forms.Button();
		this.label189 = new System.Windows.Forms.Label();
		this.label187 = new System.Windows.Forms.Label();
		this.label185 = new System.Windows.Forms.Label();
		this.label183 = new System.Windows.Forms.Label();
		this.label181 = new System.Windows.Forms.Label();
		this.label179 = new System.Windows.Forms.Label();
		this.label177 = new System.Windows.Forms.Label();
		this.label175 = new System.Windows.Forms.Label();
		this.label182 = new System.Windows.Forms.Label();
		this.label153 = new System.Windows.Forms.Label();
		this.label152 = new System.Windows.Forms.Label();
		this.s56 = new System.Windows.Forms.TextBox();
		this.label151 = new System.Windows.Forms.Label();
		this.label150 = new System.Windows.Forms.Label();
		this.s57 = new System.Windows.Forms.TextBox();
		this.s58 = new System.Windows.Forms.TextBox();
		this.s59 = new System.Windows.Forms.TextBox();
		this.s60 = new System.Windows.Forms.TextBox();
		this.s61 = new System.Windows.Forms.TextBox();
		this.s62 = new System.Windows.Forms.TextBox();
		this.s63 = new System.Windows.Forms.TextBox();
		this.label148 = new System.Windows.Forms.Label();
		this.label146 = new System.Windows.Forms.Label();
		this.label144 = new System.Windows.Forms.Label();
		this.label142 = new System.Windows.Forms.Label();
		this.label140 = new System.Windows.Forms.Label();
		this.label138 = new System.Windows.Forms.Label();
		this.label136 = new System.Windows.Forms.Label();
		this.label134 = new System.Windows.Forms.Label();
		this.label132 = new System.Windows.Forms.Label();
		this.label149 = new System.Windows.Forms.Label();
		this.label147 = new System.Windows.Forms.Label();
		this.label145 = new System.Windows.Forms.Label();
		this.label143 = new System.Windows.Forms.Label();
		this.label141 = new System.Windows.Forms.Label();
		this.label139 = new System.Windows.Forms.Label();
		this.label137 = new System.Windows.Forms.Label();
		this.label135 = new System.Windows.Forms.Label();
		this.label133 = new System.Windows.Forms.Label();
		this.s64 = new System.Windows.Forms.TextBox();
		this.s65 = new System.Windows.Forms.TextBox();
		this.s66 = new System.Windows.Forms.TextBox();
		this.label131 = new System.Windows.Forms.Label();
		this.label129 = new System.Windows.Forms.Label();
		this.label127 = new System.Windows.Forms.Label();
		this.label125 = new System.Windows.Forms.Label();
		this.label123 = new System.Windows.Forms.Label();
		this.label121 = new System.Windows.Forms.Label();
		this.label119 = new System.Windows.Forms.Label();
		this.label117 = new System.Windows.Forms.Label();
		this.label95 = new System.Windows.Forms.Label();
		this.label130 = new System.Windows.Forms.Label();
		this.label128 = new System.Windows.Forms.Label();
		this.label126 = new System.Windows.Forms.Label();
		this.label124 = new System.Windows.Forms.Label();
		this.label122 = new System.Windows.Forms.Label();
		this.label120 = new System.Windows.Forms.Label();
		this.label118 = new System.Windows.Forms.Label();
		this.label116 = new System.Windows.Forms.Label();
		this.label94 = new System.Windows.Forms.Label();
		this.s67 = new System.Windows.Forms.TextBox();
		this.s68 = new System.Windows.Forms.TextBox();
		this.s69 = new System.Windows.Forms.TextBox();
		this.s70 = new System.Windows.Forms.TextBox();
		this.s71 = new System.Windows.Forms.TextBox();
		this.s72 = new System.Windows.Forms.TextBox();
		this.tex86 = new System.Windows.Forms.TextBox();
		this.tex87 = new System.Windows.Forms.TextBox();
		this.tex88 = new System.Windows.Forms.TextBox();
		this.tex89 = new System.Windows.Forms.TextBox();
		this.label154 = new System.Windows.Forms.Label();
		this.label155 = new System.Windows.Forms.Label();
		this.pnl_titil_ca.SuspendLayout();
		this.tableLayoutPanel1.SuspendLayout();
		this.panel1.SuspendLayout();
		this.tableLayoutPanel3.SuspendLayout();
		base.SuspendLayout();
		this.pnl_titil_ca.BackColor = System.Drawing.Color.RoyalBlue;
		this.pnl_titil_ca.Controls.Add(this.lbl_taswit);
		this.pnl_titil_ca.Controls.Add(this.txtwestga);
		this.pnl_titil_ca.Controls.Add(this.tableLayoutPanel1);
		this.pnl_titil_ca.Controls.Add(this.simpleButton1);
		this.pnl_titil_ca.Controls.Add(this.label111);
		this.pnl_titil_ca.Dock = System.Windows.Forms.DockStyle.Top;
		this.pnl_titil_ca.Location = new System.Drawing.Point(0, 0);
		this.pnl_titil_ca.Name = "pnl_titil_ca";
		this.pnl_titil_ca.Size = new System.Drawing.Size(1412, 197);
		this.pnl_titil_ca.TabIndex = 0;
		this.pnl_titil_ca.Paint += new System.Windows.Forms.PaintEventHandler(pnl_titil_ca_Paint);
		this.lbl_taswit.AutoSize = true;
		this.lbl_taswit.ForeColor = System.Drawing.Color.RoyalBlue;
		this.lbl_taswit.Location = new System.Drawing.Point(275, 25);
		this.lbl_taswit.Name = "lbl_taswit";
		this.lbl_taswit.Size = new System.Drawing.Size(42, 17);
		this.lbl_taswit.TabIndex = 5339;
		this.lbl_taswit.Text = "label2";
		this.txtwestga.AutoSize = true;
		this.txtwestga.ForeColor = System.Drawing.Color.RoyalBlue;
		this.txtwestga.Location = new System.Drawing.Point(391, 35);
		this.txtwestga.Name = "txtwestga";
		this.txtwestga.Size = new System.Drawing.Size(42, 17);
		this.txtwestga.TabIndex = 5337;
		this.txtwestga.Text = "label2";
		this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
		this.tableLayoutPanel1.ColumnCount = 7;
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33948f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.87762f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.41576f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22632f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.14082f));
		this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204f));
		this.tableLayoutPanel1.Controls.Add(this.comwestga, 4, 1);
		this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
		this.tableLayoutPanel1.Controls.Add(this.txtcoodtasj, 2, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtbnkacood, 6, 1);
		this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
		this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
		this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
		this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
		this.tableLayoutPanel1.Controls.Add(this.txtnawbnka, 5, 1);
		this.tableLayoutPanel1.Controls.Add(this.txtparezga, 1, 1);
		this.tableLayoutPanel1.Controls.Add(this.label10, 1, 0);
		this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
		this.tableLayoutPanel1.Controls.Add(this.tex_total_s, 0, 1);
		this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
		this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 81);
		this.tableLayoutPanel1.Name = "tableLayoutPanel1";
		this.tableLayoutPanel1.RowCount = 2;
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56f));
		this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.tableLayoutPanel1.Size = new System.Drawing.Size(1406, 113);
		this.tableLayoutPanel1.TabIndex = 5336;
		this.tableLayoutPanel1.Leave += new System.EventHandler(tableLayoutPanel1_Leave);
		this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(tableLayoutPanel1_MouseMove);
		this.comwestga.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
		this.comwestga.BorderColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.comwestga.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.comwestga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comwestga.FocusedColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.comwestga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.comwestga.Font = new System.Drawing.Font("Segoe UI", 13.8f);
		this.comwestga.ForeColor = System.Drawing.Color.Red;
		this.comwestga.ItemHeight = 40;
		this.comwestga.Location = new System.Drawing.Point(847, 60);
		this.comwestga.Name = "comwestga";
		this.comwestga.Size = new System.Drawing.Size(100, 46);
		this.comwestga.TabIndex = 5902;
		this.comwestga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.comwestga.SelectedIndexChanged += new System.EventHandler(comwestga_SelectedIndexChanged);
		this.comwestga.Click += new System.EventHandler(comwestga_Click);
		this.comwestga.MouseMove += new System.Windows.Forms.MouseEventHandler(comwestga_MouseMove);
		this.label1.AutoSize = true;
		this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label1.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(159, 57);
		this.label1.TabIndex = 5337;
		this.label1.Text = "کۆی گشتی";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtcoodtasj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtcoodtasj.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtcoodtasj.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtcoodtasj.Location = new System.Drawing.Point(327, 60);
		this.txtcoodtasj.Multiline = true;
		this.txtcoodtasj.Name = "txtcoodtasj";
		this.txtcoodtasj.ReadOnly = true;
		this.txtcoodtasj.Size = new System.Drawing.Size(220, 50);
		this.txtcoodtasj.TabIndex = 4;
		this.txtcoodtasj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtcoodtasj.MouseMove += new System.Windows.Forms.MouseEventHandler(txtcoodtasj_MouseMove);
		this.txtbnkacood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtbnkacood.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtbnkacood.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtbnkacood.Location = new System.Drawing.Point(1203, 60);
		this.txtbnkacood.Multiline = true;
		this.txtbnkacood.Name = "txtbnkacood";
		this.txtbnkacood.ReadOnly = true;
		this.txtbnkacood.Size = new System.Drawing.Size(200, 50);
		this.txtbnkacood.TabIndex = 0;
		this.txtbnkacood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label9.AutoSize = true;
		this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label9.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.ForeColor = System.Drawing.Color.White;
		this.label9.Location = new System.Drawing.Point(327, 0);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(220, 57);
		this.label9.TabIndex = 12;
		this.label9.Text = "ژ.ناوه\u200cندی تۆماركردن";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.AutoSize = true;
		this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label3.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.White;
		this.label3.Location = new System.Drawing.Point(1203, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(200, 57);
		this.label3.TabIndex = 9;
		this.label3.Text = "ژ.بنكه\u200cی ده\u200cنگدان";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label6.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.label6.Location = new System.Drawing.Point(553, 0);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(288, 57);
		this.label6.TabIndex = 10;
		this.label6.Text = "تۆمارکردن";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(label6_MouseMove);
		this.label8.AutoSize = true;
		this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label8.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = System.Drawing.Color.White;
		this.label8.Location = new System.Drawing.Point(953, 0);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(244, 57);
		this.label8.TabIndex = 11;
		this.label8.Text = "ناوی بنكه\u200cی ده\u200cنگدان";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtnawbnka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtnawbnka.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtnawbnka.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtnawbnka.Location = new System.Drawing.Point(953, 60);
		this.txtnawbnka.Multiline = true;
		this.txtnawbnka.Name = "txtnawbnka";
		this.txtnawbnka.ReadOnly = true;
		this.txtnawbnka.Size = new System.Drawing.Size(244, 50);
		this.txtnawbnka.TabIndex = 6;
		this.txtnawbnka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.txtparezga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtparezga.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtparezga.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtparezga.Location = new System.Drawing.Point(168, 60);
		this.txtparezga.Multiline = true;
		this.txtparezga.Name = "txtparezga";
		this.txtparezga.ReadOnly = true;
		this.txtparezga.Size = new System.Drawing.Size(153, 50);
		this.txtparezga.TabIndex = 3;
		this.txtparezga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.label10.AutoSize = true;
		this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label10.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.ForeColor = System.Drawing.Color.White;
		this.label10.Location = new System.Drawing.Point(168, 0);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(153, 57);
		this.label10.TabIndex = 13;
		this.label10.Text = "پارێزگا";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label11.AutoSize = true;
		this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label11.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label11.ForeColor = System.Drawing.Color.White;
		this.label11.Location = new System.Drawing.Point(847, 0);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(100, 57);
		this.label11.TabIndex = 11;
		this.label11.Text = "ژ.وێستگه\u200c";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.tex_total_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.tex_total_s.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tex_total_s.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tex_total_s.Location = new System.Drawing.Point(3, 60);
		this.tex_total_s.Multiline = true;
		this.tex_total_s.Name = "tex_total_s";
		this.tex_total_s.ReadOnly = true;
		this.tex_total_s.Size = new System.Drawing.Size(159, 50);
		this.tex_total_s.TabIndex = 5336;
		this.tex_total_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.button1.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
		this.button1.Font = new System.Drawing.Font("Unikurd Jino", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new System.Drawing.Point(553, 60);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(288, 50);
		this.button1.TabIndex = 5338;
		this.button1.Text = "تۆمارکردن";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(button1_MouseMove);
		this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
		this.simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
		this.simpleButton1.Location = new System.Drawing.Point(13, 9);
		this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.simpleButton1.Size = new System.Drawing.Size(46, 46);
		this.simpleButton1.TabIndex = 2;
		this.simpleButton1.Text = " ";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click);
		this.label111.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label111.AutoSize = true;
		this.label111.Font = new System.Drawing.Font("Unikurd Nali", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label111.ForeColor = System.Drawing.Color.White;
		this.label111.Location = new System.Drawing.Point(531, 9);
		this.label111.Name = "label111";
		this.label111.Size = new System.Drawing.Size(409, 44);
		this.label111.TabIndex = 0;
		this.label111.Text = "په\u200cڕه\u200cی تۆماری كاندید- پارێزگای هەڵەبجە";
		this.panel1.AutoScroll = true;
		this.panel1.Controls.Add(this.tableLayoutPanel3);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 197);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1412, 603);
		this.panel1.TabIndex = 122;
		this.tableLayoutPanel3.ColumnCount = 7;
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952f));
		this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.90476f));
		this.tableLayoutPanel3.Controls.Add(this.label93, 1, 38);
		this.tableLayoutPanel3.Controls.Add(this.label92, 0, 38);
		this.tableLayoutPanel3.Controls.Add(this.s53, 6, 15);
		this.tableLayoutPanel3.Controls.Add(this.label91, 1, 37);
		this.tableLayoutPanel3.Controls.Add(this.label90, 0, 37);
		this.tableLayoutPanel3.Controls.Add(this.label89, 1, 36);
		this.tableLayoutPanel3.Controls.Add(this.label88, 0, 36);
		this.tableLayoutPanel3.Controls.Add(this.label87, 1, 35);
		this.tableLayoutPanel3.Controls.Add(this.label86, 0, 35);
		this.tableLayoutPanel3.Controls.Add(this.label85, 1, 34);
		this.tableLayoutPanel3.Controls.Add(this.label84, 0, 34);
		this.tableLayoutPanel3.Controls.Add(this.label83, 1, 33);
		this.tableLayoutPanel3.Controls.Add(this.label82, 0, 33);
		this.tableLayoutPanel3.Controls.Add(this.label81, 1, 32);
		this.tableLayoutPanel3.Controls.Add(this.label80, 0, 32);
		this.tableLayoutPanel3.Controls.Add(this.label79, 1, 31);
		this.tableLayoutPanel3.Controls.Add(this.label78, 0, 31);
		this.tableLayoutPanel3.Controls.Add(this.label77, 1, 30);
		this.tableLayoutPanel3.Controls.Add(this.label76, 0, 30);
		this.tableLayoutPanel3.Controls.Add(this.label75, 1, 29);
		this.tableLayoutPanel3.Controls.Add(this.label74, 0, 29);
		this.tableLayoutPanel3.Controls.Add(this.label73, 1, 28);
		this.tableLayoutPanel3.Controls.Add(this.label72, 0, 28);
		this.tableLayoutPanel3.Controls.Add(this.label71, 1, 27);
		this.tableLayoutPanel3.Controls.Add(this.label70, 0, 27);
		this.tableLayoutPanel3.Controls.Add(this.label69, 1, 26);
		this.tableLayoutPanel3.Controls.Add(this.label68, 0, 26);
		this.tableLayoutPanel3.Controls.Add(this.label67, 1, 25);
		this.tableLayoutPanel3.Controls.Add(this.label66, 0, 25);
		this.tableLayoutPanel3.Controls.Add(this.label65, 1, 24);
		this.tableLayoutPanel3.Controls.Add(this.label64, 0, 24);
		this.tableLayoutPanel3.Controls.Add(this.label63, 1, 23);
		this.tableLayoutPanel3.Controls.Add(this.label62, 0, 23);
		this.tableLayoutPanel3.Controls.Add(this.label61, 1, 22);
		this.tableLayoutPanel3.Controls.Add(this.label60, 0, 22);
		this.tableLayoutPanel3.Controls.Add(this.label59, 1, 21);
		this.tableLayoutPanel3.Controls.Add(this.label58, 0, 21);
		this.tableLayoutPanel3.Controls.Add(this.label57, 1, 20);
		this.tableLayoutPanel3.Controls.Add(this.label56, 0, 20);
		this.tableLayoutPanel3.Controls.Add(this.label55, 1, 19);
		this.tableLayoutPanel3.Controls.Add(this.label54, 0, 19);
		this.tableLayoutPanel3.Controls.Add(this.label53, 1, 18);
		this.tableLayoutPanel3.Controls.Add(this.s55, 6, 17);
		this.tableLayoutPanel3.Controls.Add(this.label156, 5, 17);
		this.tableLayoutPanel3.Controls.Add(this.label52, 0, 18);
		this.tableLayoutPanel3.Controls.Add(this.label157, 4, 17);
		this.tableLayoutPanel3.Controls.Add(this.label51, 1, 17);
		this.tableLayoutPanel3.Controls.Add(this.s54, 6, 16);
		this.tableLayoutPanel3.Controls.Add(this.label158, 5, 16);
		this.tableLayoutPanel3.Controls.Add(this.label50, 0, 17);
		this.tableLayoutPanel3.Controls.Add(this.label159, 4, 16);
		this.tableLayoutPanel3.Controls.Add(this.label49, 1, 16);
		this.tableLayoutPanel3.Controls.Add(this.label48, 0, 16);
		this.tableLayoutPanel3.Controls.Add(this.label160, 5, 15);
		this.tableLayoutPanel3.Controls.Add(this.label47, 1, 15);
		this.tableLayoutPanel3.Controls.Add(this.label161, 4, 15);
		this.tableLayoutPanel3.Controls.Add(this.label46, 0, 15);
		this.tableLayoutPanel3.Controls.Add(this.s52, 6, 14);
		this.tableLayoutPanel3.Controls.Add(this.label162, 5, 14);
		this.tableLayoutPanel3.Controls.Add(this.label45, 1, 14);
		this.tableLayoutPanel3.Controls.Add(this.label163, 4, 14);
		this.tableLayoutPanel3.Controls.Add(this.label44, 0, 14);
		this.tableLayoutPanel3.Controls.Add(this.s51, 6, 13);
		this.tableLayoutPanel3.Controls.Add(this.label164, 5, 13);
		this.tableLayoutPanel3.Controls.Add(this.label43, 1, 13);
		this.tableLayoutPanel3.Controls.Add(this.label165, 4, 13);
		this.tableLayoutPanel3.Controls.Add(this.label42, 0, 13);
		this.tableLayoutPanel3.Controls.Add(this.s50, 6, 12);
		this.tableLayoutPanel3.Controls.Add(this.label166, 5, 12);
		this.tableLayoutPanel3.Controls.Add(this.label41, 1, 12);
		this.tableLayoutPanel3.Controls.Add(this.label167, 4, 12);
		this.tableLayoutPanel3.Controls.Add(this.label40, 0, 12);
		this.tableLayoutPanel3.Controls.Add(this.s49, 6, 11);
		this.tableLayoutPanel3.Controls.Add(this.s48, 6, 10);
		this.tableLayoutPanel3.Controls.Add(this.s47, 6, 9);
		this.tableLayoutPanel3.Controls.Add(this.s46, 6, 8);
		this.tableLayoutPanel3.Controls.Add(this.s45, 6, 7);
		this.tableLayoutPanel3.Controls.Add(this.s44, 6, 6);
		this.tableLayoutPanel3.Controls.Add(this.s43, 6, 5);
		this.tableLayoutPanel3.Controls.Add(this.s42, 6, 4);
		this.tableLayoutPanel3.Controls.Add(this.s41, 6, 3);
		this.tableLayoutPanel3.Controls.Add(this.s40, 6, 2);
		this.tableLayoutPanel3.Controls.Add(this.s39, 6, 1);
		this.tableLayoutPanel3.Controls.Add(this.label168, 5, 11);
		this.tableLayoutPanel3.Controls.Add(this.label39, 1, 11);
		this.tableLayoutPanel3.Controls.Add(this.label170, 5, 10);
		this.tableLayoutPanel3.Controls.Add(this.label169, 4, 11);
		this.tableLayoutPanel3.Controls.Add(this.label172, 5, 9);
		this.tableLayoutPanel3.Controls.Add(this.label38, 0, 11);
		this.tableLayoutPanel3.Controls.Add(this.label174, 5, 8);
		this.tableLayoutPanel3.Controls.Add(this.label37, 1, 10);
		this.tableLayoutPanel3.Controls.Add(this.label176, 5, 7);
		this.tableLayoutPanel3.Controls.Add(this.label171, 4, 10);
		this.tableLayoutPanel3.Controls.Add(this.label178, 5, 6);
		this.tableLayoutPanel3.Controls.Add(this.label36, 0, 10);
		this.tableLayoutPanel3.Controls.Add(this.label180, 5, 5);
		this.tableLayoutPanel3.Controls.Add(this.label35, 1, 9);
		this.tableLayoutPanel3.Controls.Add(this.label173, 4, 9);
		this.tableLayoutPanel3.Controls.Add(this.label184, 5, 3);
		this.tableLayoutPanel3.Controls.Add(this.label34, 0, 9);
		this.tableLayoutPanel3.Controls.Add(this.label186, 5, 2);
		this.tableLayoutPanel3.Controls.Add(this.label33, 1, 8);
		this.tableLayoutPanel3.Controls.Add(this.label188, 5, 1);
		this.tableLayoutPanel3.Controls.Add(this.label32, 0, 8);
		this.tableLayoutPanel3.Controls.Add(this.label31, 1, 7);
		this.tableLayoutPanel3.Controls.Add(this.label30, 0, 7);
		this.tableLayoutPanel3.Controls.Add(this.label29, 1, 6);
		this.tableLayoutPanel3.Controls.Add(this.label28, 0, 6);
		this.tableLayoutPanel3.Controls.Add(this.label27, 1, 5);
		this.tableLayoutPanel3.Controls.Add(this.label26, 0, 5);
		this.tableLayoutPanel3.Controls.Add(this.label25, 1, 4);
		this.tableLayoutPanel3.Controls.Add(this.label24, 0, 4);
		this.tableLayoutPanel3.Controls.Add(this.label23, 1, 3);
		this.tableLayoutPanel3.Controls.Add(this.label22, 0, 3);
		this.tableLayoutPanel3.Controls.Add(this.label21, 1, 2);
		this.tableLayoutPanel3.Controls.Add(this.label20, 0, 2);
		this.tableLayoutPanel3.Controls.Add(this.label19, 1, 1);
		this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
		this.tableLayoutPanel3.Controls.Add(this.s2, 2, 2);
		this.tableLayoutPanel3.Controls.Add(this.s3, 2, 3);
		this.tableLayoutPanel3.Controls.Add(this.s4, 2, 4);
		this.tableLayoutPanel3.Controls.Add(this.s11, 2, 11);
		this.tableLayoutPanel3.Controls.Add(this.s5, 2, 5);
		this.tableLayoutPanel3.Controls.Add(this.s9, 2, 9);
		this.tableLayoutPanel3.Controls.Add(this.s6, 2, 6);
		this.tableLayoutPanel3.Controls.Add(this.s7, 2, 7);
		this.tableLayoutPanel3.Controls.Add(this.s12, 2, 12);
		this.tableLayoutPanel3.Controls.Add(this.s8, 2, 8);
		this.tableLayoutPanel3.Controls.Add(this.s13, 2, 13);
		this.tableLayoutPanel3.Controls.Add(this.s17, 2, 17);
		this.tableLayoutPanel3.Controls.Add(this.s16, 2, 16);
		this.tableLayoutPanel3.Controls.Add(this.s14, 2, 14);
		this.tableLayoutPanel3.Controls.Add(this.s18, 2, 18);
		this.tableLayoutPanel3.Controls.Add(this.button9, 2, 0);
		this.tableLayoutPanel3.Controls.Add(this.button8, 1, 0);
		this.tableLayoutPanel3.Controls.Add(this.s19, 2, 19);
		this.tableLayoutPanel3.Controls.Add(this.s20, 2, 20);
		this.tableLayoutPanel3.Controls.Add(this.s22, 2, 22);
		this.tableLayoutPanel3.Controls.Add(this.s24, 2, 24);
		this.tableLayoutPanel3.Controls.Add(this.s21, 2, 21);
		this.tableLayoutPanel3.Controls.Add(this.s38, 2, 38);
		this.tableLayoutPanel3.Controls.Add(this.s23, 2, 23);
		this.tableLayoutPanel3.Controls.Add(this.s37, 2, 37);
		this.tableLayoutPanel3.Controls.Add(this.s25, 2, 25);
		this.tableLayoutPanel3.Controls.Add(this.s36, 2, 36);
		this.tableLayoutPanel3.Controls.Add(this.s35, 2, 35);
		this.tableLayoutPanel3.Controls.Add(this.s34, 2, 34);
		this.tableLayoutPanel3.Controls.Add(this.s33, 2, 33);
		this.tableLayoutPanel3.Controls.Add(this.s32, 2, 32);
		this.tableLayoutPanel3.Controls.Add(this.s31, 2, 31);
		this.tableLayoutPanel3.Controls.Add(this.s30, 2, 30);
		this.tableLayoutPanel3.Controls.Add(this.s29, 2, 29);
		this.tableLayoutPanel3.Controls.Add(this.s28, 2, 28);
		this.tableLayoutPanel3.Controls.Add(this.s27, 2, 27);
		this.tableLayoutPanel3.Controls.Add(this.s26, 2, 26);
		this.tableLayoutPanel3.Controls.Add(this.s15, 2, 15);
		this.tableLayoutPanel3.Controls.Add(this.s10, 2, 10);
		this.tableLayoutPanel3.Controls.Add(this.s1, 2, 1);
		this.tableLayoutPanel3.Controls.Add(this.button10, 6, 0);
		this.tableLayoutPanel3.Controls.Add(this.button11, 5, 0);
		this.tableLayoutPanel3.Controls.Add(this.button12, 4, 0);
		this.tableLayoutPanel3.Controls.Add(this.label189, 4, 1);
		this.tableLayoutPanel3.Controls.Add(this.label187, 4, 2);
		this.tableLayoutPanel3.Controls.Add(this.label185, 4, 3);
		this.tableLayoutPanel3.Controls.Add(this.label183, 4, 4);
		this.tableLayoutPanel3.Controls.Add(this.label181, 4, 5);
		this.tableLayoutPanel3.Controls.Add(this.label179, 4, 6);
		this.tableLayoutPanel3.Controls.Add(this.label177, 4, 7);
		this.tableLayoutPanel3.Controls.Add(this.label175, 4, 8);
		this.tableLayoutPanel3.Controls.Add(this.label182, 5, 4);
		this.tableLayoutPanel3.Controls.Add(this.label153, 4, 18);
		this.tableLayoutPanel3.Controls.Add(this.label152, 5, 18);
		this.tableLayoutPanel3.Controls.Add(this.s56, 6, 18);
		this.tableLayoutPanel3.Controls.Add(this.label151, 4, 19);
		this.tableLayoutPanel3.Controls.Add(this.label150, 5, 19);
		this.tableLayoutPanel3.Controls.Add(this.s57, 6, 19);
		this.tableLayoutPanel3.Controls.Add(this.s58, 6, 20);
		this.tableLayoutPanel3.Controls.Add(this.s59, 6, 21);
		this.tableLayoutPanel3.Controls.Add(this.s60, 6, 22);
		this.tableLayoutPanel3.Controls.Add(this.s61, 6, 23);
		this.tableLayoutPanel3.Controls.Add(this.s62, 6, 24);
		this.tableLayoutPanel3.Controls.Add(this.s63, 6, 25);
		this.tableLayoutPanel3.Controls.Add(this.label148, 5, 20);
		this.tableLayoutPanel3.Controls.Add(this.label146, 5, 21);
		this.tableLayoutPanel3.Controls.Add(this.label144, 5, 22);
		this.tableLayoutPanel3.Controls.Add(this.label142, 5, 23);
		this.tableLayoutPanel3.Controls.Add(this.label140, 5, 24);
		this.tableLayoutPanel3.Controls.Add(this.label138, 5, 25);
		this.tableLayoutPanel3.Controls.Add(this.label136, 5, 26);
		this.tableLayoutPanel3.Controls.Add(this.label134, 5, 27);
		this.tableLayoutPanel3.Controls.Add(this.label132, 5, 28);
		this.tableLayoutPanel3.Controls.Add(this.label149, 4, 20);
		this.tableLayoutPanel3.Controls.Add(this.label147, 4, 21);
		this.tableLayoutPanel3.Controls.Add(this.label145, 4, 22);
		this.tableLayoutPanel3.Controls.Add(this.label143, 4, 23);
		this.tableLayoutPanel3.Controls.Add(this.label141, 4, 24);
		this.tableLayoutPanel3.Controls.Add(this.label139, 4, 25);
		this.tableLayoutPanel3.Controls.Add(this.label137, 4, 26);
		this.tableLayoutPanel3.Controls.Add(this.label135, 4, 27);
		this.tableLayoutPanel3.Controls.Add(this.label133, 4, 28);
		this.tableLayoutPanel3.Controls.Add(this.s64, 6, 26);
		this.tableLayoutPanel3.Controls.Add(this.s65, 6, 27);
		this.tableLayoutPanel3.Controls.Add(this.s66, 6, 28);
		this.tableLayoutPanel3.Controls.Add(this.label131, 4, 29);
		this.tableLayoutPanel3.Controls.Add(this.label129, 4, 30);
		this.tableLayoutPanel3.Controls.Add(this.label127, 4, 31);
		this.tableLayoutPanel3.Controls.Add(this.label125, 4, 32);
		this.tableLayoutPanel3.Controls.Add(this.label123, 4, 33);
		this.tableLayoutPanel3.Controls.Add(this.label121, 4, 34);
		this.tableLayoutPanel3.Controls.Add(this.label119, 4, 35);
		this.tableLayoutPanel3.Controls.Add(this.label117, 4, 36);
		this.tableLayoutPanel3.Controls.Add(this.label95, 4, 37);
		this.tableLayoutPanel3.Controls.Add(this.label130, 5, 29);
		this.tableLayoutPanel3.Controls.Add(this.label128, 5, 30);
		this.tableLayoutPanel3.Controls.Add(this.label126, 5, 31);
		this.tableLayoutPanel3.Controls.Add(this.label124, 5, 32);
		this.tableLayoutPanel3.Controls.Add(this.label122, 5, 33);
		this.tableLayoutPanel3.Controls.Add(this.label120, 5, 34);
		this.tableLayoutPanel3.Controls.Add(this.label118, 5, 35);
		this.tableLayoutPanel3.Controls.Add(this.label116, 5, 36);
		this.tableLayoutPanel3.Controls.Add(this.label94, 5, 37);
		this.tableLayoutPanel3.Controls.Add(this.s67, 6, 29);
		this.tableLayoutPanel3.Controls.Add(this.s68, 6, 30);
		this.tableLayoutPanel3.Controls.Add(this.s69, 6, 31);
		this.tableLayoutPanel3.Controls.Add(this.s70, 6, 32);
		this.tableLayoutPanel3.Controls.Add(this.s71, 6, 33);
		this.tableLayoutPanel3.Controls.Add(this.s72, 6, 34);
		this.tableLayoutPanel3.Controls.Add(this.tex86, 6, 35);
		this.tableLayoutPanel3.Controls.Add(this.tex87, 6, 36);
		this.tableLayoutPanel3.Controls.Add(this.tex88, 6, 37);
		this.tableLayoutPanel3.Controls.Add(this.tex89, 6, 38);
		this.tableLayoutPanel3.Controls.Add(this.label154, 5, 38);
		this.tableLayoutPanel3.Controls.Add(this.label155, 4, 38);
		this.tableLayoutPanel3.Controls.Add(this.button7, 0, 0);
		this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 6);
		this.tableLayoutPanel3.Name = "tableLayoutPanel3";
		this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.tableLayoutPanel3.RowCount = 39;
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.034619f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.537141f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.552115f));
		this.tableLayoutPanel3.Size = new System.Drawing.Size(1376, 2005);
		this.tableLayoutPanel3.TabIndex = 0;
		this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(tableLayoutPanel3_MouseMove);
		this.label93.AutoSize = true;
		this.label93.BackColor = System.Drawing.Color.Lavender;
		this.label93.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label93.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label93.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label93.ForeColor = System.Drawing.Color.Black;
		this.label93.Location = new System.Drawing.Point(889, 1946);
		this.label93.Name = "label93";
		this.label93.Size = new System.Drawing.Size(321, 59);
		this.label93.TabIndex = 6005;
		this.label93.Text = "كاندید 38";
		this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label92.AutoSize = true;
		this.label92.BackColor = System.Drawing.Color.Lavender;
		this.label92.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label92.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label92.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label92.ForeColor = System.Drawing.Color.Black;
		this.label92.Location = new System.Drawing.Point(1216, 1946);
		this.label92.Name = "label92";
		this.label92.Size = new System.Drawing.Size(157, 59);
		this.label92.TabIndex = 6004;
		this.label92.Text = "38";
		this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s53.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s53.Enabled = false;
		this.s53.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s53.Location = new System.Drawing.Point(3, 776);
		this.s53.Multiline = true;
		this.s53.Name = "s53";
		this.s53.Size = new System.Drawing.Size(162, 45);
		this.s53.TabIndex = 65;
		this.s53.Text = "0";
		this.s53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s53.Click += new System.EventHandler(tex65_Click);
		this.s53.TextChanged += new System.EventHandler(tex65_TextChanged);
		this.s53.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex65_KeyPress);
		this.s53.Leave += new System.EventHandler(tex65_Leave);
		this.label91.AutoSize = true;
		this.label91.BackColor = System.Drawing.Color.Lavender;
		this.label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label91.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label91.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label91.ForeColor = System.Drawing.Color.Black;
		this.label91.Location = new System.Drawing.Point(889, 1895);
		this.label91.Name = "label91";
		this.label91.Size = new System.Drawing.Size(321, 51);
		this.label91.TabIndex = 6003;
		this.label91.Text = "كاندید 37";
		this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label90.AutoSize = true;
		this.label90.BackColor = System.Drawing.Color.Lavender;
		this.label90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label90.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label90.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label90.ForeColor = System.Drawing.Color.Black;
		this.label90.Location = new System.Drawing.Point(1216, 1895);
		this.label90.Name = "label90";
		this.label90.Size = new System.Drawing.Size(157, 51);
		this.label90.TabIndex = 6002;
		this.label90.Text = "37";
		this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label89.AutoSize = true;
		this.label89.BackColor = System.Drawing.Color.Lavender;
		this.label89.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label89.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label89.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label89.ForeColor = System.Drawing.Color.Black;
		this.label89.Location = new System.Drawing.Point(889, 1844);
		this.label89.Name = "label89";
		this.label89.Size = new System.Drawing.Size(321, 51);
		this.label89.TabIndex = 6001;
		this.label89.Text = "كاندید 36";
		this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label88.AutoSize = true;
		this.label88.BackColor = System.Drawing.Color.Lavender;
		this.label88.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label88.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label88.ForeColor = System.Drawing.Color.Black;
		this.label88.Location = new System.Drawing.Point(1216, 1844);
		this.label88.Name = "label88";
		this.label88.Size = new System.Drawing.Size(157, 51);
		this.label88.TabIndex = 6000;
		this.label88.Text = "36";
		this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label87.AutoSize = true;
		this.label87.BackColor = System.Drawing.Color.Lavender;
		this.label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label87.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label87.ForeColor = System.Drawing.Color.Black;
		this.label87.Location = new System.Drawing.Point(889, 1793);
		this.label87.Name = "label87";
		this.label87.Size = new System.Drawing.Size(321, 51);
		this.label87.TabIndex = 5999;
		this.label87.Text = "كاندید 35";
		this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label86.AutoSize = true;
		this.label86.BackColor = System.Drawing.Color.Lavender;
		this.label86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label86.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label86.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label86.ForeColor = System.Drawing.Color.Black;
		this.label86.Location = new System.Drawing.Point(1216, 1793);
		this.label86.Name = "label86";
		this.label86.Size = new System.Drawing.Size(157, 51);
		this.label86.TabIndex = 5998;
		this.label86.Text = "35";
		this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label85.AutoSize = true;
		this.label85.BackColor = System.Drawing.Color.Lavender;
		this.label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label85.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label85.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label85.ForeColor = System.Drawing.Color.Black;
		this.label85.Location = new System.Drawing.Point(889, 1742);
		this.label85.Name = "label85";
		this.label85.Size = new System.Drawing.Size(321, 51);
		this.label85.TabIndex = 5997;
		this.label85.Text = "كاندید 76";
		this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label84.AutoSize = true;
		this.label84.BackColor = System.Drawing.Color.Lavender;
		this.label84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label84.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label84.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label84.ForeColor = System.Drawing.Color.Black;
		this.label84.Location = new System.Drawing.Point(1216, 1742);
		this.label84.Name = "label84";
		this.label84.Size = new System.Drawing.Size(157, 51);
		this.label84.TabIndex = 5996;
		this.label84.Text = "34";
		this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label83.AutoSize = true;
		this.label83.BackColor = System.Drawing.Color.Lavender;
		this.label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label83.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label83.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label83.ForeColor = System.Drawing.Color.Black;
		this.label83.Location = new System.Drawing.Point(889, 1691);
		this.label83.Name = "label83";
		this.label83.Size = new System.Drawing.Size(321, 51);
		this.label83.TabIndex = 5995;
		this.label83.Text = "كاندید 33";
		this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label82.AutoSize = true;
		this.label82.BackColor = System.Drawing.Color.Lavender;
		this.label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label82.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label82.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label82.ForeColor = System.Drawing.Color.Black;
		this.label82.Location = new System.Drawing.Point(1216, 1691);
		this.label82.Name = "label82";
		this.label82.Size = new System.Drawing.Size(157, 51);
		this.label82.TabIndex = 5994;
		this.label82.Text = "33";
		this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label81.AutoSize = true;
		this.label81.BackColor = System.Drawing.Color.Lavender;
		this.label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label81.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label81.ForeColor = System.Drawing.Color.Black;
		this.label81.Location = new System.Drawing.Point(889, 1640);
		this.label81.Name = "label81";
		this.label81.Size = new System.Drawing.Size(321, 51);
		this.label81.TabIndex = 5993;
		this.label81.Text = "كاندید 32";
		this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label80.AutoSize = true;
		this.label80.BackColor = System.Drawing.Color.Lavender;
		this.label80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label80.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label80.ForeColor = System.Drawing.Color.Black;
		this.label80.Location = new System.Drawing.Point(1216, 1640);
		this.label80.Name = "label80";
		this.label80.Size = new System.Drawing.Size(157, 51);
		this.label80.TabIndex = 5992;
		this.label80.Text = "32";
		this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label79.AutoSize = true;
		this.label79.BackColor = System.Drawing.Color.Lavender;
		this.label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label79.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label79.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label79.ForeColor = System.Drawing.Color.Black;
		this.label79.Location = new System.Drawing.Point(889, 1589);
		this.label79.Name = "label79";
		this.label79.Size = new System.Drawing.Size(321, 51);
		this.label79.TabIndex = 5991;
		this.label79.Text = "كاندید 31";
		this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label78.AutoSize = true;
		this.label78.BackColor = System.Drawing.Color.Lavender;
		this.label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label78.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label78.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label78.ForeColor = System.Drawing.Color.Black;
		this.label78.Location = new System.Drawing.Point(1216, 1589);
		this.label78.Name = "label78";
		this.label78.Size = new System.Drawing.Size(157, 51);
		this.label78.TabIndex = 5990;
		this.label78.Text = "31";
		this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label77.AutoSize = true;
		this.label77.BackColor = System.Drawing.Color.Lavender;
		this.label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label77.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label77.ForeColor = System.Drawing.Color.Black;
		this.label77.Location = new System.Drawing.Point(889, 1538);
		this.label77.Name = "label77";
		this.label77.Size = new System.Drawing.Size(321, 51);
		this.label77.TabIndex = 5989;
		this.label77.Text = "كاندید 30";
		this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label76.AutoSize = true;
		this.label76.BackColor = System.Drawing.Color.Lavender;
		this.label76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label76.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label76.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label76.ForeColor = System.Drawing.Color.Black;
		this.label76.Location = new System.Drawing.Point(1216, 1538);
		this.label76.Name = "label76";
		this.label76.Size = new System.Drawing.Size(157, 51);
		this.label76.TabIndex = 5988;
		this.label76.Text = "30";
		this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label75.AutoSize = true;
		this.label75.BackColor = System.Drawing.Color.Lavender;
		this.label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label75.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label75.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label75.ForeColor = System.Drawing.Color.Black;
		this.label75.Location = new System.Drawing.Point(889, 1487);
		this.label75.Name = "label75";
		this.label75.Size = new System.Drawing.Size(321, 51);
		this.label75.TabIndex = 5987;
		this.label75.Text = "كاندید 29";
		this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label74.AutoSize = true;
		this.label74.BackColor = System.Drawing.Color.Lavender;
		this.label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label74.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label74.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label74.ForeColor = System.Drawing.Color.Black;
		this.label74.Location = new System.Drawing.Point(1216, 1487);
		this.label74.Name = "label74";
		this.label74.Size = new System.Drawing.Size(157, 51);
		this.label74.TabIndex = 5986;
		this.label74.Text = "29";
		this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label73.AutoSize = true;
		this.label73.BackColor = System.Drawing.Color.Lavender;
		this.label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label73.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label73.ForeColor = System.Drawing.Color.Black;
		this.label73.Location = new System.Drawing.Point(889, 1436);
		this.label73.Name = "label73";
		this.label73.Size = new System.Drawing.Size(321, 51);
		this.label73.TabIndex = 5985;
		this.label73.Text = "كاندید 28";
		this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label72.AutoSize = true;
		this.label72.BackColor = System.Drawing.Color.Lavender;
		this.label72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label72.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label72.ForeColor = System.Drawing.Color.Black;
		this.label72.Location = new System.Drawing.Point(1216, 1436);
		this.label72.Name = "label72";
		this.label72.Size = new System.Drawing.Size(157, 51);
		this.label72.TabIndex = 5984;
		this.label72.Text = "28";
		this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label71.AutoSize = true;
		this.label71.BackColor = System.Drawing.Color.Lavender;
		this.label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label71.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label71.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label71.ForeColor = System.Drawing.Color.Black;
		this.label71.Location = new System.Drawing.Point(889, 1385);
		this.label71.Name = "label71";
		this.label71.Size = new System.Drawing.Size(321, 51);
		this.label71.TabIndex = 5983;
		this.label71.Text = "كاندید 27";
		this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label70.AutoSize = true;
		this.label70.BackColor = System.Drawing.Color.Lavender;
		this.label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label70.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label70.ForeColor = System.Drawing.Color.Black;
		this.label70.Location = new System.Drawing.Point(1216, 1385);
		this.label70.Name = "label70";
		this.label70.Size = new System.Drawing.Size(157, 51);
		this.label70.TabIndex = 5982;
		this.label70.Text = "27";
		this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label69.AutoSize = true;
		this.label69.BackColor = System.Drawing.Color.Lavender;
		this.label69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label69.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label69.ForeColor = System.Drawing.Color.Black;
		this.label69.Location = new System.Drawing.Point(889, 1334);
		this.label69.Name = "label69";
		this.label69.Size = new System.Drawing.Size(321, 51);
		this.label69.TabIndex = 5981;
		this.label69.Text = "كاندید 26";
		this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label68.AutoSize = true;
		this.label68.BackColor = System.Drawing.Color.Lavender;
		this.label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label68.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label68.ForeColor = System.Drawing.Color.Black;
		this.label68.Location = new System.Drawing.Point(1216, 1334);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(157, 51);
		this.label68.TabIndex = 5980;
		this.label68.Text = "26";
		this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label67.AutoSize = true;
		this.label67.BackColor = System.Drawing.Color.Lavender;
		this.label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label67.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label67.ForeColor = System.Drawing.Color.Black;
		this.label67.Location = new System.Drawing.Point(889, 1283);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(321, 51);
		this.label67.TabIndex = 5979;
		this.label67.Text = "كاندید 25";
		this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label66.AutoSize = true;
		this.label66.BackColor = System.Drawing.Color.Lavender;
		this.label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label66.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label66.ForeColor = System.Drawing.Color.Black;
		this.label66.Location = new System.Drawing.Point(1216, 1283);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(157, 51);
		this.label66.TabIndex = 5978;
		this.label66.Text = "25";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label65.AutoSize = true;
		this.label65.BackColor = System.Drawing.Color.Lavender;
		this.label65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label65.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label65.ForeColor = System.Drawing.Color.Black;
		this.label65.Location = new System.Drawing.Point(889, 1232);
		this.label65.Name = "label65";
		this.label65.Size = new System.Drawing.Size(321, 51);
		this.label65.TabIndex = 5977;
		this.label65.Text = "كاندید 24";
		this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label64.AutoSize = true;
		this.label64.BackColor = System.Drawing.Color.Lavender;
		this.label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label64.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label64.ForeColor = System.Drawing.Color.Black;
		this.label64.Location = new System.Drawing.Point(1216, 1232);
		this.label64.Name = "label64";
		this.label64.Size = new System.Drawing.Size(157, 51);
		this.label64.TabIndex = 5976;
		this.label64.Text = "24";
		this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label63.AutoSize = true;
		this.label63.BackColor = System.Drawing.Color.Lavender;
		this.label63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label63.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label63.ForeColor = System.Drawing.Color.Black;
		this.label63.Location = new System.Drawing.Point(889, 1181);
		this.label63.Name = "label63";
		this.label63.Size = new System.Drawing.Size(321, 51);
		this.label63.TabIndex = 5975;
		this.label63.Text = "كاندید 23";
		this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label62.AutoSize = true;
		this.label62.BackColor = System.Drawing.Color.Lavender;
		this.label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label62.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label62.ForeColor = System.Drawing.Color.Black;
		this.label62.Location = new System.Drawing.Point(1216, 1181);
		this.label62.Name = "label62";
		this.label62.Size = new System.Drawing.Size(157, 51);
		this.label62.TabIndex = 5974;
		this.label62.Text = "23";
		this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label61.AutoSize = true;
		this.label61.BackColor = System.Drawing.Color.Lavender;
		this.label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label61.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label61.ForeColor = System.Drawing.Color.Black;
		this.label61.Location = new System.Drawing.Point(889, 1130);
		this.label61.Name = "label61";
		this.label61.Size = new System.Drawing.Size(321, 51);
		this.label61.TabIndex = 5973;
		this.label61.Text = "كاندید 22";
		this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label60.AutoSize = true;
		this.label60.BackColor = System.Drawing.Color.Lavender;
		this.label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label60.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label60.ForeColor = System.Drawing.Color.Black;
		this.label60.Location = new System.Drawing.Point(1216, 1130);
		this.label60.Name = "label60";
		this.label60.Size = new System.Drawing.Size(157, 51);
		this.label60.TabIndex = 5972;
		this.label60.Text = "22";
		this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label59.AutoSize = true;
		this.label59.BackColor = System.Drawing.Color.Lavender;
		this.label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label59.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label59.ForeColor = System.Drawing.Color.Black;
		this.label59.Location = new System.Drawing.Point(889, 1079);
		this.label59.Name = "label59";
		this.label59.Size = new System.Drawing.Size(321, 51);
		this.label59.TabIndex = 5971;
		this.label59.Text = "كاندید 21";
		this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label58.AutoSize = true;
		this.label58.BackColor = System.Drawing.Color.Lavender;
		this.label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label58.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label58.ForeColor = System.Drawing.Color.Black;
		this.label58.Location = new System.Drawing.Point(1216, 1079);
		this.label58.Name = "label58";
		this.label58.Size = new System.Drawing.Size(157, 51);
		this.label58.TabIndex = 5970;
		this.label58.Text = "21";
		this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label57.AutoSize = true;
		this.label57.BackColor = System.Drawing.Color.Lavender;
		this.label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label57.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label57.ForeColor = System.Drawing.Color.Black;
		this.label57.Location = new System.Drawing.Point(889, 1028);
		this.label57.Name = "label57";
		this.label57.Size = new System.Drawing.Size(321, 51);
		this.label57.TabIndex = 5969;
		this.label57.Text = "كاندید 20";
		this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label56.AutoSize = true;
		this.label56.BackColor = System.Drawing.Color.Lavender;
		this.label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label56.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label56.ForeColor = System.Drawing.Color.Black;
		this.label56.Location = new System.Drawing.Point(1216, 1028);
		this.label56.Name = "label56";
		this.label56.Size = new System.Drawing.Size(157, 51);
		this.label56.TabIndex = 5968;
		this.label56.Text = "20";
		this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label55.AutoSize = true;
		this.label55.BackColor = System.Drawing.Color.Lavender;
		this.label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label55.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label55.ForeColor = System.Drawing.Color.Black;
		this.label55.Location = new System.Drawing.Point(889, 977);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(321, 51);
		this.label55.TabIndex = 5967;
		this.label55.Text = "كاندید 19";
		this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label54.AutoSize = true;
		this.label54.BackColor = System.Drawing.Color.Lavender;
		this.label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label54.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label54.ForeColor = System.Drawing.Color.Black;
		this.label54.Location = new System.Drawing.Point(1216, 977);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(157, 51);
		this.label54.TabIndex = 5966;
		this.label54.Text = "19";
		this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label53.AutoSize = true;
		this.label53.BackColor = System.Drawing.Color.Lavender;
		this.label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label53.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label53.ForeColor = System.Drawing.Color.Black;
		this.label53.Location = new System.Drawing.Point(889, 926);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(321, 51);
		this.label53.TabIndex = 5965;
		this.label53.Text = "كاندید 18";
		this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s55.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s55.Enabled = false;
		this.s55.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s55.Location = new System.Drawing.Point(3, 878);
		this.s55.Multiline = true;
		this.s55.Name = "s55";
		this.s55.Size = new System.Drawing.Size(162, 45);
		this.s55.TabIndex = 67;
		this.s55.Text = "0";
		this.s55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s55.Click += new System.EventHandler(tex67_Click);
		this.s55.TextChanged += new System.EventHandler(tex67_TextChanged);
		this.s55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex67_KeyPress);
		this.s55.Leave += new System.EventHandler(tex67_Leave);
		this.label156.AutoSize = true;
		this.label156.BackColor = System.Drawing.Color.Lavender;
		this.label156.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label156.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label156.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label156.ForeColor = System.Drawing.Color.Black;
		this.label156.Location = new System.Drawing.Point(171, 875);
		this.label156.Name = "label156";
		this.label156.Size = new System.Drawing.Size(321, 51);
		this.label156.TabIndex = 5963;
		this.label156.Text = "كاندید 55";
		this.label156.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label52.AutoSize = true;
		this.label52.BackColor = System.Drawing.Color.Lavender;
		this.label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label52.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label52.ForeColor = System.Drawing.Color.Black;
		this.label52.Location = new System.Drawing.Point(1216, 926);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(157, 51);
		this.label52.TabIndex = 5964;
		this.label52.Text = "18";
		this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label157.AutoSize = true;
		this.label157.BackColor = System.Drawing.Color.Lavender;
		this.label157.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label157.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label157.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label157.ForeColor = System.Drawing.Color.Black;
		this.label157.Location = new System.Drawing.Point(498, 875);
		this.label157.Name = "label157";
		this.label157.Size = new System.Drawing.Size(157, 51);
		this.label157.TabIndex = 5962;
		this.label157.Text = "55";
		this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label51.AutoSize = true;
		this.label51.BackColor = System.Drawing.Color.Lavender;
		this.label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label51.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label51.ForeColor = System.Drawing.Color.Black;
		this.label51.Location = new System.Drawing.Point(889, 875);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(321, 51);
		this.label51.TabIndex = 5963;
		this.label51.Text = "كاندید 17";
		this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s54.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s54.Enabled = false;
		this.s54.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s54.Location = new System.Drawing.Point(3, 827);
		this.s54.Multiline = true;
		this.s54.Name = "s54";
		this.s54.Size = new System.Drawing.Size(162, 45);
		this.s54.TabIndex = 66;
		this.s54.Text = "0";
		this.s54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s54.Click += new System.EventHandler(tex66_Click);
		this.s54.TextChanged += new System.EventHandler(tex66_TextChanged);
		this.s54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex66_KeyPress);
		this.s54.Leave += new System.EventHandler(tex66_Leave);
		this.label158.AutoSize = true;
		this.label158.BackColor = System.Drawing.Color.Lavender;
		this.label158.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label158.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label158.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label158.ForeColor = System.Drawing.Color.Black;
		this.label158.Location = new System.Drawing.Point(171, 824);
		this.label158.Name = "label158";
		this.label158.Size = new System.Drawing.Size(321, 51);
		this.label158.TabIndex = 5961;
		this.label158.Text = "كاندید 45";
		this.label158.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label50.AutoSize = true;
		this.label50.BackColor = System.Drawing.Color.Lavender;
		this.label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label50.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label50.ForeColor = System.Drawing.Color.Black;
		this.label50.Location = new System.Drawing.Point(1216, 875);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(157, 51);
		this.label50.TabIndex = 5962;
		this.label50.Text = "17";
		this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label159.AutoSize = true;
		this.label159.BackColor = System.Drawing.Color.Lavender;
		this.label159.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label159.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label159.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label159.ForeColor = System.Drawing.Color.Black;
		this.label159.Location = new System.Drawing.Point(498, 824);
		this.label159.Name = "label159";
		this.label159.Size = new System.Drawing.Size(157, 51);
		this.label159.TabIndex = 5960;
		this.label159.Text = "54";
		this.label159.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label49.AutoSize = true;
		this.label49.BackColor = System.Drawing.Color.Lavender;
		this.label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label49.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label49.ForeColor = System.Drawing.Color.Black;
		this.label49.Location = new System.Drawing.Point(889, 824);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(321, 51);
		this.label49.TabIndex = 5961;
		this.label49.Text = "كاندید 16";
		this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label48.AutoSize = true;
		this.label48.BackColor = System.Drawing.Color.Lavender;
		this.label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label48.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label48.ForeColor = System.Drawing.Color.Black;
		this.label48.Location = new System.Drawing.Point(1216, 824);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(157, 51);
		this.label48.TabIndex = 5960;
		this.label48.Text = "16";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label160.AutoSize = true;
		this.label160.BackColor = System.Drawing.Color.Lavender;
		this.label160.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label160.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label160.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label160.ForeColor = System.Drawing.Color.Black;
		this.label160.Location = new System.Drawing.Point(171, 773);
		this.label160.Name = "label160";
		this.label160.Size = new System.Drawing.Size(321, 51);
		this.label160.TabIndex = 5959;
		this.label160.Text = "كاندید 53";
		this.label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label47.AutoSize = true;
		this.label47.BackColor = System.Drawing.Color.Lavender;
		this.label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label47.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label47.ForeColor = System.Drawing.Color.Black;
		this.label47.Location = new System.Drawing.Point(889, 773);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(321, 51);
		this.label47.TabIndex = 5959;
		this.label47.Text = "كاندید 15";
		this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label161.AutoSize = true;
		this.label161.BackColor = System.Drawing.Color.Lavender;
		this.label161.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label161.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label161.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label161.ForeColor = System.Drawing.Color.Black;
		this.label161.Location = new System.Drawing.Point(498, 773);
		this.label161.Name = "label161";
		this.label161.Size = new System.Drawing.Size(157, 51);
		this.label161.TabIndex = 5958;
		this.label161.Text = "53";
		this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label46.AutoSize = true;
		this.label46.BackColor = System.Drawing.Color.Lavender;
		this.label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label46.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label46.ForeColor = System.Drawing.Color.Black;
		this.label46.Location = new System.Drawing.Point(1216, 773);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(157, 51);
		this.label46.TabIndex = 5958;
		this.label46.Text = "15";
		this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s52.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s52.Enabled = false;
		this.s52.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s52.Location = new System.Drawing.Point(3, 725);
		this.s52.Multiline = true;
		this.s52.Name = "s52";
		this.s52.Size = new System.Drawing.Size(162, 45);
		this.s52.TabIndex = 64;
		this.s52.Text = "0";
		this.s52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s52.Click += new System.EventHandler(tex64_Click);
		this.s52.TextChanged += new System.EventHandler(tex64_TextChanged);
		this.s52.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex64_KeyPress);
		this.s52.Leave += new System.EventHandler(tex64_Leave);
		this.label162.AutoSize = true;
		this.label162.BackColor = System.Drawing.Color.Lavender;
		this.label162.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label162.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label162.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label162.ForeColor = System.Drawing.Color.Black;
		this.label162.Location = new System.Drawing.Point(171, 722);
		this.label162.Name = "label162";
		this.label162.Size = new System.Drawing.Size(321, 51);
		this.label162.TabIndex = 5957;
		this.label162.Text = "كاندید 52";
		this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label45.AutoSize = true;
		this.label45.BackColor = System.Drawing.Color.Lavender;
		this.label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label45.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label45.ForeColor = System.Drawing.Color.Black;
		this.label45.Location = new System.Drawing.Point(889, 722);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(321, 51);
		this.label45.TabIndex = 5957;
		this.label45.Text = "كاندید 14";
		this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label163.AutoSize = true;
		this.label163.BackColor = System.Drawing.Color.Lavender;
		this.label163.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label163.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label163.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label163.ForeColor = System.Drawing.Color.Black;
		this.label163.Location = new System.Drawing.Point(498, 722);
		this.label163.Name = "label163";
		this.label163.Size = new System.Drawing.Size(157, 51);
		this.label163.TabIndex = 5956;
		this.label163.Text = "52";
		this.label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label44.AutoSize = true;
		this.label44.BackColor = System.Drawing.Color.Lavender;
		this.label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label44.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label44.ForeColor = System.Drawing.Color.Black;
		this.label44.Location = new System.Drawing.Point(1216, 722);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(157, 51);
		this.label44.TabIndex = 5956;
		this.label44.Text = "14";
		this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s51.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s51.Enabled = false;
		this.s51.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s51.Location = new System.Drawing.Point(3, 674);
		this.s51.Multiline = true;
		this.s51.Name = "s51";
		this.s51.Size = new System.Drawing.Size(162, 45);
		this.s51.TabIndex = 63;
		this.s51.Text = "0";
		this.s51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s51.Click += new System.EventHandler(tex63_Click);
		this.s51.TextChanged += new System.EventHandler(tex63_TextChanged);
		this.s51.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex63_KeyPress);
		this.s51.Leave += new System.EventHandler(tex63_Leave);
		this.label164.AutoSize = true;
		this.label164.BackColor = System.Drawing.Color.Lavender;
		this.label164.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label164.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label164.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label164.ForeColor = System.Drawing.Color.Black;
		this.label164.Location = new System.Drawing.Point(171, 671);
		this.label164.Name = "label164";
		this.label164.Size = new System.Drawing.Size(321, 51);
		this.label164.TabIndex = 5955;
		this.label164.Text = "كاندید 51";
		this.label164.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label43.AutoSize = true;
		this.label43.BackColor = System.Drawing.Color.Lavender;
		this.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label43.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label43.ForeColor = System.Drawing.Color.Black;
		this.label43.Location = new System.Drawing.Point(889, 671);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(321, 51);
		this.label43.TabIndex = 5955;
		this.label43.Text = "كاندید 13";
		this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label165.AutoSize = true;
		this.label165.BackColor = System.Drawing.Color.Lavender;
		this.label165.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label165.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label165.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label165.ForeColor = System.Drawing.Color.Black;
		this.label165.Location = new System.Drawing.Point(498, 671);
		this.label165.Name = "label165";
		this.label165.Size = new System.Drawing.Size(157, 51);
		this.label165.TabIndex = 5954;
		this.label165.Text = "51";
		this.label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label42.AutoSize = true;
		this.label42.BackColor = System.Drawing.Color.Lavender;
		this.label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label42.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label42.ForeColor = System.Drawing.Color.Black;
		this.label42.Location = new System.Drawing.Point(1216, 671);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(157, 51);
		this.label42.TabIndex = 5954;
		this.label42.Text = "13";
		this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s50.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s50.Enabled = false;
		this.s50.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s50.Location = new System.Drawing.Point(3, 623);
		this.s50.Multiline = true;
		this.s50.Name = "s50";
		this.s50.Size = new System.Drawing.Size(162, 45);
		this.s50.TabIndex = 62;
		this.s50.Text = "0";
		this.s50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s50.Click += new System.EventHandler(tex62_Click);
		this.s50.TextChanged += new System.EventHandler(tex62_TextChanged);
		this.s50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex62_KeyPress);
		this.s50.Leave += new System.EventHandler(tex62_Leave);
		this.label166.AutoSize = true;
		this.label166.BackColor = System.Drawing.Color.Lavender;
		this.label166.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label166.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label166.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label166.ForeColor = System.Drawing.Color.Black;
		this.label166.Location = new System.Drawing.Point(171, 620);
		this.label166.Name = "label166";
		this.label166.Size = new System.Drawing.Size(321, 51);
		this.label166.TabIndex = 5953;
		this.label166.Text = "كاندید 50";
		this.label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label41.AutoSize = true;
		this.label41.BackColor = System.Drawing.Color.Lavender;
		this.label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label41.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label41.ForeColor = System.Drawing.Color.Black;
		this.label41.Location = new System.Drawing.Point(889, 620);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(321, 51);
		this.label41.TabIndex = 5953;
		this.label41.Text = "كاندید 12";
		this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label167.AutoSize = true;
		this.label167.BackColor = System.Drawing.Color.Lavender;
		this.label167.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label167.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label167.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label167.ForeColor = System.Drawing.Color.Black;
		this.label167.Location = new System.Drawing.Point(498, 620);
		this.label167.Name = "label167";
		this.label167.Size = new System.Drawing.Size(157, 51);
		this.label167.TabIndex = 5952;
		this.label167.Text = "50";
		this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label40.AutoSize = true;
		this.label40.BackColor = System.Drawing.Color.Lavender;
		this.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label40.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label40.ForeColor = System.Drawing.Color.Black;
		this.label40.Location = new System.Drawing.Point(1216, 620);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(157, 51);
		this.label40.TabIndex = 5952;
		this.label40.Text = "12";
		this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s49.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s49.Enabled = false;
		this.s49.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s49.Location = new System.Drawing.Point(3, 572);
		this.s49.Multiline = true;
		this.s49.Name = "s49";
		this.s49.Size = new System.Drawing.Size(162, 45);
		this.s49.TabIndex = 61;
		this.s49.Text = "0";
		this.s49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s49.Click += new System.EventHandler(tex61_Click);
		this.s49.TextChanged += new System.EventHandler(tex61_TextChanged);
		this.s49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex61_KeyPress);
		this.s49.Leave += new System.EventHandler(tex61_Leave);
		this.s48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s48.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s48.Enabled = false;
		this.s48.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s48.Location = new System.Drawing.Point(3, 521);
		this.s48.Multiline = true;
		this.s48.Name = "s48";
		this.s48.Size = new System.Drawing.Size(162, 45);
		this.s48.TabIndex = 60;
		this.s48.Text = "0";
		this.s48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s48.Click += new System.EventHandler(tex60_Click);
		this.s48.TextChanged += new System.EventHandler(tex60_TextChanged);
		this.s48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex60_KeyPress);
		this.s48.Leave += new System.EventHandler(tex60_Leave);
		this.s47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s47.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s47.Enabled = false;
		this.s47.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s47.Location = new System.Drawing.Point(3, 470);
		this.s47.Multiline = true;
		this.s47.Name = "s47";
		this.s47.Size = new System.Drawing.Size(162, 45);
		this.s47.TabIndex = 59;
		this.s47.Text = "0";
		this.s47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s47.Click += new System.EventHandler(tex59_Click);
		this.s47.TextChanged += new System.EventHandler(tex59_TextChanged);
		this.s47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex59_KeyPress);
		this.s47.Leave += new System.EventHandler(tex59_Leave);
		this.s46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s46.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s46.Enabled = false;
		this.s46.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s46.Location = new System.Drawing.Point(3, 419);
		this.s46.Multiline = true;
		this.s46.Name = "s46";
		this.s46.Size = new System.Drawing.Size(162, 45);
		this.s46.TabIndex = 58;
		this.s46.Text = "0";
		this.s46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s46.Click += new System.EventHandler(tex58_Click);
		this.s46.TextChanged += new System.EventHandler(tex58_TextChanged);
		this.s46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex58_KeyPress);
		this.s46.Leave += new System.EventHandler(tex58_Leave);
		this.s45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s45.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s45.Enabled = false;
		this.s45.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s45.Location = new System.Drawing.Point(3, 368);
		this.s45.Multiline = true;
		this.s45.Name = "s45";
		this.s45.Size = new System.Drawing.Size(162, 45);
		this.s45.TabIndex = 57;
		this.s45.Text = "0";
		this.s45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s45.Click += new System.EventHandler(tex57_Click);
		this.s45.TextChanged += new System.EventHandler(tex57_TextChanged);
		this.s45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex57_KeyPress);
		this.s45.Leave += new System.EventHandler(tex57_Leave);
		this.s44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s44.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s44.Enabled = false;
		this.s44.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s44.Location = new System.Drawing.Point(3, 317);
		this.s44.Multiline = true;
		this.s44.Name = "s44";
		this.s44.Size = new System.Drawing.Size(162, 45);
		this.s44.TabIndex = 56;
		this.s44.Text = "0";
		this.s44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s44.Click += new System.EventHandler(tex56_Click);
		this.s44.TextChanged += new System.EventHandler(tex56_TextChanged);
		this.s44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex56_KeyPress);
		this.s44.Leave += new System.EventHandler(tex56_Leave);
		this.s43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s43.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s43.Enabled = false;
		this.s43.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s43.Location = new System.Drawing.Point(3, 266);
		this.s43.Multiline = true;
		this.s43.Name = "s43";
		this.s43.Size = new System.Drawing.Size(162, 45);
		this.s43.TabIndex = 55;
		this.s43.Text = "0";
		this.s43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s43.Click += new System.EventHandler(tex55_Click);
		this.s43.TextChanged += new System.EventHandler(tex55_TextChanged);
		this.s43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex55_KeyPress);
		this.s43.Leave += new System.EventHandler(tex55_Leave);
		this.s42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s42.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s42.Enabled = false;
		this.s42.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s42.Location = new System.Drawing.Point(3, 215);
		this.s42.Multiline = true;
		this.s42.Name = "s42";
		this.s42.Size = new System.Drawing.Size(162, 45);
		this.s42.TabIndex = 54;
		this.s42.Text = "0";
		this.s42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s42.Click += new System.EventHandler(tex54_Click);
		this.s42.TextChanged += new System.EventHandler(tex54_TextChanged);
		this.s42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex54_KeyPress);
		this.s42.Leave += new System.EventHandler(tex54_Leave);
		this.s41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s41.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s41.Enabled = false;
		this.s41.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s41.Location = new System.Drawing.Point(3, 164);
		this.s41.Multiline = true;
		this.s41.Name = "s41";
		this.s41.Size = new System.Drawing.Size(162, 45);
		this.s41.TabIndex = 53;
		this.s41.Text = "0";
		this.s41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s41.Click += new System.EventHandler(tex53_Click);
		this.s41.TextChanged += new System.EventHandler(tex53_TextChanged);
		this.s41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex53_KeyPress);
		this.s41.Leave += new System.EventHandler(tex53_Leave);
		this.s40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s40.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s40.Enabled = false;
		this.s40.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s40.Location = new System.Drawing.Point(3, 113);
		this.s40.Multiline = true;
		this.s40.Name = "s40";
		this.s40.Size = new System.Drawing.Size(162, 45);
		this.s40.TabIndex = 52;
		this.s40.Text = "0";
		this.s40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s40.Click += new System.EventHandler(tex52_Click);
		this.s40.TextChanged += new System.EventHandler(tex52_TextChanged);
		this.s40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex52_KeyPress);
		this.s40.Leave += new System.EventHandler(tex52_Leave);
		this.s39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s39.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s39.Enabled = false;
		this.s39.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s39.Location = new System.Drawing.Point(3, 63);
		this.s39.Multiline = true;
		this.s39.Name = "s39";
		this.s39.Size = new System.Drawing.Size(162, 44);
		this.s39.TabIndex = 51;
		this.s39.Text = "0";
		this.s39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s39.Click += new System.EventHandler(tex51_Click);
		this.s39.TextChanged += new System.EventHandler(tex51_TextChanged);
		this.s39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex51_KeyPress);
		this.s39.Leave += new System.EventHandler(tex51_Leave);
		this.label168.AutoSize = true;
		this.label168.BackColor = System.Drawing.Color.Lavender;
		this.label168.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label168.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label168.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label168.ForeColor = System.Drawing.Color.Black;
		this.label168.Location = new System.Drawing.Point(171, 569);
		this.label168.Name = "label168";
		this.label168.Size = new System.Drawing.Size(321, 51);
		this.label168.TabIndex = 5951;
		this.label168.Text = "كاندید 49";
		this.label168.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label39.AutoSize = true;
		this.label39.BackColor = System.Drawing.Color.Lavender;
		this.label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label39.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label39.ForeColor = System.Drawing.Color.Black;
		this.label39.Location = new System.Drawing.Point(889, 569);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(321, 51);
		this.label39.TabIndex = 5951;
		this.label39.Text = "كاندید 11";
		this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label170.AutoSize = true;
		this.label170.BackColor = System.Drawing.Color.Lavender;
		this.label170.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label170.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label170.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label170.ForeColor = System.Drawing.Color.Black;
		this.label170.Location = new System.Drawing.Point(171, 518);
		this.label170.Name = "label170";
		this.label170.Size = new System.Drawing.Size(321, 51);
		this.label170.TabIndex = 5949;
		this.label170.Text = "كاندید 48";
		this.label170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label169.AutoSize = true;
		this.label169.BackColor = System.Drawing.Color.Lavender;
		this.label169.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label169.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label169.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label169.ForeColor = System.Drawing.Color.Black;
		this.label169.Location = new System.Drawing.Point(498, 569);
		this.label169.Name = "label169";
		this.label169.Size = new System.Drawing.Size(157, 51);
		this.label169.TabIndex = 5950;
		this.label169.Text = "49";
		this.label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label172.AutoSize = true;
		this.label172.BackColor = System.Drawing.Color.Lavender;
		this.label172.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label172.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label172.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label172.ForeColor = System.Drawing.Color.Black;
		this.label172.Location = new System.Drawing.Point(171, 467);
		this.label172.Name = "label172";
		this.label172.Size = new System.Drawing.Size(321, 51);
		this.label172.TabIndex = 5947;
		this.label172.Text = "كاندید 47";
		this.label172.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label38.AutoSize = true;
		this.label38.BackColor = System.Drawing.Color.Lavender;
		this.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label38.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label38.ForeColor = System.Drawing.Color.Black;
		this.label38.Location = new System.Drawing.Point(1216, 569);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(157, 51);
		this.label38.TabIndex = 5950;
		this.label38.Text = "11";
		this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label174.AutoSize = true;
		this.label174.BackColor = System.Drawing.Color.Lavender;
		this.label174.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label174.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label174.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label174.ForeColor = System.Drawing.Color.Black;
		this.label174.Location = new System.Drawing.Point(171, 416);
		this.label174.Name = "label174";
		this.label174.Size = new System.Drawing.Size(321, 51);
		this.label174.TabIndex = 5945;
		this.label174.Text = "كاندید 46";
		this.label174.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label37.AutoSize = true;
		this.label37.BackColor = System.Drawing.Color.Lavender;
		this.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label37.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label37.ForeColor = System.Drawing.Color.Black;
		this.label37.Location = new System.Drawing.Point(889, 518);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(321, 51);
		this.label37.TabIndex = 5949;
		this.label37.Text = "كاندید 10";
		this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label176.AutoSize = true;
		this.label176.BackColor = System.Drawing.Color.Lavender;
		this.label176.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label176.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label176.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label176.ForeColor = System.Drawing.Color.Black;
		this.label176.Location = new System.Drawing.Point(171, 365);
		this.label176.Name = "label176";
		this.label176.Size = new System.Drawing.Size(321, 51);
		this.label176.TabIndex = 5943;
		this.label176.Text = "كاندید 45";
		this.label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label171.AutoSize = true;
		this.label171.BackColor = System.Drawing.Color.Lavender;
		this.label171.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label171.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label171.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label171.ForeColor = System.Drawing.Color.Black;
		this.label171.Location = new System.Drawing.Point(498, 518);
		this.label171.Name = "label171";
		this.label171.Size = new System.Drawing.Size(157, 51);
		this.label171.TabIndex = 5948;
		this.label171.Text = "48";
		this.label171.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label178.AutoSize = true;
		this.label178.BackColor = System.Drawing.Color.Lavender;
		this.label178.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label178.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label178.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label178.ForeColor = System.Drawing.Color.Black;
		this.label178.Location = new System.Drawing.Point(171, 314);
		this.label178.Name = "label178";
		this.label178.Size = new System.Drawing.Size(321, 51);
		this.label178.TabIndex = 5941;
		this.label178.Text = "كاندید 44";
		this.label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label36.AutoSize = true;
		this.label36.BackColor = System.Drawing.Color.Lavender;
		this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label36.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label36.ForeColor = System.Drawing.Color.Black;
		this.label36.Location = new System.Drawing.Point(1216, 518);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(157, 51);
		this.label36.TabIndex = 5948;
		this.label36.Text = "10";
		this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label180.AutoSize = true;
		this.label180.BackColor = System.Drawing.Color.Lavender;
		this.label180.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label180.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label180.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label180.ForeColor = System.Drawing.Color.Black;
		this.label180.Location = new System.Drawing.Point(171, 263);
		this.label180.Name = "label180";
		this.label180.Size = new System.Drawing.Size(321, 51);
		this.label180.TabIndex = 5939;
		this.label180.Text = "كاندید 43";
		this.label180.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label35.AutoSize = true;
		this.label35.BackColor = System.Drawing.Color.Lavender;
		this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label35.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label35.ForeColor = System.Drawing.Color.Black;
		this.label35.Location = new System.Drawing.Point(889, 467);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(321, 51);
		this.label35.TabIndex = 5947;
		this.label35.Text = "كاندید 9";
		this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label173.AutoSize = true;
		this.label173.BackColor = System.Drawing.Color.Lavender;
		this.label173.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label173.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label173.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label173.ForeColor = System.Drawing.Color.Black;
		this.label173.Location = new System.Drawing.Point(498, 467);
		this.label173.Name = "label173";
		this.label173.Size = new System.Drawing.Size(157, 51);
		this.label173.TabIndex = 5946;
		this.label173.Text = "47";
		this.label173.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label184.AutoSize = true;
		this.label184.BackColor = System.Drawing.Color.Lavender;
		this.label184.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label184.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label184.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label184.ForeColor = System.Drawing.Color.Black;
		this.label184.Location = new System.Drawing.Point(171, 161);
		this.label184.Name = "label184";
		this.label184.Size = new System.Drawing.Size(321, 51);
		this.label184.TabIndex = 5935;
		this.label184.Text = "كاندید 41";
		this.label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label34.AutoSize = true;
		this.label34.BackColor = System.Drawing.Color.Lavender;
		this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label34.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label34.ForeColor = System.Drawing.Color.Black;
		this.label34.Location = new System.Drawing.Point(1216, 467);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(157, 51);
		this.label34.TabIndex = 5946;
		this.label34.Text = "9";
		this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label186.AutoSize = true;
		this.label186.BackColor = System.Drawing.Color.Lavender;
		this.label186.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label186.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label186.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label186.ForeColor = System.Drawing.Color.Black;
		this.label186.Location = new System.Drawing.Point(171, 110);
		this.label186.Name = "label186";
		this.label186.Size = new System.Drawing.Size(321, 51);
		this.label186.TabIndex = 5933;
		this.label186.Text = "كاندید 40";
		this.label186.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label33.AutoSize = true;
		this.label33.BackColor = System.Drawing.Color.Lavender;
		this.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label33.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label33.ForeColor = System.Drawing.Color.Black;
		this.label33.Location = new System.Drawing.Point(889, 416);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(321, 51);
		this.label33.TabIndex = 5945;
		this.label33.Text = "كاندید 8";
		this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label188.AutoSize = true;
		this.label188.BackColor = System.Drawing.Color.Lavender;
		this.label188.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label188.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label188.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label188.ForeColor = System.Drawing.Color.Black;
		this.label188.Location = new System.Drawing.Point(171, 60);
		this.label188.Name = "label188";
		this.label188.Size = new System.Drawing.Size(321, 50);
		this.label188.TabIndex = 5931;
		this.label188.Text = "كاندید 39";
		this.label188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label32.AutoSize = true;
		this.label32.BackColor = System.Drawing.Color.Lavender;
		this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label32.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label32.ForeColor = System.Drawing.Color.Black;
		this.label32.Location = new System.Drawing.Point(1216, 416);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(157, 51);
		this.label32.TabIndex = 5944;
		this.label32.Text = "8";
		this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label31.AutoSize = true;
		this.label31.BackColor = System.Drawing.Color.Lavender;
		this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label31.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label31.ForeColor = System.Drawing.Color.Black;
		this.label31.Location = new System.Drawing.Point(889, 365);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(321, 51);
		this.label31.TabIndex = 5943;
		this.label31.Text = "كاندید 7";
		this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label30.AutoSize = true;
		this.label30.BackColor = System.Drawing.Color.Lavender;
		this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label30.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label30.ForeColor = System.Drawing.Color.Black;
		this.label30.Location = new System.Drawing.Point(1216, 365);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(157, 51);
		this.label30.TabIndex = 5942;
		this.label30.Text = "7";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label29.AutoSize = true;
		this.label29.BackColor = System.Drawing.Color.Lavender;
		this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label29.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label29.ForeColor = System.Drawing.Color.Black;
		this.label29.Location = new System.Drawing.Point(889, 314);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(321, 51);
		this.label29.TabIndex = 5941;
		this.label29.Text = "كاندید 6";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label28.AutoSize = true;
		this.label28.BackColor = System.Drawing.Color.Lavender;
		this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label28.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label28.ForeColor = System.Drawing.Color.Black;
		this.label28.Location = new System.Drawing.Point(1216, 314);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(157, 51);
		this.label28.TabIndex = 5940;
		this.label28.Text = "6";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label27.AutoSize = true;
		this.label27.BackColor = System.Drawing.Color.Lavender;
		this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label27.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label27.ForeColor = System.Drawing.Color.Black;
		this.label27.Location = new System.Drawing.Point(889, 263);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(321, 51);
		this.label27.TabIndex = 5939;
		this.label27.Text = "كاندید 5";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label26.AutoSize = true;
		this.label26.BackColor = System.Drawing.Color.Lavender;
		this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label26.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label26.ForeColor = System.Drawing.Color.Black;
		this.label26.Location = new System.Drawing.Point(1216, 263);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(157, 51);
		this.label26.TabIndex = 5938;
		this.label26.Text = "5";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.AutoSize = true;
		this.label25.BackColor = System.Drawing.Color.Lavender;
		this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label25.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label25.ForeColor = System.Drawing.Color.Black;
		this.label25.Location = new System.Drawing.Point(889, 212);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(321, 51);
		this.label25.TabIndex = 5937;
		this.label25.Text = "كاندید 4";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label24.AutoSize = true;
		this.label24.BackColor = System.Drawing.Color.Lavender;
		this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label24.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label24.ForeColor = System.Drawing.Color.Black;
		this.label24.Location = new System.Drawing.Point(1216, 212);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(157, 51);
		this.label24.TabIndex = 5936;
		this.label24.Text = "4";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label23.AutoSize = true;
		this.label23.BackColor = System.Drawing.Color.Lavender;
		this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label23.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label23.ForeColor = System.Drawing.Color.Black;
		this.label23.Location = new System.Drawing.Point(889, 161);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(321, 51);
		this.label23.TabIndex = 5935;
		this.label23.Text = "كاندید 3";
		this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label22.AutoSize = true;
		this.label22.BackColor = System.Drawing.Color.Lavender;
		this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label22.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label22.ForeColor = System.Drawing.Color.Black;
		this.label22.Location = new System.Drawing.Point(1216, 161);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(157, 51);
		this.label22.TabIndex = 5934;
		this.label22.Text = "3";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label21.AutoSize = true;
		this.label21.BackColor = System.Drawing.Color.Lavender;
		this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label21.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label21.ForeColor = System.Drawing.Color.Black;
		this.label21.Location = new System.Drawing.Point(889, 110);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(321, 51);
		this.label21.TabIndex = 5933;
		this.label21.Text = "كاندید 2";
		this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label20.AutoSize = true;
		this.label20.BackColor = System.Drawing.Color.Lavender;
		this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label20.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.ForeColor = System.Drawing.Color.Black;
		this.label20.Location = new System.Drawing.Point(1216, 110);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(157, 51);
		this.label20.TabIndex = 5932;
		this.label20.Text = "2";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label19.AutoSize = true;
		this.label19.BackColor = System.Drawing.Color.Lavender;
		this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label19.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label19.ForeColor = System.Drawing.Color.Black;
		this.label19.Location = new System.Drawing.Point(889, 60);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(321, 50);
		this.label19.TabIndex = 5931;
		this.label19.Text = "كاندید 1";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label18.AutoSize = true;
		this.label18.BackColor = System.Drawing.Color.Lavender;
		this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label18.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label18.ForeColor = System.Drawing.Color.Black;
		this.label18.Location = new System.Drawing.Point(1216, 60);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(157, 50);
		this.label18.TabIndex = 5930;
		this.label18.Text = "1";
		this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s2.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s2.Location = new System.Drawing.Point(726, 113);
		this.s2.Multiline = true;
		this.s2.Name = "s2";
		this.s2.Size = new System.Drawing.Size(157, 45);
		this.s2.TabIndex = 14;
		this.s2.Text = "0";
		this.s2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s2.Click += new System.EventHandler(tex14_Click);
		this.s2.TextChanged += new System.EventHandler(tex14_TextChanged);
		this.s2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex14_KeyPress);
		this.s2.Leave += new System.EventHandler(tex14_Leave);
		this.s3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s3.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s3.Location = new System.Drawing.Point(726, 164);
		this.s3.Multiline = true;
		this.s3.Name = "s3";
		this.s3.Size = new System.Drawing.Size(157, 45);
		this.s3.TabIndex = 15;
		this.s3.Text = "0";
		this.s3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s3.Click += new System.EventHandler(tex15_Click);
		this.s3.TextChanged += new System.EventHandler(tex15_TextChanged);
		this.s3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex15_KeyPress);
		this.s3.Leave += new System.EventHandler(tex15_Leave);
		this.s4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s4.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s4.Location = new System.Drawing.Point(726, 215);
		this.s4.Multiline = true;
		this.s4.Name = "s4";
		this.s4.Size = new System.Drawing.Size(157, 45);
		this.s4.TabIndex = 16;
		this.s4.Text = "0";
		this.s4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s4.Click += new System.EventHandler(tex16_Click);
		this.s4.TextChanged += new System.EventHandler(tex16_TextChanged);
		this.s4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex16_KeyPress);
		this.s4.Leave += new System.EventHandler(tex16_Leave);
		this.s11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s11.Enabled = false;
		this.s11.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s11.Location = new System.Drawing.Point(726, 572);
		this.s11.Multiline = true;
		this.s11.Name = "s11";
		this.s11.Size = new System.Drawing.Size(157, 45);
		this.s11.TabIndex = 23;
		this.s11.Text = "0";
		this.s11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s11.Click += new System.EventHandler(tex23_Click);
		this.s11.TextChanged += new System.EventHandler(tex23_TextChanged);
		this.s11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex23_KeyPress);
		this.s11.Leave += new System.EventHandler(tex23_Leave);
		this.s5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s5.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s5.Location = new System.Drawing.Point(726, 266);
		this.s5.Multiline = true;
		this.s5.Name = "s5";
		this.s5.Size = new System.Drawing.Size(157, 45);
		this.s5.TabIndex = 17;
		this.s5.Text = "0";
		this.s5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s5.Click += new System.EventHandler(tex17_Click);
		this.s5.TextChanged += new System.EventHandler(tex17_TextChanged);
		this.s5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex17_KeyPress);
		this.s5.Leave += new System.EventHandler(tex17_Leave);
		this.s9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s9.Enabled = false;
		this.s9.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s9.Location = new System.Drawing.Point(726, 470);
		this.s9.Multiline = true;
		this.s9.Name = "s9";
		this.s9.Size = new System.Drawing.Size(157, 45);
		this.s9.TabIndex = 21;
		this.s9.Text = "0";
		this.s9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s9.Click += new System.EventHandler(tex21_Click);
		this.s9.TextChanged += new System.EventHandler(tex21_TextChanged);
		this.s9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex21_KeyPress);
		this.s9.Leave += new System.EventHandler(tex21_Leave);
		this.s6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s6.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s6.Location = new System.Drawing.Point(726, 317);
		this.s6.Multiline = true;
		this.s6.Name = "s6";
		this.s6.Size = new System.Drawing.Size(157, 45);
		this.s6.TabIndex = 18;
		this.s6.Text = "0";
		this.s6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s6.Click += new System.EventHandler(tex18_Click);
		this.s6.TextChanged += new System.EventHandler(tex18_TextChanged);
		this.s6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex18_KeyPress);
		this.s6.Leave += new System.EventHandler(tex18_Leave);
		this.s7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s7.Enabled = false;
		this.s7.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s7.Location = new System.Drawing.Point(726, 368);
		this.s7.Multiline = true;
		this.s7.Name = "s7";
		this.s7.Size = new System.Drawing.Size(157, 45);
		this.s7.TabIndex = 19;
		this.s7.Text = "0";
		this.s7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s7.Click += new System.EventHandler(tex19_Click);
		this.s7.TextChanged += new System.EventHandler(tex19_TextChanged);
		this.s7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex19_KeyPress);
		this.s7.Leave += new System.EventHandler(tex19_Leave);
		this.s12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s12.Enabled = false;
		this.s12.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s12.Location = new System.Drawing.Point(726, 623);
		this.s12.Multiline = true;
		this.s12.Name = "s12";
		this.s12.Size = new System.Drawing.Size(157, 45);
		this.s12.TabIndex = 24;
		this.s12.Text = "0";
		this.s12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s12.Click += new System.EventHandler(tex24_Click);
		this.s12.TextChanged += new System.EventHandler(tex24_TextChanged);
		this.s12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex24_KeyPress);
		this.s12.Leave += new System.EventHandler(tex24_Leave);
		this.s8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s8.Enabled = false;
		this.s8.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s8.Location = new System.Drawing.Point(726, 419);
		this.s8.Multiline = true;
		this.s8.Name = "s8";
		this.s8.Size = new System.Drawing.Size(157, 45);
		this.s8.TabIndex = 20;
		this.s8.Text = "0";
		this.s8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s8.Click += new System.EventHandler(tex20_Click);
		this.s8.TextChanged += new System.EventHandler(tex20_TextChanged);
		this.s8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex20_KeyPress);
		this.s8.Leave += new System.EventHandler(tex20_Leave);
		this.s13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s13.Enabled = false;
		this.s13.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s13.Location = new System.Drawing.Point(726, 674);
		this.s13.Multiline = true;
		this.s13.Name = "s13";
		this.s13.Size = new System.Drawing.Size(157, 45);
		this.s13.TabIndex = 25;
		this.s13.Text = "0";
		this.s13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s13.Click += new System.EventHandler(tex25_Click);
		this.s13.TextChanged += new System.EventHandler(tex25_TextChanged);
		this.s13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex25_KeyPress);
		this.s13.Leave += new System.EventHandler(tex25_Leave);
		this.s17.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s17.Enabled = false;
		this.s17.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s17.Location = new System.Drawing.Point(726, 878);
		this.s17.Multiline = true;
		this.s17.Name = "s17";
		this.s17.Size = new System.Drawing.Size(157, 45);
		this.s17.TabIndex = 29;
		this.s17.Text = "0";
		this.s17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s17.Click += new System.EventHandler(tex29_Click);
		this.s17.TextChanged += new System.EventHandler(tex29_TextChanged);
		this.s17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex29_KeyPress);
		this.s17.Leave += new System.EventHandler(tex29_Leave);
		this.s16.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s16.Enabled = false;
		this.s16.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s16.Location = new System.Drawing.Point(726, 827);
		this.s16.Multiline = true;
		this.s16.Name = "s16";
		this.s16.Size = new System.Drawing.Size(157, 45);
		this.s16.TabIndex = 28;
		this.s16.Text = "0";
		this.s16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s16.Click += new System.EventHandler(tex28_Click);
		this.s16.TextChanged += new System.EventHandler(tex28_TextChanged);
		this.s16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex28_KeyPress);
		this.s16.Leave += new System.EventHandler(tex28_Leave);
		this.s14.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s14.Enabled = false;
		this.s14.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s14.Location = new System.Drawing.Point(726, 725);
		this.s14.Multiline = true;
		this.s14.Name = "s14";
		this.s14.Size = new System.Drawing.Size(157, 45);
		this.s14.TabIndex = 26;
		this.s14.Text = "0";
		this.s14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s14.Click += new System.EventHandler(tex26_Click);
		this.s14.TextChanged += new System.EventHandler(tex26_TextChanged);
		this.s14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex26_KeyPress);
		this.s14.Leave += new System.EventHandler(tex26_Leave);
		this.s18.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s18.Enabled = false;
		this.s18.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s18.Location = new System.Drawing.Point(726, 929);
		this.s18.Multiline = true;
		this.s18.Name = "s18";
		this.s18.Size = new System.Drawing.Size(157, 45);
		this.s18.TabIndex = 30;
		this.s18.Text = "0";
		this.s18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s18.Click += new System.EventHandler(tex30_Click);
		this.s18.TextChanged += new System.EventHandler(tex30_TextChanged);
		this.s18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex30_KeyPress);
		this.s18.Leave += new System.EventHandler(tex30_Leave);
		this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button9.BackColor = System.Drawing.Color.RoyalBlue;
		this.button9.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button9.ForeColor = System.Drawing.Color.White;
		this.button9.Location = new System.Drawing.Point(726, 3);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(157, 54);
		this.button9.TabIndex = 5902;
		this.button9.Text = "ده\u200cنگ";
		this.button9.UseVisualStyleBackColor = false;
		this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button8.BackColor = System.Drawing.Color.RoyalBlue;
		this.button8.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button8.ForeColor = System.Drawing.Color.White;
		this.button8.Location = new System.Drawing.Point(889, 3);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(321, 54);
		this.button8.TabIndex = 5901;
		this.button8.Text = "ناوی كاندید";
		this.button8.UseVisualStyleBackColor = false;
		this.s19.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s19.Enabled = false;
		this.s19.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s19.Location = new System.Drawing.Point(726, 980);
		this.s19.Multiline = true;
		this.s19.Name = "s19";
		this.s19.Size = new System.Drawing.Size(157, 45);
		this.s19.TabIndex = 31;
		this.s19.Text = "0";
		this.s19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s19.Click += new System.EventHandler(tex31_Click);
		this.s19.TextChanged += new System.EventHandler(tex31_TextChanged);
		this.s19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex31_KeyPress);
		this.s19.Leave += new System.EventHandler(tex31_Leave);
		this.s20.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s20.Enabled = false;
		this.s20.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s20.Location = new System.Drawing.Point(726, 1031);
		this.s20.Multiline = true;
		this.s20.Name = "s20";
		this.s20.Size = new System.Drawing.Size(157, 45);
		this.s20.TabIndex = 32;
		this.s20.Text = "0";
		this.s20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s20.Click += new System.EventHandler(tex32_Click);
		this.s20.TextChanged += new System.EventHandler(tex32_TextChanged);
		this.s20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex32_KeyPress);
		this.s20.Leave += new System.EventHandler(tex32_Leave);
		this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button7.BackColor = System.Drawing.Color.RoyalBlue;
		this.button7.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button7.ForeColor = System.Drawing.Color.White;
		this.button7.Location = new System.Drawing.Point(1216, 3);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(157, 54);
		this.button7.TabIndex = 5898;
		this.button7.Text = "ژ.كاندید";
		this.button7.UseVisualStyleBackColor = false;
		this.s22.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s22.Enabled = false;
		this.s22.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s22.Location = new System.Drawing.Point(726, 1133);
		this.s22.Multiline = true;
		this.s22.Name = "s22";
		this.s22.Size = new System.Drawing.Size(157, 45);
		this.s22.TabIndex = 34;
		this.s22.Text = "0";
		this.s22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s22.Click += new System.EventHandler(tex34_Click);
		this.s22.TextChanged += new System.EventHandler(tex34_TextChanged);
		this.s22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex34_KeyPress);
		this.s22.Leave += new System.EventHandler(tex34_Leave);
		this.s24.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s24.Enabled = false;
		this.s24.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s24.Location = new System.Drawing.Point(726, 1235);
		this.s24.Multiline = true;
		this.s24.Name = "s24";
		this.s24.Size = new System.Drawing.Size(157, 45);
		this.s24.TabIndex = 36;
		this.s24.Text = "0";
		this.s24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s24.Click += new System.EventHandler(tex36_Click);
		this.s24.TextChanged += new System.EventHandler(tex36_TextChanged);
		this.s24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex36_KeyPress);
		this.s24.Leave += new System.EventHandler(tex36_Leave);
		this.s21.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s21.Enabled = false;
		this.s21.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s21.Location = new System.Drawing.Point(726, 1082);
		this.s21.Multiline = true;
		this.s21.Name = "s21";
		this.s21.Size = new System.Drawing.Size(157, 45);
		this.s21.TabIndex = 33;
		this.s21.Text = "0";
		this.s21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s21.Click += new System.EventHandler(tex33_Click);
		this.s21.TextChanged += new System.EventHandler(tex33_TextChanged);
		this.s21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex33_KeyPress);
		this.s21.Leave += new System.EventHandler(tex33_Leave);
		this.s38.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s38.Enabled = false;
		this.s38.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s38.Location = new System.Drawing.Point(726, 1949);
		this.s38.Multiline = true;
		this.s38.Name = "s38";
		this.s38.Size = new System.Drawing.Size(157, 53);
		this.s38.TabIndex = 50;
		this.s38.Text = "0";
		this.s38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s38.Click += new System.EventHandler(tex50_Click);
		this.s38.TextChanged += new System.EventHandler(tex50_TextChanged);
		this.s38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex50_KeyPress);
		this.s38.Leave += new System.EventHandler(tex50_Leave);
		this.s23.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s23.Enabled = false;
		this.s23.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s23.Location = new System.Drawing.Point(726, 1184);
		this.s23.Multiline = true;
		this.s23.Name = "s23";
		this.s23.Size = new System.Drawing.Size(157, 45);
		this.s23.TabIndex = 35;
		this.s23.Text = "0";
		this.s23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s23.Click += new System.EventHandler(tex35_Click);
		this.s23.TextChanged += new System.EventHandler(tex35_TextChanged);
		this.s23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex35_KeyPress);
		this.s23.Leave += new System.EventHandler(tex35_Leave);
		this.s37.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s37.Enabled = false;
		this.s37.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s37.Location = new System.Drawing.Point(726, 1898);
		this.s37.Multiline = true;
		this.s37.Name = "s37";
		this.s37.Size = new System.Drawing.Size(157, 45);
		this.s37.TabIndex = 49;
		this.s37.Text = "0";
		this.s37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s37.Click += new System.EventHandler(tex49_Click);
		this.s37.TextChanged += new System.EventHandler(tex49_TextChanged);
		this.s37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex49_KeyPress);
		this.s37.Leave += new System.EventHandler(tex49_Leave);
		this.s25.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s25.Enabled = false;
		this.s25.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s25.Location = new System.Drawing.Point(726, 1286);
		this.s25.Multiline = true;
		this.s25.Name = "s25";
		this.s25.Size = new System.Drawing.Size(157, 45);
		this.s25.TabIndex = 37;
		this.s25.Text = "0";
		this.s25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s25.Click += new System.EventHandler(tex37_Click);
		this.s25.TextChanged += new System.EventHandler(tex37_TextChanged);
		this.s25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex37_KeyPress);
		this.s25.Leave += new System.EventHandler(tex37_Leave);
		this.s36.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s36.Enabled = false;
		this.s36.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s36.Location = new System.Drawing.Point(726, 1847);
		this.s36.Multiline = true;
		this.s36.Name = "s36";
		this.s36.Size = new System.Drawing.Size(157, 45);
		this.s36.TabIndex = 48;
		this.s36.Text = "0";
		this.s36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s36.Click += new System.EventHandler(tex48_Click);
		this.s36.TextChanged += new System.EventHandler(tex48_TextChanged);
		this.s36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex48_KeyPress);
		this.s36.Leave += new System.EventHandler(tex48_Leave);
		this.s35.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s35.Enabled = false;
		this.s35.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s35.Location = new System.Drawing.Point(726, 1796);
		this.s35.Multiline = true;
		this.s35.Name = "s35";
		this.s35.Size = new System.Drawing.Size(157, 45);
		this.s35.TabIndex = 47;
		this.s35.Text = "0";
		this.s35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s35.Click += new System.EventHandler(tex47_Click);
		this.s35.TextChanged += new System.EventHandler(tex47_TextChanged);
		this.s35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex47_KeyPress);
		this.s35.Leave += new System.EventHandler(tex47_Leave);
		this.s34.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s34.Enabled = false;
		this.s34.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s34.Location = new System.Drawing.Point(726, 1745);
		this.s34.Multiline = true;
		this.s34.Name = "s34";
		this.s34.Size = new System.Drawing.Size(157, 45);
		this.s34.TabIndex = 46;
		this.s34.Text = "0";
		this.s34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s34.Click += new System.EventHandler(tex46_Click);
		this.s34.TextChanged += new System.EventHandler(tex46_TextChanged);
		this.s34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex46_KeyPress);
		this.s34.Leave += new System.EventHandler(tex46_Leave);
		this.s33.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s33.Enabled = false;
		this.s33.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s33.Location = new System.Drawing.Point(726, 1694);
		this.s33.Multiline = true;
		this.s33.Name = "s33";
		this.s33.Size = new System.Drawing.Size(157, 45);
		this.s33.TabIndex = 45;
		this.s33.Text = "0";
		this.s33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s33.Click += new System.EventHandler(tex45_Click);
		this.s33.TextChanged += new System.EventHandler(tex45_TextChanged);
		this.s33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex45_KeyPress);
		this.s33.Leave += new System.EventHandler(tex45_Leave);
		this.s32.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s32.Enabled = false;
		this.s32.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s32.Location = new System.Drawing.Point(726, 1643);
		this.s32.Multiline = true;
		this.s32.Name = "s32";
		this.s32.Size = new System.Drawing.Size(157, 45);
		this.s32.TabIndex = 44;
		this.s32.Text = "0";
		this.s32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s32.Click += new System.EventHandler(tex44_Click);
		this.s32.TextChanged += new System.EventHandler(tex44_TextChanged);
		this.s32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex44_KeyPress);
		this.s32.Leave += new System.EventHandler(tex44_Leave);
		this.s31.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s31.Enabled = false;
		this.s31.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s31.Location = new System.Drawing.Point(726, 1592);
		this.s31.Multiline = true;
		this.s31.Name = "s31";
		this.s31.Size = new System.Drawing.Size(157, 45);
		this.s31.TabIndex = 43;
		this.s31.Text = "0";
		this.s31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s31.Click += new System.EventHandler(tex43_Click);
		this.s31.TextChanged += new System.EventHandler(tex43_TextChanged);
		this.s31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex43_KeyPress);
		this.s31.Leave += new System.EventHandler(tex43_Leave);
		this.s30.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s30.Enabled = false;
		this.s30.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s30.Location = new System.Drawing.Point(726, 1541);
		this.s30.Multiline = true;
		this.s30.Name = "s30";
		this.s30.Size = new System.Drawing.Size(157, 45);
		this.s30.TabIndex = 42;
		this.s30.Text = "0";
		this.s30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s30.Click += new System.EventHandler(tex42_Click);
		this.s30.TextChanged += new System.EventHandler(tex42_TextChanged);
		this.s30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex42_KeyPress);
		this.s30.Leave += new System.EventHandler(tex42_Leave);
		this.s29.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s29.Enabled = false;
		this.s29.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s29.Location = new System.Drawing.Point(726, 1490);
		this.s29.Multiline = true;
		this.s29.Name = "s29";
		this.s29.Size = new System.Drawing.Size(157, 45);
		this.s29.TabIndex = 41;
		this.s29.Text = "0";
		this.s29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s29.Click += new System.EventHandler(tex41_Click);
		this.s29.TextChanged += new System.EventHandler(tex41_TextChanged);
		this.s29.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex41_KeyPress);
		this.s29.Leave += new System.EventHandler(tex41_Leave);
		this.s28.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s28.Enabled = false;
		this.s28.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s28.Location = new System.Drawing.Point(726, 1439);
		this.s28.Multiline = true;
		this.s28.Name = "s28";
		this.s28.Size = new System.Drawing.Size(157, 45);
		this.s28.TabIndex = 40;
		this.s28.Text = "0";
		this.s28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s28.Click += new System.EventHandler(tex40_Click);
		this.s28.TextChanged += new System.EventHandler(tex40_TextChanged);
		this.s28.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex40_KeyPress);
		this.s28.Leave += new System.EventHandler(tex40_Leave);
		this.s27.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s27.Enabled = false;
		this.s27.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s27.Location = new System.Drawing.Point(726, 1388);
		this.s27.Multiline = true;
		this.s27.Name = "s27";
		this.s27.Size = new System.Drawing.Size(157, 45);
		this.s27.TabIndex = 39;
		this.s27.Text = "0";
		this.s27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s27.Click += new System.EventHandler(tex39_Click);
		this.s27.TextChanged += new System.EventHandler(tex39_TextChanged);
		this.s27.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex39_KeyPress);
		this.s27.Leave += new System.EventHandler(tex39_Leave);
		this.s26.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s26.Enabled = false;
		this.s26.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s26.Location = new System.Drawing.Point(726, 1337);
		this.s26.Multiline = true;
		this.s26.Name = "s26";
		this.s26.Size = new System.Drawing.Size(157, 45);
		this.s26.TabIndex = 38;
		this.s26.Text = "0";
		this.s26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s26.Click += new System.EventHandler(tex38_Click);
		this.s26.TextChanged += new System.EventHandler(tex38_TextChanged);
		this.s26.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex38_KeyPress);
		this.s26.Leave += new System.EventHandler(tex38_Leave);
		this.s15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s15.Enabled = false;
		this.s15.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s15.Location = new System.Drawing.Point(726, 776);
		this.s15.Multiline = true;
		this.s15.Name = "s15";
		this.s15.Size = new System.Drawing.Size(157, 45);
		this.s15.TabIndex = 27;
		this.s15.Text = "0";
		this.s15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s15.Click += new System.EventHandler(tex27_Click);
		this.s15.TextChanged += new System.EventHandler(tex27_TextChanged);
		this.s15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex27_KeyPress);
		this.s15.Leave += new System.EventHandler(tex27_Leave);
		this.s10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s10.Enabled = false;
		this.s10.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s10.Location = new System.Drawing.Point(726, 521);
		this.s10.Multiline = true;
		this.s10.Name = "s10";
		this.s10.Size = new System.Drawing.Size(157, 45);
		this.s10.TabIndex = 22;
		this.s10.Text = "0";
		this.s10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s10.Click += new System.EventHandler(tex22_Click);
		this.s10.TextChanged += new System.EventHandler(tex22_TextChanged);
		this.s10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex22_KeyPress);
		this.s10.Leave += new System.EventHandler(tex22_Leave);
		this.s1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.s1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s1.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s1.Location = new System.Drawing.Point(726, 63);
		this.s1.Multiline = true;
		this.s1.Name = "s1";
		this.s1.Size = new System.Drawing.Size(157, 44);
		this.s1.TabIndex = 13;
		this.s1.Text = "0";
		this.s1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s1.Click += new System.EventHandler(tex13_Click);
		this.s1.TextChanged += new System.EventHandler(tex13_TextChanged);
		this.s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex13_KeyPress);
		this.s1.Leave += new System.EventHandler(tex13_Leave);
		this.button10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button10.BackColor = System.Drawing.Color.RoyalBlue;
		this.button10.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button10.ForeColor = System.Drawing.Color.White;
		this.button10.Location = new System.Drawing.Point(3, 3);
		this.button10.Name = "button10";
		this.button10.Size = new System.Drawing.Size(162, 54);
		this.button10.TabIndex = 5902;
		this.button10.Text = "ده\u200cنگ";
		this.button10.UseVisualStyleBackColor = false;
		this.button11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button11.BackColor = System.Drawing.Color.RoyalBlue;
		this.button11.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button11.ForeColor = System.Drawing.Color.White;
		this.button11.Location = new System.Drawing.Point(171, 3);
		this.button11.Name = "button11";
		this.button11.Size = new System.Drawing.Size(321, 54);
		this.button11.TabIndex = 5901;
		this.button11.Text = "ناوی كاندید";
		this.button11.UseVisualStyleBackColor = false;
		this.button12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button12.BackColor = System.Drawing.Color.RoyalBlue;
		this.button12.Font = new System.Drawing.Font("Unikurd Jino", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button12.ForeColor = System.Drawing.Color.White;
		this.button12.Location = new System.Drawing.Point(498, 3);
		this.button12.Name = "button12";
		this.button12.Size = new System.Drawing.Size(157, 54);
		this.button12.TabIndex = 5898;
		this.button12.Text = "ژ.كاندید";
		this.button12.UseVisualStyleBackColor = false;
		this.label189.AutoSize = true;
		this.label189.BackColor = System.Drawing.Color.Lavender;
		this.label189.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label189.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label189.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label189.ForeColor = System.Drawing.Color.Black;
		this.label189.Location = new System.Drawing.Point(498, 60);
		this.label189.Name = "label189";
		this.label189.Size = new System.Drawing.Size(157, 50);
		this.label189.TabIndex = 5930;
		this.label189.Text = "39";
		this.label189.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label187.AutoSize = true;
		this.label187.BackColor = System.Drawing.Color.Lavender;
		this.label187.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label187.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label187.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label187.ForeColor = System.Drawing.Color.Black;
		this.label187.Location = new System.Drawing.Point(498, 110);
		this.label187.Name = "label187";
		this.label187.Size = new System.Drawing.Size(157, 51);
		this.label187.TabIndex = 5932;
		this.label187.Text = "40";
		this.label187.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label185.AutoSize = true;
		this.label185.BackColor = System.Drawing.Color.Lavender;
		this.label185.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label185.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label185.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label185.ForeColor = System.Drawing.Color.Black;
		this.label185.Location = new System.Drawing.Point(498, 161);
		this.label185.Name = "label185";
		this.label185.Size = new System.Drawing.Size(157, 51);
		this.label185.TabIndex = 5934;
		this.label185.Text = "41";
		this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label183.AutoSize = true;
		this.label183.BackColor = System.Drawing.Color.Lavender;
		this.label183.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label183.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label183.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label183.ForeColor = System.Drawing.Color.Black;
		this.label183.Location = new System.Drawing.Point(498, 212);
		this.label183.Name = "label183";
		this.label183.Size = new System.Drawing.Size(157, 51);
		this.label183.TabIndex = 5936;
		this.label183.Text = "42";
		this.label183.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label181.AutoSize = true;
		this.label181.BackColor = System.Drawing.Color.Lavender;
		this.label181.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label181.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label181.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label181.ForeColor = System.Drawing.Color.Black;
		this.label181.Location = new System.Drawing.Point(498, 263);
		this.label181.Name = "label181";
		this.label181.Size = new System.Drawing.Size(157, 51);
		this.label181.TabIndex = 5938;
		this.label181.Text = "43";
		this.label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label179.AutoSize = true;
		this.label179.BackColor = System.Drawing.Color.Lavender;
		this.label179.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label179.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label179.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label179.ForeColor = System.Drawing.Color.Black;
		this.label179.Location = new System.Drawing.Point(498, 314);
		this.label179.Name = "label179";
		this.label179.Size = new System.Drawing.Size(157, 51);
		this.label179.TabIndex = 5940;
		this.label179.Text = "44";
		this.label179.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label177.AutoSize = true;
		this.label177.BackColor = System.Drawing.Color.Lavender;
		this.label177.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label177.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label177.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label177.ForeColor = System.Drawing.Color.Black;
		this.label177.Location = new System.Drawing.Point(498, 365);
		this.label177.Name = "label177";
		this.label177.Size = new System.Drawing.Size(157, 51);
		this.label177.TabIndex = 5942;
		this.label177.Text = "45";
		this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label175.AutoSize = true;
		this.label175.BackColor = System.Drawing.Color.Lavender;
		this.label175.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label175.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label175.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label175.ForeColor = System.Drawing.Color.Black;
		this.label175.Location = new System.Drawing.Point(498, 416);
		this.label175.Name = "label175";
		this.label175.Size = new System.Drawing.Size(157, 51);
		this.label175.TabIndex = 5944;
		this.label175.Text = "46";
		this.label175.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label182.AutoSize = true;
		this.label182.BackColor = System.Drawing.Color.Lavender;
		this.label182.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label182.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label182.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label182.ForeColor = System.Drawing.Color.Black;
		this.label182.Location = new System.Drawing.Point(171, 212);
		this.label182.Name = "label182";
		this.label182.Size = new System.Drawing.Size(321, 51);
		this.label182.TabIndex = 5937;
		this.label182.Text = "كاندید 42";
		this.label182.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label153.AutoSize = true;
		this.label153.BackColor = System.Drawing.Color.Lavender;
		this.label153.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label153.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label153.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label153.ForeColor = System.Drawing.Color.Black;
		this.label153.Location = new System.Drawing.Point(498, 926);
		this.label153.Name = "label153";
		this.label153.Size = new System.Drawing.Size(157, 51);
		this.label153.TabIndex = 5966;
		this.label153.Text = "56";
		this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label152.AutoSize = true;
		this.label152.BackColor = System.Drawing.Color.Lavender;
		this.label152.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label152.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label152.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label152.ForeColor = System.Drawing.Color.Black;
		this.label152.Location = new System.Drawing.Point(171, 926);
		this.label152.Name = "label152";
		this.label152.Size = new System.Drawing.Size(321, 51);
		this.label152.TabIndex = 5967;
		this.label152.Text = "كاندید 56";
		this.label152.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s56.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s56.Enabled = false;
		this.s56.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s56.Location = new System.Drawing.Point(3, 929);
		this.s56.Multiline = true;
		this.s56.Name = "s56";
		this.s56.Size = new System.Drawing.Size(162, 45);
		this.s56.TabIndex = 68;
		this.s56.Text = "0";
		this.s56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s56.Click += new System.EventHandler(tex69_Click);
		this.s56.TextChanged += new System.EventHandler(tex69_TextChanged);
		this.s56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex69_KeyPress);
		this.s56.Leave += new System.EventHandler(tex69_Leave);
		this.label151.AutoSize = true;
		this.label151.BackColor = System.Drawing.Color.Lavender;
		this.label151.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label151.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label151.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label151.ForeColor = System.Drawing.Color.Black;
		this.label151.Location = new System.Drawing.Point(498, 977);
		this.label151.Name = "label151";
		this.label151.Size = new System.Drawing.Size(157, 51);
		this.label151.TabIndex = 5968;
		this.label151.Text = "57";
		this.label151.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label150.AutoSize = true;
		this.label150.BackColor = System.Drawing.Color.Lavender;
		this.label150.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label150.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label150.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label150.ForeColor = System.Drawing.Color.Black;
		this.label150.Location = new System.Drawing.Point(171, 977);
		this.label150.Name = "label150";
		this.label150.Size = new System.Drawing.Size(321, 51);
		this.label150.TabIndex = 5969;
		this.label150.Text = "كاندید 57";
		this.label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s57.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s57.Enabled = false;
		this.s57.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s57.Location = new System.Drawing.Point(3, 980);
		this.s57.Multiline = true;
		this.s57.Name = "s57";
		this.s57.Size = new System.Drawing.Size(162, 45);
		this.s57.TabIndex = 69;
		this.s57.Text = "0";
		this.s57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s57.Click += new System.EventHandler(tex70_Click);
		this.s57.TextChanged += new System.EventHandler(tex70_TextChanged);
		this.s57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex70_KeyPress);
		this.s57.Leave += new System.EventHandler(tex70_Leave);
		this.s58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s58.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s58.Enabled = false;
		this.s58.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s58.Location = new System.Drawing.Point(3, 1031);
		this.s58.Multiline = true;
		this.s58.Name = "s58";
		this.s58.Size = new System.Drawing.Size(162, 45);
		this.s58.TabIndex = 70;
		this.s58.Text = "0";
		this.s58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s58.Click += new System.EventHandler(tex71_Click);
		this.s58.TextChanged += new System.EventHandler(tex71_TextChanged);
		this.s58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex71_KeyPress);
		this.s58.Leave += new System.EventHandler(tex71_Leave);
		this.s59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s59.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s59.Enabled = false;
		this.s59.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s59.Location = new System.Drawing.Point(3, 1082);
		this.s59.Multiline = true;
		this.s59.Name = "s59";
		this.s59.Size = new System.Drawing.Size(162, 45);
		this.s59.TabIndex = 71;
		this.s59.Text = "0";
		this.s59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s59.Click += new System.EventHandler(tex72_Click);
		this.s59.TextChanged += new System.EventHandler(tex72_TextChanged);
		this.s59.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex72_KeyPress);
		this.s59.Leave += new System.EventHandler(tex72_Leave);
		this.s60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s60.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s60.Enabled = false;
		this.s60.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s60.Location = new System.Drawing.Point(3, 1133);
		this.s60.Multiline = true;
		this.s60.Name = "s60";
		this.s60.Size = new System.Drawing.Size(162, 45);
		this.s60.TabIndex = 72;
		this.s60.Text = "0";
		this.s60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s60.Click += new System.EventHandler(tex73_Click);
		this.s60.TextChanged += new System.EventHandler(tex73_TextChanged);
		this.s60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex73_KeyPress);
		this.s60.Leave += new System.EventHandler(tex73_Leave);
		this.s61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s61.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s61.Enabled = false;
		this.s61.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s61.Location = new System.Drawing.Point(3, 1184);
		this.s61.Multiline = true;
		this.s61.Name = "s61";
		this.s61.Size = new System.Drawing.Size(162, 45);
		this.s61.TabIndex = 73;
		this.s61.Text = "0";
		this.s61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s61.Click += new System.EventHandler(tex74_Click);
		this.s61.TextChanged += new System.EventHandler(tex74_TextChanged);
		this.s61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex74_KeyPress);
		this.s61.Leave += new System.EventHandler(tex74_Leave);
		this.s62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s62.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s62.Enabled = false;
		this.s62.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s62.Location = new System.Drawing.Point(3, 1235);
		this.s62.Multiline = true;
		this.s62.Name = "s62";
		this.s62.Size = new System.Drawing.Size(162, 45);
		this.s62.TabIndex = 74;
		this.s62.Text = "0";
		this.s62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s62.Click += new System.EventHandler(tex75_Click);
		this.s62.TextChanged += new System.EventHandler(tex75_TextChanged);
		this.s62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex75_KeyPress);
		this.s62.Leave += new System.EventHandler(tex75_Leave);
		this.s63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s63.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s63.Enabled = false;
		this.s63.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s63.Location = new System.Drawing.Point(3, 1286);
		this.s63.Multiline = true;
		this.s63.Name = "s63";
		this.s63.Size = new System.Drawing.Size(162, 45);
		this.s63.TabIndex = 75;
		this.s63.Text = "0";
		this.s63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s63.Click += new System.EventHandler(tex76_Click);
		this.s63.TextChanged += new System.EventHandler(tex76_TextChanged);
		this.s63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex76_KeyPress);
		this.s63.Leave += new System.EventHandler(tex76_Leave);
		this.label148.AutoSize = true;
		this.label148.BackColor = System.Drawing.Color.Lavender;
		this.label148.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label148.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label148.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label148.ForeColor = System.Drawing.Color.Black;
		this.label148.Location = new System.Drawing.Point(171, 1028);
		this.label148.Name = "label148";
		this.label148.Size = new System.Drawing.Size(321, 51);
		this.label148.TabIndex = 5971;
		this.label148.Text = "كاندید 58";
		this.label148.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label146.AutoSize = true;
		this.label146.BackColor = System.Drawing.Color.Lavender;
		this.label146.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label146.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label146.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label146.ForeColor = System.Drawing.Color.Black;
		this.label146.Location = new System.Drawing.Point(171, 1079);
		this.label146.Name = "label146";
		this.label146.Size = new System.Drawing.Size(321, 51);
		this.label146.TabIndex = 5973;
		this.label146.Text = "كاندید 59";
		this.label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label144.AutoSize = true;
		this.label144.BackColor = System.Drawing.Color.Lavender;
		this.label144.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label144.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label144.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label144.ForeColor = System.Drawing.Color.Black;
		this.label144.Location = new System.Drawing.Point(171, 1130);
		this.label144.Name = "label144";
		this.label144.Size = new System.Drawing.Size(321, 51);
		this.label144.TabIndex = 5975;
		this.label144.Text = "كاندید 60";
		this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label142.AutoSize = true;
		this.label142.BackColor = System.Drawing.Color.Lavender;
		this.label142.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label142.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label142.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label142.ForeColor = System.Drawing.Color.Black;
		this.label142.Location = new System.Drawing.Point(171, 1181);
		this.label142.Name = "label142";
		this.label142.Size = new System.Drawing.Size(321, 51);
		this.label142.TabIndex = 5977;
		this.label142.Text = "كاندید 61";
		this.label142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label140.AutoSize = true;
		this.label140.BackColor = System.Drawing.Color.Lavender;
		this.label140.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label140.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label140.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label140.ForeColor = System.Drawing.Color.Black;
		this.label140.Location = new System.Drawing.Point(171, 1232);
		this.label140.Name = "label140";
		this.label140.Size = new System.Drawing.Size(321, 51);
		this.label140.TabIndex = 5979;
		this.label140.Text = "كاندید 62";
		this.label140.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label138.AutoSize = true;
		this.label138.BackColor = System.Drawing.Color.Lavender;
		this.label138.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label138.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label138.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label138.ForeColor = System.Drawing.Color.Black;
		this.label138.Location = new System.Drawing.Point(171, 1283);
		this.label138.Name = "label138";
		this.label138.Size = new System.Drawing.Size(321, 51);
		this.label138.TabIndex = 5981;
		this.label138.Text = "كاندید 63";
		this.label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label136.AutoSize = true;
		this.label136.BackColor = System.Drawing.Color.Lavender;
		this.label136.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label136.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label136.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label136.ForeColor = System.Drawing.Color.Black;
		this.label136.Location = new System.Drawing.Point(171, 1334);
		this.label136.Name = "label136";
		this.label136.Size = new System.Drawing.Size(321, 51);
		this.label136.TabIndex = 5983;
		this.label136.Text = "كاندید 64";
		this.label136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label134.AutoSize = true;
		this.label134.BackColor = System.Drawing.Color.Lavender;
		this.label134.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label134.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label134.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label134.ForeColor = System.Drawing.Color.Black;
		this.label134.Location = new System.Drawing.Point(171, 1385);
		this.label134.Name = "label134";
		this.label134.Size = new System.Drawing.Size(321, 51);
		this.label134.TabIndex = 5985;
		this.label134.Text = "كاندید 65";
		this.label134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label132.AutoSize = true;
		this.label132.BackColor = System.Drawing.Color.Lavender;
		this.label132.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label132.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label132.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label132.ForeColor = System.Drawing.Color.Black;
		this.label132.Location = new System.Drawing.Point(171, 1436);
		this.label132.Name = "label132";
		this.label132.Size = new System.Drawing.Size(321, 51);
		this.label132.TabIndex = 5987;
		this.label132.Text = "كاندید 66";
		this.label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label149.AutoSize = true;
		this.label149.BackColor = System.Drawing.Color.Lavender;
		this.label149.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label149.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label149.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label149.ForeColor = System.Drawing.Color.Black;
		this.label149.Location = new System.Drawing.Point(498, 1028);
		this.label149.Name = "label149";
		this.label149.Size = new System.Drawing.Size(157, 51);
		this.label149.TabIndex = 5970;
		this.label149.Text = "58";
		this.label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label147.AutoSize = true;
		this.label147.BackColor = System.Drawing.Color.Lavender;
		this.label147.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label147.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label147.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label147.ForeColor = System.Drawing.Color.Black;
		this.label147.Location = new System.Drawing.Point(498, 1079);
		this.label147.Name = "label147";
		this.label147.Size = new System.Drawing.Size(157, 51);
		this.label147.TabIndex = 5972;
		this.label147.Text = "59";
		this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label145.AutoSize = true;
		this.label145.BackColor = System.Drawing.Color.Lavender;
		this.label145.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label145.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label145.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label145.ForeColor = System.Drawing.Color.Black;
		this.label145.Location = new System.Drawing.Point(498, 1130);
		this.label145.Name = "label145";
		this.label145.Size = new System.Drawing.Size(157, 51);
		this.label145.TabIndex = 5974;
		this.label145.Text = "60";
		this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label143.AutoSize = true;
		this.label143.BackColor = System.Drawing.Color.Lavender;
		this.label143.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label143.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label143.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label143.ForeColor = System.Drawing.Color.Black;
		this.label143.Location = new System.Drawing.Point(498, 1181);
		this.label143.Name = "label143";
		this.label143.Size = new System.Drawing.Size(157, 51);
		this.label143.TabIndex = 5976;
		this.label143.Text = "61";
		this.label143.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label141.AutoSize = true;
		this.label141.BackColor = System.Drawing.Color.Lavender;
		this.label141.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label141.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label141.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label141.ForeColor = System.Drawing.Color.Black;
		this.label141.Location = new System.Drawing.Point(498, 1232);
		this.label141.Name = "label141";
		this.label141.Size = new System.Drawing.Size(157, 51);
		this.label141.TabIndex = 5978;
		this.label141.Text = "62";
		this.label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label139.AutoSize = true;
		this.label139.BackColor = System.Drawing.Color.Lavender;
		this.label139.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label139.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label139.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label139.ForeColor = System.Drawing.Color.Black;
		this.label139.Location = new System.Drawing.Point(498, 1283);
		this.label139.Name = "label139";
		this.label139.Size = new System.Drawing.Size(157, 51);
		this.label139.TabIndex = 5980;
		this.label139.Text = "63";
		this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label137.AutoSize = true;
		this.label137.BackColor = System.Drawing.Color.Lavender;
		this.label137.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label137.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label137.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label137.ForeColor = System.Drawing.Color.Black;
		this.label137.Location = new System.Drawing.Point(498, 1334);
		this.label137.Name = "label137";
		this.label137.Size = new System.Drawing.Size(157, 51);
		this.label137.TabIndex = 5982;
		this.label137.Text = "64";
		this.label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label135.AutoSize = true;
		this.label135.BackColor = System.Drawing.Color.Lavender;
		this.label135.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label135.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label135.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label135.ForeColor = System.Drawing.Color.Black;
		this.label135.Location = new System.Drawing.Point(498, 1385);
		this.label135.Name = "label135";
		this.label135.Size = new System.Drawing.Size(157, 51);
		this.label135.TabIndex = 5984;
		this.label135.Text = "65";
		this.label135.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label133.AutoSize = true;
		this.label133.BackColor = System.Drawing.Color.Lavender;
		this.label133.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label133.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label133.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label133.ForeColor = System.Drawing.Color.Black;
		this.label133.Location = new System.Drawing.Point(498, 1436);
		this.label133.Name = "label133";
		this.label133.Size = new System.Drawing.Size(157, 51);
		this.label133.TabIndex = 5986;
		this.label133.Text = "66";
		this.label133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s64.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s64.Enabled = false;
		this.s64.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s64.Location = new System.Drawing.Point(3, 1337);
		this.s64.Multiline = true;
		this.s64.Name = "s64";
		this.s64.Size = new System.Drawing.Size(162, 45);
		this.s64.TabIndex = 76;
		this.s64.Text = "0";
		this.s64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s64.Click += new System.EventHandler(tex77_Click);
		this.s64.TextChanged += new System.EventHandler(tex77_TextChanged);
		this.s64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex77_KeyPress);
		this.s64.Leave += new System.EventHandler(tex77_Leave);
		this.s65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s65.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s65.Enabled = false;
		this.s65.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s65.Location = new System.Drawing.Point(3, 1388);
		this.s65.Multiline = true;
		this.s65.Name = "s65";
		this.s65.Size = new System.Drawing.Size(162, 45);
		this.s65.TabIndex = 77;
		this.s65.Text = "0";
		this.s65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s65.Click += new System.EventHandler(tex78_Click);
		this.s65.TextChanged += new System.EventHandler(tex78_TextChanged);
		this.s65.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex78_KeyPress);
		this.s65.Leave += new System.EventHandler(tex78_Leave);
		this.s66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s66.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s66.Enabled = false;
		this.s66.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s66.Location = new System.Drawing.Point(3, 1439);
		this.s66.Multiline = true;
		this.s66.Name = "s66";
		this.s66.Size = new System.Drawing.Size(162, 45);
		this.s66.TabIndex = 78;
		this.s66.Text = "0";
		this.s66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s66.Click += new System.EventHandler(tex79_Click);
		this.s66.TextChanged += new System.EventHandler(tex79_TextChanged);
		this.s66.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex79_KeyPress);
		this.s66.Leave += new System.EventHandler(tex79_Leave);
		this.label131.AutoSize = true;
		this.label131.BackColor = System.Drawing.Color.Lavender;
		this.label131.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label131.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label131.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label131.ForeColor = System.Drawing.Color.Black;
		this.label131.Location = new System.Drawing.Point(498, 1487);
		this.label131.Name = "label131";
		this.label131.Size = new System.Drawing.Size(157, 51);
		this.label131.TabIndex = 5988;
		this.label131.Text = "67";
		this.label131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label129.AutoSize = true;
		this.label129.BackColor = System.Drawing.Color.Lavender;
		this.label129.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label129.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label129.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label129.ForeColor = System.Drawing.Color.Black;
		this.label129.Location = new System.Drawing.Point(498, 1538);
		this.label129.Name = "label129";
		this.label129.Size = new System.Drawing.Size(157, 51);
		this.label129.TabIndex = 5990;
		this.label129.Text = "68";
		this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label127.AutoSize = true;
		this.label127.BackColor = System.Drawing.Color.Lavender;
		this.label127.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label127.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label127.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label127.ForeColor = System.Drawing.Color.Black;
		this.label127.Location = new System.Drawing.Point(498, 1589);
		this.label127.Name = "label127";
		this.label127.Size = new System.Drawing.Size(157, 51);
		this.label127.TabIndex = 5992;
		this.label127.Text = "69";
		this.label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label125.AutoSize = true;
		this.label125.BackColor = System.Drawing.Color.Lavender;
		this.label125.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label125.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label125.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label125.ForeColor = System.Drawing.Color.Black;
		this.label125.Location = new System.Drawing.Point(498, 1640);
		this.label125.Name = "label125";
		this.label125.Size = new System.Drawing.Size(157, 51);
		this.label125.TabIndex = 5994;
		this.label125.Text = "70";
		this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label123.AutoSize = true;
		this.label123.BackColor = System.Drawing.Color.Lavender;
		this.label123.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label123.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label123.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label123.ForeColor = System.Drawing.Color.Black;
		this.label123.Location = new System.Drawing.Point(498, 1691);
		this.label123.Name = "label123";
		this.label123.Size = new System.Drawing.Size(157, 51);
		this.label123.TabIndex = 5996;
		this.label123.Text = "71";
		this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label121.AutoSize = true;
		this.label121.BackColor = System.Drawing.Color.Lavender;
		this.label121.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label121.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label121.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label121.ForeColor = System.Drawing.Color.Black;
		this.label121.Location = new System.Drawing.Point(498, 1742);
		this.label121.Name = "label121";
		this.label121.Size = new System.Drawing.Size(157, 51);
		this.label121.TabIndex = 5998;
		this.label121.Text = "72";
		this.label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label119.AutoSize = true;
		this.label119.BackColor = System.Drawing.Color.Lavender;
		this.label119.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label119.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label119.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label119.ForeColor = System.Drawing.Color.Black;
		this.label119.Location = new System.Drawing.Point(498, 1793);
		this.label119.Name = "label119";
		this.label119.Size = new System.Drawing.Size(157, 51);
		this.label119.TabIndex = 6000;
		this.label119.Text = "73";
		this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label117.AutoSize = true;
		this.label117.BackColor = System.Drawing.Color.Lavender;
		this.label117.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label117.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label117.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label117.ForeColor = System.Drawing.Color.Black;
		this.label117.Location = new System.Drawing.Point(498, 1844);
		this.label117.Name = "label117";
		this.label117.Size = new System.Drawing.Size(157, 51);
		this.label117.TabIndex = 6002;
		this.label117.Text = "74";
		this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label95.AutoSize = true;
		this.label95.BackColor = System.Drawing.Color.Lavender;
		this.label95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label95.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label95.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label95.ForeColor = System.Drawing.Color.Black;
		this.label95.Location = new System.Drawing.Point(498, 1895);
		this.label95.Name = "label95";
		this.label95.Size = new System.Drawing.Size(157, 51);
		this.label95.TabIndex = 6004;
		this.label95.Text = "75";
		this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label130.AutoSize = true;
		this.label130.BackColor = System.Drawing.Color.Lavender;
		this.label130.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label130.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label130.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label130.ForeColor = System.Drawing.Color.Black;
		this.label130.Location = new System.Drawing.Point(171, 1487);
		this.label130.Name = "label130";
		this.label130.Size = new System.Drawing.Size(321, 51);
		this.label130.TabIndex = 5989;
		this.label130.Text = "كاندید 67";
		this.label130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label128.AutoSize = true;
		this.label128.BackColor = System.Drawing.Color.Lavender;
		this.label128.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label128.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label128.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label128.ForeColor = System.Drawing.Color.Black;
		this.label128.Location = new System.Drawing.Point(171, 1538);
		this.label128.Name = "label128";
		this.label128.Size = new System.Drawing.Size(321, 51);
		this.label128.TabIndex = 5991;
		this.label128.Text = "كاندید 68";
		this.label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label126.AutoSize = true;
		this.label126.BackColor = System.Drawing.Color.Lavender;
		this.label126.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label126.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label126.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label126.ForeColor = System.Drawing.Color.Black;
		this.label126.Location = new System.Drawing.Point(171, 1589);
		this.label126.Name = "label126";
		this.label126.Size = new System.Drawing.Size(321, 51);
		this.label126.TabIndex = 5993;
		this.label126.Text = "كاندید 69";
		this.label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label124.AutoSize = true;
		this.label124.BackColor = System.Drawing.Color.Lavender;
		this.label124.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label124.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label124.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label124.ForeColor = System.Drawing.Color.Black;
		this.label124.Location = new System.Drawing.Point(171, 1640);
		this.label124.Name = "label124";
		this.label124.Size = new System.Drawing.Size(321, 51);
		this.label124.TabIndex = 5995;
		this.label124.Text = "كاندید 70";
		this.label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label122.AutoSize = true;
		this.label122.BackColor = System.Drawing.Color.Lavender;
		this.label122.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label122.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label122.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label122.ForeColor = System.Drawing.Color.Black;
		this.label122.Location = new System.Drawing.Point(171, 1691);
		this.label122.Name = "label122";
		this.label122.Size = new System.Drawing.Size(321, 51);
		this.label122.TabIndex = 5997;
		this.label122.Text = "كاندید 71";
		this.label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label120.AutoSize = true;
		this.label120.BackColor = System.Drawing.Color.Lavender;
		this.label120.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label120.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label120.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label120.ForeColor = System.Drawing.Color.Black;
		this.label120.Location = new System.Drawing.Point(171, 1742);
		this.label120.Name = "label120";
		this.label120.Size = new System.Drawing.Size(321, 51);
		this.label120.TabIndex = 5999;
		this.label120.Text = "كاندید 72";
		this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label118.AutoSize = true;
		this.label118.BackColor = System.Drawing.Color.Lavender;
		this.label118.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label118.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label118.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label118.ForeColor = System.Drawing.Color.Black;
		this.label118.Location = new System.Drawing.Point(171, 1793);
		this.label118.Name = "label118";
		this.label118.Size = new System.Drawing.Size(321, 51);
		this.label118.TabIndex = 6001;
		this.label118.Text = "كاندید 73";
		this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label116.AutoSize = true;
		this.label116.BackColor = System.Drawing.Color.Lavender;
		this.label116.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label116.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label116.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label116.ForeColor = System.Drawing.Color.Black;
		this.label116.Location = new System.Drawing.Point(171, 1844);
		this.label116.Name = "label116";
		this.label116.Size = new System.Drawing.Size(321, 51);
		this.label116.TabIndex = 6003;
		this.label116.Text = "كاندید 74";
		this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label94.AutoSize = true;
		this.label94.BackColor = System.Drawing.Color.Lavender;
		this.label94.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label94.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label94.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label94.ForeColor = System.Drawing.Color.Black;
		this.label94.Location = new System.Drawing.Point(171, 1895);
		this.label94.Name = "label94";
		this.label94.Size = new System.Drawing.Size(321, 51);
		this.label94.TabIndex = 6005;
		this.label94.Text = "كاندید 75";
		this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.s67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s67.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s67.Enabled = false;
		this.s67.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s67.Location = new System.Drawing.Point(3, 1490);
		this.s67.Multiline = true;
		this.s67.Name = "s67";
		this.s67.Size = new System.Drawing.Size(162, 45);
		this.s67.TabIndex = 79;
		this.s67.Text = "0";
		this.s67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s67.Click += new System.EventHandler(tex80_Click);
		this.s67.TextChanged += new System.EventHandler(tex80_TextChanged);
		this.s67.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex80_KeyPress);
		this.s67.Leave += new System.EventHandler(tex80_Leave);
		this.s68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s68.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s68.Enabled = false;
		this.s68.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s68.Location = new System.Drawing.Point(3, 1541);
		this.s68.Multiline = true;
		this.s68.Name = "s68";
		this.s68.Size = new System.Drawing.Size(162, 45);
		this.s68.TabIndex = 80;
		this.s68.Text = "0";
		this.s68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s68.Click += new System.EventHandler(tex81_Click);
		this.s68.TextChanged += new System.EventHandler(tex81_TextChanged);
		this.s68.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex81_KeyPress);
		this.s68.Leave += new System.EventHandler(tex81_Leave);
		this.s69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s69.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s69.Enabled = false;
		this.s69.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s69.Location = new System.Drawing.Point(3, 1592);
		this.s69.Multiline = true;
		this.s69.Name = "s69";
		this.s69.Size = new System.Drawing.Size(162, 45);
		this.s69.TabIndex = 81;
		this.s69.Text = "0";
		this.s69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s69.Click += new System.EventHandler(tex82_Click);
		this.s69.TextChanged += new System.EventHandler(tex82_TextChanged);
		this.s69.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex82_KeyPress);
		this.s69.Leave += new System.EventHandler(tex82_Leave);
		this.s70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s70.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s70.Enabled = false;
		this.s70.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s70.Location = new System.Drawing.Point(3, 1643);
		this.s70.Multiline = true;
		this.s70.Name = "s70";
		this.s70.Size = new System.Drawing.Size(162, 45);
		this.s70.TabIndex = 82;
		this.s70.Text = "0";
		this.s70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s70.Click += new System.EventHandler(tex83_Click);
		this.s70.TextChanged += new System.EventHandler(tex83_TextChanged);
		this.s70.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex83_KeyPress);
		this.s70.Leave += new System.EventHandler(tex83_Leave);
		this.s71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s71.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s71.Enabled = false;
		this.s71.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s71.Location = new System.Drawing.Point(3, 1694);
		this.s71.Multiline = true;
		this.s71.Name = "s71";
		this.s71.Size = new System.Drawing.Size(162, 45);
		this.s71.TabIndex = 83;
		this.s71.Text = "0";
		this.s71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s71.Click += new System.EventHandler(tex84_Click);
		this.s71.TextChanged += new System.EventHandler(tex84_TextChanged);
		this.s71.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex84_KeyPress);
		this.s71.Leave += new System.EventHandler(tex84_Leave);
		this.s72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.s72.Dock = System.Windows.Forms.DockStyle.Fill;
		this.s72.Enabled = false;
		this.s72.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.s72.Location = new System.Drawing.Point(3, 1745);
		this.s72.Multiline = true;
		this.s72.Name = "s72";
		this.s72.Size = new System.Drawing.Size(162, 45);
		this.s72.TabIndex = 84;
		this.s72.Text = "0";
		this.s72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.s72.Click += new System.EventHandler(tex85_Click);
		this.s72.TextChanged += new System.EventHandler(tex85_TextChanged);
		this.s72.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex85_KeyPress);
		this.s72.Leave += new System.EventHandler(tex85_Leave);
		this.tex86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.tex86.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tex86.Enabled = false;
		this.tex86.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tex86.Location = new System.Drawing.Point(3, 1796);
		this.tex86.Multiline = true;
		this.tex86.Name = "tex86";
		this.tex86.Size = new System.Drawing.Size(162, 45);
		this.tex86.TabIndex = 85;
		this.tex86.Text = "0";
		this.tex86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.tex86.Click += new System.EventHandler(tex86_Click);
		this.tex86.TextChanged += new System.EventHandler(tex86_TextChanged);
		this.tex86.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex86_KeyPress);
		this.tex86.Leave += new System.EventHandler(tex86_Leave);
		this.tex87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.tex87.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tex87.Enabled = false;
		this.tex87.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tex87.Location = new System.Drawing.Point(3, 1847);
		this.tex87.Multiline = true;
		this.tex87.Name = "tex87";
		this.tex87.Size = new System.Drawing.Size(162, 45);
		this.tex87.TabIndex = 86;
		this.tex87.Text = "0";
		this.tex87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.tex87.Click += new System.EventHandler(tex87_Click);
		this.tex87.TextChanged += new System.EventHandler(tex87_TextChanged);
		this.tex87.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex87_KeyPress);
		this.tex87.Leave += new System.EventHandler(tex87_Leave);
		this.tex88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.tex88.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tex88.Enabled = false;
		this.tex88.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tex88.Location = new System.Drawing.Point(3, 1898);
		this.tex88.Multiline = true;
		this.tex88.Name = "tex88";
		this.tex88.Size = new System.Drawing.Size(162, 45);
		this.tex88.TabIndex = 87;
		this.tex88.Text = "0";
		this.tex88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.tex88.Click += new System.EventHandler(tex88_Click);
		this.tex88.TextChanged += new System.EventHandler(tex88_TextChanged);
		this.tex88.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex88_KeyPress);
		this.tex88.Leave += new System.EventHandler(tex88_Leave);
		this.tex89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.tex89.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tex89.Enabled = false;
		this.tex89.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.tex89.Location = new System.Drawing.Point(3, 1949);
		this.tex89.Multiline = true;
		this.tex89.Name = "tex89";
		this.tex89.Size = new System.Drawing.Size(162, 53);
		this.tex89.TabIndex = 88;
		this.tex89.Text = "0";
		this.tex89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.tex89.Click += new System.EventHandler(tex89_Click);
		this.tex89.TextChanged += new System.EventHandler(tex89_TextChanged);
		this.tex89.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tex89_KeyPress);
		this.tex89.Leave += new System.EventHandler(tex89_Leave);
		this.label154.AutoSize = true;
		this.label154.BackColor = System.Drawing.Color.Lavender;
		this.label154.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label154.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label154.Font = new System.Drawing.Font("Unikurd Jino", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label154.ForeColor = System.Drawing.Color.Black;
		this.label154.Location = new System.Drawing.Point(171, 1946);
		this.label154.Name = "label154";
		this.label154.Size = new System.Drawing.Size(321, 59);
		this.label154.TabIndex = 5965;
		this.label154.Text = "كاندید 76";
		this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label155.AutoSize = true;
		this.label155.BackColor = System.Drawing.Color.Lavender;
		this.label155.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label155.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label155.Font = new System.Drawing.Font("Unikurd Jino", 16.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label155.ForeColor = System.Drawing.Color.Black;
		this.label155.Location = new System.Drawing.Point(498, 1946);
		this.label155.Name = "label155";
		this.label155.Size = new System.Drawing.Size(157, 59);
		this.label155.TabIndex = 5964;
		this.label155.Text = "76";
		this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1412, 800);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.pnl_titil_ca);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Candid_hl";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Candid_T";
		base.Load += new System.EventHandler(Candid_T_Load);
		this.pnl_titil_ca.ResumeLayout(false);
		this.pnl_titil_ca.PerformLayout();
		this.tableLayoutPanel1.ResumeLayout(false);
		this.tableLayoutPanel1.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.tableLayoutPanel3.ResumeLayout(false);
		this.tableLayoutPanel3.PerformLayout();
		base.ResumeLayout(false);
	}
}
