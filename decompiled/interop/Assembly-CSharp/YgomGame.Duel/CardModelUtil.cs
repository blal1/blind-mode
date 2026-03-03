using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001982")]
public static class CardModelUtil
{
	[Token(Token = "0x170018FF")]
	public static bool isReady
	{
		[Token(Token = "0x600A3AB")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A3AC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x600A3AD")]
	[Address(RVA = "0xF082F0", Offset = "0xF074F0", VA = "0x180F082F0")]
	public static Sprite GetLoadingSprite(int cardID)
	{
		return null;
	}

	[Token(Token = "0x600A3AE")]
	[Address(RVA = "0xF08390", Offset = "0xF07590", VA = "0x180F08390")]
	public static Texture GetLoadingTexture(int cardID)
	{
		return null;
	}

	[Token(Token = "0x600A3AF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Terminate()
	{
	}
}
