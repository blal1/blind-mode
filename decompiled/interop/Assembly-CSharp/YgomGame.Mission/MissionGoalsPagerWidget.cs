using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C0B")]
public class MissionGoalsPagerWidget : ElementWidgetBase
{
	[Token(Token = "0x40099AB")]
	[FieldOffset(Offset = "0x20")]
	private string k_ELabelShortcutKeyIconR;

	[Token(Token = "0x40099AC")]
	[FieldOffset(Offset = "0x28")]
	private string k_ELabelShortcutKeyIconL;

	[Token(Token = "0x40099AD")]
	[FieldOffset(Offset = "0x30")]
	public readonly MissionPanelWidget ownerPanel;

	[Token(Token = "0x40099AE")]
	[FieldOffset(Offset = "0x38")]
	public readonly Selector selector;

	[Token(Token = "0x40099AF")]
	[FieldOffset(Offset = "0x40")]
	public readonly ScrollRectPageSnap pageSnap;

	[Token(Token = "0x40099B0")]
	[FieldOffset(Offset = "0x48")]
	public readonly ScrollRectPageSnapButtons pageButtons;

	[Token(Token = "0x40099B1")]
	[FieldOffset(Offset = "0x50")]
	public readonly InfinityScrollView scrollView;

	[Token(Token = "0x40099B2")]
	[FieldOffset(Offset = "0x58")]
	public readonly ScrollRect scrollRect;

	[Token(Token = "0x40099B3")]
	[FieldOffset(Offset = "0x60")]
	public readonly List<MissionGoalsWidget> goalsWidgets;

	[Token(Token = "0x40099B4")]
	[FieldOffset(Offset = "0x68")]
	public Action<MissionGoalsPagerWidget> onPageChangedCallback;

	[Token(Token = "0x40099B5")]
	[FieldOffset(Offset = "0x70")]
	public Action onPlayPagingBeginCallback;

	[Token(Token = "0x40099B6")]
	[FieldOffset(Offset = "0x78")]
	public Action onPlayPagingEndCallback;

	[Token(Token = "0x170009E1")]
	public GameObject shortcutKeyIconR
	{
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x818900", Offset = "0x817B00", VA = "0x180818900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E2")]
	public GameObject shortcutKeyIconL
	{
		[Token(Token = "0x6004962")]
		[Address(RVA = "0x88DAB0", Offset = "0x88CCB0", VA = "0x18088DAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E3")]
	public MissionGoalsWidget CurrentGoalsWidget
	{
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x91FB10", Offset = "0x91ED10", VA = "0x18091FB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004964")]
	[Address(RVA = "0x91F800", Offset = "0x91EA00", VA = "0x18091F800")]
	public bool IsEnabledPrev()
	{
		return default(bool);
	}

	[Token(Token = "0x6004965")]
	[Address(RVA = "0x91F7D0", Offset = "0x91E9D0", VA = "0x18091F7D0")]
	public bool IsEnabledNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6004966")]
	[Address(RVA = "0x91F850", Offset = "0x91EA50", VA = "0x18091F850")]
	public MissionGoalsPagerWidget(ElementObjectManager eom, MissionPanelWidget ownerPanel)
	{
	}

	[Token(Token = "0x6004967")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnPagingTweenEnd()
	{
	}

	[Token(Token = "0x6004968")]
	[Address(RVA = "0x91F830", Offset = "0x91EA30", VA = "0x18091F830")]
	private void OnPageChanged()
	{
	}
}
