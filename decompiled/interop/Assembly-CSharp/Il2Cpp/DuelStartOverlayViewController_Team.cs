using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomGame.Menu;
using Il2CppYgomSystem.ElementSystem;
using UnityEngine;

namespace Il2Cpp;

public class DuelStartOverlayViewController_Team : BaseMenuViewController
{
	public class TeamInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_info;

		private static readonly System.IntPtr NativeFieldInfoPtr_teamNameMrk;

		private static readonly System.IntPtr NativeFieldInfoPtr_userNum;

		private static readonly System.IntPtr NativeFieldInfoPtr_membersInfo;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Int32_Int32_Dictionary_2_String_Object_0;

		public unsafe Il2CppSystem.Object info
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int teamNameMrk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamNameMrk);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamNameMrk)) = value;
			}
		}

		public unsafe int userNum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userNum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userNum)) = value;
			}
		}

		public unsafe Dictionary<string, Il2CppSystem.Object> membersInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_membersInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_membersInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static TeamInfo()
		{
			Il2CppClassPointerStore<TeamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "TeamInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr);
			NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr, "info");
			NativeFieldInfoPtr_teamNameMrk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr, "teamNameMrk");
			NativeFieldInfoPtr_userNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr, "userNum");
			NativeFieldInfoPtr_membersInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr, "membersInfo");
			NativeMethodInfoPtr__ctor_Public_Void_Object_Int32_Int32_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr, 100664023);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37886, XrefRangeEnd = 37889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TeamInfo(Il2CppSystem.Object info, int teamNameMrk, int userNum, Dictionary<string, Il2CppSystem.Object> membersInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeamInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &teamNameMrk;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &userNum;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)membersInfo);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_Int32_Int32_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TeamInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PREFAB_PATH;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFinish;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_TweenFinish;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_RootPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_RootRival;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_TextTeamName;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_RootProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_ImageIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_PlatformPlayerIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_E_PlatformPlayerNameGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerEom;

	private static readonly System.IntPtr NativeFieldInfoPtr_rivalEom;

	private static readonly System.IntPtr NativeFieldInfoPtr_tweenFinish;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MEMBERS;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCreatedView_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispTeam_Private_Void_Int32_ElementObjectManager_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTeam_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTeamInfo_Private_TeamInfo_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTeam_Private_Void_ElementObjectManager_TeamInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHideObject_Public_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string PREFAB_PATH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PREFAB_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PREFAB_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool isFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFinish);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFinish)) = value;
		}
	}

	public unsafe string E_TweenFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_TweenFinish);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_TweenFinish)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_RootPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_RootPlayer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_RootPlayer)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_RootRival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_RootRival);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_RootRival)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_TextTeamName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_TextTeamName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_TextTeamName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_RootProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_RootProfile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_RootProfile)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_ImageIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_ImageIcon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_ImageIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_PlatformPlayerIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_PlatformPlayerIcon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_PlatformPlayerIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string E_PlatformPlayerNameGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_PlatformPlayerNameGroup);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E_PlatformPlayerNameGroup)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ElementObjectManager playerEom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerEom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerEom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager rivalEom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rivalEom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rivalEom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject tweenFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tweenFinish);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tweenFinish)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int MAX_MEMBERS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAX_MEMBERS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAX_MEMBERS)) = value;
		}
	}

	static DuelStartOverlayViewController_Team()
	{
		Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DuelStartOverlayViewController_Team");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr);
		NativeFieldInfoPtr_PREFAB_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "PREFAB_PATH");
		NativeFieldInfoPtr_isFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "isFinish");
		NativeFieldInfoPtr_E_TweenFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_TweenFinish");
		NativeFieldInfoPtr_E_RootPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_RootPlayer");
		NativeFieldInfoPtr_E_RootRival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_RootRival");
		NativeFieldInfoPtr_E_TextTeamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_TextTeamName");
		NativeFieldInfoPtr_E_RootProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_RootProfile");
		NativeFieldInfoPtr_E_ImageIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_ImageIcon");
		NativeFieldInfoPtr_E_PlatformPlayerIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_PlatformPlayerIcon");
		NativeFieldInfoPtr_E_PlatformPlayerNameGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "E_PlatformPlayerNameGroup");
		NativeFieldInfoPtr_playerEom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "playerEom");
		NativeFieldInfoPtr_rivalEom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "rivalEom");
		NativeFieldInfoPtr_tweenFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "tweenFinish");
		NativeFieldInfoPtr_MAX_MEMBERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, "MAX_MEMBERS");
		NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_OnCreatedView_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_DispTeam_Private_Void_Int32_ElementObjectManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664014);
		NativeMethodInfoPtr_InitTeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_SetTeamInfo_Private_TeamInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_SetTeam_Private_Void_ElementObjectManager_TeamInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664017);
		NativeMethodInfoPtr_GetHideObject_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664018);
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr, 100664021);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25324, RefRangeEnd = 25325, XrefRangeStart = 25324, XrefRangeEnd = 25325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NotificationStackEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37889, XrefRangeEnd = 37920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCreatedView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCreatedView_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 37948, RefRangeEnd = 37950, XrefRangeStart = 37920, XrefRangeEnd = 37948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispTeam(int myid, ElementObjectManager teamEom, bool isPlayerTeam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&myid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)teamEom);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPlayerTeam;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispTeam_Private_Void_Int32_ElementObjectManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37950, XrefRangeEnd = 37966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTeam()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37966, XrefRangeEnd = 37984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TeamInfo SetTeamInfo(Il2CppSystem.Object teamInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)teamInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTeamInfo_Private_TeamInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TeamInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38104, RefRangeEnd = 38105, XrefRangeStart = 37984, XrefRangeEnd = 38104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTeam(ElementObjectManager eom, TeamInfo teamInfo, bool isPlayerTeam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)teamInfo);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPlayerTeam;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTeam_Private_Void_ElementObjectManager_TeamInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38105, XrefRangeEnd = 38107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetHideObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHideObject_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38107, XrefRangeEnd = 38115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38115, XrefRangeEnd = 38124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38124, XrefRangeEnd = 38157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DuelStartOverlayViewController_Team()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuelStartOverlayViewController_Team>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DuelStartOverlayViewController_Team(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
