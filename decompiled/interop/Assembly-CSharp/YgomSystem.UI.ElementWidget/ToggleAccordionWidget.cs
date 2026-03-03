using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000620")]
public class ToggleAccordionWidget : ElementWidgetBase
{
	[Token(Token = "0x4001DA3")]
	private const string k_ELabelHandleToggle = "HandleToggle";

	[Token(Token = "0x4001DA4")]
	private const string k_TLabelToOpen = "ToOpen";

	[Token(Token = "0x4001DA5")]
	private const string k_TLabelToClose = "ToClose";

	[Token(Token = "0x4001DA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, ToggleWidget> m_ChildToggles;

	[Token(Token = "0x4001DA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Tween> m_ToOpenTweens;

	[Token(Token = "0x4001DA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Tween> m_ToCloseTweens;

	[Token(Token = "0x4001DA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ElementEntityFactory m_EntityFactory;

	[Token(Token = "0x4001DAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ToggleWidget m_GroupTabToggle;

	[Token(Token = "0x4001DAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isOnTween;

	[Token(Token = "0x1700050A")]
	public Dictionary<int, ToggleWidget> childToggles
	{
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050B")]
	public ElementEntityFactory entityFactory
	{
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050C")]
	public ToggleWidget groupTabToggle
	{
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0x6B0F00", Offset = "0x6B0100", VA = "0x1806B0F00")]
	private List<Tween> GetTweenByLabel(string label)
	{
		return null;
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0x6B0B40", Offset = "0x6AFD40", VA = "0x1806B0B40")]
	public void AddChild(int index, ToggleWidget child)
	{
	}

	[Token(Token = "0x6002865")]
	[Address(RVA = "0x6B16B0", Offset = "0x6B08B0", VA = "0x1806B16B0")]
	public ToggleAccordionWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6002866")]
	[Address(RVA = "0x6B0BD0", Offset = "0x6AFDD0", VA = "0x1806B0BD0")]
	public void CaptureTweenFrom()
	{
	}

	[Token(Token = "0x6002867")]
	[Address(RVA = "0x6B0F90", Offset = "0x6B0190", VA = "0x1806B0F90")]
	public void PlayTween(bool isOn, bool immediate = false, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x6002868")]
	[Address(RVA = "0x6B0A70", Offset = "0x6AFC70", VA = "0x1806B0A70")]
	public void ActiveChildItems(bool isOn)
	{
	}

	[Token(Token = "0x6002869")]
	[Address(RVA = "0x6B0C60", Offset = "0x6AFE60", VA = "0x1806B0C60")]
	private void CheckCollectTween()
	{
	}

	[Token(Token = "0x600286A")]
	[Address(RVA = "0x6B1330", Offset = "0x6B0530", VA = "0x1806B1330")]
	private void StopAllTween()
	{
	}

	[Token(Token = "0x600286B")]
	[Address(RVA = "0x6B1500", Offset = "0x6B0700", VA = "0x1806B1500")]
	private void TargetGotoAndPlayLabel(string label, bool wakeup, bool immediate)
	{
	}

	[Token(Token = "0x600286C")]
	[Address(RVA = "0x6B10D0", Offset = "0x6B02D0", VA = "0x1806B10D0")]
	private void SetFinishTweenAction(string label, [Optional] Action onCompleted)
	{
	}
}
