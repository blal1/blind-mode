using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;

namespace YgomGame.Lottery;

[Token(Token = "0x2001712")]
public class LotteryFirstViewViewController : BaseMenuViewController, ILotteryChildViewControllerGroup
{
	[Token(Token = "0x2001713")]
	[CompilerGenerated]
	private sealed class _003CyTestCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DA59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DA5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DA5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotteryFirstViewViewController _003C_003E4__this;

		[Token(Token = "0x400DA5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x400DA5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x17001643")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60090DA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001644")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60090DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60090D7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyTestCoroutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60090D8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60090D9")]
		[Address(RVA = "0xDBF970", Offset = "0xDBEB70", VA = "0x180DBF970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60090DB")]
		[Address(RVA = "0xDBFB50", Offset = "0xDBED50", VA = "0x180DBFB50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DA54")]
	private const string k_PrefPath = "Lottery/LotteryFirstView";

	[Token(Token = "0x400DA55")]
	private const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DA56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float m_Time;

	[Token(Token = "0x400DA57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private int m_RoundNum;

	[Token(Token = "0x400DA58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int m_Id;

	[Token(Token = "0x17001641")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60090CF")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001642")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60090D0")]
		[Address(RVA = "0xDAA250", Offset = "0xDA9450", VA = "0x180DAA250", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60090D1")]
	[Address(RVA = "0xDAA130", Offset = "0xDA9330", VA = "0x180DAA130")]
	public static void Open(int id, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60090D2")]
	[Address(RVA = "0xDA9E50", Offset = "0xDA9050", VA = "0x180DA9E50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60090D3")]
	[Address(RVA = "0xDA9EC0", Offset = "0xDA90C0", VA = "0x180DA9EC0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60090D4")]
	[Address(RVA = "0xDAA320", Offset = "0xDA9520", VA = "0x180DAA320")]
	[IteratorStateMachine(typeof(_003CyTestCoroutine_003Ed__12))]
	private IEnumerator yTestCoroutine(float time, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60090D5")]
	[Address(RVA = "0xDAA230", Offset = "0xDA9430", VA = "0x180DAA230")]
	public LotteryFirstViewViewController()
	{
	}
}
