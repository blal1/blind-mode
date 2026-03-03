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

public static class RemoveRangeExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0, Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0;

	static RemoveRangeExtensions()
	{
		Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RemoveRangeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr, 100664546);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030154, XrefRangeEnd = 1030157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryRemoveElementsInRange<TValue>(this IList<TValue> list, int index, int count, out Il2CppSystem.Exception error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		error = ((num3 == 0) ? null : new Il2CppSystem.Exception(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RemoveRangeExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
