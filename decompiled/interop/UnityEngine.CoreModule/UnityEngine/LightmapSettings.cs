using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class LightmapSettings : Object
{
	private delegate IntPtr get_lightmapsDelegate();

	private delegate void set_lightmapsDelegate(IntPtr value);

	private delegate LightmapsMode get_lightmapsModeDelegate();

	private delegate void set_lightmapsModeDelegate(LightmapsMode value);

	private delegate void ResetDelegate();

	private delegate IntPtr get_lightProbes_InjectedDelegate();

	private delegate void set_lightProbes_InjectedDelegate(IntPtr value);

	private static readonly get_lightmapsDelegate get_lightmapsDelegateField;

	private static readonly set_lightmapsDelegate set_lightmapsDelegateField;

	private static readonly get_lightmapsModeDelegate get_lightmapsModeDelegateField;

	private static readonly set_lightmapsModeDelegate set_lightmapsModeDelegateField;

	private static readonly ResetDelegate ResetDelegateField;

	private static readonly get_lightProbes_InjectedDelegate get_lightProbes_InjectedDelegateField;

	private static readonly set_lightProbes_InjectedDelegate set_lightProbes_InjectedDelegateField;

	public static Il2CppReferenceArray<LightmapData> lightmaps
	{
		get
		{
			IntPtr intPtr = get_lightmapsDelegateField();
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightmapData>>(intPtr) : null;
		}
		set
		{
			set_lightmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static LightmapsMode lightmapsMode
	{
		get
		{
			return get_lightmapsModeDelegateField();
		}
		set
		{
			set_lightmapsModeDelegateField(value);
		}
	}

	public static LightProbes lightProbes
	{
		get
		{
			return Unmarshal.UnmarshalUnityObject<LightProbes>(get_lightProbes_Injected());
		}
		set
		{
			set_lightProbes_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public static LightmapsModeLegacy lightmapsModeLegacy
	{
		get
		{
			return LightmapsModeLegacy.Single;
		}
		set
		{
		}
	}

	public static ColorSpace bakedColorSpace
	{
		get
		{
			return QualitySettings.desiredColorSpace;
		}
		set
		{
		}
	}

	static LightmapSettings()
	{
		Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr);
		get_lightmapsDelegateField = IL2CPP.ResolveICall<get_lightmapsDelegate>("UnityEngine.LightmapSettings::get_lightmaps");
		set_lightmapsDelegateField = IL2CPP.ResolveICall<set_lightmapsDelegate>("UnityEngine.LightmapSettings::set_lightmaps");
		get_lightmapsModeDelegateField = IL2CPP.ResolveICall<get_lightmapsModeDelegate>("UnityEngine.LightmapSettings::get_lightmapsMode");
		set_lightmapsModeDelegateField = IL2CPP.ResolveICall<set_lightmapsModeDelegate>("UnityEngine.LightmapSettings::set_lightmapsMode");
		ResetDelegateField = IL2CPP.ResolveICall<ResetDelegate>("UnityEngine.LightmapSettings::Reset");
		get_lightProbes_InjectedDelegateField = IL2CPP.ResolveICall<get_lightProbes_InjectedDelegate>("UnityEngine.LightmapSettings::get_lightProbes_Injected");
		set_lightProbes_InjectedDelegateField = IL2CPP.ResolveICall<set_lightProbes_InjectedDelegate>("UnityEngine.LightmapSettings::set_lightProbes_Injected");
	}

	public LightmapSettings(IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Reset()
	{
		ResetDelegateField();
	}

	public static IntPtr get_lightProbes_Injected()
	{
		return get_lightProbes_InjectedDelegateField();
	}

	public static void set_lightProbes_Injected(IntPtr value)
	{
		set_lightProbes_InjectedDelegateField(value);
	}
}
