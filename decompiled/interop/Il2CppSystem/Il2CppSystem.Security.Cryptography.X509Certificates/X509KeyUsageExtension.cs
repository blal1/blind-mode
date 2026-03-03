using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

public sealed class X509KeyUsageExtension : X509Extension
{
	private static readonly System.IntPtr NativeFieldInfoPtr_oid;

	private static readonly System.IntPtr NativeFieldInfoPtr_friendlyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_all;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyUsages;

	private static readonly System.IntPtr NativeFieldInfoPtr__status;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;

	public unsafe static string oid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_oid, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_oid, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string friendlyName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_friendlyName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static X509KeyUsageFlags all
	{
		get
		{
			Unsafe.SkipInit(out X509KeyUsageFlags result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_all, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_all, (void*)(&value));
		}
	}

	public unsafe X509KeyUsageFlags _keyUsages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyUsages);
			return *(X509KeyUsageFlags*)num;
		}
		set
		{
			*(X509KeyUsageFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyUsages)) = value;
		}
	}

	public unsafe AsnDecodeStatus _status
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__status);
			return *(AsnDecodeStatus*)num;
		}
		set
		{
			*(AsnDecodeStatus*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__status)) = value;
		}
	}

	public unsafe X509KeyUsageFlags KeyUsages
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 880796, RefRangeEnd = 880799, XrefRangeStart = 880796, XrefRangeEnd = 880796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(X509KeyUsageFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static X509KeyUsageExtension()
	{
		Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr);
		NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "oid");
		NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "friendlyName");
		NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "all");
		NativeFieldInfoPtr__keyUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_keyUsages");
		NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_status");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665208);
		NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665209);
		NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665210);
		NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665211);
		NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665212);
		NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665213);
		NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665214);
		NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665215);
		NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100665216);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880761, XrefRangeEnd = 880771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509KeyUsageExtension()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 880783, RefRangeEnd = 880784, XrefRangeStart = 880771, XrefRangeEnd = 880783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encodedKeyUsage);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &critical;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880784, XrefRangeEnd = 880796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&keyUsages);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &critical;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880799, XrefRangeEnd = 880815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asnEncodedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(X509KeyUsageFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 880823, RefRangeEnd = 880825, XrefRangeStart = 880815, XrefRangeEnd = 880823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extension);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AsnDecodeStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 880839, RefRangeEnd = 880840, XrefRangeStart = 880825, XrefRangeEnd = 880839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> Encode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880840, XrefRangeEnd = 880920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString(bool multiLine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&multiLine);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public X509KeyUsageExtension(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
