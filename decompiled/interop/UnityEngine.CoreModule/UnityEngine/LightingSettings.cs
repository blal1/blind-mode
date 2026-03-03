using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class LightingSettings : Object
{
	private delegate void Internal_CreateDelegate(IntPtr self);

	private delegate bool get_bakedGI_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_bakedGI_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_realtimeGI_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_realtimeGI_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_realtimeEnvironmentLighting_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_realtimeEnvironmentLighting_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly IntPtr NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0;

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField;

	private static readonly get_bakedGI_InjectedDelegate get_bakedGI_InjectedDelegateField;

	private static readonly set_bakedGI_InjectedDelegate set_bakedGI_InjectedDelegateField;

	private static readonly get_realtimeGI_InjectedDelegate get_realtimeGI_InjectedDelegateField;

	private static readonly set_realtimeGI_InjectedDelegate set_realtimeGI_InjectedDelegateField;

	private static readonly get_realtimeEnvironmentLighting_InjectedDelegate get_realtimeEnvironmentLighting_InjectedDelegateField;

	private static readonly set_realtimeEnvironmentLighting_InjectedDelegate set_realtimeEnvironmentLighting_InjectedDelegateField;

	public bool bakedGI
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bakedGI_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bakedGI_Injected(intPtr, value);
		}
	}

	public bool realtimeGI
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_realtimeGI_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_realtimeGI_Injected(intPtr, value);
		}
	}

	public bool realtimeEnvironmentLighting
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_realtimeEnvironmentLighting_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_realtimeEnvironmentLighting_Injected(intPtr, value);
		}
	}

	static LightingSettings()
	{
		Il2CppClassPointerStore<LightingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightingSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr);
		NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664271);
		Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.LightingSettings::Internal_Create");
		get_bakedGI_InjectedDelegateField = IL2CPP.ResolveICall<get_bakedGI_InjectedDelegate>("UnityEngine.LightingSettings::get_bakedGI_Injected");
		set_bakedGI_InjectedDelegateField = IL2CPP.ResolveICall<set_bakedGI_InjectedDelegate>("UnityEngine.LightingSettings::set_bakedGI_Injected");
		get_realtimeGI_InjectedDelegateField = IL2CPP.ResolveICall<get_realtimeGI_InjectedDelegate>("UnityEngine.LightingSettings::get_realtimeGI_Injected");
		set_realtimeGI_InjectedDelegateField = IL2CPP.ResolveICall<set_realtimeGI_InjectedDelegate>("UnityEngine.LightingSettings::set_realtimeGI_Injected");
		get_realtimeEnvironmentLighting_InjectedDelegateField = IL2CPP.ResolveICall<get_realtimeEnvironmentLighting_InjectedDelegate>("UnityEngine.LightingSettings::get_realtimeEnvironmentLighting_Injected");
		set_realtimeEnvironmentLighting_InjectedDelegateField = IL2CPP.ResolveICall<set_realtimeEnvironmentLighting_InjectedDelegate>("UnityEngine.LightingSettings::set_realtimeEnvironmentLighting_Injected");
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LightingSettingsDontStripMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LightingSettings(IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Internal_Create(LightingSettings self)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self));
	}

	public static bool get_bakedGI_Injected(IntPtr _unity_self)
	{
		return get_bakedGI_InjectedDelegateField(_unity_self);
	}

	public static void set_bakedGI_Injected(IntPtr _unity_self, bool value)
	{
		set_bakedGI_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_realtimeGI_Injected(IntPtr _unity_self)
	{
		return get_realtimeGI_InjectedDelegateField(_unity_self);
	}

	public static void set_realtimeGI_Injected(IntPtr _unity_self, bool value)
	{
		set_realtimeGI_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_realtimeEnvironmentLighting_Injected(IntPtr _unity_self)
	{
		return get_realtimeEnvironmentLighting_InjectedDelegateField(_unity_self);
	}

	public static void set_realtimeEnvironmentLighting_Injected(IntPtr _unity_self, bool value)
	{
		set_realtimeEnvironmentLighting_InjectedDelegateField(_unity_self, value);
	}
}
