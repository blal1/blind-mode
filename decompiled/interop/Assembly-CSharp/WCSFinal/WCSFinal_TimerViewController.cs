using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace WCSFinal;

[Token(Token = "0x2000107")]
public class WCSFinal_TimerViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0xD0")]
	private bool istimerstart;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0xD1")]
	private bool isfinish;

	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0xD2")]
	private bool isdisplaymenu;

	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x0")]
	private static int lastsethour;

	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x4")]
	private static int lastsetminute;

	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x8")]
	private static int lastsetsecond;

	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0xD4")]
	private float currenttime;

	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0xD8")]
	private int oldtime;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI TextTimer;

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0xE8")]
	private SelectionButton buttonstart;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0xF0")]
	private SelectionButton buttonreset;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0xF8")]
	private SelectionButton buttonsetting;

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x9E89C0", Offset = "0x9E7BC0", VA = "0x1809E89C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x9E8E70", Offset = "0x9E8070", VA = "0x1809E8E70", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x9E9280", Offset = "0x9E8480", VA = "0x1809E9280")]
	private void Update()
	{
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x9E9220", Offset = "0x9E8420", VA = "0x1809E9220")]
	private void SetTime()
	{
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x9E9160", Offset = "0x9E8360", VA = "0x1809E9160")]
	private void SetTimeText()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x9E9500", Offset = "0x9E8700", VA = "0x1809E9500")]
	public WCSFinal_TimerViewController()
	{
	}
}
