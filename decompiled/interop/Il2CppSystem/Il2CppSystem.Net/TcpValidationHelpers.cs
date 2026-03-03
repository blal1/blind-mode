using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net;

public static class TcpValidationHelpers : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ValidatePortNumber_Public_Static_Boolean_Int32_0;

	static TcpValidationHelpers()
	{
		Il2CppClassPointerStore<TcpValidationHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "TcpValidationHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TcpValidationHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_ValidatePortNumber_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpValidationHelpers>.NativeClassPtr, 100665845);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884962, RefRangeEnd = 884963, XrefRangeStart = 884962, XrefRangeEnd = 884962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ValidatePortNumber(int port)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&port);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidatePortNumber_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TcpValidationHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
