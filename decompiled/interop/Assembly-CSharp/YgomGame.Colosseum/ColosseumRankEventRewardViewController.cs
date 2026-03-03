using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001C8F")]
public class ColosseumRankEventRewardViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001C90")]
	internal class ItemData
	{
		[Token(Token = "0x400FF45")]
		[FieldOffset(Offset = "0x10")]
		internal int itemID;

		[Token(Token = "0x400FF46")]
		[FieldOffset(Offset = "0x14")]
		internal int quantity;

		[Token(Token = "0x400FF47")]
		[FieldOffset(Offset = "0x18")]
		internal int itemCategory;

		[Token(Token = "0x400FF48")]
		[FieldOffset(Offset = "0x1C")]
		internal bool is_period;

		[Token(Token = "0x600B926")]
		[Address(RVA = "0x5009A0", Offset = "0x4FFBA0", VA = "0x1805009A0")]
		internal ItemData(int itemID, int quantity, int itemCategory, bool is_period = false)
		{
		}
	}

	[Token(Token = "0x2001C91")]
	internal class Data
	{
		[Token(Token = "0x400FF49")]
		[FieldOffset(Offset = "0x10")]
		internal List<ItemData> itemDatas;

		[Token(Token = "0x400FF4A")]
		[FieldOffset(Offset = "0x18")]
		internal int rank;

		[Token(Token = "0x400FF4B")]
		[FieldOffset(Offset = "0x1C")]
		internal int tier;

		[Token(Token = "0x400FF4C")]
		[FieldOffset(Offset = "0x20")]
		internal bool received;

		[Token(Token = "0x600B927")]
		[Address(RVA = "0x546530", Offset = "0x545730", VA = "0x180546530")]
		public Data(int rank, int tier, bool received)
		{
		}
	}

	[Token(Token = "0x400FF35")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400FF36")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string IMG_ITEM_LABEL;

	[Token(Token = "0x400FF37")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400FF38")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string IMG_RANK_LABEL;

	[Token(Token = "0x400FF39")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string IMG_RANK_BG_LABEL;

	[Token(Token = "0x400FF3A")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string IMG_RECEIVED_LABEL;

	[Token(Token = "0x400FF3B")]
	[FieldOffset(Offset = "0x100")]
	private readonly string IMG_ARROW_LABEL;

	[Token(Token = "0x400FF3C")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TXT_QUANTITY_LABEL;

	[Token(Token = "0x400FF3D")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TXT_MESSAGE_LABEL;

	[Token(Token = "0x400FF3E")]
	[FieldOffset(Offset = "0x118")]
	private readonly string TXT_RANK_LABEL;

	[Token(Token = "0x400FF3F")]
	[FieldOffset(Offset = "0x120")]
	private readonly string TXT_TIER_LABEL;

	[Token(Token = "0x400FF40")]
	[FieldOffset(Offset = "0x128")]
	private InfinityScrollView isv;

	[Token(Token = "0x400FF41")]
	[FieldOffset(Offset = "0x130")]
	private List<Data> dataList;

	[Token(Token = "0x400FF42")]
	[FieldOffset(Offset = "0x138")]
	private int defaultCursorIndex;

	[Token(Token = "0x400FF43")]
	[FieldOffset(Offset = "0x13C")]
	private bool isSelectedDefault;

	[Token(Token = "0x400FF44")]
	[FieldOffset(Offset = "0x140")]
	private int id;

	[Token(Token = "0x17001BE1")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B917")]
		[Address(RVA = "0x536240", Offset = "0x535440", VA = "0x180536240", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B918")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B919")]
	[Address(RVA = "0x5345F0", Offset = "0x5337F0", VA = "0x1805345F0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B91A")]
	[Address(RVA = "0x535340", Offset = "0x534540", VA = "0x180535340", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B91B")]
	[Address(RVA = "0x535450", Offset = "0x534650", VA = "0x180535450", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600B91C")]
	[Address(RVA = "0x5356A0", Offset = "0x5348A0", VA = "0x1805356A0")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600B91D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x600B91E")]
	[Address(RVA = "0x534AA0", Offset = "0x533CA0", VA = "0x180534AA0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B91F")]
	[Address(RVA = "0x535200", Offset = "0x534400", VA = "0x180535200")]
	private string RankEventConvert(int rank)
	{
		return null;
	}

	[Token(Token = "0x600B920")]
	[Address(RVA = "0x534470", Offset = "0x533670", VA = "0x180534470")]
	private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
	{
		return null;
	}

	[Token(Token = "0x600B921")]
	[Address(RVA = "0x536020", Offset = "0x535220", VA = "0x180536020")]
	public ColosseumRankEventRewardViewController()
	{
	}
}
