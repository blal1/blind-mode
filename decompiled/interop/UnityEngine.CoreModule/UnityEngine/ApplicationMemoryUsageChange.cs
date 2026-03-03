using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ApplicationMemoryUsageChange
{
	private static readonly System.IntPtr NativeFieldInfoPtr__memoryUsage_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0;

	[FieldOffset(0)]
	public ApplicationMemoryUsage _memoryUsage_k__BackingField;

	public unsafe ApplicationMemoryUsage memoryUsage
	{
		get
		{
			return _memoryUsage_k__BackingField;
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ApplicationMemoryUsageChange()
	{
		Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ApplicationMemoryUsageChange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr);
		NativeFieldInfoPtr__memoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, "<memoryUsage>k__BackingField");
		NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663866);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ApplicationMemoryUsageChange(ApplicationMemoryUsage usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&usage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
