using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A02")]
public class DeckPlaceStatus
{
	[Token(Token = "0x400EFFF")]
	[FieldOffset(Offset = "0x10")]
	private PlaceStatusLabel statusLabel;

	[Token(Token = "0x400F000")]
	[FieldOffset(Offset = "0x18")]
	private DeckCardPlace deckPlace;

	[Token(Token = "0x400F001")]
	private const int lowDeckNum = 10;

	[Token(Token = "0x400F002")]
	private const int veryLowDeckNum = 5;

	[Token(Token = "0x400F003")]
	[FieldOffset(Offset = "0x20")]
	private int prevNum;

	[Token(Token = "0x170019E0")]
	public bool isTerminated
	{
		[Token(Token = "0x600A7F8")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A7F6")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public DeckPlaceStatus(DeckCardPlace deckPlace)
	{
	}

	[Token(Token = "0x600A7F7")]
	[Address(RVA = "0xF3D5B0", Offset = "0xF3C7B0", VA = "0x180F3D5B0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A7F9")]
	[Address(RVA = "0xF3D790", Offset = "0xF3C990", VA = "0x180F3D790")]
	public void Update()
	{
	}

	[Token(Token = "0x600A7FA")]
	[Address(RVA = "0xF3D670", Offset = "0xF3C870", VA = "0x180F3D670")]
	public void UpdateStatusPos()
	{
	}

	[Token(Token = "0x600A7FB")]
	[Address(RVA = "0xF3D2D0", Offset = "0xF3C4D0", VA = "0x180F3D2D0")]
	public void Show(bool immediate)
	{
	}

	[Token(Token = "0x600A7FC")]
	[Address(RVA = "0xF3D1C0", Offset = "0xF3C3C0", VA = "0x180F3D1C0")]
	public void Hide(bool immediate)
	{
	}

	[Token(Token = "0x600A7FD")]
	[Address(RVA = "0xF3D490", Offset = "0xF3C690", VA = "0x180F3D490")]
	public void ShuffleShow()
	{
	}

	[Token(Token = "0x600A7FE")]
	[Address(RVA = "0xF3D410", Offset = "0xF3C610", VA = "0x180F3D410")]
	public void ShuffleHide()
	{
	}

	[Token(Token = "0x600A7FF")]
	[Address(RVA = "0xF3DBB0", Offset = "0xF3CDB0", VA = "0x180F3DBB0")]
	private Vector2 World2ScreenPos(Vector3 pos)
	{
		return default(Vector2);
	}
}
