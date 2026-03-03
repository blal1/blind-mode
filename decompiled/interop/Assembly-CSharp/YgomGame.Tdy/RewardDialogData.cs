using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;

namespace YgomGame.Tdy;

[Token(Token = "0x2000854")]
public class RewardDialogData
{
	[Token(Token = "0x40085EC")]
	[FieldOffset(Offset = "0x10")]
	public EntryItemListData.Context itemContext;

	[Token(Token = "0x40085ED")]
	[FieldOffset(Offset = "0x18")]
	public bool isSendPresent;

	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RewardDialogData()
	{
	}
}
