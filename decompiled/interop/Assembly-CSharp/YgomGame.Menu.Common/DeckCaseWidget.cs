using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001406")]
public class DeckCaseWidget : ElementWidgetBase
{
	[Token(Token = "0x400C4E4")]
	[FieldOffset(Offset = "0x20")]
	private int m_caseID;

	[Token(Token = "0x400C4E5")]
	[FieldOffset(Offset = "0x24")]
	private int m_protectorId;

	[Token(Token = "0x400C4E6")]
	[FieldOffset(Offset = "0x28")]
	private string m_deckName;

	[Token(Token = "0x400C4E7")]
	[FieldOffset(Offset = "0x30")]
	private int[] m_pickupCards;

	[Token(Token = "0x400C4E8")]
	[FieldOffset(Offset = "0x38")]
	private int[] m_pickupDecos;

	[Token(Token = "0x400C4E9")]
	[FieldOffset(Offset = "0x40")]
	private Image m_deckImage;

	[Token(Token = "0x400C4EA")]
	[FieldOffset(Offset = "0x48")]
	private Image m_deckOpenedImage;

	[Token(Token = "0x400C4EB")]
	[FieldOffset(Offset = "0x50")]
	private RawImage[] m_cardImages;

	[Token(Token = "0x400C4EC")]
	[FieldOffset(Offset = "0x58")]
	private ExtendedTextMeshProUGUI m_nameText;

	[Token(Token = "0x400C4ED")]
	private const string openTweenLabel = "select";

	[Token(Token = "0x400C4EE")]
	private const string closeTweenLabel = "deselect";

	[Token(Token = "0x400C4EF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string prefabResourcePath;

	[Token(Token = "0x1700130E")]
	public Image image
	{
		[Token(Token = "0x6007C89")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700130F")]
	public int caseID
	{
		[Token(Token = "0x6007C8E")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001310")]
	public int protectorId
	{
		[Token(Token = "0x6007C8F")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001311")]
	public string deckName
	{
		[Token(Token = "0x6007C90")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001312")]
	public int[] pickupCards
	{
		[Token(Token = "0x6007C91")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001313")]
	public int[] pickupDecos
	{
		[Token(Token = "0x6007C92")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007C8A")]
	[Address(RVA = "0xC62F40", Offset = "0xC62140", VA = "0x180C62F40")]
	private void setCardImage(int index, int id, int decoration, bool addProgress)
	{
	}

	[Token(Token = "0x6007C8B")]
	[Address(RVA = "0xC62DE0", Offset = "0xC61FE0", VA = "0x180C62DE0")]
	private void setAnimation(bool isOpen, bool immediate = false)
	{
	}

	[Token(Token = "0x6007C8C")]
	[Address(RVA = "0xC62CA0", Offset = "0xC61EA0", VA = "0x180C62CA0")]
	private void playTweenEndOfLabel(GameObject target, string label)
	{
	}

	[Token(Token = "0x6007C8D")]
	[Address(RVA = "0xC630C0", Offset = "0xC622C0", VA = "0x180C630C0")]
	private static void traverseTweenTree(GameObject target, string label, Action<Tween> action, bool recursive)
	{
	}

	[Token(Token = "0x6007C93")]
	[Address(RVA = "0xC629B0", Offset = "0xC61BB0", VA = "0x180C629B0")]
	public DeckCaseWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6007C94")]
	[Address(RVA = "0xC61D90", Offset = "0xC60F90", VA = "0x180C61D90")]
	public DeckCaseWidget Binding(int caseId, int protectorId, string deckName, int[] pickupCards_, int[] pickupDecos_, bool opened, bool isLarge = false, bool isDestroyTweens = false)
	{
		return null;
	}

	[Token(Token = "0x6007C95")]
	[Address(RVA = "0xC621A0", Offset = "0xC613A0", VA = "0x180C621A0")]
	public void ChangeCardImage(int index, int id, int decoration)
	{
	}

	[Token(Token = "0x6007C96")]
	[Address(RVA = "0xC62610", Offset = "0xC61810", VA = "0x180C62610")]
	public void ChangeDeckName(string name)
	{
	}

	[Token(Token = "0x6007C97")]
	[Address(RVA = "0xC62540", Offset = "0xC61740", VA = "0x180C62540")]
	public void ChangeDeckCaseImage(int caseId)
	{
	}

	[Token(Token = "0x6007C98")]
	[Address(RVA = "0xC62690", Offset = "0xC61890", VA = "0x180C62690")]
	public void ChangeProtectorImage(int protectorId)
	{
	}

	[Token(Token = "0x6007C99")]
	[Address(RVA = "0xC62230", Offset = "0xC61430", VA = "0x180C62230")]
	public void ChangeCardWithProtectorImage((int mrk, int deco) card1, (int mrk, int deco) card2, (int mrk, int deco) card3, int protectorId)
	{
	}

	[Token(Token = "0x6007C9A")]
	[Address(RVA = "0xC62930", Offset = "0xC61B30", VA = "0x180C62930")]
	public void SetOpen(bool immediate = false)
	{
	}

	[Token(Token = "0x6007C9B")]
	[Address(RVA = "0xC62920", Offset = "0xC61B20", VA = "0x180C62920")]
	public void SetClose(bool immediate = false)
	{
	}

	[Token(Token = "0x6007C9C")]
	[Address(RVA = "0xC62840", Offset = "0xC61A40", VA = "0x180C62840")]
	public static GameObject LoadPrefabFromResource()
	{
		return null;
	}
}
