using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x2000441")]
public class ExtendedScrollRect : ScrollRect, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IPointerDownHandler
{
	[Token(Token = "0x2000443")]
	[CompilerGenerated]
	private sealed class _003CMoveContentImpl_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40014E6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40014E7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40014E8")]
		[FieldOffset(Offset = "0x20")]
		public ExtendedScrollRect _003C_003E4__this;

		[Token(Token = "0x1700028B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B6A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CMoveContentImpl_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x5F3960", Offset = "0x5F2B60", VA = "0x1805F3960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x5F3CF0", Offset = "0x5F2EF0", VA = "0x1805F3CF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40014CC")]
	private const float WHEELSCROLL_MINMAGNITUDE = 0.0001f;

	[Token(Token = "0x40014CD")]
	private const float k_MinDeltaModify = 0.3f;

	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x130")]
	private GameObject barObjHorizontal;

	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x138")]
	private GameObject barObjVertical;

	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0x140")]
	private TweenContainer tweenContainerH;

	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x148")]
	private TweenContainer tweenContainerV;

	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x150")]
	private CanvasGroup barCanvasGrpH;

	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x158")]
	private CanvasGroup barCanvasGrpV;

	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x160")]
	private bool dragScrollEnabled;

	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x161")]
	private bool fadeEnabled;

	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x162")]
	private bool isHorizontalShowing;

	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x163")]
	private bool isVerticalShowing;

	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x164")]
	protected bool dragging;

	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0x168")]
	private Vector2 m_WheelScrollVelocity;

	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x174")]
	private Vector2 m_TargetPos;

	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x17C")]
	private Vector2 m_AnchorPos;

	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x188")]
	private IEnumerator m_yMoveContentImpl;

	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0x190")]
	public Action onStopScrollCallback;

	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	private bool m_IsIgnoreNotTagetAxis;

	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0x19C")]
	[SerializeField]
	private float ignoreRate;

	[Token(Token = "0x40014E1")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private bool m_StopOnPointerDown;

	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0x1A1")]
	[SerializeField]
	private bool m_ApplyDeltaTime;

	[Token(Token = "0x17000286")]
	public int dragBlockCounter
	{
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x5E55F0", Offset = "0x5E47F0", VA = "0x1805E55F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x5E5680", Offset = "0x5E4880", VA = "0x1805E5680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000287")]
	public bool isDragBlocked
	{
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x5E5610", Offset = "0x5E4810", VA = "0x1805E5610")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000288")]
	public Vector2 targetPos
	{
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x5E5660", Offset = "0x5E4860", VA = "0x1805E5660")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000289")]
	public bool isMoving
	{
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x5E5620", Offset = "0x5E4820", VA = "0x1805E5620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700028A")]
	public bool isAutoScroll
	{
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x5E5600", Offset = "0x5E4800", VA = "0x1805E5600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x5E49F0", Offset = "0x5E3BF0", VA = "0x1805E49F0")]
	public void SetIgnoreNotTagetAxis(bool isIgnore, float thres)
	{
	}

	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x5E4E00", Offset = "0x5E4000", VA = "0x1805E4E00", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x5E3A30", Offset = "0x5E2C30", VA = "0x1805E3A30")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x5E5140", Offset = "0x5E4340", VA = "0x1805E5140")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x5E4300", Offset = "0x5E3500", VA = "0x1805E4300", Slot = "61")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x5E42E0", Offset = "0x5E34E0", VA = "0x1805E42E0", Slot = "43")]
	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x5E4070", Offset = "0x5E3270", VA = "0x1805E4070", Slot = "44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x5E40E0", Offset = "0x5E32E0", VA = "0x1805E40E0", Slot = "46")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x5E4100", Offset = "0x5E3300", VA = "0x1805E4100", Slot = "45")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x5E4330", Offset = "0x5E3530", VA = "0x1805E4330", Slot = "42")]
	public override void OnScroll(PointerEventData data)
	{
	}

	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x5E4380", Offset = "0x5E3580", VA = "0x1805E4380")]
	public void ScrollByDelta(Vector2 delta)
	{
	}

	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x5E4790", Offset = "0x5E3990", VA = "0x1805E4790")]
	public void ScrollByTargetPos(Vector2 targetPos)
	{
	}

	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x5E4E20", Offset = "0x5E4020", VA = "0x1805E4E20")]
	public void StopAutoScroll(bool isInvokeCallback = true)
	{
	}

	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x5E4000", Offset = "0x5E3200", VA = "0x1805E4000")]
	[IteratorStateMachine(typeof(_003CMoveContentImpl_003Ed__47))]
	protected IEnumerator MoveContentImpl()
	{
		return null;
	}

	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x5E37D0", Offset = "0x5E29D0", VA = "0x1805E37D0")]
	public void ActiveAnalogPadScroll(SelectorManager.AnalogType analogType)
	{
	}

	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x5E4A00", Offset = "0x5E3C00", VA = "0x1805E4A00")]
	private void SetTargetAlpha(GameObject target, float alpha)
	{
	}

	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x5E4AA0", Offset = "0x5E3CA0", VA = "0x1805E4AA0")]
	private void ShowScrollBar()
	{
	}

	[Token(Token = "0x6001B59")]
	[Address(RVA = "0x5E3890", Offset = "0x5E2A90", VA = "0x1805E3890")]
	private void HideScrollBar()
	{
	}

	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x5E4EE0", Offset = "0x5E40E0", VA = "0x1805E4EE0", Slot = "41")]
	public override void StopMovement()
	{
	}

	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x5E49A0", Offset = "0x5E3BA0", VA = "0x1805E49A0")]
	public void ScrollByVerticalNormalizedPos(float dst, bool overrideTarget = true)
	{
	}

	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x5E4630", Offset = "0x5E3830", VA = "0x1805E4630")]
	public void ScrollByHorizontalNormalizedPos(float dst, bool overrideTarget = true)
	{
	}

	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x5E4680", Offset = "0x5E3880", VA = "0x1805E4680")]
	public void ScrollByNormalizedPos(Vector2 dst, bool overrideTarget = true)
	{
	}

	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x5E40C0", Offset = "0x5E32C0", VA = "0x1805E40C0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0x5E5470", Offset = "0x5E4670", VA = "0x1805E5470")]
	public ExtendedScrollRect()
	{
	}
}
