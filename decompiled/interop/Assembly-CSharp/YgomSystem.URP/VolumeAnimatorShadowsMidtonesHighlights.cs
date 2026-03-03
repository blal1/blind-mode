using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x200030C")]
public class VolumeAnimatorShadowsMidtonesHighlights : VolumeAnimatorComponentBase<ShadowsMidtonesHighlights>
{
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool shadows_Ov;

	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector4 shadows_Val;

	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool midtones_Ov;

	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector4 midtones_Val;

	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool highlights_Ov;

	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector4 highlights_Val;

	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private bool shadowsStart_Ov;

	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float shadowsStart_Val;

	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool shadowsEnd_Ov;

	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float shadowsEnd_Val;

	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private bool highlightsStart_Ov;

	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float highlightsStart_Val;

	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private bool highlightsEnd_Ov;

	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float highlightsEnd_Val;

	[Token(Token = "0x600130F")]
	[Address(RVA = "0x41CB10", Offset = "0x41BD10", VA = "0x18041CB10", Slot = "10")]
	protected override void ExecuteImport(ShadowsMidtonesHighlights component)
	{
	}

	[Token(Token = "0x6001310")]
	[Address(RVA = "0x41C8C0", Offset = "0x41BAC0", VA = "0x18041C8C0", Slot = "11")]
	protected override void ExecuteExport(ShadowsMidtonesHighlights component)
	{
	}

	[Token(Token = "0x6001311")]
	[Address(RVA = "0x41CD50", Offset = "0x41BF50", VA = "0x18041CD50")]
	public VolumeAnimatorShadowsMidtonesHighlights()
	{
	}
}
