using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001498")]
public class RegulationIconBinder : ResourceBinderBase
{
	[Token(Token = "0x400C701")]
	private const string rarityLabelCommonFormat = "Limit{0}";

	[Token(Token = "0x400C702")]
	private const string rarityLabelNone = "LimitNone";

	[Token(Token = "0x6007FD4")]
	[Address(RVA = "0xC7A5F0", Offset = "0xC797F0", VA = "0x180C7A5F0")]
	public string GetRegulationIconLabel(CardCollectionInfo.Regulation reg, bool showNone = false)
	{
		return null;
	}

	[Token(Token = "0x6007FD5")]
	[Address(RVA = "0xC7A440", Offset = "0xC79640", VA = "0x180C7A440")]
	public BindingSpriteContainer BindRegulationIcon(Image target, CardCollectionInfo.Regulation reg, bool async = true, bool showNone = false)
	{
		return null;
	}

	[Token(Token = "0x6007FD6")]
	[Address(RVA = "0xC7A4B0", Offset = "0xC796B0", VA = "0x180C7A4B0")]
	public BindingSpriteContainer BindRegulationIcon(GameObject target, CardCollectionInfo.Regulation reg, bool async = true, bool showNone = false)
	{
		return null;
	}

	[Token(Token = "0x6007FD7")]
	[Address(RVA = "0xC7A220", Offset = "0xC79420", VA = "0x180C7A220")]
	public void BindCardLimitFromToGroup(GameObject cardLimitIcon, ElementObjectManager cardLimitFromToGroupEom, CardCollectionInfo.Regulation limitRegStatus, bool prevVisible, CardCollectionInfo.Regulation prevLimitRegStatus = CardCollectionInfo.Regulation.None, bool showNone = false)
	{
	}

	[Token(Token = "0x6007FD8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RegulationIconBinder()
	{
	}
}
