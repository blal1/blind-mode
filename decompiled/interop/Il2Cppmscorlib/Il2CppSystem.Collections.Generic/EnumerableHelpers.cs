using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections.Generic;

public static class EnumerableHelpers : Object
{
	private sealed class MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0, Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0;

	static EnumerableHelpers()
	{
		Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "EnumerableHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr, 100674112);
		NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr, 100674113);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 831988, RefRangeEnd = 831989, XrefRangeStart = 831982, XrefRangeEnd = 831988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ToArray<T>(IEnumerable<T> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832013, RefRangeEnd = 832014, XrefRangeStart = 831989, XrefRangeEnd = 832013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ToArray<T>(IEnumerable<T> source, out int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref length);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	public EnumerableHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
