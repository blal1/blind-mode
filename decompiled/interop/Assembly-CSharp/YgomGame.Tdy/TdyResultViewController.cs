using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Tdy;

[Token(Token = "0x200086D")]
public class TdyResultViewController : BaseMenuViewController
{
	[Token(Token = "0x200086E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4008652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPlayingKizuna;

		[Token(Token = "0x600332A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600332B")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CPlayEffect_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200086F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_1
	{
		[Token(Token = "0x4008653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPlayingComplete;

		[Token(Token = "0x600332C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_1()
		{
		}

		[Token(Token = "0x600332D")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CPlayEffect_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000870")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_2
	{
		[Token(Token = "0x4008654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPlayingChain;

		[Token(Token = "0x600332E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_2()
		{
		}

		[Token(Token = "0x600332F")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CPlayEffect_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000871")]
	[CompilerGenerated]
	private sealed class _003CPlayEffect_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TdyResultViewController _003C_003E4__this;

		[Token(Token = "0x4008658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		[Token(Token = "0x4008659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass12_1 _003C_003E8__2;

		[Token(Token = "0x400865A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass12_2 _003C_003E8__3;

		[Token(Token = "0x1700065C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003333")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003335")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003330")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayEffect_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003331")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003332")]
		[Address(RVA = "0x778F90", Offset = "0x778190", VA = "0x180778F90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003334")]
		[Address(RVA = "0x7796A0", Offset = "0x7788A0", VA = "0x1807796A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400864B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string k_ArgKeyOverrideOnBack;

	[Token(Token = "0x400864C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private PlayEffectDesc m_GetKizuna;

	[Token(Token = "0x400864D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<RewardDialogData> m_GetKizunaRewards;

	[Token(Token = "0x400864E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private PlayEffectDesc[] m_ChainEffList;

	[Token(Token = "0x400864F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool m_IsCompleteKizuna;

	[Token(Token = "0x4008650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private List<RewardDialogData> m_CompleteKizunaRewards;

	[Token(Token = "0x4008651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Action m_OverrideOnBack;

	[Token(Token = "0x6003322")]
	[Address(RVA = "0x7785C0", Offset = "0x7777C0", VA = "0x1807785C0")]
	public static void SwapTop(ViewControllerManager vcm, ViewController target, [Optional] Action overrideOnBack)
	{
	}

	[Token(Token = "0x6003323")]
	[Address(RVA = "0x777DE0", Offset = "0x776FE0", VA = "0x180777DE0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003324")]
	[Address(RVA = "0x7784E0", Offset = "0x7776E0", VA = "0x1807784E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003325")]
	[Address(RVA = "0x7784A0", Offset = "0x7776A0", VA = "0x1807784A0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6003326")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6003327")]
	[Address(RVA = "0x778550", Offset = "0x777750", VA = "0x180778550")]
	[IteratorStateMachine(typeof(_003CPlayEffect_003Ed__12))]
	private IEnumerator PlayEffect()
	{
		return null;
	}

	[Token(Token = "0x6003328")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TdyResultViewController()
	{
	}
}
