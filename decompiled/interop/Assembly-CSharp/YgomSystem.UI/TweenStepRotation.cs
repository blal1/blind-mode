using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004FF")]
[AddComponentMenu("Ygom/UI/Tween/Tween Step Rotation")]
public class TweenStepRotation : Tween
{
	[Token(Token = "0x40018A8")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 from;

	[Token(Token = "0x40018A9")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 to;

	[Token(Token = "0x40018AA")]
	[FieldOffset(Offset = "0x88")]
	public Vector3 origin;

	[Token(Token = "0x40018AB")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 step;

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x641FC0", Offset = "0x6411C0", VA = "0x180641FC0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x6421B0", Offset = "0x6413B0", VA = "0x1806421B0")]
	public TweenStepRotation()
	{
	}
}
