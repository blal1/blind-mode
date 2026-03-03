using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Lottery;

[Token(Token = "0x2001714")]
public class LotteryHistoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, ILotteryChildViewControllerGroup
{
	[Token(Token = "0x400DA5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ResultArea;

	[Token(Token = "0x400DA5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_TabGroup;

	[Token(Token = "0x400DA60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_TabTemplate;

	[Token(Token = "0x400DA61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_TabOnLabel;

	[Token(Token = "0x400DA62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_TabOffLabel;

	[Token(Token = "0x400DA63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_SelectedCardsWidget;

	[Token(Token = "0x400DA64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_Button;

	[Token(Token = "0x400DA65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_HelpButton;

	[Token(Token = "0x400DA66")]
	private const string k_PrefPath = "Lottery/LotteryHistory";

	[Token(Token = "0x400DA67")]
	private const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DA68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private DirectionalTabGroup m_TabGroup;

	[Token(Token = "0x400DA69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private SelectedCardsWidget m_CardsWidget;

	[Token(Token = "0x400DA6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ResultCardsWidget m_ResultWidget;

	[Token(Token = "0x400DA6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int m_Id;

	[Token(Token = "0x17001645")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60090DD")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001646")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60090DE")]
		[Address(RVA = "0xDAB510", Offset = "0xDAA710", VA = "0x180DAB510", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60090DF")]
	[Address(RVA = "0xDAA430", Offset = "0xDA9630", VA = "0x180DAA430")]
	public static void Open(int id, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60090E0")]
	[Address(RVA = "0xDAA3C0", Offset = "0xDA95C0", VA = "0x180DAA3C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60090E1")]
	[Address(RVA = "0xDAA530", Offset = "0xDA9730", VA = "0x180DAA530")]
	private void Start()
	{
	}

	[Token(Token = "0x60090E2")]
	[Address(RVA = "0xDAB380", Offset = "0xDAA580", VA = "0x180DAB380")]
	public LotteryHistoryViewController()
	{
	}
}
