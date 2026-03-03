using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.Open.Widget;

[Token(Token = "0x2001550")]
public class CardPackFoundKeyWidget : ElementWidgetBehaviourBase<CardPackFoundKeyWidget>
{
	[Token(Token = "0x400CC44")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelNumText;

	[Token(Token = "0x400CC45")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelKeyIcon;

	[Token(Token = "0x400CC46")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelKeyIconBase;

	[Token(Token = "0x400CC47")]
	[FieldOffset(Offset = "0x40")]
	private int m_TotalFoundNum;

	[Token(Token = "0x400CC48")]
	[FieldOffset(Offset = "0x48")]
	private PlayableDirector m_Playable;

	[Token(Token = "0x400CC49")]
	[FieldOffset(Offset = "0x50")]
	private PlayableDirector m_KeyIconPlayable;

	[Token(Token = "0x400CC4A")]
	[FieldOffset(Offset = "0x58")]
	private TextMeshPro m_NumText;

	[Token(Token = "0x400CC4B")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_KeyIcon;

	[Token(Token = "0x400CC4C")]
	[FieldOffset(Offset = "0x68")]
	private CardPackFoundKey[] m_FoundKeys;

	[Token(Token = "0x17001416")]
	public bool isPlayingPlayable
	{
		[Token(Token = "0x60083B8")]
		[Address(RVA = "0x49BE90", Offset = "0x49B090", VA = "0x18049BE90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60083B9")]
		[Address(RVA = "0x49C580", Offset = "0x49B780", VA = "0x18049C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60083BA")]
	[Address(RVA = "0xCB3910", Offset = "0xCB2B10", VA = "0x180CB3910")]
	public static CardPackFoundKeyWidget Create(ElementObjectManager eom, IReadOnlyList<GameObject> cardFoundKeys)
	{
		return null;
	}

	[Token(Token = "0x60083BB")]
	[Address(RVA = "0xCB36D0", Offset = "0xCB28D0", VA = "0x180CB36D0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x60083BC")]
	[Address(RVA = "0xCB3CD0", Offset = "0xCB2ED0", VA = "0x180CB3CD0")]
	public void PlayFoundKeys(IReadOnlyList<(int, int)> foundKeys)
	{
	}

	[Token(Token = "0x60083BD")]
	[Address(RVA = "0xCB3BC0", Offset = "0xCB2DC0", VA = "0x180CB3BC0")]
	private void OnObtainSecretKey(CardPackFoundKey obtainKey)
	{
	}

	[Token(Token = "0x60083BE")]
	[Address(RVA = "0xCB3BA0", Offset = "0xCB2DA0", VA = "0x180CB3BA0")]
	private void OnBeginPlayable(PlayableDirector playable)
	{
	}

	[Token(Token = "0x60083BF")]
	[Address(RVA = "0xCB3BB0", Offset = "0xCB2DB0", VA = "0x180CB3BB0")]
	private void OnEndPlayable(PlayableDirector playable)
	{
	}

	[Token(Token = "0x60083C0")]
	[Address(RVA = "0xCB3580", Offset = "0xCB2780", VA = "0x180CB3580")]
	public void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x60083C1")]
	[Address(RVA = "0xCB3EB0", Offset = "0xCB30B0", VA = "0x180CB3EB0")]
	public void SetImmediate(int totalFoundNum)
	{
	}

	[Token(Token = "0x60083C2")]
	[Address(RVA = "0xCB3FB0", Offset = "0xCB31B0", VA = "0x180CB3FB0")]
	public CardPackFoundKeyWidget()
	{
	}
}
