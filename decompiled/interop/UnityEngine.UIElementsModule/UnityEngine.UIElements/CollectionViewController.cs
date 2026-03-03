using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Hierarchy;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000058")]
public abstract class CollectionViewController : IDisposable
{
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x10")]
	private BaseVerticalCollectionView m_View;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x18")]
	private IList m_ItemsSource;

	[Token(Token = "0x17000060")]
	public virtual IList itemsSource
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x29A8E30", Offset = "0x29A8030", VA = "0x1829A8E30", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	protected BaseVerticalCollectionView view
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action itemsSourceChanged
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x29A8C40", Offset = "0x29A7E40", VA = "0x1829A8C40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x29A8D90", Offset = "0x29A7F90", VA = "0x1829A8D90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<int, int> itemIndexChanged
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x29A8B90", Offset = "0x29A7D90", VA = "0x1829A8B90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x29A8CE0", Offset = "0x29A7EE0", VA = "0x1829A8CE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x29A8A60", Offset = "0x29A7C60", VA = "0x1829A8A60")]
	private protected void SetHierarchyViewModelWithoutNotify(HierarchyViewModel source)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x29A8AE0", Offset = "0x29A7CE0", VA = "0x1829A8AE0")]
	public void SetView(BaseVerticalCollectionView collectionView)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	protected virtual void PrepareView()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x29A8740", Offset = "0x29A7940", VA = "0x1829A8740", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x29A8840", Offset = "0x29A7A40", VA = "0x1829A8840", Slot = "9")]
	public virtual int GetItemsCount()
	{
		return default(int);
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x60B310", Offset = "0x60A510", VA = "0x18060B310", Slot = "10")]
	internal virtual int GetItemsMinCount()
	{
		return default(int);
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x29A8790", Offset = "0x29A7990", VA = "0x1829A8790", Slot = "11")]
	public virtual int GetIndexForId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x29A8790", Offset = "0x29A7990", VA = "0x1829A8790", Slot = "12")]
	public virtual int GetIdForIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x29A87A0", Offset = "0x29A79A0", VA = "0x1829A87A0", Slot = "13")]
	public virtual object GetItemForIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x29A89D0", Offset = "0x29A7BD0", VA = "0x1829A89D0", Slot = "14")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
	internal virtual void SetBindingContext(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x29A8890", Offset = "0x29A7A90", VA = "0x1829A8890", Slot = "16")]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x29A8A20", Offset = "0x29A7C20", VA = "0x1829A8A20", Slot = "17")]
	internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x29A89A0", Offset = "0x29A7BA0", VA = "0x1829A89A0", Slot = "18")]
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "19")]
	internal virtual void PreRefresh()
	{
	}

	[Token(Token = "0x60002FA")]
	protected abstract VisualElement MakeItem();

	[Token(Token = "0x60002FB")]
	protected abstract void BindItem(VisualElement element, int index);

	[Token(Token = "0x60002FC")]
	protected abstract void UnbindItem(VisualElement element, int index);

	[Token(Token = "0x60002FD")]
	protected abstract void DestroyItem(VisualElement element);

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x3F2960", Offset = "0x3F1B60", VA = "0x1803F2960")]
	protected void RaiseItemsSourceChanged()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x29A5770", Offset = "0x29A4970", VA = "0x1829A5770")]
	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected CollectionViewController()
	{
	}
}
