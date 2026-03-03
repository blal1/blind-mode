using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem;

[System.Serializable]
public sealed class TimeZoneInfo : Object
{
	public sealed class CachedData : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__oneYearLocalFromUtc;

		private static readonly System.IntPtr NativeFieldInfoPtr__localTimeZone;

		private static readonly System.IntPtr NativeFieldInfoPtr__systemTimeZones;

		private static readonly System.IntPtr NativeFieldInfoPtr__readOnlySystemTimeZones;

		private static readonly System.IntPtr NativeFieldInfoPtr__allSystemTimeZonesRead;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentOneYearLocal_Private_Static_TimeZoneInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetOneYearLocalFromUtc_Public_OffsetAndRule_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateLocal_Private_TimeZoneInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Local_Public_get_TimeZoneInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCorrespondingKind_Public_DateTimeKind_TimeZoneInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe OffsetAndRule _oneYearLocalFromUtc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oneYearLocalFromUtc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OffsetAndRule>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oneYearLocalFromUtc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TimeZoneInfo _localTimeZone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localTimeZone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localTimeZone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Dictionary<string, TimeZoneInfo> _systemTimeZones
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__systemTimeZones);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, TimeZoneInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__systemTimeZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__readOnlySystemTimeZones);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__readOnlySystemTimeZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool _allSystemTimeZonesRead
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allSystemTimeZonesRead);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allSystemTimeZonesRead)) = value;
			}
		}

		public unsafe TimeZoneInfo Local
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715646, XrefRangeEnd = 715648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Local_Public_get_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
		}

		static CachedData()
		{
			Il2CppClassPointerStore<CachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "CachedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedData>.NativeClassPtr);
			NativeFieldInfoPtr__oneYearLocalFromUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedData>.NativeClassPtr, "_oneYearLocalFromUtc");
			NativeFieldInfoPtr__localTimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedData>.NativeClassPtr, "_localTimeZone");
			NativeFieldInfoPtr__systemTimeZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedData>.NativeClassPtr, "_systemTimeZones");
			NativeFieldInfoPtr__readOnlySystemTimeZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedData>.NativeClassPtr, "_readOnlySystemTimeZones");
			NativeFieldInfoPtr__allSystemTimeZonesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedData>.NativeClassPtr, "_allSystemTimeZonesRead");
			NativeMethodInfoPtr_GetCurrentOneYearLocal_Private_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedData>.NativeClassPtr, 100664170);
			NativeMethodInfoPtr_GetOneYearLocalFromUtc_Public_OffsetAndRule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedData>.NativeClassPtr, 100664171);
			NativeMethodInfoPtr_CreateLocal_Private_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedData>.NativeClassPtr, 100664172);
			NativeMethodInfoPtr_get_Local_Public_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedData>.NativeClassPtr, 100664173);
			NativeMethodInfoPtr_GetCorrespondingKind_Public_DateTimeKind_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedData>.NativeClassPtr, 100664174);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedData>.NativeClassPtr, 100664175);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715591, XrefRangeEnd = 715603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeZoneInfo GetCurrentOneYearLocal()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentOneYearLocal_Private_Static_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715603, XrefRangeEnd = 715627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffsetAndRule GetOneYearLocalFromUtc(int year)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&year);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOneYearLocalFromUtc_Public_OffsetAndRule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OffsetAndRule>(intPtr2) : null;
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 715641, RefRangeEnd = 715646, XrefRangeStart = 715627, XrefRangeEnd = 715641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneInfo CreateLocal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLocal_Private_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 715652, RefRangeEnd = 715656, XrefRangeStart = 715648, XrefRangeEnd = 715652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeZone);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCorrespondingKind_Public_DateTimeKind_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DateTimeKind*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CachedData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class OffsetAndRule : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Year;

		private static readonly System.IntPtr NativeFieldInfoPtr_Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_Rule;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TimeSpan_AdjustmentRule_0;

		public unsafe int Year
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Year);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Year)) = value;
			}
		}

		public unsafe TimeSpan Offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset);
				return *(TimeSpan*)num;
			}
			set
			{
				*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset)) = value;
			}
		}

		public unsafe AdjustmentRule Rule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rule);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rule)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static OffsetAndRule()
		{
			Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "OffsetAndRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr);
			NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr, "Year");
			NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr, "Offset");
			NativeFieldInfoPtr_Rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr, "Rule");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr, 100664176);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715656, XrefRangeEnd = 715658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetAndRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&year);
			*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_TimeSpan_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OffsetAndRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public sealed class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_TZI;

		private static readonly System.IntPtr NativeFieldInfoPtr_TimeZoneKeyName;

		private static readonly System.IntPtr NativeFieldInfoPtr_DynamicDaylightTimeDisabled;

		public unsafe Interop.Kernel32.TIME_ZONE_INFORMATION TZI
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TZI);
				return *(Interop.Kernel32.TIME_ZONE_INFORMATION*)num;
			}
			set
			{
				*(Interop.Kernel32.TIME_ZONE_INFORMATION*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TZI)) = value;
			}
		}

		public unsafe string TimeZoneKeyName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeZoneKeyName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeZoneKeyName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe byte DynamicDaylightTimeDisabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DynamicDaylightTimeDisabled);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DynamicDaylightTimeDisabled)) = value;
			}
		}

		static DYNAMIC_TIME_ZONE_INFORMATION()
		{
			Il2CppClassPointerStore<DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "DYNAMIC_TIME_ZONE_INFORMATION");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr);
			NativeFieldInfoPtr_TZI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TZI");
			NativeFieldInfoPtr_TimeZoneKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "TimeZoneKeyName");
			NativeFieldInfoPtr_DynamicDaylightTimeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr, "DynamicDaylightTimeDisabled");
		}

		public DYNAMIC_TIME_ZONE_INFORMATION(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DYNAMIC_TIME_ZONE_INFORMATION()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DYNAMIC_TIME_ZONE_INFORMATION>.NativeClassPtr))
		{
		}
	}

	[OriginalName("mscorlib.dll", "", "TimeZoneInfoResult")]
	public enum TimeZoneInfoResult
	{
		Success,
		TimeZoneNotFoundException,
		InvalidTimeZoneException,
		SecurityException
	}

	[System.Serializable]
	public sealed class AdjustmentRule : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__dateStart;

		private static readonly System.IntPtr NativeFieldInfoPtr__dateEnd;

		private static readonly System.IntPtr NativeFieldInfoPtr__daylightDelta;

		private static readonly System.IntPtr NativeFieldInfoPtr__daylightTransitionStart;

		private static readonly System.IntPtr NativeFieldInfoPtr__daylightTransitionEnd;

		private static readonly System.IntPtr NativeFieldInfoPtr__baseUtcOffsetDelta;

		private static readonly System.IntPtr NativeFieldInfoPtr__noDaylightTransitions;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseUtcOffsetDelta_Internal_get_TimeSpan_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_NoDaylightTransitions_Internal_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDaylightSaving_Internal_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsStartDateMarkerForBeginningOfYear_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsEndDateMarkerForEndOfYear_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		public unsafe DateTime _dateStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dateStart);
				return *(DateTime*)num;
			}
			set
			{
				*(DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dateStart)) = value;
			}
		}

		public unsafe DateTime _dateEnd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dateEnd);
				return *(DateTime*)num;
			}
			set
			{
				*(DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dateEnd)) = value;
			}
		}

		public unsafe TimeSpan _daylightDelta
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightDelta);
				return *(TimeSpan*)num;
			}
			set
			{
				*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightDelta)) = value;
			}
		}

		public unsafe TransitionTime _daylightTransitionStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightTransitionStart);
				return *(TransitionTime*)num;
			}
			set
			{
				*(TransitionTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightTransitionStart)) = value;
			}
		}

		public unsafe TransitionTime _daylightTransitionEnd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightTransitionEnd);
				return *(TransitionTime*)num;
			}
			set
			{
				*(TransitionTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightTransitionEnd)) = value;
			}
		}

		public unsafe TimeSpan _baseUtcOffsetDelta
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__baseUtcOffsetDelta);
				return *(TimeSpan*)num;
			}
			set
			{
				*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__baseUtcOffsetDelta)) = value;
			}
		}

		public unsafe bool _noDaylightTransitions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__noDaylightTransitions);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__noDaylightTransitions)) = value;
			}
		}

		public unsafe DateTime DateStart
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe DateTime DateEnd
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe TimeSpan DaylightDelta
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe TransitionTime DaylightTransitionStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(TransitionTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe TransitionTime DaylightTransitionEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(TransitionTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe TimeSpan BaseUtcOffsetDelta
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseUtcOffsetDelta_Internal_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool NoDaylightTransitions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NoDaylightTransitions_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool HasDaylightSaving
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 715670, RefRangeEnd = 715676, XrefRangeStart = 715658, XrefRangeEnd = 715670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasDaylightSaving_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static AdjustmentRule()
		{
			Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "AdjustmentRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr);
			NativeFieldInfoPtr__dateStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_dateStart");
			NativeFieldInfoPtr__dateEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_dateEnd");
			NativeFieldInfoPtr__daylightDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_daylightDelta");
			NativeFieldInfoPtr__daylightTransitionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_daylightTransitionStart");
			NativeFieldInfoPtr__daylightTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_daylightTransitionEnd");
			NativeFieldInfoPtr__baseUtcOffsetDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_baseUtcOffsetDelta");
			NativeFieldInfoPtr__noDaylightTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, "_noDaylightTransitions");
			NativeMethodInfoPtr_get_DateStart_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664177);
			NativeMethodInfoPtr_get_DateEnd_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664178);
			NativeMethodInfoPtr_get_DaylightDelta_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664179);
			NativeMethodInfoPtr_get_DaylightTransitionStart_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664180);
			NativeMethodInfoPtr_get_DaylightTransitionEnd_Public_get_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664181);
			NativeMethodInfoPtr_get_BaseUtcOffsetDelta_Internal_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664182);
			NativeMethodInfoPtr_get_NoDaylightTransitions_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664183);
			NativeMethodInfoPtr_get_HasDaylightSaving_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664184);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664185);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664186);
			NativeMethodInfoPtr__ctor_Private_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664187);
			NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664188);
			NativeMethodInfoPtr_IsStartDateMarkerForBeginningOfYear_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664189);
			NativeMethodInfoPtr_IsEndDateMarkerForEndOfYear_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664190);
			NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664191);
			NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664192);
			NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664193);
			NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664194);
			NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr, 100664195);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715676, XrefRangeEnd = 715695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(AdjustmentRule other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715695, XrefRangeEnd = 715701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715701, XrefRangeEnd = 715703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = (nint)(&dateStart);
			*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateEnd;
			*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightDelta;
			*(TransitionTime**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTransitionStart;
			*(TransitionTime**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTransitionEnd;
			*(TimeSpan**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffsetDelta;
			*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noDaylightTransitions;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 715708, RefRangeEnd = 715712, XrefRangeStart = 715703, XrefRangeEnd = 715708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = (nint)(&dateStart);
			*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateEnd;
			*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightDelta;
			*(TransitionTime**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTransitionStart;
			*(TransitionTime**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTransitionEnd;
			*(TimeSpan**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffsetDelta;
			*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noDaylightTransitions;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAdjustmentRule_Internal_Static_AdjustmentRule_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_TimeSpan_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr2) : null;
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 715726, RefRangeEnd = 715732, XrefRangeStart = 715712, XrefRangeEnd = 715726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStartDateMarkerForBeginningOfYear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStartDateMarkerForBeginningOfYear_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 715746, RefRangeEnd = 715753, XrefRangeStart = 715732, XrefRangeEnd = 715746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEndDateMarkerForEndOfYear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEndDateMarkerForEndOfYear_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 715817, RefRangeEnd = 715820, XrefRangeStart = 715753, XrefRangeEnd = 715817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&dateStart);
			*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateEnd;
			*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightDelta;
			*(TransitionTime**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTransitionStart;
			*(TransitionTime**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTransitionEnd;
			*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &noDaylightTransitions;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateAdjustmentRule_Private_Static_Void_DateTime_DateTime_TimeSpan_TransitionTime_TransitionTime_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715820, XrefRangeEnd = 715821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715821, XrefRangeEnd = 715852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715852, XrefRangeEnd = 715912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdjustmentRule(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715912, XrefRangeEnd = 715915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdjustmentRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustmentRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public AdjustmentRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct TransitionTime
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__timeOfDay;

		private static readonly System.IntPtr NativeFieldInfoPtr__month;

		private static readonly System.IntPtr NativeFieldInfoPtr__week;

		private static readonly System.IntPtr NativeFieldInfoPtr__day;

		private static readonly System.IntPtr NativeFieldInfoPtr__dayOfWeek;

		private static readonly System.IntPtr NativeFieldInfoPtr__isFixedDateRule;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Week_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		[FieldOffset(0)]
		public readonly DateTime _timeOfDay;

		[FieldOffset(8)]
		public readonly byte _month;

		[FieldOffset(9)]
		public readonly byte _week;

		[FieldOffset(10)]
		public readonly byte _day;

		[FieldOffset(12)]
		public readonly DayOfWeek _dayOfWeek;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.U1)]
		public readonly bool _isFixedDateRule;

		public unsafe DateTime TimeOfDay
		{
			[CallerCount(98)]
			[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int Month
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Month_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int Week
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Week_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int Day
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Day_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe DayOfWeek DayOfWeek
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(DayOfWeek*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool IsFixedDateRule
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static TransitionTime()
		{
			Il2CppClassPointerStore<TransitionTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "TransitionTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr);
			NativeFieldInfoPtr__timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, "_timeOfDay");
			NativeFieldInfoPtr__month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, "_month");
			NativeFieldInfoPtr__week = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, "_week");
			NativeFieldInfoPtr__day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, "_day");
			NativeFieldInfoPtr__dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, "_dayOfWeek");
			NativeFieldInfoPtr__isFixedDateRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, "_isFixedDateRule");
			NativeMethodInfoPtr_get_TimeOfDay_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664196);
			NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664197);
			NativeMethodInfoPtr_get_Week_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664198);
			NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664199);
			NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664200);
			NativeMethodInfoPtr_get_IsFixedDateRule_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664201);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664202);
			NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664203);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664204);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664205);
			NativeMethodInfoPtr__ctor_Private_Void_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664206);
			NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664207);
			NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664208);
			NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664209);
			NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664210);
			NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664211);
			NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, 100664212);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715915, XrefRangeEnd = 715919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Object obj)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715919, XrefRangeEnd = 715920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TransitionTime t1, TransitionTime t2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&t1);
			*(TransitionTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TransitionTime_TransitionTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 715926, RefRangeEnd = 715937, XrefRangeStart = 715920, XrefRangeEnd = 715926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(TransitionTime other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715937, XrefRangeEnd = 715938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&timeOfDay);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &week;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
			*(DayOfWeek**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dayOfWeek;
			*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFixedDateRule;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_DateTime_Int32_Int32_Int32_DayOfWeek_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715938, XrefRangeEnd = 715939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&timeOfDay);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFixedDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TransitionTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715939, XrefRangeEnd = 715940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&timeOfDay);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &week;
			*(DayOfWeek**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dayOfWeek;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFloatingDateRule_Public_Static_TransitionTime_DateTime_Int32_Int32_DayOfWeek_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TransitionTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 715954, RefRangeEnd = 715967, XrefRangeStart = 715940, XrefRangeEnd = 715954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&timeOfDay);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &week;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
			*(DayOfWeek**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dayOfWeek;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTransitionTime_Private_Static_Void_DateTime_Int32_Int32_Int32_DayOfWeek_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715967, XrefRangeEnd = 715968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715968, XrefRangeEnd = 715989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715989, XrefRangeEnd = 716037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionTime(SerializationInfo info, StreamingContext context)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransitionTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("System.TimeZoneInfo+<>c")]
	public sealed class __c : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__110_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetSystemTimeZonesWinRTFallback_b__49_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetSystemTimeZones_b__110_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__157_0_Internal_Boolean_0;

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

		public unsafe static Comparison<TimeZoneInfo> __9__49_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Comparison<TimeZoneInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Comparison<TimeZoneInfo> __9__110_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__110_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Comparison<TimeZoneInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__110_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_0");
			NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__110_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664214);
			NativeMethodInfoPtr__GetSystemTimeZonesWinRTFallback_b__49_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664215);
			NativeMethodInfoPtr__GetSystemTimeZones_b__110_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664216);
			NativeMethodInfoPtr___cctor_b__157_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664217);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716037, XrefRangeEnd = 716043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetSystemTimeZonesWinRTFallback_b__49_0(TimeZoneInfo x, TimeZoneInfo y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetSystemTimeZonesWinRTFallback_b__49_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716043, XrefRangeEnd = 716049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetSystemTimeZones_b__110_0(TimeZoneInfo x, TimeZoneInfo y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetSystemTimeZones_b__110_0_Internal_Int32_TimeZoneInfo_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716049, XrefRangeEnd = 716062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __cctor_b__157_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__157_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_lazyHaveRegistry;

	private static readonly System.IntPtr NativeFieldInfoPtr__id;

	private static readonly System.IntPtr NativeFieldInfoPtr__displayName;

	private static readonly System.IntPtr NativeFieldInfoPtr__standardDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr__daylightDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr__baseUtcOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportsDaylightSavingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__adjustmentRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_utcTimeZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cachedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_maxDateOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_minDateOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateAllSystemTimeZones_Private_Static_Void_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateAllSystemTimeZonesFromRegistry_Private_Static_Void_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_byref_TIME_ZONE_INFORMATION_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDaylightSavingTimeNotSupported_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Private_Static_AdjustmentRule_byref_REG_TZI_FORMAT_DateTime_DateTime_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindIdFromTimeZoneInformation_Private_Static_String_byref_TIME_ZONE_INFORMATION_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTimeZone_Private_Static_TimeZoneInfo_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTimeZoneFromWin32Data_Private_Static_TimeZoneInfo_byref_TIME_ZONE_INFORMATION_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_byref_REG_TZI_FORMAT_byref_TransitionTime_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateAdjustmentRules_Private_Static_Boolean_String_byref_REG_TZI_FORMAT_byref_Il2CppReferenceArray_1_AdjustmentRule_byref_Exception_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTimeZoneEntryFromRegistry_Private_Static_Boolean_RegistryKey_String_byref_REG_TZI_FORMAT_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCompareStandardDate_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_byref_REG_TZI_FORMAT_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCompareTimeZoneInformationToRegistry_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_String_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalizedNameByMuiNativeResource_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalizedNameByNativeResource_Private_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedNamesByRegistryKey_Private_Static_Void_RegistryKey_byref_String_byref_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTimeZoneFromLocalRegistry_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HaveRegistry_Private_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Private_Static_Void_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousAdjustmentRule_Private_AdjustmentRule_AdjustmentRule_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_TimeZoneInfoOptions_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTime_Internal_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTime_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_byref_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_Boolean_byref_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareAdjustmentRuleToDateTime_Private_Int32_AdjustmentRule_AdjustmentRule_DateTime_DateTime_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertUtcToTimeZone_Private_Static_DateTime_Int64_TimeZoneInfo_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDaylightTime_Private_DaylightTimeStruct_Int32_AdjustmentRule_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsDaylightSavings_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_TimeZoneInfoOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDaylightSavingsStartOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDaylightSavingsEndOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsDaylightSavingsFromUtc_Private_Static_Boolean_DateTime_Int32_TimeSpan_AdjustmentRule_Nullable_1_Int32_byref_Boolean_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsDst_Private_Static_Boolean_DateTime_DateTime_DateTime_Boolean_AdjustmentRule_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsAmbiguousTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsInvalidTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionTimeToDateTime_Internal_Static_DateTime_Int32_TransitionTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTimeZone_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTimeZoneInfo_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_TimeSpan_AdjustmentRule_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidAdjustmentRuleOffest_Private_Static_Boolean_TimeSpan_AdjustmentRule_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	public unsafe static Lazy<bool> lazyHaveRegistry
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lazyHaveRegistry, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Lazy<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lazyHaveRegistry, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _displayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _standardDisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__standardDisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__standardDisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _daylightDisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightDisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__daylightDisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TimeSpan _baseUtcOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__baseUtcOffset);
			return *(TimeSpan*)num;
		}
		set
		{
			*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__baseUtcOffset)) = value;
		}
	}

	public unsafe bool _supportsDaylightSavingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportsDaylightSavingTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportsDaylightSavingTime)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<AdjustmentRule> _adjustmentRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adjustmentRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AdjustmentRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adjustmentRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TimeZoneInfo s_utcTimeZone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_utcTimeZone, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_utcTimeZone, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CachedData s_cachedData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cachedData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cachedData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DateTime s_maxDateOnly
	{
		get
		{
			Unsafe.SkipInit(out DateTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_maxDateOnly, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_maxDateOnly, (void*)(&value));
		}
	}

	public unsafe static DateTime s_minDateOnly
	{
		get
		{
			Unsafe.SkipInit(out DateTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_minDateOnly, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_minDateOnly, (void*)(&value));
		}
	}

	public unsafe static TimeSpan MaxOffset
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxOffset, (void*)(&value));
		}
	}

	public unsafe static TimeSpan MinOffset
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinOffset, (void*)(&value));
		}
	}

	public unsafe static bool HaveRegistry
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 716613, RefRangeEnd = 716618, XrefRangeStart = 716605, XrefRangeEnd = 716613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HaveRegistry_Private_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string Id
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string DisplayName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716927, XrefRangeEnd = 716928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe TimeSpan BaseUtcOffset
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static TimeZoneInfo Local
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 717167, RefRangeEnd = 717178, XrefRangeStart = 717161, XrefRangeEnd = 717167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
		}
	}

	public unsafe static TimeZoneInfo Utc
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717178, XrefRangeEnd = 717182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
		}
	}

	static TimeZoneInfo()
	{
		Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZoneInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr);
		NativeFieldInfoPtr_lazyHaveRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "lazyHaveRegistry");
		NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_id");
		NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_displayName");
		NativeFieldInfoPtr__standardDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_standardDisplayName");
		NativeFieldInfoPtr__daylightDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_daylightDisplayName");
		NativeFieldInfoPtr__baseUtcOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_baseUtcOffset");
		NativeFieldInfoPtr__supportsDaylightSavingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_supportsDaylightSavingTime");
		NativeFieldInfoPtr__adjustmentRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "_adjustmentRules");
		NativeFieldInfoPtr_s_utcTimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_utcTimeZone");
		NativeFieldInfoPtr_s_cachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_cachedData");
		NativeFieldInfoPtr_s_maxDateOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_maxDateOnly");
		NativeFieldInfoPtr_s_minDateOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "s_minDateOnly");
		NativeFieldInfoPtr_MaxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "MaxOffset");
		NativeFieldInfoPtr_MinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, "MinOffset");
		NativeMethodInfoPtr_PopulateAllSystemTimeZones_Private_Static_Void_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_PopulateAllSystemTimeZonesFromRegistry_Private_Static_Void_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr__ctor_Private_Void_byref_TIME_ZONE_INFORMATION_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_CheckDaylightSavingTimeNotSupported_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Private_Static_AdjustmentRule_byref_REG_TZI_FORMAT_DateTime_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664092);
		NativeMethodInfoPtr_FindIdFromTimeZoneInformation_Private_Static_String_byref_TIME_ZONE_INFORMATION_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664093);
		NativeMethodInfoPtr_GetLocalTimeZone_Private_Static_TimeZoneInfo_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664094);
		NativeMethodInfoPtr_GetLocalTimeZoneFromWin32Data_Private_Static_TimeZoneInfo_byref_TIME_ZONE_INFORMATION_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_byref_REG_TZI_FORMAT_byref_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_TryCreateAdjustmentRules_Private_Static_Boolean_String_byref_REG_TZI_FORMAT_byref_Il2CppReferenceArray_1_AdjustmentRule_byref_Exception_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664098);
		NativeMethodInfoPtr_TryGetTimeZoneEntryFromRegistry_Private_Static_Boolean_RegistryKey_String_byref_REG_TZI_FORMAT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_TryCompareStandardDate_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_byref_REG_TZI_FORMAT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_TryCompareTimeZoneInformationToRegistry_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_TryGetLocalizedNameByMuiNativeResource_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_TryGetLocalizedNameByNativeResource_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr_GetLocalizedNamesByRegistryKey_Private_Static_Void_RegistryKey_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_TryGetTimeZoneFromLocalRegistry_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_get_HaveRegistry_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664109);
		NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664114);
		NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Private_Static_Void_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_get_BaseUtcOffset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_GetPreviousAdjustmentRule_Private_AdjustmentRule_AdjustmentRule_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664123);
		NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664124);
		NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_TimeZoneInfoOptions_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664125);
		NativeMethodInfoPtr_ConvertTime_Internal_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664126);
		NativeMethodInfoPtr_ConvertTime_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664127);
		NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_get_Local_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_get_Utc_Public_Static_get_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_Boolean_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_CompareAdjustmentRuleToDateTime_Private_Int32_AdjustmentRule_AdjustmentRule_DateTime_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_ConvertToUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_ConvertFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_ConvertToFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_ConvertUtcToTimeZone_Private_Static_DateTime_Int64_TimeZoneInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_GetDaylightTime_Private_DaylightTimeStruct_Int32_AdjustmentRule_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_GetIsDaylightSavings_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_GetDaylightSavingsStartOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_GetDaylightSavingsEndOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_GetIsDaylightSavingsFromUtc_Private_Static_Boolean_DateTime_Int32_TimeSpan_AdjustmentRule_Nullable_1_Int32_byref_Boolean_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_CheckIsDst_Private_Static_Boolean_DateTime_DateTime_DateTime_Boolean_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_GetIsAmbiguousTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_GetIsInvalidTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_TransitionTimeToDateTime_Internal_Static_DateTime_Int32_TransitionTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_TryGetTimeZone_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_ValidateTimeZoneInfo_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_IsValidAdjustmentRuleOffest_Private_Static_Boolean_TimeSpan_AdjustmentRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr, 100664169);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716062, XrefRangeEnd = 716071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopulateAllSystemTimeZones(CachedData cachedData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateAllSystemTimeZones_Private_Static_Void_CachedData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716090, RefRangeEnd = 716092, XrefRangeStart = 716071, XrefRangeEnd = 716090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateAllSystemTimeZonesFromRegistry_Private_Static_Void_CachedData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716125, RefRangeEnd = 716127, XrefRangeStart = 716092, XrefRangeEnd = 716125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeZoneInfo([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref zone);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstDisabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_byref_TIME_ZONE_INFORMATION_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716127, XrefRangeEnd = 716128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckDaylightSavingTimeNotSupported([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref timeZone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDaylightSavingTimeNotSupported_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 716158, RefRangeEnd = 716162, XrefRangeStart = 716128, XrefRangeEnd = 716158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation([In] ref Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref timeZoneInformation);
		*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startDate;
		*(DateTime**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endDate;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultBaseUtcOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Private_Static_AdjustmentRule_byref_REG_TZI_FORMAT_DateTime_DateTime_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716162, XrefRangeEnd = 716182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FindIdFromTimeZoneInformation([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref timeZone);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dstDisabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindIdFromTimeZoneInformation_Private_Static_String_byref_TIME_ZONE_INFORMATION_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 716194, RefRangeEnd = 716195, XrefRangeStart = 716182, XrefRangeEnd = 716194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfo GetLocalTimeZone(CachedData cachedData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalTimeZone_Private_Static_TimeZoneInfo_CachedData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716205, RefRangeEnd = 716207, XrefRangeStart = 716195, XrefRangeEnd = 716205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfo GetLocalTimeZoneFromWin32Data([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref timeZoneInformation);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstDisabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalTimeZoneFromWin32Data_Private_Static_TimeZoneInfo_byref_TIME_ZONE_INFORMATION_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716259, RefRangeEnd = 716261, XrefRangeStart = 716207, XrefRangeEnd = 716259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAmbiguousLocalDst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateTimeNowUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716270, RefRangeEnd = 716272, XrefRangeStart = 716261, XrefRangeEnd = 716270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TransitionTimeFromTimeZoneInformation([In] ref Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref timeZoneInformation);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transitionTime);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &readStartDate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_byref_REG_TZI_FORMAT_byref_TransitionTime_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 716384, RefRangeEnd = 716385, XrefRangeStart = 716272, XrefRangeEnd = 716384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCreateAdjustmentRules(string id, [In] ref Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out Il2CppReferenceArray<AdjustmentRule> rules, out Exception e, int defaultBaseUtcOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref defaultTimeZoneInformation);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultBaseUtcOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreateAdjustmentRules_Private_Static_Boolean_String_byref_REG_TZI_FORMAT_byref_Il2CppReferenceArray_1_AdjustmentRule_byref_Exception_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		rules = ((num5 == 0) ? null : new Il2CppReferenceArray<AdjustmentRule>((System.IntPtr)num5));
		nint num6 = num4;
		e = ((num6 == 0) ? null : new Exception(num6));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716389, RefRangeEnd = 716391, XrefRangeStart = 716385, XrefRangeEnd = 716389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dtzi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTimeZoneEntryFromRegistry_Private_Static_Boolean_RegistryKey_String_byref_REG_TZI_FORMAT_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716391, XrefRangeEnd = 716392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCompareStandardDate([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, [In] ref Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref timeZone);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref registryTimeZoneInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCompareStandardDate_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_byref_REG_TZI_FORMAT_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 716438, RefRangeEnd = 716439, XrefRangeStart = 716392, XrefRangeEnd = 716438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCompareTimeZoneInformationToRegistry([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref timeZone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dstDisabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCompareTimeZoneInformationToRegistry_Private_Static_Boolean_byref_TIME_ZONE_INFORMATION_String_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 716465, RefRangeEnd = 716468, XrefRangeStart = 716439, XrefRangeEnd = 716465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TryGetLocalizedNameByMuiNativeResource(string resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetLocalizedNameByMuiNativeResource_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 716475, RefRangeEnd = 716476, XrefRangeStart = 716468, XrefRangeEnd = 716475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resource;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetLocalizedNameByNativeResource_Private_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 716538, RefRangeEnd = 716539, XrefRangeStart = 716476, XrefRangeEnd = 716538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedNamesByRegistryKey_Private_Static_Void_RegistryKey_byref_String_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		displayName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		standardName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		daylightName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num6);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716539, XrefRangeEnd = 716548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		value = ((num5 == 0) ? null : new TimeZoneInfo(num5));
		nint num6 = num4;
		e = ((num6 == 0) ? null : new Exception(num6));
		return *(TimeZoneInfoResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716548, XrefRangeEnd = 716605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTimeZoneFromLocalRegistry_Private_Static_TimeZoneInfoResult_String_byref_TimeZoneInfo_byref_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		value = ((num5 == 0) ? null : new TimeZoneInfo(num5));
		nint num6 = num4;
		e = ((num6 == 0) ? null : new Exception(num6));
		return *(TimeZoneInfoResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716618, XrefRangeEnd = 716624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dwIndex);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumDynamicTimeZoneInformation_Internal_Static_UInt32_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		lpTimeZoneInformation = ((num3 == 0) ? null : new DYNAMIC_TIME_ZONE_INFORMATION(num3));
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716624, XrefRangeEnd = 716630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		pTimeZoneInformation = ((num2 == 0) ? null : new DYNAMIC_TIME_ZONE_INFORMATION(num2));
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716630, XrefRangeEnd = 716637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lpTimeZoneInformation);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref FirstYear);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref LastYear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDynamicTimeZoneInformationEffectiveYears_Internal_Static_UInt32_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_UInt32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 716644, RefRangeEnd = 716647, XrefRangeStart = 716637, XrefRangeEnd = 716644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&wYear);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pdtzi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ptzi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeZoneInformationForYear_Internal_Static_Boolean_UInt16_byref_DYNAMIC_TIME_ZONE_INFORMATION_byref_TIME_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 716677, RefRangeEnd = 716681, XrefRangeStart = 716647, XrefRangeEnd = 716677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)timeZoneInformation);
		*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startDate;
		*(DateTime**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endDate;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultBaseUtcOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAdjustmentRuleFromTimeZoneInformation_Internal_Static_AdjustmentRule_byref_DYNAMIC_TIME_ZONE_INFORMATION_DateTime_DateTime_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716691, RefRangeEnd = 716693, XrefRangeStart = 716681, XrefRangeEnd = 716691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)timeZoneInformation));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transitionTime);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &readStartDate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionTimeFromTimeZoneInformation_Private_Static_Boolean_DYNAMIC_TIME_ZONE_INFORMATION_byref_TransitionTime_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716788, RefRangeEnd = 716790, XrefRangeStart = 716693, XrefRangeEnd = 716788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)timeZoneInformation));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreateTimeZone_Internal_Static_TimeZoneInfo_DYNAMIC_TIME_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716790, XrefRangeEnd = 716820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalTimeZoneInfoWinRTFallback_Internal_Static_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716837, RefRangeEnd = 716839, XrefRangeStart = 716820, XrefRangeEnd = 716837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSystemTimeZoneByIdWinRTFallback_Internal_Static_TimeZoneInfo_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716925, RefRangeEnd = 716927, XrefRangeStart = 716839, XrefRangeEnd = 716925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSystemTimeZonesWinRTFallback(CachedData cachedData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystemTimeZonesWinRTFallback_Private_Static_Void_CachedData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 716936, RefRangeEnd = 716939, XrefRangeStart = 716928, XrefRangeEnd = 716936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, Nullable<int> ruleIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ruleIndex));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviousAdjustmentRule_Private_AdjustmentRule_AdjustmentRule_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 716944, RefRangeEnd = 716949, XrefRangeStart = 716939, XrefRangeEnd = 716944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSpan GetUtcOffset(DateTime dateTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffset_Public_TimeSpan_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 716956, RefRangeEnd = 716961, XrefRangeStart = 716949, XrefRangeEnd = 716956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalUtcOffset_Internal_Static_TimeSpan_DateTime_TimeZoneInfoOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 716966, RefRangeEnd = 716968, XrefRangeStart = 716961, XrefRangeEnd = 716966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffset_Internal_TimeSpan_DateTime_TimeZoneInfoOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 717002, RefRangeEnd = 717005, XrefRangeStart = 716968, XrefRangeEnd = 717002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dateTime);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffset_Private_TimeSpan_DateTime_TimeZoneInfoOptions_CachedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717005, XrefRangeEnd = 717010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&dateTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceTimeZone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationTimeZone);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTime_Internal_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 717050, RefRangeEnd = 717053, XrefRangeStart = 717010, XrefRangeEnd = 717050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&dateTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceTimeZone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationTimeZone);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTime_Private_Static_DateTime_DateTime_TimeZoneInfo_TimeZoneInfo_TimeZoneInfoOptions_CachedData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717053, XrefRangeEnd = 717060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTimeToUtc_Internal_Static_DateTime_DateTime_TimeZoneInfoOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717060, XrefRangeEnd = 717062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(TimeZoneInfo other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717062, XrefRangeEnd = 717066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717066, XrefRangeEnd = 717074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 717134, RefRangeEnd = 717135, XrefRangeStart = 717074, XrefRangeEnd = 717134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSystemTimeZones_Public_Static_ReadOnlyCollection_1_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TimeZoneInfo>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 717159, RefRangeEnd = 717161, XrefRangeStart = 717135, XrefRangeEnd = 717159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSameRules(TimeZoneInfo other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSameRules_Public_Boolean_TimeZoneInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 717192, RefRangeEnd = 717197, XrefRangeStart = 717182, XrefRangeEnd = 717192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, Il2CppReferenceArray<AdjustmentRule> adjustmentRules, bool disableDaylightSavingTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(displayName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(daylightDisplayName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adjustmentRules);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableDaylightSavingTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_TimeSpan_String_String_String_Il2CppReferenceArray_1_AdjustmentRule_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 717201, RefRangeEnd = 717206, XrefRangeStart = 717197, XrefRangeEnd = 717201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(displayName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(standardDisplayName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCustomTimeZone_Public_Static_TimeZoneInfo_String_TimeSpan_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717206, XrefRangeEnd = 717210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717210, XrefRangeEnd = 717234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717234, XrefRangeEnd = 717302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeZoneInfo(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717302, XrefRangeEnd = 717303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<int> ruleIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_byref_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		ruleIndex = ((num3 == 0) ? null : new Nullable<int>(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 717320, RefRangeEnd = 717328, XrefRangeStart = 717303, XrefRangeEnd = 717320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<int> ruleIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dateTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateTimeisUtc;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdjustmentRuleForTime_Private_AdjustmentRule_DateTime_Boolean_byref_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		ruleIndex = ((num3 == 0) ? null : new Nullable<int>(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdjustmentRule>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 717359, RefRangeEnd = 717360, XrefRangeStart = 717328, XrefRangeEnd = 717359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousRule);
		*(DateTime**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateTime;
		*(DateTime**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateOnly;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateTimeisUtc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareAdjustmentRuleToDateTime_Private_Int32_AdjustmentRule_AdjustmentRule_DateTime_DateTime_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717360, XrefRangeEnd = 717361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dateTime);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightDelta;
		*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffsetDelta;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717361, XrefRangeEnd = 717362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dateTime);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightDelta;
		*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffsetDelta;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 717385, RefRangeEnd = 717391, XrefRangeStart = 717362, XrefRangeEnd = 717385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&dateTime);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightDelta;
		*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffsetDelta;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &convertToUtc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToFromUtc_Private_DateTime_DateTime_TimeSpan_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717391, XrefRangeEnd = 717427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ticks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationTimeZone);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAmbiguousLocalDst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertUtcToTimeZone_Private_Static_DateTime_Int64_TimeZoneInfo_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 717437, RefRangeEnd = 717442, XrefRangeStart = 717427, XrefRangeEnd = 717437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, Nullable<int> ruleIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&year);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ruleIndex));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDaylightTime_Private_DaylightTimeStruct_Int32_AdjustmentRule_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DaylightTimeStruct*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 717544, RefRangeEnd = 717546, XrefRangeStart = 717442, XrefRangeEnd = 717544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(DaylightTimeStruct**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTime;
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsDaylightSavings_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_TimeZoneInfoOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717546, XrefRangeEnd = 717556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, Nullable<int> ruleIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&baseUtcOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ruleIndex));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDaylightSavingsStartOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717556, XrefRangeEnd = 717562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&baseUtcOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDaylightSavingsEndOffsetFromUtc_Private_TimeSpan_TimeSpan_AdjustmentRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 717721, RefRangeEnd = 717723, XrefRangeStart = 717562, XrefRangeEnd = 717721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, Nullable<int> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&time);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &utc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ruleIndex));
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAmbiguousLocalDst);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsDaylightSavingsFromUtc_Private_Static_Boolean_DateTime_Int32_TimeSpan_AdjustmentRule_Nullable_1_Int32_byref_Boolean_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 717760, RefRangeEnd = 717762, XrefRangeStart = 717723, XrefRangeEnd = 717760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&startTime);
		*(DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(DateTime**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endTime;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreYearAdjustment;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsDst_Private_Static_Boolean_DateTime_DateTime_DateTime_Boolean_AdjustmentRule_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 717818, RefRangeEnd = 717819, XrefRangeStart = 717762, XrefRangeEnd = 717818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(DaylightTimeStruct**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsAmbiguousTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 717875, RefRangeEnd = 717876, XrefRangeStart = 717819, XrefRangeEnd = 717875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rule);
		*(DaylightTimeStruct**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &daylightTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsInvalidTime_Private_Static_Boolean_DateTime_AdjustmentRule_DaylightTimeStruct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 717900, RefRangeEnd = 717901, XrefRangeStart = 717876, XrefRangeEnd = 717900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zone);
		*(TimeZoneInfoOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_DateTime_TimeZoneInfo_TimeZoneInfoOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 717908, RefRangeEnd = 717910, XrefRangeStart = 717901, XrefRangeEnd = 717908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 717914, RefRangeEnd = 717915, XrefRangeStart = 717910, XrefRangeEnd = 717914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zone);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isDaylightSavings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffsetFromUtc_Private_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 717965, RefRangeEnd = 717969, XrefRangeStart = 717915, XrefRangeEnd = 717965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&time);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zone);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isDaylightSavings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAmbiguousLocalDst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffsetFromUtc_Internal_Static_TimeSpan_DateTime_TimeZoneInfo_byref_Boolean_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 717993, RefRangeEnd = 717995, XrefRangeStart = 717969, XrefRangeEnd = 717993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&year);
		*(TransitionTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transitionTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionTimeToDateTime_Internal_Static_DateTime_Int32_TransitionTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718008, RefRangeEnd = 718010, XrefRangeStart = 717995, XrefRangeEnd = 718008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstDisabled;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &alwaysFallbackToLocalMachine;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTimeZone_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		value = ((num5 == 0) ? null : new TimeZoneInfo(num5));
		nint num6 = num4;
		e = ((num6 == 0) ? null : new Exception(num6));
		return *(TimeZoneInfoResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718010, XrefRangeEnd = 718046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstDisabled;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTimeZoneFromLocalMachine_Private_Static_TimeZoneInfoResult_String_Boolean_byref_TimeZoneInfo_byref_Exception_CachedData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		value = ((num5 == 0) ? null : new TimeZoneInfo(num5));
		nint num6 = num4;
		e = ((num6 == 0) ? null : new Exception(num6));
		return *(TimeZoneInfoResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 718061, RefRangeEnd = 718064, XrefRangeStart = 718046, XrefRangeEnd = 718061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, Il2CppReferenceArray<AdjustmentRule> adjustmentRules, out bool adjustmentRulesSupportDst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseUtcOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adjustmentRules);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref adjustmentRulesSupportDst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTimeZoneInfo_Private_Static_Void_String_TimeSpan_Il2CppReferenceArray_1_AdjustmentRule_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 718072, RefRangeEnd = 718074, XrefRangeStart = 718064, XrefRangeEnd = 718072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UtcOffsetOutOfRange(TimeSpan offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UtcOffsetOutOfRange_Internal_Static_Boolean_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718074, XrefRangeEnd = 718086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&baseUtcOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adjustmentRule);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUtcOffset_Private_Static_TimeSpan_TimeSpan_AdjustmentRule_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 718101, RefRangeEnd = 718102, XrefRangeStart = 718086, XrefRangeEnd = 718101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&baseUtcOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adjustmentRule);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidAdjustmentRuleOffest_Private_Static_Boolean_TimeSpan_AdjustmentRule_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718102, XrefRangeEnd = 718105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeZoneInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TimeZoneInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
