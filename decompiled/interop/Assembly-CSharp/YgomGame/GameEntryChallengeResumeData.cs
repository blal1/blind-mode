using System;
using Il2CppDummyDll;

namespace YgomGame;

[Serializable]
[Token(Token = "0x200070E")]
public class GameEntryChallengeResumeData
{
	[Token(Token = "0x4002337")]
	public const int CurrentVersion = 0;

	[Token(Token = "0x4002338")]
	[FieldOffset(Offset = "0x10")]
	public int ver;

	[Token(Token = "0x4002339")]
	[FieldOffset(Offset = "0x14")]
	public int country;

	[Token(Token = "0x400233A")]
	[FieldOffset(Offset = "0x18")]
	public int state;

	[Token(Token = "0x400233B")]
	[FieldOffset(Offset = "0x20")]
	public int[] birth;

	[Token(Token = "0x400233C")]
	[FieldOffset(Offset = "0x28")]
	public int age;

	[Token(Token = "0x400233D")]
	[FieldOffset(Offset = "0x30")]
	public string gc_token;

	[Token(Token = "0x170005C5")]
	public int birthYear
	{
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x71CCB0", Offset = "0x71BEB0", VA = "0x18071CCB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005C6")]
	public int birthMonth
	{
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x71CC80", Offset = "0x71BE80", VA = "0x18071CC80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005C7")]
	public int birthDay
	{
		[Token(Token = "0x6002EA4")]
		[Address(RVA = "0x71CC50", Offset = "0x71BE50", VA = "0x18071CC50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x71CBA0", Offset = "0x71BDA0", VA = "0x18071CBA0")]
	public void SetBirth(int year, int month, int day)
	{
	}

	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0x71CBF0", Offset = "0x71BDF0", VA = "0x18071CBF0")]
	public GameEntryChallengeResumeData()
	{
	}
}
