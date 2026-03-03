using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x200167B")]
public class TeamResultEffectViewController : BaseMenuViewController
{
	[Token(Token = "0x400D6BA")]
	private const string k_ArgKeyCallback = "callback";

	[Token(Token = "0x400D6BB")]
	private const string k_ArgKeyResult = "result";

	[Token(Token = "0x400D6BC")]
	private const string k_ArgKeyCardMrk = "cardMrk";

	[Token(Token = "0x400D6BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelBackShortcutButton;

	[Token(Token = "0x400D6BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private TimelineObject teamResultEffectTimeLine;

	[Token(Token = "0x400D6BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private EventPlayableAsset eventPlayableAsset;

	[Token(Token = "0x400D6C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ElementObjectManager eom;

	[Token(Token = "0x400D6C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SelectionButton backButton;

	[Token(Token = "0x400D6C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool isFinishedSE;

	[Token(Token = "0x400D6C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
	private bool isFinishedResultEffect;

	[Token(Token = "0x400D6C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int resultStatus;

	[Token(Token = "0x400D6C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int cardMrk;

	[Token(Token = "0x6008BE2")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008BE3")]
	[Address(RVA = "0xD6D930", Offset = "0xD6CB30", VA = "0x180D6D930", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008BE4")]
	[Address(RVA = "0xD6DA60", Offset = "0xD6CC60", VA = "0x180D6DA60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008BE5")]
	[Address(RVA = "0x578EC0", Offset = "0x5780C0", VA = "0x180578EC0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6008BE6")]
	[Address(RVA = "0xD6D7F0", Offset = "0xD6C9F0", VA = "0x180D6D7F0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6008BE7")]
	[Address(RVA = "0xD6DD90", Offset = "0xD6CF90", VA = "0x180D6DD90")]
	private void Start()
	{
	}

	[Token(Token = "0x6008BE8")]
	[Address(RVA = "0xD6E340", Offset = "0xD6D540", VA = "0x180D6E340")]
	private void Update()
	{
	}

	[Token(Token = "0x6008BE9")]
	[Address(RVA = "0xD6DC30", Offset = "0xD6CE30", VA = "0x180D6DC30")]
	public static void Open(ViewControllerManager manager, int result, int cardMrk, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6008BEA")]
	[Address(RVA = "0xD6DD90", Offset = "0xD6CF90", VA = "0x180D6DD90")]
	private void Play()
	{
	}

	[Token(Token = "0x6008BEB")]
	[Address(RVA = "0xD6DDA0", Offset = "0xD6CFA0", VA = "0x180D6DDA0")]
	private void StartTimeLine()
	{
	}

	[Token(Token = "0x6008BEC")]
	[Address(RVA = "0xD6D480", Offset = "0xD6C680", VA = "0x180D6D480")]
	private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
	{
		return null;
	}

	[Token(Token = "0x6008BED")]
	[Address(RVA = "0xD6E650", Offset = "0xD6D850", VA = "0x180D6E650")]
	public TeamResultEffectViewController()
	{
	}
}
