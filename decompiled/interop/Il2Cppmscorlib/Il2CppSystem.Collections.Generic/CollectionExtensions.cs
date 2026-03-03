using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections.Generic;

public static class CollectionExtensions : Object
{
	private sealed class MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0<TKey, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0<TKey, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0;

	static CollectionExtensions()
	{
		Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "CollectionExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100674136);
		NativeMethodInfoPtr_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100674137);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832175, RefRangeEnd = 832176, XrefRangeStart = 832171, XrefRangeEnd = 832175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TKey reference;
		if (!typeof(TKey).IsValueType)
		{
			object obj = key;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref key;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_0<TKey, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832176, XrefRangeEnd = 832179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		//IL_009f->IL00a2: Incompatible stack types: I vs Ref
		//IL_0092->IL00a2: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TKey reference;
		if (!typeof(TKey).IsValueType)
		{
			object obj = key;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref key;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference2;
		if (!typeof(TValue).IsValueType)
		{
			object obj2 = defaultValue;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref defaultValue;
		}
		*(void**)num2 = Unsafe.AsPointer(ref reference2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValueOrDefault_Public_Static_TValue_IReadOnlyDictionary_2_TKey_TValue_TKey_TValue_0<TKey, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	public CollectionExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
