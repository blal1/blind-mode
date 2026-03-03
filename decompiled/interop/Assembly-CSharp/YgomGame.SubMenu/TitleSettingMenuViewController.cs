using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.SubMenu;

[Token(Token = "0x200104C")]
public class TitleSettingMenuViewController : SubMenuViewController
{
	[Token(Token = "0x200104F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x400ADDB")]
		[FieldOffset(Offset = "0x10")]
		public bool cacheClearflag;

		[Token(Token = "0x60062C3")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60062C4")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CCacheClear_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001050")]
	[CompilerGenerated]
	private sealed class _003CCacheClear_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400ADDC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400ADDD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400ADDE")]
		[FieldOffset(Offset = "0x20")]
		public Action onPreCacheClear;

		[Token(Token = "0x400ADDF")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x400ADE0")]
		[FieldOffset(Offset = "0x30")]
		public Action onPostCacheClear;

		[Token(Token = "0x17000F66")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60062C8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F67")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60062CA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60062C5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCacheClear_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60062C6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60062C7")]
		[Address(RVA = "0xA9C870", Offset = "0xA9BA70", VA = "0x180A9C870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60062C9")]
		[Address(RVA = "0xA9CBC0", Offset = "0xA9BDC0", VA = "0x180A9CBC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x17000F65")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60062B5")]
		[Address(RVA = "0xA9AE70", Offset = "0xA9A070", VA = "0x180A9AE70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60062B6")]
	[Address(RVA = "0xA8FB50", Offset = "0xA8ED50", VA = "0x180A8FB50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60062B7")]
	[Address(RVA = "0xA9A830", Offset = "0xA99A30", VA = "0x180A9A830", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60062B8")]
	[Address(RVA = "0xA9A7A0", Offset = "0xA999A0", VA = "0x180A9A7A0")]
	[IteratorStateMachine(typeof(_003CCacheClear_003Ed__4))]
	private IEnumerator CacheClear(Action onPreCacheClear, Action onPostCacheClear)
	{
		return null;
	}

	[Token(Token = "0x60062B9")]
	[Address(RVA = "0xA90330", Offset = "0xA8F530", VA = "0x180A90330")]
	public TitleSettingMenuViewController()
	{
	}
}
