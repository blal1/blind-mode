using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D04")]
public abstract class MDMarkupTableCellBase : ElementWidgetBase, IMDMarkupTableCell
{
	[Token(Token = "0x4009D2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LayoutElement layoutElementCache;

	[Token(Token = "0x4009D2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LayoutElementRectReferer layoutElementRectRefererCache;

	[Token(Token = "0x17000B1D")]
	private LayoutElement layoutElement
	{
		[Token(Token = "0x6004E89")]
		[Address(RVA = "0x95A240", Offset = "0x959440", VA = "0x18095A240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B1E")]
	private LayoutElementRectReferer layoutElementRectReferer
	{
		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x95A1A0", Offset = "0x9593A0", VA = "0x18095A1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B1F")]
	private ElementObjectManager YgomGame_002EMDMarkup_002EIMDMarkupTableCell_002Eeom
	{
		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B20")]
	public bool borderVisible
	{
		[Token(Token = "0x6004E8D")]
		[Address(RVA = "0x95A140", Offset = "0x959340", VA = "0x18095A140", Slot = "12")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0x95A2D0", Offset = "0x9594D0", VA = "0x18095A2D0", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x6004E8C")]
	[Address(RVA = "0x8847B0", Offset = "0x8839B0", VA = "0x1808847B0")]
	public MDMarkupTableCellBase(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004E8F")]
	[Address(RVA = "0x959EB0", Offset = "0x9590B0", VA = "0x180959EB0", Slot = "16")]
	public virtual void SetAlignment(TextAlignmentOptions alignment)
	{
	}

	[Token(Token = "0x6004E90")]
	[Address(RVA = "0x959FB0", Offset = "0x9591B0", VA = "0x180959FB0", Slot = "15")]
	public void SetSizeRate(float sizeRate, [Optional] RectTransform sourceRect)
	{
	}
}
