using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization;

public static class GlobalizationMode : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Invariant_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Invariant_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalizationInvariantMode_Private_Static_Boolean_0;

	public unsafe static bool _Invariant_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Invariant_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Invariant_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool Invariant
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817914, XrefRangeEnd = 817918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Invariant_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GlobalizationMode()
	{
		Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "GlobalizationMode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr);
		NativeFieldInfoPtr__Invariant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr, "<Invariant>k__BackingField");
		NativeMethodInfoPtr_get_Invariant_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr, 100672817);
		NativeMethodInfoPtr_GetGlobalizationInvariantMode_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalizationMode>.NativeClassPtr, 100672818);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetGlobalizationInvariantMode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalizationInvariantMode_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GlobalizationMode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
