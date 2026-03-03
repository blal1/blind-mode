using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine;

public sealed class _AndroidJNIHelper : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0<ReturnType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_FRAME_SIZE_FOR_ARRAYS;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_IntPtr_AndroidJavaProxy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0;

	public unsafe static int FRAME_SIZE_FOR_ARRAYS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FRAME_SIZE_FOR_ARRAYS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FRAME_SIZE_FOR_ARRAYS, (void*)(&value));
		}
	}

	static _AndroidJNIHelper()
	{
		Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "_AndroidJNIHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr);
		NativeFieldInfoPtr_FRAME_SIZE_FOR_ARRAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, "FRAME_SIZE_FOR_ARRAYS");
		NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_IntPtr_AndroidJavaProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663366);
		_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663367);
		_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663372);
		_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663373);
		_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663374);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149475, XrefRangeEnd = 1149488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateJavaProxy(System.IntPtr player, System.IntPtr delegateHandle, AndroidJavaProxy proxy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&player);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delegateHandle;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proxy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_IntPtr_AndroidJavaProxy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149488, XrefRangeEnd = 1149504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jrunnable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149504, XrefRangeEnd = 1149509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, System.IntPtr jmethodName, System.IntPtr jargs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proxy);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jmethodName;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &jargs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1149574, RefRangeEnd = 1149575, XrefRangeStart = 1149509, XrefRangeEnd = 1149574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateJNIArgArray(Il2CppReferenceArray<Il2CppSystem.Object> args, Il2CppSystem.Span<jvalue> ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ret));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1149705, RefRangeEnd = 1149706, XrefRangeStart = 1149575, XrefRangeEnd = 1149705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object UnboxArray(AndroidJavaObject obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1149891, RefRangeEnd = 1149893, XrefRangeStart = 1149706, XrefRangeEnd = 1149891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Unbox(AndroidJavaObject obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1149917, RefRangeEnd = 1149918, XrefRangeStart = 1149893, XrefRangeEnd = 1149917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidJavaObject Box(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149918, XrefRangeEnd = 1149930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteJNIArgArray(Il2CppReferenceArray<Il2CppSystem.Object> args, Il2CppSystem.Span<jvalue> jniArgs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)jniArgs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150116, RefRangeEnd = 1150117, XrefRangeStart = 1149930, XrefRangeEnd = 1150116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ConvertToJNIArray(Il2CppSystem.Array array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1150241, RefRangeEnd = 1150244, XrefRangeStart = 1150117, XrefRangeEnd = 1150241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArrayType ConvertFromJNIArray<ArrayType>(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<ArrayType>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150244, XrefRangeEnd = 1150252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetConstructorID(System.IntPtr jclass, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150252, XrefRangeEnd = 1150257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, Il2CppReferenceArray<Il2CppSystem.Object> args, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1150268, RefRangeEnd = 1150275, XrefRangeStart = 1150257, XrefRangeEnd = 1150268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID<ReturnType>(System.IntPtr jclass, string methodName, Il2CppReferenceArray<Il2CppSystem.Object> args, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1150288, RefRangeEnd = 1150292, XrefRangeStart = 1150275, XrefRangeEnd = 1150288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetConstructorID(System.IntPtr jclass, string signature)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150306, RefRangeEnd = 1150307, XrefRangeStart = 1150292, XrefRangeEnd = 1150306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, string signature, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150311, RefRangeEnd = 1150312, XrefRangeStart = 1150307, XrefRangeEnd = 1150311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodIDFallback(System.IntPtr jclass, string methodName, string signature, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1150381, RefRangeEnd = 1150385, XrefRangeStart = 1150312, XrefRangeEnd = 1150381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSignature(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1150402, RefRangeEnd = 1150409, XrefRangeStart = 1150385, XrefRangeEnd = 1150402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSignature(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150439, RefRangeEnd = 1150440, XrefRangeStart = 1150409, XrefRangeEnd = 1150439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSignature<ReturnType>(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public _AndroidJNIHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr GetFieldID<ReturnType>(System.IntPtr jclass, string fieldName, bool isStatic)
	{
		return AndroidJNIHelper.GetFieldID(jclass, fieldName, GetSignature((Il2CppSystem.Object)Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ReturnType>())), isStatic);
	}

	public static System.IntPtr GetFieldID(System.IntPtr jclass, string fieldName, string signature, bool isStatic)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
