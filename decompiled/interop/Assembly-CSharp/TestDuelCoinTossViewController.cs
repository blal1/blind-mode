using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

[Token(Token = "0x2000011")]
public class TestDuelCoinTossViewController : DuelStartViewController
{
	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class _003CyInit_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		public TestDuelCoinTossViewController _003C_003E4__this;

		[Token(Token = "0x17000005")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInit_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3EB550", Offset = "0x3EA750", VA = "0x1803EB550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3EB580", Offset = "0x3EA780", VA = "0x1803EB580", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x220")]
	private ElementObjectManager m_StartUIEom;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x228")]
	private string cantSelectJson;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x230")]
	private string canSelectJson;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x238")]
	private GameObject rootCanChoice2;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x240")]
	private GameObject rootCantChoice2;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x248")]
	private List<int> coinIdList;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x250")]
	private List<string> coinIdStringList;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x258")]
	private int coinIndex;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x25C")]
	private bool isUseDummyJson;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x260")]
	private readonly string ROOT_CAN_CHOICE_LABEL;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x268")]
	private readonly string ROOT_CANT_CHOICE_LABEL;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x270")]
	private List<string> loadedPathList;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3E55D0", Offset = "0x3E47D0", VA = "0x1803E55D0")]
	public bool LoadDummyJson(bool isChoice = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3E56F0", Offset = "0x3E48F0", VA = "0x1803E56F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3E5BA0", Offset = "0x3E4DA0", VA = "0x1803E5BA0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void PlayTimeline()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3E5C20", Offset = "0x3E4E20", VA = "0x1803E5C20", Slot = "33")]
	protected override void SelectTurn()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3E6480", Offset = "0x3E5680", VA = "0x1803E6480", Slot = "37")]
	[IteratorStateMachine(typeof(_003CyInit_003Ed__17))]
	protected override IEnumerator yInit()
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3E5400", Offset = "0x3E4600", VA = "0x1803E5400", Slot = "29")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3E59D0", Offset = "0x3E4BD0", VA = "0x1803E59D0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3E5E50", Offset = "0x3E5050", VA = "0x1803E5E50", Slot = "35")]
	protected override void StartDuel()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3E5300", Offset = "0x3E4500", VA = "0x1803E5300", Slot = "34")]
	protected override void DuelBegin()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3E5AF0", Offset = "0x3E4CF0", VA = "0x1803E5AF0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3E62A0", Offset = "0x3E54A0", VA = "0x1803E62A0")]
	public TestDuelCoinTossViewController()
	{
	}
}
