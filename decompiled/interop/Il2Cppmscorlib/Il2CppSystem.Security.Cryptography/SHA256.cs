using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public class SHA256 : HashAlgorithm
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA256_0;

	static SHA256()
	{
		Il2CppClassPointerStore<SHA256>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100669436);
		NativeMethodInfoPtr_Create_Public_Static_SHA256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100669437);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786643, XrefRangeEnd = 786644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SHA256()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 786648, RefRangeEnd = 786650, XrefRangeStart = 786644, XrefRangeEnd = 786648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SHA256 Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_SHA256_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SHA256>(intPtr2) : null;
	}

	public SHA256(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
