using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200115C")]
public class ColosseumDuelResultViewController_Rate : BaseMenuViewController, IFadeSupported
{
	[Token(Token = "0x400B64B")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400B64C")]
	private const string k_ArgkeyGameMode = "gameMode";

	[Token(Token = "0x400B64D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelBackShortcutButton;

	[Token(Token = "0x400B64E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string RATE_INFO_LABEL;

	[Token(Token = "0x400B64F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string RATE_INFOROOT_LABEL;

	[Token(Token = "0x400B650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string TEXT_TOTAL_RATE_LABEL;

	[Token(Token = "0x400B651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TEXT_ADD_RATE_LABEL;

	[Token(Token = "0x400B652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TEXT_BEFORE_RATE_LABEL;

	[Token(Token = "0x400B653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject m_View3D;

	[Token(Token = "0x400B654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool is_initialised;

	[Token(Token = "0x400B655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ElementObjectManager eom;

	[Token(Token = "0x400B656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ElementObject rateInfoRoot;

	[Token(Token = "0x400B657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ElementObject bg;

	[Token(Token = "0x400B658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Tween beforeRateTextTween;

	[Token(Token = "0x400B659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Tween diffRateTextTween;

	[Token(Token = "0x400B65A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Tween totalRateTextTween;

	[Token(Token = "0x400B65B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private SelectionButton buttonBackArea;

	[Token(Token = "0x400B65C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Engine.ResultType resultType;

	[Token(Token = "0x400B65D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private bool isStartTween;

	[Token(Token = "0x400B65E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
	private bool isPlaySE;

	[Token(Token = "0x400B65F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
	private bool ForceTweenFinished;

	[Token(Token = "0x400B660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
	private bool isPlayTween;

	[Token(Token = "0x400B661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private string gameModePath;

	[Token(Token = "0x1700113D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006CC3")]
		[Address(RVA = "0xB460C0", Offset = "0xB452C0", VA = "0x180B460C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006CC4")]
	[Address(RVA = "0xB45DB0", Offset = "0xB44FB0", VA = "0x180B45DB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006CC5")]
	[Address(RVA = "0xB45C70", Offset = "0xB44E70", VA = "0x180B45C70")]
	private void clickButtonBackArea()
	{
	}

	[Token(Token = "0x6006CC6")]
	[Address(RVA = "0xB459A0", Offset = "0xB44BA0", VA = "0x180B459A0")]
	public static void Open(Util.GameMode gameMode, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6006CC7")]
	[Address(RVA = "0xB45690", Offset = "0xB44890", VA = "0x180B45690", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006CC8")]
	[Address(RVA = "0xB45730", Offset = "0xB44930", VA = "0x180B45730", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006CC9")]
	[Address(RVA = "0xB45BA0", Offset = "0xB44DA0", VA = "0x180B45BA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006CCA")]
	[Address(RVA = "0xB45AE0", Offset = "0xB44CE0", VA = "0x180B45AE0")]
	private void Play()
	{
	}

	[Token(Token = "0x6006CCB")]
	[Address(RVA = "0xB458F0", Offset = "0xB44AF0", VA = "0x180B458F0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006CCC")]
	[Address(RVA = "0xB45860", Offset = "0xB44A60", VA = "0x180B45860", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006CCD")]
	[Address(RVA = "0xB44FB0", Offset = "0xB441B0", VA = "0x180B44FB0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6006CCE")]
	[Address(RVA = "0xB460A0", Offset = "0xB452A0", VA = "0x180B460A0")]
	private bool checkDuelResultType()
	{
		return default(bool);
	}

	[Token(Token = "0x6006CCF")]
	[Address(RVA = "0x3EF010", Offset = "0x3EE210", VA = "0x1803EF010", Slot = "28")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x6006CD0")]
	[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "29")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x6006CD1")]
	[Address(RVA = "0xB45F40", Offset = "0xB45140", VA = "0x180B45F40")]
	public ColosseumDuelResultViewController_Rate()
	{
	}
}
