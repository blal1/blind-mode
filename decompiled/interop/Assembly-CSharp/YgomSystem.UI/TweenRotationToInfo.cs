using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000511")]
[CreateAssetMenu(menuName = "Tween Info/Tween Rotation To")]
public class TweenRotationToInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018DE")]
	[FieldOffset(Offset = "0x38")]
	public bool quaternionLerp;

	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 to;

	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	public TweenRotationToInfo()
	{
	}
}
