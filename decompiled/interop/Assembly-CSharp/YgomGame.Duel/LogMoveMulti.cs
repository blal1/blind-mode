using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018FB")]
public class LogMoveMulti : LogItemBase
{
	[Token(Token = "0x400E99A")]
	private const int FULLWIDTH = 320;

	[Token(Token = "0x400E99B")]
	private const int FULLWIDTH_WIDTH = 670;

	[Token(Token = "0x400E99C")]
	private const int INDENTWIDTH = 280;

	[Token(Token = "0x400E99D")]
	private const int INDENTWIDTH_WIDTH = 580;

	[Token(Token = "0x400E99E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected Color m_Color_Team0;

	[Token(Token = "0x400E99F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected Color m_Color_Team1;

	[Token(Token = "0x400E9A0")]
	public const int numMax = 5;

	[Token(Token = "0x400E9A1")]
	[FieldOffset(Offset = "0x70")]
	private bool m_ShowingPopupText;

	[Token(Token = "0x400E9A2")]
	[FieldOffset(Offset = "0x78")]
	protected List<int> m_CardIDList;

	[Token(Token = "0x400E9A3")]
	[FieldOffset(Offset = "0x80")]
	protected string LABEL_EO_CARDTEX;

	[Token(Token = "0x400E9A4")]
	[FieldOffset(Offset = "0x88")]
	protected string LABEL_EO_CARDMASK;

	[Token(Token = "0x400E9A5")]
	[FieldOffset(Offset = "0x90")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400E9A6")]
	[FieldOffset(Offset = "0x98")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400E9A7")]
	[FieldOffset(Offset = "0xA0")]
	protected string LABEL_EO_COST_BG;

	[Token(Token = "0x400E9A8")]
	[FieldOffset(Offset = "0xA8")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400E9A9")]
	[FieldOffset(Offset = "0xB0")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x17001884")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A0EF")]
		[Address(RVA = "0xEE4BF0", Offset = "0xEE3DF0", VA = "0x180EE4BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A0EE")]
	[Address(RVA = "0xEE3FE0", Offset = "0xEE31E0", VA = "0x180EE3FE0")]
	public void SetData(MoveMultiData data)
	{
	}

	[Token(Token = "0x600A0F0")]
	[Address(RVA = "0xEE39E0", Offset = "0xEE2BE0", VA = "0x180EE39E0")]
	protected void SetCards(MoveMultiData data)
	{
	}

	[Token(Token = "0x600A0F1")]
	[Address(RVA = "0xEE33B0", Offset = "0xEE25B0", VA = "0x180EE33B0")]
	private void InitSelectionItems(int idx, SelectionButton sbtn)
	{
	}

	[Token(Token = "0x600A0F2")]
	[Address(RVA = "0xEE3760", Offset = "0xEE2960", VA = "0x180EE3760")]
	protected SelectionButton SetCard(LogDataSide data, ElementObjectManager cardeom)
	{
		return null;
	}

	[Token(Token = "0x600A0F3")]
	[Address(RVA = "0xEE3670", Offset = "0xEE2870", VA = "0x180EE3670")]
	private void SetCardTexture(RawImage cardtexture, GameObject cardmask, int cardid, bool face, bool insight)
	{
	}

	[Token(Token = "0x600A0F4")]
	[Address(RVA = "0xEE44F0", Offset = "0xEE36F0", VA = "0x180EE44F0")]
	protected void SetWidth(bool isIndent)
	{
	}

	[Token(Token = "0x600A0F5")]
	[Address(RVA = "0xEE3DE0", Offset = "0xEE2FE0", VA = "0x180EE3DE0")]
	protected void SetColor(bool team, bool indent)
	{
	}

	[Token(Token = "0x600A0F6")]
	[Address(RVA = "0xEE3EE0", Offset = "0xEE30E0", VA = "0x180EE3EE0")]
	protected void SetCost(bool isCost)
	{
	}

	[Token(Token = "0x600A0F7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public override void OnAdded()
	{
	}

	[Token(Token = "0x600A0F8")]
	[Address(RVA = "0xEE3460", Offset = "0xEE2660", VA = "0x180EE3460", Slot = "6")]
	public override void OnRemoved()
	{
	}

	[Token(Token = "0x600A0F9")]
	[Address(RVA = "0xEE3420", Offset = "0xEE2620", VA = "0x180EE3420", Slot = "4")]
	public override void OnCreated(DuelClient host)
	{
	}

	[Token(Token = "0x600A0FA")]
	[Address(RVA = "0xEE45C0", Offset = "0xEE37C0", VA = "0x180EE45C0")]
	private void SetupCallBack(int idx)
	{
	}

	[Token(Token = "0x600A0FB")]
	[Address(RVA = "0xEE4320", Offset = "0xEE3520", VA = "0x180EE4320")]
	public void SetItemTransition()
	{
	}

	[Token(Token = "0x600A0FC")]
	[Address(RVA = "0xEE4A60", Offset = "0xEE3C60", VA = "0x180EE4A60")]
	public LogMoveMulti()
	{
	}
}
