using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

public static class SwapCollectionExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0, Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0;

	static SwapCollectionExtensions()
	{
		Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SwapCollectionExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr, 100664564);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030244, XrefRangeEnd = 1030299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TrySwap<TValue>(this IList<TValue> list, int from, int to, out Il2CppSystem.Exception error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		error = ((num3 == 0) ? null : new Il2CppSystem.Exception(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SwapCollectionExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
