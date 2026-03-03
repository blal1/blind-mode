using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts;

public class InputControlLayout : Il2CppSystem.Object
{
	public sealed class ControlItem : Il2CppSystem.ValueType
	{
		[OriginalName("Unity.InputSystem.dll", "", "Flags")]
		[System.Flags]
		public enum Flags
		{
			isModifyingExistingControl = 1,
			IsNoisy = 2,
			IsSynthetic = 4,
			IsFirstDefinedInThisLayout = 8,
			DontReset = 0x10
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__name_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__layout_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__variants_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__useStateFrom_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__displayName_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__shortDisplayName_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__usages_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__aliases_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__parameters_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__processors_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__offset_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__bit_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__sizeInBits_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__format_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__flags_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__arraySize_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__defaultState_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__minValue_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__maxValue_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_layout_Public_get_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_layout_Internal_set_Void_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_variants_Public_get_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_variants_Internal_set_Void_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_useStateFrom_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_useStateFrom_Internal_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_displayName_Internal_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_shortDisplayName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_shortDisplayName_Internal_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_usages_Public_get_ReadOnlyArray_1_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_usages_Internal_set_Void_ReadOnlyArray_1_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_aliases_Public_get_ReadOnlyArray_1_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_aliases_Internal_set_Void_ReadOnlyArray_1_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_parameters_Public_get_ReadOnlyArray_1_NamedValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_parameters_Internal_set_Void_ReadOnlyArray_1_NamedValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_processors_Public_get_ReadOnlyArray_1_NameAndParameters_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_processors_Internal_set_Void_ReadOnlyArray_1_NameAndParameters_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_offset_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_offset_Internal_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_bit_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_bit_Internal_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeInBits_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeInBits_Internal_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_format_Internal_set_Void_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_flags_Private_get_Flags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_flags_Private_set_Void_Flags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_arraySize_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_arraySize_Internal_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultState_Public_get_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultState_Internal_set_Void_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_minValue_Public_get_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_minValue_Internal_set_Void_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_maxValue_Internal_set_Void_PrimitiveValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isModifyingExistingControl_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isModifyingExistingControl_Internal_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isNoisy_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isNoisy_Internal_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isSynthetic_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isSynthetic_Internal_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_dontReset_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_dontReset_Internal_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isFirstDefinedInThisLayout_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isFirstDefinedInThisLayout_Internal_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isArray_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_ControlItem_ControlItem_0;

		public unsafe InternedString _name_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name_k__BackingField);
				return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe InternedString _layout_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layout_k__BackingField);
				return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layout_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe InternedString _variants_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__variants_k__BackingField);
				return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__variants_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe string _useStateFrom_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useStateFrom_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useStateFrom_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string _displayName_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string _shortDisplayName_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortDisplayName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortDisplayName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe ReadOnlyArray<InternedString> _usages_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__usages_k__BackingField);
				return new ReadOnlyArray<InternedString>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyArray<InternedString>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__usages_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyArray<InternedString>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ReadOnlyArray<InternedString> _aliases_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aliases_k__BackingField);
				return new ReadOnlyArray<InternedString>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyArray<InternedString>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aliases_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyArray<InternedString>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ReadOnlyArray<NamedValue> _parameters_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parameters_k__BackingField);
				return new ReadOnlyArray<NamedValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyArray<NamedValue>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parameters_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyArray<NamedValue>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ReadOnlyArray<NameAndParameters> _processors_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__processors_k__BackingField);
				return new ReadOnlyArray<NameAndParameters>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyArray<NameAndParameters>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__processors_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyArray<NameAndParameters>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe uint _offset_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__offset_k__BackingField);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__offset_k__BackingField)) = value;
			}
		}

		public unsafe uint _bit_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bit_k__BackingField);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bit_k__BackingField)) = value;
			}
		}

		public unsafe uint _sizeInBits_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizeInBits_k__BackingField);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizeInBits_k__BackingField)) = value;
			}
		}

		public unsafe FourCC _format_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__format_k__BackingField);
				return *(FourCC*)num;
			}
			set
			{
				*(FourCC*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__format_k__BackingField)) = value;
			}
		}

		public unsafe Flags _flags_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__flags_k__BackingField);
				return *(Flags*)num;
			}
			set
			{
				*(Flags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__flags_k__BackingField)) = value;
			}
		}

		public unsafe int _arraySize_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arraySize_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arraySize_k__BackingField)) = value;
			}
		}

		public unsafe PrimitiveValue _defaultState_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultState_k__BackingField);
				return *(PrimitiveValue*)num;
			}
			set
			{
				*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultState_k__BackingField)) = value;
			}
		}

		public unsafe PrimitiveValue _minValue_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minValue_k__BackingField);
				return *(PrimitiveValue*)num;
			}
			set
			{
				*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minValue_k__BackingField)) = value;
			}
		}

		public unsafe PrimitiveValue _maxValue_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxValue_k__BackingField);
				return *(PrimitiveValue*)num;
			}
			set
			{
				*(PrimitiveValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxValue_k__BackingField)) = value;
			}
		}

		public unsafe InternedString name
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InternedString(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_name_Internal_set_Void_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe InternedString layout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 739711, RefRangeEnd = 739712, XrefRangeStart = 739711, XrefRangeEnd = 739712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layout_Public_get_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InternedString(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011018, XrefRangeEnd = 1011025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_layout_Internal_set_Void_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe InternedString variants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_variants_Public_get_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InternedString(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011025, XrefRangeEnd = 1011026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_variants_Internal_set_Void_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe string useStateFrom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useStateFrom_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useStateFrom_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe string displayName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84623, RefRangeEnd = 84624, XrefRangeStart = 84623, XrefRangeEnd = 84624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_displayName_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe string shortDisplayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shortDisplayName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shortDisplayName_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ReadOnlyArray<InternedString> usages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usages_Public_get_ReadOnlyArray_1_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<InternedString>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011026, XrefRangeEnd = 1011027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usages_Internal_set_Void_ReadOnlyArray_1_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ReadOnlyArray<InternedString> aliases
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aliases_Public_get_ReadOnlyArray_1_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<InternedString>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011027, XrefRangeEnd = 1011028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aliases_Internal_set_Void_ReadOnlyArray_1_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ReadOnlyArray<NamedValue> parameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parameters_Public_get_ReadOnlyArray_1_NamedValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<NamedValue>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011028, XrefRangeEnd = 1011029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_parameters_Internal_set_Void_ReadOnlyArray_1_NamedValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ReadOnlyArray<NameAndParameters> processors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_processors_Public_get_ReadOnlyArray_1_NameAndParameters_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<NameAndParameters>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011029, XrefRangeEnd = 1011030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_processors_Internal_set_Void_ReadOnlyArray_1_NameAndParameters_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offset_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offset_Internal_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint bit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bit_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bit_Internal_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint sizeInBits
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 178480, RefRangeEnd = 178492, XrefRangeStart = 178480, XrefRangeEnd = 178492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeInBits_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sizeInBits_Internal_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe FourCC format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_get_FourCC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_format_Internal_set_Void_FourCC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe Flags flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_flags_Private_get_Flags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Flags*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_flags_Private_set_Void_Flags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int arraySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_arraySize_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_arraySize_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe PrimitiveValue defaultState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultState_Public_get_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultState_Internal_set_Void_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe PrimitiveValue minValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minValue_Public_get_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_minValue_Internal_set_Void_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe PrimitiveValue maxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxValue_Public_get_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxValue_Internal_set_Void_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isModifyingExistingControl
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1011030, RefRangeEnd = 1011033, XrefRangeStart = 1011030, XrefRangeEnd = 1011030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isModifyingExistingControl_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isModifyingExistingControl_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isNoisy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1011033, RefRangeEnd = 1011034, XrefRangeStart = 1011033, XrefRangeEnd = 1011033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isNoisy_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isNoisy_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isSynthetic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1011034, RefRangeEnd = 1011035, XrefRangeStart = 1011034, XrefRangeEnd = 1011034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSynthetic_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isSynthetic_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool dontReset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1011035, RefRangeEnd = 1011036, XrefRangeStart = 1011035, XrefRangeEnd = 1011035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dontReset_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dontReset_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isFirstDefinedInThisLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isFirstDefinedInThisLayout_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isFirstDefinedInThisLayout_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isArray
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1011036, RefRangeEnd = 1011039, XrefRangeStart = 1011036, XrefRangeEnd = 1011036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		static ControlItem()
		{
			Il2CppClassPointerStore<ControlItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "ControlItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlItem>.NativeClassPtr);
			NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<name>k__BackingField");
			NativeFieldInfoPtr__layout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<layout>k__BackingField");
			NativeFieldInfoPtr__variants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<variants>k__BackingField");
			NativeFieldInfoPtr__useStateFrom_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<useStateFrom>k__BackingField");
			NativeFieldInfoPtr__displayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<displayName>k__BackingField");
			NativeFieldInfoPtr__shortDisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<shortDisplayName>k__BackingField");
			NativeFieldInfoPtr__usages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<usages>k__BackingField");
			NativeFieldInfoPtr__aliases_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<aliases>k__BackingField");
			NativeFieldInfoPtr__parameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<parameters>k__BackingField");
			NativeFieldInfoPtr__processors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<processors>k__BackingField");
			NativeFieldInfoPtr__offset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<offset>k__BackingField");
			NativeFieldInfoPtr__bit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<bit>k__BackingField");
			NativeFieldInfoPtr__sizeInBits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<sizeInBits>k__BackingField");
			NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<format>k__BackingField");
			NativeFieldInfoPtr__flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<flags>k__BackingField");
			NativeFieldInfoPtr__arraySize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<arraySize>k__BackingField");
			NativeFieldInfoPtr__defaultState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<defaultState>k__BackingField");
			NativeFieldInfoPtr__minValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<minValue>k__BackingField");
			NativeFieldInfoPtr__maxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, "<maxValue>k__BackingField");
			NativeMethodInfoPtr_get_name_Public_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668126);
			NativeMethodInfoPtr_set_name_Internal_set_Void_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668127);
			NativeMethodInfoPtr_get_layout_Public_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668128);
			NativeMethodInfoPtr_set_layout_Internal_set_Void_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668129);
			NativeMethodInfoPtr_get_variants_Public_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668130);
			NativeMethodInfoPtr_set_variants_Internal_set_Void_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668131);
			NativeMethodInfoPtr_get_useStateFrom_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668132);
			NativeMethodInfoPtr_set_useStateFrom_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668133);
			NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668134);
			NativeMethodInfoPtr_set_displayName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668135);
			NativeMethodInfoPtr_get_shortDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668136);
			NativeMethodInfoPtr_set_shortDisplayName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668137);
			NativeMethodInfoPtr_get_usages_Public_get_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668138);
			NativeMethodInfoPtr_set_usages_Internal_set_Void_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668139);
			NativeMethodInfoPtr_get_aliases_Public_get_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668140);
			NativeMethodInfoPtr_set_aliases_Internal_set_Void_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668141);
			NativeMethodInfoPtr_get_parameters_Public_get_ReadOnlyArray_1_NamedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668142);
			NativeMethodInfoPtr_set_parameters_Internal_set_Void_ReadOnlyArray_1_NamedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668143);
			NativeMethodInfoPtr_get_processors_Public_get_ReadOnlyArray_1_NameAndParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668144);
			NativeMethodInfoPtr_set_processors_Internal_set_Void_ReadOnlyArray_1_NameAndParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668145);
			NativeMethodInfoPtr_get_offset_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668146);
			NativeMethodInfoPtr_set_offset_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668147);
			NativeMethodInfoPtr_get_bit_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668148);
			NativeMethodInfoPtr_set_bit_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668149);
			NativeMethodInfoPtr_get_sizeInBits_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668150);
			NativeMethodInfoPtr_set_sizeInBits_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668151);
			NativeMethodInfoPtr_get_format_Public_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668152);
			NativeMethodInfoPtr_set_format_Internal_set_Void_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668153);
			NativeMethodInfoPtr_get_flags_Private_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668154);
			NativeMethodInfoPtr_set_flags_Private_set_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668155);
			NativeMethodInfoPtr_get_arraySize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668156);
			NativeMethodInfoPtr_set_arraySize_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668157);
			NativeMethodInfoPtr_get_defaultState_Public_get_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668158);
			NativeMethodInfoPtr_set_defaultState_Internal_set_Void_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668159);
			NativeMethodInfoPtr_get_minValue_Public_get_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668160);
			NativeMethodInfoPtr_set_minValue_Internal_set_Void_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668161);
			NativeMethodInfoPtr_get_maxValue_Public_get_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668162);
			NativeMethodInfoPtr_set_maxValue_Internal_set_Void_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668163);
			NativeMethodInfoPtr_get_isModifyingExistingControl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668164);
			NativeMethodInfoPtr_set_isModifyingExistingControl_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668165);
			NativeMethodInfoPtr_get_isNoisy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668166);
			NativeMethodInfoPtr_set_isNoisy_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668167);
			NativeMethodInfoPtr_get_isSynthetic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668168);
			NativeMethodInfoPtr_set_isSynthetic_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668169);
			NativeMethodInfoPtr_get_dontReset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668170);
			NativeMethodInfoPtr_set_dontReset_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668171);
			NativeMethodInfoPtr_get_isFirstDefinedInThisLayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668172);
			NativeMethodInfoPtr_set_isFirstDefinedInThisLayout_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668173);
			NativeMethodInfoPtr_get_isArray_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668174);
			NativeMethodInfoPtr_Merge_Public_ControlItem_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItem>.NativeClassPtr, 100668175);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1011079, RefRangeEnd = 1011085, XrefRangeStart = 1011039, XrefRangeEnd = 1011079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlItem Merge(ControlItem other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Merge_Public_ControlItem_ControlItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlItem(pointer);
		}

		public ControlItem(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ControlItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlItem>.NativeClassPtr))
		{
		}
	}

	public class Builder : Il2CppSystem.Object
	{
		public sealed class ControlBuilder : Il2CppSystem.ValueType
		{
			[System.Serializable]
			[ObfuscatedName("UnityEngine.InputSystem.Layouts.InputControlLayout+Builder+ControlBuilder+<>c")]
			public sealed class __c : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr___9;

				private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__WithUsages_b__14_0_Internal_InternedString_String_0;

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

				public unsafe static Il2CppSystem.Func<string, InternedString> __9__14_0
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
					}
				}

				static __c()
				{
					Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
					NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
					NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_0");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668221);
					NativeMethodInfoPtr__WithUsages_b__14_0_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668222);
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
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011085, XrefRangeEnd = 1011086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe InternedString _WithUsages_b__14_0(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WithUsages_b__14_0_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new InternedString(pointer);
				}

				public __c(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_builder;

			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithDisplayName_Public_ControlBuilder_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithLayout_Public_ControlBuilder_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithFormat_Public_ControlBuilder_FourCC_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithFormat_Public_ControlBuilder_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithByteOffset_Public_ControlBuilder_UInt32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithBitOffset_Public_ControlBuilder_UInt32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_IsSynthetic_Public_ControlBuilder_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_IsNoisy_Public_ControlBuilder_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_DontReset_Public_ControlBuilder_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithSizeInBits_Public_ControlBuilder_UInt32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithRange_Public_ControlBuilder_Single_Single_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Il2CppReferenceArray_1_InternedString_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_IEnumerable_1_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Il2CppStringArray_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithParameters_Public_ControlBuilder_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithProcessors_Public_ControlBuilder_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_WithDefaultState_Public_ControlBuilder_PrimitiveValue_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_UsingStateFrom_Public_ControlBuilder_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_AsArrayOfControlsWithSize_Public_ControlBuilder_Int32_0;

			public unsafe Builder builder
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builder);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe int index
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = value;
				}
			}

			static ControlBuilder()
			{
				Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Builder>.NativeClassPtr, "ControlBuilder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr);
				NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, "builder");
				NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, "index");
				NativeMethodInfoPtr_WithDisplayName_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668201);
				NativeMethodInfoPtr_WithLayout_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668202);
				NativeMethodInfoPtr_WithFormat_Public_ControlBuilder_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668203);
				NativeMethodInfoPtr_WithFormat_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668204);
				NativeMethodInfoPtr_WithByteOffset_Public_ControlBuilder_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668205);
				NativeMethodInfoPtr_WithBitOffset_Public_ControlBuilder_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668206);
				NativeMethodInfoPtr_IsSynthetic_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668207);
				NativeMethodInfoPtr_IsNoisy_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668208);
				NativeMethodInfoPtr_DontReset_Public_ControlBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668209);
				NativeMethodInfoPtr_WithSizeInBits_Public_ControlBuilder_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668210);
				NativeMethodInfoPtr_WithRange_Public_ControlBuilder_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668211);
				NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Il2CppReferenceArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668212);
				NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668213);
				NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668214);
				NativeMethodInfoPtr_WithParameters_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668215);
				NativeMethodInfoPtr_WithProcessors_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668216);
				NativeMethodInfoPtr_WithDefaultState_Public_ControlBuilder_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668217);
				NativeMethodInfoPtr_UsingStateFrom_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668218);
				NativeMethodInfoPtr_AsArrayOfControlsWithSize_Public_ControlBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr, 100668219);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1011087, RefRangeEnd = 1011089, XrefRangeStart = 1011086, XrefRangeEnd = 1011087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithDisplayName(string displayName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDisplayName_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1011092, RefRangeEnd = 1011109, XrefRangeStart = 1011089, XrefRangeEnd = 1011092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithLayout(string layout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(layout);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithLayout_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1011109, RefRangeEnd = 1011122, XrefRangeStart = 1011109, XrefRangeEnd = 1011109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithFormat(FourCC format)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&format);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithFormat_Public_ControlBuilder_FourCC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011122, XrefRangeEnd = 1011123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithFormat(string format)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithFormat_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1011123, RefRangeEnd = 1011136, XrefRangeStart = 1011123, XrefRangeEnd = 1011123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithByteOffset(uint offset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&offset);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithByteOffset_Public_ControlBuilder_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1011136, RefRangeEnd = 1011144, XrefRangeStart = 1011136, XrefRangeEnd = 1011136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithBitOffset(uint bit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&bit);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBitOffset_Public_ControlBuilder_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			public unsafe ControlBuilder IsSynthetic(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSynthetic_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			public unsafe ControlBuilder IsNoisy(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNoisy_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			public unsafe ControlBuilder DontReset(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DontReset_Public_ControlBuilder_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1011144, RefRangeEnd = 1011152, XrefRangeStart = 1011144, XrefRangeEnd = 1011144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithSizeInBits(uint sizeInBits)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&sizeInBits);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithSizeInBits_Public_ControlBuilder_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1011154, RefRangeEnd = 1011157, XrefRangeStart = 1011152, XrefRangeEnd = 1011154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithRange(float minValue, float maxValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&minValue);
				*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithRange_Public_ControlBuilder_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1011163, RefRangeEnd = 1011166, XrefRangeStart = 1011157, XrefRangeEnd = 1011163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithUsages([Optional] Il2CppReferenceArray<InternedString> usages)
			{
				if (usages == null)
				{
					usages = (Il2CppReferenceArray<InternedString>)(object)new Il2CppStructArray<InternedString>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usages);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Il2CppReferenceArray_1_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1011188, RefRangeEnd = 1011192, XrefRangeStart = 1011166, XrefRangeEnd = 1011188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithUsages(IEnumerable<string> usages)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usages);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_IEnumerable_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011192, XrefRangeEnd = 1011193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithUsages([Optional] Il2CppStringArray usages)
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				if (usages == null)
				{
					usages = new Il2CppStringArray(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usages);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithUsages_Public_ControlBuilder_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1011199, RefRangeEnd = 1011210, XrefRangeStart = 1011193, XrefRangeEnd = 1011199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithParameters(string parameters)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parameters);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithParameters_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1011219, RefRangeEnd = 1011222, XrefRangeStart = 1011210, XrefRangeEnd = 1011219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithProcessors(string processors)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(processors);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithProcessors_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1011222, RefRangeEnd = 1011225, XrefRangeStart = 1011222, XrefRangeEnd = 1011222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder WithDefaultState(PrimitiveValue value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDefaultState_Public_ControlBuilder_PrimitiveValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011225, XrefRangeEnd = 1011227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControlBuilder UsingStateFrom(string path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsingStateFrom_Public_ControlBuilder_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			[CallerCount(0)]
			public unsafe ControlBuilder AsArrayOfControlsWithSize(int arraySize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&arraySize);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsArrayOfControlsWithSize_Public_ControlBuilder_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControlBuilder(pointer);
			}

			public ControlBuilder WithUsages(params InternedString[] usages)
			{
				return WithUsages(new Il2CppReferenceArray<InternedString>(usages));
			}

			public ControlBuilder WithUsages(params string[] usages)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected O, but got Unknown
				return this.WithUsages(new Il2CppStringArray(usages));
			}

			public ControlBuilder(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public ControlBuilder()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlBuilder>.NativeClassPtr))
			{
			}
		}

		private sealed class MethodInfoStoreGeneric_WithType_Public_Builder_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WithType_Public_Builder_0, Il2CppClassPointerStore<Builder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__name_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__displayName_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__type_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__stateFormat_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__stateSizeInBytes_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ExtendsLayout;

		private static readonly System.IntPtr NativeFieldInfoPtr__updateBeforeRender_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Controls;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_stateFormat_Public_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_stateFormat_Public_set_Void_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_stateSizeInBytes_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_extendsLayout_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_extendsLayout_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Nullable_1_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_updateBeforeRender_Public_set_Void_Nullable_1_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controls_Public_get_ReadOnlyArray_1_ControlItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddControl_Public_ControlBuilder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithName_Public_Builder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithDisplayName_Public_Builder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithType_Public_Builder_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithFormat_Public_Builder_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithFormat_Public_Builder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithSizeInBytes_Public_Builder_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Extend_Public_Builder_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_InputControlLayout_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string _name_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string _displayName_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppSystem.Type _type_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe FourCC _stateFormat_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateFormat_k__BackingField);
				return *(FourCC*)num;
			}
			set
			{
				*(FourCC*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateFormat_k__BackingField)) = value;
			}
		}

		public unsafe int _stateSizeInBytes_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateSizeInBytes_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateSizeInBytes_k__BackingField)) = value;
			}
		}

		public unsafe string m_ExtendsLayout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExtendsLayout);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExtendsLayout)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppSystem.Nullable<bool> _updateBeforeRender_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateBeforeRender_k__BackingField);
				return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__updateBeforeRender_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int m_ControlCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ControlCount)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<ControlItem> m_Controls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Controls);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControlItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Controls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string name
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe string displayName
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe Il2CppSystem.Type type
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe FourCC stateFormat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateFormat_Public_get_FourCC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 84616, RefRangeEnd = 84621, XrefRangeStart = 84616, XrefRangeEnd = 84621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stateFormat_Public_set_Void_FourCC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int stateSizeInBytes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stateSizeInBytes_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe string extendsLayout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_extendsLayout_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1011229, RefRangeEnd = 1011231, XrefRangeStart = 1011227, XrefRangeEnd = 1011229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_extendsLayout_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe Il2CppSystem.Nullable<bool> updateBeforeRender
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Il2CppSystem.Nullable<bool>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_updateBeforeRender_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ReadOnlyArray<ControlItem> controls
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1011234, RefRangeEnd = 1011235, XrefRangeStart = 1011231, XrefRangeEnd = 1011234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controls_Public_get_ReadOnlyArray_1_ControlItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<ControlItem>(pointer);
			}
		}

		static Builder()
		{
			Il2CppClassPointerStore<Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "Builder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Builder>.NativeClassPtr);
			NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "<name>k__BackingField");
			NativeFieldInfoPtr__displayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "<displayName>k__BackingField");
			NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "<type>k__BackingField");
			NativeFieldInfoPtr__stateFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "<stateFormat>k__BackingField");
			NativeFieldInfoPtr__stateSizeInBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "<stateSizeInBytes>k__BackingField");
			NativeFieldInfoPtr_m_ExtendsLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "m_ExtendsLayout");
			NativeFieldInfoPtr__updateBeforeRender_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "<updateBeforeRender>k__BackingField");
			NativeFieldInfoPtr_m_ControlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "m_ControlCount");
			NativeFieldInfoPtr_m_Controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Builder>.NativeClassPtr, "m_Controls");
			NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668176);
			NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668177);
			NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668178);
			NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668179);
			NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668180);
			NativeMethodInfoPtr_set_type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668181);
			NativeMethodInfoPtr_get_stateFormat_Public_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668182);
			NativeMethodInfoPtr_set_stateFormat_Public_set_Void_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668183);
			NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668184);
			NativeMethodInfoPtr_set_stateSizeInBytes_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668185);
			NativeMethodInfoPtr_get_extendsLayout_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668186);
			NativeMethodInfoPtr_set_extendsLayout_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668187);
			NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668188);
			NativeMethodInfoPtr_set_updateBeforeRender_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668189);
			NativeMethodInfoPtr_get_controls_Public_get_ReadOnlyArray_1_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668190);
			NativeMethodInfoPtr_AddControl_Public_ControlBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668191);
			NativeMethodInfoPtr_WithName_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668192);
			NativeMethodInfoPtr_WithDisplayName_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668193);
			NativeMethodInfoPtr_WithType_Public_Builder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668194);
			NativeMethodInfoPtr_WithFormat_Public_Builder_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668195);
			NativeMethodInfoPtr_WithFormat_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668196);
			NativeMethodInfoPtr_WithSizeInBytes_Public_Builder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668197);
			NativeMethodInfoPtr_Extend_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668198);
			NativeMethodInfoPtr_Build_Public_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668199);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Builder>.NativeClassPtr, 100668200);
		}

		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1011245, RefRangeEnd = 1011268, XrefRangeStart = 1011235, XrefRangeEnd = 1011245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlBuilder AddControl(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControl_Public_ControlBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlBuilder(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011268, XrefRangeEnd = 1011269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Builder WithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithName_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011269, XrefRangeEnd = 1011270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Builder WithDisplayName(string displayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithDisplayName_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011270, XrefRangeEnd = 1011275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Builder WithType<T>() where T : InputControl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WithType_Public_Builder_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe Builder WithFormat(FourCC format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&format);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithFormat_Public_Builder_FourCC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011275, XrefRangeEnd = 1011276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Builder WithFormat(string format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithFormat_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe Builder WithSizeInBytes(int sizeInBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&sizeInBytes);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithSizeInBytes_Public_Builder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011276, XrefRangeEnd = 1011278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Builder Extend(string baseLayoutName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseLayoutName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extend_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Builder>(intPtr2) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1011310, RefRangeEnd = 1011312, XrefRangeStart = 1011278, XrefRangeEnd = 1011310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		public unsafe Builder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Builder>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Builder(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.InputSystem.dll", "", "Flags")]
	[System.Flags]
	public enum Flags
	{
		IsGenericTypeOfDevice = 1,
		HideInUI = 2,
		IsOverride = 4,
		CanRunInBackground = 8,
		CanRunInBackgroundIsSet = 0x10,
		IsNoisy = 0x20
	}

	[System.Serializable]
	public sealed class LayoutJsonNameAndDescriptorOnly : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_extend;

		private static readonly System.IntPtr NativeFieldInfoPtr_extendMultiple;

		private static readonly System.IntPtr NativeFieldInfoPtr_device;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string extend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extend);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extend)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppStringArray extendMultiple
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendMultiple);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendMultiple)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe InputDeviceMatcher.MatcherJson device
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device);
				return new InputDeviceMatcher.MatcherJson(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceMatcher.MatcherJson>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceMatcher.MatcherJson>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static LayoutJsonNameAndDescriptorOnly()
		{
			Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "LayoutJsonNameAndDescriptorOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr, "name");
			NativeFieldInfoPtr_extend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr, "extend");
			NativeFieldInfoPtr_extendMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr, "extendMultiple");
			NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr, "device");
		}

		public LayoutJsonNameAndDescriptorOnly(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public LayoutJsonNameAndDescriptorOnly()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutJsonNameAndDescriptorOnly>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class LayoutJson : Il2CppSystem.ValueType
	{
		[System.Serializable]
		[ObfuscatedName("UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ToLayout_b__14_0_Internal_InternedString_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FromLayout_b__15_0_Internal_String_InternedString_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FromLayout_b__15_1_Internal_String_InternedString_0;

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

			public unsafe static Il2CppSystem.Func<string, InternedString> __9__14_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<InternedString, string> __9__15_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InternedString, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<InternedString, string> __9__15_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InternedString, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_0");
				NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_0");
				NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_1");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668226);
				NativeMethodInfoPtr__ToLayout_b__14_0_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668227);
				NativeMethodInfoPtr__FromLayout_b__15_0_Internal_String_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668228);
				NativeMethodInfoPtr__FromLayout_b__15_1_Internal_String_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668229);
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternedString _ToLayout_b__14_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ToLayout_b__14_0_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InternedString(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FromLayout_b__15_0(InternedString x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromLayout_b__15_0_Internal_String_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FromLayout_b__15_1(InternedString x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromLayout_b__15_1_Internal_String_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_extend;

		private static readonly System.IntPtr NativeFieldInfoPtr_extendMultiple;

		private static readonly System.IntPtr NativeFieldInfoPtr_format;

		private static readonly System.IntPtr NativeFieldInfoPtr_beforeRender;

		private static readonly System.IntPtr NativeFieldInfoPtr_runInBackground;

		private static readonly System.IntPtr NativeFieldInfoPtr_commonUsages;

		private static readonly System.IntPtr NativeFieldInfoPtr_displayName;

		private static readonly System.IntPtr NativeFieldInfoPtr_description;

		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_variant;

		private static readonly System.IntPtr NativeFieldInfoPtr_isGenericTypeOfDevice;

		private static readonly System.IntPtr NativeFieldInfoPtr_hideInUI;

		private static readonly System.IntPtr NativeFieldInfoPtr_controls;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToLayout_Public_InputControlLayout_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FromLayout_Public_Static_LayoutJson_InputControlLayout_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string extend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extend);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extend)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppStringArray extendMultiple
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendMultiple);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendMultiple)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string format
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string beforeRender
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beforeRender);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beforeRender)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string runInBackground
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runInBackground);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runInBackground)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppStringArray commonUsages
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonUsages);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonUsages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

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

		public unsafe string description
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string variant
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variant);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variant)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe bool isGenericTypeOfDevice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGenericTypeOfDevice);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGenericTypeOfDevice)) = value;
			}
		}

		public unsafe bool hideInUI
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideInUI);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideInUI)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<ControlItemJson> controls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controls);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControlItemJson>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static LayoutJson()
		{
			Il2CppClassPointerStore<LayoutJson>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "LayoutJson");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "name");
			NativeFieldInfoPtr_extend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "extend");
			NativeFieldInfoPtr_extendMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "extendMultiple");
			NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "format");
			NativeFieldInfoPtr_beforeRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "beforeRender");
			NativeFieldInfoPtr_runInBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "runInBackground");
			NativeFieldInfoPtr_commonUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "commonUsages");
			NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "displayName");
			NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "description");
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "type");
			NativeFieldInfoPtr_variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "variant");
			NativeFieldInfoPtr_isGenericTypeOfDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "isGenericTypeOfDevice");
			NativeFieldInfoPtr_hideInUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "hideInUI");
			NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, "controls");
			NativeMethodInfoPtr_ToLayout_Public_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, 100668223);
			NativeMethodInfoPtr_FromLayout_Public_Static_LayoutJson_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr, 100668224);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011434, RefRangeEnd = 1011435, XrefRangeStart = 1011312, XrefRangeEnd = 1011434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlLayout ToLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLayout_Public_InputControlLayout_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011499, RefRangeEnd = 1011500, XrefRangeStart = 1011435, XrefRangeEnd = 1011499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LayoutJson FromLayout(InputControlLayout layout)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromLayout_Public_Static_LayoutJson_InputControlLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new LayoutJson(pointer);
		}

		public LayoutJson(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public LayoutJson()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutJson>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public class ControlItemJson : Il2CppSystem.Object
	{
		[System.Serializable]
		[ObfuscatedName("UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_1;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__25_1;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__25_2;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__25_3;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ToLayout_b__24_0_Internal_InternedString_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ToLayout_b__24_1_Internal_InternedString_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FromControlItems_b__25_0_Internal_String_NamedValue_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FromControlItems_b__25_1_Internal_String_NameAndParameters_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FromControlItems_b__25_2_Internal_String_InternedString_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FromControlItems_b__25_3_Internal_String_InternedString_0;

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

			public unsafe static Il2CppSystem.Func<string, InternedString> __9__24_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<string, InternedString> __9__24_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<NamedValue, string> __9__25_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NamedValue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<NameAndParameters, string> __9__25_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NameAndParameters, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<InternedString, string> __9__25_2
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InternedString, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static Il2CppSystem.Func<InternedString, string> __9__25_3
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InternedString, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_0");
				NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_1");
				NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_0");
				NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_1");
				NativeFieldInfoPtr___9__25_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_2");
				NativeFieldInfoPtr___9__25_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_3");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668234);
				NativeMethodInfoPtr__ToLayout_b__24_0_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668235);
				NativeMethodInfoPtr__ToLayout_b__24_1_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668236);
				NativeMethodInfoPtr__FromControlItems_b__25_0_Internal_String_NamedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668237);
				NativeMethodInfoPtr__FromControlItems_b__25_1_Internal_String_NameAndParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668238);
				NativeMethodInfoPtr__FromControlItems_b__25_2_Internal_String_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668239);
				NativeMethodInfoPtr__FromControlItems_b__25_3_Internal_String_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668240);
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternedString _ToLayout_b__24_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ToLayout_b__24_0_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InternedString(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternedString _ToLayout_b__24_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ToLayout_b__24_1_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new InternedString(pointer);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011500, XrefRangeEnd = 1011501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FromControlItems_b__25_0(NamedValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromControlItems_b__25_0_Internal_String_NamedValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011501, XrefRangeEnd = 1011502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FromControlItems_b__25_1(NameAndParameters x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromControlItems_b__25_1_Internal_String_NameAndParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FromControlItems_b__25_2(InternedString x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromControlItems_b__25_2_Internal_String_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FromControlItems_b__25_3(InternedString x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromControlItems_b__25_3_Internal_String_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_layout;

		private static readonly System.IntPtr NativeFieldInfoPtr_variants;

		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeFieldInfoPtr_alias;

		private static readonly System.IntPtr NativeFieldInfoPtr_useStateFrom;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_bit;

		private static readonly System.IntPtr NativeFieldInfoPtr_sizeInBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_format;

		private static readonly System.IntPtr NativeFieldInfoPtr_arraySize;

		private static readonly System.IntPtr NativeFieldInfoPtr_usages;

		private static readonly System.IntPtr NativeFieldInfoPtr_aliases;

		private static readonly System.IntPtr NativeFieldInfoPtr_parameters;

		private static readonly System.IntPtr NativeFieldInfoPtr_processors;

		private static readonly System.IntPtr NativeFieldInfoPtr_displayName;

		private static readonly System.IntPtr NativeFieldInfoPtr_shortDisplayName;

		private static readonly System.IntPtr NativeFieldInfoPtr_noisy;

		private static readonly System.IntPtr NativeFieldInfoPtr_dontReset;

		private static readonly System.IntPtr NativeFieldInfoPtr_synthetic;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultState;

		private static readonly System.IntPtr NativeFieldInfoPtr_minValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxValue;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToLayout_Public_ControlItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FromControlItems_Public_Static_Il2CppReferenceArray_1_ControlItemJson_Il2CppReferenceArray_1_ControlItem_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string layout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string variants
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variants);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variants)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string usage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string alias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alias);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alias)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string useStateFrom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStateFrom);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStateFrom)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe uint offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = value;
			}
		}

		public unsafe uint bit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bit);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bit)) = value;
			}
		}

		public unsafe uint sizeInBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeInBits);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeInBits)) = value;
			}
		}

		public unsafe string format
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int arraySize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arraySize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arraySize)) = value;
			}
		}

		public unsafe Il2CppStringArray usages
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usages);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStringArray aliases
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aliases);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aliases)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string parameters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameters);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameters)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string processors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processors);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processors)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

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

		public unsafe string shortDisplayName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortDisplayName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortDisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe bool noisy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noisy);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noisy)) = value;
			}
		}

		public unsafe bool dontReset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontReset);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontReset)) = value;
			}
		}

		public unsafe bool synthetic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_synthetic);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_synthetic)) = value;
			}
		}

		public unsafe string defaultState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultState);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultState)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string minValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minValue);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minValue)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string maxValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxValue);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxValue)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static ControlItemJson()
		{
			Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "ControlItemJson");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "name");
			NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "layout");
			NativeFieldInfoPtr_variants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "variants");
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "usage");
			NativeFieldInfoPtr_alias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "alias");
			NativeFieldInfoPtr_useStateFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "useStateFrom");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_bit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "bit");
			NativeFieldInfoPtr_sizeInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "sizeInBits");
			NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "format");
			NativeFieldInfoPtr_arraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "arraySize");
			NativeFieldInfoPtr_usages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "usages");
			NativeFieldInfoPtr_aliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "aliases");
			NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "parameters");
			NativeFieldInfoPtr_processors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "processors");
			NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "displayName");
			NativeFieldInfoPtr_shortDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "shortDisplayName");
			NativeFieldInfoPtr_noisy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "noisy");
			NativeFieldInfoPtr_dontReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "dontReset");
			NativeFieldInfoPtr_synthetic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "synthetic");
			NativeFieldInfoPtr_defaultState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "defaultState");
			NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "minValue");
			NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, "maxValue");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, 100668230);
			NativeMethodInfoPtr_ToLayout_Public_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, 100668231);
			NativeMethodInfoPtr_FromControlItems_Public_Static_Il2CppReferenceArray_1_ControlItemJson_Il2CppReferenceArray_1_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr, 100668232);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011502, XrefRangeEnd = 1011503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlItemJson()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlItemJson>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011608, RefRangeEnd = 1011609, XrefRangeStart = 1011503, XrefRangeEnd = 1011608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlItem ToLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLayout_Public_ControlItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlItem(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011731, RefRangeEnd = 1011732, XrefRangeStart = 1011609, XrefRangeEnd = 1011731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ControlItemJson> FromControlItems(Il2CppReferenceArray<ControlItem> items)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromControlItems_Public_Static_Il2CppReferenceArray_1_ControlItemJson_Il2CppReferenceArray_1_ControlItem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControlItemJson>>(intPtr2) : null;
		}

		public ControlItemJson(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class Collection : Il2CppSystem.ValueType
	{
		public sealed class LayoutMatcher : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_layoutName;

			private static readonly System.IntPtr NativeFieldInfoPtr_deviceMatcher;

			public unsafe InternedString layoutName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutName);
					return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe InputDeviceMatcher deviceMatcher
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceMatcher);
					return new InputDeviceMatcher(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceMatcher), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, ref *(uint*)null));
				}
			}

			static LayoutMatcher()
			{
				Il2CppClassPointerStore<LayoutMatcher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Collection>.NativeClassPtr, "LayoutMatcher");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutMatcher>.NativeClassPtr);
				NativeFieldInfoPtr_layoutName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutMatcher>.NativeClassPtr, "layoutName");
				NativeFieldInfoPtr_deviceMatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutMatcher>.NativeClassPtr, "deviceMatcher");
			}

			public LayoutMatcher(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public LayoutMatcher()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutMatcher>.NativeClassPtr))
			{
			}
		}

		public sealed class PrecompiledLayout : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_factoryMethod;

			private static readonly System.IntPtr NativeFieldInfoPtr_metadata;

			public unsafe Il2CppSystem.Func<InputDevice> factoryMethod
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factoryMethod);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InputDevice>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factoryMethod)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe string metadata
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metadata);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metadata)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			static PrecompiledLayout()
			{
				Il2CppClassPointerStore<PrecompiledLayout>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Collection>.NativeClassPtr, "PrecompiledLayout");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrecompiledLayout>.NativeClassPtr);
				NativeFieldInfoPtr_factoryMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrecompiledLayout>.NativeClassPtr, "factoryMethod");
				NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrecompiledLayout>.NativeClassPtr, "metadata");
			}

			public PrecompiledLayout(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public PrecompiledLayout()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrecompiledLayout>.NativeClassPtr))
			{
			}
		}

		[ObfuscatedName("UnityEngine.InputSystem.Layouts.InputControlLayout+Collection+<GetBaseLayouts>d__24")]
		public sealed class _GetBaseLayouts_d__24 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;

			private static readonly System.IntPtr NativeFieldInfoPtr_includeSelf;

			private static readonly System.IntPtr NativeFieldInfoPtr___3__includeSelf;

			private static readonly System.IntPtr NativeFieldInfoPtr_layout;

			private static readonly System.IntPtr NativeFieldInfoPtr___3__layout;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeFieldInfoPtr___3____4__this;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_Utilities_InternedString__get_Current_Private_Virtual_Final_New_get_InternedString_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_Utilities_InternedString__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InternedString_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			public unsafe int __1__state
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = value;
				}
			}

			public unsafe InternedString __2__current
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
					return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe int __l__initialThreadId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			public unsafe bool includeSelf
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeSelf);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeSelf)) = value;
				}
			}

			public unsafe bool __3__includeSelf
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__includeSelf);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__includeSelf)) = value;
				}
			}

			public unsafe InternedString layout
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout);
					return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe InternedString __3__layout
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__layout);
					return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__layout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe Collection __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					return new Collection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Collection>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Collection>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe Collection __3____4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3____4__this);
					return new Collection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Collection>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Collection>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe virtual InternedString System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EInputSystem_002EUtilities_002EInternedString_003E_002ECurrent
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_Utilities_InternedString__get_Current_Private_Virtual_Final_New_get_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new InternedString(pointer);
				}
			}

			public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011738, XrefRangeEnd = 1011741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			static _GetBaseLayouts_d__24()
			{
				Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Collection>.NativeClassPtr, "<GetBaseLayouts>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr);
				NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>1__state");
				NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>2__current");
				NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>l__initialThreadId");
				NativeFieldInfoPtr_includeSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "includeSelf");
				NativeFieldInfoPtr___3__includeSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>3__includeSelf");
				NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "layout");
				NativeFieldInfoPtr___3__layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>3__layout");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>4__this");
				NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, "<>3__<>4__this");
				NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668257);
				NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668258);
				NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668259);
				NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_Utilities_InternedString__get_Current_Private_Virtual_Final_New_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668260);
				NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668261);
				NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668262);
				NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_Utilities_InternedString__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668263);
				NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr, 100668264);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 860099, RefRangeEnd = 860102, XrefRangeStart = 860099, XrefRangeEnd = 860102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetBaseLayouts_d__24(int _003C_003E1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GetBaseLayouts_d__24>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&_003C_003E1__state);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(19883)]
			[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011732, XrefRangeEnd = 1011733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011733, XrefRangeEnd = 1011738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011741, XrefRangeEnd = 1011750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<InternedString> System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_Utilities_InternedString__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_Utilities_InternedString__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<InternedString>>(intPtr2) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			public _GetBaseLayouts_d__24(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_kBaseScoreForNonGeneratedLayouts;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutTypes;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutStrings;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutBuilders;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseLayoutTable;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutOverrides;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutOverrideNames;

		private static readonly System.IntPtr NativeFieldInfoPtr_precompiledLayouts;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutMatchers;

		private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryFindLayoutForType_Public_InternedString_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryFindMatchingLayout_Public_InternedString_InputDeviceDescription_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HasLayout_Public_Boolean_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadLayoutInternal_Private_InputControlLayout_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadLayout_Public_InputControlLayout_InternedString_Dictionary_2_InternedString_InputControlLayout_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseLayoutName_Public_InternedString_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRootLayoutName_Public_InternedString_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDistanceInInheritanceHierarchy_Public_Boolean_InternedString_InternedString_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindLayoutThatIntroducesControl_Public_InternedString_InputControl_Cache_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetControlTypeForLayout_Public_Type_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ValueTypeIsAssignableFrom_Public_Boolean_InternedString_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsGeneratedLayout_Public_Boolean_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseLayouts_Public_IEnumerable_1_InternedString_InternedString_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsBasedOn_Public_Boolean_InternedString_InternedString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddMatcher_Public_Void_InternedString_InputDeviceMatcher_0;

		public unsafe static float kBaseScoreForNonGeneratedLayouts
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kBaseScoreForNonGeneratedLayouts, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kBaseScoreForNonGeneratedLayouts, (void*)(&value));
			}
		}

		public unsafe Dictionary<InternedString, Il2CppSystem.Type> layoutTypes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutTypes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, Il2CppSystem.Type>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Dictionary<InternedString, string> layoutStrings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutStrings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Dictionary<InternedString, Il2CppSystem.Func<InputControlLayout>> layoutBuilders
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutBuilders);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, Il2CppSystem.Func<InputControlLayout>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutBuilders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Dictionary<InternedString, InternedString> baseLayoutTable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLayoutTable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, InternedString>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLayoutTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Dictionary<InternedString, Il2CppReferenceArray<InternedString>> layoutOverrides
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutOverrides);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, Il2CppReferenceArray<InternedString>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe HashSet<InternedString> layoutOverrideNames
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutOverrideNames);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InternedString>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutOverrideNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Dictionary<InternedString, PrecompiledLayout> precompiledLayouts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_precompiledLayouts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, PrecompiledLayout>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_precompiledLayouts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<LayoutMatcher> layoutMatchers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutMatchers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LayoutMatcher>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutMatchers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Collection()
		{
			Il2CppClassPointerStore<Collection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "Collection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collection>.NativeClassPtr);
			NativeFieldInfoPtr_kBaseScoreForNonGeneratedLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "kBaseScoreForNonGeneratedLayouts");
			NativeFieldInfoPtr_layoutTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "layoutTypes");
			NativeFieldInfoPtr_layoutStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "layoutStrings");
			NativeFieldInfoPtr_layoutBuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "layoutBuilders");
			NativeFieldInfoPtr_baseLayoutTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "baseLayoutTable");
			NativeFieldInfoPtr_layoutOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "layoutOverrides");
			NativeFieldInfoPtr_layoutOverrideNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "layoutOverrideNames");
			NativeFieldInfoPtr_precompiledLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "precompiledLayouts");
			NativeFieldInfoPtr_layoutMatchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection>.NativeClassPtr, "layoutMatchers");
			NativeMethodInfoPtr_Allocate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668241);
			NativeMethodInfoPtr_TryFindLayoutForType_Public_InternedString_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668242);
			NativeMethodInfoPtr_TryFindMatchingLayout_Public_InternedString_InputDeviceDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668243);
			NativeMethodInfoPtr_HasLayout_Public_Boolean_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668244);
			NativeMethodInfoPtr_TryLoadLayoutInternal_Private_InputControlLayout_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668245);
			NativeMethodInfoPtr_TryLoadLayout_Public_InputControlLayout_InternedString_Dictionary_2_InternedString_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668246);
			NativeMethodInfoPtr_GetBaseLayoutName_Public_InternedString_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668247);
			NativeMethodInfoPtr_GetRootLayoutName_Public_InternedString_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668248);
			NativeMethodInfoPtr_ComputeDistanceInInheritanceHierarchy_Public_Boolean_InternedString_InternedString_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668249);
			NativeMethodInfoPtr_FindLayoutThatIntroducesControl_Public_InternedString_InputControl_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668250);
			NativeMethodInfoPtr_GetControlTypeForLayout_Public_Type_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668251);
			NativeMethodInfoPtr_ValueTypeIsAssignableFrom_Public_Boolean_InternedString_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668252);
			NativeMethodInfoPtr_IsGeneratedLayout_Public_Boolean_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668253);
			NativeMethodInfoPtr_GetBaseLayouts_Public_IEnumerable_1_InternedString_InternedString_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668254);
			NativeMethodInfoPtr_IsBasedOn_Public_Boolean_InternedString_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668255);
			NativeMethodInfoPtr_AddMatcher_Public_Void_InternedString_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection>.NativeClassPtr, 100668256);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011806, RefRangeEnd = 1011807, XrefRangeStart = 1011750, XrefRangeEnd = 1011806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Allocate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Allocate_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1011822, RefRangeEnd = 1011830, XrefRangeStart = 1011807, XrefRangeEnd = 1011822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString TryFindLayoutForType(Il2CppSystem.Type layoutType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutType);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindLayoutForType_Public_InternedString_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011845, RefRangeEnd = 1011846, XrefRangeStart = 1011830, XrefRangeEnd = 1011845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deviceDescription));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindMatchingLayout_Public_InternedString_InputDeviceDescription_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1011855, RefRangeEnd = 1011861, XrefRangeStart = 1011846, XrefRangeEnd = 1011855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLayout(InternedString name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasLayout_Public_Boolean_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011871, RefRangeEnd = 1011872, XrefRangeStart = 1011861, XrefRangeEnd = 1011871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlLayout TryLoadLayoutInternal(InternedString name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLoadLayoutInternal_Private_InputControlLayout_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1011904, RefRangeEnd = 1011910, XrefRangeStart = 1011872, XrefRangeEnd = 1011904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)table);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLoadLayout_Public_InputControlLayout_InternedString_Dictionary_2_InternedString_InputControlLayout_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011910, XrefRangeEnd = 1011913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString GetBaseLayoutName(InternedString layoutName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layoutName));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseLayoutName_Public_InternedString_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011913, XrefRangeEnd = 1011917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString GetRootLayoutName(InternedString layoutName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layoutName));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootLayoutName_Public_InternedString_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011933, RefRangeEnd = 1011934, XrefRangeStart = 1011917, XrefRangeEnd = 1011933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)firstLayout));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)secondLayout));
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDistanceInInheritanceHierarchy_Public_Boolean_InternedString_InternedString_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1011943, RefRangeEnd = 1011944, XrefRangeStart = 1011934, XrefRangeEnd = 1011943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cache));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLayoutThatIntroducesControl_Public_InternedString_InputControl_Cache_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1011957, RefRangeEnd = 1011959, XrefRangeStart = 1011944, XrefRangeEnd = 1011957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Type GetControlTypeForLayout(InternedString layoutName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layoutName));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlTypeForLayout_Public_Type_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011959, XrefRangeEnd = 1011970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValueTypeIsAssignableFrom(InternedString layoutName, Il2CppSystem.Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layoutName));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)valueType);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValueTypeIsAssignableFrom_Public_Boolean_InternedString_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1011973, RefRangeEnd = 1011975, XrefRangeStart = 1011970, XrefRangeEnd = 1011973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGeneratedLayout(InternedString layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGeneratedLayout_Public_Boolean_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011975, XrefRangeEnd = 1011981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSelf;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseLayouts_Public_IEnumerable_1_InternedString_InternedString_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InternedString>>(intPtr2) : null;
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1011986, RefRangeEnd = 1011992, XrefRangeStart = 1011981, XrefRangeEnd = 1011986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBasedOn(InternedString parentLayout, InternedString childLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parentLayout));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)childLayout));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBasedOn_Public_Boolean_InternedString_InternedString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012005, RefRangeEnd = 1012006, XrefRangeStart = 1011992, XrefRangeEnd = 1012005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMatcher(InternedString layout, InputDeviceMatcher matcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)layout));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matcher));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMatcher_Public_Void_InternedString_InputDeviceMatcher_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Collection(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Collection()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collection>.NativeClassPtr))
		{
		}
	}

	public class LayoutNotFoundException : Il2CppSystem.Exception
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__layout_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_layout_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		public unsafe string _layout_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layout_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layout_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string layout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layout_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		static LayoutNotFoundException()
		{
			Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "LayoutNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr);
			NativeFieldInfoPtr__layout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, "<layout>k__BackingField");
			NativeMethodInfoPtr_get_layout_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, 100668265);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, 100668266);
			NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, 100668267);
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, 100668268);
			NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, 100668269);
			NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr, 100668270);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012006, XrefRangeEnd = 1012010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012010, XrefRangeEnd = 1012015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutNotFoundException(string name, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012015, XrefRangeEnd = 1012025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutNotFoundException(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012025, XrefRangeEnd = 1012029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutNotFoundException(string message, Il2CppSystem.Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerException);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012029, XrefRangeEnd = 1012033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutNotFoundException>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LayoutNotFoundException(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class Cache : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_table;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindOrLoadLayout_Public_InputControlLayout_String_Boolean_0;

		public unsafe Dictionary<InternedString, InputControlLayout> table
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_table);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InternedString, InputControlLayout>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_table)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Cache()
		{
			Il2CppClassPointerStore<Cache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "Cache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cache>.NativeClassPtr);
			NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cache>.NativeClassPtr, "table");
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100668271);
			NativeMethodInfoPtr_FindOrLoadLayout_Public_InputControlLayout_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100668272);
		}

		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 843220, RefRangeEnd = 843271, XrefRangeStart = 843220, XrefRangeEnd = 843271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1012057, RefRangeEnd = 1012064, XrefRangeStart = 1012033, XrefRangeEnd = 1012057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwIfNotFound;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindOrLoadLayout_Public_InputControlLayout_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
		}

		public Cache(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Cache()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cache>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct CacheRefInstance
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_valid;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool valid;

		static CacheRefInstance()
		{
			Il2CppClassPointerStore<CacheRefInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "CacheRefInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheRefInstance>.NativeClassPtr);
			NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheRefInstance>.NativeClassPtr, "valid");
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheRefInstance>.NativeClassPtr, 100668273);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1012072, RefRangeEnd = 1012080, XrefRangeStart = 1012064, XrefRangeEnd = 1012072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CacheRefInstance>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.InputSystem.Layouts.InputControlLayout+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__52_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__75_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__75_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FromType_b__52_0_Internal_InternedString_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateControlItemFromMember_b__75_0_Internal_InternedString_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateControlItemFromMember_b__75_1_Internal_InternedString_String_0;

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

		public unsafe static Il2CppSystem.Func<string, InternedString> __9__52_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__52_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<string, InternedString> __9__75_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__75_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__75_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<string, InternedString> __9__75_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__75_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, InternedString>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__75_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__52_0");
			NativeFieldInfoPtr___9__75_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__75_0");
			NativeFieldInfoPtr___9__75_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__75_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668275);
			NativeMethodInfoPtr__FromType_b__52_0_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668276);
			NativeMethodInfoPtr__CreateControlItemFromMember_b__75_0_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668277);
			NativeMethodInfoPtr__CreateControlItemFromMember_b__75_1_Internal_InternedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668278);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString _FromType_b__52_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FromType_b__52_0_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString _CreateControlItemFromMember_b__75_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateControlItemFromMember_b__75_0_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternedString _CreateControlItemFromMember_b__75_1(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateControlItemFromMember_b__75_1_Internal_InternedString_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultVariant;

	private static readonly System.IntPtr NativeFieldInfoPtr_VariantSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Variants;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateSizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateBeforeRender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaseLayouts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AppliedOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CommonUsages;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Controls;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Layouts;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CacheInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CacheInstanceRef;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultVariant_Public_Static_get_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_variants_Public_get_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stateFormat_Public_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseLayouts_Public_get_IEnumerable_1_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_appliedOverrides_Public_get_IEnumerable_1_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_commonUsages_Public_get_ReadOnlyArray_1_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controls_Public_get_ReadOnlyArray_1_ControlItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDeviceLayout_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isControlLayout_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOverride_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isOverride_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isGenericTypeOfDevice_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isGenericTypeOfDevice_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hideInUI_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hideInUI_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isNoisy_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isNoisy_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canRunInBackground_Public_get_Nullable_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_canRunInBackground_Internal_set_Void_Nullable_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_ControlItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControl_Public_Nullable_1_ControlItem_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControlIncludingArrayElements_Public_Nullable_1_ControlItem_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueType_Public_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromType_Public_Static_InputControlLayout_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJson_Public_Static_InputControlLayout_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlItems_Private_Static_Void_Type_List_1_ControlItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlItemsFromFields_Private_Static_Void_Type_List_1_ControlItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlItemsFromProperties_Private_Static_Void_Type_List_1_ControlItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlItemsFromMembers_Private_Static_Void_Il2CppReferenceArray_1_MemberInfo_List_1_ControlItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddControlItemsFromMember_Private_Static_Void_MemberInfo_Il2CppReferenceArray_1_InputControlAttribute_List_1_ControlItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateControlItemFromMember_Private_Static_ControlItem_MemberInfo_InputControlAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InferLayoutFromValueType_Private_Static_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeLayout_Public_Void_InputControlLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLookupTableForControls_Private_Static_Dictionary_2_String_ControlItem_Il2CppReferenceArray_1_ControlItem_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VariantsMatch_Internal_Static_Boolean_InternedString_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VariantsMatch_Internal_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseHeaderFieldsFromJson_Internal_Static_Void_String_byref_InternedString_byref_InlinedArray_1_InternedString_byref_InputDeviceMatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cache_Internal_Static_get_byref_Cache_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheRef_Internal_Static_CacheRefInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__MergeLayout_b__77_0_Private_Boolean_ControlItem_0;

	public unsafe static InternedString s_DefaultVariant
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultVariant, (void*)intPtr);
			return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultVariant, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static string VariantSeparator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VariantSeparator, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VariantSeparator, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe InternedString m_Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name);
			return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Type m_Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Type);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Type)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InternedString m_Variants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Variants);
			return new InternedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InternedString>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Variants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InternedString>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe FourCC m_StateFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateFormat);
			return *(FourCC*)num;
		}
		set
		{
			*(FourCC*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateFormat)) = value;
		}
	}

	public unsafe int m_StateSizeInBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateSizeInBytes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StateSizeInBytes)) = value;
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> m_UpdateBeforeRender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateBeforeRender);
			return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateBeforeRender), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InlinedArray<InternedString> m_BaseLayouts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BaseLayouts);
			return new InlinedArray<InternedString>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<InternedString>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BaseLayouts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<InternedString>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InlinedArray<InternedString> m_AppliedOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AppliedOverrides);
			return new InlinedArray<InternedString>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<InternedString>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AppliedOverrides), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<InternedString>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppReferenceArray<InternedString> m_CommonUsages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommonUsages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternedString>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommonUsages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<ControlItem> m_Controls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Controls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControlItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Controls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_DisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Description)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Flags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(Flags*)num;
		}
		set
		{
			*(Flags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	public unsafe static Collection s_Layouts
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Collection>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Layouts, (void*)intPtr);
			return new Collection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Collection>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Layouts, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static Cache s_CacheInstance
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Cache>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CacheInstance, (void*)intPtr);
			return new Cache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cache>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CacheInstance, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static int s_CacheInstanceRef
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CacheInstanceRef, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CacheInstanceRef, (void*)(&value));
		}
	}

	public unsafe static InternedString DefaultVariant
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012080, XrefRangeEnd = 1012084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultVariant_Public_Static_get_InternedString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}
	}

	public unsafe InternedString name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739711, RefRangeEnd = 739712, XrefRangeStart = 739711, XrefRangeEnd = 739712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}
	}

	public unsafe string displayName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012084, XrefRangeEnd = 1012085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Type type
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
	}

	public unsafe InternedString variants
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_variants_Public_get_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InternedString(pointer);
		}
	}

	public unsafe FourCC stateFormat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateFormat_Public_get_FourCC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int stateSizeInBytes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe IEnumerable<InternedString> baseLayouts
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012085, XrefRangeEnd = 1012088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseLayouts_Public_get_IEnumerable_1_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InternedString>>(intPtr2) : null;
		}
	}

	public unsafe IEnumerable<InternedString> appliedOverrides
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012088, XrefRangeEnd = 1012091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_appliedOverrides_Public_get_IEnumerable_1_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InternedString>>(intPtr2) : null;
		}
	}

	public unsafe ReadOnlyArray<InternedString> commonUsages
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012091, XrefRangeEnd = 1012094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_commonUsages_Public_get_ReadOnlyArray_1_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<InternedString>(pointer);
		}
	}

	public unsafe ReadOnlyArray<ControlItem> controls
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012097, RefRangeEnd = 1012099, XrefRangeStart = 1012094, XrefRangeEnd = 1012097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controls_Public_get_ReadOnlyArray_1_ControlItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<ControlItem>(pointer);
		}
	}

	public unsafe bool updateBeforeRender
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012099, XrefRangeEnd = 1012100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isDeviceLayout
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012100, XrefRangeEnd = 1012106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDeviceLayout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isControlLayout
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012106, XrefRangeEnd = 1012111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isControlLayout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isOverride
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012111, RefRangeEnd = 1012112, XrefRangeStart = 1012111, XrefRangeEnd = 1012111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isOverride_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isGenericTypeOfDevice
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isGenericTypeOfDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isGenericTypeOfDevice_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hideInUI
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hideInUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hideInUI_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isNoisy
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012112, RefRangeEnd = 1012113, XrefRangeStart = 1012112, XrefRangeEnd = 1012112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isNoisy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isNoisy_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> canRunInBackground
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012116, RefRangeEnd = 1012118, XrefRangeStart = 1012113, XrefRangeEnd = 1012116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canRunInBackground_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<bool>(pointer);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012122, RefRangeEnd = 1012124, XrefRangeStart = 1012118, XrefRangeEnd = 1012122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_canRunInBackground_Internal_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ControlItem this[string path]
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012124, XrefRangeEnd = 1012128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_ControlItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ControlItem(pointer);
		}
	}

	public unsafe static ref Cache cache
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1012757, RefRangeEnd = 1012763, XrefRangeStart = 1012753, XrefRangeEnd = 1012757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cache_Internal_Static_get_byref_Cache_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Cache*)intPtr2;
		}
	}

	static InputControlLayout()
	{
		Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Layouts", "InputControlLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr);
		NativeFieldInfoPtr_s_DefaultVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "s_DefaultVariant");
		NativeFieldInfoPtr_VariantSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "VariantSeparator");
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_Type");
		NativeFieldInfoPtr_m_Variants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_Variants");
		NativeFieldInfoPtr_m_StateFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_StateFormat");
		NativeFieldInfoPtr_m_StateSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_StateSizeInBytes");
		NativeFieldInfoPtr_m_UpdateBeforeRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_UpdateBeforeRender");
		NativeFieldInfoPtr_m_BaseLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_BaseLayouts");
		NativeFieldInfoPtr_m_AppliedOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_AppliedOverrides");
		NativeFieldInfoPtr_m_CommonUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_CommonUsages");
		NativeFieldInfoPtr_m_Controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_Controls");
		NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_DisplayName");
		NativeFieldInfoPtr_m_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_Description");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_s_Layouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "s_Layouts");
		NativeFieldInfoPtr_s_CacheInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "s_CacheInstance");
		NativeFieldInfoPtr_s_CacheInstanceRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, "s_CacheInstanceRef");
		NativeMethodInfoPtr_get_DefaultVariant_Public_Static_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668078);
		NativeMethodInfoPtr_get_name_Public_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668079);
		NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668080);
		NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668081);
		NativeMethodInfoPtr_get_variants_Public_get_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668082);
		NativeMethodInfoPtr_get_stateFormat_Public_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668083);
		NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668084);
		NativeMethodInfoPtr_get_baseLayouts_Public_get_IEnumerable_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668085);
		NativeMethodInfoPtr_get_appliedOverrides_Public_get_IEnumerable_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668086);
		NativeMethodInfoPtr_get_commonUsages_Public_get_ReadOnlyArray_1_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668087);
		NativeMethodInfoPtr_get_controls_Public_get_ReadOnlyArray_1_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668088);
		NativeMethodInfoPtr_get_updateBeforeRender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668089);
		NativeMethodInfoPtr_get_isDeviceLayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668090);
		NativeMethodInfoPtr_get_isControlLayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668091);
		NativeMethodInfoPtr_get_isOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668092);
		NativeMethodInfoPtr_set_isOverride_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668093);
		NativeMethodInfoPtr_get_isGenericTypeOfDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668094);
		NativeMethodInfoPtr_set_isGenericTypeOfDevice_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668095);
		NativeMethodInfoPtr_get_hideInUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668096);
		NativeMethodInfoPtr_set_hideInUI_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668097);
		NativeMethodInfoPtr_get_isNoisy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668098);
		NativeMethodInfoPtr_set_isNoisy_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668099);
		NativeMethodInfoPtr_get_canRunInBackground_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668100);
		NativeMethodInfoPtr_set_canRunInBackground_Internal_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668101);
		NativeMethodInfoPtr_get_Item_Public_get_ControlItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668102);
		NativeMethodInfoPtr_FindControl_Public_Nullable_1_ControlItem_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668103);
		NativeMethodInfoPtr_FindControlIncludingArrayElements_Public_Nullable_1_ControlItem_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668104);
		NativeMethodInfoPtr_GetValueType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668105);
		NativeMethodInfoPtr_FromType_Public_Static_InputControlLayout_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668106);
		NativeMethodInfoPtr_ToJson_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668107);
		NativeMethodInfoPtr_FromJson_Public_Static_InputControlLayout_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668108);
		NativeMethodInfoPtr__ctor_Private_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668109);
		NativeMethodInfoPtr_AddControlItems_Private_Static_Void_Type_List_1_ControlItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668110);
		NativeMethodInfoPtr_AddControlItemsFromFields_Private_Static_Void_Type_List_1_ControlItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668111);
		NativeMethodInfoPtr_AddControlItemsFromProperties_Private_Static_Void_Type_List_1_ControlItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668112);
		NativeMethodInfoPtr_AddControlItemsFromMembers_Private_Static_Void_Il2CppReferenceArray_1_MemberInfo_List_1_ControlItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668113);
		NativeMethodInfoPtr_AddControlItemsFromMember_Private_Static_Void_MemberInfo_Il2CppReferenceArray_1_InputControlAttribute_List_1_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668114);
		NativeMethodInfoPtr_CreateControlItemFromMember_Private_Static_ControlItem_MemberInfo_InputControlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668115);
		NativeMethodInfoPtr_InferLayoutFromValueType_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668116);
		NativeMethodInfoPtr_MergeLayout_Public_Void_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668117);
		NativeMethodInfoPtr_CreateLookupTableForControls_Private_Static_Dictionary_2_String_ControlItem_Il2CppReferenceArray_1_ControlItem_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668118);
		NativeMethodInfoPtr_VariantsMatch_Internal_Static_Boolean_InternedString_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668119);
		NativeMethodInfoPtr_VariantsMatch_Internal_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668120);
		NativeMethodInfoPtr_ParseHeaderFieldsFromJson_Internal_Static_Void_String_byref_InternedString_byref_InlinedArray_1_InternedString_byref_InputDeviceMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668121);
		NativeMethodInfoPtr_get_cache_Internal_Static_get_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668122);
		NativeMethodInfoPtr_CacheRef_Internal_Static_CacheRefInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668123);
		NativeMethodInfoPtr__MergeLayout_b__77_0_Private_Boolean_ControlItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr, 100668125);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012137, RefRangeEnd = 1012138, XrefRangeStart = 1012128, XrefRangeEnd = 1012137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<ControlItem> FindControl(InternedString path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)path));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControl_Public_Nullable_1_ControlItem_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<ControlItem>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012154, RefRangeEnd = 1012155, XrefRangeStart = 1012138, XrefRangeEnd = 1012154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<ControlItem> FindControlIncludingArrayElements(string path, out int arrayIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref arrayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControlIncludingArrayElements_Public_Nullable_1_ControlItem_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<ControlItem>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012155, XrefRangeEnd = 1012161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Type GetValueType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012161, XrefRangeEnd = 1012235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlLayout FromType(string name, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromType_Public_Static_InputControlLayout_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1012240, RefRangeEnd = 1012242, XrefRangeStart = 1012235, XrefRangeEnd = 1012240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToJson()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJson_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012242, XrefRangeEnd = 1012246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControlLayout FromJson(string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJson_Public_Static_InputControlLayout_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControlLayout>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012246, XrefRangeEnd = 1012250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControlLayout(string name, Il2CppSystem.Type type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControlLayout>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1012262, RefRangeEnd = 1012265, XrefRangeStart = 1012250, XrefRangeEnd = 1012262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddControlItems(Il2CppSystem.Type type, List<ControlItem> controlLayouts, string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlLayouts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlItems_Private_Static_Void_Type_List_1_ControlItem_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012265, XrefRangeEnd = 1012270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddControlItemsFromFields(Il2CppSystem.Type type, List<ControlItem> controlLayouts, string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlLayouts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlItemsFromFields_Private_Static_Void_Type_List_1_ControlItem_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012270, XrefRangeEnd = 1012275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddControlItemsFromProperties(Il2CppSystem.Type type, List<ControlItem> controlLayouts, string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlLayouts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlItemsFromProperties_Private_Static_Void_Type_List_1_ControlItem_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1012332, RefRangeEnd = 1012336, XrefRangeStart = 1012275, XrefRangeEnd = 1012332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddControlItemsFromMembers(Il2CppReferenceArray<MemberInfo> members, List<ControlItem> controlItems, string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)members);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlItems);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlItemsFromMembers_Private_Static_Void_Il2CppReferenceArray_1_MemberInfo_List_1_ControlItem_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012351, RefRangeEnd = 1012352, XrefRangeStart = 1012336, XrefRangeEnd = 1012351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddControlItemsFromMember(MemberInfo member, Il2CppReferenceArray<InputControlAttribute> attributes, List<ControlItem> controlItems)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlItems);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddControlItemsFromMember_Private_Static_Void_MemberInfo_Il2CppReferenceArray_1_InputControlAttribute_List_1_ControlItem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1012474, RefRangeEnd = 1012476, XrefRangeStart = 1012352, XrefRangeEnd = 1012474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateControlItemFromMember_Private_Static_ControlItem_MemberInfo_InputControlAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ControlItem(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012499, RefRangeEnd = 1012500, XrefRangeStart = 1012476, XrefRangeEnd = 1012499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InferLayoutFromValueType(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InferLayoutFromValueType_Private_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1012667, RefRangeEnd = 1012669, XrefRangeStart = 1012500, XrefRangeEnd = 1012667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeLayout(InputControlLayout other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeLayout_Public_Void_InputControlLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1012711, RefRangeEnd = 1012713, XrefRangeStart = 1012669, XrefRangeEnd = 1012711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, ControlItem> CreateLookupTableForControls(Il2CppReferenceArray<ControlItem> controlItems, List<string> variants = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlItems);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)variants);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLookupTableForControls_Private_Static_Dictionary_2_String_ControlItem_Il2CppReferenceArray_1_ControlItem_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, ControlItem>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012713, XrefRangeEnd = 1012717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool VariantsMatch(InternedString expected, InternedString actual)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)expected));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)actual));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VariantsMatch_Internal_Static_Boolean_InternedString_InternedString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1012732, RefRangeEnd = 1012736, XrefRangeStart = 1012717, XrefRangeEnd = 1012732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool VariantsMatch(string expected, string actual)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(expected);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actual);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VariantsMatch_Internal_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1012752, RefRangeEnd = 1012753, XrefRangeStart = 1012736, XrefRangeEnd = 1012752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString> baseLayouts, out InputDeviceMatcher deviceMatcher)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseHeaderFieldsFromJson_Internal_Static_Void_String_byref_InternedString_byref_InlinedArray_1_InternedString_byref_InputDeviceMatcher_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num7 = num2;
		name = ((num7 == 0) ? null : new InternedString(num7));
		nint num8 = num4;
		baseLayouts = ((num8 == 0) ? null : new InlinedArray<InternedString>(num8));
		nint num9 = num6;
		deviceMatcher = ((num9 == 0) ? null : new InputDeviceMatcher(num9));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1012767, RefRangeEnd = 1012770, XrefRangeStart = 1012763, XrefRangeEnd = 1012767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CacheRefInstance CacheRef()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheRef_Internal_Static_CacheRefInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CacheRefInstance*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012770, XrefRangeEnd = 1012777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _MergeLayout_b__77_0(ControlItem x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MergeLayout_b__77_0_Private_Boolean_ControlItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputControlLayout(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
