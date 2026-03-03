using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B80")]
public class TextsWidget : WidgetBase<TextsWidget.Source>
{
	[Token(Token = "0x2000B81")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x4009729")]
		[FieldOffset(Offset = "0x10")]
		public string[] texts;

		[Token(Token = "0x6004656")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public Source(params string[] texts)
		{
		}
	}

	[Token(Token = "0x2000B82")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400972A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400972B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400972C")]
		[FieldOffset(Offset = "0x20")]
		public TextsWidget _003C_003E4__this;

		[Token(Token = "0x17000970")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600465A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000971")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600465C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004657")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004658")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004659")]
		[Address(RVA = "0x8F72C0", Offset = "0x8F64C0", VA = "0x1808F72C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600465B")]
		[Address(RVA = "0x8F7650", Offset = "0x8F6850", VA = "0x1808F7650", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009728")]
	private const string k_ELabel_TextFormat = "Text{0}";

	[Token(Token = "0x6004653")]
	[Address(RVA = "0x8F3A60", Offset = "0x8F2C60", VA = "0x1808F3A60")]
	public TextsWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004654")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x6004655")]
	[Address(RVA = "0x8F39F0", Offset = "0x8F2BF0", VA = "0x1808F39F0", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__4))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
