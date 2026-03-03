using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E26")]
public class SheetWidget
{
	[Token(Token = "0x400A248")]
	[FieldOffset(Offset = "0x10")]
	public readonly GameObject gameObject;

	[Token(Token = "0x400A249")]
	[FieldOffset(Offset = "0x18")]
	public readonly RectTransform rectTransform;

	[Token(Token = "0x400A24A")]
	[FieldOffset(Offset = "0x20")]
	private readonly SheetWidgetFactory m_SheetWidgetFactory;

	[Token(Token = "0x400A24B")]
	[FieldOffset(Offset = "0x28")]
	public readonly List<ISheetContentWidget> m_ContentWidgets;

	[Token(Token = "0x400A24C")]
	[FieldOffset(Offset = "0x30")]
	public readonly List<ISheetContentCompleteCheckWidget> m_ContentCompleteCheckWidgets;

	[Token(Token = "0x400A24D")]
	[FieldOffset(Offset = "0x38")]
	public readonly SheetSelectionItemMap selectionItemMap;

	[Token(Token = "0x400A24E")]
	[FieldOffset(Offset = "0x40")]
	private int m_LoadingCnt;

	[Token(Token = "0x17000CC9")]
	public bool isReady
	{
		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x9C3520", Offset = "0x9C2720", VA = "0x1809C3520")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000CCA")]
	public bool isMust
	{
		[Token(Token = "0x60055AF")]
		[Address(RVA = "0x9C3510", Offset = "0x9C2710", VA = "0x1809C3510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055B0")]
		[Address(RVA = "0x9C35E0", Offset = "0x9C27E0", VA = "0x1809C35E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000CCB")]
	public bool isInputComplete
	{
		[Token(Token = "0x60055B1")]
		[Address(RVA = "0x9C3500", Offset = "0x9C2700", VA = "0x1809C3500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x9C35D0", Offset = "0x9C27D0", VA = "0x1809C35D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000CCC")]
	public IReadOnlyList<ISheetContentWidget> contentWidgets
	{
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000088")]
	public event Action onChangeComplete
	{
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x9C3460", Offset = "0x9C2660", VA = "0x1809C3460")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x9C3530", Offset = "0x9C2730", VA = "0x1809C3530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60055B6")]
	[Address(RVA = "0x9C32A0", Offset = "0x9C24A0", VA = "0x1809C32A0")]
	public SheetWidget(RectTransform rectTransform, SheetWidgetFactory sheetWidgetFactory)
	{
	}

	[Token(Token = "0x60055B7")]
	[Address(RVA = "0x9C2A80", Offset = "0x9C1C80", VA = "0x1809C2A80")]
	public void SetContext(SheetContext sheetContext)
	{
	}

	[Token(Token = "0x60055B8")]
	[Address(RVA = "0x9C2D70", Offset = "0x9C1F70", VA = "0x1809C2D70")]
	public void SetupSelectionItems(ExtendedScrollRect scrollRect)
	{
	}

	[Token(Token = "0x60055B9")]
	[Address(RVA = "0x9C2930", Offset = "0x9C1B30", VA = "0x1809C2930")]
	private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60055BA")]
	[Address(RVA = "0x9C2770", Offset = "0x9C1970", VA = "0x1809C2770")]
	public void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}

	[Token(Token = "0x60055BB")]
	[Address(RVA = "0x9C2F90", Offset = "0x9C2190", VA = "0x1809C2F90")]
	public bool TrySelectHeadItem(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60055BC")]
	[Address(RVA = "0x9C25E0", Offset = "0x9C17E0", VA = "0x1809C25E0")]
	private void CheckInputComplete()
	{
	}
}
