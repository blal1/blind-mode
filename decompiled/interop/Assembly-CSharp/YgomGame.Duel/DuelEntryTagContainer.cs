using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001795")]
public class DuelEntryTagContainer
{
	[Token(Token = "0x400DD57")]
	private const string LABEL_OBJ_DUELENTRYPVP_TAG_CONTAINER = "Duel/Timeline/Duel/Universal/DuelEntry/DuelEntryTagContainer";

	[Token(Token = "0x400DD58")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_TagList00;

	[Token(Token = "0x400DD59")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_TagList01;

	[Token(Token = "0x400DD5A")]
	[FieldOffset(Offset = "0x20")]
	public (bool, bool) IsDispTime;

	[Token(Token = "0x6009475")]
	[Address(RVA = "0xDE0CB0", Offset = "0xDDFEB0", VA = "0x180DE0CB0")]
	public static DuelEntryTagContainer CreateTagContainer()
	{
		return null;
	}

	[Token(Token = "0x6009476")]
	[Address(RVA = "0xDE21D0", Offset = "0xDE13D0", VA = "0x180DE21D0")]
	private void Initialize(AssetContainer assetContainer, Dictionary<string, object> duelDic)
	{
	}

	[Token(Token = "0x6009477")]
	[Address(RVA = "0xDE2540", Offset = "0xDE1740", VA = "0x180DE2540")]
	private void TagInitialize(GameObject tagListObj, int myId)
	{
	}

	[Token(Token = "0x6009478")]
	[Address(RVA = "0xDE0E40", Offset = "0xDE0040", VA = "0x180DE0E40")]
	public void FadeInTag()
	{
	}

	[Token(Token = "0x6009479")]
	[Address(RVA = "0xDE15A0", Offset = "0xDE07A0", VA = "0x180DE15A0")]
	public void FadeOutTag()
	{
	}

	[Token(Token = "0x600947A")]
	[Address(RVA = "0xDE1E80", Offset = "0xDE1080", VA = "0x180DE1E80")]
	private List<TextMeshPro> GetTweenAlphaTMPList(GameObject list, bool isDisp = true)
	{
		return null;
	}

	[Token(Token = "0x600947B")]
	[Address(RVA = "0xDE2B00", Offset = "0xDE1D00", VA = "0x180DE2B00")]
	public void TagSetLocator(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600947C")]
	[Address(RVA = "0xDE2450", Offset = "0xDE1650", VA = "0x180DE2450")]
	public void Release()
	{
	}

	[Token(Token = "0x600947D")]
	[Address(RVA = "0xDE2C50", Offset = "0xDE1E50", VA = "0x180DE2C50")]
	public DuelEntryTagContainer()
	{
	}
}
