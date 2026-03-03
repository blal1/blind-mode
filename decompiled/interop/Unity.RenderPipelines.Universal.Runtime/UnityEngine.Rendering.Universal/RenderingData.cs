using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public sealed class RenderingData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameData;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightData;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowData;

	private static readonly System.IntPtr NativeFieldInfoPtr_postProcessingData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_universalRenderingData_Internal_get_UniversalRenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_commandBuffer_Internal_get_byref_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullResults_Public_get_byref_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsDynamicBatching_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_perObjectData_Public_get_byref_PerObjectData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_postProcessingEnabled_Public_get_byref_Boolean_0;

	public unsafe ContextContainer frameData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CameraData cameraData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData);
			return new CameraData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe LightData lightData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightData);
			return new LightData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LightData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ShadowData shadowData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowData);
			return new ShadowData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe PostProcessingData postProcessingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingData);
			return new PostProcessingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PostProcessingData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe UniversalRenderingData universalRenderingData
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106864, XrefRangeEnd = 1106868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_universalRenderingData_Internal_get_UniversalRenderingData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderingData>(intPtr2) : null;
		}
	}

	public unsafe ref CommandBuffer commandBuffer
	{
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1106877, RefRangeEnd = 1106934, XrefRangeStart = 1106868, XrefRangeEnd = 1106877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_commandBuffer_Internal_get_byref_CommandBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(CommandBuffer*)intPtr2;
		}
	}

	public unsafe ref CullingResults cullResults
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1106937, RefRangeEnd = 1106939, XrefRangeStart = 1106934, XrefRangeEnd = 1106937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullResults_Public_get_byref_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(CullingResults*)intPtr2;
		}
	}

	public unsafe ref bool supportsDynamicBatching
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106939, XrefRangeEnd = 1106942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsDynamicBatching_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref PerObjectData perObjectData
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106942, XrefRangeEnd = 1106945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_perObjectData_Public_get_byref_PerObjectData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(PerObjectData*)intPtr2;
		}
	}

	public unsafe ref bool postProcessingEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106945, XrefRangeEnd = 1106948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postProcessingEnabled_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	static RenderingData()
	{
		Il2CppClassPointerStore<RenderingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingData>.NativeClassPtr);
		NativeFieldInfoPtr_frameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "frameData");
		NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "cameraData");
		NativeFieldInfoPtr_lightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "lightData");
		NativeFieldInfoPtr_shadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "shadowData");
		NativeFieldInfoPtr_postProcessingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, "postProcessingData");
		NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665992);
		NativeMethodInfoPtr_get_universalRenderingData_Internal_get_UniversalRenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665993);
		NativeMethodInfoPtr_get_commandBuffer_Internal_get_byref_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665994);
		NativeMethodInfoPtr_get_cullResults_Public_get_byref_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665995);
		NativeMethodInfoPtr_get_supportsDynamicBatching_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665996);
		NativeMethodInfoPtr_get_perObjectData_Public_get_byref_PerObjectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665997);
		NativeMethodInfoPtr_get_postProcessingEnabled_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, 100665998);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106863, RefRangeEnd = 1106864, XrefRangeStart = 1106854, XrefRangeEnd = 1106863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderingData(ContextContainer frameData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderingData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderingData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RenderingData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderingData>.NativeClassPtr))
	{
	}
}
