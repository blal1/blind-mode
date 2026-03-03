using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Projector : Behaviour
{
	private delegate float get_nearClipPlane_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_nearClipPlane_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_farClipPlane_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_farClipPlane_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_fieldOfView_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_fieldOfView_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_aspectRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_aspectRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_orthographic_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_orthographic_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_orthographicSize_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_orthographicSize_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_ignoreLayers_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_ignoreLayers_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate IntPtr get_material_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_material_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly get_nearClipPlane_InjectedDelegate get_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<get_nearClipPlane_InjectedDelegate>("UnityEngine.Projector::get_nearClipPlane_Injected");

	private static readonly set_nearClipPlane_InjectedDelegate set_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<set_nearClipPlane_InjectedDelegate>("UnityEngine.Projector::set_nearClipPlane_Injected");

	private static readonly get_farClipPlane_InjectedDelegate get_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<get_farClipPlane_InjectedDelegate>("UnityEngine.Projector::get_farClipPlane_Injected");

	private static readonly set_farClipPlane_InjectedDelegate set_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<set_farClipPlane_InjectedDelegate>("UnityEngine.Projector::set_farClipPlane_Injected");

	private static readonly get_fieldOfView_InjectedDelegate get_fieldOfView_InjectedDelegateField = IL2CPP.ResolveICall<get_fieldOfView_InjectedDelegate>("UnityEngine.Projector::get_fieldOfView_Injected");

	private static readonly set_fieldOfView_InjectedDelegate set_fieldOfView_InjectedDelegateField = IL2CPP.ResolveICall<set_fieldOfView_InjectedDelegate>("UnityEngine.Projector::set_fieldOfView_Injected");

	private static readonly get_aspectRatio_InjectedDelegate get_aspectRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_aspectRatio_InjectedDelegate>("UnityEngine.Projector::get_aspectRatio_Injected");

	private static readonly set_aspectRatio_InjectedDelegate set_aspectRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_aspectRatio_InjectedDelegate>("UnityEngine.Projector::set_aspectRatio_Injected");

	private static readonly get_orthographic_InjectedDelegate get_orthographic_InjectedDelegateField = IL2CPP.ResolveICall<get_orthographic_InjectedDelegate>("UnityEngine.Projector::get_orthographic_Injected");

	private static readonly set_orthographic_InjectedDelegate set_orthographic_InjectedDelegateField = IL2CPP.ResolveICall<set_orthographic_InjectedDelegate>("UnityEngine.Projector::set_orthographic_Injected");

	private static readonly get_orthographicSize_InjectedDelegate get_orthographicSize_InjectedDelegateField = IL2CPP.ResolveICall<get_orthographicSize_InjectedDelegate>("UnityEngine.Projector::get_orthographicSize_Injected");

	private static readonly set_orthographicSize_InjectedDelegate set_orthographicSize_InjectedDelegateField = IL2CPP.ResolveICall<set_orthographicSize_InjectedDelegate>("UnityEngine.Projector::set_orthographicSize_Injected");

	private static readonly get_ignoreLayers_InjectedDelegate get_ignoreLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_ignoreLayers_InjectedDelegate>("UnityEngine.Projector::get_ignoreLayers_Injected");

	private static readonly set_ignoreLayers_InjectedDelegate set_ignoreLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_ignoreLayers_InjectedDelegate>("UnityEngine.Projector::set_ignoreLayers_Injected");

	private static readonly get_material_InjectedDelegate get_material_InjectedDelegateField = IL2CPP.ResolveICall<get_material_InjectedDelegate>("UnityEngine.Projector::get_material_Injected");

	private static readonly set_material_InjectedDelegate set_material_InjectedDelegateField = IL2CPP.ResolveICall<set_material_InjectedDelegate>("UnityEngine.Projector::set_material_Injected");

	public float nearClipPlane
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_nearClipPlane_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_nearClipPlane_Injected(intPtr, value);
		}
	}

	public float farClipPlane
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_farClipPlane_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_farClipPlane_Injected(intPtr, value);
		}
	}

	public float fieldOfView
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fieldOfView_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fieldOfView_Injected(intPtr, value);
		}
	}

	public float aspectRatio
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_aspectRatio_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_aspectRatio_Injected(intPtr, value);
		}
	}

	public bool orthographic
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_orthographic_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_orthographic_Injected(intPtr, value);
		}
	}

	public float orthographicSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_orthographicSize_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_orthographicSize_Injected(intPtr, value);
		}
	}

	public int ignoreLayers
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_ignoreLayers_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_ignoreLayers_Injected(intPtr, value);
		}
	}

	public Material material
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Material>(get_material_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_material_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public static float get_nearClipPlane_Injected(IntPtr _unity_self)
	{
		return get_nearClipPlane_InjectedDelegateField(_unity_self);
	}

	public static void set_nearClipPlane_Injected(IntPtr _unity_self, float value)
	{
		set_nearClipPlane_InjectedDelegateField(_unity_self, value);
	}

	public static float get_farClipPlane_Injected(IntPtr _unity_self)
	{
		return get_farClipPlane_InjectedDelegateField(_unity_self);
	}

	public static void set_farClipPlane_Injected(IntPtr _unity_self, float value)
	{
		set_farClipPlane_InjectedDelegateField(_unity_self, value);
	}

	public static float get_fieldOfView_Injected(IntPtr _unity_self)
	{
		return get_fieldOfView_InjectedDelegateField(_unity_self);
	}

	public static void set_fieldOfView_Injected(IntPtr _unity_self, float value)
	{
		set_fieldOfView_InjectedDelegateField(_unity_self, value);
	}

	public static float get_aspectRatio_Injected(IntPtr _unity_self)
	{
		return get_aspectRatio_InjectedDelegateField(_unity_self);
	}

	public static void set_aspectRatio_Injected(IntPtr _unity_self, float value)
	{
		set_aspectRatio_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_orthographic_Injected(IntPtr _unity_self)
	{
		return get_orthographic_InjectedDelegateField(_unity_self);
	}

	public static void set_orthographic_Injected(IntPtr _unity_self, bool value)
	{
		set_orthographic_InjectedDelegateField(_unity_self, value);
	}

	public static float get_orthographicSize_Injected(IntPtr _unity_self)
	{
		return get_orthographicSize_InjectedDelegateField(_unity_self);
	}

	public static void set_orthographicSize_Injected(IntPtr _unity_self, float value)
	{
		set_orthographicSize_InjectedDelegateField(_unity_self, value);
	}

	public static int get_ignoreLayers_Injected(IntPtr _unity_self)
	{
		return get_ignoreLayers_InjectedDelegateField(_unity_self);
	}

	public static void set_ignoreLayers_Injected(IntPtr _unity_self, int value)
	{
		set_ignoreLayers_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_material_Injected(IntPtr _unity_self)
	{
		return get_material_InjectedDelegateField(_unity_self);
	}

	public static void set_material_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_material_InjectedDelegateField(_unity_self, value);
	}
}
