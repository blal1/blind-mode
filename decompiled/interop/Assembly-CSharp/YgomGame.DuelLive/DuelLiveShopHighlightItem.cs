using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EF9")]
public class DuelLiveShopHighlightItem
{
	[Token(Token = "0x400A592")]
	[FieldOffset(Offset = "0x10")]
	public int packId;

	[Token(Token = "0x400A593")]
	[FieldOffset(Offset = "0x18")]
	public List<int> highlightMrks;

	[Token(Token = "0x400A594")]
	[FieldOffset(Offset = "0x20")]
	public int selectedMrk;

	[Token(Token = "0x400A595")]
	[FieldOffset(Offset = "0x24")]
	public int selectedIndex;

	[Token(Token = "0x6005ABA")]
	[Address(RVA = "0x87A210", Offset = "0x879410", VA = "0x18087A210")]
	public DuelLiveShopHighlightItem(int packId, List<int> highlightMrks, int selectedMrk = -1, int selectedIndex = -1)
	{
	}

	[Token(Token = "0x6005ABB")]
	[Address(RVA = "0xA0C180", Offset = "0xA0B380", VA = "0x180A0C180")]
	public bool CheckProduct(DuelLiveProductContext ctx)
	{
		return default(bool);
	}
}
