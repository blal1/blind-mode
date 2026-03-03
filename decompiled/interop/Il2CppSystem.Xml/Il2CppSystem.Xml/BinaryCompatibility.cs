using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml;

public static class BinaryCompatibility : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0;

	public unsafe static bool TargetsAtLeast_Desktop_V4_5_2
	{
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BinaryCompatibility()
	{
		Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinaryCompatibility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
		NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100665211);
	}

	public BinaryCompatibility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
