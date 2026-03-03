using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Utilities;

public static class ExceptionHelpers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsExceptionIndicatingBugInCode_Public_Static_Boolean_Exception_0;

	static ExceptionHelpers()
	{
		Il2CppClassPointerStore<ExceptionHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "ExceptionHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_IsExceptionIndicatingBugInCode_Public_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelpers>.NativeClassPtr, 100668686);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016571, RefRangeEnd = 1016572, XrefRangeStart = 1016567, XrefRangeEnd = 1016571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsExceptionIndicatingBugInCode(this Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExceptionIndicatingBugInCode_Public_Static_Boolean_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ExceptionHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
