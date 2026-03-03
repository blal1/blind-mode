using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B83")]
public class TextWidget : WidgetBase<TextWidget.Source>
{
	[Token(Token = "0x2000B84")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x400972E")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x6004660")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public Source(string text)
		{
		}
	}

	[Token(Token = "0x2000B85")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400972F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009730")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009731")]
		[FieldOffset(Offset = "0x20")]
		public TextWidget _003C_003E4__this;

		[Token(Token = "0x17000972")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004664")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000973")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004666")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004661")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004662")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004663")]
		[Address(RVA = "0x8F71E0", Offset = "0x8F63E0", VA = "0x1808F71E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004665")]
		[Address(RVA = "0x8F7610", Offset = "0x8F6810", VA = "0x1808F7610", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400972D")]
	private const string k_ELabel_Text = "Text";

	[Token(Token = "0x600465D")]
	[Address(RVA = "0x8F39A0", Offset = "0x8F2BA0", VA = "0x1808F39A0")]
	public TextWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600465E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x600465F")]
	[Address(RVA = "0x8F3930", Offset = "0x8F2B30", VA = "0x1808F3930", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__4))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
