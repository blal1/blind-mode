using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct SteamServersDisconnected_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_eResult;

	[FieldOffset(0)]
	public EResult m_eResult;

	static SteamServersDisconnected_t()
	{
		Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamServersDisconnected_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "m_eResult");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
