using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Accessibility;

public static class AccessibilitySettings : Il2CppSystem.Object
{
	private delegate float GetFontScaleDelegate();

	private delegate bool IsBoldTextEnabledDelegate();

	private delegate bool IsClosedCaptioningEnabledDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr_fontScaleChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_boldTextStatusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_closedCaptioningStatusChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_OnFontScaleChanged_Private_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_OnBoldTextStatusChanged_Private_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_OnClosedCaptioningStatusChanged_Private_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeFontScaleChanged_Internal_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeBoldTextStatusChanged_Internal_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeClosedCaptionStatusChanged_Internal_Static_Void_Boolean_0;

	private static readonly GetFontScaleDelegate GetFontScaleDelegateField;

	private static readonly IsBoldTextEnabledDelegate IsBoldTextEnabledDelegateField;

	private static readonly IsClosedCaptioningEnabledDelegate IsClosedCaptioningEnabledDelegateField;

	public unsafe static Il2CppSystem.Action<float> fontScaleChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontScaleChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontScaleChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<bool> boldTextStatusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_boldTextStatusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_boldTextStatusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<bool> closedCaptioningStatusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_closedCaptioningStatusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_closedCaptioningStatusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static float fontScale => GetFontScale();

	public static bool isBoldTextEnabled => IsBoldTextEnabled();

	public static bool isClosedCaptioningEnabled => IsClosedCaptioningEnabled();

	static AccessibilitySettings()
	{
		Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilitySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr);
		NativeFieldInfoPtr_fontScaleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, "fontScaleChanged");
		NativeFieldInfoPtr_boldTextStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, "boldTextStatusChanged");
		NativeFieldInfoPtr_closedCaptioningStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, "closedCaptioningStatusChanged");
		NativeMethodInfoPtr_Internal_OnFontScaleChanged_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_Internal_OnBoldTextStatusChanged_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_Internal_OnClosedCaptioningStatusChanged_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_InvokeFontScaleChanged_Internal_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_InvokeBoldTextStatusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_InvokeClosedCaptionStatusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilitySettings>.NativeClassPtr, 100663378);
		GetFontScaleDelegateField = IL2CPP.ResolveICall<GetFontScaleDelegate>("UnityEngine.Accessibility.AccessibilitySettings::GetFontScale");
		IsBoldTextEnabledDelegateField = IL2CPP.ResolveICall<IsBoldTextEnabledDelegate>("UnityEngine.Accessibility.AccessibilitySettings::IsBoldTextEnabled");
		IsClosedCaptioningEnabledDelegateField = IL2CPP.ResolveICall<IsClosedCaptioningEnabledDelegate>("UnityEngine.Accessibility.AccessibilitySettings::IsClosedCaptioningEnabled");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147796, XrefRangeEnd = 1147800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_OnFontScaleChanged(float newFontScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newFontScale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_OnFontScaleChanged_Private_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147800, XrefRangeEnd = 1147804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_OnBoldTextStatusChanged(bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_OnBoldTextStatusChanged_Private_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147804, XrefRangeEnd = 1147808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_OnClosedCaptioningStatusChanged(bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_OnClosedCaptioningStatusChanged_Private_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1147810, RefRangeEnd = 1147811, XrefRangeStart = 1147808, XrefRangeEnd = 1147810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeFontScaleChanged(float newFontScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newFontScale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeFontScaleChanged_Internal_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1147813, RefRangeEnd = 1147814, XrefRangeStart = 1147811, XrefRangeEnd = 1147813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBoldTextStatusChanged(bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeBoldTextStatusChanged_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1147816, RefRangeEnd = 1147817, XrefRangeStart = 1147814, XrefRangeEnd = 1147816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeClosedCaptionStatusChanged(bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeClosedCaptionStatusChanged_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AccessibilitySettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static float GetFontScale()
	{
		return GetFontScaleDelegateField();
	}

	public static bool IsBoldTextEnabled()
	{
		return IsBoldTextEnabledDelegateField();
	}

	public static bool IsClosedCaptioningEnabled()
	{
		return IsClosedCaptioningEnabledDelegateField();
	}

	[SpecialName]
	public static void add_fontScaleChanged(Il2CppSystem.Action<float> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_fontScaleChanged(Il2CppSystem.Action<float> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_boldTextStatusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_boldTextStatusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_closedCaptioningStatusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_closedCaptioningStatusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
