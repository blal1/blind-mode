using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006D7")]
public class GenericCardListEx : MonoBehaviour, IGenericScrollViewSupport, IGameObjectPool
{
	[Token(Token = "0x400226A")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_EoManager;

	[Token(Token = "0x400226B")]
	[FieldOffset(Offset = "0x28")]
	protected GenericScrollView m_ScrollView;

	[Token(Token = "0x400226C")]
	[FieldOffset(Offset = "0x30")]
	protected RawImage m_OriginCard;

	[Token(Token = "0x400226D")]
	[FieldOffset(Offset = "0x38")]
	protected SelectionButton m_OriginCardSbtn;

	[Token(Token = "0x400226E")]
	[FieldOffset(Offset = "0x40")]
	protected List<int> m_Datalist;

	[Token(Token = "0x400226F")]
	[FieldOffset(Offset = "0x48")]
	protected CardInfoForGenericCardListEx m_CardInfoForRelativeCard;

	[Token(Token = "0x4002270")]
	[FieldOffset(Offset = "0x50")]
	protected int m_OriginCardid;

	[Token(Token = "0x4002271")]
	[FieldOffset(Offset = "0x54")]
	protected int m_ShowingCardid;

	[Token(Token = "0x4002272")]
	[FieldOffset(Offset = "0x58")]
	protected bool m_IsVisible;

	[Token(Token = "0x4002273")]
	[FieldOffset(Offset = "0x60")]
	protected SelectionButton m_RelativeCardSbtn;

	[Token(Token = "0x4002274")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_IsFading;

	[Token(Token = "0x4002275")]
	[FieldOffset(Offset = "0x70")]
	protected ExtendedTextMeshProUGUI m_TitleText;

	[Token(Token = "0x4002276")]
	[FieldOffset(Offset = "0x78")]
	protected FullScreenUiBg m_FullScreenUiBg;

	[Token(Token = "0x4002277")]
	[FieldOffset(Offset = "0x80")]
	protected DeckBrowserForDuel m_DeckBrowserForDuel;

	[Token(Token = "0x4002278")]
	[FieldOffset(Offset = "0x88")]
	protected UiSwitchTweenAnimationController m_UiSwitchTweenAnimationController;

	[Token(Token = "0x4002279")]
	[FieldOffset(Offset = "0x90")]
	public UnityAction onShow;

	[Token(Token = "0x400227A")]
	[FieldOffset(Offset = "0x98")]
	public UnityAction onClose;

	[Token(Token = "0x170005AA")]
	public bool m_IsShowing
	{
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x705030", Offset = "0x704230", VA = "0x180705030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x705070", Offset = "0x704270", VA = "0x180705070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005AB")]
	public string poolKey
	{
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x705040", Offset = "0x704240", VA = "0x180705040", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AC")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x704910", Offset = "0x703B10", VA = "0x180704910", Slot = "12")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x703780", Offset = "0x702980", VA = "0x180703780")]
	public static void Create(Transform parent, UnityAction<int> onClick, bool ismobile, UnityAction<GenericCardListEx> onFinish, bool forOutGame)
	{
	}

	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
	public void SetFullScreenUiBg(FullScreenUiBg fullScreenUiBg)
	{
	}

	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
	public void SetDeckBrowserForDuel(DeckBrowserForDuel deckBrowserForDuel)
	{
	}

	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x704CD0", Offset = "0x703ED0", VA = "0x180704CD0")]
	public void Show()
	{
	}

	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x7036E0", Offset = "0x7028E0", VA = "0x1807036E0")]
	public void Close(bool closebg = true)
	{
	}

	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x704C20", Offset = "0x703E20", VA = "0x180704C20")]
	public void ShowRelativeCardByCardid(int cardid)
	{
	}

	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x703F20", Offset = "0x703120", VA = "0x180703F20")]
	protected void InitializeOnCreated(UnityAction<int> onClick, bool ismobile)
	{
	}

	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x7043F0", Offset = "0x7035F0", VA = "0x1807043F0")]
	protected void Initialize(UnityAction<int> onClick, bool ismobile)
	{
	}

	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x703A00", Offset = "0x702C00", VA = "0x180703A00")]
	private void InitCardInfo(UnityAction<int> onClick, bool ismobile, bool onCreated = true)
	{
	}

	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x703C80", Offset = "0x702E80", VA = "0x180703C80")]
	private void InitTween(GameObject root, GameObject scrollview)
	{
	}

	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x7049F0", Offset = "0x703BF0", VA = "0x1807049F0")]
	private void SetRelativeCardList(int cardid, bool updatelist = true)
	{
	}

	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x704E00", Offset = "0x704000", VA = "0x180704E00")]
	private void UpdateScrollView()
	{
	}

	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x704800", Offset = "0x703A00", VA = "0x180704800", Slot = "4")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6002DB8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void OnItemEntry(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6002DB9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x704640", Offset = "0x703840", VA = "0x180704640", Slot = "7")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x704570", Offset = "0x703770", VA = "0x180704570", Slot = "8")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x704950", Offset = "0x703B50", VA = "0x180704950")]
	private void OnShowEvent()
	{
	}

	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x7044D0", Offset = "0x7036D0", VA = "0x1807044D0")]
	private void OnCloseEvent()
	{
	}

	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public GenericCardListEx()
	{
	}
}
