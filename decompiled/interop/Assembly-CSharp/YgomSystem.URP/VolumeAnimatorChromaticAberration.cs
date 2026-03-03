using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000301")]
public class VolumeAnimatorChromaticAberration : VolumeAnimatorComponentBase<ChromaticAberration>
{
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool intensity_Ov;

	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 1f)]
	private float intensity_Val;

	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x41A650", Offset = "0x419850", VA = "0x18041A650", Slot = "10")]
	protected override void ExecuteImport(ChromaticAberration component)
	{
	}

	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x41A5E0", Offset = "0x4197E0", VA = "0x18041A5E0", Slot = "11")]
	protected override void ExecuteExport(ChromaticAberration component)
	{
	}

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x41A6C0", Offset = "0x4198C0", VA = "0x18041A6C0")]
	public VolumeAnimatorChromaticAberration()
	{
	}
}
