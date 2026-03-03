using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices;

public static class JitHelpers : Object
{
	private sealed class MethodInfoStoreGeneric_UnsafeCast_Internal_Static_T_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_UnsafeEnumCast_Internal_Static_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_UnsafeEnumCastLong_Internal_Static_Int64_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0;

	static JitHelpers()
	{
		Il2CppClassPointerStore<JitHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "JitHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100671509);
		NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100671510);
		NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100671511);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806953, XrefRangeEnd = 806955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T UnsafeCast<T>(Object o) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnsafeCast_Internal_Static_T_Object_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 806960, RefRangeEnd = 806963, XrefRangeStart = 806955, XrefRangeEnd = 806960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int UnsafeEnumCast<T>(T val) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = val;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref val;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnsafeEnumCast_Internal_Static_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806963, XrefRangeEnd = 806966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long UnsafeEnumCastLong<T>(T val) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = val;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref val;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnsafeEnumCastLong_Internal_Static_Int64_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public JitHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
