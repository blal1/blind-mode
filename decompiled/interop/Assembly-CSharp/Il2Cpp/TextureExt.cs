using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public static class TextureExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToTexture2D_Public_Static_Texture2D_Texture_0;

	static TextureExt()
	{
		Il2CppClassPointerStore<TextureExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TextureExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureExt>.NativeClassPtr);
		NativeMethodInfoPtr_ToTexture2D_Public_Static_Texture2D_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureExt>.NativeClassPtr, 100663308);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 25080, RefRangeEnd = 25082, XrefRangeStart = 25063, XrefRangeEnd = 25080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D ToTexture2D(this Texture self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTexture2D_Public_Static_Texture2D_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	public TextureExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
