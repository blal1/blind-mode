using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B6F")]
public class EmptyWidget : WidgetBase<EmptyWidget.Source>
{
	[Token(Token = "0x2000B70")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x6004610")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Source()
		{
		}
	}

	[Token(Token = "0x2000B71")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096F6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096F7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000961")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004614")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000962")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004616")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004611")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004612")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004613")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004615")]
		[Address(RVA = "0x8F71A0", Offset = "0x8F63A0", VA = "0x1808F71A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x600460D")]
	[Address(RVA = "0x8E60D0", Offset = "0x8E52D0", VA = "0x1808E60D0")]
	public EmptyWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600460E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x600460F")]
	[Address(RVA = "0x8E6080", Offset = "0x8E5280", VA = "0x1808E6080", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__3))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
