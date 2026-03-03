using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro;

public class TMP_TextParsingUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LookupStringL;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LookupStringU;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EmojiLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EmojiPresentationFormLookup;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDiacriticalMark_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBaseGlyph_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIgnorableForLigature_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmoji_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmojiPresentationForm_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TMP_TextParsingUtilities s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_TextParsingUtilities>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string k_LookupStringL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LookupStringL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LookupStringL, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_LookupStringU
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LookupStringU, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LookupStringU, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static HashSet<uint> k_EmojiLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EmojiLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EmojiLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HashSet<uint> k_EmojiPresentationFormLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EmojiPresentationFormLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EmojiPresentationFormLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TMP_TextParsingUtilities instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133923, XrefRangeEnd = 1133927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_TextParsingUtilities>(intPtr2) : null;
		}
	}

	static TMP_TextParsingUtilities()
	{
		Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextParsingUtilities");
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_k_LookupStringL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_LookupStringL");
		NativeFieldInfoPtr_k_LookupStringU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_LookupStringU");
		NativeFieldInfoPtr_k_EmojiLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_EmojiLookup");
		NativeFieldInfoPtr_k_EmojiPresentationFormLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, "k_EmojiPresentationFormLookup");
		NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_TextParsingUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_IsDiacriticalMark_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_IsBaseGlyph_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_IsIgnorableForLigature_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_IsEmoji_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_IsEmojiPresentationForm_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr, 100664998);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1133935, RefRangeEnd = 1133939, XrefRangeStart = 1133927, XrefRangeEnd = 1133935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHashCode(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1133941, RefRangeEnd = 1133943, XrefRangeStart = 1133939, XrefRangeEnd = 1133941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHashCodeCaseSensitive(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCodeCaseSensitive_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133943, XrefRangeEnd = 1133946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToLowerASCIIFast(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1133949, RefRangeEnd = 1133953, XrefRangeStart = 1133946, XrefRangeEnd = 1133949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToUpperASCIIFast(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1133956, RefRangeEnd = 1133959, XrefRangeStart = 1133953, XrefRangeEnd = 1133956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUpperASCIIFast(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133959, XrefRangeEnd = 1133962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToLowerASCIIFast(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLowerASCIIFast_Public_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsHighSurrogate(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsLowSurrogate(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1133962, RefRangeEnd = 1133963, XrefRangeStart = 1133962, XrefRangeEnd = 1133962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&highSurrogate);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowSurrogate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToUTF32_Internal_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsDiacriticalMark(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDiacriticalMark_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1133963, RefRangeEnd = 1133966, XrefRangeStart = 1133963, XrefRangeEnd = 1133963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBaseGlyph(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBaseGlyph_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1133966, RefRangeEnd = 1133968, XrefRangeStart = 1133966, XrefRangeEnd = 1133966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIgnorableForLigature(uint cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIgnorableForLigature_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1133976, RefRangeEnd = 1133978, XrefRangeStart = 1133968, XrefRangeEnd = 1133976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEmoji(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmoji_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1133986, RefRangeEnd = 1133988, XrefRangeStart = 1133978, XrefRangeEnd = 1133986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEmojiPresentationForm(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmojiPresentationForm_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1133988, RefRangeEnd = 1133991, XrefRangeStart = 1133988, XrefRangeEnd = 1133988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHangul(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1133991, RefRangeEnd = 1133997, XrefRangeStart = 1133991, XrefRangeEnd = 1133991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCJK(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_TextParsingUtilities()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextParsingUtilities>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_TextParsingUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
