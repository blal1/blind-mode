using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000512")]
[CreateAssetMenu(menuName = "Tween Info/Tween Scale")]
public class TweenScaleInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 from;

	[Token(Token = "0x40018E1")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 to;

	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	public TweenScaleInfo()
	{
	}
}
