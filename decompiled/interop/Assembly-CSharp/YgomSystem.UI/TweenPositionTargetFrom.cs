using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004EC")]
[AddComponentMenu("Ygom/UI/Tween/Tween Position Target From")]
public class TweenPositionTargetFrom : Tween
{
	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rtrans;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Vector3 from;

	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public bool updateX;

	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x85")]
	[SerializeField]
	public bool updateY;

	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x86")]
	[SerializeField]
	public bool updateZ;

	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 to;

	[Token(Token = "0x6002090")]
	[Address(RVA = "0x63CD30", Offset = "0x63BF30", VA = "0x18063CD30", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002091")]
	[Address(RVA = "0x63CE40", Offset = "0x63C040", VA = "0x18063CE40", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002092")]
	[Address(RVA = "0x63D0D0", Offset = "0x63C2D0", VA = "0x18063D0D0")]
	public TweenPositionTargetFrom()
	{
	}
}
