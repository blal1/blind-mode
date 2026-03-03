using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections;

public static class HashtableExtensions : Object
{
	private sealed class MethodInfoStoreGeneric_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0, Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0;

	static HashtableExtensions()
	{
		Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections", "HashtableExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr, 100665296);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 881415, RefRangeEnd = 881419, XrefRangeStart = 881414, XrefRangeEnd = 881415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetValue<T>(this Hashtable table, Object key, out T value)
	{
		//IL_004a->IL004c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)table);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<T, object>(ref value) = ((num3 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num3, false, false));
		}
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HashtableExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
