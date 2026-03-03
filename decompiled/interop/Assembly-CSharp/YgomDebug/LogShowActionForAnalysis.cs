using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomDebug;

[Token(Token = "0x200012D")]
public class LogShowActionForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x4000727")]
	private const int FULLWIDTH = 320;

	[Token(Token = "0x4000728")]
	private const int FULLWIDTH_WIDTH = 670;

	[Token(Token = "0x4000729")]
	private const int INDENTWIDTH = 280;

	[Token(Token = "0x400072A")]
	private const int INDENTWIDTH_WIDTH = 580;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Color m_Color_Team0;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected Color m_Color_Team1;

	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x40")]
	protected string LABEL_EO_CARDTEX;

	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x48")]
	protected string LABEL_EO_CARDMASK;

	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_CURSOR;

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x58")]
	protected string LABEL_EO_CTRICONL;

	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x60")]
	protected string LABEL_EO_CTRICONR;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x68")]
	protected string LABEL_EO_POSICONL;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x70")]
	protected string LABEL_EO_POSICONR;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x78")]
	protected string LABEL_EO_PLAYERICON;

	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x80")]
	protected string LABEL_EO_CARDL;

	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x88")]
	protected string LABEL_EO_CARDR;

	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x90")]
	protected string LABEL_EO_ACTION;

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x98")]
	protected string LABEL_EO_ACTTEXT;

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0xA0")]
	protected string LABEL_EO_COIN;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0xA8")]
	protected string LABEL_EO_COINICON;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0xB0")]
	protected string LABEL_EO_DICE;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0xB8")]
	protected string LABEL_EO_DICEICON;

	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0xC0")]
	protected string LABEL_EO_ARROW;

	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0xC8")]
	protected string LABEL_EO_FACEICONL;

	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0xD0")]
	protected string LABEL_EO_FACEICONR;

	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0xD8")]
	protected string LABEL_EO_FACEICON;

	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0xE0")]
	protected string LABEL_EO_FACEICONFRAME;

	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0xE8")]
	protected string LABEL_EO_LPCHANGE;

	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0xF0")]
	protected string LABEL_EO_CHANGEVALUE;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0xF8")]
	protected string LABEL_EO_RESTLP;

	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x100")]
	protected string LABEL_EO_CHANGETYPE;

	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x108")]
	protected string LABEL_EO_COUNTERCHANGE;

	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x110")]
	protected string LABEL_EO_COUNTERNUMPRE;

	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x118")]
	protected string LABEL_EO_COUNTERNUMAFT;

	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x120")]
	protected string LABEL_EO_COUNTERTYPE;

	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x128")]
	protected string LABEL_EO_COUNTERICON;

	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x130")]
	protected string LABEL_EO_LINETOP;

	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x138")]
	protected string LABEL_EO_LINEBOTTOM;

	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x140")]
	protected string LABEL_EO_BACKGROUND;

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x148")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x150")]
	protected string LABEL_EO_CARDNAMELAYER;

	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x158")]
	protected string LABEL_EO_BATTLEARROW;

	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x160")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x168")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x170")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x178")]
	protected string LABEL_EO_POSITIONICONROOT;

	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x180")]
	protected int m_CardIdL;

	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x184")]
	protected int m_CardIdR;

	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x0")]
	protected static Dictionary<LOGACTIONTYPE, string> m_ActTypeStrDict;

	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x8")]
	protected static Dictionary<Engine.DamageType, string> m_DmgTypeStrDict;

	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x188")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000D4")]
	protected DuelIconSprites m_IconSprites
	{
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x9D9130", Offset = "0x9D8330", VA = "0x1809D9130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D5")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x9D9090", Offset = "0x9D8290", VA = "0x1809D9090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x9D7870", Offset = "0x9D6A70", VA = "0x1809D7870")]
	public void SetData(ShowActionDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x9D5DD0", Offset = "0x9D4FD0", VA = "0x1809D5DD0")]
	public static void ResetWordTable()
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x9D7080", Offset = "0x9D6280", VA = "0x1809D7080")]
	protected void SetCards(ShowActionDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x9D6E10", Offset = "0x9D6010", VA = "0x1809D6E10")]
	protected void SetCard(LogDataSideForAnalysis data, ref int cardidpre, ElementObjectManager cardeom)
	{
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x9D8320", Offset = "0x9D7520", VA = "0x1809D8320")]
	protected void SetPositionIcon(ShowActionDataForAnalysis data, ElementObjectManager poseom)
	{
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x9D7FA0", Offset = "0x9D71A0", VA = "0x1809D7FA0")]
	protected SelectionButton SetFaceIcon(LogDataSideForAnalysis data, ElementObjectManager eomface)
	{
		return null;
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x9D6B80", Offset = "0x9D5D80", VA = "0x1809D6B80")]
	protected void SetAction(LogDataCenterForAnalysis data)
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x9D7E10", Offset = "0x9D7010", VA = "0x1809D7E10")]
	protected void SetDiceResult(LogDataCenterForAnalysis data)
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x9D72A0", Offset = "0x9D64A0", VA = "0x1809D72A0")]
	protected void SetCoinResult(LogDataCenterForAnalysis data)
	{
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x9D80E0", Offset = "0x9D72E0", VA = "0x1809D80E0")]
	protected void SetLPChange(LogDataCenterForAnalysis data)
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x9D7600", Offset = "0x9D6800", VA = "0x1809D7600")]
	protected void SetCounterChange(LogDataCenterForAnalysis data)
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x9D6D20", Offset = "0x9D5F20", VA = "0x1809D6D20")]
	private void SetCardTexture(RawImage cardtexture, GameObject cardmask, int cardid, bool face, bool insight)
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x9D8800", Offset = "0x9D7A00", VA = "0x1809D8800")]
	protected void SetWidth(bool isIndent)
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x9D7500", Offset = "0x9D6700", VA = "0x1809D7500")]
	protected void SetColor(bool team, bool indent)
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public override void OnAdded()
	{
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x9D5DC0", Offset = "0x9D4FC0", VA = "0x1809D5DC0", Slot = "5")]
	public override void OnRemoved()
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x9D8980", Offset = "0x9D7B80", VA = "0x1809D8980")]
	public LogShowActionForAnalysis()
	{
	}
}
