using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E9")]
public class TextField : TextInputBaseField<string>
{
	[Token(Token = "0x20000EA")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
	{
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2AD8A10", Offset = "0x2AD7C10", VA = "0x182AD8A10")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : TextInputBaseField<string>.UxmlTraits
	{
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UxmlStringAttributeDescription k_Value;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x120")]
		private UxmlBoolAttributeDescription m_Multiline;

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2AD9240", Offset = "0x2AD8440", VA = "0x182AD9240", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2AD9990", Offset = "0x2AD8B90", VA = "0x182AD9990")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000EC")]
	private class TextInput : TextInputBase
	{
		[Token(Token = "0x17000110")]
		private TextField parentTextField
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2AD6F30", Offset = "0x2AD6130", VA = "0x182AD6F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		public bool multiline
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2AD6EC0", Offset = "0x2AD60C0", VA = "0x182AD6EC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2AD6FB0", Offset = "0x2AD61B0", VA = "0x182AD6FB0")]
			set
			{
			}
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "137")]
		protected override string StringToValue(string str)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2AD6E60", Offset = "0x2AD6060", VA = "0x182AD6E60")]
		public TextInput()
		{
		}
	}

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId multilineProperty;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x98")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0xA0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0xA8")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x1700010D")]
	private TextInput textInput
	{
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2AD6B70", Offset = "0x2AD5D70", VA = "0x182AD6B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010E")]
	[CreateProperty]
	public bool multiline
	{
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2AD6B00", Offset = "0x2AD5D00", VA = "0x182AD6B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2AD6C30", Offset = "0x2AD5E30", VA = "0x182AD6C30")]
		set
		{
		}
	}

	[Token(Token = "0x1700010F")]
	public override string value
	{
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2AD6BF0", Offset = "0x2AD5DF0", VA = "0x182AD6BF0", Slot = "144")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2AD6DB0", Offset = "0x2AD5FB0", VA = "0x182AD6DB0", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x2AD6AD0", Offset = "0x2AD5CD0", VA = "0x182AD6AD0")]
	public TextField()
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x2AD6AA0", Offset = "0x2AD5CA0", VA = "0x182AD6AA0")]
	public TextField(string label)
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x2AD6840", Offset = "0x2AD5A40", VA = "0x182AD6840")]
	public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar)
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x2AD6420", Offset = "0x2AD5620", VA = "0x182AD6420", Slot = "155")]
	public override void SetValueWithoutNotify(string newValue)
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x2AD65B0", Offset = "0x2AD57B0", VA = "0x182AD65B0", Slot = "160")]
	internal override void UpdateTextFromValue()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x2AD6190", Offset = "0x2AD5390", VA = "0x182AD6190", Slot = "8")]
	[EventInterest(new Type[] { typeof(FocusOutEvent) })]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x2AD6390", Offset = "0x2AD5590", VA = "0x182AD6390", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "157")]
	protected override string ValueToString(string value)
	{
		return null;
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x52F690", Offset = "0x52E890", VA = "0x18052F690", Slot = "158")]
	protected override string StringToValue(string str)
	{
		return null;
	}
}
