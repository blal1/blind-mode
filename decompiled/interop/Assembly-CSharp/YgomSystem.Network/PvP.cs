using System.Collections;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200027D")]
public class PvP
{
	[Token(Token = "0x200027E")]
	public enum Command
	{
		[Token(Token = "0x4000E32")]
		ENTRY = 0,
		[Token(Token = "0x4000E33")]
		INIT = 1,
		[Token(Token = "0x4000E34")]
		WAIT = 2,
		[Token(Token = "0x4000E35")]
		READY = 3,
		[Token(Token = "0x4000E36")]
		COMMAND = 4,
		[Token(Token = "0x4000E37")]
		EFFECT = 5,
		[Token(Token = "0x4000E38")]
		CANCEL = 6,
		[Token(Token = "0x4000E39")]
		RESULT = 7,
		[Token(Token = "0x4000E3A")]
		DBGCMD = 8,
		[Token(Token = "0x4000E3B")]
		CHEATCARD = 9,
		[Token(Token = "0x4000E3C")]
		CHAT = 10,
		[Token(Token = "0x4000E3D")]
		LIST = 11,
		[Token(Token = "0x4000E3E")]
		PHASE = 12,
		[Token(Token = "0x4000E3F")]
		SKILL = 13,
		[Token(Token = "0x4000E40")]
		LEAVE = 14,
		[Token(Token = "0x4000E41")]
		EXIT = 15,
		[Token(Token = "0x4000E42")]
		RECOVERY = 16,
		[Token(Token = "0x4000E43")]
		WATCH = 17,
		[Token(Token = "0x4000E44")]
		SURRENDER = 18,
		[Token(Token = "0x4000E45")]
		LATENCY = 19,
		[Token(Token = "0x4000E46")]
		SEND = 20,
		[Token(Token = "0x4000E47")]
		RECV = 21,
		[Token(Token = "0x4000E48")]
		TIME = 22,
		[Token(Token = "0x4000E49")]
		TURN = 23,
		[Token(Token = "0x4000E4A")]
		INPUTGUARD = 24,
		[Token(Token = "0x4000E4B")]
		DATA = 50,
		[Token(Token = "0x4000E4C")]
		REPLAY = 60,
		[Token(Token = "0x4000E4D")]
		FLIPINFO = 61,
		[Token(Token = "0x4000E4E")]
		TIMEUP = 97,
		[Token(Token = "0x4000E4F")]
		FINISH = 98,
		[Token(Token = "0x4000E50")]
		POLL = 99,
		[Token(Token = "0x4000E51")]
		ERROR = 100,
		[Token(Token = "0x4000E52")]
		FATAL = 900,
		[Token(Token = "0x4000E53")]
		CONNECT = 1000,
		[Token(Token = "0x4000E54")]
		RECONNECT = 1001,
		[Token(Token = "0x4000E55")]
		CLOSE = 1003,
		[Token(Token = "0x4000E56")]
		PING = 1004,
		[Token(Token = "0x4000E57")]
		PONG = 1005,
		[Token(Token = "0x4000E58")]
		MATCH = 1006,
		[Token(Token = "0x4000E59")]
		DROP = 1007,
		[Token(Token = "0x4000E5A")]
		MATCH_UPDATE = 1010,
		[Token(Token = "0x4000E5B")]
		MATCH_LIST = 1011,
		[Token(Token = "0x4000E5C")]
		INFO = 1012
	}

	[Token(Token = "0x200027F")]
	public class KeyDef
	{
		[Token(Token = "0x4000E5D")]
		public const string CMD = "c";

		[Token(Token = "0x4000E5E")]
		public const string BODY = "b";

		[Token(Token = "0x4000E5F")]
		public const string TICKET = "t";

		[Token(Token = "0x4000E60")]
		public const string TOKEN = "token";

		[Token(Token = "0x4000E61")]
		public const string SERIAL = "s";

		[Token(Token = "0x4000E62")]
		public const string USERAGENT = "ua";

		[Token(Token = "0x4000E63")]
		public const string DATA = "d";

		[Token(Token = "0x4000E64")]
		public const string ID = "id";

		[Token(Token = "0x4000E65")]
		public const string INFO = "in";

		[Token(Token = "0x4000E66")]
		public const string FROM = "f";

		[Token(Token = "0x4000E67")]
		public const string HOST = "h";

		[Token(Token = "0x4000E68")]
		public const string TIME = "tm";

		[Token(Token = "0x4000E69")]
		public const string COND = "cn";

		[Token(Token = "0x4000E6A")]
		public const string MODE = "m";

		[Token(Token = "0x4000E6B")]
		public const string PROF = "p";

		[Token(Token = "0x4000E6C")]
		public const string ERROR = "e";

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public KeyDef()
		{
		}
	}

	[Token(Token = "0x2000280")]
	public class Event
	{
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x10")]
		private Command memCmd;

		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x18")]
		private byte[] memBody;

		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x20")]
		private uint memSerial;

		[Token(Token = "0x1700017B")]
		public Command Cmd
		{
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(Command);
			}
		}

		[Token(Token = "0x1700017C")]
		public byte[] Body
		{
			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		public uint Serial
		{
			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0xE6E5C0", Offset = "0xE6D7C0", VA = "0x180E6E5C0")]
		public Event(Command cmd, byte[] body, uint serial = 0u)
		{
		}
	}

	[Token(Token = "0x2000281")]
	public abstract class Implement
	{
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x10")]
		public float waitTime;

		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x14")]
		public float retryTime;

		[Token(Token = "0x6000F2F")]
		public abstract void Connect(string url, string ticket, int port);

		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "5")]
		public virtual bool IsQue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "6")]
		public virtual bool IsPoll()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "7")]
		public virtual bool IsEntried()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F33")]
		public abstract Event Dequeue();

		[Token(Token = "0x6000F34")]
		public abstract IEnumerator Exec(Event val);

		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000F36")]
		public abstract int GetConnectionID();

		[Token(Token = "0x6000F37")]
		public abstract int[] GetMembers();

		[Token(Token = "0x6000F38")]
		public abstract void Send(Command cmd, byte[] bin, uint serial);

		[Token(Token = "0x6000F39")]
		public abstract void Send(Event ev);

		[Token(Token = "0x6000F3A")]
		public abstract Event Recv();

		[Token(Token = "0x6000F3B")]
		public abstract void AddCompleteHandler(EventHandler handler);

		[Token(Token = "0x6000F3C")]
		public abstract void AddErrorHandler(EventHandler handler);

		[Token(Token = "0x6000F3D")]
		public abstract void AddFatalHandler(EventHandler handler);

		[Token(Token = "0x6000F3E")]
		public abstract void AddRecvHandler(EventHandler handler);

		[Token(Token = "0x6000F3F")]
		public abstract void RemoveRecvHandler(EventHandler handler);

		[Token(Token = "0x6000F40")]
		public abstract void ClearHandler();

		[Token(Token = "0x6000F41")]
		public abstract void SetPollingData(byte[] data);

		[Token(Token = "0x6000F42")]
		public abstract void ApplicationQuitAbort();

		[Token(Token = "0x6000F43")]
		public abstract int GetJobCount();

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0xE6F510", Offset = "0xE6E710", VA = "0x180E6F510")]
		protected Implement()
		{
		}
	}

	[Token(Token = "0x2000282")]
	public delegate void EventHandler(Event val, int code = 0);

	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x0")]
	private static Implement s_refPvP;

	[Token(Token = "0x6000F14")]
	[Address(RVA = "0xE728C0", Offset = "0xE71AC0", VA = "0x180E728C0")]
	public static void Connect(string url, string ticket, int port = 80)
	{
	}

	[Token(Token = "0x6000F15")]
	[Address(RVA = "0xE73120", Offset = "0xE72320", VA = "0x180E73120")]
	public static void SetTime(float waitTime, float retryTime)
	{
	}

	[Token(Token = "0x6000F16")]
	[Address(RVA = "0xE72F80", Offset = "0xE72180", VA = "0x180E72F80")]
	public static void Send(Command cmd, byte[] bin, uint serial)
	{
	}

	[Token(Token = "0x6000F17")]
	[Address(RVA = "0xE73020", Offset = "0xE72220", VA = "0x180E73020")]
	public static void Send(Event ev)
	{
	}

	[Token(Token = "0x6000F18")]
	[Address(RVA = "0xE72E80", Offset = "0xE72080", VA = "0x180E72E80")]
	public static Event Recv()
	{
		return null;
	}

	[Token(Token = "0x6000F19")]
	[Address(RVA = "0xE727F0", Offset = "0xE719F0", VA = "0x180E727F0")]
	public static void Close()
	{
	}

	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0xE72CC0", Offset = "0xE71EC0", VA = "0x180E72CC0")]
	public static bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0xE72E00", Offset = "0xE72000", VA = "0x180E72E00")]
	public static bool IsQue()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0xE72D80", Offset = "0xE71F80", VA = "0x180E72D80")]
	public static bool IsPoll()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0xE72D00", Offset = "0xE71F00", VA = "0x180E72D00")]
	public static bool IsEntried()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0xE72B40", Offset = "0xE71D40", VA = "0x180E72B40")]
	public static Event Dequeue()
	{
		return null;
	}

	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0xE72BC0", Offset = "0xE71DC0", VA = "0x180E72BC0")]
	public static IEnumerator Exec(Event val)
	{
		return null;
	}

	[Token(Token = "0x6000F20")]
	[Address(RVA = "0xE72510", Offset = "0xE71710", VA = "0x180E72510")]
	public static void AddCompleteHandler(EventHandler handler)
	{
	}

	[Token(Token = "0x6000F21")]
	[Address(RVA = "0xE72590", Offset = "0xE71790", VA = "0x180E72590")]
	public static void AddErrorHandler(EventHandler handler)
	{
	}

	[Token(Token = "0x6000F22")]
	[Address(RVA = "0xE72610", Offset = "0xE71810", VA = "0x180E72610")]
	public static void AddFatalHandler(EventHandler handler)
	{
	}

	[Token(Token = "0x6000F23")]
	[Address(RVA = "0xE72690", Offset = "0xE71890", VA = "0x180E72690")]
	public static void AddRecvHandler(EventHandler handler)
	{
	}

	[Token(Token = "0x6000F24")]
	[Address(RVA = "0xE72F00", Offset = "0xE72100", VA = "0x180E72F00")]
	public static void RemoveRecvHandler(EventHandler handler)
	{
	}

	[Token(Token = "0x6000F25")]
	[Address(RVA = "0xE72780", Offset = "0xE71980", VA = "0x180E72780")]
	public static void ClearHandler()
	{
	}

	[Token(Token = "0x6000F26")]
	[Address(RVA = "0xE730A0", Offset = "0xE722A0", VA = "0x180E730A0")]
	public static void SetPollingData(byte[] data)
	{
	}

	[Token(Token = "0x6000F27")]
	[Address(RVA = "0xE72710", Offset = "0xE71910", VA = "0x180E72710")]
	public static void ApplicationQuitAbort()
	{
	}

	[Token(Token = "0x6000F28")]
	[Address(RVA = "0xE72C40", Offset = "0xE71E40", VA = "0x180E72C40")]
	public static int GetJobCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PvP()
	{
	}
}
