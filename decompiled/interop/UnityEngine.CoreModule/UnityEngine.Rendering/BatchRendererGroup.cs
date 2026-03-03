using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public class BatchRendererGroup : Il2CppSystem.Object
{
	public sealed class OnPerformCulling : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0;

		static OnPerformCulling()
		{
			Il2CppClassPointerStore<OnPerformCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "OnPerformCulling");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPerformCulling>.NativeClassPtr, 100668347);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPerformCulling>.NativeClassPtr, 100668348);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237392, RefRangeEnd = 1237393, XrefRangeStart = 1237382, XrefRangeEnd = 1237392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnPerformCulling(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnPerformCulling>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, System.IntPtr userContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererGroup);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cullingContext));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cullingOutput));
			*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &userContext;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public OnPerformCulling(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnPerformCulling(System.Func<BatchRendererGroup, BatchCullingContext, BatchCullingOutput, System.IntPtr, JobHandle> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnPerformCulling>((System.Delegate)P_0);
		}

		public static OnPerformCulling operator +(OnPerformCulling P_0, OnPerformCulling P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnPerformCulling>();
		}

		public static OnPerformCulling operator -(OnPerformCulling P_0, OnPerformCulling P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnPerformCulling>();
			}
			return (OnPerformCulling)obj;
		}
	}

	public sealed class OnFinishedCulling : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

		static OnFinishedCulling()
		{
			Il2CppClassPointerStore<OnFinishedCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "OnFinishedCulling");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFinishedCulling>.NativeClassPtr, 100668349);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFinishedCulling>.NativeClassPtr, 100668350);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 770479, RefRangeEnd = 770486, XrefRangeStart = 770479, XrefRangeEnd = 770486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnFinishedCulling(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnFinishedCulling>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(System.IntPtr customCullingResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&customCullingResult);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnFinishedCulling(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnFinishedCulling(System.Action<System.IntPtr> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnFinishedCulling>((System.Delegate)P_0);
		}

		public static OnFinishedCulling operator +(OnFinishedCulling P_0, OnFinishedCulling P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnFinishedCulling>();
		}

		public static OnFinishedCulling operator -(OnFinishedCulling P_0, OnFinishedCulling P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnFinishedCulling>();
			}
			return (OnFinishedCulling)obj;
		}
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_BatchRendererGroup_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_BatchRendererGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100668351);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(BatchRendererGroup batchRendererGroup)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)batchRendererGroup);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_BatchRendererGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate int GetConstantBufferMaxWindowSizeDelegate();

	private delegate int GetConstantBufferOffsetAlignmentDelegate();

	private delegate void SetDrawCommandBatchBuffer_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr batchID, [In] System.IntPtr buffer);

	private delegate void RegisterMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetRegisteredMaterial_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr material);

	private delegate void RegisterMesh_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr mesh, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetRegisteredMesh_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr mesh);

	private delegate void SetGlobalBounds_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr bounds);

	private delegate void SetPickingMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

	private delegate void SetErrorMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

	private delegate void SetLoadingMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr material);

	private delegate void SetEnabledViewTypes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr viewTypes);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GroupHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PerformCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FinishedCulling;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BatchRendererGroupCreateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDrawCommandBatch_Private_BatchID_IntPtr_Int32_GraphicsBufferHandle_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBatch_Public_BatchID_NativeArray_1_MetadataValue_GraphicsBufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawCommandBatch_Private_Void_BatchID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBatch_Public_Void_BatchID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMaterials_Internal_Void_ReadOnlySpan_1_Int32_Span_1_BatchMaterialID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterMaterial_Public_Void_BatchMaterialID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMeshes_Internal_Void_ReadOnlySpan_1_Int32_Span_1_BatchMeshID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterMesh_Public_Void_BatchMeshID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferTarget_Private_Static_BatchBufferTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BufferTarget_Public_Static_get_BatchBufferTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_BatchRendererGroup_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnFinishedCulling_Private_Static_Void_BatchRendererGroup_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OcclusionTestAABB_Internal_Static_Boolean_IntPtr_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDrawCommandBatch_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_byref_GraphicsBufferHandle_UInt32_UInt32_byref_BatchID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawCommandBatch_Injected_Private_Static_Void_IntPtr_byref_BatchID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMaterials_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterMaterial_Injected_Private_Static_Void_IntPtr_byref_BatchMaterialID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMeshes_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterMesh_Injected_Private_Static_Void_IntPtr_byref_BatchMeshID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OcclusionTestAABB_Injected_Private_Static_Boolean_IntPtr_byref_Bounds_0;

	private static readonly GetConstantBufferMaxWindowSizeDelegate GetConstantBufferMaxWindowSizeDelegateField;

	private static readonly GetConstantBufferOffsetAlignmentDelegate GetConstantBufferOffsetAlignmentDelegateField;

	private static readonly SetDrawCommandBatchBuffer_InjectedDelegate SetDrawCommandBatchBuffer_InjectedDelegateField;

	private static readonly RegisterMaterial_InjectedDelegate RegisterMaterial_InjectedDelegateField;

	private static readonly GetRegisteredMaterial_InjectedDelegate GetRegisteredMaterial_InjectedDelegateField;

	private static readonly RegisterMesh_InjectedDelegate RegisterMesh_InjectedDelegateField;

	private static readonly GetRegisteredMesh_InjectedDelegate GetRegisteredMesh_InjectedDelegateField;

	private static readonly SetGlobalBounds_InjectedDelegate SetGlobalBounds_InjectedDelegateField;

	private static readonly SetPickingMaterial_InjectedDelegate SetPickingMaterial_InjectedDelegateField;

	private static readonly SetErrorMaterial_InjectedDelegate SetErrorMaterial_InjectedDelegateField;

	private static readonly SetLoadingMaterial_InjectedDelegate SetLoadingMaterial_InjectedDelegateField;

	private static readonly SetEnabledViewTypes_InjectedDelegate SetEnabledViewTypes_InjectedDelegateField;

	public unsafe System.IntPtr m_GroupHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GroupHandle);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GroupHandle)) = value;
		}
	}

	public unsafe OnPerformCulling m_PerformCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerformCulling);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnPerformCulling>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerformCulling)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe OnFinishedCulling m_FinishedCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinishedCulling);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnFinishedCulling>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinishedCulling)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static BatchBufferTarget BufferTarget
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237460, RefRangeEnd = 1237462, XrefRangeStart = 1237460, XrefRangeEnd = 1237462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BufferTarget_Public_Static_get_BatchBufferTarget_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BatchBufferTarget*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BatchRendererGroup()
	{
		Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr);
		NativeFieldInfoPtr_m_GroupHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_GroupHandle");
		NativeFieldInfoPtr_m_PerformCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_PerformCulling");
		NativeFieldInfoPtr_m_FinishedCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_FinishedCulling");
		NativeMethodInfoPtr__ctor_Public_Void_BatchRendererGroupCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668323);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668324);
		NativeMethodInfoPtr_AddDrawCommandBatch_Private_BatchID_IntPtr_Int32_GraphicsBufferHandle_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668325);
		NativeMethodInfoPtr_AddBatch_Public_BatchID_NativeArray_1_MetadataValue_GraphicsBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668326);
		NativeMethodInfoPtr_RemoveDrawCommandBatch_Private_Void_BatchID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668327);
		NativeMethodInfoPtr_RemoveBatch_Public_Void_BatchID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668328);
		NativeMethodInfoPtr_RegisterMaterials_Internal_Void_ReadOnlySpan_1_Int32_Span_1_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668329);
		NativeMethodInfoPtr_UnregisterMaterial_Public_Void_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668330);
		NativeMethodInfoPtr_RegisterMeshes_Internal_Void_ReadOnlySpan_1_Int32_Span_1_BatchMeshID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668331);
		NativeMethodInfoPtr_UnregisterMesh_Public_Void_BatchMeshID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668332);
		NativeMethodInfoPtr_GetBufferTarget_Private_Static_BatchBufferTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668333);
		NativeMethodInfoPtr_get_BufferTarget_Public_Static_get_BatchBufferTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668334);
		NativeMethodInfoPtr_Create_Private_Static_IntPtr_BatchRendererGroup_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668335);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668336);
		NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668337);
		NativeMethodInfoPtr_InvokeOnFinishedCulling_Private_Static_Void_BatchRendererGroup_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668338);
		NativeMethodInfoPtr_OcclusionTestAABB_Internal_Static_Boolean_IntPtr_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668339);
		NativeMethodInfoPtr_AddDrawCommandBatch_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_byref_GraphicsBufferHandle_UInt32_UInt32_byref_BatchID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668340);
		NativeMethodInfoPtr_RemoveDrawCommandBatch_Injected_Private_Static_Void_IntPtr_byref_BatchID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668341);
		NativeMethodInfoPtr_RegisterMaterials_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668342);
		NativeMethodInfoPtr_UnregisterMaterial_Injected_Private_Static_Void_IntPtr_byref_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668343);
		NativeMethodInfoPtr_RegisterMeshes_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668344);
		NativeMethodInfoPtr_UnregisterMesh_Injected_Private_Static_Void_IntPtr_byref_BatchMeshID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668345);
		NativeMethodInfoPtr_OcclusionTestAABB_Injected_Private_Static_Boolean_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100668346);
		GetConstantBufferMaxWindowSizeDelegateField = IL2CPP.ResolveICall<GetConstantBufferMaxWindowSizeDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferMaxWindowSize");
		GetConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<GetConstantBufferOffsetAlignmentDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferOffsetAlignment");
		SetDrawCommandBatchBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SetDrawCommandBatchBuffer_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetDrawCommandBatchBuffer_Injected");
		RegisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<RegisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterial_Injected");
		GetRegisteredMaterial_InjectedDelegateField = IL2CPP.ResolveICall<GetRegisteredMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMaterial_Injected");
		RegisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<RegisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMesh_Injected");
		GetRegisteredMesh_InjectedDelegateField = IL2CPP.ResolveICall<GetRegisteredMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMesh_Injected");
		SetGlobalBounds_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalBounds_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetGlobalBounds_Injected");
		SetPickingMaterial_InjectedDelegateField = IL2CPP.ResolveICall<SetPickingMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetPickingMaterial_Injected");
		SetErrorMaterial_InjectedDelegateField = IL2CPP.ResolveICall<SetErrorMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetErrorMaterial_Injected");
		SetLoadingMaterial_InjectedDelegateField = IL2CPP.ResolveICall<SetLoadingMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetLoadingMaterial_Injected");
		SetEnabledViewTypes_InjectedDelegateField = IL2CPP.ResolveICall<SetEnabledViewTypes_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetEnabledViewTypes_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237399, RefRangeEnd = 1237400, XrefRangeStart = 1237393, XrefRangeEnd = 1237399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BatchRendererGroup(BatchRendererGroupCreateInfo info)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BatchRendererGroupCreateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237402, RefRangeEnd = 1237403, XrefRangeStart = 1237400, XrefRangeEnd = 1237402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237403, XrefRangeEnd = 1237406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BatchID AddDrawCommandBatch(System.IntPtr values, int count, GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&values);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(GraphicsBufferHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferOffset;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &windowSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDrawCommandBatch_Private_BatchID_IntPtr_Int32_GraphicsBufferHandle_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BatchID*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237413, RefRangeEnd = 1237414, XrefRangeStart = 1237406, XrefRangeEnd = 1237413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BatchID AddBatch(NativeArray<MetadataValue> batchMetadata, GraphicsBufferHandle buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMetadata));
		*(GraphicsBufferHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBatch_Public_BatchID_NativeArray_1_MetadataValue_GraphicsBufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BatchID*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237414, XrefRangeEnd = 1237417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDrawCommandBatch(BatchID batchID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&batchID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawCommandBatch_Private_Void_BatchID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237420, RefRangeEnd = 1237422, XrefRangeStart = 1237417, XrefRangeEnd = 1237420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBatch(BatchID batchID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&batchID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBatch_Public_Void_BatchID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237435, RefRangeEnd = 1237436, XrefRangeStart = 1237422, XrefRangeEnd = 1237435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterMaterials(Il2CppSystem.ReadOnlySpan<int> materialID, Il2CppSystem.Span<BatchMaterialID> batchMaterialID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterMaterials_Internal_Void_ReadOnlySpan_1_Int32_Span_1_BatchMaterialID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237439, RefRangeEnd = 1237440, XrefRangeStart = 1237436, XrefRangeEnd = 1237439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterMaterial(BatchMaterialID material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterMaterial_Public_Void_BatchMaterialID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237453, RefRangeEnd = 1237454, XrefRangeStart = 1237440, XrefRangeEnd = 1237453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterMeshes(Il2CppSystem.ReadOnlySpan<int> meshID, Il2CppSystem.Span<BatchMeshID> batchMeshID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)meshID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMeshID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterMeshes_Internal_Void_ReadOnlySpan_1_Int32_Span_1_BatchMeshID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237457, RefRangeEnd = 1237458, XrefRangeStart = 1237454, XrefRangeEnd = 1237457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterMesh(BatchMeshID mesh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mesh);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterMesh_Public_Void_BatchMeshID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237460, RefRangeEnd = 1237462, XrefRangeStart = 1237458, XrefRangeEnd = 1237460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BatchBufferTarget GetBufferTarget()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferTarget_Private_Static_BatchBufferTarget_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BatchBufferTarget*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237462, XrefRangeEnd = 1237464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create(BatchRendererGroup group, void* userContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = userContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Static_IntPtr_BatchRendererGroup_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237464, XrefRangeEnd = 1237466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr groupHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&groupHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237466, XrefRangeEnd = 1237481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, System.IntPtr userContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref context);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lodParameters);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &userContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237481, XrefRangeEnd = 1237485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnFinishedCulling(BatchRendererGroup group, System.IntPtr customCullingResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &customCullingResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnFinishedCulling_Private_Static_Void_BatchRendererGroup_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237487, RefRangeEnd = 1237488, XrefRangeStart = 1237485, XrefRangeEnd = 1237487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OcclusionTestAABB(System.IntPtr occlusionBuffer, Bounds aabb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&occlusionBuffer);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aabb;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OcclusionTestAABB_Internal_Static_Boolean_IntPtr_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237488, XrefRangeEnd = 1237490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddDrawCommandBatch_Injected(System.IntPtr _unity_self, System.IntPtr values, int count, [In] ref GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, out BatchID ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &values;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref buffer);
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferOffset;
		*(uint**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &windowSize;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDrawCommandBatch_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_byref_GraphicsBufferHandle_UInt32_UInt32_byref_BatchID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237490, XrefRangeEnd = 1237492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDrawCommandBatch_Injected(System.IntPtr _unity_self, [In] ref BatchID batchID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref batchID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawCommandBatch_Injected_Private_Static_Void_IntPtr_byref_BatchID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237492, XrefRangeEnd = 1237494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterMaterials_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper materialID, ref ManagedSpanWrapper batchMaterialID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref materialID);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref batchMaterialID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterMaterials_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237494, XrefRangeEnd = 1237496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterMaterial_Injected(System.IntPtr _unity_self, [In] ref BatchMaterialID material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterMaterial_Injected_Private_Static_Void_IntPtr_byref_BatchMaterialID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237496, XrefRangeEnd = 1237498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterMeshes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper meshID, ref ManagedSpanWrapper batchMeshID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref meshID);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref batchMeshID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterMeshes_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237498, XrefRangeEnd = 1237500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterMesh_Injected(System.IntPtr _unity_self, [In] ref BatchMeshID mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mesh);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterMesh_Injected_Private_Static_Void_IntPtr_byref_BatchMeshID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237500, XrefRangeEnd = 1237502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OcclusionTestAABB_Injected(System.IntPtr occlusionBuffer, [In] ref Bounds aabb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&occlusionBuffer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aabb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OcclusionTestAABB_Injected_Private_Static_Boolean_IntPtr_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BatchRendererGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe BatchID AddBatch(NativeArray<MetadataValue> batchMetadata, GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize)
	{
		//IL_0014: Expected O, but got Ref
		return AddDrawCommandBatch((System.IntPtr)batchMetadata.GetUnsafeReadOnlyPtr(), ((NativeArray<MetadataValue>)(&batchMetadata)).Length, buffer, bufferOffset, windowSize);
	}

	public void SetDrawCommandBatchBuffer(BatchID batchID, GraphicsBufferHandle buffer)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDrawCommandBatchBuffer_Injected(intPtr, ref batchID, ref buffer);
	}

	public void SetBatchBuffer(BatchID batchID, GraphicsBufferHandle buffer)
	{
		SetDrawCommandBatchBuffer(batchID, buffer);
	}

	public BatchMaterialID RegisterMaterial(Material material)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RegisterMaterial_Injected(intPtr, Object.MarshalledUnityObject.Marshal(material), out var ret);
		return ret;
	}

	public Material GetRegisteredMaterial(BatchMaterialID material)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Material>(GetRegisteredMaterial_Injected(intPtr, ref material));
	}

	public BatchMeshID RegisterMesh(Mesh mesh)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RegisterMesh_Injected(intPtr, Object.MarshalledUnityObject.Marshal(mesh), out var ret);
		return ret;
	}

	public Mesh GetRegisteredMesh(BatchMeshID mesh)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Mesh>(GetRegisteredMesh_Injected(intPtr, ref mesh));
	}

	public void SetGlobalBounds(Bounds bounds)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetGlobalBounds_Injected(intPtr, ref bounds);
	}

	public void SetPickingMaterial(Material material)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetPickingMaterial_Injected(intPtr, Object.MarshalledUnityObject.Marshal(material));
	}

	public void SetErrorMaterial(Material material)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetErrorMaterial_Injected(intPtr, Object.MarshalledUnityObject.Marshal(material));
	}

	public void SetLoadingMaterial(Material material)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLoadingMaterial_Injected(intPtr, Object.MarshalledUnityObject.Marshal(material));
	}

	public unsafe void SetEnabledViewTypes(Il2CppStructArray<BatchCullingViewType> viewTypes)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<BatchCullingViewType> span);
		((Il2CppSystem.Span<BatchCullingViewType>)(&span))._002Ector((Il2CppArrayBase<BatchCullingViewType>)(object)viewTypes);
		fixed (BatchCullingViewType* begin = &((Il2CppSystem.Span<BatchCullingViewType>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper viewTypes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<BatchCullingViewType>)(&span)).Length);
			SetEnabledViewTypes_Injected(intPtr, ref viewTypes2);
		}
	}

	public static int GetConstantBufferMaxWindowSize()
	{
		return GetConstantBufferMaxWindowSizeDelegateField();
	}

	public static int GetConstantBufferOffsetAlignment()
	{
		return GetConstantBufferOffsetAlignmentDelegateField();
	}

	public unsafe static void SetDrawCommandBatchBuffer_Injected(System.IntPtr _unity_self, [In] ref BatchID batchID, [In] ref GraphicsBufferHandle buffer)
	{
		SetDrawCommandBatchBuffer_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref batchID), (nint)Unsafe.AsPointer(ref buffer));
	}

	public unsafe static void RegisterMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material, out BatchMaterialID ret)
	{
		RegisterMaterial_InjectedDelegateField(_unity_self, material, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static System.IntPtr GetRegisteredMaterial_Injected(System.IntPtr _unity_self, [In] ref BatchMaterialID material)
	{
		return GetRegisteredMaterial_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref material));
	}

	public unsafe static void RegisterMesh_Injected(System.IntPtr _unity_self, System.IntPtr mesh, out BatchMeshID ret)
	{
		RegisterMesh_InjectedDelegateField(_unity_self, mesh, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static System.IntPtr GetRegisteredMesh_Injected(System.IntPtr _unity_self, [In] ref BatchMeshID mesh)
	{
		return GetRegisteredMesh_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref mesh));
	}

	public unsafe static void SetGlobalBounds_Injected(System.IntPtr _unity_self, [In] ref Bounds bounds)
	{
		SetGlobalBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref bounds));
	}

	public static void SetPickingMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material)
	{
		SetPickingMaterial_InjectedDelegateField(_unity_self, material);
	}

	public static void SetErrorMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material)
	{
		SetErrorMaterial_InjectedDelegateField(_unity_self, material);
	}

	public static void SetLoadingMaterial_Injected(System.IntPtr _unity_self, System.IntPtr material)
	{
		SetLoadingMaterial_InjectedDelegateField(_unity_self, material);
	}

	public unsafe static void SetEnabledViewTypes_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper viewTypes)
	{
		SetEnabledViewTypes_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref viewTypes));
	}
}
