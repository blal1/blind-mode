using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct ShadowSliceData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	[FieldOffset(0)]
	public Matrix4x4 viewMatrix;

	[FieldOffset(64)]
	public Matrix4x4 projectionMatrix;

	[FieldOffset(128)]
	public Matrix4x4 shadowTransform;

	[FieldOffset(192)]
	public int offsetX;

	[FieldOffset(196)]
	public int offsetY;

	[FieldOffset(200)]
	public int resolution;

	[FieldOffset(204)]
	public ShadowSplitData splitData;

	static ShadowSliceData()
	{
		Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowSliceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr);
		NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "viewMatrix");
		NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "projectionMatrix");
		NativeFieldInfoPtr_shadowTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "shadowTransform");
		NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "offsetX");
		NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "offsetY");
		NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "resolution");
		NativeFieldInfoPtr_splitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, "splitData");
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, 100665520);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099661, RefRangeEnd = 1099663, XrefRangeStart = 1099655, XrefRangeEnd = 1099661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSliceData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
