using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B60")]
public class BannerWidget : WidgetBase<BannerWidget.Source>
{
	[Token(Token = "0x2000B61")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x40096C9")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x60045D7")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public Source(string path)
		{
		}
	}

	[Token(Token = "0x2000B62")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096CA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096CB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40096CC")]
		[FieldOffset(Offset = "0x20")]
		public BannerWidget _003C_003E4__this;

		[Token(Token = "0x17000957")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60045DB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000958")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60045DD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x8F7690", Offset = "0x8F6890", VA = "0x1808F7690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60045DC")]
		[Address(RVA = "0x8F7720", Offset = "0x8F6920", VA = "0x1808F7720", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40096C7")]
	private const string k_ELabel_ImageHolder = "ImageHolder";

	[Token(Token = "0x40096C8")]
	[FieldOffset(Offset = "0x38")]
	private readonly GameObject m_ImageHolder;

	[Token(Token = "0x60045D4")]
	[Address(RVA = "0x8E0EB0", Offset = "0x8E00B0", VA = "0x1808E0EB0")]
	public BannerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60045D5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x60045D6")]
	[Address(RVA = "0x8E0E40", Offset = "0x8E0040", VA = "0x1808E0E40", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__5))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
