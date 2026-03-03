using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Card;

[Token(Token = "0x200161D")]
public class CardPictureCreator : CardTextureCreatorBase
{
	[Token(Token = "0x400D4CD")]
	private const int MAXRETRYCOUNT = 10;

	[Token(Token = "0x400D4CE")]
	[FieldOffset(Offset = "0x70")]
	private CardIllustManager m_CardIllustManager;

	[Token(Token = "0x400D4CF")]
	[FieldOffset(Offset = "0x78")]
	protected CardPicture m_CardPictureBase;

	[Token(Token = "0x400D4D0")]
	[FieldOffset(Offset = "0x80")]
	protected Dictionary<int, Texture2D> m_TaskQueue_WaitStandby;

	[Token(Token = "0x400D4D1")]
	[FieldOffset(Offset = "0x88")]
	protected Dictionary<int, int> m_RetryCountTable;

	[Token(Token = "0x400D4D2")]
	[FieldOffset(Offset = "0x90")]
	protected bool m_NoneCallBackStandbyFlag;

	[Token(Token = "0x400D4D3")]
	[FieldOffset(Offset = "0x91")]
	public bool m_IgnoreIllsut;

	[Token(Token = "0x6008998")]
	[Address(RVA = "0xD4C460", Offset = "0xD4B660", VA = "0x180D4C460")]
	public static CardPictureCreator CreateCardPictureCreator(CardIllustManager cardIllustManager)
	{
		return null;
	}

	[Token(Token = "0x6008999")]
	[Address(RVA = "0xD4C560", Offset = "0xD4B760", VA = "0x180D4C560", Slot = "8")]
	protected override bool CreateTaskImpl(TaskDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x600899A")]
	[Address(RVA = "0xD4C770", Offset = "0xD4B970", VA = "0x180D4C770", Slot = "5")]
	protected override void InitComponent()
	{
	}

	[Token(Token = "0x600899B")]
	[Address(RVA = "0xD4CD20", Offset = "0xD4BF20", VA = "0x180D4CD20", Slot = "6")]
	protected override void SetCanvas()
	{
	}

	[Token(Token = "0x600899C")]
	[Address(RVA = "0xD4CB50", Offset = "0xD4BD50", VA = "0x180D4CB50", Slot = "7")]
	protected override void SetCPRenderTexture()
	{
	}

	[Token(Token = "0x600899D")]
	[Address(RVA = "0xD4CFA0", Offset = "0xD4C1A0", VA = "0x180D4CFA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600899E")]
	[Address(RVA = "0xD4C2C0", Offset = "0xD4B4C0", VA = "0x180D4C2C0", Slot = "4")]
	public override void CancelCardPictureTask(int cardid)
	{
	}

	[Token(Token = "0x600899F")]
	[Address(RVA = "0xD4CE80", Offset = "0xD4C080", VA = "0x180D4CE80")]
	private void SetupCardAsyncCallback(TaskDesc desc)
	{
	}

	[Token(Token = "0x60089A0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardPictureCreator()
	{
	}
}
