using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography;

public class MD4 : HashAlgorithm
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD4_0;

	static MD4()
	{
		Il2CppClassPointerStore<MD4>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD4");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_Create_Public_Static_MD4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663628);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MD4()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD4>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698803, RefRangeEnd = 698804, XrefRangeStart = 698782, XrefRangeEnd = 698803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MD4 Create()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_MD4_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MD4>(intPtr2) : null;
	}

	public MD4(IntPtr pointer)
		: base(pointer)
	{
	}
}
