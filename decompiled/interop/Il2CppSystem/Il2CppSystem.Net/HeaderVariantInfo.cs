using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net;

public sealed class HeaderVariantInfo : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_variant;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0;

	public unsafe string m_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe CookieVariant m_variant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_variant);
			return *(CookieVariant*)num;
		}
		set
		{
			*(CookieVariant*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_variant)) = value;
		}
	}

	public unsafe string Name
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe CookieVariant Variant
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CookieVariant*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static HeaderVariantInfo()
	{
		Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderVariantInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_name");
		NativeFieldInfoPtr_m_variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_variant");
		NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100666438);
		NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100666439);
		NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100666440);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 767829, RefRangeEnd = 767852, XrefRangeStart = 767829, XrefRangeEnd = 767852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeaderVariantInfo(string name, CookieVariant variant)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(CookieVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HeaderVariantInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HeaderVariantInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
	{
	}
}
