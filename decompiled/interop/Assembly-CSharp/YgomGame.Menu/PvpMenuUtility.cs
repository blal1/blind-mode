using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Menu;

[Token(Token = "0x20013CF")]
public class PvpMenuUtility
{
	[Token(Token = "0x20013D0")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x400C3D6")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6007B33")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6007B34")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CyShowMatchingErrorDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20013D1")]
	[CompilerGenerated]
	private sealed class _003CyShowMatchingErrorDialog_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3D7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3D8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3D9")]
		[FieldOffset(Offset = "0x20")]
		public PvPCode errorCode;

		[Token(Token = "0x400C3DA")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		[Token(Token = "0x170012F1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007B38")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007B3A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007B35")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyShowMatchingErrorDialog_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007B36")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007B37")]
		[Address(RVA = "0xC52090", Offset = "0xC51290", VA = "0x180C52090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007B39")]
		[Address(RVA = "0xC522B0", Offset = "0xC514B0", VA = "0x180C522B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20013D2")]
	[CompilerGenerated]
	private sealed class _003CyShowMatchingErrorToast_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3DB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3DC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3DD")]
		[FieldOffset(Offset = "0x20")]
		public PvPCode errorCode;

		[Token(Token = "0x170012F3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007B3E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007B40")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007B3B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyShowMatchingErrorToast_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007B3C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007B3D")]
		[Address(RVA = "0xC522F0", Offset = "0xC514F0", VA = "0x180C522F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007B3F")]
		[Address(RVA = "0xC52360", Offset = "0xC51560", VA = "0x180C52360", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6007B2E")]
	[Address(RVA = "0xC48610", Offset = "0xC47810", VA = "0x180C48610")]
	public static bool IsRetryableMatchingResult(int code)
	{
		return default(bool);
	}

	[Token(Token = "0x6007B2F")]
	[Address(RVA = "0xC48390", Offset = "0xC47590", VA = "0x180C48390")]
	public static void GetErrorDialogText(PvPCode errorCode, ref string title, ref string msg)
	{
	}

	[Token(Token = "0x6007B30")]
	[Address(RVA = "0xC48620", Offset = "0xC47820", VA = "0x180C48620")]
	[IteratorStateMachine(typeof(_003CyShowMatchingErrorDialog_003Ed__2))]
	public static IEnumerator yShowMatchingErrorDialog(PvPCode errorCode)
	{
		return null;
	}

	[Token(Token = "0x6007B31")]
	[Address(RVA = "0xC48680", Offset = "0xC47880", VA = "0x180C48680")]
	[IteratorStateMachine(typeof(_003CyShowMatchingErrorToast_003Ed__3))]
	public static IEnumerator yShowMatchingErrorToast(PvPCode errorCode)
	{
		return null;
	}

	[Token(Token = "0x6007B32")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PvpMenuUtility()
	{
	}
}
