using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010A3")]
public class DeckBox : MonoBehaviour
{
	[Token(Token = "0x400B0E7")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_eom;

	[Token(Token = "0x400B0E8")]
	[FieldOffset(Offset = "0x28")]
	protected ElementObjectManager m_body;

	[Token(Token = "0x400B0E9")]
	[FieldOffset(Offset = "0x30")]
	protected TextMeshProUGUI m_DeckNameText;

	[Token(Token = "0x400B0EA")]
	[FieldOffset(Offset = "0x38")]
	protected GameObject m_CreateDeckIcon;

	[Token(Token = "0x400B0EB")]
	[FieldOffset(Offset = "0x40")]
	protected GameObject m_DisabledIcon;

	[Token(Token = "0x400B0EC")]
	[FieldOffset(Offset = "0x48")]
	protected GameObject m_CurrentDeckIcon;

	[Token(Token = "0x400B0ED")]
	[FieldOffset(Offset = "0x50")]
	protected SelectionButton m_button;

	[Token(Token = "0x400B0EE")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_SelectionToggle;

	[Token(Token = "0x400B0EF")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_ToggleOn;

	[Token(Token = "0x400B0F0")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_RankIcon;

	[Token(Token = "0x400B0F1")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_RateIcon;

	[Token(Token = "0x400B0F2")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_BG;

	[Token(Token = "0x400B0F3")]
	[FieldOffset(Offset = "0x80")]
	public Image m_regImage;

	[Token(Token = "0x400B0F4")]
	[FieldOffset(Offset = "0x88")]
	protected GameObject m_deckCaseObj;

	[Token(Token = "0x400B0F5")]
	[FieldOffset(Offset = "0x90")]
	protected UnityAction m_OnClickAction;

	[Token(Token = "0x400B0F6")]
	[FieldOffset(Offset = "0x98")]
	protected int m_deckID;

	[Token(Token = "0x400B0F7")]
	[FieldOffset(Offset = "0xA0")]
	public Action onSelectedTweenCallback;

	[Token(Token = "0x400B0F8")]
	[FieldOffset(Offset = "0xA8")]
	public Action onDeSelectedTweenCallback;

	[Token(Token = "0x400B0F9")]
	[FieldOffset(Offset = "0xB0")]
	protected string m_deckName;

	[Token(Token = "0x400B0FA")]
	[FieldOffset(Offset = "0xB8")]
	protected DeckCaseWidget m_deckCaseWidget;

	[Token(Token = "0x1700109B")]
	public bool m_isSelected
	{
		[Token(Token = "0x60066F6")]
		[Address(RVA = "0xABE6F0", Offset = "0xABD8F0", VA = "0x180ABE6F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60066F7")]
		[Address(RVA = "0xABE740", Offset = "0xABD940", VA = "0x180ABE740")]
		set
		{
		}
	}

	[Token(Token = "0x1700109C")]
	public string SoundLabelClick
	{
		[Token(Token = "0x60066F8")]
		[Address(RVA = "0xABE710", Offset = "0xABD910", VA = "0x180ABE710")]
		set
		{
		}
	}

	[Token(Token = "0x1700109D")]
	public int deckID
	{
		[Token(Token = "0x60066F9")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066FA")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700109E")]
	public SelectionButton button
	{
		[Token(Token = "0x60066FB")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700109F")]
	public string deckName
	{
		[Token(Token = "0x60066FC")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		get
		{
			return null;
		}
		[Token(Token = "0x60066FD")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		set
		{
		}
	}

	[Token(Token = "0x170010A0")]
	public DeckCaseWidget deckCaseWidget
	{
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A1")]
	public DeckSelectViewController2.DeckCondition m_Condition
	{
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0xAA4ED0", Offset = "0xAA40D0", VA = "0x180AA4ED0")]
		[CompilerGenerated]
		get
		{
			return default(DeckSelectViewController2.DeckCondition);
		}
		[Token(Token = "0x6006700")]
		[Address(RVA = "0xAA4930", Offset = "0xAA3B30", VA = "0x180AA4930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6006701")]
	[Address(RVA = "0xABCF40", Offset = "0xABC140", VA = "0x180ABCF40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006702")]
	[Address(RVA = "0xABCFD0", Offset = "0xABC1D0", VA = "0x180ABCFD0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6006703")]
	[Address(RVA = "0xABE350", Offset = "0xABD550", VA = "0x180ABE350")]
	protected void SetTweenCallback()
	{
	}

	[Token(Token = "0x6006704")]
	[Address(RVA = "0xABD3C0", Offset = "0xABC5C0", VA = "0x180ABD3C0")]
	public IAsyncProgressContainer SetAsCreateButton()
	{
		return null;
	}

	[Token(Token = "0x6006705")]
	[Address(RVA = "0xABD430", Offset = "0xABC630", VA = "0x180ABD430")]
	public IAsyncProgressContainer SetAsDeck(int id, string name, int case_id, int protector_id, int[] pickup_ids, int[] pickup_decos, bool opened = false, bool setAsNewButton = false, bool isDeletemode = false, bool isSelected = false)
	{
		return null;
	}

	[Token(Token = "0x6006706")]
	[Address(RVA = "0xABD520", Offset = "0xABC720", VA = "0x180ABD520")]
	private IAsyncProgressContainer SetData(int id, string name, int case_id, int protector_id, int[] pickup_ids, int[] pickup_decos, bool opened = false, bool setAsNewButton = false, bool isDeletemode = false, bool isSelected = false)
	{
		return null;
	}

	[Token(Token = "0x6006707")]
	[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006708")]
	[Address(RVA = "0xABD500", Offset = "0xABC700", VA = "0x180ABD500")]
	public void SetCurrentDeckIcon(bool disp)
	{
	}

	[Token(Token = "0x6006709")]
	[Address(RVA = "0xABCF50", Offset = "0xABC150", VA = "0x180ABCF50")]
	public bool GetCurrentDeckIconDisp()
	{
		return default(bool);
	}

	[Token(Token = "0x600670A")]
	[Address(RVA = "0xABE330", Offset = "0xABD530", VA = "0x180ABE330")]
	public void SetDisableDeckIcon(bool disp)
	{
	}

	[Token(Token = "0x600670B")]
	[Address(RVA = "0xABD470", Offset = "0xABC670", VA = "0x180ABD470")]
	public void SetBadge(bool disp)
	{
	}

	[Token(Token = "0x600670C")]
	[Address(RVA = "0xABDEF0", Offset = "0xABD0F0", VA = "0x180ABDEF0")]
	public void SetDeckIconAndBG(int rank, int rate)
	{
	}

	[Token(Token = "0x600670D")]
	[Address(RVA = "0xABE410", Offset = "0xABD610", VA = "0x180ABE410")]
	private void Start()
	{
	}

	[Token(Token = "0x600670E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Update()
	{
	}

	[Token(Token = "0x600670F")]
	[Address(RVA = "0xABE690", Offset = "0xABD890", VA = "0x180ABE690")]
	public DeckBox()
	{
	}
}
