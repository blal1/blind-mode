using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class CustomCollider2D : Collider2D
{
	private delegate int get_customShapeCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_customVertexCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetCustomShapesNative_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount);

	private delegate void SetCustomShapesNative_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount);

	private delegate void SetCustomShapeNative_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex);

	private delegate void ClearCustomShapes_Internal_InjectedDelegate(System.IntPtr _unity_self, int shapeIndex, int shapeCount);

	private delegate void ClearCustomShapes_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly get_customShapeCount_InjectedDelegate get_customShapeCount_InjectedDelegateField = IL2CPP.ResolveICall<get_customShapeCount_InjectedDelegate>("UnityEngine.CustomCollider2D::get_customShapeCount_Injected");

	private static readonly get_customVertexCount_InjectedDelegate get_customVertexCount_InjectedDelegateField = IL2CPP.ResolveICall<get_customVertexCount_InjectedDelegate>("UnityEngine.CustomCollider2D::get_customVertexCount_Injected");

	private static readonly GetCustomShapesNative_Internal_InjectedDelegate GetCustomShapesNative_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetCustomShapesNative_Internal_InjectedDelegate>("UnityEngine.CustomCollider2D::GetCustomShapesNative_Internal_Injected");

	private static readonly SetCustomShapesNative_Internal_InjectedDelegate SetCustomShapesNative_Internal_InjectedDelegateField = IL2CPP.ResolveICall<SetCustomShapesNative_Internal_InjectedDelegate>("UnityEngine.CustomCollider2D::SetCustomShapesNative_Internal_Injected");

	private static readonly SetCustomShapeNative_Internal_InjectedDelegate SetCustomShapeNative_Internal_InjectedDelegateField = IL2CPP.ResolveICall<SetCustomShapeNative_Internal_InjectedDelegate>("UnityEngine.CustomCollider2D::SetCustomShapeNative_Internal_Injected");

	private static readonly ClearCustomShapes_Internal_InjectedDelegate ClearCustomShapes_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ClearCustomShapes_Internal_InjectedDelegate>("UnityEngine.CustomCollider2D::ClearCustomShapes_Internal_Injected");

	private static readonly ClearCustomShapes_InjectedDelegate ClearCustomShapes_InjectedDelegateField = IL2CPP.ResolveICall<ClearCustomShapes_InjectedDelegate>("UnityEngine.CustomCollider2D::ClearCustomShapes_Injected");

	public int customShapeCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_customShapeCount_Injected(intPtr);
		}
	}

	public int customVertexCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_customVertexCount_Injected(intPtr);
		}
	}

	public int GetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, [Optional] int shapeCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetCustomShapesNative_Internal(System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCustomShapesNative_Internal_Injected(intPtr, shapesPtr, shapeCount, verticesPtr, vertexCount);
	}

	public void SetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetCustomShapesNative_Internal(System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetCustomShapesNative_Internal_Injected(intPtr, shapesPtr, shapeCount, verticesPtr, vertexCount);
	}

	public void SetCustomShape(PhysicsShapeGroup2D physicsShapeGroup, int srcShapeIndex, int dstShapeIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetCustomShapeNative_Internal(System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetCustomShapeNative_Internal_Injected(intPtr, shapesPtr, shapeCount, verticesPtr, vertexCount, srcShapeIndex, dstShapeIndex);
	}

	public void ClearCustomShapes(int shapeIndex, int shapeCount)
	{
		int num = customShapeCount;
		if (shapeIndex < 0 || shapeIndex >= num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Cannot clear custom shape(s) at index {0} as the CustomCollider2D only has {1} shape(s).", (Il2CppSystem.Object)(object)shapeIndex, (Il2CppSystem.Object)(object)num));
		}
		if (shapeIndex + shapeCount < 0 || shapeIndex + shapeCount > customShapeCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Cannot clear custom shape(s) in the range (index {0}, count {1}) as this range is outside range of the existing {2} shape(s).", (Il2CppSystem.Object)(object)shapeIndex, (Il2CppSystem.Object)(object)shapeCount, (Il2CppSystem.Object)(object)customShapeCount));
		}
		ClearCustomShapes_Internal(shapeIndex, shapeCount);
	}

	public void ClearCustomShapes_Internal(int shapeIndex, int shapeCount)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearCustomShapes_Internal_Injected(intPtr, shapeIndex, shapeCount);
	}

	public void ClearCustomShapes()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearCustomShapes_Injected(intPtr);
	}

	public static int get_customShapeCount_Injected(System.IntPtr _unity_self)
	{
		return get_customShapeCount_InjectedDelegateField(_unity_self);
	}

	public static int get_customVertexCount_Injected(System.IntPtr _unity_self)
	{
		return get_customVertexCount_InjectedDelegateField(_unity_self);
	}

	public static int GetCustomShapesNative_Internal_Injected(System.IntPtr _unity_self, System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount)
	{
		return GetCustomShapesNative_Internal_InjectedDelegateField(_unity_self, shapesPtr, shapeCount, verticesPtr, vertexCount);
	}

	public static void SetCustomShapesNative_Internal_Injected(System.IntPtr _unity_self, System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount)
	{
		SetCustomShapesNative_Internal_InjectedDelegateField(_unity_self, shapesPtr, shapeCount, verticesPtr, vertexCount);
	}

	public static void SetCustomShapeNative_Internal_Injected(System.IntPtr _unity_self, System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex)
	{
		SetCustomShapeNative_Internal_InjectedDelegateField(_unity_self, shapesPtr, shapeCount, verticesPtr, vertexCount, srcShapeIndex, dstShapeIndex);
	}

	public static void ClearCustomShapes_Internal_Injected(System.IntPtr _unity_self, int shapeIndex, int shapeCount)
	{
		ClearCustomShapes_Internal_InjectedDelegateField(_unity_self, shapeIndex, shapeCount);
	}

	public static void ClearCustomShapes_Injected(System.IntPtr _unity_self)
	{
		ClearCustomShapes_InjectedDelegateField(_unity_self);
	}
}
