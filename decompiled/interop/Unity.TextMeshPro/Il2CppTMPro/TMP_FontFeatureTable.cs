using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro;

[System.Serializable]
public class TMP_FontFeatureTable : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("TMPro.TMP_FontFeatureTable+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__25_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__26_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__26_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__27_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_0_Internal_UInt32_GlyphPairAdjustmentRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_1_Internal_UInt32_GlyphPairAdjustmentRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_0_Internal_UInt32_MarkToBaseAdjustmentRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_1_Internal_UInt32_MarkToBaseAdjustmentRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_0_Internal_UInt32_MarkToMarkAdjustmentRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_1_Internal_UInt32_MarkToMarkAdjustmentRecord_0;

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

		public unsafe static Il2CppSystem.Func<GlyphPairAdjustmentRecord, uint> __9__25_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<GlyphPairAdjustmentRecord, uint> __9__25_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<GlyphPairAdjustmentRecord, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<MarkToBaseAdjustmentRecord, uint> __9__26_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MarkToBaseAdjustmentRecord, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__26_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<MarkToBaseAdjustmentRecord, uint> __9__26_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MarkToBaseAdjustmentRecord, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__26_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<MarkToMarkAdjustmentRecord, uint> __9__27_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MarkToMarkAdjustmentRecord, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<MarkToMarkAdjustmentRecord, uint> __9__27_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MarkToMarkAdjustmentRecord, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_0");
			NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_1");
			NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__26_0");
			NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__26_1");
			NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_0");
			NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664055);
			NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_0_Internal_UInt32_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664056);
			NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_1_Internal_UInt32_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664057);
			NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_0_Internal_UInt32_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664058);
			NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_1_Internal_UInt32_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664059);
			NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_0_Internal_UInt32_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664060);
			NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_1_Internal_UInt32_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664061);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124544, XrefRangeEnd = 1124546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortGlyphPairAdjustmentRecords_b__25_0(GlyphPairAdjustmentRecord s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_0_Internal_UInt32_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124546, XrefRangeEnd = 1124548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortGlyphPairAdjustmentRecords_b__25_1(GlyphPairAdjustmentRecord s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortGlyphPairAdjustmentRecords_b__25_1_Internal_UInt32_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 498700, RefRangeEnd = 498709, XrefRangeStart = 498700, XrefRangeEnd = 498709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortMarkToBaseAdjustmentRecords_b__26_0(MarkToBaseAdjustmentRecord s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_0_Internal_UInt32_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe uint _SortMarkToBaseAdjustmentRecords_b__26_1(MarkToBaseAdjustmentRecord s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortMarkToBaseAdjustmentRecords_b__26_1_Internal_UInt32_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 498700, RefRangeEnd = 498709, XrefRangeStart = 498700, XrefRangeEnd = 498709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortMarkToMarkAdjustmentRecords_b__27_0(MarkToMarkAdjustmentRecord s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_0_Internal_UInt32_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe uint _SortMarkToMarkAdjustmentRecords_b__27_1(MarkToMarkAdjustmentRecord s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortMarkToMarkAdjustmentRecords_b__27_1_Internal_UInt32_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MultipleSubstitutionRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LigatureSubstitutionRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_multipleSubstitutionRecords_Public_get_List_1_MultipleSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_multipleSubstitutionRecords_Public_set_Void_List_1_MultipleSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ligatureRecords_Public_get_List_1_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ligatureRecords_Public_set_Void_List_1_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_GlyphPairAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_GlyphPairAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MarkToBaseAdjustmentRecords_Public_get_List_1_MarkToBaseAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MarkToBaseAdjustmentRecords_Public_set_Void_List_1_MarkToBaseAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MarkToMarkAdjustmentRecords_Public_get_List_1_MarkToMarkAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MarkToMarkAdjustmentRecords_Public_set_Void_List_1_MarkToMarkAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortMarkToBaseAdjustmentRecords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortMarkToMarkAdjustmentRecords_Public_Void_0;

	public unsafe List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MultipleSubstitutionRecords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MultipleSubstitutionRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MultipleSubstitutionRecords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LigatureSubstitutionRecords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LigatureSubstitutionRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LigatureSubstitutionRecords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GlyphPairAdjustmentRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MarkToBaseAdjustmentRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MarkToMarkAdjustmentRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, List<LigatureSubstitutionRecord>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, GlyphPairAdjustmentRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, MarkToBaseAdjustmentRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, MarkToMarkAdjustmentRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<MultipleSubstitutionRecord> multipleSubstitutionRecords
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_multipleSubstitutionRecords_Public_get_List_1_MultipleSubstitutionRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MultipleSubstitutionRecord>>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_multipleSubstitutionRecords_Public_set_Void_List_1_MultipleSubstitutionRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<LigatureSubstitutionRecord> ligatureRecords
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ligatureRecords_Public_get_List_1_LigatureSubstitutionRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LigatureSubstitutionRecord>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ligatureRecords_Public_set_Void_List_1_LigatureSubstitutionRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GlyphPairAdjustmentRecord>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MarkToBaseAdjustmentRecords_Public_get_List_1_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MarkToBaseAdjustmentRecords_Public_set_Void_List_1_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MarkToMarkAdjustmentRecords_Public_get_List_1_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MarkToMarkAdjustmentRecords_Public_set_Void_List_1_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static TMP_FontFeatureTable()
	{
		Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontFeatureTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr);
		NativeFieldInfoPtr_m_MultipleSubstitutionRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_MultipleSubstitutionRecords");
		NativeFieldInfoPtr_m_LigatureSubstitutionRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_LigatureSubstitutionRecords");
		NativeFieldInfoPtr_m_GlyphPairAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecords");
		NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_MarkToBaseAdjustmentRecords");
		NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_MarkToMarkAdjustmentRecords");
		NativeFieldInfoPtr_m_LigatureSubstitutionRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_LigatureSubstitutionRecordLookup");
		NativeFieldInfoPtr_m_GlyphPairAdjustmentRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_GlyphPairAdjustmentRecordLookup");
		NativeFieldInfoPtr_m_MarkToBaseAdjustmentRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_MarkToBaseAdjustmentRecordLookup");
		NativeFieldInfoPtr_m_MarkToMarkAdjustmentRecordLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, "m_MarkToMarkAdjustmentRecordLookup");
		NativeMethodInfoPtr_get_multipleSubstitutionRecords_Public_get_List_1_MultipleSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_set_multipleSubstitutionRecords_Public_set_Void_List_1_MultipleSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_get_ligatureRecords_Public_get_List_1_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_set_ligatureRecords_Public_set_Void_List_1_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_get_glyphPairAdjustmentRecords_Public_get_List_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_set_glyphPairAdjustmentRecords_Public_set_Void_List_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_get_MarkToBaseAdjustmentRecords_Public_get_List_1_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_set_MarkToBaseAdjustmentRecords_Public_set_Void_List_1_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_get_MarkToMarkAdjustmentRecords_Public_get_List_1_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_set_MarkToMarkAdjustmentRecords_Public_set_Void_List_1_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_SortMarkToBaseAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_SortMarkToMarkAdjustmentRecords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr, 100664053);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1124605, RefRangeEnd = 1124608, XrefRangeStart = 1124548, XrefRangeEnd = 1124605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_FontFeatureTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontFeatureTable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1124647, RefRangeEnd = 1124649, XrefRangeStart = 1124608, XrefRangeEnd = 1124647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortGlyphPairAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortGlyphPairAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1124688, RefRangeEnd = 1124690, XrefRangeStart = 1124649, XrefRangeEnd = 1124688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortMarkToBaseAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortMarkToBaseAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1124729, RefRangeEnd = 1124731, XrefRangeStart = 1124690, XrefRangeEnd = 1124729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortMarkToMarkAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortMarkToMarkAdjustmentRecords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_FontFeatureTable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
