using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CD7")]
public class MDMarkupBoardPagerContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
{
	[Token(Token = "0x2000CD8")]
	public class Context
	{
		[Token(Token = "0x4009C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool badge;

		[Token(Token = "0x4009C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string dateStr;

		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x937070", Offset = "0x936270", VA = "0x180937070")]
		public Context()
		{
		}
	}

	[Token(Token = "0x2000CDA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x4009C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool doneOutput;

		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyCreateMMA_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000CDB")]
	[CompilerGenerated]
	private sealed class _003CyCreateMMA_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MDMarkupBoardPagerContainerWidget _003C_003E4__this;

		[Token(Token = "0x4009C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int idx;

		[Token(Token = "0x4009C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

		[Token(Token = "0x4009C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ElementObjectManager _003CmmaEom_003E5__2;

		[Token(Token = "0x4009C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MDMarkupBoardContainerWidget _003CmmaWidget_003E5__3;

		[Token(Token = "0x17000B02")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004DB9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B03")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004DBB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCreateMMA_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004DB8")]
		[Address(RVA = "0x9615D0", Offset = "0x9607D0", VA = "0x1809615D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DBA")]
		[Address(RVA = "0x961ED0", Offset = "0x9610D0", VA = "0x180961ED0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CDC")]
	[CompilerGenerated]
	private sealed class _003CyOutputGraph_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MDMarkupBoardPagerContainerWidget _003C_003E4__this;

		[Token(Token = "0x4009C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int idx;

		[Token(Token = "0x4009C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4009C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003CprevIdx_003E5__2;

		[Token(Token = "0x4009C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IEnumerator _003CplayOutRoutine_003E5__3;

		[Token(Token = "0x4009C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _003CfirstVisit_003E5__4;

		[Token(Token = "0x4009C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MDMarkupBoardContainerWidget _003CdstPage_003E5__5;

		[Token(Token = "0x4009C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IEnumerator _003CplayInRoutine_003E5__6;

		[Token(Token = "0x4009C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IEnumerator _003CcreateMMARoutine_003E5__7;

		[Token(Token = "0x17000B04")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004DBF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B05")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004DC1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004DBC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOutputGraph_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004DBD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004DBE")]
		[Address(RVA = "0x9625C0", Offset = "0x9617C0", VA = "0x1809625C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DC0")]
		[Address(RVA = "0x962EF0", Offset = "0x9620F0", VA = "0x180962EF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CDD")]
	[CompilerGenerated]
	private sealed class _003CyPlayIn_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MDMarkupBoardPagerContainerWidget _003C_003E4__this;

		[Token(Token = "0x4009C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int dstIdx;

		[Token(Token = "0x4009C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int prevIdx;

		[Token(Token = "0x4009C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _003CtweenTarget_003E5__2;

		[Token(Token = "0x4009C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003CinKey_003E5__3;

		[Token(Token = "0x17000B06")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004DC5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B07")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004DC7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004DC2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayIn_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004DC4")]
		[Address(RVA = "0x964A00", Offset = "0x963C00", VA = "0x180964A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x964B70", Offset = "0x963D70", VA = "0x180964B70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CDE")]
	[CompilerGenerated]
	private sealed class _003CyPlayOut_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MDMarkupBoardPagerContainerWidget _003C_003E4__this;

		[Token(Token = "0x4009C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int prevIdx;

		[Token(Token = "0x4009C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _003CtweenTarget_003E5__2;

		[Token(Token = "0x4009C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003CoutKey_003E5__3;

		[Token(Token = "0x17000B08")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004DCB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B09")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004DCD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayOut_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x964BB0", Offset = "0x963DB0", VA = "0x180964BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x964D20", Offset = "0x963F20", VA = "0x180964D20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009C4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string k_ELabel_MMATemplate;

	[Token(Token = "0x4009C4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string k_ELabel_PagerGroup;

	[Token(Token = "0x4009C50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_ELabel_NextButton;

	[Token(Token = "0x4009C51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string k_ELabel_PrevButton;

	[Token(Token = "0x4009C52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly string k_TLabelPagingNextOut;

	[Token(Token = "0x4009C53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string k_TLabelPagingBackOut;

	[Token(Token = "0x4009C54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string k_TLabelPagingNextIn;

	[Token(Token = "0x4009C55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly string k_TLabelPagingBackIn;

	[Token(Token = "0x4009C56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_CacheLimit;

	[Token(Token = "0x4009C57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_MMATemplate;

	[Token(Token = "0x4009C58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MDMarkupContentCustomBoardPageHandler m_Handler;

	[Token(Token = "0x4009C59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Context m_Context;

	[Token(Token = "0x4009C5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private MDMarkupGraphFactory m_GraphFactory;

	[Token(Token = "0x4009C5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private MDMarkupBoardContainer[] m_BoardContainers;

	[Token(Token = "0x4009C5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int m_Idx;

	[Token(Token = "0x4009C5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Queue<(int idx, MDMarkupBoardContainerWidget widget)> m_MMACaches;

	[Token(Token = "0x17000B00")]
	private SelectionButton prevButton
	{
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x952B40", Offset = "0x951D40", VA = "0x180952B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B01")]
	private SelectionButton nextButton
	{
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x952AF0", Offset = "0x951CF0", VA = "0x180952AF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004D9F")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "13")]
	public GameObject FindById(string id)
	{
		return null;
	}

	[Token(Token = "0x6004DA0")]
	[Address(RVA = "0x951EB0", Offset = "0x9510B0", VA = "0x180951EB0")]
	private string GetTLabelPagingOut(int direction)
	{
		return null;
	}

	[Token(Token = "0x6004DA1")]
	[Address(RVA = "0x951EA0", Offset = "0x9510A0", VA = "0x180951EA0")]
	private string GetTLabelPagingIn(int direction)
	{
		return null;
	}

	[Token(Token = "0x6004DA2")]
	[Address(RVA = "0x952860", Offset = "0x951A60", VA = "0x180952860")]
	private bool ValidIdx(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DA3")]
	[Address(RVA = "0x951E80", Offset = "0x951080", VA = "0x180951E80")]
	private bool ContainCache(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DA4")]
	[Address(RVA = "0x952710", Offset = "0x951910", VA = "0x180952710")]
	private MDMarkupBoardContainerWidget TryGetCache(int idx)
	{
		return null;
	}

	[Token(Token = "0x6004DA5")]
	[Address(RVA = "0x952890", Offset = "0x951A90", VA = "0x180952890")]
	public MDMarkupBoardPagerContainerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004DA6")]
	[Address(RVA = "0x951EC0", Offset = "0x9510C0", VA = "0x180951EC0", Slot = "10")]
	public void Initialize(IMDMarkupContainer containerData)
	{
	}

	[Token(Token = "0x6004DA7")]
	[Address(RVA = "0x952450", Offset = "0x951650", VA = "0x180952450", Slot = "11")]
	public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
	{
	}

	[Token(Token = "0x6004DA8")]
	[Address(RVA = "0x952140", Offset = "0x951340", VA = "0x180952140", Slot = "12")]
	public void OnStart(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004DA9")]
	[Address(RVA = "0x952300", Offset = "0x951500", VA = "0x180952300")]
	private void OutputGraph(int idx, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6004DAA")]
	[Address(RVA = "0x952C10", Offset = "0x951E10", VA = "0x180952C10")]
	[IteratorStateMachine(typeof(_003CyOutputGraph_003Ed__32))]
	private IEnumerator yOutputGraph(int idx, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004DAB")]
	[Address(RVA = "0x952B90", Offset = "0x951D90", VA = "0x180952B90")]
	[IteratorStateMachine(typeof(_003CyCreateMMA_003Ed__33))]
	private IEnumerator yCreateMMA(int idx)
	{
		return null;
	}

	[Token(Token = "0x6004DAC")]
	[Address(RVA = "0x952D40", Offset = "0x951F40", VA = "0x180952D40")]
	[IteratorStateMachine(typeof(_003CyPlayOut_003Ed__34))]
	private IEnumerator yPlayOut(int prevIdx, int dstIdx)
	{
		return null;
	}

	[Token(Token = "0x6004DAD")]
	[Address(RVA = "0x952CB0", Offset = "0x951EB0", VA = "0x180952CB0")]
	[IteratorStateMachine(typeof(_003CyPlayIn_003Ed__35))]
	private IEnumerator yPlayIn(int prevIdx, int dstIdx)
	{
		return null;
	}

	[Token(Token = "0x6004DAE")]
	[Address(RVA = "0x952560", Offset = "0x951760", VA = "0x180952560")]
	private void RefreshButtons()
	{
	}

	[Token(Token = "0x6004DAF")]
	[Address(RVA = "0x952100", Offset = "0x951300", VA = "0x180952100")]
	private void OnClickNext()
	{
	}

	[Token(Token = "0x6004DB0")]
	[Address(RVA = "0x952120", Offset = "0x951320", VA = "0x180952120")]
	private void OnClickPrev()
	{
	}
}
