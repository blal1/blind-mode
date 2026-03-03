using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class StallMarkerAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	private static readonly IntPtr NativeFieldInfoPtr_HasProgressMarkup;

	private static readonly IntPtr NativeFieldInfoPtr_Duration;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateStallMarkerAnalytic_Internal_Static_StallMarkerAnalytic_0;

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool HasProgressMarkup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasProgressMarkup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasProgressMarkup)) = value;
		}
	}

	public unsafe double Duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration)) = value;
		}
	}

	static StallMarkerAnalytic()
	{
		Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "StallMarkerAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_HasProgressMarkup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr, "HasProgressMarkup");
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr, "Duration");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_CreateStallMarkerAnalytic_Internal_Static_StallMarkerAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr, 100663357);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407939, XrefRangeEnd = 1407944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StallMarkerAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StallMarkerAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407944, XrefRangeEnd = 1407952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StallMarkerAnalytic CreateStallMarkerAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStallMarkerAnalytic_Internal_Static_StallMarkerAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<StallMarkerAnalytic>(intPtr2) : null;
	}

	public StallMarkerAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
