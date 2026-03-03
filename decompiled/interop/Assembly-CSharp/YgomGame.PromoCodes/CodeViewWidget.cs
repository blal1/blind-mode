using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B67")]
public class CodeViewWidget : WidgetBase<CodeViewWidget.Source>
{
	[Token(Token = "0x2000B68")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x40096E0")]
		[FieldOffset(Offset = "0x10")]
		public string code;

		[Token(Token = "0x60045F5")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public Source(string code)
		{
		}
	}

	[Token(Token = "0x2000B69")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096E1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096E2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40096E3")]
		[FieldOffset(Offset = "0x20")]
		public CodeViewWidget _003C_003E4__this;

		[Token(Token = "0x1700095D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60045F9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700095E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60045FB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x8F74E0", Offset = "0x8F66E0", VA = "0x1808F74E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x8F75D0", Offset = "0x8F67D0", VA = "0x1808F75D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40096DF")]
	private const string k_ELabel_CodeValue = "CodeValue";

	[Token(Token = "0x60045F2")]
	[Address(RVA = "0x8E5F70", Offset = "0x8E5170", VA = "0x1808E5F70")]
	public CodeViewWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60045F3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x60045F4")]
	[Address(RVA = "0x8E5F00", Offset = "0x8E5100", VA = "0x1808E5F00", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__4))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
