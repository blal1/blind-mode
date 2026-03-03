using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class __JobReflectionRegistrationOutput__15867191014387474753 : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

	static __JobReflectionRegistrationOutput__15867191014387474753()
	{
		Il2CppClassPointerStore<__JobReflectionRegistrationOutput__15867191014387474753>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "", "__JobReflectionRegistrationOutput__15867191014387474753");
		NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__15867191014387474753>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__15867191014387474753>.NativeClassPtr, 100664081);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075743, RefRangeEnd = 1075744, XrefRangeStart = 1075625, XrefRangeEnd = 1075743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateJobReflectionData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075744, XrefRangeEnd = 1075751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EarlyInit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public __JobReflectionRegistrationOutput__15867191014387474753(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
