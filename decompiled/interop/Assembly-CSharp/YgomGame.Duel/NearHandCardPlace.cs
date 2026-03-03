using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019B0")]
public class NearHandCardPlace : HandCardPlace
{
	[Token(Token = "0x400ED83")]
	[FieldOffset(Offset = "0x130")]
	private Vector3 centerCameraDelta;

	[Token(Token = "0x400ED84")]
	[FieldOffset(Offset = "0x13C")]
	private float cameraDistance;

	[Token(Token = "0x400ED85")]
	[FieldOffset(Offset = "0x140")]
	private Vector3 centerPosition;

	[Token(Token = "0x400ED86")]
	[FieldOffset(Offset = "0x14C")]
	private Vector3 scale;

	[Token(Token = "0x400ED87")]
	[FieldOffset(Offset = "0x158")]
	private Vector3 targetScale;

	[Token(Token = "0x400ED88")]
	[FieldOffset(Offset = "0x164")]
	private Vector3 modeChangeStartCenterPosition;

	[Token(Token = "0x400ED89")]
	[FieldOffset(Offset = "0x170")]
	private Vector3 modeChangeStartScale;

	[Token(Token = "0x400ED8A")]
	[FieldOffset(Offset = "0x17C")]
	private float modeChangeTime;

	[Token(Token = "0x400ED8B")]
	[FieldOffset(Offset = "0x180")]
	private float modeChangeTimeCounter;

	[Token(Token = "0x400ED8C")]
	[FieldOffset(Offset = "0x184")]
	private Vector3 centerViewportSmall;

	[Token(Token = "0x400ED8D")]
	[FieldOffset(Offset = "0x190")]
	private Vector3 _locatorOffsetTargetDeciding;

	[Token(Token = "0x400ED8E")]
	[FieldOffset(Offset = "0x19C")]
	private Vector3 _locatorOffsetTargetSelecting;

	[Token(Token = "0x1700193D")]
	protected override int selectedIndex
	{
		[Token(Token = "0x600A51A")]
		[Address(RVA = "0xF2DEB0", Offset = "0xF2D0B0", VA = "0x180F2DEB0", Slot = "43")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700193E")]
	protected override int decidedIndex
	{
		[Token(Token = "0x600A51B")]
		[Address(RVA = "0xF2DD80", Offset = "0xF2CF80", VA = "0x180F2DD80", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700193F")]
	public override int handCardNum
	{
		[Token(Token = "0x600A51C")]
		[Address(RVA = "0xF2DE20", Offset = "0xF2D020", VA = "0x180F2DE20", Slot = "42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001940")]
	private Vector3 targetCenterPosition
	{
		[Token(Token = "0x600A51D")]
		[Address(RVA = "0xF2DF90", Offset = "0xF2D190", VA = "0x180F2DF90")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001941")]
	protected override HandCardManager.ViewSortMode sortMode
	{
		[Token(Token = "0x600A51E")]
		[Address(RVA = "0xF2DF50", Offset = "0xF2D150", VA = "0x180F2DF50", Slot = "48")]
		get
		{
			return default(HandCardManager.ViewSortMode);
		}
	}

	[Token(Token = "0x17001942")]
	protected override Vector3 locatorOffsetTargetDeciding
	{
		[Token(Token = "0x600A51F")]
		[Address(RVA = "0xF2DE70", Offset = "0xF2D070", VA = "0x180F2DE70", Slot = "46")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001943")]
	protected override Vector3 locatorOffsetTargetSelecting
	{
		[Token(Token = "0x600A520")]
		[Address(RVA = "0xF2DE90", Offset = "0xF2D090", VA = "0x180F2DE90", Slot = "45")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001944")]
	public override bool isAllOpen
	{
		[Token(Token = "0x600A521")]
		[Address(RVA = "0xF2DE50", Offset = "0xF2D050", VA = "0x180F2DE50", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A522")]
	[Address(RVA = "0xF2D870", Offset = "0xF2CA70", VA = "0x180F2D870")]
	public NearHandCardPlace(DuelFieldBase duelField, int team, int position)
	{
	}

	[Token(Token = "0x600A523")]
	[Address(RVA = "0xF2CFE0", Offset = "0xF2C1E0", VA = "0x180F2CFE0", Slot = "50")]
	protected override void SelectNextItem(int index)
	{
	}

	[Token(Token = "0x600A524")]
	[Address(RVA = "0xF2D0D0", Offset = "0xF2C2D0", VA = "0x180F2D0D0", Slot = "51")]
	protected override void SelectPrevItem(int index)
	{
	}

	[Token(Token = "0x600A525")]
	[Address(RVA = "0xF2CEB0", Offset = "0xF2C0B0", VA = "0x180F2CEB0", Slot = "49")]
	protected override void HighlightImpl(int index, SharedDefinition.ActivateAura auraType)
	{
	}

	[Token(Token = "0x600A526")]
	[Address(RVA = "0xF2CFC0", Offset = "0xF2C1C0", VA = "0x180F2CFC0", Slot = "4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600A527")]
	[Address(RVA = "0xF2D690", Offset = "0xF2C890", VA = "0x180F2D690")]
	private void UpdateCenter()
	{
	}

	[Token(Token = "0x600A528")]
	[Address(RVA = "0xF2D440", Offset = "0xF2C640", VA = "0x180F2D440", Slot = "54")]
	public override void UpdateCenterPosition()
	{
	}

	[Token(Token = "0x600A529")]
	[Address(RVA = "0xF2D1E0", Offset = "0xF2C3E0", VA = "0x180F2D1E0", Slot = "9")]
	protected override void SetupCardLocator(CardLocator cardLocator)
	{
	}

	[Token(Token = "0x600A52A")]
	[Address(RVA = "0xF2C720", Offset = "0xF2B920", VA = "0x180F2C720", Slot = "53")]
	public override void GetPosture(int index, out Vector3 position, out Quaternion rotation, out float depth, int card_num = -1, bool originPosition = false)
	{
	}

	[Token(Token = "0x600A52B")]
	[Address(RVA = "0xF2CE80", Offset = "0xF2C080", VA = "0x180F2CE80", Slot = "41")]
	public override int GetViewIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600A52C")]
	[Address(RVA = "0xF2C6F0", Offset = "0xF2B8F0", VA = "0x180F2C6F0", Slot = "40")]
	public override int GetIndexByViewIndex(int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600A52D")]
	[Address(RVA = "0xF2D310", Offset = "0xF2C510", VA = "0x180F2D310", Slot = "52")]
	public override int UniqueIdToIndex(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x600A52E")]
	[Address(RVA = "0xF2D1B0", Offset = "0xF2C3B0", VA = "0x180F2D1B0", Slot = "55")]
	protected override void SetSortImpl(HandCardManager.ViewSortMode sort)
	{
	}

	[Token(Token = "0x600A52F")]
	[Address(RVA = "0xF2CF90", Offset = "0xF2C190", VA = "0x180F2CF90", Slot = "56")]
	protected override void InsertViewIndexImpl(int targetIndex, int InsertViewIndex)
	{
	}

	[Token(Token = "0x600A530")]
	[Address(RVA = "0x558260", Offset = "0x557460", VA = "0x180558260", Slot = "57")]
	protected override void RefreshCardLocatorsImpl()
	{
	}

	[Token(Token = "0x600A531")]
	[Address(RVA = "0xF2D340", Offset = "0xF2C540", VA = "0x180F2D340", Slot = "58")]
	public override void UpdateAllCardPosition()
	{
	}
}
