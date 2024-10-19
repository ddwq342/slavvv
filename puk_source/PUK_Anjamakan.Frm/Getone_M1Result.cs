using System.Data.Linq.Mapping;

namespace PUK_Anjamakan.Frm;

public class Getone_M1Result
{
	private string _naw_mahafaza;

	private int? _malband;

	private int? _cood_tasjil;

	private string _naw_tasjil;

	private int? _cood_bnka;

	private string _naw_bnka;

	private int? _westga;

	private int? _dangdar;

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

	[Column(Storage = "_malband", DbType = "Int")]
	public int? malband
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

	[Column(Storage = "_cood_tasjil", DbType = "Int")]
	public int? cood_tasjil
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

	[Column(Storage = "_cood_bnka", DbType = "Int")]
	public int? cood_bnka
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

	[Column(Storage = "_westga", DbType = "Int")]
	public int? westga
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

	[Column(Storage = "_dangdar", DbType = "Int")]
	public int? dangdar
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
}
