using System;
using System.Runtime.InteropServices;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public class PhysicsShapeGroup2D
{
	public const float MinVertexSeparation = 0.0025f;

	public List<Vector2> groupVertices
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int shapeCount
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int vertexCount
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Matrix4x4 localToWorldMatrix
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void Clear()
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void Add(PhysicsShapeGroup2D physicsShapeGroup)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void GetShapeVertices(int shapeIndex, List<Vector2> vertices)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public Vector2 GetShapeVertex(int shapeIndex, int vertexIndex)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetShapeVertex(int shapeIndex, int vertexIndex, Vector2 vertex)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetShapeRadius(int shapeIndex, float radius)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetShapeAdjacentVertices(int shapeIndex, bool useAdjacentStart, bool useAdjacentEnd, Vector2 adjacentStart, Vector2 adjacentEnd)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void DeleteShape(int shapeIndex)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int AddCircle(Vector2 center, float radius)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int AddCapsule(Vector2 vertex0, Vector2 vertex1, float radius)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int AddBox(Vector2 center, Vector2 size, [Optional] float angle, [Optional] float edgeRadius)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int AddPolygon(List<Vector2> vertices)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int AddEdges(List<Vector2> vertices, [Optional] float edgeRadius)
	{
		return AddEdges(vertices, useAdjacentStart: false, useAdjacentEnd: false, Vector2.zero, Vector2.zero, edgeRadius);
	}

	public int AddEdges(List<Vector2> vertices, bool useAdjacentStart, bool useAdjacentEnd, Vector2 adjacentStart, Vector2 adjacentEnd, [Optional] float edgeRadius)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static Vector2 _003CAddBox_003Eg__Rotate_007C28_0(float cos, float sin, Vector2 value)
	{
		return new Vector2(cos * value.x - sin * value.y, sin * value.x + cos * value.y);
	}
}
