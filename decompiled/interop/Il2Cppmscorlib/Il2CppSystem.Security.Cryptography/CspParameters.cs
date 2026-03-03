using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Cryptography;

public sealed class CspParameters : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ProviderType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProviderName;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyContainerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_flags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0;

	public unsafe int ProviderType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProviderType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProviderType)) = value;
		}
	}

	public unsafe string ProviderName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProviderName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProviderName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string KeyContainerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyContainerName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyContainerName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int KeyNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyNumber)) = value;
		}
	}

	public unsafe int m_flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_flags);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_flags)) = value;
		}
	}

	public unsafe CspProviderFlags Flags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CspProviderFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 785033, RefRangeEnd = 785039, XrefRangeStart = 785033, XrefRangeEnd = 785033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static CspParameters()
	{
		Il2CppClassPointerStore<CspParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CspParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CspParameters>.NativeClassPtr);
		NativeFieldInfoPtr_ProviderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderType");
		NativeFieldInfoPtr_ProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderName");
		NativeFieldInfoPtr_KeyContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyContainerName");
		NativeFieldInfoPtr_KeyNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyNumber");
		NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "m_flags");
		NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669250);
		NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669251);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669252);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669253);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669254);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669255);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 785042, RefRangeEnd = 785043, XrefRangeStart = 785039, XrefRangeEnd = 785042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CspParameters()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 785046, RefRangeEnd = 785048, XrefRangeStart = 785043, XrefRangeEnd = 785046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CspParameters(int dwTypeIn)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dwTypeIn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 785051, RefRangeEnd = 785054, XrefRangeStart = 785048, XrefRangeEnd = 785051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dwTypeIn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strProviderNameIn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strContainerNameIn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785054, XrefRangeEnd = 785057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&providerType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(providerName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(keyContainerName);
		*(CspProviderFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CspParameters(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
