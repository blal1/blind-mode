using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200055D")]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
public class TouchParticle : uGuiParticleBase
{
	[Token(Token = "0x4001A0C")]
	[FieldOffset(Offset = "0x0")]
	private static int TouchEnableCount;

	[Token(Token = "0x4001A0D")]
	[FieldOffset(Offset = "0x118")]
	public float emissionSpan;

	[Token(Token = "0x4001A0E")]
	[FieldOffset(Offset = "0x11C")]
	public float moveEmissionSpan;

	[Token(Token = "0x4001A0F")]
	[FieldOffset(Offset = "0x120")]
	public float lifeTime;

	[Token(Token = "0x4001A10")]
	[FieldOffset(Offset = "0x124")]
	public float startScaleMin;

	[Token(Token = "0x4001A11")]
	[FieldOffset(Offset = "0x128")]
	public float startScaleMax;

	[Token(Token = "0x4001A12")]
	[FieldOffset(Offset = "0x12C")]
	public float endScale;

	[Token(Token = "0x4001A13")]
	[FieldOffset(Offset = "0x130")]
	public int startId;

	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x134")]
	public int endId;

	[Token(Token = "0x4001A15")]
	[FieldOffset(Offset = "0x138")]
	public float rscaleMin;

	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x13C")]
	public float rscaleMax;

	[Token(Token = "0x4001A17")]
	[FieldOffset(Offset = "0x140")]
	public float totalscale;

	[Token(Token = "0x4001A18")]
	[FieldOffset(Offset = "0x144")]
	private float emission;

	[Token(Token = "0x4001A19")]
	[FieldOffset(Offset = "0x148")]
	private float rscale;

	[Token(Token = "0x4001A1A")]
	[FieldOffset(Offset = "0x150")]
	private Color32[] scolors;

	[Token(Token = "0x4001A1B")]
	[FieldOffset(Offset = "0x158")]
	private Color32[] ecolors;

	[Token(Token = "0x4001A1C")]
	[FieldOffset(Offset = "0x160")]
	private int pointingBit;

	[Token(Token = "0x4001A1D")]
	[FieldOffset(Offset = "0x164")]
	private int pointingTrgBit;

	[Token(Token = "0x4001A1E")]
	[FieldOffset(Offset = "0x168")]
	private int pointingNtrgBit;

	[Token(Token = "0x4001A1F")]
	[FieldOffset(Offset = "0x16C")]
	private int pointingMoveBit;

	[Token(Token = "0x4001A20")]
	[FieldOffset(Offset = "0x170")]
	private Vector2[] pointingPos;

	[Token(Token = "0x60022C9")]
	[Address(RVA = "0x653C90", Offset = "0x652E90", VA = "0x180653C90")]
	private void CreateTouchParticle(float px, float py, int n, float rs, float ss)
	{
	}

	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x6543B0", Offset = "0x6535B0", VA = "0x1806543B0")]
	public static void EffectDisable()
	{
	}

	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x6543F0", Offset = "0x6535F0", VA = "0x1806543F0")]
	public static void EffectEnable()
	{
	}

	[Token(Token = "0x60022CC")]
	[Address(RVA = "0x654430", Offset = "0x653630", VA = "0x180654430", Slot = "65")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x654D40", Offset = "0x653F40", VA = "0x180654D40")]
	public TouchParticle()
	{
	}
}
