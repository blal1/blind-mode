using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO.Enumeration;

public static class FileSystemName : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_wildcardChars;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_simpleWildcardChars;

	private static readonly System.IntPtr NativeMethodInfoPtr_TranslateWin32Expression_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesWin32Expression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchesSimpleExpression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchPattern_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_Boolean_0;

	public unsafe static Il2CppStructArray<char> s_wildcardChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_wildcardChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_wildcardChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> s_simpleWildcardChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_simpleWildcardChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_simpleWildcardChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static FileSystemName()
	{
		Il2CppClassPointerStore<FileSystemName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemName");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr);
		NativeFieldInfoPtr_s_wildcardChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, "s_wildcardChars");
		NativeFieldInfoPtr_s_simpleWildcardChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, "s_simpleWildcardChars");
		NativeMethodInfoPtr_TranslateWin32Expression_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100675195);
		NativeMethodInfoPtr_MatchesWin32Expression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100675196);
		NativeMethodInfoPtr_MatchesSimpleExpression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100675197);
		NativeMethodInfoPtr_MatchPattern_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemName>.NativeClassPtr, 100675198);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 840393, RefRangeEnd = 840394, XrefRangeStart = 840359, XrefRangeEnd = 840393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TranslateWin32Expression(string expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TranslateWin32Expression_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 840394, XrefRangeEnd = 840398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)expression));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesWin32Expression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 840398, XrefRangeEnd = 840402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)expression));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchesSimpleExpression_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 840467, RefRangeEnd = 840470, XrefRangeStart = 840402, XrefRangeEnd = 840467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)expression));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)name));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useExtendedWildcards;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchPattern_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FileSystemName(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
