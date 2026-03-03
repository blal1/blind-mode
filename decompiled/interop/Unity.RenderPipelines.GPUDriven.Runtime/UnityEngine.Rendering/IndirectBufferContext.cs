using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct IndirectBufferContext
{
	[OriginalName("Unity.RenderPipelines.GPUDriven.Runtime.dll", "", "BufferState")]
	public enum BufferState
	{
		Pending,
		Zeroed,
		NoOcclusionTest,
		AllInstancesOcclusionTested,
		OccludedInstancesReTested
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingJobHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferState;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_subviewMask;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_BufferState_Int32_Int32_0;

	[FieldOffset(0)]
	public JobHandle cullingJobHandle;

	[FieldOffset(16)]
	public BufferState bufferState;

	[FieldOffset(20)]
	public int occluderVersion;

	[FieldOffset(24)]
	public int subviewMask;

	static IndirectBufferContext()
	{
		Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectBufferContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr);
		NativeFieldInfoPtr_cullingJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, "cullingJobHandle");
		NativeFieldInfoPtr_bufferState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, "bufferState");
		NativeFieldInfoPtr_occluderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, "occluderVersion");
		NativeFieldInfoPtr_subviewMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, "subviewMask");
		NativeMethodInfoPtr__ctor_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_Matches_Public_Boolean_BufferState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, 100663897);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 831880, RefRangeEnd = 831892, XrefRangeStart = 831880, XrefRangeEnd = 831892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IndirectBufferContext(JobHandle cullingJobHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cullingJobHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_JobHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073661, RefRangeEnd = 1073662, XrefRangeStart = 1073661, XrefRangeEnd = 1073661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Matches(BufferState bufferState, int occluderVersion, int subviewMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&bufferState);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &occluderVersion;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &subviewMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Boolean_BufferState_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectBufferContext>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
