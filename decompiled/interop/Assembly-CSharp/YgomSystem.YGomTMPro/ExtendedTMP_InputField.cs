using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.LocalizedFont;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x2000230")]
public sealed class ExtendedTMP_InputField : TMP_InputField, ILocalizedFontOwner
{
	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x2F8")]
	[SerializeField]
	private LocalizedFontSettingsBase.FontType m_localizedFontType;

	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x2FC")]
	[SerializeField]
	private int m_localizedFontMaterialIndex;

	[Token(Token = "0x17000164")]
	public LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x49BD60", Offset = "0x49AF60", VA = "0x18049BD60", Slot = "87")]
		get
		{
			return default(LocalizedFontSettingsBase.FontType);
		}
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x49C470", Offset = "0x49B670", VA = "0x18049C470", Slot = "88")]
		set
		{
		}
	}

	[Token(Token = "0x17000165")]
	public int localizedFontMaterialIndex
	{
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x49BD70", Offset = "0x49AF70", VA = "0x18049BD70", Slot = "89")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x49C480", Offset = "0x49B680", VA = "0x18049C480", Slot = "90")]
		set
		{
		}
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0xD36E70", Offset = "0xD36070", VA = "0x180D36E70", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0xD37330", Offset = "0xD36530", VA = "0x180D37330")]
	public ExtendedTMP_InputField()
	{
	}
}
