using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UI;

public static class SetPropertyUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0;

	static SetPropertyUtility()
	{
		Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "SetPropertyUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr);
		NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100664420);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1127116, RefRangeEnd = 1127121, XrefRangeStart = 1127116, XrefRangeEnd = 1127121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetColor(ref Color currentValue, Color newValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref currentValue);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1296975, RefRangeEnd = 1296983, XrefRangeStart = 1296962, XrefRangeEnd = 1296975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetStruct<T>(ref T currentValue, T newValue) where T : new()
	{
		//IL_005d->IL0060: Incompatible stack types: I vs Ref
		//IL_0050->IL0060: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref currentValue));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = newValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref newValue;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref currentValue) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1127143, RefRangeEnd = 1127171, XrefRangeStart = 1127143, XrefRangeEnd = 1127171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetClass<T>(ref T currentValue, T newValue) where T : class
	{
		//IL_005d->IL0060: Incompatible stack types: I vs Ref
		//IL_0050->IL0060: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentValue);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = newValue;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref newValue;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		currentValue = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public SetPropertyUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
