using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D08")]
public class MDMarkupTableCellItem : MDMarkupTableCellBase, IMDMarkupItemWidget, IMDMarkupButtonWidget, IMDMarkupButtonContainWidget
{
	[Token(Token = "0x4009D4E")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x4009D4F")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelRoot;

	[Token(Token = "0x4009D50")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelThumbHolder;

	[Token(Token = "0x4009D51")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_OVGroupLabel_Default;

	[Token(Token = "0x4009D52")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_OVGroupLabel_Structure;

	[Token(Token = "0x4009D53")]
	[FieldOffset(Offset = "0x58")]
	public readonly PlatformOverriderGroup m_OVGroup;

	[Token(Token = "0x4009D54")]
	[FieldOffset(Offset = "0x60")]
	public readonly LayoutElement m_LayoutElement;

	[Token(Token = "0x4009D55")]
	[FieldOffset(Offset = "0x68")]
	public readonly RectTransform m_Root;

	[Token(Token = "0x4009D56")]
	[FieldOffset(Offset = "0x70")]
	public readonly AspectRatioFitter m_AspectRatioFitter;

	[Token(Token = "0x4009D57")]
	[FieldOffset(Offset = "0x78")]
	public readonly GameObject m_ThumbHolder;

	[Token(Token = "0x17000B31")]
	public bool itemIsPeriod
	{
		[Token(Token = "0x6004EC0")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EC1")]
		[Address(RVA = "0x449850", Offset = "0x448A50", VA = "0x180449850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B32")]
	public int itemCategory
	{
		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0x449830", Offset = "0x448A30", VA = "0x180449830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B33")]
	public int itemId
	{
		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0x865350", Offset = "0x864550", VA = "0x180865350", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x8653A0", Offset = "0x8645A0", VA = "0x1808653A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B34")]
	public SelectionButton button
	{
		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6004EC8")]
	[Address(RVA = "0x95BE90", Offset = "0x95B090", VA = "0x18095BE90")]
	public MDMarkupTableCellItem(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004EC9")]
	[Address(RVA = "0x95BC70", Offset = "0x95AE70", VA = "0x18095BC70", Slot = "22")]
	public void OnSetupSelectionItem(IMDMarkupFreeScrollHandler freeScrollHandler)
	{
	}

	[Token(Token = "0x6004ECA")]
	[Address(RVA = "0x95BCD0", Offset = "0x95AED0", VA = "0x18095BCD0")]
	public void SetItem(bool isPeriod, int itemCategory, int itemId, MDMarkupDef.ItemSize itemSize, float overrideHeight = 0f)
	{
	}

	[Token(Token = "0x6004ECB")]
	[Address(RVA = "0x95AC50", Offset = "0x959E50", VA = "0x18095AC50", Slot = "21")]
	public void SetOnClick(UnityAction callback)
	{
	}
}
