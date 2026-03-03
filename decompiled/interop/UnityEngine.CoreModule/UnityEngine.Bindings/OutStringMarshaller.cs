using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct OutStringMarshaller
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringAndDispose_Public_Static_String_ManagedSpanWrapper_0;

	static OutStringMarshaller()
	{
		Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "OutStringMarshaller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr);
		NativeMethodInfoPtr_GetStringAndDispose_Public_Static_String_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr, 100667246);
	}

	[CallerCount(72)]
	[CachedScanResults(RefRangeStart = 1228357, RefRangeEnd = 1228429, XrefRangeStart = 1228354, XrefRangeEnd = 1228357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStringAndDispose(ManagedSpanWrapper managedSpan)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&managedSpan);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringAndDispose_Public_Static_String_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static void UpdateStringAndDispose(ManagedSpanWrapper inSpanWrapper, ManagedSpanWrapper outSpanWrapper, ref string outString)
	{
		if (inSpanWrapper.begin != outSpanWrapper.begin)
		{
			outString = GetStringAndDispose(outSpanWrapper);
		}
	}
}
