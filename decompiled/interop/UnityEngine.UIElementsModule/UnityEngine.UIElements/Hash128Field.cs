using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000D5")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Hash128Field : TextInputBaseField<Hash128>
{
	[Token(Token = "0x20000D6")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Hash128Field, UxmlTraits>
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2AD8C50", Offset = "0x2AD7E50", VA = "0x182AD8C50")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000D7")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
	{
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2AD9AF0", Offset = "0x2AD8CF0", VA = "0x182AD9AF0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000D8")]
	private class Hash128Input : TextInputBase
	{
		[Token(Token = "0x170000F4")]
		protected string allowedCharacters
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x2AC7F20", Offset = "0x2AC7120", VA = "0x182AC7F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2AC7DC0", Offset = "0x2AC6FC0", VA = "0x182AC7DC0")]
		internal Hash128Input()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2AC7C70", Offset = "0x2AC6E70", VA = "0x182AC7C70", Slot = "138")]
		internal override bool AcceptCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2AC7520", Offset = "0x2AC6720", VA = "0x182AC7520", Slot = "137")]
		protected override Hash128 StringToValue(string str)
		{
			return default(Hash128);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2AC7D20", Offset = "0x2AC6F20", VA = "0x182AC7D20")]
		internal static Hash128 Parse(string str)
		{
			return default(Hash128);
		}
	}

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170000F3")]
	public override Hash128 value
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2AC7B50", Offset = "0x2AC6D50", VA = "0x182AC7B50", Slot = "144")]
		get
		{
			return default(Hash128);
		}
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x2AC7BB0", Offset = "0x2AC6DB0", VA = "0x182AC7BB0", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x2AC7B40", Offset = "0x2AC6D40", VA = "0x182AC7B40")]
	public Hash128Field()
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x2AC7860", Offset = "0x2AC6A60", VA = "0x182AC7860")]
	public Hash128Field(string label, int maxLength = -1)
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x2AC7650", Offset = "0x2AC6850", VA = "0x182AC7650", Slot = "159")]
	internal override void UpdateValueFromText()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x2AC75C0", Offset = "0x2AC67C0", VA = "0x182AC75C0", Slot = "160")]
	internal override void UpdateTextFromValue()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x2AC7460", Offset = "0x2AC6660", VA = "0x182AC7460", Slot = "155")]
	public override void SetValueWithoutNotify(Hash128 newValue)
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x2AC7720", Offset = "0x2AC6920", VA = "0x182AC7720", Slot = "157")]
	protected override string ValueToString(Hash128 value)
	{
		return null;
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x2AC7520", Offset = "0x2AC6720", VA = "0x182AC7520", Slot = "158")]
	protected override Hash128 StringToValue(string str)
	{
		return default(Hash128);
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x2AC72E0", Offset = "0x2AC64E0", VA = "0x182AC72E0", Slot = "8")]
	[EventInterest(new Type[] { typeof(FocusOutEvent) })]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}
}
