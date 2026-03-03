using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200050F")]
[CreateAssetMenu(menuName = "Tween Info/Tween Position To")]
public class TweenPositionToInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018DA")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 to;

	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x63B820", Offset = "0x63AA20", VA = "0x18063B820")]
	public TweenPositionToInfo()
	{
	}
}
