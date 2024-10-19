using System.Data;
using System.Data.SqlClient;
using PUK_Anjamakan.Properties;

namespace PUK_Anjamakan.DAL;

internal class DataAccessLayer
{
	private SqlConnection sqlconnection;

	public DataAccessLayer()
	{
		string mode = Settings.Default.Mode;
		if (mode == "SQL")
		{
			sqlconnection = new SqlConnection("Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=false; User ID=" + Settings.Default.ID + "; Password=" + Settings.Default.Password);
		}
		else
		{
			sqlconnection = new SqlConnection("Server=" + Settings.Default.Server + "; Database=" + Settings.Default.Database + "; Integrated Security=true");
		}
	}

	public void Open()
	{
		if (sqlconnection.State != ConnectionState.Open)
		{
			sqlconnection.Open();
		}
	}

	public void Close()
	{
		if (sqlconnection.State == ConnectionState.Open)
		{
			sqlconnection.Close();
		}
	}

	public DataTable SelectData(string stored_procedure, SqlParameter[] param)
	{
		SqlCommand sqlcmd = new SqlCommand();
		sqlcmd.CommandType = CommandType.StoredProcedure;
		sqlcmd.CommandText = stored_procedure;
		sqlcmd.Connection = sqlconnection;
		if (param != null)
		{
			for (int i = 0; i < param.Length; i++)
			{
				sqlcmd.Parameters.Add(param[i]);
			}
		}
		SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
		DataTable dt = new DataTable();
		da.Fill(dt);
		return dt;
	}

	public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
	{
		SqlCommand sqlcmd = new SqlCommand();
		sqlcmd.CommandType = CommandType.StoredProcedure;
		sqlcmd.CommandText = stored_procedure;
		sqlcmd.Connection = sqlconnection;
		if (param != null)
		{
			sqlcmd.Parameters.AddRange(param);
		}
		sqlcmd.ExecuteNonQuery();
	}
}
