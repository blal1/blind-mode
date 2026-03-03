using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CBD")]
public class MDMarkupAssetBehaviourControllerBase : IMDMarkupAssetBehaviourController
{
	[Token(Token = "0x2000CBE")]
	[CompilerGenerated]
	private sealed class _003COnPostprocessMMA_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009BE9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009BEA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000AEF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004D32")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004D34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnPostprocessMMA_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x95F8C0", Offset = "0x95EAC0", VA = "0x18095F8C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CBF")]
	[CompilerGenerated]
	private sealed class _003COnPreprocessMMA_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009BEB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009BEC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000AF1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004D38")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004D3A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnPreprocessMMA_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x95F900", Offset = "0x95EB00", VA = "0x18095F900", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CC0")]
	[CompilerGenerated]
	private sealed class _003CPostprocessMMA_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009BED")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009BEE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009BEF")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupAssetBehaviourControllerBase _003C_003E4__this;

		[Token(Token = "0x4009BF0")]
		[FieldOffset(Offset = "0x28")]
		public IMDMarkupContainerWidget containerWidget;

		[Token(Token = "0x4009BF1")]
		[FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4009BF2")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator _003Croutine_003E5__2;

		[Token(Token = "0x17000AF3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004D3E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004D40")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D3B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPostprocessMMA_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004D3C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004D3D")]
		[Address(RVA = "0x95F940", Offset = "0x95EB40", VA = "0x18095F940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D3F")]
		[Address(RVA = "0x95FA30", Offset = "0x95EC30", VA = "0x18095FA30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000CC1")]
	[CompilerGenerated]
	private sealed class _003CPreprocessMMA_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009BF3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009BF4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009BF5")]
		[FieldOffset(Offset = "0x20")]
		public MDMarkupAssetBehaviourControllerBase _003C_003E4__this;

		[Token(Token = "0x4009BF6")]
		[FieldOffset(Offset = "0x28")]
		public MDMarkupAsset mdMarkupAsset;

		[Token(Token = "0x4009BF7")]
		[FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4009BF8")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator _003Croutine_003E5__2;

		[Token(Token = "0x17000AF5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004D44")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004D46")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D41")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPreprocessMMA_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x95FA70", Offset = "0x95EC70", VA = "0x18095FA70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x95FB60", Offset = "0x95ED60", VA = "0x18095FB60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009BE8")]
	[FieldOffset(Offset = "0x10")]
	private MDMarkupAssetViewController m_Vc;

	[Token(Token = "0x17000AEE")]
	protected MDMarkupAssetViewController vc
	{
		[Token(Token = "0x6004D23")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004D24")]
	[Address(RVA = "0x94DDC0", Offset = "0x94CFC0", VA = "0x18094DDC0", Slot = "4")]
	public void Initialize(MDMarkupAssetViewController vc)
	{
	}

	[Token(Token = "0x6004D25")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	protected virtual void OnInitialize()
	{
	}

	[Token(Token = "0x6004D26")]
	[Address(RVA = "0x94DE00", Offset = "0x94D000", VA = "0x18094DE00", Slot = "5")]
	public void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004D27")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	protected virtual void OnNotificationStackEntry()
	{
	}

	[Token(Token = "0x6004D28")]
	[Address(RVA = "0x94DEC0", Offset = "0x94D0C0", VA = "0x18094DEC0", Slot = "7")]
	[IteratorStateMachine(typeof(_003CPostprocessMMA_003Ed__7))]
	public IEnumerator PostprocessMMA(IMDMarkupContainerWidget containerWidget, Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004D29")]
	[Address(RVA = "0x94DE20", Offset = "0x94D020", VA = "0x18094DE20", Slot = "11")]
	[IteratorStateMachine(typeof(_003COnPostprocessMMA_003Ed__8))]
	protected virtual IEnumerator OnPostprocessMMA(IMDMarkupContainerWidget containerWidget)
	{
		return null;
	}

	[Token(Token = "0x6004D2A")]
	[Address(RVA = "0x94DF70", Offset = "0x94D170", VA = "0x18094DF70", Slot = "6")]
	[IteratorStateMachine(typeof(_003CPreprocessMMA_003Ed__9))]
	public IEnumerator PreprocessMMA(MDMarkupAsset mdMarkupAsset, Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6004D2B")]
	[Address(RVA = "0x94DE70", Offset = "0x94D070", VA = "0x18094DE70", Slot = "12")]
	[IteratorStateMachine(typeof(_003COnPreprocessMMA_003Ed__10))]
	protected virtual IEnumerator OnPreprocessMMA(MDMarkupAsset mdMarkupAsset)
	{
		return null;
	}

	[Token(Token = "0x6004D2C")]
	[Address(RVA = "0x731260", Offset = "0x730460", VA = "0x180731260", Slot = "8")]
	public void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004D2D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected virtual void OnNotificationStackRemove()
	{
	}

	[Token(Token = "0x6004D2E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MDMarkupAssetBehaviourControllerBase()
	{
	}
}
