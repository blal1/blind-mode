using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization;

[StructLayout(LayoutKind.Explicit)]
public struct HebrewNumberParsingContext
{
	private static readonly System.IntPtr NativeFieldInfoPtr_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_result;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	[FieldOffset(0)]
	public HebrewNumber.HS state;

	[FieldOffset(4)]
	public int result;

	static HebrewNumberParsingContext()
	{
		Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumberParsingContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr);
		NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "state");
		NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "result");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, 100672795);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817657, RefRangeEnd = 817658, XrefRangeStart = 817657, XrefRangeEnd = 817657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HebrewNumberParsingContext(int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
