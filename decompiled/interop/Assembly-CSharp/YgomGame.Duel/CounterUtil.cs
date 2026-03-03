using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.TextIDs;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x200187A")]
public class CounterUtil
{
	[Token(Token = "0x200187B")]
	private class CounterInfo
	{
		[Token(Token = "0x400E5EA")]
		[FieldOffset(Offset = "0x10")]
		public IDS_COUNTER nameTextID;

		[Token(Token = "0x400E5EB")]
		[FieldOffset(Offset = "0x18")]
		public string iconLabel;

		[Token(Token = "0x6009CBF")]
		[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
		public CounterInfo(IDS_COUNTER nameTextID, string iconLabel)
		{
		}
	}

	[Token(Token = "0x400E5E8")]
	[FieldOffset(Offset = "0x0")]
	private static SpriteContainer counterIconContainer;

	[Token(Token = "0x400E5E9")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<Engine.CounterType, CounterInfo> counterInfoList;

	[Token(Token = "0x6009CB9")]
	[Address(RVA = "0xE9EB00", Offset = "0xE9DD00", VA = "0x180E9EB00")]
	public static void Initialize(SpriteContainer counterIconContainer)
	{
	}

	[Token(Token = "0x6009CBA")]
	[Address(RVA = "0xE9E9A0", Offset = "0xE9DBA0", VA = "0x180E9E9A0")]
	public static string GetCounterName(Engine.CounterType type)
	{
		return null;
	}

	[Token(Token = "0x6009CBB")]
	[Address(RVA = "0xE9E810", Offset = "0xE9DA10", VA = "0x180E9E810")]
	public static Sprite GetCounterIcon(Engine.CounterType type)
	{
		return null;
	}

	[Token(Token = "0x6009CBC")]
	[Address(RVA = "0xE9EB70", Offset = "0xE9DD70", VA = "0x180E9EB70")]
	public static void Terminate()
	{
	}

	[Token(Token = "0x6009CBD")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CounterUtil()
	{
	}
}
