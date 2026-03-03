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
using Il2CppSystem.Reflection;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class InputDevice : InputControl
{
	[System.Serializable]
	[OriginalName("Unity.InputSystem.dll", "", "DeviceFlags")]
	[System.Flags]
	public enum DeviceFlags
	{
		UpdateBeforeRender = 1,
		HasStateCallbacks = 2,
		HasControlsWithDefaultState = 4,
		HasDontResetControls = 0x400,
		HasEventMerger = 0x2000,
		HasEventPreProcessor = 0x4000,
		Remote = 8,
		Native = 0x10,
		DisabledInFrontend = 0x20,
		DisabledInRuntime = 0x80,
		DisabledWhileInBackground = 0x100,
		DisabledStateHasBeenQueriedFromRuntime = 0x40,
		CanRunInBackground = 0x800,
		CanRunInBackgroundHasBeenQueried = 0x1000
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ControlBitRangeNode
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_endBitOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftChildIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlCount;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

		[FieldOffset(0)]
		public ushort endBitOffset;

		[FieldOffset(2)]
		public short leftChildIndex;

		[FieldOffset(4)]
		public ushort controlStartIndex;

		[FieldOffset(6)]
		public byte controlCount;

		static ControlBitRangeNode()
		{
			Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "ControlBitRangeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr);
			NativeFieldInfoPtr_endBitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr, "endBitOffset");
			NativeFieldInfoPtr_leftChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr, "leftChildIndex");
			NativeFieldInfoPtr_controlStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr, "controlStartIndex");
			NativeFieldInfoPtr_controlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr, "controlCount");
			NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr, 100665005);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 976341, RefRangeEnd = 976344, XrefRangeStart = 976341, XrefRangeEnd = 976341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBitRangeNode(ushort endOffset)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&endOffset);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlBitRangeNode>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_ExecuteCommand_Public_Int64_byref_TCommand_0<TCommand>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ExecuteCommand_Public_Int64_byref_TCommand_0, Il2CppClassPointerStore<InputDevice>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCommand>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Build_Internal_Static_TDevice_String_String_InputDeviceDescription_Boolean_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Build_Internal_Static_TDevice_String_String_InputDeviceDescription_Boolean_0, Il2CppClassPointerStore<InputDevice>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidDeviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_kLocalParticipantId;

	private static readonly System.IntPtr NativeFieldInfoPtr_kInvalidDeviceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentProcessedEventBytesOnUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdateTimeInternal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentUpdateStepCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AliasesForEachControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UsagesForEachControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UsageToControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildrenForEachControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdatedButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ButtonControlsCheckingPressState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseCachePathForButtonPresses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateOffsetToControlMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlTreeNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlTreeIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_kControlIndexBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_kStateOffsetBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_kStateSizeBits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_description_Public_get_InputDeviceDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canRunInBackground_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canDeviceRunInBackground_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_added_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_remote_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_native_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastUpdateTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wasUpdatedThisFrame_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allControls_Public_get_ReadOnlyArray_1_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Virtual_Object_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Virtual_Object_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Virtual_Void_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyConfigurationChanged_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeCurrent_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAdded_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoved_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnConfigurationChanged_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommand_Public_Int64_byref_TCommand_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommand_Protected_Virtual_New_Int64_ptr_InputDeviceCommand_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryEnabledStateFromRuntime_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledInFrontend_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledInFrontend_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledInRuntime_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledInRuntime_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledWhileInBackground_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledWhileInBackground_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeStateOffsetToControlMapEntry_Internal_Static_UInt32_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeStateOffsetToControlMapEntry_Internal_Static_Void_UInt32_byref_UInt32_byref_UInt32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasControlsWithDefaultState_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasControlsWithDefaultState_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasDontResetControls_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasDontResetControls_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasStateCallbacks_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasStateCallbacks_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasEventMerger_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasEventMerger_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasEventPreProcessor_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasEventPreProcessor_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDeviceUsage_Internal_Void_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDeviceUsage_Internal_Void_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDeviceUsages_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestSync_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestReset_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteEnableCommand_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteDisableCommand_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyAdded_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyRemoved_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Build_Internal_Static_TDevice_String_String_InputDeviceDescription_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteChangedControlStates_Internal_Void_ptr_Byte_ptr_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WritePartialChangedControlStatesInternal_Private_Void_UInt32_UInt32_ControlBitRangeNode_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DumpControlBitRangeNode_Private_Void_Int32_ControlBitRangeNode_UInt32_UInt32_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DumpControlTree_Private_Void_ControlBitRangeNode_UInt32_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DumpControlTree_Internal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteChangedControlStatesInternal_Private_Void_ptr_Void_ptr_Byte_ControlBitRangeNode_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasDataChangedInRange_Private_Static_Boolean_ptr_Byte_ptr_Void_UInt32_UInt32_0;

	public unsafe static int InvalidDeviceId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidDeviceId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidDeviceId, (void*)(&value));
		}
	}

	public unsafe static int kLocalParticipantId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kLocalParticipantId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kLocalParticipantId, (void*)(&value));
		}
	}

	public unsafe static int kInvalidDeviceIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInvalidDeviceIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInvalidDeviceIndex, (void*)(&value));
		}
	}

	public unsafe DeviceFlags m_DeviceFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceFlags);
			return *(DeviceFlags*)num;
		}
		set
		{
			*(DeviceFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceFlags)) = value;
		}
	}

	public unsafe int m_DeviceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceId)) = value;
		}
	}

	public unsafe int m_ParticipantId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParticipantId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParticipantId)) = value;
		}
	}

	public unsafe int m_DeviceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceIndex)) = value;
		}
	}

	public unsafe uint m_CurrentProcessedEventBytesOnUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentProcessedEventBytesOnUpdate);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentProcessedEventBytesOnUpdate)) = value;
		}
	}

	public unsafe InputDeviceDescription m_Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Description);
			return new InputDeviceDescription(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceDescription>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Description), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceDescription>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe double m_LastUpdateTimeInternal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastUpdateTimeInternal);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastUpdateTimeInternal)) = value;
		}
	}

	public unsafe uint m_CurrentUpdateStepCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentUpdateStepCount);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentUpdateStepCount)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<InternedString> m_AliasesForEachControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AliasesForEachControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternedString>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AliasesForEachControl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<InternedString> m_UsagesForEachControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsagesForEachControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternedString>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsagesForEachControl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<InputControl> m_UsageToControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsageToControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsageToControl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<InputControl> m_ChildrenForEachControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildrenForEachControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildrenForEachControl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<int> m_UpdatedButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdatedButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdatedButtons)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ButtonControl> m_ButtonControlsCheckingPressState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ButtonControlsCheckingPressState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ButtonControl>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ButtonControlsCheckingPressState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_UseCachePathForButtonPresses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseCachePathForButtonPresses);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseCachePathForButtonPresses)) = value;
		}
	}

	public unsafe Il2CppStructArray<uint> m_StateOffsetToControlMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateOffsetToControlMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ControlBitRangeNode> m_ControlTreeNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlTreeNodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ControlBitRangeNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlTreeNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ushort> m_ControlTreeIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlTreeIndices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlTreeIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int kControlIndexBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kControlIndexBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kControlIndexBits, (void*)(&value));
		}
	}

	public unsafe static int kStateOffsetBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kStateOffsetBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kStateOffsetBits, (void*)(&value));
		}
	}

	public unsafe static int kStateSizeBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kStateSizeBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kStateSizeBits, (void*)(&value));
		}
	}

	public unsafe InputDeviceDescription description
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_description_Public_get_InputDeviceDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputDeviceDescription(pointer);
		}
	}

	public unsafe bool enabled
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 976349, RefRangeEnd = 976354, XrefRangeStart = 976344, XrefRangeEnd = 976349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool canRunInBackground
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976358, RefRangeEnd = 976360, XrefRangeStart = 976354, XrefRangeEnd = 976358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canRunInBackground_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool canDeviceRunInBackground
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976358, RefRangeEnd = 976360, XrefRangeStart = 976358, XrefRangeEnd = 976360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canDeviceRunInBackground_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool added
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 976360, RefRangeEnd = 976375, XrefRangeStart = 976360, XrefRangeEnd = 976360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_added_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool remote
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 976375, RefRangeEnd = 976380, XrefRangeStart = 976375, XrefRangeEnd = 976375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_remote_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool native
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 976380, RefRangeEnd = 976384, XrefRangeStart = 976380, XrefRangeEnd = 976380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_native_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool updateBeforeRender
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 976384, RefRangeEnd = 976388, XrefRangeStart = 976384, XrefRangeEnd = 976384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int deviceId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double lastUpdateTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976388, XrefRangeEnd = 976390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastUpdateTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool wasUpdatedThisFrame
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976390, XrefRangeEnd = 976392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wasUpdatedThisFrame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ReadOnlyArray<InputControl> allControls
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 976395, RefRangeEnd = 976401, XrefRangeStart = 976392, XrefRangeEnd = 976395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allControls_Public_get_ReadOnlyArray_1_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputControl>(pointer);
		}
	}

	public unsafe override Il2CppSystem.Type valueType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976401, XrefRangeEnd = 976406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976406, XrefRangeEnd = 976410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe static ReadOnlyArray<InputDevice> all
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976410, XrefRangeEnd = 976418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputDevice>(pointer);
		}
	}

	public unsafe bool disabledInFrontend
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 976505, RefRangeEnd = 976513, XrefRangeStart = 976505, XrefRangeEnd = 976505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledInFrontend_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976513, RefRangeEnd = 976514, XrefRangeStart = 976513, XrefRangeEnd = 976513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledInFrontend_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool disabledInRuntime
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 976514, RefRangeEnd = 976524, XrefRangeStart = 976514, XrefRangeEnd = 976514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledInRuntime_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 976524, RefRangeEnd = 976530, XrefRangeStart = 976524, XrefRangeEnd = 976524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledInRuntime_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool disabledWhileInBackground
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 976530, RefRangeEnd = 976535, XrefRangeStart = 976530, XrefRangeEnd = 976530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledWhileInBackground_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 976535, RefRangeEnd = 976543, XrefRangeStart = 976535, XrefRangeEnd = 976535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledWhileInBackground_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasControlsWithDefaultState
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976544, RefRangeEnd = 976546, XrefRangeStart = 976544, XrefRangeEnd = 976544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasControlsWithDefaultState_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 976546, RefRangeEnd = 976549, XrefRangeStart = 976546, XrefRangeEnd = 976546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasControlsWithDefaultState_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasDontResetControls
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976549, RefRangeEnd = 976550, XrefRangeStart = 976549, XrefRangeEnd = 976549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDontResetControls_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 976550, RefRangeEnd = 976601, XrefRangeStart = 976550, XrefRangeEnd = 976550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasDontResetControls_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasStateCallbacks
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 976601, RefRangeEnd = 976603, XrefRangeStart = 976601, XrefRangeEnd = 976601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasStateCallbacks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasStateCallbacks_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasEventMerger
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976603, RefRangeEnd = 976604, XrefRangeStart = 976603, XrefRangeEnd = 976603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasEventMerger_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976604, RefRangeEnd = 976605, XrefRangeStart = 976604, XrefRangeEnd = 976604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasEventMerger_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasEventPreProcessor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976605, RefRangeEnd = 976606, XrefRangeStart = 976605, XrefRangeEnd = 976605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasEventPreProcessor_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976606, RefRangeEnd = 976607, XrefRangeStart = 976606, XrefRangeEnd = 976606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasEventPreProcessor_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static InputDevice()
	{
		Il2CppClassPointerStore<InputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputDevice");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice>.NativeClassPtr);
		NativeFieldInfoPtr_InvalidDeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "InvalidDeviceId");
		NativeFieldInfoPtr_kLocalParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "kLocalParticipantId");
		NativeFieldInfoPtr_kInvalidDeviceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "kInvalidDeviceIndex");
		NativeFieldInfoPtr_m_DeviceFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_DeviceFlags");
		NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_DeviceId");
		NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_ParticipantId");
		NativeFieldInfoPtr_m_DeviceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_DeviceIndex");
		NativeFieldInfoPtr_m_CurrentProcessedEventBytesOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_CurrentProcessedEventBytesOnUpdate");
		NativeFieldInfoPtr_m_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_Description");
		NativeFieldInfoPtr_m_LastUpdateTimeInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_LastUpdateTimeInternal");
		NativeFieldInfoPtr_m_CurrentUpdateStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_CurrentUpdateStepCount");
		NativeFieldInfoPtr_m_AliasesForEachControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_AliasesForEachControl");
		NativeFieldInfoPtr_m_UsagesForEachControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_UsagesForEachControl");
		NativeFieldInfoPtr_m_UsageToControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_UsageToControl");
		NativeFieldInfoPtr_m_ChildrenForEachControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_ChildrenForEachControl");
		NativeFieldInfoPtr_m_UpdatedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_UpdatedButtons");
		NativeFieldInfoPtr_m_ButtonControlsCheckingPressState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_ButtonControlsCheckingPressState");
		NativeFieldInfoPtr_m_UseCachePathForButtonPresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_UseCachePathForButtonPresses");
		NativeFieldInfoPtr_m_StateOffsetToControlMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_StateOffsetToControlMap");
		NativeFieldInfoPtr_m_ControlTreeNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_ControlTreeNodes");
		NativeFieldInfoPtr_m_ControlTreeIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_ControlTreeIndices");
		NativeFieldInfoPtr_kControlIndexBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "kControlIndexBits");
		NativeFieldInfoPtr_kStateOffsetBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "kStateOffsetBits");
		NativeFieldInfoPtr_kStateSizeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "kStateSizeBits");
		NativeMethodInfoPtr_get_description_Public_get_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664942);
		NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664943);
		NativeMethodInfoPtr_get_canRunInBackground_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664944);
		NativeMethodInfoPtr_get_canDeviceRunInBackground_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664945);
		NativeMethodInfoPtr_get_added_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664946);
		NativeMethodInfoPtr_get_remote_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664947);
		NativeMethodInfoPtr_get_native_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664948);
		NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664949);
		NativeMethodInfoPtr_get_deviceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664950);
		NativeMethodInfoPtr_get_lastUpdateTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664951);
		NativeMethodInfoPtr_get_wasUpdatedThisFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664952);
		NativeMethodInfoPtr_get_allControls_Public_get_ReadOnlyArray_1_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664953);
		NativeMethodInfoPtr_get_valueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664954);
		NativeMethodInfoPtr_get_valueSizeInBytes_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664955);
		NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664956);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664957);
		NativeMethodInfoPtr_ReadValueFromBufferAsObject_Public_Virtual_Object_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664958);
		NativeMethodInfoPtr_ReadValueFromStateAsObject_Public_Virtual_Object_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664959);
		NativeMethodInfoPtr_ReadValueFromStateIntoBuffer_Public_Virtual_Void_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664960);
		NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664961);
		NativeMethodInfoPtr_NotifyConfigurationChanged_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664962);
		NativeMethodInfoPtr_MakeCurrent_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664963);
		NativeMethodInfoPtr_OnAdded_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664964);
		NativeMethodInfoPtr_OnRemoved_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664965);
		NativeMethodInfoPtr_OnConfigurationChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664966);
		NativeMethodInfoPtr_ExecuteCommand_Public_Int64_byref_TCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664967);
		NativeMethodInfoPtr_ExecuteCommand_Protected_Virtual_New_Int64_ptr_InputDeviceCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664968);
		NativeMethodInfoPtr_QueryEnabledStateFromRuntime_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr_get_disabledInFrontend_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr_set_disabledInFrontend_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr_get_disabledInRuntime_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr_set_disabledInRuntime_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664973);
		NativeMethodInfoPtr_get_disabledWhileInBackground_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664974);
		NativeMethodInfoPtr_set_disabledWhileInBackground_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664975);
		NativeMethodInfoPtr_EncodeStateOffsetToControlMapEntry_Internal_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr_DecodeStateOffsetToControlMapEntry_Internal_Static_Void_UInt32_byref_UInt32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr_get_hasControlsWithDefaultState_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr_set_hasControlsWithDefaultState_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr_get_hasDontResetControls_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_set_hasDontResetControls_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_get_hasStateCallbacks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_set_hasStateCallbacks_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_get_hasEventMerger_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_set_hasEventMerger_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_get_hasEventPreProcessor_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_set_hasEventPreProcessor_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_AddDeviceUsage_Internal_Void_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_RemoveDeviceUsage_Internal_Void_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_ClearDeviceUsages_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_RequestSync_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_RequestReset_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_ExecuteEnableCommand_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_ExecuteDisableCommand_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_NotifyAdded_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_NotifyRemoved_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_Build_Internal_Static_TDevice_String_String_InputDeviceDescription_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_WriteChangedControlStates_Internal_Void_ptr_Byte_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_WritePartialChangedControlStatesInternal_Private_Void_UInt32_UInt32_ControlBitRangeNode_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_DumpControlBitRangeNode_Private_Void_Int32_ControlBitRangeNode_UInt32_UInt32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_DumpControlTree_Private_Void_ControlBitRangeNode_UInt32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_DumpControlTree_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_WriteChangedControlStatesInternal_Private_Void_ptr_Void_ptr_Byte_ControlBitRangeNode_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_HasDataChangedInRange_Private_Static_Boolean_ptr_Byte_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100665004);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 976311, RefRangeEnd = 976341, XrefRangeStart = 976311, XrefRangeEnd = 976341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputDevice()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevice>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976418, XrefRangeEnd = 976423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976423, XrefRangeEnd = 976434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976434, XrefRangeEnd = 976463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976463, XrefRangeEnd = 976468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976471, RefRangeEnd = 976472, XrefRangeStart = 976468, XrefRangeEnd = 976471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyConfigurationChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyConfigurationChanged_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MakeCurrent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MakeCurrent_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAdded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAdded_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRemoved_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnConfigurationChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnConfigurationChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976491, RefRangeEnd = 976492, XrefRangeStart = 976472, XrefRangeEnd = 976491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long ExecuteCommand<TCommand>(ref TCommand command) where TCommand : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TCommand, object>(ref command));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ExecuteCommand_Public_Int64_byref_TCommand_0<TCommand>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TCommand, object>(ref command) = ((intPtr4 == (System.IntPtr)0) ? ((TCommand)null) : IL2CPP.PointerToValueGeneric<TCommand>(intPtr4, false, false));
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976492, XrefRangeEnd = 976499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual long ExecuteCommand(InputDeviceCommand* commandPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)commandPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteCommand_Protected_Virtual_New_Int64_ptr_InputDeviceCommand_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976504, RefRangeEnd = 976505, XrefRangeStart = 976499, XrefRangeEnd = 976504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool QueryEnabledStateFromRuntime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryEnabledStateFromRuntime_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976543, RefRangeEnd = 976544, XrefRangeStart = 976543, XrefRangeEnd = 976543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&controlIndex);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateOffsetInBits;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateSizeInBits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeStateOffsetToControlMapEntry_Internal_Static_UInt32_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&entry);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref controlIndex);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stateOffset);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stateSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeStateOffsetToControlMapEntry_Internal_Static_Void_UInt32_byref_UInt32_byref_UInt32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 976613, RefRangeEnd = 976615, XrefRangeStart = 976607, XrefRangeEnd = 976613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDeviceUsage(InternedString usage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDeviceUsage_Internal_Void_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976624, RefRangeEnd = 976625, XrefRangeStart = 976615, XrefRangeEnd = 976624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDeviceUsage(InternedString usage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usage));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDeviceUsage_Internal_Void_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976625, RefRangeEnd = 976626, XrefRangeStart = 976625, XrefRangeEnd = 976625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDeviceUsages()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDeviceUsages_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 976631, RefRangeEnd = 976636, XrefRangeStart = 976626, XrefRangeEnd = 976631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequestSync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestSync_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976641, RefRangeEnd = 976642, XrefRangeStart = 976636, XrefRangeEnd = 976641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequestReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestReset_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 976647, RefRangeEnd = 976651, XrefRangeStart = 976642, XrefRangeEnd = 976647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ExecuteEnableCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteEnableCommand_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 976655, RefRangeEnd = 976659, XrefRangeStart = 976651, XrefRangeEnd = 976655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ExecuteDisableCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteDisableCommand_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 651654, RefRangeEnd = 651676, XrefRangeStart = 651654, XrefRangeEnd = 651676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyAdded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyAdded_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 908827, RefRangeEnd = 908829, XrefRangeStart = 908827, XrefRangeEnd = 908829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyRemoved_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 976696, RefRangeEnd = 976699, XrefRangeStart = 976659, XrefRangeEnd = 976696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TDevice Build<TDevice>(string layoutName = null, string layoutVariants = null, InputDeviceDescription deviceDescription = null, bool noPrecompiledLayouts = false) where TDevice : InputDevice
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutVariants);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescription));
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &noPrecompiledLayouts;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Build_Internal_Static_TDevice_String_String_InputDeviceDescription_Boolean_0<TDevice>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDevice>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976706, RefRangeEnd = 976707, XrefRangeStart = 976699, XrefRangeEnd = 976706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)deviceStateBuffer;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateSizeInBytes;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateOffsetInDevice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteChangedControlStates_Internal_Void_ptr_Byte_ptr_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 976727, RefRangeEnd = 976729, XrefRangeStart = 976707, XrefRangeEnd = 976727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WritePartialChangedControlStatesInternal(uint stateSizeInBits, uint stateOffsetInDeviceInBits, ControlBitRangeNode parentNode, uint startOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&stateSizeInBits);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateOffsetInDeviceInBits;
		*(ControlBitRangeNode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentNode;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WritePartialChangedControlStatesInternal_Private_Void_UInt32_UInt32_ControlBitRangeNode_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 976778, RefRangeEnd = 976780, XrefRangeStart = 976729, XrefRangeEnd = 976778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DumpControlBitRangeNode(int nodeIndex, ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<string> output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&nodeIndex);
		*(ControlBitRangeNode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &node;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DumpControlBitRangeNode_Private_Void_Int32_ControlBitRangeNode_UInt32_UInt32_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 976784, RefRangeEnd = 976787, XrefRangeStart = 976780, XrefRangeEnd = 976784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DumpControlTree(ControlBitRangeNode parentNode, uint startOffset, List<string> output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&parentNode);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DumpControlTree_Private_Void_ControlBitRangeNode_UInt32_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976787, XrefRangeEnd = 976799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string DumpControlTree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DumpControlTree_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 976824, RefRangeEnd = 976827, XrefRangeStart = 976799, XrefRangeEnd = 976824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteChangedControlStatesInternal(void* statePtr, byte* deviceStatePtr, ControlBitRangeNode parentNode, uint startOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)statePtr;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = deviceStatePtr;
		*(ControlBitRangeNode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentNode;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteChangedControlStatesInternal_Private_Void_ptr_Void_ptr_Byte_ControlBitRangeNode_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976827, XrefRangeEnd = 976828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)deviceStatePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = statePtr;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startOffset;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasDataChangedInRange_Private_Static_Boolean_ptr_Byte_ptr_Void_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputDevice(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
