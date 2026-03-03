using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CC3")]
public class ColosseumRewardTournamentViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001CC4")]
	internal abstract class ModeBehaviour
	{
		[Token(Token = "0x40100A8")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x40100A9")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string BTN_ICON_LABEL;

		[Token(Token = "0x40100AA")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string IMG_LINE_LABEL;

		[Token(Token = "0x40100AB")]
		[FieldOffset(Offset = "0x28")]
		protected readonly string TXT_ORDER_LABEL;

		[Token(Token = "0x40100AC")]
		[FieldOffset(Offset = "0x30")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x40100AD")]
		[FieldOffset(Offset = "0x38")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x40100AE")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string TXT_DATE_LABEL;

		[Token(Token = "0x40100AF")]
		[FieldOffset(Offset = "0x48")]
		protected readonly string TXT_EXPLAIN_LABEL;

		[Token(Token = "0x40100B0")]
		[FieldOffset(Offset = "0x50")]
		protected readonly string E_ImageReceived;

		[Token(Token = "0x40100B1")]
		[FieldOffset(Offset = "0x58")]
		protected readonly ColosseumRewardTournamentViewController vc;

		[Token(Token = "0x40100B2")]
		[FieldOffset(Offset = "0x60")]
		protected readonly InfinityScrollView isv;

		[Token(Token = "0x40100B3")]
		[FieldOffset(Offset = "0x68")]
		protected readonly ElementObjectManager eom;

		[Token(Token = "0x40100B4")]
		[FieldOffset(Offset = "0x70")]
		protected readonly int id;

		[Token(Token = "0x40100B5")]
		[FieldOffset(Offset = "0x78")]
		protected readonly string startDateReward;

		[Token(Token = "0x40100B6")]
		[FieldOffset(Offset = "0x80")]
		protected readonly string endDateReward;

		[Token(Token = "0x600BA2B")]
		[Address(RVA = "0x55DF80", Offset = "0x55D180", VA = "0x18055DF80")]
		protected ModeBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
		{
		}

		[Token(Token = "0x600BA2C")]
		internal abstract void CallAPI();

		[Token(Token = "0x600BA2D")]
		internal abstract void UpdateView();

		[Token(Token = "0x600BA2E")]
		internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

		[Token(Token = "0x600BA2F")]
		internal abstract void InitializeScroll();
	}

	[Token(Token = "0x2001CC5")]
	internal class TournamentBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001CC6")]
		private class Data
		{
			[Token(Token = "0x40100B8")]
			[FieldOffset(Offset = "0x10")]
			internal List<ItemData> itemDatas;

			[Token(Token = "0x40100B9")]
			[FieldOffset(Offset = "0x18")]
			internal int maxRank;

			[Token(Token = "0x40100BA")]
			[FieldOffset(Offset = "0x1C")]
			internal int minRank;

			[Token(Token = "0x600BA39")]
			[Address(RVA = "0x557F70", Offset = "0x557170", VA = "0x180557F70")]
			public Data(int maxRank, int minRank)
			{
			}
		}

		[Token(Token = "0x2001CC7")]
		private class ItemData
		{
			[Token(Token = "0x40100BB")]
			[FieldOffset(Offset = "0x10")]
			internal int itemID;

			[Token(Token = "0x40100BC")]
			[FieldOffset(Offset = "0x14")]
			internal int quantity;

			[Token(Token = "0x600BA3A")]
			[Address(RVA = "0x55DEE0", Offset = "0x55D0E0", VA = "0x18055DEE0")]
			public ItemData(int itemID, int quantity)
			{
			}
		}

		[Token(Token = "0x40100B7")]
		[FieldOffset(Offset = "0x88")]
		private List<Data> dataList;

		[Token(Token = "0x600BA30")]
		[Address(RVA = "0x55F8A0", Offset = "0x55EAA0", VA = "0x18055F8A0")]
		public TournamentBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
		{
		}

		[Token(Token = "0x600BA31")]
		[Address(RVA = "0x55E740", Offset = "0x55D940", VA = "0x18055E740", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600BA32")]
		[Address(RVA = "0x55E9F0", Offset = "0x55DBF0", VA = "0x18055E9F0", Slot = "7")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600BA33")]
		[Address(RVA = "0x55EB00", Offset = "0x55DD00", VA = "0x18055EB00", Slot = "6")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600BA34")]
		[Address(RVA = "0x55F2F0", Offset = "0x55E4F0", VA = "0x18055F2F0", Slot = "5")]
		internal override void UpdateView()
		{
		}

		[Token(Token = "0x600BA35")]
		[Address(RVA = "0x55E7F0", Offset = "0x55D9F0", VA = "0x18055E7F0")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
		{
			return null;
		}
	}

	[Token(Token = "0x2001CCA")]
	internal class ExhibitionBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001CCB")]
		private class Data
		{
			[Token(Token = "0x40100C4")]
			[FieldOffset(Offset = "0x10")]
			internal readonly int itemCategory;

			[Token(Token = "0x40100C5")]
			[FieldOffset(Offset = "0x14")]
			internal readonly int itemID;

			[Token(Token = "0x40100C6")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int needToken;

			[Token(Token = "0x40100C7")]
			[FieldOffset(Offset = "0x1C")]
			internal readonly int quantity;

			[Token(Token = "0x40100C8")]
			[FieldOffset(Offset = "0x20")]
			internal bool isPeriod;

			[Token(Token = "0x40100C9")]
			[FieldOffset(Offset = "0x21")]
			internal bool received;

			[Token(Token = "0x600BA48")]
			[Address(RVA = "0x557F10", Offset = "0x557110", VA = "0x180557F10")]
			public Data(int itemCategory, int itemID, int needToken, int quantity, bool isPeriod, bool received)
			{
			}
		}

		[Token(Token = "0x40100C3")]
		[FieldOffset(Offset = "0x88")]
		private List<Data> dataList;

		[Token(Token = "0x600BA42")]
		[Address(RVA = "0x55DCD0", Offset = "0x55CED0", VA = "0x18055DCD0")]
		public ExhibitionBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
		{
		}

		[Token(Token = "0x600BA43")]
		[Address(RVA = "0x55A020", Offset = "0x559220", VA = "0x18055A020", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600BA44")]
		[Address(RVA = "0x55D430", Offset = "0x55C630", VA = "0x18055D430", Slot = "7")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600BA45")]
		[Address(RVA = "0x55D4D0", Offset = "0x55C6D0", VA = "0x18055D4D0", Slot = "6")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600BA46")]
		[Address(RVA = "0x55D8C0", Offset = "0x55CAC0", VA = "0x18055D8C0", Slot = "5")]
		internal override void UpdateView()
		{
		}
	}

	[Token(Token = "0x2001CCD")]
	internal class DuelTrialBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001CCE")]
		private class Data
		{
			[Token(Token = "0x40100CC")]
			[FieldOffset(Offset = "0x10")]
			internal List<ItemData> itemDatas;

			[Token(Token = "0x40100CD")]
			[FieldOffset(Offset = "0x18")]
			internal string winText;

			[Token(Token = "0x600BA52")]
			[Address(RVA = "0x5581C0", Offset = "0x5573C0", VA = "0x1805581C0")]
			public Data(string winText)
			{
			}
		}

		[Token(Token = "0x2001CCF")]
		private class ItemData
		{
			[Token(Token = "0x40100CE")]
			[FieldOffset(Offset = "0x10")]
			internal int itemCategory;

			[Token(Token = "0x40100CF")]
			[FieldOffset(Offset = "0x14")]
			internal int itemID;

			[Token(Token = "0x40100D0")]
			[FieldOffset(Offset = "0x18")]
			internal int num;

			[Token(Token = "0x40100D1")]
			[FieldOffset(Offset = "0x1C")]
			internal bool isPeriod;

			[Token(Token = "0x40100D2")]
			[FieldOffset(Offset = "0x20")]
			internal int shopId;

			[Token(Token = "0x600BA53")]
			[Address(RVA = "0x55DF20", Offset = "0x55D120", VA = "0x18055DF20")]
			public ItemData(int itemCategory, int itemID, int num, bool isPeriod, int shopId)
			{
			}
		}

		[Token(Token = "0x40100CB")]
		[FieldOffset(Offset = "0x88")]
		private List<Data> dataList;

		[Token(Token = "0x600BA4B")]
		[Address(RVA = "0x55AE70", Offset = "0x55A070", VA = "0x18055AE70")]
		public DuelTrialBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
		{
		}

		[Token(Token = "0x600BA4C")]
		[Address(RVA = "0x55A020", Offset = "0x559220", VA = "0x18055A020", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600BA4D")]
		[Address(RVA = "0x55A240", Offset = "0x559440", VA = "0x18055A240", Slot = "7")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600BA4E")]
		[Address(RVA = "0x55A350", Offset = "0x559550", VA = "0x18055A350", Slot = "6")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600BA4F")]
		[Address(RVA = "0x55A960", Offset = "0x559B60", VA = "0x18055A960", Slot = "5")]
		internal override void UpdateView()
		{
		}

		[Token(Token = "0x600BA50")]
		[Address(RVA = "0x55A040", Offset = "0x559240", VA = "0x18055A040")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
		{
			return null;
		}
	}

	[Token(Token = "0x2001CD2")]
	internal class VersusBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001CD3")]
		private class Data
		{
			[Token(Token = "0x40100D7")]
			[FieldOffset(Offset = "0x10")]
			internal readonly int itemCategory;

			[Token(Token = "0x40100D8")]
			[FieldOffset(Offset = "0x14")]
			internal readonly int itemID;

			[Token(Token = "0x40100D9")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int needToken;

			[Token(Token = "0x40100DA")]
			[FieldOffset(Offset = "0x1C")]
			internal readonly int quantity;

			[Token(Token = "0x40100DB")]
			[FieldOffset(Offset = "0x20")]
			internal bool isPeriod;

			[Token(Token = "0x40100DC")]
			[FieldOffset(Offset = "0x21")]
			internal bool received;

			[Token(Token = "0x600BA5F")]
			[Address(RVA = "0x557F10", Offset = "0x557110", VA = "0x180557F10")]
			public Data(int itemCategory, int itemID, int needToken, int quantity, bool isPeriod, bool received)
			{
			}
		}

		[Token(Token = "0x40100D6")]
		[FieldOffset(Offset = "0x88")]
		private List<Data> dataList;

		[Token(Token = "0x600BA59")]
		[Address(RVA = "0x562660", Offset = "0x561860", VA = "0x180562660")]
		public VersusBehaviour(ColosseumRewardTournamentViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string startDateReward, string endDateReward)
		{
		}

		[Token(Token = "0x600BA5A")]
		[Address(RVA = "0x55A020", Offset = "0x559220", VA = "0x18055A020", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600BA5B")]
		[Address(RVA = "0x561CC0", Offset = "0x560EC0", VA = "0x180561CC0", Slot = "7")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600BA5C")]
		[Address(RVA = "0x561D60", Offset = "0x560F60", VA = "0x180561D60", Slot = "6")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600BA5D")]
		[Address(RVA = "0x562110", Offset = "0x561310", VA = "0x180562110", Slot = "5")]
		internal override void UpdateView()
		{
		}
	}

	[Token(Token = "0x40100A6")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40100A7")]
	[FieldOffset(Offset = "0xD8")]
	private ModeBehaviour modeBehaviour;

	[Token(Token = "0x17001BEE")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600BA27")]
		[Address(RVA = "0x54FEF0", Offset = "0x54F0F0", VA = "0x18054FEF0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BA28")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BA29")]
	[Address(RVA = "0x54FA00", Offset = "0x54EC00", VA = "0x18054FA00", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BA2A")]
	[Address(RVA = "0x54FE90", Offset = "0x54F090", VA = "0x18054FE90")]
	public ColosseumRewardTournamentViewController()
	{
	}
}
