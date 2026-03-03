using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.IO;

public static class MonoLinqHelper : Object
{
	private sealed class MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0;

	static MonoLinqHelper()
	{
		Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoLinqHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr);
		NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr, 100675115);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 839562, RefRangeEnd = 839567, XrefRangeStart = 839560, XrefRangeEnd = 839562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> ToArray<T>(this IEnumerable<T> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	public MonoLinqHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
