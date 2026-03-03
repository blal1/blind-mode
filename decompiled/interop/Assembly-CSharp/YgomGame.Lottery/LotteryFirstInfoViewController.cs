using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;

namespace YgomGame.Lottery;

[Token(Token = "0x2001710")]
public class LotteryFirstInfoViewController : BaseMenuViewController, ILotteryChildViewControllerGroup
{
	[Token(Token = "0x2001711")]
	[CompilerGenerated]
	private sealed class _003CyCheckTimeline_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DA4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DA50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DA51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayableDirector pd;

		[Token(Token = "0x400DA52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x400DA53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LotteryFirstInfoViewController _003C_003E4__this;

		[Token(Token = "0x1700163F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60090CC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001640")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60090CE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60090C9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCheckTimeline_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60090CA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60090CB")]
		[Address(RVA = "0xDBEDC0", Offset = "0xDBDFC0", VA = "0x180DBEDC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60090CD")]
		[Address(RVA = "0xDBEF20", Offset = "0xDBE120", VA = "0x180DBEF20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DA4B")]
	private const string k_PrefPath = "Lottery/LotteryFirstInfo";

	[Token(Token = "0x400DA4C")]
	private const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DA4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int m_Id;

	[Token(Token = "0x400DA4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Coroutine m_Coroutine;

	[Token(Token = "0x1700163D")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60090C1")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700163E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60090C2")]
		[Address(RVA = "0xDA9CD0", Offset = "0xDA8ED0", VA = "0x180DA9CD0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60090C3")]
	[Address(RVA = "0xDA9BD0", Offset = "0xDA8DD0", VA = "0x180DA9BD0")]
	public static void Open(int id, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60090C4")]
	[Address(RVA = "0xDA9B60", Offset = "0xDA8D60", VA = "0x180DA9B60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60090C5")]
	[Address(RVA = "0xDA9840", Offset = "0xDA8A40", VA = "0x180DA9840", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60090C6")]
	[Address(RVA = "0xDA98B0", Offset = "0xDA8AB0", VA = "0x180DA98B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60090C7")]
	[Address(RVA = "0xDA9DA0", Offset = "0xDA8FA0", VA = "0x180DA9DA0")]
	[IteratorStateMachine(typeof(_003CyCheckTimeline_003Ed__12))]
	private IEnumerator yCheckTimeline(PlayableDirector pd, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60090C8")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public LotteryFirstInfoViewController()
	{
	}
}
