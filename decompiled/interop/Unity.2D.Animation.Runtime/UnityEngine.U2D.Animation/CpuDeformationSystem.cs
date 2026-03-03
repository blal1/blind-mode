using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Jobs;

namespace UnityEngine.U2D.Animation;

public class CpuDeformationSystem : BaseDeformationSystem
{
	private static readonly IntPtr NativeFieldInfoPtr_k_GpuSkinningShaderKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_m_BoundJobHandle;

	private static readonly IntPtr NativeFieldInfoPtr_m_CopyJobHandle;

	private static readonly IntPtr NativeMethodInfoPtr_get_deformationMethod_Public_Virtual_get_DeformationMethods_0;

	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_Void_SpriteSkin_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResizeBuffers_Private_Void_Int32_byref_PerSkinJobData_0;

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

	public unsafe JobHandle m_BoundJobHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundJobHandle);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundJobHandle)) = value;
		}
	}

	public unsafe JobHandle m_CopyJobHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyJobHandle);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyJobHandle)) = value;
		}
	}

	public unsafe override DeformationMethods deformationMethod
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static CpuDeformationSystem()
	{
		Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "CpuDeformationSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr);
		NativeFieldInfoPtr_k_GpuSkinningShaderKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, "k_GpuSkinningShaderKeyword");
		NativeFieldInfoPtr_m_BoundJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, "m_BoundJobHandle");
		NativeFieldInfoPtr_m_CopyJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, "m_CopyJobHandle");
		NativeMethodInfoPtr_get_deformationMethod_Public_Virtual_get_DeformationMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_Cleanup_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_Update_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_ResizeBuffers_Private_Void_Int32_byref_PerSkinJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr, 100663332);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954162, XrefRangeEnd = 954165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Cleanup_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954165, XrefRangeEnd = 954171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954171, XrefRangeEnd = 954220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Update_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954220, XrefRangeEnd = 954232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954232, XrefRangeEnd = 954233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CpuDeformationSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CpuDeformationSystem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CpuDeformationSystem(IntPtr pointer)
		: base(pointer)
	{
	}
}
