using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x200195E")]
public class CameraShakerSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200195F")]
	public class Info
	{
		[Token(Token = "0x400EC12")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400EC13")]
		[FieldOffset(Offset = "0x18")]
		public float duration;

		[Token(Token = "0x400EC14")]
		[FieldOffset(Offset = "0x1C")]
		public float delay;

		[Token(Token = "0x400EC15")]
		[FieldOffset(Offset = "0x20")]
		public bool usePerlinShake;

		[Token(Token = "0x400EC16")]
		[FieldOffset(Offset = "0x24")]
		public float perlinCycle;

		[Token(Token = "0x400EC17")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 perlinPower;

		[Token(Token = "0x400EC18")]
		[FieldOffset(Offset = "0x34")]
		public bool useCosShake;

		[Token(Token = "0x400EC19")]
		[FieldOffset(Offset = "0x38")]
		public float cosCycle;

		[Token(Token = "0x400EC1A")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 cosPower;

		[Token(Token = "0x400EC1B")]
		[FieldOffset(Offset = "0x48")]
		public bool useSinShake;

		[Token(Token = "0x400EC1C")]
		[FieldOffset(Offset = "0x4C")]
		public float sinCycle;

		[Token(Token = "0x400EC1D")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 sinPower;

		[Token(Token = "0x400EC1E")]
		[FieldOffset(Offset = "0x5C")]
		public bool useSinShakeSub;

		[Token(Token = "0x400EC1F")]
		[FieldOffset(Offset = "0x60")]
		public float sinCycleSub;

		[Token(Token = "0x400EC20")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 sinPowerSub;

		[Token(Token = "0x400EC21")]
		[FieldOffset(Offset = "0x70")]
		public bool useRandomShake;

		[Token(Token = "0x400EC22")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 randomMin;

		[Token(Token = "0x400EC23")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 randomMax;

		[Token(Token = "0x400EC24")]
		[FieldOffset(Offset = "0x8C")]
		public int randomDelayFrame;

		[Token(Token = "0x400EC25")]
		[FieldOffset(Offset = "0x90")]
		public float randomDelayGain;

		[Token(Token = "0x600A308")]
		[Address(RVA = "0xF142C0", Offset = "0xF134C0", VA = "0x180F142C0")]
		public Info Copy()
		{
			return null;
		}

		[Token(Token = "0x600A309")]
		[Address(RVA = "0xF14340", Offset = "0xF13540", VA = "0x180F14340")]
		public (Vector3, bool) GetShake(float time, Vector3 pre_shake, int frame_count, Vector3 big, Vector3 lit)
		{
			return default((Vector3, bool));
		}

		[Token(Token = "0x600A30A")]
		[Address(RVA = "0xF14810", Offset = "0xF13A10", VA = "0x180F14810")]
		public Info()
		{
		}
	}

	[Token(Token = "0x400EC11")]
	[FieldOffset(Offset = "0x18")]
	public List<Info> infoList;

	[Token(Token = "0x600A306")]
	[Address(RVA = "0xF00A70", Offset = "0xEFFC70", VA = "0x180F00A70")]
	public Info Get(string label)
	{
		return null;
	}

	[Token(Token = "0x600A307")]
	[Address(RVA = "0xF00B40", Offset = "0xEFFD40", VA = "0x180F00B40")]
	public CameraShakerSetting()
	{
	}
}
