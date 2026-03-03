using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004FC")]
[AddComponentMenu("Ygom/UI/Tween/Tween Size To")]
[RequireComponent(typeof(RectTransform))]
public class TweenSizeTo : Tween
{
	[Token(Token = "0x4001896")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rtrans;

	[Token(Token = "0x4001897")]
	[FieldOffset(Offset = "0x78")]
	private Vector2 from;

	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public Vector2 to;

	[Token(Token = "0x4001899")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public bool ignoreWidth;

	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0x89")]
	[SerializeField]
	public bool ignoreHeight;

	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0x90")]
	private LayoutElement layout;

	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x640A90", Offset = "0x63FC90", VA = "0x180640A90", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x640BF0", Offset = "0x63FDF0", VA = "0x180640BF0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x640E20", Offset = "0x640020", VA = "0x180640E20")]
	public TweenSizeTo()
	{
	}
}
