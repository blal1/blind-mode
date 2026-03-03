using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C6F")]
public class MDMarkupAsset
{
	[Token(Token = "0x4009B1D")]
	[FieldOffset(Offset = "0x10")]
	private IMDMarkupContainer m_Container;

	[Token(Token = "0x4009B1E")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, IMDMarkupId> m_IdMap;

	[Token(Token = "0x4009B1F")]
	[FieldOffset(Offset = "0x20")]
	public bool invalidModify;

	[Token(Token = "0x4009B23")]
	[FieldOffset(Offset = "0x38")]
	private int m_LoadingCnt;

	[Token(Token = "0x4009B24")]
	[FieldOffset(Offset = "0x40")]
	private Action m_OnLoadCompleteCallback;

	[Token(Token = "0x4009B25")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<string, object> args;

	[Token(Token = "0x17000A3D")]
	public int invalidPos
	{
		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A3E")]
	public bool isValidData
	{
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x935720", Offset = "0x934920", VA = "0x180935720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A3F")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A40")]
	public string invalidMessage
	{
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A41")]
	public IMDMarkupContainer container
	{
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B61")]
	[Address(RVA = "0x934800", Offset = "0x933A00", VA = "0x180934800")]
	public static MDMarkupAsset CreateByJson(string json)
	{
		return null;
	}

	[Token(Token = "0x6004B62")]
	[Address(RVA = "0x934790", Offset = "0x933990", VA = "0x180934790")]
	public static MDMarkupAsset CraeteInstanceByContainer(IMDMarkupContainer container)
	{
		return null;
	}

	[Token(Token = "0x6004B63")]
	[Address(RVA = "0x934920", Offset = "0x933B20", VA = "0x180934920")]
	public static MDMarkupAsset CreateInstance(MDMarkupDef.ContainerType containerType)
	{
		return null;
	}

	[Token(Token = "0x6004B64")]
	[Address(RVA = "0x934990", Offset = "0x933B90", VA = "0x180934990")]
	public void ImportJson(string json)
	{
	}

	[Token(Token = "0x6004B65")]
	[Address(RVA = "0x9356B0", Offset = "0x9348B0", VA = "0x1809356B0")]
	public void SetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004B66")]
	[Address(RVA = "0x9350C0", Offset = "0x9342C0", VA = "0x1809350C0")]
	public void Preload(Action onLoadCompleteCallback)
	{
	}

	[Token(Token = "0x6004B67")]
	[Address(RVA = "0x934A70", Offset = "0x933C70", VA = "0x180934A70")]
	private void OnCheckLoadComplete()
	{
	}

	[Token(Token = "0x6004B68")]
	[Address(RVA = "0x935710", Offset = "0x934910", VA = "0x180935710")]
	public MDMarkupAsset()
	{
	}
}
