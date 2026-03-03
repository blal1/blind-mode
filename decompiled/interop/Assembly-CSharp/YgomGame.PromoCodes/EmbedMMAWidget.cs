using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.MDMarkup;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B6A")]
public class EmbedMMAWidget : WidgetBase<EmbedMMAWidget.Source>
{
	[Token(Token = "0x2000B6B")]
	public class Source : IWidgetSource
	{
		[Token(Token = "0x40096E8")]
		[FieldOffset(Offset = "0x10")]
		public string mmaPath;

		[Token(Token = "0x40096E9")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> args;

		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public Source(string mmaPath, Dictionary<string, object> args)
		{
		}
	}

	[Token(Token = "0x2000B6C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x40096EA")]
		[FieldOffset(Offset = "0x10")]
		public bool mmaFactoriyReady;

		[Token(Token = "0x40096EB")]
		[FieldOffset(Offset = "0x18")]
		public EmbedMMAWidget _003C_003E4__this;

		[Token(Token = "0x40096EC")]
		[FieldOffset(Offset = "0x20")]
		public bool doneMMAPreload;

		[Token(Token = "0x40096ED")]
		[FieldOffset(Offset = "0x21")]
		public bool doneWidgetOutput;

		[Token(Token = "0x6004600")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6004601")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003COnProgressInitialize_003Eb__0()
		{
		}

		[Token(Token = "0x6004602")]
		[Address(RVA = "0x8FACD0", Offset = "0x8F9ED0", VA = "0x1808FACD0")]
		internal void _003COnProgressInitialize_003Eb__1(string path)
		{
		}

		[Token(Token = "0x6004603")]
		[Address(RVA = "0x69EDD0", Offset = "0x69DFD0", VA = "0x18069EDD0")]
		internal void _003COnProgressInitialize_003Eb__2()
		{
		}

		[Token(Token = "0x6004604")]
		[Address(RVA = "0x69EDE0", Offset = "0x69DFE0", VA = "0x18069EDE0")]
		internal void _003COnProgressInitialize_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000B6D")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_1
	{
		[Token(Token = "0x40096EE")]
		[FieldOffset(Offset = "0x10")]
		public bool doneLoadEmbedMMA;

		[Token(Token = "0x6004605")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass7_1()
		{
		}

		[Token(Token = "0x6004606")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003COnProgressInitialize_003Eb__4()
		{
		}
	}

	[Token(Token = "0x2000B6E")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096EF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096F0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40096F1")]
		[FieldOffset(Offset = "0x20")]
		public EmbedMMAWidget _003C_003E4__this;

		[Token(Token = "0x40096F2")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		[Token(Token = "0x40096F3")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass7_1 _003C_003E8__2;

		[Token(Token = "0x40096F4")]
		[FieldOffset(Offset = "0x38")]
		private MDMarkupBoardContainerWidget _003CcontainerWidget_003E5__2;

		[Token(Token = "0x40096F5")]
		[FieldOffset(Offset = "0x40")]
		private MDMarkupEmbedContainer _003CembedContainer_003E5__3;

		[Token(Token = "0x1700095F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600460A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000960")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600460C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004607")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004608")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004609")]
		[Address(RVA = "0x8F7760", Offset = "0x8F6960", VA = "0x1808F7760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600460B")]
		[Address(RVA = "0x8F8210", Offset = "0x8F7410", VA = "0x1808F8210", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40096E4")]
	private const string k_OLabel_ScrollBarDefault = "Default";

	[Token(Token = "0x40096E5")]
	private const string k_OLabel_ScrollBarOnFooter = "OnFooter";

	[Token(Token = "0x40096E6")]
	[FieldOffset(Offset = "0x38")]
	private MDMarkupGraphFactory m_MMAFactory;

	[Token(Token = "0x40096E7")]
	[FieldOffset(Offset = "0x40")]
	private MDMarkupAsset m_MMA;

	[Token(Token = "0x60045FC")]
	[Address(RVA = "0x8E6030", Offset = "0x8E5230", VA = "0x1808E6030")]
	public EmbedMMAWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60045FD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x60045FE")]
	[Address(RVA = "0x8E5FC0", Offset = "0x8E51C0", VA = "0x1808E5FC0", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__7))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}
}
