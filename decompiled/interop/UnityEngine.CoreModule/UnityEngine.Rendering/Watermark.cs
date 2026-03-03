using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class Watermark : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_0;

	static Watermark()
	{
		Il2CppClassPointerStore<Watermark>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "Watermark");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Watermark>.NativeClassPtr);
		NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Watermark>.NativeClassPtr, 100668290);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237216, RefRangeEnd = 1237217, XrefRangeStart = 1237214, XrefRangeEnd = 1237216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVisible()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Watermark(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
