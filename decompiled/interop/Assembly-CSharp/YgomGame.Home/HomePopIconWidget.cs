using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;

namespace YgomGame.Home;

[Token(Token = "0x2000D5D")]
public class HomePopIconWidget
{
	[Token(Token = "0x2000D5E")]
	public enum PopIconType
	{
		[Token(Token = "0x4009EC5")]
		StartingMission = 1,
		[Token(Token = "0x4009EC6")]
		FriendInvitation,
		[Token(Token = "0x4009EC7")]
		DuelPassStart,
		[Token(Token = "0x4009EC8")]
		DuelPassLimit,
		[Token(Token = "0x4009EC9")]
		GemSale
	}

	[Token(Token = "0x2000D60")]
	[CompilerGenerated]
	private sealed class _003CyPlayPop_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomePopIconWidget _003C_003E4__this;

		[Token(Token = "0x4009ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HomeViewController hvc;

		[Token(Token = "0x17000BA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60050B4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60050B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPop_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x97BC40", Offset = "0x97AE40", VA = "0x18097BC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x97C0D0", Offset = "0x97B2D0", VA = "0x18097C0D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000D61")]
	[CompilerGenerated]
	private sealed class _003CyPlayPopIn_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomePopIconWidget _003C_003E4__this;

		[Token(Token = "0x17000BA6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60050BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60050BC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPopIn_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x97B5E0", Offset = "0x97A7E0", VA = "0x18097B5E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x97B910", Offset = "0x97AB10", VA = "0x18097B910", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000D62")]
	[CompilerGenerated]
	private sealed class _003CyPlayPopOut_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomePopIconWidget _003C_003E4__this;

		[Token(Token = "0x17000BA8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60050C0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60050C2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPopOut_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x97B950", Offset = "0x97AB50", VA = "0x18097B950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x97BC00", Offset = "0x97AE00", VA = "0x18097BC00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009EBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string k_TLabel_PopIn;

	[Token(Token = "0x4009EBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string k_TLabel_PopOut;

	[Token(Token = "0x4009EBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Dictionary<PopIconType, GameObject> m_HolderMap;

	[Token(Token = "0x4009EC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<PopIconType, bool> m_ActiveMap;

	[Token(Token = "0x4009EC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<PopIconType, bool> m_LoadingStateMap;

	[Token(Token = "0x4009EC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_Activate;

	[Token(Token = "0x4009EC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine m_TransitionRoutine;

	[Token(Token = "0x17000BA3")]
	public bool enabled
	{
		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60050A1")]
	[Address(RVA = "0x96E7F0", Offset = "0x96D9F0", VA = "0x18096E7F0")]
	public void Assign(PopIconType iconType, GameObject iconHolder)
	{
	}

	[Token(Token = "0x60050A2")]
	[Address(RVA = "0x96EB80", Offset = "0x96DD80", VA = "0x18096EB80")]
	public bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60050A3")]
	[Address(RVA = "0x96F090", Offset = "0x96E290", VA = "0x18096F090")]
	public void UpdateActive(PopIconType iconType, bool activeFlag, [Optional] Action<GameObject> onFinish)
	{
	}

	[Token(Token = "0x60050A4")]
	[Address(RVA = "0x96E7E0", Offset = "0x96D9E0", VA = "0x18096E7E0")]
	public void Activate()
	{
	}

	[Token(Token = "0x60050A5")]
	[Address(RVA = "0x96E860", Offset = "0x96DA60", VA = "0x18096E860")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60050A6")]
	[Address(RVA = "0x96EDB0", Offset = "0x96DFB0", VA = "0x18096EDB0")]
	public void TryPlayPopIn(HomeViewController hvc)
	{
	}

	[Token(Token = "0x60050A7")]
	[Address(RVA = "0x96F440", Offset = "0x96E640", VA = "0x18096F440")]
	[IteratorStateMachine(typeof(_003CyPlayPopIn_003Ed__16))]
	private IEnumerator yPlayPopIn(HomeViewController hvc)
	{
		return null;
	}

	[Token(Token = "0x60050A8")]
	[Address(RVA = "0x96EEA0", Offset = "0x96E0A0", VA = "0x18096EEA0")]
	public void TryPlayPopOut(HomeViewController hvc)
	{
	}

	[Token(Token = "0x60050A9")]
	[Address(RVA = "0x96F4B0", Offset = "0x96E6B0", VA = "0x18096F4B0")]
	[IteratorStateMachine(typeof(_003CyPlayPopOut_003Ed__18))]
	private IEnumerator yPlayPopOut(HomeViewController hvc)
	{
		return null;
	}

	[Token(Token = "0x60050AA")]
	[Address(RVA = "0x96EF90", Offset = "0x96E190", VA = "0x18096EF90")]
	public void TryPlayPop(HomeViewController hvc)
	{
	}

	[Token(Token = "0x60050AB")]
	[Address(RVA = "0x96F520", Offset = "0x96E720", VA = "0x18096F520")]
	[IteratorStateMachine(typeof(_003CyPlayPop_003Ed__20))]
	private IEnumerator yPlayPop(HomeViewController hvc)
	{
		return null;
	}

	[Token(Token = "0x60050AC")]
	[Address(RVA = "0x96E9C0", Offset = "0x96DBC0", VA = "0x18096E9C0")]
	private bool IsPlayingTween(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x60050AD")]
	[Address(RVA = "0x96F300", Offset = "0x96E500", VA = "0x18096F300")]
	public HomePopIconWidget()
	{
	}
}
