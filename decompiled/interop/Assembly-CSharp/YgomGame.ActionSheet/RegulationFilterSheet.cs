using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.ActionSheet;

[Token(Token = "0x2000C2D")]
public class RegulationFilterSheet
{
	[Token(Token = "0x4009A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> m_RegulationIds;

	[Token(Token = "0x4009A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<FilterSelectViewController.EntryData> m_Entrys;

	[Token(Token = "0x17000A20")]
	public List<int> regulationIds
	{
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A21")]
	public List<FilterSelectViewController.EntryData> regulationNames
	{
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A6E")]
	[Address(RVA = "0x945820", Offset = "0x944A20", VA = "0x180945820")]
	public int GetRegulationID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6004A6F")]
	[Address(RVA = "0x945AB0", Offset = "0x944CB0", VA = "0x180945AB0")]
	public void SetInPeriodTournaments([Optional] List<int> selectedRegulationList, [Optional] Dictionary<string, object> ruleInfo)
	{
	}

	[Token(Token = "0x6004A70")]
	[Address(RVA = "0x945950", Offset = "0x944B50", VA = "0x180945950")]
	public void Open([Optional] Action<List<int>, List<string>> callback)
	{
	}

	[Token(Token = "0x6004A71")]
	[Address(RVA = "0x9456D0", Offset = "0x9448D0", VA = "0x1809456D0")]
	public (int, string) GetFirstRegulationInfo()
	{
		return default((int, string));
	}

	[Token(Token = "0x6004A72")]
	[Address(RVA = "0x945790", Offset = "0x944990", VA = "0x180945790")]
	public string GetRegLabel(int regId)
	{
		return null;
	}

	[Token(Token = "0x6004A73")]
	[Address(RVA = "0x945880", Offset = "0x944A80", VA = "0x180945880")]
	private bool GetTextGroup(string fullTextId, out string groupId)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A74")]
	[Address(RVA = "0x945FD0", Offset = "0x9451D0", VA = "0x180945FD0")]
	public RegulationFilterSheet()
	{
	}
}
