using System;
using Il2CppDummyDll;
using YgomSystem.Compliance;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Compliance;

[Token(Token = "0x200115A")]
public class GameEntryApprovalView : ApprovalView
{
	[Token(Token = "0x6006CB9")]
	[Address(RVA = "0xB50120", Offset = "0xB4F320", VA = "0x180B50120", Slot = "6")]
	public override void InitializeView(ElementObjectManager rootEOM, Selector selector, Action<ApprovalStatus> resultCallback)
	{
	}

	[Token(Token = "0x6006CBA")]
	[Address(RVA = "0xB50110", Offset = "0xB4F310", VA = "0x180B50110", Slot = "4")]
	protected override Handle CallSendMailAPI(string mailAddress)
	{
		return null;
	}

	[Token(Token = "0x6006CBB")]
	[Address(RVA = "0xB500F0", Offset = "0xB4F2F0", VA = "0x180B500F0", Slot = "5")]
	protected override Handle CallGenerateOtp()
	{
		return null;
	}

	[Token(Token = "0x6006CBC")]
	[Address(RVA = "0xB50100", Offset = "0xB4F300", VA = "0x180B50100", Slot = "7")]
	protected override Handle CallGetStatusAPI()
	{
		return null;
	}

	[Token(Token = "0x6006CBD")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GameEntryApprovalView()
	{
	}
}
