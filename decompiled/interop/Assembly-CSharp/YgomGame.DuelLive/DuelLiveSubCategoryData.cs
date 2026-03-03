using System;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EEE")]
public class DuelLiveSubCategoryData : DuelLiveProductGroupData
{
	[Token(Token = "0x6005A9F")]
	[Address(RVA = "0xA0C4E0", Offset = "0xA0B6E0", VA = "0x180A0C4E0", Slot = "10")]
	public override bool IsMatchProduct(IProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AA0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveSubCategoryData()
	{
	}
}
