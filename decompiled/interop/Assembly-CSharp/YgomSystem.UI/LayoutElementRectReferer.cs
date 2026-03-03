using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000532")]
[RequireComponent(typeof(ILayoutElement))]
public class LayoutElementRectReferer : UIBehaviour, ILayoutElement
{
	[Token(Token = "0x2000533")]
	[CompilerGenerated]
	private sealed class _003CDelayedSetDirty_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001955")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001956")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001957")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform rectTransform;

		[Token(Token = "0x1700037D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60021C4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021C6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedSetDirty_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x655660", Offset = "0x654860", VA = "0x180655660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x6556F0", Offset = "0x6548F0", VA = "0x1806556F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001951")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_LayoutPriority;

	[Token(Token = "0x4001952")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform m_SourceLayout;

	[Token(Token = "0x4001953")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_WidthScale;

	[Token(Token = "0x4001954")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_HeightScale;

	[Token(Token = "0x17000371")]
	public RectTransform sourceLayout
	{
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x6499C0", Offset = "0x648BC0", VA = "0x1806499C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000372")]
	public float widthScale
	{
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x649990", Offset = "0x648B90", VA = "0x180649990")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x649A50", Offset = "0x648C50", VA = "0x180649A50")]
		set
		{
		}
	}

	[Token(Token = "0x17000373")]
	public float heightScale
	{
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x6496D0", Offset = "0x6488D0", VA = "0x1806496D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x6499A0", Offset = "0x648BA0", VA = "0x1806499A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000374")]
	private float sourceWidth
	{
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x649930", Offset = "0x648B30", VA = "0x180649930")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000375")]
	private float sourceHeight
	{
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x6498D0", Offset = "0x648AD0", VA = "0x1806498D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000376")]
	public int layoutPriority
	{
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30", Slot = "25")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000377")]
	public float preferredWidth
	{
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x6497E0", Offset = "0x6489E0", VA = "0x1806497E0", Slot = "20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000378")]
	public float preferredHeight
	{
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x6496F0", Offset = "0x6488F0", VA = "0x1806496F0", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000379")]
	public float minWidth
	{
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x6496E0", Offset = "0x6488E0", VA = "0x1806496E0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700037A")]
	public float flexibleWidth
	{
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x6496C0", Offset = "0x6488C0", VA = "0x1806496C0", Slot = "21")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700037B")]
	public float minHeight
	{
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x6496E0", Offset = "0x6488E0", VA = "0x1806496E0", Slot = "22")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700037C")]
	public float flexibleHeight
	{
		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x6496C0", Offset = "0x6488C0", VA = "0x1806496C0", Slot = "24")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	public void CalculateLayoutInputHorizontal()
	{
	}

	[Token(Token = "0x60021BD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public void CalculateLayoutInputVertical()
	{
	}

	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x649530", Offset = "0x648730", VA = "0x180649530")]
	protected void SetDirty()
	{
	}

	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x6494C0", Offset = "0x6486C0", VA = "0x1806494C0")]
	[IteratorStateMachine(typeof(_003CDelayedSetDirty_003Ed__34))]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform)
	{
		return null;
	}

	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x6496A0", Offset = "0x6488A0", VA = "0x1806496A0")]
	public LayoutElementRectReferer()
	{
	}
}
