using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004EB")]
[AddComponentMenu("Ygom/UI/Tween/Tween Position Target")]
public class TweenPositionTarget : Tween
{
	[Token(Token = "0x400184A")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rtrans;

	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Vector3 from;

	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public Vector3 to;

	[Token(Token = "0x400184D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public bool updateX;

	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x91")]
	[SerializeField]
	public bool updateY;

	[Token(Token = "0x400184F")]
	[FieldOffset(Offset = "0x92")]
	[SerializeField]
	public bool updateZ;

	[Token(Token = "0x600208D")]
	[Address(RVA = "0x63D1B0", Offset = "0x63C3B0", VA = "0x18063D1B0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x600208E")]
	[Address(RVA = "0x63D230", Offset = "0x63C430", VA = "0x18063D230", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600208F")]
	[Address(RVA = "0x63D4C0", Offset = "0x63C6C0", VA = "0x18063D4C0")]
	public TweenPositionTarget()
	{
	}
}
