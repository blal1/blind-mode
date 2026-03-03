using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x20018FE")]
public class LogMoveMultiHeader : LogItemBase
{
	[Token(Token = "0x400E9B0")]
	private const int FULLWIDTH = 320;

	[Token(Token = "0x400E9B1")]
	private const int FULLWIDTH_WIDTH = 670;

	[Token(Token = "0x400E9B2")]
	private const int INDENTWIDTH = 280;

	[Token(Token = "0x400E9B3")]
	private const int INDENTWIDTH_WIDTH = 580;

	[Token(Token = "0x400E9B4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected Color m_Color_Team0;

	[Token(Token = "0x400E9B5")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected Color m_Color_Team1;

	[Token(Token = "0x400E9B6")]
	public const int numMax = 5;

	[Token(Token = "0x400E9B7")]
	[FieldOffset(Offset = "0x70")]
	protected List<int> m_CardIDList;

	[Token(Token = "0x400E9B8")]
	[FieldOffset(Offset = "0x78")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400E9B9")]
	[FieldOffset(Offset = "0x80")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400E9BA")]
	[FieldOffset(Offset = "0x88")]
	protected string LABEL_EO_COST_BG;

	[Token(Token = "0x400E9BB")]
	[FieldOffset(Offset = "0x90")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400E9BC")]
	[FieldOffset(Offset = "0x98")]
	protected string LABEL_EO_CURSOR;

	[Token(Token = "0x400E9BD")]
	[FieldOffset(Offset = "0xA0")]
	protected string LABEL_EO_CTRICONL;

	[Token(Token = "0x400E9BE")]
	[FieldOffset(Offset = "0xA8")]
	protected string LABEL_EO_CTRICONR;

	[Token(Token = "0x400E9BF")]
	[FieldOffset(Offset = "0xB0")]
	protected string LABEL_EO_POSICONL;

	[Token(Token = "0x400E9C0")]
	[FieldOffset(Offset = "0xB8")]
	protected string LABEL_EO_POSICONR;

	[Token(Token = "0x400E9C1")]
	[FieldOffset(Offset = "0xC0")]
	protected string LABEL_EO_PLAYERICON;

	[Token(Token = "0x400E9C2")]
	[FieldOffset(Offset = "0xC8")]
	protected string LABEL_EO_CARDL;

	[Token(Token = "0x400E9C3")]
	[FieldOffset(Offset = "0xD0")]
	protected string LABEL_EO_CARDR;

	[Token(Token = "0x400E9C4")]
	[FieldOffset(Offset = "0xD8")]
	protected string LABEL_EO_ACTION;

	[Token(Token = "0x400E9C5")]
	[FieldOffset(Offset = "0xE0")]
	protected string LABEL_EO_ACTTEXT;

	[Token(Token = "0x400E9C6")]
	[FieldOffset(Offset = "0xE8")]
	protected string LABEL_EO_COIN;

	[Token(Token = "0x400E9C7")]
	[FieldOffset(Offset = "0xF0")]
	protected string LABEL_EO_COINICON;

	[Token(Token = "0x400E9C8")]
	[FieldOffset(Offset = "0xF8")]
	protected string LABEL_EO_DICE;

	[Token(Token = "0x400E9C9")]
	[FieldOffset(Offset = "0x100")]
	protected string LABEL_EO_DICEICON;

	[Token(Token = "0x400E9CA")]
	[FieldOffset(Offset = "0x108")]
	protected string LABEL_EO_ARROW;

	[Token(Token = "0x400E9CB")]
	[FieldOffset(Offset = "0x110")]
	protected string LABEL_EO_FACEICONL;

	[Token(Token = "0x400E9CC")]
	[FieldOffset(Offset = "0x118")]
	protected string LABEL_EO_FACEICONR;

	[Token(Token = "0x400E9CD")]
	[FieldOffset(Offset = "0x120")]
	protected string LABEL_EO_FACEICON;

	[Token(Token = "0x400E9CE")]
	[FieldOffset(Offset = "0x128")]
	protected string LABEL_EO_FACEICONFRAME;

	[Token(Token = "0x400E9CF")]
	[FieldOffset(Offset = "0x130")]
	protected string LABEL_EO_LPCHANGE;

	[Token(Token = "0x400E9D0")]
	[FieldOffset(Offset = "0x138")]
	protected string LABEL_EO_CHANGEVALUE;

	[Token(Token = "0x400E9D1")]
	[FieldOffset(Offset = "0x140")]
	protected string LABEL_EO_RESTLP;

	[Token(Token = "0x400E9D2")]
	[FieldOffset(Offset = "0x148")]
	protected string LABEL_EO_CHANGETYPE;

	[Token(Token = "0x400E9D3")]
	[FieldOffset(Offset = "0x150")]
	protected string LABEL_EO_COUNTERCHANGE;

	[Token(Token = "0x400E9D4")]
	[FieldOffset(Offset = "0x158")]
	protected string LABEL_EO_COUNTERNUMPRE;

	[Token(Token = "0x400E9D5")]
	[FieldOffset(Offset = "0x160")]
	protected string LABEL_EO_COUNTERNUMAFT;

	[Token(Token = "0x400E9D6")]
	[FieldOffset(Offset = "0x168")]
	protected string LABEL_EO_COUNTERTYPE;

	[Token(Token = "0x400E9D7")]
	[FieldOffset(Offset = "0x170")]
	protected string LABEL_EO_COUNTERICON;

	[Token(Token = "0x400E9D8")]
	[FieldOffset(Offset = "0x178")]
	protected string LABEL_EO_LINETOP;

	[Token(Token = "0x400E9D9")]
	[FieldOffset(Offset = "0x180")]
	protected string LABEL_EO_LINEBOTTOM;

	[Token(Token = "0x400E9DA")]
	[FieldOffset(Offset = "0x188")]
	protected string LABEL_EO_BACKGROUND;

	[Token(Token = "0x400E9DB")]
	[FieldOffset(Offset = "0x190")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x400E9DC")]
	[FieldOffset(Offset = "0x198")]
	protected string LABEL_EO_CARDNAMELAYER;

	[Token(Token = "0x400E9DD")]
	[FieldOffset(Offset = "0x1A0")]
	protected string LABEL_EO_BATTLEARROW;

	[Token(Token = "0x400E9DE")]
	[FieldOffset(Offset = "0x1A8")]
	protected string LABEL_EO_POSITIONICONROOT;

	[Token(Token = "0x400E9DF")]
	[FieldOffset(Offset = "0x1B0")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x17001885")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A108")]
		[Address(RVA = "0xEE3310", Offset = "0xEE2510", VA = "0x180EE3310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A107")]
	[Address(RVA = "0xEE2060", Offset = "0xEE1260", VA = "0x180EE2060")]
	public void SetData(ShowActionData data)
	{
	}

	[Token(Token = "0x600A109")]
	[Address(RVA = "0xEE2540", Offset = "0xEE1740", VA = "0x180EE2540")]
	protected void SetPositionIcon(ShowActionData data, ElementObjectManager poseom)
	{
	}

	[Token(Token = "0x600A10A")]
	[Address(RVA = "0xEE1CB0", Offset = "0xEE0EB0", VA = "0x180EE1CB0")]
	protected void SetAction(LogDataCenter data, bool showArrow)
	{
	}

	[Token(Token = "0x600A10B")]
	[Address(RVA = "0xEE2AE0", Offset = "0xEE1CE0", VA = "0x180EE2AE0")]
	protected void SetWidth(bool isIndent)
	{
	}

	[Token(Token = "0x600A10C")]
	[Address(RVA = "0xEE1E60", Offset = "0xEE1060", VA = "0x180EE1E60")]
	protected void SetColor(bool team, bool indent)
	{
	}

	[Token(Token = "0x600A10D")]
	[Address(RVA = "0xEE1F60", Offset = "0xEE1160", VA = "0x180EE1F60")]
	protected void SetCost(bool isCost)
	{
	}

	[Token(Token = "0x600A10E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public override void OnAdded()
	{
	}

	[Token(Token = "0x600A10F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public override void OnRemoved()
	{
	}

	[Token(Token = "0x600A110")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380", Slot = "4")]
	public override void OnCreated(DuelClient host)
	{
	}

	[Token(Token = "0x600A111")]
	[Address(RVA = "0xEE2BB0", Offset = "0xEE1DB0", VA = "0x180EE2BB0")]
	public LogMoveMultiHeader()
	{
	}
}
