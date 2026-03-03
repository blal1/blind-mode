using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class PropertyNameUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PropertyName_0;

	static PropertyNameUtils()
	{
		Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyNameUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr);
		NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100666073);
		NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100666074);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185310, RefRangeEnd = 1185312, XrefRangeStart = 1185296, XrefRangeEnd = 1185310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyName PropertyNameFromString(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PropertyName*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185312, XrefRangeEnd = 1185314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PropertyNameFromString_Injected(ref ManagedSpanWrapper name, out PropertyName ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PropertyName_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PropertyNameUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
