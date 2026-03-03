using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.Effect;

[Token(Token = "0x2000324")]
public class ScreenFiller : MonoBehaviour
{
	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager elements;

	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x28")]
	private SpriteRenderer fillSprite;

	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x0")]
	private static ScreenFiller instance;

	[Token(Token = "0x4001129")]
	[FieldOffset(Offset = "0x30")]
	private float time;

	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0x34")]
	private float fadeTime;

	[Token(Token = "0x400112B")]
	private const float DefaultFadeTime = 0.2f;

	[Token(Token = "0x400112C")]
	[FieldOffset(Offset = "0x38")]
	private Color startColor;

	[Token(Token = "0x400112D")]
	[FieldOffset(Offset = "0x48")]
	private Color targetColor;

	[Token(Token = "0x400112E")]
	[FieldOffset(Offset = "0x58")]
	private bool isLock;

	[Token(Token = "0x600139A")]
	[Address(RVA = "0x414F70", Offset = "0x414170", VA = "0x180414F70")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x415450", Offset = "0x414650", VA = "0x180415450")]
	public void SetSpriteColor(Color color)
	{
	}

	[Token(Token = "0x600139C")]
	[Address(RVA = "0x415490", Offset = "0x414690", VA = "0x180415490")]
	public void StartFade(Color targetColor, float fadeTime = 0.2f)
	{
	}

	[Token(Token = "0x600139D")]
	[Address(RVA = "0x415750", Offset = "0x414950", VA = "0x180415750")]
	private void UpdateFade(bool force = false)
	{
	}

	[Token(Token = "0x600139E")]
	[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
	private void SetLock(bool isLock)
	{
	}

	[Token(Token = "0x600139F")]
	[Address(RVA = "0x4152D0", Offset = "0x4144D0", VA = "0x1804152D0")]
	public static void SetFillColor(Color color)
	{
	}

	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x4155B0", Offset = "0x4147B0", VA = "0x1804155B0")]
	public static void StartFillFade(Color color, float fadeTime = 0.2f)
	{
	}

	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x4153A0", Offset = "0x4145A0", VA = "0x1804153A0")]
	public static void SetFillLock(bool isLock)
	{
	}

	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x414EA0", Offset = "0x4140A0", VA = "0x180414EA0")]
	private void CheckEnabled()
	{
	}

	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x415890", Offset = "0x414A90", VA = "0x180415890")]
	private void Update()
	{
	}

	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ScreenFiller()
	{
	}
}
