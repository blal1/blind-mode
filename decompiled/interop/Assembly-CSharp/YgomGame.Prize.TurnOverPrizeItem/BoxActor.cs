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
using YgomSystem.YGomTMPro;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000B97")]
public class BoxActor : ElementWidgetBase
{
	[Token(Token = "0x2000B98")]
	[CompilerGenerated]
	private sealed class _003CyPlayInConfirm_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009757")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009758")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009759")]
		[FieldOffset(Offset = "0x20")]
		public BoxActor _003C_003E4__this;

		[Token(Token = "0x17000986")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046B3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000987")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046B5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayInConfirm_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x8FBD90", Offset = "0x8FAF90", VA = "0x1808FBD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x8FBE80", Offset = "0x8FB080", VA = "0x1808FBE80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009748")]
	private const string k_ELabelBoxButton = "BoxButton";

	[Token(Token = "0x4009749")]
	private const string k_ELabelCoverSprite = "CoverSprite";

	[Token(Token = "0x400974A")]
	private const string k_ELabelArrowSprite = "ArrowSprite";

	[Token(Token = "0x400974B")]
	private const string k_ELabelEffectSprite = "EffectSprite";

	[Token(Token = "0x400974C")]
	private const string k_ELabelItemTemplate = "ItemLocater";

	[Token(Token = "0x400974D")]
	private const string k_ELabelEffectTemplate = "ItemEffect";

	[Token(Token = "0x400974E")]
	public const string k_ELabelItemLocater = "ItemLocater";

	[Token(Token = "0x400974F")]
	public const string k_ELabelItemNum = "ItemNum";

	[Token(Token = "0x4009750")]
	private const string k_TLabelIn = "In";

	[Token(Token = "0x4009751")]
	private const string k_TLabelLoop = "Loop";

	[Token(Token = "0x4009752")]
	private const string k_TLabelOut = "Out";

	[Token(Token = "0x4009753")]
	[FieldOffset(Offset = "0x20")]
	private readonly PlayableDirector m_PlayableDirector;

	[Token(Token = "0x4009754")]
	[FieldOffset(Offset = "0x28")]
	private readonly LabeledPlayableController m_LabeledController;

	[Token(Token = "0x4009755")]
	[FieldOffset(Offset = "0x30")]
	private SortedDictionary<string, ElementObject>.KeyCollection m_EffectLabels;

	[Token(Token = "0x4009756")]
	[FieldOffset(Offset = "0x38")]
	private SortedDictionary<string, ElementObject>.KeyCollection m_LocaterLabels;

	[Token(Token = "0x17000980")]
	public SelectionButton button
	{
		[Token(Token = "0x600469F")]
		[Address(RVA = "0x8E1820", Offset = "0x8E0A20", VA = "0x1808E1820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000981")]
	public SpriteRenderer coverSprite
	{
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x8E1880", Offset = "0x8E0A80", VA = "0x1808E1880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000982")]
	public SpriteRenderer effectSprite
	{
		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x8E18E0", Offset = "0x8E0AE0", VA = "0x1808E18E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000983")]
	public SpriteRenderer arrowSprite
	{
		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x8E17C0", Offset = "0x8E09C0", VA = "0x1808E17C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000984")]
	public GameObject itemTemplate
	{
		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x8E1990", Offset = "0x8E0B90", VA = "0x1808E1990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000985")]
	public GameObject effectTemplate
	{
		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x8E1940", Offset = "0x8E0B40", VA = "0x1808E1940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60046A5")]
	[Address(RVA = "0x8E16A0", Offset = "0x8E08A0", VA = "0x1808E16A0")]
	public BoxActor(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60046A6")]
	[Address(RVA = "0x8E1180", Offset = "0x8E0380", VA = "0x1808E1180")]
	public void PlayInConfirm()
	{
	}

	[Token(Token = "0x60046A7")]
	[Address(RVA = "0x8E19E0", Offset = "0x8E0BE0", VA = "0x1808E19E0")]
	[IteratorStateMachine(typeof(_003CyPlayInConfirm_003Ed__29))]
	private IEnumerator yPlayInConfirm()
	{
		return null;
	}

	[Token(Token = "0x60046A8")]
	[Address(RVA = "0x8E1220", Offset = "0x8E0420", VA = "0x1808E1220")]
	public void PlayOutConfirm()
	{
	}

	[Token(Token = "0x60046A9")]
	[Address(RVA = "0x8E1130", Offset = "0x8E0330", VA = "0x1808E1130")]
	public bool IsPlayingOut()
	{
		return default(bool);
	}

	[Token(Token = "0x60046AA")]
	[Address(RVA = "0x8E0FB0", Offset = "0x8E01B0", VA = "0x1808E0FB0")]
	public GameObject GetItemLocater(string label)
	{
		return null;
	}

	[Token(Token = "0x60046AB")]
	[Address(RVA = "0x8E1030", Offset = "0x8E0230", VA = "0x1808E1030")]
	public ExtendedTextMeshProUGUI GetItemNumText(string label)
	{
		return null;
	}

	[Token(Token = "0x60046AC")]
	[Address(RVA = "0x8E0F40", Offset = "0x8E0140", VA = "0x1808E0F40")]
	private GameObject GetItemEffect(string label)
	{
		return null;
	}

	[Token(Token = "0x60046AD")]
	[Address(RVA = "0x8E10C0", Offset = "0x8E02C0", VA = "0x1808E10C0")]
	private GameObject GetItemTemplate(string label)
	{
		return null;
	}

	[Token(Token = "0x60046AE")]
	[Address(RVA = "0x8E1490", Offset = "0x8E0690", VA = "0x1808E1490")]
	public bool SetItemEffect(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x60046AF")]
	[Address(RVA = "0x8E1280", Offset = "0x8E0480", VA = "0x1808E1280")]
	public bool SetItemActive(string label)
	{
		return default(bool);
	}
}
