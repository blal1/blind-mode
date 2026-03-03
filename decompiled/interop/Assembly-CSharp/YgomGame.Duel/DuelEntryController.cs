using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomSystem.Timeline;

namespace YgomGame.Duel;

[Token(Token = "0x200178A")]
public class DuelEntryController
{
	[Token(Token = "0x200178B")]
	private class MatchingUIPrepareFlag
	{
		[Token(Token = "0x400DD3E")]
		[FieldOffset(Offset = "0x10")]
		private bool nomatching;

		[Token(Token = "0x400DD3F")]
		[FieldOffset(Offset = "0x11")]
		private bool lightready;

		[Token(Token = "0x400DD40")]
		[FieldOffset(Offset = "0x12")]
		private byte mateloadedcount;

		[Token(Token = "0x170016A5")]
		public bool isReady
		{
			[Token(Token = "0x6009457")]
			[Address(RVA = "0xDEBDF0", Offset = "0xDEAFF0", VA = "0x180DEBDF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6009458")]
		[Address(RVA = "0x4658A0", Offset = "0x464AA0", VA = "0x1804658A0")]
		public void LightLoaded()
		{
		}

		[Token(Token = "0x6009459")]
		[Address(RVA = "0xDEBDE0", Offset = "0xDEAFE0", VA = "0x180DEBDE0")]
		public void MateLoaded()
		{
		}

		[Token(Token = "0x600945A")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		public void NoMatching()
		{
		}

		[Token(Token = "0x600945B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MatchingUIPrepareFlag()
		{
		}
	}

	[Token(Token = "0x2001790")]
	[CompilerGenerated]
	private sealed class _003CDuelEntryPlayCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DD49")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DD4A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DD4B")]
		[FieldOffset(Offset = "0x20")]
		public DuelEntryController _003C_003E4__this;

		[Token(Token = "0x170016A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009467")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009469")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009464")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDuelEntryPlayCoroutine_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009465")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009466")]
		[Address(RVA = "0xDEEB10", Offset = "0xDEDD10", VA = "0x180DEEB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009468")]
		[Address(RVA = "0xDEEB90", Offset = "0xDEDD90", VA = "0x180DEEB90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DD2B")]
	private const string LABEL_TIMELINE_DUELENTRYPVP = "Duel/Timeline/Duel/Universal/DuelEntry/DuelEntry";

	[Token(Token = "0x400DD2C")]
	private const string LABEL_TIMELINE_DUELENTRYPVP_TEAM = "Duel/Timeline/Duel/Universal/DuelEntry/DuelEntryTeam";

	[Token(Token = "0x400DD2D")]
	private const string LABEL_TIMELINE_DUELENTRYSOLO = "Prefabs/Solo/SoloTransition/SoloTransitionDuelEntry";

	[Token(Token = "0x400DD2E")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_Director;

	[Token(Token = "0x400DD2F")]
	[FieldOffset(Offset = "0x18")]
	private LabeledPlayableController m_LPController;

	[Token(Token = "0x400DD30")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_MateActorParent;

	[Token(Token = "0x400DD31")]
	[FieldOffset(Offset = "0x28")]
	private Character m_MateActorNear;

	[Token(Token = "0x400DD32")]
	[FieldOffset(Offset = "0x30")]
	private Character m_MateActorFar;

	[Token(Token = "0x400DD33")]
	[FieldOffset(Offset = "0x38")]
	private DuelEntryMode m_Mode;

	[Token(Token = "0x400DD34")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_MotionPlayed;

	[Token(Token = "0x400DD35")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_DuelStartCameraCreated;

	[Token(Token = "0x400DD36")]
	[FieldOffset(Offset = "0x3E")]
	private bool m_Cancelled;

	[Token(Token = "0x400DD37")]
	[FieldOffset(Offset = "0x40")]
	private string m_MatepathNear;

	[Token(Token = "0x400DD38")]
	[FieldOffset(Offset = "0x48")]
	private string m_MatepathFar;

	[Token(Token = "0x400DD39")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_LightTemplate;

	[Token(Token = "0x400DD3A")]
	[FieldOffset(Offset = "0x58")]
	private MatchingUIPrepareFlag m_MatchingUIPreapareFlag;

	[Token(Token = "0x400DD3B")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_BackPlane;

	[Token(Token = "0x400DD3C")]
	[FieldOffset(Offset = "0x68")]
	public UnityAction onTimelineStop;

	[Token(Token = "0x400DD3D")]
	[FieldOffset(Offset = "0x70")]
	private DuelEntryTagContainer m_TagContainer;

	[Token(Token = "0x170016A4")]
	public bool IsAlive
	{
		[Token(Token = "0x600943E")]
		[Address(RVA = "0xDE0C60", Offset = "0xDDFE60", VA = "0x180DE0C60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600943F")]
	[Address(RVA = "0xDDE1B0", Offset = "0xDDD3B0", VA = "0x180DDE1B0")]
	public static DuelEntryController Create(DuelEntryMode mode)
	{
		return null;
	}

	[Token(Token = "0x6009440")]
	[Address(RVA = "0xDDE590", Offset = "0xDDD790", VA = "0x180DDE590")]
	private void Initialize(DuelEntryMode mode)
	{
	}

	[Token(Token = "0x6009441")]
	[Address(RVA = "0xDDFE90", Offset = "0xDDF090", VA = "0x180DDFE90")]
	private void SetBaseTimelineEvent()
	{
	}

	[Token(Token = "0x6009442")]
	[Address(RVA = "0xDDFC10", Offset = "0xDDEE10", VA = "0x180DDFC10")]
	public void Release()
	{
	}

	[Token(Token = "0x6009443")]
	[Address(RVA = "0xDDE220", Offset = "0xDDD420", VA = "0x180DDE220")]
	[IteratorStateMachine(typeof(_003CDuelEntryPlayCoroutine_003Ed__26))]
	private IEnumerator DuelEntryPlayCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6009444")]
	[Address(RVA = "0xDDEC30", Offset = "0xDDDE30", VA = "0x180DDEC30")]
	public void OnLoadEnd()
	{
	}

	[Token(Token = "0x6009445")]
	[Address(RVA = "0xDDEBE0", Offset = "0xDDDDE0", VA = "0x180DDEBE0")]
	public void OnFirstMoveDecide()
	{
	}

	[Token(Token = "0x6009446")]
	[Address(RVA = "0xDDEC80", Offset = "0xDDDE80", VA = "0x180DDEC80")]
	private void PlayTimeline()
	{
	}

	[Token(Token = "0x6009447")]
	[Address(RVA = "0xDDF490", Offset = "0xDDE690", VA = "0x180DDF490")]
	private void PrepareMatchingUI()
	{
	}

	[Token(Token = "0x6009448")]
	[Address(RVA = "0xDDF370", Offset = "0xDDE570", VA = "0x180DDF370")]
	private void PrepareLight()
	{
	}

	[Token(Token = "0x6009449")]
	[Address(RVA = "0xDDF730", Offset = "0xDDE930", VA = "0x180DDF730")]
	private void PrepareMate()
	{
	}

	[Token(Token = "0x600944A")]
	[Address(RVA = "0xDDFA80", Offset = "0xDDEC80", VA = "0x180DDFA80")]
	private void PrepareTag()
	{
	}

	[Token(Token = "0x600944B")]
	[Address(RVA = "0xDDE790", Offset = "0xDDD990", VA = "0x180DDE790")]
	private void MateInitialize(Character mateActor, int mateid, string matepath, bool isnear)
	{
	}

	[Token(Token = "0x600944C")]
	[Address(RVA = "0xDDE290", Offset = "0xDDD490", VA = "0x180DDE290")]
	private int GetMateId(bool isnear)
	{
		return default(int);
	}

	[Token(Token = "0x600944D")]
	[Address(RVA = "0xDDDC40", Offset = "0xDDCE40", VA = "0x180DDDC40")]
	private void CreateLight(int playerId)
	{
	}

	[Token(Token = "0x600944E")]
	[Address(RVA = "0xDE06A0", Offset = "0xDDF8A0", VA = "0x180DE06A0")]
	private void SetTeamCard()
	{
	}

	[Token(Token = "0x600944F")]
	[Address(RVA = "0xDDE4F0", Offset = "0xDDD6F0", VA = "0x180DDE4F0")]
	private int GetTeamMrk(int myid)
	{
		return default(int);
	}

	[Token(Token = "0x6009450")]
	[Address(RVA = "0xDE0120", Offset = "0xDDF320", VA = "0x180DE0120")]
	private void SetFlyingCard()
	{
	}

	[Token(Token = "0x6009451")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelEntryController()
	{
	}
}
