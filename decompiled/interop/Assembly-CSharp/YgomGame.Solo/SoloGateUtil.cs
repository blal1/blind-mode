using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.Solo;

[Token(Token = "0x200088F")]
public class SoloGateUtil
{
	[Token(Token = "0x2000890")]
	internal class GateManager
	{
		[Token(Token = "0x40086CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Dictionary<int, Data> masterDataDic;

		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x768DF0", Offset = "0x767FF0", VA = "0x180768DF0")]
		public GateManager()
		{
		}
	}

	[Token(Token = "0x2000891")]
	internal class Data
	{
		[Token(Token = "0x40086D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int gateID;

		[Token(Token = "0x40086D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string gateName;

		[Token(Token = "0x40086D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string strOverview;

		[Token(Token = "0x40086D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string strUnlocks;

		[Token(Token = "0x40086D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isClear;

		[Token(Token = "0x40086D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isComplete;

		[Token(Token = "0x40086D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool isBadge;

		[Token(Token = "0x40086D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool haveCanUnlockChapter;

		[Token(Token = "0x40086D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal bool isUnlocked;

		[Token(Token = "0x40086D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int priority;

		[Token(Token = "0x40086DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal long openDate;

		[Token(Token = "0x40086DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal long lastPlayDate;

		[Token(Token = "0x40086DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool isActive;

		[Token(Token = "0x40086DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal int parentID;

		[Token(Token = "0x40086DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal bool isSelected;

		[Token(Token = "0x40086DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<int> childs;

		[Token(Token = "0x40086E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal GateManager gateManager;

		[Token(Token = "0x40086E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal int category;

		[Token(Token = "0x40086E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal bool isAnime;

		[Token(Token = "0x40086E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		internal bool isVoice;

		[Token(Token = "0x17000664")]
		internal string StrName
		{
			[Token(Token = "0x60033CB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60033CC")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000665")]
		internal bool IsComplete
		{
			[Token(Token = "0x60033CD")]
			[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033CE")]
			[Address(RVA = "0x768DE0", Offset = "0x767FE0", VA = "0x180768DE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000666")]
		internal bool IsClear
		{
			[Token(Token = "0x60033CF")]
			[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033D0")]
			[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000667")]
		internal bool IsBadge
		{
			[Token(Token = "0x60033D1")]
			[Address(RVA = "0x768C30", Offset = "0x767E30", VA = "0x180768C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033D2")]
			[Address(RVA = "0x768DD0", Offset = "0x767FD0", VA = "0x180768DD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000668")]
		internal bool HaveCanUnlockChapter
		{
			[Token(Token = "0x60033D3")]
			[Address(RVA = "0x768AA0", Offset = "0x767CA0", VA = "0x180768AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033D4")]
			[Address(RVA = "0x768DC0", Offset = "0x767FC0", VA = "0x180768DC0")]
			set
			{
			}
		}

		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x7689B0", Offset = "0x767BB0", VA = "0x1807689B0")]
		internal Data(int gateID, string strName, string strOverview, string strUnlocks, bool isUnlocked, bool haveUnlockChapter, int priority, long openDate, long lastPlayDate, bool isActive, int parentID, int category, bool isAnime, bool isVoice, GateManager gateManager)
		{
		}

		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x7681C0", Offset = "0x7673C0", VA = "0x1807681C0")]
		internal void AddChild(int child)
		{
		}

		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x7682B0", Offset = "0x7674B0", VA = "0x1807682B0")]
		internal void CheckCompleteClearFlag()
		{
		}

		[Token(Token = "0x60033D8")]
		[Address(RVA = "0x7686B0", Offset = "0x7678B0", VA = "0x1807686B0")]
		internal void UpdateDateInSubGate()
		{
		}
	}

	[Token(Token = "0x2000894")]
	[CompilerGenerated]
	private sealed class _003CTweenPlayCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40086E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40086E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40086E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject obj;

		[Token(Token = "0x40086E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x40086EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool includeChildren;

		[Token(Token = "0x40086EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool wakeup;

		[Token(Token = "0x40086EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action conpletedCallback;

		[Token(Token = "0x17000669")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60033EA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700066A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033EC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CTweenPlayCoroutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x7796E0", Offset = "0x7788E0", VA = "0x1807796E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x779820", Offset = "0x778A20", VA = "0x180779820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40086C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string TXT_GATENAME_LABEL;

	[Token(Token = "0x40086C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string TXT_CLEAR_LABEL;

	[Token(Token = "0x40086C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string TXT_COMPLETE_LABEL;

	[Token(Token = "0x40086C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string IMG_LOCK_LABEL;

	[Token(Token = "0x40086C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string IMG_GATE_LABEL;

	[Token(Token = "0x40086C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string IMG_ARROW_LABEL;

	[Token(Token = "0x40086C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly string IMG_BADGE_LABEL;

	[Token(Token = "0x40086C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly string IMG_CAN_UNLOCK_LABEL;

	[Token(Token = "0x40086CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly string BTN_LABEL;

	[Token(Token = "0x40086CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly string IMG_ANIME_LABEL;

	[Token(Token = "0x40086CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly string IMG_VOICE_LABEL;

	[Token(Token = "0x40086CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static readonly string TXT_PARENT_GATENAME_LABEL;

	[Token(Token = "0x40086CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly string OBJ_LOADINGICON_LABEL;

	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x76D230", Offset = "0x76C430", VA = "0x18076D230")]
	internal static void SetData(Data data, ElementObjectManager eom, GateManager gateManager, [Optional] UnityAction clickedCallback, [Optional] UnityAction selectedCallback)
	{
	}

	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x76DAF0", Offset = "0x76CCF0", VA = "0x18076DAF0")]
	internal static List<int> SortingGate(List<int> dataList, SoloFilterSortUtil.GateSort gateSort, GateManager gateManager)
	{
		return null;
	}

	[Token(Token = "0x60033BF")]
	[Address(RVA = "0x76C950", Offset = "0x76BB50", VA = "0x18076C950")]
	internal static List<int> FilteringGate(List<int> dataList, SoloFilterSortUtil.GateFilter filter, GateManager gateManager)
	{
		return null;
	}

	[Token(Token = "0x60033C0")]
	[Address(RVA = "0x76D810", Offset = "0x76CA10", VA = "0x18076D810")]
	internal static void SetFlags(Data data, ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60033C1")]
	[Address(RVA = "0x76D090", Offset = "0x76C290", VA = "0x18076D090")]
	internal static bool IsAnime(Data data, GateManager gateManager)
	{
		return default(bool);
	}

	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x76E310", Offset = "0x76D510", VA = "0x18076E310")]
	internal static void UpdateData(GateManager gateManager, TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x60033C3")]
	[Address(RVA = "0x76BFD0", Offset = "0x76B1D0", VA = "0x18076BFD0")]
	public static bool CheckUnlock(int unlockID, out string strUnlocks)
	{
		return default(bool);
	}

	[Token(Token = "0x60033C4")]
	[Address(RVA = "0x76B340", Offset = "0x76A540", VA = "0x18076B340")]
	internal static bool CheckHaveCanUnlockChapter(int gateID)
	{
		return default(bool);
	}

	[Token(Token = "0x60033C5")]
	[Address(RVA = "0x76DF70", Offset = "0x76D170", VA = "0x18076DF70")]
	internal static void UpdateBadge(GateManager gateManager)
	{
	}

	[Token(Token = "0x60033C6")]
	[Address(RVA = "0x76CD10", Offset = "0x76BF10", VA = "0x18076CD10")]
	internal static void InitGateManagerData(GateManager gateManager)
	{
	}

	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x76DEB0", Offset = "0x76D0B0", VA = "0x18076DEB0")]
	[IteratorStateMachine(typeof(_003CTweenPlayCoroutine_003Ed__23))]
	internal static IEnumerator TweenPlayCoroutine(GameObject obj, Action conpletedCallback, string label = "", bool includeChildren = false, bool wakeup = false)
	{
		return null;
	}

	[Token(Token = "0x60033C8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SoloGateUtil()
	{
	}
}
