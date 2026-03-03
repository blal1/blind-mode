using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.Menu;

[Token(Token = "0x2001244")]
public class LoginBonusSlotWidget : ElementWidgetBase
{
	[Token(Token = "0x2001245")]
	public enum Mode
	{
		[Token(Token = "0x400BAE6")]
		None,
		[Token(Token = "0x400BAE7")]
		Recieved,
		[Token(Token = "0x400BAE8")]
		RecieveFocus
	}

	[Token(Token = "0x2001246")]
	private struct Reward
	{
		[Token(Token = "0x400BAE9")]
		[FieldOffset(Offset = "0x0")]
		internal int day;

		[Token(Token = "0x400BAEA")]
		[FieldOffset(Offset = "0x4")]
		internal int num;

		[Token(Token = "0x400BAEB")]
		[FieldOffset(Offset = "0x8")]
		internal int category;

		[Token(Token = "0x400BAEC")]
		[FieldOffset(Offset = "0xC")]
		internal int itemId;

		[Token(Token = "0x400BAED")]
		[FieldOffset(Offset = "0x10")]
		internal bool is_period;
	}

	[Token(Token = "0x400BAD8")]
	private const string k_ELabelLabelText = "LabelText";

	[Token(Token = "0x400BAD9")]
	private const string k_ELabelRewardThumb = "RewardThumb";

	[Token(Token = "0x400BADA")]
	private const string k_ELabelRewardNum = "RewardNum";

	[Token(Token = "0x400BADB")]
	private const string k_ELabelRecievedCover = "RecievedCover";

	[Token(Token = "0x400BADC")]
	private const string k_ELabelRecieveFocusCover = "RecieveFocusCover";

	[Token(Token = "0x400BADD")]
	internal const string k_ELabelLabelTextImage = "LabelTextImage";

	[Token(Token = "0x400BADE")]
	internal const string k_OGLabelRewardThumb_Default = "Default";

	[Token(Token = "0x400BADF")]
	internal const string k_OGLabelRewardThumb_Structure = "Structure";

	[Token(Token = "0x400BAE0")]
	private const string LABEL_DAY_TEXT = "LabelText";

	[Token(Token = "0x400BAE2")]
	[FieldOffset(Offset = "0x24")]
	private Mode _mode;

	[Token(Token = "0x400BAE3")]
	[FieldOffset(Offset = "0x28")]
	private List<Reward> _rewards;

	[Token(Token = "0x400BAE4")]
	[FieldOffset(Offset = "0x30")]
	private int _loginBonusId;

	[Token(Token = "0x170011EC")]
	public int day
	{
		[Token(Token = "0x60071BC")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60071BB")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011ED")]
	public SelectionButton button
	{
		[Token(Token = "0x60071BD")]
		[Address(RVA = "0xB7A410", Offset = "0xB79610", VA = "0x180B7A410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011EE")]
	public TMP_Text labelText
	{
		[Token(Token = "0x60071BE")]
		[Address(RVA = "0xB7A460", Offset = "0xB79660", VA = "0x180B7A460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011EF")]
	public GameObject rewardThumb
	{
		[Token(Token = "0x60071BF")]
		[Address(RVA = "0xB7A660", Offset = "0xB79860", VA = "0x180B7A660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F0")]
	public PlatformOverriderGroup rewardOvGroup
	{
		[Token(Token = "0x60071C0")]
		[Address(RVA = "0xB7A600", Offset = "0xB79800", VA = "0x180B7A600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F1")]
	public TMP_Text rewardNum
	{
		[Token(Token = "0x60071C1")]
		[Address(RVA = "0xB7A5A0", Offset = "0xB797A0", VA = "0x180B7A5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F2")]
	public GameObject recievedCover
	{
		[Token(Token = "0x60071C2")]
		[Address(RVA = "0xB7A510", Offset = "0xB79710", VA = "0x180B7A510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F3")]
	public GameObject recieveFocusCover
	{
		[Token(Token = "0x60071C3")]
		[Address(RVA = "0xB7A4C0", Offset = "0xB796C0", VA = "0x180B7A4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F4")]
	public int rewardCount
	{
		[Token(Token = "0x60071C4")]
		[Address(RVA = "0xB7A560", Offset = "0xB79760", VA = "0x180B7A560")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60071C5")]
	[Address(RVA = "0xB7A2C0", Offset = "0xB794C0", VA = "0x180B7A2C0")]
	public LoginBonusSlotWidget(ElementObjectManager eom, int lbId)
	{
	}

	[Token(Token = "0x60071C6")]
	[Address(RVA = "0xB792E0", Offset = "0xB784E0", VA = "0x180B792E0")]
	public void BindImage(string label, Sprite image)
	{
	}

	[Token(Token = "0x60071C7")]
	[Address(RVA = "0xB79960", Offset = "0xB78B60", VA = "0x180B79960")]
	public void SetMode(Mode mode)
	{
	}

	[Token(Token = "0x60071C8")]
	[Address(RVA = "0xB79780", Offset = "0xB78980", VA = "0x180B79780")]
	public void Ready()
	{
	}

	[Token(Token = "0x60071C9")]
	[Address(RVA = "0xB7A250", Offset = "0xB79450", VA = "0x180B7A250")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60071CA")]
	[Address(RVA = "0xB78C70", Offset = "0xB77E70", VA = "0x180B78C70")]
	public void AddData(Dictionary<string, object> source, int slotNumber)
	{
	}

	[Token(Token = "0x60071CB")]
	[Address(RVA = "0xB79B60", Offset = "0xB78D60", VA = "0x180B79B60")]
	public void ShowItem()
	{
	}

	[Token(Token = "0x60071CC")]
	[Address(RVA = "0xB79C50", Offset = "0xB78E50", VA = "0x180B79C50")]
	public void ShowObtainedItem(EntryItemListData itemList, List<object> shopInfoList, Action callback, bool isPresentBoxSent = false)
	{
	}

	[Token(Token = "0x60071CD")]
	[Address(RVA = "0xB793C0", Offset = "0xB785C0", VA = "0x180B793C0")]
	private void DrawPackItem(object shopInfo)
	{
	}

	[Token(Token = "0x60071CE")]
	[Address(RVA = "0xB79560", Offset = "0xB78760", VA = "0x180B79560")]
	private void OpenOdds(object shopInfo)
	{
	}

	[Token(Token = "0x60071CF")]
	[Address(RVA = "0xB796A0", Offset = "0xB788A0", VA = "0x180B796A0")]
	private static void OpenShopSectionMainteDialog(Action callback)
	{
	}
}
