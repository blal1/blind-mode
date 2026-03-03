using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001A46")]
public abstract class HandCardPlace : CardPlace
{
	[Token(Token = "0x2001A47")]
	private enum ShuffleStep
	{
		[Token(Token = "0x400F28A")]
		Idle,
		[Token(Token = "0x400F28B")]
		Shrink,
		[Token(Token = "0x400F28C")]
		Expand
	}

	[Token(Token = "0x400F26A")]
	[FieldOffset(Offset = "0x88")]
	private ShuffleStep shuffleStep;

	[Token(Token = "0x400F26B")]
	[FieldOffset(Offset = "0x8C")]
	protected float shuffleTimer;

	[Token(Token = "0x400F26C")]
	[FieldOffset(Offset = "0x90")]
	protected Action onFinishedShuffle;

	[Token(Token = "0x400F26D")]
	[FieldOffset(Offset = "0x98")]
	protected float flabellateAngleBase;

	[Token(Token = "0x400F26E")]
	[FieldOffset(Offset = "0x9C")]
	protected float flabellateAngle;

	[Token(Token = "0x400F26F")]
	[FieldOffset(Offset = "0xA0")]
	protected float flabellateAngleLimit;

	[Token(Token = "0x400F270")]
	[FieldOffset(Offset = "0xA4")]
	protected float rate;

	[Token(Token = "0x400F271")]
	[FieldOffset(Offset = "0xA8")]
	protected float flabellateRadiusPerScreen;

	[Token(Token = "0x400F272")]
	[FieldOffset(Offset = "0xAC")]
	private float shuffleTimeShrink;

	[Token(Token = "0x400F273")]
	[FieldOffset(Offset = "0xB0")]
	private float shuffleTimeExpand;

	[Token(Token = "0x400F274")]
	[FieldOffset(Offset = "0xB4")]
	protected Vector3 centerViewport;

	[Token(Token = "0x400F275")]
	[FieldOffset(Offset = "0xC0")]
	protected float centerScale;

	[Token(Token = "0x400F276")]
	[FieldOffset(Offset = "0xC4")]
	protected float centerScaleSmall;

	[Token(Token = "0x400F277")]
	[FieldOffset(Offset = "0xC8")]
	protected float centerHeight;

	[Token(Token = "0x400F278")]
	[FieldOffset(Offset = "0xCC")]
	protected float selectingOffsetLerp;

	[Token(Token = "0x400F279")]
	[FieldOffset(Offset = "0xD0")]
	protected Dictionary<HandCardManager.DispMode, Vector3> centerPositions;

	[Token(Token = "0x400F27A")]
	[FieldOffset(Offset = "0xD8")]
	protected int preSelectIndex;

	[Token(Token = "0x400F27B")]
	[FieldOffset(Offset = "0xDC")]
	protected int preDecideIndex;

	[Token(Token = "0x400F27C")]
	[FieldOffset(Offset = "0xE0")]
	private float _angleOffset;

	[Token(Token = "0x400F27D")]
	[FieldOffset(Offset = "0xE4")]
	private Vector2 preScreenPoint;

	[Token(Token = "0x400F27E")]
	[FieldOffset(Offset = "0xEC")]
	private bool dragAngleScroll;

	[Token(Token = "0x400F27F")]
	[FieldOffset(Offset = "0xED")]
	protected bool isBusy;

	[Token(Token = "0x400F280")]
	[FieldOffset(Offset = "0xF0")]
	protected List<(GameObject parent, SelectionButton item)> selectionItems;

	[Token(Token = "0x400F281")]
	[FieldOffset(Offset = "0xF8")]
	protected GameObject handCardObj;

	[Token(Token = "0x400F282")]
	[FieldOffset(Offset = "0x100")]
	private int createdHandCardCount;

	[Token(Token = "0x400F283")]
	[FieldOffset(Offset = "0x104")]
	protected SharedDefinition.Location location;

	[Token(Token = "0x400F285")]
	[FieldOffset(Offset = "0x110")]
	protected HandCardManager manager;

	[Token(Token = "0x400F286")]
	[FieldOffset(Offset = "0x118")]
	private Selector selector;

	[Token(Token = "0x400F287")]
	[FieldOffset(Offset = "0x120")]
	private bool showDetailStatus;

	[Token(Token = "0x400F288")]
	[FieldOffset(Offset = "0x128")]
	private PlaceStatusLabel statusLabel;

	[Token(Token = "0x17001A49")]
	public abstract int handCardNum
	{
		[Token(Token = "0x600AA5C")]
		get;
	}

	[Token(Token = "0x17001A4A")]
	protected abstract int selectedIndex
	{
		[Token(Token = "0x600AA5D")]
		get;
	}

	[Token(Token = "0x17001A4B")]
	protected abstract int decidedIndex
	{
		[Token(Token = "0x600AA5E")]
		get;
	}

	[Token(Token = "0x17001A4C")]
	protected int selectedViewIndex
	{
		[Token(Token = "0x600AA5F")]
		[Address(RVA = "0xF6EE30", Offset = "0xF6E030", VA = "0x180F6EE30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A4D")]
	protected int decidedViewIndex
	{
		[Token(Token = "0x600AA60")]
		[Address(RVA = "0xF6EDE0", Offset = "0xF6DFE0", VA = "0x180F6EDE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A4E")]
	protected abstract Vector3 locatorOffsetTargetSelecting
	{
		[Token(Token = "0x600AA61")]
		get;
	}

	[Token(Token = "0x17001A4F")]
	protected abstract Vector3 locatorOffsetTargetDeciding
	{
		[Token(Token = "0x600AA62")]
		get;
	}

	[Token(Token = "0x17001A50")]
	public abstract bool isAllOpen
	{
		[Token(Token = "0x600AA63")]
		get;
	}

	[Token(Token = "0x17001A51")]
	protected float angleOffset
	{
		[Token(Token = "0x600AA64")]
		[Address(RVA = "0xF6ED90", Offset = "0xF6DF90", VA = "0x180F6ED90")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AA65")]
		[Address(RVA = "0xF6EE70", Offset = "0xF6E070", VA = "0x180F6EE70")]
		set
		{
		}
	}

	[Token(Token = "0x17001A52")]
	protected float angleOffsetOrg
	{
		[Token(Token = "0x600AA66")]
		[Address(RVA = "0xF6ED80", Offset = "0xF6DF80", VA = "0x180F6ED80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A53")]
	protected float clampedAngleOffset
	{
		[Token(Token = "0x600AA67")]
		[Address(RVA = "0xF6ED90", Offset = "0xF6DF90", VA = "0x180F6ED90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A54")]
	protected virtual HandCardManager.ViewSortMode sortMode
	{
		[Token(Token = "0x600AA68")]
		[Address(RVA = "0xA2A0D0", Offset = "0xA292D0", VA = "0x180A2A0D0", Slot = "48")]
		[CompilerGenerated]
		get
		{
			return default(HandCardManager.ViewSortMode);
		}
	}

	[Token(Token = "0x17001A55")]
	protected override int loadStartIdx
	{
		[Token(Token = "0x600AA81")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A56")]
	protected override int loadIndexIncValue
	{
		[Token(Token = "0x600AA82")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001A57")]
	protected override bool loadIsOver
	{
		[Token(Token = "0x600AA83")]
		[Address(RVA = "0xF6EE20", Offset = "0xF6E020", VA = "0x180F6EE20", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AA69")]
	protected abstract void HighlightImpl(int index, SharedDefinition.ActivateAura auraType);

	[Token(Token = "0x600AA6A")]
	[Address(RVA = "0xF6EB20", Offset = "0xF6DD20", VA = "0x180F6EB20")]
	public HandCardPlace(DuelFieldBase duelField, int team, int position)
	{
	}

	[Token(Token = "0x600AA6B")]
	[Address(RVA = "0xF6AF50", Offset = "0xF6A150", VA = "0x180F6AF50")]
	protected void CreateHandCardObject(string obj_name)
	{
	}

	[Token(Token = "0x600AA6C")]
	[Address(RVA = "0xF6BA60", Offset = "0xF6AC60", VA = "0x180F6BA60", Slot = "15")]
	public override Vector3 GetScreenPos(int index, Vector2 ofsRate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AA6D")]
	[Address(RVA = "0xF6C820", Offset = "0xF6BA20", VA = "0x180F6C820", Slot = "4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600AA6E")]
	[Address(RVA = "0xF6BD20", Offset = "0xF6AF20", VA = "0x180F6BD20")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600AA6F")]
	[Address(RVA = "0xF6B4D0", Offset = "0xF6A6D0", VA = "0x180F6B4D0", Slot = "7")]
	public override CardLocator GetCardLocator(int index, bool create = true, bool insert = false)
	{
		return null;
	}

	[Token(Token = "0x600AA70")]
	[Address(RVA = "0xF6D270", Offset = "0xF6C470", VA = "0x180F6D270")]
	private void SetupSelectionItem(SelectionButton item)
	{
	}

	[Token(Token = "0x600AA71")]
	[Address(RVA = "0xF6D0B0", Offset = "0xF6C2B0", VA = "0x180F6D0B0")]
	public void SetupAngleOffset(int viewIndex)
	{
	}

	[Token(Token = "0x600AA72")]
	[Address(RVA = "0xF6BAA0", Offset = "0xF6ACA0", VA = "0x180F6BAA0")]
	private int GetSelectionItemIndex(SelectionItem item)
	{
		return default(int);
	}

	[Token(Token = "0x600AA73")]
	[Address(RVA = "0xF6BAD0", Offset = "0xF6ACD0", VA = "0x180F6BAD0")]
	private int GetSelectionItemViewIndex(SelectionItem item)
	{
		return default(int);
	}

	[Token(Token = "0x600AA74")]
	protected abstract void SelectNextItem(int index);

	[Token(Token = "0x600AA75")]
	protected abstract void SelectPrevItem(int index);

	[Token(Token = "0x600AA76")]
	[Address(RVA = "0xF6E6A0", Offset = "0xF6D8A0", VA = "0x180F6E6A0")]
	protected void UpdateSelectionItem(GameObject actItemParent, SelectionItem actItem, CardLocator locator)
	{
	}

	[Token(Token = "0x600AA77")]
	[Address(RVA = "0xF6E050", Offset = "0xF6D250", VA = "0x180F6E050")]
	private void UpdateLocatorOffset(CardLocator locator, bool immediate)
	{
	}

	[Token(Token = "0x600AA78")]
	[Address(RVA = "0xF6DF10", Offset = "0xF6D110", VA = "0x180F6DF10")]
	private void UpdateLocatorOffsetAll(bool immediate)
	{
	}

	[Token(Token = "0x600AA79")]
	[Address(RVA = "0xF6C070", Offset = "0xF6B270", VA = "0x180F6C070", Slot = "11")]
	protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return null;
	}

	[Token(Token = "0x600AA7A")]
	[Address(RVA = "0xF6C270", Offset = "0xF6B470", VA = "0x180F6C270", Slot = "12")]
	protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA7B")]
	[Address(RVA = "0xF6ACD0", Offset = "0xF69ED0", VA = "0x180F6ACD0")]
	private void ArrangementLocators()
	{
	}

	[Token(Token = "0x600AA7C")]
	[Address(RVA = "0xF6C7C0", Offset = "0xF6B9C0", VA = "0x180F6C7C0", Slot = "13")]
	protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600AA7D")]
	[Address(RVA = "0xF6C7D0", Offset = "0xF6B9D0", VA = "0x180F6C7D0", Slot = "14")]
	protected override void OnUnregister(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600AA7E")]
	[Address(RVA = "0xF6DAD0", Offset = "0xF6CCD0", VA = "0x180F6DAD0", Slot = "26")]
	protected override void ShuffleImpl(Action onFinished)
	{
	}

	[Token(Token = "0x600AA7F")]
	[Address(RVA = "0xF6E930", Offset = "0xF6DB30", VA = "0x180F6E930")]
	protected void UpdateShuffle()
	{
	}

	[Token(Token = "0x600AA80")]
	[Address(RVA = "0xF6B120", Offset = "0xF6A320", VA = "0x180F6B120", Slot = "32")]
	protected override void EndSacrificeTargetEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600AA84")]
	[Address(RVA = "0xF6C940", Offset = "0xF6BB40", VA = "0x180F6C940", Slot = "28")]
	protected override void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600AA85")]
	[Address(RVA = "0xF6C880", Offset = "0xF6BA80", VA = "0x180F6C880", Slot = "31")]
	protected override void ReqDecideEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600AA86")]
	[Address(RVA = "0xF6B380", Offset = "0xF6A580", VA = "0x180F6B380", Slot = "29")]
	protected override void FlipTurnImpl(int index, bool isFace, bool isAttack, bool immediate, Action onFinished)
	{
	}

	[Token(Token = "0x600AA87")]
	[Address(RVA = "0xF6BBC0", Offset = "0xF6ADC0", VA = "0x180F6BBC0", Slot = "23")]
	public override Vector3 GetTypicalPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AA88")]
	public abstract int UniqueIdToIndex(int uniqueId);

	[Token(Token = "0x600AA89")]
	[Address(RVA = "0xF6DB40", Offset = "0xF6CD40", VA = "0x180F6DB40")]
	protected void SyncEngineHandCardIndex()
	{
	}

	[Token(Token = "0x600AA8A")]
	[Address(RVA = "0xF6DCD0", Offset = "0xF6CED0", VA = "0x180F6DCD0")]
	protected void SyncHandCardIndex(int[] unique_ids)
	{
	}

	[Token(Token = "0x600AA8B")]
	public abstract void GetPosture(int index, out Vector3 position, out Quaternion rotation, out float depth, int card_num = -1, bool originPosition = false);

	[Token(Token = "0x600AA8C")]
	[Address(RVA = "0xF6B8F0", Offset = "0xF6AAF0", VA = "0x180F6B8F0")]
	protected float GetFlabellateAngle(int viewIndex, bool origin, bool baseAngle, bool clamp180 = true)
	{
		return default(float);
	}

	[Token(Token = "0x600AA8D")]
	[Address(RVA = "0xF6B9D0", Offset = "0xF6ABD0", VA = "0x180F6B9D0")]
	protected float GetFlabellateAngle(int viewIndex, int handNum, bool origin, bool baseAngle, bool clamp180 = true)
	{
		return default(float);
	}

	[Token(Token = "0x600AA8E")]
	public abstract void UpdateCenterPosition();

	[Token(Token = "0x600AA8F")]
	[Address(RVA = "0xF6E410", Offset = "0xF6D610", VA = "0x180F6E410", Slot = "8")]
	protected override void UpdateLocators()
	{
	}

	[Token(Token = "0x600AA90")]
	[Address(RVA = "0xF6E260", Offset = "0xF6D460", VA = "0x180F6E260")]
	protected void UpdateLocator(CardLocator actLocator, int index)
	{
	}

	[Token(Token = "0x600AA91")]
	[Address(RVA = "0xF6D1E0", Offset = "0xF6C3E0", VA = "0x180F6D1E0", Slot = "9")]
	protected override void SetupCardLocator(CardLocator cardLocator)
	{
	}

	[Token(Token = "0x600AA92")]
	[Address(RVA = "0xF6CE70", Offset = "0xF6C070", VA = "0x180F6CE70")]
	private void SetCardFloatingMove(bool useFloatingPivot)
	{
	}

	[Token(Token = "0x600AA93")]
	[Address(RVA = "0xF6CBB0", Offset = "0xF6BDB0", VA = "0x180F6CBB0")]
	private void ResetCardPivotPosition()
	{
	}

	[Token(Token = "0x600AA94")]
	[Address(RVA = "0xF6CFE0", Offset = "0xF6C1E0", VA = "0x180F6CFE0")]
	public void SetSort(HandCardManager.ViewSortMode sort, bool select = true)
	{
	}

	[Token(Token = "0x600AA95")]
	protected abstract void SetSortImpl(HandCardManager.ViewSortMode sort);

	[Token(Token = "0x600AA96")]
	[Address(RVA = "0xF6BF90", Offset = "0xF6B190", VA = "0x180F6BF90")]
	public void InsertViewIndex(int targetIndex, int insertViewIndex, bool select)
	{
	}

	[Token(Token = "0x600AA97")]
	protected abstract void InsertViewIndexImpl(int targetIndex, int InsertViewIndex);

	[Token(Token = "0x600AA98")]
	[Address(RVA = "0xF6C830", Offset = "0xF6BA30", VA = "0x180F6C830")]
	public void RefreshCardLocators(bool updateCardPosition)
	{
	}

	[Token(Token = "0x600AA99")]
	protected abstract void RefreshCardLocatorsImpl();

	[Token(Token = "0x600AA9A")]
	[Address(RVA = "0xF6CE20", Offset = "0xF6C020", VA = "0x180F6CE20")]
	public bool Select(int index, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA9B")]
	[Address(RVA = "0xF6CD00", Offset = "0xF6BF00", VA = "0x180F6CD00")]
	public bool SelectByViewIndex(int viewIndex, bool force = false, bool playSE = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA9C")]
	[Address(RVA = "0xF6D990", Offset = "0xF6CB90", VA = "0x180F6D990")]
	public void ShowStatusLabel(bool immediate, bool showDetail)
	{
	}

	[Token(Token = "0x600AA9D")]
	[Address(RVA = "0xF6BC20", Offset = "0xF6AE20", VA = "0x180F6BC20")]
	public void HideStatusLabel(bool immediate, bool finishDetail = false)
	{
	}

	[Token(Token = "0x600AA9E")]
	public abstract void UpdateAllCardPosition();
}
