using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Cryptography;

public class RSAPKCS1SignatureDescription : SignatureDescription
{
	private static readonly System.IntPtr NativeFieldInfoPtr__hashAlgorithm;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_0;

	public unsafe string _hashAlgorithm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hashAlgorithm);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hashAlgorithm)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static RSAPKCS1SignatureDescription()
	{
		Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr);
		NativeFieldInfoPtr__hashAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr, "_hashAlgorithm");
		NativeMethodInfoPtr__ctor_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr, 100669498);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 787112, RefRangeEnd = 787117, XrefRangeStart = 787100, XrefRangeEnd = 787112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureDescription>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hashAlgorithm);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(digestAlgorithm);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RSAPKCS1SignatureDescription(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
