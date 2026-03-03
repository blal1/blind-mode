using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.X509.Extensions;

public class AuthorityKeyIdentifierExtension : X509Extension
{
	private static readonly IntPtr NativeFieldInfoPtr_aki;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0;

	private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe Il2CppStructArray<byte> aki
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aki);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aki)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> Identifier
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692802, RefRangeEnd = 692803, XrefRangeStart = 692799, XrefRangeEnd = 692802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Identifier_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
	}

	static AuthorityKeyIdentifierExtension()
	{
		Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509.Extensions", "AuthorityKeyIdentifierExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr);
		NativeFieldInfoPtr_aki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, "aki");
		NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_get_Identifier_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr, 100663554);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 692765, RefRangeEnd = 692766, XrefRangeStart = 692764, XrefRangeEnd = 692765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AuthorityKeyIdentifierExtension(X509Extension extension)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorityKeyIdentifierExtension>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extension);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692766, XrefRangeEnd = 692776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Decode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692776, XrefRangeEnd = 692799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Encode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692803, XrefRangeEnd = 692824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AuthorityKeyIdentifierExtension(IntPtr pointer)
		: base(pointer)
	{
	}
}
