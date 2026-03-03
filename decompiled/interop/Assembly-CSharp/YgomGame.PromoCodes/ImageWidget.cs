using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B72")]
public class ImageWidget : WidgetBase<TextWidget.Source>
{
	[Token(Token = "0x2000B73")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Source()
		{
		}
	}

	[Token(Token = "0x2000B74")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096F8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096F9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000963")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600461E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000964")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004620")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600461B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600461C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600461D")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600461F")]
		[Address(RVA = "0x8F7160", Offset = "0x8F6360", VA = "0x1808F7160", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6004617")]
	[Address(RVA = "0x8E6210", Offset = "0x8E5410", VA = "0x1808E6210")]
	public ImageWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004618")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x6004619")]
	[Address(RVA = "0x8E61C0", Offset = "0x8E53C0", VA = "0x1808E61C0", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__2))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
