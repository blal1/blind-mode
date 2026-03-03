using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text;

public class TextSelectionService : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Substring_Internal_Static_String_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentWord_Internal_Static_Void_IntPtr_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousCodePointIndex_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextCodePointIndex_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorLogicalIndexFromPosition_Internal_Static_Int32_IntPtr_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPositionFromLogicalIndex_Internal_Static_Vector2_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineUpCharacterPosition_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineDownCharacterPosition_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHighlightRectangles_Internal_Static_Il2CppStructArray_1_Rect_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterHeightFromIndex_Internal_Static_Single_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStartOfNextWord_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEndOfPreviousWord_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstCharacterIndexOnLine_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastCharacterIndexOnLine_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLineHeight_Internal_Static_Single_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLineNumber_Internal_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToPreviousParagraph_Internal_Static_Void_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToStartOfParagraph_Internal_Static_Void_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToEndOfParagraph_Internal_Static_Void_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToNextParagraph_Internal_Static_Void_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentParagraph_Internal_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Substring_Injected_Private_Static_Void_IntPtr_Int32_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorLogicalIndexFromPosition_Injected_Private_Static_Int32_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPositionFromLogicalIndex_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHighlightRectangles_Injected_Private_Static_Void_IntPtr_Int32_Int32_byref_BlittableArrayWrapper_0;

	static TextSelectionService()
	{
		Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextSelectionService");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr);
		NativeMethodInfoPtr_Substring_Internal_Static_String_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr_SelectCurrentWord_Internal_Static_Void_IntPtr_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_PreviousCodePointIndex_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_NextCodePointIndex_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_GetCursorLogicalIndexFromPosition_Internal_Static_Int32_IntPtr_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_GetCursorPositionFromLogicalIndex_Internal_Static_Vector2_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_LineUpCharacterPosition_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_LineDownCharacterPosition_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_GetHighlightRectangles_Internal_Static_Il2CppStructArray_1_Rect_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_GetCharacterHeightFromIndex_Internal_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_GetStartOfNextWord_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_GetEndOfPreviousWord_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_GetFirstCharacterIndexOnLine_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr_GetLastCharacterIndexOnLine_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_GetLineHeight_Internal_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_GetLineNumber_Internal_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_SelectToPreviousParagraph_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr_SelectToStartOfParagraph_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_SelectToEndOfParagraph_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_SelectToNextParagraph_Internal_Static_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_SelectCurrentParagraph_Internal_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_Substring_Injected_Private_Static_Void_IntPtr_Int32_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_GetCursorLogicalIndexFromPosition_Injected_Private_Static_Int32_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_GetCursorPositionFromLogicalIndex_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_GetHighlightRectangles_Injected_Private_Static_Void_IntPtr_Int32_Int32_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectionService>.NativeClassPtr, 100663903);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1283078, RefRangeEnd = 1283079, XrefRangeStart = 1283073, XrefRangeEnd = 1283078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Substring(System.IntPtr textGenerationInfo, int startIndex, int endIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Substring_Internal_Static_String_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283079, XrefRangeEnd = 1283081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectCurrentWord(System.IntPtr textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref startIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref endIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectCurrentWord_Internal_Static_Void_IntPtr_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283081, XrefRangeEnd = 1283083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PreviousCodePointIndex(System.IntPtr textGenerationInfo, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousCodePointIndex_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283083, XrefRangeEnd = 1283085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NextCodePointIndex(System.IntPtr textGenerationInfo, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextCodePointIndex_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283085, XrefRangeEnd = 1283087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCursorLogicalIndexFromPosition(System.IntPtr textGenerationInfo, Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorLogicalIndexFromPosition_Internal_Static_Int32_IntPtr_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283087, XrefRangeEnd = 1283089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetCursorPositionFromLogicalIndex(System.IntPtr textGenerationInfo, int logicalIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logicalIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPositionFromLogicalIndex_Internal_Static_Vector2_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283089, XrefRangeEnd = 1283091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LineUpCharacterPosition(System.IntPtr textGenerationInfo, int originalPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalPos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineUpCharacterPosition_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283091, XrefRangeEnd = 1283093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LineDownCharacterPosition(System.IntPtr textGenerationInfo, int originalPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalPos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineDownCharacterPosition_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1283099, RefRangeEnd = 1283100, XrefRangeStart = 1283093, XrefRangeEnd = 1283099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Rect> GetHighlightRectangles(System.IntPtr textGenerationInfo, int cursorIndex, int selectIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cursorIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHighlightRectangles_Internal_Static_Il2CppStructArray_1_Rect_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283100, XrefRangeEnd = 1283102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetCharacterHeightFromIndex(System.IntPtr textGenerationInfo, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterHeightFromIndex_Internal_Static_Single_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283102, XrefRangeEnd = 1283104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetStartOfNextWord(System.IntPtr textGenerationInfo, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStartOfNextWord_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283104, XrefRangeEnd = 1283106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetEndOfPreviousWord(System.IntPtr textGenerationInfo, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEndOfPreviousWord_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283106, XrefRangeEnd = 1283108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFirstCharacterIndexOnLine(System.IntPtr textGenerationInfo, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstCharacterIndexOnLine_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283108, XrefRangeEnd = 1283110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLastCharacterIndexOnLine(System.IntPtr textGenerationInfo, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastCharacterIndexOnLine_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283110, XrefRangeEnd = 1283112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetLineHeight(System.IntPtr textGenerationInfo, int lineIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLineHeight_Internal_Static_Single_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283112, XrefRangeEnd = 1283114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLineNumber(System.IntPtr textGenerationInfo, int logicalIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logicalIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLineNumber_Internal_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283114, XrefRangeEnd = 1283116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectToPreviousParagraph(System.IntPtr textGenerationInfo, ref int cursorIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cursorIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToPreviousParagraph_Internal_Static_Void_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283116, XrefRangeEnd = 1283118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectToStartOfParagraph(System.IntPtr textGenerationInfo, ref int cursorIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cursorIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToStartOfParagraph_Internal_Static_Void_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283118, XrefRangeEnd = 1283120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectToEndOfParagraph(System.IntPtr textGenerationInfo, ref int cursorIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cursorIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToEndOfParagraph_Internal_Static_Void_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283120, XrefRangeEnd = 1283122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectToNextParagraph(System.IntPtr textGenerationInfo, ref int cursorIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cursorIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToNextParagraph_Internal_Static_Void_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283122, XrefRangeEnd = 1283124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectCurrentParagraph(System.IntPtr textGenerationInfo, ref int cursorIndex, ref int selectIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&textGenerationInfo);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cursorIndex);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref selectIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectCurrentParagraph_Internal_Static_Void_IntPtr_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283124, XrefRangeEnd = 1283126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Substring_Injected(System.IntPtr textGenerationInfo, int startIndex, int endIndex, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endIndex;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Substring_Injected_Private_Static_Void_IntPtr_Int32_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283126, XrefRangeEnd = 1283128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCursorLogicalIndexFromPosition_Injected(System.IntPtr textGenerationInfo, [In] ref Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textGenerationInfo);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorLogicalIndexFromPosition_Injected_Private_Static_Int32_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283128, XrefRangeEnd = 1283130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCursorPositionFromLogicalIndex_Injected(System.IntPtr textGenerationInfo, int logicalIndex, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logicalIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPositionFromLogicalIndex_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283130, XrefRangeEnd = 1283132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetHighlightRectangles_Injected(System.IntPtr textGenerationInfo, int cursorIndex, int selectIndex, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&textGenerationInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cursorIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectIndex;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHighlightRectangles_Injected_Private_Static_Void_IntPtr_Int32_Int32_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextSelectionService(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
