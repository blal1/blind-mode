using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public static class ThrowHelper : Object
{
	private sealed class MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0, Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArrayTypeMismatchException_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentException_DestinationTooShort_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateArgumentException_DestinationTooShort_Private_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIndexOutOfRangeException_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateIndexOutOfRangeException_Private_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_ArrayMemoryPoolBuffer_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateObjectDisposedException_ArrayMemoryPoolBuffer_Private_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateThrowNotSupportedException_Private_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowWrongKeyTypeArgumentException_Internal_Static_Void_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowSerializationException_Internal_Static_Void_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumNotStarted_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumEnded_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_NoValue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRange_IndexException_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIndexArgumentOutOfRange_NeedNonNegNumException_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentException_Argument_InvalidArrayType_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAddingDuplicateWithKeyArgumentException_Private_Static_ArgumentException_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowAddingDuplicateWithKeyArgumentException_Internal_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyNotFoundException_Private_Static_KeyNotFoundException_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowKeyNotFoundException_Internal_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidTypeWithPointersNotSupported_Internal_Static_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_ConcurrentOperationsNotSupported_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInvalidOperationException_Internal_Static_InvalidOperationException_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArraySegmentCtorValidationFailedExceptions_Internal_Static_Void_Array_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArraySegmentCtorValidationFailedException_Private_Static_Exception_Array_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArgumentException_Private_Static_ArgumentException_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArgumentNullException_Private_Static_ArgumentNullException_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_ExceptionResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0;

	static ThrowHelper()
	{
		Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThrowHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
		NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666304);
		NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666305);
		NativeMethodInfoPtr_ThrowArrayTypeMismatchException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666306);
		NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666307);
		NativeMethodInfoPtr_ThrowArgumentException_DestinationTooShort_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666308);
		NativeMethodInfoPtr_CreateArgumentException_DestinationTooShort_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666309);
		NativeMethodInfoPtr_ThrowIndexOutOfRangeException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666310);
		NativeMethodInfoPtr_CreateIndexOutOfRangeException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666311);
		NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666312);
		NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666313);
		NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666314);
		NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666315);
		NativeMethodInfoPtr_ThrowObjectDisposedException_ArrayMemoryPoolBuffer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666316);
		NativeMethodInfoPtr_CreateObjectDisposedException_ArrayMemoryPoolBuffer_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666317);
		NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666318);
		NativeMethodInfoPtr_CreateThrowNotSupportedException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666319);
		NativeMethodInfoPtr_ThrowWrongKeyTypeArgumentException_Internal_Static_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666320);
		NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666321);
		NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666322);
		NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666323);
		NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666324);
		NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666325);
		NativeMethodInfoPtr_ThrowSerializationException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666326);
		NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666327);
		NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666328);
		NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666329);
		NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumNotStarted_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666330);
		NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumEnded_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666331);
		NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_NoValue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666332);
		NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666333);
		NativeMethodInfoPtr_ThrowArgumentOutOfRange_IndexException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666334);
		NativeMethodInfoPtr_ThrowIndexArgumentOutOfRange_NeedNonNegNumException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666335);
		NativeMethodInfoPtr_ThrowArgumentException_Argument_InvalidArrayType_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666336);
		NativeMethodInfoPtr_GetAddingDuplicateWithKeyArgumentException_Private_Static_ArgumentException_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666337);
		NativeMethodInfoPtr_ThrowAddingDuplicateWithKeyArgumentException_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666338);
		NativeMethodInfoPtr_GetKeyNotFoundException_Private_Static_KeyNotFoundException_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666339);
		NativeMethodInfoPtr_ThrowKeyNotFoundException_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666340);
		NativeMethodInfoPtr_ThrowInvalidTypeWithPointersNotSupported_Internal_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_ThrowInvalidOperationException_ConcurrentOperationsNotSupported_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_GetInvalidOperationException_Internal_Static_InvalidOperationException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666343);
		NativeMethodInfoPtr_ThrowArraySegmentCtorValidationFailedExceptions_Internal_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_GetArraySegmentCtorValidationFailedException_Private_Static_Exception_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr_GetArgumentException_Private_Static_ArgumentException_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr_GetArgumentNullException_Private_Static_ArgumentNullException_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666353);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 749026, RefRangeEnd = 749102, XrefRangeStart = 749023, XrefRangeEnd = 749026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentNullException(ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749109, RefRangeEnd = 749110, XrefRangeStart = 749102, XrefRangeEnd = 749109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateArgumentNullException(ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 749113, RefRangeEnd = 749115, XrefRangeStart = 749110, XrefRangeEnd = 749113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArrayTypeMismatchException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArrayTypeMismatchException_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749119, RefRangeEnd = 749120, XrefRangeStart = 749115, XrefRangeEnd = 749119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateArrayTypeMismatchException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 749123, RefRangeEnd = 749126, XrefRangeStart = 749120, XrefRangeEnd = 749123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentException_DestinationTooShort()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentException_DestinationTooShort_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749132, RefRangeEnd = 749133, XrefRangeStart = 749126, XrefRangeEnd = 749132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateArgumentException_DestinationTooShort()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateArgumentException_DestinationTooShort_Private_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 749136, RefRangeEnd = 749149, XrefRangeStart = 749133, XrefRangeEnd = 749136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowIndexOutOfRangeException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIndexOutOfRangeException_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749153, RefRangeEnd = 749154, XrefRangeStart = 749149, XrefRangeEnd = 749153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateIndexOutOfRangeException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateIndexOutOfRangeException_Private_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(243)]
	[CachedScanResults(RefRangeStart = 749157, RefRangeEnd = 749400, XrefRangeStart = 749154, XrefRangeEnd = 749157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentOutOfRangeException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749404, RefRangeEnd = 749405, XrefRangeStart = 749400, XrefRangeEnd = 749404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateArgumentOutOfRangeException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 749408, RefRangeEnd = 749436, XrefRangeStart = 749405, XrefRangeEnd = 749408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749443, RefRangeEnd = 749444, XrefRangeStart = 749436, XrefRangeEnd = 749443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749444, XrefRangeEnd = 749447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowObjectDisposedException_ArrayMemoryPoolBuffer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowObjectDisposedException_ArrayMemoryPoolBuffer_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749456, RefRangeEnd = 749457, XrefRangeStart = 749447, XrefRangeEnd = 749456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateObjectDisposedException_ArrayMemoryPoolBuffer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateObjectDisposedException_ArrayMemoryPoolBuffer_Private_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 749460, RefRangeEnd = 749465, XrefRangeStart = 749457, XrefRangeEnd = 749460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowNotSupportedException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749469, RefRangeEnd = 749470, XrefRangeStart = 749465, XrefRangeEnd = 749469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateThrowNotSupportedException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateThrowNotSupportedException_Private_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749486, RefRangeEnd = 749487, XrefRangeStart = 749470, XrefRangeEnd = 749486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowWrongKeyTypeArgumentException(Object key, Type targetType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowWrongKeyTypeArgumentException_Internal_Static_Void_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 749503, RefRangeEnd = 749510, XrefRangeStart = 749487, XrefRangeEnd = 749503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowWrongValueTypeArgumentException(Object value, Type targetType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 749517, RefRangeEnd = 749552, XrefRangeStart = 749510, XrefRangeEnd = 749517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentException(ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 749560, RefRangeEnd = 749572, XrefRangeStart = 749552, XrefRangeEnd = 749560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&resource);
		*(ExceptionArgument**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &argument;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 749589, RefRangeEnd = 749618, XrefRangeStart = 749572, XrefRangeEnd = 749589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&argument);
		*(ExceptionResource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resource;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 749625, RefRangeEnd = 749637, XrefRangeStart = 749618, XrefRangeEnd = 749625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException(ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749637, XrefRangeEnd = 749644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowSerializationException(ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowSerializationException_Internal_Static_Void_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 749651, RefRangeEnd = 749684, XrefRangeStart = 749644, XrefRangeEnd = 749651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowNotSupportedException(ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 749690, RefRangeEnd = 749703, XrefRangeStart = 749684, XrefRangeEnd = 749690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 749709, RefRangeEnd = 749721, XrefRangeStart = 749703, XrefRangeEnd = 749709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 749727, RefRangeEnd = 749729, XrefRangeStart = 749721, XrefRangeEnd = 749727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumNotStarted_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 749735, RefRangeEnd = 749737, XrefRangeStart = 749729, XrefRangeEnd = 749735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumEnded()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumEnded_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749743, RefRangeEnd = 749744, XrefRangeStart = 749737, XrefRangeEnd = 749743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException_InvalidOperation_NoValue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_NoValue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 749749, RefRangeEnd = 749751, XrefRangeStart = 749744, XrefRangeEnd = 749749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&argument);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr2) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 749755, RefRangeEnd = 749771, XrefRangeStart = 749751, XrefRangeEnd = 749755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentOutOfRange_IndexException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentOutOfRange_IndexException_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 749775, RefRangeEnd = 749790, XrefRangeStart = 749771, XrefRangeEnd = 749775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIndexArgumentOutOfRange_NeedNonNegNumException_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 749796, RefRangeEnd = 749809, XrefRangeStart = 749790, XrefRangeEnd = 749796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentException_Argument_InvalidArrayType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentException_Argument_InvalidArrayType_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749816, RefRangeEnd = 749817, XrefRangeStart = 749809, XrefRangeEnd = 749816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArgumentException GetAddingDuplicateWithKeyArgumentException(Object key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAddingDuplicateWithKeyArgumentException_Private_Static_ArgumentException_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749817, XrefRangeEnd = 749820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowAddingDuplicateWithKeyArgumentException(Object key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowAddingDuplicateWithKeyArgumentException_Internal_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749829, RefRangeEnd = 749830, XrefRangeStart = 749820, XrefRangeEnd = 749829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KeyNotFoundException GetKeyNotFoundException(Object key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyNotFoundException_Private_Static_KeyNotFoundException_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyNotFoundException>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749831, RefRangeEnd = 749832, XrefRangeStart = 749830, XrefRangeEnd = 749831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowKeyNotFoundException(Object key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowKeyNotFoundException_Internal_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 749839, RefRangeEnd = 749845, XrefRangeStart = 749832, XrefRangeEnd = 749839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidTypeWithPointersNotSupported(Type targetType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidTypeWithPointersNotSupported_Internal_Static_Void_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 749849, RefRangeEnd = 749852, XrefRangeStart = 749845, XrefRangeEnd = 749849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidOperationException_ConcurrentOperationsNotSupported_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749856, RefRangeEnd = 749857, XrefRangeStart = 749852, XrefRangeEnd = 749856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InvalidOperationException GetInvalidOperationException(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInvalidOperationException_Internal_Static_InvalidOperationException_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749860, RefRangeEnd = 749861, XrefRangeStart = 749857, XrefRangeEnd = 749860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArraySegmentCtorValidationFailedExceptions_Internal_Static_Void_Array_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 749868, RefRangeEnd = 749869, XrefRangeStart = 749861, XrefRangeEnd = 749868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArraySegmentCtorValidationFailedException_Private_Static_Exception_Array_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749869, XrefRangeEnd = 749876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArgumentException GetArgumentException(ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArgumentException_Private_Static_ArgumentException_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749876, XrefRangeEnd = 749881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArgumentNullException GetArgumentNullException(ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArgumentNullException_Private_Static_ArgumentNullException_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArgumentNullException>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 749882, RefRangeEnd = 749885, XrefRangeStart = 749881, XrefRangeEnd = 749882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IfNullAndNullsAreIllegalThenThrow<T>(Object value, ExceptionArgument argName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(ExceptionArgument**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &argName;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 749910, RefRangeEnd = 749916, XrefRangeStart = 749885, XrefRangeEnd = 749910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetArgumentName(ExceptionArgument argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 749924, RefRangeEnd = 749926, XrefRangeStart = 749916, XrefRangeEnd = 749924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&argument);
		*(ExceptionResource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resource;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 749929, RefRangeEnd = 749933, XrefRangeStart = 749926, XrefRangeEnd = 749929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 749936, RefRangeEnd = 749942, XrefRangeStart = 749933, XrefRangeEnd = 749936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 749989, RefRangeEnd = 749995, XrefRangeStart = 749942, XrefRangeEnd = 749989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceName(ExceptionResource resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public ThrowHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
