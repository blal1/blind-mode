using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Users;

[StructLayout(LayoutKind.Explicit)]
public struct InputUser
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ControlSchemeChangeSyntax
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_UserIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr_AndPairRemainingDevices_Public_ControlSchemeChangeSyntax_0;

		[FieldOffset(0)]
		public int m_UserIndex;

		static ControlSchemeChangeSyntax()
		{
			Il2CppClassPointerStore<ControlSchemeChangeSyntax>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "ControlSchemeChangeSyntax");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlSchemeChangeSyntax>.NativeClassPtr);
			NativeFieldInfoPtr_m_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlSchemeChangeSyntax>.NativeClassPtr, "m_UserIndex");
			NativeMethodInfoPtr_AndPairRemainingDevices_Public_ControlSchemeChangeSyntax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlSchemeChangeSyntax>.NativeClassPtr, 100666638);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1000495, RefRangeEnd = 1000496, XrefRangeStart = 1000491, XrefRangeEnd = 1000495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlSchemeChangeSyntax AndPairRemainingDevices()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AndPairRemainingDevices_Public_ControlSchemeChangeSyntax_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ControlSchemeChangeSyntax*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlSchemeChangeSyntax>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("Unity.InputSystem.dll", "", "UserFlags")]
	[System.Flags]
	public enum UserFlags
	{
		BindToAllDevices = 1,
		UserAccountSelectionInProgress = 2
	}

	public sealed class UserData : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_platformUserAccountHandle;

		private static readonly System.IntPtr NativeFieldInfoPtr_platformUserAccountName;

		private static readonly System.IntPtr NativeFieldInfoPtr_platformUserAccountId;

		private static readonly System.IntPtr NativeFieldInfoPtr_deviceCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_deviceStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_actions;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlScheme;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlSchemeMatch;

		private static readonly System.IntPtr NativeFieldInfoPtr_lostDeviceCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_lostDeviceStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_flags;

		public unsafe Il2CppSystem.Nullable<InputUserAccountHandle> platformUserAccountHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountHandle);
				return new Il2CppSystem.Nullable<InputUserAccountHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputUserAccountHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputUserAccountHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe string platformUserAccountName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string platformUserAccountId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountId);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountId)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int deviceCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceCount)) = value;
			}
		}

		public unsafe int deviceStartIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceStartIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceStartIndex)) = value;
			}
		}

		public unsafe IInputActionCollection actions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInputActionCollection>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Nullable<InputControlScheme> controlScheme
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlScheme);
				return new Il2CppSystem.Nullable<InputControlScheme>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputControlScheme>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlScheme), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<InputControlScheme>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe InputControlScheme.MatchResult controlSchemeMatch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlSchemeMatch);
				return new InputControlScheme.MatchResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputControlScheme.MatchResult>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlSchemeMatch), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputControlScheme.MatchResult>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int lostDeviceCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostDeviceCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostDeviceCount)) = value;
			}
		}

		public unsafe int lostDeviceStartIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostDeviceStartIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostDeviceStartIndex)) = value;
			}
		}

		public unsafe UserFlags flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags);
				return *(UserFlags*)num;
			}
			set
			{
				*(UserFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags)) = value;
			}
		}

		static UserData()
		{
			Il2CppClassPointerStore<UserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "UserData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserData>.NativeClassPtr);
			NativeFieldInfoPtr_platformUserAccountHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "platformUserAccountHandle");
			NativeFieldInfoPtr_platformUserAccountName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "platformUserAccountName");
			NativeFieldInfoPtr_platformUserAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "platformUserAccountId");
			NativeFieldInfoPtr_deviceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "deviceCount");
			NativeFieldInfoPtr_deviceStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "deviceStartIndex");
			NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "actions");
			NativeFieldInfoPtr_controlScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "controlScheme");
			NativeFieldInfoPtr_controlSchemeMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "controlSchemeMatch");
			NativeFieldInfoPtr_lostDeviceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "lostDeviceCount");
			NativeFieldInfoPtr_lostDeviceStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "lostDeviceStartIndex");
			NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "flags");
		}

		public UserData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public UserData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserData>.NativeClassPtr))
		{
		}
	}

	public sealed class CompareDevicesByUserAccount : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_platformUserAccountHandle;

		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InputDevice_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetUserAccountHandleForDevice_Private_Static_Nullable_1_InputUserAccountHandle_InputDevice_0;

		public unsafe InputUserAccountHandle platformUserAccountHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountHandle);
				return new InputUserAccountHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputUserAccountHandle>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformUserAccountHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputUserAccountHandle>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static CompareDevicesByUserAccount()
		{
			Il2CppClassPointerStore<CompareDevicesByUserAccount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "CompareDevicesByUserAccount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareDevicesByUserAccount>.NativeClassPtr);
			NativeFieldInfoPtr_platformUserAccountHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareDevicesByUserAccount>.NativeClassPtr, "platformUserAccountHandle");
			NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InputDevice_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareDevicesByUserAccount>.NativeClassPtr, 100666639);
			NativeMethodInfoPtr_GetUserAccountHandleForDevice_Private_Static_Nullable_1_InputUserAccountHandle_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareDevicesByUserAccount>.NativeClassPtr, 100666640);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000496, XrefRangeEnd = 1000528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(InputDevice x, InputDevice y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_InputDevice_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 806201, RefRangeEnd = 806273, XrefRangeStart = 806201, XrefRangeEnd = 806273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppSystem.Nullable<InputUserAccountHandle> GetUserAccountHandleForDevice(InputDevice device)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUserAccountHandleForDevice_Private_Static_Nullable_1_InputUserAccountHandle_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<InputUserAccountHandle>(pointer);
		}

		public CompareDevicesByUserAccount(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CompareDevicesByUserAccount()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareDevicesByUserAccount>.NativeClassPtr))
		{
		}
	}

	public sealed class OngoingAccountSelection : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_device;

		private static readonly System.IntPtr NativeFieldInfoPtr_userId;

		public unsafe InputDevice device
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe uint userId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userId);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userId)) = value;
			}
		}

		static OngoingAccountSelection()
		{
			Il2CppClassPointerStore<OngoingAccountSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "OngoingAccountSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OngoingAccountSelection>.NativeClassPtr);
			NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OngoingAccountSelection>.NativeClassPtr, "device");
			NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OngoingAccountSelection>.NativeClassPtr, "userId");
		}

		public OngoingAccountSelection(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public OngoingAccountSelection()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OngoingAccountSelection>.NativeClassPtr))
		{
		}
	}

	public sealed class GlobalState : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pairingStateVersion;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUserId;

		private static readonly System.IntPtr NativeFieldInfoPtr_allUserCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_allPairedDeviceCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_allLostDeviceCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_allUsers;

		private static readonly System.IntPtr NativeFieldInfoPtr_allUserData;

		private static readonly System.IntPtr NativeFieldInfoPtr_allPairedDevices;

		private static readonly System.IntPtr NativeFieldInfoPtr_allLostDevices;

		private static readonly System.IntPtr NativeFieldInfoPtr_ongoingAccountSelections;

		private static readonly System.IntPtr NativeFieldInfoPtr_onChange;

		private static readonly System.IntPtr NativeFieldInfoPtr_onUnpairedDeviceUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr_onPreFilterUnpairedDeviceUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionChangeDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_onDeviceChangeDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_onEventDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_onActionChangeHooked;

		private static readonly System.IntPtr NativeFieldInfoPtr_onDeviceChangeHooked;

		private static readonly System.IntPtr NativeFieldInfoPtr_onEventHooked;

		private static readonly System.IntPtr NativeFieldInfoPtr_listenForUnpairedDeviceActivity;

		public unsafe int pairingStateVersion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingStateVersion);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingStateVersion)) = value;
			}
		}

		public unsafe uint lastUserId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUserId);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUserId)) = value;
			}
		}

		public unsafe int allUserCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allUserCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allUserCount)) = value;
			}
		}

		public unsafe int allPairedDeviceCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allPairedDeviceCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allPairedDeviceCount)) = value;
			}
		}

		public unsafe int allLostDeviceCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLostDeviceCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLostDeviceCount)) = value;
			}
		}

		public unsafe Il2CppStructArray<InputUser> allUsers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allUsers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputUser>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allUsers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<UserData> allUserData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allUserData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UserData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allUserData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<InputDevice> allPairedDevices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allPairedDevices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDevice>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allPairedDevices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<InputDevice> allLostDevices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLostDevices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDevice>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLostDevices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InlinedArray<OngoingAccountSelection> ongoingAccountSelections
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ongoingAccountSelections);
				return new InlinedArray<OngoingAccountSelection>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<OngoingAccountSelection>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ongoingAccountSelections), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<OngoingAccountSelection>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CallbackArray<Il2CppSystem.Action<InputUser, InputUserChange, InputDevice>> onChange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onChange);
				return new CallbackArray<Il2CppSystem.Action<InputUser, InputUserChange, InputDevice>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<InputUser, InputUserChange, InputDevice>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onChange), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<InputUser, InputUserChange, InputDevice>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CallbackArray<Il2CppSystem.Action<InputControl, InputEventPtr>> onUnpairedDeviceUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUnpairedDeviceUsed);
				return new CallbackArray<Il2CppSystem.Action<InputControl, InputEventPtr>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<InputControl, InputEventPtr>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUnpairedDeviceUsed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<InputControl, InputEventPtr>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CallbackArray<Il2CppSystem.Func<InputDevice, InputEventPtr, bool>> onPreFilterUnpairedDeviceUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPreFilterUnpairedDeviceUsed);
				return new CallbackArray<Il2CppSystem.Func<InputDevice, InputEventPtr, bool>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Func<InputDevice, InputEventPtr, bool>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPreFilterUnpairedDeviceUsed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Func<InputDevice, InputEventPtr, bool>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange> actionChangeDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionChangeDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionChangeDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<InputDevice, InputDeviceChange> onDeviceChangeDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onDeviceChangeDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputDevice, InputDeviceChange>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onDeviceChangeDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<InputEventPtr, InputDevice> onEventDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEventDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputEventPtr, InputDevice>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEventDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool onActionChangeHooked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onActionChangeHooked);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onActionChangeHooked)) = value;
			}
		}

		public unsafe bool onDeviceChangeHooked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onDeviceChangeHooked);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onDeviceChangeHooked)) = value;
			}
		}

		public unsafe bool onEventHooked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEventHooked);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEventHooked)) = value;
			}
		}

		public unsafe int listenForUnpairedDeviceActivity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listenForUnpairedDeviceActivity);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listenForUnpairedDeviceActivity)) = value;
			}
		}

		static GlobalState()
		{
			Il2CppClassPointerStore<GlobalState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "GlobalState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState>.NativeClassPtr);
			NativeFieldInfoPtr_pairingStateVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "pairingStateVersion");
			NativeFieldInfoPtr_lastUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "lastUserId");
			NativeFieldInfoPtr_allUserCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allUserCount");
			NativeFieldInfoPtr_allPairedDeviceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allPairedDeviceCount");
			NativeFieldInfoPtr_allLostDeviceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allLostDeviceCount");
			NativeFieldInfoPtr_allUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allUsers");
			NativeFieldInfoPtr_allUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allUserData");
			NativeFieldInfoPtr_allPairedDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allPairedDevices");
			NativeFieldInfoPtr_allLostDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "allLostDevices");
			NativeFieldInfoPtr_ongoingAccountSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "ongoingAccountSelections");
			NativeFieldInfoPtr_onChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onChange");
			NativeFieldInfoPtr_onUnpairedDeviceUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onUnpairedDeviceUsed");
			NativeFieldInfoPtr_onPreFilterUnpairedDeviceUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onPreFilterUnpairedDeviceUsed");
			NativeFieldInfoPtr_actionChangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "actionChangeDelegate");
			NativeFieldInfoPtr_onDeviceChangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onDeviceChangeDelegate");
			NativeFieldInfoPtr_onEventDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onEventDelegate");
			NativeFieldInfoPtr_onActionChangeHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onActionChangeHooked");
			NativeFieldInfoPtr_onDeviceChangeHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onDeviceChangeHooked");
			NativeFieldInfoPtr_onEventHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onEventHooked");
			NativeFieldInfoPtr_listenForUnpairedDeviceActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "listenForUnpairedDeviceActivity");
		}

		public GlobalState(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GlobalState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.InputSystem.Users.InputUser+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__88_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__88_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveAndResetState_b__88_0_Internal_Void_byref_GlobalState_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveAndResetState_b__88_1_Internal_Void_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static SavedStructState<GlobalState>.TypedRestore __9__88_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__88_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SavedStructState<GlobalState>.TypedRestore>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__88_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action __9__88_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__88_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__88_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__88_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__88_0");
			NativeFieldInfoPtr___9__88_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__88_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666642);
			NativeMethodInfoPtr__SaveAndResetState_b__88_0_Internal_Void_byref_GlobalState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666643);
			NativeMethodInfoPtr__SaveAndResetState_b__88_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666644);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000528, XrefRangeEnd = 1000534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveAndResetState_b__88_0(ref GlobalState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveAndResetState_b__88_0_Internal_Void_byref_GlobalState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000534, XrefRangeEnd = 1000538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveAndResetState_b__88_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveAndResetState_b__88_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputUserOnChangeMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputCheckForUnpairMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlobalState;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_platformUserAccountHandle_Public_get_Nullable_1_InputUserAccountHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_platformUserAccountName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_platformUserAccountId_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pairedDevices_Public_get_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lostDevices_Public_get_ReadOnlyArray_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actions_Public_get_IInputActionCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlScheme_Public_get_Nullable_1_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlSchemeMatch_Public_get_MatchResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasMissingRequiredDevices_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_InputUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onChange_Public_Static_add_Void_Action_3_InputUser_InputUserChange_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onChange_Public_Static_rem_Void_Action_3_InputUser_InputUserChange_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onUnpairedDeviceUsed_Public_Static_add_Void_Action_2_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onUnpairedDeviceUsed_Public_Static_rem_Void_Action_2_InputControl_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onPrefilterUnpairedDeviceActivity_Public_Static_add_Void_Func_3_InputDevice_InputEventPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onPrefilterUnpairedDeviceActivity_Public_Static_rem_Void_Func_3_InputDevice_InputEventPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_listenForUnpairedDeviceActivity_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_listenForUnpairedDeviceActivity_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssociateActionsWithUser_Public_Void_IInputActionCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateControlScheme_Public_ControlSchemeChangeSyntax_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindControlScheme_Private_Boolean_String_byref_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControlScheme_Internal_Void_String_byref_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateControlScheme_Public_ControlSchemeChangeSyntax_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateControlSchemeInternal_Private_Void_Int32_InputControlScheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpairDevice_Public_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpairDevices_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLostDevicesForUser_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpairDevicesAndRemoveUser_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnpairedInputDevices_Public_Static_InputControlList_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnpairedInputDevices_Public_Static_Int32_byref_InputControlList_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUserPairedToDevice_Public_Static_Nullable_1_InputUser_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUserByAccount_Public_Static_Nullable_1_InputUser_InputUserAccountHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUserWithoutPairedDevices_Public_Static_InputUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformPairingWithDevice_Public_Static_InputUser_InputDevice_InputUser_InputUserPairingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitiateUserAccountSelection_Private_Static_Boolean_Int32_InputDevice_InputUserPairingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputUser_InputUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputUser_InputUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUser_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUser_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Notify_Private_Static_Void_Int32_InputUserChange_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_InputUserAccountHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDeviceToUser_Private_Static_Void_Int32_InputDevice_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDeviceFromUser_Private_Static_Void_Int32_InputDevice_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateControlSchemeMatch_Private_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlatformUserAccount_Private_Static_Int64_Int32_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryPairedPlatformUserAccount_Private_Static_Int64_InputDevice_byref_Nullable_1_InputUserAccountHandle_byref_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitiateUserAccountSelectionAtPlatformLevel_Private_Static_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeviceChange_Private_Static_Void_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLostDevice_Private_Static_Int32_InputDevice_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEvent_Private_Static_Void_InputEventPtr_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveAndResetState_Internal_Static_ISavedState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HookIntoActionChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnhookFromActionChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HookIntoDeviceChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnhookFromDeviceChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HookIntoEvents_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnhookFromDeviceStateChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeAndResetGlobalState_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGlobals_Internal_Static_Void_0;

	[FieldOffset(0)]
	public uint m_Id;

	public unsafe static uint InvalidId
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidId, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_InputUserOnChangeMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputUserOnChangeMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputUserOnChangeMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_InputCheckForUnpairMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputCheckForUnpairMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputCheckForUnpairMarker, (void*)(&value));
		}
	}

	public unsafe static GlobalState s_GlobalState
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalState, (void*)intPtr);
			return new GlobalState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalState, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe bool valid
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1000545, RefRangeEnd = 1000561, XrefRangeStart = 1000538, XrefRangeEnd = 1000545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valid_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int index
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1000572, RefRangeEnd = 1000604, XrefRangeStart = 1000561, XrefRangeEnd = 1000572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_index_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint id
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Nullable<InputUserAccountHandle> platformUserAccountHandle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000604, XrefRangeEnd = 1000609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_platformUserAccountHandle_Public_get_Nullable_1_InputUserAccountHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<InputUserAccountHandle>(pointer);
		}
	}

	public unsafe string platformUserAccountName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000609, XrefRangeEnd = 1000614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_platformUserAccountName_Public_get_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string platformUserAccountId
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000614, XrefRangeEnd = 1000619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_platformUserAccountId_Public_get_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe ReadOnlyArray<InputDevice> pairedDevices
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1000627, RefRangeEnd = 1000635, XrefRangeStart = 1000619, XrefRangeEnd = 1000627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pairedDevices_Public_get_ReadOnlyArray_1_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputDevice>(pointer);
		}
	}

	public unsafe ReadOnlyArray<InputDevice> lostDevices
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000635, XrefRangeEnd = 1000643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lostDevices_Public_get_ReadOnlyArray_1_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputDevice>(pointer);
		}
	}

	public unsafe IInputActionCollection actions
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1000648, RefRangeEnd = 1000649, XrefRangeStart = 1000643, XrefRangeEnd = 1000648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actions_Public_get_IInputActionCollection_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInputActionCollection>(intPtr2) : null;
		}
	}

	public unsafe Il2CppSystem.Nullable<InputControlScheme> controlScheme
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1000654, RefRangeEnd = 1000656, XrefRangeStart = 1000649, XrefRangeEnd = 1000654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlScheme_Public_get_Nullable_1_InputControlScheme_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<InputControlScheme>(pointer);
		}
	}

	public unsafe InputControlScheme.MatchResult controlSchemeMatch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000656, XrefRangeEnd = 1000661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlSchemeMatch_Public_get_MatchResult_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputControlScheme.MatchResult(pointer);
		}
	}

	public unsafe bool hasMissingRequiredDevices
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000661, XrefRangeEnd = 1000669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasMissingRequiredDevices_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static ReadOnlyArray<InputUser> all
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000669, XrefRangeEnd = 1000676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_InputUser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InputUser>(pointer);
		}
	}

	public unsafe static int listenForUnpairedDeviceActivity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000756, XrefRangeEnd = 1000760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_listenForUnpairedDeviceActivity_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1000777, RefRangeEnd = 1000781, XrefRangeStart = 1000760, XrefRangeEnd = 1000777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_listenForUnpairedDeviceActivity_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static InputUser()
	{
		Il2CppClassPointerStore<InputUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Users", "InputUser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputUser>.NativeClassPtr);
		NativeFieldInfoPtr_InvalidId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "InvalidId");
		NativeFieldInfoPtr_k_InputUserOnChangeMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "k_InputUserOnChangeMarker");
		NativeFieldInfoPtr_k_InputCheckForUnpairMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "k_InputCheckForUnpairMarker");
		NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "m_Id");
		NativeFieldInfoPtr_s_GlobalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputUser>.NativeClassPtr, "s_GlobalState");
		NativeMethodInfoPtr_get_valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666568);
		NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666569);
		NativeMethodInfoPtr_get_id_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666570);
		NativeMethodInfoPtr_get_platformUserAccountHandle_Public_get_Nullable_1_InputUserAccountHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666571);
		NativeMethodInfoPtr_get_platformUserAccountName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666572);
		NativeMethodInfoPtr_get_platformUserAccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666573);
		NativeMethodInfoPtr_get_pairedDevices_Public_get_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666574);
		NativeMethodInfoPtr_get_lostDevices_Public_get_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666575);
		NativeMethodInfoPtr_get_actions_Public_get_IInputActionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666576);
		NativeMethodInfoPtr_get_controlScheme_Public_get_Nullable_1_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666577);
		NativeMethodInfoPtr_get_controlSchemeMatch_Public_get_MatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666578);
		NativeMethodInfoPtr_get_hasMissingRequiredDevices_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666579);
		NativeMethodInfoPtr_get_all_Public_Static_get_ReadOnlyArray_1_InputUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666580);
		NativeMethodInfoPtr_add_onChange_Public_Static_add_Void_Action_3_InputUser_InputUserChange_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666581);
		NativeMethodInfoPtr_remove_onChange_Public_Static_rem_Void_Action_3_InputUser_InputUserChange_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666582);
		NativeMethodInfoPtr_add_onUnpairedDeviceUsed_Public_Static_add_Void_Action_2_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666583);
		NativeMethodInfoPtr_remove_onUnpairedDeviceUsed_Public_Static_rem_Void_Action_2_InputControl_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666584);
		NativeMethodInfoPtr_add_onPrefilterUnpairedDeviceActivity_Public_Static_add_Void_Func_3_InputDevice_InputEventPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666585);
		NativeMethodInfoPtr_remove_onPrefilterUnpairedDeviceActivity_Public_Static_rem_Void_Func_3_InputDevice_InputEventPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666586);
		NativeMethodInfoPtr_get_listenForUnpairedDeviceActivity_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666587);
		NativeMethodInfoPtr_set_listenForUnpairedDeviceActivity_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666588);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666589);
		NativeMethodInfoPtr_AssociateActionsWithUser_Public_Void_IInputActionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666590);
		NativeMethodInfoPtr_ActivateControlScheme_Public_ControlSchemeChangeSyntax_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666591);
		NativeMethodInfoPtr_TryFindControlScheme_Private_Boolean_String_byref_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666592);
		NativeMethodInfoPtr_FindControlScheme_Internal_Void_String_byref_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666593);
		NativeMethodInfoPtr_ActivateControlScheme_Public_ControlSchemeChangeSyntax_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666594);
		NativeMethodInfoPtr_ActivateControlSchemeInternal_Private_Void_Int32_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666595);
		NativeMethodInfoPtr_UnpairDevice_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666596);
		NativeMethodInfoPtr_UnpairDevices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666597);
		NativeMethodInfoPtr_RemoveLostDevicesForUser_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666598);
		NativeMethodInfoPtr_UnpairDevicesAndRemoveUser_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666599);
		NativeMethodInfoPtr_GetUnpairedInputDevices_Public_Static_InputControlList_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666600);
		NativeMethodInfoPtr_GetUnpairedInputDevices_Public_Static_Int32_byref_InputControlList_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666601);
		NativeMethodInfoPtr_FindUserPairedToDevice_Public_Static_Nullable_1_InputUser_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666602);
		NativeMethodInfoPtr_FindUserByAccount_Public_Static_Nullable_1_InputUser_InputUserAccountHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666603);
		NativeMethodInfoPtr_CreateUserWithoutPairedDevices_Public_Static_InputUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666604);
		NativeMethodInfoPtr_PerformPairingWithDevice_Public_Static_InputUser_InputDevice_InputUser_InputUserPairingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666605);
		NativeMethodInfoPtr_InitiateUserAccountSelection_Private_Static_Boolean_Int32_InputDevice_InputUserPairingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666606);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666607);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666608);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputUser_InputUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputUser_InputUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666611);
		NativeMethodInfoPtr_AddUser_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666612);
		NativeMethodInfoPtr_RemoveUser_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_Notify_Private_Static_Void_Int32_InputUserChange_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_InputUserAccountHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_AddDeviceToUser_Private_Static_Void_Int32_InputDevice_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_RemoveDeviceFromUser_Private_Static_Void_Int32_InputDevice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_UpdateControlSchemeMatch_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_UpdatePlatformUserAccount_Private_Static_Int64_Int32_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_QueryPairedPlatformUserAccount_Private_Static_Int64_InputDevice_byref_Nullable_1_InputUserAccountHandle_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_InitiateUserAccountSelectionAtPlatformLevel_Private_Static_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666623);
		NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666624);
		NativeMethodInfoPtr_OnDeviceChange_Private_Static_Void_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666625);
		NativeMethodInfoPtr_FindLostDevice_Private_Static_Int32_InputDevice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666626);
		NativeMethodInfoPtr_OnEvent_Private_Static_Void_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666627);
		NativeMethodInfoPtr_SaveAndResetState_Internal_Static_ISavedState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666628);
		NativeMethodInfoPtr_HookIntoActionChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666629);
		NativeMethodInfoPtr_UnhookFromActionChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666630);
		NativeMethodInfoPtr_HookIntoDeviceChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666631);
		NativeMethodInfoPtr_UnhookFromDeviceChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666632);
		NativeMethodInfoPtr_HookIntoEvents_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666633);
		NativeMethodInfoPtr_UnhookFromDeviceStateChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr_DisposeAndResetGlobalState_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr_ResetGlobals_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUser>.NativeClassPtr, 100666636);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000676, XrefRangeEnd = 1000689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onChange(Il2CppSystem.Action<InputUser, InputUserChange, InputDevice> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onChange_Public_Static_add_Void_Action_3_InputUser_InputUserChange_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000689, XrefRangeEnd = 1000702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onChange(Il2CppSystem.Action<InputUser, InputUserChange, InputDevice> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onChange_Public_Static_rem_Void_Action_3_InputUser_InputUserChange_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000712, RefRangeEnd = 1000714, XrefRangeStart = 1000702, XrefRangeEnd = 1000712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onUnpairedDeviceUsed(Il2CppSystem.Action<InputControl, InputEventPtr> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onUnpairedDeviceUsed_Public_Static_add_Void_Action_2_InputControl_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000728, RefRangeEnd = 1000730, XrefRangeStart = 1000714, XrefRangeEnd = 1000728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onUnpairedDeviceUsed(Il2CppSystem.Action<InputControl, InputEventPtr> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onUnpairedDeviceUsed_Public_Static_rem_Void_Action_2_InputControl_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000730, XrefRangeEnd = 1000743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onPrefilterUnpairedDeviceActivity(Il2CppSystem.Func<InputDevice, InputEventPtr, bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onPrefilterUnpairedDeviceActivity_Public_Static_add_Void_Func_3_InputDevice_InputEventPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000743, XrefRangeEnd = 1000756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onPrefilterUnpairedDeviceActivity(Il2CppSystem.Func<InputDevice, InputEventPtr, bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onPrefilterUnpairedDeviceActivity_Public_Static_rem_Void_Func_3_InputDevice_InputEventPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000781, XrefRangeEnd = 1000817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000888, RefRangeEnd = 1000890, XrefRangeStart = 1000817, XrefRangeEnd = 1000888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssociateActionsWithUser(IInputActionCollection actions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssociateActionsWithUser_Public_Void_IInputActionCollection_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000890, XrefRangeEnd = 1000898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlSchemeChangeSyntax ActivateControlScheme(string schemeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateControlScheme_Public_ControlSchemeChangeSyntax_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ControlSchemeChangeSyntax*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1000916, RefRangeEnd = 1000917, XrefRangeStart = 1000898, XrefRangeEnd = 1000916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryFindControlScheme(string schemeName, out InputControlScheme scheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindControlScheme_Private_Boolean_String_byref_InputControlScheme_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		scheme = ((num3 == 0) ? null : new InputControlScheme(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000921, RefRangeEnd = 1000923, XrefRangeStart = 1000917, XrefRangeEnd = 1000921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindControlScheme(string schemeName, out InputControlScheme scheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControlScheme_Internal_Void_String_byref_InputControlScheme_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		scheme = ((num3 == 0) ? null : new InputControlScheme(num3));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1000940, RefRangeEnd = 1000944, XrefRangeStart = 1000923, XrefRangeEnd = 1000940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateControlScheme_Public_ControlSchemeChangeSyntax_InputControlScheme_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ControlSchemeChangeSyntax*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000974, RefRangeEnd = 1000976, XrefRangeStart = 1000944, XrefRangeEnd = 1000974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&userIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scheme));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateControlSchemeInternal_Private_Void_Int32_InputControlScheme_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000987, RefRangeEnd = 1000989, XrefRangeStart = 1000976, XrefRangeEnd = 1000987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnpairDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpairDevice_Public_Void_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1001015, RefRangeEnd = 1001021, XrefRangeStart = 1000989, XrefRangeEnd = 1001015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnpairDevices()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpairDevices_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1001041, RefRangeEnd = 1001044, XrefRangeStart = 1001021, XrefRangeEnd = 1001041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveLostDevicesForUser(int userIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveLostDevicesForUser_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001044, XrefRangeEnd = 1001050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnpairDevicesAndRemoveUser()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpairDevicesAndRemoveUser_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001057, RefRangeEnd = 1001058, XrefRangeStart = 1001050, XrefRangeEnd = 1001057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlList<InputDevice> GetUnpairedInputDevices()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnpairedInputDevices_Public_Static_InputControlList_1_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputControlList<InputDevice>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1001089, RefRangeEnd = 1001092, XrefRangeStart = 1001058, XrefRangeEnd = 1001089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUnpairedInputDevices(ref InputControlList<InputDevice> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnpairedInputDevices_Public_Static_Int32_byref_InputControlList_1_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001116, RefRangeEnd = 1001117, XrefRangeStart = 1001092, XrefRangeEnd = 1001116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<InputUser> FindUserPairedToDevice(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUserPairedToDevice_Public_Static_Nullable_1_InputUser_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<InputUser>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001117, XrefRangeEnd = 1001139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)platformUserAccountHandle));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUserByAccount_Public_Static_Nullable_1_InputUser_InputUserAccountHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<InputUser>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001139, XrefRangeEnd = 1001144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputUser CreateUserWithoutPairedDevices()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUserWithoutPairedDevices_Public_Static_InputUser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InputUser*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1001167, RefRangeEnd = 1001171, XrefRangeStart = 1001144, XrefRangeEnd = 1001167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputUser PerformPairingWithDevice(InputDevice device, InputUser user = default(InputUser), InputUserPairingOptions options = InputUserPairingOptions.None)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &user;
		*(InputUserPairingOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformPairingWithDevice_Public_Static_InputUser_InputDevice_InputUser_InputUserPairingOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InputUser*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001182, RefRangeEnd = 1001183, XrefRangeStart = 1001171, XrefRangeEnd = 1001182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&userIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputUserPairingOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitiateUserAccountSelection_Private_Static_Boolean_Int32_InputDevice_InputUserPairingOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 687938, RefRangeEnd = 687951, XrefRangeStart = 687938, XrefRangeEnd = 687951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(InputUser other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputUser_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001183, XrefRangeEnd = 1001188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(175)]
	[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 449651, RefRangeEnd = 449658, XrefRangeStart = 449651, XrefRangeEnd = 449658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(InputUser left, InputUser right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(InputUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputUser_InputUser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(InputUser left, InputUser right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(InputUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputUser_InputUser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001202, RefRangeEnd = 1001204, XrefRangeStart = 1001188, XrefRangeEnd = 1001202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddUser()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUser_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1001251, RefRangeEnd = 1001254, XrefRangeStart = 1001204, XrefRangeEnd = 1001251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveUser(int userIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUser_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1001294, RefRangeEnd = 1001302, XrefRangeStart = 1001254, XrefRangeEnd = 1001294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Notify(int userIndex, InputUserChange change, InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&userIndex);
		*(InputUserChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Notify_Private_Static_Void_Int32_InputUserChange_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001302, XrefRangeEnd = 1001309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryFindUserIndex(uint userId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001309, XrefRangeEnd = 1001320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryFindUserIndex(InputUserAccountHandle platformHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)platformHandle));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_InputUserAccountHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001320, XrefRangeEnd = 1001336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryFindUserIndex(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindUserIndex_Private_Static_Int32_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001429, RefRangeEnd = 1001431, XrefRangeStart = 1001336, XrefRangeEnd = 1001429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&userIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &asLostDevice;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dontUpdateControlScheme;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDeviceToUser_Private_Static_Void_Int32_InputDevice_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001525, RefRangeEnd = 1001527, XrefRangeStart = 1001431, XrefRangeEnd = 1001525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&userIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &asLostDevice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDeviceFromUser_Private_Static_Void_Int32_InputDevice_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1001615, RefRangeEnd = 1001620, XrefRangeStart = 1001527, XrefRangeEnd = 1001615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&userIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoPairMissing;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateControlSchemeMatch_Private_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001663, RefRangeEnd = 1001664, XrefRangeStart = 1001620, XrefRangeEnd = 1001663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long UpdatePlatformUserAccount(int userIndex, InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&userIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePlatformUserAccount_Private_Static_Int64_Int32_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001682, RefRangeEnd = 1001683, XrefRangeStart = 1001664, XrefRangeEnd = 1001682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long QueryPairedPlatformUserAccount(InputDevice device, out Il2CppSystem.Nullable<InputUserAccountHandle> platformAccountHandle, out string platformAccountName, out string platformAccountId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryPairedPlatformUserAccount_Private_Static_Int64_InputDevice_byref_Nullable_1_InputUserAccountHandle_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num7 = num2;
		platformAccountHandle = ((num7 == 0) ? null : new Il2CppSystem.Nullable<InputUserAccountHandle>(num7));
		platformAccountName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		platformAccountId = IL2CPP.Il2CppStringToManaged((System.IntPtr)num6);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001683, XrefRangeEnd = 1001687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitiateUserAccountSelectionAtPlatformLevel_Private_Static_Boolean_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001687, XrefRangeEnd = 1001702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnActionChange(Il2CppSystem.Object obj, InputActionChange change)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(InputActionChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001702, XrefRangeEnd = 1001726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputDeviceChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDeviceChange_Private_Static_Void_InputDevice_InputDeviceChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001733, RefRangeEnd = 1001735, XrefRangeStart = 1001726, XrefRangeEnd = 1001733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindLostDevice(InputDevice device, int startIndex = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLostDevice_Private_Static_Int32_InputDevice_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001735, XrefRangeEnd = 1001807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnEvent(InputEventPtr eventPtr, InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEvent_Private_Static_Void_InputEventPtr_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001807, XrefRangeEnd = 1001851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ISavedState SaveAndResetState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAndResetState_Internal_Static_ISavedState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISavedState>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001851, XrefRangeEnd = 1001878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HookIntoActionChange()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HookIntoActionChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001895, RefRangeEnd = 1001897, XrefRangeStart = 1001878, XrefRangeEnd = 1001895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnhookFromActionChange()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnhookFromActionChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001921, RefRangeEnd = 1001922, XrefRangeStart = 1001897, XrefRangeEnd = 1001921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HookIntoDeviceChange()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HookIntoDeviceChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001933, RefRangeEnd = 1001935, XrefRangeStart = 1001922, XrefRangeEnd = 1001933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnhookFromDeviceChange()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnhookFromDeviceChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1001961, RefRangeEnd = 1001963, XrefRangeStart = 1001935, XrefRangeEnd = 1001961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HookIntoEvents()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HookIntoEvents_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1001977, RefRangeEnd = 1001980, XrefRangeStart = 1001963, XrefRangeEnd = 1001977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnhookFromDeviceStateChange()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnhookFromDeviceStateChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001992, RefRangeEnd = 1001993, XrefRangeStart = 1001980, XrefRangeEnd = 1001992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisposeAndResetGlobalState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeAndResetGlobalState_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001993, XrefRangeEnd = 1002011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetGlobals()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGlobals_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputUser>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
