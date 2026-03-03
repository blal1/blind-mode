using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal;

public class DecalDrawErrorSystem : DecalDrawSystem
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Technique;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_DecalTechnique_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_DecalEntityChunk_0;

	public unsafe DecalTechnique m_Technique
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Technique);
			return *(DecalTechnique*)num;
		}
		set
		{
			*(DecalTechnique*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Technique)) = value;
		}
	}

	static DecalDrawErrorSystem()
	{
		Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawErrorSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr);
		NativeFieldInfoPtr_m_Technique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, "m_Technique");
		NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_DecalTechnique_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, 100663990);
		NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_DecalEntityChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr, 100663991);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081161, RefRangeEnd = 1081162, XrefRangeStart = 1081155, XrefRangeEnd = 1081161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalDrawErrorSystem(DecalEntityManager entityManager, DecalTechnique technique)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawErrorSystem>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager);
		*(DecalTechnique**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &technique;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_DecalTechnique_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalCachedChunk);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081162, XrefRangeEnd = 1081164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Material GetMaterial(DecalEntityChunk decalEntityChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalEntityChunk);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMaterial_Protected_Virtual_Material_DecalEntityChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	public DecalDrawErrorSystem(IntPtr pointer)
		: base(pointer)
	{
	}
}
