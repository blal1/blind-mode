using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts;

public sealed class InputDeviceBuilder : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct RefInstance
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		static RefInstance()
		{
			Il2CppClassPointerStore<RefInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "RefInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefInstance>.NativeClassPtr);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefInstance>.NativeClassPtr, 100668331);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1012796, RefRangeEnd = 1012802, XrefRangeStart = 1012789, XrefRangeEnd = 1012796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefInstance>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Device;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayoutCacheRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildControlOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateOffsetToControlMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StringBuilder;

	private static readonly System.IntPtr NativeFieldInfoPtr_kSizeForControlUsingStateFromOtherControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InstanceRef;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_InternedString_InternedString_InputDeviceDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Public_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateLayout_Private_InputControl_InternedString_InternedString_InternedString_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateLayout_Private_InputControl_InputControlLayout_InternedString_InternedString_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChildControls_Private_Void_InputControlLayout_InternedString_InputControl_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChildControl_Private_InputControl_InputControlLayout_InternedString_InputControl_byref_Boolean_ControlItem_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertChildControlOverride_Private_Void_InputControl_byref_ControlItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChildControlOverridePath_Private_String_InputControl_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChildControlIfMissing_Private_Void_InputControlLayout_InternedString_InputControl_byref_Boolean_byref_ControlItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertChildControl_Private_InputControl_InputControlLayout_InternedString_InputControl_byref_Boolean_byref_ControlItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyUseStateFrom_Private_Static_Void_InputControl_byref_ControlItem_InputControlLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShiftChildIndicesInHierarchyOneUp_Private_Static_Void_InputDevice_Int32_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayName_Private_Void_InputControl_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddParentDisplayNameRecursive_Private_Static_Void_InputControl_StringBuilder_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddProcessors_Private_Static_Void_InputControl_byref_ControlItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFormat_Private_Static_Void_InputControl_ControlItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindOrLoadLayout_Private_Static_InputControlLayout_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStateLayout_Private_Static_Void_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeControlHierarchy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeControlHierarchyRecursive_Private_Void_InputControl_Int32_Il2CppReferenceArray_1_InputControl_Boolean_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertControlBitRangeNode_Private_Void_byref_ControlBitRangeNode_InputControl_byref_Int32_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBestMidPoint_Private_UInt16_ControlBitRangeNode_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlToNode_Private_Void_InputControl_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChildren_Private_Void_byref_ControlBitRangeNode_ControlBitRangeNode_ControlBitRangeNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControlIndex_Private_UInt16_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_byref_InputDeviceBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ref_Internal_Static_RefInstance_0;

	public unsafe InputDevice m_Device
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Device);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Device)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputControlLayout.CacheRefInstance m_LayoutCacheRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutCacheRef);
			return *(InputControlLayout.CacheRefInstance*)num;
		}
		set
		{
			*(InputControlLayout.CacheRefInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutCacheRef)) = value;
		}
	}

	public unsafe Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildControlOverrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, InputControlLayout.ControlItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildControlOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<uint> m_StateOffsetToControlMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StringBuilder m_StringBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StringBuilder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StringBuilder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static uint kSizeForControlUsingStateFromOtherControl
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSizeForControlUsingStateFromOtherControl, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSizeForControlUsingStateFromOtherControl, (void*)(&value));
		}
	}

	public unsafe static InputDeviceBuilder s_Instance
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)intPtr);
			return new InputDeviceBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static int s_InstanceRef
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InstanceRef, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InstanceRef, (void*)(&value));
		}
	}

	public unsafe static ref InputDeviceBuilder instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1013456, RefRangeEnd = 1013458, XrefRangeStart = 1013454, XrefRangeEnd = 1013456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Internal_Static_get_byref_InputDeviceBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(InputDeviceBuilder*)intPtr2;
		}
	}

	static InputDeviceBuilder()
	{
		Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Layouts", "InputDeviceBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_m_Device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "m_Device");
		NativeFieldInfoPtr_m_LayoutCacheRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "m_LayoutCacheRef");
		NativeFieldInfoPtr_m_ChildControlOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "m_ChildControlOverrides");
		NativeFieldInfoPtr_m_StateOffsetToControlMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "m_StateOffsetToControlMap");
		NativeFieldInfoPtr_m_StringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "m_StringBuilder");
		NativeFieldInfoPtr_kSizeForControlUsingStateFromOtherControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "kSizeForControlUsingStateFromOtherControl");
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_s_InstanceRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, "s_InstanceRef");
		NativeMethodInfoPtr_Setup_Public_Void_InternedString_InternedString_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668302);
		NativeMethodInfoPtr_Finish_Public_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668303);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668304);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668305);
		NativeMethodInfoPtr_InstantiateLayout_Private_InputControl_InternedString_InternedString_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668306);
		NativeMethodInfoPtr_InstantiateLayout_Private_InputControl_InputControlLayout_InternedString_InternedString_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668307);
		NativeMethodInfoPtr_AddChildControls_Private_Void_InputControlLayout_InternedString_InputControl_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668308);
		NativeMethodInfoPtr_AddChildControl_Private_InputControl_InputControlLayout_InternedString_InputControl_byref_Boolean_ControlItem_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668309);
		NativeMethodInfoPtr_InsertChildControlOverride_Private_Void_InputControl_byref_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668310);
		NativeMethodInfoPtr_ChildControlOverridePath_Private_String_InputControl_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668311);
		NativeMethodInfoPtr_AddChildControlIfMissing_Private_Void_InputControlLayout_InternedString_InputControl_byref_Boolean_byref_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668312);
		NativeMethodInfoPtr_InsertChildControl_Private_InputControl_InputControlLayout_InternedString_InputControl_byref_Boolean_byref_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668313);
		NativeMethodInfoPtr_ApplyUseStateFrom_Private_Static_Void_InputControl_byref_ControlItem_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668314);
		NativeMethodInfoPtr_ShiftChildIndicesInHierarchyOneUp_Private_Static_Void_InputDevice_Int32_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668315);
		NativeMethodInfoPtr_SetDisplayName_Private_Void_InputControl_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668316);
		NativeMethodInfoPtr_AddParentDisplayNameRecursive_Private_Static_Void_InputControl_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668317);
		NativeMethodInfoPtr_AddProcessors_Private_Static_Void_InputControl_byref_ControlItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668318);
		NativeMethodInfoPtr_SetFormat_Private_Static_Void_InputControl_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668319);
		NativeMethodInfoPtr_FindOrLoadLayout_Private_Static_InputControlLayout_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668320);
		NativeMethodInfoPtr_ComputeStateLayout_Private_Static_Void_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668321);
		NativeMethodInfoPtr_FinalizeControlHierarchy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668322);
		NativeMethodInfoPtr_FinalizeControlHierarchyRecursive_Private_Void_InputControl_Int32_Il2CppReferenceArray_1_InputControl_Boolean_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668323);
		NativeMethodInfoPtr_InsertControlBitRangeNode_Private_Void_byref_ControlBitRangeNode_InputControl_byref_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668324);
		NativeMethodInfoPtr_GetBestMidPoint_Private_UInt16_ControlBitRangeNode_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668325);
		NativeMethodInfoPtr_AddControlToNode_Private_Void_InputControl_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668326);
		NativeMethodInfoPtr_AddChildren_Private_Void_byref_ControlBitRangeNode_ControlBitRangeNode_ControlBitRangeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668327);
		NativeMethodInfoPtr_GetControlIndex_Private_UInt16_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668328);
		NativeMethodInfoPtr_get_instance_Internal_Static_get_byref_InputDeviceBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668329);
		NativeMethodInfoPtr_Ref_Internal_Static_RefInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr, 100668330);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012824, RefRangeEnd = 1012825, XrefRangeStart = 1012802, XrefRangeEnd = 1012824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variants));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescription));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_InternedString_InternedString_InputDeviceDescription_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012866, RefRangeEnd = 1012867, XrefRangeStart = 1012825, XrefRangeEnd = 1012866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputDevice Finish()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finish_Public_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012867, XrefRangeEnd = 1012868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012873, RefRangeEnd = 1012874, XrefRangeStart = 1012868, XrefRangeEnd = 1012873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012881, RefRangeEnd = 1012882, XrefRangeStart = 1012874, XrefRangeEnd = 1012881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variants));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantiateLayout_Private_InputControl_InternedString_InternedString_InternedString_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1012932, RefRangeEnd = 1012934, XrefRangeStart = 1012882, XrefRangeEnd = 1012932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variants));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantiateLayout_Private_InputControl_InputControlLayout_InternedString_InternedString_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012981, RefRangeEnd = 1012982, XrefRangeStart = 1012934, XrefRangeEnd = 1012981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variants));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref haveChildrenUsingStateFromOtherControls);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChildControls_Private_Void_InputControlLayout_InternedString_InputControl_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1013065, RefRangeEnd = 1013068, XrefRangeStart = 1012982, XrefRangeEnd = 1013065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variants));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref haveChildrenUsingStateFromOtherControls);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem));
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &childIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(nameOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChildControl_Private_InputControl_InputControlLayout_InternedString_InputControl_byref_Boolean_ControlItem_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013087, RefRangeEnd = 1013088, XrefRangeStart = 1013068, XrefRangeEnd = 1013087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertChildControlOverride_Private_Void_InputControl_byref_ControlItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013088, XrefRangeEnd = 1013091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ChildControlOverridePath(InputControl parent, InternedString controlName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlName));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChildControlOverridePath_Private_String_InputControl_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013091, XrefRangeEnd = 1013095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variants));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref haveChildrenUsingStateFromOtherControls);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChildControlIfMissing_Private_Void_InputControlLayout_InternedString_InputControl_byref_Boolean_byref_ControlItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1013107, RefRangeEnd = 1013109, XrefRangeStart = 1013095, XrefRangeEnd = 1013107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)variant));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref haveChildrenUsingStateFromOtherControls);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertChildControl_Private_InputControl_InputControlLayout_InternedString_InputControl_byref_Boolean_byref_ControlItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013118, RefRangeEnd = 1013119, XrefRangeStart = 1013109, XrefRangeEnd = 1013118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyUseStateFrom_Private_Static_Void_InputControl_byref_ControlItem_InputControlLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exceptControl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShiftChildIndicesInHierarchyOneUp_Private_Static_Void_InputDevice_Int32_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1013155, RefRangeEnd = 1013157, XrefRangeStart = 1013119, XrefRangeEnd = 1013155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(longDisplayNameFromLayout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(shortDisplayNameFromLayout);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortName;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisplayName_Private_Void_InputControl_String_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1013164, RefRangeEnd = 1013167, XrefRangeStart = 1013157, XrefRangeEnd = 1013164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringBuilder);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortName;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddParentDisplayNameRecursive_Private_Static_Void_InputControl_StringBuilder_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013184, RefRangeEnd = 1013185, XrefRangeStart = 1013167, XrefRangeEnd = 1013184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddProcessors_Private_Static_Void_InputControl_byref_ControlItem_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013185, XrefRangeEnd = 1013193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFormat_Private_Static_Void_InputControl_ControlItem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013193, XrefRangeEnd = 1013198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlLayout FindOrLoadLayout(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindOrLoadLayout_Private_Static_InputControlLayout_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1013291, RefRangeEnd = 1013294, XrefRangeStart = 1013198, XrefRangeEnd = 1013291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeStateLayout(InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeStateLayout_Private_Static_Void_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013312, RefRangeEnd = 1013313, XrefRangeStart = 1013294, XrefRangeEnd = 1013312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinalizeControlHierarchy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizeControlHierarchy_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1013343, RefRangeEnd = 1013345, XrefRangeStart = 1013313, XrefRangeEnd = 1013343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, Il2CppReferenceArray<InputControl> allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allControls);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &noisy;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dontReset;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref controlIndiciesNextFreeIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizeControlHierarchyRecursive_Private_Void_InputControl_Int32_Il2CppReferenceArray_1_InputControl_Boolean_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1013377, RefRangeEnd = 1013379, XrefRangeStart = 1013345, XrefRangeEnd = 1013377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertControlBitRangeNode(ref InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref controlIndiciesNextFreeIndex);
		*(ushort**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertControlBitRangeNode_Private_Void_byref_ControlBitRangeNode_InputControl_byref_Int32_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013440, RefRangeEnd = 1013441, XrefRangeStart = 1013379, XrefRangeEnd = 1013440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetBestMidPoint(InputDevice.ControlBitRangeNode parent, ushort startOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&parent);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBestMidPoint_Private_UInt16_ControlBitRangeNode_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1013446, RefRangeEnd = 1013448, XrefRangeStart = 1013441, XrefRangeEnd = 1013446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref controlIndiciesNextFreeIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodeIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlToNode_Private_Void_InputControl_byref_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013451, RefRangeEnd = 1013452, XrefRangeStart = 1013448, XrefRangeEnd = 1013451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChildren(ref InputDevice.ControlBitRangeNode parent, InputDevice.ControlBitRangeNode left, InputDevice.ControlBitRangeNode right)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref parent);
		*(InputDevice.ControlBitRangeNode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(InputDevice.ControlBitRangeNode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChildren_Private_Void_byref_ControlBitRangeNode_ControlBitRangeNode_ControlBitRangeNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1013453, RefRangeEnd = 1013454, XrefRangeStart = 1013452, XrefRangeEnd = 1013453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetControlIndex(InputControl control)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlIndex_Private_UInt16_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1013460, RefRangeEnd = 1013463, XrefRangeStart = 1013458, XrefRangeEnd = 1013460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RefInstance Ref()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ref_Internal_Static_RefInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RefInstance*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputDeviceBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InputDeviceBuilder()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceBuilder>.NativeClassPtr))
	{
	}
}
