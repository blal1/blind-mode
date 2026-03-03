using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x200007F")]
public class PvpMenuMatchingViewController_Team : PvpMenuMatchingViewControllerBase
{
	[Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class _003CyMatch_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController_Team _003C_003E4__this;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnumerator _003CieWaitMatching_003E5__2;

		[Token(Token = "0x1700003C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMatch_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x3FECA0", Offset = "0x3FDEA0", VA = "0x1803FECA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x3FF490", Offset = "0x3FE690", VA = "0x1803FF490", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class _003CyPopView_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController_Team _003C_003E4__this;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003CpastSec_003E5__2;

		[Token(Token = "0x1700003E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPopView_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4005E0", Offset = "0x3FF7E0", VA = "0x1804005E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x400830", Offset = "0x3FFA30", VA = "0x180400830", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string BTN_CANCEL_LABEL;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string E_TextSearching;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool m_bCalledPop;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	private bool m_bIsTimeOut;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	private bool m_bIsLeader;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private IEnumerator m_yPopViewRoutine;

	[Token(Token = "0x4000292")]
	private const float LIMIT_POP_TIME = 15f;

	[Token(Token = "0x1700003B")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x3F6D20", Offset = "0x3F5F20", VA = "0x1803F6D20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x3F6760", Offset = "0x3F5960", VA = "0x1803F6760", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x3F6600", Offset = "0x3F5800", VA = "0x1803F6600", Slot = "29")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x3F6EC0", Offset = "0x3F60C0", VA = "0x1803F6EC0", Slot = "28")]
	[IteratorStateMachine(typeof(_003CyMatch_003Ed__11))]
	protected override IEnumerator yMatch()
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x3F6AB0", Offset = "0x3F5CB0", VA = "0x1803F6AB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x3F6610", Offset = "0x3F5810", VA = "0x1803F6610")]
	public void OnClickBackButton()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x3F6F30", Offset = "0x3F6130", VA = "0x1803F6F30")]
	[IteratorStateMachine(typeof(_003CyPopView_003Ed__14))]
	private IEnumerator yPopView()
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x3F68E0", Offset = "0x3F5AE0", VA = "0x1803F68E0")]
	private void PopViewControllerSafety([Optional] UnityAction onSafetyPopAction)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x3F6C90", Offset = "0x3F5E90", VA = "0x1803F6C90")]
	public PvpMenuMatchingViewController_Team()
	{
	}
}
