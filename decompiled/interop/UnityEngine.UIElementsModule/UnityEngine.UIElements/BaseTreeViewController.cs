using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Hierarchy;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000054")]
public abstract class BaseTreeViewController : CollectionViewController
{
	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class _003CGetAllItemIds_003Ed__23 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _003C_003E2__current;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IEnumerable<int> rootIds;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerable<int> _003C_003E3__rootIds;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BaseTreeViewController _003C_003E4__this;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HierarchyFlattened.Enumerator _003C_003Es__1;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private HierarchyFlattenedNode _003CflattenedNode_003E5__2;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private HierarchyNode _003Cnode_003E5__3;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private IEnumerator<int> _003C_003Es__4;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _003Cid_003E5__5;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private HierarchyNode _003CparentNode_003E5__6;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HierarchyFlattenedNodeChildren _003CflattenedNodeChildren_003E5__7;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private HierarchyFlattenedNodeChildren.Enumerator _003C_003Es__8;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HierarchyNode _003Cnode_003E5__9;

		[Token(Token = "0x1700005A")]
		private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x778F30", Offset = "0x778130", VA = "0x180778F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x778F60", Offset = "0x778160", VA = "0x180778F60")]
		[DebuggerHidden]
		public _003CGetAllItemIds_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x29AF340", Offset = "0x29AE540", VA = "0x1829AF340", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x29AEAC0", Offset = "0x29ADCC0", VA = "0x1829AEAC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x29AF3A0", Offset = "0x29AE5A0", VA = "0x1829AF3A0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x29AF300", Offset = "0x29AE500", VA = "0x1829AF300", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x29AF250", Offset = "0x29AE450", VA = "0x1829AF250", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x29AF250", Offset = "0x29AE450", VA = "0x1829AF250", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class _003CGetChildrenIds_003Ed__25 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _003C_003E2__current;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int id;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int _003C_003E3__id;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BaseTreeViewController _003C_003E4__this;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HierarchyNode _003CnodeById_003E5__1;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HierarchyNodeChildren _003Cnodes_003E5__2;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private HierarchyNodeChildren.Enumerator _003C_003Es__3;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private HierarchyNode _003Cnode_003E5__4;

		[Token(Token = "0x1700005C")]
		private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x778F30", Offset = "0x778130", VA = "0x180778F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x778F60", Offset = "0x778160", VA = "0x180778F60")]
		[DebuggerHidden]
		public _003CGetChildrenIds_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x29AF660", Offset = "0x29AE860", VA = "0x1829AF660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x29AF8B0", Offset = "0x29AEAB0", VA = "0x1829AF8B0", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x29AF800", Offset = "0x29AEA00", VA = "0x1829AF800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x29AF800", Offset = "0x29AEA00", VA = "0x1829AF800", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class _003CGetChildrenIdsByIndex_003Ed__41 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _003C_003E2__current;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int index;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int _003C_003E3__index;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BaseTreeViewController _003C_003E4__this;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HierarchyNodeChildren _003Cnodes_003E5__1;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HierarchyNodeChildren.Enumerator _003C_003Es__2;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HierarchyNode _003Cnode_003E5__3;

		[Token(Token = "0x1700005E")]
		private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x778F30", Offset = "0x778130", VA = "0x180778F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x778F60", Offset = "0x778160", VA = "0x180778F60")]
		[DebuggerHidden]
		public _003CGetChildrenIdsByIndex_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x29AF400", Offset = "0x29AE600", VA = "0x1829AF400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x29AF620", Offset = "0x29AE820", VA = "0x1829AF620", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x29AF570", Offset = "0x29AE770", VA = "0x1829AF570", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x29AF570", Offset = "0x29AE770", VA = "0x1829AF570", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private protected Hierarchy m_Hierarchy;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private protected HierarchyFlattened m_HierarchyFlattened;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private protected HierarchyViewModel m_HierarchyViewModel;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private protected Dictionary<int, HierarchyNode> m_IdToNodeDictionary;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private IHierarchyProperty<int> m_TreeViewDataProperty;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_HierarchyHasPendingChanged;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker K_ExpandItemByIndex;

	[Token(Token = "0x17000057")]
	protected BaseTreeView baseTreeView
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x29A5F30", Offset = "0x29A5130", VA = "0x1829A5F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000058")]
	private protected Hierarchy hierarchy
	{
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x29A6060", Offset = "0x29A5260", VA = "0x1829A6060")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public override IList itemsSource
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x29A61D0", Offset = "0x29A53D0", VA = "0x1829A61D0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x14000009")]
	internal event Action<TreeViewExpansionChangedArgs> itemExpandedChanged
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x29A5E80", Offset = "0x29A5080", VA = "0x1829A5E80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x29A5FB0", Offset = "0x29A51B0", VA = "0x1829A5FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x29A5C90", Offset = "0x29A4E90", VA = "0x1829A5C90")]
	protected BaseTreeViewController()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x29A2DA0", Offset = "0x29A1FA0", VA = "0x1829A2DA0", Slot = "1")]
	~BaseTreeViewController()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x29A2600", Offset = "0x29A1800", VA = "0x1829A2600")]
	internal void DisposeHierarchy()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x29A2E00", Offset = "0x29A2000", VA = "0x1829A2E00", Slot = "24")]
	[IteratorStateMachine(typeof(_003CGetAllItemIds_003Ed__23))]
	public virtual IEnumerable<int> GetAllItemIds([Optional] IEnumerable<int> rootIds)
	{
		return null;
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x29A39F0", Offset = "0x29A2BF0", VA = "0x1829A39F0", Slot = "25")]
	public virtual int GetParentId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x29A3160", Offset = "0x29A2360", VA = "0x1829A3160", Slot = "26")]
	[IteratorStateMachine(typeof(_003CGetChildrenIds_003Ed__25))]
	public virtual IEnumerable<int> GetChildrenIds(int id)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x29A4650", Offset = "0x29A3850", VA = "0x1829A4650", Slot = "27")]
	public virtual void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x29A4150", Offset = "0x29A3350", VA = "0x1829A4150", Slot = "14")]
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x29A3CB0", Offset = "0x29A2EB0", VA = "0x1829A3CB0", Slot = "16")]
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x29A3F00", Offset = "0x29A3100", VA = "0x1829A3F00", Slot = "18")]
	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x29A54D0", Offset = "0x29A46D0", VA = "0x1829A54D0")]
	internal void PostInitRegistration(ReusableTreeViewItem treeItem)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x29A4940", Offset = "0x29A3B40", VA = "0x1829A4940")]
	private void OnItemPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x29A56C0", Offset = "0x29A48C0", VA = "0x1829A56C0")]
	private void RaiseItemExpandedChanged(int id, bool isExpanded, bool isAppliedToAllChildren)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x29A5060", Offset = "0x29A4260", VA = "0x1829A5060")]
	private void OnToggleValueChanged(ChangeEvent<bool> evt)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x29A3930", Offset = "0x29A2B30", VA = "0x1829A3930", Slot = "11")]
	public override int GetIndexForId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x29A36B0", Offset = "0x29A28B0", VA = "0x1829A36B0", Slot = "12")]
	public override int GetIdForIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x29A3C00", Offset = "0x29A2E00", VA = "0x1829A3C00", Slot = "28")]
	public virtual bool HasChildren(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x29A26D0", Offset = "0x29A18D0", VA = "0x1829A26D0")]
	public bool Exists(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x29A3BA0", Offset = "0x29A2DA0", VA = "0x1829A3BA0")]
	public bool HasChildrenByIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x29A30E0", Offset = "0x29A22E0", VA = "0x1829A30E0")]
	[IteratorStateMachine(typeof(_003CGetChildrenIdsByIndex_003Ed__41))]
	public IEnumerable<int> GetChildrenIdsByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x29A2E90", Offset = "0x29A2090", VA = "0x1829A2E90")]
	public int GetChildIndexForId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x29A3880", Offset = "0x29A2A80", VA = "0x1829A3880")]
	public int GetIndentationDepth(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x29A37C0", Offset = "0x29A29C0", VA = "0x1829A37C0")]
	public int GetIndentationDepthByIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1521C70", Offset = "0x1520E70", VA = "0x181521C70", Slot = "29")]
	public virtual bool CanChangeExpandedState(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x29A44C0", Offset = "0x29A36C0", VA = "0x1829A44C0")]
	public bool IsExpanded(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x29A4380", Offset = "0x29A3580", VA = "0x1829A4380")]
	public bool IsExpandedByIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x29A2730", Offset = "0x29A1930", VA = "0x1829A2730")]
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x29A2CC0", Offset = "0x29A1EC0", VA = "0x1829A2CC0")]
	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x29A2080", Offset = "0x29A1280", VA = "0x1829A2080")]
	public void CollapseItemByIndex(int index, bool collapseAllChildren, bool refresh = true)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x29A24A0", Offset = "0x29A16A0", VA = "0x1829A24A0")]
	public void CollapseItem(int id, bool collapseAllChildren, bool refresh = true)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x29A28E0", Offset = "0x29A1AE0", VA = "0x1829A28E0")]
	private void ExpandItemByNode(in HierarchyNode node, bool expandAllChildren, bool refresh)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x29A2150", Offset = "0x29A1350", VA = "0x1829A2150")]
	private void CollapseItemByNode(in HierarchyNode node, bool collapseAllChildren, bool refresh)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x29A31E0", Offset = "0x29A23E0", VA = "0x1829A31E0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void GetExpandedItemIds(List<int> list)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x29A45F0", Offset = "0x29A37F0", VA = "0x1829A45F0")]
	internal bool IsViewDataKeyEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x29A56B0", Offset = "0x29A48B0", VA = "0x1829A56B0", Slot = "19")]
	internal override void PreRefresh()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x29A45C0", Offset = "0x29A37C0", VA = "0x1829A45C0")]
	private bool IsIndexValid(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x29A4200", Offset = "0x29A3400", VA = "0x1829A4200")]
	private bool IsChildOf(int childId, int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x29A5770", Offset = "0x29A4970", VA = "0x1829A5770")]
	internal void RaiseItemParentChanged(int id, int newParentId)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x29A2580", Offset = "0x29A1780", VA = "0x1829A2580")]
	internal HierarchyNode CreateNode(in HierarchyNode parent)
	{
		return default(HierarchyNode);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x29A5820", Offset = "0x29A4A20", VA = "0x1829A5820")]
	internal void UpdateIdToNodeDictionary(int id, in HierarchyNode node, bool isAdd = true)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x29A2030", Offset = "0x29A1230", VA = "0x1829A2030")]
	internal void ClearIdToNodeDictionary()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x29A5960", Offset = "0x29A4B60", VA = "0x1829A5960")]
	internal void UpdateSortOrder(in HierarchyNode newParent, in HierarchyNode insertedNode, int insertedIndex)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x29A52C0", Offset = "0x29A44C0", VA = "0x1829A52C0")]
	internal void OnViewDataReadyUpdateNodes()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x29A5790", Offset = "0x29A4990", VA = "0x1829A5790")]
	internal void UpdateHierarchy()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x29A35D0", Offset = "0x29A27D0", VA = "0x1829A35D0")]
	internal HierarchyNode GetHierarchyNodeById(int id)
	{
		return default(HierarchyNode);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x29A3670", Offset = "0x29A2870", VA = "0x1829A3670")]
	internal HierarchyNode GetHierarchyNodeByIndex(int index)
	{
		return default(HierarchyNode);
	}
}
