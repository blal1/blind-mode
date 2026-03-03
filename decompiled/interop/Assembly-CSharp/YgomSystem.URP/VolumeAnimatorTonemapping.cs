using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x200030E")]
public class VolumeAnimatorTonemapping : VolumeAnimatorComponentBase<Tonemapping>
{
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool mode_Ov;

	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private TonemappingMode mode_Val;

	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool acesPreset_Ov;

	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private HDRACESPreset acesPreset_Val;

	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool hueShiftAmount_Ov;

	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float hueShiftAmount_Val;

	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool detectPaperWhite_Ov;

	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool detectPaperWhite_Val;

	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool paperWhite_Ov;

	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float paperWhite_Val;

	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool detectBrightnessLimits_Ov;

	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool detectBrightnessLimits_Val;

	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	private bool minNits_Ov;

	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0f, 1f)]
	private float minNits_Val;

	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool maxNits_Ov;

	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float maxNits_Val;

	[Token(Token = "0x6001315")]
	[Address(RVA = "0x41D2F0", Offset = "0x41C4F0", VA = "0x18041D2F0", Slot = "10")]
	protected override void ExecuteImport(Tonemapping component)
	{
	}

	[Token(Token = "0x6001316")]
	[Address(RVA = "0x41D090", Offset = "0x41C290", VA = "0x18041D090", Slot = "11")]
	protected override void ExecuteExport(Tonemapping component)
	{
	}

	[Token(Token = "0x6001317")]
	[Address(RVA = "0x41D550", Offset = "0x41C750", VA = "0x18041D550")]
	public VolumeAnimatorTonemapping()
	{
	}
}
