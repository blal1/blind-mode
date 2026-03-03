using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Credit;

[Token(Token = "0x200112D")]
public class CreditBGTimeline
{
	[Token(Token = "0x400B53C")]
	[FieldOffset(Offset = "0x10")]
	private readonly string k_timelinePath;

	[Token(Token = "0x400B53D")]
	[FieldOffset(Offset = "0x18")]
	private ElementObjectManager m_effEom;

	[Token(Token = "0x400B53E")]
	[FieldOffset(Offset = "0x20")]
	private List<UnityAction<Texture2D>> m_onFinishList;

	[Token(Token = "0x400B53F")]
	[FieldOffset(Offset = "0x28")]
	private PlayableDirector m_playableDirector;

	[Token(Token = "0x400B540")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_favoriteIds;

	[Token(Token = "0x6006BB7")]
	[Address(RVA = "0xB27960", Offset = "0xB26B60", VA = "0x180B27960")]
	public CreditBGTimeline()
	{
	}

	[Token(Token = "0x6006BB8")]
	[Address(RVA = "0xB271E0", Offset = "0xB263E0", VA = "0x180B271E0")]
	public void SetTimeline()
	{
	}

	[Token(Token = "0x6006BB9")]
	[Address(RVA = "0xB27290", Offset = "0xB26490", VA = "0x180B27290")]
	private void StartTimeline(bool result)
	{
	}

	[Token(Token = "0x6006BBA")]
	[Address(RVA = "0xB27940", Offset = "0xB26B40", VA = "0x180B27940")]
	public void StopTimeline()
	{
	}
}
