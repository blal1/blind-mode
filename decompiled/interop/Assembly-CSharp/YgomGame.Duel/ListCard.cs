using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018EE")]
public class ListCard : MonoBehaviour
{
	[Token(Token = "0x400E959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color m_ColorMyself;

	[Token(Token = "0x400E95A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color m_ColorRIval;

	[Token(Token = "0x400E95B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color m_ColorDefault;

	[Token(Token = "0x400E95C")]
	protected const int BIT_CANTATTACK = 512;

	[Token(Token = "0x400E95D")]
	protected const int BIT_HANDOPEN = 2048;

	[Token(Token = "0x400E95E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static Dictionary<int, int> m_IconTable;

	[Token(Token = "0x400E95F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ListCardData m_CardData;

	[Token(Token = "0x400E960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x400E961")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RawImage m_CardPicture;

	[Token(Token = "0x400E962")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Image m_DarkMask;

	[Token(Token = "0x400E963")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject m_LinkMarker;

	[Token(Token = "0x400E964")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject m_CardMask;

	[Token(Token = "0x400E965")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject m_Badge;

	[Token(Token = "0x400E966")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject m_PendulumInfo;

	[Token(Token = "0x400E967")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Image m_BgPanel;

	[Token(Token = "0x400E968")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Image m_SelectedEffect;

	[Token(Token = "0x400E969")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Image m_Star;

	[Token(Token = "0x400E96A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Image m_TargettedIcon;

	[Token(Token = "0x400E96B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Image m_ChainIcon;

	[Token(Token = "0x400E96C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Image m_FromExtraIcon;

	[Token(Token = "0x400E96D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Image m_DisableIcon;

	[Token(Token = "0x400E96E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ExtendedTextMeshProUGUI m_BadgeIndex;

	[Token(Token = "0x400E96F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private ExtendedTextMeshProUGUI m_LvRkLkNum;

	[Token(Token = "0x400E970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ExtendedTextMeshProUGUI m_ChainNum;

	[Token(Token = "0x400E971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI m_PendulumScaleNum;

	[Token(Token = "0x400E972")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private SelectionButton m_SelectionButton;

	[Token(Token = "0x400E973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool m_DarkMode;

	[Token(Token = "0x17001865")]
	private Color m_OwnerColor
	{
		[Token(Token = "0x600A095")]
		[Address(RVA = "0xEE15D0", Offset = "0xEE07D0", VA = "0x180EE15D0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17001866")]
	public RawImage cardPicture
	{
		[Token(Token = "0x600A096")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001867")]
	public int RunListIndex
	{
		[Token(Token = "0x600A098")]
		[Address(RVA = "0xEE14A0", Offset = "0xEE06A0", VA = "0x180EE14A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001868")]
	public int DataIndex
	{
		[Token(Token = "0x600A099")]
		[Address(RVA = "0xEE13A0", Offset = "0xEE05A0", VA = "0x180EE13A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001869")]
	public bool Isknown
	{
		[Token(Token = "0x600A09A")]
		[Address(RVA = "0xEE1420", Offset = "0xEE0620", VA = "0x180EE1420")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700186A")]
	public bool HoldInstance
	{
		[Token(Token = "0x600A09B")]
		[Address(RVA = "0xEE13F0", Offset = "0xEE05F0", VA = "0x180EE13F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700186B")]
	public int CardId
	{
		[Token(Token = "0x600A09C")]
		[Address(RVA = "0xEE1380", Offset = "0xEE0580", VA = "0x180EE1380")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700186C")]
	public int UniqueID
	{
		[Token(Token = "0x600A09D")]
		[Address(RVA = "0xEE14E0", Offset = "0xEE06E0", VA = "0x180EE14E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700186D")]
	public int TargetUid
	{
		[Token(Token = "0x600A09E")]
		[Address(RVA = "0xEE14C0", Offset = "0xEE06C0", VA = "0x180EE14C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700186E")]
	public int Badge
	{
		[Token(Token = "0x600A09F")]
		[Address(RVA = "0xEE16E0", Offset = "0xEE08E0", VA = "0x180EE16E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700186F")]
	public int textid
	{
		[Token(Token = "0x600A0A0")]
		[Address(RVA = "0xEE16C0", Offset = "0xEE08C0", VA = "0x180EE16C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001870")]
	public bool Selected
	{
		[Token(Token = "0x600A0A1")]
		[Address(RVA = "0xEE1710", Offset = "0xEE0910", VA = "0x180EE1710")]
		set
		{
		}
	}

	[Token(Token = "0x17001871")]
	public bool Targeted
	{
		[Token(Token = "0x600A0A2")]
		[Address(RVA = "0xEE1730", Offset = "0xEE0930", VA = "0x180EE1730")]
		set
		{
		}
	}

	[Token(Token = "0x17001872")]
	public bool DarkMode
	{
		[Token(Token = "0x600A0A3")]
		[Address(RVA = "0xEE1700", Offset = "0xEE0900", VA = "0x180EE1700")]
		set
		{
		}
	}

	[Token(Token = "0x17001873")]
	public int Player
	{
		[Token(Token = "0x600A0A4")]
		[Address(RVA = "0xEE1440", Offset = "0xEE0640", VA = "0x180EE1440")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001874")]
	public int Position
	{
		[Token(Token = "0x600A0A5")]
		[Address(RVA = "0xEE1470", Offset = "0xEE0670", VA = "0x180EE1470")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001875")]
	public bool Face
	{
		[Token(Token = "0x600A0A6")]
		[Address(RVA = "0xEE13C0", Offset = "0xEE05C0", VA = "0x180EE13C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001876")]
	public int highlightEffectTableIndex
	{
		[Token(Token = "0x600A0A7")]
		[Address(RVA = "0xEE15A0", Offset = "0xEE07A0", VA = "0x180EE15A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600A097")]
	[Address(RVA = "0xEDF530", Offset = "0xEDE730", VA = "0x180EDF530")]
	private void InitComponent()
	{
	}

	[Token(Token = "0x600A0A8")]
	[Address(RVA = "0xEDFA10", Offset = "0xEDEC10", VA = "0x180EDFA10")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600A0A9")]
	[Address(RVA = "0xEDFDF0", Offset = "0xEDEFF0", VA = "0x180EDFDF0")]
	public void SetDecideButton(bool use_decide_button, [Optional] SelectionButton decide_button)
	{
	}

	[Token(Token = "0x600A0AA")]
	[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
	public void SetData(ListCardData data)
	{
	}

	[Token(Token = "0x600A0AB")]
	[Address(RVA = "0xEE1160", Offset = "0xEE0360", VA = "0x180EE1160")]
	public void UpdateListCard()
	{
	}

	[Token(Token = "0x600A0AC")]
	[Address(RVA = "0xEDFEC0", Offset = "0xEDF0C0", VA = "0x180EDFEC0")]
	public void SetGroupPos(int index)
	{
	}

	[Token(Token = "0x600A0AD")]
	[Address(RVA = "0xEDFA20", Offset = "0xEDEC20", VA = "0x180EDFA20")]
	private void SetCardArea()
	{
	}

	[Token(Token = "0x600A0AE")]
	[Address(RVA = "0xEDFF10", Offset = "0xEDF110", VA = "0x180EDFF10")]
	private void SetInfoArea()
	{
	}

	[Token(Token = "0x600A0AF")]
	[Address(RVA = "0xEDF1C0", Offset = "0xEDE3C0", VA = "0x180EDF1C0")]
	private Sprite GetStateIcon()
	{
		return null;
	}

	[Token(Token = "0x600A0B0")]
	[Address(RVA = "0xEE0270", Offset = "0xEDF470", VA = "0x180EE0270")]
	private void SetLevelRankLink()
	{
	}

	[Token(Token = "0x600A0B1")]
	[Address(RVA = "0xEE0F00", Offset = "0xEE0100", VA = "0x180EE0F00")]
	private void SetPendulumScale()
	{
	}

	[Token(Token = "0x600A0B2")]
	[Address(RVA = "0xEDFB10", Offset = "0xEDED10", VA = "0x180EDFB10")]
	private void SetCardPicture()
	{
	}

	[Token(Token = "0x600A0B3")]
	[Address(RVA = "0xEE0960", Offset = "0xEDFB60", VA = "0x180EE0960")]
	public void SetOnClick(UnityAction<ListCard> onClick)
	{
	}

	[Token(Token = "0x600A0B4")]
	[Address(RVA = "0xEE0A70", Offset = "0xEDFC70", VA = "0x180EE0A70")]
	public void SetOnDoubleClick(UnityAction<ListCard> onDoubleClick)
	{
	}

	[Token(Token = "0x600A0B5")]
	[Address(RVA = "0xEE0B90", Offset = "0xEDFD90", VA = "0x180EE0B90")]
	public void SetOnHold(UnityAction<ListCard> onHold)
	{
	}

	[Token(Token = "0x600A0B6")]
	[Address(RVA = "0xEE1130", Offset = "0xEE0330", VA = "0x180EE1130")]
	public void SetSelectionCursor()
	{
	}

	[Token(Token = "0x600A0B7")]
	[Address(RVA = "0xEDF1A0", Offset = "0xEDE3A0", VA = "0x180EDF1A0")]
	public Transform GetCardPictureTransform()
	{
		return null;
	}

	[Token(Token = "0x600A0B8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ListCard()
	{
	}
}
