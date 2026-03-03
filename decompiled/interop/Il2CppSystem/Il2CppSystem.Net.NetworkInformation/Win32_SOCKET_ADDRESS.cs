using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

[StructLayout(LayoutKind.Explicit)]
public struct Win32_SOCKET_ADDRESS
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Sockaddr;

	private static readonly System.IntPtr NativeFieldInfoPtr_SockaddrLength;

	[FieldOffset(0)]
	public System.IntPtr Sockaddr;

	[FieldOffset(8)]
	public int SockaddrLength;

	static Win32_SOCKET_ADDRESS()
	{
		Il2CppClassPointerStore<Win32_SOCKET_ADDRESS>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_SOCKET_ADDRESS");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_SOCKET_ADDRESS>.NativeClassPtr);
		NativeFieldInfoPtr_Sockaddr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_SOCKET_ADDRESS>.NativeClassPtr, "Sockaddr");
		NativeFieldInfoPtr_SockaddrLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_SOCKET_ADDRESS>.NativeClassPtr, "SockaddrLength");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_SOCKET_ADDRESS>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
