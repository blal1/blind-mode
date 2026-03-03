using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem;
using YgomSystem.Compliance;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Compliance;

[Token(Token = "0x2001145")]
public abstract class ApprovalView
{
	[Token(Token = "0x2001146")]
	private enum Step
	{
		[Token(Token = "0x400B60E")]
		None,
		[Token(Token = "0x400B60F")]
		Stay,
		[Token(Token = "0x400B610")]
		Result,
		[Token(Token = "0x400B611")]
		Finish
	}

	[Token(Token = "0x2001148")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x400B617")]
		[FieldOffset(Offset = "0x10")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x400B618")]
		[FieldOffset(Offset = "0x18")]
		public string mailAddress;

		[Token(Token = "0x400B619")]
		[FieldOffset(Offset = "0x20")]
		public bool send_result;

		[Token(Token = "0x6006C6C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6006C6D")]
		[Address(RVA = "0xB57A50", Offset = "0xB56C50", VA = "0x180B57A50")]
		internal Handle _003CsendMailAddressCoroutine_003Eb__0()
		{
			return null;
		}

		[Token(Token = "0x6006C6E")]
		[Address(RVA = "0xB57A90", Offset = "0xB56C90", VA = "0x180B57A90")]
		internal bool _003CsendMailAddressCoroutine_003Eb__1(int code)
		{
			return default(bool);
		}

		[Token(Token = "0x6006C6F")]
		[Address(RVA = "0x69EDD0", Offset = "0x69DFD0", VA = "0x18069EDD0")]
		internal void _003CsendMailAddressCoroutine_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2001149")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_1
	{
		[Token(Token = "0x400B61A")]
		[FieldOffset(Offset = "0x10")]
		public bool waitDialog;

		[Token(Token = "0x6006C70")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass30_1()
		{
		}

		[Token(Token = "0x6006C71")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CsendMailAddressCoroutine_003Eb__3()
		{
		}
	}

	[Token(Token = "0x200114A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		[Token(Token = "0x400B61B")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6006C72")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass57_0()
		{
		}

		[Token(Token = "0x6006C73")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CshowResultDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200114B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		[Token(Token = "0x400B61C")]
		[FieldOffset(Offset = "0x10")]
		public Func<Handle> createHandle;

		[Token(Token = "0x400B61D")]
		[FieldOffset(Offset = "0x18")]
		public Func<int, bool> hookError;

		[Token(Token = "0x400B61E")]
		[FieldOffset(Offset = "0x20")]
		public bool wait;

		[Token(Token = "0x400B61F")]
		[FieldOffset(Offset = "0x28")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x400B620")]
		[FieldOffset(Offset = "0x30")]
		public Action resultCallback;

		[Token(Token = "0x400B621")]
		[FieldOffset(Offset = "0x38")]
		public Action _003C_003E9__2;

		[Token(Token = "0x6006C74")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass63_0()
		{
		}

		[Token(Token = "0x6006C75")]
		[Address(RVA = "0x4FFB70", Offset = "0x4FED70", VA = "0x1804FFB70")]
		internal Handle _003CrequestWebAPICoroutine_003Eb__0()
		{
			return null;
		}

		[Token(Token = "0x6006C76")]
		[Address(RVA = "0xB57C20", Offset = "0xB56E20", VA = "0x180B57C20")]
		internal void _003CrequestWebAPICoroutine_003Eb__1(int apiCode)
		{
		}

		[Token(Token = "0x6006C77")]
		[Address(RVA = "0xB57D30", Offset = "0xB56F30", VA = "0x180B57D30")]
		internal void _003CrequestWebAPICoroutine_003Eb__2()
		{
		}
	}

	[Token(Token = "0x200114D")]
	[CompilerGenerated]
	private sealed class _003Cpolling_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B626")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B627")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B628")]
		[FieldOffset(Offset = "0x20")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x400B629")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cinterval_003E5__2;

		[Token(Token = "0x1700112D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C7F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700112E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C81")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C7C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003Cpolling_003Ed__62(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C7D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C7E")]
		[Address(RVA = "0xB580C0", Offset = "0xB572C0", VA = "0x180B580C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C80")]
		[Address(RVA = "0xB58350", Offset = "0xB57550", VA = "0x180B58350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200114E")]
	[CompilerGenerated]
	private sealed class _003CrequestWebAPICoroutine_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B62A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B62B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B62C")]
		[FieldOffset(Offset = "0x20")]
		public Func<Handle> createHandle;

		[Token(Token = "0x400B62D")]
		[FieldOffset(Offset = "0x28")]
		public Func<int, bool> hookError;

		[Token(Token = "0x400B62E")]
		[FieldOffset(Offset = "0x30")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x400B62F")]
		[FieldOffset(Offset = "0x38")]
		public Action resultCallback;

		[Token(Token = "0x400B630")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass63_0 _003C_003E8__1;

		[Token(Token = "0x1700112F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C85")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001130")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C87")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C82")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CrequestWebAPICoroutine_003Ed__63(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C83")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C84")]
		[Address(RVA = "0xB58390", Offset = "0xB57590", VA = "0x180B58390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C86")]
		[Address(RVA = "0xB58590", Offset = "0xB57790", VA = "0x180B58590", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200114F")]
	[CompilerGenerated]
	private sealed class _003CsendMailAddressCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B631")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B632")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B633")]
		[FieldOffset(Offset = "0x20")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x400B634")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		[Token(Token = "0x400B635")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass30_1 _003C_003E8__2;

		[Token(Token = "0x17001131")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C8B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001132")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C8D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C88")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CsendMailAddressCoroutine_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C89")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C8A")]
		[Address(RVA = "0xB585D0", Offset = "0xB577D0", VA = "0x180B585D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C8C")]
		[Address(RVA = "0xB58AC0", Offset = "0xB57CC0", VA = "0x180B58AC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001150")]
	[CompilerGenerated]
	private sealed class _003CshowResultDialog_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B636")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B637")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B638")]
		[FieldOffset(Offset = "0x20")]
		public ApprovalStatus status;

		[Token(Token = "0x400B639")]
		[FieldOffset(Offset = "0x28")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x400B63A")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

		[Token(Token = "0x17001133")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C91")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001134")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C93")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C8E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowResultDialog_003Ed__57(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C8F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C90")]
		[Address(RVA = "0xB58B00", Offset = "0xB57D00", VA = "0x180B58B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C92")]
		[Address(RVA = "0xB58D40", Offset = "0xB57F40", VA = "0x180B58D40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001151")]
	[CompilerGenerated]
	private sealed class _003CstepResult_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B63B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B63C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B63D")]
		[FieldOffset(Offset = "0x20")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x17001135")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C97")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001136")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C99")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C94")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepResult_003Ed__59(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C95")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C96")]
		[Address(RVA = "0xB58D80", Offset = "0xB57F80", VA = "0x180B58D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C98")]
		[Address(RVA = "0xB58F20", Offset = "0xB58120", VA = "0x180B58F20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001152")]
	[CompilerGenerated]
	private sealed class _003CstepStay_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B63E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B63F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B640")]
		[FieldOffset(Offset = "0x20")]
		public ApprovalView _003C_003E4__this;

		[Token(Token = "0x17001137")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C9D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001138")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C9F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStay_003Ed__58(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C9B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0xB58F60", Offset = "0xB58160", VA = "0x180B58F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C9E")]
		[Address(RVA = "0xB590C0", Offset = "0xB582C0", VA = "0x180B590C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B5E8")]
	private const string k_ElementRootMailAddress = "RootMailAddress";

	[Token(Token = "0x400B5E9")]
	private const string k_ElementRootQRCode = "RootQRCode";

	[Token(Token = "0x400B5EA")]
	private const string k_ElementRootOTP = "RootOTP";

	[Token(Token = "0x400B5EB")]
	private const string k_ElementSectionTextTitle = "TextTitle";

	[Token(Token = "0x400B5EC")]
	private const string k_ElementSectionTextInfo = "TextInfo";

	[Token(Token = "0x400B5ED")]
	private const string k_ElementMailInputField = "MailAdressInputField";

	[Token(Token = "0x400B5EE")]
	private const string k_ElementMailButtonSubmit = "ButtonSubmit";

	[Token(Token = "0x400B5EF")]
	private const string k_ElementMailTextSubmitButton = "TextSubmitButton";

	[Token(Token = "0x400B5F0")]
	private const string k_ElementQRRawImage = "RawImageQRcode";

	[Token(Token = "0x400B5F1")]
	private const string k_ElementOtpTextOtp = "TextOtp";

	[Token(Token = "0x400B5F2")]
	private const string k_ElementOtpButtonCopy = "ButtonCopy";

	[Token(Token = "0x400B5F3")]
	private const string k_ElementOtpButtonWebSite = "ButtonWebSite";

	[Token(Token = "0x400B5F4")]
	[FieldOffset(Offset = "0x10")]
	private ElementObjectManager m_rootEOM;

	[Token(Token = "0x400B5F5")]
	[FieldOffset(Offset = "0x18")]
	private Selector m_selector;

	[Token(Token = "0x400B5F6")]
	[FieldOffset(Offset = "0x20")]
	private StepSequencer m_seq;

	[Token(Token = "0x400B5F7")]
	[FieldOffset(Offset = "0x28")]
	private IEnumerator m_polling;

	[Token(Token = "0x400B5F8")]
	[FieldOffset(Offset = "0x30")]
	private WebAPIQueue m_apiQueue;

	[Token(Token = "0x400B5F9")]
	[FieldOffset(Offset = "0x38")]
	private string m_activeDialog;

	[Token(Token = "0x400B5FA")]
	[FieldOffset(Offset = "0x40")]
	private ApprovalStatus m_status;

	[Token(Token = "0x400B5FB")]
	[FieldOffset(Offset = "0x48")]
	private Action<ApprovalStatus> m_resultCallback;

	[Token(Token = "0x400B5FC")]
	[FieldOffset(Offset = "0x50")]
	private bool m_mailEditable;

	[Token(Token = "0x400B5FD")]
	[FieldOffset(Offset = "0x58")]
	private Regex m_mailRegex;

	[Token(Token = "0x400B5FE")]
	[FieldOffset(Offset = "0x60")]
	private InputFieldWidget m_mailInputField;

	[Token(Token = "0x400B5FF")]
	[FieldOffset(Offset = "0x68")]
	private SelectionButton m_mailSubmitButton;

	[Token(Token = "0x400B600")]
	[FieldOffset(Offset = "0x70")]
	private IEnumerator m_mailSendCoroutine;

	[Token(Token = "0x400B601")]
	[FieldOffset(Offset = "0x78")]
	private RawImage m_qrImage;

	[Token(Token = "0x400B602")]
	[FieldOffset(Offset = "0x80")]
	private ExtendedTextMeshProUGUI m_qrRemainTimeText;

	[Token(Token = "0x400B603")]
	[FieldOffset(Offset = "0x88")]
	private bool m_showOtpArea;

	[Token(Token = "0x400B604")]
	[FieldOffset(Offset = "0x90")]
	private ExtendedTextMeshProUGUI m_otpAreaText;

	[Token(Token = "0x400B605")]
	[FieldOffset(Offset = "0x98")]
	private ExtendedTextMeshProUGUI m_otpAreaRemainTimeText;

	[Token(Token = "0x400B606")]
	[FieldOffset(Offset = "0xA0")]
	private SelectionButton m_otpAreaCopyButton;

	[Token(Token = "0x400B607")]
	[FieldOffset(Offset = "0xA8")]
	private SelectionButton m_otpWebSiteButton;

	[Token(Token = "0x400B608")]
	[FieldOffset(Offset = "0xB0")]
	private long m_otpExpireTime;

	[Token(Token = "0x400B609")]
	[FieldOffset(Offset = "0xB8")]
	private long m_otpRemainTime;

	[Token(Token = "0x400B60A")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_otpGenerating;

	[Token(Token = "0x400B60B")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_otpRequireGenerate;

	[Token(Token = "0x400B60C")]
	[FieldOffset(Offset = "0xC8")]
	private string m_passedDialogMessage;

	[Token(Token = "0x6006C42")]
	[Address(RVA = "0xB43DD0", Offset = "0xB42FD0", VA = "0x180B43DD0")]
	private bool isOpenedAnyDialog()
	{
		return default(bool);
	}

	[Token(Token = "0x6006C43")]
	protected abstract Handle CallSendMailAPI(string mailAddress);

	[Token(Token = "0x6006C44")]
	[Address(RVA = "0xB43E40", Offset = "0xB43040", VA = "0x180B43E40")]
	private bool isValidMailAddress(string mailAddress)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C45")]
	[Address(RVA = "0xB43730", Offset = "0xB42930", VA = "0x180B43730")]
	private void startSendMailAddressCoroutine()
	{
	}

	[Token(Token = "0x6006C46")]
	[Address(RVA = "0xB44100", Offset = "0xB43300", VA = "0x180B44100")]
	[IteratorStateMachine(typeof(_003CsendMailAddressCoroutine_003Ed__30))]
	private IEnumerator sendMailAddressCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6006C47")]
	[Address(RVA = "0xB43D50", Offset = "0xB42F50", VA = "0x180B43D50")]
	private void getOtpExpireTime()
	{
	}

	[Token(Token = "0x6006C48")]
	[Address(RVA = "0xB44EE0", Offset = "0xB440E0", VA = "0x180B44EE0")]
	private bool updateOtpRemainTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6006C49")]
	[Address(RVA = "0xB438B0", Offset = "0xB42AB0", VA = "0x180B438B0")]
	private void drawOtpRemainTime(long remain)
	{
	}

	[Token(Token = "0x6006C4A")]
	[Address(RVA = "0xB43A00", Offset = "0xB42C00", VA = "0x180B43A00")]
	private void drawQRImage(string url)
	{
	}

	[Token(Token = "0x6006C4B")]
	[Address(RVA = "0xB43AF0", Offset = "0xB42CF0", VA = "0x180B43AF0")]
	private void generateNewOTP()
	{
	}

	[Token(Token = "0x6006C4C")]
	protected abstract Handle CallGenerateOtp();

	[Token(Token = "0x6006C4D")]
	public abstract void InitializeView(ElementObjectManager rootEOM, Selector selector, Action<ApprovalStatus> resultCallback);

	[Token(Token = "0x6006C4E")]
	[Address(RVA = "0xB44170", Offset = "0xB43370", VA = "0x180B44170")]
	protected void setupView(ElementObjectManager rootEOM, Selector selector, string descText, bool mailAddressEdit, Action<ApprovalStatus> resultCallback)
	{
	}

	[Token(Token = "0x6006C4F")]
	[Address(RVA = "0xB43320", Offset = "0xB42520", VA = "0x180B43320")]
	public void StartView()
	{
	}

	[Token(Token = "0x6006C50")]
	[Address(RVA = "0xB43280", Offset = "0xB42480", VA = "0x180B43280")]
	public void StopView()
	{
	}

	[Token(Token = "0x6006C51")]
	[Address(RVA = "0xB43280", Offset = "0xB42480", VA = "0x180B43280")]
	public void DestoryView()
	{
	}

	[Token(Token = "0x6006C52")]
	[Address(RVA = "0xB43890", Offset = "0xB42A90", VA = "0x180B43890")]
	public void UpdateView()
	{
	}

	[Token(Token = "0x6006C53")]
	[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
	protected void setPassedDialogMessage(string message)
	{
	}

	[Token(Token = "0x6006C54")]
	[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
	private void setStatus(ApprovalStatus status)
	{
	}

	[Token(Token = "0x6006C55")]
	[Address(RVA = "0xB44D30", Offset = "0xB43F30", VA = "0x180B44D30")]
	[IteratorStateMachine(typeof(_003CshowResultDialog_003Ed__57))]
	private IEnumerator showResultDialog(ApprovalStatus status)
	{
		return null;
	}

	[Token(Token = "0x6006C56")]
	[Address(RVA = "0xB44E70", Offset = "0xB44070", VA = "0x180B44E70")]
	[IteratorStateMachine(typeof(_003CstepStay_003Ed__58))]
	private IEnumerator stepStay(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006C57")]
	[Address(RVA = "0xB44E00", Offset = "0xB44000", VA = "0x180B44E00")]
	[IteratorStateMachine(typeof(_003CstepResult_003Ed__59))]
	private IEnumerator stepResult(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006C58")]
	[Address(RVA = "0xB44DB0", Offset = "0xB43FB0", VA = "0x180B44DB0")]
	private void stepFinish(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006C59")]
	protected abstract Handle CallGetStatusAPI();

	[Token(Token = "0x6006C5A")]
	[Address(RVA = "0xB43E90", Offset = "0xB43090", VA = "0x180B43E90")]
	[IteratorStateMachine(typeof(_003Cpolling_003Ed__62))]
	private IEnumerator polling()
	{
		return null;
	}

	[Token(Token = "0x6006C5B")]
	[Address(RVA = "0xB44040", Offset = "0xB43240", VA = "0x180B44040")]
	[IteratorStateMachine(typeof(_003CrequestWebAPICoroutine_003Ed__63))]
	private IEnumerator requestWebAPICoroutine(Func<Handle> createHandle, Func<int, bool> hookError, Action resultCallback, string debugApiName)
	{
		return null;
	}

	[Token(Token = "0x6006C5C")]
	[Address(RVA = "0xB43F00", Offset = "0xB43100", VA = "0x180B43F00")]
	private void requestWebAPICall(Func<Handle> createHandle, Action resultCallback, string debugApiName)
	{
	}

	[Token(Token = "0x6006C5D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x6006C5E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected ApprovalView()
	{
	}
}
