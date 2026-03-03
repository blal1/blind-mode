using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

public static class ColorUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CompareColors_Internal_Static_Boolean_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyColors_Internal_Static_Color32_Color32_Color32_0;

	static ColorUtilities()
	{
		Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "ColorUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_CompareColors_Internal_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_MultiplyColors_Internal_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663347);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1274547, RefRangeEnd = 1274548, XrefRangeStart = 1274547, XrefRangeEnd = 1274547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareColors(Color32 a, Color32 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareColors_Internal_Static_Boolean_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1274548, RefRangeEnd = 1274553, XrefRangeStart = 1274548, XrefRangeEnd = 1274548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 MultiplyColors(Color32 c1, Color32 c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyColors_Internal_Static_Color32_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ColorUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
