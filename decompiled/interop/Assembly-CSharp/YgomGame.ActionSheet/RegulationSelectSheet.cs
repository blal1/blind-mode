using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.ActionSheet;

[Token(Token = "0x2000C2F")]
public class RegulationSelectSheet
{
	[Token(Token = "0x4009A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> m_RegulationIds;

	[Token(Token = "0x4009A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ActionSheetViewController.EntryData> m_Entrys;

	[Token(Token = "0x17000A22")]
	public List<int> regulationIds
	{
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A23")]
	public List<ActionSheetViewController.EntryData> regulationNames
	{
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A79")]
	[Address(RVA = "0x9461E0", Offset = "0x9453E0", VA = "0x1809461E0")]
	public int GetRegulationID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6004A7A")]
	[Address(RVA = "0x946CE0", Offset = "0x945EE0", VA = "0x180946CE0")]
	public void SetInPeriodTournaments(bool checkBox = false, int defaultReg = 0, [Optional] Dictionary<string, object> ruleInfo)
	{
	}

	[Token(Token = "0x6004A7B")]
	[Address(RVA = "0x946890", Offset = "0x945A90", VA = "0x180946890")]
	public void Open(Action<int, string> callback)
	{
	}

	[Token(Token = "0x6004A7C")]
	[Address(RVA = "0x9469E0", Offset = "0x945BE0", VA = "0x1809469E0")]
	public void Open(int regulationID, Action<int, string> callback)
	{
	}

	[Token(Token = "0x6004A7D")]
	[Address(RVA = "0x946880", Offset = "0x945A80", VA = "0x180946880")]
	public void OpenWithSelected(int selectedRegID, Action<int, string> callback)
	{
	}

	[Token(Token = "0x6004A7E")]
	[Address(RVA = "0x946090", Offset = "0x945290", VA = "0x180946090")]
	public (int, string) GetFirstRegulationInfo()
	{
		return default((int, string));
	}

	[Token(Token = "0x6004A7F")]
	[Address(RVA = "0x946150", Offset = "0x945350", VA = "0x180946150")]
	public string GetRegLabel(int regId)
	{
		return null;
	}

	[Token(Token = "0x6004A80")]
	[Address(RVA = "0x946240", Offset = "0x945440", VA = "0x180946240")]
	private bool GetTextGroup(string fullTextId, out string groupId)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A81")]
	[Address(RVA = "0x946310", Offset = "0x945510", VA = "0x180946310")]
	public void OpenInPeriodTournament(Action<int, string> callback, bool checkBox = false, int defaultReg = 0)
	{
	}

	[Token(Token = "0x6004A82")]
	[Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
	public RegulationSelectSheet()
	{
	}
}
