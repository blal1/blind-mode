using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.LocalizedFont;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x200022F")]
public class ExtendedTextMeshProUGUI : TextMeshProUGUI, ILocalizedFontOwner
{
	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x7C8")]
	private TMP_FontAsset m_CachedFontAsset;

	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x7D0")]
	private bool m_ReadyLocalized;

	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x7D4")]
	[SerializeField]
	private LocalizedFontSettingsBase.FontType m_localizedFontType;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x7D8")]
	[SerializeField]
	private int m_localizedFontMaterialIndex;

	[Token(Token = "0x17000162")]
	public LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0xD376B0", Offset = "0xD368B0", VA = "0x180D376B0", Slot = "143")]
		get
		{
			return default(LocalizedFontSettingsBase.FontType);
		}
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0xD376D0", Offset = "0xD368D0", VA = "0x180D376D0", Slot = "144")]
		set
		{
		}
	}

	[Token(Token = "0x17000163")]
	public int localizedFontMaterialIndex
	{
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0xD376A0", Offset = "0xD368A0", VA = "0x180D376A0", Slot = "145")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0xD376C0", Offset = "0xD368C0", VA = "0x180D376C0", Slot = "146")]
		set
		{
		}
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0xD374F0", Offset = "0xD366F0", VA = "0x180D374F0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0xD37620", Offset = "0xD36820", VA = "0x180D37620", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0xD37390", Offset = "0xD36590", VA = "0x180D37390")]
	public void ApplyLocalize()
	{
	}

	[Token(Token = "0x6000D00")]
	[Address(RVA = "0xD37520", Offset = "0xD36720", VA = "0x180D37520", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000D01")]
	[Address(RVA = "0xD37640", Offset = "0xD36840", VA = "0x180D37640")]
	public ExtendedTextMeshProUGUI()
	{
	}
}
