namespace UnityEngine.LowLevelPhysics;

public struct BoxGeometry
{
	public Vector3 m_HalfExtents;

	public Vector3 HalfExtents
	{
		get
		{
			return m_HalfExtents;
		}
		set
		{
			m_HalfExtents = value;
		}
	}

	public GeometryType GeometryType => GeometryType.Box;
}
