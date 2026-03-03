using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B63")]
public class CodeInputWidget : WidgetBase<CodeInputWidget.Source>, IInputCooltimeWidget, IScrollEntityButtonWidget
{
	[Token(Token = "0x2000B64")]
	public class Source : IWidgetSourceSelectable, IWidgetSource
	{
		[Token(Token = "0x40096D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int inputLength;

		[Token(Token = "0x40096D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string inputGuideText;

		[Token(Token = "0x40096D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string confirmTitle;

		[Token(Token = "0x40096D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string confirmMessage;

		[Token(Token = "0x40096D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string completeDescText;

		[Token(Token = "0x40096D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PromoCodeFormat codeFormat;

		[Token(Token = "0x40096D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isCompleted;

		[Token(Token = "0x40096D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<string> onCodeDecided;

		[Token(Token = "0x1700095A")]
		public bool isSelectable
		{
			[Token(Token = "0x60045E8")]
			[Address(RVA = "0x8F3920", Offset = "0x8F2B20", VA = "0x1808F3920", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x8F3800", Offset = "0x8F2A00", VA = "0x1808F3800")]
		public Source(int inputLength, string inputGuideText, string confirmTitle, string confirmMessage, PromoCodeFormat codeFormat, Action<string> onCodeDecided, bool isCompleted, [Optional] string completeDescText)
		{
		}
	}

	[Token(Token = "0x2000B66")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40096DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CodeInputWidget _003C_003E4__this;

		[Token(Token = "0x1700095B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60045EF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700095C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60045F1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x8F5D70", Offset = "0x8F4F70", VA = "0x1808F5D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60045F0")]
		[Address(RVA = "0x8F5E00", Offset = "0x8F5000", VA = "0x1808F5E00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40096CD")]
	private const string k_ELabel_InputField = "InputField";

	[Token(Token = "0x40096CE")]
	private const string k_ELabel_InputFormRoot = "InputFormRoot";

	[Token(Token = "0x40096CF")]
	private const string k_ELabel_CompleteLabelRoot = "CompleteLabelRoot";

	[Token(Token = "0x40096D0")]
	private const string k_ELabel_CompleteDescText = "CompleteDescText";

	[Token(Token = "0x40096D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputFieldWidget m_InputFieldWidget;

	[Token(Token = "0x17000959")]
	public InputFieldWidget inputFieldWidget
	{
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60045DF")]
	[Address(RVA = "0x8E5660", Offset = "0x8E4860", VA = "0x1808E5660", Slot = "16")]
	public void GetCooltimeWidgets(List<InputFieldWidget> res)
	{
	}

	[Token(Token = "0x60045E0")]
	[Address(RVA = "0x8E5DF0", Offset = "0x8E4FF0", VA = "0x1808E5DF0")]
	public CodeInputWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60045E1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x60045E2")]
	[Address(RVA = "0x8E5730", Offset = "0x8E4930", VA = "0x1808E5730", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__11))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}

	[Token(Token = "0x60045E3")]
	[Address(RVA = "0x8E5B10", Offset = "0x8E4D10", VA = "0x1808E5B10")]
	public void RefreshViewAsInput()
	{
	}

	[Token(Token = "0x60045E4")]
	[Address(RVA = "0x8E59F0", Offset = "0x8E4BF0", VA = "0x1808E59F0")]
	public void RefreshViewAsComplete()
	{
	}

	[Token(Token = "0x60045E5")]
	[Address(RVA = "0x8E5710", Offset = "0x8E4910", VA = "0x1808E5710")]
	private InputField.ContentType GetPromoCodeFormatContentType(PromoCodeFormat format)
	{
		return default(InputField.ContentType);
	}

	[Token(Token = "0x60045E6")]
	[Address(RVA = "0x8E55A0", Offset = "0x8E47A0", VA = "0x1808E55A0", Slot = "17")]
	public IReadOnlyList<(SelectionItem, int, int)> CollectionSelectionItems()
	{
		return null;
	}

	[Token(Token = "0x60045E7")]
	[Address(RVA = "0x8E57A0", Offset = "0x8E49A0", VA = "0x1808E57A0")]
	private void OnSubmitInput(string input)
	{
	}
}
