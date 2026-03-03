using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000F8")]
public class ListView : BaseListView
{
	[Token(Token = "0x20000F9")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
	{
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2AD8C10", Offset = "0x2AD7E10", VA = "0x182AD8C10")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000FA")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseListView.UxmlTraits
	{
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x108")]
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2AD8D10", Offset = "0x2AD7F10", VA = "0x182AD8D10", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2AD9A40", Offset = "0x2AD8C40", VA = "0x182AD9A40")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId itemTemplateProperty;

	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId makeItemProperty;

	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId bindItemProperty;

	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId unbindItemProperty;

	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId destroyItemProperty;

	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x6B0")]
	private Func<VisualElement> m_MakeItem;

	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x6B8")]
	private Func<VisualElement> m_TemplateMakeItem;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x6C0")]
	private VisualTreeAsset m_ItemTemplate;

	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x6C8")]
	private Action<VisualElement, int> m_BindItem;

	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x6D0")]
	private Action<VisualElement, int> m_UnbindItem;

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x6D8")]
	private Action<VisualElement> m_DestroyItem;

	[Token(Token = "0x17000138")]
	[CreateProperty]
	public Func<VisualElement> makeItem
	{
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2ACE2C0", Offset = "0x2ACD4C0", VA = "0x182ACE2C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2ACE5B0", Offset = "0x2ACD7B0", VA = "0x182ACE5B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000139")]
	[CreateProperty]
	public VisualTreeAsset itemTemplate
	{
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2ACE2B0", Offset = "0x2ACD4B0", VA = "0x182ACE2B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2ACE430", Offset = "0x2ACD630", VA = "0x182ACE430")]
		set
		{
		}
	}

	[Token(Token = "0x1700013A")]
	[CreateProperty]
	public Action<VisualElement, int> bindItem
	{
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2ACE290", Offset = "0x2ACD490", VA = "0x182ACE290")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2ACE2E0", Offset = "0x2ACD4E0", VA = "0x182ACE2E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700013B")]
	[CreateProperty]
	public Action<VisualElement, int> unbindItem
	{
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2ACE2D0", Offset = "0x2ACD4D0", VA = "0x182ACE2D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2ACE660", Offset = "0x2ACD860", VA = "0x182ACE660")]
		set
		{
		}
	}

	[Token(Token = "0x1700013C")]
	[CreateProperty]
	public Action<VisualElement> destroyItem
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2ACE2A0", Offset = "0x2ACD4A0", VA = "0x182ACE2A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2ACE390", Offset = "0x2ACD590", VA = "0x182ACE390")]
		set
		{
		}
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x2ACDCA0", Offset = "0x2ACCEA0", VA = "0x182ACDCA0")]
	private VisualElement TemplateMakeItem()
	{
		return null;
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x2ACDC30", Offset = "0x2ACCE30", VA = "0x182ACDC30", Slot = "146")]
	internal override bool HasValidDataAndBindings()
	{
		return default(bool);
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x2ACDBE0", Offset = "0x2ACCDE0", VA = "0x182ACDBE0", Slot = "142")]
	protected override CollectionViewController CreateViewController()
	{
		return null;
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x2ACE1C0", Offset = "0x2ACD3C0", VA = "0x182ACE1C0")]
	public ListView()
	{
	}
}
