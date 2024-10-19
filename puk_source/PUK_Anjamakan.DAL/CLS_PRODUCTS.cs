using System.Data;
using System.Data.SqlClient;

namespace PUK_Anjamakan.DAL;

internal class CLS_PRODUCTS
{
	public DataTable Getone(int ID)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[1]
		{
			new SqlParameter("@ID", SqlDbType.Int)
		};
		param[0].Value = ID;
		Dt = DAL.SelectData("Getone", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_one_taybat(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_one_taybat", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_malband_id(int ID)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[1]
		{
			new SqlParameter("@ID", SqlDbType.Int)
		};
		param[0].Value = ID;
		Dt = DAL.SelectData("get_malband_id", param);
		DAL.Close();
		return Dt;
	}

	public DataTable SP_LOGIN2(string User, string Pass, string type)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		SqlParameter[] param = new SqlParameter[3]
		{
			new SqlParameter("@user", SqlDbType.VarChar, 50),
			null,
			null
		};
		param[0].Value = User;
		param[1] = new SqlParameter("@Pass", SqlDbType.VarChar, 50);
		param[1].Value = Pass;
		param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
		param[2].Value = type;
		DataTable Dt = new DataTable();
		Dt = DAL.SelectData("SP_LOGIN2", param);
		DAL.Close();
		return Dt;
	}

	public void candid_ss(string naw_mahafaza, int cood_tasjil, int cood_bnka, string naw_bnka, int westga, int s1, int s2, int s3, int s4, int s5, int s6, int s7, int s8, int s9, int s10, int s11, int s12, int s13, int s14, int s15, int s16, int s17, int s18, int s19, int s20, int s21, int s22, int s23, int s24, int s25, int s26, int s27, int s28, int s29, int s30, int s31, int s32, int s33, int s34, int s35, int s36, int s37, int s38, int s39, int s40, int s41, int s42, int s43, int s44, int s45, int s46, int s47, int s48, int s49, int s50, int s51, int s52, int s53, int s54, int s55, int s56, int s57, int s58, int s59, int s60, int s61, int s62, int s63, int s64, int s65, int s66, int s67, int s68, int s69, int s70, int s71, int s72)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DAL.Open();
		SqlParameter[] param = new SqlParameter[77];
		param[0] = new SqlParameter("@naw_mahafaza", SqlDbType.NVarChar, 15);
		param[0].Value = naw_mahafaza;
		param[1] = new SqlParameter("@cood_tasjil", SqlDbType.Int);
		param[1].Value = cood_tasjil;
		param[2] = new SqlParameter("@cood_bnka", SqlDbType.Int);
		param[2].Value = cood_bnka;
		param[3] = new SqlParameter("@naw_bnka", SqlDbType.NVarChar, 50);
		param[3].Value = naw_bnka;
		param[4] = new SqlParameter("@westga", SqlDbType.Int);
		param[4].Value = westga;
		param[5] = new SqlParameter("@1", SqlDbType.Int);
		param[5].Value = s1;
		param[6] = new SqlParameter("@2", SqlDbType.Int);
		param[6].Value = s2;
		param[7] = new SqlParameter("@3", SqlDbType.Int);
		param[7].Value = s3;
		param[8] = new SqlParameter("@4", SqlDbType.Int);
		param[8].Value = s4;
		param[9] = new SqlParameter("@5", SqlDbType.Int);
		param[9].Value = s5;
		param[10] = new SqlParameter("@6", SqlDbType.Int);
		param[10].Value = s6;
		param[11] = new SqlParameter("@7", SqlDbType.Int);
		param[11].Value = s7;
		param[12] = new SqlParameter("@8", SqlDbType.Int);
		param[12].Value = s8;
		param[13] = new SqlParameter("@9", SqlDbType.Int);
		param[13].Value = s9;
		param[14] = new SqlParameter("@10", SqlDbType.Int);
		param[14].Value = s10;
		param[15] = new SqlParameter("@11", SqlDbType.Int);
		param[15].Value = s11;
		param[16] = new SqlParameter("@12", SqlDbType.Int);
		param[16].Value = s12;
		param[17] = new SqlParameter("@13", SqlDbType.Int);
		param[17].Value = s13;
		param[18] = new SqlParameter("@14", SqlDbType.Int);
		param[18].Value = s14;
		param[19] = new SqlParameter("@15", SqlDbType.Int);
		param[19].Value = s15;
		param[20] = new SqlParameter("@16", SqlDbType.Int);
		param[20].Value = s16;
		param[21] = new SqlParameter("@17", SqlDbType.Int);
		param[21].Value = s17;
		param[22] = new SqlParameter("@18", SqlDbType.Int);
		param[22].Value = s18;
		param[23] = new SqlParameter("@19", SqlDbType.Int);
		param[23].Value = s19;
		param[24] = new SqlParameter("@20", SqlDbType.Int);
		param[24].Value = s20;
		param[25] = new SqlParameter("@21", SqlDbType.Int);
		param[25].Value = 21;
		param[26] = new SqlParameter("@22", SqlDbType.Int);
		param[26].Value = s22;
		param[27] = new SqlParameter("@23", SqlDbType.Int);
		param[27].Value = s23;
		param[28] = new SqlParameter("@24", SqlDbType.Int);
		param[28].Value = s24;
		param[29] = new SqlParameter("@25", SqlDbType.Int);
		param[29].Value = s25;
		param[30] = new SqlParameter("@26", SqlDbType.Int);
		param[30].Value = s26;
		param[31] = new SqlParameter("@27", SqlDbType.Int);
		param[31].Value = s27;
		param[32] = new SqlParameter("@28", SqlDbType.Int);
		param[32].Value = s28;
		param[33] = new SqlParameter("@29", SqlDbType.Int);
		param[33].Value = s29;
		param[34] = new SqlParameter("@30", SqlDbType.Int);
		param[34].Value = s30;
		param[35] = new SqlParameter("@31", SqlDbType.Int);
		param[35].Value = s31;
		param[36] = new SqlParameter("@32", SqlDbType.Int);
		param[36].Value = s32;
		param[37] = new SqlParameter("@33", SqlDbType.Int);
		param[37].Value = s33;
		param[38] = new SqlParameter("@34", SqlDbType.Int);
		param[38].Value = s34;
		param[39] = new SqlParameter("@35", SqlDbType.Int);
		param[39].Value = s35;
		param[40] = new SqlParameter("@36", SqlDbType.Int);
		param[40].Value = s36;
		param[41] = new SqlParameter("@37", SqlDbType.Int);
		param[41].Value = s37;
		param[42] = new SqlParameter("@38", SqlDbType.Int);
		param[42].Value = s38;
		param[43] = new SqlParameter("@39", SqlDbType.Int);
		param[43].Value = s39;
		param[44] = new SqlParameter("@40", SqlDbType.Int);
		param[44].Value = s40;
		param[45] = new SqlParameter("@41", SqlDbType.Int);
		param[45].Value = s41;
		param[46] = new SqlParameter("@42", SqlDbType.Int);
		param[46].Value = s42;
		param[47] = new SqlParameter("@43", SqlDbType.Int);
		param[47].Value = s43;
		param[48] = new SqlParameter("@44", SqlDbType.Int);
		param[48].Value = s44;
		param[49] = new SqlParameter("@45", SqlDbType.Int);
		param[49].Value = s45;
		param[50] = new SqlParameter("@46", SqlDbType.Int);
		param[50].Value = s46;
		param[51] = new SqlParameter("@47", SqlDbType.Int);
		param[51].Value = s47;
		param[52] = new SqlParameter("@48", SqlDbType.Int);
		param[52].Value = s48;
		param[53] = new SqlParameter("@49", SqlDbType.Int);
		param[53].Value = s49;
		param[54] = new SqlParameter("@50", SqlDbType.Int);
		param[54].Value = s50;
		param[55] = new SqlParameter("@51", SqlDbType.Int);
		param[55].Value = s51;
		param[56] = new SqlParameter("@52", SqlDbType.Int);
		param[56].Value = s52;
		param[57] = new SqlParameter("@53", SqlDbType.Int);
		param[57].Value = s53;
		param[58] = new SqlParameter("@54", SqlDbType.Int);
		param[58].Value = s54;
		param[59] = new SqlParameter("@55", SqlDbType.Int);
		param[59].Value = s55;
		param[60] = new SqlParameter("@56", SqlDbType.Int);
		param[60].Value = s56;
		param[61] = new SqlParameter("@57", SqlDbType.Int);
		param[61].Value = s57;
		param[62] = new SqlParameter("@58", SqlDbType.Int);
		param[62].Value = s58;
		param[63] = new SqlParameter("@59", SqlDbType.Int);
		param[63].Value = s59;
		param[64] = new SqlParameter("@60", SqlDbType.Int);
		param[64].Value = s60;
		param[65] = new SqlParameter("@61", SqlDbType.Int);
		param[65].Value = s61;
		param[66] = new SqlParameter("@62", SqlDbType.Int);
		param[66].Value = s62;
		param[67] = new SqlParameter("@63", SqlDbType.Int);
		param[67].Value = s63;
		param[68] = new SqlParameter("@64", SqlDbType.Int);
		param[68].Value = s64;
		param[69] = new SqlParameter("@65", SqlDbType.Int);
		param[69].Value = s65;
		param[70] = new SqlParameter("@66", SqlDbType.Int);
		param[70].Value = s66;
		param[71] = new SqlParameter("@67", SqlDbType.Int);
		param[71].Value = s67;
		param[72] = new SqlParameter("@68", SqlDbType.Int);
		param[72].Value = s68;
		param[73] = new SqlParameter("@69", SqlDbType.Int);
		param[73].Value = s69;
		param[74] = new SqlParameter("@70", SqlDbType.Int);
		param[74].Value = s70;
		param[75] = new SqlParameter("@71", SqlDbType.Int);
		param[75].Value = s71;
		param[76] = new SqlParameter("@72", SqlDbType.Int);
		param[76].Value = s72;
		DAL.ExecuteCommand("candid_ss", param);
		DAL.Close();
	}

	public void candid_ss_update(int cood_bnka, int westga, int s1, int s2, int s3, int s4, int s5, int s6, int s7, int s8, int s9, int s10, int s11, int s12, int s13, int s14, int s15, int s16, int s17, int s18, int s19, int s20, int s21, int s22, int s23, int s24, int s25, int s26, int s27, int s28, int s29, int s30, int s31, int s32, int s33, int s34, int s35, int s36, int s37, int s38, int s39, int s40, int s41, int s42, int s43, int s44, int s45, int s46, int s47, int s48, int s49, int s50, int s51, int s52, int s53, int s54, int s55, int s56, int s57, int s58, int s59, int s60, int s61, int s62, int s63, int s64, int s65, int s66, int s67, int s68, int s69, int s70, int s71, int s72)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DAL.Open();
		SqlParameter[] param = new SqlParameter[75];
		param[1] = new SqlParameter("@cood_bnka", SqlDbType.Int);
		param[1].Value = cood_bnka;
		param[2] = new SqlParameter("@westga", SqlDbType.Int);
		param[2].Value = westga;
		param[3] = new SqlParameter("@1", SqlDbType.Int);
		param[3].Value = s1;
		param[4] = new SqlParameter("@2", SqlDbType.Int);
		param[4].Value = s2;
		param[5] = new SqlParameter("@3", SqlDbType.Int);
		param[5].Value = s3;
		param[6] = new SqlParameter("@4", SqlDbType.Int);
		param[6].Value = s4;
		param[7] = new SqlParameter("@5", SqlDbType.Int);
		param[7].Value = s5;
		param[8] = new SqlParameter("@6", SqlDbType.Int);
		param[8].Value = s6;
		param[9] = new SqlParameter("@7", SqlDbType.Int);
		param[9].Value = s7;
		param[10] = new SqlParameter("@8", SqlDbType.Int);
		param[10].Value = s8;
		param[11] = new SqlParameter("@9", SqlDbType.Int);
		param[11].Value = s9;
		param[12] = new SqlParameter("@10", SqlDbType.Int);
		param[12].Value = s10;
		param[13] = new SqlParameter("@11", SqlDbType.Int);
		param[13].Value = s11;
		param[14] = new SqlParameter("@12", SqlDbType.Int);
		param[14].Value = s12;
		param[15] = new SqlParameter("@13", SqlDbType.Int);
		param[15].Value = s13;
		param[16] = new SqlParameter("@14", SqlDbType.Int);
		param[16].Value = s14;
		param[17] = new SqlParameter("@15", SqlDbType.Int);
		param[17].Value = s15;
		param[18] = new SqlParameter("@16", SqlDbType.Int);
		param[18].Value = s16;
		param[19] = new SqlParameter("@17", SqlDbType.Int);
		param[19].Value = s17;
		param[20] = new SqlParameter("@18", SqlDbType.Int);
		param[20].Value = s18;
		param[21] = new SqlParameter("@19", SqlDbType.Int);
		param[21].Value = s19;
		param[22] = new SqlParameter("@20", SqlDbType.Int);
		param[22].Value = s20;
		param[23] = new SqlParameter("@21", SqlDbType.Int);
		param[23].Value = 21;
		param[24] = new SqlParameter("@22", SqlDbType.Int);
		param[24].Value = s22;
		param[25] = new SqlParameter("@23", SqlDbType.Int);
		param[25].Value = s23;
		param[26] = new SqlParameter("@24", SqlDbType.Int);
		param[26].Value = s24;
		param[27] = new SqlParameter("@25", SqlDbType.Int);
		param[27].Value = s25;
		param[28] = new SqlParameter("@26", SqlDbType.Int);
		param[28].Value = s26;
		param[29] = new SqlParameter("@27", SqlDbType.Int);
		param[29].Value = s27;
		param[30] = new SqlParameter("@28", SqlDbType.Int);
		param[30].Value = s28;
		param[31] = new SqlParameter("@29", SqlDbType.Int);
		param[31].Value = s29;
		param[32] = new SqlParameter("@30", SqlDbType.Int);
		param[32].Value = s30;
		param[33] = new SqlParameter("@31", SqlDbType.Int);
		param[33].Value = s31;
		param[34] = new SqlParameter("@32", SqlDbType.Int);
		param[34].Value = s32;
		param[35] = new SqlParameter("@33", SqlDbType.Int);
		param[35].Value = s33;
		param[36] = new SqlParameter("@34", SqlDbType.Int);
		param[36].Value = s34;
		param[37] = new SqlParameter("@35", SqlDbType.Int);
		param[37].Value = s35;
		param[38] = new SqlParameter("@36", SqlDbType.Int);
		param[38].Value = s36;
		param[39] = new SqlParameter("@37", SqlDbType.Int);
		param[39].Value = s37;
		param[40] = new SqlParameter("@38", SqlDbType.Int);
		param[40].Value = s38;
		param[41] = new SqlParameter("@39", SqlDbType.Int);
		param[41].Value = s39;
		param[42] = new SqlParameter("@40", SqlDbType.Int);
		param[42].Value = s40;
		param[43] = new SqlParameter("@41", SqlDbType.Int);
		param[43].Value = s41;
		param[44] = new SqlParameter("@42", SqlDbType.Int);
		param[44].Value = s42;
		param[45] = new SqlParameter("@43", SqlDbType.Int);
		param[45].Value = s43;
		param[46] = new SqlParameter("@44", SqlDbType.Int);
		param[46].Value = s44;
		param[47] = new SqlParameter("@45", SqlDbType.Int);
		param[47].Value = s45;
		param[48] = new SqlParameter("@46", SqlDbType.Int);
		param[48].Value = s46;
		param[49] = new SqlParameter("@47", SqlDbType.Int);
		param[49].Value = s47;
		param[50] = new SqlParameter("@48", SqlDbType.Int);
		param[50].Value = s48;
		param[51] = new SqlParameter("@49", SqlDbType.Int);
		param[51].Value = s49;
		param[52] = new SqlParameter("@50", SqlDbType.Int);
		param[52].Value = s50;
		param[53] = new SqlParameter("@51", SqlDbType.Int);
		param[53].Value = s51;
		param[54] = new SqlParameter("@52", SqlDbType.Int);
		param[54].Value = s52;
		param[55] = new SqlParameter("@53", SqlDbType.Int);
		param[55].Value = s53;
		param[56] = new SqlParameter("@54", SqlDbType.Int);
		param[56].Value = s54;
		param[57] = new SqlParameter("@55", SqlDbType.Int);
		param[57].Value = s55;
		param[58] = new SqlParameter("@56", SqlDbType.Int);
		param[58].Value = s56;
		param[59] = new SqlParameter("@57", SqlDbType.Int);
		param[59].Value = s57;
		param[60] = new SqlParameter("@58", SqlDbType.Int);
		param[60].Value = s58;
		param[61] = new SqlParameter("@59", SqlDbType.Int);
		param[61].Value = s59;
		param[62] = new SqlParameter("@60", SqlDbType.Int);
		param[62].Value = s60;
		param[63] = new SqlParameter("@61", SqlDbType.Int);
		param[63].Value = s61;
		param[64] = new SqlParameter("@62", SqlDbType.Int);
		param[64].Value = s62;
		param[65] = new SqlParameter("@63", SqlDbType.Int);
		param[65].Value = s63;
		param[66] = new SqlParameter("@64", SqlDbType.Int);
		param[66].Value = s64;
		param[67] = new SqlParameter("@65", SqlDbType.Int);
		param[67].Value = s65;
		param[68] = new SqlParameter("@66", SqlDbType.Int);
		param[68].Value = s66;
		param[69] = new SqlParameter("@67", SqlDbType.Int);
		param[69].Value = s67;
		param[70] = new SqlParameter("@68", SqlDbType.Int);
		param[70].Value = s68;
		param[71] = new SqlParameter("@69", SqlDbType.Int);
		param[71].Value = s69;
		param[72] = new SqlParameter("@70", SqlDbType.Int);
		param[72].Value = s70;
		param[73] = new SqlParameter("@71", SqlDbType.Int);
		param[73].Value = s71;
		param[74] = new SqlParameter("@72", SqlDbType.Int);
		param[74].Value = s72;
		DAL.ExecuteCommand("candid_ss", param);
		DAL.Close();
	}

	public DataTable get_candid_taybats(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_candid_taybats", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_candid_taybath(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_candid_taybath", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_candid_taybatd(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_candid_taybatd", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_candid_taybat_hl(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_candid_taybat_hl", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_hazb_s(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_hazb_s", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_hazb_h(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_hazb_h", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_hazb_d(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_hazb_d", param);
		DAL.Close();
		return Dt;
	}

	public DataTable get_hazb_HL(int bnka, int west)
	{
		DataAccessLayer DAL = new DataAccessLayer();
		DataTable Dt = new DataTable();
		SqlParameter[] param = new SqlParameter[2]
		{
			new SqlParameter("@bnka", SqlDbType.Int),
			null
		};
		param[0].Value = bnka;
		param[1] = new SqlParameter("@west", SqlDbType.Int);
		param[1].Value = west;
		Dt = DAL.SelectData("get_hazb_HL", param);
		DAL.Close();
		return Dt;
	}
}
