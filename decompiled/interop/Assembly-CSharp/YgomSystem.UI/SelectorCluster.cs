using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004B0")]
public class SelectorCluster
{
	[Token(Token = "0x40016DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int priority;

	[Token(Token = "0x40016E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SelectorGroup> groups;

	[Token(Token = "0x40016E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SelectionItem preSelectedItem;

	[Token(Token = "0x40016E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected PadInputDirection currentPadDirection;

	[Token(Token = "0x40016E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float padInputContinueTime;

	[Token(Token = "0x40016E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static Vector2 directionUp;

	[Token(Token = "0x40016E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static Vector2 directionUpRight;

	[Token(Token = "0x40016E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static Vector2 directionRight;

	[Token(Token = "0x40016E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected static Vector2 directionDownRight;

	[Token(Token = "0x40016EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected static Vector2 directionDown;

	[Token(Token = "0x40016EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected static Vector2 directionDownLeft;

	[Token(Token = "0x40016EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected static Vector2 directionLeft;

	[Token(Token = "0x40016ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected static Vector2 directionUpLeft;

	[Token(Token = "0x17000300")]
	public bool goThrough
	{
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x61B860", Offset = "0x61AA60", VA = "0x18061B860")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000301")]
	public int goThroughCounter
	{
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000302")]
	public SelectionItem currentItem
	{
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000303")]
	public Selector currentSelector
	{
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x61B7E0", Offset = "0x61A9E0", VA = "0x18061B7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000304")]
	public bool activated
	{
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000305")]
	public bool protectActivation
	{
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x416710", Offset = "0x415910", VA = "0x180416710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x61B750", Offset = "0x61A950", VA = "0x18061B750")]
	public SelectorCluster(int priority)
	{
	}

	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x619B80", Offset = "0x618D80", VA = "0x180619B80")]
	public void AddGroup(SelectorGroup group)
	{
	}

	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x61AD60", Offset = "0x619F60", VA = "0x18061AD60")]
	public void RemoveGroup(SelectorGroup group)
	{
	}

	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x61B1A0", Offset = "0x61A3A0", VA = "0x18061B1A0")]
	public SelectionItem.UpdateItemStatus UpdateAllGroups()
	{
		return default(SelectionItem.UpdateItemStatus);
	}

	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x61B390", Offset = "0x61A590", VA = "0x18061B390")]
	public void UpdatePriorityAllGroupsIfDirty()
	{
	}

	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x61A150", Offset = "0x619350", VA = "0x18061A150")]
	public SelectorGroup GetGroup(string label)
	{
		return null;
	}

	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x61AEE0", Offset = "0x61A0E0", VA = "0x18061AEE0")]
	public bool SelectItem(SelectionItem item, bool initializeSelection = false, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x619ED0", Offset = "0x6190D0", VA = "0x180619ED0")]
	public void DeselectCurrentItem(bool savePreSelectedItem)
	{
	}

	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x61AA20", Offset = "0x619C20", VA = "0x18061AA20")]
	public SelectionItem GetSelectionItem(Vector2 view_position)
	{
		return null;
	}

	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x61A500", Offset = "0x619700", VA = "0x18061A500")]
	public bool GetSelectionItemAll(Vector2 view_position, List<SelectionItem> hitItems, bool containNoneInteractable = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x61A220", Offset = "0x619420", VA = "0x18061A220")]
	public SelectionItem GetHighestPrioritySelectableItem()
	{
		return null;
	}

	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x61AE60", Offset = "0x61A060", VA = "0x18061AE60")]
	public bool SelectHighestPriorityItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x619C50", Offset = "0x618E50", VA = "0x180619C50")]
	public void ChangeSelectionItem(Vector2 position, Vector2 normalized_direction, bool check_loop, float angle, bool igonre_current_item)
	{
	}

	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x61A670", Offset = "0x619870", VA = "0x18061A670")]
	public (SelectionItem, float) GetSelectionItem(Vector2 position, Vector2 normalized_direction, bool check_loop, float angle, [Optional] SelectionItem ignore_item)
	{
		return default((SelectionItem, float));
	}

	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x619FB0", Offset = "0x6191B0", VA = "0x180619FB0")]
	public SelectionItem GetDefaultItem()
	{
		return null;
	}

	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x61ADC0", Offset = "0x619FC0", VA = "0x18061ADC0")]
	public bool SelectDefaultItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
	public SelectionItem GetPreSelectedItem()
	{
		return null;
	}

	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x61B0F0", Offset = "0x61A2F0", VA = "0x18061B0F0")]
	public bool SelectPreSelectedItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x61A3D0", Offset = "0x6195D0", VA = "0x18061A3D0")]
	private Vector2 GetScreenEdge(Vector2 position, Vector2 ray_direction)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x619A70", Offset = "0x618C70", VA = "0x180619A70")]
	public void Activate()
	{
	}

	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x619DA0", Offset = "0x618FA0", VA = "0x180619DA0")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x61ACA0", Offset = "0x619EA0", VA = "0x18061ACA0")]
	public void Refresh()
	{
	}
}
