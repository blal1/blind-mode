using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class CollabOperationAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_category;

	private static readonly IntPtr NativeFieldInfoPtr_operation;

	private static readonly IntPtr NativeFieldInfoPtr_result;

	private static readonly IntPtr NativeFieldInfoPtr_start_ts;

	private static readonly IntPtr NativeFieldInfoPtr_duration;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateCollabOperationAnalytic_Internal_Static_CollabOperationAnalytic_0;

	public unsafe string category
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string operation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_operation);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_operation)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string result
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe long start_ts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start_ts);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start_ts)) = value;
		}
	}

	public unsafe long duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = value;
		}
	}

	static CollabOperationAnalytic()
	{
		Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "CollabOperationAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, "category");
		NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, "operation");
		NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, "result");
		NativeFieldInfoPtr_start_ts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, "start_ts");
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, "duration");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_CreateCollabOperationAnalytic_Internal_Static_CollabOperationAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr, 100663318);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407689, XrefRangeEnd = 1407694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CollabOperationAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabOperationAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407694, XrefRangeEnd = 1407702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CollabOperationAnalytic CreateCollabOperationAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCollabOperationAnalytic_Internal_Static_CollabOperationAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CollabOperationAnalytic>(intPtr2) : null;
	}

	public CollabOperationAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
