using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x20002FF")]
public class VolumeAnimatorBloom : VolumeAnimatorComponentBase<Bloom>
{
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool threshold_Ov;

	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float threshold_Val;

	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool intensity_Ov;

	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float intensity_Val;

	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool scatter_Ov;

	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float scatter_Val;

	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool clamp_Ov;

	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float clamp_Val;

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool tint_Ov;

	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private Color tint_Val;

	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool highQualityFiltering_Ov;

	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x65")]
	[SerializeField]
	private bool highQualityFiltering_Val;

	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0x66")]
	[SerializeField]
	private bool dirtTexture_Ov;

	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Texture dirtTexture_Val;

	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool dirtIntensity_Ov;

	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float dirtIntensity_Val;

	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x419D80", Offset = "0x418F80", VA = "0x180419D80", Slot = "10")]
	protected override void ExecuteImport(Bloom component)
	{
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x419B00", Offset = "0x418D00", VA = "0x180419B00", Slot = "11")]
	protected override void ExecuteExport(Bloom component)
	{
	}

	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x41A000", Offset = "0x419200", VA = "0x18041A000")]
	public VolumeAnimatorBloom()
	{
	}
}
