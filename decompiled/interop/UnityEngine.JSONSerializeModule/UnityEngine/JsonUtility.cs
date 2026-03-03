using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class JsonUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FromJson_Public_Static_T_String_0, Il2CppClassPointerStore<JsonUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJsonInternal_Private_Static_String_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJsonInternal_Private_Static_Object_String_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJson_Public_Static_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Object_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJsonOverwrite_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJsonInternal_Injected_Private_Static_Void_Object_Boolean_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJsonInternal_Injected_Private_Static_Object_byref_ManagedSpanWrapper_Object_Type_0;

	static JsonUtility()
	{
		Il2CppClassPointerStore<JsonUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.JSONSerializeModule.dll", "UnityEngine", "JsonUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr);
		NativeMethodInfoPtr_ToJsonInternal_Private_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_FromJsonInternal_Private_Static_Object_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_ToJson_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_FromJson_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_FromJson_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_FromJsonOverwrite_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_ToJsonInternal_Injected_Private_Static_Void_Object_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_FromJsonInternal_Injected_Private_Static_Object_byref_ManagedSpanWrapper_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663305);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1253233, RefRangeEnd = 1253235, XrefRangeStart = 1253225, XrefRangeEnd = 1253233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToJsonInternal(Il2CppSystem.Object obj, bool prettyPrint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prettyPrint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJsonInternal_Private_Static_String_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1253249, RefRangeEnd = 1253251, XrefRangeStart = 1253235, XrefRangeEnd = 1253249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object FromJsonInternal(string json, Il2CppSystem.Object objectToOverwrite, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToOverwrite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJsonInternal_Private_Static_Object_String_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1253259, RefRangeEnd = 1253272, XrefRangeStart = 1253251, XrefRangeEnd = 1253259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToJson(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1253281, RefRangeEnd = 1253287, XrefRangeStart = 1253272, XrefRangeEnd = 1253281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToJson(Il2CppSystem.Object obj, bool prettyPrint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prettyPrint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJson_Public_Static_String_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1253293, RefRangeEnd = 1253313, XrefRangeStart = 1253287, XrefRangeEnd = 1253293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FromJson<T>(string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FromJson_Public_Static_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253324, RefRangeEnd = 1253325, XrefRangeStart = 1253313, XrefRangeEnd = 1253324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object FromJson(string json, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJson_Public_Static_Object_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1253334, RefRangeEnd = 1253338, XrefRangeStart = 1253325, XrefRangeEnd = 1253334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FromJsonOverwrite(string json, Il2CppSystem.Object objectToOverwrite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToOverwrite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJsonOverwrite_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253338, XrefRangeEnd = 1253340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ToJsonInternal_Injected(Il2CppSystem.Object obj, bool prettyPrint, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prettyPrint;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJsonInternal_Injected_Private_Static_Void_Object_Boolean_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253340, XrefRangeEnd = 1253342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object FromJsonInternal_Injected(ref ManagedSpanWrapper json, Il2CppSystem.Object objectToOverwrite, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref json);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToOverwrite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJsonInternal_Injected_Private_Static_Object_byref_ManagedSpanWrapper_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	public JsonUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
