using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x200077E")]
public class WCSBattleInfoBaseViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200077F")]
	public enum ViewType
	{
		[Token(Token = "0x400259D")]
		LEAGUE,
		[Token(Token = "0x400259E")]
		FINAL
	}

	[Token(Token = "0x2000780")]
	public class InfoArg
	{
		[Token(Token = "0x17000612")]
		public Def.LeagueLayoutType layout
		{
			[Token(Token = "0x600312C")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(Def.LeagueLayoutType);
			}
			[Token(Token = "0x600312B")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000613")]
		public string cwJsonPathPrefix
		{
			[Token(Token = "0x600312E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600312D")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000614")]
		public Func<Def.CampaignStatus> getWCSPeriodFunc
		{
			[Token(Token = "0x600312F")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003130")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000615")]
		public Func<Handle> pollAPIFunc
		{
			[Token(Token = "0x6003131")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003132")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000616")]
		public Func<int> pollUpdateIntervalGetter
		{
			[Token(Token = "0x6003133")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003134")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000617")]
		public bool applyImmediately
		{
			[Token(Token = "0x6003136")]
			[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003135")]
			[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000618")]
		public bool isAdmin
		{
			[Token(Token = "0x6003138")]
			[Address(RVA = "0x689960", Offset = "0x688B60", VA = "0x180689960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003137")]
			[Address(RVA = "0x74E7C0", Offset = "0x74D9C0", VA = "0x18074E7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6003139")]
		[Address(RVA = "0x64B760", Offset = "0x64A960", VA = "0x18064B760")]
		public InfoArg()
		{
		}
	}

	[Token(Token = "0x2000781")]
	public abstract class View
	{
		[Token(Token = "0x40025A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected ViewControllerManager _manager;

		[Token(Token = "0x40025A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ElementObjectManager _eom;

		[Token(Token = "0x17000619")]
		public string cwJsonPath
		{
			[Token(Token = "0x600313B")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600313A")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700061A")]
		public Func<Def.CampaignStatus> getWCSPeriodFunc
		{
			[Token(Token = "0x600313D")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600313C")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700061B")]
		public bool isAdmin
		{
			[Token(Token = "0x600313F")]
			[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600313E")]
			[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003140")]
		[Address(RVA = "0x7614D0", Offset = "0x7606D0", VA = "0x1807614D0")]
		public View(ElementObjectManager eom, ViewControllerManager manager, bool isAdmin)
		{
		}

		[Token(Token = "0x6003141")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		public virtual void Terminate()
		{
		}

		[Token(Token = "0x6003142")]
		[Address(RVA = "0x761450", Offset = "0x760650", VA = "0x180761450")]
		public void ApplyData()
		{
		}

		[Token(Token = "0x6003143")]
		protected abstract void ApplyFromCW(object baseData);
	}

	[Token(Token = "0x2000782")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x40025AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Handle handle;

		[Token(Token = "0x40025AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int errCode;

		[Token(Token = "0x6003144")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6003145")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CPolling_003Eb__0(Handle res)
		{
		}

		[Token(Token = "0x6003146")]
		[Address(RVA = "0x5C7C70", Offset = "0x5C6E70", VA = "0x1805C7C70")]
		internal bool _003CPolling_003Eb__1()
		{
			return default(bool);
		}

		[Token(Token = "0x6003147")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		internal void _003CPolling_003Eb__2(int code)
		{
		}

		[Token(Token = "0x6003148")]
		[Address(RVA = "0x736180", Offset = "0x735380", VA = "0x180736180")]
		internal bool _003CPolling_003Eb__3()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000783")]
	[CompilerGenerated]
	private sealed class _003CPolling_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40025AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40025AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40025AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WCSBattleInfoBaseViewController _003C_003E4__this;

		[Token(Token = "0x40025B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x1700061C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600314C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700061D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600314E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003149")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPolling_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600314A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600314B")]
		[Address(RVA = "0x759240", Offset = "0x758440", VA = "0x180759240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600314D")]
		[Address(RVA = "0x7597D0", Offset = "0x7589D0", VA = "0x1807597D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000784")]
	[CompilerGenerated]
	private sealed class _003CProcessTimeDisp_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40025B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40025B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40025B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WCSBattleInfoBaseViewController _003C_003E4__this;

		[Token(Token = "0x40025B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _003Cdisp_003E5__2;

		[Token(Token = "0x40025B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _003C_prevTime_003E5__3;

		[Token(Token = "0x1700061E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003152")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700061F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003154")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600314F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CProcessTimeDisp_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003150")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003151")]
		[Address(RVA = "0x759AA0", Offset = "0x758CA0", VA = "0x180759AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003153")]
		[Address(RVA = "0x759D70", Offset = "0x758F70", VA = "0x180759D70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400258C")]
	private const string ARG_KEY_PAGETYPE = "pagetype";

	[Token(Token = "0x400258D")]
	internal const string ARG_KEY_INFO_ARG = "InfoArg";

	[Token(Token = "0x400258E")]
	private const string ARG_KEY_USE_DUMMY_INFO_ARG = "ArgKeyUseDummyInfoArg";

	[Token(Token = "0x400258F")]
	internal const string ARG_KEY_HELP_BTN_INVISIBLE = "HelpBtnInvisible";

	[Token(Token = "0x4002590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] VC_PATH;

	[Token(Token = "0x4002591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private ViewType _viewType;

	[Token(Token = "0x4002592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ElementObjectManager _scrollEom;

	[Token(Token = "0x4002593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private View _innerView;

	[Token(Token = "0x4002594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private InfoArg _infoArg;

	[Token(Token = "0x4002595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Func<Handle> _callPollingAPI;

	[Token(Token = "0x4002596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private IEnumerator _pollingRoutine;

	[Token(Token = "0x4002597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Func<int> _pollingPeriodUpdater;

	[Token(Token = "0x4002598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ExtendedTextMeshProUGUI _timeText;

	[Token(Token = "0x4002599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private long _nextRoundTime;

	[Token(Token = "0x400259A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float _pollingWaitRemain;

	[Token(Token = "0x400259B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private float _pollingTimestamp;

	[Token(Token = "0x1700060E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003116")]
		[Address(RVA = "0x7627F0", Offset = "0x7619F0", VA = "0x1807627F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060F")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x6003117")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000610")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6003118")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000611")]
	private bool isErrorDlgShowing
	{
		[Token(Token = "0x6003119")]
		[Address(RVA = "0x7626F0", Offset = "0x7618F0", VA = "0x1807626F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003115")]
	[Address(RVA = "0x761590", Offset = "0x760790", VA = "0x180761590")]
	public static void Go(ViewType type, ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600311A")]
	[Address(RVA = "0x761A90", Offset = "0x760C90", VA = "0x180761A90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600311B")]
	[Address(RVA = "0x7616C0", Offset = "0x7608C0", VA = "0x1807616C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600311C")]
	[Address(RVA = "0x762290", Offset = "0x761490", VA = "0x180762290", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600311D")]
	[Address(RVA = "0x761920", Offset = "0x760B20", VA = "0x180761920", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600311E")]
	[Address(RVA = "0x7619A0", Offset = "0x760BA0", VA = "0x1807619A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600311F")]
	[Address(RVA = "0x761B00", Offset = "0x760D00", VA = "0x180761B00")]
	private void OnVisibleStart()
	{
	}

	[Token(Token = "0x6003120")]
	[Address(RVA = "0x762560", Offset = "0x761760", VA = "0x180762560")]
	private void UpdateNextRoundTime()
	{
	}

	[Token(Token = "0x6003121")]
	[Address(RVA = "0x7621C0", Offset = "0x7613C0", VA = "0x1807621C0")]
	private void StartPolling()
	{
	}

	[Token(Token = "0x6003122")]
	[Address(RVA = "0x761540", Offset = "0x760740", VA = "0x180761540")]
	private void EndPolling()
	{
	}

	[Token(Token = "0x6003123")]
	[Address(RVA = "0x7620E0", Offset = "0x7612E0", VA = "0x1807620E0")]
	[IteratorStateMachine(typeof(_003CPolling_003Ed__37))]
	private IEnumerator Polling()
	{
		return null;
	}

	[Token(Token = "0x6003124")]
	[Address(RVA = "0x762150", Offset = "0x761350", VA = "0x180762150")]
	[IteratorStateMachine(typeof(_003CProcessTimeDisp_003Ed__38))]
	private IEnumerator ProcessTimeDisp()
	{
		return null;
	}

	[Token(Token = "0x6003125")]
	[Address(RVA = "0x7626D0", Offset = "0x7618D0", VA = "0x1807626D0")]
	public WCSBattleInfoBaseViewController()
	{
	}
}
