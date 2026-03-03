using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomGame.WCS.Portal;
using Il2CppYgomSystem.UI;

namespace Il2CppWCSFinal;

public class Util : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("WCSFinal.Util+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__10_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__10_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__10_3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetArgs_b__10_0_Internal_CampaignStatus_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetArgs_b__10_1_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetArgs_b__10_2_Internal_CampaignStatus_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetArgs_b__10_3_Internal_Int32_0;

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

		public unsafe static Il2CppSystem.Func<Def.CampaignStatus> __9__10_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Def.CampaignStatus>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__10_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__10_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__10_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Def.CampaignStatus> __9__10_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Def.CampaignStatus>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__10_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__10_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__10_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__10_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Util>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__10_0");
			NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__10_1");
			NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__10_2");
			NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__10_3");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664975);
			NativeMethodInfoPtr__GetArgs_b__10_0_Internal_CampaignStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664976);
			NativeMethodInfoPtr__GetArgs_b__10_1_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664977);
			NativeMethodInfoPtr__GetArgs_b__10_2_Internal_CampaignStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664978);
			NativeMethodInfoPtr__GetArgs_b__10_3_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664979);
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
		public unsafe Def.CampaignStatus _GetArgs_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetArgs_b__10_0_Internal_CampaignStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Def.CampaignStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48399, XrefRangeEnd = 48405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetArgs_b__10_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetArgs_b__10_1_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe Def.CampaignStatus _GetArgs_b__10_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetArgs_b__10_2_Internal_CampaignStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Def.CampaignStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48405, XrefRangeEnd = 48411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetArgs_b__10_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetArgs_b__10_3_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_APP_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_PREFIX;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_DUELMENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_ADMIN_1STSTAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_ADMIN_TOURNAMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_PROFILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_TEAM_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_TIMER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATH_TIMESETTING;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushChildViewController_Public_Static_Void_ViewControllerManager_String_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArgs_Private_Static_Void_String_byref_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWCSAdmin_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCurrentTimeDispSwicthingTriger_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string APP_VERSION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_APP_VERSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_APP_VERSION, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_PREFIX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_PREFIX, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_PREFIX, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_DUELMENU
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_DUELMENU, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_DUELMENU, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_ADMIN_1STSTAGE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_ADMIN_1STSTAGE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_ADMIN_1STSTAGE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_ADMIN_TOURNAMENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_ADMIN_TOURNAMENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_ADMIN_TOURNAMENT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_PROFILE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_PROFILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_PROFILE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_TEAM_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_TEAM_TABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_TEAM_TABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_TIMER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_TIMER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_TIMER, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PATH_TIMESETTING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATH_TIMESETTING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATH_TIMESETTING, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static Util()
	{
		Il2CppClassPointerStore<Util>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "WCSFinal", "Util");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Util>.NativeClassPtr);
		NativeFieldInfoPtr_APP_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "APP_VERSION");
		NativeFieldInfoPtr_PATH_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_PREFIX");
		NativeFieldInfoPtr_PATH_DUELMENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_DUELMENU");
		NativeFieldInfoPtr_PATH_ADMIN_1STSTAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_ADMIN_1STSTAGE");
		NativeFieldInfoPtr_PATH_ADMIN_TOURNAMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_ADMIN_TOURNAMENT");
		NativeFieldInfoPtr_PATH_PROFILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_PROFILE");
		NativeFieldInfoPtr_PATH_TEAM_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_TEAM_TABLE");
		NativeFieldInfoPtr_PATH_TIMER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_TIMER");
		NativeFieldInfoPtr_PATH_TIMESETTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Util>.NativeClassPtr, "PATH_TIMESETTING");
		NativeMethodInfoPtr_PushChildViewController_Public_Static_Void_ViewControllerManager_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Util>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr_GetArgs_Private_Static_Void_String_byref_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Util>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr_IsWCSAdmin_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Util>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr_CheckCurrentTimeDispSwicthingTriger_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Util>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Util>.NativeClassPtr, 100664973);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48424, RefRangeEnd = 48426, XrefRangeStart = 48411, XrefRangeEnd = 48424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushChildViewController(ViewControllerManager manager, string prefabpath, Dictionary<string, Il2CppSystem.Object> args = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefabpath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushChildViewController_Public_Static_Void_ViewControllerManager_String_Dictionary_2_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48544, RefRangeEnd = 48546, XrefRangeStart = 48426, XrefRangeEnd = 48544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetArgs(string prefabpath, ref Dictionary<string, Il2CppSystem.Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabpath);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArgs_Private_Static_Void_String_byref_Dictionary_2_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		args = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<string, Il2CppSystem.Object>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48556, RefRangeEnd = 48557, XrefRangeStart = 48546, XrefRangeEnd = 48556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWCSAdmin()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWCSAdmin_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48558, RefRangeEnd = 48559, XrefRangeStart = 48557, XrefRangeEnd = 48558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckCurrentTimeDispSwicthingTriger()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCurrentTimeDispSwicthingTriger_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Util()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Util>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Util(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
