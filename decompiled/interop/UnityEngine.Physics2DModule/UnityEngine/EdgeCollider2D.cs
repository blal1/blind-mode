using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class EdgeCollider2D : Collider2D
{
	private delegate void Reset_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_edgeRadius_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_edgeRadius_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_edgeCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_pointCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_points_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_points_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int GetPoints_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr points);

	private delegate bool SetPoints_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr points);

	private delegate bool get_useAdjacentStartPoint_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useAdjacentStartPoint_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_useAdjacentEndPoint_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useAdjacentEndPoint_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_adjacentStartPoint_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_adjacentStartPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_adjacentEndPoint_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_adjacentEndPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private static readonly Reset_InjectedDelegate Reset_InjectedDelegateField = IL2CPP.ResolveICall<Reset_InjectedDelegate>("UnityEngine.EdgeCollider2D::Reset_Injected");

	private static readonly get_edgeRadius_InjectedDelegate get_edgeRadius_InjectedDelegateField = IL2CPP.ResolveICall<get_edgeRadius_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_edgeRadius_Injected");

	private static readonly set_edgeRadius_InjectedDelegate set_edgeRadius_InjectedDelegateField = IL2CPP.ResolveICall<set_edgeRadius_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_edgeRadius_Injected");

	private static readonly get_edgeCount_InjectedDelegate get_edgeCount_InjectedDelegateField = IL2CPP.ResolveICall<get_edgeCount_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_edgeCount_Injected");

	private static readonly get_pointCount_InjectedDelegate get_pointCount_InjectedDelegateField = IL2CPP.ResolveICall<get_pointCount_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_pointCount_Injected");

	private static readonly get_points_InjectedDelegate get_points_InjectedDelegateField = IL2CPP.ResolveICall<get_points_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_points_Injected");

	private static readonly set_points_InjectedDelegate set_points_InjectedDelegateField = IL2CPP.ResolveICall<set_points_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_points_Injected");

	private static readonly GetPoints_InjectedDelegate GetPoints_InjectedDelegateField = IL2CPP.ResolveICall<GetPoints_InjectedDelegate>("UnityEngine.EdgeCollider2D::GetPoints_Injected");

	private static readonly SetPoints_InjectedDelegate SetPoints_InjectedDelegateField = IL2CPP.ResolveICall<SetPoints_InjectedDelegate>("UnityEngine.EdgeCollider2D::SetPoints_Injected");

	private static readonly get_useAdjacentStartPoint_InjectedDelegate get_useAdjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_useAdjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentStartPoint_Injected");

	private static readonly set_useAdjacentStartPoint_InjectedDelegate set_useAdjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_useAdjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentStartPoint_Injected");

	private static readonly get_useAdjacentEndPoint_InjectedDelegate get_useAdjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_useAdjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_useAdjacentEndPoint_Injected");

	private static readonly set_useAdjacentEndPoint_InjectedDelegate set_useAdjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_useAdjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_useAdjacentEndPoint_Injected");

	private static readonly get_adjacentStartPoint_InjectedDelegate get_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentStartPoint_Injected");

	private static readonly set_adjacentStartPoint_InjectedDelegate set_adjacentStartPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_adjacentStartPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentStartPoint_Injected");

	private static readonly get_adjacentEndPoint_InjectedDelegate get_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<get_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::get_adjacentEndPoint_Injected");

	private static readonly set_adjacentEndPoint_InjectedDelegate set_adjacentEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<set_adjacentEndPoint_InjectedDelegate>("UnityEngine.EdgeCollider2D::set_adjacentEndPoint_Injected");

	public float edgeRadius
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_edgeRadius_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_edgeRadius_Injected(intPtr, value);
		}
	}

	public int edgeCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_edgeCount_Injected(intPtr);
		}
	}

	public int pointCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pointCount_Injected(intPtr);
		}
	}

	public unsafe Il2CppStructArray<Vector2> points
	{
		get
		{
			Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<Vector2> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_points_Injected(intPtr, out ret);
			}
			finally
			{
				Unsafe.SkipInit(out Il2CppStructArray<Vector2> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<Vector2>*)(&array));
				result = array;
			}
			return result;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_001f: Expected O, but got Ref
			//IL_002b: Expected O, but got Ref
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
			((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)value);
			fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper value2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
				set_points_Injected(intPtr, ref value2);
			}
		}
	}

	public bool useAdjacentStartPoint
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useAdjacentStartPoint_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useAdjacentStartPoint_Injected(intPtr, value);
		}
	}

	public bool useAdjacentEndPoint
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useAdjacentEndPoint_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useAdjacentEndPoint_Injected(intPtr, value);
		}
	}

	public Vector2 adjacentStartPoint
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_adjacentStartPoint_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_adjacentStartPoint_Injected(intPtr, ref value);
		}
	}

	public Vector2 adjacentEndPoint
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_adjacentEndPoint_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_adjacentEndPoint_Injected(intPtr, ref value);
		}
	}

	public void Reset()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Reset_Injected(intPtr);
	}

	public int GetPoints(List<Vector2> points)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool SetPoints(List<Vector2> points)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void Reset_Injected(System.IntPtr _unity_self)
	{
		Reset_InjectedDelegateField(_unity_self);
	}

	public static float get_edgeRadius_Injected(System.IntPtr _unity_self)
	{
		return get_edgeRadius_InjectedDelegateField(_unity_self);
	}

	public static void set_edgeRadius_Injected(System.IntPtr _unity_self, float value)
	{
		set_edgeRadius_InjectedDelegateField(_unity_self, value);
	}

	public static int get_edgeCount_Injected(System.IntPtr _unity_self)
	{
		return get_edgeCount_InjectedDelegateField(_unity_self);
	}

	public static int get_pointCount_Injected(System.IntPtr _unity_self)
	{
		return get_pointCount_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_points_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_points_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_points_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_points_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static int GetPoints_Injected(System.IntPtr _unity_self, ref BlittableListWrapper points)
	{
		return GetPoints_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref points));
	}

	public unsafe static bool SetPoints_Injected(System.IntPtr _unity_self, ref BlittableListWrapper points)
	{
		return SetPoints_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref points));
	}

	public static bool get_useAdjacentStartPoint_Injected(System.IntPtr _unity_self)
	{
		return get_useAdjacentStartPoint_InjectedDelegateField(_unity_self);
	}

	public static void set_useAdjacentStartPoint_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useAdjacentStartPoint_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useAdjacentEndPoint_Injected(System.IntPtr _unity_self)
	{
		return get_useAdjacentEndPoint_InjectedDelegateField(_unity_self);
	}

	public static void set_useAdjacentEndPoint_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useAdjacentEndPoint_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_adjacentStartPoint_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_adjacentStartPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_adjacentStartPoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_adjacentStartPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_adjacentEndPoint_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_adjacentEndPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_adjacentEndPoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_adjacentEndPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}
}
