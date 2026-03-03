using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200050E")]
[CreateAssetMenu(menuName = "Tween Info/Tween Position")]
public class TweenPositionInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018D8")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 from;

	[Token(Token = "0x40018D9")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 to;

	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	public TweenPositionInfo()
	{
	}
}
