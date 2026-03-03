using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct GetAuthSessionTicketResponse_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_hAuthTicket;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_eResult;

	[FieldOffset(0)]
	public HAuthTicket m_hAuthTicket;

	[FieldOffset(4)]
	public EResult m_eResult;

	static GetAuthSessionTicketResponse_t()
	{
		Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "GetAuthSessionTicketResponse_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_hAuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "m_hAuthTicket");
		NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "m_eResult");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
