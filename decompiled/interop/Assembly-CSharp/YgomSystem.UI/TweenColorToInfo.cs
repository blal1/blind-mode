using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000509")]
[CreateAssetMenu(menuName = "Tween Info/Tween Color To")]
public class TweenColorToInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018CA")]
	[FieldOffset(Offset = "0x38")]
	[ColorLabelString]
	public string toLabel;

	[Token(Token = "0x40018CB")]
	[FieldOffset(Offset = "0x40")]
	public Color to;

	[Token(Token = "0x40018CC")]
	[FieldOffset(Offset = "0x50")]
	public bool isRecusive;

	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x63A4D0", Offset = "0x6396D0", VA = "0x18063A4D0")]
	public TweenColorToInfo()
	{
	}
}
