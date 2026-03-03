using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public class SHA512 : HashAlgorithm
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA512_0;

	static SHA512()
	{
		Il2CppClassPointerStore<SHA512>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA512");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA512>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100669474);
		NativeMethodInfoPtr_Create_Public_Static_SHA512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100669475);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786947, XrefRangeEnd = 786948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SHA512()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA512>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 786952, RefRangeEnd = 786955, XrefRangeStart = 786948, XrefRangeEnd = 786952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SHA512 Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_SHA512_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SHA512>(intPtr2) : null;
	}

	public SHA512(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
