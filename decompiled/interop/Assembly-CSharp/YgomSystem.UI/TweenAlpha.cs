using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004E0")]
[AddComponentMenu("Ygom/UI/Tween/Tween Alpha")]
public class TweenAlpha : Tween
{
	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Range(0f, 1f)]
	public float from;

	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Range(0f, 1f)]
	public float to;

	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x78")]
	public bool isRecusive;

	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x80")]
	private CanvasGroup canvasGroup;

	[Token(Token = "0x4001822")]
	[FieldOffset(Offset = "0x88")]
	private List<KeyValuePair<Graphic, Color>> childGraps;

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x639E00", Offset = "0x639000", VA = "0x180639E00", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x63A1C0", Offset = "0x6393C0", VA = "0x18063A1C0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600206E")]
	[Address(RVA = "0x63A440", Offset = "0x639640", VA = "0x18063A440")]
	public TweenAlpha()
	{
	}
}
