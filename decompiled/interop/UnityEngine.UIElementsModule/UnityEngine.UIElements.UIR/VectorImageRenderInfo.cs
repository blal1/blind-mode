using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000577")]
internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
{
	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x18")]
	public int useCount;

	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0x20")]
	public GradientRemap firstGradientRemap;

	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x28")]
	public Alloc gradientSettingsAlloc;

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x2A68580", Offset = "0x2A67780", VA = "0x182A68580")]
	public void Reset()
	{
	}

	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x2A685B0", Offset = "0x2A677B0", VA = "0x182A685B0")]
	public VectorImageRenderInfo()
	{
	}
}
