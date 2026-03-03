using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Stats;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20019BA")]
public class CardReportTelopManager : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x20019BB")]
	private class CardReportTelopTask
	{
		[Token(Token = "0x400EDE1")]
		[FieldOffset(Offset = "0x10")]
		public int cardid;

		[Token(Token = "0x400EDE2")]
		[FieldOffset(Offset = "0x18")]
		public List<CardStatsData> datas;

		[Token(Token = "0x400EDE3")]
		[FieldOffset(Offset = "0x20")]
		public bool testflag;

		[Token(Token = "0x600A57F")]
		[Address(RVA = "0xF1B5B0", Offset = "0xF1A7B0", VA = "0x180F1B5B0")]
		public CardReportTelopTask(int cardid, bool fortest = false)
		{
		}
	}

	[Token(Token = "0x400EDD9")]
	[FieldOffset(Offset = "0x20")]
	private DuelClient m_Host;

	[Token(Token = "0x400EDDA")]
	private const string PREHAB_PATH = "Prefabs/Duel/UI/CardReportTelop";

	[Token(Token = "0x400EDDB")]
	private const int MAX_TELOP_COUNT = 5;

	[Token(Token = "0x400EDDC")]
	[FieldOffset(Offset = "0x28")]
	private Queue<CardReportTelopTask> m_TaskQueue;

	[Token(Token = "0x400EDDD")]
	[FieldOffset(Offset = "0x30")]
	private List<CardReportTelopController> m_TelopList;

	[Token(Token = "0x400EDDE")]
	[FieldOffset(Offset = "0x38")]
	private CardReportTelopTask m_CurrentTask;

	[Token(Token = "0x400EDDF")]
	[FieldOffset(Offset = "0x40")]
	private List<int> m_History;

	[Token(Token = "0x400EDE0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int m_Duration;

	[Token(Token = "0x17001954")]
	public string poolKey
	{
		[Token(Token = "0x600A574")]
		[Address(RVA = "0xF1B580", Offset = "0xF1A780", VA = "0x180F1B580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001955")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A576")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001956")]
	private bool isProcessing
	{
		[Token(Token = "0x600A578")]
		[Address(RVA = "0xF1B460", Offset = "0xF1A660", VA = "0x180F1B460")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A575")]
	[Address(RVA = "0xF1AFF0", Offset = "0xF1A1F0", VA = "0x180F1AFF0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A577")]
	[Address(RVA = "0xF1AB10", Offset = "0xF19D10", VA = "0x180F1AB10")]
	public static void Create(DuelClient host, Transform parent, UnityAction<CardReportTelopManager> onFinish)
	{
	}

	[Token(Token = "0x600A579")]
	[Address(RVA = "0xF1ADB0", Offset = "0xF19FB0", VA = "0x180F1ADB0")]
	private void Initialize(DuelClient host, Transform parent, UnityAction<CardReportTelopManager> onFinish)
	{
	}

	[Token(Token = "0x600A57A")]
	[Address(RVA = "0xF1B160", Offset = "0xF1A360", VA = "0x180F1B160")]
	private void Update()
	{
	}

	[Token(Token = "0x600A57B")]
	[Address(RVA = "0xF1A8C0", Offset = "0xF19AC0", VA = "0x180F1A8C0")]
	public void AddCardReportTelopTask(int cardid)
	{
	}

	[Token(Token = "0x600A57C")]
	[Address(RVA = "0xF1ACB0", Offset = "0xF19EB0", VA = "0x180F1ACB0")]
	public void HideTelopEffect()
	{
	}

	[Token(Token = "0x600A57D")]
	[Address(RVA = "0xF1AAC0", Offset = "0xF19CC0", VA = "0x180F1AAC0")]
	public void ClearHistory()
	{
	}

	[Token(Token = "0x600A57E")]
	[Address(RVA = "0xF1B450", Offset = "0xF1A650", VA = "0x180F1B450")]
	public CardReportTelopManager()
	{
	}
}
