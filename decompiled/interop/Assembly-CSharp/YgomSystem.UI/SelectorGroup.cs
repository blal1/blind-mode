using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004B1")]
public class SelectorGroup
{
	[Token(Token = "0x20004B2")]
	public enum Direction
	{
		[Token(Token = "0x40016F5")]
		None,
		[Token(Token = "0x40016F6")]
		Up,
		[Token(Token = "0x40016F7")]
		Right,
		[Token(Token = "0x40016F8")]
		Down,
		[Token(Token = "0x40016F9")]
		Left
	}

	[Token(Token = "0x40016F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string groupLabel;

	[Token(Token = "0x40016F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Selector> selectors;

	[Token(Token = "0x40016F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool isDirty;

	[Token(Token = "0x17000306")]
	public int selectorNum
	{
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x61CDF0", Offset = "0x61BFF0", VA = "0x18061CDF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000307")]
	public int groupPriority
	{
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x61CDA0", Offset = "0x61BFA0", VA = "0x18061CDA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000308")]
	public SelectionItem currentItem
	{
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x61CD40", Offset = "0x61BF40", VA = "0x18061CD40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000309")]
	public int priorityInCluster
	{
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0x61CCA0", Offset = "0x61BEA0", VA = "0x18061CCA0")]
	public SelectorGroup(string group_label)
	{
	}

	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x61B870", Offset = "0x61AA70", VA = "0x18061B870")]
	public void AddSelector(Selector selector)
	{
	}

	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x61C390", Offset = "0x61B590", VA = "0x18061C390")]
	public void RemoveSelector(Selector selector)
	{
	}

	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x61C6F0", Offset = "0x61B8F0", VA = "0x18061C6F0")]
	public SelectionItem.UpdateItemStatus UpdateAllSelectors()
	{
		return default(SelectionItem.UpdateItemStatus);
	}

	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x61C840", Offset = "0x61BA40", VA = "0x18061C840")]
	public void UpdateSelectorDepthIfDirty()
	{
	}

	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x61BF50", Offset = "0x61B150", VA = "0x18061BF50")]
	public (SelectionItem, float) GetSelectionItem(Vector2 position, Vector2 normalized_direction, float angle, [Optional] SelectionItem ignore_item)
	{
		return default((SelectionItem, float));
	}

	[Token(Token = "0x6001F04")]
	[Address(RVA = "0x61BA20", Offset = "0x61AC20", VA = "0x18061BA20")]
	public SelectionItem GetHiestPrioritySelectableItem()
	{
		return null;
	}

	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x61BCB0", Offset = "0x61AEB0", VA = "0x18061BCB0")]
	public (SelectionItem, float) GetSelectionItem(Vector2 view_position)
	{
		return default((SelectionItem, float));
	}

	[Token(Token = "0x6001F06")]
	[Address(RVA = "0x61BBC0", Offset = "0x61ADC0", VA = "0x18061BBC0")]
	public bool GetSelectionItemAll(Vector2 view_position, List<SelectionItem> hitItems, bool containNoneInteractable = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x61C530", Offset = "0x61B730", VA = "0x18061C530")]
	public void SetDefaultItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x61B930", Offset = "0x61AB30", VA = "0x18061B930")]
	public SelectionItem GetDefaultItem()
	{
		return null;
	}

	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x61C3F0", Offset = "0x61B5F0", VA = "0x18061C3F0")]
	public bool SelectItem(SelectionItem item, bool initializeSelection = false, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x61C660", Offset = "0x61B860", VA = "0x18061C660")]
	public void SetGroupPriority(int group_priority, bool refresh_active_group)
	{
	}

	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
	public void SetPriorityInCluster(int priority_in_cluster)
	{
	}

	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x61C910", Offset = "0x61BB10", VA = "0x18061C910")]
	private void UpdateSelectorDepth()
	{
	}

	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x61C150", Offset = "0x61B350", VA = "0x18061C150")]
	public void InvokeClusterActivateCallback()
	{
	}

	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x61C270", Offset = "0x61B470", VA = "0x18061C270")]
	public void InvokeClusterDeactivateCallback()
	{
	}

	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
	public List<Selector> GetSelectors()
	{
		return null;
	}
}
