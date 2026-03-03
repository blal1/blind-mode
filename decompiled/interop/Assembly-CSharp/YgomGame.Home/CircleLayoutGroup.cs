using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YgomGame.Home;

[Token(Token = "0x2000D43")]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class CircleLayoutGroup : UIBehaviour, ILayoutGroup, ILayoutController
{
	[Token(Token = "0x2000D44")]
	public enum SupportVersion
	{
		[Token(Token = "0x4009E77")]
		OLD,
		[Token(Token = "0x4009E78")]
		NEW
	}

	[Token(Token = "0x2000D45")]
	private enum ChildAlignment
	{
		[Token(Token = "0x4009E7A")]
		LEFT,
		[Token(Token = "0x4009E7B")]
		CENTER,
		[Token(Token = "0x4009E7C")]
		RIGHT
	}

	[Token(Token = "0x2000D46")]
	[CompilerGenerated]
	private sealed class _003CDelayedSetDirty_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009E7D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009E7E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009E7F")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform rectTransform;

		[Token(Token = "0x17000B91")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600504D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B92")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600504F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600504A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedSetDirty_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600504B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600504C")]
		[Address(RVA = "0x979430", Offset = "0x978630", VA = "0x180979430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600504E")]
		[Address(RVA = "0x9794C0", Offset = "0x9786C0", VA = "0x1809794C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009E66")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SupportVersion supportVersion;

	[Token(Token = "0x4009E67")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("中心からの距離")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x4009E68")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 1f)]
	[HideInInspector]
	private float arc;

	[Token(Token = "0x4009E69")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("各子オブジェクト同士の回転角")]
	[SerializeField]
	private float offsetAngle;

	[Token(Token = "0x4009E6A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private Vector2 space;

	[Token(Token = "0x4009E6B")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("並びを反転させるかどうか")]
	[SerializeField]
	private bool reverse;

	[Token(Token = "0x4009E6C")]
	[FieldOffset(Offset = "0x3C")]
	[Tooltip("楕円の幅")]
	[SerializeField]
	[HideInInspector]
	private float circleWidth;

	[Token(Token = "0x4009E6D")]
	[FieldOffset(Offset = "0x40")]
	[Tooltip("楕円の高さ")]
	[SerializeField]
	[HideInInspector]
	private float circleHeight;

	[Token(Token = "0x4009E6E")]
	[FieldOffset(Offset = "0x44")]
	[Tooltip("基準点の初期回転角")]
	[SerializeField]
	[Range(0f, 360f)]
	[HideInInspector]
	private float startAngle;

	[Token(Token = "0x4009E6F")]
	[FieldOffset(Offset = "0x48")]
	[Tooltip("子オブジェクトを並べる基準点")]
	[SerializeField]
	[HideInInspector]
	private ChildAlignment childAlignment;

	[Token(Token = "0x4009E70")]
	[FieldOffset(Offset = "0x4C")]
	[Tooltip("子オブジェクトの初期回転")]
	[SerializeField]
	[Range(-180f, 180f)]
	[HideInInspector]
	private float startRotation;

	[Token(Token = "0x4009E71")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("各子オブジェクト自身の回転、この値ずつ回転させていく")]
	[SerializeField]
	[HideInInspector]
	private float offsetRotation;

	[Token(Token = "0x4009E72")]
	[FieldOffset(Offset = "0x54")]
	[Tooltip("楕円の中心をずらしたい場合に使用")]
	[SerializeField]
	[HideInInspector]
	private Vector2 offsetPos;

	[Token(Token = "0x4009E73")]
	[FieldOffset(Offset = "0x5C")]
	[Tooltip("簡易Autoサイズ調整を有効にする、対象：半円まで調整するのは幅のみ")]
	[SerializeField]
	[HideInInspector]
	private bool fitSize;

	[Token(Token = "0x4009E74")]
	[FieldOffset(Offset = "0x5D")]
	private DrivenRectTransformTracker m_Tracker;

	[NonSerialized]
	[Token(Token = "0x4009E75")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform m_Rect;

	[Token(Token = "0x17000B8F")]
	public SupportVersion Version
	{
		[Token(Token = "0x600503F")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(SupportVersion);
		}
	}

	[Token(Token = "0x17000B90")]
	protected RectTransform OwnRectTransform
	{
		[Token(Token = "0x6005040")]
		[Address(RVA = "0x969020", Offset = "0x968220", VA = "0x180969020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005041")]
	[Address(RVA = "0x968300", Offset = "0x967500", VA = "0x180968300", Slot = "10")]
	protected override void OnRectTransformDimensionsChange()
	{
	}

	[Token(Token = "0x6005042")]
	[Address(RVA = "0x968E40", Offset = "0x968040", VA = "0x180968E40")]
	private void SetDirty()
	{
	}

	[Token(Token = "0x6005043")]
	[Address(RVA = "0x968290", Offset = "0x967490", VA = "0x180968290")]
	[IteratorStateMachine(typeof(_003CDelayedSetDirty_003Ed__24))]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform)
	{
		return null;
	}

	[Token(Token = "0x6005044")]
	[Address(RVA = "0x968E20", Offset = "0x968020", VA = "0x180968E20", Slot = "17")]
	public void SetLayoutHorizontal()
	{
	}

	[Token(Token = "0x6005045")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public void SetLayoutVertical()
	{
	}

	[Token(Token = "0x6005046")]
	[Address(RVA = "0x968E20", Offset = "0x968020", VA = "0x180968E20")]
	private void SetCircleLayout()
	{
	}

	[Token(Token = "0x6005047")]
	[Address(RVA = "0x968440", Offset = "0x967640", VA = "0x180968440")]
	private void SetCircleLayout_New()
	{
	}

	[Token(Token = "0x6005048")]
	[Address(RVA = "0x968B60", Offset = "0x967D60", VA = "0x180968B60")]
	private void SetCircleLayout_Old()
	{
	}

	[Token(Token = "0x6005049")]
	[Address(RVA = "0x968F70", Offset = "0x968170", VA = "0x180968F70")]
	public CircleLayoutGroup()
	{
	}
}
