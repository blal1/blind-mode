using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class TileSizeExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_TileSize_0;

	static TileSizeExtensions()
	{
		Il2CppClassPointerStore<TileSizeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TileSizeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileSizeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_IsValid_Public_Static_Boolean_TileSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileSizeExtensions>.NativeClassPtr, 100665617);
	}

	[CallerCount(0)]
	public unsafe static bool IsValid(this TileSize tileSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Static_Boolean_TileSize_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TileSizeExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
