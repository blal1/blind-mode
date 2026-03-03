using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x200109B")]
public class CardStrip : DeckEditCard
{
	[Token(Token = "0x400B0A4")]
	[FieldOffset(Offset = "0x140")]
	private ExtendedTextMeshProUGUI m_CardInventory;

	[Token(Token = "0x400B0A5")]
	[FieldOffset(Offset = "0x148")]
	private GameObject m_CardInventoryRoot;

	[Token(Token = "0x400B0A6")]
	[FieldOffset(Offset = "0x150")]
	private Image m_InDeckIndicatorRental;

	[Token(Token = "0x400B0A7")]
	[FieldOffset(Offset = "0x158")]
	private Image m_InDeckIndicator1;

	[Token(Token = "0x400B0A8")]
	[FieldOffset(Offset = "0x160")]
	private Image m_InDeckIndicator2;

	[Token(Token = "0x400B0A9")]
	[FieldOffset(Offset = "0x168")]
	private Image m_InDeckIndicator3;

	[Token(Token = "0x400B0AA")]
	[FieldOffset(Offset = "0x170")]
	private int inDeckR;

	[Token(Token = "0x400B0AB")]
	[FieldOffset(Offset = "0x174")]
	private int inDeckN;

	[Token(Token = "0x400B0AC")]
	[FieldOffset(Offset = "0x178")]
	private int inDeckP1;

	[Token(Token = "0x400B0AD")]
	[FieldOffset(Offset = "0x17C")]
	private int inDeckP2;

	[Token(Token = "0x400B0AE")]
	[FieldOffset(Offset = "0x180")]
	private List<Image> m_IndicatorsR;

	[Token(Token = "0x400B0AF")]
	[FieldOffset(Offset = "0x188")]
	private List<Image> m_IndicatorsN;

	[Token(Token = "0x400B0B0")]
	[FieldOffset(Offset = "0x190")]
	private List<Image> m_IndicatorsP1;

	[Token(Token = "0x400B0B1")]
	[FieldOffset(Offset = "0x198")]
	private List<Image> m_IndicatorsP2;

	[Token(Token = "0x400B0B2")]
	[FieldOffset(Offset = "0x1A0")]
	private int inDeckAlterR;

	[Token(Token = "0x400B0B3")]
	[FieldOffset(Offset = "0x1A4")]
	private int inDeckAlterN;

	[Token(Token = "0x400B0B4")]
	[FieldOffset(Offset = "0x1A8")]
	private int inDeckAlterP1;

	[Token(Token = "0x400B0B5")]
	[FieldOffset(Offset = "0x1AC")]
	private int inDeckAlterP2;

	[Token(Token = "0x400B0B6")]
	[FieldOffset(Offset = "0x1B0")]
	private List<Image> m_IndicatorsAlterR;

	[Token(Token = "0x400B0B7")]
	[FieldOffset(Offset = "0x1B8")]
	private List<Image> m_IndicatorsAlterN;

	[Token(Token = "0x400B0B8")]
	[FieldOffset(Offset = "0x1C0")]
	private List<Image> m_IndicatorsAlterP1;

	[Token(Token = "0x400B0B9")]
	[FieldOffset(Offset = "0x1C8")]
	private List<Image> m_IndicatorsAlterP2;

	[Token(Token = "0x400B0BA")]
	[FieldOffset(Offset = "0x1D0")]
	private GameObject m_LockIcon;

	[Token(Token = "0x400B0BB")]
	[FieldOffset(Offset = "0x1D8")]
	private bool isIni;

	[Token(Token = "0x60066A5")]
	[Address(RVA = "0xABA0E0", Offset = "0xAB92E0", VA = "0x180ABA0E0")]
	protected new void InitializeElemnts()
	{
	}

	[Token(Token = "0x60066A6")]
	[Address(RVA = "0xABA0B0", Offset = "0xAB92B0", VA = "0x180ABA0B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60066A7")]
	[Address(RVA = "0xABB2D0", Offset = "0xABA4D0", VA = "0x180ABB2D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60066A8")]
	[Address(RVA = "0xABA540", Offset = "0xAB9740", VA = "0x180ABA540")]
	public void SetCardInventory(bool nonPrizeOnly = false)
	{
	}

	[Token(Token = "0x60066A9")]
	[Address(RVA = "0xABA610", Offset = "0xAB9810", VA = "0x180ABA610")]
	public void SetCardInventory(int num)
	{
	}

	[Token(Token = "0x60066AA")]
	[Address(RVA = "0xABA520", Offset = "0xAB9720", VA = "0x180ABA520")]
	public void SetCardInventoryDisp(bool show)
	{
	}

	[Token(Token = "0x60066AB")]
	[Address(RVA = "0xABAEE0", Offset = "0xABA0E0", VA = "0x180ABAEE0")]
	public void SetInDeckSum(int numN, int alterN, int numP1, int alterP1, int numP2, int alterP2, int numRental, int alterR)
	{
	}

	[Token(Token = "0x60066AC")]
	[Address(RVA = "0xAB9E20", Offset = "0xAB9020", VA = "0x180AB9E20")]
	private void AdjustIndicator(int oldNum, int newNum, List<Image> list, Image template, bool isAlter = false)
	{
	}

	[Token(Token = "0x60066AD")]
	[Address(RVA = "0xABA6D0", Offset = "0xAB98D0", VA = "0x180ABA6D0")]
	public void SetInDeckIndicatorColor(bool isFull)
	{
	}

	[Token(Token = "0x60066AE")]
	[Address(RVA = "0xABA690", Offset = "0xAB9890", VA = "0x180ABA690", Slot = "19")]
	public override void SetData(CardBaseData baseData, int regulationID, DeckEditViewController2.DisplayMode mode = DeckEditViewController2.DisplayMode.Simple)
	{
	}

	[Token(Token = "0x60066AF")]
	[Address(RVA = "0xABA340", Offset = "0xAB9540", VA = "0x180ABA340")]
	public new void ScalingIcons(float scale = 1.5f)
	{
	}

	[Token(Token = "0x60066B0")]
	[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
	public SelectionItem GetSelectionItem()
	{
		return null;
	}

	[Token(Token = "0x60066B1")]
	[Address(RVA = "0xABB0F0", Offset = "0xABA2F0", VA = "0x180ABB0F0")]
	public void SetLimitIcon(CardCollectionInfo.Regulation limit)
	{
	}

	[Token(Token = "0x60066B2")]
	[Address(RVA = "0xABB220", Offset = "0xABA420", VA = "0x180ABB220")]
	public void SetLockIcon(CardBaseData baseData, bool isDismantleMode)
	{
	}

	[Token(Token = "0x60066B3")]
	[Address(RVA = "0xABB5C0", Offset = "0xABA7C0", VA = "0x180ABB5C0")]
	public CardStrip()
	{
	}
}
