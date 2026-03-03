using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004E3")]
[AddComponentMenu("Ygom/UI/Tween/Tween Color")]
public class TweenColor : Tween
{
	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[ColorLabelString]
	public string fromLabel;

	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Color from;

	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[ColorLabelString]
	public string toLabel;

	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public Color to;

	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0xA0")]
	public bool isOverride;

	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0xA1")]
	public bool isRecusive;

	[Token(Token = "0x4001832")]
	[FieldOffset(Offset = "0xA8")]
	private List<KeyValuePair<Graphic, Color>> childGraps;

	[Token(Token = "0x6002075")]
	[Address(RVA = "0x63ACD0", Offset = "0x639ED0", VA = "0x18063ACD0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x63B050", Offset = "0x63A250", VA = "0x18063B050", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0x63B4D0", Offset = "0x63A6D0", VA = "0x18063B4D0")]
	public TweenColor()
	{
	}
}
