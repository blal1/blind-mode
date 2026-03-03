using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public class SHA1 : HashAlgorithm
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA1_0;

	static SHA1()
	{
		Il2CppClassPointerStore<SHA1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100669425);
		NativeMethodInfoPtr_Create_Public_Static_SHA1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100669426);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 786218, RefRangeEnd = 786219, XrefRangeStart = 786218, XrefRangeEnd = 786219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SHA1()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 786586, RefRangeEnd = 786593, XrefRangeStart = 786582, XrefRangeEnd = 786586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SHA1 Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_SHA1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SHA1>(intPtr2) : null;
	}

	public SHA1(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
