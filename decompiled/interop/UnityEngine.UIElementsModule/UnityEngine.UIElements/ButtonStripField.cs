using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200009C")]
internal class ButtonStripField : BaseField<int>
{
	[Token(Token = "0x200009D")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits>
	{
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x2AB5860", Offset = "0x2AB4A60", VA = "0x182AB5860")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200009E")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<int>.UxmlTraits
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2ABA2A0", Offset = "0x2AB94A0", VA = "0x182ABA2A0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x538")]
	private readonly List<Button> m_Buttons;

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x2AA8F80", Offset = "0x2AA8180", VA = "0x182AA8F80")]
	public ButtonStripField()
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x2AA8E20", Offset = "0x2AA8020", VA = "0x182AA8E20", Slot = "155")]
	public override void SetValueWithoutNotify(int newValue)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x2AA8D20", Offset = "0x2AA7F20", VA = "0x182AA8D20")]
	private void RefreshButtonsState()
	{
	}
}
