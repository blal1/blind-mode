using Il2CppDummyDll;
using YgomSystem.UI;

[Token(Token = "0x2000094")]
public class DuelStartViewController_Team : DuelStartViewController
{
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x220")]
	private bool isFinishedOverlay;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x221")]
	private bool isCalledDuelBegin;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x3F0CD0", Offset = "0x3EFED0", VA = "0x1803F0CD0", Slot = "29")]
	protected override void Init()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x3F0EE0", Offset = "0x3F00E0", VA = "0x1803F0EE0", Slot = "30")]
	protected override void WaitInit()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x3F0BA0", Offset = "0x3EFDA0", VA = "0x1803F0BA0", Slot = "31")]
	protected override void ControllVSImage()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x3F0CA0", Offset = "0x3EFEA0", VA = "0x1803F0CA0", Slot = "28")]
	protected override void InitTimeLine()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x3F0ED0", Offset = "0x3F00D0", VA = "0x1803F0ED0", Slot = "35")]
	protected override void StartDuel()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x3F0970", Offset = "0x3EFB70", VA = "0x1803F0970", Slot = "36")]
	protected override void CauseError()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x3F0D60", Offset = "0x3EFF60", VA = "0x1803F0D60", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x3F0F40", Offset = "0x3F0140", VA = "0x1803F0F40")]
	public DuelStartViewController_Team()
	{
	}
}
