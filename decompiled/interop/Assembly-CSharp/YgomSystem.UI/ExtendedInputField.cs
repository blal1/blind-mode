using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.LocalizedFont;

namespace YgomSystem.UI;

[Token(Token = "0x2000531")]
[AddComponentMenu("Ygom/UI/uGUI/Extended InputField")]
public sealed class ExtendedInputField : InputField, ILocalizedFontOwner
{
	[Token(Token = "0x400194B")]
	[FieldOffset(Offset = "0x220")]
	[SerializeField]
	private LocalizedFontSettingsBase.FontType m_localizedFontType;

	[Token(Token = "0x400194C")]
	[FieldOffset(Offset = "0x224")]
	[SerializeField]
	private int m_localizedFontMaterialIndex;

	[Token(Token = "0x400194D")]
	[FieldOffset(Offset = "0x228")]
	private Event m_ProcessingEvent;

	[Token(Token = "0x400194E")]
	[FieldOffset(Offset = "0x230")]
	private int preAnchor;

	[Token(Token = "0x400194F")]
	[FieldOffset(Offset = "0x234")]
	private int preFocus;

	[Token(Token = "0x4001950")]
	[FieldOffset(Offset = "0x238")]
	private string preText;

	[Token(Token = "0x1700036F")]
	public LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x648FB0", Offset = "0x6481B0", VA = "0x180648FB0", Slot = "82")]
		get
		{
			return default(LocalizedFontSettingsBase.FontType);
		}
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x648FD0", Offset = "0x6481D0", VA = "0x180648FD0", Slot = "83")]
		set
		{
		}
	}

	[Token(Token = "0x17000370")]
	public int localizedFontMaterialIndex
	{
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x648FA0", Offset = "0x6481A0", VA = "0x180648FA0", Slot = "84")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x648FC0", Offset = "0x6481C0", VA = "0x180648FC0", Slot = "85")]
		set
		{
		}
	}

	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x648CA0", Offset = "0x647EA0", VA = "0x180648CA0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60021AB")]
	[Address(RVA = "0x648690", Offset = "0x647890", VA = "0x180648690", Slot = "65")]
	public override void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60021AC")]
	[Address(RVA = "0x648F00", Offset = "0x648100", VA = "0x180648F00")]
	public ExtendedInputField()
	{
	}
}
