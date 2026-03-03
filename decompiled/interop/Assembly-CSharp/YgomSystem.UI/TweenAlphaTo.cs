using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004E2")]
[AddComponentMenu("Ygom/UI/Tween/Tween Alpha To")]
public class TweenAlphaTo : Tween
{
	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Range(0f, 1f)]
	public float to;

	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x74")]
	public bool isRecusive;

	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x78")]
	private CanvasGroup canvasGroup;

	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0x80")]
	private float canvasAlpha;

	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0x88")]
	private List<KeyValuePair<Graphic, Color>> childGraps;

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x639700", Offset = "0x638900", VA = "0x180639700", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x639AE0", Offset = "0x638CE0", VA = "0x180639AE0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x639DB0", Offset = "0x638FB0", VA = "0x180639DB0")]
	public TweenAlphaTo()
	{
	}
}
