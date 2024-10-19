using System.Data.Linq.Mapping;

namespace PUK_Anjamakan.Frm;

public class get_addto_dResult
{
	private int _ID;

	private string _naw_mahafaza;

	private string _malband;

	private string _cood_tasjil;

	private string _naw_tasjil;

	private string _cood_bnka;

	private string _naw_bnka;

	private string _westga_gshty;

	private string _dangdar;

	private string _westga;

	private string _waraqa_rast;

	private string _waraqapochal;

	private string _naw_karmand;

	private string _taime;

	private string _shwen;

	private int? _hazbid_1;

	private int? _hazbid_2;

	private int? _hazbid_3;

	private int? _hazbid_4;

	private int? _hazbid_5;

	private int? _hazbid_6;

	private int? _hazbid_7;

	private int? _hazbid_8;

	private int? _hazbid_9;

	private int? _hazbid_10;

	private int? _hazbid_11;

	private int? _hazbid_12;

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

	[Column(Storage = "_naw_mahafaza", DbType = "NVarChar(255)")]
	public string naw_mahafaza
	{
		get
		{
			return _naw_mahafaza;
		}
		set
		{
			if (_naw_mahafaza != value)
			{
				_naw_mahafaza = value;
			}
		}
	}

	[Column(Storage = "_malband", DbType = "NVarChar(255)")]
	public string malband
	{
		get
		{
			return _malband;
		}
		set
		{
			if (_malband != value)
			{
				_malband = value;
			}
		}
	}

	[Column(Storage = "_cood_tasjil", DbType = "NVarChar(255)")]
	public string cood_tasjil
	{
		get
		{
			return _cood_tasjil;
		}
		set
		{
			if (_cood_tasjil != value)
			{
				_cood_tasjil = value;
			}
		}
	}

	[Column(Storage = "_naw_tasjil", DbType = "NVarChar(255)")]
	public string naw_tasjil
	{
		get
		{
			return _naw_tasjil;
		}
		set
		{
			if (_naw_tasjil != value)
			{
				_naw_tasjil = value;
			}
		}
	}

	[Column(Storage = "_cood_bnka", DbType = "NVarChar(255)")]
	public string cood_bnka
	{
		get
		{
			return _cood_bnka;
		}
		set
		{
			if (_cood_bnka != value)
			{
				_cood_bnka = value;
			}
		}
	}

	[Column(Storage = "_naw_bnka", DbType = "NVarChar(255)")]
	public string naw_bnka
	{
		get
		{
			return _naw_bnka;
		}
		set
		{
			if (_naw_bnka != value)
			{
				_naw_bnka = value;
			}
		}
	}

	[Column(Storage = "_westga_gshty", DbType = "NVarChar(255)")]
	public string westga_gshty
	{
		get
		{
			return _westga_gshty;
		}
		set
		{
			if (_westga_gshty != value)
			{
				_westga_gshty = value;
			}
		}
	}

	[Column(Storage = "_dangdar", DbType = "NVarChar(255)")]
	public string dangdar
	{
		get
		{
			return _dangdar;
		}
		set
		{
			if (_dangdar != value)
			{
				_dangdar = value;
			}
		}
	}

	[Column(Storage = "_westga", DbType = "NVarChar(255)")]
	public string westga
	{
		get
		{
			return _westga;
		}
		set
		{
			if (_westga != value)
			{
				_westga = value;
			}
		}
	}

	[Column(Storage = "_waraqa_rast", DbType = "NVarChar(255)")]
	public string waraqa_rast
	{
		get
		{
			return _waraqa_rast;
		}
		set
		{
			if (_waraqa_rast != value)
			{
				_waraqa_rast = value;
			}
		}
	}

	[Column(Storage = "_waraqapochal", DbType = "NVarChar(255)")]
	public string waraqapochal
	{
		get
		{
			return _waraqapochal;
		}
		set
		{
			if (_waraqapochal != value)
			{
				_waraqapochal = value;
			}
		}
	}

	[Column(Storage = "_naw_karmand", DbType = "NVarChar(255)")]
	public string naw_karmand
	{
		get
		{
			return _naw_karmand;
		}
		set
		{
			if (_naw_karmand != value)
			{
				_naw_karmand = value;
			}
		}
	}

	[Column(Storage = "_taime", DbType = "NVarChar(255)")]
	public string taime
	{
		get
		{
			return _taime;
		}
		set
		{
			if (_taime != value)
			{
				_taime = value;
			}
		}
	}

	[Column(Storage = "_shwen", DbType = "NVarChar(255)")]
	public string shwen
	{
		get
		{
			return _shwen;
		}
		set
		{
			if (_shwen != value)
			{
				_shwen = value;
			}
		}
	}

	[Column(Storage = "_hazbid_1", DbType = "Int")]
	public int? hazbid_1
	{
		get
		{
			return _hazbid_1;
		}
		set
		{
			if (_hazbid_1 != value)
			{
				_hazbid_1 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_2", DbType = "Int")]
	public int? hazbid_2
	{
		get
		{
			return _hazbid_2;
		}
		set
		{
			if (_hazbid_2 != value)
			{
				_hazbid_2 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_3", DbType = "Int")]
	public int? hazbid_3
	{
		get
		{
			return _hazbid_3;
		}
		set
		{
			if (_hazbid_3 != value)
			{
				_hazbid_3 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_4", DbType = "Int")]
	public int? hazbid_4
	{
		get
		{
			return _hazbid_4;
		}
		set
		{
			if (_hazbid_4 != value)
			{
				_hazbid_4 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_5", DbType = "Int")]
	public int? hazbid_5
	{
		get
		{
			return _hazbid_5;
		}
		set
		{
			if (_hazbid_5 != value)
			{
				_hazbid_5 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_6", DbType = "Int")]
	public int? hazbid_6
	{
		get
		{
			return _hazbid_6;
		}
		set
		{
			if (_hazbid_6 != value)
			{
				_hazbid_6 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_7", DbType = "Int")]
	public int? hazbid_7
	{
		get
		{
			return _hazbid_7;
		}
		set
		{
			if (_hazbid_7 != value)
			{
				_hazbid_7 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_8", DbType = "Int")]
	public int? hazbid_8
	{
		get
		{
			return _hazbid_8;
		}
		set
		{
			if (_hazbid_8 != value)
			{
				_hazbid_8 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_9", DbType = "Int")]
	public int? hazbid_9
	{
		get
		{
			return _hazbid_9;
		}
		set
		{
			if (_hazbid_9 != value)
			{
				_hazbid_9 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_10", DbType = "Int")]
	public int? hazbid_10
	{
		get
		{
			return _hazbid_10;
		}
		set
		{
			if (_hazbid_10 != value)
			{
				_hazbid_10 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_11", DbType = "Int")]
	public int? hazbid_11
	{
		get
		{
			return _hazbid_11;
		}
		set
		{
			if (_hazbid_11 != value)
			{
				_hazbid_11 = value;
			}
		}
	}

	[Column(Storage = "_hazbid_12", DbType = "Int")]
	public int? hazbid_12
	{
		get
		{
			return _hazbid_12;
		}
		set
		{
			if (_hazbid_12 != value)
			{
				_hazbid_12 = value;
			}
		}
	}
}
