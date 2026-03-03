using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Lottery;

[Token(Token = "0x20016D7")]
public class LotteryDummyPortalViewController : BaseMenuViewController
{
	[Token(Token = "0x20016D8")]
	private class TransitionController
	{
		[Token(Token = "0x400D8E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Queue<Action> transitionQueue;

		[Token(Token = "0x400D8E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_TransitionCount;

		[Token(Token = "0x17001592")]
		public bool isDoing
		{
			[Token(Token = "0x6008E27")]
			[Address(RVA = "0xDA5A70", Offset = "0xDA4C70", VA = "0x180DA5A70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6008E28")]
		[Address(RVA = "0xDA59F0", Offset = "0xDA4BF0", VA = "0x180DA59F0")]
		public TransitionController()
		{
		}

		[Token(Token = "0x6008E29")]
		[Address(RVA = "0xDA5890", Offset = "0xDA4A90", VA = "0x180DA5890")]
		public void OnStacking(ViewControllerManager vcm, ViewController vc, bool isEntry, ViewController portalVC)
		{
		}

		[Token(Token = "0x6008E2A")]
		[Address(RVA = "0xDA5950", Offset = "0xDA4B50", VA = "0x180DA5950")]
		public void OnUpdate(ViewController vc)
		{
		}

		[Token(Token = "0x6008E2B")]
		[Address(RVA = "0x949D90", Offset = "0x948F90", VA = "0x180949D90")]
		public void DecTransitionCount()
		{
		}
	}

	[Token(Token = "0x400D8DC")]
	public const string k_PrefPath = "Lottery/LotteryPortal";

	[Token(Token = "0x400D8DD")]
	public const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400D8DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_SECategory;

	[Token(Token = "0x400D8DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private TransitionController m_Controller;

	[Token(Token = "0x400D8E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_Id;

	[Token(Token = "0x17001591")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6008E1C")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008E1D")]
	[Address(RVA = "0xDA43D0", Offset = "0xDA35D0", VA = "0x180DA43D0")]
	public static void Open(int id, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008E1E")]
	[Address(RVA = "0xDA41D0", Offset = "0xDA33D0", VA = "0x180DA41D0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E1F")]
	[Address(RVA = "0xDA3DF0", Offset = "0xDA2FF0", VA = "0x180DA3DF0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008E20")]
	[Address(RVA = "0xDA40F0", Offset = "0xDA32F0", VA = "0x180DA40F0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008E21")]
	[Address(RVA = "0xDA45F0", Offset = "0xDA37F0", VA = "0x180DA45F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6008E22")]
	[Address(RVA = "0xDA46A0", Offset = "0xDA38A0", VA = "0x180DA46A0")]
	public LotteryDummyPortalViewController()
	{
	}
}
