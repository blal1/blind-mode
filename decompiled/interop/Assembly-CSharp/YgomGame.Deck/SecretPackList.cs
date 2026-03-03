using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Deck;

[Token(Token = "0x2001120")]
public class SecretPackList : BaseMenuViewController, IBokeSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400B4DD")]
	[FieldOffset(Offset = "0xD0")]
	private List<CardCollectionInfo.SecretPackInfo> packList;

	[Token(Token = "0x400B4DE")]
	[FieldOffset(Offset = "0xD8")]
	private InfinityScrollView infinityScroll;

	[Token(Token = "0x400B4DF")]
	[FieldOffset(Offset = "0xE0")]
	private Action<int, List<int>> decideCallback;

	[Token(Token = "0x400B4E0")]
	public const string argsKeyPackList = "PackList";

	[Token(Token = "0x400B4E1")]
	public const string argsKeyCallback = "DecideCallback";

	[Token(Token = "0x1700111F")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006B60")]
		[Address(RVA = "0xB34FB0", Offset = "0xB341B0", VA = "0x180B34FB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006B61")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006B62")]
	[Address(RVA = "0xB349D0", Offset = "0xB33BD0", VA = "0x180B349D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006B63")]
	[Address(RVA = "0x705530", Offset = "0x704730", VA = "0x180705530")]
	public void OnCreateEntity(GameObject obj)
	{
	}

	[Token(Token = "0x6006B64")]
	[Address(RVA = "0xB346B0", Offset = "0xB338B0", VA = "0x180B346B0")]
	public void OnUpdateEntity(GameObject obj, int idx)
	{
	}

	[Token(Token = "0x6006B65")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public SecretPackList()
	{
	}
}
