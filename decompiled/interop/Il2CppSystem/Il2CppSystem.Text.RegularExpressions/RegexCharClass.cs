using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class RegexCharClass : Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct LowerCaseMapping
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ChMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_ChMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_LcOp;

		private static readonly System.IntPtr NativeFieldInfoPtr_Data;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0;

		[FieldOffset(0)]
		public readonly char ChMin;

		[FieldOffset(2)]
		public readonly char ChMax;

		[FieldOffset(4)]
		public readonly int LcOp;

		[FieldOffset(8)]
		public readonly int Data;

		static LowerCaseMapping()
		{
			Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "LowerCaseMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr);
			NativeFieldInfoPtr_ChMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr, "ChMin");
			NativeFieldInfoPtr_ChMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr, "ChMax");
			NativeFieldInfoPtr_LcOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr, "LcOp");
			NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr, "Data");
			NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr, 100664615);
		}

		[CallerCount(0)]
		public unsafe LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&chMin);
			*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chMax;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lcOp;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LowerCaseMapping>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class SingleRangeComparer : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0;

		public unsafe static SingleRangeComparer Instance
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SingleRangeComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static SingleRangeComparer()
		{
			Il2CppClassPointerStore<SingleRangeComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRangeComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleRangeComparer>.NativeClassPtr);
			NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRangeComparer>.NativeClassPtr, "Instance");
			NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRangeComparer>.NativeClassPtr, 100664616);
			NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRangeComparer>.NativeClassPtr, 100664617);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleRangeComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleRangeComparer>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873303, XrefRangeEnd = 873306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(SingleRange x, SingleRange y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&x);
			*(SingleRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public SingleRangeComparer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SingleRange
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_First;

		private static readonly System.IntPtr NativeFieldInfoPtr_Last;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0;

		[FieldOffset(0)]
		public readonly char First;

		[FieldOffset(2)]
		public readonly char Last;

		static SingleRange()
		{
			Il2CppClassPointerStore<SingleRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleRange>.NativeClassPtr);
			NativeFieldInfoPtr_First = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRange>.NativeClassPtr, "First");
			NativeFieldInfoPtr_Last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRange>.NativeClassPtr, "Last");
			NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRange>.NativeClassPtr, 100664619);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 817658, RefRangeEnd = 817659, XrefRangeStart = 817658, XrefRangeEnd = 817659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleRange(char first, char last)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&first);
			*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &last;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SingleRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_internalRegexIgnoreCase;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_space;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_notSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_word;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_notWord;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpaceClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotSpaceClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_WordClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotWordClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_DigitClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotDigitClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_definedCategories;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_propTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_lcTable;

	private static readonly System.IntPtr NativeFieldInfoPtr__rangelist;

	private static readonly System.IntPtr NativeFieldInfoPtr__categories;

	private static readonly System.IntPtr NativeFieldInfoPtr__canonical;

	private static readonly System.IntPtr NativeFieldInfoPtr__negate;

	private static readonly System.IntPtr NativeFieldInfoPtr__subtractor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CanMerge_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Negate_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChar_Public_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCharClass_Public_Void_RegexCharClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSet_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSubtraction_Public_Void_RegexCharClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRange_Public_Void_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCategoryFromName_Public_Void_String_Boolean_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCategory_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLowercase_Public_Void_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWord_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpace_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDigit_Public_Void_Boolean_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SingletonChar_Public_Static_Char_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMergeable_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSingleton_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSingletonInverse_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNegated_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsECMAWordChar_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWordChar_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CharInClass_Public_Static_Boolean_Char_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CharInClassRecursive_Private_Static_Boolean_Char_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_RegexCharClass_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RangeCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToStringClass_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Canonicalize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0;

	public unsafe static string s_internalRegexIgnoreCase
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_internalRegexIgnoreCase, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_internalRegexIgnoreCase, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string s_space
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_space, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_space, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string s_notSpace
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_notSpace, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_notSpace, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string s_word
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_word, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_word, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string s_notWord
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_notWord, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_notWord, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SpaceClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpaceClass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpaceClass, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string NotSpaceClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotSpaceClass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotSpaceClass, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string WordClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WordClass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WordClass, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string NotWordClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotWordClass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotWordClass, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DigitClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DigitClass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DigitClass, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string NotDigitClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotDigitClass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotDigitClass, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Dictionary<string, string> s_definedCategories
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_definedCategories, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_definedCategories, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> s_propTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_propTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_propTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<LowerCaseMapping> s_lcTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_lcTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<LowerCaseMapping>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_lcTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<SingleRange> _rangelist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rangelist);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SingleRange>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rangelist)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StringBuilder _categories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__categories);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__categories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _canonical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canonical);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canonical)) = value;
		}
	}

	public unsafe bool _negate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__negate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__negate)) = value;
		}
	}

	public unsafe RegexCharClass _subtractor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__subtractor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__subtractor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool CanMerge
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanMerge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool Negate
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Negate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RegexCharClass()
	{
		Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCharClass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr);
		NativeFieldInfoPtr_s_internalRegexIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_internalRegexIgnoreCase");
		NativeFieldInfoPtr_s_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_space");
		NativeFieldInfoPtr_s_notSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_notSpace");
		NativeFieldInfoPtr_s_word = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_word");
		NativeFieldInfoPtr_s_notWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_notWord");
		NativeFieldInfoPtr_SpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SpaceClass");
		NativeFieldInfoPtr_NotSpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotSpaceClass");
		NativeFieldInfoPtr_WordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "WordClass");
		NativeFieldInfoPtr_NotWordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotWordClass");
		NativeFieldInfoPtr_DigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "DigitClass");
		NativeFieldInfoPtr_NotDigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotDigitClass");
		NativeFieldInfoPtr_s_definedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_definedCategories");
		NativeFieldInfoPtr_s_propTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_propTable");
		NativeFieldInfoPtr_s_lcTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_lcTable");
		NativeFieldInfoPtr__rangelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_rangelist");
		NativeFieldInfoPtr__categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_categories");
		NativeFieldInfoPtr__canonical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_canonical");
		NativeFieldInfoPtr__negate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_negate");
		NativeFieldInfoPtr__subtractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_subtractor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_get_CanMerge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_set_Negate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_AddChar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664580);
		NativeMethodInfoPtr_AddCharClass_Public_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_AddSet_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_AddSubtraction_Public_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_AddRange_Public_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_AddCategoryFromName_Public_Void_String_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664585);
		NativeMethodInfoPtr_AddCategory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664586);
		NativeMethodInfoPtr_AddLowercase_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664587);
		NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_AddWord_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_AddSpace_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_AddDigit_Public_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_SingletonChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_IsMergeable_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_IsSingleton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_IsSingletonInverse_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_IsNegated_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_IsECMAWordChar_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_IsWordChar_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr_CharInClass_Public_Static_Boolean_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664601);
		NativeMethodInfoPtr_CharInClassRecursive_Private_Static_Boolean_Char_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664602);
		NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664603);
		NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664604);
		NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664605);
		NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664606);
		NativeMethodInfoPtr_Parse_Public_Static_RegexCharClass_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_RangeCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_ToStringClass_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_Canonicalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664613);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 873319, RefRangeEnd = 873325, XrefRangeStart = 873306, XrefRangeEnd = 873319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexCharClass()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873325, XrefRangeEnd = 873329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&negate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ranges);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)categories);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subtraction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873330, RefRangeEnd = 873333, XrefRangeStart = 873329, XrefRangeEnd = 873330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChar(char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873350, RefRangeEnd = 873352, XrefRangeStart = 873333, XrefRangeEnd = 873350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCharClass(RegexCharClass cc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCharClass_Public_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873367, RefRangeEnd = 873370, XrefRangeStart = 873352, XrefRangeEnd = 873367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSet(string set)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSet_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSubtraction(RegexCharClass sub)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sub);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSubtraction_Public_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 873378, RefRangeEnd = 873384, XrefRangeStart = 873370, XrefRangeEnd = 873378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRange(char first, char last)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&first);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &last;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRange_Public_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873420, RefRangeEnd = 873422, XrefRangeStart = 873384, XrefRangeEnd = 873420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &invert;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &caseInsensitive;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCategoryFromName_Public_Void_String_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873422, XrefRangeEnd = 873424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCategory(string category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCategory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873433, RefRangeEnd = 873434, XrefRangeStart = 873424, XrefRangeEnd = 873433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLowercase(CultureInfo culture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLowercase_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873452, RefRangeEnd = 873455, XrefRangeStart = 873434, XrefRangeEnd = 873452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&chMin);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chMax;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873471, RefRangeEnd = 873472, XrefRangeStart = 873455, XrefRangeEnd = 873471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWord(bool ecma, bool negate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ecma);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &negate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWord_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873488, RefRangeEnd = 873489, XrefRangeStart = 873472, XrefRangeEnd = 873488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpace(bool ecma, bool negate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ecma);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &negate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpace_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873498, RefRangeEnd = 873499, XrefRangeStart = 873489, XrefRangeEnd = 873498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDigit(bool ecma, bool negate, string pattern)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ecma);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &negate;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDigit_Public_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873501, RefRangeEnd = 873503, XrefRangeStart = 873499, XrefRangeEnd = 873501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char SingletonChar(string set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SingletonChar_Public_Static_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873507, RefRangeEnd = 873509, XrefRangeStart = 873503, XrefRangeEnd = 873507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMergeable(string charClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMergeable_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873517, RefRangeEnd = 873519, XrefRangeStart = 873509, XrefRangeEnd = 873517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEmpty(string charClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873530, RefRangeEnd = 873532, XrefRangeStart = 873519, XrefRangeEnd = 873530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSingleton(string set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSingleton_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873543, RefRangeEnd = 873545, XrefRangeStart = 873532, XrefRangeEnd = 873543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSingletonInverse(string set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSingletonInverse_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873545, XrefRangeEnd = 873547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSubtraction(string charClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsNegated(string set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNegated_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873556, RefRangeEnd = 873558, XrefRangeStart = 873547, XrefRangeEnd = 873556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsECMAWordChar(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsECMAWordChar_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 873566, RefRangeEnd = 873572, XrefRangeStart = 873558, XrefRangeEnd = 873566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWordChar(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWordChar_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 873576, RefRangeEnd = 873580, XrefRangeStart = 873572, XrefRangeEnd = 873576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CharInClass(char ch, string set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ch);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(set);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CharInClass_Public_Static_Boolean_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 873590, RefRangeEnd = 873595, XrefRangeStart = 873580, XrefRangeEnd = 873590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CharInClassRecursive(char ch, string set, int start)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ch);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(set);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CharInClassRecursive_Private_Static_Boolean_Char_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873602, RefRangeEnd = 873603, XrefRangeStart = 873595, XrefRangeEnd = 873602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&ch);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(set);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mySetLength;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &myCategoryLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873603, XrefRangeEnd = 873619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&ch);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(set);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mySetLength;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &myCategoryLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873621, RefRangeEnd = 873622, XrefRangeStart = 873619, XrefRangeEnd = 873621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ch);
		*(UnicodeCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chcategory;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(category);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873622, XrefRangeEnd = 873627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NegateCategory(string category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873631, RefRangeEnd = 873633, XrefRangeStart = 873627, XrefRangeEnd = 873631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegexCharClass Parse(string charClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_RegexCharClass_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873663, RefRangeEnd = 873666, XrefRangeStart = 873633, XrefRangeEnd = 873663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegexCharClass ParseRecursive(string charClass, int start)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 873667, RefRangeEnd = 873668, XrefRangeStart = 873666, XrefRangeEnd = 873667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RangeCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RangeCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 875013, RefRangeEnd = 875018, XrefRangeStart = 873668, XrefRangeEnd = 875013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToStringClass()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToStringClass_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 875022, RefRangeEnd = 875025, XrefRangeStart = 875018, XrefRangeEnd = 875022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SingleRange GetRangeAt(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SingleRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875052, RefRangeEnd = 875053, XrefRangeStart = 875025, XrefRangeEnd = 875052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Canonicalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Canonicalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875053, XrefRangeEnd = 875067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SetFromProperty(string capname, bool invert, string pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &invert;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public RegexCharClass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
