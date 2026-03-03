using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x200030B")]
public class VolumeAnimatorPaniniProjection : VolumeAnimatorComponentBase<PaniniProjection>
{
	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool distance_Ov;

	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 1f)]
	private float distance_Val;

	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool cropToFit_Ov;

	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float cropToFit_Val;

	[Token(Token = "0x600130C")]
	[Address(RVA = "0x41C7D0", Offset = "0x41B9D0", VA = "0x18041C7D0", Slot = "10")]
	protected override void ExecuteImport(PaniniProjection component)
	{
	}

	[Token(Token = "0x600130D")]
	[Address(RVA = "0x41C720", Offset = "0x41B920", VA = "0x18041C720", Slot = "11")]
	protected override void ExecuteExport(PaniniProjection component)
	{
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0x41C880", Offset = "0x41BA80", VA = "0x18041C880")]
	public VolumeAnimatorPaniniProjection()
	{
	}
}
