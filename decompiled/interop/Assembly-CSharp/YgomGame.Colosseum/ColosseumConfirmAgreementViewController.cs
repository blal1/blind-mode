using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BB9")]
public class ColosseumConfirmAgreementViewController : ColosseumConfirmViewControllerBase
{
	[Token(Token = "0x600B485")]
	[Address(RVA = "0x4B6CA0", Offset = "0x4B5EA0", VA = "0x1804B6CA0")]
	public static void PushView(ViewControllerManager vcm, int logoId, int identifier = 0, [Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x600B486")]
	[Address(RVA = "0x4B6FE0", Offset = "0x4B61E0", VA = "0x1804B6FE0", Slot = "29")]
	protected override void UpdateView()
	{
	}

	[Token(Token = "0x600B487")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public ColosseumConfirmAgreementViewController()
	{
	}
}
