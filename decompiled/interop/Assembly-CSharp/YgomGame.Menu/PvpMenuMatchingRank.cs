using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013B9")]
public class PvpMenuMatchingRank : PvpMenuMatchingBase
{
	[Token(Token = "0x20013BA")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C39C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C39D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C39E")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingRank _003C_003E4__this;

		[Token(Token = "0x400C39F")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007AAE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007AB0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007AAB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007AAC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007AAD")]
		[Address(RVA = "0xC53160", Offset = "0xC52360", VA = "0x180C53160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007AAF")]
		[Address(RVA = "0xC535C0", Offset = "0xC527C0", VA = "0x180C535C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C399")]
	[FieldOffset(Offset = "0x40")]
	private int seasonId;

	[Token(Token = "0x400C39A")]
	[FieldOffset(Offset = "0x44")]
	private int rentalState;

	[Token(Token = "0x400C39B")]
	[FieldOffset(Offset = "0x48")]
	private float m_ProgressCount;

	[Token(Token = "0x6007AA4")]
	[Address(RVA = "0xC43E80", Offset = "0xC43080", VA = "0x180C43E80", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007AA5")]
	[Address(RVA = "0xC46050", Offset = "0xC45250", VA = "0x180C46050", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AA6")]
	[Address(RVA = "0xC463A0", Offset = "0xC455A0", VA = "0x180C463A0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__4))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007AA7")]
	[Address(RVA = "0xC45F10", Offset = "0xC45110", VA = "0x180C45F10", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AA8")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingRank()
	{
	}
}
