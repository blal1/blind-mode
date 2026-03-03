using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x2001300")]
public class PreHomeViewController : ViewController
{
	[Token(Token = "0x2001301")]
	private enum Step
	{
		[Token(Token = "0x400BEAE")]
		WaitDownload,
		[Token(Token = "0x400BEAF")]
		Idle,
		[Token(Token = "0x400BEB0")]
		Wait1,
		[Token(Token = "0x400BEB1")]
		Wait2,
		[Token(Token = "0x400BEB2")]
		Wait3,
		[Token(Token = "0x400BEB3")]
		GoHome
	}

	[Token(Token = "0x400BEA9")]
	public const string PREFAB_PATH = "Home/PreHome";

	[Token(Token = "0x400BEAA")]
	[FieldOffset(Offset = "0x48")]
	private Step step;

	[Token(Token = "0x400BEAB")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_soundLoadFinish;

	[Token(Token = "0x400BEAC")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_shouldDownload;

	[Token(Token = "0x6007605")]
	[Address(RVA = "0xBC5620", Offset = "0xBC4820", VA = "0x180BC5620", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007606")]
	[Address(RVA = "0xBC5C80", Offset = "0xBC4E80", VA = "0x180BC5C80", Slot = "9")]
	public override float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x6007607")]
	[Address(RVA = "0xBC5820", Offset = "0xBC4A20", VA = "0x180BC5820", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007608")]
	[Address(RVA = "0xBC5540", Offset = "0xBC4740", VA = "0x180BC5540")]
	private bool IsWaitFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6007609")]
	[Address(RVA = "0xBC5730", Offset = "0xBC4930", VA = "0x180BC5730", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600760A")]
	[Address(RVA = "0xBC5CB0", Offset = "0xBC4EB0", VA = "0x180BC5CB0")]
	public PreHomeViewController()
	{
	}
}
