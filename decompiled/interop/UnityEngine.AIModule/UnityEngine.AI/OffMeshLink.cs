using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public sealed class OffMeshLink : Behaviour
{
	private delegate bool get_activated_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_activated_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_occupied_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_costOverride_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_costOverride_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_biDirectional_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_biDirectional_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void UpdatePositions_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_area_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_area_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate bool get_autoUpdatePositions_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoUpdatePositions_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate IntPtr get_startTransform_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_startTransform_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate IntPtr get_endTransform_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_endTransform_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly get_activated_InjectedDelegate get_activated_InjectedDelegateField = IL2CPP.ResolveICall<get_activated_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_activated_Injected");

	private static readonly set_activated_InjectedDelegate set_activated_InjectedDelegateField = IL2CPP.ResolveICall<set_activated_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_activated_Injected");

	private static readonly get_occupied_InjectedDelegate get_occupied_InjectedDelegateField = IL2CPP.ResolveICall<get_occupied_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_occupied_Injected");

	private static readonly get_costOverride_InjectedDelegate get_costOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_costOverride_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_costOverride_Injected");

	private static readonly set_costOverride_InjectedDelegate set_costOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_costOverride_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_costOverride_Injected");

	private static readonly get_biDirectional_InjectedDelegate get_biDirectional_InjectedDelegateField = IL2CPP.ResolveICall<get_biDirectional_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_biDirectional_Injected");

	private static readonly set_biDirectional_InjectedDelegate set_biDirectional_InjectedDelegateField = IL2CPP.ResolveICall<set_biDirectional_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_biDirectional_Injected");

	private static readonly UpdatePositions_InjectedDelegate UpdatePositions_InjectedDelegateField = IL2CPP.ResolveICall<UpdatePositions_InjectedDelegate>("UnityEngine.AI.OffMeshLink::UpdatePositions_Injected");

	private static readonly get_area_InjectedDelegate get_area_InjectedDelegateField = IL2CPP.ResolveICall<get_area_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_area_Injected");

	private static readonly set_area_InjectedDelegate set_area_InjectedDelegateField = IL2CPP.ResolveICall<set_area_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_area_Injected");

	private static readonly get_autoUpdatePositions_InjectedDelegate get_autoUpdatePositions_InjectedDelegateField = IL2CPP.ResolveICall<get_autoUpdatePositions_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_autoUpdatePositions_Injected");

	private static readonly set_autoUpdatePositions_InjectedDelegate set_autoUpdatePositions_InjectedDelegateField = IL2CPP.ResolveICall<set_autoUpdatePositions_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_autoUpdatePositions_Injected");

	private static readonly get_startTransform_InjectedDelegate get_startTransform_InjectedDelegateField = IL2CPP.ResolveICall<get_startTransform_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_startTransform_Injected");

	private static readonly set_startTransform_InjectedDelegate set_startTransform_InjectedDelegateField = IL2CPP.ResolveICall<set_startTransform_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_startTransform_Injected");

	private static readonly get_endTransform_InjectedDelegate get_endTransform_InjectedDelegateField = IL2CPP.ResolveICall<get_endTransform_InjectedDelegate>("UnityEngine.AI.OffMeshLink::get_endTransform_Injected");

	private static readonly set_endTransform_InjectedDelegate set_endTransform_InjectedDelegateField = IL2CPP.ResolveICall<set_endTransform_InjectedDelegate>("UnityEngine.AI.OffMeshLink::set_endTransform_Injected");

	public bool activated
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_activated_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_activated_Injected(intPtr, value);
		}
	}

	public bool occupied
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_occupied_Injected(intPtr);
		}
	}

	public float costOverride
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_costOverride_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_costOverride_Injected(intPtr, value);
		}
	}

	public bool biDirectional
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_biDirectional_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_biDirectional_Injected(intPtr, value);
		}
	}

	public int navMeshLayer
	{
		get
		{
			return area;
		}
		set
		{
			area = value;
		}
	}

	public int area
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_area_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_area_Injected(intPtr, value);
		}
	}

	public bool autoUpdatePositions
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoUpdatePositions_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoUpdatePositions_Injected(intPtr, value);
		}
	}

	public Transform startTransform
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Transform>(get_startTransform_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_startTransform_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Transform endTransform
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Transform>(get_endTransform_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_endTransform_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public void UpdatePositions()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdatePositions_Injected(intPtr);
	}

	public static bool get_activated_Injected(IntPtr _unity_self)
	{
		return get_activated_InjectedDelegateField(_unity_self);
	}

	public static void set_activated_Injected(IntPtr _unity_self, bool value)
	{
		set_activated_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_occupied_Injected(IntPtr _unity_self)
	{
		return get_occupied_InjectedDelegateField(_unity_self);
	}

	public static float get_costOverride_Injected(IntPtr _unity_self)
	{
		return get_costOverride_InjectedDelegateField(_unity_self);
	}

	public static void set_costOverride_Injected(IntPtr _unity_self, float value)
	{
		set_costOverride_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_biDirectional_Injected(IntPtr _unity_self)
	{
		return get_biDirectional_InjectedDelegateField(_unity_self);
	}

	public static void set_biDirectional_Injected(IntPtr _unity_self, bool value)
	{
		set_biDirectional_InjectedDelegateField(_unity_self, value);
	}

	public static void UpdatePositions_Injected(IntPtr _unity_self)
	{
		UpdatePositions_InjectedDelegateField(_unity_self);
	}

	public static int get_area_Injected(IntPtr _unity_self)
	{
		return get_area_InjectedDelegateField(_unity_self);
	}

	public static void set_area_Injected(IntPtr _unity_self, int value)
	{
		set_area_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoUpdatePositions_Injected(IntPtr _unity_self)
	{
		return get_autoUpdatePositions_InjectedDelegateField(_unity_self);
	}

	public static void set_autoUpdatePositions_Injected(IntPtr _unity_self, bool value)
	{
		set_autoUpdatePositions_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_startTransform_Injected(IntPtr _unity_self)
	{
		return get_startTransform_InjectedDelegateField(_unity_self);
	}

	public static void set_startTransform_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_startTransform_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_endTransform_Injected(IntPtr _unity_self)
	{
		return get_endTransform_InjectedDelegateField(_unity_self);
	}

	public static void set_endTransform_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_endTransform_InjectedDelegateField(_unity_self, value);
	}
}
