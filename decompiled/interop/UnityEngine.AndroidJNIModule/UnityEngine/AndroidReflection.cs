using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class AndroidReflection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetMethodID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetFieldID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FieldGetDeclaringClass;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvocationError_Internal_Static_IntPtr_Exception_Boolean_0;

	public const string RELECTION_HELPER_CLASS_NAME = "com/unity3d/player/ReflectionHelper";

	public unsafe static GlobalJavaObjectRef s_ReflectionHelperClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperClass, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperClass, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static System.IntPtr s_ReflectionHelperGetConstructorID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr s_ReflectionHelperGetMethodID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperGetMethodID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperGetMethodID, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr s_ReflectionHelperGetFieldID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperGetFieldID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperGetFieldID, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr s_ReflectionHelperGetFieldSignature
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr s_ReflectionHelperNewProxyInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr s_ReflectionHelperCeateInvocationError
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr s_FieldGetDeclaringClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FieldGetDeclaringClass, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FieldGetDeclaringClass, (void*)(&value));
		}
	}

	static AndroidReflection()
	{
		Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidReflection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr);
		NativeFieldInfoPtr_s_ReflectionHelperClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperClass");
		NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetConstructorID");
		NativeFieldInfoPtr_s_ReflectionHelperGetMethodID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetMethodID");
		NativeFieldInfoPtr_s_ReflectionHelperGetFieldID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetFieldID");
		NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetFieldSignature");
		NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperNewProxyInstance");
		NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperCeateInvocationError");
		NativeFieldInfoPtr_s_FieldGetDeclaringClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_FieldGetDeclaringClass");
		NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_CreateInvocationError_Internal_Static_IntPtr_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663354);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1149400, RefRangeEnd = 1149404, XrefRangeStart = 1149398, XrefRangeEnd = 1149400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPrimitive(Il2CppSystem.Type t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1149405, RefRangeEnd = 1149408, XrefRangeStart = 1149404, XrefRangeEnd = 1149405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAssignableFrom(Il2CppSystem.Type t, Il2CppSystem.Type from)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149408, XrefRangeEnd = 1149414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(clazz);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149414, XrefRangeEnd = 1149420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(string clazz, string methodName, string signature)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(clazz);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1149434, RefRangeEnd = 1149435, XrefRangeStart = 1149420, XrefRangeEnd = 1149434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetConstructorMember(System.IntPtr jclass, string signature)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1149450, RefRangeEnd = 1149451, XrefRangeStart = 1149435, XrefRangeEnd = 1149450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodMember(System.IntPtr jclass, string methodName, string signature, bool isStatic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&jclass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(signature);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStatic;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149451, XrefRangeEnd = 1149461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewProxyInstance(System.IntPtr player, System.IntPtr delegateHandle, System.IntPtr interfaze)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&player);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delegateHandle;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &interfaze;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1149473, RefRangeEnd = 1149475, XrefRangeStart = 1149461, XrefRangeEnd = 1149473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateInvocationError(Il2CppSystem.Exception ex, bool methodNotFound)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodNotFound;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvocationError_Internal_Static_IntPtr_Exception_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AndroidReflection(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr GetFieldMember(System.IntPtr jclass, string fieldName, string signature, bool isStatic)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static System.IntPtr GetFieldClass(System.IntPtr field)
	{
		return AndroidJNISafe.CallObjectMethod(field, s_FieldGetDeclaringClass, (Il2CppStructArray<jvalue>)null);
	}

	public static string GetFieldSignature(System.IntPtr field)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
