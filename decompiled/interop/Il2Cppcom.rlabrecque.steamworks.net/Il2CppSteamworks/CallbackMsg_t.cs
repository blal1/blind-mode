using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct CallbackMsg_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_hSteamUser;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_iCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pubParam;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cubParam;

	[FieldOffset(0)]
	public int m_hSteamUser;

	[FieldOffset(4)]
	public int m_iCallback;

	[FieldOffset(8)]
	public System.IntPtr m_pubParam;

	[FieldOffset(16)]
	public int m_cubParam;

	static CallbackMsg_t()
	{
		Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "CallbackMsg_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_hSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_hSteamUser");
		NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_iCallback");
		NativeFieldInfoPtr_m_pubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_pubParam");
		NativeFieldInfoPtr_m_cubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_cubParam");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
