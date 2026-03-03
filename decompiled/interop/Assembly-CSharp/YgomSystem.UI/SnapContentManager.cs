using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004DA")]
public class SnapContentManager : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[Token(Token = "0x40017E3")]
	private const int TEMPLATE_NUM = 3;

	[Token(Token = "0x40017E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int templateNum;

	[Token(Token = "0x40017E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ScrollRectPageSnap m_pageSnap;

	[Token(Token = "0x40017E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ScrollRect m_scrollRect;

	[Token(Token = "0x40017E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_pastIdx;

	[Token(Token = "0x40017E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int currentPage;

	[Token(Token = "0x40017E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int m_maxPage;

	[Token(Token = "0x40017EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string templateLabel;

	[Token(Token = "0x40017EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<GameObject> templateGOList;

	[Token(Token = "0x40017EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<GameObject> onCreatedEntityCallback;

	[Token(Token = "0x40017ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<GameObject, int> onSetEntityCallback;

	[Token(Token = "0x40017EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action onPageChangedCallBack;

	[Token(Token = "0x40017EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int m_pageBuff;

	[Token(Token = "0x40017F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool m_isTouching;

	[Token(Token = "0x40017F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool m_isLoop;

	[Token(Token = "0x1700034E")]
	public int currentEntityIdx
	{
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x638060", Offset = "0x637260", VA = "0x180638060")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700034F")]
	public ScrollRect.ScrollRectEvent onValueChanged
	{
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x638090", Offset = "0x637290", VA = "0x180638090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000350")]
	public bool isTouching
	{
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x638080", Offset = "0x637280", VA = "0x180638080")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600202A")]
	[Address(RVA = "0x636F00", Offset = "0x636100", VA = "0x180636F00")]
	public void InitializeContent(int maxPage, [Optional] Action onCompleteCallBack, bool isLoop = false)
	{
	}

	[Token(Token = "0x600202B")]
	[Address(RVA = "0x637B10", Offset = "0x636D10", VA = "0x180637B10")]
	public void SetFirstPage(int firstPage = 0)
	{
	}

	[Token(Token = "0x600202C")]
	[Address(RVA = "0x637F30", Offset = "0x637130", VA = "0x180637F30")]
	public bool ToNextPage()
	{
		return default(bool);
	}

	[Token(Token = "0x600202D")]
	[Address(RVA = "0x637F70", Offset = "0x637170", VA = "0x180637F70")]
	public bool ToPrevPage()
	{
		return default(bool);
	}

	[Token(Token = "0x600202E")]
	[Address(RVA = "0x637EF0", Offset = "0x6370F0", VA = "0x180637EF0")]
	public void SetScrollDisabled()
	{
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0x637410", Offset = "0x636610", VA = "0x180637410")]
	public bool IsContainViewport(GameObject entity)
	{
		return default(bool);
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0x637730", Offset = "0x636930", VA = "0x180637730")]
	private void OnIdxChanged()
	{
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0x6374B0", Offset = "0x6366B0", VA = "0x1806374B0", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0x6374E0", Offset = "0x6366E0", VA = "0x1806374E0", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x6377C0", Offset = "0x6369C0", VA = "0x1806377C0")]
	private void OnReleaseDrag(int idx)
	{
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x636E60", Offset = "0x636060", VA = "0x180636E60")]
	private void ChangePage(int diff)
	{
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0x637860", Offset = "0x636A60", VA = "0x180637860")]
	private void RearrangeTemplate(int idxDiff)
	{
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x637FB0", Offset = "0x6371B0", VA = "0x180637FB0")]
	public SnapContentManager()
	{
	}
}
