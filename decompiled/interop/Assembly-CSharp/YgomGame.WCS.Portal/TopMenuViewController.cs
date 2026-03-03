using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000774")]
public class TopMenuViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000775")]
	private enum OpenStatus
	{
		[Token(Token = "0x4002565")]
		Before,
		[Token(Token = "0x4002566")]
		Open,
		[Token(Token = "0x4002567")]
		After
	}

	[Token(Token = "0x2000778")]
	[CompilerGenerated]
	private sealed class _003CloadIconImage_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x20")]
		public Image imageUI;

		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x28")]
		public string imagePath;

		[Token(Token = "0x4002575")]
		[FieldOffset(Offset = "0x30")]
		private IAsyncProgressContent _003Cbinding_003E5__2;

		[Token(Token = "0x1700060B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60030FC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030FE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030F9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloadIconImage_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x75D5A0", Offset = "0x75C7A0", VA = "0x18075D5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x75D6D0", Offset = "0x75C8D0", VA = "0x18075D6D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002554")]
	private const string LABEL_BTN_1STSTAGE = "Button1stStage";

	[Token(Token = "0x4002555")]
	private const string LABEL_BTN_CAMPAIGN = "ButtonCampaign";

	[Token(Token = "0x4002556")]
	private const string LABEL_BTN_TOURNAMENT = "ButtonTournament";

	[Token(Token = "0x4002557")]
	private const string LABEL_BTN_WATCH = "ButtonWatch";

	[Token(Token = "0x4002558")]
	private const string LABEL_BTN_REGULATION = "ButtonRegulation";

	[Token(Token = "0x4002559")]
	private const string LABEL_ROOT_DEFAULTLOGO = "DefaultLogoRoot";

	[Token(Token = "0x400255A")]
	private const string LABEL_ROOT_WINNER = "ResultRoot";

	[Token(Token = "0x400255B")]
	private const string LABEL_IMG_WINNERICON = "ResultTeamGroupIcon";

	[Token(Token = "0x400255C")]
	private const string LABEL_TEXT_WINNERAREA = "TextResultTeamGroup";

	[Token(Token = "0x400255D")]
	private const string LABEL_TEXT_WINNERNAME = "TextResultTeamName";

	[Token(Token = "0x400255E")]
	[FieldOffset(Offset = "0xD0")]
	private int m_winnerTeamID;

	[Token(Token = "0x400255F")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject m_uiDefaultLogoRoot;

	[Token(Token = "0x4002560")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_uiWinnerRoot;

	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject m_ui1stStageRoot;

	[Token(Token = "0x4002562")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject m_uiTournamentRoot;

	[Token(Token = "0x4002563")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_uiVoteRewardBadge;

	[Token(Token = "0x17000609")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x733AF0", Offset = "0x732CF0", VA = "0x180733AF0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060A")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60030E1")]
	[Address(RVA = "0x732EB0", Offset = "0x7320B0", VA = "0x180732EB0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60030E2")]
	[Address(RVA = "0x732EE0", Offset = "0x7320E0", VA = "0x180732EE0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60030E3")]
	[Address(RVA = "0x7333D0", Offset = "0x7325D0", VA = "0x1807333D0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60030E4")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60030E5")]
	[Address(RVA = "0x734640", Offset = "0x733840", VA = "0x180734640")]
	private void updateCampaignInfo(bool isOnCreate)
	{
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0x734180", Offset = "0x733380", VA = "0x180734180")]
	private void updateAllUI(bool isOnCreate)
	{
	}

	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x733EC0", Offset = "0x7330C0", VA = "0x180733EC0")]
	private void setWinnerTeamUI(bool isOnCreate)
	{
	}

	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x733BC0", Offset = "0x732DC0", VA = "0x180733BC0")]
	[IteratorStateMachine(typeof(_003CloadIconImage_003Ed__28))]
	private IEnumerator loadIconImage(Image imageUI, string imagePath)
	{
		return null;
	}

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x733C50", Offset = "0x732E50", VA = "0x180733C50")]
	private void setOpenStatusFooterUI(GameObject root, OpenStatus status, string text)
	{
	}

	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TopMenuViewController()
	{
	}
}
