using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class LicensingErrorAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_licensingErrorType;

	private static readonly IntPtr NativeFieldInfoPtr_additionalData;

	private static readonly IntPtr NativeFieldInfoPtr_errorMessage;

	private static readonly IntPtr NativeFieldInfoPtr_correlationId;

	private static readonly IntPtr NativeFieldInfoPtr_sessionId;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateLicensingErrorAnalytic_Internal_Static_LicensingErrorAnalytic_0;

	public unsafe string licensingErrorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensingErrorType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensingErrorType)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string additionalData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalData);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalData)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string errorMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorMessage)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string correlationId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_correlationId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_correlationId)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string sessionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sessionId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sessionId)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static LicensingErrorAnalytic()
	{
		Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "LicensingErrorAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_licensingErrorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, "licensingErrorType");
		NativeFieldInfoPtr_additionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, "additionalData");
		NativeFieldInfoPtr_errorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, "errorMessage");
		NativeFieldInfoPtr_correlationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, "correlationId");
		NativeFieldInfoPtr_sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, "sessionId");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_CreateLicensingErrorAnalytic_Internal_Static_LicensingErrorAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr, 100663320);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407702, XrefRangeEnd = 1407707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LicensingErrorAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LicensingErrorAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407707, XrefRangeEnd = 1407715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LicensingErrorAnalytic CreateLicensingErrorAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLicensingErrorAnalytic_Internal_Static_LicensingErrorAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<LicensingErrorAnalytic>(intPtr2) : null;
	}

	public LicensingErrorAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
