using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.URP;

[Token(Token = "0x2000305")]
public class VolumeAnimatorCustomPostEffectVolume : VolumeAnimatorComponentBase<CustomPostEffectVolume>
{
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool passName_Ov;

	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string passName_Val;

	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool material_Ov;

	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Material material_Val;

	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool passIndex_Ov;

	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private int passIndex_Val;

	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x41B2B0", Offset = "0x41A4B0", VA = "0x18041B2B0", Slot = "10")]
	protected override void ExecuteImport(CustomPostEffectVolume component)
	{
	}

	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x41B1B0", Offset = "0x41A3B0", VA = "0x18041B1B0", Slot = "11")]
	protected override void ExecuteExport(CustomPostEffectVolume component)
	{
	}

	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x41B3C0", Offset = "0x41A5C0", VA = "0x18041B3C0")]
	public VolumeAnimatorCustomPostEffectVolume()
	{
	}
}
