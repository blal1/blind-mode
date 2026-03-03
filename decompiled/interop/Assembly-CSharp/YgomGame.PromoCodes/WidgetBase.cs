using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B8E")]
public abstract class WidgetBase<Source> : ElementWidgetBase, IWidget where Source : class, IWidgetSource
{
	[Token(Token = "0x2000B8F")]
	[CompilerGenerated]
	private sealed class _003CProgressInitialize_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009735")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009736")]
		[FieldOffset(Offset = "0x0")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009737")]
		[FieldOffset(Offset = "0x0")]
		public WidgetBase<Source> _003C_003E4__this;

		[Token(Token = "0x4009738")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator _003Croutine_003E5__2;

		[Token(Token = "0x1700097B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004680")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004682")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600467D")]
		[DebuggerHidden]
		public _003CProgressInitialize_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600467E")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600467F")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004681")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009732")]
	[FieldOffset(Offset = "0x0")]
	protected Source m_Source;

	[Token(Token = "0x4009733")]
	[FieldOffset(Offset = "0x0")]
	protected PromoCodesViewController.SourceContainer m_SourceContainer;

	[Token(Token = "0x4009734")]
	[FieldOffset(Offset = "0x0")]
	private bool m_IsReady;

	[Token(Token = "0x1700097A")]
	public bool IsReady
	{
		[Token(Token = "0x6004676")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004675")]
	public WidgetBase(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004677")]
	public void BeginInitialize(PromoCodesViewController.SourceContainer sourceContainer)
	{
	}

	[Token(Token = "0x6004678")]
	protected abstract void OnBeginInitialize();

	[Token(Token = "0x6004679")]
	[IteratorStateMachine(typeof(WidgetBase<>._003CProgressInitialize_003Ed__8))]
	public IEnumerator ProgressInitialize()
	{
		return null;
	}

	[Token(Token = "0x600467A")]
	protected abstract IEnumerator OnProgressInitialize();

	[Token(Token = "0x600467B")]
	public void SubmitSource(IWidgetSource widgetSource)
	{
	}

	[Token(Token = "0x600467C")]
	public void Release()
	{
	}
}
