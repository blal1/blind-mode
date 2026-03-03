using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public static class ParamTransfer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Exec_Public_Static_UInt32_UInt64_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextNum_Private_Static_UInt32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAlphabetNum_Private_Static_UInt32_Char_0;

	static ParamTransfer()
	{
		Il2CppClassPointerStore<ParamTransfer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ParamTransfer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamTransfer>.NativeClassPtr);
		NativeMethodInfoPtr_Exec_Public_Static_UInt32_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamTransfer>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_GetTextNum_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamTransfer>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_GetAlphabetNum_Private_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamTransfer>.NativeClassPtr, 100663598);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33130, RefRangeEnd = 33131, XrefRangeStart = 33124, XrefRangeEnd = 33130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Exec(ulong did, uint pcode0, uint pcode1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&did);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pcode0;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pcode1;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exec_Public_Static_UInt32_UInt64_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33131, XrefRangeEnd = 33135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetTextNum(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextNum_Private_Static_UInt32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint GetAlphabetNum(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAlphabetNum_Private_Static_UInt32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ParamTransfer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
