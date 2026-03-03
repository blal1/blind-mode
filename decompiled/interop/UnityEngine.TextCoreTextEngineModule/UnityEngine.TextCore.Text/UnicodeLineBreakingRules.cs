using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

[System.Serializable]
public class UnicodeLineBreakingRules : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnicodeLineBreakingRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LeadingCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FollowingCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LeadingCharactersLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FollowingCharactersLookup;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leadingCharactersLookup_Internal_get_HashSet_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_followingCharactersLookup_Internal_get_HashSet_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UnityEngine.TextAsset m_UnicodeLineBreakingRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnicodeLineBreakingRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.TextAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnicodeLineBreakingRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UnityEngine.TextAsset m_LeadingCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LeadingCharacters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.TextAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LeadingCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UnityEngine.TextAsset m_FollowingCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FollowingCharacters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.TextAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FollowingCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_UseModernHangulLineBreakingRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
		}
	}

	public unsafe HashSet<uint> m_LeadingCharactersLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LeadingCharactersLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LeadingCharactersLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<uint> m_FollowingCharactersLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FollowingCharactersLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FollowingCharactersLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<uint> leadingCharactersLookup
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1284803, RefRangeEnd = 1284810, XrefRangeStart = 1284802, XrefRangeEnd = 1284803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leadingCharactersLookup_Internal_get_HashSet_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
		}
	}

	public unsafe HashSet<uint> followingCharactersLookup
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1284811, RefRangeEnd = 1284812, XrefRangeStart = 1284810, XrefRangeEnd = 1284811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_followingCharactersLookup_Internal_get_HashSet_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
		}
	}

	public unsafe bool useModernHangulLineBreakingRules
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_UseModernHangulLineBreakingRules = value;
		}
	}

	public UnityEngine.TextAsset lineBreakingRules => m_UnicodeLineBreakingRules;

	public UnityEngine.TextAsset leadingCharacters => m_LeadingCharacters;

	public UnityEngine.TextAsset followingCharacters => m_FollowingCharacters;

	static UnicodeLineBreakingRules()
	{
		Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "UnicodeLineBreakingRules");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr);
		NativeFieldInfoPtr_m_UnicodeLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_UnicodeLineBreakingRules");
		NativeFieldInfoPtr_m_LeadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_LeadingCharacters");
		NativeFieldInfoPtr_m_FollowingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_FollowingCharacters");
		NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
		NativeFieldInfoPtr_m_LeadingCharactersLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_LeadingCharactersLookup");
		NativeFieldInfoPtr_m_FollowingCharactersLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_FollowingCharactersLookup");
		NativeMethodInfoPtr_get_leadingCharactersLookup_Internal_get_HashSet_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_get_followingCharactersLookup_Internal_get_HashSet_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100664048);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1284852, RefRangeEnd = 1284858, XrefRangeStart = 1284812, XrefRangeEnd = 1284852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLineBreakingRules()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1284870, RefRangeEnd = 1284872, XrefRangeStart = 1284858, XrefRangeEnd = 1284870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<uint> GetCharacters(UnityEngine.TextAsset file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)file);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnicodeLineBreakingRules()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnicodeLineBreakingRules(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void LoadLineBreakingRules(UnityEngine.TextAsset leadingRules, UnityEngine.TextAsset followingRules)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
