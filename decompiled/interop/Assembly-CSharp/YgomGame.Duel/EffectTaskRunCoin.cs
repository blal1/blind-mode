using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Coin;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001B3D")]
public class EffectTaskRunCoin : EffectTask
{
	[Token(Token = "0x2001B3E")]
	private enum Step
	{
		[Token(Token = "0x400F81A")]
		WaitCardEffect,
		[Token(Token = "0x400F81B")]
		WaitLoadEffect,
		[Token(Token = "0x400F81C")]
		WaitCoin,
		[Token(Token = "0x400F81D")]
		Finish
	}

	[Token(Token = "0x400F806")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F807")]
	[FieldOffset(Offset = "0x20")]
	private ScreenSelector selector;

	[Token(Token = "0x400F808")]
	[FieldOffset(Offset = "0x28")]
	private int numThrows;

	[Token(Token = "0x400F809")]
	[FieldOffset(Offset = "0x2C")]
	private int faceBits;

	[Token(Token = "0x400F80A")]
	[FieldOffset(Offset = "0x30")]
	private int shineBits;

	[Token(Token = "0x400F80B")]
	[FieldOffset(Offset = "0x34")]
	private bool isTimelineLoaded;

	[Token(Token = "0x400F80C")]
	[FieldOffset(Offset = "0x35")]
	private bool isCoinLoaded;

	[Token(Token = "0x400F80D")]
	[FieldOffset(Offset = "0x36")]
	private bool isCoinEffectLoaded;

	[Token(Token = "0x400F80E")]
	[FieldOffset(Offset = "0x37")]
	private bool isCoinEffectLoaded2;

	[Token(Token = "0x400F80F")]
	[FieldOffset(Offset = "0x38")]
	private bool isCoinEffectLoaded3;

	[Token(Token = "0x400F810")]
	[FieldOffset(Offset = "0x39")]
	private bool isMyself;

	[Token(Token = "0x400F811")]
	[FieldOffset(Offset = "0x3C")]
	private int param1;

	[Token(Token = "0x400F812")]
	[FieldOffset(Offset = "0x40")]
	private int param2;

	[Token(Token = "0x400F813")]
	[FieldOffset(Offset = "0x44")]
	private int param3;

	[Token(Token = "0x400F814")]
	[FieldOffset(Offset = "0x48")]
	private int coinID;

	[Token(Token = "0x400F815")]
	[FieldOffset(Offset = "0x50")]
	private CoinSettings coinSettings;

	[Token(Token = "0x400F816")]
	[FieldOffset(Offset = "0x58")]
	private readonly string coinTossTimeLinePath;

	[Token(Token = "0x400F817")]
	[FieldOffset(Offset = "0x60")]
	private string loadedTexturePath;

	[Token(Token = "0x400F818")]
	[FieldOffset(Offset = "0x68")]
	private List<string> loadedAssetPathList;

	[Token(Token = "0x600B001")]
	[Address(RVA = "0x473740", Offset = "0x472940", VA = "0x180473740")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B002")]
	[Address(RVA = "0x4736B0", Offset = "0x4728B0", VA = "0x1804736B0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B003")]
	[Address(RVA = "0x474530", Offset = "0x473730", VA = "0x180474530")]
	public EffectTaskRunCoin(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B004")]
	[Address(RVA = "0x474050", Offset = "0x473250", VA = "0x180474050", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B005")]
	[Address(RVA = "0x4740A0", Offset = "0x4732A0", VA = "0x1804740A0")]
	private void WaitCardEffect()
	{
	}

	[Token(Token = "0x600B006")]
	[Address(RVA = "0x474340", Offset = "0x473540", VA = "0x180474340")]
	private void WaitCoin()
	{
	}

	[Token(Token = "0x600B007")]
	[Address(RVA = "0x4737A0", Offset = "0x4729A0", VA = "0x1804737A0", Slot = "5")]
	public override void OnDestroy()
	{
	}
}
