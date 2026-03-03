using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001181")]
public class SortDialogViewController_CardFile : SortDialogBase<SortComparer.Sorter>
{
	[Token(Token = "0x400B7A9")]
	private const string PREFAB_PATH_SORTDIALOG = "Common/SortDialog/SortDialog_CardFile";

	[Token(Token = "0x400B7AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<SortComparer.METHOD, string> methodTabLabel;

	[Token(Token = "0x400B7AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<SortComparer.METHOD> unorderedMethod;

	[Token(Token = "0x1700114D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0xB65BB0", Offset = "0xB64DB0", VA = "0x180B65BB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006DD6")]
	[Address(RVA = "0xB65840", Offset = "0xB64A40", VA = "0x180B65840")]
	public static void Open(SortComparer.METHOD method, SortComparer.ORDER order, [Optional] Action<SortComparer.Sorter> callback)
	{
	}

	[Token(Token = "0x6006DD7")]
	[Address(RVA = "0xB65740", Offset = "0xB64940", VA = "0x180B65740", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006DD8")]
	[Address(RVA = "0xB64E00", Offset = "0xB64000", VA = "0x180B64E00")]
	public static string GetSorterName(SortComparer.Sorter s)
	{
		return null;
	}

	[Token(Token = "0x6006DD9")]
	[Address(RVA = "0xB64FE0", Offset = "0xB641E0", VA = "0x180B64FE0", Slot = "31")]
	protected override List<string> InitializeMethodLabelList()
	{
		return null;
	}

	[Token(Token = "0x6006DDA")]
	[Address(RVA = "0xB65760", Offset = "0xB64960", VA = "0x180B65760", Slot = "33")]
	protected override void OnClickAscCallback(string label)
	{
	}

	[Token(Token = "0x6006DDB")]
	[Address(RVA = "0xB657D0", Offset = "0xB649D0", VA = "0x180B657D0", Slot = "34")]
	protected override void OnClickDescCallback(string label)
	{
	}

	[Token(Token = "0x6006DDC")]
	[Address(RVA = "0xB65200", Offset = "0xB64400", VA = "0x180B65200", Slot = "35")]
	protected override bool IsAscOn(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DDD")]
	[Address(RVA = "0xB653A0", Offset = "0xB645A0", VA = "0x180B653A0", Slot = "36")]
	protected override bool IsDescOn(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DDE")]
	[Address(RVA = "0xB64F20", Offset = "0xB64120", VA = "0x180B64F20", Slot = "32")]
	protected override string GetText(string label)
	{
		return null;
	}

	[Token(Token = "0x6006DDF")]
	[Address(RVA = "0xB64C60", Offset = "0xB63E60", VA = "0x180B64C60")]
	private SortComparer.METHOD GetMethodFromLabel(string label)
	{
		return default(SortComparer.METHOD);
	}

	[Token(Token = "0x6006DE0")]
	[Address(RVA = "0xB64F80", Offset = "0xB64180", VA = "0x180B64F80", Slot = "37")]
	protected override string GetTitle()
	{
		return null;
	}

	[Token(Token = "0x6006DE1")]
	[Address(RVA = "0xB65540", Offset = "0xB64740", VA = "0x180B65540", Slot = "38")]
	protected override bool IsUnorderedMethod(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DE2")]
	[Address(RVA = "0xB65B70", Offset = "0xB64D70", VA = "0x180B65B70")]
	public SortDialogViewController_CardFile()
	{
	}
}
