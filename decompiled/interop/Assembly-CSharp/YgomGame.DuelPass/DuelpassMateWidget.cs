using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ED6")]
public class DuelpassMateWidget
{
	[Token(Token = "0x2000ED7")]
	[CompilerGenerated]
	private sealed class _003CMateSwapCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A4FA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A4FB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A4FC")]
		[FieldOffset(Offset = "0x20")]
		public DuelpassMateWidget _003C_003E4__this;

		[Token(Token = "0x400A4FD")]
		[FieldOffset(Offset = "0x28")]
		private float _003CswapTime_003E5__2;

		[Token(Token = "0x400A4FE")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CelapsedTime_003E5__3;

		[Token(Token = "0x400A4FF")]
		[FieldOffset(Offset = "0x30")]
		private int _003CmateIdx_003E5__4;

		[Token(Token = "0x17000DE4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60059F8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DE5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60059FA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CMateSwapCoroutine_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x9FC970", Offset = "0x9FBB70", VA = "0x1809FC970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60059F9")]
		[Address(RVA = "0x9FCAE0", Offset = "0x9FBCE0", VA = "0x1809FCAE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A4F6")]
	[FieldOffset(Offset = "0x10")]
	private Transform mateTransform;

	[Token(Token = "0x400A4F7")]
	[FieldOffset(Offset = "0x18")]
	private SelectionButton mateButton;

	[Token(Token = "0x400A4F8")]
	[FieldOffset(Offset = "0x20")]
	private List<int> mateIds;

	[Token(Token = "0x400A4F9")]
	[FieldOffset(Offset = "0x28")]
	private Character2D chara;

	[Token(Token = "0x60059EF")]
	[Address(RVA = "0x9EE460", Offset = "0x9ED660", VA = "0x1809EE460")]
	public DuelpassMateWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60059F0")]
	[Address(RVA = "0x9EDD60", Offset = "0x9ECF60", VA = "0x1809EDD60", Slot = "1")]
	~DuelpassMateWidget()
	{
	}

	[Token(Token = "0x60059F1")]
	[Address(RVA = "0x9EDE40", Offset = "0x9ED040", VA = "0x1809EDE40")]
	[IteratorStateMachine(typeof(_003CMateSwapCoroutine_003Ed__6))]
	private IEnumerator MateSwapCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60059F2")]
	[Address(RVA = "0x9EDEB0", Offset = "0x9ED0B0", VA = "0x1809EDEB0")]
	private void SetMate(int id)
	{
	}
}
