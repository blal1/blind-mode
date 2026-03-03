using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001180")]
public class SortDialogViewController_Card : SortDialogBase<SortComparer.Sorter>
{
	[Token(Token = "0x400B7A4")]
	private const string PREFAB_PATH_SORTDIALOG = "Common/SortDialog/SortDialog_Card";

	[Token(Token = "0x400B7A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<SortComparer.METHOD, string> methodTabLabel;

	[Token(Token = "0x400B7A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<SortComparer.METHOD> unorderedMethod;

	[Token(Token = "0x400B7A7")]
	private const string k_argKeyMethodList = "MethodList";

	[Token(Token = "0x400B7A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private SortComparer.METHOD[] availableMethods;

	[Token(Token = "0x1700114C")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006DC5")]
		[Address(RVA = "0xB67030", Offset = "0xB66230", VA = "0x180B67030", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006DC6")]
	[Address(RVA = "0xB66BF0", Offset = "0xB65DF0", VA = "0x180B66BF0")]
	public static void Open(SortComparer.METHOD method, SortComparer.ORDER order, [Optional] Action<SortComparer.Sorter> callback)
	{
	}

	[Token(Token = "0x6006DC7")]
	[Address(RVA = "0xB66A70", Offset = "0xB65C70", VA = "0x180B66A70")]
	public static void OpenMethods(SortComparer.METHOD[] methodList, SortComparer.METHOD method, SortComparer.ORDER order, [Optional] Action<SortComparer.Sorter> callback)
	{
	}

	[Token(Token = "0x6006DC8")]
	[Address(RVA = "0xB668A0", Offset = "0xB65AA0", VA = "0x180B668A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006DC9")]
	[Address(RVA = "0xB65E20", Offset = "0xB65020", VA = "0x180B65E20")]
	public static string GetSorterName(SortComparer.Sorter s)
	{
		return null;
	}

	[Token(Token = "0x6006DCA")]
	[Address(RVA = "0xB66000", Offset = "0xB65200", VA = "0x180B66000", Slot = "31")]
	protected override List<string> InitializeMethodLabelList()
	{
		return null;
	}

	[Token(Token = "0x6006DCB")]
	[Address(RVA = "0xB66990", Offset = "0xB65B90", VA = "0x180B66990", Slot = "33")]
	protected override void OnClickAscCallback(string label)
	{
	}

	[Token(Token = "0x6006DCC")]
	[Address(RVA = "0xB66A00", Offset = "0xB65C00", VA = "0x180B66A00", Slot = "34")]
	protected override void OnClickDescCallback(string label)
	{
	}

	[Token(Token = "0x6006DCD")]
	[Address(RVA = "0xB66360", Offset = "0xB65560", VA = "0x180B66360", Slot = "35")]
	protected override bool IsAscOn(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DCE")]
	[Address(RVA = "0xB66500", Offset = "0xB65700", VA = "0x180B66500", Slot = "36")]
	protected override bool IsDescOn(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DCF")]
	[Address(RVA = "0xB65F40", Offset = "0xB65140", VA = "0x180B65F40", Slot = "32")]
	protected override string GetText(string label)
	{
		return null;
	}

	[Token(Token = "0x6006DD0")]
	[Address(RVA = "0xB65C80", Offset = "0xB64E80", VA = "0x180B65C80")]
	private SortComparer.METHOD GetMethodFromLabel(string label)
	{
		return default(SortComparer.METHOD);
	}

	[Token(Token = "0x6006DD1")]
	[Address(RVA = "0xB65FA0", Offset = "0xB651A0", VA = "0x180B65FA0", Slot = "37")]
	protected override string GetTitle()
	{
		return null;
	}

	[Token(Token = "0x6006DD2")]
	[Address(RVA = "0xB666A0", Offset = "0xB658A0", VA = "0x180B666A0", Slot = "38")]
	protected override bool IsUnorderedMethod(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DD3")]
	[Address(RVA = "0xB66FF0", Offset = "0xB661F0", VA = "0x180B66FF0")]
	public SortDialogViewController_Card()
	{
	}
}
