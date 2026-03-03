using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.Network;

namespace YgomGame.ConsoleDataLink;

[Token(Token = "0x2001138")]
public class ConsoleDataLinkInheritViewController : ConsoleDataLinkViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200113B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x400B5AA")]
		[FieldOffset(Offset = "0x10")]
		public bool isEnd;

		[Token(Token = "0x400B5AB")]
		[FieldOffset(Offset = "0x18")]
		public ConsoleDataLinkInheritViewController _003C_003E4__this;

		[Token(Token = "0x400B5AC")]
		[FieldOffset(Offset = "0x20")]
		public string authSession;

		[Token(Token = "0x400B5AD")]
		[FieldOffset(Offset = "0x28")]
		public bool authSessionSuccess;

		[Token(Token = "0x6006C04")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6006C05")]
		[Address(RVA = "0xB3D430", Offset = "0xB3C630", VA = "0x180B3D430")]
		internal void _003CKonamiIDCheckInherit_Polling_003Eb__0()
		{
		}

		[Token(Token = "0x6006C06")]
		[Address(RVA = "0xB3DA50", Offset = "0xB3CC50", VA = "0x180B3DA50")]
		internal void _003CKonamiIDCheckInherit_Polling_003Eb__1(string session, bool success)
		{
		}
	}

	[Token(Token = "0x200113C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		[Token(Token = "0x400B5AE")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x6006C07")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[Token(Token = "0x6006C08")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CKonamiIDCheckInherit_Polling_003Eb__2(int _code)
		{
		}
	}

	[Token(Token = "0x200113D")]
	[CompilerGenerated]
	private sealed class _003CKonamiIDCheckInherit_Polling_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B5AF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B5B0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B5B1")]
		[FieldOffset(Offset = "0x20")]
		public ConsoleDataLinkInheritViewController _003C_003E4__this;

		[Token(Token = "0x400B5B2")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x400B5B3")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass8_1 _003C_003E8__2;

		[Token(Token = "0x400B5B4")]
		[FieldOffset(Offset = "0x38")]
		private string _003Cnonce_003E5__2;

		[Token(Token = "0x400B5B5")]
		[FieldOffset(Offset = "0x40")]
		private Handle _003Chandle_003E5__3;

		[Token(Token = "0x17001129")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C0C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700112A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C0E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C09")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CKonamiIDCheckInherit_Polling_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C0A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C0B")]
		[Address(RVA = "0xB3AF10", Offset = "0xB3A110", VA = "0x180B3AF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C0D")]
		[Address(RVA = "0xB3B7F0", Offset = "0xB3A9F0", VA = "0x180B3B7F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B5A4")]
	[FieldOffset(Offset = "0x1D0")]
	private bool inheritFrag;

	[Token(Token = "0x400B5A5")]
	[FieldOffset(Offset = "0x1D8")]
	private string m_limitMessageText;

	[Token(Token = "0x6006BF1")]
	[Address(RVA = "0xB25010", Offset = "0xB24210", VA = "0x180B25010")]
	private static string getLimitMessageText()
	{
		return null;
	}

	[Token(Token = "0x6006BF2")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006BF3")]
	[Address(RVA = "0xB247E0", Offset = "0xB239E0", VA = "0x180B247E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006BF4")]
	[Address(RVA = "0xB24CA0", Offset = "0xB23EA0", VA = "0x180B24CA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006BF5")]
	[Address(RVA = "0xB25020", Offset = "0xB24220", VA = "0x180B25020")]
	private void onClickInheritButton(Action action)
	{
	}

	[Token(Token = "0x6006BF6")]
	[Address(RVA = "0xB246E0", Offset = "0xB238E0", VA = "0x180B246E0")]
	private void Inherit()
	{
	}

	[Token(Token = "0x6006BF7")]
	[Address(RVA = "0xB24770", Offset = "0xB23970", VA = "0x180B24770")]
	[IteratorStateMachine(typeof(_003CKonamiIDCheckInherit_Polling_003Ed__8))]
	private IEnumerator KonamiIDCheckInherit_Polling()
	{
		return null;
	}

	[Token(Token = "0x6006BF8")]
	[Address(RVA = "0xB25000", Offset = "0xB24200", VA = "0x180B25000")]
	public ConsoleDataLinkInheritViewController()
	{
	}
}
