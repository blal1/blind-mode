using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public class GPUDrivenProcessor : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GPUDrivenProcessor_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GPUDrivenProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100668388);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(GPUDrivenProcessor obj)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GPUDrivenProcessor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.GPUDrivenProcessor+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__34_0_Internal_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__34_1_Internal_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668390);
			NativeMethodInfoPtr___cctor_b__34_0_Internal_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668391);
			NativeMethodInfoPtr___cctor_b__34_1_Internal_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668392);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237504, XrefRangeEnd = 1237570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__34_0([In] ref GPUDrivenRendererGroupDataNative nativeData, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)Unsafe.AsPointer(ref nativeData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__34_0_Internal_Void_byref_GPUDrivenRendererGroupDataNative_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237570, XrefRangeEnd = 1237603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__34_1([In] ref GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref nativeData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__34_1_Internal_Void_byref_GPUDrivenLODGroupDataNative_GPUDrivenLODGroupDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	private delegate bool get_enablePartialRendering_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_enableMaterialFilters_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_enableMaterialFilters_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetMaterialFilterFlags_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr__scratchMeshes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__scratchMaterials_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_NativeRendererCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_NativeLODGroupCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scratchMeshes_Internal_get_List_1_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scratchMeshes_Private_set_Void_List_1_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scratchMaterials_Internal_get_List_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scratchMaterials_Private_set_Void_List_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Private_Void_ReadOnlySpan_1_Int32_GPUDrivenRendererDataNativeCallback_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Public_Void_ReadOnlySpan_1_Int32_GPUDrivenRendererDataCallback_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableGPUDrivenRendering_Public_Void_ReadOnlySpan_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchLODGroupData_Private_Void_ReadOnlySpan_1_Int32_GPUDrivenLODGroupDataNativeCallback_GPUDrivenLODGroupDataCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchLODGroupData_Public_Void_ReadOnlySpan_1_Int32_GPUDrivenLODGroupDataCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enablePartialRendering_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMaterialFilters_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyMaterialsImpl_Private_Static_Int32_ReadOnlySpan_1_Int32_Span_1_Int32_Span_1_Int32_Span_1_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyMaterials_Public_Static_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_GPUDrivenRendererDataNativeCallback_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableGPUDrivenRendering_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchLODGroupData_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_GPUDrivenLODGroupDataNativeCallback_GPUDrivenLODGroupDataCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enablePartialRendering_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMaterialFilters_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyMaterialsImpl_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly get_enablePartialRendering_InjectedDelegate get_enablePartialRendering_InjectedDelegateField;

	private static readonly set_enableMaterialFilters_InjectedDelegate set_enableMaterialFilters_InjectedDelegateField;

	private static readonly get_enableMaterialFilters_InjectedDelegate get_enableMaterialFilters_InjectedDelegateField;

	private static readonly GetMaterialFilterFlags_InjectedDelegate GetMaterialFilterFlags_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe List<Mesh> _scratchMeshes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchMeshes_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Mesh>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchMeshes_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<Material> _scratchMaterials_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchMaterials_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchMaterials_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NativeRendererCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenRendererDataNativeCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NativeRendererCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NativeLODGroupCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenLODGroupDataNativeCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NativeLODGroupCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<Mesh> scratchMeshes
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scratchMeshes_Internal_get_List_1_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Mesh>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scratchMeshes_Private_set_Void_List_1_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<Material> scratchMaterials
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scratchMaterials_Internal_get_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scratchMaterials_Private_set_Void_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enablePartialRendering
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enablePartialRendering_Injected(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237756, RefRangeEnd = 1237758, XrefRangeStart = 1237749, XrefRangeEnd = 1237756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enablePartialRendering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool enableMaterialFilters
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableMaterialFilters_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableMaterialFilters_Injected(intPtr, value);
		}
	}

	static GPUDrivenProcessor()
	{
		Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenProcessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr__scratchMeshes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "<scratchMeshes>k__BackingField");
		NativeFieldInfoPtr__scratchMaterials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "<scratchMaterials>k__BackingField");
		NativeFieldInfoPtr_s_NativeRendererCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "s_NativeRendererCallback");
		NativeFieldInfoPtr_s_NativeLODGroupCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, "s_NativeLODGroupCallback");
		NativeMethodInfoPtr_get_scratchMeshes_Internal_get_List_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668362);
		NativeMethodInfoPtr_set_scratchMeshes_Private_set_Void_List_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668363);
		NativeMethodInfoPtr_get_scratchMaterials_Internal_get_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668364);
		NativeMethodInfoPtr_set_scratchMaterials_Private_set_Void_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668365);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668366);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668367);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668368);
		NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668369);
		NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668370);
		NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668371);
		NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Private_Void_ReadOnlySpan_1_Int32_GPUDrivenRendererDataNativeCallback_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668372);
		NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Public_Void_ReadOnlySpan_1_Int32_GPUDrivenRendererDataCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668373);
		NativeMethodInfoPtr_DisableGPUDrivenRendering_Public_Void_ReadOnlySpan_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668374);
		NativeMethodInfoPtr_DispatchLODGroupData_Private_Void_ReadOnlySpan_1_Int32_GPUDrivenLODGroupDataNativeCallback_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668375);
		NativeMethodInfoPtr_DispatchLODGroupData_Public_Void_ReadOnlySpan_1_Int32_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668376);
		NativeMethodInfoPtr_set_enablePartialRendering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668377);
		NativeMethodInfoPtr_ClearMaterialFilters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668378);
		NativeMethodInfoPtr_ClassifyMaterialsImpl_Private_Static_Int32_ReadOnlySpan_1_Int32_Span_1_Int32_Span_1_Int32_Span_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668379);
		NativeMethodInfoPtr_ClassifyMaterials_Public_Static_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668380);
		NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_GPUDrivenRendererDataNativeCallback_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668382);
		NativeMethodInfoPtr_DisableGPUDrivenRendering_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668383);
		NativeMethodInfoPtr_DispatchLODGroupData_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_GPUDrivenLODGroupDataNativeCallback_GPUDrivenLODGroupDataCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668384);
		NativeMethodInfoPtr_set_enablePartialRendering_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668385);
		NativeMethodInfoPtr_ClearMaterialFilters_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668386);
		NativeMethodInfoPtr_ClassifyMaterialsImpl_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr, 100668387);
		get_enablePartialRendering_InjectedDelegateField = IL2CPP.ResolveICall<get_enablePartialRendering_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::get_enablePartialRendering_Injected");
		set_enableMaterialFilters_InjectedDelegateField = IL2CPP.ResolveICall<set_enableMaterialFilters_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::set_enableMaterialFilters_Injected");
		get_enableMaterialFilters_InjectedDelegateField = IL2CPP.ResolveICall<get_enableMaterialFilters_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::get_enableMaterialFilters_Injected");
		GetMaterialFilterFlags_InjectedDelegateField = IL2CPP.ResolveICall<GetMaterialFilterFlags_InjectedDelegate>("UnityEngine.Rendering.GPUDrivenProcessor::GetMaterialFilterFlags_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237623, RefRangeEnd = 1237624, XrefRangeStart = 1237603, XrefRangeEnd = 1237623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUDrivenProcessor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenProcessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237624, XrefRangeEnd = 1237628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237635, RefRangeEnd = 1237636, XrefRangeStart = 1237628, XrefRangeEnd = 1237635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237641, RefRangeEnd = 1237643, XrefRangeStart = 1237636, XrefRangeEnd = 1237641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237643, XrefRangeEnd = 1237645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237645, XrefRangeEnd = 1237676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237676, XrefRangeEnd = 1237687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableGPUDrivenRenderingAndDispatchRendererData(Il2CppSystem.ReadOnlySpan<int> renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialUpdateOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Private_Void_ReadOnlySpan_1_Int32_GPUDrivenRendererDataNativeCallback_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237706, RefRangeEnd = 1237707, XrefRangeStart = 1237687, XrefRangeEnd = 1237706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableGPUDrivenRenderingAndDispatchRendererData(Il2CppSystem.ReadOnlySpan<int> renderersID, GPUDrivenRendererDataCallback callback, bool materialUpdateOnly = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialUpdateOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Public_Void_ReadOnlySpan_1_Int32_GPUDrivenRendererDataCallback_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1237718, RefRangeEnd = 1237721, XrefRangeStart = 1237707, XrefRangeEnd = 1237718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableGPUDrivenRendering(Il2CppSystem.ReadOnlySpan<int> renderersID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableGPUDrivenRendering_Public_Void_ReadOnlySpan_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237721, XrefRangeEnd = 1237732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchLODGroupData(Il2CppSystem.ReadOnlySpan<int> lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchLODGroupData_Private_Void_ReadOnlySpan_1_Int32_GPUDrivenLODGroupDataNativeCallback_GPUDrivenLODGroupDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237747, RefRangeEnd = 1237749, XrefRangeStart = 1237732, XrefRangeEnd = 1237747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchLODGroupData(Il2CppSystem.ReadOnlySpan<int> lodGroupID, GPUDrivenLODGroupDataCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchLODGroupData_Public_Void_ReadOnlySpan_1_Int32_GPUDrivenLODGroupDataCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237765, RefRangeEnd = 1237767, XrefRangeStart = 1237758, XrefRangeEnd = 1237765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearMaterialFilters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMaterialFilters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237790, RefRangeEnd = 1237791, XrefRangeStart = 1237767, XrefRangeEnd = 1237790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ClassifyMaterialsImpl(Il2CppSystem.ReadOnlySpan<int> materialIDs, Il2CppSystem.Span<int> unsupportedMaterialIDs, Il2CppSystem.Span<int> supportedMaterialIDs, Il2CppSystem.Span<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedMaterialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedPackedMaterialDatas));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClassifyMaterialsImpl_Private_Static_Int32_ReadOnlySpan_1_Int32_Span_1_Int32_Span_1_Int32_Span_1_GPUDrivenPackedMaterialData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237806, RefRangeEnd = 1237808, XrefRangeStart = 1237791, XrefRangeEnd = 1237806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ClassifyMaterials(NativeArray<int> materialIDs, NativeArray<int> unsupportedMaterialIDs, NativeArray<int> supportedMaterialIDs, NativeArray<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedMaterialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedPackedMaterialDatas));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClassifyMaterials_Public_Static_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237808, XrefRangeEnd = 1237810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderersID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialUpdateOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableGPUDrivenRenderingAndDispatchRendererData_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_GPUDrivenRendererDataNativeCallback_List_1_Mesh_List_1_Material_GPUDrivenRendererDataCallback_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237810, XrefRangeEnd = 1237812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableGPUDrivenRendering_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper renderersID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderersID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableGPUDrivenRendering_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237812, XrefRangeEnd = 1237814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DispatchLODGroupData_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lodGroupID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchLODGroupData_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_GPUDrivenLODGroupDataNativeCallback_GPUDrivenLODGroupDataCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237814, XrefRangeEnd = 1237816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_enablePartialRendering_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enablePartialRendering_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237816, XrefRangeEnd = 1237818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearMaterialFilters_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMaterialFilters_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237818, XrefRangeEnd = 1237820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ClassifyMaterialsImpl_Injected(ref ManagedSpanWrapper materialIDs, ref ManagedSpanWrapper unsupportedMaterialIDs, ref ManagedSpanWrapper supportedMaterialIDs, ref ManagedSpanWrapper supportedPackedMaterialDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref materialIDs);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref unsupportedMaterialIDs);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref supportedMaterialIDs);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref supportedPackedMaterialDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClassifyMaterialsImpl_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GPUDrivenProcessor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public int GetMaterialFilterFlags(Material material)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetMaterialFilterFlags_Injected(intPtr, Object.MarshalledUnityObject.Marshal(material));
	}

	public static bool get_enablePartialRendering_Injected(System.IntPtr _unity_self)
	{
		return get_enablePartialRendering_InjectedDelegateField(_unity_self);
	}

	public static void set_enableMaterialFilters_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enableMaterialFilters_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableMaterialFilters_Injected(System.IntPtr _unity_self)
	{
		return get_enableMaterialFilters_InjectedDelegateField(_unity_self);
	}

	public static int GetMaterialFilterFlags_Injected(System.IntPtr _unity_self, System.IntPtr material)
	{
		return GetMaterialFilterFlags_InjectedDelegateField(_unity_self, material);
	}
}
