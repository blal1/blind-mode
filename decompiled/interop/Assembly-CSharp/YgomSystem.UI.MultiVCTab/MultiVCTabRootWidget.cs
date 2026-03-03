using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005EC")]
public class MultiVCTabRootWidget : ElementWidgetBase
{
	[Token(Token = "0x20005ED")]
	public class Context
	{
		[Token(Token = "0x4001C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MultiVCTabSettings MultiVCTabSettings;

		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public Context(MultiVCTabSettings MultiVCTabSettings)
		{
		}
	}

	[Token(Token = "0x4001C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly ProductShowcaseWidget productShowcase;

	[Token(Token = "0x4001C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, bool> m_AutoAcordionShrinkMap;

	[Token(Token = "0x4001C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Context m_Context;

	[Token(Token = "0x170004A6")]
	public Context context
	{
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A7")]
	public int currentSubTabIdx
	{
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x697EC0", Offset = "0x6970C0", VA = "0x180697EC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004A8")]
	public int currentSubTabSectionIdx
	{
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x697FD0", Offset = "0x6971D0", VA = "0x180697FD0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004A9")]
	public int currentHorizonTabIdx
	{
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x697B30", Offset = "0x696D30", VA = "0x180697B30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004AA")]
	public ProductShowcaseWidget currentShowcase
	{
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AB")]
	public ProductShowcaseWidget.Context currentShowcaseCtx
	{
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x697EA0", Offset = "0x6970A0", VA = "0x180697EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AC")]
	public AccordionTabGroupWidget currentSubTabList
	{
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x697FB0", Offset = "0x6971B0", VA = "0x180697FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AD")]
	public MultiVCTabHorizonWidget currentHorizonTabWidget
	{
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x697CF0", Offset = "0x696EF0", VA = "0x180697CF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AE")]
	public List<MultiVCTabListWidget.TabContext> currentSubTabListCtxs
	{
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x697F80", Offset = "0x697180", VA = "0x180697F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004AF")]
	public MultiVCTabListWidget.TabContext currentSubTabListCtx
	{
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x697EF0", Offset = "0x6970F0", VA = "0x180697EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004B0")]
	public int currentSubTabSectionLength
	{
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x698000", Offset = "0x697200", VA = "0x180698000")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0x697AA0", Offset = "0x696CA0", VA = "0x180697AA0")]
	public MultiVCTabRootWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
	public void InitContext(Context context)
	{
	}

	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x696BD0", Offset = "0x695DD0", VA = "0x180696BD0")]
	public void InitData()
	{
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x696BE0", Offset = "0x695DE0", VA = "0x180696BE0")]
	private void InitProductGruopData()
	{
	}

	[Token(Token = "0x60026E9")]
	private void OrderDescendingChild<T>(ref List<T> list) where T : MultiVCTabListWidget.TabContext
	{
	}

	[Token(Token = "0x60026EA")]
	private void OrderDescendungHorizon<T>(ref List<T> list) where T : MultiVCTabHorizonWidget.TabContext
	{
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x697620", Offset = "0x696820", VA = "0x180697620")]
	public void InitSubCategoryTab()
	{
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x697530", Offset = "0x696730", VA = "0x180697530")]
	public void InitProduct(Action onComplete)
	{
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x697950", Offset = "0x696B50", VA = "0x180697950")]
	public void UpdateShowcase(bool resetPos = true, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x697810", Offset = "0x696A10", VA = "0x180697810")]
	public void UpdateBadge(bool isSection = false, bool isHorizonTab = false)
	{
	}

	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x697A50", Offset = "0x696C50", VA = "0x180697A50")]
	public void UpdateSubTabList()
	{
	}

	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x697650", Offset = "0x696850", VA = "0x180697650")]
	public bool IsAutoAcordionShrink(int categoryId)
	{
		return default(bool);
	}

	[Token(Token = "0x60026F1")]
	[Address(RVA = "0x6976E0", Offset = "0x6968E0", VA = "0x1806976E0")]
	public void SetAutoAcordionShrink(int categoryId, bool value)
	{
	}
}
