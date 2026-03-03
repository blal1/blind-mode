using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputControlPath : Il2CppSystem.Object
{
	[OriginalName("Unity.InputSystem.dll", "", "HumanReadableStringOptions")]
	[System.Flags]
	public enum HumanReadableStringOptions
	{
		None = 0,
		OmitDevice = 2,
		UseShortNames = 4
	}

	[OriginalName("Unity.InputSystem.dll", "", "PathComponentType")]
	public enum PathComponentType
	{
		Name,
		DisplayName,
		Usage,
		Layout
	}

	public sealed class ParsedPathComponent : Il2CppSystem.ValueType
	{
		[System.Serializable]
		[ObfuscatedName("UnityEngine.InputSystem.InputControlPath+ParsedPathComponent+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__get_usages_b__7_0_Internal_String_Substring_0;

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

			public unsafe static Il2CppSystem.Func<Substring, string> __9__7_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Substring, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__7_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__7_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664865);
				NativeMethodInfoPtr__get_usages_b__7_0_Internal_String_Substring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664866);
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975482, XrefRangeEnd = 975483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _get_usages_b__7_0(Substring x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_usages_b__7_0_Internal_String_Substring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Layout;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Usages;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_layout_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_usages_Public_get_IEnumerable_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isWildcard_Internal_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isDoubleWildcard_Internal_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHumanReadableString_Internal_String_String_String_byref_String_byref_String_HumanReadableStringOptions_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHumanReadableString_Private_Static_String_Substring_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_InputControl_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ComparePathElementToString_Private_Static_Boolean_Substring_String_0;

		public unsafe Substring m_Layout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Layout);
				return new Substring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Substring>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Layout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Substring>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe InlinedArray<Substring> m_Usages
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Usages);
				return new InlinedArray<Substring>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<Substring>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Usages), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<Substring>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Substring m_Name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name);
				return new Substring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Substring>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Substring>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Substring m_DisplayName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName);
				return new Substring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Substring>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Substring>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe string layout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975483, XrefRangeEnd = 975484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layout_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe IEnumerable<string> usages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975484, XrefRangeEnd = 975505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usages_Public_get_IEnumerable_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
		}

		public unsafe string name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975505, XrefRangeEnd = 975506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string displayName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975506, XrefRangeEnd = 975507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe bool isWildcard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 975511, RefRangeEnd = 975512, XrefRangeStart = 975507, XrefRangeEnd = 975511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isWildcard_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isDoubleWildcard
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975512, XrefRangeEnd = 975516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDoubleWildcard_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ParsedPathComponent()
		{
			Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "ParsedPathComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr);
			NativeFieldInfoPtr_m_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, "m_Layout");
			NativeFieldInfoPtr_m_Usages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, "m_Usages");
			NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, "m_Name");
			NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, "m_DisplayName");
			NativeMethodInfoPtr_get_layout_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664854);
			NativeMethodInfoPtr_get_usages_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664855);
			NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664856);
			NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664857);
			NativeMethodInfoPtr_get_isWildcard_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664858);
			NativeMethodInfoPtr_get_isDoubleWildcard_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664859);
			NativeMethodInfoPtr_ToHumanReadableString_Internal_String_String_String_byref_String_byref_String_HumanReadableStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664860);
			NativeMethodInfoPtr_ToHumanReadableString_Private_Static_String_Substring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664861);
			NativeMethodInfoPtr_Matches_Public_Boolean_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664862);
			NativeMethodInfoPtr_ComparePathElementToString_Private_Static_Boolean_Substring_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, 100664863);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 975666, RefRangeEnd = 975668, XrefRangeStart = 975516, XrefRangeEnd = 975666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, HumanReadableStringOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentLayoutName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parentControlPath);
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num4 = 0;
			*(nint**)num3 = &num4;
			*(HumanReadableStringOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHumanReadableString_Internal_String_String_String_byref_String_byref_String_HumanReadableStringOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			referencedLayoutName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
			controlPath = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975668, XrefRangeEnd = 975672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHumanReadableString(Substring substring)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)substring));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHumanReadableString_Private_Static_String_Substring_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 975713, RefRangeEnd = 975716, XrefRangeStart = 975672, XrefRangeEnd = 975713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(InputControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Boolean_InputControl_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 975723, RefRangeEnd = 975728, XrefRangeStart = 975716, XrefRangeEnd = 975723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComparePathElementToString(Substring pathElement, string element)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pathElement));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(element);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComparePathElementToString_Private_Static_Boolean_Substring_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ParsedPathComponent(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ParsedPathComponent()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr))
		{
		}
	}

	public sealed class PathParser : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_path;

		private static readonly System.IntPtr NativeFieldInfoPtr_length;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftIndexInPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightIndexInPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_current;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isAtEnd_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveToNextComponent_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseComponentPart_Private_Substring_Char_0;

		public unsafe string path
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int length
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length)) = value;
			}
		}

		public unsafe int leftIndexInPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftIndexInPath);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftIndexInPath)) = value;
			}
		}

		public unsafe int rightIndexInPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightIndexInPath);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightIndexInPath)) = value;
			}
		}

		public unsafe ParsedPathComponent current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_current);
				return new ParsedPathComponent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool isAtEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isAtEnd_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static PathParser()
		{
			Il2CppClassPointerStore<PathParser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "PathParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathParser>.NativeClassPtr);
			NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathParser>.NativeClassPtr, "path");
			NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathParser>.NativeClassPtr, "length");
			NativeFieldInfoPtr_leftIndexInPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathParser>.NativeClassPtr, "leftIndexInPath");
			NativeFieldInfoPtr_rightIndexInPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathParser>.NativeClassPtr, "rightIndexInPath");
			NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathParser>.NativeClassPtr, "current");
			NativeMethodInfoPtr_get_isAtEnd_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathParser>.NativeClassPtr, 100664867);
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathParser>.NativeClassPtr, 100664868);
			NativeMethodInfoPtr_MoveToNextComponent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathParser>.NativeClassPtr, 100664869);
			NativeMethodInfoPtr_ParseComponentPart_Private_Substring_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathParser>.NativeClassPtr, 100664870);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975728, XrefRangeEnd = 975729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathParser(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathParser>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 975756, RefRangeEnd = 975765, XrefRangeStart = 975729, XrefRangeEnd = 975756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextComponent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToNextComponent_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975765, XrefRangeEnd = 975768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Substring ParseComponentPart(char terminator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&terminator);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseComponentPart_Private_Substring_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Substring(pointer);
		}

		public PathParser(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public PathParser()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathParser>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.InputSystem.InputControlPath+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TryGetDeviceUsages_b__9_0_Internal_String_Substring_0;

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

		public unsafe static Il2CppSystem.Func<Substring, string> __9__9_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Substring, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__9_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__9_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664872);
			NativeMethodInfoPtr__TryGetDeviceUsages_b__9_0_Internal_String_Substring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664873);
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
		public unsafe string _TryGetDeviceUsages_b__9_0(Substring x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TryGetDeviceUsages_b__9_0_Internal_String_Substring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputSystem.InputControlPath+<Parse>d__34")]
	public sealed class _Parse_d__34 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;

		private static readonly System.IntPtr NativeFieldInfoPtr_path;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__path;

		private static readonly System.IntPtr NativeFieldInfoPtr__parser_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__get_Current_Private_Virtual_Final_New_get_ParsedPathComponent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ParsedPathComponent_0;

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

		public unsafe ParsedPathComponent __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				return new ParsedPathComponent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParsedPathComponent>.NativeClassPtr, ref *(uint*)null));
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

		public unsafe string path
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string __3__path
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__path);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__path)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe PathParser _parser_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parser_5__2);
				return new PathParser(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathParser>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parser_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PathParser>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe virtual ParsedPathComponent System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EInputSystem_002EInputControlPath_002EParsedPathComponent_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__get_Current_Private_Virtual_Final_New_get_ParsedPathComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ParsedPathComponent(pointer);
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975781, XrefRangeEnd = 975784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		static _Parse_d__34()
		{
			Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "<Parse>d__34");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, "<>l__initialThreadId");
			NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, "path");
			NativeFieldInfoPtr___3__path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, "<>3__path");
			NativeFieldInfoPtr__parser_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, "<parser>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664874);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664875);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664876);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__get_Current_Private_Virtual_Final_New_get_ParsedPathComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664877);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664878);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664879);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ParsedPathComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664880);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr, 100664881);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975768, XrefRangeEnd = 975770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Parse_d__34(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Parse_d__34>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975770, XrefRangeEnd = 975776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975776, XrefRangeEnd = 975781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975784, XrefRangeEnd = 975792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<ParsedPathComponent> System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_InputSystem_InputControlPath_ParsedPathComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ParsedPathComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<ParsedPathComponent>>(intPtr2) : null;
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

		public _Parse_d__34(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_TryFindControl_Public_Static_TControl_InputControl_String_Int32_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryFindControl_Public_Static_TControl_InputControl_String_Int32_0, Il2CppClassPointerStore<InputControlPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TryFindControls_Public_Static_Int32_InputControl_String_Int32_byref_InputControlList_1_TControl_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryFindControls_Public_Static_Int32_InputControl_String_Int32_byref_InputControlList_1_TControl_0, Il2CppClassPointerStore<InputControlPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TryFindChild_Public_Static_TControl_InputControl_String_Int32_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryFindChild_Public_Static_TControl_InputControl_String_Int32_0, Il2CppClassPointerStore<InputControlPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_MatchControlsRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MatchControlsRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0, Il2CppClassPointerStore<InputControlPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_MatchByUsageAtDeviceRootRecursive_Private_Static_TControl_InputDevice_String_Int32_byref_InputControlList_1_TControl_Boolean_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MatchByUsageAtDeviceRootRecursive_Private_Static_TControl_InputDevice_String_Int32_byref_InputControlList_1_TControl_Boolean_0, Il2CppClassPointerStore<InputControlPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_MatchChildrenRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0<TControl>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MatchChildrenRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0, Il2CppClassPointerStore<InputControlPath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TControl>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Wildcard;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoubleWildcard;

	private static readonly System.IntPtr NativeFieldInfoPtr_Separator;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeparatorReplacement;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanSlashes_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_InputControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHumanReadableString_Public_Static_String_String_HumanReadableStringOptions_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHumanReadableString_Public_Static_String_String_byref_String_byref_String_HumanReadableStringOptions_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDeviceUsages_Public_Static_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDeviceLayout_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetControlLayout_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControlLayoutRecursive_Private_Static_String_byref_PathParser_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControlLayoutRecursive_Private_Static_String_byref_PathParser_InputControlLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ControlLayoutMatchesPathComponent_Private_Static_Boolean_byref_ControlItem_byref_PathParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringMatches_Private_Static_Boolean_Substring_InternedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindControl_Public_Static_InputControl_InputControl_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindControls_Public_Static_Il2CppReferenceArray_1_InputControl_InputControl_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindControls_Public_Static_Int32_InputControl_String_byref_InputControlList_1_InputControl_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindControl_Public_Static_TControl_InputControl_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindControls_Public_Static_Int32_InputControl_String_Int32_byref_InputControlList_1_TControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindChild_Public_Static_InputControl_InputControl_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindChild_Public_Static_TControl_InputControl_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Static_Boolean_String_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchControlComponent_Internal_Static_Boolean_byref_ParsedPathComponent_byref_ControlItem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesPrefix_Public_Static_Boolean_String_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesRecursive_Private_Static_Boolean_byref_PathParser_InputControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchControlsRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchByUsageAtDeviceRootRecursive_Private_Static_TControl_InputDevice_String_Int32_byref_InputControlList_1_TControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchChildrenRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchPathComponent_Private_Static_Boolean_String_String_byref_Int32_PathComponentType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PathComponentCanYieldMultipleMatches_Private_Static_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_IEnumerable_1_ParsedPathComponent_String_0;

	public unsafe static string Wildcard
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Wildcard, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Wildcard, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DoubleWildcard
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoubleWildcard, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoubleWildcard, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static char Separator
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Separator, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Separator, (void*)(&value));
		}
	}

	public unsafe static char SeparatorReplacement
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SeparatorReplacement, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SeparatorReplacement, (void*)(&value));
		}
	}

	static InputControlPath()
	{
		Il2CppClassPointerStore<InputControlPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputControlPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr);
		NativeFieldInfoPtr_Wildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "Wildcard");
		NativeFieldInfoPtr_DoubleWildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "DoubleWildcard");
		NativeFieldInfoPtr_Separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "Separator");
		NativeFieldInfoPtr_SeparatorReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, "SeparatorReplacement");
		NativeMethodInfoPtr_CleanSlashes_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664826);
		NativeMethodInfoPtr_Combine_Public_Static_String_InputControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664827);
		NativeMethodInfoPtr_ToHumanReadableString_Public_Static_String_String_HumanReadableStringOptions_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664828);
		NativeMethodInfoPtr_ToHumanReadableString_Public_Static_String_String_byref_String_byref_String_HumanReadableStringOptions_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664829);
		NativeMethodInfoPtr_TryGetDeviceUsages_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664830);
		NativeMethodInfoPtr_TryGetDeviceLayout_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664831);
		NativeMethodInfoPtr_TryGetControlLayout_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664832);
		NativeMethodInfoPtr_FindControlLayoutRecursive_Private_Static_String_byref_PathParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664833);
		NativeMethodInfoPtr_FindControlLayoutRecursive_Private_Static_String_byref_PathParser_InputControlLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664834);
		NativeMethodInfoPtr_ControlLayoutMatchesPathComponent_Private_Static_Boolean_byref_ControlItem_byref_PathParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664835);
		NativeMethodInfoPtr_StringMatches_Private_Static_Boolean_Substring_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664836);
		NativeMethodInfoPtr_TryFindControl_Public_Static_InputControl_InputControl_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664837);
		NativeMethodInfoPtr_TryFindControls_Public_Static_Il2CppReferenceArray_1_InputControl_InputControl_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664838);
		NativeMethodInfoPtr_TryFindControls_Public_Static_Int32_InputControl_String_byref_InputControlList_1_InputControl_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664839);
		NativeMethodInfoPtr_TryFindControl_Public_Static_TControl_InputControl_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664840);
		NativeMethodInfoPtr_TryFindControls_Public_Static_Int32_InputControl_String_Int32_byref_InputControlList_1_TControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664841);
		NativeMethodInfoPtr_TryFindChild_Public_Static_InputControl_InputControl_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664842);
		NativeMethodInfoPtr_TryFindChild_Public_Static_TControl_InputControl_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664843);
		NativeMethodInfoPtr_Matches_Public_Static_Boolean_String_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664844);
		NativeMethodInfoPtr_MatchControlComponent_Internal_Static_Boolean_byref_ParsedPathComponent_byref_ControlItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664845);
		NativeMethodInfoPtr_MatchesPrefix_Public_Static_Boolean_String_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664846);
		NativeMethodInfoPtr_MatchesRecursive_Private_Static_Boolean_byref_PathParser_InputControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664847);
		NativeMethodInfoPtr_MatchControlsRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664848);
		NativeMethodInfoPtr_MatchByUsageAtDeviceRootRecursive_Private_Static_TControl_InputDevice_String_Int32_byref_InputControlList_1_TControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664849);
		NativeMethodInfoPtr_MatchChildrenRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664850);
		NativeMethodInfoPtr_MatchPathComponent_Private_Static_Boolean_String_String_byref_Int32_PathComponentType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664851);
		NativeMethodInfoPtr_PathComponentCanYieldMultipleMatches_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664852);
		NativeMethodInfoPtr_Parse_Public_Static_IEnumerable_1_ParsedPathComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControlPath>.NativeClassPtr, 100664853);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 975794, RefRangeEnd = 975795, XrefRangeStart = 975792, XrefRangeEnd = 975794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CleanSlashes(this string pathComponent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pathComponent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanSlashes_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975795, XrefRangeEnd = 975802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Combine(InputControl parent, string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Public_Static_String_InputControl_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975802, XrefRangeEnd = 975803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToHumanReadableString(string path, HumanReadableStringOptions options = HumanReadableStringOptions.None, InputControl control = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(HumanReadableStringOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHumanReadableString_Public_Static_String_String_HumanReadableStringOptions_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 975865, RefRangeEnd = 975867, XrefRangeStart = 975803, XrefRangeEnd = 975865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, HumanReadableStringOptions options = HumanReadableStringOptions.None, InputControl control = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(HumanReadableStringOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHumanReadableString_Public_Static_String_String_byref_String_byref_String_HumanReadableStringOptions_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		deviceLayoutName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		controlPath = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975867, XrefRangeEnd = 975887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray TryGetDeviceUsages(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetDeviceUsages_Public_Static_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 975894, RefRangeEnd = 975896, XrefRangeStart = 975887, XrefRangeEnd = 975894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TryGetDeviceLayout(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetDeviceLayout_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975896, XrefRangeEnd = 975903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TryGetControlLayout(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetControlLayout_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 975919, RefRangeEnd = 975920, XrefRangeStart = 975903, XrefRangeEnd = 975919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FindControlLayoutRecursive(ref PathParser parser, string layoutName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parser);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControlLayoutRecursive_Private_Static_String_byref_PathParser_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 975941, RefRangeEnd = 975942, XrefRangeStart = 975920, XrefRangeEnd = 975941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FindControlLayoutRecursive(ref PathParser parser, InputControlLayout layout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parser);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControlLayoutRecursive_Private_Static_String_byref_PathParser_InputControlLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975942, XrefRangeEnd = 975946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ControlLayoutMatchesPathComponent(ref InputControlLayout.ControlItem controlItem, ref PathParser parser)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parser);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ControlLayoutMatchesPathComponent_Private_Static_Boolean_byref_ControlItem_byref_PathParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 975959, RefRangeEnd = 975966, XrefRangeStart = 975946, XrefRangeEnd = 975959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StringMatches(Substring str, InternedString matchTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matchTo));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringMatches_Private_Static_Boolean_Substring_InternedString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 975969, RefRangeEnd = 975973, XrefRangeStart = 975966, XrefRangeEnd = 975969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControl TryFindControl(InputControl control, string path, int indexInPath = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindControl_Public_Static_InputControl_InputControl_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975973, XrefRangeEnd = 975988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<InputControl> TryFindControls(InputControl control, string path, int indexInPath = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindControls_Public_Static_Il2CppReferenceArray_1_InputControl_InputControl_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975988, XrefRangeEnd = 975991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryFindControls(InputControl control, string path, ref InputControlList<InputControl> matches, int indexInPath = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindControls_Public_Static_Int32_InputControl_String_byref_InputControlList_1_InputControl_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 975995, RefRangeEnd = 975999, XrefRangeStart = 975991, XrefRangeEnd = 975995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TControl TryFindControl<TControl>(InputControl control, string path, int indexInPath = 0) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryFindControl_Public_Static_TControl_InputControl_String_Int32_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 976002, RefRangeEnd = 976005, XrefRangeStart = 975999, XrefRangeEnd = 976002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryFindControls<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryFindControls_Public_Static_Int32_InputControl_String_Int32_byref_InputControlList_1_TControl_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 976008, RefRangeEnd = 976013, XrefRangeStart = 976005, XrefRangeEnd = 976008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputControl TryFindChild(InputControl control, string path, int indexInPath = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindChild_Public_Static_InputControl_InputControl_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 976023, RefRangeEnd = 976027, XrefRangeStart = 976013, XrefRangeEnd = 976023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TControl TryFindChild<TControl>(InputControl control, string path, int indexInPath = 0) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryFindChild_Public_Static_TControl_InputControl_String_Int32_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 976032, RefRangeEnd = 976035, XrefRangeStart = 976027, XrefRangeEnd = 976032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Matches(string expected, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(expected);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Static_Boolean_String_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976035, XrefRangeEnd = 976066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchControlComponent(ref ParsedPathComponent expectedControlComponent, ref InputControlLayout.ControlItem controlItem, bool matchAlias = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)expectedControlComponent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controlItem);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchAlias;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchControlComponent_Internal_Static_Boolean_byref_ParsedPathComponent_byref_ControlItem_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 976071, RefRangeEnd = 976072, XrefRangeStart = 976066, XrefRangeEnd = 976071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchesPrefix(string expected, InputControl control)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(expected);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesPrefix_Public_Static_Boolean_String_InputControl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 976073, RefRangeEnd = 976077, XrefRangeStart = 976072, XrefRangeEnd = 976073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchesRecursive(ref PathParser parser, InputControl currentControl, bool prefixOnly = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parser);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentControl);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefixOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesRecursive_Private_Static_Boolean_byref_PathParser_InputControl_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 976120, RefRangeEnd = 976125, XrefRangeStart = 976077, XrefRangeEnd = 976120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TControl MatchControlsRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchMultiple;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MatchControlsRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976125, XrefRangeEnd = 976134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TControl MatchByUsageAtDeviceRootRecursive<TControl>(InputDevice device, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchMultiple;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MatchByUsageAtDeviceRootRecursive_Private_Static_TControl_InputDevice_String_Int32_byref_InputControlList_1_TControl_Boolean_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976134, XrefRangeEnd = 976142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TControl MatchChildrenRecursive<TControl>(InputControl control, string path, int indexInPath, ref InputControlList<TControl> matches, bool matchMultiple) where TControl : InputControl
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)matches);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchMultiple;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MatchChildrenRecursive_Private_Static_TControl_InputControl_String_Int32_byref_InputControlList_1_TControl_Boolean_0<TControl>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TControl>(intPtr2, false, true);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 976145, RefRangeEnd = 976152, XrefRangeStart = 976142, XrefRangeEnd = 976145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchPathComponent(string component, string path, ref int indexInPath, PathComponentType componentType, int startIndexInComponent = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref indexInPath);
		*(PathComponentType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &componentType;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndexInComponent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchPathComponent_Private_Static_Boolean_String_String_byref_Int32_PathComponentType_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 976155, RefRangeEnd = 976157, XrefRangeStart = 976152, XrefRangeEnd = 976155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexInPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PathComponentCanYieldMultipleMatches_Private_Static_Boolean_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976157, XrefRangeEnd = 976163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<ParsedPathComponent> Parse(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_IEnumerable_1_ParsedPathComponent_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<ParsedPathComponent>>(intPtr2) : null;
	}

	public InputControlPath(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
