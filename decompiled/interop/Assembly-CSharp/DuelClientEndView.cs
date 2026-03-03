using System;
using Il2CppDummyDll;
using YgomSystem.Timeline;
using YgomSystem.UI;

[Token(Token = "0x2000044")]
public class DuelClientEndView : ViewController
{
	[Token(Token = "0x400012F")]
	public const string PREFAB_PATH = "Duel/DuelClientEndView";

	[Token(Token = "0x4000130")]
	public const string k_ArgsKeyLPController = "LPController";

	[Token(Token = "0x4000131")]
	public const string k_ArgsKeyPushAction = "PushAction";

	[Token(Token = "0x4000132")]
	public const string k_ArgsKeyPopAction = "PopAction";

	[Token(Token = "0x4000133")]
	public const string k_ArgsKeyLoopEndAtStackRemove = "LoopEndAtStackRemove";

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x48")]
	private Action<ViewControllerManager, ViewController> m_PushAction;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x50")]
	private Action<ViewControllerManager, ViewController> m_PopAction;

	[Token(Token = "0x4000136")]
	public const string TIMELINE_PATH = "Duel/Timeline/Duel/Universal/DuelEndTransition/DuelEndTransition";

	[Token(Token = "0x4000137")]
	public const string TIMELINELABEL_TRANSIN = "TransIn";

	[Token(Token = "0x4000138")]
	public const string TIMELINELABEL_TRANSOUT = "TransOut";

	[Token(Token = "0x4000139")]
	public const string TIMELINELABEL_WAIT = "Wait";

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x58")]
	private TimelineObject m_TimelineObject;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x60")]
	private bool m_LabelClipEndFlag_TransOut;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x61")]
	private bool m_LoopEndAtStackRemove;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x3DBA90", Offset = "0x3DAC90", VA = "0x1803DBA90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x3DBE60", Offset = "0x3DB060", VA = "0x1803DBE60", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x3DBF10", Offset = "0x3DB110", VA = "0x1803DBF10", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x3DBFA0", Offset = "0x3DB1A0", VA = "0x1803DBFA0", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x3DC020", Offset = "0x3DB220", VA = "0x1803DC020")]
	public DuelClientEndView()
	{
	}
}
