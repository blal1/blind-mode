using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppTMPro;

public static class TMP_DefaultControls : Il2CppSystem.Object
{
	public sealed class Resources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_standard;

		private static readonly System.IntPtr NativeFieldInfoPtr_background;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputField;

		private static readonly System.IntPtr NativeFieldInfoPtr_knob;

		private static readonly System.IntPtr NativeFieldInfoPtr_checkmark;

		private static readonly System.IntPtr NativeFieldInfoPtr_dropdown;

		private static readonly System.IntPtr NativeFieldInfoPtr_mask;

		public unsafe Sprite standard
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standard);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standard)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Sprite background
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Sprite inputField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Sprite knob
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knob);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Sprite checkmark
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkmark);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkmark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Sprite dropdown
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropdown);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropdown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Sprite mask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Resources()
		{
			Il2CppClassPointerStore<Resources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "Resources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resources>.NativeClassPtr);
			NativeFieldInfoPtr_standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "standard");
			NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "background");
			NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "inputField");
			NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "knob");
			NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "checkmark");
			NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "dropdown");
			NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resources>.NativeClassPtr, "mask");
		}

		public Resources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Resources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Resources>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_AddComponent_Private_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComponent_Private_Static_T_GameObject_0, Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_kThickHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_kThinHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TextElementSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ThickElementSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ThinElementSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultSelectableColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TextColor;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Private_Static_T_GameObject_0;

	public unsafe static float kWidth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kWidth, (void*)(&value));
		}
	}

	public unsafe static float kThickHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kThickHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kThickHeight, (void*)(&value));
		}
	}

	public unsafe static float kThinHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kThinHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kThinHeight, (void*)(&value));
		}
	}

	public unsafe static Vector2 s_TextElementSize
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TextElementSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TextElementSize, (void*)(&value));
		}
	}

	public unsafe static Vector2 s_ThickElementSize
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ThickElementSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ThickElementSize, (void*)(&value));
		}
	}

	public unsafe static Vector2 s_ThinElementSize
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ThinElementSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ThinElementSize, (void*)(&value));
		}
	}

	public unsafe static Color s_DefaultSelectableColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&value));
		}
	}

	public unsafe static Color s_TextColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TextColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TextColor, (void*)(&value));
		}
	}

	static TMP_DefaultControls()
	{
		Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_DefaultControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr);
		NativeFieldInfoPtr_kWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kWidth");
		NativeFieldInfoPtr_kThickHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kThickHeight");
		NativeFieldInfoPtr_kThinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kThinHeight");
		NativeFieldInfoPtr_s_TextElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_TextElementSize");
		NativeFieldInfoPtr_s_ThickElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_ThickElementSize");
		NativeFieldInfoPtr_s_ThinElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_ThinElementSize");
		NativeFieldInfoPtr_s_DefaultSelectableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_DefaultSelectableColor");
		NativeFieldInfoPtr_s_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_TextColor");
		NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663720);
		NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663721);
		NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663722);
		NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663723);
		NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663724);
		NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663725);
		NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663726);
		NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663727);
		NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663729);
		NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663730);
		NativeMethodInfoPtr_AddComponent_Private_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663731);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1120190, RefRangeEnd = 1120195, XrefRangeStart = 1120182, XrefRangeEnd = 1120190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateUIElementRoot(string name, Vector2 size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1120206, RefRangeEnd = 1120220, XrefRangeStart = 1120195, XrefRangeEnd = 1120206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateUIObject(string name, GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120220, XrefRangeEnd = 1120226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDefaultTextValues(TMP_Text lbl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lbl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120226, XrefRangeEnd = 1120229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDefaultColorTransitionValues(Selectable slider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1120241, RefRangeEnd = 1120244, XrefRangeStart = 1120229, XrefRangeEnd = 1120241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetParentAndAlign(GameObject child, GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1120254, RefRangeEnd = 1120256, XrefRangeStart = 1120244, XrefRangeEnd = 1120254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(GameObject go, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1120301, RefRangeEnd = 1120302, XrefRangeStart = 1120256, XrefRangeEnd = 1120301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateScrollbar(Resources resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120302, XrefRangeEnd = 1120353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateButton(Resources resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120353, XrefRangeEnd = 1120363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateText(Resources resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120363, XrefRangeEnd = 1120464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateInputField(Resources resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120464, XrefRangeEnd = 1120701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateDropdown(Resources resources)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1120704, RefRangeEnd = 1120728, XrefRangeStart = 1120701, XrefRangeEnd = 1120704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddComponent<T>(GameObject go) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddComponent_Private_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	public TMP_DefaultControls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
