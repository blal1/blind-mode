using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004F0")]
[AddComponentMenu("Ygom/UI/Tween/Tween Scale")]
public class TweenScale : Tween
{
	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public Vector3 from;

	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public Vector3 to;

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x63E8C0", Offset = "0x63DAC0", VA = "0x18063E8C0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x600209C")]
	[Address(RVA = "0x63E910", Offset = "0x63DB10", VA = "0x18063E910", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x63E9D0", Offset = "0x63DBD0", VA = "0x18063E9D0")]
	public TweenScale()
	{
	}
}
