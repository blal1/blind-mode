using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200061F")]
public class StructureBoxWidget : ElementWidgetBase
{
	[Token(Token = "0x4001D99")]
	[FieldOffset(Offset = "0x20")]
	public readonly Image deckImage;

	[Token(Token = "0x4001D9A")]
	[FieldOffset(Offset = "0x28")]
	public readonly Image deckOpenedImage;

	[Token(Token = "0x4001D9B")]
	[FieldOffset(Offset = "0x30")]
	public readonly RawImage[] cardImages;

	[Token(Token = "0x4001D9C")]
	[FieldOffset(Offset = "0x38")]
	public readonly ExtendedTextMeshProUGUI nameText;

	[Token(Token = "0x4001D9D")]
	[FieldOffset(Offset = "0x40")]
	public readonly SelectionButton button;

	[Token(Token = "0x4001D9E")]
	[FieldOffset(Offset = "0x48")]
	private Image[] _monsterImages;

	[Token(Token = "0x4001DA0")]
	[FieldOffset(Offset = "0x58")]
	public Action<StructureBoxWidget> onClickEvent;

	[Token(Token = "0x4001DA1")]
	[FieldOffset(Offset = "0x60")]
	private bool _useNewDeckImage;

	[Token(Token = "0x4001DA2")]
	[FieldOffset(Offset = "0x61")]
	private bool _useNewOpenedDeckImage;

	[Token(Token = "0x17000509")]
	public int structureId
	{
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600285E")]
	[Address(RVA = "0x6B0160", Offset = "0x6AF360", VA = "0x1806B0160")]
	public StructureBoxWidget(ElementObjectManager eom, Sprite deckSprite, Sprite openedDeckSprite, Sprite[] monsterSprites)
	{
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0x6AFDB0", Offset = "0x6AEFB0", VA = "0x1806AFDB0")]
	public StructureBoxWidget Binding(int structureId)
	{
		return null;
	}
}
