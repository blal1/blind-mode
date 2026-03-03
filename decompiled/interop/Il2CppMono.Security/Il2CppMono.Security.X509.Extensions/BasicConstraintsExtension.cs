using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppMono.Security.X509.Extensions;

public class BasicConstraintsExtension : X509Extension
{
	private static readonly IntPtr NativeFieldInfoPtr_cA;

	private static readonly IntPtr NativeFieldInfoPtr_pathLenConstraint;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0;

	private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe bool cA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cA);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cA)) = value;
		}
	}

	public unsafe int pathLenConstraint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathLenConstraint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathLenConstraint)) = value;
		}
	}

	public unsafe bool CertificateAuthority
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BasicConstraintsExtension()
	{
		Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509.Extensions", "BasicConstraintsExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr);
		NativeFieldInfoPtr_cA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, "cA");
		NativeFieldInfoPtr_pathLenConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, "pathLenConstraint");
		NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr, 100663559);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 692765, RefRangeEnd = 692766, XrefRangeStart = 692765, XrefRangeEnd = 692766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasicConstraintsExtension(X509Extension extension)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicConstraintsExtension>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extension);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692824, XrefRangeEnd = 692833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Decode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Decode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692833, XrefRangeEnd = 692858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Encode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Encode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692858, XrefRangeEnd = 692887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public BasicConstraintsExtension(IntPtr pointer)
		: base(pointer)
	{
	}
}
