using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

public static class ListBufferExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ListBuffer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QuickSort_Public_Static_Void_ListBuffer_1_T_0, Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_ListBuffer_1_T_0;

	static ListBufferExtensions()
	{
		Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ListBufferExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_QuickSort_Public_Static_Void_ListBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr, 100664468);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029573, XrefRangeEnd = 1029577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort<T>(this ListBuffer<T> self) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)self));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ListBuffer_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ListBufferExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
