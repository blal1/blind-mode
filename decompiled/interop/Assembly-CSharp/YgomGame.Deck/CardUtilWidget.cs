using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x200109C")]
public abstract class CardUtilWidget : CardParameterWidget
{
	[Token(Token = "0x400B0BC")]
	[FieldOffset(Offset = "0xC8")]
	protected Material m_TextBGMaterial;

	[Token(Token = "0x400B0BD")]
	[FieldOffset(Offset = "0xD0")]
	protected UnityAction m_OnClickCraftCreate;

	[Token(Token = "0x400B0BE")]
	[FieldOffset(Offset = "0xD8")]
	protected UnityAction m_OnClickCraftDismantle;

	[Token(Token = "0x400B0BF")]
	[FieldOffset(Offset = "0xE0")]
	protected UnityAction m_OnClickRelatedCards;

	[Token(Token = "0x400B0C0")]
	[FieldOffset(Offset = "0xE8")]
	protected UnityAction m_OnClickButtonAddCard;

	[Token(Token = "0x400B0C1")]
	[FieldOffset(Offset = "0xF0")]
	protected UnityAction m_OnClickButtonRemoveCard;

	[Token(Token = "0x400B0C2")]
	[FieldOffset(Offset = "0xF8")]
	protected UnityAction m_OnClickBackButton;

	[Token(Token = "0x400B0C3")]
	[FieldOffset(Offset = "0x100")]
	protected UnityAction m_OnClickButtonBookmark;

	[Token(Token = "0x400B0C4")]
	[FieldOffset(Offset = "0x108")]
	protected UnityAction m_OnClickLootSource;

	[Token(Token = "0x17001084")]
	protected abstract Image m_AtkIcon
	{
		[Token(Token = "0x60066B8")]
		get;
	}

	[Token(Token = "0x17001085")]
	protected abstract ExtendedTextMeshProUGUI m_AtkText
	{
		[Token(Token = "0x60066B9")]
		get;
	}

	[Token(Token = "0x17001086")]
	protected abstract Image m_DefIcon
	{
		[Token(Token = "0x60066BA")]
		get;
	}

	[Token(Token = "0x17001087")]
	protected abstract ExtendedTextMeshProUGUI m_DefText
	{
		[Token(Token = "0x60066BB")]
		get;
	}

	[Token(Token = "0x17001088")]
	protected abstract RectTransform m_SpellTrapType
	{
		[Token(Token = "0x60066BC")]
		get;
	}

	[Token(Token = "0x17001089")]
	protected abstract ExtendedTextMeshProUGUI m_SpellTrapTypeText
	{
		[Token(Token = "0x60066BD")]
		get;
	}

	[Token(Token = "0x1700108A")]
	protected abstract ExtendedScrollRect m_TextArea
	{
		[Token(Token = "0x60066BE")]
		get;
	}

	[Token(Token = "0x1700108B")]
	protected abstract ExtendedTextMeshProUGUI m_CardDesc
	{
		[Token(Token = "0x60066BF")]
		get;
	}

	[Token(Token = "0x1700108C")]
	protected abstract ExtendedTextMeshProUGUI m_CardDescHeading
	{
		[Token(Token = "0x60066C0")]
		get;
	}

	[Token(Token = "0x1700108D")]
	protected abstract Image m_NameAreaBG
	{
		[Token(Token = "0x60066C1")]
		get;
	}

	[Token(Token = "0x1700108E")]
	protected abstract Image m_DescAreaBG
	{
		[Token(Token = "0x60066C2")]
		get;
	}

	[Token(Token = "0x1700108F")]
	protected abstract RubyTextGX m_CardName
	{
		[Token(Token = "0x60066C3")]
		get;
	}

	[Token(Token = "0x17001090")]
	protected abstract SelectionButton m_CreateButton
	{
		[Token(Token = "0x60066CC")]
		get;
	}

	[Token(Token = "0x17001091")]
	protected abstract SelectionButton m_DismantleButton
	{
		[Token(Token = "0x60066CD")]
		get;
	}

	[Token(Token = "0x17001092")]
	protected abstract SelectionButton m_AddCardButton
	{
		[Token(Token = "0x60066CE")]
		get;
	}

	[Token(Token = "0x17001093")]
	protected abstract SelectionButton m_RemoveCardButton
	{
		[Token(Token = "0x60066CF")]
		get;
	}

	[Token(Token = "0x17001094")]
	protected abstract SelectionButton m_BookmarkButton
	{
		[Token(Token = "0x60066D0")]
		get;
	}

	[Token(Token = "0x17001095")]
	protected abstract SelectionButton m_HowToGetButton
	{
		[Token(Token = "0x60066D1")]
		get;
	}

	[Token(Token = "0x17001096")]
	protected abstract SelectionButton m_RelatedCardButton
	{
		[Token(Token = "0x60066D2")]
		get;
	}

	[Token(Token = "0x60066C4")]
	[Address(RVA = "0xABB970", Offset = "0xABAB70", VA = "0x180ABB970")]
	protected void setCardName()
	{
	}

	[Token(Token = "0x60066C5")]
	[Address(RVA = "0xABB7B0", Offset = "0xABA9B0", VA = "0x180ABB7B0")]
	protected void setAttack()
	{
	}

	[Token(Token = "0x60066C6")]
	[Address(RVA = "0xABBC90", Offset = "0xABAE90", VA = "0x180ABBC90")]
	protected void setDefence()
	{
	}

	[Token(Token = "0x60066C7")]
	[Address(RVA = "0xABBE30", Offset = "0xABB030", VA = "0x180ABBE30")]
	protected void setDescriptionHeading()
	{
	}

	[Token(Token = "0x60066C8")]
	[Address(RVA = "0xABBA90", Offset = "0xABAC90", VA = "0x180ABBA90")]
	private void setCardText()
	{
	}

	[Token(Token = "0x60066C9")]
	[Address(RVA = "0xABB920", Offset = "0xABAB20", VA = "0x180ABB920")]
	protected void setCardNameBG()
	{
	}

	[Token(Token = "0x60066CA")]
	[Address(RVA = "0xABB920", Offset = "0xABAB20", VA = "0x180ABB920")]
	protected void setDescAreaBG()
	{
	}

	[Token(Token = "0x60066CB")]
	[Address(RVA = "0xABBFD0", Offset = "0xABB1D0", VA = "0x180ABBFD0")]
	protected void setSpellTrapType()
	{
	}

	[Token(Token = "0x60066D3")]
	[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
	public void SetOnClickAddToMainButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60066D4")]
	[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
	public void SetOnClickRemoveFromMainButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60066D5")]
	[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
	public void SetOnClickBookmarkButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60066D6")]
	[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
	public void SetOnClickCraftCreateButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60066D7")]
	[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
	public void SetOnClickCraftDismantleButtonCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60066D8")]
	[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
	public void SetOnClickRelatedCardsButton(UnityAction callback)
	{
	}

	[Token(Token = "0x60066D9")]
	[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
	public void SetOnClickLootSourceButton(UnityAction callback)
	{
	}

	[Token(Token = "0x60066DA")]
	[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
	public void SetOnClickBackButton(UnityAction callback)
	{
	}

	[Token(Token = "0x60066DB")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	protected CardUtilWidget()
	{
	}
}
