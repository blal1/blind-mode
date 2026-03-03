using Il2CppDummyDll;
using UnityEngine;
using YgomGame.CardFile;
using YgomSystem.UI;

namespace YgomGame.Test;

[Token(Token = "0x2001746")]
public class CardFileTest : ViewController
{
	[Token(Token = "0x400DB5C")]
	[FieldOffset(Offset = "0x48")]
	private CardFileController cardFileController;

	[Token(Token = "0x400DB5D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int cardFileID;

	[Token(Token = "0x400DB5E")]
	[FieldOffset(Offset = "0x54")]
	private int step;

	[Token(Token = "0x60091EB")]
	[Address(RVA = "0xDC5500", Offset = "0xDC4700", VA = "0x180DC5500")]
	private void Start()
	{
	}

	[Token(Token = "0x60091EC")]
	[Address(RVA = "0xDC5570", Offset = "0xDC4770", VA = "0x180DC5570")]
	private void Update()
	{
	}

	[Token(Token = "0x60091ED")]
	[Address(RVA = "0xDC4B40", Offset = "0xDC3D40", VA = "0x180DC4B40")]
	private void CreateCardFile()
	{
	}

	[Token(Token = "0x60091EE")]
	[Address(RVA = "0xDC55E0", Offset = "0xDC47E0", VA = "0x180DC55E0")]
	public CardFileTest()
	{
	}
}
