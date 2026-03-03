using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Utilities;

public static class SpriteUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCircleSprite_Public_Static_Sprite_Int32_Color32_0;

	static SpriteUtilities()
	{
		Il2CppClassPointerStore<SpriteUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "SpriteUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_CreateCircleSprite_Public_Static_Sprite_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteUtilities>.NativeClassPtr, 100669028);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1021497, RefRangeEnd = 1021498, XrefRangeStart = 1021481, XrefRangeEnd = 1021497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite CreateCircleSprite(int radius, Color32 colour)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&radius);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colour;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCircleSprite_Public_Static_Sprite_Int32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	public SpriteUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
