using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct IndirectBufferAllocInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawAllocIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceAllocIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWithinLimits_Public_Boolean_byref_IndirectBufferLimits_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtraDrawInfoSlotIndex_Public_Int32_0;

	[FieldOffset(0)]
	public int drawAllocIndex;

	[FieldOffset(4)]
	public int drawCount;

	[FieldOffset(8)]
	public int instanceAllocIndex;

	[FieldOffset(12)]
	public int instanceCount;

	static IndirectBufferAllocInfo()
	{
		Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectBufferAllocInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr);
		NativeFieldInfoPtr_drawAllocIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, "drawAllocIndex");
		NativeFieldInfoPtr_drawCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, "drawCount");
		NativeFieldInfoPtr_instanceAllocIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, "instanceAllocIndex");
		NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, "instanceCount");
		NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_IsWithinLimits_Public_Boolean_byref_IndirectBufferLimits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_GetExtraDrawInfoSlotIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, 100663895);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1019790, RefRangeEnd = 1019796, XrefRangeStart = 1019790, XrefRangeEnd = 1019796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEmpty()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073659, RefRangeEnd = 1073660, XrefRangeStart = 1073659, XrefRangeEnd = 1073659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWithinLimits([In] ref IndirectBufferLimits limits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref limits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWithinLimits_Public_Boolean_byref_IndirectBufferLimits_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073660, RefRangeEnd = 1073661, XrefRangeStart = 1073660, XrefRangeEnd = 1073660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetExtraDrawInfoSlotIndex()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtraDrawInfoSlotIndex_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectBufferAllocInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
