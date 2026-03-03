using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200012E")]
public class RadioButton : BaseBoolField, IGroupBoxOption
{
	[Token(Token = "0x200012F")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
	{
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x2AEF7F0", Offset = "0x2AEE9F0", VA = "0x182AEF7F0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000130")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
	{
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x2AF0A80", Offset = "0x2AEFC80", VA = "0x182AF0A80", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2AF2620", Offset = "0x2AF1820", VA = "0x182AF2620")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x8")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x10")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string checkmarkBackgroundUssClassName;

	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string checkmarkUssClassName;

	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string textUssClassName;

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x560")]
	private VisualElement m_CheckmarkBackground;

	[Token(Token = "0x1700018F")]
	public override bool value
	{
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x2ADF610", Offset = "0x2ADE810", VA = "0x182ADF610", Slot = "144")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x2ADF650", Offset = "0x2ADE850", VA = "0x182ADF650", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0x2ADF310", Offset = "0x2ADE510", VA = "0x182ADF310")]
	public RadioButton()
	{
	}

	[Token(Token = "0x6000945")]
	[Address(RVA = "0x2ADF320", Offset = "0x2ADE520", VA = "0x182ADF320")]
	public RadioButton(string label)
	{
	}

	[Token(Token = "0x6000946")]
	[Address(RVA = "0x2ADEE50", Offset = "0x2ADE050", VA = "0x182ADEE50")]
	private void OnOptionAttachToPanel(AttachToPanelEvent evt)
	{
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0x2ADEEB0", Offset = "0x2ADE0B0", VA = "0x182ADEEB0")]
	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x6000948")]
	[Address(RVA = "0x2ADEDD0", Offset = "0x2ADDFD0", VA = "0x182ADEDD0", Slot = "156")]
	protected override void InitLabel()
	{
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0x2ADEF30", Offset = "0x2ADE130", VA = "0x182ADEF30", Slot = "157")]
	protected override void ToggleValue()
	{
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x2ADEF80", Offset = "0x2ADE180", VA = "0x182ADEF80", Slot = "158")]
	private void UnityEngine_002EUIElements_002EIGroupBoxOption_002ESetSelected(bool selected)
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x2ADEF10", Offset = "0x2ADE110", VA = "0x182ADEF10", Slot = "155")]
	public override void SetValueWithoutNotify(bool newValue)
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0x2ADEFA0", Offset = "0x2ADE1A0", VA = "0x182ADEFA0")]
	private void UpdateCheckmark()
	{
	}

	[Token(Token = "0x600094D")]
	[Address(RVA = "0x2ADF050", Offset = "0x2ADE250", VA = "0x182ADF050", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}
}
