using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AC1")]
public class ZoneCardOut : ZoneCard
{
	[Token(Token = "0x2001AC2")]
	[CompilerGenerated]
	private sealed class _003CPlayFinishedCallbackExecuter_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F58A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F58B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F58C")]
		[FieldOffset(Offset = "0x20")]
		public ZoneCardOut _003C_003E4__this;

		[Token(Token = "0x17001AEA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600ADEC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001AEB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600ADEE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600ADE9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayFinishedCallbackExecuter_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600ADEA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600ADEB")]
		[Address(RVA = "0x44F1D0", Offset = "0x44E3D0", VA = "0x18044F1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600ADED")]
		[Address(RVA = "0x44F300", Offset = "0x44E500", VA = "0x18044F300", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F588")]
	[FieldOffset(Offset = "0x60")]
	private List<Action> onPlayFinished;

	[Token(Token = "0x400F589")]
	private const float playedCallbackIntervalTime = 0.1f;

	[Token(Token = "0x600ADE3")]
	[Address(RVA = "0x452C60", Offset = "0x451E60", VA = "0x180452C60")]
	public static ZoneCardOut Create(Zone zone, Mode mode, int index, Action<ZoneCard> onLoadFinished)
	{
		return null;
	}

	[Token(Token = "0x600ADE4")]
	[Address(RVA = "0x452DC0", Offset = "0x451FC0", VA = "0x180452DC0", Slot = "4")]
	public override void Play(int cardID, int uniqueID, bool isFace, Action onPlayFinished)
	{
	}

	[Token(Token = "0x600ADE5")]
	[Address(RVA = "0x452D50", Offset = "0x451F50", VA = "0x180452D50")]
	[IteratorStateMachine(typeof(_003CPlayFinishedCallbackExecuter_003Ed__4))]
	private IEnumerator PlayFinishedCallbackExecuter()
	{
		return null;
	}

	[Token(Token = "0x600ADE6")]
	[Address(RVA = "0x4531D0", Offset = "0x4523D0", VA = "0x1804531D0", Slot = "5")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x600ADE7")]
	[Address(RVA = "0x453320", Offset = "0x452520", VA = "0x180453320")]
	public ZoneCardOut()
	{
	}
}
