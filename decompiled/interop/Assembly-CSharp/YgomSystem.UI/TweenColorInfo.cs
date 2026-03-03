using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000508")]
[CreateAssetMenu(menuName = "Tween Info/Tween Color")]
public class TweenColorInfo : TweenGenerateInfo
{
	[Token(Token = "0x40018C4")]
	[FieldOffset(Offset = "0x38")]
	[ColorLabelString]
	public string fromLabel;

	[Token(Token = "0x40018C5")]
	[FieldOffset(Offset = "0x40")]
	public Color from;

	[Token(Token = "0x40018C6")]
	[FieldOffset(Offset = "0x50")]
	[ColorLabelString]
	public string toLabel;

	[Token(Token = "0x40018C7")]
	[FieldOffset(Offset = "0x58")]
	public Color to;

	[Token(Token = "0x40018C8")]
	[FieldOffset(Offset = "0x68")]
	public bool isOverride;

	[Token(Token = "0x40018C9")]
	[FieldOffset(Offset = "0x69")]
	public bool isRecusive;

	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x63A4A0", Offset = "0x6396A0", VA = "0x18063A4A0")]
	public TweenColorInfo()
	{
	}
}
