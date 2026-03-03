using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public sealed class InspectorOrderAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr__m_inspectorSort_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__m_sortDirection_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0;

	public unsafe InspectorSort _m_inspectorSort_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__m_inspectorSort_k__BackingField);
			return *(InspectorSort*)num;
		}
		set
		{
			*(InspectorSort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__m_inspectorSort_k__BackingField)) = value;
		}
	}

	public unsafe InspectorSortDirection _m_sortDirection_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__m_sortDirection_k__BackingField);
			return *(InspectorSortDirection*)num;
		}
		set
		{
			*(InspectorSortDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__m_sortDirection_k__BackingField)) = value;
		}
	}

	public unsafe InspectorSort m_inspectorSort
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InspectorSort*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_m_inspectorSort_k__BackingField = value;
		}
	}

	public unsafe InspectorSortDirection m_sortDirection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InspectorSortDirection*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_m_sortDirection_k__BackingField = value;
		}
	}

	static InspectorOrderAttribute()
	{
		Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "InspectorOrderAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__m_inspectorSort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_inspectorSort>k__BackingField");
		NativeFieldInfoPtr__m_sortDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_sortDirection>k__BackingField");
		NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100666382);
		NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100666383);
	}

	public InspectorOrderAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
