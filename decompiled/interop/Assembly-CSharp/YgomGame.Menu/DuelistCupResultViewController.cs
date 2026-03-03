using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200115D")]
public class DuelistCupResultViewController : BaseMenuViewController, IFadeSupported
{
	[Token(Token = "0x400B662")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400B663")]
	private const string k_ArgkeyGameMode = "gameMode";

	[Token(Token = "0x400B664")]
	private const string k_ArgkeyEventId = "event_id";

	[Token(Token = "0x400B665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelBackShortcutButton;

	[Token(Token = "0x400B666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string DP_INFO_LABEL;

	[Token(Token = "0x400B667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string DP_INFOROOT_LABEL;

	[Token(Token = "0x400B668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string TW_WIN_LABEL;

	[Token(Token = "0x400B669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TW_DROW_LABEL;

	[Token(Token = "0x400B66A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TW_LOSE_LABEL;

	[Token(Token = "0x400B66B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TEXT_TOTAL_DP_LABEL;

	[Token(Token = "0x400B66C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TEXT_ADD_DP_LABEL;

	[Token(Token = "0x400B66D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TEXT_STAGE_LABEL;

	[Token(Token = "0x400B66E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TEXT_RESULTLABEL_LABEL;

	[Token(Token = "0x400B66F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string TEXT_WIN_LABEL;

	[Token(Token = "0x400B670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string TEXT_WIN_NUM_LABEL;

	[Token(Token = "0x400B671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string TEXT_BEFORE_DP_LABEL;

	[Token(Token = "0x400B672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string IMAGE_ARROW_LABEL;

	[Token(Token = "0x400B673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject m_View3D;

	[Token(Token = "0x400B674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private bool is_initialised;

	[Token(Token = "0x400B675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private ElementObjectManager m_TargetEom;

	[Token(Token = "0x400B676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ElementObjectManager eom;

	[Token(Token = "0x400B677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ElementObject bg;

	[Token(Token = "0x400B678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Tween BeforeDPTextTween;

	[Token(Token = "0x400B679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Tween DiffDPTextTween;

	[Token(Token = "0x400B67A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Tween TotalDPTextTween;

	[Token(Token = "0x400B67B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private SelectionButton buttonBackArea;

	[Token(Token = "0x400B67C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Engine.ResultType resultType;

	[Token(Token = "0x400B67D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private bool isStartTween;

	[Token(Token = "0x400B67E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18D")]
	private bool isPlaySE;

	[Token(Token = "0x400B67F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18E")]
	private bool ForceTweenFinished;

	[Token(Token = "0x400B680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18F")]
	private bool isPlayTween;

	[Token(Token = "0x400B681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int bDP;

	[Token(Token = "0x400B682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private int aDP;

	[Token(Token = "0x400B683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Util.GameMode gameMode;

	[Token(Token = "0x400B684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private string gameModePath;

	[Token(Token = "0x400B685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private int m_EventId;

	[Token(Token = "0x1700113E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006CD4")]
		[Address(RVA = "0xB4B760", Offset = "0xB4A960", VA = "0x180B4B760", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006CD5")]
	[Address(RVA = "0xB4B2E0", Offset = "0xB4A4E0", VA = "0x180B4B2E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006CD6")]
	[Address(RVA = "0xB4B1A0", Offset = "0xB4A3A0", VA = "0x180B4B1A0")]
	private void clickButtonBackArea()
	{
	}

	[Token(Token = "0x6006CD7")]
	[Address(RVA = "0xB4ACD0", Offset = "0xB49ED0", VA = "0x180B4ACD0")]
	public static void Open(Util.GameMode gameMode, int eventId, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6006CD8")]
	[Address(RVA = "0xB4A810", Offset = "0xB49A10", VA = "0x180B4A810", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006CD9")]
	[Address(RVA = "0xB4AA60", Offset = "0xB49C60", VA = "0x180B4AA60", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006CDA")]
	[Address(RVA = "0xB4AFF0", Offset = "0xB4A1F0", VA = "0x180B4AFF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006CDB")]
	[Address(RVA = "0xB4AE50", Offset = "0xB4A050", VA = "0x180B4AE50")]
	private void Play()
	{
	}

	[Token(Token = "0x6006CDC")]
	[Address(RVA = "0xB4AC20", Offset = "0xB49E20", VA = "0x180B4AC20", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006CDD")]
	[Address(RVA = "0xB4AB90", Offset = "0xB49D90", VA = "0x180B4AB90", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006CDE")]
	[Address(RVA = "0xB49D10", Offset = "0xB48F10", VA = "0x180B49D10")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6006CDF")]
	[Address(RVA = "0xB4B740", Offset = "0xB4A940", VA = "0x180B4B740")]
	private bool checkDuelResultType()
	{
		return default(bool);
	}

	[Token(Token = "0x6006CE0")]
	[Address(RVA = "0x3EF010", Offset = "0x3EE210", VA = "0x1803EF010", Slot = "28")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x6006CE1")]
	[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "29")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x6006CE2")]
	[Address(RVA = "0xB4B470", Offset = "0xB4A670", VA = "0x180B4B470")]
	public DuelistCupResultViewController()
	{
	}
}
