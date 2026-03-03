using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001758")]
public class DuelAcslInfo
{
	[Token(Token = "0x2001759")]
	public class AcslInfo
	{
		[Token(Token = "0x400DC15")]
		[FieldOffset(Offset = "0x10")]
		public int pos;

		[Token(Token = "0x400DC16")]
		[FieldOffset(Offset = "0x14")]
		public int cid;

		[Token(Token = "0x400DC17")]
		[FieldOffset(Offset = "0x18")]
		public bool face;

		[Token(Token = "0x400DC18")]
		[FieldOffset(Offset = "0x19")]
		public bool turn;

		[Token(Token = "0x400DC19")]
		[FieldOffset(Offset = "0x1C")]
		public int r;

		[Token(Token = "0x400DC1A")]
		[FieldOffset(Offset = "0x20")]
		public int uid;

		[Token(Token = "0x400DC1B")]
		[FieldOffset(Offset = "0x24")]
		public bool used;

		[Token(Token = "0x6009298")]
		[Address(RVA = "0xDBFB90", Offset = "0xDBED90", VA = "0x180DBFB90")]
		public AcslInfo(Dictionary<string, object> dic)
		{
		}
	}

	[Token(Token = "0x400DC13")]
	[FieldOffset(Offset = "0x10")]
	public List<AcslInfo> myAcslInfos;

	[Token(Token = "0x400DC14")]
	[FieldOffset(Offset = "0x18")]
	public List<AcslInfo> rivalAcslInfos;

	[Token(Token = "0x6009294")]
	[Address(RVA = "0xDC6720", Offset = "0xDC5920", VA = "0x180DC6720")]
	public static DuelAcslInfo Create()
	{
		return null;
	}

	[Token(Token = "0x6009295")]
	[Address(RVA = "0xDC65D0", Offset = "0xDC57D0", VA = "0x180DC65D0")]
	public bool CheckInfo(int cid, int pos, bool myself)
	{
		return default(bool);
	}

	[Token(Token = "0x6009296")]
	[Address(RVA = "0xDC6C80", Offset = "0xDC5E80", VA = "0x180DC6C80")]
	public int GetStyleByUniqueID(int uid)
	{
		return default(int);
	}

	[Token(Token = "0x6009297")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelAcslInfo()
	{
	}
}
