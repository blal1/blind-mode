using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000164")]
public class TreeView : BaseTreeView
{
	[Token(Token = "0x2000165")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<TreeView, UxmlTraits>
	{
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x2B0BE40", Offset = "0x2B0B040", VA = "0x182B0BE40")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000166")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseTreeView.UxmlTraits
	{
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0xD0")]
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate;

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x2B0C610", Offset = "0x2B0B810", VA = "0x182B0C610", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x2B0CC10", Offset = "0x2B0BE10", VA = "0x182B0CC10")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId itemTemplateProperty;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId makeItemProperty;

	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId bindItemProperty;

	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId unbindItemProperty;

	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId destroyItemProperty;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x5C0")]
	private Func<VisualElement> m_MakeItem;

	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x5C8")]
	private Func<VisualElement> m_TemplateMakeItem;

	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x5D0")]
	private VisualTreeAsset m_ItemTemplate;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x5D8")]
	private Action<VisualElement, int> m_BindItem;

	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x5E0")]
	private Action<VisualElement, int> m_UnbindItem;

	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x5E8")]
	private Action<VisualElement> m_DestroyItem;

	[Token(Token = "0x170001D4")]
	[CreateProperty]
	public Func<VisualElement> makeItem
	{
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x2ADC8E0", Offset = "0x2ADBAE0", VA = "0x182ADC8E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x2B04410", Offset = "0x2B03610", VA = "0x182B04410")]
		set
		{
		}
	}

	[Token(Token = "0x170001D5")]
	[CreateProperty]
	public VisualTreeAsset itemTemplate
	{
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x2ADC8F0", Offset = "0x2ADBAF0", VA = "0x182ADC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x2B04310", Offset = "0x2B03510", VA = "0x182B04310")]
		set
		{
		}
	}

	[Token(Token = "0x170001D6")]
	[CreateProperty]
	public Action<VisualElement, int> bindItem
	{
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x2B04190", Offset = "0x2B03390", VA = "0x182B04190")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x2B041C0", Offset = "0x2B033C0", VA = "0x182B041C0")]
		set
		{
		}
	}

	[Token(Token = "0x170001D7")]
	[CreateProperty]
	public Action<VisualElement, int> unbindItem
	{
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x2B041B0", Offset = "0x2B033B0", VA = "0x182B041B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x2B044C0", Offset = "0x2B036C0", VA = "0x182B044C0")]
		set
		{
		}
	}

	[Token(Token = "0x170001D8")]
	[CreateProperty]
	public Action<VisualElement> destroyItem
	{
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x2B041A0", Offset = "0x2B033A0", VA = "0x182B041A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x2B04270", Offset = "0x2B03470", VA = "0x182B04270")]
		set
		{
		}
	}

	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x2B039C0", Offset = "0x2B02BC0", VA = "0x182B039C0")]
	private VisualElement TemplateMakeItem()
	{
		return null;
	}

	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x2B03980", Offset = "0x2B02B80", VA = "0x182B03980", Slot = "146")]
	internal override bool HasValidDataAndBindings()
	{
		return default(bool);
	}

	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x2B03920", Offset = "0x2B02B20", VA = "0x182B03920", Slot = "142")]
	protected override CollectionViewController CreateViewController()
	{
		return null;
	}

	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x2B03EE0", Offset = "0x2B030E0", VA = "0x182B03EE0")]
	public TreeView()
	{
	}

	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x2B04030", Offset = "0x2B03230", VA = "0x182B04030")]
	public TreeView(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem)
	{
	}
}
