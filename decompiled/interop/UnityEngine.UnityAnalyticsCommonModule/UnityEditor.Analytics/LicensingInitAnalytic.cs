using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class LicensingInitAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_licensingProtocolVersion;

	private static readonly IntPtr NativeFieldInfoPtr_licensingClientVersion;

	private static readonly IntPtr NativeFieldInfoPtr_channelType;

	private static readonly IntPtr NativeFieldInfoPtr_initTime;

	private static readonly IntPtr NativeFieldInfoPtr_isLegacy;

	private static readonly IntPtr NativeFieldInfoPtr_sessionId;

	private static readonly IntPtr NativeFieldInfoPtr_correlationId;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateLicensingInitAnalytic_Internal_Static_LicensingInitAnalytic_0;

	public unsafe string licensingProtocolVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensingProtocolVersion);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensingProtocolVersion)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string licensingClientVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensingClientVersion);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensingClientVersion)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string channelType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelType);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelType)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe double initTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTime)) = value;
		}
	}

	public unsafe bool isLegacy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLegacy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLegacy)) = value;
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

	static LicensingInitAnalytic()
	{
		Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "LicensingInitAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_licensingProtocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "licensingProtocolVersion");
		NativeFieldInfoPtr_licensingClientVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "licensingClientVersion");
		NativeFieldInfoPtr_channelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "channelType");
		NativeFieldInfoPtr_initTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "initTime");
		NativeFieldInfoPtr_isLegacy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "isLegacy");
		NativeFieldInfoPtr_sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "sessionId");
		NativeFieldInfoPtr_correlationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, "correlationId");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_CreateLicensingInitAnalytic_Internal_Static_LicensingInitAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr, 100663322);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407715, XrefRangeEnd = 1407720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LicensingInitAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LicensingInitAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407720, XrefRangeEnd = 1407728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LicensingInitAnalytic CreateLicensingInitAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLicensingInitAnalytic_Internal_Static_LicensingInitAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<LicensingInitAnalytic>(intPtr2) : null;
	}

	public LicensingInitAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
