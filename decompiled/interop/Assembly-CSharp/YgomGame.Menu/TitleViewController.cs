using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20013DB")]
public class TitleViewController : BaseMenuViewController, IFadeSupported
{
	[Token(Token = "0x20013DC")]
	private enum Step
	{
		[Token(Token = "0x400C427")]
		Title,
		[Token(Token = "0x400C428")]
		DemoStart,
		[Token(Token = "0x400C429")]
		GameStart
	}

	[Token(Token = "0x20013DD")]
	public enum LayoutType
	{
		[Token(Token = "0x400C42B")]
		None,
		[Token(Token = "0x400C42C")]
		LogoOnly,
		[Token(Token = "0x400C42D")]
		LogoAndMonster,
		[Token(Token = "0x400C42E")]
		AutoStart
	}

	[Token(Token = "0x20013DE")]
	private class TitleSpecialDisplayDef
	{
		[Token(Token = "0x400C42F")]
		[FieldOffset(Offset = "0x10")]
		public int wallpaperID;

		[Token(Token = "0x400C430")]
		[FieldOffset(Offset = "0x14")]
		public int overlayBGID;

		[Token(Token = "0x6007B9E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TitleSpecialDisplayDef()
		{
		}
	}

	[Token(Token = "0x20013E0")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		[Token(Token = "0x400C439")]
		[FieldOffset(Offset = "0x10")]
		public StepSequencer seq;

		[Token(Token = "0x6007BA8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[Token(Token = "0x6007BA9")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F8B0", VA = "0x180C506B0")]
		internal void _003CstepGameStart_003Eb__3()
		{
		}
	}

	[Token(Token = "0x20013E1")]
	[CompilerGenerated]
	private sealed class _003CstepGameStart_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C43A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C43B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C43C")]
		[FieldOffset(Offset = "0x20")]
		public StepSequencer seq;

		[Token(Token = "0x400C43D")]
		[FieldOffset(Offset = "0x28")]
		public TitleViewController _003C_003E4__this;

		[Token(Token = "0x400C43E")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

		[Token(Token = "0x170012FC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007BAD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012FD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007BAF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007BAA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepGameStart_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007BAB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007BAC")]
		[Address(RVA = "0xC50CA0", Offset = "0xC4FEA0", VA = "0x180C50CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007BAE")]
		[Address(RVA = "0xC514F0", Offset = "0xC506F0", VA = "0x180C514F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C402")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x400C403")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_autoStart;

	[Token(Token = "0x400C404")]
	[FieldOffset(Offset = "0xDC")]
	private float m_autoStartWaitTimer;

	[Token(Token = "0x400C405")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string BTN_START_LABEL;

	[Token(Token = "0x400C406")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BTN_SETTING_LABEL;

	[Token(Token = "0x400C407")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BTN_DATALINK_LABEL;

	[Token(Token = "0x400C408")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string BTN_KONAMI_LABEL;

	[Token(Token = "0x400C409")]
	[FieldOffset(Offset = "0x100")]
	private readonly string BTN_BACKKEYSHORTCUT_LABEL;

	[Token(Token = "0x400C40A")]
	[FieldOffset(Offset = "0x108")]
	private readonly string MONSTER_WALLPAPER_ROOT_LABEL;

	[Token(Token = "0x400C40B")]
	[FieldOffset(Offset = "0x110")]
	private readonly string MONSTER_WALLPAPER_LABEL;

	[Token(Token = "0x400C40C")]
	[FieldOffset(Offset = "0x118")]
	private readonly string ICON_PLATFORM_LABEL;

	[Token(Token = "0x400C40D")]
	[FieldOffset(Offset = "0x120")]
	private readonly string ICON_START_LABEL;

	[Token(Token = "0x400C40E")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TITLELOGO_LABEL;

	[Token(Token = "0x400C40F")]
	[FieldOffset(Offset = "0x130")]
	private readonly string TITLELOGOSET_LABEL;

	[Token(Token = "0x400C410")]
	[FieldOffset(Offset = "0x138")]
	private readonly string PRESSMSGTEXT_LABEL;

	[Token(Token = "0x400C411")]
	[FieldOffset(Offset = "0x140")]
	private readonly string CODEVER_LABEL;

	[Token(Token = "0x400C412")]
	[FieldOffset(Offset = "0x148")]
	private readonly string PLAYERID_LABEL;

	[Token(Token = "0x400C413")]
	[FieldOffset(Offset = "0x150")]
	private readonly string TEXT_GAMESTART_LABEL;

	[Token(Token = "0x400C414")]
	[FieldOffset(Offset = "0x158")]
	private readonly string TEXT_SAFEMODE_LABEL;

	[Token(Token = "0x400C415")]
	[FieldOffset(Offset = "0x160")]
	private GameObject m_currentWallpaperMonster;

	[Token(Token = "0x400C416")]
	[FieldOffset(Offset = "0x168")]
	private int m_monsterWallpaperID;

	[Token(Token = "0x400C417")]
	[FieldOffset(Offset = "0x16C")]
	private bool m_anniv;

	[Token(Token = "0x400C418")]
	[FieldOffset(Offset = "0x170")]
	private int m_overlayBGID;

	[Token(Token = "0x400C419")]
	[FieldOffset(Offset = "0x178")]
	private IReadOnlyCollection<TitleSettingMenuID> m_menuOrder;

	[Token(Token = "0x400C41A")]
	[FieldOffset(Offset = "0x180")]
	private PlayableDirector titleLogoDirector;

	[Token(Token = "0x400C41B")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	private PlayableAsset beginTimeline;

	[Token(Token = "0x400C41C")]
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	private PlayableAsset fadeInTimeline;

	[Token(Token = "0x400C41D")]
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	private PlayableAsset fadeOutTimeline;

	[Token(Token = "0x400C41E")]
	[FieldOffset(Offset = "0x1A0")]
	private bool m_demoDataReady;

	[Token(Token = "0x400C41F")]
	private const float DefaultDemoStartTime = 45f;

	[Token(Token = "0x400C420")]
	[FieldOffset(Offset = "0x1A4")]
	private float m_demoTimer;

	[Token(Token = "0x400C421")]
	[FieldOffset(Offset = "0x1A8")]
	private bool m_demoTimerActive;

	[Token(Token = "0x400C422")]
	[FieldOffset(Offset = "0x1AC")]
	private LayoutType m_layout;

	[Token(Token = "0x400C423")]
	[FieldOffset(Offset = "0x0")]
	private static readonly TitleSpecialDisplayDef[] s_specialDefs;

	[Token(Token = "0x400C424")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int k_annivWallpaperID;

	[Token(Token = "0x400C425")]
	[FieldOffset(Offset = "0x10")]
	private static TitleViewController s_instance;

	[Token(Token = "0x170012F8")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007B6C")]
		[Address(RVA = "0xC4D9A0", Offset = "0xC4CBA0", VA = "0x180C4D9A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F9")]
	private bool isEnableAction
	{
		[Token(Token = "0x6007B6D")]
		[Address(RVA = "0xC4D950", Offset = "0xC4CB50", VA = "0x180C4D950")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012FA")]
	private static bool enablePlatformIcon
	{
		[Token(Token = "0x6007B8E")]
		[Address(RVA = "0xC4D8E0", Offset = "0xC4CAE0", VA = "0x180C4D8E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012FB")]
	public static TitleViewController Instance
	{
		[Token(Token = "0x6007B93")]
		[Address(RVA = "0xC4D810", Offset = "0xC4CA10", VA = "0x180C4D810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007B6E")]
	[Address(RVA = "0xC4D460", Offset = "0xC4C660", VA = "0x180C4D460")]
	private void clickAction(Action action)
	{
	}

	[Token(Token = "0x6007B6F")]
	[Address(RVA = "0xC4DB60", Offset = "0xC4CD60", VA = "0x180C4DB60")]
	private static bool isMobile()
	{
		return default(bool);
	}

	[Token(Token = "0x6007B70")]
	[Address(RVA = "0xC4AFB0", Offset = "0xC4A1B0", VA = "0x180C4AFB0")]
	private void OnClickStart()
	{
	}

	[Token(Token = "0x6007B71")]
	[Address(RVA = "0xC4ADD0", Offset = "0xC49FD0", VA = "0x180C4ADD0")]
	private void OnClickSettingMenu()
	{
	}

	[Token(Token = "0x6007B72")]
	[Address(RVA = "0xC4ACF0", Offset = "0xC49EF0", VA = "0x180C4ACF0")]
	private void OnClickDataLink()
	{
	}

	[Token(Token = "0x6007B73")]
	[Address(RVA = "0xC4ACA0", Offset = "0xC49EA0", VA = "0x180C4ACA0")]
	private void OnClickCompany()
	{
	}

	[Token(Token = "0x6007B74")]
	[Address(RVA = "0xC4AC50", Offset = "0xC49E50", VA = "0x180C4AC50")]
	private void OnClickBackKey()
	{
	}

	[Token(Token = "0x6007B75")]
	[Address(RVA = "0xC4DBB0", Offset = "0xC4CDB0", VA = "0x180C4DBB0")]
	private static void openMainteDialog()
	{
	}

	[Token(Token = "0x6007B76")]
	[Address(RVA = "0xC4A460", Offset = "0xC49660", VA = "0x180C4A460", Slot = "28")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x6007B77")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "29")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x6007B78")]
	[Address(RVA = "0xC4A480", Offset = "0xC49680", VA = "0x180C4A480", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007B79")]
	[Address(RVA = "0xC4B180", Offset = "0xC4A380", VA = "0x180C4B180", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007B7A")]
	[Address(RVA = "0xC4AA90", Offset = "0xC49C90", VA = "0x180C4AA90", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007B7B")]
	[Address(RVA = "0xC4BD00", Offset = "0xC4AF00", VA = "0x180C4BD00", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6007B7C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
	protected override void OnTransitionSetBg(TransitionType type)
	{
	}

	[Token(Token = "0x6007B7D")]
	[Address(RVA = "0xC4AAF0", Offset = "0xC49CF0", VA = "0x180C4AAF0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6007B7E")]
	[Address(RVA = "0xC4A380", Offset = "0xC49580", VA = "0x180C4A380")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007B7F")]
	[Address(RVA = "0xC4BC20", Offset = "0xC4AE20", VA = "0x180C4BC20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007B80")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6007B81")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x6007B82")]
	[Address(RVA = "0xC4E500", Offset = "0xC4D700", VA = "0x180C4E500")]
	private void stepTitle(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007B83")]
	[Address(RVA = "0xC4E1F0", Offset = "0xC4D3F0", VA = "0x180C4E1F0")]
	private void stepDemoStart(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007B84")]
	[Address(RVA = "0xC4E470", Offset = "0xC4D670", VA = "0x180C4E470")]
	[IteratorStateMachine(typeof(_003CstepGameStart_003Ed__61))]
	private IEnumerator stepGameStart(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007B85")]
	[Address(RVA = "0xC4D750", Offset = "0xC4C950", VA = "0x180C4D750")]
	private static TitleSpecialDisplayDef getSpecialDefByWallpaper(int wallpaperID)
	{
		return null;
	}

	[Token(Token = "0x6007B86")]
	[Address(RVA = "0xC4C060", Offset = "0xC4B260", VA = "0x180C4C060")]
	private void PrepareLayout(LayoutType type)
	{
	}

	[Token(Token = "0x6007B87")]
	[Address(RVA = "0xC4D560", Offset = "0xC4C760", VA = "0x180C4D560")]
	private static int fetchMonsterWallpaperID()
	{
		return default(int);
	}

	[Token(Token = "0x6007B88")]
	[Address(RVA = "0xC4E080", Offset = "0xC4D280", VA = "0x180C4E080")]
	private void setMonsterWallpaper(int id)
	{
	}

	[Token(Token = "0x6007B89")]
	[Address(RVA = "0xC4D5F0", Offset = "0xC4C7F0", VA = "0x180C4D5F0")]
	private static int getOverlayBGID(int wallpaperID)
	{
		return default(int);
	}

	[Token(Token = "0x6007B8A")]
	[Address(RVA = "0xC4DFD0", Offset = "0xC4D1D0", VA = "0x180C4DFD0")]
	private static void pushOverlayBG(int id)
	{
	}

	[Token(Token = "0x6007B8B")]
	[Address(RVA = "0xC4DF90", Offset = "0xC4D190", VA = "0x180C4DF90")]
	private static void popOverlayBG()
	{
	}

	[Token(Token = "0x6007B8C")]
	[Address(RVA = "0xC4DAE0", Offset = "0xC4CCE0", VA = "0x180C4DAE0")]
	private static bool isAnnivWallpaper(int wallpaperID)
	{
		return default(bool);
	}

	[Token(Token = "0x6007B8D")]
	[Address(RVA = "0xC4D4C0", Offset = "0xC4C6C0", VA = "0x180C4D4C0")]
	private void dispAnnivLogo(bool show)
	{
	}

	[Token(Token = "0x6007B8F")]
	[Address(RVA = "0xC4AD40", Offset = "0xC49F40", VA = "0x180C4AD40")]
	private void OnClickPlatformIcon()
	{
	}

	[Token(Token = "0x6007B90")]
	[Address(RVA = "0xC4C010", Offset = "0xC4B210", VA = "0x180C4C010")]
	public void OpenDataLink()
	{
	}

	[Token(Token = "0x6007B91")]
	[Address(RVA = "0xC4C640", Offset = "0xC4B840", VA = "0x180C4C640")]
	public void StartGame()
	{
	}

	[Token(Token = "0x6007B92")]
	[Address(RVA = "0xC4A470", Offset = "0xC49670", VA = "0x180C4A470")]
	public float GetDemoStartTime()
	{
		return default(float);
	}

	[Token(Token = "0x6007B94")]
	[Address(RVA = "0xC4D160", Offset = "0xC4C360", VA = "0x180C4D160")]
	public TitleViewController()
	{
	}
}
