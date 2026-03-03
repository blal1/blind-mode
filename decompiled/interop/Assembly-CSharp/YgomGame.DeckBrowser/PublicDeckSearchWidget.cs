using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001038")]
public class PublicDeckSearchWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400AD78")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForPublicDeckSearch";

	[Token(Token = "0x400AD79")]
	[FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelTagArea;

	[Token(Token = "0x400AD7A")]
	[FieldOffset(Offset = "0x168")]
	private readonly Transform m_TagArea;

	[Token(Token = "0x400AD7B")]
	[FieldOffset(Offset = "0x170")]
	private readonly InfinityScrollView m_TagScrollView;

	[Token(Token = "0x400AD7C")]
	[FieldOffset(Offset = "0x178")]
	private List<CategoryReference> m_SelectedCategories;

	[Token(Token = "0x400AD7D")]
	[FieldOffset(Offset = "0x180")]
	private List<CategoryReference> m_SelectedTags;

	[Token(Token = "0x400AD7E")]
	[FieldOffset(Offset = "0x188")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x6006248")]
	[Address(RVA = "0xA973D0", Offset = "0xA965D0", VA = "0x180A973D0")]
	public PublicDeckSearchWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6006249")]
	[Address(RVA = "0xA95ED0", Offset = "0xA950D0", VA = "0x180A95ED0")]
	public static void Create(Transform parent, Action<PublicDeckSearchWidget> onCreated)
	{
	}

	[Token(Token = "0x600624A")]
	[Address(RVA = "0xA95FD0", Offset = "0xA951D0", VA = "0x180A95FD0")]
	private void InitializeInfinityScrollView()
	{
	}

	[Token(Token = "0x600624B")]
	[Address(RVA = "0xA779B0", Offset = "0xA76BB0", VA = "0x180A779B0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x600624C")]
	[Address(RVA = "0xA963D0", Offset = "0xA955D0", VA = "0x180A963D0")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x600624D")]
	[Address(RVA = "0xA96450", Offset = "0xA95650", VA = "0x180A96450")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600624E")]
	[Address(RVA = "0xA96A10", Offset = "0xA95C10", VA = "0x180A96A10")]
	public void SetCategories(List<int> categoryIds)
	{
	}

	[Token(Token = "0x600624F")]
	[Address(RVA = "0xA96EF0", Offset = "0xA960F0", VA = "0x180A96EF0")]
	public void SetTags(List<int> tagIds)
	{
	}

	[Token(Token = "0x6006250")]
	[Address(RVA = "0xA96120", Offset = "0xA95320", VA = "0x180A96120")]
	public string LangKey(string lang)
	{
		return null;
	}
}
