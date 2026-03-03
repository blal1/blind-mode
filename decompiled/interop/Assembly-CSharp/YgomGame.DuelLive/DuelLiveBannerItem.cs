using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EFC")]
public class DuelLiveBannerItem
{
	[Token(Token = "0x400A599")]
	[FieldOffset(Offset = "0x10")]
	public int menuID;

	[Token(Token = "0x400A59A")]
	[FieldOffset(Offset = "0x14")]
	public int sectionID;

	[Token(Token = "0x400A59B")]
	[FieldOffset(Offset = "0x18")]
	public string title;

	[Token(Token = "0x400A59C")]
	[FieldOffset(Offset = "0x20")]
	public string schemeUrl;

	[Token(Token = "0x400A59D")]
	[FieldOffset(Offset = "0x28")]
	public string imagePath;

	[Token(Token = "0x400A59E")]
	[FieldOffset(Offset = "0x30")]
	public string buttonText;

	[Token(Token = "0x400A59F")]
	[FieldOffset(Offset = "0x38")]
	public string startData;

	[Token(Token = "0x400A5A0")]
	[FieldOffset(Offset = "0x40")]
	public string endData;

	[Token(Token = "0x6005AC9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveBannerItem()
	{
	}
}
