using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000513")]
[CreateAssetMenu(menuName = "Tween Info/Tween Scale To")]
public class TweenScaleToInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 to;

	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	public TweenScaleToInfo()
	{
	}
}
