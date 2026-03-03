using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A7F")]
public class ScenarioObjectContainerUI : ScenarioContainerBase
{
	[Token(Token = "0x4009271")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelRootUI;

	[Token(Token = "0x4009272")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelClickAreaButton;

	[Token(Token = "0x4009273")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelRootScreen;

	[Token(Token = "0x4009274")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelTextArea;

	[Token(Token = "0x4009275")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelScreenTextUnder;

	[Token(Token = "0x4009276")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelScreenTextOver;

	[Token(Token = "0x4009277")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelMenuArea;

	[Token(Token = "0x4009278")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelLogScreen;

	[Token(Token = "0x4009279")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelInputBlocker;

	[Token(Token = "0x400927A")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelInputBlockerButton;

	[Token(Token = "0x400927B")]
	[FieldOffset(Offset = "0x78")]
	public readonly Selector inputBlocker;

	[Token(Token = "0x400927C")]
	[FieldOffset(Offset = "0x80")]
	public readonly SelectionButton clickAreaButton;

	[Token(Token = "0x400927D")]
	[FieldOffset(Offset = "0x88")]
	public readonly ScenarioRootScreen rootScreen;

	[Token(Token = "0x400927E")]
	[FieldOffset(Offset = "0x90")]
	public readonly ScenarioTextContainer textContainer;

	[Token(Token = "0x400927F")]
	[FieldOffset(Offset = "0x98")]
	public readonly ScenarioScreenContainer screenContainer;

	[Token(Token = "0x4009280")]
	[FieldOffset(Offset = "0xA0")]
	public readonly ScenarioMenuContainer menuContainer;

	[Token(Token = "0x4009281")]
	[FieldOffset(Offset = "0xA8")]
	public readonly ScenarioLogContainer logContainer;

	[Token(Token = "0x4009282")]
	[FieldOffset(Offset = "0xB0")]
	public readonly ScenarioMovieContainer movieContainer;

	[Token(Token = "0x170008A1")]
	public GameObject rootUI
	{
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x88DAB0", Offset = "0x88CCB0", VA = "0x18088DAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000053")]
	public event Action onClickAreaEvent
	{
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x88D950", Offset = "0x88CB50", VA = "0x18088D950")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x88DAE0", Offset = "0x88CCE0", VA = "0x18088DAE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000054")]
	public event Action onClickInputBlockerEvent
	{
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x88DA00", Offset = "0x88CC00", VA = "0x18088DA00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x88DB90", Offset = "0x88CD90", VA = "0x18088DB90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60040AF")]
	[Address(RVA = "0x88D300", Offset = "0x88C500", VA = "0x18088D300")]
	public ScenarioObjectContainerUI(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60040B0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void Initialize(ScenarioWork work)
	{
	}

	[Token(Token = "0x60040B1")]
	[Address(RVA = "0x88D280", Offset = "0x88C480", VA = "0x18088D280")]
	public bool OnBack()
	{
		return default(bool);
	}
}
