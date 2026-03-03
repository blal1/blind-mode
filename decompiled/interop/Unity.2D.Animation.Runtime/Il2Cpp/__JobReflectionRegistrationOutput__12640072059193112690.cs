using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class __JobReflectionRegistrationOutput__12640072059193112690 : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

	static __JobReflectionRegistrationOutput__12640072059193112690()
	{
		Il2CppClassPointerStore<__JobReflectionRegistrationOutput__12640072059193112690>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "", "__JobReflectionRegistrationOutput__12640072059193112690");
		NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__12640072059193112690>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__12640072059193112690>.NativeClassPtr, 100663771);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 958568, RefRangeEnd = 958569, XrefRangeStart = 958534, XrefRangeEnd = 958568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateJobReflectionData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958569, XrefRangeEnd = 958570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EarlyInit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public __JobReflectionRegistrationOutput__12640072059193112690(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
