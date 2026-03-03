using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000160")]
[UxmlElement(null, new Type[] { typeof(Button) })]
public class ToggleButtonGroup : BaseField<ToggleButtonGroupState>
{
	[Token(Token = "0x2000161")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<ToggleButtonGroup, UxmlTraits>
	{
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x2B0BE00", Offset = "0x2B0B000", VA = "0x182B0BE00")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000162")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<ToggleButtonGroupState>.UxmlTraits
	{
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x98")]
		private UxmlBoolAttributeDescription m_IsMultipleSelection;

		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlBoolAttributeDescription m_AllowEmptySelection;

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x2B0C460", Offset = "0x2B0B660", VA = "0x182B0C460", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x2B0CA60", Offset = "0x2B0BC60", VA = "0x182B0CA60")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string k_MaxToggleButtonGroupMessage;

	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly BindingId isMultipleSelectionProperty;

	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0xA0")]
	internal static readonly BindingId allowEmptySelectionProperty;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x138")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x140")]
	public static readonly string containerUssClassName;

	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x148")]
	public static readonly string buttonGroupClassName;

	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x150")]
	public static readonly string buttonClassName;

	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x158")]
	public static readonly string buttonLeftClassName;

	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x160")]
	public static readonly string buttonMidClassName;

	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x168")]
	public static readonly string buttonRightClassName;

	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x170")]
	public static readonly string buttonStandaloneClassName;

	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x178")]
	public static readonly string emptyStateLabelClassName;

	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x540")]
	private VisualElement m_ButtonGroupContainer;

	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x548")]
	private List<Button> m_Buttons;

	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x550")]
	private VisualElement m_EmptyLabel;

	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x558")]
	private bool m_IsMultipleSelection;

	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x559")]
	private bool m_AllowEmptySelection;

	[Token(Token = "0x170001CE")]
	[CreateProperty]
	public bool isMultipleSelection
	{
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x2B02D80", Offset = "0x2B01F80", VA = "0x182B02D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2B02FF0", Offset = "0x2B021F0", VA = "0x182B02FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170001CF")]
	[CreateProperty]
	public bool allowEmptySelection
	{
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x2B02D70", Offset = "0x2B01F70", VA = "0x182B02D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x2B02D90", Offset = "0x2B01F90", VA = "0x182B02D90")]
		set
		{
		}
	}

	[Token(Token = "0x170001D0")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x2ADEC50", Offset = "0x2ADDE50", VA = "0x182ADEC50", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x2B029B0", Offset = "0x2B01BB0", VA = "0x182B029B0")]
	public ToggleButtonGroup()
	{
	}

	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x2B029F0", Offset = "0x2B01BF0", VA = "0x182B029F0")]
	public ToggleButtonGroup(string label)
	{
	}

	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x2B02A30", Offset = "0x2B01C30", VA = "0x182B02A30")]
	public ToggleButtonGroup(string label, ToggleButtonGroupState toggleButtonGroupState)
	{
	}

	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x2B01B50", Offset = "0x2B00D50", VA = "0x182B01B50", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x2B02280", Offset = "0x2B01480", VA = "0x182B02280", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}

	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x2B01BC0", Offset = "0x2B00DC0", VA = "0x182B01BC0", Slot = "155")]
	public override void SetValueWithoutNotify(ToggleButtonGroupState newValue)
	{
	}

	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x2B00FE0", Offset = "0x2B001E0", VA = "0x182B00FE0")]
	private void OnButtonGroupContainerElementAdded(VisualElement ve, int index)
	{
	}

	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x2B01420", Offset = "0x2B00620", VA = "0x182B01420")]
	private void OnButtonGroupContainerElementRemoved(VisualElement ve)
	{
	}

	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x2B01D90", Offset = "0x2B00F90", VA = "0x182B01D90")]
	private void UpdateButtonStates(ToggleButtonGroupState options)
	{
	}

	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x2B01840", Offset = "0x2B00A40", VA = "0x182B01840")]
	private void OnOptionChange(EventBase evt)
	{
	}

	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x2B020B0", Offset = "0x2B012B0", VA = "0x182B020B0")]
	private void UpdateButtonsStyling()
	{
	}
}
