using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Network;

[Token(Token = "0x200027A")]
public class NetworkMain : MonoBehaviour
{
	[Token(Token = "0x200027B")]
	public class RequestStructure
	{
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x0")]
		private static int s_RequestIdCount;

		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] s_NullArray;

		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x28")]
		private int memId;

		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x30")]
		private string memCmd;

		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, object> memParam;

		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x40")]
		private RequestStructure memChain;

		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x48")]
		private bool memIsInnerChain;

		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x50")]
		private Queue<RequestStructure> refRequestQue;

		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x58")]
		public Handle handle;

		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x60")]
		public Status status;

		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x64")]
		public int code;

		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x68")]
		public float timeOut;

		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x6C")]
		public bool deckext;

		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x6D")]
		public bool abort;

		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x6E")]
		public bool finished;

		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x6F")]
		public bool nofatal;

		[Token(Token = "0x17000175")]
		public string Command
		{
			[Token(Token = "0x6000F03")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000176")]
		public Dictionary<string, object> Param
		{
			[Token(Token = "0x6000F04")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		public int Id
		{
			[Token(Token = "0x6000F05")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000178")]
		public RequestStructure Next
		{
			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		public bool IsInnerChain
		{
			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		public byte[] Body
		{
			[Token(Token = "0x6000F08")]
			[Address(RVA = "0xE73840", Offset = "0xE72A40", VA = "0x180E73840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000E")]
		public event EventHandler errorEvent
		{
			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0xE73700", Offset = "0xE72900", VA = "0x180E73700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0xE74160", Offset = "0xE73360", VA = "0x180E74160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event EventHandler completeEvent
		{
			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0xE73660", Offset = "0xE72860", VA = "0x180E73660")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0xE740C0", Offset = "0xE732C0", VA = "0x180E740C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event EventHandler retryEvent
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0xE737A0", Offset = "0xE729A0", VA = "0x180E737A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F01")]
			[Address(RVA = "0xE74200", Offset = "0xE73400", VA = "0x180E74200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000F02")]
		[Address(RVA = "0xE73530", Offset = "0xE72730", VA = "0x180E73530")]
		public RequestStructure(string command, Dictionary<string, object> param, Queue<RequestStructure> q)
		{
		}

		[Token(Token = "0x6000F09")]
		[Address(RVA = "0xE733D0", Offset = "0xE725D0", VA = "0x180E733D0")]
		public void Entry()
		{
		}

		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0xE73460", Offset = "0xE72660", VA = "0x180E73460")]
		public void Remove()
		{
		}

		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0xE732F0", Offset = "0xE724F0", VA = "0x180E732F0")]
		public void Chain(RequestStructure req)
		{
		}

		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0xE73390", Offset = "0xE72590", VA = "0x180E73390")]
		public void Complete()
		{
		}

		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0xE73420", Offset = "0xE72620", VA = "0x180E73420")]
		public void Error()
		{
		}

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0xE73480", Offset = "0xE72680", VA = "0x180E73480")]
		public void Retry()
		{
		}

		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0xE73340", Offset = "0xE72540", VA = "0x180E73340")]
		public void ClearAllEvent()
		{
		}
	}

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x0")]
	private static Queue<RequestStructure> s_refRequestQue;

	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x8")]
	private static List<RequestStructure> s_refExcList;

	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x10")]
	private static bool s_suspend;

	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x18")]
	private static string s_Version;

	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x20")]
	private static string s_Session;

	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x28")]
	private static string s_Lang;

	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x30")]
	private static string s_UserAgent;

	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x38")]
	private static float s_TouchSum;

	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x20")]
	private Protocol m_Protocol;

	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x28")]
	private Protocol m_ProtocolDeckExt;

	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x3C")]
	private static bool s_AbortPorotocol;

	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x40")]
	private static Action s_ShutdownCallback;

	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x48")]
	private static Action<Action> s_disconnectAction;

	[Token(Token = "0x1700016F")]
	public static NetworkReachability Reachability
	{
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380")]
		get
		{
			return default(NetworkReachability);
		}
	}

	[Token(Token = "0x17000170")]
	public static string Version
	{
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0xE71B70", Offset = "0xE70D70", VA = "0x180E71B70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0xE71D70", Offset = "0xE70F70", VA = "0x180E71D70")]
		set
		{
		}
	}

	[Token(Token = "0x17000171")]
	public static string Session
	{
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0xE71A80", Offset = "0xE70C80", VA = "0x180E71A80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0xE71C30", Offset = "0xE70E30", VA = "0x180E71C30")]
		set
		{
		}
	}

	[Token(Token = "0x17000172")]
	public static string Lang
	{
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0xE71A30", Offset = "0xE70C30", VA = "0x180E71A30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0xE71BC0", Offset = "0xE70DC0", VA = "0x180E71BC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000173")]
	public static string UserAgent
	{
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0xE71B20", Offset = "0xE70D20", VA = "0x180E71B20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0xE71D00", Offset = "0xE70F00", VA = "0x180E71D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000174")]
	public static float TouchSum
	{
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0xE71AD0", Offset = "0xE70CD0", VA = "0x180E71AD0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0xE71CA0", Offset = "0xE70EA0", VA = "0x180E71CA0")]
		set
		{
		}
	}

	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0xE70AD0", Offset = "0xE6FCD0", VA = "0x180E70AD0")]
	public static void RequestShutdown(Action callback)
	{
	}

	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0xE70280", Offset = "0xE6F480", VA = "0x180E70280")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0xE70D70", Offset = "0xE6FF70", VA = "0x180E70D70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0xE70E10", Offset = "0xE70010", VA = "0x180E70E10")]
	private void Update()
	{
	}

	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0xE70530", Offset = "0xE6F730", VA = "0x180E70530")]
	public static Handle Entry(string cmd, Dictionary<string, object> param, float timeout)
	{
		return null;
	}

	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0xE70900", Offset = "0xE6FB00", VA = "0x180E70900")]
	private void IEnumRequest(RequestStructure data)
	{
	}

	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0xE70A30", Offset = "0xE6FC30", VA = "0x180E70A30")]
	private void IPvPEnumRequest(PvP.Event val)
	{
	}

	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0xE70D00", Offset = "0xE6FF00", VA = "0x180E70D00")]
	public static void SetDisconnectAction(Action<Action> action)
	{
	}

	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0xE70B50", Offset = "0xE6FD50", VA = "0x180E70B50")]
	public static void ResetRequest()
	{
	}

	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public NetworkMain()
	{
	}
}
