using System.Text;
using AOT;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

[Token(Token = "0x20000A4")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x0")]
	protected static bool s_EverInitialized;

	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x8")]
	protected static SteamManager s_instance;

	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x20")]
	protected bool m_bInitialized;

	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x28")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	[Token(Token = "0x1700004A")]
	protected static SteamManager Instance
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x6819F0", Offset = "0x680BF0", VA = "0x1806819F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004B")]
	public static bool Initialized
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x681900", Offset = "0x680B00", VA = "0x180681900")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x6816B0", Offset = "0x6808B0", VA = "0x1806816B0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitOnPlayMode()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x681470", Offset = "0x680670", VA = "0x180681470", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x6817E0", Offset = "0x6809E0", VA = "0x1806817E0", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x681720", Offset = "0x680920", VA = "0x180681720", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x6818F0", Offset = "0x680AF0", VA = "0x1806818F0", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SteamManager()
	{
	}
}
