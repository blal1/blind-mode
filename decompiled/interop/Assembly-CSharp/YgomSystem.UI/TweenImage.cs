using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004E8")]
[AddComponentMenu("Ygom/UI/Tween/Tween Image")]
public class TweenImage : Tween
{
	[Token(Token = "0x4001840")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public Sprite[] frames;

	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x78")]
	private Image image;

	[Token(Token = "0x6002083")]
	[Address(RVA = "0x63BA30", Offset = "0x63AC30", VA = "0x18063BA30", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x6002084")]
	[Address(RVA = "0x63BA80", Offset = "0x63AC80", VA = "0x18063BA80", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x6002085")]
	[Address(RVA = "0x63BB50", Offset = "0x63AD50", VA = "0x18063BB50")]
	public TweenImage()
	{
	}
}
