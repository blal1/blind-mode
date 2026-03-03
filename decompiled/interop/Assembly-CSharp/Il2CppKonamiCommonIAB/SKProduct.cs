using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppKonamiCommonIAB;

public sealed class SKProduct : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_localizedDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_localizedTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_currency;

	private static readonly System.IntPtr NativeFieldInfoPtr_productIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayedPrice;

	private static readonly System.IntPtr NativeMethodInfoPtr_print_Public_Void_String_0;

	public unsafe string localizedDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedDescription)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string localizedTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedTitle)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe float price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = value;
		}
	}

	public unsafe string currency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currency);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currency)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string productIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productIdentifier)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string displayedPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayedPrice);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayedPrice)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SKProduct()
	{
		Il2CppClassPointerStore<SKProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "KonamiCommonIAB", "SKProduct");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SKProduct>.NativeClassPtr);
		NativeFieldInfoPtr_localizedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, "localizedDescription");
		NativeFieldInfoPtr_localizedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, "localizedTitle");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, "price");
		NativeFieldInfoPtr_currency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, "currency");
		NativeFieldInfoPtr_productIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, "productIdentifier");
		NativeFieldInfoPtr_displayedPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, "displayedPrice");
		NativeMethodInfoPtr_print_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SKProduct>.NativeClassPtr, 100665102);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void print(string header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_print_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SKProduct(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SKProduct()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SKProduct>.NativeClassPtr))
	{
	}
}
