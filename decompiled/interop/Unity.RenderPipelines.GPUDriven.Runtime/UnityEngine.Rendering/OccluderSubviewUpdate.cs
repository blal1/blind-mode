using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OccluderSubviewUpdate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_subviewIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthSliceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_invViewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_gpuProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewOffsetWorldSpace;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	[FieldOffset(0)]
	public int subviewIndex;

	[FieldOffset(4)]
	public int depthSliceIndex;

	[FieldOffset(8)]
	public Vector2Int depthOffset;

	[FieldOffset(16)]
	public Matrix4x4 viewMatrix;

	[FieldOffset(80)]
	public Matrix4x4 invViewMatrix;

	[FieldOffset(144)]
	public Matrix4x4 gpuProjMatrix;

	[FieldOffset(208)]
	public Vector3 viewOffsetWorldSpace;

	static OccluderSubviewUpdate()
	{
		Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OccluderSubviewUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_subviewIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "subviewIndex");
		NativeFieldInfoPtr_depthSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "depthSliceIndex");
		NativeFieldInfoPtr_depthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "depthOffset");
		NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "viewMatrix");
		NativeFieldInfoPtr_invViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "invViewMatrix");
		NativeFieldInfoPtr_gpuProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "gpuProjMatrix");
		NativeFieldInfoPtr_viewOffsetWorldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, "viewOffsetWorldSpace");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, 100663536);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069250, RefRangeEnd = 1069251, XrefRangeStart = 1069240, XrefRangeEnd = 1069250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OccluderSubviewUpdate(int subviewIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subviewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OccluderSubviewUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
