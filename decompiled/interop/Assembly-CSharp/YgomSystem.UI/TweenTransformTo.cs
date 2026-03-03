using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000503")]
[AddComponentMenu("Ygom/UI/Tween/Tween Transform To")]
public class TweenTransformTo : Tween
{
	[Token(Token = "0x40018B5")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 fromPosition;

	[Token(Token = "0x40018B6")]
	[FieldOffset(Offset = "0x7C")]
	private Quaternion fromRotation;

	[Token(Token = "0x40018B7")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 fromScale;

	[Token(Token = "0x40018B8")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public Transform to;

	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020D7")]
	[Address(RVA = "0x642850", Offset = "0x641A50", VA = "0x180642850", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020D8")]
	[Address(RVA = "0x642B50", Offset = "0x641D50", VA = "0x180642B50")]
	public TweenTransformTo()
	{
	}
}
