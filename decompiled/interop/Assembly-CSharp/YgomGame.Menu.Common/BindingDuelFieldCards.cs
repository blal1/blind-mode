using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Certification;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001420")]
public class BindingDuelFieldCards : MonoBehaviour
{
	[Token(Token = "0x2001421")]
	private enum FieldPostion
	{
		[Token(Token = "0x400C54E")]
		monsterLeft2,
		[Token(Token = "0x400C54F")]
		monsterLeft1,
		[Token(Token = "0x400C550")]
		monsterCenter,
		[Token(Token = "0x400C551")]
		monsterRight1,
		[Token(Token = "0x400C552")]
		monsterRight2,
		[Token(Token = "0x400C553")]
		ExLeft,
		[Token(Token = "0x400C554")]
		ExRight,
		[Token(Token = "0x400C555")]
		MagicLeft2,
		[Token(Token = "0x400C556")]
		MagicLeft1,
		[Token(Token = "0x400C557")]
		MagicCenter,
		[Token(Token = "0x400C558")]
		MagicRight1,
		[Token(Token = "0x400C559")]
		MagicRight2,
		[Token(Token = "0x400C55A")]
		Field,
		[Token(Token = "0x400C55B")]
		Hand,
		[Token(Token = "0x400C55C")]
		DeckEx,
		[Token(Token = "0x400C55D")]
		Deck,
		[Token(Token = "0x400C55E")]
		Grave,
		[Token(Token = "0x400C55F")]
		exclusion,
		[Token(Token = "0x400C560")]
		special
	}

	[Token(Token = "0x2001422")]
	private class XyzCard
	{
		[Token(Token = "0x400C561")]
		[FieldOffset(Offset = "0x10")]
		public int fieldPos;

		[Token(Token = "0x400C562")]
		[FieldOffset(Offset = "0x14")]
		public int faceMrk;

		[Token(Token = "0x400C563")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, int> xyzMat;

		[Token(Token = "0x6007D40")]
		[Address(RVA = "0xC6A6B0", Offset = "0xC698B0", VA = "0x180C6A6B0")]
		public XyzCard()
		{
		}
	}

	[Token(Token = "0x400C526")]
	[FieldOffset(Offset = "0x20")]
	protected string jsonData;

	[Token(Token = "0x400C527")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected long dataID;

	[Token(Token = "0x400C528")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool StartOnAwake;

	[Token(Token = "0x400C529")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool isField;

	[Token(Token = "0x400C52A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private HandLayout playerHand;

	[Token(Token = "0x400C52B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private HandLayout enemyHand;

	[Token(Token = "0x400C52C")]
	[FieldOffset(Offset = "0x48")]
	private DuelSnapshotSetting.DuelSnapshot duelSnapshot;

	[Token(Token = "0x400C52D")]
	[FieldOffset(Offset = "0x50")]
	private CertificationDuelFieldSettings settings;

	[Token(Token = "0x400C52E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ElementObjectManager cardList;

	[Token(Token = "0x400C52F")]
	[FieldOffset(Offset = "0x60")]
	private InfinityScrollView m_isv;

	[Token(Token = "0x400C530")]
	[FieldOffset(Offset = "0x68")]
	private List<int> cardListMrks;

	[Token(Token = "0x400C531")]
	[FieldOffset(Offset = "0x70")]
	private readonly string L_MonsterMaterialsRoot;

	[Token(Token = "0x400C532")]
	[FieldOffset(Offset = "0x78")]
	private readonly string L_HandArea;

	[Token(Token = "0x400C533")]
	[FieldOffset(Offset = "0x80")]
	private readonly string L_Text;

	[Token(Token = "0x400C534")]
	[FieldOffset(Offset = "0x88")]
	private bool isInit;

	[Token(Token = "0x400C535")]
	[FieldOffset(Offset = "0x89")]
	private bool isLoaded;

	[Token(Token = "0x400C536")]
	[FieldOffset(Offset = "0x8A")]
	private bool isCreated;

	[Token(Token = "0x400C537")]
	[FieldOffset(Offset = "0x8B")]
	private bool isApply;

	[Token(Token = "0x400C538")]
	[FieldOffset(Offset = "0x90")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400C539")]
	[FieldOffset(Offset = "0x98")]
	private ElementObjectManager playerEom;

	[Token(Token = "0x400C53A")]
	[FieldOffset(Offset = "0xA0")]
	private ElementObjectManager enemyEom;

	[Token(Token = "0x400C53B")]
	[FieldOffset(Offset = "0xA8")]
	private Tween m_TweenClose;

	[Token(Token = "0x400C53C")]
	[FieldOffset(Offset = "0xB0")]
	private Tween m_TweenOpen;

	[Token(Token = "0x400C53D")]
	[FieldOffset(Offset = "0xB8")]
	private SelectionButton _bgButton;

	[Token(Token = "0x400C53E")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<string, DuelSnapshotSetting.SnapshotInfo> cardExistPos;

	[Token(Token = "0x400C53F")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<string, XyzCard> xyzCardDic;

	[Token(Token = "0x400C540")]
	[FieldOffset(Offset = "0xD0")]
	private List<SelectionButton> _buttons;

	[Token(Token = "0x400C541")]
	[FieldOffset(Offset = "0xD8")]
	public bool interactableButtonsAfterApply;

	[Token(Token = "0x400C542")]
	[FieldOffset(Offset = "0xD9")]
	public bool interactableBGButtonAfterApply;

	[Token(Token = "0x400C543")]
	[FieldOffset(Offset = "0xDA")]
	public bool interactableCardList;

	[Token(Token = "0x400C544")]
	[FieldOffset(Offset = "0xDB")]
	public bool setTransitionModeNone;

	[Token(Token = "0x400C545")]
	[FieldOffset(Offset = "0xE0")]
	public Dictionary<string, object> args;

	[Token(Token = "0x400C546")]
	[FieldOffset(Offset = "0xE8")]
	public Action OnLoadedAction;

	[Token(Token = "0x400C547")]
	[FieldOffset(Offset = "0xF0")]
	public float flexFlabellateRadiusPerScreen;

	[Token(Token = "0x400C548")]
	[FieldOffset(Offset = "0xF4")]
	public float parentHeight;

	[Token(Token = "0x400C549")]
	[FieldOffset(Offset = "0xF8")]
	private List<SelectionButton> myHandCards;

	[Token(Token = "0x400C54A")]
	[FieldOffset(Offset = "0x100")]
	private List<SelectionButton> enemyHandCards;

	[Token(Token = "0x400C54B")]
	[FieldOffset(Offset = "0x108")]
	private bool isShowCardListWindow;

	[Token(Token = "0x400C54C")]
	[FieldOffset(Offset = "0x110")]
	private List<CertificationDuelFieldSettings.IconData> iconDataList;

	[Token(Token = "0x1700132B")]
	public SelectionButton bgButton
	{
		[Token(Token = "0x6007D25")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700132C")]
	public List<SelectionButton> buttons
	{
		[Token(Token = "0x6007D26")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007D27")]
	[Address(RVA = "0xC59BA0", Offset = "0xC58DA0", VA = "0x180C59BA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6007D28")]
	[Address(RVA = "0xC58790", Offset = "0xC57990", VA = "0x180C58790")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007D29")]
	[Address(RVA = "0xC58350", Offset = "0xC57550", VA = "0x180C58350")]
	private void Initialized()
	{
	}

	[Token(Token = "0x6007D2A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnCreated(GameObject temp)
	{
	}

	[Token(Token = "0x6007D2B")]
	[Address(RVA = "0xC587B0", Offset = "0xC579B0", VA = "0x180C587B0")]
	private void OnUpdate(GameObject temp, int index)
	{
	}

	[Token(Token = "0x6007D2C")]
	[Address(RVA = "0xC59330", Offset = "0xC58530", VA = "0x180C59330")]
	private void SetPlayersFieldButton(ElementObjectManager target, bool isPlayer)
	{
	}

	[Token(Token = "0x6007D2D")]
	[Address(RVA = "0xC58F80", Offset = "0xC58180", VA = "0x180C58F80")]
	private void SetGraveButton(ElementObjectManager target, bool isExclusion = false)
	{
	}

	[Token(Token = "0x6007D2E")]
	[Address(RVA = "0xC58A00", Offset = "0xC57C00", VA = "0x180C58A00")]
	private void PlayCardListTween()
	{
	}

	[Token(Token = "0x6007D2F")]
	[Address(RVA = "0xC59B60", Offset = "0xC58D60", VA = "0x180C59B60")]
	private void SetUpFieldElement()
	{
	}

	[Token(Token = "0x6007D30")]
	[Address(RVA = "0xC59BC0", Offset = "0xC58DC0", VA = "0x180C59BC0")]
	private void TrySelectHandCard(GameObject from, bool isMyHand)
	{
	}

	[Token(Token = "0x6007D31")]
	[Address(RVA = "0xC58A70", Offset = "0xC57C70", VA = "0x180C58A70")]
	private void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007D32")]
	[Address(RVA = "0xC5A4F0", Offset = "0xC596F0", VA = "0x180C5A4F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6007D33")]
	[Address(RVA = "0xC58E20", Offset = "0xC58020", VA = "0x180C58E20")]
	private void SetCardData()
	{
	}

	[Token(Token = "0x6007D34")]
	[Address(RVA = "0xC57710", Offset = "0xC56910", VA = "0x180C57710")]
	private void CreateCardsFromDic()
	{
	}

	[Token(Token = "0x6007D35")]
	[Address(RVA = "0xC58E90", Offset = "0xC58090", VA = "0x180C58E90")]
	private void SetFieldIcon()
	{
	}

	[Token(Token = "0x6007D36")]
	[Address(RVA = "0xC58DC0", Offset = "0xC57FC0", VA = "0x180C58DC0")]
	private void SetAdditionaInfo()
	{
	}

	[Token(Token = "0x6007D37")]
	[Address(RVA = "0xC571E0", Offset = "0xC563E0", VA = "0x180C571E0")]
	private void BindCard(GameObject eo, DuelSnapshotSetting.SnapshotInfo card, int playerId, bool isHandCard = false)
	{
	}

	[Token(Token = "0x6007D38")]
	[Address(RVA = "0xC5A030", Offset = "0xC59230", VA = "0x180C5A030")]
	private void TurnCard(GameObject obj)
	{
	}

	[Token(Token = "0x6007D39")]
	[Address(RVA = "0xC5A090", Offset = "0xC59290", VA = "0x180C5A090")]
	private void TurnExCard(GameObject obj)
	{
	}

	[Token(Token = "0x6007D3A")]
	[Address(RVA = "0xC59200", Offset = "0xC58400", VA = "0x180C59200")]
	public void SetInteractButtons(bool frag)
	{
	}

	[Token(Token = "0x6007D3B")]
	[Address(RVA = "0xC58CD0", Offset = "0xC57ED0", VA = "0x180C58CD0")]
	public void RefleshHandLayout()
	{
	}

	[Token(Token = "0x6007D3C")]
	[Address(RVA = "0xC5A500", Offset = "0xC59700", VA = "0x180C5A500")]
	public BindingDuelFieldCards()
	{
	}
}
