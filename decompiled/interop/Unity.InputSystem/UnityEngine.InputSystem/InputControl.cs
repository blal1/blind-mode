using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class InputControl : Il2CppSystem.Object
{
	[OriginalName("Unity.InputSystem.dll", "", "ControlFlags")]
	[System.Flags]
	public enum ControlFlags
	{
		ConfigUpToDate = 1,
		IsNoisy = 2,
		IsSynthetic = 4,
		IsButton = 8,
		DontReset = 0x10,
		SetupFinished = 0x20,
		UsesStateFromOtherControl = 0x40
	}

	private sealed class MethodInfoStoreGeneric_TryGetChildControl_Public_TControl_String_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryGetChildControl_Public_TControl_String_0, Il2CppClassPointerStore<InputControl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetChildControl_Public_TControl_String_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetChildControl_Public_TControl_String_0, Il2CppClassPointerStore<InputControl>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateBlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayNameFromLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShortDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShortDisplayNameFromLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Layout;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Variants;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Device;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Parent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UsageCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UsageStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AliasCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AliasStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedValueIsStale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnprocessedCachedValueIsStale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MinValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OptimizedControlDataType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_displayName_Protected_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shortDisplayName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shortDisplayName_Protected_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_path_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_layout_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_variants_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_device_Public_get_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_parent_Public_get_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_children_Public_get_ReadOnlyArray_1_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usages_Public_get_ReadOnlyArray_1_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aliases_Public_get_ReadOnlyArray_1_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stateBlock_Public_get_InputStateBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_noisy_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_noisy_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_synthetic_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_synthetic_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_InputControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueType_Public_Abstract_Virtual_New_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueSizeInBytes_Public_Abstract_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebuggerDisplay_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateMagnitude_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_New_Single_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Abstract_Virtual_New_Object_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Abstract_Virtual_New_Object_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Abstract_Virtual_New_Void_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueFromBufferIntoState_Public_Virtual_New_Void_ptr_Void_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueFromObjectIntoState_Public_Virtual_New_Void_Object_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareValue_Public_Abstract_Virtual_New_Boolean_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetChildControl_Public_InputControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetChildControl_Public_TControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildControl_Public_InputControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildControl_Public_TControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshConfigurationIfNeeded_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentStatePtr_FamOrAssem_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_previousFrameStatePtr_FamOrAssem_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultStatePtr_FamOrAssem_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_noiseMaskPtr_FamOrAssem_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stateOffsetRelativeToDeviceRoot_FamOrAssem_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_optimizedControlDataType_Public_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_New_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParameterChanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOptimizedControlDataType_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOptimizedControlDataTypeRecursively_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureOptimizationTypeHasNotChanged_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSetupFinished_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isSetupFinished_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isButton_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isButton_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isConfigUpToDate_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isConfigUpToDate_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dontReset_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dontReset_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usesStateFromOtherControl_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_usesStateFromOtherControl_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasDefaultState_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallFinishSetupRecursive_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeChildPath_Internal_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BakeOffsetIntoStateBlockRecursive_Internal_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceIndex_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValueConsideredPressed_Internal_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddProcessor_Internal_Virtual_New_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsStale_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsStaleRecursively_Internal_Void_0;

	public unsafe InputStateBlock m_StateBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateBlock);
			return *(InputStateBlock*)num;
		}
		set
		{
			*(InputStateBlock*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateBlock)) = value;
		}
	}

	public unsafe InternedString m_Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name);
			return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string m_Path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Path)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_DisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_DisplayNameFromLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayNameFromLayout);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayNameFromLayout)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_ShortDisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShortDisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShortDisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_ShortDisplayNameFromLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShortDisplayNameFromLayout);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShortDisplayNameFromLayout)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe InternedString m_Layout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Layout);
			return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Layout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InternedString m_Variants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Variants);
			return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Variants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
		}
	}

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

	public unsafe InputControl m_Parent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Parent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Parent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_UsageCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsageCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsageCount)) = value;
		}
	}

	public unsafe int m_UsageStartIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsageStartIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsageStartIndex)) = value;
		}
	}

	public unsafe int m_AliasCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AliasCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AliasCount)) = value;
		}
	}

	public unsafe int m_AliasStartIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AliasStartIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AliasStartIndex)) = value;
		}
	}

	public unsafe int m_ChildCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildCount)) = value;
		}
	}

	public unsafe int m_ChildStartIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildStartIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildStartIndex)) = value;
		}
	}

	public unsafe ControlFlags m_ControlFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlFlags);
			return *(ControlFlags*)num;
		}
		set
		{
			*(ControlFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlFlags)) = value;
		}
	}

	public unsafe bool m_CachedValueIsStale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedValueIsStale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedValueIsStale)) = value;
		}
	}

	public unsafe bool m_UnprocessedCachedValueIsStale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnprocessedCachedValueIsStale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnprocessedCachedValueIsStale)) = value;
		}
	}

	public unsafe PrimitiveValue m_DefaultState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultState);
			return *(PrimitiveValue*)num;
		}
		set
		{
			*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultState)) = value;
		}
	}

	public unsafe PrimitiveValue m_MinValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinValue);
			return *(PrimitiveValue*)num;
		}
		set
		{
			*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinValue)) = value;
		}
	}

	public unsafe PrimitiveValue m_MaxValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxValue);
			return *(PrimitiveValue*)num;
		}
		set
		{
			*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxValue)) = value;
		}
	}

	public unsafe FourCC m_OptimizedControlDataType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OptimizedControlDataType);
			return *(FourCC*)num;
		}
		set
		{
			*(FourCC*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OptimizedControlDataType)) = value;
		}
	}

	public unsafe string name
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 972422, RefRangeEnd = 972432, XrefRangeStart = 972421, XrefRangeEnd = 972422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string displayName
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 972433, RefRangeEnd = 972440, XrefRangeStart = 972432, XrefRangeEnd = 972433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84623, RefRangeEnd = 84624, XrefRangeStart = 84623, XrefRangeEnd = 84624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_displayName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string shortDisplayName
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 972440, RefRangeEnd = 972445, XrefRangeStart = 972440, XrefRangeEnd = 972440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shortDisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84628, RefRangeEnd = 84632, XrefRangeStart = 84628, XrefRangeEnd = 84632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shortDisplayName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string path
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 972460, RefRangeEnd = 972478, XrefRangeStart = 972445, XrefRangeEnd = 972460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string layout
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 972479, RefRangeEnd = 972486, XrefRangeStart = 972478, XrefRangeEnd = 972479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layout_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string variants
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972486, XrefRangeEnd = 972487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_variants_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe InputDevice device
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_device_Public_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
		}
	}

	public unsafe InputControl parent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parent_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
		}
	}

	public unsafe ReadOnlyArray<InputControl> children
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 972490, RefRangeEnd = 972500, XrefRangeStart = 972487, XrefRangeEnd = 972490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_children_Public_get_ReadOnlyArray_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputControl>(pointer);
		}
	}

	public unsafe ReadOnlyArray<InternedString> usages
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 972503, RefRangeEnd = 972516, XrefRangeStart = 972500, XrefRangeEnd = 972503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usages_Public_get_ReadOnlyArray_1_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InternedString>(pointer);
		}
	}

	public unsafe ReadOnlyArray<InternedString> aliases
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972519, RefRangeEnd = 972521, XrefRangeStart = 972516, XrefRangeEnd = 972519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aliases_Public_get_ReadOnlyArray_1_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InternedString>(pointer);
		}
	}

	public unsafe InputStateBlock stateBlock
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739711, RefRangeEnd = 739712, XrefRangeStart = 739711, XrefRangeEnd = 739712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateBlock_Public_get_InputStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InputStateBlock*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool noisy
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 972521, RefRangeEnd = 972527, XrefRangeStart = 972521, XrefRangeEnd = 972521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_noisy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 972529, RefRangeEnd = 972535, XrefRangeStart = 972527, XrefRangeEnd = 972529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_noisy_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool synthetic
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972535, RefRangeEnd = 972536, XrefRangeStart = 972535, XrefRangeEnd = 972535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_synthetic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(121)]
		[CachedScanResults(RefRangeStart = 972536, RefRangeEnd = 972657, XrefRangeStart = 972536, XrefRangeEnd = 972536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_synthetic_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputControl this[string path]
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972657, XrefRangeEnd = 972660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_InputControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
		}
	}

	public unsafe virtual Il2CppSystem.Type valueType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_valueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
	}

	public unsafe virtual int valueSizeInBytes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_valueSizeInBytes_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float magnitude
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 972662, RefRangeEnd = 972669, XrefRangeStart = 972660, XrefRangeEnd = 972662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe void* currentStatePtr
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 972994, RefRangeEnd = 973020, XrefRangeStart = 972992, XrefRangeEnd = 972994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentStatePtr_FamOrAssem_get_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
	}

	public unsafe void* previousFrameStatePtr
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973022, RefRangeEnd = 973023, XrefRangeStart = 973020, XrefRangeEnd = 973022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_previousFrameStatePtr_FamOrAssem_get_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
	}

	public unsafe void* defaultStatePtr
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973023, XrefRangeEnd = 973025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultStatePtr_FamOrAssem_get_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
	}

	public unsafe void* noiseMaskPtr
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973025, XrefRangeEnd = 973027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_noiseMaskPtr_FamOrAssem_get_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
	}

	public unsafe uint stateOffsetRelativeToDeviceRoot
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 973030, RefRangeEnd = 973031, XrefRangeStart = 973027, XrefRangeEnd = 973030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateOffsetRelativeToDeviceRoot_FamOrAssem_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe FourCC optimizedControlDataType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_optimizedControlDataType_Public_get_FourCC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isSetupFinished
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSetupFinished_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(460)]
		[CachedScanResults(RefRangeStart = 973124, RefRangeEnd = 973584, XrefRangeStart = 973124, XrefRangeEnd = 973124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isSetupFinished_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isButton
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 973584, RefRangeEnd = 973588, XrefRangeStart = 973584, XrefRangeEnd = 973584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isButton_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(168)]
		[CachedScanResults(RefRangeStart = 973588, RefRangeEnd = 973756, XrefRangeStart = 973588, XrefRangeEnd = 973588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isButton_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isConfigUpToDate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isConfigUpToDate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isConfigUpToDate_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool dontReset
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 973756, RefRangeEnd = 973761, XrefRangeStart = 973756, XrefRangeEnd = 973756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dontReset_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 973761, RefRangeEnd = 973814, XrefRangeStart = 973761, XrefRangeEnd = 973761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dontReset_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool usesStateFromOtherControl
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 973814, RefRangeEnd = 973817, XrefRangeStart = 973814, XrefRangeEnd = 973814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usesStateFromOtherControl_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 973817, RefRangeEnd = 973819, XrefRangeStart = 973817, XrefRangeEnd = 973817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usesStateFromOtherControl_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasDefaultState
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 973820, RefRangeEnd = 973823, XrefRangeStart = 973819, XrefRangeEnd = 973820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDefaultState_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputControl()
	{
		Il2CppClassPointerStore<InputControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControl>.NativeClassPtr);
		NativeFieldInfoPtr_m_StateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_StateBlock");
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_Path");
		NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_DisplayName");
		NativeFieldInfoPtr_m_DisplayNameFromLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_DisplayNameFromLayout");
		NativeFieldInfoPtr_m_ShortDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_ShortDisplayName");
		NativeFieldInfoPtr_m_ShortDisplayNameFromLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_ShortDisplayNameFromLayout");
		NativeFieldInfoPtr_m_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_Layout");
		NativeFieldInfoPtr_m_Variants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_Variants");
		NativeFieldInfoPtr_m_Device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_Device");
		NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_Parent");
		NativeFieldInfoPtr_m_UsageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_UsageCount");
		NativeFieldInfoPtr_m_UsageStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_UsageStartIndex");
		NativeFieldInfoPtr_m_AliasCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_AliasCount");
		NativeFieldInfoPtr_m_AliasStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_AliasStartIndex");
		NativeFieldInfoPtr_m_ChildCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_ChildCount");
		NativeFieldInfoPtr_m_ChildStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_ChildStartIndex");
		NativeFieldInfoPtr_m_ControlFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_ControlFlags");
		NativeFieldInfoPtr_m_CachedValueIsStale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_CachedValueIsStale");
		NativeFieldInfoPtr_m_UnprocessedCachedValueIsStale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_UnprocessedCachedValueIsStale");
		NativeFieldInfoPtr_m_DefaultState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_DefaultState");
		NativeFieldInfoPtr_m_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_MinValue");
		NativeFieldInfoPtr_m_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_MaxValue");
		NativeFieldInfoPtr_m_OptimizedControlDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "m_OptimizedControlDataType");
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_set_displayName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_get_shortDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_set_shortDisplayName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_get_path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_get_layout_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_get_variants_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_get_device_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_get_parent_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr_get_children_Public_get_ReadOnlyArray_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664601);
		NativeMethodInfoPtr_get_usages_Public_get_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664602);
		NativeMethodInfoPtr_get_aliases_Public_get_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664603);
		NativeMethodInfoPtr_get_stateBlock_Public_get_InputStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664604);
		NativeMethodInfoPtr_get_noisy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664605);
		NativeMethodInfoPtr_set_noisy_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664606);
		NativeMethodInfoPtr_get_synthetic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_set_synthetic_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_get_Item_Public_get_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_get_valueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_get_valueSizeInBytes_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr_DebuggerDisplay_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_EvaluateMagnitude_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_New_Single_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Abstract_Virtual_New_Object_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Abstract_Virtual_New_Object_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Abstract_Virtual_New_Void_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_WriteValueFromBufferIntoState_Public_Virtual_New_Void_ptr_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_WriteValueFromObjectIntoState_Public_Virtual_New_Void_Object_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_CompareValue_Public_Abstract_Virtual_New_Boolean_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_TryGetChildControl_Public_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_TryGetChildControl_Public_TControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_GetChildControl_Public_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_GetChildControl_Public_TControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664628);
		NativeMethodInfoPtr_RefreshConfigurationIfNeeded_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_get_currentStatePtr_FamOrAssem_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_get_previousFrameStatePtr_FamOrAssem_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_get_defaultStatePtr_FamOrAssem_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664633);
		NativeMethodInfoPtr_get_noiseMaskPtr_FamOrAssem_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664634);
		NativeMethodInfoPtr_get_stateOffsetRelativeToDeviceRoot_FamOrAssem_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664635);
		NativeMethodInfoPtr_get_optimizedControlDataType_Public_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664636);
		NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_New_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664637);
		NativeMethodInfoPtr_ApplyParameterChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664638);
		NativeMethodInfoPtr_SetOptimizedControlDataType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664639);
		NativeMethodInfoPtr_SetOptimizedControlDataTypeRecursively_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664640);
		NativeMethodInfoPtr_EnsureOptimizationTypeHasNotChanged_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664641);
		NativeMethodInfoPtr_get_isSetupFinished_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664642);
		NativeMethodInfoPtr_set_isSetupFinished_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664643);
		NativeMethodInfoPtr_get_isButton_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664644);
		NativeMethodInfoPtr_set_isButton_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664645);
		NativeMethodInfoPtr_get_isConfigUpToDate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664646);
		NativeMethodInfoPtr_set_isConfigUpToDate_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664647);
		NativeMethodInfoPtr_get_dontReset_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664648);
		NativeMethodInfoPtr_set_dontReset_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664649);
		NativeMethodInfoPtr_get_usesStateFromOtherControl_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664650);
		NativeMethodInfoPtr_set_usesStateFromOtherControl_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664651);
		NativeMethodInfoPtr_get_hasDefaultState_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664652);
		NativeMethodInfoPtr_CallFinishSetupRecursive_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664653);
		NativeMethodInfoPtr_MakeChildPath_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664654);
		NativeMethodInfoPtr_BakeOffsetIntoStateBlockRecursive_Internal_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664655);
		NativeMethodInfoPtr_GetDeviceIndex_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664656);
		NativeMethodInfoPtr_IsValueConsideredPressed_Internal_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664657);
		NativeMethodInfoPtr_AddProcessor_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664658);
		NativeMethodInfoPtr_MarkAsStale_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664659);
		NativeMethodInfoPtr_MarkAsStaleRecursively_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100664660);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972669, XrefRangeEnd = 972674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972674, XrefRangeEnd = 972682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string DebuggerDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebuggerDisplay_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 972662, RefRangeEnd = 972669, XrefRangeStart = 972662, XrefRangeEnd = 972669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EvaluateMagnitude()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateMagnitude_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float EvaluateMagnitude(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_New_Single_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Abstract_Virtual_New_Object_ptr_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object ReadValueFromStateAsObject(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Abstract_Virtual_New_Object_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)statePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = bufferPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Abstract_Virtual_New_Void_ptr_Void_ptr_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972682, XrefRangeEnd = 972689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)bufferPtr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueFromBufferIntoState_Public_Virtual_New_Void_ptr_Void_Int32_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972689, XrefRangeEnd = 972696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void WriteValueFromObjectIntoState(Il2CppSystem.Object value, void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueFromObjectIntoState_Public_Virtual_New_Void_Object_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool CompareValue(void* firstStatePtr, void* secondStatePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)firstStatePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = secondStatePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CompareValue_Public_Abstract_Virtual_New_Boolean_ptr_Void_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972706, RefRangeEnd = 972707, XrefRangeStart = 972696, XrefRangeEnd = 972706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl TryGetChildControl(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetChildControl_Public_InputControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 972712, RefRangeEnd = 972714, XrefRangeStart = 972707, XrefRangeEnd = 972712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TControl TryGetChildControl<TControl>(string path) where TControl : InputControl
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryGetChildControl_Public_TControl_String_0<TControl>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972719, RefRangeEnd = 972720, XrefRangeStart = 972714, XrefRangeEnd = 972719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl GetChildControl(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildControl_Public_InputControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(261)]
	[CachedScanResults(RefRangeStart = 972724, RefRangeEnd = 972985, XrefRangeStart = 972720, XrefRangeEnd = 972724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TControl GetChildControl<TControl>(string path) where TControl : InputControl
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetChildControl_Public_TControl_String_0<TControl>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 972989, RefRangeEnd = 972990, XrefRangeStart = 972985, XrefRangeEnd = 972989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControl>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 972990, RefRangeEnd = 972992, XrefRangeStart = 972990, XrefRangeEnd = 972990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshConfigurationIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshConfigurationIfNeeded_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RefreshConfiguration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual FourCC CalculateOptimizedControlDataType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_New_FourCC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973031, XrefRangeEnd = 973039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyParameterChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParameterChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973039, XrefRangeEnd = 973044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOptimizedControlDataType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOptimizedControlDataType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973044, XrefRangeEnd = 973068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOptimizedControlDataTypeRecursively()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOptimizedControlDataTypeRecursively_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973068, XrefRangeEnd = 973124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureOptimizationTypeHasNotChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureOptimizationTypeHasNotChanged_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 973832, RefRangeEnd = 973834, XrefRangeStart = 973823, XrefRangeEnd = 973832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CallFinishSetupRecursive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallFinishSetupRecursive_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973834, XrefRangeEnd = 973837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string MakeChildPath(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeChildPath_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 973848, RefRangeEnd = 973851, XrefRangeStart = 973837, XrefRangeEnd = 973848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BakeOffsetIntoStateBlockRecursive(uint offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BakeOffsetIntoStateBlockRecursive_Internal_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 973851, RefRangeEnd = 973871, XrefRangeStart = 973851, XrefRangeEnd = 973851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDeviceIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeviceIndex_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 973873, RefRangeEnd = 973875, XrefRangeStart = 973871, XrefRangeEnd = 973873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValueConsideredPressed(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValueConsideredPressed_Internal_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddProcessor(Il2CppSystem.Object first)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddProcessor_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void MarkAsStale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsStale_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 973897, RefRangeEnd = 973899, XrefRangeStart = 973875, XrefRangeEnd = 973897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkAsStaleRecursively()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsStaleRecursively_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputControl(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class InputControl<TValue> : InputControl where TValue : new()
{
	private sealed class MethodInfoStoreGeneric_TryGetProcessor_Internal_TProcessor_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(InputControl<TValue>.NativeMethodInfoPtr_TryGetProcessor_Internal_TProcessor_0, Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnprocessedCachedValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_evaluateProcessorsEveryRead;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unprocessedValue_Internal_get_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValue_Public_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromPreviousFrame_Public_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadDefaultValue_Public_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromState_Public_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateWithCaching_Public_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromStateWithCaching_Public_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnprocessedValue_Public_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Abstract_Virtual_New_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Virtual_Object_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Virtual_Void_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueFromBufferIntoState_Public_Virtual_Void_ptr_Void_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueFromObjectIntoState_Public_Virtual_Void_Object_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_New_Void_TValue_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Virtual_Object_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareValue_Private_Static_Boolean_byref_TValue_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessValue_Public_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessValue_Public_Void_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetProcessor_Internal_TProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddProcessor_Internal_Virtual_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_processors_Internal_get_Il2CppReferenceArray_1_InputProcessor_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe InlinedArray<InputProcessor<TValue>> m_ProcessorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessorStack);
			return new InlinedArray<InputProcessor<TValue>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<InputProcessor<TValue>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<InputProcessor<TValue>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TValue m_CachedValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedValue);
			return IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num, true, false);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedValue);
			System.Type typeFromHandle = typeof(TValue);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					object obj = value;
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null));
					if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						System.IntPtr intPtr2 = intPtr;
						// IL cpblk instruction
						Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
					}
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(value as string));
				}
			}
			else
			{
				Unsafe.Write((void*)num2, value);
			}
		}
	}

	public unsafe TValue m_UnprocessedCachedValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnprocessedCachedValue);
			return IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num, true, false);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnprocessedCachedValue);
			System.Type typeFromHandle = typeof(TValue);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					object obj = value;
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null));
					if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						System.IntPtr intPtr2 = intPtr;
						// IL cpblk instruction
						Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
					}
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(value as string));
				}
			}
			else
			{
				Unsafe.Write((void*)num2, value);
			}
		}
	}

	public unsafe bool evaluateProcessorsEveryRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evaluateProcessorsEveryRead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evaluateProcessorsEveryRead)) = value;
		}
	}

	public unsafe override Il2CppSystem.Type valueType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
	}

	public unsafe override int valueSizeInBytes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ref TValue value
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973899, XrefRangeEnd = 973905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(TValue*)intPtr2;
		}
	}

	public unsafe ref TValue unprocessedValue
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973905, XrefRangeEnd = 973911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unprocessedValue_Internal_get_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(TValue*)intPtr2;
		}
	}

	public unsafe Il2CppReferenceArray<InputProcessor<TValue>> processors
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974015, XrefRangeEnd = 974023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_processors_Internal_get_Il2CppReferenceArray_1_InputProcessor_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputProcessor<TValue>>>(intPtr2) : null;
		}
	}

	static InputControl()
	{
		Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputControl`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr);
		NativeFieldInfoPtr_m_ProcessorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, "m_ProcessorStack");
		NativeFieldInfoPtr_m_CachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, "m_CachedValue");
		NativeFieldInfoPtr_m_UnprocessedCachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, "m_UnprocessedCachedValue");
		NativeFieldInfoPtr_evaluateProcessorsEveryRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, "evaluateProcessorsEveryRead");
		NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664661);
		NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664662);
		NativeMethodInfoPtr_get_value_Public_get_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664663);
		NativeMethodInfoPtr_get_unprocessedValue_Internal_get_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664664);
		NativeMethodInfoPtr_ReadValue_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664665);
		NativeMethodInfoPtr_ReadValueFromPreviousFrame_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664666);
		NativeMethodInfoPtr_ReadDefaultValue_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664667);
		NativeMethodInfoPtr_ReadValueFromState_Public_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664668);
		NativeMethodInfoPtr_ReadValueFromStateWithCaching_Public_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664669);
		NativeMethodInfoPtr_ReadUnprocessedValueFromStateWithCaching_Public_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664670);
		NativeMethodInfoPtr_ReadUnprocessedValue_Public_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664671);
		NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Abstract_Virtual_New_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664672);
		NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Virtual_Object_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664673);
		NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Virtual_Void_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664674);
		NativeMethodInfoPtr_WriteValueFromBufferIntoState_Public_Virtual_Void_ptr_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664675);
		NativeMethodInfoPtr_WriteValueFromObjectIntoState_Public_Virtual_Void_Object_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664676);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_New_Void_TValue_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664677);
		NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Virtual_Object_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664678);
		NativeMethodInfoPtr_CompareValue_Private_Static_Boolean_byref_TValue_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664679);
		NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664680);
		NativeMethodInfoPtr_ProcessValue_Public_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664681);
		NativeMethodInfoPtr_ProcessValue_Public_Void_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664682);
		NativeMethodInfoPtr_TryGetProcessor_Internal_TProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664683);
		NativeMethodInfoPtr_AddProcessor_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_get_processors_Internal_get_Il2CppReferenceArray_1_InputProcessor_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr, 100664687);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973911, XrefRangeEnd = 973912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValue_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973912, XrefRangeEnd = 973914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadValueFromPreviousFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueFromPreviousFrame_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973914, XrefRangeEnd = 973917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadDefaultValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadDefaultValue_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973917, XrefRangeEnd = 973918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadValueFromState(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueFromState_Public_TValue_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973918, XrefRangeEnd = 973920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadValueFromStateWithCaching(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueFromStateWithCaching_Public_TValue_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973920, XrefRangeEnd = 973923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadUnprocessedValueFromStateWithCaching_Public_TValue_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973923, XrefRangeEnd = 973924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadUnprocessedValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadUnprocessedValue_Public_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	public unsafe virtual TValue ReadUnprocessedValueFromState(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Abstract_Virtual_New_TValue_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973924, XrefRangeEnd = 973926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Object ReadValueFromStateAsObject(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Virtual_Object_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973926, XrefRangeEnd = 973928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)statePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = bufferPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Virtual_Void_ptr_Void_ptr_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973928, XrefRangeEnd = 973929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)bufferPtr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueFromBufferIntoState_Public_Virtual_Void_ptr_Void_Int32_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973929, XrefRangeEnd = 973940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteValueFromObjectIntoState(Il2CppSystem.Object value, void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueFromObjectIntoState_Public_Virtual_Void_Object_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973940, XrefRangeEnd = 973946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void WriteValueIntoState(TValue value, void* statePtr)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_New_Void_TValue_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973946, XrefRangeEnd = 973948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Virtual_Object_ptr_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973948, XrefRangeEnd = 973950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareValue(ref TValue firstValue, ref TValue secondValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref firstValue));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref secondValue));
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareValue_Private_Static_Boolean_byref_TValue_byref_TValue_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		Unsafe.As<TValue, object>(ref firstValue) = ((intPtr5 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
		System.IntPtr intPtr6 = intPtr2;
		Unsafe.As<TValue, object>(ref secondValue) = ((intPtr6 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr4);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973950, XrefRangeEnd = 973954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)firstStatePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = secondStatePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973954, XrefRangeEnd = 973955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ProcessValue(TValue value)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessValue_Public_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	public unsafe void ProcessValue(ref TValue value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref value));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessValue_Public_Void_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TValue, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973955, XrefRangeEnd = 973966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TProcessor TryGetProcessor<TProcessor>() where TProcessor : InputProcessor<TValue>
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputControl<TProcessor>.MethodInfoStoreGeneric_TryGetProcessor_Internal_TProcessor_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TProcessor>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973966, XrefRangeEnd = 973999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AddProcessor(Il2CppSystem.Object processor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddProcessor_Internal_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 974014, RefRangeEnd = 974015, XrefRangeStart = 973999, XrefRangeEnd = 974014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 974024, RefRangeEnd = 974035, XrefRangeStart = 974023, XrefRangeEnd = 974024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControl<TValue>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputControl(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
