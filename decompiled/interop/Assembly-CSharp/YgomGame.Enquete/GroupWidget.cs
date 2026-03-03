using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E13")]
public class GroupWidget : SheetContentWidget, ISheetContentCompleteCheckWidget, ISheetAsyncInitializeContentWidget, ISheetInputDirectionWidget
{
	[Token(Token = "0x2000E14")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x400A20D")]
		[FieldOffset(Offset = "0x10")]
		public int loadingCnt;

		[Token(Token = "0x400A20E")]
		[FieldOffset(Offset = "0x18")]
		public Action _003C_003E9__0;

		[Token(Token = "0x6005548")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6005549")]
		[Address(RVA = "0x9C74A0", Offset = "0x9C66A0", VA = "0x1809C74A0")]
		internal void _003CyInitializeAsync_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000E15")]
	[CompilerGenerated]
	private sealed class _003CyInitializeAsync_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A20F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A210")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A211")]
		[FieldOffset(Offset = "0x20")]
		public GroupWidget _003C_003E4__this;

		[Token(Token = "0x400A212")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		[Token(Token = "0x400A213")]
		[FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x17000CB5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600554D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600554F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600554A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitializeAsync_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600554B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600554C")]
		[Address(RVA = "0x9C7A20", Offset = "0x9C6C20", VA = "0x1809C7A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600554E")]
		[Address(RVA = "0x9C7D10", Offset = "0x9C6F10", VA = "0x1809C7D10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A206")]
	[FieldOffset(Offset = "0x28")]
	private readonly SheetWidgetFactory m_SheetWidgetFactory;

	[Token(Token = "0x400A207")]
	[FieldOffset(Offset = "0x30")]
	public readonly List<ISheetContentWidget> m_ContentWidgets;

	[Token(Token = "0x400A208")]
	[FieldOffset(Offset = "0x38")]
	public readonly List<ISheetContentCompleteCheckWidget> m_ContentCompleteCheckWidgets;

	[Token(Token = "0x400A209")]
	[FieldOffset(Offset = "0x40")]
	public bool isMust;

	[Token(Token = "0x17000CB3")]
	public bool isInputComplete
	{
		[Token(Token = "0x600553A")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600553B")]
		[Address(RVA = "0x416710", Offset = "0x415910", VA = "0x180416710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000CB4")]
	public Func<SelectionItem, PadInputDirection, bool> onInputDirectionFunc
	{
		[Token(Token = "0x600553C")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600553D")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x14000080")]
	public event Action onChangeComplete
	{
		[Token(Token = "0x600553E")]
		[Address(RVA = "0x9BA850", Offset = "0x9B9A50", VA = "0x1809BA850", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600553F")]
		[Address(RVA = "0x9BA8F0", Offset = "0x9B9AF0", VA = "0x1809BA8F0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005540")]
	[Address(RVA = "0x9BA740", Offset = "0x9B9940", VA = "0x1809BA740")]
	public GroupWidget(ElementObjectManager eom, string label, SheetWidgetFactory sheetWidgetFactory)
	{
	}

	[Token(Token = "0x6005541")]
	[Address(RVA = "0x9BA4E0", Offset = "0x9B96E0", VA = "0x1809BA4E0")]
	public void SetContents(List<ISheetContentContext> contents)
	{
	}

	[Token(Token = "0x6005542")]
	[Address(RVA = "0x9BA450", Offset = "0x9B9650", VA = "0x1809BA450", Slot = "20")]
	public void InitializeAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6005543")]
	[Address(RVA = "0x9BA990", Offset = "0x9B9B90", VA = "0x1809BA990")]
	[IteratorStateMachine(typeof(_003CyInitializeAsync_003Ed__18))]
	private IEnumerator yInitializeAsync(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6005544")]
	[Address(RVA = "0x9BA290", Offset = "0x9B9490", VA = "0x1809BA290", Slot = "14")]
	public override void ImportInputValues(Dictionary<string, object> importValues)
	{
	}

	[Token(Token = "0x6005545")]
	[Address(RVA = "0x9BA0E0", Offset = "0x9B92E0", VA = "0x1809BA0E0", Slot = "15")]
	public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
	{
	}

	[Token(Token = "0x6005546")]
	[Address(RVA = "0x9B9F20", Offset = "0x9B9120", VA = "0x1809B9F20", Slot = "16")]
	public override void CollectInputValues(Dictionary<string, object> resultValues)
	{
	}

	[Token(Token = "0x6005547")]
	[Address(RVA = "0x9B9D90", Offset = "0x9B8F90", VA = "0x1809B9D90")]
	private void CheckInputComplete()
	{
	}
}
