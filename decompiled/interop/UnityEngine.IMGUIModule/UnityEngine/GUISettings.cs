using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
public sealed class GUISettings : Il2CppSystem.Object
{
	private delegate float Internal_GetCursorFlashSpeedDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DoubleClickSelectsWord;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TripleClickSelectsLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorFlashSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectionColor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly Internal_GetCursorFlashSpeedDelegate Internal_GetCursorFlashSpeedDelegateField;

	public unsafe bool m_DoubleClickSelectsWord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DoubleClickSelectsWord);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DoubleClickSelectsWord)) = value;
		}
	}

	public unsafe bool m_TripleClickSelectsLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TripleClickSelectsLine);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TripleClickSelectsLine)) = value;
		}
	}

	public unsafe Color m_CursorColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorColor)) = value;
		}
	}

	public unsafe float m_CursorFlashSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorFlashSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorFlashSpeed)) = value;
		}
	}

	public unsafe Color m_SelectionColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectionColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectionColor)) = value;
		}
	}

	public bool doubleClickSelectsWord
	{
		get
		{
			return m_DoubleClickSelectsWord;
		}
		set
		{
			m_DoubleClickSelectsWord = value;
		}
	}

	public bool tripleClickSelectsLine
	{
		get
		{
			return m_TripleClickSelectsLine;
		}
		set
		{
			m_TripleClickSelectsLine = value;
		}
	}

	public Color cursorColor
	{
		get
		{
			return m_CursorColor;
		}
		set
		{
			m_CursorColor = value;
		}
	}

	public float cursorFlashSpeed
	{
		get
		{
			if (m_CursorFlashSpeed >= 0f)
			{
				return m_CursorFlashSpeed;
			}
			return Internal_GetCursorFlashSpeed();
		}
		set
		{
			m_CursorFlashSpeed = value;
		}
	}

	public Color selectionColor
	{
		get
		{
			return m_SelectionColor;
		}
		set
		{
			m_SelectionColor = value;
		}
	}

	static GUISettings()
	{
		Il2CppClassPointerStore<GUISettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_DoubleClickSelectsWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_DoubleClickSelectsWord");
		NativeFieldInfoPtr_m_TripleClickSelectsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_TripleClickSelectsLine");
		NativeFieldInfoPtr_m_CursorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorColor");
		NativeFieldInfoPtr_m_CursorFlashSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorFlashSpeed");
		NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_SelectionColor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663518);
		Internal_GetCursorFlashSpeedDelegateField = IL2CPP.ResolveICall<Internal_GetCursorFlashSpeedDelegate>("UnityEngine.GUISettings::Internal_GetCursorFlashSpeed");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246386, XrefRangeEnd = 1246387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUISettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GUISettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static float Internal_GetCursorFlashSpeed()
	{
		return Internal_GetCursorFlashSpeedDelegateField();
	}
}
