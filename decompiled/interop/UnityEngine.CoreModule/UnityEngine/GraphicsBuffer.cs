using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class GraphicsBuffer : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "Target")]
	[System.Flags]
	public enum Target
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 0x10,
		Raw = 0x20,
		Append = 0x40,
		Counter = 0x80,
		IndirectArguments = 0x100,
		Constant = 0x200
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "UsageFlags")]
	[System.Flags]
	public enum UsageFlags
	{
		None = 0,
		LockBufferForWrite = 1
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_GraphicsBuffer_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GraphicsBuffer_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToManaged_Public_Static_GraphicsBuffer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100664869);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100664870);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1177410, RefRangeEnd = 1177412, XrefRangeStart = 1177406, XrefRangeEnd = 1177410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsBuffer ConvertToManaged(System.IntPtr ptr)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
			*ptr2 = (nint)(&ptr);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToManaged_Public_Static_GraphicsBuffer_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(GraphicsBuffer graphicsBuffer)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphicsBuffer);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GraphicsBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_UnlockBufferAfterWrite_Public_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnlockBufferAfterWrite_Public_Void_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate Target get_target_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void InternalGetData_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

	private delegate System.IntPtr GetNativeBufferPtr_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetCounterValue_InjectedDelegate(System.IntPtr _unity_self, uint counterValue);

	private delegate void CopyCountCC_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

	private delegate void CopyCountGC_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

	private delegate void CopyCountCG_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

	private delegate void CopyCountGG_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Target_UsageFlags_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUsageFlags_Private_UsageFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usageFlags_Public_get_UsageFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bufferHandle_Public_get_GraphicsBufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockBufferAfterWrite_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUsageFlags_Injected_Private_Static_UsageFlags_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bufferHandle_Injected_Private_Static_Void_IntPtr_byref_GraphicsBufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly get_target_InjectedDelegate get_target_InjectedDelegateField;

	private static readonly InternalGetData_InjectedDelegate InternalGetData_InjectedDelegateField;

	private static readonly GetNativeBufferPtr_InjectedDelegate GetNativeBufferPtr_InjectedDelegateField;

	private static readonly SetCounterValue_InjectedDelegate SetCounterValue_InjectedDelegateField;

	private static readonly CopyCountCC_InjectedDelegate CopyCountCC_InjectedDelegateField;

	private static readonly CopyCountGC_InjectedDelegate CopyCountGC_InjectedDelegateField;

	private static readonly CopyCountCG_InjectedDelegate CopyCountCG_InjectedDelegateField;

	private static readonly CopyCountGG_InjectedDelegate CopyCountGG_InjectedDelegateField;

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

	public unsafe int count
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1177541, RefRangeEnd = 1177546, XrefRangeStart = 1177537, XrefRangeEnd = 1177541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int stride
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1177550, RefRangeEnd = 1177557, XrefRangeStart = 1177546, XrefRangeEnd = 1177550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UsageFlags usageFlags
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177561, RefRangeEnd = 1177562, XrefRangeStart = 1177561, XrefRangeEnd = 1177562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usageFlags_Public_get_UsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UsageFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe GraphicsBufferHandle bufferHandle
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1177565, RefRangeEnd = 1177568, XrefRangeStart = 1177562, XrefRangeEnd = 1177565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bufferHandle_Public_get_GraphicsBufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsBufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string name
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1177672, RefRangeEnd = 1177675, XrefRangeStart = 1177671, XrefRangeEnd = 1177672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Target target
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_target_Injected(intPtr);
		}
	}

	static GraphicsBuffer()
	{
		Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GraphicsBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664828);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664829);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664830);
		NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664831);
		NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664832);
		NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664833);
		NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664834);
		NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664836);
		NativeMethodInfoPtr__ctor_Public_Void_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664837);
		NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664838);
		NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664839);
		NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664840);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664841);
		NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664842);
		NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664843);
		NativeMethodInfoPtr_GetUsageFlags_Private_UsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664844);
		NativeMethodInfoPtr_get_usageFlags_Public_get_UsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664845);
		NativeMethodInfoPtr_get_bufferHandle_Public_get_GraphicsBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664846);
		NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664847);
		NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664848);
		NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664849);
		NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664850);
		NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664851);
		NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664852);
		NativeMethodInfoPtr_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664853);
		NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664854);
		NativeMethodInfoPtr_UnlockBufferAfterWrite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664855);
		NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664856);
		NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664857);
		NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664858);
		NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664859);
		NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664860);
		NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664861);
		NativeMethodInfoPtr_GetUsageFlags_Injected_Private_Static_UsageFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664862);
		NativeMethodInfoPtr_get_bufferHandle_Injected_Private_Static_Void_IntPtr_byref_GraphicsBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664863);
		NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664864);
		NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664865);
		NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664866);
		NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664867);
		NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664868);
		get_target_InjectedDelegateField = IL2CPP.ResolveICall<get_target_InjectedDelegate>("UnityEngine.GraphicsBuffer::get_target_Injected");
		InternalGetData_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetData_InjectedDelegate>("UnityEngine.GraphicsBuffer::InternalGetData_Injected");
		GetNativeBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<GetNativeBufferPtr_InjectedDelegate>("UnityEngine.GraphicsBuffer::GetNativeBufferPtr_Injected");
		SetCounterValue_InjectedDelegateField = IL2CPP.ResolveICall<SetCounterValue_InjectedDelegate>("UnityEngine.GraphicsBuffer::SetCounterValue_Injected");
		CopyCountCC_InjectedDelegateField = IL2CPP.ResolveICall<CopyCountCC_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountCC_Injected");
		CopyCountGC_InjectedDelegateField = IL2CPP.ResolveICall<CopyCountGC_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountGC_Injected");
		CopyCountCG_InjectedDelegateField = IL2CPP.ResolveICall<CopyCountCG_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountCG_Injected");
		CopyCountGG_InjectedDelegateField = IL2CPP.ResolveICall<CopyCountGG_InjectedDelegate>("UnityEngine.GraphicsBuffer::CopyCountGG_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177412, XrefRangeEnd = 1177421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 1177430, RefRangeEnd = 1177485, XrefRangeStart = 1177421, XrefRangeEnd = 1177430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177485, XrefRangeEnd = 1177491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool RequiresCompute(Target target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsVertexIndexOrCopyOnly(Target target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177491, XrefRangeEnd = 1177493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&target);
		*(UsageFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usageFlags;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177493, XrefRangeEnd = 1177496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyBuffer(GraphicsBuffer buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 1177498, RefRangeEnd = 1177520, XrefRangeStart = 1177496, XrefRangeEnd = 1177498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphicsBuffer(Target target, int count, int stride)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1177522, RefRangeEnd = 1177526, XrefRangeStart = 1177520, XrefRangeEnd = 1177522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphicsBuffer(Target target, UsageFlags usageFlags, int count, int stride)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&target);
		*(UsageFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usageFlags;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Target_UsageFlags_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177530, RefRangeEnd = 1177532, XrefRangeStart = 1177526, XrefRangeEnd = 1177530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&target);
		*(UsageFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usageFlags;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 1177430, RefRangeEnd = 1177485, XrefRangeStart = 1177430, XrefRangeEnd = 1177485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177532, XrefRangeEnd = 1177535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidBuffer(GraphicsBuffer buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_GraphicsBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177535, RefRangeEnd = 1177537, XrefRangeStart = 1177535, XrefRangeEnd = 1177535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177561, RefRangeEnd = 1177562, XrefRangeStart = 1177557, XrefRangeEnd = 1177561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UsageFlags GetUsageFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsageFlags_Private_UsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UsageFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177572, RefRangeEnd = 1177573, XrefRangeStart = 1177568, XrefRangeEnd = 1177572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData<T>(NativeArray<T> data) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177611, RefRangeEnd = 1177612, XrefRangeStart = 1177573, XrefRangeEnd = 1177611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(Il2CppSystem.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphicsBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1177616, RefRangeEnd = 1177621, XrefRangeStart = 1177612, XrefRangeEnd = 1177616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphicsBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177625, RefRangeEnd = 1177627, XrefRangeStart = 1177621, XrefRangeEnd = 1177625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetNativeData(System.IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphicsBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177627, XrefRangeEnd = 1177631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetData(Il2CppSystem.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphicsBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177635, RefRangeEnd = 1177636, XrefRangeStart = 1177631, XrefRangeEnd = 1177635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void* BeginBufferWrite(int offset = 0, int size = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginBufferWrite_Private_ptr_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177643, RefRangeEnd = 1177644, XrefRangeStart = 1177636, XrefRangeEnd = 1177643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bufferStartIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LockBufferForWrite_Public_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177648, RefRangeEnd = 1177650, XrefRangeStart = 1177644, XrefRangeEnd = 1177648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndBufferWrite(int bytesWritten = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytesWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndBufferWrite_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177670, RefRangeEnd = 1177671, XrefRangeStart = 1177650, XrefRangeEnd = 1177670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockBufferAfterWrite<T>(int countWritten) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&countWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnlockBufferAfterWrite_Public_Void_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177690, RefRangeEnd = 1177691, XrefRangeStart = 1177675, XrefRangeEnd = 1177690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177691, XrefRangeEnd = 1177693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyBuffer_Injected(System.IntPtr buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177693, XrefRangeEnd = 1177695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidBuffer_Injected(System.IntPtr buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177695, XrefRangeEnd = 1177697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_count_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177697, XrefRangeEnd = 1177699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_stride_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177699, XrefRangeEnd = 1177701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UsageFlags GetUsageFlags_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsageFlags_Injected_Private_Static_UsageFlags_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UsageFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177701, XrefRangeEnd = 1177703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_bufferHandle_Injected(System.IntPtr _unity_self, out GraphicsBufferHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bufferHandle_Injected_Private_Static_Void_IntPtr_byref_GraphicsBufferHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177703, XrefRangeEnd = 1177705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetNativeData_Injected(System.IntPtr _unity_self, System.IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphicsBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177705, XrefRangeEnd = 1177707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetData_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphicsBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177707, XrefRangeEnd = 1177709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* BeginBufferWrite_Injected(System.IntPtr _unity_self, int offset, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginBufferWrite_Injected_Private_Static_ptr_Void_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177709, XrefRangeEnd = 1177711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndBufferWrite_Injected(System.IntPtr _unity_self, int bytesWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bytesWritten;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndBufferWrite_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177711, XrefRangeEnd = 1177713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GraphicsBuffer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetData(Il2CppSystem.Array data)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsArrayBlittable(data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", (Il2CppSystem.Object)UnsafeUtility.GetReasonForArrayNonBlittable(data)));
		}
		InternalSetData(data, 0, 0, data.Length, UnsafeUtility.SizeOf(((Il2CppSystem.Object)data).GetType().GetElementType()));
	}

	public void SetData<T>(List<T> data) where T : struct
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		InternalSetData((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength(data), Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
	}

	public void SetData<T>(List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		if (managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object)(object)managedBufferStartIndex, (Il2CppSystem.Object)(object)graphicsBufferStartIndex, (Il2CppSystem.Object)(object)count));
		}
		InternalSetData((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
	}

	public void GetData(Il2CppSystem.Array data)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsArrayBlittable(data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object)UnsafeUtility.GetReasonForArrayNonBlittable(data)));
		}
		InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(((Il2CppSystem.Object)data).GetType().GetElementType()));
	}

	public void GetData(Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsArrayBlittable(data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object)UnsafeUtility.GetReasonForArrayNonBlittable(data)));
		}
		if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object)(object)managedBufferStartIndex, (Il2CppSystem.Object)(object)computeBufferStartIndex, (Il2CppSystem.Object)(object)count));
		}
		InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(((Il2CppSystem.Object)data).GetType().GetElementType()));
	}

	public void InternalGetData(Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		InternalGetData_Injected(intPtr, data, managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
	}

	public System.IntPtr GetNativeBufferPtr()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetNativeBufferPtr_Injected(intPtr);
	}

	public void SetCounterValue(uint counterValue)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetCounterValue_Injected(intPtr, counterValue);
	}

	public static void CopyCountCC(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
	{
		CopyCountCC_Injected((src == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
	}

	public static void CopyCountGC(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
	{
		CopyCountGC_Injected((src == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
	}

	public static void CopyCountCG(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
	{
		CopyCountCG_Injected((src == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
	}

	public static void CopyCountGG(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
	{
		CopyCountGG_Injected((src == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
	}

	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
	{
		CopyCountCC(src, dst, dstOffsetBytes);
	}

	public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
	{
		CopyCountGC(src, dst, dstOffsetBytes);
	}

	public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
	{
		CopyCountCG(src, dst, dstOffsetBytes);
	}

	public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
	{
		CopyCountGG(src, dst, dstOffsetBytes);
	}

	public static Target get_target_Injected(System.IntPtr _unity_self)
	{
		return get_target_InjectedDelegateField(_unity_self);
	}

	public static void InternalGetData_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		InternalGetData_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
	}

	public static System.IntPtr GetNativeBufferPtr_Injected(System.IntPtr _unity_self)
	{
		return GetNativeBufferPtr_InjectedDelegateField(_unity_self);
	}

	public static void SetCounterValue_Injected(System.IntPtr _unity_self, uint counterValue)
	{
		SetCounterValue_InjectedDelegateField(_unity_self, counterValue);
	}

	public static void CopyCountCC_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
	{
		CopyCountCC_InjectedDelegateField(src, dst, dstOffsetBytes);
	}

	public static void CopyCountGC_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
	{
		CopyCountGC_InjectedDelegateField(src, dst, dstOffsetBytes);
	}

	public static void CopyCountCG_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
	{
		CopyCountCG_InjectedDelegateField(src, dst, dstOffsetBytes);
	}

	public static void CopyCountGG_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
	{
		CopyCountGG_InjectedDelegateField(src, dst, dstOffsetBytes);
	}
}
