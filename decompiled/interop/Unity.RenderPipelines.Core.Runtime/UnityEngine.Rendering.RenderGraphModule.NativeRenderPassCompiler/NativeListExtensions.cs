using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public static class NativeListExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_MakeReadOnlySpan_Internal_Static_ReadOnlySpan_1_T_byref_NativeList_1_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MakeReadOnlySpan_Internal_Static_ReadOnlySpan_1_T_byref_NativeList_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeListExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LastIndex_Internal_Static_Int32_byref_NativeList_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LastIndex_Internal_Static_Int32_byref_NativeList_1_T_0, Il2CppClassPointerStore<NativeListExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeReadOnlySpan_Internal_Static_ReadOnlySpan_1_T_byref_NativeList_1_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndex_Internal_Static_Int32_byref_NativeList_1_T_0;

	static NativeListExtensions()
	{
		Il2CppClassPointerStore<NativeListExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "NativeListExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeListExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_MakeReadOnlySpan_Internal_Static_ReadOnlySpan_1_T_byref_NativeList_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeListExtensions>.NativeClassPtr, 100667790);
		NativeMethodInfoPtr_LastIndex_Internal_Static_Int32_byref_NativeList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeListExtensions>.NativeClassPtr, 100667791);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061562, XrefRangeEnd = 1061564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ReadOnlySpan<T> MakeReadOnlySpan<T>(this ref NativeList<T> list, int first, int numElements) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &first;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numElements;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MakeReadOnlySpan_Internal_Static_ReadOnlySpan_1_T_byref_NativeList_1_T_Int32_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<T>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061564, XrefRangeEnd = 1061566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LastIndex<T>(this ref NativeList<T> list) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LastIndex_Internal_Static_Int32_byref_NativeList_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NativeListExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
