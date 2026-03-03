using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal;

public class UniversalRenderingData : ContextItem
{
	private static readonly IntPtr NativeFieldInfoPtr_m_CommandBuffer;

	private static readonly IntPtr NativeFieldInfoPtr_cullResults;

	private static readonly IntPtr NativeFieldInfoPtr_supportsDynamicBatching;

	private static readonly IntPtr NativeFieldInfoPtr_perObjectData;

	private static readonly IntPtr NativeFieldInfoPtr__renderingMode_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__opaqueLayerMask_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__transparentLayerMask_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_commandBuffer_Internal_get_CommandBuffer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_renderingMode_Internal_set_Void_RenderingMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_opaqueLayerMask_Internal_set_Void_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_transparentLayerMask_Internal_set_Void_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CommandBuffer m_CommandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommandBuffer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CullingResults cullResults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullResults);
			return *(CullingResults*)num;
		}
		set
		{
			*(CullingResults*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullResults)) = value;
		}
	}

	public unsafe bool supportsDynamicBatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsDynamicBatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsDynamicBatching)) = value;
		}
	}

	public unsafe PerObjectData perObjectData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectData);
			return *(PerObjectData*)num;
		}
		set
		{
			*(PerObjectData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectData)) = value;
		}
	}

	public unsafe RenderingMode _renderingMode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderingMode_k__BackingField);
			return *(RenderingMode*)num;
		}
		set
		{
			*(RenderingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderingMode_k__BackingField)) = value;
		}
	}

	public unsafe LayerMask _opaqueLayerMask_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opaqueLayerMask_k__BackingField);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opaqueLayerMask_k__BackingField)) = value;
		}
	}

	public unsafe LayerMask _transparentLayerMask_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transparentLayerMask_k__BackingField);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transparentLayerMask_k__BackingField)) = value;
		}
	}

	public unsafe CommandBuffer commandBuffer
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1087032, RefRangeEnd = 1087040, XrefRangeStart = 1087026, XrefRangeEnd = 1087032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_commandBuffer_Internal_get_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
		}
	}

	public unsafe RenderingMode renderingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243941, RefRangeEnd = 243942, XrefRangeStart = 243941, XrefRangeEnd = 243942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingMode_Internal_set_Void_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LayerMask opaqueLayerMask
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65293, RefRangeEnd = 65294, XrefRangeStart = 65293, XrefRangeEnd = 65294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_opaqueLayerMask_Internal_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LayerMask transparentLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202040, RefRangeEnd = 202045, XrefRangeStart = 202040, XrefRangeEnd = 202045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_transparentLayerMask_Internal_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static UniversalRenderingData()
	{
		Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr);
		NativeFieldInfoPtr_m_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "m_CommandBuffer");
		NativeFieldInfoPtr_cullResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "cullResults");
		NativeFieldInfoPtr_supportsDynamicBatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "supportsDynamicBatching");
		NativeFieldInfoPtr_perObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "perObjectData");
		NativeFieldInfoPtr__renderingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "<renderingMode>k__BackingField");
		NativeFieldInfoPtr__opaqueLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "<opaqueLayerMask>k__BackingField");
		NativeFieldInfoPtr__transparentLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, "<transparentLayerMask>k__BackingField");
		NativeMethodInfoPtr_get_commandBuffer_Internal_get_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_set_renderingMode_Internal_set_Void_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_set_opaqueLayerMask_Internal_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_set_transparentLayerMask_Internal_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664564);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr, 100664565);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087040, XrefRangeEnd = 1087043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalRenderingData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderingData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalRenderingData(IntPtr pointer)
		: base(pointer)
	{
	}
}
