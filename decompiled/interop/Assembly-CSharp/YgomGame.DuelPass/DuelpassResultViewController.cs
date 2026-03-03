using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ECE")]
public class DuelpassResultViewController : BaseMenuViewController
{
	[Token(Token = "0x400A4D2")]
	[FieldOffset(Offset = "0xD0")]
	private DuelpassResultProgressBarWidget resultProgressBar;

	[Token(Token = "0x400A4D3")]
	[FieldOffset(Offset = "0xD8")]
	private DuelpassRewardPanelWidget rewardPanel;

	[Token(Token = "0x400A4D4")]
	[FieldOffset(Offset = "0xE0")]
	private SelectionButton toDuelResultButton;

	[Token(Token = "0x17000DE0")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x9F2BA0", Offset = "0x9F1DA0", VA = "0x1809F2BA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE1")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x9F2B00", Offset = "0x9F1D00", VA = "0x1809F2B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60059C7")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60059C8")]
	[Address(RVA = "0x9F23A0", Offset = "0x9F15A0", VA = "0x1809F23A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60059C9")]
	[Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
	private void ResultView()
	{
	}

	[Token(Token = "0x60059CA")]
	[Address(RVA = "0x9F2990", Offset = "0x9F1B90", VA = "0x1809F2990")]
	private void Start()
	{
	}

	[Token(Token = "0x60059CB")]
	[Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
	private void OnStartProgressBarAnimation()
	{
	}

	[Token(Token = "0x60059CC")]
	[Address(RVA = "0x9F23B0", Offset = "0x9F15B0", VA = "0x1809F23B0")]
	private void OnEndProgressBarAnimation()
	{
	}

	[Token(Token = "0x60059CD")]
	[Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
	private void OnGradeUp(int grade)
	{
	}

	[Token(Token = "0x60059CE")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public DuelpassResultViewController()
	{
	}
}
