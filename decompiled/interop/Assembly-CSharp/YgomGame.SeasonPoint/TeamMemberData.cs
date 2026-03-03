using Il2CppDummyDll;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A40")]
internal class TeamMemberData
{
	[Token(Token = "0x40090D4")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40090D5")]
	[FieldOffset(Offset = "0x18")]
	public string onlineId;

	[Token(Token = "0x40090D6")]
	[FieldOffset(Offset = "0x20")]
	public long pcode;

	[Token(Token = "0x40090D7")]
	[FieldOffset(Offset = "0x28")]
	public bool isSameOs;

	[Token(Token = "0x40090D8")]
	[FieldOffset(Offset = "0x2C")]
	public int icon;

	[Token(Token = "0x40090D9")]
	[FieldOffset(Offset = "0x30")]
	public int iconFrame;

	[Token(Token = "0x40090DA")]
	[FieldOffset(Offset = "0x34")]
	public SeasonPointUtil.MemberStatus status;

	[Token(Token = "0x40090DB")]
	[FieldOffset(Offset = "0x38")]
	public bool isMyData;

	[Token(Token = "0x6003ECA")]
	[Address(RVA = "0x87A2E0", Offset = "0x8794E0", VA = "0x18087A2E0")]
	public TeamMemberData()
	{
	}

	[Token(Token = "0x6003ECB")]
	[Address(RVA = "0x87A350", Offset = "0x879550", VA = "0x18087A350")]
	public TeamMemberData(string name, string onlineId, long pcode, bool isSameOs, int icon, int iconFrame, bool isMyData = false)
	{
	}

	[Token(Token = "0x6003ECC")]
	[Address(RVA = "0x87A430", Offset = "0x879630", VA = "0x18087A430")]
	public void resetDatas()
	{
	}
}
