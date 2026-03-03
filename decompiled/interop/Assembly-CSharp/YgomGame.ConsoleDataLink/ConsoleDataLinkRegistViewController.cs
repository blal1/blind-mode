using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.Network;

namespace YgomGame.ConsoleDataLink;

[Token(Token = "0x200113E")]
public class ConsoleDataLinkRegistViewController : ConsoleDataLinkViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001141")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x400B5BC")]
		[FieldOffset(Offset = "0x10")]
		public bool isEnd;

		[Token(Token = "0x400B5BD")]
		[FieldOffset(Offset = "0x11")]
		public bool waitDialogIsActive;

		[Token(Token = "0x400B5BE")]
		[FieldOffset(Offset = "0x18")]
		public ConsoleDataLinkRegistViewController _003C_003E4__this;

		[Token(Token = "0x400B5BF")]
		[FieldOffset(Offset = "0x20")]
		public bool APICompleteCheck;

		[Token(Token = "0x400B5C0")]
		[FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__1;

		[Token(Token = "0x400B5C1")]
		[FieldOffset(Offset = "0x30")]
		public Action _003C_003E9__2;

		[Token(Token = "0x6006C1D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6006C1E")]
		[Address(RVA = "0xB3D030", Offset = "0xB3C230", VA = "0x180B3D030")]
		internal void _003CKonamiIDCheckLink_Polling_003Eb__0(Handle handle)
		{
		}

		[Token(Token = "0x6006C1F")]
		[Address(RVA = "0xB3D3D0", Offset = "0xB3C5D0", VA = "0x180B3D3D0")]
		internal void _003CKonamiIDCheckLink_Polling_003Eb__1()
		{
		}

		[Token(Token = "0x6006C20")]
		[Address(RVA = "0xB3D430", Offset = "0xB3C630", VA = "0x180B3D430")]
		internal void _003CKonamiIDCheckLink_Polling_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2001142")]
	[CompilerGenerated]
	private sealed class _003CKonamiIDCheckLink_Polling_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B5C2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B5C3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B5C4")]
		[FieldOffset(Offset = "0x20")]
		public ConsoleDataLinkRegistViewController _003C_003E4__this;

		[Token(Token = "0x400B5C5")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x1700112B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006C24")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700112C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006C26")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006C21")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CKonamiIDCheckLink_Polling_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006C22")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006C23")]
		[Address(RVA = "0xB3B830", Offset = "0xB3AA30", VA = "0x180B3B830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006C25")]
		[Address(RVA = "0xB3B9F0", Offset = "0xB3ABF0", VA = "0x180B3B9F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B5B6")]
	[FieldOffset(Offset = "0x1D0")]
	private string m_linkUrl;

	[Token(Token = "0x6006C0F")]
	[Address(RVA = "0xB25330", Offset = "0xB24530", VA = "0x180B25330", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006C10")]
	[Address(RVA = "0xB256E0", Offset = "0xB248E0", VA = "0x180B256E0")]
	private void Regist()
	{
	}

	[Token(Token = "0x6006C11")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006C12")]
	[Address(RVA = "0xB251E0", Offset = "0xB243E0", VA = "0x180B251E0")]
	private void CheckRegistered(UnityAction unregesteredEvent)
	{
	}

	[Token(Token = "0x6006C13")]
	[Address(RVA = "0xB252C0", Offset = "0xB244C0", VA = "0x180B252C0")]
	[IteratorStateMachine(typeof(_003CKonamiIDCheckLink_Polling_003Ed__5))]
	private IEnumerator KonamiIDCheckLink_Polling()
	{
		return null;
	}

	[Token(Token = "0x6006C14")]
	[Address(RVA = "0xB25000", Offset = "0xB24200", VA = "0x180B25000")]
	public ConsoleDataLinkRegistViewController()
	{
	}
}
