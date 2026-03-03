using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001852")]
public struct CardInfoData
{
	[Token(Token = "0x400E3D9")]
	[FieldOffset(Offset = "0x0")]
	public bool hasinstance;

	[Token(Token = "0x400E3DA")]
	[FieldOffset(Offset = "0x4")]
	public int cardid;

	[Token(Token = "0x400E3DB")]
	[FieldOffset(Offset = "0x8")]
	public int uniqueid;

	[Token(Token = "0x400E3DC")]
	[FieldOffset(Offset = "0xC")]
	public int player;

	[Token(Token = "0x400E3DD")]
	[FieldOffset(Offset = "0x10")]
	public int owner;

	[Token(Token = "0x400E3DE")]
	[FieldOffset(Offset = "0x14")]
	public int position;

	[Token(Token = "0x400E3DF")]
	[FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x400E3E0")]
	[FieldOffset(Offset = "0x1C")]
	public int cardattribute;

	[Token(Token = "0x400E3E1")]
	[FieldOffset(Offset = "0x20")]
	public int styleid;

	[Token(Token = "0x400E3E2")]
	[FieldOffset(Offset = "0x24")]
	public int orglevel;

	[Token(Token = "0x400E3E3")]
	[FieldOffset(Offset = "0x28")]
	public int orgrank;

	[Token(Token = "0x400E3E4")]
	[FieldOffset(Offset = "0x2C")]
	public int orgtype;

	[Token(Token = "0x400E3E5")]
	[FieldOffset(Offset = "0x30")]
	public int effectflag;

	[Token(Token = "0x400E3E6")]
	[FieldOffset(Offset = "0x34")]
	public int overlaynum;

	[Token(Token = "0x400E3E7")]
	[FieldOffset(Offset = "0x38")]
	public int orgscale;

	[Token(Token = "0x400E3E8")]
	[FieldOffset(Offset = "0x3C")]
	public int scale;

	[Token(Token = "0x400E3E9")]
	[FieldOffset(Offset = "0x40")]
	public int turncounter;

	[Token(Token = "0x400E3EA")]
	[FieldOffset(Offset = "0x44")]
	public bool isfightableoneffect;

	[Token(Token = "0x400E3EB")]
	[FieldOffset(Offset = "0x45")]
	public bool istuner;

	[Token(Token = "0x400E3EC")]
	[FieldOffset(Offset = "0x46")]
	public bool isMagic;

	[Token(Token = "0x400E3ED")]
	[FieldOffset(Offset = "0x47")]
	public bool isTrap;

	[Token(Token = "0x400E3EE")]
	[FieldOffset(Offset = "0x48")]
	public bool isTrapMonster;

	[Token(Token = "0x400E3EF")]
	[FieldOffset(Offset = "0x49")]
	public bool isNormalMonster;

	[Token(Token = "0x400E3F0")]
	[FieldOffset(Offset = "0x4A")]
	public bool isContinuous;

	[Token(Token = "0x400E3F1")]
	[FieldOffset(Offset = "0x4B")]
	public bool isEquip;

	[Token(Token = "0x400E3F2")]
	[FieldOffset(Offset = "0x4C")]
	public Engine.BasicVal basicval;

	[Token(Token = "0x400E3F3")]
	[FieldOffset(Offset = "0x70")]
	public List<KeyValuePair<Engine.CounterType, int>> countertable;
}
