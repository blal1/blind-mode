using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2Cpp;

public sealed class Locale : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

	static Locale()
	{
		Il2CppClassPointerStore<Locale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "", "Locale");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Locale>.NativeClassPtr);
		NativeMethodInfoPtr_GetText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663298);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 687979, RefRangeEnd = 687983, XrefRangeStart = 687978, XrefRangeEnd = 687979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string fmt, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fmt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public static string GetText(string fmt, params Il2CppSystem.Object[] args)
	{
		return GetText(fmt, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public Locale(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
