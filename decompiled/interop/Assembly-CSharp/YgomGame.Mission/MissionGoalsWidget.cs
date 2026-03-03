using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000C0C")]
public class MissionGoalsWidget : ElementWidgetBase
{
	[Token(Token = "0x40099B7")]
	[FieldOffset(Offset = "0x20")]
	private readonly int k_ELabelGoalWidgetMax;

	[Token(Token = "0x40099B8")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelGoalHolderFormat;

	[Token(Token = "0x40099B9")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelGauge;

	[Token(Token = "0x40099BA")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelGaugeStartHead;

	[Token(Token = "0x40099BB")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelGaugeGaugeStartHeadFill;

	[Token(Token = "0x40099BC")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelGaugeExtendHead;

	[Token(Token = "0x40099BD")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelGaugeExtendHeadFill;

	[Token(Token = "0x40099BE")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelGaugeExtendTail;

	[Token(Token = "0x40099BF")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelGaugeExtendTailFill;

	[Token(Token = "0x40099C0")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelSecretFilter;

	[Token(Token = "0x40099C1")]
	[FieldOffset(Offset = "0x70")]
	public int idx;

	[Token(Token = "0x40099C2")]
	[FieldOffset(Offset = "0x78")]
	public readonly MissionPanelWidget ownerPanel;

	[Token(Token = "0x40099C3")]
	[FieldOffset(Offset = "0x80")]
	public readonly Slider gauge;

	[Token(Token = "0x40099C4")]
	[FieldOffset(Offset = "0x88")]
	public readonly GameObject gaugeStartHead;

	[Token(Token = "0x40099C5")]
	[FieldOffset(Offset = "0x90")]
	public readonly GameObject gaugeStartHeadFill;

	[Token(Token = "0x40099C6")]
	[FieldOffset(Offset = "0x98")]
	public readonly GameObject gaugeExtendHeadBar;

	[Token(Token = "0x40099C7")]
	[FieldOffset(Offset = "0xA0")]
	public readonly GameObject gaugeExtendHeadFill;

	[Token(Token = "0x40099C8")]
	[FieldOffset(Offset = "0xA8")]
	public readonly GameObject gaugeExtendTailBar;

	[Token(Token = "0x40099C9")]
	[FieldOffset(Offset = "0xB0")]
	public readonly GameObject gaugeExtendTailFill;

	[Token(Token = "0x40099CA")]
	[FieldOffset(Offset = "0xB8")]
	public readonly Slider secretFilterGauge;

	[Token(Token = "0x40099CB")]
	[FieldOffset(Offset = "0xC0")]
	public readonly List<MissionGoalHolderWidget> goalHolders;

	[Token(Token = "0x6004969")]
	[Address(RVA = "0x91FC60", Offset = "0x91EE60", VA = "0x18091FC60")]
	public MissionGoalsWidget(ElementObjectManager eom, MissionPanelWidget ownerPanel)
	{
	}
}
