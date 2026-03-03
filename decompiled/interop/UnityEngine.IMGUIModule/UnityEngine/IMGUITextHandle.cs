using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

public class IMGUITextHandle : TextHandle
{
	public class TextHandleTuple : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr_hashCode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;

		public unsafe float lastTimeUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeUsed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeUsed)) = value;
			}
		}

		public unsafe int hashCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCode);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		static TextHandleTuple()
		{
			Il2CppClassPointerStore<TextHandleTuple>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "TextHandleTuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextHandleTuple>.NativeClassPtr);
			NativeFieldInfoPtr_lastTimeUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandleTuple>.NativeClassPtr, "lastTimeUsed");
			NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandleTuple>.NativeClassPtr, "hashCode");
			NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTuple>.NativeClassPtr, 100663762);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248305, XrefRangeEnd = 1248306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextHandleTuple(float lastTimeUsed, int hashCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextHandleTuple>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&lastTimeUsed);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashCode;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TextHandleTuple(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tuple;

	private static readonly System.IntPtr NativeFieldInfoPtr_textHandles;

	private static readonly System.IntPtr NativeFieldInfoPtr_textHandlesTuple;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCleanupTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_newHandlesSinceCleanup;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCachedOnNative;

	private static readonly System.IntPtr NativeMethodInfoPtr_EmptyManagedCache_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextHandle_Internal_Static_IMGUITextHandle_GUIStyle_Rect_String_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextHandle_Internal_Static_IMGUITextHandle_GUIStyle_Rect_String_Color32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldCleanup_Private_Static_Boolean_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearUnusedTextHandles_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextHandle_Private_Static_IMGUITextHandle_TextGenerationSettings_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLineHeight_Internal_Static_Single_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredSize_Internal_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertGUIStyleToGenerationSettings_Private_Static_Void_TextGenerationSettings_GUIStyle_Color_String_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LegacyClippingToNewOverflow_Private_Static_TextOverflowMode_TextClipping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public const float sFallbackFontSize = 13f;

	public const float sTimeToFlush = 5f;

	public const float sTimeBetweenCleanupRuns = 30f;

	public const int sNewHandlesBetweenCleanupRuns = 500;

	public unsafe LinkedListNode<TextHandleTuple> tuple
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuple);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LinkedListNode<TextHandleTuple>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuple)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, IMGUITextHandle> textHandles
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textHandles, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, IMGUITextHandle>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textHandles, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LinkedList<TextHandleTuple> textHandlesTuple
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textHandlesTuple, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LinkedList<TextHandleTuple>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textHandlesTuple, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static float lastCleanupTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastCleanupTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastCleanupTime, (void*)(&value));
		}
	}

	public unsafe static int newHandlesSinceCleanup
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_newHandlesSinceCleanup, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_newHandlesSinceCleanup, (void*)(&value));
		}
	}

	public unsafe bool isCachedOnNative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCachedOnNative);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCachedOnNative)) = value;
		}
	}

	static IMGUITextHandle()
	{
		Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "IMGUITextHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr);
		NativeFieldInfoPtr_tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "tuple");
		NativeFieldInfoPtr_textHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "textHandles");
		NativeFieldInfoPtr_textHandlesTuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "textHandlesTuple");
		NativeFieldInfoPtr_lastCleanupTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "lastCleanupTime");
		NativeFieldInfoPtr_newHandlesSinceCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "newHandlesSinceCleanup");
		NativeFieldInfoPtr_isCachedOnNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, "isCachedOnNative");
		NativeMethodInfoPtr_EmptyManagedCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr_GetTextHandle_Internal_Static_IMGUITextHandle_GUIStyle_Rect_String_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr_GetTextHandle_Internal_Static_IMGUITextHandle_GUIStyle_Rect_String_Color32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663752);
		NativeMethodInfoPtr_ShouldCleanup_Private_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_ClearUnusedTextHandles_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_GetTextHandle_Private_Static_IMGUITextHandle_TextGenerationSettings_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_GetLineHeight_Internal_Static_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_GetPreferredSize_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr_ConvertGUIStyleToGenerationSettings_Private_Static_Void_TextGenerationSettings_GUIStyle_Color_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr_LegacyClippingToNewOverflow_Private_Static_TextOverflowMode_TextClipping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663759);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr, 100663760);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248306, XrefRangeEnd = 1248318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EmptyManagedCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EmptyManagedCache_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1248328, RefRangeEnd = 1248333, XrefRangeStart = 1248318, XrefRangeEnd = 1248328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextHandle_Internal_Static_IMGUITextHandle_GUIStyle_Rect_String_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMGUITextHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248333, XrefRangeEnd = 1248343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textColor;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isCached);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextHandle_Internal_Static_IMGUITextHandle_GUIStyle_Rect_String_Color32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMGUITextHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&currentTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastTime;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cleanupThreshold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldCleanup_Private_Static_Boolean_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248377, RefRangeEnd = 1248378, XrefRangeStart = 1248343, XrefRangeEnd = 1248377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearUnusedTextHandles()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearUnusedTextHandles_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1248438, RefRangeEnd = 1248441, XrefRangeStart = 1248378, XrefRangeEnd = 1248438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMGUITextHandle GetTextHandle(UnityEngine.TextCore.Text.TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCalledFromNative;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isCached);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextHandle_Private_Static_IMGUITextHandle_TextGenerationSettings_Boolean_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMGUITextHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248441, XrefRangeEnd = 1248454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetLineHeight(GUIStyle style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLineHeight_Internal_Static_Single_GUIStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector2 GetPreferredSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredSize_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1248557, RefRangeEnd = 1248562, XrefRangeStart = 1248454, XrefRangeEnd = 1248557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertGUIStyleToGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(Rect**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertGUIStyleToGenerationSettings_Private_Static_Void_TextGenerationSettings_GUIStyle_Color_String_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&clipping);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LegacyClippingToNewOverflow_Private_Static_TextOverflowMode_TextClipping_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextOverflowMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248562, XrefRangeEnd = 1248566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IMGUITextHandle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMGUITextHandle>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IMGUITextHandle(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void EmptyCache()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetNumCharactersThatFitWithinWidth(float width)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppStructArray<Rect> GetHyperlinkRects(Rect content)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
