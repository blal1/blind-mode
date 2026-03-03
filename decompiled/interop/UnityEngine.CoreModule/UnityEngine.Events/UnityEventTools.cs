using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events;

public class UnityEventTools : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0;

	static UnityEventTools()
	{
		Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventTools");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr);
		NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100667105);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1222433, RefRangeEnd = 1222438, XrefRangeStart = 1222402, XrefRangeEnd = 1222433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TidyAssemblyTypeName(string assemblyTypeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyTypeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public UnityEventTools(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
