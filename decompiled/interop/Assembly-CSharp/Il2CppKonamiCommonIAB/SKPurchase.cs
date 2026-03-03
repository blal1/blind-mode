using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppKonamiCommonIAB;

public sealed class SKPurchase : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_result;

	private static readonly System.IntPtr NativeFieldInfoPtr_productIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_transactionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_jws;

	private static readonly System.IntPtr NativeFieldInfoPtr_appUsername;

	public unsafe int result
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result)) = value;
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

	public unsafe string transactionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transactionId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transactionId)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string jws
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jws);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jws)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string appUsername
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appUsername);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appUsername)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SKPurchase()
	{
		Il2CppClassPointerStore<SKPurchase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "KonamiCommonIAB", "SKPurchase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr);
		NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr, "result");
		NativeFieldInfoPtr_productIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr, "productIdentifier");
		NativeFieldInfoPtr_transactionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr, "transactionId");
		NativeFieldInfoPtr_jws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr, "jws");
		NativeFieldInfoPtr_appUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr, "appUsername");
	}

	public SKPurchase(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SKPurchase()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SKPurchase>.NativeClassPtr))
	{
	}
}
