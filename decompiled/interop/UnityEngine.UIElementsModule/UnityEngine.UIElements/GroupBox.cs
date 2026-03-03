using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000D2")]
public class GroupBox : BindableElement, IGroupBox
{
	[Token(Token = "0x20000D3")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits>
	{
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2AD8B50", Offset = "0x2AD7D50", VA = "0x182AD8B50")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000D4")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x90")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x2AD9730", Offset = "0x2AD8930", VA = "0x182AD9730", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x2AD9D30", Offset = "0x2AD8F30", VA = "0x182AD9D30")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x98")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0xA0")]
	public static readonly string labelUssClassName;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x4B8")]
	private Label m_TitleLabel;

	[Token(Token = "0x170000F2")]
	[CreateProperty]
	public string text
	{
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2AC70B0", Offset = "0x2AC62B0", VA = "0x182AC70B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2AC70E0", Offset = "0x2AC62E0", VA = "0x182AC70E0")]
		set
		{
		}
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x2AC7030", Offset = "0x2AC6230", VA = "0x182AC7030")]
	public GroupBox()
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x2AC6FA0", Offset = "0x2AC61A0", VA = "0x182AC6FA0")]
	public GroupBox(string text)
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "139")]
	private void UnityEngine_002EUIElements_002EIGroupBox_002EOnOptionAdded(IGroupBoxOption option)
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "140")]
	private void UnityEngine_002EUIElements_002EIGroupBox_002EOnOptionRemoved(IGroupBoxOption option)
	{
	}
}
