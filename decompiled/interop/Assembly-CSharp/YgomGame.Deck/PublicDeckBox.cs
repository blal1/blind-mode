using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001100")]
public class PublicDeckBox : MonoBehaviour
{
	[Token(Token = "0x400B3B7")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_eom;

	[Token(Token = "0x400B3B8")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_body;

	[Token(Token = "0x400B3B9")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_CardImage;

	[Token(Token = "0x400B3BA")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_DeckImage;

	[Token(Token = "0x400B3BB")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton m_button;

	[Token(Token = "0x400B3BC")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_publicDeckCaseObj;

	[Token(Token = "0x400B3BD")]
	[FieldOffset(Offset = "0x50")]
	private UnityAction m_OnClickAction;

	[Token(Token = "0x400B3BE")]
	[FieldOffset(Offset = "0x58")]
	private int m_deckID;

	[Token(Token = "0x400B3BF")]
	[FieldOffset(Offset = "0x60")]
	private PublicDeckCaseWidget m_publicDeckCaseWidget;

	[Token(Token = "0x17001116")]
	public int DeckID
	{
		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001117")]
	public PublicDeckCaseWidget publicDeckCaseWidget
	{
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001118")]
	public DeckSelectViewController2.DeckCondition m_Condition
	{
		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
		[CompilerGenerated]
		get
		{
			return default(DeckSelectViewController2.DeckCondition);
		}
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0xB2E810", Offset = "0xB2DA10", VA = "0x180B2E810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6006ADE")]
	[Address(RVA = "0xB2E3D0", Offset = "0xB2D5D0", VA = "0x180B2E3D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006ADF")]
	[Address(RVA = "0xB2E630", Offset = "0xB2D830", VA = "0x180B2E630")]
	public IAsyncProgressContainer SetParams(int id, int pickup_id, int caseId)
	{
		return null;
	}

	[Token(Token = "0x6006AE0")]
	[Address(RVA = "0xB2E520", Offset = "0xB2D720", VA = "0x180B2E520")]
	private IAsyncProgressContainer SetData(int id, int pickup_id, int caseId)
	{
		return null;
	}

	[Token(Token = "0x6006AE1")]
	[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AE2")]
	[Address(RVA = "0xB2E740", Offset = "0xB2D940", VA = "0x180B2E740")]
	private void Start()
	{
	}

	[Token(Token = "0x6006AE3")]
	[Address(RVA = "0xB2E800", Offset = "0xB2DA00", VA = "0x180B2E800")]
	public PublicDeckBox()
	{
	}
}
