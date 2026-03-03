using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004EE")]
[AddComponentMenu("Ygom/UI/Tween/Tween Rotation")]
public class TweenRotation : Tween
{
	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 from;

	[Token(Token = "0x400185A")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 to;

	[Token(Token = "0x400185B")]
	[FieldOffset(Offset = "0x88")]
	public bool quaternionLerp;

	[Token(Token = "0x6002096")]
	[Address(RVA = "0x63E0D0", Offset = "0x63D2D0", VA = "0x18063E0D0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002097")]
	[Address(RVA = "0x63E470", Offset = "0x63D670", VA = "0x18063E470")]
	public TweenRotation()
	{
	}
}
