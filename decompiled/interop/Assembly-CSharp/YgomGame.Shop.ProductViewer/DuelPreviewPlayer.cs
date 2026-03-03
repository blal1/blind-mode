using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.DuelPreview;
using YgomGame.Menu.Common;

namespace YgomGame.Shop.ProductViewer;

[Token(Token = "0x20009E3")]
public class DuelPreviewPlayer : IThumbPlayer
{
	[Token(Token = "0x20009E5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4008E2D")]
		[FieldOffset(Offset = "0x10")]
		public ThumbWidget thumbWidgetSub;

		[Token(Token = "0x4008E2E")]
		[FieldOffset(Offset = "0x18")]
		public ThumbWidget thumbWidgetMain;

		[Token(Token = "0x4008E2F")]
		[FieldOffset(Offset = "0x20")]
		public bool isPlaying;

		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x842580", Offset = "0x841780", VA = "0x180842580")]
		internal void _003CyPlay_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20009E6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_1
	{
		[Token(Token = "0x4008E30")]
		[FieldOffset(Offset = "0x10")]
		public bool loading;

		[Token(Token = "0x4008E31")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_1()
		{
		}

		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x8425C0", Offset = "0x8417C0", VA = "0x1808425C0")]
		internal void _003CyPlay_003Eb__1(string path)
		{
		}
	}

	[Token(Token = "0x20009E7")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008E32")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008E33")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008E34")]
		[FieldOffset(Offset = "0x20")]
		public ThumbWidget thumbWidgetSub;

		[Token(Token = "0x4008E35")]
		[FieldOffset(Offset = "0x28")]
		public ThumbWidget thumbWidgetMain;

		[Token(Token = "0x4008E36")]
		[FieldOffset(Offset = "0x30")]
		public DuelPreviewPlayer _003C_003E4__this;

		[Token(Token = "0x4008E37")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass20_1 _003C_003E8__1;

		[Token(Token = "0x4008E38")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__2;

		[Token(Token = "0x170007F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C4F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C51")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x844E20", Offset = "0x844020", VA = "0x180844E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x845530", Offset = "0x844730", VA = "0x180845530", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008E24")]
	[FieldOffset(Offset = "0x10")]
	private readonly YgomGame.DuelPreview.DuelPreviewPlayer m_PreviewContainer;

	[Token(Token = "0x4008E25")]
	[FieldOffset(Offset = "0x18")]
	private readonly HighlightContext m_Context;

	[Token(Token = "0x4008E26")]
	[FieldOffset(Offset = "0x20")]
	public bool enabled;

	[Token(Token = "0x4008E27")]
	[FieldOffset(Offset = "0x28")]
	public string bgThumbPath;

	[Token(Token = "0x4008E28")]
	[FieldOffset(Offset = "0x30")]
	private AsyncProgressLoadingCountContent m_AsyncLoadingCountContent;

	[Token(Token = "0x170007F0")]
	private bool YgomGame_002EShop_002EProductViewer_002EIThumbPlayer_002Eenabled
	{
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007F1")]
	public IAsyncProgressContent asyncProgressContent
	{
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F2")]
	public HighlightContext context
	{
		[Token(Token = "0x6003C3B")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F3")]
	public ShopDef.ViewerType viewerType
	{
		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "9")]
		get
		{
			return default(ShopDef.ViewerType);
		}
	}

	[Token(Token = "0x14000044")]
	public event Action<bool> onRequestedFadeInInfo
	{
		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0x821D70", Offset = "0x820F70", VA = "0x180821D70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000045")]
	public event Action<bool> onRequestedFadeOutInfo
	{
		[Token(Token = "0x6003C3F")]
		[Address(RVA = "0x821E20", Offset = "0x821020", VA = "0x180821E20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003C40")]
		[Address(RVA = "0x821F80", Offset = "0x821180", VA = "0x180821F80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003C41")]
	[Address(RVA = "0x821CC0", Offset = "0x820EC0", VA = "0x180821CC0")]
	public DuelPreviewPlayer(YgomGame.DuelPreview.DuelPreviewPlayer previewContainer, HighlightContext context)
	{
	}

	[Token(Token = "0x6003C42")]
	[Address(RVA = "0x822030", Offset = "0x821230", VA = "0x180822030", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__20))]
	public IEnumerator yPlay(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
	{
		return null;
	}

	[Token(Token = "0x6003C43")]
	[Address(RVA = "0x821AC0", Offset = "0x820CC0", VA = "0x180821AC0", Slot = "8")]
	public void SetImmediate(ThumbWidget thumbWidgetMain, ThumbWidget thumbWidgetSub)
	{
	}
}
