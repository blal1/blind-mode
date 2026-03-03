using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections;

public static class NativeSliceExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0;

	static NativeSliceExtensions()
	{
		Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSliceExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663580);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1165758, RefRangeEnd = 1165760, XrefRangeStart = 1165756, XrefRangeEnd = 1165758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)thisArray));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<T>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1165762, RefRangeEnd = 1165764, XrefRangeStart = 1165760, XrefRangeEnd = 1165762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)thisArray));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<T>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1165766, RefRangeEnd = 1165767, XrefRangeStart = 1165764, XrefRangeEnd = 1165766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start, int length) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)thisArray));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<T>(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1165769, RefRangeEnd = 1165773, XrefRangeStart = 1165767, XrefRangeEnd = 1165769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start, int length) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)thisSlice));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<T>(pointer);
	}

	public NativeSliceExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice) where T : struct
	{
		return thisSlice;
	}

	public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start) where T : struct
	{
		return new NativeSlice<T>(thisSlice, start);
	}
}
