using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001853")]
public class CardInfoBase : MonoBehaviour
{
	[Token(Token = "0x2001854")]
	protected enum ValueState
	{
		[Token(Token = "0x400E485")]
		NORMAL,
		[Token(Token = "0x400E486")]
		CHANGED,
		[Token(Token = "0x400E487")]
		UP,
		[Token(Token = "0x400E488")]
		DOWN
	}

	[Token(Token = "0x400E3F4")]
	[FieldOffset(Offset = "0x20")]
	protected Color m_FontColorNormal;

	[Token(Token = "0x400E3F5")]
	[FieldOffset(Offset = "0x30")]
	protected Color m_FontColorChanged;

	[Token(Token = "0x400E3F6")]
	protected const int MAXLINKNUM = 8;

	[Token(Token = "0x400E3F7")]
	protected const int BIT_CANTATTACK = 512;

	[Token(Token = "0x400E3F8")]
	protected const int BIT_HANDOPEN = 2048;

	[Token(Token = "0x400E3F9")]
	public const int INVALID_HIGHLIGHT_TEXTID = 0;

	[Token(Token = "0x400E3FA")]
	protected const string SIGN_BRACKET_PRE = "【";

	[Token(Token = "0x400E3FB")]
	protected const string SIGN_BRACKET_SUF = "】";

	[Token(Token = "0x400E3FC")]
	protected const string LABEL_TWEEN_SCROLL = "AutoScroll";

	[Token(Token = "0x400E3FD")]
	protected const string LABEL_RT_WINDOW = "Window";

	[Token(Token = "0x400E3FE")]
	protected const string LABEL_RT_PENDULUMSCALE = "PendulumScale";

	[Token(Token = "0x400E3FF")]
	protected const string LABEL_RT_LINKARROWS = "LinkArrows";

	[Token(Token = "0x400E400")]
	protected const string LABEL_RT_NAMEAREA = "NameArea";

	[Token(Token = "0x400E401")]
	protected const string LABEL_RT_TEXTAREA = "TextArea";

	[Token(Token = "0x400E402")]
	protected const string LABEL_RT_STATUEICONS = "StatueIcons";

	[Token(Token = "0x400E403")]
	protected const string LABEL_RT_ACTIVATEDGROUP = "ActivatedGroup";

	[Token(Token = "0x400E404")]
	protected const string LABEL_RT_SCALE_XYZ = "PendulumXYZGroup";

	[Token(Token = "0x400E405")]
	protected const string LABEL_RTXT_CARDNAME = "TextCardName";

	[Token(Token = "0x400E406")]
	protected const string LABEL_RIMG_CARDIMAGE = "ImageCard";

	[Token(Token = "0x400E407")]
	protected const string LABEL_IMG_ICONRARITY = "IconRarity";

	[Token(Token = "0x400E408")]
	protected const string LABEL_IMG_ATTRIBUTEICON = "IconAttribute";

	[Token(Token = "0x400E409")]
	protected const string LABEL_IMG_ATTROUTLINE = "AttrOutline";

	[Token(Token = "0x400E40A")]
	protected const string LABEL_IMG_TUNERGROUP = "TunerGroup";

	[Token(Token = "0x400E40B")]
	protected const string LABEL_IMG_TUNERICON = "IconTuner";

	[Token(Token = "0x400E40C")]
	protected const string LABEL_IMG_TUNEROUTLINE = "TunerOutline";

	[Token(Token = "0x400E40D")]
	protected const string LABEL_IMG_LINKARROW = "LinkArrow";

	[Token(Token = "0x400E40E")]
	protected const string LABEL_IMG_LINKICON = "IconLink";

	[Token(Token = "0x400E40F")]
	protected const string LABEL_IMG_LEVELICON = "IconLevel";

	[Token(Token = "0x400E410")]
	protected const string LABEL_IMG_RANKICON = "IconRank";

	[Token(Token = "0x400E411")]
	protected const string LABEL_IMG_XYZMATICON = "IconXyzMaterial";

	[Token(Token = "0x400E412")]
	protected const string LABEL_IMG_TYPEGROUP = "TypeGroup";

	[Token(Token = "0x400E413")]
	protected const string LABEL_IMG_TYPEICON = "IconType";

	[Token(Token = "0x400E414")]
	protected const string LABEL_IMG_TYPEOUTLINE = "TypeOutline";

	[Token(Token = "0x400E415")]
	protected const string LABEL_IMG_SPTRTYPEROOT = "SpellTrapType";

	[Token(Token = "0x400E416")]
	protected const string LABEL_IMG_SPTRTYPE = "IconSpellTrapType";

	[Token(Token = "0x400E417")]
	protected const string LABEL_IMG_SPTROUTLINE = "SpellTrapOutline";

	[Token(Token = "0x400E418")]
	protected const string LABEL_IMG_ATKICON = "IconAtk";

	[Token(Token = "0x400E419")]
	protected const string LABEL_IMG_DEFICON = "IconDef";

	[Token(Token = "0x400E41A")]
	protected const string LABEL_IMG_TURNNUM = "IconTurnCounter";

	[Token(Token = "0x400E41B")]
	protected const string LABEL_IMG_COUNTER = "IconCounter";

	[Token(Token = "0x400E41C")]
	protected const string LABEL_IMG_PLATETITLE = "PlateTitle";

	[Token(Token = "0x400E41D")]
	protected const string LABEL_IMG_PLATEDESCRIPTION = "PlateDescription";

	[Token(Token = "0x400E41E")]
	protected const string LABEL_IMG_ACTIVATEDICON = "IconActivated";

	[Token(Token = "0x400E41F")]
	protected const string LABEL_IMG_PLATEACTIVATED = "PlateActivated";

	[Token(Token = "0x400E420")]
	protected const string LABEL_TXT_LEVELNUM = "TextLevel";

	[Token(Token = "0x400E421")]
	protected const string LABEL_TXT_RANKNUM = "TextRank";

	[Token(Token = "0x400E422")]
	protected const string LABEL_TXT_XYZMATNUM = "TextXyzMaterial";

	[Token(Token = "0x400E423")]
	protected const string LABEL_TXT_TURNCOUNTERNUM = "TextTurnCounter";

	[Token(Token = "0x400E424")]
	protected const string LABEL_TXT_PENDULUMSCALENUM = "TextPendulumScale";

	[Token(Token = "0x400E425")]
	protected const string LABEL_TXT_LINKNUM = "TextLink";

	[Token(Token = "0x400E426")]
	protected const string LABEL_TXT_SPTRTYPE = "TextSpellTrapType";

	[Token(Token = "0x400E427")]
	protected const string LABEL_TXT_ATKVALUE = "TextAtk";

	[Token(Token = "0x400E428")]
	protected const string LABEL_TXT_DEFVALUE = "TextDef";

	[Token(Token = "0x400E429")]
	protected const string LABEL_TXT_COUNTERNUM = "CounterNum";

	[Token(Token = "0x400E42A")]
	protected const string LABEL_TXT_DSPTITLE = "TextDescriptionItem";

	[Token(Token = "0x400E42B")]
	protected const string LABEL_TXT_DSPCONTENT = "TextDescriptionValue";

	[Token(Token = "0x400E42C")]
	protected const string LABEL_GO_STATUEICON_DISABLEFFECT = "IconStatueDiable";

	[Token(Token = "0x400E42D")]
	protected const string LABEL_GO_STATUEICON_CANTREVIVE = "IconStatueCantRevive";

	[Token(Token = "0x400E42E")]
	protected const string LABEL_GO_STATUEICON_CANTATTACK = "IconStatueCantAttack";

	[Token(Token = "0x400E42F")]
	protected const string LABEL_GO_STATUEICON_HANDOPEN = "IconStatueHandOpen";

	[Token(Token = "0x400E430")]
	protected const string LABEL_GO_STATUEICON_FUSIONMATERIAL = "IconStatueFusionMat";

	[Token(Token = "0x400E431")]
	protected const string LABEL_GO_STATUEICON_SYNCMATERIAL = "IconStatueSyncMat";

	[Token(Token = "0x400E432")]
	protected const string LABEL_GO_STATUEICON_DEMENSIONHOLE = "IconStatueDemensionHole";

	[Token(Token = "0x400E433")]
	protected const string LABEL_GO_STATUEICON_BYBATTLE = "IconStatueByBattle";

	[Token(Token = "0x400E434")]
	protected const string LABEL_IMG_COMMON_COUNTER = "IconCommonCounter";

	[Token(Token = "0x400E435")]
	protected const string LABEL_IMG_COMMON_COUNTER_READY = "IconCommonCounterBaseReady";

	[Token(Token = "0x400E436")]
	protected const string LABEL_IMG_COMMON_COUNTER_UNREADY = "IconCommonCounterBaseUnready";

	[Token(Token = "0x400E437")]
	protected const string LABEL_TXT_COMMON_COUNTER = "TextCommonCounter";

	[Token(Token = "0x400E438")]
	protected const string LABEL_BTN_CARDAREA = "CardArea";

	[Token(Token = "0x400E439")]
	protected const string LABEL_ICON_CARDAREA_SHORTCUT = "CardAreaShortcut";

	[Token(Token = "0x400E43A")]
	protected const string LABEL_BAR_TEAM0 = "ColorBarTeam0";

	[Token(Token = "0x400E43B")]
	protected const string LABEL_BAR_TEAM1 = "ColorBarTeam1";

	[Token(Token = "0x400E43C")]
	protected const string HIGHLIGHTTEXTCOLORCODE = "00D2FF";

	[Token(Token = "0x400E43D")]
	[FieldOffset(Offset = "0x40")]
	protected Dictionary<int, GameObject> m_StatueIconTable;

	[Token(Token = "0x400E43E")]
	[FieldOffset(Offset = "0x48")]
	protected ElementObjectManager m_EOManager_Property;

	[Token(Token = "0x400E43F")]
	[FieldOffset(Offset = "0x50")]
	protected RectTransform m_Window_Property;

	[Token(Token = "0x400E440")]
	[FieldOffset(Offset = "0x58")]
	protected RectTransform m_LinkArrows_Property;

	[Token(Token = "0x400E441")]
	[FieldOffset(Offset = "0x60")]
	protected RectTransform m_PenScale_Property;

	[Token(Token = "0x400E442")]
	[FieldOffset(Offset = "0x68")]
	protected RectTransform m_PendScaleXyzMatRoot_Property;

	[Token(Token = "0x400E443")]
	[FieldOffset(Offset = "0x70")]
	protected RectTransform m_TextArea_Property;

	[Token(Token = "0x400E444")]
	[FieldOffset(Offset = "0x78")]
	protected RectTransform m_NameArea_Property;

	[Token(Token = "0x400E445")]
	[FieldOffset(Offset = "0x80")]
	protected RectTransform m_StatueIcons_Property;

	[Token(Token = "0x400E446")]
	[FieldOffset(Offset = "0x88")]
	protected RectTransform m_SpTrTypeRoot_Property;

	[Token(Token = "0x400E447")]
	[FieldOffset(Offset = "0x90")]
	protected RubyTextGX m_CardName_Property;

	[Token(Token = "0x400E448")]
	[FieldOffset(Offset = "0x98")]
	protected RawImage m_CardImage_Property;

	[Token(Token = "0x400E449")]
	[FieldOffset(Offset = "0xA0")]
	protected SelectionButton m_CardImageButton_Property;

	[Token(Token = "0x400E44A")]
	[FieldOffset(Offset = "0xA8")]
	protected Image m_GachaRareIcon_Property;

	[Token(Token = "0x400E44B")]
	[FieldOffset(Offset = "0xB0")]
	protected Image m_AttributeIcon_Property;

	[Token(Token = "0x400E44C")]
	protected const int numAttrMax = 7;

	[Token(Token = "0x400E44D")]
	[FieldOffset(Offset = "0xB8")]
	protected List<Image> m_AttributeIconList_Property;

	[Token(Token = "0x400E44E")]
	[FieldOffset(Offset = "0xC0")]
	protected List<Image> m_AttributeOutlineList_Property;

	[Token(Token = "0x400E44F")]
	[FieldOffset(Offset = "0xC8")]
	protected GameObject m_AttributeIconListRoot_Property;

	[Token(Token = "0x400E450")]
	[FieldOffset(Offset = "0xD0")]
	protected Image m_AttrOutline_Property;

	[Token(Token = "0x400E451")]
	[FieldOffset(Offset = "0xD8")]
	protected Image m_TunerIcon_Property;

	[Token(Token = "0x400E452")]
	[FieldOffset(Offset = "0xE0")]
	protected RectTransform m_TunerGroup_Property;

	[Token(Token = "0x400E453")]
	[FieldOffset(Offset = "0xE8")]
	protected Image m_TunerOutline_Property;

	[Token(Token = "0x400E454")]
	[FieldOffset(Offset = "0xF0")]
	protected Image m_LevelIcon_Property;

	[Token(Token = "0x400E455")]
	[FieldOffset(Offset = "0xF8")]
	protected Image m_LinkIcon_Property;

	[Token(Token = "0x400E456")]
	[FieldOffset(Offset = "0x100")]
	protected Image m_RankIcon_Property;

	[Token(Token = "0x400E457")]
	[FieldOffset(Offset = "0x108")]
	protected Image m_XyzMatIcon_Property;

	[Token(Token = "0x400E458")]
	[FieldOffset(Offset = "0x110")]
	protected Image m_TypeIcon_Property;

	[Token(Token = "0x400E459")]
	[FieldOffset(Offset = "0x118")]
	protected RectTransform m_TypeGroup_Property;

	[Token(Token = "0x400E45A")]
	[FieldOffset(Offset = "0x120")]
	protected RectTransform m_ActivatedGroup_Property;

	[Token(Token = "0x400E45B")]
	[FieldOffset(Offset = "0x128")]
	protected Image m_TypeOutline_Property;

	[Token(Token = "0x400E45C")]
	[FieldOffset(Offset = "0x130")]
	protected Image m_SpTrTypeIcon_Property;

	[Token(Token = "0x400E45D")]
	[FieldOffset(Offset = "0x138")]
	protected Image m_SpTrOutline_Property;

	[Token(Token = "0x400E45E")]
	[FieldOffset(Offset = "0x140")]
	protected Image m_AtkIcon_Property;

	[Token(Token = "0x400E45F")]
	[FieldOffset(Offset = "0x148")]
	protected Image m_DefIcon_Property;

	[Token(Token = "0x400E460")]
	[FieldOffset(Offset = "0x150")]
	protected Image m_NameAreaBg_Property;

	[Token(Token = "0x400E461")]
	[FieldOffset(Offset = "0x158")]
	protected Image m_TypeAreaBg_Property;

	[Token(Token = "0x400E462")]
	[FieldOffset(Offset = "0x160")]
	protected Image m_TurnElapsedIcon_Property;

	[Token(Token = "0x400E463")]
	[FieldOffset(Offset = "0x168")]
	protected GameObject m_CommonCounterRoot_Property;

	[Token(Token = "0x400E464")]
	[FieldOffset(Offset = "0x170")]
	protected Image m_CommonCounterIconReady_Property;

	[Token(Token = "0x400E465")]
	[FieldOffset(Offset = "0x178")]
	protected Image m_CommonCounterIconUnready_Property;

	[Token(Token = "0x400E466")]
	[FieldOffset(Offset = "0x180")]
	protected ExtendedTextMeshProUGUI m_CommonCounterText_Property;

	[Token(Token = "0x400E467")]
	[FieldOffset(Offset = "0x188")]
	protected Image m_ActivatedIcon_Property;

	[Token(Token = "0x400E468")]
	[FieldOffset(Offset = "0x190")]
	protected Image m_ActivatedPlate_Property;

	[Token(Token = "0x400E469")]
	[FieldOffset(Offset = "0x198")]
	protected ExtendedTextMeshProUGUI m_XyzMatNum_Property;

	[Token(Token = "0x400E46A")]
	[FieldOffset(Offset = "0x1A0")]
	protected ExtendedTextMeshProUGUI m_TurnElapsedNum_Property;

	[Token(Token = "0x400E46B")]
	[FieldOffset(Offset = "0x1A8")]
	protected ExtendedTextMeshProUGUI m_PenScaleNum_Property;

	[Token(Token = "0x400E46C")]
	[FieldOffset(Offset = "0x1B0")]
	protected ExtendedTextMeshProUGUI m_LinkNum_Property;

	[Token(Token = "0x400E46D")]
	[FieldOffset(Offset = "0x1B8")]
	protected ExtendedTextMeshProUGUI m_LevelNum_Property;

	[Token(Token = "0x400E46E")]
	[FieldOffset(Offset = "0x1C0")]
	protected ExtendedTextMeshProUGUI m_RankNum_Property;

	[Token(Token = "0x400E46F")]
	[FieldOffset(Offset = "0x1C8")]
	protected ExtendedTextMeshProUGUI m_SpTrType_Property;

	[Token(Token = "0x400E470")]
	[FieldOffset(Offset = "0x1D0")]
	protected ExtendedTextMeshProUGUI m_AtkValue_Property;

	[Token(Token = "0x400E471")]
	[FieldOffset(Offset = "0x1D8")]
	protected ExtendedTextMeshProUGUI m_DefValue_Property;

	[Token(Token = "0x400E472")]
	[FieldOffset(Offset = "0x1E0")]
	protected ExtendedTextMeshProUGUI m_DspTitle_Property;

	[Token(Token = "0x400E473")]
	[FieldOffset(Offset = "0x1E8")]
	protected ExtendedTextMeshProUGUI m_DspContent_Property;

	[Token(Token = "0x400E474")]
	[FieldOffset(Offset = "0x1F0")]
	protected SelectionButton m_CardArea_Property;

	[Token(Token = "0x400E475")]
	[FieldOffset(Offset = "0x1F8")]
	protected SelectionItem m_TextAreaItem_Property;

	[Token(Token = "0x400E476")]
	[FieldOffset(Offset = "0x200")]
	protected RectTransform m_ColorBarTeam0_Property;

	[Token(Token = "0x400E477")]
	[FieldOffset(Offset = "0x208")]
	protected RectTransform m_ColorBarTeam1_Property;

	[Token(Token = "0x400E478")]
	[FieldOffset(Offset = "0x210")]
	public bool AlwaysDisp;

	[Token(Token = "0x400E479")]
	[FieldOffset(Offset = "0x211")]
	public bool EnableAttributeIcon;

	[Token(Token = "0x400E47A")]
	[FieldOffset(Offset = "0x218")]
	protected CardInfoData m_CardInfoData;

	[Token(Token = "0x400E47B")]
	[FieldOffset(Offset = "0x290")]
	protected CardInfoData m_CardInfoDataOld;

	[Token(Token = "0x400E47C")]
	[FieldOffset(Offset = "0x308")]
	protected Dictionary<int, int> m_HighLightEfxTableForHappening;

	[Token(Token = "0x400E47D")]
	[FieldOffset(Offset = "0x310")]
	protected Dictionary<int, int> m_HighLightEfxTableForToHappen;

	[Token(Token = "0x400E47E")]
	[FieldOffset(Offset = "0x318")]
	protected PopUpTextManager m_PutManager;

	[Token(Token = "0x400E481")]
	[FieldOffset(Offset = "0x328")]
	protected CardExpand m_CardExpand;

	[Token(Token = "0x400E482")]
	[FieldOffset(Offset = "0x330")]
	protected Transform m_CardExpandParent;

	[Token(Token = "0x400E483")]
	[FieldOffset(Offset = "0x338")]
	protected Action onFinishClose;

	[Token(Token = "0x17001777")]
	protected static Content m_CCI
	{
		[Token(Token = "0x6009AED")]
		[Address(RVA = "0xE5E530", Offset = "0xE5D730", VA = "0x180E5E530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001778")]
	protected DuelIconSprites m_DuelIconSprites
	{
		[Token(Token = "0x6009AEE")]
		[Address(RVA = "0x9D9130", Offset = "0x9D8330", VA = "0x1809D9130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001779")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x6009AEF")]
		[Address(RVA = "0xE5F110", Offset = "0xE5E310", VA = "0x180E5F110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177A")]
	protected RectTransform m_Window
	{
		[Token(Token = "0x6009AF0")]
		[Address(RVA = "0xE608E0", Offset = "0xE5FAE0", VA = "0x180E608E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177B")]
	protected RectTransform m_LinkArrows
	{
		[Token(Token = "0x6009AF1")]
		[Address(RVA = "0xE5F410", Offset = "0xE5E610", VA = "0x180E5F410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177C")]
	protected RectTransform m_PenScale
	{
		[Token(Token = "0x6009AF2")]
		[Address(RVA = "0xE5F8D0", Offset = "0xE5EAD0", VA = "0x180E5F8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177D")]
	protected RectTransform m_PendScaleXyzMatRoot
	{
		[Token(Token = "0x6009AF3")]
		[Address(RVA = "0xE5F990", Offset = "0xE5EB90", VA = "0x180E5F990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177E")]
	protected RectTransform m_TextArea
	{
		[Token(Token = "0x6009AF4")]
		[Address(RVA = "0xE600D0", Offset = "0xE5F2D0", VA = "0x180E600D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177F")]
	protected RectTransform m_NameArea
	{
		[Token(Token = "0x6009AF5")]
		[Address(RVA = "0xE5F740", Offset = "0xE5E940", VA = "0x180E5F740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001780")]
	protected RectTransform m_StatueIcons
	{
		[Token(Token = "0x6009AF6")]
		[Address(RVA = "0xE5FF30", Offset = "0xE5F130", VA = "0x180E5FF30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001781")]
	protected RectTransform m_SpTrTypeRoot
	{
		[Token(Token = "0x6009AF7")]
		[Address(RVA = "0xE5FD90", Offset = "0xE5EF90", VA = "0x180E5FD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001782")]
	protected RubyTextGX m_CardName
	{
		[Token(Token = "0x6009AF8")]
		[Address(RVA = "0xE5E830", Offset = "0xE5DA30", VA = "0x180E5E830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001783")]
	protected RawImage m_CardImage
	{
		[Token(Token = "0x6009AF9")]
		[Address(RVA = "0xE5E760", Offset = "0xE5D960", VA = "0x180E5E760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001784")]
	protected SelectionButton m_CardImageButton
	{
		[Token(Token = "0x6009AFA")]
		[Address(RVA = "0xE5E690", Offset = "0xE5D890", VA = "0x180E5E690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001785")]
	protected Image m_GachaRareIcon
	{
		[Token(Token = "0x6009AFB")]
		[Address(RVA = "0xE5F1A0", Offset = "0xE5E3A0", VA = "0x180E5F1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001786")]
	protected Image m_AttributeIcon
	{
		[Token(Token = "0x6009AFC")]
		[Address(RVA = "0xE5E250", Offset = "0xE5D450", VA = "0x180E5E250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001787")]
	protected List<Image> m_AttributeIconList
	{
		[Token(Token = "0x6009AFD")]
		[Address(RVA = "0xE5E030", Offset = "0xE5D230", VA = "0x180E5E030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001788")]
	protected List<Image> m_AttributeOutlineList
	{
		[Token(Token = "0x6009AFE")]
		[Address(RVA = "0xE5E320", Offset = "0xE5D520", VA = "0x180E5E320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001789")]
	protected GameObject m_AttributeIconListRoot
	{
		[Token(Token = "0x6009AFF")]
		[Address(RVA = "0xE5DF70", Offset = "0xE5D170", VA = "0x180E5DF70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700178A")]
	protected Image m_AttrOutline
	{
		[Token(Token = "0x6009B00")]
		[Address(RVA = "0xE5DEA0", Offset = "0xE5D0A0", VA = "0x180E5DEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700178B")]
	protected Image m_TunerIcon
	{
		[Token(Token = "0x6009B01")]
		[Address(RVA = "0xE60260", Offset = "0xE5F460", VA = "0x180E60260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700178C")]
	protected RectTransform m_TunerGroup
	{
		[Token(Token = "0x6009B02")]
		[Address(RVA = "0xE60190", Offset = "0xE5F390", VA = "0x180E60190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700178D")]
	protected Image m_TunerOutline
	{
		[Token(Token = "0x6009B03")]
		[Address(RVA = "0xE60330", Offset = "0xE5F530", VA = "0x180E60330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700178E")]
	protected Image m_LevelIcon
	{
		[Token(Token = "0x6009B04")]
		[Address(RVA = "0xE5F270", Offset = "0xE5E470", VA = "0x180E5F270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700178F")]
	protected Image m_LinkIcon
	{
		[Token(Token = "0x6009B05")]
		[Address(RVA = "0xE5F4D0", Offset = "0xE5E6D0", VA = "0x180E5F4D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001790")]
	protected Image m_RankIcon
	{
		[Token(Token = "0x6009B06")]
		[Address(RVA = "0xE5FA50", Offset = "0xE5EC50", VA = "0x180E5FA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001791")]
	protected Image m_XyzMatIcon
	{
		[Token(Token = "0x6009B07")]
		[Address(RVA = "0xE609A0", Offset = "0xE5FBA0", VA = "0x180E609A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001792")]
	protected Image m_TypeIcon
	{
		[Token(Token = "0x6009B08")]
		[Address(RVA = "0xE60740", Offset = "0xE5F940", VA = "0x180E60740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001793")]
	protected RectTransform m_TypeGroup
	{
		[Token(Token = "0x6009B09")]
		[Address(RVA = "0xE60670", Offset = "0xE5F870", VA = "0x180E60670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001794")]
	protected RectTransform m_ActivatedGroup
	{
		[Token(Token = "0x6009B0A")]
		[Address(RVA = "0xE5DA90", Offset = "0xE5CC90", VA = "0x180E5DA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001795")]
	protected Image m_TypeOutline
	{
		[Token(Token = "0x6009B0B")]
		[Address(RVA = "0xE60810", Offset = "0xE5FA10", VA = "0x180E60810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001796")]
	protected Image m_SpTrTypeIcon
	{
		[Token(Token = "0x6009B0C")]
		[Address(RVA = "0xE5FCC0", Offset = "0xE5EEC0", VA = "0x180E5FCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001797")]
	protected Image m_SpTrOutline
	{
		[Token(Token = "0x6009B0D")]
		[Address(RVA = "0xE5FBF0", Offset = "0xE5EDF0", VA = "0x180E5FBF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001798")]
	protected Image m_AtkIcon
	{
		[Token(Token = "0x6009B0E")]
		[Address(RVA = "0xE5DD00", Offset = "0xE5CF00", VA = "0x180E5DD00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001799")]
	protected Image m_DefIcon
	{
		[Token(Token = "0x6009B0F")]
		[Address(RVA = "0xE5EDD0", Offset = "0xE5DFD0", VA = "0x180E5EDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179A")]
	protected Image m_NameAreaBg
	{
		[Token(Token = "0x6009B10")]
		[Address(RVA = "0xE5F670", Offset = "0xE5E870", VA = "0x180E5F670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179B")]
	protected Image m_TypeAreaBg
	{
		[Token(Token = "0x6009B11")]
		[Address(RVA = "0xE605A0", Offset = "0xE5F7A0", VA = "0x180E605A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179C")]
	protected Image m_TurnElapsedIcon
	{
		[Token(Token = "0x6009B12")]
		[Address(RVA = "0xE60400", Offset = "0xE5F600", VA = "0x180E60400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179D")]
	protected GameObject m_CommonCounterRoot
	{
		[Token(Token = "0x6009B13")]
		[Address(RVA = "0xE5EC40", Offset = "0xE5DE40", VA = "0x180E5EC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179E")]
	protected Image m_CommonCounterIconReady
	{
		[Token(Token = "0x6009B14")]
		[Address(RVA = "0xE5EAA0", Offset = "0xE5DCA0", VA = "0x180E5EAA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179F")]
	protected Image m_CommonCounterIconUnready
	{
		[Token(Token = "0x6009B15")]
		[Address(RVA = "0xE5EB70", Offset = "0xE5DD70", VA = "0x180E5EB70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A0")]
	protected ExtendedTextMeshProUGUI m_CommonCounterText
	{
		[Token(Token = "0x6009B16")]
		[Address(RVA = "0xE5ED00", Offset = "0xE5DF00", VA = "0x180E5ED00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A1")]
	protected Image m_ActivatedIcon
	{
		[Token(Token = "0x6009B17")]
		[Address(RVA = "0xE5DB60", Offset = "0xE5CD60", VA = "0x180E5DB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A2")]
	protected Image m_ActivatedPlate
	{
		[Token(Token = "0x6009B18")]
		[Address(RVA = "0xE5DC30", Offset = "0xE5CE30", VA = "0x180E5DC30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A3")]
	protected ExtendedTextMeshProUGUI m_XyzMatNum
	{
		[Token(Token = "0x6009B19")]
		[Address(RVA = "0xE60A70", Offset = "0xE5FC70", VA = "0x180E60A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A4")]
	protected ExtendedTextMeshProUGUI m_TurnElapsedNum
	{
		[Token(Token = "0x6009B1A")]
		[Address(RVA = "0xE604D0", Offset = "0xE5F6D0", VA = "0x180E604D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A5")]
	protected ExtendedTextMeshProUGUI m_PenScaleNum
	{
		[Token(Token = "0x6009B1B")]
		[Address(RVA = "0xE5F800", Offset = "0xE5EA00", VA = "0x180E5F800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A6")]
	protected ExtendedTextMeshProUGUI m_LinkNum
	{
		[Token(Token = "0x6009B1C")]
		[Address(RVA = "0xE5F5A0", Offset = "0xE5E7A0", VA = "0x180E5F5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A7")]
	protected ExtendedTextMeshProUGUI m_LevelNum
	{
		[Token(Token = "0x6009B1D")]
		[Address(RVA = "0xE5F340", Offset = "0xE5E540", VA = "0x180E5F340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A8")]
	protected ExtendedTextMeshProUGUI m_RankNum
	{
		[Token(Token = "0x6009B1E")]
		[Address(RVA = "0xE5FB20", Offset = "0xE5ED20", VA = "0x180E5FB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A9")]
	protected ExtendedTextMeshProUGUI m_SpTrType
	{
		[Token(Token = "0x6009B1F")]
		[Address(RVA = "0xE5FE60", Offset = "0xE5F060", VA = "0x180E5FE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AA")]
	protected ExtendedTextMeshProUGUI m_AtkValue
	{
		[Token(Token = "0x6009B20")]
		[Address(RVA = "0xE5DDD0", Offset = "0xE5CFD0", VA = "0x180E5DDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AB")]
	protected ExtendedTextMeshProUGUI m_DefValue
	{
		[Token(Token = "0x6009B21")]
		[Address(RVA = "0xE5EEA0", Offset = "0xE5E0A0", VA = "0x180E5EEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AC")]
	protected ExtendedTextMeshProUGUI m_DspTitle
	{
		[Token(Token = "0x6009B22")]
		[Address(RVA = "0xE5F040", Offset = "0xE5E240", VA = "0x180E5F040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AD")]
	protected ExtendedTextMeshProUGUI m_DspContent
	{
		[Token(Token = "0x6009B23")]
		[Address(RVA = "0xE5EF70", Offset = "0xE5E170", VA = "0x180E5EF70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AE")]
	protected SelectionButton m_CardArea
	{
		[Token(Token = "0x6009B24")]
		[Address(RVA = "0xE5E5C0", Offset = "0xE5D7C0", VA = "0x180E5E5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AF")]
	protected SelectionItem m_TextAreaItem
	{
		[Token(Token = "0x6009B25")]
		[Address(RVA = "0xE60000", Offset = "0xE5F200", VA = "0x180E60000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B0")]
	protected RectTransform m_ColorBarTeam0
	{
		[Token(Token = "0x6009B26")]
		[Address(RVA = "0xE5E900", Offset = "0xE5DB00", VA = "0x180E5E900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B1")]
	protected RectTransform m_ColorBarTeam1
	{
		[Token(Token = "0x6009B27")]
		[Address(RVA = "0xE5E9D0", Offset = "0xE5DBD0", VA = "0x180E5E9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B2")]
	public bool isShowing
	{
		[Token(Token = "0x6009B28")]
		[Address(RVA = "0xE5DA80", Offset = "0xE5CC80", VA = "0x180E5DA80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009B29")]
		[Address(RVA = "0xE60B50", Offset = "0xE5FD50", VA = "0x180E60B50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170017B3")]
	public bool isClosing
	{
		[Token(Token = "0x6009B2A")]
		[Address(RVA = "0xE5DA70", Offset = "0xE5CC70", VA = "0x180E5DA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009B2B")]
		[Address(RVA = "0xE60B40", Offset = "0xE5FD40", VA = "0x180E60B40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6009AEA")]
	[Address(RVA = "0xE57D40", Offset = "0xE56F40", VA = "0x180E57D40")]
	public static bool IsTextResourceLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6009AEB")]
	[Address(RVA = "0xE57E00", Offset = "0xE57000", VA = "0x180E57E00")]
	protected static void LoadCardInfoBaseResource()
	{
	}

	[Token(Token = "0x6009AEC")]
	[Address(RVA = "0xE5CC00", Offset = "0xE5BE00", VA = "0x180E5CC00")]
	protected static void UnloadCardInfoBaseResource()
	{
	}

	[Token(Token = "0x6009B2C")]
	[Address(RVA = "0xE5D370", Offset = "0xE5C570", VA = "0x180E5D370")]
	protected CardInfoData UpdateCardInfoDataByUniqueId(int uniqueid)
	{
		return default(CardInfoData);
	}

	[Token(Token = "0x6009B2D")]
	[Address(RVA = "0xE5CC90", Offset = "0xE5BE90", VA = "0x180E5CC90")]
	protected CardInfoData UpdateCardInfoDataByCardId(int cardid, int styleid, int player = -1)
	{
		return default(CardInfoData);
	}

	[Token(Token = "0x6009B2E")]
	[Address(RVA = "0xE5B8D0", Offset = "0xE5AAD0", VA = "0x180E5B8D0")]
	protected void SetRubyName(int cardidorg, int cardidDisp)
	{
	}

	[Token(Token = "0x6009B2F")]
	[Address(RVA = "0xE58E50", Offset = "0xE58050", VA = "0x180E58E50")]
	protected void SetAttribute(int cardidorg, Content.Attribute attrdisp)
	{
	}

	[Token(Token = "0x6009B30")]
	[Address(RVA = "0xE58A90", Offset = "0xE57C90", VA = "0x180E58A90")]
	protected void SetAttributeList(int cardidorg, int element)
	{
	}

	[Token(Token = "0x6009B31")]
	[Address(RVA = "0xE58F80", Offset = "0xE58180", VA = "0x180E58F80")]
	protected void SetBgColor(Image bg, Content.Frame type)
	{
	}

	[Token(Token = "0x6009B32")]
	[Address(RVA = "0xE58150", Offset = "0xE57350", VA = "0x180E58150")]
	protected void SetActivatedIconBgColor(Image bg, Content.Frame type)
	{
	}

	[Token(Token = "0x6009B33")]
	[Address(RVA = "0xE5AA80", Offset = "0xE59C80", VA = "0x180E5AA80")]
	protected void SetOwner()
	{
	}

	[Token(Token = "0x6009B34")]
	[Address(RVA = "0xE59010", Offset = "0xE58210", VA = "0x180E59010")]
	protected void SetCardImage(int cardidorg, int styleid)
	{
	}

	[Token(Token = "0x6009B35")]
	[Address(RVA = "0xE5A5A0", Offset = "0xE597A0", VA = "0x180E5A5A0")]
	protected void SetLinkArrows(int cardidorg)
	{
	}

	[Token(Token = "0x6009B36")]
	[Address(RVA = "0xE5A900", Offset = "0xE59B00", VA = "0x180E5A900")]
	protected void SetOverlayNum(int cardidorg, int owner, int locate, int index, int overlaynum)
	{
	}

	[Token(Token = "0x6009B37")]
	[Address(RVA = "0xE5B1F0", Offset = "0xE5A3F0", VA = "0x180E5B1F0")]
	protected void SetPendulumScale(int cardidorg, int owner, int locate, int index, int scale, int orgscale)
	{
	}

	[Token(Token = "0x6009B38")]
	[Address(RVA = "0xE5B510", Offset = "0xE5A710", VA = "0x180E5B510")]
	protected void SetPendulumXYZGroup()
	{
	}

	[Token(Token = "0x6009B39")]
	[Address(RVA = "0xE5C440", Offset = "0xE5B640", VA = "0x180E5C440")]
	protected void SetTunerIcon(int cardidorg, int owner, int locate, int index, bool isTuner)
	{
	}

	[Token(Token = "0x6009B3A")]
	[Address(RVA = "0xE5C690", Offset = "0xE5B890", VA = "0x180E5C690")]
	protected void SetTurnElapsed(int owner, int locate, int index, int turncounter)
	{
	}

	[Token(Token = "0x6009B3B")]
	[Address(RVA = "0xE590E0", Offset = "0xE582E0", VA = "0x180E590E0")]
	protected void SetCommonCounter(DuelClient host, int cardid, int owner, int locate, int index)
	{
	}

	[Token(Token = "0x6009B3C")]
	[Address(RVA = "0xE5A4D0", Offset = "0xE596D0", VA = "0x180E5A4D0")]
	protected void SetLevel(int leveldisp, int levelorg)
	{
	}

	[Token(Token = "0x6009B3D")]
	[Address(RVA = "0xE5B690", Offset = "0xE5A890", VA = "0x180E5B690")]
	protected void SetRank(int rankdisp, int rankorg)
	{
	}

	[Token(Token = "0x6009B3E")]
	[Address(RVA = "0xE5A7F0", Offset = "0xE599F0", VA = "0x180E5A7F0")]
	protected void SetLinkNum(int cardidorg)
	{
	}

	[Token(Token = "0x6009B3F")]
	[Address(RVA = "0xE5C840", Offset = "0xE5BA40", VA = "0x180E5C840")]
	protected void SetType(int typedispid, int typeorg)
	{
	}

	[Token(Token = "0x6009B40")]
	[Address(RVA = "0xE585A0", Offset = "0xE577A0", VA = "0x180E585A0")]
	protected void SetAtk(int cardidorg, int atkdisp, int atkorigin, bool ismonsternow)
	{
	}

	[Token(Token = "0x6009B41")]
	[Address(RVA = "0xE59950", Offset = "0xE58B50", VA = "0x180E59950")]
	protected void SetDef(int cardidorg, int defdisp, int deforigin, bool ismonsternow)
	{
	}

	[Token(Token = "0x6009B42")]
	[Address(RVA = "0xE59410", Offset = "0xE58610", VA = "0x180E59410")]
	protected void SetCounters(int owner, int locate, int index, int maxcounternum, List<KeyValuePair<Engine.CounterType, int>> countertable)
	{
	}

	[Token(Token = "0x6009B43")]
	[Address(RVA = "0xE5BF70", Offset = "0xE5B170", VA = "0x180E5BF70")]
	protected void SetSpTrType(int cardidorg, int player, int position, CardInfoData cardInfoData)
	{
	}

	[Token(Token = "0x6009B44")]
	[Address(RVA = "0xE5BA40", Offset = "0xE5AC40", VA = "0x180E5BA40")]
	protected void SetSpTrTypeForMonster(int cardidorg, int player, int position, int index, CardInfoData cardInfoData)
	{
	}

	[Token(Token = "0x6009B45")]
	[Address(RVA = "0xE5ACB0", Offset = "0xE59EB0", VA = "0x180E5ACB0")]
	protected void SetParamIconsColor(int cardidorg, bool isGray)
	{
	}

	[Token(Token = "0x6009B46")]
	[Address(RVA = "0xE59B20", Offset = "0xE58D20", VA = "0x180E59B20")]
	protected void SetDspTitle(int cardidorg, int typeid, int effectid, int player, int position, int index, bool istuner, bool hasinstance)
	{
	}

	[Token(Token = "0x6009B47")]
	[Address(RVA = "0xE59FD0", Offset = "0xE591D0", VA = "0x180E59FD0")]
	protected void SetDspTitle(CardInfoData cardInfoData)
	{
	}

	[Token(Token = "0x6009B48")]
	[Address(RVA = "0xE58190", Offset = "0xE57390", VA = "0x180E58190")]
	protected void SetActivatedIcon(int effectId, int cardId, int owner)
	{
	}

	[Token(Token = "0x6009B49")]
	[Address(RVA = "0xE57300", Offset = "0xE56500", VA = "0x180E57300")]
	protected Image GetLinkArrow(int index)
	{
		return null;
	}

	[Token(Token = "0x6009B4A")]
	[Address(RVA = "0xE570B0", Offset = "0xE562B0", VA = "0x180E570B0")]
	protected void AddTypeText(ref string origin, Content.Type type, bool typechanged)
	{
	}

	[Token(Token = "0x6009B4B")]
	[Address(RVA = "0xE56C00", Offset = "0xE55E00", VA = "0x180E56C00")]
	protected void AddKindText(ref string origin, Content.Kind kind, bool effectchanged, bool tunerchanged, bool isTrap, bool isTrapMonster)
	{
	}

	[Token(Token = "0x6009B4C")]
	[Address(RVA = "0xE57280", Offset = "0xE56480", VA = "0x180E57280")]
	protected Color GetFontColor(ValueState valuestate)
	{
		return default(Color);
	}

	[Token(Token = "0x6009B4D")]
	[Address(RVA = "0xE569B0", Offset = "0xE55BB0", VA = "0x180E569B0")]
	protected string AddColorTag(string origin, Color color)
	{
		return null;
	}

	[Token(Token = "0x6009B4E")]
	[Address(RVA = "0xE56AE0", Offset = "0xE55CE0", VA = "0x180E56AE0")]
	protected string AddColorTag(string origin, string colorcode)
	{
		return null;
	}

	[Token(Token = "0x6009B4F")]
	[Address(RVA = "0xE56890", Offset = "0xE55A90", VA = "0x180E56890")]
	protected string AddAlphaTag(string origin, string alphacode)
	{
		return null;
	}

	[Token(Token = "0x6009B50")]
	[Address(RVA = "0xE5B760", Offset = "0xE5A960", VA = "0x180E5B760")]
	protected void SetRareIcon(int cardid, RarityIconBinder.Type type)
	{
	}

	[Token(Token = "0x6009B51")]
	[Address(RVA = "0xE5C1D0", Offset = "0xE5B3D0", VA = "0x180E5C1D0")]
	protected void SetStatueBar(bool visible)
	{
	}

	[Token(Token = "0x6009B52")]
	[Address(RVA = "0xE57160", Offset = "0xE56360", VA = "0x180E57160")]
	protected Image GetCounterImage(int index)
	{
		return null;
	}

	[Token(Token = "0x6009B53")]
	[Address(RVA = "0xE571F0", Offset = "0xE563F0", VA = "0x180E571F0")]
	protected ExtendedTextMeshProUGUI GetCounterText(int index)
	{
		return null;
	}

	[Token(Token = "0x6009B54")]
	[Address(RVA = "0xE57440", Offset = "0xE56640", VA = "0x180E57440")]
	protected void InitStatueIconTable()
	{
	}

	[Token(Token = "0x6009B55")]
	[Address(RVA = "0xE57390", Offset = "0xE56590", VA = "0x180E57390")]
	protected void InitCardInfoData()
	{
	}

	[Token(Token = "0x6009B56")]
	[Address(RVA = "0xE5C2F0", Offset = "0xE5B4F0", VA = "0x180E5C2F0")]
	protected void SetStatueIconPopUpText(int index, string text)
	{
	}

	[Token(Token = "0x6009B57")]
	[Address(RVA = "0xE5A410", Offset = "0xE59610", VA = "0x180E5A410")]
	public void SetHighlightEffectHappening(int uniqueid, int textid)
	{
	}

	[Token(Token = "0x6009B58")]
	[Address(RVA = "0xE5D8B0", Offset = "0xE5CAB0", VA = "0x180E5D8B0")]
	public void UpdateHighLightTextIdTableForToHappen(int index, int textid)
	{
	}

	[Token(Token = "0x6009B59")]
	[Address(RVA = "0xE580F0", Offset = "0xE572F0", VA = "0x180E580F0")]
	public void RemoveHightEffect()
	{
	}

	[Token(Token = "0x6009B5A")]
	[Address(RVA = "0xE58750", Offset = "0xE57950", VA = "0x180E58750")]
	public void SetAttributeFlag(int flagbit, int cardid, int owner = -1, int locate = -1, int index = -1, bool isfightableoneffect = false)
	{
	}

	[Token(Token = "0x6009B5B")]
	[Address(RVA = "0xE57B20", Offset = "0xE56D20", VA = "0x180E57B20", Slot = "4")]
	protected virtual void InitializeBase(bool onCreated = true)
	{
	}

	[Token(Token = "0x6009B5C")]
	[Address(RVA = "0xE57E90", Offset = "0xE57090", VA = "0x180E57E90")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6009B5D")]
	[Address(RVA = "0xE57150", Offset = "0xE56350", VA = "0x180E57150")]
	public static bool CheckHighLightTextIdValid(int textid)
	{
		return default(bool);
	}

	[Token(Token = "0x6009B5E")]
	[Address(RVA = "0xE57EB0", Offset = "0xE570B0", VA = "0x180E57EB0")]
	public void OpenCardExpand()
	{
	}

	[Token(Token = "0x6009B5F")]
	[Address(RVA = "0xE58FC0", Offset = "0xE581C0", VA = "0x180E58FC0")]
	public void SetCardExpand(CardExpand cardExpand, Transform parent)
	{
	}

	[Token(Token = "0x6009B60")]
	[Address(RVA = "0xE5D9B0", Offset = "0xE5CBB0", VA = "0x180E5D9B0")]
	public CardInfoBase()
	{
	}
}
