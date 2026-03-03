using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20018D6")]
public class DuelStatusViewer : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x20018D7")]
	public enum UpdateStatusType
	{
		[Token(Token = "0x400E8C6")]
		None,
		[Token(Token = "0x400E8C7")]
		OnTurnChange
	}

	[Token(Token = "0x20018D8")]
	public struct DuelStatusSideInfo
	{
		[Token(Token = "0x400E8C8")]
		[FieldOffset(Offset = "0x0")]
		public bool canIDoSummon;

		[Token(Token = "0x400E8C9")]
		[FieldOffset(Offset = "0x1")]
		public bool canIDoSpecialSummon;

		[Token(Token = "0x400E8CA")]
		[FieldOffset(Offset = "0x4")]
		public int canIDoPutMonster;

		[Token(Token = "0x400E8CB")]
		[FieldOffset(Offset = "0x8")]
		public int totalAtk;
	}

	[Token(Token = "0x20018D9")]
	public struct DuelStatusInfo
	{
		[Token(Token = "0x400E8CC")]
		[FieldOffset(Offset = "0x0")]
		public DuelStatusSideInfo nearStatus;

		[Token(Token = "0x400E8CD")]
		[FieldOffset(Offset = "0xC")]
		public DuelStatusSideInfo farStatus;

		[Token(Token = "0x400E8CE")]
		[FieldOffset(Offset = "0x18")]
		public Engine.Phase phase;
	}

	[Token(Token = "0x400E8B1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E8B2")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E8B3")]
	[FieldOffset(Offset = "0x30")]
	private DuelGameObjectManager goManager;

	[Token(Token = "0x400E8B4")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager buttonUI;

	[Token(Token = "0x400E8B5")]
	[FieldOffset(Offset = "0x40")]
	private Selector selector;

	[Token(Token = "0x400E8B6")]
	[FieldOffset(Offset = "0x48")]
	private SelectionButton openButton;

	[Token(Token = "0x400E8B7")]
	[FieldOffset(Offset = "0x50")]
	private SummonInfoViewer summonInfoViewer;

	[Token(Token = "0x400E8B8")]
	[FieldOffset(Offset = "0x58")]
	private BattlePhaseInfoViewer battlePhaseInfoViewer;

	[Token(Token = "0x400E8BB")]
	[FieldOffset(Offset = "0x62")]
	public bool isOpen;

	[Token(Token = "0x400E8BC")]
	[FieldOffset(Offset = "0x63")]
	private bool lockDown;

	[Token(Token = "0x400E8BD")]
	[FieldOffset(Offset = "0x68")]
	private List<DeckCardPlace> deckCardPlaces;

	[Token(Token = "0x400E8BE")]
	[FieldOffset(Offset = "0x70")]
	private List<GraveCardPlace> graveCardPlaces;

	[Token(Token = "0x400E8BF")]
	[FieldOffset(Offset = "0x78")]
	private List<HandCardPlace> handCardPlaces;

	[Token(Token = "0x400E8C0")]
	[FieldOffset(Offset = "0x80")]
	private bool initialized;

	[Token(Token = "0x400E8C1")]
	[FieldOffset(Offset = "0x81")]
	private bool initStatus;

	[Token(Token = "0x400E8C2")]
	private const string LABEL_ON = "On";

	[Token(Token = "0x400E8C3")]
	private const string LABEL_OFF = "Off";

	[Token(Token = "0x400E8C4")]
	private const string prefabPath = "Prefabs/Duel/DuelStatusViewer";

	[Token(Token = "0x1700184B")]
	public bool opening
	{
		[Token(Token = "0x600A003")]
		[Address(RVA = "0x91E9C0", Offset = "0x91DBC0", VA = "0x18091E9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A004")]
		[Address(RVA = "0x91E9F0", Offset = "0x91DBF0", VA = "0x18091E9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700184C")]
	public bool reqOpen
	{
		[Token(Token = "0x600A005")]
		[Address(RVA = "0xEDB2C0", Offset = "0xEDA4C0", VA = "0x180EDB2C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A006")]
		[Address(RVA = "0xEDB2D0", Offset = "0xEDA4D0", VA = "0x180EDB2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700184D")]
	public string poolKey
	{
		[Token(Token = "0x600A007")]
		[Address(RVA = "0xEDB290", Offset = "0xEDA490", VA = "0x180EDB290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700184E")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600A009")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A008")]
	[Address(RVA = "0xEDA1C0", Offset = "0xED93C0", VA = "0x180EDA1C0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600A00A")]
	[Address(RVA = "0xED9160", Offset = "0xED8360", VA = "0x180ED9160")]
	public static void Create(DuelGameObjectManager goManager, DuelHUD duelHUD, Transform parent, ElementObjectManager buttonUI, Action<DuelStatusViewer> finishCallback)
	{
	}

	[Token(Token = "0x600A00B")]
	[Address(RVA = "0xED97D0", Offset = "0xED89D0", VA = "0x180ED97D0")]
	private void Initialize(DuelGameObjectManager goManager, DuelHUD duelHUD, ElementObjectManager buttonUI)
	{
	}

	[Token(Token = "0x600A00C")]
	[Address(RVA = "0xEDA320", Offset = "0xED9520", VA = "0x180EDA320")]
	public void Open()
	{
	}

	[Token(Token = "0x600A00D")]
	[Address(RVA = "0xED88C0", Offset = "0xED7AC0", VA = "0x180ED88C0")]
	public void Close()
	{
	}

	[Token(Token = "0x600A00E")]
	[Address(RVA = "0xEDAC90", Offset = "0xED9E90", VA = "0x180EDAC90")]
	private void SetShowStatusDetail(bool show)
	{
	}

	[Token(Token = "0x600A00F")]
	[Address(RVA = "0xEDABC0", Offset = "0xED9DC0", VA = "0x180EDABC0")]
	private void SetShowStatusDetail(int player, bool show)
	{
	}

	[Token(Token = "0x600A010")]
	[Address(RVA = "0xEDA1A0", Offset = "0xED93A0", VA = "0x180EDA1A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600A011")]
	[Address(RVA = "0xEDB130", Offset = "0xEDA330", VA = "0x180EDB130")]
	private void Update()
	{
	}

	[Token(Token = "0x600A012")]
	[Address(RVA = "0xED9610", Offset = "0xED8810", VA = "0x180ED9610")]
	private void InitStatus()
	{
	}

	[Token(Token = "0x600A013")]
	[Address(RVA = "0xEDAF40", Offset = "0xEDA140", VA = "0x180EDAF40")]
	public void UpdateStatus(DuelStatusInfo status, UpdateStatusType updateType = UpdateStatusType.None)
	{
	}

	[Token(Token = "0x600A014")]
	[Address(RVA = "0xEDAE80", Offset = "0xEDA080", VA = "0x180EDAE80")]
	private void UpdateStatus(SharedDefinition.Location location, DuelStatusSideInfo info, Engine.Phase phase, UpdateStatusType updateType = UpdateStatusType.None)
	{
	}

	[Token(Token = "0x600A015")]
	[Address(RVA = "0xEDAD50", Offset = "0xED9F50", VA = "0x180EDAD50")]
	public void UpdateBattlePhaseInfo()
	{
	}

	[Token(Token = "0x600A016")]
	[Address(RVA = "0xED9460", Offset = "0xED8660", VA = "0x180ED9460")]
	public static DuelStatusInfo GetDuelStatusInfo()
	{
		return default(DuelStatusInfo);
	}

	[Token(Token = "0x600A017")]
	[Address(RVA = "0xED93B0", Offset = "0xED85B0", VA = "0x180ED93B0")]
	private static DuelStatusSideInfo GetDuelStatusInfo(int player)
	{
		return default(DuelStatusSideInfo);
	}

	[Token(Token = "0x600A018")]
	[Address(RVA = "0xEDADE0", Offset = "0xED9FE0", VA = "0x180EDADE0")]
	private void UpdateButton()
	{
	}

	[Token(Token = "0x600A019")]
	[Address(RVA = "0xEDAB40", Offset = "0xED9D40", VA = "0x180EDAB40")]
	public void SetDispButton(bool disp)
	{
	}

	[Token(Token = "0x600A01A")]
	[Address(RVA = "0xEDB180", Offset = "0xEDA380", VA = "0x180EDB180")]
	public DuelStatusViewer()
	{
	}
}
