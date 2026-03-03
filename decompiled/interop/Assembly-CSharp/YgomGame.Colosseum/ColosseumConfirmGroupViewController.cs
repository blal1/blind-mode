using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BBB")]
public class ColosseumConfirmGroupViewController : ColosseumConfirmViewControllerBase
{
	[Token(Token = "0x400FB0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int currentIndex;

	[Token(Token = "0x400FB0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<(int id, string text)> regionList;

	[Token(Token = "0x600B48D")]
	[Address(RVA = "0x4B77D0", Offset = "0x4B69D0", VA = "0x1804B77D0")]
	public static void PushView(ViewControllerManager vcm, int logoId, int identifier = 0, [Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x600B48E")]
	[Address(RVA = "0x4B7D80", Offset = "0x4B6F80", VA = "0x1804B7D80", Slot = "29")]
	protected override void UpdateView()
	{
	}

	[Token(Token = "0x600B48F")]
	[Address(RVA = "0x4B7730", Offset = "0x4B6930", VA = "0x1804B7730")]
	private void CallAPIWcsSetRegion(int regionId)
	{
	}

	[Token(Token = "0x600B490")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public ColosseumConfirmGroupViewController()
	{
	}
}
