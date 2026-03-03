using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001903")]
public class LogShowAction : LogItemBase
{
	[Token(Token = "0x400EA09")]
	private const int FULLWIDTH = 320;

	[Token(Token = "0x400EA0A")]
	private const int FULLWIDTH_WIDTH = 670;

	[Token(Token = "0x400EA0B")]
	private const int INDENTWIDTH = 280;

	[Token(Token = "0x400EA0C")]
	private const int INDENTWIDTH_WIDTH = 580;

	[Token(Token = "0x400EA0D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected Color m_Color_Team0;

	[Token(Token = "0x400EA0E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected Color m_Color_Team1;

	[Token(Token = "0x400EA0F")]
	[FieldOffset(Offset = "0x70")]
	private bool m_ShowingPopupText;

	[Token(Token = "0x400EA10")]
	[FieldOffset(Offset = "0x78")]
	protected string LABEL_EO_CARDTEX;

	[Token(Token = "0x400EA11")]
	[FieldOffset(Offset = "0x80")]
	protected string LABEL_EO_CARDMASK;

	[Token(Token = "0x400EA12")]
	[FieldOffset(Offset = "0x88")]
	protected string LABEL_EO_CURSOR;

	[Token(Token = "0x400EA13")]
	[FieldOffset(Offset = "0x90")]
	protected string LABEL_EO_CTRICONL;

	[Token(Token = "0x400EA14")]
	[FieldOffset(Offset = "0x98")]
	protected string LABEL_EO_CTRICONR;

	[Token(Token = "0x400EA15")]
	[FieldOffset(Offset = "0xA0")]
	protected string LABEL_EO_POSICONL;

	[Token(Token = "0x400EA16")]
	[FieldOffset(Offset = "0xA8")]
	protected string LABEL_EO_POSICONR;

	[Token(Token = "0x400EA17")]
	[FieldOffset(Offset = "0xB0")]
	protected string LABEL_EO_PLAYERICON;

	[Token(Token = "0x400EA18")]
	[FieldOffset(Offset = "0xB8")]
	protected string LABEL_EO_CARDL;

	[Token(Token = "0x400EA19")]
	[FieldOffset(Offset = "0xC0")]
	protected string LABEL_EO_CARDR;

	[Token(Token = "0x400EA1A")]
	[FieldOffset(Offset = "0xC8")]
	protected string LABEL_EO_ACTION;

	[Token(Token = "0x400EA1B")]
	[FieldOffset(Offset = "0xD0")]
	protected string LABEL_EO_ACTTEXT;

	[Token(Token = "0x400EA1C")]
	[FieldOffset(Offset = "0xD8")]
	protected string LABEL_EO_COIN;

	[Token(Token = "0x400EA1D")]
	[FieldOffset(Offset = "0xE0")]
	protected string LABEL_EO_COINROOT;

	[Token(Token = "0x400EA1E")]
	[FieldOffset(Offset = "0xE8")]
	protected string LABEL_EO_COINICON;

	[Token(Token = "0x400EA1F")]
	[FieldOffset(Offset = "0xF0")]
	protected string LABEL_EO_DICE;

	[Token(Token = "0x400EA20")]
	[FieldOffset(Offset = "0xF8")]
	protected string LABEL_EO_DICEICON;

	[Token(Token = "0x400EA21")]
	[FieldOffset(Offset = "0x100")]
	protected string LABEL_EO_ZONE;

	[Token(Token = "0x400EA22")]
	[FieldOffset(Offset = "0x108")]
	protected string LABEL_EO_ZONEICON;

	[Token(Token = "0x400EA23")]
	[FieldOffset(Offset = "0x110")]
	protected string LABEL_EO_ARROW;

	[Token(Token = "0x400EA24")]
	[FieldOffset(Offset = "0x118")]
	protected string LABEL_EO_FACEICONL;

	[Token(Token = "0x400EA25")]
	[FieldOffset(Offset = "0x120")]
	protected string LABEL_EO_FACEICONR;

	[Token(Token = "0x400EA26")]
	[FieldOffset(Offset = "0x128")]
	protected string LABEL_EO_FACEICON;

	[Token(Token = "0x400EA27")]
	[FieldOffset(Offset = "0x130")]
	protected string LABEL_EO_FACEICONFRAME;

	[Token(Token = "0x400EA28")]
	[FieldOffset(Offset = "0x138")]
	protected string LABEL_EO_LPCHANGE;

	[Token(Token = "0x400EA29")]
	[FieldOffset(Offset = "0x140")]
	protected string LABEL_EO_CHANGEVALUE;

	[Token(Token = "0x400EA2A")]
	[FieldOffset(Offset = "0x148")]
	protected string LABEL_EO_RESTLP;

	[Token(Token = "0x400EA2B")]
	[FieldOffset(Offset = "0x150")]
	protected string LABEL_EO_CHANGETYPE;

	[Token(Token = "0x400EA2C")]
	[FieldOffset(Offset = "0x158")]
	protected string LABEL_EO_COUNTERCHANGE;

	[Token(Token = "0x400EA2D")]
	[FieldOffset(Offset = "0x160")]
	protected string LABEL_EO_COUNTERNUMPRE;

	[Token(Token = "0x400EA2E")]
	[FieldOffset(Offset = "0x168")]
	protected string LABEL_EO_COUNTERNUMAFT;

	[Token(Token = "0x400EA2F")]
	[FieldOffset(Offset = "0x170")]
	protected string LABEL_EO_COUNTERTYPE;

	[Token(Token = "0x400EA30")]
	[FieldOffset(Offset = "0x178")]
	protected string LABEL_EO_COUNTERICON;

	[Token(Token = "0x400EA31")]
	[FieldOffset(Offset = "0x180")]
	protected string LABEL_EO_LINETOP;

	[Token(Token = "0x400EA32")]
	[FieldOffset(Offset = "0x188")]
	protected string LABEL_EO_LINEBOTTOM;

	[Token(Token = "0x400EA33")]
	[FieldOffset(Offset = "0x190")]
	protected string LABEL_EO_BACKGROUND;

	[Token(Token = "0x400EA34")]
	[FieldOffset(Offset = "0x198")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x400EA35")]
	[FieldOffset(Offset = "0x1A0")]
	protected string LABEL_EO_CARDNAMELAYER;

	[Token(Token = "0x400EA36")]
	[FieldOffset(Offset = "0x1A8")]
	protected string LABEL_EO_BATTLEARROW;

	[Token(Token = "0x400EA37")]
	[FieldOffset(Offset = "0x1B0")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400EA38")]
	[FieldOffset(Offset = "0x1B8")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400EA39")]
	[FieldOffset(Offset = "0x1C0")]
	protected string LABEL_EO_COST_BG;

	[Token(Token = "0x400EA3A")]
	[FieldOffset(Offset = "0x1C8")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400EA3B")]
	[FieldOffset(Offset = "0x1D0")]
	protected string LABEL_EO_POSITIONICONROOT;

	[Token(Token = "0x400EA3C")]
	[FieldOffset(Offset = "0x1D8")]
	protected int m_CardIdL;

	[Token(Token = "0x400EA3D")]
	[FieldOffset(Offset = "0x1DC")]
	protected int m_CardIdR;

	[Token(Token = "0x400EA3E")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<LOGACTIONTYPE, string> m_ActTypeStrDict;

	[Token(Token = "0x400EA3F")]
	[FieldOffset(Offset = "0x8")]
	protected static Dictionary<Engine.DamageType, string> m_DmgTypeStrDict;

	[Token(Token = "0x400EA40")]
	[FieldOffset(Offset = "0x1E0")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018B1")]
	public bool isCoinLog
	{
		[Token(Token = "0x600A16B")]
		[Address(RVA = "0xEF25F0", Offset = "0xEF17F0", VA = "0x180EF25F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018B2")]
	protected DuelIconSprites m_IconSprites
	{
		[Token(Token = "0x600A16E")]
		[Address(RVA = "0x9D9130", Offset = "0x9D8330", VA = "0x1809D9130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B3")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A16F")]
		[Address(RVA = "0xEF2640", Offset = "0xEF1840", VA = "0x180EF2640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A16C")]
	[Address(RVA = "0xEF04E0", Offset = "0xEEF6E0", VA = "0x180EF04E0")]
	public void SetData(ShowActionData data)
	{
	}

	[Token(Token = "0x600A16D")]
	[Address(RVA = "0xEEE080", Offset = "0xEED280", VA = "0x180EEE080")]
	public static void ResetWordTable()
	{
	}

	[Token(Token = "0x600A170")]
	[Address(RVA = "0xEEF570", Offset = "0xEEE770", VA = "0x180EEF570")]
	protected void SetCards(ShowActionData data)
	{
	}

	[Token(Token = "0x600A171")]
	[Address(RVA = "0xEEF2F0", Offset = "0xEEE4F0", VA = "0x180EEF2F0")]
	protected SelectionButton SetCard(LogDataSide data, ref int cardidpre, ElementObjectManager cardeom)
	{
		return null;
	}

	[Token(Token = "0x600A172")]
	[Address(RVA = "0xEF1060", Offset = "0xEF0260", VA = "0x180EF1060")]
	protected void SetPositionIcon(ShowActionData data, ElementObjectManager poseom)
	{
	}

	[Token(Token = "0x600A173")]
	[Address(RVA = "0xEF0CE0", Offset = "0xEEFEE0", VA = "0x180EF0CE0")]
	protected SelectionButton SetFaceIcon(LogDataSide data, ElementObjectManager eomface)
	{
		return null;
	}

	[Token(Token = "0x600A174")]
	[Address(RVA = "0xEEF050", Offset = "0xEEE250", VA = "0x180EEF050")]
	protected void SetAction(LogDataCenter data, bool showArrow)
	{
	}

	[Token(Token = "0x600A175")]
	[Address(RVA = "0xEF0B20", Offset = "0xEEFD20", VA = "0x180EF0B20")]
	protected void SetDiceResult(LogDataCenter data)
	{
	}

	[Token(Token = "0x600A176")]
	[Address(RVA = "0xEEFA50", Offset = "0xEEEC50", VA = "0x180EEFA50")]
	protected void SetCoinResult(LogDataCenter data)
	{
	}

	[Token(Token = "0x600A177")]
	[Address(RVA = "0xEEFA10", Offset = "0xEEEC10", VA = "0x180EEFA10")]
	private void SetCoinButton(SelectionButton sbtn, int index)
	{
	}

	[Token(Token = "0x600A178")]
	[Address(RVA = "0xEF0E20", Offset = "0xEF0020", VA = "0x180EF0E20")]
	protected void SetLPChange(LogDataCenter data)
	{
	}

	[Token(Token = "0x600A179")]
	[Address(RVA = "0xEF0270", Offset = "0xEEF470", VA = "0x180EF0270")]
	protected void SetCounterChange(LogDataCenter data)
	{
	}

	[Token(Token = "0x600A17A")]
	[Address(RVA = "0xEF1640", Offset = "0xEF0840", VA = "0x180EF1640")]
	protected void SetZoneIcon(ShowActionData data)
	{
	}

	[Token(Token = "0x600A17B")]
	[Address(RVA = "0xEEF200", Offset = "0xEEE400", VA = "0x180EEF200")]
	private void SetCardTexture(RawImage cardtexture, GameObject cardmask, int cardid, bool face, bool insight)
	{
	}

	[Token(Token = "0x600A17C")]
	[Address(RVA = "0xEF1570", Offset = "0xEF0770", VA = "0x180EF1570")]
	protected void SetWidth(bool isIndent)
	{
	}

	[Token(Token = "0x600A17D")]
	[Address(RVA = "0xEF0030", Offset = "0xEEF230", VA = "0x180EF0030")]
	protected void SetColor(bool team, bool indent)
	{
	}

	[Token(Token = "0x600A17E")]
	[Address(RVA = "0xEF0130", Offset = "0xEEF330", VA = "0x180EF0130")]
	protected void SetCost(ShowActionData data)
	{
	}

	[Token(Token = "0x600A17F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110", Slot = "5")]
	public override void OnAdded()
	{
	}

	[Token(Token = "0x600A180")]
	[Address(RVA = "0xEEDF40", Offset = "0xEED140", VA = "0x180EEDF40", Slot = "6")]
	public override void OnRemoved()
	{
	}

	[Token(Token = "0x600A181")]
	[Address(RVA = "0xEEDF00", Offset = "0xEED100", VA = "0x180EEDF00", Slot = "4")]
	public override void OnCreated(DuelClient host)
	{
	}

	[Token(Token = "0x600A182")]
	[Address(RVA = "0xEF18A0", Offset = "0xEF0AA0", VA = "0x180EF18A0")]
	private void SetupCallBack(bool isleft)
	{
	}

	[Token(Token = "0x600A183")]
	[Address(RVA = "0xEF1E00", Offset = "0xEF1000", VA = "0x180EF1E00")]
	public LogShowAction()
	{
	}
}
