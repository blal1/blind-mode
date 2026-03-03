using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CEC")]
public class MDMarkupGraphWidget : MonoBehaviour, IMDMarkupFreeScrollHandler
{
	[Token(Token = "0x2000CED")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x4009CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IMDMarkupWidgetFactory widgetFactory;

		[Token(Token = "0x4009CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MDMarkupGraphWidget _003C_003E4__this;

		[Token(Token = "0x4009CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<IMDMarkupWidgetFactory> _003C_003E9__1;

		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CyOutput_003Eb__1(IMDMarkupWidgetFactory targetWidgetFactory)
		{
		}
	}

	[Token(Token = "0x2000CEE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_1
	{
		[Token(Token = "0x4009CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool initFactoryComplete;

		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_1()
		{
		}

		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyOutput_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000CEF")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_2
	{
		[Token(Token = "0x4009CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool waitSubGraphOutput;

		[Token(Token = "0x6004E27")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_2()
		{
		}

		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CyOutput_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000CF3")]
	[CompilerGenerated]
	private sealed class _003CyOutput_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MDMarkupGraphWidget _003C_003E4__this;

		[Token(Token = "0x4009CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass29_1 _003C_003E8__1;

		[Token(Token = "0x4009CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__2;

		[Token(Token = "0x4009CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass29_2 _003C_003E8__3;

		[Token(Token = "0x4009CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onComplete;

		[Token(Token = "0x4009CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IMDMarkupContent _003CmdMarkupContent_003E5__2;

		[Token(Token = "0x4009CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IMDMarkupWidget _003CcreatedWidget_003E5__3;

		[Token(Token = "0x4009CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProGlyphCreater _003CtmpGlyphCreater_003E5__4;

		[Token(Token = "0x4009CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IEnumerator _003CcreateGlyphRoutine_003E5__5;

		[Token(Token = "0x4009CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MDMarkupIndentWidget _003CindentWidget_003E5__6;

		[Token(Token = "0x4009CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IEnumerator _003CyLoadOrGetFactory_003E5__7;

		[Token(Token = "0x4009CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _003Ci_003E5__8;

		[Token(Token = "0x17000B11")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004E32")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B12")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004E34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOutput_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x962F30", Offset = "0x962130", VA = "0x180962F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E33")]
		[Address(RVA = "0x9649C0", Offset = "0x963BC0", VA = "0x1809649C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009CD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MDMarkupGraphFactory m_MarkupGraphFactory;

	[Token(Token = "0x4009CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Stack<MDMarkupIndentWidget> m_IndentStack;

	[Token(Token = "0x4009CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<object> m_CardMrks;

	[Token(Token = "0x4009CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<object> m_CardPremires;

	[Token(Token = "0x4009CD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<int> m_CardOvRarities;

	[Token(Token = "0x4009CD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> m_CardOvLimitStates;

	[Token(Token = "0x4009CD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> m_CardOvPrevLimitStates;

	[Token(Token = "0x4009CD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<bool> m_CardShowNoneLimitStates;

	[Token(Token = "0x4009CDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<bool> m_CardShowPrevLimitStates;

	[Token(Token = "0x4009CDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<string> m_CardAppendBottomTexts;

	[Token(Token = "0x4009CDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<IMDMarkupWidget> m_ContentWidgets;

	[Token(Token = "0x4009CDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Queue<IMDMarkupContent> m_ContentRequestQueue;

	[Token(Token = "0x4009CDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine m_OutputCoroutine;

	[Token(Token = "0x4009CDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int m_SelectionPosY;

	[Token(Token = "0x4009CE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public FreeScrollView freeScrollView;

	[Token(Token = "0x4009CE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int m_RecoverIndent;

	[Token(Token = "0x17000B0F")]
	public List<IMDMarkupWidget> contentWidgets
	{
		[Token(Token = "0x6004E0F")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B10")]
	public bool isReady
	{
		[Token(Token = "0x6004E12")]
		[Address(RVA = "0x9548D0", Offset = "0x953AD0", VA = "0x1809548D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400006F")]
	public event Action<MDMarkupGraphWidget> onOutputCompleteEvent
	{
		[Token(Token = "0x6004E10")]
		[Address(RVA = "0x954810", Offset = "0x953A10", VA = "0x180954810")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004E11")]
		[Address(RVA = "0x9548E0", Offset = "0x953AE0", VA = "0x1809548E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004E13")]
	[Address(RVA = "0x953A30", Offset = "0x952C30", VA = "0x180953A30")]
	public static MDMarkupGraphWidget Create(Transform owner, [Optional] MDMarkupGraphFactory graphFactory)
	{
		return null;
	}

	[Token(Token = "0x6004E14")]
	[Address(RVA = "0x953AB0", Offset = "0x952CB0", VA = "0x180953AB0")]
	public static MDMarkupGraphWidget Create(GameObject owner, [Optional] MDMarkupGraphFactory graphFactory)
	{
		return null;
	}

	[Token(Token = "0x6004E15")]
	[Address(RVA = "0x9545B0", Offset = "0x9537B0", VA = "0x1809545B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6004E16")]
	[Address(RVA = "0x9540F0", Offset = "0x9532F0", VA = "0x1809540F0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004E17")]
	[Address(RVA = "0x953CF0", Offset = "0x952EF0", VA = "0x180953CF0")]
	public void InsertContents(IReadOnlyList<IMDMarkupContent> contentDatas)
	{
	}

	[Token(Token = "0x6004E18")]
	[Address(RVA = "0x953B20", Offset = "0x952D20", VA = "0x180953B20")]
	public void InsertContent(IMDMarkupContent mdMarkupContent)
	{
	}

	[Token(Token = "0x6004E19")]
	[Address(RVA = "0x9541A0", Offset = "0x9533A0", VA = "0x1809541A0")]
	public void Output([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6004E1A")]
	[Address(RVA = "0x9549A0", Offset = "0x953BA0", VA = "0x1809549A0")]
	[IteratorStateMachine(typeof(_003CyOutput_003Ed__29))]
	private IEnumerator yOutput([Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004E1B")]
	[Address(RVA = "0x954290", Offset = "0x953490", VA = "0x180954290")]
	private MDMarkupIndentWidget ProcessIndent(int targetIndent)
	{
		return null;
	}

	[Token(Token = "0x6004E1C")]
	[Address(RVA = "0x953990", Offset = "0x952B90", VA = "0x180953990", Slot = "4")]
	public void AssignSelectionItem(SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x6004E1D")]
	[Address(RVA = "0x954540", Offset = "0x953740", VA = "0x180954540", Slot = "5")]
	public void ProgressSelectionPosY()
	{
	}

	[Token(Token = "0x6004E1E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void SetFreeScrollView(FreeScrollView scroll)
	{
	}

	[Token(Token = "0x6004E1F")]
	[Address(RVA = "0x953EB0", Offset = "0x9530B0", VA = "0x180953EB0")]
	private void OnClickCard(int cardIdx)
	{
	}

	[Token(Token = "0x6004E20")]
	[Address(RVA = "0x954060", Offset = "0x953260", VA = "0x180954060")]
	private void OnClickItem(bool isPeriod, int itemCategory, int itemId)
	{
	}

	[Token(Token = "0x6004E21")]
	[Address(RVA = "0x9540A0", Offset = "0x9532A0", VA = "0x1809540A0")]
	private void OnClickLink(string link)
	{
	}

	[Token(Token = "0x6004E22")]
	[Address(RVA = "0x954700", Offset = "0x953900", VA = "0x180954700")]
	public MDMarkupGraphWidget()
	{
	}
}
