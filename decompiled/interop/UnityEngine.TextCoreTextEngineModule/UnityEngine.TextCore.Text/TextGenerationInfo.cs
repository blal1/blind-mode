using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

public static class TextGenerationInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_IntPtr_0;

	static TextGenerationInfo()
	{
		Il2CppClassPointerStore<TextGenerationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGenerationInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerationInfo>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationInfo>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationInfo>.NativeClassPtr, 100663878);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1283068, RefRangeEnd = 1283070, XrefRangeStart = 1283066, XrefRangeEnd = 1283068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1283072, RefRangeEnd = 1283073, XrefRangeStart = 1283070, XrefRangeEnd = 1283072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextGenerationInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
