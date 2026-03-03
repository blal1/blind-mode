using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomGame.Utility;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu;

[Token(Token = "0x200134E")]
public class ProfileReplayViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200134F")]
	internal class ReplayInfo
	{
		[Token(Token = "0x400C0DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long did;

		[Token(Token = "0x400C0DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int mode;

		[Token(Token = "0x400C0DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal long timestamp;

		[Token(Token = "0x400C0E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string dateTime;

		[Token(Token = "0x400C0E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Engine.ResultType result;

		[Token(Token = "0x400C0E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string title;

		[Token(Token = "0x400C0E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal string turn;

		[Token(Token = "0x400C0E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal bool isOpen;

		[Token(Token = "0x400C0E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		internal bool isSameOS;

		[Token(Token = "0x400C0E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string onlineId;

		[Token(Token = "0x400C0E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal bool isLocked;

		[Token(Token = "0x400C0E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal int choice;

		[Token(Token = "0x400C0E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal int myId;

		[Token(Token = "0x400C0EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		internal int first;

		[Token(Token = "0x400C0EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal List<object> tagIds;

		[Token(Token = "0x400C0EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal GameObject lockIcon;

		[Token(Token = "0x400C0ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal GameObject imageOpen;

		[Token(Token = "0x400C0EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal UserInfo[] userInfos;

		[Token(Token = "0x60077FD")]
		[Address(RVA = "0xBFA2E0", Offset = "0xBF94E0", VA = "0x180BFA2E0")]
		public ReplayInfo(long did, int mode, long timestamp, string dateTime, Engine.ResultType result, string title, string turn, bool isOpen, UserInfo myInfo, UserInfo rivalInfo, bool isSameOS = false, [Optional] string onlineId, bool isLocked = false, int choice = 0, int myId = 0, int first = 0, [Optional] List<object> tagIds)
		{
		}

		[Token(Token = "0x60077FE")]
		[Address(RVA = "0xBFA290", Offset = "0xBF9490", VA = "0x180BFA290")]
		public UserInfo GetInfo(bool isMine)
		{
			return null;
		}
	}

	[Token(Token = "0x2001350")]
	internal class UserInfo
	{
		[Token(Token = "0x400C0EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int iconID;

		[Token(Token = "0x400C0F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int frameID;

		[Token(Token = "0x400C0F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int deckCaseID;

		[Token(Token = "0x400C0F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int coinID;

		[Token(Token = "0x400C0F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int regulationID;

		[Token(Token = "0x400C0F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal long pcode;

		[Token(Token = "0x400C0F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string name;

		[Token(Token = "0x400C0F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Dictionary<string, object> pickCards;

		[Token(Token = "0x400C0F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Dictionary<string, object> deck;

		[Token(Token = "0x60077FF")]
		[Address(RVA = "0xC01550", Offset = "0xC00750", VA = "0x180C01550")]
		public UserInfo(int iconID, int frameID, int deckCaseID, int coinID, int regulationID, long pcode, string name, Dictionary<string, object> pickCards, Dictionary<string, object> deck)
		{
		}
	}

	[Token(Token = "0x2001351")]
	internal class PickCard
	{
		[Token(Token = "0x400C0F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int index;

		[Token(Token = "0x400C0F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int cardID;

		[Token(Token = "0x400C0FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal RawImage imageCard;

		[Token(Token = "0x6007800")]
		[Address(RVA = "0xBE8EE0", Offset = "0xBE80E0", VA = "0x180BE8EE0")]
		public void SetPickCard(int cardId)
		{
		}

		[Token(Token = "0x6007801")]
		[Address(RVA = "0xBE8F80", Offset = "0xBE8180", VA = "0x180BE8F80")]
		public PickCard(int index, int cardID, RawImage imageCard)
		{
		}
	}

	[Token(Token = "0x400C0BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_VIEW_LABEL;

	[Token(Token = "0x400C0BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string LOCK_ICON_LABEL;

	[Token(Token = "0x400C0BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400C0BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string IMG_ICON_COIN_FIRST_LABEL;

	[Token(Token = "0x400C0BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string INFORMATION_LABEL;

	[Token(Token = "0x400C0BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TAG_HOLDER_LABEL;

	[Token(Token = "0x400C0C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TAG_TEMPLATE_LABEL;

	[Token(Token = "0x400C0C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TMP_IMG_OPEN_LABEL;

	[Token(Token = "0x400C0C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TMP_TXT_RESULT_LABEL;

	[Token(Token = "0x400C0C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TMP_TXT_MODE_LABEL;

	[Token(Token = "0x400C0C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string TMP_TXT_DATE_LABEL;

	[Token(Token = "0x400C0C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string TMP_TXT_TURN_LABEL;

	[Token(Token = "0x400C0C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string TMP_TXT_ORDER_LABEL;

	[Token(Token = "0x400C0C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string TMP_TXT_NUM_LABEL;

	[Token(Token = "0x400C0C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string TMP_TXT_NUM_GROUP_LABEL;

	[Token(Token = "0x400C0C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string TMP_TXT_PLATFORM_NAME_LABEL;

	[Token(Token = "0x400C0CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string TMP_TXT_PLATFORM_ICON_LABEL;

	[Token(Token = "0x400C0CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string TXT_EMPTY_LABEL;

	[Token(Token = "0x400C0CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string TXT_SETTING_LABEL;

	[Token(Token = "0x400C0CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string TXT_OPEN_LABEL;

	[Token(Token = "0x400C0CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string TMP_BTN_LABEL;

	[Token(Token = "0x400C0CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string TMP_BTN_OPEN_LABEL;

	[Token(Token = "0x400C0D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string TMP_BTN_SETTING_LABEL;

	[Token(Token = "0x400C0D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string TMP_BTN_PROTECT_LABEL;

	[Token(Token = "0x400C0D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string TMP_BTN_PLAY_LABEL;

	[Token(Token = "0x400C0D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private InfinityScrollView isv;

	[Token(Token = "0x400C0D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int itemIndex;

	[Token(Token = "0x400C0D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private int coinIdCache;

	[Token(Token = "0x400C0D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private long pcode;

	[Token(Token = "0x400C0D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool isSelectMaxIndex;

	[Token(Token = "0x400C0D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
	private bool coinHeadCache;

	[Token(Token = "0x400C0D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
	private bool isFirstCoinBinding;

	[Token(Token = "0x400C0DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<bool> isSelected;

	[Token(Token = "0x400C0DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<ReplayInfo> replayInfos;

	[Token(Token = "0x400C0DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private List<TextMeshProUGUI> tagList;

	[Token(Token = "0x1700129B")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60077DE")]
		[Address(RVA = "0xBF5C30", Offset = "0xBF4E30", VA = "0x180BF5C30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077DF")]
	[Address(RVA = "0xBEF3F0", Offset = "0xBEE5F0", VA = "0x180BEF3F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60077E0")]
	[Address(RVA = "0xBEF540", Offset = "0xBEE740", VA = "0x180BEF540", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60077E1")]
	[Address(RVA = "0xBF0CB0", Offset = "0xBEFEB0", VA = "0x180BF0CB0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x60077E2")]
	[Address(RVA = "0xBEF640", Offset = "0xBEE840", VA = "0x180BEF640", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60077E3")]
	[Address(RVA = "0xBF1320", Offset = "0xBF0520", VA = "0x180BF1320")]
	private void SetReplayOpen(long did, bool isOpen)
	{
	}

	[Token(Token = "0x60077E4")]
	[Address(RVA = "0xBEE990", Offset = "0xBEDB90", VA = "0x180BEE990")]
	private void CheckDeck(int itemIndex, bool isMine, int regulationId = 0)
	{
	}

	[Token(Token = "0x60077E5")]
	[Address(RVA = "0xBEF040", Offset = "0xBEE240", VA = "0x180BEF040")]
	private Dictionary<string, object> GetDeckCards(bool isMain, bool isMine)
	{
		return null;
	}

	[Token(Token = "0x60077E6")]
	[Address(RVA = "0xBF1160", Offset = "0xBF0360", VA = "0x180BF1160")]
	private void OpenProfileCard(long pcode)
	{
	}

	[Token(Token = "0x60077E7")]
	[Address(RVA = "0xBEEC70", Offset = "0xBEDE70", VA = "0x180BEEC70")]
	private void DeleteReplayDialog(long did, string strDate)
	{
	}

	[Token(Token = "0x60077E8")]
	[Address(RVA = "0xBF0D50", Offset = "0xBEFF50", VA = "0x180BF0D50")]
	private void OpenEdit(long did)
	{
	}

	[Token(Token = "0x60077E9")]
	[Address(RVA = "0xBEEED0", Offset = "0xBEE0D0", VA = "0x180BEEED0")]
	private void DeleteReplay(long did)
	{
	}

	[Token(Token = "0x60077EA")]
	[Address(RVA = "0xBF1260", Offset = "0xBF0460", VA = "0x180BF1260")]
	private void PlayReplay(long did)
	{
	}

	[Token(Token = "0x60077EB")]
	[Address(RVA = "0xBEFF60", Offset = "0xBEF160", VA = "0x180BEFF60")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60077EC")]
	[Address(RVA = "0xBF3AF0", Offset = "0xBF2CF0", VA = "0x180BF3AF0")]
	private void UpdateProfileReplay(Dictionary<string, object> replayDic)
	{
	}

	[Token(Token = "0x60077ED")]
	[Address(RVA = "0xBF2E80", Offset = "0xBF2080", VA = "0x180BF2E80")]
	public void UpdateInfo(int itemIndex)
	{
	}

	[Token(Token = "0x60077EE")]
	[Address(RVA = "0xBF13F0", Offset = "0xBF05F0", VA = "0x180BF13F0")]
	private void SortReplayDate(bool descendingOrder = true)
	{
	}

	[Token(Token = "0x60077EF")]
	[Address(RVA = "0xBEE920", Offset = "0xBEDB20", VA = "0x180BEE920")]
	private void ChangeEmpty()
	{
	}

	[Token(Token = "0x60077F0")]
	[Address(RVA = "0xBEFF00", Offset = "0xBEF100", VA = "0x180BEFF00")]
	private void OnGsvStanby()
	{
	}

	[Token(Token = "0x60077F1")]
	[Address(RVA = "0xBEF3E0", Offset = "0xBEE5E0", VA = "0x180BEF3E0")]
	private int GetDefaultAccessoryId(ItemUtil.Category category)
	{
		return default(int);
	}

	[Token(Token = "0x60077F2")]
	[Address(RVA = "0xBF5790", Offset = "0xBF4990", VA = "0x180BF5790")]
	public ProfileReplayViewController()
	{
	}
}
