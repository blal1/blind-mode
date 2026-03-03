using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Lottery;

[Token(Token = "0x2001737")]
public class SelectedCardsWidget : MonoBehaviour
{
	[Token(Token = "0x400DB0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string k_SelectedArea;

	[Token(Token = "0x400DB0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string k_WinningArea;

	[Token(Token = "0x400DB10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_CardButton;

	[Token(Token = "0x400DB11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string k_Sheet;

	[Token(Token = "0x400DB12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly string k_WinningRank;

	[Token(Token = "0x400DB13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public SelectionButton upperButton;

	[Token(Token = "0x400DB14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int m_WidgetNum;

	[Token(Token = "0x400DB15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private int m_CardNum;

	[Token(Token = "0x400DB16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private int m_SheetNum;

	[Token(Token = "0x400DB17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<(SheetViewer, ElementObjectManager)> m_Widgets;

	[Token(Token = "0x400DB18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private SelectionButton m_DefaultButton;

	[Token(Token = "0x17001658")]
	public SelectionButton defaultButton
	{
		[Token(Token = "0x600919F")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60091A0")]
	[Address(RVA = "0xDB4F40", Offset = "0xDB4140", VA = "0x180DB4F40")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60091A1")]
	[Address(RVA = "0xDB60C0", Offset = "0xDB52C0", VA = "0x180DB60C0")]
	public void SetSheets(int[] sheetInfo)
	{
	}

	[Token(Token = "0x60091A2")]
	[Address(RVA = "0xDB5360", Offset = "0xDB4560", VA = "0x180DB5360")]
	public void SetCards(int id, List<int[]> cards, int winning = -1, [Optional] LotteryUtil.WinningInfo info, [Optional] List<int> allCards, [Optional] List<int> numbers)
	{
	}

	[Token(Token = "0x60091A3")]
	[Address(RVA = "0xDB51B0", Offset = "0xDB43B0", VA = "0x180DB51B0")]
	private void SetCardButtonAction(SelectionButton button, int widgetCount, int cardCount, List<int> allCards, List<int> numbers, int mrk)
	{
	}

	[Token(Token = "0x60091A4")]
	[Address(RVA = "0xDB63D0", Offset = "0xDB55D0", VA = "0x180DB63D0")]
	public SelectedCardsWidget()
	{
	}
}
