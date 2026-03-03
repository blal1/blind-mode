using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem;

namespace YgomGame.GemShop;

[Token(Token = "0x2000DA7")]
public class GemShopPermissionViewController : BaseMenuViewController
{
	[Token(Token = "0x2000DA8")]
	private enum Step
	{
		[Token(Token = "0x4009FC0")]
		Start,
		[Token(Token = "0x4009FC1")]
		ConfirmUpgrade,
		[Token(Token = "0x4009FC2")]
		Challenge,
		[Token(Token = "0x4009FC3")]
		Finish
	}

	[Token(Token = "0x2000DA9")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4009FC4")]
		[FieldOffset(Offset = "0x10")]
		public GemShopPermissionViewController _003C_003E4__this;

		[Token(Token = "0x4009FC5")]
		[FieldOffset(Offset = "0x18")]
		public StepSequencer seq;

		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6005200")]
		[Address(RVA = "0x997230", Offset = "0x996430", VA = "0x180997230")]
		internal void _003CstepStart_003Eb__0()
		{
		}

		[Token(Token = "0x6005201")]
		[Address(RVA = "0x997280", Offset = "0x996480", VA = "0x180997280")]
		internal void _003CstepStart_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000DAA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_1
	{
		[Token(Token = "0x4009FC6")]
		[FieldOffset(Offset = "0x10")]
		public bool waitDailog;

		[Token(Token = "0x6005202")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_1()
		{
		}

		[Token(Token = "0x6005203")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CstepStart_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000DAB")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_2
	{
		[Token(Token = "0x4009FC7")]
		[FieldOffset(Offset = "0x10")]
		public int apiCode;

		[Token(Token = "0x4009FC8")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6005204")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_2()
		{
		}

		[Token(Token = "0x6005205")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStart_003Eb__3(int code)
		{
		}

		[Token(Token = "0x6005206")]
		[Address(RVA = "0x9972E0", Offset = "0x9964E0", VA = "0x1809972E0")]
		internal void _003CstepStart_003Eb__4()
		{
		}
	}

	[Token(Token = "0x2000DAC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_3
	{
		[Token(Token = "0x4009FC9")]
		[FieldOffset(Offset = "0x10")]
		public bool waitDailog;

		[Token(Token = "0x6005207")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass12_3()
		{
		}

		[Token(Token = "0x6005208")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CstepStart_003Eb__5()
		{
		}
	}

	[Token(Token = "0x2000DAE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4009FCD")]
		[FieldOffset(Offset = "0x10")]
		public bool res_approved;

		[Token(Token = "0x4009FCE")]
		[FieldOffset(Offset = "0x11")]
		public bool wait;

		[Token(Token = "0x600520C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600520D")]
		[Address(RVA = "0x997550", Offset = "0x996750", VA = "0x180997550")]
		internal void _003CstepChallenge_003Eb__0(bool _res)
		{
		}
	}

	[Token(Token = "0x2000DAF")]
	[CompilerGenerated]
	private sealed class _003CstepChallenge_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009FCF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009FD0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009FD1")]
		[FieldOffset(Offset = "0x20")]
		public GemShopPermissionViewController _003C_003E4__this;

		[Token(Token = "0x4009FD2")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x4009FD3")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17000BDF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005211")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005213")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600520E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepChallenge_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600520F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005210")]
		[Address(RVA = "0x99A7A0", Offset = "0x9999A0", VA = "0x18099A7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005212")]
		[Address(RVA = "0x99A9C0", Offset = "0x999BC0", VA = "0x18099A9C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000DB0")]
	[CompilerGenerated]
	private sealed class _003CstepStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009FD4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009FD5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009FD6")]
		[FieldOffset(Offset = "0x20")]
		public GemShopPermissionViewController _003C_003E4__this;

		[Token(Token = "0x4009FD7")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x4009FD8")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass12_1 _003C_003E8__1;

		[Token(Token = "0x4009FD9")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass12_0 _003C_003E8__2;

		[Token(Token = "0x4009FDA")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass12_2 _003C_003E8__3;

		[Token(Token = "0x4009FDB")]
		[FieldOffset(Offset = "0x48")]
		private _003C_003Ec__DisplayClass12_3 _003C_003E8__4;

		[Token(Token = "0x4009FDC")]
		[FieldOffset(Offset = "0x50")]
		private bool _003Ccurrent_003E5__2;

		[Token(Token = "0x17000BE1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005217")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005219")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005214")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStart_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005215")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005216")]
		[Address(RVA = "0x99AA00", Offset = "0x999C00", VA = "0x18099AA00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005218")]
		[Address(RVA = "0x99B140", Offset = "0x99A340", VA = "0x18099B140", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009FBB")]
	private const string k_ViewControllerPath = "GemShop/GemShopPermission";

	[Token(Token = "0x4009FBC")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x4009FBD")]
	[FieldOffset(Offset = "0xD8")]
	private GemShopPermissionResult m_result;

	[Token(Token = "0x4009FBE")]
	[FieldOffset(Offset = "0xE0")]
	private Action<GemShopPermissionResult> m_resultCallback;

	[Token(Token = "0x17000BDE")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x989D70", Offset = "0x988F70", VA = "0x180989D70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60051F3")]
	[Address(RVA = "0x989CA0", Offset = "0x988EA0", VA = "0x180989CA0")]
	public static void Open(Action<GemShopPermissionResult> resultCallback)
	{
	}

	[Token(Token = "0x60051F4")]
	[Address(RVA = "0x989C00", Offset = "0x988E00", VA = "0x180989C00")]
	public static void OpenOnHome(Action<GemShopPermissionResult> resultCallback)
	{
	}

	[Token(Token = "0x60051F6")]
	[Address(RVA = "0x989980", Offset = "0x988B80", VA = "0x180989980", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60051F7")]
	[Address(RVA = "0x7551A0", Offset = "0x7543A0", VA = "0x1807551A0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60051F8")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x60051F9")]
	[Address(RVA = "0x98A030", Offset = "0x989230", VA = "0x18098A030")]
	[IteratorStateMachine(typeof(_003CstepStart_003Ed__12))]
	private IEnumerator stepStart(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x60051FA")]
	[Address(RVA = "0x989ED0", Offset = "0x9890D0", VA = "0x180989ED0")]
	private void stepConfirmUpgrade(StepSequencer seq)
	{
	}

	[Token(Token = "0x60051FB")]
	[Address(RVA = "0x989E40", Offset = "0x989040", VA = "0x180989E40")]
	[IteratorStateMachine(typeof(_003CstepChallenge_003Ed__14))]
	private IEnumerator stepChallenge(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x60051FC")]
	[Address(RVA = "0x989FC0", Offset = "0x9891C0", VA = "0x180989FC0")]
	private void stepFinish(StepSequencer seq)
	{
	}

	[Token(Token = "0x60051FD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x60051FE")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public GemShopPermissionViewController()
	{
	}
}
