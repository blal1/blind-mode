using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public class MD5 : HashAlgorithm
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_MD5_0;

	static MD5()
	{
		Il2CppClassPointerStore<MD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100669339);
		NativeMethodInfoPtr_Create_Public_Static_MD5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5>.NativeClassPtr, 100669340);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 785863, RefRangeEnd = 785864, XrefRangeStart = 785862, XrefRangeEnd = 785863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MD5()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 785868, RefRangeEnd = 785873, XrefRangeStart = 785864, XrefRangeEnd = 785868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MD5 Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_MD5_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MD5>(intPtr2) : null;
	}

	public MD5(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
