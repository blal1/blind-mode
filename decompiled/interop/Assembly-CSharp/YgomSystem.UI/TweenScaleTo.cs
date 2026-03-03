using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004F1")]
[AddComponentMenu("Ygom/UI/Tween/Tween Scale To")]
public class TweenScaleTo : Tween
{
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 from;

	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public Vector3 to;

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x63E6F0", Offset = "0x63D8F0", VA = "0x18063E6F0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x63E6B0", Offset = "0x63D8B0", VA = "0x18063E6B0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x63E800", Offset = "0x63DA00", VA = "0x18063E800")]
	public TweenScaleTo()
	{
	}
}
