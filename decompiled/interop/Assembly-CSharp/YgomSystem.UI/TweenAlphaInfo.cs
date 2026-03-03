using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000506")]
[CreateAssetMenu(menuName = "Tween Info/Tween Alpha")]
public class TweenAlphaInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018BF")]
	[FieldOffset(Offset = "0x38")]
	public float from;

	[Token(Token = "0x40018C0")]
	[FieldOffset(Offset = "0x3C")]
	public float to;

	[Token(Token = "0x40018C1")]
	[FieldOffset(Offset = "0x40")]
	public bool isRecusive;

	[Token(Token = "0x60020DF")]
	[Address(RVA = "0x639230", Offset = "0x638430", VA = "0x180639230")]
	public TweenAlphaInfo()
	{
	}
}
