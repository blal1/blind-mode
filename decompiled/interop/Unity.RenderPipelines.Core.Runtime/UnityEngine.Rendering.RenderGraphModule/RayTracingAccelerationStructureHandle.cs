using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct RayTracingAccelerationStructureHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_NullHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nullHandle_Public_Static_get_RayTracingAccelerationStructureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RayTracingAccelerationStructure_RayTracingAccelerationStructureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	[FieldOffset(0)]
	public ResourceHandle handle;

	public unsafe static RayTracingAccelerationStructureHandle s_NullHandle
	{
		get
		{
			Unsafe.SkipInit(out RayTracingAccelerationStructureHandle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NullHandle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NullHandle, (void*)(&value));
		}
	}

	public unsafe static RayTracingAccelerationStructureHandle nullHandle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059216, XrefRangeEnd = 1059220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nullHandle_Public_Static_get_RayTracingAccelerationStructureHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RayTracingAccelerationStructureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RayTracingAccelerationStructureHandle()
	{
		Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RayTracingAccelerationStructureHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr);
		NativeFieldInfoPtr_s_NullHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, "s_NullHandle");
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, "handle");
		NativeMethodInfoPtr_get_nullHandle_Public_Static_get_RayTracingAccelerationStructureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, 100667513);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, 100667514);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RayTracingAccelerationStructure_RayTracingAccelerationStructureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, 100667515);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, 100667516);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1059225, RefRangeEnd = 1059226, XrefRangeStart = 1059220, XrefRangeEnd = 1059225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayTracingAccelerationStructureHandle(int handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059226, XrefRangeEnd = 1059255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RayTracingAccelerationStructure(RayTracingAccelerationStructureHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RayTracingAccelerationStructure_RayTracingAccelerationStructureHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RayTracingAccelerationStructure>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1059255, XrefRangeEnd = 1059259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayTracingAccelerationStructureHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
