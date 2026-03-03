using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct ManagedSpanWrapper
{
	private static readonly System.IntPtr NativeFieldInfoPtr_begin;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0;

	[FieldOffset(0)]
	public readonly System.IntPtr begin;

	[FieldOffset(8)]
	public readonly int length;

	static ManagedSpanWrapper()
	{
		Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "ManagedSpanWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_begin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, "begin");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, "length");
		NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, 100667244);
	}

	[CallerCount(463)]
	[CachedScanResults(RefRangeStart = 736483, RefRangeEnd = 736946, XrefRangeStart = 736483, XrefRangeEnd = 736946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ManagedSpanWrapper(void* begin, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)begin;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedSpanWrapper>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe static Il2CppSystem.Span<T> ToSpan<T>(ManagedSpanWrapper spanWrapper)
	{
		return new Il2CppSystem.Span<T>((void*)spanWrapper.begin, spanWrapper.length);
	}

	public unsafe static Il2CppSystem.ReadOnlySpan<T> ToReadOnlySpan<T>(ManagedSpanWrapper spanWrapper)
	{
		return new Il2CppSystem.ReadOnlySpan<T>((void*)spanWrapper.begin, spanWrapper.length);
	}
}
