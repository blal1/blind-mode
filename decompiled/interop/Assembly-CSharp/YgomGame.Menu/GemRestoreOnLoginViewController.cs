using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using KonamiCommonIAB;
using YgomGame.GemShop;
using YgomSystem.Billing;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20012AC")]
public class GemRestoreOnLoginViewController : BaseMenuViewController
{
	[Token(Token = "0x20012AD")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x400BCE9")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x400BCEA")]
		[FieldOffset(Offset = "0x14")]
		public int retCode;

		[Token(Token = "0x400BCEB")]
		[FieldOffset(Offset = "0x18")]
		public List<ProductInfo> productData;

		[Token(Token = "0x400BCEC")]
		[FieldOffset(Offset = "0x20")]
		public List<Purchase> compPurchases;

		[Token(Token = "0x400BCED")]
		[FieldOffset(Offset = "0x28")]
		public GemRestoreOnLoginViewController _003C_003E4__this;

		[Token(Token = "0x400BCEE")]
		[FieldOffset(Offset = "0x30")]
		public bool reboot;

		[Token(Token = "0x600742B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600742C")]
		[Address(RVA = "0xBB9830", Offset = "0xBB8A30", VA = "0x180BB9830")]
		internal void _003CProcessGemRestoring_003Eb__0(Handle e)
		{
		}

		[Token(Token = "0x600742D")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		internal void _003CProcessGemRestoring_003Eb__1(int code)
		{
		}

		[Token(Token = "0x600742E")]
		[Address(RVA = "0xBB9890", Offset = "0xBB8A90", VA = "0x180BB9890")]
		internal void _003CProcessGemRestoring_003Eb__2(List<ProductInfo> list)
		{
		}

		[Token(Token = "0x600742F")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CProcessGemRestoring_003Eb__3()
		{
			return default(bool);
		}

		[Token(Token = "0x6007430")]
		[Address(RVA = "0xBB98B0", Offset = "0xBB8AB0", VA = "0x180BB98B0")]
		internal void _003CProcessGemRestoring_003Eb__4(ResultCode result, List<Purchase> compList)
		{
		}

		[Token(Token = "0x6007431")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CProcessGemRestoring_003Eb__5()
		{
			return default(bool);
		}

		[Token(Token = "0x6007432")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CProcessGemRestoring_003Eb__6()
		{
		}

		[Token(Token = "0x6007433")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CProcessGemRestoring_003Eb__7()
		{
			return default(bool);
		}

		[Token(Token = "0x6007434")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CProcessGemRestoring_003Eb__8()
		{
		}

		[Token(Token = "0x6007435")]
		[Address(RVA = "0xBB98D0", Offset = "0xBB8AD0", VA = "0x180BB98D0")]
		internal void _003CProcessGemRestoring_003Eb__9()
		{
		}

		[Token(Token = "0x6007436")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CProcessGemRestoring_003Eb__10()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20012AE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x400BCEF")]
		[FieldOffset(Offset = "0x10")]
		public int retCode;

		[Token(Token = "0x6007437")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6007438")]
		[Address(RVA = "0x5F4420", Offset = "0x5F3620", VA = "0x1805F4420")]
		internal void _003CCallNetworkAPI_003Eb__0(Handle e)
		{
		}
	}

	[Token(Token = "0x20012AF")]
	[CompilerGenerated]
	private sealed class _003CCallNetworkAPI_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BCF0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BCF1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BCF2")]
		[FieldOffset(Offset = "0x20")]
		public Handle handle;

		[Token(Token = "0x400BCF3")]
		[FieldOffset(Offset = "0x28")]
		public Action<int> callback;

		[Token(Token = "0x400BCF4")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x1700124D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600743C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700124E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600743E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007439")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallNetworkAPI_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600743A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600743B")]
		[Address(RVA = "0xBB4530", Offset = "0xBB3730", VA = "0x180BB4530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600743D")]
		[Address(RVA = "0xBB4690", Offset = "0xBB3890", VA = "0x180BB4690", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20012B0")]
	[CompilerGenerated]
	private sealed class _003CProcessGemRestoring_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BCF5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BCF6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BCF7")]
		[FieldOffset(Offset = "0x20")]
		public GemRestoreOnLoginViewController _003C_003E4__this;

		[Token(Token = "0x400BCF8")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x400BCF9")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _003Cproducts_003E5__2;

		[Token(Token = "0x1700124F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007442")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001250")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007444")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600743F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CProcessGemRestoring_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007440")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007441")]
		[Address(RVA = "0xBB4EA0", Offset = "0xBB40A0", VA = "0x180BB4EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007443")]
		[Address(RVA = "0xBB5B00", Offset = "0xBB4D00", VA = "0x180BB5B00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BCE1")]
	private const string VC_PATH = "GemRestoreOnLogin/GemRestoreOnLogin";

	[Token(Token = "0x400BCE2")]
	private const string ARG_KEY_NOREBOOT = "NoRebootMode";

	[Token(Token = "0x400BCE3")]
	private const string ARG_KEY_ONEND = "OnEnd";

	[Token(Token = "0x400BCE4")]
	[FieldOffset(Offset = "0x0")]
	private static IEnumerator s_Routine;

	[Token(Token = "0x400BCE5")]
	[FieldOffset(Offset = "0xD0")]
	private YgomSystem.Network.EventHandler _onNetworkErrorHandler;

	[Token(Token = "0x400BCE6")]
	[FieldOffset(Offset = "0xD8")]
	private bool _isNoRebootMode;

	[Token(Token = "0x400BCE7")]
	[FieldOffset(Offset = "0xE0")]
	private Action _onEnd;

	[Token(Token = "0x400BCE8")]
	[FieldOffset(Offset = "0xE8")]
	private JsonGemShopAnalyzer _pdAnalyzer;

	[Token(Token = "0x6007422")]
	[Address(RVA = "0xB9F7F0", Offset = "0xB9E9F0", VA = "0x180B9F7F0")]
	[Conditional("NOT_USE_THIS_METHOD")]
	public static void GoFromTestScene()
	{
	}

	[Token(Token = "0x6007423")]
	[Address(RVA = "0xB9F910", Offset = "0xB9EB10", VA = "0x180B9F910")]
	public static void Go(ViewControllerManager manager, Action onEnd)
	{
	}

	[Token(Token = "0x6007424")]
	[Address(RVA = "0xB9FA50", Offset = "0xB9EC50", VA = "0x180B9FA50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007425")]
	[Address(RVA = "0xB9FC70", Offset = "0xB9EE70", VA = "0x180B9FC70", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007426")]
	[Address(RVA = "0xB9FD90", Offset = "0xB9EF90", VA = "0x180B9FD90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007427")]
	[Address(RVA = "0xB9FE10", Offset = "0xB9F010", VA = "0x180B9FE10")]
	[IteratorStateMachine(typeof(_003CProcessGemRestoring_003Ed__13))]
	private IEnumerator ProcessGemRestoring()
	{
		return null;
	}

	[Token(Token = "0x6007428")]
	[Address(RVA = "0xB9F760", Offset = "0xB9E960", VA = "0x180B9F760")]
	[IteratorStateMachine(typeof(_003CCallNetworkAPI_003Ed__14))]
	private IEnumerator CallNetworkAPI(Handle handle, Action<int> callback)
	{
		return null;
	}

	[Token(Token = "0x6007429")]
	[Address(RVA = "0xB9F2C0", Offset = "0xB9E4C0", VA = "0x180B9F2C0")]
	private Dictionary<string, string> AnalyzeAndGetProductInfos()
	{
		return null;
	}

	[Token(Token = "0x600742A")]
	[Address(RVA = "0xB9FE80", Offset = "0xB9F080", VA = "0x180B9FE80")]
	public GemRestoreOnLoginViewController()
	{
	}
}
