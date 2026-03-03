using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ECF")]
public class DuelPassViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400A4D5")]
	[FieldOffset(Offset = "0xD0")]
	private DuelpassProgressBarWidget progressBar;

	[Token(Token = "0x400A4D6")]
	[FieldOffset(Offset = "0xD8")]
	private DuelpassRewardPanelWidget rewardPanel;

	[Token(Token = "0x400A4D7")]
	[FieldOffset(Offset = "0xE0")]
	private DuelpassBulkRecieveButtonWidget bulkRecieveButton;

	[Token(Token = "0x400A4D9")]
	[FieldOffset(Offset = "0xF0")]
	private DuelpassPeriodDateWidget dateView;

	[Token(Token = "0x400A4DA")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject goldFog;

	[Token(Token = "0x400A4DB")]
	[FieldOffset(Offset = "0x100")]
	private TMP_Text textMessage;

	[Token(Token = "0x400A4DC")]
	[FieldOffset(Offset = "0x108")]
	private SelectionButton toShopButton;

	[Token(Token = "0x400A4DD")]
	[FieldOffset(Offset = "0x110")]
	private SelectionButton whatDuelpassButton;

	[Token(Token = "0x400A4DE")]
	[FieldOffset(Offset = "0x118")]
	private bool isFirst;

	[Token(Token = "0x17000DE2")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60059D0")]
		[Address(RVA = "0x9ECBD0", Offset = "0x9EBDD0", VA = "0x1809ECBD0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE3")]
	public DuelpassRecommendItemWidget recommendItemView
	{
		[Token(Token = "0x60059D2")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60059D1")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60059D3")]
	[Address(RVA = "0x9EC020", Offset = "0x9EB220", VA = "0x1809EC020", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60059D4")]
	[Address(RVA = "0x9ECA30", Offset = "0x9EBC30", VA = "0x1809ECA30", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60059D5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
	protected override void OnTransitionSetBg(TransitionType type)
	{
	}

	[Token(Token = "0x60059D6")]
	[Address(RVA = "0x9EC0D0", Offset = "0x9EB2D0", VA = "0x1809EC0D0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60059D7")]
	[Address(RVA = "0x9ECA60", Offset = "0x9EBC60", VA = "0x1809ECA60")]
	private void Start()
	{
	}

	[Token(Token = "0x60059D8")]
	[Address(RVA = "0x9EC160", Offset = "0x9EB360", VA = "0x1809EC160", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60059D9")]
	[Address(RVA = "0x9EC8D0", Offset = "0x9EBAD0", VA = "0x1809EC8D0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60059DA")]
	[Address(RVA = "0x9ECA90", Offset = "0x9EBC90", VA = "0x1809ECA90")]
	public void UpdateView()
	{
	}

	[Token(Token = "0x60059DB")]
	[Address(RVA = "0x9ECBC0", Offset = "0x9EBDC0", VA = "0x1809ECBC0")]
	public DuelPassViewController()
	{
	}
}
