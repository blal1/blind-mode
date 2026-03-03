using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E25")]
public class SheetSelectionItemMap
{
	[Token(Token = "0x400A247")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<object> m_SelectionObjs;

	[Token(Token = "0x17000CC8")]
	public IReadOnlyList<object> selectionItems
	{
		[Token(Token = "0x60055A4")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055A5")]
	[Address(RVA = "0x9C0320", Offset = "0x9BF520", VA = "0x1809C0320")]
	public void AppendItemLine(SelectionItem selectionItems)
	{
	}

	[Token(Token = "0x60055A6")]
	[Address(RVA = "0x9C0270", Offset = "0x9BF470", VA = "0x1809C0270")]
	public void AppendItemLine(List<SelectionItem> selectionItems)
	{
	}

	[Token(Token = "0x60055A7")]
	[Address(RVA = "0x9C01C0", Offset = "0x9BF3C0", VA = "0x1809C01C0")]
	public void AppendItemLine(Selector selector)
	{
	}

	[Token(Token = "0x60055A8")]
	[Address(RVA = "0x9C0950", Offset = "0x9BFB50", VA = "0x1809C0950")]
	public void SetupSelectionItems(ExtendedScrollRect scrollRect)
	{
	}

	[Token(Token = "0x60055A9")]
	[Address(RVA = "0x9C0550", Offset = "0x9BF750", VA = "0x1809C0550")]
	public bool OnInputDir(SelectionItem fromItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60055AA")]
	[Address(RVA = "0x9C0490", Offset = "0x9BF690", VA = "0x1809C0490")]
	private bool OnInputDir(SelectionItem fromItem, Vector2 dir)
	{
		return default(bool);
	}

	[Token(Token = "0x60055AB")]
	[Address(RVA = "0x9C0C00", Offset = "0x9BFE00", VA = "0x1809C0C00")]
	private bool TrySelectDir(int fromIdxX, int fromIdxY, int xSearchDir, int ySearchDir, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60055AC")]
	[Address(RVA = "0x9C0690", Offset = "0x9BF890", VA = "0x1809C0690")]
	private (bool, int, int) SearchIdxInfoByItem(SelectionItem searchItem)
	{
		return default((bool, int, int));
	}

	[Token(Token = "0x60055AD")]
	[Address(RVA = "0x9C0EE0", Offset = "0x9C00E0", VA = "0x1809C0EE0")]
	public SheetSelectionItemMap()
	{
	}
}
