using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019A9")]
public class FarHandCardPlace : HandCardPlace
{
	[Token(Token = "0x400ED6F")]
	[FieldOffset(Offset = "0x130")]
	private Vector3 _locatorOffsetTargetDeciding;

	[Token(Token = "0x400ED70")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 _locatorOffsetTargetSelecting;

	[Token(Token = "0x17001935")]
	protected override int selectedIndex
	{
		[Token(Token = "0x600A4E0")]
		[Address(RVA = "0xF2A710", Offset = "0xF29910", VA = "0x180F2A710", Slot = "43")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001936")]
	protected override int decidedIndex
	{
		[Token(Token = "0x600A4E1")]
		[Address(RVA = "0xF2A5E0", Offset = "0xF297E0", VA = "0x180F2A5E0", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001937")]
	public override int handCardNum
	{
		[Token(Token = "0x600A4E2")]
		[Address(RVA = "0xF2A680", Offset = "0xF29880", VA = "0x180F2A680", Slot = "42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001938")]
	protected override HandCardManager.ViewSortMode sortMode
	{
		[Token(Token = "0x600A4E3")]
		[Address(RVA = "0xF2A7B0", Offset = "0xF299B0", VA = "0x180F2A7B0", Slot = "48")]
		get
		{
			return default(HandCardManager.ViewSortMode);
		}
	}

	[Token(Token = "0x17001939")]
	protected override Vector3 locatorOffsetTargetDeciding
	{
		[Token(Token = "0x600A4E4")]
		[Address(RVA = "0xF2A6D0", Offset = "0xF298D0", VA = "0x180F2A6D0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700193A")]
	protected override Vector3 locatorOffsetTargetSelecting
	{
		[Token(Token = "0x600A4E5")]
		[Address(RVA = "0xF2A6F0", Offset = "0xF298F0", VA = "0x180F2A6F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700193B")]
	public override bool isAllOpen
	{
		[Token(Token = "0x600A4E6")]
		[Address(RVA = "0xF2A6B0", Offset = "0xF298B0", VA = "0x180F2A6B0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A4E7")]
	[Address(RVA = "0xF2A210", Offset = "0xF29410", VA = "0x180F2A210")]
	public FarHandCardPlace(DuelFieldBase duelField, int team, int position)
	{
	}

	[Token(Token = "0x600A4E8")]
	[Address(RVA = "0xF29D30", Offset = "0xF28F30", VA = "0x180F29D30", Slot = "50")]
	protected override void SelectNextItem(int index)
	{
	}

	[Token(Token = "0x600A4E9")]
	[Address(RVA = "0xF29E10", Offset = "0xF29010", VA = "0x180F29E10", Slot = "51")]
	protected override void SelectPrevItem(int index)
	{
	}

	[Token(Token = "0x600A4EA")]
	[Address(RVA = "0xF29CD0", Offset = "0xF28ED0", VA = "0x180F29CD0", Slot = "13")]
	protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600A4EB")]
	[Address(RVA = "0xF29BE0", Offset = "0xF28DE0", VA = "0x180F29BE0", Slot = "49")]
	protected override void HighlightImpl(int index, SharedDefinition.ActivateAura auraType)
	{
	}

	[Token(Token = "0x600A4EC")]
	[Address(RVA = "0xF2A0B0", Offset = "0xF292B0", VA = "0x180F2A0B0", Slot = "54")]
	public override void UpdateCenterPosition()
	{
	}

	[Token(Token = "0x600A4ED")]
	[Address(RVA = "0xF29F30", Offset = "0xF29130", VA = "0x180F29F30", Slot = "9")]
	protected override void SetupCardLocator(CardLocator cardLocator)
	{
	}

	[Token(Token = "0x600A4EE")]
	[Address(RVA = "0xF29260", Offset = "0xF28460", VA = "0x180F29260", Slot = "53")]
	public override void GetPosture(int index, out Vector3 position, out Quaternion rotation, out float depth, int card_num = -1, bool originPosition = false)
	{
	}

	[Token(Token = "0x600A4EF")]
	[Address(RVA = "0xF29BB0", Offset = "0xF28DB0", VA = "0x180F29BB0", Slot = "41")]
	public override int GetViewIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600A4F0")]
	[Address(RVA = "0xF29230", Offset = "0xF28430", VA = "0x180F29230", Slot = "40")]
	public override int GetIndexByViewIndex(int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600A4F1")]
	[Address(RVA = "0xF29F80", Offset = "0xF29180", VA = "0x180F29F80", Slot = "52")]
	public override int UniqueIdToIndex(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x600A4F2")]
	[Address(RVA = "0xF29F00", Offset = "0xF29100", VA = "0x180F29F00", Slot = "55")]
	protected override void SetSortImpl(HandCardManager.ViewSortMode sort)
	{
	}

	[Token(Token = "0x600A4F3")]
	[Address(RVA = "0xF29CA0", Offset = "0xF28EA0", VA = "0x180F29CA0", Slot = "56")]
	protected override void InsertViewIndexImpl(int targetIndex, int InsertViewIndex)
	{
	}

	[Token(Token = "0x600A4F4")]
	[Address(RVA = "0x558260", Offset = "0x557460", VA = "0x180558260", Slot = "57")]
	protected override void RefreshCardLocatorsImpl()
	{
	}

	[Token(Token = "0x600A4F5")]
	[Address(RVA = "0xF29FB0", Offset = "0xF291B0", VA = "0x180F29FB0", Slot = "58")]
	public override void UpdateAllCardPosition()
	{
	}
}
