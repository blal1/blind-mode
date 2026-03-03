using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions;

public class Regex : Object
{
	public sealed class CachedCodeEntryKey : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__options;

		private static readonly System.IntPtr NativeFieldInfoPtr__cultureKey;

		private static readonly System.IntPtr NativeFieldInfoPtr__pattern;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RegexOptions_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedCodeEntryKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CachedCodeEntryKey_CachedCodeEntryKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		public unsafe RegexOptions _options
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__options);
				return *(RegexOptions*)num;
			}
			set
			{
				*(RegexOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__options)) = value;
			}
		}

		public unsafe string _cultureKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cultureKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cultureKey)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string _pattern
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pattern)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static CachedCodeEntryKey()
		{
			Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Regex>.NativeClassPtr, "CachedCodeEntryKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr);
			NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, "_options");
			NativeFieldInfoPtr__cultureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, "_cultureKey");
			NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, "_pattern");
			NativeMethodInfoPtr__ctor_Public_Void_RegexOptions_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, 100664564);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, 100664565);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedCodeEntryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, 100664566);
			NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CachedCodeEntryKey_CachedCodeEntryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, 100664567);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, 100664568);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&options);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cultureKey);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RegexOptions_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872492, XrefRangeEnd = 872497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872497, XrefRangeEnd = 872499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(CachedCodeEntryKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedCodeEntryKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872499, XrefRangeEnd = 872501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CachedCodeEntryKey left, CachedCodeEntryKey right)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)left));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)right));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CachedCodeEntryKey_CachedCodeEntryKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public CachedCodeEntryKey(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CachedCodeEntryKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr))
		{
		}
	}

	public sealed class CachedCodeEntry : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Next;

		private static readonly System.IntPtr NativeFieldInfoPtr_Previous;

		private static readonly System.IntPtr NativeFieldInfoPtr_Key;

		private static readonly System.IntPtr NativeFieldInfoPtr_Code;

		private static readonly System.IntPtr NativeFieldInfoPtr_Caps;

		private static readonly System.IntPtr NativeFieldInfoPtr_Capnames;

		private static readonly System.IntPtr NativeFieldInfoPtr_Capslist;

		private static readonly System.IntPtr NativeFieldInfoPtr_Capsize;

		private static readonly System.IntPtr NativeFieldInfoPtr_Runnerref;

		private static readonly System.IntPtr NativeFieldInfoPtr_ReplRef;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CachedCodeEntryKey_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_WeakReference_1_RegexReplacement_0;

		public unsafe CachedCodeEntry Next
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CachedCodeEntry Previous
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Previous);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Previous)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CachedCodeEntryKey Key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Key);
				return new CachedCodeEntryKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Key), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CachedCodeEntryKey>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe RegexCode Code
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Code);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexCode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Code)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Hashtable Caps
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Caps);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Caps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Hashtable Capnames
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capnames);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capnames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStringArray Capslist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capslist);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capslist)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int Capsize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capsize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capsize)) = value;
			}
		}

		public unsafe ExclusiveReference Runnerref
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Runnerref);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Runnerref)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe WeakReference<RegexReplacement> ReplRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReplRef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeakReference<RegexReplacement>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReplRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CachedCodeEntry()
		{
			Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Regex>.NativeClassPtr, "CachedCodeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr);
			NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Next");
			NativeFieldInfoPtr_Previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Previous");
			NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Key");
			NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Code");
			NativeFieldInfoPtr_Caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Caps");
			NativeFieldInfoPtr_Capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Capnames");
			NativeFieldInfoPtr_Capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Capslist");
			NativeFieldInfoPtr_Capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Capsize");
			NativeFieldInfoPtr_Runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "Runnerref");
			NativeFieldInfoPtr_ReplRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "ReplRef");
			NativeMethodInfoPtr__ctor_Public_Void_CachedCodeEntryKey_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_WeakReference_1_RegexReplacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, 100664569);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872501, XrefRangeEnd = 872509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, Il2CppStringArray capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capnames);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capslist);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)code);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caps);
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &capsize;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)runner);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)replref);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CachedCodeEntryKey_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_WeakReference_1_RegexReplacement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CachedCodeEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CacheDictionarySwitchLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cacheSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cache;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cacheCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cacheFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_cacheLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_maximumMatchTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultMatchTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_InfiniteMatchTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalMatchTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxOptionShift;

	private static readonly System.IntPtr NativeFieldInfoPtr_pattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_roptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_factory;

	private static readonly System.IntPtr NativeFieldInfoPtr_caps;

	private static readonly System.IntPtr NativeFieldInfoPtr_capnames;

	private static readonly System.IntPtr NativeFieldInfoPtr_capslist;

	private static readonly System.IntPtr NativeFieldInfoPtr_capsize;

	private static readonly System.IntPtr NativeFieldInfoPtr__runnerref;

	private static readonly System.IntPtr NativeFieldInfoPtr__replref;

	private static readonly System.IntPtr NativeFieldInfoPtr__code;

	private static readonly System.IntPtr NativeFieldInfoPtr__refsInitialized;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedCode_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedCodeEntryInternal_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillCacheDictionary_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCacheValue_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCacheValueSmall_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookupCachedAndPromote_Private_Static_CachedCodeEntry_CachedCodeEntryKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Match_Public_Match_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Match_Public_Match_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Private_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Private_Static_Il2CppStringArray_Regex_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Escape_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeReferences_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseOptionR_FamOrAssem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0;

	public unsafe static int CacheDictionarySwitchLimit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CacheDictionarySwitchLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CacheDictionarySwitchLimit, (void*)(&value));
		}
	}

	public unsafe static int s_cacheSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cacheSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cacheSize, (void*)(&value));
		}
	}

	public unsafe static Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CachedCodeEntryKey, CachedCodeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_cacheCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cacheCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cacheCount, (void*)(&value));
		}
	}

	public unsafe static CachedCodeEntry s_cacheFirst
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cacheFirst, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cacheFirst, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CachedCodeEntry s_cacheLast
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_cacheLast, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_cacheLast, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TimeSpan s_maximumMatchTimeout
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_maximumMatchTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_maximumMatchTimeout, (void*)(&value));
		}
	}

	public unsafe static string DefaultMatchTimeout_ConfigKeyName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static TimeSpan s_defaultMatchTimeout
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_defaultMatchTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_defaultMatchTimeout, (void*)(&value));
		}
	}

	public unsafe static TimeSpan InfiniteMatchTimeout
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&value));
		}
	}

	public unsafe TimeSpan internalMatchTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalMatchTimeout);
			return *(TimeSpan*)num;
		}
		set
		{
			*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalMatchTimeout)) = value;
		}
	}

	public unsafe static int MaxOptionShift
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxOptionShift, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxOptionShift, (void*)(&value));
		}
	}

	public unsafe string pattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe RegexOptions roptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roptions);
			return *(RegexOptions*)num;
		}
		set
		{
			*(RegexOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roptions)) = value;
		}
	}

	public unsafe RegexRunnerFactory factory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexRunnerFactory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable caps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable capnames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capnames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capnames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray capslist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capslist);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capslist)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int capsize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capsize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capsize)) = value;
		}
	}

	public unsafe ExclusiveReference _runnerref
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runnerref);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runnerref)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe WeakReference<RegexReplacement> _replref
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__replref);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeakReference<RegexReplacement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__replref)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RegexCode _code
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__code);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexCode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__code)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _refsInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__refsInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__refsInitialized)) = value;
		}
	}

	public unsafe bool RightToLeft
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 873184, RefRangeEnd = 873187, XrefRangeStart = 873184, XrefRangeEnd = 873184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Regex()
	{
		Il2CppClassPointerStore<Regex>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Regex");
		NativeFieldInfoPtr_CacheDictionarySwitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "CacheDictionarySwitchLimit");
		NativeFieldInfoPtr_s_cacheSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheSize");
		NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cache");
		NativeFieldInfoPtr_s_cacheCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheCount");
		NativeFieldInfoPtr_s_cacheFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheFirst");
		NativeFieldInfoPtr_s_cacheLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheLast");
		NativeFieldInfoPtr_s_maximumMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_maximumMatchTimeout");
		NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "DefaultMatchTimeout_ConfigKeyName");
		NativeFieldInfoPtr_s_defaultMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_defaultMatchTimeout");
		NativeFieldInfoPtr_InfiniteMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "InfiniteMatchTimeout");
		NativeFieldInfoPtr_internalMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "internalMatchTimeout");
		NativeFieldInfoPtr_MaxOptionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "MaxOptionShift");
		NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "pattern");
		NativeFieldInfoPtr_roptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "roptions");
		NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "factory");
		NativeFieldInfoPtr_caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "caps");
		NativeFieldInfoPtr_capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capnames");
		NativeFieldInfoPtr_capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capslist");
		NativeFieldInfoPtr_capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capsize");
		NativeFieldInfoPtr__runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_runnerref");
		NativeFieldInfoPtr__replref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_replref");
		NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_code");
		NativeFieldInfoPtr__refsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_refsInitialized");
		NativeMethodInfoPtr_GetCachedCode_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr_GetCachedCodeEntryInternal_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr_FillCacheDictionary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_TryGetCacheValue_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_TryGetCacheValueSmall_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_LookupCachedAndPromote_Private_Static_CachedCodeEntry_CachedCodeEntryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_Match_Public_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_Match_Public_Match_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664529);
		NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_Replace_Private_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_Split_Private_Static_Il2CppStringArray_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_Escape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_InitializeReferences_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_UseOptionR_FamOrAssem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664563);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872509, XrefRangeEnd = 872521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isToAdd;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCachedCode_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872608, RefRangeEnd = 872609, XrefRangeStart = 872521, XrefRangeEnd = 872608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isToAdd;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCachedCodeEntryInternal_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872609, XrefRangeEnd = 872624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillCacheDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillCacheDictionary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872624, XrefRangeEnd = 872631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCacheValue_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		entry = ((num3 == 0) ? null : new CachedCodeEntry(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872639, RefRangeEnd = 872640, XrefRangeStart = 872631, XrefRangeEnd = 872639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCacheValueSmall_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		entry = ((num3 == 0) ? null : new CachedCodeEntry(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872650, RefRangeEnd = 872651, XrefRangeStart = 872640, XrefRangeEnd = 872650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookupCachedAndPromote_Private_Static_CachedCodeEntry_CachedCodeEntryKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 872656, RefRangeEnd = 872663, XrefRangeStart = 872651, XrefRangeEnd = 872656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMatch(string input, string pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872668, RefRangeEnd = 872669, XrefRangeStart = 872663, XrefRangeEnd = 872668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMatch(string input, string pattern, RegexOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 872675, RefRangeEnd = 872677, XrefRangeStart = 872669, XrefRangeEnd = 872675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 872679, RefRangeEnd = 872692, XrefRangeStart = 872677, XrefRangeEnd = 872679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsMatch(string input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872692, XrefRangeEnd = 872693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsMatch(string input, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 872703, RefRangeEnd = 872729, XrefRangeStart = 872693, XrefRangeEnd = 872703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Match Match(string input, string pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872729, XrefRangeEnd = 872735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 872737, RefRangeEnd = 872742, XrefRangeStart = 872735, XrefRangeEnd = 872737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Match Match(string input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Match_Public_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872743, RefRangeEnd = 872744, XrefRangeStart = 872742, XrefRangeEnd = 872743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Match Match(string input, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Match_Public_Match_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 872749, RefRangeEnd = 872769, XrefRangeStart = 872744, XrefRangeEnd = 872749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MatchCollection Matches(string input, string pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872787, RefRangeEnd = 872788, XrefRangeStart = 872769, XrefRangeEnd = 872787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 872802, RefRangeEnd = 872804, XrefRangeStart = 872788, XrefRangeEnd = 872802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MatchCollection Matches(string input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 872817, RefRangeEnd = 872819, XrefRangeStart = 872804, XrefRangeEnd = 872817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MatchCollection Matches(string input, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr2) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 872830, RefRangeEnd = 872845, XrefRangeStart = 872819, XrefRangeEnd = 872830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Replace(string input, string pattern, string replacement)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872845, XrefRangeEnd = 872865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		*(RegexOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872868, RefRangeEnd = 872869, XrefRangeStart = 872865, XrefRangeEnd = 872868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(string input, string replacement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872869, XrefRangeEnd = 872884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(string input, string replacement, int count, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 872897, RefRangeEnd = 872900, XrefRangeStart = 872884, XrefRangeEnd = 872897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Replace(string input, string pattern, MatchEvaluator evaluator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evaluator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872900, XrefRangeEnd = 872916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evaluator);
		*(RegexOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872916, XrefRangeEnd = 872921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(string input, MatchEvaluator evaluator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evaluator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872921, XrefRangeEnd = 872931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(string input, MatchEvaluator evaluator, int count, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evaluator);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 872962, RefRangeEnd = 872966, XrefRangeStart = 872931, XrefRangeEnd = 872962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evaluator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Private_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 872979, RefRangeEnd = 872980, XrefRangeStart = 872966, XrefRangeEnd = 872979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray Split(string input, string pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872980, XrefRangeEnd = 872996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872996, XrefRangeEnd = 873001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split(string input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873001, XrefRangeEnd = 873011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split(string input, int count, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 873060, RefRangeEnd = 873064, XrefRangeStart = 873011, XrefRangeEnd = 873060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray Split(Regex regex, string input, int count, int startat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Private_Static_Il2CppStringArray_Regex_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873082, RefRangeEnd = 873085, XrefRangeStart = 873064, XrefRangeEnd = 873082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateMatchTimeout(TimeSpan matchTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&matchTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873085, XrefRangeEnd = 873096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TimeSpan InitDefaultMatchTimeout()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873096, XrefRangeEnd = 873101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Regex()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 873106, RefRangeEnd = 873118, XrefRangeStart = 873101, XrefRangeEnd = 873106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Regex(string pattern)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 873123, RefRangeEnd = 873132, XrefRangeStart = 873118, XrefRangeEnd = 873123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Regex(string pattern, RegexOptions options)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873132, XrefRangeEnd = 873137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo si, StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)si);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 873160, RefRangeEnd = 873172, XrefRangeStart = 873137, XrefRangeEnd = 873160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(RegexOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchTimeout;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToCache;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 873182, RefRangeEnd = 873184, XrefRangeStart = 873172, XrefRangeEnd = 873182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Escape(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Escape_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873187, XrefRangeEnd = 873193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GroupNameFromNumber(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873193, XrefRangeEnd = 873196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GroupNumberFromName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873196, XrefRangeEnd = 873214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeReferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeReferences_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 873237, RefRangeEnd = 873252, XrefRangeStart = 873214, XrefRangeEnd = 873237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&quick);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prevlen;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &beginning;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 873184, RefRangeEnd = 873187, XrefRangeStart = 873184, XrefRangeEnd = 873187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseOptionR()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseOptionR_FamOrAssem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool UseOptionInvariant()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Regex(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
