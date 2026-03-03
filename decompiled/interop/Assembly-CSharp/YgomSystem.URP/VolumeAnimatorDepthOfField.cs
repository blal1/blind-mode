using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000306")]
public class VolumeAnimatorDepthOfField : VolumeAnimatorComponentBase<DepthOfField>
{
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool mode_Ov;

	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private DepthOfFieldMode mode_Val;

	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool gaussianStart_Ov;

	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float gaussianStart_Val;

	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool gaussianEnd_Ov;

	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float gaussianEnd_Val;

	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool gaussianMaxRadius_Ov;

	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float gaussianMaxRadius_Val;

	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool highQualitySampling_Ov;

	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool highQualitySampling_Val;

	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	private bool focusDistance_Ov;

	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float focusDistance_Val;

	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool aperture_Ov;

	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float aperture_Val;

	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool focalLength_Ov;

	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Range(0f, 1f)]
	private float focalLength_Val;

	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool bladeCount_Ov;

	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Range(0f, 1f)]
	private int bladeCount_Val;

	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool bladeCurvature_Ov;

	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Range(0f, 1f)]
	private float bladeCurvature_Val;

	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool bladeRotation_Ov;

	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float bladeRotation_Val;

	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x41B750", Offset = "0x41A950", VA = "0x18041B750", Slot = "10")]
	protected override void ExecuteImport(DepthOfField component)
	{
	}

	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x41B400", Offset = "0x41A600", VA = "0x18041B400", Slot = "11")]
	protected override void ExecuteExport(DepthOfField component)
	{
	}

	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x41BA90", Offset = "0x41AC90", VA = "0x18041BA90")]
	public VolumeAnimatorDepthOfField()
	{
	}
}
