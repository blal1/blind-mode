using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013BB")]
public class PvpMenuMatchingRankEvent : PvpMenuMatchingBase
{
	[Token(Token = "0x20013BC")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3A2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3A3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3A4")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingRankEvent _003C_003E4__this;

		[Token(Token = "0x400C3A5")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007ABB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007ABD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007AB8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007AB9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007ABA")]
		[Address(RVA = "0xC52A30", Offset = "0xC51C30", VA = "0x180C52A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007ABC")]
		[Address(RVA = "0xC52D70", Offset = "0xC51F70", VA = "0x180C52D70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3A0")]
	[FieldOffset(Offset = "0x40")]
	private int rank_event_id;

	[Token(Token = "0x400C3A1")]
	[FieldOffset(Offset = "0x44")]
	private float m_ProgressCount;

	[Token(Token = "0x6007AB1")]
	[Address(RVA = "0xC44930", Offset = "0xC43B30", VA = "0x180C44930", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007AB2")]
	[Address(RVA = "0xC45BC0", Offset = "0xC44DC0", VA = "0x180C45BC0", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AB3")]
	[Address(RVA = "0xC45E80", Offset = "0xC45080", VA = "0x180C45E80", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__3))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007AB4")]
	[Address(RVA = "0xC45AC0", Offset = "0xC44CC0", VA = "0x180C45AC0", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AB5")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingRankEvent()
	{
	}
}
