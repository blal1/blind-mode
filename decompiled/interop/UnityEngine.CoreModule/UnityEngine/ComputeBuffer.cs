using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class ComputeBuffer : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_ComputeBuffer_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100666624);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(ComputeBuffer computeBuffer)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeBuffer);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_ComputeBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
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
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate ComputeBufferMode get_usage_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void InternalGetData_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

	private delegate System.IntPtr BeginBufferWrite_InjectedDelegate(System.IntPtr _unity_self, int offset, int size);

	private delegate void EndBufferWrite_InjectedDelegate(System.IntPtr _unity_self, int bytesWritten);

	private delegate void SetName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name);

	private delegate void SetCounterValue_InjectedDelegate(System.IntPtr _unity_self, uint counterValue);

	private delegate void CopyCount_InjectedDelegate(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes);

	private delegate System.IntPtr GetNativeBufferPtr_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0;

	private static readonly get_usage_InjectedDelegate get_usage_InjectedDelegateField;

	private static readonly InternalGetData_InjectedDelegate InternalGetData_InjectedDelegateField;

	private static readonly BeginBufferWrite_InjectedDelegate BeginBufferWrite_InjectedDelegateField;

	private static readonly EndBufferWrite_InjectedDelegate EndBufferWrite_InjectedDelegateField;

	private static readonly SetName_InjectedDelegate SetName_InjectedDelegateField;

	private static readonly SetCounterValue_InjectedDelegate SetCounterValue_InjectedDelegateField;

	private static readonly CopyCount_InjectedDelegate CopyCount_InjectedDelegateField;

	private static readonly GetNativeBufferPtr_InjectedDelegate GetNativeBufferPtr_InjectedDelegateField;

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
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1215346, RefRangeEnd = 1215353, XrefRangeStart = 1215342, XrefRangeEnd = 1215346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1215357, RefRangeEnd = 1215371, XrefRangeStart = 1215353, XrefRangeEnd = 1215357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ComputeBufferMode usage
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_usage_Injected(intPtr);
		}
	}

	public string name
	{
		set
		{
			SetName(value);
		}
	}

	static ComputeBuffer()
	{
		Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666600);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666601);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666602);
		NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666603);
		NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666604);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666605);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666606);
		NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666607);
		NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666608);
		NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666611);
		NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666612);
		NativeMethodInfoPtr_SetData_Public_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_IsValidBuffer_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_get_count_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_get_stride_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666623);
		get_usage_InjectedDelegateField = IL2CPP.ResolveICall<get_usage_InjectedDelegate>("UnityEngine.ComputeBuffer::get_usage_Injected");
		InternalGetData_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetData_InjectedDelegate>("UnityEngine.ComputeBuffer::InternalGetData_Injected");
		BeginBufferWrite_InjectedDelegateField = IL2CPP.ResolveICall<BeginBufferWrite_InjectedDelegate>("UnityEngine.ComputeBuffer::BeginBufferWrite_Injected");
		EndBufferWrite_InjectedDelegateField = IL2CPP.ResolveICall<EndBufferWrite_InjectedDelegate>("UnityEngine.ComputeBuffer::EndBufferWrite_Injected");
		SetName_InjectedDelegateField = IL2CPP.ResolveICall<SetName_InjectedDelegate>("UnityEngine.ComputeBuffer::SetName_Injected");
		SetCounterValue_InjectedDelegateField = IL2CPP.ResolveICall<SetCounterValue_InjectedDelegate>("UnityEngine.ComputeBuffer::SetCounterValue_Injected");
		CopyCount_InjectedDelegateField = IL2CPP.ResolveICall<CopyCount_InjectedDelegate>("UnityEngine.ComputeBuffer::CopyCount_Injected");
		GetNativeBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<GetNativeBufferPtr_InjectedDelegate>("UnityEngine.ComputeBuffer::GetNativeBufferPtr_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215207, XrefRangeEnd = 1215216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 1215225, RefRangeEnd = 1215270, XrefRangeStart = 1215216, XrefRangeEnd = 1215225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215270, XrefRangeEnd = 1215276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215276, XrefRangeEnd = 1215278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		*(ComputeBufferType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(ComputeBufferMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215278, XrefRangeEnd = 1215281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyBuffer(ComputeBuffer buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1215282, RefRangeEnd = 1215290, XrefRangeStart = 1215281, XrefRangeEnd = 1215282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer(int count, int stride)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 1215291, RefRangeEnd = 1215328, XrefRangeStart = 1215290, XrefRangeEnd = 1215291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		*(ComputeBufferType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215333, RefRangeEnd = 1215335, XrefRangeStart = 1215328, XrefRangeEnd = 1215333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		*(ComputeBufferType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(ComputeBufferMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &stackDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 1215225, RefRangeEnd = 1215270, XrefRangeStart = 1215225, XrefRangeEnd = 1215270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215335, XrefRangeEnd = 1215338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidBuffer(ComputeBuffer buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidBuffer_Private_Static_Boolean_ComputeBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1215338, RefRangeEnd = 1215342, XrefRangeStart = 1215338, XrefRangeEnd = 1215338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1215377, RefRangeEnd = 1215396, XrefRangeStart = 1215371, XrefRangeEnd = 1215377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(Il2CppSystem.Array data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215396, XrefRangeEnd = 1215399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData<T>(NativeArray<T> data) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1215403, RefRangeEnd = 1215413, XrefRangeStart = 1215399, XrefRangeEnd = 1215403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215417, RefRangeEnd = 1215419, XrefRangeStart = 1215413, XrefRangeEnd = 1215417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetNativeData(System.IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215419, XrefRangeEnd = 1215423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetData(Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215423, XrefRangeEnd = 1215425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyBuffer_Injected(System.IntPtr buf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyBuffer_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215425, XrefRangeEnd = 1215427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215427, XrefRangeEnd = 1215429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215429, XrefRangeEnd = 1215431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215431, XrefRangeEnd = 1215433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetNativeData_Injected(System.IntPtr _unity_self, System.IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetNativeData_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215433, XrefRangeEnd = 1215435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetData_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBufferStartIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetData_Injected_Private_Static_Void_IntPtr_Array_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ComputeBuffer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetData<T>(List<T> data) where T : struct
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		InternalSetData((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength(data), Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
	}

	public void SetData(Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsArrayBlittable(data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to ComputeBuffer.SetData(array) must be blittable.\n{0}", (Il2CppSystem.Object)UnsafeUtility.GetReasonForArrayNonBlittable(data)));
		}
		if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object)(object)managedBufferStartIndex, (Il2CppSystem.Object)(object)computeBufferStartIndex, (Il2CppSystem.Object)(object)count));
		}
		InternalSetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf(((Il2CppSystem.Object)data).GetType().GetElementType()));
	}

	public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object)(object)managedBufferStartIndex, (Il2CppSystem.Object)(object)computeBufferStartIndex, (Il2CppSystem.Object)(object)count));
		}
		InternalSetData((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, computeBufferStartIndex, count, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
	}

	public void GetData(Il2CppSystem.Array data)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsArrayBlittable(data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object)UnsafeUtility.GetReasonForArrayNonBlittable(data)));
		}
		InternalGetData(data, 0, 0, data.Length, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf(((Il2CppSystem.Object)data).GetType().GetElementType()));
	}

	public void GetData(Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		if (!UnsafeUtility.IsArrayBlittable(data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", (Il2CppSystem.Object)UnsafeUtility.GetReasonForArrayNonBlittable(data)));
		}
		if (managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", (Il2CppSystem.Object)(object)managedBufferStartIndex, (Il2CppSystem.Object)(object)computeBufferStartIndex, (Il2CppSystem.Object)(object)count));
		}
		InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf(((Il2CppSystem.Object)data).GetType().GetElementType()));
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

	public unsafe void* BeginBufferWrite([System.Runtime.InteropServices.Optional] int offset, [System.Runtime.InteropServices.Optional] int size)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return BeginBufferWrite_Injected(intPtr, offset, size);
	}

	public NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : struct
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void EndBufferWrite([System.Runtime.InteropServices.Optional] int bytesWritten)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EndBufferWrite_Injected(intPtr, bytesWritten);
	}

	public void EndWrite<T>(int countWritten) where T : struct
	{
		if (countWritten < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad indices/count arguments (countWritten:{0})", (Il2CppSystem.Object)(object)countWritten));
		}
		int num = UnsafeUtility.SizeOf<T>();
		EndBufferWrite(countWritten * num);
	}

	public unsafe void SetName(string name)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetName_Injected(intPtr, ref managedSpanWrapper);
					return;
				}
			}
			SetName_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
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

	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
	{
		CopyCount_Injected((src == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(dst), dstOffsetBytes);
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

	public static ComputeBufferMode get_usage_Injected(System.IntPtr _unity_self)
	{
		return get_usage_InjectedDelegateField(_unity_self);
	}

	public static void InternalGetData_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
		InternalGetData_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
	}

	public unsafe static void* BeginBufferWrite_Injected(System.IntPtr _unity_self, int offset, int size)
	{
		return (void*)BeginBufferWrite_InjectedDelegateField(_unity_self, offset, size);
	}

	public static void EndBufferWrite_Injected(System.IntPtr _unity_self, int bytesWritten)
	{
		EndBufferWrite_InjectedDelegateField(_unity_self, bytesWritten);
	}

	public unsafe static void SetName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		SetName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name));
	}

	public static void SetCounterValue_Injected(System.IntPtr _unity_self, uint counterValue)
	{
		SetCounterValue_InjectedDelegateField(_unity_self, counterValue);
	}

	public static void CopyCount_Injected(System.IntPtr src, System.IntPtr dst, int dstOffsetBytes)
	{
		CopyCount_InjectedDelegateField(src, dst, dstOffsetBytes);
	}

	public static System.IntPtr GetNativeBufferPtr_Injected(System.IntPtr _unity_self)
	{
		return GetNativeBufferPtr_InjectedDelegateField(_unity_self);
	}
}
