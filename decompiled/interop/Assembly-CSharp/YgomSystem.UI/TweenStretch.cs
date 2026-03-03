using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000500")]
[AddComponentMenu("Ygom/UI/Tween/Tween Stretch")]
[RequireComponent(typeof(RectTransform))]
public class TweenStretch : TweenStretchTo
{
	[Token(Token = "0x40018AC")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public StretchOffset from;

	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x642640", Offset = "0x641840", VA = "0x180642640", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x6426E0", Offset = "0x6418E0", VA = "0x1806426E0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x642550", Offset = "0x641750", VA = "0x180642550")]
	public TweenStretch()
	{
	}
}
