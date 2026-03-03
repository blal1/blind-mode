using System;
using Il2CppDummyDll;
using YgomSystem.Compliance;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Compliance;

[Token(Token = "0x200115B")]
public class GemShopApprovalView : ApprovalView
{
	[Token(Token = "0x6006CBE")]
	[Address(RVA = "0xB501C0", Offset = "0xB4F3C0", VA = "0x180B501C0", Slot = "6")]
	public override void InitializeView(ElementObjectManager rootEOM, Selector selector, Action<ApprovalStatus> resultCallback)
	{
	}

	[Token(Token = "0x6006CBF")]
	[Address(RVA = "0xB501B0", Offset = "0xB4F3B0", VA = "0x180B501B0", Slot = "4")]
	protected override Handle CallSendMailAPI(string mailAddress)
	{
		return null;
	}

	[Token(Token = "0x6006CC0")]
	[Address(RVA = "0xB50190", Offset = "0xB4F390", VA = "0x180B50190", Slot = "5")]
	protected override Handle CallGenerateOtp()
	{
		return null;
	}

	[Token(Token = "0x6006CC1")]
	[Address(RVA = "0xB501A0", Offset = "0xB4F3A0", VA = "0x180B501A0", Slot = "7")]
	protected override Handle CallGetStatusAPI()
	{
		return null;
	}

	[Token(Token = "0x6006CC2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GemShopApprovalView()
	{
	}
}
