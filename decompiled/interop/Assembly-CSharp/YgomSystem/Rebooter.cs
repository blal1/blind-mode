using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.Utility;

namespace YgomSystem;

[Token(Token = "0x20001DC")]
[DisallowMultipleComponent]
public class Rebooter : MonoBehaviour
{
	[Token(Token = "0x20001DD")]
	[CompilerGenerated]
	private sealed class _003CRebootProcess_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x20")]
		public AppInfo.BootType boottype;

		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x28")]
		public string bootpage;

		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x30")]
		public UnityAction onEnd;

		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x38")]
		public Rebooter _003C_003E4__this;

		[Token(Token = "0x1700012B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CRebootProcess_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xC17B90", Offset = "0xC16D90", VA = "0x180C17B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xC18360", Offset = "0xC17560", VA = "0x180C18360", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x20")]
	private IEnumerator _proc;

	[Token(Token = "0x17000129")]
	public static Rebooter instance
	{
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xC12000", Offset = "0xC11200", VA = "0x180C12000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xC12110", Offset = "0xC11310", VA = "0x180C12110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700012A")]
	public static bool rebooting
	{
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xC12040", Offset = "0xC11240", VA = "0x180C12040")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0xC11C40", Offset = "0xC10E40", VA = "0x180C11C40")]
	public static void Execute(string bootpage, AppInfo.BootType boottype, UnityAction onEnd)
	{
	}

	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0xC11AF0", Offset = "0xC10CF0", VA = "0x180C11AF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0xC11D70", Offset = "0xC10F70", VA = "0x180C11D70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0xC11F00", Offset = "0xC11100", VA = "0x180C11F00")]
	private void RebootStart(string bootpage, AppInfo.BootType boottype, UnityAction onEnd)
	{
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0xC11E40", Offset = "0xC11040", VA = "0x180C11E40")]
	[IteratorStateMachine(typeof(_003CRebootProcess_003Ed__11))]
	private IEnumerator RebootProcess(string bootpage, AppInfo.BootType boottype, UnityAction onEnd)
	{
		return null;
	}

	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public Rebooter()
	{
	}
}
