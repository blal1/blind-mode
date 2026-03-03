using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSpine;

public static class HashSetExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_AddAll_Public_Static_Boolean_HashSet_1_T_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddAll_Public_Static_Boolean_HashSet_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<HashSetExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAll_Public_Static_Boolean_HashSet_1_T_Il2CppArrayBase_1_T_0;

	static HashSetExtensions()
	{
		Il2CppClassPointerStore<HashSetExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "HashSetExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSetExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_AddAll_Public_Static_Boolean_HashSet_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetExtensions>.NativeClassPtr, 100663593);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 842145, RefRangeEnd = 842146, XrefRangeStart = 842143, XrefRangeEnd = 842145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AddAll<T>(this HashSet<T> set, Il2CppArrayBase<T> addSet)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addSet);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddAll_Public_Static_Boolean_HashSet_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HashSetExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
