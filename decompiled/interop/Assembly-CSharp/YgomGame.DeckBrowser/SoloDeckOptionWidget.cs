using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x200103A")]
public class SoloDeckOptionWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400AD81")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForSoloDeck";

	[Token(Token = "0x400AD82")]
	[FieldOffset(Offset = "0x160")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x6006253")]
	[Address(RVA = "0xA97820", Offset = "0xA96A20", VA = "0x180A97820")]
	public SoloDeckOptionWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6006254")]
	[Address(RVA = "0xA97720", Offset = "0xA96920", VA = "0x180A97720")]
	public static void Create(Transform parent, Action<SoloDeckOptionWidget> onCreated)
	{
	}
}
