using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200015D")]
public class Toggle : BaseBoolField
{
	[Token(Token = "0x200015E")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Toggle, UxmlTraits>
	{
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2B0BE80", Offset = "0x2B0B080", VA = "0x182B0BE80")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
	{
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2B0BFC0", Offset = "0x2B0B1C0", VA = "0x182B0BFC0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2B0CCC0", Offset = "0x2B0BEC0", VA = "0x182B0CCC0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x18")]
	[Obsolete]
	public static readonly string noTextVariantUssClassName;

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string checkmarkUssClassName;

	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string textUssClassName;

	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string mixedValuesUssClassName;

	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x2B037F0", Offset = "0x2B029F0", VA = "0x182B037F0")]
	public Toggle()
	{
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x2B036B0", Offset = "0x2B028B0", VA = "0x182B036B0")]
	public Toggle(string label)
	{
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x2B031D0", Offset = "0x2B023D0", VA = "0x182B031D0", Slot = "156")]
	protected override void InitLabel()
	{
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x2B03250", Offset = "0x2B02450", VA = "0x182B03250", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}
}
