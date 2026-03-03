using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001411")]
public class PublicDeckCaseWidget : ElementWidgetBase
{
	[Token(Token = "0x400C4F9")]
	[FieldOffset(Offset = "0x20")]
	private int m_caseID;

	[Token(Token = "0x400C4FA")]
	[FieldOffset(Offset = "0x24")]
	private int m_pickupCard;

	[Token(Token = "0x400C4FB")]
	[FieldOffset(Offset = "0x28")]
	private Image m_deckImage;

	[Token(Token = "0x400C4FC")]
	[FieldOffset(Offset = "0x30")]
	private RawImage m_cardImage;

	[Token(Token = "0x400C4FD")]
	private const string openTweenLabel = "select";

	[Token(Token = "0x400C4FE")]
	private const string closeTweenLabel = "deselect";

	[Token(Token = "0x400C4FF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string prefabResourcePath;

	[Token(Token = "0x17001315")]
	public int caseID
	{
		[Token(Token = "0x6007CC1")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001316")]
	public int pickupCard
	{
		[Token(Token = "0x6007CC2")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007CBD")]
	[Address(RVA = "0xC65080", Offset = "0xC64280", VA = "0x180C65080")]
	private void setCardImage(int id, bool addProgress)
	{
	}

	[Token(Token = "0x6007CBE")]
	[Address(RVA = "0xC64E30", Offset = "0xC64030", VA = "0x180C64E30")]
	private void setAnimation(bool isOpen, bool immediate = false)
	{
	}

	[Token(Token = "0x6007CBF")]
	[Address(RVA = "0xC64CF0", Offset = "0xC63EF0", VA = "0x180C64CF0")]
	private void playTweenEndOfLabel(GameObject target, string label)
	{
	}

	[Token(Token = "0x6007CC0")]
	[Address(RVA = "0xC65120", Offset = "0xC64320", VA = "0x180C65120")]
	private static void traverseTweenTree(GameObject target, string label, Action<Tween> action, bool recursive)
	{
	}

	[Token(Token = "0x6007CC3")]
	[Address(RVA = "0xC64C20", Offset = "0xC63E20", VA = "0x180C64C20")]
	public PublicDeckCaseWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6007CC4")]
	[Address(RVA = "0xC64950", Offset = "0xC63B50", VA = "0x180C64950")]
	public PublicDeckCaseWidget Binding(int caseId, int pickupCard)
	{
		return null;
	}

	[Token(Token = "0x6007CC5")]
	[Address(RVA = "0xC64A70", Offset = "0xC63C70", VA = "0x180C64A70")]
	public void ChangeCardImage(int id)
	{
	}

	[Token(Token = "0x6007CC6")]
	[Address(RVA = "0xC64AF0", Offset = "0xC63CF0", VA = "0x180C64AF0")]
	public static GameObject LoadPrefabFromResource()
	{
		return null;
	}
}
