using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography;

public class HMACMD5 : HMAC
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	static HMACMD5()
	{
		Il2CppClassPointerStore<HMACMD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACMD5");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100669295);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100669296);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 785543, RefRangeEnd = 785544, XrefRangeStart = 785527, XrefRangeEnd = 785543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HMACMD5()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 785559, RefRangeEnd = 785561, XrefRangeStart = 785544, XrefRangeEnd = 785559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HMACMD5(Il2CppStructArray<byte> key)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HMACMD5(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
