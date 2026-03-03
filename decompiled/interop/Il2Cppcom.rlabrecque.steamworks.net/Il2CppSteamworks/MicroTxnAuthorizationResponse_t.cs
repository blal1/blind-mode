using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct MicroTxnAuthorizationResponse_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_unAppID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ulOrderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bAuthorized;

	[FieldOffset(0)]
	public uint m_unAppID;

	[FieldOffset(8)]
	public ulong m_ulOrderID;

	[FieldOffset(16)]
	public byte m_bAuthorized;

	static MicroTxnAuthorizationResponse_t()
	{
		Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "MicroTxnAuthorizationResponse_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_unAppID");
		NativeFieldInfoPtr_m_ulOrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_ulOrderID");
		NativeFieldInfoPtr_m_bAuthorized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_bAuthorized");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
