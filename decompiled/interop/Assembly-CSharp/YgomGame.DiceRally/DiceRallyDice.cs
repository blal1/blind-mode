using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F8F")]
public class DiceRallyDice
{
	[Token(Token = "0x2000F90")]
	[CompilerGenerated]
	private sealed class _003CyDecideDice_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A8BD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A8BE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A8BF")]
		[FieldOffset(Offset = "0x20")]
		public DiceRallyDice _003C_003E4__this;

		[Token(Token = "0x400A8C0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject fadeBg;

		[Token(Token = "0x400A8C1")]
		[FieldOffset(Offset = "0x30")]
		public Action onFinished;

		[Token(Token = "0x400A8C2")]
		[FieldOffset(Offset = "0x38")]
		private float _003Cspan_003E5__2;

		[Token(Token = "0x400A8C3")]
		[FieldOffset(Offset = "0x3C")]
		private bool _003CisTurned_003E5__3;

		[Token(Token = "0x17000EE4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E66")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E68")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E63")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyDecideDice_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E64")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E65")]
		[Address(RVA = "0xA4C120", Offset = "0xA4B320", VA = "0x180A4C120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E67")]
		[Address(RVA = "0xA4C540", Offset = "0xA4B740", VA = "0x180A4C540", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A8B3")]
	[FieldOffset(Offset = "0x10")]
	private int m_Number;

	[Token(Token = "0x400A8B4")]
	[FieldOffset(Offset = "0x14")]
	private int m_StartSE;

	[Token(Token = "0x400A8B5")]
	[FieldOffset(Offset = "0x18")]
	private bool m_Turned;

	[Token(Token = "0x400A8B6")]
	[FieldOffset(Offset = "0x19")]
	private bool m_IsSkip;

	[Token(Token = "0x400A8B7")]
	[FieldOffset(Offset = "0x1A")]
	private bool m_IsPlayedSE;

	[Token(Token = "0x400A8B8")]
	[FieldOffset(Offset = "0x1B")]
	private bool m_IsPlaying;

	[Token(Token = "0x400A8B9")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_Dice;

	[Token(Token = "0x400A8BA")]
	[FieldOffset(Offset = "0x28")]
	private SelectionButton m_SkipButton;

	[Token(Token = "0x400A8BB")]
	[FieldOffset(Offset = "0x30")]
	private PlayableDirector m_Timeline;

	[Token(Token = "0x400A8BC")]
	[FieldOffset(Offset = "0x38")]
	public Vector3[] m_Rots;

	[Token(Token = "0x6005E5D")]
	[Address(RVA = "0xA32320", Offset = "0xA31520", VA = "0x180A32320")]
	public void RollDice(int num, GameObject fadeBg)
	{
	}

	[Token(Token = "0x6005E5E")]
	[Address(RVA = "0x444C90", Offset = "0x443E90", VA = "0x180444C90")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E5F")]
	[Address(RVA = "0xA327C0", Offset = "0xA319C0", VA = "0x180A327C0")]
	[IteratorStateMachine(typeof(_003CyDecideDice_003Ed__12))]
	public IEnumerator yDecideDice(Action onFinished, GameObject fadeBg)
	{
		return null;
	}

	[Token(Token = "0x6005E60")]
	[Address(RVA = "0xA325A0", Offset = "0xA317A0", VA = "0x180A325A0")]
	public void SetSkipButton(SelectionButton sb)
	{
	}

	[Token(Token = "0x6005E61")]
	[Address(RVA = "0xA32690", Offset = "0xA31890", VA = "0x180A32690")]
	public DiceRallyDice()
	{
	}
}
