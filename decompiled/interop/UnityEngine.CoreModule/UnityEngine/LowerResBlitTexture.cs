using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public class LowerResBlitTexture : Object
{
	private static readonly IntPtr NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0;

	static LowerResBlitTexture()
	{
		Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LowerResBlitTexture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr);
		NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr, 100666653);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LowerResBlitTextureDontStripMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LowerResBlitTexture(IntPtr pointer)
		: base(pointer)
	{
	}
}
