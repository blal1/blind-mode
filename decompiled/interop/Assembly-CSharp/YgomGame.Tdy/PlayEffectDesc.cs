using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000853")]
public class PlayEffectDesc
{
	[Token(Token = "0x40085EA")]
	[FieldOffset(Offset = "0x10")]
	public PlayEffectType type;

	[Token(Token = "0x40085EB")]
	[FieldOffset(Offset = "0x18")]
	public KizunaStatus[] status;

	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x74F990", Offset = "0x74EB90", VA = "0x18074F990")]
	private int idToIndex(int kizunaID)
	{
		return default(int);
	}

	[Token(Token = "0x60032A8")]
	[Address(RVA = "0x74F8B0", Offset = "0x74EAB0", VA = "0x18074F8B0")]
	public KizunaStatus GetStatus(int kizunaID)
	{
		return default(KizunaStatus);
	}

	[Token(Token = "0x60032A9")]
	[Address(RVA = "0x74F8F0", Offset = "0x74EAF0", VA = "0x18074F8F0")]
	public void SetStatus(int kizunaID, KizunaStatus st)
	{
	}

	[Token(Token = "0x60032AA")]
	[Address(RVA = "0x74F930", Offset = "0x74EB30", VA = "0x18074F930")]
	public PlayEffectDesc()
	{
	}
}
