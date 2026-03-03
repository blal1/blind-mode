using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class MetalPatchShaderComputeBufferAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateMetalPatchShaderComputeBufferAnalytic_Internal_Static_MetalPatchShaderComputeBufferAnalytic_0;

	static MetalPatchShaderComputeBufferAnalytic()
	{
		Il2CppClassPointerStore<MetalPatchShaderComputeBufferAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "MetalPatchShaderComputeBufferAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetalPatchShaderComputeBufferAnalytic>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetalPatchShaderComputeBufferAnalytic>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_CreateMetalPatchShaderComputeBufferAnalytic_Internal_Static_MetalPatchShaderComputeBufferAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetalPatchShaderComputeBufferAnalytic>.NativeClassPtr, 100663324);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407728, XrefRangeEnd = 1407733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MetalPatchShaderComputeBufferAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetalPatchShaderComputeBufferAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407733, XrefRangeEnd = 1407741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMetalPatchShaderComputeBufferAnalytic_Internal_Static_MetalPatchShaderComputeBufferAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MetalPatchShaderComputeBufferAnalytic>(intPtr2) : null;
	}

	public MetalPatchShaderComputeBufferAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
