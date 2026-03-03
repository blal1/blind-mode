using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D43")]
public class BgEffectStateControl : StateMachineBehaviour
{
	[Token(Token = "0x2001D44")]
	[CompilerGenerated]
	private sealed class _003CSyncAnimatorEnableTap_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40102E7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40102E8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40102E9")]
		[FieldOffset(Offset = "0x20")]
		public BgEffectStateControl _003C_003E4__this;

		[Token(Token = "0x40102EA")]
		[FieldOffset(Offset = "0x28")]
		public BgEffectSettingInner setting;

		[Token(Token = "0x17001BFF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BBF1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C00")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BBF3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BBEE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSyncAnimatorEnableTap_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BBEF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BBF0")]
		[Address(RVA = "0x57AEF0", Offset = "0x57A0F0", VA = "0x18057AEF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BBF2")]
		[Address(RVA = "0x57AFE0", Offset = "0x57A1E0", VA = "0x18057AFE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40102E3")]
	[FieldOffset(Offset = "0x18")]
	public bool syncAnimatorEnableTap;

	[Token(Token = "0x40102E4")]
	[FieldOffset(Offset = "0x1C")]
	public float syncAnimatorEnableTapDelay;

	[Token(Token = "0x40102E5")]
	[FieldOffset(Offset = "0x20")]
	public bool useEnterRandom;

	[Token(Token = "0x40102E6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public List<string> triggerNames;

	[Token(Token = "0x600BBEB")]
	[Address(RVA = "0x567220", Offset = "0x566420", VA = "0x180567220", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600BBEC")]
	[Address(RVA = "0x567770", Offset = "0x566970", VA = "0x180567770")]
	[IteratorStateMachine(typeof(_003CSyncAnimatorEnableTap_003Ed__5))]
	private IEnumerator SyncAnimatorEnableTap(BgEffectSettingInner setting)
	{
		return null;
	}

	[Token(Token = "0x600BBED")]
	[Address(RVA = "0x567800", Offset = "0x566A00", VA = "0x180567800")]
	public BgEffectStateControl()
	{
	}
}
