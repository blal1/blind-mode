using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000BFF")]
public class MissionSelectorHistoryHandler : IMissionSelectorHistoryHandler
{
	[Token(Token = "0x4009978")]
	[FieldOffset(Offset = "0x10")]
	private readonly Func<bool> m_IsSelectedFunc;

	[Token(Token = "0x4009979")]
	[FieldOffset(Offset = "0x18")]
	private readonly Action<Dictionary<string, object>> m_SaveSelectorHistoryCallback;

	[Token(Token = "0x400997A")]
	[FieldOffset(Offset = "0x20")]
	private readonly Func<Dictionary<string, object>, bool> m_TrySelectHistoryFunc;

	[Token(Token = "0x400997B")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<string, object> m_SaveArgs;

	[Token(Token = "0x170009D8")]
	public bool isSelected
	{
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x4FFB70", Offset = "0x4FED70", VA = "0x1804FFB70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004914")]
	[Address(RVA = "0x923830", Offset = "0x922A30", VA = "0x180923830")]
	public MissionSelectorHistoryHandler(Func<bool> isSelectedFunc, Action<Dictionary<string, object>> saveSelectorHistoryCallback, Func<Dictionary<string, object>, bool> trySelectHistoryFunc)
	{
	}

	[Token(Token = "0x6004916")]
	[Address(RVA = "0x923790", Offset = "0x922990", VA = "0x180923790")]
	public void SetSaveArgs(string key, object value)
	{
	}

	[Token(Token = "0x6004917")]
	[Address(RVA = "0x923720", Offset = "0x922920", VA = "0x180923720", Slot = "5")]
	public void SaveSelectorHistory()
	{
	}

	[Token(Token = "0x6004918")]
	[Address(RVA = "0x923800", Offset = "0x922A00", VA = "0x180923800", Slot = "6")]
	public bool TrySelectHistory()
	{
		return default(bool);
	}
}
