using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct SteamServerConnectFailure_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_eResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bStillRetrying;

	[FieldOffset(0)]
	public EResult m_eResult;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_bStillRetrying;

	static SteamServerConnectFailure_t()
	{
		Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamServerConnectFailure_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "m_eResult");
		NativeFieldInfoPtr_m_bStillRetrying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "m_bStillRetrying");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
