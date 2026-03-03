using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A54")]
public class LethalEffect : MonoBehaviour
{
	[Token(Token = "0x2001A55")]
	public enum EffectType
	{
		[Token(Token = "0x400F29E")]
		Normal,
		[Token(Token = "0x400F29F")]
		DarkMagician,
		[Token(Token = "0x400F2A0")]
		BlueEyes,
		[Token(Token = "0x400F2A1")]
		RedEyes,
		[Token(Token = "0x400F2A2")]
		Ra,
		[Token(Token = "0x400F2A3")]
		Obelisk,
		[Token(Token = "0x400F2A4")]
		Slifer
	}

	[Token(Token = "0x400F297")]
	[FieldOffset(Offset = "0x20")]
	private AllCardBreaker allCardBreaker;

	[Token(Token = "0x400F298")]
	[FieldOffset(Offset = "0x28")]
	private AllCardBreaker allCardBreakerOtherSide;

	[Token(Token = "0x400F299")]
	[FieldOffset(Offset = "0x30")]
	private bool playedSlow;

	[Token(Token = "0x400F29A")]
	[FieldOffset(Offset = "0x38")]
	private DuelGameObjectManager goManager;

	[Token(Token = "0x400F29C")]
	[FieldOffset(Offset = "0x48")]
	private Action onFinished;

	[Token(Token = "0x17001A68")]
	public bool playing
	{
		[Token(Token = "0x600AAF0")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AAF1")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600AAF2")]
	[Address(RVA = "0xF6F990", Offset = "0xF6EB90", VA = "0x180F6F990")]
	public static LethalEffect Create(DuelGameObjectManager goManager)
	{
		return null;
	}

	[Token(Token = "0x600AAF3")]
	[Address(RVA = "0xF6FA70", Offset = "0xF6EC70", VA = "0x180F6FA70")]
	public void Play(int loser, Action onFinished, bool useEffect, Vector3 effectPosition, bool draw, bool isDeckOut, EffectType effectType, Vector3 attackDirection)
	{
	}

	[Token(Token = "0x600AAF4")]
	[Address(RVA = "0xF70660", Offset = "0xF6F860", VA = "0x180F70660")]
	private void Update()
	{
	}

	[Token(Token = "0x600AAF5")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LethalEffect()
	{
	}
}
