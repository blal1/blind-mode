using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005F5")]
public class ProductShowcaseWidget : ElementWidgetBase
{
	[Token(Token = "0x20005F6")]
	public class Context
	{
		[Token(Token = "0x4001CA1")]
		[FieldOffset(Offset = "0x10")]
		public List<MultiVCTabListWidget.TabContext> subTabListCtx;

		[Token(Token = "0x4001CA2")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<(int, int), MultiVCTabHorizonWidget> horizonTabCtx;

		[Token(Token = "0x600270B")]
		[Address(RVA = "0x689680", Offset = "0x688880", VA = "0x180689680")]
		public Context()
		{
		}
	}

	[Token(Token = "0x4001C9C")]
	private const string k_ELabelSubTabs = "SubTabs";

	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0x20")]
	private readonly MultiVCTabListWidget m_SubTabListWidget;

	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0x28")]
	private readonly AccordionTabGroupWidget m_AccordionWidget;

	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0x30")]
	private readonly Selector[] m_Selectors;

	[Token(Token = "0x4001CA0")]
	[FieldOffset(Offset = "0x38")]
	public readonly Context ctx;

	[Token(Token = "0x170004B5")]
	public MultiVCTabListWidget subTabListWidget
	{
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004B6")]
	public AccordionTabGroupWidget accordionWidget
	{
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002708")]
	[Address(RVA = "0x69DD60", Offset = "0x69CF60", VA = "0x18069DD60")]
	public ProductShowcaseWidget(ElementObjectManager eom, MultiVCTabRootWidget owner, bool frag = false)
	{
	}

	[Token(Token = "0x6002709")]
	[Address(RVA = "0x69DC50", Offset = "0x69CE50", VA = "0x18069DC50")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x600270A")]
	[Address(RVA = "0x69DCE0", Offset = "0x69CEE0", VA = "0x18069DCE0")]
	public bool TrySelectDefault(bool isInitializeSelect = false)
	{
		return default(bool);
	}
}
