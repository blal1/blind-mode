using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Deck;

namespace YgomGame.Utility;

[Token(Token = "0x20008F8")]
public class FilterDialogManager
{
	[Token(Token = "0x40088FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private SearchFilter.Setting m_Setting;

	[Token(Token = "0x40088FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SearchFilter.Setting m_DefaultSetting;

	[Token(Token = "0x40088FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<FilterDialog.FilterGroupType> m_FilterGroupTypes;

	[Token(Token = "0x4008900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private FilterDialog.OptionMask m_OptionMask;

	[Token(Token = "0x4008901")]
	private const int sliderQ = -100;

	[Token(Token = "0x4008902")]
	private const int monsterValMax = 5000;

	[Token(Token = "0x60035C2")]
	[Address(RVA = "0x7BBC00", Offset = "0x7BAE00", VA = "0x1807BBC00")]
	public FilterDialogManager()
	{
	}

	[Token(Token = "0x60035C3")]
	[Address(RVA = "0x7BB560", Offset = "0x7BA760", VA = "0x1807BB560")]
	public bool IsFiltered()
	{
		return default(bool);
	}

	[Token(Token = "0x60035C4")]
	[Address(RVA = "0x7BAFE0", Offset = "0x7BA1E0", VA = "0x1807BAFE0")]
	private bool CheckDiff(BitArray ba1, BitArray ba2)
	{
		return default(bool);
	}

	[Token(Token = "0x60035C5")]
	[Address(RVA = "0x7BC1F0", Offset = "0x7BB3F0", VA = "0x1807BC1F0")]
	private static bool checkAny(BitArray ba)
	{
		return default(bool);
	}

	[Token(Token = "0x60035C6")]
	[Address(RVA = "0x7BC420", Offset = "0x7BB620", VA = "0x1807BC420")]
	private static bool checkValue(int[] array)
	{
		return default(bool);
	}

	[Token(Token = "0x60035C7")]
	[Address(RVA = "0x7BBA10", Offset = "0x7BAC10", VA = "0x1807BBA10")]
	public void OpenFilterDialog(int regID = -1, [Optional] Action resultCallback)
	{
	}

	[Token(Token = "0x60035C8")]
	[Address(RVA = "0x7BB0B0", Offset = "0x7BA2B0", VA = "0x1807BB0B0")]
	private List<CardBaseData> GetCardBaseDataList(List<int> mrks)
	{
		return null;
	}

	[Token(Token = "0x60035C9")]
	[Address(RVA = "0x7BB330", Offset = "0x7BA530", VA = "0x1807BB330")]
	public List<int> GetFilteredList(List<int> mrks)
	{
		return null;
	}

	[Token(Token = "0x60035CA")]
	[Address(RVA = "0x7BBBA0", Offset = "0x7BADA0", VA = "0x1807BBBA0")]
	public void SetDefaultSetting(SearchFilter.Setting setting)
	{
	}

	[Token(Token = "0x60035CB")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetFilterGroupTypes(List<FilterDialog.FilterGroupType> filterGroupTypes)
	{
	}

	[Token(Token = "0x60035CC")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetFilerOptionMask(FilterDialog.OptionMask mask)
	{
	}

	[Token(Token = "0x60035CD")]
	[Address(RVA = "0x7BB070", Offset = "0x7BA270", VA = "0x1807BB070")]
	private void CopyDefaultSetting()
	{
	}

	[Token(Token = "0x60035CE")]
	[Address(RVA = "0x7BB310", Offset = "0x7BA510", VA = "0x1807BB310")]
	public SearchFilter.Setting GetCurrentSetting()
	{
		return null;
	}
}
