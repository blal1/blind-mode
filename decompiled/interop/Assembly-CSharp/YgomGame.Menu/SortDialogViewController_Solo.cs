using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001182")]
public class SortDialogViewController_Solo : SortDialogBase<SoloFilterSortUtil.GateSort>
{
	[Token(Token = "0x2001183")]
	public class SortData
	{
		[Token(Token = "0x400B7B2")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400B7B3")]
		[FieldOffset(Offset = "0x18")]
		public SoloFilterSortUtil.GateSort ascendSort;

		[Token(Token = "0x400B7B4")]
		[FieldOffset(Offset = "0x1C")]
		public SoloFilterSortUtil.GateSort descendSort;

		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0x85BF40", Offset = "0x85B140", VA = "0x18085BF40")]
		public SortData(string label, SoloFilterSortUtil.GateSort ascendSort, SoloFilterSortUtil.GateSort descendSort)
		{
		}
	}

	[Token(Token = "0x400B7AC")]
	private const string PREFAB_PATH_SORTDIALOG = "Common/SortDialog/SortDialog_Solo";

	[Token(Token = "0x400B7AD")]
	private const string ARGS_SORT_DATAS = "ArgsSortDatas";

	[Token(Token = "0x400B7AE")]
	private const string ARGS_CURRENT_SORT = "ArgsKeyCurrentSort";

	[Token(Token = "0x400B7AF")]
	private const string ARGS_TITLE = "ArgsKeyTitle";

	[Token(Token = "0x400B7B0")]
	[FieldOffset(Offset = "0xF8")]
	private SortData[] m_SortDatas;

	[Token(Token = "0x400B7B1")]
	[FieldOffset(Offset = "0x100")]
	private SoloFilterSortUtil.GateSort m_CurrentSort;

	[Token(Token = "0x6006DE4")]
	[Address(RVA = "0xB678B0", Offset = "0xB66AB0", VA = "0x180B678B0")]
	public static void Open(SortData[] sortDatas, Action<SoloFilterSortUtil.GateSort> callback, SoloFilterSortUtil.GateSort currentSort, string title = "")
	{
	}

	[Token(Token = "0x6006DE5")]
	[Address(RVA = "0xB67520", Offset = "0xB66720", VA = "0x180B67520", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006DE6")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "32")]
	protected override string GetText(string label)
	{
		return null;
	}

	[Token(Token = "0x6006DE7")]
	[Address(RVA = "0xB67100", Offset = "0xB66300", VA = "0x180B67100", Slot = "37")]
	protected override string GetTitle()
	{
		return null;
	}

	[Token(Token = "0x6006DE8")]
	[Address(RVA = "0xB671D0", Offset = "0xB663D0", VA = "0x180B671D0", Slot = "31")]
	protected override List<string> InitializeMethodLabelList()
	{
		return null;
	}

	[Token(Token = "0x6006DE9")]
	[Address(RVA = "0xB67300", Offset = "0xB66500", VA = "0x180B67300", Slot = "35")]
	protected override bool IsAscOn(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DEA")]
	[Address(RVA = "0xB67410", Offset = "0xB66610", VA = "0x180B67410", Slot = "36")]
	protected override bool IsDescOn(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DEB")]
	[Address(RVA = "0xB67690", Offset = "0xB66890", VA = "0x180B67690", Slot = "33")]
	protected override void OnClickAscCallback(string label)
	{
	}

	[Token(Token = "0x6006DEC")]
	[Address(RVA = "0xB677A0", Offset = "0xB669A0", VA = "0x180B677A0", Slot = "34")]
	protected override void OnClickDescCallback(string label)
	{
	}

	[Token(Token = "0x6006DED")]
	[Address(RVA = "0xB67A10", Offset = "0xB66C10", VA = "0x180B67A10")]
	public SortDialogViewController_Solo()
	{
	}
}
