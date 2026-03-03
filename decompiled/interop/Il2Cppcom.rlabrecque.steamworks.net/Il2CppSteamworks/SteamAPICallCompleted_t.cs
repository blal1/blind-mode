using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct SteamAPICallCompleted_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_hAsyncCall;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_iCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cubParam;

	[FieldOffset(0)]
	public SteamAPICall_t m_hAsyncCall;

	[FieldOffset(8)]
	public int m_iCallback;

	[FieldOffset(12)]
	public uint m_cubParam;

	static SteamAPICallCompleted_t()
	{
		Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamAPICallCompleted_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_hAsyncCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_hAsyncCall");
		NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_iCallback");
		NativeFieldInfoPtr_m_cubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_cubParam");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
