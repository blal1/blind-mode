using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public static class NativeArrayExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0;

	static NativeArrayExtensions()
	{
		Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "NativeArrayExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr, 100665990);
		NativeMethodInfoPtr_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr, 100665991);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1106829, RefRangeEnd = 1106832, XrefRangeStart = 1106828, XrefRangeEnd = 1106829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref T UnsafeElementAt<T>(this NativeArray<T> array, int index) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnsafeElementAt_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(T*)intPtr2;
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1106833, RefRangeEnd = 1106854, XrefRangeStart = 1106832, XrefRangeEnd = 1106833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref T UnsafeElementAtMutable<T>(this NativeArray<T> array, int index) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnsafeElementAtMutable_Public_Static_byref_T_NativeArray_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(T*)intPtr2;
	}

	public NativeArrayExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
