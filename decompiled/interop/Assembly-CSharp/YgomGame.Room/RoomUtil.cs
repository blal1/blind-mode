using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.Network;

namespace YgomGame.Room;

[Token(Token = "0x2000B0A")]
public class RoomUtil
{
	[Token(Token = "0x2000B0B")]
	public enum LPType
	{
		[Token(Token = "0x4009526")]
		LP_8000 = 1,
		[Token(Token = "0x4009527")]
		LP_4000
	}

	[Token(Token = "0x2000B0C")]
	public static class LP
	{
		[Token(Token = "0x4009528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, int> s_lpDic;

		[Token(Token = "0x1700090A")]
		public static int typeCount
		{
			[Token(Token = "0x60043CF")]
			[Address(RVA = "0x8C9260", Offset = "0x8C8460", VA = "0x1808C9260")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700090B")]
		public static List<string> makeStringArray
		{
			[Token(Token = "0x60043D0")]
			[Address(RVA = "0x8C8FC0", Offset = "0x8C81C0", VA = "0x1808C8FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60043D1")]
		[Address(RVA = "0x8C8B70", Offset = "0x8C7D70", VA = "0x1808C8B70")]
		public static int GetIndexByType(LPType type)
		{
			return default(int);
		}

		[Token(Token = "0x60043D2")]
		[Address(RVA = "0x8C8D80", Offset = "0x8C7F80", VA = "0x1808C8D80")]
		public static int GetLPTypeFromIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60043D3")]
		[Address(RVA = "0x8C8CE0", Offset = "0x8C7EE0", VA = "0x1808C8CE0")]
		public static int GetLPFromType(LPType type)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000B0D")]
	public struct DuelTimeSetting
	{
		[Token(Token = "0x1700090C")]
		public int id
		{
			[Token(Token = "0x60043D6")]
			[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60043D5")]
			[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700090D")]
		public string name
		{
			[Token(Token = "0x60043D8")]
			[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60043D7")]
			[Address(RVA = "0x5BF770", Offset = "0x5BE970", VA = "0x1805BF770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700090E")]
		public int duration
		{
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60043D9")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700090F")]
		public int order
		{
			[Token(Token = "0x60043DC")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60043DB")]
			[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x8C8B40", Offset = "0x8C7D40", VA = "0x1808C8B40", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}

		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x8C8AA0", Offset = "0x8C7CA0", VA = "0x1808C8AA0")]
		public static string ToString(string name, int duration)
		{
			return null;
		}
	}

	[Token(Token = "0x2000B12")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4009538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DialogViewControllerManager dlgViewMgr;

		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x8DFF70", Offset = "0x8DF170", VA = "0x1808DFF70")]
		internal bool _003CCloseAllDialogsRoutine_003Eb__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000B13")]
	[CompilerGenerated]
	private sealed class _003CCloseAllDialogsRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400953A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400953B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x17000910")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60043EF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000911")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60043F1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCloseAllDialogsRoutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x8DAEF0", Offset = "0x8DA0F0", VA = "0x1808DAEF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x8DB090", Offset = "0x8DA290", VA = "0x1808DB090", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60043C8")]
	[Address(RVA = "0x8D8A70", Offset = "0x8D7C70", VA = "0x1808D8A70")]
	public static bool HandleResultCode(Handle handle, [Optional] UnityAction onSuccess, [Optional] UnityAction<RoomCode> onFailed)
	{
		return default(bool);
	}

	[Token(Token = "0x60043C9")]
	[Address(RVA = "0x8D8780", Offset = "0x8D7980", VA = "0x1808D8780")]
	public static void CallGetDeckList(int deckId, Action<bool> onEnd)
	{
	}

	[Token(Token = "0x60043CA")]
	[Address(RVA = "0x8D8850", Offset = "0x8D7A50", VA = "0x1808D8850")]
	public static void CallReplayAPIForRoom(long did, long pcode, [Optional] Action<PvPCode> onResult)
	{
	}

	[Token(Token = "0x60043CB")]
	[Address(RVA = "0x8D8920", Offset = "0x8D7B20", VA = "0x1808D8920")]
	public static void CallSaveReplayAPI(long did, int eid, [Optional] Action<PvPCode> onResult)
	{
	}

	[Token(Token = "0x60043CC")]
	[Address(RVA = "0x8D8A10", Offset = "0x8D7C10", VA = "0x1808D8A10")]
	public static void CloseAllDialogs()
	{
	}

	[Token(Token = "0x60043CD")]
	[Address(RVA = "0x8D89C0", Offset = "0x8D7BC0", VA = "0x1808D89C0")]
	[IteratorStateMachine(typeof(_003CCloseAllDialogsRoutine_003Ed__8))]
	private static IEnumerator CloseAllDialogsRoutine()
	{
		return null;
	}

	[Token(Token = "0x60043CE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RoomUtil()
	{
	}
}
