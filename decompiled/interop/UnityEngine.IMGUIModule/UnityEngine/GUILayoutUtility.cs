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
using UnityEngineInternal;

namespace UnityEngine;

public class GUILayoutUtility : Il2CppSystem.Object
{
	public sealed class LayoutCache : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_topLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutGroups;

		private static readonly System.IntPtr NativeFieldInfoPtr_windows;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ResetCursor_Public_Void_0;

		public unsafe int _id_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField)) = value;
			}
		}

		public unsafe GUILayoutGroup topLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topLevel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GenericStack layoutGroups
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutGroups);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericStack>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutGroups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GUILayoutGroup windows
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windows);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int id
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static LayoutCache()
		{
			Il2CppClassPointerStore<LayoutCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "LayoutCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr);
			NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, "<id>k__BackingField");
			NativeFieldInfoPtr_topLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, "topLevel");
			NativeFieldInfoPtr_layoutGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, "layoutGroups");
			NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, "windows");
			NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, 100663515);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, 100663516);
			NativeMethodInfoPtr_ResetCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr, 100663517);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245908, RefRangeEnd = 1245910, XrefRangeStart = 1245892, XrefRangeEnd = 1245908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutCache(int instanceID = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutCache>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&instanceID);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245925, RefRangeEnd = 1245926, XrefRangeStart = 1245910, XrefRangeEnd = 1245925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LayoutCache(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate void GetWindowsBounds_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_StoredLayouts;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_StoredWindows;

	private static readonly System.IntPtr NativeFieldInfoPtr_current;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDummyRect;

	private static readonly System.IntPtr NativeFieldInfoPtr__unbalancedgroupscount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SpaceStyle;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unbalancedgroupscount_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_unbalancedgroupscount_Internal_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLayoutCache_Internal_Static_LayoutCache_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSelectedIdList_Internal_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Layout_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndLayoutArea_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0;

	private static readonly GetWindowsBounds_InjectedDelegate GetWindowsBounds_InjectedDelegateField;

	public unsafe static Dictionary<int, LayoutCache> s_StoredLayouts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_StoredLayouts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, LayoutCache>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_StoredLayouts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, LayoutCache> s_StoredWindows
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_StoredWindows, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, LayoutCache>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_StoredWindows, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LayoutCache current
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_current, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutCache>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_current, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Rect kDummyRect
	{
		get
		{
			Unsafe.SkipInit(out Rect result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDummyRect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDummyRect, (void*)(&value));
		}
	}

	public unsafe static int _unbalancedgroupscount_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__unbalancedgroupscount_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__unbalancedgroupscount_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static GUIStyle s_SpaceStyle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SpaceStyle, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SpaceStyle, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int unbalancedgroupscount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245936, XrefRangeEnd = 1245940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unbalancedgroupscount_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245940, XrefRangeEnd = 1245944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_unbalancedgroupscount_Internal_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static GUIStyle spaceStyle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246359, XrefRangeEnd = 1246382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
	}

	public static GUILayoutGroup topLevel => current.topLevel;

	static GUILayoutUtility()
	{
		Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr);
		NativeFieldInfoPtr_s_StoredLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredLayouts");
		NativeFieldInfoPtr_s_StoredWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredWindows");
		NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "current");
		NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "kDummyRect");
		NativeFieldInfoPtr__unbalancedgroupscount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "<unbalancedgroupscount>k__BackingField");
		NativeFieldInfoPtr_s_SpaceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_SpaceStyle");
		NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_get_unbalancedgroupscount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_set_unbalancedgroupscount_Internal_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_GetLayoutCache_Internal_Static_LayoutCache_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_RemoveSelectedIdList_Internal_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_Layout_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_EndLayoutArea_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663514);
		GetWindowsBounds_InjectedDelegateField = IL2CPP.ResolveICall<GetWindowsBounds_InjectedDelegate>("UnityEngine.GUILayoutUtility::GetWindowsBounds_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245926, XrefRangeEnd = 1245931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect Internal_GetWindowRect(int windowID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245931, XrefRangeEnd = 1245936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_MoveWindow(int windowID, Rect r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowID);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245944, XrefRangeEnd = 1245954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LayoutCache GetLayoutCache(int instanceID, bool isWindow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instanceID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWindow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLayoutCache_Internal_Static_LayoutCache_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutCache>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1245988, RefRangeEnd = 1245993, XrefRangeStart = 1245954, XrefRangeEnd = 1245988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LayoutCache SelectIDList(int instanceID, bool isWindow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instanceID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWindow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutCache>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245993, XrefRangeEnd = 1246006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveSelectedIdList(int instanceID, bool isWindow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instanceID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWindow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSelectedIdList_Internal_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246024, RefRangeEnd = 1246025, XrefRangeStart = 1246006, XrefRangeEnd = 1246024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Begin(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246049, RefRangeEnd = 1246050, XrefRangeStart = 1246025, XrefRangeEnd = 1246049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginContainer(LayoutCache cache)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cache);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246068, RefRangeEnd = 1246069, XrefRangeStart = 1246050, XrefRangeEnd = 1246068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginWindow(int windowID, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&windowID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1246079, RefRangeEnd = 1246081, XrefRangeStart = 1246069, XrefRangeEnd = 1246079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Layout()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Layout_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246092, RefRangeEnd = 1246093, XrefRangeStart = 1246081, XrefRangeEnd = 1246092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LayoutFromEditorWindow()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246093, XrefRangeEnd = 1246103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LayoutFromContainer(float w, float h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&w);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246125, RefRangeEnd = 1246126, XrefRangeStart = 1246104, XrefRangeEnd = 1246125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LayoutFreeGroup(GUILayoutGroup toplevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toplevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1246139, RefRangeEnd = 1246141, XrefRangeStart = 1246126, XrefRangeEnd = 1246139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LayoutSingleGroup(GUILayoutGroup i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1246149, RefRangeEnd = 1246151, XrefRangeStart = 1246141, XrefRangeEnd = 1246149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Il2CppSystem.Type LayoutType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)LayoutType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1246187, RefRangeEnd = 1246189, XrefRangeStart = 1246151, XrefRangeEnd = 1246187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutGroup BeginLayoutGroup(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options, Il2CppSystem.Type layoutType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246215, RefRangeEnd = 1246216, XrefRangeStart = 1246189, XrefRangeEnd = 1246215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndLayoutGroup()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246250, RefRangeEnd = 1246251, XrefRangeStart = 1246216, XrefRangeEnd = 1246250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutGroup BeginLayoutArea(GUIStyle style, Il2CppSystem.Type layoutType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1246272, RefRangeEnd = 1246273, XrefRangeStart = 1246251, XrefRangeEnd = 1246272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndLayoutArea()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndLayoutArea_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246273, XrefRangeEnd = 1246277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetRect(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
	{
		if (options == null)
		{
			options = new Il2CppReferenceArray<GUILayoutOption>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1246326, RefRangeEnd = 1246331, XrefRangeStart = 1246277, XrefRangeEnd = 1246326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect DoGetRect(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246331, XrefRangeEnd = 1246335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetRect(float width, float height, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
	{
		if (options == null)
		{
			options = new Il2CppReferenceArray<GUILayoutOption>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1246357, RefRangeEnd = 1246359, XrefRangeStart = 1246335, XrefRangeEnd = 1246357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&minWidth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeight;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246382, XrefRangeEnd = 1246384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_GetWindowRect_Injected(int windowID, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowID);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246384, XrefRangeEnd = 1246386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_MoveWindow_Injected(int windowID, [In] ref Rect r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowID);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref r);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return GetRect(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
	{
		return GetRect(width, height, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public GUILayoutUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Rect GetWindowsBounds()
	{
		GetWindowsBounds_Injected(out var ret);
		return ret;
	}

	public static void CleanupRoots()
	{
		s_SpaceStyle = null;
		s_StoredLayouts.Clear();
		s_StoredWindows.Clear();
		current = new LayoutCache();
	}

	public static void BeginGroup(string GroupName)
	{
	}

	public static void EndGroup(string groupName)
	{
	}

	public static float LayoutFromInspector(float width)
	{
		if (current.topLevel != null && current.topLevel.windowID == -1)
		{
			current.topLevel.CalcWidth();
			current.topLevel.SetHorizontal(0f, width);
			current.topLevel.CalcHeight();
			current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, current.topLevel.maxHeight));
			float minHeight = current.topLevel.minHeight;
			LayoutFreeGroup(current.windows);
			return minHeight;
		}
		if (current.topLevel != null)
		{
			LayoutSingleGroup(current.topLevel);
		}
		return 0f;
	}

	public static GUILayoutGroup DoBeginLayoutArea(GUIStyle style, Il2CppSystem.Type layoutType)
	{
		return BeginLayoutArea(style, layoutType);
	}

	public static Rect GetRect(GUIContent content, GUIStyle style)
	{
		return DoGetRect(content, style, null);
	}

	public static Rect GetRect(float width, float height)
	{
		return DoGetRect(width, width, height, height, GUIStyle.none, null);
	}

	public static Rect GetRect(float width, float height, GUIStyle style)
	{
		return DoGetRect(width, width, height, height, style, null);
	}

	public static Rect GetRect(float width, float height, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoGetRect(width, width, height, height, GUIStyle.none, options);
	}

	public static Rect GetRect(float width, float height, params GUILayoutOption[] options)
	{
		return GetRect(width, height, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
	{
		return DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, null);
	}

	public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style)
	{
		return DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, null);
	}

	public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, options);
	}

	public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options)
	{
		return GetRect(minWidth, maxWidth, minHeight, maxHeight, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);
	}

	public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options)
	{
		return GetRect(minWidth, maxWidth, minHeight, maxHeight, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect GetLastRect()
	{
		EventType type = Event.current.type;
		EventType eventType = type;
		if (eventType == EventType.Layout || eventType == EventType.Used)
		{
			return kDummyRect;
		}
		return current.topLevel.GetLast();
	}

	public static Rect GetAspectRect(float aspect)
	{
		return DoGetAspectRect(aspect, null);
	}

	public static Rect GetAspectRect(float aspect, GUIStyle style)
	{
		return DoGetAspectRect(aspect, null);
	}

	public static Rect GetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoGetAspectRect(aspect, options);
	}

	public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options)
	{
		return GetAspectRect(aspect, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect GetAspectRect(float aspect, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoGetAspectRect(aspect, options);
	}

	public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options)
	{
		return GetAspectRect(aspect, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect DoGetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
	{
		switch (Event.current.type)
		{
		case EventType.Layout:
			current.topLevel.Add(new GUIAspectSizer(aspect, options));
			return kDummyRect;
		case EventType.Used:
			return kDummyRect;
		default:
			return current.topLevel.GetNext().rect;
		}
	}

	public unsafe static void GetWindowsBounds_Injected(out Rect ret)
	{
		GetWindowsBounds_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
