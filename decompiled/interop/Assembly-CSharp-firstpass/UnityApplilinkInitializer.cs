using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class UnityApplilinkInitializer : MonoBehaviour
{
	public enum VerboseType
	{
		Off,
		ErrorOnly,
		All
	}

	public enum AdType
	{
		Recommend,
		Reward
	}

	[System.Serializable]
	public class AdItem : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_adType;

		private static readonly System.IntPtr NativeFieldInfoPtr_adName;

		private static readonly System.IntPtr NativeFieldInfoPtr_adModel;

		private static readonly System.IntPtr NativeFieldInfoPtr_adLocation;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe AdType adType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adType);
				return *(AdType*)num;
			}
			set
			{
				*(AdType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adType)) = value;
			}
		}

		public unsafe string adName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe UnityApplilinkPlugin.AdModel adModel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModel);
				return *(UnityApplilinkPlugin.AdModel*)num;
			}
			set
			{
				*(UnityApplilinkPlugin.AdModel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adModel)) = value;
			}
		}

		public unsafe string adLocation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adLocation);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adLocation)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static AdItem()
		{
			Il2CppClassPointerStore<AdItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "AdItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdItem>.NativeClassPtr);
			NativeFieldInfoPtr_adType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdItem>.NativeClassPtr, "adType");
			NativeFieldInfoPtr_adName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdItem>.NativeClassPtr, "adName");
			NativeFieldInfoPtr_adModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdItem>.NativeClassPtr, "adModel");
			NativeFieldInfoPtr_adLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdItem>.NativeClassPtr, "adLocation");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdItem>.NativeClassPtr, 100663401);
		}

		[CallerCount(1830)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 21395, XrefRangeStart = 19565, XrefRangeEnd = 21395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdItem>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public AdItem(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_appliId;

	private static readonly System.IntPtr NativeFieldInfoPtr_env;

	private static readonly System.IntPtr NativeFieldInfoPtr_verboseLevelForDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_verboseLevelForRelease;

	private static readonly System.IntPtr NativeFieldInfoPtr_ads;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInitialized;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string appliId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliId)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe UnityApplilinkPlugin.Env env
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_env);
			return *(UnityApplilinkPlugin.Env*)num;
		}
		set
		{
			*(UnityApplilinkPlugin.Env*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_env)) = value;
		}
	}

	public unsafe VerboseType verboseLevelForDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verboseLevelForDefault);
			return *(VerboseType*)num;
		}
		set
		{
			*(VerboseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verboseLevelForDefault)) = value;
		}
	}

	public unsafe VerboseType verboseLevelForRelease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verboseLevelForRelease);
			return *(VerboseType*)num;
		}
		set
		{
			*(VerboseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verboseLevelForRelease)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<AdItem> ads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AdItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool isInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isInitialized, (void*)(&value));
		}
	}

	static UnityApplilinkInitializer()
	{
		Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UnityApplilinkInitializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr);
		NativeFieldInfoPtr_appliId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "appliId");
		NativeFieldInfoPtr_env = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "env");
		NativeFieldInfoPtr_verboseLevelForDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "verboseLevelForDefault");
		NativeFieldInfoPtr_verboseLevelForRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "verboseLevelForRelease");
		NativeFieldInfoPtr_ads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "ads");
		NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, "isInitialized");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr, 100663400);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228987, XrefRangeEnd = 1229020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229020, XrefRangeEnd = 1229029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityApplilinkInitializer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityApplilinkInitializer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnityApplilinkInitializer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
