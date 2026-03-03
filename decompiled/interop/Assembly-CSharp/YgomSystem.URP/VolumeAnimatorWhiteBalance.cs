using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000310")]
public class VolumeAnimatorWhiteBalance : VolumeAnimatorComponentBase<WhiteBalance>
{
	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool temperature_Ov;

	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 1f)]
	private float temperature_Val;

	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool tint_Ov;

	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float tint_Val;

	[Token(Token = "0x600131B")]
	[Address(RVA = "0x41C7D0", Offset = "0x41B9D0", VA = "0x18041C7D0", Slot = "10")]
	protected override void ExecuteImport(WhiteBalance component)
	{
	}

	[Token(Token = "0x600131C")]
	[Address(RVA = "0x41C720", Offset = "0x41B920", VA = "0x18041C720", Slot = "11")]
	protected override void ExecuteExport(WhiteBalance component)
	{
	}

	[Token(Token = "0x600131D")]
	[Address(RVA = "0x41D960", Offset = "0x41CB60", VA = "0x18041D960")]
	public VolumeAnimatorWhiteBalance()
	{
	}
}
