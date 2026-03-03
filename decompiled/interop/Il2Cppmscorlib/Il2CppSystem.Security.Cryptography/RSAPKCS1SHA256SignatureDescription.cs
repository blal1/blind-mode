using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Cryptography;

public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RSAPKCS1SHA256SignatureDescription()
	{
		Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA256SignatureDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr, 100669500);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787122, XrefRangeEnd = 787127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RSAPKCS1SHA256SignatureDescription()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RSAPKCS1SHA256SignatureDescription(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
