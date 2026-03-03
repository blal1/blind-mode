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

namespace UnityEngine.InputSystem.HID;

public static class HIDParser : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct HIDReportData
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportType;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentBitOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindOrAddReport_Public_Static_Int32_Nullable_1_Int32_HIDReportType_List_1_HIDReportData_0;

		[FieldOffset(0)]
		public int reportId;

		[FieldOffset(4)]
		public HID.HIDReportType reportType;

		[FieldOffset(8)]
		public int currentBitOffset;

		static HIDReportData()
		{
			Il2CppClassPointerStore<HIDReportData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDParser>.NativeClassPtr, "HIDReportData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDReportData>.NativeClassPtr);
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDReportData>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_reportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDReportData>.NativeClassPtr, "reportType");
			NativeFieldInfoPtr_currentBitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDReportData>.NativeClassPtr, "currentBitOffset");
			NativeMethodInfoPtr_FindOrAddReport_Public_Static_Int32_Nullable_1_Int32_HIDReportType_List_1_HIDReportData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDReportData>.NativeClassPtr, 100667060);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005933, RefRangeEnd = 1005934, XrefRangeStart = 1005921, XrefRangeEnd = 1005933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindOrAddReport(Il2CppSystem.Nullable<int> reportId, HID.HIDReportType reportType, List<HIDReportData> reports)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)reportId));
			*(HID.HIDReportType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reportType;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reports);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindOrAddReport_Public_Static_Int32_Nullable_1_Int32_HIDReportType_List_1_HIDReportData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HIDReportData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("Unity.InputSystem.dll", "", "HIDItemTypeAndTag")]
	public enum HIDItemTypeAndTag
	{
		Input = 128,
		Output = 144,
		Feature = 176,
		Collection = 160,
		EndCollection = 192,
		UsagePage = 4,
		LogicalMinimum = 20,
		LogicalMaximum = 36,
		PhysicalMinimum = 52,
		PhysicalMaximum = 68,
		UnitExponent = 84,
		Unit = 100,
		ReportSize = 116,
		ReportID = 132,
		ReportCount = 148,
		Push = 164,
		Pop = 180,
		Usage = 8,
		UsageMinimum = 24,
		UsageMaximum = 40,
		DesignatorIndex = 56,
		DesignatorMinimum = 72,
		DesignatorMaximum = 88,
		StringIndex = 120,
		StringMinimum = 136,
		StringMaximum = 152,
		Delimiter = 168
	}

	public sealed class HIDItemStateLocal : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeFieldInfoPtr_usageMinimum;

		private static readonly System.IntPtr NativeFieldInfoPtr_usageMaximum;

		private static readonly System.IntPtr NativeFieldInfoPtr_designatorIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_designatorMinimum;

		private static readonly System.IntPtr NativeFieldInfoPtr_designatorMaximum;

		private static readonly System.IntPtr NativeFieldInfoPtr_stringIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_stringMinimum;

		private static readonly System.IntPtr NativeFieldInfoPtr_stringMaximum;

		private static readonly System.IntPtr NativeFieldInfoPtr_usageList;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_byref_HIDItemStateLocal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetUsage_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetUsage_Public_Int32_Int32_0;

		public unsafe Il2CppSystem.Nullable<int> usage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> usageMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMinimum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMinimum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> usageMaximum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMaximum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMaximum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> designatorIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designatorIndex);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designatorIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> designatorMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designatorMinimum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designatorMinimum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> designatorMaximum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designatorMaximum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designatorMaximum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> stringIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringIndex);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> stringMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringMinimum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringMinimum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> stringMaximum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringMaximum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringMaximum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe List<int> usageList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static HIDItemStateLocal()
		{
			Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDParser>.NativeClassPtr, "HIDItemStateLocal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr);
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "usage");
			NativeFieldInfoPtr_usageMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "usageMinimum");
			NativeFieldInfoPtr_usageMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "usageMaximum");
			NativeFieldInfoPtr_designatorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "designatorIndex");
			NativeFieldInfoPtr_designatorMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "designatorMinimum");
			NativeFieldInfoPtr_designatorMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "designatorMaximum");
			NativeFieldInfoPtr_stringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "stringIndex");
			NativeFieldInfoPtr_stringMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "stringMinimum");
			NativeFieldInfoPtr_stringMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "stringMaximum");
			NativeFieldInfoPtr_usageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, "usageList");
			NativeMethodInfoPtr_Reset_Public_Static_Void_byref_HIDItemStateLocal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, 100667061);
			NativeMethodInfoPtr_SetUsage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, 100667062);
			NativeMethodInfoPtr_GetUsage_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr, 100667063);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005934, XrefRangeEnd = 1005936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset(ref HIDItemStateLocal state)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Static_Void_byref_HIDItemStateLocal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005953, RefRangeEnd = 1005954, XrefRangeStart = 1005936, XrefRangeEnd = 1005953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUsage(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUsage_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1005962, RefRangeEnd = 1005967, XrefRangeStart = 1005954, XrefRangeEnd = 1005962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUsage(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsage_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public HIDItemStateLocal(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HIDItemStateLocal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDItemStateLocal>.NativeClassPtr))
		{
		}
	}

	public sealed class HIDItemStateGlobal : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_usagePage;

		private static readonly System.IntPtr NativeFieldInfoPtr_logicalMinimum;

		private static readonly System.IntPtr NativeFieldInfoPtr_logicalMaximum;

		private static readonly System.IntPtr NativeFieldInfoPtr_physicalMinimum;

		private static readonly System.IntPtr NativeFieldInfoPtr_physicalMaximum;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitExponent;

		private static readonly System.IntPtr NativeFieldInfoPtr_unit;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetUsagePage_Public_UsagePage_Int32_byref_HIDItemStateLocal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysicalMin_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysicalMax_Public_Int32_0;

		public unsafe Il2CppSystem.Nullable<int> usagePage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> logicalMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMinimum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMinimum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> logicalMaximum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMaximum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMaximum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> physicalMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMinimum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMinimum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> physicalMaximum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMaximum);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMaximum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> unitExponent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitExponent);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitExponent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> unit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unit);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> reportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportSize);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> reportCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportCount);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> reportId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportId);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static HIDItemStateGlobal()
		{
			Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDParser>.NativeClassPtr, "HIDItemStateGlobal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr);
			NativeFieldInfoPtr_usagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "usagePage");
			NativeFieldInfoPtr_logicalMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "logicalMinimum");
			NativeFieldInfoPtr_logicalMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "logicalMaximum");
			NativeFieldInfoPtr_physicalMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "physicalMinimum");
			NativeFieldInfoPtr_physicalMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "physicalMaximum");
			NativeFieldInfoPtr_unitExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "unitExponent");
			NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "unit");
			NativeFieldInfoPtr_reportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "reportSize");
			NativeFieldInfoPtr_reportCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "reportCount");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, "reportId");
			NativeMethodInfoPtr_GetUsagePage_Public_UsagePage_Int32_byref_HIDItemStateLocal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, 100667064);
			NativeMethodInfoPtr_GetPhysicalMin_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, 100667065);
			NativeMethodInfoPtr_GetPhysicalMax_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr, 100667066);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005967, XrefRangeEnd = 1005972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HID.UsagePage GetUsagePage(int index, ref HIDItemStateLocal localItemState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&index);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localItemState);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsagePage_Public_UsagePage_Int32_byref_HIDItemStateLocal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HID.UsagePage*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005983, RefRangeEnd = 1005984, XrefRangeStart = 1005972, XrefRangeEnd = 1005983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPhysicalMin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPhysicalMin_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005995, RefRangeEnd = 1005996, XrefRangeStart = 1005984, XrefRangeEnd = 1005995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPhysicalMax()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPhysicalMax_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public HIDItemStateGlobal(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HIDItemStateGlobal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDItemStateGlobal>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseReportDescriptor_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_HIDDeviceDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseReportDescriptor_Public_Static_Boolean_ptr_Byte_Int32_byref_HIDDeviceDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadData_Private_Static_Int32_Int32_ptr_Byte_ptr_Byte_0;

	static HIDParser()
	{
		Il2CppClassPointerStore<HIDParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.HID", "HIDParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDParser>.NativeClassPtr);
		NativeMethodInfoPtr_ParseReportDescriptor_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_HIDDeviceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDParser>.NativeClassPtr, 100667057);
		NativeMethodInfoPtr_ParseReportDescriptor_Public_Static_Boolean_ptr_Byte_Int32_byref_HIDDeviceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDParser>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr_ReadData_Private_Static_Int32_Int32_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDParser>.NativeClassPtr, 100667059);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005996, XrefRangeEnd = 1006005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseReportDescriptor(Il2CppStructArray<byte> buffer, ref HID.HIDDeviceDescriptor deviceDescriptor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseReportDescriptor_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_HIDDeviceDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1006145, RefRangeEnd = 1006147, XrefRangeStart = 1006005, XrefRangeEnd = 1006145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)bufferPtr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseReportDescriptor_Public_Static_Boolean_ptr_Byte_Int32_byref_HIDDeviceDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1006147, RefRangeEnd = 1006161, XrefRangeStart = 1006147, XrefRangeEnd = 1006147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReadData(int itemSize, byte* currentPtr, byte* endPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&itemSize);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = currentPtr;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = endPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadData_Private_Static_Int32_Int32_ptr_Byte_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HIDParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
