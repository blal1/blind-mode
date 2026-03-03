using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000051")]
public abstract class BaseListViewController : CollectionViewController
{
	[Token(Token = "0x17000050")]
	protected BaseListView baseListView
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x299CE50", Offset = "0x299C050", VA = "0x18299CE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000006")]
	public event Action itemsSourceSizeChanged
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x299CDB0", Offset = "0x299BFB0", VA = "0x18299CDB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x299D030", Offset = "0x299C230", VA = "0x18299D030")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action<IEnumerable<int>> itemsAdded
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x299CC50", Offset = "0x299BE50", VA = "0x18299CC50")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x299CED0", Offset = "0x299C0D0", VA = "0x18299CED0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action<IEnumerable<int>> itemsRemoved
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x299CD00", Offset = "0x299BF00", VA = "0x18299CD00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x299CF80", Offset = "0x299C180", VA = "0x18299CF80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x299B8A0", Offset = "0x299AAA0", VA = "0x18299B8A0", Slot = "14")]
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x299BC90", Offset = "0x299AE90", VA = "0x18299BC90")]
	internal void PostInitRegistration(ReusableListViewItem listItem)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x299C8C0", Offset = "0x299BAC0", VA = "0x18299C8C0", Slot = "15")]
	internal override void SetBindingContext(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x299B600", Offset = "0x299A800", VA = "0x18299B600", Slot = "16")]
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1521C70", Offset = "0x1520E70", VA = "0x181521C70", Slot = "24")]
	public virtual bool NeedsDragHandle(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x299ABF0", Offset = "0x2999DF0", VA = "0x18299ABF0", Slot = "25")]
	public virtual void AddItems(int itemCount)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x299BA50", Offset = "0x299AC50", VA = "0x18299BA50", Slot = "26")]
	public virtual void Move(int index, int newIndex)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x299C340", Offset = "0x299B540", VA = "0x18299C340", Slot = "27")]
	public virtual void RemoveItem(int index)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x299C650", Offset = "0x299B850", VA = "0x18299C650", Slot = "28")]
	public virtual void RemoveItems(List<int> indices)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x299C4B0", Offset = "0x299B6B0", VA = "0x18299C4B0", Slot = "29")]
	internal virtual void RemoveItems(int itemCount)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x299B380", Offset = "0x299A580", VA = "0x18299B380", Slot = "30")]
	public virtual void ClearItems()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x8C8340", Offset = "0x8C7540", VA = "0x1808C8340")]
	protected void RaiseOnSizeChanged()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x299C160", Offset = "0x299B360", VA = "0x18299C160")]
	protected void RaiseItemsAdded(IEnumerable<int> indices)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x299C180", Offset = "0x299B380", VA = "0x18299C180")]
	protected void RaiseItemsRemoved(IEnumerable<int> indices)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x299B270", Offset = "0x299A470", VA = "0x18299B270")]
	private static Array AddToArray(Array source, int itemCount)
	{
		return null;
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x299C1A0", Offset = "0x299B3A0", VA = "0x18299C1A0")]
	private static Array RemoveFromArray(Array source, List<int> indicesToRemove)
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x299CA60", Offset = "0x299BC60", VA = "0x18299CA60")]
	private void Swap(int lhs, int rhs)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x299B4A0", Offset = "0x299A6A0", VA = "0x18299B4A0")]
	private void EnsureItemSourceCanBeResized()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseListViewController()
	{
	}
}
