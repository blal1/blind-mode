using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000308")]
public class VolumeAnimatorLensDistortion : VolumeAnimatorComponentBase<LensDistortion>
{
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool intensity_Ov;

	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 1f)]
	private float intensity_Val;

	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool xMultiplier_Ov;

	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float xMultiplier_Val;

	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool yMultiplier_Ov;

	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float yMultiplier_Val;

	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool center_Ov;

	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector2 center_Val;

	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool scale_Ov;

	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Range(0f, 1f)]
	private float scale_Val;

	[Token(Token = "0x6001303")]
	[Address(RVA = "0x41BF40", Offset = "0x41B140", VA = "0x18041BF40", Slot = "10")]
	protected override void ExecuteImport(LensDistortion component)
	{
	}

	[Token(Token = "0x6001304")]
	[Address(RVA = "0x41BDA0", Offset = "0x41AFA0", VA = "0x18041BDA0", Slot = "11")]
	protected override void ExecuteExport(LensDistortion component)
	{
	}

	[Token(Token = "0x6001305")]
	[Address(RVA = "0x41C0E0", Offset = "0x41B2E0", VA = "0x18041C0E0")]
	public VolumeAnimatorLensDistortion()
	{
	}
}
