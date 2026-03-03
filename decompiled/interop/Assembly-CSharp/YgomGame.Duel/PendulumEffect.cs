using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A93")]
public class PendulumEffect : SummonEffectBase
{
	[Token(Token = "0x400F4C8")]
	[FieldOffset(Offset = "0xB8")]
	private Texture leftScaleSpriteOnes;

	[Token(Token = "0x400F4C9")]
	[FieldOffset(Offset = "0xC0")]
	private Texture leftScaleSpriteTens;

	[Token(Token = "0x400F4CA")]
	[FieldOffset(Offset = "0xC8")]
	private Texture rightScaleSpriteOnes;

	[Token(Token = "0x400F4CB")]
	[FieldOffset(Offset = "0xD0")]
	private Texture rightScaleSpriteTens;

	[Token(Token = "0x400F4CC")]
	[FieldOffset(Offset = "0xD8")]
	private Texture2D leftScaleTextureFront;

	[Token(Token = "0x400F4CD")]
	[FieldOffset(Offset = "0xE0")]
	private Material leftScaleTextureBack;

	[Token(Token = "0x400F4CE")]
	[FieldOffset(Offset = "0xE8")]
	private Texture2D rightScaleTextureFront;

	[Token(Token = "0x400F4CF")]
	[FieldOffset(Offset = "0xF0")]
	private Material rightScaleTextureBack;

	[Token(Token = "0x400F4D0")]
	[FieldOffset(Offset = "0xF8")]
	private int leftScale;

	[Token(Token = "0x400F4D1")]
	[FieldOffset(Offset = "0xFC")]
	private int rightScale;

	[Token(Token = "0x400F4D2")]
	private const int maxScale = 99;

	[Token(Token = "0x400F4D3")]
	private const string SUMMON_PENDULUM = "Duel/Timeline/Duel/Universal/Summon/SummonPendulum/SummonPendulum01";

	[Token(Token = "0x17001AC5")]
	public override Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600ACCF")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "4")]
		get
		{
			return default(Engine.SpSummonType);
		}
	}

	[Token(Token = "0x600ACD0")]
	[Address(RVA = "0x443240", Offset = "0x442440", VA = "0x180443240")]
	public static PendulumEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600ACD1")]
	[Address(RVA = "0x443290", Offset = "0x442490", VA = "0x180443290")]
	public void LoadScaleCard(int leftCardID, int leftUniqueID, int leftScale, int rightCardID, int rightUniqueID, int rightScale)
	{
	}

	[Token(Token = "0x600ACD2")]
	[Address(RVA = "0x4439B0", Offset = "0x442BB0", VA = "0x1804439B0", Slot = "6")]
	protected override bool PlayEffect(Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600ACD3")]
	[Address(RVA = "0x4439D0", Offset = "0x442BD0", VA = "0x1804439D0")]
	private void PlayPendulumEffect(int materialNum, Action onFinished)
	{
	}

	[Token(Token = "0x600ACD4")]
	[Address(RVA = "0x4446C0", Offset = "0x4438C0", VA = "0x1804446C0")]
	public PendulumEffect()
	{
	}
}
