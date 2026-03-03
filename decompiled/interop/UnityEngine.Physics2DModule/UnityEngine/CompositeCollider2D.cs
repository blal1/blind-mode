using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class CompositeCollider2D : Collider2D
{
	public enum GeometryType
	{
		Outlines,
		Polygons
	}

	public enum GenerationType
	{
		Synchronous,
		Manual
	}

	private delegate GeometryType get_geometryType_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_geometryType_InjectedDelegate(System.IntPtr _unity_self, GeometryType value);

	private delegate GenerationType get_generationType_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_generationType_InjectedDelegate(System.IntPtr _unity_self, GenerationType value);

	private delegate bool get_useDelaunayMesh_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useDelaunayMesh_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_vertexDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_vertexDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_edgeRadius_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_edgeRadius_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_offsetDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_offsetDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void GenerateGeometry_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetCompositedColliders_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr colliders);

	private delegate int GetPathPointCount_Internal_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate int get_pathCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_pointCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetPathArray_Internal_InjectedDelegate(System.IntPtr _unity_self, int index, System.IntPtr points);

	private delegate int GetPathList_Internal_InjectedDelegate(System.IntPtr _unity_self, int index, System.IntPtr points);

	private static readonly get_geometryType_InjectedDelegate get_geometryType_InjectedDelegateField = IL2CPP.ResolveICall<get_geometryType_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_geometryType_Injected");

	private static readonly set_geometryType_InjectedDelegate set_geometryType_InjectedDelegateField = IL2CPP.ResolveICall<set_geometryType_InjectedDelegate>("UnityEngine.CompositeCollider2D::set_geometryType_Injected");

	private static readonly get_generationType_InjectedDelegate get_generationType_InjectedDelegateField = IL2CPP.ResolveICall<get_generationType_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_generationType_Injected");

	private static readonly set_generationType_InjectedDelegate set_generationType_InjectedDelegateField = IL2CPP.ResolveICall<set_generationType_InjectedDelegate>("UnityEngine.CompositeCollider2D::set_generationType_Injected");

	private static readonly get_useDelaunayMesh_InjectedDelegate get_useDelaunayMesh_InjectedDelegateField = IL2CPP.ResolveICall<get_useDelaunayMesh_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_useDelaunayMesh_Injected");

	private static readonly set_useDelaunayMesh_InjectedDelegate set_useDelaunayMesh_InjectedDelegateField = IL2CPP.ResolveICall<set_useDelaunayMesh_InjectedDelegate>("UnityEngine.CompositeCollider2D::set_useDelaunayMesh_Injected");

	private static readonly get_vertexDistance_InjectedDelegate get_vertexDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_vertexDistance_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_vertexDistance_Injected");

	private static readonly set_vertexDistance_InjectedDelegate set_vertexDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_vertexDistance_InjectedDelegate>("UnityEngine.CompositeCollider2D::set_vertexDistance_Injected");

	private static readonly get_edgeRadius_InjectedDelegate get_edgeRadius_InjectedDelegateField = IL2CPP.ResolveICall<get_edgeRadius_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_edgeRadius_Injected");

	private static readonly set_edgeRadius_InjectedDelegate set_edgeRadius_InjectedDelegateField = IL2CPP.ResolveICall<set_edgeRadius_InjectedDelegate>("UnityEngine.CompositeCollider2D::set_edgeRadius_Injected");

	private static readonly get_offsetDistance_InjectedDelegate get_offsetDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_offsetDistance_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_offsetDistance_Injected");

	private static readonly set_offsetDistance_InjectedDelegate set_offsetDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_offsetDistance_InjectedDelegate>("UnityEngine.CompositeCollider2D::set_offsetDistance_Injected");

	private static readonly GenerateGeometry_InjectedDelegate GenerateGeometry_InjectedDelegateField = IL2CPP.ResolveICall<GenerateGeometry_InjectedDelegate>("UnityEngine.CompositeCollider2D::GenerateGeometry_Injected");

	private static readonly GetCompositedColliders_InjectedDelegate GetCompositedColliders_InjectedDelegateField = IL2CPP.ResolveICall<GetCompositedColliders_InjectedDelegate>("UnityEngine.CompositeCollider2D::GetCompositedColliders_Injected");

	private static readonly GetPathPointCount_Internal_InjectedDelegate GetPathPointCount_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetPathPointCount_Internal_InjectedDelegate>("UnityEngine.CompositeCollider2D::GetPathPointCount_Internal_Injected");

	private static readonly get_pathCount_InjectedDelegate get_pathCount_InjectedDelegateField = IL2CPP.ResolveICall<get_pathCount_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_pathCount_Injected");

	private static readonly get_pointCount_InjectedDelegate get_pointCount_InjectedDelegateField = IL2CPP.ResolveICall<get_pointCount_InjectedDelegate>("UnityEngine.CompositeCollider2D::get_pointCount_Injected");

	private static readonly GetPathArray_Internal_InjectedDelegate GetPathArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetPathArray_Internal_InjectedDelegate>("UnityEngine.CompositeCollider2D::GetPathArray_Internal_Injected");

	private static readonly GetPathList_Internal_InjectedDelegate GetPathList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetPathList_Internal_InjectedDelegate>("UnityEngine.CompositeCollider2D::GetPathList_Internal_Injected");

	public GeometryType geometryType
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_geometryType_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_geometryType_Injected(intPtr, value);
		}
	}

	public GenerationType generationType
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_generationType_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_generationType_Injected(intPtr, value);
		}
	}

	public bool useDelaunayMesh
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useDelaunayMesh_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useDelaunayMesh_Injected(intPtr, value);
		}
	}

	public float vertexDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vertexDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_vertexDistance_Injected(intPtr, value);
		}
	}

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

	public float offsetDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_offsetDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_offsetDistance_Injected(intPtr, value);
		}
	}

	public int pathCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pathCount_Injected(intPtr);
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

	public void GenerateGeometry()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GenerateGeometry_Injected(intPtr);
	}

	public int GetCompositedColliders(List<Collider2D> colliders)
	{
		if (colliders == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(colliders, "colliders");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCompositedColliders_Injected(intPtr, colliders);
	}

	public int GetPathPointCount(int index)
	{
		int num = pathCount - 1;
		if (index < 0 || index > num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("Path index {0} must be in the range of 0 to {1}.", (Il2CppSystem.Object)(object)index, (Il2CppSystem.Object)(object)num));
		}
		return GetPathPointCount_Internal(index);
	}

	public int GetPathPointCount_Internal(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPathPointCount_Internal_Injected(intPtr, index);
	}

	public int GetPath(int index, Il2CppStructArray<Vector2> points)
	{
		if (index < 0 || index >= pathCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("Path index {0} must be in the range of 0 to {1}.", (Il2CppSystem.Object)(object)index, (Il2CppSystem.Object)(object)(pathCount - 1)));
		}
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		return GetPathArray_Internal(index, points);
	}

	public unsafe int GetPathArray_Internal(int index, Il2CppStructArray<Vector2> points)
	{
		//IL_0028: Expected O, but got Ref
		//IL_002f: Expected O, but got Ref
		//IL_003b: Expected O, but got Ref
		if (points == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)points, "points");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)points);
		int pathArray_Internal_Injected;
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper points2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			pathArray_Internal_Injected = GetPathArray_Internal_Injected(intPtr, index, ref points2);
		}
		return pathArray_Internal_Injected;
	}

	public int GetPath(int index, List<Vector2> points)
	{
		if (index < 0 || index >= pathCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("Path index {0} must be in the range of 0 to {1}.", (Il2CppSystem.Object)(object)index, (Il2CppSystem.Object)(object)(pathCount - 1)));
		}
		if (points == null)
		{
			throw new Il2CppSystem.ArgumentNullException("points");
		}
		return GetPathList_Internal(index, points);
	}

	public int GetPathList_Internal(int index, List<Vector2> points)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static GeometryType get_geometryType_Injected(System.IntPtr _unity_self)
	{
		return get_geometryType_InjectedDelegateField(_unity_self);
	}

	public static void set_geometryType_Injected(System.IntPtr _unity_self, GeometryType value)
	{
		set_geometryType_InjectedDelegateField(_unity_self, value);
	}

	public static GenerationType get_generationType_Injected(System.IntPtr _unity_self)
	{
		return get_generationType_InjectedDelegateField(_unity_self);
	}

	public static void set_generationType_Injected(System.IntPtr _unity_self, GenerationType value)
	{
		set_generationType_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useDelaunayMesh_Injected(System.IntPtr _unity_self)
	{
		return get_useDelaunayMesh_InjectedDelegateField(_unity_self);
	}

	public static void set_useDelaunayMesh_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useDelaunayMesh_InjectedDelegateField(_unity_self, value);
	}

	public static float get_vertexDistance_Injected(System.IntPtr _unity_self)
	{
		return get_vertexDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_vertexDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_vertexDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_edgeRadius_Injected(System.IntPtr _unity_self)
	{
		return get_edgeRadius_InjectedDelegateField(_unity_self);
	}

	public static void set_edgeRadius_Injected(System.IntPtr _unity_self, float value)
	{
		set_edgeRadius_InjectedDelegateField(_unity_self, value);
	}

	public static float get_offsetDistance_Injected(System.IntPtr _unity_self)
	{
		return get_offsetDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_offsetDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_offsetDistance_InjectedDelegateField(_unity_self, value);
	}

	public static void GenerateGeometry_Injected(System.IntPtr _unity_self)
	{
		GenerateGeometry_InjectedDelegateField(_unity_self);
	}

	public static int GetCompositedColliders_Injected(System.IntPtr _unity_self, List<Collider2D> colliders)
	{
		return GetCompositedColliders_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colliders));
	}

	public static int GetPathPointCount_Internal_Injected(System.IntPtr _unity_self, int index)
	{
		return GetPathPointCount_Internal_InjectedDelegateField(_unity_self, index);
	}

	public static int get_pathCount_Injected(System.IntPtr _unity_self)
	{
		return get_pathCount_InjectedDelegateField(_unity_self);
	}

	public static int get_pointCount_Injected(System.IntPtr _unity_self)
	{
		return get_pointCount_InjectedDelegateField(_unity_self);
	}

	public unsafe static int GetPathArray_Internal_Injected(System.IntPtr _unity_self, int index, ref ManagedSpanWrapper points)
	{
		return GetPathArray_Internal_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref points));
	}

	public unsafe static int GetPathList_Internal_Injected(System.IntPtr _unity_self, int index, ref BlittableListWrapper points)
	{
		return GetPathList_Internal_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref points));
	}
}
