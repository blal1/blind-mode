using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography;

public class RIPEMD160 : HashAlgorithm
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0;

	static RIPEMD160()
	{
		Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RIPEMD160");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100669386);
		NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100669387);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 786218, RefRangeEnd = 786219, XrefRangeStart = 786217, XrefRangeEnd = 786218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RIPEMD160()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 786223, RefRangeEnd = 786224, XrefRangeStart = 786219, XrefRangeEnd = 786223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RIPEMD160 Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RIPEMD160>(intPtr2) : null;
	}

	public RIPEMD160(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
