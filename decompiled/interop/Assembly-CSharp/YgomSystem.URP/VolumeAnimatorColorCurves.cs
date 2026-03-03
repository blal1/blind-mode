using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000303")]
public class VolumeAnimatorColorCurves : VolumeAnimatorComponentBase<ColorCurves>
{
	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool master_Ov;

	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextureCurve master_Val;

	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool red_Ov;

	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextureCurve red_Val;

	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool green_Ov;

	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TextureCurve green_Val;

	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool blue_Ov;

	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextureCurve blue_Val;

	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool hueVsHue_Ov;

	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private TextureCurve hueVsHue_Val;

	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool hueVsSat_Ov;

	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TextureCurve hueVsSat_Val;

	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool satVsSat_Ov;

	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private TextureCurve satVsSat_Val;

	[Token(Token = "0x400106E")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private bool lumVsSat_Ov;

	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private TextureCurve lumVsSat_Val;

	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x41ACE0", Offset = "0x419EE0", VA = "0x18041ACE0", Slot = "10")]
	protected override void ExecuteImport(ColorCurves component)
	{
	}

	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x41AA70", Offset = "0x419C70", VA = "0x18041AA70", Slot = "11")]
	protected override void ExecuteExport(ColorCurves component)
	{
	}

	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x41AFC0", Offset = "0x41A1C0", VA = "0x18041AFC0")]
	public VolumeAnimatorColorCurves()
	{
	}
}
