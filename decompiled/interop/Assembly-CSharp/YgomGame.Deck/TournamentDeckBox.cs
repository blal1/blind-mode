using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Menu.Common;

namespace YgomGame.Deck;

[Token(Token = "0x2001126")]
public class TournamentDeckBox : DeckBox
{
	[Token(Token = "0x400B4FC")]
	[FieldOffset(Offset = "0xC8")]
	private Image m_TournamentLogo;

	[Token(Token = "0x400B4FD")]
	[FieldOffset(Offset = "0xD0")]
	private Image m_TournamentBG;

	[Token(Token = "0x6006B82")]
	[Address(RVA = "0xB385F0", Offset = "0xB377F0", VA = "0x180B385F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006B83")]
	[Address(RVA = "0xB387E0", Offset = "0xB379E0", VA = "0x180B387E0")]
	public IAsyncProgressContainer SetData(int id, string name, int case_id, int protector_id, int[] pickup_ids, int[] pickup_decos, int logoId, int logoBgId, int stage = 0, bool opened = false, bool isHideEventLogo = false)
	{
		return null;
	}

	[Token(Token = "0x6006B84")]
	[Address(RVA = "0xB38AF0", Offset = "0xB37CF0", VA = "0x180B38AF0")]
	public TournamentDeckBox()
	{
	}
}
