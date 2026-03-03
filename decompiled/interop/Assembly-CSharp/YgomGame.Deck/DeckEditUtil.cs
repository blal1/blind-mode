using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.Network;

namespace YgomGame.Deck;

[Token(Token = "0x20010AA")]
public static class DeckEditUtil
{
	[Token(Token = "0x20010AB")]
	public enum SelectorPriority
	{
		[Token(Token = "0x400B13C")]
		DeckEditor,
		[Token(Token = "0x400B13D")]
		ActionMenu,
		[Token(Token = "0x400B13E")]
		CardDetail
	}

	[Token(Token = "0x400B13A")]
	[FieldOffset(Offset = "0x4")]
	private static SortComparer.Sorter deckSorter;

	[Token(Token = "0x170010B1")]
	public static int selectorPriorityBase
	{
		[Token(Token = "0x600673E")]
		[Address(RVA = "0xAC0C10", Offset = "0xABFE10", VA = "0x180AC0C10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600673F")]
		[Address(RVA = "0xAC0C60", Offset = "0xABFE60", VA = "0x180AC0C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6006740")]
	[Address(RVA = "0xAC05D0", Offset = "0xABF7D0", VA = "0x180AC05D0")]
	public static int GetSelectorPriority(int priority)
	{
		return default(int);
	}

	[Token(Token = "0x6006741")]
	[Address(RVA = "0xAC0510", Offset = "0xABF710", VA = "0x180AC0510")]
	public static int GetSelectorPriority(SelectorPriority priority)
	{
		return default(int);
	}

	[Token(Token = "0x6006742")]
	[Address(RVA = "0xAC09C0", Offset = "0xABFBC0", VA = "0x180AC09C0")]
	public static void SortCardDataList(List<CardBaseData> list)
	{
	}

	[Token(Token = "0x6006743")]
	[Address(RVA = "0xAC0AE0", Offset = "0xABFCE0", VA = "0x180AC0AE0")]
	public static void SortCardDataList(List<CardBaseData> list, SortComparer.Sorter sorter)
	{
	}

	[Token(Token = "0x6006744")]
	[Address(RVA = "0xAC0860", Offset = "0xABFA60", VA = "0x180AC0860")]
	public static bool IsDifferentCardList(List<CardBaseData> deckA, List<CardBaseData> deckB)
	{
		return default(bool);
	}

	[Token(Token = "0x6006745")]
	[Address(RVA = "0xAC0660", Offset = "0xABF860", VA = "0x180AC0660")]
	public static bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<DeckCode> onFailed, bool showDialog = true)
	{
		return default(bool);
	}
}
