using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Cryptography;

public class DSASignatureDescription : SignatureDescription
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DSASignatureDescription()
	{
		Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr, 100669503);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787137, XrefRangeEnd = 787150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DSASignatureDescription()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DSASignatureDescription(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
