using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013D7")]
public class TitleDemoViewController : BaseMenuViewController
{
	[Token(Token = "0x20013D8")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x400C3FA")]
		[FieldOffset(Offset = "0x10")]
		public bool waitLoadSysSE;

		[Token(Token = "0x6007B62")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6007B63")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CplayDemo_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20013D9")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_1
	{
		[Token(Token = "0x400C3FB")]
		[FieldOffset(Offset = "0x10")]
		public bool isSkipped;

		[Token(Token = "0x400C3FC")]
		[FieldOffset(Offset = "0x11")]
		public bool waitDemo;

		[Token(Token = "0x6007B64")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_1()
		{
		}

		[Token(Token = "0x6007B65")]
		[Address(RVA = "0x997550", Offset = "0x996750", VA = "0x180997550")]
		internal void _003CplayDemo_003Eb__1(bool _isSkipped)
		{
		}
	}

	[Token(Token = "0x20013DA")]
	[CompilerGenerated]
	private sealed class _003CplayDemo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3FD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3FE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3FF")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x400C400")]
		[FieldOffset(Offset = "0x28")]
		public TitleDemoViewController _003C_003E4__this;

		[Token(Token = "0x400C401")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_1 _003C_003E8__2;

		[Token(Token = "0x170012F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007B69")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007B6B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007B66")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CplayDemo_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007B67")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007B68")]
		[Address(RVA = "0xC508C0", Offset = "0xC4FAC0", VA = "0x180C508C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007B6A")]
		[Address(RVA = "0xC50C60", Offset = "0xC4FE60", VA = "0x180C50C60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3F9")]
	[FieldOffset(Offset = "0xD0")]
	private string m_scenarioName;

	[Token(Token = "0x6007B5C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void debugLog(string msg)
	{
	}

	[Token(Token = "0x6007B5D")]
	[Address(RVA = "0xC4A230", Offset = "0xC49430", VA = "0x180C4A230", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007B5E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007B5F")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007B60")]
	[Address(RVA = "0xC4A310", Offset = "0xC49510", VA = "0x180C4A310")]
	[IteratorStateMachine(typeof(_003CplayDemo_003Ed__5))]
	private IEnumerator playDemo()
	{
		return null;
	}

	[Token(Token = "0x6007B61")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TitleDemoViewController()
	{
	}
}
