using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Solo;

[Token(Token = "0x20008B9")]
public class SoloPortalViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x40087BC")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string TXT_CLEAR_LABEL;

	[Token(Token = "0x40087BD")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TXT_COMPLETE_LABEL;

	[Token(Token = "0x40087BE")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string IMG_BADGE_LABEL;

	[Token(Token = "0x40087BF")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x40087C0")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BTN_LASTPLAY_LABEL;

	[Token(Token = "0x40087C1")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string BTN_RECOMMEND1_LABEL;

	[Token(Token = "0x40087C2")]
	[FieldOffset(Offset = "0x100")]
	private readonly string BTN_RECOMMEND2_LABEL;

	[Token(Token = "0x40087C3")]
	[FieldOffset(Offset = "0x108")]
	private readonly string BTN_STORYLIST_LABEL;

	[Token(Token = "0x40087C4")]
	[FieldOffset(Offset = "0x110")]
	private readonly string BTN_TRAININGLIST_LABEL;

	[Token(Token = "0x40087C5")]
	public const string BGM_TUTORIAL = "BGM_TUTORIAL_01";

	[Token(Token = "0x40087C6")]
	public const string BGM_SOLO = "BGM_SOLO_GATE";

	[Token(Token = "0x40087C7")]
	[FieldOffset(Offset = "0x118")]
	private SoloGateUtil.GateManager m_GateManager;

	[Token(Token = "0x40087C8")]
	[FieldOffset(Offset = "0x120")]
	private string tmpPushLabel;

	[Token(Token = "0x40087C9")]
	[FieldOffset(Offset = "0x128")]
	private string tmpSwapInLabel;

	[Token(Token = "0x1700067D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003499")]
		[Address(RVA = "0x7AAE30", Offset = "0x7AA030", VA = "0x1807AAE30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600349A")]
	[Address(RVA = "0x7A9460", Offset = "0x7A8660", VA = "0x1807A9460", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600349B")]
	[Address(RVA = "0x7A9580", Offset = "0x7A8780", VA = "0x1807A9580", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600349C")]
	[Address(RVA = "0x7AAA10", Offset = "0x7A9C10", VA = "0x1807AAA10", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600349D")]
	[Address(RVA = "0x7AAB80", Offset = "0x7A9D80", VA = "0x1807AAB80", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600349E")]
	[Address(RVA = "0x7A9600", Offset = "0x7A8800", VA = "0x1807A9600", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600349F")]
	[Address(RVA = "0x7A96D0", Offset = "0x7A88D0", VA = "0x1807A96D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60034A0")]
	[Address(RVA = "0x7AA670", Offset = "0x7A9870", VA = "0x1807AA670")]
	private int SearchLastPlayGate()
	{
		return default(int);
	}

	[Token(Token = "0x60034A1")]
	[Address(RVA = "0x7AAC70", Offset = "0x7A9E70", VA = "0x1807AAC70")]
	public SoloPortalViewController()
	{
	}
}
