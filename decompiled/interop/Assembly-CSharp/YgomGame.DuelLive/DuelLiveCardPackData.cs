using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EF8")]
public class DuelLiveCardPackData
{
	[Token(Token = "0x400A58B")]
	[FieldOffset(Offset = "0x10")]
	public string packNameIDs;

	[Token(Token = "0x400A58C")]
	[FieldOffset(Offset = "0x18")]
	public string infoText;

	[Token(Token = "0x400A58D")]
	[FieldOffset(Offset = "0x20")]
	public string buttonLabelIDs;

	[Token(Token = "0x400A58E")]
	[FieldOffset(Offset = "0x28")]
	public string url;

	[Token(Token = "0x400A58F")]
	[FieldOffset(Offset = "0x30")]
	public int packId;

	[Token(Token = "0x400A590")]
	[FieldOffset(Offset = "0x38")]
	public List<int> highlightList;

	[Token(Token = "0x400A591")]
	[FieldOffset(Offset = "0x40")]
	public int packIconId;

	[Token(Token = "0x17000E0A")]
	public bool isUrlEnable
	{
		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x866DC0", Offset = "0x865FC0", VA = "0x180866DC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005AB9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveCardPackData()
	{
	}
}
