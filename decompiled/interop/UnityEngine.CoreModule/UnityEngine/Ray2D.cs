using System;
using Il2CppSystem;

namespace UnityEngine;

public struct Ray2D
{
	public Vector2 m_Origin;

	public Vector2 m_Direction;

	public Vector2 origin
	{
		get
		{
			return m_Origin;
		}
		set
		{
			m_Origin = value;
		}
	}

	public Vector2 direction
	{
		get
		{
			return m_Direction;
		}
		set
		{
			m_Direction = value.normalized;
		}
	}

	public Vector2 GetPoint(float distance)
	{
		return m_Origin + m_Direction * distance;
	}

	public override string ToString()
	{
		return ToString(null, null);
	}

	public string ToString(string format)
	{
		return ToString(format, null);
	}

	public string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
