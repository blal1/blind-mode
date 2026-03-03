using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004FB")]
[AddComponentMenu("Ygom/UI/Tween/Tween Size")]
[RequireComponent(typeof(RectTransform))]
public class TweenSize : Tween
{
	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rtrans;

	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector2 from;

	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public Vector2 to;

	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public bool ignoreWidth;

	[Token(Token = "0x4001894")]
	[FieldOffset(Offset = "0x89")]
	[SerializeField]
	public bool ignoreHeight;

	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x90")]
	private LayoutElement layout;

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x640EF0", Offset = "0x6400F0", VA = "0x180640EF0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x640FA0", Offset = "0x6401A0", VA = "0x180640FA0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x641150", Offset = "0x640350", VA = "0x180641150")]
	public TweenSize()
	{
	}
}
