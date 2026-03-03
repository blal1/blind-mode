using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x2001639")]
public class AutoReleaseCardIllust : MonoBehaviour
{
	[Token(Token = "0x400D55D")]
	[FieldOffset(Offset = "0x20")]
	private int refCardSystemId;

	[Token(Token = "0x400D55E")]
	[FieldOffset(Offset = "0x28")]
	private CardIllustManager cardIllustManager;

	[Token(Token = "0x400D55F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int requestCardId;

	[Token(Token = "0x400D560")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int loadedCardid;

	[Token(Token = "0x400D561")]
	[FieldOffset(Offset = "0x38")]
	private UnityAction<Texture2D> onFinish;

	[Token(Token = "0x6008A40")]
	[Address(RVA = "0xD43F20", Offset = "0xD43120", VA = "0x180D43F20")]
	public AutoReleaseCardIllust()
	{
	}

	[Token(Token = "0x6008A41")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetCardIllustManager(CardIllustManager cardIllustManager)
	{
	}

	[Token(Token = "0x6008A42")]
	[Address(RVA = "0xD43D10", Offset = "0xD42F10", VA = "0x180D43D10")]
	public void SetCard(int cardid, UnityAction<Texture2D> onFinish, bool immediateOnReuse = false)
	{
	}

	[Token(Token = "0x6008A43")]
	[Address(RVA = "0xD43AD0", Offset = "0xD42CD0", VA = "0x180D43AD0")]
	private void LoadCardIllust(bool immediateOnReuse = false)
	{
	}

	[Token(Token = "0x6008A44")]
	[Address(RVA = "0xD43C50", Offset = "0xD42E50", VA = "0x180D43C50")]
	public void ReleaseCardIllust()
	{
	}

	[Token(Token = "0x6008A45")]
	[Address(RVA = "0xD43C40", Offset = "0xD42E40", VA = "0x180D43C40")]
	private void OnDestroy()
	{
	}
}
