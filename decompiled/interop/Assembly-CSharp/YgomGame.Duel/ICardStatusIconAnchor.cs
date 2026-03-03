using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A49")]
public interface ICardStatusIconAnchor
{
	[Token(Token = "0x17001A58")]
	GameObject effectAnchor
	{
		[Token(Token = "0x600AAAF")]
		get;
	}

	[Token(Token = "0x17001A59")]
	Quaternion localRot
	{
		[Token(Token = "0x600AAB0")]
		get;
	}

	[Token(Token = "0x17001A5A")]
	Vector3 centerOfs
	{
		[Token(Token = "0x600AAB1")]
		get;
	}

	[Token(Token = "0x17001A5B")]
	Vector3 atkDefOfs
	{
		[Token(Token = "0x600AAB2")]
		get;
	}

	[Token(Token = "0x17001A5C")]
	Vector3 levelOfs
	{
		[Token(Token = "0x600AAB3")]
		get;
	}

	[Token(Token = "0x17001A5D")]
	Vector3 attrOfs
	{
		[Token(Token = "0x600AAB4")]
		get;
	}

	[Token(Token = "0x17001A5E")]
	Vector3 typeOfs
	{
		[Token(Token = "0x600AAB5")]
		get;
	}

	[Token(Token = "0x17001A5F")]
	Vector3 counterOfs
	{
		[Token(Token = "0x600AAB6")]
		get;
	}

	[Token(Token = "0x17001A60")]
	Vector3 turnsOfs
	{
		[Token(Token = "0x600AAB7")]
		get;
	}
}
