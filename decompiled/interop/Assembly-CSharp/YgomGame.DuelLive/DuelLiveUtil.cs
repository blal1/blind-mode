using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F20")]
public static class DuelLiveUtil
{
	[Token(Token = "0x400A636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int menuId;

	[Token(Token = "0x400A637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int replayIndex;

	[Token(Token = "0x400A638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int mrk;

	[Token(Token = "0x400A639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int optId;

	[Token(Token = "0x17000E56")]
	public static int playCount
	{
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0xA0CAB0", Offset = "0xA0BCB0", VA = "0x180A0CAB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005B97")]
		[Address(RVA = "0xA0CAF0", Offset = "0xA0BCF0", VA = "0x180A0CAF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6005B98")]
	[Address(RVA = "0xA0C920", Offset = "0xA0BB20", VA = "0x180A0C920")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6005B99")]
	[Address(RVA = "0xA0C960", Offset = "0xA0BB60", VA = "0x180A0C960")]
	public static int SetupContinuousPlay(int menuId, int replayIndex, int optId, int mrk)
	{
		return default(int);
	}

	[Token(Token = "0x6005B9A")]
	[Address(RVA = "0xA0C650", Offset = "0xA0B850", VA = "0x180A0C650")]
	public static int GetContinuousPlayNum()
	{
		return default(int);
	}

	[Token(Token = "0x6005B9B")]
	[Address(RVA = "0x83BCE0", Offset = "0x83AEE0", VA = "0x18083BCE0")]
	public static void CheckFocusBGM()
	{
	}

	[Token(Token = "0x6005B9C")]
	[Address(RVA = "0xA0C6B0", Offset = "0xA0B8B0", VA = "0x180A0C6B0")]
	public static (int, int, int, int) GetContinuousPlayParams()
	{
		return default((int, int, int, int));
	}

	[Token(Token = "0x6005B9D")]
	[Address(RVA = "0xA0C730", Offset = "0xA0B930", VA = "0x180A0C730")]
	public static void HandleResultCode(Handle handle, [Optional] Action onSuccess, [Optional] Action<DuelLiveCode> onFailed)
	{
	}

	[Token(Token = "0x6005B9E")]
	[Address(RVA = "0xA0C540", Offset = "0xA0B740", VA = "0x180A0C540")]
	public static void CheckLaunch(int menu_id, int section_id, int opt_id, Action onSuccess, [Optional] Action onFailed)
	{
	}
}
