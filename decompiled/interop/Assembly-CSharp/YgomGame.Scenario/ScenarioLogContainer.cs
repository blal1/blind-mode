using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A72")]
public class ScenarioLogContainer : ScenarioContainerBase
{
	[Token(Token = "0x40091F4")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelScrollArea;

	[Token(Token = "0x40091F5")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelTextMeshTemplate;

	[Token(Token = "0x40091F6")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelCloseButton;

	[Token(Token = "0x40091F7")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_TweenShow;

	[Token(Token = "0x40091F8")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_TweenHide;

	[Token(Token = "0x40091F9")]
	[FieldOffset(Offset = "0x50")]
	private readonly ScrollRect m_ScrollArea;

	[Token(Token = "0x40091FA")]
	[FieldOffset(Offset = "0x58")]
	private readonly ExtendedTextMeshProUGUI m_TextMeshTemplate;

	[Token(Token = "0x40091FB")]
	[FieldOffset(Offset = "0x60")]
	private int m_CreatedLogCnt;

	[Token(Token = "0x40091FC")]
	[FieldOffset(Offset = "0x68")]
	public Action onClickCloseCallback;

	[Token(Token = "0x6004032")]
	[Address(RVA = "0x886320", Offset = "0x885520", VA = "0x180886320")]
	public ScenarioLogContainer(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004033")]
	[Address(RVA = "0x885F40", Offset = "0x885140", VA = "0x180885F40")]
	public void Initialize(int selectorPriority)
	{
	}

	[Token(Token = "0x6004034")]
	[Address(RVA = "0x886210", Offset = "0x885410", VA = "0x180886210")]
	public void Show(IReadOnlyList<IScenarioLogBehavior> logBehaviors)
	{
	}

	[Token(Token = "0x6004035")]
	[Address(RVA = "0x885EB0", Offset = "0x8850B0", VA = "0x180885EB0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6004036")]
	[Address(RVA = "0x885CC0", Offset = "0x884EC0", VA = "0x180885CC0")]
	private void CheckLogsInsert(IReadOnlyList<IScenarioLogBehavior> logBehaviors)
	{
	}

	[Token(Token = "0x6004037")]
	[Address(RVA = "0x885FB0", Offset = "0x8851B0", VA = "0x180885FB0")]
	public void InsertLogText(IScenarioLogTextBehavior logText)
	{
	}

	[Token(Token = "0x6004038")]
	[Address(RVA = "0x8861E0", Offset = "0x8853E0", VA = "0x1808861E0")]
	private void OnTweenOpenStart()
	{
	}

	[Token(Token = "0x6004039")]
	[Address(RVA = "0x8861B0", Offset = "0x8853B0", VA = "0x1808861B0")]
	private void OnTweenCloseFinished()
	{
	}
}
