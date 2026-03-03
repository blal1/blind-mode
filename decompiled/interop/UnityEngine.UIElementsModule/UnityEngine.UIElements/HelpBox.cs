using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000DA")]
public class HelpBox : VisualElement
{
	[Token(Token = "0x20000DB")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits>
	{
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2AD8BD0", Offset = "0x2AD7DD0", VA = "0x182AD8BD0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000DC")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x88")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x90")]
		private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2AD9460", Offset = "0x2AD8660", VA = "0x182AD9460", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2AD9E10", Offset = "0x2AD9010", VA = "0x182AD9E10")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId messageTypeProperty;

	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x130")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x138")]
	public static readonly string labelUssClassName;

	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x140")]
	public static readonly string iconUssClassName;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x148")]
	public static readonly string iconInfoUssClassName;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x150")]
	public static readonly string iconwarningUssClassName;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x158")]
	public static readonly string iconErrorUssClassName;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x4A8")]
	private HelpBoxMessageType m_HelpBoxMessageType;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x4B0")]
	private VisualElement m_Icon;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x4B8")]
	private string m_IconClass;

	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x4C0")]
	private Label m_Label;

	[Token(Token = "0x170000F5")]
	[CreateProperty]
	public string text
	{
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2AC8940", Offset = "0x2AC7B40", VA = "0x182AC8940")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2AC8A00", Offset = "0x2AC7C00", VA = "0x182AC8A00")]
		set
		{
		}
	}

	[Token(Token = "0x170000F6")]
	[CreateProperty]
	public HelpBoxMessageType messageType
	{
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2AC8930", Offset = "0x2AC7B30", VA = "0x182AC8930")]
		get
		{
			return default(HelpBoxMessageType);
		}
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2AC8970", Offset = "0x2AC7B70", VA = "0x182AC8970")]
		set
		{
		}
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x2AC85E0", Offset = "0x2AC77E0", VA = "0x182AC85E0")]
	public HelpBox()
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x2AC8790", Offset = "0x2AC7990", VA = "0x182AC8790")]
	public HelpBox(string text, HelpBoxMessageType messageType)
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x2AC7F50", Offset = "0x2AC7150", VA = "0x182AC7F50")]
	private string GetIconClass(HelpBoxMessageType messageType)
	{
		return null;
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x2AC8030", Offset = "0x2AC7230", VA = "0x182AC8030")]
	private void UpdateIcon(HelpBoxMessageType messageType)
	{
	}
}
