using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Test;

[Token(Token = "0x2001748")]
public class MonsterCutinTest : ViewController
{
	[Token(Token = "0x200174D")]
	[CompilerGenerated]
	private sealed class _003CContinuousPlayCutin_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DB82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DB83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DB84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterCutinTest _003C_003E4__this;

		[Token(Token = "0x400DB85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17001663")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600921B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001664")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600921D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009218")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CContinuousPlayCutin_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009219")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600921A")]
		[Address(RVA = "0xDD6520", Offset = "0xDD5720", VA = "0x180DD6520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600921C")]
		[Address(RVA = "0xDD67C0", Offset = "0xDD59C0", VA = "0x180DD67C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200174E")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DB86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DB87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DB88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterCutinTest _003C_003E4__this;

		[Token(Token = "0x17001665")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009221")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001666")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009223")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600921E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600921F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009220")]
		[Address(RVA = "0xDD6920", Offset = "0xDD5B20", VA = "0x180DD6920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009222")]
		[Address(RVA = "0xDD6B00", Offset = "0xDD5D00", VA = "0x180DD6B00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DB61")]
	public const string ArgKey_EnableBack = "EnableBack";

	[Token(Token = "0x400DB62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400DB63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private CardIndividualSetting setting;

	[Token(Token = "0x400DB64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool[] continuousTargets;

	[Token(Token = "0x400DB65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int cardID;

	[Token(Token = "0x400DB66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool useCardParameter;

	[Token(Token = "0x400DB67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool isMyself;

	[Token(Token = "0x400DB68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	private bool isContinuousPlay;

	[Token(Token = "0x400DB69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
	private bool isContinuousPlayRecord;

	[Token(Token = "0x400DB6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float interval;

	[Token(Token = "0x400DB6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Content.Attribute attribute;

	[Token(Token = "0x400DB6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string cardName;

	[Token(Token = "0x400DB6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private MonsterCutinEffect.LevelType levelType;

	[Token(Token = "0x400DB6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int level;

	[Token(Token = "0x400DB6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int attack;

	[Token(Token = "0x400DB70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int defense;

	[Token(Token = "0x400DB71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isOcg;

	[Token(Token = "0x400DB72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private MonsterCutinEffect monsterCutinEffect;

	[Token(Token = "0x400DB73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isPlaying;

	[Token(Token = "0x400DB74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ElementObjectManager ui;

	[Token(Token = "0x60091F2")]
	[Address(RVA = "0xDD4280", Offset = "0xDD3480", VA = "0x180DD4280", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60091F3")]
	[Address(RVA = "0xDD4210", Offset = "0xDD3410", VA = "0x180DD4210")]
	[IteratorStateMachine(typeof(_003CContinuousPlayCutin_003Ed__21))]
	private IEnumerator ContinuousPlayCutin()
	{
		return null;
	}

	[Token(Token = "0x60091F4")]
	[Address(RVA = "0xDD5330", Offset = "0xDD4530", VA = "0x180DD5330")]
	private void PlayCutin(int cardID, [Optional] Action onFinish)
	{
	}

	[Token(Token = "0x60091F5")]
	[Address(RVA = "0xDD55D0", Offset = "0xDD47D0", VA = "0x180DD55D0")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__23))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60091F6")]
	[Address(RVA = "0xDD59F0", Offset = "0xDD4BF0", VA = "0x180DD59F0")]
	public MonsterCutinTest()
	{
	}
}
