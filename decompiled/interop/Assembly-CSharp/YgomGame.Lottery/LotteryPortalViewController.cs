using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Lottery;

[Token(Token = "0x2001715")]
public class LotteryPortalViewController : BaseMenuViewController
{
	[Token(Token = "0x2001716")]
	private class TransitionController
	{
		[Token(Token = "0x400DA73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Queue<Action> transitionQueue;

		[Token(Token = "0x400DA74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_TransitionCount;

		[Token(Token = "0x17001648")]
		public bool isDoing
		{
			[Token(Token = "0x60090FF")]
			[Address(RVA = "0xDA5A70", Offset = "0xDA4C70", VA = "0x180DA5A70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6009100")]
		[Address(RVA = "0xDB8390", Offset = "0xDB7590", VA = "0x180DB8390")]
		public TransitionController()
		{
		}

		[Token(Token = "0x6009101")]
		[Address(RVA = "0xDB8230", Offset = "0xDB7430", VA = "0x180DB8230")]
		public void OnStacking(ViewControllerManager vcm, ViewController vc, bool isEntry, ViewController portalVC)
		{
		}

		[Token(Token = "0x6009102")]
		[Address(RVA = "0xDB82F0", Offset = "0xDB74F0", VA = "0x180DB82F0")]
		public void OnUpdate(ViewController vc)
		{
		}

		[Token(Token = "0x6009103")]
		[Address(RVA = "0x949D90", Offset = "0x948F90", VA = "0x180949D90")]
		public void DecTransitionCount()
		{
		}

		[Token(Token = "0x6009104")]
		[Address(RVA = "0xDB8220", Offset = "0xDB7420", VA = "0x180DB8220")]
		public void AddTransitionCount()
		{
		}
	}

	[Token(Token = "0x400DA6C")]
	public const string k_PrefPath = "Lottery/LotteryPortal";

	[Token(Token = "0x400DA6D")]
	public const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DA6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_HelpPath;

	[Token(Token = "0x400DA6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_SECategory;

	[Token(Token = "0x400DA70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private TransitionController m_Controller;

	[Token(Token = "0x400DA71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_Id;

	[Token(Token = "0x400DA72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool m_IsDispProgress;

	[Token(Token = "0x17001647")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60090E5")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60090E6")]
	[Address(RVA = "0xDAC000", Offset = "0xDAB200", VA = "0x180DAC000")]
	public static void Open(int id, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60090E7")]
	[Address(RVA = "0xDABCE0", Offset = "0xDAAEE0", VA = "0x180DABCE0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60090E8")]
	[Address(RVA = "0xDAB820", Offset = "0xDAAA20", VA = "0x180DAB820", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60090E9")]
	[Address(RVA = "0xDABAF0", Offset = "0xDAACF0", VA = "0x180DABAF0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60090EA")]
	[Address(RVA = "0xDABB80", Offset = "0xDAAD80", VA = "0x180DABB80", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60090EB")]
	[Address(RVA = "0xDACB40", Offset = "0xDABD40", VA = "0x180DACB40")]
	private void Update()
	{
	}

	[Token(Token = "0x60090EC")]
	[Address(RVA = "0xDAB5E0", Offset = "0xDAA7E0", VA = "0x180DAB5E0")]
	private void MakeNextPageQueue(int pageId)
	{
	}

	[Token(Token = "0x60090ED")]
	[Address(RVA = "0xDACBF0", Offset = "0xDABDF0", VA = "0x180DACBF0")]
	public LotteryPortalViewController()
	{
	}
}
