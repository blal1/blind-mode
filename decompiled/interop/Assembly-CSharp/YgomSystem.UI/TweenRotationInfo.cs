using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000510")]
[CreateAssetMenu(menuName = "Tween Info/Tween Rotation")]
public class TweenRotationInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018DB")]
	[FieldOffset(Offset = "0x38")]
	public bool quaternionLerp;

	[Token(Token = "0x40018DC")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 from;

	[Token(Token = "0x40018DD")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 to;

	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	public TweenRotationInfo()
	{
	}
}
