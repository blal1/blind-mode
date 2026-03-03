using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct IndirectBufferContextHandles
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceInfoBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_argsBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInfoBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseForOcclusionTest_Public_Void_IBaseRenderGraphBuilder_0;

	[FieldOffset(0)]
	public BufferHandle instanceBuffer;

	[FieldOffset(12)]
	public BufferHandle instanceInfoBuffer;

	[FieldOffset(24)]
	public BufferHandle argsBuffer;

	[FieldOffset(36)]
	public BufferHandle drawInfoBuffer;

	static IndirectBufferContextHandles()
	{
		Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectBufferContextHandles");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr);
		NativeFieldInfoPtr_instanceBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr, "instanceBuffer");
		NativeFieldInfoPtr_instanceInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr, "instanceInfoBuffer");
		NativeFieldInfoPtr_argsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr, "argsBuffer");
		NativeFieldInfoPtr_drawInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr, "drawInfoBuffer");
		NativeMethodInfoPtr_UseForOcclusionTest_Public_Void_IBaseRenderGraphBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr, 100663912);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073822, RefRangeEnd = 1073823, XrefRangeStart = 1073813, XrefRangeEnd = 1073822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseForOcclusionTest(IBaseRenderGraphBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseForOcclusionTest_Public_Void_IBaseRenderGraphBuilder_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectBufferContextHandles>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
