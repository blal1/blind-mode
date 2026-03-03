using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x200185B")]
public class CardInfoDetailForDuel : CardInfoDetail, IGameObjectPool
{
	[Token(Token = "0x400E4BB")]
	protected const string PATH_PREHABFORDUEL = "Prefabs/Duel/UI/CardInfoDetailForDuel";

	[Token(Token = "0x400E4BC")]
	[FieldOffset(Offset = "0x370")]
	private ToggleWidget m_OriginInfoToggle;

	[Token(Token = "0x400E4BD")]
	[FieldOffset(Offset = "0x378")]
	private SelectionButton m_RelativeCardButton;

	[Token(Token = "0x400E4BE")]
	[FieldOffset(Offset = "0x380")]
	private DuelClient m_Host;

	[Token(Token = "0x400E4BF")]
	[FieldOffset(Offset = "0x388")]
	private bool m_BlcokRelatriveCard;

	[Token(Token = "0x170017C3")]
	public string poolKey
	{
		[Token(Token = "0x6009B9B")]
		[Address(RVA = "0xE85270", Offset = "0xE84470", VA = "0x180E85270", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C4")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009B9D")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009B9C")]
	[Address(RVA = "0xE83B70", Offset = "0xE82D70", VA = "0x180E83B70", Slot = "7")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009B9E")]
	[Address(RVA = "0xE83350", Offset = "0xE82550", VA = "0x180E83350")]
	public static void Create(DuelClient host, Transform parent, UnityAction<CardInfoDetailForDuel> finishedCallback)
	{
	}

	[Token(Token = "0x6009B9F")]
	[Address(RVA = "0xE83700", Offset = "0xE82900", VA = "0x180E83700", Slot = "4")]
	protected override void InitializeBase(bool onCreated = true)
	{
	}

	[Token(Token = "0x6009BA0")]
	[Address(RVA = "0xE83820", Offset = "0xE82A20", VA = "0x180E83820")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x6009BA1")]
	[Address(RVA = "0xE83AA0", Offset = "0xE82CA0", VA = "0x180E83AA0")]
	private void OnFinishClose()
	{
	}

	[Token(Token = "0x6009BA2")]
	[Address(RVA = "0xE84810", Offset = "0xE83A10", VA = "0x180E84810")]
	public new void Show()
	{
	}

	[Token(Token = "0x6009BA3")]
	[Address(RVA = "0xE83520", Offset = "0xE82720", VA = "0x180E83520")]
	private void InitToggle()
	{
	}

	[Token(Token = "0x6009BA4")]
	[Address(RVA = "0xE84200", Offset = "0xE83400", VA = "0x180E84200")]
	private void SetCardByOriginalInfo()
	{
	}

	[Token(Token = "0x6009BA5")]
	[Address(RVA = "0xE83F90", Offset = "0xE83190", VA = "0x180E83F90")]
	public new void SetCardByCardInfoData(CardInfoData cardInfoData)
	{
	}

	[Token(Token = "0x6009BA6")]
	[Address(RVA = "0xE83C20", Offset = "0xE82E20", VA = "0x180E83C20")]
	public new void SetCardByCardId(int cardid, int styleid = 1)
	{
	}

	[Token(Token = "0x6009BA7")]
	[Address(RVA = "0xE84510", Offset = "0xE83710", VA = "0x180E84510")]
	public void SetCardByUniqueId(int uniqueId)
	{
	}

	[Token(Token = "0x6009BA8")]
	[Address(RVA = "0xE832F0", Offset = "0xE824F0", VA = "0x180E832F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6009BA9")]
	[Address(RVA = "0xE83A30", Offset = "0xE82C30", VA = "0x180E83A30")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6009BAA")]
	[Address(RVA = "0xE85260", Offset = "0xE84460", VA = "0x180E85260")]
	public CardInfoDetailForDuel()
	{
	}
}
