using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EFD")]
public class DuelLiveBannerData
{
	[Token(Token = "0x400A5A1")]
	[FieldOffset(Offset = "0x10")]
	private List<DuelLiveBannerItem> items;

	[Token(Token = "0x6005ACA")]
	[Address(RVA = "0xA019D0", Offset = "0xA00BD0", VA = "0x180A019D0")]
	public DuelLiveBannerItem GetItemByMenuId(int index)
	{
		return null;
	}

	[Token(Token = "0x6005ACB")]
	[Address(RVA = "0xA01880", Offset = "0xA00A80", VA = "0x180A01880")]
	public void AddItem(int menuId, int sectionId, string title, string url, string path, string btnText)
	{
	}

	[Token(Token = "0x6005ACC")]
	[Address(RVA = "0xA01B00", Offset = "0xA00D00", VA = "0x180A01B00")]
	public DuelLiveBannerData()
	{
	}
}
