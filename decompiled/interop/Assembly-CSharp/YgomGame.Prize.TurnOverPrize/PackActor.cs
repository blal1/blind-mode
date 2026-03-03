using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrize;

[Token(Token = "0x2000BAF")]
public class PackActor : ElementWidgetBase
{
	[Token(Token = "0x2000BB0")]
	[CompilerGenerated]
	private sealed class _003CyPlayInConfirm_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40097B9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40097BA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40097BB")]
		[FieldOffset(Offset = "0x20")]
		public PackActor _003C_003E4__this;

		[Token(Token = "0x1700099F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004737")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004739")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004734")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayInConfirm_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004735")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004736")]
		[Address(RVA = "0x915D40", Offset = "0x914F40", VA = "0x180915D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004738")]
		[Address(RVA = "0x915E30", Offset = "0x915030", VA = "0x180915E30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40097B1")]
	private const string k_ELabelPackSprite = "PackSprite";

	[Token(Token = "0x40097B2")]
	private const string k_ELabelCoverSprite = "CoverSprite";

	[Token(Token = "0x40097B3")]
	private const string k_ELabelArrowSprite = "ArrowSprite";

	[Token(Token = "0x40097B4")]
	private const string k_TLabelIn = "In";

	[Token(Token = "0x40097B5")]
	private const string k_TLabelLoop = "Loop";

	[Token(Token = "0x40097B6")]
	private const string k_TLabelOut = "Out";

	[Token(Token = "0x40097B7")]
	[FieldOffset(Offset = "0x20")]
	private readonly PlayableDirector m_PlayableDirector;

	[Token(Token = "0x40097B8")]
	[FieldOffset(Offset = "0x28")]
	private readonly LabeledPlayableController m_LabeledController;

	[Token(Token = "0x1700099B")]
	public SelectionButton button
	{
		[Token(Token = "0x600472B")]
		[Address(RVA = "0x902FB0", Offset = "0x9021B0", VA = "0x180902FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099C")]
	public SpriteRenderer packSprite
	{
		[Token(Token = "0x600472C")]
		[Address(RVA = "0x903070", Offset = "0x902270", VA = "0x180903070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099D")]
	public SpriteRenderer coverSprite
	{
		[Token(Token = "0x600472D")]
		[Address(RVA = "0x903010", Offset = "0x902210", VA = "0x180903010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099E")]
	public SpriteRenderer arrowSprite
	{
		[Token(Token = "0x600472E")]
		[Address(RVA = "0x902F50", Offset = "0x902150", VA = "0x180902F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600472F")]
	[Address(RVA = "0x902EC0", Offset = "0x9020C0", VA = "0x180902EC0")]
	public PackActor(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004730")]
	[Address(RVA = "0x902DC0", Offset = "0x901FC0", VA = "0x180902DC0")]
	public void PlayInConfirm()
	{
	}

	[Token(Token = "0x6004731")]
	[Address(RVA = "0x9030D0", Offset = "0x9022D0", VA = "0x1809030D0")]
	[IteratorStateMachine(typeof(_003CyPlayInConfirm_003Ed__18))]
	private IEnumerator yPlayInConfirm()
	{
		return null;
	}

	[Token(Token = "0x6004732")]
	[Address(RVA = "0x902E60", Offset = "0x902060", VA = "0x180902E60")]
	public void PlayOutConfirm()
	{
	}

	[Token(Token = "0x6004733")]
	[Address(RVA = "0x902D70", Offset = "0x901F70", VA = "0x180902D70")]
	public bool IsPlayingOut()
	{
		return default(bool);
	}
}
