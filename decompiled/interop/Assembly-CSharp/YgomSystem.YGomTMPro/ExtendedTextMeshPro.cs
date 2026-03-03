using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.LocalizedFont;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x200022E")]
public class ExtendedTextMeshPro : TextMeshPro, ILocalizedFontOwner
{
	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x790")]
	private TMP_FontAsset m_CachedFontAsset;

	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x798")]
	[SerializeField]
	private LocalizedFontSettingsBase.FontType m_localizedFontType;

	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x79C")]
	[SerializeField]
	private int m_localizedFontMaterialIndex;

	[Token(Token = "0x17000160")]
	public LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0xD379A0", Offset = "0xD36BA0", VA = "0x180D379A0", Slot = "143")]
		get
		{
			return default(LocalizedFontSettingsBase.FontType);
		}
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0xD379C0", Offset = "0xD36BC0", VA = "0x180D379C0", Slot = "144")]
		set
		{
		}
	}

	[Token(Token = "0x17000161")]
	public int localizedFontMaterialIndex
	{
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0xD37990", Offset = "0xD36B90", VA = "0x180D37990", Slot = "145")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0xD379B0", Offset = "0xD36BB0", VA = "0x180D379B0", Slot = "146")]
		set
		{
		}
	}

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0xD377E0", Offset = "0xD369E0", VA = "0x180D377E0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0xD376E0", Offset = "0xD368E0", VA = "0x180D376E0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0xD37930", Offset = "0xD36B30", VA = "0x180D37930")]
	public ExtendedTextMeshPro()
	{
	}
}
