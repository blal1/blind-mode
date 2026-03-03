using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.InputSystem.Utilities;

public static class ReadOnlyArrayExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Contains_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0, Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0, Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_ReadOnlyArray_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_ReadOnlyArray_1_TValue_TValue_0, Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_HaveEqualReferences_Internal_Static_Boolean_ReadOnlyArray_1_TValue_IReadOnlyList_1_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_HaveEqualReferences_Internal_Static_Boolean_ReadOnlyArray_1_TValue_IReadOnlyList_1_TValue_Int32_0, Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_ReadOnlyArray_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveEqualReferences_Internal_Static_Boolean_ReadOnlyArray_1_TValue_IReadOnlyList_1_TValue_Int32_0;

	static ReadOnlyArrayExtensions()
	{
		Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "ReadOnlyArrayExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Contains_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr, 100669015);
		NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr, 100669016);
		NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_ReadOnlyArray_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr, 100669017);
		NativeMethodInfoPtr_HaveEqualReferences_Internal_Static_Boolean_ReadOnlyArray_1_TValue_IReadOnlyList_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyArrayExtensions>.NativeClassPtr, 100669018);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1021423, RefRangeEnd = 1021427, XrefRangeStart = 1021421, XrefRangeEnd = 1021423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Contains<TValue>(this ReadOnlyArray<TValue> array, TValue value)
	{
		//IL_005c->IL005f: Incompatible stack types: I vs Ref
		//IL_004f->IL005f: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Contains_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1021428, RefRangeEnd = 1021434, XrefRangeStart = 1021427, XrefRangeEnd = 1021428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsReference<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : class
	{
		//IL_005c->IL005f: Incompatible stack types: I vs Ref
		//IL_004f->IL005f: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			TValue val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_ReadOnlyArray_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1021434, RefRangeEnd = 1021436, XrefRangeStart = 1021434, XrefRangeEnd = 1021434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOfReference<TValue>(this ReadOnlyArray<TValue> array, TValue value) where TValue : class
	{
		//IL_005c->IL005f: Incompatible stack types: I vs Ref
		//IL_004f->IL005f: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			TValue val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_ReadOnlyArray_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1021447, RefRangeEnd = 1021448, XrefRangeStart = 1021436, XrefRangeEnd = 1021447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HaveEqualReferences<TValue>(this ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = int.MaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array1));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array2);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_HaveEqualReferences_Internal_Static_Boolean_ReadOnlyArray_1_TValue_IReadOnlyList_1_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ReadOnlyArrayExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
