using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AAB")]
public class XyzEffect : SummonEffectBase
{
	[Token(Token = "0x17001AE2")]
	public override Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600AD75")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "4")]
		get
		{
			return default(Engine.SpSummonType);
		}
	}

	[Token(Token = "0x600AD76")]
	[Address(RVA = "0x451FF0", Offset = "0x4511F0", VA = "0x180451FF0")]
	public static XyzEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600AD77")]
	[Address(RVA = "0x452040", Offset = "0x451240", VA = "0x180452040", Slot = "5")]
	public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
	{
	}

	[Token(Token = "0x600AD78")]
	[Address(RVA = "0x452140", Offset = "0x451340", VA = "0x180452140", Slot = "6")]
	protected override bool PlayEffect(Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600AD79")]
	[Address(RVA = "0x452340", Offset = "0x451540", VA = "0x180452340")]
	private void PlayXyzEffect(int materialNum, Action onFinished)
	{
	}

	[Token(Token = "0x600AD7A")]
	[Address(RVA = "0x4446C0", Offset = "0x4438C0", VA = "0x1804446C0")]
	public XyzEffect()
	{
	}
}
