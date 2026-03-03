using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine;

public static class AndroidJNIHelper : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
	}

	private delegate bool get_debugDelegate();

	private delegate void set_debugDelegate(bool value);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Box_Private_Static_IntPtr_jvalue_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Box_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Box_Public_Static_IntPtr_Boolean_0;

	private static readonly get_debugDelegate get_debugDelegateField;

	private static readonly set_debugDelegate set_debugDelegateField;

	public static bool debug
	{
		get
		{
			return get_debugDelegateField();
		}
		set
		{
			set_debugDelegateField(value);
		}
	}

	static AndroidJNIHelper()
	{
		Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNIHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663382);
		AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663384);
		AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_Box_Private_Static_IntPtr_jvalue_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_Box_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_Box_Public_Static_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663388);
		get_debugDelegateField = IL2CPP.ResolveICall<get_debugDelegate>("UnityEngine.AndroidJNIHelper::get_debug");
		set_debugDelegateField = IL2CPP.ResolveICall<set_debugDelegate>("UnityEngine.AndroidJNIHelper::set_debug");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150440, XrefRangeEnd = 1150444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetConstructorID(System.IntPtr javaClass, string signature)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&javaClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1150448, RefRangeEnd = 1150454, XrefRangeStart = 1150444, XrefRangeEnd = 1150448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName, string signature, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&javaClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150473, RefRangeEnd = 1150474, XrefRangeStart = 1150454, XrefRangeEnd = 1150473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jrunnable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1150494, RefRangeEnd = 1150497, XrefRangeStart = 1150474, XrefRangeEnd = 1150494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proxy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1150502, RefRangeEnd = 1150507, XrefRangeStart = 1150497, XrefRangeEnd = 1150502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateJNIArgArray(Il2CppReferenceArray<Il2CppSystem.Object> args, Il2CppSystem.Span<jvalue> jniArgs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)jniArgs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150507, XrefRangeEnd = 1150522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteJNIArgArray(Il2CppReferenceArray<Il2CppSystem.Object> args, Il2CppSystem.Span<jvalue> jniArgs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)jniArgs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150522, XrefRangeEnd = 1150533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150533, XrefRangeEnd = 1150541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, Il2CppReferenceArray<Il2CppSystem.Object> args, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150541, XrefRangeEnd = 1150566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150566, XrefRangeEnd = 1150582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1150592, RefRangeEnd = 1150595, XrefRangeStart = 1150582, XrefRangeEnd = 1150592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Box(jvalue val, string boxedClass, string signature)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&val);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(boxedClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Box_Private_Static_IntPtr_jvalue_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150595, XrefRangeEnd = 1150600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Box(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Box_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150600, XrefRangeEnd = 1150605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Box(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Box_Public_Static_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AndroidJNIHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr GetConstructorID(System.IntPtr javaClass)
	{
		return GetConstructorID(javaClass, "");
	}

	public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName)
	{
		return GetMethodID(javaClass, methodName, "", isStatic: false);
	}

	public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName, string signature)
	{
		return GetMethodID(javaClass, methodName, signature, isStatic: false);
	}

	public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName)
	{
		return GetFieldID(javaClass, fieldName, "", isStatic: false);
	}

	public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName, string signature)
	{
		return GetFieldID(javaClass, fieldName, signature, isStatic: false);
	}

	public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName, string signature, bool isStatic)
	{
		return _AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, isStatic);
	}

	public static System.IntPtr ConvertToJNIArray(Il2CppSystem.Array array)
	{
		return _AndroidJNIHelper.ConvertToJNIArray(array);
	}

	public static Il2CppStructArray<jvalue> CreateJNIArgArray(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void DeleteJNIArgArray(Il2CppReferenceArray<Il2CppSystem.Object> args, Il2CppStructArray<jvalue> jniArgs)
	{
		_AndroidJNIHelper.DeleteJNIArgArray(args, (Il2CppArrayBase<jvalue>)(object)jniArgs);
	}

	public static string GetSignature(Il2CppSystem.Object obj)
	{
		return _AndroidJNIHelper.GetSignature(obj);
	}

	public static string GetSignature(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		return _AndroidJNIHelper.GetSignature(args);
	}

	public static System.IntPtr GetFieldID<FieldType>(System.IntPtr jclass, string fieldName, bool isStatic)
	{
		return _AndroidJNIHelper.GetFieldID<FieldType>(jclass, fieldName, isStatic);
	}

	public static string GetSignature<ReturnType>(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		return _AndroidJNIHelper.GetSignature<ReturnType>(args);
	}

	public static System.IntPtr Box(sbyte value)
	{
		jvalue val = default(jvalue);
		val.b = value;
		return Box(val, "java/lang/Byte", "(B)Ljava/lang/Byte;");
	}

	public static System.IntPtr Box(short value)
	{
		jvalue val = default(jvalue);
		val.s = value;
		return Box(val, "java/lang/Short", "(S)Ljava/lang/Short;");
	}

	public static System.IntPtr Box(long value)
	{
		jvalue val = default(jvalue);
		val.j = value;
		return Box(val, "java/lang/Long", "(J)Ljava/lang/Long;");
	}

	public static System.IntPtr Box(float value)
	{
		jvalue val = default(jvalue);
		val.f = value;
		return Box(val, "java/lang/Float", "(F)Ljava/lang/Float;");
	}

	public static System.IntPtr Box(double value)
	{
		jvalue val = default(jvalue);
		val.d = value;
		return Box(val, "java/lang/Double", "(D)Ljava/lang/Double;");
	}

	public static System.IntPtr Box(char value)
	{
		jvalue val = default(jvalue);
		val.c = value;
		return Box(val, "java/lang/Character", "(C)Ljava/lang/Character;");
	}

	public static System.IntPtr GetUnboxMethod(System.IntPtr obj, string methodName, string signature)
	{
		System.IntPtr objectClass = AndroidJNISafe.GetObjectClass(obj);
		try
		{
			return AndroidJNISafe.GetMethodID(objectClass, methodName, signature);
		}
		finally
		{
			AndroidJNISafe.DeleteLocalRef(objectClass);
		}
	}

	public static void Unbox(System.IntPtr obj, out sbyte value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "byteValue", "()B");
		value = AndroidJNISafe.CallSByteMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out short value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "shortValue", "()S");
		value = AndroidJNISafe.CallShortMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out int value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "intValue", "()I");
		value = AndroidJNISafe.CallIntMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out long value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "longValue", "()J");
		value = AndroidJNISafe.CallLongMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out float value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "floatValue", "()F");
		value = AndroidJNISafe.CallFloatMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out double value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "doubleValue", "()D");
		value = AndroidJNISafe.CallDoubleMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out char value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "charValue", "()C");
		value = AndroidJNISafe.CallCharMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}

	public static void Unbox(System.IntPtr obj, out bool value)
	{
		System.IntPtr unboxMethod = GetUnboxMethod(obj, "booleanValue", "()Z");
		value = AndroidJNISafe.CallBooleanMethod(obj, unboxMethod, (Il2CppSystem.Span<jvalue>)null);
	}
}
