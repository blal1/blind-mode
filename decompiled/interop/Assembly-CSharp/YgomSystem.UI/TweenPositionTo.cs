using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004ED")]
[AddComponentMenu("Ygom/UI/Tween/Tween Position To")]
public class TweenPositionTo : Tween
{
	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rtrans;

	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 from;

	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public Vector3 to;

	[Token(Token = "0x6002093")]
	[Address(RVA = "0x63D5A0", Offset = "0x63C7A0", VA = "0x18063D5A0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002094")]
	[Address(RVA = "0x63D6A0", Offset = "0x63C8A0", VA = "0x18063D6A0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002095")]
	[Address(RVA = "0x63D8F0", Offset = "0x63CAF0", VA = "0x18063D8F0")]
	public TweenPositionTo()
	{
	}
}
