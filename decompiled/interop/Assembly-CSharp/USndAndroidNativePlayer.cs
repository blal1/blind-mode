using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009B")]
public class USndAndroidNativePlayer
{
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x0")]
	private static USndAndroidNativePlayer player;

	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject plugin;

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x682BA0", Offset = "0x681DA0", VA = "0x180682BA0")]
	public static void Initialize(int maxNum)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x6832B0", Offset = "0x6824B0", VA = "0x1806832B0")]
	public static void Terminate()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x682DD0", Offset = "0x681FD0", VA = "0x180682DD0")]
	public static int LoadData(string saveName, string className, string funcName)
	{
		return default(int);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x682F90", Offset = "0x682190", VA = "0x180682F90")]
	public static int Play(int soundId, float volume, float rate)
	{
		return default(int);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x6831A0", Offset = "0x6823A0", VA = "0x1806831A0")]
	public static void Stop(int streamId)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x6833A0", Offset = "0x6825A0", VA = "0x1806833A0")]
	public static void Unload(int soundId)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public USndAndroidNativePlayer()
	{
	}
}
