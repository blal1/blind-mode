using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardPack.Open.Widget;

[Token(Token = "0x200154F")]
[RequireComponent(typeof(SpriteRenderer))]
public class CardPackFoundKey : MonoBehaviour
{
	[Token(Token = "0x400CC3E")]
	[FieldOffset(Offset = "0x20")]
	private SpriteRenderer m_KeyTemplate;

	[Token(Token = "0x400CC3F")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<SpriteRenderer> m_KeyCaches;

	[Token(Token = "0x400CC40")]
	[FieldOffset(Offset = "0x30")]
	private int m_Idx;

	[Token(Token = "0x400CC41")]
	[FieldOffset(Offset = "0x34")]
	private int m_FoundCnt;

	[Token(Token = "0x400CC42")]
	[FieldOffset(Offset = "0x38")]
	private Action<CardPackFoundKey> m_OnFinishCallback;

	[NonSerialized]
	[Token(Token = "0x400CC43")]
	[FieldOffset(Offset = "0x40")]
	public int sortingOrderBase;

	[Token(Token = "0x17001415")]
	public int foundCnt
	{
		[Token(Token = "0x60083B2")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60083B3")]
	[Address(RVA = "0xCB4090", Offset = "0xCB3290", VA = "0x180CB4090")]
	public void Initialize(int idx, SpriteRenderer keyTemplate)
	{
	}

	[Token(Token = "0x60083B4")]
	[Address(RVA = "0xCB40F0", Offset = "0xCB32F0", VA = "0x180CB40F0")]
	public void SetPlay(int foundCnt, Action<CardPackFoundKey> onFinishCallback)
	{
	}

	[Token(Token = "0x60083B5")]
	[Address(RVA = "0xCB40C0", Offset = "0xCB32C0", VA = "0x180CB40C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60083B6")]
	[Address(RVA = "0xCB4060", Offset = "0xCB3260", VA = "0x180CB4060")]
	public void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x60083B7")]
	[Address(RVA = "0xCB43A0", Offset = "0xCB35A0", VA = "0x180CB43A0")]
	public CardPackFoundKey()
	{
	}
}
