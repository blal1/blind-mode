using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CD5")]
public class ColosseumRewardViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001CD6")]
	internal class Data
	{
		[Token(Token = "0x40100ED")]
		[FieldOffset(Offset = "0x10")]
		internal List<ItemData> itemDatas;

		[Token(Token = "0x40100EE")]
		[FieldOffset(Offset = "0x18")]
		internal int rank;

		[Token(Token = "0x40100EF")]
		[FieldOffset(Offset = "0x1C")]
		internal int tier;

		[Token(Token = "0x40100F0")]
		[FieldOffset(Offset = "0x20")]
		internal bool received;

		[Token(Token = "0x600BA71")]
		[Address(RVA = "0x558080", Offset = "0x557280", VA = "0x180558080")]
		public Data(int rank, int tier, bool received)
		{
		}
	}

	[Token(Token = "0x2001CD7")]
	internal class ItemData
	{
		[Token(Token = "0x40100F1")]
		[FieldOffset(Offset = "0x10")]
		internal int itemID;

		[Token(Token = "0x40100F2")]
		[FieldOffset(Offset = "0x14")]
		internal int quantity;

		[Token(Token = "0x600BA72")]
		[Address(RVA = "0x55DEE0", Offset = "0x55D0E0", VA = "0x18055DEE0")]
		internal ItemData(int itemID, int quantity)
		{
		}
	}

	[Token(Token = "0x40100DE")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40100DF")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string IMG_ITEM_LABEL;

	[Token(Token = "0x40100E0")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x40100E1")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string IMG_RANK_LABEL;

	[Token(Token = "0x40100E2")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string IMG_RANK_BG_LABEL;

	[Token(Token = "0x40100E3")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string IMG_RECEIVED_LABEL;

	[Token(Token = "0x40100E4")]
	[FieldOffset(Offset = "0x100")]
	private readonly string IMG_ARROW_LABEL;

	[Token(Token = "0x40100E5")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TXT_QUANTITY_LABEL;

	[Token(Token = "0x40100E6")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TXT_MESSAGE_LABEL;

	[Token(Token = "0x40100E7")]
	[FieldOffset(Offset = "0x118")]
	private readonly string TXT_RANK_LABEL;

	[Token(Token = "0x40100E8")]
	[FieldOffset(Offset = "0x120")]
	private readonly string TXT_TIER_LABEL;

	[Token(Token = "0x40100E9")]
	[FieldOffset(Offset = "0x128")]
	private InfinityScrollView isv;

	[Token(Token = "0x40100EA")]
	[FieldOffset(Offset = "0x130")]
	private List<Data> dataList;

	[Token(Token = "0x40100EB")]
	[FieldOffset(Offset = "0x138")]
	private int defaultCursorIndex;

	[Token(Token = "0x40100EC")]
	[FieldOffset(Offset = "0x13C")]
	private bool isSelectedDefault;

	[Token(Token = "0x17001BEF")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600BA62")]
		[Address(RVA = "0x551A80", Offset = "0x550C80", VA = "0x180551A80", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BA63")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BA64")]
	[Address(RVA = "0x5501B0", Offset = "0x54F3B0", VA = "0x1805501B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BA65")]
	[Address(RVA = "0x550BE0", Offset = "0x54FDE0", VA = "0x180550BE0", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600BA66")]
	[Address(RVA = "0x535450", Offset = "0x534650", VA = "0x180535450", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600BA67")]
	[Address(RVA = "0x550F40", Offset = "0x550140", VA = "0x180550F40")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600BA68")]
	[Address(RVA = "0x550030", Offset = "0x54F230", VA = "0x180550030")]
	private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
	{
		return null;
	}

	[Token(Token = "0x600BA69")]
	[Address(RVA = "0x5504F0", Offset = "0x54F6F0", VA = "0x1805504F0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600BA6A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600BA6B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x600BA6C")]
	[Address(RVA = "0x551860", Offset = "0x550A60", VA = "0x180551860")]
	public ColosseumRewardViewController()
	{
	}
}
