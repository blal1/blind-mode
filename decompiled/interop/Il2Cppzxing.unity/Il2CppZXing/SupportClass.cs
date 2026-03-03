using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppZXing;

public static class SupportClass : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<SupportClass>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_T_0, Il2CppClassPointerStore<SupportClass>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetValue_Public_Static_T_IDictionary_2_DecodeHintType_Object_DecodeHintType_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValue_Public_Static_T_IDictionary_2_DecodeHintType_Object_DecodeHintType_T_0, Il2CppClassPointerStore<SupportClass>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBinaryString_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bitCount_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Static_T_IDictionary_2_DecodeHintType_Object_DecodeHintType_T_0;

	static SupportClass()
	{
		Il2CppClassPointerStore<SupportClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "SupportClass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportClass>.NativeClassPtr);
		NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportClass>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportClass>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_ToBinaryString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportClass>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_bitCount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportClass>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_GetValue_Public_Static_T_IDictionary_2_DecodeHintType_Object_DecodeHintType_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportClass>.NativeClassPtr, 100663536);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1413130, RefRangeEnd = 1413136, XrefRangeStart = 1413129, XrefRangeEnd = 1413130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413136, RefRangeEnd = 1413137, XrefRangeStart = 1413136, XrefRangeEnd = 1413136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Fill<T>(Il2CppArrayBase<T> array, int startIndex, int endIndex, T value)
	{
		//IL_0073->IL0076: Incompatible stack types: I vs Ref
		//IL_0066->IL0076: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endIndex;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413144, RefRangeEnd = 1413145, XrefRangeStart = 1413137, XrefRangeEnd = 1413144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBinaryString(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBinaryString_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1413145, RefRangeEnd = 1413147, XrefRangeStart = 1413145, XrefRangeEnd = 1413145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bitCount(int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bitCount_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413156, RefRangeEnd = 1413157, XrefRangeStart = 1413147, XrefRangeEnd = 1413156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetValue<T>(IDictionary<DecodeHintType, Il2CppSystem.Object> hints, DecodeHintType hintType, T @default)
	{
		//IL_0065->IL0068: Incompatible stack types: I vs Ref
		//IL_0058->IL0068: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		*(DecodeHintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hintType;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = @default;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref @default;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValue_Public_Static_T_IDictionary_2_DecodeHintType_Object_DecodeHintType_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	public SupportClass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
