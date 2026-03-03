using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.Controls;

public class ButtonControl : AxisControl
{
	private static readonly IntPtr NativeFieldInfoPtr_m_NeedsToCheckFramePress;

	private static readonly IntPtr NativeFieldInfoPtr_m_UpdateCountLastPressed;

	private static readonly IntPtr NativeFieldInfoPtr_m_UpdateCountLastReleased;

	private static readonly IntPtr NativeFieldInfoPtr_m_LastUpdateWasPress;

	private static readonly IntPtr NativeFieldInfoPtr__needsToCheckFramePress_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_pressPoint;

	private static readonly IntPtr NativeFieldInfoPtr_s_GlobalDefaultButtonPressPoint;

	private static readonly IntPtr NativeFieldInfoPtr_s_GlobalDefaultButtonReleaseThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_kMinButtonPressPoint;

	private static readonly IntPtr NativeMethodInfoPtr_get_needsToCheckFramePress_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_needsToCheckFramePress_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_pressPointOrDefault_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsValueConsideredPressed_Public_Boolean_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_BeginTestingForFramePresses_Private_Void_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wasPressedThisFrame_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wasReleasedThisFrame_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateWasPressed_Internal_Void_0;

	public unsafe bool m_NeedsToCheckFramePress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsToCheckFramePress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsToCheckFramePress)) = value;
		}
	}

	public unsafe uint m_UpdateCountLastPressed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateCountLastPressed);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateCountLastPressed)) = value;
		}
	}

	public unsafe uint m_UpdateCountLastReleased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateCountLastReleased);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateCountLastReleased)) = value;
		}
	}

	public unsafe bool m_LastUpdateWasPress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastUpdateWasPress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastUpdateWasPress)) = value;
		}
	}

	public unsafe bool _needsToCheckFramePress_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__needsToCheckFramePress_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__needsToCheckFramePress_k__BackingField)) = value;
		}
	}

	public unsafe float pressPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressPoint)) = value;
		}
	}

	public unsafe static float s_GlobalDefaultButtonPressPoint
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalDefaultButtonPressPoint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalDefaultButtonPressPoint, (void*)(&value));
		}
	}

	public unsafe static float s_GlobalDefaultButtonReleaseThreshold
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalDefaultButtonReleaseThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalDefaultButtonReleaseThreshold, (void*)(&value));
		}
	}

	public unsafe static float kMinButtonPressPoint
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMinButtonPressPoint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMinButtonPressPoint, (void*)(&value));
		}
	}

	public unsafe bool needsToCheckFramePress
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_needsToCheckFramePress_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_needsToCheckFramePress_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float pressPointOrDefault
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1014390, RefRangeEnd = 1014396, XrefRangeStart = 1014389, XrefRangeEnd = 1014390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressPointOrDefault_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isPressed
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1014443, RefRangeEnd = 1014462, XrefRangeStart = 1014442, XrefRangeEnd = 1014443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool wasPressedThisFrame
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014467, XrefRangeEnd = 1014471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wasPressedThisFrame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool wasReleasedThisFrame
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014471, XrefRangeEnd = 1014475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wasReleasedThisFrame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ButtonControl()
	{
		Il2CppClassPointerStore<ButtonControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Controls", "ButtonControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr);
		NativeFieldInfoPtr_m_NeedsToCheckFramePress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "m_NeedsToCheckFramePress");
		NativeFieldInfoPtr_m_UpdateCountLastPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "m_UpdateCountLastPressed");
		NativeFieldInfoPtr_m_UpdateCountLastReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "m_UpdateCountLastReleased");
		NativeFieldInfoPtr_m_LastUpdateWasPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "m_LastUpdateWasPress");
		NativeFieldInfoPtr__needsToCheckFramePress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "<needsToCheckFramePress>k__BackingField");
		NativeFieldInfoPtr_pressPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "pressPoint");
		NativeFieldInfoPtr_s_GlobalDefaultButtonPressPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "s_GlobalDefaultButtonPressPoint");
		NativeFieldInfoPtr_s_GlobalDefaultButtonReleaseThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "s_GlobalDefaultButtonReleaseThreshold");
		NativeFieldInfoPtr_kMinButtonPressPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, "kMinButtonPressPoint");
		NativeMethodInfoPtr_get_needsToCheckFramePress_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668403);
		NativeMethodInfoPtr_set_needsToCheckFramePress_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668404);
		NativeMethodInfoPtr_get_pressPointOrDefault_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668405);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668406);
		NativeMethodInfoPtr_IsValueConsideredPressed_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668407);
		NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668408);
		NativeMethodInfoPtr_BeginTestingForFramePresses_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668409);
		NativeMethodInfoPtr_get_wasPressedThisFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668410);
		NativeMethodInfoPtr_get_wasReleasedThisFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668411);
		NativeMethodInfoPtr_UpdateWasPressed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr, 100668412);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 1014403, RefRangeEnd = 1014436, XrefRangeStart = 1014396, XrefRangeEnd = 1014403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ButtonControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonControl>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1014437, RefRangeEnd = 1014442, XrefRangeStart = 1014436, XrefRangeEnd = 1014437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool IsValueConsideredPressed(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValueConsideredPressed_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014462, XrefRangeEnd = 1014467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentlyPressed);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &pressedLastFrame;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginTestingForFramePresses_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1014479, RefRangeEnd = 1014482, XrefRangeStart = 1014475, XrefRangeEnd = 1014479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWasPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWasPressed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ButtonControl(IntPtr pointer)
		: base(pointer)
	{
	}
}
