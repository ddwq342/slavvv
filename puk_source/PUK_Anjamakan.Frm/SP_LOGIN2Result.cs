using System.Data.Linq.Mapping;

namespace PUK_Anjamakan.Frm;

public class SP_LOGIN2Result
{
	private int _ID;

	private string _User_Name;

	private string _Password;

	private string _User_Type;

	[Column(Storage = "_ID", DbType = "Int NOT NULL")]
	public int ID
	{
		get
		{
			return _ID;
		}
		set
		{
			if (_ID != value)
			{
				_ID = value;
			}
		}
	}

	[Column(Storage = "_User_Name", DbType = "VarChar(50)")]
	public string User_Name
	{
		get
		{
			return _User_Name;
		}
		set
		{
			if (_User_Name != value)
			{
				_User_Name = value;
			}
		}
	}

	[Column(Storage = "_Password", DbType = "VarChar(50)")]
	public string Password
	{
		get
		{
			return _Password;
		}
		set
		{
			if (_Password != value)
			{
				_Password = value;
			}
		}
	}

	[Column(Storage = "_User_Type", DbType = "VarChar(50)")]
	public string User_Type
	{
		get
		{
			return _User_Type;
		}
		set
		{
			if (_User_Type != value)
			{
				_User_Type = value;
			}
		}
	}
}
