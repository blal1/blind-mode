using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

public static class X509Pal : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_X509PalImpl_0;

	public unsafe static X509PalImpl Instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862386, RefRangeEnd = 862388, XrefRangeStart = 862373, XrefRangeEnd = 862386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_X509PalImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr2) : null;
		}
	}

	static X509Pal()
	{
		Il2CppClassPointerStore<X509Pal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "X509Pal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Pal>.NativeClassPtr);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Pal>.NativeClassPtr, 100663314);
	}

	public X509Pal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
