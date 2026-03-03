using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography;

public class MD2 : HashAlgorithm
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD2_0;

	static MD2()
	{
		Il2CppClassPointerStore<MD2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663682);
		NativeMethodInfoPtr_Create_Public_Static_MD2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663683);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693690, XrefRangeEnd = 693691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MD2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693691, XrefRangeEnd = 693708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MD2 Create()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_MD2_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MD2>(intPtr2) : null;
	}

	public MD2(IntPtr pointer)
		: base(pointer)
	{
	}
}
