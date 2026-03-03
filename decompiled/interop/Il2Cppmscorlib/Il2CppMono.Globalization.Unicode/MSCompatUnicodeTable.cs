using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode;

public class MSCompatUnicodeTable : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("Mono.Globalization.Unicode.MSCompatUnicodeTable+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0;

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

		public unsafe static Il2CppSystem.Comparison<Level2Map> __9__17_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Level2Map>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__17_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__17_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663502);
			NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663503);
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
		public unsafe int _BuildTailoringTables_b__17_0(Level2Map a, Level2Map b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxExpansionLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignorableFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_categories;

	private static readonly System.IntPtr NativeFieldInfoPtr_level1;

	private static readonly System.IntPtr NativeFieldInfoPtr_level2;

	private static readonly System.IntPtr NativeFieldInfoPtr_level3;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkCHScategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkCHTcategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkJAcategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkKOcategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkCHSlv1;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkCHTlv1;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkJAlv1;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkKOlv1;

	private static readonly System.IntPtr NativeFieldInfoPtr_cjkKOlv2;

	private static readonly System.IntPtr NativeFieldInfoPtr_tailoringArr;

	private static readonly System.IntPtr NativeFieldInfoPtr_tailoringInfos;

	private static readonly System.IntPtr NativeFieldInfoPtr_forLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReady;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

	public unsafe static int MaxExpansionLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxExpansionLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxExpansionLength, (void*)(&value));
		}
	}

	public unsafe static byte* ignorableFlags
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ignorableFlags, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ignorableFlags, (void*)value);
		}
	}

	public unsafe static byte* categories
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_categories, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_categories, (void*)value);
		}
	}

	public unsafe static byte* level1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_level1, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_level1, (void*)value);
		}
	}

	public unsafe static byte* level2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_level2, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_level2, (void*)value);
		}
	}

	public unsafe static byte* level3
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_level3, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_level3, (void*)value);
		}
	}

	public unsafe static byte* cjkCHScategory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkCHScategory, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkCHScategory, (void*)value);
		}
	}

	public unsafe static byte* cjkCHTcategory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkCHTcategory, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkCHTcategory, (void*)value);
		}
	}

	public unsafe static byte* cjkJAcategory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkJAcategory, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkJAcategory, (void*)value);
		}
	}

	public unsafe static byte* cjkKOcategory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkKOcategory, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkKOcategory, (void*)value);
		}
	}

	public unsafe static byte* cjkCHSlv1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkCHSlv1, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkCHSlv1, (void*)value);
		}
	}

	public unsafe static byte* cjkCHTlv1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkCHTlv1, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkCHTlv1, (void*)value);
		}
	}

	public unsafe static byte* cjkJAlv1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkJAlv1, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkJAlv1, (void*)value);
		}
	}

	public unsafe static byte* cjkKOlv1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkKOlv1, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkKOlv1, (void*)value);
		}
	}

	public unsafe static byte* cjkKOlv2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cjkKOlv2, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cjkKOlv2, (void*)value);
		}
	}

	public unsafe static Il2CppStructArray<char> tailoringArr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tailoringArr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tailoringArr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<TailoringInfo> tailoringInfos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tailoringInfos, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TailoringInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tailoringInfos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Object forLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_forLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_forLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool isReady
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isReady, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isReady, (void*)(&value));
		}
	}

	public unsafe static bool IsReady
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697304, XrefRangeEnd = 697308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MSCompatUnicodeTable()
	{
		Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "MSCompatUnicodeTable");
		NativeFieldInfoPtr_MaxExpansionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "MaxExpansionLength");
		NativeFieldInfoPtr_ignorableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "ignorableFlags");
		NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "categories");
		NativeFieldInfoPtr_level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level1");
		NativeFieldInfoPtr_level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level2");
		NativeFieldInfoPtr_level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level3");
		NativeFieldInfoPtr_cjkCHScategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHScategory");
		NativeFieldInfoPtr_cjkCHTcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHTcategory");
		NativeFieldInfoPtr_cjkJAcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkJAcategory");
		NativeFieldInfoPtr_cjkKOcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOcategory");
		NativeFieldInfoPtr_cjkCHSlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHSlv1");
		NativeFieldInfoPtr_cjkCHTlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHTlv1");
		NativeFieldInfoPtr_cjkJAlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkJAlv1");
		NativeFieldInfoPtr_cjkKOlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOlv1");
		NativeFieldInfoPtr_cjkKOlv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOlv2");
		NativeFieldInfoPtr_tailoringArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "tailoringArr");
		NativeFieldInfoPtr_tailoringInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "tailoringInfos");
		NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "forLock");
		NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "isReady");
		NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663500);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697071, RefRangeEnd = 697073, XrefRangeStart = 697062, XrefRangeEnd = 697071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TailoringInfo GetTailoringInfo(int lcid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lcid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TailoringInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697179, RefRangeEnd = 697180, XrefRangeStart = 697073, XrefRangeEnd = 697179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Il2CppReferenceArray<Contraction> contractions, ref Il2CppReferenceArray<Level2Map> diacriticals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contractions);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)diacriticals);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		contractions = ((intPtr5 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<Contraction>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		diacriticals = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<Level2Map>(intPtr6));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697226, RefRangeEnd = 697227, XrefRangeStart = 697180, XrefRangeEnd = 697226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
	{
		//IL_00bf->IL00c1: Incompatible stack types: I vs O
		//IL_00d0->IL00d2: Incompatible stack types: I vs O
		//IL_00f4->IL00f6: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
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
		System.IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr6);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697227, XrefRangeEnd = 697236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte Category(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697236, XrefRangeEnd = 697245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte Level1(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697254, RefRangeEnd = 697255, XrefRangeStart = 697245, XrefRangeEnd = 697254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte Level2(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 697264, RefRangeEnd = 697274, XrefRangeStart = 697255, XrefRangeEnd = 697264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte Level3(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 697283, RefRangeEnd = 697286, XrefRangeStart = 697274, XrefRangeEnd = 697283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIgnorable(int cp, byte flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cp);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697290, RefRangeEnd = 697295, XrefRangeStart = 697286, XrefRangeEnd = 697290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIgnorableNonSpacing(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int ToKanaTypeInsensitive(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int ToWidthCompat(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 697295, RefRangeEnd = 697300, XrefRangeStart = 697295, XrefRangeEnd = 697295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasSpecialWeight(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsHalfWidthKana(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsHiragana(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 697300, RefRangeEnd = 697304, XrefRangeStart = 697300, XrefRangeEnd = 697300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsJapaneseSmallLetter(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697314, RefRangeEnd = 697316, XrefRangeStart = 697308, XrefRangeEnd = 697314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetResource(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint UInt32FromBytePtr(byte* raw, uint idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)raw;
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 697328, RefRangeEnd = 697330, XrefRangeStart = 697316, XrefRangeEnd = 697328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
	{
		//IL_00bf->IL00c1: Incompatible stack types: I vs O
		//IL_00d0->IL00d2: Incompatible stack types: I vs O
		//IL_00f4->IL00f6: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(culture);
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
		System.IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr6);
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697424, RefRangeEnd = 697425, XrefRangeStart = 697330, XrefRangeEnd = 697424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table)
	{
		//IL_00bf->IL00c1: Incompatible stack types: I vs O
		//IL_00d0->IL00d2: Incompatible stack types: I vs O
		//IL_00f4->IL00f6: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(culture);
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
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cjkLv2Indexer);
		*(System.IntPtr**)num4 = &intPtr4;
		byte* num5 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref lv2Table));
		*(System.IntPtr**)num5 = &intPtr5;
		Unsafe.SkipInit(out System.IntPtr intPtr6);
		System.IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr6);
		Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		System.IntPtr intPtr8 = intPtr;
		cjkIndexer = ((intPtr8 == (System.IntPtr)0) ? null : new CodePointIndexer(intPtr8));
		System.IntPtr intPtr9 = intPtr2;
		Unsafe.As<byte*, object>(ref catTable) = ((intPtr9 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr9)));
		System.IntPtr intPtr10 = intPtr3;
		Unsafe.As<byte*, object>(ref lv1Table) = ((intPtr10 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr10)));
		System.IntPtr intPtr11 = intPtr4;
		cjkLv2Indexer = ((intPtr11 == (System.IntPtr)0) ? null : new CodePointIndexer(intPtr11));
		System.IntPtr intPtr12 = intPtr5;
		Unsafe.As<byte*, object>(ref lv2Table) = ((intPtr12 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr12)));
	}

	public MSCompatUnicodeTable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
