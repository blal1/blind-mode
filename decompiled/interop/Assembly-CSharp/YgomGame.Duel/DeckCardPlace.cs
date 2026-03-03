using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019A0")]
public class DeckCardPlace : CardPlace
{
	[Token(Token = "0x20019A1")]
	private enum Step
	{
		[Token(Token = "0x400ED53")]
		Idle,
		[Token(Token = "0x400ED54")]
		WaitReverse,
		[Token(Token = "0x400ED55")]
		WaitLoad1stCard,
		[Token(Token = "0x400ED56")]
		FinishSync
	}

	[Token(Token = "0x20019A2")]
	private enum ShuffleStep
	{
		[Token(Token = "0x400ED58")]
		Idle,
		[Token(Token = "0x400ED59")]
		InitShuffleDeck,
		[Token(Token = "0x400ED5A")]
		WaitShuffleBeforeReverse,
		[Token(Token = "0x400ED5B")]
		StartShuffle,
		[Token(Token = "0x400ED5C")]
		WaitShuffle,
		[Token(Token = "0x400ED5D")]
		WaitEndShuffle,
		[Token(Token = "0x400ED5E")]
		WaitShuffleAfterReverse,
		[Token(Token = "0x400ED5F")]
		TermShuffle
	}

	[Token(Token = "0x20019A3")]
	public struct Trans3D
	{
		[Token(Token = "0x400ED60")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x400ED61")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion rotation;

		[Token(Token = "0x400ED62")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 scale;

		[Token(Token = "0x600A4D2")]
		[Address(RVA = "0xF2E030", Offset = "0xF2D230", VA = "0x180F2E030")]
		public Trans3D(Vector3 pos, Quaternion rot, Vector3 sca)
		{
		}
	}

	[Token(Token = "0x400ED27")]
	[FieldOffset(Offset = "0x88")]
	protected CardLocator cardLocator1st;

	[Token(Token = "0x400ED28")]
	[FieldOffset(Offset = "0x90")]
	private Step step;

	[Token(Token = "0x400ED29")]
	[FieldOffset(Offset = "0x94")]
	private ShuffleStep shuffleStep;

	[Token(Token = "0x400ED2A")]
	[FieldOffset(Offset = "0x98")]
	private string name;

	[Token(Token = "0x400ED2B")]
	[FieldOffset(Offset = "0xA0")]
	private UnityEngine.Object srcObject;

	[Token(Token = "0x400ED2C")]
	[FieldOffset(Offset = "0xA8")]
	private SimpleEffect highlightEff;

	[Token(Token = "0x400ED2D")]
	[FieldOffset(Offset = "0xB0")]
	private Action onFinishedSync;

	[Token(Token = "0x400ED2E")]
	[FieldOffset(Offset = "0xB8")]
	private DeckPlaceStatus deckStatus;

	[Token(Token = "0x400ED2F")]
	[FieldOffset(Offset = "0xC0")]
	private bool showDetailStatus;

	[Token(Token = "0x400ED30")]
	[FieldOffset(Offset = "0xC8")]
	private List<MeshRenderer> boxRenderers;

	[Token(Token = "0x400ED31")]
	[FieldOffset(Offset = "0xD0")]
	private Trans3D defaultAnchorTrans;

	[Token(Token = "0x400ED33")]
	[FieldOffset(Offset = "0xFC")]
	private Vector3 defaultAnchorPos;

	[Token(Token = "0x400ED34")]
	[FieldOffset(Offset = "0x108")]
	private Quaternion defaultAnchorRot;

	[Token(Token = "0x400ED35")]
	[FieldOffset(Offset = "0x118")]
	private GameObject shuffleDeck;

	[Token(Token = "0x400ED36")]
	[FieldOffset(Offset = "0x120")]
	private Transform root;

	[Token(Token = "0x400ED37")]
	[FieldOffset(Offset = "0x128")]
	private Action onFinishedShuffle;

	[Token(Token = "0x400ED38")]
	[FieldOffset(Offset = "0x130")]
	private Animator boxAnim;

	[Token(Token = "0x400ED39")]
	[FieldOffset(Offset = "0x138")]
	private Queue<float> seQueue;

	[Token(Token = "0x400ED3A")]
	[FieldOffset(Offset = "0x140")]
	private float time;

	[Token(Token = "0x400ED3B")]
	[FieldOffset(Offset = "0x144")]
	private bool isSync;

	[Token(Token = "0x400ED3D")]
	[FieldOffset(Offset = "0x14C")]
	private bool reverse;

	[Token(Token = "0x400ED3E")]
	[FieldOffset(Offset = "0x150")]
	private int topSleeveID;

	[Token(Token = "0x400ED3F")]
	[FieldOffset(Offset = "0x154")]
	private int topCardID;

	[Token(Token = "0x400ED40")]
	[FieldOffset(Offset = "0x158")]
	private int topUniqueID;

	[Token(Token = "0x400ED41")]
	[FieldOffset(Offset = "0x15C")]
	private bool topFace;

	[Token(Token = "0x400ED42")]
	[FieldOffset(Offset = "0x160")]
	private ChainedBezierMotion reverseMotion;

	[Token(Token = "0x400ED43")]
	[FieldOffset(Offset = "0x168")]
	private float reverseTime;

	[Token(Token = "0x400ED44")]
	private const int invalidIndex = -1;

	[Token(Token = "0x400ED45")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 cardOfsOfOne;

	[Token(Token = "0x400ED46")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int anim_Shuffle;

	[Token(Token = "0x400ED47")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int anim_Idle;

	[Token(Token = "0x400ED48")]
	[FieldOffset(Offset = "0x16C")]
	private bool effectActivation;

	[Token(Token = "0x400ED49")]
	[FieldOffset(Offset = "0x16D")]
	private bool lethalEffectPlayed;

	[Token(Token = "0x400ED4B")]
	private const string deckModelResPath = "Duel/Models/DeckModelWrapper";

	[Token(Token = "0x17001921")]
	public int localTopCardIndex
	{
		[Token(Token = "0x600A47C")]
		[Address(RVA = "0xA2A100", Offset = "0xA29300", VA = "0x180A2A100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A47D")]
		[Address(RVA = "0xA2A540", Offset = "0xA29740", VA = "0x180A2A540")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001922")]
	public int localCardNum
	{
		[Token(Token = "0x600A47E")]
		[Address(RVA = "0xF14260", Offset = "0xF13460", VA = "0x180F14260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A47F")]
		[Address(RVA = "0xF14290", Offset = "0xF13490", VA = "0x180F14290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001923")]
	private int defaultSleeveID
	{
		[Token(Token = "0x600A480")]
		[Address(RVA = "0xF141C0", Offset = "0xF133C0", VA = "0x180F141C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001924")]
	public SharedDefinition.Location location
	{
		[Token(Token = "0x600A481")]
		[Address(RVA = "0x5E55F0", Offset = "0x5E47F0", VA = "0x1805E55F0")]
		[CompilerGenerated]
		get
		{
			return default(SharedDefinition.Location);
		}
		[Token(Token = "0x600A482")]
		[Address(RVA = "0x5E5680", Offset = "0x5E4880", VA = "0x1805E5680")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001925")]
	public GameObject anchor
	{
		[Token(Token = "0x600A498")]
		[Address(RVA = "0xEB35C0", Offset = "0xEB27C0", VA = "0x180EB35C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A497")]
		[Address(RVA = "0xEB2820", Offset = "0xEB1A20", VA = "0x180EB2820")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001926")]
	public GameObject box
	{
		[Token(Token = "0x600A49A")]
		[Address(RVA = "0xEB3600", Offset = "0xEB2800", VA = "0x180EB3600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A499")]
		[Address(RVA = "0xEB36F0", Offset = "0xEB28F0", VA = "0x180EB36F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001927")]
	public MeshRenderer boxBeforeTopRenderer
	{
		[Token(Token = "0x600A49C")]
		[Address(RVA = "0xEB36C0", Offset = "0xEB28C0", VA = "0x180EB36C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A49B")]
		[Address(RVA = "0xEB3760", Offset = "0xEB2960", VA = "0x180EB3760")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001928")]
	private MeshRenderer boxFirstTopRenderer
	{
		[Token(Token = "0x600A49D")]
		[Address(RVA = "0xF14050", Offset = "0xF13250", VA = "0x180F14050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001929")]
	private MeshRenderer boxSecondTopRenderer
	{
		[Token(Token = "0x600A49E")]
		[Address(RVA = "0xF140F0", Offset = "0xF132F0", VA = "0x180F140F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192A")]
	private MeshRenderer boxThirdTopRenderer
	{
		[Token(Token = "0x600A49F")]
		[Address(RVA = "0xF14140", Offset = "0xF13340", VA = "0x180F14140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192B")]
	private MeshRenderer boxForthTopRenderer
	{
		[Token(Token = "0x600A4A0")]
		[Address(RVA = "0xF140A0", Offset = "0xF132A0", VA = "0x180F140A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192C")]
	public MeshRenderer boxAfterTopRenderer
	{
		[Token(Token = "0x600A4A5")]
		[Address(RVA = "0xAE41E0", Offset = "0xAE33E0", VA = "0x180AE41E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A4A4")]
		[Address(RVA = "0xAE4560", Offset = "0xAE3760", VA = "0x180AE4560")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700192D")]
	public MeshRenderer boxTopRenderer
	{
		[Token(Token = "0x600A4A6")]
		[Address(RVA = "0xF14050", Offset = "0xF13250", VA = "0x180F14050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192E")]
	public CardRoot top
	{
		[Token(Token = "0x600A4A7")]
		[Address(RVA = "0xAE41F0", Offset = "0xAE33F0", VA = "0x180AE41F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A4A8")]
		[Address(RVA = "0xA91060", Offset = "0xA90260", VA = "0x180A91060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700192F")]
	private float deckHeightScaler
	{
		[Token(Token = "0x600A4B9")]
		[Address(RVA = "0xF14190", Offset = "0xF13390", VA = "0x180F14190")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001930")]
	public float adjustedDeckHeightScaler
	{
		[Token(Token = "0x600A4BA")]
		[Address(RVA = "0xF13FF0", Offset = "0xF131F0", VA = "0x180F13FF0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001931")]
	private int indexToDownValue
	{
		[Token(Token = "0x600A4C2")]
		[Address(RVA = "0xF14240", Offset = "0xF13440", VA = "0x180F14240")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001932")]
	public Vector3 posOfNumCardsStatus
	{
		[Token(Token = "0x600A4C5")]
		[Address(RVA = "0xF14270", Offset = "0xF13470", VA = "0x180F14270")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600A4C6")]
		[Address(RVA = "0xF142A0", Offset = "0xF134A0", VA = "0x180F142A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001933")]
	public int bottomIndex
	{
		[Token(Token = "0x600A4C8")]
		[Address(RVA = "0xF14030", Offset = "0xF13230", VA = "0x180F14030")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001934")]
	public Vector3 highLightEffLocalScale
	{
		[Token(Token = "0x600A4CA")]
		[Address(RVA = "0xF14210", Offset = "0xF13410", VA = "0x180F14210")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600A483")]
	[Address(RVA = "0xF13C50", Offset = "0xF12E50", VA = "0x180F13C50")]
	public DeckCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor, string name, SharedDefinition.Location location)
	{
	}

	[Token(Token = "0x600A484")]
	[Address(RVA = "0xF118E0", Offset = "0xF10AE0", VA = "0x180F118E0", Slot = "16")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x600A485")]
	[Address(RVA = "0xF11D40", Offset = "0xF10F40", VA = "0x180F11D40", Slot = "5")]
	public override bool UpdateInitialize()
	{
		return default(bool);
	}

	[Token(Token = "0x600A486")]
	[Address(RVA = "0xF12D50", Offset = "0xF11F50", VA = "0x180F12D50", Slot = "6")]
	public override bool UpdateTerminate()
	{
		return default(bool);
	}

	[Token(Token = "0x600A487")]
	[Address(RVA = "0xF0E720", Offset = "0xF0D920", VA = "0x180F0E720", Slot = "17")]
	protected override void OnPrepareToDuel(bool startAtZero, Action onFinished)
	{
	}

	[Token(Token = "0x600A488")]
	[Address(RVA = "0xF0EC90", Offset = "0xF0DE90", VA = "0x180F0EC90", Slot = "18")]
	protected override void OnShowUp(bool playEffect, Action onFinished)
	{
	}

	[Token(Token = "0x600A489")]
	[Address(RVA = "0xF0CBB0", Offset = "0xF0BDB0", VA = "0x180F0CBB0", Slot = "7")]
	public override CardLocator GetCardLocator(int index, bool create, bool insert)
	{
		return null;
	}

	[Token(Token = "0x600A48A")]
	[Address(RVA = "0xF10570", Offset = "0xF0F770", VA = "0x180F10570", Slot = "26")]
	protected override void ShuffleImpl(Action onFinished)
	{
	}

	[Token(Token = "0x600A48B")]
	[Address(RVA = "0xF0E930", Offset = "0xF0DB30", VA = "0x180F0E930", Slot = "13")]
	protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600A48C")]
	[Address(RVA = "0xF0F1C0", Offset = "0xF0E3C0", VA = "0x180F0F1C0", Slot = "14")]
	protected override void OnUnregister(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A48D")]
	[Address(RVA = "0xF0E530", Offset = "0xF0D730", VA = "0x180F0E530", Slot = "12")]
	protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x600A48E")]
	[Address(RVA = "0xF0E4C0", Offset = "0xF0D6C0", VA = "0x180F0E4C0", Slot = "11")]
	protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return null;
	}

	[Token(Token = "0x600A48F")]
	[Address(RVA = "0xF12C70", Offset = "0xF11E70", VA = "0x180F12C70")]
	private void UpdatePopUpText()
	{
	}

	[Token(Token = "0x600A490")]
	[Address(RVA = "0xF0E310", Offset = "0xF0D510", VA = "0x180F0E310")]
	private CardRoot LoadCardRootToLocator(CardLocator cardLocator, int cardID, int uniqueID, bool isFace, int sleeveID = -1)
	{
		return null;
	}

	[Token(Token = "0x600A491")]
	[Address(RVA = "0xF0FD10", Offset = "0xF0EF10", VA = "0x180F0FD10", Slot = "28")]
	protected override void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600A492")]
	[Address(RVA = "0xF10120", Offset = "0xF0F320", VA = "0x180F10120")]
	private void SetDispHighlightEffect(bool disp)
	{
	}

	[Token(Token = "0x600A493")]
	[Address(RVA = "0xF0F9F0", Offset = "0xF0EBF0", VA = "0x180F0F9F0", Slot = "31")]
	protected override void ReqDecideEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A494")]
	[Address(RVA = "0xF0CB30", Offset = "0xF0BD30", VA = "0x180F0CB30", Slot = "30")]
	protected override void FlipTurnStartImpl(CardRoot cardRoot, bool isFace)
	{
	}

	[Token(Token = "0x600A495")]
	[Address(RVA = "0xF0F200", Offset = "0xF0E400", VA = "0x180F0F200", Slot = "4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600A496")]
	[Address(RVA = "0xF0CFA0", Offset = "0xF0C1A0", VA = "0x180F0CFA0", Slot = "15")]
	public override Vector3 GetScreenPos(int index, Vector2 ofsRate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A4A1")]
	[Address(RVA = "0xF0CF30", Offset = "0xF0C130", VA = "0x180F0CF30")]
	public Trans3D GetDefaultAnchorTransform()
	{
		return default(Trans3D);
	}

	[Token(Token = "0x600A4A2")]
	[Address(RVA = "0xF10000", Offset = "0xF0F200", VA = "0x180F10000")]
	public void ResetAnchorTransform()
	{
	}

	[Token(Token = "0x600A4A3")]
	[Address(RVA = "0xF100E0", Offset = "0xF0F2E0", VA = "0x180F100E0")]
	public void SetBeforeTopTexture(Texture tex)
	{
	}

	[Token(Token = "0x600A4A9")]
	[Address(RVA = "0xF0D160", Offset = "0xF0C360", VA = "0x180F0D160")]
	private int GetSleeveID(int uniqueID)
	{
		return default(int);
	}

	[Token(Token = "0x600A4AA")]
	[Address(RVA = "0xF12320", Offset = "0xF11520", VA = "0x180F12320")]
	private void UpdateLocatorIndices()
	{
	}

	[Token(Token = "0x600A4AB")]
	[Address(RVA = "0xF11140", Offset = "0xF10340", VA = "0x180F11140")]
	public void SyncToEngine(Dictionary<string, object> savedEngineParams, Action onFinished, int num = 0)
	{
	}

	[Token(Token = "0x600A4AC")]
	[Address(RVA = "0xF109E0", Offset = "0xF0FBE0", VA = "0x180F109E0")]
	private void StartReverseStep()
	{
	}

	[Token(Token = "0x600A4AD")]
	[Address(RVA = "0xF132A0", Offset = "0xF124A0", VA = "0x180F132A0")]
	private void WaitReverseStep()
	{
	}

	[Token(Token = "0x600A4AE")]
	[Address(RVA = "0xF106D0", Offset = "0xF0F8D0", VA = "0x180F106D0")]
	private void StartLoadCardStep()
	{
	}

	[Token(Token = "0x600A4AF")]
	[Address(RVA = "0xF13290", Offset = "0xF12490", VA = "0x180F13290")]
	private void WaitLoad1stCardStep()
	{
	}

	[Token(Token = "0x600A4B0")]
	[Address(RVA = "0xF0CA70", Offset = "0xF0BC70", VA = "0x180F0CA70")]
	private void FinishSyncStep()
	{
	}

	[Token(Token = "0x600A4B1")]
	[Address(RVA = "0xF0D440", Offset = "0xF0C640", VA = "0x180F0D440")]
	private void InitShuffleDeckStep()
	{
	}

	[Token(Token = "0x600A4B2")]
	[Address(RVA = "0xF13550", Offset = "0xF12750", VA = "0x180F13550")]
	private void WaitShuffleBeforeReverseStep()
	{
	}

	[Token(Token = "0x600A4B3")]
	[Address(RVA = "0xF11010", Offset = "0xF10210", VA = "0x180F11010")]
	private void StartShuffleStep()
	{
	}

	[Token(Token = "0x600A4B4")]
	[Address(RVA = "0xF13A00", Offset = "0xF12C00", VA = "0x180F13A00")]
	private void WaitShuffleStep()
	{
	}

	[Token(Token = "0x600A4B5")]
	[Address(RVA = "0xF12D80", Offset = "0xF11F80", VA = "0x180F12D80")]
	private void WaitEndShuffleStep()
	{
	}

	[Token(Token = "0x600A4B6")]
	[Address(RVA = "0xF133C0", Offset = "0xF125C0", VA = "0x180F133C0")]
	private void WaitShuffleAfterReverseStep()
	{
	}

	[Token(Token = "0x600A4B7")]
	[Address(RVA = "0xF11720", Offset = "0xF10920", VA = "0x180F11720")]
	private void TermShuffleStep()
	{
	}

	[Token(Token = "0x600A4B8")]
	[Address(RVA = "0xF12360", Offset = "0xF11560", VA = "0x180F12360")]
	private void UpdateLocator()
	{
	}

	[Token(Token = "0x600A4BB")]
	[Address(RVA = "0xF12460", Offset = "0xF11660", VA = "0x180F12460")]
	public void UpdateParts(bool reqReloadTex = true)
	{
	}

	[Token(Token = "0x600A4BC")]
	[Address(RVA = "0xF10480", Offset = "0xF0F680", VA = "0x180F10480")]
	public void Show()
	{
	}

	[Token(Token = "0x600A4BD")]
	[Address(RVA = "0xF10410", Offset = "0xF0F610", VA = "0x180F10410")]
	public void Show(Vector3 pos)
	{
	}

	[Token(Token = "0x600A4BE")]
	[Address(RVA = "0xF0D370", Offset = "0xF0C570", VA = "0x180F0D370")]
	public Vector3 Hide(bool lethalEffect = false)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A4BF")]
	[Address(RVA = "0xF103E0", Offset = "0xF0F5E0", VA = "0x180F103E0")]
	public void ShowStatusLabel(bool immediate, bool showDetail)
	{
	}

	[Token(Token = "0x600A4C0")]
	[Address(RVA = "0xF0D2C0", Offset = "0xF0C4C0", VA = "0x180F0D2C0")]
	public void HideStatusLabel(bool immediate, bool finishShowDetail = false)
	{
	}

	[Token(Token = "0x600A4C1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void SetInputEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600A4C3")]
	[Address(RVA = "0xF11A90", Offset = "0xF10C90", VA = "0x180F11A90")]
	private void UpdateBoxTopTexture()
	{
	}

	[Token(Token = "0x600A4C4")]
	[Address(RVA = "0xF0C910", Offset = "0xF0BB10", VA = "0x180F0C910")]
	private GameObject DuplicateShuffleDeck()
	{
		return null;
	}

	[Token(Token = "0x600A4C7")]
	[Address(RVA = "0xF0D200", Offset = "0xF0C400", VA = "0x180F0D200", Slot = "23")]
	public override Vector3 GetTypicalPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A4C9")]
	[Address(RVA = "0xF0CF60", Offset = "0xF0C160", VA = "0x180F0CF60")]
	private Vector3 GetScaleY()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A4CB")]
	[Address(RVA = "0xF0EC10", Offset = "0xF0DE10", VA = "0x180F0EC10", Slot = "38")]
	public override void OnSelected()
	{
	}

	[Token(Token = "0x600A4CC")]
	[Address(RVA = "0xF0E410", Offset = "0xF0D610", VA = "0x180F0E410", Slot = "39")]
	public override void OnDeselected()
	{
	}
}
