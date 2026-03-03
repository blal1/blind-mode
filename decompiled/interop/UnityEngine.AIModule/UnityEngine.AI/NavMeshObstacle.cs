using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public sealed class NavMeshObstacle : Behaviour
{
	private delegate float get_height_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_height_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_radius_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_velocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_velocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_carving_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_carving_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_carveOnlyStationary_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_carveOnlyStationary_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_carvingMoveThreshold_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_carvingMoveThreshold_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_carvingTimeToStationary_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_carvingTimeToStationary_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate NavMeshObstacleShape get_shape_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_shape_InjectedDelegate(IntPtr _unity_self, NavMeshObstacleShape value);

	private delegate void get_center_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_center_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_size_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_size_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void FitExtents_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_height_Injected");

	private static readonly set_height_InjectedDelegate set_height_InjectedDelegateField = IL2CPP.ResolveICall<set_height_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_height_Injected");

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_radius_Injected");

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_radius_Injected");

	private static readonly get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<get_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_velocity_Injected");

	private static readonly set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<set_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_velocity_Injected");

	private static readonly get_carving_InjectedDelegate get_carving_InjectedDelegateField = IL2CPP.ResolveICall<get_carving_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_carving_Injected");

	private static readonly set_carving_InjectedDelegate set_carving_InjectedDelegateField = IL2CPP.ResolveICall<set_carving_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_carving_Injected");

	private static readonly get_carveOnlyStationary_InjectedDelegate get_carveOnlyStationary_InjectedDelegateField = IL2CPP.ResolveICall<get_carveOnlyStationary_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_carveOnlyStationary_Injected");

	private static readonly set_carveOnlyStationary_InjectedDelegate set_carveOnlyStationary_InjectedDelegateField = IL2CPP.ResolveICall<set_carveOnlyStationary_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_carveOnlyStationary_Injected");

	private static readonly get_carvingMoveThreshold_InjectedDelegate get_carvingMoveThreshold_InjectedDelegateField = IL2CPP.ResolveICall<get_carvingMoveThreshold_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_carvingMoveThreshold_Injected");

	private static readonly set_carvingMoveThreshold_InjectedDelegate set_carvingMoveThreshold_InjectedDelegateField = IL2CPP.ResolveICall<set_carvingMoveThreshold_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_carvingMoveThreshold_Injected");

	private static readonly get_carvingTimeToStationary_InjectedDelegate get_carvingTimeToStationary_InjectedDelegateField = IL2CPP.ResolveICall<get_carvingTimeToStationary_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_carvingTimeToStationary_Injected");

	private static readonly set_carvingTimeToStationary_InjectedDelegate set_carvingTimeToStationary_InjectedDelegateField = IL2CPP.ResolveICall<set_carvingTimeToStationary_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_carvingTimeToStationary_Injected");

	private static readonly get_shape_InjectedDelegate get_shape_InjectedDelegateField = IL2CPP.ResolveICall<get_shape_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_shape_Injected");

	private static readonly set_shape_InjectedDelegate set_shape_InjectedDelegateField = IL2CPP.ResolveICall<set_shape_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_shape_Injected");

	private static readonly get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<get_center_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_center_Injected");

	private static readonly set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<set_center_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_center_Injected");

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_size_Injected");

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_size_Injected");

	private static readonly FitExtents_InjectedDelegate FitExtents_InjectedDelegateField = IL2CPP.ResolveICall<FitExtents_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::FitExtents_Injected");

	public float height
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_height_Injected(intPtr, value);
		}
	}

	public float radius
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_radius_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_radius_Injected(intPtr, value);
		}
	}

	public Vector3 velocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_velocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_velocity_Injected(intPtr, ref value);
		}
	}

	public bool carving
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_carving_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_carving_Injected(intPtr, value);
		}
	}

	public bool carveOnlyStationary
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_carveOnlyStationary_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_carveOnlyStationary_Injected(intPtr, value);
		}
	}

	public float carvingMoveThreshold
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_carvingMoveThreshold_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_carvingMoveThreshold_Injected(intPtr, value);
		}
	}

	public float carvingTimeToStationary
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_carvingTimeToStationary_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_carvingTimeToStationary_Injected(intPtr, value);
		}
	}

	public NavMeshObstacleShape shape
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shape_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shape_Injected(intPtr, value);
		}
	}

	public Vector3 center
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_center_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_center_Injected(intPtr, ref value);
		}
	}

	public Vector3 size
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_size_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_size_Injected(intPtr, ref value);
		}
	}

	public void FitExtents()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		FitExtents_Injected(intPtr);
	}

	public static float get_height_Injected(IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static void set_height_Injected(IntPtr _unity_self, float value)
	{
		set_height_InjectedDelegateField(_unity_self, value);
	}

	public static float get_radius_Injected(IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_velocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_velocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_velocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_carving_Injected(IntPtr _unity_self)
	{
		return get_carving_InjectedDelegateField(_unity_self);
	}

	public static void set_carving_Injected(IntPtr _unity_self, bool value)
	{
		set_carving_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_carveOnlyStationary_Injected(IntPtr _unity_self)
	{
		return get_carveOnlyStationary_InjectedDelegateField(_unity_self);
	}

	public static void set_carveOnlyStationary_Injected(IntPtr _unity_self, bool value)
	{
		set_carveOnlyStationary_InjectedDelegateField(_unity_self, value);
	}

	public static float get_carvingMoveThreshold_Injected(IntPtr _unity_self)
	{
		return get_carvingMoveThreshold_InjectedDelegateField(_unity_self);
	}

	public static void set_carvingMoveThreshold_Injected(IntPtr _unity_self, float value)
	{
		set_carvingMoveThreshold_InjectedDelegateField(_unity_self, value);
	}

	public static float get_carvingTimeToStationary_Injected(IntPtr _unity_self)
	{
		return get_carvingTimeToStationary_InjectedDelegateField(_unity_self);
	}

	public static void set_carvingTimeToStationary_Injected(IntPtr _unity_self, float value)
	{
		set_carvingTimeToStationary_InjectedDelegateField(_unity_self, value);
	}

	public static NavMeshObstacleShape get_shape_Injected(IntPtr _unity_self)
	{
		return get_shape_InjectedDelegateField(_unity_self);
	}

	public static void set_shape_Injected(IntPtr _unity_self, NavMeshObstacleShape value)
	{
		set_shape_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_center_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_center_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_size_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_size_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void FitExtents_Injected(IntPtr _unity_self)
	{
		FitExtents_InjectedDelegateField(_unity_self);
	}
}
