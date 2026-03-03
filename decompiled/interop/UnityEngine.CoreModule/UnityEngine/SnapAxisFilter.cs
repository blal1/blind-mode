using Il2CppSystem;

namespace UnityEngine;

public struct SnapAxisFilter
{
	public const SnapAxis X = SnapAxis.X;

	public const SnapAxis Y = SnapAxis.Y;

	public const SnapAxis Z = SnapAxis.Z;

	public SnapAxis m_Mask;

	public float x => ((m_Mask & SnapAxis.X) == SnapAxis.X) ? 1f : 0f;

	public float y => ((m_Mask & SnapAxis.Y) == SnapAxis.Y) ? 1f : 0f;

	public float z => ((m_Mask & SnapAxis.Z) == SnapAxis.Z) ? 1f : 0f;

	public int active
	{
		get
		{
			int num = 0;
			if ((int)(m_Mask & SnapAxis.X) > 0)
			{
				num++;
			}
			if ((int)(m_Mask & SnapAxis.Y) > 0)
			{
				num++;
			}
			if ((int)(m_Mask & SnapAxis.Z) > 0)
			{
				num++;
			}
			return num;
		}
	}

	public float Item
	{
		get
		{
			if (i < 0 || i > 2)
			{
				throw new IndexOutOfRangeException();
			}
			return (float)(1 & ((int)m_Mask >> i)) * 1f;
		}
		set
		{
			if (i < 0 || i > 2)
			{
				throw new IndexOutOfRangeException();
			}
			m_Mask &= (SnapAxis)(byte)(~(1 << i));
			m_Mask |= (SnapAxis)(byte)(((value > 0f) ? 1u : 0u) << i);
		}
	}

	public override string ToString()
	{
		return String.Format("{{{0}, {1}, {2}}}", (Il2CppSystem.Object)(object)x, (Il2CppSystem.Object)(object)y, (Il2CppSystem.Object)(object)z);
	}

	public static implicit operator Vector3(SnapAxisFilter mask)
	{
		return new Vector3(mask.x, mask.y, mask.z);
	}

	public static explicit operator SnapAxisFilter(Vector3 v)
	{
		return new SnapAxisFilter(v);
	}

	public static explicit operator SnapAxis(SnapAxisFilter mask)
	{
		return mask.m_Mask;
	}

	public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
	{
		return new SnapAxisFilter(left.m_Mask | right.m_Mask);
	}

	public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
	{
		return new SnapAxisFilter(left.m_Mask & right.m_Mask);
	}

	public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
	{
		return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
	}

	public static SnapAxisFilter operator ~(SnapAxisFilter left)
	{
		return new SnapAxisFilter((SnapAxis)(~(uint)left.m_Mask));
	}

	public static Vector3 operator *(SnapAxisFilter mask, float value)
	{
		return new Vector3(mask.x * value, mask.y * value, mask.z * value);
	}

	public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
	{
		return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
	}

	public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
	{
		int num = mask.active;
		if (num > 2)
		{
			return mask;
		}
		Vector3 vector = rotation * (Vector3)mask;
		vector = new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
		if (num > 1)
		{
			return new Vector3((vector.x > vector.y || vector.x > vector.z) ? 1 : 0, (vector.y > vector.x || vector.y > vector.z) ? 1 : 0, (vector.z > vector.x || vector.z > vector.y) ? 1 : 0);
		}
		return new Vector3((vector.x > vector.y && vector.x > vector.z) ? 1 : 0, (vector.y > vector.z && vector.y > vector.x) ? 1 : 0, (vector.z > vector.x && vector.z > vector.y) ? 1 : 0);
	}

	public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
	{
		return left.m_Mask == right.m_Mask;
	}

	public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right)
	{
		return !(left == right);
	}

	public bool Equals(SnapAxisFilter other)
	{
		return m_Mask == other.m_Mask;
	}

	public bool Equals(Il2CppSystem.Object obj)
	{
		if (obj == null)
		{
			return false;
		}
		return obj is SnapAxisFilter && Equals((SnapAxisFilter)(object)obj);
	}

	public override int GetHashCode()
	{
		return ((Il2CppSystem.Object)m_Mask).GetHashCode();
	}
}
