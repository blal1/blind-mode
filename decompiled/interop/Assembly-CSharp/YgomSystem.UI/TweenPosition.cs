using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004EA")]
[AddComponentMenu("Ygom/UI/Tween/Tween Position")]
public class TweenPosition : Tween
{
	[Token(Token = "0x4001847")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rtrans;

	[Token(Token = "0x4001848")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Vector3 from;

	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public Vector3 to;

	[Token(Token = "0x600208A")]
	[Address(RVA = "0x63D9C0", Offset = "0x63CBC0", VA = "0x18063D9C0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x63DA40", Offset = "0x63CC40", VA = "0x18063DA40", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600208C")]
	[Address(RVA = "0x63DBF0", Offset = "0x63CDF0", VA = "0x18063DBF0")]
	public TweenPosition()
	{
	}
}
