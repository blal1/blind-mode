using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem;

[System.Serializable]
public class AggregateException : Exception
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_innerExceptions;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Flatten_Public_AggregateException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe ReadOnlyCollection<Exception> m_innerExceptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_innerExceptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_innerExceptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReadOnlyCollection<Exception> InnerExceptions
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Exception>>(intPtr2) : null;
		}
	}

	public unsafe override string Message
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718471, XrefRangeEnd = 718492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static AggregateException()
	{
		Il2CppClassPointerStore<AggregateException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AggregateException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggregateException>.NativeClassPtr);
		NativeFieldInfoPtr_m_innerExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, "m_innerExceptions");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_get_InnerExceptions_Public_get_ReadOnlyCollection_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_Flatten_Public_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateException>.NativeClassPtr, 100664262);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718206, XrefRangeEnd = 718225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718225, XrefRangeEnd = 718238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(IEnumerable<Exception> innerExceptions)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718241, RefRangeEnd = 718243, XrefRangeStart = 718238, XrefRangeEnd = 718241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException([Optional] Il2CppReferenceArray<Exception> innerExceptions)
	{
		if (innerExceptions == null)
		{
			innerExceptions = new Il2CppReferenceArray<Exception>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718243, XrefRangeEnd = 718254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(string message, IEnumerable<Exception> innerExceptions)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718254, XrefRangeEnd = 718255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(string message, [Optional] Il2CppReferenceArray<Exception> innerExceptions)
	{
		if (innerExceptions == null)
		{
			innerExceptions = new Il2CppReferenceArray<Exception>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 718299, RefRangeEnd = 718304, XrefRangeStart = 718255, XrefRangeEnd = 718299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(string message, IList<Exception> innerExceptions)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718317, RefRangeEnd = 718318, XrefRangeStart = 718304, XrefRangeEnd = 718317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptionInfos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718329, RefRangeEnd = 718330, XrefRangeStart = 718318, XrefRangeEnd = 718329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptionInfos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_IEnumerable_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718376, RefRangeEnd = 718378, XrefRangeStart = 718330, XrefRangeEnd = 718376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerExceptionInfos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_IList_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718378, XrefRangeEnd = 718412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718412, XrefRangeEnd = 718430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718469, RefRangeEnd = 718471, XrefRangeStart = 718430, XrefRangeEnd = 718469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AggregateException Flatten()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Flatten_Public_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AggregateException>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718492, XrefRangeEnd = 718525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AggregateException(params Exception[] innerExceptions)
		: this(new Il2CppReferenceArray<Exception>(innerExceptions))
	{
	}

	public AggregateException(string message, params Exception[] innerExceptions)
		: this(message, new Il2CppReferenceArray<Exception>(innerExceptions))
	{
	}

	public AggregateException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
