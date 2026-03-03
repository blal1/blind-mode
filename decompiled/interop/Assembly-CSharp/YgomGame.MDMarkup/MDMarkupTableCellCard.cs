using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D06")]
public class MDMarkupTableCellCard : MDMarkupTableCellBase, IMDMarkupCardWidget, IMDMarkupButtonWidget, IMDMarkupButtonContainWidget
{
	[Token(Token = "0x4009D35")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x4009D36")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelRoot;

	[Token(Token = "0x4009D37")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelImage;

	[Token(Token = "0x4009D38")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelRarityIcon;

	[Token(Token = "0x4009D39")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelLimitIcon;

	[Token(Token = "0x4009D3A")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelLimitFromToGroup;

	[Token(Token = "0x4009D3B")]
	private const string k_OVGLabel_Default = "RarityOff";

	[Token(Token = "0x4009D3C")]
	private const string k_OVGLabel_RarityOn = "RarityOn";

	[Token(Token = "0x4009D3D")]
	[FieldOffset(Offset = "0x60")]
	public readonly LayoutElement m_LayoutElement;

	[Token(Token = "0x4009D3E")]
	[FieldOffset(Offset = "0x68")]
	public readonly RectTransform m_Root;

	[Token(Token = "0x4009D3F")]
	[FieldOffset(Offset = "0x70")]
	public readonly AspectRatioFitter m_AspectRatioFitter;

	[Token(Token = "0x4009D40")]
	[FieldOffset(Offset = "0x78")]
	public readonly RawImage m_CardImage;

	[Token(Token = "0x17000B23")]
	public int cardMrk
	{
		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x5889C0", Offset = "0x587BC0", VA = "0x1805889C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x588B20", Offset = "0x587D20", VA = "0x180588B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B24")]
	public int cardPremire
	{
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x449830", Offset = "0x448A30", VA = "0x180449830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B25")]
	public SelectionButton button
	{
		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B26")]
	public GameObject rarityIcon
	{
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x95B220", Offset = "0x95A420", VA = "0x18095B220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B27")]
	public GameObject limitIcon
	{
		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x95B1F0", Offset = "0x95A3F0", VA = "0x18095B1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B28")]
	public ElementObjectManager limitFromToGroupEom
	{
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x95B1A0", Offset = "0x95A3A0", VA = "0x18095B1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B29")]
	public int overrideRarity
	{
		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x6ABCD0", Offset = "0x6AAED0", VA = "0x1806ABCD0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x6AC1E0", Offset = "0x6AB3E0", VA = "0x1806AC1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B2A")]
	public int overrideLimitState
	{
		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x6ABCC0", Offset = "0x6AAEC0", VA = "0x1806ABCC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x56CBF0", Offset = "0x56BDF0", VA = "0x18056CBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B2B")]
	public int overridePrevLimitState
	{
		[Token(Token = "0x6004EA9")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B2C")]
	public bool showNoneLimitState
	{
		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x4ACC50", Offset = "0x4ABE50", VA = "0x1804ACC50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x95B260", Offset = "0x95A460", VA = "0x18095B260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B2D")]
	public bool showPrevLimitState
	{
		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x95B250", Offset = "0x95A450", VA = "0x18095B250", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x95B270", Offset = "0x95A470", VA = "0x18095B270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B2E")]
	public string cardBottomText
	{
		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004EB0")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6004EB1")]
	[Address(RVA = "0x95AED0", Offset = "0x95A0D0", VA = "0x18095AED0")]
	public MDMarkupTableCellCard(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004EB2")]
	[Address(RVA = "0x95A7F0", Offset = "0x9599F0", VA = "0x18095A7F0", Slot = "27")]
	public void OnSetupSelectionItem(IMDMarkupFreeScrollHandler freeScrollHandler)
	{
	}

	[Token(Token = "0x6004EB3")]
	[Address(RVA = "0x95A850", Offset = "0x959A50", VA = "0x18095A850")]
	public void SetCard(int mrk, int premire, MDMarkupDef.CardSize cardSize, float overrideHeight = 0f)
	{
	}

	[Token(Token = "0x6004EB4")]
	[Address(RVA = "0x95AC80", Offset = "0x959E80", VA = "0x18095AC80")]
	public void SetRarityIcon(int rarityId = -1)
	{
	}

	[Token(Token = "0x6004EB5")]
	[Address(RVA = "0x95AA90", Offset = "0x959C90", VA = "0x18095AA90")]
	public void SetLimitRegIcon(int regId = 0, int limitStatusVal = -1, bool limitNoneVisible = false, bool prevLimitStatusVisible = false, int prevLimitStatusVal = -1)
	{
	}

	[Token(Token = "0x6004EB6")]
	[Address(RVA = "0x95ADB0", Offset = "0x959FB0", VA = "0x18095ADB0")]
	public void SubmitOvGroupLabel()
	{
	}

	[Token(Token = "0x6004EB7")]
	[Address(RVA = "0x95AC50", Offset = "0x959E50", VA = "0x18095AC50", Slot = "26")]
	public void SetOnClick(UnityAction callback)
	{
	}
}
