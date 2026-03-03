using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public sealed class NavMeshData : Object
{
	private delegate void Internal_CreateDelegate(IntPtr mono, int agentTypeID);

	private delegate void get_sourceBounds_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void get_position_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_position_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_rotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_rotation_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_hasHeightMeshData_InjectedDelegate(IntPtr _unity_self);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.AI.NavMeshData::Internal_Create");

	private static readonly get_sourceBounds_InjectedDelegate get_sourceBounds_InjectedDelegateField = IL2CPP.ResolveICall<get_sourceBounds_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_sourceBounds_Injected");

	private static readonly get_position_InjectedDelegate get_position_InjectedDelegateField = IL2CPP.ResolveICall<get_position_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_position_Injected");

	private static readonly set_position_InjectedDelegate set_position_InjectedDelegateField = IL2CPP.ResolveICall<set_position_InjectedDelegate>("UnityEngine.AI.NavMeshData::set_position_Injected");

	private static readonly get_rotation_InjectedDelegate get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<get_rotation_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_rotation_Injected");

	private static readonly set_rotation_InjectedDelegate set_rotation_InjectedDelegateField = IL2CPP.ResolveICall<set_rotation_InjectedDelegate>("UnityEngine.AI.NavMeshData::set_rotation_Injected");

	private static readonly get_hasHeightMeshData_InjectedDelegate get_hasHeightMeshData_InjectedDelegateField = IL2CPP.ResolveICall<get_hasHeightMeshData_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_hasHeightMeshData_Injected");

	public Bounds sourceBounds
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_sourceBounds_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Vector3 position
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_position_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_position_Injected(intPtr, ref value);
		}
	}

	public Quaternion rotation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_rotation_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rotation_Injected(intPtr, ref value);
		}
	}

	public bool hasHeightMeshData
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hasHeightMeshData_Injected(intPtr);
		}
	}

	public static void Internal_Create(NavMeshData mono, int agentTypeID)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono), agentTypeID);
	}

	public unsafe static void get_sourceBounds_Injected(IntPtr _unity_self, out Bounds ret)
	{
		get_sourceBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_position_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_position_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_position_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_position_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret)
	{
		get_rotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_rotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
	{
		set_rotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_hasHeightMeshData_Injected(IntPtr _unity_self)
	{
		return get_hasHeightMeshData_InjectedDelegateField(_unity_self);
	}
}
