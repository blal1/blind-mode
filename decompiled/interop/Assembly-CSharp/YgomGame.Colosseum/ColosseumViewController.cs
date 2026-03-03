using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001D05")]
public class ColosseumViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001D06")]
	internal interface ICustomButtonAction
	{
		[Token(Token = "0x600BAF0")]
		void OnCustomClick(ViewControllerManager manager, Action onFailed);
	}

	[Token(Token = "0x2001D07")]
	internal abstract class ColosseumMenuBase
	{
		[Token(Token = "0x40101CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x40101CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string ROOT_RANK_LABEL;

		[Token(Token = "0x40101CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string ROOT_FREE_LABEL;

		[Token(Token = "0x40101CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string IMG_LABEL;

		[Token(Token = "0x40101D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string TXT_TIME_LIMIT_LABEL;

		[Token(Token = "0x40101D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string TXT_LABEL;

		[Token(Token = "0x40101D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x40101D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x40101D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string IMG_BG_LABEL;

		[Token(Token = "0x600BAF1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		internal virtual void Init(ElementObjectManager m_View, ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600BAF2")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "5")]
		internal virtual bool OnResult(ViewController from, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600BAF3")]
		internal abstract void Update();

		[Token(Token = "0x600BAF4")]
		internal abstract ColosseumUtil.PlayMode GetPlayMode();

		[Token(Token = "0x600BAF5")]
		[Address(RVA = "0x5723A0", Offset = "0x5715A0", VA = "0x1805723A0")]
		protected ColosseumMenuBase()
		{
		}
	}

	[Token(Token = "0x2001D08")]
	protected internal class ButtonInfo
	{
		[Token(Token = "0x40101D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string name;

		[Token(Token = "0x40101D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly int identifier;

		[Token(Token = "0x40101D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal readonly ColosseumUtil.PlayMode playMode;

		[Token(Token = "0x600BAF6")]
		[Address(RVA = "0x56F780", Offset = "0x56E980", VA = "0x18056F780")]
		internal ButtonInfo(string name, ColosseumUtil.PlayMode playMode, int identifier = 0)
		{
		}
	}

	[Token(Token = "0x2001D09")]
	internal abstract class ButtonEvent : ButtonInfo
	{
		[Token(Token = "0x2001D0A")]
		public enum TemplateType
		{
			[Token(Token = "0x40101EA")]
			NORMAL,
			[Token(Token = "0x40101EB")]
			REGULATION,
			[Token(Token = "0x40101EC")]
			DUELTRIAL
		}

		[Token(Token = "0x40101D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string TXT_BEFORE_LABEL;

		[Token(Token = "0x40101D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string TXT_AFTER_LABEL;

		[Token(Token = "0x40101DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string TXT_OPEN_LABEL;

		[Token(Token = "0x40101DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string TXT_TIME_LABEL;

		[Token(Token = "0x40101DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string IMG_BEFORE_LABEL;

		[Token(Token = "0x40101DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string IMG_AFTER_LABEL;

		[Token(Token = "0x40101DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string IMG_OPEN_LABEL;

		[Token(Token = "0x40101DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected readonly string IMG_LOGO_LABEL;

		[Token(Token = "0x40101E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected readonly string IMG_LOGO_BG_LABEL;

		[Token(Token = "0x40101E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected readonly string IMG_ATTENTION_LABEL;

		[Token(Token = "0x40101E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected readonly string IMG_TIME_LABEL;

		[Token(Token = "0x40101E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected readonly string IMG_EVENT_CATEGORY;

		[Token(Token = "0x40101E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TemplateType type;

		[Token(Token = "0x40101E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string vcPrefabPath;

		[Token(Token = "0x40101E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal string endDate;

		[Token(Token = "0x40101E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal string startDate;

		[Token(Token = "0x40101E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal int sort;

		[Token(Token = "0x17001BF4")]
		public string VcPrefabPath
		{
			[Token(Token = "0x600BAF7")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600BAF8")]
			[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
			protected set
			{
			}
		}

		[Token(Token = "0x600BAF9")]
		[Address(RVA = "0x56EE80", Offset = "0x56E080", VA = "0x18056EE80")]
		internal ButtonEvent(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
		{
		}

		[Token(Token = "0x600BAFA")]
		internal abstract void SetStatus(ElementObjectManager eom);

		[Token(Token = "0x600BAFB")]
		internal abstract void SetLogo(ElementObjectManager eom);

		[Token(Token = "0x600BAFC")]
		internal abstract void SetStatusText(ElementObjectManager eom);

		[Token(Token = "0x600BAFD")]
		[Address(RVA = "0x56EDC0", Offset = "0x56DFC0", VA = "0x18056EDC0", Slot = "7")]
		internal virtual Dictionary<string, object> GetAdditionalArgs()
		{
			return null;
		}

		[Token(Token = "0x600BAFE")]
		[Address(RVA = "0x56EE20", Offset = "0x56E020", VA = "0x18056EE20", Slot = "8")]
		protected virtual string GetEventCategoryPath()
		{
			return null;
		}
	}

	[Token(Token = "0x2001D0B")]
	internal class ColosseumMenuManager
	{
		[Token(Token = "0x40101ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<ColosseumMenuBase> menuBases;

		[Token(Token = "0x40101EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<ButtonEvent> eventList;

		[Token(Token = "0x600BAFF")]
		[Address(RVA = "0x575200", Offset = "0x574400", VA = "0x180575200")]
		internal ColosseumMenuManager()
		{
		}

		[Token(Token = "0x600BB00")]
		[Address(RVA = "0x574C40", Offset = "0x573E40", VA = "0x180574C40")]
		internal void Init(ElementObjectManager m_View, ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600BB01")]
		[Address(RVA = "0x574ED0", Offset = "0x5740D0", VA = "0x180574ED0")]
		internal void Update()
		{
		}

		[Token(Token = "0x600BB02")]
		[Address(RVA = "0x574D70", Offset = "0x573F70", VA = "0x180574D70")]
		internal bool OnResult(ViewController from, object value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001D0D")]
	internal abstract class ColosseumMenuEventDuel : ColosseumMenuBase
	{
		[Token(Token = "0x40101F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal List<ButtonEvent> eventList;

		[Token(Token = "0x600BB06")]
		[Address(RVA = "0x573F30", Offset = "0x573130", VA = "0x180573F30")]
		protected ColosseumMenuEventDuel()
		{
		}
	}

	[Token(Token = "0x2001D0E")]
	internal class ColosseumMenuExhibition : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D0F")]
		internal class ButtonExhibition : ButtonEvent
		{
			[Token(Token = "0x40101F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusExhibition status;

			[Token(Token = "0x40101F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x40101F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal bool isReward;

			[Token(Token = "0x600BB0A")]
			[Address(RVA = "0x56F6F0", Offset = "0x56E8F0", VA = "0x18056F6F0")]
			internal ButtonExhibition(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB0B")]
			[Address(RVA = "0x56DF20", Offset = "0x56D120", VA = "0x18056DF20")]
			internal void SetInfo(ColosseumUtil.StatusExhibition status, int logoId, string startDate, string endDate, bool isReward)
			{
			}

			[Token(Token = "0x600BB0C")]
			[Address(RVA = "0x56F400", Offset = "0x56E600", VA = "0x18056F400", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB0D")]
			[Address(RVA = "0x56F100", Offset = "0x56E300", VA = "0x18056F100", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB0E")]
			[Address(RVA = "0x56F2A0", Offset = "0x56E4A0", VA = "0x18056F2A0", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB07")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB08")]
		[Address(RVA = "0x573FB0", Offset = "0x5731B0", VA = "0x180573FB0", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB09")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuExhibition()
		{
		}
	}

	[Token(Token = "0x2001D10")]
	internal class ColosseumMenuTournament : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D11")]
		internal class ButtonTournament : ButtonEvent
		{
			[Token(Token = "0x40101F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusTournament status;

			[Token(Token = "0x40101F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal ColosseumUtil.StatusTournamentHolding statusHolding;

			[Token(Token = "0x40101F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal int logoId;

			[Token(Token = "0x600BB12")]
			[Address(RVA = "0x570BB0", Offset = "0x56FDB0", VA = "0x180570BB0")]
			internal ButtonTournament(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB13")]
			[Address(RVA = "0x570580", Offset = "0x56F780", VA = "0x180570580")]
			internal void SetInfo(ColosseumUtil.StatusTournament status, ColosseumUtil.StatusTournamentHolding statusHolding, int logoId, string startDate, string endDate)
			{
			}

			[Token(Token = "0x600BB14")]
			[Address(RVA = "0x5708E0", Offset = "0x56FAE0", VA = "0x1805708E0", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB15")]
			[Address(RVA = "0x5705E0", Offset = "0x56F7E0", VA = "0x1805705E0", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB16")]
			[Address(RVA = "0x570780", Offset = "0x56F980", VA = "0x180570780", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB0F")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB10")]
		[Address(RVA = "0x578160", Offset = "0x577360", VA = "0x180578160", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB11")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuTournament()
		{
		}
	}

	[Token(Token = "0x2001D12")]
	internal class ColosseumMenuRegulationDuel : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D13")]
		internal class ButtonRankEvent : ButtonEvent
		{
			[Token(Token = "0x40101F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusRankEvent status;

			[Token(Token = "0x40101F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x40101FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal bool isReward;

			[Token(Token = "0x600BB1A")]
			[Address(RVA = "0x5704E0", Offset = "0x56F6E0", VA = "0x1805704E0")]
			internal ButtonRankEvent(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB1B")]
			[Address(RVA = "0x56DF20", Offset = "0x56D120", VA = "0x18056DF20")]
			internal void SetInfo(ColosseumUtil.StatusRankEvent status, int logoId, string startDate, string endDate, bool isReward)
			{
			}

			[Token(Token = "0x600BB1C")]
			[Address(RVA = "0x570200", Offset = "0x56F400", VA = "0x180570200", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB1D")]
			[Address(RVA = "0x56FF00", Offset = "0x56F100", VA = "0x18056FF00", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB1E")]
			[Address(RVA = "0x5700A0", Offset = "0x56F2A0", VA = "0x1805700A0", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB17")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB18")]
		[Address(RVA = "0x5763D0", Offset = "0x5755D0", VA = "0x1805763D0", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB19")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuRegulationDuel()
		{
		}
	}

	[Token(Token = "0x2001D14")]
	internal class ColosseumMenuCup : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D15")]
		internal class ButtonDuelistCup : ButtonEvent
		{
			[Token(Token = "0x40101FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusDuelistCup status;

			[Token(Token = "0x40101FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x40101FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal int stage;

			[Token(Token = "0x600BB24")]
			[Address(RVA = "0x56ED30", Offset = "0x56DF30", VA = "0x18056ED30")]
			internal ButtonDuelistCup(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB25")]
			[Address(RVA = "0x56E640", Offset = "0x56D840", VA = "0x18056E640")]
			internal void SetInfo(ColosseumUtil.StatusDuelistCup status, int logoId, string startDate, string endDate, int stage)
			{
			}

			[Token(Token = "0x600BB26")]
			[Address(RVA = "0x56E9F0", Offset = "0x56DBF0", VA = "0x18056E9F0", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB27")]
			[Address(RVA = "0x56E6A0", Offset = "0x56D8A0", VA = "0x18056E6A0", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB28")]
			[Address(RVA = "0x56E860", Offset = "0x56DA60", VA = "0x18056E860", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB1F")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB20")]
		[Address(RVA = "0x5726B0", Offset = "0x5718B0", VA = "0x1805726B0", Slot = "8")]
		internal virtual string GetIDPath()
		{
			return null;
		}

		[Token(Token = "0x600BB21")]
		[Address(RVA = "0x5726E0", Offset = "0x5718E0", VA = "0x1805726E0", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB22")]
		[Address(RVA = "0x572530", Offset = "0x571730", VA = "0x180572530", Slot = "9")]
		protected virtual void AddEventList(int cid, string eventName, int logoId, ColosseumUtil.StatusDuelistCup status, int stage, string startDate, string endDate, int sort)
		{
		}

		[Token(Token = "0x600BB23")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuCup()
		{
		}
	}

	[Token(Token = "0x2001D16")]
	internal class ColosseumMenuWCS : ColosseumMenuCup
	{
		[Token(Token = "0x2001D17")]
		internal class ButtonWCS : ButtonDuelistCup
		{
			[Token(Token = "0x600BB2D")]
			[Address(RVA = "0x5715A0", Offset = "0x5707A0", VA = "0x1805715A0")]
			internal ButtonWCS(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB2E")]
			[Address(RVA = "0x5713E0", Offset = "0x5705E0", VA = "0x1805713E0", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB29")]
		[Address(RVA = "0x578D90", Offset = "0x577F90", VA = "0x180578D90", Slot = "8")]
		internal override string GetIDPath()
		{
			return null;
		}

		[Token(Token = "0x600BB2A")]
		[Address(RVA = "0x578DC0", Offset = "0x577FC0", VA = "0x180578DC0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB2B")]
		[Address(RVA = "0x578BE0", Offset = "0x577DE0", VA = "0x180578BE0", Slot = "9")]
		protected override void AddEventList(int cid, string eventName, int logoId, ColosseumUtil.StatusDuelistCup status, int stage, string startDate, string endDate, int sort)
		{
		}

		[Token(Token = "0x600BB2C")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuWCS()
		{
		}
	}

	[Token(Token = "0x2001D18")]
	internal class ColosseumMenuDuelTrial : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D19")]
		internal class ButtonDuelTrial : ButtonEvent
		{
			[Token(Token = "0x40101FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusDuelTrial status;

			[Token(Token = "0x40101FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x4010200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal bool isReward;

			[Token(Token = "0x4010201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private readonly string k_ETextTitle;

			[Token(Token = "0x4010202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private string m_Title;

			[Token(Token = "0x600BB32")]
			[Address(RVA = "0x56E560", Offset = "0x56D760", VA = "0x18056E560")]
			internal ButtonDuelTrial(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0, string title = "")
			{
			}

			[Token(Token = "0x600BB33")]
			[Address(RVA = "0x56DF20", Offset = "0x56D120", VA = "0x18056DF20")]
			internal void SetInfo(ColosseumUtil.StatusDuelTrial status, int logoId, string startDate, string endDate, bool isReward)
			{
			}

			[Token(Token = "0x600BB34")]
			[Address(RVA = "0x56E280", Offset = "0x56D480", VA = "0x18056E280", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB35")]
			[Address(RVA = "0x56DF80", Offset = "0x56D180", VA = "0x18056DF80", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB36")]
			[Address(RVA = "0x56E120", Offset = "0x56D320", VA = "0x18056E120", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB2F")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB30")]
		[Address(RVA = "0x573660", Offset = "0x572860", VA = "0x180573660", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB31")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuDuelTrial()
		{
		}
	}

	[Token(Token = "0x2001D1A")]
	internal class ColosseumMenuVersus : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D1B")]
		internal class ButtonVersus : ButtonEvent, ICustomButtonAction
		{
			[Token(Token = "0x4010203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusVersus status;

			[Token(Token = "0x4010204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x4010205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal bool isReward;

			[Token(Token = "0x600BB3A")]
			[Address(RVA = "0x571340", Offset = "0x570540", VA = "0x180571340")]
			internal ButtonVersus(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB3B")]
			[Address(RVA = "0x56DF20", Offset = "0x56D120", VA = "0x18056DF20")]
			internal void SetInfo(ColosseumUtil.StatusVersus status, int logoId, string startDate, string endDate, bool isReward)
			{
			}

			[Token(Token = "0x600BB3C")]
			[Address(RVA = "0x570F60", Offset = "0x570160", VA = "0x180570F60", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB3D")]
			[Address(RVA = "0x570C40", Offset = "0x56FE40", VA = "0x180570C40", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB3E")]
			[Address(RVA = "0x570DD0", Offset = "0x56FFD0", VA = "0x180570DD0", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB3F")]
			[Address(RVA = "0x571240", Offset = "0x570440", VA = "0x180571240", Slot = "9")]
			private void YgomGame_002EColosseum_002EColosseumViewController_002EICustomButtonAction_002EOnCustomClick(ViewControllerManager manager, Action onFailed)
			{
			}
		}

		[Token(Token = "0x600BB37")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB38")]
		[Address(RVA = "0x578350", Offset = "0x577550", VA = "0x180578350", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB39")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuVersus()
		{
		}
	}

	[Token(Token = "0x2001D1D")]
	internal class ColosseumMenuRDC : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D1E")]
		internal class ButtonRDC : ButtonEvent
		{
			[Token(Token = "0x401020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusDuelistCup status;

			[Token(Token = "0x401020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x401020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal int stage;

			[Token(Token = "0x600BB4A")]
			[Address(RVA = "0x56FE70", Offset = "0x56F070", VA = "0x18056FE70")]
			internal ButtonRDC(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB4B")]
			[Address(RVA = "0x56E640", Offset = "0x56D840", VA = "0x18056E640")]
			internal void SetInfo(ColosseumUtil.StatusDuelistCup status, int logoId, string startDate, string endDate, int stage)
			{
			}

			[Token(Token = "0x600BB4C")]
			[Address(RVA = "0x56FB30", Offset = "0x56ED30", VA = "0x18056FB30", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB4D")]
			[Address(RVA = "0x56F7E0", Offset = "0x56E9E0", VA = "0x18056F7E0", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB4E")]
			[Address(RVA = "0x56F9A0", Offset = "0x56EBA0", VA = "0x18056F9A0", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB45")]
		[Address(RVA = "0x575E00", Offset = "0x575000", VA = "0x180575E00", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB46")]
		[Address(RVA = "0x575DD0", Offset = "0x574FD0", VA = "0x180575DD0", Slot = "8")]
		internal virtual string GetIDPath()
		{
			return null;
		}

		[Token(Token = "0x600BB47")]
		[Address(RVA = "0x575E10", Offset = "0x575010", VA = "0x180575E10", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB48")]
		[Address(RVA = "0x575C20", Offset = "0x574E20", VA = "0x180575C20", Slot = "9")]
		protected virtual void AddEventList(int cid, string eventName, int logoId, ColosseumUtil.StatusDuelistCup status, int stage, string startDate, string endDate, int sort)
		{
		}

		[Token(Token = "0x600BB49")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuRDC()
		{
		}
	}

	[Token(Token = "0x2001D1F")]
	internal class ColosseumMenuDiceRally : ColosseumMenuEventDuel
	{
		[Token(Token = "0x2001D20")]
		internal class ButtonDiceRally : ButtonEvent
		{
			[Token(Token = "0x401020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal ColosseumUtil.StatusDiceRally status;

			[Token(Token = "0x4010210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			internal int logoId;

			[Token(Token = "0x4010211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal bool isAttention;

			[Token(Token = "0x600BB52")]
			[Address(RVA = "0x56DE90", Offset = "0x56D090", VA = "0x18056DE90")]
			internal ButtonDiceRally(string name, ColosseumUtil.PlayMode playMode, int identifier = 0, int sort = 0)
			{
			}

			[Token(Token = "0x600BB53")]
			[Address(RVA = "0x56D8D0", Offset = "0x56CAD0", VA = "0x18056D8D0")]
			internal void SetInfo(ColosseumUtil.StatusDiceRally status, int logoId, string startDate, string endDate, bool canUseDice, bool canApplyBonus)
			{
			}

			[Token(Token = "0x600BB54")]
			[Address(RVA = "0x56DBE0", Offset = "0x56CDE0", VA = "0x18056DBE0", Slot = "4")]
			internal override void SetStatus(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB55")]
			[Address(RVA = "0x56D930", Offset = "0x56CB30", VA = "0x18056D930", Slot = "5")]
			internal override void SetLogo(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x600BB56")]
			[Address(RVA = "0x56DA80", Offset = "0x56CC80", VA = "0x18056DA80", Slot = "6")]
			internal override void SetStatusText(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x600BB4F")]
		[Address(RVA = "0x572CB0", Offset = "0x571EB0", VA = "0x180572CB0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB50")]
		[Address(RVA = "0x572CC0", Offset = "0x571EC0", VA = "0x180572CC0", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB51")]
		[Address(RVA = "0x572CA0", Offset = "0x571EA0", VA = "0x180572CA0")]
		public ColosseumMenuDiceRally()
		{
		}
	}

	[Token(Token = "0x2001D21")]
	internal abstract class ColosseumMenuFreeDuel : ColosseumMenuBase
	{
		[Token(Token = "0x4010212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected GameObject selfGo;

		[Token(Token = "0x4010213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected SelectionButton selfBtn;

		[Token(Token = "0x600BB57")]
		[Address(RVA = "0x574880", Offset = "0x573A80", VA = "0x180574880")]
		protected ColosseumMenuFreeDuel()
		{
		}
	}

	[Token(Token = "0x2001D22")]
	internal class ColosseumMenuRoom : ColosseumMenuFreeDuel
	{
		[Token(Token = "0x4010214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string E_RoomImageOn;

		[Token(Token = "0x4010215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string E_RoomImageOff;

		[Token(Token = "0x4010216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string E_ImageTdy;

		[Token(Token = "0x600BB58")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB59")]
		[Address(RVA = "0x576CD0", Offset = "0x575ED0", VA = "0x180576CD0", Slot = "4")]
		internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600BB5A")]
		[Address(RVA = "0x576E50", Offset = "0x576050", VA = "0x180576E50", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB5B")]
		[Address(RVA = "0x577110", Offset = "0x576310", VA = "0x180577110")]
		public ColosseumMenuRoom()
		{
		}
	}

	[Token(Token = "0x2001D24")]
	internal class ColosseumMenuFree : ColosseumMenuFreeDuel
	{
		[Token(Token = "0x4010219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string BTN_FREE_LABEL;

		[Token(Token = "0x401021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string OBJ_FREE_STATE_LABEL;

		[Token(Token = "0x401021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string SCROLL_LABEL;

		[Token(Token = "0x600BB5F")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB60")]
		[Address(RVA = "0x574890", Offset = "0x573A90", VA = "0x180574890", Slot = "4")]
		internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600BB61")]
		[Address(RVA = "0x574A80", Offset = "0x573C80", VA = "0x180574A80", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB62")]
		[Address(RVA = "0x574BA0", Offset = "0x573DA0", VA = "0x180574BA0")]
		public ColosseumMenuFree()
		{
		}
	}

	[Token(Token = "0x2001D26")]
	internal class ColosseumMenuTeam : ColosseumMenuFreeDuel
	{
		[Token(Token = "0x4010220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string BTN_TEAM_LABEL;

		[Token(Token = "0x4010221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string OBJ_TEAM_STATE_LABEL;

		[Token(Token = "0x4010222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string SCROLL_LABEL;

		[Token(Token = "0x600BB67")]
		[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB68")]
		[Address(RVA = "0x577DB0", Offset = "0x576FB0", VA = "0x180577DB0", Slot = "4")]
		internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600BB69")]
		[Address(RVA = "0x577FA0", Offset = "0x5771A0", VA = "0x180577FA0", Slot = "6")]
		internal override void Update()
		{
		}

		[Token(Token = "0x600BB6A")]
		[Address(RVA = "0x5780C0", Offset = "0x5772C0", VA = "0x1805780C0")]
		public ColosseumMenuTeam()
		{
		}
	}

	[Token(Token = "0x2001D28")]
	internal abstract class ColosseumMenuRankDuel : ColosseumMenuBase
	{
		[Token(Token = "0x4010227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected GameObject selfGo;

		[Token(Token = "0x4010228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected SelectionButton selfBtn;

		[Token(Token = "0x600BB6F")]
		[Address(RVA = "0x574880", Offset = "0x573A80", VA = "0x180574880")]
		protected ColosseumMenuRankDuel()
		{
		}
	}

	[Token(Token = "0x2001D29")]
	internal class ColosseumMenuStandard : ColosseumMenuRankDuel
	{
		[Token(Token = "0x4010229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string E_ImageTdy;

		[Token(Token = "0x401022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ColosseumFlagManager m_flagManager;

		[Token(Token = "0x401022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_IsRate;

		[Token(Token = "0x600BB70")]
		[Address(RVA = "0x577D50", Offset = "0x576F50", VA = "0x180577D50")]
		internal ColosseumMenuStandard()
		{
		}

		[Token(Token = "0x600BB71")]
		[Address(RVA = "0x5771D0", Offset = "0x5763D0", VA = "0x1805771D0")]
		private string GetPrefPath()
		{
			return null;
		}

		[Token(Token = "0x600BB72")]
		[Address(RVA = "0x5771B0", Offset = "0x5763B0", VA = "0x1805771B0", Slot = "7")]
		internal override ColosseumUtil.PlayMode GetPlayMode()
		{
			return default(ColosseumUtil.PlayMode);
		}

		[Token(Token = "0x600BB73")]
		[Address(RVA = "0x577220", Offset = "0x576420", VA = "0x180577220", Slot = "4")]
		internal override void Init(ElementObjectManager m_View, ViewControllerManager manager)
		{
		}

		[Token(Token = "0x600BB74")]
		[Address(RVA = "0x577450", Offset = "0x576650", VA = "0x180577450", Slot = "6")]
		internal override void Update()
		{
		}
	}

	[Token(Token = "0x40101C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x40101C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BUTTON_SEASON_POINT;

	[Token(Token = "0x40101C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string BUTTON_WCS_DECK;

	[Token(Token = "0x40101C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string NEW_BADGE_LABEL;

	[Token(Token = "0x40101C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_EMPTY_EVENTS_LABEL;

	[Token(Token = "0x40101C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string IMG_EMPTY_EVENTS_LABEL;

	[Token(Token = "0x40101C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TXT_NAME_LABEL;

	[Token(Token = "0x40101C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40101C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private InfinityScrollView isv;

	[Token(Token = "0x40101CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ColosseumMenuManager colosseumManager;

	[Token(Token = "0x40101CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isFirstFade;

	[Token(Token = "0x17001BF2")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600BAE0")]
		[Address(RVA = "0x579F30", Offset = "0x579130", VA = "0x180579F30", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BF3")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600BAE1")]
		[Address(RVA = "0x579FA0", Offset = "0x5791A0", VA = "0x180579FA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BAE2")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BAE3")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600BAE4")]
	[Address(RVA = "0x578ED0", Offset = "0x5780D0", VA = "0x180578ED0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BAE5")]
	[Address(RVA = "0x579100", Offset = "0x578300", VA = "0x180579100", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x600BAE6")]
	[Address(RVA = "0x5793C0", Offset = "0x5785C0", VA = "0x1805793C0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600BAE7")]
	[Address(RVA = "0x578EC0", Offset = "0x5780C0", VA = "0x180578EC0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600BAE8")]
	[Address(RVA = "0x578DD0", Offset = "0x577FD0", VA = "0x180578DD0")]
	private void CallAPIDuelMenuInfo([Optional] Action onSuccess)
	{
	}

	[Token(Token = "0x600BAE9")]
	[Address(RVA = "0x5795E0", Offset = "0x5787E0", VA = "0x1805795E0")]
	private void UpdateMenu()
	{
	}

	[Token(Token = "0x600BAEA")]
	[Address(RVA = "0x5791B0", Offset = "0x5783B0", VA = "0x1805791B0")]
	internal void OnItemSetData(GameObject go, int index)
	{
	}

	[Token(Token = "0x600BAEB")]
	[Address(RVA = "0x579D90", Offset = "0x578F90", VA = "0x180579D90")]
	public ColosseumViewController()
	{
	}
}
