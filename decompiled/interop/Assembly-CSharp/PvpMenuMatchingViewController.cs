using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000072")]
public class PvpMenuMatchingViewController : PvpMenuMatchingViewControllerBase
{
	[Token(Token = "0x2000073")]
	public enum View
	{
		[Token(Token = "0x4000258")]
		SEARCHING,
		[Token(Token = "0x4000259")]
		MATCHING,
		[Token(Token = "0x400025A")]
		TIMEOUT
	}

	[Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class _003CyMatch_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController _003C_003E4__this;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CieWaitMatching_003E5__2;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CreachLimitTime_003E5__3;

		[Token(Token = "0x17000029")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMatch_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3FF4D0", Offset = "0x3FE6D0", VA = "0x1803FF4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x400020", Offset = "0x3FF220", VA = "0x180400020", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class _003CyPopView_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController _003C_003E4__this;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x28")]
		private float _003CpastSec_003E5__2;

		[Token(Token = "0x1700002B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPopView_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x400870", Offset = "0x3FFA70", VA = "0x180400870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x400A90", Offset = "0x3FFC90", VA = "0x180400A90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x108")]
	private readonly string BTN_CANCEL_LABEL;

	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x110")]
	private readonly string BTN_BACK_LABEL;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x118")]
	private readonly string BTN_RESEARCH_LABEL;

	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x120")]
	private readonly string TXT_TIME_LABEL;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TXT_TIPS_LABEL;

	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x130")]
	private readonly string ROOT_SEARCH_LABEL;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x138")]
	private readonly string ROOT_MATCH_LABEL;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x140")]
	private readonly string ROOT_TIMEOUT_LABEL;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x148")]
	private readonly string IMG_RANK_LABEL;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x150")]
	private readonly string IMG_EVENT_LABEL;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x158")]
	private readonly string IMG_FREE_LABEL;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x160")]
	private bool m_bRequestBack;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x161")]
	private bool m_bRequestResearch;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x162")]
	private bool m_bIsDispTimeout;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x164")]
	private float m_ResearchTime;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x168")]
	private DefinitionSetting m_MatchingDefine;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x170")]
	private ExtendedTextMeshProUGUI m_TextTime;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x178")]
	private float m_StartTime;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x180")]
	private GameObject m_rootSearch;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x188")]
	private GameObject m_rootMatch;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x190")]
	private GameObject m_rootTimeout;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x198")]
	private IEnumerator m_yPopViewRoutine;

	[Token(Token = "0x4000254")]
	private const float LIMIT_POP_TIME = 15f;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x1A0")]
	private string m_LastBgmLabel;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x1A8")]
	private View m_currentView;

	[Token(Token = "0x17000028")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x3F7B70", Offset = "0x3F6D70", VA = "0x1803F7B70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x3F4D90", Offset = "0x3F3F90", VA = "0x1803F4D90", Slot = "29")]
	protected override void Init()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x3F5010", Offset = "0x3F4210", VA = "0x1803F5010", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x3F6530", Offset = "0x3F5730", VA = "0x1803F6530")]
	private void SetActiveView(View state)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x3F4CA0", Offset = "0x3F3EA0", VA = "0x1803F4CA0")]
	private string ConvertDispTime(float elapsedTime)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x3F7CB0", Offset = "0x3F6EB0", VA = "0x1803F7CB0", Slot = "28")]
	[IteratorStateMachine(typeof(_003CyMatch_003Ed__32))]
	protected override IEnumerator yMatch()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x3F7030", Offset = "0x3F6230", VA = "0x1803F7030")]
	private void Update()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x3F4EF0", Offset = "0x3F40F0", VA = "0x1803F4EF0")]
	public void OnClickBackButton(bool requestBack = true)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x3F7D20", Offset = "0x3F6F20", VA = "0x1803F7D20")]
	[IteratorStateMachine(typeof(_003CyPopView_003Ed__35))]
	private IEnumerator yPopView()
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x3F7920", Offset = "0x3F6B20", VA = "0x1803F7920")]
	public PvpMenuMatchingViewController()
	{
	}
}
