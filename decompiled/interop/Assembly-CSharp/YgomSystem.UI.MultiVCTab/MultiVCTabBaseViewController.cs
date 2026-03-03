using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005DC")]
public class MultiVCTabBaseViewController : BaseMenuViewController, IMultiVCTabSupport
{
	[Token(Token = "0x20005DD")]
	[CompilerGenerated]
	private sealed class _003CTweenCheck_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C14")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C15")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C16")]
		[FieldOffset(Offset = "0x20")]
		public MultiVCTabBaseViewController _003C_003E4__this;

		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x28")]
		public TransitionType type;

		[Token(Token = "0x17000492")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002662")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000493")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002664")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600265F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CTweenCheck_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002660")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002661")]
		[Address(RVA = "0x69E7B0", Offset = "0x69D9B0", VA = "0x18069E7B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002663")]
		[Address(RVA = "0x69E900", Offset = "0x69DB00", VA = "0x18069E900", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001C0F")]
	[FieldOffset(Offset = "0xD0")]
	protected MultiVCTabController m_MultiVCTabController;

	[Token(Token = "0x4001C10")]
	[FieldOffset(Offset = "0xD8")]
	private Selector m_TargetSelector;

	[Token(Token = "0x4001C12")]
	[FieldOffset(Offset = "0xE4")]
	private int blockCount;

	[Token(Token = "0x4001C13")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine coroutine;

	[Token(Token = "0x17000490")]
	public Selector targetSelector
	{
		[Token(Token = "0x6002646")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000491")]
	public bool created
	{
		[Token(Token = "0x6002647")]
		[Address(RVA = "0x60ECE0", Offset = "0x60DEE0", VA = "0x18060ECE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x60F490", Offset = "0x60E690", VA = "0x18060F490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002649")]
	[Address(RVA = "0x68EC00", Offset = "0x68DE00", VA = "0x18068EC00")]
	public bool isActiveSelector()
	{
		return default(bool);
	}

	[Token(Token = "0x600264A")]
	[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
	public Selector getSelector()
	{
		return null;
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0x540540", Offset = "0x53F740", VA = "0x180540540")]
	public new void CreateView()
	{
	}

	[Token(Token = "0x600264C")]
	[Address(RVA = "0x68E020", Offset = "0x68D220", VA = "0x18068E020")]
	public void Init()
	{
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0x68E8F0", Offset = "0x68DAF0", VA = "0x18068E8F0")]
	public void SetParentVC(ViewController parent)
	{
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0x68E5A0", Offset = "0x68D7A0", VA = "0x18068E5A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "28")]
	public virtual void OnTabChangedAction()
	{
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "29")]
	protected virtual void OnSwapInAction()
	{
	}

	[Token(Token = "0x6002651")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "30")]
	protected virtual void OnSwapOutAction()
	{
	}

	[Token(Token = "0x6002652")]
	[Address(RVA = "0x68E7A0", Offset = "0x68D9A0", VA = "0x18068E7A0")]
	private void NotifyTransition(TransitionType tt, ViewController vc, ViewController preVc)
	{
	}

	[Token(Token = "0x6002653")]
	[Address(RVA = "0x68E9E0", Offset = "0x68DBE0", VA = "0x18068E9E0")]
	public void TransitionCheck(TransitionType type)
	{
	}

	[Token(Token = "0x6002654")]
	[Address(RVA = "0x68EAC0", Offset = "0x68DCC0", VA = "0x18068EAC0")]
	[IteratorStateMachine(typeof(_003CTweenCheck_003Ed__21))]
	private IEnumerator TweenCheck(TransitionType type)
	{
		return null;
	}

	[Token(Token = "0x6002655")]
	[Address(RVA = "0x68E6F0", Offset = "0x68D8F0", VA = "0x18068E6F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002656")]
	[Address(RVA = "0x68E8D0", Offset = "0x68DAD0", VA = "0x18068E8D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002657")]
	[Address(RVA = "0x68E040", Offset = "0x68D240", VA = "0x18068E040", Slot = "31")]
	protected virtual void Initialize()
	{
	}

	[Token(Token = "0x6002658")]
	[Address(RVA = "0x68DF30", Offset = "0x68D130", VA = "0x18068DF30")]
	protected CurrentMultiVCTabData GetCurrentTabData()
	{
		return null;
	}

	[Token(Token = "0x6002659")]
	[Address(RVA = "0x68E840", Offset = "0x68DA40", VA = "0x18068E840", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600265A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "32")]
	public virtual void SetTransitionFailedCallback(Action callBack)
	{
	}

	[Token(Token = "0x600265B")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public MultiVCTabBaseViewController()
	{
	}
}
