using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F91")]
public class DiceRallyEffectDialogViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x2000F92")]
	[CompilerGenerated]
	private sealed class _003CyEffect_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A8F6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A8F7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A8F8")]
		[FieldOffset(Offset = "0x20")]
		public DiceRallyEffectDialogViewController _003C_003E4__this;

		[Token(Token = "0x400A8F9")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cframe_003E5__2;

		[Token(Token = "0x17000EE6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E7A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E7C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E77")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyEffect_003Ed__60(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E78")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E79")]
		[Address(RVA = "0xA4DF00", Offset = "0xA4D100", VA = "0x180A4DF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0xA4E0D0", Offset = "0xA4D2D0", VA = "0x180A4E0D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A8C4")]
	private const string k_ArgsKeySpace = "Space";

	[Token(Token = "0x400A8C5")]
	private const string k_ArgsKeyOnFinished = "OnFinished";

	[Token(Token = "0x400A8C6")]
	private const string k_ArgsKeyLap = "Lap";

	[Token(Token = "0x400A8C7")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string CARD_HOLDER_LABEL;

	[Token(Token = "0x400A8C8")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string PREMIUM_HOLDER_LABEL;

	[Token(Token = "0x400A8C9")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string MIGHTY_HOLDER_LABEL;

	[Token(Token = "0x400A8CA")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string EFFECT_HOLDER_LABEL;

	[Token(Token = "0x400A8CB")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string GOAL_HOLDER_LABEL;

	[Token(Token = "0x400A8CC")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string IMG_CARD_LABEL;

	[Token(Token = "0x400A8CD")]
	[FieldOffset(Offset = "0x100")]
	private readonly string IMG_CARD_BACK_LABEL;

	[Token(Token = "0x400A8CE")]
	[FieldOffset(Offset = "0x108")]
	private readonly string ICON_RARITY_LABEL;

	[Token(Token = "0x400A8CF")]
	[FieldOffset(Offset = "0x110")]
	private readonly string EFFECT_DUEL_LABEL;

	[Token(Token = "0x400A8D0")]
	[FieldOffset(Offset = "0x118")]
	private readonly string ICON_CARD_PLUS_LABEL;

	[Token(Token = "0x400A8D1")]
	[FieldOffset(Offset = "0x120")]
	private readonly string ICON_LP_HALF_LABEL;

	[Token(Token = "0x400A8D2")]
	[FieldOffset(Offset = "0x128")]
	private readonly string ICON_TIME_HALF_LABEL;

	[Token(Token = "0x400A8D3")]
	[FieldOffset(Offset = "0x130")]
	private readonly string EFFECT_MAP_PLUS_LABEL;

	[Token(Token = "0x400A8D4")]
	[FieldOffset(Offset = "0x138")]
	private readonly string ICON_PLUS_1_LABEL;

	[Token(Token = "0x400A8D5")]
	[FieldOffset(Offset = "0x140")]
	private readonly string ICON_PLUS_2_LABEL;

	[Token(Token = "0x400A8D6")]
	[FieldOffset(Offset = "0x148")]
	private readonly string EFFECT_RARITY_UP_LABEL;

	[Token(Token = "0x400A8D7")]
	[FieldOffset(Offset = "0x150")]
	private readonly string BTN_CLOSE_LABEL;

	[Token(Token = "0x400A8D8")]
	[FieldOffset(Offset = "0x158")]
	private readonly string BTN_SKIP_LABEL;

	[Token(Token = "0x400A8D9")]
	[FieldOffset(Offset = "0x160")]
	private readonly string DESC_TXT_LABEL;

	[Token(Token = "0x400A8DA")]
	[FieldOffset(Offset = "0x168")]
	private readonly string EFFECT_THUNDER_LABEL;

	[Token(Token = "0x400A8DB")]
	[FieldOffset(Offset = "0x170")]
	private int m_LapMax;

	[Token(Token = "0x400A8DC")]
	[FieldOffset(Offset = "0x174")]
	private float delta;

	[Token(Token = "0x400A8DD")]
	[FieldOffset(Offset = "0x178")]
	private bool m_IsClosed;

	[Token(Token = "0x400A8DE")]
	[FieldOffset(Offset = "0x179")]
	private bool m_IsCardEffect;

	[Token(Token = "0x400A8DF")]
	[FieldOffset(Offset = "0x17A")]
	private bool m_IsEndEffect;

	[Token(Token = "0x400A8E0")]
	[FieldOffset(Offset = "0x17B")]
	private bool m_IsPlayMighty;

	[Token(Token = "0x400A8E1")]
	[FieldOffset(Offset = "0x180")]
	private DiceRallySpace m_Space;

	[Token(Token = "0x400A8E2")]
	[FieldOffset(Offset = "0x188")]
	private ElementObjectManager m_CardEom;

	[Token(Token = "0x400A8E3")]
	[FieldOffset(Offset = "0x190")]
	private ElementObjectManager m_PremiumEom;

	[Token(Token = "0x400A8E4")]
	[FieldOffset(Offset = "0x198")]
	private ElementObjectManager m_MightyEom;

	[Token(Token = "0x400A8E5")]
	[FieldOffset(Offset = "0x1A0")]
	private ElementObjectManager m_EffectEom;

	[Token(Token = "0x400A8E6")]
	[FieldOffset(Offset = "0x1A8")]
	private ElementObjectManager m_GoalEom;

	[Token(Token = "0x400A8E7")]
	[FieldOffset(Offset = "0x1B0")]
	private GameObject m_EffectMapPlus;

	[Token(Token = "0x400A8E8")]
	[FieldOffset(Offset = "0x1B8")]
	private GameObject m_EffectDuel;

	[Token(Token = "0x400A8E9")]
	[FieldOffset(Offset = "0x1C0")]
	private GameObject m_EffectRarityUp;

	[Token(Token = "0x400A8EA")]
	[FieldOffset(Offset = "0x1C8")]
	private GameObject m_IconPlus1;

	[Token(Token = "0x400A8EB")]
	[FieldOffset(Offset = "0x1D0")]
	private GameObject m_IconPlus2;

	[Token(Token = "0x400A8EC")]
	[FieldOffset(Offset = "0x1D8")]
	private GameObject m_IconCardPlus;

	[Token(Token = "0x400A8ED")]
	[FieldOffset(Offset = "0x1E0")]
	private GameObject m_IconLPHalf;

	[Token(Token = "0x400A8EE")]
	[FieldOffset(Offset = "0x1E8")]
	private GameObject m_IconTimeHalf;

	[Token(Token = "0x400A8EF")]
	[FieldOffset(Offset = "0x1F0")]
	private TextMeshProUGUI m_DescText;

	[Token(Token = "0x400A8F0")]
	[FieldOffset(Offset = "0x1F8")]
	private SelectionButton m_CloseButton;

	[Token(Token = "0x400A8F1")]
	[FieldOffset(Offset = "0x200")]
	private SelectionButton m_SkipButton;

	[Token(Token = "0x400A8F2")]
	[FieldOffset(Offset = "0x208")]
	private Action m_OnFinished;

	[Token(Token = "0x400A8F3")]
	[FieldOffset(Offset = "0x210")]
	private Coroutine m_Coroutine;

	[Token(Token = "0x400A8F4")]
	[FieldOffset(Offset = "0x218")]
	private PlayableDirector m_Pd;

	[Token(Token = "0x400A8F5")]
	[FieldOffset(Offset = "0x220")]
	private TweenAlpha m_TweenThunder;

	[Token(Token = "0x6005E69")]
	[Address(RVA = "0xA33BE0", Offset = "0xA32DE0", VA = "0x180A33BE0")]
	public static void Open(DiceRallySpace space, Action onFinished, int lapCount = 0)
	{
	}

	[Token(Token = "0x6005E6A")]
	[Address(RVA = "0x540540", Offset = "0x53F740", VA = "0x180540540", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005E6B")]
	[Address(RVA = "0xA32C20", Offset = "0xA31E20", VA = "0x180A32C20", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6005E6C")]
	[Address(RVA = "0xA32CB0", Offset = "0xA31EB0", VA = "0x180A32CB0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005E6D")]
	[Address(RVA = "0xA34020", Offset = "0xA33220", VA = "0x180A34020")]
	private void Start()
	{
	}

	[Token(Token = "0x6005E6E")]
	[Address(RVA = "0xA34380", Offset = "0xA33580", VA = "0x180A34380")]
	private void Update()
	{
	}

	[Token(Token = "0x6005E6F")]
	[Address(RVA = "0xA33D40", Offset = "0xA32F40", VA = "0x180A33D40")]
	private void PlaySE()
	{
	}

	[Token(Token = "0x6005E70")]
	[Address(RVA = "0xA328E0", Offset = "0xA31AE0", VA = "0x180A328E0")]
	private string GetViewDesc(DiceRallySpace space)
	{
		return null;
	}

	[Token(Token = "0x6005E71")]
	[Address(RVA = "0xA33EA0", Offset = "0xA330A0", VA = "0x180A33EA0")]
	private void SkipEffect()
	{
	}

	[Token(Token = "0x6005E72")]
	[Address(RVA = "0xA32870", Offset = "0xA31A70", VA = "0x180A32870")]
	private void CloseEffect()
	{
	}

	[Token(Token = "0x6005E73")]
	[Address(RVA = "0xA34890", Offset = "0xA33A90", VA = "0x180A34890")]
	[IteratorStateMachine(typeof(_003CyEffect_003Ed__60))]
	private IEnumerator yEffect()
	{
		return null;
	}

	[Token(Token = "0x6005E74")]
	[Address(RVA = "0xA344D0", Offset = "0xA336D0", VA = "0x180A344D0")]
	public DiceRallyEffectDialogViewController()
	{
	}
}
