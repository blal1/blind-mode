using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode;

public class SimpleCollator : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Context
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Option;

		private static readonly System.IntPtr NativeFieldInfoPtr_NeverMatchFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysMatchFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_Buffer1;

		private static readonly System.IntPtr NativeFieldInfoPtr_Buffer2;

		private static readonly System.IntPtr NativeFieldInfoPtr_PrevCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_PrevSortKey;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0;

		[FieldOffset(0)]
		public readonly CompareOptions Option;

		[FieldOffset(8)]
		public readonly System.IntPtr NeverMatchFlags;

		[FieldOffset(16)]
		public readonly System.IntPtr AlwaysMatchFlags;

		[FieldOffset(24)]
		public System.IntPtr Buffer1;

		[FieldOffset(32)]
		public System.IntPtr Buffer2;

		[FieldOffset(40)]
		public int PrevCode;

		[FieldOffset(48)]
		public System.IntPtr PrevSortKey;

		static Context()
		{
			Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Context");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
			NativeFieldInfoPtr_Option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "Option");
			NativeFieldInfoPtr_NeverMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "NeverMatchFlags");
			NativeFieldInfoPtr_AlwaysMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "AlwaysMatchFlags");
			NativeFieldInfoPtr_Buffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "Buffer1");
			NativeFieldInfoPtr_Buffer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "Buffer2");
			NativeFieldInfoPtr_PrevCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "PrevCode");
			NativeFieldInfoPtr_PrevSortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "PrevSortKey");
			NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100663556);
		}

		[CallerCount(0)]
		public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&opt);
			*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = alwaysMatchFlags;
			*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = neverMatchFlags;
			*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer1;
			*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer2;
			*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = prev1;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Context>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PreviousInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Code;

		private static readonly System.IntPtr NativeFieldInfoPtr_SortKey;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		[FieldOffset(0)]
		public int Code;

		[FieldOffset(8)]
		public System.IntPtr SortKey;

		static PreviousInfo()
		{
			Il2CppClassPointerStore<PreviousInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "PreviousInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviousInfo>.NativeClassPtr);
			NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousInfo>.NativeClassPtr, "Code");
			NativeFieldInfoPtr_SortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviousInfo>.NativeClassPtr, "SortKey");
			NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviousInfo>.NativeClassPtr, 100663557);
		}

		[CallerCount(0)]
		public unsafe PreviousInfo(bool dummy)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&dummy);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreviousInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class Escape : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Source;

		private static readonly System.IntPtr NativeFieldInfoPtr_Index;

		private static readonly System.IntPtr NativeFieldInfoPtr_Start;

		private static readonly System.IntPtr NativeFieldInfoPtr_End;

		private static readonly System.IntPtr NativeFieldInfoPtr_Optional;

		public unsafe string Source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int Index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index)) = value;
			}
		}

		public unsafe int Start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Start)) = value;
			}
		}

		public unsafe int End
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_End);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_End)) = value;
			}
		}

		public unsafe int Optional
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Optional);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Optional)) = value;
			}
		}

		static Escape()
		{
			Il2CppClassPointerStore<Escape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Escape");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Escape>.NativeClassPtr);
			NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Escape>.NativeClassPtr, "Source");
			NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Escape>.NativeClassPtr, "Index");
			NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Escape>.NativeClassPtr, "Start");
			NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Escape>.NativeClassPtr, "End");
			NativeFieldInfoPtr_Optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Escape>.NativeClassPtr, "Optional");
		}

		public Escape(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Escape()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Escape>.NativeClassPtr))
		{
		}
	}

	[OriginalName("mscorlib.dll", "", "ExtenderType")]
	public enum ExtenderType
	{
		None,
		Simple,
		Voiced,
		Conditional,
		Buggy
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_invariant;

	private static readonly System.IntPtr NativeFieldInfoPtr_textInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkIndexer;

	private static readonly System.IntPtr NativeFieldInfoPtr_contractions;

	private static readonly System.IntPtr NativeFieldInfoPtr_level2Maps;

	private static readonly System.IntPtr NativeFieldInfoPtr_unsafeFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkCatTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkLv1Table;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkLv2Table;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkLv2Indexer;

	private static readonly System.IntPtr NativeFieldInfoPtr_lcid;

	private static readonly System.IntPtr NativeFieldInfoPtr_frenchSort;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Category_Private_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Level1_Private_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortKey_Public_Virtual_Final_New_SortKey_String_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Globalization_ISimpleCollator_Compare_Private_Virtual_Final_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSuffix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

	public unsafe static SimpleCollator invariant
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_invariant, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_invariant, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe CodePointIndexer cjkIndexer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkIndexer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkIndexer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Contraction> contractions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contractions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Contraction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contractions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Level2Map> level2Maps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level2Maps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level2Map>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level2Maps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> unsafeFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unsafeFlags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unsafeFlags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe byte* cjkCatTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkCatTable);
			return *(byte**)num;
		}
		set
		{
			*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkCatTable)) = value;
		}
	}

	public unsafe byte* cjkLv1Table
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkLv1Table);
			return *(byte**)num;
		}
		set
		{
			*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkLv1Table)) = value;
		}
	}

	public unsafe byte* cjkLv2Table
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkLv2Table);
			return *(byte**)num;
		}
		set
		{
			*(byte**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkLv2Table)) = value;
		}
	}

	public unsafe CodePointIndexer cjkLv2Indexer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkLv2Indexer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cjkLv2Indexer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int lcid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lcid);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lcid)) = value;
		}
	}

	public unsafe bool frenchSort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frenchSort);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frenchSort)) = value;
		}
	}

	static SimpleCollator()
	{
		Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "SimpleCollator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr);
		NativeFieldInfoPtr_invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "invariant");
		NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "textInfo");
		NativeFieldInfoPtr_cjkIndexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkIndexer");
		NativeFieldInfoPtr_contractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "contractions");
		NativeFieldInfoPtr_level2Maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "level2Maps");
		NativeFieldInfoPtr_unsafeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "unsafeFlags");
		NativeFieldInfoPtr_cjkCatTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkCatTable");
		NativeFieldInfoPtr_cjkLv1Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv1Table");
		NativeFieldInfoPtr_cjkLv2Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Table");
		NativeFieldInfoPtr_cjkLv2Indexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Indexer");
		NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "lcid");
		NativeFieldInfoPtr_frenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "frenchSort");
		NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_Category_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_Level1_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_GetSortKey_Public_Virtual_Final_New_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_System_Globalization_ISimpleCollator_Compare_Private_Virtual_Final_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_IsPrefix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_IsSuffix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_LastIndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663554);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697555, RefRangeEnd = 697556, XrefRangeStart = 697522, XrefRangeEnd = 697555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleCollator(CultureInfo culture)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697556, XrefRangeEnd = 697564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
	{
		//IL_00cc->IL00ce: Incompatible stack types: I vs O
		//IL_00de->IL00e0: Incompatible stack types: I vs O
		//IL_0102->IL0104: Incompatible stack types: I vs O
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cjkIndexer);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref catTable));
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref lv1Table));
		*(System.IntPtr**)num3 = &intPtr3;
		byte* num4 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lv2Indexer);
		*(System.IntPtr**)num4 = &intPtr4;
		byte* num5 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref lv2Table));
		*(System.IntPtr**)num5 = &intPtr5;
		Unsafe.SkipInit(out System.IntPtr intPtr6);
		System.IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr6);
		Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		System.IntPtr intPtr8 = intPtr;
		cjkIndexer = ((intPtr8 == (System.IntPtr)0) ? null : new CodePointIndexer(intPtr8));
		System.IntPtr intPtr9 = intPtr2;
		Unsafe.As<byte*, object>(ref catTable) = ((intPtr9 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr9)));
		System.IntPtr intPtr10 = intPtr3;
		Unsafe.As<byte*, object>(ref lv1Table) = ((intPtr10 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr10)));
		System.IntPtr intPtr11 = intPtr4;
		lv2Indexer = ((intPtr11 == (System.IntPtr)0) ? null : new CodePointIndexer(intPtr11));
		System.IntPtr intPtr12 = intPtr5;
		Unsafe.As<byte*, object>(ref lv2Table) = ((intPtr12 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr12)));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697564, XrefRangeEnd = 697565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureInfo GetNeutralCulture(CultureInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 697567, RefRangeEnd = 697579, XrefRangeStart = 697565, XrefRangeEnd = 697567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte Category(int cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Category_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 697581, RefRangeEnd = 697589, XrefRangeStart = 697579, XrefRangeEnd = 697581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte Level1(int cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Level1_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 697595, RefRangeEnd = 697610, XrefRangeStart = 697589, XrefRangeEnd = 697595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte Level2(int cp, ExtenderType ext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cp);
		*(ExtenderType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 697611, RefRangeEnd = 697615, XrefRangeStart = 697610, XrefRangeEnd = 697611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHalfKana(int cp, CompareOptions opt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cp);
		*(CompareOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 697621, RefRangeEnd = 697628, XrefRangeStart = 697615, XrefRangeEnd = 697621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Contraction GetContraction(string s, int start, int end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Contraction>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697632, RefRangeEnd = 697634, XrefRangeStart = 697628, XrefRangeEnd = 697632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Contraction GetContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clist);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Contraction>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697634, XrefRangeEnd = 697640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Contraction GetTailContraction(string s, int start, int end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Contraction>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 697644, RefRangeEnd = 697648, XrefRangeStart = 697640, XrefRangeEnd = 697644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Contraction GetTailContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clist);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Contraction>(intPtr2) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 697674, RefRangeEnd = 697683, XrefRangeStart = 697648, XrefRangeEnd = 697674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FilterOptions(int i, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(CompareOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697683, RefRangeEnd = 697688, XrefRangeStart = 697683, XrefRangeEnd = 697683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExtenderType GetExtenderType(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ExtenderType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static byte ToDashTypeValue(ExtenderType ext, CompareOptions opt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ext);
		*(CompareOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697692, RefRangeEnd = 697697, XrefRangeStart = 697688, XrefRangeEnd = 697692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FilterExtender(int i, ExtenderType ext, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&i);
		*(ExtenderType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(CompareOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697701, RefRangeEnd = 697706, XrefRangeStart = 697697, XrefRangeEnd = 697701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIgnorable(int i, CompareOptions opt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(CompareOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697706, RefRangeEnd = 697708, XrefRangeStart = 697706, XrefRangeEnd = 697706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSafe(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697708, XrefRangeEnd = 697715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SortKey GetSortKey(string s, CompareOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(CompareOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortKey_Public_Virtual_Final_New_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SortKey>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697715, XrefRangeEnd = 697722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SortKey GetSortKey(string s, int start, int length, CompareOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(CompareOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SortKey>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 697757, RefRangeEnd = 697760, XrefRangeStart = 697722, XrefRangeEnd = 697757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(CompareOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697769, RefRangeEnd = 697770, XrefRangeStart = 697760, XrefRangeEnd = 697769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillSortKeyRaw(int i, ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&i);
		*(ExtenderType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(CompareOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697770, XrefRangeEnd = 697774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697774, XrefRangeEnd = 697775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int System_Globalization_ISimpleCollator_Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s2);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx2;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &len2;
		*(CompareOptions**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Globalization_ISimpleCollator_Compare_Private_Virtual_Final_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697776, RefRangeEnd = 697777, XrefRangeStart = 697775, XrefRangeEnd = 697776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s2);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx2;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &len2;
		*(CompareOptions**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697777, XrefRangeEnd = 697778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearBuffer(byte* buffer, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697918, RefRangeEnd = 697923, XrefRangeStart = 697778, XrefRangeEnd = 697918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s2);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx2;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &len2;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref targetConsumed);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sourceConsumed);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipHeadingExtenders;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &immediateBreakup;
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int CompareFlagPair(bool b1, bool b2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&b1);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697923, XrefRangeEnd = 697924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsPrefix(string src, string target, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(CompareOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrefix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697925, RefRangeEnd = 697926, XrefRangeStart = 697924, XrefRangeEnd = 697925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(CompareOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697926, XrefRangeEnd = 697927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipHeadingExtenders;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697927, XrefRangeEnd = 697928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsSuffix(string src, string target, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(CompareOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSuffix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697928, XrefRangeEnd = 697929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(CompareOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697929, XrefRangeEnd = 697936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref testWasUnable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697936, XrefRangeEnd = 697942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int IndexOf(string s, string target, int start, int length, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(CompareOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697942, XrefRangeEnd = 697945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfOrdinal(string s, string target, int start, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697945, XrefRangeEnd = 697946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfOrdinal(string s, char target, int start, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697946, XrefRangeEnd = 697949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = sortkey;
		*(char**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697981, RefRangeEnd = 697982, XrefRangeStart = 697949, XrefRangeEnd = 697981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = targetSortKey;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697983, RefRangeEnd = 697985, XrefRangeStart = 697982, XrefRangeEnd = 697983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(CompareOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opt;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697985, XrefRangeEnd = 697989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfOrdinal(string s, string target, int start, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697992, RefRangeEnd = 697993, XrefRangeStart = 697989, XrefRangeEnd = 697992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &orgStart;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = sortkey;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698024, RefRangeEnd = 698026, XrefRangeStart = 697993, XrefRangeEnd = 698024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = targetSortKey;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698027, RefRangeEnd = 698029, XrefRangeStart = 698026, XrefRangeEnd = 698027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = sortkey;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698029, XrefRangeEnd = 698033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = sortkey;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		*(ExtenderType**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		byte* num = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ct);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ct = ((intPtr4 == (System.IntPtr)0) ? null : new Contraction(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698033, XrefRangeEnd = 698053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, ExtenderType ext, byte* target, int ti, bool noLv4)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&opt);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = source;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &si;
		*(ExtenderType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = target;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698054, RefRangeEnd = 698056, XrefRangeStart = 698053, XrefRangeEnd = 698054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &orgStart;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = sortkey;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698056, XrefRangeEnd = 698095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &orgStart;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ti;
		*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = sortkey;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLv4;
		*(ExtenderType**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		byte* num = (byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ct);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ct = ((intPtr4 == (System.IntPtr)0) ? null : new Contraction(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public SimpleCollator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
