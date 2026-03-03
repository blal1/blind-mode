using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000BF")]
public class DropdownField : PopupField<string>
{
	[Token(Token = "0x20000C0")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
	{
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2AB5820", Offset = "0x2AB4A20", VA = "0x182AB5820")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000C1")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<string>.UxmlTraits
	{
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x98")]
		private UxmlIntAttributeDescription m_Index;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlStringAttributeDescription m_Choices;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2AB81E0", Offset = "0x2AB73E0", VA = "0x182AB81E0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x2AB9E10", Offset = "0x2AB9010", VA = "0x182AB9E10")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x2AAB020", Offset = "0x2AAA220", VA = "0x182AAB020")]
	public DropdownField()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x2AAAFB0", Offset = "0x2AAA1B0", VA = "0x182AAAFB0")]
	public DropdownField(string label)
	{
	}
}
