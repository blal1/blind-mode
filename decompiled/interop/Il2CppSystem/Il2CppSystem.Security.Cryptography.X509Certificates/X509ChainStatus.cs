using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

public sealed class X509ChainStatus : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_X509ChainStatusFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_X509ChainStatusFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_StatusInformation_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0;

	public unsafe X509ChainStatusFlags status
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status);
			return *(X509ChainStatusFlags*)num;
		}
		set
		{
			*(X509ChainStatusFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status)) = value;
		}
	}

	public unsafe string info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe X509ChainStatusFlags Status
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Status_Public_get_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(X509ChainStatusFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Status_Public_set_Void_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string StatusInformation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StatusInformation_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static X509ChainStatus()
	{
		Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatus");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr);
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "status");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "info");
		NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665171);
		NativeMethodInfoPtr_get_Status_Public_get_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665172);
		NativeMethodInfoPtr_set_Status_Public_set_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665173);
		NativeMethodInfoPtr_set_StatusInformation_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665174);
		NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665175);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 880483, RefRangeEnd = 880485, XrefRangeStart = 880481, XrefRangeEnd = 880483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509ChainStatus(X509ChainStatusFlags flag)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 880488, RefRangeEnd = 880493, XrefRangeStart = 880485, XrefRangeEnd = 880488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetInformation(X509ChainStatusFlags flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public X509ChainStatus(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public X509ChainStatus()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
	{
	}
}
