using System;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
public struct Pose
{
	public Vector3 position;

	public Quaternion rotation;

	public Vector3 forward => rotation * Vector3.forward;

	public Vector3 right => rotation * Vector3.right;

	public Vector3 up => rotation * Vector3.up;

	public static Pose identity
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public override string ToString()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public string ToString(string format)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Pose GetTransformedBy(Pose lhs)
	{
		Pose result = default(Pose);
		result.position = lhs.position + lhs.rotation * position;
		result.rotation = lhs.rotation * rotation;
		return result;
	}

	public Pose GetTransformedBy(Transform lhs)
	{
		Pose result = default(Pose);
		result.position = lhs.TransformPoint(position);
		result.rotation = lhs.rotation * rotation;
		return result;
	}

	public bool Equals(Il2CppSystem.Object obj)
	{
		if (!(obj is Pose))
		{
			return false;
		}
		return Equals((Pose)(object)obj);
	}

	public bool Equals(Pose other)
	{
		return position.Equals(other.position) && rotation.Equals(other.rotation);
	}

	public override int GetHashCode()
	{
		return ((Il2CppSystem.Object)position).GetHashCode() ^ (((Il2CppSystem.Object)rotation).GetHashCode() << 1);
	}

	public static bool operator ==(Pose a, Pose b)
	{
		return a.position == b.position && a.rotation.Equals(b.rotation);
	}

	public static bool operator !=(Pose a, Pose b)
	{
		return !(a == b);
	}
}
