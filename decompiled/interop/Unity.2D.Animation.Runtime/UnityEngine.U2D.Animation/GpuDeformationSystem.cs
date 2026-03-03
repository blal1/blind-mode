using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.U2D.Animation;

public class GpuDeformationSystem : BaseDeformationSystem
{
	private static readonly IntPtr NativeFieldInfoPtr_k_GpuSkinningShaderKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_k_GlobalSpriteBoneBufferId;

	private static readonly IntPtr NativeFieldInfoPtr_m_KeywordEnabledMaterials;

	private static readonly IntPtr NativeFieldInfoPtr_m_BoneTransformBufferSizes;

	private static readonly IntPtr NativeFieldInfoPtr_m_BoneTransformsComputeBuffer;

	private static readonly IntPtr NativeFieldInfoPtr_s_FallbackBuffer;

	private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearFallbackBuffer_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_deformationMethod_Public_Virtual_get_DeformationMethods_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoesShaderSupportGpuDeformation_Internal_Static_Boolean_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsComputeBufferValid_Private_Static_Boolean_ComputeBuffer_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeArrays_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResizeAndCopyArrays_Protected_Virtual_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CleanupComputeResources_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_Void_SpriteSkin_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddSpriteSkin_Internal_Virtual_Boolean_SpriteSkin_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResizeBuffers_Private_Void_Int32_byref_PerSkinJobData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateComputeBuffer_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetComputeBuffer_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ScheduleCopySpriteRendererBoneTransformBuffersJob_Private_JobHandle_JobHandle_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string k_GpuSkinningShaderKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GpuSkinningShaderKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GpuSkinningShaderKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_GlobalSpriteBoneBufferId
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GlobalSpriteBoneBufferId, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GlobalSpriteBoneBufferId, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Dictionary<int, Material> m_KeywordEnabledMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KeywordEnabledMaterials);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KeywordEnabledMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<int> m_BoneTransformBufferSizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformBufferSizes);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformBufferSizes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ComputeBuffer m_BoneTransformsComputeBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformsComputeBuffer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformsComputeBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ComputeBuffer s_FallbackBuffer
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FallbackBuffer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FallbackBuffer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override DeformationMethods deformationMethod
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63528, RefRangeEnd = 63535, XrefRangeStart = 63528, XrefRangeEnd = 63535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_deformationMethod_Public_Virtual_get_DeformationMethods_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DeformationMethods*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GpuDeformationSystem()
	{
		Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "GpuDeformationSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr);
		NativeFieldInfoPtr_k_GpuSkinningShaderKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, "k_GpuSkinningShaderKeyword");
		NativeFieldInfoPtr_k_GlobalSpriteBoneBufferId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, "k_GlobalSpriteBoneBufferId");
		NativeFieldInfoPtr_m_KeywordEnabledMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, "m_KeywordEnabledMaterials");
		NativeFieldInfoPtr_m_BoneTransformBufferSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, "m_BoneTransformBufferSizes");
		NativeFieldInfoPtr_m_BoneTransformsComputeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, "m_BoneTransformsComputeBuffer");
		NativeFieldInfoPtr_s_FallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, "s_FallbackBuffer");
		NativeMethodInfoPtr_CreateFallbackBuffer_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_ClearFallbackBuffer_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_get_deformationMethod_Public_Virtual_get_DeformationMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_DoesShaderSupportGpuDeformation_Internal_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_IsComputeBufferValid_Private_Static_Boolean_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_InitializeArrays_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_Cleanup_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_ResizeAndCopyArrays_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_CleanupComputeResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_AddSpriteSkin_Internal_Virtual_Boolean_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_Update_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_ResizeBuffers_Private_Void_Int32_byref_PerSkinJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_CreateComputeBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_SetComputeBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_ScheduleCopySpriteRendererBoneTransformBuffersJob_Private_JobHandle_JobHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr, 100663378);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954529, XrefRangeEnd = 954543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateFallbackBuffer()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFallbackBuffer_Private_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954543, XrefRangeEnd = 954549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearFallbackBuffer()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFallbackBuffer_Private_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954549, XrefRangeEnd = 954564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DoesShaderSupportGpuDeformation(Material material)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoesShaderSupportGpuDeformation_Internal_Static_Boolean_Material_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsComputeBufferValid(ComputeBuffer buffer)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsComputeBufferValid_Private_Static_Boolean_ComputeBuffer_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954564, XrefRangeEnd = 954585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeArrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeArrays_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954585, XrefRangeEnd = 954599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Cleanup_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954599, XrefRangeEnd = 954624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResizeAndCopyArrays(int updatedCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&updatedCount);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResizeAndCopyArrays_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954655, RefRangeEnd = 954657, XrefRangeStart = 954624, XrefRangeEnd = 954655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupComputeResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupComputeResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954657, XrefRangeEnd = 954663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateMaterial(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_Void_SpriteSkin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954663, XrefRangeEnd = 954684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool AddSpriteSkin(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddSpriteSkin_Internal_Virtual_Boolean_SpriteSkin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954684, XrefRangeEnd = 954730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Update_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 954752, RefRangeEnd = 954753, XrefRangeStart = 954730, XrefRangeEnd = 954752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResizeBuffers(int vertexBufferSize, [In] ref PerSkinJobData skinBatch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&vertexBufferSize);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref skinBatch);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeBuffers_Private_Void_Int32_byref_PerSkinJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954753, XrefRangeEnd = 954763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateComputeBuffer(int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&bufferSize);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateComputeBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 954770, RefRangeEnd = 954773, XrefRangeStart = 954763, XrefRangeEnd = 954770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetComputeBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetComputeBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954773, XrefRangeEnd = 954780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleCopySpriteRendererBoneTransformBuffersJob(JobHandle jobHandle, int batchCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&jobHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &batchCount;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleCopySpriteRendererBoneTransformBuffersJob_Private_JobHandle_JobHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954780, XrefRangeEnd = 954788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GpuDeformationSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GpuDeformationSystem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GpuDeformationSystem(IntPtr pointer)
		: base(pointer)
	{
	}
}
