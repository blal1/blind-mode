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

[Token(Token = "0x2000534")]
[RequireComponent(typeof(ILayoutElement))]
public class LayoutElementScaler : UIBehaviour, ILayoutElement
{
	[Token(Token = "0x2000535")]
	[CompilerGenerated]
	private sealed class _003CDelayedSetDirty_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400195C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400195D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform rectTransform;

		[Token(Token = "0x17000389")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021DE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021D9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedSetDirty_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x655590", Offset = "0x654790", VA = "0x180655590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x655620", Offset = "0x654820", VA = "0x180655620", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001958")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_LayoutPriority;

	[Token(Token = "0x4001959")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_WidthScale;

	[Token(Token = "0x400195A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_HeightScale;

	[Token(Token = "0x400195B")]
	[FieldOffset(Offset = "0x30")]
	private ILayoutElement m_LayoutElementCache;

	[Token(Token = "0x1700037F")]
	public ILayoutElement layoutElement
	{
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x649DC0", Offset = "0x648FC0", VA = "0x180649DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000380")]
	public int layoutPriority
	{
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30", Slot = "25")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000381")]
	public float widthScale
	{
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x64A0A0", Offset = "0x6492A0", VA = "0x18064A0A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x64A0D0", Offset = "0x6492D0", VA = "0x18064A0D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000382")]
	public float heightScale
	{
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x649DB0", Offset = "0x648FB0", VA = "0x180649DB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x64A0B0", Offset = "0x6492B0", VA = "0x18064A0B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000383")]
	public float minWidth
	{
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x649EC0", Offset = "0x6490C0", VA = "0x180649EC0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000384")]
	public float preferredWidth
	{
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x64A000", Offset = "0x649200", VA = "0x18064A000", Slot = "20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000385")]
	public float flexibleWidth
	{
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x649D10", Offset = "0x648F10", VA = "0x180649D10", Slot = "21")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000386")]
	public float minHeight
	{
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x649E20", Offset = "0x649020", VA = "0x180649E20", Slot = "22")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000387")]
	public float preferredHeight
	{
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x649F60", Offset = "0x649160", VA = "0x180649F60", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000388")]
	public float flexibleHeight
	{
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x649C70", Offset = "0x648E70", VA = "0x180649C70", Slot = "24")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60021D4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	public void CalculateLayoutInputHorizontal()
	{
	}

	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public void CalculateLayoutInputVertical()
	{
	}

	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x649AE0", Offset = "0x648CE0", VA = "0x180649AE0")]
	protected void SetDirty()
	{
	}

	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x649A70", Offset = "0x648C70", VA = "0x180649A70")]
	[IteratorStateMachine(typeof(_003CDelayedSetDirty_003Ed__30))]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform)
	{
		return null;
	}

	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x649C50", Offset = "0x648E50", VA = "0x180649C50")]
	public LayoutElementScaler()
	{
	}
}
