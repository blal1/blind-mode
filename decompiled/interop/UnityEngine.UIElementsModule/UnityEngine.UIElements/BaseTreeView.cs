using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000081")]
public abstract class BaseTreeView : BaseVerticalCollectionView
{
	[Token(Token = "0x2000082")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
	{
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0xC8")]
		private readonly UxmlBoolAttributeDescription m_AutoExpand;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2AB75E0", Offset = "0x2AB67E0", VA = "0x182AB75E0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2AB9AC0", Offset = "0x2AB8CC0", VA = "0x182AB9AC0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId autoExpandProperty;

	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x98")]
	internal static CustomStyleProperty<float> s_TreeViewIndentProperty;

	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0xA0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static readonly int invalidId;

	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0xA8")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0xB0")]
	public new static readonly string itemUssClassName;

	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0xB8")]
	public static readonly string itemToggleUssClassName;

	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0xC0")]
	[Obsolete("Individual item indents are no longer used, see itemIndentUssClassName instead", false)]
	public static readonly string itemIndentsContainerUssClassName;

	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0xC8")]
	public static readonly string itemIndentUssClassName;

	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0xD0")]
	public static readonly string itemContentContainerUssClassName;

	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x5A0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged;

	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x5A8")]
	private bool m_AutoExpand;

	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x5B0")]
	[SerializeField]
	[DontCreateProperty]
	private List<int> m_ExpandedItemIds;

	[Token(Token = "0x170000BA")]
	[CreateProperty(ReadOnly = true)]
	public new IList itemsSource
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2A9FE90", Offset = "0x2A9F090", VA = "0x182A9FE90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2AA0000", Offset = "0x2A9F200", VA = "0x182AA0000")]
		internal set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public new BaseTreeViewController viewController
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2A9FEC0", Offset = "0x2A9F0C0", VA = "0x182A9FEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BC")]
	[CreateProperty]
	public bool autoExpand
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2A9FE70", Offset = "0x2A9F070", VA = "0x182A9FE70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2A9FF40", Offset = "0x2A9F140", VA = "0x182A9FF40")]
		set
		{
		}
	}

	[Token(Token = "0x170000BD")]
	internal List<int> expandedItemIds
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2A9FE80", Offset = "0x2A9F080", VA = "0x182A9FE80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2A9FFE0", Offset = "0x2A9F1E0", VA = "0x182A9FFE0")]
		set
		{
		}
	}

	[Token(Token = "0x170000BE")]
	internal float? customIdent
	{
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x29A0BD0", Offset = "0x299FDD0", VA = "0x1829A0BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2A9FFD0", Offset = "0x2A9F1D0", VA = "0x182A9FFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x2A9E440", Offset = "0x2A9D640", VA = "0x182A9E440", Slot = "141")]
	private protected override void CreateVirtualizationController()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x2A9F280", Offset = "0x2A9E480", VA = "0x182A9F280", Slot = "143")]
	public override void SetViewController(CollectionViewController controller)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x2A9EF40", Offset = "0x2A9E140", VA = "0x182A9EF40")]
	private void OnItemIndexChanged(int srcIndex, int dstIndex)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x2A9EF20", Offset = "0x2A9E120", VA = "0x182A9EF20")]
	private void OnItemExpandedChanged(TreeViewExpansionChangedArgs arg)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x2A9E3E0", Offset = "0x2A9D5E0", VA = "0x182A9E3E0", Slot = "145")]
	internal override ICollectionDragAndDropController CreateDragAndDropController()
	{
		return null;
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x2A9FCD0", Offset = "0x2A9EED0", VA = "0x182A9FCD0")]
	public BaseTreeView()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x2A9FB20", Offset = "0x2A9ED20", VA = "0x182A9FB20")]
	public BaseTreeView(int itemHeight)
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x2A9ED70", Offset = "0x2A9DF70", VA = "0x182A9ED70")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x2A9EF50", Offset = "0x2A9E150", VA = "0x182A9EF50", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x2A9E780", Offset = "0x2A9D980", VA = "0x182A9E780", Slot = "148")]
	private protected override bool HandleItemNavigation(bool moveIn, bool altPressed)
	{
		return default(bool);
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x2A9F0A0", Offset = "0x2A9E2A0", VA = "0x182A9F0A0")]
	public void SetSelectionById(int id)
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x2A9EFE0", Offset = "0x2A9E1E0", VA = "0x182A9EFE0")]
	public void SetSelectionById(IEnumerable<int> ids)
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x2A9F1B0", Offset = "0x2A9E3B0", VA = "0x182A9F1B0")]
	internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x2A9E570", Offset = "0x2A9D770", VA = "0x182A9E570")]
	private int GetItemIndex(int id, bool expand = false)
	{
		return default(int);
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x2A9ED40", Offset = "0x2A9DF40", VA = "0x182A9ED40")]
	public bool IsExpanded(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x2A9E380", Offset = "0x2A9D580", VA = "0x182A9E380")]
	public void CollapseItem(int id, bool collapseAllChildren = false, bool refresh = true)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x2A9E510", Offset = "0x2A9D710", VA = "0x182A9E510")]
	public void ExpandItem(int id, bool expandAllChildren = false, bool refresh = true)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x2A9ED10", Offset = "0x2A9DF10", VA = "0x182A9ED10")]
	private bool IsExpandedByIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x2A9E2F0", Offset = "0x2A9D4F0", VA = "0x182A9E2F0")]
	private void CollapseItemByIndex(int index, bool collapseAll)
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x2A9E480", Offset = "0x2A9D680", VA = "0x182A9E480")]
	private void ExpandItemByIndex(int index, bool expandAll)
	{
	}
}
