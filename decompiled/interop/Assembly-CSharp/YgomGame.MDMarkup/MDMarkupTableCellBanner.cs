using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D02")]
public class MDMarkupTableCellBanner : MDMarkupTableCellBase, IMDMarkupAsyncWidget, IMDMarkupLayoutWidget
{
	[Token(Token = "0x4009D28")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelBannerHolder;

	[Token(Token = "0x4009D29")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_BannerHolder;

	[Token(Token = "0x4009D2A")]
	[FieldOffset(Offset = "0x40")]
	private MDMarkupBannerContext m_BannerContext;

	[Token(Token = "0x4009D2B")]
	[FieldOffset(Offset = "0x48")]
	private int m_LoadingCnt;

	[Token(Token = "0x4009D2C")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 m_BannerSize;

	[Token(Token = "0x4009D2D")]
	[FieldOffset(Offset = "0x54")]
	private float m_OverrideHeight;

	[Token(Token = "0x17000B19")]
	public bool isReady
	{
		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x959EA0", Offset = "0x9590A0", VA = "0x180959EA0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004E7E")]
	[Address(RVA = "0x959DC0", Offset = "0x958FC0", VA = "0x180959DC0")]
	public MDMarkupTableCellBanner(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004E7F")]
	[Address(RVA = "0x959C20", Offset = "0x958E20", VA = "0x180959C20")]
	public void SetBanner(MDMarkupBannerContext bannerContext, float overrideHeight)
	{
	}

	[Token(Token = "0x6004E80")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public void OnReady()
	{
	}

	[Token(Token = "0x6004E81")]
	[Address(RVA = "0x959BD0", Offset = "0x958DD0", VA = "0x180959BD0", Slot = "19")]
	public void OnConcreatedLayout()
	{
	}
}
