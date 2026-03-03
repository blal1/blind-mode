using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013C7")]
public class PvpMenuMatchingTournament : PvpMenuMatchingBase
{
	[Token(Token = "0x20013C8")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3C0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3C1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3C2")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingTournament _003C_003E4__this;

		[Token(Token = "0x400C3C3")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007B05")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007B07")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007B02")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007B03")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007B04")]
		[Address(RVA = "0xC52C50", Offset = "0xC51E50", VA = "0x180C52C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007B06")]
		[Address(RVA = "0xC52DB0", Offset = "0xC51FB0", VA = "0x180C52DB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3BE")]
	[FieldOffset(Offset = "0x40")]
	public bool goto_cpu;

	[Token(Token = "0x400C3BF")]
	[FieldOffset(Offset = "0x44")]
	private int tid;

	[Token(Token = "0x6007AFC")]
	[Address(RVA = "0xC47430", Offset = "0xC46630", VA = "0x180C47430", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AFD")]
	[Address(RVA = "0xC476F0", Offset = "0xC468F0", VA = "0x180C476F0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__3))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007AFE")]
	[Address(RVA = "0xC47330", Offset = "0xC46530", VA = "0x180C47330", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AFF")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingTournament()
	{
	}
}
