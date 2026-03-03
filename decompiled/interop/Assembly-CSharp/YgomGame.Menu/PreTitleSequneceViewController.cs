using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x200122F")]
public class PreTitleSequneceViewController : BaseMenuViewController
{
	[Token(Token = "0x2001230")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x400BA78")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x600714C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600714D")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CwaitChildVC_003Eb__0(int _result)
		{
		}
	}

	[Token(Token = "0x2001231")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x400BA79")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x600714E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600714F")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CwaitOnDemandLogo_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001232")]
	[CompilerGenerated]
	private sealed class _003Csequence_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA7A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA7B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA7C")]
		[FieldOffset(Offset = "0x20")]
		public PreTitleSequneceViewController _003C_003E4__this;

		[Token(Token = "0x170011D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007153")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007155")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007150")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003Csequence_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007151")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007152")]
		[Address(RVA = "0xB80420", Offset = "0xB7F620", VA = "0x180B80420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007154")]
		[Address(RVA = "0xB80710", Offset = "0xB7F910", VA = "0x180B80710", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001233")]
	[CompilerGenerated]
	private sealed class _003CwaitChildVC_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA7D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA7E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA7F")]
		[FieldOffset(Offset = "0x20")]
		public PreTitleSequneceViewController _003C_003E4__this;

		[Token(Token = "0x400BA80")]
		[FieldOffset(Offset = "0x28")]
		public string prefabPath;

		[Token(Token = "0x400BA81")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x170011D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007159")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600715B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007156")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitChildVC_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007157")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007158")]
		[Address(RVA = "0xB86060", Offset = "0xB85260", VA = "0x180B86060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600715A")]
		[Address(RVA = "0xB86270", Offset = "0xB85470", VA = "0x180B86270", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001234")]
	[CompilerGenerated]
	private sealed class _003CwaitOnDemandLogo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA82")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA83")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA84")]
		[FieldOffset(Offset = "0x20")]
		public OnDemandLogoOrder odlogo;

		[Token(Token = "0x400BA85")]
		[FieldOffset(Offset = "0x28")]
		public PreTitleSequneceViewController _003C_003E4__this;

		[Token(Token = "0x400BA86")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x400BA87")]
		[FieldOffset(Offset = "0x38")]
		private List<OnDemandLogoData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x170011DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007160")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007162")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600715C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitOnDemandLogo_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600715D")]
		[Address(RVA = "0xB86740", Offset = "0xB85940", VA = "0x180B86740", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600715E")]
		[Address(RVA = "0xB862B0", Offset = "0xB854B0", VA = "0x180B862B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600715F")]
		[Address(RVA = "0xB867D0", Offset = "0xB859D0", VA = "0x180B867D0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6007161")]
		[Address(RVA = "0xB86700", Offset = "0xB85900", VA = "0x180B86700", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6007145")]
	[Address(RVA = "0xB7CA20", Offset = "0xB7BC20", VA = "0x180B7CA20", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007146")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007147")]
	[Address(RVA = "0xB70F20", Offset = "0xB70120", VA = "0x180B70F20", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007148")]
	[Address(RVA = "0xB7CC00", Offset = "0xB7BE00", VA = "0x180B7CC00")]
	[IteratorStateMachine(typeof(_003Csequence_003Ed__3))]
	private IEnumerator sequence()
	{
		return null;
	}

	[Token(Token = "0x6007149")]
	[Address(RVA = "0xB7CC70", Offset = "0xB7BE70", VA = "0x180B7CC70")]
	[IteratorStateMachine(typeof(_003CwaitChildVC_003Ed__4))]
	private IEnumerator waitChildVC(string prefabPath)
	{
		return null;
	}

	[Token(Token = "0x600714A")]
	[Address(RVA = "0xB7CD00", Offset = "0xB7BF00", VA = "0x180B7CD00")]
	[IteratorStateMachine(typeof(_003CwaitOnDemandLogo_003Ed__5))]
	private IEnumerator waitOnDemandLogo(OnDemandLogoOrder odlogo)
	{
		return null;
	}

	[Token(Token = "0x600714B")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public PreTitleSequneceViewController()
	{
	}
}
