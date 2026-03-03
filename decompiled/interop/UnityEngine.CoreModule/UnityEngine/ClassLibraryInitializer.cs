using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class ClassLibraryInitializer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

	static ClassLibraryInitializer()
	{
		Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ClassLibraryInitializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr);
		NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100666232);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187314, XrefRangeEnd = 1187315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ClassLibraryInitializer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void InitAssemblyRedirections()
	{
	}
}
