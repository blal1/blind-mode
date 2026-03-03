using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchFilterSettings
{
	private delegate ulong DefaultCullingMaskDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sceneCullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_layer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_batchLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_motionMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_shadowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_receiveShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_staticShadowCaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_allDepthSorted;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isSceneCullingMaskSet;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_batchLayer_Public_set_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_motionMode_Public_set_Void_MotionVectorGenerationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_staticShadowCaster_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allDepthSorted_Public_set_Void_Boolean_0;

	[FieldOffset(0)]
	public uint renderingLayerMask;

	[FieldOffset(4)]
	public int rendererPriority;

	[FieldOffset(8)]
	public ulong m_sceneCullingMask;

	[FieldOffset(16)]
	public byte layer;

	[FieldOffset(17)]
	public byte m_batchLayer;

	[FieldOffset(18)]
	public byte m_motionMode;

	[FieldOffset(19)]
	public byte m_shadowMode;

	[FieldOffset(20)]
	public byte m_receiveShadows;

	[FieldOffset(21)]
	public byte m_staticShadowCaster;

	[FieldOffset(22)]
	public byte m_allDepthSorted;

	[FieldOffset(23)]
	public byte m_isSceneCullingMaskSet;

	private static readonly DefaultCullingMaskDelegate DefaultCullingMaskDelegateField;

	public unsafe byte batchLayer
	{
		get
		{
			return m_batchLayer;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_batchLayer_Public_set_Void_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MotionVectorGenerationMode motionMode
	{
		get
		{
			return (MotionVectorGenerationMode)m_motionMode;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237377, RefRangeEnd = 1237378, XrefRangeStart = 1237377, XrefRangeEnd = 1237377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionMode_Public_set_Void_MotionVectorGenerationMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ShadowCastingMode shadowCastingMode
	{
		get
		{
			return (ShadowCastingMode)m_shadowMode;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237378, RefRangeEnd = 1237379, XrefRangeStart = 1237378, XrefRangeEnd = 1237378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool receiveShadows
	{
		get
		{
			return m_receiveShadows != 0;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237379, RefRangeEnd = 1237380, XrefRangeStart = 1237379, XrefRangeEnd = 1237379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool staticShadowCaster
	{
		get
		{
			return m_staticShadowCaster != 0;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237380, RefRangeEnd = 1237381, XrefRangeStart = 1237380, XrefRangeEnd = 1237380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_staticShadowCaster_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool allDepthSorted
	{
		get
		{
			return m_allDepthSorted != 0;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237381, RefRangeEnd = 1237382, XrefRangeStart = 1237381, XrefRangeEnd = 1237381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allDepthSorted_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public ulong sceneCullingMask
	{
		get
		{
			return (m_isSceneCullingMaskSet != 0) ? m_sceneCullingMask : DefaultCullingMask();
		}
		set
		{
			m_isSceneCullingMaskSet = 1;
			m_sceneCullingMask = value;
		}
	}

	static BatchFilterSettings()
	{
		Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchFilterSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr);
		NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "renderingLayerMask");
		NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "rendererPriority");
		NativeFieldInfoPtr_m_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_sceneCullingMask");
		NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "layer");
		NativeFieldInfoPtr_m_batchLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_batchLayer");
		NativeFieldInfoPtr_m_motionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_motionMode");
		NativeFieldInfoPtr_m_shadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_shadowMode");
		NativeFieldInfoPtr_m_receiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_receiveShadows");
		NativeFieldInfoPtr_m_staticShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_staticShadowCaster");
		NativeFieldInfoPtr_m_allDepthSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_allDepthSorted");
		NativeFieldInfoPtr_m_isSceneCullingMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_isSceneCullingMaskSet");
		NativeMethodInfoPtr_set_batchLayer_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, 100668316);
		NativeMethodInfoPtr_set_motionMode_Public_set_Void_MotionVectorGenerationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, 100668317);
		NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, 100668318);
		NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, 100668319);
		NativeMethodInfoPtr_set_staticShadowCaster_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, 100668320);
		NativeMethodInfoPtr_set_allDepthSorted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, 100668321);
		DefaultCullingMaskDelegateField = IL2CPP.ResolveICall<DefaultCullingMaskDelegate>("UnityEngine.Rendering.BatchFilterSettings::DefaultCullingMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static ulong DefaultCullingMask()
	{
		return DefaultCullingMaskDelegateField();
	}
}
