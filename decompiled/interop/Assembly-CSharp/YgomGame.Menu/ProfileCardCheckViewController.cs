using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200130F")]
public class ProfileCardCheckViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001310")]
	[CompilerGenerated]
	private sealed class _003CDelayedInvokeCallback_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BF11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BF12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BF13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x17001271")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600764D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001272")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600764F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600764A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedInvokeCallback_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600764B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600764C")]
		[Address(RVA = "0xBCCD00", Offset = "0xBCBF00", VA = "0x180BCCD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600764E")]
		[Address(RVA = "0xBCCD70", Offset = "0xBCBF70", VA = "0x180BCCD70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BF08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelProfileCardRoot;

	[Token(Token = "0x400BF09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelBackButton;

	[Token(Token = "0x400BF0A")]
	public const string k_ArgKeyPcode = "pcode";

	[Token(Token = "0x400BF0B")]
	public const string k_ArgKeyCallAPI = "callAPI";

	[Token(Token = "0x400BF0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject m_ProfileCardParent;

	[Token(Token = "0x400BF0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private SelectionButton m_BackButton;

	[Token(Token = "0x400BF0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private long pcode;

	[Token(Token = "0x400BF0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool callAPI;

	[Token(Token = "0x400BF10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Dictionary<string, object> profileDic;

	[Token(Token = "0x6007642")]
	[Address(RVA = "0xBC7550", Offset = "0xBC6750", VA = "0x180BC7550", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007643")]
	[Address(RVA = "0xBC7920", Offset = "0xBC6B20", VA = "0x180BC7920")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007644")]
	[Address(RVA = "0xBC7670", Offset = "0xBC6870", VA = "0x180BC7670", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007645")]
	[Address(RVA = "0xBC74E0", Offset = "0xBC66E0", VA = "0x180BC74E0")]
	[IteratorStateMachine(typeof(_003CDelayedInvokeCallback_003Ed__12))]
	private IEnumerator DelayedInvokeCallback(Action action)
	{
		return null;
	}

	[Token(Token = "0x6007646")]
	[Address(RVA = "0xBC7C40", Offset = "0xBC6E40", VA = "0x180BC7C40")]
	public ProfileCardCheckViewController()
	{
	}
}
