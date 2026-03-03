using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x200012B")]
public struct LogDataCenterForAnalysis
{
	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private int dataint0;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	private int dataint1;

	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private byte boolbits;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x9")]
	[SerializeField]
	private byte databyte0;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0xA")]
	[SerializeField]
	private byte databyte1;

	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0xB")]
	[SerializeField]
	private byte datatype;

	[Token(Token = "0x170000C2")]
	private bool show
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x9D59B0", Offset = "0x9D4BB0", VA = "0x1809D59B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C3")]
	public bool isActDataShow
	{
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x9D5930", Offset = "0x9D4B30", VA = "0x1809D5930")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C4")]
	public bool isIndent
	{
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x9D5970", Offset = "0x9D4B70", VA = "0x1809D5970")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C5")]
	public bool team
	{
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x9D59C0", Offset = "0x9D4BC0", VA = "0x1809D59C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C6")]
	public bool extendinfo
	{
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x9D5920", Offset = "0x9D4B20", VA = "0x1809D5920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C7")]
	public LOGACTIONTYPE acttype
	{
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x9D58A0", Offset = "0x9D4AA0", VA = "0x1809D58A0")]
		get
		{
			return default(LOGACTIONTYPE);
		}
	}

	[Token(Token = "0x170000C8")]
	public int efxbegin
	{
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000C9")]
	public int efxend
	{
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x9D5910", Offset = "0x9D4B10", VA = "0x1809D5910")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000CA")]
	public bool isLPCDataShow
	{
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x9D5980", Offset = "0x9D4B80", VA = "0x1809D5980")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CB")]
	public int changevalue
	{
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000CC")]
	public int restLP
	{
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000CD")]
	public Engine.DamageType lpctype
	{
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x9D5990", Offset = "0x9D4B90", VA = "0x1809D5990")]
		get
		{
			return default(Engine.DamageType);
		}
	}

	[Token(Token = "0x170000CE")]
	public bool isCCDataShow
	{
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x9D5940", Offset = "0x9D4B40", VA = "0x1809D5940")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CF")]
	public int numpre
	{
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000D0")]
	public int numaft
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000D1")]
	public Engine.CounterType countertype
	{
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x9D58B0", Offset = "0x9D4AB0", VA = "0x1809D58B0")]
		get
		{
			return default(Engine.CounterType);
		}
	}

	[Token(Token = "0x170000D2")]
	public bool isDiceDataShow
	{
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x9D5960", Offset = "0x9D4B60", VA = "0x1809D5960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000D3")]
	public bool isCoinDataShow
	{
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x9D5950", Offset = "0x9D4B50", VA = "0x1809D5950")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x9D5720", Offset = "0x9D4920", VA = "0x1809D5720")]
	public LogDataCenterForAnalysis(LogDataCenter logDataCenter)
	{
	}

	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x9D5860", Offset = "0x9D4A60", VA = "0x1809D5860")]
	public LogDataCenterForAnalysis(bool show, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
	{
	}

	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x9D5810", Offset = "0x9D4A10", VA = "0x1809D5810")]
	public LogDataCenterForAnalysis(bool show, int efxbegin, int efxend, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
	{
	}

	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x9D57D0", Offset = "0x9D49D0", VA = "0x1809D57D0")]
	public LogDataCenterForAnalysis(bool show, int changevalue, int restLP, Engine.DamageType lpctype, bool isIndent, bool team)
	{
	}

	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x9D5750", Offset = "0x9D4950", VA = "0x1809D5750")]
	public LogDataCenterForAnalysis(bool show, int numpre, int numaft, int countertype, bool isIndent, bool team)
	{
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x9D5790", Offset = "0x9D4990", VA = "0x1809D5790")]
	public LogDataCenterForAnalysis(int coincount, int resultbits)
	{
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x9D57B0", Offset = "0x9D49B0", VA = "0x1809D57B0")]
	public LogDataCenterForAnalysis(int dicenum, bool team)
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x9D5360", Offset = "0x9D4560", VA = "0x1809D5360")]
	public void AddEfxNoInfo(int efxbegin, int efxend)
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x9D5370", Offset = "0x9D4570", VA = "0x1809D5370")]
	public (LOGACTIONTYPE, bool) GetActionData()
	{
		return default((LOGACTIONTYPE, bool));
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x9D5670", Offset = "0x9D4870", VA = "0x1809D5670")]
	public (int, int, Engine.DamageType, bool) GetLPChangeData()
	{
		return default((int, int, Engine.DamageType, bool));
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x9D5540", Offset = "0x9D4740", VA = "0x1809D5540")]
	public (int, int, Engine.CounterType, bool) GetCounterChangeData()
	{
		return default((int, int, Engine.CounterType, bool));
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x9D5710", Offset = "0x9D4910", VA = "0x1809D5710")]
	public void SetBmgVisible()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x9D5610", Offset = "0x9D4810", VA = "0x1809D5610")]
	public (bool, int) GetDiceData()
	{
		return default((bool, int));
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x9D53E0", Offset = "0x9D45E0", VA = "0x1809D53E0")]
	public (bool, List<bool>) GetCoinResults()
	{
		return default((bool, List<bool>));
	}
}
