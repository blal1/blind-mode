using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Buffers.Text;

public static class FormattingHelpers : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountHexDigits_Public_Static_Int32_UInt64_0;

	static FormattingHelpers()
	{
		Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers.Text", "FormattingHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr, 100674386);
		NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr, 100674387);
		NativeMethodInfoPtr_CountHexDigits_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingHelpers>.NativeClassPtr, 100674388);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 833626, RefRangeEnd = 833630, XrefRangeStart = 833625, XrefRangeEnd = 833626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CountDigits(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int CountDigits(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountDigits_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int CountHexDigits(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountHexDigits_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FormattingHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
