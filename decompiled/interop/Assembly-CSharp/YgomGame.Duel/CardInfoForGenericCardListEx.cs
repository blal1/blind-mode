using Il2CppDummyDll;
using UnityEngine.Events;

namespace YgomGame.Duel;

[Token(Token = "0x2001863")]
public class CardInfoForGenericCardListEx : CardInfoBase
{
	[Token(Token = "0x400E4D2")]
	[FieldOffset(Offset = "0x340")]
	private bool m_IsMobileLayout;

	[Token(Token = "0x6009BCB")]
	[Address(RVA = "0xE8A9D0", Offset = "0xE89BD0", VA = "0x180E8A9D0")]
	public void Show()
	{
	}

	[Token(Token = "0x6009BCC")]
	[Address(RVA = "0xE899F0", Offset = "0xE88BF0", VA = "0x180E899F0")]
	public void Initialize(bool ismobile, bool onCreated = true)
	{
	}

	[Token(Token = "0x6009BCD")]
	[Address(RVA = "0xE89B90", Offset = "0xE88D90", VA = "0x180E89B90")]
	public void Initialize(UnityAction<int> onClick, bool ismobile, bool onCreated = true)
	{
	}

	[Token(Token = "0x6009BCE")]
	[Address(RVA = "0xE898B0", Offset = "0xE88AB0", VA = "0x180E898B0")]
	public void Initialize(UnityAction<int, int> onClick, bool ismobile, bool onCreated = true)
	{
	}

	[Token(Token = "0x6009BCF")]
	[Address(RVA = "0xE8A050", Offset = "0xE89250", VA = "0x180E8A050")]
	public void SetCardByCardId(int cardid)
	{
	}

	[Token(Token = "0x6009BD0")]
	[Address(RVA = "0xE89EC0", Offset = "0xE890C0", VA = "0x180E89EC0")]
	public void SetCardByCardId(int cardid, int premID)
	{
	}

	[Token(Token = "0x6009BD1")]
	[Address(RVA = "0xE89CD0", Offset = "0xE88ED0", VA = "0x180E89CD0")]
	protected void ResetNameScroll()
	{
	}

	[Token(Token = "0x6009BD2")]
	[Address(RVA = "0xE8A8A0", Offset = "0xE89AA0", VA = "0x180E8A8A0")]
	protected void SetTitleAreaByBasicVal(int cardIdOrg, ref Engine.BasicVal basicalval)
	{
	}

	[Token(Token = "0x6009BD3")]
	[Address(RVA = "0xE8A930", Offset = "0xE89B30", VA = "0x180E8A930")]
	protected void SetTitleAreaByCardId(int cardid)
	{
	}

	[Token(Token = "0x6009BD4")]
	[Address(RVA = "0xE89D70", Offset = "0xE88F70", VA = "0x180E89D70")]
	protected void SetCardArea()
	{
	}

	[Token(Token = "0x6009BD5")]
	[Address(RVA = "0xE8A640", Offset = "0xE89840", VA = "0x180E8A640")]
	protected void SetParameterArea()
	{
	}

	[Token(Token = "0x6009BD6")]
	[Address(RVA = "0xE8A1D0", Offset = "0xE893D0", VA = "0x180E8A1D0")]
	protected void SetDescriptionArea()
	{
	}

	[Token(Token = "0x6009BD7")]
	[Address(RVA = "0xE8A350", Offset = "0xE89550", VA = "0x180E8A350")]
	protected void SetDspContent(int cardidorg, int effectid, bool isInField = false, bool isPdlCard = false, int effflag = 0)
	{
	}

	[Token(Token = "0x6009BD8")]
	[Address(RVA = "0xE85260", Offset = "0xE84460", VA = "0x180E85260")]
	public CardInfoForGenericCardListEx()
	{
	}
}
