using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.EnhancedTouch;

public static class EnhancedTouchSupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UpdateMode;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpState_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TearDownState_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeviceChange_Private_Static_Void_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSettingsChange_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckEnabled_Internal_Static_Void_0;

	public unsafe static int s_Enabled
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Enabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Enabled, (void*)(&value));
		}
	}

	public unsafe static InputSettings.UpdateMode s_UpdateMode
	{
		get
		{
			Unsafe.SkipInit(out InputSettings.UpdateMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UpdateMode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UpdateMode, (void*)(&value));
		}
	}

	public unsafe static bool enabled
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006228, RefRangeEnd = 1006229, XrefRangeStart = 1006226, XrefRangeEnd = 1006228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EnhancedTouchSupport()
	{
		Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.EnhancedTouch", "EnhancedTouchSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr);
		NativeFieldInfoPtr_s_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, "s_Enabled");
		NativeFieldInfoPtr_s_UpdateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, "s_UpdateMode");
		NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667072);
		NativeMethodInfoPtr_Enable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667073);
		NativeMethodInfoPtr_Disable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667074);
		NativeMethodInfoPtr_Reset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667075);
		NativeMethodInfoPtr_SetUpState_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667076);
		NativeMethodInfoPtr_TearDownState_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_OnDeviceChange_Private_Static_Void_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr_OnSettingsChange_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr_CheckEnabled_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnhancedTouchSupport>.NativeClassPtr, 100667080);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1006256, RefRangeEnd = 1006257, XrefRangeStart = 1006229, XrefRangeEnd = 1006256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enable()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enable_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006257, XrefRangeEnd = 1006285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disable()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disable_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006285, XrefRangeEnd = 1006294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1006322, RefRangeEnd = 1006324, XrefRangeStart = 1006294, XrefRangeEnd = 1006322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUpState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpState_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1006351, RefRangeEnd = 1006353, XrefRangeStart = 1006324, XrefRangeEnd = 1006351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TearDownState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TearDownState_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1006383, RefRangeEnd = 1006385, XrefRangeStart = 1006353, XrefRangeEnd = 1006383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputDeviceChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDeviceChange_Private_Static_Void_InputDevice_InputDeviceChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006385, XrefRangeEnd = 1006393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSettingsChange()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSettingsChange_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006393, XrefRangeEnd = 1006395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckEnabled_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EnhancedTouchSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
