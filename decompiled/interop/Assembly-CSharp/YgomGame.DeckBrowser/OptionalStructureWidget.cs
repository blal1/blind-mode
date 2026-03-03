using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x200102E")]
public class OptionalStructureWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400AD39")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForStructureDeck";

	[Token(Token = "0x400AD3A")]
	[FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelDeckCaseIcon;

	[Token(Token = "0x400AD3B")]
	[FieldOffset(Offset = "0x168")]
	private readonly Image m_DeckCaseIcon;

	[Token(Token = "0x400AD3C")]
	[FieldOffset(Offset = "0x170")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x400AD3D")]
	[FieldOffset(Offset = "0x178")]
	private int m_structureId;

	[Token(Token = "0x400AD3E")]
	[FieldOffset(Offset = "0x180")]
	protected string k_ELabelGetFirstStructureButton;

	[Token(Token = "0x400AD3F")]
	[FieldOffset(Offset = "0x188")]
	protected SelectionButton m_GetFirstStructureButton;

	[Token(Token = "0x400AD40")]
	[FieldOffset(Offset = "0x190")]
	public Action onGetFirstStructureCallback;

	[Token(Token = "0x17000F58")]
	public bool getFirstStructureButtonEnable
	{
		[Token(Token = "0x600620A")]
		[Address(RVA = "0xA92AA0", Offset = "0xA91CA0", VA = "0x180A92AA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600620B")]
		[Address(RVA = "0xA92AD0", Offset = "0xA91CD0", VA = "0x180A92AD0")]
		set
		{
		}
	}

	[Token(Token = "0x600620C")]
	[Address(RVA = "0xA92850", Offset = "0xA91A50", VA = "0x180A92850")]
	public OptionalStructureWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600620D")]
	[Address(RVA = "0xA92600", Offset = "0xA91800", VA = "0x180A92600")]
	public static void Create(int structureId, Transform parent, Action<OptionalStructureWidget> onCreated)
	{
	}

	[Token(Token = "0x600620E")]
	[Address(RVA = "0xA92710", Offset = "0xA91910", VA = "0x180A92710")]
	private void SetStructureId(int structureId)
	{
	}
}
