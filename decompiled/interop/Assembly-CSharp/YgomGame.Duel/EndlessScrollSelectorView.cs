using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001B85")]
[RequireComponent(typeof(Selector))]
public class EndlessScrollSelectorView : EndlessScrollView
{
	[Token(Token = "0x400F9B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool loopInScrollView;

	[Token(Token = "0x400F9B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
	private bool m_IsItemInHere;

	[Token(Token = "0x400F9B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private int m_SelectedItemIndex;

	[Token(Token = "0x400F9B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Vector2 m_OldPos;

	[Token(Token = "0x400F9B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[HideInInspector]
	public List<int> unselectableIndexList;

	[Token(Token = "0x400F9BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<int> uninteractableIndexList;

	[Token(Token = "0x400F9BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Dictionary<ManualTransition, SelectionItem> manualTransitionTable;

	[Token(Token = "0x17001B67")]
	private RectTransform m_CurrentItemRT
	{
		[Token(Token = "0x600B305")]
		[Address(RVA = "0x4A3460", Offset = "0x4A2660", VA = "0x1804A3460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B68")]
	private RectTransform m_ViewportRT
	{
		[Token(Token = "0x600B306")]
		[Address(RVA = "0x4A3590", Offset = "0x4A2790", VA = "0x1804A3590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B69")]
	public Selector selector
	{
		[Token(Token = "0x600B307")]
		[Address(RVA = "0x4A3680", Offset = "0x4A2880", VA = "0x1804A3680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B6A")]
	private Vector2 m_ViewportTopPos
	{
		[Token(Token = "0x600B308")]
		[Address(RVA = "0x4A3600", Offset = "0x4A2800", VA = "0x1804A3600")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001B6B")]
	private Vector2 m_ViewportBottomPos
	{
		[Token(Token = "0x600B309")]
		[Address(RVA = "0x4A3470", Offset = "0x4A2670", VA = "0x1804A3470")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001B6C")]
	private bool ishorizontalscroll
	{
		[Token(Token = "0x600B30A")]
		[Address(RVA = "0x4A3450", Offset = "0x4A2650", VA = "0x1804A3450")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600B30B")]
	[Address(RVA = "0x4A2C20", Offset = "0x4A1E20", VA = "0x1804A2C20")]
	private void SetCallBack()
	{
	}

	[Token(Token = "0x600B30C")]
	[Address(RVA = "0x4A2840", Offset = "0x4A1A40", VA = "0x1804A2840")]
	private bool IsCurrentItemInHere()
	{
		return default(bool);
	}

	[Token(Token = "0x600B30D")]
	[Address(RVA = "0x4A2710", Offset = "0x4A1910", VA = "0x1804A2710")]
	protected void InputCallBack(PadInputDirection direction)
	{
	}

	[Token(Token = "0x600B30E")]
	[Address(RVA = "0x4A2EC0", Offset = "0x4A20C0", VA = "0x1804A2EC0")]
	public bool SetSelectItemByDataIndex(int dataIndex, bool forceSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B30F")]
	[Address(RVA = "0x4A30C0", Offset = "0x4A22C0", VA = "0x1804A30C0", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600B310")]
	[Address(RVA = "0x4A2280", Offset = "0x4A1480", VA = "0x1804A2280", Slot = "4")]
	public override void Initialize(Func<int> getDataNum, Action<GameObject, int> onItemUpdate, [Optional] Action<GameObject> onItemInitialize)
	{
	}

	[Token(Token = "0x600B311")]
	[Address(RVA = "0x4A2DD0", Offset = "0x4A1FD0", VA = "0x1804A2DD0")]
	private void SetItemTrsnsitionMode(ref SelectionItem selitem, int dataindex, PadInputDirection direction, SelectionItem.TransitionMode defaultMode)
	{
	}

	[Token(Token = "0x600B312")]
	[Address(RVA = "0x4A29F0", Offset = "0x4A1BF0", VA = "0x1804A29F0")]
	private int NextDataIndex(PadInputDirection direction)
	{
		return default(int);
	}

	[Token(Token = "0x600B313")]
	[Address(RVA = "0x4A29C0", Offset = "0x4A1BC0", VA = "0x1804A29C0")]
	private bool IsObeyScrollDirection(SelectorGroup.Direction direction)
	{
		return default(bool);
	}

	[Token(Token = "0x600B314")]
	[Address(RVA = "0x4A27E0", Offset = "0x4A19E0", VA = "0x1804A27E0")]
	private bool IsCurrentDataInViewport()
	{
		return default(bool);
	}

	[Token(Token = "0x600B315")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1B60", VA = "0x1804A2960")]
	private bool IsDataInViewport(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600B316")]
	[Address(RVA = "0x4A2180", Offset = "0x4A1380", VA = "0x1804A2180")]
	private float GetCurrentDataViewportBias()
	{
		return default(float);
	}

	[Token(Token = "0x600B317")]
	[Address(RVA = "0x4A2190", Offset = "0x4A1390", VA = "0x1804A2190")]
	private float GetDataViewportBias(int dataindex)
	{
		return default(float);
	}

	[Token(Token = "0x600B318")]
	[Address(RVA = "0x4A3200", Offset = "0x4A2400", VA = "0x1804A3200")]
	public EndlessScrollSelectorView()
	{
	}
}
