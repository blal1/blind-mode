using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x2000231")]
public class TextMeshProAutoSizer : MonoBehaviour
{
	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool autoUpdate;

	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float checkSizeDelta;

	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text tmpText;

	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x30")]
	private string currentText;

	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform rectTransform;

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0xD3B350", Offset = "0xD3A550", VA = "0x180D3B350")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0xD3B410", Offset = "0xD3A610", VA = "0x180D3B410")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0xD3B240", Offset = "0xD3A440", VA = "0x180D3B240")]
	public void Apply()
	{
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0xD3B110", Offset = "0xD3A310", VA = "0x180D3B110")]
	public static float ApplyFontSize(TMP_Text target, float fitRectHeight, float fontSizeMin, float fontSizeMax = -1f, float sizeDelta = 1f, bool maxToMin = true)
	{
		return default(float);
	}

	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0xD3AFB0", Offset = "0xD3A1B0", VA = "0x180D3AFB0")]
	private static float ApplyFontSizeMaxToMin(TMP_Text target, float fitRectHeight, float fontSizeMin, float fontSizeMax, float sizeDelta)
	{
		return default(float);
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0xD3B060", Offset = "0xD3A260", VA = "0x180D3B060")]
	private static float ApplyFontSizeMinToMax(TMP_Text target, float fitRectHeight, float fontSizeMin, float fontSizeMax, float sizeDelta)
	{
		return default(float);
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0xD3B5E0", Offset = "0xD3A7E0", VA = "0x180D3B5E0")]
	public TextMeshProAutoSizer()
	{
	}
}
