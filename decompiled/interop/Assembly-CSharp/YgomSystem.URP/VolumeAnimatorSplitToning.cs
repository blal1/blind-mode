using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x200030D")]
public class VolumeAnimatorSplitToning : VolumeAnimatorComponentBase<SplitToning>
{
	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool shadows_Ov;

	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Color shadows_Val;

	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool highlights_Ov;

	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Color highlights_Val;

	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool balance_Ov;

	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float balance_Val;

	[Token(Token = "0x6001312")]
	[Address(RVA = "0x41CF30", Offset = "0x41C130", VA = "0x18041CF30", Slot = "10")]
	protected override void ExecuteImport(SplitToning component)
	{
	}

	[Token(Token = "0x6001313")]
	[Address(RVA = "0x41CE20", Offset = "0x41C020", VA = "0x18041CE20", Slot = "11")]
	protected override void ExecuteExport(SplitToning component)
	{
	}

	[Token(Token = "0x6001314")]
	[Address(RVA = "0x41D040", Offset = "0x41C240", VA = "0x18041D040")]
	public VolumeAnimatorSplitToning()
	{
	}
}
