using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppTMPro;

public static class TMPro_ExtensionMethods : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0, Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_TagToInt_Internal_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0;

	static TMPro_ExtensionMethods()
	{
		Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_ExtensionMethods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr);
		NativeMethodInfoPtr_TagToInt_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663608);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119763, XrefRangeEnd = 1119768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TagToInt(this string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TagToInt_Internal_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119768, XrefRangeEnd = 1119773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> ToIntArray(this string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119773, XrefRangeEnd = 1119779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ArrayToString(this Il2CppStructArray<char> chars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119779, XrefRangeEnd = 1119786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IntToString(this Il2CppStructArray<int> unicodes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unicodes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119786, XrefRangeEnd = 1119797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UintToString(this List<uint> unicodes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unicodes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119797, XrefRangeEnd = 1119802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IntToString(this Il2CppStructArray<int> unicodes, int start, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unicodes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119802, XrefRangeEnd = 1119807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindInstanceID<T>(this List<T> list, T target) where T : UnityEngine.Object
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = target;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref target;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1119807, RefRangeEnd = 1119811, XrefRangeStart = 1119807, XrefRangeEnd = 1119807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Compare(this Color32 a, Color32 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool CompareRGB(this Color32 a, Color32 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool Compare(this Color a, Color b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool CompareRGB(this Color a, Color b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1119811, RefRangeEnd = 1119823, XrefRangeStart = 1119811, XrefRangeEnd = 1119811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 Multiply(this Color32 c1, Color32 c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1119811, RefRangeEnd = 1119823, XrefRangeStart = 1119811, XrefRangeEnd = 1119823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 Tint(this Color32 c1, Color32 c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119823, XrefRangeEnd = 1119827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 Tint(this Color32 c1, float tint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1119830, RefRangeEnd = 1119838, XrefRangeStart = 1119827, XrefRangeEnd = 1119830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 GammaToLinear(this Color32 c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1119838, RefRangeEnd = 1119841, XrefRangeStart = 1119838, XrefRangeEnd = 1119838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte GammaToLinear(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1119841, RefRangeEnd = 1119845, XrefRangeStart = 1119841, XrefRangeEnd = 1119841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color MinAlpha(this Color c1, Color c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool Compare(this Vector3 v1, Vector3 v2, int accuracy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &accuracy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool Compare(this Quaternion q1, Quaternion q2, int accuracy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&q1);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &q2;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &accuracy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TMPro_ExtensionMethods(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
