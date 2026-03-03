using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004FE")]
[AddComponentMenu("Ygom/UI/Tween/Tween Sprite Color")]
public class TweenSpriteColor : Tween
{
	[Token(Token = "0x40018A1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[ColorLabelString]
	public string fromLabel;

	[Token(Token = "0x40018A2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Color from;

	[Token(Token = "0x40018A3")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[ColorLabelString]
	public string toLabel;

	[Token(Token = "0x40018A4")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public Color to;

	[Token(Token = "0x40018A5")]
	[FieldOffset(Offset = "0xA0")]
	public bool isOverride;

	[Token(Token = "0x40018A6")]
	[FieldOffset(Offset = "0xA1")]
	public bool isRecusive;

	[Token(Token = "0x40018A7")]
	[FieldOffset(Offset = "0xA8")]
	private List<KeyValuePair<SpriteRenderer, Color>> childGraps;

	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x641760", Offset = "0x640960", VA = "0x180641760", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x641AE0", Offset = "0x640CE0", VA = "0x180641AE0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x641F50", Offset = "0x641150", VA = "0x180641F50")]
	public TweenSpriteColor()
	{
	}
}
