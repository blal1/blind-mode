using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005E5")]
public class MultiVCTabGroupWidget : ElementWidgetBase, ISubTabWidget
{
	[Token(Token = "0x4001C51")]
	private const string k_ELabelHandleToggle = "HandleToggle";

	[Token(Token = "0x4001C52")]
	private const string k_TLabelToOpen = "ToOpen";

	[Token(Token = "0x4001C53")]
	private const string k_TLabelToClose = "ToClose";

	[Token(Token = "0x4001C54")]
	[FieldOffset(Offset = "0x20")]
	private readonly MultiVCTabWidget m_TabWidget;

	[Token(Token = "0x4001C55")]
	[FieldOffset(Offset = "0x28")]
	private readonly ElementEntityFactory m_EntityFactory;

	[Token(Token = "0x4001C56")]
	[FieldOffset(Offset = "0x30")]
	private List<Tween> m_ToOpenTweens;

	[Token(Token = "0x4001C57")]
	[FieldOffset(Offset = "0x38")]
	private List<Tween> m_ToCloseTweens;

	[Token(Token = "0x1700049B")]
	public MultiVCTabWidget tabWidget
	{
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049C")]
	public ElementEntityFactory entityFactory
	{
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049D")]
	public MultiVCTabGroupWidget parentGroup
	{
		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026AC")]
	[Address(RVA = "0x694670", Offset = "0x693870", VA = "0x180694670")]
	private List<Tween> GetTweenByLabel(string label)
	{
		return null;
	}

	[Token(Token = "0x60026AD")]
	[Address(RVA = "0x694BE0", Offset = "0x693DE0", VA = "0x180694BE0")]
	public MultiVCTabGroupWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x694360", Offset = "0x693560", VA = "0x180694360")]
	public void CaptureTweenFrom()
	{
	}

	[Token(Token = "0x60026AF")]
	[Address(RVA = "0x694700", Offset = "0x693900", VA = "0x180694700")]
	public void PlayTween(bool isOn, bool immediate = false)
	{
	}

	[Token(Token = "0x60026B0")]
	[Address(RVA = "0x6943E0", Offset = "0x6935E0", VA = "0x1806943E0")]
	private void CheckCollectTween()
	{
	}

	[Token(Token = "0x60026B1")]
	[Address(RVA = "0x694810", Offset = "0x693A10", VA = "0x180694810")]
	private void StopAllTween()
	{
	}

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x6949E0", Offset = "0x693BE0", VA = "0x1806949E0")]
	private void TargetGotoAndPlayLabel(string label, bool wakeup, bool immediate)
	{
	}
}
