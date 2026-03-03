using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class LensFlare : Behaviour
{
	private delegate float get_brightness_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_brightness_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_fadeSpeed_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_fadeSpeed_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_color_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_color_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate IntPtr get_flare_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_flare_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly get_brightness_InjectedDelegate get_brightness_InjectedDelegateField;

	private static readonly set_brightness_InjectedDelegate set_brightness_InjectedDelegateField;

	private static readonly get_fadeSpeed_InjectedDelegate get_fadeSpeed_InjectedDelegateField;

	private static readonly set_fadeSpeed_InjectedDelegate set_fadeSpeed_InjectedDelegateField;

	private static readonly get_color_InjectedDelegate get_color_InjectedDelegateField;

	private static readonly set_color_InjectedDelegate set_color_InjectedDelegateField;

	private static readonly get_flare_InjectedDelegate get_flare_InjectedDelegateField;

	private static readonly set_flare_InjectedDelegate set_flare_InjectedDelegateField;

	public float brightness
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_brightness_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_brightness_Injected(intPtr, value);
		}
	}

	public float fadeSpeed
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fadeSpeed_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fadeSpeed_Injected(intPtr, value);
		}
	}

	public Color color
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_color_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_color_Injected(intPtr, ref value);
		}
	}

	public Flare flare
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Flare>(get_flare_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flare_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	static LensFlare()
	{
		Il2CppClassPointerStore<LensFlare>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LensFlare");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlare>.NativeClassPtr);
		get_brightness_InjectedDelegateField = IL2CPP.ResolveICall<get_brightness_InjectedDelegate>("UnityEngine.LensFlare::get_brightness_Injected");
		set_brightness_InjectedDelegateField = IL2CPP.ResolveICall<set_brightness_InjectedDelegate>("UnityEngine.LensFlare::set_brightness_Injected");
		get_fadeSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_fadeSpeed_InjectedDelegate>("UnityEngine.LensFlare::get_fadeSpeed_Injected");
		set_fadeSpeed_InjectedDelegateField = IL2CPP.ResolveICall<set_fadeSpeed_InjectedDelegate>("UnityEngine.LensFlare::set_fadeSpeed_Injected");
		get_color_InjectedDelegateField = IL2CPP.ResolveICall<get_color_InjectedDelegate>("UnityEngine.LensFlare::get_color_Injected");
		set_color_InjectedDelegateField = IL2CPP.ResolveICall<set_color_InjectedDelegate>("UnityEngine.LensFlare::set_color_Injected");
		get_flare_InjectedDelegateField = IL2CPP.ResolveICall<get_flare_InjectedDelegate>("UnityEngine.LensFlare::get_flare_Injected");
		set_flare_InjectedDelegateField = IL2CPP.ResolveICall<set_flare_InjectedDelegate>("UnityEngine.LensFlare::set_flare_Injected");
	}

	public LensFlare(IntPtr pointer)
		: base(pointer)
	{
	}

	public static float get_brightness_Injected(IntPtr _unity_self)
	{
		return get_brightness_InjectedDelegateField(_unity_self);
	}

	public static void set_brightness_Injected(IntPtr _unity_self, float value)
	{
		set_brightness_InjectedDelegateField(_unity_self, value);
	}

	public static float get_fadeSpeed_Injected(IntPtr _unity_self)
	{
		return get_fadeSpeed_InjectedDelegateField(_unity_self);
	}

	public static void set_fadeSpeed_Injected(IntPtr _unity_self, float value)
	{
		set_fadeSpeed_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_color_Injected(IntPtr _unity_self, out Color ret)
	{
		get_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
	{
		set_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static IntPtr get_flare_Injected(IntPtr _unity_self)
	{
		return get_flare_InjectedDelegateField(_unity_self);
	}

	public static void set_flare_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_flare_InjectedDelegateField(_unity_self, value);
	}
}
