using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class NameFormatter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FormatVariableName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatVariableName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	static NameFormatter()
	{
		Il2CppClassPointerStore<NameFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NameFormatter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameFormatter>.NativeClassPtr);
		NativeMethodInfoPtr_FormatVariableName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameFormatter>.NativeClassPtr, 100666799);
		NativeMethodInfoPtr_FormatVariableName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameFormatter>.NativeClassPtr, 100666800);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216958, XrefRangeEnd = 1216972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatVariableName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatVariableName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216972, XrefRangeEnd = 1216974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatVariableName_Injected(ref ManagedSpanWrapper name, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatVariableName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NameFormatter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
