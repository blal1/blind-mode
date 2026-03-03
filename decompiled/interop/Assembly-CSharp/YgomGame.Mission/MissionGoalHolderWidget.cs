using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000C0A")]
public class MissionGoalHolderWidget : ElementWidgetBase
{
	[Token(Token = "0x40099A2")]
	[FieldOffset(Offset = "0x20")]
	public int idx;

	[Token(Token = "0x40099A3")]
	[FieldOffset(Offset = "0x28")]
	public readonly MissionGoalsWidget ownerGoals;

	[Token(Token = "0x40099A4")]
	[FieldOffset(Offset = "0x30")]
	public readonly SelectionButton button;

	[Token(Token = "0x40099A5")]
	[FieldOffset(Offset = "0x38")]
	public readonly GameObject root;

	[Token(Token = "0x40099A6")]
	[FieldOffset(Offset = "0x40")]
	public MissionGoalWidget goalWidget;

	[Token(Token = "0x40099A7")]
	[FieldOffset(Offset = "0x48")]
	private LayoutElement m_LayoutElementCache;

	[Token(Token = "0x40099A8")]
	[FieldOffset(Offset = "0x50")]
	public Action<MissionGoalHolderWidget> onClickCallback;

	[Token(Token = "0x40099A9")]
	[FieldOffset(Offset = "0x58")]
	public Action<MissionGoalHolderWidget> onSelectedCallback;

	[Token(Token = "0x40099AA")]
	[FieldOffset(Offset = "0x60")]
	public Action<MissionGoalHolderWidget> onDeselectedCallback;

	[Token(Token = "0x170009E0")]
	public LayoutElement layoutElement
	{
		[Token(Token = "0x600495C")]
		[Address(RVA = "0x91EC40", Offset = "0x91DE40", VA = "0x18091EC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600495D")]
	[Address(RVA = "0x91EA80", Offset = "0x91DC80", VA = "0x18091EA80")]
	public MissionGoalHolderWidget(ElementObjectManager eom, MissionGoalsWidget ownerGoals)
	{
	}

	[Token(Token = "0x600495E")]
	[Address(RVA = "0x91EA20", Offset = "0x91DC20", VA = "0x18091EA20")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600495F")]
	[Address(RVA = "0x91EA60", Offset = "0x91DC60", VA = "0x18091EA60")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x6004960")]
	[Address(RVA = "0x91EA40", Offset = "0x91DC40", VA = "0x18091EA40")]
	private void OnDeselected()
	{
	}
}
