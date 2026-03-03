using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A46")]
public class SeasonPointTopMenuViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000A48")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		[Token(Token = "0x4009135")]
		[FieldOffset(Offset = "0x10")]
		public SeasonPointTopMenuViewController _003C_003E4__this;

		[Token(Token = "0x4009136")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> seasonPtTeamDic;

		[Token(Token = "0x4009137")]
		[FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x87B5F0", Offset = "0x87A7F0", VA = "0x18087B5F0")]
		internal void _003COpenDisbandDialog_003Eb__0()
		{
		}

		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x87B760", Offset = "0x87A960", VA = "0x18087B760")]
		internal void _003COpenDisbandDialog_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000A4B")]
	[CompilerGenerated]
	private sealed class _003COpenDisbandDialog_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400913E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400913F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009140")]
		[FieldOffset(Offset = "0x20")]
		public SeasonPointTopMenuViewController _003C_003E4__this;

		[Token(Token = "0x4009141")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		[Token(Token = "0x4009142")]
		[FieldOffset(Offset = "0x30")]
		private FreeTextFilter _003CfreeTextFilter_003E5__2;

		[Token(Token = "0x1700085D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F33")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F35")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COpenDisbandDialog_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x87A4B0", Offset = "0x8796B0", VA = "0x18087A4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x87AA60", Offset = "0x879C60", VA = "0x18087AA60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009113")]
	public const string k_PREF_PATH = "SeasonPoint/SeasonPointTopMenu";

	[Token(Token = "0x4009114")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string CAUTION_TEXT;

	[Token(Token = "0x4009115")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BUTTON_DETAIL_LABEL;

	[Token(Token = "0x4009116")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string BTN_SEASON_RESULT;

	[Token(Token = "0x4009117")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BTN_SEASON_POINT;

	[Token(Token = "0x4009118")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BTN_SEASON_RANKING;

	[Token(Token = "0x4009119")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string BTN_TEAM;

	[Token(Token = "0x400911A")]
	[FieldOffset(Offset = "0x100")]
	private readonly string BTN_WCS;

	[Token(Token = "0x400911B")]
	[FieldOffset(Offset = "0x108")]
	private readonly string ICON_PATH;

	[Token(Token = "0x400911C")]
	[FieldOffset(Offset = "0x110")]
	private readonly string ICON_SEASON_RESULT;

	[Token(Token = "0x400911D")]
	[FieldOffset(Offset = "0x118")]
	private readonly string ICON_SEASON_RANKING;

	[Token(Token = "0x400911E")]
	[FieldOffset(Offset = "0x120")]
	private readonly string ICON_SEASON_POINT;

	[Token(Token = "0x400911F")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TEXT_SEASON_POINT;

	[Token(Token = "0x4009120")]
	[FieldOffset(Offset = "0x130")]
	private readonly string ICON_SEASON_TEAM;

	[Token(Token = "0x4009121")]
	[FieldOffset(Offset = "0x138")]
	private readonly string ICON_WCS;

	[Token(Token = "0x4009122")]
	[FieldOffset(Offset = "0x140")]
	private readonly string IMG_NEWBADGE_LABEL;

	[Token(Token = "0x4009123")]
	[FieldOffset(Offset = "0x148")]
	private TextMeshProUGUI cautionText;

	[Token(Token = "0x4009124")]
	[FieldOffset(Offset = "0x150")]
	private TextMeshProUGUI seasonPointText;

	[Token(Token = "0x4009125")]
	[FieldOffset(Offset = "0x158")]
	private TextMeshProUGUI nameCheckText;

	[Token(Token = "0x4009126")]
	[FieldOffset(Offset = "0x160")]
	private Coroutine coroutine;

	[Token(Token = "0x4009127")]
	[FieldOffset(Offset = "0x168")]
	private int blockCount;

	[Token(Token = "0x4009128")]
	[FieldOffset(Offset = "0x170")]
	private ElementObjectManager seasonPointBtn;

	[Token(Token = "0x4009129")]
	[FieldOffset(Offset = "0x178")]
	private ElementObjectManager seasonPointRankingBtn;

	[Token(Token = "0x400912A")]
	[FieldOffset(Offset = "0x180")]
	private ElementObjectManager seasonPointResultBtn;

	[Token(Token = "0x400912B")]
	[FieldOffset(Offset = "0x188")]
	private ElementObjectManager teamBtn;

	[Token(Token = "0x400912C")]
	[FieldOffset(Offset = "0x190")]
	private ElementObjectManager wcsBtn;

	[Token(Token = "0x400912D")]
	[FieldOffset(Offset = "0x198")]
	private GameObject teamBtnNewBadge;

	[Token(Token = "0x400912E")]
	[FieldOffset(Offset = "0x1A0")]
	private GameObject wcsBtnNewBadge;

	[Token(Token = "0x400912F")]
	[FieldOffset(Offset = "0x1A8")]
	private bool isRemind;

	[Token(Token = "0x4009130")]
	[FieldOffset(Offset = "0x1A9")]
	private bool isExistTeam;

	[Token(Token = "0x4009131")]
	[FieldOffset(Offset = "0x1AA")]
	private bool isDisband;

	[Token(Token = "0x4009132")]
	[FieldOffset(Offset = "0x1AB")]
	private bool isDisbanded;

	[Token(Token = "0x1700085C")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x876A40", Offset = "0x875C40", VA = "0x180876A40", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F0B")]
	[Address(RVA = "0x875B20", Offset = "0x874D20", VA = "0x180875B20")]
	public static void Open(ViewControllerManager vcm)
	{
	}

	[Token(Token = "0x6003F0C")]
	[Address(RVA = "0x875370", Offset = "0x874570", VA = "0x180875370", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6003F0D")]
	[Address(RVA = "0x875230", Offset = "0x874430", VA = "0x180875230", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003F0E")]
	[Address(RVA = "0x875300", Offset = "0x874500", VA = "0x180875300", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6003F0F")]
	[Address(RVA = "0x875840", Offset = "0x874A40", VA = "0x180875840", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003F10")]
	[Address(RVA = "0x874B90", Offset = "0x873D90", VA = "0x180874B90")]
	private void InitMenuButtons()
	{
	}

	[Token(Token = "0x6003F11")]
	[Address(RVA = "0x875EB0", Offset = "0x8750B0", VA = "0x180875EB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F12")]
	[Address(RVA = "0x876520", Offset = "0x875720", VA = "0x180876520")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6003F13")]
	[Address(RVA = "0x8763F0", Offset = "0x8755F0", VA = "0x1808763F0")]
	private void UpdateBadge()
	{
	}

	[Token(Token = "0x6003F14")]
	[Address(RVA = "0x875B90", Offset = "0x874D90", VA = "0x180875B90")]
	private void SetWCSButtonArea()
	{
	}

	[Token(Token = "0x6003F15")]
	[Address(RVA = "0x875A20", Offset = "0x874C20", VA = "0x180875A20")]
	[IteratorStateMachine(typeof(_003COpenDisbandDialog_003Ed__44))]
	private IEnumerator OpenDisbandDialog()
	{
		return null;
	}

	[Token(Token = "0x6003F16")]
	[Address(RVA = "0x875A90", Offset = "0x874C90", VA = "0x180875A90")]
	private void OpenDisbandToastMessage()
	{
	}

	[Token(Token = "0x6003F17")]
	[Address(RVA = "0x874740", Offset = "0x873940", VA = "0x180874740")]
	private void CallSeasonPtInfoAPI(bool isBack)
	{
	}

	[Token(Token = "0x6003F18")]
	[Address(RVA = "0x874820", Offset = "0x873A20", VA = "0x180874820")]
	private void CallTeamDisbandAPI(Dictionary<string, object> seasonPtTeamDic)
	{
	}

	[Token(Token = "0x6003F19")]
	[Address(RVA = "0x875B70", Offset = "0x874D70", VA = "0x180875B70")]
	private void SetTeamStatus(bool isExistTeam, bool isDisband, bool isDisbanded)
	{
	}

	[Token(Token = "0x6003F1A")]
	[Address(RVA = "0x875590", Offset = "0x874790", VA = "0x180875590")]
	private void OnClickTeamButton()
	{
	}

	[Token(Token = "0x6003F1B")]
	[Address(RVA = "0x8748F0", Offset = "0x873AF0", VA = "0x1808748F0")]
	private bool CheckDisbandable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F1C")]
	[Address(RVA = "0x874B30", Offset = "0x873D30", VA = "0x180874B30")]
	private bool CheckIsWcsPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F1D")]
	[Address(RVA = "0x874AD0", Offset = "0x873CD0", VA = "0x180874AD0")]
	private bool CheckIsRemindWCS()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F1E")]
	[Address(RVA = "0x876760", Offset = "0x875960", VA = "0x180876760")]
	public SeasonPointTopMenuViewController()
	{
	}
}
