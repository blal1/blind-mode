using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.DuelPreview;
using YgomGame.Menu.Common;

namespace YgomGame.Shop.ProductViewer;

[Token(Token = "0x20009E9")]
public class SummonPlayer : IThumbPlayer
{
	[Token(Token = "0x20009EB")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4008E42")]
		[FieldOffset(Offset = "0x10")]
		public ThumbWidget thumbWidgetSub;

		[Token(Token = "0x4008E43")]
		[FieldOffset(Offset = "0x18")]
		public ThumbWidget thumbWidgetMain;

		[Token(Token = "0x4008E44")]
		[FieldOffset(Offset = "0x20")]
		public bool isPlaying;

		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6003C6C")]
		[Address(RVA = "0x842580", Offset = "0x841780", VA = "0x180842580")]
		internal void _003CyPlay_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20009EC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_1
	{
		[Token(Token = "0x4008E45")]
		[FieldOffset(Offset = "0x10")]
		public bool loading;

		[Token(Token = "0x4008E46")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6003C6D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_1()
		{
		}

		[Token(Token = "0x6003C6E")]
		[Address(RVA = "0x8426C0", Offset = "0x8418C0", VA = "0x1808426C0")]
		internal void _003CyPlay_003Eb__1(string path)
		{
		}
	}

	[Token(Token = "0x20009ED")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008E47")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008E48")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008E49")]
		[FieldOffset(Offset = "0x20")]
		public ThumbWidget thumbWidgetSub;

		[Token(Token = "0x4008E4A")]
		[FieldOffset(Offset = "0x28")]
		public ThumbWidget thumbWidgetMain;

		[Token(Token = "0x4008E4B")]
		[FieldOffset(Offset = "0x30")]
		public SummonPlayer _003C_003E4__this;

		[Token(Token = "0x4008E4C")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass20_1 _003C_003E8__1;

		[Token(Token = "0x4008E4D")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__2;

		[Token(Token = "0x170007FE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C72")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C74")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C6F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C70")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C71")]
		[Address(RVA = "0x8447C0", Offset = "0x8439C0", VA = "0x1808447C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x8454F0", Offset = "0x8446F0", VA = "0x1808454F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008E39")]
	[FieldOffset(Offset = "0x10")]
	private readonly YgomGame.DuelPreview.DuelPreviewPlayer m_PreviewContainer;

	[Token(Token = "0x4008E3A")]
	[FieldOffset(Offset = "0x18")]
	private readonly HighlightContext m_Context;

	[Token(Token = "0x4008E3B")]
	[FieldOffset(Offset = "0x20")]
	public bool enabled;

	[Token(Token = "0x4008E3C")]
	[FieldOffset(Offset = "0x28")]
	public string bgThumbPath;

	[Token(Token = "0x4008E3D")]
	[FieldOffset(Offset = "0x30")]
	private AsyncProgressLoadingCountContent m_AsyncLoadingCountContent;

	[Token(Token = "0x170007FA")]
	private bool YgomGame_002EShop_002EProductViewer_002EIThumbPlayer_002Eenabled
	{
		[Token(Token = "0x6003C5C")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007FB")]
	public IAsyncProgressContent asyncProgressContent
	{
		[Token(Token = "0x6003C5D")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FC")]
	public HighlightContext context
	{
		[Token(Token = "0x6003C5E")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FD")]
	public ShopDef.ViewerType viewerType
	{
		[Token(Token = "0x6003C5F")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "9")]
		get
		{
			return default(ShopDef.ViewerType);
		}
	}

	[Token(Token = "0x14000048")]
	public event Action<bool> onRequestedFadeInInfo
	{
		[Token(Token = "0x6003C60")]
		[Address(RVA = "0x83E3F0", Offset = "0x83D5F0", VA = "0x18083E3F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C61")]
		[Address(RVA = "0x83E550", Offset = "0x83D750", VA = "0x18083E550", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000049")]
	public event Action<bool> onRequestedFadeOutInfo
	{
		[Token(Token = "0x6003C62")]
		[Address(RVA = "0x83E4A0", Offset = "0x83D6A0", VA = "0x18083E4A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C63")]
		[Address(RVA = "0x83E600", Offset = "0x83D800", VA = "0x18083E600", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003C64")]
	[Address(RVA = "0x83E340", Offset = "0x83D540", VA = "0x18083E340")]
	public SummonPlayer(YgomGame.DuelPreview.DuelPreviewPlayer previewContainer, HighlightContext context)
	{
	}

	[Token(Token = "0x6003C65")]
	[Address(RVA = "0x83E6B0", Offset = "0x83D8B0", VA = "0x18083E6B0", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__20))]
	public IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
	{
		return null;
	}

	[Token(Token = "0x6003C66")]
	[Address(RVA = "0x83E160", Offset = "0x83D360", VA = "0x18083E160", Slot = "8")]
	public void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
	{
	}
}
