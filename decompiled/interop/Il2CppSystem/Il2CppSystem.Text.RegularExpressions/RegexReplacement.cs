using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class RegexReplacement : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Specials;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftPortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightPortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_WholeString;

	private static readonly System.IntPtr NativeFieldInfoPtr__strings;

	private static readonly System.IntPtr NativeFieldInfoPtr__rules;

	private static readonly System.IntPtr NativeFieldInfoPtr__Pattern_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RegexNode_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_RegexReplacement_WeakReference_1_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Pattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replacement_Public_String_Match_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_Regex_String_Int32_Int32_0;

	public unsafe static int Specials
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Specials, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Specials, (void*)(&value));
		}
	}

	public unsafe static int LeftPortion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LeftPortion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LeftPortion, (void*)(&value));
		}
	}

	public unsafe static int RightPortion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RightPortion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RightPortion, (void*)(&value));
		}
	}

	public unsafe static int LastGroup
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LastGroup, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LastGroup, (void*)(&value));
		}
	}

	public unsafe static int WholeString
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WholeString, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WholeString, (void*)(&value));
		}
	}

	public unsafe List<string> _strings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__strings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__strings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> _rules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _Pattern_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Pattern_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Pattern_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string Pattern
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static RegexReplacement()
	{
		Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexReplacement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr);
		NativeFieldInfoPtr_Specials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "Specials");
		NativeFieldInfoPtr_LeftPortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "LeftPortion");
		NativeFieldInfoPtr_RightPortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "RightPortion");
		NativeFieldInfoPtr_LastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "LastGroup");
		NativeFieldInfoPtr_WholeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "WholeString");
		NativeFieldInfoPtr__strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_strings");
		NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "_rules");
		NativeFieldInfoPtr__Pattern_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, "<Pattern>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_String_RegexNode_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664794);
		NativeMethodInfoPtr_GetOrCreate_Public_Static_RegexReplacement_WeakReference_1_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664795);
		NativeMethodInfoPtr_get_Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664796);
		NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664797);
		NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664798);
		NativeMethodInfoPtr_Replacement_Public_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664799);
		NativeMethodInfoPtr_Replace_Public_String_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664800);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 876678, RefRangeEnd = 876680, XrefRangeStart = 876615, XrefRangeEnd = 876678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rep);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)concat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_caps);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_RegexNode_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 876710, RefRangeEnd = 876715, XrefRangeStart = 876680, XrefRangeEnd = 876710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)replRef);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caps);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capsize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capnames);
		*(RegexOptions**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &roptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreate_Public_Static_RegexReplacement_WeakReference_1_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexReplacement>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876715, XrefRangeEnd = 876733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplacementImpl(StringBuilder sb, Match match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplacementImpl_Private_Void_StringBuilder_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876733, XrefRangeEnd = 876754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplacementImplRTL(List<string> al, Match match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)al);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplacementImplRTL_Private_Void_List_1_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 876775, RefRangeEnd = 876776, XrefRangeStart = 876754, XrefRangeEnd = 876775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replacement(Match match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replacement_Public_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 876847, RefRangeEnd = 876851, XrefRangeStart = 876776, XrefRangeEnd = 876847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(Regex regex, string input, int count, int startat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_Regex_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public RegexReplacement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
