using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004E5")]
[AddComponentMenu("Ygom/UI/Tween/Tween Counter Text")]
public class TweenCounterText : Tween
{
	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public string format;

	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float from;

	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float to;

	[Token(Token = "0x400183A")]
	[FieldOffset(Offset = "0x80")]
	private Text text;

	[Token(Token = "0x400183B")]
	[FieldOffset(Offset = "0x88")]
	private TMP_Text tmpText;

	[Token(Token = "0x600207B")]
	[Address(RVA = "0x63B540", Offset = "0x63A740", VA = "0x18063B540", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x600207C")]
	[Address(RVA = "0x63B600", Offset = "0x63A800", VA = "0x18063B600", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x600207D")]
	[Address(RVA = "0x63B5C0", Offset = "0x63A7C0", VA = "0x18063B5C0")]
	private string GetCurrentCounterText(float par)
	{
		return null;
	}

	[Token(Token = "0x600207E")]
	[Address(RVA = "0x63B760", Offset = "0x63A960", VA = "0x18063B760")]
	public TweenCounterText()
	{
	}
}
