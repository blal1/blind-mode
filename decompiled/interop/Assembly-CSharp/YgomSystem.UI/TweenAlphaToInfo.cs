using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000507")]
[CreateAssetMenu(menuName = "Tween Info/Tween Alpha To")]
public class TweenAlphaToInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018C2")]
	[FieldOffset(Offset = "0x38")]
	public float to;

	[Token(Token = "0x40018C3")]
	[FieldOffset(Offset = "0x3C")]
	public bool isRecusive;

	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x6396E0", Offset = "0x6388E0", VA = "0x1806396E0")]
	public TweenAlphaToInfo()
	{
	}
}
