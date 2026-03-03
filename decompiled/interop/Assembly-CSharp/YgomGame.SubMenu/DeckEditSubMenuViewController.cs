using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.SubMenu;

[Token(Token = "0x2001041")]
public class DeckEditSubMenuViewController : SubMenuViewController
{
	[Token(Token = "0x400AD9C")]
	private const string argKeyOnClickMassDismantle = "OnClickMassDismantle";

	[Token(Token = "0x400AD9D")]
	private const string argKeyOnClickMultiDismantle = "OnClickMultiDismantle";

	[Token(Token = "0x400AD9E")]
	private const string argKeyOnClickCardProtection = "OnClickCardProtection";

	[Token(Token = "0x400AD9F")]
	private const string argKeyOnClickTrialDraw = "OnClickTrialDraw";

	[Token(Token = "0x400ADA0")]
	private const string argKeyOnClickMultiCreate = "OnClickMultiCreate";

	[Token(Token = "0x17000F62")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006272")]
		[Address(RVA = "0xA90340", Offset = "0xA8F540", VA = "0x180A90340", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006273")]
	[Address(RVA = "0xA8FB50", Offset = "0xA8ED50", VA = "0x180A8FB50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006274")]
	[Address(RVA = "0xA8FB70", Offset = "0xA8ED70", VA = "0x180A8FB70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006275")]
	[Address(RVA = "0xA8FE10", Offset = "0xA8F010", VA = "0x180A8FE10")]
	public static void Open(Action onClickMassDiamangle, Action onClickMultiDismantle, Action onClickTrialDraw, Action onClickMultiCreate, Action onClickCardProtection)
	{
	}

	[Token(Token = "0x6006276")]
	[Address(RVA = "0xA8F9F0", Offset = "0xA8EBF0", VA = "0x180A8F9F0")]
	private static Dictionary<string, object> CreateArgs(Action onClickMassDiamangle, Action onClickMultiDismantle, Action onClickTrialDraw, Action onClickMultiCreate, Action onClickCardProtection)
	{
		return null;
	}

	[Token(Token = "0x6006277")]
	[Address(RVA = "0xA90330", Offset = "0xA8F530", VA = "0x180A90330")]
	public DeckEditSubMenuViewController()
	{
	}
}
