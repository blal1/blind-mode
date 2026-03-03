using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x200184A")]
public class CardExpand : MonoBehaviour
{
	[Token(Token = "0x400E389")]
	private const string prefPath = "Prefabs/Duel/UI/CardExpand";

	[Token(Token = "0x400E38A")]
	[FieldOffset(Offset = "0x20")]
	private int cardID;

	[Token(Token = "0x400E38B")]
	[FieldOffset(Offset = "0x24")]
	private int premID;

	[Token(Token = "0x400E38C")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400E38D")]
	[FieldOffset(Offset = "0x30")]
	private RawImage m_CardImage;

	[Token(Token = "0x400E38E")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton m_CardImageButton;

	[Token(Token = "0x400E38F")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton m_BaseButton;

	[Token(Token = "0x400E390")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI m_ShortcutText;

	[Token(Token = "0x400E391")]
	[FieldOffset(Offset = "0x50")]
	private bool isZoom;

	[Token(Token = "0x400E392")]
	[FieldOffset(Offset = "0x58")]
	private Tween[] m_Tweens;

	[Token(Token = "0x400E393")]
	[FieldOffset(Offset = "0x60")]
	private Tween[] m_BaseTweens;

	[Token(Token = "0x400E394")]
	private const float initialScale = 1f;

	[Token(Token = "0x400E395")]
	[FieldOffset(Offset = "0x68")]
	private Selector m_Selector;

	[Token(Token = "0x400E396")]
	public const string SE_CARDEXPAND_DISPLAY = "SE_CARDEXPAND_DISPLAY";

	[Token(Token = "0x400E397")]
	public const string SE_CARDEXPAND_CLOSE = "SE_CARDEXPAND_CLOSE";

	[Token(Token = "0x400E398")]
	public const string SE_CARDEXPAND_ZOOMIN = "SE_CARDEXPAND_ZOOMIN";

	[Token(Token = "0x400E399")]
	public const string SE_CARDEXPAND_ZOOMOUT = "SE_CARDEXPAND_ZOOMOUT";

	[Token(Token = "0x6009A95")]
	[Address(RVA = "0xE559F0", Offset = "0xE54BF0", VA = "0x180E559F0")]
	public static void Create(Transform parent, Action<CardExpand> finishedCallback)
	{
	}

	[Token(Token = "0x6009A96")]
	[Address(RVA = "0xE55AE0", Offset = "0xE54CE0", VA = "0x180E55AE0")]
	public static void Create(Transform parent, Selector parentSelector, Action<CardExpand> finishedCallback)
	{
	}

	[Token(Token = "0x6009A97")]
	[Address(RVA = "0xE55CF0", Offset = "0xE54EF0", VA = "0x180E55CF0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6009A98")]
	[Address(RVA = "0xE56430", Offset = "0xE55630", VA = "0x180E56430")]
	public void SetCardImage(int id, int prem)
	{
	}

	[Token(Token = "0x6009A99")]
	[Address(RVA = "0xE55730", Offset = "0xE54930", VA = "0x180E55730")]
	public void Close(bool forceClose = false)
	{
	}

	[Token(Token = "0x6009A9A")]
	[Address(RVA = "0xE56160", Offset = "0xE55360", VA = "0x180E56160")]
	private void PlayTween()
	{
	}

	[Token(Token = "0x6009A9B")]
	[Address(RVA = "0xE566F0", Offset = "0xE558F0", VA = "0x180E566F0")]
	private void Show()
	{
	}

	[Token(Token = "0x6009A9C")]
	[Address(RVA = "0xE55BE0", Offset = "0xE54DE0", VA = "0x180E55BE0")]
	private void Hide()
	{
	}

	[Token(Token = "0x6009A9D")]
	[Address(RVA = "0xE566B0", Offset = "0xE558B0", VA = "0x180E566B0")]
	public void SetSelectorPriority(Selector parentSelector)
	{
	}

	[Token(Token = "0x6009A9E")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardExpand()
	{
	}
}
