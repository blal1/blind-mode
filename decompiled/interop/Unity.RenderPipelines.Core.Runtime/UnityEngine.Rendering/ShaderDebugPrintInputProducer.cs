using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class ShaderDebugPrintInputProducer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_ShaderDebugPrintInput_0;

	static ShaderDebugPrintInputProducer()
	{
		Il2CppClassPointerStore<ShaderDebugPrintInputProducer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderDebugPrintInputProducer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintInputProducer>.NativeClassPtr);
		NativeMethodInfoPtr_Get_Public_Static_ShaderDebugPrintInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInputProducer>.NativeClassPtr, 100665140);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036188, XrefRangeEnd = 1036200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShaderDebugPrintInput Get()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_ShaderDebugPrintInput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShaderDebugPrintInput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ShaderDebugPrintInputProducer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
