using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RangeKey
{
	private static readonly System.IntPtr NativeFieldInfoPtr_layer;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowCastingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticShadowCaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportsIndirect;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RangeKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public byte layer;

	[FieldOffset(4)]
	public uint renderingLayerMask;

	[FieldOffset(8)]
	public MotionVectorGenerationMode motionMode;

	[FieldOffset(12)]
	public ShadowCastingMode shadowCastingMode;

	[FieldOffset(16)]
	[MarshalAs(UnmanagedType.U1)]
	public bool staticShadowCaster;

	[FieldOffset(20)]
	public int rendererPriority;

	[FieldOffset(24)]
	[MarshalAs(UnmanagedType.U1)]
	public bool supportsIndirect;

	static RangeKey()
	{
		Il2CppClassPointerStore<RangeKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RangeKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeKey>.NativeClassPtr);
		NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "layer");
		NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "renderingLayerMask");
		NativeFieldInfoPtr_motionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "motionMode");
		NativeFieldInfoPtr_shadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "shadowCastingMode");
		NativeFieldInfoPtr_staticShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "staticShadowCaster");
		NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "rendererPriority");
		NativeFieldInfoPtr_supportsIndirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, "supportsIndirect");
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RangeKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, 100663542);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069263, RefRangeEnd = 1069264, XrefRangeStart = 1069263, XrefRangeEnd = 1069263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(RangeKey other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RangeKey_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangeKey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
