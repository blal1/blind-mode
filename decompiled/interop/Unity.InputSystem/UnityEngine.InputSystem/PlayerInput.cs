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
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
	[System.Serializable]
	public class ActionEvent : UnityEvent<InputAction.CallbackContext>
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionId;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionName;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionId_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_String_0;

		public unsafe string m_ActionId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionId);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionId)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string m_ActionName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string actionId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string actionName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		static ActionEvent()
		{
			Il2CppClassPointerStore<ActionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "ActionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr);
			NativeFieldInfoPtr_m_ActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_ActionId");
			NativeFieldInfoPtr_m_ActionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_ActionName");
			NativeMethodInfoPtr_get_actionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100666310);
			NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100666311);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100666312);
			NativeMethodInfoPtr__ctor_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100666313);
			NativeMethodInfoPtr__ctor_Public_Void_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100666314);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997323, XrefRangeEnd = 997326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997326, XrefRangeEnd = 997343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionEvent(InputAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997343, XrefRangeEnd = 997349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionEvent(Il2CppSystem.Guid actionGUID, string name = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&actionGUID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Guid_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ActionEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DeviceLostEvent : UnityEvent<PlayerInput>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DeviceLostEvent()
		{
			Il2CppClassPointerStore<DeviceLostEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "DeviceLostEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceLostEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceLostEvent>.NativeClassPtr, 100666315);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997349, XrefRangeEnd = 997352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceLostEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceLostEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DeviceLostEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DeviceRegainedEvent : UnityEvent<PlayerInput>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DeviceRegainedEvent()
		{
			Il2CppClassPointerStore<DeviceRegainedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "DeviceRegainedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceRegainedEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceRegainedEvent>.NativeClassPtr, 100666316);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997352, XrefRangeEnd = 997355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceRegainedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceRegainedEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DeviceRegainedEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ControlsChangedEvent : UnityEvent<PlayerInput>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static ControlsChangedEvent()
		{
			Il2CppClassPointerStore<ControlsChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "ControlsChangedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsChangedEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsChangedEvent>.NativeClassPtr, 100666317);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997355, XrefRangeEnd = 997358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlsChangedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlsChangedEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ControlsChangedEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetDevice_Public_TDevice_0<TDevice>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetDevice_Public_TDevice_0, Il2CppClassPointerStore<PlayerInput>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDevice>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DeviceLostMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeviceRegainedMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_ControlsChangedMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllMapsHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Actions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NotificationBehavior;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UIInputModule;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceLostEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceRegainedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlsChangedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeverAutoSwitchControlSchemes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultControlScheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultActionMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitScreenIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InputValueObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentActionMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InputActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionsInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionMessageNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InputUser;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionTriggeredDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceLostCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceRegainedCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlsChangedCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionTriggeredCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreFilterUnpairedDeviceUsedDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnUnpairedDeviceUsedHooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceChangeDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnDeviceChangeHooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_AllActivePlayersCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_AllActivePlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UserChangeDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InitPairWithDevicesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InitPairWithDevices;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InitPlayerIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InitSplitScreenIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InitControlScheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DestroyIfDeviceSetupUnsuccessful;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputIsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_splitScreenIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actions_Public_get_InputActionAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_actions_Public_set_Void_InputActionAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentControlScheme_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultControlScheme_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultControlScheme_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_neverAutoSwitchControlSchemes_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_neverAutoSwitchControlSchemes_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentActionMap_Public_get_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentActionMap_Public_set_Void_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultActionMap_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultActionMap_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_notificationBehavior_Public_get_PlayerNotifications_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_notificationBehavior_Public_set_Void_PlayerNotifications_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actionEvents_Public_get_ReadOnlyArray_1_ActionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_actionEvents_Public_set_Void_ReadOnlyArray_1_ActionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceLostEvent_Public_get_DeviceLostEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceRegainedEvent_Public_get_DeviceRegainedEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlsChangedEvent_Public_get_ControlsChangedEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onActionTriggered_Public_add_Void_Action_1_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onActionTriggered_Public_rem_Void_Action_1_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onDeviceLost_Public_add_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onDeviceLost_Public_rem_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onDeviceRegained_Public_add_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onDeviceRegained_Public_rem_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onControlsChanged_Public_add_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onControlsChanged_Public_rem_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_camera_Public_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_camera_Public_set_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uiInputModule_Public_get_InputSystemUIInputModule_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_uiInputModule_Public_set_Void_InputSystemUIInputModule_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_user_Public_get_InputUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_devices_Public_get_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasMissingRequiredDevices_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSinglePlayer_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDevice_Public_TDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateInput_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDelegates_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateInput_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassivateInput_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchCurrentControlScheme_Public_Boolean_Il2CppReferenceArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchCurrentControlScheme_Public_Void_String_Il2CppReferenceArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchCurrentActionMap_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerByIndex_Public_Static_PlayerInput_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstPairedToDevice_Public_Static_PlayerInput_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_PlayerInput_GameObject_Int32_String_Int32_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_PlayerInput_GameObject_Int32_String_Int32_Il2CppReferenceArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoInstantiate_Private_Static_PlayerInput_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyActionAssetAndApplyBindingOverrides_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UninitializeActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstallOnActionTriggeredHook_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UninstallOnActionTriggeredHook_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActionTriggered_Private_Void_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheMessageNames_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCaches_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignUserAndDevices_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveBindingForDevice_Private_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnassignUserAndDevices_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToActivateControlScheme_Private_Boolean_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignPlayerIndex_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartListeningForUnpairedDeviceActivity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopListeningForUnpairedDeviceActivity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartListeningForDeviceChanges_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopListeningForDeviceChanges_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugLogAction_Public_Void_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleDeviceLost_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleDeviceRegained_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleControlsChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUserChange_Private_Static_Void_InputUser_InputUserChange_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPreFilterUnpairedDeviceUsed_Private_Static_Boolean_InputDevice_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUnpairedDeviceUsed_Private_Void_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeviceChange_Private_Void_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchControlSchemeInternal_Private_Void_byref_InputControlScheme_Il2CppReferenceArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string DeviceLostMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeviceLostMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeviceLostMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DeviceRegainedMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeviceRegainedMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeviceRegainedMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ControlsChangedMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ControlsChangedMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ControlsChangedMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int m_AllMapsHashCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllMapsHashCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllMapsHashCode)) = value;
		}
	}

	public unsafe InputActionAsset m_Actions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Actions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Actions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PlayerNotifications m_NotificationBehavior
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NotificationBehavior);
			return *(PlayerNotifications*)num;
		}
		set
		{
			*(PlayerNotifications*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NotificationBehavior)) = value;
		}
	}

	public unsafe InputSystemUIInputModule m_UIInputModule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UIInputModule);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputSystemUIInputModule>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UIInputModule)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeviceLostEvent m_DeviceLostEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceLostEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeviceLostEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceLostEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeviceRegainedEvent m_DeviceRegainedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceRegainedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeviceRegainedEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceRegainedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ControlsChangedEvent m_ControlsChangedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlsChangedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlsChangedEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlsChangedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<ActionEvent> m_ActionEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_NeverAutoSwitchControlSchemes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeverAutoSwitchControlSchemes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeverAutoSwitchControlSchemes)) = value;
		}
	}

	public unsafe string m_DefaultControlScheme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultControlScheme);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultControlScheme)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_DefaultActionMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultActionMap);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultActionMap)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int m_SplitScreenIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitScreenIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitScreenIndex)) = value;
		}
	}

	public unsafe Camera m_Camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputValue m_InputValueObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputValueObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputValue>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputValueObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputActionMap m_CurrentActionMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentActionMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentActionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_PlayerIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerIndex)) = value;
		}
	}

	public unsafe bool m_InputActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputActive)) = value;
		}
	}

	public unsafe bool m_Enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Enabled)) = value;
		}
	}

	public unsafe bool m_ActionsInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionsInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionsInitialized)) = value;
		}
	}

	public unsafe Dictionary<string, string> m_ActionMessageNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionMessageNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionMessageNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputUser m_InputUser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputUser);
			return *(InputUser*)num;
		}
		set
		{
			*(InputUser*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputUser)) = value;
		}
	}

	public unsafe Il2CppSystem.Action<InputAction.CallbackContext> m_ActionTriggeredDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionTriggeredDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputAction.CallbackContext>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionTriggeredDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CallbackArray<Il2CppSystem.Action<PlayerInput>> m_DeviceLostCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceLostCallbacks);
			return new CallbackArray<Il2CppSystem.Action<PlayerInput>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceLostCallbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CallbackArray<Il2CppSystem.Action<PlayerInput>> m_DeviceRegainedCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceRegainedCallbacks);
			return new CallbackArray<Il2CppSystem.Action<PlayerInput>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceRegainedCallbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CallbackArray<Il2CppSystem.Action<PlayerInput>> m_ControlsChangedCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlsChangedCallbacks);
			return new CallbackArray<Il2CppSystem.Action<PlayerInput>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlsChangedCallbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CallbackArray<Il2CppSystem.Action<InputAction.CallbackContext>> m_ActionTriggeredCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionTriggeredCallbacks);
			return new CallbackArray<Il2CppSystem.Action<InputAction.CallbackContext>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<InputAction.CallbackContext>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionTriggeredCallbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<InputAction.CallbackContext>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputControl, InputEventPtr>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<InputDevice, InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreFilterUnpairedDeviceUsedDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputDevice, InputEventPtr, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreFilterUnpairedDeviceUsedDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_OnUnpairedDeviceUsedHooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnUnpairedDeviceUsedHooked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnUnpairedDeviceUsedHooked)) = value;
		}
	}

	public unsafe Il2CppSystem.Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceChangeDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputDevice, InputDeviceChange>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeviceChangeDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_OnDeviceChangeHooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnDeviceChangeHooked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnDeviceChangeHooked)) = value;
		}
	}

	public unsafe static int s_AllActivePlayersCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_AllActivePlayersCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_AllActivePlayersCount, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<PlayerInput> s_AllActivePlayers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_AllActivePlayers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerInput>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_AllActivePlayers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UserChangeDelegate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputUser, InputUserChange, InputDevice>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UserChangeDelegate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_InitPairWithDevicesCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InitPairWithDevicesCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InitPairWithDevicesCount, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<InputDevice> s_InitPairWithDevices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InitPairWithDevices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDevice>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InitPairWithDevices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_InitPlayerIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InitPlayerIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InitPlayerIndex, (void*)(&value));
		}
	}

	public unsafe static int s_InitSplitScreenIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InitSplitScreenIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InitSplitScreenIndex, (void*)(&value));
		}
	}

	public unsafe static string s_InitControlScheme
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InitControlScheme, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InitControlScheme, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool s_DestroyIfDeviceSetupUnsuccessful
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DestroyIfDeviceSetupUnsuccessful, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DestroyIfDeviceSetupUnsuccessful, (void*)(&value));
		}
	}

	public unsafe bool inputIsActive
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317191, RefRangeEnd = 317192, XrefRangeStart = 317191, XrefRangeEnd = 317192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputIsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool active
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317191, RefRangeEnd = 317192, XrefRangeStart = 317191, XrefRangeEnd = 317192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int playerIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int splitScreenIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_splitScreenIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe InputActionAsset actions
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 997361, RefRangeEnd = 997363, XrefRangeStart = 997358, XrefRangeEnd = 997361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actions_Public_get_InputActionAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997363, XrefRangeEnd = 997379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actions_Public_set_Void_InputActionAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string currentControlScheme
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997379, XrefRangeEnd = 997388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentControlScheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string defaultControlScheme
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultControlScheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultControlScheme_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool neverAutoSwitchControlSchemes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_neverAutoSwitchControlSchemes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997388, XrefRangeEnd = 997390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_neverAutoSwitchControlSchemes_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionMap currentActionMap
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentActionMap_Public_get_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997390, XrefRangeEnd = 997394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentActionMap_Public_set_Void_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string defaultActionMap
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140861, RefRangeEnd = 140862, XrefRangeStart = 140861, XrefRangeEnd = 140862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultActionMap_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultActionMap_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe PlayerNotifications notificationBehavior
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_notificationBehavior_Public_get_PlayerNotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayerNotifications*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997394, XrefRangeEnd = 997396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_notificationBehavior_Public_set_Void_PlayerNotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReadOnlyArray<ActionEvent> actionEvents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997396, XrefRangeEnd = 997399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionEvents_Public_get_ReadOnlyArray_1_ActionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<ActionEvent>(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997399, XrefRangeEnd = 997405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionEvents_Public_set_Void_ReadOnlyArray_1_ActionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DeviceLostEvent deviceLostEvent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997405, XrefRangeEnd = 997412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceLostEvent_Public_get_DeviceLostEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeviceLostEvent>(intPtr2) : null;
		}
	}

	public unsafe DeviceRegainedEvent deviceRegainedEvent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997412, XrefRangeEnd = 997419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceRegainedEvent_Public_get_DeviceRegainedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeviceRegainedEvent>(intPtr2) : null;
		}
	}

	public unsafe ControlsChangedEvent controlsChangedEvent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997419, XrefRangeEnd = 997426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlsChangedEvent_Public_get_ControlsChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlsChangedEvent>(intPtr2) : null;
		}
	}

	public unsafe Camera camera
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_camera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputSystemUIInputModule uiInputModule
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiInputModule_Public_get_InputSystemUIInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputSystemUIInputModule>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997498, XrefRangeEnd = 997517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uiInputModule_Public_set_Void_InputSystemUIInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputUser user
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_user_Public_get_InputUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InputUser*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ReadOnlyArray<InputDevice> devices
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 997524, RefRangeEnd = 997527, XrefRangeStart = 997517, XrefRangeEnd = 997524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_devices_Public_get_ReadOnlyArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputDevice>(pointer);
		}
	}

	public unsafe bool hasMissingRequiredDevices
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997527, XrefRangeEnd = 997531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasMissingRequiredDevices_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static ReadOnlyArray<PlayerInput> all
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997531, XrefRangeEnd = 997538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_PlayerInput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<PlayerInput>(pointer);
		}
	}

	public unsafe static bool isSinglePlayer
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 997543, RefRangeEnd = 997547, XrefRangeStart = 997538, XrefRangeEnd = 997543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSinglePlayer_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PlayerInput()
	{
		Il2CppClassPointerStore<PlayerInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "PlayerInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr);
		NativeFieldInfoPtr_DeviceLostMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "DeviceLostMessage");
		NativeFieldInfoPtr_DeviceRegainedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "DeviceRegainedMessage");
		NativeFieldInfoPtr_ControlsChangedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "ControlsChangedMessage");
		NativeFieldInfoPtr_m_AllMapsHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_AllMapsHashCode");
		NativeFieldInfoPtr_m_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_Actions");
		NativeFieldInfoPtr_m_NotificationBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_NotificationBehavior");
		NativeFieldInfoPtr_m_UIInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_UIInputModule");
		NativeFieldInfoPtr_m_DeviceLostEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DeviceLostEvent");
		NativeFieldInfoPtr_m_DeviceRegainedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DeviceRegainedEvent");
		NativeFieldInfoPtr_m_ControlsChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ControlsChangedEvent");
		NativeFieldInfoPtr_m_ActionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ActionEvents");
		NativeFieldInfoPtr_m_NeverAutoSwitchControlSchemes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_NeverAutoSwitchControlSchemes");
		NativeFieldInfoPtr_m_DefaultControlScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DefaultControlScheme");
		NativeFieldInfoPtr_m_DefaultActionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DefaultActionMap");
		NativeFieldInfoPtr_m_SplitScreenIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_SplitScreenIndex");
		NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_Camera");
		NativeFieldInfoPtr_m_InputValueObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_InputValueObject");
		NativeFieldInfoPtr_m_CurrentActionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_CurrentActionMap");
		NativeFieldInfoPtr_m_PlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_PlayerIndex");
		NativeFieldInfoPtr_m_InputActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_InputActive");
		NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_Enabled");
		NativeFieldInfoPtr_m_ActionsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ActionsInitialized");
		NativeFieldInfoPtr_m_ActionMessageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ActionMessageNames");
		NativeFieldInfoPtr_m_InputUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_InputUser");
		NativeFieldInfoPtr_m_ActionTriggeredDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ActionTriggeredDelegate");
		NativeFieldInfoPtr_m_DeviceLostCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DeviceLostCallbacks");
		NativeFieldInfoPtr_m_DeviceRegainedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DeviceRegainedCallbacks");
		NativeFieldInfoPtr_m_ControlsChangedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ControlsChangedCallbacks");
		NativeFieldInfoPtr_m_ActionTriggeredCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_ActionTriggeredCallbacks");
		NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_UnpairedDeviceUsedDelegate");
		NativeFieldInfoPtr_m_PreFilterUnpairedDeviceUsedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_PreFilterUnpairedDeviceUsedDelegate");
		NativeFieldInfoPtr_m_OnUnpairedDeviceUsedHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_OnUnpairedDeviceUsedHooked");
		NativeFieldInfoPtr_m_DeviceChangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_DeviceChangeDelegate");
		NativeFieldInfoPtr_m_OnDeviceChangeHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "m_OnDeviceChangeHooked");
		NativeFieldInfoPtr_s_AllActivePlayersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_AllActivePlayersCount");
		NativeFieldInfoPtr_s_AllActivePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_AllActivePlayers");
		NativeFieldInfoPtr_s_UserChangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_UserChangeDelegate");
		NativeFieldInfoPtr_s_InitPairWithDevicesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_InitPairWithDevicesCount");
		NativeFieldInfoPtr_s_InitPairWithDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_InitPairWithDevices");
		NativeFieldInfoPtr_s_InitPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_InitPlayerIndex");
		NativeFieldInfoPtr_s_InitSplitScreenIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_InitSplitScreenIndex");
		NativeFieldInfoPtr_s_InitControlScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_InitControlScheme");
		NativeFieldInfoPtr_s_DestroyIfDeviceSetupUnsuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, "s_DestroyIfDeviceSetupUnsuccessful");
		NativeMethodInfoPtr_get_inputIsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666228);
		NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666229);
		NativeMethodInfoPtr_get_playerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666230);
		NativeMethodInfoPtr_get_splitScreenIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666231);
		NativeMethodInfoPtr_get_actions_Public_get_InputActionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666232);
		NativeMethodInfoPtr_set_actions_Public_set_Void_InputActionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666233);
		NativeMethodInfoPtr_get_currentControlScheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666234);
		NativeMethodInfoPtr_get_defaultControlScheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666235);
		NativeMethodInfoPtr_set_defaultControlScheme_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666236);
		NativeMethodInfoPtr_get_neverAutoSwitchControlSchemes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666237);
		NativeMethodInfoPtr_set_neverAutoSwitchControlSchemes_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666238);
		NativeMethodInfoPtr_get_currentActionMap_Public_get_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666239);
		NativeMethodInfoPtr_set_currentActionMap_Public_set_Void_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666240);
		NativeMethodInfoPtr_get_defaultActionMap_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666241);
		NativeMethodInfoPtr_set_defaultActionMap_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666242);
		NativeMethodInfoPtr_get_notificationBehavior_Public_get_PlayerNotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666243);
		NativeMethodInfoPtr_set_notificationBehavior_Public_set_Void_PlayerNotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666244);
		NativeMethodInfoPtr_get_actionEvents_Public_get_ReadOnlyArray_1_ActionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666245);
		NativeMethodInfoPtr_set_actionEvents_Public_set_Void_ReadOnlyArray_1_ActionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666246);
		NativeMethodInfoPtr_get_deviceLostEvent_Public_get_DeviceLostEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666247);
		NativeMethodInfoPtr_get_deviceRegainedEvent_Public_get_DeviceRegainedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666248);
		NativeMethodInfoPtr_get_controlsChangedEvent_Public_get_ControlsChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666249);
		NativeMethodInfoPtr_add_onActionTriggered_Public_add_Void_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666250);
		NativeMethodInfoPtr_remove_onActionTriggered_Public_rem_Void_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666251);
		NativeMethodInfoPtr_add_onDeviceLost_Public_add_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666252);
		NativeMethodInfoPtr_remove_onDeviceLost_Public_rem_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666253);
		NativeMethodInfoPtr_add_onDeviceRegained_Public_add_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666254);
		NativeMethodInfoPtr_remove_onDeviceRegained_Public_rem_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666255);
		NativeMethodInfoPtr_add_onControlsChanged_Public_add_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666256);
		NativeMethodInfoPtr_remove_onControlsChanged_Public_rem_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666257);
		NativeMethodInfoPtr_get_camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666258);
		NativeMethodInfoPtr_set_camera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666259);
		NativeMethodInfoPtr_get_uiInputModule_Public_get_InputSystemUIInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666260);
		NativeMethodInfoPtr_set_uiInputModule_Public_set_Void_InputSystemUIInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666261);
		NativeMethodInfoPtr_get_user_Public_get_InputUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666262);
		NativeMethodInfoPtr_get_devices_Public_get_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666263);
		NativeMethodInfoPtr_get_hasMissingRequiredDevices_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666264);
		NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666265);
		NativeMethodInfoPtr_get_isSinglePlayer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666266);
		NativeMethodInfoPtr_GetDevice_Public_TDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666267);
		NativeMethodInfoPtr_ActivateInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666268);
		NativeMethodInfoPtr_UpdateDelegates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666269);
		NativeMethodInfoPtr_DeactivateInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666270);
		NativeMethodInfoPtr_PassivateInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666271);
		NativeMethodInfoPtr_SwitchCurrentControlScheme_Public_Boolean_Il2CppReferenceArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666272);
		NativeMethodInfoPtr_SwitchCurrentControlScheme_Public_Void_String_Il2CppReferenceArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666273);
		NativeMethodInfoPtr_SwitchCurrentActionMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666274);
		NativeMethodInfoPtr_GetPlayerByIndex_Public_Static_PlayerInput_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666275);
		NativeMethodInfoPtr_FindFirstPairedToDevice_Public_Static_PlayerInput_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666276);
		NativeMethodInfoPtr_Instantiate_Public_Static_PlayerInput_GameObject_Int32_String_Int32_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666277);
		NativeMethodInfoPtr_Instantiate_Public_Static_PlayerInput_GameObject_Int32_String_Int32_Il2CppReferenceArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666278);
		NativeMethodInfoPtr_DoInstantiate_Private_Static_PlayerInput_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666279);
		NativeMethodInfoPtr_InitializeActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666280);
		NativeMethodInfoPtr_CopyActionAssetAndApplyBindingOverrides_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666281);
		NativeMethodInfoPtr_UninitializeActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666282);
		NativeMethodInfoPtr_InstallOnActionTriggeredHook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666283);
		NativeMethodInfoPtr_UninstallOnActionTriggeredHook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666284);
		NativeMethodInfoPtr_OnActionTriggered_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666285);
		NativeMethodInfoPtr_CacheMessageNames_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666286);
		NativeMethodInfoPtr_ClearCaches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666287);
		NativeMethodInfoPtr_AssignUserAndDevices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666288);
		NativeMethodInfoPtr_HaveBindingForDevice_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666289);
		NativeMethodInfoPtr_UnassignUserAndDevices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666290);
		NativeMethodInfoPtr_TryToActivateControlScheme_Private_Boolean_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666291);
		NativeMethodInfoPtr_AssignPlayerIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666292);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666293);
		NativeMethodInfoPtr_StartListeningForUnpairedDeviceActivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666294);
		NativeMethodInfoPtr_StopListeningForUnpairedDeviceActivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666295);
		NativeMethodInfoPtr_StartListeningForDeviceChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666296);
		NativeMethodInfoPtr_StopListeningForDeviceChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666297);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666298);
		NativeMethodInfoPtr_DebugLogAction_Public_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666299);
		NativeMethodInfoPtr_HandleDeviceLost_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666300);
		NativeMethodInfoPtr_HandleDeviceRegained_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666301);
		NativeMethodInfoPtr_HandleControlsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666302);
		NativeMethodInfoPtr_OnUserChange_Private_Static_Void_InputUser_InputUserChange_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666303);
		NativeMethodInfoPtr_OnPreFilterUnpairedDeviceUsed_Private_Static_Boolean_InputDevice_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666304);
		NativeMethodInfoPtr_OnUnpairedDeviceUsed_Private_Void_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666305);
		NativeMethodInfoPtr_OnDeviceChange_Private_Void_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666306);
		NativeMethodInfoPtr_SwitchControlSchemeInternal_Private_Void_byref_InputControlScheme_Il2CppReferenceArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666307);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr, 100666308);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997426, XrefRangeEnd = 997435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onActionTriggered(Il2CppSystem.Action<InputAction.CallbackContext> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onActionTriggered_Public_add_Void_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997435, XrefRangeEnd = 997444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onActionTriggered(Il2CppSystem.Action<InputAction.CallbackContext> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onActionTriggered_Public_rem_Void_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997444, XrefRangeEnd = 997453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onDeviceLost(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onDeviceLost_Public_add_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997453, XrefRangeEnd = 997462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onDeviceLost(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onDeviceLost_Public_rem_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997462, XrefRangeEnd = 997471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onDeviceRegained(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onDeviceRegained_Public_add_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997471, XrefRangeEnd = 997480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onDeviceRegained(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onDeviceRegained_Public_rem_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997480, XrefRangeEnd = 997489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onControlsChanged(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onControlsChanged_Public_add_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997489, XrefRangeEnd = 997498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onControlsChanged(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onControlsChanged_Public_rem_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997547, XrefRangeEnd = 997563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TDevice GetDevice<TDevice>() where TDevice : InputDevice
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetDevice_Public_TDevice_0<TDevice>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDevice>(intPtr2, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 997571, RefRangeEnd = 997573, XrefRangeStart = 997563, XrefRangeEnd = 997571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997596, RefRangeEnd = 997597, XrefRangeStart = 997573, XrefRangeEnd = 997596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDelegates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDelegates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997597, XrefRangeEnd = 997598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeactivateInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeactivateInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassivateInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassivateInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997617, RefRangeEnd = 997618, XrefRangeStart = 997598, XrefRangeEnd = 997617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SwitchCurrentControlScheme([Optional] Il2CppReferenceArray<InputDevice> devices)
	{
		if (devices == null)
		{
			devices = new Il2CppReferenceArray<InputDevice>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchCurrentControlScheme_Public_Boolean_Il2CppReferenceArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997618, XrefRangeEnd = 997624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchCurrentControlScheme(string controlScheme, [Optional] Il2CppReferenceArray<InputDevice> devices)
	{
		if (devices == null)
		{
			devices = new Il2CppReferenceArray<InputDevice>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(controlScheme);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchCurrentControlScheme_Public_Void_String_Il2CppReferenceArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997638, RefRangeEnd = 997639, XrefRangeStart = 997624, XrefRangeEnd = 997638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchCurrentActionMap(string mapNameOrId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(mapNameOrId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchCurrentActionMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997648, RefRangeEnd = 997649, XrefRangeStart = 997639, XrefRangeEnd = 997648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerInput GetPlayerByIndex(int playerIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerByIndex_Public_Static_PlayerInput_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997669, RefRangeEnd = 997670, XrefRangeStart = 997649, XrefRangeEnd = 997669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerInput FindFirstPairedToDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstPairedToDevice_Public_Static_PlayerInput_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997670, XrefRangeEnd = 997697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice pairWithDevice = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlScheme);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitScreenIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairWithDevice);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Static_PlayerInput_GameObject_Int32_String_Int32_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997697, XrefRangeEnd = 997726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, [Optional] Il2CppReferenceArray<InputDevice> pairWithDevices)
	{
		if (pairWithDevices == null)
		{
			pairWithDevices = new Il2CppReferenceArray<InputDevice>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlScheme);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitScreenIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairWithDevices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Static_PlayerInput_GameObject_Int32_String_Int32_Il2CppReferenceArray_1_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 997767, RefRangeEnd = 997771, XrefRangeStart = 997726, XrefRangeEnd = 997767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerInput DoInstantiate(GameObject prefab)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoInstantiate_Private_Static_PlayerInput_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 997820, RefRangeEnd = 997829, XrefRangeStart = 997771, XrefRangeEnd = 997820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997857, RefRangeEnd = 997858, XrefRangeStart = 997829, XrefRangeEnd = 997857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyActionAssetAndApplyBindingOverrides()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyActionAssetAndApplyBindingOverrides_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 997884, RefRangeEnd = 997888, XrefRangeStart = 997858, XrefRangeEnd = 997884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UninitializeActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UninitializeActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 997913, RefRangeEnd = 997916, XrefRangeStart = 997888, XrefRangeEnd = 997913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstallOnActionTriggeredHook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstallOnActionTriggeredHook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 997934, RefRangeEnd = 997935, XrefRangeStart = 997916, XrefRangeEnd = 997934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UninstallOnActionTriggeredHook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UninstallOnActionTriggeredHook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997935, XrefRangeEnd = 997956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActionTriggered(InputAction.CallbackContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActionTriggered_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 997996, RefRangeEnd = 997999, XrefRangeStart = 997956, XrefRangeEnd = 997996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheMessageNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheMessageNames_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997999, XrefRangeEnd = 998002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCaches()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCaches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998082, RefRangeEnd = 998084, XrefRangeStart = 998002, XrefRangeEnd = 998082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignUserAndDevices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignUserAndDevices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998094, RefRangeEnd = 998095, XrefRangeStart = 998084, XrefRangeEnd = 998094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveBindingForDevice(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveBindingForDevice_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998095, XrefRangeEnd = 998112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnassignUserAndDevices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnassignUserAndDevices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998153, RefRangeEnd = 998155, XrefRangeStart = 998112, XrefRangeEnd = 998153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryToActivateControlScheme(InputControlScheme controlScheme)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlScheme));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToActivateControlScheme_Private_Boolean_InputControlScheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998171, RefRangeEnd = 998172, XrefRangeStart = 998155, XrefRangeEnd = 998171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignPlayerIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignPlayerIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998172, XrefRangeEnd = 998262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998292, RefRangeEnd = 998294, XrefRangeStart = 998262, XrefRangeEnd = 998292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartListeningForUnpairedDeviceActivity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartListeningForUnpairedDeviceActivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998310, RefRangeEnd = 998312, XrefRangeStart = 998294, XrefRangeEnd = 998310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopListeningForUnpairedDeviceActivity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopListeningForUnpairedDeviceActivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998312, XrefRangeEnd = 998323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartListeningForDeviceChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartListeningForDeviceChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998323, XrefRangeEnd = 998327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopListeningForDeviceChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopListeningForDeviceChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998327, XrefRangeEnd = 998407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998407, XrefRangeEnd = 998412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugLogAction(InputAction.CallbackContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugLogAction_Public_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998419, RefRangeEnd = 998420, XrefRangeStart = 998412, XrefRangeEnd = 998419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleDeviceLost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleDeviceLost_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 998427, RefRangeEnd = 998428, XrefRangeStart = 998420, XrefRangeEnd = 998427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleDeviceRegained()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleDeviceRegained_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998435, RefRangeEnd = 998437, XrefRangeStart = 998428, XrefRangeEnd = 998435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleControlsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleControlsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998437, XrefRangeEnd = 998459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnUserChange(InputUser user, InputUserChange change, InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&user);
		*(InputUserChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUserChange_Private_Static_Void_InputUser_InputUserChange_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998459, XrefRangeEnd = 998484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPreFilterUnpairedDeviceUsed_Private_Static_Boolean_InputDevice_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998484, XrefRangeEnd = 998579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUnpairedDeviceUsed_Private_Void_InputControl_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998579, XrefRangeEnd = 998597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputDeviceChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDeviceChange_Private_Void_InputDevice_InputDeviceChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 998678, RefRangeEnd = 998680, XrefRangeStart = 998597, XrefRangeEnd = 998678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, [Optional] Il2CppReferenceArray<InputDevice> devices)
	{
		if (devices == null)
		{
			devices = new Il2CppReferenceArray<InputDevice>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlScheme);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)devices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchControlSchemeInternal_Private_Void_byref_InputControlScheme_Il2CppReferenceArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998680, XrefRangeEnd = 998681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInput>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public bool SwitchCurrentControlScheme(params InputDevice[] devices)
	{
		return SwitchCurrentControlScheme(new Il2CppReferenceArray<InputDevice>(devices));
	}

	public void SwitchCurrentControlScheme(string controlScheme, params InputDevice[] devices)
	{
		SwitchCurrentControlScheme(controlScheme, new Il2CppReferenceArray<InputDevice>(devices));
	}

	public static PlayerInput Instantiate(GameObject prefab, [Optional] int playerIndex, [Optional] string controlScheme, [Optional] int splitScreenIndex, params InputDevice[] pairWithDevices)
	{
		return Instantiate(prefab, playerIndex, controlScheme, splitScreenIndex, new Il2CppReferenceArray<InputDevice>(pairWithDevices));
	}

	public void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, params InputDevice[] devices)
	{
		SwitchControlSchemeInternal(ref controlScheme, new Il2CppReferenceArray<InputDevice>(devices));
	}

	public PlayerInput(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
