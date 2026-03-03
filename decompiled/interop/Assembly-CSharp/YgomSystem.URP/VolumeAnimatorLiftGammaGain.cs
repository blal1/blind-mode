using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000309")]
public class VolumeAnimatorLiftGammaGain : VolumeAnimatorComponentBase<LiftGammaGain>
{
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool lift_Ov;

	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector4 lift_Val;

	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool gamma_Ov;

	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector4 gamma_Val;

	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool gain_Ov;

	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector4 gain_Val;

	[Token(Token = "0x6001306")]
	[Address(RVA = "0x41C280", Offset = "0x41B480", VA = "0x18041C280", Slot = "10")]
	protected override void ExecuteImport(LiftGammaGain component)
	{
	}

	[Token(Token = "0x6001307")]
	[Address(RVA = "0x41C160", Offset = "0x41B360", VA = "0x18041C160", Slot = "11")]
	protected override void ExecuteExport(LiftGammaGain component)
	{
	}

	[Token(Token = "0x6001308")]
	[Address(RVA = "0x41C390", Offset = "0x41B590", VA = "0x18041C390")]
	public VolumeAnimatorLiftGammaGain()
	{
	}
}
