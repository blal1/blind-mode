using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomGame.DiceRally;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BEF")]
public class ColosseumInfoViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001BF0")]
	protected class DiceRallyBehaviour : ModeBehaviour, ICertificationSupported, IOnBackSupported, INotificationStackRemoveSupported, IOnFocusChangedSupported, INotificationStackSupported, IOnResultSupported, IOutGameBgSupported
	{
		[Token(Token = "0x2001BF1")]
		private class RewardData
		{
			[Token(Token = "0x400FC1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x400FC1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x400FC1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x400FC1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isPeriod;

			[Token(Token = "0x400FC1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int needToken;

			[Token(Token = "0x400FC1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool focus;

			[Token(Token = "0x400FC20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool received;

			[Token(Token = "0x600B5E1")]
			[Address(RVA = "0x4CF990", Offset = "0x4CEB90", VA = "0x1804CF990")]
			public RewardData(int itemCategory, int itemId, int num, bool isPeriod, int needToken, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x2001BF6")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass78_0
		{
			[Token(Token = "0x400FC30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isFinished;

			[Token(Token = "0x400FC31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DiceRallyBehaviour _003C_003E4__this;

			[Token(Token = "0x400FC32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action _003C_003E9__6;

			[Token(Token = "0x600B5F3")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass78_0()
			{
			}

			[Token(Token = "0x600B5F4")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003CyCallAPI_003Eb__0()
			{
			}

			[Token(Token = "0x600B5F5")]
			[Address(RVA = "0x4E3AC0", Offset = "0x4E2CC0", VA = "0x1804E3AC0")]
			internal void _003CyCallAPI_003Eb__3(Handle handle)
			{
			}

			[Token(Token = "0x600B5F6")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003CyCallAPI_003Eb__6()
			{
			}

			[Token(Token = "0x600B5F7")]
			[Address(RVA = "0x4E38F0", Offset = "0x4E2AF0", VA = "0x1804E38F0")]
			internal void _003CyCallAPI_003Eb__4()
			{
			}

			[Token(Token = "0x600B5F8")]
			[Address(RVA = "0x4E3C70", Offset = "0x4E2E70", VA = "0x1804E3C70")]
			internal void _003CyCallAPI_003Eb__5()
			{
			}

			[Token(Token = "0x600B5F9")]
			[Address(RVA = "0x4E38F0", Offset = "0x4E2AF0", VA = "0x1804E38F0")]
			internal void _003CyCallAPI_003Eb__1()
			{
			}

			[Token(Token = "0x600B5FA")]
			[Address(RVA = "0x4E3930", Offset = "0x4E2B30", VA = "0x1804E3930")]
			internal void _003CyCallAPI_003Eb__2()
			{
			}
		}

		[Token(Token = "0x2001BFC")]
		[CompilerGenerated]
		private sealed class _003CyCallAPI_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400FC45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400FC46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400FC47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DiceRallyBehaviour _003C_003E4__this;

			[Token(Token = "0x400FC48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEntry;

			[Token(Token = "0x400FC49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action onComplete;

			[Token(Token = "0x400FC4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass78_0 _003C_003E8__1;

			[Token(Token = "0x400FC4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Dictionary<string, object> _003CmasterInfo_003E5__2;

			[Token(Token = "0x400FC4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int _003Cpoint_003E5__3;

			[Token(Token = "0x17001BD0")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600B610")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001BD1")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600B612")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600B60D")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyCallAPI_003Ed__78(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600B60E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600B60F")]
			[Address(RVA = "0x4E4C80", Offset = "0x4E3E80", VA = "0x1804E4C80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600B611")]
			[Address(RVA = "0x4E5B40", Offset = "0x4E4D40", VA = "0x1804E5B40", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2001BFD")]
		[CompilerGenerated]
		private sealed class _003CyPlaySE_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400FC4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400FC4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400FC4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400FC50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string label;

			[Token(Token = "0x17001BD2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600B616")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001BD3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600B618")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600B613")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlaySE_003Ed__84(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600B614")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600B615")]
			[Address(RVA = "0x4E5B80", Offset = "0x4E4D80", VA = "0x1804E5B80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600B617")]
			[Address(RVA = "0x4E5C60", Offset = "0x4E4E60", VA = "0x1804E5C60", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400FBDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected readonly string OBJ_REWARD_LABEL;

		[Token(Token = "0x400FBE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected readonly string IMG_GAUGE_LABEL;

		[Token(Token = "0x400FBE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		protected readonly string IMG_RECEIVED_LABEL;

		[Token(Token = "0x400FBE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected readonly string IMG_DEFAULT_FRAME_LABEL;

		[Token(Token = "0x400FBE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected readonly string IMG_RECEIVED_FRAME_LABEL;

		[Token(Token = "0x400FBE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected readonly string IMG_EVENT_CATEGORY;

		[Token(Token = "0x400FBE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected readonly string TXT_NEEDTOKEN_LABEL;

		[Token(Token = "0x400FBE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected readonly string TXT_DECK_LABEL;

		[Token(Token = "0x400FBE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected readonly string TXT_PLAY_LABEL;

		[Token(Token = "0x400FBE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		protected readonly string TXT_ITEM_NUM_LABEL;

		[Token(Token = "0x400FBE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected readonly string TAB_GROUP_LABEL;

		[Token(Token = "0x400FBEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected readonly string TAB_RENTAL_LABEL;

		[Token(Token = "0x400FBEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		protected readonly string TAB_MYDECK_LABEL;

		[Token(Token = "0x400FBEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		protected readonly string ROOT_RENTAL_LABEL;

		[Token(Token = "0x400FBED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		protected readonly string ROOT_MYDECK_LABEL;

		[Token(Token = "0x400FBEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		protected readonly string TMP_DECK_RENTAL_LABEL;

		[Token(Token = "0x400FBEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		protected readonly string BTN_PLAY_LABEL;

		[Token(Token = "0x400FBF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		protected readonly string BTN_DECK_LABEL;

		[Token(Token = "0x400FBF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		protected readonly string BTN_DUEL_LABEL;

		[Token(Token = "0x400FBF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		protected readonly string BTN_INFO_LABEL;

		[Token(Token = "0x400FBF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		protected readonly string BTN_BONUS_LABEL;

		[Token(Token = "0x400FBF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		protected readonly string BTN_ZOOM_LABEL;

		[Token(Token = "0x400FBF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		protected readonly string FADE_BG_LABEL;

		[Token(Token = "0x400FBF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly string ANALOG_DIRECTION_ITEM;

		[Token(Token = "0x400FBF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly string MINI_MAP_AREA_LABEL;

		[Token(Token = "0x400FBF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly string MANAGER_COLOSSEUM_DIALOG;

		[Token(Token = "0x400FBF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly string PATH_HELP_DICERALLY;

		[Token(Token = "0x400FBFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly string TWEEN_BONUS_FIRST;

		[Token(Token = "0x400FBFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly string TWEEN_BONUS;

		[Token(Token = "0x400FBFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly int DICEPOINT_MAX;

		[Token(Token = "0x400FBFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private int nameRegId;

		[Token(Token = "0x400FBFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private int logoId;

		[Token(Token = "0x400FBFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private int m_LapCount;

		[Token(Token = "0x400FC00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int m_DiceCount;

		[Token(Token = "0x400FC01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private int m_CurrentLapId;

		[Token(Token = "0x400FC02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private int m_CurrentGridId;

		[Token(Token = "0x400FC03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private int m_RarityUpCount;

		[Token(Token = "0x400FC04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Dictionary<string, object> m_BoardDict;

		[Token(Token = "0x400FC05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Dictionary<string, object> m_BoardInfo;

		[Token(Token = "0x400FC06")]
		private const float k_WallpaperDuration = 0.2f;

		[Token(Token = "0x400FC07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private ColosseumUtil.StatusDiceRally status;

		[Token(Token = "0x400FC08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private ColosseumDialogMangaer m_DialogManager;

		[Token(Token = "0x400FC09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private DiceRallyWidget m_MapWidget;

		[Token(Token = "0x400FC0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private DiceInfomationWidget m_DiceInfomationWidget;

		[Token(Token = "0x400FC0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private GoalInfomationWidget m_GoalInfomationWidget;

		[Token(Token = "0x400FC0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private Coroutine apiCoroutine;

		[Token(Token = "0x400FC0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject m_AnalogScrollIcon;

		[Token(Token = "0x400FC0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private GameObject m_FadeBg;

		[Token(Token = "0x400FC0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Transform m_FadeBgTransform;

		[Token(Token = "0x400FC10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400FC11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private DiceRallyUtil.ZoomType zoomType;

		[Token(Token = "0x400FC12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private ExtendedTextMeshProUGUI zoomText;

		[Token(Token = "0x400FC13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private GameObject zoomIconPlus;

		[Token(Token = "0x400FC14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private GameObject zoomIconMinus;

		[Token(Token = "0x400FC15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private GameObject m_MapBg;

		[Token(Token = "0x400FC16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private bool isApiSuccess;

		[Token(Token = "0x400FC17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x321")]
		private bool isCloseDialog;

		[Token(Token = "0x400FC18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x322")]
		private bool isFirst;

		[Token(Token = "0x400FC19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x323")]
		private bool m_RefreshDeckReverve;

		[Token(Token = "0x600B5AA")]
		[Address(RVA = "0x4D64E0", Offset = "0x4D56E0", VA = "0x1804D64E0")]
		public DiceRallyBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B5AB")]
		[Address(RVA = "0x4D1000", Offset = "0x4D0200", VA = "0x1804D1000", Slot = "26")]
		public void OnFocusChanged(bool setfocus)
		{
		}

		[Token(Token = "0x600B5AC")]
		[Address(RVA = "0x4D11E0", Offset = "0x4D03E0", VA = "0x1804D11E0", Slot = "25")]
		public void OnNotificationStackRemove()
		{
		}

		[Token(Token = "0x600B5AD")]
		[Address(RVA = "0x4D12A0", Offset = "0x4D04A0", VA = "0x1804D12A0", Slot = "27")]
		public void OnNotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B5AE")]
		[Address(RVA = "0x4D0F40", Offset = "0x4D0140", VA = "0x1804D0F40", Slot = "24")]
		public bool OnBack()
		{
			return default(bool);
		}

		[Token(Token = "0x600B5AF")]
		[Address(RVA = "0x4D0AF0", Offset = "0x4CFCF0", VA = "0x1804D0AF0", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B5B0")]
		[Address(RVA = "0x4D0B20", Offset = "0x4CFD20", VA = "0x1804D0B20")]
		private List<DiceRallyReward> MakeGetDiceRewardList(int eventId)
		{
			return null;
		}

		[Token(Token = "0x600B5B1")]
		[Address(RVA = "0x4D2370", Offset = "0x4D1570", VA = "0x1804D2370", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B5B2")]
		[Address(RVA = "0x4D0730", Offset = "0x4CF930", VA = "0x1804D0730", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B5B3")]
		[Address(RVA = "0x4D5820", Offset = "0x4D4A20", VA = "0x1804D5820", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B5B4")]
		[Address(RVA = "0x4D1EC0", Offset = "0x4D10C0", VA = "0x1804D1EC0")]
		private void OnWidgetCreated(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x600B5B5")]
		[Address(RVA = "0x4CFAD0", Offset = "0x4CECD0", VA = "0x1804CFAD0")]
		private void BoardUpdate()
		{
		}

		[Token(Token = "0x600B5B6")]
		[Address(RVA = "0x4D6480", Offset = "0x4D5680", VA = "0x1804D6480")]
		private void Zoom()
		{
		}

		[Token(Token = "0x600B5B7")]
		[Address(RVA = "0x4D3200", Offset = "0x4D2400", VA = "0x1804D3200")]
		private void SetZoomType(DiceRallyUtil.ZoomType type)
		{
		}

		[Token(Token = "0x600B5B8")]
		[Address(RVA = "0x4D4AD0", Offset = "0x4D3CD0", VA = "0x1804D4AD0")]
		private DiceRallyReward UpdateReward(Dictionary<string, object> rewardInfo, Dictionary<string, object> boardInfo)
		{
			return null;
		}

		[Token(Token = "0x600B5B9")]
		[Address(RVA = "0x4D4A90", Offset = "0x4D3C90", VA = "0x1804D4A90")]
		private void UpdateDuelDialog()
		{
		}

		[Token(Token = "0x600B5BA")]
		[Address(RVA = "0x4D48D0", Offset = "0x4D3AD0", VA = "0x1804D48D0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B5BB")]
		[Address(RVA = "0x4CFE70", Offset = "0x4CF070", VA = "0x1804CFE70", Slot = "4")]
		internal override void CallAPI(bool isEntry = true)
		{
		}

		[Token(Token = "0x600B5BC")]
		[Address(RVA = "0x4D6BA0", Offset = "0x4D5DA0", VA = "0x1804D6BA0")]
		[IteratorStateMachine(typeof(_003CyCallAPI_003Ed__78))]
		private IEnumerator yCallAPI(bool isEntry = true, [Optional] Action onComplete)
		{
			return null;
		}

		[Token(Token = "0x600B5BD")]
		[Address(RVA = "0x4D00A0", Offset = "0x4CF2A0", VA = "0x1804D00A0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B5BE")]
		[Address(RVA = "0x4CFFF0", Offset = "0x4CF1F0", VA = "0x1804CFFF0", Slot = "6")]
		internal override void CallDeckCheckAPI(bool isEntry)
		{
		}

		[Token(Token = "0x600B5BF")]
		[Address(RVA = "0x4D1DC0", Offset = "0x4D0FC0", VA = "0x1804D1DC0", Slot = "15")]
		internal override void OnTransitionStart(TransitionType type)
		{
		}

		[Token(Token = "0x600B5C0")]
		[Address(RVA = "0x4D1CE0", Offset = "0x4D0EE0", VA = "0x1804D1CE0", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B5C1")]
		[Address(RVA = "0x4D4420", Offset = "0x4D3620", VA = "0x1804D4420")]
		private void UpdateBonusObi()
		{
		}

		[Token(Token = "0x600B5C2")]
		[Address(RVA = "0x4D6C40", Offset = "0x4D5E40", VA = "0x1804D6C40")]
		[IteratorStateMachine(typeof(_003CyPlaySE_003Ed__84))]
		private IEnumerator yPlaySE(string label, float delay)
		{
			return null;
		}

		[Token(Token = "0x600B5C3")]
		[Address(RVA = "0x4CFD90", Offset = "0x4CEF90", VA = "0x1804CFD90", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B5C4")]
		[Address(RVA = "0x4D0620", Offset = "0x4CF820", VA = "0x1804D0620", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B5C5")]
		[Address(RVA = "0x4D10D0", Offset = "0x4D02D0", VA = "0x1804D10D0")]
		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B5C6")]
		[Address(RVA = "0x4D2D90", Offset = "0x4D1F90", VA = "0x1804D2D90")]
		private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> duelmenu, Dictionary<string, object> master)
		{
			return null;
		}

		[Token(Token = "0x600B5C7")]
		[Address(RVA = "0x4D2780", Offset = "0x4D1980", VA = "0x1804D2780")]
		private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> MTdic, Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B5C8")]
		[Address(RVA = "0x4D1C30", Offset = "0x4D0E30", VA = "0x1804D1C30", Slot = "28")]
		public bool OnResult(ViewController from, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600B5C9")]
		[Address(RVA = "0x4CFA10", Offset = "0x4CEC10", VA = "0x1804CFA10", Slot = "19")]
		internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B5CA")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B5CB")]
		[Address(RVA = "0x4D0B10", Offset = "0x4CFD10", VA = "0x1804D0B10", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}

		[Token(Token = "0x600B5CC")]
		[Address(RVA = "0x4CFA00", Offset = "0x4CEC00", VA = "0x1804CFA00", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B5CD")]
		[Address(RVA = "0x4D04D0", Offset = "0x4CF6D0", VA = "0x1804D04D0")]
		private void FadeBgSetting(Transform parent)
		{
		}

		[Token(Token = "0x600B5CE")]
		[Address(RVA = "0x4D01B0", Offset = "0x4CF3B0", VA = "0x1804D01B0")]
		private void ChangeBgColor(GameObject target)
		{
		}

		[Token(Token = "0x600B5CF")]
		[Address(RVA = "0x4D2210", Offset = "0x4D1410", VA = "0x1804D2210", Slot = "29")]
		public void SetBg(TransitionType type)
		{
		}
	}

	[Token(Token = "0x2001BFE")]
	protected class DuelistCupBehaviour : ModeBehaviour, IOnResultSupported, ICertificationSupported, IOutGameBgSupported
	{
		[Token(Token = "0x2001BFF")]
		private class Data1stReward
		{
			[Token(Token = "0x400FC7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x400FC80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x400FC81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x400FC82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isPeriod;

			[Token(Token = "0x400FC83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int needDlv;

			[Token(Token = "0x400FC84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool focus;

			[Token(Token = "0x400FC85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool received;

			[Token(Token = "0x600B641")]
			[Address(RVA = "0x4CF990", Offset = "0x4CEB90", VA = "0x1804CF990")]
			public Data1stReward(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x400FC51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly string SCROLL_LABEL;

		[Token(Token = "0x400FC52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string VIEW_1ST_LABEL;

		[Token(Token = "0x400FC53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly string VIEW_2ND_LABEL;

		[Token(Token = "0x400FC54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly string ROOT_VIEW_1ST_LABEL;

		[Token(Token = "0x400FC55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly string ROOT_VIEW_2ND_LABEL;

		[Token(Token = "0x400FC56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly string TXT_DLV_LABEL;

		[Token(Token = "0x400FC57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly string ANALOG_DIRECTION_ITEM;

		[Token(Token = "0x400FC58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly string REWARD_ROOT;

		[Token(Token = "0x400FC59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly string REWARD_NORMAL;

		[Token(Token = "0x400FC5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly string REWARD_PICKUP;

		[Token(Token = "0x400FC5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly string REWARD_DEFAULT;

		[Token(Token = "0x400FC5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly string REWARD_IMAGE;

		[Token(Token = "0x400FC5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly string REWARD_RECIEVED_FRAME;

		[Token(Token = "0x400FC5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly string REWARD_RECIEVED_ICON;

		[Token(Token = "0x400FC5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly string REWARD_NUM;

		[Token(Token = "0x400FC60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly string REWARD_DLV;

		[Token(Token = "0x400FC61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly string REWARD_GAUGE_EXTENDED_HEAD;

		[Token(Token = "0x400FC62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly string REWARD_GAUGE_EXTENDED_TAIL;

		[Token(Token = "0x400FC63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly string BTN_PREV;

		[Token(Token = "0x400FC64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly string BTN_NEXT;

		[Token(Token = "0x400FC65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly string BTN_PICKUP;

		[Token(Token = "0x400FC66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly string PICKUP_ICON;

		[Token(Token = "0x400FC67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly string PICKUP_IMAGE;

		[Token(Token = "0x400FC68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly string PICKUP_DLV;

		[Token(Token = "0x400FC69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly string PICKUP_NUM;

		[Token(Token = "0x400FC6A")]
		private const int REWARD_NUM_PER_PAGE = 5;

		[Token(Token = "0x400FC6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		protected string titleStr;

		[Token(Token = "0x400FC6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		protected PvpMenuDefine.MatchingType matchingType;

		[Token(Token = "0x400FC6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		protected int nameRegId;

		[Token(Token = "0x400FC6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		protected int logoId;

		[Token(Token = "0x400FC6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private int matchingTime2nd;

		[Token(Token = "0x400FC70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private int stage;

		[Token(Token = "0x400FC71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		protected int dispStage;

		[Token(Token = "0x400FC72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private int maxDlv;

		[Token(Token = "0x400FC73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private int rewardPageNum;

		[Token(Token = "0x400FC74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private int rewardSpaceNum;

		[Token(Token = "0x400FC75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private int year;

		[Token(Token = "0x400FC76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int month;

		[Token(Token = "0x400FC77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		protected ColosseumUtil.StatusDuelistCup status;

		[Token(Token = "0x400FC78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private ElementObjectManager rankingBtnEom;

		[Token(Token = "0x400FC79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private InfinityScrollView isv;

		[Token(Token = "0x400FC7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private ElementObjectManager scrollEom;

		[Token(Token = "0x400FC7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private ElementObjectManager pickupEom;

		[Token(Token = "0x400FC7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400FC7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private bool m_RefreshDeckReverve;

		[Token(Token = "0x400FC7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private List<Data1stReward> rewardList;

		[Token(Token = "0x600B619")]
		[Address(RVA = "0x4E16F0", Offset = "0x4E08F0", VA = "0x1804E16F0")]
		public DuelistCupBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B61A")]
		[Address(RVA = "0x4DD650", Offset = "0x4DC850", VA = "0x1804DD650", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B61B")]
		[Address(RVA = "0x4DE980", Offset = "0x4DDB80", VA = "0x1804DE980", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B61C")]
		[Address(RVA = "0x4DD180", Offset = "0x4DC380", VA = "0x1804DD180", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B61D")]
		[Address(RVA = "0x4E0C90", Offset = "0x4DFE90", VA = "0x1804E0C90", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B61E")]
		[Address(RVA = "0x4DF6C0", Offset = "0x4DE8C0", VA = "0x1804DF6C0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B61F")]
		[Address(RVA = "0x4DEC80", Offset = "0x4DDE80", VA = "0x1804DEC80", Slot = "26")]
		protected virtual List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
			return null;
		}

		[Token(Token = "0x600B620")]
		[Address(RVA = "0x4DF890", Offset = "0x4DEA90", VA = "0x1804DF890")]
		private void UpdateDisp1stStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
		{
		}

		[Token(Token = "0x600B621")]
		[Address(RVA = "0x4DCEB0", Offset = "0x4DC0B0", VA = "0x1804DCEB0")]
		private string GetDlvString(int dlv)
		{
			return null;
		}

		[Token(Token = "0x600B622")]
		[Address(RVA = "0x4E0850", Offset = "0x4DFA50", VA = "0x1804E0850", Slot = "27")]
		protected virtual void UpdateDisp2ndStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
		{
		}

		[Token(Token = "0x600B623")]
		[Address(RVA = "0x4E0960", Offset = "0x4DFB60", VA = "0x1804E0960")]
		private void UpdateRankingButton()
		{
		}

		[Token(Token = "0x600B624")]
		[Address(RVA = "0x4DCFD0", Offset = "0x4DC1D0", VA = "0x1804DCFD0", Slot = "28")]
		protected virtual string GetNorankingText()
		{
			return null;
		}

		[Token(Token = "0x600B625")]
		[Address(RVA = "0x4DD030", Offset = "0x4DC230", VA = "0x1804DD030", Slot = "29")]
		protected virtual Dictionary<string, object> GetRankingViewArgs()
		{
			return null;
		}

		[Token(Token = "0x600B626")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "30")]
		protected virtual int GetBGId()
		{
			return default(int);
		}

		[Token(Token = "0x600B627")]
		[Address(RVA = "0x4DCF30", Offset = "0x4DC130", VA = "0x1804DCF30", Slot = "31")]
		protected virtual string GetLogoPath()
		{
			return null;
		}

		[Token(Token = "0x600B628")]
		[Address(RVA = "0x4DE120", Offset = "0x4DD320", VA = "0x1804DE120", Slot = "23")]
		public bool OnResult(ViewController from, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600B629")]
		[Address(RVA = "0x4DC3F0", Offset = "0x4DB5F0", VA = "0x1804DC3F0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B62A")]
		[Address(RVA = "0x4DC0C0", Offset = "0x4DB2C0", VA = "0x1804DC0C0", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B62B")]
		[Address(RVA = "0x4DC180", Offset = "0x4DB380", VA = "0x1804DC180", Slot = "19")]
		internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B62C")]
		[Address(RVA = "0x4DE850", Offset = "0x4DDA50", VA = "0x1804DE850", Slot = "25")]
		public void SetBg(TransitionType type)
		{
		}

		[Token(Token = "0x600B62D")]
		[Address(RVA = "0x4DE1D0", Offset = "0x4DD3D0", VA = "0x1804DE1D0", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B62E")]
		[Address(RVA = "0x4DD710", Offset = "0x4DC910", VA = "0x1804DD710")]
		protected void MovePageNextReward()
		{
		}

		[Token(Token = "0x600B62F")]
		[Address(RVA = "0x4DD870", Offset = "0x4DCA70", VA = "0x1804DD870")]
		protected void OnClickDuel()
		{
		}

		[Token(Token = "0x600B630")]
		[Address(RVA = "0x4DC300", Offset = "0x4DB500", VA = "0x1804DC300", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B631")]
		[Address(RVA = "0x4DCDA0", Offset = "0x4DBFA0", VA = "0x1804DCDA0", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B632")]
		[Address(RVA = "0x4DC9A0", Offset = "0x4DBBA0", VA = "0x1804DC9A0")]
		protected void DispReward()
		{
		}

		[Token(Token = "0x600B633")]
		[Address(RVA = "0x4DC500", Offset = "0x4DB700", VA = "0x1804DC500")]
		protected void DispAward()
		{
		}

		[Token(Token = "0x600B634")]
		[Address(RVA = "0x4DDC80", Offset = "0x4DCE80", VA = "0x1804DDC80", Slot = "32")]
		protected virtual void OnClickInfo()
		{
		}

		[Token(Token = "0x600B635")]
		[Address(RVA = "0x4DE210", Offset = "0x4DD410", VA = "0x1804DE210")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x600B636")]
		[Address(RVA = "0x4DDD60", Offset = "0x4DCF60", VA = "0x1804DDD60")]
		private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x600B637")]
		[Address(RVA = "0x4DDEE0", Offset = "0x4DD0E0", VA = "0x1804DDEE0")]
		private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600B638")]
		[Address(RVA = "0x4DE010", Offset = "0x4DD210", VA = "0x1804DE010")]
		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B639")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "24")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B63A")]
		[Address(RVA = "0x4DD6F0", Offset = "0x4DC8F0", VA = "0x1804DD6F0", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C0A")]
	protected class DuelTrialBehaviour : ModeBehaviour, ICertificationSupported
	{
		[Token(Token = "0x2001C0B")]
		private class RewardData
		{
			[Token(Token = "0x400FCC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int win;

			[Token(Token = "0x400FCC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemCategory;

			[Token(Token = "0x400FCC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int itemId;

			[Token(Token = "0x400FCC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int num;

			[Token(Token = "0x400FCC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isPeriod;

			[Token(Token = "0x400FCCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool existsItem;

			[Token(Token = "0x400FCCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public bool received;

			[Token(Token = "0x400FCCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int shopId;

			[Token(Token = "0x600B685")]
			[Address(RVA = "0x4FB8D0", Offset = "0x4FAAD0", VA = "0x1804FB8D0")]
			public RewardData(int win, int itemCategory, int itemId, int num, bool isPeriod, bool existsItem, bool received, int shopId)
			{
			}

			[Token(Token = "0x600B686")]
			[Address(RVA = "0x4FB940", Offset = "0x4FAB40", VA = "0x1804FB940")]
			public RewardData(int win, bool existsItem, bool received)
			{
			}
		}

		[Token(Token = "0x400FCA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly string BTN_PREV;

		[Token(Token = "0x400FCA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string BTN_NEXT;

		[Token(Token = "0x400FCA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly string REWARD_ROOT;

		[Token(Token = "0x400FCA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly string REWARD_NONE;

		[Token(Token = "0x400FCA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly string REWARD_NORMAL;

		[Token(Token = "0x400FCA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly string REWARD_PICKUP;

		[Token(Token = "0x400FCAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly string REWARD_DEFAULT;

		[Token(Token = "0x400FCAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly string REWARD_IMAGE;

		[Token(Token = "0x400FCAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly string REWARD_RECIEVED_FRAME;

		[Token(Token = "0x400FCAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly string REWARD_RECIEVED_ICON;

		[Token(Token = "0x400FCAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly string REWARD_WIN;

		[Token(Token = "0x400FCAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly string REWARD_NUM;

		[Token(Token = "0x400FCB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly string E_Gauge;

		[Token(Token = "0x400FCB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly string REWARD_GAUGE_EXTENDED_HEAD;

		[Token(Token = "0x400FCB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly string REWARD_GAUGE_EXTENDED_TAIL;

		[Token(Token = "0x400FCB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly string E_GaugeExtendHeadFill;

		[Token(Token = "0x400FCB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly string E_GaugeExtendTailFill;

		[Token(Token = "0x400FCB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly string SCROLL_LABEL;

		[Token(Token = "0x400FCB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly string ANALOG_DIRECTION_ITEM;

		[Token(Token = "0x400FCB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly string ICON_L;

		[Token(Token = "0x400FCB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly string ICON_R;

		[Token(Token = "0x400FCB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly string k_ETextTitle;

		[Token(Token = "0x400FCBA")]
		private const int REWARD_NUM_PER_PAGE = 3;

		[Token(Token = "0x400FCBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private int nameRegId;

		[Token(Token = "0x400FCBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private int logoId;

		[Token(Token = "0x400FCBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private string titleStr;

		[Token(Token = "0x400FCBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private ColosseumUtil.StatusDuelTrial status;

		[Token(Token = "0x400FCBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private InfinityScrollView isv;

		[Token(Token = "0x400FCC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private ElementObjectManager scrollEom;

		[Token(Token = "0x400FCC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400FCC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private List<RewardData> rewardList;

		[Token(Token = "0x400FCC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private int rewardPageNum;

		[Token(Token = "0x400FCC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private int rewardSpaceNum;

		[Token(Token = "0x600B661")]
		[Address(RVA = "0x4DBC70", Offset = "0x4DAE70", VA = "0x1804DBC70")]
		public DuelTrialBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B662")]
		[Address(RVA = "0x4D8230", Offset = "0x4D7430", VA = "0x1804D8230", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B663")]
		[Address(RVA = "0x4D9370", Offset = "0x4D8570", VA = "0x1804D9370", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B664")]
		[Address(RVA = "0x4D84B0", Offset = "0x4D76B0", VA = "0x1804D84B0")]
		private void OnClickInfo()
		{
		}

		[Token(Token = "0x600B665")]
		[Address(RVA = "0x4D7A30", Offset = "0x4D6C30", VA = "0x1804D7A30", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B666")]
		[Address(RVA = "0x4DA290", Offset = "0x4D9490", VA = "0x1804DA290")]
		private void SetShortcutLRReward(bool isSet)
		{
		}

		[Token(Token = "0x600B667")]
		[Address(RVA = "0x4DB3C0", Offset = "0x4DA5C0", VA = "0x1804DB3C0", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B668")]
		[Address(RVA = "0x4DA7D0", Offset = "0x4D99D0", VA = "0x1804DA7D0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B669")]
		[Address(RVA = "0x4D6FE0", Offset = "0x4D61E0", VA = "0x1804D6FE0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B66A")]
		[Address(RVA = "0x4D6CC0", Offset = "0x4D5EC0", VA = "0x1804D6CC0", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B66B")]
		[Address(RVA = "0x4D8950", Offset = "0x4D7B50", VA = "0x1804D8950", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B66C")]
		[Address(RVA = "0x4D82E0", Offset = "0x4D74E0", VA = "0x1804D82E0")]
		private void MovePageNextReward()
		{
		}

		[Token(Token = "0x600B66D")]
		[Address(RVA = "0x4D6DF0", Offset = "0x4D5FF0", VA = "0x1804D6DF0", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B66E")]
		[Address(RVA = "0x4D78A0", Offset = "0x4D6AA0", VA = "0x1804D78A0", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B66F")]
		[Address(RVA = "0x4DAA80", Offset = "0x4D9C80", VA = "0x1804DAA80")]
		private void UpdateReward(int currentWin)
		{
		}

		[Token(Token = "0x600B670")]
		[Address(RVA = "0x4D8990", Offset = "0x4D7B90", VA = "0x1804D8990")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x600B671")]
		[Address(RVA = "0x4D8590", Offset = "0x4D7790", VA = "0x1804D8590")]
		private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x600B672")]
		[Address(RVA = "0x4D8710", Offset = "0x4D7910", VA = "0x1804D8710")]
		private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600B673")]
		[Address(RVA = "0x4D8840", Offset = "0x4D7A40", VA = "0x1804D8840")]
		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B674")]
		[Address(RVA = "0x4D9E20", Offset = "0x4D9020", VA = "0x1804D9E20")]
		private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B675")]
		[Address(RVA = "0x4D9550", Offset = "0x4D8750", VA = "0x1804D9550")]
		private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> masterInfo, Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B676")]
		[Address(RVA = "0x4D7480", Offset = "0x4D6680", VA = "0x1804D7480")]
		private void DispReward()
		{
		}

		[Token(Token = "0x600B677")]
		[Address(RVA = "0x4D70F0", Offset = "0x4D62F0", VA = "0x1804D70F0")]
		private void CheckPack()
		{
		}

		[Token(Token = "0x600B678")]
		[Address(RVA = "0x4D6EE0", Offset = "0x4D60E0", VA = "0x1804D6EE0")]
		private void CallAPIOpenCampaignPack(int item_id, int num, [Optional] Action onSuccess)
		{
		}

		[Token(Token = "0x600B679")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B67A")]
		[Address(RVA = "0x4D82D0", Offset = "0x4D74D0", VA = "0x1804D82D0", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C18")]
	protected class ExhibitionBehaviour : ModeBehaviour, ICertificationSupported
	{
		[Token(Token = "0x2001C19")]
		private class RewardData
		{
			[Token(Token = "0x400FD2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x400FD30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x400FD31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x400FD32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isPeriod;

			[Token(Token = "0x400FD33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int needToken;

			[Token(Token = "0x400FD34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool focus;

			[Token(Token = "0x400FD35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool received;

			[Token(Token = "0x600B6D4")]
			[Address(RVA = "0x4CF990", Offset = "0x4CEB90", VA = "0x1804CF990")]
			public RewardData(int itemCategory, int itemId, int num, bool isPeriod, int needToken, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x400FCFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected readonly string OBJ_REWARD_LABEL;

		[Token(Token = "0x400FCFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected readonly string IMG_GAUGE_LABEL;

		[Token(Token = "0x400FCFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		protected readonly string IMG_RECEIVED_LABEL;

		[Token(Token = "0x400FCFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected readonly string IMG_DEFAULT_FRAME_LABEL;

		[Token(Token = "0x400FD00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected readonly string IMG_RECEIVED_FRAME_LABEL;

		[Token(Token = "0x400FD01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected readonly string IMG_EVENT_CATEGORY;

		[Token(Token = "0x400FD02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected readonly string TXT_NEEDTOKEN_LABEL;

		[Token(Token = "0x400FD03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected readonly string TXT_DECK_LABEL;

		[Token(Token = "0x400FD04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected readonly string TXT_PLAY_LABEL;

		[Token(Token = "0x400FD05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		protected readonly string TXT_ITEM_NUM_LABEL;

		[Token(Token = "0x400FD06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected readonly string TAB_GROUP_LABEL;

		[Token(Token = "0x400FD07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected readonly string TAB_RENTAL_LABEL;

		[Token(Token = "0x400FD08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		protected readonly string TAB_MYDECK_LABEL;

		[Token(Token = "0x400FD09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		protected readonly string ROOT_RENTAL_LABEL;

		[Token(Token = "0x400FD0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		protected readonly string ROOT_MYDECK_LABEL;

		[Token(Token = "0x400FD0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		protected readonly string TMP_DECK_RENTAL_LABEL;

		[Token(Token = "0x400FD0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		protected readonly string BTN_PLAY_LABEL;

		[Token(Token = "0x400FD0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		protected readonly string BTN_DECK_LABEL;

		[Token(Token = "0x400FD0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly string SCROLL_LABEL;

		[Token(Token = "0x400FD0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly string ANALOG_DIRECTION_ITEM;

		[Token(Token = "0x400FD10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly string REWARD_ROOT;

		[Token(Token = "0x400FD11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly string REWARD_NORMAL;

		[Token(Token = "0x400FD12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly string REWARD_PICKUP;

		[Token(Token = "0x400FD13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly string REWARD_DEFAULT;

		[Token(Token = "0x400FD14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly string REWARD_IMAGE;

		[Token(Token = "0x400FD15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly string REWARD_RECIEVED_FRAME;

		[Token(Token = "0x400FD16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly string REWARD_RECIEVED_ICON;

		[Token(Token = "0x400FD17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly string REWARD_NUM;

		[Token(Token = "0x400FD18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly string REWARD_DLV;

		[Token(Token = "0x400FD19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly string REWARD_GAUGE_EXTENDED_HEAD;

		[Token(Token = "0x400FD1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly string REWARD_GAUGE_EXTENDED_TAIL;

		[Token(Token = "0x400FD1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private readonly string BTN_PREV;

		[Token(Token = "0x400FD1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly string BTN_NEXT;

		[Token(Token = "0x400FD1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private readonly string ICON_L;

		[Token(Token = "0x400FD1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly string ICON_R;

		[Token(Token = "0x400FD1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private readonly string BTN_PICKUP;

		[Token(Token = "0x400FD20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private readonly string PICKUP_ICON;

		[Token(Token = "0x400FD21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private readonly string PICKUP_IMAGE;

		[Token(Token = "0x400FD22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private readonly string PICKUP_DLV;

		[Token(Token = "0x400FD23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private readonly string PICKUP_NUM;

		[Token(Token = "0x400FD24")]
		private const int REWARD_NUM_PER_PAGE = 5;

		[Token(Token = "0x400FD25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private int nameRegId;

		[Token(Token = "0x400FD26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private int logoId;

		[Token(Token = "0x400FD27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private ColosseumUtil.StatusExhibition status;

		[Token(Token = "0x400FD28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private InfinityScrollView isv;

		[Token(Token = "0x400FD29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private ElementObjectManager scrollEom;

		[Token(Token = "0x400FD2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ElementObjectManager pickupEom;

		[Token(Token = "0x400FD2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400FD2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private List<RewardData> rewardList;

		[Token(Token = "0x400FD2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private int rewardPageNum;

		[Token(Token = "0x400FD2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private int rewardSpaceNum;

		[Token(Token = "0x600B6B6")]
		[Address(RVA = "0x4EA430", Offset = "0x4E9630", VA = "0x1804EA430")]
		public ExhibitionBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B6B7")]
		[Address(RVA = "0x4E6E60", Offset = "0x4E6060", VA = "0x1804E6E60", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B6B8")]
		[Address(RVA = "0x4E5FF0", Offset = "0x4E51F0", VA = "0x1804E5FF0")]
		private void DispReward()
		{
		}

		[Token(Token = "0x600B6B9")]
		[Address(RVA = "0x4E7BB0", Offset = "0x4E6DB0", VA = "0x1804E7BB0", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B6BA")]
		[Address(RVA = "0x4E64E0", Offset = "0x4E56E0", VA = "0x1804E64E0", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B6BB")]
		[Address(RVA = "0x4E8810", Offset = "0x4E7A10", VA = "0x1804E8810")]
		private void SetShortcutLRReward(bool isSet)
		{
		}

		[Token(Token = "0x600B6BC")]
		[Address(RVA = "0x4E9BB0", Offset = "0x4E8DB0", VA = "0x1804E9BB0", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B6BD")]
		[Address(RVA = "0x4E8DA0", Offset = "0x4E7FA0", VA = "0x1804E8DA0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B6BE")]
		[Address(RVA = "0x4E5EE0", Offset = "0x4E50E0", VA = "0x1804E5EE0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B6BF")]
		[Address(RVA = "0x4E5CA0", Offset = "0x4E4EA0", VA = "0x1804E5CA0", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B6C0")]
		[Address(RVA = "0x4E74B0", Offset = "0x4E66B0", VA = "0x1804E74B0", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B6C1")]
		[Address(RVA = "0x4E6F20", Offset = "0x4E6120", VA = "0x1804E6F20")]
		private void MovePageNextReward()
		{
		}

		[Token(Token = "0x600B6C2")]
		[Address(RVA = "0x4E5E00", Offset = "0x4E5000", VA = "0x1804E5E00", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B6C3")]
		[Address(RVA = "0x4E63D0", Offset = "0x4E55D0", VA = "0x1804E63D0", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B6C4")]
		[Address(RVA = "0x4E8F50", Offset = "0x4E8150", VA = "0x1804E8F50")]
		private void UpdateReward(int token)
		{
		}

		[Token(Token = "0x600B6C5")]
		[Address(RVA = "0x4E7570", Offset = "0x4E6770", VA = "0x1804E7570")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x600B6C6")]
		[Address(RVA = "0x4E70F0", Offset = "0x4E62F0", VA = "0x1804E70F0")]
		private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x600B6C7")]
		[Address(RVA = "0x4E7270", Offset = "0x4E6470", VA = "0x1804E7270")]
		private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600B6C8")]
		[Address(RVA = "0x4E73A0", Offset = "0x4E65A0", VA = "0x1804E73A0")]
		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B6C9")]
		[Address(RVA = "0x4E83A0", Offset = "0x4E75A0", VA = "0x1804E83A0")]
		private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B6CA")]
		[Address(RVA = "0x4E7D90", Offset = "0x4E6F90", VA = "0x1804E7D90")]
		private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> masterInfo, Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B6CB")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B6CC")]
		[Address(RVA = "0x4E6F10", Offset = "0x4E6110", VA = "0x1804E6F10", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C22")]
	protected class FreeBehaviour : ModeBehaviour, ICertificationSupported
	{
		[Token(Token = "0x400FD4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected readonly string E_LogoFree;

		[Token(Token = "0x400FD4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool isEndDuel;

		[Token(Token = "0x600B6EE")]
		[Address(RVA = "0x4EC6A0", Offset = "0x4EB8A0", VA = "0x1804EC6A0")]
		public FreeBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B6EF")]
		[Address(RVA = "0x4EB340", Offset = "0x4EA540", VA = "0x1804EB340")]
		private void OnClickDuel()
		{
		}

		[Token(Token = "0x600B6F0")]
		[Address(RVA = "0x4EB560", Offset = "0x4EA760", VA = "0x1804EB560", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B6F1")]
		[Address(RVA = "0x4EB210", Offset = "0x4EA410", VA = "0x1804EB210", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B6F2")]
		[Address(RVA = "0x4EC360", Offset = "0x4EB560", VA = "0x1804EC360", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B6F3")]
		[Address(RVA = "0x4EC1A0", Offset = "0x4EB3A0", VA = "0x1804EC1A0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B6F4")]
		[Address(RVA = "0x4EB790", Offset = "0x4EA990", VA = "0x1804EB790", Slot = "24")]
		protected virtual List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> infoDic)
		{
			return null;
		}

		[Token(Token = "0x600B6F5")]
		[Address(RVA = "0x4EABB0", Offset = "0x4E9DB0", VA = "0x1804EABB0", Slot = "19")]
		internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B6F6")]
		[Address(RVA = "0x4EAF10", Offset = "0x4EA110", VA = "0x1804EAF10", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B6F7")]
		[Address(RVA = "0x4EAE20", Offset = "0x4EA020", VA = "0x1804EAE20", Slot = "6")]
		internal override void CallDeckCheckAPI(bool isEntry)
		{
		}

		[Token(Token = "0x600B6F8")]
		[Address(RVA = "0x4EAB70", Offset = "0x4E9D70", VA = "0x1804EAB70", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B6F9")]
		[Address(RVA = "0x4EBCB0", Offset = "0x4EAEB0", VA = "0x1804EBCB0")]
		private void ShowCertificationPracticalResult()
		{
		}

		[Token(Token = "0x600B6FA")]
		[Address(RVA = "0x4EAD40", Offset = "0x4E9F40", VA = "0x1804EAD40", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B6FB")]
		[Address(RVA = "0x4EB020", Offset = "0x4EA220", VA = "0x1804EB020", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B6FC")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B6FD")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C2A")]
	internal interface ICertificationSupported
	{
		[Token(Token = "0x600B714")]
		ElementObjectManager GetCertificationEom();
	}

	[Token(Token = "0x2001C2B")]
	protected abstract class ModeBehaviour
	{
		[Token(Token = "0x400FD60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string IMG_LABEL;

		[Token(Token = "0x400FD61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string IMG_BG_LABEL;

		[Token(Token = "0x400FD62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string IMG_RANK_LABEL;

		[Token(Token = "0x400FD63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string TXT_CAUTION_LABEL;

		[Token(Token = "0x400FD64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string TXT_DATE_LABEL;

		[Token(Token = "0x400FD65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string TXT_STATUS_LABEL;

		[Token(Token = "0x400FD66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string TXT_SUB1_LABEL;

		[Token(Token = "0x400FD67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string TXT_SUB1_TITLE_LABEL;

		[Token(Token = "0x400FD68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string TXT_SUB2_LABEL;

		[Token(Token = "0x400FD69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected readonly string TXT_SUB2_TITLE_LABEL;

		[Token(Token = "0x400FD6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected readonly string TXT_OVERVIEW_LABEL;

		[Token(Token = "0x400FD6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x400FD6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected readonly string TXT_DUEL_NAME_LABEL;

		[Token(Token = "0x400FD6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x400FD6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected readonly string IMG_DECK_LABEL;

		[Token(Token = "0x400FD6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected readonly string IMG_DECK_EMPTY_LABEL;

		[Token(Token = "0x400FD70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected readonly string TXT_LABEL;

		[Token(Token = "0x400FD71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x400FD72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected readonly string NEW_BADGE_LABEL;

		[Token(Token = "0x400FD73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected readonly string NUM_BADGE_LABEL;

		[Token(Token = "0x400FD74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected readonly string TMP_BTN_DECK_LABEL;

		[Token(Token = "0x400FD75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected readonly string TMP_BTN_NORMAL_LABEL;

		[Token(Token = "0x400FD76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public readonly string ELabel_BtnCertification;

		[Token(Token = "0x400FD77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public readonly string ELabel_BtnMission;

		[Token(Token = "0x400FD78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected readonly string k_ELabelBadgeBase;

		[Token(Token = "0x400FD79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected readonly string k_ELabelBadgeBaseAlert;

		[Token(Token = "0x400FD7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected readonly string k_ELabelNumBadge;

		[Token(Token = "0x400FD7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected readonly string k_ELabelNumBadgeText;

		[Token(Token = "0x400FD7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public readonly string ELabel_IcnImage;

		[Token(Token = "0x400FD7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly string ELabel_IconCertificationShortcut;

		[Token(Token = "0x400FD7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal readonly ColosseumUtil.PlayMode playMode;

		[Token(Token = "0x400FD7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		internal readonly Util.GameMode gameMode;

		[Token(Token = "0x400FD80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400FD81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal readonly ColosseumInfoViewController vc;

		[Token(Token = "0x400FD82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal readonly ElementObjectManager parentEOM;

		[Token(Token = "0x400FD83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal readonly ElementObjectManager menuEOM;

		[Token(Token = "0x400FD84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal readonly GameObject certificationBadge;

		[Token(Token = "0x400FD85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal readonly GameObject missionBadge;

		[Token(Token = "0x400FD86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal readonly int eventId;

		[Token(Token = "0x400FD87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected ElementObjectManager deckBtnEOM;

		[Token(Token = "0x400FD88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected DeckCaseWidget deckCase;

		[Token(Token = "0x400FD89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected bool canUseRentalDeck;

		[Token(Token = "0x400FD8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		protected ColosseumDeckWidget colosseumDeckWidget;

		[Token(Token = "0x400FD8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		protected ElementObjectManager viewEOM;

		[Token(Token = "0x400FD8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected string startDate;

		[Token(Token = "0x400FD8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected string endDate;

		[Token(Token = "0x400FD8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		protected string startDateReward;

		[Token(Token = "0x400FD8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		protected string endDateReward;

		[Token(Token = "0x400FD90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		protected int matchingTime;

		[Token(Token = "0x600B715")]
		[Address(RVA = "0x4EDF40", Offset = "0x4ED140", VA = "0x1804EDF40")]
		protected ModeBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B716")]
		[Address(RVA = "0x4EC7E0", Offset = "0x4EB9E0", VA = "0x1804EC7E0", Slot = "4")]
		internal virtual void CallAPI(bool isEntry = true)
		{
		}

		[Token(Token = "0x600B717")]
		internal abstract void CallDetailAPI(bool isEntry, [Optional] Action onFinished);

		[Token(Token = "0x600B718")]
		[Address(RVA = "0x4EC8C0", Offset = "0x4EBAC0", VA = "0x1804EC8C0", Slot = "6")]
		internal virtual void CallDeckCheckAPI(bool isEntry)
		{
		}

		[Token(Token = "0x600B719")]
		internal abstract void SetMenu();

		[Token(Token = "0x600B71A")]
		internal abstract void InitDisp();

		[Token(Token = "0x600B71B")]
		internal abstract void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo);

		[Token(Token = "0x600B71C")]
		internal abstract void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo);

		[Token(Token = "0x600B71D")]
		internal abstract bool IsHoldingByStatus();

		[Token(Token = "0x600B71E")]
		internal abstract void CallAPIGetDeckList(int id, Action onSuccess);

		[Token(Token = "0x600B71F")]
		internal abstract Dictionary<string, object> GetDeckArgs(int identifier, bool isScratch);

		[Token(Token = "0x600B720")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
		internal virtual void PushAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B721")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
		internal virtual void OnTransitionStart(TransitionType type)
		{
		}

		[Token(Token = "0x600B722")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
		internal virtual void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B723")]
		[Address(RVA = "0x4ECAD0", Offset = "0x4EBCD0", VA = "0x1804ECAD0", Slot = "17")]
		internal virtual ElementObjectManager CreateTmpBtnNormal(string name, [Optional] UnityAction clickAction)
		{
			return null;
		}

		[Token(Token = "0x600B724")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "18")]
		protected virtual bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B725")]
		[Address(RVA = "0x4ED7E0", Offset = "0x4EC9E0", VA = "0x1804ED7E0")]
		internal void UpdateDisp()
		{
		}

		[Token(Token = "0x600B726")]
		[Address(RVA = "0x4ED4A0", Offset = "0x4EC6A0", VA = "0x1804ED4A0")]
		protected void OpenEditDeck(int id, bool isScratch = false)
		{
		}

		[Token(Token = "0x600B727")]
		[Address(RVA = "0x4ED580", Offset = "0x4EC780", VA = "0x1804ED580")]
		protected void StartPerformance(ColosseumStartViewController.PrefabType prefabType, string tournamentName = "", int logoId = 0, int identifier = 0, [Optional] Action onFinish)
		{
		}

		[Token(Token = "0x600B728")]
		[Address(RVA = "0x4EC730", Offset = "0x4EB930", VA = "0x1804EC730", Slot = "19")]
		internal virtual void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B729")]
		[Address(RVA = "0x4ECCF0", Offset = "0x4EBEF0", VA = "0x1804ECCF0")]
		internal void DetailSuccessAction(Action onFinished, bool isEntry)
		{
		}

		[Token(Token = "0x600B72A")]
		internal abstract void ApiEndAction(bool isEntry);

		[Token(Token = "0x600B72B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "21")]
		internal virtual void AdditionalBackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B72C")]
		[Address(RVA = "0x4ECF00", Offset = "0x4EC100", VA = "0x1804ECF00")]
		protected bool IsBack(ViewController vc)
		{
			return default(bool);
		}

		[Token(Token = "0x600B72D")]
		[Address(RVA = "0x4ECD30", Offset = "0x4EBF30", VA = "0x1804ECD30")]
		protected internal bool IsBackFromDeckOrDuel(ViewController vc)
		{
			return default(bool);
		}

		[Token(Token = "0x600B72E")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "22")]
		internal virtual bool IsUpdateDisp(ViewController vc)
		{
			return default(bool);
		}

		[Token(Token = "0x600B72F")]
		[Address(RVA = "0x4EC9C0", Offset = "0x4EBBC0", VA = "0x1804EC9C0")]
		private bool CheckStartPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B730")]
		[Address(RVA = "0x4ED610", Offset = "0x4EC810", VA = "0x1804ED610")]
		public void UpdateCertificationBadge()
		{
		}

		[Token(Token = "0x600B731")]
		[Address(RVA = "0x4ED740", Offset = "0x4EC940", VA = "0x1804ED740")]
		public void UpdateCertificationGrade([Optional] GameObject target)
		{
		}

		[Token(Token = "0x600B732")]
		[Address(RVA = "0x4ED8B0", Offset = "0x4ECAB0", VA = "0x1804ED8B0")]
		public void UpdateMissionButton()
		{
		}

		[Token(Token = "0x600B733")]
		[Address(RVA = "0x4EC9E0", Offset = "0x4EBBE0", VA = "0x1804EC9E0")]
		private string ConvertModeNameToClientWorkKey(Util.GameMode mode)
		{
			return null;
		}

		[Token(Token = "0x600B734")]
		[Address(RVA = "0x4ED340", Offset = "0x4EC540", VA = "0x1804ED340")]
		protected void OpenDialogEspire(bool onClosePop)
		{
		}

		[Token(Token = "0x600B735")]
		[Address(RVA = "0x4ED280", Offset = "0x4EC480", VA = "0x1804ED280")]
		protected void OpenDialogDeckReg([Optional] Action onClose)
		{
		}

		[Token(Token = "0x600B736")]
		[Address(RVA = "0x4ED120", Offset = "0x4EC320", VA = "0x1804ED120")]
		protected void OnClickDuelInactive()
		{
		}

		[Token(Token = "0x600B737")]
		[Address(RVA = "0x4ED000", Offset = "0x4EC200", VA = "0x1804ED000")]
		protected bool IsBlurOverlayHelpView(ViewController vc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C32")]
	protected class RankEventBehaviour : ModeBehaviour, ICertificationSupported
	{
		[Token(Token = "0x400FD9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly string TXT_CON_WIN;

		[Token(Token = "0x400FD9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string IMG_EVENT_RANK;

		[Token(Token = "0x400FD9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int nameRegId;

		[Token(Token = "0x400FD9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int logoId;

		[Token(Token = "0x400FDA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private ColosseumUtil.StatusRankEvent status;

		[Token(Token = "0x400FDA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private ColosseumDeckManager deckManager;

		[Token(Token = "0x600B744")]
		[Address(RVA = "0x4F8020", Offset = "0x4F7220", VA = "0x1804F8020")]
		public RankEventBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B745")]
		[Address(RVA = "0x4F6780", Offset = "0x4F5980", VA = "0x1804F6780", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B746")]
		[Address(RVA = "0x4F6A10", Offset = "0x4F5C10", VA = "0x1804F6A10", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B747")]
		[Address(RVA = "0x4F64A0", Offset = "0x4F56A0", VA = "0x1804F64A0", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B748")]
		[Address(RVA = "0x4F7390", Offset = "0x4F6590", VA = "0x1804F7390", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B749")]
		[Address(RVA = "0x4F5810", Offset = "0x4F4A10", VA = "0x1804F5810", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B74A")]
		[Address(RVA = "0x4F55C0", Offset = "0x4F47C0", VA = "0x1804F55C0", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B74B")]
		[Address(RVA = "0x4F6860", Offset = "0x4F5A60", VA = "0x1804F6860")]
		private void OnClickDuel()
		{
		}

		[Token(Token = "0x600B74C")]
		[Address(RVA = "0x4F5730", Offset = "0x4F4930", VA = "0x1804F5730", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B74D")]
		[Address(RVA = "0x4F5D60", Offset = "0x4F4F60", VA = "0x1804F5D60", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B74E")]
		[Address(RVA = "0x4F6EF0", Offset = "0x4F60F0", VA = "0x1804F6EF0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B74F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private void OnClickDeck(ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600B750")]
		[Address(RVA = "0x4F6200", Offset = "0x4F5400", VA = "0x1804F6200")]
		private (int, int) GetRank(string label)
		{
			return default((int, int));
		}

		[Token(Token = "0x600B751")]
		[Address(RVA = "0x4F5E70", Offset = "0x4F5070", VA = "0x1804F5E70")]
		private string GetNextRankText(int rank, int tier)
		{
			return null;
		}

		[Token(Token = "0x600B752")]
		[Address(RVA = "0x4F5920", Offset = "0x4F4B20", VA = "0x1804F5920")]
		private void DispReward()
		{
		}

		[Token(Token = "0x600B753")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B754")]
		[Address(RVA = "0x4F6820", Offset = "0x4F5A20", VA = "0x1804F6820", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C37")]
	protected class RateBehaviour : StandardBehaviour, ICertificationSupported, IOutGameBgSupported
	{
		[Token(Token = "0x400FDAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private readonly string E_LabelTextConWin;

		[Token(Token = "0x400FDAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private readonly string E_LabelTextRate;

		[Token(Token = "0x400FDAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private readonly string E_LabelTextTop;

		[Token(Token = "0x400FDAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private readonly string E_InformButtonGroup;

		[Token(Token = "0x400FDB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private string mmaPath;

		[Token(Token = "0x400FDB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private ElementObjectManager m_TextRateGroupEom;

		[Token(Token = "0x400FDB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private ElementObjectManager m_TextTopGroupEom;

		[Token(Token = "0x400FDB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private ExtendedTextMeshProUGUI m_TextConWin;

		[Token(Token = "0x400FDB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private ExtendedTextMeshProUGUI m_TextRate;

		[Token(Token = "0x400FDB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private ExtendedTextMeshProUGUI m_TextTop;

		[Token(Token = "0x600B764")]
		[Address(RVA = "0x4FB790", Offset = "0x4FA990", VA = "0x1804FB790")]
		public RateBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B765")]
		[Address(RVA = "0x4F9200", Offset = "0x4F8400", VA = "0x1804F9200", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B766")]
		[Address(RVA = "0x4F86E0", Offset = "0x4F78E0", VA = "0x1804F86E0", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B767")]
		[Address(RVA = "0x4FAA40", Offset = "0x4F9C40", VA = "0x1804FAA40", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B768")]
		[Address(RVA = "0x4F83E0", Offset = "0x4F75E0", VA = "0x1804F83E0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B769")]
		[Address(RVA = "0x4F82F0", Offset = "0x4F74F0", VA = "0x1804F82F0", Slot = "6")]
		internal override void CallDeckCheckAPI(bool isEntry)
		{
		}

		[Token(Token = "0x600B76A")]
		[Address(RVA = "0x4F8170", Offset = "0x4F7370", VA = "0x1804F8170", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B76B")]
		[Address(RVA = "0x4F84F0", Offset = "0x4F76F0", VA = "0x1804F84F0", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B76C")]
		[Address(RVA = "0x4F9040", Offset = "0x4F8240", VA = "0x1804F9040", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B76D")]
		[Address(RVA = "0x4F99A0", Offset = "0x4F8BA0", VA = "0x1804F99A0", Slot = "27")]
		protected override List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> infoDic)
		{
			return null;
		}

		[Token(Token = "0x600B76E")]
		[Address(RVA = "0x4F9ED0", Offset = "0x4F90D0", VA = "0x1804F9ED0", Slot = "28")]
		protected override List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> infoDic)
		{
			return null;
		}

		[Token(Token = "0x600B76F")]
		[Address(RVA = "0x4F8CB0", Offset = "0x4F7EB0", VA = "0x1804F8CB0", Slot = "26")]
		protected override void OnClickDuel()
		{
		}

		[Token(Token = "0x600B770")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public new ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B771")]
		[Address(RVA = "0x4F9100", Offset = "0x4F8300", VA = "0x1804F9100", Slot = "29")]
		public void SetBg(TransitionType type)
		{
		}
	}

	[Token(Token = "0x2001C3E")]
	protected class RDCBehaviour : ModeBehaviour, IOnResultSupported, ICertificationSupported, IOutGameBgSupported
	{
		[Token(Token = "0x2001C3F")]
		private class Data1stReward
		{
			[Token(Token = "0x400FE03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x400FE04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x400FE05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x400FE06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isPeriod;

			[Token(Token = "0x400FE07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int needDlv;

			[Token(Token = "0x400FE08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool focus;

			[Token(Token = "0x400FE09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool received;

			[Token(Token = "0x600B7C0")]
			[Address(RVA = "0x4CF990", Offset = "0x4CEB90", VA = "0x1804CF990")]
			public Data1stReward(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x400FDCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly string SCROLL_LABEL;

		[Token(Token = "0x400FDCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string VIEW_1ST_LABEL;

		[Token(Token = "0x400FDCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly string VIEW_2ND_LABEL;

		[Token(Token = "0x400FDCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly string ROOT_VIEW_1ST_LABEL;

		[Token(Token = "0x400FDD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly string ROOT_VIEW_2ND_LABEL;

		[Token(Token = "0x400FDD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly string TXT_DLV_LABEL;

		[Token(Token = "0x400FDD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly string ANALOG_DIRECTION_ITEM;

		[Token(Token = "0x400FDD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly string REWARD_ROOT;

		[Token(Token = "0x400FDD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly string REWARD_NORMAL;

		[Token(Token = "0x400FDD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly string REWARD_PICKUP;

		[Token(Token = "0x400FDD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly string REWARD_DEFAULT;

		[Token(Token = "0x400FDD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly string REWARD_IMAGE;

		[Token(Token = "0x400FDD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly string REWARD_RECIEVED_FRAME;

		[Token(Token = "0x400FDD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly string REWARD_RECIEVED_FRAME_BASE;

		[Token(Token = "0x400FDDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly string REWARD_DEFAULT_FRAME_BASE;

		[Token(Token = "0x400FDDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly string REWARD_RECIEVED_ICON;

		[Token(Token = "0x400FDDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly string REWARD_NUM;

		[Token(Token = "0x400FDDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly string REWARD_DLV;

		[Token(Token = "0x400FDDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly string REWARD_GAUGE_EXTENDED_HEAD;

		[Token(Token = "0x400FDDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly string REWARD_GAUGE_EXTENDED_TAIL;

		[Token(Token = "0x400FDE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly string BTN_PREV;

		[Token(Token = "0x400FDE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly string BTN_NEXT;

		[Token(Token = "0x400FDE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly string ICON_L;

		[Token(Token = "0x400FDE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly string ICON_R;

		[Token(Token = "0x400FDE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly string BTN_PICKUP;

		[Token(Token = "0x400FDE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly string PICKUP_ICON;

		[Token(Token = "0x400FDE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly string PICKUP_IMAGE;

		[Token(Token = "0x400FDE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly string PICKUP_DLV;

		[Token(Token = "0x400FDE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly string PICKUP_NUM;

		[Token(Token = "0x400FDE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		protected readonly string E_SmallButtonGroupMB;

		[Token(Token = "0x400FDEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		protected readonly string E_TemplateHighlight;

		[Token(Token = "0x400FDEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		protected readonly string E_TemplateNormal;

		[Token(Token = "0x400FDEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		protected readonly string E_TemplateSmall;

		[Token(Token = "0x400FDED")]
		private const int REWARD_NUM_PER_PAGE = 5;

		[Token(Token = "0x400FDEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		protected string titleStr;

		[Token(Token = "0x400FDEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		protected PvpMenuDefine.MatchingType matchingType;

		[Token(Token = "0x400FDF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		private int nameRegId;

		[Token(Token = "0x400FDF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		protected int logoId;

		[Token(Token = "0x400FDF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private int matchingTime2nd;

		[Token(Token = "0x400FDF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private int stage;

		[Token(Token = "0x400FDF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		protected int dispStage;

		[Token(Token = "0x400FDF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private int maxDlv;

		[Token(Token = "0x400FDF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private int rewardPageNum;

		[Token(Token = "0x400FDF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private int rewardSpaceNum;

		[Token(Token = "0x400FDF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
		protected ColosseumUtil.StatusDuelistCup status;

		[Token(Token = "0x400FDF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private InfinityScrollView isv;

		[Token(Token = "0x400FDFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private ElementObjectManager scrollEom;

		[Token(Token = "0x400FDFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private ElementObjectManager pickupEom;

		[Token(Token = "0x400FDFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400FDFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private bool m_RefreshDeckReverve;

		[Token(Token = "0x400FDFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ElementObject m_SmallButtonGroup;

		[Token(Token = "0x400FDFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private ElementObjectManager m_historyEom;

		[Token(Token = "0x400FE00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private ElementObjectManager m_RankingButtonEom;

		[Token(Token = "0x400FE01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private ElementObjectManager m_RankingButtonSmallEom;

		[Token(Token = "0x400FE02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private List<Data1stReward> rewardList;

		[Token(Token = "0x600B791")]
		[Address(RVA = "0x4F4F40", Offset = "0x4F4140", VA = "0x1804F4F40")]
		public RDCBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B792")]
		[Address(RVA = "0x4EFEA0", Offset = "0x4EF0A0", VA = "0x1804EFEA0", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B793")]
		[Address(RVA = "0x4F1450", Offset = "0x4F0650", VA = "0x1804F1450", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B794")]
		[Address(RVA = "0x4EF800", Offset = "0x4EEA00", VA = "0x1804EF800", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B795")]
		[Address(RVA = "0x4F2880", Offset = "0x4F1A80", VA = "0x1804F2880")]
		private void SetShortcutLRReward(bool isSet)
		{
		}

		[Token(Token = "0x600B796")]
		[Address(RVA = "0x4F44B0", Offset = "0x4F36B0", VA = "0x1804F44B0", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B797")]
		[Address(RVA = "0x4F3140", Offset = "0x4F2340", VA = "0x1804F3140")]
		private void UpdateDisp1stStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
		{
		}

		[Token(Token = "0x600B798")]
		[Address(RVA = "0x4EF530", Offset = "0x4EE730", VA = "0x1804EF530")]
		private string GetDlvString(int dlv)
		{
			return null;
		}

		[Token(Token = "0x600B799")]
		[Address(RVA = "0x4F4100", Offset = "0x4F3300", VA = "0x1804F4100", Slot = "26")]
		protected virtual void UpdateDisp2ndStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
		{
		}

		[Token(Token = "0x600B79A")]
		[Address(RVA = "0x4F4210", Offset = "0x4F3410", VA = "0x1804F4210")]
		private void UpdateRankingButton()
		{
		}

		[Token(Token = "0x600B79B")]
		[Address(RVA = "0x4F22E0", Offset = "0x4F14E0", VA = "0x1804F22E0")]
		private void SetRankingCallback(UnityAction action)
		{
		}

		[Token(Token = "0x600B79C")]
		[Address(RVA = "0x4F2340", Offset = "0x4F1540", VA = "0x1804F2340")]
		private void SetRankingColorContainer(int index)
		{
		}

		[Token(Token = "0x600B79D")]
		[Address(RVA = "0x4EF650", Offset = "0x4EE850", VA = "0x1804EF650", Slot = "27")]
		protected virtual string GetNorankingText()
		{
			return null;
		}

		[Token(Token = "0x600B79E")]
		[Address(RVA = "0x4EF6B0", Offset = "0x4EE8B0", VA = "0x1804EF6B0", Slot = "28")]
		protected virtual Dictionary<string, object> GetRankingViewArgs()
		{
			return null;
		}

		[Token(Token = "0x600B79F")]
		[Address(RVA = "0x4EF5B0", Offset = "0x4EE7B0", VA = "0x1804EF5B0", Slot = "29")]
		protected virtual string GetLogoPath()
		{
			return null;
		}

		[Token(Token = "0x600B7A0")]
		[Address(RVA = "0x4F0BA0", Offset = "0x4EFDA0", VA = "0x1804F0BA0", Slot = "23")]
		public bool OnResult(ViewController from, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600B7A1")]
		[Address(RVA = "0x4EEAC0", Offset = "0x4EDCC0", VA = "0x1804EEAC0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B7A2")]
		[Address(RVA = "0x4EE760", Offset = "0x4ED960", VA = "0x1804EE760", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B7A3")]
		[Address(RVA = "0x4EE850", Offset = "0x4EDA50", VA = "0x1804EE850", Slot = "19")]
		internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B7A4")]
		[Address(RVA = "0x4F0C50", Offset = "0x4EFE50", VA = "0x1804F0C50", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B7A5")]
		[Address(RVA = "0x4EFF60", Offset = "0x4EF160", VA = "0x1804EFF60")]
		protected void MovePageNextReward()
		{
		}

		[Token(Token = "0x600B7A6")]
		[Address(RVA = "0x4F00C0", Offset = "0x4EF2C0", VA = "0x1804F00C0")]
		private void OnClickDuel(int rentalState = 0)
		{
		}

		[Token(Token = "0x600B7A7")]
		[Address(RVA = "0x4EE9D0", Offset = "0x4EDBD0", VA = "0x1804EE9D0", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B7A8")]
		[Address(RVA = "0x4EF420", Offset = "0x4EE620", VA = "0x1804EF420", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B7A9")]
		[Address(RVA = "0x4EF020", Offset = "0x4EE220", VA = "0x1804EF020")]
		protected void DispReward()
		{
		}

		[Token(Token = "0x600B7AA")]
		[Address(RVA = "0x4EEBD0", Offset = "0x4EDDD0", VA = "0x1804EEBD0")]
		protected void DispAward()
		{
		}

		[Token(Token = "0x600B7AB")]
		[Address(RVA = "0x4F04E0", Offset = "0x4EF6E0", VA = "0x1804F04E0")]
		private void OnClickInfo()
		{
		}

		[Token(Token = "0x600B7AC")]
		[Address(RVA = "0x4F2F90", Offset = "0x4F2190", VA = "0x1804F2F90", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B7AD")]
		[Address(RVA = "0x4F1CD0", Offset = "0x4F0ED0", VA = "0x1804F1CD0")]
		private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
			return null;
		}

		[Token(Token = "0x600B7AE")]
		[Address(RVA = "0x4F23E0", Offset = "0x4F15E0", VA = "0x1804F23E0")]
		private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> duelMenuInfo)
		{
			return null;
		}

		[Token(Token = "0x600B7AF")]
		[Address(RVA = "0x4F0D10", Offset = "0x4EFF10", VA = "0x1804F0D10")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x600B7B0")]
		[Address(RVA = "0x4F05E0", Offset = "0x4EF7E0", VA = "0x1804F05E0")]
		private void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x600B7B1")]
		[Address(RVA = "0x4F07E0", Offset = "0x4EF9E0", VA = "0x1804F07E0")]
		private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x600B7B2")]
		[Address(RVA = "0x4F0960", Offset = "0x4EFB60", VA = "0x1804F0960")]
		private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600B7B3")]
		[Address(RVA = "0x4F0A90", Offset = "0x4EFC90", VA = "0x1804F0A90")]
		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B7B4")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "24")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B7B5")]
		[Address(RVA = "0x4EFF40", Offset = "0x4EF140", VA = "0x1804EFF40", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}

		[Token(Token = "0x600B7B6")]
		[Address(RVA = "0x4F1350", Offset = "0x4F0550", VA = "0x1804F1350", Slot = "25")]
		public void SetBg(TransitionType type)
		{
		}
	}

	[Token(Token = "0x2001C4B")]
	protected class StandardBehaviour : ModeBehaviour, ICertificationSupported, INotificationStackRemoveSupported, IOnBackSupported
	{
		[Token(Token = "0x2001C4C")]
		private class RankData
		{
			[Token(Token = "0x400FE61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int rank;

			[Token(Token = "0x400FE62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<TierData> tierList;

			[Token(Token = "0x600B810")]
			[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
			public RankData(int rank, List<TierData> tierList)
			{
			}
		}

		[Token(Token = "0x2001C4D")]
		private class TierData
		{
			[Token(Token = "0x400FE63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int tier;

			[Token(Token = "0x400FE64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardData reward;

			[Token(Token = "0x400FE65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool reached;

			[Token(Token = "0x600B811")]
			[Address(RVA = "0x508140", Offset = "0x507340", VA = "0x180508140")]
			public TierData(int tier, RewardData reward, bool reached)
			{
			}
		}

		[Token(Token = "0x2001C4E")]
		private class RewardData
		{
			[Token(Token = "0x400FE66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x400FE67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x400FE68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x400FE69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isPeriod;

			[Token(Token = "0x600B812")]
			[Address(RVA = "0x5009A0", Offset = "0x4FFBA0", VA = "0x1805009A0")]
			public RewardData(int itemCategory, int itemId, int num, bool isPeriod)
			{
			}
		}

		[Token(Token = "0x2001C55")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass76_0
		{
			[Token(Token = "0x400FE80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public StandardBehaviour _003C_003E4__this;

			[Token(Token = "0x400FE81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isReady;

			[Token(Token = "0x600B82B")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass76_0()
			{
			}

			[Token(Token = "0x600B82C")]
			[Address(RVA = "0x50B5C0", Offset = "0x50A7C0", VA = "0x18050B5C0")]
			internal void _003CyEndAction_003Eb__0()
			{
			}

			[Token(Token = "0x600B82D")]
			[Address(RVA = "0x50B5C0", Offset = "0x50A7C0", VA = "0x18050B5C0")]
			internal void _003CyEndAction_003Eb__3()
			{
			}

			[Token(Token = "0x600B82E")]
			[Address(RVA = "0x50B5C0", Offset = "0x50A7C0", VA = "0x18050B5C0")]
			internal void _003CyEndAction_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2001C56")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass76_1
		{
			[Token(Token = "0x400FE82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayableDirector pd;

			[Token(Token = "0x400FE83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass76_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x600B82F")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass76_1()
			{
			}

			[Token(Token = "0x600B830")]
			[Address(RVA = "0x50B5D0", Offset = "0x50A7D0", VA = "0x18050B5D0")]
			internal void _003CyEndAction_003Eb__2(PlayableDirector playable)
			{
			}
		}

		[Token(Token = "0x2001C5A")]
		[CompilerGenerated]
		private sealed class _003CyEndAction_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400FE88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400FE89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400FE8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public StandardBehaviour _003C_003E4__this;

			[Token(Token = "0x400FE8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass76_0 _003C_003E8__1;

			[Token(Token = "0x400FE8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass76_1 _003C_003E8__2;

			[Token(Token = "0x400FE8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Action<PlayableDirector> _003ConStopped_003E5__2;

			[Token(Token = "0x400FE8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CommonDialogViewController _003CtargetDialog_003E5__3;

			[Token(Token = "0x17001BD4")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600B83A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001BD5")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600B83C")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600B837")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyEndAction_003Ed__76(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600B838")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600B839")]
			[Address(RVA = "0x50C520", Offset = "0x50B720", VA = "0x18050C520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600B83B")]
			[Address(RVA = "0x50D1C0", Offset = "0x50C3C0", VA = "0x18050D1C0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400FE2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly string TXT_CON_WIN;

		[Token(Token = "0x400FE2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string k_EConWinGroup;

		[Token(Token = "0x400FE2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly string k_ENextRankGroup;

		[Token(Token = "0x400FE2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly string E_RootRankIconEf;

		[Token(Token = "0x400FE2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly string E_RankIconEf;

		[Token(Token = "0x400FE2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly string E_RootUpRankIconEf;

		[Token(Token = "0x400FE30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly string E_UpRankIconEf;

		[Token(Token = "0x400FE31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected readonly string E_ImageTdy;

		[Token(Token = "0x400FE32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected readonly string E_SmallButtonGroupMB;

		[Token(Token = "0x400FE33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		protected readonly string E_TemplateHighlight;

		[Token(Token = "0x400FE34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected readonly string E_TemplateNormal;

		[Token(Token = "0x400FE35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected readonly string E_TemplateSmallMB;

		[Token(Token = "0x400FE36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly string k_EScrollView;

		[Token(Token = "0x400FE37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly string k_EIconL;

		[Token(Token = "0x400FE38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly string k_EIconR;

		[Token(Token = "0x400FE39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly string k_EAnalogDirectionItem;

		[Token(Token = "0x400FE3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly string k_EPrevButton;

		[Token(Token = "0x400FE3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly string k_ENextButton;

		[Token(Token = "0x400FE3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly string k_EGaugeExtendHead;

		[Token(Token = "0x400FE3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly string k_EGaugeExtendTail;

		[Token(Token = "0x400FE3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly string k_EEntityReward;

		[Token(Token = "0x400FE3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly string k_ERootReward;

		[Token(Token = "0x400FE40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly string k_ETextItem;

		[Token(Token = "0x400FE41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly string k_EImageRank;

		[Token(Token = "0x400FE42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly string k_EImageTier;

		[Token(Token = "0x400FE43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly string k_ECurrentRank;

		[Token(Token = "0x400FE44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly string k_EImageItem;

		[Token(Token = "0x400FE45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly string k_ERecievedFrame;

		[Token(Token = "0x400FE46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly string k_ERootRecieved;

		[Token(Token = "0x400FE47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly string k_ERecievedIcon;

		[Token(Token = "0x400FE48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly string k_EDefaultFrame;

		[Token(Token = "0x400FE49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private readonly string k_ERewardComplete;

		[Token(Token = "0x400FE4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly string k_ECompleteText;

		[Token(Token = "0x400FE4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private readonly string k_ELockGroup;

		[Token(Token = "0x400FE4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly string k_ECompleteBlocker;

		[Token(Token = "0x400FE4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Coroutine m_EndActionRoutine;

		[Token(Token = "0x400FE4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private Selector m_CompleteBlocker;

		[Token(Token = "0x400FE4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private ElementObjectManager m_ScrollEom;

		[Token(Token = "0x400FE50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private InfinityScrollView m_Isv;

		[Token(Token = "0x400FE51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private List<RankData> m_RankList;

		[Token(Token = "0x400FE52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private SlidePagerWidget m_SlidePagerWidget;

		[Token(Token = "0x400FE53")]
		private const int k_RewardNumPerPage = 5;

		[Token(Token = "0x400FE54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		protected ElementObject m_SmallButtonGroup;

		[Token(Token = "0x400FE55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		protected ElementObjectManager m_historyEom;

		[Token(Token = "0x400FE56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private ElementObjectManager m_RateButtonEom;

		[Token(Token = "0x400FE57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		protected ElementObjectManager m_RankingButtonEom;

		[Token(Token = "0x400FE58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private string mmaPath;

		[Token(Token = "0x400FE59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private readonly string k_BasePathRankIcon;

		[Token(Token = "0x400FE5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private readonly string k_BasePathRankIconCurrent;

		[Token(Token = "0x400FE5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private readonly string k_BasePathTierIcon;

		[Token(Token = "0x400FE5C")]
		private const int k_HighestRank = 7;

		[Token(Token = "0x400FE5D")]
		private const int k_LowestTier = 5;

		[Token(Token = "0x400FE5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private List<string> m_PreLoadedPath;

		[Token(Token = "0x400FE5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private int m_CurrentRank;

		[Token(Token = "0x400FE60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		private int m_CurrentTier;

		[Token(Token = "0x600B7E4")]
		[Address(RVA = "0x507870", Offset = "0x506A70", VA = "0x180507870")]
		public StandardBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B7E5")]
		[Address(RVA = "0x501F00", Offset = "0x501100", VA = "0x180501F00", Slot = "18")]
		protected override bool IsDispPerformance()
		{
			return default(bool);
		}

		[Token(Token = "0x600B7E6")]
		[Address(RVA = "0x5021B0", Offset = "0x5013B0", VA = "0x1805021B0", Slot = "26")]
		protected virtual void OnClickDuel()
		{
		}

		[Token(Token = "0x600B7E7")]
		[Address(RVA = "0x503B60", Offset = "0x502D60", VA = "0x180503B60", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B7E8")]
		[Address(RVA = "0x501580", Offset = "0x500780", VA = "0x180501580", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B7E9")]
		[Address(RVA = "0x504CC0", Offset = "0x503EC0", VA = "0x180504CC0")]
		private void SetShortcutLRReward(bool isSet)
		{
		}

		[Token(Token = "0x600B7EA")]
		[Address(RVA = "0x502980", Offset = "0x501B80", VA = "0x180502980")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x600B7EB")]
		[Address(RVA = "0x502340", Offset = "0x501540", VA = "0x180502340")]
		private IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x600B7EC")]
		[Address(RVA = "0x5024C0", Offset = "0x5016C0", VA = "0x1805024C0")]
		private bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600B7ED")]
		[Address(RVA = "0x502720", Offset = "0x501920", VA = "0x180502720")]
		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B7EE")]
		[Address(RVA = "0x506620", Offset = "0x505820", VA = "0x180506620", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B7EF")]
		[Address(RVA = "0x505A00", Offset = "0x504C00", VA = "0x180505A00")]
		private void UpdateReward(int bestRank, int bestTier)
		{
		}

		[Token(Token = "0x600B7F0")]
		[Address(RVA = "0x5057F0", Offset = "0x5049F0", VA = "0x1805057F0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B7F1")]
		[Address(RVA = "0x504350", Offset = "0x503550", VA = "0x180504350", Slot = "27")]
		protected virtual List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> infoDic)
		{
			return null;
		}

		[Token(Token = "0x600B7F2")]
		[Address(RVA = "0x504880", Offset = "0x503A80", VA = "0x180504880", Slot = "28")]
		protected virtual List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> infoDic)
		{
			return null;
		}

		[Token(Token = "0x600B7F3")]
		[Address(RVA = "0x500CD0", Offset = "0x4FFED0", VA = "0x180500CD0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B7F4")]
		[Address(RVA = "0x500BE0", Offset = "0x4FFDE0", VA = "0x180500BE0", Slot = "6")]
		internal override void CallDeckCheckAPI(bool isEntry)
		{
		}

		[Token(Token = "0x600B7F5")]
		[Address(RVA = "0x5009F0", Offset = "0x4FFBF0", VA = "0x1805009F0", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B7F6")]
		[Address(RVA = "0x5080D0", Offset = "0x5072D0", VA = "0x1805080D0")]
		[IteratorStateMachine(typeof(_003CyEndAction_003Ed__76))]
		private IEnumerator yEndAction()
		{
			return null;
		}

		[Token(Token = "0x600B7F7")]
		[Address(RVA = "0x501FA0", Offset = "0x5011A0", VA = "0x180501FA0")]
		private void MovePageCurrentRank()
		{
		}

		[Token(Token = "0x600B7F8")]
		[Address(RVA = "0x5028C0", Offset = "0x501AC0", VA = "0x1805028C0", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B7F9")]
		[Address(RVA = "0x500B00", Offset = "0x4FFD00", VA = "0x180500B00", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B7FA")]
		[Address(RVA = "0x500DF0", Offset = "0x4FFFF0", VA = "0x180500DF0", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B7FB")]
		[Address(RVA = "0x5012E0", Offset = "0x5004E0", VA = "0x1805012E0")]
		private (int, int) GetRank(string label)
		{
			return default((int, int));
		}

		[Token(Token = "0x600B7FC")]
		[Address(RVA = "0x500FE0", Offset = "0x5001E0", VA = "0x180500FE0")]
		private string GetNextRankText(int rank, int tier)
		{
			return null;
		}

		[Token(Token = "0x600B7FD")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B7FE")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}

		[Token(Token = "0x600B7FF")]
		[Address(RVA = "0x5020A0", Offset = "0x5012A0", VA = "0x1805020A0", Slot = "25")]
		public bool OnBack()
		{
			return default(bool);
		}

		[Token(Token = "0x600B800")]
		[Address(RVA = "0x502830", Offset = "0x501A30", VA = "0x180502830", Slot = "24")]
		public void OnNotificationStackRemove()
		{
		}

		[Token(Token = "0x600B801")]
		[Address(RVA = "0x503720", Offset = "0x502920", VA = "0x180503720")]
		private void PreLoad()
		{
		}

		[Token(Token = "0x600B802")]
		[Address(RVA = "0x503A30", Offset = "0x502C30", VA = "0x180503A30")]
		private void ReleasePreLoad()
		{
		}
	}

	[Token(Token = "0x2001C5B")]
	protected class VersusBehaviour : ModeBehaviour, ICertificationSupported
	{
		[Token(Token = "0x2001C5C")]
		private class RewardData
		{
			[Token(Token = "0x400FEC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x400FEC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x400FEC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x400FEC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isPeriod;

			[Token(Token = "0x400FEC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int needToken;

			[Token(Token = "0x400FEC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool focus;

			[Token(Token = "0x400FEC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool received;

			[Token(Token = "0x600B863")]
			[Address(RVA = "0x4CF990", Offset = "0x4CEB90", VA = "0x1804CF990")]
			public RewardData(int itemCategory, int itemId, int num, bool isPeriod, int needToken, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x400FE8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly string BTN_PREV;

		[Token(Token = "0x400FE90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string BTN_NEXT;

		[Token(Token = "0x400FE91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly string REWARD_ROOT;

		[Token(Token = "0x400FE92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly string REWARD_NORMAL;

		[Token(Token = "0x400FE93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly string REWARD_PICKUP;

		[Token(Token = "0x400FE94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly string REWARD_DEFAULT;

		[Token(Token = "0x400FE95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly string REWARD_IMAGE;

		[Token(Token = "0x400FE96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly string REWARD_RECIEVED_FRAME;

		[Token(Token = "0x400FE97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly string REWARD_RECIEVED_ICON;

		[Token(Token = "0x400FE98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly string REWARD_DLV;

		[Token(Token = "0x400FE99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly string REWARD_NUM;

		[Token(Token = "0x400FE9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly string REWARD_GAUGE_EXTENDED_HEAD;

		[Token(Token = "0x400FE9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly string REWARD_GAUGE_EXTENDED_TAIL;

		[Token(Token = "0x400FE9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		protected readonly string SCROLL_LABEL;

		[Token(Token = "0x400FE9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		protected readonly string ANALOG_DIRECTION_ITEM;

		[Token(Token = "0x400FE9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly string ICON_L;

		[Token(Token = "0x400FE9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly string ICON_R;

		[Token(Token = "0x400FEA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		protected readonly string BTN_PICKUP;

		[Token(Token = "0x400FEA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly string PICKUP_ICON;

		[Token(Token = "0x400FEA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly string PICKUP_IMAGE;

		[Token(Token = "0x400FEA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly string PICKUP_DLV;

		[Token(Token = "0x400FEA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly string PICKUP_NUM;

		[Token(Token = "0x400FEA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		protected readonly string E_RootGroup;

		[Token(Token = "0x400FEA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		protected readonly string E_NumGroup;

		[Token(Token = "0x400FEA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		protected readonly string E_ImageParticipate;

		[Token(Token = "0x400FEA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		protected readonly string E_Text;

		[Token(Token = "0x400FEA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly string E_TextParticipate;

		[Token(Token = "0x400FEAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		protected readonly string E_InformButtonGroup;

		[Token(Token = "0x400FEAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		protected readonly string E_Template;

		[Token(Token = "0x400FEAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly string E_TemplateSmall;

		[Token(Token = "0x400FEAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly string E_TemplateSmallMB;

		[Token(Token = "0x400FEAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		protected readonly string E_TextMyPoint;

		[Token(Token = "0x400FEAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly string E_TextMyPointLabel;

		[Token(Token = "0x400FEB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		protected readonly string E_TextTotalPoint;

		[Token(Token = "0x400FEB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly string E_TextTotalPointLabel;

		[Token(Token = "0x400FEB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		protected readonly string E_TextTotalPointTime;

		[Token(Token = "0x400FEB3")]
		private const int REWARD_NUM_PER_PAGE = 5;

		[Token(Token = "0x400FEB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		protected readonly int k_GroupNum;

		[Token(Token = "0x400FEB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		protected int logoId;

		[Token(Token = "0x400FEB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		protected string titleStr;

		[Token(Token = "0x400FEB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		protected ColosseumUtil.StatusVersus status;

		[Token(Token = "0x400FEB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		protected InfinityScrollView isv;

		[Token(Token = "0x400FEB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		protected ElementObjectManager scrollEom;

		[Token(Token = "0x400FEBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		protected ElementObjectManager pickupEom;

		[Token(Token = "0x400FEBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400FEBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private List<RewardData> rewardList;

		[Token(Token = "0x400FEBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private int rewardPageNum;

		[Token(Token = "0x400FEBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private int rewardSpaceNum;

		[Token(Token = "0x400FEBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		protected (bool dirtyFlag, int id) currentGroup;

		[Token(Token = "0x400FEC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private bool isCalledDetailAPI;

		[Token(Token = "0x400FEC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		protected string mmaPath;

		[Token(Token = "0x600B83D")]
		[Address(RVA = "0x519030", Offset = "0x518230", VA = "0x180519030")]
		public VersusBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId, int group_id, bool isCalledDetailAPI, int groupNum)
		{
		}

		[Token(Token = "0x600B83E")]
		[Address(RVA = "0x515A20", Offset = "0x514C20", VA = "0x180515A20", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B83F")]
		[Address(RVA = "0x513AA0", Offset = "0x512CA0", VA = "0x180513AA0", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B840")]
		[Address(RVA = "0x514440", Offset = "0x513640", VA = "0x180514440")]
		private void InitGroup()
		{
		}

		[Token(Token = "0x600B841")]
		[Address(RVA = "0x516C60", Offset = "0x515E60", VA = "0x180516C60")]
		protected void SetShortcutLRReward(bool isSet)
		{
		}

		[Token(Token = "0x600B842")]
		[Address(RVA = "0x518540", Offset = "0x517740", VA = "0x180518540", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B843")]
		[Address(RVA = "0x5173A0", Offset = "0x5165A0", VA = "0x1805173A0", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B844")]
		[Address(RVA = "0x512DF0", Offset = "0x511FF0", VA = "0x180512DF0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B845")]
		[Address(RVA = "0x512C70", Offset = "0x511E70", VA = "0x180512C70", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B846")]
		[Address(RVA = "0x514D10", Offset = "0x513F10", VA = "0x180514D10", Slot = "16")]
		internal override void OnTransitionEnd(TransitionType type)
		{
		}

		[Token(Token = "0x600B847")]
		[Address(RVA = "0x514740", Offset = "0x513940", VA = "0x180514740")]
		private void MovePageNextReward()
		{
		}

		[Token(Token = "0x600B848")]
		[Address(RVA = "0x512D00", Offset = "0x511F00", VA = "0x180512D00", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B849")]
		[Address(RVA = "0x513720", Offset = "0x512920", VA = "0x180513720", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B84A")]
		[Address(RVA = "0x5177A0", Offset = "0x5169A0", VA = "0x1805177A0")]
		protected void UpdateReward(int token)
		{
		}

		[Token(Token = "0x600B84B")]
		[Address(RVA = "0x514DE0", Offset = "0x513FE0", VA = "0x180514DE0")]
		protected void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x600B84C")]
		[Address(RVA = "0x514950", Offset = "0x513B50", VA = "0x180514950")]
		protected IReadOnlyList<(SelectionItem, int, int)> OnCustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x600B84D")]
		[Address(RVA = "0x514AD0", Offset = "0x513CD0", VA = "0x180514AD0")]
		protected bool OnCustomInnerTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600B84E")]
		[Address(RVA = "0x515420", Offset = "0x514620", VA = "0x180515420", Slot = "24")]
		protected virtual void SelectDeckButton()
		{
		}

		[Token(Token = "0x600B84F")]
		[Address(RVA = "0x514C00", Offset = "0x513E00", VA = "0x180514C00")]
		protected void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		[Token(Token = "0x600B850")]
		[Address(RVA = "0x516800", Offset = "0x515A00", VA = "0x180516800")]
		private List<ColosseumDeckWidget.ButtonInfo> SetRentalDeck(Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B851")]
		[Address(RVA = "0x5160F0", Offset = "0x5152F0", VA = "0x1805160F0")]
		private List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> MTdic, Dictionary<string, object> tInfoDic)
		{
			return null;
		}

		[Token(Token = "0x600B852")]
		[Address(RVA = "0x5131F0", Offset = "0x5123F0", VA = "0x1805131F0")]
		private void DispReward()
		{
		}

		[Token(Token = "0x600B853")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private void CallAPIOpenCampaignPack(int item_id, int num, [Optional] Action onSuccess)
		{
		}

		[Token(Token = "0x600B854")]
		[Address(RVA = "0x515450", Offset = "0x514650", VA = "0x180515450", Slot = "25")]
		protected virtual void SetGroup(int groupNo)
		{
		}

		[Token(Token = "0x600B855")]
		[Address(RVA = "0x516E00", Offset = "0x516000", VA = "0x180516E00")]
		protected string SetTotalPointText()
		{
			return null;
		}

		[Token(Token = "0x600B856")]
		[Address(RVA = "0x512FC0", Offset = "0x5121C0", VA = "0x180512FC0")]
		private void DispResult([Optional] UnityAction OnFinished)
		{
		}

		[Token(Token = "0x600B857")]
		[Address(RVA = "0x513680", Offset = "0x512880", VA = "0x180513680", Slot = "26")]
		protected virtual void FinishResult()
		{
		}

		[Token(Token = "0x600B858")]
		[Address(RVA = "0x5138B0", Offset = "0x512AB0", VA = "0x1805138B0", Slot = "27")]
		protected virtual void HidePoint(int groupNo)
		{
		}

		[Token(Token = "0x600B859")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "23")]
		public ElementObjectManager GetCertificationEom()
		{
			return null;
		}

		[Token(Token = "0x600B85A")]
		[Address(RVA = "0x514730", Offset = "0x513930", VA = "0x180514730", Slot = "11")]
		internal override bool IsHoldingByStatus()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001C69")]
	protected class VersusBehaviour_3VS : VersusBehaviour, ICertificationSupported
	{
		[Token(Token = "0x2001C6A")]
		private class ActionMenu
		{
			[Token(Token = "0x400FEF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ActionSheetViewController.EntryData entryData;

			[Token(Token = "0x400FEF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityAction action;

			[Token(Token = "0x600B8BB")]
			[Address(RVA = "0x533970", Offset = "0x532B70", VA = "0x180533970")]
			public static ActionMenu Create(string btnLabel, UnityAction btnCallback)
			{
				return null;
			}

			[Token(Token = "0x600B8BC")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public ActionMenu()
			{
			}
		}

		[Token(Token = "0x400FEF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private readonly string k_ELabelHistoryButton;

		[Token(Token = "0x400FEF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private readonly string k_ELabelEventDetailButton;

		[Token(Token = "0x400FEF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private readonly string k_ELabelShortcutIcon1;

		[Token(Token = "0x400FEF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public bool m_IsUseEventDeck;

		[Token(Token = "0x600B893")]
		[Address(RVA = "0x512B70", Offset = "0x511D70", VA = "0x180512B70")]
		public VersusBehaviour_3VS(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId, int group_id, bool isCalledDetailAPI, int groupNum)
		{
		}

		[Token(Token = "0x600B894")]
		[Address(RVA = "0x50D920", Offset = "0x50CB20", VA = "0x18050D920", Slot = "8")]
		internal override void InitDisp()
		{
		}

		[Token(Token = "0x600B895")]
		[Address(RVA = "0x50F980", Offset = "0x50EB80", VA = "0x18050F980", Slot = "24")]
		protected override void SelectDeckButton()
		{
		}

		[Token(Token = "0x600B896")]
		[Address(RVA = "0x510020", Offset = "0x50F220", VA = "0x180510020", Slot = "7")]
		internal override void SetMenu()
		{
		}

		[Token(Token = "0x600B897")]
		[Address(RVA = "0x5120E0", Offset = "0x5112E0", VA = "0x1805120E0", Slot = "9")]
		internal override void UpdateView(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B898")]
		[Address(RVA = "0x50FA30", Offset = "0x50EC30", VA = "0x18050FA30", Slot = "25")]
		protected override void SetGroup(int groupNo)
		{
		}

		[Token(Token = "0x600B899")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
		protected override void FinishResult()
		{
		}

		[Token(Token = "0x600B89A")]
		[Address(RVA = "0x50D730", Offset = "0x50C930", VA = "0x18050D730", Slot = "27")]
		protected override void HidePoint(int groupNo)
		{
		}

		[Token(Token = "0x600B89B")]
		[Address(RVA = "0x511680", Offset = "0x510880", VA = "0x180511680", Slot = "10")]
		internal override void UpdateDeckWidget(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
		}

		[Token(Token = "0x600B89C")]
		[Address(RVA = "0x50E3A0", Offset = "0x50D5A0", VA = "0x18050E3A0")]
		private void OpenEmptyAction()
		{
		}

		[Token(Token = "0x600B89D")]
		[Address(RVA = "0x50F160", Offset = "0x50E360", VA = "0x18050F160")]
		private void OpenRentalActionNoSetMyDeck()
		{
		}

		[Token(Token = "0x600B89E")]
		[Address(RVA = "0x50F5B0", Offset = "0x50E7B0", VA = "0x18050F5B0")]
		private void OpenRentalActionSetMyDeck()
		{
		}

		[Token(Token = "0x600B89F")]
		[Address(RVA = "0x50E7F0", Offset = "0x50D9F0", VA = "0x18050E7F0")]
		private void OpenMyDeckAction()
		{
		}

		[Token(Token = "0x600B8A0")]
		[Address(RVA = "0x50D670", Offset = "0x50C870", VA = "0x18050D670")]
		private ActionMenu ActionMenuUseRentalDeck()
		{
			return null;
		}

		[Token(Token = "0x600B8A1")]
		[Address(RVA = "0x50D310", Offset = "0x50C510", VA = "0x18050D310")]
		private ActionMenu ActionMenuCreateEventDeck()
		{
			return null;
		}

		[Token(Token = "0x600B8A2")]
		[Address(RVA = "0x50D200", Offset = "0x50C400", VA = "0x18050D200")]
		private ActionMenu ActionMenuCopyFromMyDeck(bool isSetMydeck)
		{
			return null;
		}

		[Token(Token = "0x600B8A3")]
		[Address(RVA = "0x50D5B0", Offset = "0x50C7B0", VA = "0x18050D5B0")]
		private ActionMenu ActionMenuUseEventDeck()
		{
			return null;
		}

		[Token(Token = "0x600B8A4")]
		[Address(RVA = "0x50D4F0", Offset = "0x50C6F0", VA = "0x18050D4F0")]
		private ActionMenu ActionMenuEditEentDeck()
		{
			return null;
		}

		[Token(Token = "0x600B8A5")]
		[Address(RVA = "0x50D3D0", Offset = "0x50C5D0", VA = "0x18050D3D0")]
		private ActionMenu ActionMenuEditAccessory(bool isFixedAccessory, bool isFixedPickCards)
		{
			return null;
		}
	}

	[Token(Token = "0x2001C75")]
	protected class WCSBehaviour : DuelistCupBehaviour
	{
		[Token(Token = "0x400FF11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private readonly string E_TextGroupName;

		[Token(Token = "0x600B8D8")]
		[Address(RVA = "0x54ADD0", Offset = "0x549FD0", VA = "0x18054ADD0")]
		public WCSBehaviour(ColosseumUtil.PlayMode playMode, Util.GameMode gameMode, ViewControllerManager manager, ColosseumInfoViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager menuEOM, int eventId)
		{
		}

		[Token(Token = "0x600B8D9")]
		[Address(RVA = "0x54A080", Offset = "0x549280", VA = "0x18054A080", Slot = "28")]
		protected override string GetNorankingText()
		{
			return null;
		}

		[Token(Token = "0x600B8DA")]
		[Address(RVA = "0x54A0E0", Offset = "0x5492E0", VA = "0x18054A0E0", Slot = "29")]
		protected override Dictionary<string, object> GetRankingViewArgs()
		{
			return null;
		}

		[Token(Token = "0x600B8DB")]
		[Address(RVA = "0x54A2B0", Offset = "0x5494B0", VA = "0x18054A2B0", Slot = "32")]
		protected override void OnClickInfo()
		{
		}

		[Token(Token = "0x600B8DC")]
		[Address(RVA = "0x549FE0", Offset = "0x5491E0", VA = "0x180549FE0", Slot = "31")]
		protected override string GetLogoPath()
		{
			return null;
		}

		[Token(Token = "0x600B8DD")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "30")]
		protected override int GetBGId()
		{
			return default(int);
		}

		[Token(Token = "0x600B8DE")]
		[Address(RVA = "0x549DB0", Offset = "0x548FB0", VA = "0x180549DB0", Slot = "5")]
		internal override void CallDetailAPI(bool isEntry, [Optional] Action onFinished)
		{
		}

		[Token(Token = "0x600B8DF")]
		[Address(RVA = "0x549B70", Offset = "0x548D70", VA = "0x180549B70", Slot = "20")]
		internal override void ApiEndAction(bool isEntry)
		{
		}

		[Token(Token = "0x600B8E0")]
		[Address(RVA = "0x549C30", Offset = "0x548E30", VA = "0x180549C30", Slot = "19")]
		internal override void BackAction(ViewControllerManager vcm, ViewController vc, bool isEntry)
		{
		}

		[Token(Token = "0x600B8E1")]
		[Address(RVA = "0x54A230", Offset = "0x549430", VA = "0x18054A230", Slot = "22")]
		internal override bool IsUpdateDisp(ViewController vc)
		{
			return default(bool);
		}

		[Token(Token = "0x600B8E2")]
		[Address(RVA = "0x549CC0", Offset = "0x548EC0", VA = "0x180549CC0", Slot = "12")]
		internal override void CallAPIGetDeckList(int id, Action onSuccess)
		{
		}

		[Token(Token = "0x600B8E3")]
		[Address(RVA = "0x549ED0", Offset = "0x5490D0", VA = "0x180549ED0", Slot = "13")]
		internal override Dictionary<string, object> GetDeckArgs(int identifer, bool isScratch)
		{
			return null;
		}

		[Token(Token = "0x600B8E4")]
		[Address(RVA = "0x54AB60", Offset = "0x549D60", VA = "0x18054AB60", Slot = "27")]
		protected override void UpdateDisp2ndStage(Dictionary<string, object> masterDic, Dictionary<string, object> duelMenuDic)
		{
		}

		[Token(Token = "0x600B8E5")]
		[Address(RVA = "0x54A470", Offset = "0x549670", VA = "0x18054A470", Slot = "26")]
		protected override List<ColosseumDeckWidget.ButtonInfo> SetMyDeck(Dictionary<string, object> masterInfo, Dictionary<string, object> duelMenuInfo)
		{
			return null;
		}
	}

	[Token(Token = "0x2001C7B")]
	public interface IOnResultSupported
	{
		[Token(Token = "0x600B8F7")]
		bool OnResult(ViewController from, object value);
	}

	[Token(Token = "0x2001C7C")]
	public interface IOnBackSupported
	{
		[Token(Token = "0x600B8F8")]
		bool OnBack();
	}

	[Token(Token = "0x2001C7D")]
	public interface INotificationStackRemoveSupported
	{
		[Token(Token = "0x600B8F9")]
		void OnNotificationStackRemove();
	}

	[Token(Token = "0x2001C7E")]
	public interface INotificationStackSupported
	{
		[Token(Token = "0x600B8FA")]
		void OnNotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry);
	}

	[Token(Token = "0x2001C7F")]
	public interface IOnFocusChangedSupported
	{
		[Token(Token = "0x600B8FB")]
		void OnFocusChanged(bool setfocus);
	}

	[Token(Token = "0x2001C80")]
	public interface IOutGameBgSupported
	{
		[Token(Token = "0x600B8FC")]
		void SetBg(TransitionType type);
	}

	[Token(Token = "0x400FBCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected readonly string ROOT_MENU_LABEL;

	[Token(Token = "0x400FBCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected readonly string VIEW_STANDARD_LABEL;

	[Token(Token = "0x400FBCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected readonly string VIEW_RATE_LABEL;

	[Token(Token = "0x400FBD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	protected readonly string VIEW_TOURNAMENT_LABEL;

	[Token(Token = "0x400FBD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected readonly string VIEW_EXHIBITION_LABEL;

	[Token(Token = "0x400FBD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	protected readonly string VIEW_FREE_LABEL;

	[Token(Token = "0x400FBD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected readonly string VIEW_DUELISTCUP_LABEL;

	[Token(Token = "0x400FBD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected readonly string VIEW_RANKEVENT_LABEL;

	[Token(Token = "0x400FBD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected readonly string VIEW_DICERALLY_LABEL;

	[Token(Token = "0x400FBD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected readonly string VIEW_LABEL;

	[Token(Token = "0x400FBD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected readonly string BTN_MISSION;

	[Token(Token = "0x400FBD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_ALabelDeckOverview;

	[Token(Token = "0x400FBD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject certificationIcon;

	[Token(Token = "0x400FBDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject missionIcon;

	[Token(Token = "0x400FBDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected ColosseumUtil.PlayMode mode;

	[Token(Token = "0x400FBDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected ModeBehaviour modeBehaviour;

	[Token(Token = "0x400FBDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected ElementObjectManager deckOverviewPrefab;

	[Token(Token = "0x400FBDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private string colosseumBGMLabel;

	[Token(Token = "0x17001BCD")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B596")]
		[Address(RVA = "0x4C1700", Offset = "0x4C0900", VA = "0x1804C1700", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BCE")]
	public string ColosseumBGMLabel
	{
		[Token(Token = "0x600B597")]
		[Address(RVA = "0x4C15C0", Offset = "0x4C07C0", VA = "0x1804C15C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600B598")]
		[Address(RVA = "0x4C19D0", Offset = "0x4C0BD0", VA = "0x1804C19D0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BCF")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x600B599")]
		[Address(RVA = "0x4C15D0", Offset = "0x4C07D0", VA = "0x1804C15D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600B59A")]
	[Address(RVA = "0x4BF390", Offset = "0x4BE590", VA = "0x1804BF390")]
	private int GetSelectorPriorityAddRange()
	{
		return default(int);
	}

	[Token(Token = "0x600B59B")]
	[Address(RVA = "0x4BF310", Offset = "0x4BE510", VA = "0x1804BF310")]
	private void Awake()
	{
	}

	[Token(Token = "0x600B59C")]
	[Address(RVA = "0x4BF950", Offset = "0x4BEB50", VA = "0x1804BF950", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x600B59D")]
	[Address(RVA = "0x4BF4E0", Offset = "0x4BE6E0", VA = "0x1804BF4E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B59E")]
	[Address(RVA = "0x4BFBF0", Offset = "0x4BEDF0", VA = "0x1804BFBF0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B59F")]
	[Address(RVA = "0x4C0DE0", Offset = "0x4BFFE0", VA = "0x1804C0DE0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x600B5A0")]
	[Address(RVA = "0x4C11A0", Offset = "0x4C03A0", VA = "0x1804C11A0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B5A1")]
	[Address(RVA = "0x4C1060", Offset = "0x4C0260", VA = "0x1804C1060", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x600B5A2")]
	[Address(RVA = "0x4C0F60", Offset = "0x4C0160", VA = "0x1804C0F60", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600B5A3")]
	[Address(RVA = "0x4BFB80", Offset = "0x4BED80", VA = "0x1804BFB80", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600B5A4")]
	[Address(RVA = "0x4BF860", Offset = "0x4BEA60", VA = "0x1804BF860", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600B5A5")]
	[Address(RVA = "0x4C10B0", Offset = "0x4C02B0", VA = "0x1804C10B0", Slot = "26")]
	protected override void OnTransitionSetBg(TransitionType type)
	{
	}

	[Token(Token = "0x600B5A6")]
	[Address(RVA = "0x4C1350", Offset = "0x4C0550", VA = "0x1804C1350")]
	public ColosseumInfoViewController()
	{
	}
}
