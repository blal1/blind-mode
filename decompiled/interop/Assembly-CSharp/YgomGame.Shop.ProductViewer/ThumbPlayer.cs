using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Menu.Common;

namespace YgomGame.Shop.ProductViewer;

[Token(Token = "0x20009EE")]
public class ThumbPlayer : IThumbPlayer
{
	[Token(Token = "0x20009EF")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008E56")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008E57")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008E58")]
		[FieldOffset(Offset = "0x20")]
		public ThumbPlayer _003C_003E4__this;

		[Token(Token = "0x4008E59")]
		[FieldOffset(Offset = "0x28")]
		public ThumbWidget thumbWidgetMain;

		[Token(Token = "0x4008E5A")]
		[FieldOffset(Offset = "0x30")]
		public ThumbWidget thumbWidgetSub;

		[Token(Token = "0x4008E5B")]
		[FieldOffset(Offset = "0x38")]
		private bool _003CisReadySub_003E5__2;

		[Token(Token = "0x17000804")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C83")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000805")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x845570", Offset = "0x844770", VA = "0x180845570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x8459F0", Offset = "0x844BF0", VA = "0x1808459F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008E4E")]
	[FieldOffset(Offset = "0x10")]
	private readonly string k_TweenFadeInThumb;

	[Token(Token = "0x4008E4F")]
	[FieldOffset(Offset = "0x18")]
	private readonly string k_TweenRollWaitThumb;

	[Token(Token = "0x4008E50")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_TweenRollSwapThumb;

	[Token(Token = "0x4008E51")]
	[FieldOffset(Offset = "0x28")]
	private readonly HighlightContext m_Context;

	[Token(Token = "0x4008E52")]
	[FieldOffset(Offset = "0x30")]
	public bool enabled;

	[Token(Token = "0x4008E53")]
	[FieldOffset(Offset = "0x38")]
	private AsyncContainContent m_AsyncContainContent;

	[Token(Token = "0x17000800")]
	private bool YgomGame_002EShop_002EProductViewer_002EIThumbPlayer_002Eenabled
	{
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000801")]
	public IAsyncProgressContent asyncProgressContent
	{
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000802")]
	public HighlightContext context
	{
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000803")]
	public ShopDef.ViewerType viewerType
	{
		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "9")]
		get
		{
			return default(ShopDef.ViewerType);
		}
	}

	[Token(Token = "0x1400004A")]
	public event Action<bool> onRequestedFadeInInfo
	{
		[Token(Token = "0x6003C79")]
		[Address(RVA = "0x83E910", Offset = "0x83DB10", VA = "0x18083E910", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C7A")]
		[Address(RVA = "0x83EA70", Offset = "0x83DC70", VA = "0x18083EA70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400004B")]
	public event Action<bool> onRequestedFadeOutInfo
	{
		[Token(Token = "0x6003C7B")]
		[Address(RVA = "0x83E9C0", Offset = "0x83DBC0", VA = "0x18083E9C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C7C")]
		[Address(RVA = "0x83EB20", Offset = "0x83DD20", VA = "0x18083EB20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003C7D")]
	[Address(RVA = "0x83E810", Offset = "0x83DA10", VA = "0x18083E810")]
	public ThumbPlayer(HighlightContext context)
	{
	}

	[Token(Token = "0x6003C7E")]
	[Address(RVA = "0x83EBD0", Offset = "0x83DDD0", VA = "0x18083EBD0", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__21))]
	public IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
	{
		return null;
	}

	[Token(Token = "0x6003C7F")]
	[Address(RVA = "0x83E760", Offset = "0x83D960", VA = "0x18083E760", Slot = "8")]
	public void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
	{
	}
}
