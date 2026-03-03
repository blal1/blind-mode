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
using Unity.Profiling;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.HID;

public class HID : InputDevice
{
	[System.Serializable]
	public class HIDLayoutBuilder : Il2CppSystem.Object
	{
		[System.Serializable]
		[ObfuscatedName("UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__4_1;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__4_2;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Build_b__4_0_Internal_Boolean_HIDElementDescriptor_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Build_b__4_1_Internal_Boolean_HIDElementDescriptor_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Build_b__4_2_Internal_String_ControlItem_0;

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

			public unsafe static Il2CppSystem.Predicate<HIDElementDescriptor> __9__4_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<HIDElementDescriptor>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__4_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Predicate<HIDElementDescriptor> __9__4_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<HIDElementDescriptor>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__4_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<InputControlLayout.ControlItem, string> __9__4_2
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputControlLayout.ControlItem, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__4_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__4_0");
				NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__4_1");
				NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__4_2");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667019);
				NativeMethodInfoPtr__Build_b__4_0_Internal_Boolean_HIDElementDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667020);
				NativeMethodInfoPtr__Build_b__4_1_Internal_Boolean_HIDElementDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667021);
				NativeMethodInfoPtr__Build_b__4_2_Internal_String_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667022);
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
			public unsafe bool _Build_b__4_0(HIDElementDescriptor element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)element));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Build_b__4_0_Internal_Boolean_HIDElementDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _Build_b__4_1(HIDElementDescriptor element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)element));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Build_b__4_1_Internal_Boolean_HIDElementDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005092, XrefRangeEnd = 1005093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Build_b__4_2(InputControlLayout.ControlItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Build_b__4_2_Internal_String_ControlItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_displayName;

		private static readonly System.IntPtr NativeFieldInfoPtr_hidDescriptor;

		private static readonly System.IntPtr NativeFieldInfoPtr_parentLayout;

		private static readonly System.IntPtr NativeFieldInfoPtr_deviceType;

		private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_InputControlLayout_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string displayName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe HIDDeviceDescriptor hidDescriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidDescriptor);
				return new HIDDeviceDescriptor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidDescriptor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe string parentLayout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentLayout);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentLayout)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppSystem.Type deviceType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceType);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static HIDLayoutBuilder()
		{
			Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HID>.NativeClassPtr, "HIDLayoutBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr);
			NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, "displayName");
			NativeFieldInfoPtr_hidDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, "hidDescriptor");
			NativeFieldInfoPtr_parentLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, "parentLayout");
			NativeFieldInfoPtr_deviceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, "deviceType");
			NativeMethodInfoPtr_Build_Public_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, 100667016);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr, 100667017);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005297, RefRangeEnd = 1005298, XrefRangeStart = 1005093, XrefRangeEnd = 1005297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlLayout Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Build_Public_InputControlLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDLayoutBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDLayoutBuilder>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public HIDLayoutBuilder(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.InputSystem.dll", "", "HIDReportType")]
	public enum HIDReportType
	{
		Unknown,
		Input,
		Output,
		Feature
	}

	[OriginalName("Unity.InputSystem.dll", "", "HIDCollectionType")]
	public enum HIDCollectionType
	{
		Physical,
		Application,
		Logical,
		Report,
		NamedArray,
		UsageSwitch,
		UsageModifier
	}

	[OriginalName("Unity.InputSystem.dll", "", "HIDElementFlags")]
	[System.Flags]
	public enum HIDElementFlags
	{
		Constant = 1,
		Variable = 2,
		Relative = 4,
		Wrap = 8,
		NonLinear = 0x10,
		NoPreferred = 0x20,
		NullState = 0x40,
		Volatile = 0x80,
		BufferedBytes = 0x100
	}

	[System.Serializable]
	public sealed class HIDElementDescriptor : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeFieldInfoPtr_usagePage;

		private static readonly System.IntPtr NativeFieldInfoPtr_unit;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitExponent;

		private static readonly System.IntPtr NativeFieldInfoPtr_logicalMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_logicalMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_physicalMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_physicalMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportType;

		private static readonly System.IntPtr NativeFieldInfoPtr_collectionIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportSizeInBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportOffsetInBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_usageMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_usageMax;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasNullState_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasPreferredState_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isArray_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isNonLinear_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isRelative_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isConstant_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isWrapping_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isSigned_Internal_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_minFloatValue_Internal_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_maxFloatValue_Internal_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Is_Public_Boolean_UsagePage_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineName_Internal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineDisplayName_Internal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsUsableElement_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineLayout_Internal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineFormat_Internal_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineUsages_Internal_Il2CppReferenceArray_1_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineParameters_Internal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineAxisNormalizationParameters_Private_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineProcessors_Internal_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DetermineDefaultState_Internal_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddChildControls_Internal_Void_byref_HIDElementDescriptor_String_byref_Builder_0;

		public unsafe int usage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage)) = value;
			}
		}

		public unsafe UsagePage usagePage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage);
				return *(UsagePage*)num;
			}
			set
			{
				*(UsagePage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage)) = value;
			}
		}

		public unsafe int unit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unit);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unit)) = value;
			}
		}

		public unsafe int unitExponent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitExponent);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitExponent)) = value;
			}
		}

		public unsafe int logicalMin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMin);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMin)) = value;
			}
		}

		public unsafe int logicalMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMax);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalMax)) = value;
			}
		}

		public unsafe int physicalMin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMin);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMin)) = value;
			}
		}

		public unsafe int physicalMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMax);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalMax)) = value;
			}
		}

		public unsafe HIDReportType reportType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportType);
				return *(HIDReportType*)num;
			}
			set
			{
				*(HIDReportType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportType)) = value;
			}
		}

		public unsafe int collectionIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectionIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectionIndex)) = value;
			}
		}

		public unsafe int reportId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportId)) = value;
			}
		}

		public unsafe int reportSizeInBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportSizeInBits);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportSizeInBits)) = value;
			}
		}

		public unsafe int reportOffsetInBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportOffsetInBits);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportOffsetInBits)) = value;
			}
		}

		public unsafe HIDElementFlags flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags);
				return *(HIDElementFlags*)num;
			}
			set
			{
				*(HIDElementFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags)) = value;
			}
		}

		public unsafe Il2CppSystem.Nullable<int> usageMin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMin);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMin), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Nullable<int> usageMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMax);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageMax), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool hasNullState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasNullState_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool hasPreferredState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasPreferredState_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isArray_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isNonLinear
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isNonLinear_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRelative_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isConstant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isConstant_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isWrapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isWrapping_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isSigned
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1005298, RefRangeEnd = 1005302, XrefRangeStart = 1005298, XrefRangeEnd = 1005298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSigned_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe float minFloatValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minFloatValue_Internal_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe float maxFloatValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxFloatValue_Internal_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static HIDElementDescriptor()
		{
			Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HID>.NativeClassPtr, "HIDElementDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr);
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "usage");
			NativeFieldInfoPtr_usagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "usagePage");
			NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "unit");
			NativeFieldInfoPtr_unitExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "unitExponent");
			NativeFieldInfoPtr_logicalMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "logicalMin");
			NativeFieldInfoPtr_logicalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "logicalMax");
			NativeFieldInfoPtr_physicalMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "physicalMin");
			NativeFieldInfoPtr_physicalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "physicalMax");
			NativeFieldInfoPtr_reportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "reportType");
			NativeFieldInfoPtr_collectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "collectionIndex");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_reportSizeInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "reportSizeInBits");
			NativeFieldInfoPtr_reportOffsetInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "reportOffsetInBits");
			NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "flags");
			NativeFieldInfoPtr_usageMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "usageMin");
			NativeFieldInfoPtr_usageMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, "usageMax");
			NativeMethodInfoPtr_get_hasNullState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667023);
			NativeMethodInfoPtr_get_hasPreferredState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667024);
			NativeMethodInfoPtr_get_isArray_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667025);
			NativeMethodInfoPtr_get_isNonLinear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667026);
			NativeMethodInfoPtr_get_isRelative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667027);
			NativeMethodInfoPtr_get_isConstant_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667028);
			NativeMethodInfoPtr_get_isWrapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667029);
			NativeMethodInfoPtr_get_isSigned_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667030);
			NativeMethodInfoPtr_get_minFloatValue_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667031);
			NativeMethodInfoPtr_get_maxFloatValue_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667032);
			NativeMethodInfoPtr_Is_Public_Boolean_UsagePage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667033);
			NativeMethodInfoPtr_DetermineName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667034);
			NativeMethodInfoPtr_DetermineDisplayName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667035);
			NativeMethodInfoPtr_IsUsableElement_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667036);
			NativeMethodInfoPtr_DetermineLayout_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667037);
			NativeMethodInfoPtr_DetermineFormat_Internal_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667038);
			NativeMethodInfoPtr_DetermineUsages_Internal_Il2CppReferenceArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667039);
			NativeMethodInfoPtr_DetermineParameters_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667040);
			NativeMethodInfoPtr_DetermineAxisNormalizationParameters_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667041);
			NativeMethodInfoPtr_DetermineProcessors_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667042);
			NativeMethodInfoPtr_DetermineDefaultState_Internal_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667043);
			NativeMethodInfoPtr_AddChildControls_Internal_Void_byref_HIDElementDescriptor_String_byref_Builder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr, 100667044);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005302, RefRangeEnd = 1005304, XrefRangeStart = 1005302, XrefRangeEnd = 1005302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Is(UsagePage usagePage, int usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&usagePage);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Is_Public_Boolean_UsagePage_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005319, RefRangeEnd = 1005320, XrefRangeStart = 1005304, XrefRangeEnd = 1005319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetermineName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineName_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005325, RefRangeEnd = 1005326, XrefRangeStart = 1005320, XrefRangeEnd = 1005325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetermineDisplayName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineDisplayName_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005327, RefRangeEnd = 1005328, XrefRangeStart = 1005326, XrefRangeEnd = 1005327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUsableElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsableElement_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005332, RefRangeEnd = 1005334, XrefRangeStart = 1005328, XrefRangeEnd = 1005332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetermineLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineLayout_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005338, RefRangeEnd = 1005339, XrefRangeStart = 1005334, XrefRangeEnd = 1005338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FourCC DetermineFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineFormat_Internal_FourCC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005349, RefRangeEnd = 1005350, XrefRangeStart = 1005339, XrefRangeEnd = 1005349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<InternedString> DetermineUsages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineUsages_Internal_Il2CppReferenceArray_1_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternedString>>(intPtr2) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1005364, RefRangeEnd = 1005367, XrefRangeStart = 1005350, XrefRangeEnd = 1005364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetermineParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineParameters_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005371, RefRangeEnd = 1005373, XrefRangeStart = 1005367, XrefRangeEnd = 1005371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetermineAxisNormalizationParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineAxisNormalizationParameters_Private_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1005375, RefRangeEnd = 1005378, XrefRangeStart = 1005373, XrefRangeEnd = 1005375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetermineProcessors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineProcessors_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1005379, RefRangeEnd = 1005383, XrefRangeStart = 1005378, XrefRangeEnd = 1005379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimitiveValue DetermineDefaultState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineDefaultState_Internal_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005480, RefRangeEnd = 1005481, XrefRangeStart = 1005383, XrefRangeEnd = 1005480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildControls(ref HIDElementDescriptor element, string controlName, ref InputControlLayout.Builder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)element);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(controlName);
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			*(System.IntPtr**)num = &intPtr;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChildControls_Internal_Void_byref_HIDElementDescriptor_String_byref_Builder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == (System.IntPtr)0) ? null : new InputControlLayout.Builder(intPtr4));
		}

		public HIDElementDescriptor(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HIDElementDescriptor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDElementDescriptor>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct HIDCollectionDescriptor
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeFieldInfoPtr_usagePage;

		private static readonly System.IntPtr NativeFieldInfoPtr_parent;

		private static readonly System.IntPtr NativeFieldInfoPtr_childCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstChild;

		[FieldOffset(0)]
		public HIDCollectionType type;

		[FieldOffset(4)]
		public int usage;

		[FieldOffset(8)]
		public UsagePage usagePage;

		[FieldOffset(12)]
		public int parent;

		[FieldOffset(16)]
		public int childCount;

		[FieldOffset(20)]
		public int firstChild;

		static HIDCollectionDescriptor()
		{
			Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HID>.NativeClassPtr, "HIDCollectionDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, "type");
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, "usage");
			NativeFieldInfoPtr_usagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, "usagePage");
			NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, "parent");
			NativeFieldInfoPtr_childCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, "childCount");
			NativeFieldInfoPtr_firstChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, "firstChild");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HIDCollectionDescriptor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public sealed class HIDDeviceDescriptor : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_vendorId;

		private static readonly System.IntPtr NativeFieldInfoPtr_productId;

		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeFieldInfoPtr_usagePage;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputReportSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_outputReportSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_featureReportSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_elements;

		private static readonly System.IntPtr NativeFieldInfoPtr_collections;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FromJson_Public_Static_HIDDeviceDescriptor_String_0;

		public unsafe int vendorId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vendorId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vendorId)) = value;
			}
		}

		public unsafe int productId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productId)) = value;
			}
		}

		public unsafe int usage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage)) = value;
			}
		}

		public unsafe UsagePage usagePage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage);
				return *(UsagePage*)num;
			}
			set
			{
				*(UsagePage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage)) = value;
			}
		}

		public unsafe int inputReportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputReportSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputReportSize)) = value;
			}
		}

		public unsafe int outputReportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputReportSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputReportSize)) = value;
			}
		}

		public unsafe int featureReportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureReportSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureReportSize)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<HIDElementDescriptor> elements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDElementDescriptor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<HIDCollectionDescriptor> collections
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collections);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HIDCollectionDescriptor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static HIDDeviceDescriptor()
		{
			Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HID>.NativeClassPtr, "HIDDeviceDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr);
			NativeFieldInfoPtr_vendorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "vendorId");
			NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "productId");
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "usage");
			NativeFieldInfoPtr_usagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "usagePage");
			NativeFieldInfoPtr_inputReportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "inputReportSize");
			NativeFieldInfoPtr_outputReportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "outputReportSize");
			NativeFieldInfoPtr_featureReportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "featureReportSize");
			NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "elements");
			NativeFieldInfoPtr_collections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, "collections");
			NativeMethodInfoPtr_ToJson_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, 100667045);
			NativeMethodInfoPtr_FromJson_Public_Static_HIDDeviceDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, 100667046);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005481, XrefRangeEnd = 1005485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJson_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1005614, RefRangeEnd = 1005617, XrefRangeStart = 1005485, XrefRangeEnd = 1005614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HIDDeviceDescriptor FromJson(string json)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJson_Public_Static_HIDDeviceDescriptor_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptor(pointer);
		}

		public HIDDeviceDescriptor(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HIDDeviceDescriptor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr))
		{
		}
	}

	public sealed class HIDDeviceDescriptorBuilder : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_usagePage;

		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentReportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentReportType;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentReportOffsetInBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Elements;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Collections;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InputReportSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_OutputReportSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_FeatureReportSize;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UsagePage_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GenericDesktop_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_StartReport_Public_HIDDeviceDescriptorBuilder_HIDReportType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddElement_Public_HIDDeviceDescriptorBuilder_UsagePage_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddElement_Public_HIDDeviceDescriptorBuilder_GenericDesktop_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithPhysicalMinMax_Public_HIDDeviceDescriptorBuilder_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithLogicalMinMax_Public_HIDDeviceDescriptorBuilder_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Public_HIDDeviceDescriptor_0;

		public unsafe UsagePage usagePage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage);
				return *(UsagePage*)num;
			}
			set
			{
				*(UsagePage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usagePage)) = value;
			}
		}

		public unsafe int usage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage)) = value;
			}
		}

		public unsafe int m_CurrentReportId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentReportId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentReportId)) = value;
			}
		}

		public unsafe HIDReportType m_CurrentReportType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentReportType);
				return *(HIDReportType*)num;
			}
			set
			{
				*(HIDReportType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentReportType)) = value;
			}
		}

		public unsafe int m_CurrentReportOffsetInBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentReportOffsetInBits);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentReportOffsetInBits)) = value;
			}
		}

		public unsafe List<HIDElementDescriptor> m_Elements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Elements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HIDElementDescriptor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Elements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<HIDCollectionDescriptor> m_Collections
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Collections);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HIDCollectionDescriptor>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Collections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_InputReportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputReportSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputReportSize)) = value;
			}
		}

		public unsafe int m_OutputReportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputReportSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutputReportSize)) = value;
			}
		}

		public unsafe int m_FeatureReportSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FeatureReportSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FeatureReportSize)) = value;
			}
		}

		static HIDDeviceDescriptorBuilder()
		{
			Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HID>.NativeClassPtr, "HIDDeviceDescriptorBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr);
			NativeFieldInfoPtr_usagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "usagePage");
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "usage");
			NativeFieldInfoPtr_m_CurrentReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_CurrentReportId");
			NativeFieldInfoPtr_m_CurrentReportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_CurrentReportType");
			NativeFieldInfoPtr_m_CurrentReportOffsetInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_CurrentReportOffsetInBits");
			NativeFieldInfoPtr_m_Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_Elements");
			NativeFieldInfoPtr_m_Collections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_Collections");
			NativeFieldInfoPtr_m_InputReportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_InputReportSize");
			NativeFieldInfoPtr_m_OutputReportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_OutputReportSize");
			NativeFieldInfoPtr_m_FeatureReportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, "m_FeatureReportSize");
			NativeMethodInfoPtr__ctor_Public_Void_UsagePage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667047);
			NativeMethodInfoPtr__ctor_Public_Void_GenericDesktop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667048);
			NativeMethodInfoPtr_StartReport_Public_HIDDeviceDescriptorBuilder_HIDReportType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667049);
			NativeMethodInfoPtr_AddElement_Public_HIDDeviceDescriptorBuilder_UsagePage_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667050);
			NativeMethodInfoPtr_AddElement_Public_HIDDeviceDescriptorBuilder_GenericDesktop_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667051);
			NativeMethodInfoPtr_WithPhysicalMinMax_Public_HIDDeviceDescriptorBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667052);
			NativeMethodInfoPtr_WithLogicalMinMax_Public_HIDDeviceDescriptorBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667053);
			NativeMethodInfoPtr_Finish_Public_HIDDeviceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr, 100667054);
		}

		[CallerCount(0)]
		public unsafe HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&usagePage);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UsagePage_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe HIDDeviceDescriptorBuilder(GenericDesktop usage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&usage);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GenericDesktop_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&reportType);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reportId;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartReport_Public_HIDDeviceDescriptorBuilder_HIDReportType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptorBuilder(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005642, RefRangeEnd = 1005643, XrefRangeStart = 1005617, XrefRangeEnd = 1005642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&usagePage);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddElement_Public_HIDDeviceDescriptorBuilder_UsagePage_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptorBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005643, XrefRangeEnd = 1005644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&usage);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddElement_Public_HIDDeviceDescriptorBuilder_GenericDesktop_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptorBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005644, XrefRangeEnd = 1005651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&min);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithPhysicalMinMax_Public_HIDDeviceDescriptorBuilder_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptorBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005651, XrefRangeEnd = 1005658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&min);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithLogicalMinMax_Public_HIDDeviceDescriptorBuilder_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptorBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005658, XrefRangeEnd = 1005667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDDeviceDescriptor Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finish_Public_HIDDeviceDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptor(pointer);
		}

		public HIDDeviceDescriptorBuilder(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public HIDDeviceDescriptorBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDescriptorBuilder>.NativeClassPtr))
		{
		}
	}

	[OriginalName("Unity.InputSystem.dll", "", "UsagePage")]
	public enum UsagePage
	{
		Undefined = 0,
		GenericDesktop = 1,
		Simulation = 2,
		VRControls = 3,
		SportControls = 4,
		GameControls = 5,
		GenericDeviceControls = 6,
		Keyboard = 7,
		LEDs = 8,
		Button = 9,
		Ordinal = 10,
		Telephony = 11,
		Consumer = 12,
		Digitizer = 13,
		PID = 15,
		Unicode = 16,
		AlphanumericDisplay = 20,
		MedicalInstruments = 64,
		Monitor = 128,
		Power = 132,
		BarCodeScanner = 140,
		MagneticStripeReader = 142,
		Camera = 144,
		Arcade = 145,
		VendorDefined = 65280
	}

	[OriginalName("Unity.InputSystem.dll", "", "GenericDesktop")]
	public enum GenericDesktop
	{
		Undefined = 0,
		Pointer = 1,
		Mouse = 2,
		Joystick = 4,
		Gamepad = 5,
		Keyboard = 6,
		Keypad = 7,
		MultiAxisController = 8,
		TabletPCControls = 9,
		AssistiveControl = 10,
		X = 48,
		Y = 49,
		Z = 50,
		Rx = 51,
		Ry = 52,
		Rz = 53,
		Slider = 54,
		Dial = 55,
		Wheel = 56,
		HatSwitch = 57,
		CountedBuffer = 58,
		ByteCount = 59,
		MotionWakeup = 60,
		Start = 61,
		Select = 62,
		Vx = 64,
		Vy = 65,
		Vz = 66,
		Vbrx = 67,
		Vbry = 68,
		Vbrz = 69,
		Vno = 70,
		FeatureNotification = 71,
		ResolutionMultiplier = 72,
		SystemControl = 128,
		SystemPowerDown = 129,
		SystemSleep = 130,
		SystemWakeUp = 131,
		SystemContextMenu = 132,
		SystemMainMenu = 133,
		SystemAppMenu = 134,
		SystemMenuHelp = 135,
		SystemMenuExit = 136,
		SystemMenuSelect = 137,
		SystemMenuRight = 138,
		SystemMenuLeft = 139,
		SystemMenuUp = 140,
		SystemMenuDown = 141,
		SystemColdRestart = 142,
		SystemWarmRestart = 143,
		DpadUp = 144,
		DpadDown = 145,
		DpadRight = 146,
		DpadLeft = 147,
		SystemDock = 160,
		SystemUndock = 161,
		SystemSetup = 162,
		SystemBreak = 163,
		SystemDebuggerBreak = 164,
		ApplicationBreak = 165,
		ApplicationDebuggerBreak = 166,
		SystemSpeakerMute = 167,
		SystemHibernate = 168,
		SystemDisplayInvert = 176,
		SystemDisplayInternal = 177,
		SystemDisplayExternal = 178,
		SystemDisplayBoth = 179,
		SystemDisplayDual = 180,
		SystemDisplayToggleIntExt = 181,
		SystemDisplaySwapPrimarySecondary = 182,
		SystemDisplayLCDAutoScale = 183
	}

	[OriginalName("Unity.InputSystem.dll", "", "Simulation")]
	public enum Simulation
	{
		Undefined = 0,
		FlightSimulationDevice = 1,
		AutomobileSimulationDevice = 2,
		TankSimulationDevice = 3,
		SpaceshipSimulationDevice = 4,
		SubmarineSimulationDevice = 5,
		SailingSimulationDevice = 6,
		MotorcycleSimulationDevice = 7,
		SportsSimulationDevice = 8,
		AirplaneSimulationDevice = 9,
		HelicopterSimulationDevice = 10,
		MagicCarpetSimulationDevice = 11,
		BicylcleSimulationDevice = 12,
		FlightControlStick = 32,
		FlightStick = 33,
		CyclicControl = 34,
		CyclicTrim = 35,
		FlightYoke = 36,
		TrackControl = 37,
		Aileron = 176,
		AileronTrim = 177,
		AntiTorqueControl = 178,
		AutopilotEnable = 179,
		ChaffRelease = 180,
		CollectiveControl = 181,
		DiveBreak = 182,
		ElectronicCountermeasures = 183,
		Elevator = 184,
		ElevatorTrim = 185,
		Rudder = 186,
		Throttle = 187,
		FlightCommunications = 188,
		FlareRelease = 189,
		LandingGear = 190,
		ToeBreak = 191,
		Trigger = 192,
		WeaponsArm = 193,
		WeaponsSelect = 194,
		WingFlaps = 195,
		Accelerator = 196,
		Brake = 197,
		Clutch = 198,
		Shifter = 199,
		Steering = 200,
		TurretDirection = 201,
		BarrelElevation = 202,
		DivePlane = 203,
		Ballast = 204,
		BicycleCrank = 205,
		HandleBars = 206,
		FrontBrake = 207,
		RearBrake = 208
	}

	[OriginalName("Unity.InputSystem.dll", "", "Button")]
	public enum Button
	{
		Undefined,
		Primary,
		Secondary,
		Tertiary
	}

	[ObfuscatedName("UnityEngine.InputSystem.HID.HID+<>c__DisplayClass13_0")]
	public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_layout;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OnFindLayoutForDevice_b__0_Internal_InputControlLayout_0;

		public unsafe HIDLayoutBuilder layout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HIDLayoutBuilder>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass13_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HID>.NativeClassPtr, "<>c__DisplayClass13_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr);
			NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, "layout");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, 100667055);
			NativeMethodInfoPtr__OnFindLayoutForDevice_b__0_Internal_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, 100667056);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass13_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005667, XrefRangeEnd = 1005683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlLayout _OnFindLayoutForDevice_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnFindLayoutForDevice_b__0_Internal_InputControlLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
		}

		public __c__DisplayClass13_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kHIDInterface;

	private static readonly System.IntPtr NativeFieldInfoPtr_kHIDNamespace;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HaveParsedHIDDescriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HIDDescriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HIDParseDescriptorFallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_QueryHIDReportDescriptorDeviceCommandType_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_QueryHIDReportDescriptorSizeDeviceCommandType_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_QueryHIDParsedReportDescriptorDeviceCommandType_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hidDescriptor_Public_get_HIDDeviceDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFindLayoutForDevice_Internal_Static_String_byref_InputDeviceDescription_String_InputDeviceExecuteCommandDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadHIDDeviceDescriptor_Internal_Static_HIDDeviceDescriptor_byref_InputDeviceDescription_InputDeviceExecuteCommandDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsagePageToString_Public_Static_String_UsagePage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsageToString_Public_Static_String_UsagePage_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string kHIDInterface
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kHIDInterface, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kHIDInterface, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kHIDNamespace
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kHIDNamespace, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kHIDNamespace, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool m_HaveParsedHIDDescriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HaveParsedHIDDescriptor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HaveParsedHIDDescriptor)) = value;
		}
	}

	public unsafe HIDDeviceDescriptor m_HIDDescriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HIDDescriptor);
			return new HIDDeviceDescriptor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HIDDescriptor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HIDDeviceDescriptor>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static ProfilerMarker k_HIDParseDescriptorFallback
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HIDParseDescriptorFallback, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HIDParseDescriptorFallback, (void*)(&value));
		}
	}

	public unsafe static FourCC QueryHIDReportDescriptorDeviceCommandType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005683, XrefRangeEnd = 1005684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_QueryHIDReportDescriptorDeviceCommandType_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static FourCC QueryHIDReportDescriptorSizeDeviceCommandType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005684, XrefRangeEnd = 1005685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_QueryHIDReportDescriptorSizeDeviceCommandType_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static FourCC QueryHIDParsedReportDescriptorDeviceCommandType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005685, XrefRangeEnd = 1005686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_QueryHIDParsedReportDescriptorDeviceCommandType_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe HIDDeviceDescriptor hidDescriptor
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005691, RefRangeEnd = 1005693, XrefRangeStart = 1005686, XrefRangeEnd = 1005691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hidDescriptor_Public_get_HIDDeviceDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HIDDeviceDescriptor(pointer);
		}
	}

	static HID()
	{
		Il2CppClassPointerStore<HID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.HID", "HID");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HID>.NativeClassPtr);
		NativeFieldInfoPtr_kHIDInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HID>.NativeClassPtr, "kHIDInterface");
		NativeFieldInfoPtr_kHIDNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HID>.NativeClassPtr, "kHIDNamespace");
		NativeFieldInfoPtr_m_HaveParsedHIDDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HID>.NativeClassPtr, "m_HaveParsedHIDDescriptor");
		NativeFieldInfoPtr_m_HIDDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HID>.NativeClassPtr, "m_HIDDescriptor");
		NativeFieldInfoPtr_k_HIDParseDescriptorFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HID>.NativeClassPtr, "k_HIDParseDescriptorFallback");
		NativeMethodInfoPtr_get_QueryHIDReportDescriptorDeviceCommandType_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667006);
		NativeMethodInfoPtr_get_QueryHIDReportDescriptorSizeDeviceCommandType_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667007);
		NativeMethodInfoPtr_get_QueryHIDParsedReportDescriptorDeviceCommandType_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667008);
		NativeMethodInfoPtr_get_hidDescriptor_Public_get_HIDDeviceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667009);
		NativeMethodInfoPtr_OnFindLayoutForDevice_Internal_Static_String_byref_InputDeviceDescription_String_InputDeviceExecuteCommandDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667010);
		NativeMethodInfoPtr_ReadHIDDeviceDescriptor_Internal_Static_HIDDeviceDescriptor_byref_InputDeviceDescription_InputDeviceExecuteCommandDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667011);
		NativeMethodInfoPtr_UsagePageToString_Public_Static_String_UsagePage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667012);
		NativeMethodInfoPtr_UsageToString_Public_Static_String_UsagePage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667013);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HID>.NativeClassPtr, 100667014);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005693, XrefRangeEnd = 1005840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(matchedLayout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)executeDeviceCommand);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFindLayoutForDevice_Internal_Static_String_byref_InputDeviceDescription_String_InputDeviceExecuteCommandDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1005913, RefRangeEnd = 1005914, XrefRangeStart = 1005840, XrefRangeEnd = 1005913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescription);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)executeCommandDelegate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadHIDDeviceDescriptor_Internal_Static_HIDDeviceDescriptor_byref_InputDeviceDescription_InputDeviceExecuteCommandDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HIDDeviceDescriptor(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005914, XrefRangeEnd = 1005917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UsagePageToString(UsagePage usagePage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&usagePage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsagePageToString_Public_Static_String_UsagePage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005917, XrefRangeEnd = 1005921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UsageToString(UsagePage usagePage, int usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&usagePage);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsageToString_Public_Static_String_UsagePage_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HID()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HID>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HID(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
