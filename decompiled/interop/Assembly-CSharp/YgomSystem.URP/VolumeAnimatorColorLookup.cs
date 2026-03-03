using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000304")]
public class VolumeAnimatorColorLookup : VolumeAnimatorComponentBase<ColorLookup>
{
	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool texture_Ov;

	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Texture texture_Val;

	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool contribution_Ov;

	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float contribution_Val;

	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x41B0B0", Offset = "0x41A2B0", VA = "0x18041B0B0", Slot = "10")]
	protected override void ExecuteImport(ColorLookup component)
	{
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x41B000", Offset = "0x41A200", VA = "0x18041B000", Slot = "11")]
	protected override void ExecuteExport(ColorLookup component)
	{
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x41B170", Offset = "0x41A370", VA = "0x18041B170")]
	public VolumeAnimatorColorLookup()
	{
	}
}
