using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem;

namespace YgomGame.Card;

[Token(Token = "0x2001625")]
public class CardPictureTop : MonoBehaviour
{
	[Token(Token = "0x400D4E5")]
	private const int MAXLEVEL = 12;

	[Token(Token = "0x400D4E6")]
	private const string prefabPath = "Prefabs/Duel/CardPictureTop";

	[Token(Token = "0x400D4E7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RubyRoot rubyRoot;

	[Token(Token = "0x400D4E8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject LevelRoot;

	[Token(Token = "0x400D4E9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite[] LevelSprites;

	[Token(Token = "0x400D4EA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image[] LevelIcons;

	[Token(Token = "0x400D4EB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int nameFontSize;

	[Token(Token = "0x400D4EC")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int levelIconWidth;

	[Token(Token = "0x400D4ED")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Color monsterNameColor;

	[Token(Token = "0x400D4EE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color spellTrapNameColor;

	[Token(Token = "0x60089BC")]
	[Address(RVA = "0xD4E0A0", Offset = "0xD4D2A0", VA = "0x180D4E0A0")]
	public static CardPictureTop Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60089BD")]
	[Address(RVA = "0xD4E380", Offset = "0xD4D580", VA = "0x180D4E380")]
	public void SetCardTopArea(int cardid, bool maskmode)
	{
	}

	[Token(Token = "0x60089BE")]
	[Address(RVA = "0xD4E1A0", Offset = "0xD4D3A0", VA = "0x180D4E1A0")]
	private void SetCardName(int cardid, bool maskmode)
	{
	}

	[Token(Token = "0x60089BF")]
	[Address(RVA = "0xD4E8A0", Offset = "0xD4DAA0", VA = "0x180D4E8A0")]
	private void SetLevelRank(int cardid, bool maskmode)
	{
	}

	[Token(Token = "0x60089C0")]
	[Address(RVA = "0xD4E6B0", Offset = "0xD4D8B0", VA = "0x180D4E6B0")]
	private void SetLevelIcon(int level, bool maskmode)
	{
	}

	[Token(Token = "0x60089C1")]
	[Address(RVA = "0xD4EA30", Offset = "0xD4DC30", VA = "0x180D4EA30")]
	private void SetRankIcon(int rank, bool maskmode)
	{
	}

	[Token(Token = "0x60089C2")]
	[Address(RVA = "0xD4EC30", Offset = "0xD4DE30", VA = "0x180D4EC30")]
	public CardPictureTop()
	{
	}
}
