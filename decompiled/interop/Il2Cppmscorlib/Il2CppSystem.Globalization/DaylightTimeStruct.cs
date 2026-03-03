using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization;

[StructLayout(LayoutKind.Explicit)]
public struct DaylightTimeStruct
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Start;

	private static readonly System.IntPtr NativeFieldInfoPtr_End;

	private static readonly System.IntPtr NativeFieldInfoPtr_Delta;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_DateTime_TimeSpan_0;

	[FieldOffset(0)]
	public readonly DateTime Start;

	[FieldOffset(8)]
	public readonly DateTime End;

	[FieldOffset(16)]
	public readonly TimeSpan Delta;

	static DaylightTimeStruct()
	{
		Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DaylightTimeStruct");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr);
		NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, "Start");
		NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, "End");
		NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, "Delta");
		NativeMethodInfoPtr__ctor_Public_Void_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, 100672794);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817656, RefRangeEnd = 817657, XrefRangeStart = 817656, XrefRangeEnd = 817656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DateTime_DateTime_TimeSpan_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
