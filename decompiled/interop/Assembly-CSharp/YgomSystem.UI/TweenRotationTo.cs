using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004EF")]
[AddComponentMenu("Ygom/UI/Tween/Tween Rotation To")]
public class TweenRotationTo : Tween
{
	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 from;

	[Token(Token = "0x400185D")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 to;

	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0x88")]
	public bool quaternionLerp;

	[Token(Token = "0x6002098")]
	[Address(RVA = "0x63DCC0", Offset = "0x63CEC0", VA = "0x18063DCC0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x63DD70", Offset = "0x63CF70", VA = "0x18063DD70", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x63E010", Offset = "0x63D210", VA = "0x18063E010")]
	public TweenRotationTo()
	{
	}
}
