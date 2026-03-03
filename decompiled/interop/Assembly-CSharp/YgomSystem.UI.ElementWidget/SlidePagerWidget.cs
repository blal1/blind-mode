using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200061B")]
[RequireComponent(typeof(ScrollRectPageSnap))]
public class SlidePagerWidget : ElementWidgetBehaviourBase<SlidePagerWidget>
{
	[Token(Token = "0x200061D")]
	[CompilerGenerated]
	private sealed class _003CyMovePage_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SlidePagerWidget _003C_003E4__this;

		[Token(Token = "0x4001D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int dstPage;

		[Token(Token = "0x4001D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4001D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003CselectOnFocus_003E5__2;

		[Token(Token = "0x4001D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _003CpageDiff_003E5__3;

		[Token(Token = "0x4001D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExtendedScrollRect _003CscrollRect_003E5__4;

		[Token(Token = "0x17000505")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002850")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000506")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002852")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600284D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMovePage_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600284E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600284F")]
		[Address(RVA = "0x6B7060", Offset = "0x6B6260", VA = "0x1806B7060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002851")]
		[Address(RVA = "0x6B7640", Offset = "0x6B6840", VA = "0x1806B7640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001D78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelIndicatorTemplate;

	[Token(Token = "0x4001D79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelPrevButton;

	[Token(Token = "0x4001D7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x4001D7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string m_TweenIndicatorOn;

	[Token(Token = "0x4001D7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string m_TweenIndicatorOff;

	[Token(Token = "0x4001D7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ScrollRectPageSnap m_PageSnap;

	[Token(Token = "0x4001D7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x4001D7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x4001D80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<GameObject> m_Indicators;

	[Token(Token = "0x4001D81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Coroutine m_yMovePageRoutine;

	[Token(Token = "0x4001D82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Selector m_Selector;

	[Token(Token = "0x4001D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private InfinityScrollView m_Isv;

	[Token(Token = "0x4001D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<SelectionItem> m_TmpOrderItems;

	[Token(Token = "0x4001D85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int startPage;

	[Token(Token = "0x4001D86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isLoop;

	[Token(Token = "0x17000502")]
	public ScrollRectPageSnap pageSnap
	{
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000503")]
	public SelectionButton prevButton
	{
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000504")]
	public SelectionButton nextButton
	{
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000036")]
	public event Action onPageChanged
	{
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x6AED20", Offset = "0x6ADF20", VA = "0x1806AED20")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x6AEDD0", Offset = "0x6ADFD0", VA = "0x1806AEDD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x6AE170", Offset = "0x6AD370", VA = "0x1806AE170")]
	private bool IsValidIdx(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x600283A")]
	[Address(RVA = "0x6AE130", Offset = "0x6AD330", VA = "0x1806AE130")]
	private bool IsEnablePrev()
	{
		return default(bool);
	}

	[Token(Token = "0x600283B")]
	[Address(RVA = "0x6AE0F0", Offset = "0x6AD2F0", VA = "0x1806AE0F0")]
	private bool IsEnableNext()
	{
		return default(bool);
	}

	[Token(Token = "0x600283C")]
	[Address(RVA = "0x6AE000", Offset = "0x6AD200", VA = "0x1806AE000")]
	public static SlidePagerWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0x6ADE20", Offset = "0x6AD020", VA = "0x1806ADE20", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x600283E")]
	[Address(RVA = "0x6AE900", Offset = "0x6ADB00", VA = "0x1806AE900")]
	private void Start()
	{
	}

	[Token(Token = "0x600283F")]
	[Address(RVA = "0x6AE630", Offset = "0x6AD830", VA = "0x1806AE630")]
	public void SetPageTotal(int pageTotal)
	{
	}

	[Token(Token = "0x6002840")]
	[Address(RVA = "0x6AE440", Offset = "0x6AD640", VA = "0x1806AE440")]
	private void PlayIndicatorTween(bool immediate = false)
	{
	}

	[Token(Token = "0x6002841")]
	[Address(RVA = "0x6AEA70", Offset = "0x6ADC70", VA = "0x1806AEA70")]
	private void UpdateButtons()
	{
	}

	[Token(Token = "0x6002842")]
	[Address(RVA = "0x6AE040", Offset = "0x6AD240", VA = "0x1806AE040")]
	public void InitMovePage(Selector seletor, InfinityScrollView isv)
	{
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0x6AE1A0", Offset = "0x6AD3A0", VA = "0x1806AE1A0")]
	public bool MovePage(int dstPage)
	{
		return default(bool);
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0x6AE370", Offset = "0x6AD570", VA = "0x1806AE370")]
	private void OnClickNext()
	{
	}

	[Token(Token = "0x6002845")]
	[Address(RVA = "0x6AE3A0", Offset = "0x6AD5A0", VA = "0x1806AE3A0")]
	private void OnClickPrev()
	{
	}

	[Token(Token = "0x6002846")]
	[Address(RVA = "0x6AE3D0", Offset = "0x6AD5D0", VA = "0x1806AE3D0")]
	private void OnPageChanged()
	{
	}

	[Token(Token = "0x6002847")]
	[Address(RVA = "0x6AEE80", Offset = "0x6AE080", VA = "0x1806AEE80")]
	[IteratorStateMachine(typeof(_003CyMovePage_003Ed__38))]
	private IEnumerator yMovePage(int dstPage, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6002848")]
	[Address(RVA = "0x6AEBD0", Offset = "0x6ADDD0", VA = "0x1806AEBD0")]
	public SlidePagerWidget()
	{
	}
}
