using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class TextGenerator : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TextGenerator_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663336);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(TextGenerator textGenerator)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textGenerator);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TextGenerator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate int get_vertexCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_fontSizeUsedForBestFit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetVerticesArray_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetCharactersArray_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetLinesArray_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastString;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasGenerated;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Verts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Characters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Lines;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedVerts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedLines;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterCountVisible_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidatedSettings_Private_TextGenerationSettings_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invalidate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacters_Public_Void_List_1_UICharInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLines_Public_Void_List_1_UILineInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertices_Public_Void_List_1_UIVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredWidth_Public_Single_String_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredHeight_Public_Single_String_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateWithErrors_Public_Boolean_String_TextGenerationSettings_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Public_Boolean_String_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateWithError_Private_TextGenerationError_String_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateAlways_Private_TextGenerationError_String_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_verts_Public_get_IList_1_UIVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characters_Public_get_IList_1_UICharInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lines_Public_get_IList_1_UILineInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rectExtents_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lineCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_VerticalWrapMode_HorizontalWrapMode_Boolean_TextAnchor_Vector2_Vector2_Boolean_Boolean_byref_TextGenerationError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVerticesInternal_Private_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharactersInternal_Private_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLinesInternal_Private_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rectExtents_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lineCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Internal_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_byref_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVerticesInternal_Injected_Private_Static_Void_IntPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharactersInternal_Injected_Private_Static_Void_IntPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLinesInternal_Injected_Private_Static_Void_IntPtr_Object_0;

	private static readonly get_vertexCount_InjectedDelegate get_vertexCount_InjectedDelegateField;

	private static readonly get_fontSizeUsedForBestFit_InjectedDelegate get_fontSizeUsedForBestFit_InjectedDelegateField;

	private static readonly GetVerticesArray_InjectedDelegate GetVerticesArray_InjectedDelegateField;

	private static readonly GetCharactersArray_InjectedDelegate GetCharactersArray_InjectedDelegateField;

	private static readonly GetLinesArray_InjectedDelegate GetLinesArray_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe string m_LastString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TextGenerationSettings m_LastSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastSettings);
			return new TextGenerationSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_HasGenerated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasGenerated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasGenerated)) = value;
		}
	}

	public unsafe TextGenerationError m_LastValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastValid);
			return *(TextGenerationError*)num;
		}
		set
		{
			*(TextGenerationError*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastValid)) = value;
		}
	}

	public unsafe List<UIVertex> m_Verts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Verts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UIVertex>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Verts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<UICharInfo> m_Characters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Characters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UICharInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Characters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<UILineInfo> m_Lines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Lines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UILineInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Lines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_CachedVerts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedVerts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedVerts)) = value;
		}
	}

	public unsafe bool m_CachedCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCharacters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedCharacters)) = value;
		}
	}

	public unsafe bool m_CachedLines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedLines);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedLines)) = value;
		}
	}

	public unsafe int characterCountVisible
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1284958, RefRangeEnd = 1284965, XrefRangeStart = 1284955, XrefRangeEnd = 1284958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterCountVisible_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe IList<UIVertex> verts
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1285082, RefRangeEnd = 1285084, XrefRangeStart = 1285079, XrefRangeEnd = 1285082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_verts_Public_get_IList_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<UIVertex>>(intPtr2) : null;
		}
	}

	public unsafe IList<UICharInfo> characters
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1285087, RefRangeEnd = 1285098, XrefRangeStart = 1285084, XrefRangeEnd = 1285087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characters_Public_get_IList_1_UICharInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<UICharInfo>>(intPtr2) : null;
		}
	}

	public unsafe IList<UILineInfo> lines
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1285101, RefRangeEnd = 1285117, XrefRangeStart = 1285098, XrefRangeEnd = 1285101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lines_Public_get_IList_1_UILineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<UILineInfo>>(intPtr2) : null;
		}
	}

	public unsafe Rect rectExtents
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1285120, RefRangeEnd = 1285121, XrefRangeStart = 1285117, XrefRangeEnd = 1285120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rectExtents_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int characterCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1285125, RefRangeEnd = 1285126, XrefRangeStart = 1285121, XrefRangeEnd = 1285125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int lineCount
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1285130, RefRangeEnd = 1285137, XrefRangeStart = 1285126, XrefRangeEnd = 1285130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lineCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int vertexCount
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vertexCount_Injected(intPtr);
		}
	}

	public int fontSizeUsedForBestFit
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fontSizeUsedForBestFit_Injected(intPtr);
		}
	}

	static TextGenerator()
	{
		Il2CppClassPointerStore<TextGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "TextGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_LastString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastString");
		NativeFieldInfoPtr_m_LastSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastSettings");
		NativeFieldInfoPtr_m_HasGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HasGenerated");
		NativeFieldInfoPtr_m_LastValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastValid");
		NativeFieldInfoPtr_m_Verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Verts");
		NativeFieldInfoPtr_m_Characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Characters");
		NativeFieldInfoPtr_m_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Lines");
		NativeFieldInfoPtr_m_CachedVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedVerts");
		NativeFieldInfoPtr_m_CachedCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedCharacters");
		NativeFieldInfoPtr_m_CachedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedLines");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_get_characterCountVisible_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_ValidatedSettings_Private_TextGenerationSettings_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_Invalidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_GetCharacters_Public_Void_List_1_UICharInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_GetLines_Public_Void_List_1_UILineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_GetVertices_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_GetPreferredWidth_Public_Single_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_GetPreferredHeight_Public_Single_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_PopulateWithErrors_Public_Boolean_String_TextGenerationSettings_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_Populate_Public_Boolean_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_PopulateWithError_Private_TextGenerationError_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_PopulateAlways_Private_TextGenerationError_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_verts_Public_get_IList_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_characters_Public_get_IList_1_UICharInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_lines_Public_get_IList_1_UILineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_get_rectExtents_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_get_characterCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_get_lineCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_VerticalWrapMode_HorizontalWrapMode_Boolean_TextAnchor_Vector2_Vector2_Boolean_Boolean_byref_TextGenerationError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_GetVerticesInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_GetCharactersInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_GetLinesInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_get_rectExtents_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_get_characterCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_get_lineCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_Populate_Internal_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_byref_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_GetVerticesInternal_Injected_Private_Static_Void_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_GetCharactersInternal_Injected_Private_Static_Void_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_GetLinesInternal_Injected_Private_Static_Void_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663335);
		get_vertexCount_InjectedDelegateField = IL2CPP.ResolveICall<get_vertexCount_InjectedDelegate>("UnityEngine.TextGenerator::get_vertexCount_Injected");
		get_fontSizeUsedForBestFit_InjectedDelegateField = IL2CPP.ResolveICall<get_fontSizeUsedForBestFit_InjectedDelegate>("UnityEngine.TextGenerator::get_fontSizeUsedForBestFit_Injected");
		GetVerticesArray_InjectedDelegateField = IL2CPP.ResolveICall<GetVerticesArray_InjectedDelegate>("UnityEngine.TextGenerator::GetVerticesArray_Injected");
		GetCharactersArray_InjectedDelegateField = IL2CPP.ResolveICall<GetCharactersArray_InjectedDelegate>("UnityEngine.TextGenerator::GetCharactersArray_Injected");
		GetLinesArray_InjectedDelegateField = IL2CPP.ResolveICall<GetLinesArray_InjectedDelegate>("UnityEngine.TextGenerator::GetLinesArray_Injected");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1284917, RefRangeEnd = 1284920, XrefRangeStart = 1284893, XrefRangeEnd = 1284917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1284944, RefRangeEnd = 1284945, XrefRangeStart = 1284920, XrefRangeEnd = 1284944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerator(int initialCapacity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialCapacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284945, XrefRangeEnd = 1284953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284953, XrefRangeEnd = 1284955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_IDisposable_Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285001, RefRangeEnd = 1285003, XrefRangeStart = 1284965, XrefRangeEnd = 1285001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidatedSettings_Private_TextGenerationSettings_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TextGenerationSettings(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 158906, RefRangeEnd = 158908, XrefRangeStart = 158906, XrefRangeEnd = 158908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Invalidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invalidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285003, XrefRangeEnd = 1285007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCharacters(List<UICharInfo> characters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacters_Public_Void_List_1_UICharInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285007, XrefRangeEnd = 1285011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLines(List<UILineInfo> lines)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lines);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLines_Public_Void_List_1_UILineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285011, XrefRangeEnd = 1285015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVertices(List<UIVertex> vertices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertices_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285019, RefRangeEnd = 1285021, XrefRangeStart = 1285015, XrefRangeEnd = 1285019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPreferredWidth(string str, TextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredWidth_Public_Single_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1285025, RefRangeEnd = 1285028, XrefRangeStart = 1285021, XrefRangeEnd = 1285025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPreferredHeight(string str, TextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredHeight_Public_Single_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285050, RefRangeEnd = 1285052, XrefRangeStart = 1285028, XrefRangeEnd = 1285050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateWithErrors_Public_Boolean_String_TextGenerationSettings_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285053, RefRangeEnd = 1285054, XrefRangeStart = 1285052, XrefRangeEnd = 1285053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Populate(string str, TextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Populate_Public_Boolean_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1285066, RefRangeEnd = 1285070, XrefRangeStart = 1285054, XrefRangeEnd = 1285066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateWithError_Private_TextGenerationError_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextGenerationError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285070, XrefRangeEnd = 1285079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateAlways_Private_TextGenerationError_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextGenerationError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285137, XrefRangeEnd = 1285139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285139, XrefRangeEnd = 1285141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1285159, RefRangeEnd = 1285162, XrefRangeStart = 1285141, XrefRangeEnd = 1285159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[22];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontSize;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleFactor;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineSpacing;
		*(FontStyle**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &richText;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextForBestFit;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextMinSize;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextMaxSize;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &verticalOverFlow;
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &horizontalOverflow;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateBounds;
		*(TextAnchor**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		*(float**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &extentsX;
		*(float**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &extentsY;
		*(float**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivotX;
		*(float**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivotY;
		*(bool**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateOutOfBounds;
		*(bool**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignByGeometry;
		*(void**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285162, XrefRangeEnd = 1285168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[20];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontSize;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleFactor;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineSpacing;
		*(FontStyle**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &richText;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextForBestFit;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextMinSize;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextMaxSize;
		*(VerticalWrapMode**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &verticalOverFlow;
		*(HorizontalWrapMode**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &horizontalOverflow;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateBounds;
		*(TextAnchor**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		*(Vector2**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &extents;
		*(Vector2**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateOutOfBounds;
		*(bool**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignByGeometry;
		*(void**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_VerticalWrapMode_HorizontalWrapMode_Boolean_TextAnchor_Vector2_Vector2_Boolean_Boolean_byref_TextGenerationError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVerticesInternal(Il2CppSystem.Object vertices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVerticesInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCharactersInternal(Il2CppSystem.Object characters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharactersInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLinesInternal(Il2CppSystem.Object lines)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lines);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinesInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285168, XrefRangeEnd = 1285170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rectExtents_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rectExtents_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285170, XrefRangeEnd = 1285172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_characterCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285172, XrefRangeEnd = 1285174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_lineCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lineCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285174, XrefRangeEnd = 1285176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Populate_Internal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper str, System.IntPtr font, [In] ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[23];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref str);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &font;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontSize;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleFactor;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineSpacing;
		*(FontStyle**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &richText;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextForBestFit;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextMinSize;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &resizeTextMaxSize;
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &verticalOverFlow;
		*(int**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &horizontalOverflow;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateBounds;
		*(TextAnchor**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		*(float**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &extentsX;
		*(float**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &extentsY;
		*(float**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivotX;
		*(float**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivotY;
		*(bool**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateOutOfBounds;
		*(bool**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignByGeometry;
		*(void**)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Populate_Internal_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_byref_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285176, XrefRangeEnd = 1285178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVerticesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object vertices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVerticesInternal_Injected_Private_Static_Void_IntPtr_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285178, XrefRangeEnd = 1285180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCharactersInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object characters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharactersInternal_Injected_Private_Static_Void_IntPtr_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285180, XrefRangeEnd = 1285182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLinesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object lines)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lines);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinesInternal_Injected_Private_Static_Void_IntPtr_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe Il2CppStructArray<UIVertex> GetVerticesArray()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<UIVertex> result;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetVerticesArray_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<UIVertex> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<UIVertex>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe Il2CppStructArray<UICharInfo> GetCharactersArray()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<UICharInfo> result;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetCharactersArray_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<UICharInfo> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<UICharInfo>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe Il2CppStructArray<UILineInfo> GetLinesArray()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<UILineInfo> result;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetLinesArray_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<UILineInfo> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<UILineInfo>*)(&array));
			result = array;
		}
		return result;
	}

	public static int get_vertexCount_Injected(System.IntPtr _unity_self)
	{
		return get_vertexCount_InjectedDelegateField(_unity_self);
	}

	public static int get_fontSizeUsedForBestFit_Injected(System.IntPtr _unity_self)
	{
		return get_fontSizeUsedForBestFit_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetVerticesArray_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetVerticesArray_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetCharactersArray_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetCharactersArray_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetLinesArray_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetLinesArray_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}
}
