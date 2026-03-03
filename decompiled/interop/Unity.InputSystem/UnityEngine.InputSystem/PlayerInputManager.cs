using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
	[System.Serializable]
	public class PlayerJoinedEvent : UnityEvent<PlayerInput>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static PlayerJoinedEvent()
		{
			Il2CppClassPointerStore<PlayerJoinedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "PlayerJoinedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerJoinedEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerJoinedEvent>.NativeClassPtr, 100666360);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998681, XrefRangeEnd = 998684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerJoinedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerJoinedEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PlayerJoinedEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class PlayerLeftEvent : UnityEvent<PlayerInput>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static PlayerLeftEvent()
		{
			Il2CppClassPointerStore<PlayerLeftEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "PlayerLeftEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLeftEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLeftEvent>.NativeClassPtr, 100666361);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998684, XrefRangeEnd = 998687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerLeftEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLeftEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PlayerLeftEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerJoinedMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLeftMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NotificationBehavior;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxPlayerCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowJoining;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_JoinBehavior;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerJoinedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerLeftEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_JoinAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaintainAspectRatioInSplitScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FixedNumberOfSplitScreens;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitScreenRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_JoinActionDelegateHooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegateHooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_JoinActionDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerJoinedCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerLeftCallbacks;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_splitScreen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_splitScreen_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maintainAspectRatioInSplitScreen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedNumberOfSplitScreens_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_splitScreenArea_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxPlayerCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_joiningEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_joinBehavior_Public_get_PlayerJoinBehavior_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_joinBehavior_Public_set_Void_PlayerJoinBehavior_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_joinAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_joinAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_notificationBehavior_Public_get_PlayerNotifications_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_notificationBehavior_Public_set_Void_PlayerNotifications_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerJoinedEvent_Public_get_PlayerJoinedEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerLeftEvent_Public_get_PlayerLeftEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onPlayerJoined_Public_add_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onPlayerJoined_Public_rem_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onPlayerLeft_Public_add_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onPlayerLeft_Public_rem_Void_Action_1_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerPrefab_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerPrefab_Public_set_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerInputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instance_Private_Static_set_Void_PlayerInputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableJoining_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableJoining_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinPlayerFromUI_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinPlayerFromAction_Public_Void_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinPlayerFromActionIfNotAlreadyJoined_Public_Void_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinPlayer_Public_PlayerInput_Int32_Int32_String_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinPlayer_Public_PlayerInput_Int32_Int32_String_Il2CppReferenceArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_messages_Internal_Static_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfPlayerCanJoin_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUnpairedDeviceUsed_Private_Void_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSplitScreen_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDeviceUsableWithPlayerActions_Private_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateInputActionAsset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyPlayerJoined_Internal_Void_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyPlayerLeft_Internal_Void_PlayerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string PlayerJoinedMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerJoinedMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerJoinedMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PlayerLeftMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerLeftMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerLeftMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static PlayerInputManager _instance_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInputManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe int m_MaxPlayerCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxPlayerCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxPlayerCount)) = value;
		}
	}

	public unsafe bool m_AllowJoining
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowJoining);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowJoining)) = value;
		}
	}

	public unsafe PlayerJoinBehavior m_JoinBehavior
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinBehavior);
			return *(PlayerJoinBehavior*)num;
		}
		set
		{
			*(PlayerJoinBehavior*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinBehavior)) = value;
		}
	}

	public unsafe PlayerJoinedEvent m_PlayerJoinedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerJoinedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerJoinedEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerJoinedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PlayerLeftEvent m_PlayerLeftEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerLeftEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerLeftEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerLeftEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputActionProperty m_JoinAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GameObject m_PlayerPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_SplitScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitScreen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitScreen)) = value;
		}
	}

	public unsafe bool m_MaintainAspectRatioInSplitScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaintainAspectRatioInSplitScreen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaintainAspectRatioInSplitScreen)) = value;
		}
	}

	public unsafe int m_FixedNumberOfSplitScreens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FixedNumberOfSplitScreens);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FixedNumberOfSplitScreens)) = value;
		}
	}

	public unsafe Rect m_SplitScreenRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitScreenRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitScreenRect)) = value;
		}
	}

	public unsafe bool m_JoinActionDelegateHooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinActionDelegateHooked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinActionDelegateHooked)) = value;
		}
	}

	public unsafe bool m_UnpairedDeviceUsedDelegateHooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegateHooked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegateHooked)) = value;
		}
	}

	public unsafe Il2CppSystem.Action<InputAction.CallbackContext> m_JoinActionDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinActionDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputAction.CallbackContext>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JoinActionDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe CallbackArray<Il2CppSystem.Action<PlayerInput>> m_PlayerJoinedCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerJoinedCallbacks);
			return new CallbackArray<Il2CppSystem.Action<PlayerInput>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerJoinedCallbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CallbackArray<Il2CppSystem.Action<PlayerInput>> m_PlayerLeftCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerLeftCallbacks);
			return new CallbackArray<Il2CppSystem.Action<PlayerInput>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerLeftCallbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<PlayerInput>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool splitScreen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_splitScreen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998687, XrefRangeEnd = 998720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_splitScreen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool maintainAspectRatioInSplitScreen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maintainAspectRatioInSplitScreen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int fixedNumberOfSplitScreens
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedNumberOfSplitScreens_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Rect splitScreenArea
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_splitScreenArea_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int playerCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998720, XrefRangeEnd = 998724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int maxPlayerCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool joiningEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joiningEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe PlayerJoinBehavior joinBehavior
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joinBehavior_Public_get_PlayerJoinBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayerJoinBehavior*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joinBehavior_Public_set_Void_PlayerJoinBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty joinAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joinAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998724, XrefRangeEnd = 998729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joinAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe PlayerNotifications notificationBehavior
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_notificationBehavior_Public_get_PlayerNotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayerNotifications*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe PlayerJoinedEvent playerJoinedEvent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998729, XrefRangeEnd = 998736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerJoinedEvent_Public_get_PlayerJoinedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerJoinedEvent>(intPtr2) : null;
		}
	}

	public unsafe PlayerLeftEvent playerLeftEvent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998736, XrefRangeEnd = 998743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerLeftEvent_Public_get_PlayerLeftEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerLeftEvent>(intPtr2) : null;
		}
	}

	public unsafe GameObject playerPrefab
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerPrefab_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerPrefab_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static PlayerInputManager instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998779, XrefRangeEnd = 998781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerInputManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInputManager>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998781, XrefRangeEnd = 998785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instance_Private_Static_set_Void_PlayerInputManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Il2CppStringArray messages
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998892, XrefRangeEnd = 998901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_messages_Internal_Static_get_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	static PlayerInputManager()
	{
		Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "PlayerInputManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerJoinedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "PlayerJoinedMessage");
		NativeFieldInfoPtr_PlayerLeftMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "PlayerLeftMessage");
		NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "<instance>k__BackingField");
		NativeFieldInfoPtr_m_NotificationBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_NotificationBehavior");
		NativeFieldInfoPtr_m_MaxPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_MaxPlayerCount");
		NativeFieldInfoPtr_m_AllowJoining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_AllowJoining");
		NativeFieldInfoPtr_m_JoinBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_JoinBehavior");
		NativeFieldInfoPtr_m_PlayerJoinedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_PlayerJoinedEvent");
		NativeFieldInfoPtr_m_PlayerLeftEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_PlayerLeftEvent");
		NativeFieldInfoPtr_m_JoinAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_JoinAction");
		NativeFieldInfoPtr_m_PlayerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_PlayerPrefab");
		NativeFieldInfoPtr_m_SplitScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_SplitScreen");
		NativeFieldInfoPtr_m_MaintainAspectRatioInSplitScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_MaintainAspectRatioInSplitScreen");
		NativeFieldInfoPtr_m_FixedNumberOfSplitScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_FixedNumberOfSplitScreens");
		NativeFieldInfoPtr_m_SplitScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_SplitScreenRect");
		NativeFieldInfoPtr_m_JoinActionDelegateHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_JoinActionDelegateHooked");
		NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegateHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_UnpairedDeviceUsedDelegateHooked");
		NativeFieldInfoPtr_m_JoinActionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_JoinActionDelegate");
		NativeFieldInfoPtr_m_UnpairedDeviceUsedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_UnpairedDeviceUsedDelegate");
		NativeFieldInfoPtr_m_PlayerJoinedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_PlayerJoinedCallbacks");
		NativeFieldInfoPtr_m_PlayerLeftCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, "m_PlayerLeftCallbacks");
		NativeMethodInfoPtr_get_splitScreen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666318);
		NativeMethodInfoPtr_set_splitScreen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666319);
		NativeMethodInfoPtr_get_maintainAspectRatioInSplitScreen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666320);
		NativeMethodInfoPtr_get_fixedNumberOfSplitScreens_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666321);
		NativeMethodInfoPtr_get_splitScreenArea_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666322);
		NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666323);
		NativeMethodInfoPtr_get_maxPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666324);
		NativeMethodInfoPtr_get_joiningEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666325);
		NativeMethodInfoPtr_get_joinBehavior_Public_get_PlayerJoinBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666326);
		NativeMethodInfoPtr_set_joinBehavior_Public_set_Void_PlayerJoinBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666327);
		NativeMethodInfoPtr_get_joinAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666328);
		NativeMethodInfoPtr_set_joinAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666329);
		NativeMethodInfoPtr_get_notificationBehavior_Public_get_PlayerNotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666330);
		NativeMethodInfoPtr_set_notificationBehavior_Public_set_Void_PlayerNotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666331);
		NativeMethodInfoPtr_get_playerJoinedEvent_Public_get_PlayerJoinedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666332);
		NativeMethodInfoPtr_get_playerLeftEvent_Public_get_PlayerLeftEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666333);
		NativeMethodInfoPtr_add_onPlayerJoined_Public_add_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666334);
		NativeMethodInfoPtr_remove_onPlayerJoined_Public_rem_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666335);
		NativeMethodInfoPtr_add_onPlayerLeft_Public_add_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666336);
		NativeMethodInfoPtr_remove_onPlayerLeft_Public_rem_Void_Action_1_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666337);
		NativeMethodInfoPtr_get_playerPrefab_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666338);
		NativeMethodInfoPtr_set_playerPrefab_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666339);
		NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666340);
		NativeMethodInfoPtr_set_instance_Private_Static_set_Void_PlayerInputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_EnableJoining_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_DisableJoining_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666343);
		NativeMethodInfoPtr_JoinPlayerFromUI_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_JoinPlayerFromAction_Public_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr_JoinPlayerFromActionIfNotAlreadyJoined_Public_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr_JoinPlayer_Public_PlayerInput_Int32_Int32_String_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr_JoinPlayer_Public_PlayerInput_Int32_Int32_String_Il2CppReferenceArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_get_messages_Internal_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr_CheckIfPlayerCanJoin_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_OnUnpairedDeviceUsed_Private_Void_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666353);
		NativeMethodInfoPtr_UpdateSplitScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666354);
		NativeMethodInfoPtr_IsDeviceUsableWithPlayerActions_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666355);
		NativeMethodInfoPtr_ValidateInputActionAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666356);
		NativeMethodInfoPtr_NotifyPlayerJoined_Internal_Void_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666357);
		NativeMethodInfoPtr_NotifyPlayerLeft_Internal_Void_PlayerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666358);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr, 100666359);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998743, XrefRangeEnd = 998752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onPlayerJoined(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onPlayerJoined_Public_add_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998752, XrefRangeEnd = 998761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onPlayerJoined(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onPlayerJoined_Public_rem_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998761, XrefRangeEnd = 998770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onPlayerLeft(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onPlayerLeft_Public_add_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998770, XrefRangeEnd = 998779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onPlayerLeft(Il2CppSystem.Action<PlayerInput> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onPlayerLeft_Public_rem_Void_Action_1_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998805, RefRangeEnd = 998808, XrefRangeStart = 998785, XrefRangeEnd = 998805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableJoining()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableJoining_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998817, RefRangeEnd = 998820, XrefRangeStart = 998808, XrefRangeEnd = 998817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableJoining()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableJoining_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998820, XrefRangeEnd = 998821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoinPlayerFromUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinPlayerFromUI_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998821, XrefRangeEnd = 998824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoinPlayerFromAction(InputAction.CallbackContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinPlayerFromAction_Public_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998824, XrefRangeEnd = 998835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinPlayerFromActionIfNotAlreadyJoined_Public_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 998862, RefRangeEnd = 998865, XrefRangeStart = 998835, XrefRangeEnd = 998862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, InputDevice pairWithDevice = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitScreenIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlScheme);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairWithDevice);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinPlayer_Public_PlayerInput_Int32_Int32_String_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998865, XrefRangeEnd = 998892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, [Optional] Il2CppReferenceArray<InputDevice> pairWithDevices)
	{
		if (pairWithDevices == null)
		{
			pairWithDevices = new Il2CppReferenceArray<InputDevice>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitScreenIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlScheme);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairWithDevices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinPlayer_Public_PlayerInput_Int32_Int32_String_Il2CppReferenceArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 998920, RefRangeEnd = 998925, XrefRangeStart = 998901, XrefRangeEnd = 998920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIfPlayerCanJoin(int playerIndex = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfPlayerCanJoin_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998925, XrefRangeEnd = 998929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998929, XrefRangeEnd = 998982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998982, XrefRangeEnd = 998993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 999080, RefRangeEnd = 999084, XrefRangeStart = 998993, XrefRangeEnd = 999080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSplitScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSplitScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 999141, RefRangeEnd = 999142, XrefRangeStart = 999084, XrefRangeEnd = 999141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDeviceUsableWithPlayerActions(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDeviceUsableWithPlayerActions_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateInputActionAsset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateInputActionAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 999150, RefRangeEnd = 999152, XrefRangeStart = 999142, XrefRangeEnd = 999150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyPlayerJoined(PlayerInput player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyPlayerJoined_Internal_Void_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999152, XrefRangeEnd = 999160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyPlayerLeft(PlayerInput player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyPlayerLeft_Internal_Void_PlayerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999160, XrefRangeEnd = 999161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInputManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInputManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PlayerInput JoinPlayer([Optional] int playerIndex, [Optional] int splitScreenIndex, [Optional] string controlScheme, params InputDevice[] pairWithDevices)
	{
		return JoinPlayer(playerIndex, splitScreenIndex, controlScheme, new Il2CppReferenceArray<InputDevice>(pairWithDevices));
	}

	public PlayerInputManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
