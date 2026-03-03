using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization;

[System.Serializable]
public class CultureInfo : Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Data
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ansi;

		private static readonly System.IntPtr NativeFieldInfoPtr_ebcdic;

		private static readonly System.IntPtr NativeFieldInfoPtr_mac;

		private static readonly System.IntPtr NativeFieldInfoPtr_oem;

		private static readonly System.IntPtr NativeFieldInfoPtr_right_to_left;

		private static readonly System.IntPtr NativeFieldInfoPtr_list_sep;

		[FieldOffset(0)]
		public int ansi;

		[FieldOffset(4)]
		public int ebcdic;

		[FieldOffset(8)]
		public int mac;

		[FieldOffset(12)]
		public int oem;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.U1)]
		public bool right_to_left;

		[FieldOffset(17)]
		public byte list_sep;

		static Data()
		{
			Il2CppClassPointerStore<Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "Data");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Data>.NativeClassPtr);
			NativeFieldInfoPtr_ansi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "ansi");
			NativeFieldInfoPtr_ebcdic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "ebcdic");
			NativeFieldInfoPtr_mac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "mac");
			NativeFieldInfoPtr_oem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "oem");
			NativeFieldInfoPtr_right_to_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "right_to_left");
			NativeFieldInfoPtr_list_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "list_sep");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Data>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class OnCultureInfoChangedDelegate : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

		static OnCultureInfoChangedDelegate()
		{
			Il2CppClassPointerStore<OnCultureInfoChangedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "OnCultureInfoChangedDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCultureInfoChangedDelegate>.NativeClassPtr, 100673270);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCultureInfoChangedDelegate>.NativeClassPtr, 100673271);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnCultureInfoChangedDelegate(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnCultureInfoChangedDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(string language)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnCultureInfoChangedDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnCultureInfoChangedDelegate(System.Action<string> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnCultureInfoChangedDelegate>((System.Delegate)P_0);
		}

		public static OnCultureInfoChangedDelegate operator +(OnCultureInfoChangedDelegate P_0, OnCultureInfoChangedDelegate P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<OnCultureInfoChangedDelegate>();
		}

		public static OnCultureInfoChangedDelegate operator -(OnCultureInfoChangedDelegate P_0, OnCultureInfoChangedDelegate P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnCultureInfoChangedDelegate>();
			}
			return (OnCultureInfoChangedDelegate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_invariant_culture_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_shared_table_lock;

	private static readonly System.IntPtr NativeFieldInfoPtr_default_current_culture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isReadOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_cultureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_parent_lcid;

	private static readonly System.IntPtr NativeFieldInfoPtr_datetime_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_number_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_default_calendar_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_useUserOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_numInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateTimeInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_textInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_englishname;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativename;

	private static readonly System.IntPtr NativeFieldInfoPtr_iso3lang;

	private static readonly System.IntPtr NativeFieldInfoPtr_iso2lang;

	private static readonly System.IntPtr NativeFieldInfoPtr_win3lang;

	private static readonly System.IntPtr NativeFieldInfoPtr_territory;

	private static readonly System.IntPtr NativeFieldInfoPtr_native_calendar_names;

	private static readonly System.IntPtr NativeFieldInfoPtr_compareInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_textinfo_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dataItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_calendar;

	private static readonly System.IntPtr NativeFieldInfoPtr_parent_culture;

	private static readonly System.IntPtr NativeFieldInfoPtr_constructed;

	private static readonly System.IntPtr NativeFieldInfoPtr_cached_serialized_form;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cultureData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isInherited;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvariantCultureId;

	private static readonly System.IntPtr NativeFieldInfoPtr_CalendarTypeBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOCALE_INVARIANT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MSG_READONLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentCulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_shared_by_number;

	private static readonly System.IntPtr NativeFieldInfoPtr_shared_by_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsTaiwanSku;

	private static readonly System.IntPtr NativeMethodInfoPtr_get__cultureData_Internal_get_CultureData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get__isInherited_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Territory_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get__name_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextInfoData_Private_Data_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckNeutral_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Construct_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructLocaleFromName_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SortName_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUserPreferredCultureInfoInAppX_Private_Static_Void_OnCultureInfoChangedDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUserPreferredCultureInfoInAppX_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCultureInfoChangedInAppX_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_Void_CultureInfo_0;

	public unsafe static CultureInfo invariant_culture_info
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_invariant_culture_info, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_invariant_culture_info, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object shared_table_lock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shared_table_lock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shared_table_lock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureInfo default_current_culture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_default_current_culture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_default_current_culture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_isReadOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isReadOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isReadOnly)) = value;
		}
	}

	public unsafe int cultureID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cultureID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cultureID)) = value;
		}
	}

	public unsafe int parent_lcid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent_lcid);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent_lcid)) = value;
		}
	}

	public unsafe int datetime_index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_datetime_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_datetime_index)) = value;
		}
	}

	public unsafe int number_index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_number_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_number_index)) = value;
		}
	}

	public unsafe int default_calendar_type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_default_calendar_type);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_default_calendar_type)) = value;
		}
	}

	public unsafe bool m_useUserOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_useUserOverride);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_useUserOverride)) = value;
		}
	}

	public unsafe NumberFormatInfo numInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DateTimeFormatInfo dateTimeInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateTimeInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateTimeInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextInfo textInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string englishname
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_englishname);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_englishname)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string nativename
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativename);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativename)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string iso3lang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iso3lang);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iso3lang)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string iso2lang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iso2lang);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iso2lang)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string win3lang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_win3lang);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_win3lang)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string territory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_territory);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_territory)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStringArray native_calendar_names
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_native_calendar_names);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_native_calendar_names)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CompareInfo compareInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compareInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compareInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe void* textinfo_data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textinfo_data);
			return *(void**)num;
		}
		set
		{
			*(void**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textinfo_data)) = value;
		}
	}

	public unsafe int m_dataItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataItem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataItem)) = value;
		}
	}

	public unsafe Calendar calendar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CultureInfo parent_culture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent_culture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent_culture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool constructed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructed)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> cached_serialized_form
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cached_serialized_form);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cached_serialized_form)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CultureData m_cultureData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cultureData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cultureData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_isInherited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isInherited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isInherited)) = value;
		}
	}

	public unsafe static int InvariantCultureId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvariantCultureId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvariantCultureId, (void*)(&value));
		}
	}

	public unsafe static int CalendarTypeBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CalendarTypeBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CalendarTypeBits, (void*)(&value));
		}
	}

	public unsafe static int LOCALE_INVARIANT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOCALE_INVARIANT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOCALE_INVARIANT, (void*)(&value));
		}
	}

	public unsafe static string MSG_READONLY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MSG_READONLY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MSG_READONLY, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static CultureInfo s_DefaultThreadCurrentUICulture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureInfo s_DefaultThreadCurrentCulture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, CultureInfo> shared_by_number
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shared_by_number, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CultureInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shared_by_number, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, CultureInfo> shared_by_name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shared_by_name, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, CultureInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shared_by_name, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureInfo s_UserPreferredCultureInfoInAppX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsTaiwanSku
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsTaiwanSku, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsTaiwanSku, (void*)(&value));
		}
	}

	public unsafe CultureData _cultureData
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__cultureData_Internal_get_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
		}
	}

	public unsafe bool _isInherited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__isInherited_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static CultureInfo InvariantCulture
	{
		[CallerCount(277)]
		[CachedScanResults(RefRangeStart = 820255, RefRangeEnd = 820532, XrefRangeStart = 820250, XrefRangeEnd = 820255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe static CultureInfo CurrentCulture
	{
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 820535, RefRangeEnd = 820611, XrefRangeStart = 820532, XrefRangeEnd = 820535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe static CultureInfo CurrentUICulture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 820614, RefRangeEnd = 820615, XrefRangeStart = 820611, XrefRangeEnd = 820614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe string Territory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Territory_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string _name
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe virtual int LCID
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual string Name
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe virtual Calendar Calendar
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820655, XrefRangeEnd = 820661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
		}
	}

	public unsafe virtual CultureInfo Parent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820661, XrefRangeEnd = 820676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe virtual TextInfo TextInfo
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820676, XrefRangeEnd = 820690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
		}
	}

	public unsafe virtual CompareInfo CompareInfo
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820705, XrefRangeEnd = 820719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
		}
	}

	public unsafe virtual bool IsNeutralCulture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820719, XrefRangeEnd = 820720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual NumberFormatInfo NumberFormat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820720, XrefRangeEnd = 820728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820728, XrefRangeEnd = 820743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual DateTimeFormatInfo DateTimeFormat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820743, XrefRangeEnd = 820764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820764, XrefRangeEnd = 820779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual string EnglishName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820779, XrefRangeEnd = 820780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe int CalendarType
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 821578, RefRangeEnd = 821582, XrefRangeStart = 821578, XrefRangeEnd = 821578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static CultureInfo DefaultThreadCurrentCulture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821614, XrefRangeEnd = 821619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe static CultureInfo DefaultThreadCurrentUICulture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821619, XrefRangeEnd = 821624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe string SortName
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SortName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static CultureInfo UserDefaultUICulture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821624, XrefRangeEnd = 821631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe static CultureInfo UserDefaultCulture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821631, XrefRangeEnd = 821635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	static CultureInfo()
	{
		Il2CppClassPointerStore<CultureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr);
		NativeFieldInfoPtr_invariant_culture_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "invariant_culture_info");
		NativeFieldInfoPtr_shared_table_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_table_lock");
		NativeFieldInfoPtr_default_current_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_current_culture");
		NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isReadOnly");
		NativeFieldInfoPtr_cultureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cultureID");
		NativeFieldInfoPtr_parent_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_lcid");
		NativeFieldInfoPtr_datetime_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "datetime_index");
		NativeFieldInfoPtr_number_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "number_index");
		NativeFieldInfoPtr_default_calendar_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_calendar_type");
		NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_useUserOverride");
		NativeFieldInfoPtr_numInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "numInfo");
		NativeFieldInfoPtr_dateTimeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "dateTimeInfo");
		NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textInfo");
		NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_name");
		NativeFieldInfoPtr_englishname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "englishname");
		NativeFieldInfoPtr_nativename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "nativename");
		NativeFieldInfoPtr_iso3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso3lang");
		NativeFieldInfoPtr_iso2lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso2lang");
		NativeFieldInfoPtr_win3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "win3lang");
		NativeFieldInfoPtr_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "territory");
		NativeFieldInfoPtr_native_calendar_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "native_calendar_names");
		NativeFieldInfoPtr_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "compareInfo");
		NativeFieldInfoPtr_textinfo_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textinfo_data");
		NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_dataItem");
		NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "calendar");
		NativeFieldInfoPtr_parent_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_culture");
		NativeFieldInfoPtr_constructed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "constructed");
		NativeFieldInfoPtr_cached_serialized_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cached_serialized_form");
		NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_cultureData");
		NativeFieldInfoPtr_m_isInherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isInherited");
		NativeFieldInfoPtr_InvariantCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "InvariantCultureId");
		NativeFieldInfoPtr_CalendarTypeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "CalendarTypeBits");
		NativeFieldInfoPtr_LOCALE_INVARIANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "LOCALE_INVARIANT");
		NativeFieldInfoPtr_MSG_READONLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "MSG_READONLY");
		NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentUICulture");
		NativeFieldInfoPtr_s_DefaultThreadCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentCulture");
		NativeFieldInfoPtr_shared_by_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_number");
		NativeFieldInfoPtr_shared_by_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_name");
		NativeFieldInfoPtr_s_UserPreferredCultureInfoInAppX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_UserPreferredCultureInfoInAppX");
		NativeFieldInfoPtr_IsTaiwanSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "IsTaiwanSku");
		NativeMethodInfoPtr_get__cultureData_Internal_get_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673208);
		NativeMethodInfoPtr_get__isInherited_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673209);
		NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673210);
		NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673211);
		NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673212);
		NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673213);
		NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673214);
		NativeMethodInfoPtr_get_Territory_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673215);
		NativeMethodInfoPtr_get__name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673216);
		NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673217);
		NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673218);
		NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673219);
		NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673220);
		NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673221);
		NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673222);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673223);
		NativeMethodInfoPtr_GetTextInfoData_Private_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673224);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673225);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673226);
		NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673227);
		NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673228);
		NativeMethodInfoPtr_CheckNeutral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673229);
		NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673230);
		NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673231);
		NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673232);
		NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673233);
		NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673234);
		NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673235);
		NativeMethodInfoPtr_Construct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673236);
		NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673237);
		NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673238);
		NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673239);
		NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673240);
		NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673241);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673242);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673243);
		NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673244);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673245);
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673246);
		NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673247);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673248);
		NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673249);
		NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673250);
		NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673251);
		NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673252);
		NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673253);
		NativeMethodInfoPtr_ConstructLocaleFromName_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673254);
		NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673255);
		NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673256);
		NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673257);
		NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673258);
		NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673259);
		NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673260);
		NativeMethodInfoPtr_get_SortName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673261);
		NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673262);
		NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673263);
		NativeMethodInfoPtr_InitializeUserPreferredCultureInfoInAppX_Private_Static_Void_OnCultureInfoChangedDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673264);
		NativeMethodInfoPtr_SetUserPreferredCultureInfoInAppX_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673265);
		NativeMethodInfoPtr_OnCultureInfoChangedInAppX_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673266);
		NativeMethodInfoPtr_GetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673267);
		NativeMethodInfoPtr_SetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100673268);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 820644, RefRangeEnd = 820649, XrefRangeStart = 820615, XrefRangeEnd = 820644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo ConstructCurrentCulture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 820653, RefRangeEnd = 820655, XrefRangeStart = 820649, XrefRangeEnd = 820653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo ConstructCurrentUICulture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820690, XrefRangeEnd = 820701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820701, XrefRangeEnd = 820704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Data GetTextInfoData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextInfoData_Private_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Data*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820704, XrefRangeEnd = 820705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckNeutral()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckNeutral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820780, XrefRangeEnd = 820793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object GetFormat(Type formatType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820793, XrefRangeEnd = 820794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Construct()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Construct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820794, XrefRangeEnd = 820795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool construct_internal_locale_from_lcid(int lcid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lcid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820795, XrefRangeEnd = 820796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool construct_internal_locale_from_name(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820796, XrefRangeEnd = 820797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string get_current_locale_name()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820828, RefRangeEnd = 820829, XrefRangeStart = 820797, XrefRangeEnd = 820828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConstructInvariant(bool read_only)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&read_only);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820829, XrefRangeEnd = 820833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextInfo CreateTextInfo(bool readOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&readOnly);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820834, RefRangeEnd = 820835, XrefRangeStart = 820833, XrefRangeEnd = 820834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo(int culture)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820835, XrefRangeEnd = 820836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo(int culture, bool useUserOverride)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&culture);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUserOverride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 820844, RefRangeEnd = 820849, XrefRangeStart = 820836, XrefRangeEnd = 820844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo(int culture, bool useUserOverride, bool read_only)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&culture);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUserOverride;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &read_only;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 820850, RefRangeEnd = 820855, XrefRangeStart = 820849, XrefRangeEnd = 820850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 820856, RefRangeEnd = 820861, XrefRangeStart = 820855, XrefRangeEnd = 820856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo(string name, bool useUserOverride)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUserOverride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 820877, RefRangeEnd = 820883, XrefRangeStart = 820861, XrefRangeEnd = 820877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo(string name, bool useUserOverride, bool read_only)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUserOverride;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &read_only;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820883, XrefRangeEnd = 820884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 820919, RefRangeEnd = 820921, XrefRangeStart = 820884, XrefRangeEnd = 820919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void insert_into_shared_tables(CultureInfo c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 820945, RefRangeEnd = 820948, XrefRangeStart = 820921, XrefRangeEnd = 820945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo GetCultureInfo(int culture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 820972, RefRangeEnd = 820984, XrefRangeStart = 820948, XrefRangeEnd = 820972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo GetCultureInfo(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820988, RefRangeEnd = 820989, XrefRangeStart = 820984, XrefRangeEnd = 820988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo CreateCulture(string name, bool reference)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reference;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 821004, RefRangeEnd = 821005, XrefRangeStart = 820989, XrefRangeEnd = 821004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo CreateSpecificCulture(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 821009, RefRangeEnd = 821011, XrefRangeStart = 821005, XrefRangeEnd = 821009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ConstructLocaleFromName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructLocaleFromName_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 821577, RefRangeEnd = 821578, XrefRangeStart = 821011, XrefRangeEnd = 821577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo CreateSpecificCultureFromNeutral(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 821602, RefRangeEnd = 821603, XrefRangeStart = 821582, XrefRangeEnd = 821602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Calendar CreateCalendar(int calendarType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821603, XrefRangeEnd = 821614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateNotFoundException(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821635, XrefRangeEnd = 821637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onCultureInfoChangedInAppX);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeUserPreferredCultureInfoInAppX_Private_Static_Void_OnCultureInfoChangedDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821637, XrefRangeEnd = 821687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUserPreferredCultureInfoInAppX(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUserPreferredCultureInfoInAppX_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821687, XrefRangeEnd = 821700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnCultureInfoChangedInAppX(string language)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCultureInfoChangedInAppX_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821700, XrefRangeEnd = 821717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821717, XrefRangeEnd = 821738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo cultureInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cultureInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCultureInfoForUserPreferredLanguageInAppX_Internal_Static_Void_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CultureInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
